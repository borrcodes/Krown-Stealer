using System;
using System.IO;
using System.Text;

namespace ns13
{
	// Token: 0x0200001B RID: 27
	internal class Class7
	{
		// Token: 0x06000122 RID: 290 RVA: 0x00008F84 File Offset: 0x00007184
		public Class7(string string_1)
		{
			this.byte_1 = File.ReadAllBytes(string_1);
			this.ulong_1 = this.method_5(16, 2);
			this.ulong_0 = this.method_5(56, 4);
			this.method_3(100L);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00008FE8 File Offset: 0x000071E8
		public string method_0(int int_0, int int_1)
		{
			string result;
			try
			{
				if (int_0 >= this.struct6_0.Length)
				{
					result = null;
				}
				else
				{
					result = ((int_1 >= this.struct6_0[int_0].string_0.Length) ? null : this.struct6_0[int_0].string_0[int_1]);
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00003C4C File Offset: 0x00001E4C
		public int method_1()
		{
			return this.struct6_0.Length;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000904C File Offset: 0x0000724C
		private bool method_2(ulong ulong_2)
		{
			bool result;
			try
			{
				if (this.byte_1[(int)(checked((IntPtr)ulong_2))] == 13)
				{
					uint num = (uint)(this.method_5((int)ulong_2 + 3, 2) - 1UL);
					int num2 = 0;
					if (this.struct6_0 != null)
					{
						num2 = this.struct6_0.Length;
						Array.Resize<Class7.Struct6>(ref this.struct6_0, this.struct6_0.Length + (int)num + 1);
					}
					else
					{
						this.struct6_0 = new Class7.Struct6[num + 1U];
					}
					for (uint num3 = 0U; num3 <= num; num3 += 1U)
					{
						ulong num4 = this.method_5((int)ulong_2 + 8 + (int)(num3 * 2U), 2);
						if (ulong_2 != 100UL)
						{
							num4 += ulong_2;
						}
						int num5 = this.method_6((int)num4);
						this.method_7((int)num4, num5);
						int num6 = this.method_6((int)(num4 + (ulong)((long)num5 - (long)num4) + 1UL));
						this.method_7((int)(num4 + (ulong)((long)num5 - (long)num4) + 1UL), num6);
						ulong num7 = num4 + (ulong)((long)num6 - (long)num4 + 1L);
						int num8 = this.method_6((int)num7);
						int num9 = num8;
						long num10 = this.method_7((int)num7, num8);
						Class7.Struct5[] array = null;
						long num11 = (long)(num7 - (ulong)((long)num8) + 1UL);
						int num12 = 0;
						while (num11 < num10)
						{
							Array.Resize<Class7.Struct5>(ref array, num12 + 1);
							int num13 = num9 + 1;
							num9 = this.method_6(num13);
							array[num12].long_1 = this.method_7(num13, num9);
							array[num12].long_0 = (long)((array[num12].long_1 <= 9L) ? ((ulong)this.byte_0[(int)(checked((IntPtr)array[num12].long_1))]) : ((ulong)((!Class7.smethod_0(array[num12].long_1)) ? ((array[num12].long_1 - 12L) / 2L) : ((array[num12].long_1 - 13L) / 2L))));
							num11 = num11 + (long)(num9 - num13) + 1L;
							num12++;
						}
						if (array != null)
						{
							this.struct6_0[num2 + (int)num3].string_0 = new string[array.Length];
							int num14 = 0;
							for (int i = 0; i <= array.Length - 1; i++)
							{
								if (array[i].long_1 > 9L)
								{
									if (!Class7.smethod_0(array[i].long_1))
									{
										if (this.ulong_0 == 1UL)
										{
											this.struct6_0[num2 + (int)num3].string_0[i] = Encoding.Default.GetString(this.byte_1, (int)(num7 + (ulong)num10 + (ulong)((long)num14)), (int)array[i].long_0);
										}
										else if (this.ulong_0 == 2UL)
										{
											this.struct6_0[num2 + (int)num3].string_0[i] = Encoding.Unicode.GetString(this.byte_1, (int)(num7 + (ulong)num10 + (ulong)((long)num14)), (int)array[i].long_0);
										}
										else if (this.ulong_0 == 3UL)
										{
											this.struct6_0[num2 + (int)num3].string_0[i] = Encoding.BigEndianUnicode.GetString(this.byte_1, (int)(num7 + (ulong)num10 + (ulong)((long)num14)), (int)array[i].long_0);
										}
									}
									else
									{
										this.struct6_0[num2 + (int)num3].string_0[i] = Encoding.Default.GetString(this.byte_1, (int)(num7 + (ulong)num10 + (ulong)((long)num14)), (int)array[i].long_0);
									}
								}
								else
								{
									this.struct6_0[num2 + (int)num3].string_0[i] = Convert.ToString(this.method_5((int)(num7 + (ulong)num10 + (ulong)((long)num14)), (int)array[i].long_0));
								}
								num14 += (int)array[i].long_0;
							}
						}
					}
				}
				else if (this.byte_1[(int)(checked((IntPtr)ulong_2))] == 5)
				{
					uint num15 = (uint)(this.method_5((int)(ulong_2 + 3UL), 2) - 1UL);
					for (uint num16 = 0U; num16 <= num15; num16 += 1U)
					{
						uint num17 = (uint)this.method_5((int)ulong_2 + 12 + (int)(num16 * 2U), 2);
						this.method_2((this.method_5((int)(ulong_2 + (ulong)num17), 4) - 1UL) * this.ulong_1);
					}
					this.method_2((this.method_5((int)(ulong_2 + 8UL), 4) - 1UL) * this.ulong_1);
				}
				result = true;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000954C File Offset: 0x0000774C
		private void method_3(long long_0)
		{
			try
			{
				byte b = this.byte_1[(int)(checked((IntPtr)long_0))];
				if (b != 5)
				{
					if (b == 13)
					{
						ulong num = this.method_5((int)long_0 + 3, 2) - 1UL;
						int num2 = 0;
						if (this.struct7_0 != null)
						{
							num2 = this.struct7_0.Length;
							Array.Resize<Class7.Struct7>(ref this.struct7_0, this.struct7_0.Length + (int)num + 1);
						}
						else
						{
							this.struct7_0 = new Class7.Struct7[num + 1UL];
						}
						for (ulong num3 = 0UL; num3 <= num; num3 += 1UL)
						{
							ulong num4 = this.method_5((int)long_0 + 8 + (int)num3 * 2, 2);
							if (long_0 != 100L)
							{
								num4 += (ulong)long_0;
							}
							int num5 = this.method_6((int)num4);
							this.method_7((int)num4, num5);
							int num6 = this.method_6((int)(num4 + (ulong)((long)num5 - (long)num4) + 1UL));
							this.method_7((int)(num4 + (ulong)((long)num5 - (long)num4) + 1UL), num6);
							ulong num7 = num4 + (ulong)((long)num6 - (long)num4 + 1L);
							int num8 = this.method_6((int)num7);
							int num9 = num8;
							long num10 = this.method_7((int)num7, num8);
							long[] array = new long[5];
							for (int i = 0; i <= 4; i++)
							{
								int int_ = num9 + 1;
								num9 = this.method_6(int_);
								array[i] = this.method_7(int_, num9);
								array[i] = (long)((array[i] <= 9L) ? ((ulong)this.byte_0[(int)(checked((IntPtr)array[i]))]) : ((ulong)((!Class7.smethod_0(array[i])) ? ((array[i] - 12L) / 2L) : ((array[i] - 13L) / 2L))));
							}
							if (this.ulong_0 != 1UL)
							{
							}
							if (this.ulong_0 == 1UL)
							{
								this.struct7_0[num2 + (int)num3].string_0 = Encoding.Default.GetString(this.byte_1, (int)(num7 + (ulong)num10 + (ulong)array[0]), (int)array[1]);
							}
							else if (this.ulong_0 == 2UL)
							{
								this.struct7_0[num2 + (int)num3].string_0 = Encoding.Unicode.GetString(this.byte_1, (int)(num7 + (ulong)num10 + (ulong)array[0]), (int)array[1]);
							}
							else if (this.ulong_0 == 3UL)
							{
								this.struct7_0[num2 + (int)num3].string_0 = Encoding.BigEndianUnicode.GetString(this.byte_1, (int)(num7 + (ulong)num10 + (ulong)array[0]), (int)array[1]);
							}
							this.struct7_0[num2 + (int)num3].long_0 = (long)this.method_5((int)(num7 + (ulong)num10 + (ulong)array[0] + (ulong)array[1] + (ulong)array[2]), (int)array[3]);
							if (this.ulong_0 == 1UL)
							{
								this.struct7_0[num2 + (int)num3].string_1 = Encoding.Default.GetString(this.byte_1, (int)(num7 + (ulong)num10 + (ulong)array[0] + (ulong)array[1] + (ulong)array[2] + (ulong)array[3]), (int)array[4]);
							}
							else if (this.ulong_0 == 2UL)
							{
								this.struct7_0[num2 + (int)num3].string_1 = Encoding.Unicode.GetString(this.byte_1, (int)(num7 + (ulong)num10 + (ulong)array[0] + (ulong)array[1] + (ulong)array[2] + (ulong)array[3]), (int)array[4]);
							}
							else if (this.ulong_0 == 3UL)
							{
								this.struct7_0[num2 + (int)num3].string_1 = Encoding.BigEndianUnicode.GetString(this.byte_1, (int)(num7 + (ulong)num10 + (ulong)array[0] + (ulong)array[1] + (ulong)array[2] + (ulong)array[3]), (int)array[4]);
							}
						}
					}
				}
				else
				{
					uint num11 = (uint)(this.method_5((int)long_0 + 3, 2) - 1UL);
					for (int j = 0; j <= (int)num11; j++)
					{
						uint num12 = (uint)this.method_5((int)long_0 + 12 + j * 2, 2);
						if (long_0 == 100L)
						{
							this.method_3((long)((this.method_5((int)num12, 4) - 1UL) * this.ulong_1));
						}
						else
						{
							this.method_3((long)((this.method_5((int)(long_0 + (long)((ulong)num12)), 4) - 1UL) * this.ulong_1));
						}
					}
					this.method_3((long)((this.method_5((int)long_0 + 8, 4) - 1UL) * this.ulong_1));
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00009A38 File Offset: 0x00007C38
		public bool method_4(string string_1)
		{
			bool result;
			try
			{
				int num = -1;
				int i = 0;
				while (i <= this.struct7_0.Length)
				{
					if (string.Compare(this.struct7_0[i].string_0.ToLower(), string_1.ToLower(), StringComparison.Ordinal) != 0)
					{
						i++;
					}
					else
					{
						num = i;
						IL_4D:
						if (num == -1)
						{
							return false;
						}
						string[] array = this.struct7_0[num].string_1.Substring(this.struct7_0[num].string_1.IndexOf("(", StringComparison.Ordinal) + 1).Split(new char[]
						{
							','
						});
						for (int j = 0; j <= array.Length - 1; j++)
						{
							array[j] = array[j].TrimStart(new char[0]);
							int num2 = array[j].IndexOf(' ');
							if (num2 > 0)
							{
								array[j] = array[j].Substring(0, num2);
							}
							if (array[j].IndexOf("UNIQUE", StringComparison.Ordinal) != 0)
							{
								Array.Resize<string>(ref this.string_0, j + 1);
								this.string_0[j] = array[j];
							}
						}
						return this.method_2((ulong)((this.struct7_0[num].long_0 - 1L) * (long)this.ulong_1));
					}
				}
				goto IL_4D;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00009BF0 File Offset: 0x00007DF0
		private ulong method_5(int int_0, int int_1)
		{
			ulong result;
			try
			{
				if (int_1 > 8 | int_1 == 0)
				{
					result = 0UL;
				}
				else
				{
					ulong num = 0UL;
					for (int i = 0; i <= int_1 - 1; i++)
					{
						num = (num << 8 | (ulong)this.byte_1[int_0 + i]);
					}
					result = num;
				}
			}
			catch
			{
				result = 0UL;
			}
			return result;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00009C60 File Offset: 0x00007E60
		private int method_6(int int_0)
		{
			int result;
			try
			{
				if (int_0 > this.byte_1.Length)
				{
					result = 0;
				}
				else
				{
					for (int i = int_0; i <= int_0 + 8; i++)
					{
						if (i > this.byte_1.Length - 1)
						{
							return 0;
						}
						if ((this.byte_1[i] & 128) != 128)
						{
							return i;
						}
					}
					result = int_0 + 8;
				}
			}
			catch
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00009CD4 File Offset: 0x00007ED4
		private long method_7(int int_0, int int_1)
		{
			long result;
			try
			{
				int_1++;
				byte[] array = new byte[8];
				int num = int_1 - int_0;
				bool flag = false;
				if (num == 0 | num > 9)
				{
					result = 0L;
				}
				else if (num == 1)
				{
					array[0] = (this.byte_1[int_0] & 127);
					result = BitConverter.ToInt64(array, 0);
				}
				else
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
						array[0] = this.byte_1[int_1 - 1];
						int_1--;
						num4 = 1;
					}
					for (int i = int_1 - 1; i >= int_0; i += -1)
					{
						if (i - 1 >= int_0)
						{
							array[num4] = (byte)((this.byte_1[i] >> num2 - 1 & 255 >> num2) | (int)this.byte_1[i - 1] << num3);
							num2++;
							num4++;
							num3--;
						}
						else if (!flag)
						{
							array[num4] = (byte)(this.byte_1[i] >> num2 - 1 & 255 >> num2);
						}
					}
					result = BitConverter.ToInt64(array, 0);
				}
			}
			catch
			{
				result = 0L;
			}
			return result;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00003B8A File Offset: 0x00001D8A
		private static bool smethod_0(long long_0)
		{
			return (long_0 & 1L) == 1L;
		}

		// Token: 0x0400005B RID: 91
		private readonly byte[] byte_0 = new byte[]
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

		// Token: 0x0400005C RID: 92
		private readonly ulong ulong_0;

		// Token: 0x0400005D RID: 93
		private readonly byte[] byte_1;

		// Token: 0x0400005E RID: 94
		private readonly ulong ulong_1;

		// Token: 0x0400005F RID: 95
		private string[] string_0;

		// Token: 0x04000060 RID: 96
		private Class7.Struct7[] struct7_0;

		// Token: 0x04000061 RID: 97
		private Class7.Struct6[] struct6_0;

		// Token: 0x0200001C RID: 28
		private struct Struct5
		{
			// Token: 0x04000062 RID: 98
			public long long_0;

			// Token: 0x04000063 RID: 99
			public long long_1;
		}

		// Token: 0x0200001D RID: 29
		private struct Struct6
		{
			// Token: 0x04000064 RID: 100
			public string[] string_0;
		}

		// Token: 0x0200001E RID: 30
		private struct Struct7
		{
			// Token: 0x04000065 RID: 101
			public string string_0;

			// Token: 0x04000066 RID: 102
			public long long_0;

			// Token: 0x04000067 RID: 103
			public string string_1;
		}
	}
}
