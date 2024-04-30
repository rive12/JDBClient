using System;
using GorillaLocomotion;
using Photon.Pun;
using Photon.Realtime;
using StupidTemplate.Notifications;
using UnityEngine;

namespace StupidTemplate.Mods
{
	// Token: 0x0200003E RID: 62
	internal class tag
	{
		// Token: 0x06000091 RID: 145 RVA: 0x00004038 File Offset: 0x00002238
		public static void All()
		{
			bool isMasterClient = PhotonNetwork.IsMasterClient;
			if (isMasterClient)
			{
				foreach (GorillaTagManager gorillaTagManager in Object.FindObjectsOfType<GorillaTagManager>())
				{
					foreach (Player player in PhotonNetwork.PlayerList)
					{
						bool flag = !gorillaTagManager.currentInfected.Contains(player);
						if (flag)
						{
							gorillaTagManager.currentInfected.Add(player);
						}
					}
				}
			}
			else
			{
				bool flag2 = !GorillaTagger.Instance.offlineVRRig.mainSkin.material.name.Contains("fected");
				if (flag2)
				{
					NotifiLib.SendNotification("<color=grey>[</color><color=red>FAILIURE</color><color=grey>]</color> <color=white>You must be tagged.</color>");
				}
				else
				{
					bool flag3 = false;
					foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
					{
						bool flag4 = !vrrig.mainSkin.material.name.Contains("fected");
						if (flag4)
						{
							flag3 = true;
							break;
						}
					}
					bool flag5 = flag3;
					if (flag5)
					{
						foreach (VRRig vrrig2 in GorillaParent.instance.vrrigs)
						{
							bool flag6 = !vrrig2.mainSkin.material.name.Contains("fected");
							if (flag6)
							{
								GorillaTagger.Instance.offlineVRRig.enabled = false;
								GorillaTagger.Instance.offlineVRRig.transform.position = vrrig2.transform.position - new Vector3(0f, -3f, 0f);
								GorillaTagger.Instance.myVRRig.transform.position = vrrig2.transform.position - new Vector3(0f, -3f, 0f);
								Player.Instance.rightControllerTransform.position = vrrig2.transform.position;
							}
						}
					}
					else
					{
						NotifiLib.SendNotification("<color=grey>[</color><color=green>SUCCESS</color><color=grey>]</color> <color=white>Everyone has been tagged.</color>");
						GorillaTagger.Instance.offlineVRRig.enabled = true;
					}
				}
			}
		}

		// Token: 0x04000029 RID: 41
		private static GameObject pointer;
	}
}
