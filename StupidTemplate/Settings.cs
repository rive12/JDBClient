using System;
using StupidTemplate.Classes;
using StupidTemplate.Menu;
using UnityEngine;

namespace StupidTemplate
{
	// Token: 0x02000002 RID: 2
	internal class Settings
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000002 RID: 2 RVA: 0x00002057 File Offset: 0x00000257
		public static Color OutlineColor { get; internal set; }

		// Token: 0x04000001 RID: 1
		public static ExtGradient backgroundColor = new ExtGradient
		{
			isRainbow = false
		};

		// Token: 0x04000002 RID: 2
		public static ExtGradient[] buttonColors = new ExtGradient[]
		{
			new ExtGradient
			{
				colors = Main.GetSolidGradient(Color.black)
			},
			new ExtGradient
			{
				isRainbow = false
			}
		};

		// Token: 0x04000003 RID: 3
		public static Color[] textColors = new Color[]
		{
			Color.red,
			Color.red
		};

		// Token: 0x04000004 RID: 4
		public static Font currentFont = Resources.GetBuiltinResource(typeof(Font), "Arial.ttf") as Font;

		// Token: 0x04000005 RID: 5
		public static bool fpsCounter = true;

		// Token: 0x04000006 RID: 6
		public static bool disconnectButton = true;

		// Token: 0x04000007 RID: 7
		public static bool rightHanded = false;

		// Token: 0x04000008 RID: 8
		public static bool disableNotifications = false;

		// Token: 0x04000009 RID: 9
		public static KeyCode keyboardButton = 113;

		// Token: 0x0400000A RID: 10
		public static Vector3 menuSize = new Vector3(0.1f, 1f, 1f);

		// Token: 0x0400000B RID: 11
		public static int buttonsPerPage = 8;
	}
}
