using System.Collections.Generic;
using F3frs5SXTsGVtVfuZX;
using GYFmeytn3uk9KnUELA;
using Newtonsoft.Json.Linq;

namespace IDRASharedModels;

public static class JsonDeserializeHelper
{
	public static Dictionary<string, object> DeserializeToDictionary(string json)
	{
		return PngCuirw1(JToken.Parse(json));
	}

	private static Dictionary<string, object> PngCuirw1(JToken P_0)
	{
		if (P_0 is JObject jObject)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			{
				foreach (JProperty item in jObject.Properties())
				{
					dictionary[item.Name] = PngCuirw1(item.Value);
				}
				return dictionary;
			}
		}
		if (P_0 is JArray jArray)
		{
			List<object> list = new List<object>();
			foreach (JToken item2 in jArray)
			{
				list.Add(PngCuirw1(item2));
			}
			return new Dictionary<string, object> { 
			{
				mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(1166),
				list
			} };
		}
		return new Dictionary<string, object> { 
		{
			mLElmM0kdWGfEg0Q8v.f9XBcmGxgX(1178),
			P_0.ToObject<object>()
		} };
	}

	static JsonDeserializeHelper()
	{
		G2089JiDB7k4x1yr7J.kLjw4iIsCLsZtxc4lksN0j();
	}
}
