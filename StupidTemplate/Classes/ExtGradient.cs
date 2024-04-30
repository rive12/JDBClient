using System;
using UnityEngine;

namespace StupidTemplate.Classes
{
	// Token: 0x02000048 RID: 72
	public class ExtGradient
	{
		// Token: 0x04000041 RID: 65
		public GradientColorKey[] colors = new GradientColorKey[]
		{
			new GradientColorKey(Color.black, 0f),
			new GradientColorKey(Color.magenta, 0.5f),
			new GradientColorKey(Color.black, 1f)
		};

		// Token: 0x04000042 RID: 66
		public bool isRainbow = false;

		// Token: 0x04000043 RID: 67
		public bool copyRigColors = false;
	}
}
