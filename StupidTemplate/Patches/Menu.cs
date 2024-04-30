using System;
using System.Reflection;
using HarmonyLib;
using UnityEngine;

namespace StupidTemplate.Patches
{
	// Token: 0x02000006 RID: 6
	public class Menu : MonoBehaviour
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000021E0 File Offset: 0x000003E0
		// (set) Token: 0x0600000B RID: 11 RVA: 0x000021E7 File Offset: 0x000003E7
		public static bool IsPatched { get; private set; }

		// Token: 0x0600000C RID: 12 RVA: 0x000021F0 File Offset: 0x000003F0
		internal static void ApplyHarmonyPatches()
		{
			bool flag = !Menu.IsPatched;
			if (flag)
			{
				bool flag2 = Menu.instance == null;
				if (flag2)
				{
					Menu.instance = new Harmony("org.JDB.gorillatag.menutemplate");
				}
				Menu.instance.PatchAll(Assembly.GetExecutingAssembly());
				Menu.IsPatched = true;
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002240 File Offset: 0x00000440
		internal static void RemoveHarmonyPatches()
		{
			bool flag = Menu.instance != null && Menu.IsPatched;
			if (flag)
			{
				Menu.IsPatched = false;
			}
		}

		// Token: 0x04000014 RID: 20
		private static Harmony instance;
	}
}
