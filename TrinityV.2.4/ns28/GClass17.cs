using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace ns28
{
	// Token: 0x0200002F RID: 47
	public class GClass17
	{
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x00003EF1 File Offset: 0x000020F1
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x00003EF9 File Offset: 0x000020F9
		public string String_0 { get; set; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x00003F02 File Offset: 0x00002102
		public List<KeyValuePair<string, string>> List_0 { get; }

		// Token: 0x060001A7 RID: 423 RVA: 0x0000D138 File Offset: 0x0000B338
		public GClass17(string string_1)
		{
			List<byte> list = new List<byte>();
			this.List_0 = new List<KeyValuePair<string, string>>();
			using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(string_1)))
			{
				int i = 0;
				int num = (int)binaryReader.BaseStream.Length;
				while (i < num)
				{
					list.Add(binaryReader.ReadByte());
					i++;
				}
			}
			string value = BitConverter.ToString(this.method_0(list.ToArray(), 0, 4, false)).Replace("-", "");
			string text = BitConverter.ToString(this.method_0(list.ToArray(), 4, 4, false)).Replace("-", "");
			int num2 = BitConverter.ToInt32(this.method_0(list.ToArray(), 12, 4, true), 0);
			if (!string.IsNullOrEmpty(value))
			{
				this.String_0 = "Berkelet DB";
				if (text.Equals("00000002"))
				{
					this.String_0 += " 1.85 (Hash, version 2, native byte-order)";
				}
				int num3 = int.Parse(BitConverter.ToString(this.method_0(list.ToArray(), 56, 4, false)).Replace("-", ""));
				int num4 = 1;
				while (this.List_0.Count < num3)
				{
					string[] array = new string[(num3 - this.List_0.Count) * 2];
					for (int j = 0; j < (num3 - this.List_0.Count) * 2; j++)
					{
						array[j] = BitConverter.ToString(this.method_0(list.ToArray(), num2 * num4 + 2 + j * 2, 2, true)).Replace("-", "");
					}
					Array.Sort<string>(array);
					for (int k = 0; k < array.Length; k += 2)
					{
						int num5 = Convert.ToInt32(array[k], 16) + num2 * num4;
						int num6 = Convert.ToInt32(array[k + 1], 16) + num2 * num4;
						int num7 = (k + 2 >= array.Length) ? (num2 + num2 * num4) : (Convert.ToInt32(array[k + 2], 16) + num2 * num4);
						string @string = Encoding.ASCII.GetString(this.method_0(list.ToArray(), num6, num7 - num6, false));
						string value2 = BitConverter.ToString(this.method_0(list.ToArray(), num5, num6 - num5, false));
						if (!string.IsNullOrEmpty(@string))
						{
							this.List_0.Add(new KeyValuePair<string, string>(@string, value2));
						}
					}
					num4++;
				}
				return;
			}
			this.String_0 = "Unknow database format";
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0000D454 File Offset: 0x0000B654
		private byte[] method_0(byte[] byte_0, int int_0, int int_1, bool bool_0)
		{
			byte[] array = new byte[int_1];
			int num = 0;
			for (int i = int_0; i < int_0 + int_1; i++)
			{
				array[num] = byte_0[i];
				num++;
			}
			if (bool_0)
			{
				Array.Reverse(array);
			}
			return array;
		}

		// Token: 0x040000B3 RID: 179
		[CompilerGenerated]
		private string string_0;

		// Token: 0x040000B4 RID: 180
		[CompilerGenerated]
		private readonly List<KeyValuePair<string, string>> list_0;
	}
}
