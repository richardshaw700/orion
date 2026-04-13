using System.IO;
using System.Text;
using lKEAGvFqWp7B16kDoY;

namespace Dj53wpDm4kAP8dsJHT;

internal class B5SwJpMR70AGGOQRMt : BinaryWriter
{
	public B5SwJpMR70AGGOQRMt(int P_0)
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		base._002Ector(new MemoryStream(P_0));
	}

	public override void Write(string P_0)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(P_0);
		Write(bytes);
		Write((byte)0);
	}

	public byte[] f8BDIGyqsD()
	{
		return ((MemoryStream)BaseStream).GetBuffer();
	}
}
