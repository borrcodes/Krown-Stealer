using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using ns2;
using ns3;

namespace ns4
{
	// Token: 0x0200000D RID: 13
	public class GClass3 : GClass2, IList<GClass2>, ICollection<GClass2>, IEnumerable<GClass2>, IEnumerable
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600004E RID: 78 RVA: 0x0000313A File Offset: 0x0000133A
		public virtual int Count
		{
			get
			{
				return this.list_0.Count;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00003147 File Offset: 0x00001347
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000003 RID: 3
		public sealed override GClass2 this[int index]
		{
			get
			{
				return this.list_0[index];
			}
			set
			{
				this.list_0[index] = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00003167 File Offset: 0x00001367
		public virtual GEnum0 GEnum0_0
		{
			get
			{
				return GEnum0.Array;
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000316A File Offset: 0x0000136A
		public GClass3(params GClass2[] gclass2_0)
		{
			this.list_0 = new List<GClass2>();
			this.method_7(gclass2_0);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003184 File Offset: 0x00001384
		public GClass3(IEnumerable<GClass2> ienumerable_0)
		{
			if (ienumerable_0 == null)
			{
				throw new ArgumentNullException("items");
			}
			this.list_0 = new List<GClass2>(ienumerable_0);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000031A6 File Offset: 0x000013A6
		public void Add(GClass2 item)
		{
			if (item == null)
			{
				throw new ArgumentNullException("item");
			}
			this.list_0.Add(item);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000031C2 File Offset: 0x000013C2
		public void method_6(IEnumerable<GClass2> ienumerable_0)
		{
			if (ienumerable_0 == null)
			{
				throw new ArgumentNullException("items");
			}
			this.list_0.AddRange(ienumerable_0);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000031DE File Offset: 0x000013DE
		public void method_7(params GClass2[] gclass2_0)
		{
			if (gclass2_0 != null)
			{
				this.list_0.AddRange(gclass2_0);
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000031EF File Offset: 0x000013EF
		public void Clear()
		{
			this.list_0.Clear();
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000031FC File Offset: 0x000013FC
		public bool Contains(GClass2 item)
		{
			return this.list_0.Contains(item);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000320A File Offset: 0x0000140A
		public void CopyTo(GClass2[] array, int arrayIndex)
		{
			this.list_0.CopyTo(array, arrayIndex);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00003219 File Offset: 0x00001419
		public int IndexOf(GClass2 item)
		{
			return this.list_0.IndexOf(item);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00003227 File Offset: 0x00001427
		public void Insert(int index, GClass2 item)
		{
			this.list_0.Insert(index, item);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00003236 File Offset: 0x00001436
		public bool Remove(GClass2 item)
		{
			return this.list_0.Remove(item);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00003244 File Offset: 0x00001444
		public void RemoveAt(int index)
		{
			this.list_0.RemoveAt(index);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00006C24 File Offset: 0x00004E24
		public virtual void vmethod_1(Stream stream_0, bool bool_0)
		{
			if (stream_0 == null)
			{
				throw new ArgumentNullException("stream");
			}
			stream_0.WriteByte(91);
			for (int i = 0; i < this.list_0.Count; i++)
			{
				GClass2 gclass = this.list_0[i];
				if (gclass != null)
				{
					gclass.vmethod_1(stream_0, bool_0);
				}
				else
				{
					stream_0.WriteByte(110);
					stream_0.WriteByte(117);
					stream_0.WriteByte(108);
					stream_0.WriteByte(108);
				}
				if (i < this.Int32_0 - 1)
				{
					stream_0.WriteByte(44);
					stream_0.WriteByte(32);
				}
			}
			stream_0.WriteByte(93);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00003252 File Offset: 0x00001452
		IEnumerator<GClass2> IEnumerable<GClass2>.GetEnumerator()
		{
			return this.list_0.GetEnumerator();
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00003252 File Offset: 0x00001452
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.list_0.GetEnumerator();
		}

		// Token: 0x04000033 RID: 51
		private List<GClass2> list_0;
	}
}
