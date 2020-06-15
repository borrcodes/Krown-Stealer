using System;
using System.Globalization;
using System.IO;
using System.Text;
using ns2;
using ns3;

namespace ns6
{
	// Token: 0x02000010 RID: 16
	public class GClass5 : GClass2
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600007C RID: 124 RVA: 0x000033EB File Offset: 0x000015EB
		public object Object_0
		{
			get
			{
				return this.object_0;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00006E60 File Offset: 0x00005060
		public virtual GEnum0 GEnum0_0
		{
			get
			{
				if (this.object_0 == null)
				{
					return GEnum0.String;
				}
				TypeCode typeCode = Type.GetTypeCode(this.object_0.GetType());
				switch (typeCode)
				{
				case TypeCode.Object:
				case TypeCode.Char:
					return GEnum0.String;
				case TypeCode.DBNull:
					break;
				case TypeCode.Boolean:
					return GEnum0.Boolean;
				default:
					if (typeCode == TypeCode.DateTime || typeCode == TypeCode.String)
					{
						return GEnum0.String;
					}
					break;
				}
				return GEnum0.Number;
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000033F3 File Offset: 0x000015F3
		public GClass5(bool bool_0)
		{
			this.object_0 = bool_0;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00003407 File Offset: 0x00001607
		public GClass5(byte byte_2)
		{
			this.object_0 = byte_2;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000341B File Offset: 0x0000161B
		public GClass5(char char_0)
		{
			this.object_0 = char_0;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000342F File Offset: 0x0000162F
		public GClass5(decimal decimal_0)
		{
			this.object_0 = decimal_0;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00003443 File Offset: 0x00001643
		public GClass5(double double_0)
		{
			this.object_0 = double_0;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00003457 File Offset: 0x00001657
		public GClass5(float float_0)
		{
			this.object_0 = float_0;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000346B File Offset: 0x0000166B
		public GClass5(int int_0)
		{
			this.object_0 = int_0;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000347F File Offset: 0x0000167F
		public GClass5(long long_0)
		{
			this.object_0 = long_0;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00003493 File Offset: 0x00001693
		public GClass5(sbyte sbyte_0)
		{
			this.object_0 = sbyte_0;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000034A7 File Offset: 0x000016A7
		public GClass5(short short_0)
		{
			this.object_0 = short_0;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000034BB File Offset: 0x000016BB
		public GClass5(string string_0)
		{
			this.object_0 = string_0;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000034CA File Offset: 0x000016CA
		public GClass5(DateTime dateTime_0)
		{
			this.object_0 = dateTime_0;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000034DE File Offset: 0x000016DE
		public GClass5(uint uint_0)
		{
			this.object_0 = uint_0;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000034F2 File Offset: 0x000016F2
		public GClass5(ulong ulong_0)
		{
			this.object_0 = ulong_0;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00003506 File Offset: 0x00001706
		public GClass5(ushort ushort_0)
		{
			this.object_0 = ushort_0;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000351A File Offset: 0x0000171A
		public GClass5(DateTimeOffset dateTimeOffset_0)
		{
			this.object_0 = dateTimeOffset_0;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000352E File Offset: 0x0000172E
		public GClass5(Guid guid_0)
		{
			this.object_0 = guid_0;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00003542 File Offset: 0x00001742
		public GClass5(TimeSpan timeSpan_0)
		{
			this.object_0 = timeSpan_0;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000034BB File Offset: 0x000016BB
		public GClass5(Uri uri_0)
		{
			this.object_0 = uri_0;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000034BB File Offset: 0x000016BB
		public GClass5(object object_1)
		{
			this.object_0 = object_1;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00006EB0 File Offset: 0x000050B0
		public virtual void vmethod_1(Stream stream_0, bool bool_0)
		{
			GEnum0 genum0_ = this.GEnum0_0;
			if (genum0_ == GEnum0.String)
			{
				stream_0.WriteByte(34);
				byte[] bytes = Encoding.UTF8.GetBytes(base.method_3(this.object_0.ToString()));
				stream_0.Write(bytes, 0, bytes.Length);
				stream_0.WriteByte(34);
				return;
			}
			if (genum0_ != GEnum0.Boolean)
			{
				byte[] bytes2 = Encoding.UTF8.GetBytes(this.method_6());
				stream_0.Write(bytes2, 0, bytes2.Length);
				return;
			}
			if ((bool)this.object_0)
			{
				stream_0.Write(GClass5.byte_0, 0, 4);
				return;
			}
			stream_0.Write(GClass5.byte_1, 0, 5);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00006F48 File Offset: 0x00005148
		public string method_6()
		{
			GEnum0 genum0_ = this.GEnum0_0;
			if (genum0_ != GEnum0.String)
			{
				if (genum0_ != GEnum0.Number)
				{
					throw new InvalidOperationException();
				}
				string text = (this.object_0 is float || this.object_0 is double) ? ((IFormattable)this.object_0).ToString("R", NumberFormatInfo.InvariantInfo) : ((IFormattable)this.object_0).ToString("G", NumberFormatInfo.InvariantInfo);
				if (!(text == "NaN") && !(text == "Infinity") && !(text == "-Infinity"))
				{
					return text;
				}
				return "\"" + text + "\"";
			}
			else if (!(this.object_0 is string) && this.object_0 != null)
			{
				if (this.object_0 is char)
				{
					return this.object_0.ToString();
				}
				string str = "GetFormattedString from value type ";
				Type type = this.object_0.GetType();
				throw new NotImplementedException(str + ((type != null) ? type.ToString() : null));
			}
			else
			{
				string text2 = this.object_0 as string;
				if (string.IsNullOrEmpty(text2))
				{
					return "null";
				}
				return text2.Trim(new char[]
				{
					'"'
				});
			}
		}

		// Token: 0x04000035 RID: 53
		private object object_0;

		// Token: 0x04000036 RID: 54
		private static readonly byte[] byte_0 = Encoding.UTF8.GetBytes("true");

		// Token: 0x04000037 RID: 55
		private static readonly byte[] byte_1 = Encoding.UTF8.GetBytes("false");
	}
}
