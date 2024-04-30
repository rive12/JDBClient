using System;
using UnityEngine;

namespace StupidTemplate.Mods
{
	// Token: 0x02000027 RID: 39
	internal class fixw
	{
		// Token: 0x06000056 RID: 86 RVA: 0x00003420 File Offset: 0x00001620
		public static void FixWater()
		{
			GameObject gameObject = GameObject.Find("Environment Objects/LocalObjects_Prefab/Beach/B_WaterVolumes");
			Transform transform = gameObject.transform;
			for (int i = 0; i < transform.childCount; i++)
			{
				GameObject gameObject2 = transform.GetChild(i).gameObject;
				gameObject2.layer = LayerMask.NameToLayer("Water");
			}
		}
	}
}
