using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using P3NBy0oT7wIBhs7JVn;
using Tree.Structures;
using xvPCPAE495dWC1pA5M;

namespace Tree.Extensions;

public static class CustomTreeExtensions
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass0_0
	{
		public Action<SerializableCardLeaf> YpIxnHn4a;

		public _003C_003Ec__DisplayClass0_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal void KQ7YTdSKS(SerializableCardLeaf x)
		{
			YpIxnHn4a(x);
			x.TraverseCardTree(YpIxnHn4a);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass1_0
	{
		public List<SerializableCardLeaf> C3dEM0bIF;

		public _003C_003Ec__DisplayClass1_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal void LL46N8GID(SerializableCardLeaf x)
		{
			C3dEM0bIF.Add(x);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public List<SerializableCardLeaf> cMe3tr34J;

		public _003C_003Ec__DisplayClass2_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal void a0kB5trg0(SerializableCardLeaf x)
		{
			cMe3tr34J.Add(x);
		}
	}

	public static void TraverseCardTree(this SerializableCardLeaf leaf, Action<SerializableCardLeaf> action)
	{
		_003C_003Ec__DisplayClass0_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass0_0();
		CS_0024_003C_003E8__locals3.YpIxnHn4a = action;
		if (leaf.Children != null)
		{
			leaf.Children.ToList().ForEach(delegate(SerializableCardLeaf x)
			{
				CS_0024_003C_003E8__locals3.YpIxnHn4a(x);
				x.TraverseCardTree(CS_0024_003C_003E8__locals3.YpIxnHn4a);
			});
		}
	}

	public static IEnumerable<SerializableCardLeaf> FindCardLeaves(this SerializableCardLeaf leaf, Func<SerializableCardLeaf, bool> whereExpression)
	{
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass1_0();
		CS_0024_003C_003E8__locals3.C3dEM0bIF = new List<SerializableCardLeaf>();
		leaf.TraverseCardTree(delegate(SerializableCardLeaf x)
		{
			CS_0024_003C_003E8__locals3.C3dEM0bIF.Add(x);
		});
		return CS_0024_003C_003E8__locals3.C3dEM0bIF.Where(whereExpression);
	}

	public static IEnumerable<SerializableCardLeaf> FlattenCardTree(this SerializableCardTree tree)
	{
		_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass2_0();
		CS_0024_003C_003E8__locals3.cMe3tr34J = new List<SerializableCardLeaf> { tree.Root };
		tree.Root.TraverseCardTree(delegate(SerializableCardLeaf x)
		{
			CS_0024_003C_003E8__locals3.cMe3tr34J.Add(x);
		});
		return CS_0024_003C_003E8__locals3.cMe3tr34J;
	}
}
