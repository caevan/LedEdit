// Decompiled with JetBrains decompiler
// Type: ab
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using SwfDotNet.IO;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class ab : Form
{
  public static int int_0;
  public static string string_0;
  public static int int_1;
  public static int int_2;
  public static int int_3;
  private int int_4;
  private int int_5;
  private IContainer icontainer_0;
  private GroupBox groupBox_0;
  private Button button_0;
  private TextBox textBox_0;
  private Label label_0;
  private Button button_1;
  private Button button_2;
  private Button button_3;
  private TextBox textBox_1;
  private Label label_1;
  private Button button_4;
  private Button button_5;
  private Button button_6;
  private Button button_7;

  static ab() => ab.old_acctor_mc();

  public ab()
  {
    this.method_1();
    this.int_4 = 1;
    this.int_5 = ab.int_0;
    this.textBox_0.Text = this.int_4.ToString();
    this.textBox_1.Text = this.int_5.ToString();
    this.Text = ab.string_0;
  }

  private void button_1_Click(object sender, EventArgs e)
  {
    int int_0 = 1;
    int int32_1;
    try
    {
      int32_1 = Convert.ToInt32(this.textBox_0.Text);
    }
    catch
    {
      if (c.useEnglishLanguage)
        this.method_0(Module.a("\uF4A6\uDDA8쪪\uDFAC\uDBAE醰\uF5B2잴횶풸\uDEBA鶼횾닀\uE3C2뛄ꋆ뷈\uEBCA\uA4CCꇎ닐볒\uA7D4ꗖ볘룚\uA9DC돞飠싢", int_0));
      else
        this.method_0(Module.a("퀫拱賴ጧ쇑볾탙\uDBCC뙉", int_0));
      this.textBox_0.Focus();
      return;
    }
    if (int32_1 <= ab.int_0 && int32_1 >= 1)
    {
      ab.int_2 = int32_1 - 1;
      int int32_2;
      try
      {
        int32_2 = Convert.ToInt32(this.textBox_1.Text);
      }
      catch
      {
        if (c.useEnglishLanguage)
          this.method_0(Module.a("\uE2A6잨쾪趬\uE9AE쎰튲\uD8B4튶馸튺캼龾닀ꛂ뇄\uE7C6ꃈꗊ껌ꃎꏐꇒ냔듖귘럚ꓜﻞ", int_0));
        else
          this.method_0(Module.a("瓘\uF6CF賴ጧ쇑볾탙\uDBCC뙉", int_0));
        this.textBox_1.Focus();
        return;
      }
      if (int32_2 <= ab.int_0 && int32_2 >= 1)
      {
        ab.int_3 = int32_2 - 1;
        int num = ab.int_3 - ab.int_2 + 1;
        if (ab.int_1 == 1 && num >= ab.int_0)
        {
          if (c.useEnglishLanguage)
            this.method_0(Module.a("\uE4A6좨얪趬솮\uDEB0잲閴풶첸쾺鶼\uDEBE귀꿂\uE5C4돆ꇈ껊\uEDCC\uA9CEꏐ닒룔닖\uAAD8\uFADA", int_0));
          else
            this.method_0(Module.a("ꫨ吨쇸餡\uEFCC룗铬둋", int_0));
        }
        else if (ab.int_1 == 2 && num >= ab.int_0)
        {
          if (c.useEnglishLanguage)
            this.method_0(Module.a("\uE4A6좨얪趬솮\uDEB0잲閴펶\uDCB8ힺ\uD8BC쮾꓀\uE3C2꓄ꯆꗈ\uEBCA만\uA7CE듐\uF3D2돔ꗖ룘뛚룜곞샠", int_0));
          else
            this.method_0(Module.a("ꫨ吨诸줺\uEFCC룗铬둋", int_0));
        }
        else
          this.DialogResult = DialogResult.OK;
      }
      else
      {
        if (c.useEnglishLanguage)
          this.method_0(Module.a("\uE2A6잨쾪趬\uE9AE쎰튲\uD8B4튶馸튺캼龾닀ꛂ뇄\uE7C6ꃈꗊ껌ꃎꏐꇒ냔듖귘럚ꓜﻞ", int_0));
        else
          this.method_0(Module.a("瓘\uF6CF賴ጧ쇑볾탙\uDBCC뙉", int_0));
        this.textBox_1.Focus();
      }
    }
    else
    {
      if (c.useEnglishLanguage)
        this.method_0(Module.a("\uF4A6\uDDA8쪪\uDFAC\uDBAE醰\uF5B2잴횶풸\uDEBA鶼횾닀\uE3C2뛄ꋆ뷈\uEBCA\uA4CCꇎ닐볒\uA7D4ꗖ볘룚\uA9DC돞飠싢", int_0));
      else
        this.method_0(Module.a("퀫拱賴ጧ쇑볾탙\uDBCC뙉", int_0));
      this.textBox_0.Focus();
    }
  }

  private void button_2_Click(object sender, EventArgs e) => this.Close();

  private void method_0(string string_1)
  {
    MessageDialog aa = new MessageDialog();
    aa.label_0.Text = string_1;
    int num = (int) aa.ShowDialog();
  }

  private void textBox_0_TextChanged(object sender, EventArgs e)
  {
    int int_0 = 17;
    int int32;
    try
    {
      int32 = Convert.ToInt32(this.textBox_0.Text);
    }
    catch
    {
      if (c.useEnglishLanguage)
        this.method_0(Module.a("\uE4B6춸\uDABA쾼쮾\uE1C0藂럄ꛆ\uA4C8껊\uEDCCꛎꋐ\uF3D2ꛔ닖귘ﯚ드뇞苠賢韤闦賨裪駬菮裰틲", int_0));
      else
        this.method_0(Module.a("쀻狡鳤̷퇁첎ꂩꮼ옹", int_0));
      this.textBox_0.Focus();
      return;
    }
    if (int32 <= ab.int_0 && int32 >= 1)
    {
      this.int_4 = int32;
    }
    else
    {
      if (c.useEnglishLanguage)
        this.method_0(Module.a("\uE4B6춸\uDABA쾼쮾\uE1C0藂럄ꛆ\uA4C8껊\uEDCCꛎꋐ\uF3D2ꛔ닖귘ﯚ드뇞苠賢韤闦賨裪駬菮裰틲", int_0));
      else
        this.method_0(Module.a("쀻狡鳤̷퇁첎ꂩꮼ옹", int_0));
      this.textBox_0.Focus();
    }
  }

  private void textBox_1_TextChanged(object sender, EventArgs e)
  {
    int int_0 = 9;
    int int32;
    try
    {
      int32 = Convert.ToInt32(this.textBox_1.Text);
    }
    catch
    {
      if (c.useEnglishLanguage)
        this.method_0(Module.a("\uEAAE\uDFB0ힲ閴\uF1B6쮸\uDABA킼\uDABE\uE1C0ꫂ뛄\uE7C6뫈껊만\uEFCE룐뷒뛔룖ꯘ\uA9DA룜볞闠迢鳤웦", int_0));
      else
        this.method_0(Module.a("糐\uEED7铬ି\uD9C9듶\uD8D1폄빁", int_0));
      this.textBox_1.Focus();
      return;
    }
    if (int32 <= ab.int_0 && int32 >= 1)
    {
      this.int_5 = int32;
    }
    else
    {
      if (c.useEnglishLanguage)
        this.method_0(Module.a("\uEAAE\uDFB0ힲ閴\uF1B6쮸\uDABA킼\uDABE\uE1C0ꫂ뛄\uE7C6뫈껊만\uEFCE룐뷒뛔룖ꯘ\uA9DA룜볞闠迢鳤웦", int_0));
      else
        this.method_0(Module.a("糐\uEED7铬ି\uD9C9듶\uD8D1폄빁", int_0));
      this.textBox_1.Focus();
    }
  }

  private void button_0_Click(object sender, EventArgs e)
  {
    this.int_4 = 1;
    this.textBox_0.Text = this.int_4.ToString();
  }

  private void button_3_Click(object sender, EventArgs e)
  {
    this.int_5 = ab.int_0;
    this.textBox_1.Text = this.int_5.ToString();
  }

  private void button_5_Click(object sender, EventArgs e)
  {
    if (this.int_4 < ab.int_0)
      ++this.int_4;
    this.textBox_0.Text = this.int_4.ToString();
  }

  private void button_4_Click(object sender, EventArgs e)
  {
    if (this.int_4 > 1)
      --this.int_4;
    this.textBox_0.Text = this.int_4.ToString();
  }

  private void button_7_Click(object sender, EventArgs e)
  {
    if (this.int_5 < ab.int_0)
      ++this.int_5;
    this.textBox_1.Text = this.int_5.ToString();
  }

  private void button_6_Click(object sender, EventArgs e)
  {
    if (this.int_5 > 1)
      --this.int_5;
    this.textBox_1.Text = this.int_5.ToString();
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

  private void method_1()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ab));
    this.groupBox_0 = new GroupBox();
    this.button_3 = new Button();
    this.textBox_1 = new TextBox();
    this.label_1 = new Label();
    this.button_0 = new Button();
    this.textBox_0 = new TextBox();
    this.label_0 = new Label();
    this.button_1 = new Button();
    this.button_2 = new Button();
    this.button_5 = new Button();
    this.button_4 = new Button();
    this.button_6 = new Button();
    this.button_7 = new Button();
    this.groupBox_0.SuspendLayout();
    this.SuspendLayout();
    this.groupBox_0.Controls.Add((Control) this.button_6);
    this.groupBox_0.Controls.Add((Control) this.button_7);
    this.groupBox_0.Controls.Add((Control) this.button_4);
    this.groupBox_0.Controls.Add((Control) this.button_5);
    this.groupBox_0.Controls.Add((Control) this.button_3);
    this.groupBox_0.Controls.Add((Control) this.textBox_1);
    this.groupBox_0.Controls.Add((Control) this.label_1);
    this.groupBox_0.Controls.Add((Control) this.button_0);
    this.groupBox_0.Controls.Add((Control) this.textBox_0);
    this.groupBox_0.Controls.Add((Control) this.label_0);
    this.groupBox_0.Location = new Point(12, 12);
    this.groupBox_0.Name = Module.a("쾧\uD8A9쎫\uDBAD삯\uF0B1\uDBB3캵覷", 2);
    this.groupBox_0.Size = new Size(277, 110);
    this.groupBox_0.TabIndex = 0;
    this.groupBox_0.TabStop = false;
    this.button_3.Location = new Point(212, 68);
    this.button_3.Name = Module.a("쪧\uDFA9\uD8AB\uDAAD\uDFAF\uDCB1肳", 2);
    this.button_3.Size = new Size(50, 23);
    this.button_3.TabIndex = 7;
    this.button_3.Text = Module.a("菀跷", 2);
    this.button_3.UseVisualStyleBackColor = true;
    this.button_3.Click += new EventHandler(this.button_3_Click);
    this.textBox_1.Location = new Point(84, 70);
    this.textBox_1.Name = Module.a("\uDCA7쾩풫\uDAAD\uF2AF\uDDB1첳蒵", 2);
    this.textBox_1.Size = new Size(86, 21);
    this.textBox_1.TabIndex = 5;
    this.textBox_1.Text = Module.a("馧", 2);
    this.textBox_1.TextChanged += new EventHandler(this.textBox_1_TextChanged);
    this.label_1.AutoSize = true;
    this.label_1.Location = new Point(17, 77);
    this.label_1.Name = Module.a("쒧쮩캫쮭\uDCAF肱", 2);
    this.label_1.Size = new Size(47, 12);
    this.label_1.TabIndex = 4;
    this.label_1.Text = Module.a("篙\uF5CE诵钭", 2);
    this.button_0.Location = new Point(212, 21);
    this.button_0.Name = Module.a("쪧\uDFA9\uD8AB\uDAAD\uDFAF\uDCB1薳", 2);
    this.button_0.Size = new Size(50, 23);
    this.button_0.TabIndex = 3;
    this.button_0.Text = Module.a("㸾跷", 2);
    this.button_0.UseVisualStyleBackColor = true;
    this.button_0.Click += new EventHandler(this.button_0_Click);
    this.textBox_0.Location = new Point(84, 21);
    this.textBox_0.Name = Module.a("\uDCA7쾩풫\uDAAD\uF2AF\uDDB1첳螵", 2);
    this.textBox_0.Size = new Size(86, 21);
    this.textBox_0.TabIndex = 1;
    this.textBox_0.Text = Module.a("馧", 2);
    this.textBox_0.TextChanged += new EventHandler(this.textBox_0_TextChanged);
    this.label_0.AutoSize = true;
    this.label_0.Location = new Point(17, 24);
    this.label_0.Name = Module.a("쒧쮩캫쮭\uDCAF莱", 2);
    this.label_0.Size = new Size(47, 12);
    this.label_0.TabIndex = 0;
    this.label_0.Text = Module.a("\uDF2A懰诵钭", 2);
    this.button_1.Location = new Point(310, 36);
    this.button_1.Name = Module.a("쪧\uDFA9\uD8AB\uDAAD\uDFAF\uDCB1蚳", 2);
    this.button_1.Size = new Size(75, 23);
    this.button_1.TabIndex = 1;
    this.button_1.Text = Module.a("웟ヲ", 2);
    this.button_1.UseVisualStyleBackColor = true;
    this.button_1.Click += new EventHandler(this.button_1_Click);
    this.button_2.Location = new Point(310, 82);
    this.button_2.Name = Module.a("쪧\uDFA9\uD8AB\uDAAD\uDFAF\uDCB1螳", 2);
    this.button_2.Size = new Size(75, 23);
    this.button_2.TabIndex = 2;
    this.button_2.Text = Module.a("维⋄", 2);
    this.button_2.UseVisualStyleBackColor = true;
    this.button_2.Click += new EventHandler(this.button_2_Click);
    this.button_5.BackgroundImage = (Image) componentResourceManager.GetObject(Module.a("쪧\uDFA9\uD8AB\uDAAD\uDFAF\uDCB1膳颵覆\uDBB9\uDFBB햽\uA7BF냁ꯃ독ꛇ껉藋ꏍ뇏뗑뇓", 2));
    this.button_5.BackgroundImageLayout = ImageLayout.Stretch;
    this.button_5.Location = new Point(176, 18);
    this.button_5.Name = Module.a("쪧\uDFA9\uD8AB\uDAAD\uDFAF\uDCB1膳", 2);
    this.button_5.Size = new Size(21, 15);
    this.button_5.TabIndex = 3;
    this.button_5.UseVisualStyleBackColor = true;
    this.button_5.Click += new EventHandler(this.button_5_Click);
    this.button_4.BackgroundImage = (Image) componentResourceManager.GetObject(Module.a("쪧\uDFA9\uD8AB\uDAAD\uDFAF\uDCB1芳颵覆\uDBB9\uDFBB햽\uA7BF냁ꯃ독ꛇ껉藋ꏍ뇏뗑뇓", 2));
    this.button_4.BackgroundImageLayout = ImageLayout.Stretch;
    this.button_4.Location = new Point(176, 34);
    this.button_4.Name = Module.a("쪧\uDFA9\uD8AB\uDAAD\uDFAF\uDCB1芳", 2);
    this.button_4.Size = new Size(21, 13);
    this.button_4.TabIndex = 4;
    this.button_4.UseVisualStyleBackColor = true;
    this.button_4.Click += new EventHandler(this.button_4_Click);
    this.button_6.BackgroundImage = (Image) componentResourceManager.GetObject(Module.a("쪧\uDFA9\uD8AB\uDAAD\uDFAF\uDCB1莳颵覆\uDBB9\uDFBB햽\uA7BF냁ꯃ독ꛇ껉藋ꏍ뇏뗑뇓", 2));
    this.button_6.BackgroundImageLayout = ImageLayout.Stretch;
    this.button_6.Location = new Point(176, 83);
    this.button_6.Name = Module.a("쪧\uDFA9\uD8AB\uDAAD\uDFAF\uDCB1莳", 2);
    this.button_6.Size = new Size(21, 13);
    this.button_6.TabIndex = 9;
    this.button_6.UseVisualStyleBackColor = true;
    this.button_6.Click += new EventHandler(this.button_6_Click);
    this.button_7.BackgroundImage = (Image) componentResourceManager.GetObject(Module.a("쪧\uDFA9\uD8AB\uDAAD\uDFAF\uDCB1貳颵覆\uDBB9\uDFBB햽\uA7BF냁ꯃ독ꛇ껉藋ꏍ뇏뗑뇓", 2));
    this.button_7.BackgroundImageLayout = ImageLayout.Stretch;
    this.button_7.Location = new Point(176, 67);
    this.button_7.Name = Module.a("쪧\uDFA9\uD8AB\uDAAD\uDFAF\uDCB1貳", 2);
    this.button_7.Size = new Size(21, 15);
    this.button_7.TabIndex = 8;
    this.button_7.UseVisualStyleBackColor = true;
    this.button_7.Click += new EventHandler(this.button_7_Click);
    this.AutoScaleDimensions = new SizeF(6f, 12f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(398, 140);
    this.ControlBox = false;
    this.Controls.Add((Control) this.button_2);
    this.Controls.Add((Control) this.button_1);
    this.Controls.Add((Control) this.groupBox_0);
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Name = Module.a("\uEDA7캩얫\uDAAD\uEFAF쪱펳", 2);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = Module.a("\uEDA7캩얫\uDAAD\uEFAF쪱펳", 2);
    this.groupBox_0.ResumeLayout(false);
    this.groupBox_0.PerformLayout();
    this.ResumeLayout(false);
  }

  [SpecialName]
  private static void old_acctor_mc()
  {
    ab.int_0 = 1;
    ab.string_0 = "";
    ab.int_1 = 0;
    ab.int_2 = 1;
    ab.int_3 = 1;
  }
}
