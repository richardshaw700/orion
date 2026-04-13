using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Emgu.CV;
using IodKeMsDBY9RwTYmwo;
using mMWtJPWctee66WM7q3;

namespace cibwYfp1iGN979yZlM;

internal class oaBtWW8J5C9uEnllFR
{
	public static double vZB43531sp(Mat P_0, int P_1, int P_2)
	{
		if (P_0 == null)
		{
			return 0.0;
		}
		int elementSize = P_0.ElementSize;
		nint source = P_0.DataPointer + P_1 * P_0.Step + P_2 * elementSize;
		switch (elementSize)
		{
		case 8:
		{
			byte[] array2 = new byte[8];
			Marshal.Copy(source, array2, 0, 8);
			return BitConverter.ToDouble(array2, 0);
		}
		case 4:
		{
			byte[] array = new byte[4];
			Marshal.Copy(source, array, 0, 4);
			return BitConverter.ToSingle(array, 0);
		}
		default:
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 1);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(14292));
			defaultInterpolatedStringHandler.AppendFormatted(elementSize);
			throw new NotSupportedException(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		}
	}

	public oaBtWW8J5C9uEnllFR()
	{
		edn1DLqc3tTSJMfwQw.HjE5gdQvRAiaZ();
		base._002Ector();
	}
}
