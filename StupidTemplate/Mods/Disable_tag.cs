using System;
using GorillaLocomotion;

namespace StupidTemplate.Mods
{
	// Token: 0x0200001B RID: 27
	internal class Disable_tag
	{
		// Token: 0x0600003D RID: 61 RVA: 0x00002D9E File Offset: 0x00000F9E
		public static void DisableTagFreeze()
		{
			Player.Instance.disableMovement = false;
		}
	}
}
