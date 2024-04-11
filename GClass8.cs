// Decompiled with JetBrains decompiler
// Type: GClass8
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;

[DefaultMember("Item")]
public class GClass8
{
  private int int_0;
  private Point[] point_0;
  private Color[] color_0;
  private int int_1;

  [SpecialName]
  public int method_0() => this.int_1;

  [SpecialName]
  public void method_1(int int_2) => this.int_1 = int_2;

  public GClass8(int int_2, int int_3)
  {
    this.int_0 = int_2;
    this.point_0 = new Point[int_3];
    this.color_0 = new Color[int_3];
    this.int_1 = 0;
  }

  public void method_2(int int_2, Color color_1) => this.color_0[int_2] = color_1;

  public Color method_3(int int_2) => this.color_0[int_2];

  [SpecialName]
  public int method_4() => this.int_0;

  [SpecialName]
  public void method_5(int int_2) => this.int_0 = int_2;

  [SpecialName]
  public Point method_6(int int_2) => this.point_0[int_2];

  [SpecialName]
  public void method_7(int int_2, Point point_1) => this.point_0[int_2] = point_1;
}
