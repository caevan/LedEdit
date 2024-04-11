// Decompiled with JetBrains decompiler
// Type: d
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using AxShockwaveFlashObjects;
using Microsoft.DirectX.AudioVideoPlayback;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class d : Form
{
  public const int int_0 = 274;
  public const int int_1 = 61456;
  public const int int_2 = 2;
  private System.ComponentModel.Container container_0;
  public Panel panel_0;
  public AxShockwaveFlash axShockwaveFlash_0;
  private Video video_0;
  private int int_3;
  private int int_4;

  public d()
  {
    this.method_4();
    this.axShockwaveFlash_0.ScaleMode = 2;
  }

    protected override void Dispose(bool disposing)
    {
        if (disposing && this.container_0 != null)
            this.container_0.Dispose();

        base.Dispose(disposing);
    }

    public void method_0(string string_0, int int_5, int int_6)
  {
    int int_0 = 7;
    if (string_0.Length == 0)
      return;
    bool flag = false;
    if (string_0.EndsWith(Module.a("莬캮잰\uDAB2", int_0)))
      flag = true;
    if (string_0.EndsWith(Module.a("莬\uD8AE\uDCB0얲", int_0)))
      flag = true;
    if (string_0.EndsWith(Module.a("莬슮솰횲튴", int_0)))
      flag = true;
    if (string_0.EndsWith(Module.a("莬슮솰풲", int_0)))
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
    int int_0 = 10;
    if (this.video_0 != null)
      this.method_2();
    string str1 = string_0;
    int num1 = str1.LastIndexOf(Module.a("\uECAF", int_0));
    string str2 = str1.Substring(num1 + 1, str1.Length - num1 - 1);
    try
    {
      this.video_0 = new Video(string_0);
    }
    catch
    {
      int num2 = (int) MessageBox.Show(Module.a("\uE5AF\uDCB1햳풵풷\uDFB9鲻쪽꾿\uE2C1듃\uAAC5꧇돉\uECCB", int_0) + str2);
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

  private void method_3(object sender, FormClosingEventArgs e)
  {
    if (this.video_0 == null)
      return;
    this.method_2();
  }

  private void method_4()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (d));
    this.panel_0 = new Panel();
    this.axShockwaveFlash_0 = new AxShockwaveFlash();
    this.panel_0.SuspendLayout();
    this.axShockwaveFlash_0.BeginInit();
    this.SuspendLayout();
    this.panel_0.Controls.Add((Control) this.axShockwaveFlash_0);
    this.panel_0.Cursor = Cursors.SizeAll;
    this.panel_0.Dock = DockStyle.Fill;
    this.panel_0.Font = new Font(Module.a("\uE5B5톷ힹ\uEFBB쮽꺿", 16), 5.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.panel_0.Location = new Point(0, 0);
    this.panel_0.Name = Module.a("욵\uD9B7풹\uD9BB튽\uF1BF", 16);
    this.panel_0.Size = new Size(480, 360);
    this.panel_0.TabIndex = 0;
    this.axShockwaveFlash_0.Dock = DockStyle.Fill;
    this.axShockwaveFlash_0.Enabled = true;
    this.axShockwaveFlash_0.Location = new Point(0, 0);
    this.axShockwaveFlash_0.Name = Module.a("ힵ삷\uE9B9풻톽ꎿ꧁돃\uA7C5뻇꿉請ꋍ뇏ꇑ볓\uE7D5", 16);
    this.axShockwaveFlash_0.OcxState = (AxHost.State) componentResourceManager.GetObject(Module.a("ힵ삷\uE9B9풻톽ꎿ꧁돃\uA7C5뻇꿉請ꋍ뇏ꇑ볓\uE7D5\uF6D7闙뿛ꛝ돟雡藣鋥跧", 16));
    this.axShockwaveFlash_0.Size = new Size(480, 360);
    this.axShockwaveFlash_0.TabIndex = 0;
    this.AutoScaleBaseSize = new Size(4, 8);
    this.ClientSize = new Size(480, 360);
    this.ControlBox = false;
    this.Controls.Add((Control) this.panel_0);
    this.Cursor = Cursors.SizeAll;
    this.Font = new Font(Module.a("\uE5B5톷ힹ\uEFBB쮽꺿", 16), 5.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Location = new Point(500, 400);
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = Module.a("\uE6B5풷\uDBB9얻\uDBBD늿", 16);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = Module.a("\uE6B5풷\uDBB9얻\uDBBD늿", 16);
    this.TopMost = true;
    this.MouseEnter += new EventHandler(this.d_MouseEnter);
    this.MouseDown += new MouseEventHandler(this.d_MouseDown);
    this.MouseLeave += new EventHandler(this.d_MouseLeave);
    this.panel_0.ResumeLayout(false);
    this.axShockwaveFlash_0.EndInit();
    this.ResumeLayout(false);
  }

  [DllImport("user32.dll")]
  public static extern bool ReleaseCapture();

  [DllImport("user32.dll")]
  public static extern bool SendMessage(IntPtr intptr_0, int int_5, int int_6, int int_7);

  private void d_MouseDown(object sender, MouseEventArgs e)
  {
    d.ReleaseCapture();
    d.SendMessage(this.Handle, 274, 61458, 0);
  }

  private void d_MouseEnter(object sender, EventArgs e) => this.Cursor = Cursors.SizeAll;

  private void d_MouseLeave(object sender, EventArgs e) => this.Cursor = Cursors.Default;
}
