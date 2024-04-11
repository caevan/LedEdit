// Decompiled with JetBrains decompiler
// Type: GClass0
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using Microsoft.DirectX.DirectDraw;
using System.Drawing;
using System.Runtime.CompilerServices;

public class GClass0
{
  protected int int_0;
  protected int int_1;
  protected Rectangle rectangle_0 = Rectangle.Empty;
  protected Rectangle rectangle_1 = Rectangle.Empty;
  protected Bitmap bitmap_0;
  protected GEnum0 genum0_0;
  protected Device device_0;
  protected SurfaceDescription surfaceDescription_0;
  protected Surface surface_0;
  protected Point point_0 = new Point(0, 0);
  protected Point point_1 = new Point(0, 0);

  [SpecialName]
  public GEnum0 method_0() => this.genum0_0;

  [SpecialName]
  public int method_1() => this.int_0;

  [SpecialName]
  public int method_2() => this.int_1;

  [SpecialName]
  public Rectangle method_3() => this.rectangle_1;

  [SpecialName]
  public void method_4(Rectangle rectangle_2) => this.rectangle_1 = rectangle_2;

  [SpecialName]
  public Rectangle method_5() => this.rectangle_0;

  [SpecialName]
  public void method_6(Rectangle rectangle_2) => this.rectangle_0 = rectangle_2;

  [SpecialName]
  public Point method_7() => this.point_0;

  [SpecialName]
  public void method_8(Point point_2)
  {
    this.point_0 = point_2;
    this.rectangle_1.X = this.point_0.X;
    this.rectangle_1.Y = this.point_0.Y;
  }

  [SpecialName]
  public Point method_9() => this.point_1;

  [SpecialName]
  public void method_10(Point point_2)
  {
    this.point_1 = point_2;
    this.rectangle_0.X = this.point_1.X;
    this.rectangle_0.Y = this.point_1.Y;
  }

  [SpecialName]
  public Bitmap method_11() => this.bitmap_0;

  [SpecialName]
  public Surface method_12() => this.surface_0;

  public void method_13(GClass0 gclass0_0)
  {
    if (gclass0_0.method_0() == GEnum0.const_1)
      this.surface_0.Draw(gclass0_0.method_3(), gclass0_0.method_12(), gclass0_0.method_5(), DrawFlags.Wait | DrawFlags.KeySource);
    else
      this.surface_0.Draw(gclass0_0.method_3(), gclass0_0.method_12(), gclass0_0.method_5(), DrawFlags.Wait);
  }

  public void method_14(GClass0 gclass0_0)
  {
    if (gclass0_0.method_0() == GEnum0.const_1)
      this.surface_0.Draw(this.rectangle_0, gclass0_0.method_12(), gclass0_0.method_5(), DrawFlags.Wait | DrawFlags.KeySource);
    else
      this.surface_0.Draw(this.rectangle_0, gclass0_0.method_12(), gclass0_0.method_5(), DrawFlags.Wait);
  }

  public GClass0(
    Bitmap bitmap_1,
    GEnum0 genum0_1,
    Device device_1,
    Rectangle rectangle_2,
    Rectangle rectangle_3)
  {
    this.bitmap_0 = bitmap_1;
    this.genum0_0 = genum0_1;
    this.device_0 = device_1;
    this.rectangle_0 = rectangle_2;
    this.rectangle_1 = rectangle_3;
    this.int_0 = this.bitmap_0.Width;
    this.int_1 = this.bitmap_0.Height;
    this.method_16();
  }

  public GClass0(string string_0, GEnum0 genum0_1, Device device_1)
  {
    this.bitmap_0 = new Bitmap(this.GetType().Module.Assembly.GetManifestResourceStream(string_0));
    this.genum0_0 = genum0_1;
    this.device_0 = device_1;
    this.rectangle_0 = new Rectangle(0, 0, this.bitmap_0.Width, this.bitmap_0.Height);
    this.rectangle_1 = this.rectangle_0;
    this.int_0 = this.bitmap_0.Width;
    this.int_1 = this.bitmap_0.Height;
    this.method_16();
  }

  public GClass0(int int_2, string string_0, GEnum0 genum0_1, Device device_1)
  {
    this.bitmap_0 = new Bitmap(string_0);
    this.genum0_0 = genum0_1;
    this.device_0 = device_1;
    this.rectangle_0 = new Rectangle(0, 0, this.bitmap_0.Width, this.bitmap_0.Height);
    this.rectangle_1 = this.rectangle_0;
    this.int_0 = this.bitmap_0.Width;
    this.int_1 = this.bitmap_0.Height;
    this.method_16();
  }

  public GClass0(Device device_1, GEnum0 genum0_1, Rectangle rectangle_2, Rectangle rectangle_3)
  {
    this.device_0 = device_1;
    this.rectangle_0 = rectangle_2;
    this.rectangle_1 = rectangle_3;
    this.genum0_0 = genum0_1;
    this.surfaceDescription_0 = new SurfaceDescription();
    this.surfaceDescription_0.SurfaceCaps.OffScreenPlain = true;
    this.surfaceDescription_0.Width = this.rectangle_0.Width;
    this.surfaceDescription_0.Height = this.rectangle_0.Height;
    this.surfaceDescription_0.SurfaceCaps.SystemMemory = true;
    this.surface_0 = new Surface(this.surfaceDescription_0, this.device_0);
    if (this.genum0_0 != GEnum0.const_1)
      return;
    this.surface_0.SetColorKey(ColorKeyFlags.SourceDraw, new ColorKey()
    {
      ColorSpaceHighValue = 16777215,
      ColorSpaceLowValue = 16777215
    });
  }

  public void method_15(Rectangle rectangle_2)
  {
    this.rectangle_0 = rectangle_2;
    this.surfaceDescription_0 = new SurfaceDescription();
    this.surfaceDescription_0.SurfaceCaps.OffScreenPlain = true;
    if (this.rectangle_0.Width < 1 || this.rectangle_0.Height < 1)
      return;
    this.surfaceDescription_0.Width = this.rectangle_0.Width;
    this.surfaceDescription_0.Height = this.rectangle_0.Height;
    this.surfaceDescription_0.SurfaceCaps.SystemMemory = true;
    try
    {
      this.surface_0 = new Surface(this.surfaceDescription_0, this.device_0);
    }
    catch
    {
    }
  }

  public GClass0(Device device_1, Rectangle rectangle_2, Rectangle rectangle_3)
  {
    this.device_0 = device_1;
    this.rectangle_0 = rectangle_2;
    this.rectangle_1 = rectangle_3;
    this.surfaceDescription_0 = new SurfaceDescription();
    this.surfaceDescription_0.SurfaceCaps.OffScreenPlain = true;
    this.surfaceDescription_0.Width = this.rectangle_0.Width;
    this.surfaceDescription_0.Height = this.rectangle_0.Height;
    this.surfaceDescription_0.SurfaceCaps.SystemMemory = true;
    this.surface_0 = new Surface(this.surfaceDescription_0, this.device_0);
  }

  public GClass0(
    string string_0,
    GEnum0 genum0_1,
    Device device_1,
    Rectangle rectangle_2,
    Rectangle rectangle_3)
  {
    this.bitmap_0 = new Bitmap(this.GetType().Module.Assembly.GetManifestResourceStream(string_0));
    this.genum0_0 = genum0_1;
    this.device_0 = device_1;
    this.rectangle_0 = rectangle_2;
    this.rectangle_1 = rectangle_3;
    this.int_0 = this.bitmap_0.Width;
    this.int_1 = this.bitmap_0.Height;
    this.method_16();
  }

  protected void method_16()
  {
    this.surfaceDescription_0 = new SurfaceDescription();
    this.surfaceDescription_0.SurfaceCaps.OffScreenPlain = true;
    this.surfaceDescription_0.Width = this.rectangle_0.Width;
    this.surfaceDescription_0.Height = this.rectangle_0.Height;
    this.surfaceDescription_0.SurfaceCaps.SystemMemory = true;
    this.surface_0 = new Surface(this.bitmap_0, this.surfaceDescription_0, this.device_0);
    if (this.genum0_0 != GEnum0.const_1)
      return;
    this.surface_0.SetColorKey(ColorKeyFlags.SourceDraw, new ColorKey()
    {
      ColorSpaceHighValue = 0,
      ColorSpaceLowValue = 0
    });
  }

  public void method_17() => this.method_16();
}
