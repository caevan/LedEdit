// Decompiled with JetBrains decompiler
// Type: GClass1
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using Microsoft.DirectX.DirectDraw;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class GClass1
{
  protected Control control_0;
  protected Device device_0;
  protected Clipper clipper_0;
  protected Surface surface_0;
  protected Surface surface_1;
  protected Point point_0;
  protected Rectangle rectangle_0;

  [SpecialName]
  public Surface method_0() => this.surface_1;

  [SpecialName]
  public Device method_1() => this.device_0;

  [SpecialName]
  public Surface method_2() => this.surface_0;

  public GClass1(Control control_1)
  {
    this.control_0 = control_1;
    this.device_0 = new Device();
    this.device_0.SetCooperativeLevel(this.control_0, CooperativeLevelFlags.Normal);
    this.method_3();
  }

  protected void method_3()
  {
    SurfaceDescription desc = new SurfaceDescription();
    desc.SurfaceCaps.PrimarySurface = true;
    this.surface_0 = new Surface(desc, this.device_0);
    desc.Clear();
    desc.Width = this.control_0.Width;
    desc.Height = this.control_0.Height;
    desc.SurfaceCaps.OffScreenPlain = true;
    desc.SurfaceCaps.SystemMemory = true;
    this.surface_1 = new Surface(desc, this.device_0);
    this.clipper_0 = new Clipper(this.device_0);
    this.clipper_0.Window = this.control_0;
    this.surface_0.Clipper = this.clipper_0;
  }

  public void method_4(GClass0 gclass0_0)
  {
    if (!this.control_0.Created)
      return;
    if (this.surface_1 == (Surface) null)
      return;
    try
    {
      if (gclass0_0.method_0() == GEnum0.const_1)
        this.surface_1.Draw(gclass0_0.method_3(), gclass0_0.method_12(), gclass0_0.method_5(), DrawFlags.Wait | DrawFlags.KeySource);
      else
        this.surface_1.Draw(gclass0_0.method_3(), gclass0_0.method_12(), gclass0_0.method_5(), DrawFlags.Wait);
    }
    catch
    {
      this.method_3();
    }
  }

  public void method_5()
  {
    if (!this.control_0.Created || this.surface_0 == (Surface) null)
      return;
    if (this.surface_1 == (Surface) null)
      return;
    try
    {
      this.point_0 = this.control_0.PointToScreen(new Point(0, 0));
      this.rectangle_0 = new Rectangle(this.point_0.X, this.point_0.Y, this.control_0.Width, this.control_0.Height);
      this.surface_0.Draw(this.rectangle_0, this.surface_1, DrawFlags.Wait);
    }
    catch (SurfaceLostException ex)
    {
      this.method_3();
    }
  }
}
