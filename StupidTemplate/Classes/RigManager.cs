using System;
using BepInEx;
using HarmonyLib;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

namespace StupidTemplate.Classes
{
	// Token: 0x02000049 RID: 73
	internal class RigManager : BaseUnityPlugin
	{
		// Token: 0x060000AF RID: 175 RVA: 0x00006C6C File Offset: 0x00004E6C
		public static VRRig GetVRRigFromPlayer(Player p)
		{
			return GorillaGameManager.instance.FindPlayerVRRig(p);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00006C8C File Offset: 0x00004E8C
		public static VRRig GetRandomVRRig(bool includeSelf)
		{
			VRRig vrrig = GorillaParent.instance.vrrigs[Random.Range(0, GorillaParent.instance.vrrigs.Count - 1)];
			VRRig result;
			if (includeSelf)
			{
				result = vrrig;
			}
			else
			{
				bool flag = vrrig != GorillaTagger.Instance.offlineVRRig;
				if (flag)
				{
					result = vrrig;
				}
				else
				{
					result = RigManager.GetRandomVRRig(includeSelf);
				}
			}
			return result;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00006CF4 File Offset: 0x00004EF4
		public static VRRig GetClosestVRRig()
		{
			float num = float.MaxValue;
			VRRig result = null;
			foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
			{
				bool flag = Vector3.Distance(GorillaTagger.Instance.bodyCollider.transform.position, vrrig.transform.position) < num;
				if (flag)
				{
					num = Vector3.Distance(GorillaTagger.Instance.bodyCollider.transform.position, vrrig.transform.position);
					result = vrrig;
				}
			}
			return result;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00006DB0 File Offset: 0x00004FB0
		public static PhotonView GetPhotonViewFromVRRig(VRRig p)
		{
			return (PhotonView)Traverse.Create(p).Field("photonView").GetValue();
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00006DDC File Offset: 0x00004FDC
		public static Player GetRandomPlayer(bool includeSelf)
		{
			Player result;
			if (includeSelf)
			{
				result = PhotonNetwork.PlayerList[Random.Range(0, PhotonNetwork.PlayerList.Length - 1)];
			}
			else
			{
				result = PhotonNetwork.PlayerListOthers[Random.Range(0, PhotonNetwork.PlayerListOthers.Length - 1)];
			}
			return result;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00006E24 File Offset: 0x00005024
		public static Player GetPlayerFromVRRig(VRRig p)
		{
			return RigManager.GetPhotonViewFromVRRig(p).Owner;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00006E44 File Offset: 0x00005044
		public static Player GetPlayerFromID(string id)
		{
			Player result = null;
			foreach (Player player in PhotonNetwork.PlayerList)
			{
				bool flag = player.UserId == id;
				if (flag)
				{
					result = player;
					break;
				}
			}
			return result;
		}
	}
}
