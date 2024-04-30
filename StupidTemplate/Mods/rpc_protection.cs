using System;
using Photon.Pun;

namespace StupidTemplate.Mods
{
	// Token: 0x02000036 RID: 54
	internal class rpc_protection
	{
		// Token: 0x06000075 RID: 117 RVA: 0x00003BBC File Offset: 0x00001DBC
		public static void RPCProtection()
		{
			GorillaNot.instance.rpcErrorMax = int.MaxValue;
			GorillaNot.instance.rpcCallLimit = int.MaxValue;
			GorillaNot.instance.logErrorMax = int.MaxValue;
			PhotonNetwork.RemoveRPCs(PhotonNetwork.LocalPlayer);
			PhotonNetwork.OpCleanRpcBuffer(GorillaTagger.Instance.myVRRig);
			PhotonNetwork.RemoveBufferedRPCs(GorillaTagger.Instance.myVRRig.ViewID, null, null);
			PhotonNetwork.RemoveRPCsInGroup(int.MaxValue);
			PhotonNetwork.SendAllOutgoingCommands();
			GorillaNot.instance.OnPlayerLeftRoom(PhotonNetwork.LocalPlayer);
		}
	}
}
