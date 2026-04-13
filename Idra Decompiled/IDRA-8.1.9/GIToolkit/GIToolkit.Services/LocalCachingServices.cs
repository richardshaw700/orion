using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Autofac;
using GIToolkit.Model;
using Newtonsoft.Json;
using P3NBy0oT7wIBhs7JVn;
using PersistentObjectCachenet45;
using xvPCPAE495dWC1pA5M;

namespace GIToolkit.Services;

public class LocalCachingServices : ILocalCachingServices
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass10_0<T, I> where T : new()
	{
		public T instance;

		public _003C_003Ec__DisplayClass10_0()
		{
			hYmKHB2AETliGYPniL.CdBQSA585CPGp();
			UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
			base._002Ector();
		}

		internal T UtmxKI4xqt(IComponentContext i)
		{
			return instance;
		}
	}

	public bool Contains(string key)
	{
		try
		{
			return PersistentObjectCache.ContainsAsync<SyncObject>(key).Result;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public Task<bool> ContainsAsync(string key)
	{
		try
		{
			return PersistentObjectCache.ContainsAsync<SyncObject>(key);
		}
		catch (Exception)
		{
			return Task.FromResult(result: false);
		}
	}

	public SyncObject Get(string key)
	{
		return PersistentObjectCache.GetObjectAsync<SyncObject>(key, ignoreInvalidationTime: true).Result;
	}

	public Task<SyncObject> GetAsync(string key)
	{
		return PersistentObjectCache.GetObjectAsync<SyncObject>(key, ignoreInvalidationTime: true);
	}

	public SyncObject Set<T>(string key, T data)
	{
		return PersistentObjectCache.SetObjectAsync(key, new SyncObject(SyncType.Get, data, typeof(T)), TimeSpan.MaxValue).Result;
	}

	public Task<SyncObject> SetAsync<T>(string key, T data)
	{
		return PersistentObjectCache.SetObjectAsync(key, new SyncObject(SyncType.Get, data, typeof(T)), TimeSpan.MaxValue);
	}

	public T Cache<T>(string key, T data)
	{
		Set(key, data);
		SyncObject obj = Get(key);
		return (T)TryDeserialize(obj);
	}

	public async Task<T> CacheAsync<T>(string key, T data)
	{
		await SetAsync(key, data);
		return (T)TryDeserialize(await GetAsync(key));
	}

	public void ClearCache(string key)
	{
		PersistentObjectCache.ClearCache(key);
	}

	public object TryDeserialize(SyncObject obj)
	{
		try
		{
			object obj2 = JsonConvert.DeserializeObject(obj.Data.ToString(), obj.Type);
			if (obj2 != null)
			{
				return obj2;
			}
		}
		catch (Exception)
		{
		}
		return obj.Data;
	}

	public ContainerBuilder RegisterObjectInstance<T, I>(ref ContainerBuilder builder, string key) where T : new()
	{
		_003C_003Ec__DisplayClass10_0<T, I> CS_0024_003C_003E8__locals5 = new _003C_003Ec__DisplayClass10_0<T, I>();
		CS_0024_003C_003E8__locals5.instance = new T();
		if (Contains(key))
		{
			SyncObject syncObject = Get(key);
			if (syncObject != null)
			{
				CS_0024_003C_003E8__locals5.instance = (T)TryDeserialize(syncObject);
			}
			if (CS_0024_003C_003E8__locals5.instance == null)
			{
				CS_0024_003C_003E8__locals5.instance = new T();
			}
		}
		builder.Register((IComponentContext i) => CS_0024_003C_003E8__locals5.instance).As(typeof(I)).SingleInstance();
		return builder;
	}

	public LocalCachingServices()
	{
		hYmKHB2AETliGYPniL.CdBQSA585CPGp();
		UyIvgf6xc1OH8Uuxf3.enrvf6BndZ();
		base._002Ector();
	}
}
