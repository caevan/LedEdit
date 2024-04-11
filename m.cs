// Decompiled with JetBrains decompiler
// Type: m
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class m : Form
{
  private IContainer icontainer_0;
  private Button button_0;
  private Button button_1;
  private Button button_2;
  private TextBox textBox_0;
  private Label label_0;
  private Button button_3;
  private Button button_4;
  private Button button_5;
  public static int int_0;
  public static string string_0;
  public static int int_1;
  private int int_2;

  static m() => m.old_acctor_mc();

    protected override void Dispose(bool disposing)
    {
        if (disposing && this.icontainer_0 != null)
            this.icontainer_0.Dispose();

        base.Dispose(disposing);
    }

    private void method_0()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (m));
    this.button_0 = new Button();
    this.button_1 = new Button();
    this.button_2 = new Button();
    this.textBox_0 = new TextBox();
    this.label_0 = new Label();
    this.button_3 = new Button();
    this.button_4 = new Button();
    this.button_5 = new Button();
    this.SuspendLayout();
    this.button_0.BackgroundImage = (Image) componentResourceManager.GetObject(Module.a("ힴ슶춸쾺튼톾\uF7C0\uEDC2蟄ꛆ\uAAC8ꃊ\uAACC뷎뻐ꛒ믔돖郘뛚볜룞蓠", 15));
    this.button_0.BackgroundImageLayout = ImageLayout.Stretch;
    this.button_0.Location = new Point(181, 34);
    this.button_0.Name = Module.a("ힴ슶춸쾺튼톾\uF7C0", 15);
    this.button_0.Size = new Size(21, 13);
    this.button_0.TabIndex = 9;
    this.button_0.UseVisualStyleBackColor = true;
    this.button_0.Click += new EventHandler(this.button_0_Click);
    this.button_1.BackgroundImage = (Image) componentResourceManager.GetObject(Module.a("ힴ슶춸쾺튼톾\uF4C0\uEDC2蟄ꛆ\uAAC8ꃊ\uAACC뷎뻐ꛒ믔돖郘뛚볜룞蓠", 15));
    this.button_1.BackgroundImageLayout = ImageLayout.Stretch;
    this.button_1.Location = new Point(181, 18);
    this.button_1.Name = Module.a("ힴ슶춸쾺튼톾\uF4C0", 15);
    this.button_1.Size = new Size(21, 15);
    this.button_1.TabIndex = 8;
    this.button_1.UseVisualStyleBackColor = true;
    this.button_1.Click += new EventHandler(this.button_1_Click);
    this.button_2.Location = new Point(217, 21);
    this.button_2.Name = Module.a("ힴ슶춸쾺튼톾\uF0C0", 15);
    this.button_2.Size = new Size(50, 23);
    this.button_2.TabIndex = 7;
    this.button_2.Text = Module.a("⌭部", 15);
    this.button_2.UseVisualStyleBackColor = true;
    this.button_2.Click += new EventHandler(this.button_2_Click);
    this.textBox_0.Location = new Point(89, 21);
    this.textBox_0.Name = Module.a("솴튶솸쾺ﾼ킾맀\uF2C2", 15);
    this.textBox_0.Size = new Size(86, 21);
    this.textBox_0.TabIndex = 6;
    this.textBox_0.Text = Module.a("蒴", 15);
    this.textBox_0.TextChanged += new EventHandler(this.textBox_0_TextChanged);
    this.label_0.AutoSize = true;
    this.label_0.Location = new Point(22, 24);
    this.label_0.Name = Module.a("\uD9B4횶\uDBB8\uDEBA톼躾", 15);
    this.label_0.Size = new Size(59, 12);
    this.label_0.TabIndex = 5;
    this.label_0.Text = Module.a("ⷈ茻\uF4F7헅螼", 15);
    this.button_3.Location = new Point(273, 21);
    this.button_3.Name = Module.a("ힴ슶춸쾺튼톾\uF5C0", 15);
    this.button_3.Size = new Size(50, 23);
    this.button_3.TabIndex = 10;
    this.button_3.Text = Module.a("黓部", 15);
    this.button_3.UseVisualStyleBackColor = true;
    this.button_3.Click += new EventHandler(this.button_3_Click);
    this.button_4.Location = new Point(204, 82);
    this.button_4.Name = Module.a("ힴ슶춸쾺튼톾\uF2C0", 15);
    this.button_4.Size = new Size(75, 23);
    this.button_4.TabIndex = 12;
    this.button_4.Text = Module.a("揧㿛", 15);
    this.button_4.UseVisualStyleBackColor = true;
    this.button_4.Click += new EventHandler(this.button_4_Click);
    this.button_5.Location = new Point(70, 82);
    this.button_5.Name = Module.a("ힴ슶춸쾺튼톾\uF3C0", 15);
    this.button_5.Size = new Size(75, 23);
    this.button_5.TabIndex = 11;
    this.button_5.Text = Module.a("\uDBCCⷭ", 15);
    this.button_5.UseVisualStyleBackColor = true;
    this.button_5.Click += new EventHandler(this.button_5_Click);
    this.AutoScaleDimensions = new SizeF(6f, 12f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(349, 133);
    this.ControlBox = false;
    this.Controls.Add((Control) this.button_4);
    this.Controls.Add((Control) this.button_5);
    this.Controls.Add((Control) this.button_3);
    this.Controls.Add((Control) this.button_0);
    this.Controls.Add((Control) this.button_1);
    this.Controls.Add((Control) this.button_2);
    this.Controls.Add((Control) this.textBox_0);
    this.Controls.Add((Control) this.label_0);
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Name = Module.a("\uEFB4\uDFB6\uD8B8햺즼횾꓀鳂ꛄ꓆", 15);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = Module.a("\uEFB4\uDFB6\uD8B8햺즼횾꓀鳂ꛄ꓆", 15);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public m()
  {
    this.method_0();
    this.int_2 = 1;
    this.textBox_0.Text = this.int_2.ToString();
    this.Text = m.string_0;
  }

  private void button_1_Click(object sender, EventArgs e)
  {
    if (this.int_2 < m.int_0)
      ++this.int_2;
    this.textBox_0.Text = this.int_2.ToString();
  }

  private void button_0_Click(object sender, EventArgs e)
  {
    if (this.int_2 > 1)
      --this.int_2;
    this.textBox_0.Text = this.int_2.ToString();
  }

  private void button_2_Click(object sender, EventArgs e)
  {
    this.int_2 = 1;
    this.textBox_0.Text = this.int_2.ToString();
  }

  private void button_3_Click(object sender, EventArgs e)
  {
    this.int_2 = m.int_0;
    this.textBox_0.Text = this.int_2.ToString();
  }

  private void method_1(string string_1)
  {
    MessageDialog aa = new MessageDialog();
    aa.label_0.Text = string_1;
    int num = (int) aa.ShowDialog();
  }

  private void textBox_0_TextChanged(object sender, EventArgs e)
  {
    int int_0 = 4;
    int int32;
    try
    {
      int32 = Convert.ToInt32(this.textBox_0.Text);
    }
    catch
    {
      if (c.useEnglishLanguage)
        this.method_1(Module.a("囹\uD8AB쾭슯욱钳\uF0B5쪷\uDBB9톻\uDBBD\uE0BF뇁ꇃ닅볇ꏉꋋ꧍\uF0CF럑ꛓꓕ럗꣙\uFDDB", int_0));
      else
        this.method_1(Module.a("\uDD24柲觳ฤ\uDCCE맽헞훏뭆", int_0));
      this.textBox_0.Focus();
      return;
    }
    if (int32 <= m.int_0 && int32 >= 1)
    {
      this.int_2 = int32;
    }
    else
    {
      if (c.useEnglishLanguage)
        this.method_1(Module.a("囹\uD8AB쾭슯욱钳\uF0B5쪷\uDBB9톻\uDBBD\uE0BF뇁ꇃ닅볇ꏉꋋ꧍\uF0CF럑ꛓꓕ럗꣙\uFDDB", int_0));
      else
        this.method_1(Module.a("\uDD24柲觳ฤ\uDCCE맽헞훏뭆", int_0));
      this.textBox_0.Focus();
    }
  }

  private void button_5_Click(object sender, EventArgs e)
  {
    int int_0 = 4;
    int int32;
    try
    {
      int32 = Convert.ToInt32(this.textBox_0.Text);
    }
    catch
    {
      if (c.useEnglishLanguage)
        this.method_1(Module.a("囹\uD8AB쾭슯욱钳\uF0B5쪷\uDBB9톻\uDBBD\uE0BF뇁ꇃ닅볇ꏉꋋ꧍\uF0CF럑ꛓꓕ럗꣙\uFDDB", int_0));
      else
        this.method_1(Module.a("\uDD24柲觳ฤ\uDCCE맽헞훏뭆", int_0));
      this.textBox_0.Focus();
      return;
    }
    if (int32 <= m.int_0 && int32 >= 1)
    {
      m.int_1 = int32 - 1;
      this.DialogResult = DialogResult.OK;
    }
    else
    {
      if (c.useEnglishLanguage)
        this.method_1(Module.a("囹\uD8AB쾭슯욱钳\uF0B5쪷\uDBB9톻\uDBBD\uE0BF뇁ꇃ닅볇ꏉꋋ꧍\uF0CF럑ꛓꓕ럗꣙\uFDDB", int_0));
      else
        this.method_1(Module.a("\uDD24柲觳ฤ\uDCCE맽헞훏뭆", int_0));
      this.textBox_0.Focus();
    }
  }

  private void button_4_Click(object sender, EventArgs e) => this.Close();

  [SpecialName]
  private static void old_acctor_mc()
  {
    m.int_0 = 1;
    m.string_0 = "";
    m.int_1 = 1;
  }
}
