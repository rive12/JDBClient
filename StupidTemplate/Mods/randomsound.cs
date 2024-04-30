using System;
using UnityEngine;

namespace StupidTemplate.Mods
{
	// Token: 0x02000034 RID: 52
	internal class randomsound
	{
		// Token: 0x06000070 RID: 112 RVA: 0x00003AAC File Offset: 0x00001CAC
		public static void RandomSoundSpam()
		{
			bool flag = randomsound.rightGrab;
			if (flag)
			{
				GorillaTagger.Instance.myVRRig.RPC("PlayHandTap", 0, new object[]
				{
					Random.Range(3, 215),
					false,
					999999f
				});
				randomsound.rpc_protection();
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00003B10 File Offset: 0x00001D10
		private static void rpc_protection()
		{
			throw new NotImplementedException();
		}

		// Token: 0x04000027 RID: 39
		private static bool rightGrab;
	}
}
