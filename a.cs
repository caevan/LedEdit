// Decompiled with JetBrains decompiler
// Type: a
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class a : Form
{
  private IContainer icontainer_0;
  private RadioButton radioButton_0;
  private RadioButton radioButton_1;
  private Button button_0;
  private Button button_1;
  private GroupBox groupBox_0;
  private GroupBox groupBox_1;
  private RadioButton radioButton_2;
  private RadioButton radioButton_3;
  private TrackBar trackBar_0;
  private Label label_0;
  private Label label_1;
  public TrackBar trackBar_1;
  private Label label_2;
  public TrackBar trackBar_2;
  private TextBox textBox_0;
  private Label label_3;
  private Button button_2;
  private CheckBox checkBox_0;
  private Button button_3;
  private CheckBox checkBox_1;
  private CheckBox checkBox_2;
  private static Color color_0;

    //virtual public void Dispose(bool disposing)
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (a));
    this.radioButton_0 = new RadioButton();
    this.radioButton_1 = new RadioButton();
    this.button_0 = new Button();
    this.button_1 = new Button();
    this.groupBox_0 = new GroupBox();
    this.groupBox_1 = new GroupBox();
    this.checkBox_0 = new CheckBox();
    this.radioButton_2 = new RadioButton();
    this.radioButton_3 = new RadioButton();
    this.trackBar_0 = new TrackBar();
    this.label_0 = new Label();
    this.label_1 = new Label();
    this.trackBar_1 = new TrackBar();
    this.label_2 = new Label();
    this.trackBar_2 = new TrackBar();
    this.textBox_0 = new TextBox();
    this.label_3 = new Label();
    this.button_2 = new Button();
    this.button_3 = new Button();
    this.checkBox_1 = new CheckBox();
    this.checkBox_2 = new CheckBox();
    this.groupBox_0.SuspendLayout();
    this.groupBox_1.SuspendLayout();
    this.trackBar_0.BeginInit();
    this.trackBar_1.BeginInit();
    this.trackBar_2.BeginInit();
    this.SuspendLayout();
        this.radioButton_0.AccessibleDescription = (string)null;
        this.radioButton_0.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.radioButton_0, "radioButton1");
        this.radioButton_0.BackgroundImage = (Image)null;
        this.radioButton_0.Font = (Font)null;
        this.radioButton_0.Name = "radioButton1";
        this.radioButton_0.TabStop = true;
        this.radioButton_0.UseVisualStyleBackColor = true;
        this.radioButton_0.CheckedChanged += new EventHandler(this.radioButton_0_CheckedChanged);
        this.radioButton_1.AccessibleDescription = (string)null;
        this.radioButton_1.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.radioButton_1, "radioButton2");
        this.radioButton_1.BackgroundImage = (Image)null;
        this.radioButton_1.Font = (Font)null;
        this.radioButton_1.Name = "radioButton2";
        this.radioButton_1.TabStop = true;
        this.radioButton_1.UseVisualStyleBackColor = true;
        this.radioButton_1.CheckedChanged += new EventHandler(this.radioButton_1_CheckedChanged);

        this.button_0.AccessibleDescription = (string) null;
    this.button_0.AccessibleName = (string) null;
        componentResourceManager.ApplyResources((object)this.button_0, "button1");
        this.button_0.BackgroundImage = (Image)null;
        this.button_0.Font = (Font)null;
        this.button_0.Name = "button1";
        this.button_0.UseVisualStyleBackColor = true;
        this.button_0.Click += new EventHandler(this.button_0_Click);
        this.button_1.AccessibleDescription = (string)null;
        this.button_1.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.button_1, "button3");
        this.button_1.BackgroundImage = (Image)null;
        this.button_1.Font = (Font)null;
        this.button_1.Name = "button3";
        this.button_1.UseVisualStyleBackColor = true;
        this.button_1.Click += new EventHandler(this.button_1_Click);
        this.groupBox_0.AccessibleDescription = (string)null;
        this.groupBox_0.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.groupBox_0, "groupBox1");

        this.groupBox_0.BackgroundImage = (Image)null;
        this.groupBox_0.Controls.Add((Control)this.radioButton_1);
        this.groupBox_0.Controls.Add((Control)this.radioButton_0);
        this.groupBox_0.Font = (Font)null;
        this.groupBox_0.Name = "groupBox1";
        this.groupBox_0.TabStop = false;
        this.groupBox_1.AccessibleDescription = (string)null;
        this.groupBox_1.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.groupBox_1, "groupBox2");
        this.groupBox_1.BackgroundImage = (Image)null;
        this.groupBox_1.Controls.Add((Control)this.checkBox_0);
        this.groupBox_1.Controls.Add((Control)this.radioButton_2);
        this.groupBox_1.Controls.Add((Control)this.radioButton_3);
        this.groupBox_1.Font = (Font)null;
        this.groupBox_1.Name = "groupBox2";
        this.groupBox_1.TabStop = false;
        this.checkBox_0.AccessibleDescription = (string)null;
        this.checkBox_0.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.checkBox_0, "checkBox1");

        this.checkBox_0.BackgroundImage = (Image)null;
        this.checkBox_0.Font = (Font)null;
        this.checkBox_0.Name = "checkBox1";
        this.checkBox_0.UseVisualStyleBackColor = true;
        this.checkBox_0.CheckedChanged += new EventHandler(this.checkBox_0_CheckedChanged);
        this.radioButton_2.AccessibleDescription = (string)null;
        this.radioButton_2.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.radioButton_2, "radioButton4");
        this.radioButton_2.BackgroundImage = (Image)null;
        this.radioButton_2.Font = (Font)null;
        this.radioButton_2.Name = "radioButton4";
        this.radioButton_2.TabStop = true;
        this.radioButton_2.UseVisualStyleBackColor = true;
        this.radioButton_2.CheckedChanged += new EventHandler(this.radioButton_2_CheckedChanged);
        this.radioButton_3.AccessibleDescription = (string)null;
        this.radioButton_3.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.radioButton_3, "radioButton3");
        this.radioButton_3.BackgroundImage = (Image)null;
        this.radioButton_3.Font = (Font)null;
        this.radioButton_3.Name = "radioButton3";

        this.radioButton_3.TabStop = true;
    this.radioButton_3.UseVisualStyleBackColor = true;
    this.radioButton_3.CheckedChanged += new EventHandler(this.radioButton_3_CheckedChanged);
    this.trackBar_0.AccessibleDescription = (string) null;
    this.trackBar_0.AccessibleName = (string) null;
        componentResourceManager.ApplyResources((object)this.trackBar_0, "trackBar1");
        this.trackBar_0.BackgroundImage = (Image)null;
        this.trackBar_0.Cursor = Cursors.Hand;
        this.trackBar_0.Font = (Font)null;
        this.trackBar_0.LargeChange = 1;
        this.trackBar_0.Maximum = 20;
        this.trackBar_0.Name = "trackBar1";
        this.trackBar_0.Value = 9;
        this.trackBar_0.Scroll += new EventHandler(this.trackBar_0_Scroll);
        this.label_0.AccessibleDescription = (string)null;
        this.label_0.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_0, "label5");
        this.label_0.Font = (Font)null;
        this.label_0.Name = "label5";
        this.label_1.AccessibleDescription = (string)null;
        this.label_1.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_1, "label1");
        this.label_1.Font = (Font)null;
        this.label_1.Name = "label1";
        this.trackBar_1.AccessibleDescription = (string)null;
        this.trackBar_1.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.trackBar_1, "trackBar2");

    this.trackBar_1.BackgroundImage = (Image) null;
    this.trackBar_1.Cursor = Cursors.Hand;
    this.trackBar_1.Font = (Font) null;
    this.trackBar_1.LargeChange = 1;
        this.trackBar_1.Name = "trackBar2";
        this.trackBar_1.Scroll += new EventHandler(this.trackBar_1_Scroll);
        this.label_2.AccessibleDescription = (string)null;
        this.label_2.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_2, "label2");
        this.label_2.Font = (Font)null;
        this.label_2.Name = "label2";
        this.trackBar_2.AccessibleDescription = (string)null;
        this.trackBar_2.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.trackBar_2, "trackBar3");
        this.trackBar_2.BackgroundImage = (Image)null;
        this.trackBar_2.Cursor = Cursors.Hand;
        this.trackBar_2.Font = (Font)null;
        this.trackBar_2.LargeChange = 1;
        this.trackBar_2.Minimum = -3;

        this.trackBar_2.Name = "trackBar3";
        this.trackBar_2.Scroll += new EventHandler(this.trackBar_2_Scroll);
        this.textBox_0.AccessibleDescription = (string)null;
        this.textBox_0.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.textBox_0, "textBox1");
        this.textBox_0.BackgroundImage = (Image)null;
        this.textBox_0.Font = (Font)null;
        this.textBox_0.Name = "textBox1";
        this.textBox_0.TextChanged += new EventHandler(this.textBox_0_TextChanged);
        this.label_3.AccessibleDescription = (string)null;
        this.label_3.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_3, "label3");
        this.label_3.Font = (Font)null;
        this.label_3.Name = "label3";
        this.button_2.AccessibleDescription = (string)null;
        this.button_2.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.button_2, "button5");
        this.button_2.BackgroundImage = (Image)null;
        this.button_2.Font = (Font)null;
        this.button_2.Name = "button5";

        this.button_2.UseVisualStyleBackColor = true;
    this.button_2.Click += new EventHandler(this.button_2_Click);
    this.button_3.AccessibleDescription = (string) null;
    this.button_3.AccessibleName = (string) null;
        componentResourceManager.ApplyResources((object)this.button_3, "button2");
        this.button_3.BackgroundImage = (Image)null;
        this.button_3.Font = (Font)null;
        this.button_3.Name = "button2";
        this.button_3.UseVisualStyleBackColor = true;
        this.button_3.Click += new EventHandler(this.button_3_Click);
        this.checkBox_1.AccessibleDescription = (string)null;
        this.checkBox_1.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.checkBox_1, "checkBox2");
        this.checkBox_1.BackgroundImage = (Image)null;
        this.checkBox_1.Font = (Font)null;
        this.checkBox_1.Name = "checkBox2";
        this.checkBox_1.UseVisualStyleBackColor = true;
        this.checkBox_1.CheckedChanged += new EventHandler(this.checkBox_1_CheckedChanged);
        this.checkBox_2.AccessibleDescription = (string)null;
        this.checkBox_2.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.checkBox_2, "checkBox3");

        this.checkBox_2.BackgroundImage = (Image) null;
    this.checkBox_2.Font = (Font) null;
        this.checkBox_2.Name = "checkBox3";
        this.checkBox_2.UseVisualStyleBackColor = true;
        this.checkBox_2.CheckedChanged += new EventHandler(this.checkBox_2_CheckedChanged);
        this.AccessibleDescription = (string)null;
        this.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this, "$this");

        this.AutoScaleMode = AutoScaleMode.Font;
    this.BackgroundImage = (Image) null;
    this.ControlBox = false;
    this.Controls.Add((Control) this.checkBox_2);
    this.Controls.Add((Control) this.checkBox_1);
    this.Controls.Add((Control) this.button_3);
    this.Controls.Add((Control) this.button_2);
    this.Controls.Add((Control) this.label_3);
    this.Controls.Add((Control) this.textBox_0);
    this.Controls.Add((Control) this.label_2);
    this.Controls.Add((Control) this.trackBar_2);
    this.Controls.Add((Control) this.label_1);
    this.Controls.Add((Control) this.trackBar_1);
    this.Controls.Add((Control) this.label_0);
    this.Controls.Add((Control) this.trackBar_0);
    this.Controls.Add((Control) this.groupBox_1);
    this.Controls.Add((Control) this.groupBox_0);
    this.Controls.Add((Control) this.button_1);
    this.Controls.Add((Control) this.button_0);
    this.Font = (Font) null;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Icon = (Icon) null;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = "Text_Insert";
    this.ShowInTaskbar = false;
    this.TopMost = true;
    this.FormClosing += new FormClosingEventHandler(this.a_FormClosing);
    this.groupBox_0.ResumeLayout(false);
    this.groupBox_0.PerformLayout();
    this.groupBox_1.ResumeLayout(false);
    this.groupBox_1.PerformLayout();
    this.trackBar_0.EndInit();
    this.trackBar_1.EndInit();
    this.trackBar_2.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public a()
  {
    this.method_0();
    if (c.bool_53)
      this.radioButton_0.Checked = true;
    else
      this.radioButton_1.Checked = true;
    if (c.bool_54)
    {
      this.radioButton_3.Checked = true;
      this.trackBar_2.Enabled = true;
      this.trackBar_1.Enabled = false;
    }
    else
    {
      this.radioButton_2.Checked = true;
      this.trackBar_2.Enabled = false;
      this.trackBar_1.Enabled = true;
    }
    if (c.int_57 + 10 <= this.trackBar_0.Maximum)
      this.trackBar_0.Value = c.int_57 + 10;
    this.trackBar_1.Maximum = c.int_60;
    this.trackBar_2.Maximum = c.int_61;
    this.textBox_0.Text = c.string_19;
    this.method_1();
    c.bool_52 = this.checkBox_0.Checked;
    this.button_0.Enabled = this.checkBox_1.Checked;
    c.bool_55 = this.checkBox_1.Checked;
  }

  private void button_0_Click(object sender, EventArgs e)
  {
    ColorDialog colorDialog = new ColorDialog();
    colorDialog.Color = c.color_2;
    colorDialog.AllowFullOpen = true;
    colorDialog.FullOpen = true;
    colorDialog.ShowHelp = true;
    if (colorDialog.ShowDialog() == DialogResult.OK)
      c.color_2 = colorDialog.Color.R != (byte) 0 || colorDialog.Color.G != (byte) 0 || colorDialog.Color.B != (byte) 0 ? colorDialog.Color : Color.FromArgb(0, 0, 1);
    this.method_1();
  }

  private void button_1_Click(object sender, EventArgs e)
  {
    FontDialog fontDialog = new FontDialog();
    fontDialog.Font = c.font_0;
    fontDialog.Color = c.color_3;
    fontDialog.AllowScriptChange = true;
    fontDialog.ShowColor = true;
    if (fontDialog.ShowDialog() != DialogResult.Cancel)
    {
      c.font_0 = fontDialog.Font;
      c.color_3 = fontDialog.Color.R != (byte) 0 || fontDialog.Color.G != (byte) 0 || fontDialog.Color.B != (byte) 0 ? fontDialog.Color : Color.FromArgb(0, 0, 1);
    }
    this.method_1();
  }

  private void textBox_0_TextChanged(object sender, EventArgs e)
  {
    c.string_19 = this.textBox_0.Text;
    this.method_1();
  }

  private void radioButton_0_CheckedChanged(object sender, EventArgs e)
  {
    c.bool_53 = false;
    this.method_1();
    this.checkBox_2.Enabled = true;
    this.checkBox_1.Enabled = true;
    c.bool_56 = this.checkBox_2.Checked;
  }

  private void radioButton_1_CheckedChanged(object sender, EventArgs e)
  {
    c.bool_53 = true;
    this.method_1();
    this.checkBox_2.Checked = false;
    this.checkBox_2.Enabled = false;
    c.bool_56 = false;
    this.checkBox_1.Checked = false;
    this.checkBox_1.Enabled = false;
    this.button_0.Enabled = this.checkBox_1.Checked;
    c.bool_55 = this.checkBox_1.Checked;
  }

  private void radioButton_3_CheckedChanged(object sender, EventArgs e)
  {
    c.bool_54 = false;
    c.int_59 = 0;
    this.trackBar_2.Enabled = true;
    this.trackBar_1.Enabled = false;
    this.method_1();
    this.checkBox_0.Enabled = false;
  }

  private void radioButton_2_CheckedChanged(object sender, EventArgs e)
  {
    c.bool_54 = true;
    c.int_58 = 0;
    this.trackBar_2.Enabled = false;
    this.trackBar_1.Enabled = true;
    this.method_1();
    this.checkBox_0.Enabled = false;
  }

  private void trackBar_0_Scroll(object sender, EventArgs e) => this.method_1();

  private void trackBar_1_Scroll(object sender, EventArgs e) => this.method_1();

  private void trackBar_2_Scroll(object sender, EventArgs e) => this.method_1();

  private void button_2_Click(object sender, EventArgs e)
  {
    c.bool_51 = false;
    c.bool_55 = false;
    this.Hide();
  }

  public void method_1()
  {
    int int_0 = 6;
    c.int_59 = this.trackBar_2.Value;
    c.int_58 = this.trackBar_1.Value;
    c.int_57 = this.trackBar_0.Value - 10;
    if (!c.bool_53)
    {
      c.gclass0_8.method_12().ForeColor = c.color_3;
    }
    else
    {
      c.gclass0_8.method_12().ColorFill(Color.FromArgb(0, 0, 1));
      c.gclass0_8.method_12().ForeColor = Color.FromArgb(0, 0, 0);
    }
    c.gclass0_8.method_12().FontHandle = c.font_0.ToHfont();
    string[] strArray = c.string_19.Split(new string[1]
    {
      Module.a("ꆫ꒭", int_0)
    }, StringSplitOptions.None);
    if (strArray.Length > 1)
    {
      int length = strArray[0].Length;
      int index1 = 0;
      for (int index2 = 0; index2 < strArray.Length; ++index2)
      {
        if (strArray[index2].Length > length)
        {
          length = strArray[index2].Length;
          index1 = index2;
        }
      }
      c.size_0 = TextRenderer.MeasureText(strArray[index1], c.font_0);
    }
    else
      c.size_0 = TextRenderer.MeasureText(c.string_19, c.font_0);
    if (this.radioButton_1.Checked)
      this.button_0.Enabled = false;
    else
      this.button_0.Enabled = true;
  }

  private void a_FormClosing(object sender, FormClosingEventArgs e) => c.bool_51 = false;

  private void checkBox_0_CheckedChanged(object sender, EventArgs e)
  {
    c.int_59 = 0;
    c.bool_52 = this.checkBox_0.Checked;
  }

  private void button_3_Click(object sender, EventArgs e) => this.Hide();

  private void checkBox_1_CheckedChanged(object sender, EventArgs e)
  {
    this.button_0.Enabled = this.checkBox_1.Checked;
    c.bool_55 = this.checkBox_1.Checked;
  }

  private void checkBox_2_CheckedChanged(object sender, EventArgs e)
  {
    if (this.checkBox_2.Checked)
    {
      a.color_0 = c.color_3;
      c.color_3 = Color.FromArgb(0, 0, 1);
    }
    else
      c.color_3 = a.color_0;
    c.bool_56 = this.checkBox_2.Checked;
    this.button_0.Enabled = this.checkBox_1.Checked;
    c.bool_55 = this.checkBox_1.Checked;
  }
}
