using System;
using Photon.Pun;

namespace StupidTemplate.Mods
{
	// Token: 0x02000035 RID: 53
	internal class rizz
	{
		// Token: 0x06000073 RID: 115 RVA: 0x00003B24 File Offset: 0x00001D24
		public static void joinrandom()
		{
			foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
			{
				bool flag = !vrrig.isOfflineVRRig && vrrig.concatStringOfCosmeticsAllowed.Contains("LBAAK.");
				if (flag)
				{
					PhotonNetwork.Disconnect();
				}
				else
				{
					PhotonNetwork.JoinRandomRoom();
				}
			}
		}
	}
}
