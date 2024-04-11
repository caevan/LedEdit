// Decompiled with JetBrains decompiler
// Type: b
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class b : Form
{
  private Label label_0;
  private Label label_1;
  private Button button_0;
  private ComboBox comboBox_0;
  private System.ComponentModel.Container container_0;

  public b()
  {
    this.method_0();
    this.comboBox_0.SelectedIndex = c.smethod_0() - 1;
  }

 
    protected override void Dispose(bool disposing)
    {
        if (disposing && this.container_0 != null)
            this.container_0.Dispose();

        base.Dispose(disposing);
    }
    private void method_0()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (b));
    this.label_0 = new Label();
    this.label_1 = new Label();
    this.button_0 = new Button();
    this.comboBox_0 = new ComboBox();
    this.SuspendLayout();
    this.label_0.AccessibleDescription = (string) null;
    this.label_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_0, Module.a("쪥즧좩즫슭膯", 0));
    this.label_0.Font = (Font) null;
    this.label_0.Name = Module.a("쪥즧좩즫슭膯", 0);
    this.label_1.AccessibleDescription = (string) null;
    this.label_1.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_1, Module.a("쪥즧좩즫슭芯", 0));
    this.label_1.Font = (Font) null;
    this.label_1.Name = Module.a("쪥즧좩즫슭芯", 0);
    this.button_0.AccessibleDescription = (string) null;
    this.button_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.button_0, Module.a("쒥\uDDA7\uDEA9\uD8AB솭\uDEAF莱", 0));
    this.button_0.BackgroundImage = (Image) null;
    this.button_0.Font = (Font) null;
    this.button_0.Name = Module.a("쒥\uDDA7\uDEA9\uD8AB솭\uDEAF莱", 0);
    this.button_0.Click += new EventHandler(this.button_0_Click);
    this.comboBox_0.AccessibleDescription = (string) null;
    this.comboBox_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.comboBox_0, Module.a("얥잧잩캫솭\uF2AF\uDDB1첳螵", 0));
    this.comboBox_0.BackgroundImage = (Image) null;
    this.comboBox_0.Font = (Font) null;
    this.comboBox_0.FormattingEnabled = true;
    this.comboBox_0.Items.AddRange(new object[30]
    {
      (object) componentResourceManager.GetString(Module.a("얥잧잩캫솭\uF2AF\uDDB1첳螵隷\uF3B9좻\uDBBD궿뇁", 0)),
      (object) componentResourceManager.GetString(Module.a("얥잧잩캫솭\uF2AF\uDDB1첳螵隷\uF3B9좻\uDBBD궿뇁\uF5C3", 0)),
      (object) componentResourceManager.GetString(Module.a("얥잧잩캫솭\uF2AF\uDDB1첳螵隷\uF3B9좻\uDBBD궿뇁\uF6C3", 0)),
      (object) componentResourceManager.GetString(Module.a("얥잧잩캫솭\uF2AF\uDDB1첳螵隷\uF3B9좻\uDBBD궿뇁\uF7C3", 0)),
      (object) componentResourceManager.GetString(Module.a("얥잧잩캫솭\uF2AF\uDDB1첳螵隷\uF3B9좻\uDBBD궿뇁\uF0C3", 0)),
      (object) componentResourceManager.GetString(Module.a("얥잧잩캫솭\uF2AF\uDDB1첳螵隷\uF3B9좻\uDBBD궿뇁\uF1C3", 0)),
      (object) componentResourceManager.GetString(Module.a("얥잧잩캫솭\uF2AF\uDDB1첳螵隷\uF3B9좻\uDBBD궿뇁\uF2C3", 0)),
      (object) componentResourceManager.GetString(Module.a("얥잧잩캫솭\uF2AF\uDDB1첳螵隷\uF3B9좻\uDBBD궿뇁\uF3C3", 0)),
      (object) componentResourceManager.GetString(Module.a("얥잧잩캫솭\uF2AF\uDDB1첳螵隷\uF3B9좻\uDBBD궿뇁ﳃ", 0)),
      (object) componentResourceManager.GetString(Module.a("얥잧잩캫솭\uF2AF\uDDB1첳螵隷\uF3B9좻\uDBBD궿뇁ﷃ", 0)),
      (object) componentResourceManager.GetString(Module.a("얥잧잩캫솭\uF2AF\uDDB1첳螵隷\uF3B9좻\uDBBD궿뇁\uF5C3\uF6C5", 0)),
      (object) componentResourceManager.GetString(Module.a("얥잧잩캫솭\uF2AF\uDDB1첳螵隷\uF3B9좻\uDBBD궿뇁\uF5C3\uF7C5", 0)),
      (object) componentResourceManager.GetString(Module.a("얥잧잩캫솭\uF2AF\uDDB1첳螵隷\uF3B9좻\uDBBD궿뇁\uF5C3\uF4C5", 0)),
      (object) componentResourceManager.GetString(Module.a("얥잧잩캫솭\uF2AF\uDDB1첳螵隷\uF3B9좻\uDBBD궿뇁\uF5C3\uF5C5", 0)),
      (object) componentResourceManager.GetString(Module.a("얥잧잩캫솭\uF2AF\uDDB1첳螵隷\uF3B9좻\uDBBD궿뇁\uF5C3\uF2C5", 0)),
      (object) componentResourceManager.GetString(Module.a("얥잧잩캫솭\uF2AF\uDDB1첳螵隷\uF3B9좻\uDBBD궿뇁\uF5C3\uF3C5", 0)),
      (object) componentResourceManager.GetString(Module.a("얥잧잩캫솭\uF2AF\uDDB1첳螵隷\uF3B9좻\uDBBD궿뇁\uF5C3\uF0C5", 0)),
      (object) componentResourceManager.GetString(Module.a("얥잧잩캫솭\uF2AF\uDDB1첳螵隷\uF3B9좻\uDBBD궿뇁\uF5C3\uF1C5", 0)),
      (object) componentResourceManager.GetString(Module.a("얥잧잩캫솭\uF2AF\uDDB1첳螵隷\uF3B9좻\uDBBD궿뇁\uF5C3ﻅ", 0)),
      (object) componentResourceManager.GetString(Module.a("얥잧잩캫솭\uF2AF\uDDB1첳螵隷\uF3B9좻\uDBBD궿뇁\uF5C3ￅ", 0)),
      (object) componentResourceManager.GetString(Module.a("얥잧잩캫솭\uF2AF\uDDB1첳螵隷\uF3B9좻\uDBBD궿뇁\uF6C3\uF6C5", 0)),
      (object) componentResourceManager.GetString(Module.a("얥잧잩캫솭\uF2AF\uDDB1첳螵隷\uF3B9좻\uDBBD궿뇁\uF6C3\uF7C5", 0)),
      (object) componentResourceManager.GetString(Module.a("얥잧잩캫솭\uF2AF\uDDB1첳螵隷\uF3B9좻\uDBBD궿뇁\uF6C3\uF4C5", 0)),
      (object) componentResourceManager.GetString(Module.a("얥잧잩캫솭\uF2AF\uDDB1첳螵隷\uF3B9좻\uDBBD궿뇁\uF6C3\uF5C5", 0)),
      (object) componentResourceManager.GetString(Module.a("얥잧잩캫솭\uF2AF\uDDB1첳螵隷\uF3B9좻\uDBBD궿뇁\uF6C3\uF2C5", 0)),
      (object) componentResourceManager.GetString(Module.a("얥잧잩캫솭\uF2AF\uDDB1첳螵隷\uF3B9좻\uDBBD궿뇁\uF6C3\uF3C5", 0)),
      (object) componentResourceManager.GetString(Module.a("얥잧잩캫솭\uF2AF\uDDB1첳螵隷\uF3B9좻\uDBBD궿뇁\uF6C3\uF0C5", 0)),
      (object) componentResourceManager.GetString(Module.a("얥잧잩캫솭\uF2AF\uDDB1첳螵隷\uF3B9좻\uDBBD궿뇁\uF6C3\uF1C5", 0)),
      (object) componentResourceManager.GetString(Module.a("얥잧잩캫솭\uF2AF\uDDB1첳螵隷\uF3B9좻\uDBBD궿뇁\uF6C3ﻅ", 0)),
      (object) componentResourceManager.GetString(Module.a("얥잧잩캫솭\uF2AF\uDDB1첳螵隷\uF3B9좻\uDBBD궿뇁\uF6C3ￅ", 0))
    });
    this.comboBox_0.Name = Module.a("얥잧잩캫솭\uF2AF\uDDB1첳螵", 0);
    this.comboBox_0.SelectedIndexChanged += new EventHandler(this.comboBox_0_SelectedIndexChanged);
    this.AcceptButton = (IButtonControl) this.button_0;
    this.AccessibleDescription = (string) null;
    this.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this, Module.a("芥\uDCA7슩얫\uDDAD", 0));
    this.BackgroundImage = (Image) null;
    this.ControlBox = false;
    this.Controls.Add((Control) this.comboBox_0);
    this.Controls.Add((Control) this.button_0);
    this.Controls.Add((Control) this.label_1);
    this.Controls.Add((Control) this.label_0);
    this.Font = (Font) null;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Icon = (Icon) null;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = Module.a("\uF5A5춧\uDEA9\uD8AB잭\uDEAF햱\uF2B3\uD9B5쪷ힹ", 0);
    this.ShowInTaskbar = false;
    this.TopMost = true;
    this.ResumeLayout(false);
  }

  private void button_0_Click(object sender, EventArgs e)
  {
    int int_0 = 12;
    try
    {
      Convert.ToInt32(this.comboBox_0.Text);
    }
    catch
    {
      this.method_1(Module.a("\uF7B1욳쒵ힷ좹鶻", int_0));
      return;
    }
    if (this.comboBox_0.SelectedIndex < 0)
    {
      this.method_1(Module.a("\uF7B1욳쒵ힷ좹鶻", int_0));
    }
    else
    {
      c.smethod_1(this.comboBox_0.SelectedIndex + 1);
      this.DialogResult = DialogResult.OK;
    }
  }

  private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
  {
  }

  private void method_1(string string_0)
  {
    MessageDialog aa = new MessageDialog();
    aa.label_0.Text = string_0;
    int num = (int) aa.ShowDialog();
  }
}
