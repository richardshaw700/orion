using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;
using sX02IJN7NqxvB7iKPK;
using zLGfTg8qMbPmqnv69o;

namespace PimDeWitte.UnityMainThreadDispatcher;

public class UnityMainThreadDispatcher : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public UnityMainThreadDispatcher xabcRtxXaC;

		public IEnumerator NhTcssyBuv;

		public _003C_003Ec__DisplayClass2_0()
		{
			WqDrXqVrUpBU7mgIWd.JJMXwo8zxTjJm();
			base._002Ector();
		}

		internal void LIsceqlGiI()
		{
			((MonoBehaviour)xabcRtxXaC).StartCoroutine(NhTcssyBuv);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public Action Dl9cH8TEDl;

		public TaskCompletionSource<bool> G3Lcxk7hSB;

		public _003C_003Ec__DisplayClass4_0()
		{
			WqDrXqVrUpBU7mgIWd.JJMXwo8zxTjJm();
			base._002Ector();
		}

		internal void QKbcW2EXbu()
		{
			try
			{
				Dl9cH8TEDl();
				G3Lcxk7hSB.TrySetResult(result: true);
			}
			catch (Exception exception)
			{
				G3Lcxk7hSB.TrySetException(exception);
			}
		}
	}

	private static readonly Queue<Action> YSaccViID;

	private static UnityMainThreadDispatcher v9TKEh3fv;

	public void Update()
	{
		lock (YSaccViID)
		{
			while (YSaccViID.Count > 0)
			{
				YSaccViID.Dequeue()();
			}
		}
	}

	public void Enqueue(IEnumerator action)
	{
		_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass2_0();
		CS_0024_003C_003E8__locals4.xabcRtxXaC = this;
		CS_0024_003C_003E8__locals4.NhTcssyBuv = action;
		lock (YSaccViID)
		{
			YSaccViID.Enqueue(delegate
			{
				((MonoBehaviour)CS_0024_003C_003E8__locals4.xabcRtxXaC).StartCoroutine(CS_0024_003C_003E8__locals4.NhTcssyBuv);
			});
		}
	}

	public void Enqueue(Action action)
	{
		Enqueue(jDVwPXRfS(action));
	}

	public Task EnqueueAsync(Action action)
	{
		_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals6 = new _003C_003Ec__DisplayClass4_0();
		CS_0024_003C_003E8__locals6.Dl9cH8TEDl = action;
		CS_0024_003C_003E8__locals6.G3Lcxk7hSB = new TaskCompletionSource<bool>();
		Enqueue(jDVwPXRfS(delegate
		{
			try
			{
				CS_0024_003C_003E8__locals6.Dl9cH8TEDl();
				CS_0024_003C_003E8__locals6.G3Lcxk7hSB.TrySetResult(result: true);
			}
			catch (Exception exception)
			{
				CS_0024_003C_003E8__locals6.G3Lcxk7hSB.TrySetException(exception);
			}
		}));
		return CS_0024_003C_003E8__locals6.G3Lcxk7hSB.Task;
	}

	private IEnumerator jDVwPXRfS(Action P_0)
	{
		P_0();
		yield return null;
	}

	public static bool Exists()
	{
		return (Object)(object)v9TKEh3fv != (Object)null;
	}

	public static UnityMainThreadDispatcher Instance()
	{
		if (!Exists())
		{
			throw new Exception(Dpdrn94xidrKkBCvWK.vZjKJCNxST(0));
		}
		return v9TKEh3fv;
	}

	private void Awake()
	{
		if ((Object)(object)v9TKEh3fv == (Object)null)
		{
			v9TKEh3fv = this;
			Object.DontDestroyOnLoad((Object)(object)((Component)this).gameObject);
		}
	}

	private void OnDestroy()
	{
		v9TKEh3fv = null;
	}

	public UnityMainThreadDispatcher()
	{
		WqDrXqVrUpBU7mgIWd.JJMXwo8zxTjJm();
		((MonoBehaviour)this)._002Ector();
	}

	static UnityMainThreadDispatcher()
	{
		WqDrXqVrUpBU7mgIWd.JJMXwo8zxTjJm();
		YSaccViID = new Queue<Action>();
		v9TKEh3fv = null;
	}
}
