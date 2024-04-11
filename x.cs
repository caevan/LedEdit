// Decompiled with JetBrains decompiler
// Type: x
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

public class x : Form
{
  private IContainer icontainer_0;
  private Label label_0;
  private Label label_1;
  private Button button_0;

  public x()
  {
    this.method_0();
    this.label_1.Text = DateTime.Now.ToString();
  }

  private void button_0_Click(object sender, EventArgs e)
  {
    SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Title = "Save as..."; // Module.a("\uE2B0튲쎴튶馸\uDABA캼醾\uEFC0\uEDC2", 11);
    saveFileDialog.AddExtension = true;
        saveFileDialog.DefaultExt = "led"; // Module.a("\uDDB0횲톴", 11);
        saveFileDialog.Filter = "Led(*.led)|*.led|All File(*.*)|*.*"; // Module.a("ﶰ횲톴龶鎸閺톼\uDABEꗀ\uEAC2맄\uEDC6\uE7C8\uA7CA\uA8CCꯎ귐鋒맔믖律鷚드돞蓠쯢쿤짦쏨싪釬엮\uDFF0\uD9F2", 11);
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
      buffer[35] = (byte) 1;
      buffer[36] = (byte) 197;
      DateTime now = DateTime.Now;
      now.AddMinutes(1.0);
      buffer[37] = (byte) (now.Year - 2000);
      buffer[38] = (byte) now.Month;
      buffer[39] = (byte) now.Day;
      buffer[40] = (byte) now.DayOfWeek;
      buffer[41] = (byte) now.Hour;
      buffer[42] = (byte) now.Minute;
      now.AddMinutes(1.0);
      bufferedStream.Write(buffer, 0, 512);
      bufferedStream.Flush();
      bufferedStream.Close();
      fileStream.Close();
    }
    this.Close();
  }

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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (x));
    this.label_0 = new Label();
    this.label_1 = new Label();
    this.button_0 = new Button();
    this.SuspendLayout();
    this.label_0.AccessibleDescription = (string) null;
    this.label_0.AccessibleName = (string) null;
 //   componentResourceManager.ApplyResources((object) this.label_0, Module.a("용춫청햯\uDEB1薳", 4));
    componentResourceManager.ApplyResources((object)this.label_0, "label1");
        this.label_0.Font = (Font) null;
        this.label_0.Name = "label1"; // Module.a("용춫청햯\uDEB1薳", 4);
    this.label_1.AccessibleDescription = (string) null;
    this.label_1.AccessibleName = (string) null;
 //   componentResourceManager.ApplyResources((object) this.label_1, Module.a("용춫청햯\uDEB1蚳", 4));
        componentResourceManager.ApplyResources((object)this.label_1, "label2");
        this.label_1.Font = (Font) null;
        this.label_1.Name = "label2"; //Module.a("용춫청햯\uDEB1蚳", 4);
    this.button_0.AccessibleDescription = (string) null;
    this.button_0.AccessibleName = (string) null;
 //   componentResourceManager.ApplyResources((object) this.button_0, Module.a("좩\uD9AB\uDAAD쒯\uDDB1\uDAB3螵", 4));
        componentResourceManager.ApplyResources((object)this.button_0, "button1");
        this.button_0.BackgroundImage = (Image) null;
    this.button_0.Font = (Font) null;
        this.button_0.Name = "button1"; //Module.a("좩\uD9AB\uDAAD쒯\uDDB1\uDAB3螵", 4);
    this.button_0.UseVisualStyleBackColor = true;
    this.button_0.Click += new EventHandler(this.button_0_Click);
    this.AccessibleDescription = (string) null;
    this.AccessibleName = (string) null;
 //   componentResourceManager.ApplyResources((object) this, Module.a("躩\uD8AB욭\uD9AF솱", 4));
        componentResourceManager.ApplyResources((object)this, "$this");
        this.AutoScaleMode = AutoScaleMode.Font;
    this.BackgroundImage = (Image) null;
    this.ControlBox = false;
    this.Controls.Add((Control) this.button_0);
    this.Controls.Add((Control) this.label_1);
    this.Controls.Add((Control) this.label_0);
    this.Font = (Font) null;
    this.Icon = (Icon) null;
        this.Name = "Setting_times"; //Module.a("囹즫\uDAAD쒯\uDBB1\uDAB3통\uE7B7캹햻펽ꖿ뇁", 4);
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
