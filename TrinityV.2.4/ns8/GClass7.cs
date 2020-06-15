using System;

namespace ns8
{
	// Token: 0x02000016 RID: 22
	public static class GClass7
	{
		// Token: 0x060000EE RID: 238 RVA: 0x00003A37 File Offset: 0x00001C37
		public static bool smethod_0<T>(this T gparam_0)
		{
			return gparam_0 != null;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00003A42 File Offset: 0x00001C42
		public static string smethod_1(this string string_0, string string_1)
		{
			if (!string.IsNullOrEmpty(string_0))
			{
				return string_0;
			}
			return string_1;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00003A4F File Offset: 0x00001C4F
		public static bool smethod_2(this bool? nullable_0, bool bool_0)
		{
			if (nullable_0 != null)
			{
				return nullable_0.Value;
			}
			return bool_0;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00003A63 File Offset: 0x00001C63
		public static T smethod_3<T>(this T gparam_0) where T : class
		{
			if (gparam_0 == null)
			{
				return Activator.CreateInstance<T>();
			}
			return gparam_0;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00003A74 File Offset: 0x00001C74
		public static T smethod_4<T>(this T gparam_0, T gparam_1) where T : class
		{
			if (gparam_0 != null)
			{
				return gparam_0;
			}
			if (gparam_1 == null)
			{
				return Activator.CreateInstance<T>();
			}
			return gparam_1;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00003A8F File Offset: 0x00001C8F
		public static int smethod_5(this int? nullable_0, int int_0)
		{
			if (nullable_0 != null)
			{
				return nullable_0.Value;
			}
			return int_0;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00003AA3 File Offset: 0x00001CA3
		public static long smethod_6(this long? nullable_0, long long_0)
		{
			if (nullable_0 != null)
			{
				return nullable_0.Value;
			}
			return long_0;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00003AB7 File Offset: 0x00001CB7
		public static double smethod_7(this double? nullable_0, double double_0)
		{
			if (nullable_0 != null)
			{
				return nullable_0.Value;
			}
			return double_0;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00003ACB File Offset: 0x00001CCB
		public static DateTime smethod_8(this DateTime? nullable_0, DateTime dateTime_0)
		{
			if (nullable_0 != null)
			{
				return nullable_0.Value;
			}
			return dateTime_0;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00003ADF File Offset: 0x00001CDF
		public static Guid smethod_9(this Guid? nullable_0, Guid guid_0)
		{
			if (nullable_0 != null)
			{
				return nullable_0.Value;
			}
			return guid_0;
		}
	}
}
