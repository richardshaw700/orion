using System.Runtime.CompilerServices;
using IodKeMsDBY9RwTYmwo;
using mMWtJPWctee66WM7q3;

namespace IDRAAutoCalibration.DTO.Calibration;

public class CalibrationValidationValue
{
	public ValidationValueType ValidationValueType;

	public double Value;

	public bool IsValid;

	public CalibrationValidationValue(ValidationValueType validationValueType, double value, bool isValid)
	{
		edn1DLqc3tTSJMfwQw.HjE5gdQvRAiaZ();
		ValidationValueType = validationValueType;
		Value = value;
		IsValid = isValid;
		base._002Ector();
	}

	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 3);
		defaultInterpolatedStringHandler.AppendFormatted(IsValid);
		defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(14348));
		defaultInterpolatedStringHandler.AppendFormatted(ValidationValueType, 5);
		defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(14370));
		defaultInterpolatedStringHandler.AppendFormatted(Value, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(14392));
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}
}
