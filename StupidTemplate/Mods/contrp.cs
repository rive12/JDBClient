using System;
using GorillaLocomotion;

namespace StupidTemplate.Mods
{
	// Token: 0x0200001A RID: 26
	internal class contrp
	{
		// Token: 0x0600003B RID: 59 RVA: 0x00002D74 File Offset: 0x00000F74
		public static void EnableSlideControl()
		{
			contrp.oldSlide = Player.Instance.slideControl;
			Player.Instance.slideControl = 1f;
		}

		// Token: 0x04000024 RID: 36
		private static float oldSlide;
	}
}
