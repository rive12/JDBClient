using System;
using GorillaLocomotion;

namespace StupidTemplate.Mods
{
	// Token: 0x0200002E RID: 46
	internal class Helicopter
	{
		// Token: 0x06000064 RID: 100 RVA: 0x000037AD File Offset: 0x000019AD
		public static void EnableTagFreeze()
		{
			Player.Instance.disableMovement = true;
		}
	}
}
