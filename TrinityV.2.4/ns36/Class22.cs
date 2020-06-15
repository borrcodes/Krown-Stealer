using System;
using System.Runtime.CompilerServices;

namespace ns36
{
	// Token: 0x02000039 RID: 57
	internal class Class22
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x00003FFD File Offset: 0x000021FD
		// (set) Token: 0x060001E6 RID: 486 RVA: 0x00004005 File Offset: 0x00002205
		public string String_0 { get; set; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x0000400E File Offset: 0x0000220E
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x00004016 File Offset: 0x00002216
		public string String_1 { get; set; }

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x0000401F File Offset: 0x0000221F
		// (set) Token: 0x060001EA RID: 490 RVA: 0x00004027 File Offset: 0x00002227
		public string String_2 { get; set; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060001EB RID: 491 RVA: 0x00004030 File Offset: 0x00002230
		// (set) Token: 0x060001EC RID: 492 RVA: 0x00004038 File Offset: 0x00002238
		public string String_3 { get; set; }

		// Token: 0x060001ED RID: 493 RVA: 0x0000F3E0 File Offset: 0x0000D5E0
		public virtual string ToString()
		{
			return string.Format("Host: {0}\r\nLogin : {1}\r\nPassword: {2}\r\nSoft: {3}\r\n \r\n", new object[]
			{
				this.String_0,
				this.String_1,
				this.String_2,
				this.String_3
			});
		}

		// Token: 0x040000D4 RID: 212
		[CompilerGenerated]
		private string string_0;

		// Token: 0x040000D5 RID: 213
		[CompilerGenerated]
		private string string_1;

		// Token: 0x040000D6 RID: 214
		[CompilerGenerated]
		private string string_2;

		// Token: 0x040000D7 RID: 215
		[CompilerGenerated]
		private string string_3;
	}
}
