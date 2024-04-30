using System;
using GorillaLocomotion;
using UnityEngine;

namespace StupidTemplate.Mods
{
	// Token: 0x02000028 RID: 40
	internal class NoclipFly
	{
		// Token: 0x06000058 RID: 88 RVA: 0x00003480 File Offset: 0x00001680
		public static void FlyNoclip()
		{
			bool rightControllerPrimaryButton = ControllerInputPoller.instance.rightControllerPrimaryButton;
			if (rightControllerPrimaryButton)
			{
				Player.Instance.transform.position += Player.Instance.headCollider.transform.forward * Time.deltaTime * 13f;
				Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
				foreach (MeshCollider meshCollider in Resources.FindObjectsOfTypeAll<MeshCollider>())
				{
					meshCollider.enabled = false;
				}
			}
			else
			{
				foreach (MeshCollider meshCollider2 in Resources.FindObjectsOfTypeAll<MeshCollider>())
				{
					meshCollider2.enabled = true;
				}
			}
		}
	}
}
