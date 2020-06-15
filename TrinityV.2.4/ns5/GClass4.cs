using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ns2;
using ns3;

namespace ns5
{
	// Token: 0x0200000F RID: 15
	public class GClass4 : GClass2, IDictionary<string, GClass2>, ICollection<KeyValuePair<string, GClass2>>, IEnumerable<KeyValuePair<string, GClass2>>, IEnumerable
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000064 RID: 100 RVA: 0x0000327E File Offset: 0x0000147E
		public virtual int Count
		{
			get
			{
				return this.sortedDictionary_0.Count;
			}
		}

		// Token: 0x17000006 RID: 6
		public sealed override GClass2 this[string key]
		{
			get
			{
				return this.sortedDictionary_0[key];
			}
			set
			{
				this.sortedDictionary_0[key] = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000067 RID: 103 RVA: 0x000032A8 File Offset: 0x000014A8
		public virtual GEnum0 GEnum0_0
		{
			get
			{
				return GEnum0.Object;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000068 RID: 104 RVA: 0x000032AB File Offset: 0x000014AB
		public ICollection<string> Keys
		{
			get
			{
				return this.sortedDictionary_0.Keys;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000069 RID: 105 RVA: 0x000032B8 File Offset: 0x000014B8
		public ICollection<GClass2> Values
		{
			get
			{
				return this.sortedDictionary_0.Values;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00003147 File Offset: 0x00001347
		bool ICollection<KeyValuePair<string, GClass2>>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000032C5 File Offset: 0x000014C5
		public GClass4(params KeyValuePair<string, GClass2>[] keyValuePair_0)
		{
			this.sortedDictionary_0 = new SortedDictionary<string, GClass2>(StringComparer.Ordinal);
			if (keyValuePair_0 != null)
			{
				this.method_7(keyValuePair_0);
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000032E7 File Offset: 0x000014E7
		public GClass4(IEnumerable<KeyValuePair<string, GClass2>> ienumerable_0)
		{
			if (ienumerable_0 == null)
			{
				throw new ArgumentNullException("items");
			}
			this.sortedDictionary_0 = new SortedDictionary<string, GClass2>(StringComparer.Ordinal);
			this.method_6(ienumerable_0);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00003314 File Offset: 0x00001514
		public IEnumerator<KeyValuePair<string, GClass2>> GetEnumerator()
		{
			return this.sortedDictionary_0.GetEnumerator();
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00003314 File Offset: 0x00001514
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.sortedDictionary_0.GetEnumerator();
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00003326 File Offset: 0x00001526
		public void Add(string key, GClass2 value)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			this.sortedDictionary_0.Add(key, value);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00003343 File Offset: 0x00001543
		public void Add(KeyValuePair<string, GClass2> pair)
		{
			this.method_8(pair.Key, pair.Value);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00006CE4 File Offset: 0x00004EE4
		public void method_6(IEnumerable<KeyValuePair<string, GClass2>> ienumerable_0)
		{
			if (ienumerable_0 == null)
			{
				throw new ArgumentNullException("items");
			}
			foreach (KeyValuePair<string, GClass2> keyValuePair in ienumerable_0)
			{
				this.sortedDictionary_0.Add(keyValuePair.Key, keyValuePair.Value);
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00003359 File Offset: 0x00001559
		public void method_7(params KeyValuePair<string, GClass2>[] keyValuePair_0)
		{
			this.method_6(keyValuePair_0);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00003362 File Offset: 0x00001562
		public void Clear()
		{
			this.sortedDictionary_0.Clear();
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000336F File Offset: 0x0000156F
		bool ICollection<KeyValuePair<string, GClass2>>.Contains(KeyValuePair<string, GClass2> item)
		{
			return ((ICollection<KeyValuePair<string, GClass2>>)this.sortedDictionary_0).Contains(item);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000337D File Offset: 0x0000157D
		bool ICollection<KeyValuePair<string, GClass2>>.Remove(KeyValuePair<string, GClass2> item)
		{
			return ((ICollection<KeyValuePair<string, GClass2>>)this.sortedDictionary_0).Remove(item);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000338B File Offset: 0x0000158B
		public virtual bool ContainsKey(string key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			return this.sortedDictionary_0.ContainsKey(key);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000033A7 File Offset: 0x000015A7
		public void CopyTo(KeyValuePair<string, GClass2>[] array, int arrayIndex)
		{
			((ICollection<KeyValuePair<string, GClass2>>)this.sortedDictionary_0).CopyTo(array, arrayIndex);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000033B6 File Offset: 0x000015B6
		public bool Remove(string key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			return this.sortedDictionary_0.Remove(key);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00006D50 File Offset: 0x00004F50
		public virtual void vmethod_1(Stream stream_0, bool bool_0)
		{
			if (stream_0 == null)
			{
				throw new ArgumentNullException("stream");
			}
			stream_0.WriteByte(123);
			foreach (KeyValuePair<string, GClass2> keyValuePair in this.sortedDictionary_0)
			{
				stream_0.WriteByte(34);
				byte[] bytes = Encoding.UTF8.GetBytes(base.method_3(keyValuePair.Key));
				stream_0.Write(bytes, 0, bytes.Length);
				stream_0.WriteByte(34);
				stream_0.WriteByte(44);
				stream_0.WriteByte(32);
				if (keyValuePair.Value == null)
				{
					stream_0.WriteByte(110);
					stream_0.WriteByte(117);
					stream_0.WriteByte(108);
					stream_0.WriteByte(108);
				}
				else
				{
					keyValuePair.Value.vmethod_1(stream_0, bool_0);
				}
			}
			stream_0.WriteByte(125);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000033D2 File Offset: 0x000015D2
		public bool TryGetValue(string key, out GClass2 value)
		{
			return this.sortedDictionary_0.TryGetValue(key, out value);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000033E1 File Offset: 0x000015E1
		void method_8(string string_0, object object_0)
		{
			this.Add(string_0, object_0);
		}

		// Token: 0x04000034 RID: 52
		private SortedDictionary<string, GClass2> sortedDictionary_0;
	}
}
