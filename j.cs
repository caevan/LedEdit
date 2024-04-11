// Decompiled with JetBrains decompiler
// Type: j
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class j : Form
{
  private IContainer icontainer_0;
  private ComboBox comboBox_0;
  private Label label_0;
  private ComboBox comboBox_1;
  private Label label_1;
  private ComboBox comboBox_2;
  private Label label_2;
  private Label label_3;
  private ComboBox comboBox_3;
  private Label label_4;
  private ComboBox comboBox_4;
  private GroupBox groupBox_0;
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
  private Button button_0;
  private Button button_1;

  public j()
  {
    this.method_0();
    this.comboBox_2.Items.Clear();
    this.comboBox_1.Items.Clear();
    this.comboBox_0.Items.Clear();
    this.comboBox_2.Items.Add((object) Module.a("袸袺킼ﺾ", 19));
    this.comboBox_2.Items.Add((object) Module.a("袸辺킼ﺾ", 19));
    this.comboBox_2.Items.Add((object) Module.a("袸躺킼ﺾ", 19));
    this.comboBox_2.Items.Add((object) Module.a("袸趺킼ﺾ", 19));
    this.comboBox_2.Items.Add((object) Module.a("袸貺킼ﺾ", 19));
    this.comboBox_2.Items.Add((object) Module.a("袸莺킼ﺾ", 19));
    this.comboBox_2.Items.Add((object) Module.a("袸芺킼ﺾ", 19));
    this.comboBox_2.Items.Add((object) Module.a("许论킼ﺾ", 19));
    this.comboBox_2.Items.Add((object) Module.a("许誺킼ﺾ", 19));
    this.comboBox_2.Items.Add((object) Module.a("许覺킼ﺾ", 19));
    this.comboBox_2.Items.Add((object) Module.a("许袺킼ﺾ", 19));
    this.comboBox_2.Items.Add((object) Module.a("许辺킼ﺾ", 19));
    this.comboBox_2.Items.Add((object) Module.a("许躺킼ﺾ", 19));
    this.comboBox_2.Items.Add((object) Module.a("许趺킼ﺾ", 19));
    this.comboBox_2.Items.Add((object) Module.a("许貺킼ﺾ", 19));
    this.comboBox_2.Items.Add((object) Module.a("许莺킼ﺾ", 19));
    this.comboBox_2.Items.Add((object) Module.a("许芺킼ﺾ", 19));
    this.comboBox_2.Items.Add((object) Module.a("誸论킼ﺾ", 19));
    this.comboBox_2.Items.Add((object) Module.a("誸誺킼ﺾ", 19));
    this.comboBox_2.Items.Add((object) Module.a("誸覺킼ﺾ", 19));
    this.comboBox_2.Items.Add((object) Module.a("誸袺킼ﺾ", 19));
    this.comboBox_2.Items.Add((object) Module.a("誸辺킼ﺾ", 19));
    this.comboBox_2.Items.Add((object) Module.a("誸躺킼ﺾ", 19));
    this.comboBox_2.Items.Add((object) Module.a("誸趺킼ﺾ", 19));
    this.comboBox_2.Items.Add((object) Module.a("誸貺킼ﺾ", 19));
    this.comboBox_2.Items.Add((object) Module.a("誸莺킼ﺾ", 19));
    this.comboBox_2.Items.Add((object) Module.a("誸芺킼ﺾ", 19));
    this.comboBox_2.Items.Add((object) Module.a("趸论킼ﺾ", 19));
    this.comboBox_2.Items.Add((object) Module.a("趸誺킼ﺾ", 19));
    this.comboBox_2.Items.Add((object) Module.a("趸覺킼ﺾ", 19));
    this.comboBox_2.Items.Add((object) Module.a("趸袺킼ﺾ", 19));
    this.comboBox_2.Items.Add((object) Module.a("趸辺킼ﺾ", 19));
    this.comboBox_1.Items.Add((object) Module.a("袸袺킼ﺾ", 19));
    this.comboBox_1.Items.Add((object) Module.a("袸辺킼ﺾ", 19));
    this.comboBox_1.Items.Add((object) Module.a("袸躺킼ﺾ", 19));
    this.comboBox_1.Items.Add((object) Module.a("袸趺킼ﺾ", 19));
    this.comboBox_1.Items.Add((object) Module.a("袸貺킼ﺾ", 19));
    this.comboBox_1.Items.Add((object) Module.a("袸莺킼ﺾ", 19));
    this.comboBox_1.Items.Add((object) Module.a("袸芺킼ﺾ", 19));
    this.comboBox_1.Items.Add((object) Module.a("许论킼ﺾ", 19));
    this.comboBox_1.Items.Add((object) Module.a("许誺킼ﺾ", 19));
    this.comboBox_1.Items.Add((object) Module.a("许覺킼ﺾ", 19));
    this.comboBox_1.Items.Add((object) Module.a("许袺킼ﺾ", 19));
    this.comboBox_1.Items.Add((object) Module.a("许辺킼ﺾ", 19));
    this.comboBox_1.Items.Add((object) Module.a("许躺킼ﺾ", 19));
    this.comboBox_1.Items.Add((object) Module.a("许趺킼ﺾ", 19));
    this.comboBox_1.Items.Add((object) Module.a("许貺킼ﺾ", 19));
    this.comboBox_1.Items.Add((object) Module.a("许莺킼ﺾ", 19));
    this.comboBox_1.Items.Add((object) Module.a("许芺킼ﺾ", 19));
    this.comboBox_1.Items.Add((object) Module.a("誸论킼ﺾ", 19));
    this.comboBox_1.Items.Add((object) Module.a("誸誺킼ﺾ", 19));
    this.comboBox_1.Items.Add((object) Module.a("誸覺킼ﺾ", 19));
    this.comboBox_1.Items.Add((object) Module.a("誸袺킼ﺾ", 19));
    this.comboBox_1.Items.Add((object) Module.a("誸辺킼ﺾ", 19));
    this.comboBox_1.Items.Add((object) Module.a("誸躺킼ﺾ", 19));
    this.comboBox_1.Items.Add((object) Module.a("誸趺킼ﺾ", 19));
    this.comboBox_1.Items.Add((object) Module.a("誸貺킼ﺾ", 19));
    this.comboBox_1.Items.Add((object) Module.a("誸莺킼ﺾ", 19));
    this.comboBox_1.Items.Add((object) Module.a("誸芺킼ﺾ", 19));
    this.comboBox_1.Items.Add((object) Module.a("趸论킼ﺾ", 19));
    this.comboBox_1.Items.Add((object) Module.a("趸誺킼ﺾ", 19));
    this.comboBox_1.Items.Add((object) Module.a("趸覺킼ﺾ", 19));
    this.comboBox_1.Items.Add((object) Module.a("趸袺킼ﺾ", 19));
    this.comboBox_1.Items.Add((object) Module.a("趸辺킼ﺾ", 19));
    this.comboBox_0.Items.Add((object) Module.a("袸袺킼ﺾ", 19));
    this.comboBox_0.Items.Add((object) Module.a("袸辺킼ﺾ", 19));
    this.comboBox_0.Items.Add((object) Module.a("袸躺킼ﺾ", 19));
    this.comboBox_0.Items.Add((object) Module.a("袸趺킼ﺾ", 19));
    this.comboBox_0.Items.Add((object) Module.a("袸貺킼ﺾ", 19));
    this.comboBox_0.Items.Add((object) Module.a("袸莺킼ﺾ", 19));
    this.comboBox_0.Items.Add((object) Module.a("袸芺킼ﺾ", 19));
    this.comboBox_0.Items.Add((object) Module.a("许论킼ﺾ", 19));
    this.comboBox_0.Items.Add((object) Module.a("许誺킼ﺾ", 19));
    this.comboBox_0.Items.Add((object) Module.a("许覺킼ﺾ", 19));
    this.comboBox_0.Items.Add((object) Module.a("许袺킼ﺾ", 19));
    this.comboBox_0.Items.Add((object) Module.a("许辺킼ﺾ", 19));
    this.comboBox_0.Items.Add((object) Module.a("许躺킼ﺾ", 19));
    this.comboBox_0.Items.Add((object) Module.a("许趺킼ﺾ", 19));
    this.comboBox_0.Items.Add((object) Module.a("许貺킼ﺾ", 19));
    this.comboBox_0.Items.Add((object) Module.a("许莺킼ﺾ", 19));
    this.comboBox_0.Items.Add((object) Module.a("许芺킼ﺾ", 19));
    this.comboBox_0.Items.Add((object) Module.a("誸论킼ﺾ", 19));
    this.comboBox_0.Items.Add((object) Module.a("誸誺킼ﺾ", 19));
    this.comboBox_0.Items.Add((object) Module.a("誸覺킼ﺾ", 19));
    this.comboBox_0.Items.Add((object) Module.a("誸袺킼ﺾ", 19));
    this.comboBox_0.Items.Add((object) Module.a("誸辺킼ﺾ", 19));
    this.comboBox_0.Items.Add((object) Module.a("誸躺킼ﺾ", 19));
    this.comboBox_0.Items.Add((object) Module.a("誸趺킼ﺾ", 19));
    this.comboBox_0.Items.Add((object) Module.a("誸貺킼ﺾ", 19));
    this.comboBox_0.Items.Add((object) Module.a("誸莺킼ﺾ", 19));
    this.comboBox_0.Items.Add((object) Module.a("誸芺킼ﺾ", 19));
    this.comboBox_0.Items.Add((object) Module.a("趸论킼ﺾ", 19));
    this.comboBox_0.Items.Add((object) Module.a("趸誺킼ﺾ", 19));
    this.comboBox_0.Items.Add((object) Module.a("趸覺킼ﺾ", 19));
    this.comboBox_0.Items.Add((object) Module.a("趸袺킼ﺾ", 19));
    this.comboBox_0.Items.Add((object) Module.a("趸辺킼ﺾ", 19));
    this.comboBox_3.Items.Add((object) Module.a("许躺讼\uF7BE鯀", 19));
    this.comboBox_3.Items.Add((object) Module.a("貸誺込\uF7BE鯀", 19));
    this.comboBox_3.Items.Add((object) Module.a("袸论込设觀駂", 19));
    this.comboBox_3.Items.Add((object) Module.a("许论覼螾觀駂", 19));
    this.comboBox_4.Items.Add((object) Module.a("许辺\uDFBC횾뗀", 19));
    this.comboBox_4.Items.Add((object) Module.a("誸论\uDFBC횾뗀", 19));
    this.comboBox_4.Items.Add((object) Module.a("誸袺\uDFBC횾뗀", 19));
    this.comboBox_4.Items.Add((object) Module.a("誸趺\uDFBC횾뗀", 19));
    this.comboBox_2.SelectedIndex = (int) c.byte_3 & 31;
    this.comboBox_1.SelectedIndex = (int) c.byte_4 & 31;
    this.comboBox_0.SelectedIndex = (int) c.byte_5 & 31;
    if (((int) c.byte_3 & 128) == 0)
      this.radioButton_1.Checked = true;
    else
      this.radioButton_0.Checked = true;
    if (((int) c.byte_4 & 128) == 0)
      this.radioButton_2.Checked = true;
    else
      this.radioButton_3.Checked = true;
    if (((int) c.byte_5 & 128) == 0)
      this.radioButton_5.Checked = true;
    else
      this.radioButton_4.Checked = true;
    if (((int) c.byte_5 & 64) == 0)
      this.radioButton_7.Checked = true;
    else
      this.radioButton_6.Checked = true;
    this.comboBox_3.SelectedIndex = (int) (byte) ((uint) c.byte_3 >> 5) & 3;
    this.comboBox_4.SelectedIndex = (int) (byte) ((uint) c.byte_4 >> 5) & 3;
  }

  private void button_0_Click(object sender, EventArgs e)
  {
    c.byte_3 = (byte) this.comboBox_2.SelectedIndex;
    c.byte_4 = (byte) this.comboBox_1.SelectedIndex;
    c.byte_5 = (byte) this.comboBox_0.SelectedIndex;
    if (this.radioButton_1.Checked)
      c.byte_3 = c.byte_3;
    else
      c.byte_3 |= (byte) 128;
    if (this.radioButton_2.Checked)
      c.byte_4 = c.byte_4;
    else
      c.byte_4 |= (byte) 128;
    if (this.radioButton_5.Checked)
      c.byte_5 = c.byte_5;
    else
      c.byte_5 |= (byte) 128;
    if (this.radioButton_7.Checked)
      c.byte_5 = c.byte_5;
    else
      c.byte_5 |= (byte) 64;
    byte num1 = (byte) ((uint) (byte) this.comboBox_3.SelectedIndex << 5);
    c.byte_3 |= num1;
    byte num2 = (byte) ((uint) (byte) this.comboBox_4.SelectedIndex << 5);
    c.byte_4 |= num2;
    this.DialogResult = DialogResult.OK;
  }

  private void button_1_Click(object sender, EventArgs e) => this.Close();

    protected override void Dispose(bool disposing)
    {
        if (disposing && this.icontainer_0 != null)
            this.icontainer_0.Dispose();

        base.Dispose(disposing);
    }
    private void method_0()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (j));
    this.comboBox_0 = new ComboBox();
    this.label_0 = new Label();
    this.comboBox_1 = new ComboBox();
    this.label_1 = new Label();
    this.comboBox_2 = new ComboBox();
    this.label_2 = new Label();
    this.label_3 = new Label();
    this.comboBox_3 = new ComboBox();
    this.label_4 = new Label();
    this.comboBox_4 = new ComboBox();
    this.groupBox_0 = new GroupBox();
    this.radioButton_0 = new RadioButton();
    this.radioButton_1 = new RadioButton();
    this.groupBox_1 = new GroupBox();
    this.radioButton_2 = new RadioButton();
    this.radioButton_3 = new RadioButton();
    this.groupBox_2 = new GroupBox();
    this.radioButton_4 = new RadioButton();
    this.radioButton_5 = new RadioButton();
    this.groupBox_3 = new GroupBox();
    this.radioButton_6 = new RadioButton();
    this.radioButton_7 = new RadioButton();
    this.button_0 = new Button();
    this.button_1 = new Button();
    this.groupBox_0.SuspendLayout();
    this.groupBox_1.SuspendLayout();
    this.groupBox_2.SuspendLayout();
    this.groupBox_3.SuspendLayout();
    this.SuspendLayout();
    this.comboBox_0.AccessibleDescription = (string) null;
    this.comboBox_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.comboBox_0, Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆靖", 19));
    this.comboBox_0.BackgroundImage = (Image) null;
    this.comboBox_0.Font = (Font) null;
    this.comboBox_0.FormattingEnabled = true;
    this.comboBox_0.Items.AddRange(new object[16]
    {
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆靖\uE5CA蓌믎듐뻒ꛔ", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆靖\uE5CA蓌믎듐뻒ꛔ\uE6D6", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆靖\uE5CA蓌믎듐뻒ꛔ\uE5D6", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆靖\uE5CA蓌믎듐뻒ꛔ\uE4D6", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆靖\uE5CA蓌믎듐뻒ꛔ\uE3D6", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆靖\uE5CA蓌믎듐뻒ꛔ\uE2D6", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆靖\uE5CA蓌믎듐뻒ꛔ\uE1D6", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆靖\uE5CA蓌믎듐뻒ꛔ\uE0D6", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆靖\uE5CA蓌믎듐뻒ꛔ\uEFD6", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆靖\uE5CA蓌믎듐뻒ꛔ\uEED6", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆靖\uE5CA蓌믎듐뻒ꛔ\uE6D6\uE9D8", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆靖\uE5CA蓌믎듐뻒ꛔ\uE6D6\uE8D8", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆靖\uE5CA蓌믎듐뻒ꛔ\uE6D6\uEBD8", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆靖\uE5CA蓌믎듐뻒ꛔ\uE6D6\uEAD8", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆靖\uE5CA蓌믎듐뻒ꛔ\uE6D6\uEDD8", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆靖\uE5CA蓌믎듐뻒ꛔ\uE6D6\uECD8", 19))
    });
    this.comboBox_0.Name = Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆靖", 19);
    this.label_0.AccessibleDescription = (string) null;
    this.label_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_0, Module.a("햸\uDABA\uDFBC\uDABE귀\uF0C2", 19));
    this.label_0.Font = (Font) null;
    this.label_0.Name = Module.a("햸\uDABA\uDFBC\uDABE귀\uF0C2", 19);
    this.comboBox_1.AccessibleDescription = (string) null;
    this.comboBox_1.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.comboBox_1, Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆\uFBC8", 19));
    this.comboBox_1.BackgroundImage = (Image) null;
    this.comboBox_1.Font = (Font) null;
    this.comboBox_1.FormattingEnabled = true;
    this.comboBox_1.Items.AddRange(new object[16]
    {
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆\uFBC8\uE5CA蓌믎듐뻒ꛔ", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆\uFBC8\uE5CA蓌믎듐뻒ꛔ\uE6D6", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆\uFBC8\uE5CA蓌믎듐뻒ꛔ\uE5D6", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆\uFBC8\uE5CA蓌믎듐뻒ꛔ\uE4D6", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆\uFBC8\uE5CA蓌믎듐뻒ꛔ\uE3D6", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆\uFBC8\uE5CA蓌믎듐뻒ꛔ\uE2D6", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆\uFBC8\uE5CA蓌믎듐뻒ꛔ\uE1D6", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆\uFBC8\uE5CA蓌믎듐뻒ꛔ\uE0D6", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆\uFBC8\uE5CA蓌믎듐뻒ꛔ\uEFD6", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆\uFBC8\uE5CA蓌믎듐뻒ꛔ\uEED6", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆\uFBC8\uE5CA蓌믎듐뻒ꛔ\uE6D6\uE9D8", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆\uFBC8\uE5CA蓌믎듐뻒ꛔ\uE6D6\uE8D8", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆\uFBC8\uE5CA蓌믎듐뻒ꛔ\uE6D6\uEBD8", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆\uFBC8\uE5CA蓌믎듐뻒ꛔ\uE6D6\uEAD8", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆\uFBC8\uE5CA蓌믎듐뻒ꛔ\uE6D6\uEDD8", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆\uFBC8\uE5CA蓌믎듐뻒ꛔ\uE6D6\uECD8", 19))
    });
    this.comboBox_1.Name = Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆\uFBC8", 19);
    this.label_1.AccessibleDescription = (string) null;
    this.label_1.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_1, Module.a("햸\uDABA\uDFBC\uDABE귀\uF1C2", 19));
    this.label_1.Font = (Font) null;
    this.label_1.Name = Module.a("햸\uDABA\uDFBC\uDABE귀\uF1C2", 19);
    this.comboBox_2.AccessibleDescription = (string) null;
    this.comboBox_2.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.comboBox_2, Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆\uF8C8", 19));
    this.comboBox_2.BackgroundImage = (Image) null;
    this.comboBox_2.Font = (Font) null;
    this.comboBox_2.FormattingEnabled = true;
    this.comboBox_2.Items.AddRange(new object[16]
    {
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆\uF8C8\uE5CA蓌믎듐뻒ꛔ", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆\uF8C8\uE5CA蓌믎듐뻒ꛔ\uE6D6", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆\uF8C8\uE5CA蓌믎듐뻒ꛔ\uE5D6", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆\uF8C8\uE5CA蓌믎듐뻒ꛔ\uE4D6", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆\uF8C8\uE5CA蓌믎듐뻒ꛔ\uE3D6", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆\uF8C8\uE5CA蓌믎듐뻒ꛔ\uE2D6", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆\uF8C8\uE5CA蓌믎듐뻒ꛔ\uE1D6", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆\uF8C8\uE5CA蓌믎듐뻒ꛔ\uE0D6", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆\uF8C8\uE5CA蓌믎듐뻒ꛔ\uEFD6", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆\uF8C8\uE5CA蓌믎듐뻒ꛔ\uEED6", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆\uF8C8\uE5CA蓌믎듐뻒ꛔ\uE6D6\uE9D8", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆\uF8C8\uE5CA蓌믎듐뻒ꛔ\uE6D6\uE8D8", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆\uF8C8\uE5CA蓌믎듐뻒ꛔ\uE6D6\uEBD8", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆\uF8C8\uE5CA蓌믎듐뻒ꛔ\uE6D6\uEAD8", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆\uF8C8\uE5CA蓌믎듐뻒ꛔ\uE6D6\uEDD8", 19)),
      (object) componentResourceManager.GetString(Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆\uF8C8\uE5CA蓌믎듐뻒ꛔ\uE6D6\uECD8", 19))
    });
    this.comboBox_2.Name = Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆\uF8C8", 19);
    this.label_2.AccessibleDescription = (string) null;
    this.label_2.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_2, Module.a("햸\uDABA\uDFBC\uDABE귀\uF2C2", 19));
    this.label_2.Font = (Font) null;
    this.label_2.Name = Module.a("햸\uDABA\uDFBC\uDABE귀\uF2C2", 19);
    this.label_3.AccessibleDescription = (string) null;
    this.label_3.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_3, Module.a("햸\uDABA\uDFBC\uDABE귀\uF7C2", 19));
    this.label_3.Font = (Font) null;
    this.label_3.Name = Module.a("햸\uDABA\uDFBC\uDABE귀\uF7C2", 19);
    this.comboBox_3.AccessibleDescription = (string) null;
    this.comboBox_3.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.comboBox_3, Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆\uFDC8", 19));
    this.comboBox_3.BackgroundImage = (Image) null;
    this.comboBox_3.Font = (Font) null;
    this.comboBox_3.FormattingEnabled = true;
    this.comboBox_3.Name = Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆\uFDC8", 19);
    this.label_4.AccessibleDescription = (string) null;
    this.label_4.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_4, Module.a("햸\uDABA\uDFBC\uDABE귀\uF6C2", 19));
    this.label_4.Font = (Font) null;
    this.label_4.Name = Module.a("햸\uDABA\uDFBC\uDABE귀\uF6C2", 19);
    this.comboBox_4.AccessibleDescription = (string) null;
    this.comboBox_4.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.comboBox_4, Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆ﳈ", 19));
    this.comboBox_4.BackgroundImage = (Image) null;
    this.comboBox_4.Font = (Font) null;
    this.comboBox_4.FormattingEnabled = true;
    this.comboBox_4.Name = Module.a("\uDAB8풺킼\uDDBE껀臂\uAAC4뿆ﳈ", 19);
    this.groupBox_0.AccessibleDescription = (string) null;
    this.groupBox_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.groupBox_0, Module.a("\uDEB8즺튼쪾뇀臂\uAAC4뿆\uF8C8", 19));
    this.groupBox_0.BackgroundImage = (Image) null;
    this.groupBox_0.Controls.Add((Control) this.radioButton_0);
    this.groupBox_0.Controls.Add((Control) this.radioButton_1);
    this.groupBox_0.Font = (Font) null;
    this.groupBox_0.Name = Module.a("\uDEB8즺튼쪾뇀臂\uAAC4뿆\uF8C8", 19);
    this.groupBox_0.TabStop = false;
    this.radioButton_0.AccessibleDescription = (string) null;
    this.radioButton_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.radioButton_0, Module.a("쮸\uDABA\uD9BC횾껀臂냄돆뷈\uA4CAꏌ\uFDCE", 19));
    this.radioButton_0.BackgroundImage = (Image) null;
    this.radioButton_0.Font = (Font) null;
    this.radioButton_0.Name = Module.a("쮸\uDABA\uD9BC횾껀臂냄돆뷈\uA4CAꏌ\uFDCE", 19);
    this.radioButton_0.TabStop = true;
    this.radioButton_0.UseVisualStyleBackColor = true;
    this.radioButton_1.AccessibleDescription = (string) null;
    this.radioButton_1.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.radioButton_1, Module.a("쮸\uDABA\uD9BC횾껀臂냄돆뷈\uA4CAꏌﻎ", 19));
    this.radioButton_1.BackgroundImage = (Image) null;
    this.radioButton_1.Font = (Font) null;
    this.radioButton_1.Name = Module.a("쮸\uDABA\uD9BC횾껀臂냄돆뷈\uA4CAꏌﻎ", 19);
    this.radioButton_1.TabStop = true;
    this.radioButton_1.UseVisualStyleBackColor = true;
    this.groupBox_1.AccessibleDescription = (string) null;
    this.groupBox_1.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.groupBox_1, Module.a("\uDEB8즺튼쪾뇀臂\uAAC4뿆\uFBC8", 19));
    this.groupBox_1.BackgroundImage = (Image) null;
    this.groupBox_1.Controls.Add((Control) this.radioButton_2);
    this.groupBox_1.Controls.Add((Control) this.radioButton_3);
    this.groupBox_1.Font = (Font) null;
    this.groupBox_1.Name = Module.a("\uDEB8즺튼쪾뇀臂\uAAC4뿆\uFBC8", 19);
    this.groupBox_1.TabStop = false;
    this.radioButton_2.AccessibleDescription = (string) null;
    this.radioButton_2.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.radioButton_2, Module.a("쮸\uDABA\uD9BC횾껀臂냄돆뷈\uA4CAꏌﳎ", 19));
    this.radioButton_2.BackgroundImage = (Image) null;
    this.radioButton_2.Font = (Font) null;
    this.radioButton_2.Name = Module.a("쮸\uDABA\uD9BC횾껀臂냄돆뷈\uA4CAꏌﳎ", 19);
    this.radioButton_2.TabStop = true;
    this.radioButton_2.UseVisualStyleBackColor = true;
    this.radioButton_3.AccessibleDescription = (string) null;
    this.radioButton_3.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.radioButton_3, Module.a("쮸\uDABA\uD9BC횾껀臂냄돆뷈\uA4CAꏌ\uFBCE", 19));
    this.radioButton_3.BackgroundImage = (Image) null;
    this.radioButton_3.Font = (Font) null;
    this.radioButton_3.Name = Module.a("쮸\uDABA\uD9BC횾껀臂냄돆뷈\uA4CAꏌ\uFBCE", 19);
    this.radioButton_3.TabStop = true;
    this.radioButton_3.UseVisualStyleBackColor = true;
    this.groupBox_2.AccessibleDescription = (string) null;
    this.groupBox_2.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.groupBox_2, Module.a("\uDEB8즺튼쪾뇀臂\uAAC4뿆靖", 19));
    this.groupBox_2.BackgroundImage = (Image) null;
    this.groupBox_2.Controls.Add((Control) this.radioButton_4);
    this.groupBox_2.Controls.Add((Control) this.radioButton_5);
    this.groupBox_2.Font = (Font) null;
    this.groupBox_2.Name = Module.a("\uDEB8즺튼쪾뇀臂\uAAC4뿆靖", 19);
    this.groupBox_2.TabStop = false;
    this.radioButton_4.AccessibleDescription = (string) null;
    this.radioButton_4.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.radioButton_4, Module.a("쮸\uDABA\uD9BC횾껀臂냄돆뷈\uA4CAꏌ龜", 19));
    this.radioButton_4.BackgroundImage = (Image) null;
    this.radioButton_4.Font = (Font) null;
    this.radioButton_4.Name = Module.a("쮸\uDABA\uD9BC횾껀臂냄돆뷈\uA4CAꏌ龜", 19);
    this.radioButton_4.TabStop = true;
    this.radioButton_4.UseVisualStyleBackColor = true;
    this.radioButton_5.AccessibleDescription = (string) null;
    this.radioButton_5.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.radioButton_5, Module.a("쮸\uDABA\uD9BC횾껀臂냄돆뷈\uA4CAꏌ硫", 19));
    this.radioButton_5.BackgroundImage = (Image) null;
    this.radioButton_5.Font = (Font) null;
    this.radioButton_5.Name = Module.a("쮸\uDABA\uD9BC횾껀臂냄돆뷈\uA4CAꏌ硫", 19);
    this.radioButton_5.TabStop = true;
    this.radioButton_5.UseVisualStyleBackColor = true;
    this.groupBox_3.AccessibleDescription = (string) null;
    this.groupBox_3.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.groupBox_3, Module.a("\uDEB8즺튼쪾뇀臂\uAAC4뿆\uFDC8", 19));
    this.groupBox_3.BackgroundImage = (Image) null;
    this.groupBox_3.Controls.Add((Control) this.radioButton_6);
    this.groupBox_3.Controls.Add((Control) this.radioButton_7);
    this.groupBox_3.Font = (Font) null;
    this.groupBox_3.Name = Module.a("\uDEB8즺튼쪾뇀臂\uAAC4뿆\uFDC8", 19);
    this.groupBox_3.TabStop = false;
    this.radioButton_6.AccessibleDescription = (string) null;
    this.radioButton_6.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.radioButton_6, Module.a("쮸\uDABA\uD9BC횾껀臂냄돆뷈\uA4CAꏌ\uF8CE", 19));
    this.radioButton_6.BackgroundImage = (Image) null;
    this.radioButton_6.Font = (Font) null;
    this.radioButton_6.Name = Module.a("쮸\uDABA\uD9BC횾껀臂냄돆뷈\uA4CAꏌ\uF8CE", 19);
    this.radioButton_6.TabStop = true;
    this.radioButton_6.UseVisualStyleBackColor = true;
    this.radioButton_7.AccessibleDescription = (string) null;
    this.radioButton_7.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.radioButton_7, Module.a("쮸\uDABA\uD9BC횾껀臂냄돆뷈\uA4CAꏌ\uF7CE", 19));
    this.radioButton_7.BackgroundImage = (Image) null;
    this.radioButton_7.Font = (Font) null;
    this.radioButton_7.Name = Module.a("쮸\uDABA\uD9BC횾껀臂냄돆뷈\uA4CAꏌ\uF7CE", 19);
    this.radioButton_7.TabStop = true;
    this.radioButton_7.UseVisualStyleBackColor = true;
    this.button_0.AccessibleDescription = (string) null;
    this.button_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.button_0, Module.a("\uDBB8캺즼쮾껀귂\uF4C4", 19));
    this.button_0.BackgroundImage = (Image) null;
    this.button_0.Font = (Font) null;
    this.button_0.Name = Module.a("\uDBB8캺즼쮾껀귂\uF4C4", 19);
    this.button_0.UseVisualStyleBackColor = true;
    this.button_0.Click += new EventHandler(this.button_0_Click);
    this.button_1.AccessibleDescription = (string) null;
    this.button_1.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.button_1, Module.a("\uDBB8캺즼쮾껀귂\uF7C4", 19));
    this.button_1.BackgroundImage = (Image) null;
    this.button_1.Font = (Font) null;
    this.button_1.Name = Module.a("\uDBB8캺즼쮾껀귂\uF7C4", 19);
    this.button_1.UseVisualStyleBackColor = true;
    this.button_1.Click += new EventHandler(this.button_1_Click);
    this.AccessibleDescription = (string) null;
    this.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this, Module.a("鶸쾺햼횾닀", 19));
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackgroundImage = (Image) null;
    this.ControlBox = false;
    this.Controls.Add((Control) this.button_1);
    this.Controls.Add((Control) this.button_0);
    this.Controls.Add((Control) this.groupBox_3);
    this.Controls.Add((Control) this.groupBox_2);
    this.Controls.Add((Control) this.groupBox_1);
    this.Controls.Add((Control) this.groupBox_0);
    this.Controls.Add((Control) this.comboBox_4);
    this.Controls.Add((Control) this.label_4);
    this.Controls.Add((Control) this.comboBox_3);
    this.Controls.Add((Control) this.label_3);
    this.Controls.Add((Control) this.comboBox_0);
    this.Controls.Add((Control) this.label_0);
    this.Controls.Add((Control) this.comboBox_1);
    this.Controls.Add((Control) this.label_1);
    this.Controls.Add((Control) this.comboBox_2);
    this.Controls.Add((Control) this.label_2);
    this.Font = (Font) null;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Icon = (Icon) null;
    this.Name = Module.a("\uF1B8\uDEBA펼\uD8BE跀ꫂ냄飆軈鳊\uFBCC\uFDCE\uE2D0诒", 19);
    this.TopMost = true;
    this.groupBox_0.ResumeLayout(false);
    this.groupBox_0.PerformLayout();
    this.groupBox_1.ResumeLayout(false);
    this.groupBox_1.PerformLayout();
    this.groupBox_2.ResumeLayout(false);
    this.groupBox_2.PerformLayout();
    this.groupBox_3.ResumeLayout(false);
    this.groupBox_3.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
