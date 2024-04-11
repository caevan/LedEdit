// Decompiled with JetBrains decompiler
// Type: w
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class w : Form
{
  private byte byte_0;
  private byte byte_1;
  private byte byte_2;
  private IContainer icontainer_0;
  private Label label_0;
  private ComboBox comboBox_0;
  private ComboBox comboBox_1;
  private Label label_1;
  private ComboBox comboBox_2;
  private Label label_2;
  private ComboBox comboBox_3;
  private Label label_3;
  private GroupBox groupBox_0;
  private RadioButton radioButton_0;
  private RadioButton radioButton_1;
  private GroupBox groupBox_1;
  private Button button_0;
  private Button button_1;

  public w()
  {
    int int_0 = 9;
    // ISSUE: explicit constructor call
//    base.\u002Ector();
    this.method_0();
    this.comboBox_0.Items.Clear();
    this.comboBox_1.Items.Clear();
    this.comboBox_2.Items.Clear();
    this.comboBox_3.Items.Clear();
    switch (c.byte_20)
    {
      case 10:
        this.Text = Module.a("ﲮﲰ芲莴肶躸", int_0);
        this.comboBox_0.Items.Add((object) Module.a("麮莰鶲薴\uDAB6\uF8B8", int_0));
        this.comboBox_0.Items.Add((object) Module.a("麮覰鶲薴\uDAB6\uF8B8", int_0));
        this.comboBox_0.Items.Add((object) Module.a("鶮薰鶲薴\uDAB6\uF8B8", int_0));
        this.comboBox_0.Items.Add((object) Module.a("鲮膰鶲薴\uDAB6\uF8B8", int_0));
        this.comboBox_1.Items.Add((object) Module.a("麮薰鶲芴\uDAB6\uF8B8", int_0));
        this.comboBox_1.Items.Add((object) Module.a("麮蒰鶲肴\uDAB6\uF8B8", int_0));
        this.comboBox_1.Items.Add((object) Module.a("麮螰鶲膴\uDAB6\uF8B8", int_0));
        this.comboBox_1.Items.Add((object) Module.a("麮蚰鶲螴\uDAB6\uF8B8", int_0));
        this.comboBox_1.Items.Add((object) Module.a("麮覰鶲薴\uDAB6\uF8B8", int_0));
        this.comboBox_1.Items.Add((object) Module.a("麮覰鶲趴\uDAB6\uF8B8", int_0));
        this.comboBox_1.Items.Add((object) Module.a("麮袰鶲莴\uDAB6\uF8B8", int_0));
        this.comboBox_1.Items.Add((object) Module.a("鶮膰鶲膴\uDAB6\uF8B8", int_0));
        this.comboBox_2.Items.Add((object) Module.a("麮薰鶲芴\uDAB6\uF8B8", int_0));
        this.comboBox_2.Items.Add((object) Module.a("麮蒰鶲肴\uDAB6\uF8B8", int_0));
        this.comboBox_2.Items.Add((object) Module.a("麮螰鶲膴\uDAB6\uF8B8", int_0));
        this.comboBox_2.Items.Add((object) Module.a("麮蚰鶲螴\uDAB6\uF8B8", int_0));
        this.comboBox_2.Items.Add((object) Module.a("麮覰鶲薴\uDAB6\uF8B8", int_0));
        this.comboBox_2.Items.Add((object) Module.a("麮覰鶲趴\uDAB6\uF8B8", int_0));
        this.comboBox_2.Items.Add((object) Module.a("麮袰鶲莴\uDAB6\uF8B8", int_0));
        this.comboBox_2.Items.Add((object) Module.a("鶮膰鶲膴\uDAB6\uF8B8", int_0));
        this.comboBox_3.Items.Add((object) Module.a("麮薰鶲芴\uDAB6\uF8B8", int_0));
        this.comboBox_3.Items.Add((object) Module.a("麮蒰鶲肴\uDAB6\uF8B8", int_0));
        this.comboBox_3.Items.Add((object) Module.a("麮螰鶲膴\uDAB6\uF8B8", int_0));
        this.comboBox_3.Items.Add((object) Module.a("麮蚰鶲螴\uDAB6\uF8B8", int_0));
        this.comboBox_3.Items.Add((object) Module.a("麮覰鶲薴\uDAB6\uF8B8", int_0));
        this.comboBox_3.Items.Add((object) Module.a("麮覰鶲趴\uDAB6\uF8B8", int_0));
        this.comboBox_3.Items.Add((object) Module.a("麮袰鶲莴\uDAB6\uF8B8", int_0));
        this.comboBox_3.Items.Add((object) Module.a("鶮膰鶲膴\uDAB6\uF8B8", int_0));
        break;
      case 12:
        this.Text = Module.a("ﲮﲰ芲莴肶许趺", int_0);
        this.groupBox_1.Enabled = false;
        this.comboBox_0.Items.Add((object) Module.a("麮莰鶲螴\uDAB6\uF8B8", int_0));
        this.comboBox_0.Items.Add((object) Module.a("鶮薰鶲肴\uDAB6\uF8B8", int_0));
        this.comboBox_0.Items.Add((object) Module.a("麮覰鶲膴\uDAB6\uF8B8", int_0));
        this.comboBox_0.Items.Add((object) Module.a("鲮膰鶲莴\uDAB6\uF8B8", int_0));
        this.comboBox_1.Items.Add((object) Module.a("麮蒰鶲薴\uDAB6\uF8B8", int_0));
        this.comboBox_1.Items.Add((object) Module.a("麮蒰鶲貴\uDAB6\uF8B8", int_0));
        this.comboBox_1.Items.Add((object) Module.a("麮螰鶲芴\uDAB6\uF8B8", int_0));
        this.comboBox_1.Items.Add((object) Module.a("麮蚰鶲肴\uDAB6\uF8B8", int_0));
        this.comboBox_1.Items.Add((object) Module.a("麮覰鶲膴\uDAB6\uF8B8", int_0));
        this.comboBox_1.Items.Add((object) Module.a("麮袰鶲螴\uDAB6\uF8B8", int_0));
        this.comboBox_1.Items.Add((object) Module.a("鶮膰鶲蒴\uDAB6\uF8B8", int_0));
        this.comboBox_1.Items.Add((object) Module.a("鶮肰鶲薴\uDAB6\uF8B8", int_0));
        this.comboBox_2.Items.Add((object) Module.a("麮蒰鶲薴\uDAB6\uF8B8", int_0));
        this.comboBox_2.Items.Add((object) Module.a("麮蒰鶲貴\uDAB6\uF8B8", int_0));
        this.comboBox_2.Items.Add((object) Module.a("麮螰鶲芴\uDAB6\uF8B8", int_0));
        this.comboBox_2.Items.Add((object) Module.a("麮蚰鶲肴\uDAB6\uF8B8", int_0));
        this.comboBox_2.Items.Add((object) Module.a("麮覰鶲膴\uDAB6\uF8B8", int_0));
        this.comboBox_2.Items.Add((object) Module.a("麮袰鶲螴\uDAB6\uF8B8", int_0));
        this.comboBox_2.Items.Add((object) Module.a("鶮膰鶲蒴\uDAB6\uF8B8", int_0));
        this.comboBox_2.Items.Add((object) Module.a("鶮肰鶲薴\uDAB6\uF8B8", int_0));
        this.comboBox_3.Items.Add((object) Module.a("麮蒰鶲薴\uDAB6\uF8B8", int_0));
        this.comboBox_3.Items.Add((object) Module.a("麮蒰鶲貴\uDAB6\uF8B8", int_0));
        this.comboBox_3.Items.Add((object) Module.a("麮螰鶲芴\uDAB6\uF8B8", int_0));
        this.comboBox_3.Items.Add((object) Module.a("麮蚰鶲肴\uDAB6\uF8B8", int_0));
        this.comboBox_3.Items.Add((object) Module.a("麮覰鶲膴\uDAB6\uF8B8", int_0));
        this.comboBox_3.Items.Add((object) Module.a("麮袰鶲螴\uDAB6\uF8B8", int_0));
        this.comboBox_3.Items.Add((object) Module.a("鶮膰鶲蒴\uDAB6\uF8B8", int_0));
        this.comboBox_3.Items.Add((object) Module.a("鶮肰鶲薴\uDAB6\uF8B8", int_0));
        break;
    }
    byte num1 = (byte) ((uint) c.byte_3 >> 4);
    byte num2 = (byte) ((uint) c.byte_3 & 15U);
    byte num3 = (byte) ((uint) c.byte_4 >> 4);
    byte num4 = (byte) ((uint) c.byte_4 & 15U);
    this.comboBox_0.SelectedIndex = (int) num1;
    this.comboBox_1.SelectedIndex = (int) num2;
    this.comboBox_2.SelectedIndex = (int) num3;
    this.comboBox_3.SelectedIndex = (int) num4;
    this.byte_0 = num2;
    this.byte_1 = num3;
    this.byte_2 = num4;
    if (c.byte_5 == (byte) 0)
      this.radioButton_0.Checked = true;
    else
      this.radioButton_1.Checked = true;
  }

  private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
  {
    int int_0 = 2;
    this.comboBox_1.Items.Clear();
    this.comboBox_2.Items.Clear();
    this.comboBox_3.Items.Clear();
    switch (c.byte_20)
    {
      case 10:
        if (this.comboBox_0.SelectedIndex == 0)
        {
          this.comboBox_1.Items.Add((object) Module.a("醧蒩钫쎭\uF1AF", int_0));
          this.comboBox_1.Items.Add((object) Module.a("馧骩芫鶭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("馧骩芫鞭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("馧鮩芫鮭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("馧颩芫麭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("馧颩芫鮭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("馧馩芫龭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("馧馩芫颭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("醧蒩钫쎭\uF1AF", int_0));
          this.comboBox_2.Items.Add((object) Module.a("馧骩芫鶭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("馧骩芫鞭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("馧鮩芫鮭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("馧颩芫麭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("馧颩芫鮭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("馧馩芫龭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("馧馩芫颭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("醧蒩钫쎭\uF1AF", int_0));
          this.comboBox_3.Items.Add((object) Module.a("馧骩芫鶭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("馧骩芫鞭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("馧鮩芫鮭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("馧颩芫麭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("馧颩芫鮭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("馧馩芫龭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("馧馩芫颭\uDDAF\uF3B1", int_0));
          break;
        }
        if (this.comboBox_0.SelectedIndex == 1)
        {
          this.comboBox_1.Items.Add((object) Module.a("馧麩芫馭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("馧龩芫鮭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("馧鲩芫骭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("馧鶩芫鲭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("馧銩芫麭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("馧銩芫隭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("馧鎩芫颭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("骧骩芫骭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("馧麩芫馭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("馧龩芫鮭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("馧鲩芫骭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("馧鶩芫鲭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("馧銩芫麭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("馧銩芫隭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("馧鎩芫颭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("骧骩芫骭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("馧麩芫馭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("馧龩芫鮭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("馧鲩芫骭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("馧鶩芫鲭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("馧銩芫麭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("馧銩芫隭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("馧鎩芫颭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("骧骩芫骭\uDDAF\uF3B1", int_0));
          break;
        }
        if (this.comboBox_0.SelectedIndex == 2)
        {
          this.comboBox_1.Items.Add((object) Module.a("馧鎩芫颭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("骧骩芫馭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("骧鮩芫鞭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("骧颩芫鞭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("骧麩芫麭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("骧龩芫龭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("骧鲩芫龭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("骧鶩芫鲭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("馧鎩芫颭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("骧骩芫馭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("骧鮩芫鞭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("骧颩芫鞭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("骧麩芫麭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("骧龩芫龭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("骧鲩芫龭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("骧鶩芫鲭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("馧鎩芫颭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("骧骩芫馭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("骧鮩芫鞭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("骧颩芫鞭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("骧麩芫麭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("骧龩芫龭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("骧鲩芫龭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("骧鶩芫鲭\uDDAF\uF3B1", int_0));
          break;
        }
        if (this.comboBox_0.SelectedIndex == 3)
        {
          this.comboBox_1.Items.Add((object) Module.a("骧麩芫鮭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("骧龩芫隭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("骧鶩芫鶭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("骧銩芫馭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("鮧骩芫麭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("鮧鮩芫鶭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("鮧颩芫馭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("鮧麩芫麭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("骧麩芫鮭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("骧龩芫隭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("骧鶩芫鶭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("骧銩芫馭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("鮧骩芫麭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("鮧鮩芫鶭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("鮧颩芫馭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("鮧麩芫麭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("骧麩芫鮭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("骧龩芫隭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("骧鶩芫鶭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("骧銩芫馭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("鮧骩芫麭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("鮧鮩芫鶭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("鮧颩芫馭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("鮧麩芫麭\uDDAF\uF3B1", int_0));
          break;
        }
        break;
      case 12:
        if (this.comboBox_0.SelectedIndex == 0)
        {
          this.comboBox_1.Items.Add((object) Module.a("馧骩芫麭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("馧骩芫颭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("馧鮩芫龭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("馧鮩芫颭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("馧颩芫鲭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("馧颩芫馭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("馧馩芫骭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("馧馩芫鞭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("馧骩芫麭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("馧骩芫颭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("馧鮩芫龭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("馧鮩芫颭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("馧颩芫鲭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("馧颩芫馭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("馧馩芫骭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("馧馩芫鞭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("馧骩芫麭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("馧骩芫颭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("馧鮩芫龭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("馧鮩芫颭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("馧颩芫鲭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("馧颩芫馭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("馧馩芫骭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("馧馩芫鞭\uDDAF\uF3B1", int_0));
          break;
        }
        if (this.comboBox_0.SelectedIndex == 1)
        {
          this.comboBox_1.Items.Add((object) Module.a("骧骩芫麭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("骧鮩芫鲭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("骧颩芫鲭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("骧馩芫鶭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("骧麩芫鮭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("骧龩芫颭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("骧鲩芫隭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("骧鶩芫鞭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("骧骩芫麭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("骧鮩芫鲭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("骧颩芫鲭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("骧馩芫鶭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("骧麩芫鮭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("骧龩芫颭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("骧鲩芫隭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("骧鶩芫鞭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("骧骩芫麭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("骧鮩芫鲭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("骧颩芫鲭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("骧馩芫鶭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("骧麩芫鮭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("骧龩芫颭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("骧鲩芫隭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("骧鶩芫鞭\uDDAF\uF3B1", int_0));
          break;
        }
        if (this.comboBox_0.SelectedIndex == 2)
        {
          this.comboBox_1.Items.Add((object) Module.a("馧龩芫麭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("馧龩芫鞭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("馧鲩芫馭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("馧鶩芫鮭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("馧銩芫骭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("馧鎩芫鲭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("骧骩芫龭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("骧鮩芫麭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("馧龩芫麭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("馧龩芫鞭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("馧鲩芫馭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("馧鶩芫鮭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("馧銩芫骭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("馧鎩芫鲭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("骧骩芫龭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("骧鮩芫麭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("馧龩芫麭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("馧龩芫鞭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("馧鲩芫馭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("馧鶩芫鮭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("馧銩芫骭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("馧鎩芫鲭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("骧骩芫龭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("骧鮩芫麭\uDDAF\uF3B1", int_0));
          break;
        }
        if (this.comboBox_0.SelectedIndex == 3)
        {
          this.comboBox_1.Items.Add((object) Module.a("骧龩芫麭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("骧鲩芫鮭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("骧鶩芫隭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("骧鎩芫龭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("鮧骩芫颭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("鮧鮩芫鞭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("鮧馩芫鮭\uDDAF\uF3B1", int_0));
          this.comboBox_1.Items.Add((object) Module.a("鮧麩芫鞭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("骧龩芫麭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("骧鲩芫鮭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("骧鶩芫隭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("骧鎩芫龭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("鮧骩芫颭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("鮧鮩芫鞭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("鮧馩芫鮭\uDDAF\uF3B1", int_0));
          this.comboBox_2.Items.Add((object) Module.a("鮧麩芫鞭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("骧龩芫麭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("骧鲩芫鮭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("骧鶩芫隭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("骧鎩芫龭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("鮧骩芫颭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("鮧鮩芫鞭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("鮧馩芫鮭\uDDAF\uF3B1", int_0));
          this.comboBox_3.Items.Add((object) Module.a("鮧麩芫鞭\uDDAF\uF3B1", int_0));
          break;
        }
        break;
    }
    this.comboBox_1.SelectedIndex = (int) this.byte_0;
    this.comboBox_2.SelectedIndex = (int) this.byte_1;
    this.comboBox_3.SelectedIndex = (int) this.byte_2;
  }

  private void button_1_Click(object sender, EventArgs e) => this.Close();

  private void button_0_Click(object sender, EventArgs e)
  {
    byte selectedIndex1 = (byte) this.comboBox_0.SelectedIndex;
    byte selectedIndex2 = (byte) this.comboBox_1.SelectedIndex;
    byte selectedIndex3 = (byte) this.comboBox_2.SelectedIndex;
    byte selectedIndex4 = (byte) this.comboBox_3.SelectedIndex;
    byte num1 = (byte) ((uint) selectedIndex1 << 4 | (uint) selectedIndex2);
    byte num2 = (byte) ((uint) selectedIndex3 << 4 | (uint) selectedIndex4);
    c.byte_3 = num1;
    c.byte_4 = num2;
    c.byte_5 = !this.radioButton_0.Checked ? (byte) 85 : (byte) 0;
    this.DialogResult = DialogResult.OK;
  }

    protected override void Dispose(bool disposing)
    {
        if (disposing && this.icontainer_0 != null)
            this.icontainer_0.Dispose();

        base.Dispose(disposing);
    }

    private void method_0()
  {
    this.label_0 = new Label();
    this.comboBox_0 = new ComboBox();
    this.comboBox_1 = new ComboBox();
    this.label_1 = new Label();
    this.comboBox_2 = new ComboBox();
    this.label_2 = new Label();
    this.comboBox_3 = new ComboBox();
    this.label_3 = new Label();
    this.groupBox_0 = new GroupBox();
    this.radioButton_0 = new RadioButton();
    this.radioButton_1 = new RadioButton();
    this.groupBox_1 = new GroupBox();
    this.button_0 = new Button();
    this.button_1 = new Button();
    this.groupBox_0.SuspendLayout();
    this.groupBox_1.SuspendLayout();
    this.SuspendLayout();
    this.label_0.AutoSize = true;
    this.label_0.Location = new Point(171, 20);
    this.label_0.Name = Module.a("\uD8B3ힵ\uDAB7\uDFB9킻辽", 14);
    this.label_0.Size = new Size(53, 12);
    this.label_0.TabIndex = 0;
    this.label_0.Text = Module.a("臆\uF7D8⛯烏", 14);
    this.comboBox_0.FormattingEnabled = true;
    this.comboBox_0.Items.AddRange(new object[4]
    {
      (object) Module.a("薳蒵隷誹톻ﾽ", 14),
      (object) Module.a("薳躵隷誹톻ﾽ", 14),
      (object) Module.a("蚳芵隷誹톻ﾽ", 14),
      (object) Module.a("螳蚵隷誹톻ﾽ", 14)
    });
    this.comboBox_0.Location = new Point(230, 17);
    this.comboBox_0.Name = Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3", 14);
    this.comboBox_0.Size = new Size(89, 20);
    this.comboBox_0.TabIndex = 1;
    this.comboBox_0.SelectedIndexChanged += new EventHandler(this.comboBox_0_SelectedIndexChanged);
    this.comboBox_1.FormattingEnabled = true;
    this.comboBox_1.Location = new Point(59, 63);
    this.comboBox_1.Name = Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF6C3", 14);
    this.comboBox_1.Size = new Size(89, 20);
    this.comboBox_1.TabIndex = 3;
    this.label_1.AutoSize = true;
    this.label_1.Location = new Point(8, 66);
    this.label_1.Name = Module.a("\uD8B3ힵ\uDAB7\uDFB9킻貽", 14);
    this.label_1.Size = new Size(47, 12);
    this.label_1.TabIndex = 2;
    this.label_1.Text = Module.a("짅엫\uD93F\uE8B9", 14);
    this.comboBox_2.FormattingEnabled = true;
    this.comboBox_2.Location = new Point(230, 63);
    this.comboBox_2.Name = Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF7C3", 14);
    this.comboBox_2.Size = new Size(89, 20);
    this.comboBox_2.TabIndex = 5;
    this.label_2.AutoSize = true;
    this.label_2.Location = new Point(178, 66);
    this.label_2.Name = Module.a("\uD8B3ힵ\uDAB7\uDFB9킻趽", 14);
    this.label_2.Size = new Size(47, 12);
    this.label_2.TabIndex = 4;
    this.label_2.Text = Module.a("짅엫\uD93Fﶹ", 14);
    this.comboBox_3.FormattingEnabled = true;
    this.comboBox_3.Location = new Point(402, 63);
    this.comboBox_3.Name = Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF0C3", 14);
    this.comboBox_3.Size = new Size(89, 20);
    this.comboBox_3.TabIndex = 7;
    this.label_3.AutoSize = true;
    this.label_3.Location = new Point(352, 66);
    this.label_3.Name = Module.a("\uD8B3ힵ\uDAB7\uDFB9킻誽", 14);
    this.label_3.Size = new Size(47, 12);
    this.label_3.TabIndex = 6;
    this.label_3.Text = Module.a("짅엫\uD93F\uF8B9", 14);
    this.groupBox_0.Controls.Add((Control) this.label_2);
    this.groupBox_0.Controls.Add((Control) this.comboBox_3);
    this.groupBox_0.Controls.Add((Control) this.label_0);
    this.groupBox_0.Controls.Add((Control) this.label_3);
    this.groupBox_0.Controls.Add((Control) this.comboBox_0);
    this.groupBox_0.Controls.Add((Control) this.comboBox_2);
    this.groupBox_0.Controls.Add((Control) this.label_1);
    this.groupBox_0.Controls.Add((Control) this.comboBox_1);
    this.groupBox_0.Location = new Point(12, 12);
    this.groupBox_0.Name = Module.a("펳쒵ힷ쾹첻ﲽ꾿뫁\uF5C3", 14);
    this.groupBox_0.Size = new Size(502, 97);
    this.groupBox_0.TabIndex = 8;
    this.groupBox_0.TabStop = false;
    this.groupBox_0.Text = Module.a("臆\uF7D8⛯烏Ȱ탂", 14);
    this.radioButton_0.AutoSize = true;
    this.radioButton_0.Location = new Point(14, 24);
    this.radioButton_0.Name = Module.a("욳ힵ\uDCB7펹펻ﲽ떿뛁냃꧅ꛇ\uFBC9", 14);
    this.radioButton_0.Size = new Size(95, 16);
    this.radioButton_0.TabIndex = 10;
    this.radioButton_0.TabStop = true;
    this.radioButton_0.Text = Module.a("✼䳤埍姪\uDFD0蛣", 14);
    this.radioButton_0.UseVisualStyleBackColor = true;
    this.radioButton_1.AutoSize = true;
    this.radioButton_1.Location = new Point(164, 24);
    this.radioButton_1.Name = Module.a("욳ힵ\uDCB7펹펻ﲽ떿뛁냃꧅ꛇ\uF8C9", 14);
    this.radioButton_1.Size = new Size(95, 16);
    this.radioButton_1.TabIndex = 11;
    this.radioButton_1.TabStop = true;
    this.radioButton_1.Text = Module.a("✼䳤埍姪燨꿩", 14);
    this.radioButton_1.UseVisualStyleBackColor = true;
    this.groupBox_1.Controls.Add((Control) this.radioButton_1);
    this.groupBox_1.Controls.Add((Control) this.radioButton_0);
    this.groupBox_1.Location = new Point(12, 115);
    this.groupBox_1.Name = Module.a("펳쒵ힷ쾹첻ﲽ꾿뫁\uF6C3", 14);
    this.groupBox_1.Size = new Size(502, 50);
    this.groupBox_1.TabIndex = 12;
    this.groupBox_1.TabStop = false;
    this.groupBox_1.Text = Module.a("✼䳤埍姪㷜駝줯⮣", 14);
    this.button_0.Location = new Point(134, 191);
    this.button_0.Name = Module.a("횳쎵첷캹펻킽\uF1BF", 14);
    this.button_0.Size = new Size(75, 23);
    this.button_0.TabIndex = 13;
    this.button_0.Text = Module.a("\uDACBⳮ", 14);
    this.button_0.UseVisualStyleBackColor = true;
    this.button_0.Click += new EventHandler(this.button_0_Click);
    this.button_1.Location = new Point(309, 191);
    this.button_1.Name = Module.a("횳쎵첷캹펻킽\uF2BF", 14);
    this.button_1.Size = new Size(75, 23);
    this.button_1.TabIndex = 14;
    this.button_1.Text = Module.a("拠㻘", 14);
    this.button_1.UseVisualStyleBackColor = true;
    this.button_1.Click += new EventHandler(this.button_1_Click);
    this.AutoScaleDimensions = new SizeF(6f, 12f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(520, 240);
    this.ControlBox = false;
    this.Controls.Add((Control) this.button_1);
    this.Controls.Add((Control) this.button_0);
    this.Controls.Add((Control) this.groupBox_1);
    this.Controls.Add((Control) this.groupBox_0);
    this.Name = Module.a("ﲳ펵횷\uDDB9\uF0BBힽ떿鷁\uF5C3\uF0C5ￇ\uFDC9", 14);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = Module.a("ﲳ펵횷\uDDB9\uF0BBힽ떿鷁\uF5C3\uF0C5ￇ\uFDC9", 14);
    this.TopMost = true;
    this.groupBox_0.ResumeLayout(false);
    this.groupBox_0.PerformLayout();
    this.groupBox_1.ResumeLayout(false);
    this.groupBox_1.PerformLayout();
    this.ResumeLayout(false);
  }
}
