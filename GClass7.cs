// Decompiled with JetBrains decompiler
// Type: GClass7
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using System.Drawing;
using System.Runtime.CompilerServices;

public class GClass7
{
  private PointF pointF_0;
  private PointF pointF_1;

  [SpecialName]
  public PointF method_0() => this.pointF_0;

  [SpecialName]
  public void method_1(PointF pointF_2) => this.pointF_0 = pointF_2;

  [SpecialName]
  public PointF method_2() => this.pointF_1;

  [SpecialName]
  public void method_3(PointF pointF_2) => this.pointF_1 = pointF_2;

  public GClass7(PointF pointF_2, PointF pointF_3)
  {
    this.pointF_0 = pointF_2;
    this.pointF_1 = pointF_3;
  }
}
