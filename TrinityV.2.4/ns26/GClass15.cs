using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace ns26
{
	// Token: 0x0200002D RID: 45
	public class GClass15
	{
		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00003E82 File Offset: 0x00002082
		public string String_0 { get; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000198 RID: 408 RVA: 0x00003E8A File Offset: 0x0000208A
		public string String_1 { get; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000199 RID: 409 RVA: 0x00003E92 File Offset: 0x00002092
		public string String_2 { get; }

		// Token: 0x0600019A RID: 410 RVA: 0x0000CE7C File Offset: 0x0000B07C
		public GClass15(string string_3)
		{
			int num = int.Parse(string_3.Substring(2, 2), NumberStyles.HexNumber) * 2;
			this.String_0 = string_3.Substring(6, num);
			int num2 = string_3.Length - (6 + num + 36);
			this.String_1 = string_3.Substring(6 + num + 36, num2);
			this.String_2 = string_3.Substring(6 + num + 4 + num2);
		}

		// Token: 0x040000AB RID: 171
		[CompilerGenerated]
		private readonly string string_0;

		// Token: 0x040000AC RID: 172
		[CompilerGenerated]
		private readonly string string_1;

		// Token: 0x040000AD RID: 173
		[CompilerGenerated]
		private readonly string string_2;
	}
}
