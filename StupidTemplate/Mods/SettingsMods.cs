using System;
using Photon.Pun;
using StupidTemplate.Menu;

namespace StupidTemplate.Mods
{
	// Token: 0x02000038 RID: 56
	internal class SettingsMods
	{
		// Token: 0x06000078 RID: 120 RVA: 0x00003C64 File Offset: 0x00001E64
		public static void EnterSettings()
		{
			Main.buttonsType = 1;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00003C6D File Offset: 0x00001E6D
		public static void MenuSettings()
		{
			Main.buttonsType = 2;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00003C76 File Offset: 0x00001E76
		public static void MovementSettings()
		{
			Main.buttonsType = 3;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00003C7F File Offset: 0x00001E7F
		public static void ProjectileSettings()
		{
			Main.buttonsType = 4;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00003C88 File Offset: 0x00001E88
		public static void RightHand()
		{
			Settings.rightHanded = true;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00003C91 File Offset: 0x00001E91
		public static void LeftHand()
		{
			Settings.rightHanded = false;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00003C9A File Offset: 0x00001E9A
		public static void EnableFPSCounter()
		{
			Settings.fpsCounter = true;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00003CA3 File Offset: 0x00001EA3
		public static void DisableFPSCounter()
		{
			Settings.fpsCounter = false;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00003CAC File Offset: 0x00001EAC
		public static void EnableNotifications()
		{
			Settings.disableNotifications = false;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00003CB5 File Offset: 0x00001EB5
		public static void DisableNotifications()
		{
			Settings.disableNotifications = true;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00003CBE File Offset: 0x00001EBE
		public static void EnableDisconnectButton()
		{
			Settings.disconnectButton = true;
			PhotonNetwork.Disconnect();
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00003CCF File Offset: 0x00001ECF
		public static void DisableDisconnectButton()
		{
			Settings.disconnectButton = false;
		}
	}
}
