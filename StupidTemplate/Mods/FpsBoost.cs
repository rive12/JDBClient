using System;
using GorillaLocomotion;
using UnityEngine;

namespace StupidTemplate.Mods
{
	// Token: 0x0200002A RID: 42
	internal class FpsBoost
	{
		// Token: 0x0600005C RID: 92 RVA: 0x000036A2 File Offset: 0x000018A2
		public static void FPSBoostx()
		{
			Player.Instance.bodyCollider.attachedRigidbody.AddForce(Vector3.up * (Time.deltaTime * (12f / Time.deltaTime)), 5);
		}
	}
}
