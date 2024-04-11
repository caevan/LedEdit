// Decompiled with JetBrains decompiler
// Type: f
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

public class f : Form
{
  private IContainer icontainer_0;
  private Label label_0;
  private Label label_1;
  private Button button_0;
  private Button button_1;
  private Label label_2;
  private Button button_2;
  private TextBox textBox_0;
  private Label label_3;
  private ComboBox comboBox_0;
  private Label label_4;
  private ComboBox comboBox_1;
  private Label label_5;
  private TextBox textBox_1;
  private Label label_6;
  private Label label_7;
  private Label label_8;
  private ComboBox comboBox_2;
  private GroupBox groupBox_0;
  private Label label_9;
  private ComboBox comboBox_3;
  private Label label_10;
  private Label label_11;
  private ComboBox comboBox_4;
  private Label label_12;
  private Label label_13;
  private ComboBox comboBox_5;
  private Label label_14;
  private RadioButton radioButton_0;
  private RadioButton radioButton_1;
  private GroupBox groupBox_1;
  private RadioButton radioButton_2;
  private RadioButton radioButton_3;
  private GroupBox groupBox_2;
  private RadioButton radioButton_4;
  private RadioButton radioButton_5;
  private GroupBox groupBox_3;
  private RadioButton radioButton_6;
  private RadioButton radioButton_7;
  private RadioButton radioButton_8;
  private Label label_15;
  private Label label_16;
  private Label label_17;
  private GroupBox groupBox_4;
  private ListBox listBox_0;
  private Label label_18;
  private Button button_3;
  private Label label_19;
  private string string_0;
  private string string_1;
  private ArrayList arrayList_0;

    protected override void Dispose(bool disposing)
    {
        if (disposing && this.icontainer_0 != null)
            this.icontainer_0.Dispose();

        base.Dispose(disposing);
    }

    private void method_0()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (f));
    this.label_0 = new Label();
    this.label_1 = new Label();
    this.button_0 = new Button();
    this.button_1 = new Button();
    this.label_2 = new Label();
    this.button_2 = new Button();
    this.textBox_0 = new TextBox();
    this.label_3 = new Label();
    this.comboBox_0 = new ComboBox();
    this.comboBox_1 = new ComboBox();
    this.label_4 = new Label();
    this.groupBox_2 = new GroupBox();
    this.radioButton_4 = new RadioButton();
    this.radioButton_5 = new RadioButton();
    this.textBox_1 = new TextBox();
    this.label_6 = new Label();
    this.label_5 = new Label();
    this.label_7 = new Label();
    this.label_8 = new Label();
    this.comboBox_2 = new ComboBox();
    this.groupBox_0 = new GroupBox();
    this.comboBox_5 = new ComboBox();
    this.label_14 = new Label();
    this.label_13 = new Label();
    this.label_9 = new Label();
    this.comboBox_3 = new ComboBox();
    this.label_10 = new Label();
    this.label_11 = new Label();
    this.comboBox_4 = new ComboBox();
    this.label_12 = new Label();
    this.radioButton_0 = new RadioButton();
    this.radioButton_1 = new RadioButton();
    this.groupBox_1 = new GroupBox();
    this.radioButton_2 = new RadioButton();
    this.radioButton_3 = new RadioButton();
    this.groupBox_3 = new GroupBox();
    this.radioButton_7 = new RadioButton();
    this.radioButton_8 = new RadioButton();
    this.radioButton_6 = new RadioButton();
    this.label_15 = new Label();
    this.label_16 = new Label();
    this.label_17 = new Label();
    this.groupBox_4 = new GroupBox();
    this.listBox_0 = new ListBox();
    this.label_18 = new Label();
    this.button_3 = new Button();
    this.label_19 = new Label();
    this.groupBox_2.SuspendLayout();
    this.groupBox_0.SuspendLayout();
    this.groupBox_1.SuspendLayout();
    this.groupBox_3.SuspendLayout();
    this.groupBox_4.SuspendLayout();
    this.SuspendLayout();
    this.label_0.AccessibleDescription = (string) null;
    this.label_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_0, Module.a("\uD8B3ힵ\uDAB7\uDFB9킻貽", 14));
    this.label_0.Font = (Font) null;
    this.label_0.Name = Module.a("\uD8B3ힵ\uDAB7\uDFB9킻貽", 14);
    this.label_1.AccessibleDescription = (string) null;
    this.label_1.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_1, Module.a("\uD8B3ힵ\uDAB7\uDFB9킻辽", 14));
    this.label_1.Font = (Font) null;
    this.label_1.Name = Module.a("\uD8B3ힵ\uDAB7\uDFB9킻辽", 14);
    this.button_0.AccessibleDescription = (string) null;
    this.button_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.button_0, Module.a("횳쎵첷캹펻킽\uF1BF", 14));
    this.button_0.BackgroundImage = (Image) null;
    this.button_0.Name = Module.a("횳쎵첷캹펻킽\uF1BF", 14);
    this.button_0.UseVisualStyleBackColor = true;
    this.button_0.Click += new EventHandler(this.button_0_Click);
    this.button_1.AccessibleDescription = (string) null;
    this.button_1.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.button_1, Module.a("횳쎵첷캹펻킽\uF2BF", 14));
    this.button_1.BackgroundImage = (Image) null;
    this.button_1.Font = (Font) null;
    this.button_1.Name = Module.a("횳쎵첷캹펻킽\uF2BF", 14);
    this.button_1.UseVisualStyleBackColor = true;
    this.button_1.Click += new EventHandler(this.button_1_Click);
    this.label_2.AccessibleDescription = (string) null;
    this.label_2.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_2, Module.a("\uD8B3ힵ\uDAB7\uDFB9킻趽", 14));
    this.label_2.Font = (Font) null;
    this.label_2.Name = Module.a("\uD8B3ힵ\uDAB7\uDFB9킻趽", 14);
    this.button_2.AccessibleDescription = (string) null;
    this.button_2.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.button_2, Module.a("횳쎵첷캹펻킽\uF3BF", 14));
    this.button_2.BackgroundImage = (Image) null;
    this.button_2.DialogResult = DialogResult.Cancel;
    this.button_2.Name = Module.a("횳쎵첷캹펻킽\uF3BF", 14);
    this.button_2.UseVisualStyleBackColor = true;
    this.button_2.Click += new EventHandler(this.button_2_Click);
    this.textBox_0.AccessibleDescription = (string) null;
    this.textBox_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.textBox_0, Module.a("삳펵삷캹ﺻ톽뢿\uF1C1", 14));
    this.textBox_0.BackColor = SystemColors.ControlLightLight;
    this.textBox_0.BackgroundImage = (Image) null;
    this.textBox_0.Font = (Font) null;
    this.textBox_0.Name = Module.a("삳펵삷캹ﺻ톽뢿\uF1C1", 14);
    this.label_3.AccessibleDescription = (string) null;
    this.label_3.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_3, Module.a("\uD8B3ힵ\uDAB7\uDFB9킻誽", 14));
    this.label_3.Font = (Font) null;
    this.label_3.Name = Module.a("\uD8B3ힵ\uDAB7\uDFB9킻誽", 14);
    this.comboBox_0.AccessibleDescription = (string) null;
    this.comboBox_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.comboBox_0, Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3", 14));
    this.comboBox_0.BackgroundImage = (Image) null;
    this.comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
    this.comboBox_0.Font = (Font) null;
    this.comboBox_0.FormattingEnabled = true;
    this.comboBox_0.Items.AddRange(new object[30]
    {
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3\uE8C5臇뻉꧋ꏍꏏ", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3\uE8C5臇뻉꧋ꏍꏏ\uE0D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3\uE8C5臇뻉꧋ꏍꏏ\uE1D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3\uE8C5臇뻉꧋ꏍꏏ\uE6D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3\uE8C5臇뻉꧋ꏍꏏ\uE7D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3\uE8C5臇뻉꧋ꏍꏏ\uE4D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3\uE8C5臇뻉꧋ꏍꏏ\uE5D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3\uE8C5臇뻉꧋ꏍꏏ\uEAD1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3\uE8C5臇뻉꧋ꏍꏏ\uEBD1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1\uE4D3", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1\uE5D3", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1\uE6D3", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1\uE7D3", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1\uE0D3", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1\uE1D3", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1\uE2D3", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1\uE3D3", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1\uECD3", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1\uEDD3", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3\uE8C5臇뻉꧋ꏍꏏ\uE0D1\uE4D3", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3\uE8C5臇뻉꧋ꏍꏏ\uE0D1\uE5D3", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3\uE8C5臇뻉꧋ꏍꏏ\uE0D1\uE6D3", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3\uE8C5臇뻉꧋ꏍꏏ\uE0D1\uE7D3", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3\uE8C5臇뻉꧋ꏍꏏ\uE0D1\uE0D3", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3\uE8C5臇뻉꧋ꏍꏏ\uE0D1\uE1D3", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3\uE8C5臇뻉꧋ꏍꏏ\uE0D1\uE2D3", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3\uE8C5臇뻉꧋ꏍꏏ\uE0D1\uE3D3", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3\uE8C5臇뻉꧋ꏍꏏ\uE0D1\uECD3", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3\uE8C5臇뻉꧋ꏍꏏ\uE0D1\uEDD3", 14))
    });
    this.comboBox_0.Name = Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3", 14);
    this.comboBox_1.AccessibleDescription = (string) null;
    this.comboBox_1.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.comboBox_1, Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF6C3", 14));
    this.comboBox_1.BackgroundImage = (Image) null;
    this.comboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
    this.comboBox_1.Font = (Font) null;
    this.comboBox_1.FormattingEnabled = true;
    this.comboBox_1.Items.AddRange(new object[6]
    {
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF6C3\uE8C5臇뻉꧋ꏍꏏ", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF6C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF6C3\uE8C5臇뻉꧋ꏍꏏ\uE0D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF6C3\uE8C5臇뻉꧋ꏍꏏ\uE1D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF6C3\uE8C5臇뻉꧋ꏍꏏ\uE6D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF6C3\uE8C5臇뻉꧋ꏍꏏ\uE7D1", 14))
    });
    this.comboBox_1.Name = Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF6C3", 14);
    this.label_4.AccessibleDescription = (string) null;
    this.label_4.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_4, Module.a("\uD8B3ힵ\uDAB7\uDFB9킻讽", 14));
    this.label_4.Font = (Font) null;
    this.label_4.Name = Module.a("\uD8B3ힵ\uDAB7\uDFB9킻讽", 14);
    this.groupBox_2.AccessibleDescription = (string) null;
    this.groupBox_2.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.groupBox_2, Module.a("펳쒵ힷ쾹첻ﲽ꾿뫁\uF2C3", 14));
    this.groupBox_2.BackgroundImage = (Image) null;
    this.groupBox_2.Controls.Add((Control) this.radioButton_4);
    this.groupBox_2.Controls.Add((Control) this.radioButton_5);
    this.groupBox_2.Font = (Font) null;
    this.groupBox_2.Name = Module.a("펳쒵ힷ쾹첻ﲽ꾿뫁\uF2C3", 14);
    this.groupBox_2.TabStop = false;
    this.radioButton_4.AccessibleDescription = (string) null;
    this.radioButton_4.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.radioButton_4, Module.a("욳ힵ\uDCB7펹펻ﲽ떿뛁냃꧅ꛇﳉ", 14));
    this.radioButton_4.BackgroundImage = (Image) null;
    this.radioButton_4.Font = (Font) null;
    this.radioButton_4.Name = Module.a("욳ힵ\uDCB7펹펻ﲽ떿뛁냃꧅ꛇﳉ", 14);
    this.radioButton_4.UseVisualStyleBackColor = true;
    this.radioButton_5.AccessibleDescription = (string) null;
    this.radioButton_5.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.radioButton_5, Module.a("욳ힵ\uDCB7펹펻ﲽ떿뛁냃꧅ꛇ\uFFC9", 14));
    this.radioButton_5.BackgroundImage = (Image) null;
    this.radioButton_5.Checked = true;
    this.radioButton_5.Font = (Font) null;
    this.radioButton_5.Name = Module.a("욳ힵ\uDCB7펹펻ﲽ떿뛁냃꧅ꛇ\uFFC9", 14);
    this.radioButton_5.TabStop = true;
    this.radioButton_5.UseVisualStyleBackColor = true;
    this.textBox_1.AccessibleDescription = (string) null;
    this.textBox_1.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.textBox_1, Module.a("삳펵삷캹ﺻ톽뢿\uF3C1", 14));
    this.textBox_1.BackgroundImage = (Image) null;
    this.textBox_1.Font = (Font) null;
    this.textBox_1.Name = Module.a("삳펵삷캹ﺻ톽뢿\uF3C1", 14);
    this.textBox_1.ReadOnly = true;
    this.label_6.AccessibleDescription = (string) null;
    this.label_6.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_6, Module.a("\uD8B3ힵ\uDAB7\uDFB9킻辽\uF1BF", 14));
    this.label_6.Font = (Font) null;
    this.label_6.Name = Module.a("\uD8B3ힵ\uDAB7\uDFB9킻辽\uF1BF", 14);
    this.label_6.Click += new EventHandler(this.label_6_Click);
    this.label_5.AccessibleDescription = (string) null;
    this.label_5.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_5, Module.a("\uD8B3ힵ\uDAB7\uDFB9킻辽\uF0BF", 14));
    this.label_5.ForeColor = SystemColors.HotTrack;
    this.label_5.Name = Module.a("\uD8B3ힵ\uDAB7\uDFB9킻辽\uF0BF", 14);
    this.label_7.AccessibleDescription = (string) null;
    this.label_7.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_7, Module.a("\uD8B3ힵ\uDAB7\uDFB9킻辽\uF2BF", 14));
    this.label_7.Font = (Font) null;
    this.label_7.Name = Module.a("\uD8B3ힵ\uDAB7\uDFB9킻辽\uF2BF", 14);
    this.label_8.AccessibleDescription = (string) null;
    this.label_8.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_8, Module.a("\uD8B3ힵ\uDAB7\uDFB9킻辽\uF3BF", 14));
    this.label_8.Font = (Font) null;
    this.label_8.Name = Module.a("\uD8B3ힵ\uDAB7\uDFB9킻辽\uF3BF", 14);
    this.comboBox_2.AccessibleDescription = (string) null;
    this.comboBox_2.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.comboBox_2, Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF0C3", 14));
    this.comboBox_2.BackgroundImage = (Image) null;
    this.comboBox_2.Font = (Font) null;
    this.comboBox_2.FormattingEnabled = true;
    this.comboBox_2.Items.AddRange(new object[17]
    {
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF0C3\uE8C5臇뻉꧋ꏍꏏ", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF0C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF0C3\uE8C5臇뻉꧋ꏍꏏ\uE0D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF0C3\uE8C5臇뻉꧋ꏍꏏ\uE1D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF0C3\uE8C5臇뻉꧋ꏍꏏ\uE6D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF0C3\uE8C5臇뻉꧋ꏍꏏ\uE7D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF0C3\uE8C5臇뻉꧋ꏍꏏ\uE4D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF0C3\uE8C5臇뻉꧋ꏍꏏ\uE5D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF0C3\uE8C5臇뻉꧋ꏍꏏ\uEAD1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF0C3\uE8C5臇뻉꧋ꏍꏏ\uEBD1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF0C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1\uE4D3", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF0C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1\uE5D3", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF0C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1\uE6D3", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF0C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1\uE7D3", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF0C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1\uE0D3", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF0C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1\uE1D3", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF0C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1\uE2D3", 14))
    });
    this.comboBox_2.Name = Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF0C3", 14);
    this.comboBox_2.SelectedIndexChanged += new EventHandler(this.comboBox_2_SelectedIndexChanged);
    this.groupBox_0.AccessibleDescription = (string) null;
    this.groupBox_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.groupBox_0, Module.a("펳쒵ힷ쾹첻ﲽ꾿뫁\uF7C3", 14));
    this.groupBox_0.BackgroundImage = (Image) null;
    this.groupBox_0.Controls.Add((Control) this.comboBox_5);
    this.groupBox_0.Controls.Add((Control) this.label_14);
    this.groupBox_0.Controls.Add((Control) this.label_13);
    this.groupBox_0.Controls.Add((Control) this.label_9);
    this.groupBox_0.Controls.Add((Control) this.comboBox_3);
    this.groupBox_0.Controls.Add((Control) this.label_10);
    this.groupBox_0.Controls.Add((Control) this.label_11);
    this.groupBox_0.Controls.Add((Control) this.comboBox_4);
    this.groupBox_0.Controls.Add((Control) this.label_12);
    this.groupBox_0.Controls.Add((Control) this.label_8);
    this.groupBox_0.Controls.Add((Control) this.comboBox_2);
    this.groupBox_0.Controls.Add((Control) this.label_7);
    this.groupBox_0.Font = (Font) null;
    this.groupBox_0.Name = Module.a("펳쒵ힷ쾹첻ﲽ꾿뫁\uF7C3", 14);
    this.groupBox_0.TabStop = false;
    this.comboBox_5.AccessibleDescription = (string) null;
    this.comboBox_5.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.comboBox_5, Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF3C3", 14));
    this.comboBox_5.BackgroundImage = (Image) null;
    this.comboBox_5.Font = (Font) null;
    this.comboBox_5.FormattingEnabled = true;
    this.comboBox_5.Items.AddRange(new object[17]
    {
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF3C3\uE8C5臇뻉꧋ꏍꏏ", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF3C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF3C3\uE8C5臇뻉꧋ꏍꏏ\uE0D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF3C3\uE8C5臇뻉꧋ꏍꏏ\uE1D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF3C3\uE8C5臇뻉꧋ꏍꏏ\uE6D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF3C3\uE8C5臇뻉꧋ꏍꏏ\uE7D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF3C3\uE8C5臇뻉꧋ꏍꏏ\uE4D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF3C3\uE8C5臇뻉꧋ꏍꏏ\uE5D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF3C3\uE8C5臇뻉꧋ꏍꏏ\uEAD1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF3C3\uE8C5臇뻉꧋ꏍꏏ\uEBD1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF3C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1\uE4D3", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF3C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1\uE5D3", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF3C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1\uE6D3", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF3C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1\uE7D3", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF3C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1\uE0D3", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF3C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1\uE1D3", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF3C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1\uE2D3", 14))
    });
    this.comboBox_5.Name = Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF3C3", 14);
    this.comboBox_5.SelectedIndexChanged += new EventHandler(this.comboBox_5_SelectedIndexChanged);
    this.label_14.AccessibleDescription = (string) null;
    this.label_14.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_14, Module.a("\uD8B3ힵ\uDAB7\uDFB9킻辽樂", 14));
    this.label_14.Font = (Font) null;
    this.label_14.Name = Module.a("\uD8B3ힵ\uDAB7\uDFB9킻辽樂", 14);
    this.label_13.AccessibleDescription = (string) null;
    this.label_13.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_13, Module.a("\uD8B3ힵ\uDAB7\uDFB9킻辽\uF8BF", 14));
    this.label_13.Font = (Font) null;
    this.label_13.Name = Module.a("\uD8B3ힵ\uDAB7\uDFB9킻辽\uF8BF", 14);
    this.label_9.AccessibleDescription = (string) null;
    this.label_9.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_9, Module.a("\uD8B3ힵ\uDAB7\uDFB9킻辽\uF6BF", 14));
    this.label_9.Font = (Font) null;
    this.label_9.Name = Module.a("\uD8B3ힵ\uDAB7\uDFB9킻辽\uF6BF", 14);
    this.comboBox_3.AccessibleDescription = (string) null;
    this.comboBox_3.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.comboBox_3, Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF2C3", 14));
    this.comboBox_3.BackgroundImage = (Image) null;
    this.comboBox_3.Font = (Font) null;
    this.comboBox_3.FormattingEnabled = true;
    this.comboBox_3.Items.AddRange(new object[17]
    {
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF2C3\uE8C5臇뻉꧋ꏍꏏ", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF2C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF2C3\uE8C5臇뻉꧋ꏍꏏ\uE0D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF2C3\uE8C5臇뻉꧋ꏍꏏ\uE1D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF2C3\uE8C5臇뻉꧋ꏍꏏ\uE6D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF2C3\uE8C5臇뻉꧋ꏍꏏ\uE7D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF2C3\uE8C5臇뻉꧋ꏍꏏ\uE4D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF2C3\uE8C5臇뻉꧋ꏍꏏ\uE5D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF2C3\uE8C5臇뻉꧋ꏍꏏ\uEAD1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF2C3\uE8C5臇뻉꧋ꏍꏏ\uEBD1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF2C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1\uE4D3", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF2C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1\uE5D3", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF2C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1\uE6D3", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF2C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1\uE7D3", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF2C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1\uE0D3", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF2C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1\uE1D3", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF2C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1\uE2D3", 14))
    });
    this.comboBox_3.Name = Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF2C3", 14);
    this.comboBox_3.SelectedIndexChanged += new EventHandler(this.comboBox_3_SelectedIndexChanged);
    this.label_10.AccessibleDescription = (string) null;
    this.label_10.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_10, Module.a("\uD8B3ힵ\uDAB7\uDFB9킻辽\uF7BF", 14));
    this.label_10.Font = (Font) null;
    this.label_10.Name = Module.a("\uD8B3ힵ\uDAB7\uDFB9킻辽\uF7BF", 14);
    this.label_11.AccessibleDescription = (string) null;
    this.label_11.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_11, Module.a("\uD8B3ힵ\uDAB7\uDFB9킻辽\uF4BF", 14));
    this.label_11.Font = (Font) null;
    this.label_11.Name = Module.a("\uD8B3ힵ\uDAB7\uDFB9킻辽\uF4BF", 14);
    this.comboBox_4.AccessibleDescription = (string) null;
    this.comboBox_4.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.comboBox_4, Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF1C3", 14));
    this.comboBox_4.BackgroundImage = (Image) null;
    this.comboBox_4.Font = (Font) null;
    this.comboBox_4.FormattingEnabled = true;
    this.comboBox_4.Items.AddRange(new object[17]
    {
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF1C3\uE8C5臇뻉꧋ꏍꏏ", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF1C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF1C3\uE8C5臇뻉꧋ꏍꏏ\uE0D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF1C3\uE8C5臇뻉꧋ꏍꏏ\uE1D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF1C3\uE8C5臇뻉꧋ꏍꏏ\uE6D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF1C3\uE8C5臇뻉꧋ꏍꏏ\uE7D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF1C3\uE8C5臇뻉꧋ꏍꏏ\uE4D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF1C3\uE8C5臇뻉꧋ꏍꏏ\uE5D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF1C3\uE8C5臇뻉꧋ꏍꏏ\uEAD1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF1C3\uE8C5臇뻉꧋ꏍꏏ\uEBD1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF1C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1\uE4D3", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF1C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1\uE5D3", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF1C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1\uE6D3", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF1C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1\uE7D3", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF1C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1\uE0D3", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF1C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1\uE1D3", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF1C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1\uE2D3", 14))
    });
    this.comboBox_4.Name = Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF1C3", 14);
    this.comboBox_4.SelectedIndexChanged += new EventHandler(this.comboBox_4_SelectedIndexChanged);
    this.label_12.AccessibleDescription = (string) null;
    this.label_12.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_12, Module.a("\uD8B3ힵ\uDAB7\uDFB9킻辽\uF5BF", 14));
    this.label_12.Font = (Font) null;
    this.label_12.Name = Module.a("\uD8B3ힵ\uDAB7\uDFB9킻辽\uF5BF", 14);
    this.radioButton_0.AccessibleDescription = (string) null;
    this.radioButton_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.radioButton_0, Module.a("욳ힵ\uDCB7펹펻ﲽ떿뛁냃꧅ꛇ\uF8C9", 14));
    this.radioButton_0.BackgroundImage = (Image) null;
    this.radioButton_0.Font = (Font) null;
    this.radioButton_0.Name = Module.a("욳ힵ\uDCB7펹펻ﲽ떿뛁냃꧅ꛇ\uF8C9", 14);
    this.radioButton_0.UseVisualStyleBackColor = true;
    this.radioButton_0.CheckedChanged += new EventHandler(this.radioButton_0_CheckedChanged);
    this.radioButton_1.AccessibleDescription = (string) null;
    this.radioButton_1.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.radioButton_1, Module.a("욳ힵ\uDCB7펹펻ﲽ떿뛁냃꧅ꛇ\uFBC9", 14));
    this.radioButton_1.BackgroundImage = (Image) null;
    this.radioButton_1.Checked = true;
    this.radioButton_1.Font = (Font) null;
    this.radioButton_1.Name = Module.a("욳ힵ\uDCB7펹펻ﲽ떿뛁냃꧅ꛇ\uFBC9", 14);
    this.radioButton_1.TabStop = true;
    this.radioButton_1.UseVisualStyleBackColor = true;
    this.radioButton_1.CheckedChanged += new EventHandler(this.radioButton_1_CheckedChanged);
    this.groupBox_1.AccessibleDescription = (string) null;
    this.groupBox_1.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.groupBox_1, Module.a("펳쒵ힷ쾹첻ﲽ꾿뫁\uF1C3", 14));
    this.groupBox_1.BackgroundImage = (Image) null;
    this.groupBox_1.Controls.Add((Control) this.radioButton_2);
    this.groupBox_1.Controls.Add((Control) this.radioButton_3);
    this.groupBox_1.Font = (Font) null;
    this.groupBox_1.Name = Module.a("펳쒵ힷ쾹첻ﲽ꾿뫁\uF1C3", 14);
    this.groupBox_1.TabStop = false;
    this.radioButton_2.AccessibleDescription = (string) null;
    this.radioButton_2.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.radioButton_2, Module.a("욳ힵ\uDCB7펹펻ﲽ떿뛁냃꧅ꛇﻉ", 14));
    this.radioButton_2.BackgroundImage = (Image) null;
    this.radioButton_2.Checked = true;
    this.radioButton_2.Font = (Font) null;
    this.radioButton_2.Name = Module.a("욳ힵ\uDCB7펹펻ﲽ떿뛁냃꧅ꛇﻉ", 14);
    this.radioButton_2.TabStop = true;
    this.radioButton_2.UseVisualStyleBackColor = true;
    this.radioButton_3.AccessibleDescription = (string) null;
    this.radioButton_3.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.radioButton_3, Module.a("욳ힵ\uDCB7펹펻ﲽ떿뛁냃꧅ꛇ柳", 14));
    this.radioButton_3.BackgroundImage = (Image) null;
    this.radioButton_3.Font = (Font) null;
    this.radioButton_3.Name = Module.a("욳ힵ\uDCB7펹펻ﲽ떿뛁냃꧅ꛇ柳", 14);
    this.radioButton_3.UseVisualStyleBackColor = true;
    this.groupBox_3.AccessibleDescription = (string) null;
    this.groupBox_3.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.groupBox_3, Module.a("펳쒵ힷ쾹첻ﲽ꾿뫁\uF3C3", 14));
    this.groupBox_3.BackgroundImage = (Image) null;
    this.groupBox_3.Controls.Add((Control) this.radioButton_7);
    this.groupBox_3.Controls.Add((Control) this.radioButton_8);
    this.groupBox_3.Controls.Add((Control) this.radioButton_6);
    this.groupBox_3.Font = (Font) null;
    this.groupBox_3.Name = Module.a("펳쒵ힷ쾹첻ﲽ꾿뫁\uF3C3", 14);
    this.groupBox_3.TabStop = false;
    this.radioButton_7.AccessibleDescription = (string) null;
    this.radioButton_7.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.radioButton_7, Module.a("욳ힵ\uDCB7펹펻ﲽ떿뛁냃꧅ꛇ\uF3C9", 14));
    this.radioButton_7.BackgroundImage = (Image) null;
    this.radioButton_7.Font = (Font) null;
    this.radioButton_7.Name = Module.a("욳ힵ\uDCB7펹펻ﲽ떿뛁냃꧅ꛇ\uF3C9", 14);
    this.radioButton_7.UseVisualStyleBackColor = true;
    this.radioButton_8.AccessibleDescription = (string) null;
    this.radioButton_8.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.radioButton_8, Module.a("욳ힵ\uDCB7펹펻ﲽ떿뛁냃꧅ꛇ\uF2C9", 14));
    this.radioButton_8.BackgroundImage = (Image) null;
    this.radioButton_8.Font = (Font) null;
    this.radioButton_8.Name = Module.a("욳ힵ\uDCB7펹펻ﲽ떿뛁냃꧅ꛇ\uF2C9", 14);
    this.radioButton_8.UseVisualStyleBackColor = true;
    this.radioButton_6.AccessibleDescription = (string) null;
    this.radioButton_6.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.radioButton_6, Module.a("욳ힵ\uDCB7펹펻ﲽ떿뛁냃꧅ꛇ\uFDC9", 14));
    this.radioButton_6.BackgroundImage = (Image) null;
    this.radioButton_6.Checked = true;
    this.radioButton_6.Font = (Font) null;
    this.radioButton_6.Name = Module.a("욳ힵ\uDCB7펹펻ﲽ떿뛁냃꧅ꛇ\uFDC9", 14);
    this.radioButton_6.TabStop = true;
    this.radioButton_6.UseVisualStyleBackColor = true;
    this.label_15.AccessibleDescription = (string) null;
    this.label_15.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_15, Module.a("\uD8B3ힵ\uDAB7\uDFB9킻蚽", 14));
    this.label_15.Font = (Font) null;
    this.label_15.Name = Module.a("\uD8B3ힵ\uDAB7\uDFB9킻蚽", 14);
    this.label_16.AccessibleDescription = (string) null;
    this.label_16.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_16, Module.a("\uD8B3ힵ\uDAB7\uDFB9킻螽", 14));
    this.label_16.Font = (Font) null;
    this.label_16.Name = Module.a("\uD8B3ힵ\uDAB7\uDFB9킻螽", 14);
    this.label_17.AccessibleDescription = (string) null;
    this.label_17.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_17, Module.a("\uD8B3ힵ\uDAB7\uDFB9킻貽\uF0BF", 14));
    this.label_17.ForeColor = SystemColors.HotTrack;
    this.label_17.Name = Module.a("\uD8B3ힵ\uDAB7\uDFB9킻貽\uF0BF", 14);
    this.groupBox_4.AccessibleDescription = (string) null;
    this.groupBox_4.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.groupBox_4, Module.a("펳쒵ힷ쾹첻ﲽ꾿뫁\uF0C3", 14));
    this.groupBox_4.BackgroundImage = (Image) null;
    this.groupBox_4.Controls.Add((Control) this.radioButton_0);
    this.groupBox_4.Controls.Add((Control) this.radioButton_1);
    this.groupBox_4.Font = (Font) null;
    this.groupBox_4.Name = Module.a("펳쒵ힷ쾹첻ﲽ꾿뫁\uF0C3", 14);
    this.groupBox_4.TabStop = false;
    this.listBox_0.AccessibleDescription = (string) null;
    this.listBox_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.listBox_0, Module.a("\uD8B3\uDFB5쮷캹ﺻ톽뢿\uF3C1", 14));
    this.listBox_0.BackgroundImage = (Image) null;
    this.listBox_0.Font = (Font) null;
    this.listBox_0.FormattingEnabled = true;
    this.listBox_0.Name = Module.a("\uD8B3\uDFB5쮷캹ﺻ톽뢿\uF3C1", 14);
    this.listBox_0.SelectedIndexChanged += new EventHandler(this.listBox_0_SelectedIndexChanged);
    this.label_18.AccessibleDescription = (string) null;
    this.label_18.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_18, Module.a("\uD8B3ힵ\uDAB7\uDFB9킻袽", 14));
    this.label_18.Font = (Font) null;
    this.label_18.Name = Module.a("\uD8B3ힵ\uDAB7\uDFB9킻袽", 14);
    this.button_3.AccessibleDescription = (string) null;
    this.button_3.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.button_3, Module.a("횳쎵첷캹펻킽\uF4BF", 14));
    this.button_3.BackgroundImage = (Image) null;
    this.button_3.ForeColor = SystemColors.HotTrack;
    this.button_3.Name = Module.a("횳쎵첷캹펻킽\uF4BF", 14);
    this.button_3.UseVisualStyleBackColor = true;
    this.button_3.Click += new EventHandler(this.button_3_Click);
    this.label_19.AccessibleDescription = (string) null;
    this.label_19.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_19, Module.a("\uD8B3ힵ\uDAB7\uDFB9킻覽", 14));
    this.label_19.Name = Module.a("\uD8B3ힵ\uDAB7\uDFB9킻覽", 14);
    this.AccessibleDescription = (string) null;
    this.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this, Module.a("邳습킷펹쾻", 14));
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackgroundImage = (Image) null;
    this.ControlBox = false;
    this.Controls.Add((Control) this.label_19);
    this.Controls.Add((Control) this.button_3);
    this.Controls.Add((Control) this.label_18);
    this.Controls.Add((Control) this.listBox_0);
    this.Controls.Add((Control) this.groupBox_4);
    this.Controls.Add((Control) this.textBox_1);
    this.Controls.Add((Control) this.label_1);
    this.Controls.Add((Control) this.groupBox_2);
    this.Controls.Add((Control) this.label_6);
    this.Controls.Add((Control) this.label_5);
    this.Controls.Add((Control) this.label_0);
    this.Controls.Add((Control) this.comboBox_0);
    this.Controls.Add((Control) this.label_3);
    this.Controls.Add((Control) this.label_15);
    this.Controls.Add((Control) this.comboBox_1);
    this.Controls.Add((Control) this.label_17);
    this.Controls.Add((Control) this.label_4);
    this.Controls.Add((Control) this.label_16);
    this.Controls.Add((Control) this.groupBox_3);
    this.Controls.Add((Control) this.groupBox_1);
    this.Controls.Add((Control) this.groupBox_0);
    this.Controls.Add((Control) this.textBox_0);
    this.Controls.Add((Control) this.button_2);
    this.Controls.Add((Control) this.label_2);
    this.Controls.Add((Control) this.button_1);
    this.Controls.Add((Control) this.button_0);
    this.Font = (Font) null;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Icon = (Icon) null;
    this.Name = Module.a("\uE7B3쾵쮷캹\uD9BB펽龿釁ꇃ닅", 14);
    this.groupBox_2.ResumeLayout(false);
    this.groupBox_2.PerformLayout();
    this.groupBox_0.ResumeLayout(false);
    this.groupBox_0.PerformLayout();
    this.groupBox_1.ResumeLayout(false);
    this.groupBox_1.PerformLayout();
    this.groupBox_3.ResumeLayout(false);
    this.groupBox_3.PerformLayout();
    this.groupBox_4.ResumeLayout(false);
    this.groupBox_4.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public f()
  {
    int int_0 = 12;
    // ISSUE: explicit constructor call
 //   base.\u002Ector();
    this.method_0();
    this.textBox_0.Text = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + (object) '\\' + Module.a("ﺱ톳튵覷钹첻욽ꊿ", 12);
    this.comboBox_0.SelectedIndex = 19;
    this.comboBox_1.SelectedIndex = 0;
    this.arrayList_0 = new ArrayList();
    this.arrayList_0.Clear();
    bool flag1 = false;
    string path1 = Application.StartupPath + Module.a("\uEEB1\uE7B3\uF3B5\uECB7\uE6B9\uD8BBힽ꺿ꗁ뻃껅ꇇ闉꧋ꃍ뇏냑룓돕\uF6D7껙ꓛꫝ", 12);
    if (File.Exists(path1))
    {
      using (StreamReader streamReader = new StreamReader(path1, Encoding.ASCII))
      {
        bool flag2 = false;
        try
        {
          flag2 = Convert.ToBoolean(streamReader.ReadLine());
        }
        catch
        {
        }
        if (flag2)
          flag1 = true;
      }
    }
    if (flag1)
    {
      this.button_3.Visible = false;
      this.label_19.Visible = true;
    }
    else
    {
      this.button_3.Visible = true;
      this.label_19.Visible = false;
    }
    string path2;
    while (true)
    {
      path2 = c.string_1;
      if (flag1)
        goto label_19;
label_13:
      if (!File.Exists(path2))
      {
        using (StreamWriter streamWriter = new StreamWriter(path2, false, Encoding.Unicode))
        {
          streamWriter.WriteLine(Module.a("薱", int_0));
          streamWriter.WriteLine(Module.a("花莳薵覆﮹袻﮽\uF0BF﯁\uF6C3\uF0C5劉韛ￋ\uFBCD\uE1CF铑鋓\uE0D5鷗\uE8D9鷛鯝ꇟ탡ꇣꏥ\uD9E7\uDDE9ꫫ\uDEED뗯냱싳샵췷싹쿻췽ㇿ㌁䀃㈅䴇㨉䤋䴍␏␑┓ℕ⤗堙堛Ⱍ戟昡ሣ攥ဧ温樫ḭ̯ȱ瀳眵षਹ縻紽Ŀ畁畃ͅେཉ祋్楏ၑ恓恕ᵗṙ潛橝呟偡啣╥幧⡩\u2E6B噭䥯ㅱ䑳ふ㵷㡹㹻䭽쉿쎁뒃쒅뺇붉쾋뮍ꞏꞑ킓펕ꆗ꺙겛ꦝ\uE59F\uE7A1钣鎥麧颩麫颭覯膱膳膵醴貹ﾻ誽\uF2BF胁\uF5C3\uF7C5難\uF3C9溜ￍ鏏", int_0));
          streamWriter.WriteLine(Module.a("花莳薵覆﮹袻﮽\uF0BF﯁\uF6C3\uF0C5劉韛ￋ\uFBCD\uE1CF铑鋓\uE0D5鷗\uE8D9鷛鯝ꇟ탡ꇣꏥ\uD9E7\uDDE9ꫫ\uDEED뗯뛱뗳컵뻷맹쯻믽䛿\u3101䀃䌅㬇㸉䴋伍┏儑∓刕⬗堙⤛⠝ᐟሡᴣ急椧氩漫\u192D\u082F焱Գ̵ష縹\u0A3BܽĿ݁煃ͅ灇ॉ罋罍ᕏ晑ၓ慕ᩗ᱙ṛὝ偟兡剣\u2465內⥩奫彭䕯䩱㝳乵㵷䡹㵻䡽롿뮁얃뚅첇뢉좋랍ꂏꖑ궓ꞕ\uDC97ꮙ궛\uDB9D閟\uE0A1\uE1A3\uE3A5邧鎩骫颭\uF1AF蒱膳\uF0B5ﲷ袹ﺻ讽\uF5BF\uF6C1\uF0C3蓅難ﳉ頋諍\uE4CF金雓\uEFD5髗\uE2D9飛\uEBDD탟훡퓣훥곧ꯩ껫\uDCED쏯", int_0));
          streamWriter.WriteLine(Module.a("\uF6B1足肵辷誹ﺻ貽膿蛁\uF0C3\uF7C5\uFBC7柳ￋ词鋏\uE1D1\uEDD3\uE7D5鯗\uEAD9黛\uECDDꛟ폡ꋣ퓥\uDBE7껩ꧫ\uD8ED뛯뇱쟳쿵죷쏹맻볽㓿㈁䄃䐅㰇伉伋㴍☏儑∓✕嬗嬙⸛ⴝ感ᜡᔣ朥ᴧᨩḫḭ̯猱瀳猵笷ഹ\u0D3Bؽ砿牁絃畅େ้ੋ睍敏", int_0));
          streamWriter.WriteLine(Module.a("螱\uF1B3螵趷芹覻螽芿\uF3C1\uF2C3蟅軇韛請词\uE5CF\uE0D1\uE1D3韕鯗黙飛\uEADDꓟ훡\uDDE3헥\uDDE7꿩\uD8EB\uDBED돯뛱럳냵컷쯹쯻췽䋿㘁㜃㸅万三䴋䠍␏儑✓匕Ⱇ∙␛⨝星ᄡ昣ᘥ洧ᠩ洫洭甯\u0A31瘳眵࠷̹༻砽琿獁Cх筇獉ࡋ癍晏", int_0));
          streamWriter.WriteLine(Module.a("螱\uF1B3螵趷芹覻螽芿\uF3C1\uF2C3蟅軇韛請词\uE5CF\uE0D1\uE7D3铕\uEED7\uE9D9\uEBDB\uEADDꇟ퇡ꛣꋥꧧ\uDBE9\uDBEB귭쟯엱췳쇵뫷룹쫻짽䏿\u3101䜃㸅万䠉㨋䨍∏☑倓―嬗帙┛嬝戟愡愣ሥ洧ᬩ樫氭猯ر眳眵\u0A37簹\u0E3Bܽ爿獁݃Eେ\u0C49繋్ᑏၑ敓ᑕ浗ᥙ摛潝╟Ⅱ兣坥嵧剩⥫\u2D6D䁯㝱䵳㉵佷䡹㹻䙽롿잁뒃쎅뮇즉뾋뮍톏펑ꎓꊕ\uDE97\uDB99ꮛ꾝\uE59F醡銣钥鲧銩\uEEAB颭\uF5AF薱蒳\uF0B5膷ﾹﶻﲽ\uF7BF\uF5C1胃\uF0C5難ﳉ迋词雏铑\uE2D3\uE3D5\uEBD7\uE8D9鷛\uEFDD\uD9DFꏡ\uDDE3ꏥ\uDFE7꿩\uD8EBퟭ엯", int_0));
          streamWriter.WriteLine(Module.a("螱\uF1B3螵趷芹覻螽芿\uF3C1\uF2C3蟅軇韛請词\uE5CF\uE1D1闓\uEFD5\uEBD7黙\uE5DB\uE6DD\uD8DF헡ꋣퟥ\uDDE7ꧩ귫\uDAED뗯뛱샳듵샷룹쿻쿽㗿䐁䘃㼅䨇㸉䨋䴍☏⌑␓┕ⴗ⠙ⴛ☝\u181FᨡሣᔥᰧᤩᤫἭ猯Աĳ瀵簷ହлଽ焿穁كE硇繉硋ཌྷ楏", int_0));
          streamWriter.WriteLine(Module.a("螱\uF1B3螵趷芹覻螽芿\uF3C1\uF2C3蟅軇韛請词\uE5CF\uEBD1闓\uE1D5\uE8D7黙飛\uEFDD폟\uDBE1ꗣ\uDFE5탧꿩\uDFEB훭쇯싱췳듵뫷쫹쯻췽䏿䌁䘃㌅䴇㨉䨋㸍吏⬑┓匕⬗ⰙⴛⰝᔟሡ攣戥ᬧሩᠫ欭瘯琱瘳猵縷ହ縻\u0E3D眿穁牃瑅็硉ࡋ繍ፏ", int_0));
          continue;
        }
      }
      else
        break;
label_19:
      path2 = Application.StartupPath + Module.a("\uEEB1\uE7B3\uF3B5\uECB7\uE6B9\uD8BBힽ꺿ꗁ뻃껅ꇇ闉듋뛍ﻏꛑ곓ꋕ", int_0);
      goto label_13;
    }
    try
    {
      using (StreamReader streamReader = new StreamReader(path2, Encoding.Unicode))
      {
        int num = 0;
        string str = streamReader.ReadLine();
        try
        {
          num = Convert.ToInt32(str);
        }
        catch
        {
        }
        if (num > 0)
        {
          Class1 class1 = new Class1();
          for (int index = 0; index < num; ++index)
          {
            string string_1 = streamReader.ReadLine();
            this.arrayList_0.Add((object) class1.method_1(string_1, Class1.string_0));
          }
          this.listBox_0.Items.Clear();
          for (int index = 0; index < this.arrayList_0.Count; ++index)
          {
            string[] strArray = ((string) this.arrayList_0[index]).Split(';');
            if (strArray.Length == 3)
              this.listBox_0.Items.Add((object) strArray[1]);
            else
              break;
          }
        }
      }
    }
    catch
    {
    }
    string str1 = (string) null;
    string path3 = c.string_2 + Module.a("\uEEB1삳습솷쪹\uD9BB\uE1BD뎿뇁\uF5C3\uF6C5\uE6C7뻉듋뫍", int_0);
    if (File.Exists(path3))
    {
      using (StreamReader streamReader = new StreamReader(path3, Encoding.ASCII))
      {
        try
        {
          str1 = streamReader.ReadLine();
        }
        catch
        {
        }
      }
      for (int index = 0; index < this.arrayList_0.Count; ++index)
      {
        string[] strArray = ((string) this.arrayList_0[index]).Split(';');
        if (strArray.Length != 3)
          break;
        if (str1 == strArray[1])
        {
          this.string_0 = strArray[0];
          c.string_7 = strArray[1];
          this.label_17.Text = c.string_7;
          this.string_1 = strArray[2];
          this.method_1();
          this.method_3();
          this.listBox_0.SelectedIndex = index;
          break;
        }
      }
    }
    else
    {
      string[] strArray = ((string) this.arrayList_0[0]).Split(';');
      if (strArray.Length != 3)
        return;
      this.string_0 = strArray[0];
      c.string_7 = strArray[1];
      this.label_17.Text = c.string_7;
      this.string_1 = strArray[2];
      this.method_1();
      this.method_3();
      this.listBox_0.SelectedIndex = 0;
    }
  }

  private void method_1()
  {
    int int_0 = 13;
    c.byte_20 = (byte) 0;
    c.bool_2 = false;
    c.byte_0 = (byte) 0;
    if (!(this.string_0 == Module.a("\uE7B2颴辶覸论趼銾鋀胂", 13)) && !(this.string_0 == Module.a("膲螴螶覸隺袼蚾\uF4C0", int_0)) && !(this.string_0 == Module.a("ﾲ\uF0B4\uF3B6覸论誼銾럀\uFBC2\uEBC4\uF2C6", int_0)) && !(this.string_0 == Module.a("ﾲ\uF0B4\uF3B6钸\uEDBA薼醾\uF4C0", int_0)))
    {
      if (this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾鋀胂", int_0))
        c.int_2 = 14;
      else if (this.string_0 == Module.a("\uF7B2\uF8B4\uEFB6馸\uEDBA躼龾賀곂ꯄ\uA8C6\uAAC8ꏊ뿌ꃎ볐뛒", int_0))
        c.int_2 = 51;
      else if (this.string_0 == Module.a("\uE5B2蚴骶\uF4B8鮺\uF0BC킾꿀곂ꛄ꿆믈\uA4CAꃌ\uAACE", int_0))
      {
        c.int_2 = 55;
        c.byte_20 = (byte) 0;
      }
      else if (this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾藀軂鷄\uEAC6蓈\uA4CAꏌꃎ닐믒\uA7D4룖듘뻚", int_0))
      {
        c.int_2 = 55;
        c.byte_20 = (byte) 1;
      }
      else if (!(this.string_0 == Module.a("\uE7B2颴莶覸论趼銾\uF7C0\uFBC2\uF5C4\uF4C6", int_0)) && !(this.string_0 == Module.a("ﾲ\uF0B4\uF3B6覸论誼銾럀\uF7C2\uEBC4\uF7C6", int_0)) && !(this.string_0 == Module.a("芲蒴螶袸鮺\uEBBC设\uEFC0\uF3C2", int_0)) && !(this.string_0 == Module.a("ﾲ\uF0B4\uF3B6钸\uEDBA覼醾\uF1C0", int_0)))
      {
        if (!(this.string_0 == Module.a("\uE7B2颴辶覸论趼銾\uF7C0\uFBC2\uF5C4\uF4C6", int_0)) && !(this.string_0 == Module.a("ﾲ\uF0B4\uF3B6覸论誼銾럀\uFBC2\uEBC4\uF7C6", int_0)) && !(this.string_0 == Module.a("芲蒴螶袸鮺\uEBBC螾\uEFC0\uF3C2", int_0)) && !(this.string_0 == Module.a("ﾲ\uF0B4\uF3B6钸\uEDBA薼醾\uF1C0", int_0)))
        {
          if (!(this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾燎\uFBC2\uF5C4\uF1C6", int_0)) && !(this.string_0 == Module.a("ﾲ\uF0B4\uF3B6覸论誼銾韀\uFBC2ﷄ\uF7C6\uFFC8", int_0)))
          {
            if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾菀\uEEC2ﷄￆ杻\uFDCA", int_0))
            {
              c.int_2 = 150;
              c.bool_2 = true;
            }
            else if (!(this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾\uF7C0\uFBC2\uF5C4\uF4C6", int_0)) && !(this.string_0 == Module.a("ﾲ\uF0B4\uF3B6覸论誼銾럀\uF2C2\uEBC4\uF7C6", int_0)) && !(this.string_0 == Module.a("芲蒴螶袸鮺\uEBBC躾\uEFC0\uF3C2", int_0)) && !(this.string_0 == Module.a("ﾲ\uF0B4\uF3B6钸\uEDBA貼醾\uF1C0", int_0)) && !(this.string_0 == Module.a("芲蒴螶覸隺寮袾\uF1C0\uF6C2", int_0)))
            {
              if (this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾觀迂\uF6C4\uF5C6", int_0))
              {
                c.int_2 = 9;
                c.byte_20 = (byte) 1;
              }
              else if (this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾藀\uF4C2\uF2C4\uF6C6杻", int_0))
              {
                c.int_2 = 9;
                c.byte_20 = (byte) 2;
              }
              else if (this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾郀胂\uF3C4ￆ杻\uF2CA", int_0))
              {
                c.int_2 = 9;
                c.byte_20 = (byte) 3;
              }
              else if (!(this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾鋀胂", int_0)) && !(this.string_0 == Module.a("膲蒴螶覸隺袼蚾\uF4C0", int_0)) && !(this.string_0 == Module.a("ﾲ\uF0B4\uF3B6覸论誼銾럀\uFBC2\uEBC4ￆﳈ", int_0)) && !(this.string_0 == Module.a("ﾲ\uF0B4\uF3B6钸\uEDBA薼醾\uF2C0\uF1C2\uE8C4\uF5C6ﳈ\uFDCA", int_0)))
              {
                if (!(this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾\uF7C0\uFBC2\uF5C4\uF4C6", int_0)) && !(this.string_0 == Module.a("\uE5B2\uF6B4骶貸论趼ﺾ", int_0)) && !(this.string_0 == Module.a("膲蒴螶覸隺寮袾\uF1C0\uF6C2", int_0)) && !(this.string_0 == Module.a("ﾲ\uF0B4\uF3B6覸论誼銾럀\uFBC2\uEBC4ￆ\uFFC8", int_0)) && !(this.string_0 == Module.a("芲蒴螶袸鮺\uEBBC螾\uEFC0\uF2C2", int_0)) && !(this.string_0 == Module.a("ﾲ\uF0B4\uF3B6钸\uEDBA薼醾\uF2C0\uF1C2", int_0)))
                {
                  if (!(this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾菀\uEEC2\uF3C4ￆ杻\uF8CA", int_0)) && !(this.string_0 == Module.a("ﾲ\uF0B4\uF3B6覸论誼銾럀\uFBC2\uEBC4ￆ\uF1C8", int_0)))
                  {
                    if (this.string_0 == Module.a("\uE7B2ﲴ\uF6B6\uF6B8隺\uEDBC\uF6BE迀蓂", int_0))
                      c.int_2 = 201;
                    else if (!(this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾雀郂", int_0)) && !(this.string_0 == Module.a("膲蒴螶覸隺\uF4BC\uF6BE苀\uFBC2", int_0)) && !(this.string_0 == Module.a("ﾲ\uF0B4\uF3B6覸论誼銾럀\uFBC2\uEBC4ￆ\uFBC8", int_0)) && !(this.string_0 == Module.a("ﾲ\uF0B4\uF3B6钸\uEDBA薼醾\uF3C0\uF6C2\uF3C4", int_0)))
                    {
                      if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾菀\uEEC2鋄铆", int_0))
                      {
                        c.int_2 = 120;
                        c.bool_2 = true;
                      }
                      else if (!(this.string_0 == Module.a("\uE7B2颴辶覸论趼銾雀郂", int_0)) && !(this.string_0 == Module.a("ﾲ\uF0B4\uF3B6覸论誼銾럀\uFBC2\uEBC4\uF5C6", int_0)) && !(this.string_0 == Module.a("ﾲ\uF0B4\uF3B6钸\uEDBA薼醾\uF3C0", int_0)))
                      {
                        if (!(this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾雀郂", int_0)) && !(this.string_0 == Module.a("芲蒴螶覸隺\uF4BC\uF6BE苀\uFBC2", int_0)) && !(this.string_0 == Module.a("ﾲ\uF0B4\uF3B6覸论誼銾럀\uF2C2\uEBC4\uF5C6", int_0)) && !(this.string_0 == Module.a("ﾲ\uF0B4\uF3B6钸\uEDBA貼醾\uF3C0", int_0)))
                        {
                          if (this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾觀迂\uF7C4ￆ杻\uF8CA", int_0))
                            c.int_2 = 13;
                          else if (!(this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾燎\uFBC2\uF5C4\uF1C6", int_0)) && !(this.string_0 == Module.a("ﾲ\uF0B4\uF3B6覸论誼銾럀\uF2C2\uEBC4\uF1C6", int_0)))
                          {
                            if (!(this.string_0 == Module.a("\uE7B2颴莶覸论趼銾燎\uFBC2\uF5C4\uF1C6", int_0)) && !(this.string_0 == Module.a("ﾲ\uF0B4\uF3B6覸论誼銾韀\uF7C2\uEBC4\uF1C6", int_0)))
                            {
                              if (!(this.string_0 == Module.a("\uE7B2颴辶覸论趼銾燎\uFBC2\uF5C4\uF1C6", int_0)) && !(this.string_0 == Module.a("ﾲ\uF0B4\uF3B6覸论誼銾韀\uFBC2\uEBC4\uF1C6", int_0)))
                              {
                                if (!(this.string_0 == Module.a("\uE7B2颴莶覸论趼銾雀郂", int_0)) && !(this.string_0 == Module.a("ﾲ\uF0B4\uF3B6覸论誼銾럀\uF7C2\uEBC4\uF5C6", int_0)) && !(this.string_0 == Module.a("ﾲ\uF0B4\uF3B6钸\uEDBA覼醾\uF3C0", int_0)))
                                {
                                  if (!(this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾闀迂雄", int_0)) && !(this.string_0 == Module.a("膲蒴螶覸隺\uF0BC螾", int_0)) && !(this.string_0 == Module.a("\uE7B2領\uE4B6馸\uEDBA袼", int_0)))
                                  {
                                    if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾釀輸ﷄ\uF6C6靖", int_0))
                                    {
                                      c.int_2 = 140;
                                      c.byte_20 = (byte) 1;
                                    }
                                    else if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾\uF1C0\uFBC2\uF4C4\uF2C6", int_0))
                                    {
                                      c.int_2 = 140;
                                      c.byte_20 = (byte) 2;
                                    }
                                    else if (!(this.string_0 == Module.a("\uE7B2領\uE4B6馸\uEDBA袼銾賀", int_0)) && !(this.string_0 == Module.a("\uF0B2살얶춸\uDABA풼톾\uE1C0闂\uF0C4", int_0)))
                                    {
                                      if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾\uF1C0\uFBC2\uF7C4\uF2C6", int_0))
                                      {
                                        c.int_2 = 140;
                                        c.byte_20 = (byte) 5;
                                      }
                                      else if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾\uF1C0輸\uF5C4\uF6C6", int_0))
                                      {
                                        c.int_2 = 140;
                                        c.byte_20 = (byte) 6;
                                      }
                                      else if (this.string_0 == Module.a("\uF0B2살얶춸\uDABA풼톾\uE1C0闂\uF0C4\uEAC6蓈\uA4CAꏌꃎ닐믒\uA7D4룖듘뻚", int_0))
                                      {
                                        c.int_2 = 140;
                                        c.byte_20 = (byte) 7;
                                      }
                                      else if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾胀鏂蓄\uF6C6杻流", int_0))
                                      {
                                        c.int_2 = 140;
                                        c.byte_20 = (byte) 8;
                                      }
                                      else if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾\uF7C0\uFBC2\uF4C4\uF4C6", int_0))
                                      {
                                        c.int_2 = 140;
                                        c.byte_20 = (byte) 9;
                                      }
                                      else if (this.string_0 == Module.a("\uE7B2颴芶覸论\uF6BC銾胀迂规", int_0))
                                      {
                                        c.int_2 = 180;
                                        c.byte_20 = (byte) 0;
                                      }
                                      else if (!(this.string_0 == Module.a("\uE7B2颴辶覸论趼銾闀迂雄", int_0)) && !(this.string_0 == Module.a("\uE7B2領\uE4B6馸\uEDBA貼", int_0)))
                                      {
                                        if (!(this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾闀迂雄", int_0)) && !(this.string_0 == Module.a("芲蒴螶覸隺\uF0BC螾", int_0)) && !(this.string_0 == Module.a("\uE7B2領\uE4B6馸\uEDBA躼", int_0)) && !(this.string_0 == Module.a("\uE7B2領\uE4B6馸\uEDBA躼銾賀", int_0)) && !(this.string_0 == Module.a("\uF0B2살얶춸\uDABA풼톾\uE1C0闂\uF6C4", int_0)))
                                        {
                                          if (this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾釀輸ﷄ\uF6C6靖", int_0))
                                          {
                                            c.int_2 = 47;
                                            c.byte_20 = (byte) 1;
                                          }
                                          else if (this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾\uF1C0\uFBC2\uF4C4\uF2C6", int_0))
                                          {
                                            c.int_2 = 47;
                                            c.byte_20 = (byte) 2;
                                          }
                                          else if (this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾觀迂\uF4C4ￆ杻\uF2CA", int_0))
                                          {
                                            c.int_2 = 47;
                                            c.byte_20 = (byte) 3;
                                          }
                                          else if (this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾賀髂ﳄ\uF5C6\uFBC8響", int_0))
                                          {
                                            c.int_2 = 47;
                                            c.byte_20 = (byte) 4;
                                          }
                                          else if (this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾\uF1C0\uFBC2\uF7C4\uF2C6", int_0))
                                          {
                                            c.int_2 = 47;
                                            c.byte_20 = (byte) 5;
                                          }
                                          else if (this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾\uF1C0輸\uF5C4\uF6C6", int_0))
                                          {
                                            c.int_2 = 47;
                                            c.byte_20 = (byte) 6;
                                          }
                                          else if (this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾胀鏂蓄\uF6C6杻流", int_0))
                                          {
                                            c.int_2 = 47;
                                            c.byte_20 = (byte) 8;
                                          }
                                          else if (this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾\uF7C0\uFBC2\uF4C4\uF4C6", int_0))
                                          {
                                            c.int_2 = 47;
                                            c.byte_20 = (byte) 9;
                                          }
                                          else if (!(this.string_0 == Module.a("\uE7B2颴莶覸论趼銾闀迂雄", int_0)) && !(this.string_0 == Module.a("\uE7B2領\uE4B6馸\uEDBA込", int_0)) && !(this.string_0 == Module.a("\uE7B2領\uE4B6馸\uEDBA込銾賀", int_0)) && !(this.string_0 == Module.a("\uF0B2살얶춸\uDABA풼톾\uE1C0闂\uF7C4", int_0)))
                                          {
                                            if (this.string_0 == Module.a("\uE7B2颴莶覸论趼銾釀輸ﷄ\uF6C6靖", int_0))
                                            {
                                              c.int_2 = 48;
                                              c.byte_20 = (byte) 1;
                                            }
                                            else if (this.string_0 == Module.a("\uE7B2颴莶覸论趼銾\uF1C0\uFBC2\uF4C4\uF2C6", int_0))
                                            {
                                              c.int_2 = 48;
                                              c.byte_20 = (byte) 2;
                                            }
                                            else if (this.string_0 == Module.a("\uE7B2颴莶覸论趼銾\uF1C0\uFBC2\uF7C4\uF2C6", int_0))
                                            {
                                              c.int_2 = 48;
                                              c.byte_20 = (byte) 5;
                                            }
                                            else if (this.string_0 == Module.a("\uE7B2颴莶覸论趼銾\uF1C0輸\uF5C4\uF6C6", int_0))
                                            {
                                              c.int_2 = 48;
                                              c.byte_20 = (byte) 6;
                                            }
                                            else if (!(this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾闀軂", int_0)) && !(this.string_0 == Module.a("膲蒴螶覸隺\uEFBC\uE5BE燎", int_0)) && !(this.string_0 == Module.a("\uE7B2\uF8B4骶\uEDB8\uE3BA\uEBBC躾", int_0)) && !(this.string_0 == Module.a("ﺲ\uF0B4\uF0B6\uF8B8隺\uEBBC躾", int_0)) && !(this.string_0 == Module.a("莲芴薶", int_0)))
                                            {
                                              if (!(this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾鋀軂\uF4C4\uF1C6ﻈ響\uF8CC", int_0)) && !(this.string_0 == Module.a("\uE0B2\uF8B4蚶辸貺貼誾\uE1C0闂\uF0C4", int_0)))
                                              {
                                                if (!(this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾鋀軂\uF4C4\uF1C6ﻈ響\uFBCC", int_0)) && !(this.string_0 == Module.a("\uE0B2\uF8B4蚶辸貺貼覾\uE1C0闂\uF0C4", int_0)))
                                                {
                                                  if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾闀軂\uF4C4ﻆ", int_0))
                                                  {
                                                    c.byte_20 = (byte) 5;
                                                    c.int_2 = 130;
                                                  }
                                                  else if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾藀郂\uF4C4ￆ\uF0C8", int_0))
                                                  {
                                                    c.byte_20 = (byte) 6;
                                                    c.int_2 = 130;
                                                  }
                                                  else if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾铀胂雄\uEAC6\uF8C8\uFBCAￌ\uFBCE", int_0))
                                                  {
                                                    c.byte_20 = (byte) 7;
                                                    c.int_2 = 130;
                                                  }
                                                  else if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾胀蟂臄飆\uF8C8", int_0))
                                                  {
                                                    c.byte_20 = (byte) 81;
                                                    c.int_2 = 130;
                                                  }
                                                  else if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾胀蟂臄飆\uFBC8", int_0))
                                                  {
                                                    c.byte_20 = (byte) 82;
                                                    c.int_2 = 130;
                                                  }
                                                  else if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾胀蟂臄飆靖", int_0))
                                                  {
                                                    c.byte_20 = (byte) 83;
                                                    c.int_2 = 130;
                                                  }
                                                  else if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾胀蟂臄飆\uFDC8", int_0))
                                                  {
                                                    c.byte_20 = (byte) 84;
                                                    c.int_2 = 130;
                                                  }
                                                  else if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾胀蟂臄飆ﳈ", int_0))
                                                  {
                                                    c.byte_20 = (byte) 85;
                                                    c.int_2 = 130;
                                                  }
                                                  else if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾胀蟂臄飆\uFFC8", int_0))
                                                  {
                                                    c.byte_20 = (byte) 86;
                                                    c.int_2 = 130;
                                                  }
                                                  else if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾胀蟂臄飆ﻈ", int_0))
                                                  {
                                                    c.byte_20 = (byte) 87;
                                                    c.int_2 = 130;
                                                  }
                                                  else if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾胀蟂臄飆\uF1C8", int_0))
                                                  {
                                                    c.byte_20 = (byte) 88;
                                                    c.int_2 = 130;
                                                  }
                                                  else if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾胀蟂臄飆\uF0C8", int_0))
                                                  {
                                                    c.byte_20 = (byte) 89;
                                                    c.int_2 = 130;
                                                  }
                                                  else if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾胀蟂臄飆\uF8C8\uFBCA", int_0))
                                                  {
                                                    c.byte_20 = (byte) 90;
                                                    c.int_2 = 130;
                                                  }
                                                  else if (!(this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾菀\uEEC2釄諆", int_0)) && !(this.string_0 == Module.a("\uE7B2\uF8B4骶﮸隺\uE9BC\uE7BE韀\uF2C2", int_0)) && !(this.string_0 == Module.a("ﺲ\uF0B4\uF0B6\uF8B8隺ﾼ銾韀\uF2C2", int_0)))
                                                  {
                                                    if (!(this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾菀\uEEC2雄諆\uF8C8\uFDCA頻ﻎ\uE4D0", int_0)) && !(this.string_0 == Module.a("\uE0B2\uF8B4蚶辸貺貼誾\uE1C0闂\uF0C4\uEAC6诈", int_0)))
                                                    {
                                                      if (!(this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾菀\uEEC2雄諆\uF8C8\uFDCA頻ﻎ\uE7D0", int_0)) && !(this.string_0 == Module.a("\uE0B2\uF8B4蚶辸貺貼覾\uE1C0闂\uF0C4\uEAC6诈", int_0)))
                                                      {
                                                        if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾菀\uEEC2釄諆\uF8C8\uF2CA", int_0))
                                                        {
                                                          c.byte_20 = (byte) 5;
                                                          c.int_2 = 130;
                                                          c.bool_2 = true;
                                                        }
                                                        else if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾菀\uEEC2臄铆\uF8C8\uF3CA\uF4CC", int_0))
                                                        {
                                                          c.byte_20 = (byte) 6;
                                                          c.int_2 = 130;
                                                          c.bool_2 = true;
                                                        }
                                                        else if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾菀\uEEC2郄蓆髈\uE6CAﳌￎ\uE3D0\uE7D2", int_0))
                                                        {
                                                          c.byte_20 = (byte) 7;
                                                          c.int_2 = 130;
                                                          c.bool_2 = true;
                                                        }
                                                        else if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾菀\uEEC2雄菆ﳈ響ￌ\uF7CE", int_0))
                                                        {
                                                          c.byte_20 = (byte) 8;
                                                          c.int_2 = 130;
                                                          c.bool_2 = true;
                                                        }
                                                        else if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾\uF0C0\uF5C2\uF2C4\uF0C6", int_0))
                                                        {
                                                          c.int_2 = 130;
                                                          c.bool_2 = true;
                                                          c.byte_20 = (byte) 10;
                                                        }
                                                        else if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾菀\uEEC2釄諆\uF8C8\uF3CAￌ\uF6CE", int_0))
                                                        {
                                                          c.byte_20 = (byte) 11;
                                                          c.int_2 = 130;
                                                          c.bool_2 = true;
                                                        }
                                                        else if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾鋀軂\uF4C4\uF1C6ﻈ流\uFBCC", int_0))
                                                        {
                                                          c.int_2 = 130;
                                                          c.bool_2 = true;
                                                          c.byte_20 = (byte) 12;
                                                        }
                                                        else if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾菀\uEEC2\uF4C4ￆ\uF1C8流", int_0))
                                                        {
                                                          c.int_2 = 130;
                                                          c.bool_2 = true;
                                                          c.byte_20 = (byte) 13;
                                                        }
                                                        else if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾菀\uEEC2\uF3C4ￆ\uF8C8流", int_0))
                                                        {
                                                          c.int_2 = 130;
                                                          c.bool_2 = true;
                                                          c.byte_20 = (byte) 14;
                                                        }
                                                        else if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾菀\uEEC2鋄铆\uFBC8\uF3CAﳌﻎ", int_0))
                                                        {
                                                          c.int_2 = 130;
                                                          c.bool_2 = true;
                                                          c.byte_20 = (byte) 15;
                                                        }
                                                        else if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾菀\uEEC2釄蛆\uF0C8\uF2CA\uFDCC\uF6CE", int_0))
                                                        {
                                                          c.int_2 = 130;
                                                          c.bool_2 = true;
                                                          c.byte_20 = (byte) 16;
                                                        }
                                                        else if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾菀\uEEC2\uF3C4\uF7C6\uFBC8響", int_0))
                                                        {
                                                          c.int_2 = 130;
                                                          c.bool_2 = true;
                                                          c.byte_20 = (byte) 17;
                                                        }
                                                        else if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾菀\uEEC2苄郆\uFFC8流ﻌ韎", int_0))
                                                        {
                                                          c.int_2 = 130;
                                                          c.bool_2 = true;
                                                          c.byte_20 = (byte) 18;
                                                        }
                                                        else if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾菀\uEEC2苄郆\uFFC8流琉韎", int_0))
                                                        {
                                                          c.int_2 = 130;
                                                          c.bool_2 = true;
                                                          c.byte_20 = (byte) 19;
                                                        }
                                                        else if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾菀\uEEC2规韆跈響\uF5CC\uF7CE\uE7D0", int_0))
                                                        {
                                                          c.int_2 = 130;
                                                          c.bool_2 = true;
                                                          c.byte_20 = (byte) 20;
                                                        }
                                                        else if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾菀\uEEC2郄蓆髈\uF3CA\uF4CCￎ\uE2D0", int_0))
                                                        {
                                                          c.int_2 = 130;
                                                          c.bool_2 = true;
                                                          c.byte_20 = (byte) 21;
                                                        }
                                                        else if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾菀\uEEC2蓄菆跈铊ﳌ", int_0))
                                                        {
                                                          c.int_2 = 130;
                                                          c.bool_2 = true;
                                                          c.byte_20 = (byte) 41;
                                                        }
                                                        else if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾菀\uEEC2蓄菆跈铊ￌ", int_0))
                                                        {
                                                          c.int_2 = 130;
                                                          c.bool_2 = true;
                                                          c.byte_20 = (byte) 42;
                                                        }
                                                        else if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾菀\uEEC2蓄菆跈铊ﻌ", int_0))
                                                        {
                                                          c.int_2 = 130;
                                                          c.bool_2 = true;
                                                          c.byte_20 = (byte) 43;
                                                        }
                                                        else if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾菀\uEEC2蓄菆跈铊琉", int_0))
                                                        {
                                                          c.int_2 = 130;
                                                          c.bool_2 = true;
                                                          c.byte_20 = (byte) 44;
                                                        }
                                                        else if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾菀\uEEC2蓄菆跈铊\uF8CC", int_0))
                                                        {
                                                          c.int_2 = 130;
                                                          c.bool_2 = true;
                                                          c.byte_20 = (byte) 45;
                                                        }
                                                        else if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾菀\uEEC2蓄菆跈铊\uFBCC", int_0))
                                                        {
                                                          c.int_2 = 130;
                                                          c.bool_2 = true;
                                                          c.byte_20 = (byte) 46;
                                                        }
                                                        else if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾菀\uEEC2蓄菆跈铊頻", int_0))
                                                        {
                                                          c.int_2 = 130;
                                                          c.bool_2 = true;
                                                          c.byte_20 = (byte) 47;
                                                        }
                                                        else if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾菀\uEEC2蓄菆跈铊\uF5CC", int_0))
                                                        {
                                                          c.int_2 = 130;
                                                          c.bool_2 = true;
                                                          c.byte_20 = (byte) 48;
                                                        }
                                                        else if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾菀\uEEC2蓄菆跈铊\uF4CC", int_0))
                                                        {
                                                          c.int_2 = 130;
                                                          c.bool_2 = true;
                                                          c.byte_20 = (byte) 49;
                                                        }
                                                        else if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾菀\uEEC2蓄菆跈铊ﳌￎ", int_0))
                                                        {
                                                          c.int_2 = 130;
                                                          c.bool_2 = true;
                                                          c.byte_20 = (byte) 50;
                                                        }
                                                        else if (this.string_0 == Module.a("\uE7B2颴辶覸论趼銾闀軂", int_0))
                                                          c.int_2 = 31;
                                                        else if (!(this.string_0 == Module.a("\uE7B2颴莶覸论趼銾闀軂", int_0)) && !(this.string_0 == Module.a("\uE7B2\uF8B4骶\uEDB8\uE3BA\uEBBC设", int_0)) && !(this.string_0 == Module.a("ﺲ\uF0B4\uF0B6\uF8B8隺\uEBBC设", int_0)))
                                                        {
                                                          if (!(this.string_0 == Module.a("\uE7B2颴莶覸论趼銾鋀軂\uF4C4\uF1C6ﻈ響\uF8CC", int_0)) && !(this.string_0 == Module.a("\uE0B2\uF8B4蚶辸貺貼誾\uE1C0闂\uF7C4", int_0)))
                                                          {
                                                            if (!(this.string_0 == Module.a("\uE7B2颴莶覸论趼銾鋀軂\uF4C4\uF1C6ﻈ響\uFBCC", int_0)) && !(this.string_0 == Module.a("\uE0B2\uF8B4蚶辸貺貼覾\uE1C0闂\uF7C4", int_0)))
                                                            {
                                                              if (this.string_0 == Module.a("\uE7B2颴莶覸论趼銾闀軂\uF4C4ﻆ", int_0))
                                                              {
                                                                c.int_2 = 50;
                                                                c.byte_20 = (byte) 5;
                                                              }
                                                              else if (this.string_0 == Module.a("\uE7B2颴莶覸论趼銾藀郂\uF4C4ￆ\uF0C8", int_0))
                                                              {
                                                                c.int_2 = 50;
                                                                c.byte_20 = (byte) 6;
                                                              }
                                                              else if (!(this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾闀軂", int_0)) && !(this.string_0 == Module.a("芲蒴螶覸隺\uEFBC\uE5BE燎", int_0)) && !(this.string_0 == Module.a("\uE7B2\uF8B4骶\uEDB8\uE3BA\uEBBC貾", int_0)) && !(this.string_0 == Module.a("ﺲ\uF0B4\uF0B6\uF8B8隺\uEBBC貾", int_0)) && !(this.string_0 == Module.a("莲芴蒶", int_0)))
                                                              {
                                                                if (!(this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾鋀軂\uF4C4\uF1C6ﻈ響\uF8CC", int_0)) && !(this.string_0 == Module.a("\uE0B2\uF8B4蚶辸貺貼誾\uE1C0闂\uF6C4", int_0)))
                                                                {
                                                                  if (!(this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾鋀軂\uF4C4\uF1C6ﻈ響\uFBCC", int_0)) && !(this.string_0 == Module.a("\uE0B2\uF8B4蚶辸貺貼覾\uE1C0闂\uF6C4", int_0)))
                                                                  {
                                                                    if (this.string_0 == Module.a("\uE7B2颴蚶覸论趼ﲾ\uECC0軂\uAAC4꧆ꛈ\uA8CAꗌ뷎뻐뻒냔", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 5;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾闀軂\uF4C4ﻆ", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 6;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾藀郂\uF4C4ￆ\uF0C8", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 7;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾铀胂雄\uEAC6\uF8C8\uFBCAￌ\uFBCE", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 8;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾藀軂鷄\uF5C6杻ￊ\uF5CC", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 9;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾\uF0C0\uF5C2\uF2C4\uF0C6", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 10;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾闀軂\uF4C4ￆ\uFBC8\uF2CA", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 11;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾鋀軂\uF4C4\uF1C6ﻈ流\uFBCC", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 12;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾\uF0C0\uFBC2ﷄ\uF5C6", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 13;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾\uF7C0\uFBC2\uF4C4\uF5C6", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 14;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾雀郂\uF7C4ￆ\uF8C8響", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 15;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾闀苂ﳄﻆ杻\uF2CA", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 16;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾\uF7C0\uF3C2\uF7C4\uF6C6", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 17;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾蛀铂\uF3C4\uF5C6靖鏊", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 18;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾蛀铂\uF3C4\uF5C6\uFDC8鏊", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 19;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾跀鏂臄\uF6C6\uF1C8\uF3CA\uFBCC", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 20;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾铀胂雄ￆ\uF0C8\uFBCAﻌ", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 21;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uF8B2颴蚶覸论趼銾胀迂规", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 22;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾闀軂\uF4C4ﻆ\uF8C8\uF8CA", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 41;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾闀軂\uF4C4ﻆ\uF8C8ￊ", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 42;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾胀蟂臄飆靖", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 43;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾胀蟂臄飆\uFDC8", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 44;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾胀蟂臄飆ﳈ", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 45;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾胀蟂臄飆\uFFC8", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 46;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾胀蟂臄飆ﻈ", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 47;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾胀蟂臄飆\uF1C8", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 48;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾胀蟂臄飆\uF0C8", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 49;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾胀蟂臄飆\uF8C8\uFBCA", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 50;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴薶覸论趼銾闀軂", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 61;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴薶覸论趼銾\uF0C0\uF5C2\uF2C4\uF6C6\uF8C8", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 62;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴薶覸论趼銾鋀軂\uF4C4\uF1C6ﻈ響\uFBCC", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 63;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴薶覸论趼銾鋀軂\uF4C4\uF1C6ﻈ流\uFBCC", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 64;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴薶覸论趼銾闀軂\uF4C4ￆ\uFBC8\uF2CA", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 65;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴薶覸论趼銾\uF7C0\uFBC2\uF5C4\uF4C6", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 66;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴薶覸论趼銾\uF8C0\uFBC2\uF4C4\uF4C6", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 67;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴薶覸论趼銾雀郂\uF7C4ￆ杻響", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 68;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴薶覸论趼銾雀郂\uF7C4ￆ\uF8C8響", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 69;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴薶覸论趼銾闀苂ﳄﻆ杻\uF2CA", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 70;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴薶覸论趼銾\uF7C0\uF3C2\uF7C4\uF6C6", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 71;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴薶覸论趼銾蛀铂\uF3C4\uF5C6靖鏊", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 72;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴薶覸论趼銾蛀铂\uF3C4\uF5C6\uFDC8鏊", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 73;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴薶覸论趼銾跀鏂臄\uF6C6\uF1C8\uF3CA\uFBCC", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 74;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴薶覸论趼銾铀胂雄ￆ\uF0C8\uFBCAﻌ", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 75;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴薶覸论趼銾胀蟂臄飆\uF8C8", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 91;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴薶覸论趼銾胀蟂臄飆\uFBC8", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 92;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴薶覸论趼銾胀蟂臄飆靖", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 93;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴薶覸论趼銾胀蟂臄飆\uFDC8", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 94;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴薶覸论趼銾胀蟂臄飆ﳈ", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 95;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴薶覸论趼銾胀蟂臄飆\uFFC8", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 96;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴薶覸论趼銾胀蟂臄飆ﻈ", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 97;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴薶覸论趼銾胀蟂臄飆\uF1C8", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 98;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴薶覸论趼銾胀蟂臄飆\uF0C8", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 99;
                                                                    }
                                                                    else if (this.string_0 == Module.a("\uE7B2颴薶覸论趼銾胀蟂臄飆\uF8C8\uFBCA", int_0))
                                                                    {
                                                                      c.int_2 = 32;
                                                                      c.byte_20 = (byte) 100;
                                                                    }
                                                                    else if (!(this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾藀軂鷄", int_0)) && !(this.string_0 == Module.a("\uF7B2\uF8B4\uEFB6馸\uEDBA袼", int_0)) && !(this.string_0 == Module.a("\uF7B2\uF8B4\uEFB6钸\uEFBA\uE5BC\uE9BE\uF0C0", int_0)) && !(this.string_0 == Module.a("ﶲﺴ\uF4B6钸论誼达", int_0)) && !(this.string_0 == Module.a("ﺲ\uF0B4\uF0B6\uF8B8隺寮\uF2BE駀闂\uF4C4", int_0)) && !(this.string_0 == Module.a("莲芴蚶", int_0)) && !(this.string_0 == Module.a("\uE5B2\uF6B4骶貸论趼ﶾ", int_0)) && !(this.string_0 == Module.a("膲蒴螶覸隺寮\uF2BE駀", int_0)))
                                                                    {
                                                                      if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾菀\uEEC2臄諆釈\uE6CA背ꃎ뿐볒뛔뿖ꯘ듚냜뫞", int_0))
                                                                      {
                                                                        c.int_2 = 110;
                                                                        c.byte_20 = (byte) 3;
                                                                      }
                                                                      else if (!(this.string_0 == Module.a("\uE7B2颴辶覸论趼銾藀軂鷄", int_0)) && !(this.string_0 == Module.a("\uF7B2\uF8B4\uEFB6馸\uEDBA貼", int_0)))
                                                                      {
                                                                        if (!(this.string_0 == Module.a("\uE7B2颴莶覸论趼銾藀軂鷄", int_0)) && !(this.string_0 == Module.a("\uF7B2\uF8B4\uEFB6馸\uEDBA込", int_0)))
                                                                        {
                                                                          if (!(this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾藀軂鷄", int_0)) && !(this.string_0 == Module.a("\uF7B2\uF8B4\uEFB6馸\uEDBA躼", int_0)) && !(this.string_0 == Module.a("\uF7B2\uF8B4\uEFB6钸\uEFBA\uE5BC\uE9BE\uF2C0", int_0)) && !(this.string_0 == Module.a("ﶲﺴ\uF4B6钸论誼貾", int_0)) && !(this.string_0 == Module.a("莲芴螶", int_0)) && !(this.string_0 == Module.a("芲蒴螶覸隺寮\uF2BE駀", int_0)))
                                                                          {
                                                                            if (!(this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0铂雄", int_0)) && !(this.string_0 == Module.a("膲螴螶覸隺\uF4BC\uF6BE苀\uFBC2", int_0)))
                                                                            {
                                                                              if (!(this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0韂裄", int_0)) && !(this.string_0 == Module.a("膲螴螶覸隺\uEFBC\uE5BE燎", int_0)) && !(this.string_0 == Module.a("\uE7B2\uF8B4骶\uEDB8\uE3BA\uEBBC趾", int_0)) && !(this.string_0 == Module.a("ﺲ\uF0B4\uF0B6\uF8B8隺\uEBBC趾", int_0)))
                                                                              {
                                                                                if (!(this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0郂裄\uF6C6\uFFC8ﳊﳌ龜", int_0)) && !(this.string_0 == Module.a("\uE0B2\uF8B4蚶辸貺貼誾\uE1C0闂\uF4C4藆", int_0)))
                                                                                {
                                                                                  if (!(this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0郂裄\uF6C6\uFFC8ﳊﳌ硫", int_0)) && !(this.string_0 == Module.a("\uE0B2\uF8B4蚶辸貺貼覾\uE1C0闂\uF4C4藆", int_0)))
                                                                                  {
                                                                                    if (this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0韂裄\uF6C6\uF0C8", int_0))
                                                                                    {
                                                                                      c.int_2 = 82;
                                                                                      c.byte_20 = (byte) 5;
                                                                                    }
                                                                                    else if (this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0蟂雄\uF6C6\uF1C8\uF2CA", int_0))
                                                                                    {
                                                                                      c.int_2 = 82;
                                                                                      c.byte_20 = (byte) 6;
                                                                                    }
                                                                                    else if (this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0雂蛄铆\uE4C8響\uFDCC\uFDCE\uE5D0", int_0))
                                                                                    {
                                                                                      c.int_2 = 82;
                                                                                      c.byte_20 = (byte) 7;
                                                                                    }
                                                                                    else if (this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0\uF2C2\uF3C4\uF0C6ﻈ", int_0))
                                                                                    {
                                                                                      c.int_2 = 82;
                                                                                      c.byte_20 = (byte) 10;
                                                                                    }
                                                                                    else if (this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0韂裄\uF6C6\uF1C8流\uF4CC", int_0))
                                                                                    {
                                                                                      c.int_2 = 82;
                                                                                      c.byte_20 = (byte) 11;
                                                                                    }
                                                                                    else if (this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0郂裄\uF6C6\uFFC8ﳊￌ硫", int_0))
                                                                                    {
                                                                                      c.int_2 = 82;
                                                                                      c.byte_20 = (byte) 12;
                                                                                    }
                                                                                    else if (this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0\uF2C2ﷄￆ\uFBC8", int_0))
                                                                                    {
                                                                                      c.int_2 = 82;
                                                                                      c.byte_20 = (byte) 13;
                                                                                    }
                                                                                    else if (this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0\uF5C2ﷄ\uF6C6\uFBC8", int_0))
                                                                                    {
                                                                                      c.int_2 = 82;
                                                                                      c.byte_20 = (byte) 14;
                                                                                    }
                                                                                    else if (this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0铂雄\uF5C6\uF1C8響ﳌ", int_0))
                                                                                    {
                                                                                      c.int_2 = 82;
                                                                                      c.byte_20 = (byte) 15;
                                                                                    }
                                                                                    else if (this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0韂蓄ﻆ\uF0C8\uFBCA\uF4CC", int_0))
                                                                                    {
                                                                                      c.int_2 = 82;
                                                                                      c.byte_20 = (byte) 16;
                                                                                    }
                                                                                    else if (this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0\uF5C2\uF5C4\uF5C6\uF8C8", int_0))
                                                                                    {
                                                                                      c.int_2 = 82;
                                                                                      c.byte_20 = (byte) 17;
                                                                                    }
                                                                                    else if (this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0蓂鋄\uF1C6\uFBC8\uF8CA闌", int_0))
                                                                                    {
                                                                                      c.int_2 = 82;
                                                                                      c.byte_20 = (byte) 18;
                                                                                    }
                                                                                    else if (this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0蓂鋄\uF1C6\uFBC8ￊ闌", int_0))
                                                                                    {
                                                                                      c.int_2 = 82;
                                                                                      c.byte_20 = (byte) 19;
                                                                                    }
                                                                                    else if (this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0迂闄菆\uF8C8\uF3CA\uF5CC硫", int_0))
                                                                                    {
                                                                                      c.int_2 = 82;
                                                                                      c.byte_20 = (byte) 20;
                                                                                    }
                                                                                    else if (this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0雂蛄铆\uF1C8\uF2CA\uFDCCﳎ", int_0))
                                                                                    {
                                                                                      c.int_2 = 82;
                                                                                      c.byte_20 = (byte) 21;
                                                                                    }
                                                                                    else if (this.string_0 == Module.a("\uF8B2颴辶覸论趼銾胀迂规", int_0))
                                                                                    {
                                                                                      c.int_2 = 82;
                                                                                      c.byte_20 = (byte) 22;
                                                                                    }
                                                                                    else if (this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0跂髄\uF1C6\uF1C8\uFBCAﻌ", int_0))
                                                                                    {
                                                                                      c.int_2 = 82;
                                                                                      c.byte_20 = (byte) 70;
                                                                                    }
                                                                                    else if (this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0苂臄菆雈響", int_0))
                                                                                    {
                                                                                      c.int_2 = 82;
                                                                                      c.byte_20 = (byte) 41;
                                                                                    }
                                                                                    else if (this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0苂臄菆雈流", int_0))
                                                                                    {
                                                                                      c.int_2 = 82;
                                                                                      c.byte_20 = (byte) 42;
                                                                                    }
                                                                                    else if (this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0苂臄菆雈\uF8CA", int_0))
                                                                                    {
                                                                                      c.int_2 = 82;
                                                                                      c.byte_20 = (byte) 43;
                                                                                    }
                                                                                    else if (this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0苂臄菆雈ￊ", int_0))
                                                                                    {
                                                                                      c.int_2 = 82;
                                                                                      c.byte_20 = (byte) 44;
                                                                                    }
                                                                                    else if (this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0苂臄菆雈ﻊ", int_0))
                                                                                    {
                                                                                      c.int_2 = 82;
                                                                                      c.byte_20 = (byte) 45;
                                                                                    }
                                                                                    else if (this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0苂臄菆雈\uFDCA", int_0))
                                                                                    {
                                                                                      c.int_2 = 82;
                                                                                      c.byte_20 = (byte) 46;
                                                                                    }
                                                                                    else if (this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0苂臄菆雈ﳊ", int_0))
                                                                                    {
                                                                                      c.int_2 = 82;
                                                                                      c.byte_20 = (byte) 47;
                                                                                    }
                                                                                    else if (this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0苂臄菆雈\uF3CA", int_0))
                                                                                    {
                                                                                      c.int_2 = 82;
                                                                                      c.byte_20 = (byte) 48;
                                                                                    }
                                                                                    else if (this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0苂臄菆雈\uF2CA", int_0))
                                                                                    {
                                                                                      c.int_2 = 82;
                                                                                      c.byte_20 = (byte) 49;
                                                                                    }
                                                                                    else if (this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0苂臄菆雈響\uFDCC", int_0))
                                                                                    {
                                                                                      c.int_2 = 82;
                                                                                      c.byte_20 = (byte) 50;
                                                                                    }
                                                                                    else if (!(this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0蟂裄鿆", int_0)) && !(this.string_0 == Module.a("\uF7B2\uF8B4\uEFB6馸\uEDBA貼ﶾ", int_0)) && !(this.string_0 == Module.a("ﶲﺴ\uF4B6钸论誼趾", int_0)) && !(this.string_0 == Module.a("ﺲ\uF0B4\uF0B6\uF8B8隺寮\uF2BE駀闂\uF4C4藆", int_0)) && !(this.string_0 == Module.a("膲螴螶覸隺寮\uF2BE駀", int_0)) && !(this.string_0 == Module.a("\uF7B2\uF8B4\uEFB6钸\uEFBA\uE5BC\uE9BE\uF3C0", int_0)) && !(this.string_0 == Module.a("ﶲﺴ\uF4B6钸论誼躾", int_0)) && !(this.string_0 == Module.a("ﺲ\uF0B4\uF0B6\uF8B8隺寮\uF2BE駀闂\uF7C4", int_0)))
                                                                                    {
                                                                                      if (!(this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0\uF5C2ﷄ\uF7C6靖", int_0)) && !(this.string_0 == Module.a("膲螴螶覸隺寮袾\uF1C0\uF6C2", int_0)))
                                                                                      {
                                                                                        if (!(this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0韂规铆", int_0)) && !(this.string_0 == Module.a("膲螴螶覸隺\uF0BC螾", int_0)) && !(this.string_0 == Module.a("\uE7B2領\uE4B6馸\uEDBA貼ﶾ", int_0)) && !(this.string_0 == Module.a("\uE7B2領\uE4B6馸\uEDBA貼ﶾ\uECC0軂", int_0)) && !(this.string_0 == Module.a("\uF0B2살얶춸\uDABA풼톾\uE1C0闂\uF4C4藆", int_0)))
                                                                                        {
                                                                                          if (this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0鏂ﳄￆ\uF8C8\uF8CA", int_0))
                                                                                          {
                                                                                            c.int_2 = 85;
                                                                                            c.byte_20 = (byte) 1;
                                                                                          }
                                                                                          else if (this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0\uF3C2ﷄ\uF6C6ﳈ", int_0))
                                                                                          {
                                                                                            c.int_2 = 85;
                                                                                            c.byte_20 = (byte) 2;
                                                                                          }
                                                                                          else if (this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0\uF3C2ﷄ\uF5C6ﳈ", int_0))
                                                                                          {
                                                                                            c.int_2 = 85;
                                                                                            c.byte_20 = (byte) 5;
                                                                                          }
                                                                                          else if (this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0\uF3C2ﳄ\uF7C6\uF8C8", int_0))
                                                                                          {
                                                                                            c.int_2 = 85;
                                                                                            c.byte_20 = (byte) 6;
                                                                                          }
                                                                                          else if (this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0苂闄蛆\uF8C8\uFBCAￌ", int_0))
                                                                                          {
                                                                                            c.int_2 = 85;
                                                                                            c.byte_20 = (byte) 8;
                                                                                          }
                                                                                          else if (this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0\uF5C2ﷄ\uF6C6靖", int_0))
                                                                                          {
                                                                                            c.int_2 = 85;
                                                                                            c.byte_20 = (byte) 9;
                                                                                          }
                                                                                          else if (this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0\uFBC2ﷄ\uF7C6\uFFC8", int_0))
                                                                                            c.int_2 = 86;
                                                                                        }
                                                                                        else
                                                                                          c.int_2 = 85;
                                                                                      }
                                                                                      else
                                                                                        c.int_2 = 84;
                                                                                    }
                                                                                    else
                                                                                      c.int_2 = 83;
                                                                                  }
                                                                                  else
                                                                                  {
                                                                                    c.int_2 = 82;
                                                                                    c.byte_20 = (byte) 4;
                                                                                  }
                                                                                }
                                                                                else
                                                                                {
                                                                                  c.int_2 = 82;
                                                                                  c.byte_20 = (byte) 3;
                                                                                }
                                                                              }
                                                                              else
                                                                                c.int_2 = 82;
                                                                            }
                                                                            else
                                                                              c.int_2 = 81;
                                                                          }
                                                                          else
                                                                            c.int_2 = 16;
                                                                        }
                                                                        else
                                                                          c.int_2 = 49;
                                                                      }
                                                                      else
                                                                        c.int_2 = 2;
                                                                    }
                                                                    else
                                                                      c.int_2 = 110;
                                                                  }
                                                                  else
                                                                  {
                                                                    c.int_2 = 32;
                                                                    c.byte_20 = (byte) 4;
                                                                  }
                                                                }
                                                                else
                                                                {
                                                                  c.int_2 = 32;
                                                                  c.byte_20 = (byte) 3;
                                                                }
                                                              }
                                                              else
                                                                c.int_2 = 32;
                                                            }
                                                            else
                                                            {
                                                              c.int_2 = 50;
                                                              c.byte_20 = (byte) 4;
                                                            }
                                                          }
                                                          else
                                                          {
                                                            c.int_2 = 50;
                                                            c.byte_20 = (byte) 3;
                                                          }
                                                        }
                                                        else
                                                          c.int_2 = 50;
                                                      }
                                                      else
                                                      {
                                                        c.byte_20 = (byte) 4;
                                                        c.int_2 = 130;
                                                        c.bool_2 = true;
                                                      }
                                                    }
                                                    else
                                                    {
                                                      c.byte_20 = (byte) 3;
                                                      c.int_2 = 130;
                                                      c.bool_2 = true;
                                                    }
                                                  }
                                                  else
                                                  {
                                                    c.int_2 = 130;
                                                    c.bool_2 = true;
                                                  }
                                                }
                                                else
                                                {
                                                  c.byte_20 = (byte) 4;
                                                  c.int_2 = 130;
                                                }
                                              }
                                              else
                                              {
                                                c.byte_20 = (byte) 3;
                                                c.int_2 = 130;
                                              }
                                            }
                                            else
                                              c.int_2 = 130;
                                          }
                                          else
                                            c.int_2 = 48;
                                        }
                                        else
                                          c.int_2 = 47;
                                      }
                                      else
                                        c.int_2 = 46;
                                    }
                                    else
                                    {
                                      c.int_2 = 140;
                                      c.byte_20 = (byte) 3;
                                    }
                                  }
                                  else
                                  {
                                    c.int_2 = 140;
                                    c.byte_20 = (byte) 0;
                                  }
                                }
                                else
                                  c.int_2 = 41;
                              }
                              else
                                c.int_2 = 54;
                            }
                            else
                              c.int_2 = 53;
                          }
                          else
                            c.int_2 = 52;
                        }
                        else
                          c.int_2 = 13;
                      }
                      else
                        c.int_2 = 12;
                    }
                    else
                      c.int_2 = 120;
                  }
                  else
                  {
                    c.int_2 = 102;
                    c.bool_2 = true;
                  }
                }
                else
                  c.int_2 = 102;
              }
              else
                c.int_2 = 101;
            }
            else
            {
              c.int_2 = 9;
              c.byte_20 = (byte) 0;
            }
          }
          else
            c.int_2 = 150;
        }
        else
          c.int_2 = 8;
      }
      else
        c.int_2 = 7;
    }
    else
      c.int_2 = 3;
    this.groupBox_1.Enabled = false;
    c.byte_1 = (byte) 0;
    if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾\uF1C0\uFBC2\uF7C4\uF2C6", int_0) || this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0\uF3C2ﷄ\uF5C6ﳈ", int_0) || this.string_0 == Module.a("\uE7B2颴莶覸论趼銾\uF1C0\uFBC2\uF7C4\uF2C6", int_0) || this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾\uF1C0\uFBC2\uF7C4\uF2C6", int_0) || this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾\uF1C0輸\uF5C4\uF6C6", int_0) || this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0\uF3C2ﳄ\uF7C6\uF8C8", int_0) || this.string_0 == Module.a("\uE7B2颴莶覸论趼銾\uF1C0輸\uF5C4\uF6C6", int_0) || this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾\uF1C0輸\uF5C4\uF6C6", int_0))
      c.byte_1 = (byte) 2;
    if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾闀軂\uF4C4ﻆ", int_0) || this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾菀\uEEC2釄諆\uF8C8\uF2CA", int_0) || this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0韂裄\uF6C6\uF0C8", int_0) || this.string_0 == Module.a("\uE7B2颴莶覸论趼銾闀軂\uF4C4ﻆ", int_0) || this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾闀軂\uF4C4ﻆ", int_0))
    {
      c.byte_1 = (byte) 1;
      this.groupBox_1.Enabled = true;
    }
    if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾闀軂\uF4C4ￆ\uFBC8\uF2CA", int_0) || this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾菀\uEEC2釄諆\uF8C8\uF3CAￌ\uF6CE", int_0) || this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0韂裄\uF6C6\uF1C8流\uF4CC", int_0) || this.string_0 == Module.a("\uE7B2颴莶覸论趼銾闀軂\uF4C4ￆ\uFBC8\uF2CA", int_0) || this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾闀軂\uF4C4ￆ\uFBC8\uF2CA", int_0) || this.string_0 == Module.a("\uE7B2颴薶覸论趼銾闀軂\uF4C4ￆ\uFBC8\uF2CA", int_0))
    {
      c.byte_1 = (byte) 1;
      this.groupBox_1.Enabled = true;
    }
    if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾菀\uEEC2釄蛆\uF0C8\uF2CA\uFDCC\uF6CE", int_0) || this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾闀苂ﳄﻆ杻\uF2CA", int_0) || this.string_0 == Module.a("\uE7B2颴薶覸论趼銾闀苂ﳄﻆ杻\uF2CA", int_0) || this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0韂蓄ﻆ\uF0C8\uFBCA\uF4CC", int_0))
    {
      c.byte_1 = (byte) 1;
      this.groupBox_1.Enabled = true;
    }
    if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾菀\uEEC2\uF4C4ￆ\uF1C8流", int_0) || this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0\uF2C2ﷄￆ\uFBC8", int_0) || this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾\uF0C0\uFBC2ﷄ\uF5C6", int_0))
      this.groupBox_1.Enabled = true;
    if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾菀\uEEC2\uF3C4ￆ\uF8C8流", int_0) || this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0\uF5C2ﷄ\uF6C6\uFBC8", int_0) || this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾\uF7C0\uFBC2\uF4C4\uF5C6", int_0))
      this.groupBox_1.Enabled = true;
    if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾\uF0C0\uF5C2\uF2C4\uF0C6", int_0) || this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾菀\uEEC2\uF4C4\uF1C6ﻈﳊ", int_0) || this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0\uF2C2\uF3C4\uF0C6ﻈ", int_0) || this.string_0 == Module.a("\uE7B2颴莶覸论趼銾\uF0C0\uF5C2\uF2C4\uF0C6", int_0) || this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾\uF0C0\uF5C2\uF2C4\uF0C6", int_0) || this.string_0 == Module.a("\uE7B2颴薶覸论趼銾\uF0C0\uF5C2\uF2C4\uF6C6\uF8C8", int_0))
    {
      c.byte_1 = (byte) 3;
      this.groupBox_1.Enabled = true;
      c.byte_3 = (byte) 21;
      c.byte_4 = (byte) 68;
      c.byte_5 = (byte) 0;
    }
    if (this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾鋀軂\uF4C4\uF1C6ﻈ流\uFBCC", int_0) || this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾菀\uEEC2雄諆\uF8C8\uFDCA頻\uFDCE\uE7D0", int_0) || this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0郂裄\uF6C6\uFFC8ﳊￌ硫", int_0) || this.string_0 == Module.a("\uE7B2颴莶覸论趼銾鋀軂\uF4C4\uF1C6ﻈ流\uFBCC", int_0) || this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾鋀軂\uF4C4\uF1C6ﻈ流\uFBCC", int_0) || this.string_0 == Module.a("\uE7B2颴薶覸论趼銾鋀軂\uF4C4\uF1C6ﻈ流\uFBCC", int_0))
    {
      c.byte_1 = (byte) 4;
      c.byte_3 = (byte) 36;
      c.byte_4 = (byte) 51;
      c.byte_5 = (byte) 0;
    }
    if (this.string_0 == Module.a("\uE7B2颴薶覸论趼銾蛀铂\uF3C4\uF5C6靖鏊", int_0) || this.string_0 == Module.a("\uE7B2颴薶覸论趼銾蛀铂\uF3C4\uF5C6\uFDC8鏊", int_0) || this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0蓂鋄\uF1C6\uFBC8\uF8CA闌", int_0) || this.string_0 == Module.a("\uE7B2颴辶覸论趼ﶾ\uECC0蓂鋄\uF1C6\uFBC8ￊ闌", int_0) || this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾菀\uEEC2苄郆\uFFC8流ﻌ韎", int_0) || this.string_0 == Module.a("\uE7B2颴蚶覸论\uF6BC銾菀\uEEC2苄郆\uFFC8流琉韎", int_0) || this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾蛀铂\uF3C4\uF5C6靖鏊", int_0) || this.string_0 == Module.a("\uE7B2颴蚶覸论趼銾蛀铂\uF3C4\uF5C6\uFDC8鏊", int_0))
    {
      c.byte_1 = (byte) 5;
      c.byte_3 = (byte) 5;
      c.byte_4 = (byte) 5;
      c.byte_5 = (byte) 5;
      c.byte_3 = c.byte_3;
      c.byte_4 |= (byte) 128;
      c.byte_5 = c.byte_5;
      c.byte_5 = c.byte_5;
      c.byte_3 |= (byte) 96;
      c.byte_4 |= (byte) 0;
    }
    if (c.useEnglishLanguage)
    {
      this.radioButton_3.Text = Module.a("\uE0B2\uD9B4\uD8B6캸鮺캼쾾꓀ꛂꇄ", int_0);
      this.radioButton_2.Text = Module.a("﮲\uDCB4킶톸鮺캼쾾꓀ꛂꇄ", int_0);
    }
    else
    {
      this.radioButton_3.Text = Module.a("﷽ꨤ", int_0);
      this.radioButton_2.Text = Module.a("欨ꨤ", int_0);
    }
    this.radioButton_5.Checked = true;
    this.groupBox_2.Enabled = false;
    if (c.int_2 == 140 || c.int_2 == 46 || c.int_2 == 47 || c.int_2 == 48 || c.int_2 == 85)
      this.groupBox_2.Enabled = true;
    if (c.int_2 == 2 || c.int_2 == 49 || c.int_2 == 16 || c.int_2 == 110 || c.int_2 == 83)
      this.groupBox_2.Enabled = true;
    if (c.int_2 == 31 || c.int_2 == 50 || c.int_2 == 32 || c.int_2 == 130 || c.int_2 == 82)
      this.groupBox_2.Enabled = true;
    this.groupBox_3.Enabled = false;
    if (c.byte_20 == (byte) 0 || c.byte_20 == (byte) 15 || c.byte_20 > (byte) 60)
    {
      switch (c.int_2)
      {
        case 12:
        case 13:
        case 41:
        case 81:
        case 120:
          this.groupBox_1.Enabled = true;
          this.radioButton_3.Text = Module.a("\uE4B2\uE6B4薶膸论貼", int_0);
          this.radioButton_2.Text = Module.a("\uE4B2\uE6B4薶膸论躼", int_0);
          this.groupBox_3.Enabled = true;
          break;
        case 31:
        case 32:
        case 50:
        case 82:
        case 130:
          this.groupBox_1.Enabled = true;
          break;
        case 46:
        case 47:
        case 48:
        case 85:
        case 140:
          this.groupBox_1.Enabled = true;
          this.radioButton_3.Text = Module.a("\uE7B2領\uE4B6誸论趼躾", int_0);
          this.radioButton_2.Text = Module.a("\uE7B2領\uE4B6誸论趼螾", int_0);
          break;
        default:
          this.groupBox_1.Enabled = false;
          break;
      }
    }
    if (c.byte_20 == (byte) 3 && (c.int_2 == 31 || c.int_2 == 50 || c.int_2 == 32 || c.int_2 == 130 || c.int_2 == 82))
      this.groupBox_1.Enabled = true;
    if (c.int_2 != 2 && c.int_2 != 49 && c.int_2 != 16 && c.int_2 != 110 && c.int_2 != 83)
    {
      if (c.int_2 == 12 || c.int_2 == 31 || c.int_2 == 50 || c.int_2 == 81 || c.int_2 == 86 || c.int_2 == 82 || c.int_2 == 85 || c.int_2 == 41 || c.int_2 == 46 || c.int_2 == 48 || c.int_2 == 53 || c.int_2 == 54)
      {
        if (c.useEnglishLanguage)
        {
          this.radioButton_1.Text = Module.a("蚲蒴薶馸ힺ풼\uD8BE꧀럂뛄\uE7C6마껊뿌\uEFCE臐볒\uA7D4ꏖ", int_0);
          this.radioButton_0.Text = Module.a("芲薴薶趸鮺톼횾ꛀꯂ뇄듆\uE9C8믊\uA8CC뷎\uF1D0菒뫔ꗖ귘", int_0);
        }
        else
        {
          this.radioButton_1.Text = Module.a("糙\u9FFA壌嫫躺貼趾꺰", int_0);
          this.radioButton_0.Text = Module.a("糙\u9FFA壌嫫誺趼趾\uF5C0겲", int_0);
        }
      }
    }
    else if (c.useEnglishLanguage)
    {
      this.radioButton_1.Text = Module.a("\uE0B2솴횶ힸ\uDFBA\uDCBC춾ꗀ\uE3C2臄諆釈ﻊﳌ\uFDCE", int_0);
      this.radioButton_0.Text = Module.a("\uE0B2솴횶ힸ\uDFBA\uDCBC춾ꗀ\uE3C2臄諆釈ﻊﳌ\uFDCE", int_0);
    }
    else
    {
      this.radioButton_1.Text = Module.a("듚珥\uF3B6\uF4B8\uE3BA袼躾\uF3C0貑歏", int_0);
      this.radioButton_0.Text = Module.a("듚珥\uF3B6\uF4B8\uE3BA袼躾\uF3C0貑歏", int_0);
    }
    if (c.int_2 == 12 || c.int_2 == 41 || c.int_2 == 13 || c.int_2 == 120 || c.int_2 == 81)
    {
      if (c.useEnglishLanguage)
      {
        this.groupBox_3.Text = Module.a("\uF7B2풴쎶\uD8B8鮺\uDCBC\uDBBEꯀ뛂뛄돆\uA4C8껊ꏌ믎", int_0);
        this.radioButton_6.Text = Module.a("\uF6B2풴풶톸鮺캼횾맀\uEEC2뗄\uA8C6ꃈꗊ만\uEFCEꏐ뛒ꏔ닖ꯘ\uA8DA룜", int_0);
        this.radioButton_8.Text = Module.a("\uF6B2풴풶톸鮺\uDBBC킾듀뇂\uE8C4럆ꛈꋊꏌ믎\uF1D0ꇒ냔ꇖ볘\uA9DA껜뫞", int_0);
        this.radioButton_7.Text = Module.a("ﶲ\uDAB4얶풸\uDABA톼龾곀곂ꇄꋆ", int_0);
      }
      else
      {
        this.groupBox_3.Text = Module.a("쏗\uDBD7됺췝", int_0);
        this.radioButton_6.Text = Module.a("糙\uD8E5ໆ瓫ꫮ", int_0);
        this.radioButton_8.Text = Module.a("糙滢ໆ瓫ꫮ", int_0);
        this.radioButton_7.Text = Module.a("탙跪雜뛧", int_0);
      }
    }
    if (c.int_2 != 2 && c.int_2 != 49 && c.int_2 != 16 && c.int_2 != 110 && c.int_2 != 83)
      return;
    this.groupBox_3.Enabled = true;
    if (c.useEnglishLanguage)
    {
      this.groupBox_3.Text = Module.a("\uF7B2\uF8B4\uEFB6馸\uEBBA쾼킾뗀곂ꛄ\uA8C6ꗈ", int_0);
      this.radioButton_6.Text = Module.a("\uE0B2솴횶ힸ\uDFBA\uDCBC춾ꗀ\uE3C2臄諆釈\uEBCA뷌뷎뻐\uA7D2뫔듖뛘럚\uFDDC\uF7DE폠훢헤곦诨鯪黬웮", int_0);
      this.radioButton_8.Text = Module.a("\uE0B2솴횶ힸ\uDFBA\uDCBC춾ꗀ\uE3C2臄諆釈\uEBCA뷌ꏎꓐꃒ\uF5D4돖볘럚볜ꛞ쇠\uDBE2郤铦", int_0);
      this.radioButton_7.Text = Module.a("蚲薴螶\uF2B8\uD9BA춼첾\uE1C0藂럄ꋆ룈뻊\uA8CCꇎ닐\uAAD2", int_0);
    }
    else
    {
      this.groupBox_3.Text = Module.a("\uF7B2\uF8B4\uEFB6\uF6EBᔱ", int_0);
      this.radioButton_6.Text = Module.a("듚珥\uF3B6\uF4B8\uE3BA\uF2EFᄵ\uE9C0\uF1C2\uF0C4\uF7C6苈꧊뷌볎\uF8D0", int_0);
      this.radioButton_8.Text = Module.a("듚珥\uF3B6\uF4B8\uE3BAᷮ䧠㞥\uFBC2냄듆", int_0);
      this.radioButton_7.Text = Module.a("蚲薴螶\uF2B8\uD9BA춼첾偘䒱", int_0);
    }
  }

  [SpecialName]
  public string method_2() => this.textBox_0.Text;

  private void button_1_Click(object sender, EventArgs e)
  {
    SaveFileDialog saveFileDialog = new SaveFileDialog();
    saveFileDialog.Title = Module.a("\uEBB7\uDBB9쪻\uDBBD\uE0BFꏁ럃\uE8C5\uE6C7\uE4C9", 18);
    saveFileDialog.AddExtension = true;
    saveFileDialog.DefaultExt = Module.a("좷승\uDEBB", 18);
    saveFileDialog.Filter = Module.a("\uE8B7좹펻풽ꖿꇁ냃\uE6C5軇ꏉꃋꯍ\uF8CF\uF8D1䀘ꛕꃗ룙\uF5DBꋝ쫟쳡铣黥諧雩귫苭鳯틱닳\u9FF5铷\u9FF9퓻퓽\u2EFF⠁ⴃ稅∇␉☋", 18);
    if (saveFileDialog.ShowDialog() != DialogResult.OK)
      return;
    this.textBox_0.Text = saveFileDialog.FileName;
  }

  private void button_0_Click(object sender, EventArgs e)
  {
    int int_0 = 3;
    if (this.comboBox_0.SelectedIndex == -1)
      this.comboBox_0.SelectedIndex = 19;
    if (this.comboBox_1.SelectedIndex == -1)
      this.comboBox_1.SelectedIndex = 0;
    c.smethod_1(this.comboBox_0.SelectedIndex + 1);
    c.int_81 = this.comboBox_1.SelectedIndex;
    c.byte_19 = (byte) 1;
    c.bool_14 = false;
    if (this.string_0 == Module.a("ﶨ蚪鲬龮膰\uF8B2颴\uE3B6\uF4B8誺蒼", int_0) || this.string_0 == Module.a("ﶨ蚪鲬龮膰\uF8B2颴\uF5B6钸\uEFBA\uF0BC躾\uF8C0", int_0) || this.string_0 == Module.a("ﶨ蚪閬龮膰莲\uF7B4骶\uEDB8\uF6BA貼蚾", int_0) || this.string_0 == Module.a("ﶨ蚪馬龮膰莲颴\uE3B6\uF4B8誺蒼", int_0) || this.string_0 == Module.a("ﶨ蚪鲬龮膰莲颴\uE3B6\uF4B8誺蒼", int_0))
      c.byte_19 = !this.radioButton_3.Checked ? (byte) 170 : (byte) 85;
    if (this.string_0 == Module.a("ﶨ蚪鲬龮膰\uF8B2颴\uE3B6\uF4B8誺薼趾\uF8C0", int_0) || this.string_0 == Module.a("ﶨ蚪鲬龮膰\uF8B2颴\uF5B6钸\uEFBA\uF0BC躾燎\uF1C2ﳄ", int_0) || this.string_0 == Module.a("ﶨ蚪閬龮膰莲\uF7B4骶\uEDB8\uF6BA貼螾\uF3C0輸", int_0) || this.string_0 == Module.a("ﶨ蚪馬龮膰莲颴\uE3B6\uF4B8誺薼趾\uF8C0", int_0) || this.string_0 == Module.a("ﶨ蚪鲬龮膰莲颴\uE3B6\uF4B8誺薼趾\uF8C0", int_0))
      c.byte_19 = !this.radioButton_3.Checked ? (byte) 170 : (byte) 85;
    if (this.string_0 == Module.a("ﶨ蚪鲬龮膰\uF8B2颴\uF5B6钸誺薼螾\uF3C0", int_0) || this.string_0 == Module.a("ﶨ蚪閬龮膰莲\uF7B4骶袸莺薼趾", int_0) || this.string_0 == Module.a("ﶨ蚪鲬龮膰莲颴蚶膸莺込", int_0))
      c.byte_19 = !this.radioButton_3.Checked ? (byte) 170 : (byte) 85;
    if (this.string_0 == Module.a("ﶨ蚪鲬龮膰\uF8B2颴\uF5B6钸趺薼躾\uF3C0", int_0) || this.string_0 == Module.a("ﶨ蚪閬龮膰莲\uF7B4骶辸莺貼趾", int_0) || this.string_0 == Module.a("ﶨ蚪鲬龮膰莲颴膶膸誺込", int_0))
      c.byte_19 = !this.radioButton_3.Checked ? (byte) 170 : (byte) 85;
    if (this.string_0 == Module.a("ﶨ蚪鲬龮膰\uF8B2颴蚶辸貺誼", int_0) || this.string_0 == Module.a("ﶨ蚪鲬龮膰\uF8B2颴\uF5B6钸誺讼袾\uF6C0", int_0) || this.string_0 == Module.a("ﶨ蚪閬龮膰莲\uF7B4骶袸趺誼袾", int_0) || this.string_0 == Module.a("ﶨ蚪馬龮膰莲颴蚶辸貺誼", int_0) || this.string_0 == Module.a("ﶨ蚪鲬龮膰莲颴蚶辸貺誼", int_0))
      c.byte_19 = !this.radioButton_3.Checked ? (byte) 170 : (byte) 85;
    if (c.byte_20 == (byte) 0 || c.byte_20 == (byte) 15 || c.byte_20 > (byte) 60)
    {
      switch (c.int_2)
      {
        case 12:
        case 13:
        case 41:
        case 81:
        case 120:
          c.bool_14 = !this.radioButton_3.Checked;
          c.byte_19 = !this.radioButton_6.Checked ? (!this.radioButton_8.Checked ? (byte) 3 : (byte) 2) : (byte) 1;
          break;
        case 31:
        case 32:
        case 50:
        case 82:
        case 130:
          c.byte_19 = !this.radioButton_3.Checked ? (byte) 170 : (byte) 85;
          break;
      }
    }
    if (c.byte_20 == (byte) 3 && (c.int_2 == 31 || c.int_2 == 50 || c.int_2 == 32 || c.int_2 == 130 || c.int_2 == 82))
      c.byte_19 = !this.radioButton_3.Checked ? (byte) 170 : (byte) 85;
    c.bool_18 = false;
    if (c.int_2 == 140 || c.int_2 == 46 || c.int_2 == 47 || c.int_2 == 48 || c.int_2 == 85)
    {
      c.bool_18 = !this.radioButton_5.Checked;
      c.bool_17 = !this.radioButton_3.Checked;
    }
    if (c.int_2 == 2 || c.int_2 == 49 || c.int_2 == 16 || c.int_2 == 110 || c.int_2 == 83)
    {
      c.bool_18 = !this.radioButton_5.Checked;
      if (c.byte_20 != (byte) 3)
      {
        c.byte_20 = (byte) 0;
        if (this.radioButton_6.Checked)
          c.byte_20 = (byte) 0;
        else if (this.radioButton_8.Checked)
          c.byte_20 = (byte) 1;
        else if (this.radioButton_7.Checked)
          c.byte_20 = (byte) 2;
      }
    }
    if (c.int_2 == 31 || c.int_2 == 50 || c.int_2 == 32 || c.int_2 == 130 || c.int_2 == 82)
      c.bool_18 = !this.radioButton_5.Checked;
    string path = c.string_2 + Module.a("\uF5A8\uDFAA\uD9AC횮솰횲\uEAB4쒶쪸誺趼醾뗀믂뇄", int_0);
    if (File.Exists(path))
      File.Delete(path);
    using (StreamWriter streamWriter = new StreamWriter(path, false, Encoding.ASCII))
      streamWriter.WriteLine(c.string_7);
    this.DialogResult = DialogResult.OK;
  }

  private void button_2_Click(object sender, EventArgs e) => this.Close();

  private void method_3()
  {
    int int_0 = 7;
    this.groupBox_4.Enabled = false;
    this.radioButton_0.Enabled = true;
    int num1 = 512;
    if (c.int_2 != 2 && c.int_2 != 49 && c.int_2 != 16 && c.int_2 != 110 && c.int_2 != 83)
    {
      if (c.int_2 == 12 || c.int_2 == 31 || c.int_2 == 50 || c.int_2 == 81 || c.int_2 == 86 || c.int_2 == 82 || c.int_2 == 85 || c.int_2 == 41 || c.int_2 == 46 || c.int_2 == 48 || c.int_2 == 53 || c.int_2 == 54)
      {
        if (this.radioButton_1.Checked)
        {
          c.bool_3 = false;
          num1 = 512;
        }
        else
        {
          c.bool_3 = true;
          num1 = 1024;
        }
      }
    }
    else
    {
      this.radioButton_0.Enabled = false;
      if (this.radioButton_1.Checked)
      {
        c.bool_1 = false;
        num1 = 512;
      }
      else
      {
        c.bool_1 = true;
        num1 = 170;
      }
    }
    if (c.int_2 != 101 && c.int_2 != 103 && c.int_2 != 14 && c.int_2 != 15)
      this.groupBox_4.Enabled = false;
    else
      this.groupBox_4.Enabled = true;
    if (c.int_2 == 101 || c.int_2 == 103)
    {
      if (this.radioButton_1.Checked)
        c.int_2 = 101;
      else if (this.radioButton_0.Checked)
        c.int_2 = 103;
    }
    if (c.int_2 == 14 || c.int_2 == 15)
    {
      if (this.radioButton_1.Checked)
        c.int_2 = 14;
      else if (this.radioButton_0.Checked)
        c.int_2 = 15;
    }
    this.textBox_1.ReadOnly = true;
    if (c.int_2 == 3)
    {
      this.label_5.Text = Module.a("\uF7ACﺮﶰ課芴蚶许鞺誼设觀胂\uF0C4ﻆﳈ\uE7CA背跎飐\uE6D2\uE5D4\uE5D6\uEFD8", int_0);
      this.label_6.Text = Module.a("閬", int_0);
      c.int_75 = 8;
      int num2 = c.int_8 + c.int_9 + c.int_10 + 3;
      this.textBox_1.Text = ((768 - (int) c.byte_0) / num2).ToString();
      this.textBox_1.ReadOnly = true;
      c.int_74 = 256;
      this.groupBox_4.Enabled = true;
      this.groupBox_0.Visible = true;
    }
    if (c.int_2 == 14)
    {
      this.label_5.Text = Module.a("\uF7ACﺮﶰ課芴蚶许鞺誼设觀胂\uF0C4ﻆﳈ\uE7CA背跎飐\uE6D2\uE5D4\uE5D6\uEFD8", int_0);
      this.label_6.Text = Module.a("鲬", int_0);
      int num3 = c.int_8 + c.int_9 + c.int_10 + 3;
      this.textBox_1.Text = ((768 - (int) c.byte_0) / num3).ToString();
      this.textBox_1.ReadOnly = true;
      c.int_74 = 256;
      this.groupBox_4.Enabled = true;
      this.groupBox_0.Visible = true;
    }
    if (c.int_2 == 7)
    {
      this.label_5.Text = Module.a("\uE1ACﾮ\uF5B0薲趴螶誸鞺寮袾\uF1C0\uF6C2", int_0);
      this.label_6.Text = Module.a("馬", int_0);
      c.int_75 = 8;
      this.textBox_1.Text = Module.a("鲬龮莰螲", int_0);
      c.int_74 = 1024;
    }
    if (c.int_2 == 8)
    {
      this.label_5.Text = Module.a("\uE1ACﾮ\uF5B0薲趴螶誸鞺寮袾\uF1C0\uF6C2", int_0);
      this.label_6.Text = Module.a("閬", int_0);
      c.int_75 = 8;
      this.textBox_1.Text = Module.a("鲬龮莰螲", int_0);
      c.int_74 = 1024;
    }
    if (c.int_2 == 9)
    {
      this.label_5.Text = Module.a("\uE1ACﾮ\uF5B0薲趴螶誸鞺寮袾\uF1C0\uF6C2", int_0);
      this.label_6.Text = Module.a("鲬", int_0);
      this.textBox_1.Text = Module.a("龬龮薰讲", int_0);
      c.int_74 = 2048;
      this.groupBox_0.Visible = false;
    }
    else if (c.int_2 == 101)
    {
      this.label_5.Text = Module.a("\uF7ACﺮﶰ課芴蚶许鞺誼设觀胂\uF0C4ﻆﳈ\uE7CA背跎飐\uE6D2\uE5D4\uE5D6\uEFD8", int_0);
      this.label_6.Text = Module.a("閬", int_0);
      c.int_75 = 8;
      int num4 = c.int_8 + c.int_9 + c.int_10 + 3;
      this.textBox_1.Text = ((768 - (int) c.byte_0) / num4).ToString();
      this.textBox_1.ReadOnly = true;
      c.int_74 = 256;
      this.groupBox_4.Enabled = true;
      this.groupBox_0.Visible = true;
    }
    else if (c.int_2 == 103)
    {
      this.label_5.Text = Module.a("\uF7ACﺮﶰ課芴蚶许鞺誼设觀胂\uF0C4ﻆﳈ\uE7CA背跎飐\uE6D2\uE5D4\uE5D6\uEFD8", int_0);
      this.label_6.Text = Module.a("閬", int_0);
      c.int_75 = 8;
      int num5 = c.int_8 + c.int_9 + c.int_10 + 3;
      this.textBox_1.Text = ((1536 - (int) c.byte_0) / num5).ToString();
      this.textBox_1.ReadOnly = true;
      c.int_74 = 512;
      this.groupBox_4.Enabled = true;
      this.groupBox_0.Visible = true;
    }
    else if (c.int_2 == 15)
    {
      this.label_5.Text = Module.a("\uF7ACﺮﶰ課芴蚶许鞺誼设觀胂\uF0C4ﻆﳈ\uE7CA背跎飐\uE6D2\uE5D4\uE5D6\uEFD8", int_0);
      this.label_6.Text = Module.a("鲬", int_0);
      c.int_75 = 8;
      int num6 = c.int_8 + c.int_9 + c.int_10 + 3;
      this.textBox_1.Text = ((1536 - (int) c.byte_0) / num6).ToString();
      this.textBox_1.ReadOnly = true;
      c.int_74 = 512;
      this.groupBox_4.Enabled = true;
      this.groupBox_0.Visible = true;
    }
    else if (c.int_2 == 102)
    {
      this.label_5.Text = Module.a("\uE1ACﾮ\uF5B0薲趴螶誸鞺寮袾\uF1C0\uF6C2", int_0);
      this.label_6.Text = Module.a("閬", int_0);
      c.int_75 = 8;
      this.textBox_1.Text = c.int_4.ToString();
      this.textBox_1.ReadOnly = true;
      c.int_74 = c.int_4;
      this.groupBox_0.Visible = false;
    }
    else if (c.int_2 == 84)
    {
      this.label_5.Text = Module.a("\uE1ACﾮ\uF5B0薲趴螶誸鞺寮袾\uF1C0\uF6C2", int_0);
      this.label_6.Text = Module.a("閬", int_0);
      c.int_75 = 8;
      this.textBox_1.Text = c.int_4.ToString();
      this.textBox_1.ReadOnly = true;
      c.int_74 = c.int_4;
      this.groupBox_0.Visible = false;
    }
    else if (c.int_2 == 201)
    {
      this.label_5.Text = Module.a("엽웱탗ﳮ\u12D7臤䋄擄醼늾쯀\uECA7쒧\uF5C6ﳈ\uFDCA\uE7CCﳎ\uE3D0\u1C82\uF5A9혩", int_0);
      this.label_6.Text = Module.a("鲬馮", int_0);
      c.int_75 = 16;
      this.textBox_1.Text = Module.a("龬骮螰", int_0);
      this.textBox_1.ReadOnly = true;
      c.int_74 = 256;
      this.groupBox_0.Visible = false;
    }
    else if (c.int_2 == 120)
    {
      this.label_5.Text = Module.a("窱ﲮ莰讲薴蚶閸\uECBA\uEEBC趾燎\uF3C2\uF6C4옹", int_0);
      this.label_6.Text = Module.a("閬", int_0);
      c.int_75 = 8;
      this.textBox_1.Text = Module.a("颬麮莰", int_0);
      this.textBox_1.ReadOnly = true;
      c.int_74 = 512;
      this.groupBox_0.Visible = false;
    }
    else if (c.int_2 == 150)
    {
      this.label_5.Text = Module.a("\uE1ACﾮ\uF5B0讲趴螶辸鞺\uF1BC\uEFBE藀\uFBC2ﷄ\uF7C6\uF0C8쨵", int_0);
      this.label_6.Text = Module.a("閬", int_0);
      c.int_75 = 8;
      this.textBox_1.Text = Module.a("颬麮莰", int_0);
      this.textBox_1.ReadOnly = true;
      c.int_74 = 512;
      this.groupBox_0.Visible = false;
    }
    else if (c.int_2 == 140)
    {
      this.label_5.Text = Module.a("怜\uE3AE\uE2B0育薴螶袸鞺\uE9BC\uF3BE鋀\uF0C2\uF5C4\uF7C6\uF1C8쨵", int_0);
      this.label_6.Text = Module.a("閬", int_0);
      c.int_75 = 8;
      this.textBox_1.Text = Module.a("颬麮莰", int_0);
      this.textBox_1.ReadOnly = true;
      c.int_74 = 512;
      this.groupBox_0.Visible = false;
    }
    else if (c.int_2 == 12)
    {
      this.label_5.Text = Module.a("窱ﲮ莰讲薴蚶閸\uECBA\uEEBC趾燎\uF3C2\uF6C4옹", int_0);
      this.label_6.Text = Module.a("閬", int_0);
      c.int_75 = 8;
      this.textBox_1.Text = num1.ToString();
      this.textBox_1.ReadOnly = true;
      c.int_74 = num1;
      this.groupBox_0.Visible = false;
      this.groupBox_4.Enabled = true;
    }
    else if (c.int_2 == 54)
    {
      this.label_5.Text = Module.a("\uE1ACﾮ\uF5B0讲趴螶辸鞺\uF1BC\uEFBE藀\uFBC2ﷄ\uF7C6\uF0C8쨵", int_0);
      this.label_6.Text = Module.a("閬", int_0);
      c.int_75 = 8;
      this.textBox_1.Text = num1.ToString();
      this.textBox_1.ReadOnly = true;
      c.int_74 = num1;
      this.groupBox_0.Visible = false;
      this.groupBox_4.Enabled = true;
    }
    else if (c.int_2 == 46)
    {
      this.label_5.Text = Module.a("怜\uE3AE\uE2B0育薴螶袸鞺\uE9BC\uF3BE鋀\uF0C2\uF5C4\uF7C6\uF1C8쨵", int_0);
      this.label_6.Text = Module.a("閬", int_0);
      c.int_75 = 8;
      this.textBox_1.Text = num1.ToString();
      this.textBox_1.ReadOnly = true;
      c.int_74 = num1;
      this.groupBox_0.Visible = false;
      this.groupBox_4.Enabled = true;
    }
    else if (c.int_2 == 48)
    {
      this.label_5.Text = Module.a("怜\uE3AE\uE2B0育薴螶袸鞺\uE9BC\uF3BE鋀\uF0C2\uF5C4\uF7C6\uF1C8쨵", int_0);
      this.label_6.Text = Module.a("馬", int_0);
      c.int_75 = 8;
      this.textBox_1.Text = num1.ToString();
      this.textBox_1.ReadOnly = true;
      c.int_74 = num1;
      this.groupBox_0.Visible = false;
      this.groupBox_4.Enabled = true;
    }
    else if (c.int_2 == 41)
    {
      this.label_5.Text = Module.a("窱ﲮ莰讲薴蚶閸\uECBA\uEEBC趾燎\uF3C2\uF6C4옹", int_0);
      this.label_6.Text = Module.a("馬", int_0);
      c.int_75 = 8;
      this.textBox_1.Text = num1.ToString();
      this.textBox_1.ReadOnly = true;
      c.int_74 = num1;
      this.groupBox_0.Visible = false;
      this.groupBox_4.Enabled = true;
    }
    else if (c.int_2 == 53)
    {
      this.label_5.Text = Module.a("\uE1ACﾮ\uF5B0讲趴螶辸鞺\uF1BC\uEFBE藀\uFBC2ﷄ\uF7C6\uF0C8쨵", int_0);
      this.label_6.Text = Module.a("馬", int_0);
      c.int_75 = 8;
      this.textBox_1.Text = num1.ToString();
      this.textBox_1.ReadOnly = true;
      c.int_74 = num1;
      this.groupBox_0.Visible = false;
      this.groupBox_4.Enabled = true;
    }
    else if (c.int_2 == 81)
    {
      this.label_5.Text = Module.a("窱ﲮ莰讲薴蚶閸\uECBA\uEEBC趾燎\uF3C2\uF6C4옹", int_0);
      this.label_6.Text = Module.a("閬", int_0);
      c.int_75 = 8;
      this.textBox_1.Text = num1.ToString();
      this.textBox_1.ReadOnly = true;
      c.int_74 = num1;
      this.groupBox_0.Visible = false;
      this.groupBox_4.Enabled = true;
    }
    else if (c.int_2 == 86)
    {
      this.label_5.Text = Module.a("\uE1ACﾮ\uF5B0讲趴螶辸鞺\uF1BC\uEFBE藀\uFBC2ﷄ\uF7C6\uF0C8쨵", int_0);
      this.label_6.Text = Module.a("閬", int_0);
      c.int_75 = 8;
      this.textBox_1.Text = num1.ToString();
      this.textBox_1.ReadOnly = true;
      c.int_74 = num1;
      this.groupBox_0.Visible = false;
      this.groupBox_4.Enabled = true;
    }
    else if (c.int_2 == 85)
    {
      this.label_5.Text = Module.a("怜\uE3AE\uE2B0育薴螶袸鞺\uE9BC\uF3BE鋀\uF0C2\uF5C4\uF7C6\uF1C8쨵", int_0);
      this.label_6.Text = Module.a("閬", int_0);
      c.int_75 = 8;
      this.textBox_1.Text = num1.ToString();
      this.textBox_1.ReadOnly = true;
      c.int_74 = num1;
      this.groupBox_0.Visible = false;
      this.groupBox_4.Enabled = true;
    }
    else if (c.int_2 == 13)
    {
      this.label_5.Text = Module.a("窱ﲮ莰讲薴蚶閸\uECBA\uEEBC趾燎\uF3C2\uF6C4옹", int_0);
      this.label_6.Text = Module.a("鲬", int_0);
      this.textBox_1.Text = Module.a("龬龮薰讲", int_0);
      this.textBox_1.ReadOnly = true;
      c.int_74 = 2048;
      this.groupBox_0.Visible = false;
    }
    else if (c.int_2 == 47)
    {
      this.label_5.Text = Module.a("怜\uE3AE\uE2B0育薴螶袸鞺\uE9BC\uF3BE鋀\uF0C2\uF5C4\uF7C6\uF1C8쨵", int_0);
      this.label_6.Text = Module.a("鲬", int_0);
      this.textBox_1.Text = Module.a("龬龮薰讲", int_0);
      this.textBox_1.ReadOnly = true;
      c.int_74 = 2048;
      this.groupBox_0.Visible = false;
    }
    else if (c.int_2 == 130)
    {
      this.label_5.Text = Module.a("怜\uE2AE肰讲薴蒶閸\uEFBA\uF0BC躾燎\uF3C2\uF1C4옹", int_0);
      this.label_6.Text = Module.a("閬", int_0);
      c.int_75 = 8;
      this.textBox_1.Text = Module.a("颬麮莰", int_0);
      this.textBox_1.ReadOnly = true;
      c.int_74 = 512;
      this.groupBox_0.Visible = false;
    }
    else if (c.int_2 == 180)
    {
      this.label_5.Text = Module.a("怜芮蒰莲薴ﲶ钸諸\uF1BC\uF3BE쀿", int_0);
      this.label_6.Text = Module.a("閬", int_0);
      c.int_75 = 8;
      this.textBox_1.Text = Module.a("骬馮覰", int_0);
      this.textBox_1.ReadOnly = true;
      c.int_74 = 768;
      this.groupBox_0.Visible = false;
    }
    else if (c.int_2 == 31)
    {
      this.label_5.Text = Module.a("怜\uE2AE肰讲薴蒶閸\uEFBA\uF0BC躾燎\uF3C2\uF1C4옹", int_0);
      this.label_6.Text = Module.a("閬", int_0);
      c.int_75 = 8;
      this.textBox_1.Text = num1.ToString();
      this.textBox_1.ReadOnly = true;
      c.int_74 = num1;
      this.groupBox_0.Visible = false;
      this.groupBox_4.Enabled = true;
    }
    else if (c.int_2 == 50)
    {
      this.label_5.Text = Module.a("怜\uE2AE肰讲薴蒶閸\uEFBA\uF0BC躾燎\uF3C2\uF1C4옹", int_0);
      this.label_6.Text = Module.a("馬", int_0);
      c.int_75 = 8;
      this.textBox_1.Text = num1.ToString();
      this.textBox_1.ReadOnly = true;
      c.int_74 = num1;
      this.groupBox_0.Visible = false;
      this.groupBox_4.Enabled = true;
    }
    else if (c.int_2 == 82)
    {
      this.label_5.Text = Module.a("怜\uE2AE肰讲薴蒶閸\uEFBA\uF0BC躾燎\uF3C2\uF1C4옹", int_0);
      this.label_6.Text = Module.a("閬", int_0);
      c.int_75 = 8;
      this.textBox_1.Text = num1.ToString();
      this.textBox_1.ReadOnly = true;
      c.int_74 = num1;
      this.groupBox_0.Visible = false;
      this.groupBox_4.Enabled = true;
    }
    else if (c.int_2 == 32)
    {
      this.label_5.Text = Module.a("怜\uE2AE肰讲薴蒶閸\uEFBA\uF0BC躾燎\uF3C2\uF1C4옹", int_0);
      this.label_6.Text = Module.a("鲬", int_0);
      this.textBox_1.Text = Module.a("龬龮薰讲", int_0);
      this.textBox_1.ReadOnly = true;
      c.int_74 = 2048;
      if (c.byte_20 > (byte) 60)
      {
        this.textBox_1.Text = Module.a("鲬龮莰螲", int_0);
        this.label_6.Text = Module.a("龬", int_0);
        c.int_74 = 1024;
      }
      this.groupBox_0.Visible = false;
    }
    else if (c.int_2 == 52)
    {
      this.label_5.Text = Module.a("\uE1ACﾮ\uF5B0讲趴螶辸鞺\uF1BC\uEFBE藀\uFBC2ﷄ\uF7C6\uF0C8", int_0);
      this.label_6.Text = Module.a("鲬", int_0);
      this.textBox_1.Text = Module.a("龬龮薰讲", int_0);
      this.textBox_1.ReadOnly = true;
      c.int_74 = 2048;
      this.groupBox_0.Visible = false;
    }
    else if (c.int_2 == 110)
    {
      this.label_5.Text = Module.a("\uE5AC\uF7AE蒰芲螴\uF6B6", int_0);
      this.label_6.Text = Module.a("閬", int_0);
      c.int_75 = 8;
      this.textBox_1.Text = num1.ToString();
      this.textBox_1.ReadOnly = true;
      c.int_74 = num1;
      this.groupBox_0.Visible = false;
      this.groupBox_4.Enabled = true;
    }
    else if (c.int_2 == 83)
    {
      this.label_5.Text = Module.a("\uE5AC\uF7AE蒰芲螴\uF6B6", int_0);
      this.label_6.Text = Module.a("閬", int_0);
      c.int_75 = 8;
      this.textBox_1.Text = num1.ToString();
      this.textBox_1.ReadOnly = true;
      c.int_74 = num1;
      this.groupBox_0.Visible = false;
      this.groupBox_4.Enabled = true;
    }
    else if (c.int_2 == 2)
    {
      this.label_5.Text = Module.a("\uE5AC\uF7AE蒰芲螴\uF6B6", int_0);
      this.label_6.Text = Module.a("閬", int_0);
      c.int_75 = 8;
      this.textBox_1.Text = num1.ToString();
      this.textBox_1.ReadOnly = true;
      c.int_74 = num1;
      this.groupBox_0.Visible = false;
      this.groupBox_4.Enabled = true;
    }
    else if (c.int_2 == 49)
    {
      this.label_5.Text = Module.a("\uE5AC\uF7AE蒰芲螴\uF6B6", int_0);
      this.label_6.Text = Module.a("馬", int_0);
      c.int_75 = 8;
      this.textBox_1.Text = num1.ToString();
      this.textBox_1.ReadOnly = true;
      c.int_74 = num1;
      this.groupBox_0.Visible = false;
      this.groupBox_4.Enabled = true;
    }
    else if (c.int_2 == 16)
    {
      this.label_5.Text = Module.a("\uE5AC\uF7AE蒰芲螴\uF6B6", int_0);
      this.label_6.Text = Module.a("鲬", int_0);
      this.textBox_1.Text = num1.ToString();
      this.textBox_1.ReadOnly = true;
      c.int_74 = num1;
      this.groupBox_0.Visible = false;
      this.groupBox_4.Enabled = true;
    }
    else if (c.int_2 == 51)
    {
      this.label_5.Text = Module.a("\uE5AC\uF7AE蒰芲螴\uF6B6馸\uF6BA튼톾껀ꃂ귄뗆ꛈꛊ\uA8CC", int_0);
      this.label_6.Text = Module.a("鲬", int_0);
      this.textBox_1.Text = Module.a("鲬骮芰薲", int_0);
      this.textBox_1.ReadOnly = true;
      c.int_74 = 1536;
      this.groupBox_0.Visible = false;
      this.groupBox_4.Enabled = false;
    }
    else if (c.int_2 == 55)
    {
      this.label_5.Text = Module.a("ﮬ鲮鲰ﺲ閴襁횸햺튼\uDCBE꧀뇂\uAAC4\uAAC6곈", int_0);
      this.label_6.Text = Module.a("鲬", int_0);
      this.textBox_1.Text = Module.a("鲬骮芰薲", int_0);
      this.textBox_1.ReadOnly = true;
      c.int_74 = 1536;
      this.groupBox_0.Visible = false;
      this.groupBox_4.Enabled = false;
    }
    if (this.string_0 == Module.a("鲬麮膰芲閴\uE1B6袸閺趼", int_0) || this.string_0 == Module.a("鲬麮膰芲閴\uE1B6趸閺趼", int_0) || this.string_0 == Module.a("鲬麮膰芲閴\uE1B6膸閺趼", int_0) || this.string_0 == Module.a("鲬麮膰芲閴\uE1B6膸閺貼", int_0))
      this.label_5.Text = Module.a("鲬麮膰芲", int_0);
    if (c.string_7 == Module.a("\uEEAC\uDAAE쎰잲풴\uDEB6ힸ鮺\uEBBC誾", int_0) || c.string_7 == Module.a("\uEEAC\uDAAE쎰잲풴\uDEB6ힸ鮺\uEBBC貾", int_0) || c.string_7 == Module.a("\uEEAC\uDAAE쎰잲풴\uDEB6ힸ鮺\uEBBC趾", int_0) || c.string_7 == Module.a("\uEEAC\uDAAE쎰잲풴\uDEB6ힸ鮺\uEBBC躾菀", int_0) || c.string_7 == Module.a("怜\uE3AE\uE2B0鎲\uE3B4芶钸\uF6BA", int_0) || c.string_7 == Module.a("怜\uE3AE\uE2B0鎲\uE3B4蒶钸\uF6BA", int_0) || c.string_7 == Module.a("怜\uE3AE\uE2B0鎲\uE3B4薶钸\uF6BA", int_0) || c.string_7 == Module.a("怜\uE3AE\uE2B0鎲\uE3B4蚶﮸隺\uF0BC", int_0))
    {
      if (c.useEnglishLanguage)
        this.label_5.Text = Module.a("ﺬ\uDAAE솰쎲\uDAB4얶춸鮺ﺼ쪾돀럂꓄껆\uA7C8\uEBCA臌ꛎ뛐믒ꇔꓖ", int_0);
      else
        this.label_5.Text = Module.a("苉껍⛊꯬\uDAC4", int_0);
      this.groupBox_0.Visible = false;
      this.groupBox_1.Enabled = false;
    }
    if (!c.bool_35)
      return;
    this.label_5.Text = this.string_1;
  }

  private void comboBox_5_SelectedIndexChanged(object sender, EventArgs e) => this.method_3();

  private void comboBox_2_SelectedIndexChanged(object sender, EventArgs e)
  {
    c.int_8 = this.comboBox_2.SelectedIndex;
    this.method_3();
  }

  private void comboBox_4_SelectedIndexChanged(object sender, EventArgs e)
  {
    c.int_9 = this.comboBox_4.SelectedIndex;
    this.method_3();
  }

  private void comboBox_3_SelectedIndexChanged(object sender, EventArgs e)
  {
    c.int_10 = this.comboBox_3.SelectedIndex;
    this.method_3();
  }

  private void radioButton_1_CheckedChanged(object sender, EventArgs e) => this.method_3();

  private void radioButton_0_CheckedChanged(object sender, EventArgs e) => this.method_3();

  private void label_6_Click(object sender, EventArgs e)
  {
  }

  private void button_3_Click(object sender, EventArgs e)
  {
    if (new ah().ShowDialog() != DialogResult.OK)
      return;
    this.arrayList_0 = new ArrayList();
    this.arrayList_0.Clear();
    string string1 = c.string_1;
    if (!File.Exists(string1))
      return;
    try
    {
      using (StreamReader streamReader = new StreamReader(string1, Encoding.Unicode))
      {
        int num = 0;
        try
        {
          num = Convert.ToInt32(streamReader.ReadLine());
        }
        catch
        {
        }
        if (num <= 0)
          return;
        Class1 class1 = new Class1();
        for (int index = 0; index < num; ++index)
        {
          string string_1 = streamReader.ReadLine();
          this.arrayList_0.Add((object) class1.method_1(string_1, Class1.string_0));
        }
        this.listBox_0.Items.Clear();
        for (int index = 0; index < this.arrayList_0.Count; ++index)
        {
          string[] strArray = ((string) this.arrayList_0[index]).Split(';');
          if (strArray.Length != 3)
            break;
          this.listBox_0.Items.Add((object) strArray[1]);
        }
      }
    }
    catch
    {
    }
  }

  private void listBox_0_SelectedIndexChanged(object sender, EventArgs e)
  {
    if (this.listBox_0.SelectedIndex < 0 || this.listBox_0.SelectedIndex >= this.arrayList_0.Count)
      return;
    string[] strArray = ((string) this.arrayList_0[this.listBox_0.SelectedIndex]).Split(';');
    if (strArray.Length != 3)
      return;
    this.string_0 = strArray[0];
    c.string_7 = strArray[1];
    this.label_17.Text = c.string_7;
    this.string_1 = strArray[2];
    this.method_1();
    this.method_3();
  }
}
