using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace StupidTemplate.Mods
{
	// Token: 0x02000017 RID: 23
	internal class ball
	{
		// Token: 0x06000035 RID: 53 RVA: 0x00002C7C File Offset: 0x00000E7C
		public static void GrabBall()
		{
			bool flag = ControllerInputPoller.instance.rightGrab || Mouse.current.rightButton.isPressed;
			if (flag)
			{
				GameObject.Find("Environment Objects/PersistentObjects_Prefab/WaterPolo/BeachBall").transform.position = GorillaTagger.Instance.rightHandTransform.position;
			}
		}
	}
}
