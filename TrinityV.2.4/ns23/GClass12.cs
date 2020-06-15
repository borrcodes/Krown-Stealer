using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using ns21;

namespace ns23
{
	// Token: 0x0200002A RID: 42
	public class GClass12
	{
		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00003D3D File Offset: 0x00001F3D
		// (set) Token: 0x06000170 RID: 368 RVA: 0x00003D45 File Offset: 0x00001F45
		public GEnum1 GEnum1_0 { get; set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00003D4E File Offset: 0x00001F4E
		// (set) Token: 0x06000172 RID: 370 RVA: 0x00003D56 File Offset: 0x00001F56
		public byte[] Byte_0 { get; set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000173 RID: 371 RVA: 0x00003D5F File Offset: 0x00001F5F
		// (set) Token: 0x06000174 RID: 372 RVA: 0x00003D67 File Offset: 0x00001F67
		public int Int32_0 { get; set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000175 RID: 373 RVA: 0x00003D70 File Offset: 0x00001F70
		// (set) Token: 0x06000176 RID: 374 RVA: 0x00003D78 File Offset: 0x00001F78
		public List<GClass12> List_0 { get; set; }

		// Token: 0x06000177 RID: 375 RVA: 0x00003D81 File Offset: 0x00001F81
		public GClass12()
		{
			this.List_0 = new List<GClass12>();
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0000CC18 File Offset: 0x0000AE18
		public virtual string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			StringBuilder stringBuilder2 = new StringBuilder();
			GEnum1 genum = this.GEnum1_0;
			switch (genum)
			{
			case GEnum1.Integer:
				foreach (byte b in this.Byte_0)
				{
					stringBuilder2.AppendFormat("{0:X2}", b);
				}
				stringBuilder.Append("\tINTEGER ").Append(stringBuilder2).AppendLine();
				break;
			case GEnum1.BitString:
			case GEnum1.Null:
				break;
			case GEnum1.OctetString:
				foreach (byte b2 in this.Byte_0)
				{
					stringBuilder2.AppendFormat("{0:X2}", b2);
				}
				stringBuilder.Append("\tOCTETSTRING ").AppendLine(stringBuilder2.ToString());
				break;
			case GEnum1.ObjectIdentifier:
				foreach (byte b3 in this.Byte_0)
				{
					stringBuilder2.AppendFormat("{0:X2}", b3);
				}
				stringBuilder.Append("\tOBJECTIDENTIFIER ").AppendLine(stringBuilder2.ToString());
				break;
			default:
				if (genum == GEnum1.Sequence)
				{
					stringBuilder.AppendLine("SEQUENCE {");
				}
				break;
			}
			foreach (GClass12 gclass in this.List_0)
			{
				stringBuilder.Append(gclass.ToString());
			}
			if (this.GEnum1_0 == GEnum1.Sequence)
			{
				stringBuilder.AppendLine("}");
			}
			stringBuilder2.Remove(0, stringBuilder2.Length - 1);
			return stringBuilder.ToString();
		}

		// Token: 0x04000099 RID: 153
		[CompilerGenerated]
		private GEnum1 genum1_0;

		// Token: 0x0400009A RID: 154
		[CompilerGenerated]
		private byte[] byte_0;

		// Token: 0x0400009B RID: 155
		[CompilerGenerated]
		private int int_0;

		// Token: 0x0400009C RID: 156
		[CompilerGenerated]
		private List<GClass12> list_0;
	}
}
