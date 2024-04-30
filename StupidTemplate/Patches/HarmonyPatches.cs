using System;
using System.ComponentModel;
using BepInEx;

namespace StupidTemplate.Patches
{
	// Token: 0x02000010 RID: 16
	[Description("Created by @imcool with love <3")]
	[BepInPlugin("org.JDB.gorillatag.menutemplate", "JDB Client", "1.0.0")]
	public class HarmonyPatches : BaseUnityPlugin
	{
		// Token: 0x06000021 RID: 33 RVA: 0x00002370 File Offset: 0x00000570
		private void OnEnable()
		{
			Menu.ApplyHarmonyPatches();
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002379 File Offset: 0x00000579
		private void OnDisable()
		{
			Menu.RemoveHarmonyPatches();
		}
	}
}
