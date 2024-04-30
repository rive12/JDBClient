using System;
using StupidTemplate.Notifications;
using UnityEngine;

namespace StupidTemplate.Mods
{
	// Token: 0x0200001D RID: 29
	internal class dougses
	{
		// Token: 0x06000041 RID: 65 RVA: 0x00002DC8 File Offset: 0x00000FC8
		public static void SeizureBug()
		{
			GameObject gameObject = GameObject.Find("Floating Bug Holdable");
			ThrowableBug component = GameObject.Find("Floating Bug Holdable").GetComponent<ThrowableBug>();
			bool flag = component.IsMyItem();
			bool flag2 = flag;
			if (flag2)
			{
				bool rightGrab = ControllerInputPoller.instance.rightGrab;
				bool flag3 = rightGrab;
				if (flag3)
				{
					float num = 500f;
					gameObject.transform.Rotate(Vector3.up, num * Time.deltaTime);
					gameObject.transform.Rotate(Vector3.forward, num * Time.deltaTime);
					gameObject.transform.Rotate(Vector3.right, num * Time.deltaTime);
				}
			}
			else
			{
				NotifiLib.SendNotification("<color=red>Please grab the bug first!</color>");
			}
		}
	}
}
