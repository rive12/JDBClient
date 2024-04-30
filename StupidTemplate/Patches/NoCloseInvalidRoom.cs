using System;
using HarmonyLib;
using UnityEngine;

namespace StupidTemplate.Patches
{
	// Token: 0x02000009 RID: 9
	[HarmonyPatch(typeof(GorillaNot), "CloseInvalidRoom")]
	public class NoCloseInvalidRoom : MonoBehaviour
	{
		// Token: 0x06000013 RID: 19 RVA: 0x000022AC File Offset: 0x000004AC
		private static bool Prefix()
		{
			return false;
		}
	}
}
