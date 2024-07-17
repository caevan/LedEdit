// Decompiled with JetBrains decompiler
// Type: PixelArray
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;

[DefaultMember("Item")]
public class PixelArray
{
  private int portNum;
  private Point[] point_0;
  private Color[] color_0;
  private int pixelIndex;

  [SpecialName]
  public int GetPixelIndex() => this.pixelIndex;

  [SpecialName]
  public void SetPixelIndex(int int_2) => this.pixelIndex = int_2;

  public PixelArray(int portNum, int totalPixels)
  {
    this.portNum = portNum;
    this.point_0 = new Point[totalPixels];
    this.color_0 = new Color[totalPixels];
    this.pixelIndex = 0;
  }

  public void SetColorForPixel(int int_2, Color color_1) => this.color_0[int_2] = color_1;

  public Color GetColorForPixel(int int_2) => this.color_0[int_2];

  [SpecialName]
  public int GetPortNum() => this.portNum;

  [SpecialName]
  public void method_5(int int_2) => this.portNum = int_2;

  [SpecialName]
  public Point GetPointForPixel(int int_2) => this.point_0[int_2];

  [SpecialName]
  public void SetPointForPixel(int int_2, Point point_1) => this.point_0[int_2] = point_1;
}
