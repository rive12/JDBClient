using System;

namespace StupidTemplate.Mods
{
	// Token: 0x02000024 RID: 36
	internal class InvisMonke
	{
		// Token: 0x06000050 RID: 80 RVA: 0x000032B0 File Offset: 0x000014B0
		public static void InvisMonkeX()
		{
			bool rightControllerSecondaryButton = ControllerInputPoller.instance.rightControllerSecondaryButton;
			if (rightControllerSecondaryButton)
			{
				GorillaTagger.Instance.offlineVRRig.headBodyOffset.x = 180f;
			}
			else
			{
				GorillaTagger.Instance.offlineVRRig.headBodyOffset.x = 0f;
			}
		}
	}
}
