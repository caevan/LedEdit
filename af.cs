// Decompiled with JetBrains decompiler
// Type: af
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

public class af : Form
{
  private IContainer icontainer_0;
  private Label label_0;
  private TextBox textBox_0;
  private Button button_0;
  private Label label_1;

    protected override void Dispose(bool disposing)
    {
        if (disposing && this.icontainer_0 != null)
            this.icontainer_0.Dispose();

        base.Dispose(disposing);
    }

    private void method_0()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (af));
    this.label_0 = new Label();
    this.textBox_0 = new TextBox();
    this.button_0 = new Button();
    this.label_1 = new Label();
    this.SuspendLayout();
    this.label_0.AccessibleDescription = (string) null;
    this.label_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_0, Module.a("슭톯킱톳\uDAB5覷", 8));
    this.label_0.Font = (Font) null;
    this.label_0.Name = Module.a("슭톯킱톳\uDAB5覷", 8);
    this.textBox_0.AccessibleDescription = (string) null;
    this.textBox_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.textBox_0, Module.a("\uDAAD햯쪱삳\uF4B5ힷ승趻", 8));
    this.textBox_0.BackgroundImage = (Image) null;
    this.textBox_0.Font = (Font) null;
    this.textBox_0.Name = Module.a("\uDAAD햯쪱삳\uF4B5ힷ승趻", 8);
    this.button_0.AccessibleDescription = (string) null;
    this.button_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.button_0, Module.a("청얯욱삳\uD9B5횷讹", 8));
    this.button_0.BackgroundImage = (Image) null;
    this.button_0.Font = (Font) null;
    this.button_0.Name = Module.a("청얯욱삳\uD9B5횷讹", 8);
    this.button_0.UseVisualStyleBackColor = true;
    this.button_0.Click += new EventHandler(this.button_0_Click);
    this.label_1.AccessibleDescription = (string) null;
    this.label_1.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_1, Module.a("슭톯킱톳\uDAB5誷", 8));
    this.label_1.Font = (Font) null;
    this.label_1.Name = Module.a("슭톯킱톳\uDAB5誷", 8);
    this.AccessibleDescription = (string) null;
    this.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this, Module.a("読쒯\uDAB1\uDDB3억", 8));
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackgroundImage = (Image) null;
    this.ControlBox = false;
    this.Controls.Add((Control) this.label_1);
    this.Controls.Add((Control) this.button_0);
    this.Controls.Add((Control) this.textBox_0);
    this.Controls.Add((Control) this.label_0);
    this.Font = (Font) null;
    this.Icon = (Icon) null;
    this.Name = Module.a("ﶭ햯욱\uEBB3ﾵ\uE8B7", 8);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public af() => this.method_0();

  private void button_0_Click(object sender, EventArgs e)
  {
    int int_0 = 19;
    byte num1;
    try
    {
      num1 = Convert.ToByte(this.textBox_0.Text);
    }
    catch
    {
      this.method_1(Module.a("ﲸ즺쾼킾돀\uE2C2", int_0));
      this.textBox_0.Focus();
      return;
    }
    if (num1 >= (byte) 1 && num1 <= (byte) 128)
    {
      byte num2 = (byte) ((uint) num1 - 1U);
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.Title = Module.a("\uEAB8\uDABA쮼\uDABE\uE1C0ꋂ뛄\uE9C6\uE7C8\uE5CA", int_0);
      saveFileDialog.AddExtension = true;
      saveFileDialog.DefaultExt = Module.a("햸\uDEBA\uD9BC", int_0);
      saveFileDialog.Filter = Module.a("\uF5B8\uDEBA\uD9BC鞾\uEBC0\uEDC2꧄ꋆ귈\uE2CA뇌\uE5CE\uFFD0뿒냔돖ꗘ髚뇜돞쇠ꗢ賤详賨쏪쟬쇮\uDBF0\uDAF2觴\uDDF6ퟸ퇺", int_0);
      if (saveFileDialog.ShowDialog() == DialogResult.OK)
      {
        FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write);
        BufferedStream bufferedStream = new BufferedStream((Stream) fileStream);
        byte[] buffer = new byte[512];
        new Random().NextBytes(buffer);
        buffer[0] = (byte) 114;
        buffer[1] = (byte) 122;
        buffer[2] = (byte) 98;
        buffer[3] = (byte) 118;
        buffer[4] = (byte) 48;
        buffer[5] = (byte) 48;
        buffer[6] = (byte) 49;
        buffer[32] = (byte) 85;
        buffer[33] = (byte) 170;
        buffer[34] = num2;
        bufferedStream.Write(buffer, 0, 512);
        bufferedStream.Flush();
        bufferedStream.Close();
        fileStream.Close();
      }
      this.Close();
    }
    else
    {
      this.method_1(Module.a("ﲸ즺쾼킾돀\uE2C2", int_0));
      this.textBox_0.Focus();
    }
  }

  private void method_1(string string_0)
  {
    MessageDialog aa = new MessageDialog();
    aa.label_0.Text = string_0;
    int num = (int) aa.ShowDialog();
  }
}
