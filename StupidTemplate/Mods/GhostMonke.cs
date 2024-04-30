using System;

namespace StupidTemplate.Mods
{
	// Token: 0x0200002B RID: 43
	internal class GhostMonke
	{
		// Token: 0x0600005E RID: 94 RVA: 0x000036E4 File Offset: 0x000018E4
		public static void GhostMonk()
		{
			bool rightControllerPrimaryButton = ControllerInputPoller.instance.rightControllerPrimaryButton;
			if (rightControllerPrimaryButton)
			{
				GorillaTagger.Instance.offlineVRRig.enabled = false;
			}
			else
			{
				GorillaTagger.Instance.offlineVRRig.enabled |= true;
			}
		}
	}
}
