using System;
using HarmonyLib;
using Photon.Pun;
using Photon.Realtime;
using StupidTemplate.Notifications;
using UnityEngine;

namespace StupidTemplate.Patches
{
	// Token: 0x02000004 RID: 4
	[HarmonyPatch(typeof(MonoBehaviourPunCallbacks), "OnPlayerEnteredRoom")]
	internal class JoinPatch : MonoBehaviour
	{
		// Token: 0x06000006 RID: 6 RVA: 0x00002140 File Offset: 0x00000340
		private static void Prefix(Player newPlayer)
		{
			bool flag = newPlayer != JoinPatch.oldnewplayer;
			if (flag)
			{
				NotifiLib.SendNotification("<color=grey>[</color><color=green>JOIN</color><color=grey>] </color><color=white>Name: " + newPlayer.NickName + "</color>");
				JoinPatch.oldnewplayer = newPlayer;
			}
		}

		// Token: 0x04000011 RID: 17
		private static Player oldnewplayer;
	}
}
