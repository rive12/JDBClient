using System;
using UnityEngine;

namespace StupidTemplate.Mods
{
	// Token: 0x02000023 RID: 35
	internal class WallWalk
	{
		// Token: 0x0600004D RID: 77 RVA: 0x000031F8 File Offset: 0x000013F8
		public static void GripMonkeWWRight()
		{
			bool rightControllerSecondaryButton = ControllerInputPoller.instance.rightControllerSecondaryButton;
			bool flag = rightControllerSecondaryButton;
			if (flag)
			{
				GorillaTagger.Instance.bodyCollider.attachedRigidbody.AddForce(Vector3.right * (Time.deltaTime * (10f / Time.deltaTime)), 5);
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00003250 File Offset: 0x00001450
		public static void GripMonkeWWLeft()
		{
			bool leftControllerSecondaryButton = ControllerInputPoller.instance.leftControllerSecondaryButton;
			bool flag = leftControllerSecondaryButton;
			if (flag)
			{
				GorillaTagger.Instance.bodyCollider.attachedRigidbody.AddForce(Vector3.left * (Time.deltaTime * (10f / Time.deltaTime)), 5);
			}
		}
	}
}
