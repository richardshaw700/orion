from ghidra.app.decompiler import DecompInterface
from ghidra.util.task import ConsoleTaskMonitor
from java.io import File
import os
import re


STRING_KEYWORDS = [
    "Wait.For.Shot",
    "waitForShot",
    "ExtractBallClub",
    "Extract.BallClub",
    "Ball.Build",
    "Club.Build",
    "BackSpinSideSpinInference",
    "Club.Detection",
    "Ball.Impact.On.Club",
    "loadCamera",
    "StartSingleFrameCamera",
    "StartBoardFrameCamera",
    "saveShot",
    "exportPostShot",
    "loadMLModel",
]

FUNCTION_KEYWORDS = [
    "waitForShot",
    "extractBallClub",
    "ballHasMoveEnough",
    "saveShot",
    "exportPostShot",
    "loadCamera",
    "loadMLModel",
    "setCameraCallback",
    "onNewShot",
    "club",
    "spin",
]


def ensure_dir(path):
    if not os.path.isdir(path):
        os.makedirs(path)


def safe_name(name):
    return re.sub(r"[^A-Za-z0-9._-]+", "_", name)


def write_text(path, content):
    fh = open(path, "w")
    try:
        fh.write(content)
    finally:
        fh.close()


args = getScriptArgs()
if len(args) < 1:
    raise Exception("Expected output directory as first argument")

output_dir = args[0]
ensure_dir(output_dir)

listing = currentProgram.getListing()
function_manager = currentProgram.getFunctionManager()
monitor = ConsoleTaskMonitor()

interesting = {}


def add_function(func, reason):
    if func is None:
        return
    key = str(func.getEntryPoint())
    if key not in interesting:
        interesting[key] = {
            "function": func,
            "reasons": []
        }
    if reason not in interesting[key]["reasons"]:
        interesting[key]["reasons"].append(reason)


data_iter = listing.getDefinedData(True)
while data_iter.hasNext() and not monitor.isCancelled():
    data = data_iter.next()
    try:
        if not data.hasStringValue():
            continue
        value = data.getValue()
        if value is None:
            continue
        text = str(value)
    except:
        continue

    matched = []
    lower_text = text.lower()
    for keyword in STRING_KEYWORDS:
        if keyword.lower() in lower_text:
            matched.append(keyword)

    if not matched:
        continue

    refs = getReferencesTo(data.getAddress())
    for ref in refs:
        func = getFunctionContaining(ref.getFromAddress())
        if func is None:
            continue
        add_function(func, "string:" + ",".join(matched))


func_iter = function_manager.getFunctions(True)
while func_iter.hasNext() and not monitor.isCancelled():
    func = func_iter.next()
    try:
        name = func.getName(True)
    except:
        name = func.getName()
    lower_name = name.lower()
    for keyword in FUNCTION_KEYWORDS:
        if keyword.lower() in lower_name:
            add_function(func, "name:" + keyword)


decompiler = DecompInterface()
decompiler.openProgram(currentProgram)

summary_lines = []
summary_lines.append("Program: %s" % currentProgram.getName())
summary_lines.append("Matched functions: %d" % len(interesting))
summary_lines.append("")

for entry in sorted(interesting.keys()):
    func = interesting[entry]["function"]
    reasons = "; ".join(sorted(interesting[entry]["reasons"]))
    try:
        full_name = func.getName(True)
    except:
        full_name = func.getName()

    summary_lines.append("%s\t%s\t%s" % (entry, full_name, reasons))

    file_basename = "%s_%s" % (entry.replace(":", "_"), safe_name(full_name))
    result = decompiler.decompileFunction(func, 60, monitor)

    content_lines = []
    content_lines.append("FUNCTION: %s" % full_name)
    content_lines.append("ENTRY: %s" % entry)
    content_lines.append("REASONS: %s" % reasons)
    content_lines.append("")

    if result is not None and result.decompileCompleted():
        decompiled = result.getDecompiledFunction()
        if decompiled is not None:
            content_lines.append(decompiled.getC())
        else:
            content_lines.append("// Decompilation produced no function body.")
    else:
        message = ""
        try:
            message = result.getErrorMessage()
        except:
            message = "unknown error"
        content_lines.append("// Decompilation failed: %s" % message)

    write_text(os.path.join(output_dir, file_basename + ".c"), "\n".join(content_lines))


write_text(os.path.join(output_dir, "summary.txt"), "\n".join(summary_lines))
print("Wrote %d decompiled functions to %s" % (len(interesting), output_dir))
