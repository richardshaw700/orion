using Newtonsoft.Json;

namespace GIToolkit.Services;

public interface IJsonHelper
{
	T DeserializeObject<T>(string content);

	string SerializeObject(object obj);

	string SerializeObject(object obj, Formatting formatting, JsonConverter[] converter);
}
