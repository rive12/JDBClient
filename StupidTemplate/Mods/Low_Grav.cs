using System;
using GorillaLocomotion;
using UnityEngine;

namespace StupidTemplate.Mods
{
	// Token: 0x02000030 RID: 48
	internal class Low_Grav
	{
		// Token: 0x06000068 RID: 104 RVA: 0x0000398E File Offset: 0x00001B8E
		public static void LowGravity()
		{
			Player.Instance.bodyCollider.attachedRigidbody.AddForce(Vector3.up * (Time.deltaTime * (7f / Time.deltaTime)), 5);
		}
	}
}
