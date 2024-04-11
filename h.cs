// Decompiled with JetBrains decompiler
// Type: h
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using System;
using System.ComponentModel;
using System.Windows.Forms;

public class h : Form
{
  private IContainer icontainer_0;
  private ListBox listBox_0;
  private Button button_0;
  private Label label_0;

    protected override void Dispose(bool disposing)
    {
        if (disposing && this.icontainer_0 != null)
            this.icontainer_0.Dispose();

        base.Dispose(disposing);
    }

    private void method_0()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (h));
    this.listBox_0 = new ListBox();
    this.button_0 = new Button();
    this.label_0 = new Label();
    this.SuspendLayout();
    this.listBox_0.FormattingEnabled = true;
    componentResourceManager.ApplyResources((object) this.listBox_0, Module.a("쎮\uD8B0삲솴\uF5B6횸쎺貼", 9));
    this.listBox_0.Items.AddRange(new object[2]
    {
      (object) componentResourceManager.GetString(Module.a("쎮\uD8B0삲솴\uF5B6횸쎺貼醾裀럂ꃄ\uAAC6뫈", 9)),
      (object) componentResourceManager.GetString(Module.a("쎮\uD8B0삲솴\uF5B6횸쎺貼醾裀럂ꃄ\uAAC6뫈響", 9))
    });
    this.listBox_0.Name = Module.a("쎮\uD8B0삲솴\uF5B6횸쎺貼", 9);
    this.listBox_0.SelectedIndexChanged += new EventHandler(this.listBox_0_SelectedIndexChanged);
    componentResourceManager.ApplyResources((object) this.button_0, Module.a("춮쒰잲솴\uD8B6ힸ誺", 9));
    this.button_0.Name = Module.a("춮쒰잲솴\uD8B6ힸ誺", 9);
    this.button_0.UseVisualStyleBackColor = true;
    this.button_0.Click += new EventHandler(this.button_0_Click);
    componentResourceManager.ApplyResources((object) this.label_0, Module.a("쎮킰톲킴\uDBB6袸", 9));
    this.label_0.Name = Module.a("쎮킰톲킴\uDBB6袸", 9);
    this.label_0.Click += new EventHandler(this.label_0_Click);
    componentResourceManager.ApplyResources((object) this, Module.a("议얰\uDBB2\uDCB4쒶", 9));
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ControlBox = false;
    this.Controls.Add((Control) this.label_0);
    this.Controls.Add((Control) this.button_0);
    this.Controls.Add((Control) this.listBox_0);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = Module.a("\uE3AE킰\uDDB2튴슶\uD8B8\uDCBA\uD8BC\uE0BE鋀ꛂ꧄ꋆ\uAAC8뿊\uA4CCꃎ뿐", 9);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public h()
  {
    this.method_0();
    this.listBox_0.SelectedIndex = 0;
  }

  private void button_0_Click(object sender, EventArgs e)
  {
    c.useEnglishLanguage = this.listBox_0.SelectedIndex != 0;
    this.DialogResult = DialogResult.OK;
  }

  private void label_0_Click(object sender, EventArgs e)
  {
  }

  private void listBox_0_SelectedIndexChanged(object sender, EventArgs e)
  {
  }
}
