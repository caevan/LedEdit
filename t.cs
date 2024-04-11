// Decompiled with JetBrains decompiler
// Type: t
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

public class t : Form
{
  private const int int_0 = 15;
  private uint uint_0;
  private uint uint_1;
  private uint uint_2;
  private Class1 class1_0;
  private int int_1;
  private IContainer icontainer_0;
  private Label label_0;
  private TextBox textBox_0;
  private Label label_1;
  private TextBox textBox_1;
  private Button button_0;
  private Button button_1;
  private Label label_2;
  private Button button_2;
  private Label label_3;

  public t()
  {
    int int_0 = 7;
    this.uint_0 = 899613341U;
    this.uint_1 = 974236103U;
    this.int_1 = -1;
    // ISSUE: explicit constructor call
 //   base.\u002Ector();
    this.method_5();
    this.class1_0 = new Class1();
    if (!this.method_1())
    {
      this.uint_0 = (uint) new Random().Next();
      this.uint_1 = (uint) DateTime.Now.Ticks;
      this.method_3();
      this.method_2();
    }
    this.method_0();
    if (this.int_1 != -1)
    {
      int num = 15 - this.int_1;
      this.label_3.Text = Module.a("䠧쀡䟾㟄怿鿃郡쯟攳훬쪎蓼", int_0) + num.ToString() + Module.a("趬蛷끏", int_0);
      string str = this.class1_0.method_3();
      string string_3 = str + Module.a("鞬辮鯗寞㧥鿃軚鞺\uDED7韩뺏\uEBB7规ꋆ귈車꧌ꛎꗐ뱝⎚혩律", int_0) + this.label_3.Text;
      this.class1_0.method_2(Module.a("햬욮\uDFB0톲\uDAB4\uE8B6\uDDB8튺\uDCBC톾므ꫂ藄뛆룈\uE5CA껌ꃎ볐ￒ귔뻖럘맚닜믞裠苢诤鷦胨ꯪ诬胮觰黲铴黶闸헺黼郾氀⼂約渆月椊戌倎甐稒琔礖挘爚崜⸞ጠᔢତ䐦䘨䘪", int_0), Module.a("\uE1AC쪮햰\uF6B2톴\uDEB6춸鮺", int_0) + str + Module.a("趬辮搻鯇钴", int_0), string_3);
    }
    else
    {
      this.label_3.Text = Module.a("䠧쀡䟾䇯竊瀹ꛟ鞺䨷埒䶑벍\uEDB1옹", int_0);
      this.button_2.Enabled = false;
      string str = this.class1_0.method_3();
      string string_3 = str + Module.a("鞬辮鯗寞㧥鿃軚鞺\uDED7韩뺏\uEBB7规ꋆ귈車꧌ꛎꗐ뱝⎚혩律", int_0) + this.label_3.Text;
      this.class1_0.method_2(Module.a("햬욮\uDFB0톲\uDAB4\uE8B6\uDDB8튺\uDCBC톾므ꫂ藄뛆룈\uE5CA껌ꃎ볐ￒ귔뻖럘맚닜믞裠苢诤鷦胨ꯪ诬胮觰黲铴黶闸헺黼郾氀⼂約渆月椊戌倎甐稒琔礖挘爚崜⸞ጠᔢତ䐦䘨䘪", int_0), Module.a("\uE1AC쪮햰\uF6B2톴\uDEB6춸鮺", int_0) + str + Module.a("趬辮䏭琽\uAAD3隶", int_0), string_3);
    }
    this.method_2();
    this.uint_2 = this.uint_0 * this.uint_1;
    this.uint_2 *= 12576867U;
    this.uint_2 ^= 78654347U;
    this.uint_2 += 15890743U;
    string path = Directory.CreateDirectory(Environment.SystemDirectory).Parent.FullName + Module.a("\uF1AC슮슰쮲\uD8B4蚶趸隺\uD8BC\uDBBE\uF2C0\uF7C2\uF7C4\uF5C6雈뷊ﻌ\uE2CE듐뷒ꃔ淪闘铚髜", int_0);
    string str1;
    if (File.Exists(path))
    {
      using (StreamReader streamReader = new StreamReader(path, Encoding.Unicode))
        str1 = streamReader.ReadLine();
    }
    else
      str1 = Module.a("骬骮莰蚲肴莶许辺", int_0);
    uint num1;
    try
    {
      num1 = Convert.ToUInt32(str1, 16);
    }
    catch
    {
      num1 = 87655424U;
    }
    uint num2;
    try
    {
      num2 = Convert.ToUInt32(this.class1_0.method_5());
    }
    catch
    {
      num2 = 427865410U;
    }
    this.uint_2 ^= num1;
    this.uint_2 += num2;
    this.textBox_0.Text = this.uint_2.ToString();
  }

  private void method_0()
  {
    int int_0 = 6;
    string fullName = Directory.CreateDirectory(Environment.SystemDirectory).Parent.FullName;
    string systemDirectory = Environment.SystemDirectory;
    string path1 = fullName + Module.a("\uF0AB쎭쎯쪱\uD9B3螵買鞹\uE4BBﲽ樂\uF1C1\uF2C3\uF7C5\uF0C7\uFBC9\uE1CBꯍ뻏\uA7D1䀘髕韗鷙", 6);
    if (File.Exists(path1))
    {
      string string_1;
      using (StreamReader streamReader = new StreamReader(path1, Encoding.Unicode))
      {
        string_1 = streamReader.ReadLine();
        string_1 = streamReader.ReadLine();
      }
      string str1;
      try
      {
        str1 = this.class1_0.method_1(string_1, Class1.string_0);
      }
      catch
      {
        this.button_2.Enabled = false;
        this.int_1 = -1;
        return;
      }
      int int32_1;
      try
      {
        int32_1 = Convert.ToInt32(str1);
      }
      catch
      {
        this.button_2.Enabled = false;
        this.int_1 = -1;
        return;
      }
      string path2 = systemDirectory + Module.a("\uF0AB\uDBAD욯솱쒳\uDDB5覷횹銻ힽ꺿ꯁ", int_0);
      if (File.Exists(path2))
      {
        using (StreamReader streamReader = new StreamReader(path2, Encoding.Unicode))
          string_1 = streamReader.ReadLine();
        string str2;
        try
        {
          str2 = this.class1_0.method_1(string_1, Class1.string_0);
        }
        catch
        {
          this.button_2.Enabled = false;
          this.int_1 = -1;
          return;
        }
        int int32_2;
        try
        {
          int32_2 = Convert.ToInt32(str2);
        }
        catch
        {
          this.button_2.Enabled = false;
          this.int_1 = -1;
          return;
        }
        DateTime now = DateTime.Now;
        int num = now.Year * 365 + now.Month * 30 + 2008 + now.Day;
        if (num < int32_2)
        {
          this.button_2.Enabled = false;
          this.int_1 = -1;
        }
        else
        {
          this.int_1 = num - int32_1;
          if (this.int_1 < 15 && this.int_1 >= 0)
          {
            this.button_2.Enabled = true;
          }
          else
          {
            this.button_2.Enabled = false;
            this.int_1 = -1;
          }
        }
      }
      else
      {
        this.button_2.Enabled = false;
        this.int_1 = -1;
      }
    }
    else
    {
      this.button_2.Enabled = false;
      this.int_1 = -1;
    }
  }

  private bool method_1()
  {
    int int_0 = 2;
    bool flag = false;
    RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Module.a("ﮧ\uE5A9\uEAAB節\uE7AF\uF3B1\uE6B3\uF3B5", 2), true);
    string[] subKeyNames = registryKey.GetSubKeyNames();
    foreach (string str in subKeyNames)
    {
      if (str == Module.a("\uE5A7쎩쾫\uDCAD\uDFAF\uE3B1솳\uDFB5覷횹", int_0))
        flag = true;
    }
    if (flag)
    {
      string str = registryKey.OpenSubKey(Module.a("\uE5A7쎩쾫\uDCAD\uDFAF\uE3B1솳\uDFB5覷횹", int_0), true).GetValue(Module.a("\uE0A7\uE2A9", int_0)).ToString();
      try
      {
        this.uint_1 = Convert.ToUInt32(str);
      }
      catch
      {
        this.uint_1 = 92835214U;
      }
    }
    else
      this.uint_1 = 17234501U;
    string fullName = Directory.CreateDirectory(Environment.SystemDirectory).Parent.FullName;
    string systemDirectory = Environment.SystemDirectory;
    string path = fullName + Module.a("\uF4A7잩\uDFAB횭\uDDAF莱肳鮵\uE0B7\uF8B9薻趽\uF6BF\uF3C1ﳃ\uF7C5\uE5C7꿉ꋋ믍ﻏ黑鯓釕", int_0);
    if (File.Exists(path))
    {
      using (StreamReader streamReader = new StreamReader(path, Encoding.Unicode))
      {
        string str = streamReader.ReadLine();
        try
        {
          this.uint_0 = Convert.ToUInt32(str);
          return true;
        }
        catch
        {
          this.uint_0 = 80143285U;
        }
      }
    }
    else
      this.uint_0 = 25835285U;
    foreach (string str in subKeyNames)
    {
      if (str == Module.a("\uF8A7얩삫잭\uDDAF\uDDB1\uDFB3\uDFB5쮷\uDFB9", int_0))
        return true;
    }
    foreach (string str in subKeyNames)
    {
      if (str == Module.a("\uE1A7쒩\uDFAB\uDAAD톯\uDEB1\uD8B3펵쮷즹\uDDBBힽ", int_0))
        return true;
    }
    foreach (string str in subKeyNames)
    {
      if (str == Module.a("\uE9A7\uD9A9\uF8AB춭\uDFAF솱횳햵톷\uDBB9", int_0))
        return true;
    }
    foreach (string str in subKeyNames)
    {
      if (str == Module.a("\uEFA7잩쎫쮭\uDEAF슱\uDFB3억", int_0))
        return true;
    }
    foreach (string str in subKeyNames)
    {
      if (str == Module.a("\uE5A7얩\uD8AB솭펯욱\uDBB3억\uDAB7", int_0))
        return true;
    }
    return File.Exists(fullName + Module.a("\uF4A7\uDAA9잫\uDDAD풯龱ힳ습횷캹쾻邽ꦿ곁귃", int_0)) || File.Exists(fullName + Module.a("\uF4A7\uDCA9\uDFAB쪭풯욱욳螵풷钹\uD8BB튽겿", int_0)) || File.Exists(systemDirectory + Module.a("\uF4A7\uEEA9즫춭풯\uDCB1톳습\uE7B7\uE2B9ﺻ邽꒿껁ꣃ", int_0)) || File.Exists(systemDirectory + Module.a("\uF4A7\uDDA9잫쪭즯\uDFB1쒳억隷풹좻튽", int_0)) || File.Exists(systemDirectory + Module.a("\uF4A7\uDCA9鶫슭膯쒱펳ힵ隷좹펻펽", int_0));
  }

  private void method_2()
  {
    string systemDirectory = Environment.SystemDirectory;
    string str1 = systemDirectory + Module.a("\uE9B4슶쾸좺춼풾\uF0C0꿂\uEBC4껆\uA7C8ꋊ", 15);
    DateTime now = DateTime.Now;
    string str2 = this.class1_0.method_0((now.Year * 365 + now.Month * 30 + 2008 + now.Day).ToString(), Class1.string_0);
    string path = systemDirectory + Module.a("\uE9B4슶쾸좺춼풾\uF0C0꿂\uEBC4껆\uA7C8ꋊ", 15);
    if (File.Exists(path))
      File.Delete(path);
    using (StreamWriter streamWriter = new StreamWriter(path, false, Encoding.Unicode))
      streamWriter.WriteLine(str2);
  }

  private void method_3()
  {
    int int_0 = 14;
    Class1 class1 = new Class1();
    bool flag1 = false;
    RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Module.a("\uE7B3例ﺷ\uEEB9\uEBBBﾽ銿蟁", 14), true);
    string[] subKeyNames = registryKey.GetSubKeyNames();
    foreach (string str in subKeyNames)
    {
      if (str == Module.a("靈\uDFB5\uDBB7좹펻\uEFBD떿ꯁ\uF5C3\uAAC5", int_0))
        flag1 = true;
    }
    if (!flag1)
      registryKey.CreateSubKey(Module.a("靈\uDFB5\uDBB7좹펻\uEFBD떿ꯁ\uF5C3\uAAC5", int_0)).SetValue(Module.a("ﲳﺵ", int_0), (object) this.uint_1.ToString());
    else
      registryKey.OpenSubKey(Module.a("靈\uDFB5\uDBB7좹펻\uEFBD떿ꯁ\uF5C3\uAAC5", int_0), true).SetValue(Module.a("ﲳﺵ", int_0), (object) this.uint_1.ToString());
    bool flag2 = false;
    foreach (string str in subKeyNames)
    {
      if (str == Module.a("\uE4B3\uD9B5풷펹톻톽ꮿꯁ럃ꏅ", int_0))
        flag2 = true;
    }
    if (!flag2)
      registryKey.CreateSubKey(Module.a("\uE4B3\uD9B5풷펹톻톽ꮿꯁ럃ꏅ", int_0)).SetValue(Module.a("\uE3B3\uE6B5", int_0), (object) Module.a("\uF7B3\uF5B5颷誹讻麽\uF4BF\uF1C1\uE4C3ￅ軇\uEAC9\uF5CB賍", int_0));
    bool flag3 = false;
    foreach (string str in subKeyNames)
    {
      if (str == Module.a("ﶳ\uD8B5쮷캹\uDDBB튽겿\uA7C1럃뗅꧇ꏉ", int_0))
        flag3 = true;
    }
    if (!flag3)
      registryKey.CreateSubKey(Module.a("ﶳ\uD8B5쮷캹\uDDBB튽겿\uA7C1럃뗅꧇ꏉ", int_0)).SetValue(Module.a("\uF7B3\uF5B5", int_0), (object) Module.a("\uE3B3\uDFB5횷\uDEB9펻즽뎿", int_0));
    bool flag4 = false;
    foreach (string str in subKeyNames)
    {
      if (str == Module.a("\uF5B3억\uECB7\uD9B9펻춽ꊿꇁ귃\uA7C5", int_0))
        flag4 = true;
    }
    if (!flag4)
      registryKey.CreateSubKey(Module.a("\uF5B3억\uECB7\uD9B9펻춽ꊿꇁ귃\uA7C5", int_0)).SetValue(Module.a("\uF7B3쎵쪷좹\uD9BB킽뒿铁ꇃ듅믇ꏉꏋꃍ", int_0), (object) Module.a("莳骵覷隹趻誽\uECBF\uF2C1", int_0));
    bool flag5 = false;
    foreach (string str in subKeyNames)
    {
      if (str == Module.a("\uF3B3\uDBB5ힷ\uDFB9튻캽ꮿ뇁", int_0))
        flag5 = true;
    }
    if (!flag5)
      registryKey.CreateSubKey(Module.a("\uF3B3\uDBB5ힷ\uDFB9튻캽ꮿ뇁", int_0)).SetValue(Module.a("\uF1B3\uD8B5\uD9B7\uD8B9킻\uDBBD銿\uA7C1럃苅ꇇꯉꃋꇍ럏", int_0), (object) Module.a("薳", int_0));
    bool flag6 = false;
    foreach (string str in subKeyNames)
    {
      if (str == Module.a("靈\uD9B5첷햹\uDFBB쪽꾿뇁ꛃ", int_0))
        flag6 = true;
    }
    if (!flag6)
      registryKey.CreateSubKey(Module.a("靈\uD9B5첷햹\uDFBB쪽꾿뇁ꛃ", int_0)).SetValue(Module.a("\uE4B3쒵ힷ\uDEB9즻\uDDBD뒿见ꇃ뿅", int_0), (object) Module.a("貳膵誷躹辻", int_0));
    string fullName = Directory.CreateDirectory(Environment.SystemDirectory).Parent.FullName;
    string systemDirectory = Environment.SystemDirectory;
    string path1 = fullName + Module.a("\uE8B3욵펷즹\uD8BB鎽ꎿ뛁\uAAC3닅믇\uE4C9ꗋꃍ맏", int_0);
    if (!File.Exists(path1))
    {
      using (StreamWriter streamWriter = new StreamWriter(path1, false, Encoding.Unicode))
      {
        streamWriter.WriteLine(Module.a("貳辵膷芹躻誽\uF2BF\uF7C1", int_0));
        streamWriter.WriteLine(Module.a("蒳", int_0));
      }
    }
    string path2 = fullName + Module.a("\uE8B3삵쮷\uDEB9\uD8BB쪽늿\uF3C1ꣃ\uE8C5곇ꛉꃋ", int_0);
    if (!File.Exists(path2))
    {
      using (StreamWriter streamWriter = new StreamWriter(path2, false, Encoding.Unicode))
      {
        streamWriter.WriteLine(Module.a("\uF6B3\uF0B5閷惡\uF8BB鎽樂\uF5C1\uE9C3\uF7C5難", int_0));
        streamWriter.WriteLine(Module.a("삳쒵춷\uDFB9", int_0));
      }
    }
    string path3 = systemDirectory + Module.a("\uE8B3\uF2B5\uDDB7\uD9B9\uD8BB킽ꖿ뛁鯃黅談\uE4C9\uA8CBꋍ볏", int_0);
    if (!File.Exists(path3))
    {
      using (StreamWriter streamWriter = new StreamWriter(path3, false, Encoding.Unicode))
      {
        streamWriter.WriteLine(Module.a("\uF7B3\uF5B5ﲷﺹ躻趽芿臁臃菅", int_0));
        streamWriter.WriteLine(Module.a("薳", int_0));
      }
    }
    string path4 = systemDirectory + Module.a("\uE8B3솵펷\uDEB9얻펽낿뇁\uEAC3\uA8C5볇ꛉ", int_0);
    if (!File.Exists(path4))
    {
      using (StreamWriter streamWriter = new StreamWriter(path4, false, Encoding.Unicode))
      {
        streamWriter.WriteLine(Module.a("쎳\uDFB5횷\uDEB9펻즽뎿뫁듃", int_0));
        streamWriter.WriteLine(Module.a("ﲳﺵ", int_0));
      }
    }
    string path5 = systemDirectory + Module.a("\uE8B3삵覷횹趻좽\uA7BFꏁ\uEAC3듅\uA7C7\uA7C9", int_0);
    if (!File.Exists(path5))
    {
      using (StreamWriter streamWriter = new StreamWriter(path5, false, Encoding.Unicode))
      {
        streamWriter.WriteLine(Module.a("蚳蚵袷貹醻覽\uEDBF\uF0C1", int_0));
        streamWriter.WriteLine(Module.a("춳펵쮷", int_0));
      }
    }
    string str1 = this.class1_0.method_4();
    string path6 = fullName + Module.a("\uE8B3\uDBB5쮷승톻辽\uF4BF\uEFC1ꇃꋅ\uFBC7ﻉﻋﳍ迏ꓑ\uE7D3ﯕ뷗듙\uA9DB\uF0DD곟귡ꏣ", int_0);
    if (File.Exists(path6))
      File.Delete(path6);
    using (StreamWriter streamWriter = new StreamWriter(path6, false, Encoding.Unicode))
    {
      streamWriter.WriteLine(str1);
      streamWriter.WriteLine(str1);
    }
    DateTime now = DateTime.Now;
    int num = now.Year * 365 + now.Month * 30 + 2008 + now.Day;
    string str2 = class1.method_0(num.ToString(), Class1.string_0);
    string path7 = fullName + Module.a("\uE8B3\uDBB5쮷승톻辽\uF4BF\uEFC1鳃蓅\uF1C7柳頋ￍ\uE8CF\uE3D1陸돕뛗꿙\uF2DB鋝꿟ꗡ", int_0);
    if (File.Exists(path7))
      File.Delete(path7);
    using (StreamWriter streamWriter = new StreamWriter(path7, false, Encoding.Unicode))
    {
      streamWriter.WriteLine(this.uint_0.ToString());
      streamWriter.WriteLine(str2);
      streamWriter.WriteLine(this.uint_1.ToString());
      streamWriter.Write(Module.a("観讵薷骹\uEABB\uDBBD늿ꃁꯃ뗅귇\uEAC9ꃋꇍ럏뗑뷓룕뿗龎꿛ꫝ臟郡郣菥賧탩쳫\uDCED샯싱쳳\uDBF5췷ퟹ쓻\uDEFD\u20FF㨁㸃㔅〇〉㰋㠍』㈑嘓挕焗瘙砛㸝吟嬡吣䌥ሧ\u0A29缫昭礯戱ᐳ挵瘷猹缻焽п݁摃畅晇穉絋恍摏扑摓晕癗桙桛浝啟䉡䑣╥१٩kݭṯᕱ味ٵ\u0A77ᕹύ\u1B7D\uF37F\uF181뺃ꚅ쮇낉킋\uD98D\uD98F\uDC91킓\uD995쾗즙삛\uED9D\uD99F톡킣쎥얧馩麫\uF2AD\uDDAF솱\uDDB3펵삷\uDFB9\uDFBB邽ꖿ뫁ꇃ\uE6C5\uF5C7\uF7C9\uF1CB쏍\uDACF鿑蟓鿕\uF8D7\uF2D9뿛\uF7DD샟쫡틣\uDEE5틧틩\uDCEB쟭탯꧱쓳컵싷짹쓻쓽ヿ㐁㸃㸅㴇㌉儋㐍』䀑焓攕紗渙栛眝丟䔡У䔥䤧䤩䐫䬭启ሱ䐳夵吷匹弻䜽怿㑁╃⩅㵇⽉㽋䍍婏ὑݓὕ硗牙㽛睝䁟䩡剣幥剧剩屫䝭偯⥱䑳乵䉷䥹䑻䑽끿뒁뺃뺅붇뎉톋뒍낏\uDF91\uF593\uF595\uF097\uF399\uF29Bﮝ肟튡쮣쪥솧즩햫躭욯펱\uD8B3쎵\uDDB7骹鮻諾ꖿꃁ뇃ꇅ\uEFC7\uEAC9ꗋ뷍\uF0CF\uE2D1\uD9D3\uDCD5闗觙闛ﻝ죟臡췣웥샧\uDCE9퓫퓭죯싱\uDDF3훵ꏷ쫹쓻쓽㏿㨁㸃㘅㸇〉㐋㬍⤏休⸓㘕㈗〙㘛㐝ਟࠡรإ稧弩䈫欭帯唱崳堵崷9ㄻ㐽怿扁摃晅桇橉汋湍灏牑瑓籕牗灙癛瑝䩟䡡䑣㙥ᩧթ\u086B᭭\u136Fٱ乳噵ᵷ䁹⁻ώ\uE57F\uE081\uE083\uE385뢇뎉\uE88B뾍\uF68Fꮑ꒓\uF395ﲗ꺙ꦛﶝ솟隡鲣鎥鮧즩좫춭톯톱薳킵讷\uE6B9톻춽뢿꿁ꣃ\uE8C5ꗇ막ꗋ쏍\uDACF\uF2D1\uF4D3\uF6D5\uF8D7龎ﳛﻝ샟싡쓣웥싧샩웫쓭\uDAEF\uD8F1\uDEF3훵맷駹裻韽濿氁㸃★ԇ\tⰋ⸍』㈑㐓㘕㠗㨙㰛㸝\u001Fࠡรథȧ)ثЭု焱嬳嬵唷嬹刻娽ి⭁⩃⍅片橉晋摍穏硑繓籕牗灙癛瑝浟桡⥣㕥Ⅷ䩩䑫൭奯剱屳䁵䁷䁹䑻乽\uA97Fꊁ\uDF83뚅낇낉뾋뚍ꪏꊑꊓ겕ꂗ꾙ꖛ쎝骟芡\uE7A3쪥솧쾩슫\uDAAD鶯솱\uDDB3튵\uDDB7骹\uDDBB킽꒿\uE2C1釃迅\uE8C7ꏉ뿋\uEECD뻏뷑뫓돕\uF8D7뗙껛ﻝ苟菡韣迥诧탩쳫볭藯鳱髳\u9FF5雷鷹\uDCFB鯽滿瘁洃琅洇⨉攋怍挏昑甓稕琗㨙猛瀝\u001F嘡䰣䌥ࠧ天䤫尭䘯圱䘳ᠵ㔷〹焻洽ि扁汃╅慇橉摋硍桏桑汓晕煗穙ݛ湝塟塡坣幥剧婩婫呭䡯䝱䵳\u2B75䉷婹㭻\u0C7D\uE17F\uE081\uE683\uE385\uEC87ꪉ\uE98B\uF68D\uF58F\uF191\uE193\uE295\uF197\uF599\uF29B뺝춟힡킣쎥킧蒩ꆫ꒭ﶯ\uE1B1ﶳ隵邷\uD9B9閻麽\uE8BF\uF4C1ﳃﳅ\uF0C7韛\uE5CB\uEECD诏\uE2D1\uECD3\uECD5\uEBD7\uE2D9\uE6DB\uEEDDퟟ\uD8E1퓣\uDFE5\uDBE7럩훫컭돯黱鯳韵鏷鏹鋻駽\u20FF朁樃朅樇昉椋樍㸏ἑḓ嬕䬗匙㰛㘝䌟ଡУลḧሩᘫᘭ/ᬱᐳ洵࠷ȹػഽ砿硁瑃煅片穉畋絍\u0D4F桑瑓\u1755ⱗ\u2E59㥛㍝ၟᙡൣ\u0865ཧ䩩ᡫŭ偯\u1771ᩳ\u1775᩷ᙹ\u197B幽\uE17F\uEE81\uE883ꚅ\uEC87\uE389ﾋ\uEF8D\uF28Fﺑ\uF193\uF295뢗\uEA99\uEE9B\uF79D횟잡좣쎥쾧쾩\uDFAB躭튯ힱ튳\uD9B5쪷\uDFB9鲻\uDDBDꆿ껁ꣃ꿅ꛇ귉\uECCB蟍뻏ꇑꃓ럕듗뛙ﳛ뇝軟싡럣菥髧鳩觫鳭\uFDEF\uF8F1맳ꗵ뇷\uDAF9퓻鷽⧿∁Ⰳ々〇〉㐋㸍㤏㈑伓☕‗’⼛☝᨟ሡጣᰥᤧᨩᔫ猭ਯሱ紳堵嬷䠹夻匽┿ⱁぃ⽅♇ⵉ汋ⵍ㽏❑㩓≕㵗⡙籛⩝ཟ䉡cཥ᭧୩\u0E6Bɭᕯ剱ݳṵ\u0D77\u0E79\u187Bᅽ\uF77F\uEC81ꪃꚅ쮇\uE589曆\uE08D\uE48F\uF791\uE693뚕聯ﲙ\uE89Bﮝ튟芡춣좥쮧\uD8A9즫쎭햯\uDCB1삳貵颷誹놻뒽趿釁跃\uE6C5\uE0C7막\uE5CB\uEECD\uF8CF\uEAD1\uECD3\uECD5黗\uEAD9\uF5DBﻝ믟틡\uDCE3\uDCE5\uDBE7틩훫\uDEED쟯죱엳쏵컷ꟹ웻\uDEFD䟿瀁攃搅樇漉栋⸍甏樑焓甕洗渙甛焝丟ȡ䤣匥尧伩含-㴯㠱礳攵焷ᨹᐻ䴽椿扁汃繅灇灉瑋積祏牑ན晕恗恙潛晝婟剡卣履奧剩孫㍭䩯剱♳\u1375\u0B77ό\u087B\u0A7D\uE97F\uEC81\uE383ꚅ\uEB87\uEB89\uEF8B\uE68D\uF58F\uF691뒓\uE695\uF797\uF699\uF59Bﶝ\uD99F芡튣장쒧\uDFA9즫\uDDAD붯뢱靈\uE5B5\uF1B7骹钻춽\uE9BF\uE2C1\uECC3ﻅ\uF0C7\uF0C9\uF4CB鬒紐\uF2D1迓\uE6D5\uE0D7\uE0D9\uEFDB\uE6DD\uDADF틡폣\uDCE5\uD9E7틩\uDBEB돭쫯틱맳韵鯷鋹闻都旿∁球椅搇按漋眍』搑甓稕洗缙㰛㤝搟䜡䘣匥伧ഩఫ䜭䌯ሱг㬵㈷眹漻眽怿橁㝃潅桇扉瑋癍橏橑恓罕硗ř汛晝婟兡屣履塧嵩噫彭䡯䕱⥳䱵塷偹噻命ꩿꢁ꺃겅ꢇ\uD889曆\uE08D햏ﲑ\uF393ﾕ\uF697ﾙꚛ", int_0));
    }
  }

  private void method_4(string string_0)
  {
    MessageDialog aa = new MessageDialog();
    aa.label_0.Text = string_0;
    int num = (int) aa.ShowDialog();
  }

  private void button_0_Click(object sender, EventArgs e)
  {
    int int_0 = 18;
    string text = this.textBox_1.Text;
    if (text.Length == 0)
    {
      if (c.useEnglishLanguage)
        this.method_4(Module.a("\uECB7특\uD9BB麽銿\uA7C1ꏃ꿅믇뻉뻋꿍\uA4CF믑믓룕\uF8D7铙\uA9DB돝苟蟡難웥鯧苩菫鯭鳯雱髳\uEFD5賷\uDAF9黻鯽\u20FF瀁愃欅椇按戋⸍甏缑搓戕愗㬙", int_0));
      else
        this.method_4(Module.a("僛㛨뷃돳㴿\uF88F뺹윺", int_0));
    }
    else
    {
      uint num1 = (uint) (((int) (this.uint_2 % 10U) * 92357405 + 257883457 + (int) (uint) ((ulong) (this.uint_2 / 10U % 10U * 4043249743U) + 9052345973UL) + (int) (uint) ((long) (this.uint_2 / 100U % 10U) * 4869354254L + 4932543588L) + (int) (uint) ((long) (this.uint_2 / 1000U % 10U) * 7438543243L + 4324570932L) + (int) (uint) ((long) (this.uint_2 / 10000U % 10U) * 7988983535L + 9084345347L) + (int) (uint) ((long) (this.uint_2 / 100000U % 10U) * 9325345345L + 5438854354L)) * 438 + ((int) (uint) ((ulong) (this.uint_2 / 1000000U % 10U) * 6755665656UL + 2342412432UL) + (int) (uint) ((long) (this.uint_2 / 10000000U % 10U) * 5425445345L + 8876677777L) + (int) (uint) ((long) (this.uint_2 / 100000000U % 10U) * 5545435454L + 9878769800L) + (int) (uint) ((long) (this.uint_2 / 1000000000U % 10U) * 6553665464L + 4525434524L) + (int) (uint) ((long) this.uint_2 / 10000000000L % 10L * 6576576577L + 5433453225L) + (int) (uint) ((ulong) ((long) this.uint_2 / 100000000000L % 10L * 9965773645L) + 3455667067UL)) * 647346) + (uint) ((long) this.uint_2 / 10000000000000L % 10L * 7657567454L + 5465000775L) % 9465U;
      uint num2 = this.uint_2 % 10U ^ 350240862U;
      uint num3 = (uint) ((ulong) (this.uint_2 / 10U % 10U) ^ 7384317106UL);
      uint num4 = (uint) ((ulong) (this.uint_2 / 100U % 10U) ^ 8454171590UL);
      uint num5 = (uint) ((ulong) (this.uint_2 / 1000U % 10U) ^ 8945570440UL);
      uint num6 = this.uint_2 / 10000U % 10U ^ 736437890U;
      uint num7 = this.uint_2 / 100000U % 10U ^ 2434999005U;
      uint num8 = (uint) ((ulong) (this.uint_2 / 1000000U % 10U) ^ 8742153001UL);
      uint num9 = (uint) ((ulong) (this.uint_2 / 10000000U % 10U) ^ 8767448760UL);
      uint num10 = (uint) ((ulong) (this.uint_2 / 100000000U % 10U) ^ 49960111216UL);
      uint num11 = this.uint_2 / 1000000000U % 10U ^ 1052981339U;
      uint num12 = (uint) ((long) this.uint_2 / 10000000000L % 10L ^ 10408030699L);
      uint num13 = (uint) ((ulong) ((long) this.uint_2 / 100000000000L % 10L) ^ 721457533UL);
      uint num14 = (uint) ((ulong) ((long) this.uint_2 / 10000000000000L % 10L) ^ 34750776UL);
      uint num15 = (uint) (((int) num6 + (int) num3) * 12 + ((int) num4 ^ (int) num5) + ((int) num2 + (int) num7) ^ 438 + ((int) num8 * (int) num9 + (int) num10 ^ (int) num11 + (int) (num12 / num13)) * 646 + (int) num14 * 332354);
      uint num16 = this.uint_2 % 10U ^ 350240862U;
      uint num17 = this.uint_2 * 10U % 10U ^ 2353387817U;
      uint num18 = (uint) ((ulong) (this.uint_2 * 100U % 10U) ^ 7649434232UL);
      uint num19 = (uint) ((int) (this.uint_2 * 1000U % 10U) * 21421244 - 65454);
      uint num20 = this.uint_2 * 10000U % 10U ^ 99813199U;
      uint num21 = (uint) ((ulong) (this.uint_2 * 100000U % 10U) ^ 18446744073709499418UL);
      uint num22 = this.uint_2 * 1000000U % 10U ^ 87764131U;
      uint num23 = (uint) ((ulong) (this.uint_2 * 10000000U % 10U) ^ 8766779581UL);
      uint num24 = this.uint_2 * 100000000U % 10U ^ 3747888U;
      uint num25 = this.uint_2 * 1000000000U % 10U ^ 1061869340U;
      uint num26 = (uint) ((long) this.uint_2 * 10000000000L % 10L ^ 10408030699L);
      uint num27 = (uint) ((ulong) ((long) this.uint_2 * 100000000000L % 10L) ^ 835012224UL);
      uint num28 = (uint) ((ulong) ((long) this.uint_2 * 10000000000000L % 10L * 6575532L) - 756776UL);
      uint num29 = (uint) (((int) num19 ^ (int) num17) * 12 + (int) num18 * (int) num16 + ((int) num20 + (int) num27) ^ 438 + ((int) num22 * (int) num23 + (int) num24 ^ (int) num25 + (int) (num26 / num21)) * 646 + (int) num28 * 332354);
      string strA = this.class1_0.method_0((num1 + num15 + num29).ToString(), Class1.string_0);
      string fullName = Directory.CreateDirectory(Environment.SystemDirectory).Parent.FullName;
      if (string.Compare(strA, text) == 0)
      {
        this.button_0.Enabled = false;
        this.label_2.Text = Module.a("髜琶\uDCF4쇲\uE8CA\uEEA6ꭌる\uE4C7⊥䂚\uDEAF依팮\uF65F\uF459\uD928", int_0);
        string path = fullName + Module.a("\uE4B7\uD8B9킻\uDFBD뎿뛁\uA7C3\uF7C5\uA4C7ꏉꋋ\uE0CD볏뷑돓", int_0);
        if (File.Exists(path))
          File.Delete(path);
        using (StreamWriter streamWriter = new StreamWriter(path, false, Encoding.Unicode))
          streamWriter.WriteLine(text.ToString());
        this.method_3();
        c.smethod_3(true);
        this.Close();
      }
      else
      {
        this.textBox_1.Text = "";
        this.label_2.Text = Module.a("僛㛨뷃Ꜩ⼴\uEEC1㍈啊궖ꦢꊳ⚡岞펩픬\uF459者\uDB26", int_0);
        this.label_2.ForeColor = System.Drawing.Color.Red;
      }
    }
  }

  private void button_1_Click(object sender, EventArgs e) => this.Close();

  private void button_2_Click(object sender, EventArgs e)
  {
    c.smethod_3(true);
    this.Close();
  }

    protected override void Dispose(bool disposing)
    {
        if (disposing && this.icontainer_0 != null)
            this.icontainer_0.Dispose();

        base.Dispose(disposing);
    }

    private void method_5()
  {
    this.label_0 = new Label();
    this.textBox_0 = new TextBox();
    this.label_1 = new Label();
    this.textBox_1 = new TextBox();
    this.button_0 = new Button();
    this.button_1 = new Button();
    this.label_2 = new Label();
    this.button_2 = new Button();
    this.label_3 = new Label();
    this.SuspendLayout();
    this.label_0.AutoSize = true;
    this.label_0.Location = new Point(32, 54);
    this.label_0.Name = Module.a("\uD8B3ힵ\uDAB7\uDFB9킻貽", 14);
    this.label_0.Size = new Size(59, 12);
    this.label_0.TabIndex = 1;
    this.label_0.Text = Module.a("飔賒\uF1B7ﺹ䯨蒽", 14);
    this.textBox_0.BackColor = SystemColors.Control;
    this.textBox_0.Location = new Point(92, 51);
    this.textBox_0.Name = Module.a("삳펵삷캹ﺻ톽뢿\uF3C1", 14);
    this.textBox_0.ReadOnly = true;
    this.textBox_0.Size = new Size(206, 21);
    this.textBox_0.TabIndex = 2;
    this.label_1.AutoSize = true;
    this.label_1.Location = new Point(32, 125);
    this.label_1.Name = Module.a("\uD8B3ힵ\uDAB7\uDFB9킻趽", 14);
    this.label_1.Size = new Size(47, 12);
    this.label_1.TabIndex = 3;
    this.label_1.Text = Module.a("峟㫤맏肹", 14);
    this.textBox_1.Location = new Point(92, 99);
    this.textBox_1.Multiline = true;
    this.textBox_1.Name = Module.a("삳펵삷캹ﺻ톽뢿\uF0C1", 14);
    this.textBox_1.Size = new Size(206, 66);
    this.textBox_1.TabIndex = 4;
    this.button_0.Location = new Point(152, 213);
    this.button_0.Name = Module.a("횳쎵첷캹펻킽\uF1BF", 14);
    this.button_0.Size = new Size(73, 24);
    this.button_0.TabIndex = 5;
    this.button_0.Text = Module.a("峟㫤", 14);
    this.button_0.UseVisualStyleBackColor = true;
    this.button_0.Click += new EventHandler(this.button_0_Click);
    this.button_1.Location = new Point(263, 212);
    this.button_1.Name = Module.a("횳쎵첷캹펻킽\uF2BF", 14);
    this.button_1.Size = new Size(73, 24);
    this.button_1.TabIndex = 6;
    this.button_1.Text = Module.a("됣䳤", 14);
    this.button_1.UseVisualStyleBackColor = true;
    this.button_1.Click += new EventHandler(this.button_1_Click);
    this.label_2.AutoSize = true;
    this.label_2.Location = new Point(42, 183);
    this.label_2.Name = Module.a("\uD8B3ힵ\uDAB7\uDFB9킻誽", 14);
    this.label_2.Size = new Size(0, 12);
    this.label_2.TabIndex = 7;
    this.button_2.Enabled = false;
    this.button_2.Location = new Point(36, 213);
    this.button_2.Name = Module.a("횳쎵첷캹펻킽\uF3BF", 14);
    this.button_2.Size = new Size(75, 23);
    this.button_2.TabIndex = 9;
    this.button_2.Text = Module.a("愸黀", 14);
    this.button_2.UseVisualStyleBackColor = true;
    this.button_2.Click += new EventHandler(this.button_2_Click);
    this.label_3.AutoSize = true;
    this.label_3.Location = new Point(32, 18);
    this.label_3.Name = Module.a("\uD8B3ힵ\uDAB7\uDFB9킻袽", 14);
    this.label_3.Size = new Size(143, 12);
    this.label_3.TabIndex = 10;
    this.label_3.Text = Module.a("儸\uD93A仹㻏椰雈\uE9E6늤\u1C4C꾗쎉\uF0C9", 14);
    this.AutoScaleDimensions = new SizeF(6f, 12f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(367, 271);
    this.ControlBox = false;
    this.Controls.Add((Control) this.label_3);
    this.Controls.Add((Control) this.button_2);
    this.Controls.Add((Control) this.label_2);
    this.Controls.Add((Control) this.button_1);
    this.Controls.Add((Control) this.button_0);
    this.Controls.Add((Control) this.textBox_1);
    this.Controls.Add((Control) this.label_1);
    this.Controls.Add((Control) this.textBox_0);
    this.Controls.Add((Control) this.label_0);
    this.MaximumSize = new Size(543, 422);
    this.MinimumSize = new Size(375, 305);
    this.Name = Module.a("靈\uDFB5햷\uDBB9", 14);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = Module.a("峟㫤", 14);
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
