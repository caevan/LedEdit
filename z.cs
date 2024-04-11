// Decompiled with JetBrains decompiler
// Type: z
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class z : Form
{
  private IContainer icontainer_0;
  private Label label_0;
  private Button button_0;
  private Button button_1;

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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (z));
    this.label_0 = new Label();
    this.button_0 = new Button();
    this.button_1 = new Button();
    this.SuspendLayout();
    this.label_0.AccessibleDescription = (string) null;
    this.label_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_0, Module.a("삫쾭튯ힱ\uD8B3螵", 6));
    this.label_0.Name = Module.a("삫쾭튯ힱ\uD8B3螵", 6);
    this.button_0.AccessibleDescription = (string) null;
    this.button_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.button_0, Module.a("캫\uDBAD쒯욱\uDBB3\uD8B5覷", 6));
    this.button_0.BackgroundImage = (Image) null;
    this.button_0.DialogResult = DialogResult.OK;
    this.button_0.Font = (Font) null;
    this.button_0.Name = Module.a("캫\uDBAD쒯욱\uDBB3\uD8B5覷", 6);
    this.button_0.UseVisualStyleBackColor = true;
    this.button_1.AccessibleDescription = (string) null;
    this.button_1.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.button_1, Module.a("캫\uDBAD쒯욱\uDBB3\uD8B5誷", 6));
    this.button_1.BackgroundImage = (Image) null;
    this.button_1.DialogResult = DialogResult.Cancel;
    this.button_1.Font = (Font) null;
    this.button_1.Name = Module.a("캫\uDBAD쒯욱\uDBB3\uD8B5誷", 6);
    this.button_1.UseVisualStyleBackColor = true;
    this.button_1.Click += new EventHandler(this.button_1_Click);
    this.AccessibleDescription = (string) null;
    this.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this, Module.a("被\uDAAD\uD8AF\uDBB1잳", 6));
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackgroundImage = (Image) null;
    this.ControlBox = false;
    this.Controls.Add((Control) this.button_1);
    this.Controls.Add((Control) this.button_0);
    this.Controls.Add((Control) this.label_0);
    this.Font = (Font) null;
    this.Icon = (Icon) null;
    this.Name = Module.a("ﾫ쾭욯ힱ\uF6B3\uD9B5삷", 6);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public z() => this.method_0();

  private void button_1_Click(object sender, EventArgs e)
  {
  }
}
