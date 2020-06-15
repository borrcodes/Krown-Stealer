using System;
using ns21;
using ns23;

namespace ns20
{
	// Token: 0x02000027 RID: 39
	public class GClass10
	{
		// Token: 0x06000164 RID: 356 RVA: 0x0000C948 File Offset: 0x0000AB48
		public static GClass12 smethod_0(byte[] byte_0)
		{
			GClass12 gclass = new GClass12();
			for (int i = 0; i < byte_0.Length; i++)
			{
				GEnum1 genum = (GEnum1)byte_0[i];
				switch (genum)
				{
				case GEnum1.Integer:
				{
					gclass.List_0.Add(new GClass12
					{
						GEnum1_0 = GEnum1.Integer,
						Int32_0 = (int)byte_0[i + 1]
					});
					byte[] array = new byte[(int)byte_0[i + 1]];
					int length = (i + 2 + (int)byte_0[i + 1] > byte_0.Length) ? (byte_0.Length - (i + 2)) : ((int)byte_0[i + 1]);
					Array.Copy(byte_0, i + 2, array, 0, length);
					gclass.List_0[gclass.List_0.Count - 1].Byte_0 = array;
					i = i + 1 + gclass.List_0[gclass.List_0.Count - 1].Int32_0;
					break;
				}
				case GEnum1.BitString:
				case GEnum1.Null:
					break;
				case GEnum1.OctetString:
				{
					gclass.List_0.Add(new GClass12
					{
						GEnum1_0 = GEnum1.OctetString,
						Int32_0 = (int)byte_0[i + 1]
					});
					byte[] array2 = new byte[(int)byte_0[i + 1]];
					int length = (i + 2 + (int)byte_0[i + 1] > byte_0.Length) ? (byte_0.Length - (i + 2)) : ((int)byte_0[i + 1]);
					Array.Copy(byte_0, i + 2, array2, 0, length);
					gclass.List_0[gclass.List_0.Count - 1].Byte_0 = array2;
					i = i + 1 + gclass.List_0[gclass.List_0.Count - 1].Int32_0;
					break;
				}
				case GEnum1.ObjectIdentifier:
				{
					gclass.List_0.Add(new GClass12
					{
						GEnum1_0 = GEnum1.ObjectIdentifier,
						Int32_0 = (int)byte_0[i + 1]
					});
					byte[] array3 = new byte[(int)byte_0[i + 1]];
					int length = (i + 2 + (int)byte_0[i + 1] > byte_0.Length) ? (byte_0.Length - (i + 2)) : ((int)byte_0[i + 1]);
					Array.Copy(byte_0, i + 2, array3, 0, length);
					gclass.List_0[gclass.List_0.Count - 1].Byte_0 = array3;
					i = i + 1 + gclass.List_0[gclass.List_0.Count - 1].Int32_0;
					break;
				}
				default:
					if (genum == GEnum1.Sequence)
					{
						byte[] array4;
						if (gclass.Int32_0 == 0)
						{
							gclass.GEnum1_0 = GEnum1.Sequence;
							gclass.Int32_0 = byte_0.Length - (i + 2);
							array4 = new byte[gclass.Int32_0];
						}
						else
						{
							gclass.List_0.Add(new GClass12
							{
								GEnum1_0 = GEnum1.Sequence,
								Int32_0 = (int)byte_0[i + 1]
							});
							array4 = new byte[(int)byte_0[i + 1]];
						}
						int num = (array4.Length > byte_0.Length - (i + 2)) ? (byte_0.Length - (i + 2)) : array4.Length;
						Array.Copy(byte_0, i + 2, array4, 0, array4.Length);
						gclass.List_0.Add(GClass10.smethod_0(array4));
						i = i + 1 + (int)byte_0[i + 1];
					}
					break;
				}
			}
			return gclass;
		}
	}
}
