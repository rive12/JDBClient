using System;
using HarmonyLib;
using Photon.Pun;
using StupidTemplate.Notifications;
using UnityEngine;

namespace StupidTemplate.Mods
{
	// Token: 0x02000015 RID: 21
	internal class anticheat
	{
		// Token: 0x0200004B RID: 75
		[HarmonyPatch(typeof(GorillaNot), "SendReport")]
		internal class AntiCheat : MonoBehaviour
		{
			// Token: 0x060000BB RID: 187 RVA: 0x00006F64 File Offset: 0x00005164
			private static bool Prefix(string susReason, string susId, string susNick)
			{
				bool flag = susId == PhotonNetwork.LocalPlayer.UserId;
				if (flag)
				{
					bool flag2 = susReason != "empty rig";
					if (flag2)
					{
						Debug.Log("report");
						NotifiLib.SendNotification("<color=red>[ANTICHEAT] REPORTED YOU FOR: " + susReason + "</color>");
					}
				}
				return false;
			}
		}
	}
}
