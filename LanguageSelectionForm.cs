// Decompiled with JetBrains decompiler
// Type: LanguageSelectionForm
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using System;
using System.ComponentModel;
using System.Windows.Forms;

public class LanguageSelectionForm : Form
{
  private IContainer icontainer_0;
  private ListBox listBox_0;
  private Button OKButton;
  private Label label_0;

    protected override void Dispose(bool disposing)
    {
        if (disposing && this.icontainer_0 != null)
            this.icontainer_0.Dispose();

        base.Dispose(disposing);
    }

    private void LayoutForm()
  {
        ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(LanguageSelectionForm));
        this.listBox_0 = new ListBox();
        this.OKButton = new Button();
        this.label_0 = new Label();
        this.SuspendLayout();
        this.listBox_0.FormattingEnabled = true;
        componentResourceManager.ApplyResources((object)this.listBox_0, "listBox1");
        this.listBox_0.Items.AddRange(new object[2]
        {
      (object) componentResourceManager.GetString("listBox1.Items"),
      (object) componentResourceManager.GetString("listBox1.Items1")
        });
        this.listBox_0.Name = "listBox1";
        this.listBox_0.SelectedIndexChanged += new EventHandler(this.listBox_0_SelectedIndexChanged);
        componentResourceManager.ApplyResources((object)this.OKButton, "button1");
        this.OKButton.Name = "button1";
        this.OKButton.UseVisualStyleBackColor = true;
        this.OKButton.Click += new EventHandler(this.OKButton_Click);
        componentResourceManager.ApplyResources((object)this.label_0, "label1");
        this.label_0.Name = "label1";
        this.label_0.Click += new EventHandler(this.label_0_Click);
        componentResourceManager.ApplyResources((object)this, "$this");
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ControlBox = false;
        this.Controls.Add((Control)this.label_0);
        this.Controls.Add((Control)this.OKButton);
        this.Controls.Add((Control)this.listBox_0);
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.Name = "Language_Selection";
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    public LanguageSelectionForm()
  {
    this.LayoutForm();
    this.listBox_0.SelectedIndex = 0;
  }

  private void OKButton_Click(object sender, EventArgs e)
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
