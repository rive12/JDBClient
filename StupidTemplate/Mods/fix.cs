using System;

namespace StupidTemplate.Mods
{
	// Token: 0x02000025 RID: 37
	internal class fix
	{
		// Token: 0x06000052 RID: 82 RVA: 0x00003310 File Offset: 0x00001510
		public static void FixHead()
		{
			GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.x = 0f;
			GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.y = 0f;
			GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.z = 0f;
		}
	}
}
