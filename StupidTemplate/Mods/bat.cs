using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace StupidTemplate.Mods
{
	// Token: 0x02000018 RID: 24
	internal class bat
	{
		// Token: 0x06000037 RID: 55 RVA: 0x00002CE0 File Offset: 0x00000EE0
		public static void GrabBat()
		{
			bool flag = ControllerInputPoller.instance.rightGrab || Mouse.current.rightButton.isPressed;
			if (flag)
			{
				GameObject.Find("Cave Bat Holdable").transform.position = GorillaTagger.Instance.rightHandTransform.position;
			}
		}
	}
}
