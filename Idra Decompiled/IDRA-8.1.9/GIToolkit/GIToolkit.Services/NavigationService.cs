using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using P3NBy0oT7wIBhs7JVn;
using U4yoVEpfEeOhjCsFXj;
using xvPCPAE495dWC1pA5M;

namespace GIToolkit.Services;

public class NavigationService<T> : INavigationService<T> where T : Enum
{
	private Dictionary<T, ObservableRecipient> LiY6Ta9fyY;

	private Stack<T> sZO6Lcf7gR;

	[CompilerGenerated]
	private ObservableRecipient boD60fLVUN;

	public ObservableRecipient Current
	{
		[CompilerGenerated]
		get
		{
			return boD60fLVUN;
		}
		[CompilerGenerated]
		set
		{
			boD60fLVUN = value;
		}
	}

	public void NavigateTo(T name)
	{
		try
		{
			Current = LiY6Ta9fyY[name];
			sZO6Lcf7gR.Push(name);
			WeakReferenceMessenger.Default.Send(Current);
		}
		catch (Exception)
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(9604));
		}
	}

	public T CurrentPage()
	{
		try
		{
			return LiY6Ta9fyY.FirstOrDefault((KeyValuePair<T, ObservableRecipient> P_0) => P_0.Value == Current).Key;
		}
		catch (Exception)
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(9604));
		}
	}

	public void GoBack()
	{
		sZO6Lcf7gR.Pop();
		if (sZO6Lcf7gR.Count > 0)
		{
			Current = LiY6Ta9fyY[sZO6Lcf7gR.Peek()];
			WeakReferenceMessenger.Default.Send(Current);
		}
	}

	public T GetBackInfo()
	{
		try
		{
			T item = sZO6Lcf7gR.Peek();
			sZO6Lcf7gR.Pop();
			T result = sZO6Lcf7gR.Peek();
			sZO6Lcf7gR.Push(item);
			return result;
		}
		catch (Exception)
		{
			throw new Exception(so95DAFNMfktfjp4Dm.An6v7kuCGg(9604));
		}
	}

	public void ClearHistory()
	{
		sZO6Lcf7gR.Clear();
	}

	public void AddPage(ObservableRecipient page, T name)
	{
		if (LiY6Ta9fyY.ContainsKey(name))
		{
			LiY6Ta9fyY[name] = page;
		}
		else
		{
			LiY6Ta9fyY.Add(name, page);
		}
	}

	public void RemovePage(T name)
	{
		try
		{
			LiY6Ta9fyY.Remove(name);
		}
		catch (Exception)
		{
		}
	}

	public NavigationService()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		LiY6Ta9fyY = new Dictionary<T, ObservableRecipient>();
		sZO6Lcf7gR = new Stack<T>();
		base._002Ector();
	}

	[CompilerGenerated]
	private bool cR36Qogvr9(KeyValuePair<T, ObservableRecipient> P_0)
	{
		return P_0.Value == Current;
	}
}
