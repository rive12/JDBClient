using System;
using UnityEngine;

namespace StupidTemplate.Mods
{
	// Token: 0x02000031 RID: 49
	internal class Noclip
	{
		// Token: 0x0600006A RID: 106 RVA: 0x000039CC File Offset: 0x00001BCC
		public static void NoclipMod()
		{
			bool rightControllerPrimaryButton = ControllerInputPoller.instance.rightControllerPrimaryButton;
			if (rightControllerPrimaryButton)
			{
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
