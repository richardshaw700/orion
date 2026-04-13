using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using P3NBy0oT7wIBhs7JVn;
using Tree.Structures;
using xvPCPAE495dWC1pA5M;

namespace Tree.Extensions;

public static class TreeExtensions
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass0_0<T> where T : class
	{
		public Action<Leaf<T>> action;

		public _003C_003Ec__DisplayClass0_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal void nJBFL8FrB(Leaf<T> x)
		{
			action(x);
			x.TraverseTree(action);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass1_0<T> where T : class
	{
		public List<Leaf<T>> flattenedLeaves;

		public _003C_003Ec__DisplayClass1_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal void UPOpw6Bki(Leaf<T> x)
		{
			flattenedLeaves.Add(x);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass2_0<T> where T : class
	{
		public List<Leaf<T>> leaves;

		public _003C_003Ec__DisplayClass2_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal void tSbWLqB0Q(Leaf<T> x)
		{
			leaves.Add(x);
		}
	}

	public static void TraverseTree<T>(this Leaf<T> leaf, Action<Leaf<T>> action) where T : class
	{
		_003C_003Ec__DisplayClass0_0<T> CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass0_0<T>();
		CS_0024_003C_003E8__locals3.action = action;
		if (leaf.Children != null)
		{
			leaf.Children.ToList().ForEach(delegate(Leaf<T> x)
			{
				CS_0024_003C_003E8__locals3.action(x);
				x.TraverseTree(CS_0024_003C_003E8__locals3.action);
			});
		}
	}

	public static IEnumerable<Leaf<T>> FindLeaves<T>(this Leaf<T> leaf, Func<Leaf<T>, bool> whereExpression) where T : class
	{
		_003C_003Ec__DisplayClass1_0<T> CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass1_0<T>();
		CS_0024_003C_003E8__locals3.flattenedLeaves = new List<Leaf<T>>();
		leaf.TraverseTree(delegate(Leaf<T> x)
		{
			CS_0024_003C_003E8__locals3.flattenedLeaves.Add(x);
		});
		return CS_0024_003C_003E8__locals3.flattenedLeaves.Where(whereExpression);
	}

	public static IEnumerable<Leaf<T>> FlattenTree<T>(this Tree<T> tree) where T : class
	{
		_003C_003Ec__DisplayClass2_0<T> CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass2_0<T>();
		CS_0024_003C_003E8__locals3.leaves = new List<Leaf<T>> { tree.Root };
		tree.Root.TraverseTree(delegate(Leaf<T> x)
		{
			CS_0024_003C_003E8__locals3.leaves.Add(x);
		});
		return CS_0024_003C_003E8__locals3.leaves;
	}

	public static Leaf<T> FindRoot<T>(this Leaf<T> leaf) where T : class
	{
		if (leaf.Parent == null)
		{
			return leaf;
		}
		return leaf.Parent.FindRoot();
	}
}
