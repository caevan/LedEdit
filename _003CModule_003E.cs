// Decompiled with JetBrains decompiler
// Type: <Module>
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using log4net;
using AFSApp.Helpers;

internal class Module
{
    internal static readonly ILog Log =
    LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    public static string a(string string_0, int int_0, bool debug = false)
  {
        LogData.LogInfo($"Module a start "+ string_0 + $"- {int_0}");
    char[] charArray = string_0.ToCharArray();
    int num1 = 1812539813 + int_0;
    for (int index1 = 0; index1 < charArray.Length; ++index1)
    {
      int index2 = index1;
      char[] chArray = charArray;
      int index3 = index2;
      int num2 = (int) (short) charArray[index2];
        if(debug)
            {
                LogData.LogInfo($"Decrypter : num2 {num2.ToString("X2")}");
            }
            int num3 = num2 & (int) byte.MaxValue;
      int num4 = num1;
      int num5 = num4 + 1;
      byte num6 = (byte) (num3 ^ num4);
      int num7 = num2 >> 8;
      int num8 = num5;
      num1 = num8 + 1;
      int num9 = (int) (byte) (num7 ^ num8);
      int num10 = (int) (ushort) ((uint) num6 << 8 | (uint) (byte) num9);
      chArray[index3] = (char) num10;
    }
        Log.Info($"{new string(charArray)}");
        Log.Info($"{string.Intern(new string(charArray))}");
        LogData.LogInfo($"{string.Intern(new string(charArray))}");
        return string.Intern(new string(charArray));
  }
}
