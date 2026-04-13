using System.Threading.Tasks;
using Autofac;
using GIToolkit.Model;

namespace GIToolkit.Services;

public interface ILocalCachingServices
{
	void ClearCache(string key);

	bool Contains(string key);

	Task<bool> ContainsAsync(string key);

	SyncObject Get(string key);

	Task<SyncObject> GetAsync(string key);

	SyncObject Set<T>(string key, T data);

	Task<SyncObject> SetAsync<T>(string key, T data);

	object TryDeserialize(SyncObject obj);

	T Cache<T>(string key, T data);

	Task<T> CacheAsync<T>(string key, T data);

	ContainerBuilder RegisterObjectInstance<T, I>(ref ContainerBuilder builder, string key) where T : new();
}
