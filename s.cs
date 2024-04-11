// Decompiled with JetBrains decompiler
// Type: s
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class s : Form
{
  private IContainer icontainer_0;
  private GroupBox groupBox_0;
  private TextBox textBox_0;
  private Label label_0;
  private Label label_1;
  private Button button_0;
  private Label label_2;
  private TextBox textBox_1;
  private Label label_3;
  private RadioButton radioButton_0;
  private RadioButton radioButton_1;
  private Label label_4;
  private Button button_1;
  public static byte byte_0;

  static s() => s.old_acctor_mc();

    protected override void Dispose(bool disposing)
    {
        if (disposing && this.icontainer_0 != null)
            this.icontainer_0.Dispose();

        base.Dispose(disposing);
    }

    private void method_0()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (s));
    this.groupBox_0 = new GroupBox();
    this.label_4 = new Label();
    this.radioButton_0 = new RadioButton();
    this.radioButton_1 = new RadioButton();
    this.label_3 = new Label();
    this.textBox_1 = new TextBox();
    this.label_2 = new Label();
    this.label_1 = new Label();
    this.textBox_0 = new TextBox();
    this.label_0 = new Label();
    this.button_0 = new Button();
    this.button_1 = new Button();
    this.groupBox_0.SuspendLayout();
    this.SuspendLayout();
    this.groupBox_0.AccessibleDescription = (string) null;
    this.groupBox_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.groupBox_0, Module.a("\uD7AF삱\uDBB3쎵좷\uF8B9펻욽\uF1BF", 10));
    this.groupBox_0.BackgroundImage = (Image) null;
    this.groupBox_0.Controls.Add((Control) this.label_4);
    this.groupBox_0.Controls.Add((Control) this.radioButton_0);
    this.groupBox_0.Controls.Add((Control) this.radioButton_1);
    this.groupBox_0.Controls.Add((Control) this.label_3);
    this.groupBox_0.Controls.Add((Control) this.textBox_1);
    this.groupBox_0.Controls.Add((Control) this.label_2);
    this.groupBox_0.Controls.Add((Control) this.label_1);
    this.groupBox_0.Controls.Add((Control) this.textBox_0);
    this.groupBox_0.Controls.Add((Control) this.label_0);
    this.groupBox_0.Font = (Font) null;
    this.groupBox_0.Name = Module.a("\uD7AF삱\uDBB3쎵좷\uF8B9펻욽\uF1BF", 10);
    this.groupBox_0.TabStop = false;
    this.label_4.AccessibleDescription = (string) null;
    this.label_4.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_4, Module.a("\uDCAF펱횳펵풷边", 10));
    this.label_4.Font = (Font) null;
    this.label_4.Name = Module.a("\uDCAF펱횳펵풷边", 10);
    this.radioButton_0.AccessibleDescription = (string) null;
    this.radioButton_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.radioButton_0, Module.a("슯펱킳\uDFB5ힷ\uF8B9즻쪽뒿귁\uAAC3\uF4C5", 10));
    this.radioButton_0.BackgroundImage = (Image) null;
    this.radioButton_0.Font = (Font) null;
    this.radioButton_0.Name = Module.a("슯펱킳\uDFB5ힷ\uF8B9즻쪽뒿귁\uAAC3\uF4C5", 10);
    this.radioButton_0.UseVisualStyleBackColor = true;
    this.radioButton_1.AccessibleDescription = (string) null;
    this.radioButton_1.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.radioButton_1, Module.a("슯펱킳\uDFB5ힷ\uF8B9즻쪽뒿귁\uAAC3\uF7C5", 10));
    this.radioButton_1.BackgroundImage = (Image) null;
    this.radioButton_1.Checked = true;
    this.radioButton_1.Font = (Font) null;
    this.radioButton_1.Name = Module.a("슯펱킳\uDFB5ힷ\uF8B9즻쪽뒿귁\uAAC3\uF7C5", 10);
    this.radioButton_1.TabStop = true;
    this.radioButton_1.UseVisualStyleBackColor = true;
    this.label_3.AccessibleDescription = (string) null;
    this.label_3.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_3, Module.a("\uDCAF펱횳펵풷躹", 10));
    this.label_3.Font = (Font) null;
    this.label_3.Name = Module.a("\uDCAF펱횳펵풷躹", 10);
    this.textBox_1.AccessibleDescription = (string) null;
    this.textBox_1.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.textBox_1, Module.a("쒯ힱ첳습覆햹쒻貽", 10));
    this.textBox_1.BackgroundImage = (Image) null;
    this.textBox_1.Font = (Font) null;
    this.textBox_1.Name = Module.a("쒯ힱ첳습覆햹쒻貽", 10);
    this.label_2.AccessibleDescription = (string) null;
    this.label_2.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_2, Module.a("\uDCAF펱횳펵풷覹", 10));
    this.label_2.Font = (Font) null;
    this.label_2.Name = Module.a("\uDCAF펱횳펵풷覹", 10);
    this.label_1.AccessibleDescription = (string) null;
    this.label_1.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_1, Module.a("\uDCAF펱횳펵풷袹", 10));
    this.label_1.Font = (Font) null;
    this.label_1.Name = Module.a("\uDCAF펱횳펵풷袹", 10);
    this.textBox_0.AccessibleDescription = (string) null;
    this.textBox_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.textBox_0, Module.a("쒯ힱ첳습覆햹쒻辽", 10));
    this.textBox_0.BackgroundImage = (Image) null;
    this.textBox_0.Font = (Font) null;
    this.textBox_0.Name = Module.a("쒯ힱ첳습覆햹쒻辽", 10);
    this.label_0.AccessibleDescription = (string) null;
    this.label_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_0, Module.a("\uDCAF펱횳펵풷讹", 10));
    this.label_0.Font = (Font) null;
    this.label_0.Name = Module.a("\uDCAF펱횳펵풷讹", 10);
    this.button_0.AccessibleDescription = (string) null;
    this.button_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.button_0, Module.a("튯잱삳습ힷ풹趻", 10));
    this.button_0.BackgroundImage = (Image) null;
    this.button_0.Font = (Font) null;
    this.button_0.Name = Module.a("튯잱삳습ힷ풹趻", 10);
    this.button_0.UseVisualStyleBackColor = true;
    this.button_0.Click += new EventHandler(this.button_0_Click);
    this.button_1.AccessibleDescription = (string) null;
    this.button_1.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.button_1, Module.a("튯잱삳습ힷ풹躻", 10));
    this.button_1.BackgroundImage = (Image) null;
    this.button_1.Font = (Font) null;
    this.button_1.Name = Module.a("튯잱삳습ힷ풹躻", 10);
    this.button_1.UseVisualStyleBackColor = true;
    this.button_1.Click += new EventHandler(this.button_1_Click);
    this.AccessibleDescription = (string) null;
    this.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this, Module.a("钯욱\uDCB3\uDFB5쮷", 10));
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackgroundImage = (Image) null;
    this.ControlBox = false;
    this.Controls.Add((Control) this.button_1);
    this.Controls.Add((Control) this.button_0);
    this.Controls.Add((Control) this.groupBox_0);
    this.Font = (Font) null;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Icon = (Icon) null;
    this.Name = Module.a("\uE8AF\uDBB1햳\uD8B5\uE2B7특햻ﶽꦿ釁곃독", 10);
    this.groupBox_0.ResumeLayout(false);
    this.groupBox_0.PerformLayout();
    this.ResumeLayout(false);
  }

  public s() => this.method_0();

  private void method_1(string string_0)
  {
    MessageDialog aa = new MessageDialog();
    aa.label_0.Text = string_0;
    int num = (int) aa.ShowDialog();
  }

  private bool method_2(string string_0)
  {
    char[] chArray = new char[string_0.Length];
    char[] charArray = string_0.ToCharArray();
    for (int index = 0; index < charArray.Length; ++index)
    {
      if (charArray[index] < '0' || charArray[index] > '9')
        return false;
    }
    return true;
  }

  private void button_0_Click(object sender, EventArgs e)
  {
    int int_0 = 15;
    if (this.textBox_1.Text.Length != 6)
    {
      this.method_1(Module.a("\uF0B4얶쮸풺쾼鎾ꣀ귂뗄닆뷈\uEBCA\uFBCC\uEFCE뗐뫒닔뻖귘\uA8DAﳜ", int_0));
      this.textBox_1.Focus();
    }
    else if (!this.method_2(this.textBox_1.Text))
    {
      this.method_1(Module.a("\uF0B4얶쮸풺쾼鎾ꣀ귂뗄닆뷈\uEBCA\uFBCC\uEFCE뗐뫒닔뻖귘\uA8DAﳜ", int_0));
      this.textBox_1.Focus();
    }
    else
    {
      string str = '1'.ToString() + this.textBox_1.Text;
      int int32_1;
      try
      {
        int32_1 = Convert.ToInt32(str);
      }
      catch
      {
        this.method_1(Module.a("\uF0B4얶쮸풺쾼鎾ꣀ귂뗄닆뷈\uEBCA\uFBCC\uEFCE뗐뫒닔뻖귘\uA8DAﳜ", int_0));
        this.textBox_1.Focus();
        return;
      }
      int int32_2;
      try
      {
        int32_2 = Convert.ToInt32(this.textBox_0.Text);
      }
      catch
      {
        this.method_1(Module.a("\uF0B4얶쮸풺쾼麾", int_0));
        this.textBox_0.Focus();
        return;
      }
      if (int32_2 >= 1 && int32_2 <= 9999)
      {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Title = Module.a("\uE6B4횶쾸\uDEBA鶼\uDEBE닀\uEDC2\uEBC4\uE9C6", int_0);
        saveFileDialog.AddExtension = true;
        saveFileDialog.DefaultExt = Module.a("\uD9B4튶\uDDB8", int_0);
        saveFileDialog.Filter = Module.a("領튶\uDDB8鎺鞼醾귀ꛂꇄ\uEEC6뗈\uE1CA\uE3CCꏎ듐럒꧔雖뗘럚\uFDDC駞裠迢胤쿦쏨엪쟬웮跰\uD9F2\uDBF4\uDDF6", int_0);
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
          FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write);
          BufferedStream bufferedStream = new BufferedStream((Stream) fileStream);
          byte[] buffer = new byte[512];
          new Random().NextBytes(buffer);
          buffer[0] = (byte) 114;
          buffer[1] = (byte) 122;
          buffer[2] = (byte) 98;
          buffer[3] = (byte) 118;
          buffer[4] = (byte) 48;
          buffer[5] = (byte) 48;
          buffer[6] = (byte) 49;
          if (this.radioButton_1.Checked)
          {
            buffer[35] = (byte) 42;
            buffer[36] = (byte) 162;
          }
          else
          {
            buffer[35] = (byte) 53;
            buffer[36] = (byte) 83;
          }
          buffer[37] = (byte) (int32_1 / 65536);
          int num = int32_1 % 65536;
          buffer[38] = (byte) (num / 256);
          buffer[39] = (byte) (num % 256);
          buffer[40] = (byte) (int32_2 / 256);
          buffer[41] = (byte) (int32_2 % 256);
          buffer[42] = (byte) 0;
          bufferedStream.Write(buffer, 0, 512);
          bufferedStream.Flush();
          bufferedStream.Close();
          fileStream.Close();
        }
        this.Close();
      }
      else
      {
        this.method_1(Module.a("ﲴ\uD9B6즸캺즼龾蓀뇂럄\uA8C6믈\uE7CA\uE5CCﻎ연\uEAD2\uECD4\uEED6\uE0D8\uF2DA", int_0));
        this.textBox_0.Focus();
      }
    }
  }

  private void button_1_Click(object sender, EventArgs e) => this.Close();

  [SpecialName]
  private static void old_acctor_mc() => s.byte_0 = (byte) 50;
}
