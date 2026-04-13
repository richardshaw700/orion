using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GIToolkit.Models;
using P3NBy0oT7wIBhs7JVn;
using xvPCPAE495dWC1pA5M;

namespace Tree.Structures;

[Serializable]
public class SerializableCardLeaf : IEquatable<SerializableCardLeaf>
{
	[CompilerGenerated]
	private LauncherCard uT0R676Nw;

	[CompilerGenerated]
	private List<SerializableCardLeaf> to3A9dMYR;

	[CompilerGenerated]
	private string Ct2kEHHdb;

	public LauncherCard Card
	{
		[CompilerGenerated]
		get
		{
			return uT0R676Nw;
		}
		[CompilerGenerated]
		set
		{
			uT0R676Nw = value;
		}
	}

	public List<SerializableCardLeaf> Children
	{
		[CompilerGenerated]
		get
		{
			return to3A9dMYR;
		}
		[CompilerGenerated]
		set
		{
			to3A9dMYR = value;
		}
	}

	public string ParentCardName
	{
		[CompilerGenerated]
		get
		{
			return Ct2kEHHdb;
		}
		[CompilerGenerated]
		set
		{
			Ct2kEHHdb = value;
		}
	}

	public bool Equals(SerializableCardLeaf other)
	{
		if (other == null)
		{
			return false;
		}
		if (Card.Name == other.Card.Name)
		{
			return Card.IconFileName == other.Card.IconFileName;
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		return Equals(obj as SerializableCardLeaf);
	}

	public override int GetHashCode()
	{
		return (Card.Name, Card.IconFileName).GetHashCode();
	}

	public SerializableCardLeaf()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
	}
}
