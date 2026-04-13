using System;
using System.Runtime.CompilerServices;
using GICTSCore.Data;

namespace GICTSCore.Services;

public struct ModeSetting : IEquatable<ModeSetting>
{
	[CompilerGenerated]
	private bool PN6HQn18iL;

	[CompilerGenerated]
	private int wTnHPLVSji;

	[CompilerGenerated]
	private bool iu6HGSUIYG;

	[CompilerGenerated]
	private bool jq4HqkFT5T;

	[CompilerGenerated]
	private int iQ6HmByGuT;

	[CompilerGenerated]
	private IdraMode XAIH2QPBOM;

	public bool ShowInterface
	{
		[CompilerGenerated]
		readonly get
		{
			return PN6HQn18iL;
		}
		[CompilerGenerated]
		set
		{
			PN6HQn18iL = value;
		}
	}

	public int DebugLevel
	{
		[CompilerGenerated]
		readonly get
		{
			return wTnHPLVSji;
		}
		[CompilerGenerated]
		set
		{
			wTnHPLVSji = value;
		}
	}

	public bool StartWithGame
	{
		[CompilerGenerated]
		readonly get
		{
			return iu6HGSUIYG;
		}
		[CompilerGenerated]
		set
		{
			iu6HGSUIYG = value;
		}
	}

	public bool StartAutoShotMode
	{
		[CompilerGenerated]
		readonly get
		{
			return jq4HqkFT5T;
		}
		[CompilerGenerated]
		set
		{
			jq4HqkFT5T = value;
		}
	}

	public int RunningMode
	{
		[CompilerGenerated]
		readonly get
		{
			return iQ6HmByGuT;
		}
		[CompilerGenerated]
		set
		{
			iQ6HmByGuT = value;
		}
	}

	public IdraMode CurrentSetJsonMode
	{
		[CompilerGenerated]
		readonly get
		{
			return XAIH2QPBOM;
		}
		[CompilerGenerated]
		set
		{
			XAIH2QPBOM = value;
		}
	}

	public bool Equals(ModeSetting other)
	{
		if (other.ShowInterface == ShowInterface && other.DebugLevel == DebugLevel && other.StartWithGame == StartWithGame && other.StartAutoShotMode == StartAutoShotMode && other.RunningMode == RunningMode)
		{
			return other.CurrentSetJsonMode == CurrentSetJsonMode;
		}
		return false;
	}
}
