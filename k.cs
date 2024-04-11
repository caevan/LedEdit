// Decompiled with JetBrains decompiler
// Type: k
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class k : Form
{
  private IContainer icontainer_0;
  private TextBox textBox_0;
  private Label label_0;

  public k() => this.method_3();

  [SpecialName]
  public string method_0() => this.textBox_0.Text;

  [SpecialName]
  public void method_1(string string_0) => this.textBox_0.Text = string_0;

  private void method_2(object sender, EventArgs e) => this.Hide();

    protected override void Dispose(bool disposing)
    {
        if (disposing && this.icontainer_0 != null)
            this.icontainer_0.Dispose();

        base.Dispose(disposing);
    }

    private void method_3()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (k));
    this.textBox_0 = new TextBox();
    this.label_0 = new Label();
    this.SuspendLayout();
    this.textBox_0.AccessibleDescription = (string) null;
    this.textBox_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.textBox_0, Module.a("\uDFAA좬\uD7AE얰\uF1B2\uDAB4쾶袸", 5));
    this.textBox_0.BackgroundImage = (Image) null;
    this.textBox_0.Font = (Font) null;
    this.textBox_0.Name = Module.a("\uDFAA좬\uD7AE얰\uF1B2\uDAB4쾶袸", 5);
    this.textBox_0.ReadOnly = true;
    this.label_0.AccessibleDescription = (string) null;
    this.label_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_0, Module.a("잪첬춮풰\uDFB2蒴", 5));
    this.label_0.Font = (Font) null;
    this.label_0.Name = Module.a("잪첬춮풰\uDFB2蒴", 5);
    this.AccessibleDescription = (string) null;
    this.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this, Module.a("辪\uD9AC잮\uD8B0삲", 5));
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = SystemColors.Control;
    this.BackgroundImage = (Image) null;
    this.ControlBox = false;
    this.Controls.Add((Control) this.label_0);
    this.Controls.Add((Control) this.textBox_0);
    this.Font = (Font) null;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Icon = (Icon) null;
    this.Name = Module.a("\uE5AA좬\uDBAE\uE6B0튲솴풶톸", 5);
    this.ShowInTaskbar = false;
    this.TopMost = true;
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
