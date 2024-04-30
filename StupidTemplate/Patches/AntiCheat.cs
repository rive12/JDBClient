using System;
using HarmonyLib;
using UnityEngine;

namespace StupidTemplate.Patches
{
	// Token: 0x02000007 RID: 7
	[HarmonyPatch(typeof(GorillaNot), "SendReport")]
	internal class AntiCheat : MonoBehaviour
	{
		// Token: 0x0600000F RID: 15 RVA: 0x00002274 File Offset: 0x00000474
		private static bool Prefix(string susReason, string susId, string susNick)
		{
			return false;
		}
	}
}
