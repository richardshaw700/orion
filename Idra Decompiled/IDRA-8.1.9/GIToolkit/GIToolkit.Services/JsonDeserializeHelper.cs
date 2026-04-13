using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using U4yoVEpfEeOhjCsFXj;

namespace GIToolkit.Services;

public static class JsonDeserializeHelper
{
	public static Dictionary<string, object> DeserializeToDictionary(string json)
	{
		return B8Mx34ZjNR(JToken.Parse(json));
	}

	private static Dictionary<string, object> B8Mx34ZjNR(JToken P_0)
	{
		if (P_0 is JObject jObject)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			{
				foreach (JProperty item in jObject.Properties())
				{
					dictionary[item.Name] = B8Mx34ZjNR(item.Value);
				}
				return dictionary;
			}
		}
		if (P_0 is JArray jArray)
		{
			List<object> list = new List<object>();
			foreach (JToken item2 in jArray)
			{
				list.Add(B8Mx34ZjNR(item2));
			}
			return new Dictionary<string, object> { 
			{
				so95DAFNMfktfjp4Dm.An6v7kuCGg(3976),
				list
			} };
		}
		return new Dictionary<string, object> { 
		{
			so95DAFNMfktfjp4Dm.An6v7kuCGg(3988),
			P_0.ToObject<object>()
		} };
	}
}
