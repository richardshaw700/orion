using System;
using System.Runtime.CompilerServices;
using IDRAAutoCalibration.Services.Calibration.ValidationMetrics;
using IodKeMsDBY9RwTYmwo;
using mMWtJPWctee66WM7q3;
using qPXR3XhH8CWnNrWRAB;

namespace OO3ERm92I7MIQhT00f;

internal sealed class u3V7kvv77B14SyahwY
{
	private readonly int qyZJdsGPOJ;

	private readonly double jAuJrGM0H6;

	private readonly double JuBJJYYtib;

	private readonly double f68J4x654s;

	private readonly double aD0Jn1pnLi;

	private readonly int PlpJ1kLd9m;

	private readonly ReWq5vUJMIH4Nehanl JYGJOJnfaS;

	private double VQkJ6b2Y94;

	private double jR3JHWUImX;

	private double cOpJjkmiy1;

	private double ascJRvZSC3;

	private int pmHJvQlGXb;

	private double WepJ9nbbEM;

	private double P7RJUDhjX8;

	private int QQOJhn4IwS;

	private int sAMJei5XSo;

	private int JFgJmQqsYX;

	private int AjqJuml69S;

	private int gDHJ7VivUw;

	private int aaMJ86vs99;

	private readonly double tHWJpQE7GI;

	private readonly double pRdJSVsauV;

	public void AKer26LgPu()
	{
		JYGJOJnfaS.AlgJxw4rCK();
		VQkJ6b2Y94 = 1.0;
		jR3JHWUImX = 0.0;
		cOpJjkmiy1 = 1.0;
		ascJRvZSC3 = 0.0;
		pmHJvQlGXb = 0;
		WepJ9nbbEM = double.PositiveInfinity;
		P7RJUDhjX8 = 0.0;
		QQOJhn4IwS = (sAMJei5XSo = 0);
		JFgJmQqsYX = (AjqJuml69S = 0);
		gDHJ7VivUw = (aaMJ86vs99 = 0);
	}

	[SpecialName]
	public double tJcriU3t4q()
	{
		if (!(WepJ9nbbEM > 1E-09) || !(P7RJUDhjX8 > 1E-09))
		{
			return 1.0;
		}
		return P7RJUDhjX8 / WepJ9nbbEM;
	}

	[SpecialName]
	public double c0qJ3pKEEQ()
	{
		return Math.Max(0.0, jR3JHWUImX - VQkJ6b2Y94);
	}

	[SpecialName]
	public double HkjJMcHqY8()
	{
		return Math.Max(0.0, ascJRvZSC3 - cOpJjkmiy1);
	}

	public void VEArGO7Dlh(DotGridMetrics P_0)
	{
		JYGJOJnfaS.mhrJsy86aR(P_0.CenterX01, P_0.CenterY01);
		VQkJ6b2Y94 = Math.Min(VQkJ6b2Y94, P_0.CenterX01);
		jR3JHWUImX = Math.Max(jR3JHWUImX, P_0.CenterX01);
		cOpJjkmiy1 = Math.Min(cOpJjkmiy1, P_0.CenterY01);
		ascJRvZSC3 = Math.Max(ascJRvZSC3, P_0.CenterY01);
		pmHJvQlGXb++;
		if (P_0.DepthProxy > 1E-09)
		{
			if (P_0.DepthProxy < WepJ9nbbEM)
			{
				WepJ9nbbEM = P_0.DepthProxy;
			}
			if (P_0.DepthProxy > P7RJUDhjX8)
			{
				P7RJUDhjX8 = P_0.DepthProxy;
			}
		}
		if (P_0.PitchProxy >= tHWJpQE7GI)
		{
			QQOJhn4IwS++;
		}
		else if (P_0.PitchProxy <= 0.0 - tHWJpQE7GI)
		{
			sAMJei5XSo++;
		}
		if (P_0.RollProxy >= tHWJpQE7GI)
		{
			AjqJuml69S++;
		}
		else if (P_0.RollProxy <= 0.0 - tHWJpQE7GI)
		{
			JFgJmQqsYX++;
		}
		if (P_0.YawProxyDeg >= pRdJSVsauV)
		{
			aaMJ86vs99++;
		}
		else if (P_0.YawProxyDeg <= 0.0 - pRdJSVsauV)
		{
			gDHJ7VivUw++;
		}
	}

	public CalibrationGuidanceState fMIrFchle1()
	{
		double val = YY3rb7C0oQ(JYGJOJnfaS.XEGJqf6Qtb() / jAuJrGM0H6);
		double num = YY3rb7C0oQ(c0qJ3pKEEQ() / JuBJJYYtib);
		double num2 = YY3rb7C0oQ(HkjJMcHqY8() / f68J4x654s);
		double val2 = YY3rb7C0oQ((num + num2) * 0.5);
		double num3 = Math.Max(val, val2);
		double num4 = 0.0;
		if (pmHJvQlGXb >= PlpJ1kLd9m && WepJ9nbbEM > 1E-09 && P7RJUDhjX8 > 1E-09)
		{
			num4 = YY3rb7C0oQ((tJcriU3t4q() - 1.0) / (aD0Jn1pnLi - 1.0));
		}
		double num5 = YY3rb7C0oQ((Math.Min(1.0, (double)QQOJhn4IwS / (double)qyZJdsGPOJ) + Math.Min(1.0, (double)sAMJei5XSo / (double)qyZJdsGPOJ)) / 2.0);
		double num6 = YY3rb7C0oQ((Math.Min(1.0, (double)JFgJmQqsYX / (double)qyZJdsGPOJ) + Math.Min(1.0, (double)AjqJuml69S / (double)qyZJdsGPOJ)) / 2.0);
		double num7 = YY3rb7C0oQ((Math.Min(1.0, (double)gDHJ7VivUw / (double)qyZJdsGPOJ) + Math.Min(1.0, (double)aaMJ86vs99 / (double)qyZJdsGPOJ)) / 2.0);
		double overall = (2.0 * num4 + 2.0 * num3 + num5 + num6 + num7) / 7.0;
		var (instruction, instructionText) = PNDrNpeuKL(num3, num4, num5, num6, num7);
		return new CalibrationGuidanceState
		{
			Overall01 = overall,
			Coverage01 = num3,
			Depth01 = num4,
			Pitch01 = num5,
			Roll01 = num6,
			Yaw01 = num7,
			Instruction = instruction,
			InstructionText = instructionText
		};
	}

	private (GuidanceInstruction, string) PNDrNpeuKL(double P_0, double P_1, double P_2, double P_3, double P_4)
	{
		if (P_1 < 1.0)
		{
			if (pmHJvQlGXb < PlpJ1kLd9m)
			{
				return (GuidanceInstruction.MoveCloser, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(12860));
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(52, 2);
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(12982));
			defaultInterpolatedStringHandler.AppendFormatted(tJcriU3t4q(), xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(2508));
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(13064));
			defaultInterpolatedStringHandler.AppendFormatted(aD0Jn1pnLi, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(2508));
			defaultInterpolatedStringHandler.AppendLiteral(xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(13088));
			return (GuidanceInstruction.MoveCloser, defaultInterpolatedStringHandler.ToStringAndClear());
		}
		if (P_0 < 1.0)
		{
			var (num, num2) = JYGJOJnfaS.ATJJWEqPKH();
			if (num2 <= (JYGJOJnfaS.mKsJfWMK4R() - 1) / 3)
			{
				return (GuidanceInstruction.MoveLeft, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(13098));
			}
			if (num2 >= (JYGJOJnfaS.mKsJfWMK4R() - 1) * 2 / 3)
			{
				return (GuidanceInstruction.MoveRight, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(13194));
			}
			if (num <= (JYGJOJnfaS.q7NJVWK0Ha() - 1) / 3)
			{
				return (GuidanceInstruction.MoveUp, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(13292));
			}
			if (num >= (JYGJOJnfaS.q7NJVWK0Ha() - 1) * 2 / 3)
			{
				return (GuidanceInstruction.MoveDown, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(13376));
			}
			return (GuidanceInstruction.None, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(13466));
		}
		if (P_2 < 1.0)
		{
			if (QQOJhn4IwS < qyZJdsGPOJ)
			{
				return (GuidanceInstruction.TiltForward, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(13540));
			}
			return (GuidanceInstruction.TiltBackward, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(13632));
		}
		if (P_3 < 1.0)
		{
			if (JFgJmQqsYX < qyZJdsGPOJ)
			{
				return (GuidanceInstruction.TiltLeftSideUp, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(13730));
			}
			return (GuidanceInstruction.TiltRightSideUp, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(13798));
		}
		if (P_4 < 1.0)
		{
			if (gDHJ7VivUw < qyZJdsGPOJ)
			{
				return (GuidanceInstruction.RotateLeft, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(13868));
			}
			return (GuidanceInstruction.RotateRight, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(13948));
		}
		return (GuidanceInstruction.None, xvOBE7xZBPJ5BZrY6D.fnKnNR0pN6(14030));
	}

	private static double YY3rb7C0oQ(double P_0)
	{
		if (!(P_0 < 0.0))
		{
			if (!(P_0 > 1.0))
			{
				return P_0;
			}
			return 1.0;
		}
		return 0.0;
	}

	public u3V7kvv77B14SyahwY()
	{
		edn1DLqc3tTSJMfwQw.HjE5gdQvRAiaZ();
		qyZJdsGPOJ = 4;
		jAuJrGM0H6 = 0.44;
		JuBJJYYtib = 0.3;
		f68J4x654s = 0.25;
		aD0Jn1pnLi = 1.07;
		PlpJ1kLd9m = 10;
		JYGJOJnfaS = new ReWq5vUJMIH4Nehanl(3, 3);
		VQkJ6b2Y94 = 1.0;
		cOpJjkmiy1 = 1.0;
		WepJ9nbbEM = double.PositiveInfinity;
		tHWJpQE7GI = 0.03;
		pRdJSVsauV = 5.0;
		base._002Ector();
	}
}
