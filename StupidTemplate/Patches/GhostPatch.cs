using System;
using HarmonyLib;
using UnityEngine;

namespace StupidTemplate.Patches
{
	// Token: 0x02000011 RID: 17
	[HarmonyPatch(typeof(VRRig), "OnDisable")]
	internal class GhostPatch : MonoBehaviour
	{
		// Token: 0x06000024 RID: 36 RVA: 0x0000238C File Offset: 0x0000058C
		public static bool Prefix(VRRig __instance)
		{
			return !(__instance == GorillaTagger.Instance.offlineVRRig);
		}
	}
}
