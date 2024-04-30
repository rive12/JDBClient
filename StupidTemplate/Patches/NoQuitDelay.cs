using System;
using HarmonyLib;
using UnityEngine;

namespace StupidTemplate.Patches
{
	// Token: 0x0200000B RID: 11
	[HarmonyPatch(typeof(GorillaNot), "QuitDelay", 5)]
	public class NoQuitDelay : MonoBehaviour
	{
		// Token: 0x06000017 RID: 23 RVA: 0x000022E4 File Offset: 0x000004E4
		private static bool Prefix()
		{
			return false;
		}
	}
}
