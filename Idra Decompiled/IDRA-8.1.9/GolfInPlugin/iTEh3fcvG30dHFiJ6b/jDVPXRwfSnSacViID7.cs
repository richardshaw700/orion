using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using sX02IJN7NqxvB7iKPK;

namespace iTEh3fcvG30dHFiJ6b;

internal static class jDVPXRwfSnSacViID7
{
	public static string qbSC6nSkE()
	{
		EventSystem current = EventSystem.current;
		GameObject val = ((current != null) ? current.currentSelectedGameObject : null);
		if (val == null)
		{
			return Dpdrn94xidrKkBCvWK.vZjKJCNxST(1062);
		}
		string text = Dpdrn94xidrKkBCvWK.vZjKJCNxST(1140) + (((Object)val).name ?? Dpdrn94xidrKkBCvWK.vZjKJCNxST(1168)) + Dpdrn94xidrKkBCvWK.vZjKJCNxST(1186);
		Transform val2 = val.transform;
		List<string> list = new List<string>();
		while ((Object)(object)val2.parent != (Object)null)
		{
			val2 = val2.parent;
			list.Add(((Object)((Component)val2).gameObject).name);
		}
		text = ((list.Count > 0) ? (text + Dpdrn94xidrKkBCvWK.vZjKJCNxST(1234) + string.Join(Dpdrn94xidrKkBCvWK.vZjKJCNxST(1254), list) + Dpdrn94xidrKkBCvWK.vZjKJCNxST(1186)) : (text + Dpdrn94xidrKkBCvWK.vZjKJCNxST(1194)));
		EventSystem current2 = EventSystem.current;
		object obj;
		if (current2 == null)
		{
			obj = null;
		}
		else
		{
			GameObject currentSelectedGameObject = current2.currentSelectedGameObject;
			obj = ((currentSelectedGameObject != null) ? currentSelectedGameObject.GetComponents<MonoBehaviour>() : null);
		}
		MonoBehaviour[] array = (MonoBehaviour[])obj;
		if (array == null || array.Length == 0)
		{
			return text + Dpdrn94xidrKkBCvWK.vZjKJCNxST(1262);
		}
		return text + Dpdrn94xidrKkBCvWK.vZjKJCNxST(1336) + string.Join(Dpdrn94xidrKkBCvWK.vZjKJCNxST(1374), array.Select((MonoBehaviour x) => ((object)x).GetType().Name));
	}
}
