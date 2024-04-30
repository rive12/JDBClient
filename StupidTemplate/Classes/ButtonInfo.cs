using System;

namespace StupidTemplate.Classes
{
	// Token: 0x02000046 RID: 70
	public class ButtonInfo
	{
		// Token: 0x04000037 RID: 55
		public string buttonText = "-";

		// Token: 0x04000038 RID: 56
		public string overlapText = null;

		// Token: 0x04000039 RID: 57
		public Action method = null;

		// Token: 0x0400003A RID: 58
		public Action enableMethod = null;

		// Token: 0x0400003B RID: 59
		public Action disableMethod = null;

		// Token: 0x0400003C RID: 60
		public bool enabled = false;

		// Token: 0x0400003D RID: 61
		public bool isTogglable = true;

		// Token: 0x0400003E RID: 62
		public string toolTip = "This button doesn't have a tooltip/tutorial.";
	}
}
