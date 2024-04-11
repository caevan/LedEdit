// Decompiled with JetBrains decompiler
// Type: ac
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

public class ac : Form
{
  private IContainer icontainer_0;
  private Button button_0;
  private TextBox textBox_0;
  private TrackBar trackBar_0;
  private ComboBox comboBox_0;
  private Label label_0;
  private Panel panel_0;
  private Label label_1;
  private Label label_2;
  private Label label_3;
  private Label label_4;
  private Label label_5;
  private Label label_6;
  private Label label_7;
  private GroupBox groupBox_0;
  private GroupBox groupBox_1;
  private TextBox textBox_1;
  private TrackBar trackBar_1;
  private Label label_8;
  private TextBox textBox_2;
  private TrackBar trackBar_2;
  private Label label_9;
  private TextBox textBox_3;
  private TrackBar trackBar_3;
  private Label label_10;
  private Label label_11;
  private TextBox textBox_4;
  private Label label_12;
  private Button button_1;
  private GroupBox groupBox_2;
  private Button button_2;
  private byte[] byte_0 = new byte[256]
  {
    (byte) 0,
    (byte) 128,
    (byte) 64,
    (byte) 192,
    (byte) 32,
    (byte) 160,
    (byte) 96,
    (byte) 224,
    (byte) 16,
    (byte) 144,
    (byte) 80,
    (byte) 208,
    (byte) 48,
    (byte) 176,
    (byte) 112,
    (byte) 240,
    (byte) 8,
    (byte) 136,
    (byte) 72,
    (byte) 200,
    (byte) 40,
    (byte) 168,
    (byte) 104,
    (byte) 232,
    (byte) 24,
    (byte) 152,
    (byte) 88,
    (byte) 216,
    (byte) 56,
    (byte) 184,
    (byte) 120,
    (byte) 248,
    (byte) 4,
    (byte) 132,
    (byte) 68,
    (byte) 196,
    (byte) 36,
    (byte) 164,
    (byte) 100,
    (byte) 228,
    (byte) 20,
    (byte) 148,
    (byte) 84,
    (byte) 212,
    (byte) 52,
    (byte) 180,
    (byte) 116,
    (byte) 244,
    (byte) 12,
    (byte) 140,
    (byte) 76,
    (byte) 204,
    (byte) 44,
    (byte) 172,
    (byte) 108,
    (byte) 236,
    (byte) 28,
    (byte) 156,
    (byte) 92,
    (byte) 220,
    (byte) 60,
    (byte) 188,
    (byte) 124,
    (byte) 252,
    (byte) 2,
    (byte) 130,
    (byte) 66,
    (byte) 194,
    (byte) 34,
    (byte) 162,
    (byte) 98,
    (byte) 226,
    (byte) 18,
    (byte) 146,
    (byte) 82,
    (byte) 210,
    (byte) 50,
    (byte) 178,
    (byte) 114,
    (byte) 242,
    (byte) 10,
    (byte) 138,
    (byte) 74,
    (byte) 202,
    (byte) 42,
    (byte) 170,
    (byte) 106,
    (byte) 234,
    (byte) 26,
    (byte) 154,
    (byte) 90,
    (byte) 218,
    (byte) 58,
    (byte) 186,
    (byte) 122,
    (byte) 250,
    (byte) 6,
    (byte) 134,
    (byte) 70,
    (byte) 198,
    (byte) 38,
    (byte) 166,
    (byte) 102,
    (byte) 230,
    (byte) 22,
    (byte) 150,
    (byte) 86,
    (byte) 214,
    (byte) 54,
    (byte) 182,
    (byte) 118,
    (byte) 246,
    (byte) 14,
    (byte) 142,
    (byte) 78,
    (byte) 206,
    (byte) 46,
    (byte) 174,
    (byte) 110,
    (byte) 238,
    (byte) 30,
    (byte) 158,
    (byte) 94,
    (byte) 222,
    (byte) 62,
    (byte) 190,
    (byte) 126,
    (byte) 254,
    (byte) 1,
    (byte) 129,
    (byte) 65,
    (byte) 193,
    (byte) 33,
    (byte) 161,
    (byte) 97,
    (byte) 225,
    (byte) 17,
    (byte) 145,
    (byte) 81,
    (byte) 209,
    (byte) 49,
    (byte) 177,
    (byte) 113,
    (byte) 241,
    (byte) 9,
    (byte) 137,
    (byte) 73,
    (byte) 201,
    (byte) 41,
    (byte) 169,
    (byte) 105,
    (byte) 233,
    (byte) 25,
    (byte) 153,
    (byte) 89,
    (byte) 217,
    (byte) 57,
    (byte) 185,
    (byte) 121,
    (byte) 249,
    (byte) 5,
    (byte) 133,
    (byte) 69,
    (byte) 197,
    (byte) 37,
    (byte) 165,
    (byte) 101,
    (byte) 229,
    (byte) 21,
    (byte) 149,
    (byte) 85,
    (byte) 213,
    (byte) 53,
    (byte) 181,
    (byte) 117,
    (byte) 245,
    (byte) 13,
    (byte) 141,
    (byte) 77,
    (byte) 205,
    (byte) 45,
    (byte) 173,
    (byte) 109,
    (byte) 237,
    (byte) 29,
    (byte) 157,
    (byte) 93,
    (byte) 221,
    (byte) 61,
    (byte) 189,
    (byte) 125,
    (byte) 253,
    (byte) 3,
    (byte) 131,
    (byte) 67,
    (byte) 195,
    (byte) 35,
    (byte) 163,
    (byte) 99,
    (byte) 227,
    (byte) 19,
    (byte) 147,
    (byte) 83,
    (byte) 211,
    (byte) 51,
    (byte) 179,
    (byte) 115,
    (byte) 243,
    (byte) 11,
    (byte) 139,
    (byte) 75,
    (byte) 203,
    (byte) 43,
    (byte) 171,
    (byte) 107,
    (byte) 235,
    (byte) 27,
    (byte) 155,
    (byte) 91,
    (byte) 219,
    (byte) 59,
    (byte) 187,
    (byte) 123,
    (byte) 251,
    (byte) 7,
    (byte) 135,
    (byte) 71,
    (byte) 199,
    (byte) 39,
    (byte) 167,
    (byte) 103,
    (byte) 231,
    (byte) 23,
    (byte) 151,
    (byte) 87,
    (byte) 215,
    (byte) 55,
    (byte) 183,
    (byte) 119,
    (byte) 247,
    (byte) 15,
    (byte) 143,
    (byte) 79,
    (byte) 207,
    (byte) 47,
    (byte) 175,
    (byte) 111,
    (byte) 239,
    (byte) 31,
    (byte) 159,
    (byte) 95,
    (byte) 223,
    (byte) 63,
    (byte) 191,
    (byte) 127,
    byte.MaxValue
  };

    //virtual void Form.Dispose(bool disposing)
    //{
    //  if (disposing && this.icontainer_0 != null)
    //    this.icontainer_0.Dispose();
    //  // ISSUE: explicit non-virtual call
    //  __nonvirtual (((Form) this).Dispose(disposing));
    //}
    protected override void Dispose(bool disposing)
    {
        if (disposing && this.icontainer_0 != null)
            this.icontainer_0.Dispose();

        base.Dispose(disposing);
    }

    private void method_0()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ac));
    this.button_0 = new Button();
    this.textBox_0 = new TextBox();
    this.trackBar_0 = new TrackBar();
    this.comboBox_0 = new ComboBox();
    this.label_0 = new Label();
    this.panel_0 = new Panel();
    this.label_1 = new Label();
    this.label_2 = new Label();
    this.label_3 = new Label();
    this.label_4 = new Label();
    this.label_5 = new Label();
    this.label_6 = new Label();
    this.label_7 = new Label();
    this.groupBox_0 = new GroupBox();
    this.textBox_1 = new TextBox();
    this.trackBar_1 = new TrackBar();
    this.label_8 = new Label();
    this.textBox_2 = new TextBox();
    this.trackBar_2 = new TrackBar();
    this.label_9 = new Label();
    this.textBox_3 = new TextBox();
    this.trackBar_3 = new TrackBar();
    this.label_10 = new Label();
    this.groupBox_1 = new GroupBox();
    this.label_11 = new Label();
    this.textBox_4 = new TextBox();
    this.label_12 = new Label();
    this.button_1 = new Button();
    this.groupBox_2 = new GroupBox();
    this.button_2 = new Button();
    this.trackBar_0.BeginInit();
    this.panel_0.SuspendLayout();
    this.groupBox_0.SuspendLayout();
    this.trackBar_1.BeginInit();
    this.trackBar_2.BeginInit();
    this.trackBar_3.BeginInit();
    this.groupBox_1.SuspendLayout();
    this.groupBox_2.SuspendLayout();
    this.SuspendLayout();
    this.button_0.AccessibleDescription = (string) null;
    this.button_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.button_0, Module.a("햶첸쾺즼킾꿀\uF2C2", 17));
    this.button_0.BackgroundImage = (Image) null;
    this.button_0.Font = (Font) null;
    this.button_0.Name = Module.a("햶첸쾺즼킾꿀\uF2C2", 17);
    this.button_0.UseVisualStyleBackColor = true;
    this.button_0.Click += new EventHandler(this.button_0_Click);
    this.textBox_0.AccessibleDescription = (string) null;
    this.textBox_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.textBox_0, Module.a("쎶\uDCB8쎺즼ﶾ껀믂\uF4C4", 17));
    this.textBox_0.BackgroundImage = (Image) null;
    this.textBox_0.Font = (Font) null;
    this.textBox_0.Name = Module.a("쎶\uDCB8쎺즼ﶾ껀믂\uF4C4", 17);
    this.textBox_0.ReadOnly = true;
    this.trackBar_0.AccessibleDescription = (string) null;
    this.trackBar_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.trackBar_0, Module.a("쎶쮸\uDABA\uDEBC풾菀ꋂ럄\uF6C6", 17));
    this.trackBar_0.BackgroundImage = (Image) null;
    this.trackBar_0.Font = (Font) null;
    this.trackBar_0.LargeChange = 2;
    this.trackBar_0.Maximum = 30;
    this.trackBar_0.Minimum = 6;
    this.trackBar_0.Name = Module.a("쎶쮸\uDABA\uDEBC풾菀ꋂ럄\uF6C6", 17);
    this.trackBar_0.SmallChange = 2;
    this.trackBar_0.TickFrequency = 2;
    this.trackBar_0.TickStyle = TickStyle.Both;
    this.trackBar_0.Value = 18;
    this.trackBar_0.Scroll += new EventHandler(this.trackBar_0_Scroll);
    this.comboBox_0.AccessibleDescription = (string) null;
    this.comboBox_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.comboBox_0, Module.a("풶횸횺\uDFBC킾菀곂뷄\uF5C6", 17));
    this.comboBox_0.BackgroundImage = (Image) null;
    this.comboBox_0.Font = (Font) null;
    this.comboBox_0.FormattingEnabled = true;
    this.comboBox_0.Items.AddRange(new object[6]
    {
      (object) componentResourceManager.GetString(Module.a("풶횸횺\uDFBC킾菀곂뷄\uF5C6\uE7C8苊만\uAACE볐ꃒ", 17)),
      (object) componentResourceManager.GetString(Module.a("풶횸횺\uDFBC킾菀곂뷄\uF5C6\uE7C8苊만\uAACE볐ꃒ\uE4D4", 17)),
      (object) componentResourceManager.GetString(Module.a("풶횸횺\uDFBC킾菀곂뷄\uF5C6\uE7C8苊만\uAACE볐ꃒ\uE7D4", 17)),
      (object) componentResourceManager.GetString(Module.a("풶횸횺\uDFBC킾菀곂뷄\uF5C6\uE7C8苊만\uAACE볐ꃒ\uE6D4", 17)),
      (object) componentResourceManager.GetString(Module.a("풶횸횺\uDFBC킾菀곂뷄\uF5C6\uE7C8苊만\uAACE볐ꃒ\uE1D4", 17)),
      (object) componentResourceManager.GetString(Module.a("풶횸횺\uDFBC킾菀곂뷄\uF5C6\uE7C8苊만\uAACE볐ꃒ\uE0D4", 17))
    });
    this.comboBox_0.Name = Module.a("풶횸횺\uDFBC킾菀곂뷄\uF5C6", 17);
    this.label_0.AccessibleDescription = (string) null;
    this.label_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_0, Module.a("\uDBB6\uD8B8\uD9BA\uD8BC펾\uF4C0", 17));
    this.label_0.BackColor = SystemColors.Control;
    this.label_0.Name = Module.a("\uDBB6\uD8B8\uD9BA\uD8BC펾\uF4C0", 17);
    this.panel_0.AccessibleDescription = (string) null;
    this.panel_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.panel_0, Module.a("잶\uD8B8햺\uD8BC펾\uF0C0", 17));
    this.panel_0.BackgroundImage = (Image) null;
    this.panel_0.Controls.Add((Control) this.label_1);
    this.panel_0.Controls.Add((Control) this.textBox_0);
    this.panel_0.Controls.Add((Control) this.label_2);
    this.panel_0.Controls.Add((Control) this.label_3);
    this.panel_0.Controls.Add((Control) this.label_4);
    this.panel_0.Controls.Add((Control) this.label_5);
    this.panel_0.Controls.Add((Control) this.label_6);
    this.panel_0.Controls.Add((Control) this.label_7);
    this.panel_0.Controls.Add((Control) this.trackBar_0);
    this.panel_0.Font = (Font) null;
    this.panel_0.Name = Module.a("잶\uD8B8햺\uD8BC펾\uF0C0", 17);
    this.label_1.AccessibleDescription = (string) null;
    this.label_1.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_1, Module.a("\uDBB6\uD8B8\uD9BA\uD8BC펾\uF0C0\uF3C2", 17));
    this.label_1.Font = (Font) null;
    this.label_1.Name = Module.a("\uDBB6\uD8B8\uD9BA\uD8BC펾\uF0C0\uF3C2", 17);
    this.label_2.AccessibleDescription = (string) null;
    this.label_2.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_2, Module.a("\uDBB6\uD8B8\uD9BA\uD8BC펾\uF8C0", 17));
    this.label_2.Font = (Font) null;
    this.label_2.Name = Module.a("\uDBB6\uD8B8\uD9BA\uD8BC펾\uF8C0", 17);
    this.label_3.AccessibleDescription = (string) null;
    this.label_3.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_3, Module.a("\uDBB6\uD8B8\uD9BA\uD8BC펾燎", 17));
    this.label_3.Font = (Font) null;
    this.label_3.Name = Module.a("\uDBB6\uD8B8\uD9BA\uD8BC펾燎", 17);
    this.label_4.AccessibleDescription = (string) null;
    this.label_4.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_4, Module.a("\uDBB6\uD8B8\uD9BA\uD8BC펾\uF6C0", 17));
    this.label_4.Font = (Font) null;
    this.label_4.Name = Module.a("\uDBB6\uD8B8\uD9BA\uD8BC펾\uF6C0", 17);
    this.label_5.AccessibleDescription = (string) null;
    this.label_5.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_5, Module.a("\uDBB6\uD8B8\uD9BA\uD8BC펾\uF7C0", 17));
    this.label_5.Font = (Font) null;
    this.label_5.Name = Module.a("\uDBB6\uD8B8\uD9BA\uD8BC펾\uF7C0", 17);
    this.label_6.AccessibleDescription = (string) null;
    this.label_6.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_6, Module.a("\uDBB6\uD8B8\uD9BA\uD8BC펾\uF5C0", 17));
    this.label_6.Font = (Font) null;
    this.label_6.Name = Module.a("\uDBB6\uD8B8\uD9BA\uD8BC펾\uF5C0", 17);
    this.label_7.AccessibleDescription = (string) null;
    this.label_7.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_7, Module.a("\uDBB6\uD8B8\uD9BA\uD8BC펾\uF2C0", 17));
    this.label_7.Font = (Font) null;
    this.label_7.Name = Module.a("\uDBB6\uD8B8\uD9BA\uD8BC펾\uF2C0", 17);
    this.groupBox_0.AccessibleDescription = (string) null;
    this.groupBox_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.groupBox_0, Module.a("킶쮸풺좼쾾菀곂뷄\uF6C6", 17));
    this.groupBox_0.BackgroundImage = (Image) null;
    this.groupBox_0.Controls.Add((Control) this.textBox_1);
    this.groupBox_0.Controls.Add((Control) this.trackBar_1);
    this.groupBox_0.Controls.Add((Control) this.label_8);
    this.groupBox_0.Controls.Add((Control) this.textBox_2);
    this.groupBox_0.Controls.Add((Control) this.trackBar_2);
    this.groupBox_0.Controls.Add((Control) this.label_9);
    this.groupBox_0.Controls.Add((Control) this.textBox_3);
    this.groupBox_0.Controls.Add((Control) this.trackBar_3);
    this.groupBox_0.Controls.Add((Control) this.label_10);
    this.groupBox_0.Font = (Font) null;
    this.groupBox_0.Name = Module.a("킶쮸풺좼쾾菀곂뷄\uF6C6", 17);
    this.groupBox_0.TabStop = false;
    this.textBox_1.AccessibleDescription = (string) null;
    this.textBox_1.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.textBox_1, Module.a("쎶\uDCB8쎺즼ﶾ껀믂\uF0C4", 17));
    this.textBox_1.BackgroundImage = (Image) null;
    this.textBox_1.Font = (Font) null;
    this.textBox_1.Name = Module.a("쎶\uDCB8쎺즼ﶾ껀믂\uF0C4", 17);
    this.textBox_1.ReadOnly = true;
    this.trackBar_1.AccessibleDescription = (string) null;
    this.trackBar_1.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.trackBar_1, Module.a("쎶쮸\uDABA\uDEBC풾菀ꋂ럄\uF2C6", 17));
    this.trackBar_1.BackgroundImage = (Image) null;
    this.trackBar_1.Font = (Font) null;
    this.trackBar_1.Maximum = (int) byte.MaxValue;
    this.trackBar_1.Name = Module.a("쎶쮸\uDABA\uDEBC풾菀ꋂ럄\uF2C6", 17);
    this.trackBar_1.Value = (int) byte.MaxValue;
    this.trackBar_1.Scroll += new EventHandler(this.trackBar_1_Scroll);
    this.label_8.AccessibleDescription = (string) null;
    this.label_8.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_8, Module.a("\uDBB6\uD8B8\uD9BA\uD8BC펾\uF0C0", 17));
    this.label_8.Name = Module.a("\uDBB6\uD8B8\uD9BA\uD8BC펾\uF0C0", 17);
    this.textBox_2.AccessibleDescription = (string) null;
    this.textBox_2.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.textBox_2, Module.a("쎶\uDCB8쎺즼ﶾ껀믂\uF1C4", 17));
    this.textBox_2.BackgroundImage = (Image) null;
    this.textBox_2.Font = (Font) null;
    this.textBox_2.Name = Module.a("쎶\uDCB8쎺즼ﶾ껀믂\uF1C4", 17);
    this.textBox_2.ReadOnly = true;
    this.trackBar_2.AccessibleDescription = (string) null;
    this.trackBar_2.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.trackBar_2, Module.a("쎶쮸\uDABA\uDEBC풾菀ꋂ럄\uF3C6", 17));
    this.trackBar_2.BackgroundImage = (Image) null;
    this.trackBar_2.Font = (Font) null;
    this.trackBar_2.Maximum = (int) byte.MaxValue;
    this.trackBar_2.Name = Module.a("쎶쮸\uDABA\uDEBC풾菀ꋂ럄\uF3C6", 17);
    this.trackBar_2.Value = (int) byte.MaxValue;
    this.trackBar_2.Scroll += new EventHandler(this.trackBar_2_Scroll);
    this.label_9.AccessibleDescription = (string) null;
    this.label_9.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_9, Module.a("\uDBB6\uD8B8\uD9BA\uD8BC펾\uF0C0\uF7C2", 17));
    this.label_9.Name = Module.a("\uDBB6\uD8B8\uD9BA\uD8BC펾\uF0C0\uF7C2", 17);
    this.textBox_3.AccessibleDescription = (string) null;
    this.textBox_3.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.textBox_3, Module.a("쎶\uDCB8쎺즼ﶾ껀믂\uF6C4", 17));
    this.textBox_3.BackgroundImage = (Image) null;
    this.textBox_3.Font = (Font) null;
    this.textBox_3.Name = Module.a("쎶\uDCB8쎺즼ﶾ껀믂\uF6C4", 17);
    this.textBox_3.ReadOnly = true;
    this.trackBar_3.AccessibleDescription = (string) null;
    this.trackBar_3.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.trackBar_3, Module.a("쎶쮸\uDABA\uDEBC풾菀ꋂ럄\uF4C6", 17));
    this.trackBar_3.BackgroundImage = (Image) null;
    this.trackBar_3.Font = (Font) null;
    this.trackBar_3.Maximum = (int) byte.MaxValue;
    this.trackBar_3.Name = Module.a("쎶쮸\uDABA\uDEBC풾菀ꋂ럄\uF4C6", 17);
    this.trackBar_3.Value = (int) byte.MaxValue;
    this.trackBar_3.Scroll += new EventHandler(this.trackBar_3_Scroll);
    this.label_10.AccessibleDescription = (string) null;
    this.label_10.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_10, Module.a("\uDBB6\uD8B8\uD9BA\uD8BC펾\uF0C0\uF0C2", 17));
    this.label_10.Name = Module.a("\uDBB6\uD8B8\uD9BA\uD8BC펾\uF0C0\uF0C2", 17);
    this.groupBox_1.AccessibleDescription = (string) null;
    this.groupBox_1.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.groupBox_1, Module.a("킶쮸풺좼쾾菀곂뷄\uF5C6", 17));
    this.groupBox_1.BackgroundImage = (Image) null;
    this.groupBox_1.Controls.Add((Control) this.panel_0);
    this.groupBox_1.Font = (Font) null;
    this.groupBox_1.Name = Module.a("킶쮸풺좼쾾菀곂뷄\uF5C6", 17);
    this.groupBox_1.TabStop = false;
    this.label_11.AccessibleDescription = (string) null;
    this.label_11.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_11, Module.a("\uDBB6\uD8B8\uD9BA\uD8BC펾\uF3C0", 17));
    this.label_11.Font = (Font) null;
    this.label_11.Name = Module.a("\uDBB6\uD8B8\uD9BA\uD8BC펾\uF3C0", 17);
    this.textBox_4.AccessibleDescription = (string) null;
    this.textBox_4.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.textBox_4, Module.a("쎶\uDCB8쎺즼ﶾ껀믂\uF7C4", 17));
    this.textBox_4.BackgroundImage = (Image) null;
    this.textBox_4.Font = (Font) null;
    this.textBox_4.Name = Module.a("쎶\uDCB8쎺즼ﶾ껀믂\uF7C4", 17);
    this.label_12.AccessibleDescription = (string) null;
    this.label_12.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_12, Module.a("\uDBB6\uD8B8\uD9BA\uD8BC펾\uF0C0\uF2C2", 17));
    this.label_12.Font = (Font) null;
    this.label_12.Name = Module.a("\uDBB6\uD8B8\uD9BA\uD8BC펾\uF0C0\uF2C2", 17);
    this.button_1.AccessibleDescription = (string) null;
    this.button_1.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.button_1, Module.a("햶첸쾺즼킾꿀\uF1C2", 17));
    this.button_1.BackgroundImage = (Image) null;
    this.button_1.Font = (Font) null;
    this.button_1.Name = Module.a("햶첸쾺즼킾꿀\uF1C2", 17);
    this.button_1.UseVisualStyleBackColor = true;
    this.button_1.Click += new EventHandler(this.button_1_Click);
    this.groupBox_2.AccessibleDescription = (string) null;
    this.groupBox_2.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.groupBox_2, Module.a("킶쮸풺좼쾾菀곂뷄\uF4C6", 17));
    this.groupBox_2.BackgroundImage = (Image) null;
    this.groupBox_2.Controls.Add((Control) this.button_1);
    this.groupBox_2.Controls.Add((Control) this.label_0);
    this.groupBox_2.Controls.Add((Control) this.comboBox_0);
    this.groupBox_2.Controls.Add((Control) this.textBox_4);
    this.groupBox_2.Controls.Add((Control) this.label_12);
    this.groupBox_2.Controls.Add((Control) this.label_11);
    this.groupBox_2.Font = (Font) null;
    this.groupBox_2.Name = Module.a("킶쮸풺좼쾾菀곂뷄\uF4C6", 17);
    this.groupBox_2.TabStop = false;
    this.button_2.AccessibleDescription = (string) null;
    this.button_2.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.button_2, Module.a("햶첸쾺즼킾꿀\uF0C2", 17));
    this.button_2.BackgroundImage = (Image) null;
    this.button_2.Font = (Font) null;
    this.button_2.Name = Module.a("햶첸쾺즼킾꿀\uF0C2", 17);
    this.button_2.UseVisualStyleBackColor = true;
    this.button_2.Click += new EventHandler(this.button_2_Click);
    this.AccessibleDescription = (string) null;
    this.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this, Module.a("鎶춸펺풼첾", 17));
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackgroundImage = (Image) null;
    this.ControlBox = false;
    this.Controls.Add((Control) this.button_2);
    this.Controls.Add((Control) this.groupBox_2);
    this.Controls.Add((Control) this.groupBox_1);
    this.Controls.Add((Control) this.groupBox_0);
    this.Controls.Add((Control) this.button_0);
    this.Font = (Font) null;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Icon = (Icon) null;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = Module.a("\uF0B6\uDCB8햺\uD8BC춾ꃀ럂ꃄ", 17);
    this.TopMost = true;
    this.trackBar_0.EndInit();
    this.panel_0.ResumeLayout(false);
    this.panel_0.PerformLayout();
    this.groupBox_0.ResumeLayout(false);
    this.groupBox_0.PerformLayout();
    this.trackBar_1.EndInit();
    this.trackBar_2.EndInit();
    this.trackBar_3.EndInit();
    this.groupBox_1.ResumeLayout(false);
    this.groupBox_2.ResumeLayout(false);
    this.groupBox_2.PerformLayout();
    this.ResumeLayout(false);
  }

  public ac()
  {
    this.method_0();
    this.comboBox_0.SelectedIndex = c.int_81;
    switch (c.int_2)
    {
      case 1:
      case 9:
      case 102:
        this.panel_0.Visible = false;
        break;
      case 2:
        this.comboBox_0.Visible = false;
        this.label_0.Visible = false;
        break;
    }
    this.trackBar_0.Value = (int) (c.double_2 * 10.0);
    this.textBox_0.Text = c.double_2.ToString();
    this.trackBar_3.Value = (int) c.byte_13;
    this.textBox_3.Text = this.trackBar_3.Value.ToString();
    this.trackBar_2.Value = (int) c.byte_14;
    this.textBox_2.Text = this.trackBar_2.Value.ToString();
    this.trackBar_1.Value = (int) c.byte_15;
    this.textBox_1.Text = this.trackBar_1.Value.ToString();
    if (c.byte_1 != (byte) 1 && c.byte_1 != (byte) 2 && c.byte_1 != (byte) 3 && c.byte_1 != (byte) 4 && c.byte_1 != (byte) 5)
      this.button_1.Enabled = false;
    else
      this.button_1.Enabled = true;
  }

  private void trackBar_0_Scroll(object sender, EventArgs e)
  {
    double num = (double) this.trackBar_0.Value / 10.0;
    c.double_2 = num;
    this.textBox_0.Text = string.Format(Module.a("킪鶬閮膰鶲薴쪶", 5), (object) num);
    this.method_2();
  }

  private void method_1(string string_0)
  {
    MessageDialog aa = new MessageDialog();
    aa.label_0.Text = string_0;
    int num = (int) aa.ShowDialog();
  }

  private void method_2()
  {
    double double2 = c.double_2;
    for (int index = 0; index < 256; ++index)
    {
      double num1 = Math.Pow((double) index / (double) byte.MaxValue, double2);
      double num2 = (double) c.byte_13 * num1;
      c.byte_21[index] = (byte) num2;
      if (c.bool_18)
        c.byte_21[index] = (byte)~c.byte_21[index];
    }
    for (int index = 0; index < 256; ++index)
    {
      double num3 = Math.Pow((double) index / (double) byte.MaxValue, double2);
      double num4 = (double) c.byte_14 * num3;
      c.byte_22[index] = (byte) num4;
      if (c.bool_18)
        c.byte_22[index] = (byte)~c.byte_22[index];
    }
    for (int index = 0; index < 256; ++index)
    {
      double num5 = Math.Pow((double) index / (double) byte.MaxValue, double2);
      double num6 = (double) c.byte_15 * num5;
      c.byte_23[index] = (byte) num6;
      if (c.bool_18)
        c.byte_23[index] = (byte)~c.byte_23[index];
    }
    switch (c.byte_1)
    {
      case 1:
        c.byte_21[(int) byte.MaxValue] = (byte) 254;
        c.byte_22[(int) byte.MaxValue] = (byte) 254;
        c.byte_23[(int) byte.MaxValue] = (byte) 254;
        c.byte_6 = (byte) ((uint) (byte) ((uint) c.byte_3 << 3) | (uint) (byte) ((uint) (byte) ((uint) c.byte_4 >> 2) & 7U));
        c.byte_7 = (byte) ((uint) (byte) ((uint) c.byte_4 << 6) | (uint) (byte) ((uint) c.byte_5 << 1));
        if (c.byte_2 == (byte) 85)
          c.byte_7 = c.byte_7;
        c.byte_7 = c.byte_7;
        byte[] numArray1 = new byte[8]
        {
          (byte) 1,
          (byte) 2,
          (byte) 4,
          (byte) 8,
          (byte) 16,
          (byte) 32,
          (byte) 64,
          (byte) 128
        };
        byte[] numArray2 = new byte[8]
        {
          (byte) 128,
          (byte) 64,
          (byte) 32,
          (byte) 16,
          (byte) 8,
          (byte) 4,
          (byte) 2,
          (byte) 1
        };
        byte num7 = 0;
        for (int index = 0; index < 8; ++index)
        {
          if (((int) c.byte_6 & (int) numArray1[index]) != 0)
            num7 |= numArray2[index];
        }
        c.byte_6 = num7;
        byte num8 = 0;
        for (int index = 0; index < 8; ++index)
        {
          if (((int) c.byte_7 & (int) numArray1[index]) != 0)
            num8 |= numArray2[index];
        }
        c.byte_7 = num8;
        break;
      case 2:
        c.byte_6 = (byte) ((uint) (byte) ((uint) c.byte_5 << 4) | (uint) c.byte_4);
        c.byte_7 = (byte) ((uint) (byte) ((uint) c.byte_3 << 4) | 9U);
        break;
      case 3:
        byte num9 = (byte) ((uint) c.byte_3 >> 4);
        byte num10 = (byte) ((uint) c.byte_3 & 15U);
        byte num11 = (byte) ((uint) c.byte_4 >> 4);
        byte num12 = (byte) ((uint) c.byte_4 & 15U);
        c.byte_6 = c.byte_5 != (byte) 0 ? (byte) 212 : (byte) 84;
        if (((int) num10 & 4) != 0)
          c.byte_6 |= (byte) 1;
        c.byte_7 = (byte) ((uint) num10 << 6);
        c.byte_7 |= (byte) ((uint) num11 << 2);
        if (((int) num12 & 4) != 0)
          c.byte_7 |= (byte) 1;
        c.byte_8 = (byte) ((uint) num12 << 6);
        c.byte_8 |= (byte) ((uint) num9 << 1);
        break;
      case 4:
        byte num13 = (byte) ((uint) c.byte_3 >> 4);
        byte num14 = (byte) ((uint) c.byte_3 & 15U);
        byte num15 = (byte) ((uint) c.byte_4 >> 4);
        byte num16 = (byte) ((uint) c.byte_4 & 15U);
        c.byte_6 = (byte) ((uint) num14 << 5);
        c.byte_6 |= (byte) ((uint) num15 << 2);
        c.byte_6 |= (byte) ((uint) num16 >> 1);
        c.byte_7 = (byte) ((uint) num16 << 7);
        c.byte_7 |= (byte) ((uint) num13 << 5);
        c.byte_7 |= (byte) 19;
        c.byte_8 = byte.MaxValue;
        break;
      case 5:
        c.byte_6 = c.byte_3;
        c.byte_7 = c.byte_4;
        c.byte_8 = c.byte_5;
        break;
    }
  }

  private void button_0_Click(object sender, EventArgs e)
  {
    this.method_2();
    c.int_81 = this.comboBox_0.SelectedIndex;
    string path = c.string_21 + (object) '\\' + c.string_23 + Module.a("龰풲\uD8B4\uDAB6", 11);
    if (File.Exists(path))
      File.Delete(path);
    using (StreamWriter streamWriter = new StreamWriter(path, false, Encoding.Unicode))
    {
      streamWriter.WriteLine(c.double_2.ToString());
      streamWriter.WriteLine(c.byte_13.ToString());
      streamWriter.WriteLine(c.byte_14.ToString());
      streamWriter.WriteLine(c.byte_15.ToString());
      streamWriter.WriteLine(c.int_81.ToString());
    }
    c.string_3 = this.textBox_4.Text;
    this.DialogResult = DialogResult.OK;
  }

  private void trackBar_3_Scroll(object sender, EventArgs e)
  {
    c.byte_13 = (byte) this.trackBar_3.Value;
    this.textBox_3.Text = this.trackBar_3.Value.ToString();
    this.method_2();
  }

  private void trackBar_2_Scroll(object sender, EventArgs e)
  {
    c.byte_14 = (byte) this.trackBar_2.Value;
    this.textBox_2.Text = this.trackBar_2.Value.ToString();
    this.method_2();
  }

  private void trackBar_1_Scroll(object sender, EventArgs e)
  {
    c.byte_15 = (byte) this.trackBar_1.Value;
    this.textBox_1.Text = this.trackBar_1.Value.ToString();
    this.method_2();
  }

  private void button_1_Click(object sender, EventArgs e)
  {
    switch (c.byte_1)
    {
      case 1:
      case 2:
        int num1 = (int) new u().ShowDialog();
        this.method_2();
        break;
      case 3:
      case 4:
        int num2 = (int) new w().ShowDialog();
        this.method_2();
        break;
      case 5:
        int num3 = (int) new j().ShowDialog();
        this.method_2();
        break;
    }
  }

  private void button_2_Click(object sender, EventArgs e) => this.Close();
}
