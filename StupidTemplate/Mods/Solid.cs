using System;
using UnityEngine;

namespace StupidTemplate.Mods
{
	// Token: 0x0200003A RID: 58
	internal class Solid
	{
		// Token: 0x06000089 RID: 137 RVA: 0x00003F54 File Offset: 0x00002154
		public static void SolidWater()
		{
			GameObject gameObject = GameObject.Find("Environment Objects/LocalObjects_Prefab/Beach/B_WaterVolumes");
			Transform transform = gameObject.transform;
			for (int i = 0; i < transform.childCount; i++)
			{
				GameObject gameObject2 = transform.GetChild(i).gameObject;
				gameObject2.layer = LayerMask.NameToLayer("Default");
			}
		}
	}
}
