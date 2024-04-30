using System;
using HarmonyLib;
using Photon.Pun;
using Photon.Realtime;
using StupidTemplate.Notifications;
using UnityEngine;

namespace StupidTemplate.Patches
{
	// Token: 0x02000005 RID: 5
	[HarmonyPatch(typeof(MonoBehaviourPunCallbacks), "OnPlayerLeftRoom")]
	internal class LeavePatch : MonoBehaviour
	{
		// Token: 0x06000008 RID: 8 RVA: 0x0000218C File Offset: 0x0000038C
		private static void Prefix(Player otherPlayer)
		{
			bool flag = otherPlayer != PhotonNetwork.LocalPlayer && otherPlayer != LeavePatch.a;
			if (flag)
			{
				NotifiLib.SendNotification("<color=grey>[</color><color=red>LEAVE</color><color=grey>]</color> <color=white>Name: " + otherPlayer.NickName + "</color>");
				LeavePatch.a = otherPlayer;
			}
		}

		// Token: 0x04000012 RID: 18
		private static Player a;
	}
}
