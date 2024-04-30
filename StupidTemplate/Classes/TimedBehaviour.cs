using System;
using UnityEngine;

namespace StupidTemplate.Classes
{
	// Token: 0x0200004A RID: 74
	public class TimedBehaviour : MonoBehaviour
	{
		// Token: 0x060000B7 RID: 183 RVA: 0x00006E96 File Offset: 0x00005096
		public virtual void Start()
		{
			this.startTime = Time.time;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00006EA4 File Offset: 0x000050A4
		public virtual void Update()
		{
			bool flag = !this.complete;
			if (flag)
			{
				this.progress = Mathf.Clamp((Time.time - this.startTime) / this.duration, 0f, 1f);
				bool flag2 = Time.time - this.startTime > this.duration;
				if (flag2)
				{
					bool flag3 = this.loop;
					if (flag3)
					{
						this.OnLoop();
					}
					else
					{
						this.complete = true;
					}
				}
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00006F21 File Offset: 0x00005121
		public virtual void OnLoop()
		{
			this.startTime = Time.time;
		}

		// Token: 0x04000044 RID: 68
		public bool complete = false;

		// Token: 0x04000045 RID: 69
		public bool loop = true;

		// Token: 0x04000046 RID: 70
		public float progress = 0f;

		// Token: 0x04000047 RID: 71
		protected bool paused = false;

		// Token: 0x04000048 RID: 72
		protected float startTime;

		// Token: 0x04000049 RID: 73
		protected float duration = 2f;
	}
}
