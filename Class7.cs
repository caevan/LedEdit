// Decompiled with JetBrains decompiler
// Type: Class7
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

internal class Class7
{
  [DllImport("user32.dll", SetLastError = true)]
  public static extern bool RegisterHotKey(
    IntPtr intptr_0,
    int int_0,
    Class7.Enum0 enum0_0,
    Keys keys_0);

  [DllImport("user32.dll", SetLastError = true)]
  public static extern bool UnregisterHotKey(IntPtr intptr_0, int int_0);

  [Flags]
  public enum Enum0
  {
    flag_0 = 0,
    flag_1 = 1,
    flag_2 = 2,
    flag_3 = 4,
    flag_4 = 8,
  }
}
