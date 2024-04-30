using System;
using UnityEngine;

namespace StupidTemplate.Mods
{
	// Token: 0x02000021 RID: 33
	internal class fart
	{
		// Token: 0x06000048 RID: 72 RVA: 0x0000302C File Offset: 0x0000122C
		private static GameObject CreatePlatformOnHand(Transform handTransform)
		{
			GameObject gameObject = GameObject.CreatePrimitive(0);
			gameObject.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
			gameObject.transform.position = handTransform.position;
			gameObject.transform.rotation = handTransform.rotation;
			float num = (float)Time.frameCount / 180f % 1f;
			gameObject.GetComponent<Renderer>().material.color = Color.HSVToRGB(num, 1f, 1f);
			return gameObject;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000030C0 File Offset: 0x000012C0
		public static void Platforms2()
		{
			bool flag = ControllerInputPoller.instance.leftGrab && fart.leftplat == null;
			if (flag)
			{
				fart.leftplat = fart.CreatePlatformOnHand(GorillaTagger.Instance.leftHandTransform);
			}
			bool flag2 = ControllerInputPoller.instance.rightGrab && fart.rightplat == null;
			if (flag2)
			{
				fart.rightplat = fart.CreatePlatformOnHand(GorillaTagger.Instance.rightHandTransform);
			}
			bool flag3 = ControllerInputPoller.instance.rightGrabRelease && fart.rightplat != null;
			if (flag3)
			{
				Utils.Disable(fart.rightplat);
				fart.rightplat = null;
			}
			bool flag4 = ControllerInputPoller.instance.leftGrabRelease && fart.leftplat != null;
			if (flag4)
			{
				Utils.Disable(fart.leftplat);
				fart.leftplat = null;
			}
		}

		// Token: 0x04000025 RID: 37
		private static GameObject leftplat;

		// Token: 0x04000026 RID: 38
		private static GameObject rightplat;
	}
}
