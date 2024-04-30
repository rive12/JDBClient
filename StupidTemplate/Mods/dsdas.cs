using System;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

namespace StupidTemplate.Mods
{
	// Token: 0x0200001E RID: 30
	internal class dsdas
	{
		// Token: 0x06000043 RID: 67 RVA: 0x00002E84 File Offset: 0x00001084
		public static void TagSelf()
		{
			foreach (GorillaTagManager gorillaTagManager in Object.FindObjectsOfType(typeof(GorillaTagManager)))
			{
				Player localPlayer = PhotonNetwork.LocalPlayer;
				gorillaTagManager.currentInfected.Add(localPlayer);
				gorillaTagManager.UpdateState();
			}
		}
	}
}
