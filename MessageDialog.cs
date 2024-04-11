// Decompiled with JetBrains decompiler
// Type: aa
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class MessageDialog : Form
{
  private int int_0 = 1024;
  private int int_1 = 768;
  private IContainer icontainer_0;
  public Label label_0;
  private Button button_0;

  public MessageDialog() => this.Create();

  [DllImport("user32.dll")]
  public static extern bool MessageBeep(uint uint_0);

  private void aa_Load(object sender, EventArgs e)
  {
    //int int_0 = 11;
        if (c.useEnglishLanguage)
            this.button_0.Text = "Ok"; //Module.a("ﺰ\uF8B2", int_0);
        else
            this.button_0.Text = "确定"; // Module.a("\uDFC8⧩", int_0);
    MessageDialog.MessageBeep(uint.MaxValue);
  }

  private void button_0_Paint(object sender, PaintEventArgs e)
  {
    this.button_0.Location = new Point(this.Size.Width / 2 - this.button_0.Width / 2, this.button_0.Location.Y);
    this.label_0.Location = new Point(this.Size.Width / 2 - this.label_0.Width / 2, this.label_0.Location.Y);
  }

  private void aa_SizeChanged(object sender, EventArgs e)
  {
    if (this.Width > this.int_0)
      this.Width = this.int_0;
    if (this.Height <= this.int_1)
      return;
    this.Height = this.int_1;
  }

  private void aa_Shown(object sender, EventArgs e)
  {
    this.int_0 = this.Width;
    this.int_1 = this.Height;
  }

    protected override void Dispose(bool disposing)
    {
        if (disposing && this.icontainer_0 != null)
            this.icontainer_0.Dispose();

        base.Dispose(disposing);
    }
  //  virtual void Form.Dispose(bool disposing)
  //{
  //  if (disposing && this.icontainer_0 != null)
  //    this.icontainer_0.Dispose();
  //  // ISSUE: explicit non-virtual call
  //  __nonvirtual (((Form) this).Dispose(disposing));
  //}

  private void Create()
  {
    this.label_0 = new Label();
    this.button_0 = new Button();
    this.SuspendLayout();
    this.label_0.AutoSize = true;
    this.label_0.Location = new Point(12, 20);
        this.label_0.Name = "label1"; //Module.a("삫쾭튯ힱ\uD8B3螵", 6);
    this.label_0.Size = new Size(41, 12);
    this.label_0.TabIndex = 0;
        this.label_0.Text = "label1";// Module.a("삫쾭튯ힱ\uD8B3螵", 6);
    this.button_0.AutoSize = true;
    this.button_0.DialogResult = DialogResult.OK;
    this.button_0.Location = new Point(24, 46);
        this.button_0.Name = "button1"; // Module.a("캫\uDBAD쒯욱\uDBB3\uD8B5覷", 6);
    this.button_0.Size = new Size(75, 23);
    this.button_0.TabIndex = 1;
        this.button_0.Text = "Ok";//Module.a("싓㓶", 6);
    this.button_0.UseVisualStyleBackColor = true;
    this.button_0.Paint += new PaintEventHandler(this.button_0_Paint);
    this.AcceptButton = (IButtonControl) this.button_0;
    this.AutoScaleDimensions = new SizeF(6f, 12f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.AutoSize = true;
    this.ClientSize = new Size(115, 81);
    this.ControlBox = false;
    this.Controls.Add((Control) this.button_0);
    this.Controls.Add((Control) this.label_0);
    this.MaximizeBox = false;
    this.MinimizeBox = false;
        this.Name = "My_MessageBox"; // Module.a("\uE1AB\uD7AD\uEFAFﾱ톳억쮷\uDBB9\uDBBB\uDBBD芿귁볃", 6);
    this.ShowIcon = false;
    this.ShowInTaskbar = false;
    this.SizeGripStyle = SizeGripStyle.Hide;
    this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "  "; //Module.a("貫躭", 6);
    this.TopMost = true;
    this.Load += new EventHandler(this.aa_Load);
    this.SizeChanged += new EventHandler(this.aa_SizeChanged);
    this.Shown += new EventHandler(this.aa_Shown);
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
