using System;
using System.Security.Cryptography;
using System.Text;

namespace ns25
{
	// Token: 0x0200002C RID: 44
	public static class GClass14
	{
		// Token: 0x06000196 RID: 406 RVA: 0x0000CDF8 File Offset: 0x0000AFF8
		public static string smethod_0(byte[] byte_0, byte[] byte_1, byte[] byte_2, PaddingMode paddingMode_0 = PaddingMode.None)
		{
			string @string;
			using (TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider())
			{
				tripleDESCryptoServiceProvider.Key = byte_0;
				tripleDESCryptoServiceProvider.IV = byte_1;
				tripleDESCryptoServiceProvider.Mode = CipherMode.CBC;
				tripleDESCryptoServiceProvider.Padding = paddingMode_0;
				using (ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor(byte_0, byte_1))
				{
					@string = Encoding.Default.GetString(cryptoTransform.TransformFinalBlock(byte_2, 0, byte_2.Length));
				}
			}
			return @string;
		}
	}
}
