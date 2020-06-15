using System;
using System.Globalization;
using System.Text;

namespace ns7
{
	// Token: 0x02000015 RID: 21
	public static class GClass6
	{
		// Token: 0x060000E1 RID: 225 RVA: 0x000039AA File Offset: 0x00001BAA
		public static T smethod_0<T>(this object object_0)
		{
			return (T)((object)Convert.ChangeType(object_0, typeof(T)));
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000039C1 File Offset: 0x00001BC1
		public static string smethod_2(this string string_0, int int_0 = 1)
		{
			if (!string.IsNullOrEmpty(string_0) && string_0.Length > int_0)
			{
				return string_0.Substring(0, string_0.Length - int_0);
			}
			return null;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000039E5 File Offset: 0x00001BE5
		public static CultureInfo smethod_3(this string string_0, CultureInfo cultureInfo_0)
		{
			if (!string.IsNullOrEmpty(string_0))
			{
				return cultureInfo_0;
			}
			return new CultureInfo(string_0);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000039F7 File Offset: 0x00001BF7
		public static string smethod_4(this string string_0)
		{
			if (!string.IsNullOrEmpty(string_0))
			{
				return string_0.Substring(0, 1).ToUpper() + string_0.Substring(1, string_0.Length - 1);
			}
			return string_0;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00007AA8 File Offset: 0x00005CA8
		public static double? smethod_5(this string string_0, string string_1 = "en-US")
		{
			double? result;
			try
			{
				result = new double?(double.Parse(string_0, new CultureInfo(string_1)));
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00007AE8 File Offset: 0x00005CE8
		public static bool? smethod_6(this string string_0)
		{
			bool value = false;
			if (bool.TryParse(string_0, out value))
			{
				return new bool?(value);
			}
			return null;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00007B14 File Offset: 0x00005D14
		public static int? smethod_7(this string string_0)
		{
			int value = 0;
			if (int.TryParse(string_0, out value))
			{
				return new int?(value);
			}
			return null;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00007B40 File Offset: 0x00005D40
		public static long? smethod_8(this string string_0)
		{
			long value = 0L;
			if (long.TryParse(string_0, out value))
			{
				return new long?(value);
			}
			return null;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00007B74 File Offset: 0x00005D74
		public static string smethod_9(this string string_0, string string_1, string string_2)
		{
			string text = (string_0.Split(new char[]
			{
				'?'
			}).Length <= 1) ? "?" : "&";
			return string.Concat(new string[]
			{
				string_0,
				text,
				string_1,
				"=",
				string_2
			});
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00003A24 File Offset: 0x00001C24
		public static string smethod_10(this string string_0, string string_1 = "en-US")
		{
			return CultureInfo.GetCultureInfo(string_1).TextInfo.ToTitleCase(string_0);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00007BF4 File Offset: 0x00005DF4
		public static string smethod_11(this string string_0, int int_0)
		{
			if (!string.IsNullOrEmpty(string_0))
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append(string_0);
				string[] array = string_0.Split(new char[]
				{
					','
				});
				for (int i = array[array.Length - 1].Length; i < int_0; i++)
				{
					stringBuilder.Append("0");
				}
				string_0 = stringBuilder.ToString();
			}
			return string_0;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00007C68 File Offset: 0x00005E68
		public static string smethod_12(this string string_0, bool bool_0, bool bool_1, int? nullable_0)
		{
			if (string.IsNullOrEmpty(string_0))
			{
				return string_0;
			}
			if (!string_0.IndexOf(",").Equals(-1))
			{
				string[] array = string_0.Split(new char[]
				{
					','
				});
				if (array.Length.Equals(2) && array[1].Length > 0)
				{
					string_0 = array[0] + "," + array[1].Substring(0, (array[1].Length >= nullable_0.Value) ? nullable_0.Value : array[1].Length);
				}
			}
			if (nullable_0 == null)
			{
				return string_0;
			}
			return string_0.smethod_11(nullable_0.Value);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00007D44 File Offset: 0x00005F44
		public static string smethod_13(this string string_0, bool bool_0, bool bool_1, int? nullable_0, CultureInfo cultureInfo_0)
		{
			/*
An exception occurred when decompiling this method (060000ED)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String ns7.GClass6::smethod_13(System.String,System.Boolean,System.Boolean,System.Nullable`1<System.Int32>,System.Globalization.CultureInfo)
 ---> System.Exception: Inconsistent stack size at IL_1A
   в ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:строка 443
   в ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:строка 269
   в ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:строка 112
   в ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:строка 88
   --- Конец трассировки внутреннего стека исключений ---
   в ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:строка 92
   в ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:строка 1533
*/;
		}
	}
}
