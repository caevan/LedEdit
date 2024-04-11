// Decompiled with JetBrains decompiler
// Type: ai
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class ai : Form
{
  private IContainer icontainer_0;
  private Label label_0;
  private ComboBox comboBox_0;
  private Button button_0;
  private Button button_1;

  public ai()
  {
    this.method_1();
    this.comboBox_0.Items.Clear();
    if (c.int_78 > c.int_76)
      c.int_78 = c.int_77;
    for (int index = 1; index <= c.int_76; ++index)
      this.comboBox_0.Items.Add((object) index);
    if (c.int_78 > 0)
      this.comboBox_0.SelectedIndex = c.int_78 - 1;
    else
      this.comboBox_0.SelectedIndex = c.int_77 - 1;
  }

  private void button_0_Click(object sender, EventArgs e)
  {
    int int_0 = 14;
    try
    {
      Convert.ToInt32(this.comboBox_0.Text);
    }
    catch
    {
      this.method_0(Module.a("\uF1B3쒵쪷햹캻龽", int_0));
      return;
    }
    if (this.comboBox_0.SelectedIndex < 0)
    {
      this.method_0(Module.a("\uF1B3쒵쪷햹캻龽", int_0));
    }
    else
    {
      c.int_78 = this.comboBox_0.SelectedIndex + 1;
      this.DialogResult = DialogResult.OK;
    }
  }

  private void method_0(string string_0)
  {
    MessageDialog aa = new MessageDialog();
    aa.label_0.Text = string_0;
    int num = (int) aa.ShowDialog();
  }

  private void button_1_Click(object sender, EventArgs e) => this.Close();

    protected override void Dispose(bool disposing)
    {
        if (disposing && this.icontainer_0 != null)
            this.icontainer_0.Dispose();

        base.Dispose(disposing);
    }

    private void method_1()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ai));
    this.label_0 = new Label();
    this.comboBox_0 = new ComboBox();
    this.button_0 = new Button();
    this.button_1 = new Button();
    this.SuspendLayout();
    this.label_0.AccessibleDescription = (string) null;
    this.label_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_0, Module.a("\uDFB2풴햶\uDCB8ힺ貼", 13));
    this.label_0.Font = (Font) null;
    this.label_0.Name = Module.a("\uDFB2풴햶\uDCB8ힺ貼", 13);
    this.comboBox_0.AccessibleDescription = (string) null;
    this.comboBox_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.comboBox_0, Module.a("킲\uDAB4\uDAB6\uDBB8풺ﾼ킾맀\uF2C2", 13));
    this.comboBox_0.BackgroundImage = (Image) null;
    this.comboBox_0.Font = (Font) null;
    this.comboBox_0.FormattingEnabled = true;
    this.comboBox_0.Name = Module.a("킲\uDAB4\uDAB6\uDBB8풺ﾼ킾맀\uF2C2", 13);
    this.button_0.AccessibleDescription = (string) null;
    this.button_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.button_0, Module.a("톲살쎶춸풺펼躾", 13));
    this.button_0.BackgroundImage = (Image) null;
    this.button_0.Font = (Font) null;
    this.button_0.Name = Module.a("톲살쎶춸풺펼躾", 13);
    this.button_0.UseVisualStyleBackColor = true;
    this.button_0.Click += new EventHandler(this.button_0_Click);
    this.button_1.AccessibleDescription = (string) null;
    this.button_1.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.button_1, Module.a("톲살쎶춸풺펼趾", 13));
    this.button_1.BackgroundImage = (Image) null;
    this.button_1.Font = (Font) null;
    this.button_1.Name = Module.a("톲살쎶춸풺펼趾", 13);
    this.button_1.UseVisualStyleBackColor = true;
    this.button_1.Click += new EventHandler(this.button_1_Click);
    this.AccessibleDescription = (string) null;
    this.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this, Module.a("鞲솴\uDFB6킸좺", 13));
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackgroundImage = (Image) null;
    this.ControlBox = false;
    this.Controls.Add((Control) this.button_1);
    this.Controls.Add((Control) this.button_0);
    this.Controls.Add((Control) this.comboBox_0);
    this.Controls.Add((Control) this.label_0);
    this.Font = (Font) null;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Icon = (Icon) null;
    this.Name = Module.a("\uE0B2킴쎶\uE6B8ﶺ튼춾곀鳂鿄\uA8C6ꛈꛊ", 13);
    this.ShowIcon = false;
    this.ShowInTaskbar = false;
    this.TopMost = true;
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
