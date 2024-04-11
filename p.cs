// Decompiled with JetBrains decompiler
// Type: p
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class p : Form
{
  private IContainer icontainer_0;
  private Button button_0;
  private Button button_1;
  private Label label_0;

    protected override void Dispose(bool disposing)
    {
        if (disposing && this.icontainer_0 != null)
            this.icontainer_0.Dispose();

        base.Dispose(disposing);
    }

    private void method_0()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (p));
    this.button_0 = new Button();
    this.button_1 = new Button();
    this.label_0 = new Label();
    this.SuspendLayout();
    this.button_0.AccessibleDescription = (string) null;
    this.button_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.button_0, Module.a("쮨\uDEAA\uD9AC\uDBAE\uDEB0\uDDB2蒴", 3));
    this.button_0.BackgroundImage = (Image) null;
    this.button_0.DialogResult = DialogResult.OK;
    this.button_0.Font = (Font) null;
    this.button_0.Name = Module.a("쮨\uDEAA\uD9AC\uDBAE\uDEB0\uDDB2蒴", 3);
    this.button_0.UseVisualStyleBackColor = true;
    this.button_1.AccessibleDescription = (string) null;
    this.button_1.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.button_1, Module.a("쮨\uDEAA\uD9AC\uDBAE\uDEB0\uDDB2螴", 3));
    this.button_1.BackgroundImage = (Image) null;
    this.button_1.DialogResult = DialogResult.Cancel;
    this.button_1.Font = (Font) null;
    this.button_1.Name = Module.a("쮨\uDEAA\uD9AC\uDBAE\uDEB0\uDDB2螴", 3);
    this.button_1.UseVisualStyleBackColor = true;
    this.label_0.AccessibleDescription = (string) null;
    this.label_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_0, Module.a("얨쪪쾬쪮\uDDB0芲", 3));
    this.label_0.Name = Module.a("얨쪪쾬쪮\uDDB0芲", 3);
    this.AccessibleDescription = (string) null;
    this.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this, Module.a("趨\uDFAA얬욮슰", 3));
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackgroundImage = (Image) null;
    this.ControlBox = false;
    this.Controls.Add((Control) this.label_0);
    this.Controls.Add((Control) this.button_1);
    this.Controls.Add((Control) this.button_0);
    this.Font = (Font) null;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Icon = (Icon) null;
    this.Name = Module.a("\uE0A8\uD8AA\uF2AC\uECAE\uDDB0횲잴횶\uE6B8\uE3BA풼\uDEBE껀꓂냄\uA8C6", 3);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public p() => this.method_0();
}
