using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

// Token: 0x02000001 RID: 1
internal class <Module>
{
	// Token: 0x06000001 RID: 1 RVA: 0x000040F0 File Offset: 0x000022F0
	static <Module>()
	{
		/*
An exception occurred when decompiling this method (06000001)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void <Module>::.cctor()
 ---> System.ArgumentOutOfRangeException: Требуется неотрицательное число.
Имя параметра: length
   в System.Array.Copy(Array sourceArray, Int32 sourceIndex, Array destinationArray, Int32 destinationIndex, Int32 length, Boolean reliable)
   в System.Array.Copy(Array sourceArray, Array destinationArray, Int32 length)
   в ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackSlot.ModifyStack(StackSlot[] stack, Int32 popCount, Int32 pushCount, ByteCode pushDefinition) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:строка 48
   в ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:строка 387
   в ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:строка 269
   в ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:строка 112
   в ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:строка 88
   --- Конец трассировки внутреннего стека исключений ---
   в ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:строка 92
   в ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) в D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:строка 1533
*/;
	}

	// Token: 0x06000002 RID: 2 RVA: 0x0000433C File Offset: 0x0000253C
	private static void smethod_0()
	{
		string str = "COR";
		Type typeFromHandle = typeof(Environment);
		MethodInfo method = typeFromHandle.GetMethod("GetEnvironmentVariable", new Type[]
		{
			typeof(string)
		});
		if (method != null && "1".Equals(method.Invoke(null, new object[]
		{
			str + "_ENABLE_PROFILING"
		})))
		{
			Environment.FailFast(null);
		}
		new Thread(new ParameterizedThreadStart(<Module>.smethod_1))
		{
			IsBackground = true
		}.Start(null);
	}

	// Token: 0x06000003 RID: 3 RVA: 0x000043E4 File Offset: 0x000025E4
	private static void smethod_1(object object_0)
	{
		Thread thread = object_0 as Thread;
		if (thread == null)
		{
			thread = new Thread(new ParameterizedThreadStart(<Module>.smethod_1));
			thread.IsBackground = true;
			thread.Start(Thread.CurrentThread);
			Thread.Sleep(500);
		}
		for (;;)
		{
			if (Debugger.IsAttached)
			{
				goto IL_3D;
			}
			if (Debugger.IsLogging())
			{
				goto IL_3D;
			}
			IL_43:
			if (!thread.IsAlive)
			{
				Environment.FailFast(null);
			}
			Thread.Sleep(1000);
			continue;
			IL_3D:
			Environment.FailFast(null);
			goto IL_43;
		}
	}

	// Token: 0x06000004 RID: 4
	[DllImport("kernel32.dll")]
	internal unsafe static extern bool VirtualProtect(byte* pByte_0, int int_0, uint uint_0, ref uint uint_1);

	// Token: 0x06000005 RID: 5 RVA: 0x00004464 File Offset: 0x00002664
	internal unsafe static void smethod_2()
	{
		byte* ptr = (byte*)((void*)Marshal.GetHINSTANCE(typeof(<Module>).Module));
		byte* ptr2 = ptr + 60;
		ptr2 = ptr + *(uint*)ptr2;
		ptr2 += 6;
		ushort num = *(ushort*)ptr2;
		ptr2 += 14;
		ushort num2 = *(ushort*)ptr2;
		ptr2 = ptr2 + 4 + num2;
		(UIntPtr)11UL;
		uint num3;
		<Module>.VirtualProtect(ptr2 - 16, 8, 64U, ref num3);
		*(int*)(ptr2 - 12) = 0;
		byte* ptr3 = ptr + *(uint*)(ptr2 - 16);
		*(int*)(ptr2 - 16) = 0;
		<Module>.VirtualProtect(ptr3, 72, 64U, ref num3);
		byte* ptr4 = ptr + *(uint*)(ptr3 + 8);
		*(int*)ptr3 = 0;
		*(int*)(ptr3 + 4) = 0;
		*(int*)(ptr3 + 8) = 0;
		*(int*)(ptr3 + 12) = 0;
		<Module>.VirtualProtect(ptr4, 4, 64U, ref num3);
		*(int*)ptr4 = 0;
		for (int i = 0; i < (int)num; i++)
		{
			<Module>.VirtualProtect(ptr2, 8, 64U, ref num3);
			Marshal.Copy(new byte[8], 0, (IntPtr)((void*)ptr2), 8);
			ptr2 += 40;
		}
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00004558 File Offset: 0x00002758
	internal static void smethod_3()
	{
		Stream baseStream = new StreamReader(typeof(<Module>).Assembly.Location).BaseStream;
		BinaryReader binaryReader = new BinaryReader(baseStream);
		byte[] array = File.ReadAllBytes(typeof(<Module>).Assembly.Location);
		byte[] byte_ = binaryReader.ReadBytes(array.Length - 32);
		string a = <Module>.smethod_4(byte_);
		binaryReader.BaseStream.Position = binaryReader.BaseStream.Length - 32L;
		string @string = Encoding.ASCII.GetString(binaryReader.ReadBytes(32));
		if (a != @string)
		{
			MessageBox.Show("You probably know what this mean, if not, i'll tell u, you modified the app so TrinityProtector is mad :)", "TrinityProtector - Trinity0", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			Process.GetCurrentProcess().Kill();
		}
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00004624 File Offset: 0x00002824
	internal static string smethod_4(byte[] byte_1)
	{
		MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] array = md5CryptoServiceProvider.ComputeHash(byte_1);
		StringBuilder stringBuilder = new StringBuilder();
		foreach (byte b in array)
		{
			stringBuilder.Append(b.ToString("x2").ToLower());
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002EDC File Offset: 0x000010DC
	internal static void smethod_5()
	{
	}

	// Token: 0x06000009 RID: 9 RVA: 0x0000468C File Offset: 0x0000288C
	internal static byte[] smethod_6(byte[] byte_1)
	{
		MemoryStream memoryStream = new MemoryStream(byte_1);
		<Module>.Class1 @class = new <Module>.Class1();
		byte[] buffer = new byte[5];
		memoryStream.Read(buffer, 0, 5);
		@class.method_5(buffer);
		long num = 0L;
		for (int i = 0; i < 8; i++)
		{
			int num2 = memoryStream.ReadByte();
			num |= (long)((long)((ulong)((byte)num2)) << 8 * i);
		}
		byte[] array = new byte[(int)num];
		MemoryStream stream_ = new MemoryStream(array, true);
		long long_ = memoryStream.Length - 13L;
		@class.method_4(memoryStream, stream_, long_, num);
		return array;
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00004728 File Offset: 0x00002928
	internal static byte[] smethod_7(byte[] A_0)
	{
		uint num = 928U;
		uint[] array = new uint[16];
		uint num2 = 771735947U;
		for (int i = 0; i < 16; i++)
		{
			num2 ^= num2 >> 12;
			num2 ^= num2 << 25;
			num2 ^= num2 >> 27;
			array[i] = num2;
		}
		int num3 = 0;
		int num4 = 0;
		uint[] array2 = new uint[16];
		byte[] array3 = new byte[num * 4U];
		while ((long)num3 < (long)((ulong)num))
		{
			for (int j = 0; j < 16; j++)
			{
				array2[j] = (uint)A_0[num3 + j];
			}
			array2[0] = (array2[0] ^ array[0]);
			array2[1] = (array2[1] ^ array[1]);
			array2[2] = (array2[2] ^ array[2]);
			array2[3] = (array2[3] ^ array[3]);
			array2[4] = (array2[4] ^ array[4]);
			array2[5] = (array2[5] ^ array[5]);
			array2[6] = (array2[6] ^ array[6]);
			array2[7] = (array2[7] ^ array[7]);
			array2[8] = (array2[8] ^ array[8]);
			array2[9] = (array2[9] ^ array[9]);
			array2[10] = (array2[10] ^ array[10]);
			array2[11] = (array2[11] ^ array[11]);
			array2[12] = (array2[12] ^ array[12]);
			array2[13] = (array2[13] ^ array[13]);
			array2[14] = (array2[14] ^ array[14]);
			array2[15] = (array2[15] ^ array[15]);
			for (int k = 0; k < 16; k++)
			{
				uint num5 = array2[k];
				array3[num4++] = (byte)num5;
				array3[num4++] = (byte)(num5 >> 8);
				array3[num4++] = (byte)(num5 >> 16);
				array3[num4++] = (byte)(num5 >> 24);
				array[k] ^= num5;
			}
			num3 += 16;
		}
		return array3;
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00004904 File Offset: 0x00002B04
	internal static T smethod_8<T>(uint uint_0, uint uint_1, uint uint_2)
	{
		uint_0 = (uint_0 * 2283669271U ^ 1050255224U);
		uint num = uint_0 >> 30;
		T result = default(T);
		uint_0 &= 1073741823U;
		uint_0 <<= 2;
		uint_1 &= 1073741823U;
		uint_1 <<= 2;
		if ((ulong)num == 0UL)
		{
			int count = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.byte_0, (int)uint_0, count)));
		}
		else if ((ulong)num == 3UL)
		{
			T[] array = new T[1];
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array, 0, sizeof(T));
			result = array[0];
		}
		else if ((ulong)num == 1UL)
		{
			int num2 = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			int length = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			Array array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array2, 0, num2 - 4);
			result = (T)((object)array2);
		}
		return result;
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00004AB8 File Offset: 0x00002CB8
	internal static T smethod_9<T>(uint uint_0, uint uint_1, uint uint_2)
	{
		uint_0 = (uint_0 * 3138277413U ^ 3246726496U);
		uint num = uint_0 >> 30;
		T result = default(T);
		uint_0 &= 1073741823U;
		uint_0 <<= 2;
		uint_1 &= 1073741823U;
		uint_1 <<= 2;
		if ((ulong)num == 1UL)
		{
			int count = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.byte_0, (int)uint_0, count)));
		}
		else if ((ulong)num == 2UL)
		{
			T[] array = new T[1];
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array, 0, sizeof(T));
			result = array[0];
		}
		else if ((ulong)num == 0UL)
		{
			int num2 = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			int length = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			Array array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array2, 0, num2 - 4);
			result = (T)((object)array2);
		}
		return result;
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00004C6C File Offset: 0x00002E6C
	internal static T smethod_10<T>(uint uint_0, uint uint_1, uint uint_2)
	{
		uint_0 = (uint_0 * 3736306837U ^ 1696047991U);
		uint num = uint_0 >> 30;
		T result = default(T);
		uint_0 &= 1073741823U;
		uint_0 <<= 2;
		uint_1 &= 1073741823U;
		uint_1 <<= 2;
		if ((ulong)num == 2UL)
		{
			int count = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.byte_0, (int)uint_0, count)));
		}
		else if ((ulong)num == 1UL)
		{
			T[] array = new T[1];
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array, 0, sizeof(T));
			result = array[0];
		}
		else if ((ulong)num == 0UL)
		{
			int num2 = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			int length = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			Array array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array2, 0, num2 - 4);
			result = (T)((object)array2);
		}
		return result;
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00004E20 File Offset: 0x00003020
	internal static T smethod_11<T>(uint uint_0, uint uint_1, uint uint_2)
	{
		uint_0 = (uint_0 * 1785633621U ^ 657035722U);
		uint num = uint_0 >> 30;
		T result = default(T);
		uint_0 &= 1073741823U;
		uint_0 <<= 2;
		uint_1 &= 1073741823U;
		uint_1 <<= 2;
		if ((ulong)num == 0UL)
		{
			int count = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.byte_0, (int)uint_0, count)));
		}
		else if ((ulong)num == 2UL)
		{
			T[] array = new T[1];
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array, 0, sizeof(T));
			result = array[0];
		}
		else if ((ulong)num == 3UL)
		{
			int num2 = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			int length = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			Array array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array2, 0, num2 - 4);
			result = (T)((object)array2);
		}
		return result;
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00004FD4 File Offset: 0x000031D4
	internal static T smethod_12<T>(uint uint_0, uint uint_1, uint uint_2)
	{
		uint_0 = (uint_0 * 400660039U ^ 2310009310U);
		uint num = uint_0 >> 30;
		T result = default(T);
		uint_0 &= 1073741823U;
		uint_0 <<= 2;
		uint_1 &= 1073741823U;
		uint_1 <<= 2;
		if ((ulong)num == 3UL)
		{
			int count = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.byte_0, (int)uint_0, count)));
		}
		else if ((ulong)num == 2UL)
		{
			T[] array = new T[1];
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array, 0, sizeof(T));
			result = array[0];
		}
		else if ((ulong)num == 0UL)
		{
			int num2 = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			int length = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
			Array array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array2, 0, num2 - 4);
			result = (T)((object)array2);
		}
		return result;
	}

	// Token: 0x06000010 RID: 16
	[DllImport("kernel32.dll", EntryPoint = "VirtualProtect")]
	internal static extern bool VirtualProtect_1(IntPtr intptr_0, uint uint_0, uint uint_1, ref uint uint_2);

	// Token: 0x06000011 RID: 17
	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	internal static extern bool CheckRemoteDebuggerPresent(IntPtr intptr_0, ref bool bool_0);

	// Token: 0x06000012 RID: 18 RVA: 0x00005188 File Offset: 0x00003388
	internal unsafe static void smethod_13()
	{
		Module module = typeof(<Module>).Module;
		string fullyQualifiedName = module.FullyQualifiedName;
		bool flag = fullyQualifiedName.Length > 0 && fullyQualifiedName[0] == '<';
		byte* ptr = (byte*)((void*)Marshal.GetHINSTANCE(module));
		byte* ptr2 = ptr + *(uint*)(ptr + 60);
		ushort num = *(ushort*)(ptr2 + 6);
		ushort num2 = *(ushort*)(ptr2 + 20);
		bool flag2 = false;
		uint* ptr3 = null;
		uint num3 = 0U;
		uint* ptr4 = (uint*)(ptr2 + 24 + num2);
		uint num4 = 3900707303U;
		uint num5 = 1329366568U;
		uint num6 = 245012877U;
		uint num7 = 712285120U;
		<Module>.CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref flag2);
		if (flag2)
		{
			Environment.Exit(0);
		}
		for (int i = 0; i < (int)num; i++)
		{
			uint num8 = *(ptr4++) * *(ptr4++);
			if (num8 == 2072217438U)
			{
				ptr3 = (uint*)(ptr + (UIntPtr)(flag ? ptr4[3] : ptr4[1]) / 4);
				<Module>.CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref flag2);
				if (flag2)
				{
					Environment.Exit(0);
				}
				num3 = (flag ? ptr4[2] : (*ptr4)) >> 2;
			}
			else if (num8 > 0U)
			{
				uint* ptr5 = (uint*)(ptr + (UIntPtr)(flag ? ptr4[3] : ptr4[1]) / 4);
				uint num9 = ptr4[2] >> 2;
				for (uint num10 = 0U; num10 < num9; num10 += 1U)
				{
					uint num11 = (num4 ^ *(ptr5++)) + num5 + num6 * num7;
					num4 = num5;
					num5 = num7;
					num7 = num11;
				}
			}
			ptr4 += 8;
		}
		uint[] array = new uint[16];
		uint[] array2 = new uint[16];
		for (int j = 0; j < 16; j++)
		{
			array[j] = num7;
			array2[j] = num5;
			num4 = (num5 >> 5 | num5 << 27);
			num5 = (num6 >> 3 | num6 << 29);
			<Module>.CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref flag2);
			if (flag2)
			{
				Environment.Exit(0);
			}
			num6 = (num7 >> 7 | num7 << 25);
			num7 = (num4 >> 11 | num4 << 21);
		}
		array[0] = (array[0] ^ array2[0]);
		array[1] = array[1] * array2[1];
		array[2] = array[2] + array2[2];
		array[3] = (array[3] ^ array2[3]);
		array[4] = array[4] * array2[4];
		array[5] = array[5] + array2[5];
		array[6] = (array[6] ^ array2[6]);
		array[7] = array[7] * array2[7];
		array[8] = array[8] + array2[8];
		array[9] = (array[9] ^ array2[9]);
		array[10] = array[10] * array2[10];
		array[11] = array[11] + array2[11];
		array[12] = (array[12] ^ array2[12]);
		array[13] = array[13] * array2[13];
		array[14] = array[14] + array2[14];
		array[15] = (array[15] ^ array2[15]);
		uint num12 = 64U;
		<Module>.VirtualProtect_1((IntPtr)((void*)ptr3), num3 << 2, 64U, ref num12);
		if (num12 != 64U)
		{
			uint num13 = 0U;
			for (uint num14 = 0U; num14 < num3; num14 += 1U)
			{
				*ptr3 ^= array[(int)(num13 & 15U)];
				array[(int)(num13 & 15U)] = (array[(int)(num13 & 15U)] ^ *(ptr3++)) + 1035675673U;
				<Module>.CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref flag2);
				if (flag2)
				{
					Environment.Exit(0);
				}
				num13 += 1U;
			}
		}
	}

	// Token: 0x04000001 RID: 1
	internal static byte[] byte_0;

	// Token: 0x04000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
	internal static <Module>.Struct4 struct4_0;

	// Token: 0x02000002 RID: 2
	internal struct Struct0
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00002EDE File Offset: 0x000010DE
		internal void method_0()
		{
			this.uint_0 = 1024U;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000550C File Offset: 0x0000370C
		internal uint method_1(<Module>.Class0 class0_0)
		{
			uint num = (class0_0.uint_1 >> 11) * this.uint_0;
			uint result;
			if (class0_0.uint_0 < num)
			{
				class0_0.uint_1 = num;
				this.uint_0 += 2048U - this.uint_0 >> 5;
				if (class0_0.uint_1 < 16777216U)
				{
					class0_0.uint_0 = (class0_0.uint_0 << 8 | (uint)((byte)class0_0.stream_0.ReadByte()));
					class0_0.uint_1 <<= 8;
				}
				result = 0U;
			}
			else
			{
				class0_0.uint_1 -= num;
				class0_0.uint_0 -= num;
				this.uint_0 -= this.uint_0 >> 5;
				if (class0_0.uint_1 < 16777216U)
				{
					class0_0.uint_0 = (class0_0.uint_0 << 8 | (uint)((byte)class0_0.stream_0.ReadByte()));
					class0_0.uint_1 <<= 8;
				}
				result = 1U;
			}
			return result;
		}

		// Token: 0x04000003 RID: 3
		internal uint uint_0;
	}

	// Token: 0x02000003 RID: 3
	internal struct Struct1
	{
		// Token: 0x06000015 RID: 21 RVA: 0x00002EEB File Offset: 0x000010EB
		internal Struct1(int int_1)
		{
			this.int_0 = int_1;
			this.struct0_0 = new <Module>.Struct0[1 << int_1];
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00005600 File Offset: 0x00003800
		internal void method_0()
		{
			uint num = 1U;
			while ((ulong)num < (ulong)(1L << (this.int_0 & 31)))
			{
				this.struct0_0[(int)num].method_0();
				num += 1U;
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00005638 File Offset: 0x00003838
		internal uint method_1(<Module>.Class0 class0_0)
		{
			uint num = 1U;
			for (int i = this.int_0; i > 0; i--)
			{
				num = (num << 1) + this.struct0_0[(int)num].method_1(class0_0);
			}
			return num - (1U << this.int_0);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00005680 File Offset: 0x00003880
		internal uint method_2(<Module>.Class0 class0_0)
		{
			uint num = 1U;
			uint num2 = 0U;
			for (int i = 0; i < this.int_0; i++)
			{
				uint num3 = this.struct0_0[(int)num].method_1(class0_0);
				num <<= 1;
				num += num3;
				num2 |= num3 << i;
			}
			return num2;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000056D0 File Offset: 0x000038D0
		internal static uint smethod_0(<Module>.Struct0[] struct0_1, uint uint_0, <Module>.Class0 class0_0, int int_1)
		{
			uint num = 1U;
			uint num2 = 0U;
			for (int i = 0; i < int_1; i++)
			{
				uint num3 = struct0_1[(int)(uint_0 + num)].method_1(class0_0);
				num <<= 1;
				num += num3;
				num2 |= num3 << i;
			}
			return num2;
		}

		// Token: 0x04000004 RID: 4
		internal readonly <Module>.Struct0[] struct0_0;

		// Token: 0x04000005 RID: 5
		internal readonly int int_0;
	}

	// Token: 0x02000004 RID: 4
	internal class Class0
	{
		// Token: 0x0600001A RID: 26 RVA: 0x00005718 File Offset: 0x00003918
		internal void method_0(Stream stream_1)
		{
			this.stream_0 = stream_1;
			this.uint_0 = 0U;
			this.uint_1 = uint.MaxValue;
			for (int i = 0; i < 5; i++)
			{
				this.uint_0 = (this.uint_0 << 8 | (uint)((byte)this.stream_0.ReadByte()));
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002F05 File Offset: 0x00001105
		internal void method_1()
		{
			this.stream_0 = null;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002F0E File Offset: 0x0000110E
		internal void method_2()
		{
			while (this.uint_1 < 16777216U)
			{
				this.uint_0 = (this.uint_0 << 8 | (uint)((byte)this.stream_0.ReadByte()));
				this.uint_1 <<= 8;
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00005764 File Offset: 0x00003964
		internal uint method_3(int int_0)
		{
			uint num = this.uint_1;
			uint num2 = this.uint_0;
			uint num3 = 0U;
			for (int i = int_0; i > 0; i--)
			{
				num >>= 1;
				uint num4 = num2 - num >> 31;
				num2 -= (num & num4 - 1U);
				num3 = (num3 << 1 | 1U - num4);
				if (num < 16777216U)
				{
					num2 = (num2 << 8 | (uint)((byte)this.stream_0.ReadByte()));
					num <<= 8;
				}
			}
			this.uint_1 = num;
			this.uint_0 = num2;
			return num3;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002F4B File Offset: 0x0000114B
		internal Class0()
		{
		}

		// Token: 0x04000006 RID: 6
		internal uint uint_0;

		// Token: 0x04000007 RID: 7
		internal uint uint_1;

		// Token: 0x04000008 RID: 8
		internal Stream stream_0;
	}

	// Token: 0x02000005 RID: 5
	internal class Class1
	{
		// Token: 0x0600001F RID: 31 RVA: 0x000057E0 File Offset: 0x000039E0
		internal Class1()
		{
			this.uint_0 = uint.MaxValue;
			int num = 0;
			while ((long)num < 4L)
			{
				this.struct1_0[num] = new <Module>.Struct1(6);
				num++;
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000058DC File Offset: 0x00003ADC
		internal void method_0(uint uint_3)
		{
			if (this.uint_0 != uint_3)
			{
				this.uint_0 = uint_3;
				this.uint_1 = Math.Max(this.uint_0, 1U);
				uint uint_4 = Math.Max(this.uint_1, 4096U);
				this.class4_0.method_0(uint_4);
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002F53 File Offset: 0x00001153
		internal void method_1(int int_0, int int_1)
		{
			this.class3_0.method_0(int_0, int_1);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00005930 File Offset: 0x00003B30
		internal void method_2(int int_0)
		{
			uint num = 1U << int_0;
			this.class2_0.method_0(num);
			this.class2_1.method_0(num);
			this.uint_2 = num - 1U;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00005968 File Offset: 0x00003B68
		internal void method_3(Stream stream_0, Stream stream_1)
		{
			this.class0_0.method_0(stream_0);
			this.class4_0.method_1(stream_1, this.bool_0);
			for (uint num = 0U; num < 12U; num += 1U)
			{
				for (uint num2 = 0U; num2 <= this.uint_2; num2 += 1U)
				{
					uint num3 = (num << 4) + num2;
					this.struct0_0[(int)num3].method_0();
					this.struct0_1[(int)num3].method_0();
				}
				this.struct0_2[(int)num].method_0();
				this.struct0_3[(int)num].method_0();
				this.struct0_4[(int)num].method_0();
				this.struct0_5[(int)num].method_0();
			}
			this.class3_0.method_1();
			for (uint num = 0U; num < 4U; num += 1U)
			{
				this.struct1_0[(int)num].method_0();
			}
			for (uint num = 0U; num < 114U; num += 1U)
			{
				this.struct0_6[(int)num].method_0();
			}
			this.class2_0.method_1();
			this.class2_1.method_1();
			this.struct1_1.method_0();
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00005A98 File Offset: 0x00003C98
		internal void method_4(Stream stream_0, Stream stream_1, long long_0, long long_1)
		{
			this.method_3(stream_0, stream_1);
			<Module>.Struct3 @struct = default(<Module>.Struct3);
			@struct.method_0();
			uint num = 0U;
			uint num2 = 0U;
			uint num3 = 0U;
			uint num4 = 0U;
			ulong num5 = 0UL;
			if (0L < long_1)
			{
				this.struct0_0[(int)((int)@struct.uint_0 << 4)].method_1(this.class0_0);
				@struct.method_1();
				byte byte_ = this.class3_0.method_3(this.class0_0, 0U, 0);
				this.class4_0.method_5(byte_);
				num5 += 1UL;
			}
			while (num5 < (ulong)long_1)
			{
				uint num6 = (uint)num5 & this.uint_2;
				if (this.struct0_0[(int)((@struct.uint_0 << 4) + num6)].method_1(this.class0_0) == 0U)
				{
					byte byte_2 = this.class4_0.method_6(0U);
					byte byte_3;
					if (!@struct.method_5())
					{
						byte_3 = this.class3_0.method_4(this.class0_0, (uint)num5, byte_2, this.class4_0.method_6(num));
					}
					else
					{
						byte_3 = this.class3_0.method_3(this.class0_0, (uint)num5, byte_2);
					}
					this.class4_0.method_5(byte_3);
					@struct.method_1();
					num5 += 1UL;
				}
				else
				{
					uint num8;
					if (this.struct0_2[(int)@struct.uint_0].method_1(this.class0_0) == 1U)
					{
						if (this.struct0_3[(int)@struct.uint_0].method_1(this.class0_0) == 0U)
						{
							if (this.struct0_1[(int)((@struct.uint_0 << 4) + num6)].method_1(this.class0_0) == 0U)
							{
								@struct.method_4();
								this.class4_0.method_5(this.class4_0.method_6(num));
								num5 += 1UL;
								continue;
							}
						}
						else
						{
							uint num7;
							if (this.struct0_4[(int)@struct.uint_0].method_1(this.class0_0) == 0U)
							{
								num7 = num2;
							}
							else
							{
								if (this.struct0_5[(int)@struct.uint_0].method_1(this.class0_0) == 0U)
								{
									num7 = num3;
								}
								else
								{
									num7 = num4;
									num4 = num3;
								}
								num3 = num2;
							}
							num2 = num;
							num = num7;
						}
						num8 = this.class2_1.method_2(this.class0_0, num6) + 2U;
						@struct.method_3();
					}
					else
					{
						num4 = num3;
						num3 = num2;
						num2 = num;
						num8 = 2U + this.class2_0.method_2(this.class0_0, num6);
						@struct.method_2();
						uint num9 = this.struct1_0[(int)<Module>.Class1.smethod_0(num8)].method_1(this.class0_0);
						if (num9 >= 4U)
						{
							int num10 = (int)((num9 >> 1) - 1U);
							num = (2U | (num9 & 1U)) << num10;
							if (num9 < 14U)
							{
								num += <Module>.Struct1.smethod_0(this.struct0_6, num - num9 - 1U, this.class0_0, num10);
							}
							else
							{
								num += this.class0_0.method_3(num10 - 4) << 4;
								num += this.struct1_1.method_2(this.class0_0);
							}
						}
						else
						{
							num = num9;
						}
					}
					if (((ulong)num >= num5 || num >= this.uint_1) && num == 4294967295U)
					{
						break;
					}
					this.class4_0.method_4(num, num8);
					num5 += (ulong)num8;
				}
			}
			this.class4_0.method_3();
			this.class4_0.method_2();
			this.class0_0.method_1();
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00005E20 File Offset: 0x00004020
		internal void method_5(byte[] byte_0)
		{
			int int_ = (int)(byte_0[0] % 9);
			int num = (int)(byte_0[0] / 9);
			int int_2 = num % 5;
			int int_3 = num / 5;
			uint num2 = 0U;
			for (int i = 0; i < 4; i++)
			{
				num2 += (uint)((uint)byte_0[1 + i] << i * 8);
			}
			this.method_0(num2);
			this.method_1(int_2, int_);
			this.method_2(int_3);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00005E84 File Offset: 0x00004084
		internal static uint smethod_0(uint uint_3)
		{
			uint_3 -= 2U;
			uint result;
			if (uint_3 < 4U)
			{
				result = uint_3;
			}
			else
			{
				result = 3U;
			}
			return result;
		}

		// Token: 0x04000009 RID: 9
		internal readonly <Module>.Struct0[] struct0_0 = new <Module>.Struct0[192];

		// Token: 0x0400000A RID: 10
		internal readonly <Module>.Struct0[] struct0_1 = new <Module>.Struct0[192];

		// Token: 0x0400000B RID: 11
		internal readonly <Module>.Struct0[] struct0_2 = new <Module>.Struct0[12];

		// Token: 0x0400000C RID: 12
		internal readonly <Module>.Struct0[] struct0_3 = new <Module>.Struct0[12];

		// Token: 0x0400000D RID: 13
		internal readonly <Module>.Struct0[] struct0_4 = new <Module>.Struct0[12];

		// Token: 0x0400000E RID: 14
		internal readonly <Module>.Struct0[] struct0_5 = new <Module>.Struct0[12];

		// Token: 0x0400000F RID: 15
		internal readonly <Module>.Class1.Class2 class2_0 = new <Module>.Class1.Class2();

		// Token: 0x04000010 RID: 16
		internal readonly <Module>.Class1.Class3 class3_0 = new <Module>.Class1.Class3();

		// Token: 0x04000011 RID: 17
		internal readonly <Module>.Class4 class4_0 = new <Module>.Class4();

		// Token: 0x04000012 RID: 18
		internal readonly <Module>.Struct0[] struct0_6 = new <Module>.Struct0[114];

		// Token: 0x04000013 RID: 19
		internal readonly <Module>.Struct1[] struct1_0 = new <Module>.Struct1[4];

		// Token: 0x04000014 RID: 20
		internal readonly <Module>.Class0 class0_0 = new <Module>.Class0();

		// Token: 0x04000015 RID: 21
		internal readonly <Module>.Class1.Class2 class2_1 = new <Module>.Class1.Class2();

		// Token: 0x04000016 RID: 22
		internal bool bool_0 = false;

		// Token: 0x04000017 RID: 23
		internal uint uint_0;

		// Token: 0x04000018 RID: 24
		internal uint uint_1;

		// Token: 0x04000019 RID: 25
		internal <Module>.Struct1 struct1_1 = new <Module>.Struct1(4);

		// Token: 0x0400001A RID: 26
		internal uint uint_2;

		// Token: 0x02000006 RID: 6
		internal class Class2
		{
			// Token: 0x06000027 RID: 39 RVA: 0x00005EA4 File Offset: 0x000040A4
			internal void method_0(uint uint_1)
			{
				for (uint num = this.uint_0; num < uint_1; num += 1U)
				{
					this.struct1_0[(int)num] = new <Module>.Struct1(3);
					this.struct1_1[(int)num] = new <Module>.Struct1(3);
				}
				this.uint_0 = uint_1;
			}

			// Token: 0x06000028 RID: 40 RVA: 0x00005EF0 File Offset: 0x000040F0
			internal void method_1()
			{
				this.struct0_0.method_0();
				for (uint num = 0U; num < this.uint_0; num += 1U)
				{
					this.struct1_0[(int)num].method_0();
					this.struct1_1[(int)num].method_0();
				}
				this.struct0_1.method_0();
				this.struct1_2.method_0();
			}

			// Token: 0x06000029 RID: 41 RVA: 0x00005F54 File Offset: 0x00004154
			internal uint method_2(<Module>.Class0 class0_0, uint uint_1)
			{
				uint result;
				if (this.struct0_0.method_1(class0_0) == 0U)
				{
					result = this.struct1_0[(int)uint_1].method_1(class0_0);
				}
				else
				{
					uint num = 8U;
					if (this.struct0_1.method_1(class0_0) == 0U)
					{
						num += this.struct1_1[(int)uint_1].method_1(class0_0);
					}
					else
					{
						num += 8U;
						num += this.struct1_2.method_1(class0_0);
					}
					result = num;
				}
				return result;
			}

			// Token: 0x0600002A RID: 42 RVA: 0x00005FC8 File Offset: 0x000041C8
			internal Class2()
			{
			}

			// Token: 0x0400001B RID: 27
			internal readonly <Module>.Struct1[] struct1_0 = new <Module>.Struct1[16];

			// Token: 0x0400001C RID: 28
			internal readonly <Module>.Struct1[] struct1_1 = new <Module>.Struct1[16];

			// Token: 0x0400001D RID: 29
			internal <Module>.Struct0 struct0_0 = default(<Module>.Struct0);

			// Token: 0x0400001E RID: 30
			internal <Module>.Struct0 struct0_1 = default(<Module>.Struct0);

			// Token: 0x0400001F RID: 31
			internal <Module>.Struct1 struct1_2 = new <Module>.Struct1(8);

			// Token: 0x04000020 RID: 32
			internal uint uint_0;
		}

		// Token: 0x02000007 RID: 7
		internal class Class3
		{
			// Token: 0x0600002B RID: 43 RVA: 0x0000601C File Offset: 0x0000421C
			internal void method_0(int int_2, int int_3)
			{
				if (this.struct2_0 == null || this.int_1 != int_3 || this.int_0 != int_2)
				{
					this.int_0 = int_2;
					this.uint_0 = (1U << int_2) - 1U;
					this.int_1 = int_3;
					uint num = 1U << this.int_1 + this.int_0;
					this.struct2_0 = new <Module>.Class1.Class3.Struct2[num];
					for (uint num2 = 0U; num2 < num; num2 += 1U)
					{
						this.struct2_0[(int)num2].method_0();
					}
				}
			}

			// Token: 0x0600002C RID: 44 RVA: 0x000060A0 File Offset: 0x000042A0
			internal void method_1()
			{
				uint num = 1U << this.int_1 + this.int_0;
				for (uint num2 = 0U; num2 < num; num2 += 1U)
				{
					this.struct2_0[(int)num2].method_1();
				}
			}

			// Token: 0x0600002D RID: 45 RVA: 0x000060E0 File Offset: 0x000042E0
			internal uint method_2(uint uint_1, byte byte_0)
			{
				return ((uint_1 & this.uint_0) << this.int_1) + (uint)(byte_0 >> 8 - this.int_1);
			}

			// Token: 0x0600002E RID: 46 RVA: 0x00006110 File Offset: 0x00004310
			internal byte method_3(<Module>.Class0 class0_0, uint uint_1, byte byte_0)
			{
				return this.struct2_0[(int)this.method_2(uint_1, byte_0)].method_2(class0_0);
			}

			// Token: 0x0600002F RID: 47 RVA: 0x00006138 File Offset: 0x00004338
			internal byte method_4(<Module>.Class0 class0_0, uint uint_1, byte byte_0, byte byte_1)
			{
				return this.struct2_0[(int)this.method_2(uint_1, byte_0)].method_3(class0_0, byte_1);
			}

			// Token: 0x06000030 RID: 48 RVA: 0x00002F4B File Offset: 0x0000114B
			internal Class3()
			{
			}

			// Token: 0x04000021 RID: 33
			internal <Module>.Class1.Class3.Struct2[] struct2_0;

			// Token: 0x04000022 RID: 34
			internal int int_0;

			// Token: 0x04000023 RID: 35
			internal int int_1;

			// Token: 0x04000024 RID: 36
			internal uint uint_0;

			// Token: 0x02000008 RID: 8
			internal struct Struct2
			{
				// Token: 0x06000031 RID: 49 RVA: 0x00002F62 File Offset: 0x00001162
				internal void method_0()
				{
					this.struct0_0 = new <Module>.Struct0[768];
				}

				// Token: 0x06000032 RID: 50 RVA: 0x00006164 File Offset: 0x00004364
				internal void method_1()
				{
					for (int i = 0; i < 768; i++)
					{
						this.struct0_0[i].method_0();
					}
				}

				// Token: 0x06000033 RID: 51 RVA: 0x00006194 File Offset: 0x00004394
				internal byte method_2(<Module>.Class0 class0_0)
				{
					uint num = 1U;
					do
					{
						num = (num << 1 | this.struct0_0[(int)num].method_1(class0_0));
					}
					while (num < 256U);
					return (byte)num;
				}

				// Token: 0x06000034 RID: 52 RVA: 0x000061C8 File Offset: 0x000043C8
				internal byte method_3(<Module>.Class0 class0_0, byte byte_0)
				{
					uint num = 1U;
					for (;;)
					{
						uint num2 = (uint)(byte_0 >> 7 & 1);
						byte_0 = (byte)(byte_0 << 1);
						uint num3 = this.struct0_0[(int)((1U + num2 << 8) + num)].method_1(class0_0);
						num = (num << 1 | num3);
						if (num2 != num3)
						{
							break;
						}
						if (num >= 256U)
						{
							goto IL_65;
						}
					}
					while (num < 256U)
					{
						num = (num << 1 | this.struct0_0[(int)num].method_1(class0_0));
					}
					IL_65:
					return (byte)num;
				}

				// Token: 0x04000025 RID: 37
				internal <Module>.Struct0[] struct0_0;
			}
		}
	}

	// Token: 0x02000009 RID: 9
	internal class Class4
	{
		// Token: 0x06000035 RID: 53 RVA: 0x00002F74 File Offset: 0x00001174
		internal void method_0(uint uint_3)
		{
			if (this.uint_2 != uint_3)
			{
				this.byte_0 = new byte[uint_3];
			}
			this.uint_2 = uint_3;
			this.uint_0 = 0U;
			this.uint_1 = 0U;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002FA5 File Offset: 0x000011A5
		internal void method_1(Stream stream_1, bool bool_0)
		{
			this.method_2();
			this.stream_0 = stream_1;
			if (!bool_0)
			{
				this.uint_1 = 0U;
				this.uint_0 = 0U;
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002FC8 File Offset: 0x000011C8
		internal void method_2()
		{
			this.method_3();
			this.stream_0 = null;
			Buffer.BlockCopy(new byte[this.byte_0.Length], 0, this.byte_0, 0, this.byte_0.Length);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00006240 File Offset: 0x00004440
		internal void method_3()
		{
			uint num = this.uint_0 - this.uint_1;
			if (num != 0U)
			{
				this.stream_0.Write(this.byte_0, (int)this.uint_1, (int)num);
				if (this.uint_0 >= this.uint_2)
				{
					this.uint_0 = 0U;
				}
				this.uint_1 = this.uint_0;
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000062A0 File Offset: 0x000044A0
		internal void method_4(uint uint_3, uint uint_4)
		{
			uint num = this.uint_0 - uint_3 - 1U;
			if (num >= this.uint_2)
			{
				num += this.uint_2;
			}
			while (uint_4 > 0U)
			{
				if (num >= this.uint_2)
				{
					num = 0U;
				}
				byte[] array = this.byte_0;
				uint num2 = this.uint_0;
				this.uint_0 = num2 + 1U;
				array[(int)num2] = this.byte_0[(int)num++];
				if (this.uint_0 >= this.uint_2)
				{
					this.method_3();
				}
				uint_4 -= 1U;
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x0000632C File Offset: 0x0000452C
		internal void method_5(byte byte_1)
		{
			byte[] array = this.byte_0;
			uint num = this.uint_0;
			this.uint_0 = num + 1U;
			array[(int)num] = byte_1;
			if (this.uint_0 >= this.uint_2)
			{
				this.method_3();
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000636C File Offset: 0x0000456C
		internal byte method_6(uint uint_3)
		{
			uint num = this.uint_0 - uint_3 - 1U;
			if (num >= this.uint_2)
			{
				num += this.uint_2;
			}
			return this.byte_0[(int)num];
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002F4B File Offset: 0x0000114B
		internal Class4()
		{
		}

		// Token: 0x04000026 RID: 38
		internal byte[] byte_0;

		// Token: 0x04000027 RID: 39
		internal uint uint_0;

		// Token: 0x04000028 RID: 40
		internal Stream stream_0;

		// Token: 0x04000029 RID: 41
		internal uint uint_1;

		// Token: 0x0400002A RID: 42
		internal uint uint_2;
	}

	// Token: 0x0200000A RID: 10
	internal struct Struct3
	{
		// Token: 0x0600003D RID: 61 RVA: 0x00002FF9 File Offset: 0x000011F9
		internal void method_0()
		{
			this.uint_0 = 0U;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003002 File Offset: 0x00001202
		internal void method_1()
		{
			if (this.uint_0 < 4U)
			{
				this.uint_0 = 0U;
			}
			else if (this.uint_0 < 10U)
			{
				this.uint_0 -= 3U;
			}
			else
			{
				this.uint_0 -= 6U;
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003042 File Offset: 0x00001242
		internal void method_2()
		{
			this.uint_0 = ((this.uint_0 < 7U) ? 7U : 10U);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003058 File Offset: 0x00001258
		internal void method_3()
		{
			this.uint_0 = ((this.uint_0 < 7U) ? 8U : 11U);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000306E File Offset: 0x0000126E
		internal void method_4()
		{
			this.uint_0 = ((this.uint_0 < 7U) ? 9U : 11U);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003085 File Offset: 0x00001285
		internal bool method_5()
		{
			return this.uint_0 < 7U;
		}

		// Token: 0x0400002B RID: 43
		internal uint uint_0;
	}

	// Token: 0x0200000B RID: 11
	[StructLayout(LayoutKind.Explicit, Size = 3712)]
	internal struct Struct4
	{
	}
}
