using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace ns0
{
	// Token: 0x0200000C RID: 12
	public class GClass0
	{
		// Token: 0x06000043 RID: 67 RVA: 0x00003090 File Offset: 0x00001290
		public GClass0(TextReader textReader_1)
		{
			if (textReader_1 == null)
			{
				throw new ArgumentNullException("reader");
			}
			this.textReader_0 = textReader_1;
			this.stringBuilder_0 = new StringBuilder();
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000030C3 File Offset: 0x000012C3
		public object method_0()
		{
			object result = this.method_1();
			this.method_4();
			if (this.method_3() >= 0)
			{
				throw this.method_9("extra characters in JSON input");
			}
			return result;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000063A8 File Offset: 0x000045A8
		private object method_1()
		{
			this.method_4();
			int num = this.method_2();
			if (num < 0)
			{
				throw this.method_9("Incomplete JSON input");
			}
			if (num <= 102)
			{
				if (num == 34)
				{
					return this.method_6();
				}
				if (num != 91)
				{
					if (num == 102)
					{
						this.method_8("false");
						return false;
					}
				}
				else
				{
					this.method_3();
					List<object> list = new List<object>();
					this.method_4();
					if (this.method_2() == 93)
					{
						this.method_3();
						return list;
					}
					for (;;)
					{
						object item = this.method_1();
						list.Add(item);
						this.method_4();
						num = this.method_2();
						if (num != 44)
						{
							break;
						}
						this.method_3();
					}
					if (this.method_3() != 93)
					{
						throw this.method_9("JSON array must end with ']'");
					}
					return list.ToArray();
				}
			}
			else
			{
				if (num == 110)
				{
					this.method_8("null");
					return null;
				}
				if (num == 116)
				{
					this.method_8("true");
					return true;
				}
				if (num == 123)
				{
					this.method_3();
					Dictionary<string, object> dictionary = new Dictionary<string, object>();
					this.method_4();
					if (this.method_2() == 125)
					{
						this.method_3();
						return dictionary;
					}
					do
					{
						this.method_4();
						if (this.method_2() == 125)
						{
							goto Block_15;
						}
						string key = this.method_6();
						this.method_4();
						this.method_7(':');
						this.method_4();
						dictionary[key] = this.method_1();
						this.method_4();
						num = this.method_3();
					}
					while (num == 44 || num != 125);
					goto IL_1C2;
					Block_15:
					this.method_3();
					IL_1C2:
					int num2 = 0;
					KeyValuePair<string, object>[] array = new KeyValuePair<string, object>[dictionary.Count];
					foreach (KeyValuePair<string, object> keyValuePair in dictionary)
					{
						array[num2++] = keyValuePair;
					}
					return array;
				}
			}
			if ((48 <= num && num <= 57) || num == 45)
			{
				return this.method_5();
			}
			throw this.method_9(string.Format("Unexpected character '{0}'", (char)num));
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000030EA File Offset: 0x000012EA
		private int method_2()
		{
			if (!this.bool_0)
			{
				this.int_2 = this.textReader_0.Read();
				this.bool_0 = true;
			}
			return this.int_2;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00006604 File Offset: 0x00004804
		private int method_3()
		{
			object obj = this.bool_0 ? this.int_2 : this.textReader_0.Read();
			this.bool_0 = false;
			if (this.bool_1)
			{
				this.int_0++;
				this.int_1 = 0;
				this.bool_1 = false;
			}
			object obj2 = obj;
			if (obj2 == 10)
			{
				this.bool_1 = true;
			}
			this.int_1++;
			return obj2;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00006674 File Offset: 0x00004874
		private void method_4()
		{
			for (;;)
			{
				int num = this.method_2();
				if (num - 9 > 1 && num != 13)
				{
					if (num != 32)
					{
						break;
					}
				}
				this.method_3();
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000066A4 File Offset: 0x000048A4
		private object method_5()
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (this.method_2() == 45)
			{
				stringBuilder.Append((char)this.method_3());
			}
			int num = 0;
			bool flag = this.method_2() == 48;
			int num2;
			for (;;)
			{
				num2 = this.method_2();
				if (num2 < 48 || 57 < num2)
				{
					goto IL_7F;
				}
				stringBuilder.Append((char)this.method_3());
				if (flag && num == 1)
				{
					break;
				}
				num++;
			}
			throw this.method_9("leading zeros are not allowed");
			IL_7F:
			if (num == 0)
			{
				throw this.method_9("Invalid JSON numeric literal; no digit found");
			}
			bool flag2 = false;
			int num3 = 0;
			if (this.method_2() == 46)
			{
				flag2 = true;
				stringBuilder.Append((char)this.method_3());
				if (this.method_2() < 0)
				{
					throw this.method_9("Invalid JSON numeric literal; extra dot");
				}
				for (;;)
				{
					num2 = this.method_2();
					if (num2 < 48 || 57 < num2)
					{
						break;
					}
					stringBuilder.Append((char)this.method_3());
					num3++;
				}
				if (num3 == 0)
				{
					throw this.method_9("Invalid JSON numeric literal; extra dot");
				}
			}
			num2 = this.method_2();
			if (num2 != 101 && num2 != 69)
			{
				if (!flag2)
				{
					int num4;
					if (int.TryParse(stringBuilder.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out num4))
					{
						return num4;
					}
					long num5;
					if (long.TryParse(stringBuilder.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out num5))
					{
						return num5;
					}
					ulong num6;
					if (ulong.TryParse(stringBuilder.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out num6))
					{
						return num6;
					}
				}
				decimal num7;
				if (decimal.TryParse(stringBuilder.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out num7) && num7 != 0m)
				{
					return num7;
				}
			}
			else
			{
				stringBuilder.Append((char)this.method_3());
				if (this.method_2() < 0)
				{
					throw new ArgumentException("Invalid JSON numeric literal; incomplete exponent");
				}
				int num8 = this.method_2();
				if (num8 != 43)
				{
					if (num8 == 45)
					{
						stringBuilder.Append((char)this.method_3());
					}
				}
				else
				{
					stringBuilder.Append((char)this.method_3());
				}
				if (this.method_2() < 0)
				{
					throw this.method_9("Invalid JSON numeric literal; incomplete exponent");
				}
				for (;;)
				{
					num2 = this.method_2();
					if (num2 < 48 || 57 < num2)
					{
						break;
					}
					stringBuilder.Append((char)this.method_3());
				}
			}
			return double.Parse(stringBuilder.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00006938 File Offset: 0x00004B38
		private string method_6()
		{
			if (this.method_2() != 34)
			{
				throw this.method_9("Invalid JSON string literal format");
			}
			this.method_3();
			this.stringBuilder_0.Length = 0;
			for (;;)
			{
				int num = this.method_3();
				if (num < 0)
				{
					goto IL_23D;
				}
				if (num == 34)
				{
					goto IL_249;
				}
				if (num != 92)
				{
					this.stringBuilder_0.Append((char)num);
				}
				else
				{
					num = this.method_3();
					if (num < 0)
					{
						goto IL_231;
					}
					if (num <= 92)
					{
						if (num != 34 && num != 47 && num != 92)
						{
							break;
						}
						this.stringBuilder_0.Append((char)num);
					}
					else if (num <= 102)
					{
						if (num != 98)
						{
							if (num != 102)
							{
								break;
							}
							this.stringBuilder_0.Append('\f');
						}
						else
						{
							this.stringBuilder_0.Append('\b');
						}
					}
					else
					{
						if (num != 110)
						{
							switch (num)
							{
							case 114:
								this.stringBuilder_0.Append('\r');
								continue;
							case 116:
								this.stringBuilder_0.Append('\t');
								continue;
							case 117:
							{
								ushort num2 = 0;
								for (int i = 0; i < 4; i++)
								{
									num2 = (ushort)(num2 << 4);
									if ((num = this.method_3()) < 0)
									{
										goto IL_225;
									}
									if (48 <= num && num <= 57)
									{
										num2 += (ushort)(num - 48);
									}
									if (65 <= num && num <= 70)
									{
										num2 += (ushort)(num - 65 + 10);
									}
									if (97 <= num && num <= 102)
									{
										num2 += (ushort)(num - 97 + 10);
									}
								}
								this.stringBuilder_0.Append((char)num2);
								continue;
							}
							}
							break;
						}
						this.stringBuilder_0.Append('\n');
					}
				}
			}
			throw this.method_9("Invalid JSON string literal; unexpected escape character");
			IL_225:
			throw this.method_9("Incomplete unicode character escape literal");
			IL_231:
			throw this.method_9("Invalid JSON string literal; incomplete escape sequence");
			IL_23D:
			throw this.method_9("JSON string is not closed");
			IL_249:
			return this.stringBuilder_0.ToString();
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00006B9C File Offset: 0x00004D9C
		private void method_7(char char_0)
		{
			int num;
			if ((num = this.method_3()) != (int)char_0)
			{
				throw this.method_9(string.Format("Expected '{0}', got '{1}'", char_0, (char)num));
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00006BD4 File Offset: 0x00004DD4
		private void method_8(string string_0)
		{
			for (int i = 0; i < string_0.Length; i++)
			{
				if (this.method_3() != (int)string_0[i])
				{
					throw this.method_9(string.Format("Expected '{0}', differed at {1}", string_0, i));
				}
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00003112 File Offset: 0x00001312
		private Exception method_9(string string_0)
		{
			return new ArgumentException(string.Format("{0}. At line {1}, column {2}", string_0, this.int_0, this.int_1));
		}

		// Token: 0x0400002C RID: 44
		private readonly StringBuilder stringBuilder_0;

		// Token: 0x0400002D RID: 45
		private readonly TextReader textReader_0;

		// Token: 0x0400002E RID: 46
		private int int_0 = 1;

		// Token: 0x0400002F RID: 47
		private int int_1;

		// Token: 0x04000030 RID: 48
		private int int_2;

		// Token: 0x04000031 RID: 49
		private bool bool_0;

		// Token: 0x04000032 RID: 50
		private bool bool_1;
	}
}
