using System;
using System.Runtime.CompilerServices;

namespace ns33
{
	// Token: 0x02000034 RID: 52
	internal class Class19
	{
		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060001CC RID: 460 RVA: 0x00003F7C File Offset: 0x0000217C
		// (set) Token: 0x060001CD RID: 461 RVA: 0x00003F84 File Offset: 0x00002184
		public string String_0 { get; set; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060001CE RID: 462 RVA: 0x00003F8D File Offset: 0x0000218D
		// (set) Token: 0x060001CF RID: 463 RVA: 0x00003F95 File Offset: 0x00002195
		public string String_1 { get; set; }

		// Token: 0x060001D0 RID: 464 RVA: 0x00003F9E File Offset: 0x0000219E
		public virtual string ToString()
		{
			return string.Format("{0} | {1}\r\n \r\n", this.String_1, this.String_0);
		}

		// Token: 0x040000BE RID: 190
		[CompilerGenerated]
		private string string_0;

		// Token: 0x040000BF RID: 191
		[CompilerGenerated]
		private string string_1;
	}
}
