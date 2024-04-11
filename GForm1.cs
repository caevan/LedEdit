// Decompiled with JetBrains decompiler
// Type: GForm1
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class GForm1 : Form
{
  private IContainer icontainer_0;

  public GForm1() => this.method_0();

    protected override void Dispose(bool disposing)
    {
        if (disposing && this.icontainer_0 != null)
            this.icontainer_0.Dispose();

        base.Dispose(disposing);
    }

    private void method_0()
  {
    this.SuspendLayout();
    this.AutoScaleDimensions = new SizeF(6f, 12f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackgroundImageLayout = ImageLayout.Stretch;
    this.ClientSize = new Size(656, 450);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Name = Module.a("\uE2B2\uDCB4\uF3B6횸햺\uDABC\uE0BE釀ꫂꛄ돆", 13);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = Module.a("\uE2B2\uDCB4\uF3B6횸햺\uDABC\uE0BE釀ꫂꛄ돆", 13);
    this.ResumeLayout(false);
  }
}
