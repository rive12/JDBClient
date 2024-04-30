using System;
using Photon.Pun;

namespace StupidTemplate.Mods
{
	// Token: 0x0200001C RID: 28
	internal class disconnect
	{
		// Token: 0x0600003F RID: 63 RVA: 0x00002DB5 File Offset: 0x00000FB5
		public static void Disconnect()
		{
			PhotonNetwork.Disconnect();
		}
	}
}
