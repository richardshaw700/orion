using System.Runtime.CompilerServices;
using System.Text;
using JdN3qlxpK1fXeWoSKd;
using lKEAGvFqWp7B16kDoY;

namespace GICTS.Core;

public record IdraDataOutGame
{
	public bool hasWaitForShot
	{
		[CompilerGenerated]
		get
		{
			return kOHLtoof7D;
		}
		[CompilerGenerated]
		init
		{
			kOHLtoof7D = value;
		}
	}

	public string offsetBallY
	{
		[CompilerGenerated]
		get
		{
			return vliLr4hyah;
		}
		[CompilerGenerated]
		init
		{
			vliLr4hyah = value;
		}
	}

	[CompilerGenerated]
	private readonly bool kOHLtoof7D;

	[CompilerGenerated]
	private readonly string vliLr4hyah;

	public IdraDataOutGame(bool hasWaitForShot, string offsetBallY)
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		kOHLtoof7D = hasWaitForShot;
		vliLr4hyah = offsetBallY;
		base._002Ector();
	}

	[CompilerGenerated]
	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(706));
		stringBuilder.Append(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(740));
		if (PrintMembers(stringBuilder))
		{
			stringBuilder.Append(' ');
		}
		stringBuilder.Append('}');
		return stringBuilder.ToString();
	}

	[CompilerGenerated]
	protected virtual bool PrintMembers(StringBuilder builder)
	{
		RuntimeHelpers.EnsureSufficientExecutionStack();
		builder.Append(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(750));
		builder.Append(hasWaitForShot.ToString());
		builder.Append(YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(788));
		builder.Append((object?)offsetBallY);
		return true;
	}

	[CompilerGenerated]
	protected IdraDataOutGame(IdraDataOutGame original)
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		base._002Ector();
		kOHLtoof7D = original.kOHLtoof7D;
		vliLr4hyah = original.vliLr4hyah;
	}

	[CompilerGenerated]
	public void Deconstruct(out bool hasWaitForShot, out string offsetBallY)
	{
		hasWaitForShot = this.hasWaitForShot;
		offsetBallY = this.offsetBallY;
	}
}
