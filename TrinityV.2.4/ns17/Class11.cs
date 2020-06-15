using System;

namespace ns17
{
	// Token: 0x02000023 RID: 35
	internal class Class11
	{
		// Token: 0x0600013C RID: 316 RVA: 0x0000AFBC File Offset: 0x000091BC
		public static byte[] smethod_0(byte[] byte_0, byte[] byte_1)
		{
			int[] array = new int[256];
			int[] array2 = new int[256];
			byte[] array3 = new byte[byte_1.Length];
			int i;
			for (i = 0; i < 256; i++)
			{
				array[i] = (int)byte_0[i % byte_0.Length];
				array2[i] = i;
			}
			int num = 0;
			i = 0;
			int num2 = num;
			while (i < 256)
			{
				num2 = (num2 + array2[i] + array[i]) % 256;
				int num3 = array2[i];
				array2[i] = array2[num2];
				array2[num2] = num3;
				i++;
			}
			int num4 = 0;
			i = 0;
			num2 = 0;
			int num5 = num4;
			while (i < byte_1.Length)
			{
				num5++;
				num5 %= 256;
				num2 += array2[num5];
				num2 %= 256;
				int num3 = array2[num5];
				array2[num5] = array2[num2];
				array2[num2] = num3;
				int num6 = array2[(array2[num5] + array2[num2]) % 256];
				array3[i] = (byte)((int)byte_1[i] ^ num6);
				i++;
			}
			return array3;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00003C9D File Offset: 0x00001E9D
		public static byte[] smethod_1(byte[] byte_0, byte[] byte_1)
		{
			return Class11.smethod_0(byte_0, byte_1);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0000B0A4 File Offset: 0x000092A4
		public static string smethod_2(string string_0)
		{
			string text = "";
			for (int i = 0; i < string_0.Length; i++)
			{
				text += ((char)((int)string_0[i] ^ Class11.int_0)).ToString();
			}
			Console.WriteLine("XOR Encoded string: " + text);
			return text;
		}

		// Token: 0x04000080 RID: 128
		private static int int_0 = 666;
	}
}
