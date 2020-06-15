using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace ns27
{
	// Token: 0x0200002E RID: 46
	public class GClass16
	{
		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00003E9A File Offset: 0x0000209A
		private byte[] Byte_0 { get; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600019C RID: 412 RVA: 0x00003EA2 File Offset: 0x000020A2
		private byte[] Byte_1 { get; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600019D RID: 413 RVA: 0x00003EAA File Offset: 0x000020AA
		private byte[] Byte_2 { get; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600019E RID: 414 RVA: 0x00003EB2 File Offset: 0x000020B2
		// (set) Token: 0x0600019F RID: 415 RVA: 0x00003EBA File Offset: 0x000020BA
		public byte[] Byte_3 { get; private set; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x00003EC3 File Offset: 0x000020C3
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x00003ECB File Offset: 0x000020CB
		public byte[] Byte_4 { get; private set; }

		// Token: 0x060001A2 RID: 418 RVA: 0x00003ED4 File Offset: 0x000020D4
		public GClass16(byte[] byte_5, byte[] byte_6, byte[] byte_7)
		{
			this.Byte_0 = byte_5;
			this.Byte_1 = byte_6;
			this.Byte_2 = byte_7;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000CEE8 File Offset: 0x0000B0E8
		public void method_0()
		{
			SHA1CryptoServiceProvider sha1CryptoServiceProvider = new SHA1CryptoServiceProvider();
			byte[] array = new byte[this.Byte_0.Length + this.Byte_1.Length];
			Array.Copy(this.Byte_0, 0, array, 0, this.Byte_0.Length);
			Array.Copy(this.Byte_1, 0, array, this.Byte_0.Length, this.Byte_1.Length);
			byte[] array2 = sha1CryptoServiceProvider.ComputeHash(array);
			byte[] array3 = new byte[array2.Length + this.Byte_2.Length];
			Array.Copy(array2, 0, array3, 0, array2.Length);
			Array.Copy(this.Byte_2, 0, array3, array2.Length, this.Byte_2.Length);
			byte[] key = sha1CryptoServiceProvider.ComputeHash(array3);
			byte[] array4 = new byte[20];
			Array.Copy(this.Byte_2, 0, array4, 0, this.Byte_2.Length);
			for (int i = this.Byte_2.Length; i < 20; i++)
			{
				array4[i] = 0;
			}
			byte[] array5 = new byte[array4.Length + this.Byte_2.Length];
			Array.Copy(array4, 0, array5, 0, array4.Length);
			Array.Copy(this.Byte_2, 0, array5, array4.Length, this.Byte_2.Length);
			byte[] array6;
			byte[] array9;
			using (HMACSHA1 hmacsha = new HMACSHA1(key))
			{
				array6 = hmacsha.ComputeHash(array5);
				byte[] array7 = hmacsha.ComputeHash(array4);
				byte[] array8 = new byte[array7.Length + this.Byte_2.Length];
				Array.Copy(array7, 0, array8, 0, array7.Length);
				Array.Copy(this.Byte_2, 0, array8, array7.Length, this.Byte_2.Length);
				array9 = hmacsha.ComputeHash(array8);
			}
			byte[] array10 = new byte[array6.Length + array9.Length];
			Array.Copy(array6, 0, array10, 0, array6.Length);
			Array.Copy(array9, 0, array10, array6.Length, array9.Length);
			this.Byte_3 = new byte[24];
			for (int j = 0; j < this.Byte_3.Length; j++)
			{
				this.Byte_3[j] = array10[j];
			}
			this.Byte_4 = new byte[8];
			int num = this.Byte_4.Length - 1;
			for (int k = array10.Length - 1; k >= array10.Length - this.Byte_4.Length; k--)
			{
				this.Byte_4[num] = array10[k];
				num--;
			}
		}

		// Token: 0x040000AE RID: 174
		[CompilerGenerated]
		private readonly byte[] byte_0;

		// Token: 0x040000AF RID: 175
		[CompilerGenerated]
		private readonly byte[] byte_1;

		// Token: 0x040000B0 RID: 176
		[CompilerGenerated]
		private readonly byte[] byte_2;

		// Token: 0x040000B1 RID: 177
		[CompilerGenerated]
		private byte[] byte_3;

		// Token: 0x040000B2 RID: 178
		[CompilerGenerated]
		private byte[] byte_4;
	}
}
