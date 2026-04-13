// Extracts likely shot-pipeline functions by matching interesting strings and
// demangled function names, then decompiles them to text files.

import ghidra.app.decompiler.DecompInterface;
import ghidra.app.decompiler.DecompileResults;
import ghidra.app.script.GhidraScript;
import ghidra.program.model.listing.Data;
import ghidra.program.model.listing.DataIterator;
import ghidra.program.model.listing.Function;
import ghidra.program.model.listing.FunctionIterator;
import ghidra.program.model.listing.Listing;
import ghidra.program.model.symbol.Reference;

import java.io.IOException;
import java.nio.charset.StandardCharsets;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.util.ArrayList;
import java.util.Map;
import java.util.Set;
import java.util.TreeMap;
import java.util.TreeSet;

public class ExtractShotPipeline extends GhidraScript {

	private static final String[] STRING_KEYWORDS = {
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
		"loadMLModel"
	};

	private static final String[] FUNCTION_KEYWORDS = {
		"waitForShot",
		"extractBallClub",
		"ballHasMoveEnough",
		"saveShot",
		"exportPostShot",
		"loadCamera",
		"loadMLModel",
		"setCameraCallback",
		"onNewShot",
		"spin",
		"club"
	};

	private static class Match {
		final Function function;
		final Set<String> reasons = new TreeSet<>();

		Match(Function function) {
			this.function = function;
		}
	}

	@Override
	protected void run() throws Exception {
		String[] args = getScriptArgs();
		if (args.length < 1) {
			throw new IllegalArgumentException("Expected output directory as first argument");
		}

		Path outputDir = Paths.get(args[0]);
		Files.createDirectories(outputDir);

		Map<String, Match> interesting = new TreeMap<>();

		Listing listing = currentProgram.getListing();
		DataIterator dataIterator = listing.getDefinedData(true);
		while (dataIterator.hasNext() && !monitor.isCancelled()) {
			Data data = dataIterator.next();
			if (!data.hasStringValue()) {
				continue;
			}

			Object value = data.getValue();
			if (value == null) {
				continue;
			}

			String text = value.toString();
			String lower = text.toLowerCase();
			ArrayList<String> matched = new ArrayList<>();
			for (String keyword : STRING_KEYWORDS) {
				if (lower.contains(keyword.toLowerCase())) {
					matched.add(keyword);
				}
			}
			if (matched.isEmpty()) {
				continue;
			}

			Reference[] refs = getReferencesTo(data.getAddress());
			for (Reference ref : refs) {
				Function function = getFunctionContaining(ref.getFromAddress());
				addFunction(interesting, function, "string:" + String.join(",", matched));
			}
		}

		FunctionIterator functionIterator = currentProgram.getFunctionManager().getFunctions(true);
		while (functionIterator.hasNext() && !monitor.isCancelled()) {
			Function function = functionIterator.next();
			String name = function.getName(true);
			String lowerName = name.toLowerCase();
			for (String keyword : FUNCTION_KEYWORDS) {
				if (lowerName.contains(keyword.toLowerCase())) {
					addFunction(interesting, function, "name:" + keyword);
				}
			}
		}

		DecompInterface decompiler = new DecompInterface();
		decompiler.openProgram(currentProgram);

		StringBuilder summary = new StringBuilder();
		summary.append("Program: ").append(currentProgram.getName()).append('\n');
		summary.append("Matched functions: ").append(interesting.size()).append('\n').append('\n');

		for (Map.Entry<String, Match> entry : interesting.entrySet()) {
			String address = entry.getKey();
			Match match = entry.getValue();
			Function function = match.function;
			String fullName = function.getName(true);
			String reasons = String.join("; ", match.reasons);

			summary.append(address).append('\t').append(fullName).append('\t').append(reasons).append('\n');

			String fileName = address.replace(':', '_') + "_" + safeName(fullName) + ".c";
			Path filePath = outputDir.resolve(fileName);

			StringBuilder content = new StringBuilder();
			content.append("FUNCTION: ").append(fullName).append('\n');
			content.append("ENTRY: ").append(address).append('\n');
			content.append("REASONS: ").append(reasons).append('\n').append('\n');

			DecompileResults result = decompiler.decompileFunction(function, 60, monitor);
			if (result != null && result.decompileCompleted() && result.getDecompiledFunction() != null) {
				content.append(result.getDecompiledFunction().getC());
			}
			else {
				String error = (result == null) ? "no result returned" : result.getErrorMessage();
				content.append("// Decompilation failed: ").append(error).append('\n');
			}

			writeText(filePath, content.toString());
		}

		writeText(outputDir.resolve("summary.txt"), summary.toString());
		println("Wrote " + interesting.size() + " decompiled functions to " + outputDir);
	}

	private void addFunction(Map<String, Match> interesting, Function function, String reason) {
		if (function == null) {
			return;
		}
		String key = function.getEntryPoint().toString();
		Match match = interesting.get(key);
		if (match == null) {
			match = new Match(function);
			interesting.put(key, match);
		}
		match.reasons.add(reason);
	}

	private String safeName(String text) {
		return text.replaceAll("[^A-Za-z0-9._-]+", "_");
	}

	private void writeText(Path path, String content) throws IOException {
		Files.write(path, content.getBytes(StandardCharsets.UTF_8));
	}
}
