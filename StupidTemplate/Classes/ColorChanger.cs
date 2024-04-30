using System;
using UnityEngine;

namespace StupidTemplate.Classes
{
	// Token: 0x02000047 RID: 71
	public class ColorChanger : TimedBehaviour
	{
		// Token: 0x060000AB RID: 171 RVA: 0x00006AFC File Offset: 0x00004CFC
		public override void Start()
		{
			base.Start();
			this.renderer = base.GetComponent<Renderer>();
			this.Update();
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00006B1C File Offset: 0x00004D1C
		public override void Update()
		{
			base.Update();
			bool flag = this.colorInfo != null;
			if (flag)
			{
				bool flag2 = !this.colorInfo.copyRigColors;
				if (flag2)
				{
					Color color = new Gradient
					{
						colorKeys = this.colorInfo.colors
					}.Evaluate(Time.time / 2f % 1f);
					bool isRainbow = this.colorInfo.isRainbow;
					if (isRainbow)
					{
						float num = (float)Time.frameCount / 180f % 1f;
						color = Color.HSVToRGB(num, 1f, 1f);
					}
					this.renderer.material.color = color;
				}
				else
				{
					this.renderer.material = GorillaTagger.Instance.offlineVRRig.mainSkin.material;
				}
			}
		}

		// Token: 0x0400003F RID: 63
		public Renderer renderer;

		// Token: 0x04000040 RID: 64
		public ExtGradient colorInfo;
	}
}
