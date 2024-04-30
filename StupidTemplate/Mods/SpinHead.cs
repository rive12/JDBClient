using System;

namespace StupidTemplate.Mods
{
	// Token: 0x0200003C RID: 60
	internal class SpinHead
	{
		// Token: 0x0600008D RID: 141 RVA: 0x00003FDE File Offset: 0x000021DE
		public static void SpinHeadX()
		{
			VRMap head = GorillaTagger.Instance.offlineVRRig.head;
			head.trackingRotationOffset.x = head.trackingRotationOffset.x + 10f;
		}
	}
}
