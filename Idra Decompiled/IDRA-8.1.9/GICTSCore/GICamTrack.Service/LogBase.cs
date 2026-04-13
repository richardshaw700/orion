using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading;
using JdN3qlxpK1fXeWoSKd;
using lKEAGvFqWp7B16kDoY;

namespace GICamTrack.Service;

public abstract class LogBase
{
	public delegate void OnNewMessageEventHandler(object sender, NewMessageEventArgs e);

	protected readonly object lockObj;

	[CompilerGenerated]
	private OnNewMessageEventHandler vx0LB5wOVW;

	public event OnNewMessageEventHandler NewMessageEvent
	{
		[CompilerGenerated]
		add
		{
			OnNewMessageEventHandler onNewMessageEventHandler = vx0LB5wOVW;
			OnNewMessageEventHandler onNewMessageEventHandler2;
			do
			{
				onNewMessageEventHandler2 = onNewMessageEventHandler;
				OnNewMessageEventHandler value2 = (OnNewMessageEventHandler)Delegate.Combine(onNewMessageEventHandler2, value);
				onNewMessageEventHandler = Interlocked.CompareExchange(ref vx0LB5wOVW, value2, onNewMessageEventHandler2);
			}
			while ((object)onNewMessageEventHandler != onNewMessageEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			OnNewMessageEventHandler onNewMessageEventHandler = vx0LB5wOVW;
			OnNewMessageEventHandler onNewMessageEventHandler2;
			do
			{
				onNewMessageEventHandler2 = onNewMessageEventHandler;
				OnNewMessageEventHandler value2 = (OnNewMessageEventHandler)Delegate.Remove(onNewMessageEventHandler2, value);
				onNewMessageEventHandler = Interlocked.CompareExchange(ref vx0LB5wOVW, value2, onNewMessageEventHandler2);
			}
			while ((object)onNewMessageEventHandler != onNewMessageEventHandler2);
		}
	}

	protected virtual void OnNewMessage(NewMessageEventArgs e)
	{
		vx0LB5wOVW?.Invoke(this, e);
	}

	public abstract void Log(string message);

	public void Add(string message)
	{
		Log(message);
	}

	public void Add<T>(string message, T logObject)
	{
		if (logObject == null)
		{
			Log(message);
			return;
		}
		string empty = string.Empty;
		try
		{
			empty = JsonSerializer.Serialize(logObject, new JsonSerializerOptions
			{
				WriteIndented = true
			});
		}
		catch (Exception ex)
		{
			empty = YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(516) + ex.Message;
		}
		Log(message + YMYMvTu0UxT5Rn8kmF.ahYK8ZsYu6(612) + empty);
	}

	protected LogBase()
	{
		fhYaaMbcaIbkDahgc9.PdVWL95B80ZOj();
		lockObj = new object();
		base._002Ector();
	}
}
