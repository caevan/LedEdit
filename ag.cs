// Decompiled with JetBrains decompiler
// Type: ag
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class ag : Form
{
  private IContainer icontainer_0;
  private Button button_0;
  private TextBox textBox_0;
  private Button button_1;
  private Label label_0;
  public static string string_0;

    protected override void Dispose(bool disposing)
    {
        if (disposing && this.icontainer_0 != null)
            this.icontainer_0.Dispose();

        base.Dispose(disposing);
    }

    private void method_0()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ag));
    this.button_0 = new Button();
    this.textBox_0 = new TextBox();
    this.button_1 = new Button();
    this.label_0 = new Label();
    this.SuspendLayout();
    this.button_0.AccessibleDescription = (string) null;
    this.button_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.button_0, Module.a("톲살쎶춸풺펼趾", 13));
    this.button_0.BackgroundImage = (Image) null;
    this.button_0.Font = (Font) null;
    this.button_0.Name = Module.a("톲살쎶춸풺펼趾", 13);
    this.button_0.UseVisualStyleBackColor = true;
    this.button_0.Click += new EventHandler(this.button_0_Click);
    this.textBox_0.AccessibleDescription = (string) null;
    this.textBox_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.textBox_0, Module.a("잲킴쾶춸了튼잾\uF0C0", 13));
    this.textBox_0.BackgroundImage = (Image) null;
    this.textBox_0.Font = (Font) null;
    this.textBox_0.Name = Module.a("잲킴쾶춸了튼잾\uF0C0", 13);
    this.button_1.AccessibleDescription = (string) null;
    this.button_1.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.button_1, Module.a("톲살쎶춸풺펼躾", 13));
    this.button_1.BackgroundImage = (Image) null;
    this.button_1.Font = (Font) null;
    this.button_1.Name = Module.a("톲살쎶춸풺펼躾", 13);
    this.button_1.UseVisualStyleBackColor = true;
    this.button_1.Click += new EventHandler(this.button_1_Click);
    this.label_0.AccessibleDescription = (string) null;
    this.label_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_0, Module.a("\uDFB2풴햶\uDCB8ힺ貼", 13));
    this.label_0.Font = (Font) null;
    this.label_0.Name = Module.a("\uDFB2풴햶\uDCB8ힺ貼", 13);
    this.AccessibleDescription = (string) null;
    this.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this, Module.a("鞲솴\uDFB6킸좺", 13));
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackgroundImage = (Image) null;
    this.ControlBox = false;
    this.Controls.Add((Control) this.button_0);
    this.Controls.Add((Control) this.textBox_0);
    this.Controls.Add((Control) this.button_1);
    this.Controls.Add((Control) this.label_0);
    this.Font = (Font) null;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Icon = (Icon) null;
    this.Name = Module.a("者\uDBB4잶첸쾺\uE2BC쮾꓀믂뇄", 13);
    this.TopMost = true;
    this.Shown += new EventHandler(this.ag_Shown);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public ag() => this.method_0();

  private void method_1(string string_1)
  {
    MessageDialog aa = new MessageDialog();
    aa.label_0.Text = string_1;
    int num = (int) aa.ShowDialog();
  }

  private void button_1_Click(object sender, EventArgs e)
  {
    int int_0 = 13;
    if (this.textBox_0.Text == "")
    {
      if (c.useEnglishLanguage)
        this.method_1(Module.a("\uE3B2\uD9B4튶\uD8B8좺\uD8BC龾꓀귂뇄ꋆ믈\uEBCA곌\uEFCE뿐닒룔닖\uF8D8", int_0));
      else
        this.method_1(Module.a("䐹☻틧듬䯃뱃", int_0));
      this.textBox_0.Focus();
    }
    else
    {
      ag.string_0 = this.textBox_0.Text;
      this.DialogResult = DialogResult.OK;
    }
  }

  private void button_0_Click(object sender, EventArgs e) => this.Close();

  private void ag_Shown(object sender, EventArgs e)
  {
    this.textBox_0.Focus();
    this.textBox_0.Text = ag.string_0;
    this.textBox_0.SelectAll();
  }
}
