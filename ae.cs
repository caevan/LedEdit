// Decompiled with JetBrains decompiler
// Type: ae
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

public class ae : Form
{
  private IContainer icontainer_0;
  private CheckBox checkBox_0;
  private GroupBox groupBox_0;
  private Button button_0;
  private Label label_0;
  private TextBox textBox_0;
  private Button button_1;
  private Button button_2;
  private CheckBox checkBox_1;
  private GroupBox groupBox_1;
  private Label label_1;
  private Label label_2;
  private DateTimePicker dateTimePicker_0;
  private CheckBox checkBox_2;
  private GroupBox groupBox_2;
  private ComboBox comboBox_0;
  private Label label_3;
  private Label label_4;
  private CheckBox checkBox_3;

  public ae()
  {
    int int_0 = 2;
    // ISSUE: explicit constructor call
 //   base.\u002Ector();
    this.method_3();
    this.checkBox_3.Checked = false;
    string path1 = c.string_2 + Module.a("\uF4A7囹\uD8AB쾭슯욱\uEBB3습隷캹쒻쪽", 2);
    if (File.Exists(path1))
    {
      using (StreamReader streamReader = new StreamReader(path1, Encoding.Unicode))
      {
        this.textBox_0.Text = streamReader.ReadLine();
        if (Convert.ToBoolean(streamReader.ReadLine()))
          this.checkBox_3.Checked = true;
        string str = streamReader.ReadLine();
        if (str != null)
        {
          try
          {
            this.dateTimePicker_0.Value = new DateTime(Convert.ToInt64(str));
          }
          catch
          {
          }
          this.checkBox_1.Checked = true;
          this.groupBox_1.Enabled = true;
        }
        else
        {
          this.checkBox_1.Checked = false;
          this.groupBox_1.Enabled = false;
        }
      }
      this.checkBox_0.Checked = true;
      this.groupBox_0.Enabled = true;
    }
    else
    {
      this.checkBox_0.Checked = false;
      this.groupBox_0.Enabled = false;
      this.checkBox_1.Checked = false;
      this.groupBox_1.Enabled = false;
    }
    this.checkBox_3.Enabled = this.checkBox_0.Checked;
    this.checkBox_2.Checked = false;
    string path2 = c.string_2 + Module.a("\uF4A7囹\uF3AB청\uDFAF\uDDB1삳\uE9B5쮷钹좻욽뒿", int_0);
    if (File.Exists(path2))
    {
      using (StreamReader streamReader = new StreamReader(path2, Encoding.Unicode))
      {
        string str = streamReader.ReadLine();
        try
        {
          if (Convert.ToBoolean(str))
          {
            this.checkBox_2.Checked = true;
            this.comboBox_0.SelectedIndex = Convert.ToInt32(streamReader.ReadLine());
          }
        }
        catch
        {
        }
      }
    }
    this.checkBox_0_CheckedChanged((object) null, (EventArgs) null);
    this.groupBox_2.Enabled = this.checkBox_2.Checked;
  }

  public static void smethod_0(int int_0)
  {
    string str = Module.a("\uF6B1\uDDB3\uDBB5颷\uEDB9쾻횽춿죁韃ꏅ볇\uEAC9鯋뷍룏\uF2D1\uE9D3\uF6D5迗觙뿛곝觟鋡郣죥ꯧ飩觫迭蓯韱믳铵鋷\u9FF9\u9FFB諽⣿ 匃唅欇砉攋縍搏㰑䜓縕紗瘙瀛㰝ट⼡⸣焥笧䤩師䜭䀯䘱ᨳ攵吷弹夻丽栿", 12) + (int_0 * 1000).ToString() + Module.a("鮱릳벵\uEFB7즹풻邽銿럁\uAAC3\uE6C5\uEAC7", 12) + ae.smethod_1(Application.ExecutablePath) + Module.a("邱颳骵\uECB7좹즻\uDBBD춿죁韃ꏅ볇\uEAC9鯋뷍룏\uEFD1髓맕賗닙뗛냝蟟\uEFE1\uEEE3뇥믧觩黫蟭胯蛱\uDAF3蟵跷鏹裻", 12);
    using (StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + Module.a("\uEEB1", 12) + Application.ProductName + Module.a("鲱슳풵쮷", 12), false, Encoding.GetEncoding(Module.a("\uF5B1\uF6B3蒵讷讹躻", 12))))
      streamWriter.Write(str);
  }

  private static string smethod_1(string string_0)
  {
    int int_0 = 19;
    try
    {
      char[] chArray = new char[1]{ '\\' };
      string str1 = string_0;
      string str2 = string.Empty;
      List<string> stringList = new List<string>();
      stringList.AddRange((IEnumerable<string>) str1.Split(chArray));
      int num = 0;
      foreach (string str3 in stringList)
      {
        string str4 = str3;
        if (str4.Contains(Module.a("馸", int_0)))
        {
          str4 = str4.Replace(Module.a("馸", int_0), "");
          if (str4.Length <= 6)
            str4 += Module.a("잸誺", int_0);
          else if (str4.Length > 6)
            str4 = str4.Substring(0, 6) + Module.a("잸誺", int_0);
        }
        if (num == 0)
          str2 = str4 + Module.a("\uE5B8", int_0);
        else if (num < stringList.Count - 1)
          str2 = str2 + str4 + Module.a("\uE5B8", int_0);
        else if (num == stringList.Count - 1)
          str2 += str4;
        ++num;
      }
      return str2;
    }
    catch
    {
      return string_0;
    }
  }

  public static void smethod_2() => File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + Module.a("\uF3AE", 9) + Application.ProductName + Module.a("膮잰톲운", 9));

  private void button_0_Click(object sender, EventArgs e)
  {
    OpenFileDialog openFileDialog = new OpenFileDialog();
    openFileDialog.Title = Module.a("\uE3AFힱ\uD8B3펵\uDBB7캹鲻\uEEBD뢿ꃁ", 10);
    openFileDialog.Filter = Module.a("\uE0AF삱\uDBB3\uDCB5\uDDB7\uD9B9좻麽蚿ꯁꣃꏅ\uE0C7\uE0C9\uE2CB뻍꣏냑\uFDD3\uAAD5\uF2D7\uF4D9곛ꛝ苟黡ꗣ諥蓧쫩ꫫ蟭鳯韱\uDCF3\uDCF5훷탹헻苽⫿Ⰱ⸃", 10);
    openFileDialog.RestoreDirectory = true;
    if (openFileDialog.ShowDialog() != DialogResult.OK)
      return;
    this.textBox_0.Text = openFileDialog.FileName;
  }

  private void button_1_Click(object sender, EventArgs e)
  {
    int int_0 = 3;
    string path1 = c.string_2 + Module.a("\uF5A8\uF8AA\uD9AC캮쎰잲\uEAB4쎶鞸쾺얼쮾", 3);
    if (File.Exists(path1))
      File.Delete(path1);
    if (this.checkBox_0.Checked)
    {
      using (StreamWriter streamWriter = new StreamWriter(path1, false, Encoding.Unicode))
      {
        streamWriter.WriteLine(this.textBox_0.Text);
        streamWriter.WriteLine(this.checkBox_3.Checked.ToString());
        if (this.checkBox_1.Checked)
          streamWriter.WriteLine(this.dateTimePicker_0.Value.Ticks);
      }
    }
    else if (this.checkBox_1.Checked)
    {
      using (StreamWriter streamWriter = new StreamWriter(path1, false, Encoding.Unicode))
      {
        streamWriter.WriteLine(Module.a("쪨좪캬", int_0));
        streamWriter.WriteLine(Module.a("쪨좪캬", int_0));
        streamWriter.WriteLine(this.dateTimePicker_0.Value.Ticks);
      }
    }
    string path2 = c.string_2 + Module.a("\uF5A8\uF8AA\uF2AC춮\uDEB0\uDCB2솴\uE8B6쪸閺즼잾뗀", int_0);
    if (File.Exists(path2))
      File.Delete(path2);
    if (this.checkBox_2.Checked)
    {
      int int32;
      try
      {
        int32 = Convert.ToInt32(this.comboBox_0.Text);
      }
      catch
      {
        int num = (int) MessageBox.Show(Module.a("直\uDFAA첬\uDDAE얰鎲솴\uD8B6馸즺좼톾\uE1C0ꋂꏄ돆곈맊\uEDCCꋎ룐뷒ꃔꏖ볘\uA8DA\uFDDC髞鏠釢諤闦죨", int_0));
        this.comboBox_0.Focus();
        return;
      }
      if (int32 >= 5 && int32 <= 15)
      {
        ae.smethod_0(int32 * 60);
        using (StreamWriter streamWriter = new StreamWriter(path2, false, Encoding.Unicode))
        {
          streamWriter.WriteLine(Module.a("\uDDA8\uD9AA\uD8AC쪮", int_0));
          streamWriter.WriteLine(this.comboBox_0.SelectedIndex.ToString());
        }
      }
      else
      {
        int num = (int) MessageBox.Show(Module.a("直\uDFAA첬\uDDAE얰鎲솴\uD8B6馸즺좼톾\uE1C0ꋂꏄ돆곈맊\uEDCCꋎ룐뷒ꃔꏖ볘\uA8DA\uFDDC髞鏠釢諤闦죨", int_0));
        this.comboBox_0.Focus();
        return;
      }
    }
    else
      ae.smethod_2();
    this.DialogResult = DialogResult.OK;
  }

  private void button_2_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.Cancel;

  private void method_0(object sender, EventArgs e)
  {
  }

  private void checkBox_0_CheckedChanged(object sender, EventArgs e)
  {
    if (!this.checkBox_0.Checked)
      this.groupBox_0.Enabled = false;
    else
      this.groupBox_0.Enabled = true;
    this.checkBox_3.Enabled = this.checkBox_0.Checked;
  }

  private void checkBox_1_CheckedChanged(object sender, EventArgs e)
  {
    if (!this.checkBox_1.Checked)
      this.groupBox_1.Enabled = false;
    else
      this.groupBox_1.Enabled = true;
  }

  private void method_1(object sender, EventArgs e)
  {
  }

  private void method_2(object sender, EventArgs e)
  {
  }

  private void checkBox_2_CheckedChanged(object sender, EventArgs e) => this.groupBox_2.Enabled = this.checkBox_2.Checked;

  private void ae_Load(object sender, EventArgs e)
  {
  }

    protected override void Dispose(bool disposing)
    {
        if (disposing && this.icontainer_0 != null)
            this.icontainer_0.Dispose();

        base.Dispose(disposing);
    }

    private void method_3()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ae));
    this.checkBox_0 = new CheckBox();
    this.groupBox_0 = new GroupBox();
    this.button_0 = new Button();
    this.label_0 = new Label();
    this.textBox_0 = new TextBox();
    this.groupBox_1 = new GroupBox();
    this.label_1 = new Label();
    this.label_2 = new Label();
    this.dateTimePicker_0 = new DateTimePicker();
    this.checkBox_1 = new CheckBox();
    this.button_1 = new Button();
    this.button_2 = new Button();
    this.checkBox_2 = new CheckBox();
    this.groupBox_2 = new GroupBox();
    this.comboBox_0 = new ComboBox();
    this.label_3 = new Label();
    this.label_4 = new Label();
    this.checkBox_3 = new CheckBox();
    this.groupBox_0.SuspendLayout();
    this.groupBox_1.SuspendLayout();
    this.groupBox_2.SuspendLayout();
    this.SuspendLayout();
    this.checkBox_0.AccessibleDescription = (string) null;
    this.checkBox_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.checkBox_0, Module.a("\uDBB7특\uD9BB\uDDBDꮿ胁ꯃ뻅劉", 18));
    this.checkBox_0.BackgroundImage = (Image) null;
    this.checkBox_0.Font = (Font) null;
    this.checkBox_0.Name = Module.a("\uDBB7특\uD9BB\uDDBDꮿ胁ꯃ뻅劉", 18);
    this.checkBox_0.UseVisualStyleBackColor = true;
    this.checkBox_0.CheckedChanged += new EventHandler(this.checkBox_0_CheckedChanged);
    this.groupBox_0.AccessibleDescription = (string) null;
    this.groupBox_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.groupBox_0, Module.a("\uDFB7좹펻쮽낿胁ꯃ뻅劉", 18));
    this.groupBox_0.BackgroundImage = (Image) null;
    this.groupBox_0.Controls.Add((Control) this.button_0);
    this.groupBox_0.Controls.Add((Control) this.label_0);
    this.groupBox_0.Controls.Add((Control) this.textBox_0);
    this.groupBox_0.Font = (Font) null;
    this.groupBox_0.Name = Module.a("\uDFB7좹펻쮽낿胁ꯃ뻅劉", 18);
    this.groupBox_0.TabStop = false;
    this.button_0.AccessibleDescription = (string) null;
    this.button_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.button_0, Module.a("\uDAB7쾹좻쪽꾿곁\uF5C3", 18));
    this.button_0.BackgroundImage = (Image) null;
    this.button_0.Font = (Font) null;
    this.button_0.Name = Module.a("\uDAB7쾹좻쪽꾿곁\uF5C3", 18);
    this.button_0.UseVisualStyleBackColor = true;
    this.button_0.Click += new EventHandler(this.button_0_Click);
    this.label_0.AccessibleDescription = (string) null;
    this.label_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_0, Module.a("풷\uDBB9\uDEBB\uDBBD겿\uF3C1", 18));
    this.label_0.Font = (Font) null;
    this.label_0.Name = Module.a("풷\uDBB9\uDEBB\uDBBD겿\uF3C1", 18);
    this.textBox_0.AccessibleDescription = (string) null;
    this.textBox_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.textBox_0, Module.a("첷\uDFB9쒻쪽芿귁볃\uF7C5", 18));
    this.textBox_0.BackgroundImage = (Image) null;
    this.textBox_0.Font = (Font) null;
    this.textBox_0.Name = Module.a("첷\uDFB9쒻쪽芿귁볃\uF7C5", 18);
    this.groupBox_1.AccessibleDescription = (string) null;
    this.groupBox_1.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.groupBox_1, Module.a("\uDFB7좹펻쮽낿胁ꯃ뻅難", 18));
    this.groupBox_1.BackgroundImage = (Image) null;
    this.groupBox_1.Controls.Add((Control) this.label_1);
    this.groupBox_1.Controls.Add((Control) this.label_2);
    this.groupBox_1.Controls.Add((Control) this.dateTimePicker_0);
    this.groupBox_1.Font = (Font) null;
    this.groupBox_1.Name = Module.a("\uDFB7좹펻쮽낿胁ꯃ뻅難", 18);
    this.groupBox_1.TabStop = false;
    this.label_1.AccessibleDescription = (string) null;
    this.label_1.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_1, Module.a("풷\uDBB9\uDEBB\uDBBD겿\uF6C1", 18));
    this.label_1.Font = (Font) null;
    this.label_1.Name = Module.a("풷\uDBB9\uDEBB\uDBBD겿\uF6C1", 18);
    this.label_2.AccessibleDescription = (string) null;
    this.label_2.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_2, Module.a("풷\uDBB9\uDEBB\uDBBD겿\uF1C1", 18));
    this.label_2.Font = (Font) null;
    this.label_2.Name = Module.a("풷\uDBB9\uDEBB\uDBBD겿\uF1C1", 18);
    this.dateTimePicker_0.AccessibleDescription = (string) null;
    this.dateTimePicker_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.dateTimePicker_0, Module.a("\uDCB7\uDBB9좻\uDBBD钿ꯁ꧃ꏅ飇ꏉ꿋ꗍ뗏ꃑ\uE5D3", 18));
    this.dateTimePicker_0.BackgroundImage = (Image) null;
    this.dateTimePicker_0.CalendarFont = (Font) null;
    this.dateTimePicker_0.CustomFormat = (string) null;
    this.dateTimePicker_0.Font = (Font) null;
    this.dateTimePicker_0.Format = DateTimePickerFormat.Time;
    this.dateTimePicker_0.Name = Module.a("\uDCB7\uDBB9좻\uDBBD钿ꯁ꧃ꏅ飇ꏉ꿋ꗍ뗏ꃑ\uE5D3", 18);
    this.dateTimePicker_0.ShowUpDown = true;
    this.checkBox_1.AccessibleDescription = (string) null;
    this.checkBox_1.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.checkBox_1, Module.a("\uDBB7특\uD9BB\uDDBDꮿ胁ꯃ뻅難", 18));
    this.checkBox_1.BackgroundImage = (Image) null;
    this.checkBox_1.Font = (Font) null;
    this.checkBox_1.Name = Module.a("\uDBB7특\uD9BB\uDDBDꮿ胁ꯃ뻅難", 18);
    this.checkBox_1.UseVisualStyleBackColor = true;
    this.checkBox_1.CheckedChanged += new EventHandler(this.checkBox_1_CheckedChanged);
    this.button_1.AccessibleDescription = (string) null;
    this.button_1.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.button_1, Module.a("\uDAB7쾹좻쪽꾿곁\uF6C3", 18));
    this.button_1.BackgroundImage = (Image) null;
    this.button_1.Font = (Font) null;
    this.button_1.Name = Module.a("\uDAB7쾹좻쪽꾿곁\uF6C3", 18);
    this.button_1.UseVisualStyleBackColor = true;
    this.button_1.Click += new EventHandler(this.button_1_Click);
    this.button_2.AccessibleDescription = (string) null;
    this.button_2.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.button_2, Module.a("\uDAB7쾹좻쪽꾿곁\uF7C3", 18));
    this.button_2.BackgroundImage = (Image) null;
    this.button_2.Font = (Font) null;
    this.button_2.Name = Module.a("\uDAB7쾹좻쪽꾿곁\uF7C3", 18);
    this.button_2.UseVisualStyleBackColor = true;
    this.button_2.Click += new EventHandler(this.button_2_Click);
    this.checkBox_2.AccessibleDescription = (string) null;
    this.checkBox_2.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.checkBox_2, Module.a("\uDBB7특\uD9BB\uDDBDꮿ胁ꯃ뻅\uFBC7", 18));
    this.checkBox_2.BackgroundImage = (Image) null;
    this.checkBox_2.Font = (Font) null;
    this.checkBox_2.Name = Module.a("\uDBB7특\uD9BB\uDDBDꮿ胁ꯃ뻅\uFBC7", 18);
    this.checkBox_2.UseVisualStyleBackColor = true;
    this.checkBox_2.CheckedChanged += new EventHandler(this.checkBox_2_CheckedChanged);
    this.groupBox_2.AccessibleDescription = (string) null;
    this.groupBox_2.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.groupBox_2, Module.a("\uDFB7좹펻쮽낿胁ꯃ뻅ﻇ", 18));
    this.groupBox_2.BackgroundImage = (Image) null;
    this.groupBox_2.Controls.Add((Control) this.comboBox_0);
    this.groupBox_2.Controls.Add((Control) this.label_3);
    this.groupBox_2.Controls.Add((Control) this.label_4);
    this.groupBox_2.Font = (Font) null;
    this.groupBox_2.Name = Module.a("\uDFB7좹펻쮽낿胁ꯃ뻅ﻇ", 18);
    this.groupBox_2.TabStop = false;
    this.comboBox_0.AccessibleDescription = (string) null;
    this.comboBox_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.comboBox_0, Module.a("\uDBB7햹톻\uDCBD꾿胁ꯃ뻅劉", 18));
    this.comboBox_0.BackgroundImage = (Image) null;
    this.comboBox_0.Font = (Font) null;
    this.comboBox_0.FormattingEnabled = true;
    this.comboBox_0.Items.AddRange(new object[11]
    {
      (object) componentResourceManager.GetString(Module.a("\uDBB7햹톻\uDCBD꾿胁ꯃ뻅劉\uE4C9藋뫍뗏뿑\uA7D3", 18)),
      (object) componentResourceManager.GetString(Module.a("\uDBB7햹톻\uDCBD꾿胁ꯃ뻅劉\uE4C9藋뫍뗏뿑\uA7D3\uE7D5", 18)),
      (object) componentResourceManager.GetString(Module.a("\uDBB7햹톻\uDCBD꾿胁ꯃ뻅劉\uE4C9藋뫍뗏뿑\uA7D3\uE4D5", 18)),
      (object) componentResourceManager.GetString(Module.a("\uDBB7햹톻\uDCBD꾿胁ꯃ뻅劉\uE4C9藋뫍뗏뿑\uA7D3\uE5D5", 18)),
      (object) componentResourceManager.GetString(Module.a("\uDBB7햹톻\uDCBD꾿胁ꯃ뻅劉\uE4C9藋뫍뗏뿑\uA7D3\uE2D5", 18)),
      (object) componentResourceManager.GetString(Module.a("\uDBB7햹톻\uDCBD꾿胁ꯃ뻅劉\uE4C9藋뫍뗏뿑\uA7D3\uE3D5", 18)),
      (object) componentResourceManager.GetString(Module.a("\uDBB7햹톻\uDCBD꾿胁ꯃ뻅劉\uE4C9藋뫍뗏뿑\uA7D3\uE0D5", 18)),
      (object) componentResourceManager.GetString(Module.a("\uDBB7햹톻\uDCBD꾿胁ꯃ뻅劉\uE4C9藋뫍뗏뿑\uA7D3\uE1D5", 18)),
      (object) componentResourceManager.GetString(Module.a("\uDBB7햹톻\uDCBD꾿胁ꯃ뻅劉\uE4C9藋뫍뗏뿑\uA7D3\uEED5", 18)),
      (object) componentResourceManager.GetString(Module.a("\uDBB7햹톻\uDCBD꾿胁ꯃ뻅劉\uE4C9藋뫍뗏뿑\uA7D3\uEFD5", 18)),
      (object) componentResourceManager.GetString(Module.a("\uDBB7햹톻\uDCBD꾿胁ꯃ뻅劉\uE4C9藋뫍뗏뿑\uA7D3\uE7D5\uE8D7", 18))
    });
    this.comboBox_0.Name = Module.a("\uDBB7햹톻\uDCBD꾿胁ꯃ뻅劉", 18);
    this.label_3.AccessibleDescription = (string) null;
    this.label_3.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_3, Module.a("풷\uDBB9\uDEBB\uDBBD겿\uF3C1\uF0C3", 18));
    this.label_3.Font = (Font) null;
    this.label_3.Name = Module.a("풷\uDBB9\uDEBB\uDBBD겿\uF3C1\uF0C3", 18);
    this.label_4.AccessibleDescription = (string) null;
    this.label_4.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_4, Module.a("풷\uDBB9\uDEBB\uDBBD겿\uF3C1\uF7C3", 18));
    this.label_4.Font = (Font) null;
    this.label_4.Name = Module.a("풷\uDBB9\uDEBB\uDBBD겿\uF3C1\uF7C3", 18);
    this.checkBox_3.AccessibleDescription = (string) null;
    this.checkBox_3.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.checkBox_3, Module.a("\uDBB7특\uD9BB\uDDBDꮿ胁ꯃ뻅ﳇ", 18));
    this.checkBox_3.BackgroundImage = (Image) null;
    this.checkBox_3.Font = (Font) null;
    this.checkBox_3.Name = Module.a("\uDBB7특\uD9BB\uDDBDꮿ胁ꯃ뻅ﳇ", 18);
    this.checkBox_3.UseVisualStyleBackColor = true;
    this.AcceptButton = (IButtonControl) this.button_1;
    this.AccessibleDescription = (string) null;
    this.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this, Module.a("鲷캹풻ힽ뎿", 18));
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackgroundImage = (Image) null;
    this.ControlBox = false;
    this.Controls.Add((Control) this.checkBox_3);
    this.Controls.Add((Control) this.groupBox_2);
    this.Controls.Add((Control) this.groupBox_1);
    this.Controls.Add((Control) this.checkBox_2);
    this.Controls.Add((Control) this.checkBox_1);
    this.Controls.Add((Control) this.button_2);
    this.Controls.Add((Control) this.button_1);
    this.Controls.Add((Control) this.groupBox_0);
    this.Controls.Add((Control) this.checkBox_0);
    this.Font = (Font) null;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Icon = (Icon) null;
    this.Name = Module.a("醴쾹좻톽貿귁ꗃꋅ", 18);
    this.Load += new EventHandler(this.ae_Load);
    this.groupBox_0.ResumeLayout(false);
    this.groupBox_0.PerformLayout();
    this.groupBox_1.ResumeLayout(false);
    this.groupBox_1.PerformLayout();
    this.groupBox_2.ResumeLayout(false);
    this.groupBox_2.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
