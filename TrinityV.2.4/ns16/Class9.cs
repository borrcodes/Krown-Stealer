using System;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns16
{
	// Token: 0x02000021 RID: 33
	internal class Class9
	{
		// Token: 0x06000133 RID: 307 RVA: 0x0000ACB0 File Offset: 0x00008EB0
		public static void smethod_0()
		{
			string[] array = Class9.string_0;
			for (int i = 0; i < array.Length; i++)
			{
				Class9.Class10 @class = new Class9.Class10();
				@class.string_0 = array[i];
				if (Process.GetProcesses().Any(new Func<Process, bool>(@class.method_0)))
				{
					Environment.Exit(0);
				}
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0000AD00 File Offset: 0x00008F00
		public static void smethod_1()
		{
			using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("Select * from Win32_ComputerSystem"))
			{
				using (ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get())
				{
					foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
					{
						string text = managementBaseObject["Manufacturer"].ToString().ToLower();
						if ((text == "microsoft corporation" && managementBaseObject["Model"].ToString().ToUpperInvariant().Contains("VIRTUAL")) || text.Contains("vmware") || managementBaseObject["Model"].ToString() == "VirtualBox")
						{
							Environment.Exit(0);
						}
					}
				}
			}
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0000AE00 File Offset: 0x00009000
		public static void smethod_2()
		{
			if (Class9.GetModuleHandle("SbieDll.dll").ToInt32() != 0)
			{
				Environment.Exit(0);
			}
		}

		// Token: 0x06000136 RID: 310
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetModuleHandle(string string_1);

		// Token: 0x06000137 RID: 311
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		private static extern bool CheckRemoteDebuggerPresent(IntPtr intptr_0, ref bool bool_0);

		// Token: 0x0400007E RID: 126
		public static string[] string_0 = new string[]
		{
			"HttpAnalyzer",
			"Dumper",
			"Reflector",
			"Wireshark",
			"WPE",
			"ProcessExplorer",
			"IDA",
			"HTTP Debugger Pro",
			"The Wireshark Network Analyzer",
			"WinDbg",
			"Colasoft Capsa",
			"smsniff",
			"Olly",
			"OllyDbg",
			"WPE PRO",
			"Microsoft Network Monitor",
			"Fiddler",
			"SmartSniff",
			"Immunity Debugger",
			"Process Explorer",
			"PE Tools",
			"AQtime",
			"DS-5 Debug",
			"Dbxtool",
			"Topaz",
			"FusionDebug",
			"NetBeans",
			"Rational Purify",
			".NET Reflector",
			"Cheat Engine",
			"Sigma Engine"
		};

		// Token: 0x02000022 RID: 34
		[CompilerGenerated]
		private sealed class Class10
		{
			// Token: 0x0600013B RID: 315 RVA: 0x00003C85 File Offset: 0x00001E85
			internal bool method_0(Process process_0)
			{
				return process_0.ProcessName.ToLower().Contains(this.string_0);
			}

			// Token: 0x0400007F RID: 127
			public string string_0;
		}
	}
}
