using System;
using GorillaLocomotion;
using UnityEngine;

namespace StupidTemplate.Mods
{
	// Token: 0x02000022 RID: 34
	internal class fast
	{
		// Token: 0x0600004B RID: 75 RVA: 0x000031AC File Offset: 0x000013AC
		public static void FastSwim()
		{
			bool inWater = Player.Instance.InWater;
			if (inWater)
			{
				Player.Instance.gameObject.GetComponent<Rigidbody>().velocity *= 1.069f;
			}
		}
	}
}
