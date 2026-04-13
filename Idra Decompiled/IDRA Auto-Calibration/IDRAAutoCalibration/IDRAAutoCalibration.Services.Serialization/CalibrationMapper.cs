using IDRAAutoCalibration.DTO.Calibration;
using IDRAAutoCalibration.DTO.Calibration.Serialization;
using mMWtJPWctee66WM7q3;

namespace IDRAAutoCalibration.Services.Serialization;

public class CalibrationMapper
{
	public static IDRAAutoCalibration.DTO.Calibration.Serialization.Calibration MapFromStereoCalibrationResult(StereoCalibrationResult stereoCalibrationResult)
	{
		return new IDRAAutoCalibration.DTO.Calibration.Serialization.Calibration
		{
			Camera1 = 
			{
				Name = stereoCalibrationResult[CameraRole.Master].CameraId,
				Coeffs = OpenCvMatToStringConverter.ToString(stereoCalibrationResult[CameraRole.Master].DistCoefficient),
				Matrix = OpenCvMatToStringConverter.ToString(stereoCalibrationResult[CameraRole.Master].CameraMatrix)
			},
			Camera2 = 
			{
				Name = stereoCalibrationResult[CameraRole.Slave].CameraId,
				Coeffs = OpenCvMatToStringConverter.ToString(stereoCalibrationResult[CameraRole.Slave].DistCoefficient),
				Matrix = OpenCvMatToStringConverter.ToString(stereoCalibrationResult[CameraRole.Slave].CameraMatrix)
			},
			Stereo = 
			{
				Rotation = OpenCvMatToStringConverter.ToString(stereoCalibrationResult.RotationMatrix),
				Translation = OpenCvMatToStringConverter.ToString(stereoCalibrationResult.TranslationVector),
				PerspectiveTransformation = OpenCvMatToStringConverter.ToString(stereoCalibrationResult.PerspectiveTransformation),
				Camera1 = 
				{
					Projection = OpenCvMatToStringConverter.ToString(stereoCalibrationResult[CameraRole.Master].Projection),
					Rectification = OpenCvMatToStringConverter.ToString(stereoCalibrationResult[CameraRole.Master].Rectification),
					ROI = OpenCvMatToStringConverter.ToString(stereoCalibrationResult[CameraRole.Master].ROI)
				},
				Camera2 = 
				{
					Projection = OpenCvMatToStringConverter.ToString(stereoCalibrationResult[CameraRole.Slave].Projection),
					Rectification = OpenCvMatToStringConverter.ToString(stereoCalibrationResult[CameraRole.Slave].Rectification),
					ROI = OpenCvMatToStringConverter.ToString(stereoCalibrationResult[CameraRole.Slave].ROI)
				}
			},
			Target = 
			{
				PO = OpenCvMatToStringConverter.ToString(stereoCalibrationResult.TargetPO),
				PX = OpenCvMatToStringConverter.ToString(stereoCalibrationResult.TargetPX),
				PY = OpenCvMatToStringConverter.ToString(stereoCalibrationResult.TargetPY),
				Camera1 = 
				{
					PO = OpenCvMatToStringConverter.ToString(stereoCalibrationResult[CameraRole.Master].TargetPO),
					PX = OpenCvMatToStringConverter.ToString(stereoCalibrationResult[CameraRole.Master].TargetPX),
					PY = OpenCvMatToStringConverter.ToString(stereoCalibrationResult[CameraRole.Master].TargetPY),
					ORIGIN = OpenCvMatToStringConverter.ToString(stereoCalibrationResult[CameraRole.Master].TargetOrigin),
					R = OpenCvMatToStringConverter.ToString(stereoCalibrationResult[CameraRole.Master].TargetRotation),
					T = OpenCvMatToStringConverter.ToString(stereoCalibrationResult[CameraRole.Master].TargetTranslation),
					VX = OpenCvMatToStringConverter.ToString(stereoCalibrationResult[CameraRole.Master].TargetVX),
					VY = OpenCvMatToStringConverter.ToString(stereoCalibrationResult[CameraRole.Master].TargetVY),
					VZ = OpenCvMatToStringConverter.ToString(stereoCalibrationResult[CameraRole.Master].TargetVZ)
				},
				Camera2 = 
				{
					PO = OpenCvMatToStringConverter.ToString(stereoCalibrationResult[CameraRole.Slave].TargetPO),
					PX = OpenCvMatToStringConverter.ToString(stereoCalibrationResult[CameraRole.Slave].TargetPX),
					PY = OpenCvMatToStringConverter.ToString(stereoCalibrationResult[CameraRole.Slave].TargetPY),
					ORIGIN = OpenCvMatToStringConverter.ToString(stereoCalibrationResult[CameraRole.Slave].TargetOrigin),
					R = OpenCvMatToStringConverter.ToString(stereoCalibrationResult[CameraRole.Slave].TargetRotation),
					T = OpenCvMatToStringConverter.ToString(stereoCalibrationResult[CameraRole.Slave].TargetTranslation),
					VX = OpenCvMatToStringConverter.ToString(stereoCalibrationResult[CameraRole.Slave].TargetVX),
					VY = OpenCvMatToStringConverter.ToString(stereoCalibrationResult[CameraRole.Slave].TargetVY),
					VZ = OpenCvMatToStringConverter.ToString(stereoCalibrationResult[CameraRole.Slave].TargetVZ)
				}
			}
		};
	}

	public CalibrationMapper()
	{
		edn1DLqc3tTSJMfwQw.HjE5gdQvRAiaZ();
		base._002Ector();
	}
}
