using System;
using HarmonyLib;
using UnityEngine;

namespace StupidTemplate.Patches
{
	// Token: 0x0200000D RID: 13
	[HarmonyPatch(typeof(GorillaNot), "GetRPCCallTracker")]
	internal class NoGetRPCCallTracker : MonoBehaviour
	{
		// Token: 0x0600001B RID: 27 RVA: 0x0000231C File Offset: 0x0000051C
		private static bool Prefix()
		{
			return false;
		}
	}
}
