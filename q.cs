// Decompiled with JetBrains decompiler
// Type: q
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

public class q : Form
{
  private bool bool_0;
  private int int_0;
  private IContainer icontainer_0;
  private Button button_0;
  private Label label_0;

  public q()
  {
    this.method_1();
    this.Text = Module.a("薶覸誺覼龾", 17) + c.string_0;
    string str = Application.StartupPath + Module.a("\uEBB6\uEAB8ﺺ\uE9BC\uE3BE꧀ꛂ꧄럆\uE7C8꧊ꃌ뿎", 17);
    if (File.Exists(str))
    {
      this.BackgroundImage = Image.FromFile(str);
      this.BackgroundImageLayout = ImageLayout.Stretch;
      this.label_0.Visible = false;
    }
    this.int_0 = 0;
  }

  private void button_0_Click(object sender, EventArgs e)
  {
    this.bool_0 = false;
    this.method_0();
    if (this.bool_0)
    {
      ++this.int_0;
      if (this.int_0 < 3)
        return;
    }
    this.DialogResult = DialogResult.OK;
  }

  private void method_0()
  {
    int int_0 = 3;
    StackFrame stackFrame = new StackFrame();
    this.label_0.Text = stackFrame.GetMethod().Name;
    if (!(stackFrame.GetMethod().Name == Module.a("槀\uE0C7\u0DFE槵\uEEB0킲\uDDB4튶\uDAB8킺\uE2BC햾ꣀꋂ꣄껆", 3)))
      return;
    int num = (int) MessageBox.Show(Module.a("泝私膬ꃲ狯銲閴颶隸钺鶼\uE9BEꣀ뇂냄듆\uE5C8\uEBCA꿌\uAACE\uF1D0냒듔ꗖ볘뷚\uA8DC돞쇠賢菤쟦部蓪飬鷮퇰闲鳴鯶鳸\uDAFA\uDDFC", int_0));
    this.bool_0 = true;
  }

  private void q_Load(object sender, EventArgs e) => this.method_0();

    protected override void Dispose(bool disposing)
    {
        if (disposing && this.icontainer_0 != null)
            this.icontainer_0.Dispose();

        base.Dispose(disposing);
    }

    private void method_1()
  {
    this.button_0 = new Button();
    this.label_0 = new Label();
    this.SuspendLayout();
    this.button_0.Location = new Point(304, 185);
    this.button_0.Name = Module.a("쪧\uDFA9\uD8AB\uDAAD\uDFAF\uDCB1薳", 2);
    this.button_0.Size = new Size(75, 23);
    this.button_0.TabIndex = 1;
    this.button_0.Text = Module.a("\uE7A7\uE1A9", 2);
    this.button_0.UseVisualStyleBackColor = true;
    this.button_0.Click += new EventHandler(this.button_0_Click);
    this.label_0.AutoSize = true;
    this.label_0.BackColor = SystemColors.ActiveCaptionText;
    this.label_0.Location = new Point(304, 218);
    this.label_0.Name = Module.a("쒧쮩캫쮭\uDCAF莱", 2);
    this.label_0.Size = new Size(35, 12);
    this.label_0.TabIndex = 2;
    this.label_0.Text = Module.a("袧誩貫躭邯", 2);
    this.AutoScaleDimensions = new SizeF(6f, 12f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackgroundImageLayout = ImageLayout.Stretch;
    this.ClientSize = new Size(431, 245);
    this.ControlBox = false;
    this.Controls.Add((Control) this.label_0);
    this.Controls.Add((Control) this.button_0);
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.MinimumSize = new Size(226, 159);
    this.Name = Module.a("\uE9A7좩쎫\uDBAD쒯", 2);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = Module.a("\uE9A7좩쎫\uDBAD쒯鲱骳颵", 2);
    this.Load += new EventHandler(this.q_Load);
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
