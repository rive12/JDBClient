using System;
using HarmonyLib;
using UnityEngine;

namespace StupidTemplate.Patches
{
	// Token: 0x0200000A RID: 10
	[HarmonyPatch(typeof(GorillaNot), "CheckReports", 5)]
	public class NoCheckReports : MonoBehaviour
	{
		// Token: 0x06000015 RID: 21 RVA: 0x000022C8 File Offset: 0x000004C8
		private static bool Prefix()
		{
			return false;
		}
	}
}
