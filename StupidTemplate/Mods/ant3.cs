using System;
using Photon.Pun;
using StupidTemplate.Notifications;
using UnityEngine;

namespace StupidTemplate.Mods
{
	// Token: 0x02000014 RID: 20
	internal class ant3
	{
		// Token: 0x06000030 RID: 48 RVA: 0x00002A70 File Offset: 0x00000C70
		public static void Disconnect()
		{
			GorillaScoreBoard[] array = Object.FindObjectsOfType<GorillaScoreBoard>();
			bool flag = ant3.AntireportBlock == null;
			if (flag)
			{
				foreach (GorillaScoreBoard gorillaScoreBoard in array)
				{
					ant3.AntireportBlock = GameObject.CreatePrimitive(3);
					ant3.AntireportBlock.transform.localScale = new Vector3(float.MinValue, float.MinValue, float.MinValue);
					ant3.AntireportBlock.transform.position = gorillaScoreBoard.transform.position;
					ant3.AntireportBlock.transform.rotation = gorillaScoreBoard.transform.rotation;
					Object.Destroy(ant3.AntireportBlock.GetComponent<BoxCollider>());
				}
			}
			foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
			{
				bool flag2 = vrrig != GorillaTagger.Instance.offlineVRRig && Vector3.Distance(vrrig.transform.position, ant3.AntireportBlock.transform.position) < 1.7f;
				if (flag2)
				{
					PhotonNetwork.Disconnect();
					NotifiLib.SendNotification("Some loser tried to report you, what the sigma.");
				}
			}
		}

		// Token: 0x04000023 RID: 35
		public static GameObject AntireportBlock;
	}
}
