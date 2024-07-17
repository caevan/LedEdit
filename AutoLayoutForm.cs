// Decompiled with JetBrains decompiler
// Type: y
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using AFSApp.Helpers;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

// Auto layout form
public class AutoLayoutForm : Form
{
  public static int dataEntryPoint;
  private int int_1;
  private int int_2;
  private int int_3;
  private int int_4;
  private IContainer icontainer_0;
  private Label label_0;
  private Label label_1;
  private TextBox textBox_HorizontalPixels;
  private TextBox textBox_VerticalPixels;
  private Label label_2;
  private TextBox textBox_PixelsPerPort;
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
  private ComboBox comboBox_DataEntryPoint;
  private ImageList imageList_0;
  private Label label_13;
  private Label label_14;

  [SpecialName]
  public string GetHorizontalPixels() => this.textBox_HorizontalPixels.Text;

  [SpecialName]
  public string GetVerticalPixels() => this.textBox_VerticalPixels.Text;

  [SpecialName]
  public string GetPixelsPerPort() => this.textBox_PixelsPerPort.Text;

    public AutoLayoutForm()
    {
        int int_0 = 1;
        // ISSUE: explicit constructor call

        //base.\u002Ector();
        this.LayoutForm();
        if (c.useEnglishLanguage)
        {
            this.comboBox_DataEntryPoint.Items.Clear();
            this.comboBox_DataEntryPoint.Items.Add((object)"On the left horizontal");
            this.comboBox_DataEntryPoint.Items.Add((object)"On the right horizontal");
            this.comboBox_DataEntryPoint.Items.Add((object)"On the left vertical");
            this.comboBox_DataEntryPoint.Items.Add((object)"On the right vertical");
            this.comboBox_DataEntryPoint.Items.Add((object)"Under the left horizontal");
            this.comboBox_DataEntryPoint.Items.Add((object)"Under the right horizontal");
            this.comboBox_DataEntryPoint.Items.Add((object)"Under the left vertical");
            this.comboBox_DataEntryPoint.Items.Add((object)"Under the right vertical");
            this.comboBox_DataEntryPoint.Items.Add((object)"Z shape connect");
        }
        this.comboBox_DataEntryPoint.SelectedIndex = 0;
        this.pictureBox_0.Image = this.imageList_0.Images[0];
        this.int_3 = 4000;
        this.int_4 = 3000;
        this.label_3.Text = "(1—" + this.int_3.ToString() + ")";
        this.label_4.Text = "(1—" + this.int_4.ToString() + ")";

        this.textBox_PixelsPerPort.Text = c.int_74.ToString();
        this.int_2 = c.int_74;
        this.label_8.Text = "8";

        if (c.ledControllerType == 3)
        {
            int num1 = c.int_8 + c.int_9 + c.int_10 + 3;
            int num2 = (768 - (int)c.byte_0) / num1;
            this.int_2 = num2;
            this.textBox_PixelsPerPort.Text = num2.ToString();
            this.label_14.Text = "1";
            this.label_8.Text = "8";
            this.label_5.Text = "(1—" + num2.ToString() + ")";

            this.int_1 = num2 * 8;
            this.label_6.Text = this.int_1.ToString();
        }
        if (c.ledControllerType == 14)
        {
            int num3 = c.int_8 + c.int_9 + c.int_10 + 3;
            int num4 = (768 - (int)c.byte_0) / num3;
            this.int_2 = num4;
            this.textBox_PixelsPerPort.Text = num4.ToString();
            this.label_14.Text = "1";
            this.label_8.Text = "1";
            this.label_5.Text = "(1—" + num4.ToString() + ")";
            this.int_1 = num4;
            this.label_6.Text = this.int_1.ToString();
        }
        else if (c.ledControllerType == 7)
        {
            this.label_14.Text = "1";
            this.label_8.Text = "4";
            this.label_5.Text = "(1—1024)";
            this.int_1 = 4096;
            this.label_6.Text = this.int_1.ToString();
        }
        else if (c.ledControllerType == 8)
        {
            this.label_14.Text = "1";
            this.label_8.Text = "8";
            this.label_5.Text = "(1—1024)";
            this.int_1 = 8192;
            this.label_6.Text = this.int_1.ToString();
        }
        else if (c.ledControllerType == 9)
        {
            this.label_14.Text = "1";
            this.label_8.Text = "1";
            this.label_5.Text = "(1—2048)";
            this.int_1 = 2048;
            this.label_6.Text = this.int_1.ToString();
        }
        else if (c.ledControllerType == 101)
        {
            int num5 = c.int_8 + c.int_9 + c.int_10 + 3;
            int num6 = (768 - (int)c.byte_0) / num5;
            this.int_2 = num6;
            this.textBox_PixelsPerPort.Text = num6.ToString();
            this.label_14.Text = "64";
            this.label_8.Text = "512";
            this.label_5.Text = "(1—" + num6.ToString() + ")";
            this.int_1 = 512 * num6;
            this.label_6.Text = this.int_1.ToString();
            this.label_7.Text = "This online system controls the maximum number of lights:";
        }
        else if (c.ledControllerType == 103)
        {
            int num7 = c.int_8 + c.int_9 + c.int_10 + 3;
            int num8 = (1536 - (int)c.byte_0) / num7;
            this.int_2 = num8;
            this.textBox_PixelsPerPort.Text = num8.ToString();
            this.label_14.Text = "64";
            this.label_8.Text = "512";
            this.label_5.Text = "(1—" + num8.ToString() + ")";
            this.int_1 = 512 * num8;
            this.label_6.Text = this.int_1.ToString();
            this.label_7.Text = "This online system controls the maximum number of lights:";
        }
        else if (c.ledControllerType == 15)
        {
            int num9 = c.int_8 + c.int_9 + c.int_10 + 3;
            int num10 = (1536 - (int)c.byte_0) / num9;
            this.int_2 = num10;
            this.textBox_PixelsPerPort.Text = num10.ToString();
            this.label_14.Text = "1";
            this.label_8.Text = "1";
            this.label_5.Text = "(1—" + num10.ToString() + ")";
            this.int_1 = num10;
            this.label_6.Text = this.int_1.ToString();
            this.label_7.Text = "This online system controls the maximum number of lights:";
        }
        else if (c.ledControllerType == 102)
        {
            this.label_14.Text = (131072 / (8 * c.int_4)).ToString();
            this.label_8.Text = (131072 / c.int_4).ToString();
            this.label_5.Text = "(1—" + c.int_4.ToString() + ")";
            this.int_1 = 131072;
            this.label_6.Text = this.int_1.ToString();
            this.label_7.Text = "This online system controls the maximum number of lights:";
        }
        else if (c.ledControllerType == 84)
        {
            this.label_14.Text = (131072 / (8 * c.int_4)).ToString();
            this.label_8.Text = (131072 / c.int_4).ToString();
            this.label_5.Text = "(1—" + c.int_4.ToString() + ")";
            this.int_1 = 131072;
            this.label_6.Text = this.int_1.ToString();
            this.label_7.Text = "This online system controls the maximum number of lights:";
        }
        else if (c.ledControllerType == 201)
        {
            this.label_14.Text = "1";
            this.label_8.Text = "16";
            this.label_5.Text = "(1—512)";
            this.int_1 = 8192;
            this.label_6.Text = this.int_1.ToString();
            this.label_7.Text = "This online system controls the maximum number of lights:8192,All settings on this page are invalid，Depends on program settings！";
        }
        else if (c.ledControllerType == 120)
        {
            this.label_14.Text = "32";
            this.label_8.Text = "256";
            this.label_5.Text = "(1—512)";
            this.int_1 = 131072;
            this.label_6.Text = this.int_1.ToString();
            this.label_7.Text = "This online system controls the maximum number of lights:";
        }
        else if (c.ledControllerType == 160)
        {
            this.label_14.Text = "32";
            this.label_8.Text = "256";
            this.label_5.Text = "(1—512)";
            this.int_1 = 0;
            this.label_6.Text = this.int_1.ToString();
            this.label_7.Text = "This online system controls the maximum number of lights:";
        }
        else if (c.ledControllerType == 150)
        {
            this.label_14.Text = "32";
            this.label_8.Text = "256";
            this.label_5.Text = "(1—512)";
            this.int_1 = 131072;
            this.label_6.Text = this.int_1.ToString();
            this.label_7.Text = "This online system controls the maximum number of lights:";
        }
        else if (c.ledControllerType == 140)
        {
            this.label_14.Text = "32";
            this.label_8.Text = "256";
            this.label_5.Text = "(1—512)";
            this.int_1 = 131072;
            this.label_6.Text = this.int_1.ToString();
            this.label_7.Text = "This online system controls the maximum number of lights:";
        }
        else if (c.ledControllerType == 81)
        {
            if (!c.bool_3)
            {
                this.label_5.Text = "(1—512)";
                this.label_14.Text = "32";
                this.label_8.Text = "256";
            }
            else
            {
                this.label_5.Text = "(1—1024)";
                this.label_14.Text = "16";
                this.label_8.Text = "128";
            }
            this.int_1 = 131072;
            this.label_6.Text = this.int_1.ToString();
            this.label_7.Text = "This online system controls the maximum number of lights:";
        }
        else if (c.ledControllerType == 86)
        {
            if (!c.bool_3)
            {
                this.label_5.Text = "(1—512)";
                this.label_14.Text = "32";
                this.label_8.Text = "256";
            }
            else
            {
                this.label_5.Text = "(1—1024)";
                this.label_14.Text = "16";
                this.label_8.Text = "128";
            }
            this.int_1 = 131072;
            this.label_6.Text = this.int_1.ToString();
            this.label_7.Text = "This online system controls the maximum number of lights:";
        }
        else if (c.ledControllerType == 85)
        {
            if (!c.bool_3)
            {
                this.label_5.Text = "(1—512)";
                this.label_14.Text = "32";
                this.label_8.Text = "256";
            }
            else
            {
                this.label_5.Text = "(1—1024)";
                this.label_14.Text = "16";
                this.label_8.Text = "128";
            }
            this.int_1 = 131072;
            this.label_6.Text = this.int_1.ToString();
            this.label_7.Text = "This online system controls the maximum number of lights:";
        }
        else if (c.ledControllerType == 12)
        {
            this.label_14.Text = "1";
            this.label_8.Text = "8";
            if (!c.bool_3)
            {
                this.label_5.Text = "(1—512)";
                this.int_1 = 4096;
            }
            else
            {
                this.label_5.Text = "(1—1024)";
                this.int_1 = 8192;
            }
            this.label_6.Text = this.int_1.ToString();
            this.label_7.Text = "This online system controls the maximum number of lights:";
        }
        else if (c.ledControllerType == 54)
        {
            this.label_14.Text = "1";
            this.label_8.Text = "8";
            if (!c.bool_3)
            {
                this.label_5.Text = "(1—512)";
                this.int_1 = 4096;
            }
            else
            {
                this.label_5.Text = "(1—1024)";
                this.int_1 = 8192;
            }
            this.label_6.Text = this.int_1.ToString();
            this.label_7.Text = "This online system controls the maximum number of lights:";
        }
        else if (c.ledControllerType == 46)
        {
            this.label_14.Text = "1";
            this.label_8.Text = "8";
            if (!c.bool_3)
            {
                this.label_5.Text = "(1—512)";
                this.int_1 = 4096;
            }
            else
            {
                this.label_5.Text = "(1—1024)";
                this.int_1 = 8192;
            }
            this.label_6.Text = this.int_1.ToString();
            this.label_7.Text = "This online system controls the maximum number of lights:";
        }
        else if (c.ledControllerType == 48)
        {
            this.label_14.Text = "1";
            this.label_8.Text = "4";
            if (!c.bool_3)
            {
                this.label_5.Text = "(1—512)";
                this.int_1 = 2048;
            }
            else
            {
                this.label_5.Text = "(1—1024)";
                this.int_1 = 4096;
            }
            this.label_6.Text = this.int_1.ToString();
            this.label_7.Text = "This online system controls the maximum number of lights:";
        }
        else if (c.ledControllerType == 13)
        {
            this.label_14.Text = "1";
            this.label_8.Text = "1";
            this.label_5.Text = "(1—2048)";
            this.int_1 = 2048;
            this.label_6.Text = this.int_1.ToString();
            this.label_7.Text = "This online system controls the maximum number of lights:";
        }
        else if (c.ledControllerType == 52)
        {
            this.label_14.Text = "1";
            this.label_8.Text = "1";
            this.label_5.Text = "(1—2048)";
            this.int_1 = 2048;
            this.label_6.Text = this.int_1.ToString();
            this.label_7.Text = "This online system controls the maximum number of lights:";
        }
        else if (c.ledControllerType == 47)
        {
            this.label_14.Text = "1";
            this.label_8.Text = "1";
            this.label_5.Text = "(1—2048)";
            this.int_1 = 2048;
            this.label_6.Text = this.int_1.ToString();
            this.label_7.Text = "This online system controls the maximum number of lights:";
        }
        else if (c.ledControllerType == 51)
        {
            this.label_14.Text = "1";
            this.label_8.Text = "1";
            this.label_5.Text = "(1—1536)";
            this.int_1 = 1536;
            this.label_6.Text = this.int_1.ToString();
            this.label_7.Text = "This online system controls the maximum number of lights:";
        }
        else if (c.ledControllerType == 55)
        {
            this.label_14.Text = "1";
            this.label_8.Text = "1";
            this.label_5.Text = "(1—1536)";
            this.int_1 = 1536;
            this.label_6.Text = this.int_1.ToString();
            this.label_7.Text = "This online system controls the maximum number of lights:";
        }
        else if (c.ledControllerType == 130)
        {
            this.label_14.Text = "32";
            this.label_8.Text = (131072 / c.int_74).ToString();
            this.label_5.Text = "(1—" + c.int_74.ToString() + ")";
            this.int_1 = 131072;
            this.label_6.Text = this.int_1.ToString();
            this.label_7.Text = "This online system controls the maximum number of lights:";
        }
        else if (c.ledControllerType == 180)
        {
            this.label_14.Text = "250";
            this.label_8.Text = (300000 / c.int_74).ToString();
            this.label_5.Text = "(1—" + c.int_74.ToString() + ")";
            this.int_1 = 300000;
            this.label_6.Text = this.int_1.ToString();
            this.label_7.Text = "This online system controls the maximum number of lights:";
        }
        else if (c.ledControllerType == 82)
        {
            if (!c.bool_3)
            {
                this.label_5.Text = "(1—512)";
                this.label_14.Text = "32";
                this.label_8.Text = "256";
            }
            else
            {
                this.label_5.Text = "(1—1024)";
                this.label_14.Text = "16";
                this.label_8.Text = "128";
            }
            this.int_1 = 131072;
            this.label_6.Text = this.int_1.ToString();
            this.label_7.Text = "This online system controls the maximum number of lights:";
        }
        else if (c.ledControllerType == 31)
        {
            this.label_14.Text = "1";
            this.label_8.Text = "8";
            if (!c.bool_3)
            {
                this.label_5.Text = "(1—512)";
                this.int_1 = 4096;
            }
            else
            {
                this.label_5.Text = "(1—1024)";
                this.int_1 = 8192;
            }
            this.label_6.Text = this.int_1.ToString();
            this.label_7.Text = "This online system controls the maximum number of lights:";
        }
        else if (c.ledControllerType == 50)
        {
            this.label_14.Text = "1";
            this.label_8.Text = "4";
            if (!c.bool_3)
            {
                this.label_5.Text = "(1—512)";
                this.int_1 = 2048;
            }
            else
            {
                this.label_5.Text = "(1—1024)";
                this.int_1 = 4096;
            }
            this.label_6.Text = this.int_1.ToString();
            this.label_7.Text = "This online system controls the maximum number of lights:";
        }
        else if (c.ledControllerType == 41)
        {
            this.label_14.Text = "1";
            this.label_8.Text = "4";
            if (!c.bool_3)
            {
                this.label_5.Text = "(1—512)";
                this.int_1 = 2048;
            }
            else
            {
                this.label_5.Text = "(1—1024)";
                this.int_1 = 4096;
            }
            this.label_6.Text = this.int_1.ToString();
            this.label_7.Text = "This online system controls the maximum number of lights:";
        }
        else if (c.ledControllerType == 53)
        {
            this.label_14.Text = "1";
            this.label_8.Text = "4";
            if (!c.bool_3)
            {
                this.label_5.Text = "(1—512)";
                this.int_1 = 2048;
            }
            else
            {
                this.label_5.Text = "(1—1024)";
                this.int_1 = 4096;
            }
            this.label_6.Text = this.int_1.ToString();
            this.label_7.Text = "This online system controls the maximum number of lights:";
        }
        else if (c.ledControllerType == 32) //T1000 - WS2811
        {
            this.label_14.Text = "1";
            this.label_8.Text = "1";
            this.label_5.Text = "(1—2048)";
            this.int_1 = 2048;
            if (c.byte_20 > (byte)60)
            {
                this.label_5.Text = "(1—1024)";
                this.int_1 = 1024;
            }
            this.label_6.Text = this.int_1.ToString();
            this.label_7.Text = "This online system controls the maximum number of lights:";
        }
        if (!c.bool_1)
        {
            if (c.ledControllerType == 2)
            {
                this.label_5.Text = "(1—512)";
                this.int_1 = 4096;
                this.label_6.Text = this.int_1.ToString();
            }
            if (c.ledControllerType == 49)
            {
                this.label_5.Text = "(1—512)";
                this.int_1 = 2048;
                this.label_6.Text = this.int_1.ToString();
            }
            if (c.ledControllerType == 16)
            {
                this.label_5.Text = "(1—512)";
                this.int_1 = 512;
                this.label_6.Text = this.int_1.ToString();
                this.label_8.Text = "1";
            }
            else if (c.ledControllerType == 110)
            {
                this.label_14.Text = "32";
                this.label_8.Text = "256";
                this.label_5.Text = "(1—512)";
                this.int_1 = 131072;
                this.label_6.Text = this.int_1.ToString();
                this.label_7.Text = "This online system controls the maximum number of lights:";
            }
            else if (c.ledControllerType == 83)
            {
                this.label_14.Text = "32";
                this.label_8.Text = "256";
                this.label_5.Text = "(1—512)";
                this.int_1 = 131072;
                this.label_6.Text = this.int_1.ToString();
                this.label_7.Text = "This online system controls the maximum number of lights:";
            }
        }
        else
        {
            if (c.ledControllerType == 2)
            {
                this.label_5.Text = "(1—170)";
                this.int_1 = 1360;
                this.label_6.Text = this.int_1.ToString();
            }
            if (c.ledControllerType == 49)
            {
                this.label_5.Text = "(1—170)";
                this.int_1 = 680;
                this.label_6.Text = this.int_1.ToString();
            }
            if (c.ledControllerType == 16)
            {
                this.label_5.Text = "(1—170)";
                this.int_1 = 170;
                this.label_6.Text = this.int_1.ToString();
                this.label_8.Text = "1";
            }
            else if (c.ledControllerType == 110)
            {
                this.label_14.Text = "97";
                this.label_8.Text = "771";
                this.label_5.Text = "(1—170)";
                this.int_1 = 131072;
                this.label_6.Text = this.int_1.ToString();
                this.label_7.Text = "This online system controls the maximum number of lights:";
            }
            else if (c.ledControllerType == 83)
            {
                this.label_14.Text = "97";
                this.label_8.Text = "771";
                this.label_5.Text = "(1—170)";
                this.int_1 = 131072;
                this.label_6.Text = this.int_1.ToString();
                this.label_7.Text = "This online system controls the maximum number of lights:";
            }
        }
        if (!c.useEnglishLanguage)
            return;
        this.label_7.Text = "Max.Number of Lights Contrlllerled:";
    }

    private void button_1_Click(object sender, EventArgs e) => this.Close();

  private void ShowMessage(string string_0)
  {
    MessageDialog aa = new MessageDialog();
    aa.label_0.Text = string_0;
    int num = (int) aa.ShowDialog();
  }

    private void OKButton_Click(object sender, EventArgs e)
    {
        int int_0 = 8;
        int int32_1;
        try
        {
            int32_1 = Convert.ToInt32(this.textBox_PixelsPerPort.Text);
        }
        catch
        {
            if (c.useEnglishLanguage)
            {
                this.ShowMessage("The setup of the max. number of lights on the port is incorrect!");
                return;
            }
            this.ShowMessage("The setting of the maximum number of lights on the port does not match the！");
            return;
        }
        if (int32_1 > this.int_2)
        {
            if (c.useEnglishLanguage)
                this.ShowMessage("The setup of the max. number of lights on the port is incorrect!");
            else
                this.ShowMessage("端口最大灯数设置不符合！");
            this.textBox_PixelsPerPort.Focus();
        }
        else
        {
            int int32_2;
            try
            {
                int32_2 = Convert.ToInt32(this.textBox_HorizontalPixels.Text);
            }
            catch
            {
                if (c.useEnglishLanguage)
                {
                    this.ShowMessage("The setup of the horizontal pixel is incorrect!");
                    return;
                }
                this.ShowMessage("水平像素设置不符合！");
                return;
            }
            if (int32_2 >= 1)
            {
                if (int32_2 <= this.int_3)
                {
                    int int32_3;
                    try
                    {
                        int32_3 = Convert.ToInt32(this.textBox_VerticalPixels.Text);
                    }
                    catch
                    {
                        if (c.useEnglishLanguage)
                        {
                            this.ShowMessage("The setup of the vertical pixel is incorrect!");
                            return;
                        }
                        this.ShowMessage("垂直像素设置不符合！");
                        return;
                    }
                    if (int32_3 >= 1)
                    {
                        if (int32_3 <= this.int_4)
                        {
                            try
                            {
                                Convert.ToInt32(this.textBox_HorizontalPixels.Text);
                                Convert.ToInt32(this.textBox_VerticalPixels.Text);
                            }
                            catch
                            {
                                if (c.useEnglishLanguage)
                                {
                                    this.ShowMessage("The setup of the horizontal and vertical pixel is incorrect!");
                                    return;
                                }
                                this.ShowMessage("水平和垂直像素设置有误！");
                                return;
                            }
                            AutoLayoutForm.dataEntryPoint = this.comboBox_DataEntryPoint.SelectedIndex;
                            this.DialogResult = DialogResult.OK;
                            return;
                        }
                    }
                    if (c.useEnglishLanguage)
                        this.ShowMessage("The setup of the vertical pixel is incorrect!");
                    else
                        this.ShowMessage("垂直像素设置不符合！");
                    this.textBox_VerticalPixels.Focus();
                    return;
                }
            }
            if (c.useEnglishLanguage)
                this.ShowMessage("The setup of the horizontal pixel is incorrect!");
            else
                this.ShowMessage("水平像素设置不符合！");
            this.textBox_HorizontalPixels.Focus();
        }
    }

    private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e) => this.pictureBox_0.Image = this.imageList_0.Images[this.comboBox_DataEntryPoint.SelectedIndex];

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

    private void LayoutForm()
    {
        this.icontainer_0 = (IContainer)new System.ComponentModel.Container();
        ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AutoLayoutForm));
        this.label_0 = new Label();
        this.label_1 = new Label();
        this.textBox_HorizontalPixels = new TextBox();
        this.textBox_VerticalPixels = new TextBox();
        this.label_2 = new Label();
        this.textBox_PixelsPerPort = new TextBox();
        this.button_0 = new Button();
        this.label_3 = new Label();
        this.label_4 = new Label();
        this.label_5 = new Label();
        this.groupBox_0 = new GroupBox();
        this.label_14 = new Label();
        this.label_13 = new Label();
        this.comboBox_DataEntryPoint = new ComboBox();
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
        ((ISupportInitialize)this.pictureBox_0).BeginInit();
        this.SuspendLayout();
        this.label_0.AccessibleDescription = (string)null;
        this.label_0.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_0, "label1");
        this.label_0.Font = (Font)null;
        this.label_0.Name = "label1";
        this.label_1.AccessibleDescription = (string)null;
        this.label_1.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_1, "label2");
        this.label_1.Font = (Font)null;
        this.label_1.Name = "label2";
        this.textBox_HorizontalPixels.AccessibleDescription = (string)null;
        this.textBox_HorizontalPixels.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.textBox_HorizontalPixels, "textBox1");
        this.textBox_HorizontalPixels.BackgroundImage = (Image)null;
        this.textBox_HorizontalPixels.Font = (Font)null;
        this.textBox_HorizontalPixels.Name = "textBox1";
        this.textBox_VerticalPixels.AccessibleDescription = (string)null;
        this.textBox_VerticalPixels.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.textBox_VerticalPixels, "textBox2");
        this.textBox_VerticalPixels.BackgroundImage = (Image)null;
        this.textBox_VerticalPixels.Font = (Font)null;
        this.textBox_VerticalPixels.Name = "textBox2";
        this.label_2.AccessibleDescription = (string)null;
        this.label_2.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_2, "label3");
        this.label_2.Font = (Font)null;
        this.label_2.Name = "label3";
        LogData.LogInfo($"label_2.Text - {label_2.Text}");
        this.textBox_PixelsPerPort.AccessibleDescription = (string)null;
        this.textBox_PixelsPerPort.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.textBox_PixelsPerPort, "textBox3");
        this.textBox_PixelsPerPort.BackColor = SystemColors.ControlLightLight;
        this.textBox_PixelsPerPort.BackgroundImage = (Image)null;
        this.textBox_PixelsPerPort.Font = (Font)null;
        this.textBox_PixelsPerPort.Name = "textBox3";
        this.button_0.AccessibleDescription = (string)null;
        this.button_0.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.button_0, "button1");
        this.button_0.BackgroundImage = (Image)null;
        this.button_0.Font = (Font)null;
        this.button_0.Name = "button1";
        this.button_0.UseVisualStyleBackColor = true;
        this.button_0.Click += new EventHandler(this.OKButton_Click);
        this.label_3.AccessibleDescription = (string)null;
        this.label_3.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_3, "label4");
        this.label_3.Font = (Font)null;
        this.label_3.Name = "label4";
        LogData.LogInfo($"label_3.Text - {label_3.Text}");
        this.label_4.AccessibleDescription = (string)null;
        this.label_4.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_4, "label5");
        this.label_4.Font = (Font)null;
        this.label_4.Name = "label5";
        LogData.LogInfo($"label_4.Text - {label_4.Text}");
        this.label_5.AccessibleDescription = (string)null;
        this.label_5.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_5, "label6");
        this.label_5.Font = (Font)null;
        this.label_5.Name = "label6";
        this.groupBox_0.AccessibleDescription = (string)null;
        this.groupBox_0.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.groupBox_0, "groupBox1");
        this.groupBox_0.BackgroundImage = (Image)null;
        this.groupBox_0.Controls.Add((Control)this.label_14);
        this.groupBox_0.Controls.Add((Control)this.label_13);
        this.groupBox_0.Controls.Add((Control)this.comboBox_DataEntryPoint);
        this.groupBox_0.Controls.Add((Control)this.label_12);
        this.groupBox_0.Controls.Add((Control)this.label_6);
        this.groupBox_0.Controls.Add((Control)this.label_7);
        this.groupBox_0.Controls.Add((Control)this.label_8);
        this.groupBox_0.Controls.Add((Control)this.label_9);
        this.groupBox_0.Controls.Add((Control)this.textBox_PixelsPerPort);
        this.groupBox_0.Controls.Add((Control)this.label_0);
        this.groupBox_0.Controls.Add((Control)this.label_1);
        this.groupBox_0.Controls.Add((Control)this.textBox_HorizontalPixels);
        this.groupBox_0.Controls.Add((Control)this.label_5);
        this.groupBox_0.Controls.Add((Control)this.textBox_VerticalPixels);
        this.groupBox_0.Controls.Add((Control)this.label_4);
        this.groupBox_0.Controls.Add((Control)this.label_2);
        this.groupBox_0.Controls.Add((Control)this.label_3);
        this.groupBox_0.Font = (Font)null;
        this.groupBox_0.Name = "groupBox1";
        this.groupBox_0.TabStop = false;
        this.label_14.AccessibleDescription = (string)null;
        this.label_14.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_14, "label17");
        this.label_14.Font = (Font)null;
        this.label_14.Name = "label17";
        this.label_13.AccessibleDescription = (string)null;
        this.label_13.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_13, "label16");
        this.label_13.Font = (Font)null;
        this.label_13.Name = "label16";
        this.comboBox_DataEntryPoint.AccessibleDescription = (string)null;
        this.comboBox_DataEntryPoint.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.comboBox_DataEntryPoint, "comboBox1");
        this.comboBox_DataEntryPoint.BackgroundImage = (Image)null;
        this.comboBox_DataEntryPoint.Font = (Font)null;
        this.comboBox_DataEntryPoint.FormattingEnabled = true;
        this.comboBox_DataEntryPoint.Items.AddRange(new object[9]
        {
     (object) componentResourceManager.GetString("comboBox1.Items"),
     (object) componentResourceManager.GetString("comboBox1.Items1"),
     (object) componentResourceManager.GetString("comboBox1.Items2"),
     (object) componentResourceManager.GetString("comboBox1.Items3"),
     (object) componentResourceManager.GetString("comboBox1.Items4"),
     (object) componentResourceManager.GetString("comboBox1.Items5"),
     (object) componentResourceManager.GetString("comboBox1.Items6"),
     (object) componentResourceManager.GetString("comboBox1.Items7"),
     (object) componentResourceManager.GetString("comboBox1.Items8")
        });
        this.comboBox_DataEntryPoint.Name = "comboBox1";
        this.comboBox_DataEntryPoint.SelectedIndexChanged += new EventHandler(this.comboBox_0_SelectedIndexChanged);
        this.label_12.AccessibleDescription = (string)null;
        this.label_12.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_12, "label14");
        this.label_12.Font = (Font)null;
        this.label_12.Name = "label14";
        this.label_6.AccessibleDescription = (string)null;
        this.label_6.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_6, "label11");
        this.label_6.Font = (Font)null;
        this.label_6.Name = "label11";
        this.label_7.AccessibleDescription = (string)null;
        this.label_7.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_7, "label10");
        this.label_7.Font = (Font)null;
        this.label_7.Name = "label10";
        this.label_8.AccessibleDescription = (string)null;
        this.label_8.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_8, "label9");
        this.label_8.Font = (Font)null;
        this.label_8.Name = "label9";
        this.label_9.AccessibleDescription = (string)null;
        this.label_9.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_9, "label8");
        this.label_9.Font = (Font)null;
        this.label_9.Name = "label8";
        this.button_1.AccessibleDescription = (string)null;
        this.button_1.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.button_1, "button2");
        this.button_1.BackgroundImage = (Image)null;
        this.button_1.DialogResult = DialogResult.Cancel;
        this.button_1.Font = (Font)null;
        this.button_1.Name = "button2";
        this.button_1.UseVisualStyleBackColor = true;
        this.button_1.Click += new EventHandler(this.button_1_Click);
        this.label_10.AccessibleDescription = (string)null;
        this.label_10.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_10, "label12");
        this.label_10.Font = (Font)null;
        this.label_10.Name = "label12";
        this.label_11.AccessibleDescription = (string)null;
        this.label_11.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_11, "label13");
        this.label_11.Font = (Font)null;
        this.label_11.Name = "label13";
        this.pictureBox_0.AccessibleDescription = (string)null;
        this.pictureBox_0.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.pictureBox_0, "pictureBox1");
        this.pictureBox_0.BackgroundImage = (Image)null;
        this.pictureBox_0.Font = (Font)null;
        this.pictureBox_0.ImageLocation = (string)null;
        this.pictureBox_0.Name = "pictureBox1";
        this.pictureBox_0.TabStop = false;
        this.imageList_0.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageList1.ImageStream");
        this.imageList_0.TransparentColor = Color.Transparent;
        this.imageList_0.Images.SetKeyName(0, "上左横向.bmp");
        this.imageList_0.Images.SetKeyName(1, "上右横向.bmp");
        this.imageList_0.Images.SetKeyName(2, "上左纵向.bmp");
        this.imageList_0.Images.SetKeyName(3, "上右纵向.bmp");
        this.imageList_0.Images.SetKeyName(4, "下左横向.bmp");
        this.imageList_0.Images.SetKeyName(5, "下右横向.bmp");
        this.imageList_0.Images.SetKeyName(6, "下左纵向.bmp");
        this.imageList_0.Images.SetKeyName(7, "下右纵向.bmp");
        this.imageList_0.Images.SetKeyName(8, "Z.bmp");
        this.AccessibleDescription = (string)null;
        this.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this, "$this");
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackgroundImage = (Image)null;
        this.ControlBox = false;
        this.Controls.Add((Control)this.pictureBox_0);
        this.Controls.Add((Control)this.label_11);
        this.Controls.Add((Control)this.label_10);
        this.Controls.Add((Control)this.button_1);
        this.Controls.Add((Control)this.groupBox_0);
        this.Controls.Add((Control)this.button_0);
        this.Font = (Font)null;
        this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        this.Icon = (Icon)null;
        this.Name = "Set_Form";
        this.groupBox_0.ResumeLayout(false);
        this.groupBox_0.PerformLayout();
        ((ISupportInitialize)this.pictureBox_0).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
