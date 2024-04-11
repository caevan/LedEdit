// Decompiled with JetBrains decompiler
// Type: GForm0
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class GForm0 : Form
{
  private IContainer icontainer_0;
  private PictureBox pictureBox_0;
  private RadioButton radioButton_0;
  private GroupBox groupBox_0;
  private RadioButton radioButton_1;
  private RadioButton radioButton_2;
  private TextBox textBox_0;
  private Button button_0;
  private ImageList imageList_0;

  public GForm0()
  {
    this.method_1();
    this.method_0();
  }

  private void method_0()
  {
    int int_0 = 5;
    switch (c.byte_9)
    {
      case 1:
        if (this.radioButton_0.Checked)
        {
          this.pictureBox_0.Image = this.imageList_0.Images[0];
          if (c.useEnglishLanguage)
            this.textBox_0.Text = Module.a("\uEAAA\uD9AC\uDBAE킰킲\uDDB4\uDAB6\uDCB8햺즼龾꿀곂\uE5C4듆마껊껌ꛎ냐뿒\uF5D4ꗖ볘\uAADA\uA8DC뛞鏠蛢裤苦蟨\u9FEA黬쏮퇰鋲蛴ퟶ闸铺鏼飾℀戂瘄✆紈挊栌⼎攐瘒洔挖㤘漚爜㼞唠䬢䀤ܦ䜨个䰬崮匰䨲ᔴ嘶圸强ᴼ嘾⽀ⵂ⁄㕆楈⡊\u244C㵎㉐㽒ご策祘㩚㍜㭞䅠\u0A62\u0B64䝦ᵨͪ\u086C佮ተᩲݴᑶᕸṺ嵼Ṿ\uF580\uF782\uE484\uE486\uE188\uE68A\uE88C\uE18E\uE590뎒\uF694\uF696\uF798뮚ﾜ爵膠잢첤풦쪨쒪쎬솮풰킲솴튶\uDDB8鞺鶼쾾ꃀ뫂\uE5C4ꛆ뷈뿊\uA8CCꇎꗐ뫒뫔맖律꿚닜\uFFDE苠賢诤触賨裪駬쿮藰鯲郴ퟶ跸黺藼课ⴀ⌂焄漆氈⬊氌笎攐爒瘔编琘縚猜欞Ġ䈢嘤ܦ䨨䜪䈬尮吰ጲ䄴堶ᤸ伺唼娾慀⅂⑄㑆⁈⡊浌㽎㹐㩒㭔⍖祘㑚㭜罞ᙠౢᝤͦᩨ䕪", int_0);
          else
            this.textBox_0.Text = Module.a("甥ዒໂ룗쫀㿟㘿ﯔ鞺埯㸷\u1F4F暡\uF596䂣麓侼襚ṁ嶄햅傅ꒅ㚋\uF7DAꮂ쮐즷\uE5B5悵㥩嚖ҹࢢ䊋\uF1AF\uDFF2ᶘ\uF897\u2777庙窙ꢥ蕶\uF567᱔⬆힇둴ぐ\uE05D\uEC90玅쒛遳乃齬\uE74Bꙮ༠", int_0);
          c.byte_10 = (byte) 0;
          break;
        }
        if (this.radioButton_2.Checked)
        {
          this.pictureBox_0.Image = this.imageList_0.Images[1];
          if (c.useEnglishLanguage)
            this.textBox_0.Text = Module.a("\uE8AA얬캮쎰튲횴쎶\uDCB8즺캼龾곀뛂뛄돆\uE9C8꧊\uA8CC\uEFCE닐볒믔맖볘룚\uA9DC뫞藠쏢釤裦짨\u9FEA藬諮퇰釲铴蓶郸裺\uDDFC郾最⌂爄栆笈漊縌⌎ㄐ朒純爖㤘稚検欞䀠䀢䴤䨦䰨䔪夬\u0F2E䔰尲ᔴ䌶儸帺ᴼ嘾⽀ⵂ⁄㕆楈⡊\u244C㵎㉐㽒ご睖㡘⡚絜㍞\u0E60ൢɤ䝦\u0868ᡪ䵬੮ݰᙲ᭴孶奸\u197A\u087C\u0B7Eꆀ\uE082\uE484\uE986꺈ﾊ권\uEB8E\uF890\uE092\uF694\uF896\uF798\uF59A\uF89Cﲞ햠莢쒤펦\uDDA8쪪캬잮\uDCB0횲\uDBB4쎶鞸", int_0);
          else
            this.textBox_0.Text = Module.a("ⳏ\uFAF7櫱쨨㈻欻ዕ觪㳟\uEAE7㯈㮗窲\uE9C4᥉皶↙䱅ᅁ\uE182햅傅ꒅ㚋\uF7DA鮓\uF0B8㽯岜\uE8AAᩦ䒍\uEBB5쏬", int_0);
          c.byte_10 = (byte) 1;
          break;
        }
        if (!this.radioButton_1.Checked)
          break;
        this.pictureBox_0.Image = this.imageList_0.Images[2];
        if (c.useEnglishLanguage)
          this.textBox_0.Text = Module.a("ﲪ슬\uDDAE햰삲閴\uDAB6첸좺즼龾ꏀꛂ\uE5C4꓆ꛈꗊꏌ\uAACE닐\uA7D2냔돖律꿚닜\uFFDE闠询胤쟦鷨軪闬鯮퇰鳲鏴ퟶ跸鏺飼\uDFFE挀戂瘄渆稈⬊紌怎砐紒愔搖㔘䤚爜樞传䜢Ԥ䨦尨堪夬\u0F2E匰嘲ᔴ吶嘸唺匼娾≀㝂⁄⍆楈㽊≌潎═㭒ご睖㩘㹚㍜⭞Ѡᅢ䭤", int_0);
        else
          this.textBox_0.Text = Module.a("ⳏ\uFAF7櫱쨨㈻欻ዕ觪㳟\uEAE7㯈㮗窲\uE9C4솑ಗ끒䱅ᅁ\uE182ﺜᚋ溦\uF7D8", int_0);
        c.byte_10 = (byte) 2;
        break;
      case 2:
        if (this.radioButton_0.Checked)
        {
          this.pictureBox_0.Image = this.imageList_0.Images[3];
          if (c.useEnglishLanguage)
            this.textBox_0.Text = Module.a("\uEAAA\uD9AC\uDBAE킰킲\uDDB4\uDAB6\uDCB8햺즼龾꿀곂\uE5C4듆마껊껌ꛎ냐뿒\uF5D4ꗖ볘\uAADA\uA8DC뛞鏠蛢裤苦蟨\u9FEA黬쏮퇰鋲蛴ퟶ闸铺鏼飾℀戂瘄✆紈挊栌⼎攐瘒洔挖㤘漚爜㼞唠䬢䀤ܦ䜨个䰬崮匰䨲ᔴ嘶圸强ᴼ嘾⽀ⵂ⁄㕆楈⡊\u244C㵎㉐㽒ご策祘㩚㍜㭞䅠\u0A62\u0B64䝦ᵨͪ\u086C佮ተᩲݴᑶᕸṺ嵼Ṿ\uF580\uF782\uE484\uE486\uE188\uE68A\uE88C\uE18E\uE590뎒\uF694\uF696\uF798뮚ﾜ爵膠잢첤풦쪨쒪쎬솮풰킲솴튶\uDDB8鞺鶼쾾ꃀ뫂\uE5C4ꛆ뷈뿊\uA8CCꇎꗐ뫒뫔맖律꿚닜\uFFDE苠賢诤触賨裪駬쿮藰鯲郴ퟶ跸黺藼课ⴀ⌂焄漆氈⬊氌笎攐爒瘔编琘縚猜欞Ġ䈢嘤ܦ䨨䜪䈬尮吰ጲ䄴堶ᤸ伺唼娾慀⅂⑄㑆⁈⡊浌㽎㹐㩒㭔⍖祘㑚㭜罞ᙠౢᝤͦᩨ䕪", int_0);
          else
            this.textBox_0.Text = Module.a("甥ዒໂ룗쫀㿟㘿ﯔ鞺埯㸷\u1F4F暡\uF596䂣麓侼襚ṁ嶄햅傅ꒅ㚋\uF7DAꮂ쮐즷\uE5B5悵㥩嚖ҹࢢ䊋\uF1AF\uDFF2ᶘ\uF897\u2777庙窙ꢥ蕶\uF567᱔⬆힇둴ぐ\uE05D\uEC90玅쒛遳乃齬\uE74Bꙮ༠", int_0);
          c.byte_10 = (byte) 0;
          break;
        }
        if (this.radioButton_2.Checked)
        {
          this.pictureBox_0.Image = this.imageList_0.Images[4];
          if (c.useEnglishLanguage)
            this.textBox_0.Text = Module.a("\uE8AA얬캮쎰튲횴쎶\uDCB8즺캼龾곀뛂뛄돆\uE9C8꧊\uA8CC\uEFCE닐볒믔맖볘룚\uA9DC뫞藠쏢釤裦짨\u9FEA藬諮퇰釲铴蓶郸裺\uDDFC郾最⌂爄栆笈漊縌⌎ㄐ朒純爖㤘稚検欞䀠䀢䴤䨦䰨䔪夬\u0F2E䔰尲ᔴ䌶儸帺ᴼ嘾⽀ⵂ⁄㕆楈⡊\u244C㵎㉐㽒ご睖㡘⡚絜㍞\u0E60ൢɤ䝦\u0868ᡪ䵬੮ݰᙲ᭴孶奸\u197A\u087C\u0B7Eꆀ\uE082\uE484\uE986꺈ﾊ권\uEB8E\uF890\uE092\uF694\uF896\uF798\uF59A\uF89Cﲞ햠莢쒤펦\uDDA8쪪캬잮\uDCB0횲\uDBB4쎶鞸", int_0);
          else
            this.textBox_0.Text = Module.a("ⳏ\uFAF7櫱쨨㈻欻ዕ觪㳟\uEAE7㯈㮗窲\uE9C4᥉皶↙䱅ᅁ\uE182햅傅ꒅ㚋\uF7DA鮓\uF0B8㽯岜\uE8AAᩦ䒍\uEBB5쏬", int_0);
          c.byte_10 = (byte) 1;
          break;
        }
        if (!this.radioButton_1.Checked)
          break;
        this.pictureBox_0.Image = this.imageList_0.Images[5];
        if (c.useEnglishLanguage)
          this.textBox_0.Text = Module.a("ﲪ슬\uDDAE햰삲閴\uDAB6첸좺즼龾ꏀꛂ\uE5C4꓆ꛈꗊꏌ\uAACE닐\uA7D2냔돖律꿚닜\uFFDE闠询胤쟦鷨軪闬鯮퇰鳲鏴ퟶ跸鏺飼\uDFFE挀戂瘄渆稈⬊紌怎砐紒愔搖㔘䤚爜樞传䜢Ԥ䨦尨堪夬\u0F2E匰嘲ᔴ吶嘸唺匼娾≀㝂⁄⍆楈㽊≌潎═㭒ご睖㩘㹚㍜⭞Ѡᅢ䭤", int_0);
        else
          this.textBox_0.Text = Module.a("ⳏ\uFAF7櫱쨨㈻欻ዕ觪㳟\uEAE7㯈㮗窲\uE9C4솑ಗ끒䱅ᅁ\uE182ﺜᚋ溦\uF7D8", int_0);
        c.byte_10 = (byte) 2;
        break;
    }
  }

  private void radioButton_0_CheckedChanged(object sender, EventArgs e) => this.method_0();

  private void radioButton_2_CheckedChanged(object sender, EventArgs e) => this.method_0();

  private void radioButton_1_CheckedChanged(object sender, EventArgs e) => this.method_0();

    protected override void Dispose(bool disposing)
    {
        if (disposing && this.icontainer_0 != null)
            this.icontainer_0.Dispose();

        base.Dispose(disposing);
    }

    private void method_1()
  {
    this.icontainer_0 = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (GForm0));
    this.pictureBox_0 = new PictureBox();
    this.radioButton_0 = new RadioButton();
    this.groupBox_0 = new GroupBox();
    this.radioButton_1 = new RadioButton();
    this.radioButton_2 = new RadioButton();
    this.textBox_0 = new TextBox();
    this.button_0 = new Button();
    this.imageList_0 = new ImageList(this.icontainer_0);
    ((ISupportInitialize) this.pictureBox_0).BeginInit();
    this.groupBox_0.SuspendLayout();
    this.SuspendLayout();
    this.pictureBox_0.AccessibleDescription = (string) null;
    this.pictureBox_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.pictureBox_0, Module.a("좷펹\uDFBB쪽떿냁ꇃ蓅\uA7C7닉\uFDCB", 18));
    this.pictureBox_0.BackgroundImage = (Image) null;
    this.pictureBox_0.Font = (Font) null;
    this.pictureBox_0.ImageLocation = (string) null;
    this.pictureBox_0.Name = Module.a("좷펹\uDFBB쪽떿냁ꇃ蓅\uA7C7닉\uFDCB", 18);
    this.pictureBox_0.TabStop = false;
    this.radioButton_0.AccessibleDescription = (string) null;
    this.radioButton_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.radioButton_0, Module.a("쪷\uDBB9\uD8BBힽ꾿胁뇃닅볇ꗉꋋￍ", 18));
    this.radioButton_0.BackgroundImage = (Image) null;
    this.radioButton_0.Checked = true;
    this.radioButton_0.Font = (Font) null;
    this.radioButton_0.Name = Module.a("쪷\uDBB9\uD8BBힽ꾿胁뇃닅볇ꗉꋋￍ", 18);
    this.radioButton_0.TabStop = true;
    this.radioButton_0.UseVisualStyleBackColor = true;
    this.radioButton_0.CheckedChanged += new EventHandler(this.radioButton_0_CheckedChanged);
    this.groupBox_0.AccessibleDescription = (string) null;
    this.groupBox_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.groupBox_0, Module.a("\uDFB7좹펻쮽낿胁ꯃ뻅劉", 18));
    this.groupBox_0.BackgroundImage = (Image) null;
    this.groupBox_0.Controls.Add((Control) this.radioButton_1);
    this.groupBox_0.Controls.Add((Control) this.radioButton_2);
    this.groupBox_0.Controls.Add((Control) this.radioButton_0);
    this.groupBox_0.Font = (Font) null;
    this.groupBox_0.Name = Module.a("\uDFB7좹펻쮽낿胁ꯃ뻅劉", 18);
    this.groupBox_0.TabStop = false;
    this.radioButton_1.AccessibleDescription = (string) null;
    this.radioButton_1.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.radioButton_1, Module.a("쪷\uDBB9\uD8BBힽ꾿胁뇃닅볇ꗉꋋ\uFDCD", 18));
    this.radioButton_1.BackgroundImage = (Image) null;
    this.radioButton_1.Font = (Font) null;
    this.radioButton_1.Name = Module.a("쪷\uDBB9\uD8BBힽ꾿胁뇃닅볇ꗉꋋ\uFDCD", 18);
    this.radioButton_1.UseVisualStyleBackColor = true;
    this.radioButton_1.CheckedChanged += new EventHandler(this.radioButton_1_CheckedChanged);
    this.radioButton_2.AccessibleDescription = (string) null;
    this.radioButton_2.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.radioButton_2, Module.a("쪷\uDBB9\uD8BBힽ꾿胁뇃닅볇ꗉꋋﳍ", 18));
    this.radioButton_2.BackgroundImage = (Image) null;
    this.radioButton_2.Font = (Font) null;
    this.radioButton_2.Name = Module.a("쪷\uDBB9\uD8BBힽ꾿胁뇃닅볇ꗉꋋﳍ", 18);
    this.radioButton_2.UseVisualStyleBackColor = true;
    this.radioButton_2.CheckedChanged += new EventHandler(this.radioButton_2_CheckedChanged);
    this.textBox_0.AccessibleDescription = (string) null;
    this.textBox_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.textBox_0, Module.a("첷\uDFB9쒻쪽芿귁볃\uF7C5", 18));
    this.textBox_0.BackgroundImage = (Image) null;
    this.textBox_0.BorderStyle = BorderStyle.FixedSingle;
    this.textBox_0.Font = (Font) null;
    this.textBox_0.Name = Module.a("첷\uDFB9쒻쪽芿귁볃\uF7C5", 18);
    this.textBox_0.ReadOnly = true;
    this.button_0.AccessibleDescription = (string) null;
    this.button_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.button_0, Module.a("\uDAB7쾹좻쪽꾿곁\uF5C3", 18));
    this.button_0.BackgroundImage = (Image) null;
    this.button_0.DialogResult = DialogResult.OK;
    this.button_0.Font = (Font) null;
    this.button_0.Name = Module.a("\uDAB7쾹좻쪽꾿곁\uF5C3", 18);
    this.button_0.UseVisualStyleBackColor = true;
    this.imageList_0.ImageStream = (ImageListStreamer) componentResourceManager.GetObject(Module.a("톷ힹ\uDDBB\uD9BDꖿ軁귃뗅볇\uFBC9\uE2CB蟍뷏돑돓돕诗껙껛믝臟迡", 18));
    this.imageList_0.TransparentColor = Color.Transparent;
    this.imageList_0.Images.SetKeyName(0, Module.a("\uDCB7승\uDABB\uE1BD\uF1BF\uECC1껃뛅꿇", 18));
    this.imageList_0.Images.SetKeyName(1, Module.a("\uDCB7승\uDABB\uE1BD\uF2BF\uECC1껃뛅꿇", 18));
    this.imageList_0.Images.SetKeyName(2, Module.a("\uDCB7승\uDABB\uE1BD\uF3BF\uECC1껃뛅꿇", 18));
    this.imageList_0.Images.SetKeyName(3, Module.a("\uDBB7\uDEB9캻\uE1BD\uF1BF\uECC1껃뛅꿇", 18));
    this.imageList_0.Images.SetKeyName(4, Module.a("\uDBB7\uDEB9캻\uE1BD\uF2BF\uECC1껃뛅꿇", 18));
    this.imageList_0.Images.SetKeyName(5, Module.a("\uDBB7\uDEB9캻\uE1BD\uF3BF\uECC1껃뛅꿇", 18));
    this.AccessibleDescription = (string) null;
    this.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this, Module.a("鲷캹풻ힽ뎿", 18));
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackgroundImage = (Image) null;
    this.ControlBox = false;
    this.Controls.Add((Control) this.button_0);
    this.Controls.Add((Control) this.textBox_0);
    this.Controls.Add((Control) this.groupBox_0);
    this.Controls.Add((Control) this.pictureBox_0);
    this.Font = (Font) null;
    this.Icon = (Icon) null;
    this.Name = Module.a("\uF1B7ힹ첻톽늿뛁鯃\uAAC5꧇돉ꏋ믍\uA4CF", 18);
    ((ISupportInitialize) this.pictureBox_0).EndInit();
    this.groupBox_0.ResumeLayout(false);
    this.groupBox_0.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
