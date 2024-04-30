using System;
using GorillaLocomotion;

namespace StupidTemplate.Mods
{
	// Token: 0x02000026 RID: 38
	internal class LongArms
	{
		// Token: 0x06000054 RID: 84 RVA: 0x00003384 File Offset: 0x00001584
		public static void StickLongArms()
		{
			Player.Instance.leftControllerTransform.transform.position = GorillaTagger.Instance.leftHandTransform.position + GorillaTagger.Instance.leftHandTransform.forward * 0.333f;
			Player.Instance.rightControllerTransform.transform.position = GorillaTagger.Instance.rightHandTransform.position + GorillaTagger.Instance.rightHandTransform.forward * 0.333f;
		}
	}
}
