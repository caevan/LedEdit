// Decompiled with JetBrains decompiler
// Type: ad
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using Microsoft.DirectX.AudioVideoPlayback;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class ad : Form
{
  public const int int_0 = 274;
  public const int int_1 = 61456;
  public const int int_2 = 2;
  private Video video_0;
  private int int_3;
  private int int_4;
  private IContainer icontainer_0;

  public ad() => this.method_3();

  public void method_0(string string_0, int int_5, int int_6)
  {
    int int_0 = 13;
    if (string_0.Length == 0)
      return;
    bool flag = false;
    if (string_0.EndsWith(Module.a("鶲풴솶킸", int_0)))
      flag = true;
    if (string_0.EndsWith(Module.a("鶲슴\uDAB6쾸", int_0)))
      flag = true;
    if (string_0.EndsWith(Module.a("鶲\uD8B4잶\uDCB8\uDCBA", int_0)))
      flag = true;
    if (string_0.EndsWith(Module.a("鶲\uD8B4잶\uDEB8", int_0)))
      flag = true;
    this.int_3 = int_5;
    this.int_4 = int_6;
    if (this.int_3 < 1 || this.int_4 < 1)
    {
      this.int_3 = 300;
      this.int_4 = 200;
    }
    if (!flag)
      return;
    this.method_1(string_0);
  }

  private void method_1(string string_0)
  {
    int int_0 = 0;
    if (this.video_0 != null)
      this.method_2();
    string str1 = string_0;
    int num1 = str1.LastIndexOf(Module.a("瘟", int_0));
    string str2 = str1.Substring(num1 + 1, str1.Length - num1 - 1);
    try
    {
      this.video_0 = new Video(string_0);
    }
    catch
    {
      int num2 = (int) MessageBox.Show(Module.a("\uF3A5욧쮩캫슭햯銱삳\uD9B5颷쪹킻\uDFBD릿\uE2C1", int_0) + str2);
      return;
    }
    this.video_0.Owner = (Control) this;
    this.video_0.Owner.Size = new Size(this.int_3, this.int_4);
    this.video_0.Ending += new EventHandler(this.video_0_Ending);
    this.video_0.Play();
  }

  private void video_0_Ending(object sender, EventArgs e)
  {
    if (this.video_0 == null)
      return;
    this.video_0.CurrentPosition = 0.0;
  }

  public void method_2()
  {
    if (this.video_0 == null)
      return;
    this.video_0.Stop();
    this.video_0.Dispose();
    this.video_0 = (Video) null;
  }

  private void ad_FormClosing(object sender, FormClosingEventArgs e)
  {
    if (this.video_0 == null)
      return;
    this.method_2();
  }

  [DllImport("user32.dll")]
  public static extern bool ReleaseCapture();

  [DllImport("user32.dll")]
  public static extern bool SendMessage(IntPtr intptr_0, int int_5, int int_6, int int_7);

  private void ad_MouseDown(object sender, MouseEventArgs e)
  {
    ad.ReleaseCapture();
    ad.SendMessage(this.Handle, 274, 61458, 0);
  }

  private void ad_MouseEnter(object sender, EventArgs e) => this.Cursor = Cursors.SizeAll;

  private void ad_MouseLeave(object sender, EventArgs e) => this.Cursor = Cursors.Default;

    protected override void Dispose(bool disposing)
    {
        if (disposing && this.icontainer_0 != null)
            this.icontainer_0.Dispose();

        base.Dispose(disposing);
    }

    private void method_3()
  {
    this.SuspendLayout();
    this.AutoScaleDimensions = new SizeF(6f, 12f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(250, 250);
    this.ControlBox = false;
    this.FormBorderStyle = FormBorderStyle.None;
    this.Name = Module.a("\uF5B3삵톷\uE5B9\uECBB튽ꆿ믁ꇃ듅", 14);
    this.ShowIcon = false;
    this.ShowInTaskbar = false;
    this.Text = Module.a("\uF5B3삵톷\uE5B9\uECBB튽ꆿ믁ꇃ듅", 14);
    this.TopMost = true;
    this.MouseEnter += new EventHandler(this.ad_MouseEnter);
    this.MouseDown += new MouseEventHandler(this.ad_MouseDown);
    this.MouseLeave += new EventHandler(this.ad_MouseLeave);
    this.FormClosing += new FormClosingEventHandler(this.ad_FormClosing);
    this.ResumeLayout(false);
  }
}
