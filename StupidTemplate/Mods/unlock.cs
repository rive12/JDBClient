using System;
using GorillaNetworking;
using UnityEngine;

namespace StupidTemplate.Mods
{
	// Token: 0x02000040 RID: 64
	internal class unlock
	{
		// Token: 0x06000096 RID: 150 RVA: 0x00004534 File Offset: 0x00002734
		public static void UnlockCompetitive()
		{
			GorillaComputer.instance.CompQueueUnlockButtonPress();
			GorillaComputer.instance.allowedInCompetitive = true;
			PlayerPrefs.SetInt("allowedInCompetitive", 1);
			PlayerPrefs.Save();
		}
	}
}
