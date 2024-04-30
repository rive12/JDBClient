using System;
using HarmonyLib;
using UnityEngine;

namespace StupidTemplate.Patches
{
	// Token: 0x0200000C RID: 12
	[HarmonyPatch(typeof(GorillaNot), "IncrementRPCCallLocal")]
	public class NoIncrementRPCCallLocal : MonoBehaviour
	{
		// Token: 0x06000019 RID: 25 RVA: 0x00002300 File Offset: 0x00000500
		private static bool Prefix(PhotonMessageInfoWrapped infoWrapped, string rpcFunction)
		{
			return false;
		}
	}
}
