// Decompiled with JetBrains decompiler
// Type: g
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

public class g : Form
{
  private IContainer icontainer_0;
  private Label label_0;
  private Label label_1;
  private Label label_2;
  private TextBox textBox_0;
  private TextBox textBox_1;
  private TextBox textBox_2;
  private GroupBox groupBox_0;
  private Button button_0;
  private Label label_3;
  private Label label_4;
  private Label label_5;

    protected override void Dispose(bool disposing)
    {
        if (disposing && this.icontainer_0 != null)
            this.icontainer_0.Dispose();

        base.Dispose(disposing);
    }

    private void method_0()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (g));
    this.label_0 = new Label();
    this.label_1 = new Label();
    this.label_2 = new Label();
    this.textBox_0 = new TextBox();
    this.textBox_1 = new TextBox();
    this.textBox_2 = new TextBox();
    this.groupBox_0 = new GroupBox();
    this.label_3 = new Label();
    this.label_4 = new Label();
    this.label_5 = new Label();
    this.button_0 = new Button();
    this.groupBox_0.SuspendLayout();
    this.SuspendLayout();
    this.label_0.AccessibleDescription = (string) null;
    this.label_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_0, Module.a("슭톯킱톳\uDAB5覷", 8));
    this.label_0.Font = (Font) null;
    this.label_0.Name = Module.a("슭톯킱톳\uDAB5覷", 8);
    this.label_1.AccessibleDescription = (string) null;
    this.label_1.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_1, Module.a("슭톯킱톳\uDAB5誷", 8));
    this.label_1.Font = (Font) null;
    this.label_1.Name = Module.a("슭톯킱톳\uDAB5誷", 8);
    this.label_2.AccessibleDescription = (string) null;
    this.label_2.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_2, Module.a("슭톯킱톳\uDAB5讷", 8));
    this.label_2.Font = (Font) null;
    this.label_2.Name = Module.a("슭톯킱톳\uDAB5讷", 8);
    this.textBox_0.AccessibleDescription = (string) null;
    this.textBox_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.textBox_0, Module.a("\uDAAD햯쪱삳\uF4B5ힷ승趻", 8));
    this.textBox_0.BackgroundImage = (Image) null;
    this.textBox_0.Font = (Font) null;
    this.textBox_0.Name = Module.a("\uDAAD햯쪱삳\uF4B5ힷ승趻", 8);
    this.textBox_1.AccessibleDescription = (string) null;
    this.textBox_1.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.textBox_1, Module.a("\uDAAD햯쪱삳\uF4B5ힷ승躻", 8));
    this.textBox_1.BackgroundImage = (Image) null;
    this.textBox_1.Font = (Font) null;
    this.textBox_1.Name = Module.a("\uDAAD햯쪱삳\uF4B5ힷ승躻", 8);
    this.textBox_2.AccessibleDescription = (string) null;
    this.textBox_2.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.textBox_2, Module.a("\uDAAD햯쪱삳\uF4B5ힷ승辻", 8));
    this.textBox_2.BackgroundImage = (Image) null;
    this.textBox_2.Font = (Font) null;
    this.textBox_2.Name = Module.a("\uDAAD햯쪱삳\uF4B5ힷ승辻", 8);
    this.groupBox_0.AccessibleDescription = (string) null;
    this.groupBox_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.groupBox_0, Module.a("즭슯\uDDB1솳욵覆햹쒻辽", 8));
    this.groupBox_0.BackgroundImage = (Image) null;
    this.groupBox_0.Controls.Add((Control) this.label_3);
    this.groupBox_0.Controls.Add((Control) this.label_4);
    this.groupBox_0.Controls.Add((Control) this.label_5);
    this.groupBox_0.Controls.Add((Control) this.textBox_2);
    this.groupBox_0.Controls.Add((Control) this.label_0);
    this.groupBox_0.Controls.Add((Control) this.textBox_1);
    this.groupBox_0.Controls.Add((Control) this.label_1);
    this.groupBox_0.Controls.Add((Control) this.textBox_0);
    this.groupBox_0.Controls.Add((Control) this.label_2);
    this.groupBox_0.Font = (Font) null;
    this.groupBox_0.Name = Module.a("즭슯\uDDB1솳욵覆햹쒻辽", 8);
    this.groupBox_0.TabStop = false;
    this.label_3.AccessibleDescription = (string) null;
    this.label_3.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_3, Module.a("슭톯킱톳\uDAB5躷", 8));
    this.label_3.Font = (Font) null;
    this.label_3.Name = Module.a("슭톯킱톳\uDAB5躷", 8);
    this.label_4.AccessibleDescription = (string) null;
    this.label_4.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_4, Module.a("슭톯킱톳\uDAB5趷", 8));
    this.label_4.Font = (Font) null;
    this.label_4.Name = Module.a("슭톯킱톳\uDAB5趷", 8);
    this.label_5.AccessibleDescription = (string) null;
    this.label_5.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_5, Module.a("슭톯킱톳\uDAB5買", 8));
    this.label_5.Font = (Font) null;
    this.label_5.Name = Module.a("슭톯킱톳\uDAB5買", 8);
    this.button_0.AccessibleDescription = (string) null;
    this.button_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.button_0, Module.a("청얯욱삳\uD9B5횷讹", 8));
    this.button_0.BackgroundImage = (Image) null;
    this.button_0.Font = (Font) null;
    this.button_0.Name = Module.a("청얯욱삳\uD9B5횷讹", 8);
    this.button_0.UseVisualStyleBackColor = true;
    this.button_0.Click += new EventHandler(this.button_0_Click);
    this.AccessibleDescription = (string) null;
    this.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this, Module.a("読쒯\uDAB1\uDDB3억", 8));
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackgroundImage = (Image) null;
    this.ControlBox = false;
    this.Controls.Add((Control) this.button_0);
    this.Controls.Add((Control) this.groupBox_0);
    this.Font = (Font) null;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Icon = (Icon) null;
    this.Name = Module.a("\uEAADﶯ\uEAB1\uEBB3ힵ\uDCB7\uDEB9캻\uDBBD뎿뇁", 8);
    this.Load += new EventHandler(this.g_Load);
    this.groupBox_0.ResumeLayout(false);
    this.groupBox_0.PerformLayout();
    this.ResumeLayout(false);
  }

  public g() => this.method_0();

  private void method_1(string string_0)
  {
    MessageDialog aa = new MessageDialog();
    aa.label_0.Text = string_0;
    int num = (int) aa.ShowDialog();
  }

  private void button_0_Click(object sender, EventArgs e)
  {
    int int_0 = 6;
    int int32_1;
    try
    {
      int32_1 = Convert.ToInt32(this.textBox_0.Text);
    }
    catch
    {
      if (c.useEnglishLanguage)
        this.method_1(Module.a("ﾫ\uDAAD톯삱삳\uDFB5횷\uDDB9鲻\uDDBDꢿꏁ\uAAC3\uA8C5귇ꛉ\uECCBꯍꋏꃑ믓ꓕ輪", int_0));
      else
        this.method_1(Module.a("\uDB26旴\uAA3F\uE121ਸ\uD8CA뗹\uD9D2틃龽", int_0));
      this.textBox_0.Focus();
      return;
    }
    if (int32_1 >= 1)
    {
      if (int32_1 <= 2048)
      {
        int int32_2;
        try
        {
          int32_2 = Convert.ToInt32(this.textBox_1.Text);
        }
        catch
        {
          if (c.useEnglishLanguage)
            this.method_1(Module.a("\uEFAB욭톯\uDCB1\uDAB3펵풷骹쾻캽ꆿꇁ귃\uA8C5꿇\uEAC9꧋볍ꋏ뷑ꛓ\uF7D5", int_0));
          else
            this.method_1(Module.a("堾㨻\uAA3F\uE121ਸ\uD8CA뗹\uD9D2틃龽", int_0));
          this.textBox_1.Focus();
          return;
        }
        if (int32_2 >= 1)
        {
          if (int32_2 <= (int) byte.MaxValue)
          {
            int int32_3;
            try
            {
              int32_3 = Convert.ToInt32(this.textBox_2.Text);
            }
            catch
            {
              if (c.useEnglishLanguage)
                this.method_1(Module.a("\uE2AB\uDBAD\uDDAF킱톳쒵颷햹\uDABB麽ꎿ꫁귃뛅믇\uEAC9꧋볍ꋏ뷑ꛓ\uF7D5", int_0));
              else
                this.method_1(Module.a("̩\uE9DF샊峇ਸ\uD8CA뗹\uD9D2틃龽", int_0));
              this.textBox_2.Focus();
              return;
            }
            if (int32_3 >= 1 && int32_3 <= 2048)
            {
              c.int_5 = int32_1;
              c.int_6 = int32_2;
              c.int_7 = int32_3;
              string path = c.settingsPath + Module.a("\uF0AB\uEAAD\uDDAF쪱\uEBB3ힵ\uDCB7\uDEB9캻\uE1BD뎿\uA7C1냃\uF7C5믇돉듋ꗍ迏ꛑ䀘ꋕꃗ껙", int_0);
              if (File.Exists(path))
                File.Delete(path);
              using (StreamWriter streamWriter = new StreamWriter(path, false, Encoding.Unicode))
              {
                streamWriter.WriteLine(c.int_5.ToString());
                streamWriter.WriteLine(c.int_6.ToString());
                streamWriter.WriteLine(c.int_7.ToString());
              }
              this.DialogResult = DialogResult.OK;
              return;
            }
            if (c.useEnglishLanguage)
              this.method_1(Module.a("\uE2AB\uDBAD\uDDAF킱톳쒵颷햹\uDABB麽ꎿ꫁귃뛅믇\uEAC9꧋볍ꋏ뷑ꛓ\uF7D5", int_0));
            else
              this.method_1(Module.a("̩\uE9DF샊峇ਸ\uD8CA뗹\uD9D2틃龽", int_0));
            this.textBox_2.Focus();
            return;
          }
        }
        if (c.useEnglishLanguage)
          this.method_1(Module.a("\uEFAB욭톯\uDCB1\uDAB3펵풷骹쾻캽ꆿꇁ귃\uA8C5꿇\uEAC9꧋볍ꋏ뷑ꛓ\uF7D5", int_0));
        else
          this.method_1(Module.a("堾㨻\uAA3F\uE121ਸ\uD8CA뗹\uD9D2틃龽", int_0));
        this.textBox_1.Focus();
        return;
      }
    }
    if (c.useEnglishLanguage)
      this.method_1(Module.a("ﾫ\uDAAD톯삱삳\uDFB5횷\uDDB9鲻\uDDBDꢿꏁ\uAAC3\uA8C5귇ꛉ\uECCBꯍꋏꃑ믓ꓕ輪", int_0));
    else
      this.method_1(Module.a("\uDB26旴\uAA3F\uE121ਸ\uD8CA뗹\uD9D2틃龽", int_0));
    this.textBox_0.Focus();
  }

  private void g_Load(object sender, EventArgs e)
  {
    this.textBox_0.Text = c.int_5.ToString();
    this.textBox_1.Text = c.int_6.ToString();
    this.textBox_2.Text = c.int_7.ToString();
  }
}
