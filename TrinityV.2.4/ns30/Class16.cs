using System;
using System.Runtime.CompilerServices;

namespace ns30
{
	// Token: 0x02000031 RID: 49
	internal class Class16
	{
		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060001AD RID: 429 RVA: 0x00003F0A File Offset: 0x0000210A
		// (set) Token: 0x060001AE RID: 430 RVA: 0x00003F12 File Offset: 0x00002112
		public string String_0 { get; set; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060001AF RID: 431 RVA: 0x00003F1B File Offset: 0x0000211B
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x00003F23 File Offset: 0x00002123
		public string String_1 { get; set; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x00003F2C File Offset: 0x0000212C
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x00003F34 File Offset: 0x00002134
		public string String_2 { get; set; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x00003F3D File Offset: 0x0000213D
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x00003F45 File Offset: 0x00002145
		public string String_3 { get; set; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x00003F4E File Offset: 0x0000214E
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x00003F56 File Offset: 0x00002156
		public string String_4 { get; set; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x00003F5F File Offset: 0x0000215F
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x00003F67 File Offset: 0x00002167
		public string String_5 { get; set; }

		// Token: 0x060001B9 RID: 441 RVA: 0x0000D720 File Offset: 0x0000B920
		public virtual string ToString()
		{
			return string.Format("{0}\tFALSE\t{1}\t{2}\t{3}\t{4}\t{5}\r\n", new object[]
			{
				this.String_0,
				this.String_3,
				this.String_5.ToUpper(),
				this.String_4,
				this.String_1,
				this.String_2
			});
		}

		// Token: 0x040000B6 RID: 182
		[CompilerGenerated]
		private string string_0;

		// Token: 0x040000B7 RID: 183
		[CompilerGenerated]
		private string string_1;

		// Token: 0x040000B8 RID: 184
		[CompilerGenerated]
		private string string_2;

		// Token: 0x040000B9 RID: 185
		[CompilerGenerated]
		private string string_3;

		// Token: 0x040000BA RID: 186
		[CompilerGenerated]
		private string string_4;

		// Token: 0x040000BB RID: 187
		[CompilerGenerated]
		private string string_5;
	}
}
