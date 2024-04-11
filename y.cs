// Decompiled with JetBrains decompiler
// Type: y
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class y : Form
{
  public static int int_0;
  private int int_1;
  private int int_2;
  private int int_3;
  private int int_4;
  private IContainer icontainer_0;
  private Label label_0;
  private Label label_1;
  private TextBox textBox_0;
  private TextBox textBox_1;
  private Label label_2;
  private TextBox textBox_2;
  private Button button_0;
  private Label label_3;
  private Label label_4;
  private Label label_5;
  private GroupBox groupBox_0;
  private Button button_1;
  private Label label_6;
  private Label label_7;
  private Label label_8;
  private Label label_9;
  private Label label_10;
  private Label label_11;
  private Label label_12;
  private PictureBox pictureBox_0;
  private ComboBox comboBox_0;
  private ImageList imageList_0;
  private Label label_13;
  private Label label_14;

  [SpecialName]
  public string method_0() => this.textBox_0.Text;

  [SpecialName]
  public string method_1() => this.textBox_1.Text;

  [SpecialName]
  public string method_2() => this.textBox_2.Text;

  public y()
  {
    int int_0 = 1;
    // ISSUE: explicit constructor call
  
    //base.\u002Ector();
    this.method_4();
    if (c.useEnglishLanguage)
    {
      this.comboBox_0.Items.Clear();
      this.comboBox_0.Items.Add((object) Module.a("\uE8A6잨讪\uD9AC잮풰鎲\uD9B4튶\uDFB8쾺鶼ힾ껀뇂계뷆ꛈꗊ만껎뷐", int_0));
      this.comboBox_0.Items.Add((object) Module.a("\uE8A6잨讪\uD9AC잮풰鎲잴\uDEB6\uDEB8펺즼龾꧀곂럄껆돈\uA4CAꏌ믎냐뿒", int_0));
      this.comboBox_0.Items.Add((object) Module.a("\uE8A6잨讪\uD9AC잮풰鎲\uD9B4튶\uDFB8쾺鶼즾꓀뇂뇄껆\uAAC8\uAACAꇌ", int_0));
      this.comboBox_0.Items.Add((object) Module.a("\uE8A6잨讪\uD9AC잮풰鎲잴\uDEB6\uDEB8펺즼龾럀ꛂ럄돆ꃈ\uA8CA곌ꏎ", int_0));
      this.comboBox_0.Items.Add((object) Module.a("\uF2A6잨쾪좬\uDDAE醰잲\uDDB4튶馸ힺ\uD8BC\uD9BE뗀\uE3C2귄\uA8C6믈ꋊ럌ꃎ뿐\uA7D2듔믖", int_0));
      this.comboBox_0.Items.Add((object) Module.a("\uF2A6잨쾪좬\uDDAE醰잲\uDDB4튶馸즺풼\uD8BE꧀럂\uE5C4꿆ꛈ맊\uA4CC뗎뻐뷒ꇔ뛖뗘", int_0));
      this.comboBox_0.Items.Add((object) Module.a("\uF2A6잨쾪좬\uDDAE醰잲\uDDB4튶馸ힺ\uD8BC\uD9BE뗀\uE3C2도ꋆ믈뿊\uA4CC곎냐뿒", int_0));
      this.comboBox_0.Items.Add((object) Module.a("\uF2A6잨쾪좬\uDDAE醰잲\uDDB4튶馸즺풼\uD8BE꧀럂\uE5C4뇆곈맊만ꛎ닐닒맔", int_0));
      this.comboBox_0.Items.Add((object) Module.a("ﶦ覨\uD8AA얬캮솰횲閴풶횸햺펼\uDABEꋀ럂", int_0));
    }
    this.comboBox_0.SelectedIndex = 0;
    this.pictureBox_0.Image = this.imageList_0.Images[0];
    this.int_3 = 4000;
    this.int_4 = 3000;
    this.label_3.Text = Module.a("辦風뾊", int_0) + this.int_3.ToString() + Module.a("躦", int_0);
    this.label_4.Text = Module.a("辦風뾊", int_0) + this.int_4.ToString() + Module.a("躦", int_0);
    this.textBox_2.Text = c.int_74.ToString();
    this.int_2 = c.int_74;
    this.label_8.Text = Module.a("龦", int_0);
    if (c.int_2 == 3)
    {
      int num1 = c.int_8 + c.int_9 + c.int_10 + 3;
      int num2 = (768 - (int) c.byte_0) / num1;
      this.int_2 = num2;
      this.textBox_2.Text = num2.ToString();
      this.label_14.Text = Module.a("隦", int_0);
      this.label_8.Text = Module.a("龦", int_0);
      this.label_5.Text = Module.a("辦風뾊", int_0) + num2.ToString() + Module.a("躦", int_0);
      this.int_1 = num2 * 8;
      this.label_6.Text = this.int_1.ToString();
    }
    if (c.int_2 == 14)
    {
      int num3 = c.int_8 + c.int_9 + c.int_10 + 3;
      int num4 = (768 - (int) c.byte_0) / num3;
      this.int_2 = num4;
      this.textBox_2.Text = num4.ToString();
      this.label_14.Text = Module.a("隦", int_0);
      this.label_8.Text = Module.a("隦", int_0);
      this.label_5.Text = Module.a("辦風뾊", int_0) + num4.ToString() + Module.a("躦", int_0);
      this.int_1 = num4;
      this.label_6.Text = this.int_1.ToString();
    }
    else if (c.int_2 == 7)
    {
      this.label_14.Text = Module.a("隦", int_0);
      this.label_8.Text = Module.a("鎦", int_0);
      this.label_5.Text = Module.a("辦風뾊鲬龮莰螲鲴", int_0);
      this.int_1 = 4096;
      this.label_6.Text = this.int_1.ToString();
    }
    else if (c.int_2 == 8)
    {
      this.label_14.Text = Module.a("隦", int_0);
      this.label_8.Text = Module.a("龦", int_0);
      this.label_5.Text = Module.a("辦風뾊鲬龮莰螲鲴", int_0);
      this.int_1 = 8192;
      this.label_6.Text = this.int_1.ToString();
    }
    else if (c.int_2 == 9)
    {
      this.label_14.Text = Module.a("隦", int_0);
      this.label_8.Text = Module.a("隦", int_0);
      this.label_5.Text = Module.a("辦風뾊龬龮薰讲鲴", int_0);
      this.int_1 = 2048;
      this.label_6.Text = this.int_1.ToString();
    }
    else if (c.int_2 == 101)
    {
      int num5 = c.int_8 + c.int_9 + c.int_10 + 3;
      int num6 = (768 - (int) c.byte_0) / num5;
      this.int_2 = num6;
      this.textBox_2.Text = num6.ToString();
      this.label_14.Text = Module.a("醦鶨", int_0);
      this.label_8.Text = Module.a("銦風馪", int_0);
      this.label_5.Text = Module.a("辦風뾊", int_0) + num6.ToString() + Module.a("躦", int_0);
      this.int_1 = 512 * num6;
      this.label_6.Text = this.int_1.ToString();
      this.label_7.Text = Module.a("证ﴨ重囐烐ᛓ藠뗓郯훈쯟螼", int_0);
    }
    else if (c.int_2 == 103)
    {
      int num7 = c.int_8 + c.int_9 + c.int_10 + 3;
      int num8 = (1536 - (int) c.byte_0) / num7;
      this.int_2 = num8;
      this.textBox_2.Text = num8.ToString();
      this.label_14.Text = Module.a("醦鶨", int_0);
      this.label_8.Text = Module.a("銦風馪", int_0);
      this.label_5.Text = Module.a("辦風뾊", int_0) + num8.ToString() + Module.a("躦", int_0);
      this.int_1 = 512 * num8;
      this.label_6.Text = this.int_1.ToString();
      this.label_7.Text = Module.a("证ﴨ重囐烐ᛓ藠뗓郯훈쯟螼", int_0);
    }
    else if (c.int_2 == 15)
    {
      int num9 = c.int_8 + c.int_9 + c.int_10 + 3;
      int num10 = (1536 - (int) c.byte_0) / num9;
      this.int_2 = num10;
      this.textBox_2.Text = num10.ToString();
      this.label_14.Text = Module.a("隦", int_0);
      this.label_8.Text = Module.a("隦", int_0);
      this.label_5.Text = Module.a("辦風뾊", int_0) + num10.ToString() + Module.a("躦", int_0);
      this.int_1 = num10;
      this.label_6.Text = this.int_1.ToString();
      this.label_7.Text = Module.a("证ﴨ重囐烐ᛓ藠뗓郯훈쯟螼", int_0);
    }
    else if (c.int_2 == 102)
    {
      this.label_14.Text = (131072 / (8 * c.int_4)).ToString();
      this.label_8.Text = (131072 / c.int_4).ToString();
      this.label_5.Text = Module.a("辦風뾊", int_0) + c.int_4.ToString() + Module.a("躦", int_0);
      this.int_1 = 131072;
      this.label_6.Text = this.int_1.ToString();
      this.label_7.Text = Module.a("证ﴨ重囐烐ᛓ藠뗓郯훈쯟螼", int_0);
    }
    else if (c.int_2 == 84)
    {
      this.label_14.Text = (131072 / (8 * c.int_4)).ToString();
      this.label_8.Text = (131072 / c.int_4).ToString();
      this.label_5.Text = Module.a("辦風뾊", int_0) + c.int_4.ToString() + Module.a("躦", int_0);
      this.int_1 = 131072;
      this.label_6.Text = this.int_1.ToString();
      this.label_7.Text = Module.a("证ﴨ重囐烐ᛓ藠뗓郯훈쯟螼", int_0);
    }
    else if (c.int_2 == 201)
    {
      this.label_14.Text = Module.a("隦", int_0);
      this.label_8.Text = Module.a("隦龨", int_0);
      this.label_5.Text = Module.a("辦風뾊颬麮莰骲", int_0);
      this.int_1 = 8192;
      this.label_6.Text = this.int_1.ToString();
      this.label_7.Text = Module.a("证ﴨ重囐烐ᛓ藠뗓郯훈쯟螼螾\uF0C0輸\uF7C4\uEBC6\uE5AF빒䦺煅뾯뮃㵄\uE68F醽휥ꪍ貑\uE883\uE898檺奭玳づꅤ\uEE11", int_0);
    }
    else if (c.int_2 == 120)
    {
      this.label_14.Text = Module.a("钦鮨", int_0);
      this.label_8.Text = Module.a("閦鲨鶪", int_0);
      this.label_5.Text = Module.a("辦風뾊颬麮莰骲", int_0);
      this.int_1 = 131072;
      this.label_6.Text = this.int_1.ToString();
      this.label_7.Text = Module.a("证ﴨ重囐烐ᛓ藠뗓郯훈쯟螼", int_0);
    }
    else if (c.int_2 == 160)
    {
      this.label_14.Text = Module.a("钦鮨", int_0);
      this.label_8.Text = Module.a("閦鲨鶪", int_0);
      this.label_5.Text = Module.a("辦風뾊颬麮莰骲", int_0);
      this.int_1 = 0;
      this.label_6.Text = this.int_1.ToString();
      this.label_7.Text = Module.a("证ﴨ重囐烐ᛓ藠뗓郯훈쯟螼", int_0);
    }
    else if (c.int_2 == 150)
    {
      this.label_14.Text = Module.a("钦鮨", int_0);
      this.label_8.Text = Module.a("閦鲨鶪", int_0);
      this.label_5.Text = Module.a("辦風뾊颬麮莰骲", int_0);
      this.int_1 = 131072;
      this.label_6.Text = this.int_1.ToString();
      this.label_7.Text = Module.a("证ﴨ重囐烐ᛓ藠뗓郯훈쯟螼", int_0);
    }
    else if (c.int_2 == 140)
    {
      this.label_14.Text = Module.a("钦鮨", int_0);
      this.label_8.Text = Module.a("閦鲨鶪", int_0);
      this.label_5.Text = Module.a("辦風뾊颬麮莰骲", int_0);
      this.int_1 = 131072;
      this.label_6.Text = this.int_1.ToString();
      this.label_7.Text = Module.a("证ﴨ重囐烐ᛓ藠뗓郯훈쯟螼", int_0);
    }
    else if (c.int_2 == 81)
    {
      if (!c.bool_3)
      {
        this.label_5.Text = Module.a("辦風뾊颬麮莰骲", int_0);
        this.label_14.Text = Module.a("钦鮨", int_0);
        this.label_8.Text = Module.a("閦鲨鶪", int_0);
      }
      else
      {
        this.label_5.Text = Module.a("辦風뾊鲬龮莰螲鲴", int_0);
        this.label_14.Text = Module.a("隦龨", int_0);
        this.label_8.Text = Module.a("隦鮨鎪", int_0);
      }
      this.int_1 = 131072;
      this.label_6.Text = this.int_1.ToString();
      this.label_7.Text = Module.a("证ﴨ重囐烐ᛓ藠뗓郯훈쯟螼", int_0);
    }
    else if (c.int_2 == 86)
    {
      if (!c.bool_3)
      {
        this.label_5.Text = Module.a("辦風뾊颬麮莰骲", int_0);
        this.label_14.Text = Module.a("钦鮨", int_0);
        this.label_8.Text = Module.a("閦鲨鶪", int_0);
      }
      else
      {
        this.label_5.Text = Module.a("辦風뾊鲬龮莰螲鲴", int_0);
        this.label_14.Text = Module.a("隦龨", int_0);
        this.label_8.Text = Module.a("隦鮨鎪", int_0);
      }
      this.int_1 = 131072;
      this.label_6.Text = this.int_1.ToString();
      this.label_7.Text = Module.a("证ﴨ重囐烐ᛓ藠뗓郯훈쯟螼", int_0);
    }
    else if (c.int_2 == 85)
    {
      if (!c.bool_3)
      {
        this.label_5.Text = Module.a("辦風뾊颬麮莰骲", int_0);
        this.label_14.Text = Module.a("钦鮨", int_0);
        this.label_8.Text = Module.a("閦鲨鶪", int_0);
      }
      else
      {
        this.label_5.Text = Module.a("辦風뾊鲬龮莰螲鲴", int_0);
        this.label_14.Text = Module.a("隦龨", int_0);
        this.label_8.Text = Module.a("隦鮨鎪", int_0);
      }
      this.int_1 = 131072;
      this.label_6.Text = this.int_1.ToString();
      this.label_7.Text = Module.a("证ﴨ重囐烐ᛓ藠뗓郯훈쯟螼", int_0);
    }
    else if (c.int_2 == 12)
    {
      this.label_14.Text = Module.a("隦", int_0);
      this.label_8.Text = Module.a("龦", int_0);
      if (!c.bool_3)
      {
        this.label_5.Text = Module.a("辦風뾊颬麮莰骲", int_0);
        this.int_1 = 4096;
      }
      else
      {
        this.label_5.Text = Module.a("辦風뾊鲬龮莰螲鲴", int_0);
        this.int_1 = 8192;
      }
      this.label_6.Text = this.int_1.ToString();
      this.label_7.Text = Module.a("证ﴨ重囐烐ᛓ藠뗓郯훈쯟螼", int_0);
    }
    else if (c.int_2 == 54)
    {
      this.label_14.Text = Module.a("隦", int_0);
      this.label_8.Text = Module.a("龦", int_0);
      if (!c.bool_3)
      {
        this.label_5.Text = Module.a("辦風뾊颬麮莰骲", int_0);
        this.int_1 = 4096;
      }
      else
      {
        this.label_5.Text = Module.a("辦風뾊鲬龮莰螲鲴", int_0);
        this.int_1 = 8192;
      }
      this.label_6.Text = this.int_1.ToString();
      this.label_7.Text = Module.a("证ﴨ重囐烐ᛓ藠뗓郯훈쯟螼", int_0);
    }
    else if (c.int_2 == 46)
    {
      this.label_14.Text = Module.a("隦", int_0);
      this.label_8.Text = Module.a("龦", int_0);
      if (!c.bool_3)
      {
        this.label_5.Text = Module.a("辦風뾊颬麮莰骲", int_0);
        this.int_1 = 4096;
      }
      else
      {
        this.label_5.Text = Module.a("辦風뾊鲬龮莰螲鲴", int_0);
        this.int_1 = 8192;
      }
      this.label_6.Text = this.int_1.ToString();
      this.label_7.Text = Module.a("证ﴨ重囐烐ᛓ藠뗓郯훈쯟螼", int_0);
    }
    else if (c.int_2 == 48)
    {
      this.label_14.Text = Module.a("隦", int_0);
      this.label_8.Text = Module.a("鎦", int_0);
      if (!c.bool_3)
      {
        this.label_5.Text = Module.a("辦風뾊颬麮莰骲", int_0);
        this.int_1 = 2048;
      }
      else
      {
        this.label_5.Text = Module.a("辦風뾊鲬龮莰螲鲴", int_0);
        this.int_1 = 4096;
      }
      this.label_6.Text = this.int_1.ToString();
      this.label_7.Text = Module.a("证ﴨ重囐烐ᛓ藠뗓郯훈쯟螼", int_0);
    }
    else if (c.int_2 == 13)
    {
      this.label_14.Text = Module.a("隦", int_0);
      this.label_8.Text = Module.a("隦", int_0);
      this.label_5.Text = Module.a("辦風뾊龬龮薰讲鲴", int_0);
      this.int_1 = 2048;
      this.label_6.Text = this.int_1.ToString();
      this.label_7.Text = Module.a("证ﴨ重囐烐ᛓ藠뗓郯훈쯟螼", int_0);
    }
    else if (c.int_2 == 52)
    {
      this.label_14.Text = Module.a("隦", int_0);
      this.label_8.Text = Module.a("隦", int_0);
      this.label_5.Text = Module.a("辦風뾊龬龮薰讲鲴", int_0);
      this.int_1 = 2048;
      this.label_6.Text = this.int_1.ToString();
      this.label_7.Text = Module.a("证ﴨ重囐烐ᛓ藠뗓郯훈쯟螼", int_0);
    }
    else if (c.int_2 == 47)
    {
      this.label_14.Text = Module.a("隦", int_0);
      this.label_8.Text = Module.a("隦", int_0);
      this.label_5.Text = Module.a("辦風뾊龬龮薰讲鲴", int_0);
      this.int_1 = 2048;
      this.label_6.Text = this.int_1.ToString();
      this.label_7.Text = Module.a("证ﴨ重囐烐ᛓ藠뗓郯훈쯟螼", int_0);
    }
    else if (c.int_2 == 51)
    {
      this.label_14.Text = Module.a("隦", int_0);
      this.label_8.Text = Module.a("隦", int_0);
      this.label_5.Text = Module.a("辦風뾊鲬骮芰薲鲴", int_0);
      this.int_1 = 1536;
      this.label_6.Text = this.int_1.ToString();
      this.label_7.Text = Module.a("证ﴨ重囐烐ᛓ藠뗓郯훈쯟螼", int_0);
    }
    else if (c.int_2 == 55)
    {
      this.label_14.Text = Module.a("隦", int_0);
      this.label_8.Text = Module.a("隦", int_0);
      this.label_5.Text = Module.a("辦風뾊鲬骮芰薲鲴", int_0);
      this.int_1 = 1536;
      this.label_6.Text = this.int_1.ToString();
      this.label_7.Text = Module.a("证ﴨ重囐烐ᛓ藠뗓郯훈쯟螼", int_0);
    }
    else if (c.int_2 == 130)
    {
      this.label_14.Text = Module.a("钦鮨", int_0);
      this.label_8.Text = (131072 / c.int_74).ToString();
      this.label_5.Text = Module.a("辦風뾊", int_0) + c.int_74.ToString() + Module.a("躦", int_0);
      this.int_1 = 131072;
      this.label_6.Text = this.int_1.ToString();
      this.label_7.Text = Module.a("证ﴨ重囐烐ᛓ藠뗓郯훈쯟螼", int_0);
    }
    else if (c.int_2 == 180)
    {
      this.label_14.Text = Module.a("閦鲨鮪", int_0);
      this.label_8.Text = (300000 / c.int_74).ToString();
      this.label_5.Text = Module.a("辦風뾊", int_0) + c.int_74.ToString() + Module.a("躦", int_0);
      this.int_1 = 300000;
      this.label_6.Text = this.int_1.ToString();
      this.label_7.Text = Module.a("证ﴨ重囐烐ᛓ藠뗓郯훈쯟螼", int_0);
    }
    else if (c.int_2 == 82)
    {
      if (!c.bool_3)
      {
        this.label_5.Text = Module.a("辦風뾊颬麮莰骲", int_0);
        this.label_14.Text = Module.a("钦鮨", int_0);
        this.label_8.Text = Module.a("閦鲨鶪", int_0);
      }
      else
      {
        this.label_5.Text = Module.a("辦風뾊鲬龮莰螲鲴", int_0);
        this.label_14.Text = Module.a("隦龨", int_0);
        this.label_8.Text = Module.a("隦鮨鎪", int_0);
      }
      this.int_1 = 131072;
      this.label_6.Text = this.int_1.ToString();
      this.label_7.Text = Module.a("证ﴨ重囐烐ᛓ藠뗓郯훈쯟螼", int_0);
    }
    else if (c.int_2 == 31)
    {
      this.label_14.Text = Module.a("隦", int_0);
      this.label_8.Text = Module.a("龦", int_0);
      if (!c.bool_3)
      {
        this.label_5.Text = Module.a("辦風뾊颬麮莰骲", int_0);
        this.int_1 = 4096;
      }
      else
      {
        this.label_5.Text = Module.a("辦風뾊鲬龮莰螲鲴", int_0);
        this.int_1 = 8192;
      }
      this.label_6.Text = this.int_1.ToString();
      this.label_7.Text = Module.a("证ﴨ重囐烐ᛓ藠뗓郯훈쯟螼", int_0);
    }
    else if (c.int_2 == 50)
    {
      this.label_14.Text = Module.a("隦", int_0);
      this.label_8.Text = Module.a("鎦", int_0);
      if (!c.bool_3)
      {
        this.label_5.Text = Module.a("辦風뾊颬麮莰骲", int_0);
        this.int_1 = 2048;
      }
      else
      {
        this.label_5.Text = Module.a("辦風뾊鲬龮莰螲鲴", int_0);
        this.int_1 = 4096;
      }
      this.label_6.Text = this.int_1.ToString();
      this.label_7.Text = Module.a("证ﴨ重囐烐ᛓ藠뗓郯훈쯟螼", int_0);
    }
    else if (c.int_2 == 41)
    {
      this.label_14.Text = Module.a("隦", int_0);
      this.label_8.Text = Module.a("鎦", int_0);
      if (!c.bool_3)
      {
        this.label_5.Text = Module.a("辦風뾊颬麮莰骲", int_0);
        this.int_1 = 2048;
      }
      else
      {
        this.label_5.Text = Module.a("辦風뾊鲬龮莰螲鲴", int_0);
        this.int_1 = 4096;
      }
      this.label_6.Text = this.int_1.ToString();
      this.label_7.Text = Module.a("证ﴨ重囐烐ᛓ藠뗓郯훈쯟螼", int_0);
    }
    else if (c.int_2 == 53)
    {
      this.label_14.Text = Module.a("隦", int_0);
      this.label_8.Text = Module.a("鎦", int_0);
      if (!c.bool_3)
      {
        this.label_5.Text = Module.a("辦風뾊颬麮莰骲", int_0);
        this.int_1 = 2048;
      }
      else
      {
        this.label_5.Text = Module.a("辦風뾊鲬龮莰螲鲴", int_0);
        this.int_1 = 4096;
      }
      this.label_6.Text = this.int_1.ToString();
      this.label_7.Text = Module.a("证ﴨ重囐烐ᛓ藠뗓郯훈쯟螼", int_0);
    }
    else if (c.int_2 == 32)
    {
      this.label_14.Text = Module.a("隦", int_0);
      this.label_8.Text = Module.a("隦", int_0);
      this.label_5.Text = Module.a("辦風뾊龬龮薰讲鲴", int_0);
      this.int_1 = 2048;
      if (c.byte_20 > (byte) 60)
      {
        this.label_5.Text = Module.a("辦風뾊鲬龮莰螲鲴", int_0);
        this.int_1 = 1024;
      }
      this.label_6.Text = this.int_1.ToString();
      this.label_7.Text = Module.a("证ﴨ重囐烐ᛓ藠뗓郯훈쯟螼", int_0);
    }
    if (!c.bool_1)
    {
      if (c.int_2 == 2)
      {
        this.label_5.Text = Module.a("辦風뾊颬麮莰骲", int_0);
        this.int_1 = 4096;
        this.label_6.Text = this.int_1.ToString();
      }
      if (c.int_2 == 49)
      {
        this.label_5.Text = Module.a("辦風뾊颬麮莰骲", int_0);
        this.int_1 = 2048;
        this.label_6.Text = this.int_1.ToString();
      }
      if (c.int_2 == 16)
      {
        this.label_5.Text = Module.a("辦風뾊颬麮莰骲", int_0);
        this.int_1 = 512;
        this.label_6.Text = this.int_1.ToString();
        this.label_8.Text = Module.a("隦", int_0);
      }
      else if (c.int_2 == 110)
      {
        this.label_14.Text = Module.a("钦鮨", int_0);
        this.label_8.Text = Module.a("閦鲨鶪", int_0);
        this.label_5.Text = Module.a("辦風뾊颬麮莰骲", int_0);
        this.int_1 = 131072;
        this.label_6.Text = this.int_1.ToString();
        this.label_7.Text = Module.a("证ﴨ重囐烐ᛓ藠뗓郯훈쯟螼", int_0);
      }
      else if (c.int_2 == 83)
      {
        this.label_14.Text = Module.a("钦鮨", int_0);
        this.label_8.Text = Module.a("閦鲨鶪", int_0);
        this.label_5.Text = Module.a("辦風뾊颬麮莰骲", int_0);
        this.int_1 = 131072;
        this.label_6.Text = this.int_1.ToString();
        this.label_7.Text = Module.a("证ﴨ重囐烐ᛓ藠뗓郯훈쯟螼", int_0);
      }
    }
    else
    {
      if (c.int_2 == 2)
      {
        this.label_5.Text = Module.a("辦風뾊鲬颮膰骲", int_0);
        this.int_1 = 1360;
        this.label_6.Text = this.int_1.ToString();
      }
      if (c.int_2 == 49)
      {
        this.label_5.Text = Module.a("辦風뾊鲬颮膰骲", int_0);
        this.int_1 = 680;
        this.label_6.Text = this.int_1.ToString();
      }
      if (c.int_2 == 16)
      {
        this.label_5.Text = Module.a("辦風뾊鲬颮膰骲", int_0);
        this.int_1 = 170;
        this.label_6.Text = this.int_1.ToString();
        this.label_8.Text = Module.a("隦", int_0);
      }
      else if (c.int_2 == 110)
      {
        this.label_14.Text = Module.a("麦麨", int_0);
        this.label_8.Text = Module.a("邦麨骪", int_0);
        this.label_5.Text = Module.a("辦風뾊鲬颮膰骲", int_0);
        this.int_1 = 131072;
        this.label_6.Text = this.int_1.ToString();
        this.label_7.Text = Module.a("证ﴨ重囐烐ᛓ藠뗓郯훈쯟螼", int_0);
      }
      else if (c.int_2 == 83)
      {
        this.label_14.Text = Module.a("麦麨", int_0);
        this.label_8.Text = Module.a("邦麨骪", int_0);
        this.label_5.Text = Module.a("辦風뾊鲬颮膰骲", int_0);
        this.int_1 = 131072;
        this.label_6.Text = this.int_1.ToString();
        this.label_7.Text = Module.a("证ﴨ重囐烐ᛓ藠뗓郯훈쯟螼", int_0);
      }
    }
    if (!c.useEnglishLanguage)
      return;
    this.label_7.Text = Module.a("\uEAA6좨펪莬\uE1AE쒰\uDEB2ힴ튶쮸鮺튼\uD9BE\uE1C0迂계ꃆꇈ뿊뻌\uEFCE鋐볒믔ꏖꯘ럚뇜돞蓠釢觤苦跨퇪", int_0);
  }

  private void button_1_Click(object sender, EventArgs e) => this.Close();

  private void method_3(string string_0)
  {
    MessageDialog aa = new MessageDialog();
    aa.label_0.Text = string_0;
    int num = (int) aa.ShowDialog();
  }

  private void button_0_Click(object sender, EventArgs e)
  {
    int int_0 = 8;
    int int32_1;
    try
    {
      int32_1 = Convert.ToInt32(this.textBox_2.Text);
    }
    catch
    {
      if (c.useEnglishLanguage)
      {
        this.method_3(Module.a("節\uD8AFힱ钳억\uDDB7캹즻캽\uE0BF귁ꋃ\uE6C5볇ꋉ꧋\uEECD뷏돑곓\uF8D5\uF8D7듙\uA9DB돝苟蟡難웥蟧賩쳫苭駯闱鳳苵请\uDAF9鏻都\u20FF瘁氃挅⠇稉挋簍搏㈑紓攕㠗猙爛紝伟倡嘣䌥䬧帩ഫ", int_0));
        return;
      }
      this.method_3(Module.a("䇗叼닖鏪\uD9C5죒в틄돳\uE6C4쪕씼", int_0));
      return;
    }
    if (int32_1 > this.int_2)
    {
      if (c.useEnglishLanguage)
        this.method_3(Module.a("節\uD8AFힱ钳억\uDDB7캹즻캽\uE0BF귁ꋃ\uE6C5볇ꋉ꧋\uEECD뷏돑곓\uF8D5\uF8D7듙\uA9DB돝苟蟡難웥蟧賩쳫苭駯闱鳳苵请\uDAF9鏻都\u20FF瘁氃挅⠇稉挋簍搏㈑紓攕㠗猙爛紝伟倡嘣䌥䬧帩ഫ", int_0));
      else
        this.method_3(Module.a("䇗叼닖鏪\uD9C5죒в틄돳\uE6C4쪕씼", int_0));
      this.textBox_2.Focus();
    }
    else
    {
      int int32_2;
      try
      {
        int32_2 = Convert.ToInt32(this.textBox_0.Text);
      }
      catch
      {
        if (c.useEnglishLanguage)
        {
          this.method_3(Module.a("節\uD8AFힱ钳억\uDDB7캹즻캽\uE0BF귁ꋃ\uE6C5볇ꋉ꧋\uEECD룏뷑ꛓ뿕ꋗ뗙닛ꫝ臟軡쓣雥臧鋩觫苭탯鯱蟳훵釷铹\u9FFB釽狿瀁愃攅簇⬉", int_0));
          return;
        }
        this.method_3(Module.a("髁쏱緡铎࠾훈럷髀뛩셀", int_0));
        return;
      }
      if (int32_2 >= 1)
      {
        if (int32_2 <= this.int_3)
        {
          int int32_3;
          try
          {
            int32_3 = Convert.ToInt32(this.textBox_1.Text);
          }
          catch
          {
            if (c.useEnglishLanguage)
            {
              this.method_3(Module.a("節\uD8AFힱ钳억\uDDB7캹즻캽\uE0BF귁ꋃ\uE6C5볇ꋉ꧋\uEECDꛏ럑ꛓꋕ뇗맙뷛닝샟鋡跣黥跧蛩쳫蟭華틱鷳飵鯷闹軻賽旿愁瀃✅", int_0));
              return;
            }
            this.method_3(Module.a("⳺䓙緡铎࠾훈럷髀뛩셀", int_0));
            return;
          }
          if (int32_3 >= 1)
          {
            if (int32_3 <= this.int_4)
            {
              try
              {
                Convert.ToInt32(this.textBox_0.Text);
                Convert.ToInt32(this.textBox_1.Text);
              }
              catch
              {
                if (c.useEnglishLanguage)
                {
                  this.method_3(Module.a("節\uD8AFힱ钳억\uDDB7캹즻캽\uE0BF귁ꋃ\uE6C5볇ꋉ꧋\uEECD룏뷑ꛓ뿕ꋗ뗙닛ꫝ臟軡쓣蟥蛧軩쳫飭闯胱胳\u9FF5鯷鯹郻\uDEFD烿欁簃挅搇⨉攋納』笑稓甕眗栙減笝䌟嘡ԣ", int_0));
                  return;
                }
                this.method_3(Module.a("髁쏱㻥㛤䋃矧髄Ȱ탂짘ⵊ씼", int_0));
                return;
              }
              y.int_0 = this.comboBox_0.SelectedIndex;
              this.DialogResult = DialogResult.OK;
              return;
            }
          }
          if (c.useEnglishLanguage)
            this.method_3(Module.a("節\uD8AFힱ钳억\uDDB7캹즻캽\uE0BF귁ꋃ\uE6C5볇ꋉ꧋\uEECDꛏ럑ꛓꋕ뇗맙뷛닝샟鋡跣黥跧蛩쳫蟭華틱鷳飵鯷闹軻賽旿愁瀃✅", int_0));
          else
            this.method_3(Module.a("⳺䓙緡铎࠾훈럷髀뛩셀", int_0));
          this.textBox_1.Focus();
          return;
        }
      }
      if (c.useEnglishLanguage)
        this.method_3(Module.a("節\uD8AFힱ钳억\uDDB7캹즻캽\uE0BF귁ꋃ\uE6C5볇ꋉ꧋\uEECD룏뷑ꛓ뿕ꋗ뗙닛ꫝ臟軡쓣雥臧鋩觫苭탯鯱蟳훵釷铹\u9FFB釽狿瀁愃攅簇⬉", int_0));
      else
        this.method_3(Module.a("髁쏱緡铎࠾훈럷髀뛩셀", int_0));
      this.textBox_0.Focus();
    }
  }

  private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e) => this.pictureBox_0.Image = this.imageList_0.Images[this.comboBox_0.SelectedIndex];

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

    private void method_4()
  {
    this.icontainer_0 = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (y));
    this.label_0 = new Label();
    this.label_1 = new Label();
    this.textBox_0 = new TextBox();
    this.textBox_1 = new TextBox();
    this.label_2 = new Label();
    this.textBox_2 = new TextBox();
    this.button_0 = new Button();
    this.label_3 = new Label();
    this.label_4 = new Label();
    this.label_5 = new Label();
    this.groupBox_0 = new GroupBox();
    this.label_14 = new Label();
    this.label_13 = new Label();
    this.comboBox_0 = new ComboBox();
    this.label_12 = new Label();
    this.label_6 = new Label();
    this.label_7 = new Label();
    this.label_8 = new Label();
    this.label_9 = new Label();
    this.button_1 = new Button();
    this.label_10 = new Label();
    this.label_11 = new Label();
    this.pictureBox_0 = new PictureBox();
    this.imageList_0 = new ImageList(this.icontainer_0);
    this.groupBox_0.SuspendLayout();
    ((ISupportInitialize) this.pictureBox_0).BeginInit();
    this.SuspendLayout();
    this.label_0.AccessibleDescription = (string) null;
    this.label_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_0, Module.a("\uD8B3ힵ\uDAB7\uDFB9킻辽", 14));
    this.label_0.Font = (Font) null;
    this.label_0.Name = Module.a("\uD8B3ힵ\uDAB7\uDFB9킻辽", 14);
    this.label_1.AccessibleDescription = (string) null;
    this.label_1.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_1, Module.a("\uD8B3ힵ\uDAB7\uDFB9킻貽", 14));
    this.label_1.Font = (Font) null;
    this.label_1.Name = Module.a("\uD8B3ힵ\uDAB7\uDFB9킻貽", 14);
    this.textBox_0.AccessibleDescription = (string) null;
    this.textBox_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.textBox_0, Module.a("삳펵삷캹ﺻ톽뢿\uF3C1", 14));
    this.textBox_0.BackgroundImage = (Image) null;
    this.textBox_0.Font = (Font) null;
    this.textBox_0.Name = Module.a("삳펵삷캹ﺻ톽뢿\uF3C1", 14);
    this.textBox_1.AccessibleDescription = (string) null;
    this.textBox_1.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.textBox_1, Module.a("삳펵삷캹ﺻ톽뢿\uF0C1", 14));
    this.textBox_1.BackgroundImage = (Image) null;
    this.textBox_1.Font = (Font) null;
    this.textBox_1.Name = Module.a("삳펵삷캹ﺻ톽뢿\uF0C1", 14);
    this.label_2.AccessibleDescription = (string) null;
    this.label_2.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_2, Module.a("\uD8B3ힵ\uDAB7\uDFB9킻趽", 14));
    this.label_2.Font = (Font) null;
    this.label_2.Name = Module.a("\uD8B3ힵ\uDAB7\uDFB9킻趽", 14);
    this.textBox_2.AccessibleDescription = (string) null;
    this.textBox_2.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.textBox_2, Module.a("삳펵삷캹ﺻ톽뢿\uF1C1", 14));
    this.textBox_2.BackColor = SystemColors.ControlLightLight;
    this.textBox_2.BackgroundImage = (Image) null;
    this.textBox_2.Font = (Font) null;
    this.textBox_2.Name = Module.a("삳펵삷캹ﺻ톽뢿\uF1C1", 14);
    this.button_0.AccessibleDescription = (string) null;
    this.button_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.button_0, Module.a("횳쎵첷캹펻킽\uF1BF", 14));
    this.button_0.BackgroundImage = (Image) null;
    this.button_0.Font = (Font) null;
    this.button_0.Name = Module.a("횳쎵첷캹펻킽\uF1BF", 14);
    this.button_0.UseVisualStyleBackColor = true;
    this.button_0.Click += new EventHandler(this.button_0_Click);
    this.label_3.AccessibleDescription = (string) null;
    this.label_3.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_3, Module.a("\uD8B3ힵ\uDAB7\uDFB9킻誽", 14));
    this.label_3.Font = (Font) null;
    this.label_3.Name = Module.a("\uD8B3ힵ\uDAB7\uDFB9킻誽", 14);
    this.label_4.AccessibleDescription = (string) null;
    this.label_4.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_4, Module.a("\uD8B3ힵ\uDAB7\uDFB9킻讽", 14));
    this.label_4.Font = (Font) null;
    this.label_4.Name = Module.a("\uD8B3ힵ\uDAB7\uDFB9킻讽", 14);
    this.label_5.AccessibleDescription = (string) null;
    this.label_5.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_5, Module.a("\uD8B3ힵ\uDAB7\uDFB9킻袽", 14));
    this.label_5.Font = (Font) null;
    this.label_5.Name = Module.a("\uD8B3ힵ\uDAB7\uDFB9킻袽", 14);
    this.groupBox_0.AccessibleDescription = (string) null;
    this.groupBox_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.groupBox_0, Module.a("펳쒵ힷ쾹첻ﲽ꾿뫁\uF5C3", 14));
    this.groupBox_0.BackgroundImage = (Image) null;
    this.groupBox_0.Controls.Add((Control) this.label_14);
    this.groupBox_0.Controls.Add((Control) this.label_13);
    this.groupBox_0.Controls.Add((Control) this.comboBox_0);
    this.groupBox_0.Controls.Add((Control) this.label_12);
    this.groupBox_0.Controls.Add((Control) this.label_6);
    this.groupBox_0.Controls.Add((Control) this.label_7);
    this.groupBox_0.Controls.Add((Control) this.label_8);
    this.groupBox_0.Controls.Add((Control) this.label_9);
    this.groupBox_0.Controls.Add((Control) this.textBox_2);
    this.groupBox_0.Controls.Add((Control) this.label_0);
    this.groupBox_0.Controls.Add((Control) this.label_1);
    this.groupBox_0.Controls.Add((Control) this.textBox_0);
    this.groupBox_0.Controls.Add((Control) this.label_5);
    this.groupBox_0.Controls.Add((Control) this.textBox_1);
    this.groupBox_0.Controls.Add((Control) this.label_4);
    this.groupBox_0.Controls.Add((Control) this.label_2);
    this.groupBox_0.Controls.Add((Control) this.label_3);
    this.groupBox_0.Font = (Font) null;
    this.groupBox_0.Name = Module.a("펳쒵ힷ쾹첻ﲽ꾿뫁\uF5C3", 14);
    this.groupBox_0.TabStop = false;
    this.label_14.AccessibleDescription = (string) null;
    this.label_14.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_14, Module.a("\uD8B3ힵ\uDAB7\uDFB9킻辽\uF7BF", 14));
    this.label_14.Font = (Font) null;
    this.label_14.Name = Module.a("\uD8B3ힵ\uDAB7\uDFB9킻辽\uF7BF", 14);
    this.label_13.AccessibleDescription = (string) null;
    this.label_13.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_13, Module.a("\uD8B3ힵ\uDAB7\uDFB9킻辽\uF6BF", 14));
    this.label_13.Font = (Font) null;
    this.label_13.Name = Module.a("\uD8B3ힵ\uDAB7\uDFB9킻辽\uF6BF", 14);
    this.comboBox_0.AccessibleDescription = (string) null;
    this.comboBox_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.comboBox_0, Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3", 14));
    this.comboBox_0.BackgroundImage = (Image) null;
    this.comboBox_0.Font = (Font) null;
    this.comboBox_0.FormattingEnabled = true;
    this.comboBox_0.Items.AddRange(new object[9]
    {
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3\uE8C5臇뻉꧋ꏍꏏ", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3\uE8C5臇뻉꧋ꏍꏏ\uE3D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3\uE8C5臇뻉꧋ꏍꏏ\uE0D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3\uE8C5臇뻉꧋ꏍꏏ\uE1D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3\uE8C5臇뻉꧋ꏍꏏ\uE6D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3\uE8C5臇뻉꧋ꏍꏏ\uE7D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3\uE8C5臇뻉꧋ꏍꏏ\uE4D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3\uE8C5臇뻉꧋ꏍꏏ\uE5D1", 14)),
      (object) componentResourceManager.GetString(Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3\uE8C5臇뻉꧋ꏍꏏ\uEAD1", 14))
    });
    this.comboBox_0.Name = Module.a("ힳ\uD9B5햷\uD8B9펻ﲽ꾿뫁\uF5C3", 14);
    this.comboBox_0.SelectedIndexChanged += new EventHandler(this.comboBox_0_SelectedIndexChanged);
    this.label_12.AccessibleDescription = (string) null;
    this.label_12.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_12, Module.a("\uD8B3ힵ\uDAB7\uDFB9킻辽\uF4BF", 14));
    this.label_12.Font = (Font) null;
    this.label_12.Name = Module.a("\uD8B3ힵ\uDAB7\uDFB9킻辽\uF4BF", 14);
    this.label_6.AccessibleDescription = (string) null;
    this.label_6.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_6, Module.a("\uD8B3ힵ\uDAB7\uDFB9킻辽\uF1BF", 14));
    this.label_6.Font = (Font) null;
    this.label_6.Name = Module.a("\uD8B3ힵ\uDAB7\uDFB9킻辽\uF1BF", 14);
    this.label_7.AccessibleDescription = (string) null;
    this.label_7.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_7, Module.a("\uD8B3ힵ\uDAB7\uDFB9킻辽\uF0BF", 14));
    this.label_7.Font = (Font) null;
    this.label_7.Name = Module.a("\uD8B3ힵ\uDAB7\uDFB9킻辽\uF0BF", 14);
    this.label_8.AccessibleDescription = (string) null;
    this.label_8.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_8, Module.a("\uD8B3ힵ\uDAB7\uDFB9킻螽", 14));
    this.label_8.Font = (Font) null;
    this.label_8.Name = Module.a("\uD8B3ힵ\uDAB7\uDFB9킻螽", 14);
    this.label_9.AccessibleDescription = (string) null;
    this.label_9.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_9, Module.a("\uD8B3ힵ\uDAB7\uDFB9킻蚽", 14));
    this.label_9.Font = (Font) null;
    this.label_9.Name = Module.a("\uD8B3ힵ\uDAB7\uDFB9킻蚽", 14);
    this.button_1.AccessibleDescription = (string) null;
    this.button_1.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.button_1, Module.a("횳쎵첷캹펻킽\uF2BF", 14));
    this.button_1.BackgroundImage = (Image) null;
    this.button_1.DialogResult = DialogResult.Cancel;
    this.button_1.Font = (Font) null;
    this.button_1.Name = Module.a("횳쎵첷캹펻킽\uF2BF", 14);
    this.button_1.UseVisualStyleBackColor = true;
    this.button_1.Click += new EventHandler(this.button_1_Click);
    this.label_10.AccessibleDescription = (string) null;
    this.label_10.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_10, Module.a("\uD8B3ힵ\uDAB7\uDFB9킻辽\uF2BF", 14));
    this.label_10.Font = (Font) null;
    this.label_10.Name = Module.a("\uD8B3ힵ\uDAB7\uDFB9킻辽\uF2BF", 14);
    this.label_11.AccessibleDescription = (string) null;
    this.label_11.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_11, Module.a("\uD8B3ힵ\uDAB7\uDFB9킻辽\uF3BF", 14));
    this.label_11.Font = (Font) null;
    this.label_11.Name = Module.a("\uD8B3ힵ\uDAB7\uDFB9킻辽\uF3BF", 14);
    this.pictureBox_0.AccessibleDescription = (string) null;
    this.pictureBox_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.pictureBox_0, Module.a("쒳\uDFB5\uDBB7캹즻첽ꖿ胁ꯃ뻅劉", 14));
    this.pictureBox_0.BackgroundImage = (Image) null;
    this.pictureBox_0.Font = (Font) null;
    this.pictureBox_0.ImageLocation = (string) null;
    this.pictureBox_0.Name = Module.a("쒳\uDFB5\uDBB7캹즻첽ꖿ胁ꯃ뻅劉", 14);
    this.pictureBox_0.TabStop = false;
    this.imageList_0.ImageStream = (ImageListStreamer) componentResourceManager.GetObject(Module.a("\uDDB3\uDBB5\uD9B7\uDDB9\uD9BB\uF2BDꦿ뇁냃\uF7C5\uE6C7菉ꇋ꿍럏럑蟓ꋕ\uAAD7뿙뷛돝", 14));
    this.imageList_0.TransparentColor = Color.Transparent;
    this.imageList_0.Images.SetKeyName(0, Module.a("뻽僨鋝꯭銻\uDCBD궿닁", 14));
    this.imageList_0.Images.SetKeyName(1, Module.a("뻽䗦鋝꯭銻\uDCBD궿닁", 14));
    this.imageList_0.Images.SetKeyName(2, Module.a("뻽僨\u0DC9꯭銻\uDCBD궿닁", 14));
    this.imageList_0.Images.SetKeyName(3, Module.a("뻽䗦\u0DC9꯭銻\uDCBD궿닁", 14));
    this.imageList_0.Images.SetKeyName(4, Module.a("뿽僨鋝꯭銻\uDCBD궿닁", 14));
    this.imageList_0.Images.SetKeyName(5, Module.a("뿽䗦鋝꯭銻\uDCBD궿닁", 14));
    this.imageList_0.Images.SetKeyName(6, Module.a("뿽僨\u0DC9꯭銻\uDCBD궿닁", 14));
    this.imageList_0.Images.SetKeyName(7, Module.a("뿽䗦\u0DC9꯭銻\uDCBD궿닁", 14));
    this.imageList_0.Images.SetKeyName(8, Module.a("\uEEB3颵\uDAB7ힹ첻", 14));
    this.AccessibleDescription = (string) null;
    this.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this, Module.a("邳습킷펹쾻", 14));
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackgroundImage = (Image) null;
    this.ControlBox = false;
    this.Controls.Add((Control) this.pictureBox_0);
    this.Controls.Add((Control) this.label_11);
    this.Controls.Add((Control) this.label_10);
    this.Controls.Add((Control) this.button_1);
    this.Controls.Add((Control) this.groupBox_0);
    this.Controls.Add((Control) this.button_0);
    this.Font = (Font) null;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Icon = (Icon) null;
    this.Name = Module.a("\uE7B3펵첷\uE5B9請톽늿꿁", 14);
    this.groupBox_0.ResumeLayout(false);
    this.groupBox_0.PerformLayout();
    ((ISupportInitialize) this.pictureBox_0).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
