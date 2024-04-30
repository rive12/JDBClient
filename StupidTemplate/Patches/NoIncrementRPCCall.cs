using System;
using HarmonyLib;
using Photon.Pun;
using UnityEngine;

namespace StupidTemplate.Patches
{
	// Token: 0x0200000E RID: 14
	[HarmonyPatch(typeof(GorillaNot), "IncrementRPCCall", new Type[]
	{
		typeof(PhotonMessageInfo),
		typeof(string)
	})]
	public class NoIncrementRPCCall : MonoBehaviour
	{
		// Token: 0x0600001D RID: 29 RVA: 0x00002338 File Offset: 0x00000538
		private static bool Prefix(PhotonMessageInfo info, string callingMethod = "")
		{
			return false;
		}
	}
}
