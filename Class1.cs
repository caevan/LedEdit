// Decompiled with JetBrains decompiler
// Type: Class1
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using System;
using System.Collections;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

internal class Class1
{
  public static string string_0;

  static Class1() => Class1.old_acctor_mc();

  public string method_0(string string_1, string string_2)
  {
    int int_0 = 5;
    DESCryptoServiceProvider cryptoServiceProvider = new DESCryptoServiceProvider();
    byte[] bytes = Encoding.Default.GetBytes(string_1);
    cryptoServiceProvider.Key = Encoding.ASCII.GetBytes(string_2);
    cryptoServiceProvider.IV = Encoding.ASCII.GetBytes(string_2);
    MemoryStream memoryStream = new MemoryStream();
    CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, cryptoServiceProvider.CreateEncryptor(), CryptoStreamMode.Write);
    cryptoStream.Write(bytes, 0, bytes.Length);
    cryptoStream.FlushFinalBlock();
    StringBuilder stringBuilder = new StringBuilder();
    foreach (byte num in memoryStream.ToArray())
      stringBuilder.AppendFormat(Module.a("킪鶬閮\uE9B0膲좴", int_0), (object) num);
    stringBuilder.ToString();
    return stringBuilder.ToString();
  }

  public string method_1(string string_1, string string_2)
  {
    DESCryptoServiceProvider cryptoServiceProvider = new DESCryptoServiceProvider();
    byte[] buffer = new byte[string_1.Length / 2];
    for (int index = 0; index < string_1.Length / 2; ++index)
    {
      int int32 = Convert.ToInt32(string_1.Substring(index * 2, 2), 16);
      buffer[index] = (byte) int32;
    }
    cryptoServiceProvider.Key = Encoding.ASCII.GetBytes(string_2);
    cryptoServiceProvider.IV = Encoding.ASCII.GetBytes(string_2);
    MemoryStream memoryStream = new MemoryStream();
    CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, cryptoServiceProvider.CreateDecryptor(), CryptoStreamMode.Write);
    cryptoStream.Write(buffer, 0, buffer.Length);
    cryptoStream.FlushFinalBlock();
    StringBuilder stringBuilder = new StringBuilder();
    return Encoding.Default.GetString(memoryStream.ToArray());
  }

  public bool method_2(string string_1, string string_2, string string_3)
  {
    SmtpClient smtpClient = new SmtpClient();
    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
    smtpClient.Host = Module.a("잳\uDBB5첷쪹銻\uD8BD꾿뫁꧃\uA7C5ꇇꛉ\uE2CB귍뿏뿑", 14);
    smtpClient.Credentials = (ICredentialsByHost) new NetworkCredential(Module.a("첳\uDFB5횷\uD8B9펻\uDABDꦿꏁ\uAAC3볅ꇇ", 14), Module.a("킳쾵쪷\uD9B9횻쾽겿ꗁ\uA7C3곅", 14));
    MailMessage message = new MailMessage(Module.a("첳\uDFB5횷\uD8B9펻\uDABDꦿꏁ\uAAC3볅ꇇ諉\uAACBꇍ꣏뿑뗓뿕듗\uF4D9뿛뇝跟", 14), string_1);
    message.Subject = string_2;
    message.Body = string_3;
    message.BodyEncoding = Encoding.UTF8;
    message.IsBodyHtml = true;
    message.Priority = MailPriority.High;
    object userToken = (object) message;
    try
    {
      smtpClient.SendAsync(message, userToken);
      return true;
    }
    catch
    {
      return false;
    }
  }

  public string method_3()
  {
    int int_0 = 5;
    try
    {
      string str = "";
      foreach (ManagementBaseObject instance in new ManagementClass(Module.a("ﲪ쒬솮芰膲\uEAB4\uF4B6횸횺춼쪾뗀ꛂ럄铆냈룊만\uAACE볐", int_0)).GetInstances())
        str = instance[Module.a("ﺪ\uDEAC쪮쎰ﶲ풴\uDAB6\uDCB8", int_0)].ToString();
      return str;
    }
    catch
    {
      return Module.a("\uDEAA쎬쒮\uDFB0\uDCB2슴", int_0);
    }
  }

  public string method_4()
  {
    int int_0 = 0;
    ManagementObjectCollection instances = new ManagementClass(Module.a("\uF1A5솧쒩龫鲭\uEFAFﲱ톳습쾷햹캻햽膿ꛁꗃ뛅볇꿉뻋跍뿏병닓뿕뿗꿙껛뿝铟诡诣裥", 0)).GetInstances();
    string str1 = "";
    foreach (ManagementObject managementObject in instances)
    {
      if ((bool) managementObject[Module.a("\uEFA5\uF8A7\uEFA9슫쾭튯\uDEB1톳튵", int_0)])
        str1 = managementObject[Module.a("\uEBA5즧즩\uEDAB쪭풯삱톳억쮷", int_0)].ToString();
    }
    string str2 = "";
    string str3 = str1;
    char[] chArray = new char[1]{ ':' };
    foreach (string str4 in str3.Split(chArray))
      str2 += str4;
    return str2.Substring(4, 8);
  }

  public string method_5()
  {
    int int_0 = 1;
    string str1;
    try
    {
      str1 = GClass3.smethod_0((byte) 0).string_2;
    }
    catch
    {
      str1 = Module.a("\uEFA6令\uF8AA麬鮮\uE9B0課螴\uE0B6", int_0);
    }
    if (str1.Length < 3)
      str1 = Module.a("\uEFA6令\uF8AA麬鮮\uE9B0課螴\uE0B6", int_0);
    char[] charArray = str1.ToCharArray();
    Hashtable hashtable = new Hashtable();
    hashtable.Add((object) 'A', (object) '1');
    hashtable.Add((object) 'B', (object) '4');
    hashtable.Add((object) 'C', (object) '3');
    hashtable.Add((object) 'D', (object) '9');
    hashtable.Add((object) 'E', (object) '5');
    hashtable.Add((object) 'F', (object) '1');
    hashtable.Add((object) 'G', (object) '8');
    hashtable.Add((object) 'H', (object) '1');
    hashtable.Add((object) 'I', (object) '5');
    hashtable.Add((object) 'J', (object) '2');
    hashtable.Add((object) 'K', (object) '4');
    hashtable.Add((object) 'L', (object) '9');
    hashtable.Add((object) 'M', (object) '4');
    hashtable.Add((object) 'N', (object) '2');
    hashtable.Add((object) 'O', (object) '8');
    hashtable.Add((object) 'P', (object) '5');
    hashtable.Add((object) 'Q', (object) '1');
    hashtable.Add((object) 'R', (object) '3');
    hashtable.Add((object) 'S', (object) '6');
    hashtable.Add((object) 'T', (object) '9');
    hashtable.Add((object) 'U', (object) '3');
    hashtable.Add((object) 'V', (object) '8');
    hashtable.Add((object) 'W', (object) '1');
    hashtable.Add((object) 'X', (object) '7');
    hashtable.Add((object) 'Y', (object) '4');
    hashtable.Add((object) 'Z', (object) '2');
    hashtable.Add((object) 'a', (object) '1');
    hashtable.Add((object) 'b', (object) '4');
    hashtable.Add((object) 'c', (object) '3');
    hashtable.Add((object) 'd', (object) '9');
    hashtable.Add((object) 'e', (object) '5');
    hashtable.Add((object) 'f', (object) '1');
    hashtable.Add((object) 'g', (object) '8');
    hashtable.Add((object) 'h', (object) '1');
    hashtable.Add((object) 'i', (object) '5');
    hashtable.Add((object) 'j', (object) '2');
    hashtable.Add((object) 'k', (object) '4');
    hashtable.Add((object) 'l', (object) '9');
    hashtable.Add((object) 'm', (object) '4');
    hashtable.Add((object) 'n', (object) '2');
    hashtable.Add((object) 'o', (object) '8');
    hashtable.Add((object) 'p', (object) '5');
    hashtable.Add((object) 'q', (object) '1');
    hashtable.Add((object) 'r', (object) '3');
    hashtable.Add((object) 's', (object) '6');
    hashtable.Add((object) 't', (object) '9');
    hashtable.Add((object) 'u', (object) '3');
    hashtable.Add((object) 'v', (object) '8');
    hashtable.Add((object) 'w', (object) '1');
    hashtable.Add((object) 'x', (object) '7');
    hashtable.Add((object) 'y', (object) '4');
    hashtable.Add((object) 'z', (object) '2');
    hashtable.Add((object) '1', (object) '5');
    hashtable.Add((object) '2', (object) '9');
    hashtable.Add((object) '3', (object) '4');
    hashtable.Add((object) '4', (object) '9');
    hashtable.Add((object) '5', (object) '7');
    hashtable.Add((object) '6', (object) '2');
    hashtable.Add((object) '7', (object) '8');
    hashtable.Add((object) '8', (object) '6');
    hashtable.Add((object) '9', (object) '1');
    hashtable.Add((object) '0', (object) '3');
    string str2 = "";
    int num = charArray.Length <= 9 ? charArray.Length : 9;
    for (int index = 0; index < num; ++index)
    {
      char ch;
      try
      {
        ch = (char) hashtable[(object) charArray[index]];
      }
      catch
      {
        ch = '5';
      }
      str2 += (string) (object) ch;
    }
    return str2;
  }

    [SpecialName]
    private static void old_acctor_mc() => Class1.string_0 = "j4s9kmz5"; // Module.a("얮薰삲貴\uDCB6풸솺袼", 9);
}
