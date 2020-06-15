using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;
using ns2;
using ns4;
using ns5;
using ns6;
using ns8;

namespace ns3
{
	// Token: 0x02000012 RID: 18
	public abstract class GClass2 : IEnumerable
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00003580 File Offset: 0x00001780
		public virtual int Int32_0
		{
			get
			{
				throw new InvalidOperationException();
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000096 RID: 150
		public abstract GEnum0 GEnum0_0 { get; }

		// Token: 0x1700000F RID: 15
		public virtual GClass2 this[int int_0]
		{
			get
			{
				throw new InvalidOperationException();
			}
			set
			{
				throw new InvalidOperationException();
			}
		}

		// Token: 0x17000010 RID: 16
		public virtual GClass2 this[string string_0]
		{
			get
			{
				throw new InvalidOperationException();
			}
			set
			{
				throw new InvalidOperationException();
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00003587 File Offset: 0x00001787
		public static GClass2 smethod_0(Stream stream_0)
		{
			if (stream_0 == null)
			{
				throw new ArgumentNullException("stream");
			}
			return new ArgumentNullException(new StreamReader(stream_0, true));
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00007088 File Offset: 0x00005288
		public static GClass2 smethod_4<T>(T gparam_0)
		{
			if (gparam_0 == null)
			{
				return null;
			}
			T t;
			if ((t = gparam_0) is bool)
			{
				return new GClass5((bool)((object)t));
			}
			if ((t = gparam_0) is byte)
			{
				return new GClass5((byte)((object)t));
			}
			if ((t = gparam_0) is char)
			{
				return new GClass5((char)((object)t));
			}
			if ((t = gparam_0) is decimal)
			{
				return new GClass5((decimal)((object)t));
			}
			if ((t = gparam_0) is double)
			{
				return new GClass5((double)((object)t));
			}
			if ((t = gparam_0) is float)
			{
				return new GClass5((float)((object)t));
			}
			if ((t = gparam_0) is int)
			{
				return new GClass5((int)((object)t));
			}
			if ((t = gparam_0) is long)
			{
				return new GClass5((long)((object)t));
			}
			if ((t = gparam_0) is sbyte)
			{
				return new GClass5((sbyte)((object)t));
			}
			if ((t = gparam_0) is short)
			{
				return new GClass5((short)((object)t));
			}
			string string_;
			if ((string_ = (gparam_0 as string)) != null)
			{
				return new GClass5(string_);
			}
			if ((t = gparam_0) is uint)
			{
				return new GClass5((uint)((object)t));
			}
			if ((t = gparam_0) is ulong)
			{
				return new GClass5((ulong)((object)t));
			}
			if ((t = gparam_0) is ushort)
			{
				return new GClass5((ushort)((object)t));
			}
			if ((t = gparam_0) is DateTime)
			{
				return new GClass5((DateTime)((object)t));
			}
			if ((t = gparam_0) is DateTimeOffset)
			{
				return new GClass5((DateTimeOffset)((object)t));
			}
			if ((t = gparam_0) is Guid)
			{
				return new GClass5((Guid)((object)t));
			}
			if ((t = gparam_0) is TimeSpan)
			{
				return new GClass5((TimeSpan)((object)t));
			}
			Uri uri_;
			if ((uri_ = (gparam_0 as Uri)) != null)
			{
				return new GClass5(uri_);
			}
			IEnumerable<KeyValuePair<string, object>> enumerable = gparam_0 as IEnumerable<KeyValuePair<string, object>>;
			if (enumerable != null)
			{
				return new GClass4(new GClass2.Class5(enumerable));
			}
			IEnumerable enumerable2 = gparam_0 as IEnumerable;
			if (enumerable2 != null)
			{
				return new GClass3(new GClass2.Class6(enumerable2));
			}
			if (!(gparam_0 is IEnumerable))
			{
				PropertyInfo[] properties = gparam_0.GetType().GetProperties();
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				foreach (PropertyInfo propertyInfo in properties)
				{
					dictionary.Add(propertyInfo.Name, propertyInfo.GetValue(gparam_0, null).smethod_4("null"));
				}
				if (dictionary.Count > 0)
				{
					return new GClass4(new GClass2.Class5(dictionary));
				}
			}
			throw new NotSupportedException(string.Format("Unexpected parser return type: {0}", gparam_0.GetType()));
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000035A7 File Offset: 0x000017A7
		public static GClass2 smethod_5(string string_0)
		{
			if (string_0 == null)
			{
				throw new ArgumentNullException("jsonString");
			}
			return new ArgumentNullException(new StringReader(string_0));
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00003580 File Offset: 0x00001780
		public virtual bool vmethod_0(string string_0)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000035C2 File Offset: 0x000017C2
		public virtual void vmethod_1(Stream stream_0, bool bool_0)
		{
			if (stream_0 == null)
			{
				throw new ArgumentNullException("stream");
			}
			this.vmethod_2(new StreamWriter(stream_0), bool_0);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000035DF File Offset: 0x000017DF
		public virtual void vmethod_2(TextWriter textWriter_0, bool bool_0)
		{
			if (textWriter_0 == null)
			{
				throw new ArgumentNullException("textWriter");
			}
			this.method_0(textWriter_0, bool_0);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000073CC File Offset: 0x000055CC
		private void method_0(TextWriter textWriter_0, bool bool_0)
		{
			switch (this.GEnum0_0)
			{
			case GEnum0.String:
				if (bool_0)
				{
					textWriter_0.Write('"');
				}
				textWriter_0.Write(this.method_3(((GClass5)this).method_6()));
				if (bool_0)
				{
					textWriter_0.Write('"');
					return;
				}
				return;
			case GEnum0.Object:
			{
				textWriter_0.Write('{');
				bool flag = false;
				using (IEnumerator<KeyValuePair<string, GClass2>> enumerator = ((GClass4)this).method_5())
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<string, GClass2> keyValuePair = enumerator.Current;
						if (flag)
						{
							textWriter_0.Write(", ");
						}
						textWriter_0.Write('"');
						textWriter_0.Write(this.method_3(keyValuePair.Key));
						textWriter_0.Write("\": ");
						if (keyValuePair.Value == null)
						{
							textWriter_0.Write("null");
						}
						else
						{
							keyValuePair.Value.method_0(textWriter_0, bool_0);
						}
						flag = true;
					}
				}
				textWriter_0.Write('}');
				return;
			}
			case GEnum0.Array:
			{
				textWriter_0.Write('[');
				bool flag2 = false;
				foreach (GClass2 gclass in ((IEnumerable<GClass2>)((GClass3)this)))
				{
					if (flag2)
					{
						textWriter_0.Write(", ");
					}
					if (gclass != null)
					{
						gclass.method_0(textWriter_0, bool_0);
					}
					else
					{
						textWriter_0.Write("null");
					}
					flag2 = true;
				}
				textWriter_0.Write(']');
				return;
			}
			case GEnum0.Boolean:
				textWriter_0.Write(GClass2.smethod_25(this) ? "true" : "false");
				return;
			}
			textWriter_0.Write(((GClass5)this).method_6());
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000075A0 File Offset: 0x000057A0
		public string method_1(bool bool_0 = true)
		{
			StringWriter stringWriter = new StringWriter();
			this.vmethod_2(stringWriter, bool_0);
			return stringWriter.ToString();
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00003580 File Offset: 0x00001780
		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000075C4 File Offset: 0x000057C4
		private bool method_2(string string_0, int int_0)
		{
			char c = string_0[int_0];
			return c < ' ' || c == '"' || c == '\\' || (c >= '\ud800' && c <= '\udbff' && (int_0 == string_0.Length - 1 || string_0[int_0 + 1] < '\udc00' || string_0[int_0 + 1] > '\udfff')) || (c >= '\udc00' && c <= '\udfff' && (int_0 == 0 || string_0[int_0 - 1] < '\ud800' || string_0[int_0 - 1] > '\udbff')) || c == '\u2028' || c == '\u2029' || (c == '/' && int_0 > 0 && string_0[int_0 - 1] == '<');
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000768C File Offset: 0x0000588C
		public string method_3(string string_0)
		{
			if (string_0 == null)
			{
				return null;
			}
			for (int i = 0; i < string_0.Length; i++)
			{
				if (this.method_2(string_0, i))
				{
					StringBuilder stringBuilder = new StringBuilder();
					if (i > 0)
					{
						stringBuilder.Append(string_0, 0, i);
					}
					return this.method_4(stringBuilder, string_0, i);
				}
			}
			return string_0;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000076D8 File Offset: 0x000058D8
		private string method_4(StringBuilder stringBuilder_0, string string_0, int int_0)
		{
			int num = int_0;
			for (int i = int_0; i < string_0.Length; i++)
			{
				if (this.method_2(string_0, i))
				{
					stringBuilder_0.Append(string_0, num, i - num);
					char c = string_0[i];
					if (c <= '"')
					{
						switch (c)
						{
						case '\b':
							stringBuilder_0.Append("\\b");
							break;
						case '\t':
							stringBuilder_0.Append("\\t");
							break;
						case '\n':
							stringBuilder_0.Append("\\n");
							break;
						case '\v':
							goto IL_CD;
						case '\f':
							stringBuilder_0.Append("\\f");
							break;
						case '\r':
							stringBuilder_0.Append("\\r");
							break;
						default:
							if (c != '"')
							{
								goto IL_CD;
							}
							stringBuilder_0.Append("\\\"");
							break;
						}
					}
					else if (c != '/')
					{
						if (c != '\\')
						{
							goto IL_CD;
						}
						stringBuilder_0.Append("\\\\");
					}
					else
					{
						stringBuilder_0.Append("\\/");
					}
					IL_110:
					num = i + 1;
					goto IL_118;
					IL_CD:
					stringBuilder_0.Append("\\u");
					stringBuilder_0.Append(((int)string_0[i]).ToString("x04"));
					goto IL_110;
				}
				IL_118:;
			}
			stringBuilder_0.Append(string_0, num, string_0.Length - num);
			return stringBuilder_0.ToString();
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000035F7 File Offset: 0x000017F7
		public static GClass2 smethod_6(bool bool_0)
		{
			return new GClass5(bool_0);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000035FF File Offset: 0x000017FF
		public static GClass2 smethod_7(byte byte_0)
		{
			return new GClass5(byte_0);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00003607 File Offset: 0x00001807
		public static GClass2 smethod_8(char char_0)
		{
			return new GClass5(char_0);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000360F File Offset: 0x0000180F
		public static GClass2 smethod_9(decimal decimal_0)
		{
			return new GClass5(decimal_0);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00003617 File Offset: 0x00001817
		public static GClass2 smethod_10(double double_0)
		{
			return new GClass5(double_0);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000361F File Offset: 0x0000181F
		public static GClass2 smethod_11(float float_0)
		{
			return new GClass5(float_0);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00003627 File Offset: 0x00001827
		public static GClass2 smethod_12(int int_0)
		{
			return new GClass5(int_0);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000362F File Offset: 0x0000182F
		public static GClass2 smethod_13(long long_0)
		{
			return new GClass5(long_0);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00003637 File Offset: 0x00001837
		public static GClass2 smethod_14(sbyte sbyte_0)
		{
			return new GClass5(sbyte_0);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000363F File Offset: 0x0000183F
		public static GClass2 smethod_15(short short_0)
		{
			return new GClass5(short_0);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00003647 File Offset: 0x00001847
		public static GClass2 smethod_16(string string_0)
		{
			return new GClass5(string_0);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000364F File Offset: 0x0000184F
		public static GClass2 smethod_17(uint uint_0)
		{
			return new GClass5(uint_0);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00003657 File Offset: 0x00001857
		public static GClass2 smethod_18(ulong ulong_0)
		{
			return new GClass5(ulong_0);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000365F File Offset: 0x0000185F
		public static GClass2 smethod_19(ushort ushort_0)
		{
			return new GClass5(ushort_0);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00003667 File Offset: 0x00001867
		public static GClass2 smethod_20(DateTime dateTime_0)
		{
			return new GClass5(dateTime_0);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000366F File Offset: 0x0000186F
		public static GClass2 smethod_21(DateTimeOffset dateTimeOffset_0)
		{
			return new GClass5(dateTimeOffset_0);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00003677 File Offset: 0x00001877
		public static GClass2 smethod_22(Guid guid_0)
		{
			return new GClass5(guid_0);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000367F File Offset: 0x0000187F
		public static GClass2 smethod_23(TimeSpan timeSpan_0)
		{
			return new GClass5(timeSpan_0);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00003687 File Offset: 0x00001887
		public static GClass2 smethod_24(Uri uri_0)
		{
			return new GClass5(uri_0);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000368F File Offset: 0x0000188F
		public static bool smethod_25(GClass2 gclass2_0)
		{
			if (gclass2_0 == null)
			{
				throw new ArgumentNullException("value");
			}
			return Convert.ToBoolean(((GClass5)gclass2_0).Object_0, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000036B4 File Offset: 0x000018B4
		public static byte smethod_26(GClass2 gclass2_0)
		{
			if (gclass2_0 == null)
			{
				throw new ArgumentNullException("value");
			}
			return Convert.ToByte(((GClass5)gclass2_0).Object_0, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000036D9 File Offset: 0x000018D9
		public static char smethod_27(GClass2 gclass2_0)
		{
			if (gclass2_0 == null)
			{
				throw new ArgumentNullException("value");
			}
			return Convert.ToChar(((GClass5)gclass2_0).Object_0, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000036FE File Offset: 0x000018FE
		public static decimal smethod_28(GClass2 gclass2_0)
		{
			if (gclass2_0 == null)
			{
				throw new ArgumentNullException("value");
			}
			return Convert.ToDecimal(((GClass5)gclass2_0).Object_0, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00003723 File Offset: 0x00001923
		public static double smethod_29(GClass2 gclass2_0)
		{
			if (gclass2_0 == null)
			{
				throw new ArgumentNullException("value");
			}
			return Convert.ToDouble(((GClass5)gclass2_0).Object_0, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00003748 File Offset: 0x00001948
		public static float smethod_30(GClass2 gclass2_0)
		{
			if (gclass2_0 == null)
			{
				throw new ArgumentNullException("value");
			}
			return Convert.ToSingle(((GClass5)gclass2_0).Object_0, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000376D File Offset: 0x0000196D
		public static int smethod_31(GClass2 gclass2_0)
		{
			if (gclass2_0 == null)
			{
				throw new ArgumentNullException("value");
			}
			return Convert.ToInt32(((GClass5)gclass2_0).Object_0, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00003792 File Offset: 0x00001992
		public static long smethod_32(GClass2 gclass2_0)
		{
			if (gclass2_0 == null)
			{
				throw new ArgumentNullException("value");
			}
			return Convert.ToInt64(((GClass5)gclass2_0).Object_0, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000037B7 File Offset: 0x000019B7
		public static sbyte smethod_33(GClass2 gclass2_0)
		{
			if (gclass2_0 == null)
			{
				throw new ArgumentNullException("value");
			}
			return Convert.ToSByte(((GClass5)gclass2_0).Object_0, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000037DC File Offset: 0x000019DC
		public static short smethod_34(GClass2 gclass2_0)
		{
			if (gclass2_0 == null)
			{
				throw new ArgumentNullException("value");
			}
			return Convert.ToInt16(((GClass5)gclass2_0).Object_0, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00003801 File Offset: 0x00001A01
		public static string smethod_35(GClass2 gclass2_0)
		{
			if (gclass2_0 == null)
			{
				return null;
			}
			return gclass2_0.method_1(true);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000380F File Offset: 0x00001A0F
		public static uint smethod_36(GClass2 gclass2_0)
		{
			if (gclass2_0 == null)
			{
				throw new ArgumentNullException("value");
			}
			return Convert.ToUInt32(((GClass5)gclass2_0).Object_0, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00003834 File Offset: 0x00001A34
		public static ulong smethod_37(GClass2 gclass2_0)
		{
			if (gclass2_0 == null)
			{
				throw new ArgumentNullException("value");
			}
			return Convert.ToUInt64(((GClass5)gclass2_0).Object_0, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00003859 File Offset: 0x00001A59
		public static ushort smethod_38(GClass2 gclass2_0)
		{
			if (gclass2_0 == null)
			{
				throw new ArgumentNullException("value");
			}
			return Convert.ToUInt16(((GClass5)gclass2_0).Object_0, NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000387E File Offset: 0x00001A7E
		public static DateTime smethod_39(GClass2 gclass2_0)
		{
			if (gclass2_0 == null)
			{
				throw new ArgumentNullException("value");
			}
			return (DateTime)((GClass5)gclass2_0).Object_0;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000389E File Offset: 0x00001A9E
		public static DateTimeOffset smethod_40(GClass2 gclass2_0)
		{
			if (gclass2_0 == null)
			{
				throw new ArgumentNullException("value");
			}
			return (DateTimeOffset)((GClass5)gclass2_0).Object_0;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000038BE File Offset: 0x00001ABE
		public static TimeSpan smethod_41(GClass2 gclass2_0)
		{
			if (gclass2_0 == null)
			{
				throw new ArgumentNullException("value");
			}
			return (TimeSpan)((GClass5)gclass2_0).Object_0;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000038DE File Offset: 0x00001ADE
		public static Guid smethod_42(GClass2 gclass2_0)
		{
			if (gclass2_0 == null)
			{
				throw new ArgumentNullException("value");
			}
			return (Guid)((GClass5)gclass2_0).Object_0;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000038FE File Offset: 0x00001AFE
		public static Uri smethod_43(GClass2 gclass2_0)
		{
			if (gclass2_0 == null)
			{
				throw new ArgumentNullException("value");
			}
			return (Uri)((GClass5)gclass2_0).Object_0;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000391E File Offset: 0x00001B1E
		IEnumerator<KeyValuePair<string, GClass2>> method_5()
		{
			return base.GetEnumerator();
		}
	}
}
