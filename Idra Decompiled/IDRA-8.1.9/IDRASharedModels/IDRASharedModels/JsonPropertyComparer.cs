using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using GYFmeytn3uk9KnUELA;
using Newtonsoft.Json;

namespace IDRASharedModels;

public static class JsonPropertyComparer
{
	public static bool IsJsonPropSameAsSavedFile<T>(T currentObject, string savedFilePath) where T : class
	{
		if (!File.Exists(savedFilePath))
		{
			return false;
		}
		Dictionary<string, object> dictionary = JsonDeserializeHelper.DeserializeToDictionary(File.ReadAllText(savedFilePath));
		Dictionary<string, object> dictionary2 = YwiZKeBmS(currentObject);
		return LEhcSj3my(dictionary, dictionary2);
	}

	private static Dictionary<string, object> YwiZKeBmS(object P_0)
	{
		if (P_0 == null)
		{
			return null;
		}
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		PropertyInfo[] properties = P_0.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
		foreach (PropertyInfo propertyInfo in properties)
		{
			if (!propertyInfo.CustomAttributes.Any((CustomAttributeData x) => x.AttributeType == typeof(JsonIgnoreAttribute)))
			{
				object value = propertyInfo.GetValue(P_0);
				if (value == null)
				{
					dictionary[propertyInfo.Name] = null;
				}
				else if (MXOpAbTHn(value.GetType()))
				{
					dictionary[propertyInfo.Name] = value;
				}
				else if (value.GetType() == typeof(TimeSpan) || value.GetType() == typeof(DateTime))
				{
					dictionary[propertyInfo.Name] = value.ToString();
				}
				else if (value is IEnumerable enumerable && !(value is string))
				{
					dictionary[propertyInfo.Name] = XYj211wDC(enumerable);
				}
				else
				{
					dictionary[propertyInfo.Name] = YwiZKeBmS(value);
				}
			}
		}
		return dictionary;
	}

	private static object XYj211wDC(IEnumerable P_0)
	{
		List<object> list = new List<object>();
		foreach (object item in P_0)
		{
			if (MXOpAbTHn(item.GetType()))
			{
				list.Add(item);
			}
			else if (item is IEnumerable enumerable && !(item is string))
			{
				list.Add(XYj211wDC(enumerable));
			}
			else
			{
				list.Add(YwiZKeBmS(item));
			}
		}
		return list;
	}

	private static bool LEhcSj3my(Dictionary<string, object> P_0, Dictionary<string, object> P_1)
	{
		if (P_0 == null || P_1 == null)
		{
			return P_0 == P_1;
		}
		if (!P_0.Keys.SequenceEqual(P_1.Keys))
		{
			return false;
		}
		foreach (string key in P_0.Keys)
		{
			object obj = P_0[key];
			object obj2 = P_1[key];
			if (obj is Dictionary<string, object> dictionary && obj2 is Dictionary<string, object> dictionary2 && !LEhcSj3my(dictionary, dictionary2))
			{
				return false;
			}
		}
		return true;
	}

	private static bool MXOpAbTHn(Type P_0)
	{
		if (!P_0.IsPrimitive && !P_0.IsEnum && !(P_0 == typeof(string)))
		{
			return P_0 == typeof(decimal);
		}
		return true;
	}

	static JsonPropertyComparer()
	{
		G2089JiDB7k4x1yr7J.kLjw4iIsCLsZtxc4lksN0j();
	}
}
