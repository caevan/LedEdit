// Decompiled with JetBrains decompiler
// Type: r
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class r : Form
{
  private IContainer icontainer_0;
  public Label label_0;

  public r() => this.method_0();

    protected override void Dispose(bool disposing)
    {
        if (disposing && this.icontainer_0 != null)
            this.icontainer_0.Dispose();

        base.Dispose(disposing);
    }

    private void method_0()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (r));
    this.label_0 = new Label();
    this.SuspendLayout();
    this.label_0.AccessibleDescription = (string) null;
    this.label_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_0, Module.a("\uDBB6\uD8B8\uD9BA\uD8BC펾\uF0C0", 17));
    this.label_0.Font = (Font) null;
    this.label_0.Name = Module.a("\uDBB6\uD8B8\uD9BA\uD8BC펾\uF0C0", 17);
    this.AccessibleDescription = (string) null;
    this.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this, Module.a("鎶춸펺풼첾", 17));
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackgroundImage = (Image) null;
    this.ControlBox = false;
    this.Controls.Add((Control) this.label_0);
    this.Font = (Font) null;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Icon = (Icon) null;
    this.Name = Module.a("\uE7B6쮸\uDEBA\uE2BC쮾ꣀ냂귄껆", 17);
    this.TopMost = true;
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
