using System;
using HarmonyLib;
using UnityEngine;

namespace StupidTemplate.Patches
{
	// Token: 0x0200000F RID: 15
	[HarmonyPatch(typeof(VRRig), "IncrementRPC", new Type[]
	{
		typeof(PhotonMessageInfoWrapped),
		typeof(string)
	})]
	public class NoIncrementRPC : MonoBehaviour
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00002354 File Offset: 0x00000554
		private static bool Prefix(PhotonMessageInfoWrapped info, string sourceCall)
		{
			return false;
		}
	}
}
