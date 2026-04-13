using System.Runtime.CompilerServices;
using IodKeMsDBY9RwTYmwo;
using mMWtJPWctee66WM7q3;

namespace IDRAAutoCalibration.Services.Calibration.ValidationMetrics;

public sealed class CalibrationGuidanceState
{
	public double Overall01;

	public double Coverage01;

	public double Depth01;

	public double Pitch01;

	public double Roll01;

	public double Yaw01;

	public GuidanceInstruction Instruction;

	public string InstructionText;

	public bool IsComplete
	{
		get
		{
			if (Coverage01 >= 1.0 && Depth01 >= 1.0 && Pitch01 >= 1.0 && Roll01 >= 1.0)
			{
				return Yaw01 >= 1.0;
			}
			return false;
		}
	}

	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(64, 8);
		defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(12706));
		defaultInterpolatedStringHandler.AppendFormatted(Overall01, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(7566));
		defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(12726));
		defaultInterpolatedStringHandler.AppendFormatted(Coverage01, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(7566));
		defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(12750));
		defaultInterpolatedStringHandler.AppendFormatted(Depth01, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(7566));
		defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(7350));
		defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(12768));
		defaultInterpolatedStringHandler.AppendFormatted(Pitch01, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(7566));
		defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(12784));
		defaultInterpolatedStringHandler.AppendFormatted(Roll01, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(7566));
		defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(12800));
		defaultInterpolatedStringHandler.AppendFormatted(Yaw01, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(7566));
		defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(7350));
		defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(12814));
		defaultInterpolatedStringHandler.AppendFormatted(Instruction);
		defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(12842));
		defaultInterpolatedStringHandler.AppendFormatted(InstructionText);
		defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6666));
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	public CalibrationGuidanceState()
	{
		edn1DLqc3tTSJMfwQw.HjE5gdQvRAiaZ();
		InstructionText = "";
		base._002Ector();
	}
}
