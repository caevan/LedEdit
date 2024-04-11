// Decompiled with JetBrains decompiler
// Type: i
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class i : Form
{
  public const int int_0 = 274;
  public const int int_1 = 61456;
  public const int int_2 = 2;
  private IContainer icontainer_0;

  public i()
  {
    this.method_1();
    c.rectangle_0 = this.RectangleToScreen(this.ClientRectangle);
    this.i_Resize((object) null, (EventArgs) null);
  }

  private void i_Resize(object sender, EventArgs e)
  {
    if (!c.bool_32)
      return;
    c.rectangle_0 = this.RectangleToScreen(this.ClientRectangle);
    Rectangle rectangle_2 = new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height);
    c.gclass0_4.method_15(rectangle_2);
    c.gclass0_4.method_12().ColorFill(Color.FromArgb(0, 0, 0));
  }

  [DllImport("user32.dll")]
  public static extern bool ReleaseCapture();

  [DllImport("user32.dll")]
  public static extern bool SendMessage(IntPtr intptr_0, int int_3, int int_4, int int_5);

  private void i_MouseDown(object sender, MouseEventArgs e)
  {
    i.ReleaseCapture();
    i.SendMessage(this.Handle, 274, 61458, 0);
  }

  private void i_MouseEnter(object sender, EventArgs e) => this.Cursor = Cursors.SizeAll;

  private void i_MouseLeave(object sender, EventArgs e) => this.Cursor = Cursors.Default;

  private void i_Move(object sender, EventArgs e) => c.rectangle_0 = this.RectangleToScreen(this.ClientRectangle);

  public void method_0()
  {
    c.rectangle_0 = this.RectangleToScreen(this.ClientRectangle);
    Rectangle rectangle_2 = new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height);
    c.gclass0_4.method_15(rectangle_2);
    c.gclass0_4.method_12().ColorFill(Color.FromArgb(0, 0, 0));
  }

    protected override void Dispose(bool disposing)
    {
        if (disposing && this.icontainer_0 != null)
            this.icontainer_0.Dispose();

        base.Dispose(disposing);
    }

    private void method_1()
  {
    this.SuspendLayout();
    this.AutoScaleDimensions = new SizeF(6f, 12f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(312, 248);
    this.ControlBox = false;
    this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = "CutScreen"; //Module.a("\uF2B0욲솴\uE4B6\uDAB8즺\uD8BC\uDABE꿀", 11);
    this.Text = "Cut"; //Module.a("\uF2B0욲솴", 11);
    this.TopMost = true;
    this.TransparencyKey = Color.White;
    this.MouseEnter += new EventHandler(this.i_MouseEnter);
    this.MouseDown += new MouseEventHandler(this.i_MouseDown);
    this.MouseLeave += new EventHandler(this.i_MouseLeave);
    this.Move += new EventHandler(this.i_Move);
    this.Resize += new EventHandler(this.i_Resize);
    this.ResumeLayout(false);
  }
}
