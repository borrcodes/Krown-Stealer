using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns11;
using ns12;
using ns7;

namespace ns9
{
	// Token: 0x02000017 RID: 23
	public class GClass8
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00003AF3 File Offset: 0x00001CF3
		private byte[] Byte_0 { get; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00003AFB File Offset: 0x00001CFB
		private ulong UInt64_0 { get; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000FA RID: 250 RVA: 0x00003B03 File Offset: 0x00001D03
		// (set) Token: 0x060000FB RID: 251 RVA: 0x00003B0B File Offset: 0x00001D0B
		public string[] String_0 { get; set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00003B14 File Offset: 0x00001D14
		public int Int32_0
		{
			get
			{
				return this.GStruct1_0.Length;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00003B1E File Offset: 0x00001D1E
		private ushort UInt16_0 { get; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000FE RID: 254 RVA: 0x00003B26 File Offset: 0x00001D26
		// (set) Token: 0x060000FF RID: 255 RVA: 0x00003B2E File Offset: 0x00001D2E
		private GStruct0[] GStruct0_0 { get; set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00003B37 File Offset: 0x00001D37
		// (set) Token: 0x06000101 RID: 257 RVA: 0x00003B3F File Offset: 0x00001D3F
		private GStruct1[] GStruct1_0 { get; set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00003B48 File Offset: 0x00001D48
		private byte[] Byte_1 { get; }

		// Token: 0x06000103 RID: 259 RVA: 0x00007D70 File Offset: 0x00005F70
		public GClass8(string string_1)
		{
			this.Byte_1 = new byte[]
			{
				0,
				1,
				2,
				3,
				4,
				6,
				8,
				8,
				0,
				0
			};
			if (File.Exists(string_1))
			{
				FileSystem.FileOpen(1, string_1, OpenMode.Binary, OpenAccess.Read, OpenShare.Shared, -1);
				string s = Strings.Space((int)FileSystem.LOF(1));
				FileSystem.FileGet(1, ref s, -1L, false);
				FileSystem.FileClose(new int[]
				{
					1
				});
				this.Byte_0 = Encoding.Default.GetBytes(s);
				this.UInt16_0 = (ushort)this.method_4(16, 2);
				this.UInt64_0 = this.method_4(56, 4);
				if (decimal.Compare(new decimal(this.UInt64_0), 0m) == 0)
				{
					this.UInt64_0 = 1L;
				}
				this.method_7(100UL);
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00007E48 File Offset: 0x00006048
		public string[] method_0()
		{
			string[] array = null;
			int num = 0;
			int num2 = this.GStruct0_0.Length - 1;
			for (int i = 0; i <= num2; i++)
			{
				if (this.GStruct0_0[i].String_0 == "table")
				{
					array = (string[])Utils.CopyArray(array, new string[num + 1]);
					array[num] = this.GStruct0_0[i].String_1;
					num++;
				}
			}
			return array;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00003B50 File Offset: 0x00001D50
		public string method_1(int int_0, int int_1)
		{
			if (int_0 >= this.GStruct1_0.Length)
			{
				return null;
			}
			if (int_1 >= this.GStruct1_0[int_0].String_0.Length)
			{
				return null;
			}
			return this.GStruct1_0[int_0].String_0[int_1];
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00007ED4 File Offset: 0x000060D4
		public string method_2(int int_0, string string_1)
		{
			int num = -1;
			int num2 = this.String_0.Length - 1;
			int i = 0;
			while (i <= num2)
			{
				if (this.String_0[i].ToLower().Trim().CompareTo(string_1.ToLower().Trim()) != 0)
				{
					i++;
				}
				else
				{
					num = i;
					IL_41:
					if (num == -1)
					{
						return null;
					}
					return this.method_1(int_0, num);
				}
			}
			goto IL_41;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00007F30 File Offset: 0x00006130
		public bool method_3(string string_1)
		{
			int num = -1;
			int num2 = this.GStruct0_0.Length - 1;
			int i = 0;
			while (i <= num2)
			{
				if (this.GStruct0_0[i].String_1.ToLower().CompareTo(string_1.ToLower()) != 0)
				{
					i++;
				}
				else
				{
					num = i;
					IL_56:
					if (num == -1)
					{
						return false;
					}
					string[] array = this.GStruct0_0[num].String_3.Substring(this.GStruct0_0[num].String_3.IndexOf("(") + 1).Split(new char[]
					{
						','
					});
					int num3 = array.Length - 1;
					for (int j = 0; j <= num3; j++)
					{
						array[j] = array[j].TrimStart(new char[0]);
						int num4 = array[j].IndexOf(" ");
						if (num4 > 0)
						{
							array[j] = array[j].Substring(0, num4);
						}
						if (array[j].IndexOf("UNIQUE") == 0)
						{
							break;
						}
						this.String_0 = (string[])Utils.CopyArray(this.String_0, new string[j + 1]);
						this.String_0[j] = array[j];
					}
					return this.method_8((ulong)((this.GStruct0_0[num].Int64_1 - 1L) * (long)((ulong)this.UInt16_0)));
				}
			}
			goto IL_56;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000080CC File Offset: 0x000062CC
		private ulong method_4(int int_0, int int_1)
		{
			if (int_1 <= 8 && int_1 != 0)
			{
				ulong num = 0UL;
				for (int i = 0; i <= int_1 - 1; i++)
				{
					num = (num << 8 | (ulong)this.Byte_0[int_0 + i]);
				}
				return num;
			}
			return 0UL;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00008114 File Offset: 0x00006314
		private long method_5(int int_0, int int_1)
		{
			int_1++;
			byte[] array = new byte[8];
			int num = int_1 - int_0;
			bool flag = false;
			if (num == 0 | num > 9)
			{
				return 0L;
			}
			if (num != 1)
			{
				if (num == 9)
				{
					flag = true;
				}
				int num2 = 1;
				int num3 = 7;
				int num4 = 0;
				if (flag)
				{
					array[0] = this.Byte_0[int_1 - 1];
					int_1--;
					num4 = 1;
				}
				for (int i = int_1 - 1; i >= int_0; i += -1)
				{
					if (i - 1 >= int_0)
					{
						array[num4] = (byte)(((int)((byte)(this.Byte_0[i] >> (num2 - 1 & 7))) & 255 >> num2) | (int)((byte)(this.Byte_0[i - 1] << (num3 & 7))));
						num2++;
						num4++;
						num3--;
					}
					else if (!flag)
					{
						array[num4] = (byte)((int)((byte)(this.Byte_0[i] >> (num2 - 1 & 7))) & 255 >> num2);
					}
				}
				return BitConverter.ToInt64(array, 0);
			}
			array[0] = (this.Byte_0[int_0] & 127);
			return BitConverter.ToInt64(array, 0);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00008224 File Offset: 0x00006424
		private int method_6(int int_0)
		{
			if (int_0 > this.Byte_0.Length)
			{
				return 0;
			}
			int num = int_0 + 8;
			for (int i = int_0; i <= num; i++)
			{
				if (i > this.Byte_0.Length - 1)
				{
					return 0;
				}
				if ((this.Byte_0[i] & 128) != 128)
				{
					return i;
				}
			}
			return int_0 + 8;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00003B8A File Offset: 0x00001D8A
		public static bool smethod_0(long long_0)
		{
			return (long_0 & 1L) == 1L;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000827C File Offset: 0x0000647C
		private void method_7(ulong ulong_1)
		{
			if (this.Byte_0[(int)((uint)ulong_1)] == 13)
			{
				ushort num = (this.method_4((ulong_1.smethod_0<decimal>() + 3m).smethod_0<int>(), 2).smethod_0<decimal>() - 1m).smethod_0<ushort>();
				int num2 = 0;
				if (this.GStruct0_0 != null)
				{
					num2 = this.GStruct0_0.Length;
					this.GStruct0_0 = (GStruct0[])Utils.CopyArray(this.GStruct0_0, new GStruct0[this.GStruct0_0.Length + (int)num + 1]);
				}
				else
				{
					this.GStruct0_0 = new GStruct0[(int)(num + 1)];
				}
				int num3 = (int)num;
				for (int i = 0; i <= num3; i++)
				{
					ulong num4 = this.method_4((ulong_1.smethod_0<decimal>() + 8m + (i * 2).smethod_0<decimal>()).smethod_0<int>(), 2);
					if (decimal.Compare(ulong_1.smethod_0<decimal>(), 100m) != 0)
					{
						num4 += ulong_1;
					}
					int num5 = this.method_6(num4.smethod_0<int>());
					this.method_5(num4.smethod_0<int>(), num5);
					int num6 = this.method_6((num4.smethod_0<decimal>() + num5.smethod_0<decimal>() - num4.smethod_0<decimal>() + 1m).smethod_0<int>());
					this.GStruct0_0[num2 + i].Int64_0 = this.method_5((num4.smethod_0<decimal>() + num5.smethod_0<decimal>() - num4.smethod_0<decimal>() + 1m).smethod_0<int>(), num6);
					num4 = (num4.smethod_0<decimal>() + num6.smethod_0<decimal>() - num4.smethod_0<decimal>() + 1m).smethod_0<ulong>();
					num5 = this.method_6(num4.smethod_0<int>());
					num6 = num5;
					long value = this.method_5(num4.smethod_0<int>(), num5);
					long[] array = new long[5];
					int num7 = 0;
					do
					{
						num5 = num6 + 1;
						num6 = this.method_6(num5);
						array[num7] = this.method_5(num5, num6);
						if (array[num7] > 9L)
						{
							if (GClass8.smethod_0(array[num7]))
							{
								array[num7] = (long)Math.Round((double)(array[num7] - 13L) / 2.0);
							}
							else
							{
								array[num7] = (long)Math.Round((double)(array[num7] - 12L) / 2.0);
							}
						}
						else
						{
							array[num7] = (long)((ulong)this.Byte_1[(int)array[num7]]);
						}
						num7++;
					}
					while (num7 <= 4);
					Encoding encoding = Encoding.Default;
					decimal value2 = this.UInt64_0.smethod_0<decimal>();
					if (!1m.Equals(value2))
					{
						if (!2m.Equals(value2))
						{
							if (3m.Equals(value2))
							{
								encoding = Encoding.BigEndianUnicode;
							}
						}
						else
						{
							encoding = Encoding.Unicode;
						}
					}
					else
					{
						encoding = Encoding.Default;
					}
					this.GStruct0_0[num2 + i].String_0 = encoding.GetString(this.Byte_0, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)array[0]);
					this.GStruct0_0[num2 + i].String_1 = encoding.GetString(this.Byte_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0]))), (int)array[1]);
					this.GStruct0_0[num2 + i].Int64_1 = (long)this.method_4(Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2]))), (int)array[3]);
					this.GStruct0_0[num2 + i].String_3 = encoding.GetString(this.Byte_0, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
				}
				return;
			}
			if (this.Byte_0[(int)((uint)ulong_1)] != 5)
			{
				return;
			}
			int num8 = (int)Convert.ToUInt16(decimal.Subtract(new decimal(this.method_4(Convert.ToInt32(decimal.Add(new decimal(ulong_1), 3m)), 2)), 1m));
			for (int j = 0; j <= num8; j++)
			{
				ushort num9 = (ushort)this.method_4(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(ulong_1), 12m), new decimal(j * 2))), 2);
				if (decimal.Compare(new decimal(ulong_1), 100m) == 0)
				{
					this.method_7(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(this.method_4((int)num9, 4)), 1m), new decimal((int)this.UInt16_0))));
				}
				else
				{
					this.method_7(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(this.method_4((int)(ulong_1 + (ulong)num9), 4)), 1m), new decimal((int)this.UInt16_0))));
				}
			}
			this.method_7(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(this.method_4(Convert.ToInt32(decimal.Add(new decimal(ulong_1), 8m)), 4)), 1m), new decimal((int)this.UInt16_0))));
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000088B0 File Offset: 0x00006AB0
		private bool method_8(ulong ulong_1)
		{
			if (this.Byte_0[(int)((uint)ulong_1)] == 13)
			{
				int num = Convert.ToInt32(decimal.Subtract(new decimal(this.method_4(Convert.ToInt32(decimal.Add(new decimal(ulong_1), 3m)), 2)), 1m));
				int num2 = 0;
				if (this.GStruct1_0 != null)
				{
					num2 = this.GStruct1_0.Length;
					this.GStruct1_0 = (GStruct1[])Utils.CopyArray(this.GStruct1_0, new GStruct1[this.GStruct1_0.Length + num + 1]);
				}
				else
				{
					this.GStruct1_0 = new GStruct1[num + 1];
				}
				int num3 = num;
				for (int i = 0; i <= num3; i++)
				{
					GStruct2[] array = null;
					ulong num4 = this.method_4(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(ulong_1), 8m), new decimal(i * 2))), 2);
					if (decimal.Compare(new decimal(ulong_1), 100m) != 0)
					{
						num4 += ulong_1;
					}
					int num5 = this.method_6((int)num4);
					this.method_5((int)num4, num5);
					int num6 = this.method_6(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)));
					this.GStruct1_0[num2 + i].Int64_0 = this.method_5(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)), num6);
					num4 = Convert.ToUInt64(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num6), new decimal(num4))), 1m));
					num5 = this.method_6((int)num4);
					num6 = num5;
					long num7 = this.method_5((int)num4, num5);
					long num8 = Convert.ToInt64(decimal.Add(decimal.Subtract(new decimal(num4), new decimal(num5)), 1m));
					int num9 = 0;
					while (num8 < num7)
					{
						array = (GStruct2[])Utils.CopyArray(array, new GStruct2[num9 + 1]);
						num5 = num6 + 1;
						num6 = this.method_6(num5);
						array[num9].Int64_1 = this.method_5(num5, num6);
						if (array[num9].Int64_1 > 9L)
						{
							if (GClass8.smethod_0(array[num9].Int64_1))
							{
								array[num9].Int64_0 = (long)Math.Round((double)(array[num9].Int64_1 - 13L) / 2.0);
							}
							else
							{
								array[num9].Int64_0 = (long)Math.Round((double)(array[num9].Int64_1 - 12L) / 2.0);
							}
						}
						else
						{
							array[num9].Int64_0 = (long)((ulong)this.Byte_1[(int)array[num9].Int64_1]);
						}
						num8 = num8 + (long)(num6 - num5) + 1L;
						num9++;
					}
					this.GStruct1_0[num2 + i].String_0 = new string[array.Length - 1 + 1];
					int num10 = 0;
					int num11 = array.Length - 1;
					for (int j = 0; j <= num11; j++)
					{
						if (array[j].Int64_1 > 9L)
						{
							if (!GClass8.smethod_0(array[j].Int64_1))
							{
								if (decimal.Compare(new decimal(this.UInt64_0), 1m) == 0)
								{
									this.GStruct1_0[num2 + i].String_0[j] = Encoding.Default.GetString(this.Byte_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].Int64_0);
								}
								else if (decimal.Compare(new decimal(this.UInt64_0), 2m) == 0)
								{
									this.GStruct1_0[num2 + i].String_0[j] = Encoding.Unicode.GetString(this.Byte_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].Int64_0);
								}
								else if (decimal.Compare(new decimal(this.UInt64_0), 3m) == 0)
								{
									this.GStruct1_0[num2 + i].String_0[j] = Encoding.BigEndianUnicode.GetString(this.Byte_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].Int64_0);
								}
							}
							else
							{
								this.GStruct1_0[num2 + i].String_0[j] = Encoding.Default.GetString(this.Byte_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].Int64_0);
							}
						}
						else
						{
							this.GStruct1_0[num2 + i].String_0[j] = Convert.ToString(this.method_4(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].Int64_0));
						}
						num10 += (int)array[j].Int64_0;
					}
				}
			}
			else if (this.Byte_0[(int)((uint)ulong_1)] == 5)
			{
				int num12 = (int)Convert.ToUInt16(decimal.Subtract(new decimal(this.method_4(Convert.ToInt32(decimal.Add(new decimal(ulong_1), 3m)), 2)), 1m));
				for (int k = 0; k <= num12; k++)
				{
					ushort num13 = (ushort)this.method_4(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(ulong_1), 12m), new decimal(k * 2))), 2);
					this.method_8(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(this.method_4((int)(ulong_1 + (ulong)num13), 4)), 1m), new decimal((int)this.UInt16_0))));
				}
				this.method_8(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(this.method_4(Convert.ToInt32(decimal.Add(new decimal(ulong_1), 8m)), 4)), 1m), new decimal((int)this.UInt16_0))));
			}
			return true;
		}

		// Token: 0x0400004A RID: 74
		[CompilerGenerated]
		private readonly byte[] byte_0;

		// Token: 0x0400004B RID: 75
		[CompilerGenerated]
		private readonly ulong ulong_0;

		// Token: 0x0400004C RID: 76
		[CompilerGenerated]
		private string[] string_0;

		// Token: 0x0400004D RID: 77
		[CompilerGenerated]
		private readonly ushort ushort_0;

		// Token: 0x0400004E RID: 78
		[CompilerGenerated]
		private GStruct0[] gstruct0_0;

		// Token: 0x0400004F RID: 79
		[CompilerGenerated]
		private GStruct1[] gstruct1_0;

		// Token: 0x04000050 RID: 80
		[CompilerGenerated]
		private readonly byte[] byte_1;
	}
}
