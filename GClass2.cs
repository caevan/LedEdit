// Decompiled with JetBrains decompiler
// Type: GClass2
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using System.Drawing;
using System.Runtime.CompilerServices;

public class GClass2
{
  private PointF pointF_0;
  private string string_0;

  [SpecialName]
  public string method_0() => this.string_0;

  [SpecialName]
  public void method_1(string string_1) => this.string_0 = string_1;

  [SpecialName]
  public PointF method_2() => this.pointF_0;

  [SpecialName]
  public void method_3(PointF pointF_1) => this.pointF_0 = pointF_1;

  public GClass2(PointF pointF_1, string string_1)
  {
    this.pointF_0 = pointF_1;
    this.string_0 = string_1;
  }
}
