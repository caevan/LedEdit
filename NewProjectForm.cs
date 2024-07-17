// Decompiled with JetBrains decompiler
// Type: NewProjectForm
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using AFSApp.Helpers;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

// New Project Form
public class NewProjectForm   : Form
{
  private IContainer icontainer_0;
  private Label label_0;
  private Label label_1;
  private Button OkButton;
  private Button BrowseButton;
  private Label label_2;
  private Button button_2;
  private TextBox textBox_ProjectFilePath;
  private Label label_3;
  private ComboBox comboBox_0;
  private Label label_4;
  private ComboBox comboBox_RGBChannel;// RGBChannel
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
  private Button selectControllerButton;
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

    private void LayoutForm()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (NewProjectForm));
    this.label_0 = new Label();
    this.label_1 = new Label();
    this.OkButton = new Button();
    this.BrowseButton = new Button();
    this.label_2 = new Label();
    this.button_2 = new Button();
    this.textBox_ProjectFilePath = new TextBox();
    this.label_3 = new Label();
    this.comboBox_0 = new ComboBox();
    this.comboBox_RGBChannel = new ComboBox();
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
    this.selectControllerButton = new Button();
    this.label_19 = new Label();
    this.groupBox_2.SuspendLayout();
    this.groupBox_0.SuspendLayout();
    this.groupBox_1.SuspendLayout();
    this.groupBox_3.SuspendLayout();
    this.groupBox_4.SuspendLayout();
    this.SuspendLayout();
    this.label_0.AccessibleDescription = (string) null;
    this.label_0.AccessibleName = (string) null;
        componentResourceManager.ApplyResources((object)this.label_0, "label2");
        this.label_0.Font = (Font)null;
        this.label_0.Name = "label2";
        this.label_1.AccessibleDescription = (string)null;
        this.label_1.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_1, "label1");
        this.label_1.Font = (Font)null;
        this.label_1.Name = "label1";
        this.OkButton.AccessibleDescription = (string)null;
        this.OkButton.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.OkButton, "button1");
        this.OkButton.BackgroundImage = (Image) null;
        this.OkButton.Name = "button1"; // Module.a("횳쎵첷캹펻킽\uF1BF", 14);
    this.OkButton.UseVisualStyleBackColor = true;
    this.OkButton.Click += new EventHandler(this.OkButtonClick);
        LogData.LogInfo($"NewProjectForm OkButton.Text : {OkButton.Text}");
        LogData.LogInfo($"NewProjectForm OkButton.Text : {JsonConvert.SerializeObject(OkButton.AccessibilityObject.Bounds, Formatting.Indented)}");
    this.BrowseButton.AccessibleDescription = (string) null;
    this.BrowseButton.AccessibleName = (string) null;
        componentResourceManager.ApplyResources((object)this.BrowseButton, "button2"); this.BrowseButton.BackgroundImage = (Image) null;
    this.BrowseButton.Font = (Font) null;
        this.BrowseButton.Name = "button2"; // Module.a("횳쎵첷캹펻킽\uF2BF", 14);
    this.BrowseButton.UseVisualStyleBackColor = true;
    this.BrowseButton.Click += new EventHandler(this.button_1_Click);
        LogData.LogInfo($"NewProjectForm BrowseButton.Text : {BrowseButton.Text}");
        LogData.LogInfo($"NewProjectForm BrowseButton.Text : {JsonConvert.SerializeObject(BrowseButton.AccessibilityObject.Bounds, Formatting.Indented)}");
        this.label_2.AccessibleDescription = (string) null;
    this.label_2.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_2, Module.a("\uD8B3ힵ\uDAB7\uDFB9킻趽", 14));
    this.label_2.Font = (Font) null;
        this.label_2.Name = "label3";
        this.button_2.AccessibleDescription = (string)null;
        this.button_2.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.button_2, "button3");
        this.button_2.BackgroundImage = (Image)null;
        this.button_2.DialogResult = DialogResult.Cancel;
        this.button_2.Name = "button3";
        this.button_2.UseVisualStyleBackColor = true;
        this.button_2.Click += new EventHandler(this.button_2_Click);
        this.textBox_ProjectFilePath.AccessibleDescription = (string)null;
        this.textBox_ProjectFilePath.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.textBox_ProjectFilePath, "textBox3"); 
        this.textBox_ProjectFilePath.BackColor = SystemColors.ControlLightLight;
    this.textBox_ProjectFilePath.BackgroundImage = (Image) null;
    this.textBox_ProjectFilePath.Font = (Font) null;
        this.textBox_ProjectFilePath.Name = "textBox3";
        this.label_3.AccessibleDescription = (string)null;
        this.label_3.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_3, "label4");
        this.label_3.Font = (Font)null;
        this.label_3.Name = "label4";
        this.comboBox_0.AccessibleDescription = (string)null;
        this.comboBox_0.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.comboBox_0, "comboBox1");
        this.comboBox_0.BackgroundImage = (Image) null;
    this.comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
    this.comboBox_0.Font = (Font) null;
    this.comboBox_0.FormattingEnabled = true;
    this.comboBox_0.Items.AddRange(new object[30]
    {
      (object) componentResourceManager.GetString("comboBox1.Items"),
     (object) componentResourceManager.GetString("comboBox1.Items1"),
     (object) componentResourceManager.GetString("comboBox1.Items2"),
     (object) componentResourceManager.GetString("comboBox1.Items3"),
     (object) componentResourceManager.GetString("comboBox1.Items4"),
     (object) componentResourceManager.GetString("comboBox1.Items5"),
     (object) componentResourceManager.GetString("comboBox1.Items6"),
     (object) componentResourceManager.GetString("comboBox1.Items7"),
     (object) componentResourceManager.GetString("comboBox1.Items8"),
     (object) componentResourceManager.GetString("comboBox1.Items9"),
     (object) componentResourceManager.GetString("comboBox1.Items10"),
     (object) componentResourceManager.GetString("comboBox1.Items11"),
     (object) componentResourceManager.GetString("comboBox1.Items12"),
     (object) componentResourceManager.GetString("comboBox1.Items13"),
     (object) componentResourceManager.GetString("comboBox1.Items14"),
     (object) componentResourceManager.GetString("comboBox1.Items15"),
     (object) componentResourceManager.GetString("comboBox1.Items16"),
     (object) componentResourceManager.GetString("comboBox1.Items17"),
     (object) componentResourceManager.GetString("comboBox1.Items18"),
     (object) componentResourceManager.GetString("comboBox1.Items19"),
     (object) componentResourceManager.GetString("comboBox1.Items20"),
     (object) componentResourceManager.GetString("comboBox1.Items21"),
     (object) componentResourceManager.GetString("comboBox1.Items22"),
     (object) componentResourceManager.GetString("comboBox1.Items23"),
     (object) componentResourceManager.GetString("comboBox1.Items24"),
     (object) componentResourceManager.GetString("comboBox1.Items25"),
     (object) componentResourceManager.GetString("comboBox1.Items26"),
     (object) componentResourceManager.GetString("comboBox1.Items27"),
     (object) componentResourceManager.GetString("comboBox1.Items28"),
     (object) componentResourceManager.GetString("comboBox1.Items29")

    });
        foreach (var item in comboBox_0.Items)
        {
            LogData.LogInfo($"comboBox_DataEntryPoint Item {item.ToString()}");
        }
        
        LogData.LogInfo($"NewProjectForm comboBox_DataEntryPoint: {JsonConvert.SerializeObject(comboBox_0.Bounds, Formatting.Indented)} ");

        this.comboBox_0.Name = "comboBox1";
        this.comboBox_RGBChannel.AccessibleDescription = (string) null;
    this.comboBox_RGBChannel.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.comboBox_RGBChannel, Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF6C3", 14));
    this.comboBox_RGBChannel.BackgroundImage = (Image) null;
    this.comboBox_RGBChannel.DropDownStyle = ComboBoxStyle.DropDownList;
    this.comboBox_RGBChannel.Font = (Font) null;
    this.comboBox_RGBChannel.FormattingEnabled = true;
    this.comboBox_RGBChannel.Items.AddRange(new object[6]
    {
      (object) componentResourceManager.GetString("comboBox2.Items"),
      (object) componentResourceManager.GetString("comboBox2.Items1"),
      (object) componentResourceManager.GetString("comboBox2.Items2"),
      (object) componentResourceManager.GetString("comboBox2.Items3"),
      (object) componentResourceManager.GetString("comboBox2.Items4"),
      (object) componentResourceManager.GetString("comboBox2.Items5")

    });
        foreach (var item in comboBox_RGBChannel.Items)
        {
            LogData.LogInfo($"comboBox_RGBChannel Item {item.ToString()}");
        }
        LogData.LogInfo($"NewProjectForm comboBox_RGBChannel: {comboBox_RGBChannel.Items[0]},{comboBox_RGBChannel.Items[1]},{comboBox_RGBChannel.Items[2]},{comboBox_RGBChannel.Items[3]} ");

        this.comboBox_RGBChannel.Name = "comboBox2";
        this.label_4.AccessibleDescription = (string)null;
        this.label_4.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_4, "label5");
        this.label_4.Font = (Font)null;
        this.label_4.Name = "label5";
        this.groupBox_2.AccessibleDescription = (string)null;
        this.groupBox_2.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.groupBox_2, "groupBox6");
        this.groupBox_2.BackgroundImage = (Image)null;
        this.groupBox_2.Controls.Add((Control)this.radioButton_4);
        this.groupBox_2.Controls.Add((Control)this.radioButton_5);
        this.groupBox_2.Font = (Font)null;
        this.groupBox_2.Name = "groupBox6";
        this.groupBox_2.TabStop = false;
        this.radioButton_4.AccessibleDescription = (string)null;
        this.radioButton_4.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.radioButton_4, "radioButton6");

    this.radioButton_4.BackgroundImage = (Image) null;
    this.radioButton_4.Font = (Font) null;
        this.radioButton_4.Name = "radioButton6";
        this.radioButton_4.UseVisualStyleBackColor = true;
        this.radioButton_5.AccessibleDescription = (string)null;
        this.radioButton_5.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.radioButton_5, "radioButton5");
        this.radioButton_5.BackgroundImage = (Image)null;
        this.radioButton_5.Checked = true;
        this.radioButton_5.Font = (Font)null;
        this.radioButton_5.Name = "radioButton5";
        this.radioButton_5.TabStop = true;
        this.radioButton_5.UseVisualStyleBackColor = true;
        this.textBox_1.AccessibleDescription = (string)null;
        this.textBox_1.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.textBox_1, "textBox1");
        this.textBox_1.BackgroundImage = (Image)null;
        this.textBox_1.Font = (Font)null;
        this.textBox_1.Name = "textBox1";
        this.textBox_1.ReadOnly = true;
    this.label_6.AccessibleDescription = (string) null;
    this.label_6.AccessibleName = (string) null;
        componentResourceManager.ApplyResources((object)this.label_6, "label11");
        this.label_6.Font = (Font)null;
        this.label_6.Name = "label11";
        this.label_6.Click += new EventHandler(this.label_6_Click);
        this.label_5.AccessibleDescription = (string)null;
        this.label_5.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_5, "label10");
        this.label_5.ForeColor = SystemColors.HotTrack;
        this.label_5.Name = "label10";
        LogData.LogInfo($"label_5 location: {label_5.Location.X},{label_5.Location.Y}");
        LogData.LogInfo($"label_5 text: {label_5.Text},{label_5.Text}");
        this.label_7.AccessibleDescription = (string)null;
        this.label_7.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_7, "label12");
        this.label_7.Font = (Font)null;
        this.label_7.Name = "label12";
        this.label_8.AccessibleDescription = (string)null;
        this.label_8.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_8, "label13");

        this.label_8.Font = (Font) null;
        this.label_8.Name = "label13";
        this.comboBox_2.AccessibleDescription = (string)null;
        this.comboBox_2.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.comboBox_2, "comboBox4");

        this.comboBox_2.BackgroundImage = (Image) null;
    this.comboBox_2.Font = (Font) null;
    this.comboBox_2.FormattingEnabled = true;
    this.comboBox_2.Items.AddRange(new object[17]
    {
      (object) componentResourceManager.GetString("comboBox4.Items"),
      (object) componentResourceManager.GetString("comboBox4.Items1"),
      (object) componentResourceManager.GetString("comboBox4.Items2"),
      (object) componentResourceManager.GetString("comboBox4.Items3"),
      (object) componentResourceManager.GetString("comboBox4.Items4"),
      (object) componentResourceManager.GetString("comboBox4.Items5"),
      (object) componentResourceManager.GetString("comboBox4.Items6"),
      (object) componentResourceManager.GetString("comboBox4.Items7"),
      (object) componentResourceManager.GetString("comboBox4.Items8"),
      (object) componentResourceManager.GetString("comboBox4.Items9"),
      (object) componentResourceManager.GetString("comboBox4.Items10"),
      (object) componentResourceManager.GetString("comboBox4.Items11"),
      (object) componentResourceManager.GetString("comboBox4.Items12"),
      (object) componentResourceManager.GetString("comboBox4.Items13"),
      (object) componentResourceManager.GetString("comboBox4.Items14"),
      (object) componentResourceManager.GetString("comboBox4.Items15"),
      (object) componentResourceManager.GetString("comboBox4.Items16")

    });
        foreach (var item in comboBox_2.Items)
        {
            LogData.LogInfo($"comboBox_2 Item {item.ToString()}");
        }
        LogData.LogInfo($"NewProjectForm comboBox_2: {comboBox_2.Items[0]},{comboBox_2.Items[1]},{comboBox_2.Items[2]},{comboBox_2.Items[3]} ");

        this.comboBox_2.Name = "comboBox4";
        this.comboBox_2.SelectedIndexChanged += new EventHandler(this.comboBox_2_SelectedIndexChanged);
        this.groupBox_0.AccessibleDescription = (string)null;
        this.groupBox_0.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.groupBox_0, "groupBox3");

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
        this.groupBox_0.Name = "groupBox3";
        this.groupBox_0.TabStop = false;
        this.comboBox_5.AccessibleDescription = (string)null;
        this.comboBox_5.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.comboBox_5, "comboBox7");

        this.comboBox_5.BackgroundImage = (Image) null;
    this.comboBox_5.Font = (Font) null;
    this.comboBox_5.FormattingEnabled = true;
    this.comboBox_5.Items.AddRange(new object[17]
    {
      (object) componentResourceManager.GetString("comboBox7.Items"),
      (object) componentResourceManager.GetString("comboBox7.Items1"),
      (object) componentResourceManager.GetString("comboBox7.Items2"),
      (object) componentResourceManager.GetString("comboBox7.Items3"),
      (object) componentResourceManager.GetString("comboBox7.Items4"),
      (object) componentResourceManager.GetString("comboBox7.Items5"),
      (object) componentResourceManager.GetString("comboBox7.Items6"),
      (object) componentResourceManager.GetString("comboBox7.Items7"),
      (object) componentResourceManager.GetString("comboBox7.Items8"),
      (object) componentResourceManager.GetString("comboBox7.Items9"),
      (object) componentResourceManager.GetString("comboBox7.Items10"),
      (object) componentResourceManager.GetString("comboBox7.Items11"),
      (object) componentResourceManager.GetString("comboBox7.Items12"),
      (object) componentResourceManager.GetString("comboBox7.Items13"),
      (object) componentResourceManager.GetString("comboBox7.Items14"),
      (object) componentResourceManager.GetString("comboBox7.Items15"),
      (object) componentResourceManager.GetString("comboBox7.Items16")

    });
        LogData.LogInfo($"NewProjectForm comboBox_5 : {comboBox_5.Items[0]},{comboBox_5.Items[1]},{comboBox_5.Items[2]},{comboBox_5.Items[3]} ");
        this.comboBox_5.Name = "comboBox7";
        this.comboBox_5.SelectedIndexChanged += new EventHandler(this.comboBox_5_SelectedIndexChanged);
        this.label_14.AccessibleDescription = (string)null;
        this.label_14.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_14, "label19");
        this.label_14.Font = (Font)null;
        this.label_14.Name = "label19";
        this.label_13.AccessibleDescription = (string)null;
        this.label_13.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_13, "label18");
        this.label_13.Font = (Font)null;
        this.label_13.Name = "label18";
        this.label_9.AccessibleDescription = (string)null;
        this.label_9.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_9, "label16");
        this.label_9.Font = (Font)null;
        this.label_9.Name = "label16";
        this.comboBox_3.AccessibleDescription = (string) null;
    this.comboBox_3.AccessibleName = (string) null;
        componentResourceManager.ApplyResources((object)this.comboBox_3, "comboBox6");

        this.comboBox_3.BackgroundImage = (Image) null;
    this.comboBox_3.Font = (Font) null;
    this.comboBox_3.FormattingEnabled = true;
    this.comboBox_3.Items.AddRange(new object[17]
    {
      (object) componentResourceManager.GetString("comboBox6.Items"),
      (object) componentResourceManager.GetString("comboBox6.Items1"),
      (object) componentResourceManager.GetString("comboBox6.Items2"),
      (object) componentResourceManager.GetString("comboBox6.Items3"),
      (object) componentResourceManager.GetString("comboBox6.Items4"),
      (object) componentResourceManager.GetString("comboBox6.Items5"),
      (object) componentResourceManager.GetString("comboBox6.Items6"),
      (object) componentResourceManager.GetString("comboBox6.Items7"),
      (object) componentResourceManager.GetString("comboBox6.Items8"),
      (object) componentResourceManager.GetString("comboBox6.Items9"),
      (object) componentResourceManager.GetString("comboBox6.Items10"),
      (object) componentResourceManager.GetString("comboBox6.Items11"),
      (object) componentResourceManager.GetString("comboBox6.Items12"),
      (object) componentResourceManager.GetString("comboBox6.Items13"),
      (object) componentResourceManager.GetString("comboBox6.Items14"),
      (object) componentResourceManager.GetString("comboBox6.Items15"),
      (object) componentResourceManager.GetString("comboBox6.Items16")

    });
        LogData.LogInfo($"NewProjectForm comboBox_3: {comboBox_3.Items[0]},{comboBox_3.Items[1]},{comboBox_3.Items[2]},{comboBox_3.Items[3]} ");
        this.comboBox_3.Name = "comboBox6";
        this.comboBox_3.SelectedIndexChanged += new EventHandler(this.comboBox_3_SelectedIndexChanged);
        this.label_10.AccessibleDescription = (string)null;
        this.label_10.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_10, "label17");
        this.label_10.Font = (Font)null;
        this.label_10.Name = "label17";
        this.label_11.AccessibleDescription = (string)null;
        this.label_11.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_11, "label14");
        this.label_11.Font = (Font)null;
        this.label_11.Name = "label14";
        this.comboBox_4.AccessibleDescription = (string)null;
        this.comboBox_4.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.comboBox_4, "comboBox5");

        this.comboBox_4.BackgroundImage = (Image) null;
    this.comboBox_4.Font = (Font) null;
    this.comboBox_4.FormattingEnabled = true;
    this.comboBox_4.Items.AddRange(new object[17]
    {
      (object) componentResourceManager.GetString("comboBox5.Items"),
      (object) componentResourceManager.GetString("comboBox5.Items1"),
      (object) componentResourceManager.GetString("comboBox5.Items2"),
      (object) componentResourceManager.GetString("comboBox5.Items3"),
      (object) componentResourceManager.GetString("comboBox5.Items4"),
      (object) componentResourceManager.GetString("comboBox5.Items5"),
      (object) componentResourceManager.GetString("comboBox5.Items6"),
      (object) componentResourceManager.GetString("comboBox5.Items7"),
      (object) componentResourceManager.GetString("comboBox5.Items8"),
      (object) componentResourceManager.GetString("comboBox5.Items9"),
      (object) componentResourceManager.GetString("comboBox5.Items10"),
      (object) componentResourceManager.GetString("comboBox5.Items11"),
      (object) componentResourceManager.GetString("comboBox5.Items12"),
      (object) componentResourceManager.GetString("comboBox5.Items13"),
      (object) componentResourceManager.GetString("comboBox5.Items14"),
      (object) componentResourceManager.GetString("comboBox5.Items15"),
      (object) componentResourceManager.GetString("comboBox5.Items16")

    });
        LogData.LogInfo($"NewProjectForm comboBox_4: {comboBox_4.Items[0]},{comboBox_4.Items[1]},{comboBox_4.Items[2]},{comboBox_4.Items[3]} ");
        this.comboBox_4.Name = "comboBox5";
        this.comboBox_4.SelectedIndexChanged += new EventHandler(this.comboBox_4_SelectedIndexChanged);
        this.label_12.AccessibleDescription = (string)null;
        this.label_12.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_12, "label15");
        this.label_12.Font = (Font)null;
        this.label_12.Name = "label15";
        this.radioButton_0.AccessibleDescription = (string)null;
        this.radioButton_0.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.radioButton_0, "radioButton2");
        this.radioButton_0.BackgroundImage = (Image)null;
        this.radioButton_0.Font = (Font)null;
        this.radioButton_0.Name = "radioButton2";

        this.radioButton_0.UseVisualStyleBackColor = true;
    this.radioButton_0.CheckedChanged += new EventHandler(this.radioButton_0_CheckedChanged);
    this.radioButton_1.AccessibleDescription = (string) null;
    this.radioButton_1.AccessibleName = (string) null;
        componentResourceManager.ApplyResources((object)this.radioButton_1, "radioButton1");
        this.radioButton_1.BackgroundImage = (Image)null;
        this.radioButton_1.Checked = true;
        this.radioButton_1.Font = (Font)null;
        this.radioButton_1.Name = "radioButton1";
        this.radioButton_1.TabStop = true;
        this.radioButton_1.UseVisualStyleBackColor = true;
        this.radioButton_1.CheckedChanged += new EventHandler(this.radioButton_1_CheckedChanged);
        this.groupBox_1.AccessibleDescription = (string)null;
        this.groupBox_1.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.groupBox_1, "groupBox5");
        this.groupBox_1.BackgroundImage = (Image)null;
        this.groupBox_1.Controls.Add((Control)this.radioButton_2);
        this.groupBox_1.Controls.Add((Control)this.radioButton_3);
        this.groupBox_1.Font = (Font)null;
        this.groupBox_1.Name = "groupBox5";

        this.groupBox_1.TabStop = false;
    this.radioButton_2.AccessibleDescription = (string) null;
    this.radioButton_2.AccessibleName = (string) null;
        componentResourceManager.ApplyResources((object)this.radioButton_2, "radioButton4");
        this.radioButton_2.BackgroundImage = (Image)null;
        this.radioButton_2.Checked = true;
        this.radioButton_2.Font = (Font)null;
        this.radioButton_2.Name = "radioButton4";

        this.radioButton_2.TabStop = true;
    this.radioButton_2.UseVisualStyleBackColor = true;
    this.radioButton_3.AccessibleDescription = (string) null;
    this.radioButton_3.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.radioButton_3, "radioButton3" /*Module.a("욳ힵ\uDCB7펹펻ﲽ떿뛁냃꧅ꛇ柳", 14)*/);
    this.radioButton_3.BackgroundImage = (Image) null;
    this.radioButton_3.Font = (Font) null;
    this.radioButton_3.Name = "radioButton3"; //Module.a("욳ힵ\uDCB7펹펻ﲽ떿뛁냃꧅ꛇ柳", 14);
    this.radioButton_3.UseVisualStyleBackColor = true;
        LogData.LogInfo($"radioButton_3 Text {radioButton_3.Text}, X; {radioButton_3.Location.X} Y: radioButton_3.Location.Y");
    this.groupBox_3.AccessibleDescription = (string) null;
    this.groupBox_3.AccessibleName = (string) null;
        componentResourceManager.ApplyResources((object)this.groupBox_3, "groupBox7");
        this.groupBox_3.BackgroundImage = (Image)null;
        this.groupBox_3.Controls.Add((Control)this.radioButton_7);
        this.groupBox_3.Controls.Add((Control)this.radioButton_8);
        this.groupBox_3.Controls.Add((Control)this.radioButton_6);
        this.groupBox_3.Font = (Font)null;
        this.groupBox_3.Name = "groupBox7";
        this.groupBox_3.TabStop = false;
        this.radioButton_7.AccessibleDescription = (string)null;
        this.radioButton_7.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.radioButton_7, "radioButton9");
        this.radioButton_7.BackgroundImage = (Image)null;
        this.radioButton_7.Font = (Font)null;
        this.radioButton_7.Name = "radioButton9";
        this.radioButton_7.UseVisualStyleBackColor = true;
        this.radioButton_8.AccessibleDescription = (string)null;
        this.radioButton_8.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.radioButton_8, "radioButton8");

        this.radioButton_8.BackgroundImage = (Image) null;
    this.radioButton_8.Font = (Font) null;
        this.radioButton_8.Name = "radioButton8";
        this.radioButton_8.UseVisualStyleBackColor = true;
        this.radioButton_6.AccessibleDescription = (string)null;
        this.radioButton_6.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.radioButton_6, "radioButton7");
        this.radioButton_6.BackgroundImage = (Image)null;
        this.radioButton_6.Checked = true;
        this.radioButton_6.Font = (Font)null;
        this.radioButton_6.Name = "radioButton7";
        this.radioButton_6.TabStop = true;
        this.radioButton_6.UseVisualStyleBackColor = true;
        this.label_15.AccessibleDescription = (string)null;
        this.label_15.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_15, "label8");
        this.label_15.Font = (Font)null;
        this.label_15.Name = "label8";
        this.label_16.AccessibleDescription = (string)null;
        this.label_16.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_16, "label9");

        this.label_16.Font = (Font) null;
        this.label_16.Name = "label9";
        this.label_17.AccessibleDescription = (string)null;
        this.label_17.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_17, "label20");
        this.label_17.ForeColor = SystemColors.HotTrack;
        this.label_17.Name = "label20";
        this.groupBox_4.AccessibleDescription = (string)null;
        this.groupBox_4.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.groupBox_4, "groupBox4");
        this.groupBox_4.BackgroundImage = (Image)null;
        this.groupBox_4.Controls.Add((Control)this.radioButton_0);
        this.groupBox_4.Controls.Add((Control)this.radioButton_1);
        this.groupBox_4.Font = (Font)null;
        this.groupBox_4.Name = "groupBox4";
        this.groupBox_4.TabStop = false;
        this.listBox_0.AccessibleDescription = (string)null;
        this.listBox_0.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.listBox_0, "listBox1");

        this.listBox_0.BackgroundImage = (Image) null;
    this.listBox_0.Font = (Font) null;
    this.listBox_0.FormattingEnabled = true;
        this.listBox_0.Name = "listBox1";
        this.listBox_0.SelectedIndexChanged += new EventHandler(this.listBox_0_SelectedIndexChanged);
        this.label_18.AccessibleDescription = (string)null;
        this.label_18.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_18, "label6");

        this.label_18.Font = (Font) null;
        this.label_18.Name = "label6";// Module.a("\uD8B3ힵ\uDAB7\uDFB9킻袽", 14);
    this.selectControllerButton.AccessibleDescription = (string) null;
    this.selectControllerButton.AccessibleName = (string) null;
        componentResourceManager.ApplyResources((object)this.selectControllerButton, "button4");

        this.selectControllerButton.BackgroundImage = (Image) null;
    this.selectControllerButton.ForeColor = SystemColors.HotTrack;
        this.selectControllerButton.Name = "button4";// Module.a("횳쎵첷캹펻킽\uF4BF", 14);
    this.selectControllerButton.UseVisualStyleBackColor = true;
        LogData.LogInfo($"NewProjectForm: selectControllerButton.Text: {selectControllerButton.Text}");
    this.selectControllerButton.Click += new EventHandler(this.selectControllerButton_Click);
    this.label_19.AccessibleDescription = (string) null;
    this.label_19.AccessibleName = (string) null;
        componentResourceManager.ApplyResources((object)this.label_19, "label7");
        this.label_19.Name = "label7";
        LogData.LogInfo($"NewProjectForm: label_19.Text: {label_19.Text}");
        this.AccessibleDescription = (string)null;
        this.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this, "DDHIC");

        this.AutoScaleMode = AutoScaleMode.Font;
        this.AutoSize = true;
        this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
    this.BackgroundImage = (Image) null;
    this.ControlBox = false;
    this.Controls.Add((Control) this.label_19);
    this.Controls.Add((Control) this.selectControllerButton);
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
    this.Controls.Add((Control) this.comboBox_RGBChannel);
    this.Controls.Add((Control) this.label_17);
    this.Controls.Add((Control) this.label_4);
    this.Controls.Add((Control) this.label_16);
    this.Controls.Add((Control) this.groupBox_3);
    this.Controls.Add((Control) this.groupBox_1);
    this.Controls.Add((Control) this.groupBox_0);
    this.Controls.Add((Control) this.textBox_ProjectFilePath);
    this.Controls.Add((Control) this.button_2);
    this.Controls.Add((Control) this.label_2);
    this.Controls.Add((Control) this.BrowseButton);
    this.Controls.Add((Control) this.OkButton);
    this.Font = (Font) null;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Icon = (Icon) null;
    this.Name = "System_Set";//Module.a("\uE7B3쾵쮷캹\uD9BB펽龿釁ꇃ닅", 14);
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

  public NewProjectForm()
  {
    int int_0 = 12;
    // ISSUE: explicit constructor call
 //   base.\u002Ector();
    this.LayoutForm();
        this.textBox_ProjectFilePath.Text = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + (object)'\\' + "Led1.px";//Module.a("ﺱ톳튵覷钹첻욽ꊿ", 12);
    this.comboBox_0.SelectedIndex = 19;
    this.comboBox_RGBChannel.SelectedIndex = 0;
    this.arrayList_0 = new ArrayList();
    this.arrayList_0.Clear();
    bool flag1 = false;
        string path1 = Application.StartupPath + "\\SET\\dingzhi_enable.t"; // Module.a("\uEEB1\uE7B3\uF3B5\uECB7\uE6B9\uD8BBힽ꺿ꗁ뻃껅ꇇ闉꧋ꃍ뇏냑룓돕\uF6D7껙ꓛꫝ", 12);
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
      this.selectControllerButton.Visible = false;
      this.label_19.Visible = true;
    }
    else
    {
      this.selectControllerButton.Visible = true;
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
                LogData.LogInfo("F: Streamwriter Start");
        using (StreamWriter streamWriter = new StreamWriter(path2, false, Encoding.Unicode))
        {
          streamWriter.WriteLine("G"/*Module.a("薱", dataEntryPoint)*/);
          streamWriter.WriteLine(Module.a("花莳薵覆﮹袻﮽\uF0BF﯁\uF6C3\uF0C5劉韛ￋ\uFBCD\uE1CF铑鋓\uE0D5鷗\uE8D9鷛鯝ꇟ탡ꇣꏥ\uD9E7\uDDE9ꫫ\uDEED뗯냱싳샵췷싹쿻췽ㇿ㌁䀃㈅䴇㨉䤋䴍␏␑┓ℕ⤗堙堛Ⱍ戟昡ሣ攥ဧ温樫ḭ̯ȱ瀳眵षਹ縻紽Ŀ畁畃ͅେཉ祋్楏ၑ恓恕ᵗṙ潛橝呟偡啣╥幧⡩\u2E6B噭䥯ㅱ䑳ふ㵷㡹㹻䭽쉿쎁뒃쒅뺇붉쾋뮍ꞏꞑ킓펕ꆗ꺙겛ꦝ\uE59F\uE7A1钣鎥麧颩麫颭覯膱膳膵醴貹ﾻ誽\uF2BF胁\uF5C3\uF7C5難\uF3C9溜ￍ鏏", int_0,true));
          streamWriter.WriteLine(Module.a("花莳薵覆﮹袻﮽\uF0BF﯁\uF6C3\uF0C5劉韛ￋ\uFBCD\uE1CF铑鋓\uE0D5鷗\uE8D9鷛鯝ꇟ탡ꇣꏥ\uD9E7\uDDE9ꫫ\uDEED뗯뛱뗳컵뻷맹쯻믽䛿\u3101䀃䌅㬇㸉䴋伍┏儑∓刕⬗堙⤛⠝ᐟሡᴣ急椧氩漫\u192D\u082F焱Գ̵ష縹\u0A3BܽĿ݁煃ͅ灇ॉ罋罍ᕏ晑ၓ慕ᩗ᱙ṛὝ偟兡剣\u2465內⥩奫彭䕯䩱㝳乵㵷䡹㵻䡽롿뮁얃뚅첇뢉좋랍ꂏꖑ궓ꞕ\uDC97ꮙ궛\uDB9D閟\uE0A1\uE1A3\uE3A5邧鎩骫颭\uF1AF蒱膳\uF0B5ﲷ袹ﺻ讽\uF5BF\uF6C1\uF0C3蓅難ﳉ頋諍\uE4CF金雓\uEFD5髗\uE2D9飛\uEBDD탟훡퓣훥곧ꯩ껫\uDCED쏯", int_0,true));
          streamWriter.WriteLine(Module.a("\uF6B1足肵辷誹ﺻ貽膿蛁\uF0C3\uF7C5\uFBC7柳ￋ词鋏\uE1D1\uEDD3\uE7D5鯗\uEAD9黛\uECDDꛟ폡ꋣ퓥\uDBE7껩ꧫ\uD8ED뛯뇱쟳쿵죷쏹맻볽㓿㈁䄃䐅㰇伉伋㴍☏儑∓✕嬗嬙⸛ⴝ感ᜡᔣ朥ᴧᨩḫḭ̯猱瀳猵笷ഹ\u0D3Bؽ砿牁絃畅େ้ੋ睍敏", int_0),true);
          streamWriter.WriteLine(Module.a("螱\uF1B3螵趷芹覻螽芿\uF3C1\uF2C3蟅軇韛請词\uE5CF\uE0D1\uE1D3韕鯗黙飛\uEADDꓟ훡\uDDE3헥\uDDE7꿩\uD8EB\uDBED돯뛱럳냵컷쯹쯻췽䋿㘁㜃㸅万三䴋䠍␏儑✓匕Ⱇ∙␛⨝星ᄡ昣ᘥ洧ᠩ洫洭甯\u0A31瘳眵࠷̹༻砽琿獁Cх筇獉ࡋ癍晏", int_0),true);
          streamWriter.WriteLine(Module.a("螱\uF1B3螵趷芹覻螽芿\uF3C1\uF2C3蟅軇韛請词\uE5CF\uE0D1\uE7D3铕\uEED7\uE9D9\uEBDB\uEADDꇟ퇡ꛣꋥꧧ\uDBE9\uDBEB귭쟯엱췳쇵뫷룹쫻짽䏿\u3101䜃㸅万䠉㨋䨍∏☑倓―嬗帙┛嬝戟愡愣ሥ洧ᬩ樫氭猯ر眳眵\u0A37簹\u0E3Bܽ爿獁݃Eେ\u0C49繋్ᑏၑ敓ᑕ浗ᥙ摛潝╟Ⅱ兣坥嵧剩⥫\u2D6D䁯㝱䵳㉵佷䡹㹻䙽롿잁뒃쎅뮇즉뾋뮍톏펑ꎓꊕ\uDE97\uDB99ꮛ꾝\uE59F醡銣钥鲧銩\uEEAB颭\uF5AF薱蒳\uF0B5膷ﾹﶻﲽ\uF7BF\uF5C1胃\uF0C5難ﳉ迋词雏铑\uE2D3\uE3D5\uEBD7\uE8D9鷛\uEFDD\uD9DFꏡ\uDDE3ꏥ\uDFE7꿩\uD8EBퟭ엯", int_0,true));
          streamWriter.WriteLine(Module.a("螱\uF1B3螵趷芹覻螽芿\uF3C1\uF2C3蟅軇韛請词\uE5CF\uE1D1闓\uEFD5\uEBD7黙\uE5DB\uE6DD\uD8DF헡ꋣퟥ\uDDE7ꧩ귫\uDAED뗯뛱샳듵샷룹쿻쿽㗿䐁䘃㼅䨇㸉䨋䴍☏⌑␓┕ⴗ⠙ⴛ☝\u181FᨡሣᔥᰧᤩᤫἭ猯Աĳ瀵簷ହлଽ焿穁كE硇繉硋ཌྷ楏", int_0),true);
          streamWriter.WriteLine(Module.a("螱\uF1B3螵趷芹覻螽芿\uF3C1\uF2C3蟅軇韛請词\uE5CF\uEBD1闓\uE1D5\uE8D7黙飛\uEFDD폟\uDBE1ꗣ\uDFE5탧꿩\uDFEB훭쇯싱췳듵뫷쫹쯻췽䏿䌁䘃㌅䴇㨉䨋㸍吏⬑┓匕⬗ⰙⴛⰝᔟሡ攣戥ᬧሩᠫ欭瘯琱瘳猵縷ହ縻\u0E3D眿穁牃瑅็硉ࡋ繍ፏ", int_0),true);
         LogData.LogInfo("F: Streamwriter End");
           continue;
        }
      }
      else
        break;
label_19:
            path2 = Application.StartupPath + "\\SET\\dingzhi_xx.txt"; 
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
        string path3 = c.settingsPath + "\\ttype_ss10.txt";

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
        LogData.LogInfo($"GetVerticalPixels Start string_0: {string_0} c.ledControllerType: {c.ledControllerType}");
    if (!(this.string_0 == "T-8000-SC" /*Module.a("\uE7B2颴辶覸论趼銾鋀胂", 13)*/) &&
            !(this.string_0 == "2200-595" /*Module.a("膲螴螶覸隺袼蚾\uF4C0", dataEntryPoint)*/) &&
            !(this.string_0 == "LED007-v8.5" /*Module.a("ﾲ\uF0B4\uF3B6覸论誼銾럀\uFBC2\uEBC4\uF2C6", dataEntryPoint) */) &&
            !(this.string_0 == "LED-V8.5" /*Module.a("ﾲ\uF0B4\uF3B6钸\uEDBA薼醾\uF4C0", dataEntryPoint)*/))
    {
      if (this.string_0 == "T-1000-SC"/* Module.a("\uE7B2颴蚶覸论趼銾鋀胂", dataEntryPoint)*/)
        c.ledControllerType = 14;
      else if (this.string_0 == "DMX V3 Monochrome" /*Module.a("\uF7B2\uF8B4\uEFB6馸\uEDBA躼龾賀곂ꯄ\uA8C6\uAAC8ꏊ뿌ꃎ볐뛒", dataEntryPoint)*/)
        c.ledControllerType = 51;
      else if (this.string_0 == "V3-M Monochrome" /*Module.a("\uE5B2蚴骶\uF4B8鮺\uF0BC킾꿀곂ꛄ꿆믈\uA4CAꃌ\uAACE", dataEntryPoint)*/)
      {
        c.ledControllerType = 55;
        c.byte_20 = (byte) 0;
      }
      else if (this.string_0 == "T-1000-DMX-Monochrome" /*Module.a("\uE7B2颴蚶覸论趼銾藀軂鷄\uEAC6蓈\uA4CAꏌꃎ닐믒\uA7D4룖듘뻚", dataEntryPoint)*/)
      {
        c.ledControllerType = 55;
        c.byte_20 = (byte) 1;
      }
      else if (!(this.string_0 == "T-4000-6803"/*Module.a("\uE7B2颴莶覸论趼銾\uF7C0\uFBC2\uF5C4\uF4C6", dataEntryPoint)*/) && 
                !(this.string_0 == "LED007-v4.0" /*Module.a("ﾲ\uF0B4\uF3B6覸论誼銾럀\uF7C2\uEBC4\uF7C6", dataEntryPoint)*/) && 
                !(this.string_0 == "1101 V4.0" /*Module.a("芲蒴螶袸鮺\uEBBC设\uEFC0\uF3C2", dataEntryPoint)*/) && 
                !(this.string_0 == "LED-V4.0" /*Module.a("ﾲ\uF0B4\uF3B6钸\uEDBA覼醾\uF1C0", dataEntryPoint)*/))
      {
        if (!(this.string_0 == "T-8000-6803" /*Module.a("\uE7B2颴辶覸论趼銾\uF7C0\uFBC2\uF5C4\uF4C6", dataEntryPoint)*/) &&
                    !(this.string_0 == "LED007-v8.0" /*Module.a("ﾲ\uF0B4\uF3B6覸论誼銾럀\uFBC2\uEBC4\uF7C6", dataEntryPoint)*/) &&
                    !(this.string_0 == "1101 V8.0" /*Module.a("芲蒴螶袸鮺\uEBBC螾\uEFC0\uF3C2", dataEntryPoint)*/) && 
                    !(this.string_0 == "LED-V8.0" /*Module.a("ﾲ\uF0B4\uF3B6钸\uEDBA薼醾\uF1C0", dataEntryPoint)*/))
        {
          if (!(this.string_0 == "T-100K-8806" /*Module.a("\uE7B2颴蚶覸论\uF6BC銾燎\uFBC2\uF5C4\uF1C6", dataEntryPoint)*/) &&
                        !(this.string_0 == "LED007-V8806" /*Module.a("ﾲ\uF0B4\uF3B6覸论誼銾韀\uFBC2ﷄ\uF7C6\uFFC8", dataEntryPoint)*/))
          {
            if (this.string_0 == "T-100K-B-8806" /*Module.a("\uE7B2颴蚶覸论\uF6BC銾菀\uEEC2ﷄￆ杻\uFDCA", dataEntryPoint) */)
            {
              c.ledControllerType = 150;
              c.bool_2 = true;
            }
            else if (!(this.string_0 == "T-1000-6803" /*Module.a("\uE7B2颴蚶覸论趼銾\uF7C0\uFBC2\uF5C4\uF4C6", dataEntryPoint)*/) &&
                            !(this.string_0 == "LED007-v1.0" /*Module.a("ﾲ\uF0B4\uF3B6覸论誼銾럀\uF2C2\uEBC4\uF7C6", dataEntryPoint)*/) &&
                            !(this.string_0 == "1101 V1.0" /*Module.a("芲蒴螶袸鮺\uEBBC躾\uEFC0\uF3C2", dataEntryPoint)*/) &&
                            !(this.string_0 == "LED-V1.0" /*Module.a("ﾲ\uF0B4\uF3B6钸\uEDBA貼醾\uF1C0", dataEntryPoint)*/) &&
                            !(this.string_0 == "1100-D705" /*Module.a("芲蒴螶覸隺寮袾\uF1C0\uF6C2", dataEntryPoint)*/))
            {
              if (this.string_0 == "T-1000-HL32" /*Module.a("\uE7B2颴蚶覸论趼銾觀迂\uF6C4\uF5C6", dataEntryPoint)*/)
              {
                c.ledControllerType = 9;
                c.byte_20 = (byte) 1;
              }
              else if (this.string_0 == "T-1000-D7710" /*Module.a("\uE7B2颴蚶覸论趼銾藀\uF4C2\uF2C4\uF6C6杻", dataEntryPoint)*/)
              {
                c.ledControllerType = 9;
                c.byte_20 = (byte) 2;
              }
              else if (this.string_0 == "T-1000-QC6809"/*Module.a("\uE7B2颴蚶覸论趼銾郀胂\uF3C4ￆ杻\uF2CA", dataEntryPoint)*/)
              {
                c.ledControllerType = 9;
                c.byte_20 = (byte) 3;
              }
                else if (!(this.string_0 == "T-100K-SC") && !(this.string_0 == "2100-595") && !(this.string_0 == "LED007-v8.85") && !(this.string_0 == "LED-V8.32-256"))
                            {
                                if (!(this.string_0 == "T-100K-6803") && !(this.string_0 == "VC-500A") && !(this.string_0 == "2100-D705") && !(this.string_0 == "LED007-v8.86") && !(this.string_0 == "1101 V8.1") && !(this.string_0 == "LED-V8.32"))
                                {
                                    if (!(this.string_0 == "T-100K-B-6803") && !(this.string_0 == "LED007-v8.88"))
                                    {
                                        if (this.string_0 == "TIAO-PING")
                                            c.ledControllerType = 201;
                                        else if (!(this.string_0 == "T-100K-WS") && !(this.string_0 == "2100-IIC8") && !(this.string_0 == "LED007-v8.82") && !(this.string_0 == "LED-V8.256"))
                                        {
                                            if (this.string_0 == "T-100K-B-WS")
                                            {
                                                c.ledControllerType = 120;
                                                c.bool_2 = true;
                                            }
                                            else if (!(this.string_0 == "T-8000-WS") && !(this.string_0 == "LED007-v8.2") && !(this.string_0 == "LED-V8.2"))
                                            {
                                                if (!(this.string_0 == "T-1000-WS") && !(this.string_0 == "1100-IIC8") && !(this.string_0 == "LED007-v1.2") && !(this.string_0 == "LED-V1.2"))
                                                {
                                                    if (this.string_0 == "T-1000-HL2803")
                                                        c.ledControllerType = 13;
                                                    else if (!(this.string_0 == "T-1000-8806") && !(this.string_0 == "LED007-v1.6"))
                                                    {
                                                        if (!(this.string_0 == "T-4000-8806") && !(this.string_0 == "LED007-V4.6"))
                                                        {
                                                            if (!(this.string_0 == "T-8000-8806") && !(this.string_0 == "LED007-V8.6"))
                                                            {
                                                                if (!(this.string_0 == "T-4000-WS") && !(this.string_0 == "LED007-v4.2") && !(this.string_0 == "LED-V4.2"))
                                                                {
                                                                    if (!(this.string_0 == "T-100K-TLS") && !(this.string_0 == "2100-M8") && !(this.string_0 == "TLS V5"))
                                                                    {
                                                                        if (this.string_0 == "T-100K-P9813")
                                                                        {
                                                                            c.ledControllerType = 140;
                                                                            c.byte_20 = (byte)1;
                                                                        }
                                                                        else if (this.string_0 == "T-100K-0815")
                                                                        {
                                                                            c.ledControllerType = 140;
                                                                            c.byte_20 = (byte)2;
                                                                        }
                                                                        else if (!(this.string_0 == "TLS V5-M") && !(this.string_0 == "Curtain V5"))
                                                                        {
                                                                            if (this.string_0 == "T-100K-0825")
                                                                            {
                                                                                c.ledControllerType = 140;
                                                                                c.byte_20 = (byte)5;
                                                                            }
                                                                            else if (this.string_0 == "T-100K-0901")
                                                                            {
                                                                                c.ledControllerType = 140;
                                                                                c.byte_20 = (byte)6;
                                                                            }
                                                                            else if (this.string_0 == "Curtain V5-Monochrome")
                                                                            {
                                                                                c.ledControllerType = 140;
                                                                                c.byte_20 = (byte)7;
                                                                            }
                                                                            else if (this.string_0 == "T-100K-APA102")
                                                                            {
                                                                                c.ledControllerType = 140;
                                                                                c.byte_20 = (byte)8;
                                                                            }
                                                                            else if (this.string_0 == "T-100K-6813")
                                                                            {
                                                                                c.ledControllerType = 140;
                                                                                c.byte_20 = (byte)9;
                                                                            }
                                                                            else if (this.string_0 == "T-500K-ALL")
                                                                            {
                                                                                c.ledControllerType = 180;
                                                                                c.byte_20 = (byte)0;
                                                                            }
                                                                            else if (!(this.string_0 == "T-8000-TLS") && !(this.string_0 == "TLS V1"))
                                                                            {
                                                                                if (!(this.string_0 == "T-1000-TLS") && !(this.string_0 == "1100-M8") && !(this.string_0 == "TLS V3") && !(this.string_0 == "TLS V3-M") && !(this.string_0 == "Curtain V3"))
                                                                                {
                                                                                    if (this.string_0 == "T-1000-P9813")
                                                                                    {
                                                                                        c.ledControllerType = 47;
                                                                                        c.byte_20 = (byte)1;
                                                                                    }
                                                                                    else if (this.string_0 == "T-1000-0815")
                                                                                    {
                                                                                        c.ledControllerType = 47;
                                                                                        c.byte_20 = (byte)2;
                                                                                    }
                                                                                    else if (this.string_0 == "T-1000-HL1809")
                                                                                    {
                                                                                        c.ledControllerType = 47;
                                                                                        c.byte_20 = (byte)3;
                                                                                    }
                                                                                    else if (this.string_0 == "T-1000-MY9221")
                                                                                    {
                                                                                        c.ledControllerType = 47;
                                                                                        c.byte_20 = (byte)4;
                                                                                    }
                                                                                    else if (this.string_0 == "T-1000-0825")
                                                                                    {
                                                                                        c.ledControllerType = 47;
                                                                                        c.byte_20 = (byte)5;
                                                                                    }
                                                                                    else if (this.string_0 == "T-1000-0901")
                                                                                    {
                                                                                        c.ledControllerType = 47;
                                                                                        c.byte_20 = (byte)6;
                                                                                    }
                                                                                    else if (this.string_0 == "T-1000-APA102")
                                                                                    {
                                                                                        c.ledControllerType = 47;
                                                                                        c.byte_20 = (byte)8;
                                                                                    }
                                                                                    else if (this.string_0 == "T-1000-6813")
                                                                                    {
                                                                                        c.ledControllerType = 47;
                                                                                        c.byte_20 = (byte)9;
                                                                                    }
                                                                                    else if (!(this.string_0 == "T-4000-TLS") && !(this.string_0 == "TLS V2") && !(this.string_0 == "TLS V2-M") && !(this.string_0 == "Curtain V2"))
                                                                                    {
                                                                                        if (this.string_0 == "T-4000-P9813")
                                                                                        {
                                                                                            c.ledControllerType = 48;
                                                                                            c.byte_20 = (byte)1;
                                                                                        }
                                                                                        else if (this.string_0 == "T-4000-0815")
                                                                                        {
                                                                                            c.ledControllerType = 48;
                                                                                            c.byte_20 = (byte)2;
                                                                                        }
                                                                                        else if (this.string_0 == "T-4000-0825")
                                                                                        {
                                                                                            c.ledControllerType = 48;
                                                                                            c.byte_20 = (byte)5;
                                                                                        }
                                                                                        else if (this.string_0 == "T-4000-0901")
                                                                                        {
                                                                                            c.ledControllerType = 48;
                                                                                            c.byte_20 = (byte)6;
                                                                                        }
                                                                                        else if (!(this.string_0 == "T-100K-TM") && !(this.string_0 == "2100-RZ8") && !(this.string_0 == "TM-TXV1") && !(this.string_0 == "MEGA-V1") && !(this.string_0 == "@GB"))
                                                                                        {
                                                                                            if (!(this.string_0 == "T-100K-SM16715") && !(this.string_0 == "SM16715 V5"))
                                                                                            {
                                                                                                if (!(this.string_0 == "T-100K-SM16716") && !(this.string_0 == "SM16716 V5"))
                                                                                                {
                                                                                                    if (this.string_0 == "T-100K-TM19")
                                                                                                    {
                                                                                                        c.byte_20 = (byte)5;
                                                                                                        c.ledControllerType = 130;
                                                                                                    }
                                                                                                    else if (this.string_0 == "T-100K-DS189")
                                                                                                    {
                                                                                                        c.byte_20 = (byte)6;
                                                                                                        c.ledControllerType = 130;
                                                                                                    }
                                                                                                    else if (this.string_0 == "T-100K-UCS-1024")
                                                                                                    {
                                                                                                        c.byte_20 = (byte)7;
                                                                                                        c.ledControllerType = 130;
                                                                                                    }
                                                                                                    else if (this.string_0 == "T-100K-ADD_1")
                                                                                                    {
                                                                                                        c.byte_20 = (byte)81;
                                                                                                        c.ledControllerType = 130;
                                                                                                    }
                                                                                                    else if (this.string_0 == "T-100K-ADD_2")
                                                                                                    {
                                                                                                        c.byte_20 = (byte)82;
                                                                                                        c.ledControllerType = 130;
                                                                                                    }
                                                                                                    else if (this.string_0 == "T-100K-ADD_3")
                                                                                                    {
                                                                                                        c.byte_20 = (byte)83;
                                                                                                        c.ledControllerType = 130;
                                                                                                    }
                                                                                                    else if (this.string_0 == "T-100K-ADD_4")
                                                                                                    {
                                                                                                        c.byte_20 = (byte)84;
                                                                                                        c.ledControllerType = 130;
                                                                                                    }
                                                                                                    else if (this.string_0 == "T-100K-ADD_5")
                                                                                                    {
                                                                                                        c.byte_20 = (byte)85;
                                                                                                        c.ledControllerType = 130;
                                                                                                    }
                                                                                                    else if (this.string_0 == "T-100K-ADD_6")
                                                                                                    {
                                                                                                        c.byte_20 = (byte)86;
                                                                                                        c.ledControllerType = 130;
                                                                                                    }
                                                                                                    else if (this.string_0 == "T-100K-ADD_7")
                                                                                                    {
                                                                                                        c.byte_20 = (byte)87;
                                                                                                        c.ledControllerType = 130;
                                                                                                    }
                                                                                                    else if (this.string_0 == "T-100K-ADD_8")
                                                                                                    {
                                                                                                        c.byte_20 = (byte)88;
                                                                                                        c.ledControllerType = 130;
                                                                                                    }
                                                                                                    else if (this.string_0 == "T-100K-ADD_9")
                                                                                                    {
                                                                                                        c.byte_20 = (byte)89;
                                                                                                        c.ledControllerType = 130;
                                                                                                    }
                                                                                                    else if (this.string_0 == "T-100K-ADD_10")
                                                                                                    {
                                                                                                        c.byte_20 = (byte)90;
                                                                                                        c.ledControllerType = 130;
                                                                                                    }
                                                                                                    else if (!(this.string_0 == "T-100K-B-TM") && !(this.string_0 == "TM-B-TXV1") && !(this.string_0 == "MEGA-B-V1"))
                                                                                                    {
                                                                                                        if (!(this.string_0 == "T-100K-B-SM16715") && !(this.string_0 == "SM16715 V5-B"))
                                                                                                        {
                                                                                                            if (!(this.string_0 == "T-100K-B-SM16716") && !(this.string_0 == "SM16716 V5-B"))
                                                                                                            {
                                                                                                                if (this.string_0 == "T-100K-B-TM19")
                                                                                                                {
                                                                                                                    c.byte_20 = (byte)5;
                                                                                                                    c.ledControllerType = 130;
                                                                                                                    c.bool_2 = true;
                                                                                                                }
                                                                                                                else if (this.string_0 == "T-100K-B-DS189")
                                                                                                                {
                                                                                                                    c.byte_20 = (byte)6;
                                                                                                                    c.ledControllerType = 130;
                                                                                                                    c.bool_2 = true;
                                                                                                                }
                                                                                                                else if (this.string_0 == "T-100K-B-UCS-1024")
                                                                                                                {
                                                                                                                    c.byte_20 = (byte)7;
                                                                                                                    c.ledControllerType = 130;
                                                                                                                    c.bool_2 = true;
                                                                                                                }
                                                                                                                else if (this.string_0 == "T-100K-B-SD5128")
                                                                                                                {
                                                                                                                    c.byte_20 = (byte)8;
                                                                                                                    c.ledControllerType = 130;
                                                                                                                    c.bool_2 = true;
                                                                                                                }
                                                                                                                else if (this.string_0 == "T-100K-1677")
                                                                                                                {
                                                                                                                    c.ledControllerType = 130;
                                                                                                                    c.bool_2 = true;
                                                                                                                    c.byte_20 = (byte)10;
                                                                                                                }
                                                                                                                else if (this.string_0 == "T-100K-B-TM1829")
                                                                                                                {
                                                                                                                    c.byte_20 = (byte)11;
                                                                                                                    c.ledControllerType = 130;
                                                                                                                    c.bool_2 = true;
                                                                                                                }
                                                                                                                else if (this.string_0 == "T-100K-SM16726")
                                                                                                                {
                                                                                                                    c.ledControllerType = 130;
                                                                                                                    c.bool_2 = true;
                                                                                                                    c.byte_20 = (byte)12;
                                                                                                                }
                                                                                                                else if (this.string_0 == "T-100K-B-1882")
                                                                                                                {
                                                                                                                    c.ledControllerType = 130;
                                                                                                                    c.bool_2 = true;
                                                                                                                    c.byte_20 = (byte)13;
                                                                                                                }
                                                                                                                else if (this.string_0 == "T-100K-B-6812")
                                                                                                                {
                                                                                                                    c.ledControllerType = 130;
                                                                                                                    c.bool_2 = true;
                                                                                                                    c.byte_20 = (byte)14;
                                                                                                                }
                                                                                                                else if (this.string_0 == "T-100K-B-WS2811")
                                                                                                                {
                                                                                                                    c.ledControllerType = 130;
                                                                                                                    c.bool_2 = true;
                                                                                                                    c.byte_20 = (byte)15;
                                                                                                                }
                                                                                                                else if (this.string_0 == "T-100K-B-TA9909")
                                                                                                                {
                                                                                                                    c.ledControllerType = 130;
                                                                                                                    c.bool_2 = true;
                                                                                                                    c.byte_20 = (byte)16;
                                                                                                                }
                                                                                                                else if (this.string_0 == "T-100K-B-6021")
                                                                                                                {
                                                                                                                    c.ledControllerType = 130;
                                                                                                                    c.bool_2 = true;
                                                                                                                    c.byte_20 = (byte)17;
                                                                                                                }
                                                                                                                else if (this.string_0 == "T-100K-B-GW623X")
                                                                                                                {
                                                                                                                    c.ledControllerType = 130;
                                                                                                                    c.bool_2 = true;
                                                                                                                    c.byte_20 = (byte)18;
                                                                                                                }
                                                                                                                else if (this.string_0 == "T-100K-B-GW624X")
                                                                                                                {
                                                                                                                    c.ledControllerType = 130;
                                                                                                                    c.bool_2 = true;
                                                                                                                    c.byte_20 = (byte)19;
                                                                                                                }
                                                                                                                else if (this.string_0 == "T-100K-B-LPD1886")
                                                                                                                {
                                                                                                                    c.ledControllerType = 130;
                                                                                                                    c.bool_2 = true;
                                                                                                                    c.byte_20 = (byte)20;
                                                                                                                }
                                                                                                                else if (this.string_0 == "T-100K-B-UCS8903")
                                                                                                                {
                                                                                                                    c.ledControllerType = 130;
                                                                                                                    c.bool_2 = true;
                                                                                                                    c.byte_20 = (byte)21;
                                                                                                                }
                                                                                                                else if (this.string_0 == "T-100K-B-ADD_1")
                                                                                                                {
                                                                                                                    c.ledControllerType = 130;
                                                                                                                    c.bool_2 = true;
                                                                                                                    c.byte_20 = (byte)41;
                                                                                                                }
                                                                                                                else if (this.string_0 == "T-100K-B-ADD_2")
                                                                                                                {
                                                                                                                    c.ledControllerType = 130;
                                                                                                                    c.bool_2 = true;
                                                                                                                    c.byte_20 = (byte)42;
                                                                                                                }
                                                                                                                else if (this.string_0 == "T-100K-B-ADD_3")
                                                                                                                {
                                                                                                                    c.ledControllerType = 130;
                                                                                                                    c.bool_2 = true;
                                                                                                                    c.byte_20 = (byte)43;
                                                                                                                }
                                                                                                                else if (this.string_0 == "T-100K-B-ADD_4")
                                                                                                                {
                                                                                                                    c.ledControllerType = 130;
                                                                                                                    c.bool_2 = true;
                                                                                                                    c.byte_20 = (byte)44;
                                                                                                                }
                                                                                                                else if (this.string_0 == "T-100K-B-ADD_5")
                                                                                                                {
                                                                                                                    c.ledControllerType = 130;
                                                                                                                    c.bool_2 = true;
                                                                                                                    c.byte_20 = (byte)45;
                                                                                                                }
                                                                                                                else if (this.string_0 == "T-100K-B-ADD_6")
                                                                                                                {
                                                                                                                    c.ledControllerType = 130;
                                                                                                                    c.bool_2 = true;
                                                                                                                    c.byte_20 = (byte)46;
                                                                                                                }
                                                                                                                else if (this.string_0 == "T-100K-B-ADD_7")
                                                                                                                {
                                                                                                                    c.ledControllerType = 130;
                                                                                                                    c.bool_2 = true;
                                                                                                                    c.byte_20 = (byte)47;
                                                                                                                }
                                                                                                                else if (this.string_0 == "T-100K-B-ADD_8")
                                                                                                                {
                                                                                                                    c.ledControllerType = 130;
                                                                                                                    c.bool_2 = true;
                                                                                                                    c.byte_20 = (byte)48;
                                                                                                                }
                                                                                                                else if (this.string_0 == "T-100K-B-ADD_9")
                                                                                                                {
                                                                                                                    c.ledControllerType = 130;
                                                                                                                    c.bool_2 = true;
                                                                                                                    c.byte_20 = (byte)49;
                                                                                                                }
                                                                                                                else if (this.string_0 == "T-100K-B-ADD_10")
                                                                                                                {
                                                                                                                    c.ledControllerType = 130;
                                                                                                                    c.bool_2 = true;
                                                                                                                    c.byte_20 = (byte)50;
                                                                                                                }
                                                                                                                else if (this.string_0 == "T-8000-TM")
                                                                                                                    c.ledControllerType = 31;
                                                                                                                else if (!(this.string_0 == "T-4000-TM") && !(this.string_0 == "TM-TXV4") && !(this.string_0 == "MEGA-V4"))
                                                                                                                {
                                                                                                                    if (!(this.string_0 == "T-4000-SM16715") && !(this.string_0 == "SM16715 V2"))
                                                                                                                    {
                                                                                                                        if (!(this.string_0 == "T-4000-SM16716") && !(this.string_0 == "SM16716 V2"))
                                                                                                                        {
                                                                                                                            if (this.string_0 == "T-4000-TM19")
                                                                                                                            {
                                                                                                                                c.ledControllerType = 50;
                                                                                                                                c.byte_20 = (byte)5;
                                                                                                                            }
                                                                                                                            else if (this.string_0 == "T-4000-DS189")
                                                                                                                            {
                                                                                                                                c.ledControllerType = 50;
                                                                                                                                c.byte_20 = (byte)6;
                                                                                                                            }
                                                                                                                            else if (!(this.string_0 == "T-1000-TM") && !(this.string_0 == "1100-RZ8") && !(this.string_0 == "TM-TXV3") && !(this.string_0 == "MEGA-V3") && !(this.string_0 == "@GC"))
                                                                                                                            {
                                                                                                                                if (!(this.string_0 == "T-1000-SM16715") && !(this.string_0 == "SM16715 V3"))
                                                                                                                                {
                                                                                                                                    if (!(this.string_0 == "T-1000-SM16716") && !(this.string_0 == "SM16716 V3"))
                                                                                                                                    {
                                                                                                                                        if (this.string_0 == "T-1000C-Monochrome")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)5;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-1000-TM19")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)6;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-1000-DS189")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)7;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-1000-UCS-1024")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)8;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-1000-DMX2048")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)9;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-1000-1677")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)10;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-1000-TM1829")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)11;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-1000-SM16726")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)12;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-1000-1882")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)13;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-1000-6812")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)14;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-1000-WS2811")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)15;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-1000-TA9909")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)16;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-1000-6021")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)17;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-1000-GW623X")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)18;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-1000-GW624X")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)19;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-1000-LPD1886")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)20;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-1000-UCS8903")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)21;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "K-1000-ALL")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)22;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-1000-TM1913")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)41;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-1000-TM1914")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)42;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-1000-ADD_3")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)43;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-1000-ADD_4")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)44;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-1000-ADD_5")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)45;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-1000-ADD_6")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)46;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-1000-ADD_7")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)47;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-1000-ADD_8")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)48;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-1000-ADD_9")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)49;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-1000-ADD_10")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)50;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-2000-TM")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)61;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-2000-16711")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)62;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-2000-SM16716")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)63;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-2000-SM16726")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)64;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-2000-TM1829")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)65;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-2000-6803")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)66;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-2000-9813")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)67;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-2000-WS2801")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)68;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-2000-WS2811")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)69;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-2000-TA9909")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)70;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-2000-6021")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)71;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-2000-GW623X")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)72;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-2000-GW624X")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)73;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-2000-LPD1886")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)74;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-2000-UCS8903")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)75;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-2000-ADD_1")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)91;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-2000-ADD_2")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)92;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-2000-ADD_3")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)93;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-2000-ADD_4")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)94;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-2000-ADD_5")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)95;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-2000-ADD_6")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)96;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-2000-ADD_7")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)97;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-2000-ADD_8")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)98;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-2000-ADD_9")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)99;
                                                                                                                                        }
                                                                                                                                        else if (this.string_0 == "T-2000-ADD_10")
                                                                                                                                        {
                                                                                                                                            c.ledControllerType = 32;
                                                                                                                                            c.byte_20 = (byte)100;
                                                                                                                                        }
                                                                                                                                        else if (!(this.string_0 == "T-100K-DMX") && !(this.string_0 == "DMX V5") && !(this.string_0 == "DMX-TXV1") && !(this.string_0 == "NKC-070") && !(this.string_0 == "MEGA-DMXV1") && !(this.string_0 == "@GA") && !(this.string_0 == "VC-500B") && !(this.string_0 == "2100-DMX"))
                                                                                                                                        {
                                                                                                                                            if (this.string_0 == "T-100K-B-DMX-Monochrome")
                                                                                                                                            {
                                                                                                                                                c.ledControllerType = 110;
                                                                                                                                                c.byte_20 = (byte)3;
                                                                                                                                            }
                                                                                                                                            else if (!(this.string_0 == "T-8000-DMX") && !(this.string_0 == "DMX V1"))
                                                                                                                                            {
                                                                                                                                                if (!(this.string_0 == "T-4000-DMX") && !(this.string_0 == "DMX V2"))
                                                                                                                                                {
                                                                                                                                                    if (!(this.string_0 == "T-1000-DMX") && !(this.string_0 == "DMX V3") && !(this.string_0 == "DMX-TXV3") && !(this.string_0 == "NKC-073") && !(this.string_0 == "@G@") && !(this.string_0 == "1100-DMX"))
                                                                                                                                                    {
                                                                                                                                                        if (!(this.string_0 == "T-8000B-WS") && !(this.string_0 == "2200-IIC8"))
                                                                                                                                                        {
                                                                                                                                                            if (!(this.string_0 == "T-8000B-TM") && !(this.string_0 == "2200-RZ8") && !(this.string_0 == "TM-TXV2") && !(this.string_0 == "MEGA-V2"))
                                                                                                                                                            {
                                                                                                                                                                if (!(this.string_0 == "T-8000B-SM16715") && !(this.string_0 == "SM16715 V1B"))
                                                                                                                                                                {
                                                                                                                                                                    if (!(this.string_0 == "T-8000B-SM16716") && !(this.string_0 == "SM16716 V1B"))
                                                                                                                                                                    {
                                                                                                                                                                        if (this.string_0 == "T-8000B-TM19")
                                                                                                                                                                        {
                                                                                                                                                                            c.ledControllerType = 82;
                                                                                                                                                                            c.byte_20 = (byte)5;
                                                                                                                                                                        }
                                                                                                                                                                        else if (this.string_0 == "T-8000B-DS189")
                                                                                                                                                                        {
                                                                                                                                                                            c.ledControllerType = 82;
                                                                                                                                                                            c.byte_20 = (byte)6;
                                                                                                                                                                        }
                                                                                                                                                                        else if (this.string_0 == "T-8000B-UCS-1024")
                                                                                                                                                                        {
                                                                                                                                                                            c.ledControllerType = 82;
                                                                                                                                                                            c.byte_20 = (byte)7;
                                                                                                                                                                        }
                                                                                                                                                                        else if (this.string_0 == "T-8000B-1677")
                                                                                                                                                                        {
                                                                                                                                                                            c.ledControllerType = 82;
                                                                                                                                                                            c.byte_20 = (byte)10;
                                                                                                                                                                        }
                                                                                                                                                                        else if (this.string_0 == "T-8000B-TM1829")
                                                                                                                                                                        {
                                                                                                                                                                            c.ledControllerType = 82;
                                                                                                                                                                            c.byte_20 = (byte)11;
                                                                                                                                                                        }
                                                                                                                                                                        else if (this.string_0 == "T-8000B-SM16726")
                                                                                                                                                                        {
                                                                                                                                                                            c.ledControllerType = 82;
                                                                                                                                                                            c.byte_20 = (byte)12;
                                                                                                                                                                        }
                                                                                                                                                                        else if (this.string_0 == "T-8000B-1882")
                                                                                                                                                                        {
                                                                                                                                                                            c.ledControllerType = 82;
                                                                                                                                                                            c.byte_20 = (byte)13;
                                                                                                                                                                        }
                                                                                                                                                                        else if (this.string_0 == "T-8000B-6812")
                                                                                                                                                                        {
                                                                                                                                                                            c.ledControllerType = 82;
                                                                                                                                                                            c.byte_20 = (byte)14;
                                                                                                                                                                        }
                                                                                                                                                                        else if (this.string_0 == "T-8000B-WS2811")
                                                                                                                                                                        {
                                                                                                                                                                            c.ledControllerType = 82;
                                                                                                                                                                            c.byte_20 = (byte)15;
                                                                                                                                                                        }
                                                                                                                                                                        else if (this.string_0 == "T-8000B-TA9909")
                                                                                                                                                                        {
                                                                                                                                                                            c.ledControllerType = 82;
                                                                                                                                                                            c.byte_20 = (byte)16;
                                                                                                                                                                        }
                                                                                                                                                                        else if (this.string_0 == "T-8000B-6021")
                                                                                                                                                                        {
                                                                                                                                                                            c.ledControllerType = 82;
                                                                                                                                                                            c.byte_20 = (byte)17;
                                                                                                                                                                        }
                                                                                                                                                                        else if (this.string_0 == "T-8000B-GW623X")
                                                                                                                                                                        {
                                                                                                                                                                            c.ledControllerType = 82;
                                                                                                                                                                            c.byte_20 = (byte)18;
                                                                                                                                                                        }
                                                                                                                                                                        else if (this.string_0 == "T-8000B-GW624X")
                                                                                                                                                                        {
                                                                                                                                                                            c.ledControllerType = 82;
                                                                                                                                                                            c.byte_20 = (byte)19;
                                                                                                                                                                        }
                                                                                                                                                                        else if (this.string_0 == "T-8000B-LPD1886")
                                                                                                                                                                        {
                                                                                                                                                                            c.ledControllerType = 82;
                                                                                                                                                                            c.byte_20 = (byte)20;
                                                                                                                                                                        }
                                                                                                                                                                        else if (this.string_0 == "T-8000B-UCS8903")
                                                                                                                                                                        {
                                                                                                                                                                            c.ledControllerType = 82;
                                                                                                                                                                            c.byte_20 = (byte)21;
                                                                                                                                                                        }
                                                                                                                                                                        else if (this.string_0 == "K-8000-ALL")
                                                                                                                                                                        {
                                                                                                                                                                            c.ledControllerType = 82;
                                                                                                                                                                            c.byte_20 = (byte)22;
                                                                                                                                                                        }
                                                                                                                                                                        else if (this.string_0 == "T-8000B-N_6803")
                                                                                                                                                                        {
                                                                                                                                                                            c.ledControllerType = 82;
                                                                                                                                                                            c.byte_20 = (byte)70;
                                                                                                                                                                        }
                                                                                                                                                                        else if (this.string_0 == "T-8000B-ADD_1")
                                                                                                                                                                        {
                                                                                                                                                                            c.ledControllerType = 82;
                                                                                                                                                                            c.byte_20 = (byte)41;
                                                                                                                                                                        }
                                                                                                                                                                        else if (this.string_0 == "T-8000B-ADD_2")
                                                                                                                                                                        {
                                                                                                                                                                            c.ledControllerType = 82;
                                                                                                                                                                            c.byte_20 = (byte)42;
                                                                                                                                                                        }
                                                                                                                                                                        else if (this.string_0 == "T-8000B-ADD_3")
                                                                                                                                                                        {
                                                                                                                                                                            c.ledControllerType = 82;
                                                                                                                                                                            c.byte_20 = (byte)43;
                                                                                                                                                                        }
                                                                                                                                                                        else if (this.string_0 == "T-8000B-ADD_4")
                                                                                                                                                                        {
                                                                                                                                                                            c.ledControllerType = 82;
                                                                                                                                                                            c.byte_20 = (byte)44;
                                                                                                                                                                        }
                                                                                                                                                                        else if (this.string_0 == "T-8000B-ADD_5")
                                                                                                                                                                        {
                                                                                                                                                                            c.ledControllerType = 82;
                                                                                                                                                                            c.byte_20 = (byte)45;
                                                                                                                                                                        }
                                                                                                                                                                        else if (this.string_0 == "T-8000B-ADD_6")
                                                                                                                                                                        {
                                                                                                                                                                            c.ledControllerType = 82;
                                                                                                                                                                            c.byte_20 = (byte)46;
                                                                                                                                                                        }
                                                                                                                                                                        else if (this.string_0 == "T-8000B-ADD_7")
                                                                                                                                                                        {
                                                                                                                                                                            c.ledControllerType = 82;
                                                                                                                                                                            c.byte_20 = (byte)47;
                                                                                                                                                                        }
                                                                                                                                                                        else if (this.string_0 == "T-8000B-ADD_8")
                                                                                                                                                                        {
                                                                                                                                                                            c.ledControllerType = 82;
                                                                                                                                                                            c.byte_20 = (byte)48;
                                                                                                                                                                        }
                                                                                                                                                                        else if (this.string_0 == "T-8000B-ADD_9")
                                                                                                                                                                        {
                                                                                                                                                                            c.ledControllerType = 82;
                                                                                                                                                                            c.byte_20 = (byte)49;
                                                                                                                                                                        }
                                                                                                                                                                        else if (this.string_0 == "T-8000B-ADD_10")
                                                                                                                                                                        {
                                                                                                                                                                            c.ledControllerType = 82;
                                                                                                                                                                            c.byte_20 = (byte)50;
                                                                                                                                                                        }
                                                                                                                                                                        else if (!(this.string_0 == "T-8000B-DMX") && !(this.string_0 == "DMX V1B") && !(this.string_0 == "NKC-072") && !(this.string_0 == "MEGA-DMXV1B") && !(this.string_0 == "2200-DMX") && !(this.string_0 == "DMX-TXV2") && !(this.string_0 == "NKC-071") && !(this.string_0 == "MEGA-DMXV2"))
                                                                                                                                                                        {
                                                                                                                                                                            if (!(this.string_0 == "T-8000B-6803") && !(this.string_0 == "2200-D705"))
                                                                                                                                                                            {
                                                                                                                                                                                if (!(this.string_0 == "T-8000B-TLS") && !(this.string_0 == "2200-M8") && !(this.string_0 == "TLS V1B") && !(this.string_0 == "TLS V1B-M") && !(this.string_0 == "Curtain V1B"))
                                                                                                                                                                                {
                                                                                                                                                                                    if (this.string_0 == "T-8000B-P9813")
                                                                                                                                                                                    {
                                                                                                                                                                                        c.ledControllerType = 85;
                                                                                                                                                                                        c.byte_20 = (byte)1;
                                                                                                                                                                                    }
                                                                                                                                                                                    else if (this.string_0 == "T-8000B-0815")
                                                                                                                                                                                    {
                                                                                                                                                                                        c.ledControllerType = 85;
                                                                                                                                                                                        c.byte_20 = (byte)2;
                                                                                                                                                                                    }
                                                                                                                                                                                    else if (this.string_0 == "T-8000B-0825")
                                                                                                                                                                                    {
                                                                                                                                                                                        c.ledControllerType = 85;
                                                                                                                                                                                        c.byte_20 = (byte)5;
                                                                                                                                                                                    }
                                                                                                                                                                                    else if (this.string_0 == "T-8000B-0901")
                                                                                                                                                                                    {
                                                                                                                                                                                        c.ledControllerType = 85;
                                                                                                                                                                                        c.byte_20 = (byte)6;
                                                                                                                                                                                    }
                                                                                                                                                                                    else if (this.string_0 == "T-8000B-APA102")
                                                                                                                                                                                    {
                                                                                                                                                                                        c.ledControllerType = 85;
                                                                                                                                                                                        c.byte_20 = (byte)8;
                                                                                                                                                                                    }
                                                                                                                                                                                    else if (this.string_0 == "T-8000B-6813")
                                                                                                                                                                                    {
                                                                                                                                                                                        c.ledControllerType = 85;
                                                                                                                                                                                        c.byte_20 = (byte)9;
                                                                                                                                                                                    }
                                                                                                                                                                                    else if (this.string_0 == "T-8000B-8806")
                                                                                                                                                                                        c.ledControllerType = 86;
                                                                                                                                                                                }
                                                                                                                                                                                else
                                                                                                                                                                                    c.ledControllerType = 85;
                                                                                                                                                                            }
                                                                                                                                                                            else
                                                                                                                                                                                c.ledControllerType = 84;
                                                                                                                                                                        }
                                                                                                                                                                        else
                                                                                                                                                                            c.ledControllerType = 83;
                                                                                                                                                                    }
                                                                                                                                                                    else
                                                                                                                                                                    {
                                                                                                                                                                        c.ledControllerType = 82;
                                                                                                                                                                        c.byte_20 = (byte)4;
                                                                                                                                                                    }
                                                                                                                                                                }
                                                                                                                                                                else
                                                                                                                                                                {
                                                                                                                                                                    c.ledControllerType = 82;
                                                                                                                                                                    c.byte_20 = (byte)3;
                                                                                                                                                                }
                                                                                                                                                            }
                                                                                                                                                            else
                                                                                                                                                                c.ledControllerType = 82;
                                                                                                                                                        }
                                                                                                                                                        else
                                                                                                                                                            c.ledControllerType = 81;
                                                                                                                                                    }
                                                                                                                                                    else
                                                                                                                                                        c.ledControllerType = 16;
                                                                                                                                                }
                                                                                                                                                else
                                                                                                                                                    c.ledControllerType = 49;
                                                                                                                                            }
                                                                                                                                            else
                                                                                                                                                c.ledControllerType = 2;
                                                                                                                                        }
                                                                                                                                        else
                                                                                                                                            c.ledControllerType = 110;
                                                                                                                                    }
                                                                                                                                    else
                                                                                                                                    {
                                                                                                                                        c.ledControllerType = 32;
                                                                                                                                        c.byte_20 = (byte)4;
                                                                                                                                    }
                                                                                                                                }
                                                                                                                                else
                                                                                                                                {
                                                                                                                                    c.ledControllerType = 32;
                                                                                                                                    c.byte_20 = (byte)3;
                                                                                                                                }
                                                                                                                            }
                                                                                                                            else
                                                                                                                                c.ledControllerType = 32;
                                                                                                                        }
                                                                                                                        else
                                                                                                                        {
                                                                                                                            c.ledControllerType = 50;
                                                                                                                            c.byte_20 = (byte)4;
                                                                                                                        }
                                                                                                                    }
                                                                                                                    else
                                                                                                                    {
                                                                                                                        c.ledControllerType = 50;
                                                                                                                        c.byte_20 = (byte)3;
                                                                                                                    }
                                                                                                                }
                                                                                                                else
                                                                                                                    c.ledControllerType = 50;
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                c.byte_20 = (byte)4;
                                                                                                                c.ledControllerType = 130;
                                                                                                                c.bool_2 = true;
                                                                                                            }
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            c.byte_20 = (byte)3;
                                                                                                            c.ledControllerType = 130;
                                                                                                            c.bool_2 = true;
                                                                                                        }
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        c.ledControllerType = 130;
                                                                                                        c.bool_2 = true;
                                                                                                    }
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    c.byte_20 = (byte)4;
                                                                                                    c.ledControllerType = 130;
                                                                                                }
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                c.byte_20 = (byte)3;
                                                                                                c.ledControllerType = 130;
                                                                                            }
                                                                                        }
                                                                                        else
                                                                                            c.ledControllerType = 130;
                                                                                    }
                                                                                    else
                                                                                        c.ledControllerType = 48;
                                                                                }
                                                                                else
                                                                                    c.ledControllerType = 47;
                                                                            }
                                                                            else
                                                                                c.ledControllerType = 46;
                                                                        }
                                                                        else
                                                                        {
                                                                            c.ledControllerType = 140;
                                                                            c.byte_20 = (byte)3;
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        c.ledControllerType = 140;
                                                                        c.byte_20 = (byte)0;
                                                                    }
                                                                }
                                                                else
                                                                    c.ledControllerType = 41;
                                                            }
                                                            else
                                                                c.ledControllerType = 54;
                                                        }
                                                        else
                                                            c.ledControllerType = 53;
                                                    }
                                                    else
                                                        c.ledControllerType = 52;
                                                }
                                                else
                                                    c.ledControllerType = 13;
                                            }
                                            else
                                                c.ledControllerType = 12;
                                        }
                                        else
                                            c.ledControllerType = 120;
                                    }
                                    else
                                    {
                                        c.ledControllerType = 102;
                                        c.bool_2 = true;
                                    }
                                }
                                else
                                    c.ledControllerType = 102;
              }
              else
                c.ledControllerType = 101;
            }
            else
            {
              c.ledControllerType = 9;
              c.byte_20 = (byte) 0;
            }
          }
          else
            c.ledControllerType = 150;
        }
        else
          c.ledControllerType = 8;
      }
      else
        c.ledControllerType = 7;
    }
    else
      c.ledControllerType = 3;
    this.groupBox_1.Enabled = false;
    c.byte_1 = (byte) 0;
        if (this.string_0 == "T-100K-0825" || this.string_0 == "T-8000B-0825" || this.string_0 == "T-4000-0825" || this.string_0 == "T-1000-0825" || this.string_0 == "T-100K-0901" || this.string_0 == "T-8000B-0901" || this.string_0 == "T-4000-0901" || this.string_0 == "T-1000-0901")
            c.byte_1 = (byte)2;
        if (this.string_0 == "T-100K-TM19" || this.string_0 == "T-100K-B-TM19" || this.string_0 == "T-8000B-TM19" || this.string_0 == "T-4000-TM19" || this.string_0 == "T-1000-TM19")
        {
            c.byte_1 = (byte)1;
            this.groupBox_1.Enabled = true;
        }
        if (this.string_0 == "T-100K-TM1829" || this.string_0 == "T-100K-B-TM1829" || this.string_0 == "T-8000B-TM1829" || this.string_0 == "T-4000-TM1829" || this.string_0 == "T-1000-TM1829" || this.string_0 == "T-2000-TM1829")
        {
            c.byte_1 = (byte)1;
            this.groupBox_1.Enabled = true;
        }
        if (this.string_0 == "T-100K-B-TA9909" || this.string_0 == "T-1000-TA9909" || this.string_0 == "T-2000-TA9909" || this.string_0 == "T-8000B-TA9909")
        {
            c.byte_1 = (byte)1;
            this.groupBox_1.Enabled = true;
        }
        if (this.string_0 == "T-100K-B-1882" || this.string_0 == "T-8000B-1882" || this.string_0 == "T-1000-1882")
            this.groupBox_1.Enabled = true;

        if (this.string_0 == "T-100K-B-6812" || this.string_0 == "T-8000B-6812" || this.string_0 == "T-1000-6812")
            this.groupBox_1.Enabled = true;
        if (this.string_0 == "T-100K-1677" || this.string_0 == "T-100K-B-1677" || this.string_0 == "T-8000B-1677" || this.string_0 == "T-4000-1677" || this.string_0 == "T-1000-1677" || this.string_0 == "T-2000-16711")
        {
            c.byte_1 = (byte)3;
            this.groupBox_1.Enabled = true;
            c.byte_3 = (byte)21;
            c.byte_4 = (byte)68;
            c.byte_5 = (byte)0;
        }
        if (this.string_0 == "T-100K-SM16726" || this.string_0 == "T-100K-B-SM16726" || this.string_0 == "T-8000B-SM16726" || this.string_0 == "T-4000-SM16726" || this.string_0 == "T-1000-SM16726" || this.string_0 == "T-2000-SM16726")
        {
            c.byte_1 = (byte)4;
            c.byte_3 = (byte)36;
            c.byte_4 = (byte)51;
            c.byte_5 = (byte)0;
        }
        if (this.string_0 == "T-2000-GW623X" || this.string_0 == "T-2000-GW624X" || this.string_0 == "T-8000B-GW623X" || this.string_0 == "T-8000B-GW624X" || this.string_0 == "T-100K-B-GW623X" || this.string_0 == "T-100K-B-GW624X" || this.string_0 == "T-1000-GW623X" || this.string_0 == "T-1000-GW624X")

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
            this.radioButton_3.Text = "Slow speed";
            this.radioButton_2.Text = "High speed";

    }
    else
    {
      this.radioButton_3.Text = Module.a("﷽ꨤ", int_0);
      this.radioButton_2.Text = Module.a("欨ꨤ", int_0);
    }
    this.radioButton_5.Checked = true;
    this.groupBox_2.Enabled = false;
    if (c.ledControllerType == 140 || c.ledControllerType == 46 || c.ledControllerType == 47 || c.ledControllerType == 48 || c.ledControllerType == 85)
      this.groupBox_2.Enabled = true;
    if (c.ledControllerType == 2 || c.ledControllerType == 49 || c.ledControllerType == 16 || c.ledControllerType == 110 || c.ledControllerType == 83)
      this.groupBox_2.Enabled = true;
    if (c.ledControllerType == 31 || c.ledControllerType == 50 || c.ledControllerType == 32 || c.ledControllerType == 130 || c.ledControllerType == 82)
      this.groupBox_2.Enabled = true;
    this.groupBox_3.Enabled = false;
    if (c.byte_20 == (byte) 0 || c.byte_20 == (byte) 15 || c.byte_20 > (byte) 60)
    {
      switch (c.ledControllerType)
      {
        case 12:
        case 13:
        case 41:
        case 81:
        case 120:
          this.groupBox_1.Enabled = true;
          this.radioButton_3.Text = "WS2801";
          this.radioButton_2.Text = "WS2803";
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
          this.radioButton_3.Text = "TLS3001";
          this.radioButton_2.Text = "TLS3008";

           break;
        default:
          this.groupBox_1.Enabled = false;
          break;
      }
    }
    if (c.byte_20 == (byte) 3 && (c.ledControllerType == 31 || c.ledControllerType == 50 || c.ledControllerType == 32 || c.ledControllerType == 130 || c.ledControllerType == 82))
      this.groupBox_1.Enabled = true;
    if (c.ledControllerType != 2 && c.ledControllerType != 49 && c.ledControllerType != 16 && c.ledControllerType != 110 && c.ledControllerType != 83)
    {
      if (c.ledControllerType == 12 || c.ledControllerType == 31 || c.ledControllerType == 50 || c.ledControllerType == 81 || c.ledControllerType == 86 || c.ledControllerType == 82 || c.ledControllerType == 85 || c.ledControllerType == 41 || c.ledControllerType == 46 || c.ledControllerType == 48 || c.ledControllerType == 53 || c.ledControllerType == 54)
      {
        if (c.useEnglishLanguage)
        {
            this.radioButton_1.Text = "512 lights per Port";
            this.radioButton_0.Text = "1024 lights per Port";
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
        this.radioButton_1.Text = "Standard DMX512";
        this.radioButton_0.Text = "Standard DMX512";
    }
    else
    {
      this.radioButton_1.Text = Module.a("듚珥\uF3B6\uF4B8\uE3BA袼躾\uF3C0貑歏", int_0);
      this.radioButton_0.Text = Module.a("듚珥\uF3B6\uF4B8\uE3BA袼躾\uF3C0貑歏", int_0);
    }
    if (c.ledControllerType == 12 || c.ledControllerType == 41 || c.ledControllerType == 13 || c.ledControllerType == 120 || c.ledControllerType == 81)
    {
      if (c.useEnglishLanguage)
      {
        this.groupBox_3.Text = "Data adjustment";
        this.radioButton_6.Text = "Each six-point reverse";
        this.radioButton_8.Text = "Each four-point reverse";
        this.radioButton_7.Text = "Normal mode";

        }
       else
      {
        this.groupBox_3.Text = Module.a("쏗\uDBD7됺췝", int_0);
        this.radioButton_6.Text = Module.a("糙\uD8E5ໆ瓫ꫮ", int_0);
        this.radioButton_8.Text = Module.a("糙滢ໆ瓫ꫮ", int_0);
        this.radioButton_7.Text = Module.a("탙跪雜뛧", int_0);
      }
    }
        LogData.LogInfo($"GetVerticalPixels End string_0: {string_0} c.ledControllerType: {c.ledControllerType}");

        if (c.ledControllerType != 2 && c.ledControllerType != 49 && c.ledControllerType != 16 && c.ledControllerType != 110 && c.ledControllerType != 83)
      return;
    this.groupBox_3.Enabled = true;
    if (c.useEnglishLanguage)
    {
        this.groupBox_3.Text = "DMX Protocol";
        this.radioButton_6.Text = "Standard DMX protocol (250Kbps)";
        this.radioButton_8.Text = "Standard DMX plus delay 8us";
        this.radioButton_7.Text = "500Kbps Frequency";
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
  public string method_2() => this.textBox_ProjectFilePath.Text;

  private void button_1_Click(object sender, EventArgs e)
  {
    SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Title = "Save as..."; // Module.a("\uEBB7\uDBB9쪻\uDBBD\uE0BFꏁ럃\uE8C5\uE6C7\uE4C9", 18);
    saveFileDialog.AddExtension = true;
        saveFileDialog.DefaultExt = "pxb"; // Module.a("좷승\uDEBB", 18);
        saveFileDialog.Filter = "Project File(*.pxb)|*.pxb|All File(*.*)|*.*"; //Module.a("\uE8B7좹펻풽ꖿꇁ냃\uE6C5軇ꏉꃋꯍ\uF8CF\uF8D1䀘ꛕꃗ룙\uF5DBꋝ쫟쳡铣黥諧雩귫苭鳯틱닳\u9FF5铷\u9FF9퓻퓽\u2EFF⠁ⴃ稅∇␉☋", 18);
    if (saveFileDialog.ShowDialog() != DialogResult.OK)
      return;
    this.textBox_ProjectFilePath.Text = saveFileDialog.FileName;
  }

  private void OkButtonClick(object sender, EventArgs e)
  {
    int int_0 = 3;
    if (this.comboBox_0.SelectedIndex == -1)
      this.comboBox_0.SelectedIndex = 19;
    if (this.comboBox_RGBChannel.SelectedIndex == -1)
      this.comboBox_RGBChannel.SelectedIndex = 0;
    c.smethod_1(this.comboBox_0.SelectedIndex + 1);
    c.int_81 = this.comboBox_RGBChannel.SelectedIndex;
    c.byte_19 = (byte) 1;
    c.bool_14 = false;
    if (this.string_0 == "T-100K-TM19"/*Module.a("ﶨ蚪鲬龮膰\uF8B2颴\uE3B6\uF4B8誺蒼", dataEntryPoint)*/ ||
            this.string_0 == "T-100K-B-TM19" /*Module.a("ﶨ蚪鲬龮膰\uF8B2颴\uF5B6钸\uEFBA\uF0BC躾\uF8C0", dataEntryPoint)*/ ||
            this.string_0 == "T-8000B-TM19" /*Module.a("ﶨ蚪閬龮膰莲\uF7B4骶\uEDB8\uF6BA貼蚾", dataEntryPoint)*/ ||
            this.string_0 == "T-4000-TM19" /*Module.a("ﶨ蚪馬龮膰莲颴\uE3B6\uF4B8誺蒼", dataEntryPoint)*/ ||
            this.string_0 == "T-1000-TM19" /*Module.a("ﶨ蚪鲬龮膰莲颴\uE3B6\uF4B8誺蒼", dataEntryPoint)*/)
      c.byte_19 = !this.radioButton_3.Checked ? (byte) 170 : (byte) 85;
    if (this.string_0 == "T-100K-TM1829" /*Module.a("ﶨ蚪鲬龮膰\uF8B2颴\uE3B6\uF4B8誺薼趾\uF8C0", dataEntryPoint)*/ ||
            this.string_0 == "T-100K-B-TM1829" /*Module.a("ﶨ蚪鲬龮膰\uF8B2颴\uF5B6钸\uEFBA\uF0BC躾燎\uF1C2ﳄ", dataEntryPoint)*/ || 
            this.string_0 == "T-8000B-TM1829" /*Module.a("ﶨ蚪閬龮膰莲\uF7B4骶\uEDB8\uF6BA貼螾\uF3C0輸", dataEntryPoint)*/ || 
            this.string_0 == "T-4000-TM1829" /*Module.a("ﶨ蚪馬龮膰莲颴\uE3B6\uF4B8誺薼趾\uF8C0", dataEntryPoint)*/ || 
            this.string_0 == "T-1000-TM1829"/* Module.a("ﶨ蚪鲬龮膰莲颴\uE3B6\uF4B8誺薼趾\uF8C0", dataEntryPoint)*/)
      c.byte_19 = !this.radioButton_3.Checked ? (byte) 170 : (byte) 85;
    if (this.string_0 == "T-100K-B-1882" /*Module.a("ﶨ蚪鲬龮膰\uF8B2颴\uF5B6钸誺薼螾\uF3C0", dataEntryPoint)*/ ||
            this.string_0 == "T-8000B-1882" /*Module.a("ﶨ蚪閬龮膰莲\uF7B4骶袸莺薼趾", dataEntryPoint)*/ ||
            this.string_0 == Module.a("ﶨ蚪鲬龮膰莲颴蚶膸莺込", int_0))
      c.byte_19 = !this.radioButton_3.Checked ? (byte) 170 : (byte) 85;
    if (this.string_0 == "T-100K-B-6812" /*Module.a("ﶨ蚪鲬龮膰\uF8B2颴\uF5B6钸趺薼躾\uF3C0", dataEntryPoint)*/ ||
            this.string_0 == "T-8000B-6812" /*Module.a("ﶨ蚪閬龮膰莲\uF7B4骶辸莺貼趾", dataEntryPoint)*/ || 
            this.string_0 == Module.a("ﶨ蚪鲬龮膰莲颴膶膸誺込", int_0))
      c.byte_19 = !this.radioButton_3.Checked ? (byte) 170 : (byte) 85;
    if (this.string_0 == "T-100K-1677" /*Module.a("ﶨ蚪鲬龮膰\uF8B2颴蚶辸貺誼", dataEntryPoint)*/ ||
            this.string_0 == "T-100K-B-1677" /*Module.a("ﶨ蚪鲬龮膰\uF8B2颴\uF5B6钸誺讼袾\uF6C0", dataEntryPoint)*/ ||
            this.string_0 == "T-8000B-1677" /*Module.a("ﶨ蚪閬龮膰莲\uF7B4骶袸趺誼袾", dataEntryPoint)*/ ||
            this.string_0 == Module.a("ﶨ蚪馬龮膰莲颴蚶辸貺誼", int_0) || 
            this.string_0 == Module.a("ﶨ蚪鲬龮膰莲颴蚶辸貺誼", int_0))
      c.byte_19 = !this.radioButton_3.Checked ? (byte) 170 : (byte) 85;
    if (c.byte_20 == (byte) 0 || c.byte_20 == (byte) 15 || c.byte_20 > (byte) 60)
    {
      switch (c.ledControllerType)
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
    if (c.byte_20 == (byte) 3 && (c.ledControllerType == 31 || c.ledControllerType == 50 || c.ledControllerType == 32 || c.ledControllerType == 130 || c.ledControllerType == 82))
      c.byte_19 = !this.radioButton_3.Checked ? (byte) 170 : (byte) 85;
    c.bool_18 = false;
    if (c.ledControllerType == 140 || c.ledControllerType == 46 || c.ledControllerType == 47 || c.ledControllerType == 48 || c.ledControllerType == 85)
    {
      c.bool_18 = !this.radioButton_5.Checked;
      c.bool_17 = !this.radioButton_3.Checked;
    }
    if (c.ledControllerType == 2 || c.ledControllerType == 49 || c.ledControllerType == 16 || c.ledControllerType == 110 || c.ledControllerType == 83)
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
    if (c.ledControllerType == 31 || c.ledControllerType == 50 || c.ledControllerType == 32 || c.ledControllerType == 130 || c.ledControllerType == 82)
      c.bool_18 = !this.radioButton_5.Checked;
    string path = c.settingsPath + "\\ttype_ss10.txt" /*Module.a("\uF5A8\uDFAA\uD9AC횮솰횲\uEAB4쒶쪸誺趼醾뗀믂뇄", dataEntryPoint)*/;
        LogData.LogInfo($"path : {path} string2: {c.settingsPath}");
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
        if (c.ledControllerType != 2 && c.ledControllerType != 49 && c.ledControllerType != 16 && c.ledControllerType != 110 && c.ledControllerType != 83)
        {
            if (c.ledControllerType == 12 || c.ledControllerType == 31 || c.ledControllerType == 50 || c.ledControllerType == 81 || c.ledControllerType == 86 || c.ledControllerType == 82 || c.ledControllerType == 85 || c.ledControllerType == 41 || c.ledControllerType == 46 || c.ledControllerType == 48 || c.ledControllerType == 53 || c.ledControllerType == 54)
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
        if (c.ledControllerType != 101 && c.ledControllerType != 103 && c.ledControllerType != 14 && c.ledControllerType != 15)
            this.groupBox_4.Enabled = false;
        else
            this.groupBox_4.Enabled = true;
        if (c.ledControllerType == 101 || c.ledControllerType == 103)
        {
            if (this.radioButton_1.Checked)
                c.ledControllerType = 101;
            else if (this.radioButton_0.Checked)
                c.ledControllerType = 103;
        }
        if (c.ledControllerType == 14 || c.ledControllerType == 15)
        {
            if (this.radioButton_1.Checked)
                c.ledControllerType = 14;
            else if (this.radioButton_0.Checked)
                c.ledControllerType = 15;
        }
        this.textBox_1.ReadOnly = true;
        if (c.ledControllerType == 3)
        {
            this.label_5.Text = "ZQL9712,74HC595,MBI5026";
            this.label_6.Text = "8";
            c.int_75 = 8;
            int num2 = c.int_8 + c.int_9 + c.int_10 + 3;
            this.textBox_1.Text = ((768 - (int)c.byte_0) / num2).ToString();
            this.textBox_1.ReadOnly = true;
            c.int_74 = 256;
            this.groupBox_4.Enabled = true;
            this.groupBox_0.Visible = true;
        }
        if (c.ledControllerType == 14)
        {
            this.label_5.Text = "ZQL9712,74HC595,MBI5026";
            this.label_6.Text = "1";
            int num3 = c.int_8 + c.int_9 + c.int_10 + 3;
            this.textBox_1.Text = ((768 - (int)c.byte_0) / num3).ToString();
            this.textBox_1.ReadOnly = true;
            c.int_74 = 256;
            this.groupBox_4.Enabled = true;
            this.groupBox_0.Visible = true;
        }
        if (c.ledControllerType == 7)
        {
            this.label_5.Text = "LPD6803,D705";
            this.label_6.Text = "4";
            c.int_75 = 8;
            this.textBox_1.Text = "1024";
            c.int_74 = 1024;
        }
        if (c.ledControllerType == 8)
        {
            this.label_5.Text = "LPD6803,D705";
            this.label_6.Text = "8";
            c.int_75 = 8;
            this.textBox_1.Text = "1024";
            c.int_74 = 1024;
        }
        if (c.ledControllerType == 9)
        {
            this.label_5.Text = "LPD6803,D705";
            this.label_6.Text = "1";
            this.textBox_1.Text = "2048";
            c.int_74 = 2048;
            this.groupBox_0.Visible = false;
        }
        else if (c.ledControllerType == 101)
        {
            this.label_5.Text = "ZQL9712,74HC595,MBI5026";
            this.label_6.Text = "8";
            c.int_75 = 8;
            int num4 = c.int_8 + c.int_9 + c.int_10 + 3;
            this.textBox_1.Text = ((768 - (int)c.byte_0) / num4).ToString();
            this.textBox_1.ReadOnly = true;
            c.int_74 = 256;
            this.groupBox_4.Enabled = true;
            this.groupBox_0.Visible = true;
        }
        else if (c.ledControllerType == 103)
        {
            this.label_5.Text = "ZQL9712,74HC595,MBI5026";
            this.label_6.Text = "8";
            c.int_75 = 8;
            int num5 = c.int_8 + c.int_9 + c.int_10 + 3;
            this.textBox_1.Text = ((1536 - (int)c.byte_0) / num5).ToString();
            this.textBox_1.ReadOnly = true;
            c.int_74 = 512;
            this.groupBox_4.Enabled = true;
            this.groupBox_0.Visible = true;
        }
        else if (c.ledControllerType == 15)
        {
            this.label_5.Text = "ZQL9712,74HC595,MBI5026";
            this.label_6.Text = "1";
            c.int_75 = 8;
            int num6 = c.int_8 + c.int_9 + c.int_10 + 3;
            this.textBox_1.Text = ((1536 - (int)c.byte_0) / num6).ToString();
            this.textBox_1.ReadOnly = true;
            c.int_74 = 512;
            this.groupBox_4.Enabled = true;
            this.groupBox_0.Visible = true;
        }
        else if (c.ledControllerType == 102)
        {
            this.label_5.Text = "LPD6803,D705";
            this.label_6.Text = "8";
            c.int_75 = 8;
            this.textBox_1.Text = c.int_4.ToString();
            this.textBox_1.ReadOnly = true;
            c.int_74 = c.int_4;
            this.groupBox_0.Visible = false;
        }
        else if (c.ledControllerType == 84)
        {
            this.label_5.Text = "LPD6803,D705";
            this.label_6.Text = "8";
            c.int_75 = 8;
            this.textBox_1.Text = c.int_4.ToString();
            this.textBox_1.ReadOnly = true;
            c.int_74 = c.int_4;
            this.groupBox_0.Visible = false;
        }
        else if (c.ledControllerType == 201)
        {
            this.label_5.Text = "Full color bar screen control system, supports 256 * 32 pixels！";
          this.label_6.Text = "16";
            c.int_75 = 16;
            this.textBox_1.Text = "256";
            this.textBox_1.ReadOnly = true;
            c.int_74 = 256;
            this.groupBox_0.Visible = false;
        }
        else if (c.ledControllerType == 120)
        {
            this.label_5.Text = "WS2801,WS2803！";
            this.label_6.Text = "8";
            c.int_75 = 8;
            this.textBox_1.Text = "512";
            this.textBox_1.ReadOnly = true;
            c.int_74 = 512;
            this.groupBox_0.Visible = false;
        }
        else if (c.ledControllerType == 150)
        {
            this.label_5.Text = "LPD8806,LPD8809！";
            this.label_6.Text = "8";
            c.int_75 = 8;
            this.textBox_1.Text = "512";
            this.textBox_1.ReadOnly = true;
            c.int_74 = 512;
            this.groupBox_0.Visible = false;
        }
        else if (c.ledControllerType == 140)
        {
            this.label_5.Text = "TLS3001,TLS3008！";
            this.label_6.Text = "8";
            c.int_75 = 8;
            this.textBox_1.Text = "512";
            this.textBox_1.ReadOnly = true;
            c.int_74 = 512;
            this.groupBox_0.Visible = false;
        }
        else if (c.ledControllerType == 12)
        {
            this.label_5.Text = "WS2801,WS2803！";
            this.label_6.Text = "8";
            c.int_75 = 8;
            this.textBox_1.Text = num1.ToString();
            this.textBox_1.ReadOnly = true;
            c.int_74 = num1;
            this.groupBox_0.Visible = false;
            this.groupBox_4.Enabled = true;
        }
        else if (c.ledControllerType == 54)
        {
            this.label_5.Text = "LPD8806,LPD8809！";
            this.label_6.Text = "8";
            c.int_75 = 8;
            this.textBox_1.Text = num1.ToString();
            this.textBox_1.ReadOnly = true;
            c.int_74 = num1;
            this.groupBox_0.Visible = false;
            this.groupBox_4.Enabled = true;
        }
        else if (c.ledControllerType == 46)
        {
            this.label_5.Text = "TLS3001,TLS3008！";
            this.label_6.Text = "8";
            c.int_75 = 8;
            this.textBox_1.Text = num1.ToString();
            this.textBox_1.ReadOnly = true;
            c.int_74 = num1;
            this.groupBox_0.Visible = false;
            this.groupBox_4.Enabled = true;
        }
        else if (c.ledControllerType == 48)
        {
            this.label_5.Text = "TLS3001,TLS3008！";
            this.label_6.Text = "4";
            c.int_75 = 8;
            this.textBox_1.Text = num1.ToString();
            this.textBox_1.ReadOnly = true;
            c.int_74 = num1;
            this.groupBox_0.Visible = false;
            this.groupBox_4.Enabled = true;
        }
        else if (c.ledControllerType == 41)
        {
            this.label_5.Text = "WS2801,WS2803！";
            this.label_6.Text = "4";
            c.int_75 = 8;
            this.textBox_1.Text = num1.ToString();
            this.textBox_1.ReadOnly = true;
            c.int_74 = num1;
            this.groupBox_0.Visible = false;
            this.groupBox_4.Enabled = true;
        }
        else if (c.ledControllerType == 53)
        {
            this.label_5.Text = "LPD8806,LPD8809！";
            this.label_6.Text = "4";
            c.int_75 = 8;
            this.textBox_1.Text = num1.ToString();
            this.textBox_1.ReadOnly = true;
            c.int_74 = num1;
            this.groupBox_0.Visible = false;
            this.groupBox_4.Enabled = true;
        }
        else if (c.ledControllerType == 81)
        {
            this.label_5.Text = "WS2801,WS2803！";
            this.label_6.Text = "8";
            c.int_75 = 8;
            this.textBox_1.Text = num1.ToString();
            this.textBox_1.ReadOnly = true;
            c.int_74 = num1;
            this.groupBox_0.Visible = false;
            this.groupBox_4.Enabled = true;
        }
        else if (c.ledControllerType == 86)
        {
            this.label_5.Text = "LPD8806,LPD8809！";
            this.label_6.Text = "8";
            c.int_75 = 8;
            this.textBox_1.Text = num1.ToString();
            this.textBox_1.ReadOnly = true;
            c.int_74 = num1;
            this.groupBox_0.Visible = false;
            this.groupBox_4.Enabled = true;
        }
        else if (c.ledControllerType == 85)
        {
            this.label_5.Text = "TLS3001,TLS3008！";
            this.label_6.Text = "8";
            c.int_75 = 8;
            this.textBox_1.Text = num1.ToString();
            this.textBox_1.ReadOnly = true;
            c.int_74 = num1;
            this.groupBox_0.Visible = false;
            this.groupBox_4.Enabled = true;
        }
        else if (c.ledControllerType == 13)
        {
            this.label_5.Text = "WS2801,WS2803！";
            this.label_6.Text = "1";
            this.textBox_1.Text = "2048";
            this.textBox_1.ReadOnly = true;
            c.int_74 = 2048;
            this.groupBox_0.Visible = false;
        }
        else if (c.ledControllerType == 47)
        {
            this.label_5.Text = "TLS3001,TLS3008！";
            this.label_6.Text = "1";
            this.textBox_1.Text = "2048";
            this.textBox_1.ReadOnly = true;
            c.int_74 = 2048;
            this.groupBox_0.Visible = false;
        }
        else if (c.ledControllerType == 130)
        {
            this.label_5.Text = "TM1803,TM1804！";
            this.label_6.Text = "8";
            c.int_75 = 8;
            this.textBox_1.Text = "512";
            this.textBox_1.ReadOnly = true;
            c.int_74 = 512;
            this.groupBox_0.Visible = false;
        }
        else if (c.ledControllerType == 180)
        {
            this.label_5.Text = "T-500K-ALL！";
            this.label_6.Text = "8";
            c.int_75 = 8;
            this.textBox_1.Text = "768";
            this.textBox_1.ReadOnly = true;
            c.int_74 = 768;
            this.groupBox_0.Visible = false;
        }
        else if (c.ledControllerType == 31)
        {
            this.label_5.Text = "TM1803,TM1804！";
            this.label_6.Text = "8";
            c.int_75 = 8;
            this.textBox_1.Text = num1.ToString();
            this.textBox_1.ReadOnly = true;
            c.int_74 = num1;
            this.groupBox_0.Visible = false;
            this.groupBox_4.Enabled = true;
        }
        else if (c.ledControllerType == 50)
        {
            this.label_5.Text = "TM1803,TM1804！";
            this.label_6.Text = "4";
            c.int_75 = 8;
            this.textBox_1.Text = num1.ToString();
            this.textBox_1.ReadOnly = true;
            c.int_74 = num1;
            this.groupBox_0.Visible = false;
            this.groupBox_4.Enabled = true;
        }
        else if (c.ledControllerType == 82)
        {
            this.label_5.Text = "TM1803,TM1804！";
            this.label_6.Text = "8";
            c.int_75 = 8;
            this.textBox_1.Text = num1.ToString();
            this.textBox_1.ReadOnly = true;
            c.int_74 = num1;
            this.groupBox_0.Visible = false;
            this.groupBox_4.Enabled = true;
        }
        else if (c.ledControllerType == 32)
        {
            this.label_5.Text = "TM1803,TM1804！";
            this.label_6.Text = "1";
            this.textBox_1.Text = "2048";
            this.textBox_1.ReadOnly = true;
            c.int_74 = 2048;
            if (c.byte_20 > (byte)60)
            {
                this.textBox_1.Text = "1024";
                this.label_6.Text = "2";
                c.int_74 = 1024;
            }
            this.groupBox_0.Visible = false;
        }
        else if (c.ledControllerType == 52)
        {
            this.label_5.Text = "LPD8806,LPD8809";
            this.label_6.Text = "1";
            this.textBox_1.Text = "2048";
            this.textBox_1.ReadOnly = true;
            c.int_74 = 2048;
            this.groupBox_0.Visible = false;
        }
        else if (c.ledControllerType == 110)
        {
            this.label_5.Text = "HX512A";
            this.label_6.Text = "8";
            c.int_75 = 8;
            this.textBox_1.Text = num1.ToString();
            this.textBox_1.ReadOnly = true;
            c.int_74 = num1;
            this.groupBox_0.Visible = false;
            this.groupBox_4.Enabled = true;
        }
        else if (c.ledControllerType == 83)
        {
            this.label_5.Text = "HX512A";
            this.label_6.Text = "8";
            c.int_75 = 8;
            this.textBox_1.Text = num1.ToString();
            this.textBox_1.ReadOnly = true;
            c.int_74 = num1;
            this.groupBox_0.Visible = false;
            this.groupBox_4.Enabled = true;
        }
        else if (c.ledControllerType == 2)
        {
            this.label_5.Text = "HX512A";
            this.label_6.Text = "8";
            c.int_75 = 8;
            this.textBox_1.Text = num1.ToString();
            this.textBox_1.ReadOnly = true;
            c.int_74 = num1;
            this.groupBox_0.Visible = false;
            this.groupBox_4.Enabled = true;
        }
        else if (c.ledControllerType == 49)
        {
            this.label_5.Text = "HX512A";
            this.label_6.Text = "4";
            c.int_75 = 8;
            this.textBox_1.Text = num1.ToString();
            this.textBox_1.ReadOnly = true;
            c.int_74 = num1;
            this.groupBox_0.Visible = false;
            this.groupBox_4.Enabled = true;
        }
        else if (c.ledControllerType == 16)
        {
            this.label_5.Text = "HX512A";
            this.label_6.Text = "1";
            this.textBox_1.Text = num1.ToString();
            this.textBox_1.ReadOnly = true;
            c.int_74 = num1;
            this.groupBox_0.Visible = false;
            this.groupBox_4.Enabled = true;
        }
        else if (c.ledControllerType == 51)
        {
            this.label_5.Text = "HX512A Monochrome";
            this.label_6.Text = "1";
            this.textBox_1.Text = "1536";
            this.textBox_1.ReadOnly = true;
            c.int_74 = 1536;
            this.groupBox_0.Visible = false;
            this.groupBox_4.Enabled = false;
        }
        else if (c.ledControllerType == 55)
        {
            this.label_5.Text = "V3-M Monochrome";
            this.label_6.Text = "1";
            this.textBox_1.Text = "1536";
            this.textBox_1.ReadOnly = true;
            c.int_74 = 1536;
            this.groupBox_0.Visible = false;
            this.groupBox_4.Enabled = false;
        }
        if (this.string_0 == "1101 V1.0" || this.string_0 == "1101 V4.0" || this.string_0 == "1101 V8.0" || this.string_0 == "1101 V8.1")
            this.label_5.Text = "1101";
        if (c.string_7 == "Curtain V5" || c.string_7 == "Curtain V3" || c.string_7 == "Curtain V2" || c.string_7 == "Curtain V1B" || c.string_7 == "TLS V5-M" || c.string_7 == "TLS V3-M" || c.string_7 == "TLS V2-M" || c.string_7 == "TLS V1B-M")
        {
            if (c.useEnglishLanguage)
                this.label_5.Text = "Support Curtain Lights";
            else
                this.label_5.Text = "支持窗帘灯";
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

  private void selectControllerButton_Click(object sender, EventArgs e)
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
