// Decompiled with JetBrains decompiler
// Type: ah
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

public class ah : Form
{
  private string string_0;
  private ArrayList arrayList_0;
  private IContainer icontainer_0;
  private Label label_0;
  private TreeView treeView_0;
  private Button button_0;
  private Button button_1;
  private Label label_1;
  private ListBox listBox_0;
  private Button button_2;
  private Button button_3;
  private Label label_2;
  private Label label_3;
  private Label label_4;
  private Label label_5;

  public ah()
  {
    int int_0 = 18;
    // ISSUE: explicit constructor call
//    base.\u002Ector();
    this.method_1();
    this.arrayList_0 = new ArrayList();
    this.arrayList_0.Clear();
    string string1 = c.string_1;
    if (File.Exists(string1))
    {
      try
      {
        using (StreamReader streamReader = new StreamReader(string1, Encoding.Unicode))
        {
          int num = 0;
          try
          {
            num = Convert.ToInt32(streamReader.ReadLine());
          }
          catch
          {
          }
          if (num > 0)
          {
            Class1 class1 = new Class1();
            for (int index = 0; index < num; ++index)
            {
              string string_1 = streamReader.ReadLine();
              this.arrayList_0.Add((object) class1.method_1(string_1, Class1.string_0));
            }
            this.listBox_0.Items.Clear();
            for (int index = 0; index < this.arrayList_0.Count; ++index)
            {
              string[] strArray = ((string) this.arrayList_0[index]).Split(';');
              if (strArray.Length == 3)
                this.listBox_0.Items.Add((object) strArray[1]);
              else
                break;
            }
          }
        }
      }
      catch
      {
      }
    }
    this.string_0 = (string) null;
    if (!c.bool_35)
      return;
    TreeNode node1 = new TreeNode();
    node1.Text = "M-1000/M-8000";
    this.treeView_0.Nodes.Add(node1);
    for (int index = 0; index < c.string_14.Length; ++index)
    {
      string str = c.string_14[index];
      if (str != null && str.Substring(0, 2) == "M-")
        node1.Nodes.Add(new TreeNode(c.string_14[index]));
    }
    TreeNode node2 = new TreeNode();
        node2.Text = "T-1000A"; // Module.a("\uECB7鞹趻躽\uF0BF\uF2C1藃", int_0);
    this.treeView_0.Nodes.Add(node2);
    for (int index = 0; index < c.string_14.Length; ++index)
    {
      string str = c.string_14[index];
      if (str != null && str.Substring(0, 8) == "T-1000A-" /*Module.a("\uECB7鞹趻躽\uF0BF\uF2C1藃\uEBC5", int_0)*/)
        node2.Nodes.Add(new TreeNode(c.string_14[index]));
    }
    TreeNode node3 = new TreeNode();
        node3.Text = "T-1000B"; // Module.a("\uECB7鞹趻躽\uF0BF\uF2C1蛃", int_0);
    this.treeView_0.Nodes.Add(node3);
    for (int index = 0; index < c.string_14.Length; ++index)
    {
      string str = c.string_14[index];
      if (str != null && str.Substring(0, 8) == "T-1000B-" /*Module.a("\uECB7鞹趻躽\uF0BF\uF2C1蛃\uEBC5", int_0)*/)
        node3.Nodes.Add(new TreeNode(c.string_14[index]));
    }
    TreeNode node4 = new TreeNode();
    node4.Text = !c.useEnglishLanguage ? Module.a("\uECB7鞹趻躽\uF0BF\uF2C1韃\uEEC5鳇\uE7C9\uFDCBﻍ\uE0CF\uE2D1펻ႄ\uF4D7軙\uF1DB\uEFDD탟틡퓣䊫ꦊ웩\uDE7Dٻ\uD9EF", int_0) : Module.a("\uECB7鞹趻躽\uF0BF\uF2C1韃", int_0);
    this.treeView_0.Nodes.Add(node4);
    for (int index = 0; index < c.string_14.Length; ++index)
    {
      string str = c.string_14[index];
      if (str != null && str.Substring(0, 8) == "T-1000S-" /*Module.a("\uECB7鞹趻躽\uF0BF\uF2C1韃\uEBC5", int_0)*/)
        node4.Nodes.Add(new TreeNode(c.string_14[index]));
    }
    TreeNode node5 = new TreeNode();
        node5.Text = "T-2000"; // Module.a("\uECB7鞹躻躽\uF0BF\uF2C1", int_0);
    this.treeView_0.Nodes.Add(node5);
    for (int index = 0; index < c.string_14.Length; ++index)
    {
      string str = c.string_14[index];
      if (str != null && str.Substring(0, 7) == "T-2000-" /*Module.a("\uECB7鞹躻躽\uF0BF\uF2C1\uE9C3", int_0)*/)
        node5.Nodes.Add(new TreeNode(c.string_14[index]));
    }
    TreeNode node6 = new TreeNode();
        node6.Text = "T-4000"; //Module.a("\uECB7鞹袻躽\uF0BF\uF2C1", int_0);
    this.treeView_0.Nodes.Add(node6);
    for (int index = 0; index < c.string_14.Length; ++index)
    {
      string str = c.string_14[index];
      if (str != null && str.Substring(0, 7) == "T-4000-" /*Module.a("\uECB7鞹袻躽\uF0BF\uF2C1\uE9C3", int_0)*/)
        node6.Nodes.Add(new TreeNode(c.string_14[index]));
    }
    TreeNode node7 = new TreeNode();
        node7.Text = "T-8000"; // Module.a("\uECB7鞹蒻躽\uF0BF\uF2C1", int_0);
    this.treeView_0.Nodes.Add(node7);
    for (int index = 0; index < c.string_14.Length; ++index)
    {
      string str = c.string_14[index];
      if (str != null && str.Substring(0, 7) == "T-8000-" /*Module.a("\uECB7鞹蒻躽\uF0BF\uF2C1\uE9C3", int_0)*/)
        node7.Nodes.Add(new TreeNode(c.string_14[index]));
    }
    TreeNode node8 = new TreeNode();
        node8.Text = "T-100K-B"; // Module.a("\uECB7鞹趻躽\uF0BF见\uE9C3蓅", int_0);
    this.treeView_0.Nodes.Add(node8);
    for (int index = 0; index < c.string_14.Length; ++index)
    {
      string str = c.string_14[index];
      if (str != null && str.Substring(0, 9) == "T-100K-B-" /*Module.a("\uECB7鞹趻躽\uF0BF见\uE9C3蓅\uE5C7", int_0)*/)
        node8.Nodes.Add(new TreeNode(c.string_14[index]));
    }
    TreeNode node9 = new TreeNode();
        node9.Text = "T-200K-B"; // Module.a("\uECB7鞹躻躽\uF0BF见\uE9C3蓅", int_0);
    this.treeView_0.Nodes.Add(node9);
    for (int index = 0; index < c.string_14.Length; ++index)
    {
      string str = c.string_14[index];
      if (str != null && str.Substring(0, 9) == "T-200K-B-" /*Module.a("\uECB7鞹躻躽\uF0BF见\uE9C3蓅\uE5C7", int_0)*/)
        node9.Nodes.Add(new TreeNode(c.string_14[index]));
    }
    TreeNode node10 = new TreeNode();
        node10.Text = "T-300K"; // Module.a("\uECB7鞹辻躽\uF0BF见", int_0);
    this.treeView_0.Nodes.Add(node10);
    for (int index = 0; index < c.string_14.Length; ++index)
    {
      string str = c.string_14[index];
      if (str != null && str.Substring(0, 7) == "T-300K-"/*Module.a("\uECB7鞹辻躽\uF0BF见\uE9C3", int_0)*/)
        node10.Nodes.Add(new TreeNode(c.string_14[index]));
    }
    this.treeView_0.Nodes.Add(new TreeNode()
    {
      Text = "T-400K " //Module.a("\uECB7鞹袻躽\uF0BF见\uE4C3\uE6C5\uE8C7", int_0)
    });
    for (int index1 = 0; index1 < this.treeView_0.Nodes.Count; ++index1)
    {
      if (this.treeView_0.Nodes[index1].Nodes.Count != 0)
      {
        for (int index2 = 0; index2 < this.treeView_0.Nodes[index1].Nodes.Count; ++index2)
        {
          if (this.treeView_0.Nodes[index1].Nodes[index2].Text == "T-1000S-UCS1903,1903B,1909,1912") // Module.a("\uECB7鞹趻躽\uF0BF\uF2C1韃\uEBC5鷇觉鿋ￍ\uE9CF\uE2D1\uE7D3𥉉\uE9D7\uE3D9\uECDB\uEDDDꋟ컡헣\uDFE5\uD8E7폩샫\uDFED짯쏱웳", int_0))
          {
            this.treeView_0.SelectedNode = this.treeView_0.Nodes[0].Nodes[1];
            this.treeView_0.Focus();
            return;
          }
        }
      }
    }
  }

  private void button_3_Click(object sender, EventArgs e) => this.Close();

  private void button_2_Click(object sender, EventArgs e)
  {
    int int_0 = 8;
    if (this.arrayList_0.Count == 0)
    {
      if (c.useEnglishLanguage)
        this.method_0(Module.a("節\uD8AFힱ钳햵춷좹캻\uDBBD꺿뛁\uE4C3ꋅꇇ껉\uECCBꃍ뿏ꛑ\uF4D3럕볗뻙ﳛ뿝軟鯡쓣藥蟧蓩飫鳭\u9FEF黱飳鏵諷훹賻鋽旿持眃挅⠇欉栋樍』昑簓猕㠗礙猛瀝吟倡䬣䨥䐧伩師\u0F2D", int_0));
      else
        this.method_0(Module.a("ﷲ﷽Ꮭ뷔䷘ᣥ䇷\uE9F4᧞\uF6EDꪗ侔㆖\uE4C7㵂㞦溟瞬\uE483벅嶂⾄ﯙ", int_0));
    }
    else
    {
      string string1 = c.string_1;
      if (File.Exists(string1))
        File.Delete(string1);
      Class1 class1 = new Class1();
      using (StreamWriter streamWriter = new StreamWriter(string1, false, Encoding.Unicode))
      {
        streamWriter.WriteLine(this.arrayList_0.Count.ToString());
        for (int index = 0; index < this.arrayList_0.Count; ++index)
        {
          string str = class1.method_0((string) this.arrayList_0[index], Class1.string_0);
          streamWriter.WriteLine(str);
        }
      }
      this.DialogResult = DialogResult.OK;
    }
  }

  private void treeView_0_AfterSelect(object sender, TreeViewEventArgs e)
  {
    int int_0 = 11;
    this.string_0 = (string) null;
    if (this.treeView_0.SelectedNode == null)
      return;
    if (this.treeView_0.SelectedNode.Parent == null)
    {
      if (this.treeView_0.SelectedNode.Text == Module.a("\uE5B0麲膴螶覸\uF0BA鶼龾\uE1C0", int_0))
      {
        if (c.useEnglishLanguage)
          this.method_0(Module.a("\uE1B0\uDFB2킴횶쪸\uDEBA鶼쪾닀ꛂ\uE5C4돆ꇈ껊\uEDCC鯎ﳐ\uE7D2\uE5D4\uE7D6鋘ﯚ껜꿞蓠胢賤蛦藨쯪黬胮韰蟲苴零诸黺\uDCFC\uDFFE唀⸂\u3104㜆㤈䀊ⴌ洎砐琒爔爖樘漚㴜氞吠匢唤䠦嬨弪ബᴮἰԲᔴ娶倸场儼嘾⹀ⵂ敄㝆⁈㍊⡌⍎≐獒❔≖㕘㹚\u2E5C罞ൠ\u0A62ɤསᵨɪͬ\u086E兰rᙴնᱸṺ\u137C幾", int_0));
        else
          this.method_0(Module.a("䘻쳽鷁\uE3B6钸辺趼达諀킌\uEDB1ꡉ㾆\uEACA\uEDCC鯎ﳐ\uE7D2\uE5D4\uE7D6鋘\uDBBD徭ろ캅\uE281ퟤ퇦\uD9E8\uECA4⊼쾓䢀瞄ㅽ\uEEA4隈譣늠\uDEFE", int_0));
      }
      this.treeView_0.SelectedNode = (TreeNode) null;
    }
    else
    {
      string text = this.treeView_0.SelectedNode.Text;
      int index1 = 3000;
      for (int index2 = 0; index2 < c.string_14.Length; ++index2)
      {
        if (c.string_14[index2] == text)
        {
          index1 = index2;
          break;
        }
      }
      if (index1 < c.string_14.Length)
      {
        this.string_0 = c.string_13[index1] + (object) ';' + c.string_14[index1] + (object) ';' + c.string_15[index1];
        this.label_5.Text = c.string_14[index1];
        this.label_4.Text = c.string_15[index1];
      }
      else if (c.useEnglishLanguage)
        this.method_0(Module.a("\uE2B0\uDCB2펴쎶캸\uDABA쾼\uDABE\uE1C0뇂냄꧆\uA7C8ꋊꏌ꣎\uF1D0뛒\uA7D4ꗖ뛘\uA9DAﳜ", int_0));
      else
        this.method_0(Module.a("\uDE3F䗼攻מּ䏩ꈯ鲼", int_0));
    }
  }

  private void method_0(string string_1)
  {
    MessageDialog aa = new MessageDialog();
    aa.label_0.Text = string_1;
    int num = (int) aa.ShowDialog();
  }

  private void button_0_Click(object sender, EventArgs e)
  {
    int int_0 = 8;
    if (this.string_0 == null)
      return;
    for (int index = 0; index < this.arrayList_0.Count; ++index)
    {
      if (this.string_0 == (string) this.arrayList_0[index])
      {
        if (c.useEnglishLanguage)
        {
          this.method_0(Module.a("\uE6AD톯솱钳풵\uDDB7\uDFB9튻麽ꆿꛁꃃꏅ곇\uEBC9", int_0));
          return;
        }
        this.method_0(Module.a("峰翑䧜ᓡ鞵", int_0));
        return;
      }
    }
    if (this.string_0 != null)
      this.arrayList_0.Add((object) this.string_0);
    this.listBox_0.Items.Clear();
    for (int index = 0; index < this.arrayList_0.Count; ++index)
    {
      string[] strArray = ((string) this.arrayList_0[index]).Split(';');
      if (strArray.Length == 3)
        this.listBox_0.Items.Add((object) strArray[1]);
      else
        break;
    }
    this.string_0 = (string) null;
    this.treeView_0.SelectedNode = (TreeNode) null;
  }

  private void button_1_Click(object sender, EventArgs e)
  {
    if (this.listBox_0.SelectedIndex < 0 || this.listBox_0.SelectedIndex >= this.arrayList_0.Count)
      return;
    this.arrayList_0.RemoveAt(this.listBox_0.SelectedIndex);
    this.listBox_0.Items.Clear();
    for (int index = 0; index < this.arrayList_0.Count; ++index)
    {
      string[] strArray = ((string) this.arrayList_0[index]).Split(';');
      if (strArray.Length != 3)
        break;
      this.listBox_0.Items.Add((object) strArray[1]);
    }
  }

  private void listBox_0_SelectedIndexChanged(object sender, EventArgs e)
  {
    if (this.listBox_0.SelectedIndex < 0 || this.listBox_0.SelectedIndex >= this.arrayList_0.Count)
      return;
    string[] strArray = ((string) this.arrayList_0[this.listBox_0.SelectedIndex]).Split(';');
    if (strArray.Length != 3)
      return;
    this.label_5.Text = strArray[1];
    this.label_4.Text = strArray[2];
  }

  private void treeView_0_MouseDown(object sender, MouseEventArgs e) => this.treeView_0_AfterSelect((object) null, (TreeViewEventArgs) null);

    protected override void Dispose(bool disposing)
    {
        if (disposing && this.icontainer_0 != null)
            this.icontainer_0.Dispose();

        base.Dispose(disposing);
    }

    private void method_1()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ah));
    this.label_0 = new Label();
    this.treeView_0 = new TreeView();
    this.button_0 = new Button();
    this.button_1 = new Button();
    this.label_1 = new Label();
    this.listBox_0 = new ListBox();
    this.button_2 = new Button();
    this.button_3 = new Button();
    this.label_2 = new Label();
    this.label_3 = new Label();
    this.label_4 = new Label();
    this.label_5 = new Label();
    this.SuspendLayout();
    this.label_0.AccessibleDescription = (string) null;
    this.label_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_0, Module.a("\uDFB2풴햶\uDCB8ힺ誼", 13));
    this.label_0.Name = Module.a("\uDFB2풴햶\uDCB8ힺ誼", 13);
    this.treeView_0.AccessibleDescription = (string) null;
    this.treeView_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.treeView_0, Module.a("잲잴튶\uDCB8\uEDBA풼\uDABE뛀\uF2C2", 13));
    this.treeView_0.BackgroundImage = (Image) null;
    this.treeView_0.Font = (Font) null;
    this.treeView_0.Name = Module.a("잲잴튶\uDCB8\uEDBA풼\uDABE뛀\uF2C2", 13);
    this.treeView_0.AfterSelect += new TreeViewEventHandler(this.treeView_0_AfterSelect);
    this.treeView_0.MouseDown += new MouseEventHandler(this.treeView_0_MouseDown);
    this.button_0.AccessibleDescription = (string) null;
    this.button_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.button_0, Module.a("톲살쎶춸풺펼躾", 13));
    this.button_0.BackgroundImage = (Image) null;
    this.button_0.ForeColor = SystemColors.HotTrack;
    this.button_0.Name = Module.a("톲살쎶춸풺펼躾", 13);
    this.button_0.UseVisualStyleBackColor = true;
    this.button_0.Click += new EventHandler(this.button_0_Click);
    this.button_1.AccessibleDescription = (string) null;
    this.button_1.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.button_1, Module.a("톲살쎶춸풺펼趾", 13));
    this.button_1.BackgroundImage = (Image) null;
    this.button_1.ForeColor = SystemColors.HotTrack;
    this.button_1.Name = Module.a("톲살쎶춸풺펼趾", 13);
    this.button_1.UseVisualStyleBackColor = true;
    this.button_1.Click += new EventHandler(this.button_1_Click);
    this.label_1.AccessibleDescription = (string) null;
    this.label_1.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_1, Module.a("\uDFB2풴햶\uDCB8ힺ貼", 13));
    this.label_1.ForeColor = SystemColors.HotTrack;
    this.label_1.Name = Module.a("\uDFB2풴햶\uDCB8ힺ貼", 13);
    this.listBox_0.AccessibleDescription = (string) null;
    this.listBox_0.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.listBox_0, Module.a("\uDFB2\uDCB4쒶춸了튼잾\uF0C0", 13));
    this.listBox_0.BackgroundImage = (Image) null;
    this.listBox_0.Font = (Font) null;
    this.listBox_0.FormattingEnabled = true;
    this.listBox_0.Name = Module.a("\uDFB2\uDCB4쒶춸了튼잾\uF0C0", 13);
    this.listBox_0.SelectedIndexChanged += new EventHandler(this.listBox_0_SelectedIndexChanged);
    this.button_2.AccessibleDescription = (string) null;
    this.button_2.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.button_2, Module.a("톲살쎶춸풺펼貾", 13));
    this.button_2.BackgroundImage = (Image) null;
    this.button_2.ForeColor = SystemColors.HotTrack;
    this.button_2.Name = Module.a("톲살쎶춸풺펼貾", 13);
    this.button_2.UseVisualStyleBackColor = true;
    this.button_2.Click += new EventHandler(this.button_2_Click);
    this.button_3.AccessibleDescription = (string) null;
    this.button_3.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.button_3, Module.a("톲살쎶춸풺펼设", 13));
    this.button_3.BackgroundImage = (Image) null;
    this.button_3.ForeColor = SystemColors.HotTrack;
    this.button_3.Name = Module.a("톲살쎶춸풺펼设", 13);
    this.button_3.UseVisualStyleBackColor = true;
    this.button_3.Click += new EventHandler(this.button_3_Click);
    this.label_2.AccessibleDescription = (string) null;
    this.label_2.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_2, Module.a("\uDFB2풴햶\uDCB8ힺ込", 13));
    this.label_2.Font = (Font) null;
    this.label_2.Name = Module.a("\uDFB2풴햶\uDCB8ힺ込", 13);
    this.label_3.AccessibleDescription = (string) null;
    this.label_3.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_3, Module.a("\uDFB2풴햶\uDCB8ힺ躼", 13));
    this.label_3.Font = (Font) null;
    this.label_3.Name = Module.a("\uDFB2풴햶\uDCB8ힺ躼", 13);
    this.label_4.AccessibleDescription = (string) null;
    this.label_4.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_4, Module.a("\uDFB2풴햶\uDCB8ힺ覼", 13));
    this.label_4.ForeColor = SystemColors.HotTrack;
    this.label_4.Name = Module.a("\uDFB2풴햶\uDCB8ힺ覼", 13);
    this.label_5.AccessibleDescription = (string) null;
    this.label_5.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this.label_5, Module.a("\uDFB2풴햶\uDCB8ힺ袼", 13));
    this.label_5.ForeColor = SystemColors.HotTrack;
    this.label_5.Name = Module.a("\uDFB2풴햶\uDCB8ힺ袼", 13);
    this.AccessibleDescription = (string) null;
    this.AccessibleName = (string) null;
    componentResourceManager.ApplyResources((object) this, Module.a("鞲솴\uDFB6킸좺", 13));
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackgroundImage = (Image) null;
    this.ControlBox = false;
    this.Controls.Add((Control) this.label_4);
    this.Controls.Add((Control) this.label_5);
    this.Controls.Add((Control) this.label_3);
    this.Controls.Add((Control) this.label_2);
    this.Controls.Add((Control) this.button_3);
    this.Controls.Add((Control) this.button_2);
    this.Controls.Add((Control) this.listBox_0);
    this.Controls.Add((Control) this.label_1);
    this.Controls.Add((Control) this.button_1);
    this.Controls.Add((Control) this.button_0);
    this.Controls.Add((Control) this.label_0);
    this.Controls.Add((Control) this.treeView_0);
    this.Font = (Font) null;
    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    this.Icon = (Icon) null;
    this.Name = Module.a("\uF8B2\uEFB4\uE6B6\uE6B8\uEFBA쒼쾾꓀鳂蓄ꯆꗈ", 13);
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
