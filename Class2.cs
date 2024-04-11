// Decompiled with JetBrains decompiler
// Type: Class2
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal class Class2
{
  private long long_0;
  private long long_1;
  private long long_2;

  [DllImport("Kernel32.dll")]
  private static extern bool QueryPerformanceCounter(out long long_3);

  [DllImport("Kernel32.dll")]
  private static extern bool QueryPerformanceFrequency(out long long_3);

  public Class2()
  {
    this.long_0 = 0L;
    this.long_1 = 0L;
    if (!Class2.QueryPerformanceFrequency(out this.long_2))
      throw new Win32Exception();
  }

  public void method_0() => Class2.QueryPerformanceCounter(out this.long_0);

  public void method_1() => Class2.QueryPerformanceCounter(out this.long_1);

  [SpecialName]
  public double method_2() => (double) (this.long_1 - this.long_0) / (double) this.long_2;
}
