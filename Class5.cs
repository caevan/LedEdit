// Decompiled with JetBrains decompiler
// Type: Class5
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using System;
using System.Runtime.InteropServices;

internal class Class5
{
  internal const int int_0 = 2;
  internal const int int_1 = 8;
  internal const int int_2 = 32;
  internal const string string_0 = "SeShutdownPrivilege";
  internal const int int_3 = 0;
  internal const int int_4 = 1;
  internal const int int_5 = 2;
  internal const int int_6 = 4;
  internal const int int_7 = 8;
  internal const int int_8 = 16;

  [DllImport("kernel32.dll")]
  internal static extern IntPtr GetCurrentProcess();

  [DllImport("advapi32.dll", SetLastError = true)]
  internal static extern bool OpenProcessToken(IntPtr intptr_0, int int_9, ref IntPtr intptr_1);

  [DllImport("advapi32.dll", SetLastError = true)]
  internal static extern bool LookupPrivilegeValue(
    string string_1,
    string string_2,
    ref long long_0);

  [DllImport("advapi32.dll", SetLastError = true)]
  internal static extern bool AdjustTokenPrivileges(
    IntPtr intptr_0,
    bool bool_0,
    ref Class5.Struct4 struct4_0,
    int int_9,
    IntPtr intptr_1,
    IntPtr intptr_2);

  [DllImport("user32.dll", SetLastError = true)]
  internal static extern bool ExitWindowsEx(int int_9, int int_10);

  private static bool smethod_0(int int_9)
  {
    IntPtr currentProcess = Class5.GetCurrentProcess();
    IntPtr zero = IntPtr.Zero;
    Class5.OpenProcessToken(currentProcess, 40, ref zero);
    Class5.Struct4 struct4_0;
    struct4_0.int_0 = 1;
    struct4_0.long_0 = 0L;
    struct4_0.int_1 = 2;
    Class5.LookupPrivilegeValue((string) null, Module.a("ﲮ풰\uE0B2\uDDB4슶춸\uDFBA튼좾꿀鏂럄껆뿈ꋊꇌ\uAACE뛐뛒", 9), ref struct4_0.long_0);
    Class5.AdjustTokenPrivileges(zero, false, ref struct4_0, 0, IntPtr.Zero, IntPtr.Zero);
    return Class5.ExitWindowsEx(int_9, 0);
  }

  public static bool smethod_1() => Class5.smethod_0(6);

  public static bool smethod_2() => Class5.smethod_0(12);

  public static bool smethod_3() => Class5.smethod_0(4);

  [StructLayout(LayoutKind.Sequential, Pack = 1)]
  internal struct Struct4
  {
    public int int_0;
    public long long_0;
    public int int_1;
  }
}
