// Decompiled with JetBrains decompiler
// Type: u
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class u : Form
{
  private IContainer icontainer_0;
  private GroupBox groupBox_0;
  private ComboBox comboBox_0;
  private Label label_0;
  private CheckBox checkBox_0;
  private Button button_0;
  private Button button_1;
  private ComboBox comboBox_1;
  private Label label_1;
  private ComboBox comboBox_2;
  private Label label_2;

  public u()
  {
    int int_0 = 12;
    // ISSUE: explicit constructor call
//    base.\u002Ector();
    this.method_0();
    this.comboBox_0.Items.Clear();
    this.comboBox_1.Items.Clear();
    this.comboBox_2.Items.Clear();
    if (c.byte_1 == (byte) 2)
    {
      this.comboBox_0.Items.Add((object) Module.a("莱蒳蚵鶷", int_0));
      this.comboBox_0.Items.Add((object) Module.a("讱貳颵讷龹", int_0));
      this.comboBox_0.Items.Add((object) Module.a("讱芳颵辷龹", int_0));
      this.comboBox_0.Items.Add((object) Module.a("讱膳鎵", int_0));
      this.comboBox_0.Items.Add((object) Module.a("讱螳颵讷龹", int_0));
      this.comboBox_0.Items.Add((object) Module.a("讱薳颵辷龹", int_0));
      this.comboBox_0.Items.Add((object) Module.a("讱蒳鎵", int_0));
      this.comboBox_0.Items.Add((object) Module.a("誱貳颵讷龹", int_0));
      this.comboBox_0.Items.Add((object) Module.a("誱芳颵辷龹", int_0));
      this.comboBox_0.Items.Add((object) Module.a("誱膳鎵", int_0));
      this.comboBox_0.Items.Add((object) Module.a("誱螳颵讷龹", int_0));
      this.comboBox_0.Items.Add((object) Module.a("誱薳颵辷龹", int_0));
      this.comboBox_0.Items.Add((object) Module.a("誱蒳鎵", int_0));
      this.comboBox_0.Items.Add((object) Module.a("薱貳颵讷龹", int_0));
      this.comboBox_0.Items.Add((object) Module.a("薱芳颵辷龹", int_0));
      this.comboBox_0.Items.Add((object) Module.a("薱膳鎵", int_0));
      this.comboBox_1.Items.Add((object) Module.a("莱蒳蚵鶷", int_0));
      this.comboBox_1.Items.Add((object) Module.a("讱貳颵讷龹", int_0));
      this.comboBox_1.Items.Add((object) Module.a("讱芳颵辷龹", int_0));
      this.comboBox_1.Items.Add((object) Module.a("讱膳鎵", int_0));
      this.comboBox_1.Items.Add((object) Module.a("讱螳颵讷龹", int_0));
      this.comboBox_1.Items.Add((object) Module.a("讱薳颵辷龹", int_0));
      this.comboBox_1.Items.Add((object) Module.a("讱蒳鎵", int_0));
      this.comboBox_1.Items.Add((object) Module.a("誱貳颵讷龹", int_0));
      this.comboBox_1.Items.Add((object) Module.a("誱芳颵辷龹", int_0));
      this.comboBox_1.Items.Add((object) Module.a("誱膳鎵", int_0));
      this.comboBox_1.Items.Add((object) Module.a("誱螳颵讷龹", int_0));
      this.comboBox_1.Items.Add((object) Module.a("誱薳颵辷龹", int_0));
      this.comboBox_1.Items.Add((object) Module.a("誱蒳鎵", int_0));
      this.comboBox_1.Items.Add((object) Module.a("薱貳颵讷龹", int_0));
      this.comboBox_1.Items.Add((object) Module.a("薱芳颵辷龹", int_0));
      this.comboBox_1.Items.Add((object) Module.a("薱膳鎵", int_0));
      this.comboBox_2.Items.Add((object) Module.a("莱蒳蚵鶷", int_0));
      this.comboBox_2.Items.Add((object) Module.a("讱貳颵讷龹", int_0));
      this.comboBox_2.Items.Add((object) Module.a("讱芳颵辷龹", int_0));
      this.comboBox_2.Items.Add((object) Module.a("讱膳鎵", int_0));
      this.comboBox_2.Items.Add((object) Module.a("讱螳颵讷龹", int_0));
      this.comboBox_2.Items.Add((object) Module.a("讱薳颵辷龹", int_0));
      this.comboBox_2.Items.Add((object) Module.a("讱蒳鎵", int_0));
      this.comboBox_2.Items.Add((object) Module.a("誱貳颵讷龹", int_0));
      this.comboBox_2.Items.Add((object) Module.a("誱芳颵辷龹", int_0));
      this.comboBox_2.Items.Add((object) Module.a("誱膳鎵", int_0));
      this.comboBox_2.Items.Add((object) Module.a("誱螳颵讷龹", int_0));
      this.comboBox_2.Items.Add((object) Module.a("誱薳颵辷龹", int_0));
      this.comboBox_2.Items.Add((object) Module.a("誱蒳鎵", int_0));
      this.comboBox_2.Items.Add((object) Module.a("薱貳颵讷龹", int_0));
      this.comboBox_2.Items.Add((object) Module.a("薱芳颵辷龹", int_0));
      this.comboBox_2.Items.Add((object) Module.a("薱膳鎵", int_0));
    }
    if (c.byte_1 == (byte) 1)
    {
      this.comboBox_0.Items.Add((object) Module.a("莱蒳\uDBB5醴", int_0));
      this.comboBox_0.Items.Add((object) Module.a("莱薳\uDBB5醴", int_0));
      this.comboBox_0.Items.Add((object) Module.a("莱蚳\uDBB5醴", int_0));
      this.comboBox_0.Items.Add((object) Module.a("莱螳\uDBB5醴", int_0));
      this.comboBox_0.Items.Add((object) Module.a("莱肳\uDBB5醴", int_0));
      this.comboBox_0.Items.Add((object) Module.a("莱膳\uDBB5醴", int_0));
      this.comboBox_0.Items.Add((object) Module.a("莱芳\uDBB5醴", int_0));
      this.comboBox_0.Items.Add((object) Module.a("莱莳\uDBB5醴", int_0));
      this.comboBox_0.Items.Add((object) Module.a("莱貳\uDBB5醴", int_0));
      this.comboBox_0.Items.Add((object) Module.a("莱足\uDBB5醴", int_0));
      this.comboBox_0.Items.Add((object) Module.a("肱蒳\uDBB5醴", int_0));
      this.comboBox_0.Items.Add((object) Module.a("肱薳\uDBB5醴", int_0));
      this.comboBox_0.Items.Add((object) Module.a("肱蚳\uDBB5醴", int_0));
      this.comboBox_0.Items.Add((object) Module.a("肱螳\uDBB5醴", int_0));
      this.comboBox_0.Items.Add((object) Module.a("肱肳\uDBB5醴", int_0));
      this.comboBox_0.Items.Add((object) Module.a("肱膳\uDBB5醴", int_0));
      this.comboBox_0.Items.Add((object) Module.a("肱芳\uDBB5醴", int_0));
      this.comboBox_0.Items.Add((object) Module.a("肱莳\uDBB5醴", int_0));
      this.comboBox_0.Items.Add((object) Module.a("肱貳\uDBB5醴", int_0));
      this.comboBox_0.Items.Add((object) Module.a("肱足\uDBB5醴", int_0));
      this.comboBox_0.Items.Add((object) Module.a("膱蒳\uDBB5醴", int_0));
      this.comboBox_0.Items.Add((object) Module.a("膱薳\uDBB5醴", int_0));
      this.comboBox_0.Items.Add((object) Module.a("膱蚳\uDBB5醴", int_0));
      this.comboBox_0.Items.Add((object) Module.a("膱螳\uDBB5醴", int_0));
      this.comboBox_0.Items.Add((object) Module.a("膱肳\uDBB5醴", int_0));
      this.comboBox_0.Items.Add((object) Module.a("膱膳\uDBB5醴", int_0));
      this.comboBox_0.Items.Add((object) Module.a("膱芳\uDBB5醴", int_0));
      this.comboBox_0.Items.Add((object) Module.a("膱莳\uDBB5醴", int_0));
      this.comboBox_0.Items.Add((object) Module.a("膱貳\uDBB5醴", int_0));
      this.comboBox_0.Items.Add((object) Module.a("膱足\uDBB5醴", int_0));
      this.comboBox_0.Items.Add((object) Module.a("蚱蒳\uDBB5醴", int_0));
      this.comboBox_0.Items.Add((object) Module.a("蚱薳\uDBB5醴", int_0));
      this.comboBox_1.Items.Add((object) Module.a("莱蒳\uDBB5醴", int_0));
      this.comboBox_1.Items.Add((object) Module.a("莱薳\uDBB5醴", int_0));
      this.comboBox_1.Items.Add((object) Module.a("莱蚳\uDBB5醴", int_0));
      this.comboBox_1.Items.Add((object) Module.a("莱螳\uDBB5醴", int_0));
      this.comboBox_1.Items.Add((object) Module.a("莱肳\uDBB5醴", int_0));
      this.comboBox_1.Items.Add((object) Module.a("莱膳\uDBB5醴", int_0));
      this.comboBox_1.Items.Add((object) Module.a("莱芳\uDBB5醴", int_0));
      this.comboBox_1.Items.Add((object) Module.a("莱莳\uDBB5醴", int_0));
      this.comboBox_1.Items.Add((object) Module.a("莱貳\uDBB5醴", int_0));
      this.comboBox_1.Items.Add((object) Module.a("莱足\uDBB5醴", int_0));
      this.comboBox_1.Items.Add((object) Module.a("肱蒳\uDBB5醴", int_0));
      this.comboBox_1.Items.Add((object) Module.a("肱薳\uDBB5醴", int_0));
      this.comboBox_1.Items.Add((object) Module.a("肱蚳\uDBB5醴", int_0));
      this.comboBox_1.Items.Add((object) Module.a("肱螳\uDBB5醴", int_0));
      this.comboBox_1.Items.Add((object) Module.a("肱肳\uDBB5醴", int_0));
      this.comboBox_1.Items.Add((object) Module.a("肱膳\uDBB5醴", int_0));
      this.comboBox_1.Items.Add((object) Module.a("肱芳\uDBB5醴", int_0));
      this.comboBox_1.Items.Add((object) Module.a("肱莳\uDBB5醴", int_0));
      this.comboBox_1.Items.Add((object) Module.a("肱貳\uDBB5醴", int_0));
      this.comboBox_1.Items.Add((object) Module.a("肱足\uDBB5醴", int_0));
      this.comboBox_1.Items.Add((object) Module.a("膱蒳\uDBB5醴", int_0));
      this.comboBox_1.Items.Add((object) Module.a("膱薳\uDBB5醴", int_0));
      this.comboBox_1.Items.Add((object) Module.a("膱蚳\uDBB5醴", int_0));
      this.comboBox_1.Items.Add((object) Module.a("膱螳\uDBB5醴", int_0));
      this.comboBox_1.Items.Add((object) Module.a("膱肳\uDBB5醴", int_0));
      this.comboBox_1.Items.Add((object) Module.a("膱膳\uDBB5醴", int_0));
      this.comboBox_1.Items.Add((object) Module.a("膱芳\uDBB5醴", int_0));
      this.comboBox_1.Items.Add((object) Module.a("膱莳\uDBB5醴", int_0));
      this.comboBox_1.Items.Add((object) Module.a("膱貳\uDBB5醴", int_0));
      this.comboBox_1.Items.Add((object) Module.a("膱足\uDBB5醴", int_0));
      this.comboBox_1.Items.Add((object) Module.a("蚱蒳\uDBB5醴", int_0));
      this.comboBox_1.Items.Add((object) Module.a("蚱薳\uDBB5醴", int_0));
      this.comboBox_2.Items.Add((object) Module.a("莱蒳\uDBB5醴", int_0));
      this.comboBox_2.Items.Add((object) Module.a("莱薳\uDBB5醴", int_0));
      this.comboBox_2.Items.Add((object) Module.a("莱蚳\uDBB5醴", int_0));
      this.comboBox_2.Items.Add((object) Module.a("莱螳\uDBB5醴", int_0));
      this.comboBox_2.Items.Add((object) Module.a("莱肳\uDBB5醴", int_0));
      this.comboBox_2.Items.Add((object) Module.a("莱膳\uDBB5醴", int_0));
      this.comboBox_2.Items.Add((object) Module.a("莱芳\uDBB5醴", int_0));
      this.comboBox_2.Items.Add((object) Module.a("莱莳\uDBB5醴", int_0));
      this.comboBox_2.Items.Add((object) Module.a("莱貳\uDBB5醴", int_0));
      this.comboBox_2.Items.Add((object) Module.a("莱足\uDBB5醴", int_0));
      this.comboBox_2.Items.Add((object) Module.a("肱蒳\uDBB5醴", int_0));
      this.comboBox_2.Items.Add((object) Module.a("肱薳\uDBB5醴", int_0));
      this.comboBox_2.Items.Add((object) Module.a("肱蚳\uDBB5醴", int_0));
      this.comboBox_2.Items.Add((object) Module.a("肱螳\uDBB5醴", int_0));
      this.comboBox_2.Items.Add((object) Module.a("肱肳\uDBB5醴", int_0));
      this.comboBox_2.Items.Add((object) Module.a("肱膳\uDBB5醴", int_0));
      this.comboBox_2.Items.Add((object) Module.a("肱芳\uDBB5醴", int_0));
      this.comboBox_2.Items.Add((object) Module.a("肱莳\uDBB5醴", int_0));
      this.comboBox_2.Items.Add((object) Module.a("肱貳\uDBB5醴", int_0));
      this.comboBox_2.Items.Add((object) Module.a("肱足\uDBB5醴", int_0));
      this.comboBox_2.Items.Add((object) Module.a("膱蒳\uDBB5醴", int_0));
      this.comboBox_2.Items.Add((object) Module.a("膱薳\uDBB5醴", int_0));
      this.comboBox_2.Items.Add((object) Module.a("膱蚳\uDBB5醴", int_0));
      this.comboBox_2.Items.Add((object) Module.a("膱螳\uDBB5醴", int_0));
      this.comboBox_2.Items.Add((object) Module.a("膱肳\uDBB5醴", int_0));
      this.comboBox_2.Items.Add((object) Module.a("膱膳\uDBB5醴", int_0));
      this.comboBox_2.Items.Add((object) Module.a("膱芳\uDBB5醴", int_0));
      this.comboBox_2.Items.Add((object) Module.a("膱莳\uDBB5醴", int_0));
      this.comboBox_2.Items.Add((object) Module.a("膱貳\uDBB5醴", int_0));
      this.comboBox_2.Items.Add((object) Module.a("膱足\uDBB5醴", int_0));
      this.comboBox_2.Items.Add((object) Module.a("蚱蒳\uDBB5醴", int_0));
      this.comboBox_2.Items.Add((object) Module.a("蚱薳\uDBB5醴", int_0));
    }
    this.checkBox_0.Checked = c.byte_2 != (byte) 0;
    this.comboBox_0.SelectedIndex = (int) c.byte_3;
    this.comboBox_1.SelectedIndex = (int) c.byte_4;
    this.comboBox_2.SelectedIndex = (int) c.byte_5;
  }

  private void button_0_Click(object sender, EventArgs e)
  {
    c.byte_2 = this.checkBox_0.Checked ? (byte) 85 : (byte) 0;
    c.byte_3 = (byte) this.comboBox_0.SelectedIndex;
    c.byte_4 = (byte) this.comboBox_1.SelectedIndex;
    c.byte_5 = (byte) this.comboBox_2.SelectedIndex;
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (u));
    this.groupBox_0 = new GroupBox();
    this.comboBox_2 = new ComboBox();
    this.label_2 = new Label();
    this.comboBox_1 = new ComboBox();
    this.label_1 = new Label();
    this.comboBox_0 = new ComboBox();
    this.label_0 = new Label();
    this.checkBox_0 = new CheckBox();
    this.button_0 = new Button();
    this.button_1 = new Button();
    this.groupBox_0.SuspendLayout();
    this.SuspendLayout();
    this.groupBox_0.AccessibleDescription = (string) null;
    this.groupBox_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.groupBox_0, Module.a("햱욳\uD9B5춷쪹ﺻ톽뢿\uF3C1", 12));
    this.groupBox_0.BackgroundImage = (Image) null;
    this.groupBox_0.Controls.Add((Control) this.comboBox_2);
    this.groupBox_0.Controls.Add((Control) this.label_2);
    this.groupBox_0.Controls.Add((Control) this.comboBox_1);
    this.groupBox_0.Controls.Add((Control) this.label_1);
    this.groupBox_0.Controls.Add((Control) this.comboBox_0);
    this.groupBox_0.Controls.Add((Control) this.label_0);
    this.groupBox_0.Controls.Add((Control) this.checkBox_0);
    this.groupBox_0.Font = (Font) null;
    this.groupBox_0.Name = Module.a("햱욳\uD9B5춷쪹ﺻ톽뢿\uF3C1", 12);
    this.groupBox_0.TabStop = false;
    this.comboBox_2.AccessibleDescription = (string) null;
    this.comboBox_2.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.comboBox_2, Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF1C1", 12));
    this.comboBox_2.BackgroundImage = (Image) null;
    this.comboBox_2.Font = (Font) null;
    this.comboBox_2.FormattingEnabled = true;
    this.comboBox_2.Items.AddRange(new object[16]
    {
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF1C1\uEAC3迅볇꿉ꇋ뷍", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF1C1\uEAC3迅볇꿉ꇋ뷍\uE1CF", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF1C1\uEAC3迅볇꿉ꇋ뷍\uE2CF", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF1C1\uEAC3迅볇꿉ꇋ뷍\uE3CF", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF1C1\uEAC3迅볇꿉ꇋ뷍\uE4CF", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF1C1\uEAC3迅볇꿉ꇋ뷍\uE5CF", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF1C1\uEAC3迅볇꿉ꇋ뷍\uE6CF", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF1C1\uEAC3迅볇꿉ꇋ뷍\uE7CF", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF1C1\uEAC3迅볇꿉ꇋ뷍\uE8CF", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF1C1\uEAC3迅볇꿉ꇋ뷍\uE9CF", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF1C1\uEAC3迅볇꿉ꇋ뷍\uE1CF\uE2D1", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF1C1\uEAC3迅볇꿉ꇋ뷍\uE1CF\uE3D1", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF1C1\uEAC3迅볇꿉ꇋ뷍\uE1CF\uE0D1", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF1C1\uEAC3迅볇꿉ꇋ뷍\uE1CF\uE1D1", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF1C1\uEAC3迅볇꿉ꇋ뷍\uE1CF\uE6D1", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF1C1\uEAC3迅볇꿉ꇋ뷍\uE1CF\uE7D1", 12))
    });
    this.comboBox_2.Name = Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF1C1", 12);
    this.label_2.AccessibleDescription = (string) null;
    this.label_2.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_2, Module.a("\uDEB1햳풵\uDDB7횹辻", 12));
    this.label_2.Font = (Font) null;
    this.label_2.Name = Module.a("\uDEB1햳풵\uDDB7횹辻", 12);
    this.comboBox_1.AccessibleDescription = (string) null;
    this.comboBox_1.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.comboBox_1, Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF0C1", 12));
    this.comboBox_1.BackgroundImage = (Image) null;
    this.comboBox_1.Font = (Font) null;
    this.comboBox_1.FormattingEnabled = true;
    this.comboBox_1.Items.AddRange(new object[16]
    {
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF0C1\uEAC3迅볇꿉ꇋ뷍", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF0C1\uEAC3迅볇꿉ꇋ뷍\uE1CF", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF0C1\uEAC3迅볇꿉ꇋ뷍\uE2CF", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF0C1\uEAC3迅볇꿉ꇋ뷍\uE3CF", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF0C1\uEAC3迅볇꿉ꇋ뷍\uE4CF", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF0C1\uEAC3迅볇꿉ꇋ뷍\uE5CF", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF0C1\uEAC3迅볇꿉ꇋ뷍\uE6CF", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF0C1\uEAC3迅볇꿉ꇋ뷍\uE7CF", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF0C1\uEAC3迅볇꿉ꇋ뷍\uE8CF", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF0C1\uEAC3迅볇꿉ꇋ뷍\uE9CF", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF0C1\uEAC3迅볇꿉ꇋ뷍\uE1CF\uE2D1", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF0C1\uEAC3迅볇꿉ꇋ뷍\uE1CF\uE3D1", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF0C1\uEAC3迅볇꿉ꇋ뷍\uE1CF\uE0D1", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF0C1\uEAC3迅볇꿉ꇋ뷍\uE1CF\uE1D1", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF0C1\uEAC3迅볇꿉ꇋ뷍\uE1CF\uE6D1", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF0C1\uEAC3迅볇꿉ꇋ뷍\uE1CF\uE7D1", 12))
    });
    this.comboBox_1.Name = Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF0C1", 12);
    this.label_1.AccessibleDescription = (string) null;
    this.label_1.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_1, Module.a("\uDEB1햳풵\uDDB7횹躻", 12));
    this.label_1.Font = (Font) null;
    this.label_1.Name = Module.a("\uDEB1햳풵\uDDB7횹躻", 12);
    this.comboBox_0.AccessibleDescription = (string) null;
    this.comboBox_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.comboBox_0, Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF3C1", 12));
    this.comboBox_0.BackgroundImage = (Image) null;
    this.comboBox_0.Font = (Font) null;
    this.comboBox_0.FormattingEnabled = true;
    this.comboBox_0.Items.AddRange(new object[16]
    {
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF3C1\uEAC3迅볇꿉ꇋ뷍", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF3C1\uEAC3迅볇꿉ꇋ뷍\uE1CF", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF3C1\uEAC3迅볇꿉ꇋ뷍\uE2CF", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF3C1\uEAC3迅볇꿉ꇋ뷍\uE3CF", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF3C1\uEAC3迅볇꿉ꇋ뷍\uE4CF", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF3C1\uEAC3迅볇꿉ꇋ뷍\uE5CF", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF3C1\uEAC3迅볇꿉ꇋ뷍\uE6CF", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF3C1\uEAC3迅볇꿉ꇋ뷍\uE7CF", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF3C1\uEAC3迅볇꿉ꇋ뷍\uE8CF", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF3C1\uEAC3迅볇꿉ꇋ뷍\uE9CF", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF3C1\uEAC3迅볇꿉ꇋ뷍\uE1CF\uE2D1", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF3C1\uEAC3迅볇꿉ꇋ뷍\uE1CF\uE3D1", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF3C1\uEAC3迅볇꿉ꇋ뷍\uE1CF\uE0D1", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF3C1\uEAC3迅볇꿉ꇋ뷍\uE1CF\uE1D1", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF3C1\uEAC3迅볇꿉ꇋ뷍\uE1CF\uE6D1", 12)),
      (object) componentResourceManager.GetString(Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF3C1\uEAC3迅볇꿉ꇋ뷍\uE1CF\uE7D1", 12))
    });
    this.comboBox_0.Name = Module.a("톱\uDBB3\uDBB5\uDAB7햹ﺻ톽뢿\uF3C1", 12);
    this.label_0.AccessibleDescription = (string) null;
    this.label_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_0, Module.a("\uDEB1햳풵\uDDB7횹趻", 12));
    this.label_0.Font = (Font) null;
    this.label_0.Name = Module.a("\uDEB1햳풵\uDDB7횹趻", 12);
    this.checkBox_0.AccessibleDescription = (string) null;
    this.checkBox_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.checkBox_0, Module.a("톱\uDCB3펵\uDBB7톹ﺻ톽뢿\uF3C1", 12));
    this.checkBox_0.BackgroundImage = (Image) null;
    this.checkBox_0.Font = (Font) null;
    this.checkBox_0.Name = Module.a("톱\uDCB3펵\uDBB7톹ﺻ톽뢿\uF3C1", 12);
    this.checkBox_0.UseVisualStyleBackColor = true;
    this.button_0.AccessibleDescription = (string) null;
    this.button_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.button_0, Module.a("킱솳습첷햹튻辽", 12));
    this.button_0.BackgroundImage = (Image) null;
    this.button_0.Font = (Font) null;
    this.button_0.Name = Module.a("킱솳습첷햹튻辽", 12);
    this.button_0.UseVisualStyleBackColor = true;
    this.button_0.Click += new EventHandler(this.button_0_Click);
    this.button_1.AccessibleDescription = (string) null;
    this.button_1.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.button_1, Module.a("킱솳습첷햹튻貽", 12));
    this.button_1.BackgroundImage = (Image) null;
    this.button_1.DialogResult = DialogResult.Cancel;
    this.button_1.Font = (Font) null;
    this.button_1.Name = Module.a("킱솳습첷햹튻貽", 12);
    this.button_1.UseVisualStyleBackColor = true;
    this.button_1.Click += new EventHandler(this.button_1_Click);
    this.AcceptButton = (IButtonControl) this.button_0;
    this.AccessibleDescription = (string) null;
    this.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this, Module.a("隱삳\uDEB5톷즹", 12));
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackgroundImage = (Image) null;
    this.CancelButton = (IButtonControl) this.button_1;
    this.ControlBox = false;
    this.Controls.Add((Control) this.button_1);
    this.Controls.Add((Control) this.button_0);
    this.Controls.Add((Control) this.groupBox_0);
    this.Font = (Font) null;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Icon = (Icon) null;
    this.Name = Module.a("缾톳\uD8B5\uDFB7\uF6B9햻쮽龿釁ꇃ닅볇ꏉꋋ꧍", 12);
    this.TopMost = true;
    this.groupBox_0.ResumeLayout(false);
    this.groupBox_0.PerformLayout();
    this.ResumeLayout(false);
  }
}
