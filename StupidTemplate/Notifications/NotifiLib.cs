using System;
using System.Linq;
using BepInEx;
using UnityEngine;
using UnityEngine.UI;

namespace StupidTemplate.Notifications
{
	// Token: 0x02000013 RID: 19
	[BepInPlugin("org.gorillatag.lars.notifications2", "NotificationLibrary", "1.0.5")]
	public class NotifiLib : BaseUnityPlugin
	{
		// Token: 0x06000028 RID: 40 RVA: 0x00002419 File Offset: 0x00000619
		private void Awake()
		{
			base.Logger.LogInfo("Plugin NotificationLibrary is loaded!");
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002430 File Offset: 0x00000630
		private void Init()
		{
			this.MainCamera = GameObject.Find("Main Camera");
			this.HUDObj = new GameObject();
			this.HUDObj2 = new GameObject();
			this.HUDObj2.name = "NOTIFICATIONLIB_HUD_OBJ";
			this.HUDObj.name = "NOTIFICATIONLIB_HUD_OBJ";
			this.HUDObj.AddComponent<Canvas>();
			this.HUDObj.AddComponent<CanvasScaler>();
			this.HUDObj.AddComponent<GraphicRaycaster>();
			this.HUDObj.GetComponent<Canvas>().enabled = true;
			this.HUDObj.GetComponent<Canvas>().renderMode = 2;
			this.HUDObj.GetComponent<Canvas>().worldCamera = this.MainCamera.GetComponent<Camera>();
			this.HUDObj.GetComponent<RectTransform>().sizeDelta = new Vector2(5f, 5f);
			this.HUDObj.GetComponent<RectTransform>().position = new Vector3(this.MainCamera.transform.position.x, this.MainCamera.transform.position.y, this.MainCamera.transform.position.z);
			this.HUDObj2.transform.position = new Vector3(this.MainCamera.transform.position.x, this.MainCamera.transform.position.y, this.MainCamera.transform.position.z - 4.6f);
			this.HUDObj.transform.parent = this.HUDObj2.transform;
			this.HUDObj.GetComponent<RectTransform>().localPosition = new Vector3(0f, 0f, 1.6f);
			Vector3 eulerAngles = this.HUDObj.GetComponent<RectTransform>().rotation.eulerAngles;
			eulerAngles.y = -270f;
			this.HUDObj.transform.localScale = new Vector3(1f, 1f, 1f);
			this.HUDObj.GetComponent<RectTransform>().rotation = Quaternion.Euler(eulerAngles);
			this.Testtext = new GameObject
			{
				transform = 
				{
					parent = this.HUDObj.transform
				}
			}.AddComponent<Text>();
			this.Testtext.text = "";
			this.Testtext.fontSize = 30;
			this.Testtext.font = Settings.currentFont;
			this.Testtext.rectTransform.sizeDelta = new Vector2(450f, 210f);
			this.Testtext.alignment = 6;
			this.Testtext.rectTransform.localScale = new Vector3(0.0033333334f, 0.0033333334f, 0.33333334f);
			this.Testtext.rectTransform.localPosition = new Vector3(-1f, -1f, -0.5f);
			this.Testtext.material = this.AlertText;
			NotifiLib.NotifiText = this.Testtext;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002748 File Offset: 0x00000948
		private void FixedUpdate()
		{
			bool flag = !this.HasInit && GameObject.Find("Main Camera") != null;
			bool flag2 = flag;
			if (flag2)
			{
				this.Init();
				this.HasInit = true;
			}
			this.HUDObj2.transform.position = new Vector3(this.MainCamera.transform.position.x, this.MainCamera.transform.position.y, this.MainCamera.transform.position.z);
			this.HUDObj2.transform.rotation = this.MainCamera.transform.rotation;
			bool flag3 = this.Testtext.text != "";
			if (flag3)
			{
				this.NotificationDecayTimeCounter++;
				bool flag4 = this.NotificationDecayTimeCounter > this.NotificationDecayTime;
				if (flag4)
				{
					this.Notifilines = null;
					this.newtext = "";
					this.NotificationDecayTimeCounter = 0;
					this.Notifilines = Enumerable.ToArray<string>(Enumerable.Skip<string>(this.Testtext.text.Split(Environment.NewLine.ToCharArray()), 1));
					foreach (string text in this.Notifilines)
					{
						bool flag5 = text != "";
						if (flag5)
						{
							this.newtext = this.newtext + text + "\n";
						}
					}
					this.Testtext.text = this.newtext;
				}
			}
			else
			{
				this.NotificationDecayTimeCounter = 0;
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000028F4 File Offset: 0x00000AF4
		public static void SendNotification(string NotificationText)
		{
			bool flag = !Settings.disableNotifications;
			if (flag)
			{
				try
				{
					bool flag2 = NotifiLib.IsEnabled && NotifiLib.PreviousNotifi != NotificationText;
					if (flag2)
					{
						bool flag3 = !NotificationText.Contains(Environment.NewLine);
						if (flag3)
						{
							NotificationText += Environment.NewLine;
						}
						NotifiLib.NotifiText.text = NotifiLib.NotifiText.text + NotificationText;
						NotifiLib.NotifiText.supportRichText = true;
						NotifiLib.PreviousNotifi = NotificationText;
					}
				}
				catch
				{
					Debug.LogError("Notification failed, object probably nil due to third person ; " + NotificationText);
				}
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000029A8 File Offset: 0x00000BA8
		public static void ClearAllNotifications()
		{
			NotifiLib.NotifiText.text = "";
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000029BC File Offset: 0x00000BBC
		public static void ClearPastNotifications(int amount)
		{
			string text = "";
			foreach (string text2 in Enumerable.ToArray<string>(Enumerable.Skip<string>(NotifiLib.NotifiText.text.Split(Environment.NewLine.ToCharArray()), amount)))
			{
				bool flag = text2 != "";
				if (flag)
				{
					text = text + text2 + "\n";
				}
			}
			NotifiLib.NotifiText.text = text;
		}

		// Token: 0x04000015 RID: 21
		private GameObject HUDObj;

		// Token: 0x04000016 RID: 22
		private GameObject HUDObj2;

		// Token: 0x04000017 RID: 23
		private GameObject MainCamera;

		// Token: 0x04000018 RID: 24
		private Text Testtext;

		// Token: 0x04000019 RID: 25
		private Material AlertText = new Material(Shader.Find("GUI/Text Shader"));

		// Token: 0x0400001A RID: 26
		private int NotificationDecayTime = 144;

		// Token: 0x0400001B RID: 27
		private int NotificationDecayTimeCounter;

		// Token: 0x0400001C RID: 28
		public static int NoticationThreshold = 30;

		// Token: 0x0400001D RID: 29
		private string[] Notifilines;

		// Token: 0x0400001E RID: 30
		private string newtext;

		// Token: 0x0400001F RID: 31
		public static string PreviousNotifi;

		// Token: 0x04000020 RID: 32
		private bool HasInit;

		// Token: 0x04000021 RID: 33
		private static Text NotifiText;

		// Token: 0x04000022 RID: 34
		public static bool IsEnabled = true;
	}
}
