using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace StupidTemplate.Mods
{
	// Token: 0x0200002D RID: 45
	internal class grab
	{
		// Token: 0x06000062 RID: 98 RVA: 0x0000374C File Offset: 0x0000194C
		public static void GrabBug()
		{
			bool flag = ControllerInputPoller.instance.rightGrab || Mouse.current.rightButton.isPressed;
			if (flag)
			{
				GameObject.Find("Floating Bug Holdable").transform.position = GorillaTagger.Instance.rightHandTransform.position;
			}
		}
	}
}
