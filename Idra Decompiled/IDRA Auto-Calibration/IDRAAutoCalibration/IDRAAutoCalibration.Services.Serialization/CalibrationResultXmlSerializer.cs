using System.IO;
using System.Xml;
using IDRAAutoCalibration.DTO.Calibration;
using IDRAAutoCalibration.DTO.Calibration.Serialization;
using IodKeMsDBY9RwTYmwo;
using mMWtJPWctee66WM7q3;

namespace IDRAAutoCalibration.Services.Serialization;

public class CalibrationResultXmlSerializer
{
	private XmlWriter? xCekwGqdNK;

	public CalibrationResultXmlSerializer()
	{
		edn1DLqc3tTSJMfwQw.HjE5gdQvRAiaZ();
		base._002Ector();
	}

	public void Serialize(string filePath, StereoCalibrationResult calibrationResult)
	{
		using FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
		IDRAAutoCalibration.DTO.Calibration.Serialization.Calibration calibration = CalibrationMapper.MapFromStereoCalibrationResult(calibrationResult);
		xsNkV4xgrW(fileStream, calibration);
	}

	private void xsNkV4xgrW(Stream P_0, IDRAAutoCalibration.DTO.Calibration.Serialization.Calibration P_1)
	{
		xCekwGqdNK = XmlWriter.Create(P_0);
		xCekwGqdNK.WriteStartDocument();
		xCekwGqdNK.WriteStartElement(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5850));
		DnVkZJXMI3(P_1);
		DtikAoIB1u(P_1.Stereo);
		b7skI05tP3(P_1.Target);
		xCekwGqdNK.WriteEndElement();
		xCekwGqdNK.WriteEndDocument();
		xCekwGqdNK.Close();
	}

	private void b7skI05tP3(Target P_0)
	{
		xCekwGqdNK?.WriteStartElement(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5876));
		xCekwGqdNK?.WriteStartElement(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5892));
		B7rk5G4jm4(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5910), P_0.Camera1);
		B7rk5G4jm4(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5928), P_0.Camera2);
		xCekwGqdNK?.WriteEndElement();
		PXtk05KeNP(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5946), P_0.PO);
		PXtk05KeNP(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5954), P_0.PX);
		PXtk05KeNP(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5962), P_0.PY);
		xCekwGqdNK?.WriteEndElement();
	}

	private void B7rk5G4jm4(string P_0, CameraTarget P_1)
	{
		xCekwGqdNK?.WriteStartElement(P_0);
		PXtk05KeNP(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5970), P_1.ORIGIN);
		PXtk05KeNP(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5946), P_1.PO);
		PXtk05KeNP(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5954), P_1.PX);
		PXtk05KeNP(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5962), P_1.PY);
		PXtk05KeNP(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5986), P_1.R);
		PXtk05KeNP(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5992), P_1.T);
		PXtk05KeNP(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5998), P_1.VX);
		PXtk05KeNP(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6006), P_1.VY);
		PXtk05KeNP(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6014), P_1.VZ);
		xCekwGqdNK?.WriteEndElement();
	}

	private void DtikAoIB1u(Stereo P_0)
	{
		xCekwGqdNK?.WriteStartElement(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6022));
		xCekwGqdNK?.WriteStartElement(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5892));
		xCekwGqdNK?.WriteStartElement(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5910));
		PXtk05KeNP(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6038), P_0.Camera1.Projection);
		PXtk05KeNP(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6062), P_0.Camera1.ROI);
		PXtk05KeNP(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6072), P_0.Camera1.Rectification);
		xCekwGqdNK?.WriteEndElement();
		xCekwGqdNK?.WriteStartElement(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5928));
		PXtk05KeNP(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6038), P_0.Camera2.Projection);
		PXtk05KeNP(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6062), P_0.Camera2.ROI);
		PXtk05KeNP(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6072), P_0.Camera2.Rectification);
		xCekwGqdNK?.WriteEndElement();
		xCekwGqdNK?.WriteEndElement();
		PXtk05KeNP(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6102), P_0.PerspectiveTransformation);
		PXtk05KeNP(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6156), P_0.Rotation);
		PXtk05KeNP(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6176), P_0.Translation);
		xCekwGqdNK?.WriteEndElement();
	}

	private void DnVkZJXMI3(IDRAAutoCalibration.DTO.Calibration.Serialization.Calibration P_0)
	{
		xCekwGqdNK?.WriteStartElement(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5892));
		xCekwGqdNK?.WriteStartElement(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5910));
		xKyktCqgDY(P_0.Camera1);
		xCekwGqdNK?.WriteEndElement();
		xCekwGqdNK?.WriteStartElement(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(5928));
		xKyktCqgDY(P_0.Camera2);
		xCekwGqdNK?.WriteEndElement();
		xCekwGqdNK?.WriteEndElement();
	}

	private void xKyktCqgDY(Camera P_0)
	{
		PXtk05KeNP(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6202), P_0.Coeffs);
		PXtk05KeNP(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6218), P_0.Interpolation);
		PXtk05KeNP(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6248), P_0.Matrix);
		PXtk05KeNP(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(6264), P_0.Name);
	}

	private void PXtk05KeNP(string P_0, string P_1)
	{
		xCekwGqdNK?.WriteStartElement(P_0);
		xCekwGqdNK?.WriteString(P_1);
		xCekwGqdNK?.WriteEndElement();
	}
}
