using System;
using StupidTemplate.Menu;
using UnityEngine;

namespace StupidTemplate.Classes
{
	// Token: 0x02000045 RID: 69
	internal class Button : MonoBehaviour
	{
		// Token: 0x060000A8 RID: 168 RVA: 0x000069FC File Offset: 0x00004BFC
		public void OnTriggerEnter(Collider collider)
		{
			bool flag = Time.time > Button.buttonCooldown && collider == Main.buttonCollider && Main.menu != null;
			if (flag)
			{
				Button.buttonCooldown = Time.time + 0.2f;
				GorillaTagger.Instance.StartVibration(Settings.rightHanded, GorillaTagger.Instance.tagHapticStrength / 2f, GorillaTagger.Instance.tagHapticDuration / 2f);
				GorillaTagger.Instance.offlineVRRig.PlayHandTapLocal(8, Settings.rightHanded, 0.4f);
				Main.Toggle(this.relatedText);
			}
		}

		// Token: 0x04000035 RID: 53
		public string relatedText;

		// Token: 0x04000036 RID: 54
		public static float buttonCooldown;
	}
}
