using System;
using Photon.Pun;
using StupidTemplate.Notifications;

namespace StupidTemplate.Mods
{
	// Token: 0x02000016 RID: 22
	internal class antimod
	{
		// Token: 0x06000033 RID: 51 RVA: 0x00002BE4 File Offset: 0x00000DE4
		public static void antimoderator()
		{
			foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
			{
				bool flag = !vrrig.isOfflineVRRig && vrrig.concatStringOfCosmeticsAllowed.Contains("LBAAK");
				if (flag)
				{
					PhotonNetwork.Disconnect();
					NotifiLib.SendNotification("<color=red>[ANTI-MODERATOR]</color> Someone with the moderator stick joined, disconnected.");
				}
			}
		}
	}
}
