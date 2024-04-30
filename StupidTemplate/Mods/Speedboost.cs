using System;
using GorillaLocomotion;

namespace StupidTemplate.Mods
{
	// Token: 0x0200003B RID: 59
	internal class Speedboost
	{
		// Token: 0x0600008B RID: 139 RVA: 0x00003FB4 File Offset: 0x000021B4
		public static void SpeedboostMod()
		{
			Player.Instance.maxJumpSpeed = 9f;
			Player.Instance.jumpMultiplier = 9f;
		}
	}
}
