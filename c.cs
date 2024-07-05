// Decompiled with JetBrains decompiler
// Type: c
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using AFSApp.Helpers;
using AviFile;
using AxShockwaveFlashObjects;
using Microsoft.DirectX.DirectDraw;
using SwfDotNet.IO;
using SwfDotNet.IO.Tags;
using SwfDotNet.IO.Tags.Types;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

public class c : Form
{
    private const int int_0 = 161;
    private const int int_1 = 2;
    public static string string_0;
    public static string string_1;
    public static string string_2;
    public static bool useEnglishLanguage;
    public static int int_2;
    public static bool bool_1;
    public static Rectangle rectangle_0;
    public static bool bool_2;
    public static bool bool_3;
    public static int int_3;
    public static int int_4;
    public static int int_5;
    public static int int_6;
    public static int int_7;
    public static byte byte_0;
    public static int int_8;
    public static int int_9;
    public static int int_10;
    public static byte byte_1;
    public static byte byte_2;
    public static byte byte_3;
    public static byte byte_4;
    public static byte byte_5;
    public static byte byte_6;
    public static byte byte_7;
    public static byte byte_8;
    private bool bool_4;
    private bool bool_5;
    private Color[] color_0;
    private Color color_1;
    private ad[] ad_0;
    private AxShockwaveFlash[] axShockwaveFlash_0;
    private Class0[] class0_0;
    private Class4[] class4_0;
    private GClass4[,] gclass4_0;
    private GClass0[] gclass0_0;
    public static bool bool_6;
    private bool bool_7;
    private bool bool_8;
    private IntPtr intptr_0;
    public static bool bool_9;
    public static byte byte_9;
    public static byte byte_10;
    public static string string_3;
    private bool bool_10;
    private double double_0;
    private double double_1;
    private byte[] byte_11;
    private bool bool_11;
    private byte[] byte_12;
    public static byte byte_13;
    public static byte byte_14;
    public static byte byte_15;
    private bool bool_12;
    private string string_4;
    private Swf swf_0;
    private string string_5;
    private Image image_0;
    private int int_11;
    private int int_12;
    private int int_13;
    private string string_6;
    private FileStream fileStream_0;
    private BufferedStream bufferedStream_0;
    protected GClass0 gclass0_1;
    private bool bool_13;
    private int int_14;
    private byte[] byte_16;
    private int int_15;
    private byte[] byte_17;
    private byte[] byte_18;
    public static double double_2;
    public static byte byte_19;
    public static byte byte_20;
    public static bool bool_14;
    private int int_16;
    private bool bool_15;
    private int int_17;
    private bool bool_16;
    public static bool bool_17;
    public static bool bool_18;
    private Image image_1;
    private int int_18;
    private bool bool_19;
    private bool bool_20;
    private bool bool_21;
    private bool bool_22;
    private bool bool_23;
    private DateTime dateTime_0;
    private bool bool_24;
    private int int_19;
    private int int_20;
    private AviManager aviManager_0;
    private VideoStream videoStream_0;
    private int int_21;
    public static string string_7;
    private bool bool_25;
    private bool bool_26;
    private int int_22;
    private string string_8;
    private GEnum1 genum1_0;
    public static byte[] byte_21;
    public static byte[] byte_22;
    public static byte[] byte_23;
    private bool bool_27;
    private int int_23;
    private int int_24;
    private int int_25;
    private int int_26;
    private byte byte_24;
    private byte byte_25;
    private int int_27;
    private int int_28;
    private byte byte_26;
    private byte byte_27;
    private byte byte_28;
    private byte byte_29;
    private bool bool_28;
    private int int_29;
    private bool bool_29;
    private Class2 class2_0;
    private byte[] byte_30;
    private byte[] byte_31;
    private byte[] byte_32;
    private string[] string_9;
    private string string_10;
    private Class2 class2_1;
    private UdpClient udpClient_0;
    private int[] int_30;
    private int int_31;
    private k k_0;
    private int int_32;
    private int int_33;
    private bool bool_30;
    private bool bool_31;
    public static bool bool_32;
    private byte[] byte_33;
    private byte[] byte_34;
    private byte[] byte_35;
    private byte[] byte_36;
    private int int_34;
    private int int_35;
    private int int_36;
    private bool bool_33;
    private bool bool_34;
    private int int_37;
    private OpenFileDialog openFileDialog_0;
    private MainMenu mainMenu_0;
    private MenuItem menuItem_0;
    private SaveFileDialog saveFileDialog_0;
    private IContainer icontainer_0;
    private ArrayList arrayList_0;
    private ArrayList arrayList_1;
    private ArrayList arrayList_2;
    private ArrayList arrayList_3;
    public static ArrayList arrayList_4;
    public static int int_38;
    private int int_39;
    private int int_40;
    private string[] string_11;
    public static bool bool_35;
    public static string[] string_12;
    public static string[] string_13;
    public static string[] string_14;
    public static string[] string_15;
    private string string_16;
    public static string string_17;
    private double double_3;
    private int int_41;
    private int int_42;
    private bool bool_36;
    private bool bool_37;
    private bool bool_38;
    private bool bool_39;
    private bool bool_40;
    private byte[] byte_37;
    private byte[] byte_38;
    private byte[] byte_39;
    private byte[] byte_40;
    private int[] int_43;
    private int[] int_44;
    private int[] int_45;
    private int[] int_46;
    private int[] int_47;
    private int[] int_48;
    private bool bool_41;
    private bool bool_42;
    private bool bool_43;
    private bool bool_44;
    private bool bool_45;
    private bool bool_46;
    private int[] int_49;
    private bool bool_47;
    private bool bool_48;
    private int int_50;
    private int[] int_51;
    private bool bool_49;
    private int int_52;
    private int int_53;
    private int int_54;
    private FileStream fileStream_1;
    private BufferedStream bufferedStream_1;
    private FileStream fileStream_2;
    private BufferedStream bufferedStream_2;
    private int int_55;
    private bool bool_50;
    public static GClass1 gclass1_0;
    protected GClass0 gclass0_2;
    protected GClass0 gclass0_3;
    public static GClass0 gclass0_4;
    protected GClass0 gclass0_5;
    protected GClass0 gclass0_6;
    private GClass0 gclass0_7;
    public static GClass0 gclass0_8;
    private a a_0;
    public static bool bool_51;
    private int int_56;
    public static Size size_0;
    private string string_18;
    public static bool bool_52;
    public static bool bool_53;
    public static bool bool_54;
    public static int int_57;
    public static int int_58;
    public static int int_59;
    public static string string_19;
    public static Color color_2;
    public static Color color_3;
    public static Font font_0;
    public static int int_60;
    public static int int_61;
    public static bool bool_55;
    public static bool bool_56;
    protected GClass0 gclass0_9;
    private d d_0;
    public static i i_0;
    private r r_0;
    private int int_62;
    private int int_63;
    private int int_64;
    public static int int_65;
    public static int int_66;
    private int int_67;
    private int int_68;
    private double double_4;
    private double double_5;
    private double double_6;
    private double double_7;
    private bool bool_57;
    private string string_20;
    public static string string_21;
    private string string_22;
    public static string string_23;
    private GEnum1 genum1_1;
    private Panel panel_0;
    private double double_8;
    private MenuItem menuItem_1;
    private MenuItem menuItem_2;
    private MenuItem menuItem_3;
    private MenuItem menuItem_4;
    private MenuItem menuItem_5;
    private MenuItem menuItem_6;
    private MenuItem menuItem_7;
    private bool bool_58;
    private int int_69;
    private int int_70;
    public static int int_71;
    public static int int_72;
    private static int int_73;
    public static int int_74;
    public static int int_75;
    public static int int_76;
    public static int int_77;
    public static int int_78;
    private byte byte_41;
    private byte byte_42;
    private byte byte_43;
    private byte byte_44;
    private byte byte_45;
    private int int_79;
    private int int_80;
    public static int int_81;
    private int int_82;
    private static bool bool_59;
    private IntPtr intptr_1;
    private int int_83;
    private int int_84;
    private int int_85;
    private int int_86;
    private int int_87;
    private int int_88;
    private int int_89;
    private int int_90;
    private int int_91;
    private int int_92;
    private MenuItem menuItem_8;
    private MenuItem menuItem_9;
    private MenuItem menuItem_10;
    private MenuItem menuItem_11;
    private MenuItem menuItem_12;
    private MenuItem menuItem_13;
    private MenuItem menuItem_14;
    private Panel panel_1;
    private MenuItem menuItem_15;
    private ProgressBar progressBar_0;
    private ToolStrip toolStrip_0;
    private ToolStripButton toolStripButton_0;
    private ToolStripButton toolStripButton_1;
    private ToolStripButton toolStripButton_2;
    private ToolStripButton toolStripButton_3;
    private ToolStripButton toolStripButton_4;
    private ToolStripSeparator toolStripSeparator_0;
    private ToolStripButton toolStripButton_5;
    private ToolStripSeparator toolStripSeparator_1;
    private ToolStripSeparator toolStripSeparator_2;
    private MenuItem menuItem_16;
    private MenuItem menuItem_17;
    private MenuItem menuItem_18;
    private ToolStripSeparator toolStripSeparator_3;
    private ToolStripButton toolStripButton_6;
    private ToolStripButton toolStripButton_7;
    private MenuItem menuItem_19;
    private MenuItem menuItem_20;
    private MenuItem menuItem_21;
    private MenuItem menuItem_22;
    private MenuItem menuItem_23;
    private MenuItem menuItem_24;
    private TrackBar trackBar_0;
    private ToolStrip toolStrip_1;
    private ToolStripTextBox toolStripTextBox_0;
    private ToolStripButton toolStripButton_8;
    private ToolStripSeparator toolStripSeparator_4;
    private ToolStripButton toolStripButton_9;
    private ToolStripButton toolStripButton_10;
    private ToolStripButton toolStripButton_11;
    private ToolStripSeparator toolStripSeparator_5;
    private ToolStripLabel toolStripLabel_0;
    private ToolStripSeparator toolStripSeparator_6;
    private ToolStripButton toolStripButton_12;
    private ToolStripButton toolStripButton_13;
    private ToolStripSeparator toolStripSeparator_7;
    private ToolStripButton toolStripButton_14;
    private ToolStripSeparator toolStripSeparator_8;
    private ToolStripLabel toolStripLabel_1;
    private ToolStripTextBox toolStripTextBox_1;
    private ToolStripLabel toolStripLabel_2;
    private ToolStripSeparator toolStripSeparator_9;
    private MenuItem menuItem_25;
    private MenuItem menuItem_26;
    private MenuItem menuItem_27;
    private ToolStripButton toolStripButton_15;
    private ToolStripButton toolStripButton_16;
    private ToolStripButton toolStripButton_17;
    private ToolStripLabel toolStripLabel_3;
    private ToolStripTextBox toolStripTextBox_2;
    private ToolStripButton toolStripButton_18;
    private MenuItem menuItem_28;
    private MenuItem menuItem_29;
    private MenuItem menuItem_30;
    private TextBox textBox_0;
    private ContextMenuStrip contextMenuStrip_0;
    private ToolStripMenuItem toolStripMenuItem_0;
    private ToolStripMenuItem toolStripMenuItem_1;
    private ToolStripMenuItem toolStripMenuItem_2;
    private ToolStripMenuItem toolStripMenuItem_3;
    private MenuItem menuItem_31;
    private ToolStripMenuItem toolStripMenuItem_4;
    private MenuItem menuItem_32;
    private ToolStripTextBox toolStripTextBox_3;
    private MenuItem menuItem_33;
    private MenuItem menuItem_34;
    private MenuItem menuItem_35;
    private MenuItem menuItem_36;
    private MenuItem menuItem_37;
    private MenuItem menuItem_38;
    private MenuItem menuItem_39;
    private MenuItem menuItem_40;
    private System.Windows.Forms.Timer timer_0;
    private MenuItem menuItem_41;
    private Panel panel_2;
    private Label label_0;
    private Label label_1;
    private GroupBox groupBox_0;
    private Label label_2;
    private Label label_3;
    private Label label_4;
    private GroupBox groupBox_1;
    private TextBox textBox_1;
    private Label label_5;
    private TextBox textBox_2;
    private Label label_6;
    private Label label_7;
    private Label label_8;
    private TextBox textBox_3;
    private Label label_9;
    private Label label_10;
    private Button button_0;
    private MenuItem menuItem_42;
    private MenuItem menuItem_43;
    private MenuItem menuItem_44;
    private MenuItem menuItem_45;
    private MenuItem menuItem_46;
    private MenuItem menuItem_47;
    private MenuItem menuItem_48;
    private MenuItem menuItem_49;
    private MenuItem menuItem_50;
    private MenuItem menuItem_51;
    private MenuItem menuItem_52;
    private MenuItem menuItem_53;
    private MenuItem menuItem_54;
    private MenuItem menuItem_55;
    private MenuItem menuItem_56;
    private MenuItem menuItem_57;
    private MenuItem menuItem_58;
    private ToolStripButton toolStripButton_19;
    private ToolStripSeparator toolStripSeparator_10;
    private MenuItem menuItem_59;
    private ToolStripButton toolStripButton_20;
    private MenuItem menuItem_60;
    private Panel panel_3;
    private Label label_11;
    private MenuItem menuItem_61;
    private MenuItem menuItem_62;
    private ToolStripSeparator toolStripSeparator_11;
    private ToolStripButton toolStripButton_21;
    private ToolStripButton toolStripButton_22;
    private ToolStripButton toolStripButton_23;
    private MenuItem menuItem_63;
    private System.Windows.Forms.Timer timer_1;
    private System.Windows.Forms.Timer timer_2;
    private HScrollBar hscrollBar_0;
    private VScrollBar vscrollBar_0;
    private MenuItem menuItem_64;
    private MenuItem menuItem_65;
    private MenuItem menuItem_66;
    private MenuItem menuItem_67;
    private MenuItem menuItem_68;
    private MenuItem menuItem_69;
    private MenuItem menuItem_70;
    private MenuItem menuItem_71;
    private MenuItem menuItem_72;
    private MenuItem menuItem_73;
    private ToolStripButton toolStripButton_24;
    private MenuItem menuItem_74;
    private ToolStripButton toolStripButton_25;
    private MenuItem menuItem_75;
    private System.Windows.Forms.Timer timer_3;
    private MenuItem menuItem_76;
    private MenuItem menuItem_77;
    private MenuItem menuItem_78;
    private MenuItem menuItem_79;
    private MenuItem menuItem_80;
    private ToolStripButton toolStripButton_26;
    private MenuItem menuItem_81;
    private MenuItem menuItem_82;
    private MenuItem menuItem_83;
    private MenuItem menuItem_84;
    private MenuItem menuItem_85;
    private MenuItem menuItem_86;
    private MenuItem menuItem_87;
    private MenuItem menuItem_88;
    private MenuItem menuItem_89;
    private MenuItem menuItem_90;
    private MenuItem menuItem_91;
    private MenuItem menuItem_92;
    private MenuItem menuItem_93;
    private ContextMenuStrip contextMenuStrip_1;
    private ToolStripMenuItem toolStripMenuItem_5;
    private ToolStripMenuItem toolStripMenuItem_6;
    private ToolStripMenuItem toolStripMenuItem_7;
    private ToolStripMenuItem toolStripMenuItem_8;
    private ToolStripMenuItem toolStripMenuItem_9;
    private ToolStripMenuItem toolStripMenuItem_10;
    private ToolStripMenuItem toolStripMenuItem_11;
    private ToolStripMenuItem toolStripMenuItem_12;
    private ToolStripMenuItem toolStripMenuItem_13;
    private MenuItem menuItem_94;
    private Label label_12;
    private MenuItem menuItem_95;
    private MenuItem menuItem_96;
    private MenuItem menuItem_97;
    private MenuItem menuItem_98;
    private MenuItem menuItem_99;
    private MenuItem menuItem_100;
    private MenuItem menuItem_101;
    private MenuItem menuItem_102;
    private Label label_13;
    private MenuItem menuItem_103;
    private TabControl tabControl_0;
    private TabPage tabPage_0;
    private TabPage tabPage_1;
    private ListBox listBox_0;
    private Button button_1;
    private Button button_2;
    private Button button_3;
    private Button button_4;
    private Label label_14;
    private TextBox textBox_4;
    private TreeView treeView_0;
    private Label label_15;
    private Button button_5;
    private TextBox textBox_5;
    private Label label_16;
    private Button button_6;
    private Button button_7;
    private Button button_8;
    private Button button_9;
    private Button button_10;
    private ListBox listBox_1;
    private MenuItem menuItem_104;
    private MenuItem menuItem_105;
    private MenuItem menuItem_106;
    private MenuItem menuItem_107;
    private MenuItem menuItem_108;
    private MenuItem menuItem_109;
    private MenuItem menuItem_110;
    private MenuItem menuItem_111;
    private MenuItem menuItem_112;
    private MenuItem menuItem_113;

    static c() => c.old_acctor_mc();

    [SpecialName]
    public static int smethod_0() => c.int_73;

    [SpecialName]
    public static void smethod_1(int int_93) => c.int_73 = int_93;

    [SpecialName]
    public static bool smethod_2() => c.bool_59;

    [SpecialName]
    public static void smethod_3(bool bool_60) => c.bool_59 = bool_60;

    private bool method_0()
    {
        int int_0 = 1;
        uint num1 = 0;
        uint num2 = 0;
        string fullName = Directory.CreateDirectory(Environment.SystemDirectory).Parent.FullName;
        string path1 = fullName + "\\msxm14 - XB936181 - enu.LOG";// Module.a("ﮦ쒨\uD8AA햬슮肰螲颴\uEFB6﮸芺躼覾\uF0C0\uFBC2\uF4C4\uEAC6곈ꗊ료\uE1CE鷐鳒鋔", 1);
        if (!System.IO.File.Exists(path1))
            return false;
        using (StreamReader streamReader = new StreamReader(path1, Encoding.Unicode))
        {
            string str1 = streamReader.ReadLine();
            try
            {
                num2 = Convert.ToUInt32(str1);
            }
            catch
            {
                return false;
            }
            streamReader.ReadLine();
            string str2 = streamReader.ReadLine();
            try
            {
                num1 = Convert.ToUInt32(str2);
            }
            catch
            {
                return false;
            }
        }
        string path2 = fullName + "\\blastc1lin.log";//Module.a("ﮦ쮨잪첬\uDCAE얰킲蒴\uDBB6킸햺鎼펾껀꓂", int_0);
        if (!System.IO.File.Exists(path2))
            return false;
        string strB;
        using (StreamReader streamReader = new StreamReader(path2, Encoding.Unicode))
            strB = streamReader.ReadLine();
        uint num3 = (num1 * num2 * 12576867U ^ 78654347U) + 15890743U;
        Class1 class1 = new Class1();
        string path3 = fullName + "\\msxm14-ed3422_v3-enu.LOG"; //Module.a("ﮦ쒨\uD8AA햬슮肰螲颴튶\uDDB8袺覼趾\uF3C0鳂도\uF4C6\uE4C8껊ꏌ뫎\uFFD0鿒體郖", int_0);
        if (!System.IO.File.Exists(path3))
            return false;
        string str3;
        using (StreamReader streamReader = new StreamReader(path3, Encoding.Unicode))
            str3 = streamReader.ReadLine();
        uint num4;
        try
        {
            num4 = Convert.ToUInt32(str3, 16);
        }
        catch
        {
            num4 = 87655424U;
        }
        uint num5;
        try
        {
            num5 = Convert.ToUInt32(class1.method_5());
        }
        catch
        {
            num5 = 427865410U;
        }
        uint num6 = (num3 ^ num4) + num5;
        string str4 = num6.ToString();
        uint num7 = (uint)(((int)(num6 % 10U) * 92357405 + 257883457 + (int)(uint)((ulong)(num6 / 10U % 10U * 4043249743U) + 9052345973UL) + (int)(uint)((long)(num6 / 100U % 10U) * 4869354254L + 4932543588L) + (int)(uint)((long)(num6 / 1000U % 10U) * 7438543243L + 4324570932L) + (int)(uint)((long)(num6 / 10000U % 10U) * 7988983535L + 9084345347L) + (int)(uint)((long)(num6 / 100000U % 10U) * 9325345345L + 5438854354L)) * 438 + ((int)(uint)((ulong)(num6 / 1000000U % 10U) * 6755665656UL + 2342412432UL) + (int)(uint)((long)(num6 / 10000000U % 10U) * 5425445345L + 8876677777L) + (int)(uint)((long)(num6 / 100000000U % 10U) * 5545435454L + 9878769800L) + (int)(uint)((long)(num6 / 1000000000U % 10U) * 6553665464L + 4525434524L) + (int)(uint)((long)num6 / 10000000000L % 10L * 6576576577L + 5433453225L) + (int)(uint)((ulong)((long)num6 / 100000000000L % 10L * 9965773645L) + 3455667067UL)) * 647346) + (uint)((long)num6 / 10000000000000L % 10L * 7657567454L + 5465000775L) % 9465U;
        uint num8 = num6 % 10U ^ 350240862U;
        uint num9 = (uint)((ulong)(num6 / 10U % 10U) ^ 7384317106UL);
        uint num10 = (uint)((ulong)(num6 / 100U % 10U) ^ 8454171590UL);
        uint num11 = (uint)((ulong)(num6 / 1000U % 10U) ^ 8945570440UL);
        uint num12 = num6 / 10000U % 10U ^ 736437890U;
        uint num13 = num6 / 100000U % 10U ^ 2434999005U;
        uint num14 = (uint)((ulong)(num6 / 1000000U % 10U) ^ 8742153001UL);
        uint num15 = (uint)((ulong)(num6 / 10000000U % 10U) ^ 8767448760UL);
        uint num16 = (uint)((ulong)(num6 / 100000000U % 10U) ^ 49960111216UL);
        uint num17 = num6 / 1000000000U % 10U ^ 1052981339U;
        uint num18 = (uint)((long)num6 / 10000000000L % 10L ^ 10408030699L);
        uint num19 = (uint)((ulong)((long)num6 / 100000000000L % 10L) ^ 721457533UL);
        uint num20 = (uint)((ulong)((long)num6 / 10000000000000L % 10L) ^ 34750776UL);
        uint num21 = (uint)(((int)num12 + (int)num9) * 12 + ((int)num10 ^ (int)num11) + ((int)num8 + (int)num13) ^ 438 + ((int)num14 * (int)num15 + (int)num16 ^ (int)num17 + (int)(num18 / num19)) * 646 + (int)num20 * 332354);
        uint num22 = num6 % 10U ^ 350240862U;
        uint num23 = num6 * 10U % 10U ^ 2353387817U;
        uint num24 = (uint)((ulong)(num6 * 100U % 10U) ^ 7649434232UL);
        uint num25 = (uint)((int)(num6 * 1000U % 10U) * 21421244 - 65454);
        uint num26 = num6 * 10000U % 10U ^ 99813199U;
        uint num27 = (uint)((ulong)(num6 * 100000U % 10U) ^ 18446744073709499418UL);
        uint num28 = num6 * 1000000U % 10U ^ 87764131U;
        uint num29 = (uint)((ulong)(num6 * 10000000U % 10U) ^ 8766779581UL);
        uint num30 = num6 * 100000000U % 10U ^ 3747888U;
        uint num31 = num6 * 1000000000U % 10U ^ 1061869340U;
        uint num32 = (uint)((long)num6 * 10000000000L % 10L ^ 10408030699L);
        uint num33 = (uint)((ulong)((long)num6 * 100000000000L % 10L) ^ 835012224UL);
        uint num34 = (uint)((ulong)((long)num6 * 10000000000000L % 10L * 6575532L) - 756776UL);
        uint num35 = (uint)(((int)num25 ^ (int)num23) * 12 + (int)num24 * (int)num22 + ((int)num26 + (int)num33) ^ 438 + ((int)num28 * (int)num29 + (int)num30 ^ (int)num31 + (int)(num32 / num27)) * 646 + (int)num34 * 332354);
        uint num36 = num7 + num21 + num35;
        if (string.Compare(class1.method_0(num36.ToString(), Class1.string_0), strB) != 0)
            return false;
        string str5 = class1.method_3() + ": Registered user! Computer ID number:\r\n\r\n" + str4 + "Using software!";
//        string str5 = class1.method_3() + Module.a("鶦覨姷䗀\u23FF駅蓐둋苃꠹\uF2BA寮䣭﯀", int_0) + str4 + Module.a("螦覨讪컇蟹컿鯇\uDA3B䇸롇", int_0);
        return true;
    }

    private unsafe void method_1()
    {
        int int_0 = 15;
        c.bool_32 = true;
        this.arrayList_0 = new ArrayList();
        this.arrayList_1 = new ArrayList();
        this.arrayList_2 = new ArrayList();
        this.arrayList_3 = new ArrayList();
        this.d_0 = new d();
        this.d_0.Location = new Point(100, 80);
        this.r_0 = new r();
        this.r_0.Hide();
        this.class2_0 = new Class2();
        this.toolStripTextBox_3.Text = "";
        this.Text = this.string_8 + "@" + c.string_0;
//        this.Text = this.string_8 + Module.a("閴", 15) + c.string_0;
        this.int_62 = c.int_4 * 16 / 1024;
        this.int_63 = c.int_4 * 16;
        c.gclass1_0 = new GClass1((Control)this.panel_0);
        this.gclass0_0 = new GClass0[4];
        Rectangle rectangle = new Rectangle(0, 0, 100, 100);
        for (int index = 0; index < 4; ++index)
        {
            this.gclass0_0[index] = new GClass0(c.gclass1_0.method_1(), rectangle, rectangle);
            this.gclass0_0[index].method_12().ColorFill(Color.FromArgb(0, 0, 0));
        }
        Rectangle rectangle_2 = new Rectangle(0, 0, 50, 50);
        Rectangle rectangle_3 = new Rectangle(0, 0, 50, 50);
        c.gclass0_4 = new GClass0(c.gclass1_0.method_1(), rectangle_2, rectangle_3);
        c.i_0.Location = new Point(100, 80);
        rectangle_2 = new Rectangle(0, 0, this.panel_0.Width, this.panel_0.Height);
        rectangle_3 = new Rectangle(0, 0, this.panel_0.Width, this.panel_0.Height);
        this.gclass0_2 = new GClass0(c.gclass1_0.method_1(), rectangle_2, rectangle_3);
        this.intptr_1 = c.CreateDC("DISPLAY", (string)null, (string)null, (IntPtr)null);
//        this.intptr_1 = c.CreateDC(Module.a("\uF1B4ﺶ\uEAB8\uEBBA\uF1BCﺾ飀", int_0), (string)null, (string)null, (IntPtr)null);
        this.Location = new Point(0, 0);
        this.k_0 = new k();
        this.k_0.Hide();
        try
        {
            c.font_0 = new Font("宋体", 12f);
//            c.font_0 = new Font(Module.a("㻯\uE4F9", int_0), 12f);
        }
        catch
        {
            c.font_0 = (Font)null;
            c.font_0 = new Font("Arial", 12f);
//            c.font_0 = new Font(Module.a("\uF4B4얶킸\uDABA톼", int_0), 12f);
        }
        c.color_2 = Color.FromArgb(0, 0, 1);
        c.color_3 = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue);
        this.byte_34 = new byte[5];
        this.byte_36 = new byte[3];
        this.class2_1 = new Class2();
        this.byte_30 = new byte[1040];
        for (int index = 0; index < 1040; ++index)
            this.byte_30[index] = 0;
        this.bool_30 = false;
    }

    private void method_2()
    {
        this.toolStrip_1.Location = new Point(0, 25);
        this.textBox_0.Location = new Point(155, 50);
        this.textBox_0.Visible = true;
        this.textBox_0.Enabled = false;
        this.panel_1.Location = new Point(155, 72);
    }

    //  Consrtuctor
    public c()
    {
        int int_0 = 17;
        this.byte_11 = new byte[10]
        {
            76, 37, 215, 3, 141, 30, 129, 63, 9, 182
        };
        this.byte_12 = new byte[256]
        {
            0, 128, 64, 192, 32, 160, 96, 224, 16, 144, 80, 208, 48, 176, 112, 240, 8, 136, 72,
            200, 40, 168, 104, 232, 24, 152, 88, 216, 56, 184, 120, 248, 4, 132, 68, 196, 36,
            164, 100, 228, 20, 148, 84, 212, 52, 180, 116, 244, 12, 140, 76, 204, 44, 172, 108,
            236, 28, 156, 92, 220, 60, 188, 124, 252, 2, 130, 66, 194, 34, 162, 98, 226, 18,
            146,
      (byte) 82,
      (byte) 210,
      (byte) 50,
      (byte) 178,
      (byte) 114,
      (byte) 242,
      (byte) 10,
      (byte) 138,
      (byte) 74,
      (byte) 202,
      (byte) 42,
      (byte) 170,
      (byte) 106,
      (byte) 234,
      (byte) 26,
      (byte) 154,
      (byte) 90,
      (byte) 218,
      (byte) 58,
      (byte) 186,
      (byte) 122,
      (byte) 250,
      (byte) 6,
      (byte) 134,
      (byte) 70,
      (byte) 198,
      (byte) 38,
      (byte) 166,
      (byte) 102,
      (byte) 230,
      (byte) 22,
      (byte) 150,
      (byte) 86,
      (byte) 214,
      (byte) 54,
      (byte) 182,
      (byte) 118,
      (byte) 246,
      (byte) 14,
      (byte) 142,
      (byte) 78,
      (byte) 206,
      (byte) 46,
      (byte) 174,
      (byte) 110,
      (byte) 238,
      (byte) 30,
      (byte) 158,
      (byte) 94,
      (byte) 222,
      (byte) 62,
      (byte) 190,
      (byte) 126,
      (byte) 254,
      (byte) 1,
      (byte) 129,
      (byte) 65,
      (byte) 193,
      (byte) 33,
      (byte) 161,
      (byte) 97,
      (byte) 225,
      (byte) 17,
      (byte) 145,
      (byte) 81,
      (byte) 209,
      (byte) 49,
      (byte) 177,
      (byte) 113,
      (byte) 241,
      (byte) 9,
      (byte) 137,
      (byte) 73,
      (byte) 201,
      (byte) 41,
      (byte) 169,
      (byte) 105,
      (byte) 233,
      (byte) 25,
      (byte) 153,
      (byte) 89,
      (byte) 217,
      (byte) 57,
      (byte) 185,
      (byte) 121,
      (byte) 249,
      (byte) 5,
      (byte) 133,
      (byte) 69,
      (byte) 197,
      (byte) 37,
      (byte) 165,
      (byte) 101,
      (byte) 229,
      (byte) 21,
      (byte) 149,
      (byte) 85,
      (byte) 213,
      (byte) 53,
      (byte) 181,
      (byte) 117,
      (byte) 245,
      (byte) 13,
      (byte) 141,
      (byte) 77,
      (byte) 205,
      (byte) 45,
      (byte) 173,
      (byte) 109,
      (byte) 237,
      (byte) 29,
      (byte) 157,
      (byte) 93,
      (byte) 221,
      (byte) 61,
      (byte) 189,
      (byte) 125,
      (byte) 253,
      (byte) 3,
      (byte) 131,
      (byte) 67,
      (byte) 195,
      (byte) 35,
      (byte) 163,
      (byte) 99,
      (byte) 227,
      (byte) 19,
      (byte) 147,
      (byte) 83,
      (byte) 211,
      (byte) 51,
      (byte) 179,
      (byte) 115,
      (byte) 243,
      (byte) 11,
      (byte) 139,
      (byte) 75,
      (byte) 203,
      (byte) 43,
      (byte) 171,
      (byte) 107,
      (byte) 235,
      (byte) 27,
      (byte) 155,
      (byte) 91,
      (byte) 219,
      (byte) 59,
      (byte) 187,
      (byte) 123,
      (byte) 251,
      (byte) 7,
      (byte) 135,
      (byte) 71,
      (byte) 199,
      (byte) 39,
      (byte) 167,
      (byte) 103,
      (byte) 231,
      (byte) 23,
      (byte) 151,
      (byte) 87,
      (byte) 215,
      (byte) 55,
      (byte) 183,
      (byte) 119,
      (byte) 247,
      (byte) 15,
      (byte) 143,
      (byte) 79,
      (byte) 207,
      (byte) 47,
      (byte) 175,
      (byte) 111,
      (byte) 239,
      (byte) 31,
      (byte) 159,
      (byte) 95,
       223,
      (byte) 63,
      (byte) 191,
      (byte) 127,
      byte.MaxValue
        };
        this.byte_17 = new byte[65];
        this.byte_18 = new byte[3];
        this.int_18 = 1;
        this.int_24 = 80;
        this.int_25 = 60;
        this.int_31 = (int)byte.MaxValue;
        this.bool_31 = true;
        this.int_37 = 200;
        this.string_11 = new string[40];
        this.string_16 = "@"; // Module.a("鞶", 17);
        this.int_52 = 50000;
        this.bool_57 = true;
        this.int_82 = 1024;
        // ISSUE: explicit constructor call
        //   base.\u002Ector();
        string path1 = Application.StartupPath + "\\SET\\chyong_set.txt"; //Module.a("\uEBB6\uEAB8ﺺ\uE9BC\uE3BEꋀꯂ별\uA8C6\uA7C8곊鋌볎듐\uA7D2ﯔꏖꇘ꿚", 17);
        int num = 0;
        if (System.IO.File.Exists(path1))
        {
            using (StreamReader streamReader = new StreamReader(path1, Encoding.ASCII))
            {
                string str = streamReader.ReadLine();
                try
                {
                    num = Convert.ToInt32(str);
                }
                catch
                {
                    num = 0;
                }
            }
        }
        if (num == 0)
        {
            c.string_1 = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\LedEdit_T_setting\\chyong_ttype_2013.txt";
 //           c.string_1 = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + Module.a("\uEBB6\uF5B8\uDEBA\uD9BC諭ꗀꫂ뇄飆鷈铊뻌\uAACEꗐ\uA7D2볔맖뻘蟚뻜럞飠賢诤胦뛨\u9FEA駬雮臰雲ꫴ엶째쫺컼퇾甀笂焄", int_0, true);
            LogData.LogInfo($"In c num==0 - string_1: {string_1}");
            c.string_2 = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\LedEdit_T_setting"; //Module.a("\uEBB6\uF5B8\uDEBA\uD9BC諭ꗀꫂ뇄飆鷈铊뻌\uAACEꗐ\uA7D2볔맖뻘", int_0);
            LogData.LogInfo($"In c num==0 - string_2: { string_2}");
            var string3 = Module.a("\uE5B6첸햺즼횾곀ꛂ\uE5C4ꋆ믈맊ꋌ뷎\uFDD0뫒ꇔ\uF7D6께닚뇜돞쇠跢諤鏦짨飪髬蛮藰郲鷴ퟶ跸铺\uDDFC뫾漀搂椄渆稈挊ⴌ明缐朒瀔攖缘稚縜稞ഠ匢䤤䈦䠨堪䠬\u0F2E䐰崲尴夶䨸伺尼匾ⵀ捂ⱄ㍆效⩊⍌⭎煐❒㵔\u3256㝘筚⽜㩞\u0860ൢᙤ፦\u0868ݪŬ佮հ᭲ၴ坶\u0A78ᑺ᭼\u0B7E\uF680\uE282\uF784\uE286ꦈﾊ\uE28C꾎\uE590ﮒ\uF094랖\uDD98뮚列\uED9E좠햢삤螦욨\uD9AA趬\uEAAE醰ힲ잴\uDEB6쾸\uDEBA鶼麾", int_0, true);
            LogData.LogInfo($"In c num==0 - string3: {string3}");
            if (!Directory.Exists(c.string_2))
                Directory.CreateDirectory(c.string_2);
        }
        else
        {
            c.string_1 = "D:\\LedEdit_T_setting\\chyong_ttype_2013.txt"; //Module.a("\uF3B6莸\uE7BA\uF1BC\uDABEꗀ蛂ꇄ껆뷈铊駌郎ꋐ뛒ꇔꏖ냘뗚뫜菞苠询鳤裦蟨質달鯮藰諲藴鋶\uA6F8짺췼컾㈀ⴂ焄缆紈", int_0, true);
 //           c.string_1 = Module.a("\uF3B6莸\uE7BA\uF1BC\uDABEꗀ蛂ꇄ껆뷈铊駌郎ꋐ뛒ꇔꏖ냘뗚뫜菞苠询鳤裦蟨質달鯮藰諲藴鋶\uA6F8짺췼컾㈀ⴂ焄缆紈", int_0, true);
            LogData.LogInfo($"In c num!=0 - string_1: {string_1}");
            //            c.string_1 = Module.a("\uF3B6莸\uE7BA\uF1BC\uDABEꗀ蛂ꇄ껆뷈铊駌郎ꋐ뛒ꇔꏖ냘뗚뫜菞苠询鳤裦蟨質달鯮藰諲藴鋶\uA6F8짺췼컾㈀ⴂ焄缆紈", int_0);
            c.string_2 = "D:\\LedEdit_T_setting"; //Module.a("\uF3B6莸\uE7BA\uF1BC\uDABEꗀ蛂ꇄ껆뷈铊駌郎ꋐ뛒ꇔꏖ냘뗚뫜", int_0);
            LogData.LogInfo($"In c num!=0 - string_2: {string_2}");
            if (!Directory.Exists(c.string_2))
                Directory.CreateDirectory(c.string_2);
        }
        string str1 = Application.StartupPath + "\\SET\\qd.jpg"; //Module.a("\uEBB6\uEAB8ﺺ\uE9BC\uE3BE냀\uA7C2\uEBC4귆마곊", int_0);
        if (System.IO.File.Exists(str1))
        {
            GForm1 gform1 = new GForm1();
            gform1.BackgroundImage = Image.FromFile(str1);
            gform1.Show();
            Application.DoEvents();
            Thread.Sleep(2000);
            gform1.Close();
        }
        this.bool_23 = false;
        this.bool_24 = false;
        this.byte_31 = new byte[20];
        c.double_2 = 1.8;
        c.byte_13 = byte.MaxValue;
        c.byte_14 = byte.MaxValue;
        c.byte_15 = byte.MaxValue;
        this.method_79();
        string path2 = c.string_2 + "\\en.txt";  //Module.a("\uEBB6\uDCB8햺鎼쮾맀럂", int_0);
        if (System.IO.File.Exists(path2))
        {
            using (StreamReader streamReader = new StreamReader(path2, Encoding.ASCII))
            {
                bool flag = false;
                try
                {
                    flag = Convert.ToBoolean(streamReader.ReadLine());
                }
                catch
                {
                }
                if (flag)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
 //                   Thread.CurrentThread.CurrentUICulture = new CultureInfo(Module.a("튶ힸ隺\uE8BC\uECBE", int_0));
                    c.useEnglishLanguage = true;
                }
                else
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("zh-CN");
//                    Thread.CurrentThread.CurrentUICulture = new CultureInfo(Module.a("춶톸隺ﺼ\uF1BE", int_0));
                    c.useEnglishLanguage = false;
                }
            }
        }
        else if (new h().ShowDialog() == DialogResult.OK)
        {
            Thread.CurrentThread.CurrentUICulture = !c.useEnglishLanguage ? new CultureInfo("zh-CN") : new CultureInfo("en-US");
 //           Thread.CurrentThread.CurrentUICulture = !c.useEnglishLanguage ? new CultureInfo(Module.a("춶톸隺ﺼ\uF1BE", int_0)) : new CultureInfo(Module.a("튶ힸ隺\uE8BC\uECBE", int_0));
            using (StreamWriter streamWriter = new StreamWriter(path2, false, Encoding.ASCII))
                streamWriter.WriteLine(c.useEnglishLanguage.ToString());
        }
        string path3 = Application.StartupPath + "\\en.txt"; //Module.a("\uEBB6\uDCB8햺鎼쮾맀럂", int_0);
        try
        {
            if (System.IO.File.Exists(path3))
                System.IO.File.Delete(path3);
            using (StreamWriter streamWriter = new StreamWriter(path3, false, Encoding.ASCII))
                streamWriter.WriteLine(c.useEnglishLanguage.ToString());
        }
        catch
        {
            if (c.useEnglishLanguage)
                this.ShowMessage("The software is running incorrectly, which will cause the Chinese interface and English interface to be unable to switch normally. Please uninstall the software.\r\n\r\n");
         //       this.ShowMessage(Module.a("\uE5B6첸햺즼횾곀ꛂ\uE5C4ꋆ믈맊ꋌ뷎\uFDD0뫒ꇔ\uF7D6께닚뇜돞쇠跢諤鏦짨飪髬蛮藰郲鷴ퟶ跸铺\uDDFC뫾漀搂椄渆稈挊ⴌ明缐朒瀔攖缘稚縜稞ഠ匢䤤䈦䠨堪䠬\u0F2E䐰崲尴夶䨸伺尼匾ⵀ捂ⱄ㍆效⩊⍌⭎煐❒㵔\u3256㝘筚⽜㩞\u0860ൢᙤ፦\u0868ݪŬ佮հ᭲ၴ坶\u0A78ᑺ᭼\u0B7E\uF680\uE282\uF784\uE286ꦈﾊ\uE28C꾎\uE590ﮒ\uF094랖\uDD98뮚列\uED9E좠햢삤螦욨\uD9AA趬\uEAAE醰ힲ잴\uDEB6쾸\uDEBA鶼麾", int_0));
//            this.ShowMessage(Module.a("\uE5B6첸햺즼횾곀ꛂ\uE5C4ꋆ믈맊ꋌ뷎\uFDD0뫒ꇔ\uF7D6께닚뇜돞쇠跢諤鏦짨飪髬蛮藰郲鷴ퟶ跸铺\uDDFC뫾漀搂椄渆稈挊ⴌ明缐朒瀔攖缘稚縜稞ഠ匢䤤䈦䠨堪䠬\u0F2E䐰崲尴夶䨸伺尼匾ⵀ捂ⱄ㍆效⩊⍌⭎煐❒㵔\u3256㝘筚⽜㩞\u0860ൢᙤ፦\u0868ݪŬ佮հ᭲ၴ坶\u0A78ᑺ᭼\u0B7E\uF680\uE282\uF784\uE286ꦈﾊ\uE28C꾎\uE590ﮒ\uF094랖\uDD98뮚列\uED9E좠햢삤螦욨\uD9AA趬\uEAAE醰ힲ잴\uDEB6쾸\uDEBA鶼麾", int_0));
            else
                this.ShowMessage(Module.a("\uD839俶欵\uF134ꘫ\u2E4B\uEFC2\u1C4B솚㖓㽋\uEDCC\uE280嚵龧띃\uF7D6喌ﯚⱞ墻궕腵엤\uEAA8ᑨ袁햲\uE8BC鎓\uDFF2ɿ\uF1AA陷ප薯艱ⴀ㕳\u0B50쪗륭艑좄㽜唐쭤Ͷኖ尘썬ፈ鉏\uF4ABȢ", int_0));
        }
 //       string path4 = Application.StartupPath + Module.a("\uEBB6\uEAB8ﺺ\uE9BC\uE3BE럀ꛂ럄\uE9C6뷈돊만", int_0);
        string path4 = Application.StartupPath + "\\SET\\ver.txt";
        if (System.IO.File.Exists(path4))
        {
            using (StreamReader streamReader = new StreamReader(path4, Encoding.ASCII))
                c.string_0 = streamReader.ReadLine();
        }
        this.method_3();
        this.method_2();
        c.bool_32 = false;
        c.i_0 = new i();
        this.bool_37 = false;
        this.bool_38 = false;
        this.bool_50 = false;
        this.bool_39 = false;
        this.bool_25 = false;
        this.genum1_1 = GEnum1.const_0;
        this.method_31();
        this.int_12 = 1;
        this.int_13 = 1;
        this.int_11 = 0;
        this.int_15 = 0;
        this.bool_13 = false;
        this.menuItem_98.Enabled = false;
        this.menuItem_99.Enabled = false;
        this.menuItem_100.Enabled = false;
        this.menuItem_101.Enabled = false;
        this.menuItem_102.Enabled = false;
        string str2 = Application.StartupPath + "\\SET\\icon.ico"; //Module.a("\uEBB6\uEAB8ﺺ\uE9BC\uE3BEꣀꃂ\uAAC4꧆\uE7C8ꋊ껌ꃎ", int_0);
        if (System.IO.File.Exists(str2))
            this.Icon = new Icon(str2);
        Class1 class1 = new Class1();
        c.bool_35 = false;
        string path5 = Application.StartupPath + "\\SET\\set_xb.txt"; //Module.a("\uEBB6\uEAB8ﺺ\uE9BC\uE3BE닀ꛂ뇄飆뇈꧊\uE3CC믎꧐\uA7D2", int_0);
        if (System.IO.File.Exists(path5))
        {
            c.bool_35 = true;
            string string_1_1 = (string)null;
            using (StreamReader streamReader = new StreamReader(path5, Encoding.ASCII))
            {
                try
                {
                    string_1_1 = streamReader.ReadLine();
                }
                catch
                {
                }
                this.string_8 = class1.method_1(string_1_1, Class1.string_0);
                this.Text = this.string_8;
                int index = 0;
                do
                {
                    string string_1_2;
                    try
                    {
                        string_1_2 = streamReader.ReadLine();
                    }
                    catch
                    {
                        break;
                    }
                    if (string_1_2 != null)
                    {
                        string[] strArray = class1.method_1(string_1_2, Class1.string_0).Split(';');
                        if (strArray.Length == 3)
                        {
                            c.string_13[index] = strArray[0];
                            c.string_14[index] = strArray[1];
                            c.string_15[index] = strArray[2];
                            ++index;
                        }
                        else
                            break;
                    }
                    else
                        break;
                }
                while (index != c.string_13.Length);
            }
        }
        if (!c.bool_35)
        {
            string path6 = Application.StartupPath + "\\SET\\set.txt"; //Module.a("\uEBB6\uEAB8ﺺ\uE9BC\uE3BE닀ꛂ뇄\uE9C6뷈돊만", int_0);
            if (System.IO.File.Exists(path6))
            {
                using (StreamReader streamReader = new StreamReader(path6, Encoding.ASCII))
                {
                    this.string_8 = streamReader.ReadLine();
                    this.Text = this.string_8 + "@" + c.string_0;
//                    this.Text = this.string_8 + Module.a("鞶", int_0) + c.string_0;
                    for (int index = 0; index < c.string_12.Length; ++index)
                    {
                        try
                        {
                            c.string_12[index] = streamReader.ReadLine();
                        }
                        catch
                        {
                            break;
                        }
                    }
                    if (this.string_8 == "LED007") //Module.a("﮶ﲸﾺ趼达\uF6C0", int_0))
                        this.menuItem_24.Visible = false;
                }
            }
        }
        string path7 = Application.StartupPath + "\\SET\\6803.txt"; //Module.a("\uEBB6\uEAB8ﺺ\uE9BC\uE3BE\uF7C0\uFBC2\uF5C4\uF4C6\uE7C8뿊뗌믎", int_0);
        if (System.IO.File.Exists(path7))
        {
            using (StreamReader streamReader = new StreamReader(path7, Encoding.ASCII))
            {
                string str3 = streamReader.ReadLine();
                try
                {
                    c.int_4 = Convert.ToInt32(str3);
                }
                catch
                {
                    c.int_4 = 1024;
                }
            }
        }
        this.string_5 = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + (object)'\\' + "xb_swf_ck.jp";//Module.a("쾶\uDBB8\uE4BA캼좾\uA7C0鳂ꛄ곆\uE7C8ꇊ뷌꣎", int_0);
        this.color_0 = new Color[10];
        this.color_0[0] = Color.FromArgb(128, (int)byte.MaxValue, 128);
        this.color_0[1] = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, 128);
        this.color_0[2] = Color.FromArgb((int)byte.MaxValue, 128, 128);
        this.color_0[3] = Color.FromArgb(128, (int)byte.MaxValue, (int)byte.MaxValue);
        this.color_0[4] = Color.FromArgb(0, 128, (int)byte.MaxValue);
        this.color_0[5] = Color.FromArgb((int)byte.MaxValue, 128, 192);
        this.color_0[6] = Color.FromArgb((int)byte.MaxValue, 0, 0);
        this.color_0[7] = Color.FromArgb((int)byte.MaxValue, 128, 64);
        this.color_0[8] = Color.FromArgb(0, 0, (int)byte.MaxValue);
        this.color_0[9] = Color.FromArgb(206, 103, 0);
        c.arrayList_4 = new ArrayList();
        this.ad_0 = new ad[4];
        this.axShockwaveFlash_0 = new AxShockwaveFlash[4];
        this.class0_0 = new Class0[4];
        this.class4_0 = new Class4[5];
        this.byte_35 = new byte[10];
        this.bool_27 = false;
        try
        {
            this.udpClient_0 = new UdpClient();
        }
        catch
        {
            if (c.useEnglishLanguage)
                this.ShowMessage("Error occurs while creating UDP!");
 //           this.ShowMessage(Module.a("\uF2B6쮸즺튼춾\uE1C0곂ꛄ꓆볈맊뻌\uEFCEꛐ믒볔믖볘ﯚ뻜귞蓠苢釤軦蟨質췬뫮뗰ꏲ퓴", int_0));
            else
                this.ShowMessage("创建UDP出错！");
//            this.ShowMessage(Module.a("곤䏦\uEEBA寮\uEFBE㮑\uDA57쐻", int_0));
        }
        this.udpClient_0.Client.Blocking = false;
        this.class4_0[4] = new Class4();
        this.bool_8 = false;
    }

    // public virtual void OnShown(EventArgs e) => ((Form) this).OnShown(e);



    private void method_3()
    {
        this.icontainer_0 = (IContainer)new System.ComponentModel.Container();
        ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(c));
        this.openFileDialog_0 = new OpenFileDialog();
        this.mainMenu_0 = new MainMenu(this.icontainer_0);
        this.menuItem_11 = new MenuItem();
        this.menuItem_12 = new MenuItem();
        this.menuItem_13 = new MenuItem();
        this.menuItem_29 = new MenuItem();
        this.menuItem_0 = new MenuItem();
        this.menuItem_30 = new MenuItem();
        this.menuItem_72 = new MenuItem();
        this.menuItem_73 = new MenuItem();
        this.menuItem_14 = new MenuItem();
        this.menuItem_93 = new MenuItem();
        this.menuItem_15 = new MenuItem();
        this.menuItem_74 = new MenuItem();
        this.menuItem_19 = new MenuItem();
        this.menuItem_38 = new MenuItem();
        this.menuItem_57 = new MenuItem();
        this.menuItem_63 = new MenuItem();
        this.menuItem_75 = new MenuItem();
        this.menuItem_76 = new MenuItem();
        this.menuItem_77 = new MenuItem();
        this.menuItem_78 = new MenuItem();
        this.menuItem_83 = new MenuItem();
        this.menuItem_84 = new MenuItem();
        this.menuItem_85 = new MenuItem();
        this.menuItem_87 = new MenuItem();
        this.menuItem_97 = new MenuItem();
        this.menuItem_109 = new MenuItem();
        this.menuItem_22 = new MenuItem();
        this.menuItem_8 = new MenuItem();
        this.menuItem_96 = new MenuItem();
        this.menuItem_92 = new MenuItem();
        this.menuItem_9 = new MenuItem();
        this.menuItem_103 = new MenuItem();
        this.menuItem_70 = new MenuItem();
        this.menuItem_71 = new MenuItem();
        this.menuItem_66 = new MenuItem();
        this.menuItem_42 = new MenuItem();
        this.menuItem_43 = new MenuItem();
        this.menuItem_44 = new MenuItem();
        this.menuItem_45 = new MenuItem();
        this.menuItem_46 = new MenuItem();
        this.menuItem_69 = new MenuItem();
        this.menuItem_88 = new MenuItem();
        this.menuItem_89 = new MenuItem();
        this.menuItem_90 = new MenuItem();
        this.menuItem_60 = new MenuItem();
        this.menuItem_47 = new MenuItem();
        this.menuItem_48 = new MenuItem();
        this.menuItem_49 = new MenuItem();
        this.menuItem_50 = new MenuItem();
        this.menuItem_51 = new MenuItem();
        this.menuItem_52 = new MenuItem();
        this.menuItem_53 = new MenuItem();
        this.menuItem_54 = new MenuItem();
        this.menuItem_55 = new MenuItem();
        this.menuItem_56 = new MenuItem();
        this.menuItem_61 = new MenuItem();
        this.menuItem_23 = new MenuItem();
        this.menuItem_1 = new MenuItem();
        this.menuItem_7 = new MenuItem();
        this.menuItem_80 = new MenuItem();
        this.menuItem_81 = new MenuItem();
        this.menuItem_82 = new MenuItem();
        this.menuItem_104 = new MenuItem();
        this.menuItem_105 = new MenuItem();
        this.menuItem_106 = new MenuItem();
        this.menuItem_2 = new MenuItem();
        this.menuItem_10 = new MenuItem();
        this.menuItem_20 = new MenuItem();
        this.menuItem_3 = new MenuItem();
        this.menuItem_113 = new MenuItem();
        this.menuItem_21 = new MenuItem();
        this.menuItem_94 = new MenuItem();
        this.menuItem_67 = new MenuItem();
        this.menuItem_4 = new MenuItem();
        this.menuItem_5 = new MenuItem();
        this.menuItem_6 = new MenuItem();
        this.menuItem_25 = new MenuItem();
        this.menuItem_28 = new MenuItem();
        this.menuItem_26 = new MenuItem();
        this.menuItem_27 = new MenuItem();
        this.menuItem_31 = new MenuItem();
        this.menuItem_68 = new MenuItem();
        this.menuItem_108 = new MenuItem();
        this.menuItem_107 = new MenuItem();
        this.menuItem_98 = new MenuItem();
        this.menuItem_99 = new MenuItem();
        this.menuItem_100 = new MenuItem();
        this.menuItem_101 = new MenuItem();
        this.menuItem_102 = new MenuItem();
        this.menuItem_32 = new MenuItem();
        this.menuItem_33 = new MenuItem();
        this.menuItem_34 = new MenuItem();
        this.menuItem_39 = new MenuItem();
        this.menuItem_40 = new MenuItem();
        this.menuItem_41 = new MenuItem();
        this.menuItem_58 = new MenuItem();
        this.menuItem_110 = new MenuItem();
        this.menuItem_111 = new MenuItem();
        this.menuItem_112 = new MenuItem();
        this.menuItem_35 = new MenuItem();
        this.menuItem_36 = new MenuItem();
        this.menuItem_62 = new MenuItem();
        this.menuItem_37 = new MenuItem();
        this.menuItem_16 = new MenuItem();
        this.menuItem_59 = new MenuItem();
        this.menuItem_17 = new MenuItem();
        this.menuItem_86 = new MenuItem();
        this.menuItem_64 = new MenuItem();
        this.menuItem_79 = new MenuItem();
        this.menuItem_91 = new MenuItem();
        this.menuItem_95 = new MenuItem();
        this.menuItem_24 = new MenuItem();
        this.menuItem_65 = new MenuItem();
        this.menuItem_18 = new MenuItem();
        this.saveFileDialog_0 = new SaveFileDialog();
        this.panel_0 = new Panel();
        this.panel_1 = new Panel();
        this.panel_3 = new Panel();
        this.label_11 = new Label();
        this.panel_2 = new Panel();
        this.button_0 = new Button();
        this.groupBox_1 = new GroupBox();
        this.label_10 = new Label();
        this.textBox_3 = new TextBox();
        this.label_9 = new Label();
        this.label_7 = new Label();
        this.label_8 = new Label();
        this.textBox_1 = new TextBox();
        this.label_5 = new Label();
        this.textBox_2 = new TextBox();
        this.label_6 = new Label();
        this.groupBox_0 = new GroupBox();
        this.label_1 = new Label();
        this.label_2 = new Label();
        this.label_0 = new Label();
        this.label_3 = new Label();
        this.label_4 = new Label();
        this.progressBar_0 = new ProgressBar();
        this.toolStrip_0 = new ToolStrip();
        this.toolStripButton_5 = new ToolStripButton();
        this.toolStripButton_0 = new ToolStripButton();
        this.toolStripButton_7 = new ToolStripButton();
        this.toolStripButton_8 = new ToolStripButton();
        this.toolStripSeparator_4 = new ToolStripSeparator();
        this.toolStripButton_25 = new ToolStripButton();
        this.toolStripButton_9 = new ToolStripButton();
        this.toolStripSeparator_1 = new ToolStripSeparator();
        this.toolStripButton_1 = new ToolStripButton();
        this.toolStripButton_2 = new ToolStripButton();
        this.toolStripSeparator_2 = new ToolStripSeparator();
        this.toolStripButton_10 = new ToolStripButton();
        this.toolStripButton_11 = new ToolStripButton();
        this.toolStripSeparator_5 = new ToolStripSeparator();
        this.toolStripButton_3 = new ToolStripButton();
        this.toolStripButton_4 = new ToolStripButton();
        this.toolStripSeparator_0 = new ToolStripSeparator();
        this.toolStripButton_6 = new ToolStripButton();
        this.toolStripSeparator_3 = new ToolStripSeparator();
        this.toolStripButton_22 = new ToolStripButton();
        this.toolStripButton_23 = new ToolStripButton();
        this.toolStripLabel_3 = new ToolStripLabel();
        this.toolStripTextBox_2 = new ToolStripTextBox();
        this.toolStripButton_24 = new ToolStripButton();
        this.toolStripButton_26 = new ToolStripButton();
        this.trackBar_0 = new TrackBar();
        this.toolStrip_1 = new ToolStrip();
        this.toolStripTextBox_3 = new ToolStripTextBox();
        this.toolStripSeparator_6 = new ToolStripSeparator();
        this.toolStripButton_12 = new ToolStripButton();
        this.toolStripButton_13 = new ToolStripButton();
        this.toolStripButton_15 = new ToolStripButton();
        this.toolStripButton_18 = new ToolStripButton();
        this.toolStripButton_16 = new ToolStripButton();
        this.toolStripButton_17 = new ToolStripButton();
        this.toolStripSeparator_7 = new ToolStripSeparator();
        this.toolStripButton_14 = new ToolStripButton();
        this.toolStripSeparator_8 = new ToolStripSeparator();
        this.toolStripButton_19 = new ToolStripButton();
        this.toolStripButton_20 = new ToolStripButton();
        this.toolStripSeparator_10 = new ToolStripSeparator();
        this.toolStripLabel_1 = new ToolStripLabel();
        this.toolStripTextBox_1 = new ToolStripTextBox();
        this.toolStripLabel_2 = new ToolStripLabel();
        this.toolStripSeparator_11 = new ToolStripSeparator();
        this.toolStripButton_21 = new ToolStripButton();
        this.toolStripSeparator_9 = new ToolStripSeparator();
        this.toolStripLabel_0 = new ToolStripLabel();
        this.toolStripTextBox_0 = new ToolStripTextBox();
        this.textBox_0 = new TextBox();
        this.contextMenuStrip_0 = new ContextMenuStrip(this.icontainer_0);
        this.toolStripMenuItem_0 = new ToolStripMenuItem();
        this.toolStripMenuItem_1 = new ToolStripMenuItem();
        this.toolStripMenuItem_2 = new ToolStripMenuItem();
        this.toolStripMenuItem_3 = new ToolStripMenuItem();
        this.toolStripMenuItem_4 = new ToolStripMenuItem();
        this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
        this.timer_1 = new System.Windows.Forms.Timer(this.icontainer_0);
        this.timer_2 = new System.Windows.Forms.Timer(this.icontainer_0);
        this.hscrollBar_0 = new HScrollBar();
        this.vscrollBar_0 = new VScrollBar();
        this.timer_3 = new System.Windows.Forms.Timer(this.icontainer_0);
        this.contextMenuStrip_1 = new ContextMenuStrip(this.icontainer_0);
        this.toolStripMenuItem_5 = new ToolStripMenuItem();
        this.toolStripMenuItem_6 = new ToolStripMenuItem();
        this.toolStripMenuItem_7 = new ToolStripMenuItem();
        this.toolStripMenuItem_8 = new ToolStripMenuItem();
        this.toolStripMenuItem_9 = new ToolStripMenuItem();
        this.toolStripMenuItem_10 = new ToolStripMenuItem();
        this.toolStripMenuItem_11 = new ToolStripMenuItem();
        this.toolStripMenuItem_12 = new ToolStripMenuItem();
        this.toolStripMenuItem_13 = new ToolStripMenuItem();
        this.label_12 = new Label();
        this.label_13 = new Label();
        this.tabControl_0 = new TabControl();
        this.tabPage_0 = new TabPage();
        this.textBox_4 = new TextBox();
        this.label_14 = new Label();
        this.button_1 = new Button();
        this.button_2 = new Button();
        this.button_3 = new Button();
        this.listBox_0 = new ListBox();
        this.button_4 = new Button();
        this.tabPage_1 = new TabPage();
        this.treeView_0 = new TreeView();
        this.label_15 = new Label();
        this.button_5 = new Button();
        this.textBox_5 = new TextBox();
        this.label_16 = new Label();
        this.button_6 = new Button();
        this.button_7 = new Button();
        this.button_8 = new Button();
        this.button_9 = new Button();
        this.button_10 = new Button();
        this.listBox_1 = new ListBox();
        this.panel_1.SuspendLayout();
        this.panel_3.SuspendLayout();
        this.panel_2.SuspendLayout();
        this.groupBox_1.SuspendLayout();
        this.groupBox_0.SuspendLayout();
        this.toolStrip_0.SuspendLayout();
        this.trackBar_0.BeginInit();
        this.toolStrip_1.SuspendLayout();
        this.contextMenuStrip_0.SuspendLayout();
        this.contextMenuStrip_1.SuspendLayout();
        this.tabControl_0.SuspendLayout();
        this.tabPage_0.SuspendLayout();
        this.tabPage_1.SuspendLayout();
        this.SuspendLayout();

        #region Main menu 1
        componentResourceManager.ApplyResources((object)this.openFileDialog_0, "openFileDialog1" /* Module.a("욨\uDBAA좬솮\uF7B0\uDAB2\uD9B4튶ﶸ튺\uDCBC펾껀꓂\uF4C4", 3) */);
        this.mainMenu_0.MenuItems.AddRange(new MenuItem[11]
        {
      this.menuItem_11,
      this.menuItem_30,
      this.menuItem_22,
      this.menuItem_23,
      this.menuItem_104,
      this.menuItem_2,
      this.menuItem_4,
      this.menuItem_32,
      this.menuItem_35,
      this.menuItem_16,
      this.menuItem_24
        });
        componentResourceManager.ApplyResources((object)this.mainMenu_0, "mainMenu1" /*Module.a("쒨쪪쒬솮ﲰ횲\uDBB4슶袸", 3)*/);
        LogData.LogInfo($"menuItem_0 : {menuItem_0.Text}");

        // Main Menu
        //  File(&F)
        componentResourceManager.ApplyResources((object)this.menuItem_11, "menuItem4" /*Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6趸", 3)*/);
        LogData.LogInfo($"menuItem_11 : {menuItem_11.Text}");
        this.menuItem_11.Index = 0;
        this.menuItem_11.MenuItems.AddRange(new MenuItem[4]
        {
      this.menuItem_12,
      this.menuItem_13,
      this.menuItem_29,
      this.menuItem_0
        });

        // New Project(&N)...
        componentResourceManager.ApplyResources((object)this.menuItem_12, "menuItem14"/*Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6袸辺", 3)*/);
        LogData.LogInfo($"menuItem_12 : {menuItem_12.Text}");
        this.menuItem_12.Index = 0;
        this.menuItem_12.Click += new EventHandler(this.menuItem_12_Click);

        // Open Project(&O)...
        componentResourceManager.ApplyResources((object)this.menuItem_13, "menuItem19" /*Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6袸芺", 3)*/);
        LogData.LogInfo($"menuItem_13 : {menuItem_13.Text}");
        this.menuItem_13.Index = 1;
        this.menuItem_13.Click += new EventHandler(this.menuItem_13_Click);

        // Close Project(&C)
        componentResourceManager.ApplyResources((object)this.menuItem_29, "menuItem37" /*Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6誸貺", 3)*/);
        LogData.LogInfo($"menuItem_29 : {menuItem_29.Text}");
        this.menuItem_29.Index = 2;
        this.menuItem_29.Click += new EventHandler(this.menuItem_29_Click);

        // Exit(&E)
        componentResourceManager.ApplyResources((object)this.menuItem_0, "menuItem3" /*Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6誸", 3)*/);
        LogData.LogInfo($"menuItem_0 : {menuItem_0.Text}");
        this.menuItem_0.Index = 3;
        this.menuItem_0.Click += new EventHandler(this.menuItem_0_Click);
        #endregion

        #region Main menu 2
        // Main Menu - Menu 2
        // Project Config (&C)
        componentResourceManager.ApplyResources((object)this.menuItem_30, "menuItem38" /*Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6誸莺", 3)*/);
        LogData.LogInfo($"menuItem_30 : {menuItem_30.Text}");
        this.menuItem_30.Index = 1;
        this.menuItem_30.MenuItems.AddRange(new MenuItem[18]
        {
      this.menuItem_72,
      this.menuItem_73,
      this.menuItem_14,
      this.menuItem_93,
      this.menuItem_15,
      this.menuItem_74,
      this.menuItem_19,
      this.menuItem_38,
      this.menuItem_57,
      this.menuItem_63,
      this.menuItem_75,
      this.menuItem_76,
      this.menuItem_83,
      this.menuItem_84,
      this.menuItem_85,
      this.menuItem_87,
      this.menuItem_97,
      this.menuItem_109
        });


        componentResourceManager.ApplyResources((object)this.menuItem_72, "menuItem71" /*Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6躸誺", 3)*/);
        LogData.LogInfo($"menuItem_71 : {menuItem_71.Text}");
        this.menuItem_72.Index = 0;
        this.menuItem_72.Click += new EventHandler(this.menuItem_72_Click);

        // Import(.cxb) (&C)
        componentResourceManager.ApplyResources((object)this.menuItem_73, "menuItem82"  /*Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6膸覺", 3)*/);
        LogData.LogInfo($"menuItem_73 : {menuItem_73.Text}");
        this.menuItem_73.Index = 1;
        this.menuItem_73.Click += new EventHandler(this.menuItem_73_Click);

        // Import(.dxf) (&E)...
        componentResourceManager.ApplyResources((object)this.menuItem_14, "menuItem21" /*Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6许誺", 3)*/);
        LogData.LogInfo($"menuItem_14 : {menuItem_14.Text}");
        this.menuItem_14.Index = 2;
        this.menuItem_14.Click += new EventHandler(this.menuItem_14_Click);

        // Import（CorelDRAW .Dxf）(&W)
        componentResourceManager.ApplyResources((object)this.menuItem_93, "menuItem100" /*Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6袸论趼", 3)*/);
        LogData.LogInfo($"menuItem_93 : {menuItem_93.Text}");
        this.menuItem_93.Index = 3;
        this.menuItem_93.Click += new EventHandler(this.menuItem_93_Click);

        // Auto Layout(&A)...
        componentResourceManager.ApplyResources((object)this.menuItem_15, "menuItem2" /*Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6许", 3)*/);
        LogData.LogInfo($"menuItem_15 : {menuItem_15.Text}");
        this.menuItem_15.Index = 4;
        this.menuItem_15.Click += new EventHandler(this.menuItem_15_Click);


        componentResourceManager.ApplyResources((object)this.menuItem_74, "menuItem20" /*Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6许论", 3)*/);
        LogData.LogInfo($"menuItem_74 : {menuItem_74.Text}");
        this.menuItem_74.Index = 5;

        // Frame Rate(&F)...
        componentResourceManager.ApplyResources((object)this.menuItem_19, "menuItem23" /*Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6许袺", 3)*/);
        LogData.LogInfo($"menuItem_19 : {menuItem_19.Text}");
        this.menuItem_19.Index = 6;
        this.menuItem_19.Click += new EventHandler(this.menuItem_19_Click);

        // Zoom(&Z)...
        componentResourceManager.ApplyResources((object)this.menuItem_38, "menuItem46" /*Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6趸趺", 3)*/);
        LogData.LogInfo($"menuItem_38 : {menuItem_38.Text}");
        this.menuItem_38.Index = 7;
        this.menuItem_38.Click += new EventHandler(this.menuItem_38_Click);

        // Pixel(&R)
        componentResourceManager.ApplyResources((object)this.menuItem_57, "menuItem67" /*Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6辸貺", 3)*/);
        LogData.LogInfo($"menuItem_57 : {menuItem_57.Text}");
        this.menuItem_57.Index = 8;
        this.menuItem_57.Click += new EventHandler(this.menuItem_57_Click);

        // Gamma and Brightness(G)
        componentResourceManager.ApplyResources((object)this.menuItem_63, "menuItem68" /*Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6辸莺", 3)*/);
        LogData.LogInfo($"menuItem_63 : {menuItem_63.Text}");
        this.menuItem_63.Index = 9;
        this.menuItem_63.Click += new EventHandler(this.menuItem_63_Click);

        // Preferences(&P)...
        componentResourceManager.ApplyResources((object)this.menuItem_75, "menuItem31" /*Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6誸誺", 3)*/);
        LogData.LogInfo($"menuItem_75 : {menuItem_75.Text}");
        this.menuItem_75.Index = 10;
        this.menuItem_75.Click += new EventHandler(this.menuItem_75_Click);

        // Language(&L)
        componentResourceManager.ApplyResources((object)this.menuItem_76, "menuItem83" /* Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6膸袺", 3) */);
        LogData.LogInfo($"menuItem_76 : {menuItem_76.Text}");
        this.menuItem_76.Index = 11;
        this.menuItem_76.MenuItems.AddRange(new MenuItem[2]
        {
      this.menuItem_77,
      this.menuItem_78
        });
        //&Chinese
        componentResourceManager.ApplyResources((object)this.menuItem_77, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6膸辺", 3));
        LogData.LogInfo($"menuItem77 : {menuItem_77.Text}" );
        this.menuItem_77.Index = 0;
        this.menuItem_77.Click += new EventHandler(this.menuItem_77_Click);

        // &English
        componentResourceManager.ApplyResources((object)this.menuItem_78, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6膸躺", 3));
        LogData.LogInfo($"menuItem78 : {menuItem_78.Text}");
        this.menuItem_78.Index = 1;
        this.menuItem_78.Click += new EventHandler(this.menuItem_78_Click);

        // Refresh(&S)
        componentResourceManager.ApplyResources((object)this.menuItem_83, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6肸论", 3));
        LogData.LogInfo($"menuItem83 : {menuItem_83.Text}");
        this.menuItem_83.Index = 12;
        this.menuItem_83.Click += new EventHandler(this.menuItem_83_Click);

        // Set the controller number(&N)...
        componentResourceManager.ApplyResources((object)this.menuItem_84, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6肸誺", 3));
        LogData.LogInfo($"menuItem84 : {menuItem_84.Text}");
        this.menuItem_84.Index = 13;
        this.menuItem_84.Click += new EventHandler(this.menuItem_84_Click);

        // Controller encryption...
        componentResourceManager.ApplyResources((object)this.menuItem_85, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6肸覺", 3));
        LogData.LogInfo($"menuItem85 : {menuItem_85.Text}");
        this.menuItem_85.Index = 14;
        this.menuItem_85.Click += new EventHandler(this.menuItem_85_Click);

        // Setting current...
        componentResourceManager.ApplyResources((object)this.menuItem_87, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6肸辺", 3));
        LogData.LogInfo($"menuItem87 : {menuItem_87.Text}");
        this.menuItem_87.Index = 15;
        this.menuItem_87.Click += new EventHandler(this.menuItem_87_Click);

        // Set time(&T)...
        componentResourceManager.ApplyResources((object)this.menuItem_97, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6袸论覼", 3));
        LogData.LogInfo($"menuItem97 : {menuItem_97.Text}");
        this.menuItem_97.Index = 16;
        this.menuItem_97.Click += new EventHandler(this.menuItem_97_Click);

        // DMX address setting...
        componentResourceManager.ApplyResources((object)this.menuItem_109, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6袸誺趼", 3));
        LogData.LogInfo($"menuItem109 : {menuItem_109.Text}");
        this.menuItem_109.Index = 17;
        this.menuItem_109.Click += new EventHandler(this.menuItem_109_Click);
        #endregion

        #region Main menu - 3
        // Main Menu - menu 3
        // Video Effect(&F)
        componentResourceManager.ApplyResources((object)this.menuItem_22, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6誸覺", 3));
        LogData.LogInfo($"menuItem22 : {menuItem_22.Text}");
        this.menuItem_22.Index = 2;
        this.menuItem_22.MenuItems.AddRange(new MenuItem[29]
        {
      this.menuItem_8,
      this.menuItem_96,
      this.menuItem_92,
      this.menuItem_9,
      this.menuItem_103,
      this.menuItem_70,
      this.menuItem_71,
      this.menuItem_66,
      this.menuItem_42,
      this.menuItem_43,
      this.menuItem_44,
      this.menuItem_45,
      this.menuItem_46,
      this.menuItem_69,
      this.menuItem_88,
      this.menuItem_89,
      this.menuItem_90,
      this.menuItem_60,
      this.menuItem_47,
      this.menuItem_48,
      this.menuItem_49,
      this.menuItem_50,
      this.menuItem_51,
      this.menuItem_52,
      this.menuItem_53,
      this.menuItem_54,
      this.menuItem_55,
      this.menuItem_56,
      this.menuItem_61
        });
        this.menuItem_22.Popup += new EventHandler(this.menuItem_22_Popup);

        // Open Video(&O)...
        componentResourceManager.ApplyResources((object)this.menuItem_8, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6膸", 3));
        LogData.LogInfo($"menuItem8 : {menuItem_8.Text}");
        this.menuItem_8.Index = 0;
        this.menuItem_8.Click += new EventHandler(this.menuItem_8_Click);

        // Open swf(&S)   
        componentResourceManager.ApplyResources((object)this.menuItem_96, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6袸论躼", 3));
        LogData.LogInfo($"menuItem96 : {menuItem_96.Text}");
        this.menuItem_96.Index = 1;
        this.menuItem_96.Click += new EventHandler(this.menuItem_96_Click);

        // Open tol(&T)...       
        componentResourceManager.ApplyResources((object)this.menuItem_92, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6肸芺", 3));
        LogData.LogInfo($"menuItem92 : {menuItem_92.Text}");
        this.menuItem_92.Index = 2;
        this.menuItem_92.Click += new EventHandler(this.menuItem_92_Click);

        // Close Video/Default Effect/tol(&C)
        componentResourceManager.ApplyResources((object)this.menuItem_9, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6袸袺", 3));
        LogData.LogInfo($"menuItem9 : {menuItem_9.Text}");
        this.menuItem_9.Index = 3;
        this.menuItem_9.Click += new EventHandler(this.menuItem_9_Click);
 
        
        componentResourceManager.ApplyResources((object)this.menuItem_103, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6袸誺貼", 3));
        LogData.LogInfo($"menuItem103 : {menuItem_103.Text}");
        this.menuItem_103.Index = 4;

        // Speed +  F6
        componentResourceManager.ApplyResources((object)this.menuItem_70, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6膸论", 3));
        LogData.LogInfo($"menuItem70 : {menuItem_70.Text}");
        this.menuItem_70.Index = 5;
        this.menuItem_70.Click += new EventHandler(this.menuItem_70_Click);

        // Speed -  F7
        componentResourceManager.ApplyResources((object)this.menuItem_71, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6膸誺", 3));
        LogData.LogInfo($"menuItem71 : {menuItem_71.Text}");
        this.menuItem_71.Index = 6;
        this.menuItem_71.Click += new EventHandler(this.menuItem_71_Click);

        // -
        componentResourceManager.ApplyResources((object)this.menuItem_66, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6袸趺", 3));
        LogData.LogInfo($"menuItem66 : {menuItem_66.Text}");
        this.menuItem_66.Index = 7;

        // White Gray
        componentResourceManager.ApplyResources((object)this.menuItem_42, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6貸覺", 3));
        LogData.LogInfo($"menuItem42 : {menuItem_42.Text}");
        this.menuItem_42.Index = 8;
        this.menuItem_42.Click += new EventHandler(this.menuItem_42_Click);

        // Red Gray
        componentResourceManager.ApplyResources((object)this.menuItem_43, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6貸袺", 3));
        LogData.LogInfo($"menuItem43 : {menuItem_43.Text}");
        this.menuItem_43.Index = 9;
        this.menuItem_43.Click += new EventHandler(this.menuItem_43_Click);

        // Green Gray
        componentResourceManager.ApplyResources((object)this.menuItem_44, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6貸辺", 3));
        LogData.LogInfo($"menuItem44 : {menuItem_44.Text}");
        this.menuItem_44.Index = 10;
        this.menuItem_44.Click += new EventHandler(this.menuItem_44_Click);

        // Blue Gray
        componentResourceManager.ApplyResources((object)this.menuItem_45, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6貸躺", 3));
        LogData.LogInfo($"menuItem45 : {menuItem_45.Text}");
        this.menuItem_45.Index = 11;
        this.menuItem_45.Click += new EventHandler(this.menuItem_45_Click);
 
        componentResourceManager.ApplyResources((object)this.menuItem_46, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6貸趺", 3));
        LogData.LogInfo($"menuItem46 : {menuItem_46.Text}");
        this.menuItem_46.Index = 12;
        this.menuItem_46.Click += new EventHandler(this.menuItem_46_Click);

        // -
        componentResourceManager.ApplyResources((object)this.menuItem_69, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6躸芺", 3));
        LogData.LogInfo($"menuItem69 : {menuItem_69.Text}");
        this.menuItem_69.Index = 13;

        // Color change
        componentResourceManager.ApplyResources((object)this.menuItem_88, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6肸躺", 3));
        LogData.LogInfo($"menuItem88 : {menuItem_88.Text}");
        this.menuItem_88.Index = 14;
        this.menuItem_88.Click += new EventHandler(this.menuItem_88_Click);

        // Color gradient
        componentResourceManager.ApplyResources((object)this.menuItem_89, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6肸趺", 3));
        LogData.LogInfo($"menuItem89 : {menuItem_89.Text}");
        this.menuItem_89.Index = 15;
        this.menuItem_89.Click += new EventHandler(this.menuItem_89_Click);

        // Passage
        componentResourceManager.ApplyResources((object)this.menuItem_90, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6肸貺", 3));
        LogData.LogInfo($"menuItem90 : {menuItem_90.Text}");
        this.menuItem_90.Index = 16;
        this.menuItem_90.Click += new EventHandler(this.menuItem_90_Click);
        componentResourceManager.ApplyResources((object)this.menuItem_60, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6躸辺", 3));

        // -
        LogData.LogInfo($"menuItem60 : {menuItem_60.Text}");
        this.menuItem_60.Index = 17;

        // Move upward
        componentResourceManager.ApplyResources((object)this.menuItem_47, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6貸貺", 3));
        LogData.LogInfo($"menuItem47 : {menuItem_47.Text}");
        this.menuItem_47.Index = 18;
        this.menuItem_47.Click += new EventHandler(this.menuItem_47_Click);

        // Move down
        componentResourceManager.ApplyResources((object)this.menuItem_48, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6貸莺", 3));
        LogData.LogInfo($"menuItem48 : {menuItem_48.Text}");
        this.menuItem_48.Index = 19;
        this.menuItem_48.Click += new EventHandler(this.menuItem_48_Click);

        // Move left
        componentResourceManager.ApplyResources((object)this.menuItem_49, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6貸芺", 3));
        LogData.LogInfo($"menuItem49 : {menuItem_49.Text}");
        this.menuItem_49.Index = 20;
        this.menuItem_49.Click += new EventHandler(this.menuItem_49_Click);

        // Move right
        componentResourceManager.ApplyResources((object)this.menuItem_50, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6辸论", 3));
        LogData.LogInfo($"menuItem50 : {menuItem_50.Text}");
        this.menuItem_50.Index = 21;
        this.menuItem_50.Click += new EventHandler(this.menuItem_50_Click);

        // Elliptic diffusion
        componentResourceManager.ApplyResources((object)this.menuItem_51, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6辸誺", 3));
        LogData.LogInfo($"menuItem51 : {menuItem_51.Text}");
        this.menuItem_51.Index = 22;
        this.menuItem_51.Click += new EventHandler(this.menuItem_51_Click);

        // Elliptic contraction
        componentResourceManager.ApplyResources((object)this.menuItem_52, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6辸覺", 3));
        LogData.LogInfo($"menuItem52 : {menuItem_52.Text}");
        this.menuItem_52.Index = 23;
        this.menuItem_52.Click += new EventHandler(this.menuItem_52_Click);

        // Rectangular diffusion
        componentResourceManager.ApplyResources((object)this.menuItem_53, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6辸袺", 3));
        LogData.LogInfo($"menuItem_53 : {menuItem_53.Text}");
        this.menuItem_53.Index = 24;
        this.menuItem_53.Click += new EventHandler(this.menuItem_53_Click);

        // Rectangular contraction
        componentResourceManager.ApplyResources((object)this.menuItem_54, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6辸辺", 3));
        LogData.LogInfo($"menuItem_64 : {menuItem_54.Text}");
        this.menuItem_54.Index = 25;
        this.menuItem_54.Click += new EventHandler(this.menuItem_54_Click);

        // Double angel close
        componentResourceManager.ApplyResources((object)this.menuItem_55, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6辸躺", 3));
        LogData.LogInfo($"menuItem54 : {menuItem_55.Text}");
        this.menuItem_55.Index = 26;
        this.menuItem_55.Click += new EventHandler(this.menuItem_55_Click);

        // Double angel open
        componentResourceManager.ApplyResources((object)this.menuItem_56, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6辸趺", 3));
        LogData.LogInfo($"menuItem56 : {menuItem_56.Text}");
        this.menuItem_56.Index = 27;
        this.menuItem_56.Click += new EventHandler(this.menuItem_56_Click);

        // More Effect...
        componentResourceManager.ApplyResources((object)this.menuItem_61, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6躸袺", 3));
        LogData.LogInfo($"menuItem61 : {menuItem_61.Text}");
        this.menuItem_61.Index = 28;
        this.menuItem_61.Click += new EventHandler(this.menuItem_61_Click);
        #endregion

        #region Main menu 4
        // Main Menu - menu 4
        // Screen Shot(&S)
        componentResourceManager.ApplyResources((object)this.menuItem_23, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6誸袺", 3));
        LogData.LogInfo($"menuItem23 : {menuItem_23.Text}");
        this.menuItem_23.Index = 3;
        this.menuItem_23.MenuItems.AddRange(new MenuItem[5]
        {
      this.menuItem_1,
      this.menuItem_7,
      this.menuItem_80,
      this.menuItem_81,
      this.menuItem_82
        });
        this.menuItem_23.Popup += new EventHandler(this.menuItem_23_Popup);

        //  Open(&O)...
        componentResourceManager.ApplyResources((object)this.menuItem_1, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6肸", 3));
        LogData.LogInfo($"menuItem_1 : {menuItem_1.Text}");
        this.menuItem_1.Index = 0;
        this.menuItem_1.Click += new EventHandler(this.menuItem_1_Click);

        // Close(&C)
        componentResourceManager.ApplyResources((object)this.menuItem_7, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6躸", 3));
        LogData.LogInfo($"menuItem_7 : {menuItem_7.Text}");
        this.menuItem_7.Index = 1;
        this.menuItem_7.Click += new EventHandler(this.menuItem_7_Click);

        // Set Screen...(&S)
        componentResourceManager.ApplyResources((object)this.menuItem_80, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6膸貺", 3));
        LogData.LogInfo($"menuItem_80 : {menuItem_80.Text}");
        this.menuItem_80.Index = 2;
        this.menuItem_80.Click += new EventHandler(this.menuItem_80_Click);

        // Transparent(&T)
        componentResourceManager.ApplyResources((object)this.menuItem_81, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6膸莺", 3));
        LogData.LogInfo($"menuItem_81 : {menuItem_81.Text}");
        this.menuItem_81.Index = 3;
        this.menuItem_81.Click += new EventHandler(this.menuItem_81_Click);

        // Opaque(&N)
        componentResourceManager.ApplyResources((object)this.menuItem_82, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6膸芺", 3));
        LogData.LogInfo($"menuItem_82 : {menuItem_82.Text}");
        this.menuItem_82.Index = 4;
        this.menuItem_82.Click += new EventHandler(this.menuItem_82_Click);
        #endregion

        #region Main menu 5
        // Main Menu - menu 5
        // Text Input(&T)
        componentResourceManager.ApplyResources((object)this.menuItem_104, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6袸貺", 3));
        LogData.LogInfo($"menuItem_104 : {menuItem_104.Text}");
        this.menuItem_104.Index = 4;
        this.menuItem_104.MenuItems.AddRange(new MenuItem[2]
        {
      this.menuItem_105,
      this.menuItem_106
        });
        this.menuItem_104.Popup += new EventHandler(this.menuItem_104_Popup);

        // Open Text Panel(&T)
        componentResourceManager.ApplyResources((object)this.menuItem_105, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6躸躺", 3));
        LogData.LogInfo($"menuItem_105 : {menuItem_105.Text}");
        this.menuItem_105.Index = 0;
        this.menuItem_105.Click += new EventHandler(this.menuItem_105_Click);

        // Close Text Panel(&M)
        componentResourceManager.ApplyResources((object)this.menuItem_106, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6躸趺", 3));
        LogData.LogInfo($"menuItem_106 : {menuItem_106.Text}");
        this.menuItem_106.Index = 1;
        this.menuItem_106.Click += new EventHandler(this.menuItem_106_Click);
        #endregion

        #region Main menu 6
        // Main Menu - menu 6
        //  Record(&R)
        componentResourceManager.ApplyResources((object)this.menuItem_2, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6貸", 3));
        LogData.LogInfo($"menuItem_2 : {menuItem_2.Text}");
        this.menuItem_2.Index = 5;
        this.menuItem_2.MenuItems.AddRange(new MenuItem[7]
        {
      this.menuItem_10,
      this.menuItem_20,
      this.menuItem_3,
      this.menuItem_113,
      this.menuItem_21,
      this.menuItem_94,
      this.menuItem_67
        });

        //  null(&N)
        componentResourceManager.ApplyResources((object)this.menuItem_10, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6袸莺", 3));
        LogData.LogInfo($"menuItem_10 : {menuItem_10.Text}");
        this.menuItem_10.Index = 0;
        this.menuItem_10.Click += new EventHandler(this.menuItem_10_Click);

        // Record(&A)
        componentResourceManager.ApplyResources((object)this.menuItem_20, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6许辺", 3));
        LogData.LogInfo($"menuItem_20 : {menuItem_20.Text}");
        this.menuItem_20.Index = 1;
        this.menuItem_20.Click += new EventHandler(this.menuItem_20_Click);

        // Stop(&S)
        componentResourceManager.ApplyResources((object)this.menuItem_3, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6袸论", 3));
        LogData.LogInfo($"menuItem_3 : {menuItem_3.Text}");
        this.menuItem_3.Index = 2;
        this.menuItem_3.Click += new EventHandler(this.menuItem_3_Click);

        // null (&D)
        componentResourceManager.ApplyResources((object)this.menuItem_113, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6许躺", 3));
        LogData.LogInfo($"menuItem_113 : {menuItem_113.Text}");
        this.menuItem_113.Index = 3;
        this.menuItem_113.Click += new EventHandler(this.menuItem_113_Click);

        // Recording current swf/tol(&C)
        componentResourceManager.ApplyResources((object)this.menuItem_21, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6誸论", 3));
        LogData.LogInfo($"menuItem_21 : {menuItem_21.Text}");
        this.menuItem_21.Index = 4;
        this.menuItem_21.Click += new EventHandler(this.menuItem_21_Click);

        // Fast recording.swf/.tol(&K)
        componentResourceManager.ApplyResources((object)this.menuItem_94, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6袸论貼", 3));
        LogData.LogInfo($"menuItem_94 : {menuItem_94.Text}");
        this.menuItem_94.Index = 5;
        this.menuItem_94.Click += new EventHandler(this.menuItem_94_Click);

        // Clear(&E)
        componentResourceManager.ApplyResources((object)this.menuItem_67, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6貸誺", 3));
        LogData.LogInfo($"menuItem_67 : {menuItem_67.Text}");
        this.menuItem_67.Index = 6;
        this.menuItem_67.Click += new EventHandler(this.menuItem_67_Click);
        #endregion

        #region Main menu 7
        // Main Menu - menu 7
        // Edit/Preview(&P)
        componentResourceManager.ApplyResources((object)this.menuItem_4, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6袸誺", 3));
        LogData.LogInfo($"menuItem_4 : {menuItem_4.Text}");
        this.menuItem_4.Index = 6;
        this.menuItem_4.MenuItems.AddRange(new MenuItem[15]
        {
      this.menuItem_5,
      this.menuItem_6,
      this.menuItem_25,
      this.menuItem_28,
      this.menuItem_26,
      this.menuItem_27,
      this.menuItem_31,
      this.menuItem_68,
      this.menuItem_108,
      this.menuItem_107,
      this.menuItem_98,
      this.menuItem_99,
      this.menuItem_100,
      this.menuItem_101,
      this.menuItem_102
        });

        // Edit/Preview(&S)
        componentResourceManager.ApplyResources((object)this.menuItem_5, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6袸躺", 3));
        LogData.LogInfo($"menuItem_5 : {menuItem_5.Text}");
        this.menuItem_5.Index = 0;
        this.menuItem_5.Click += new EventHandler(this.menuItem_5_Click);

        // Exit&T)
        componentResourceManager.ApplyResources((object)this.menuItem_6, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6袸覺", 3));
        LogData.LogInfo($"menuItem_6 : {menuItem_6.Text}");
        this.menuItem_6.Index = 1;
        this.menuItem_6.Click += new EventHandler(this.menuItem_6_Click);

        // Pause(&P)
        componentResourceManager.ApplyResources((object)this.menuItem_25, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6许貺", 3));
        LogData.LogInfo($"menuItem_25 : {menuItem_25.Text}");
        this.menuItem_25.Index = 2;
        this.menuItem_25.Click += new EventHandler(this.menuItem_25_Click);

        // Play(&G)
        componentResourceManager.ApplyResources((object)this.menuItem_28, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6誸趺", 3));
        LogData.LogInfo($"menuItem_28 : {menuItem_28.Text}");
        this.menuItem_28.Index = 3;
        this.menuItem_28.Click += new EventHandler(this.menuItem_28_Click);

        // Previous(&L)
        componentResourceManager.ApplyResources((object)this.menuItem_26, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6誸辺", 3));
        LogData.LogInfo($"menuItem_26 : {menuItem_26.Text}");
        this.menuItem_26.Index = 4;
        this.menuItem_26.Click += new EventHandler(this.menuItem_26_Click);

        // Next(&N)
        componentResourceManager.ApplyResources((object)this.menuItem_27, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6誸躺", 3));
        LogData.LogInfo($"menuItem_27 : {menuItem_27.Text}");
        this.menuItem_27.Index = 5;
        this.menuItem_27.Click += new EventHandler(this.menuItem_27_Click);

        // Save(&S)
        componentResourceManager.ApplyResources((object)this.menuItem_31, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6趸誺", 3));
        LogData.LogInfo($"menuItem_31 : {menuItem_31.Text}");
        this.menuItem_31.Index = 6;
        this.menuItem_31.Click += new EventHandler(this.menuItem_31_Click);

        // Clear(&E)
        componentResourceManager.ApplyResources((object)this.menuItem_68, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6躸莺", 3));
        LogData.LogInfo($"menuItem_68 : {menuItem_68.Text}");
        this.menuItem_68.Index = 7;
        this.menuItem_68.Click += new EventHandler(this.menuItem_68_Click);

        // Text input(&T)
        componentResourceManager.ApplyResources((object)this.menuItem_108, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6躸貺", 3));
        LogData.LogInfo($"menuItem_108 : {menuItem_108.Text}");
        this.menuItem_108.Index = 8;

        // -
        componentResourceManager.ApplyResources((object)this.menuItem_107, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6许覺", 3));
        LogData.LogInfo($"menuItem_107 : {menuItem_107.Text}");
        this.menuItem_107.Index = 9;

        // Cut(&T)
        componentResourceManager.ApplyResources((object)this.menuItem_98, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6袸论袼", 3));
        LogData.LogInfo($"menuItem_98 : {menuItem_98.Text}");
        this.menuItem_98.Index = 10;
        this.menuItem_98.Click += new EventHandler(this.menuItem_98_Click);

        //  Copy(&C)
        componentResourceManager.ApplyResources((object)this.menuItem_99, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6袸论讼", 3));
        LogData.LogInfo($"menuItem_99 : {menuItem_99.Text}");
        this.menuItem_99.Index = 11;
        this.menuItem_99.Click += new EventHandler(this.menuItem_99_Click);

        // Paste(&P)
        componentResourceManager.ApplyResources((object)this.menuItem_100, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6袸论誼", 3));
        LogData.LogInfo($"menuItem_100 : {menuItem_100.Text}");
        this.menuItem_100.Index = 12;
        this.menuItem_100.Click += new EventHandler(this.menuItem_100_Click);

        // Delete(&D)
        componentResourceManager.ApplyResources((object)this.menuItem_101, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6袸论薼", 3));
        LogData.LogInfo($"menuItem_101 : {menuItem_101.Text}");
        this.menuItem_101.Index = 13;
        this.menuItem_101.Click += new EventHandler(this.menuItem_101_Click);

        // Undo(&U)
        componentResourceManager.ApplyResources((object)this.menuItem_102, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6袸论蒼", 3));
        LogData.LogInfo($"menuItem_102 : {menuItem_102.Text}");
        this.menuItem_102.Index = 14;
        this.menuItem_102.Click += new EventHandler(this.menuItem_102_Click);
        #endregion

        #region Main menu 8
        //  Auto Play(&L)
        componentResourceManager.ApplyResources((object)this.menuItem_32, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6趸覺", 3));
        LogData.LogInfo($"menuItem_32 : {menuItem_32.Text}");
        this.menuItem_32.Index = 7;
        this.menuItem_32.MenuItems.AddRange(new MenuItem[9]
        {
      this.menuItem_33,
      this.menuItem_34,
      this.menuItem_39,
      this.menuItem_40,
      this.menuItem_41,
      this.menuItem_58,
      this.menuItem_110,
      this.menuItem_111,
      this.menuItem_112
        });

        // Play(&P)
        componentResourceManager.ApplyResources((object)this.menuItem_33, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6誸芺", 3));
        LogData.LogInfo($"menuItem_33 : {menuItem_33.Text}");
        this.menuItem_33.Index = 0;
        this.menuItem_33.Click += new EventHandler(this.menuItem_33_Click);

        // 
        componentResourceManager.ApplyResources((object)this.menuItem_34, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6趸论", 3));
        LogData.LogInfo($"menuItem_34 : {menuItem_34.Text}");
        this.menuItem_34.Index = 1;
        this.menuItem_34.Click += new EventHandler(this.menuItem_34_Click);

        // Stop PC syn(&C)
        componentResourceManager.ApplyResources((object)this.menuItem_39, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6趸貺", 3));
        LogData.LogInfo($"menuItem_39 : {menuItem_39.Text}");
        this.menuItem_39.Index = 2;
        this.menuItem_39.Click += new EventHandler(this.menuItem_39_Click);

        // Start PC syn(&O) 
        componentResourceManager.ApplyResources((object)this.menuItem_40, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6趸莺", 3));
        LogData.LogInfo($"menuItem_40 : {menuItem_40.Text}");
        this.menuItem_40.Index = 3;
        this.menuItem_40.Click += new EventHandler(this.menuItem_40_Click);

        // Download...(&L)
        componentResourceManager.ApplyResources((object)this.menuItem_41, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6趸芺", 3));
        LogData.LogInfo($"menuItem_41 : {menuItem_41.Text}");
        this.menuItem_41.Index = 4;
        this.menuItem_41.Click += new EventHandler(this.menuItem_41_Click);

        // Reset Controller(&A)
        componentResourceManager.ApplyResources((object)this.menuItem_58, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6辸芺", 3));
        LogData.LogInfo($"menuItem_58 : {menuItem_58.Text}");
        this.menuItem_58.Index = 5;
        this.menuItem_58.Click += new EventHandler(this.menuItem_58_Click);

        // DMX addressing(&D)
        componentResourceManager.ApplyResources((object)this.menuItem_110, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6袸誺込", 3));
        LogData.LogInfo($"menuItem_110 : {menuItem_110.Text}");
        this.menuItem_110.Index = 6;
        this.menuItem_110.Click += new EventHandler(this.menuItem_110_Click);

        // Disable the offline player(&I)
        componentResourceManager.ApplyResources((object)this.menuItem_111, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6袸誺躼", 3));
        LogData.LogInfo($"menuItem_111 : {menuItem_111.Text}");
        this.menuItem_111.Index = 7;
        this.menuItem_111.Click += new EventHandler(this.menuItem_111_Click);

        // Enable the offline player(&E)
        componentResourceManager.ApplyResources((object)this.menuItem_112, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6袸誺覼", 3));
        LogData.LogInfo($"menuItem_112 : {menuItem_112.Text}");
        this.menuItem_112.Index = 8;
        this.menuItem_112.Click += new EventHandler(this.menuItem_112_Click);
        #endregion

#region Main menu 9

        // Realtime Play(&T)
        componentResourceManager.ApplyResources((object)this.menuItem_35, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6趸袺", 3));
        LogData.LogInfo($"menuItem_35 : {menuItem_35.Text}");
        this.menuItem_35.Index = 8;
        this.menuItem_35.MenuItems.AddRange(new MenuItem[3]
        {
      this.menuItem_36,
      this.menuItem_62,
      this.menuItem_37
        });

        //Play(&R)
        componentResourceManager.ApplyResources((object)this.menuItem_36, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6趸辺", 3));
        LogData.LogInfo($"menuItem_36 : {menuItem_36.Text}");
        this.menuItem_36.Index = 0;
        this.menuItem_36.Click += new EventHandler(this.menuItem_36_Click);

        // Screen Realtime Play(&S)
        componentResourceManager.ApplyResources((object)this.menuItem_62, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6貸论", 3));
        LogData.LogInfo($"menuItem_62 : {menuItem_62.Text}");
        this.menuItem_62.Index = 1;
        this.menuItem_62.Click += new EventHandler(this.menuItem_62_Click);

        // Stop(&S)
        componentResourceManager.ApplyResources((object)this.menuItem_37, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6趸躺", 3));
        LogData.LogInfo($"menuItem_37 : {menuItem_37.Text}");
        this.menuItem_37.Index = 2;
        this.menuItem_37.Click += new EventHandler(this.menuItem_37_Click);
        #endregion

        #region Export Menu
        // Export(&O)
        componentResourceManager.ApplyResources((object)this.menuItem_16, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6许趺", 3));
        LogData.LogInfo($"menuItem_16 : {menuItem_16.Text}");
        this.menuItem_16.Index = 9;
        this.menuItem_16.MenuItems.AddRange(new MenuItem[7]
        {
      this.menuItem_59,
      this.menuItem_17,
      this.menuItem_86,
      this.menuItem_64,
      this.menuItem_79,
      this.menuItem_91,
      this.menuItem_95
        });

        // Export Effect(.led)...(&E)
        componentResourceManager.ApplyResources((object)this.menuItem_59, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6躸论", 3));
        LogData.LogInfo($"menuItem_59 : {menuItem_59.Text}");
        this.menuItem_59.Index = 0;
        this.menuItem_59.Click += new EventHandler(this.menuItem_59_Click);

        // Export Instruction(&S)...
        componentResourceManager.ApplyResources((object)this.menuItem_17, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6许芺", 3));
        LogData.LogInfo($"menuItem_17 : {menuItem_17.Text}");
        this.menuItem_17.Index = 1;
        this.menuItem_17.Click += new EventHandler(this.menuItem_17_Click);

        // Export Preview SWF...(&F)
        componentResourceManager.ApplyResources((object)this.menuItem_86, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6肸袺", 3));
        LogData.LogInfo($"menuItem_86 : {menuItem_86.Text}");
        this.menuItem_86.Index = 2;
        this.menuItem_86.Click += new EventHandler(this.menuItem_86_Click);

        // Export Preview AVI...(&G)
        componentResourceManager.ApplyResources((object)this.menuItem_64, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6袸", 3));
        LogData.LogInfo($"menuItem_64 : {menuItem_64.Text}");
        this.menuItem_64.Index = 3;
        this.menuItem_64.Click += new EventHandler(this.menuItem_64_Click);

        // Export LayOut File(&DXF)
        componentResourceManager.ApplyResources((object)this.menuItem_79, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6膸趺", 3));
        LogData.LogInfo($"menuItem_79 : {menuItem_79.Text}");
        this.menuItem_79.Index = 4;
        this.menuItem_79.Click += new EventHandler(this.menuItem_79_Click);

        //  Export Reference BMP(&T)
        componentResourceManager.ApplyResources((object)this.menuItem_91, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6肸莺", 3));
        LogData.LogInfo($"menuItem_91 : {menuItem_91.Text}");
        this.menuItem_91.Index = 5;
        this.menuItem_91.Click += new EventHandler(this.menuItem_91_Click);

        // Export Offline player file(.BIN)...(&B)
        componentResourceManager.ApplyResources((object)this.menuItem_95, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6袸论込", 3));
        LogData.LogInfo($"menuItem_95 : {menuItem_95.Text}");
        this.menuItem_95.Index = 6;
        this.menuItem_95.Click += new EventHandler(this.menuItem_95_Click);
        #endregion

        #region Help Menu
        //  Help(&H)
        componentResourceManager.ApplyResources((object)this.menuItem_24, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6辸", 3));
        LogData.LogInfo($"menuItem_24 : {menuItem_24.Text}");
        this.menuItem_24.Index = 10;
        this.menuItem_24.MenuItems.AddRange(new MenuItem[2]
        {
      this.menuItem_65,
      this.menuItem_18
        });

        // Help(&E)...
        componentResourceManager.ApplyResources((object)this.menuItem_65, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6躸覺", 3));
        LogData.LogInfo($"menuItem_65 : {menuItem_65.Text}");
        this.menuItem_65.Index = 0;
        this.menuItem_65.Click += new EventHandler(this.menuItem_65_Click);

        // About(&A)...
        componentResourceManager.ApplyResources((object)this.menuItem_18, Module.a("쒨캪쎬\uDAAE\uF8B0잲킴\uDAB6许莺", 3));
        LogData.LogInfo($"menuItem_18 : {menuItem_18.Text}");
        this.menuItem_18.Index = 1;
        this.menuItem_18.Click += new EventHandler(this.menuItem_18_Click);
        #endregion

        componentResourceManager.ApplyResources((object)this.saveFileDialog_0, Module.a("\uDAA8쪪\uDBAC쪮\uF7B0\uDAB2\uD9B4튶ﶸ튺\uDCBC펾껀꓂\uF4C4", 3));
        LogData.LogInfo($"this.saveFileDialog_0 : {Module.a("\uDAA8쪪\uDBAC쪮\uF7B0\uDAB2\uD9B4튶ﶸ튺\uDCBC펾껀꓂\uF4C4", 3)}");
        this.panel_0.AccessibleDescription = (string)null;
        this.panel_0.AccessibleName = (string)null;

 
        componentResourceManager.ApplyResources((object)this.panel_0, Module.a("\uD9A8쪪쎬쪮\uDDB0芲", 3));
        LogData.LogInfo($"panel_0 : {Module.a("\uD9A8쪪쎬쪮\uDDB0芲", 3)}");
        this.panel_0.BackgroundImage = (Image)null;
        this.panel_0.Font = (Font)null;

        LogData.LogInfo($"panel_0.Name : {Module.a("\uD9A8쪪쎬쪮\uDDB0芲", 3)}");
        this.panel_0.Name = Module.a("\uD9A8쪪쎬쪮\uDDB0芲", 3);
        this.panel_0.Paint += new PaintEventHandler(this.panel_0_Paint);
        this.panel_0.MouseDown += new MouseEventHandler(this.panel_0_MouseDown);
        this.panel_1.AccessibleDescription = (string)null;
        this.panel_1.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.panel_1, Module.a("\uD9A8쪪쎬쪮\uDDB0膲", 3));
        this.panel_1.BackColor = SystemColors.ControlText;
        this.panel_1.BackgroundImage = (Image)null;
        this.panel_1.Controls.Add((Control)this.panel_3);
        this.panel_1.Controls.Add((Control)this.panel_2);
        this.panel_1.Controls.Add((Control)this.progressBar_0);
        this.panel_1.Controls.Add((Control)this.panel_0);
        this.panel_1.Font = (Font)null;
        this.panel_1.Name = Module.a("\uD9A8쪪쎬쪮\uDDB0膲", 3);
        this.panel_3.AccessibleDescription = (string)null;
        this.panel_3.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.panel_3, Module.a("\uD9A8쪪쎬쪮\uDDB0蚲", 3));
        this.panel_3.BackgroundImage = (Image)null;
        this.panel_3.Controls.Add((Control)this.label_11);
        this.panel_3.Font = (Font)null;
        this.panel_3.Name = Module.a("\uD9A8쪪쎬쪮\uDDB0蚲", 3);
        this.label_11.AccessibleDescription = (string)null;
        this.label_11.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_11, Module.a("얨쪪쾬쪮\uDDB0芲螴", 3));
        this.label_11.ForeColor = SystemColors.ActiveCaptionText;
        this.label_11.Name = Module.a("얨쪪쾬쪮\uDDB0芲螴", 3);
        this.panel_2.AccessibleDescription = (string)null;
        this.panel_2.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.panel_2, Module.a("\uD9A8쪪쎬쪮\uDDB0螲", 3));
        this.panel_2.BackColor = SystemColors.Control;
        this.panel_2.BackgroundImage = (Image)null;
        this.panel_2.Controls.Add((Control)this.button_0);
        this.panel_2.Controls.Add((Control)this.groupBox_1);
        this.panel_2.Controls.Add((Control)this.groupBox_0);
        this.panel_2.Font = (Font)null;
        this.panel_2.Name = Module.a("\uD9A8쪪쎬쪮\uDDB0螲", 3);
        this.button_0.AccessibleDescription = (string)null;
        this.button_0.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.button_0, Module.a("쮨\uDEAA\uD9AC\uDBAE\uDEB0\uDDB2蒴", 3));
        this.button_0.BackgroundImage = (Image)null;
        this.button_0.Font = (Font)null;
        this.button_0.Name = Module.a("쮨\uDEAA\uD9AC\uDBAE\uDEB0\uDDB2蒴", 3);
        this.button_0.UseVisualStyleBackColor = true;
        this.button_0.Click += new EventHandler(this.button_0_Click);
        this.groupBox_1.AccessibleDescription = (string)null;
        this.groupBox_1.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.groupBox_1, Module.a("캨\uD9AA슬\uDAAE솰\uF1B2\uDAB4쾶许", 3));
        this.groupBox_1.BackgroundImage = (Image)null;
        this.groupBox_1.Controls.Add((Control)this.label_10);
        this.groupBox_1.Controls.Add((Control)this.textBox_3);
        this.groupBox_1.Controls.Add((Control)this.label_9);
        this.groupBox_1.Controls.Add((Control)this.label_7);
        this.groupBox_1.Controls.Add((Control)this.label_8);
        this.groupBox_1.Controls.Add((Control)this.textBox_1);
        this.groupBox_1.Controls.Add((Control)this.label_5);
        this.groupBox_1.Controls.Add((Control)this.textBox_2);
        this.groupBox_1.Controls.Add((Control)this.label_6);
        this.groupBox_1.Font = (Font)null;
        this.groupBox_1.Name = Module.a("캨\uD9AA슬\uDAAE솰\uF1B2\uDAB4쾶许", 3);
        this.groupBox_1.TabStop = false;
        this.label_10.AccessibleDescription = (string)null;
        this.label_10.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_10, Module.a("얨쪪쾬쪮\uDDB0芲蒴", 3));
        this.label_10.Font = (Font)null;
        this.label_10.Name = Module.a("얨쪪쾬쪮\uDDB0芲蒴", 3);
        this.textBox_3.AccessibleDescription = (string)null;
        this.textBox_3.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.textBox_3, Module.a("\uDDA8캪햬\uDBAE\uF3B0\uDCB2춴莶", 3));
        this.textBox_3.BackgroundImage = (Image)null;
        this.textBox_3.Font = (Font)null;
        this.textBox_3.Name = Module.a("\uDDA8캪햬\uDBAE\uF3B0\uDCB2춴莶", 3);
        this.textBox_3.ReadOnly = true;
        this.label_9.AccessibleDescription = (string)null;
        this.label_9.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_9, Module.a("얨쪪쾬쪮\uDDB0芲薴", 3));
        this.label_9.Font = (Font)null;
        this.label_9.Name = Module.a("얨쪪쾬쪮\uDDB0芲薴", 3);
        this.label_7.AccessibleDescription = (string)null;
        this.label_7.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_7, Module.a("얨쪪쾬쪮\uDDB0課", 3));
        this.label_7.Font = (Font)null;
        this.label_7.Name = Module.a("얨쪪쾬쪮\uDDB0課", 3);
        this.label_8.AccessibleDescription = (string)null;
        this.label_8.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_8, Module.a("얨쪪쾬쪮\uDDB0讲", 3));
        this.label_8.Font = (Font)null;
        this.label_8.Name = Module.a("얨쪪쾬쪮\uDDB0讲", 3);
        this.textBox_1.AccessibleDescription = (string)null;
        this.textBox_1.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.textBox_1, Module.a("\uDDA8캪햬\uDBAE\uF3B0\uDCB2춴蒶", 3));
        this.textBox_1.BackgroundImage = (Image)null;
        this.textBox_1.Font = (Font)null;
        this.textBox_1.Name = Module.a("\uDDA8캪햬\uDBAE\uF3B0\uDCB2춴蒶", 3);
        this.textBox_1.ReadOnly = true;
        this.label_5.AccessibleDescription = (string)null;
        this.label_5.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_5, Module.a("얨쪪쾬쪮\uDDB0蒲", 3));
        this.label_5.Font = (Font)null;
        this.label_5.Name = Module.a("얨쪪쾬쪮\uDDB0蒲", 3);
        this.textBox_2.AccessibleDescription = (string)null;
        this.textBox_2.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.textBox_2, Module.a("\uDDA8캪햬\uDBAE\uF3B0\uDCB2춴薶", 3));
        this.textBox_2.BackgroundImage = (Image)null;
        this.textBox_2.Font = (Font)null;
        this.textBox_2.Name = Module.a("\uDDA8캪햬\uDBAE\uF3B0\uDCB2춴薶", 3);
        this.textBox_2.ReadOnly = true;
        this.label_6.AccessibleDescription = (string)null;
        this.label_6.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_6, Module.a("얨쪪쾬쪮\uDDB0薲", 3));
        this.label_6.Font = (Font)null;
        this.label_6.Name = Module.a("얨쪪쾬쪮\uDDB0薲", 3);
        this.groupBox_0.AccessibleDescription = (string)null;
        this.groupBox_0.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.groupBox_0, Module.a("캨\uD9AA슬\uDAAE솰\uF1B2\uDAB4쾶袸", 3));
        this.groupBox_0.BackgroundImage = (Image)null;
        this.groupBox_0.Controls.Add((Control)this.label_1);
        this.groupBox_0.Controls.Add((Control)this.label_2);
        this.groupBox_0.Controls.Add((Control)this.label_0);
        this.groupBox_0.Controls.Add((Control)this.label_3);
        this.groupBox_0.Controls.Add((Control)this.label_4);
        this.groupBox_0.Font = (Font)null;
        this.groupBox_0.Name = Module.a("캨\uD9AA슬\uDAAE솰\uF1B2\uDAB4쾶袸", 3);
        this.groupBox_0.TabStop = false;
        this.label_1.AccessibleDescription = (string)null;
        this.label_1.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_1, Module.a("얨쪪쾬쪮\uDDB0芲", 3));
        this.label_1.Font = (Font)null;
        this.label_1.Name = Module.a("얨쪪쾬쪮\uDDB0芲", 3);
        this.label_2.AccessibleDescription = (string)null;
        this.label_2.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_2, Module.a("얨쪪쾬쪮\uDDB0蚲", 3));
        this.label_2.Font = (Font)null;
        this.label_2.Name = Module.a("얨쪪쾬쪮\uDDB0蚲", 3);
        this.label_0.AccessibleDescription = (string)null;
        this.label_0.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_0, Module.a("얨쪪쾬쪮\uDDB0膲", 3));
        this.label_0.Font = (Font)null;
        this.label_0.Name = Module.a("얨쪪쾬쪮\uDDB0膲", 3);
        this.label_3.AccessibleDescription = (string)null;
        this.label_3.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_3, Module.a("얨쪪쾬쪮\uDDB0螲", 3));
        this.label_3.Font = (Font)null;
        this.label_3.Name = Module.a("얨쪪쾬쪮\uDDB0螲", 3);
        this.label_4.AccessibleDescription = (string)null;
        this.label_4.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_4, Module.a("얨쪪쾬쪮\uDDB0育", 3));
        this.label_4.Font = (Font)null;
        this.label_4.Name = Module.a("얨쪪쾬쪮\uDDB0育", 3);
        this.progressBar_0.AccessibleDescription = (string)null;
        this.progressBar_0.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.progressBar_0, Module.a("\uD9A8\uD9AA슬좮쎰횲운쒶﮸\uDABA쾼躾", 3));
        this.progressBar_0.BackColor = SystemColors.ControlLightLight;
        this.progressBar_0.BackgroundImage = (Image)null;
        this.progressBar_0.Cursor = Cursors.WaitCursor;
        this.progressBar_0.Font = (Font)null;
        this.progressBar_0.ForeColor = SystemColors.ActiveCaption;
        this.progressBar_0.Name = Module.a("\uD9A8\uD9AA슬좮쎰횲운쒶﮸\uDABA쾼躾", 3);
        this.progressBar_0.Step = 1;
        this.toolStrip_0.AccessibleDescription = (string)null;
        this.toolStrip_0.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStrip_0, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸誺", 3));
        this.toolStrip_0.BackgroundImage = (Image)null;
        this.toolStrip_0.Font = (Font)null;
        this.toolStrip_0.Items.AddRange(new ToolStripItem[25]
        {
      (ToolStripItem) this.toolStripButton_5,
      (ToolStripItem) this.toolStripButton_0,
      (ToolStripItem) this.toolStripButton_7,
      (ToolStripItem) this.toolStripButton_8,
      (ToolStripItem) this.toolStripSeparator_4,
      (ToolStripItem) this.toolStripButton_25,
      (ToolStripItem) this.toolStripButton_9,
      (ToolStripItem) this.toolStripSeparator_1,
      (ToolStripItem) this.toolStripButton_1,
      (ToolStripItem) this.toolStripButton_2,
      (ToolStripItem) this.toolStripSeparator_2,
      (ToolStripItem) this.toolStripButton_10,
      (ToolStripItem) this.toolStripButton_11,
      (ToolStripItem) this.toolStripSeparator_5,
      (ToolStripItem) this.toolStripButton_3,
      (ToolStripItem) this.toolStripButton_4,
      (ToolStripItem) this.toolStripSeparator_0,
      (ToolStripItem) this.toolStripButton_6,
      (ToolStripItem) this.toolStripSeparator_3,
      (ToolStripItem) this.toolStripButton_22,
      (ToolStripItem) this.toolStripButton_23,
      (ToolStripItem) this.toolStripLabel_3,
      (ToolStripItem) this.toolStripTextBox_2,
      (ToolStripItem) this.toolStripButton_24,
      (ToolStripItem) this.toolStripButton_26
        });
        this.toolStrip_0.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸誺", 3);
        this.toolStrip_0.RenderMode = ToolStripRenderMode.System;
        this.toolStripButton_5.AccessibleDescription = (string)null;
        this.toolStripButton_5.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripButton_5, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄﻆ", 3));
        this.toolStripButton_5.BackgroundImage = (Image)null;
        this.toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_5.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄﻆ", 3);
        this.toolStripButton_5.Click += new EventHandler(this.toolStripButton_5_Click);
        this.toolStripButton_0.AccessibleDescription = (string)null;
        this.toolStripButton_0.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripButton_0, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF6C6", 3));
        this.toolStripButton_0.BackgroundImage = (Image)null;
        this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_0.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF6C6", 3);
        this.toolStripButton_0.Click += new EventHandler(this.toolStripButton_0_Click);
        this.toolStripButton_7.AccessibleDescription = (string)null;
        this.toolStripButton_7.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripButton_7, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF6C6\uFBC8", 3));
        this.toolStripButton_7.BackgroundImage = (Image)null;
        this.toolStripButton_7.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_7.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF6C6\uFBC8", 3);
        this.toolStripButton_7.Click += new EventHandler(this.toolStripButton_7_Click);
        this.toolStripButton_8.AccessibleDescription = (string)null;
        this.toolStripButton_8.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripButton_8, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF6C6\uFDC8", 3));
        this.toolStripButton_8.BackgroundImage = (Image)null;
        this.toolStripButton_8.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_8.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF6C6\uFDC8", 3);
        this.toolStripButton_8.Click += new EventHandler(this.toolStripButton_8_Click);
        this.toolStripSeparator_4.AccessibleDescription = (string)null;
        this.toolStripSeparator_4.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripSeparator_4, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸\uE8BA\uD8BC쾾ꃀ뇂꓄돆ꛈ맊ﳌ\uF7CE", 3));
        this.toolStripSeparator_4.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸\uE8BA\uD8BC쾾ꃀ뇂꓄돆ꛈ맊ﳌ\uF7CE", 3);
        this.toolStripButton_25.AccessibleDescription = (string)null;
        this.toolStripButton_25.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripButton_25, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF6C6杻", 3));
        this.toolStripButton_25.BackgroundImage = (Image)null;
        this.toolStripButton_25.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_25.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF6C6杻", 3);
        this.toolStripButton_25.Click += new EventHandler(this.toolStripButton_25_Click);
        this.toolStripButton_9.AccessibleDescription = (string)null;
        this.toolStripButton_9.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripButton_9, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF6C6ﳈ", 3));
        this.toolStripButton_9.BackgroundImage = (Image)null;
        this.toolStripButton_9.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_9.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF6C6ﳈ", 3);
        this.toolStripButton_9.Click += new EventHandler(this.toolStripButton_9_Click);
        this.toolStripSeparator_1.AccessibleDescription = (string)null;
        this.toolStripSeparator_1.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripSeparator_1, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸\uE8BA\uD8BC쾾ꃀ뇂꓄돆ꛈ맊ￌ", 3));
        this.toolStripSeparator_1.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸\uE8BA\uD8BC쾾ꃀ뇂꓄돆ꛈ맊ￌ", 3);
        this.toolStripButton_1.AccessibleDescription = (string)null;
        this.toolStripButton_1.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripButton_1, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF5C6", 3));
        this.toolStripButton_1.BackgroundImage = (Image)null;
        this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_1.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF5C6", 3);
        this.toolStripButton_1.Click += new EventHandler(this.toolStripButton_1_Click);
        this.toolStripButton_2.AccessibleDescription = (string)null;
        this.toolStripButton_2.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripButton_2, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF4C6", 3));
        this.toolStripButton_2.BackgroundImage = (Image)null;
        this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_2.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF4C6", 3);
        this.toolStripButton_2.Click += new EventHandler(this.toolStripButton_2_Click);
        this.toolStripSeparator_2.AccessibleDescription = (string)null;
        this.toolStripSeparator_2.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripSeparator_2, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸\uE8BA\uD8BC쾾ꃀ뇂꓄돆ꛈ맊ﻌ", 3));
        this.toolStripSeparator_2.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸\uE8BA\uD8BC쾾ꃀ뇂꓄돆ꛈ맊ﻌ", 3);
        this.toolStripButton_10.AccessibleDescription = (string)null;
        this.toolStripButton_10.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripButton_10, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF6C6\uF1C8", 3));
        this.toolStripButton_10.BackgroundImage = (Image)null;
        this.toolStripButton_10.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_10.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF6C6\uF1C8", 3);
        this.toolStripButton_10.Click += new EventHandler(this.toolStripButton_10_Click);
        this.toolStripButton_11.AccessibleDescription = (string)null;
        this.toolStripButton_11.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripButton_11, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF6C6\uF0C8", 3));
        this.toolStripButton_11.BackgroundImage = (Image)null;
        this.toolStripButton_11.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_11.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF6C6\uF0C8", 3);
        this.toolStripButton_11.Click += new EventHandler(this.toolStripButton_11_Click);
        this.toolStripSeparator_5.AccessibleDescription = (string)null;
        this.toolStripSeparator_5.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripSeparator_5, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸\uE8BA\uD8BC쾾ꃀ뇂꓄돆ꛈ맊ﳌ\uF6CE", 3));
        this.toolStripSeparator_5.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸\uE8BA\uD8BC쾾ꃀ뇂꓄돆ꛈ맊ﳌ\uF6CE", 3);
        this.toolStripButton_3.AccessibleDescription = (string)null;
        this.toolStripButton_3.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripButton_3, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF1C6", 3));
        this.toolStripButton_3.BackgroundImage = (Image)null;
        this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_3.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF1C6", 3);
        this.toolStripButton_3.Click += new EventHandler(this.toolStripButton_3_Click);
        this.toolStripButton_4.AccessibleDescription = (string)null;
        this.toolStripButton_4.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripButton_4, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF0C6", 3));
        this.toolStripButton_4.BackgroundImage = (Image)null;
        this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_4.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF0C6", 3);
        this.toolStripButton_4.Click += new EventHandler(this.toolStripButton_4_Click);
        this.toolStripSeparator_0.AccessibleDescription = (string)null;
        this.toolStripSeparator_0.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripSeparator_0, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸\uE8BA\uD8BC쾾ꃀ뇂꓄돆ꛈ맊ﳌ", 3));
        this.toolStripSeparator_0.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸\uE8BA\uD8BC쾾ꃀ뇂꓄돆ꛈ맊ﳌ", 3);
        this.toolStripButton_6.AccessibleDescription = (string)null;
        this.toolStripButton_6.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripButton_6, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF6C6\uF8C8", 3));
        this.toolStripButton_6.BackgroundImage = (Image)null;
        this.toolStripButton_6.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_6.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF6C6\uF8C8", 3);
        this.toolStripButton_6.Click += new EventHandler(this.toolStripButton_6_Click);
        this.toolStripSeparator_3.AccessibleDescription = (string)null;
        this.toolStripSeparator_3.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripSeparator_3, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸\uE8BA\uD8BC쾾ꃀ뇂꓄돆ꛈ맊琉", 3));
        this.toolStripSeparator_3.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸\uE8BA\uD8BC쾾ꃀ뇂꓄돆ꛈ맊琉", 3);
        this.toolStripButton_22.AccessibleDescription = (string)null;
        this.toolStripButton_22.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripButton_22, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF5C6\uF0C8", 3));
        this.toolStripButton_22.BackgroundImage = (Image)null;
        this.toolStripButton_22.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_22.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF5C6\uF0C8", 3);
        this.toolStripButton_22.Click += new EventHandler(this.toolStripButton_22_Click);
        this.toolStripButton_23.AccessibleDescription = (string)null;
        this.toolStripButton_23.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripButton_23, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF4C6杻", 3));
        this.toolStripButton_23.BackgroundImage = (Image)null;
        this.toolStripButton_23.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_23.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF4C6杻", 3);
        this.toolStripButton_23.Click += new EventHandler(this.toolStripButton_23_Click);
        this.toolStripLabel_3.AccessibleDescription = (string)null;
        this.toolStripLabel_3.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripLabel_3, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸\uF7BA\uDCBC\uDDBE꓀꿂\uF4C4", 3));
        this.toolStripLabel_3.BackgroundImage = (Image)null;
        this.toolStripLabel_3.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸\uF7BA\uDCBC\uDDBE꓀꿂\uF4C4", 3);
        this.toolStripTextBox_2.AccessibleDescription = (string)null;
        this.toolStripTextBox_2.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripTextBox_2, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸\uEFBA\uD8BC잾뗀臂\uAAC4뿆\uF1C8", 3));
        this.toolStripTextBox_2.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸\uEFBA\uD8BC잾뗀臂\uAAC4뿆\uF1C8", 3);
        this.toolStripTextBox_2.ReadOnly = true;
        this.toolStripButton_24.AccessibleDescription = (string)null;
        this.toolStripButton_24.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripButton_24, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF2C6", 3));
        this.toolStripButton_24.BackgroundImage = (Image)null;
        this.toolStripButton_24.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_24.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF2C6", 3);
        this.toolStripButton_24.Click += new EventHandler(this.toolStripButton_24_Click);
        this.toolStripButton_26.AccessibleDescription = (string)null;
        this.toolStripButton_26.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripButton_26, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF6C6\uFFC8", 3));
        this.toolStripButton_26.BackgroundImage = (Image)null;
        this.toolStripButton_26.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_26.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF6C6\uFFC8", 3);
        this.toolStripButton_26.Click += new EventHandler(this.toolStripButton_26_Click);
        this.trackBar_0.AccessibleDescription = (string)null;
        this.trackBar_0.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.trackBar_0, Module.a("\uDDA8\uD9AA첬첮\uDAB0\uF1B2풴얶袸", 3));
        this.trackBar_0.BackColor = SystemColors.Control;
        this.trackBar_0.BackgroundImage = (Image)null;
        this.trackBar_0.Cursor = Cursors.Hand;
        this.trackBar_0.Font = (Font)null;
        this.trackBar_0.Maximum = 50;
        this.trackBar_0.Name = Module.a("\uDDA8\uD9AA첬첮\uDAB0\uF1B2풴얶袸", 3);
        this.trackBar_0.Value = 34;
        this.trackBar_0.Scroll += new EventHandler(this.trackBar_0_Scroll);
        this.trackBar_0.MouseDown += new MouseEventHandler(this.trackBar_0_MouseDown);
        this.toolStrip_1.AccessibleDescription = (string)null;
        this.toolStrip_1.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStrip_1, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸覺", 3));
        this.toolStrip_1.BackgroundImage = (Image)null;
        this.toolStrip_1.Font = (Font)null;
        this.toolStrip_1.Items.AddRange(new ToolStripItem[22]
        {
      (ToolStripItem) this.toolStripTextBox_3,
      (ToolStripItem) this.toolStripSeparator_6,
      (ToolStripItem) this.toolStripButton_12,
      (ToolStripItem) this.toolStripButton_13,
      (ToolStripItem) this.toolStripButton_15,
      (ToolStripItem) this.toolStripButton_18,
      (ToolStripItem) this.toolStripButton_16,
      (ToolStripItem) this.toolStripButton_17,
      (ToolStripItem) this.toolStripSeparator_7,
      (ToolStripItem) this.toolStripButton_14,
      (ToolStripItem) this.toolStripSeparator_8,
      (ToolStripItem) this.toolStripButton_19,
      (ToolStripItem) this.toolStripButton_20,
      (ToolStripItem) this.toolStripSeparator_10,
      (ToolStripItem) this.toolStripLabel_1,
      (ToolStripItem) this.toolStripTextBox_1,
      (ToolStripItem) this.toolStripLabel_2,
      (ToolStripItem) this.toolStripSeparator_11,
      (ToolStripItem) this.toolStripButton_21,
      (ToolStripItem) this.toolStripSeparator_9,
      (ToolStripItem) this.toolStripLabel_0,
      (ToolStripItem) this.toolStripTextBox_0
        });
        this.toolStrip_1.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸覺", 3);
        this.toolStrip_1.RenderMode = ToolStripRenderMode.System;
        this.toolStrip_1.Stretch = true;
        this.toolStripTextBox_3.AccessibleDescription = (string)null;
        this.toolStripTextBox_3.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripTextBox_3, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸\uEFBA\uD8BC잾뗀臂\uAAC4뿆靖", 3));
        this.toolStripTextBox_3.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸\uEFBA\uD8BC잾뗀臂\uAAC4뿆靖", 3);
        this.toolStripTextBox_3.ReadOnly = true;
        this.toolStripSeparator_6.AccessibleDescription = (string)null;
        this.toolStripSeparator_6.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripSeparator_6, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸\uE8BA\uD8BC쾾ꃀ뇂꓄돆ꛈ맊\uFBCC", 3));
        this.toolStripSeparator_6.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸\uE8BA\uD8BC쾾ꃀ뇂꓄돆ꛈ맊\uFBCC", 3);
        this.toolStripButton_12.AccessibleDescription = (string)null;
        this.toolStripButton_12.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripButton_12, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF5C6\uFBC8", 3));
        this.toolStripButton_12.BackgroundImage = (Image)null;
        this.toolStripButton_12.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_12.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF5C6\uFBC8", 3);
        this.toolStripButton_12.Click += new EventHandler(this.toolStripButton_12_Click);
        this.toolStripButton_13.AccessibleDescription = (string)null;
        this.toolStripButton_13.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripButton_13, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF5C6\uFDC8", 3));
        this.toolStripButton_13.BackgroundImage = (Image)null;
        this.toolStripButton_13.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_13.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF5C6\uFDC8", 3);
        this.toolStripButton_13.Click += new EventHandler(this.toolStripButton_13_Click);
        this.toolStripButton_15.AccessibleDescription = (string)null;
        this.toolStripButton_15.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripButton_15, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄￆ", 3));
        this.toolStripButton_15.BackgroundImage = (Image)null;
        this.toolStripButton_15.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_15.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄￆ", 3);
        this.toolStripButton_15.Click += new EventHandler(this.toolStripButton_15_Click);
        this.toolStripButton_18.AccessibleDescription = (string)null;
        this.toolStripButton_18.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripButton_18, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF5C6ﳈ", 3));
        this.toolStripButton_18.BackgroundImage = (Image)null;
        this.toolStripButton_18.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_18.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF5C6ﳈ", 3);
        this.toolStripButton_18.Click += new EventHandler(this.toolStripButton_18_Click);
        this.toolStripButton_16.AccessibleDescription = (string)null;
        this.toolStripButton_16.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripButton_16, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF6C6靖", 3));
        this.toolStripButton_16.BackgroundImage = (Image)null;
        this.toolStripButton_16.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_16.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF6C6靖", 3);
        this.toolStripButton_16.Click += new EventHandler(this.toolStripButton_16_Click);
        this.toolStripButton_17.AccessibleDescription = (string)null;
        this.toolStripButton_17.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripButton_17, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF3C6", 3));
        this.toolStripButton_17.BackgroundImage = (Image)null;
        this.toolStripButton_17.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_17.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF3C6", 3);
        this.toolStripButton_17.Click += new EventHandler(this.toolStripButton_17_Click);
        this.toolStripSeparator_7.AccessibleDescription = (string)null;
        this.toolStripSeparator_7.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripSeparator_7, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸\uE8BA\uD8BC쾾ꃀ뇂꓄돆ꛈ맊\uF5CC", 3));
        this.toolStripSeparator_7.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸\uE8BA\uD8BC쾾ꃀ뇂꓄돆ꛈ맊\uF5CC", 3);
        this.toolStripButton_14.AccessibleDescription = (string)null;
        this.toolStripButton_14.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripButton_14, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF5C6靖", 3));
        this.toolStripButton_14.BackgroundImage = (Image)null;
        this.toolStripButton_14.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_14.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF5C6靖", 3);
        this.toolStripButton_14.Click += new EventHandler(this.toolStripButton_14_Click);
        this.toolStripSeparator_8.AccessibleDescription = (string)null;
        this.toolStripSeparator_8.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripSeparator_8, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸\uE8BA\uD8BC쾾ꃀ뇂꓄돆ꛈ맊頻", 3));
        this.toolStripSeparator_8.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸\uE8BA\uD8BC쾾ꃀ뇂꓄돆ꛈ맊頻", 3);
        this.toolStripButton_19.AccessibleDescription = (string)null;
        this.toolStripButton_19.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripButton_19, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF5C6\uFFC8", 3));
        this.toolStripButton_19.BackgroundImage = (Image)null;
        this.toolStripButton_19.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_19.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF5C6\uFFC8", 3);
        this.toolStripButton_19.Click += new EventHandler(this.toolStripButton_19_Click);
        this.toolStripButton_20.AccessibleDescription = (string)null;
        this.toolStripButton_20.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripButton_20, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF5C6ﻈ", 3));
        this.toolStripButton_20.BackgroundImage = (Image)null;
        this.toolStripButton_20.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_20.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF5C6ﻈ", 3);
        this.toolStripButton_20.Click += new EventHandler(this.toolStripButton_20_Click);
        this.toolStripSeparator_10.AccessibleDescription = (string)null;
        this.toolStripSeparator_10.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripSeparator_10, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸\uE8BA\uD8BC쾾ꃀ뇂꓄돆ꛈ맊ﳌￎ", 3));
        this.toolStripSeparator_10.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸\uE8BA\uD8BC쾾ꃀ뇂꓄돆ꛈ맊ﳌￎ", 3);
        this.toolStripLabel_1.AccessibleDescription = (string)null;
        this.toolStripLabel_1.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripLabel_1, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸\uF7BA\uDCBC\uDDBE꓀꿂\uF1C4", 3));
        this.toolStripLabel_1.BackgroundImage = (Image)null;
        this.toolStripLabel_1.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸\uF7BA\uDCBC\uDDBE꓀꿂\uF1C4", 3);
        this.toolStripTextBox_1.AccessibleDescription = (string)null;
        this.toolStripTextBox_1.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripTextBox_1, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸\uEFBA\uD8BC잾뗀臂\uAAC4뿆ﳈ", 3));
        this.toolStripTextBox_1.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸\uEFBA\uD8BC잾뗀臂\uAAC4뿆ﳈ", 3);
        this.toolStripTextBox_1.ReadOnly = true;
        this.toolStripLabel_2.AccessibleDescription = (string)null;
        this.toolStripLabel_2.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripLabel_2, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸\uF7BA\uDCBC\uDDBE꓀꿂\uF2C4", 3));
        this.toolStripLabel_2.BackgroundImage = (Image)null;
        this.toolStripLabel_2.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸\uF7BA\uDCBC\uDDBE꓀꿂\uF2C4", 3);
        this.toolStripSeparator_11.AccessibleDescription = (string)null;
        this.toolStripSeparator_11.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripSeparator_11, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸\uE8BA\uD8BC쾾ꃀ뇂꓄돆ꛈ맊\uF4CC", 3));
        this.toolStripSeparator_11.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸\uE8BA\uD8BC쾾ꃀ뇂꓄돆ꛈ맊\uF4CC", 3);
        this.toolStripButton_21.AccessibleDescription = (string)null;
        this.toolStripButton_21.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripButton_21, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF5C6\uF1C8", 3));
        this.toolStripButton_21.BackgroundImage = (Image)null;
        this.toolStripButton_21.DisplayStyle = ToolStripItemDisplayStyle.Image;
        this.toolStripButton_21.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸了좼쮾뗀곂ꯄ\uF5C6\uF1C8", 3);
        this.toolStripButton_21.Click += new EventHandler(this.toolStripButton_21_Click);
        this.toolStripSeparator_9.AccessibleDescription = (string)null;
        this.toolStripSeparator_9.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripSeparator_9, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸\uE8BA\uD8BC쾾ꃀ뇂꓄돆ꛈ맊\uF8CC", 3));
        this.toolStripSeparator_9.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸\uE8BA\uD8BC쾾ꃀ뇂꓄돆ꛈ맊\uF8CC", 3);
        this.toolStripLabel_0.AccessibleDescription = (string)null;
        this.toolStripLabel_0.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripLabel_0, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸\uF7BA\uDCBC\uDDBE꓀꿂\uF4C4\uF7C6", 3));
        this.toolStripLabel_0.BackgroundImage = (Image)null;
        this.toolStripLabel_0.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸\uF7BA\uDCBC\uDDBE꓀꿂\uF4C4\uF7C6", 3);
        this.toolStripTextBox_0.AccessibleDescription = (string)null;
        this.toolStripTextBox_0.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripTextBox_0, Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸\uEFBA\uD8BC잾뗀臂\uAAC4뿆\uFBC8", 3));
        this.toolStripTextBox_0.BackColor = SystemColors.Control;
        this.toolStripTextBox_0.Name = Module.a("\uDDA8쒪슬쎮\uE2B0잲잴\uDEB6즸\uEFBA\uD8BC잾뗀臂\uAAC4뿆\uFBC8", 3);
        this.toolStripTextBox_0.ReadOnly = true;
        this.textBox_0.AccessibleDescription = (string)null;
        this.textBox_0.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.textBox_0, Module.a("\uDDA8캪햬\uDBAE\uF3B0\uDCB2춴蚶", 3));
        this.textBox_0.BackColor = Color.PaleGoldenrod;
        this.textBox_0.BackgroundImage = (Image)null;
        this.textBox_0.ContextMenuStrip = this.contextMenuStrip_0;
        this.textBox_0.Cursor = Cursors.Default;
        this.textBox_0.Font = (Font)null;
        this.textBox_0.ForeColor = Color.FromArgb(128, 64, 0);
        this.textBox_0.Name = Module.a("\uDDA8캪햬\uDBAE\uF3B0\uDCB2춴蚶", 3);
        this.textBox_0.ReadOnly = true;
        this.textBox_0.ShortcutsEnabled = false;
        this.textBox_0.TabStop = false;
        this.textBox_0.MouseMove += new MouseEventHandler(this.textBox_0_MouseMove);
        this.textBox_0.KeyDown += new KeyEventHandler(this.textBox_0_KeyDown);
        this.textBox_0.MouseDown += new MouseEventHandler(this.textBox_0_MouseDown);
        this.textBox_0.MouseUp += new MouseEventHandler(this.textBox_0_MouseUp);
        this.contextMenuStrip_0.AccessibleDescription = (string)null;
        this.contextMenuStrip_0.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.contextMenuStrip_0, Module.a("쪨쒪쎬\uDBAE풰쮲솴襁\uDCB8햺좼\uECBE뗀뇂계럆\uF8C8", 3));
        this.contextMenuStrip_0.BackgroundImage = (Image)null;
        this.contextMenuStrip_0.Font = (Font)null;
        this.contextMenuStrip_0.Items.AddRange(new ToolStripItem[5]
        {
      (ToolStripItem) this.toolStripMenuItem_0,
      (ToolStripItem) this.toolStripMenuItem_1,
      (ToolStripItem) this.toolStripMenuItem_2,
      (ToolStripItem) this.toolStripMenuItem_3,
      (ToolStripItem) this.toolStripMenuItem_4
        });
        this.contextMenuStrip_0.Name = Module.a("쪨쒪쎬\uDBAE풰쮲솴襁\uDCB8햺좼\uECBE뗀뇂계럆\uF8C8", 3);
        this.toolStripMenuItem_0.AccessibleDescription = (string)null;
        this.toolStripMenuItem_0.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripMenuItem_0, Module.a("쏺鼧怜삮\uDEB0\uDFB2\uE6B4쎶쮸튺춼\uF2BE꓀귂냄軆뷈껊ꃌ", 3));
        this.toolStripMenuItem_0.BackgroundImage = (Image)null;
        this.toolStripMenuItem_0.Name = Module.a("쏺鼧怜삮\uDEB0\uDFB2\uE6B4쎶쮸튺춼\uF2BE꓀귂냄軆뷈껊ꃌ", 3);
        this.toolStripMenuItem_0.ShortcutKeyDisplayString = (string)null;
        this.toolStripMenuItem_0.Click += new EventHandler(this.toolStripMenuItem_0_Click);
        this.toolStripMenuItem_1.AccessibleDescription = (string)null;
        this.toolStripMenuItem_1.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripMenuItem_1, Module.a("ꓱ鷸怜삮\uDEB0\uDFB2\uE6B4쎶쮸튺춼\uF2BE꓀귂냄軆뷈껊ꃌﻎ", 3));
        this.toolStripMenuItem_1.BackgroundImage = (Image)null;
        this.toolStripMenuItem_1.Name = Module.a("ꓱ鷸怜삮\uDEB0\uDFB2\uE6B4쎶쮸튺춼\uF2BE꓀귂냄軆뷈껊ꃌﻎ", 3);
        this.toolStripMenuItem_1.ShortcutKeyDisplayString = (string)null;
        this.toolStripMenuItem_1.Click += new EventHandler(this.toolStripMenuItem_1_Click);
        this.toolStripMenuItem_2.AccessibleDescription = (string)null;
        this.toolStripMenuItem_2.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripMenuItem_2, Module.a("㇔鼧怜삮\uDEB0\uDFB2\uE6B4쎶쮸튺춼\uF2BE꓀귂냄軆뷈껊ꃌ", 3));
        this.toolStripMenuItem_2.BackgroundImage = (Image)null;
        this.toolStripMenuItem_2.Name = Module.a("㇔鼧怜삮\uDEB0\uDFB2\uE6B4쎶쮸튺춼\uF2BE꓀귂냄軆뷈껊ꃌ", 3);
        this.toolStripMenuItem_2.ShortcutKeyDisplayString = (string)null;
        this.toolStripMenuItem_2.Click += new EventHandler(this.toolStripMenuItem_2_Click);
        this.toolStripMenuItem_3.AccessibleDescription = (string)null;
        this.toolStripMenuItem_3.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripMenuItem_3, Module.a("觺켼怜삮\uDEB0\uDFB2\uE6B4쎶쮸튺춼\uF2BE꓀귂냄軆뷈껊ꃌ", 3));
        this.toolStripMenuItem_3.BackgroundImage = (Image)null;
        this.toolStripMenuItem_3.Name = Module.a("觺켼怜삮\uDEB0\uDFB2\uE6B4쎶쮸튺춼\uF2BE꓀귂냄軆뷈껊ꃌ", 3);
        this.toolStripMenuItem_3.ShortcutKeyDisplayString = (string)null;
        this.toolStripMenuItem_3.Click += new EventHandler(this.toolStripMenuItem_3_Click);
        this.toolStripMenuItem_4.AccessibleDescription = (string)null;
        this.toolStripMenuItem_4.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripMenuItem_4, Module.a("\u0DCCꬿ\uA7E2軅糔\uEFFD﮴\uE3B6횸풺톼\uECBE뗀뇂계럆蓈껊ꏌ뫎飐\uA7D2냔뫖", 3));
        this.toolStripMenuItem_4.BackgroundImage = (Image)null;
        this.toolStripMenuItem_4.Name = Module.a("\u0DCCꬿ\uA7E2軅糔\uEFFD﮴\uE3B6횸풺톼\uECBE뗀뇂계럆蓈껊ꏌ뫎飐\uA7D2냔뫖", 3);
        this.toolStripMenuItem_4.ShortcutKeyDisplayString = (string)null;
        this.toolStripMenuItem_4.Click += new EventHandler(this.toolStripMenuItem_4_Click);
        this.timer_0.Tick += new EventHandler(this.timer_0_Tick);
        this.timer_1.Tick += new EventHandler(this.timer_1_Tick);
        this.timer_2.Interval = 80;
        this.timer_2.Tick += new EventHandler(this.timer_2_Tick);
        this.hscrollBar_0.AccessibleDescription = (string)null;
        this.hscrollBar_0.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.hscrollBar_0, Module.a("솨\uF8AA캬\uDDAE\uDEB0\uDFB2\uD9B4\uF5B6\uD8B8즺貼", 3));
        this.hscrollBar_0.BackgroundImage = (Image)null;
        this.hscrollBar_0.Font = (Font)null;
        this.hscrollBar_0.LargeChange = 1;
        this.hscrollBar_0.Name = Module.a("솨\uF8AA캬\uDDAE\uDEB0\uDFB2\uD9B4\uF5B6\uD8B8즺貼", 3);
        this.hscrollBar_0.Scroll += new ScrollEventHandler(this.hscrollBar_0_Scroll);
        this.vscrollBar_0.AccessibleDescription = (string)null;
        this.vscrollBar_0.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.vscrollBar_0, Module.a("\uDFA8\uF8AA캬\uDDAE\uDEB0\uDFB2\uD9B4\uF5B6\uD8B8즺貼", 3));
        this.vscrollBar_0.BackgroundImage = (Image)null;
        this.vscrollBar_0.Font = (Font)null;
        this.vscrollBar_0.LargeChange = 1;
        this.vscrollBar_0.Name = Module.a("\uDFA8\uF8AA캬\uDDAE\uDEB0\uDFB2\uD9B4\uF5B6\uD8B8즺貼", 3);
        this.vscrollBar_0.Scroll += new ScrollEventHandler(this.vscrollBar_0_Scroll);
        this.timer_3.Interval = 20000;
        this.timer_3.Tick += new EventHandler(this.timer_3_Tick);
        this.contextMenuStrip_1.AccessibleDescription = (string)null;
        this.contextMenuStrip_1.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.contextMenuStrip_1, Module.a("쪨쒪쎬\uDBAE풰쮲솴襁\uDCB8햺좼\uECBE뗀뇂계럆\uFBC8", 3));
        this.contextMenuStrip_1.BackgroundImage = (Image)null;
        this.contextMenuStrip_1.Font = (Font)null;
        this.contextMenuStrip_1.Items.AddRange(new ToolStripItem[9]
        {
      (ToolStripItem) this.toolStripMenuItem_5,
      (ToolStripItem) this.toolStripMenuItem_6,
      (ToolStripItem) this.toolStripMenuItem_7,
      (ToolStripItem) this.toolStripMenuItem_8,
      (ToolStripItem) this.toolStripMenuItem_9,
      (ToolStripItem) this.toolStripMenuItem_10,
      (ToolStripItem) this.toolStripMenuItem_11,
      (ToolStripItem) this.toolStripMenuItem_12,
      (ToolStripItem) this.toolStripMenuItem_13
        });
        this.contextMenuStrip_1.Name = Module.a("쪨쒪쎬\uDBAE풰쮲솴襁\uDCB8햺좼\uECBE뗀뇂계럆\uFBC8", 3);
        this.toolStripMenuItem_5.AccessibleDescription = (string)null;
        this.toolStripMenuItem_5.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripMenuItem_5, Module.a("黺ᯏ\uEBACﮮ\uDEB0\uDCB2\uD9B4\uE4B6춸즺풼쾾賀ꛂꯄ닆胈뿊\uA8CCꋎ", 3));
        this.toolStripMenuItem_5.BackgroundImage = (Image)null;
        this.toolStripMenuItem_5.Name = Module.a("黺ᯏ\uEBACﮮ\uDEB0\uDCB2\uD9B4\uE4B6춸즺풼쾾賀ꛂꯄ닆胈뿊\uA8CCꋎ", 3);
        this.toolStripMenuItem_5.ShortcutKeyDisplayString = (string)null;
        this.toolStripMenuItem_5.Click += new EventHandler(this.toolStripMenuItem_5_Click);
        this.toolStripMenuItem_6.AccessibleDescription = (string)null;
        this.toolStripMenuItem_6.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripMenuItem_6, Module.a("軶㨲怜삮\uDEB0\uDFB2\uE6B4쎶쮸튺춼\uF2BE꓀귂냄軆뷈껊ꃌ", 3));
        this.toolStripMenuItem_6.BackgroundImage = (Image)null;
        this.toolStripMenuItem_6.Name = Module.a("軶㨲怜삮\uDEB0\uDFB2\uE6B4쎶쮸튺춼\uF2BE꓀귂냄軆뷈껊ꃌ", 3);
        this.toolStripMenuItem_6.ShortcutKeyDisplayString = (string)null;
        this.toolStripMenuItem_6.Click += new EventHandler(this.toolStripMenuItem_6_Click);
        this.toolStripMenuItem_7.AccessibleDescription = (string)null;
        this.toolStripMenuItem_7.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripMenuItem_7, Module.a("胗闏怜삮\uDEB0\uDFB2\uE6B4쎶쮸튺춼\uF2BE꓀귂냄軆뷈껊ꃌ", 3));
        this.toolStripMenuItem_7.BackgroundImage = (Image)null;
        this.toolStripMenuItem_7.Name = Module.a("胗闏怜삮\uDEB0\uDFB2\uE6B4쎶쮸튺춼\uF2BE꓀귂냄軆뷈껊ꃌ", 3);
        this.toolStripMenuItem_7.ShortcutKeyDisplayString = (string)null;
        this.toolStripMenuItem_7.Click += new EventHandler(this.toolStripMenuItem_7_Click);
        this.toolStripMenuItem_8.AccessibleDescription = (string)null;
        this.toolStripMenuItem_8.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripMenuItem_8, Module.a("㟳擺跑ﮮ\uDEB0\uDCB2\uD9B4\uE4B6춸즺풼쾾賀ꛂꯄ닆胈뿊\uA8CCꋎ", 3));
        this.toolStripMenuItem_8.BackgroundImage = (Image)null;
        this.toolStripMenuItem_8.Name = Module.a("㟳擺跑ﮮ\uDEB0\uDCB2\uD9B4\uE4B6춸즺풼쾾賀ꛂꯄ닆胈뿊\uA8CCꋎ", 3);
        this.toolStripMenuItem_8.ShortcutKeyDisplayString = (string)null;
        this.toolStripMenuItem_8.Click += new EventHandler(this.toolStripMenuItem_8_Click);
        this.toolStripMenuItem_9.AccessibleDescription = (string)null;
        this.toolStripMenuItem_9.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripMenuItem_9, Module.a("铧윰ጧ쇑\uF6B0\uE7B2\uDAB4\uD8B6햸\uE8BA즼춾ꣀ돂裄ꋆ\uA7C8뻊蓌믎듐뻒", 3));
        this.toolStripMenuItem_9.BackgroundImage = (Image)null;
        this.toolStripMenuItem_9.Name = Module.a("铧윰ጧ쇑\uF6B0\uE7B2\uDAB4\uD8B6햸\uE8BA즼춾ꣀ돂裄ꋆ\uA7C8뻊蓌믎듐뻒", 3);
        this.toolStripMenuItem_9.ShortcutKeyDisplayString = (string)null;
        this.toolStripMenuItem_9.Click += new EventHandler(this.toolStripMenuItem_9_Click);
        this.toolStripMenuItem_10.AccessibleDescription = (string)null;
        this.toolStripMenuItem_10.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripMenuItem_10, Module.a("ᜣ엕ￌ\uEEC3跠\uE7B2\uDAB4\uD8B6햸\uE8BA즼춾ꣀ돂裄ꋆ\uA7C8뻊蓌믎듐뻒", 3));
        this.toolStripMenuItem_10.BackgroundImage = (Image)null;
        this.toolStripMenuItem_10.Name = Module.a("ᜣ엕ￌ\uEEC3跠\uE7B2\uDAB4\uD8B6햸\uE8BA즼춾ꣀ돂裄ꋆ\uA7C8뻊蓌믎듐뻒", 3);
        this.toolStripMenuItem_10.ShortcutKeyDisplayString = (string)null;
        this.toolStripMenuItem_10.Click += new EventHandler(this.toolStripMenuItem_10_Click);
        this.toolStripMenuItem_11.AccessibleDescription = (string)null;
        this.toolStripMenuItem_11.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripMenuItem_11, Module.a("ᓍ价\uAACF\uF8FD\uE2B0\uE7B2\uDAB4\uD8B6햸\uE8BA즼춾ꣀ돂裄ꋆ\uA7C8뻊蓌믎듐뻒", 3));
        this.toolStripMenuItem_11.BackgroundImage = (Image)null;
        this.toolStripMenuItem_11.Name = Module.a("ᓍ价\uAACF\uF8FD\uE2B0\uE7B2\uDAB4\uD8B6햸\uE8BA즼춾ꣀ돂裄ꋆ\uA7C8뻊蓌믎듐뻒", 3);
        this.toolStripMenuItem_11.ShortcutKeyDisplayString = (string)null;
        this.toolStripMenuItem_11.Click += new EventHandler(this.toolStripMenuItem_11_Click);
        this.toolStripMenuItem_12.AccessibleDescription = (string)null;
        this.toolStripMenuItem_12.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripMenuItem_12, Module.a("똸෴\uF8AC\uE9AE螰\uE7B2\uDAB4\uD8B6햸\uE8BA즼춾ꣀ돂裄ꋆ\uA7C8뻊蓌믎듐뻒", 3));
        this.toolStripMenuItem_12.BackgroundImage = (Image)null;
        this.toolStripMenuItem_12.Name = Module.a("똸෴\uF8AC\uE9AE螰\uE7B2\uDAB4\uD8B6햸\uE8BA즼춾ꣀ돂裄ꋆ\uA7C8뻊蓌믎듐뻒", 3);
        this.toolStripMenuItem_12.ShortcutKeyDisplayString = (string)null;
        this.toolStripMenuItem_12.Click += new EventHandler(this.toolStripMenuItem_12_Click);
        this.toolStripMenuItem_13.AccessibleDescription = (string)null;
        this.toolStripMenuItem_13.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.toolStripMenuItem_13, Module.a("똸෴\uE9AC\uE9AE蚰\uE7B2\uDAB4\uD8B6햸\uE8BA즼춾ꣀ돂裄ꋆ\uA7C8뻊蓌믎듐뻒", 3));
        this.toolStripMenuItem_13.BackgroundImage = (Image)null;
        this.toolStripMenuItem_13.Name = Module.a("똸෴\uE9AC\uE9AE蚰\uE7B2\uDAB4\uD8B6햸\uE8BA즼춾ꣀ돂裄ꋆ\uA7C8뻊蓌믎듐뻒", 3);
        this.toolStripMenuItem_13.ShortcutKeyDisplayString = (string)null;
        this.toolStripMenuItem_13.Click += new EventHandler(this.toolStripMenuItem_13_Click);
        this.label_12.AccessibleDescription = (string)null;
        this.label_12.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_12, Module.a("얨쪪쾬쪮\uDDB0芲蚴", 3));
        this.label_12.BackColor = SystemColors.GradientActiveCaption;
        this.label_12.Font = (Font)null;
        this.label_12.Name = Module.a("얨쪪쾬쪮\uDDB0芲蚴", 3);
        this.label_13.AccessibleDescription = (string)null;
        this.label_13.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_13, Module.a("얨쪪쾬쪮\uDDB0芲膴", 3));
        this.label_13.Font = (Font)null;
        this.label_13.Name = Module.a("얨쪪쾬쪮\uDDB0芲膴", 3);
        this.tabControl_0.AccessibleDescription = (string)null;
        this.tabControl_0.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.tabControl_0, Module.a("\uDDA8쪪쾬\uECAE\uDEB0\uDDB2솴얶횸ힺ貼", 3));
        this.tabControl_0.BackgroundImage = (Image)null;
        this.tabControl_0.Controls.Add((Control)this.tabPage_0);
        this.tabControl_0.Controls.Add((Control)this.tabPage_1);
        this.tabControl_0.Font = (Font)null;
        this.tabControl_0.Name = Module.a("\uDDA8쪪쾬\uECAE\uDEB0\uDDB2솴얶횸ힺ貼", 3);
        this.tabControl_0.SelectedIndex = 0;
        this.tabControl_0.SelectedIndexChanged += new EventHandler(this.tabControl_0_SelectedIndexChanged);
        this.tabPage_0.AccessibleDescription = (string)null;
        this.tabPage_0.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.tabPage_0, Module.a("\uDDA8쪪쾬ﾮ킰풲킴蚶", 3));
        this.tabPage_0.BackgroundImage = (Image)null;
        this.tabPage_0.Controls.Add((Control)this.textBox_4);
        this.tabPage_0.Controls.Add((Control)this.label_14);
        this.tabPage_0.Controls.Add((Control)this.button_1);
        this.tabPage_0.Controls.Add((Control)this.button_2);
        this.tabPage_0.Controls.Add((Control)this.button_3);
        this.tabPage_0.Controls.Add((Control)this.listBox_0);
        this.tabPage_0.Controls.Add((Control)this.button_4);
        this.tabPage_0.Font = (Font)null;
        this.tabPage_0.Name = Module.a("\uDDA8쪪쾬ﾮ킰풲킴蚶", 3);
        this.tabPage_0.UseVisualStyleBackColor = true;
        this.textBox_4.AccessibleDescription = (string)null;
        this.textBox_4.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.textBox_4, Module.a("\uDDA8캪햬\uDBAE\uF3B0\uDCB2춴芶", 3));
        this.textBox_4.BackgroundImage = (Image)null;
        this.textBox_4.Font = (Font)null;
        this.textBox_4.Name = Module.a("\uDDA8캪햬\uDBAE\uF3B0\uDCB2춴芶", 3);
        this.textBox_4.ReadOnly = true;
        this.label_14.AccessibleDescription = (string)null;
        this.label_14.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_14, Module.a("얨쪪쾬쪮\uDDB0芲肴", 3));
        this.label_14.Font = (Font)null;
        this.label_14.Name = Module.a("얨쪪쾬쪮\uDDB0芲肴", 3);
        this.button_1.AccessibleDescription = (string)null;
        this.button_1.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.button_1, Module.a("쮨\uDEAA\uD9AC\uDBAE\uDEB0\uDDB2芴", 3));
        this.button_1.BackgroundImage = (Image)null;
        this.button_1.Font = (Font)null;
        this.button_1.Name = Module.a("쮨\uDEAA\uD9AC\uDBAE\uDEB0\uDDB2芴", 3);
        this.button_1.UseVisualStyleBackColor = true;
        this.button_1.Click += new EventHandler(this.button_1_Click);
        this.button_2.AccessibleDescription = (string)null;
        this.button_2.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.button_2, Module.a("쮨\uDEAA\uD9AC\uDBAE\uDEB0\uDDB2莴", 3));
        this.button_2.BackgroundImage = (Image)null;
        this.button_2.Font = (Font)null;
        this.button_2.Name = Module.a("쮨\uDEAA\uD9AC\uDBAE\uDEB0\uDDB2莴", 3);
        this.button_2.UseVisualStyleBackColor = true;
        this.button_2.Click += new EventHandler(this.button_2_Click);
        this.button_3.AccessibleDescription = (string)null;
        this.button_3.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.button_3, Module.a("쮨\uDEAA\uD9AC\uDBAE\uDEB0\uDDB2蚴", 3));
        this.button_3.BackgroundImage = (Image)null;
        this.button_3.Font = (Font)null;
        this.button_3.Name = Module.a("쮨\uDEAA\uD9AC\uDBAE\uDEB0\uDDB2蚴", 3);
        this.button_3.UseVisualStyleBackColor = true;
        this.button_3.Click += new EventHandler(this.button_3_Click);
        this.listBox_0.AccessibleDescription = (string)null;
        this.listBox_0.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.listBox_0, Module.a("얨슪\uDEAC\uDBAE\uF3B0\uDCB2춴薶", 3));
        this.listBox_0.BackgroundImage = (Image)null;
        this.listBox_0.Font = (Font)null;
        this.listBox_0.FormattingEnabled = true;
        this.listBox_0.Name = Module.a("얨슪\uDEAC\uDBAE\uF3B0\uDCB2춴薶", 3);
        this.listBox_0.SelectedIndexChanged += new EventHandler(this.listBox_0_SelectedIndexChanged);
        this.listBox_0.DoubleClick += new EventHandler(this.listBox_0_DoubleClick);
        this.button_4.AccessibleDescription = (string)null;
        this.button_4.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.button_4, Module.a("쮨\uDEAA\uD9AC\uDBAE\uDEB0\uDDB2螴", 3));
        this.button_4.BackgroundImage = (Image)null;
        this.button_4.Font = (Font)null;
        this.button_4.Name = Module.a("쮨\uDEAA\uD9AC\uDBAE\uDEB0\uDDB2螴", 3);
        this.button_4.UseVisualStyleBackColor = true;
        this.button_4.Click += new EventHandler(this.button_4_Click);
        this.tabPage_1.AccessibleDescription = (string)null;
        this.tabPage_1.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.tabPage_1, Module.a("\uDDA8쪪쾬ﾮ킰풲킴薶", 3));
        this.tabPage_1.BackgroundImage = (Image)null;
        this.tabPage_1.Controls.Add((Control)this.treeView_0);
        this.tabPage_1.Controls.Add((Control)this.label_12);
        this.tabPage_1.Font = (Font)null;
        this.tabPage_1.Name = Module.a("\uDDA8쪪쾬ﾮ킰풲킴薶", 3);
        this.tabPage_1.UseVisualStyleBackColor = true;
        this.treeView_0.AccessibleDescription = (string)null;
        this.treeView_0.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.treeView_0, Module.a("\uDDA8\uD9AA좬쪮\uE7B0\uDAB2킴삶袸", 3));
        this.treeView_0.BackgroundImage = (Image)null;
        this.treeView_0.Font = (Font)null;
        this.treeView_0.Name = Module.a("\uDDA8\uD9AA좬쪮\uE7B0\uDAB2킴삶袸", 3);
        this.treeView_0.AfterSelect += new TreeViewEventHandler(this.treeView_0_AfterSelect);
        this.label_15.AccessibleDescription = (string)null;
        this.label_15.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_15, Module.a("얨쪪쾬쪮\uDDB0芲莴", 3));
        this.label_15.Font = (Font)null;
        this.label_15.Name = Module.a("얨쪪쾬쪮\uDDB0芲莴", 3);
        this.button_5.AccessibleDescription = (string)null;
        this.button_5.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.button_5, Module.a("쮨\uDEAA\uD9AC\uDBAE\uDEB0\uDDB2肴", 3));
        this.button_5.BackgroundImage = (Image)null;
        this.button_5.Font = (Font)null;
        this.button_5.Name = Module.a("쮨\uDEAA\uD9AC\uDBAE\uDEB0\uDDB2肴", 3);
        this.button_5.UseVisualStyleBackColor = true;
        this.textBox_5.AccessibleDescription = (string)null;
        this.textBox_5.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.textBox_5, Module.a("\uDDA8캪햬\uDBAE\uF3B0\uDCB2춴膶", 3));
        this.textBox_5.BackgroundImage = (Image)null;
        this.textBox_5.Font = (Font)null;
        this.textBox_5.Name = Module.a("\uDDA8캪햬\uDBAE\uF3B0\uDCB2춴膶", 3);
        this.textBox_5.ReadOnly = true;
        this.label_16.AccessibleDescription = (string)null;
        this.label_16.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.label_16, Module.a("얨쪪쾬쪮\uDDB0芲芴", 3));
        this.label_16.Font = (Font)null;
        this.label_16.Name = Module.a("얨쪪쾬쪮\uDDB0芲芴", 3);
        this.button_6.AccessibleDescription = (string)null;
        this.button_6.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.button_6, Module.a("쮨\uDEAA\uD9AC\uDBAE\uDEB0\uDDB2貴", 3));
        this.button_6.BackgroundImage = (Image)null;
        this.button_6.Font = (Font)null;
        this.button_6.Name = Module.a("쮨\uDEAA\uD9AC\uDBAE\uDEB0\uDDB2貴", 3);
        this.button_6.UseVisualStyleBackColor = true;
        this.button_7.AccessibleDescription = (string)null;
        this.button_7.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.button_7, Module.a("쮨\uDEAA\uD9AC\uDBAE\uDEB0\uDDB2蒴螶", 3));
        this.button_7.BackgroundImage = (Image)null;
        this.button_7.Font = (Font)null;
        this.button_7.Name = Module.a("쮨\uDEAA\uD9AC\uDBAE\uDEB0\uDDB2蒴螶", 3);
        this.button_7.UseVisualStyleBackColor = true;
        this.button_8.AccessibleDescription = (string)null;
        this.button_8.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.button_8, Module.a("쮨\uDEAA\uD9AC\uDBAE\uDEB0\uDDB2蒴蚶", 3));
        this.button_8.BackgroundImage = (Image)null;
        this.button_8.Font = (Font)null;
        this.button_8.Name = Module.a("쮨\uDEAA\uD9AC\uDBAE\uDEB0\uDDB2蒴蚶", 3);
        this.button_8.UseVisualStyleBackColor = true;
        this.button_9.AccessibleDescription = (string)null;
        this.button_9.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.button_9, Module.a("쮨\uDEAA\uD9AC\uDBAE\uDEB0\uDDB2蒴薶", 3));
        this.button_9.BackgroundImage = (Image)null;
        this.button_9.Font = (Font)null;
        this.button_9.Name = Module.a("쮨\uDEAA\uD9AC\uDBAE\uDEB0\uDDB2蒴薶", 3);
        this.button_9.UseVisualStyleBackColor = true;
        this.button_10.AccessibleDescription = (string)null;
        this.button_10.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.button_10, Module.a("쮨\uDEAA\uD9AC\uDBAE\uDEB0\uDDB2蒴蒶", 3));
        this.button_10.BackgroundImage = (Image)null;
        this.button_10.Font = (Font)null;
        this.button_10.Name = Module.a("쮨\uDEAA\uD9AC\uDBAE\uDEB0\uDDB2蒴蒶", 3);
        this.button_10.UseVisualStyleBackColor = true;
        this.listBox_1.AccessibleDescription = (string)null;
        this.listBox_1.AccessibleName = (string)null;
        componentResourceManager.ApplyResources((object)this.listBox_1, Module.a("얨슪\uDEAC\uDBAE\uF3B0\uDCB2춴蚶", 3));
        this.listBox_1.BackgroundImage = (Image)null;
        this.listBox_1.Font = (Font)null;
        this.listBox_1.FormattingEnabled = true;
        this.listBox_1.Name = Module.a("얨슪\uDEAC\uDBAE\uF3B0\uDCB2춴蚶", 3);
        this.AccessibleDescription = (string)null;
        this.AccessibleName = (string)null;
        this.AutoScaleMode = AutoScaleMode.None;
        componentResourceManager.ApplyResources((object)this, Module.a("趨\uDFAA얬욮슰", 3));
        this.BackColor = SystemColors.Control;
        this.BackgroundImage = (Image)null;
        this.ContextMenuStrip = this.contextMenuStrip_1;
        this.Controls.Add((Control)this.textBox_0);
        this.Controls.Add((Control)this.panel_1);
        this.Controls.Add((Control)this.trackBar_0);
        this.Controls.Add((Control)this.toolStrip_0);
        this.Controls.Add((Control)this.label_15);
        this.Controls.Add((Control)this.hscrollBar_0);
        this.Controls.Add((Control)this.tabControl_0);
        this.Controls.Add((Control)this.label_13);
        this.Controls.Add((Control)this.vscrollBar_0);
        this.Controls.Add((Control)this.toolStrip_1);
        this.Font = (Font)null;
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.Icon = (Icon)null;
        this.KeyPreview = true;
        this.Menu = this.mainMenu_0;
        this.Name = Module.a("\uEFA8쒪\uDFAC슮肰", 3);
        this.WindowState = FormWindowState.Maximized;
        this.Load += new EventHandler(this.c_Load);
        this.SizeChanged += new EventHandler(this.c_SizeChanged);
        this.FormClosing += new FormClosingEventHandler(this.c_FormClosing);
        this.KeyDown += new KeyEventHandler(this.c_KeyDown);
        this.panel_1.ResumeLayout(false);
        this.panel_3.ResumeLayout(false);
        this.panel_3.PerformLayout();
        this.panel_2.ResumeLayout(false);
        this.groupBox_1.ResumeLayout(false);
        this.groupBox_1.PerformLayout();
        this.groupBox_0.ResumeLayout(false);
        this.groupBox_0.PerformLayout();
        this.toolStrip_0.ResumeLayout(false);
        this.toolStrip_0.PerformLayout();
        this.trackBar_0.EndInit();
        this.toolStrip_1.ResumeLayout(false);
        this.toolStrip_1.PerformLayout();
        this.contextMenuStrip_0.ResumeLayout(false);
        this.contextMenuStrip_1.ResumeLayout(false);
        this.tabControl_0.ResumeLayout(false);
        this.tabPage_0.ResumeLayout(false);
        this.tabPage_0.PerformLayout();
        this.tabPage_1.ResumeLayout(false);
        this.tabPage_1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    [STAThread]
    private static void Main()
    {
        int int_0 = 1;
        if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
        {
            int num = (int)MessageBox.Show(Module.a("\uF7A6\uDBA8쒪쪬\uDDAE킰\uDEB2閴\uDEB6쪸鮺쾼쪾꿀귂계꧆껈\uEACA\uEDCC", int_0), Module.a("\uEBA6첨쾪\uE8AC쮮\uD8B0잲", int_0), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        else
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run((Form)new c());
        }
    }

    private void timer_1_Tick(object sender, EventArgs e)
    {
        if (this.int_29 != 0)
            return;
        this.int_29 = 1;
        if (this.bool_37)
        {
            if (!this.bool_50)
                this.method_16();
            else
                this.method_18();
        }
        else if (this.bool_7)
            this.method_17();
        this.int_29 = 0;
    }

    private void timer_2_Tick(object sender, EventArgs e)
    {
        int int_0 = 3;
        if (this.int_29 != 0)
            return;
        this.int_29 = 1;
        if (this.int_22 <= 0)
        {
            this.byte_35[0] = (byte)194;
            this.byte_35[1] = (byte)119;
            this.byte_35[2] = (byte)136;
            try
            {
                this.udpClient_0.Send(this.byte_35, 5, Module.a("風銪龬膮肰薲趴馶辸论鎼誾\uF1C0", int_0), 5000);
            }
            catch
            {
            }
            this.timer_2.Enabled = false;
        }
        else
        {
            this.method_61();
            --this.int_22;
        }
        this.int_29 = 0;
    }

    [DllImport("gdi32.dll")]
    private static extern bool BitBlt(
      IntPtr intptr_2,
      int int_93,
      int int_94,
      int int_95,
      int int_96,
      IntPtr intptr_3,
      int int_97,
      int int_98,
      int int_99);

    [DllImport("gdi32.dll")]
    private static extern IntPtr CreateDC(
      string string_24,
      string string_25,
      string string_26,
      IntPtr intptr_2);

    private int method_4()
    {
        int int_0 = 10;
        bool flag = false;
        int index = 0;
        this.arrayList_1.Clear();
        this.arrayList_0.Clear();
        this.arrayList_2.Clear();
        this.openFileDialog_0.Filter = Module.a("풯쪱튳麵銷钹\uD8BB욽ꚿ\uEBC1룃\uECC5\uE6C7껉듋\uA8CD곏鏑룓뫕\uF8D7鳙뗛닝藟쫡컣죥싧쏩郫쓭\uDEEF\uD8F1", 10);
        this.openFileDialog_0.Title = Module.a("ﾯ슱톳\uD8B5", 10);
        if (this.openFileDialog_0.ShowDialog() != DialogResult.OK)
            return 3;
        string fileName = this.openFileDialog_0.FileName;
        int num1 = fileName.LastIndexOf('\\');
        string string_24 = fileName.Substring(num1 + 1);
        this.method_26(2, Module.a("膯", int_0));
        this.method_26(3, string_24);
        if (fileName.Trim() == "")
        {
            if (c.useEnglishLanguage)
                this.ShowMessage(Module.a("횯\uDBB1\uD8B3펵颷풹\uDDBB펽ꖿ\uE2C1ꇃ듅뫇ꗉ뻋\uEFCD", int_0));
            else
                this.ShowMessage(Module.a("뷡퇚\uDACB㋃㿒䳷뇯뽂", int_0));
            return 1;
        }
        if (string.Compare(fileName, this.string_20 + (object)'\\' + string_24) != 0 && System.IO.File.Exists(fileName))
            System.IO.File.Copy(fileName, this.string_20 + (object)'\\' + string_24, true);
        this.progressBar_0.Enabled = true;
        this.progressBar_0.Maximum = 15;
        this.progressBar_0.Minimum = 0;
        this.progressBar_0.Visible = true;
        ++this.int_21;
        if (this.int_21 > 15)
            this.int_21 = 0;
        this.progressBar_0.Value = this.int_21;
        this.bool_10 = false;
        try
        {
            StreamReader streamReader;
            using (streamReader = new StreamReader(fileName, Encoding.ASCII))
            {
                string str1;
                string str2;
                while ((str1 = streamReader.ReadLine()) != null)
                {
                    if (str1 == Module.a("\uE4AF\uF7B1\uECB3\uE2B5", int_0))
                    {
                        do
                            ;
                        while ((str2 = streamReader.ReadLine()) != Module.a("邯莱蒳", int_0));
                        this.double_8 = Convert.ToDouble(streamReader.ReadLine());
                        this.double_4 = this.double_8;
                        str2 = streamReader.ReadLine();
                        this.double_8 = Convert.ToDouble(streamReader.ReadLine());
                        this.double_5 = this.double_8;
                        do
                            ;
                        while ((str2 = streamReader.ReadLine()) != Module.a("邯銱薳", int_0));
                        this.arrayList_2.Add((object)new GClass2(new PointF((float)this.double_4, (float)this.double_5), streamReader.ReadLine()));
                    }
                    else if (str1 == Module.a("邯銱蚳", int_0) && streamReader.ReadLine() == Module.a("\uF5AFﲱ\uE0B3ﾵ\uECB7\uF3B9僚\uEDBD", int_0))
                        break;
                }
                this.double_3 = 0.5;
                this.int_18 = (int)(this.double_3 * 2.0);
            label_52:
                while ((str2 = streamReader.ReadLine()) != null)
                {
                    string str3 = streamReader.ReadLine();
                label_33:
                    string str4;
                    if ((str4 = str3) != null)
                    {
                        if (str4 == Module.a("\uE3AF\uE2B1\uF8B3ﾵ\uF6B7ﾹ", int_0))
                        {
                        label_32:
                            do
                                ;
                            while ((str2 = streamReader.ReadLine()) != Module.a("\uF1AF톱\uF0B3풵\uEBB7쪹킻ힽ꺿\uA7C1", int_0));
                            int num2 = 0;
                            double x = double.MaxValue;
                            double y = double.MaxValue;
                            this.double_4 = 0.0;
                            this.double_5 = 0.0;
                            while (true)
                            {
                                do
                                {
                                    do
                                    {
                                        str3 = streamReader.ReadLine();
                                        if (!(str3 == Module.a("\uF1AF톱\uF0B3풵ﶷ풹좻ힽ뒿믁", int_0)) && !(str3 == Module.a("\uF5AFﲱ\uF0B3\uE5B5ﶷ惡", int_0)))
                                        {
                                            if (!(str3 == Module.a("\uE3AF\uE2B1\uF8B3ﾵ\uF6B7ﾹ", int_0)))
                                            {
                                                if (str3 == Module.a("\uE4AF\uF7B1\uECB3\uE2B5", int_0) || str3 == Module.a("\uF5AFﺱ\uF8B3ﾵ\uE8B7\uE9B9僚", int_0) || str3 == Module.a("ﶯ\uE6B1\uF1B3\uEEB5\uECB7", int_0))
                                                    goto label_33;
                                            }
                                            else
                                                goto label_32;
                                        }
                                        else
                                            goto label_52;
                                    }
                                    while (str3 != Module.a("邯莱蒳", int_0));
                                    this.double_8 = Convert.ToDouble(streamReader.ReadLine());
                                    this.double_4 = this.double_8;
                                    str2 = streamReader.ReadLine();
                                    this.double_8 = Convert.ToDouble(streamReader.ReadLine());
                                    this.double_5 = this.double_8;
                                    str2 = streamReader.ReadLine();
                                    str2 = streamReader.ReadLine();
                                    if (num2 == 0)
                                        goto label_28;
                                }
                                while (x == this.double_4 && y == this.double_5);
                                goto label_30;
                            label_28:
                                num2 = 1;
                                x = this.double_4;
                                y = this.double_5;
                                continue;
                            label_30:
                                this.arrayList_0.Add((object)new GClass7(new PointF((float)x, (float)y), new PointF((float)this.double_4, (float)this.double_5)));
                                x = this.double_4;
                                y = this.double_5;
                            }
                        }
                        else if (!(str4 == Module.a("\uF5AFﺱ\uF8B3ﾵ\uE8B7\uE9B9僚", int_0)))
                        {
                            if (!(str4 == Module.a("ﶯ\uE6B1\uF1B3\uEEB5\uECB7", int_0)))
                            {
                                if (str4 == Module.a("\uE4AF\uF7B1\uECB3\uE2B5", int_0))
                                {
                                    do
                                        ;
                                    while ((str2 = streamReader.ReadLine()) != Module.a("邯莱蒳", int_0));
                                    this.double_8 = Convert.ToDouble(streamReader.ReadLine());
                                    this.double_4 = this.double_8;
                                    str2 = streamReader.ReadLine();
                                    this.double_8 = Convert.ToDouble(streamReader.ReadLine());
                                    this.double_5 = this.double_8;
                                    do
                                        ;
                                    while ((str2 = streamReader.ReadLine()) != Module.a("邯銱薳", int_0));
                                    string string_1 = streamReader.ReadLine();
                                    if (string_1.Length == 1)
                                    {
                                        if (!(string_1 == Module.a("삯", int_0)) && !(string_1 == Module.a("\uE0AF", int_0)))
                                        {
                                            if (flag)
                                                ((GClass2)this.arrayList_2[index]).method_1(((GClass2)this.arrayList_2[index]).method_0() + string_1);
                                        }
                                        else
                                        {
                                            flag = true;
                                            index = this.arrayList_2.Count;
                                            this.arrayList_2.Add((object)new GClass2(new PointF((float)this.double_4, (float)this.double_5), string_1));
                                        }
                                    }
                                    else
                                    {
                                        flag = false;
                                        this.arrayList_2.Add((object)new GClass2(new PointF((float)this.double_4, (float)this.double_5), string_1));
                                    }
                                }
                            }
                            else
                            {
                                do
                                    ;
                                while ((str2 = streamReader.ReadLine()) != Module.a("邯莱蒳", int_0));
                                this.double_8 = Convert.ToDouble(streamReader.ReadLine());
                                this.double_4 = this.double_8;
                                str2 = streamReader.ReadLine();
                                this.double_8 = Convert.ToDouble(streamReader.ReadLine());
                                this.double_5 = this.double_8;
                                do
                                    ;
                                while ((str2 = streamReader.ReadLine()) != Module.a("邯銱薳", int_0));
                                this.arrayList_2.Add((object)new GClass2(new PointF((float)this.double_4, (float)this.double_5), streamReader.ReadLine()));
                            }
                        }
                        else
                        {
                            do
                                ;
                            while ((str2 = streamReader.ReadLine()) != Module.a("邯莱蒳", int_0));
                            this.double_8 = Convert.ToDouble(streamReader.ReadLine());
                            this.double_4 = this.double_8;
                            str2 = streamReader.ReadLine();
                            this.double_8 = Convert.ToDouble(streamReader.ReadLine());
                            this.double_5 = this.double_8;
                            str2 = streamReader.ReadLine();
                            str2 = streamReader.ReadLine();
                            str2 = streamReader.ReadLine();
                            this.double_8 = Convert.ToDouble(streamReader.ReadLine());
                            this.double_0 = this.double_8;
                            str2 = streamReader.ReadLine();
                            this.double_8 = Convert.ToDouble(streamReader.ReadLine());
                            this.double_1 = this.double_8;
                            this.bool_10 = true;
                            this.arrayList_1.Add((object)new PointF((float)this.double_4, (float)this.double_5));
                        }
                    }
                }
            }
        }
        catch
        {
            if (c.useEnglishLanguage)
                this.ShowMessage(Module.a("쒯\uDAB1톳隵\uDEB7펹킻\uDBBD\uE0BFꃁꇃ꿅ꛇ귉\uECCB믍ꏏ럑냓\uF6D5뫗ꏙﳛ뿝軟跡郣軥跧飩쳫黭苯鷱鏳蓵駷韹\uDCFB틽烿渁愃朅笇漉Ⰻ洍簏紑朓猕㠗甙栛瘝䔟倡圣إ堧堩䌫䤭䈯匱夳䔵ᐷ丹吻嬽⸿扁⭃㙅ⵇ⑉汋⡍㥏㹑ㅓ癕㥗㵙㵛㝝\u0E5F䍡", int_0));
            else
                this.ShowMessage(Module.a("㟊䓿ퟘ黢ጿ峪복铳쯅䶟뮌\uEEB0\uE4C7㵂뾚⍘ꚞ冊\uDFA9妋횃垈边\uDE82\uE120", int_0));
            this.progressBar_0.Visible = false;
            this.progressBar_0.Enabled = false;
            return 1;
        }
        if (this.bool_10)
        {
            this.double_3 = Math.Sqrt(Math.Pow(this.double_0, 2.0) + Math.Pow(this.double_1, 2.0));
            this.int_18 = (int)(this.double_3 * 2.0);
        }
        this.method_6();
        return 0;
    }

    private int method_5(int int_93, string string_24)
    {
        int int_0 = 16;
        this.arrayList_1.Clear();
        this.arrayList_0.Clear();
        this.arrayList_2.Clear();
        string str1 = (string)null;
        switch (int_93)
        {
            case 0:
                this.openFileDialog_0.Filter = Module.a("튵삷\uDCB9钻钽\uEEBFꛁ볃ꃅ\uE1C7뛉\uE6CB\uE0CD듏\uAAD1닓\uAAD5駗뛙냛ﻝꛟ诡裣菥샧샩싫쓭\uD9EF軱\uDEF3\uD8F5틷", int_0);
                this.openFileDialog_0.Title = Module.a("例좷\uDFB9튻", int_0);
                if (this.openFileDialog_0.ShowDialog() != DialogResult.OK)
                    return 3;
                str1 = this.openFileDialog_0.FileName;
                int num = str1.LastIndexOf('\\');
                string string_24_1 = str1.Substring(num + 1);
                this.method_26(2, Module.a("螵", int_0));
                this.method_26(3, string_24_1);
                if (str1.Trim() == "")
                {
                    if (c.useEnglishLanguage)
                        this.ShowMessage(Module.a("킵톷횹\uD9BB麽꺿ꏁ꧃ꏅ\uE8C7꿉뻋볍뿏ꃑ\uF5D3", int_0));
                    else
                        this.ShowMessage(Module.a("믻\uDBDC퓁㣍㧘㛱쾕씼", int_0));
                    return 1;
                }
                if (string.Compare(str1, this.string_20 + (object)'\\' + string_24_1) != 0 && System.IO.File.Exists(str1))
                {
                    System.IO.File.Copy(str1, this.string_20 + (object)'\\' + string_24_1, true);
                    break;
                }
                break;
            case 1:
                str1 = string_24;
                break;
        }
        this.progressBar_0.Enabled = true;
        this.progressBar_0.Maximum = 15;
        this.progressBar_0.Minimum = 0;
        this.progressBar_0.Visible = true;
        ++this.int_21;
        if (this.int_21 > 15)
            this.int_21 = 0;
        this.progressBar_0.Value = this.int_21;
        this.bool_10 = false;
        try
        {
            StreamReader streamReader;
            using (streamReader = new StreamReader(str1, Encoding.ASCII))
            {
                string str2;
                string str3;
                while ((str2 = streamReader.ReadLine()) != null)
                {
                    if (str2 == Module.a("\uE2B5ﶷ\uE2B9\uE8BB", int_0))
                    {
                        do
                            ;
                        while ((str3 = streamReader.ReadLine()) != Module.a("隵覷誹", int_0));
                        this.double_8 = Convert.ToDouble(streamReader.ReadLine());
                        this.double_4 = this.double_8;
                        str3 = streamReader.ReadLine();
                        this.double_8 = Convert.ToDouble(streamReader.ReadLine());
                        this.double_5 = this.double_8;
                        do
                            ;
                        while ((str3 = streamReader.ReadLine()) != Module.a("隵颷讹", int_0));
                        this.arrayList_2.Add((object)new GClass2(new PointF((float)this.double_4, (float)this.double_5), streamReader.ReadLine()));
                    }
                    else if (str2 == Module.a("隵颷袹", int_0) && streamReader.ReadLine() == Module.a("\uF3B5\uF6B7\uEEB9\uF5BB\uEABD覿蟁韃", int_0))
                        break;
                }
                while ((str3 = streamReader.ReadLine()) != null)
                {
                    string str4;
                    if ((str4 = streamReader.ReadLine()) != null)
                    {
                        if (!(str4 == Module.a("蝹\uF1B7\uF4B9僚", int_0)))
                        {
                            if (!(str4 == Module.a("\uF5B5\uF1B7\uE8B9ﾻ\uF2BD薿", int_0)))
                            {
                                if (!(str4 == Module.a("\uF3B5\uF4B7\uF6B9\uF5BB\uEEBD鎿蟁", int_0)))
                                {
                                    if (!(str4 == Module.a("﮵\uECB7ﾹ\uE4BB\uEABD", int_0)))
                                    {
                                        if (str4 == Module.a("\uE2B5ﶷ\uE2B9\uE8BB", int_0))
                                        {
                                            do
                                                ;
                                            while ((str3 = streamReader.ReadLine()) != Module.a("隵覷誹", int_0));
                                            this.double_8 = Convert.ToDouble(streamReader.ReadLine());
                                            this.double_4 = this.double_8;
                                            str3 = streamReader.ReadLine();
                                            this.double_8 = Convert.ToDouble(streamReader.ReadLine());
                                            this.double_5 = this.double_8;
                                            do
                                                ;
                                            while ((str3 = streamReader.ReadLine()) != Module.a("隵颷讹", int_0));
                                            this.arrayList_2.Add((object)new GClass2(new PointF((float)this.double_4, (float)this.double_5), streamReader.ReadLine()));
                                        }
                                    }
                                    else
                                    {
                                        do
                                            ;
                                        while ((str3 = streamReader.ReadLine()) != Module.a("隵覷誹", int_0));
                                        this.double_8 = Convert.ToDouble(streamReader.ReadLine());
                                        this.double_4 = this.double_8;
                                        str3 = streamReader.ReadLine();
                                        this.double_8 = Convert.ToDouble(streamReader.ReadLine());
                                        this.double_5 = this.double_8;
                                        do
                                            ;
                                        while ((str3 = streamReader.ReadLine()) != Module.a("隵颷讹", int_0));
                                        this.arrayList_2.Add((object)new GClass2(new PointF((float)this.double_4, (float)this.double_5), streamReader.ReadLine()));
                                    }
                                }
                                else
                                {
                                    do
                                        ;
                                    while ((str3 = streamReader.ReadLine()) != Module.a("隵覷誹", int_0));
                                    this.double_8 = Convert.ToDouble(streamReader.ReadLine());
                                    this.double_4 = this.double_8;
                                    str3 = streamReader.ReadLine();
                                    this.double_8 = Convert.ToDouble(streamReader.ReadLine());
                                    this.double_5 = this.double_8;
                                    str3 = streamReader.ReadLine();
                                    str3 = streamReader.ReadLine();
                                    str3 = streamReader.ReadLine();
                                    this.double_8 = Convert.ToDouble(streamReader.ReadLine());
                                    this.double_0 = this.double_8;
                                    str3 = streamReader.ReadLine();
                                    this.double_8 = Convert.ToDouble(streamReader.ReadLine());
                                    this.double_1 = this.double_8;
                                    this.bool_10 = true;
                                    this.arrayList_1.Add((object)new PointF((float)this.double_4, (float)this.double_5));
                                }
                            }
                            else
                            {
                                do
                                    ;
                                while ((str3 = streamReader.ReadLine()) != Module.a("隵覷誹", int_0));
                                this.double_8 = Convert.ToDouble(streamReader.ReadLine());
                                this.double_4 = this.double_8;
                                str3 = streamReader.ReadLine();
                                this.double_8 = Convert.ToDouble(streamReader.ReadLine());
                                this.double_5 = this.double_8;
                                str3 = streamReader.ReadLine();
                                str3 = streamReader.ReadLine();
                                str3 = streamReader.ReadLine();
                                this.double_8 = Convert.ToDouble(streamReader.ReadLine());
                                this.double_3 = this.double_8;
                                this.int_18 = (int)(this.double_3 * 2.0);
                                this.arrayList_1.Add((object)new PointF((float)this.double_4, (float)this.double_5));
                            }
                        }
                        else
                        {
                            do
                                ;
                            while ((str3 = streamReader.ReadLine()) != Module.a("隵覷誹", int_0));
                            this.double_8 = Convert.ToDouble(streamReader.ReadLine());
                            this.double_4 = this.double_8;
                            str3 = streamReader.ReadLine();
                            this.double_8 = Convert.ToDouble(streamReader.ReadLine());
                            this.double_5 = this.double_8;
                            str3 = streamReader.ReadLine();
                            str3 = streamReader.ReadLine();
                            str3 = streamReader.ReadLine();
                            this.double_8 = Convert.ToDouble(streamReader.ReadLine());
                            this.double_6 = this.double_8;
                            str3 = streamReader.ReadLine();
                            this.double_8 = Convert.ToDouble(streamReader.ReadLine());
                            this.double_7 = this.double_8;
                            str3 = streamReader.ReadLine();
                            str3 = streamReader.ReadLine();
                            this.arrayList_0.Add((object)new GClass7(new PointF((float)this.double_4, (float)this.double_5), new PointF((float)this.double_6, (float)this.double_7)));
                        }
                    }
                }
            }
        }
        catch
        {
            if (c.useEnglishLanguage)
                this.ShowMessage(Module.a("습킷\uDFB9鲻\uD8BDꦿ껁ꇃ\uE6C5\uAAC7꿉ꗋꃍ럏\uF2D1ꇓꗕ뷗뻙ﳛ볝駟싡藣裥蟧黩蓫语苯틱蓳蓵韷鷹軻\u9FFD淿∁⠃瘅搇漉洋納甏㈑眓稕眗椙礛㸝伟嘡䰣䌥娧天ఫ席䈯崱匳䐵夷圹伻ሽ㐿⩁⅃⡅桇╉㱋⭍㹏牑\u3253㽕㑗㽙籛㽝ݟ͡ൣ\u0865䥧", int_0));
            else
                this.ShowMessage(Module.a("㇐仹\uD9D2铬ᔵ⛬슏\uEE8D춿䞙떆\uE4BE\uE2CD❄ꆀ㥆ꂄ完톣厅킉涎놃\uE4BC\uE71A", int_0));
            this.progressBar_0.Visible = false;
            this.progressBar_0.Enabled = false;
            return 1;
        }
        if (this.bool_10)
        {
            this.double_3 = Math.Sqrt(Math.Pow(this.double_0, 2.0) + Math.Pow(this.double_1, 2.0));
            this.int_18 = (int)(this.double_3 * 2.0);
        }
        this.method_7();
        return 0;
    }

    private int method_6()
    {
        int int_0 = 5;
        if (this.double_3 < 0.5)
        {
            if (c.useEnglishLanguage)
                this.ShowMessage(Module.a("\uDFAA얬쪮醰ힲ\uDCB4횶풸\uDEBA즼\uDABE돀\uE3C2\uAAC4ꇆ\uE9C8뿊ꗌ\uAACE\uF1D0냒볔ꗖ뫘럚룜\uFFDE裠跢엤짦跨鏪诬쿮韰髲駴鋶\uD9F8鋺軼\uDFFE㴀⌂㐄⤆㤈✊紌挎琐爒昔爖㤘砚甜縞传䐢䀤ܦ䀨弪ബ丮䈰ጲ\u0B34ਸ਼࠸ᔺ\u0D3CἾ慀捂", int_0));
            else
                this.ShowMessage(Module.a("薪즬\uD7AEힰ㓗䏺髸뿯㿌䧊㯡캜䶌\uF4C4\uE9C6杻\uE7CA㩇\uE799郐ꛒꇔ룖高髚駜\uF290\uE7BC閳\u0BAB\uDE83펦ꊑ探歷횩綼쓴\uD9F6째洞", int_0));
            this.progressBar_0.Visible = false;
            this.progressBar_0.Enabled = false;
            return 1;
        }
        this.double_4 = 3.4028234663852886E+38;
        this.double_5 = 3.4028234663852886E+38;
        this.double_6 = -3.4028234663852886E+38;
        this.double_7 = -3.4028234663852886E+38;
        foreach (PointF pointF in this.arrayList_1)
        {
            if ((double)pointF.X < this.double_4)
                this.double_4 = (double)pointF.X;
            if ((double)pointF.Y < this.double_5)
                this.double_5 = (double)pointF.Y;
            if ((double)pointF.X > this.double_6)
                this.double_6 = (double)pointF.X;
            if ((double)pointF.Y > this.double_7)
                this.double_7 = (double)pointF.Y;
        }
        PointF[] pointFArray1 = new PointF[this.arrayList_1.Count];
        int count1 = this.arrayList_1.Count;
        for (int index = 0; index < this.arrayList_1.Count; ++index)
        {
            float x = ((PointF)this.arrayList_1[index]).X;
            float y = ((PointF)this.arrayList_1[index]).Y;
            pointFArray1[index].X = x;
            pointFArray1[index].Y = (float)this.double_5 - y;
        }
        this.arrayList_1.Clear();
        for (int index = 0; index < count1; ++index)
            this.arrayList_1.Add((object)pointFArray1[index]);
        int count2 = this.arrayList_0.Count;
        PointF[] pointFArray2 = new PointF[count2];
        PointF[] pointFArray3 = new PointF[count2];
        for (int index = 0; index < count2; ++index)
        {
            pointFArray2[index].X = ((GClass7)this.arrayList_0[index]).method_0().X;
            pointFArray2[index].Y = (float)this.double_5 - ((GClass7)this.arrayList_0[index]).method_0().Y;
            pointFArray3[index].X = ((GClass7)this.arrayList_0[index]).method_2().X;
            pointFArray3[index].Y = (float)this.double_5 - ((GClass7)this.arrayList_0[index]).method_2().Y;
        }
        this.arrayList_0.Clear();
        for (int index = 0; index < count2; ++index)
            this.arrayList_0.Add((object)new GClass7(pointFArray2[index], pointFArray3[index]));
        int count3 = this.arrayList_2.Count;
        PointF[] pointFArray4 = new PointF[count3];
        string[] strArray1 = new string[count3];
        for (int index = 0; index < count3; ++index)
        {
            pointFArray4[index].X = ((GClass2)this.arrayList_2[index]).method_2().X;
            pointFArray4[index].Y = (float)this.double_5 - ((GClass2)this.arrayList_2[index]).method_2().Y;
            strArray1[index] = ((GClass2)this.arrayList_2[index]).method_0();
        }
        this.arrayList_2.Clear();
        for (int index = 0; index < count3; ++index)
            this.arrayList_2.Add((object)new GClass2(pointFArray4[index], strArray1[index]));
        this.double_4 = 3.4028234663852886E+38;
        this.double_5 = 3.4028234663852886E+38;
        this.double_6 = -3.4028234663852886E+38;
        this.double_7 = -3.4028234663852886E+38;
        foreach (PointF pointF in this.arrayList_1)
        {
            if ((double)pointF.X < this.double_4)
                this.double_4 = (double)pointF.X;
            if ((double)pointF.Y < this.double_5)
                this.double_5 = (double)pointF.Y;
            if ((double)pointF.X > this.double_6)
                this.double_6 = (double)pointF.X;
            if ((double)pointF.Y > this.double_7)
                this.double_7 = (double)pointF.Y;
        }
        c.int_65 = (int)(this.double_6 - this.double_4 + 0.001);
        c.int_66 = (int)(this.double_7 - this.double_5 + 0.001);
        c.int_65 += this.int_18;
        c.int_66 += this.int_18;
        if (c.int_65 < 500 && c.int_66 < 400)
        {
            int num1 = 500 / c.int_65;
            int num2 = 400 / c.int_66;
            int num3 = num1 > num2 ? num2 : num1;
            this.int_24 = c.int_65 * num3;
            this.int_25 = c.int_66 * num3;
        }
        else
        {
            this.int_24 = c.int_65;
            this.int_25 = c.int_66;
        }
        ++this.int_21;
        if (this.int_21 > 15)
            this.int_21 = 0;
        this.progressBar_0.Value = this.int_21;
        if (c.int_65 <= 8050 && c.int_66 <= 6050)
        {
            PointF[] pointFArray5 = new PointF[this.arrayList_1.Count];
            int count4 = this.arrayList_1.Count;
            for (int index = 0; index < this.arrayList_1.Count; ++index)
            {
                float x = ((PointF)this.arrayList_1[index]).X;
                float y = ((PointF)this.arrayList_1[index]).Y;
                pointFArray5[index].X = (float)((double)x - this.double_4 + 0.001);
                pointFArray5[index].Y = (float)((double)y - this.double_5 + 0.001);
            }
            this.arrayList_1.Clear();
            for (int index = 0; index < count4; ++index)
                this.arrayList_1.Add((object)pointFArray5[index]);
            int count5 = this.arrayList_0.Count;
            PointF[] pointFArray6 = new PointF[count5];
            PointF[] pointFArray7 = new PointF[count5];
            for (int index = 0; index < count5; ++index)
            {
                pointFArray6[index].X = (float)((double)((GClass7)this.arrayList_0[index]).method_0().X - this.double_4 + 0.001);
                pointFArray6[index].Y = (float)((double)((GClass7)this.arrayList_0[index]).method_0().Y - this.double_5 + 0.001);
                pointFArray7[index].X = (float)((double)((GClass7)this.arrayList_0[index]).method_2().X - this.double_4 + 0.001);
                pointFArray7[index].Y = (float)((double)((GClass7)this.arrayList_0[index]).method_2().Y - this.double_5 + 0.001);
            }
            this.arrayList_0.Clear();
            for (int index = 0; index < count5; ++index)
                this.arrayList_0.Add((object)new GClass7(pointFArray6[index], pointFArray7[index]));
            int count6 = this.arrayList_2.Count;
            PointF[] pointFArray8 = new PointF[count6];
            string[] strArray2 = new string[count6];
            for (int index = 0; index < count6; ++index)
            {
                pointFArray8[index].X = (float)((double)((GClass2)this.arrayList_2[index]).method_2().X - this.double_4 + 0.001);
                pointFArray8[index].Y = (float)((double)((GClass2)this.arrayList_2[index]).method_2().Y - this.double_5 + 0.001);
                strArray2[index] = ((GClass2)this.arrayList_2[index]).method_0();
            }
            this.arrayList_2.Clear();
            for (int index = 0; index < count6; ++index)
                this.arrayList_2.Add((object)new GClass2(pointFArray8[index], strArray2[index]));
            return this.method_8();
        }
        if (c.useEnglishLanguage)
            this.ShowMessage(Module.a("ﮪ솬쪮킰삲킴鞶쮸\uDEBA\uD9BC쪾ꋀꛂ\uE5C4돆ꇈ껊\uEDCC곎냐뷒ꏔ뛖\uAAD8ﯚ껜뛞鯠蛢짤쟦裨飪췬髮\u9FF0韲郴藶\uD9F8迺闼髾℀怂瀄甆笈渊挌笎ㄐ愒瀔搖瘘眚栜欞䠠䰢䬤ଦन弪䔬䨮ᄰ倲吴夶伸娺丼Ἶ㉀⩂㽄≆楈⑊⭌潎ၐ♒\u2154㡖ᩘᩚᥜ罞ൠɢᱤ\u0866ᱨὪ䵬ᱮᥰᱲt᭶ᵸ孺ὼ\u1A7Eꆀ\uED82\uEA84Ꞇ\uE488\uE48Aﾌ\uEA8E놐\uE792ﶔ\uF696\uF798뮚ꖜ꾞醠鎢辤醦馨鮪鶬莮펰욲솴鞶춸펺\uD8BC龾ꃀꃂ뇄닆\uA8C8\uA7CA\uEDCC곎냐뷒ꏔ뛖\uAAD8ﯚ껜뛞鯠蛢엤触蛨鳪췬蛮苰", int_0) + c.int_65.ToString() + Module.a("膪", int_0) + c.int_66.ToString());
        else
            this.ShowMessage(Module.a("菽ﻳ\uE2FC럢ᬽ㋇본閸諸좼쮾껀胂蓄菆\uE486좔趐\uF4BB튎\uF48B\uDA88\uDA98\u2458幗ᩓ\uE7DE퇠폢헤췦\uDFE8\uDBEA\uDDEC\uDFEE\uDDF0ｲꚫ몤슍\uF8A4\uDAA5\uF0A2㭎", int_0) + c.int_65.ToString() + Module.a("膪", int_0) + c.int_66.ToString() + Module.a("螪\uEDCE䫠鷗\uDC3D䏺埓泔뿣믈鎾㙋\uEABD쪘ﲳ쪖쨵", int_0));
        this.progressBar_0.Visible = false;
        this.progressBar_0.Enabled = false;
        return 1;
    }

    private int method_7()
    {
        int int_0 = 5;
        if (this.double_3 < 0.5)
        {
            if (c.useEnglishLanguage)
                this.ShowMessage(Module.a("\uDFAA얬쪮醰ힲ\uDCB4횶풸\uDEBA즼\uDABE돀\uE3C2\uAAC4ꇆ\uE9C8뿊ꗌ\uAACE\uF1D0냒볔ꗖ뫘럚룜\uFFDE裠跢엤짦跨鏪诬쿮韰髲駴鋶\uD9F8鋺軼\uDFFE㴀⌂㐄⤆㤈✊紌挎琐爒昔爖㤘砚甜縞传䐢䀤ܦ䀨弪ബ丮䈰ጲ\u0B34ਸ਼࠸ᔺ\u0D3CἾ慀捂", int_0));
            else
                this.ShowMessage(Module.a("薪즬\uD7AEힰ㓗䏺髸뿯㿌䧊㯡캜䶌\uF4C4\uE9C6杻\uE7CA㩇\uE799郐ꛒꇔ룖高髚駜\uF290\uE7BC閳\u0BAB\uDE83펦ꊑ探歷횩綼쓴\uD9F6째洞", int_0));
            this.progressBar_0.Visible = false;
            this.progressBar_0.Enabled = false;
            return 1;
        }
        this.double_4 = 3.4028234663852886E+38;
        this.double_5 = 3.4028234663852886E+38;
        this.double_6 = -3.4028234663852886E+38;
        this.double_7 = -3.4028234663852886E+38;
        foreach (PointF pointF in this.arrayList_1)
        {
            if ((double)pointF.X < this.double_4)
                this.double_4 = (double)pointF.X;
            if ((double)pointF.Y < this.double_5)
                this.double_5 = (double)pointF.Y;
            if ((double)pointF.X > this.double_6)
                this.double_6 = (double)pointF.X;
            if ((double)pointF.Y > this.double_7)
                this.double_7 = (double)pointF.Y;
        }
        PointF[] pointFArray1 = new PointF[this.arrayList_1.Count];
        int count1 = this.arrayList_1.Count;
        for (int index = 0; index < this.arrayList_1.Count; ++index)
        {
            float x = ((PointF)this.arrayList_1[index]).X;
            float y = ((PointF)this.arrayList_1[index]).Y;
            pointFArray1[index].X = x;
            pointFArray1[index].Y = (float)this.double_5 - y;
        }
        this.arrayList_1.Clear();
        for (int index = 0; index < count1; ++index)
            this.arrayList_1.Add((object)pointFArray1[index]);
        int count2 = this.arrayList_0.Count;
        PointF[] pointFArray2 = new PointF[count2];
        PointF[] pointFArray3 = new PointF[count2];
        for (int index = 0; index < count2; ++index)
        {
            pointFArray2[index].X = ((GClass7)this.arrayList_0[index]).method_0().X;
            pointFArray2[index].Y = (float)this.double_5 - ((GClass7)this.arrayList_0[index]).method_0().Y;
            pointFArray3[index].X = ((GClass7)this.arrayList_0[index]).method_2().X;
            pointFArray3[index].Y = (float)this.double_5 - ((GClass7)this.arrayList_0[index]).method_2().Y;
        }
        this.arrayList_0.Clear();
        for (int index = 0; index < count2; ++index)
            this.arrayList_0.Add((object)new GClass7(pointFArray2[index], pointFArray3[index]));
        int count3 = this.arrayList_2.Count;
        PointF[] pointFArray4 = new PointF[count3];
        string[] strArray1 = new string[count3];
        for (int index = 0; index < count3; ++index)
        {
            pointFArray4[index].X = ((GClass2)this.arrayList_2[index]).method_2().X;
            pointFArray4[index].Y = (float)this.double_5 - ((GClass2)this.arrayList_2[index]).method_2().Y;
            strArray1[index] = ((GClass2)this.arrayList_2[index]).method_0();
        }
        this.arrayList_2.Clear();
        for (int index = 0; index < count3; ++index)
            this.arrayList_2.Add((object)new GClass2(pointFArray4[index], strArray1[index]));
        this.double_4 = 3.4028234663852886E+38;
        this.double_5 = 3.4028234663852886E+38;
        this.double_6 = -3.4028234663852886E+38;
        this.double_7 = -3.4028234663852886E+38;
        foreach (PointF pointF in this.arrayList_1)
        {
            if ((double)pointF.X < this.double_4)
                this.double_4 = (double)pointF.X;
            if ((double)pointF.Y < this.double_5)
                this.double_5 = (double)pointF.Y;
            if ((double)pointF.X > this.double_6)
                this.double_6 = (double)pointF.X;
            if ((double)pointF.Y > this.double_7)
                this.double_7 = (double)pointF.Y;
        }
        c.int_65 = (int)(this.double_6 - this.double_4 + 0.001);
        c.int_66 = (int)(this.double_7 - this.double_5 + 0.001);
        c.int_65 += this.int_18;
        c.int_66 += this.int_18;
        if (c.int_65 < 500 && c.int_66 < 400)
        {
            int num1 = 500 / c.int_65;
            int num2 = 400 / c.int_66;
            int num3 = num1 > num2 ? num2 : num1;
            this.int_24 = c.int_65 * num3;
            this.int_25 = c.int_66 * num3;
        }
        else
        {
            this.int_24 = c.int_65;
            this.int_25 = c.int_66;
        }
        ++this.int_21;
        if (this.int_21 > 15)
            this.int_21 = 0;
        this.progressBar_0.Value = this.int_21;
        if (c.int_65 <= 8050 && c.int_66 <= 6050)
        {
            PointF[] pointFArray5 = new PointF[this.arrayList_1.Count];
            int count4 = this.arrayList_1.Count;
            for (int index = 0; index < this.arrayList_1.Count; ++index)
            {
                float x = ((PointF)this.arrayList_1[index]).X;
                float y = ((PointF)this.arrayList_1[index]).Y;
                pointFArray5[index].X = (float)((double)x - this.double_4 + 0.001);
                pointFArray5[index].Y = (float)((double)y - this.double_5 + 0.001);
            }
            this.arrayList_1.Clear();
            for (int index = 0; index < count4; ++index)
                this.arrayList_1.Add((object)pointFArray5[index]);
            int count5 = this.arrayList_0.Count;
            PointF[] pointFArray6 = new PointF[count5];
            PointF[] pointFArray7 = new PointF[count5];
            for (int index = 0; index < count5; ++index)
            {
                pointFArray6[index].X = (float)((double)((GClass7)this.arrayList_0[index]).method_0().X - this.double_4 + 0.001);
                pointFArray6[index].Y = (float)((double)((GClass7)this.arrayList_0[index]).method_0().Y - this.double_5 + 0.001);
                pointFArray7[index].X = (float)((double)((GClass7)this.arrayList_0[index]).method_2().X - this.double_4 + 0.001);
                pointFArray7[index].Y = (float)((double)((GClass7)this.arrayList_0[index]).method_2().Y - this.double_5 + 0.001);
            }
            this.arrayList_0.Clear();
            for (int index = 0; index < count5; ++index)
                this.arrayList_0.Add((object)new GClass7(pointFArray6[index], pointFArray7[index]));
            int count6 = this.arrayList_2.Count;
            PointF[] pointFArray8 = new PointF[count6];
            string[] strArray2 = new string[count6];
            for (int index = 0; index < count6; ++index)
            {
                pointFArray8[index].X = (float)((double)((GClass2)this.arrayList_2[index]).method_2().X - this.double_4 + 0.001);
                pointFArray8[index].Y = (float)((double)((GClass2)this.arrayList_2[index]).method_2().Y - this.double_5 + 0.001);
                strArray2[index] = ((GClass2)this.arrayList_2[index]).method_0();
            }
            this.arrayList_2.Clear();
            for (int index = 0; index < count6; ++index)
                this.arrayList_2.Add((object)new GClass2(pointFArray8[index], strArray2[index]));
            return this.method_8();
        }
        if (c.useEnglishLanguage)
            this.ShowMessage(Module.a("ﮪ솬쪮킰삲킴鞶쮸\uDEBA\uD9BC쪾ꋀꛂ\uE5C4돆ꇈ껊\uEDCC곎냐뷒ꏔ뛖\uAAD8ﯚ껜뛞鯠蛢짤쟦裨飪췬髮\u9FF0韲郴藶\uD9F8迺闼髾℀怂瀄甆笈渊挌笎ㄐ愒瀔搖瘘眚栜欞䠠䰢䬤ଦन弪䔬䨮ᄰ倲吴夶伸娺丼Ἶ㉀⩂㽄≆楈⑊⭌潎ၐ♒\u2154㡖ᩘᩚᥜ罞ൠɢᱤ\u0866ᱨὪ䵬ᱮᥰᱲt᭶ᵸ孺ὼ\u1A7Eꆀ\uED82\uEA84Ꞇ\uE488\uE48Aﾌ\uEA8E놐\uE792ﶔ\uF696\uF798뮚ꖜ꾞醠鎢辤醦馨鮪鶬莮펰욲솴鞶춸펺\uD8BC龾ꃀꃂ뇄닆\uA8C8\uA7CA\uEDCC곎냐뷒ꏔ뛖\uAAD8ﯚ껜뛞鯠蛢엤触蛨鳪췬蛮苰", int_0) + c.int_65.ToString() + Module.a("膪", int_0) + c.int_66.ToString());
        else
            this.ShowMessage(Module.a("菽ﻳ\uE2FC럢ᬽ㋇본閸諸좼쮾껀胂蓄菆\uE486좔趐\uF4BB튎\uF48B\uDA88\uDA98\u2458幗ᩓ\uE7DE퇠폢헤췦\uDFE8\uDBEA\uDDEC\uDFEE\uDDF0ｲꚫ몤슍\uF8A4\uDAA5\uF0A2㭎", int_0) + c.int_65.ToString() + Module.a("膪", int_0) + c.int_66.ToString() + Module.a("螪\uEDCE䫠鷗\uDC3D䏺埓泔뿣믈鎾㙋\uEABD쪘ﲳ쪖쨵", int_0));
        this.progressBar_0.Visible = false;
        this.progressBar_0.Enabled = false;
        return 1;
    }

    private int method_8()
    {
        int int_0 = 6;
        switch (c.int_2)
        {
            case 9:
                this.int_82 = 2048;
                break;
            case 13:
                this.int_82 = 2048;
                break;
            case 32:
                this.int_82 = 2048;
                break;
            case 47:
                this.int_82 = 2048;
                break;
            case 52:
                this.int_82 = 2048;
                break;
        }
        if (c.int_2 == 2 || c.int_2 == 49 || c.int_2 == 16 || c.int_2 == 110 || c.int_2 == 83)
            this.int_82 = c.bool_1 ? 170 : 512;
        this.arrayList_3.Clear();
        double num1;
        double num2;
        switch (c.byte_10)
        {
            case 0:
                num1 = this.double_3;
                num2 = this.double_3;
                break;
            case 1:
                num1 = 0.0;
                num2 = this.double_3;
                break;
            default:
                num1 = 0.0;
                num2 = 0.0;
                break;
        }
    label_54:
        for (int int_2 = 0; int_2 < 1024 && this.arrayList_2.Count != 0; ++int_2)
        {
            GClass8 gclass8;
            do
            {
                int index = 0;
                while (true)
                {
                    if (index < this.arrayList_2.Count)
                    {
                        string strA = Module.a("\uDCAB", int_0) + (int_2 + 1).ToString();
                        string strB = ((GClass2)this.arrayList_2[index]).method_0();
                        int num3 = string.Compare(strA, strB, true);
                        if (num3 != 0)
                        {
                            int num4 = int_2 / 8 + 1;
                            int num5 = int_2 % 8 + 1;
                            num3 = string.Compare(Module.a("쾫", int_0) + num4.ToString() + Module.a("\uDCAB", int_0) + num5.ToString(), strB, true);
                        }
                        if (num3 != 0)
                            ++index;
                        else
                            break;
                    }
                    else
                        goto label_54;
                }
                ++this.int_21;
                if (this.int_21 > 15)
                    this.int_21 = 0;
                this.progressBar_0.Value = this.int_21;
                PointF pointF1 = ((GClass2)this.arrayList_2[index]).method_2();
                gclass8 = new GClass8(int_2, this.int_82);
                do
                {
                    this.bool_58 = true;
                    foreach (GClass7 gclass7 in this.arrayList_0)
                    {
                        if ((double)pointF1.X < (double)gclass7.method_0().X - num1 || (double)pointF1.X > (double)gclass7.method_0().X + num1 || (double)pointF1.Y < (double)gclass7.method_0().Y - num1 || (double)pointF1.Y > (double)gclass7.method_0().Y + num1)
                        {
                            if ((double)pointF1.X >= (double)gclass7.method_2().X - num1 && (double)pointF1.X <= (double)gclass7.method_2().X + num1 && (double)pointF1.Y >= (double)gclass7.method_2().Y - num1 && (double)pointF1.Y <= (double)gclass7.method_2().Y + num1)
                            {
                                pointF1 = new PointF(gclass7.method_0().X, gclass7.method_0().Y);
                                this.bool_58 = false;
                                foreach (PointF pointF2 in this.arrayList_1)
                                {
                                    if ((double)pointF2.X >= (double)pointF1.X - num2 && (double)pointF2.X <= (double)pointF1.X + num2 && (double)pointF2.Y >= (double)pointF1.Y - num2 && (double)pointF2.Y <= (double)pointF1.Y + num2)
                                    {
                                        gclass8.method_7(gclass8.method_0(), new Point((int)pointF2.X, (int)pointF2.Y));
                                        this.arrayList_1.Remove((object)pointF2);
                                        gclass8.method_1(gclass8.method_0() + 1);
                                        if (gclass8.method_0() >= this.int_82)
                                        {
                                            this.bool_58 = true;
                                            break;
                                        }
                                        break;
                                    }
                                }
                                this.arrayList_0.Remove((object)gclass7);
                                break;
                            }
                        }
                        else
                        {
                            pointF1 = new PointF(gclass7.method_2().X, gclass7.method_2().Y);
                            this.bool_58 = false;
                            foreach (PointF pointF3 in this.arrayList_1)
                            {
                                if ((double)pointF3.X >= (double)pointF1.X - num2 && (double)pointF3.X <= (double)pointF1.X + num2 && (double)pointF3.Y >= (double)pointF1.Y - num2 && (double)pointF3.Y <= (double)pointF1.Y + num2)
                                {
                                    gclass8.method_7(gclass8.method_0(), new Point((int)pointF3.X, (int)pointF3.Y));
                                    this.arrayList_1.Remove((object)pointF3);
                                    gclass8.method_1(gclass8.method_0() + 1);
                                    if (gclass8.method_0() >= this.int_82)
                                    {
                                        this.bool_58 = true;
                                        break;
                                    }
                                    break;
                                }
                            }
                            this.arrayList_0.Remove((object)gclass7);
                            break;
                        }
                    }
                }
                while (!this.bool_58);
                this.arrayList_2.RemoveAt(index);
            }
            while (gclass8.method_0() <= 0);
            this.arrayList_3.Add((object)gclass8);
        }
        this.progressBar_0.Value = 15;
        for (int index = 0; index < this.arrayList_2.Count; ++index)
        {
            string str = ((GClass2)this.arrayList_2[index]).method_0();
            if (str.Length >= 1 && str.Substring(0, 1) == Module.a("辫", int_0))
            {
                string[] strArray = str.Substring(1).Split('=');
                if (strArray[0].Substring(0, 1).ToUpper() == Module.a("ﲫ", int_0) && strArray[1].Substring(0, 1).ToUpper() == Module.a("ﲫ", int_0))
                {
                    int int_2_1 = Convert.ToInt32(strArray[0].Substring(1)) - 1;
                    int num6 = Convert.ToInt32(strArray[1].Substring(1)) - 1;
                    bool flag1 = false;
                    bool flag2 = false;
                    if (int_2_1 != num6)
                    {
                        foreach (GClass8 gclass8 in this.arrayList_3)
                        {
                            if (gclass8.method_4() == int_2_1)
                                flag1 = true;
                            if (gclass8.method_4() == num6)
                                flag2 = true;
                        }
                        if (flag2 && !flag1)
                        {
                            GClass8 gclass8_1 = new GClass8(int_2_1, this.int_82);
                            foreach (GClass8 gclass8_2 in this.arrayList_3)
                            {
                                if (gclass8_2.method_4() == num6)
                                {
                                    for (int int_2_2 = 0; int_2_2 < gclass8_2.method_0(); ++int_2_2)
                                        gclass8_1.method_7(int_2_2, gclass8_2.method_6(int_2_2));
                                    gclass8_1.method_1(gclass8_2.method_0());
                                    break;
                                }
                            }
                            this.arrayList_3.Add((object)gclass8_1);
                        }
                    }
                }
            }
        }
        bool flag = false;
        foreach (GClass8 gclass8 in this.arrayList_3)
        {
            if (gclass8.method_0() > 0)
            {
                flag = true;
                break;
            }
        }
        if (!flag)
        {
            if (c.useEnglishLanguage)
                this.ShowMessage(Module.a("嶺삭톯킱\uD8B3펵颷캹펻麽늿\uA7C1ꗃꋅ\uE8C7ꗉ맋뫍\uF0CFꛑ볓돕\uF8D7럙맛귝鏟菡菣菥죧诩軫臭藯蛱퓳髵釷鷹铻諽珿⸁␃瘅搇漉洋納甏㈑眓縕紗礙眛㸝伟圡倣إ尧䈩䤫อ簯匱䴳礵䴷丹᰻堽⤿⹁⅃杅", int_0));
            else
                this.ShowMessage(Module.a("嬠滅嗈ﺱ\uF1B3\uF2B5믩\uFAE5㯞䣳\uECBF⊤ᆯ㵎Ẕꖹ䢽⾂뾯팮", int_0));
            this.progressBar_0.Visible = false;
            this.progressBar_0.Enabled = false;
            return 1;
        }
        int num7 = 0;
        for (int index = 0; index < this.arrayList_3.Count; ++index)
        {
            if (((GClass8)this.arrayList_3[index]).method_4() > num7)
                num7 = ((GClass8)this.arrayList_3[index]).method_4();
        }
        int num8 = num7 + 1;
        this.int_23 = this.arrayList_3.Count;
        if (num8 > this.int_23)
        {
            if (!this.bool_23)
            {
                if (c.useEnglishLanguage)
                    this.ShowMessage(Module.a("\uF8AB욭햯銱쎳\uDFB5쪷\uDFB9쾻麽뎿꫁ꯃ독\uA4C7껉\uECCB곍뗏\uF2D1럓맕뛗듙맛뷝铟蟡胣웥觧觩迫臭苯雱鷳飵\u9FF7\uDAF9裻釽\u20FF瘁氃挅⠇礉椋缍攏眑稓甕紗㨙猛砝\u001F刡ᔣਥࠧ娩ḫ-ḯᰱ䐳堵ᠷ丹医ḽ㌿⍁㉃⍅桇㹉\u244B⭍灏\u2151\u2453㝕㭗㽙牛", int_0));
                else
                    this.ShowMessage(Module.a("嬠\uA7CE삯莱颳隵좷袹銻邽\uEEBF닁\uAAC3뱝䞙즗玵숲\uF69B쮃캜벸\uE15A节璋꒧ᑊ\uE31E", int_0));
            }
            this.int_23 = num8;
        }
        if ((c.int_2 == 7 || c.int_2 == 41 || c.int_2 == 48 || c.int_2 == 49 || c.int_2 == 50) && this.int_23 > 4)
        {
            if (c.useEnglishLanguage)
                this.ShowMessage(Module.a("\uF8AB욭햯銱\uD9B3ힵ삷钹鲻킽떿꿁ꛃꏅ뫇\uEAC9ꏋ\uA8CD\uF0CFꋑ믓ꓕ곗꧙ﳛ럝鏟싡탣쫥죧裩駫髭탯蛱鳳鏵\uD8F7鯹\u9FFB諽痿持栃★昇缉愋氍甏怑㐓琕紗猙爛礝\u001F圡圣䌥䰧\u0A29䔫䀭ု䘱尳匵ᠷ夹䤻䰽㈿❁⩃㉅桇摉⡋㙍㙏絑㝓\u2E55㩗穙㩛㝝\u0C5Fݡ䑣ཥ᭧", int_0) + this.int_23.ToString());
            else
                this.ShowMessage(Module.a("곌듴鿊돒肳鳻埍姪邻\uF8F2鏠输ꃃ뻅껇\uE5C9꿋뛍닏喴⊝ﮛ䚌齏ꎔ\uF6A8暑", int_0) + this.int_23.ToString() + Module.a("蛥䇗叼덎", int_0));
            this.progressBar_0.Visible = false;
            this.progressBar_0.Enabled = false;
            return 1;
        }
        this.int_23 = this.int_23 % c.int_75 != 0 ? (this.int_23 / c.int_75 + 1) * c.int_75 : this.int_23 / c.int_75 * c.int_75;
        if ((c.int_2 == 3 || c.int_2 == 8 || c.int_2 == 12 || c.int_2 == 31 || c.int_2 == 46 || c.int_2 == 2) && this.int_23 > 8)
        {
            if (c.useEnglishLanguage)
                this.ShowMessage(Module.a("\uF8AB욭햯銱\uD9B3ힵ삷钹鲻킽떿꿁ꛃꏅ뫇\uEAC9ꏋ\uA8CD\uF0CFꋑ믓ꓕ곗꧙ﳛ럝鏟싡\uDCE3쫥죧裩駫髭탯蛱鳳鏵\uD8F7鯹\u9FFB諽痿持栃★昇缉愋氍甏怑㐓琕紗猙爛礝\u001F圡圣䌥䰧\u0A29䔫䀭ု䘱尳匵ᠷ夹䤻䰽㈿❁⩃㉅桇摉⡋㙍㙏絑㝓\u2E55㩗穙㩛㝝\u0C5Fݡ䑣ཥ᭧", int_0) + this.int_23.ToString());
            else
                this.ShowMessage(Module.a("곌듴鿊돒貳鳻埍姪邻\uF8F2鏠输ꃃ뻅껇\uE5C9꿋뛍닏喴⊝ﮛ䚌齏ꎔ\uF6A8暑", int_0) + this.int_23.ToString() + Module.a("蛥䇗叼덎", int_0));
            this.progressBar_0.Visible = false;
            this.progressBar_0.Enabled = false;
            return 1;
        }
        this.int_41 = 0;
        this.int_42 = 0;
        foreach (GClass8 gclass8 in this.arrayList_3)
        {
            this.int_41 += gclass8.method_0();
            if (this.int_42 < gclass8.method_0())
                this.int_42 = gclass8.method_0();
        }
        int num9 = 0;
        foreach (GClass8 gclass8 in this.arrayList_3)
        {
            if (gclass8.method_0() > num9)
                num9 = gclass8.method_0();
        }
        if (c.int_2 == 9)
            this.int_82 = num9 <= 1024 ? 1024 : 2048;
        else if (c.int_2 == 13 || c.int_2 == 32 || c.int_2 == 47 || c.int_2 == 52)
            this.int_82 = num9 <= 1536 ? (num9 <= 1024 ? (num9 <= 512 ? 512 : 1024) : 1536) : 2048;
        switch (c.int_2)
        {
            case 101:
                this.int_82 = 256;
                break;
            case 103:
                this.int_82 = 512;
                break;
        }
        if (c.int_2 == 2 || c.int_2 == 49 || c.int_2 == 16 || c.int_2 == 110 || c.int_2 == 83)
        {
            if (!c.bool_1)
            {
                int num10 = 0;
                foreach (GClass8 gclass8 in this.arrayList_3)
                {
                    if (gclass8.method_0() > num10)
                        num10 = gclass8.method_0();
                }
                c.int_74 = num10 % 128 != 0 ? (num10 / 128 + 1) * 128 : num10 / 128 * 128;
                this.int_82 = c.int_74;
                this.method_26(11, c.int_74.ToString());
            }
            else
            {
                c.int_74 = 170;
                this.int_82 = c.int_74;
                this.method_26(11, c.int_74.ToString());
            }
            this.byte_29 = (byte)(this.int_82 / 128);
            if (this.byte_29 == (byte)1)
                c.int_3 = 30;
            else if (this.byte_29 == (byte)2)
                c.int_3 = 29;
            else if (this.byte_29 == (byte)3)
                c.int_3 = 20;
            else if (this.byte_29 == (byte)4)
                c.int_3 = 14;
            if (c.int_2 == 16 && !c.bool_1)
            {
                c.int_74 = 512;
                this.int_82 = c.int_74;
                this.method_26(11, c.int_74.ToString());
            }
            this.int_62 = this.int_82 * 24 / 1024;
            this.int_63 = this.int_82 * 24;
            c.smethod_1(c.int_3);
            this.method_26(12, c.smethod_0().ToString());
            if (c.bool_1)
            {
                this.int_62 = 4;
                this.int_63 = 4096;
                this.byte_29 = (byte)0;
                c.int_3 = 30;
                switch (c.int_2)
                {
                    case 2:
                    case 49:
                        this.int_39 = 4096;
                        break;
                    case 16:
                        this.int_39 = 4096;
                        break;
                    case 83:
                    case 110:
                        this.int_39 = 4096 * (this.int_23 >= 8 ? this.int_23 / c.int_75 : 1);
                        break;
                }
            }
        }
        this.int_39 = this.int_23 * this.int_82 * 3;
        if (c.int_2 == 201)
            this.int_39 = 16384;
        this.byte_37 = new byte[this.int_39];
        this.byte_38 = new byte[this.int_39];
        this.byte_40 = new byte[this.int_39];
        for (int index = 0; index < this.int_39; ++index)
            this.byte_37[index] = (byte)0;
        this.udpClient_0.Client.SendBufferSize = this.int_39;
        this.progressBar_0.Visible = false;
        this.progressBar_0.Enabled = false;
        if (!this.bool_23)
        {
            if (c.useEnglishLanguage)
                this.ShowMessage(Module.a("\uE5AB쎭삯\uDDB1욳습颷", int_0) + this.int_41.ToString() + Module.a("貫\uE2AD\uF5AF\uF6B1钳\uDAB5톷\uDDB9풻쪽뎿\uEEC1\uE4C3꿅ꗇ뫉ꏋ볍\uA4CF믑뫓뇕\uF8D7볙뷛럝賟蟡胣웥", int_0) + this.arrayList_1.Count.ToString() + Module.a("貫슭\uD9AF햱\uDCB3습쮷銹쮻횽ꦿ뛁ꇃ\uEFC5\uE9C7", int_0));
            else
                this.ShowMessage(Module.a("볉ㇿ䳴ퟠ钳", int_0) + this.int_41.ToString() + Module.a("貫蓣ﲯ\uF7B1\uF0B3\uD9C5钷돞鲻", int_0) + this.arrayList_1.Count.ToString() + Module.a("貫蓣ﲯ\uF7B1\uF0B3\uD9C5䓬\uDFE8跢鬰\uE8BF뾷뙁\uEFC5\uE9C7", int_0));
        }
        c.int_78 = 0;
        this.method_26(14, c.int_78.ToString());
        this.method_13();
        Bitmap bitmap = new Bitmap(this.panel_0.Width, this.panel_0.Height);
        Graphics graphics1 = Graphics.FromImage((Image)bitmap);
        IntPtr hdc1 = graphics1.GetHdc();
        Graphics graphics2 = this.panel_0.CreateGraphics();
        IntPtr hdc2 = graphics2.GetHdc();
        c.BitBlt(hdc1, 0, 0, this.panel_0.Width, this.panel_0.Height, hdc2, 0, 0, 13369376);
        graphics2.ReleaseHdc(hdc2);
        graphics1.ReleaseHdc(hdc1);
        string filename = this.string_20 + (object)'\\' + this.string_22 + Module.a("ӹ闘狼헀骳풵햷쪹", int_0);
        if (this.image_1 != null)
            this.image_1.Dispose();
        bitmap.Save(filename, ImageFormat.Bmp);
        this.image_1 = Image.FromFile(filename);
        this.method_14();
        string string_24 = this.string_22 + Module.a("芫\uE2AD좯킱", int_0);
        this.method_26(23, Module.a("鶫", int_0));
        this.method_26(24, string_24);
        return 0;
    }

    private int method_9()
    {
        int int_0 = 19;
        switch (c.int_2)
        {
            case 9:
                this.int_82 = 2048;
                break;
            case 13:
                this.int_82 = 2048;
                break;
            case 32:
                this.int_82 = 2048;
                break;
            case 47:
                this.int_82 = 2048;
                break;
            case 52:
                this.int_82 = 2048;
                break;
        }
        if (c.int_2 == 2 || c.int_2 == 49 || c.int_2 == 16 || c.int_2 == 110 || c.int_2 == 83)
            this.int_82 = c.bool_1 ? 170 : 512;
        this.arrayList_3.Clear();
    label_48:
        for (int int_2 = 0; int_2 < 1024; ++int_2)
        {
            GClass8 gclass8;
            do
            {
                int index = 0;
                while (true)
                {
                    if (index < this.arrayList_2.Count)
                    {
                        if (string.Compare(Module.a("즸", int_0) + (int_2 + 1).ToString(), ((GClass2)this.arrayList_2[index]).method_0(), true) != 0)
                            ++index;
                        else
                            break;
                    }
                    else
                        goto label_48;
                }
                ++this.int_21;
                if (this.int_21 > 15)
                    this.int_21 = 0;
                this.progressBar_0.Value = this.int_21;
                PointF pointF1 = ((GClass2)this.arrayList_2[index]).method_2();
                gclass8 = new GClass8(int_2, this.int_82);
                do
                {
                    this.bool_58 = true;
                    foreach (GClass7 gclass7 in this.arrayList_0)
                    {
                        if ((double)gclass7.method_0().X != (double)pointF1.X || (double)gclass7.method_0().Y != (double)pointF1.Y)
                        {
                            if ((double)gclass7.method_2().X == (double)pointF1.X && (double)gclass7.method_2().Y == (double)pointF1.Y)
                            {
                                pointF1 = new PointF(gclass7.method_0().X, gclass7.method_0().Y);
                                this.bool_58 = false;
                                foreach (PointF pointF2 in this.arrayList_1)
                                {
                                    if ((double)pointF2.X == (double)pointF1.X && (double)pointF2.Y == (double)pointF1.Y)
                                    {
                                        gclass8.method_7(gclass8.method_0(), new Point((int)pointF2.X, (int)pointF2.Y));
                                        this.arrayList_1.Remove((object)pointF2);
                                        gclass8.method_1(gclass8.method_0() + 1);
                                        if (gclass8.method_0() >= this.int_82)
                                        {
                                            this.bool_58 = true;
                                            break;
                                        }
                                        break;
                                    }
                                }
                                this.arrayList_0.Remove((object)gclass7);
                                break;
                            }
                        }
                        else
                        {
                            pointF1 = new PointF(gclass7.method_2().X, gclass7.method_2().Y);
                            this.bool_58 = false;
                            foreach (PointF pointF3 in this.arrayList_1)
                            {
                                if ((double)pointF3.X == (double)pointF1.X && (double)pointF3.Y == (double)pointF1.Y)
                                {
                                    gclass8.method_7(gclass8.method_0(), new Point((int)pointF3.X, (int)pointF3.Y));
                                    this.arrayList_1.Remove((object)pointF3);
                                    gclass8.method_1(gclass8.method_0() + 1);
                                    if (gclass8.method_0() >= this.int_82)
                                    {
                                        this.bool_58 = true;
                                        break;
                                    }
                                    break;
                                }
                            }
                            this.arrayList_0.Remove((object)gclass7);
                            break;
                        }
                    }
                }
                while (!this.bool_58);
                this.arrayList_2.RemoveAt(index);
            }
            while (gclass8.method_0() <= 0);
            this.arrayList_3.Add((object)gclass8);
        }
        this.progressBar_0.Value = 15;
        for (int index = 0; index < this.arrayList_2.Count; ++index)
        {
            string str = ((GClass2)this.arrayList_2[index]).method_0();
            if (str.Substring(0, 1) == Module.a("骸", int_0))
            {
                string[] strArray = str.Substring(1).Split('=');
                if (strArray[0].Substring(0, 1).ToUpper() == Module.a("\uE9B8", int_0) && strArray[1].Substring(0, 1).ToUpper() == Module.a("\uE9B8", int_0))
                {
                    int int_2_1 = Convert.ToInt32(strArray[0].Substring(1)) - 1;
                    int num = Convert.ToInt32(strArray[1].Substring(1)) - 1;
                    bool flag1 = false;
                    bool flag2 = false;
                    if (int_2_1 != num)
                    {
                        foreach (GClass8 gclass8 in this.arrayList_3)
                        {
                            if (gclass8.method_4() == int_2_1)
                                flag1 = true;
                            if (gclass8.method_4() == num)
                                flag2 = true;
                        }
                        if (flag2 && !flag1)
                        {
                            GClass8 gclass8_1 = new GClass8(int_2_1, this.int_82);
                            foreach (GClass8 gclass8_2 in this.arrayList_3)
                            {
                                if (gclass8_2.method_4() == num)
                                {
                                    for (int int_2_2 = 0; int_2_2 < gclass8_2.method_0(); ++int_2_2)
                                        gclass8_1.method_7(int_2_2, gclass8_2.method_6(int_2_2));
                                    gclass8_1.method_1(gclass8_2.method_0());
                                    break;
                                }
                            }
                            this.arrayList_3.Add((object)gclass8_1);
                        }
                    }
                }
            }
        }
        bool flag = false;
        foreach (GClass8 gclass8 in this.arrayList_3)
        {
            if (gclass8.method_0() > 0)
            {
                flag = true;
                break;
            }
        }
        if (!flag)
        {
            if (c.useEnglishLanguage)
                this.ShowMessage(Module.a("\uECB8햺\uDCBC\uDDBE귀ꛂ\uE5C4돆ꛈ\uEBCA뿌\uAACE냐럒\uF5D4룖곘꿚\uFDDCꯞ觠蛢엤諦賨飪黬軮雰雲헴零鯸铺裼课℀漂氄怆愈缊縌⌎ㄐ挒礔爖砘栚砜㼞䈠䬢䀤䐦䈨ପ䈬娮䔰ጲ䄴弶尸ᬺ焼帾㡀ూい㍆楈ⵊ\u244C⍎㑐牒", int_0));
            else
                this.ShowMessage(Module.a("丳篒壛\uF3BE蓀蟂욚螚亭㶄\uE1CC⾫Ҽ⡙·뢦嶮㪕늼\uDE21", int_0));
            this.progressBar_0.Visible = false;
            this.progressBar_0.Enabled = false;
            return 1;
        }
        int num1 = 0;
        for (int index = 0; index < this.arrayList_3.Count; ++index)
        {
            if (((GClass8)this.arrayList_3[index]).method_4() > num1)
                num1 = ((GClass8)this.arrayList_3[index]).method_4();
        }
        int num2 = num1 + 1;
        this.int_23 = this.arrayList_3.Count;
        if (num2 > this.int_23)
        {
            if (!this.bool_23)
            {
                if (c.useEnglishLanguage)
                    this.ShowMessage(Module.a("\uEDB8펺\uD8BC龾뛀ꫂ럄ꋆ뫈\uEBCA뻌\uA7CE뻐ꛒ맔돖律맚룜\uFFDE苠賢诤触賨裪駬諮闰폲铴银髸铺迼鯾栀洂戄✆紈搊ⴌ笎礐瘒㔔搖簘樚栜稞传䀢䀤ܦ䘨䴪ബ弮0ἲᔴ䜶ସᔺጼᄾㅀⵂ敄㍆♈歊㹌\u2E4E❐㙒畔⍖ㅘ㹚絜ⱞᅠɢ٤ɦ䝨", int_0));
                else
                    this.ShowMessage(Module.a("丳닙춼躾\uEDC0\uE3C2뗄\uF5C6\uE7C8\uE5CA\uE3CC뿎뿐ꥊ媊품暦휥ﮈ욌ﮯ規\uDC69뾽䆸醐\u1979\uEE11", int_0));
            }
            this.int_23 = num2;
        }
        if ((c.int_2 == 7 || c.int_2 == 41 || c.int_2 == 48 || c.int_2 == 49 || c.int_2 == 50) && this.int_23 > 4)
        {
            if (c.useEnglishLanguage)
                this.ShowMessage(Module.a("\uEDB8펺\uD8BC龾곀ꋂ뷄\uE9C6\uE9C8ꗊ료ꋎ돐뛒\uA7D4\uF7D6뛘뷚\uFDDC꿞軠釢釤铦짨苪黬쿮연\uDFF2헴闶賸迺\uDDFC课椀昂┄昆樈缊砌渎紐㌒笔或琘礚砜洞Ġ䄢䀤並䜨䰪ബ娮䈰嘲儴᜶倸唺ᴼ䬾⥀♂敄⑆㱈㥊㽌⩎㽐❒畔祖㵘⍚㭜灞ɠ᭢ݤ䝦ཨɪŬ੮兰ᩲٴ", int_0) + this.int_23.ToString());
            else
                this.ShowMessage(Module.a("맟ꇣ鋙뻝\uF5C0\uE98C⪾\u2495\uE5C8超麓芜뗐ꯒ돔\uF8D6뫘ꏚ뿜墻ឮ캬箿ꉰ隧쎟殢", int_0) + this.int_23.ToString() + Module.a("鏶哀廯빁", int_0));
            this.progressBar_0.Visible = false;
            this.progressBar_0.Enabled = false;
            return 1;
        }
        this.int_23 = this.int_23 % c.int_75 != 0 ? (this.int_23 / c.int_75 + 1) * c.int_75 : this.int_23 / c.int_75 * c.int_75;
        if ((c.int_2 == 3 || c.int_2 == 8 || c.int_2 == 12 || c.int_2 == 31 || c.int_2 == 46 || c.int_2 == 2) && this.int_23 > 8)
        {
            if (c.useEnglishLanguage)
                this.ShowMessage(Module.a("\uEDB8펺\uD8BC龾곀ꋂ뷄\uE9C6\uE9C8ꗊ료ꋎ돐뛒\uA7D4\uF7D6뛘뷚\uFDDC꿞軠釢釤铦짨苪黬쿮짰\uDFF2헴闶賸迺\uDDFC课椀昂┄昆樈缊砌渎紐㌒笔或琘礚砜洞Ġ䄢䀤並䜨䰪ബ娮䈰嘲儴᜶倸唺ᴼ䬾⥀♂敄⑆㱈㥊㽌⩎㽐❒畔祖㵘⍚㭜灞ɠ᭢ݤ䝦ཨɪŬ੮兰ᩲٴ", int_0) + this.int_23.ToString());
            else
                this.ShowMessage(Module.a("맟ꇣ鋙뻝燎\uE98C⪾\u2495\uE5C8超麓芜뗐ꯒ돔\uF8D6뫘ꏚ뿜墻ឮ캬箿ꉰ隧쎟殢", int_0) + this.int_23.ToString() + Module.a("鏶哀廯빁", int_0));
            this.progressBar_0.Visible = false;
            this.progressBar_0.Enabled = false;
            return 1;
        }
        this.int_41 = 0;
        this.int_42 = 0;
        foreach (GClass8 gclass8 in this.arrayList_3)
        {
            this.int_41 += gclass8.method_0();
            if (this.int_42 < gclass8.method_0())
                this.int_42 = gclass8.method_0();
        }
        int num3 = 0;
        foreach (GClass8 gclass8 in this.arrayList_3)
        {
            if (gclass8.method_0() > num3)
                num3 = gclass8.method_0();
        }
        if (c.int_2 == 9)
            this.int_82 = num3 <= 1024 ? 1024 : 2048;
        else if (c.int_2 == 13 || c.int_2 == 32 || c.int_2 == 47 || c.int_2 == 52)
            this.int_82 = num3 <= 1536 ? (num3 <= 1024 ? (num3 <= 512 ? 512 : 1024) : 1536) : 2048;
        switch (c.int_2)
        {
            case 101:
                this.int_82 = 256;
                break;
            case 103:
                this.int_82 = 512;
                break;
        }
        if (c.int_2 == 2 || c.int_2 == 49 || c.int_2 == 16 || c.int_2 == 110 || c.int_2 == 83)
        {
            if (!c.bool_1)
            {
                int num4 = 0;
                foreach (GClass8 gclass8 in this.arrayList_3)
                {
                    if (gclass8.method_0() > num4)
                        num4 = gclass8.method_0();
                }
                c.int_74 = num4 % 128 != 0 ? (num4 / 128 + 1) * 128 : num4 / 128 * 128;
                this.int_82 = c.int_74;
                this.method_26(11, c.int_74.ToString());
            }
            else
            {
                c.int_74 = 170;
                this.int_82 = c.int_74;
                this.method_26(11, c.int_74.ToString());
            }
            this.byte_29 = (byte)(this.int_82 / 128);
            if (this.byte_29 == (byte)1)
                c.int_3 = 30;
            else if (this.byte_29 == (byte)2)
                c.int_3 = 29;
            else if (this.byte_29 == (byte)3)
                c.int_3 = 20;
            else if (this.byte_29 == (byte)4)
                c.int_3 = 14;
            if (c.int_2 == 16 && !c.bool_1)
            {
                c.int_74 = 512;
                this.int_82 = c.int_74;
                this.method_26(11, c.int_74.ToString());
            }
            this.int_62 = this.int_82 * 24 / 1024;
            this.int_63 = this.int_82 * 24;
            c.smethod_1(c.int_3);
            this.method_26(12, c.smethod_0().ToString());
            if (c.bool_1)
            {
                this.int_62 = 4;
                this.int_63 = 4096;
                this.byte_29 = (byte)0;
                c.int_3 = 30;
                switch (c.int_2)
                {
                    case 2:
                    case 49:
                        this.int_39 = 4096;
                        break;
                    case 16:
                        this.int_39 = 4096;
                        break;
                    case 83:
                    case 110:
                        this.int_39 = 4096 * (this.int_23 >= 8 ? this.int_23 / c.int_75 : 1);
                        break;
                }
            }
        }
        this.int_39 = this.int_23 * this.int_82 * 3;
        if (c.int_2 == 201)
            this.int_39 = 16384;
        this.byte_37 = new byte[this.int_39];
        this.byte_38 = new byte[this.int_39];
        this.byte_40 = new byte[this.int_39];
        for (int index = 0; index < this.int_39; ++index)
            this.byte_37[index] = (byte)0;
        this.udpClient_0.Client.SendBufferSize = this.int_39;
        this.progressBar_0.Visible = false;
        this.progressBar_0.Enabled = false;
        if (!this.bool_23)
        {
            if (c.useEnglishLanguage)
                this.ShowMessage(Module.a("\uEDB8펺\uD8BC龾뗀곂뇄ꛆꗈ\uEBCAꏌ뫎볐뇒냔ꗖ律듚믜\uFFDE균ꛢꇤ铦짨黪黬諮闰폲鳴駶\uD9F8迺闼雾爀⌂甄甆昈愊栌氎攐㌒簔搖⌘", int_0) + this.int_41.ToString());
            else
                this.ShowMessage(Module.a("\uEAE7\uF6E8壡듄\uEC8E늓몋\uEFB3來턵", int_0) + this.int_41.ToString() + Module.a("鏶\uF7BA\uF8BC﮾꺰숽", int_0));
        }
        c.int_78 = 0;
        this.method_26(14, c.int_78.ToString());
        this.method_13();
        Bitmap bitmap = new Bitmap(this.panel_0.Width, this.panel_0.Height);
        Graphics graphics1 = Graphics.FromImage((Image)bitmap);
        IntPtr hdc1 = graphics1.GetHdc();
        Graphics graphics2 = this.panel_0.CreateGraphics();
        IntPtr hdc2 = graphics2.GetHdc();
        c.BitBlt(hdc1, 0, 0, this.panel_0.Width, this.panel_0.Height, hdc2, 0, 0, 13369376);
        graphics2.ReleaseHdc(hdc2);
        graphics1.ReleaseHdc(hdc1);
        string filename = this.string_20 + (object)'\\' + this.string_22 + Module.a("ᇪ胏翯\uD8CF\uEFC0ꇂ꣄럆", int_0);
        if (this.image_1 != null)
            this.image_1.Dispose();
        bitmap.Save(filename, ImageFormat.Bmp);
        this.image_1 = Image.FromFile(filename);
        this.method_14();
        string string_24 = this.string_22 + Module.a("鞸\uF7BA얼\uDDBE", int_0);
        this.method_26(23, Module.a("袸", int_0));
        this.method_26(24, string_24);
        return 0;
    }

    private int method_10(string string_24)
    {
        int int_0 = 6;
        FileStream fileStream = new FileStream(string_24, FileMode.Open, FileAccess.Read);
        BufferedStream bufferedStream = new BufferedStream((Stream)fileStream);
        byte[] buffer1 = new byte[512];
        bufferedStream.Seek(0L, SeekOrigin.Begin);
        bufferedStream.Read(buffer1, 0, 512);
        c.int_65 = (int)buffer1[4] * 256 + (int)buffer1[5];
        c.int_66 = (int)buffer1[6] * 256 + (int)buffer1[7];
        this.int_23 = (int)buffer1[8] * 256 + (int)buffer1[9];
        this.int_82 = (int)buffer1[10] * 256 + (int)buffer1[11];
        this.int_18 = (int)buffer1[12] * 256 + (int)buffer1[13];
        this.double_3 = (double)this.int_18 / 2.0;
        byte num1 = 0;
        byte[] numArray1 = new byte[16]
        {
      (byte) 63,
      (byte) 81,
      (byte) 46,
      (byte) 147,
      (byte) 93,
      (byte) 243,
      (byte) 194,
      (byte) 55,
      (byte) 107,
      (byte) 210,
      (byte) 127,
      (byte) 160,
      (byte) 189,
      (byte) 25,
      (byte) 83,
      (byte) 227
        };
        for (int index1 = 114; index1 < 246; ++index1)
        {
            byte index2 = (byte)(index1 % 16);
            num1 += (byte)((uint)buffer1[index1] ^ (uint)numArray1[(int)index2]);
        }
        for (int index = 185; index < 290; ++index)
            num1 += (byte)((uint)buffer1[index] ^ 165U);
        this.byte_42 = (byte)((uint)num1 ^ 90U);
        for (int index3 = 311; index3 < 427; ++index3)
        {
            byte index4 = (byte)(index3 % 16);
            num1 += (byte)((uint)buffer1[index3] ^ (uint)numArray1[(int)index4]);
        }
        for (int index = 430; index < 511; ++index)
            num1 += (byte)((uint)buffer1[index] ^ 90U);
        this.byte_43 = (byte)((uint)num1 ^ 165U);
        byte[] numArray2 = new byte[256];
        byte[] buffer2 = new byte[256];
        bufferedStream.Seek(512L, SeekOrigin.Begin);
        this.arrayList_3.Clear();
        GClass8 gclass8_1 = (GClass8)null;
        int num2 = 0;
        int num3 = 0;
        while (bufferedStream.Read(buffer2, 0, 256) == 256)
        {
            for (uint index = 0; index < 256U; ++index)
                numArray2[index] = (byte)((uint)buffer2[(index ^ (uint)this.byte_43)] - (uint)this.byte_42);
            for (int index = 0; index < 16; ++index)
            {
                if (numArray2[index * 16] == (byte)90)
                {
                    int int_2 = (int)numArray2[index * 16 + 1] * 256 + (int)numArray2[index * 16 + 2];
                    int x = (int)numArray2[index * 16 + 5] * 256 + (int)numArray2[index * 16 + 6];
                    int y = (int)numArray2[index * 16 + 7] * 256 + (int)numArray2[index * 16 + 8];
                    if (num2 == 0)
                    {
                        num2 = 1;
                        gclass8_1 = new GClass8(int_2, this.int_82);
                    }
                    else if (int_2 != num3)
                    {
                        if (gclass8_1.method_0() > 0)
                            this.arrayList_3.Add((object)gclass8_1);
                        gclass8_1 = new GClass8(int_2, this.int_82);
                    }
                    num3 = int_2;
                    gclass8_1.method_7(gclass8_1.method_0(), new Point(x, y));
                    gclass8_1.method_1(gclass8_1.method_0() + 1);
                    if (gclass8_1.method_0() >= this.int_82)
                    {
                        this.arrayList_3.Add((object)gclass8_1);
                        gclass8_1 = new GClass8(int_2, this.int_82);
                    }
                }
            }
        }
        if (num2 == 1 && gclass8_1.method_0() > 0)
            this.arrayList_3.Add((object)gclass8_1);
        bufferedStream.Flush();
        bufferedStream.Close();
        fileStream.Close();
        if (c.int_65 < 500 && c.int_66 < 400)
        {
            int num4 = 500 / c.int_65;
            int num5 = 400 / c.int_66;
            int num6 = num4 > num5 ? num5 : num4;
            this.int_24 = c.int_65 * num6;
            this.int_25 = c.int_66 * num6;
        }
        else
        {
            this.int_24 = c.int_65;
            this.int_25 = c.int_66;
        }
        this.int_41 = 0;
        this.int_42 = 0;
        foreach (GClass8 gclass8_2 in this.arrayList_3)
        {
            this.int_41 += gclass8_2.method_0();
            if (this.int_42 < gclass8_2.method_0())
                this.int_42 = gclass8_2.method_0();
        }
        int num7 = 0;
        foreach (GClass8 gclass8_3 in this.arrayList_3)
        {
            if (gclass8_3.method_0() > num7)
                num7 = gclass8_3.method_0();
        }
        if (c.int_2 == 9)
            this.int_82 = num7 <= 1024 ? 1024 : 2048;
        else if (c.int_2 == 13 || c.int_2 == 32 || c.int_2 == 47 || c.int_2 == 52)
            this.int_82 = num7 <= 1536 ? (num7 <= 1024 ? (num7 <= 512 ? 512 : 1024) : 1536) : 2048;
        switch (c.int_2)
        {
            case 101:
                this.int_82 = 256;
                break;
            case 103:
                this.int_82 = 512;
                break;
        }
        if (c.int_2 == 2 || c.int_2 == 49 || c.int_2 == 16 || c.int_2 == 110 || c.int_2 == 83)
        {
            if (!c.bool_1)
            {
                int num8 = 0;
                foreach (GClass8 gclass8_4 in this.arrayList_3)
                {
                    if (gclass8_4.method_0() > num8)
                        num8 = gclass8_4.method_0();
                }
                c.int_74 = num8 % 128 != 0 ? (num8 / 128 + 1) * 128 : num8 / 128 * 128;
                this.int_82 = c.int_74;
                this.method_26(11, c.int_74.ToString());
            }
            else
            {
                c.int_74 = 170;
                this.int_82 = c.int_74;
                this.method_26(11, c.int_74.ToString());
            }
            this.byte_29 = (byte)(this.int_82 / 128);
            if (this.byte_29 == (byte)1)
                c.int_3 = 30;
            else if (this.byte_29 == (byte)2)
                c.int_3 = 29;
            else if (this.byte_29 == (byte)3)
                c.int_3 = 20;
            else if (this.byte_29 == (byte)4)
                c.int_3 = 14;
            if (c.int_2 == 16 && !c.bool_1)
            {
                c.int_74 = 512;
                this.int_82 = c.int_74;
                this.method_26(11, c.int_74.ToString());
            }
            this.int_62 = this.int_82 * 24 / 1024;
            this.int_63 = this.int_82 * 24;
            c.smethod_1(c.int_3);
            this.method_26(12, c.smethod_0().ToString());
            if (c.bool_1)
            {
                this.int_62 = 4;
                this.int_63 = 4096;
                this.byte_29 = (byte)0;
                c.int_3 = 30;
                switch (c.int_2)
                {
                    case 2:
                    case 49:
                        this.int_39 = 4096;
                        break;
                    case 16:
                        this.int_39 = 4096;
                        break;
                    case 83:
                    case 110:
                        this.int_39 = 4096 * (this.int_23 >= 8 ? this.int_23 / c.int_75 : 1);
                        break;
                }
            }
        }
        this.int_39 = this.int_23 * this.int_82 * 3;
        if (c.int_2 == 201)
            this.int_39 = 16384;
        this.byte_37 = new byte[this.int_39];
        this.byte_38 = new byte[this.int_39];
        this.byte_40 = new byte[this.int_39];
        for (int index = 0; index < this.int_39; ++index)
            this.byte_37[index] = (byte)0;
        this.udpClient_0.Client.SendBufferSize = this.int_39;
        this.progressBar_0.Visible = false;
        this.progressBar_0.Enabled = false;
        if (!this.bool_23)
        {
            if (c.useEnglishLanguage)
                this.ShowMessage(Module.a("\uF8AB욭햯銱삳\uD9B5첷\uDBB9킻麽꺿럁꧃꓅귇룉\uECCBꇍ뛏\uF2D1飓鏕鳗꧙ﳛꯝ鏟蟡胣웥臧蓩쳫髭飯鯱蟳훵裷裹鏻铽旿愁瀃★愇礉㘋", int_0) + this.int_41.ToString());
            else
                this.ShowMessage(Module.a("\uFFF4\uE3FF嗲맋駽쟤쟸鋌㫵ꑂ", int_0) + this.int_41.ToString() + Module.a("蛥\uE2AD\uF5AF\uF6B1\uDBC3띊", int_0));
        }
        c.int_78 = 0;
        this.method_26(14, c.int_78.ToString());
        this.method_13();
        Bitmap bitmap = new Bitmap(this.panel_0.Width, this.panel_0.Height);
        Graphics graphics1 = Graphics.FromImage((Image)bitmap);
        IntPtr hdc1 = graphics1.GetHdc();
        Graphics graphics2 = this.panel_0.CreateGraphics();
        IntPtr hdc2 = graphics2.GetHdc();
        c.BitBlt(hdc1, 0, 0, this.panel_0.Width, this.panel_0.Height, hdc2, 0, 0, 13369376);
        graphics2.ReleaseHdc(hdc2);
        graphics1.ReleaseHdc(hdc1);
        string filename = this.string_20 + (object)'\\' + this.string_22 + Module.a("ӹ闘狼헀骳풵햷쪹", int_0);
        if (this.image_1 != null)
            this.image_1.Dispose();
        bitmap.Save(filename, ImageFormat.Bmp);
        this.image_1 = Image.FromFile(filename);
        return 0;
    }

    private int method_11()
    {
        int int_0 = 2;
        this.double_4 = 3.4028234663852886E+38;
        this.double_5 = 3.4028234663852886E+38;
        this.double_6 = -3.4028234663852886E+38;
        this.double_7 = -3.4028234663852886E+38;
        foreach (PointF pointF in this.arrayList_1)
        {
            if ((double)pointF.X < this.double_4)
                this.double_4 = (double)pointF.X;
            if ((double)pointF.Y < this.double_5)
                this.double_5 = (double)pointF.Y;
            if ((double)pointF.X > this.double_6)
                this.double_6 = (double)pointF.X;
            if ((double)pointF.Y > this.double_7)
                this.double_7 = (double)pointF.Y;
        }
        c.int_65 = (int)(this.double_6 - this.double_4);
        c.int_66 = (int)(this.double_7 - this.double_5);
        c.int_65 += this.int_18;
        c.int_66 += this.int_18;
        this.double_6 = (double)c.int_65;
        this.double_7 = (double)c.int_66;
        if (c.int_65 < 500 && c.int_66 < 400)
        {
            int num1 = 500 / c.int_65;
            int num2 = 400 / c.int_66;
            int num3 = num1 > num2 ? num2 : num1;
            this.int_24 = c.int_65 * num3;
            this.int_25 = c.int_66 * num3;
        }
        else
        {
            this.int_24 = c.int_65;
            this.int_25 = c.int_66;
        }
        ++this.int_21;
        if (this.int_21 > 15)
            this.int_21 = 0;
        this.progressBar_0.Value = this.int_21;
        if (c.int_65 <= 8050 && c.int_66 <= 6050)
        {
            PointF[] pointFArray1 = new PointF[this.arrayList_1.Count];
            int count1 = this.arrayList_1.Count;
            for (int index = 0; index < this.arrayList_1.Count; ++index)
            {
                float x = ((PointF)this.arrayList_1[index]).X;
                float y = ((PointF)this.arrayList_1[index]).Y;
                pointFArray1[index].X = x - (float)this.double_4;
                pointFArray1[index].Y = y - (float)this.double_5;
            }
            this.arrayList_1.Clear();
            for (int index = 0; index < count1; ++index)
                this.arrayList_1.Add((object)pointFArray1[index]);
            int count2 = this.arrayList_0.Count;
            PointF[] pointFArray2 = new PointF[count2];
            PointF[] pointFArray3 = new PointF[count2];
            for (int index = 0; index < count2; ++index)
            {
                pointFArray2[index].X = ((GClass7)this.arrayList_0[index]).method_0().X - (float)this.double_4;
                pointFArray2[index].Y = ((GClass7)this.arrayList_0[index]).method_0().Y - (float)this.double_5;
                pointFArray3[index].X = ((GClass7)this.arrayList_0[index]).method_2().X - (float)this.double_4;
                pointFArray3[index].Y = ((GClass7)this.arrayList_0[index]).method_2().Y - (float)this.double_5;
            }
            this.arrayList_0.Clear();
            for (int index = 0; index < count2; ++index)
                this.arrayList_0.Add((object)new GClass7(pointFArray2[index], pointFArray3[index]));
            int count3 = this.arrayList_2.Count;
            PointF[] pointFArray4 = new PointF[count3];
            string[] strArray = new string[count3];
            for (int index = 0; index < count3; ++index)
            {
                pointFArray4[index].X = ((GClass2)this.arrayList_2[index]).method_2().X - (float)this.double_4;
                pointFArray4[index].Y = ((GClass2)this.arrayList_2[index]).method_2().Y - (float)this.double_5;
                strArray[index] = ((GClass2)this.arrayList_2[index]).method_0();
            }
            this.arrayList_2.Clear();
            for (int index = 0; index < count3; ++index)
                this.arrayList_2.Add((object)new GClass2(pointFArray4[index], strArray[index]));
            return this.method_8();
        }
        if (c.useEnglishLanguage)
            this.ShowMessage("At the current resolution, the layout canvas size in AutoCAD cannot exceed 8000*6000, and the current canvas size is" + c.int_65.ToString() + "*" + c.int_66.ToString() + ",Therefore, this software cannot handle it, please reduce the canvas size!");
//        this.ShowMessage(Module.a("\uF8A7용즫쾭쎯ힱ钳쒵\uDDB7\uDEB9즻\uDDBDꖿ\uE2C1냃껅귇\uEAC9꿋꿍뻏ꓑ뗓ꗕ\uF8D7꧙뗛ꓝ藟컡쓣蟥鯧쫩駫胭铯韱蛳훵賷鋹駻\uDEFD揿省瘃琅洇搉砋⸍戏眑朓礕琗漙栛眝伟䰡ࠣإ尧䈩䤫อ匯匱娳䀵夷䤹᰻䴽⤿㡁⅃晅❇ⱉ汋ཌྷ╏♑㭓ᕕᥗṙ籛\u325Dş᭡ୣ፥ᱧ䩩Ὣ٭Ὧݱᡳት塷\u1879\u197B幽\uEE7F\uED81ꒃ\uEB85\uE787\uF889\uE98B꺍\uE48F晴\uF593\uF895뢗ꊙ겛꺝邟袡銣隥颧骩肫청얯욱钳습킷\uDFB9鲻\uDFBDꎿ뛁뇃\uA7C5\uA4C7\uEAC9꿋꿍뻏ꓑ뗓ꗕ\uF8D7꧙뗛ꓝ藟싡諣觥\u9FE7쫩藫鷭", int_0) + c.int_65.ToString() + Module.a("芧", int_0) + c.int_66.ToString());
        else
            this.ShowMessage("在当前分辨率下,AutoCAD中布局画布大小不能超过8000*6000,而当前画布大小为" + c.int_65.ToString() + "*" + c.int_66.ToString() + ",所以本软件无法处理,请缩小画布！");
//        this.ShowMessage(Module.a("胰臨\uE1F9\uA8FFᠠ㗂뿽骵醴쾹좻톽莿菁胃\uEB8B쮙誕\uF7BE춓\uF796\uDD8D\uD99D⭕嵚ᵖ\uE4DB\uEEDD탟틡컣탥\uD8E7\uDAE9\uDCEB십ﱯꆮ릡춀ﮩ\uDDA0\uF3A7쒳", int_0) + c.int_65.ToString() + Module.a("芧", int_0) + c.int_66.ToString() + Module.a("蒧\uEACB䧥苊\uDF20䓿哖揙볮볍邻䤶\uE9C0춝ﾶ얛줸", int_0));
        this.progressBar_0.Visible = false;
        this.progressBar_0.Enabled = false;
        return 1;
    }

    private void method_12()
    {
//        int int_0 = 6;
        int num1 = 8050 / c.int_65;
        int num2 = 6050 / c.int_66;
        c.int_76 = num1 > num2 ? num2 : num1;
        if (this.bool_21)
        {
            int num3 = 200 / c.int_65;
            int num4 = 150 / c.int_66;
            int num5 = num3 > num4 ? num4 : num3;
            this.int_24 = c.int_65 * num5;
            this.int_25 = c.int_66 * num5;
        }
        int num6 = this.int_24 / c.int_65;
        int num7 = this.int_25 / c.int_66;
        int num8 = num6 > num7 ? num7 : num6;
        c.int_77 = num8;
        if (c.int_78 != 0)
        {
            num8 = c.int_78;
        }
        else
        {
            c.int_78 = num8;
            this.method_26(14, c.int_78.ToString());
        }
        this.int_85 = num8;
        this.int_86 = this.int_85;
        this.int_67 = c.int_65 * this.int_85;
        this.int_68 = c.int_66 * this.int_85;
        if (this.int_67 < 1 || this.int_68 < 1)
        {
            this.int_67 = 300;
            this.int_68 = 200;
        }
        if (this.int_67 > c.int_71)
        {
            this.hscrollBar_0.Enabled = true;
            this.hscrollBar_0.Minimum = 0;
            this.hscrollBar_0.Maximum = (this.int_67 - c.int_71) / 6 + 2;
            if (this.hscrollBar_0.Value >= this.hscrollBar_0.Maximum)
                this.hscrollBar_0.Value = this.hscrollBar_0.Maximum;
        }
        else
            this.hscrollBar_0.Enabled = false;
        if (this.int_68 > c.int_72)
        {
            this.vscrollBar_0.Enabled = true;
            this.vscrollBar_0.Minimum = 0;
            this.vscrollBar_0.Maximum = (this.int_68 - c.int_72) / 6 + 2;
            if (this.vscrollBar_0.Value >= this.vscrollBar_0.Maximum)
                this.vscrollBar_0.Value = this.vscrollBar_0.Maximum;
        }
        else
            this.vscrollBar_0.Enabled = false;
        this.panel_0.Size = new Size(this.int_67, this.int_68);
        c.gclass1_0 = new GClass1((Control)this.panel_0);
        Rectangle rectangle_2 = new Rectangle(0, 0, this.panel_0.Width, this.panel_0.Height);
        Rectangle rectangle_3 = new Rectangle(0, 0, this.panel_0.Width, this.panel_0.Height);
        this.gclass0_2 = new GClass0(c.gclass1_0.method_1(), rectangle_2, rectangle_3);
        this.gclass0_2.method_12().ColorFill(Color.FromArgb(0, 0, 0));
        this.gclass0_5 = new GClass0(c.gclass1_0.method_1(), GEnum0.const_1, rectangle_2, rectangle_3);
        this.gclass0_5.method_12().ColorFill(Color.FromArgb(0, 0, 0));
        this.gclass0_3 = new GClass0(c.gclass1_0.method_1(), rectangle_2, rectangle_3);
        this.gclass0_3.method_12().ColorFill(Color.FromArgb(0, 0, 0));
        c.gclass0_4 = new GClass0(c.gclass1_0.method_1(), rectangle_2, rectangle_3);
        c.gclass0_4.method_12().ColorFill(Color.FromArgb(0, 0, 0));
        int num9 = 0;
        while (num9 < 4)
            ++num9;
        rectangle_2 = new Rectangle(0, 0, c.int_65, c.int_66);
        rectangle_3 = new Rectangle(0, 0, this.panel_0.Width, this.panel_0.Height);
        this.gclass0_7 = new GClass0(c.gclass1_0.method_1(), rectangle_2, rectangle_3);
        this.gclass0_7.method_12().ColorFill(Color.FromArgb(0, 0, 0));
        c.gclass0_8 = new GClass0(c.gclass1_0.method_1(), GEnum0.const_1, rectangle_2, rectangle_3);
        c.gclass0_8.method_12().ColorFill(Color.FromArgb(0, 0, 0));
        c.gclass0_8.method_12().SetColorKey(ColorKeyFlags.SourceDraw, new ColorKey()
        {
            ColorSpaceLowValue = 0,
            ColorSpaceHighValue = 0
        });
        c.int_58 = c.int_65;
        c.int_59 = c.int_65;
        c.int_60 = c.int_65;
        c.int_61 = c.int_66;
        if (this.a_0 == null)
        {
            this.a_0 = new a();
            this.a_0.Hide();
        }
        this.int_43 = new int[this.int_41];
        this.int_51 = new int[this.int_41];
        this.int_44 = new int[this.int_41];
        this.bool_49 = this.int_41 > this.int_52;
        uint index1 = 0;
        LockedData lockedData1 = this.gclass0_3.method_12().Lock(LockFlags.ReadOnly);
        lockedData1.Data.Position = 0L;
        int num10 = lockedData1.Pitch;
        LockedData lockedData2 = this.gclass0_7.method_12().Lock(LockFlags.WriteOnly);
        lockedData2.Data.Position = 0L;
        this.int_90 = lockedData2.Pitch;
        int num11 = this.int_86 / 2;
        Point point;
        for (int index2 = 0; index2 < this.arrayList_3.Count; ++index2)
        {
            this.int_91 = ((GClass8)this.arrayList_3[index2]).method_4() * this.int_82 * 3;
            for (int int_2 = 0; int_2 < ((GClass8)this.arrayList_3[index2]).method_0(); ++int_2)
            {
                point = ((GClass8)this.arrayList_3[index2]).method_6(int_2);
                this.int_87 = point.X;
                this.int_88 = ((GClass8)this.arrayList_3[index2]).method_6(int_2).Y;
                int num12 = this.int_87 * this.int_86 + num11;
                int num13 = (this.int_88 * this.int_86 + num11) * num10 + num12 * 4;
                this.int_43[index1] = num13;
                this.int_92 = this.int_91 + int_2 * 3;
                this.int_51[index1] = this.int_92;
                if (this.bool_49)
                {
                    this.int_89 = this.int_88 * this.int_90 + this.int_87 * 4;
                    this.int_44[index1] = this.int_89;
                }
                ++index1;
            }
        }
        this.gclass0_7.method_12().Unlock();
        this.gclass0_3.method_12().Unlock();
        int num14 = this.int_18 * this.int_85;
        if (num14 == 8)
            num14 = 7;
        if (this.int_41 > this.int_52)
            num14 = 1;
        if (num14 > 4)
        {
            this.gclass0_2.method_12().ForeColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue);
            this.gclass0_2.method_12().DrawWidth = num14 / 2;
            foreach (GClass8 gclass8 in this.arrayList_3)
            {
                for (int int_2 = 0; int_2 < gclass8.method_0(); ++int_2)
                {
                    this.color_1 = this.color_0[gclass8.method_4() % 10];
                    this.gclass0_2.method_12().ForeColor = this.color_1;
                    int x = gclass8.method_6(int_2).X * this.int_85 + num14 / 2;
                    int y = gclass8.method_6(int_2).Y * this.int_85 + num14 / 2;
                    this.gclass0_2.method_12().DrawCircle(x, y, num14 / 4);
                }
            }
        }
        else
        {
            switch (num14)
            {
                case 1:
                    this.gclass0_2.method_12().ForeColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue);
                    this.gclass0_2.method_12().DrawWidth = 1;
                    IEnumerator enumerator1 = this.arrayList_3.GetEnumerator();
                    try
                    {
                        while (enumerator1.MoveNext())
                        {
                            GClass8 current = (GClass8)enumerator1.Current;
                            for (int int_2 = 0; int_2 < current.method_0(); ++int_2)
                            {
                                this.color_1 = this.color_0[current.method_4() % 10];
                                this.gclass0_2.method_12().ForeColor = this.color_1;
                                int x1 = current.method_6(int_2).X * this.int_85;
                                point = current.method_6(int_2);
                                int num15 = point.Y * this.int_85;
                                this.gclass0_2.method_12().DrawLine(x1, num15, x1 + 1, num15);
                            }
                        }
                        break;
                    }
                    finally
                    {
                        if (enumerator1 is IDisposable disposable)
                            disposable.Dispose();
                    }
                case 2:
                    this.gclass0_2.method_12().ForeColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue);
                    this.gclass0_2.method_12().DrawWidth = 1;
                    IEnumerator enumerator2 = this.arrayList_3.GetEnumerator();
                    try
                    {
                        while (enumerator2.MoveNext())
                        {
                            GClass8 current = (GClass8)enumerator2.Current;
                            for (int int_2 = 0; int_2 < current.method_0(); ++int_2)
                            {
                                this.color_1 = this.color_0[current.method_4() % 10];
                                this.gclass0_2.method_12().ForeColor = this.color_1;
                                int num16 = current.method_6(int_2).X * this.int_85;
                                int num17 = current.method_6(int_2).Y * this.int_85;
                                this.gclass0_2.method_12().DrawLine(num16 + 1, num17, num16 + 2, num17);
                            }
                        }
                        break;
                    }
                    finally
                    {
                        if (enumerator2 is IDisposable disposable)
                            disposable.Dispose();
                    }
                case 3:
                    this.gclass0_2.method_12().ForeColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue);
                    this.gclass0_2.method_12().DrawWidth = 1;
                    IEnumerator enumerator3 = this.arrayList_3.GetEnumerator();
                    try
                    {
                        while (enumerator3.MoveNext())
                        {
                            GClass8 current = (GClass8)enumerator3.Current;
                            for (int int_2 = 0; int_2 < current.method_0(); ++int_2)
                            {
                                this.color_1 = this.color_0[current.method_4() % 10];
                                this.gclass0_2.method_12().ForeColor = this.color_1;
                                int num18 = current.method_6(int_2).X * this.int_85;
                                int num19 = current.method_6(int_2).Y * this.int_85;
                                this.gclass0_2.method_12().DrawLine(num18 + 1, num19, num18 + 3, num19);
                                this.gclass0_2.method_12().DrawLine(num18 + 1, num19 + 1, num18 + 3, num19 + 1);
                            }
                        }
                        break;
                    }
                    finally
                    {
                        if (enumerator3 is IDisposable disposable)
                            disposable.Dispose();
                    }
                case 4:
                    this.gclass0_2.method_12().ForeColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue);
                    this.gclass0_2.method_12().DrawWidth = 1;
                    IEnumerator enumerator4 = this.arrayList_3.GetEnumerator();
                    try
                    {
                        while (enumerator4.MoveNext())
                        {
                            GClass8 current = (GClass8)enumerator4.Current;
                            for (int int_2 = 0; int_2 < current.method_0(); ++int_2)
                            {
                                this.color_1 = this.color_0[current.method_4() % 10];
                                this.gclass0_2.method_12().ForeColor = this.color_1;
                                int num20 = current.method_6(int_2).X * this.int_85;
                                int num21 = current.method_6(int_2).Y * this.int_85;
                                this.gclass0_2.method_12().DrawLine(num20 + 1, num21, num20 + 4, num21);
                                this.gclass0_2.method_12().DrawLine(num20 + 1, num21 + 1, num20 + 4, num21 + 1);
                                this.gclass0_2.method_12().DrawLine(num20 + 1, num21 + 2, num20 + 4, num21 + 2);
                            }
                        }
                        break;
                    }
                    finally
                    {
                        if (enumerator4 is IDisposable disposable)
                            disposable.Dispose();
                    }
            }
        }
        try
        {
            this.gclass0_5.method_13(this.gclass0_2);
        }
        catch (Exception ex)
        {
            this.ShowMessage("Directx Error: " + ex.Message);
//            this.ShowMessage(Module.a("\uE8AB잭슯ힱힳ습삷骹僚첽늿귁뛃ﳅ\uE8C7", int_0) + ex.Message);
            return;
        }
        this.method_15();
        if (this.panel_0.Width <= 924 && this.panel_0.Height <= 668)
        {
            Bitmap bitmap = new Bitmap(this.panel_0.Width, this.panel_0.Height);
            Graphics graphics1 = Graphics.FromImage((Image)bitmap);
            IntPtr hdc1 = graphics1.GetHdc();
            Graphics graphics2 = this.panel_0.CreateGraphics();
            IntPtr hdc2 = graphics2.GetHdc();
            c.BitBlt(hdc1, 0, 0, this.panel_0.Width, this.panel_0.Height, hdc2, 0, 0, 13369376);
            graphics2.ReleaseHdc(hdc2);
            graphics1.ReleaseHdc(hdc1);
            //   this.string_20 + (object) '\\' + this.string_22 + Module.a("ӹ闘狼헀\uEBB3蒵隷\uD8B9톻캽", int_0);
            if (this.image_1 != null)
                this.image_1.Dispose();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save as..."; //Module.a("ﾫ쾭욯ힱ钳ힵ쮷钹銻邽", int_0);
            saveFileDialog.AddExtension = true;
            saveFileDialog.DefaultExt = "bmp"; //Module.a("캫쎭삯", int_0);
            saveFileDialog.Filter = "BMP(*.bmp)|*.bmp|All File(*.*)|*.*"; //Module.a("\uEEAB\uE3AD\uE0AF骱麳颵\uDAB7ힹ첻鞽벿\uE8C1\uEAC3꓅ꗇ뫉냋迍볏뻑\uF4D3郕뇗뛙맛\uF6DD쫟쳡컣쿥铧샩싫쓭", int_0);
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;
            string fileName = saveFileDialog.FileName;
            bitmap.Save(fileName, ImageFormat.Bmp);
        }
        else if (c.useEnglishLanguage)
            this.ShowMessage("The picture too big, please try again after narrowing picture!");
        //           this.ShowMessage(Module.a("\uF8AB욭햯銱쒳\uDFB5\uDBB7캹즻첽ꖿ\uE2C1냃꧅\uA7C7\uEAC9껋\uA7CD럏ﻑ\uF4D3ꛕ듗뿙뷛귝藟싡郣铥釧쫩跫觭釯鯱髳훵駷鳹裻鯽狿∁樃朅稇砉挋礍礏簑猓㘕栗猙缛樝唟倡䄣ܥ", int_0));
        else
            this.ShowMessage("画面太大,请缩小画面后再试！");
//        this.ShowMessage(Module.a("韞찺髶门颳䄾釈뗥蟎\uDC2A컫侐ᅈ윺", int_0));
    }

    private void method_13()
    {
 //       int int_0 = 8;
        if (c.int_65 < 1 || c.int_66 < 1)
            return;
        int num1 = 8050 / c.int_65;
        int num2 = 6050 / c.int_66;
        c.int_76 = num1 > num2 ? num2 : num1;
        if (this.bool_21)
        {
            int num3 = 200 / c.int_65;
            int num4 = 150 / c.int_66;
            int num5 = num3 > num4 ? num4 : num3;
            this.int_24 = c.int_65 * num5;
            this.int_25 = c.int_66 * num5;
        }
        int num6 = this.int_24 / c.int_65;
        int num7 = this.int_25 / c.int_66;
        int num8 = num6 > num7 ? num7 : num6;
        c.int_77 = num8;
        if (c.int_78 != 0)
        {
            num8 = c.int_78;
        }
        else
        {
            c.int_78 = num8;
            this.method_26(14, c.int_78.ToString());
        }
        this.int_85 = num8;
        this.int_86 = this.int_85;
        this.int_67 = c.int_65 * this.int_85;
        this.int_68 = c.int_66 * this.int_85;
        if (this.int_67 < 1 || this.int_68 < 1)
        {
            this.int_67 = 300;
            this.int_68 = 200;
        }
        if (this.int_67 > c.int_71)
        {
            this.hscrollBar_0.Enabled = true;
            this.hscrollBar_0.Minimum = 0;
            this.hscrollBar_0.Maximum = (this.int_67 - c.int_71) / 6 + 2;
            if (this.hscrollBar_0.Value >= this.hscrollBar_0.Maximum)
                this.hscrollBar_0.Value = this.hscrollBar_0.Maximum;
        }
        else
            this.hscrollBar_0.Enabled = false;
        if (this.int_68 > c.int_72)
        {
            this.vscrollBar_0.Enabled = true;
            this.vscrollBar_0.Minimum = 0;
            this.vscrollBar_0.Maximum = (this.int_68 - c.int_72) / 6 + 2;
            if (this.vscrollBar_0.Value >= this.vscrollBar_0.Maximum)
                this.vscrollBar_0.Value = this.vscrollBar_0.Maximum;
        }
        else
            this.vscrollBar_0.Enabled = false;
        this.panel_0.Size = new Size(this.int_67, this.int_68);
        c.gclass1_0 = new GClass1((Control)this.panel_0);
        Rectangle rectangle_2 = new Rectangle(0, 0, this.panel_0.Width, this.panel_0.Height);
        Rectangle rectangle_3 = new Rectangle(0, 0, this.panel_0.Width, this.panel_0.Height);
        this.gclass0_2 = new GClass0(c.gclass1_0.method_1(), rectangle_2, rectangle_3);
        this.gclass0_2.method_12().ColorFill(Color.FromArgb(0, 0, 0));
        this.gclass0_5 = new GClass0(c.gclass1_0.method_1(), GEnum0.const_1, rectangle_2, rectangle_3);
        this.gclass0_5.method_12().ColorFill(Color.FromArgb(0, 0, 0));
        this.gclass0_3 = new GClass0(c.gclass1_0.method_1(), rectangle_2, rectangle_3);
        this.gclass0_3.method_12().ColorFill(Color.FromArgb(0, 0, 0));
        c.gclass0_4 = new GClass0(c.gclass1_0.method_1(), rectangle_2, rectangle_3);
        c.gclass0_4.method_12().ColorFill(Color.FromArgb(0, 0, 0));
        rectangle_2 = new Rectangle(0, 0, this.int_12, this.int_13);
        rectangle_3 = new Rectangle(0, 0, this.panel_0.Width, this.panel_0.Height);
        this.gclass0_1 = new GClass0(c.gclass1_0.method_1(), rectangle_2, rectangle_3);
        rectangle_2 = new Rectangle(0, 0, c.int_65, c.int_66);
        rectangle_3 = new Rectangle(0, 0, this.panel_0.Width, this.panel_0.Height);
        this.gclass0_7 = new GClass0(c.gclass1_0.method_1(), rectangle_2, rectangle_3);
        this.gclass0_7.method_12().ColorFill(Color.FromArgb(0, 0, 0));
        c.gclass0_8 = new GClass0(c.gclass1_0.method_1(), GEnum0.const_1, rectangle_2, rectangle_3);
        c.gclass0_8.method_12().ColorFill(Color.FromArgb(0, 0, 0));
        c.gclass0_8.method_12().SetColorKey(ColorKeyFlags.SourceDraw, new ColorKey()
        {
            ColorSpaceLowValue = 0,
            ColorSpaceHighValue = 0
        });
        c.int_58 = c.int_65;
        c.int_59 = c.int_65;
        c.int_60 = c.int_65;
        c.int_61 = c.int_66;
        if (this.a_0 == null)
        {
            this.a_0 = new a();
            this.a_0.Hide();
        }
        this.a_0.trackBar_1.Maximum = c.int_60;
        this.a_0.trackBar_2.Maximum = c.int_61;
        this.int_43 = new int[this.int_41];
        this.int_51 = new int[this.int_41];
        this.int_44 = new int[this.int_41];
        this.bool_49 = this.int_41 > this.int_52;
        uint index1 = 0;
        LockedData lockedData1 = this.gclass0_3.method_12().Lock(LockFlags.ReadOnly);
        lockedData1.Data.Position = 0L;
        int num9 = lockedData1.Pitch;
        LockedData lockedData2 = this.gclass0_7.method_12().Lock(LockFlags.WriteOnly);
        lockedData2.Data.Position = 0L;
        this.int_90 = lockedData2.Pitch;
        int num10 = this.int_86 / 2;
        for (int index2 = 0; index2 < this.arrayList_3.Count; ++index2)
        {
            this.int_91 = ((GClass8)this.arrayList_3[index2]).method_4() * this.int_82 * 3;
            for (int int_2 = 0; int_2 < ((GClass8)this.arrayList_3[index2]).method_0(); ++int_2)
            {
                this.int_87 = ((GClass8)this.arrayList_3[index2]).method_6(int_2).X;
                this.int_88 = ((GClass8)this.arrayList_3[index2]).method_6(int_2).Y;
                int num11 = this.int_87 * this.int_86 + num10;
                int num12 = (this.int_88 * this.int_86 + num10) * num9 + num11 * 4;
                this.int_43[index1] = num12;
                this.int_92 = this.int_91 + int_2 * 3;
                this.int_51[index1] = this.int_92;
                if (this.bool_49)
                {
                    this.int_89 = this.int_88 * this.int_90 + this.int_87 * 4;
                    this.int_44[index1] = this.int_89;
                }
                ++index1;
            }
        }
        this.gclass0_7.method_12().Unlock();
        this.gclass0_3.method_12().Unlock();
        int num13 = this.int_18 * this.int_85;
        if (num13 == 8)
            num13 = 7;
        if (this.int_41 > this.int_52)
            num13 = 1;
        Point point1 = new Point(0, 0);
        if (num13 > 4)
        {
            this.gclass0_2.method_12().ForeColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue);
            this.gclass0_2.method_12().DrawWidth = num13 / 2;
            foreach (GClass8 gclass8 in this.arrayList_3)
            {
                for (int int_2 = 0; int_2 < gclass8.method_0(); ++int_2)
                {
                    if (this.bool_16)
                    {
                        this.gclass0_2.method_12().ForeColor = !this.bool_15 ? (this.int_16 != gclass8.method_4() || this.int_17 != int_2 ? Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue) : Color.FromArgb((int)byte.MaxValue, 0, 0)) : (this.int_16 != gclass8.method_4() ? Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue) : Color.FromArgb((int)byte.MaxValue, 0, 0));
                    }
                    else
                    {
                        this.color_1 = this.color_0[gclass8.method_4() % 10];
                        this.gclass0_2.method_12().ForeColor = this.color_1;
                    }
                    int x = gclass8.method_6(int_2).X * this.int_85 + num13 / 2;
                    int y = gclass8.method_6(int_2).Y * this.int_85 + num13 / 2;
                    this.gclass0_2.method_12().DrawCircle(x, y, num13 / 4);
                }
            }
            this.gclass0_2.method_12().ForeColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue);
            foreach (PointF pointF in this.arrayList_1)
            {
                point1.X = (int)pointF.X;
                point1.Y = (int)pointF.Y;
                int x = point1.X * this.int_85 + num13 / 2;
                int y = point1.Y * this.int_85 + num13 / 2;
                this.gclass0_2.method_12().DrawCircle(x, y, num13 / 4);
            }
        }
        else
        {
            switch (num13)
            {
                case 1:
                    this.gclass0_2.method_12().ForeColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue);
                    this.gclass0_2.method_12().DrawWidth = 1;
                    foreach (GClass8 gclass8 in this.arrayList_3)
                    {
                        for (int int_2 = 0; int_2 < gclass8.method_0(); ++int_2)
                        {
                            if (this.bool_16)
                            {
                                this.gclass0_2.method_12().ForeColor = !this.bool_15 ? (this.int_16 != gclass8.method_4() || this.int_17 != int_2 ? Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue) : Color.FromArgb((int)byte.MaxValue, 0, 0)) : (this.int_16 != gclass8.method_4() ? Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue) : Color.FromArgb((int)byte.MaxValue, 0, 0));
                            }
                            else
                            {
                                this.color_1 = this.color_0[gclass8.method_4() % 10];
                                this.gclass0_2.method_12().ForeColor = this.color_1;
                            }
                            Point point2 = gclass8.method_6(int_2);
                            int x1 = point2.X * this.int_85;
                            point2 = gclass8.method_6(int_2);
                            int num14 = point2.Y * this.int_85;
                            this.gclass0_2.method_12().DrawLine(x1, num14, x1 + 1, num14);
                        }
                    }
                    this.gclass0_2.method_12().ForeColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue);
                    IEnumerator enumerator1 = this.arrayList_1.GetEnumerator();
                    try
                    {
                        while (enumerator1.MoveNext())
                        {
                            PointF current = (PointF)enumerator1.Current;
                            point1.X = (int)current.X;
                            point1.Y = (int)current.Y;
                            int x = point1.X * this.int_85 + num13 / 2;
                            int y = point1.Y * this.int_85 + num13 / 2;
                            this.gclass0_2.method_12().DrawCircle(x, y, num13 / 4);
                        }
                        break;
                    }
                    finally
                    {
                        if (enumerator1 is IDisposable disposable)
                            disposable.Dispose();
                    }
                case 2:
                    this.gclass0_2.method_12().ForeColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue);
                    this.gclass0_2.method_12().DrawWidth = 1;
                    foreach (GClass8 gclass8 in this.arrayList_3)
                    {
                        for (int int_2 = 0; int_2 < gclass8.method_0(); ++int_2)
                        {
                            if (this.bool_16)
                            {
                                this.gclass0_2.method_12().ForeColor = !this.bool_15 ? (this.int_16 != gclass8.method_4() || this.int_17 != int_2 ? Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue) : Color.FromArgb((int)byte.MaxValue, 0, 0)) : (this.int_16 != gclass8.method_4() ? Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue) : Color.FromArgb((int)byte.MaxValue, 0, 0));
                            }
                            else
                            {
                                this.color_1 = this.color_0[gclass8.method_4() % 10];
                                this.gclass0_2.method_12().ForeColor = this.color_1;
                            }
                            Point point3 = gclass8.method_6(int_2);
                            int num15 = point3.X * this.int_85;
                            point3 = gclass8.method_6(int_2);
                            int num16 = point3.Y * this.int_85;
                            this.gclass0_2.method_12().DrawLine(num15 + 1, num16, num15 + 2, num16);
                        }
                    }
                    this.gclass0_2.method_12().ForeColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue);
                    IEnumerator enumerator2 = this.arrayList_1.GetEnumerator();
                    try
                    {
                        while (enumerator2.MoveNext())
                        {
                            PointF current = (PointF)enumerator2.Current;
                            point1.X = (int)current.X;
                            point1.Y = (int)current.Y;
                            int x = point1.X * this.int_85 + num13 / 2;
                            int y = point1.Y * this.int_85 + num13 / 2;
                            this.gclass0_2.method_12().DrawCircle(x, y, num13 / 4);
                        }
                        break;
                    }
                    finally
                    {
                        if (enumerator2 is IDisposable disposable)
                            disposable.Dispose();
                    }
                case 3:
                    this.gclass0_2.method_12().ForeColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue);
                    this.gclass0_2.method_12().DrawWidth = 1;
                    foreach (GClass8 gclass8 in this.arrayList_3)
                    {
                        for (int int_2 = 0; int_2 < gclass8.method_0(); ++int_2)
                        {
                            if (this.bool_16)
                            {
                                this.gclass0_2.method_12().ForeColor = !this.bool_15 ? (this.int_16 != gclass8.method_4() || this.int_17 != int_2 ? Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue) : Color.FromArgb((int)byte.MaxValue, 0, 0)) : (this.int_16 != gclass8.method_4() ? Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue) : Color.FromArgb((int)byte.MaxValue, 0, 0));
                            }
                            else
                            {
                                this.color_1 = this.color_0[gclass8.method_4() % 10];
                                this.gclass0_2.method_12().ForeColor = this.color_1;
                            }
                            int num17 = gclass8.method_6(int_2).X * this.int_85;
                            int num18 = gclass8.method_6(int_2).Y * this.int_85;
                            this.gclass0_2.method_12().DrawLine(num17 + 1, num18, num17 + 3, num18);
                            this.gclass0_2.method_12().DrawLine(num17 + 1, num18 + 1, num17 + 3, num18 + 1);
                        }
                    }
                    this.gclass0_2.method_12().ForeColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue);
                    IEnumerator enumerator3 = this.arrayList_1.GetEnumerator();
                    try
                    {
                        while (enumerator3.MoveNext())
                        {
                            PointF current = (PointF)enumerator3.Current;
                            point1.X = (int)current.X;
                            point1.Y = (int)current.Y;
                            int x = point1.X * this.int_85 + num13 / 2;
                            int y = point1.Y * this.int_85 + num13 / 2;
                            this.gclass0_2.method_12().DrawCircle(x, y, num13 / 4);
                        }
                        break;
                    }
                    finally
                    {
                        if (enumerator3 is IDisposable disposable)
                            disposable.Dispose();
                    }
                case 4:
                    this.gclass0_2.method_12().ForeColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue);
                    this.gclass0_2.method_12().DrawWidth = 1;
                    foreach (GClass8 gclass8 in this.arrayList_3)
                    {
                        for (int int_2 = 0; int_2 < gclass8.method_0(); ++int_2)
                        {
                            if (this.bool_16)
                            {
                                this.gclass0_2.method_12().ForeColor = !this.bool_15 ? (this.int_16 != gclass8.method_4() || this.int_17 != int_2 ? Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue) : Color.FromArgb((int)byte.MaxValue, 0, 0)) : (this.int_16 != gclass8.method_4() ? Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue) : Color.FromArgb((int)byte.MaxValue, 0, 0));
                            }
                            else
                            {
                                this.color_1 = this.color_0[gclass8.method_4() % 10];
                                this.gclass0_2.method_12().ForeColor = this.color_1;
                            }
                            int num19 = gclass8.method_6(int_2).X * this.int_85;
                            int num20 = gclass8.method_6(int_2).Y * this.int_85;
                            this.gclass0_2.method_12().DrawLine(num19 + 1, num20, num19 + 4, num20);
                            this.gclass0_2.method_12().DrawLine(num19 + 1, num20 + 1, num19 + 4, num20 + 1);
                            this.gclass0_2.method_12().DrawLine(num19 + 1, num20 + 2, num19 + 4, num20 + 2);
                        }
                    }
                    this.gclass0_2.method_12().ForeColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue);
                    IEnumerator enumerator4 = this.arrayList_1.GetEnumerator();
                    try
                    {
                        while (enumerator4.MoveNext())
                        {
                            PointF current = (PointF)enumerator4.Current;
                            point1.X = (int)current.X;
                            point1.Y = (int)current.Y;
                            int x = point1.X * this.int_85 + num13 / 2;
                            int y = point1.Y * this.int_85 + num13 / 2;
                            this.gclass0_2.method_12().DrawCircle(x, y, num13 / 4);
                        }
                        break;
                    }
                    finally
                    {
                        if (enumerator4 is IDisposable disposable)
                            disposable.Dispose();
                    }
            }
        }
        try
        {
            this.gclass0_5.method_13(this.gclass0_2);
        }
        catch (Exception ex)
        {
            this.ShowMessage("Directx Error: " + ex.Message);
//            this.ShowMessage(Module.a("\uEAAD\uD9AF삱톳햵첷승鲻﮽늿냁ꯃ듅\uF2C7\uEAC9", int_0) + ex.Message);
            return;
        }
        lockedData2 = this.gclass0_5.method_12().Lock(LockFlags.NoSystemLock);
        lockedData2.Data.Position = 0L;
        this.int_90 = lockedData2.Pitch;
        for (int index3 = 0; index3 < lockedData2.Height; ++index3)
        {
            for (int index4 = 0; index4 < lockedData2.Width; ++index4)
            {
                this.int_89 = index3 * this.int_90 + index4 * 4;
                lockedData2.Data.Position = (long)this.int_89;
                byte num21 = (byte)lockedData2.Data.ReadByte();
                byte num22 = (byte)lockedData2.Data.ReadByte();
                if ((byte)lockedData2.Data.ReadByte() != (byte)0 || num22 != (byte)0 || num21 != (byte)0)
                {
                    lockedData2.Data.Position = (long)this.int_89;
                    lockedData2.Data.WriteByte(byte.MaxValue);
                    lockedData2.Data.WriteByte(byte.MaxValue);
                    lockedData2.Data.WriteByte(byte.MaxValue);
                    lockedData2.Data.WriteByte((byte)0);
                }
            }
        }
        this.gclass0_5.method_12().Unlock();
        if (c.arrayList_4.Count > 0)
        {
            for (int index5 = 0; index5 < 5; ++index5)
                ((GClass5)c.arrayList_4[c.int_38]).gclass6_0[index5].bool_1 = false;
            c.bool_6 = true;
        }
        this.method_15();
    }

    private void method_14()
    {
        string path = this.string_20 + (object)'\\' + this.string_22 + ".Lxb";//Module.a("覦\uE5A8펪쾬", 1);
        byte[] buffer1 = new byte[512];
        new Random().NextBytes(buffer1);
        FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
        BufferedStream bufferedStream = new BufferedStream((Stream)fileStream);
        byte num1 = 0;
        byte[] numArray1 = new byte[16]
        {
      (byte) 63,
      (byte) 81,
      (byte) 46,
      (byte) 147,
      (byte) 93,
      (byte) 243,
      (byte) 194,
      (byte) 55,
      (byte) 107,
      (byte) 210,
      (byte) 127,
      (byte) 160,
      (byte) 189,
      (byte) 25,
      (byte) 83,
      (byte) 227
        };
        for (int index1 = 114; index1 < 246; ++index1)
        {
            byte index2 = (byte)(index1 % 16);
            num1 += (byte)((uint)buffer1[index1] ^ (uint)numArray1[(int)index2]);
        }
        for (int index = 185; index < 290; ++index)
            num1 += (byte)((uint)buffer1[index] ^ 165U);
        this.byte_42 = (byte)((uint)num1 ^ 90U);
        for (int index3 = 311; index3 < 427; ++index3)
        {
            byte index4 = (byte)(index3 % 16);
            num1 += (byte)((uint)buffer1[index3] ^ (uint)numArray1[(int)index4]);
        }
        for (int index = 430; index < 511; ++index)
            num1 += (byte)((uint)buffer1[index] ^ 90U);
        this.byte_43 = (byte)((uint)num1 ^ 165U);
        buffer1[4] = (byte)(c.int_65 / 256);
        buffer1[5] = (byte)(c.int_65 % 256);
        buffer1[6] = (byte)(c.int_66 / 256);
        buffer1[7] = (byte)(c.int_66 % 256);
        buffer1[8] = (byte)(this.int_23 / 256);
        buffer1[9] = (byte)(this.int_23 % 256);
        buffer1[10] = (byte)(this.int_82 / 256);
        buffer1[11] = (byte)(this.int_82 % 256);
        buffer1[12] = (byte)(this.int_18 / 256);
        buffer1[13] = (byte)(this.int_18 % 256);
        bufferedStream.Write(buffer1, 0, 512);
        int index5 = 0;
        byte[] numArray2 = new byte[256];
        byte[] buffer2 = new byte[256];
        for (int index6 = 0; index6 < 256; ++index6)
            numArray2[index6] = (byte)0;
        for (int index7 = 0; index7 < this.arrayList_3.Count; ++index7)
        {
            for (int int_2 = 0; int_2 < ((GClass8)this.arrayList_3[index7]).method_0(); ++int_2)
            {
                int x = ((GClass8)this.arrayList_3[index7]).method_6(int_2).X;
                int y = ((GClass8)this.arrayList_3[index7]).method_6(int_2).Y;
                int num2 = ((GClass8)this.arrayList_3[index7]).method_4();
                numArray2[index5] = (byte)90;
                int index8 = index5 + 1;
                numArray2[index8] = (byte)(num2 / 256);
                int index9 = index8 + 1;
                numArray2[index9] = (byte)(num2 % 256);
                int index10 = index9 + 1;
                numArray2[index10] = (byte)(int_2 / 256);
                int index11 = index10 + 1;
                numArray2[index11] = (byte)(int_2 % 256);
                int index12 = index11 + 1;
                numArray2[index12] = (byte)(x / 256);
                int index13 = index12 + 1;
                numArray2[index13] = (byte)(x % 256);
                int index14 = index13 + 1;
                numArray2[index14] = (byte)(y / 256);
                int index15 = index14 + 1;
                numArray2[index15] = (byte)(y % 256);
                index5 = index15 + 1 + 7;
                if (index5 == 256)
                {
                    for (uint index16 = 0; index16 < 256U; ++index16)
                        buffer2[index16] = (byte)((uint)numArray2[(index16 ^ (uint)this.byte_43)] + (uint)this.byte_42);
                    bufferedStream.Write(buffer2, 0, 256);
                    index5 = 0;
                    for (int index17 = 0; index17 < 256; ++index17)
                        numArray2[index17] = (byte)0;
                }
            }
        }
        for (uint index18 = 0; index18 < 256U; ++index18)
            buffer2[index18] = (byte)((uint)numArray2[(index18 ^ (uint)this.byte_43)] + (uint)this.byte_42);
        bufferedStream.Write(buffer2, 0, 256);
        bufferedStream.Flush();
        bufferedStream.Close();
        fileStream.Close();
    }

    protected void method_15()
    {
        Rectangle rectangle_2_1 = this.gclass0_2.method_5();
        Rectangle rectangle_2_2 = this.gclass0_2.method_3();
        if (this.int_67 > c.int_71)
        {
            rectangle_2_1.Width = c.int_71;
            rectangle_2_2.Width = c.int_71;
            rectangle_2_1.X = this.hscrollBar_0.Value * 6;
            if (rectangle_2_1.X > this.int_67 - c.int_71)
                rectangle_2_1.X = this.int_67 - c.int_71;
        }
        else
            rectangle_2_1.X = 0;
        if (this.int_68 > c.int_72)
        {
            rectangle_2_1.Height = c.int_72;
            rectangle_2_2.Height = c.int_72;
            rectangle_2_1.Y = this.vscrollBar_0.Value * 6;
            if (rectangle_2_1.Y > this.int_68 - c.int_72)
                rectangle_2_1.Y = this.int_68 - c.int_72;
        }
        else
            rectangle_2_1.Y = 0;
        this.gclass0_2.method_6(rectangle_2_1);
        this.gclass0_2.method_4(rectangle_2_2);
        try
        {
            c.gclass1_0.method_4(this.gclass0_2);
        }
        catch (Exception ex)
        {
            this.method_13();
            return;
        }
        try
        {
            c.gclass1_0.method_5();
        }
        catch
        {
            this.method_13();
        }
    }

    private void menuItem_0_Click(object sender, EventArgs e)
    {
        this.bool_37 = false;
        this.timer_1.Interval = 1000 / c.smethod_0();
        this.timer_1.Enabled = false;
        this.Close();
    }

    private void panel_0_Paint(object sender, PaintEventArgs e)
    {
        if (!c.bool_32)
            return;
        try
        {
            this.method_15();
        }
        catch
        {
        }
    }

    private void method_16()
    {
        int int_0 = 18;
        if (c.bool_55)
            this.gclass0_3.method_12().ColorFill(c.color_2);
        else if (this.int_26 == 0)
        {
            if (this.bool_13)
            {
                this.bufferedStream_0.Seek((long)this.int_15 * (long)this.int_14 + 14L, SeekOrigin.Begin);
                this.bufferedStream_0.Read(this.byte_16, 0, this.int_14);
                for (int index = 0; index < this.int_14; ++index)
                    this.byte_16[index] = (byte)((uint)this.byte_16[index] << 1);
                LockedData lockedData = this.gclass0_1.method_12().Lock(LockFlags.WriteOnly);
                lockedData.Data.Position = 0L;
                int num = lockedData.Pitch;
                for (int index1 = 0; index1 < this.int_13; ++index1)
                {
                    for (int index2 = 0; index2 < this.int_12; ++index2)
                    {
                        int index3 = (this.int_12 * index1 + index2) * 3;
                        lockedData.Data.Position = (long)(num * index1 + index2 * 4);
                        lockedData.Data.WriteByte(this.byte_16[index3 + 2]);
                        lockedData.Data.WriteByte(this.byte_16[index3 + 1]);
                        lockedData.Data.WriteByte(this.byte_16[index3]);
                        lockedData.Data.WriteByte((byte)0);
                    }
                }
                this.gclass0_1.method_12().Unlock();
                try
                {
                    c.gclass0_4.method_13(this.gclass0_1);
                }
                catch
                {
                    return;
                }
            }
            else
            {
                this.intptr_0 = c.gclass0_4.method_12().GetDc();
                if (this.bool_39)
                {
                    Graphics graphics = this.d_0.axShockwaveFlash_0.CreateGraphics();
                    IntPtr hdc = graphics.GetHdc();
                    c.BitBlt(this.intptr_0, 0, 0, this.d_0.ClientSize.Width, this.d_0.ClientSize.Height, hdc, 0, 0, 13369376);
                    graphics.ReleaseHdc(hdc);
                }
                else
                {
                    this.int_83 = c.rectangle_0.X;
                    this.int_84 = c.rectangle_0.Y;
                    c.BitBlt(this.intptr_0, 0, 0, c.rectangle_0.Width, c.rectangle_0.Height, this.intptr_1, this.int_83, this.int_84, 13369376);
                }
                c.gclass0_4.method_12().ReleaseDc(this.intptr_0);
            }
            try
            {
                this.gclass0_3.method_13(c.gclass0_4);
            }
            catch
            {
                return;
            }
        }
        else
            this.method_76(this.int_26);
        if (c.bool_51)
        {
            if (!c.bool_53)
                c.gclass0_8.method_12().ColorFill(Color.FromArgb(0, 0, 0));
            else
                c.gclass0_8.method_12().ColorFill(Color.FromArgb(0, 0, 1));
            if (!c.bool_54)
            {
                if (c.int_57 >= 0 && c.int_57 < 10)
                {
                    if (this.int_56 >= c.int_57)
                    {
                        this.int_56 = 0;
                        --c.int_58;
                    }
                    else
                        ++this.int_56;
                }
                else if (c.int_57 < 0)
                    c.int_58 += c.int_57;
                if (c.int_58 + c.size_0.Width < 0)
                    c.int_58 = c.int_65;
                if (c.string_19.Length > 0)
                {
                    string[] strArray = c.string_19.Split(new string[1]
                    {
                        "\r\n"
//            Module.a("떷낹", int_0)
                    }, StringSplitOptions.None);
                    if (strArray.Length > 1)
                    {
                        for (int index = 0; index < strArray.Length; ++index)
                        {
                            if (!c.bool_53)
                                c.gclass0_8.method_12().ForeColor = c.color_3;
                            c.gclass0_8.method_12().DrawText(c.int_58, c.int_59 + index * c.size_0.Height, strArray[index], false);
                        }
                    }
                    else
                    {
                        if (!c.bool_53)
                            c.gclass0_8.method_12().ForeColor = c.color_3;
                        c.gclass0_8.method_12().DrawText(c.int_58, c.int_59, c.string_19, false);
                    }
                }
            }
            else if (!c.bool_52)
            {
                if (c.int_57 >= 0 && c.int_57 < 10)
                {
                    if (this.int_56 >= c.int_57)
                    {
                        this.int_56 = 0;
                        --c.int_59;
                    }
                    else
                        ++this.int_56;
                }
                else if (c.int_57 < 0)
                    c.int_59 += c.int_57;
                if (c.string_19.Length > 0)
                {
                    string[] strArray = c.string_19.Split(new string[1]
                    {
                        "\r\n"
           // Module.a("떷낹", int_0)
                    }, StringSplitOptions.None);
                    if (strArray.Length > 1)
                    {
                        for (int index = 0; index < strArray.Length; ++index)
                        {
                            if (!c.bool_53)
                                c.gclass0_8.method_12().ForeColor = c.color_3;
                            for (int startIndex = 0; startIndex < strArray[index].Length; ++startIndex)
                            {
                                this.string_18 = strArray[index].Substring(startIndex, 1);
                                c.gclass0_8.method_12().DrawText(c.int_58 + index * c.size_0.Height, c.int_59 + startIndex * c.size_0.Height, this.string_18, false);
                            }
                        }
                    }
                    else
                    {
                        if (!c.bool_53)
                            c.gclass0_8.method_12().ForeColor = c.color_3;
                        for (int startIndex = 0; startIndex < c.string_19.Length; ++startIndex)
                        {
                            this.string_18 = c.string_19.Substring(startIndex, 1);
                            c.gclass0_8.method_12().DrawText(c.int_58, c.int_59 + startIndex * c.size_0.Height, this.string_18, false);
                        }
                    }
                    if (c.int_59 + c.size_0.Height * c.string_19.Length < 0)
                        c.int_59 = c.int_66;
                }
            }
            else
            {
                if (c.int_57 >= 0 && c.int_57 < 10)
                {
                    if (this.int_56 >= c.int_57)
                    {
                        this.int_56 = 0;
                        ++c.int_59;
                    }
                    else
                        ++this.int_56;
                }
                else if (c.int_57 < 0)
                    c.int_59 += c.int_57;
                int num = 0;
                if (c.string_19.Length > 0)
                {
                    for (int startIndex = c.string_19.Length - 1; startIndex >= 0; --startIndex)
                    {
                        this.string_18 = c.string_19.Substring(startIndex, 1);
                        c.gclass0_8.method_12().DrawText(c.int_58, c.int_59 + num * c.size_0.Height, this.string_18, false);
                        ++num;
                    }
                    if (c.int_59 > c.size_0.Height * c.string_19.Length)
                        c.int_59 = 1 - c.size_0.Height * c.string_19.Length;
                }
            }
            if (!c.bool_53)
            {
                if (c.bool_56)
                {
                    LockedData lockedData = c.gclass0_8.method_12().Lock(LockFlags.NoSystemLock);
                    lockedData.Data.Position = 0L;
                    this.int_90 = lockedData.Pitch;
                    byte num1 = 0;
                    byte num2 = 0;
                    byte num3 = 0;
                    int int90 = this.int_90;
                    for (int index4 = 0; index4 < c.gclass0_8.method_5().Height; ++index4)
                    {
                        for (int index5 = 0; index5 < c.gclass0_8.method_5().Width; ++index5)
                        {
                            this.int_89 = index4 * this.int_90 + index5 * 4;
                            lockedData.Data.Position = (long)this.int_89;
                            byte num4 = (byte)lockedData.Data.ReadByte();
                            byte num5 = (byte)lockedData.Data.ReadByte();
                            byte num6 = (byte)lockedData.Data.ReadByte();
                            if (index5 > 0)
                            {
                                if (num1 == (byte)0 && num2 == (byte)0 && num3 == (byte)0 && (int)num6 == (int)c.color_3.R && (int)num5 == (int)c.color_3.G && (int)num4 == (int)c.color_3.B && this.int_89 >= 4)
                                {
                                    lockedData.Data.Position = (long)(this.int_89 - 4);
                                    lockedData.Data.WriteByte(byte.MaxValue);
                                    lockedData.Data.WriteByte(byte.MaxValue);
                                    lockedData.Data.WriteByte(byte.MaxValue);
                                    lockedData.Data.WriteByte((byte)0);
                                }
                                if (num6 == (byte)0 && num5 == (byte)0 && num4 == (byte)0 && (int)num1 == (int)c.color_3.R && (int)num2 == (int)c.color_3.G && (int)num3 == (int)c.color_3.B)
                                {
                                    lockedData.Data.Position = (long)this.int_89;
                                    lockedData.Data.WriteByte(byte.MaxValue);
                                    lockedData.Data.WriteByte(byte.MaxValue);
                                    lockedData.Data.WriteByte(byte.MaxValue);
                                    lockedData.Data.WriteByte((byte)0);
                                }
                            }
                            num1 = num6;
                            num2 = num5;
                            num3 = num4;
                        }
                    }
                    for (int index6 = 0; index6 < c.gclass0_8.method_5().Width; ++index6)
                    {
                        for (int index7 = 0; index7 < c.gclass0_8.method_5().Height; ++index7)
                        {
                            this.int_89 = index7 * this.int_90 + index6 * 4;
                            lockedData.Data.Position = (long)this.int_89;
                            byte num7 = (byte)lockedData.Data.ReadByte();
                            byte num8 = (byte)lockedData.Data.ReadByte();
                            byte num9 = (byte)lockedData.Data.ReadByte();
                            if (index7 > 0)
                            {
                                if (num1 == (byte)0 && num2 == (byte)0 && num3 == (byte)0 && (int)num9 == (int)c.color_3.R && (int)num8 == (int)c.color_3.G && (int)num7 == (int)c.color_3.B && this.int_89 >= int90)
                                {
                                    lockedData.Data.Position = (long)(this.int_89 - int90);
                                    lockedData.Data.WriteByte(byte.MaxValue);
                                    lockedData.Data.WriteByte(byte.MaxValue);
                                    lockedData.Data.WriteByte(byte.MaxValue);
                                    lockedData.Data.WriteByte((byte)0);
                                }
                                if (num9 == (byte)0 && num8 == (byte)0 && num7 == (byte)0 && (int)num1 == (int)c.color_3.R && (int)num2 == (int)c.color_3.G && (int)num3 == (int)c.color_3.B)
                                {
                                    lockedData.Data.Position = (long)this.int_89;
                                    lockedData.Data.WriteByte(byte.MaxValue);
                                    lockedData.Data.WriteByte(byte.MaxValue);
                                    lockedData.Data.WriteByte(byte.MaxValue);
                                    lockedData.Data.WriteByte((byte)0);
                                }
                            }
                            num1 = num9;
                            num2 = num8;
                            num3 = num7;
                        }
                    }
                    c.gclass0_8.method_12().Unlock();
                }
            }
            try
            {
                this.gclass0_3.method_13(c.gclass0_8);
            }
            catch
            {
                return;
            }
        }
        LockedData lockedData1 = this.gclass0_3.method_12().Lock(LockFlags.ReadOnly);
        lockedData1.Data.Position = 0L;
        LockedData lockedData2 = this.gclass0_7.method_12().Lock(LockFlags.WriteOnly);
        lockedData2.Data.Position = 0L;
        this.int_90 = lockedData2.Pitch;
        this.int_18 = (int)(this.double_3 * 2.0);
        if (this.bool_49)
        {
            for (int index = 0; index < this.int_41; ++index)
            {
                lockedData1.Data.Position = (long)this.int_43[index];
                byte num10 = (byte)lockedData1.Data.ReadByte();
                byte num11 = (byte)lockedData1.Data.ReadByte();
                byte num12 = (byte)lockedData1.Data.ReadByte();
                this.int_92 = this.int_51[index];
                this.byte_37[this.int_92] = num12;
                ++this.int_92;
                this.byte_37[this.int_92] = num11;
                ++this.int_92;
                this.byte_37[this.int_92] = num10;
                lockedData2.Data.Position = (long)this.int_44[index];
                lockedData2.Data.WriteByte(num10);
                lockedData2.Data.WriteByte(num11);
                lockedData2.Data.WriteByte(num12);
                lockedData2.Data.WriteByte((byte)0);
            }
        }
        else
        {
            int index8 = 0;
            for (int index9 = 0; index9 < this.arrayList_3.Count; ++index9)
            {
                this.int_91 = ((GClass8)this.arrayList_3[index9]).method_4() * this.int_82 * 3;
                for (int int_2 = 0; int_2 < ((GClass8)this.arrayList_3[index9]).method_0(); ++int_2)
                {
                    this.int_87 = ((GClass8)this.arrayList_3[index9]).method_6(int_2).X;
                    this.int_88 = ((GClass8)this.arrayList_3[index9]).method_6(int_2).Y;
                    lockedData1.Data.Position = (long)this.int_43[index8];
                    byte num13 = (byte)lockedData1.Data.ReadByte();
                    byte num14 = (byte)lockedData1.Data.ReadByte();
                    byte num15 = (byte)lockedData1.Data.ReadByte();
                    this.int_92 = this.int_51[index8];
                    this.byte_37[this.int_92] = num15;
                    ++this.int_92;
                    this.byte_37[this.int_92] = num14;
                    ++this.int_92;
                    this.byte_37[this.int_92] = num13;
                    for (int index10 = 0; index10 < this.int_18; ++index10)
                    {
                        for (int index11 = 0; index11 < this.int_18; ++index11)
                        {
                            this.int_89 = (this.int_88 + index10) * this.int_90 + (this.int_87 + index11) * 4;
                            lockedData2.Data.Position = (long)this.int_89;
                            lockedData2.Data.WriteByte(num13);
                            lockedData2.Data.WriteByte(num14);
                            lockedData2.Data.WriteByte(num15);
                            lockedData2.Data.WriteByte((byte)0);
                        }
                    }
                    ++index8;
                }
            }
        }
        this.gclass0_7.method_12().Unlock();
        this.gclass0_3.method_12().Unlock();
        try
        {
            this.gclass0_2.method_13(this.gclass0_7);
        }
        catch (Exception ex)
        {
            this.ShowMessage("Directx Error: " + ex.Message);
//            this.ShowMessage(Module.a("ﲷ펹캻\uDBBDꎿ뛁볃\uE6C5跇룉뻋ꇍꋏ\uE8D1\uF4D3", int_0) + ex.Message);
            return;
        }
        try
        {
            this.gclass0_2.method_13(this.gclass0_5);
        }
        catch (Exception ex)
        {
            this.ShowMessage("Directx Error: " + ex.Message);
//            this.ShowMessage(Module.a("ﲷ펹캻\uDBBDꎿ뛁볃\uE6C5跇룉뻋ꇍꋏ\uE8D1\uF4D3", int_0) + ex.Message);
            return;
        }
        this.method_15();
        if (this.bool_38)
        {
            for (uint index = 0; (long)index < (long)this.int_39; ++index)
                this.byte_38[index] = (byte)((uint)this.byte_37[(index ^ (uint)this.byte_45)] + (uint)this.byte_44);
            this.bufferedStream_1.Write(this.byte_38, 0, this.int_39);
            ++((GClass5)c.arrayList_4[c.int_38]).int_0;
            this.toolStripTextBox_0.Text = ((GClass5)c.arrayList_4[c.int_38]).int_0.ToString();
        }
        if (this.bool_30)
        {
            this.byte_35[0] = (byte)197;
            this.byte_35[1] = (byte)119;
            this.byte_35[2] = (byte)136;
            try
            {
                this.udpClient_0.Send(this.byte_35, 5, "192.168.60.50", 5000);
 //               this.udpClient_0.Send(this.byte_35, 5, Module.a("覷莹躻邽\uF1BF\uF4C1ﳃ\uE8C5ﻇ韛\uE2CB\uFBCD\uE0CF", int_0), 5000);
            }
            catch
            {
            }
            switch (c.int_2)
            {
                case 81:
                case 82:
                case 86:
                    this.method_66();
                    this.method_59();
                    break;
                case 83:
                case 110:
                    this.method_68();
                    this.method_60();
                    break;
                case 84:
                    this.method_64();
                    this.method_58();
                    break;
                case 85:
                case 140:
                    this.method_67();
                    this.method_59();
                    break;
                case 101:
                    this.method_70();
                    this.method_57();
                    break;
                case 102:
                    if (!c.bool_2)
                    {
                        this.method_63();
                        this.method_58();
                        break;
                    }
                    this.method_64();
                    this.method_58();
                    break;
                case 103:
                    this.method_71();
                    this.method_57();
                    break;
                case 120:
                case 130:
                case 150:
                    if (!c.bool_2)
                    {
                        this.method_65();
                        this.method_59();
                        break;
                    }
                    this.method_66();
                    this.method_59();
                    break;
            }
        }
        if (!this.bool_19 && this.bool_39)
        {
            if (this.d_0.axShockwaveFlash_0.CurrentFrame() == this.int_64 - 1)
            {
                if (this.bool_57)
                {
                    this.d_0.axShockwaveFlash_0.GotoFrame(0);
                    if (this.bool_19)
                        this.d_0.axShockwaveFlash_0.Play();
                }
                else
                {
                    this.bool_22 = false;
                    if (this.bool_38)
                    {
                        this.bufferedStream_1.Flush();
                        this.bufferedStream_1.Close();
                        this.fileStream_1.Close();
                        this.bool_38 = false;
                        this.bool_40 = true;
                        ((GClass5)c.arrayList_4[c.int_38]).bool_2 = true;
                        this.method_28();
                        this.Text = this.string_8 + " "/*Module.a("颷", int_0)*/ + c.string_0;
                    }
                    this.genum1_1 = !this.bool_40 ? GEnum1.const_2 : GEnum1.const_6;
                    this.method_31();
                    this.bool_37 = false;
                    this.timer_1.Interval = 1000 / c.smethod_0();
                    this.timer_1.Enabled = false;
                    if (this.bool_39)
                        this.d_0.axShockwaveFlash_0.Stop();
                    this.d_0.Hide();
                    this.method_26(4, "1");
//                    this.method_26(4, Module.a("覷", int_0));
 //                   this.method_26(5, this.string_22 + Module.a("隷\uD8B9햻킽", int_0));
                    this.method_26(5, this.string_22 + ".bin");
                    this.method_26(8, "1");
//                    this.method_26(8, Module.a("覷", int_0));
                    this.method_26(9, this.int_55.ToString());
                    this.Location = new Point(0, 0);
                    this.method_13();
                }
            }
            else
            {
                if (this.int_19 == 0)
                    this.d_0.axShockwaveFlash_0.Forward();
                else if (this.int_19 > 0)
                {
                    for (int index = 0; index < this.int_19 + 1; ++index)
                        this.d_0.axShockwaveFlash_0.Forward();
                }
                else if (this.int_19 < 0)
                {
                    if (this.int_20 >= 0)
                    {
                        this.d_0.axShockwaveFlash_0.Forward();
                        this.int_20 = this.int_19;
                    }
                    else
                        ++this.int_20;
                }
                this.d_0.Text = this.d_0.axShockwaveFlash_0.CurrentFrame().ToString() + Module.a("鞷", int_0) + this.int_64.ToString();
            }
        }
        if (this.bool_13)
        {
            if (this.int_19 == 0)
                ++this.int_15;
            else if (this.int_19 > 0)
            {
                for (int index = 0; index < this.int_19 + 1; ++index)
                    ++this.int_15;
            }
            else if (this.int_19 < 0)
            {
                if (this.int_20 >= 0)
                {
                    ++this.int_15;
                    this.int_20 = this.int_19;
                }
                else
                    ++this.int_20;
            }
            if (this.int_15 >= this.int_11)
            {
                if (this.bool_57)
                {
                    this.int_15 = 0;
                }
                else
                {
                    this.bool_22 = false;
                    if (this.bool_38)
                    {
                        this.bufferedStream_1.Flush();
                        this.bufferedStream_1.Close();
                        this.fileStream_1.Close();
                        this.bool_38 = false;
                        this.bool_40 = true;
                        ((GClass5)c.arrayList_4[c.int_38]).bool_2 = true;
                        this.method_28();
                        this.Text = this.string_8 + Module.a("颷", int_0) + c.string_0;
                    }
                    this.genum1_1 = !this.bool_40 ? GEnum1.const_2 : GEnum1.const_6;
                    this.method_31();
                    this.bool_37 = false;
                    this.timer_1.Interval = 1000 / c.smethod_0();
                    this.timer_1.Enabled = false;
                    if (this.bool_39)
                        this.d_0.axShockwaveFlash_0.Stop();
                    this.d_0.Hide();
                    this.method_26(4, Module.a("覷", int_0));
                    this.method_26(5, this.string_22 + Module.a("隷\uD8B9햻킽", int_0));
                    this.method_26(8, Module.a("覷", int_0));
                    this.method_26(9, this.int_55.ToString());
                    this.Location = new Point(0, 0);
                    this.method_13();
                    this.bool_13 = false;
                    this.method_86();
                }
            }
        }
        if (!c.bool_51 && this.bool_29 && this.genum1_1 == GEnum1.const_5)
            this.menuItem_3_Click((object)null, (EventArgs)null);
        if (this.bool_36)
        {
            if (this.bool_13)
            {
                this.bool_22 = false;
                if (this.bool_38)
                {
                    this.bufferedStream_1.Flush();
                    this.bufferedStream_1.Close();
                    this.fileStream_1.Close();
                    this.bool_38 = false;
                    this.bool_40 = true;
                    this.Text = this.string_8 + Module.a("颷", int_0) + c.string_0;
                }
                this.genum1_1 = !this.bool_40 ? GEnum1.const_2 : GEnum1.const_6;
                this.method_31();
                this.bool_37 = false;
                this.timer_1.Interval = 1000 / c.smethod_0();
                this.timer_1.Enabled = false;
                if (this.bool_39)
                    this.d_0.axShockwaveFlash_0.Stop();
                this.d_0.Hide();
                this.method_26(4, Module.a("覷", int_0));
                this.method_26(5, this.string_22 + Module.a("隷\uD8B9햻킽", int_0));
                this.method_26(8, Module.a("覷", int_0));
                this.method_26(9, this.int_55.ToString());
                this.Location = new Point(0, 0);
                this.method_13();
                this.bool_13 = false;
                this.method_86();
            }
            else
                this.method_19();
            this.bool_36 = false;
            ((GClass5)c.arrayList_4[c.int_38]).bool_2 = true;
            this.method_28();
        }
        if (c.bool_51 || !this.bool_29)
            return;
        this.bool_29 = false;
        this.menuItem_9_Click((object)null, (EventArgs)null);
        this.menuItem_7_Click((object)null, (EventArgs)null);
    }

    private void method_17()
    {
        int int_0 = 19;
        LockedData lockedData = this.gclass0_7.method_12().Lock(LockFlags.WriteOnly);
        lockedData.Data.Position = 0L;
        this.int_90 = lockedData.Pitch;
        int index1 = 0;
        for (int index2 = 0; index2 < this.arrayList_3.Count; ++index2)
        {
            for (int int_2 = 0; int_2 < ((GClass8)this.arrayList_3[index2]).method_0(); ++int_2)
            {
                Color color = !this.bool_15 ? (this.int_16 != ((GClass8)this.arrayList_3[index2]).method_4() || this.int_17 != int_2 ? Color.FromArgb(0, 100, (int)byte.MaxValue) : Color.FromArgb((int)byte.MaxValue, 0, 0)) : (this.int_16 != ((GClass8)this.arrayList_3[index2]).method_4() ? Color.FromArgb(0, 100, (int)byte.MaxValue) : Color.FromArgb((int)byte.MaxValue, 0, 0));
                byte r = color.R;
                byte g = color.G;
                byte b = color.B;
                this.int_92 = this.int_51[index1];
                this.byte_37[this.int_92] = r;
                ++this.int_92;
                this.byte_37[this.int_92] = g;
                ++this.int_92;
                this.byte_37[this.int_92] = b;
                if (this.bool_49)
                {
                    lockedData.Data.Position = (long)this.int_44[index1];
                    lockedData.Data.WriteByte(b);
                    lockedData.Data.WriteByte(g);
                    lockedData.Data.WriteByte(r);
                    lockedData.Data.WriteByte((byte)0);
                }
                else
                {
                    this.int_87 = ((GClass8)this.arrayList_3[index2]).method_6(int_2).X;
                    this.int_88 = ((GClass8)this.arrayList_3[index2]).method_6(int_2).Y;
                    for (int index3 = 0; index3 < this.int_18; ++index3)
                    {
                        for (int index4 = 0; index4 < this.int_18; ++index4)
                        {
                            this.int_89 = (this.int_88 + index3) * this.int_90 + (this.int_87 + index4) * 4;
                            lockedData.Data.Position = (long)this.int_89;
                            lockedData.Data.WriteByte(b);
                            lockedData.Data.WriteByte(g);
                            lockedData.Data.WriteByte(r);
                            lockedData.Data.WriteByte((byte)0);
                        }
                    }
                }
                ++index1;
            }
        }
        this.gclass0_7.method_12().Unlock();
        try
        {
            this.gclass0_2.method_13(this.gclass0_7);
        }
        catch (Exception ex)
        {
            this.ShowMessage("Directx Error: " + ex.Message);
//            this.ShowMessage(Module.a("ﶸ튺쾼\uDABEꋀ럂뷄\uE7C6賈맊뿌ꃎꏐ\uE9D2\uF5D4", int_0) + ex.Message);
            return;
        }
        try
        {
            this.gclass0_2.method_13(this.gclass0_5);
        }
        catch (Exception ex)
        {
            this.ShowMessage("Directx Error: " + ex.Message);
//            this.ShowMessage(Module.a("ﶸ튺쾼\uDABEꋀ럂뷄\uE7C6賈맊뿌ꃎꏐ\uE9D2\uF5D4", int_0) + ex.Message);
            return;
        }
        this.method_15();
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && this.icontainer_0 != null)
            this.icontainer_0.Dispose();

        base.Dispose(disposing);
    }
    protected override void WndProc(ref Message m)
    {
        if (m.Msg == 161 && m.WParam.ToInt32() == 2 && this.bool_21)
            return;
        // ISSUE: explicit non-virtual call
        base.WndProc(ref m);
    }

    private void method_18()
    {
 //       int int_0 = 7;
        ++this.int_55;
        if (this.int_55 > this.int_40 - 1)
        {
            this.int_55 = 0;
            if (this.bool_21)
            {
                this.bool_21 = false;
                this.textBox_0.Enabled = false;
                this.menuItem_4.Enabled = true;
                this.timer_1.Interval = 1000 / c.smethod_0();
                this.trackBar_0.Enabled = false;
                this.method_13();
                this.bufferedStream_1.Flush();
                this.bufferedStream_1.Close();
                this.fileStream_1.Close();
                this.bool_50 = false;
                this.bool_37 = false;
                this.timer_1.Interval = 1000 / c.smethod_0();
                this.timer_1.Enabled = false;
                this.genum1_1 = GEnum1.const_6;
                this.menuItem_26.Enabled = false;
                this.menuItem_27.Enabled = false;
                this.menuItem_28.Enabled = false;
                this.menuItem_25.Enabled = false;
                this.method_31();
                this.toolStrip_1.Enabled = true;
                if (!this.bool_12)
                {
                    this.aviManager_0.Close();
                }
                else
                {
                    this.swf_0.Tags.Add((BaseTag)new EndTag());
                    SwfWriter swfWriter = new SwfWriter(this.string_4);
                    swfWriter.Write(this.swf_0);
                    swfWriter.Close();
                }
                this.TopMost = false;
                this.ControlBox = true;
                return;
            }
            if (this.bool_27)
            {
                ++c.int_38;
                if (c.int_38 >= c.arrayList_4.Count)
                    c.int_38 = 0;
                this.listBox_0.SelectedIndex = c.int_38;
                this.textBox_4.Text = this.listBox_0.Items[c.int_38].ToString();
                this.bool_11 = true;
                if (this.genum1_1 == GEnum1.const_8)
                    this.method_87();
                this.bool_11 = false;
            }
        }
        if (this.bool_21)
        {
            this.toolStrip_1.Enabled = false;
            this.trackBar_0.Enabled = false;
            this.menuItem_4.Enabled = false;
        }
        else
        {
            this.toolStrip_1.Enabled = true;
            this.menuItem_4.Enabled = true;
            this.trackBar_0.Value = this.int_55;
        }
        if (!this.bool_27)
        {
            if (this.bool_21)
            {
                this.textBox_0.Enabled = false;
            }
            else
            {
                if (!this.bool_47)
                {
                    this.textBox_0.SelectionStart = this.trackBar_0.Value;
                    this.textBox_0.Select(this.int_55, 1);
                }
                this.textBox_0.ScrollToCaret();
            }
            while (true)
            {
                int num1 = this.int_45[this.int_55];
                this.toolStripTextBox_0.Text = (this.int_55 + 1).ToString() + (object)'/' + this.int_40.ToString();
                this.bufferedStream_1.Seek((long)this.int_39 * (long)num1, SeekOrigin.Begin);
                int num2 = this.bufferedStream_1.Read(this.byte_38, 0, this.int_39);
                for (uint index = 0; (long)index < (long)this.int_39; ++index)
                    this.byte_37[index] = (byte)((uint)this.byte_38[(index ^ (uint)this.byte_45)] - (uint)this.byte_44);
                if (num2 < this.int_39)
                    this.int_55 = 0;
                else
                    break;
            }
        }
        else
        {
            this.byte_35[0] = (byte)197;
            this.byte_35[1] = (byte)119;
            this.byte_35[2] = (byte)136;
            try
            {
                this.udpClient_0.Send(this.byte_35, 5, "192.168.60.50", 5000);
 //               this.udpClient_0.Send(this.byte_35, 5, Module.a("鲬隮莰鶲蒴膶膸閺讼达\uEFC0\uF6C2\uF5C4", int_0), 5000);
            }
            catch
            {
            }
            switch (c.int_2)
            {
                case 81:
                case 82:
                case 85:
                case 86:
                case 120:
                case 130:
                case 140:
                case 150:
                    this.method_55();
                    break;
                case 83:
                case 110:
                    this.method_54();
                    break;
                case 84:
                case 102:
                    this.method_53();
                    break;
                case 101:
                case 103:
                    this.method_52();
                    break;
            }
            if (this.bool_31)
                return;
            while (true)
            {
                this.toolStripTextBox_0.Text = (this.int_55 + 1).ToString() + (object)'/' + this.int_40.ToString();
                this.bufferedStream_1.Seek((long)this.int_39 * (long)this.int_55, SeekOrigin.Begin);
                int num = this.bufferedStream_1.Read(this.byte_38, 0, this.int_39);
                for (uint index = 0; (long)index < (long)this.int_39; ++index)
                    this.byte_37[index] = (byte)((uint)this.byte_38[(index ^ (uint)this.byte_45)] - (uint)this.byte_44);
                if (num < this.int_39)
                    this.int_55 = 0;
                else
                    break;
            }
        }
        LockedData lockedData = this.gclass0_7.method_12().Lock(LockFlags.WriteOnly);
        lockedData.Data.Position = 0L;
        this.int_90 = lockedData.Pitch;
        int num3 = (int)(this.double_3 * 2.0);
        if (this.bool_49)
        {
            for (int index = 0; index < this.int_41; ++index)
            {
                this.int_92 = this.int_51[index];
                byte num4 = this.byte_37[this.int_92];
                ++this.int_92;
                byte num5 = this.byte_37[this.int_92];
                ++this.int_92;
                byte num6 = this.byte_37[this.int_92];
                lockedData.Data.Position = (long)this.int_44[index];
                lockedData.Data.WriteByte(num6);
                lockedData.Data.WriteByte(num5);
                lockedData.Data.WriteByte(num4);
                lockedData.Data.WriteByte((byte)0);
            }
        }
        else
        {
            int index1 = 0;
            for (int index2 = 0; index2 < this.arrayList_3.Count; ++index2)
            {
                this.int_91 = ((GClass8)this.arrayList_3[index2]).method_4() * this.int_82 * 3;
                for (int int_2 = 0; int_2 < ((GClass8)this.arrayList_3[index2]).method_0(); ++int_2)
                {
                    this.int_87 = ((GClass8)this.arrayList_3[index2]).method_6(int_2).X;
                    this.int_88 = ((GClass8)this.arrayList_3[index2]).method_6(int_2).Y;
                    this.int_92 = this.int_51[index1];
                    byte num7 = this.byte_37[this.int_92];
                    ++this.int_92;
                    byte num8 = this.byte_37[this.int_92];
                    ++this.int_92;
                    byte num9 = this.byte_37[this.int_92];
                    for (int index3 = 0; index3 < num3; ++index3)
                    {
                        for (int index4 = 0; index4 < num3; ++index4)
                        {
                            this.int_89 = (this.int_88 + index3) * this.int_90 + (this.int_87 + index4) * 4;
                            lockedData.Data.Position = (long)this.int_89;
                            lockedData.Data.WriteByte(num9);
                            lockedData.Data.WriteByte(num8);
                            lockedData.Data.WriteByte(num7);
                            lockedData.Data.WriteByte((byte)0);
                        }
                    }
                    ++index1;
                }
            }
        }
        this.gclass0_7.method_12().Unlock();
        try
        {
            this.gclass0_2.method_13(this.gclass0_7);
        }
        catch (Exception ex)
        {
            this.ShowMessage("Directx Error: " + ex.Message);
 //           this.ShowMessage(Module.a("\uE9AC욮쎰횲횴쎶솸鮺\uF8BC춾돀곂럄ﷆ\uE9C8", int_0) + ex.Message);
            return;
        }
        try
        {
            this.gclass0_2.method_13(this.gclass0_5);
        }
        catch (Exception ex)
        {
            this.ShowMessage("Directx Error: " + ex.Message);
///            this.ShowMessage(Module.a("\uE9AC욮쎰횲횴쎶솸鮺\uF8BC춾돀곂럄ﷆ\uE9C8", int_0) + ex.Message);
            return;
        }
        this.method_15();
        if (!this.bool_21)
            return;
        Bitmap bmp = new Bitmap(this.panel_0.Width, this.panel_0.Height);
        Graphics graphics1 = Graphics.FromImage((Image)bmp);
        IntPtr hdc1 = graphics1.GetHdc();
        Graphics graphics2 = this.panel_0.CreateGraphics();
        IntPtr hdc2 = graphics2.GetHdc();
        c.BitBlt(hdc1, 0, 0, this.panel_0.Width, this.panel_0.Height, hdc2, 0, 0, 13369376);
        graphics2.ReleaseHdc(hdc2);
        graphics1.ReleaseHdc(hdc1);
        if (!this.bool_12)
        {
            this.videoStream_0.AddFrame(bmp);
        }
        else
        {
            if (System.IO.File.Exists(this.string_5))
                System.IO.File.Delete(this.string_5);
            bmp.Save(this.string_5, ImageFormat.Jpeg);
            this.image_0 = Image.FromFile(this.string_5);
            int width = this.image_0.Width;
            int height = this.image_0.Height;
            ushort newDefineId = this.swf_0.GetNewDefineId();
            this.swf_0.Tags.Add((BaseTag)DefineBitsJpeg2Tag.FromImage(newDefineId, this.image_0));
            DefineShapeTag defineShapeTag = new DefineShapeTag();
            defineShapeTag.CharacterId = this.swf_0.GetNewDefineId();
            defineShapeTag.Rect = new Rect(0 * 20 - 1, 0 * 20 - 1, (0 + width) * 20 - 1, (0 + height) * 20 - 1);
            FillStyleCollection fillStyleArray = new FillStyleCollection();
            fillStyleArray.Add((FillStyle)new BitmapFill(FillStyleType.ClippedBitmapFill, ushort.MaxValue, new Matrix(0, 0, 20.0, 20.0)));
            fillStyleArray.Add((FillStyle)new BitmapFill(FillStyleType.ClippedBitmapFill, newDefineId, new Matrix(0 * 20 - 1, 0 * 20 - 1, 20.0 * (double)width / (double)this.image_0.Width, 20.0 * (double)height / (double)this.image_0.Height)));
            LineStyleCollection lineStyleArray = new LineStyleCollection();
            defineShapeTag.ShapeWithStyle = new ShapeWithStyle(fillStyleArray, lineStyleArray, new ShapeRecordCollection()
      {
        (ShapeRecord) new StyleChangeRecord(0 * 20 - 1, 0 * 20 - 1, (ushort) 2),
        (ShapeRecord) new StraightEdgeRecord(width * 20, 0),
        (ShapeRecord) new StraightEdgeRecord(0, height * 20),
        (ShapeRecord) new StraightEdgeRecord(-width * 20, 0),
        (ShapeRecord) new StraightEdgeRecord(0, -height * 20),
        (ShapeRecord) new EndShapeRecord()
      });
            this.swf_0.Tags.Add((BaseTag)defineShapeTag);
            this.swf_0.Tags.Add((BaseTag)new PlaceObject2Tag(defineShapeTag.CharacterId, 1, 0, 0));
            this.swf_0.Tags.Add((BaseTag)new ShowFrameTag());
            this.swf_0.Tags.Add((BaseTag)new RemoveObject2Tag((ushort)1));
            this.image_0.Dispose();
        }
    }

    private void menuItem_10_Click(object sender, EventArgs e)
    {
    }

    private void method_19()
    {
        int int_0 = 17;
        this.Text = this.string_8 + " " + c.string_0;
//        this.Text = this.string_8 + Module.a("鞶", 17) + c.string_0;
        this.bufferedStream_1.Flush();
        this.bufferedStream_1.Close();
        this.fileStream_1.Close();
        this.bool_38 = false;
        this.bool_40 = true;
        this.genum1_1 = this.bool_39 || this.bool_25 ? GEnum1.const_4 : GEnum1.const_3;
        this.method_26(4, "1");
        //        this.method_26(4, Module.a("蚶", int_0));
        this.method_26(5, this.string_22 + ".bin"); //Module.a("馶\uDBB8튺펼", int_0));
        this.method_26(8,"1");
//        this.method_26(8, Module.a("蚶", int_0));
        this.method_26(9, this.int_55.ToString());
        this.method_31();
    }

    private void menuItem_5_Click(object sender, EventArgs e)
    {
        int int_0 = 9;
        if (!((GClass5)c.arrayList_4[c.int_38]).bool_2)
        {
            if (c.useEnglishLanguage)
                this.ShowMessage("The current program without recording!");
 //           this.ShowMessage(Module.a("ﮮ\uD9B0횲閴풶첸즺쾼\uDABE꿀럂\uE5C4럆믈\uA4CA\uAACC뷎냐뻒\uF5D4ꃖ냘꿚뗜냞铠韢엤闦賨裪苬鷮闰髲鯴郶\uD8F8", int_0));
            else
                this.ShowMessage("当前节目无录制内容!");
//            this.ShowMessage(Module.a("ﳱﳢ\u3130寂埓\uECE7跨㣭ۥ\uE0C0", int_0));
        }
        else
        {
            string path = this.string_20 + (object)'\\' + ((GClass5)c.arrayList_4[c.int_38]).string_3;
            if (!System.IO.File.Exists(path))
            {
                if (c.useEnglishLanguage)
                    this.ShowMessage("The current program without recording!");
//                this.ShowMessage(Module.a("ﮮ\uD9B0횲閴풶첸즺쾼\uDABE꿀럂\uE5C4럆믈\uA4CA\uAACC뷎냐뻒\uF5D4ꃖ냘꿚뗜냞铠韢엤闦賨裪苬鷮闰髲鯴郶\uD8F8", int_0));
                else
                    this.ShowMessage("当前节目无录制内容!");
 //               this.ShowMessage(Module.a("ﳱﳢ\u3130寂埓\uECE7跨㣭ۥ\uE0C0", int_0));
            }
            else
            {
                this.fileStream_1 = new FileStream(path, FileMode.Open, FileAccess.Read);
                this.bufferedStream_1 = new BufferedStream((Stream)this.fileStream_1);
                this.bool_50 = true;
                this.int_55 = 0;
                this.int_40 = ((GClass5)c.arrayList_4[c.int_38]).int_0;
                this.int_50 = this.int_40;
                this.trackBar_0.Minimum = 0;
                this.trackBar_0.Maximum = this.int_40 - 1;
                this.trackBar_0.Enabled = true;
                this.textBox_0.Text = "";
                this.int_45 = new int[this.int_40];
                for (int index = 0; index < this.int_40; ++index)
                {
                    this.int_45[index] = index;
                    this.textBox_0.Text += (string)(object)'■';
                }
                this.genum1_1 = GEnum1.const_7;
                this.menuItem_25.Enabled = true;
                this.method_31();
                this.toolStripMenuItem_0.Enabled = false;
                this.toolStripMenuItem_1.Enabled = false;
                this.toolStripMenuItem_2.Enabled = false;
                this.toolStripMenuItem_3.Enabled = false;
                this.toolStripMenuItem_4.Enabled = false;
                this.menuItem_25_Click(sender, e);
                this.menuItem_28_Click(sender, e);
                this.menuItem_98.Enabled = true;
                this.menuItem_99.Enabled = true;
                this.menuItem_100.Enabled = false;
                this.menuItem_101.Enabled = true;
                this.menuItem_102.Enabled = false;
                this.textBox_0.Enabled = true;
            }
        }
    }

    private void menuItem_6_Click(object sender, EventArgs e)
    {
        int int_0 = 12;
        this.textBox_0.Enabled = false;
        this.menuItem_98.Enabled = false;
        this.menuItem_99.Enabled = false;
        this.menuItem_100.Enabled = false;
        this.menuItem_101.Enabled = false;
        this.menuItem_102.Enabled = false;
        if (this.bool_46)
        {
            if (new z().ShowDialog() == DialogResult.OK)
            {
                string str1 = this.string_20 + (object)'\\' + this.string_22 + "_tp.bin";
//                string str1 = this.string_20 + (object)'\\' + this.string_22 + Module.a("\uEDB1삳욵隷\uD8B9햻킽", int_0);
                if (System.IO.File.Exists(str1))
                    System.IO.File.Delete(str1);
                FileStream fileStream = new FileStream(str1, FileMode.Create, FileAccess.Write);
                BufferedStream bufferedStream = new BufferedStream((Stream)fileStream);
                for (int index1 = 0; index1 < this.int_50; ++index1)
                {
                    this.bufferedStream_1.Seek((long)this.int_39 * (long)this.int_45[index1], SeekOrigin.Begin);
                    this.bufferedStream_1.Read(this.byte_38, 0, this.int_39);
                    for (uint index2 = 0; (long)index2 < (long)this.int_39; ++index2)
                        this.byte_37[index2] = (byte)((uint)this.byte_38[(index2 ^ (uint)this.byte_45)] - (uint)this.byte_44);
                    for (uint index3 = 0; (long)index3 < (long)this.int_39; ++index3)
                        this.byte_38[index3] = (byte)((uint)this.byte_37[(index3 ^ (uint)this.byte_45)] + (uint)this.byte_44);
                    bufferedStream.Write(this.byte_38, 0, this.int_39);
                }
                bufferedStream.Flush();
                bufferedStream.Close();
                fileStream.Close();
                this.trackBar_0.Enabled = false;
                this.method_13();
                this.bufferedStream_1.Flush();
                this.bufferedStream_1.Close();
                this.fileStream_1.Close();
                this.bool_50 = false;
                this.bool_37 = false;
                this.timer_1.Interval = 1000 / c.smethod_0();
                this.timer_1.Enabled = false;
                this.genum1_1 = GEnum1.const_6;
                this.menuItem_26.Enabled = false;
                this.menuItem_27.Enabled = false;
                this.menuItem_28.Enabled = false;
                this.menuItem_25.Enabled = false;
                this.method_31();
                string str2 = this.string_20 + (object)'\\' + ((GClass5)c.arrayList_4[c.int_38]).string_3;
                ((GClass5)c.arrayList_4[c.int_38]).int_0 = this.int_40;
                ((GClass5)c.arrayList_4[c.int_38]).bool_3 = false;
                this.method_28();
                if (System.IO.File.Exists(str2))
                    System.IO.File.Delete(str2);
                System.IO.File.Copy(str1, str2);
                System.IO.File.Delete(str1);
                this.method_26(4, "1");
                //               this.method_26(4, Module.a("莱", int_0));
                this.method_26(5, this.string_22 + ".bin");
//                this.method_26(5, this.string_22 + Module.a("鲱횳\uDFB5횷", int_0));
                this.method_26(8, "1");
 //               this.method_26(8, Module.a("莱", int_0));
                this.method_26(9, this.int_50.ToString());
                this.bool_46 = false;
                this.menuItem_31.Enabled = false;
//                this.Text = this.string_8 + Module.a("\uE9B1馳鮵", int_0) + this.string_22 + (object)']';
                this.Text = this.string_8 + "[--" + this.string_22 + (object)']';
                this.method_26(6, Module.a("花", int_0));
            }
            else
            {
                this.bool_46 = false;
//                this.Text = this.string_8 + Module.a("\uE9B1馳鮵", int_0) + this.string_22 + (object)']';
                this.Text = this.string_8 + "[--" + this.string_22 + (object)']';
                this.trackBar_0.Enabled = false;
                this.method_13();
                this.bufferedStream_1.Flush();
                this.bufferedStream_1.Close();
                this.fileStream_1.Close();
                this.bool_50 = false;
                this.bool_37 = false;
                this.timer_1.Interval = 1000 / c.smethod_0();
                this.timer_1.Enabled = false;
                this.genum1_1 = GEnum1.const_6;
                this.menuItem_26.Enabled = false;
                this.menuItem_27.Enabled = false;
                this.menuItem_28.Enabled = false;
                this.menuItem_25.Enabled = false;
                this.method_31();
            }
        }
        else
        {
            this.trackBar_0.Enabled = false;
            this.method_13();
            this.bufferedStream_1.Flush();
            this.bufferedStream_1.Close();
            this.fileStream_1.Close();
            this.bool_50 = false;
            this.bool_37 = false;
            this.timer_1.Interval = 1000 / c.smethod_0();
            this.timer_1.Enabled = false;
            this.genum1_1 = GEnum1.const_6;
            this.menuItem_26.Enabled = false;
            this.menuItem_27.Enabled = false;
            this.menuItem_28.Enabled = false;
            this.menuItem_25.Enabled = false;
            this.method_31();
        }
    }

    private void menuItem_7_Click(object sender, EventArgs e)
    {
        this.bool_37 = false;
        this.timer_1.Interval = 1000 / c.smethod_0();
        this.timer_1.Enabled = false;
        c.i_0.Hide();
        this.Location = new Point(0, 0);
        this.WindowState = FormWindowState.Maximized;
        this.method_15();
        this.genum1_1 = !this.bool_40 ? GEnum1.const_2 : GEnum1.const_6;
        if (Convert.ToInt32(this.string_11[4]) == 1 && System.IO.File.Exists(this.string_20 + (object)'\\' + this.string_11[5]))
            this.genum1_1 = GEnum1.const_6;
        this.method_31();
        this.method_13();
    }

    private void menuItem_1_Click(object sender, EventArgs e)
    {
        int int_0 = 6;
        c.int_59 = 0;
        c.int_58 = 0;
        this.BringToFront();
        this.WindowState = FormWindowState.Normal;
        this.bool_39 = false;
        this.Size = new Size(this.int_69, this.int_70);
        this.Location = new Point(600, 600);
        this.method_13();
        if (this.int_67 >= 500 && this.int_68 >= 400)
            c.i_0.ClientSize = new Size(500, 400);
        else
            c.i_0.ClientSize = new Size(this.int_67, this.int_68);
        c.i_0.Location = new Point(100, 80);
        c.i_0.BackgroundImage = (Image)null;
        c.i_0.BackgroundImageLayout = ImageLayout.Tile;
        c.i_0.TransparencyKey = this.d_0.BackColor;
        c.i_0.Opacity = 1.0;
        c.i_0.Text = "Player"; //Module.a("ﲫ슭톯쮱톳쒵", int_0);
        c.i_0.Show();
        this.method_15();
        this.bool_50 = false;
        this.bool_37 = true;
 //       if ((c.string_7 == Module.a("\uF8AB\uE2AD\uE3AF銱\uE2B3莵閷\uF7B9", int_0) || c.string_7 == Module.a("\uEFAB\uDBAD슯욱햳\uDFB5횷骹\uEABB讽", int_0)) && c.smethod_0() > 20)
        if ((c.string_7 == "TLS V5-M" || c.string_7 == "Curtain V5") && c.smethod_0() > 20)
             c.smethod_1(20);
        this.timer_1.Interval = 1000 / c.smethod_0();
        this.timer_1.Enabled = true;
        this.bool_40 = false;
        this.genum1_1 = GEnum1.const_3;
        this.method_31();
        this.BringToFront();
        c.i_0.method_0();
        Rectangle rectangle_2 = new Rectangle(0, 0, c.rectangle_0.Width, c.rectangle_0.Height);
        c.gclass0_4.method_15(rectangle_2);
    }

    private void menuItem_8_Click(object sender, EventArgs e)
    {
        int int_0 = 17;
        this.menuItem_9_Click(sender, e);
        this.int_19 = 0;
        this.bool_19 = false;
        if (this.bool_28)
            this.r_0.Hide();
        c.int_59 = 0;
        c.int_58 = 0;
        this.BringToFront();
        bool flag = false;
        if (this.d_0.Visible)
        {
            this.d_0.Hide();
            flag = true;
        }
        this.method_13();
        int num1 = this.int_67;
        int num2 = this.int_68;
        if (num1 > 700)
            num1 = 700;
        if (num2 > 500)
            num2 = 500;
        this.d_0.ClientSize = new Size(num1, num2);
        Rectangle rectangle_2 = new Rectangle(0, 0, this.d_0.ClientSize.Width, this.d_0.ClientSize.Height);
        c.gclass0_4.method_15(rectangle_2);
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Title = "Open Video";//Module.a("\uF8B6즸\uDEBA펼龾韀ꫂꇄꋆꛈ", int_0);
        openFileDialog.AddExtension = true;
        openFileDialog.CheckFileExists = true;
        openFileDialog.CheckPathExists = true;
//        openFileDialog.Filter = Module.a("\uE1B6킸\uDFBA\uD8BC킾\uE1C0藂계ꯆ곈\uE3CA\uE7CC\uE1CEꋐꓒ돔ﯖ\uF3D8\uF5DA볜꧞裠쿢쿤짦黨蛪鯬쏮\uDBF0\uDDF2飴蟶鳸鳺퇼헾⼀渂甄怆 眊✌ℎ成搒猔Ⱆ㌘㔚簜椞䠠ᠢ༤द帨䘪嬬ᐮᬰᴲ場䜶尸尺ؼᔾ潀⹂㕄⁆㕈\u0A4A⅌⍎煐ᕒ㱔㭖㱘獚睜煞䭠䩢ᥤ䵦䝨䅪", int_0);
        openFileDialog.Filter = Module.a("\uE1B6킸\uDFBA\uD8BC킾\uE1C0藂계ꯆ곈\uE3CA\uE7CC\uE1CEꋐꓒ돔ﯖ\uF3D8\uF5DA볜꧞裠쿢쿤짦黨蛪鯬쏮\uDBF0\uDDF2飴蟶鳸鳺퇼헾⼀渂甄怆 眊✌ℎ成搒猔Ⱆ㌘㔚簜椞䠠ᠢ༤द帨䘪嬬ᐮᬰᴲ場䜶尸尺ؼᔾ潀⹂㕄⁆㕈\u0A4A⅌⍎煐ᕒ㱔㭖㱘獚睜煞䭠䩢ᥤ䵦䝨䅪", int_0);

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            if (this.bool_28)
                this.menuItem_9_Click(sender, e);
            this.d_0.Show();
            this.d_0.Location = new Point(500, 400);
 //           if (openFileDialog.FileName.ToLower().EndsWith(Module.a("馶쪸첺\uDBBC", int_0)))
            if (openFileDialog.FileName.ToLower().EndsWith(".swf"))
            {
                if (this.bool_20)
                {
                    this.d_0.method_2();
                    this.bool_20 = false;
                }
                this.d_0.TransparencyKey = Color.FromArgb(0);
                this.bool_20 = false;
                this.d_0.FormBorderStyle = FormBorderStyle.FixedToolWindow;
                this.d_0.axShockwaveFlash_0.Visible = true;
                this.d_0.axShockwaveFlash_0.BackgroundColor = 1;
                this.d_0.axShockwaveFlash_0.Movie = openFileDialog.FileName;
                if (this.bool_19)
                    this.d_0.axShockwaveFlash_0.Play();
                else
                    this.d_0.axShockwaveFlash_0.Stop();
                this.int_64 = this.d_0.axShockwaveFlash_0.TotalFrames;
                this.bool_20 = false;
            }
            else
            {
                if (this.bool_20)
                {
                    this.d_0.method_2();
                    this.bool_20 = false;
                }
                this.bool_20 = true;
                this.d_0.FormBorderStyle = FormBorderStyle.None;
                this.d_0.method_0(openFileDialog.FileName, num1, num2);
            }
            this.bool_57 = true;
            this.bool_50 = false;
            this.bool_37 = true;
            this.timer_1.Interval = 1000 / c.smethod_0();
            this.timer_1.Enabled = true;
            this.bool_39 = true;
            this.bool_40 = false;
            this.genum1_1 = GEnum1.const_4;
            this.method_31();
        }
        else
        {
            this.method_13();
            if (flag)
                this.d_0.Show();
            if (this.bool_22)
            {
                this.d_0.ClientSize = new Size(400, 400);
                rectangle_2 = new Rectangle(0, 0, this.d_0.ClientSize.Width, this.d_0.ClientSize.Height);
                c.gclass0_4.method_15(rectangle_2);
            }
        }
        if (this.bool_28)
            this.r_0.Show();
        this.BringToFront();
    }

    private void method_20(string string_24)
    {
        int int_0 = 9;
        if (this.bool_28)
            this.r_0.Hide();
 //       if ((c.string_7 == Module.a("ﮮﶰ\uE0B2閴\uE1B6貸隺\uF0BC", int_0) || c.string_7 == Module.a("\uECAE쒰솲솴횶킸햺鶼\uE9BE\uF4C0", int_0)) && c.smethod_0() > 20)
            if ((c.string_7 == "TLS V5-M" || c.string_7 == "Curtain V5") && c.smethod_0() > 20)
                c.smethod_1(20);
        this.timer_1.Interval = 1000 / c.smethod_0();
        c.int_59 = 0;
        c.int_58 = 0;
        this.BringToFront();
        if (this.d_0.Visible)
            this.d_0.Hide();
        this.method_13();
        this.d_0.ClientSize = new Size(this.int_67, this.int_68);
        this.d_0.Show();
        this.d_0.Location = new Point(500, 400);
 //       if (string_24.ToLower().EndsWith(Module.a("膮슰쒲펴", int_0)))
        if (string_24.ToLower().EndsWith(".swf"))
        {
                this.d_0.method_2();
            this.d_0.TransparencyKey = Color.FromArgb(0);
            this.bool_20 = false;
            this.d_0.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.d_0.axShockwaveFlash_0.Visible = true;
            this.d_0.axShockwaveFlash_0.Movie = string_24;
            if (this.bool_19)
                this.d_0.axShockwaveFlash_0.Play();
            else
                this.d_0.axShockwaveFlash_0.Stop();
            this.int_64 = this.d_0.axShockwaveFlash_0.TotalFrames;
            this.bool_20 = false;
        }
        else
        {
            this.bool_20 = true;
            this.d_0.FormBorderStyle = FormBorderStyle.None;
            this.d_0.method_0(string_24, this.int_67, this.int_68);
        }
        this.bool_57 = true;
        this.bool_50 = false;
        this.bool_37 = true;
        this.timer_1.Interval = 1000 / c.smethod_0();
        this.timer_1.Enabled = true;
        this.bool_39 = true;
        this.bool_40 = false;
        this.genum1_1 = GEnum1.const_4;
        this.method_31();
        if (this.bool_28)
            this.r_0.Show();
        this.BringToFront();
    }

    private void method_21(string string_24)
    {
        this.bool_19 = false;
        this.menuItem_9_Click((object)null, (EventArgs)null);
        this.bool_22 = true;
        c.int_59 = 0;
        c.int_58 = 0;
        if (this.bool_28)
        {
            this.bool_28 = false;
            this.method_75();
        }
        this.d_0.Hide();
        this.d_0.ClientSize = new Size(400, 400);
        Rectangle rectangle_2 = new Rectangle(0, 0, this.d_0.ClientSize.Width, this.d_0.ClientSize.Height);
        c.gclass0_4.method_15(rectangle_2);
        this.d_0.TransparencyKey = Color.FromArgb(0);
        this.d_0.axShockwaveFlash_0.Visible = true;
        this.d_0.Show();
        this.d_0.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width + 30, 400);
        this.d_0.axShockwaveFlash_0.Movie = string_24;
        if (this.bool_19)
            this.d_0.axShockwaveFlash_0.Play();
        else
            this.d_0.axShockwaveFlash_0.Stop();
        this.int_64 = this.d_0.axShockwaveFlash_0.TotalFrames;
        this.bool_57 = true;
        this.bool_50 = false;
        this.bool_37 = true;
        this.timer_1.Interval = 1000 / c.smethod_0();
        this.timer_1.Enabled = true;
        this.bool_39 = true;
        this.bool_40 = false;
        this.genum1_1 = GEnum1.const_4;
        this.method_31();
        this.BringToFront();
    }

    private void method_22()
    {
        int int_0 = 15;
        if (this.bool_28)
        {
            this.bool_28 = false;
            this.method_75();
        }
        this.bool_37 = false;
        this.timer_1.Interval = 1000 / c.smethod_0();
        this.timer_1.Enabled = false;
        this.bool_25 = false;
        this.Location = new Point(0, 0);
        if (this.d_0.axShockwaveFlash_0.Movie != null)
        {
            this.d_0.axShockwaveFlash_0.Stop();
            this.d_0.axShockwaveFlash_0.Movie = (string)null;
            string path = Application.StartupPath + (object)'\\' + "pre_1.swf";//Module.a("어얶\uDCB8\uE4BA貼醾닀듂ꏄ", int_0);
            if (System.IO.File.Exists(path))
                this.d_0.axShockwaveFlash_0.Movie = path;
            this.d_0.axShockwaveFlash_0.Movie = (string)null;
        }
        this.d_0.Hide();
        this.bool_39 = false;
        this.genum1_1 = !this.bool_40 ? GEnum1.const_2 : GEnum1.const_6;
        if (Convert.ToInt32(this.string_11[4]) == 1 && System.IO.File.Exists(this.string_20 + (object)'\\' + this.string_11[5]))
            this.genum1_1 = GEnum1.const_6;
        this.method_31();
        this.method_13();
    }

    private void menuItem_9_Click(object sender, EventArgs e)
    {
        if (this.bool_13)
        {
            this.bool_13 = false;
            this.method_86();
        }
        this.bool_22 = false;
        if (this.bool_28)
        {
            this.bool_28 = false;
            this.method_75();
        }
        this.bool_37 = false;
        this.timer_1.Interval = 1000 / c.smethod_0();
        this.timer_1.Enabled = false;
        this.bool_25 = false;
        this.Location = new Point(0, 0);
        if (this.bool_20)
        {
            this.d_0.method_2();
            this.bool_20 = false;
        }
        else
            this.d_0.axShockwaveFlash_0.Stop();
        this.d_0.Hide();
        this.bool_39 = false;
        this.genum1_1 = !this.bool_40 ? GEnum1.const_2 : GEnum1.const_6;
        if (Convert.ToInt32(this.string_11[4]) == 1 && System.IO.File.Exists(this.string_20 + (object)'\\' + this.string_11[5]))
            this.genum1_1 = GEnum1.const_6;
        this.method_31();
        this.method_13();
    }

    private void method_23(object sender, EventArgs e)
    {
        this.bool_57 = true;
        this.d_0.axShockwaveFlash_0.GotoFrame(0);
        if (!this.bool_19)
            return;
        this.d_0.axShockwaveFlash_0.Play();
    }

    private void method_24(object sender, EventArgs e)
    {
        this.bool_57 = true;
        this.d_0.axShockwaveFlash_0.GotoFrame(0);
        if (!this.bool_19)
            return;
        this.d_0.axShockwaveFlash_0.Play();
    }

    private void method_25()
    {
        this.listBox_0.Items.Clear();
        for (int index = 0; index < c.arrayList_4.Count; ++index)
            this.listBox_0.Items.Add((object)((GClass5)c.arrayList_4[index]).string_0);
    }

    private void menuItem_12_Click(object sender, EventArgs e)
    {
        int int_0 = 5;
        this.bool_8 = false;
        this.method_77();
        if (this.genum1_1 != GEnum1.const_0)
        {
            switch (!c.useEnglishLanguage ? MessageBox.Show("是否关傔䩞穓㱷먁", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) : MessageBox.Show("Whether to close the current project?", "Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2))
            {
                case DialogResult.Yes:
                    this.menuItem_29_Click((object)null, (EventArgs)null);
                    break;
                case DialogResult.No:
                    return;
            }
        }
        this.treeView_0.Nodes.Clear();
        this.timer_1.Enabled = false;
        if (!c.bool_32)
            this.method_1();
        this.WindowState = FormWindowState.Maximized;
        this.int_69 = this.Size.Width;
        this.int_70 = this.Size.Height;
        c.int_71 = this.panel_1.Width;
        c.int_72 = this.panel_1.Height;
        f f = new f();
        if (f.ShowDialog() != DialogResult.OK)
            return;
        string path1 = f.method_2();
        this.int_82 = c.int_74;
        this.string_16 = path1;
        int length1 = path1.LastIndexOf('\\');
        string str = path1.Substring(length1 + 1);
        int length2 = str.IndexOf('.');
        this.string_22 = str.Substring(0, length2);
        c.string_23 = this.string_22;
        this.string_20 = path1.Substring(0, length1);
        c.string_21 = this.string_20;
        c.string_17 = c.string_21 + "\\jiemu1i.ini"; // Module.a("\uF7AA재욮풰\uDEB2살蚶킸閺풼톾ꣀ", int_0);
        this.string_11[0] = "1"; //  Module.a("骪", int_0);
        this.string_11[1] = c.string_0;
        this.string_11[2] = "0"; // Module.a("鮪", int_0);
        this.string_11[3] = "ss"; //  Module.a("\uD8AA\uDEAC", int_0);
        this.string_11[4] = "0"; // Module.a("鮪", int_0);
        this.string_11[5] = "ss"; // Module.a("\uD8AA\uDEAC", int_0);
        this.string_11[6] = "0"; // Module.a("鮪", int_0);
        this.string_11[7] = "ss"; // Module.a("\uD8AA\uDEAC", int_0);
        this.string_11[8] = "0"; // Module.a("鮪", int_0);
        this.string_11[9] = "0"; // Module.a("鮪", int_0);
        this.string_11[10] = c.int_2.ToString();
        this.string_11[11] = c.int_74.ToString();
        this.string_11[12] = c.smethod_0().ToString();
        this.string_11[13] = c.int_81.ToString();
        this.string_11[14] = "0"; // Module.a("鮪", int_0);
        this.string_11[15] = c.int_8.ToString();
        this.string_11[16] = c.int_9.ToString();
        this.string_11[17] = c.int_10.ToString();
        this.string_11[18] = c.byte_0.ToString();
        this.string_11[19] = c.bool_1.ToString();
        this.string_11[20] = c.string_7;
        this.string_11[21] = c.bool_3.ToString();
        this.string_11[22] = c.byte_19.ToString();
        this.string_11[23] = "0"; // Module.a("鮪", int_0);
        this.string_11[24] = "0"; // Module.a("鮪", int_0);
        this.string_11[25] = c.bool_14.ToString();
        this.string_11[26] = c.bool_18.ToString();
        this.string_11[27] = c.bool_17.ToString();
        this.string_11[28] = c.byte_20.ToString();
        this.string_11[29] = c.bool_2.ToString();
        this.string_11[30] = c.byte_1.ToString();
        this.string_11[31] = c.byte_2.ToString();
        this.string_11[32] = c.byte_3.ToString();
        this.string_11[33] = c.byte_4.ToString();
        this.string_11[34] = c.byte_5.ToString();
        this.byte_33 = new byte[512];
        new Random().NextBytes(this.byte_33);
        byte num = 0;
        byte[] numArray = new byte[16]
        {
      (byte) 124,
      (byte) 94,
      (byte) 147,
      (byte) 57,
      (byte) 129,
      (byte) 146,
      (byte) 241,
      (byte) 139,
      (byte) 74,
      (byte) 169,
      (byte) 155,
      (byte) 15,
      (byte) 126,
      (byte) 44,
      (byte) 56,
      (byte) 161
        };
        for (int index1 = 14; index1 < 146; ++index1)
        {
            byte index2 = (byte)(index1 % 16);
            num += (byte)((uint)this.byte_33[index1] ^ (uint)numArray[(int)index2]);
        }
        for (int index = 185; index < 290; ++index)
            num += (byte)((uint)this.byte_33[index] ^ 165U);
        this.byte_44 = (byte)((uint)num ^ 90U);
        for (int index3 = 318; index3 < 420; ++index3)
        {
            byte index4 = (byte)(index3 % 16);
            num += (byte)((uint)this.byte_33[index3] ^ (uint)numArray[(int)index4]);
        }
        for (int index = 410; index < 501; ++index)
            num += (byte)((uint)this.byte_33[index] ^ 90U);
        this.byte_45 = (byte)((uint)num ^ 165U);
        try
        {
            using (StreamWriter streamWriter = new StreamWriter(path1, false, Encoding.Unicode))
            {
                for (int index = 0; index < this.string_11.Length; ++index)
                    streamWriter.WriteLine(this.string_11[index]);
                for (int index = 0; index < 512; ++index)
                    streamWriter.WriteLine(this.byte_33[index].ToString());
            }
        }
        catch
        {
        }
        string string_5;
        string string_4;
        if (c.useEnglishLanguage)
        {
            string_5 = "\\Program_1"; // Module.a("\uF7AAﶬ\uDDAE\uDEB0풲잴횶풸\uE4BA貼", int_0);
            string_4 = "program1";//Module.a("\uDBAA\uDFAC삮횰솲풴\uDAB6袸", int_0);
        }
        else
        {
            string_5 = "\\节目_1";//Module.a("\uF7AA⼮䇘\uEEB0芲", int_0);
            string_4 = "节目1"; //Module.a("⤨䏚麮", int_0);
        }
        string path2 = c.string_21 + string_5;
        if (Directory.Exists(path2))
            Directory.Delete(path2, true);
        GClass5 gclass5 = new GClass5(string_4, string_5, string_5 + "\\_rec.bin"); //Module.a("\uF7AA\uF2AC\uDDAE풰킲鮴햶킸햺", int_0));
        gclass5.gclass6_0[0] = new GClass6();
        gclass5.gclass6_0[1] = new GClass6();
        gclass5.gclass6_0[2] = new GClass6();
        gclass5.gclass6_0[3] = new GClass6();
        gclass5.gclass6_0[4] = new GClass6();
        if (!Directory.Exists(path2))
            Directory.CreateDirectory(path2);
        c.arrayList_4.Clear();
        c.arrayList_4.Add((object)gclass5);
        c.int_38 = 0;
        this.method_28();
        this.method_25();
        this.textBox_4.Text = this.listBox_0.Items[c.int_38].ToString();
        switch (c.int_81)
        {
            case 0:
                this.toolStripTextBox_2.Text = "RGB";
 //               this.toolStripTextBox_2.Text = Module.a("寧\uEAAC\uEDAE", int_0);
                break;
            case 1:
                this.toolStripTextBox_2.Text = "RBG";
//                this.toolStripTextBox_2.Text = Module.a("寧\uEFAC\uE8AE", int_0);
                break;
            case 2:
                this.toolStripTextBox_2.Text = "GRB";
//                this.toolStripTextBox_2.Text = Module.a("\uECAAﾬ\uEDAE", int_0);
                break;
            case 3:
                this.toolStripTextBox_2.Text = "GBR";
//                this.toolStripTextBox_2.Text = Module.a("\uECAA\uEFACﶮ", int_0);
                break;
            case 4:
                this.toolStripTextBox_2.Text = "BRG";
//                this.toolStripTextBox_2.Text = Module.a("\uE9AAﾬ\uE8AE", int_0);
                break;
            case 5:
                this.toolStripTextBox_2.Text = "BGR";
 //               this.toolStripTextBox_2.Text = Module.a("\uE9AA\uEAACﶮ", int_0);
                break;
            default:
                this.toolStripTextBox_2.Text = "RGB";
//                this.toolStripTextBox_2.Text = Module.a("寧\uEAAC\uEDAE", int_0);
                break;
        }
        this.toolStripTextBox_3.Text = c.string_7;
        this.genum1_1 = GEnum1.const_1;
        this.method_31();
        this.method_79();
        this.gclass0_2.method_12().ColorFill(Color.FromArgb(0, 0, 0));
        this.method_15();
//        this.Text = this.string_8 + Module.a("\uF0AA肬芮", int_0) + this.string_22 + (object)']';
        this.Text = this.string_8 + "[--" + this.string_22 + (object)']';
    }

    private void method_26(int int_93, string string_24)
    {
        try
        {
            using (StreamReader streamReader = new StreamReader(this.string_16, Encoding.Unicode))
            {
                for (int index = 0; index < this.string_11.Length; ++index)
                    this.string_11[index] = streamReader.ReadLine();
                for (int index = 0; index < 512; ++index)
                    this.byte_33[index] = Convert.ToByte(streamReader.ReadLine());
            }
        }
        catch
        {
        }
        this.string_11[int_93] = string_24;
        try
        {
            using (StreamWriter streamWriter = new StreamWriter(this.string_16, false, Encoding.Unicode))
            {
                for (int index = 0; index < this.string_11.Length; ++index)
                    streamWriter.WriteLine(this.string_11[index]);
                for (int index = 0; index < 512; ++index)
                    streamWriter.WriteLine(this.byte_33[index].ToString());
            }
        }
        catch
        {
        }
    }

    private bool method_27()
    {
        if (!System.IO.File.Exists(c.string_17))
            return false;
        try
        {
            using (StreamReader streamReader = new StreamReader(c.string_17, Encoding.Unicode))
            {
                string str = streamReader.ReadLine();
                int int32_1;
                try
                {
                    int32_1 = Convert.ToInt32(str);
                }
                catch
                {
                    return false;
                }
                c.arrayList_4.Clear();
                for (int index1 = 0; index1 < int32_1; ++index1)
                {
                    GClass5 gclass5 = new GClass5();
                    gclass5.gclass6_0[0] = new GClass6();
                    gclass5.gclass6_0[1] = new GClass6();
                    gclass5.gclass6_0[2] = new GClass6();
                    gclass5.gclass6_0[3] = new GClass6();
                    gclass5.gclass6_0[4] = new GClass6();
                    try
                    {
                        gclass5.bool_0 = Convert.ToBoolean(streamReader.ReadLine());
                        gclass5.bool_1 = Convert.ToBoolean(streamReader.ReadLine());
                        gclass5.bool_2 = Convert.ToBoolean(streamReader.ReadLine());
                        gclass5.string_0 = streamReader.ReadLine();
                        gclass5.string_2 = streamReader.ReadLine();
                        gclass5.string_1 = streamReader.ReadLine();
                        gclass5.int_0 = Convert.ToInt32(streamReader.ReadLine());
                        gclass5.string_3 = streamReader.ReadLine();
                        gclass5.int_1 = Convert.ToInt32(streamReader.ReadLine());
                        gclass5.bool_3 = Convert.ToBoolean(streamReader.ReadLine());
                        gclass5.int_2 = Convert.ToInt32(streamReader.ReadLine());
                        for (int index2 = 0; index2 < 5; ++index2)
                        {
                            gclass5.gclass6_0[index2].int_3 = Convert.ToInt32(streamReader.ReadLine());
                            gclass5.gclass6_0[index2].int_2 = Convert.ToInt32(streamReader.ReadLine());
                            int int32_2 = Convert.ToInt32(streamReader.ReadLine());
                            int int32_3 = Convert.ToInt32(streamReader.ReadLine());
                            int int32_4 = Convert.ToInt32(streamReader.ReadLine());
                            int int32_5 = Convert.ToInt32(streamReader.ReadLine());
                            gclass5.gclass6_0[index2].rectangle_0 = new Rectangle(int32_2, int32_3, int32_4, int32_5);
                            gclass5.gclass6_0[index2].bool_0 = Convert.ToBoolean(streamReader.ReadLine());
                            gclass5.gclass6_0[index2].string_0 = streamReader.ReadLine();
                            gclass5.gclass6_0[index2].bool_1 = Convert.ToBoolean(streamReader.ReadLine());
                            gclass5.gclass6_0[index2].int_0 = Convert.ToInt32(streamReader.ReadLine());
                            gclass5.gclass6_0[index2].int_1 = Convert.ToInt32(streamReader.ReadLine());
                            gclass5.gclass6_0[index2].bool_2 = Convert.ToBoolean(streamReader.ReadLine());
                            gclass5.gclass6_0[index2].int_4 = Convert.ToInt32(streamReader.ReadLine());
                            gclass5.gclass6_0[index2].int_5 = Convert.ToInt32(streamReader.ReadLine());
                            gclass5.gclass6_0[index2].int_6 = Convert.ToInt32(streamReader.ReadLine());
                            gclass5.gclass6_0[index2].int_7 = Convert.ToInt32(streamReader.ReadLine());
                            gclass5.gclass6_0[index2].int_8 = Convert.ToInt32(streamReader.ReadLine());
                            gclass5.gclass6_0[index2].int_9 = Convert.ToInt32(streamReader.ReadLine());
                            gclass5.gclass6_0[index2].int_10 = Convert.ToInt32(streamReader.ReadLine());
                            gclass5.gclass6_0[index2].int_11 = Convert.ToInt32(streamReader.ReadLine());
                            gclass5.gclass6_0[index2].int_12 = Convert.ToInt32(streamReader.ReadLine());
                            gclass5.gclass6_0[index2].int_13 = Convert.ToInt32(streamReader.ReadLine());
                            gclass5.gclass6_0[index2].int_14 = Convert.ToInt32(streamReader.ReadLine());
                            gclass5.gclass6_0[index2].int_15 = Convert.ToInt32(streamReader.ReadLine());
                            gclass5.gclass6_0[index2].int_16 = Convert.ToInt32(streamReader.ReadLine());
                            gclass5.gclass6_0[index2].int_17 = Convert.ToInt32(streamReader.ReadLine());
                            gclass5.gclass6_0[index2].int_18 = Convert.ToInt32(streamReader.ReadLine());
                            gclass5.gclass6_0[index2].int_19 = Convert.ToInt32(streamReader.ReadLine());
                            gclass5.gclass6_0[index2].int_20 = Convert.ToInt32(streamReader.ReadLine());
                            gclass5.gclass6_0[index2].int_21 = Convert.ToInt32(streamReader.ReadLine());
                        }
                    }
                    catch
                    {
                        return false;
                    }
                    c.arrayList_4.Add((object)gclass5);
                }
            }
        }
        catch
        {
        }
        return true;
    }

    private void method_28()
    {
        if (System.IO.File.Exists(c.string_17))
            System.IO.File.Delete(c.string_17);
        try
        {
            using (StreamWriter streamWriter = new StreamWriter(c.string_17, false, Encoding.Unicode))
            {
                streamWriter.WriteLine(c.arrayList_4.Count.ToString());
                for (int index1 = 0; index1 < c.arrayList_4.Count; ++index1)
                {
                    streamWriter.WriteLine(((GClass5)c.arrayList_4[index1]).bool_0.ToString());
                    streamWriter.WriteLine(((GClass5)c.arrayList_4[index1]).bool_1.ToString());
                    streamWriter.WriteLine(((GClass5)c.arrayList_4[index1]).bool_2.ToString());
                    streamWriter.WriteLine(((GClass5)c.arrayList_4[index1]).string_0);
                    streamWriter.WriteLine(((GClass5)c.arrayList_4[index1]).string_2);
                    streamWriter.WriteLine(((GClass5)c.arrayList_4[index1]).string_1);
                    streamWriter.WriteLine(((GClass5)c.arrayList_4[index1]).int_0.ToString());
                    streamWriter.WriteLine(((GClass5)c.arrayList_4[index1]).string_3);
                    streamWriter.WriteLine(((GClass5)c.arrayList_4[index1]).int_1.ToString());
                    streamWriter.WriteLine(((GClass5)c.arrayList_4[index1]).bool_3.ToString());
                    streamWriter.WriteLine(((GClass5)c.arrayList_4[index1]).int_2.ToString());
                    for (int index2 = 0; index2 < 5; ++index2)
                    {
                        streamWriter.WriteLine(((GClass5)c.arrayList_4[index1]).gclass6_0[index2].int_3.ToString());
                        streamWriter.WriteLine(((GClass5)c.arrayList_4[index1]).gclass6_0[index2].int_2.ToString());
                        streamWriter.WriteLine(((GClass5)c.arrayList_4[index1]).gclass6_0[index2].rectangle_0.X.ToString());
                        streamWriter.WriteLine(((GClass5)c.arrayList_4[index1]).gclass6_0[index2].rectangle_0.Y.ToString());
                        streamWriter.WriteLine(((GClass5)c.arrayList_4[index1]).gclass6_0[index2].rectangle_0.Width.ToString());
                        streamWriter.WriteLine(((GClass5)c.arrayList_4[index1]).gclass6_0[index2].rectangle_0.Height.ToString());
                        streamWriter.WriteLine(((GClass5)c.arrayList_4[index1]).gclass6_0[index2].bool_0.ToString());
                        streamWriter.WriteLine(((GClass5)c.arrayList_4[index1]).gclass6_0[index2].string_0);
                        streamWriter.WriteLine(((GClass5)c.arrayList_4[index1]).gclass6_0[index2].bool_1.ToString());
                        streamWriter.WriteLine(((GClass5)c.arrayList_4[index1]).gclass6_0[index2].int_0.ToString());
                        streamWriter.WriteLine(((GClass5)c.arrayList_4[index1]).gclass6_0[index2].int_1.ToString());
                        streamWriter.WriteLine(((GClass5)c.arrayList_4[index1]).gclass6_0[index2].bool_2.ToString());
                        streamWriter.WriteLine(((GClass5)c.arrayList_4[index1]).gclass6_0[index2].int_4.ToString());
                        streamWriter.WriteLine(((GClass5)c.arrayList_4[index1]).gclass6_0[index2].int_5.ToString());
                        streamWriter.WriteLine(((GClass5)c.arrayList_4[index1]).gclass6_0[index2].int_6.ToString());
                        streamWriter.WriteLine(((GClass5)c.arrayList_4[index1]).gclass6_0[index2].int_7.ToString());
                        streamWriter.WriteLine(((GClass5)c.arrayList_4[index1]).gclass6_0[index2].int_8.ToString());
                        streamWriter.WriteLine(((GClass5)c.arrayList_4[index1]).gclass6_0[index2].int_9.ToString());
                        streamWriter.WriteLine(((GClass5)c.arrayList_4[index1]).gclass6_0[index2].int_10.ToString());
                        streamWriter.WriteLine(((GClass5)c.arrayList_4[index1]).gclass6_0[index2].int_11.ToString());
                        streamWriter.WriteLine(((GClass5)c.arrayList_4[index1]).gclass6_0[index2].int_12.ToString());
                        streamWriter.WriteLine(((GClass5)c.arrayList_4[index1]).gclass6_0[index2].int_13.ToString());
                        streamWriter.WriteLine(((GClass5)c.arrayList_4[index1]).gclass6_0[index2].int_14.ToString());
                        streamWriter.WriteLine(((GClass5)c.arrayList_4[index1]).gclass6_0[index2].int_15.ToString());
                        streamWriter.WriteLine(((GClass5)c.arrayList_4[index1]).gclass6_0[index2].int_16.ToString());
                        streamWriter.WriteLine(((GClass5)c.arrayList_4[index1]).gclass6_0[index2].int_17.ToString());
                        streamWriter.WriteLine(((GClass5)c.arrayList_4[index1]).gclass6_0[index2].int_18.ToString());
                        streamWriter.WriteLine(((GClass5)c.arrayList_4[index1]).gclass6_0[index2].int_19.ToString());
                        streamWriter.WriteLine(((GClass5)c.arrayList_4[index1]).gclass6_0[index2].int_20.ToString());
                        streamWriter.WriteLine(((GClass5)c.arrayList_4[index1]).gclass6_0[index2].int_21.ToString());
                    }
                }
            }
        }
        catch
        {
        }
    }

    private string method_29(int int_93)
    {
        try
        {
            using (StreamReader streamReader = new StreamReader(this.string_16, Encoding.Unicode))
            {
                for (int index = 0; index < this.string_11.Length; ++index)
                    this.string_11[index] = streamReader.ReadLine();
            }
        }
        catch
        {
        }
        return this.string_11[int_93];
    }

    private void menuItem_14_Click(object sender, EventArgs e)
    {
//        int int_0 = 12;
        this.timer_1.Enabled = false;
        this.bool_7 = false;
        this.bool_8 = false;
        this.arrayList_1.Clear();
        this.method_80();
        c.byte_9 = (byte)1;
        if (new GForm0().ShowDialog() != DialogResult.OK)
            return;
        switch (this.method_5(0, (string)null))
        {
            case 1:
                c.gclass1_0 = new GClass1((Control)this.panel_0);
                Rectangle rectangle_2 = new Rectangle(0, 0, this.panel_0.Width, this.panel_0.Height);
                Rectangle rectangle_3 = new Rectangle(0, 0, this.panel_0.Width, this.panel_0.Height);
                this.gclass0_2 = new GClass0(c.gclass1_0.method_1(), rectangle_2, rectangle_3);
                this.gclass0_2.method_12().ColorFill(Color.FromArgb(0, 0, 0));
                this.method_15();
                this.genum1_1 = GEnum1.const_1;
                this.method_31();
                break;
            case 3:
                break;
            default:
//                this.method_26(4, Module.a("花", int_0));
//                this.method_26(6, Module.a("花", int_0));
                this.method_26(4, "0");
                this.method_26(6, "0");
                this.genum1_1 = GEnum1.const_2;
                this.method_31();
                this.method_81();
                break;
        }
    }

    //Open Project File
    private void menuItem_13_Click(object sender, EventArgs e)
    {
        int int_0 = 12;
        this.bool_8 = false;
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Title = "Open";
        //        openFileDialog.Title = Module.a("ﶱ쒳펵횷", 12);
        openFileDialog.Filter = "Project File(*.pxb)|*.pxb|All File(*.*)|*.*";
        //        openFileDialog.Filter = Module.a("\uE2B1욳\uD9B5튷\uDFB9\uDFBB쪽\uE0BF蓁귃\uAAC5귇\uE2C9\uE6CB\uE0CDꃏ\uAAD1뛓ￕꓗ\uF0D9\uF2DB껝食胡飣\uA7E5蓧蛩쳫꣭駯黱釳\uDEF5틷퓹훻\uD7FD糿⠁⨃Ⰵ", 12);
        openFileDialog.RestoreDirectory = true;
        if (openFileDialog.ShowDialog() != DialogResult.OK)
            return;
        this.method_30(openFileDialog.FileName);
        if (!this.method_27())
        {
            if (c.useEnglishLanguage)
                this.ShowMessage("Failed to load program list!");
            //        this.ShowMessage(Module.a("\uF4B1햳\uDFB5풷\uDFB9\uD8BB麽뒿귁\uE4C3\uAAC5\uA7C7ꯉ\uA8CB\uEECD\uA4CF뫑뇓\uF6D5꣗꣙돛망鋟菡解웥蓧菩\u9FEB髭퇯", int_0));
            else
                //                this.ShowMessage(Module.a("ዣ줼㐷囁귫퐳迤\uE532쌾", int_0));
                this.ShowMessage("加载节目列表失败");
        }
        else
        {
            c.int_38 = 0;
            if (((GClass5)c.arrayList_4[c.int_38]).bool_2 && this.genum1_1 == GEnum1.const_2)
            {
                this.genum1_1 = GEnum1.const_6;
                this.method_31();
            }
            this.method_25();
            this.textBox_4.Text = this.listBox_0.Items[c.int_38].ToString();
            this.method_15();
            this.method_81();
        }
    }

    private void method_30(string string_24)
    {
        int int_0 = 0;
        this.string_16 = string_24;
        if (!c.bool_32)
            this.method_1();
        this.WindowState = FormWindowState.Maximized;
        this.int_69 = this.Size.Width;
        this.int_70 = this.Size.Height;
        c.int_71 = this.panel_1.Width;
        c.int_72 = this.panel_1.Height;
        int length1 = string_24.LastIndexOf('\\');
        string str1 = string_24.Substring(length1 + 1);
        int length2 = str1.IndexOf('.');
        this.string_22 = str1.Substring(0, length2);
        c.string_23 = this.string_22;
        this.string_20 = string_24.Substring(0, length1);
        c.string_21 = this.string_20;
        c.string_17 = c.string_21 + Module.a("瘟슧쎩즫쎭얯莱\uDDB3颵톷풹햻", int_0);
        this.byte_33 = new byte[512];
        try
        {
            using (StreamReader streamReader = new StreamReader(this.string_16, Encoding.Unicode))
            {
                for (int index = 0; index < this.string_11.Length; ++index)
                    this.string_11[index] = streamReader.ReadLine();
                for (int index = 0; index < 512; ++index)
                    this.byte_33[index] = Convert.ToByte(streamReader.ReadLine());
            }
        }
        catch
        {
        }
        byte num = 0;
        byte[] numArray = new byte[16]
        {
      (byte) 124,
      (byte) 94,
      (byte) 147,
      (byte) 57,
      (byte) 129,
      (byte) 146,
      (byte) 241,
      (byte) 139,
      (byte) 74,
      (byte) 169,
      (byte) 155,
      (byte) 15,
      (byte) 126,
      (byte) 44,
      (byte) 56,
      (byte) 161
        };
        for (int index1 = 14; index1 < 146; ++index1)
        {
            byte index2 = (byte)(index1 % 16);
            num += (byte)((uint)this.byte_33[index1] ^ (uint)numArray[(int)index2]);
        }
        for (int index = 185; index < 290; ++index)
            num += (byte)((uint)this.byte_33[index] ^ 165U);
        this.byte_44 = (byte)((uint)num ^ 90U);
        for (int index3 = 318; index3 < 420; ++index3)
        {
            byte index4 = (byte)(index3 % 16);
            num += (byte)((uint)this.byte_33[index3] ^ (uint)numArray[(int)index4]);
        }
        for (int index = 410; index < 501; ++index)
            num += (byte)((uint)this.byte_33[index] ^ 90U);
        this.byte_45 = (byte)((uint)num ^ 165U);
        if (Convert.ToInt32(this.string_11[12]) == 0)
        {
            c.int_73 = 30;
        }
        else
        {
            int int32 = Convert.ToInt32(this.string_11[12]);
            if (int32 > 0 && int32 < 31)
            {
                c.int_73 = int32;
            }
            else
            {
                c.int_73 = 30;
                this.method_26(12, Module.a("閥颧", int_0));
            }
        }
        c.int_2 = Convert.ToInt32(this.string_11[10]);
        c.int_81 = 0;
        try
        {
            c.int_74 = Convert.ToInt32(this.string_11[11]);
            c.int_81 = Convert.ToInt32(this.string_11[13]);
            c.byte_0 = Convert.ToByte(this.string_11[18]);
            c.int_8 = Convert.ToInt32(this.string_11[15]);
            c.int_9 = Convert.ToInt32(this.string_11[16]);
            c.int_10 = Convert.ToInt32(this.string_11[17]);
            c.byte_19 = Convert.ToByte(this.string_11[22]);
            c.bool_14 = Convert.ToBoolean(this.string_11[25]);
            c.bool_18 = Convert.ToBoolean(this.string_11[26]);
            c.bool_17 = Convert.ToBoolean(this.string_11[27]);
            c.byte_20 = Convert.ToByte(this.string_11[28]);
            c.bool_2 = Convert.ToBoolean(this.string_11[29]);
            c.byte_1 = Convert.ToByte(this.string_11[30]);
            c.byte_2 = Convert.ToByte(this.string_11[31]);
            c.byte_3 = Convert.ToByte(this.string_11[32]);
            c.byte_4 = Convert.ToByte(this.string_11[33]);
            c.byte_5 = Convert.ToByte(this.string_11[34]);
        }
        catch
        {
        }
        string path = c.string_21 + (object)'\\' + c.string_23 + Module.a("袥쾧잩솫", int_0);
        if (System.IO.File.Exists(path))
        {
            using (StreamReader streamReader = new StreamReader(path, Encoding.Unicode))
            {
                try
                {
                    c.double_2 = Convert.ToDouble(streamReader.ReadLine());
                    c.byte_13 = Convert.ToByte(streamReader.ReadLine());
                    c.byte_14 = Convert.ToByte(streamReader.ReadLine());
                    c.byte_15 = Convert.ToByte(streamReader.ReadLine());
                    c.int_81 = Convert.ToInt32(streamReader.ReadLine());
                }
                catch
                {
                    c.double_2 = 1.8;
                    c.byte_13 = byte.MaxValue;
                    c.byte_14 = byte.MaxValue;
                    c.byte_15 = byte.MaxValue;
                }
            }
        }
        else
        {
            c.double_2 = 1.8;
            c.byte_13 = byte.MaxValue;
            c.byte_14 = byte.MaxValue;
            c.byte_15 = byte.MaxValue;
        }
        this.method_79();
        if (c.int_2 == 2 || c.int_2 == 16 || c.int_2 == 110)
            c.bool_1 = Convert.ToBoolean(this.string_11[19]);
        if (c.int_2 == 12 || c.int_2 == 31)
            c.bool_3 = Convert.ToBoolean(this.string_11[21]);
        switch (c.int_81)
        {
            case 0:
                this.toolStripTextBox_2.Text = Module.a("\uF4A5\uEFA7\uE8A9", int_0);
                break;
            case 1:
                this.toolStripTextBox_2.Text = Module.a("\uF4A5\uEAA7\uEDA9", int_0);
                break;
            case 2:
                this.toolStripTextBox_2.Text = Module.a("\uE1A5盛\uE8A9", int_0);
                break;
            case 3:
                this.toolStripTextBox_2.Text = Module.a("\uE1A5\uEAA7\uF8A9", int_0);
                break;
            case 4:
                this.toolStripTextBox_2.Text = Module.a("\uE4A5盛\uEDA9", int_0);
                break;
            case 5:
                this.toolStripTextBox_2.Text = Module.a("\uE4A5\uEFA7\uF8A9", int_0);
                break;
            default:
                this.toolStripTextBox_2.Text = Module.a("\uF4A5\uEFA7\uE8A9", int_0);
                break;
        }
        this.int_82 = c.int_74;
        try
        {
            c.int_78 = Convert.ToInt32(this.string_11[14]);
        }
        catch
        {
            c.int_78 = c.int_77;
        }
        this.arrayList_1.Clear();
        if (Convert.ToInt32(this.string_11[23]) == 1)
        {
            string str2 = this.string_20 + (object)'\\' + this.string_11[24];
            if (System.IO.File.Exists(str2))
            {
                if (this.method_10(str2) != 0)
                {
                    c.gclass1_0 = new GClass1((Control)this.panel_0);
                    Rectangle rectangle_2 = new Rectangle(0, 0, this.panel_0.Width, this.panel_0.Height);
                    Rectangle rectangle_3 = new Rectangle(0, 0, this.panel_0.Width, this.panel_0.Height);
                    this.gclass0_2 = new GClass0(c.gclass1_0.method_1(), rectangle_2, rectangle_3);
                    this.gclass0_2.method_12().ColorFill(Color.FromArgb(0, 0, 0));
                    this.method_15();
                    this.genum1_1 = GEnum1.const_1;
                    this.method_31();
                }
                else
                {
                    this.genum1_1 = GEnum1.const_2;
                    this.method_31();
                }
            }
            else
            {
                this.genum1_1 = GEnum1.const_1;
                this.method_31();
            }
        }
        else if (Convert.ToInt32(this.string_11[2]) == 1)
        {
            string str3 = this.string_20 + (object)'\\' + this.string_11[3];
            if (System.IO.File.Exists(str3))
            {
                if (this.method_5(1, str3) != 0)
                {
                    c.gclass1_0 = new GClass1((Control)this.panel_0);
                    Rectangle rectangle_2 = new Rectangle(0, 0, this.panel_0.Width, this.panel_0.Height);
                    Rectangle rectangle_3 = new Rectangle(0, 0, this.panel_0.Width, this.panel_0.Height);
                    this.gclass0_2 = new GClass0(c.gclass1_0.method_1(), rectangle_2, rectangle_3);
                    this.gclass0_2.method_12().ColorFill(Color.FromArgb(0, 0, 0));
                    this.method_15();
                    this.genum1_1 = GEnum1.const_1;
                    this.method_31();
                }
                else
                {
                    this.genum1_1 = GEnum1.const_2;
                    this.method_31();
                }
            }
            else
            {
                this.genum1_1 = GEnum1.const_1;
                this.method_31();
            }
        }
        else if (Convert.ToInt32(this.string_11[2]) == 2)
        {
            string str4 = this.string_20 + (object)'\\' + this.string_11[3];
            if (System.IO.File.Exists(str4))
            {
                if (this.method_82(str4) != 0)
                {
                    c.gclass1_0 = new GClass1((Control)this.panel_0);
                    Rectangle rectangle_2 = new Rectangle(0, 0, this.panel_0.Width, this.panel_0.Height);
                    Rectangle rectangle_3 = new Rectangle(0, 0, this.panel_0.Width, this.panel_0.Height);
                    this.gclass0_2 = new GClass0(c.gclass1_0.method_1(), rectangle_2, rectangle_3);
                    this.gclass0_2.method_12().ColorFill(Color.FromArgb(0, 0, 0));
                    this.method_15();
                    this.genum1_1 = GEnum1.const_1;
                    this.method_31();
                }
                else
                {
                    this.genum1_1 = GEnum1.const_2;
                    this.method_31();
                }
            }
            else
            {
                this.genum1_1 = GEnum1.const_1;
                this.method_31();
            }
        }
        else
        {
            this.genum1_1 = GEnum1.const_1;
            this.method_31();
        }
        if (Convert.ToInt32(this.string_11[4]) == 1 && System.IO.File.Exists(this.string_20 + (object)'\\' + this.string_11[5]) && this.genum1_1 == GEnum1.const_2)
        {
            this.genum1_1 = GEnum1.const_6;
            this.method_31();
        }
        c.string_7 = this.string_11[20];
        this.toolStripTextBox_3.Text = c.string_7;
        this.Text = this.string_8 + Module.a("ﶥ薧螩", int_0) + this.string_22 + (object)']';
    }

    private void method_31()
    {
        int int_0 = 10;
        this.treeView_0.Enabled = false;
        switch (this.genum1_1)
        {
            case GEnum1.const_0:
                this.menuItem_12.Enabled = true;
                this.menuItem_13.Enabled = true;
                this.menuItem_14.Enabled = false;
                this.menuItem_1.Enabled = false;
                this.menuItem_7.Enabled = false;
                this.menuItem_8.Enabled = false;
                this.menuItem_9.Enabled = false;
                this.menuItem_66.Enabled = false;
                this.menuItem_10.Enabled = false;
                this.menuItem_3.Enabled = false;
                this.menuItem_5.Enabled = false;
                this.menuItem_6.Enabled = false;
                this.menuItem_113.Enabled = false;
                this.menuItem_15.Enabled = false;
                this.menuItem_26.Enabled = false;
                this.menuItem_27.Enabled = false;
                this.menuItem_28.Enabled = false;
                this.menuItem_25.Enabled = false;
                break;
            case GEnum1.const_1:
                this.menuItem_12.Enabled = true;
                this.menuItem_13.Enabled = true;
                this.menuItem_14.Enabled = true;
                this.menuItem_1.Enabled = false;
                this.menuItem_7.Enabled = false;
                this.menuItem_8.Enabled = false;
                this.menuItem_9.Enabled = false;
                this.menuItem_66.Enabled = false;
                this.menuItem_10.Enabled = false;
                this.menuItem_3.Enabled = false;
                this.menuItem_5.Enabled = false;
                this.menuItem_6.Enabled = false;
                this.menuItem_113.Enabled = false;
                this.menuItem_15.Enabled = true;
                break;
            case GEnum1.const_2:
                this.menuItem_12.Enabled = true;
                this.menuItem_13.Enabled = true;
                this.menuItem_14.Enabled = true;
                this.menuItem_1.Enabled = true;
                this.menuItem_7.Enabled = false;
                this.menuItem_8.Enabled = true;
                this.menuItem_9.Enabled = false;
                this.menuItem_66.Enabled = false;
                this.menuItem_10.Enabled = false;
                this.menuItem_3.Enabled = false;
                this.menuItem_5.Enabled = false;
                this.menuItem_6.Enabled = false;
                this.menuItem_113.Enabled = false;
                this.menuItem_15.Enabled = true;
                this.treeView_0.Enabled = true;
                break;
            case GEnum1.const_3:
                this.menuItem_12.Enabled = false;
                this.menuItem_13.Enabled = false;
                this.menuItem_14.Enabled = false;
                this.menuItem_1.Enabled = false;
                this.menuItem_8.Enabled = false;
                this.menuItem_9.Enabled = false;
                this.menuItem_66.Enabled = false;
                this.menuItem_10.Enabled = true;
                this.menuItem_3.Enabled = false;
                this.menuItem_5.Enabled = false;
                this.menuItem_6.Enabled = false;
                this.menuItem_113.Enabled = false;
                this.menuItem_15.Enabled = false;
                this.menuItem_7.Enabled = !this.bool_30;
                break;
            case GEnum1.const_4:
                this.menuItem_12.Enabled = false;
                this.menuItem_13.Enabled = false;
                this.menuItem_14.Enabled = false;
                this.menuItem_1.Enabled = false;
                this.menuItem_7.Enabled = false;
                this.menuItem_8.Enabled = true;
                this.menuItem_66.Enabled = true;
                this.menuItem_10.Enabled = true;
                this.menuItem_3.Enabled = false;
                this.menuItem_5.Enabled = false;
                this.menuItem_6.Enabled = false;
                this.menuItem_113.Enabled = true;
                this.menuItem_15.Enabled = false;
                this.menuItem_9.Enabled = !this.bool_30;
                if (this.bool_25)
                {
                    this.menuItem_113.Enabled = false;
                    this.menuItem_66.Enabled = false;
                    break;
                }
                break;
            case GEnum1.const_5:
                this.menuItem_12.Enabled = false;
                this.menuItem_13.Enabled = false;
                this.menuItem_14.Enabled = false;
                this.menuItem_1.Enabled = false;
                this.menuItem_7.Enabled = false;
                this.menuItem_8.Enabled = false;
                this.menuItem_9.Enabled = false;
                this.menuItem_66.Enabled = false;
                this.menuItem_10.Enabled = false;
                this.menuItem_3.Enabled = true;
                this.menuItem_5.Enabled = false;
                this.menuItem_6.Enabled = false;
                this.menuItem_113.Enabled = false;
                this.menuItem_15.Enabled = false;
                break;
            case GEnum1.const_6:
                this.menuItem_12.Enabled = true;
                this.menuItem_13.Enabled = true;
                this.menuItem_14.Enabled = true;
                this.menuItem_1.Enabled = true;
                this.menuItem_7.Enabled = false;
                this.menuItem_8.Enabled = true;
                this.menuItem_9.Enabled = false;
                this.menuItem_66.Enabled = false;
                this.menuItem_10.Enabled = false;
                this.menuItem_3.Enabled = false;
                this.menuItem_5.Enabled = true;
                this.menuItem_6.Enabled = false;
                this.menuItem_113.Enabled = false;
                this.menuItem_15.Enabled = true;
                this.treeView_0.Enabled = true;
                break;
            case GEnum1.const_7:
                this.menuItem_12.Enabled = false;
                this.menuItem_13.Enabled = false;
                this.menuItem_14.Enabled = false;
                this.menuItem_1.Enabled = false;
                this.menuItem_7.Enabled = false;
                this.menuItem_8.Enabled = false;
                this.menuItem_9.Enabled = false;
                this.menuItem_66.Enabled = false;
                this.menuItem_10.Enabled = false;
                this.menuItem_3.Enabled = false;
                this.menuItem_5.Enabled = false;
                this.menuItem_6.Enabled = true;
                this.menuItem_113.Enabled = false;
                this.menuItem_15.Enabled = false;
                break;
            case GEnum1.const_8:
                this.menuItem_12.Enabled = false;
                this.menuItem_13.Enabled = false;
                this.menuItem_14.Enabled = false;
                this.menuItem_1.Enabled = false;
                this.menuItem_7.Enabled = false;
                this.menuItem_8.Enabled = false;
                this.menuItem_9.Enabled = false;
                this.menuItem_66.Enabled = false;
                this.menuItem_10.Enabled = false;
                this.menuItem_3.Enabled = false;
                this.menuItem_5.Enabled = false;
                this.menuItem_6.Enabled = false;
                this.menuItem_113.Enabled = false;
                this.menuItem_15.Enabled = false;
                break;
            case GEnum1.const_9:
                this.menuItem_12.Enabled = false;
                this.menuItem_13.Enabled = false;
                this.menuItem_14.Enabled = false;
                this.menuItem_1.Enabled = false;
                this.menuItem_7.Enabled = false;
                this.menuItem_8.Enabled = false;
                this.menuItem_9.Enabled = false;
                this.menuItem_66.Enabled = false;
                this.menuItem_10.Enabled = false;
                this.menuItem_3.Enabled = false;
                this.menuItem_5.Enabled = false;
                this.menuItem_6.Enabled = false;
                this.menuItem_113.Enabled = false;
                this.menuItem_15.Enabled = false;
                break;
        }
        this.menuItem_17.Enabled = this.menuItem_14.Enabled;
        this.menuItem_20.Enabled = this.menuItem_10.Enabled;
        this.menuItem_21.Enabled = this.menuItem_113.Enabled;
        if (this.bool_20)
            this.menuItem_21.Enabled = false;
        this.menuItem_29.Enabled = this.menuItem_15.Enabled;
        this.menuItem_33.Enabled = this.menuItem_5.Enabled;
        this.menuItem_38.Enabled = this.menuItem_14.Enabled;
        if (!this.menuItem_9.Enabled && !this.menuItem_7.Enabled)
        {
            this.menuItem_36.Enabled = false;
        }
        else
        {
            if (c.int_2 > 80)
                this.menuItem_36.Enabled = true;
            this.menuItem_38.Enabled = true;
        }
        if (!this.menuItem_6.Enabled && !this.menuItem_34.Enabled)
            this.MinimizeBox = true;
        else
            this.MinimizeBox = false;
        if (c.int_2 < 80)
        {
            this.menuItem_32.Visible = false;
            this.menuItem_35.Visible = false;
        }
        else
        {
            this.menuItem_32.Visible = true;
            this.menuItem_35.Visible = true;
        }
        this.toolStripButton_5.Enabled = this.menuItem_12.Enabled;
        this.toolStripButton_0.Enabled = this.menuItem_13.Enabled;
        this.toolStripButton_7.Enabled = this.menuItem_15.Enabled;
        this.toolStripButton_1.Enabled = this.menuItem_8.Enabled;
        this.toolStripButton_2.Enabled = this.menuItem_9.Enabled;
        this.toolStripButton_3.Enabled = this.menuItem_10.Enabled;
        this.toolStripButton_4.Enabled = this.menuItem_3.Enabled;
        this.toolStripButton_12.Enabled = this.menuItem_5.Enabled;
        this.toolStripButton_13.Enabled = this.menuItem_6.Enabled;
        this.toolStripButton_6.Enabled = this.menuItem_8.Enabled;
        this.toolStripButton_8.Enabled = this.menuItem_19.Enabled;
        this.toolStripButton_9.Enabled = this.menuItem_14.Enabled;
        this.toolStripButton_10.Enabled = this.menuItem_1.Enabled;
        this.toolStripButton_11.Enabled = this.menuItem_7.Enabled;
        this.toolStripButton_15.Enabled = this.menuItem_25.Enabled;
        this.toolStripButton_18.Enabled = this.menuItem_28.Enabled;
        this.toolStripButton_16.Enabled = this.menuItem_26.Enabled;
        this.toolStripButton_17.Enabled = this.menuItem_27.Enabled;
        this.menuItem_41.Enabled = this.menuItem_33.Enabled;
        this.menuItem_57.Enabled = this.menuItem_1.Enabled;
        this.menuItem_59.Enabled = this.menuItem_5.Enabled;
        this.menuItem_42.Enabled = this.menuItem_8.Enabled;
        this.menuItem_43.Enabled = this.menuItem_8.Enabled;
        this.menuItem_44.Enabled = this.menuItem_8.Enabled;
        this.menuItem_45.Enabled = this.menuItem_8.Enabled;
        this.menuItem_46.Enabled = this.menuItem_8.Enabled;
        this.menuItem_47.Enabled = this.menuItem_8.Enabled;
        this.menuItem_48.Enabled = this.menuItem_8.Enabled;
        this.menuItem_49.Enabled = this.menuItem_8.Enabled;
        this.menuItem_50.Enabled = this.menuItem_8.Enabled;
        this.menuItem_51.Enabled = this.menuItem_8.Enabled;
        this.menuItem_52.Enabled = this.menuItem_8.Enabled;
        this.menuItem_53.Enabled = this.menuItem_8.Enabled;
        this.menuItem_54.Enabled = this.menuItem_8.Enabled;
        this.menuItem_55.Enabled = this.menuItem_8.Enabled;
        this.menuItem_56.Enabled = this.menuItem_8.Enabled;
        this.menuItem_88.Enabled = this.menuItem_8.Enabled;
        this.menuItem_89.Enabled = this.menuItem_8.Enabled;
        this.menuItem_90.Enabled = this.menuItem_8.Enabled;
        this.menuItem_68.Enabled = this.menuItem_5.Enabled;
        this.menuItem_67.Enabled = this.menuItem_5.Enabled;
        this.menuItem_70.Enabled = this.menuItem_9.Enabled;
        this.menuItem_71.Enabled = this.menuItem_9.Enabled;
        this.menuItem_81.Enabled = this.menuItem_7.Enabled;
        this.menuItem_82.Enabled = this.menuItem_7.Enabled;
        this.menuItem_83.Enabled = this.menuItem_1.Enabled;
        this.menuItem_73.Enabled = this.menuItem_14.Enabled;
        this.menuItem_93.Enabled = this.menuItem_14.Enabled;
        if (this.genum1_1 != GEnum1.const_3)
        {
            if (this.genum1_1 != GEnum1.const_4)
                goto label_31;
        }
        try
        {
            if (Convert.ToInt32(this.method_29(4)) == 1)
            {
                this.menuItem_68.Enabled = true;
                this.menuItem_67.Enabled = true;
            }
            else
            {
                this.menuItem_68.Enabled = false;
                this.menuItem_67.Enabled = false;
            }
        }
        catch
        {
        }
    label_31:
        this.toolStripButton_19.Enabled = this.menuItem_38.Enabled;
        this.toolStripButton_20.Enabled = this.menuItem_38.Enabled;
        if (this.genum1_1 == GEnum1.const_9)
        {
            this.toolStripButton_19.Enabled = true;
            this.toolStripButton_20.Enabled = true;
            this.menuItem_38.Enabled = true;
        }
        this.menuItem_63.Enabled = true;
        this.menuItem_62.Enabled = this.menuItem_1.Enabled;
        this.menuItem_61.Enabled = this.menuItem_8.Enabled;
        this.menuItem_64.Enabled = this.menuItem_5.Enabled;
        this.toolStripButton_14.Enabled = false;
        if (this.menuItem_34.Enabled)
        {
            if (c.useEnglishLanguage)
                this.toolStripButton_14.ToolTipText = Module.a("\uE3AF욱\uDBB3욵颷﮹즻쪽꾿\uE2C1铃\uAAC5꧇돉", int_0);
            else
                this.toolStripButton_14.ToolTipText = Module.a("\uECFF탚\uE033賒ᗓ蓜", int_0);
            this.toolStripButton_14.Enabled = true;
        }
        this.panel_3.Visible = false;
        if (this.menuItem_37.Enabled)
        {
            if (c.useEnglishLanguage)
            {
                this.toolStripButton_14.ToolTipText = Module.a("\uE3AF욱\uDBB3욵颷\uE8B9\uD9BB\uDFBD겿뛁귃ꯅ귇\uEAC9鳋ꋍ뇏ꯑ", int_0);
                this.label_11.Text = Module.a("\uE2AFힱ햳\uDAB5첷펹톻\uDBBD\uE0BF鋁ꣃ\uA7C5뇇ꏉꋋ꧍ﻏﳑ䀘\uF8D5\uF6D7\uF4D9", int_0);
            }
            else
            {
                this.toolStripButton_14.ToolTipText = Module.a("\uECFF탚⫨䃐ᗓ蓜", int_0);
                this.label_11.Text = Module.a("\u2EF4䓔᧗裐闹钹銻邽\uEEBF\uECC1\uEAC3", int_0);
            }
            this.toolStripButton_14.Enabled = true;
            this.panel_3.Visible = true;
        }
        if (this.menuItem_40.Enabled)
        {
            if (c.useEnglishLanguage)
                this.label_11.Text = Module.a("\uF1AF잱삳\uD9B5颷\uEAB9킻\uDFBD릿ꯁ\uAAC3ꇅ\uE6C7\uE4C9\uE2CB\uE0CDﻏﳑ", int_0);
            else
                this.label_11.Text = Module.a("\uE42F裖᧗裐闹钹銻邽\uEEBF\uECC1\uEAC3", int_0);
            this.panel_3.Visible = true;
        }
        this.menuItem_72.Enabled = true;
        this.menuItem_79.Enabled = this.menuItem_8.Enabled;
        this.menuItem_17.Enabled = this.menuItem_8.Enabled;
        this.toolStripButton_24.Enabled = this.menuItem_72.Enabled;
        this.toolStripButton_25.Enabled = this.toolStripButton_9.Enabled;
        this.toolStripButton_26.Enabled = this.menuItem_59.Enabled;
        if (c.int_2 > 80)
        {
            this.toolStripButton_21.Enabled = this.menuItem_62.Enabled;
            this.toolStripButton_22.Enabled = this.menuItem_41.Enabled;
            this.toolStripButton_23.Enabled = this.menuItem_33.Enabled;
        }
        else
        {
            this.toolStripButton_21.Enabled = false;
            this.toolStripButton_22.Enabled = false;
            this.toolStripButton_23.Enabled = false;
        }
        this.menuItem_58.Enabled = c.bool_32;
        if (c.int_2 != 103 && c.int_2 != 14 && c.int_2 != 15)
        {
            this.menuItem_42.Visible = true;
            this.menuItem_43.Visible = true;
            this.menuItem_44.Visible = true;
            this.menuItem_45.Visible = true;
            this.menuItem_46.Visible = true;
        }
        else
        {
            this.menuItem_42.Visible = false;
            this.menuItem_43.Visible = false;
            this.menuItem_44.Visible = false;
            this.menuItem_45.Visible = false;
            this.menuItem_46.Visible = false;
        }
        if (c.useEnglishLanguage)
        {
            this.menuItem_77.Checked = false;
            this.menuItem_78.Checked = true;
        }
        else
        {
            this.menuItem_77.Checked = true;
            this.menuItem_78.Checked = false;
        }
        this.menuItem_80.Enabled = c.i_0.Visible;
        this.menuItem_41.Visible = true;
        this.toolStripTextBox_1.Text = c.smethod_0().ToString();
        this.menuItem_86.Enabled = this.menuItem_64.Enabled;
        this.menuItem_91.Enabled = this.menuItem_1.Enabled;
        this.menuItem_92.Enabled = this.menuItem_8.Enabled;
        this.menuItem_94.Enabled = this.menuItem_21.Enabled;
        this.menuItem_95.Enabled = this.menuItem_59.Enabled;
        this.menuItem_104.Enabled = this.menuItem_8.Enabled;
        this.menuItem_96.Enabled = this.menuItem_61.Enabled;
        this.menuItem_87.Enabled = c.byte_1 != (byte)0;
        this.toolStripMenuItem_5.Enabled = this.menuItem_83.Enabled;
        this.toolStripMenuItem_6.Enabled = this.menuItem_19.Enabled;
        this.toolStripMenuItem_7.Enabled = this.menuItem_38.Enabled;
        this.toolStripMenuItem_8.Enabled = this.menuItem_57.Enabled;
        this.toolStripMenuItem_9.Enabled = this.menuItem_63.Enabled;
        this.toolStripMenuItem_10.Enabled = this.menuItem_87.Enabled;
        this.toolStripMenuItem_11.Enabled = this.menuItem_17.Enabled;
        this.toolStripMenuItem_12.Enabled = this.menuItem_70.Enabled;
        this.toolStripMenuItem_13.Enabled = this.menuItem_71.Enabled;
    }

    private void method_32(StreamWriter streamWriter_0, int int_93, int int_94, double double_9)
    {
        this.int_37 += 8;
        streamWriter_0.WriteLine(Module.a("颷骹費", 18));
        streamWriter_0.WriteLine(Module.a("﮷\uF3B9\uEEBBﶽ貿蟁", 18));
        streamWriter_0.WriteLine(Module.a("颷骹覻", 18));
        streamWriter_0.WriteLine(this.int_37.ToString());
        streamWriter_0.WriteLine(Module.a("颷骹蒻", 18));
        streamWriter_0.WriteLine(Module.a("袷", 18));
        streamWriter_0.WriteLine(Module.a("颷讹費", 18));
        streamWriter_0.WriteLine(int_93.ToString());
        streamWriter_0.WriteLine(Module.a("颷袹費", 18));
        streamWriter_0.WriteLine(int_94.ToString());
        streamWriter_0.WriteLine(Module.a("颷覹費", 18));
        streamWriter_0.WriteLine(Module.a("袷钹費", 18));
        streamWriter_0.WriteLine(Module.a("颷躹費", 18));
        streamWriter_0.WriteLine(double_9.ToString());
    }

    private void method_33(StreamWriter streamWriter_0, int int_93, int int_94, double double_9)
    {
        this.int_37 += 8;
        streamWriter_0.WriteLine(Module.a("钳隵袷", 14));
        streamWriter_0.WriteLine(Module.a("\uF7B3ﾵ\uEAB7惡\uF0BB﮽", 14));
        streamWriter_0.WriteLine(Module.a("钳隵趷", 14));
        streamWriter_0.WriteLine(this.int_37.ToString());
        streamWriter_0.WriteLine(Module.a("钳隵肷", 14));
        streamWriter_0.WriteLine(Module.a("蒳", 14));
        streamWriter_0.WriteLine(Module.a("钳肵誷", 14));
        streamWriter_0.WriteLine(Module.a("钳隵颷骹鲻辽", 14));
        streamWriter_0.WriteLine(Module.a("钳螵袷", 14));
        streamWriter_0.WriteLine(int_93.ToString());
        streamWriter_0.WriteLine(Module.a("钳蒵袷", 14));
        streamWriter_0.WriteLine(int_94.ToString());
        streamWriter_0.WriteLine(Module.a("钳薵袷", 14));
        streamWriter_0.WriteLine(Module.a("蒳颵袷", 14));
        streamWriter_0.WriteLine(Module.a("钳芵袷", 14));
        streamWriter_0.WriteLine(double_9.ToString());
    }

    private void method_34(
      StreamWriter streamWriter_0,
      double double_9,
      double double_10,
      double double_11,
      double double_12)
    {
        ++this.int_37;
        streamWriter_0.WriteLine(Module.a("鎲閴螶", 13));
        streamWriter_0.WriteLine(Module.a("ﾲﲴ禮ﲸ", 13));
        streamWriter_0.WriteLine(Module.a("鎲閴芶", 13));
        streamWriter_0.WriteLine(this.int_37.ToString());
        streamWriter_0.WriteLine(Module.a("鎲閴辶", 13));
        streamWriter_0.WriteLine(Module.a("莲", 13));
        streamWriter_0.WriteLine(Module.a("鎲蒴螶", 13));
        streamWriter_0.WriteLine(double_9.ToString());
        streamWriter_0.WriteLine(Module.a("鎲螴螶", 13));
        streamWriter_0.WriteLine(double_10.ToString());
        streamWriter_0.WriteLine(Module.a("鎲蚴螶", 13));
        streamWriter_0.WriteLine(Module.a("莲鮴螶", 13));
        streamWriter_0.WriteLine(Module.a("鎲蒴蚶", 13));
        streamWriter_0.WriteLine(double_11.ToString());
        streamWriter_0.WriteLine(Module.a("鎲螴蚶", 13));
        streamWriter_0.WriteLine(double_12.ToString());
        streamWriter_0.WriteLine(Module.a("鎲蚴蚶", 13));
        streamWriter_0.WriteLine(Module.a("莲鮴螶", 13));
    }

    private void method_35(
      StreamWriter streamWriter_0,
      double double_9,
      double double_10,
      double double_11,
      double double_12)
    {
        ++this.int_37;
        streamWriter_0.WriteLine(Module.a("钳隵袷", 14));
        streamWriter_0.WriteLine(Module.a("\uF8B3ﾵ\uF6B7ﾹ", 14));
        streamWriter_0.WriteLine(Module.a("钳隵趷", 14));
        streamWriter_0.WriteLine(this.int_37.ToString());
        streamWriter_0.WriteLine(Module.a("钳隵肷", 14));
        streamWriter_0.WriteLine(Module.a("蒳", 14));
        streamWriter_0.WriteLine(Module.a("钳肵誷", 14));
        streamWriter_0.WriteLine(Module.a("钳隵颷骹鲻辽", 14));
        streamWriter_0.WriteLine(Module.a("钳螵袷", 14));
        streamWriter_0.WriteLine(double_9.ToString());
        streamWriter_0.WriteLine(Module.a("钳蒵袷", 14));
        streamWriter_0.WriteLine(double_10.ToString());
        streamWriter_0.WriteLine(Module.a("钳薵袷", 14));
        streamWriter_0.WriteLine(Module.a("蒳颵袷", 14));
        streamWriter_0.WriteLine(Module.a("钳螵覷", 14));
        streamWriter_0.WriteLine(double_11.ToString());
        streamWriter_0.WriteLine(Module.a("钳蒵覷", 14));
        streamWriter_0.WriteLine(double_12.ToString());
        streamWriter_0.WriteLine(Module.a("钳薵覷", 14));
        streamWriter_0.WriteLine(Module.a("蒳颵袷", 14));
    }

    private void method_36(
      StreamWriter streamWriter_0,
      double double_9,
      double double_10,
      int int_93)
    {
        ++this.int_37;
        streamWriter_0.WriteLine(Module.a("螦覨鮪", 1));
        streamWriter_0.WriteLine(Module.a("\uF3A6\uECA8\uF3AA怜", 1));
        streamWriter_0.WriteLine(Module.a("螦覨麪", 1));
        streamWriter_0.WriteLine(this.int_37.ToString());
        streamWriter_0.WriteLine(Module.a("螦覨鎪", 1));
        streamWriter_0.WriteLine(Module.a("鞦", 1));
        streamWriter_0.WriteLine(Module.a("螦龨馪", 1));
        streamWriter_0.WriteLine(Module.a("螦覨讪趬辮肰", 1));
        streamWriter_0.WriteLine(Module.a("螦風鮪", 1));
        streamWriter_0.WriteLine(double_9.ToString());
        streamWriter_0.WriteLine(Module.a("螦鮨鮪", 1));
        streamWriter_0.WriteLine(double_10.ToString());
        streamWriter_0.WriteLine(Module.a("螦骨鮪", 1));
        streamWriter_0.WriteLine(Module.a("鞦螨鮪", 1));
        streamWriter_0.WriteLine(Module.a("螦鶨鮪", 1));
        streamWriter_0.WriteLine(Module.a("隦螨鮪", 1));
        streamWriter_0.WriteLine(Module.a("螦覨骪", 1));
        streamWriter_0.WriteLine(Module.a("\uD7A6", 1) + int_93.ToString());
    }

    private void method_37(StreamWriter streamWriter_0, int int_93, double double_9, int int_94)
    {
        ++this.int_37;
        streamWriter_0.WriteLine(Module.a("隵颷誹", 16));
        streamWriter_0.WriteLine(Module.a("\uE2B5ﶷ\uE2B9\uE8BB", 16));
        streamWriter_0.WriteLine(Module.a("隵颷边", 16));
        streamWriter_0.WriteLine(this.int_37.ToString());
        streamWriter_0.WriteLine(Module.a("隵颷芹", 16));
        streamWriter_0.WriteLine(Module.a("蚵", 16));
        streamWriter_0.WriteLine(Module.a("隵躷袹", 16));
        streamWriter_0.WriteLine(Module.a("隵颷骹鲻麽\uF1BF", 16));
        streamWriter_0.WriteLine(Module.a("隵覷誹", 16));
        streamWriter_0.WriteLine(int_93.ToString());
        streamWriter_0.WriteLine(Module.a("隵誷誹", 16));
        streamWriter_0.WriteLine(double_9.ToString());
        streamWriter_0.WriteLine(Module.a("隵讷誹", 16));
        streamWriter_0.WriteLine(Module.a("蚵隷誹", 16));
        streamWriter_0.WriteLine(Module.a("隵買誹", 16));
        streamWriter_0.WriteLine(Module.a("螵隷誹", 16));
        streamWriter_0.WriteLine(Module.a("隵颷讹", 16));
        streamWriter_0.WriteLine(int_94.ToString());
    }

    private void method_38(int int_93, int int_94, int int_95)
    {
        for (int index1 = 0; index1 < 8; ++index1)
        {
            GClass8 gclass8 = new GClass8(int_95 + index1, 256);
            for (int index2 = 0; index2 < 16; ++index2)
            {
                for (int index3 = 7; index3 >= 0; --index3)
                {
                    gclass8.method_7(gclass8.method_0(), new Point(index2 * 8 + int_93 * 128 + index3, index1 + int_94 * 16));
                    gclass8.method_1(gclass8.method_0() + 1);
                }
                for (int index4 = 0; index4 < 8; ++index4)
                {
                    gclass8.method_7(gclass8.method_0(), new Point(index2 * 8 + int_93 * 128 + index4, index1 + 8 + int_94 * 16));
                    gclass8.method_1(gclass8.method_0() + 1);
                }
            }
            this.arrayList_3.Add((object)gclass8);
        }
    }

    private void menuItem_15_Click(object sender, EventArgs e)
    {
        int int_0 = 13;
        this.timer_1.Enabled = false;
        this.bool_7 = false;
        this.bool_8 = false;
        this.arrayList_1.Clear();
        this.method_80();
        int int32_1;
        int int32_2;
        int int32_3;
        while (true)
        {
            y y = new y();
            if (y.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    int32_1 = Convert.ToInt32(y.method_0());
                    int32_2 = Convert.ToInt32(y.method_1());
                    int32_3 = Convert.ToInt32(y.method_2());
                    goto label_6;
                }
                catch
                {
                    if (c.useEnglishLanguage)
                        this.ShowMessage(Module.a("\uF6B2\uDBB4쎶쮸슺鶼\uDABE돀뇂\uAAC4뗆\uE5C8\uEBCA뷌ꏎ듐닒ꛔ닖律뻚돜ꯞ蓠釢엤蛦軨諪蓬臮탰", int_0));
                    else
                        this.ShowMessage(Module.a("‽탥긣嘳띅䨷爯熥偍ꂕ옹", int_0));
                }
            }
            else
                break;
        }
        return;
    label_6:
        c.int_78 = 0;
        this.method_26(14, c.int_78.ToString());
        this.arrayList_3.Clear();
        if (c.int_2 == 201)
        {
            this.method_38(0, 0, 0);
            this.method_38(0, 1, 8);
            this.method_38(1, 0, 16);
            this.method_38(1, 1, 24);
        }
        else
        {
            int int_2 = 0;
            GClass8 gclass8 = new GClass8(0, int32_3);
            switch (y.int_0)
            {
                case 0:
                    int num1 = 0;
                    for (int y = 0; y < int32_2; ++y)
                    {
                        if (num1 % 2 == 0)
                        {
                        label_16:
                            for (int x = 0; x < int32_1; ++x)
                            {
                                gclass8.method_7(gclass8.method_0(), new Point(x, y));
                                gclass8.method_1(gclass8.method_0() + 1);
                                if (gclass8.method_0() >= int32_3)
                                {
                                    this.arrayList_3.Add((object)gclass8);
                                    ++int_2;
                                    gclass8 = new GClass8(int_2, int32_3);
                                    if (x == int32_1 - 1 && y < int32_2 - 1)
                                    {
                                        ++y;
                                        goto label_16;
                                    }
                                }
                            }
                            ++num1;
                        }
                        else
                        {
                            for (int x = int32_1 - 1; x >= 0; --x)
                            {
                                gclass8.method_7(gclass8.method_0(), new Point(x, y));
                                gclass8.method_1(gclass8.method_0() + 1);
                                if (gclass8.method_0() >= int32_3)
                                {
                                    this.arrayList_3.Add((object)gclass8);
                                    ++int_2;
                                    gclass8 = new GClass8(int_2, int32_3);
                                }
                            }
                            ++num1;
                        }
                    }
                    break;
                case 1:
                    int num2 = 0;
                    for (int y = 0; y < int32_2; ++y)
                    {
                        if (num2 % 2 == 0)
                        {
                        label_33:
                            for (int x = int32_1 - 1; x >= 0; --x)
                            {
                                gclass8.method_7(gclass8.method_0(), new Point(x, y));
                                gclass8.method_1(gclass8.method_0() + 1);
                                if (gclass8.method_0() >= int32_3)
                                {
                                    this.arrayList_3.Add((object)gclass8);
                                    ++int_2;
                                    gclass8 = new GClass8(int_2, int32_3);
                                    if (x == 0 && y < int32_2 - 1)
                                    {
                                        ++y;
                                        goto label_33;
                                    }
                                }
                            }
                            ++num2;
                        }
                        else
                        {
                            for (int x = 0; x < int32_1; ++x)
                            {
                                gclass8.method_7(gclass8.method_0(), new Point(x, y));
                                gclass8.method_1(gclass8.method_0() + 1);
                                if (gclass8.method_0() >= int32_3)
                                {
                                    this.arrayList_3.Add((object)gclass8);
                                    ++int_2;
                                    gclass8 = new GClass8(int_2, int32_3);
                                }
                            }
                            ++num2;
                        }
                    }
                    break;
                case 2:
                    int num3 = 0;
                    for (int x = 0; x < int32_1; ++x)
                    {
                        if (num3 % 2 == 0)
                        {
                        label_50:
                            for (int y = 0; y < int32_2; ++y)
                            {
                                gclass8.method_7(gclass8.method_0(), new Point(x, y));
                                gclass8.method_1(gclass8.method_0() + 1);
                                if (gclass8.method_0() >= int32_3)
                                {
                                    this.arrayList_3.Add((object)gclass8);
                                    ++int_2;
                                    gclass8 = new GClass8(int_2, int32_3);
                                    if (y == int32_2 - 1 && x < int32_1 - 1)
                                    {
                                        ++x;
                                        goto label_50;
                                    }
                                }
                            }
                            ++num3;
                        }
                        else
                        {
                            for (int y = int32_2 - 1; y >= 0; --y)
                            {
                                gclass8.method_7(gclass8.method_0(), new Point(x, y));
                                gclass8.method_1(gclass8.method_0() + 1);
                                if (gclass8.method_0() >= int32_3)
                                {
                                    this.arrayList_3.Add((object)gclass8);
                                    ++int_2;
                                    gclass8 = new GClass8(int_2, int32_3);
                                }
                            }
                            ++num3;
                        }
                    }
                    break;
                case 3:
                    int num4 = 0;
                    for (int x = int32_1 - 1; x >= 0; --x)
                    {
                        if (num4 % 2 == 0)
                        {
                        label_67:
                            for (int y = 0; y < int32_2; ++y)
                            {
                                gclass8.method_7(gclass8.method_0(), new Point(x, y));
                                gclass8.method_1(gclass8.method_0() + 1);
                                if (gclass8.method_0() >= int32_3)
                                {
                                    this.arrayList_3.Add((object)gclass8);
                                    ++int_2;
                                    gclass8 = new GClass8(int_2, int32_3);
                                    if (y == int32_2 - 1 && x > 0)
                                    {
                                        --x;
                                        goto label_67;
                                    }
                                }
                            }
                            ++num4;
                        }
                        else
                        {
                            for (int y = int32_2 - 1; y >= 0; --y)
                            {
                                gclass8.method_7(gclass8.method_0(), new Point(x, y));
                                gclass8.method_1(gclass8.method_0() + 1);
                                if (gclass8.method_0() >= int32_3)
                                {
                                    this.arrayList_3.Add((object)gclass8);
                                    ++int_2;
                                    gclass8 = new GClass8(int_2, int32_3);
                                }
                            }
                            ++num4;
                        }
                    }
                    break;
                case 4:
                    int num5 = 0;
                    for (int y = int32_2 - 1; y >= 0; --y)
                    {
                        if (num5 % 2 == 0)
                        {
                        label_84:
                            for (int x = 0; x < int32_1; ++x)
                            {
                                gclass8.method_7(gclass8.method_0(), new Point(x, y));
                                gclass8.method_1(gclass8.method_0() + 1);
                                if (gclass8.method_0() >= int32_3)
                                {
                                    this.arrayList_3.Add((object)gclass8);
                                    ++int_2;
                                    gclass8 = new GClass8(int_2, int32_3);
                                    if (x == int32_1 - 1 && y > 0)
                                    {
                                        --y;
                                        goto label_84;
                                    }
                                }
                            }
                            ++num5;
                        }
                        else
                        {
                            for (int x = int32_1 - 1; x >= 0; --x)
                            {
                                gclass8.method_7(gclass8.method_0(), new Point(x, y));
                                gclass8.method_1(gclass8.method_0() + 1);
                                if (gclass8.method_0() >= int32_3)
                                {
                                    this.arrayList_3.Add((object)gclass8);
                                    ++int_2;
                                    gclass8 = new GClass8(int_2, int32_3);
                                }
                            }
                            ++num5;
                        }
                    }
                    break;
                case 5:
                    int num6 = 0;
                    for (int y = int32_2 - 1; y >= 0; --y)
                    {
                        if (num6 % 2 == 0)
                        {
                        label_101:
                            for (int x = int32_1 - 1; x >= 0; --x)
                            {
                                gclass8.method_7(gclass8.method_0(), new Point(x, y));
                                gclass8.method_1(gclass8.method_0() + 1);
                                if (gclass8.method_0() >= int32_3)
                                {
                                    this.arrayList_3.Add((object)gclass8);
                                    ++int_2;
                                    gclass8 = new GClass8(int_2, int32_3);
                                    if (x == 0 && y > 0)
                                    {
                                        --y;
                                        goto label_101;
                                    }
                                }
                            }
                            ++num6;
                        }
                        else
                        {
                            for (int x = 0; x < int32_1; ++x)
                            {
                                gclass8.method_7(gclass8.method_0(), new Point(x, y));
                                gclass8.method_1(gclass8.method_0() + 1);
                                if (gclass8.method_0() >= int32_3)
                                {
                                    this.arrayList_3.Add((object)gclass8);
                                    ++int_2;
                                    gclass8 = new GClass8(int_2, int32_3);
                                }
                            }
                            ++num6;
                        }
                    }
                    break;
                case 6:
                    int num7 = 0;
                    for (int x = 0; x < int32_1; ++x)
                    {
                        if (num7 % 2 == 0)
                        {
                        label_118:
                            for (int y = int32_2 - 1; y >= 0; --y)
                            {
                                gclass8.method_7(gclass8.method_0(), new Point(x, y));
                                gclass8.method_1(gclass8.method_0() + 1);
                                if (gclass8.method_0() >= int32_3)
                                {
                                    this.arrayList_3.Add((object)gclass8);
                                    ++int_2;
                                    gclass8 = new GClass8(int_2, int32_3);
                                    if (y == 0 && x < int32_1 - 1)
                                    {
                                        ++x;
                                        goto label_118;
                                    }
                                }
                            }
                            ++num7;
                        }
                        else
                        {
                            for (int y = 0; y < int32_2; ++y)
                            {
                                gclass8.method_7(gclass8.method_0(), new Point(x, y));
                                gclass8.method_1(gclass8.method_0() + 1);
                                if (gclass8.method_0() >= int32_3)
                                {
                                    this.arrayList_3.Add((object)gclass8);
                                    ++int_2;
                                    gclass8 = new GClass8(int_2, int32_3);
                                }
                            }
                            ++num7;
                        }
                    }
                    break;
                case 7:
                    int num8 = 0;
                    for (int x = int32_1 - 1; x >= 0; --x)
                    {
                        if (num8 % 2 == 0)
                        {
                        label_135:
                            for (int y = int32_2 - 1; y >= 0; --y)
                            {
                                gclass8.method_7(gclass8.method_0(), new Point(x, y));
                                gclass8.method_1(gclass8.method_0() + 1);
                                if (gclass8.method_0() >= int32_3)
                                {
                                    this.arrayList_3.Add((object)gclass8);
                                    ++int_2;
                                    gclass8 = new GClass8(int_2, int32_3);
                                    if (y == 0 && x > 0)
                                    {
                                        --x;
                                        goto label_135;
                                    }
                                }
                            }
                            ++num8;
                        }
                        else
                        {
                            for (int y = 0; y < int32_2; ++y)
                            {
                                gclass8.method_7(gclass8.method_0(), new Point(x, y));
                                gclass8.method_1(gclass8.method_0() + 1);
                                if (gclass8.method_0() >= int32_3)
                                {
                                    this.arrayList_3.Add((object)gclass8);
                                    ++int_2;
                                    gclass8 = new GClass8(int_2, int32_3);
                                }
                            }
                            ++num8;
                        }
                    }
                    break;
                case 8:
                    for (int x = 0; x < int32_1; ++x)
                    {
                        for (int y = 0; y < int32_2; ++y)
                        {
                            gclass8.method_7(gclass8.method_0(), new Point(x, y));
                            gclass8.method_1(gclass8.method_0() + 1);
                            if (gclass8.method_0() >= int32_3)
                            {
                                this.arrayList_3.Add((object)gclass8);
                                ++int_2;
                                gclass8 = new GClass8(int_2, int32_3);
                            }
                        }
                    }
                    break;
            }
            if (gclass8.method_0() < int32_3 && gclass8.method_0() > 0)
                this.arrayList_3.Add((object)gclass8);
        }
        this.int_23 = this.arrayList_3.Count;
        this.int_23 = this.int_23 % c.int_75 != 0 ? (this.int_23 / c.int_75 + 1) * c.int_75 : this.int_23 / c.int_75 * c.int_75;
        c.int_65 = int32_1;
        c.int_66 = int32_2;
        this.double_3 = 0.5;
        this.int_18 = (int)(this.double_3 * 2.0);
        if (c.int_65 < 500 && c.int_66 < 400)
        {
            int num9 = 500 / c.int_65;
            int num10 = 400 / c.int_66;
            int num11 = num9 > num10 ? num10 : num9;
            this.int_24 = c.int_65 * num11;
            this.int_25 = c.int_66 * num11;
        }
        else
        {
            this.int_24 = c.int_65;
            this.int_25 = c.int_66;
        }
        this.int_41 = 0;
        this.int_42 = 0;
        foreach (GClass8 gclass8 in this.arrayList_3)
        {
            this.int_41 += gclass8.method_0();
            if (this.int_42 < gclass8.method_0())
                this.int_42 = gclass8.method_0();
        }
        int num12 = 0;
        foreach (GClass8 gclass8 in this.arrayList_3)
        {
            if (gclass8.method_0() > num12)
                num12 = gclass8.method_0();
        }
        if (c.int_2 == 9)
            this.int_82 = num12 <= 1024 ? 1024 : 2048;
        else if (c.int_2 == 13 || c.int_2 == 32 || c.int_2 == 47 || c.int_2 == 52)
            this.int_82 = num12 <= 1536 ? (num12 <= 1024 ? (num12 <= 512 ? 512 : 1024) : 1536) : 2048;
        switch (c.int_2)
        {
            case 101:
                this.int_82 = 256;
                break;
            case 103:
                this.int_82 = 512;
                break;
        }
        if (c.int_2 == 2 || c.int_2 == 49 || c.int_2 == 16 || c.int_2 == 110 || c.int_2 == 83)
        {
            if (!c.bool_1)
            {
                int num13 = 0;
                foreach (GClass8 gclass8 in this.arrayList_3)
                {
                    if (gclass8.method_0() > num13)
                        num13 = gclass8.method_0();
                }
                c.int_74 = num13 % 128 != 0 ? (num13 / 128 + 1) * 128 : num13 / 128 * 128;
                this.int_82 = c.int_74;
                this.method_26(11, c.int_74.ToString());
            }
            else
            {
                c.int_74 = 170;
                this.int_82 = c.int_74;
                this.method_26(11, c.int_74.ToString());
            }
            this.byte_29 = (byte)(this.int_82 / 128);
            if (this.byte_29 == (byte)1)
                c.int_3 = 30;
            else if (this.byte_29 == (byte)2)
                c.int_3 = 29;
            else if (this.byte_29 == (byte)3)
                c.int_3 = 20;
            else if (this.byte_29 == (byte)4)
                c.int_3 = 14;
            if (c.int_2 == 16 && !c.bool_1)
            {
                c.int_74 = 512;
                this.int_82 = c.int_74;
                this.method_26(11, c.int_74.ToString());
            }
            this.int_62 = this.int_82 * 24 / 1024;
            this.int_63 = this.int_82 * 24;
            c.smethod_1(c.int_3);
            this.method_26(12, c.smethod_0().ToString());
            if (c.bool_1)
            {
                this.int_62 = 4;
                this.int_63 = 4096;
                this.byte_29 = (byte)0;
                c.int_3 = 30;
                switch (c.int_2)
                {
                    case 2:
                    case 49:
                        this.int_39 = 4096;
                        break;
                    case 16:
                        this.int_39 = 4096;
                        break;
                    case 83:
                    case 110:
                        this.int_39 = 4096 * (this.int_23 >= 8 ? this.int_23 / c.int_75 : 1);
                        break;
                }
            }
        }
        this.int_39 = this.int_23 * this.int_82 * 3;
        if (c.int_2 == 201)
            this.int_39 = 16384;
        this.byte_37 = new byte[this.int_39];
        this.byte_38 = new byte[this.int_39];
        this.byte_40 = new byte[this.int_39];
        for (int index = 0; index < this.int_39; ++index)
            this.byte_37[index] = (byte)0;
        this.udpClient_0.Client.SendBufferSize = this.int_39;
        this.progressBar_0.Visible = false;
        this.progressBar_0.Enabled = false;
        if (!this.bool_23)
        {
            if (c.useEnglishLanguage)
                this.ShowMessage(Module.a("\uE7B2\uDDB4튶馸쾺튼쮾ꃀ꿂\uE5C4꧆볈ꛊ꿌\uAACEꏐ\uF3D2뫔뇖律韚飜鯞鋠쏢郤铦賨迪췬蛮\u9FF0폲致\u9FF6郸裺\uDDFC迾猀氂漄戆樈缊ⴌ明成⤒", int_0) + this.int_41.ToString());
            else
                this.ShowMessage(Module.a("\uE0ED\uF8E6勫닂雴쳭샱\uE9B5䖌\uDF3B", int_0) + this.int_41.ToString() + Module.a("駼領\uF2B6ﶸ퓊뱃", int_0));
        }
        c.int_78 = 0;
        this.method_26(14, c.int_78.ToString());
        this.method_13();
        Bitmap bitmap = new Bitmap(this.panel_0.Width, this.panel_0.Height);
        Graphics graphics1 = Graphics.FromImage((Image)bitmap);
        IntPtr hdc1 = graphics1.GetHdc();
        Graphics graphics2 = this.panel_0.CreateGraphics();
        IntPtr hdc2 = graphics2.GetHdc();
        c.BitBlt(hdc1, 0, 0, this.panel_0.Width, this.panel_0.Height, hdc2, 0, 0, 13369376);
        graphics2.ReleaseHdc(hdc2);
        graphics1.ReleaseHdc(hdc1);
        string filename = this.string_20 + (object)'\\' + this.string_22 + Module.a("ᯠ軁痥\uDEC9閺\uDFBC튾뇀", int_0);
        if (this.image_1 != null)
            this.image_1.Dispose();
        bitmap.Save(filename, ImageFormat.Bmp);
        this.image_1 = Image.FromFile(filename);
        this.method_14();
        string string_24 = this.string_22 + Module.a("鶲領쾶\uDBB8", int_0);
        this.method_26(23, Module.a("芲", int_0));
        this.method_26(24, string_24);
        this.method_26(4, Module.a("莲", int_0));
        this.method_26(6, Module.a("莲", int_0));
        this.genum1_1 = GEnum1.const_2;
        this.method_31();
        this.method_81();
    }

    private void menuItem_113_Click(object sender, EventArgs e)
    {
    }

    private void method_39()
    {
        int int_0 = 5;
        this.method_29(9);
        this.int_40 = ((GClass5)c.arrayList_4[c.int_38]).int_0;
        int num1 = this.int_23 >= 8 ? this.int_23 / c.int_75 : 1;
        int num2 = c.int_75 * this.int_82 * 3;
        if (c.int_2 == 1 || c.int_2 == 6 || c.int_2 == 7 || c.int_2 == 8 || c.int_2 == 9 || c.int_2 == 84)
            num2 = c.int_75 * this.int_82 * 2;
        byte int2 = (byte)c.int_2;
        byte[] buffer = new byte[512];
        new Random().NextBytes(buffer);
        buffer[0] = (byte)114;
        buffer[1] = (byte)122;
        buffer[2] = (byte)98;
        buffer[3] = (byte)118;
        buffer[4] = (byte)48;
        buffer[5] = (byte)48;
        buffer[6] = (byte)49;
        buffer[7] = (byte)num1;
        buffer[8] = (byte)(this.int_39 / 256);
        buffer[9] = (byte)(this.int_39 % 256);
        buffer[10] = (byte)(num2 / 256);
        buffer[11] = (byte)(num2 % 256);
        byte num3 = (byte)(this.int_40 / 65536);
        int num4 = this.int_40 % 65536;
        buffer[12] = (byte)(num4 / 256);
        buffer[13] = (byte)(num4 % 256);
        int num5 = 1000 / c.smethod_0();
        buffer[14] = (byte)num5;
        buffer[15] = int2;
        buffer[18] = (byte)(this.int_39 / 65536);
        int num6 = this.int_39 % 65536;
        buffer[19] = (byte)(num6 / 256);
        buffer[20] = (byte)(num6 % 256);
        buffer[21] = (byte)85;
        buffer[22] = (byte)170;
        buffer[23] = num3;
        buffer[24] = (byte)(c.int_4 / 64);
        if (c.int_2 == 12 || c.int_2 == 31 || c.int_2 == 81 || c.int_2 == 86 || c.int_2 == 82 || c.int_2 == 41 || c.int_2 == 46 || c.int_2 == 85 || c.int_2 == 53 || c.int_2 == 54)
        {
            if (this.int_82 == 512)
                buffer[26] = (byte)85;
            else if (this.int_82 == 1024)
                buffer[26] = (byte)170;
        }
        int num7;
        if (c.int_2 == 2 || c.int_2 == 49 || c.int_2 == 16 || c.int_2 == 110 || c.int_2 == 83 || c.int_2 == 51)
        {
            buffer[25] = this.byte_29;
            if (c.bool_1)
            {
                buffer[25] = (byte)0;
                num7 = 4096;
            }
            else
                num7 = c.int_75 * this.int_82 * 3;
        }
        buffer[27] = c.byte_19;
        buffer[28] = c.string_7 == Module.a("ﾪ\uE1ACﲮ醰\uE5B2肴骶\uF4B8", int_0) || c.string_7 == Module.a("ﾪ\uE1ACﲮ醰\uE5B2蚴骶\uF4B8", int_0) || c.string_7 == Module.a("ﾪ\uE1ACﲮ醰\uE5B2螴骶\uF4B8", int_0) || c.string_7 == Module.a("ﾪ\uE1ACﲮ醰\uE5B2蒴\uF5B6钸\uF6BA", int_0) || c.string_7 == Module.a("ﶪ麬芮ﲰ鎲\uF8B4\uD8B6ힸ풺\uDEBCힾ돀곂꣄ꋆ", int_0) || c.string_7 == Module.a("\uE8AA\uD8AC\uDDAE얰튲\uDCB4\uD9B6馸\uEDBA袼", int_0) || c.string_7 == Module.a("\uE8AA\uD8AC\uDDAE얰튲\uDCB4\uD9B6馸\uEDBA躼", int_0) || c.string_7 == Module.a("\uE8AA\uD8AC\uDDAE얰튲\uDCB4\uD9B6馸\uEDBA込", int_0) || c.string_7 == Module.a("\uE8AA\uD8AC\uDDAE얰튲\uDCB4\uD9B6馸\uEDBA貼ﶾ", int_0) ? (byte)90 : (byte)0;
        buffer[30] = (byte)0;
        if (c.int_2 == 47 || c.int_2 == 48 || c.int_2 == 46 || c.int_2 == 140 || c.int_2 == 85)
            buffer[30] = c.bool_17 ? (byte)85 : (byte)0;
        buffer[31] = c.byte_20;
        if (c.string_7 == Module.a("ﾪ肬麮膰莲薴骶\uF1B8\uF7BA込螾\uF1C0\uF0C2", int_0))
        {
            buffer[15] = (byte)47;
            buffer[31] = (byte)3;
        }
        buffer[32] = (byte)0;
        buffer[33] = (byte)0;
        buffer[34] = (byte)0;
        buffer[35] = (byte)0;
        buffer[36] = (byte)0;
        buffer[37] = (byte)0;
        buffer[38] = (byte)0;
        buffer[39] = (byte)0;
        buffer[40] = (byte)0;
        buffer[41] = (byte)0;
        buffer[42] = (byte)0;
        buffer[43] = c.byte_2;
        if (c.byte_1 != (byte)3 && c.byte_1 != (byte)4)
        {
            buffer[44] = c.byte_6;
            buffer[45] = c.byte_7;
            buffer[49] = c.byte_8;
        }
        else
        {
            buffer[44] = this.byte_12[(int)c.byte_6];
            buffer[45] = this.byte_12[(int)c.byte_7];
            buffer[49] = this.byte_12[(int)c.byte_8];
        }
        if (c.int_2 == 81)
            buffer[15] = (byte)12;
        if (c.int_2 == 82)
            buffer[15] = (byte)31;
        if (c.int_2 == 83)
            buffer[15] = (byte)2;
        if (c.int_2 == 84)
        {
            buffer[15] = (byte)8;
            num7 = c.int_75 * this.int_82 * 2;
        }
        if (c.int_2 == 85)
            buffer[15] = (byte)46;
        if (c.int_2 == 86)
            buffer[15] = (byte)54;
        this.byte_17[0] = (byte)170;
        for (int index = 0; index < 64; ++index)
            this.byte_17[index + 1] = buffer[index];
    }

    private void method_40(string string_24, string string_25)
    {
        int int_0 = 8;
        this.method_26(30, c.byte_1.ToString());
        this.method_26(31, c.byte_2.ToString());
        this.method_26(32, c.byte_3.ToString());
        this.method_26(33, c.byte_4.ToString());
        this.method_26(34, c.byte_5.ToString());
        switch (c.int_81)
        {
            case 0:
                this.toolStripTextBox_2.Text = Module.a("ﲭ\uF7AF\uF0B1", int_0);
                break;
            case 1:
                this.toolStripTextBox_2.Text = Module.a("ﲭ\uF2AF\uF5B1", int_0);
                break;
            case 2:
                this.toolStripTextBox_2.Text = Module.a("\uE9AD\uE2AF\uF0B1", int_0);
                break;
            case 3:
                this.toolStripTextBox_2.Text = Module.a("\uE9AD\uF2AF\uE0B1", int_0);
                break;
            case 4:
                this.toolStripTextBox_2.Text = Module.a("\uECAD\uE2AF\uF5B1", int_0);
                break;
            case 5:
                this.toolStripTextBox_2.Text = Module.a("\uECAD\uF7AF\uE0B1", int_0);
                break;
            default:
                this.toolStripTextBox_2.Text = Module.a("ﲭ\uF7AF\uF0B1", int_0);
                break;
        }
        this.fileStream_1 = new FileStream(string_24, FileMode.Open, FileAccess.Read);
        this.bufferedStream_1 = new BufferedStream((Stream)this.fileStream_1);
        string path1 = string_25 + Module.a("\uF2AD肯花骳\uDAB5\uDDB7\uDEB9", int_0);
        if (System.IO.File.Exists(path1))
            System.IO.File.Delete(path1);
        FileStream fileStream1 = new FileStream(path1, FileMode.Create, FileAccess.Write);
        BufferedStream bufferedStream1 = new BufferedStream((Stream)fileStream1);
        this.method_29(9);
        this.int_40 = ((GClass5)c.arrayList_4[c.int_38]).int_0;
        int num1 = this.int_23 >= 8 ? this.int_23 / c.int_75 : 1;
        if (c.int_2 == 201)
            num1 = 1;
        int count1 = c.int_75 * this.int_82 * 3;
        if (c.int_2 == 1 || c.int_2 == 6 || c.int_2 == 7 || c.int_2 == 8 || c.int_2 == 9 || c.int_2 == 84)
            count1 = c.int_75 * this.int_82 * 2;
        byte num2 = (byte)c.int_2;
        if (c.int_2 == 7)
            num2 = (byte)8;
        if (c.int_2 == 41)
            num2 = (byte)12;
        if (c.int_2 == 48)
            num2 = (byte)46;
        if (c.int_2 == 49)
            num2 = (byte)2;
        if (c.int_2 == 50)
            num2 = (byte)31;
        if (c.int_2 == 53)
            num2 = (byte)54;
        if (c.int_2 == 51)
        {
            num2 = (byte)16;
            this.byte_29 = (byte)4;
            c.bool_1 = false;
        }
        byte[] buffer1 = new byte[512];
        new Random().NextBytes(buffer1);
        buffer1[0] = (byte)114;
        buffer1[1] = (byte)122;
        buffer1[2] = (byte)98;
        buffer1[3] = (byte)118;
        buffer1[4] = (byte)48;
        buffer1[5] = (byte)48;
        buffer1[6] = (byte)49;
        buffer1[7] = (byte)num1;
        buffer1[8] = (byte)(this.int_39 / 256);
        buffer1[9] = (byte)(this.int_39 % 256);
        buffer1[10] = (byte)(count1 / 256);
        buffer1[11] = (byte)(count1 % 256);
        byte num3 = (byte)(this.int_40 / 65536);
        int num4 = this.int_40 % 65536;
        buffer1[12] = (byte)(num4 / 256);
        buffer1[13] = (byte)(num4 % 256);
        int num5 = 1000 / c.smethod_0();
        buffer1[14] = (byte)num5;
        buffer1[15] = num2;
        buffer1[18] = (byte)(this.int_39 / 65536);
        int num6 = this.int_39 % 65536;
        buffer1[19] = (byte)(num6 / 256);
        buffer1[20] = (byte)(num6 % 256);
        buffer1[21] = (byte)85;
        buffer1[22] = (byte)170;
        buffer1[23] = num3;
        buffer1[24] = (byte)(c.int_4 / 64);
        if (c.int_2 == 9)
            buffer1[26] = this.int_82 <= 1024 ? (byte)85 : (byte)170;
        else if (c.int_2 != 13 && c.int_2 != 32 && c.int_2 != 47 && c.int_2 != 52)
        {
            if (c.int_2 == 55)
                buffer1[26] = (byte)85;
            else if (c.int_2 == 12 || c.int_2 == 31 || c.int_2 == 81 || c.int_2 == 86 || c.int_2 == 82 || c.int_2 == 41 || c.int_2 == 46 || c.int_2 == 85 || c.int_2 == 53 || c.int_2 == 54)
            {
                if (this.int_82 == 512)
                    buffer1[26] = (byte)85;
                else if (this.int_82 == 1024)
                    buffer1[26] = (byte)170;
            }
        }
        else if (this.int_82 == 512)
            buffer1[26] = (byte)85;
        else if (this.int_82 == 1024)
            buffer1[26] = (byte)170;
        else if (this.int_82 == 1536)
            buffer1[26] = (byte)51;
        else if (this.int_82 == 2048)
            buffer1[26] = (byte)204;
        if (c.int_2 == 2 || c.int_2 == 49 || c.int_2 == 16 || c.int_2 == 110 || c.int_2 == 83 || c.int_2 == 51)
        {
            buffer1[25] = this.byte_29;
            if (c.bool_1)
            {
                buffer1[25] = (byte)0;
                count1 = 4096;
            }
            else
                count1 = c.int_75 * this.int_82 * 3;
        }
        buffer1[27] = c.byte_19;
        buffer1[28] = c.string_7 == Module.a("節ﲯ\uE1B1钳\uE0B5趷鞹\uF1BB", int_0) || c.string_7 == Module.a("節ﲯ\uE1B1钳\uE0B5讷鞹\uF1BB", int_0) || c.string_7 == Module.a("節ﲯ\uE1B1钳\uE0B5誷鞹\uF1BB", int_0) || c.string_7 == Module.a("節ﲯ\uE1B1钳\uE0B5覷\uF8B9醻\uF3BD", int_0) || c.string_7 == Module.a("\uF8AD莯龱靈隵\uF5B7햹튻톽ꎿ꫁뛃꧅ꗇ꿉", int_0) || c.string_7 == Module.a("\uEDAD얯삱삳ힵ톷풹鲻\uE8BD\uF5BF", int_0) || c.string_7 == Module.a("\uEDAD얯삱삳ힵ톷풹鲻\uE8BD\uF3BF", int_0) || c.string_7 == Module.a("\uEDAD얯삱삳ힵ톷풹鲻\uE8BD\uF2BF", int_0) || c.string_7 == Module.a("\uEDAD얯삱삳ힵ톷풹鲻\uE8BD\uF1BF胁", int_0) ? (byte)90 : (byte)0;
        buffer1[30] = (byte)0;
        if (c.int_2 == 47 || c.int_2 == 48 || c.int_2 == 46 || c.int_2 == 140 || c.int_2 == 85)
            buffer1[30] = c.bool_17 ? (byte)85 : (byte)0;
        buffer1[31] = c.byte_20;
        if (c.string_7 == Module.a("節鶯莱蒳蚵袷鞹\uF4BB\uF2BD\uF2BF贈\uF4C3\uF5C5", int_0))
        {
            buffer1[15] = (byte)47;
            buffer1[31] = (byte)3;
        }
        buffer1[32] = (byte)0;
        buffer1[33] = (byte)0;
        buffer1[34] = (byte)0;
        buffer1[35] = (byte)0;
        buffer1[36] = (byte)0;
        buffer1[37] = (byte)(this.int_42 / 256);
        buffer1[38] = (byte)(this.int_42 % 256);
        buffer1[39] = (byte)0;
        buffer1[40] = (byte)0;
        buffer1[41] = (byte)0;
        buffer1[42] = (byte)0;
        buffer1[43] = c.byte_2;
        if (c.byte_1 != (byte)3 && c.byte_1 != (byte)4)
        {
            buffer1[44] = c.byte_6;
            buffer1[45] = c.byte_7;
            buffer1[49] = c.byte_8;
        }
        else
        {
            buffer1[44] = this.byte_12[(int)c.byte_6];
            buffer1[45] = this.byte_12[(int)c.byte_7];
            buffer1[49] = this.byte_12[(int)c.byte_8];
        }
        this.byte_18[0] = buffer1[46];
        this.byte_18[1] = buffer1[47];
        this.byte_18[2] = buffer1[48];
        buffer1[50] = (byte)(c.int_5 / 256);
        buffer1[51] = (byte)(c.int_5 % 256);
        buffer1[52] = (byte)c.int_6;
        buffer1[53] = (byte)(c.int_7 / 256);
        buffer1[54] = (byte)(c.int_7 % 256);
        if (this.bool_5)
        {
            byte num7 = 0;
            for (int index = 300; index < 310; ++index)
                num7 += buffer1[index];
            byte num8 = (byte)((uint)(byte)((uint)num7 ^ 90U) + 150U);
            buffer1[310] = num8;
        }
        byte num9 = 0;
        switch (c.int_2)
        {
            case 9:
                if (c.byte_20 > (byte)1)
                {
                    num9 = (byte)17;
                    break;
                }
                break;
            case 32:
                if (c.byte_20 > (byte)9)
                {
                    num9 = (byte)17;
                    break;
                }
                break;
            case 82:
                if (c.byte_20 > (byte)9)
                {
                    num9 = (byte)17;
                    break;
                }
                break;
            case 130:
                if (c.byte_20 > (byte)9)
                {
                    num9 = (byte)17;
                    break;
                }
                break;
        }
        string str1 = c.string_7.Substring(0, 8);
        if (str1 == Module.a("節鶯莱蒳蚵袷﮹醻", int_0))
            num9 = (byte)17;
        else if (str1 == Module.a("節鶯莱蒳蚵袷\uF8B9醻", int_0))
            num9 = (byte)17;
        byte num10 = 17;
        if ((c.int_2 == 130 || c.int_2 == 120 || c.int_2 == 110) && !c.bool_2)
            num10 = (byte)0;
        if (c.int_2 == 47)
        {
            if (c.byte_20 == (byte)0)
                num10 = (byte)0;
            if (c.byte_20 == (byte)2)
                num10 = (byte)0;
            if (c.byte_20 == (byte)5)
                num10 = (byte)0;
            if (c.byte_20 == (byte)6)
                num10 = (byte)0;
        }
        buffer1[35] = (byte)1;
        buffer1[36] = num10;
        byte[] numArray1 = new byte[16]
        {
      (byte) 143,
      (byte) 45,
      (byte) 28,
      (byte) 105,
      (byte) 84,
      (byte) 163,
      (byte) 200,
      (byte) 75,
      (byte) 46,
      (byte) 227,
      (byte) 249,
      (byte) 35,
      (byte) 118,
      (byte) 176,
      (byte) 209,
      (byte) 62
        };
        byte[] numArray2 = new byte[16];
        for (int index = 0; index < 16; ++index)
            numArray2[index] = buffer1[index + 185];
        byte num11 = 0;
        for (int index = 0; index < 16; ++index)
        {
            byte num12 = (byte)((uint)numArray2[index] ^ (uint)numArray1[index]);
            num11 += num12;
        }
        for (int index = 0; index < 16; ++index)
            num11 += numArray2[index];
        this.byte_42 = (byte)((uint)(byte)((uint)(byte)((uint)(byte)((uint)(byte)((uint)(byte)((uint)num11 + (uint)numArray1[0]) + (uint)numArray1[2]) + (uint)numArray1[7]) + (uint)numArray1[9]) + (uint)numArray1[15]) ^ 90U);
        byte[] numArray3 = new byte[16]
        {
      (byte) 206,
      (byte) 73,
      (byte) 147,
      (byte) 86,
      (byte) 164,
      (byte) 129,
      (byte) 63,
      (byte) 162,
      (byte) 113,
      (byte) 148,
      (byte) 42,
      (byte) 53,
      (byte) 23,
      (byte) 62,
      (byte) 91,
      (byte) 225
        };
        byte num13 = 0;
        for (int index1 = 311; index1 < 427; ++index1)
        {
            byte index2 = (byte)(index1 % 16);
            num13 += (byte)((uint)buffer1[index1] ^ (uint)numArray3[(int)index2]);
        }
        for (int index = 430; index < 511; ++index)
            num13 += (byte)((uint)buffer1[index] ^ 90U);
        this.byte_43 = (byte)((uint)num13 ^ 165U);
        byte num14 = buffer1[15];
        if (c.int_2 == 81 || c.int_2 == 86 || c.int_2 == 82 || c.int_2 == 83 || c.int_2 == 84 || c.int_2 == 85)
        {
            if (c.int_2 == 81)
                buffer1[15] = (byte)12;
            if (c.int_2 == 82)
                buffer1[15] = (byte)31;
            if (c.int_2 == 83)
                buffer1[15] = (byte)2;
            if (c.int_2 == 84)
            {
                buffer1[15] = (byte)8;
                count1 = c.int_75 * this.int_82 * 2;
            }
            if (c.int_2 == 85)
                buffer1[15] = (byte)46;
            if (c.int_2 == 86)
                buffer1[15] = (byte)54;
        }
        if (num10 == (byte)17)
        {
            byte[] numArray4 = new byte[16]
            {
        (byte) 140,
        (byte) 113,
        (byte) 41,
        (byte) 111,
        (byte) 227,
        (byte) 202,
        (byte) 180,
        (byte) 249,
        (byte) 55,
        (byte) 16,
        (byte) 77,
        (byte) 5,
        (byte) 147,
        (byte) 168,
        (byte) 138,
        (byte) 26
            };
            byte num15 = 0;
            string str2 = c.string_7.Substring(0, 8);
            if (str2 == Module.a("節鶯莱蒳蚵袷﮹醻", int_0))
            {
                for (int index = 0; index < 32; ++index)
                    num15 += buffer1[index + 190];
            }
            else if (str2 == Module.a("節鶯莱蒳蚵袷\uF8B9醻", int_0))
            {
                for (int index = 0; index < 32; ++index)
                    num15 += buffer1[index + 289];
            }
            for (int index3 = 0; index3 < 109; ++index3)
            {
                byte index4 = (byte)(index3 % 16);
                num15 += (byte)((uint)buffer1[index3] ^ (uint)numArray4[(int)index4]);
            }
            if (num15 < (byte)128)
                num15 += (byte)120;
            for (int index = 0; index < 16; ++index)
                numArray2[index] = buffer1[index + (int)num15];
            numArray2[3] = buffer1[12];
            numArray2[4] = buffer1[13];
            numArray2[7] = buffer1[15];
            numArray2[8] = buffer1[31];
            numArray2[10] = buffer1[27];
            numArray2[11] = buffer1[14];
            numArray2[15] = buffer1[26];
            byte[] numArray5 = new byte[280]
            {
        (byte) 36,
        (byte) 144,
        (byte) 157,
        (byte) 7,
        (byte) 104,
        (byte) 42,
        (byte) 8,
        (byte) 100,
        (byte) 183,
        (byte) 154,
        (byte) 151,
        (byte) 189,
        (byte) 153,
        (byte) 247,
        (byte) 133,
        (byte) 118,
        (byte) 252,
        (byte) 226,
        (byte) 43,
        (byte) 229,
        (byte) 229,
        (byte) 151,
        (byte) 204,
        (byte) 27,
        (byte) 57,
        (byte) 214,
        (byte) 205,
        (byte) 204,
        (byte) 26,
        (byte) 238,
        (byte) 78,
        (byte) 192,
        (byte) 7,
        (byte) 12,
        (byte) 117,
        (byte) 102,
        (byte) 116,
        (byte) 170,
        (byte) 21,
        (byte) 190,
        (byte) 99,
        (byte) 53,
        (byte) 198,
        (byte) 39,
        (byte) 126,
        (byte) 74,
        (byte) 132,
        (byte) 160,
        (byte) 134,
        (byte) 238,
        (byte) 190,
        (byte) 152,
        (byte) 180,
        (byte) 142,
        (byte) 21,
        (byte) 141,
        (byte) 195,
        (byte) 130,
        (byte) 205,
        (byte) 146,
        (byte) 92,
        (byte) 60,
        (byte) 74,
        (byte) 201,
        (byte) 75,
        (byte) 214,
        (byte) 181,
        (byte) 140,
        (byte) 130,
        (byte) 31,
        (byte) 1,
        (byte) 81,
        (byte) 205,
        (byte) 108,
        (byte) 129,
        (byte) 175,
        (byte) 208,
        (byte) 165,
        (byte) 156,
        (byte) 239,
        (byte) 82,
        (byte) 45,
        (byte) 70,
        (byte) 44,
        (byte) 47,
        (byte) 182,
        (byte) 12,
        (byte) 121,
        (byte) 247,
        (byte) 231,
        (byte) 162,
        (byte) 241,
        (byte) 220,
        (byte) 131,
        (byte) 97,
        (byte) 39,
        (byte) 235,
        (byte) 253,
        (byte) 220,
        (byte) 167,
        (byte) 148,
        (byte) 247,
        (byte) 29,
        (byte) 102,
        (byte) 236,
        (byte) 109,
        (byte) 202,
        (byte) 71,
        (byte) 12,
        (byte) 101,
        (byte) 188,
        (byte) 30,
        (byte) 229,
        (byte) 222,
        (byte) 64,
        (byte) 47,
        (byte) 245,
        (byte) 29,
        (byte) 153,
        (byte) 148,
        (byte) 202,
        (byte) 60,
        (byte) 149,
        (byte) 155,
        (byte) 125,
        (byte) 15,
        (byte) 116,
        (byte) 74,
        (byte) 11,
        (byte) 89,
        (byte) 195,
        (byte) 210,
        (byte) 201,
        (byte) 245,
        (byte) 91,
        (byte) 91,
        (byte) 15,
        (byte) 224,
        (byte) 63,
        (byte) 194,
        (byte) 235,
        (byte) 196,
        (byte) 108,
        (byte) 145,
        (byte) 42,
        (byte) 132,
        (byte) 12,
        (byte) 254,
        (byte) 67,
        (byte) 49,
        (byte) 50,
        (byte) 205,
        (byte) 99,
        (byte) 71,
        (byte) 221,
        (byte) 87,
        (byte) 97,
        (byte) 130,
        (byte) 233,
        (byte) 220,
        (byte) 248,
        (byte) 128,
        (byte) 60,
        (byte) 178,
        (byte) 162,
        (byte) 234,
        (byte) 85,
        (byte) 240,
        (byte) 131,
        (byte) 228,
        (byte) 32,
        (byte) 21,
        (byte) 222,
        (byte) 215,
        (byte) 168,
        (byte) 5,
        (byte) 207,
        (byte) 4,
        (byte) 112,
        (byte) 248,
        (byte) 3,
        (byte) 118,
        (byte) 7,
        (byte) 217,
        (byte) 39,
        (byte) 246,
        (byte) 111,
        (byte) 129,
        (byte) 24,
        (byte) 3,
        (byte) 249,
        (byte) 140,
        (byte) 246,
        (byte) 99,
        (byte) 202,
        (byte) 107,
        (byte) 136,
        (byte) 186,
        (byte) 239,
        (byte) 64,
        (byte) 47,
        (byte) 27,
        (byte) 123,
        (byte) 94,
        (byte) 17,
        (byte) 28,
        (byte) 239,
        (byte) 140,
        (byte) 159,
        (byte) 216,
        (byte) 136,
        (byte) 92,
        (byte) 18,
        (byte) 240,
        (byte) 216,
        (byte) 130,
        (byte) 121,
        (byte) 98,
        (byte) 139,
        (byte) 171,
        (byte) 122,
        (byte) 211,
        (byte) 216,
        (byte) 128,
        (byte) 234,
        (byte) 147,
        (byte) 30,
        (byte) 122,
        (byte) 12,
        (byte) 61,
        (byte) 124,
        (byte) 21,
        (byte) 21,
        (byte) 47,
        (byte) 201,
        (byte) 231,
        (byte) 251,
        (byte) 168,
        (byte) 200,
        (byte) 10,
        (byte) 6,
        (byte) 226,
        (byte) 226,
        (byte) 64,
        (byte) 123,
        (byte) 157,
        (byte) 122,
        (byte) 6,
        (byte) 138,
        (byte) 71,
        (byte) 241,
        (byte) 38,
        (byte) 47,
        (byte) 67,
        (byte) 197,
        (byte) 91,
        (byte) 67,
        (byte) 250,
        (byte) 115,
        (byte) 125,
        (byte) 254,
        (byte) 117,
        (byte) 127,
        (byte) 97,
        (byte) 91,
        (byte) 114,
        (byte) 71,
        (byte) 226,
        (byte) 38,
        (byte) 240,
        (byte) 135,
        (byte) 208,
        (byte) 153,
        (byte) 128,
        (byte) 165,
        (byte) 152,
        (byte) 241,
        (byte) 152,
        (byte) 5,
        (byte) 77
            };
            byte num16 = 0;
            for (int index = 0; index < 16; ++index)
                num16 += numArray2[index];
            byte num17 = 0;
            for (int index = 0; index < 16; ++index)
            {
                byte num18 = (byte)((uint)numArray2[index] ^ (uint)numArray5[index + (int)num16]);
                num17 += num18;
            }
            byte[] numArray6 = new byte[8];
            for (int index = 0; index < 8; ++index)
                numArray6[index] = numArray5[index + (int)num17];
            byte num19 = 90;
            for (int index = 0; index < 8; ++index)
                num19 ^= numArray2[index];
            byte num20 = 0;
            for (int index = 0; index < 8; ++index)
            {
                byte num21 = (byte)((uint)numArray2[index] ^ (uint)numArray5[index + (int)num19]);
                num20 += num21;
            }
            byte[] buffer2 = new byte[8];
            for (int index = 0; index < 8; ++index)
                buffer2[index] = (byte)((uint)numArray2[index] ^ (uint)numArray5[index + (int)num20]);
            byte[] numArray7 = new byte[8];
            using (DESCryptoServiceProvider cryptoServiceProvider = new DESCryptoServiceProvider())
            {
                byte[] numArray8 = new byte[8];
                cryptoServiceProvider.Key = numArray6;
                cryptoServiceProvider.IV = numArray8;
                cryptoServiceProvider.Padding = PaddingMode.None;
                MemoryStream memoryStream = new MemoryStream();
                using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, cryptoServiceProvider.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cryptoStream.Write(buffer2, 0, buffer2.Length);
                    cryptoStream.FlushFinalBlock();
                    cryptoStream.Close();
                }
                byte[] array = memoryStream.ToArray();
                memoryStream.Close();
                if (array.Length == 8)
                {
                    for (int index = 0; index < 8; ++index)
                        numArray7[index] = array[index];
                }
                else
                {
                    if (c.useEnglishLanguage)
                    {
                        this.ShowMessage(Module.a("\uEBAD슯삱\uDBB3쒵馷", int_0));
                        return;
                    }
                    this.ShowMessage(Module.a("翾꿚ꬤ嬸鞵", int_0));
                    return;
                }
            }
            byte[] numArray9 = new byte[4]
            {
        (byte) ((uint) numArray7[0] ^ (uint) numArray7[1]),
        (byte) ((uint) numArray7[2] + (uint) numArray7[3]),
        (byte) ((uint) numArray7[4] - (uint) numArray7[5]),
        (byte) ((uint) numArray7[6] ^ (uint) numArray7[7])
            };
            byte num22 = 0;
            byte num23 = numArray9[0];
            if (num23 < (byte)128)
                num23 += (byte)120;
            for (int index5 = 0; index5 < 119; ++index5)
            {
                byte index6 = (byte)(index5 % 16);
                num22 += (byte)((uint)buffer1[index5 + (int)num23] ^ (uint)numArray4[(int)index6]);
            }
            this.byte_42 ^= num22;
            this.byte_42 += numArray9[2];
            byte num24 = 0;
            byte num25 = numArray9[1];
            if (num25 < (byte)128)
                num25 += (byte)120;
            for (int index7 = 0; index7 < 149; ++index7)
            {
                byte index8 = (byte)(index7 % 16);
                num24 += (byte)((uint)buffer1[index7 + (int)num25] ^ (uint)numArray4[(int)index8]);
            }
            this.byte_43 += num24;
            this.byte_43 ^= numArray9[3];
        }
        buffer1[15] = num14;
        if (this.bool_5 && c.int_2 > 80)
        {
            this.byte_43 = (byte)0;
            this.byte_42 = (byte)0;
            this.byte_39 = new byte[10];
            for (int index = 0; index < 10; ++index)
                this.byte_39[index] = (byte)((uint)buffer1[index + 203] ^ 165U);
            byte num26 = 0;
            for (int index = 0; index < 10; ++index)
            {
                num26 += (byte)((uint)this.byte_39[index] ^ (uint)this.byte_11[index]);
                this.byte_30[index + 2] = this.byte_39[index];
            }
            this.byte_42 = (byte)((uint)num26 ^ 90U);
        }
        bufferedStream1.Write(buffer1, 0, 512);
        this.progressBar_0.Enabled = true;
        this.progressBar_0.Maximum = this.int_40;
        this.progressBar_0.Minimum = 0;
        this.progressBar_0.Visible = true;
        byte[] numArray10 = new byte[3];
        switch (c.int_81)
        {
            case 0:
                numArray10[0] = (byte)0;
                numArray10[1] = (byte)1;
                numArray10[2] = (byte)2;
                break;
            case 1:
                numArray10[0] = (byte)0;
                numArray10[1] = (byte)2;
                numArray10[2] = (byte)1;
                break;
            case 2:
                numArray10[0] = (byte)1;
                numArray10[1] = (byte)0;
                numArray10[2] = (byte)2;
                break;
            case 3:
                numArray10[0] = (byte)1;
                numArray10[1] = (byte)2;
                numArray10[2] = (byte)0;
                break;
            case 4:
                numArray10[0] = (byte)2;
                numArray10[1] = (byte)0;
                numArray10[2] = (byte)1;
                break;
            case 5:
                numArray10[0] = (byte)2;
                numArray10[1] = (byte)1;
                numArray10[2] = (byte)0;
                break;
            default:
                numArray10[0] = (byte)0;
                numArray10[1] = (byte)1;
                numArray10[2] = (byte)2;
                break;
        }
        if (Directory.Exists(string_25 + Module.a("\uF2AD\uEFAF\uE6B1\uEBB3螵袷誹費\uE1BD膿臁飃", int_0)))
            Directory.Delete(string_25 + Module.a("\uF2AD\uEFAF\uE6B1\uEBB3螵袷誹費\uE1BD膿臁飃", int_0), true);
        Directory.CreateDirectory(string_25 + Module.a("\uF2AD\uEFAF\uE6B1\uEBB3螵袷誹費\uE1BD膿臁飃", int_0));
        if (c.int_2 != 13 && c.int_2 != 32 && c.int_2 != 47 && c.int_2 != 52)
        {
            switch (c.int_2)
            {
                case 9:
                    IEnumerator enumerator1 = this.arrayList_3.GetEnumerator();
                    try
                    {
                        while (enumerator1.MoveNext())
                        {
                            GClass8 current = (GClass8)enumerator1.Current;
                            int int_93 = current.method_4();
                            string path2 = string_25 + Module.a("\uF2AD\uEFAF\uE6B1\uEBB3螵袷誹費\uE1BD膿臁飃", int_0) + c.string_3 + Module.a("\uF1AD", int_0) + current.method_4().ToString() + Module.a("肭\uDCAFힱ킳", int_0);
                            if (System.IO.File.Exists(path2))
                                System.IO.File.Delete(path2);
                            FileStream fileStream2 = new FileStream(path2, FileMode.Create, FileAccess.Write);
                            BufferedStream bufferedStream2 = new BufferedStream((Stream)fileStream2);
                            bufferedStream2.Write(buffer1, 0, 512);
                            for (int index9 = 0; index9 < this.int_40; ++index9)
                            {
                                this.progressBar_0.Value = index9;
                                this.bufferedStream_1.Seek((long)this.int_39 * (long)index9, SeekOrigin.Begin);
                                this.bufferedStream_1.Read(this.byte_38, 0, this.int_39);
                                for (uint index10 = 0; (long)index10 < (long)this.int_39; ++index10)
                                    this.byte_37[index10] = (byte)((uint)this.byte_38[(index10 ^ (uint)this.byte_45)] - (uint)this.byte_44);
                                int count2 = 0;
                                for (int int_94 = 0; int_94 < this.int_82; ++int_94)
                                {
                                    byte index11 = this.method_41(int_93, int_94, (int)numArray10[0]);
                                    byte num27 = c.byte_21[(int)index11];
                                    byte index12 = this.method_41(int_93, int_94, (int)numArray10[1]);
                                    byte num28 = c.byte_22[(int)index12];
                                    byte index13 = this.method_41(int_93, int_94, (int)numArray10[2]);
                                    byte num29 = c.byte_23[(int)index13];
                                    byte index14 = (byte)((128 | (int)num27 >> 1) & 252 | (int)num28 >> 6);
                                    this.byte_40[count2] = this.byte_12[(int)index14];
                                    int index15 = count2 + 1;
                                    byte index16 = (byte)((int)num28 << 2 & 224 | (int)num29 >> 3);
                                    this.byte_40[index15] = this.byte_12[(int)index16];
                                    count2 = index15 + 1;
                                }
                                for (uint index17 = 0; (long)index17 < (long)count2; ++index17)
                                    this.byte_38[index17] = (byte)((uint)this.byte_40[(index17 ^ (uint)this.byte_43)] + (uint)this.byte_42);
                                bufferedStream2.Write(this.byte_38, 0, count2);
                            }
                            for (int index = 0; index < 20; ++index)
                                bufferedStream2.Write(this.byte_30, 0, 1024);
                            bufferedStream2.Flush();
                            bufferedStream2.Close();
                            fileStream2.Close();
                        }
                        break;
                    }
                    finally
                    {
                        if (enumerator1 is IDisposable disposable)
                            disposable.Dispose();
                    }
                case 16:
                    IEnumerator enumerator2 = this.arrayList_3.GetEnumerator();
                    try
                    {
                        while (enumerator2.MoveNext())
                        {
                            GClass8 current = (GClass8)enumerator2.Current;
                            int int_93 = current.method_4();
                            string path3 = string_25 + Module.a("\uF2AD\uEFAF\uE6B1\uEBB3螵袷誹費\uE1BD膿臁飃", int_0) + c.string_3 + Module.a("\uF1AD", int_0) + (current.method_4() + 1).ToString() + Module.a("肭\uDCAFힱ킳", int_0);
                            if (System.IO.File.Exists(path3))
                                System.IO.File.Delete(path3);
                            FileStream fileStream3 = new FileStream(path3, FileMode.Create, FileAccess.Write);
                            BufferedStream bufferedStream3 = new BufferedStream((Stream)fileStream3);
                            bufferedStream3.Write(buffer1, 0, 512);
                            for (int index18 = 0; index18 < this.int_40; ++index18)
                            {
                                this.progressBar_0.Value = index18;
                                this.bufferedStream_1.Seek((long)this.int_39 * (long)index18, SeekOrigin.Begin);
                                this.bufferedStream_1.Read(this.byte_38, 0, this.int_39);
                                for (uint index19 = 0; (long)index19 < (long)this.int_39; ++index19)
                                    this.byte_37[index19] = (byte)((uint)this.byte_38[(index19 ^ (uint)this.byte_45)] - (uint)this.byte_44);
                                int count3 = 0;
                                for (int int_94 = 0; int_94 < this.int_82; ++int_94)
                                {
                                    byte index20 = this.method_41(int_93, int_94, (int)numArray10[0]);
                                    byte num30 = c.byte_21[(int)index20];
                                    this.byte_40[count3] = num30;
                                    int index21 = count3 + 1;
                                    byte index22 = this.method_41(int_93, int_94, (int)numArray10[1]);
                                    byte num31 = c.byte_22[(int)index22];
                                    this.byte_40[index21] = num31;
                                    int index23 = index21 + 1;
                                    byte index24 = this.method_41(int_93, int_94, (int)numArray10[2]);
                                    byte num32 = c.byte_23[(int)index24];
                                    this.byte_40[index23] = num32;
                                    count3 = index23 + 1;
                                }
                                if (c.bool_1)
                                {
                                    for (uint index25 = 0; index25 < 512U; ++index25)
                                        this.byte_38[index25] = (byte)((uint)this.byte_40[(index25 ^ (uint)this.byte_43)] + (uint)this.byte_42);
                                }
                                else
                                {
                                    for (uint index26 = 0; (long)index26 < (long)count3; ++index26)
                                        this.byte_38[index26] = (byte)((uint)this.byte_40[(index26 ^ (uint)this.byte_43)] + (uint)this.byte_42);
                                }
                                bufferedStream3.Write(this.byte_38, 0, count3);
                            }
                            for (int index = 0; index < 20; ++index)
                                bufferedStream3.Write(this.byte_30, 0, 1024);
                            bufferedStream3.Flush();
                            bufferedStream3.Close();
                            fileStream3.Close();
                        }
                        break;
                    }
                    finally
                    {
                        if (enumerator2 is IDisposable disposable)
                            disposable.Dispose();
                    }
                case 55:
                    IEnumerator enumerator3 = this.arrayList_3.GetEnumerator();
                    try
                    {
                        while (enumerator3.MoveNext())
                        {
                            GClass8 current = (GClass8)enumerator3.Current;
                            int int_93 = current.method_4();
                            string path4 = string_25 + Module.a("\uF2AD\uEFAF\uE6B1\uEBB3螵袷誹費\uE1BD膿臁飃", int_0) + c.string_3 + Module.a("\uF1AD", int_0) + (current.method_4() + 1).ToString() + Module.a("肭\uDCAFힱ킳", int_0);
                            if (System.IO.File.Exists(path4))
                                System.IO.File.Delete(path4);
                            FileStream fileStream4 = new FileStream(path4, FileMode.Create, FileAccess.Write);
                            BufferedStream bufferedStream4 = new BufferedStream((Stream)fileStream4);
                            bufferedStream4.Write(buffer1, 0, 512);
                            for (int index27 = 0; index27 < this.int_40; ++index27)
                            {
                                this.progressBar_0.Value = index27;
                                this.bufferedStream_1.Seek((long)this.int_39 * (long)index27, SeekOrigin.Begin);
                                this.bufferedStream_1.Read(this.byte_38, 0, this.int_39);
                                for (uint index28 = 0; (long)index28 < (long)this.int_39; ++index28)
                                    this.byte_37[index28] = (byte)((uint)this.byte_38[(index28 ^ (uint)this.byte_45)] - (uint)this.byte_44);
                                int count4 = 0;
                                for (int int_94 = 0; int_94 < this.int_82; ++int_94)
                                {
                                    byte index29 = this.method_41(int_93, int_94, (int)numArray10[0]);
                                    byte index30 = c.byte_21[(int)index29];
                                    this.byte_40[count4] = this.byte_12[(int)index30];
                                    ++count4;
                                }
                                for (uint index31 = 0; (long)index31 < (long)count4; ++index31)
                                    this.byte_38[index31] = (byte)((uint)this.byte_40[(index31 ^ (uint)this.byte_43)] + (uint)this.byte_42);
                                bufferedStream4.Write(this.byte_38, 0, count4);
                            }
                            for (int index = 0; index < 20; ++index)
                                bufferedStream4.Write(this.byte_30, 0, 1024);
                            bufferedStream4.Flush();
                            bufferedStream4.Close();
                            fileStream4.Close();
                        }
                        break;
                    }
                    finally
                    {
                        if (enumerator3 is IDisposable disposable)
                            disposable.Dispose();
                    }
                default:
                    if (c.int_2 != 3 && c.int_2 != 5 && c.int_2 != 101 && c.int_2 != 14)
                    {
                        if (c.int_2 != 103 && c.int_2 != 15)
                        {
                            if (c.int_2 == 102)
                            {
                                if (!c.bool_2)
                                {
                                    for (int index32 = 0; index32 < this.int_40; ++index32)
                                    {
                                        this.progressBar_0.Value = index32;
                                        this.bufferedStream_1.Seek((long)this.int_39 * (long)index32, SeekOrigin.Begin);
                                        this.bufferedStream_1.Read(this.byte_38, 0, this.int_39);
                                        for (uint index33 = 0; (long)index33 < (long)this.int_39; ++index33)
                                            this.byte_37[index33] = (byte)((uint)this.byte_38[(index33 ^ (uint)this.byte_45)] - (uint)this.byte_44);
                                        byte[] numArray11 = new byte[8];
                                        byte[] numArray12 = new byte[8];
                                        int count5 = 0;
                                        for (int index34 = 0; index34 < num1; ++index34)
                                        {
                                            for (int int_94 = 0; int_94 < this.int_82; ++int_94)
                                            {
                                                byte index35 = 0;
                                                for (int int_93 = index34 * c.int_75; int_93 < (index34 + 1) * c.int_75; ++int_93)
                                                {
                                                    byte index36 = this.method_41(int_93, int_94, (int)numArray10[0]);
                                                    byte num33 = c.byte_21[(int)index36];
                                                    byte index37 = this.method_41(int_93, int_94, (int)numArray10[1]);
                                                    byte num34 = c.byte_22[(int)index37];
                                                    byte index38 = this.method_41(int_93, int_94, (int)numArray10[2]);
                                                    byte num35 = c.byte_23[(int)index38];
                                                    numArray11[(int)index35] = (byte)((128 | (int)num33 >> 1) & 252 | (int)num34 >> 6);
                                                    numArray12[(int)index35] = (byte)((int)num34 << 2 & 224 | (int)num35 >> 3);
                                                    ++index35;
                                                }
                                                for (int index39 = 0; index39 < 8; ++index39)
                                                {
                                                    this.byte_40[count5] = numArray11[index39];
                                                    ++count5;
                                                }
                                                for (int index40 = 0; index40 < 8; ++index40)
                                                {
                                                    this.byte_40[count5] = numArray12[index40];
                                                    ++count5;
                                                }
                                            }
                                        }
                                        for (uint index41 = 0; (long)index41 < (long)count5; ++index41)
                                            this.byte_38[index41] = (byte)((uint)this.byte_40[(index41 ^ (uint)this.byte_43)] + (uint)this.byte_42);
                                        bufferedStream1.Write(this.byte_38, 0, count5);
                                    }
                                    break;
                                }
                                for (int index42 = 0; index42 < this.int_40; ++index42)
                                {
                                    this.progressBar_0.Value = index42;
                                    this.bufferedStream_1.Seek((long)this.int_39 * (long)index42, SeekOrigin.Begin);
                                    this.bufferedStream_1.Read(this.byte_38, 0, this.int_39);
                                    for (uint index43 = 0; (long)index43 < (long)this.int_39; ++index43)
                                        this.byte_37[index43] = (byte)((uint)this.byte_38[(index43 ^ (uint)this.byte_45)] - (uint)this.byte_44);
                                    byte num36 = 1;
                                    int count6 = 0;
                                    for (int index44 = 0; index44 < num1; ++index44)
                                    {
                                        for (int int_94 = 0; int_94 < this.int_82; ++int_94)
                                        {
                                            this.byte_40[count6] = byte.MaxValue;
                                            ++count6;
                                            for (int index45 = 7; index45 > 2; --index45)
                                            {
                                                byte num37 = 0;
                                                for (int int_93 = index44 * c.int_75; int_93 < (index44 + 1) * c.int_75; ++int_93)
                                                {
                                                    byte index46 = this.method_41(int_93, int_94, (int)numArray10[0]);
                                                    if ((byte)((uint)c.byte_21[(int)index46] & (uint)num36 << index45) != (byte)0)
                                                        num37 |= (byte)((uint)num36 << int_93 % c.int_75);
                                                }
                                                this.byte_40[count6] = num37;
                                                ++count6;
                                            }
                                            for (int index47 = 7; index47 > 2; --index47)
                                            {
                                                byte num38 = 0;
                                                for (int int_93 = index44 * c.int_75; int_93 < (index44 + 1) * c.int_75; ++int_93)
                                                {
                                                    byte index48 = this.method_41(int_93, int_94, (int)numArray10[1]);
                                                    if ((byte)((uint)c.byte_22[(int)index48] & (uint)num36 << index47) != (byte)0)
                                                        num38 |= (byte)((uint)num36 << int_93 % c.int_75);
                                                }
                                                this.byte_40[count6] = num38;
                                                ++count6;
                                            }
                                            for (int index49 = 7; index49 > 2; --index49)
                                            {
                                                byte num39 = 0;
                                                for (int int_93 = index44 * c.int_75; int_93 < (index44 + 1) * c.int_75; ++int_93)
                                                {
                                                    byte index50 = this.method_41(int_93, int_94, (int)numArray10[2]);
                                                    if ((byte)((uint)c.byte_23[(int)index50] & (uint)num36 << index49) != (byte)0)
                                                        num39 |= (byte)((uint)num36 << int_93 % c.int_75);
                                                }
                                                this.byte_40[count6] = num39;
                                                ++count6;
                                            }
                                        }
                                    }
                                    for (uint index51 = 0; (long)index51 < (long)count6; ++index51)
                                        this.byte_38[index51] = (byte)((uint)this.byte_40[(index51 ^ (uint)this.byte_43)] + (uint)this.byte_42);
                                    bufferedStream1.Write(this.byte_38, 0, count6);
                                }
                                break;
                            }
                            if (c.int_2 != 1 && c.int_2 != 11 && c.int_2 != 7 && c.int_2 != 8 && c.int_2 != 9 && c.int_2 != 84)
                            {
                                switch (c.int_2)
                                {
                                    case 51:
                                        for (int index52 = 0; index52 < this.int_40; ++index52)
                                        {
                                            this.progressBar_0.Value = index52;
                                            this.bufferedStream_1.Seek((long)this.int_39 * (long)index52, SeekOrigin.Begin);
                                            this.bufferedStream_1.Read(this.byte_38, 0, this.int_39);
                                            for (uint index53 = 0; (long)index53 < (long)this.int_39; ++index53)
                                                this.byte_37[index53] = (byte)((uint)this.byte_38[(index53 ^ (uint)this.byte_45)] - (uint)this.byte_44);
                                            byte num40 = 1;
                                            int count7 = 0;
                                            for (int index54 = 0; index54 < num1; ++index54)
                                            {
                                                for (int int_94 = 0; int_94 < this.int_82; ++int_94)
                                                {
                                                    for (int index55 = 0; index55 < 8; ++index55)
                                                    {
                                                        byte num41 = 0;
                                                        for (int int_93 = index54 * c.int_75; int_93 < (index54 + 1) * c.int_75; ++int_93)
                                                        {
                                                            byte index56 = this.method_41(int_93, int_94, (int)numArray10[0]);
                                                            if ((byte)((uint)c.byte_21[(int)index56] & (uint)num40 << index55) != (byte)0)
                                                                num41 |= (byte)((uint)num40 << int_93 % c.int_75);
                                                        }
                                                        this.byte_40[count7] = num41;
                                                        ++count7;
                                                    }
                                                }
                                            }
                                            if (c.int_2 == 51)
                                            {
                                                int int82 = this.int_82;
                                                byte[] numArray13 = new byte[int82];
                                                for (int index57 = 0; index57 < int82; ++index57)
                                                {
                                                    byte num42 = 0;
                                                    for (int index58 = 0; index58 < 8; ++index58)
                                                        num42 |= (byte)(((int)this.byte_40[index57 * 8 + index58] & 1) << index58);
                                                    numArray13[index57] = num42;
                                                }
                                                for (uint index59 = 0; (long)index59 < (long)int82; ++index59)
                                                    this.byte_38[index59] = (byte)((uint)numArray13[(index59 ^ (uint)this.byte_43)] + (uint)this.byte_42);
                                                bufferedStream1.Write(this.byte_38, 0, int82);
                                            }
                                            else
                                            {
                                                for (uint index60 = 0; (long)index60 < (long)count7; ++index60)
                                                    this.byte_38[index60] = (byte)((uint)this.byte_40[(index60 ^ (uint)this.byte_43)] + (uint)this.byte_42);
                                                bufferedStream1.Write(this.byte_38, 0, count7);
                                            }
                                        }
                                        break;
                                    case 55:
                                        for (int index61 = 0; index61 < this.int_40; ++index61)
                                        {
                                            this.progressBar_0.Value = index61;
                                            this.bufferedStream_1.Seek((long)this.int_39 * (long)index61, SeekOrigin.Begin);
                                            this.bufferedStream_1.Read(this.byte_38, 0, this.int_39);
                                            for (uint index62 = 0; (long)index62 < (long)this.int_39; ++index62)
                                                this.byte_37[index62] = (byte)((uint)this.byte_38[(index62 ^ (uint)this.byte_45)] - (uint)this.byte_44);
                                            byte num43 = 1;
                                            int count8 = 0;
                                            for (int index63 = 0; index63 < num1; ++index63)
                                            {
                                                for (int int_94 = 0; int_94 < this.int_82; ++int_94)
                                                {
                                                    for (int index64 = 7; index64 >= 0; --index64)
                                                    {
                                                        byte num44 = 0;
                                                        for (int int_93 = index63 * c.int_75; int_93 < (index63 + 1) * c.int_75; ++int_93)
                                                        {
                                                            byte index65 = this.method_41(int_93, int_94, (int)numArray10[0]);
                                                            if ((byte)((uint)c.byte_21[(int)index65] & (uint)num43 << index64) != (byte)0)
                                                                num44 |= (byte)((uint)num43 << int_93 % c.int_75);
                                                        }
                                                        this.byte_40[count8] = num44;
                                                        ++count8;
                                                    }
                                                }
                                            }
                                            if (c.int_2 == 55)
                                            {
                                                int int82 = this.int_82;
                                                byte[] numArray14 = new byte[int82];
                                                for (int index66 = 0; index66 < int82; ++index66)
                                                {
                                                    byte num45 = 0;
                                                    for (int index67 = 0; index67 < 8; ++index67)
                                                        num45 |= (byte)(((int)this.byte_40[index66 * 8 + index67] & 1) << index67);
                                                    numArray14[index66] = num45;
                                                }
                                                for (uint index68 = 0; (long)index68 < (long)int82; ++index68)
                                                    this.byte_38[index68] = (byte)((uint)numArray14[(index68 ^ (uint)this.byte_43)] + (uint)this.byte_42);
                                                bufferedStream1.Write(this.byte_38, 0, int82);
                                            }
                                            else
                                            {
                                                for (uint index69 = 0; (long)index69 < (long)count8; ++index69)
                                                    this.byte_38[index69] = (byte)((uint)this.byte_40[(index69 ^ (uint)this.byte_43)] + (uint)this.byte_42);
                                                bufferedStream1.Write(this.byte_38, 0, count8);
                                            }
                                        }
                                        break;
                                    default:
                                        if (c.int_2 != 2 && c.int_2 != 49 && c.int_2 != 16 && c.int_2 != 110 && c.int_2 != 83)
                                        {
                                            if (c.int_2 != 120 && c.int_2 != 130 && c.int_2 != 150)
                                            {
                                                if (c.int_2 == 12 || c.int_2 == 13 || c.int_2 == 31 || c.int_2 == 50 || c.int_2 == 32 || c.int_2 == 81 || c.int_2 == 86 || c.int_2 == 82 || c.int_2 == 41 || c.int_2 == 140 || c.int_2 == 46 || c.int_2 == 48 || c.int_2 == 47 || c.int_2 == 85 || c.int_2 == 52 || c.int_2 == 53 || c.int_2 == 54)
                                                {
                                                    for (int index70 = 0; index70 < this.int_40; ++index70)
                                                    {
                                                        this.progressBar_0.Value = index70;
                                                        this.bufferedStream_1.Seek((long)this.int_39 * (long)index70, SeekOrigin.Begin);
                                                        this.bufferedStream_1.Read(this.byte_38, 0, this.int_39);
                                                        for (uint index71 = 0; (long)index71 < (long)this.int_39; ++index71)
                                                            this.byte_37[index71] = (byte)((uint)this.byte_38[(index71 ^ (uint)this.byte_45)] - (uint)this.byte_44);
                                                        byte num46 = 1;
                                                        int index72 = 0;
                                                        for (int index73 = 0; index73 < num1; ++index73)
                                                        {
                                                            if (c.bool_14)
                                                            {
                                                                int num47;
                                                                if (c.byte_19 == (byte)3)
                                                                {
                                                                    int num48 = this.int_82 % 6;
                                                                    num47 = num48 + 1;
                                                                    index72 = num48 * 24;
                                                                }
                                                                else
                                                                    num47 = 1;
                                                                for (int index74 = this.int_82 - num47; index74 >= 0; --index74)
                                                                {
                                                                    int int_94;
                                                                    switch (c.byte_19)
                                                                    {
                                                                        case 2:
                                                                            int_94 = index74 / 4 * 4 + (3 - index74 % 4);
                                                                            break;
                                                                        case 3:
                                                                            int_94 = index74 / 6 * 6 + (5 - index74 % 6);
                                                                            break;
                                                                        default:
                                                                            int_94 = index74;
                                                                            break;
                                                                    }
                                                                    for (int index75 = 7; index75 >= 0; --index75)
                                                                    {
                                                                        byte num49 = 0;
                                                                        for (int int_93 = index73 * c.int_75; int_93 < (index73 + 1) * c.int_75; ++int_93)
                                                                        {
                                                                            byte index76 = this.method_41(int_93, int_94, (int)numArray10[0]);
                                                                            if ((byte)((uint)c.byte_21[(int)index76] & (uint)num46 << index75) != (byte)0)
                                                                                num49 |= (byte)((uint)num46 << int_93 % c.int_75);
                                                                        }
                                                                        this.byte_40[index72] = num49;
                                                                        ++index72;
                                                                    }
                                                                    for (int index77 = 7; index77 >= 0; --index77)
                                                                    {
                                                                        byte num50 = 0;
                                                                        for (int int_93 = index73 * c.int_75; int_93 < (index73 + 1) * c.int_75; ++int_93)
                                                                        {
                                                                            byte index78 = this.method_41(int_93, int_94, (int)numArray10[1]);
                                                                            if ((byte)((uint)c.byte_22[(int)index78] & (uint)num46 << index77) != (byte)0)
                                                                                num50 |= (byte)((uint)num46 << int_93 % c.int_75);
                                                                        }
                                                                        this.byte_40[index72] = num50;
                                                                        ++index72;
                                                                    }
                                                                    for (int index79 = 7; index79 >= 0; --index79)
                                                                    {
                                                                        byte num51 = 0;
                                                                        for (int int_93 = index73 * c.int_75; int_93 < (index73 + 1) * c.int_75; ++int_93)
                                                                        {
                                                                            byte index80 = this.method_41(int_93, int_94, (int)numArray10[2]);
                                                                            if ((byte)((uint)c.byte_23[(int)index80] & (uint)num46 << index79) != (byte)0)
                                                                                num51 |= (byte)((uint)num46 << int_93 % c.int_75);
                                                                        }
                                                                        this.byte_40[index72] = num51;
                                                                        ++index72;
                                                                    }
                                                                }
                                                            }
                                                            else
                                                            {
                                                                for (int int_94 = 0; int_94 < this.int_82; ++int_94)
                                                                {
                                                                    for (int index81 = 7; index81 >= 0; --index81)
                                                                    {
                                                                        byte num52 = 0;
                                                                        for (int int_93 = index73 * c.int_75; int_93 < (index73 + 1) * c.int_75; ++int_93)
                                                                        {
                                                                            byte index82 = this.method_41(int_93, int_94, (int)numArray10[0]);
                                                                            if ((byte)((uint)c.byte_21[(int)index82] & (uint)num46 << index81) != (byte)0)
                                                                                num52 |= (byte)((uint)num46 << int_93 % c.int_75);
                                                                        }
                                                                        this.byte_40[index72] = num52;
                                                                        ++index72;
                                                                    }
                                                                    for (int index83 = 7; index83 >= 0; --index83)
                                                                    {
                                                                        byte num53 = 0;
                                                                        for (int int_93 = index73 * c.int_75; int_93 < (index73 + 1) * c.int_75; ++int_93)
                                                                        {
                                                                            byte index84 = this.method_41(int_93, int_94, (int)numArray10[1]);
                                                                            if ((byte)((uint)c.byte_22[(int)index84] & (uint)num46 << index83) != (byte)0)
                                                                                num53 |= (byte)((uint)num46 << int_93 % c.int_75);
                                                                        }
                                                                        this.byte_40[index72] = num53;
                                                                        ++index72;
                                                                    }
                                                                    for (int index85 = 7; index85 >= 0; --index85)
                                                                    {
                                                                        byte num54 = 0;
                                                                        for (int int_93 = index73 * c.int_75; int_93 < (index73 + 1) * c.int_75; ++int_93)
                                                                        {
                                                                            byte index86 = this.method_41(int_93, int_94, (int)numArray10[2]);
                                                                            if ((byte)((uint)c.byte_23[(int)index86] & (uint)num46 << index85) != (byte)0)
                                                                                num54 |= (byte)((uint)num46 << int_93 % c.int_75);
                                                                        }
                                                                        this.byte_40[index72] = num54;
                                                                        ++index72;
                                                                    }
                                                                }
                                                            }
                                                        }
                                                        if (c.int_2 != 13 && c.int_2 != 32 && c.int_2 != 47 && c.int_2 != 52)
                                                        {
                                                            for (uint index87 = 0; (long)index87 < (long)this.int_39; ++index87)
                                                                this.byte_38[index87] = (byte)((uint)this.byte_40[(index87 ^ (uint)this.byte_43)] + (uint)this.byte_42);
                                                            bufferedStream1.Write(this.byte_38, 0, this.int_39);
                                                        }
                                                        else
                                                        {
                                                            int count9 = this.int_82 * 24 / 8;
                                                            byte[] numArray15 = new byte[count9];
                                                            for (int index88 = 0; index88 < count9; ++index88)
                                                            {
                                                                byte num55 = 0;
                                                                for (int index89 = 0; index89 < 8; ++index89)
                                                                    num55 |= (byte)(((int)this.byte_40[index88 * 8 + index89] & 1) << index89);
                                                                numArray15[index88] = num55;
                                                            }
                                                            for (uint index90 = 0; (long)index90 < (long)count9; ++index90)
                                                                this.byte_38[index90] = (byte)((uint)numArray15[(index90 ^ (uint)this.byte_43)] + (uint)this.byte_42);
                                                            bufferedStream1.Write(this.byte_38, 0, count9);
                                                        }
                                                    }
                                                    break;
                                                }
                                                break;
                                            }
                                            if (!c.bool_2)
                                            {
                                                for (int index91 = 0; index91 < this.int_40; ++index91)
                                                {
                                                    this.progressBar_0.Value = index91;
                                                    this.bufferedStream_1.Seek((long)this.int_39 * (long)index91, SeekOrigin.Begin);
                                                    this.bufferedStream_1.Read(this.byte_38, 0, this.int_39);
                                                    for (uint index92 = 0; (long)index92 < (long)this.int_39; ++index92)
                                                        this.byte_37[index92] = (byte)((uint)this.byte_38[(index92 ^ (uint)this.byte_45)] - (uint)this.byte_44);
                                                    int index93 = 0;
                                                    for (int index94 = 0; index94 < num1; ++index94)
                                                    {
                                                        if (c.bool_14)
                                                        {
                                                            int num56;
                                                            if (c.byte_19 == (byte)3)
                                                            {
                                                                int num57 = this.int_82 % 6;
                                                                num56 = num57 + 1;
                                                                index93 = num57 * 24;
                                                            }
                                                            else
                                                                num56 = 1;
                                                            for (int index95 = this.int_82 - num56; index95 >= 0; --index95)
                                                            {
                                                                int int_94;
                                                                switch (c.byte_19)
                                                                {
                                                                    case 2:
                                                                        int_94 = index95 / 4 * 4 + (3 - index95 % 4);
                                                                        break;
                                                                    case 3:
                                                                        int_94 = index95 / 6 * 6 + (5 - index95 % 6);
                                                                        break;
                                                                    default:
                                                                        int_94 = index95;
                                                                        break;
                                                                }
                                                                for (int int_93 = index94 * c.int_75; int_93 < (index94 + 1) * c.int_75; ++int_93)
                                                                {
                                                                    byte index96 = this.method_41(int_93, int_94, (int)numArray10[0]);
                                                                    byte num58 = c.byte_21[(int)index96];
                                                                    this.byte_40[index93] = num58;
                                                                    ++index93;
                                                                }
                                                                for (int int_93 = index94 * c.int_75; int_93 < (index94 + 1) * c.int_75; ++int_93)
                                                                {
                                                                    byte index97 = this.method_41(int_93, int_94, (int)numArray10[1]);
                                                                    byte num59 = c.byte_22[(int)index97];
                                                                    this.byte_40[index93] = num59;
                                                                    ++index93;
                                                                }
                                                                for (int int_93 = index94 * c.int_75; int_93 < (index94 + 1) * c.int_75; ++int_93)
                                                                {
                                                                    byte index98 = this.method_41(int_93, int_94, (int)numArray10[2]);
                                                                    byte num60 = c.byte_23[(int)index98];
                                                                    this.byte_40[index93] = num60;
                                                                    ++index93;
                                                                }
                                                            }
                                                        }
                                                        else
                                                        {
                                                            for (int int_94 = 0; int_94 < this.int_82; ++int_94)
                                                            {
                                                                for (int int_93 = index94 * c.int_75; int_93 < (index94 + 1) * c.int_75; ++int_93)
                                                                {
                                                                    byte index99 = this.method_41(int_93, int_94, (int)numArray10[0]);
                                                                    byte num61 = c.byte_21[(int)index99];
                                                                    this.byte_40[index93] = num61;
                                                                    ++index93;
                                                                }
                                                                for (int int_93 = index94 * c.int_75; int_93 < (index94 + 1) * c.int_75; ++int_93)
                                                                {
                                                                    byte index100 = this.method_41(int_93, int_94, (int)numArray10[1]);
                                                                    byte num62 = c.byte_22[(int)index100];
                                                                    this.byte_40[index93] = num62;
                                                                    ++index93;
                                                                }
                                                                for (int int_93 = index94 * c.int_75; int_93 < (index94 + 1) * c.int_75; ++int_93)
                                                                {
                                                                    byte index101 = this.method_41(int_93, int_94, (int)numArray10[2]);
                                                                    byte num63 = c.byte_23[(int)index101];
                                                                    this.byte_40[index93] = num63;
                                                                    ++index93;
                                                                }
                                                            }
                                                        }
                                                    }
                                                    for (uint index102 = 0; (long)index102 < (long)this.int_39; ++index102)
                                                        this.byte_38[index102] = (byte)((uint)this.byte_40[(index102 ^ (uint)this.byte_43)] + (uint)this.byte_42);
                                                    bufferedStream1.Write(this.byte_38, 0, this.int_39);
                                                }
                                                break;
                                            }
                                            for (int index103 = 0; index103 < this.int_40; ++index103)
                                            {
                                                this.progressBar_0.Value = index103;
                                                this.bufferedStream_1.Seek((long)this.int_39 * (long)index103, SeekOrigin.Begin);
                                                this.bufferedStream_1.Read(this.byte_38, 0, this.int_39);
                                                for (uint index104 = 0; (long)index104 < (long)this.int_39; ++index104)
                                                    this.byte_37[index104] = (byte)((uint)this.byte_38[(index104 ^ (uint)this.byte_45)] - (uint)this.byte_44);
                                                byte num64 = 1;
                                                int index105 = 0;
                                                for (int index106 = 0; index106 < num1; ++index106)
                                                {
                                                    if (c.bool_14)
                                                    {
                                                        int num65;
                                                        if (c.byte_19 == (byte)3)
                                                        {
                                                            int num66 = this.int_82 % 6;
                                                            num65 = num66 + 1;
                                                            index105 = num66 * 24;
                                                        }
                                                        else
                                                            num65 = 1;
                                                        for (int index107 = this.int_82 - num65; index107 >= 0; --index107)
                                                        {
                                                            int int_94;
                                                            switch (c.byte_19)
                                                            {
                                                                case 2:
                                                                    int_94 = index107 / 4 * 4 + (3 - index107 % 4);
                                                                    break;
                                                                case 3:
                                                                    int_94 = index107 / 6 * 6 + (5 - index107 % 6);
                                                                    break;
                                                                default:
                                                                    int_94 = index107;
                                                                    break;
                                                            }
                                                            for (int index108 = 7; index108 >= 0; --index108)
                                                            {
                                                                byte num67 = 0;
                                                                for (int int_93 = index106 * c.int_75; int_93 < (index106 + 1) * c.int_75; ++int_93)
                                                                {
                                                                    byte index109 = this.method_41(int_93, int_94, (int)numArray10[0]);
                                                                    if ((byte)((uint)c.byte_21[(int)index109] & (uint)num64 << index108) != (byte)0)
                                                                        num67 |= (byte)((uint)num64 << int_93 % c.int_75);
                                                                }
                                                                this.byte_40[index105] = num67;
                                                                ++index105;
                                                            }
                                                            for (int index110 = 7; index110 >= 0; --index110)
                                                            {
                                                                byte num68 = 0;
                                                                for (int int_93 = index106 * c.int_75; int_93 < (index106 + 1) * c.int_75; ++int_93)
                                                                {
                                                                    byte index111 = this.method_41(int_93, int_94, (int)numArray10[1]);
                                                                    if ((byte)((uint)c.byte_22[(int)index111] & (uint)num64 << index110) != (byte)0)
                                                                        num68 |= (byte)((uint)num64 << int_93 % c.int_75);
                                                                }
                                                                this.byte_40[index105] = num68;
                                                                ++index105;
                                                            }
                                                            for (int index112 = 7; index112 >= 0; --index112)
                                                            {
                                                                byte num69 = 0;
                                                                for (int int_93 = index106 * c.int_75; int_93 < (index106 + 1) * c.int_75; ++int_93)
                                                                {
                                                                    byte index113 = this.method_41(int_93, int_94, (int)numArray10[2]);
                                                                    if ((byte)((uint)c.byte_23[(int)index113] & (uint)num64 << index112) != (byte)0)
                                                                        num69 |= (byte)((uint)num64 << int_93 % c.int_75);
                                                                }
                                                                this.byte_40[index105] = num69;
                                                                ++index105;
                                                            }
                                                        }
                                                    }
                                                    else
                                                    {
                                                        for (int int_94 = 0; int_94 < this.int_82; ++int_94)
                                                        {
                                                            for (int index114 = 7; index114 >= 0; --index114)
                                                            {
                                                                byte num70 = 0;
                                                                for (int int_93 = index106 * c.int_75; int_93 < (index106 + 1) * c.int_75; ++int_93)
                                                                {
                                                                    byte index115 = this.method_41(int_93, int_94, (int)numArray10[0]);
                                                                    if ((byte)((uint)c.byte_21[(int)index115] & (uint)num64 << index114) != (byte)0)
                                                                        num70 |= (byte)((uint)num64 << int_93 % c.int_75);
                                                                }
                                                                this.byte_40[index105] = num70;
                                                                ++index105;
                                                            }
                                                            for (int index116 = 7; index116 >= 0; --index116)
                                                            {
                                                                byte num71 = 0;
                                                                for (int int_93 = index106 * c.int_75; int_93 < (index106 + 1) * c.int_75; ++int_93)
                                                                {
                                                                    byte index117 = this.method_41(int_93, int_94, (int)numArray10[1]);
                                                                    if ((byte)((uint)c.byte_22[(int)index117] & (uint)num64 << index116) != (byte)0)
                                                                        num71 |= (byte)((uint)num64 << int_93 % c.int_75);
                                                                }
                                                                this.byte_40[index105] = num71;
                                                                ++index105;
                                                            }
                                                            for (int index118 = 7; index118 >= 0; --index118)
                                                            {
                                                                byte num72 = 0;
                                                                for (int int_93 = index106 * c.int_75; int_93 < (index106 + 1) * c.int_75; ++int_93)
                                                                {
                                                                    byte index119 = this.method_41(int_93, int_94, (int)numArray10[2]);
                                                                    if ((byte)((uint)c.byte_23[(int)index119] & (uint)num64 << index118) != (byte)0)
                                                                        num72 |= (byte)((uint)num64 << int_93 % c.int_75);
                                                                }
                                                                this.byte_40[index105] = num72;
                                                                ++index105;
                                                            }
                                                        }
                                                    }
                                                }
                                                for (uint index120 = 0; (long)index120 < (long)this.int_39; ++index120)
                                                    this.byte_38[index120] = (byte)((uint)this.byte_40[(index120 ^ (uint)this.byte_43)] + (uint)this.byte_42);
                                                bufferedStream1.Write(this.byte_38, 0, this.int_39);
                                            }
                                            break;
                                        }
                                        for (int index121 = 0; index121 < this.int_40; ++index121)
                                        {
                                            this.progressBar_0.Value = index121;
                                            this.bufferedStream_1.Seek((long)this.int_39 * (long)index121, SeekOrigin.Begin);
                                            this.bufferedStream_1.Read(this.byte_38, 0, this.int_39);
                                            for (uint index122 = 0; (long)index122 < (long)this.int_39; ++index122)
                                                this.byte_37[index122] = (byte)((uint)this.byte_38[(index122 ^ (uint)this.byte_45)] - (uint)this.byte_44);
                                            byte num73 = 1;
                                            int count10 = 0;
                                            for (int index123 = 0; index123 < num1; ++index123)
                                            {
                                                if (c.bool_1)
                                                    count10 = index123 * 4096;
                                                for (int int_94 = 0; int_94 < this.int_82; ++int_94)
                                                {
                                                    for (int index124 = 0; index124 < 8; ++index124)
                                                    {
                                                        byte num74 = 0;
                                                        for (int int_93 = index123 * c.int_75; int_93 < (index123 + 1) * c.int_75; ++int_93)
                                                        {
                                                            byte index125 = this.method_41(int_93, int_94, (int)numArray10[0]);
                                                            if ((byte)((uint)c.byte_21[(int)index125] & (uint)num73 << index124) != (byte)0)
                                                                num74 |= (byte)((uint)num73 << int_93 % c.int_75);
                                                        }
                                                        this.byte_40[count10] = num74;
                                                        ++count10;
                                                    }
                                                    for (int index126 = 0; index126 < 8; ++index126)
                                                    {
                                                        byte num75 = 0;
                                                        for (int int_93 = index123 * c.int_75; int_93 < (index123 + 1) * c.int_75; ++int_93)
                                                        {
                                                            byte index127 = this.method_41(int_93, int_94, (int)numArray10[1]);
                                                            if ((byte)((uint)c.byte_22[(int)index127] & (uint)num73 << index126) != (byte)0)
                                                                num75 |= (byte)((uint)num73 << int_93 % c.int_75);
                                                        }
                                                        this.byte_40[count10] = num75;
                                                        ++count10;
                                                    }
                                                    for (int index128 = 0; index128 < 8; ++index128)
                                                    {
                                                        byte num76 = 0;
                                                        for (int int_93 = index123 * c.int_75; int_93 < (index123 + 1) * c.int_75; ++int_93)
                                                        {
                                                            byte index129 = this.method_41(int_93, int_94, (int)numArray10[2]);
                                                            if ((byte)((uint)c.byte_23[(int)index129] & (uint)num73 << index128) != (byte)0)
                                                                num76 |= (byte)((uint)num73 << int_93 % c.int_75);
                                                        }
                                                        this.byte_40[count10] = num76;
                                                        ++count10;
                                                    }
                                                }
                                            }
                                            if (c.int_2 == 16)
                                            {
                                                if (c.bool_1)
                                                {
                                                    int count11 = 512;
                                                    byte[] numArray16 = new byte[512];
                                                    for (int index130 = 0; index130 < count11; ++index130)
                                                    {
                                                        byte num77 = 0;
                                                        for (int index131 = 0; index131 < 8; ++index131)
                                                            num77 |= (byte)(((int)this.byte_40[index130 * 8 + index131] & 1) << index131);
                                                        numArray16[index130] = num77;
                                                    }
                                                    for (uint index132 = 0; (long)index132 < (long)count11; ++index132)
                                                        this.byte_38[index132] = (byte)((uint)numArray16[(index132 ^ (uint)this.byte_43)] + (uint)this.byte_42);
                                                    bufferedStream1.Write(this.byte_38, 0, count11);
                                                }
                                                else
                                                {
                                                    int count12 = this.int_82 * 24 / 8;
                                                    byte[] numArray17 = new byte[count12];
                                                    for (int index133 = 0; index133 < count12; ++index133)
                                                    {
                                                        byte num78 = 0;
                                                        for (int index134 = 0; index134 < 8; ++index134)
                                                            num78 |= (byte)(((int)this.byte_40[index133 * 8 + index134] & 1) << index134);
                                                        numArray17[index133] = num78;
                                                    }
                                                    for (uint index135 = 0; (long)index135 < (long)count12; ++index135)
                                                        this.byte_38[index135] = (byte)((uint)numArray17[(index135 ^ (uint)this.byte_43)] + (uint)this.byte_42);
                                                    bufferedStream1.Write(this.byte_38, 0, count12);
                                                }
                                            }
                                            else if (c.bool_1)
                                            {
                                                for (uint index136 = 0; (long)index136 < (long)this.int_39; ++index136)
                                                    this.byte_38[index136] = (byte)((uint)this.byte_40[(index136 ^ (uint)this.byte_43)] + (uint)this.byte_42);
                                                bufferedStream1.Write(this.byte_38, 0, this.int_39);
                                            }
                                            else
                                            {
                                                for (uint index137 = 0; (long)index137 < (long)count10; ++index137)
                                                    this.byte_38[index137] = (byte)((uint)this.byte_40[(index137 ^ (uint)this.byte_43)] + (uint)this.byte_42);
                                                bufferedStream1.Write(this.byte_38, 0, count10);
                                            }
                                        }
                                        break;
                                }
                            }
                            else
                            {
                                for (int index138 = 0; index138 < this.int_40; ++index138)
                                {
                                    this.progressBar_0.Value = index138;
                                    this.bufferedStream_1.Seek((long)this.int_39 * (long)index138, SeekOrigin.Begin);
                                    this.bufferedStream_1.Read(this.byte_38, 0, this.int_39);
                                    for (uint index139 = 0; (long)index139 < (long)this.int_39; ++index139)
                                        this.byte_37[index139] = (byte)((uint)this.byte_38[(index139 ^ (uint)this.byte_45)] - (uint)this.byte_44);
                                    byte num79 = 1;
                                    int count13 = 0;
                                    for (int index140 = 0; index140 < num1; ++index140)
                                    {
                                        for (int int_94 = 0; int_94 < this.int_82; ++int_94)
                                        {
                                            this.byte_40[count13] = byte.MaxValue;
                                            ++count13;
                                            for (int index141 = 7; index141 > 2; --index141)
                                            {
                                                byte num80 = 0;
                                                for (int int_93 = index140 * c.int_75; int_93 < (index140 + 1) * c.int_75; ++int_93)
                                                {
                                                    byte index142 = this.method_41(int_93, int_94, (int)numArray10[0]);
                                                    if ((byte)((uint)c.byte_21[(int)index142] & (uint)num79 << index141) != (byte)0)
                                                        num80 |= (byte)((uint)num79 << int_93 % c.int_75);
                                                }
                                                this.byte_40[count13] = num80;
                                                ++count13;
                                            }
                                            for (int index143 = 7; index143 > 2; --index143)
                                            {
                                                byte num81 = 0;
                                                for (int int_93 = index140 * c.int_75; int_93 < (index140 + 1) * c.int_75; ++int_93)
                                                {
                                                    byte index144 = this.method_41(int_93, int_94, (int)numArray10[1]);
                                                    if ((byte)((uint)c.byte_22[(int)index144] & (uint)num79 << index143) != (byte)0)
                                                        num81 |= (byte)((uint)num79 << int_93 % c.int_75);
                                                }
                                                this.byte_40[count13] = num81;
                                                ++count13;
                                            }
                                            for (int index145 = 7; index145 > 2; --index145)
                                            {
                                                byte num82 = 0;
                                                for (int int_93 = index140 * c.int_75; int_93 < (index140 + 1) * c.int_75; ++int_93)
                                                {
                                                    byte index146 = this.method_41(int_93, int_94, (int)numArray10[2]);
                                                    if ((byte)((uint)c.byte_23[(int)index146] & (uint)num79 << index145) != (byte)0)
                                                        num82 |= (byte)((uint)num79 << int_93 % c.int_75);
                                                }
                                                this.byte_40[count13] = num82;
                                                ++count13;
                                            }
                                        }
                                    }
                                    if (c.int_2 == 9)
                                    {
                                        int count14 = this.int_82 * 16 / 8;
                                        byte[] numArray18 = new byte[count14];
                                        for (int index147 = 0; index147 < count14; ++index147)
                                        {
                                            byte num83 = 0;
                                            for (int index148 = 0; index148 < 8; ++index148)
                                                num83 |= (byte)(((int)this.byte_40[index147 * 8 + index148] & 1) << index148);
                                            numArray18[index147] = num83;
                                        }
                                        for (uint index149 = 0; (long)index149 < (long)count14; ++index149)
                                            this.byte_38[index149] = (byte)((uint)numArray18[(index149 ^ (uint)this.byte_43)] + (uint)this.byte_42);
                                        bufferedStream1.Write(this.byte_38, 0, count14);
                                    }
                                    else
                                    {
                                        for (uint index150 = 0; (long)index150 < (long)count13; ++index150)
                                            this.byte_38[index150] = (byte)((uint)this.byte_40[(index150 ^ (uint)this.byte_43)] + (uint)this.byte_42);
                                        bufferedStream1.Write(this.byte_38, 0, count13);
                                    }
                                }
                                break;
                            }
                        }
                        else
                        {
                            switch (c.int_81)
                            {
                                case 0:
                                    numArray10[0] = (byte)2;
                                    numArray10[1] = (byte)1;
                                    numArray10[2] = (byte)0;
                                    break;
                                case 1:
                                    numArray10[0] = (byte)1;
                                    numArray10[1] = (byte)2;
                                    numArray10[2] = (byte)0;
                                    break;
                                case 2:
                                    numArray10[0] = (byte)2;
                                    numArray10[1] = (byte)0;
                                    numArray10[2] = (byte)1;
                                    break;
                                case 3:
                                    numArray10[0] = (byte)0;
                                    numArray10[1] = (byte)2;
                                    numArray10[2] = (byte)1;
                                    break;
                                case 4:
                                    numArray10[0] = (byte)1;
                                    numArray10[1] = (byte)0;
                                    numArray10[2] = (byte)2;
                                    break;
                                case 5:
                                    numArray10[0] = (byte)0;
                                    numArray10[1] = (byte)1;
                                    numArray10[2] = (byte)2;
                                    break;
                                default:
                                    numArray10[0] = (byte)2;
                                    numArray10[1] = (byte)1;
                                    numArray10[2] = (byte)0;
                                    break;
                            }
                            int num84 = c.int_8 + c.int_9 + c.int_10 + 3;
                            int num85 = (1536 - (int)c.byte_0) / num84;
                            int num86 = (1536 - (int)c.byte_0) % num84;
                            for (int index151 = 0; index151 < this.int_40; ++index151)
                            {
                                this.progressBar_0.Value = index151;
                                this.bufferedStream_1.Seek((long)this.int_39 * (long)index151, SeekOrigin.Begin);
                                this.bufferedStream_1.Read(this.byte_38, 0, this.int_39);
                                for (uint index152 = 0; (long)index152 < (long)this.int_39; ++index152)
                                    this.byte_37[index152] = (byte)((uint)this.byte_38[(index152 ^ (uint)this.byte_45)] - (uint)this.byte_44);
                                byte num87 = 1;
                                this.class2_0.method_0();
                                int count15 = 0;
                                for (int index153 = 0; index153 < num1; ++index153)
                                {
                                    for (int index154 = 4; index154 < 8; ++index154)
                                    {
                                        int num88 = count15 + num86;
                                        for (int int_94 = num85 - 1; int_94 >= 0; --int_94)
                                        {
                                            byte num89 = 0;
                                            byte num90 = 0;
                                            byte num91 = 0;
                                            int index155 = num88 + c.int_10;
                                            for (int int_93 = index153 * c.int_75; int_93 < (index153 + 1) * c.int_75; ++int_93)
                                            {
                                                byte index156 = this.method_41(int_93, int_94, (int)numArray10[0]);
                                                if ((byte)((uint)c.byte_23[(int)index156] & (uint)num87 << index154) != (byte)0)
                                                    num89 |= (byte)((uint)num87 << int_93 % c.int_75);
                                            }
                                            this.byte_40[index155] = num89;
                                            int index157 = index155 + 1 + c.int_9;
                                            for (int int_93 = index153 * c.int_75; int_93 < (index153 + 1) * c.int_75; ++int_93)
                                            {
                                                byte index158 = this.method_41(int_93, int_94, (int)numArray10[1]);
                                                if ((byte)((uint)c.byte_22[(int)index158] & (uint)num87 << index154) != (byte)0)
                                                    num90 |= (byte)((uint)num87 << int_93 % c.int_75);
                                            }
                                            this.byte_40[index157] = num90;
                                            int index159 = index157 + 1 + c.int_8;
                                            for (int int_93 = index153 * c.int_75; int_93 < (index153 + 1) * c.int_75; ++int_93)
                                            {
                                                byte index160 = this.method_41(int_93, int_94, (int)numArray10[2]);
                                                if ((byte)((uint)c.byte_21[(int)index160] & (uint)num87 << index154) != (byte)0)
                                                    num91 |= (byte)((uint)num87 << int_93 % c.int_75);
                                            }
                                            this.byte_40[index159] = num91;
                                            num88 = index159 + 1;
                                        }
                                        count15 = num88 + (int)c.byte_0;
                                    }
                                }
                                this.class2_0.method_1();
                                if (c.int_2 == 15)
                                {
                                    int count16 = this.int_82 * 12 / 8;
                                    byte[] numArray19 = new byte[count16];
                                    for (int index161 = 0; index161 < count16; ++index161)
                                    {
                                        byte num92 = 0;
                                        for (int index162 = 0; index162 < 8; ++index162)
                                            num92 |= (byte)(((int)this.byte_40[index161 * 8 + index162] & 1) << index162);
                                        numArray19[index161] = num92;
                                    }
                                    for (uint index163 = 0; (long)index163 < (long)count16; ++index163)
                                        this.byte_38[index163] = (byte)((uint)numArray19[(index163 ^ (uint)this.byte_43)] + (uint)this.byte_42);
                                    bufferedStream1.Write(this.byte_38, 0, count16);
                                    bufferedStream1.Write(this.byte_38, 0, 256);
                                }
                                else
                                {
                                    for (uint index164 = 0; (long)index164 < (long)count15; ++index164)
                                        this.byte_38[index164] = (byte)((uint)this.byte_40[(index164 ^ (uint)this.byte_43)] + (uint)this.byte_42);
                                    bufferedStream1.Write(this.byte_38, 0, count15);
                                }
                            }
                            break;
                        }
                    }
                    else
                    {
                        switch (c.int_81)
                        {
                            case 0:
                                numArray10[0] = (byte)2;
                                numArray10[1] = (byte)1;
                                numArray10[2] = (byte)0;
                                break;
                            case 1:
                                numArray10[0] = (byte)1;
                                numArray10[1] = (byte)2;
                                numArray10[2] = (byte)0;
                                break;
                            case 2:
                                numArray10[0] = (byte)2;
                                numArray10[1] = (byte)0;
                                numArray10[2] = (byte)1;
                                break;
                            case 3:
                                numArray10[0] = (byte)0;
                                numArray10[1] = (byte)2;
                                numArray10[2] = (byte)1;
                                break;
                            case 4:
                                numArray10[0] = (byte)1;
                                numArray10[1] = (byte)0;
                                numArray10[2] = (byte)2;
                                break;
                            case 5:
                                numArray10[0] = (byte)0;
                                numArray10[1] = (byte)1;
                                numArray10[2] = (byte)2;
                                break;
                            default:
                                numArray10[0] = (byte)2;
                                numArray10[1] = (byte)1;
                                numArray10[2] = (byte)0;
                                break;
                        }
                        int num93 = c.int_8 + c.int_9 + c.int_10 + 3;
                        int num94 = (768 - (int)c.byte_0) / num93;
                        int num95 = (768 - (int)c.byte_0) % num93;
                        for (int index165 = 0; index165 < this.int_40; ++index165)
                        {
                            this.progressBar_0.Value = index165;
                            this.bufferedStream_1.Seek((long)this.int_39 * (long)index165, SeekOrigin.Begin);
                            this.bufferedStream_1.Read(this.byte_38, 0, this.int_39);
                            for (uint index166 = 0; (long)index166 < (long)this.int_39; ++index166)
                                this.byte_37[index166] = (byte)((uint)this.byte_38[(index166 ^ (uint)this.byte_45)] - (uint)this.byte_44);
                            byte num96 = 1;
                            this.class2_0.method_0();
                            int num97 = 0;
                            for (int index167 = 0; index167 < num1; ++index167)
                            {
                                for (int index168 = 0; index168 < 8; ++index168)
                                {
                                    int num98 = num97 + num95;
                                    for (int int_94 = num94 - 1; int_94 >= 0; --int_94)
                                    {
                                        byte num99 = 0;
                                        byte num100 = 0;
                                        byte num101 = 0;
                                        int index169 = num98 + c.int_10;
                                        for (int int_93 = index167 * c.int_75; int_93 < (index167 + 1) * c.int_75; ++int_93)
                                        {
                                            byte index170 = this.method_41(int_93, int_94, (int)numArray10[0]);
                                            if ((byte)((uint)c.byte_23[(int)index170] & (uint)num96 << index168) != (byte)0)
                                                num99 |= (byte)((uint)num96 << int_93 % c.int_75);
                                        }
                                        this.byte_40[index169] = num99;
                                        int index171 = index169 + 1 + c.int_9;
                                        for (int int_93 = index167 * c.int_75; int_93 < (index167 + 1) * c.int_75; ++int_93)
                                        {
                                            byte index172 = this.method_41(int_93, int_94, (int)numArray10[1]);
                                            if ((byte)((uint)c.byte_22[(int)index172] & (uint)num96 << index168) != (byte)0)
                                                num100 |= (byte)((uint)num96 << int_93 % c.int_75);
                                        }
                                        this.byte_40[index171] = num100;
                                        int index173 = index171 + 1 + c.int_8;
                                        for (int int_93 = index167 * c.int_75; int_93 < (index167 + 1) * c.int_75; ++int_93)
                                        {
                                            byte index174 = this.method_41(int_93, int_94, (int)numArray10[2]);
                                            if ((byte)((uint)c.byte_21[(int)index174] & (uint)num96 << index168) != (byte)0)
                                                num101 |= (byte)((uint)num96 << int_93 % c.int_75);
                                        }
                                        this.byte_40[index173] = num101;
                                        num98 = index173 + 1;
                                    }
                                    num97 = num98 + (int)c.byte_0;
                                }
                            }
                            this.class2_0.method_1();
                            if (c.int_2 == 14)
                            {
                                int count17 = this.int_82 * 24 / 8;
                                byte[] numArray20 = new byte[count17];
                                for (int index175 = 0; index175 < count17; ++index175)
                                {
                                    byte num102 = 0;
                                    for (int index176 = 0; index176 < 8; ++index176)
                                        num102 |= (byte)(((int)this.byte_40[index175 * 8 + index176] & 1) << index176);
                                    numArray20[index175] = num102;
                                }
                                for (uint index177 = 0; (long)index177 < (long)count17; ++index177)
                                    this.byte_38[index177] = (byte)((uint)numArray20[(index177 ^ (uint)this.byte_43)] + (uint)this.byte_42);
                                bufferedStream1.Write(this.byte_38, 0, count17);
                                bufferedStream1.Write(this.byte_38, 0, 256);
                            }
                            else
                            {
                                for (uint index178 = 0; (long)index178 < (long)this.int_39; ++index178)
                                    this.byte_38[index178] = (byte)((uint)this.byte_40[(index178 ^ (uint)this.byte_43)] + (uint)this.byte_42);
                                bufferedStream1.Write(this.byte_38, 0, this.int_39);
                            }
                        }
                        break;
                    }
                    break;
            }
        }
        else if (c.int_2 == 32 && c.byte_20 > (byte)60)
        {
            string path5 = string_25 + Module.a("\uF2AD\uEFAF\uE6B1\uEBB3螵袷誹費\uE1BD膿臁飃", int_0) + c.string_3 + Module.a("\uF1AD膯鲱\uD8B3펵\uDCB7", int_0);
            if (System.IO.File.Exists(path5))
                System.IO.File.Delete(path5);
            FileStream fileStream5 = new FileStream(path5, FileMode.Create, FileAccess.Write);
            BufferedStream bufferedStream5 = new BufferedStream((Stream)fileStream5);
            bufferedStream5.Write(buffer1, 0, 512);
            for (int index179 = 0; index179 < this.int_40; ++index179)
            {
                this.progressBar_0.Value = index179;
                this.bufferedStream_1.Seek((long)this.int_39 * (long)index179, SeekOrigin.Begin);
                this.bufferedStream_1.Read(this.byte_38, 0, this.int_39);
                for (uint index180 = 0; (long)index180 < (long)this.int_39; ++index180)
                    this.byte_37[index180] = (byte)((uint)this.byte_38[(index180 ^ (uint)this.byte_45)] - (uint)this.byte_44);
                int count18 = 0;
                int int_93_1 = 0;
                for (int int_94 = 0; int_94 < this.int_82; ++int_94)
                {
                    byte index181 = this.method_41(int_93_1, int_94, (int)numArray10[0]);
                    byte index182 = c.byte_21[(int)index181];
                    this.byte_40[count18] = this.byte_12[(int)index182];
                    int index183 = count18 + 1;
                    byte index184 = this.method_41(int_93_1, int_94, (int)numArray10[1]);
                    byte index185 = c.byte_22[(int)index184];
                    this.byte_40[index183] = this.byte_12[(int)index185];
                    int index186 = index183 + 1;
                    byte index187 = this.method_41(int_93_1, int_94, (int)numArray10[2]);
                    byte index188 = c.byte_23[(int)index187];
                    this.byte_40[index186] = this.byte_12[(int)index188];
                    count18 = index186 + 1;
                }
                int int_93_2 = 1;
                for (int int_94 = 0; int_94 < this.int_82; ++int_94)
                {
                    byte index189 = this.method_41(int_93_2, int_94, (int)numArray10[0]);
                    byte index190 = c.byte_21[(int)index189];
                    this.byte_40[count18] = this.byte_12[(int)index190];
                    int index191 = count18 + 1;
                    byte index192 = this.method_41(int_93_2, int_94, (int)numArray10[1]);
                    byte index193 = c.byte_22[(int)index192];
                    this.byte_40[index191] = this.byte_12[(int)index193];
                    int index194 = index191 + 1;
                    byte index195 = this.method_41(int_93_2, int_94, (int)numArray10[2]);
                    byte index196 = c.byte_23[(int)index195];
                    this.byte_40[index194] = this.byte_12[(int)index196];
                    count18 = index194 + 1;
                }
                for (uint index197 = 0; (long)index197 < (long)count18; ++index197)
                    this.byte_38[index197] = (byte)((uint)this.byte_40[(index197 ^ (uint)this.byte_43)] + (uint)this.byte_42);
                bufferedStream5.Write(this.byte_38, 0, count18);
            }
            for (int index = 0; index < 20; ++index)
                bufferedStream5.Write(this.byte_30, 0, 1024);
            bufferedStream5.Flush();
            bufferedStream5.Close();
            fileStream5.Close();
        }
        else
        {
            foreach (GClass8 gclass8 in this.arrayList_3)
            {
                int int_93 = gclass8.method_4();
                string path6 = string_25 + Module.a("\uF2AD\uEFAF\uE6B1\uEBB3螵袷誹費\uE1BD膿臁飃", int_0) + c.string_3 + Module.a("\uF1AD", int_0) + (gclass8.method_4() + 1).ToString() + Module.a("肭\uDCAFힱ킳", int_0);
                if (System.IO.File.Exists(path6))
                    System.IO.File.Delete(path6);
                FileStream fileStream6 = new FileStream(path6, FileMode.Create, FileAccess.Write);
                BufferedStream bufferedStream6 = new BufferedStream((Stream)fileStream6);
                bufferedStream6.Write(buffer1, 0, 512);
                for (int index198 = 0; index198 < this.int_40; ++index198)
                {
                    this.progressBar_0.Value = index198;
                    this.bufferedStream_1.Seek((long)this.int_39 * (long)index198, SeekOrigin.Begin);
                    this.bufferedStream_1.Read(this.byte_38, 0, this.int_39);
                    for (uint index199 = 0; (long)index199 < (long)this.int_39; ++index199)
                        this.byte_37[index199] = (byte)((uint)this.byte_38[(index199 ^ (uint)this.byte_45)] - (uint)this.byte_44);
                    int count19 = 0;
                    if (!c.bool_14)
                    {
                        for (int int_94 = 0; int_94 < this.int_82; ++int_94)
                        {
                            byte index200 = this.method_41(int_93, int_94, (int)numArray10[0]);
                            byte index201 = c.byte_21[(int)index200];
                            this.byte_40[count19] = this.byte_12[(int)index201];
                            int index202 = count19 + 1;
                            byte index203 = this.method_41(int_93, int_94, (int)numArray10[1]);
                            byte index204 = c.byte_22[(int)index203];
                            this.byte_40[index202] = this.byte_12[(int)index204];
                            int index205 = index202 + 1;
                            byte index206 = this.method_41(int_93, int_94, (int)numArray10[2]);
                            byte index207 = c.byte_23[(int)index206];
                            this.byte_40[index205] = this.byte_12[(int)index207];
                            count19 = index205 + 1;
                        }
                    }
                    else
                    {
                        int num103;
                        if (c.byte_19 == (byte)3)
                        {
                            int num104 = this.int_82 % 6;
                            num103 = num104 + 1;
                            count19 = num104 * 3;
                        }
                        else
                            num103 = 1;
                        for (int index208 = this.int_82 - num103; index208 >= 0; --index208)
                        {
                            int int_94;
                            switch (c.byte_19)
                            {
                                case 2:
                                    int_94 = index208 / 4 * 4 + (3 - index208 % 4);
                                    break;
                                case 3:
                                    int_94 = index208 / 6 * 6 + (5 - index208 % 6);
                                    break;
                                default:
                                    int_94 = index208;
                                    break;
                            }
                            byte index209 = this.method_41(int_93, int_94, (int)numArray10[0]);
                            byte index210 = c.byte_21[(int)index209];
                            this.byte_40[count19] = this.byte_12[(int)index210];
                            int index211 = count19 + 1;
                            byte index212 = this.method_41(int_93, int_94, (int)numArray10[1]);
                            byte index213 = c.byte_22[(int)index212];
                            this.byte_40[index211] = this.byte_12[(int)index213];
                            int index214 = index211 + 1;
                            byte index215 = this.method_41(int_93, int_94, (int)numArray10[2]);
                            byte index216 = c.byte_23[(int)index215];
                            this.byte_40[index214] = this.byte_12[(int)index216];
                            count19 = index214 + 1;
                        }
                    }
                    for (uint index217 = 0; (long)index217 < (long)count19; ++index217)
                        this.byte_38[index217] = (byte)((uint)this.byte_40[(index217 ^ (uint)this.byte_43)] + (uint)this.byte_42);
                    bufferedStream6.Write(this.byte_38, 0, count19);
                }
                for (int index = 0; index < 20; ++index)
                    bufferedStream6.Write(this.byte_30, 0, 1024);
                bufferedStream6.Flush();
                bufferedStream6.Close();
                fileStream6.Close();
            }
        }
        for (int index = 0; index < 20; ++index)
            bufferedStream1.Write(this.byte_30, 0, 1024);
        bufferedStream1.Flush();
        bufferedStream1.Close();
        fileStream1.Close();
        this.bufferedStream_1.Flush();
        this.bufferedStream_1.Close();
        this.fileStream_1.Close();
        this.method_26(6, Module.a("龭", int_0));
        if (c.int_2 == 81 || c.int_2 == 86 || c.int_2 == 82 || c.int_2 == 83 || c.int_2 == 84 || c.int_2 == 85)
        {
            this.fileStream_1 = new FileStream(string_25 + Module.a("\uF2AD肯花骳\uDAB5\uDDB7\uDEB9", int_0), FileMode.Open, FileAccess.Read);
            this.bufferedStream_1 = new BufferedStream((Stream)this.fileStream_1);
            this.bufferedStream_1.Seek(0L, SeekOrigin.Begin);
            this.bufferedStream_1.Read(buffer1, 0, 512);
            if (c.int_2 == 81)
                buffer1[15] = (byte)12;
            if (c.int_2 == 82)
                buffer1[15] = (byte)31;
            if (c.int_2 == 83)
                buffer1[15] = (byte)2;
            if (c.int_2 == 84)
            {
                buffer1[15] = (byte)8;
                count1 = c.int_75 * this.int_82 * 2;
            }
            if (c.int_2 == 85)
                buffer1[15] = (byte)46;
            if (c.int_2 == 86)
                buffer1[15] = (byte)54;
            int num105 = count1 * num1;
            if (Directory.Exists(string_25 + Module.a("\uF2AD\uEFAFﺱ\uF1B3\uF2B5", int_0)))
                Directory.Delete(string_25 + Module.a("\uF2AD\uEFAFﺱ\uF1B3\uF2B5", int_0), true);
            Directory.CreateDirectory(string_25 + Module.a("\uF2AD\uEFAFﺱ\uF1B3\uF2B5", int_0));
            for (int index218 = 0; index218 < num1; ++index218)
            {
                string path7 = string_25 + Module.a("\uF2AD\uEFAFﺱ\uF1B3\uF2B5", int_0) + (object)'\\' + c.string_3 + Module.a("\uF1AD", int_0) + (index218 + 1).ToString() + Module.a("肭\uDCAFힱ킳", int_0);
                if (System.IO.File.Exists(path7))
                    System.IO.File.Delete(path7);
                FileStream fileStream7 = new FileStream(path7, FileMode.Create, FileAccess.Write);
                BufferedStream bufferedStream7 = new BufferedStream((Stream)fileStream7);
                bufferedStream7.Write(buffer1, 0, 512);
                for (int index219 = 0; index219 < this.int_40; ++index219)
                {
                    this.bufferedStream_1.Seek((long)index219 * (long)num105 + (long)index218 * (long)count1 + 512L, SeekOrigin.Begin);
                    this.bufferedStream_1.Read(this.byte_38, 0, count1);
                    bufferedStream7.Write(this.byte_38, 0, count1);
                }
                for (int index220 = 0; index220 < 20; ++index220)
                    bufferedStream7.Write(this.byte_30, 0, 1024);
                bufferedStream7.Flush();
                bufferedStream7.Close();
                fileStream7.Close();
            }
            this.bufferedStream_1.Flush();
            this.bufferedStream_1.Close();
            this.fileStream_1.Close();
        }
        this.progressBar_0.Visible = false;
        this.progressBar_0.Enabled = false;
    }

    private byte method_41(int int_93, int int_94, int int_95) => this.byte_37[(int_93 * this.int_82 + int_94) * 3 + int_95];

    private void toolStripButton_0_Click(object sender, EventArgs e) => this.menuItem_13_Click(sender, e);

    private void toolStripButton_5_Click(object sender, EventArgs e) => this.menuItem_12_Click(sender, e);

    private void toolStripButton_7_Click(object sender, EventArgs e) => this.menuItem_15_Click(sender, e);

    private void toolStripButton_1_Click(object sender, EventArgs e) => this.menuItem_8_Click(sender, e);

    private void toolStripButton_2_Click(object sender, EventArgs e) => this.menuItem_9_Click(sender, e);

    private void method_42(object sender, EventArgs e) => this.menuItem_113_Click(sender, e);

    private void toolStripButton_4_Click(object sender, EventArgs e) => this.menuItem_3_Click(sender, e);

    private void toolStripButton_3_Click(object sender, EventArgs e) => this.menuItem_20_Click(sender, e);

    private void menuItem_17_Click(object sender, EventArgs e)
    {
        int int_0 = 11;
        string path = this.string_20 + (object)'\\' + this.string_22 + Module.a("\uEEB0\uE1B2킴횶\uDDB8\uF6BA\uD8BC醾뗀믂뇄", 11);
        int num1 = this.int_23 / c.int_75;
        int num2;
        switch (c.int_2)
        {
            case 3:
            case 5:
            case 101:
                int num3 = c.int_8 + c.int_9 + c.int_10 + 3;
                num2 = (768 - (int)c.byte_0) / num3;
                break;
            case 9:
                num2 = 2048;
                break;
            case 13:
                num2 = 2048;
                break;
            case 32:
                num2 = 2048;
                if (c.byte_20 > (byte)60)
                {
                    num2 = 1024;
                    break;
                }
                break;
            case 52:
                num2 = 2048;
                break;
            case 103:
                int num4 = c.int_8 + c.int_9 + c.int_10 + 3;
                num2 = (1536 - (int)c.byte_0) / num4;
                break;
            default:
                num2 = this.int_82;
                break;
        }
        if (System.IO.File.Exists(path))
            System.IO.File.Delete(path);
        try
        {
            using (StreamWriter streamWriter = new StreamWriter(path, false, Encoding.Unicode))
            {
                if (c.useEnglishLanguage)
                {
                    streamWriter.WriteLine(Module.a("醰鎲閴鞶馸鮺鶼龾\uE1C0\uE3C2\uE5C4\uE7C6\uE9C8\uEBCA\uEDCC\uEFCE\uF1D0\uF3D2\uF5D4\uF7D6律ﯚ\uFDDC\uFFDE쇠쏢엤쟦짨믪\u9FEC胮鯰雲雴菶퇸", int_0) + this.string_22 + Module.a("龰쎲춴햶邸\uF7BA\uDCBC욾껀뛂뇄\uE7C6胈ꗊ뻌믎ꏐꛒ뛔ꏖ냘듚돜\uE5DE", int_0));
                    streamWriter.WriteLine("");
                    streamWriter.WriteLine(this.toolStripTextBox_3.Text);
                    switch (c.byte_19)
                    {
                        case 85:
                            streamWriter.WriteLine(Module.a("\uE2B0\uDFB2\uDAB4삶馸좺춼\uDABE꓀\uA7C2", int_0));
                            streamWriter.WriteLine("");
                            break;
                        case 170:
                            streamWriter.WriteLine(Module.a("聆\uDAB2튴\uDFB6馸좺춼\uDABE꓀\uA7C2", int_0));
                            streamWriter.WriteLine("");
                            break;
                        default:
                            streamWriter.WriteLine("");
                            break;
                    }
                    streamWriter.WriteLine(Module.a("\uDCB0튲춴鞶ힸ캺킼\uDDBE꓀뇂\uE5C4\uA8C6꿈\uEBCAꇌꛎ뛐믒ꇔꓖ律뷚닜귞쇠蛢蓤蓦臨쯪鷬胮菰蟲쿴", int_0) + num2.ToString());
                    streamWriter.WriteLine("");
                    if (c.int_2 != 13 && c.int_2 != 32 && c.int_2 != 47 && c.int_2 != 52 && c.int_2 != 9 && c.int_2 != 16)
                        streamWriter.WriteLine(Module.a("\uE5B0\uDBB2\uDCB4쒶馸\uEBBA쾼킾ꯀꛂꛄ돆\uE9C8뻊뻌\uAACEꋐ\uF3D2", int_0) + num1.ToString() + Module.a("튰\uDCB2\uDBB4쎶쮸풺톼펾꓀뇂뛄\uEBC6鷈ꏊ\uA8CC\uEFCE鷐닒곔룖곘꿚\uFDDC냞蟠쏢釤迦賨쯪鷬胮菰蟲蛴ퟶ飸裺\uDDFC駾渀漂椄栆縈砊㜌", int_0));
                    int num5 = 0;
                    for (int index = 0; index < this.arrayList_3.Count; ++index)
                    {
                        if (((GClass8)this.arrayList_3[index]).method_4() > num5)
                            num5 = ((GClass8)this.arrayList_3[index]).method_4();
                    }
                    int num6 = num5 + 1;
                    if (num6 > this.arrayList_3.Count)
                        streamWriter.WriteLine(Module.a("\uE5B0\uDBB2킴鞶캸튺쾼\uDABE닀\uE3C2뛄꿆ꛈ뻊ꇌꯎ\uF1D0뇒냔\uF7D6뫘듚돜뇞蓠胢釤苦跨쯪賬賮鋰鳲蟴鏶郸闺髼\uDFFE甀氂┄猆愈渊ⴌ簎琐戒怔爖眘砚砜㼞丠䔢Ԥ圦ᠨܪബ弮̰ᴲ᬴ᤶ䤸唺ᴼ䬾⹀捂㙄♆㽈\u2E4A浌㭎㥐㙒畔\u2456⥘㩚㹜㩞你", int_0));
                    int index1 = 0;
                    for (int index2 = 1; index2 <= num1; ++index2)
                    {
                        streamWriter.WriteLine("");
                        if (c.int_2 != 13 && c.int_2 != 32 && c.int_2 != 47 && c.int_2 != 52 && c.int_2 != 9 && c.int_2 != 16)
                            streamWriter.WriteLine(Module.a("\uF2B0\uDCB2\uDBB4쎶쮸풺톼펾꓀뇂\uE5C4视ꛈ\uE5CA", int_0) + index2.ToString());
                        for (int index3 = 1; index3 <= 8; ++index3)
                        {
                            int num7 = (index2 - 1) * c.int_75 + index3;
                            if (num7 <= num6)
                            {
                                bool flag = false;
                                for (int index4 = 0; index4 < this.arrayList_3.Count; ++index4)
                                {
                                    if (((GClass8)this.arrayList_3[index4]).method_4() == num7 - 1)
                                    {
                                        flag = true;
                                        index1 = index4;
                                        break;
                                    }
                                }
                                if (flag)
                                {
                                    if (c.int_2 != 13 && c.int_2 != 32 && c.int_2 != 47 && c.int_2 != 52 && c.int_2 != 9 && c.int_2 != 16)
                                        streamWriter.WriteLine(Module.a("醰鎲閴鞶馸\uEBBA튼춾뗀", int_0) + index3.ToString() + Module.a("记鎲颴骶钸隺邼銾\uECC0\uEEC2\uE8C4\uEAC6\uE4C8\uE6CA鷌ꃎꏐ\uA7D2\uF5D4\uA7D6", int_0) + num7.ToString() + Module.a("醰\uDAB2\uDBB4鞶\uDDB8쎺\uDBBC邾ꋀ믂\uA7C4쟶蟈뻊ꃌ귎듐ꇒ\uF5D4룖뿘ﯚ뇜뛞蛠询釤铦짨裪苬臮\u9FF0雲雴菶鳸\u9FFA\uDDFC课渀⌂焄漆怈砊ⴌ缎縐愒愔ⴖ", int_0) + ((GClass8)this.arrayList_3[index1]).method_0().ToString());
                                    else if (c.int_2 == 32 && c.byte_20 > (byte)60)
                                        streamWriter.WriteLine(Module.a("醰鎲閴鞶馸\uEBBA튼춾뗀", int_0) + index3.ToString() + Module.a("记鎲颴骶钸隺邼銾\uECC0\uEEC2\uE8C4\uEAC6\uE4C8\uE6CA鷌ꃎꏐ\uA7D2\uF5D4\uA7D6", int_0) + num7.ToString() + Module.a("醰\uDAB2\uDBB4鞶\uDDB8쎺\uDBBC邾ꋀ믂\uA7C4쟶蟈뻊ꃌ귎듐ꇒ\uF5D4룖뿘ﯚ뇜뛞蛠询釤铦짨裪苬臮\u9FF0雲雴菶鳸\u9FFA\uDDFC课渀⌂焄漆怈砊ⴌ缎縐愒愔ⴖ", int_0) + ((GClass8)this.arrayList_3[index1]).method_0().ToString());
                                    else
                                        streamWriter.WriteLine(Module.a("\uF2B0\uDCB2\uDBB4쎶쮸풺톼펾꓀뇂\uE5C4视ꛈ\uE5CA", int_0) + num7.ToString() + Module.a("记鎲颴骶钸隺邼銾\uECC0\uEEC2\uE8C4\uEAC6\uE4C8\uE6CA鷌ꃎꏐ\uA7D2\uF5D4\uA7D6", int_0) + num7.ToString() + Module.a("醰\uDAB2\uDBB4鞶\uDDB8쎺\uDBBC邾ꋀ믂\uA7C4쟶蟈뻊ꃌ귎듐ꇒ\uF5D4룖뿘ﯚ뇜뛞蛠询釤铦짨裪苬臮\u9FF0雲雴菶鳸\u9FFA\uDDFC课渀⌂焄漆怈砊ⴌ缎縐愒愔ⴖ", int_0) + ((GClass8)this.arrayList_3[index1]).method_0().ToString());
                                }
                                else
                                    streamWriter.WriteLine(Module.a("醰鎲閴鞶馸\uEBBA튼춾뗀", int_0) + index3.ToString() + Module.a("记鎲颴骶钸隺邼銾\uECC0\uEEC2\uE8C4\uEAC6\uE4C8\uE6CA菌ꃎ뿐뛒", int_0));
                            }
                            else
                                break;
                        }
                    }
                    streamWriter.WriteLine("");
                    streamWriter.WriteLine(Module.a("醰鎲\uE1B4\uD8B6춸\uDABA톼龾꿀뛂꣄ꗆ곈맊\uEDCCꃎ럐\uF3D2맔뻖뻘돚\uA9DC곞쇠離雤苦跨퇪", int_0) + this.int_41.ToString());
                    streamWriter.WriteLine(Module.a("醰鎲\uF3B4\uD8B6쮸鮺즼ힾ꓀\uE3C2뛄럆곈\uA8CA\uA4CC\uA9CE룐냒\uF5D4믖룘ꋚ닜꫞闠쿢엤韦藨軪賬鳮铰폲蟴鋶\u9FF8黺迼\uDFFE甀氂┄挆焈洊∌氎椐焒㔔焖瀘眚砜氞ᬠ̢", int_0) + this.method_29(3));
                }
                else
                {
                    streamWriter.WriteLine(Module.a("醰鎲閴鞶馸鮺鶼龾\uE1C0\uE3C2\uE5C4\uE7C6\uE9C8\uEBCA\uEDCC\uEFCE\uF1D0\uF3D2\uF5D4\uF7D6律ﯚ\uFDDC\uFFDE쇠쏢엤쟦짨ື\uE696쟮", int_0) + this.string_22 + Module.a("龰쎲춴햶邸۟壡룝隓蓼", int_0));
                    streamWriter.WriteLine("");
                    streamWriter.WriteLine(this.toolStripTextBox_3.Text);
                    switch (c.byte_19)
                    {
                        case 85:
                            streamWriter.WriteLine(Module.a("\uFFFF갢铞룩", int_0));
                            streamWriter.WriteLine("");
                            break;
                        case 170:
                            streamWriter.WriteLine(Module.a("椪갢铞룩", int_0));
                            streamWriter.WriteLine("");
                            break;
                        default:
                            streamWriter.WriteLine("");
                            break;
                    }
                    streamWriter.WriteLine(Module.a("绛駼嫎哥囫᳄\uE93C㯈솧\uD99Bꪴ랣\uF386\uF1CA", int_0) + num2.ToString());
                    streamWriter.WriteLine("");
                    if (c.int_2 != 13 && c.int_2 != 32 && c.int_2 != 47 && c.int_2 != 52 && c.int_2 != 9 && c.int_2 != 16)
                        streamWriter.WriteLine(Module.a("鷗囯뻎웧웷鏏㯲龾", int_0) + num1.ToString() + Module.a("鯾ᓑ菦\uDFE0閸᳙诮ퟨ䖶Ⲹ⚗솔葙䦓욂\uF5CE", int_0));
                    int num8 = 0;
                    for (int index = 0; index < this.arrayList_3.Count; ++index)
                    {
                        if (((GClass8)this.arrayList_3[index]).method_4() > num8)
                            num8 = ((GClass8)this.arrayList_3[index]).method_4();
                    }
                    int num9 = num8 + 1;
                    if (num9 > this.arrayList_3.Count)
                        streamWriter.WriteLine(Module.a("醰寞뫕趶丳닙춼躾\uEDC0\uE3C2뗄\uF5C6\uE7C8\uE5CA\uE3CC뿎뿐ꥊ媊품暦휥ﮈ욌ﮯ規\uDC69뾽䆸醐\u1979\uEE11", int_0));
                    int index5 = 0;
                    for (int index6 = 1; index6 <= num1; ++index6)
                    {
                        streamWriter.WriteLine("");
                        if (c.int_2 != 13 && c.int_2 != 32 && c.int_2 != 47 && c.int_2 != 52 && c.int_2 != 9 && c.int_2 != 16)
                            streamWriter.WriteLine(Module.a("鷋", int_0) + index6.ToString() + Module.a("䛣ᓑ菦\uDFE0莸", int_0));
                        for (int index7 = 1; index7 <= 8; ++index7)
                        {
                            int num10 = (index6 - 1) * c.int_75 + index7;
                            if (num10 <= num9)
                            {
                                bool flag = false;
                                for (int index8 = 0; index8 < this.arrayList_3.Count; ++index8)
                                {
                                    if (((GClass8)this.arrayList_3[index8]).method_4() == num10 - 1)
                                    {
                                        flag = true;
                                        index5 = index8;
                                        break;
                                    }
                                }
                                if (flag)
                                {
                                    if (c.int_2 != 13 && c.int_2 != 32 && c.int_2 != 47 && c.int_2 != 52 && c.int_2 != 9 && c.int_2 != 16)
                                        streamWriter.WriteLine(Module.a("醰鎲閴鞶馸哀廯", int_0) + index7.ToString() + Module.a("记鎲颴骶钸隺邼銾\uECC0\uEEC2\uE8C4\uEAC6\uE4C8\uE6CA꧌럎럐ﳒ뛔꿖믘\uF694\uFDDC꿞", int_0) + num10.ToString() + Module.a("醰䓡嫎哥릈뮊붌\uDBD5⺺ₑᭋ报\u4DBE꒺붩_ﺶ\uE9D2", int_0) + ((GClass8)this.arrayList_3[index5]).method_0().ToString());
                                    else if (c.int_2 == 32 && c.byte_20 > (byte)60)
                                        streamWriter.WriteLine(Module.a("醰鎲閴鞶馸哀廯", int_0) + index7.ToString() + Module.a("记鎲颴骶钸隺邼銾\uECC0\uEEC2\uE8C4\uEAC6\uE4C8\uE6CA꧌럎럐ﳒ뛔꿖믘\uF694\uFDDC꿞", int_0) + num10.ToString() + Module.a("醰䓡嫎哥릈뮊붌\uDBD5⺺ₑᭋ报\u4DBE꒺붩_ﺶ\uE9D2", int_0) + ((GClass8)this.arrayList_3[index5]).method_0().ToString());
                                    else
                                        streamWriter.WriteLine(Module.a("醰鎲閴鞶馸韁", int_0) + num10.ToString() + Module.a("醰䓡\u12D7臤퇮膺鶼銾\uECC0\uEEC2\uE8C4\uEAC6\uE4C8\uE6CA\uE0CC\uE2CEﳐﻒ\uF8D4돖ꇘ뷚\uF2DC볞駠臢좪쟦駨", int_0) + num10.ToString() + Module.a("醰䓡嫎哥릈뮊붌\uDBD5⺺ₑᭋ报\u4DBE꒺붩_ﺶ\uE9D2", int_0) + ((GClass8)this.arrayList_3[index5]).method_0().ToString());
                                }
                                else
                                    streamWriter.WriteLine(Module.a("醰鎲閴鞶馸哀廯", int_0) + index7.ToString() + Module.a("记鎲颴骶钸隺邼銾\uECC0\uEEC2\uE8C4\uEAC6\uE4C8\uE6CA꧌럎럐ﳒ뛔꿖믘\uF694\uFDDC纲\uE887螉ઞҵ", int_0));
                            }
                            else
                                break;
                        }
                    }
                    streamWriter.WriteLine("");
                    streamWriter.WriteLine(Module.a("醰鎲駓勫닂쓵闉탎䖶뎧\u0A55\uE8A0\uF3C8", int_0) + this.int_41.ToString());
                    streamWriter.WriteLine(Module.a("醰鎲싥\uE4F9뫦ﯦ䏪䠵Γ쁂ꇄ뿆꿈\uE4CA껌럎돐咷⎚\uEDD6律", int_0) + this.method_29(3));
                }
            }
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = Module.a("\uDFB0\uDCB2솴튶즸\uDABA\uD9BC醾꓀믂ꃄ", int_0);
            startInfo.Arguments = path;
            try
            {
                Process.Start(startInfo);
            }
            catch (Win32Exception ex)
            {
                this.ShowMessage(ex.Message);
            }
        }
        catch
        {
        }
    }

    private void toolStripButton_6_Click(object sender, EventArgs e) => this.menuItem_17_Click(sender, e);

    private void menuItem_19_Click(object sender, EventArgs e)
    {
        int num = c.smethod_0();
        if (new b().ShowDialog() == DialogResult.OK)
            this.toolStripTextBox_1.Text = c.smethod_0().ToString();
        if (num == c.smethod_0())
            return;
        this.method_26(12, c.smethod_0().ToString());
        if (!this.bool_37)
            return;
        this.timer_1.Interval = 1000 / c.smethod_0();
    }

    private void menuItem_20_Click(object sender, EventArgs e)
    {
        this.bool_37 = true;
        this.timer_1.Interval = 1000 / c.smethod_0();
        this.timer_1.Enabled = true;
        string path = this.string_20 + (object)'\\' + ((GClass5)c.arrayList_4[c.int_38]).string_3;
        ((GClass5)c.arrayList_4[c.int_38]).bool_3 = false;
        this.fileStream_1 = new FileStream(path, FileMode.Append, FileAccess.Write);
        this.bufferedStream_1 = new BufferedStream((Stream)this.fileStream_1);
        this.bool_38 = true;
        this.genum1_1 = GEnum1.const_5;
        this.method_31();
        this.method_26(6, Module.a("龮", 9));
    }

    private void menuItem_21_Click(object sender, EventArgs e)
    {
        int int_0 = 6;
        this.bool_19 = false;
        this.bool_57 = false;
        this.d_0.axShockwaveFlash_0.GotoFrame(0);
        if (this.bool_19)
            this.d_0.axShockwaveFlash_0.Play();
        if (this.bool_13)
            this.int_15 = 0;
        this.menuItem_20_Click(sender, e);
        this.method_26(6, Module.a("鲫", int_0));
    }

    private void toolStripButton_12_Click(object sender, EventArgs e) => this.menuItem_5_Click(sender, e);

    private void toolStripButton_13_Click(object sender, EventArgs e) => this.menuItem_6_Click(sender, e);

    private void toolStripButton_14_Click(object sender, EventArgs e)
    {
        if (this.menuItem_34.Enabled)
            this.menuItem_34_Click(sender, e);
        if (!this.menuItem_37.Enabled)
            return;
        this.menuItem_37_Click(sender, e);
        this.menuItem_7_Click(sender, e);
    }

    private void trackBar_0_Scroll(object sender, EventArgs e)
    {
        if (this.bool_47)
            this.bool_47 = false;
        this.int_55 = this.trackBar_0.Value;
        if (this.int_55 > 0)
            --this.int_55;
        else
            this.int_55 = this.int_40 - 1;
        this.method_18();
        if (this.bool_27)
            return;
        this.textBox_0.SelectionStart = this.trackBar_0.Value;
        this.textBox_0.ScrollToCaret();
    }

    private void menuItem_29_Click(object sender, EventArgs e)
    {
        c.gclass1_0 = new GClass1((Control)this.panel_0);
        Rectangle rectangle_2 = new Rectangle(0, 0, this.panel_0.Width, this.panel_0.Height);
        Rectangle rectangle_3 = new Rectangle(0, 0, this.panel_0.Width, this.panel_0.Height);
        this.gclass0_2 = new GClass0(c.gclass1_0.method_1(), rectangle_2, rectangle_3);
        this.gclass0_2.method_12().ColorFill(Color.FromArgb(0, 0, 0));
        this.method_15();
        this.genum1_1 = GEnum1.const_0;
        this.method_31();
        this.toolStripTextBox_3.Text = "";
    }

    private void menuItem_25_Click(object sender, EventArgs e)
    {
        this.menuItem_26.Enabled = true;
        this.menuItem_27.Enabled = true;
        this.menuItem_28.Enabled = true;
        this.menuItem_25.Enabled = false;
        this.toolStripButton_15.Enabled = this.menuItem_25.Enabled;
        this.toolStripButton_18.Enabled = this.menuItem_28.Enabled;
        this.toolStripButton_16.Enabled = this.menuItem_26.Enabled;
        this.toolStripButton_17.Enabled = this.menuItem_27.Enabled;
        this.toolStripMenuItem_0.Enabled = this.bool_41;
        this.toolStripMenuItem_1.Enabled = this.bool_42;
        this.toolStripMenuItem_2.Enabled = this.bool_43;
        this.toolStripMenuItem_3.Enabled = this.bool_44;
        this.toolStripMenuItem_4.Enabled = this.bool_45;
        this.bool_37 = false;
        this.timer_1.Interval = 1000 / c.smethod_0();
        this.timer_1.Enabled = false;
    }

    private void menuItem_28_Click(object sender, EventArgs e)
    {
        this.menuItem_26.Enabled = false;
        this.menuItem_27.Enabled = false;
        this.menuItem_28.Enabled = false;
        this.menuItem_25.Enabled = true;
        this.toolStripButton_15.Enabled = this.menuItem_25.Enabled;
        this.toolStripButton_18.Enabled = this.menuItem_28.Enabled;
        this.toolStripButton_16.Enabled = this.menuItem_26.Enabled;
        this.toolStripButton_17.Enabled = this.menuItem_27.Enabled;
        this.bool_41 = this.toolStripMenuItem_0.Enabled;
        this.bool_42 = this.toolStripMenuItem_1.Enabled;
        this.bool_43 = this.toolStripMenuItem_2.Enabled;
        this.bool_44 = this.toolStripMenuItem_3.Enabled;
        this.bool_45 = this.toolStripMenuItem_4.Enabled;
        this.toolStripMenuItem_0.Enabled = false;
        this.toolStripMenuItem_1.Enabled = false;
        this.toolStripMenuItem_2.Enabled = false;
        this.toolStripMenuItem_3.Enabled = false;
        this.toolStripMenuItem_4.Enabled = false;
        if (this.bool_47)
            this.bool_47 = false;
        this.bool_37 = true;
        this.timer_1.Interval = 1000 / c.smethod_0();
        this.timer_1.Enabled = true;
    }

    private void menuItem_26_Click(object sender, EventArgs e)
    {
        if (this.bool_47)
            this.bool_47 = false;
        if (this.int_55 > 0)
            --this.int_55;
        else
            this.int_55 = this.int_40 - 1;
        if (this.int_55 > 0)
            --this.int_55;
        else
            this.int_55 = this.int_40 - 1;
        this.method_18();
    }

    private void menuItem_27_Click(object sender, EventArgs e)
    {
        if (this.bool_47)
            this.bool_47 = false;
        this.method_18();
    }

    private void toolStripButton_15_Click(object sender, EventArgs e) => this.menuItem_25_Click(sender, e);

    private void toolStripButton_18_Click(object sender, EventArgs e) => this.menuItem_28_Click(sender, e);

    private void toolStripButton_16_Click(object sender, EventArgs e) => this.menuItem_26_Click(sender, e);

    private void toolStripButton_17_Click(object sender, EventArgs e) => this.menuItem_27_Click(sender, e);

    private void toolStripButton_8_Click(object sender, EventArgs e) => this.menuItem_19_Click(sender, e);

    private void toolStripButton_9_Click(object sender, EventArgs e) => this.menuItem_14_Click(sender, e);

    private void method_43(object sender, EventArgs e) => this.method_24(sender, e);

    private void method_44(object sender, EventArgs e) => this.method_23(sender, e);

    private void toolStripButton_10_Click(object sender, EventArgs e) => this.menuItem_1_Click(sender, e);

    private void toolStripButton_11_Click(object sender, EventArgs e) => this.menuItem_7_Click(sender, e);

    private void method_45(object sender, EventArgs e) => this.menuItem_20_Click(sender, e);

    private void method_46(object sender, EventArgs e) => this.menuItem_21_Click(sender, e);

    private void menuItem_18_Click(object sender, EventArgs e)
    {
        int num = (int)new q().ShowDialog();
    }

    private void textBox_0_MouseDown(object sender, MouseEventArgs e)
    {
        this.menuItem_25_Click(sender, (EventArgs)e);
        int num1 = 0;
        if (e.Button != MouseButtons.Left)
            return;
        this.bool_48 = true;
        if (this.bool_47)
        {
            this.bool_47 = false;
            this.toolStripMenuItem_0.Enabled = false;
            this.toolStripMenuItem_1.Enabled = false;
            this.toolStripMenuItem_3.Enabled = false;
        }
        if (this.bool_37)
            return;
        int num2 = this.textBox_0.SelectionStart;
        if (num2 > this.int_40 - 1)
        {
            num1 = this.int_40;
            num2 = this.int_40 - 1;
        }
        this.int_55 = num2 <= 0 ? this.int_40 - 1 : num2 - 1;
        this.method_18();
        if (num1 == 0)
            return;
        this.textBox_0.SelectionStart = num1;
    }

    private void textBox_0_KeyDown(object sender, KeyEventArgs e)
    {
    }

    private void textBox_0_MouseUp(object sender, MouseEventArgs e)
    {
        this.bool_48 = false;
        if (this.bool_37)
            return;
        int selectionLength = this.textBox_0.SelectionLength;
        int selectionStart = this.textBox_0.SelectionStart;
        if (selectionLength <= 0)
            return;
        this.bool_47 = true;
        this.toolStripMenuItem_0.Enabled = true;
        this.toolStripMenuItem_1.Enabled = true;
        this.toolStripMenuItem_3.Enabled = true;
        this.int_46 = new int[selectionLength];
        for (int index = 0; index < selectionLength; ++index)
            this.int_46[index] = this.int_45[selectionStart + index];
    }

    private void textBox_0_MouseMove(object sender, MouseEventArgs e)
    {
        if (!this.bool_48 || this.bool_37)
            return;
        if (this.textBox_0.SelectionLength > 0)
            this.bool_47 = true;
        if (this.int_54 == this.textBox_0.SelectionLength)
            return;
        if (this.int_53 != this.textBox_0.SelectionStart)
        {
            this.int_55 = this.textBox_0.SelectionStart;
            this.int_53 = this.textBox_0.SelectionStart;
        }
        else
            this.int_55 = this.textBox_0.SelectionStart + this.textBox_0.SelectionLength - 1;
        this.int_54 = this.textBox_0.SelectionLength;
        if (this.int_55 > 0)
            --this.int_55;
        else
            this.int_55 = this.int_40 - 1;
        this.method_18();
    }

    private void method_47()
    {
        int int_0 = 4;
        int selectionLength = this.textBox_0.SelectionLength;
        int selectionStart = this.textBox_0.SelectionStart;
        if (selectionLength == this.textBox_0.TextLength)
        {
            if (c.useEnglishLanguage)
                this.ShowMessage(Module.a("ﾩ슫쾭튯\uDEB1톳隵첷햹鲻\uDDBD떿뛁\uE9C3\uA7C5ꛇ껉\uE1CB뻍뇏ꇑꃓ돕\uF8D7믙냛닝샟雡賣菥죧賩黫迭鷯韱蟳ퟵ", int_0));
            else
                this.ShowMessage(Module.a("\uA7E7儫쓿萢\uF2D3뷔釫륈", int_0));
        }
        else
        {
            this.int_49 = new int[this.int_45.Length];
            for (int index = 0; index < this.int_45.Length; ++index)
                this.int_49[index] = this.int_45[index];
            this.toolStripMenuItem_4.Enabled = true;
            this.menuItem_102.Enabled = true;
            this.bool_46 = true;
            this.menuItem_31.Enabled = true;
            this.Text = this.string_8 + Module.a("\uF1A9膫莭", int_0) + this.string_22 + (object)']' + Module.a("誩蚫", int_0);
            this.int_48 = new int[selectionLength];
            for (int index = 0; index < selectionLength; ++index)
                this.int_48[index] = this.int_45[selectionStart + index];
            this.toolStripMenuItem_2.Enabled = true;
            this.menuItem_100.Enabled = true;
            this.int_47 = new int[this.int_50];
            int index1 = 0;
            for (int index2 = 0; index2 < selectionStart; ++index2)
            {
                this.int_47[index1] = this.int_45[index2];
                ++index1;
            }
            for (int index3 = selectionLength + selectionStart; index3 < this.int_50; ++index3)
            {
                this.int_47[index1] = this.int_45[index3];
                ++index1;
            }
            this.int_50 = index1;
            this.int_45 = new int[this.int_50];
            for (int index4 = 0; index4 < this.int_50; ++index4)
                this.int_45[index4] = this.int_47[index4];
            this.int_55 = selectionStart;
            this.int_40 = this.int_50;
            this.trackBar_0.Minimum = 0;
            this.trackBar_0.Maximum = this.int_40 - 1;
            this.textBox_0.Text = "";
            for (int index5 = 0; index5 < this.int_40; ++index5)
                this.textBox_0.Text += (string)(object)'■';
            this.textBox_0.SelectionStart = selectionStart;
            this.toolStripTextBox_0.Text = (this.int_55 + 1).ToString() + (object)'/' + this.int_40.ToString();
            if (!this.bool_47)
                return;
            this.bool_47 = false;
            this.toolStripMenuItem_0.Enabled = false;
            this.toolStripMenuItem_1.Enabled = false;
            this.toolStripMenuItem_3.Enabled = false;
        }
    }

    private void toolStripMenuItem_0_Click(object sender, EventArgs e) => this.method_47();

    private void method_48()
    {
        int int_0 = 15;
        int selectionStart = this.textBox_0.SelectionStart;
        int length = this.int_48.Length;
        this.int_49 = new int[this.int_45.Length];
        for (int index = 0; index < this.int_45.Length; ++index)
            this.int_49[index] = this.int_45[index];
        this.toolStripMenuItem_4.Enabled = true;
        this.menuItem_102.Enabled = true;
        this.bool_46 = true;
        this.menuItem_31.Enabled = true;
        this.Text = this.string_8 + Module.a("\uEEB4骶钸", int_0) + this.string_22 + (object)']' + Module.a("閴鶶", int_0);
        this.int_47 = new int[this.int_50 + length];
        int index1 = 0;
        for (int index2 = 0; index2 < selectionStart; ++index2)
        {
            this.int_47[index1] = this.int_45[index2];
            ++index1;
        }
        for (int index3 = 0; index3 < length; ++index3)
        {
            this.int_47[index1] = this.int_48[index3];
            ++index1;
        }
        for (int index4 = selectionStart; index4 < this.int_50; ++index4)
        {
            this.int_47[index1] = this.int_45[index4];
            ++index1;
        }
        this.int_50 = index1;
        this.int_45 = new int[this.int_50];
        for (int index5 = 0; index5 < this.int_50; ++index5)
            this.int_45[index5] = this.int_47[index5];
        this.int_55 = selectionStart;
        this.int_40 = this.int_50;
        this.trackBar_0.Minimum = 0;
        this.trackBar_0.Maximum = this.int_40 - 1;
        this.textBox_0.Text = "";
        for (int index6 = 0; index6 < this.int_40; ++index6)
            this.textBox_0.Text += (string)(object)'■';
        this.textBox_0.SelectionStart = selectionStart;
        this.toolStripTextBox_0.Text = (this.int_55 + 1).ToString() + (object)'/' + this.int_40.ToString();
        if (!this.bool_47)
            return;
        this.bool_47 = false;
        this.toolStripMenuItem_0.Enabled = false;
        this.toolStripMenuItem_1.Enabled = false;
        this.toolStripMenuItem_3.Enabled = false;
    }

    private void toolStripMenuItem_2_Click(object sender, EventArgs e)
    {
        if (this.bool_47)
            this.method_50();
        this.method_48();
    }

    private void method_49()
    {
        int selectionLength = this.textBox_0.SelectionLength;
        int selectionStart = this.textBox_0.SelectionStart;
        this.int_48 = new int[selectionLength];
        for (int index = 0; index < selectionLength; ++index)
            this.int_48[index] = this.int_45[selectionStart + index];
        this.toolStripMenuItem_2.Enabled = true;
        this.menuItem_100.Enabled = true;
    }

    private void toolStripMenuItem_1_Click(object sender, EventArgs e) => this.method_49();

    private void method_50()
    {
        int int_0 = 3;
        int selectionLength = this.textBox_0.SelectionLength;
        int selectionStart = this.textBox_0.SelectionStart;
        if (selectionLength == this.textBox_0.TextLength)
        {
            if (c.useEnglishLanguage)
                this.ShowMessage(Module.a("ﲨ얪첬춮\uDDB0횲閴쎶횸鮺\uD9BC\uDABE귀ꛂ뇄ꋆ\uE9C8\uAACAꇌꏎ\uF1D0\uA7D2뷔닖律뷚꿜뻞賠蛢雤웦", int_0));
            else
                this.ShowMessage(Module.a("ꓦ嘪跾쬸\uF1D2뫕鋪뙉", int_0));
        }
        else
        {
            this.int_49 = new int[this.int_45.Length];
            for (int index = 0; index < this.int_45.Length; ++index)
                this.int_49[index] = this.int_45[index];
            this.toolStripMenuItem_4.Enabled = true;
            this.menuItem_102.Enabled = true;
            this.bool_46 = true;
            this.menuItem_31.Enabled = true;
            this.Text = this.string_8 + Module.a("\uF2A8蚪肬", int_0) + this.string_22 + (object)']' + Module.a("覨膪", int_0);
            this.int_47 = new int[this.int_50];
            int index1 = 0;
            for (int index2 = 0; index2 < selectionStart; ++index2)
            {
                this.int_47[index1] = this.int_45[index2];
                ++index1;
            }
            for (int index3 = selectionLength + selectionStart; index3 < this.int_50; ++index3)
            {
                this.int_47[index1] = this.int_45[index3];
                ++index1;
            }
            this.int_50 = index1;
            this.int_45 = new int[this.int_50];
            for (int index4 = 0; index4 < this.int_50; ++index4)
                this.int_45[index4] = this.int_47[index4];
            this.int_55 = selectionStart;
            this.int_40 = this.int_50;
            this.trackBar_0.Minimum = 0;
            this.trackBar_0.Maximum = this.int_40 - 1;
            this.textBox_0.Text = "";
            for (int index5 = 0; index5 < this.int_40; ++index5)
                this.textBox_0.Text += (string)(object)'■';
            this.textBox_0.SelectionStart = selectionStart;
            this.toolStripTextBox_0.Text = (this.int_55 + 1).ToString() + (object)'/' + this.int_40.ToString();
            if (!this.bool_47)
                return;
            this.bool_47 = false;
            this.toolStripMenuItem_0.Enabled = false;
            this.toolStripMenuItem_1.Enabled = false;
            this.toolStripMenuItem_3.Enabled = false;
        }
    }

    private void toolStripMenuItem_3_Click(object sender, EventArgs e) => this.method_50();

    private void method_51(object sender, EventArgs e)
    {
    }

    private void toolStripMenuItem_4_Click(object sender, EventArgs e)
    {
        int int_0 = 10;
        this.int_45 = new int[this.int_49.Length];
        for (int index = 0; index < this.int_49.Length; ++index)
            this.int_45[index] = this.int_49[index];
        this.toolStripMenuItem_4.Enabled = false;
        this.menuItem_102.Enabled = true;
        this.bool_46 = true;
        this.menuItem_31.Enabled = true;
        this.Text = Module.a("邯颱", int_0);
        this.int_55 = this.textBox_0.SelectionStart;
        this.int_40 = this.int_49.Length;
        this.int_50 = this.int_49.Length;
        this.trackBar_0.Minimum = 0;
        this.trackBar_0.Maximum = this.int_40 - 1;
        this.textBox_0.Text = "";
        for (int index = 0; index < this.int_40; ++index)
            this.textBox_0.Text += (string)(object)'■';
        this.toolStripTextBox_0.Text = (this.int_55 + 1).ToString() + (object)'/' + this.int_40.ToString();
        if (!this.bool_47)
            return;
        this.bool_47 = false;
        this.toolStripMenuItem_0.Enabled = false;
        this.toolStripMenuItem_1.Enabled = false;
        this.toolStripMenuItem_3.Enabled = false;
    }

    private void menuItem_31_Click(object sender, EventArgs e)
    {
        int int_0 = 1;
        string str1 = this.string_20 + (object)'\\' + this.string_22 + Module.a("\uF8A6\uDDA8\uDBAA莬춮\uD8B0\uDDB2", 1);
        if (System.IO.File.Exists(str1))
            System.IO.File.Delete(str1);
        FileStream fileStream = new FileStream(str1, FileMode.Create, FileAccess.Write);
        BufferedStream bufferedStream = new BufferedStream((Stream)fileStream);
        for (int index1 = 0; index1 < this.int_50; ++index1)
        {
            this.bufferedStream_1.Seek((long)this.int_39 * (long)this.int_45[index1], SeekOrigin.Begin);
            this.bufferedStream_1.Read(this.byte_38, 0, this.int_39);
            for (uint index2 = 0; (long)index2 < (long)this.int_39; ++index2)
                this.byte_37[index2] = (byte)((uint)this.byte_38[(index2 ^ (uint)this.byte_45)] - (uint)this.byte_44);
            for (uint index3 = 0; (long)index3 < (long)this.int_39; ++index3)
                this.byte_38[index3] = (byte)((uint)this.byte_37[(index3 ^ (uint)this.byte_45)] + (uint)this.byte_44);
            bufferedStream.Write(this.byte_38, 0, this.int_39);
        }
        bufferedStream.Flush();
        bufferedStream.Close();
        fileStream.Close();
        this.bufferedStream_1.Flush();
        this.bufferedStream_1.Close();
        this.fileStream_1.Close();
        string str2 = this.string_20 + (object)'\\' + ((GClass5)c.arrayList_4[c.int_38]).string_3;
        ((GClass5)c.arrayList_4[c.int_38]).bool_3 = false;
        if (System.IO.File.Exists(str2))
            System.IO.File.Delete(str2);
        System.IO.File.Copy(str1, str2);
        System.IO.File.Delete(str1);
        this.method_26(4, Module.a("隦", int_0));
        this.method_26(5, this.string_22 + Module.a("覦쮨슪쎬", int_0));
        this.method_26(8, Module.a("隦", int_0));
        this.method_26(9, this.int_50.ToString());
        this.fileStream_1 = new FileStream(this.string_20 + (object)'\\' + ((GClass5)c.arrayList_4[c.int_38]).string_3, FileMode.Open, FileAccess.Read);
        this.bufferedStream_1 = new BufferedStream((Stream)this.fileStream_1);
        this.method_29(9);
        this.int_40 = ((GClass5)c.arrayList_4[c.int_38]).int_0;
        this.int_50 = this.int_40;
        this.textBox_0.Text = "";
        this.int_45 = new int[this.int_40];
        for (int index = 0; index < this.int_40; ++index)
        {
            this.int_45[index] = index;
            this.textBox_0.Text += (string)(object)'■';
        }
        this.bool_46 = false;
        this.menuItem_31.Enabled = false;
        this.Text = this.string_8 + Module.a("ﲦ蒨蚪", int_0) + this.string_22 + (object)']';
    }

    private void c_FormClosing(object sender, FormClosingEventArgs e)
    {
        this.bool_37 = false;
        this.timer_1.Interval = 1000 / c.smethod_0();
        this.timer_1.Enabled = false;
        if (this.bool_46)
            this.menuItem_6_Click(sender, (EventArgs)e);
        e.Cancel = false;
        try
        {
            if (this.udpClient_0 == null)
                return;
            this.udpClient_0.Close();
        }
        catch
        {
        }
    }

    private void menuItem_3_Click(object sender, EventArgs e)
    {
        this.bool_36 = true;
        this.method_26(6, Module.a("龮", 9));
    }

    private void menuItem_33_Click(object sender, EventArgs e)
    {
        int int_0 = 3;
        this.int_31 = (int)byte.MaxValue;
        for (int index = 0; index < c.arrayList_4.Count; ++index)
        {
            if (!System.IO.File.Exists(this.string_20 + ((GClass5)c.arrayList_4[index]).string_3) || !((GClass5)c.arrayList_4[index]).bool_2)
            {
                if (c.useEnglishLanguage)
                {
                    this.ShowMessage(((GClass5)c.arrayList_4[index]).string_0 + Module.a("잨쒪趬\uDDAE풰킲\uDAB4얶\uDDB8튺펼\uD8BE\uE0C0", int_0));
                    return;
                }
                this.ShowMessage(((GClass5)c.arrayList_4[index]).string_0 + Module.a("䧍ﻵ鯾⫿࣫銲", int_0));
                return;
            }
        }
        bool flag = false;
        for (int index = 0; index < c.arrayList_4.Count; ++index)
        {
            if (!((GClass5)c.arrayList_4[index]).bool_3)
            {
                string str = this.string_20 + ((GClass5)c.arrayList_4[index]).string_3;
                string string_25 = this.string_20 + ((GClass5)c.arrayList_4[index]).string_1;
                this.textBox_4.Text = this.listBox_0.Items[c.int_38].ToString();
                if (System.IO.File.Exists(str))
                {
                    this.method_40(str, string_25);
                    ((GClass5)c.arrayList_4[index]).bool_3 = true;
                    flag = true;
                }
            }
        }
        if (flag)
            this.method_28();
        string path = this.string_20 + ((GClass5)c.arrayList_4[c.int_38]).string_1 + Module.a("\uF5A8鮪鶬膮\uDDB0횲톴", int_0);
        if (System.IO.File.Exists(path))
        {
            this.fileStream_2 = new FileStream(path, FileMode.Open, FileAccess.Read);
            this.bufferedStream_2 = new BufferedStream((Stream)this.fileStream_2);
            byte[] buffer1 = new byte[512];
            this.bufferedStream_2.Seek(0L, SeekOrigin.Begin);
            this.bufferedStream_2.Read(buffer1, 0, 512);
            if (buffer1[0] == (byte)114 && buffer1[1] == (byte)122 && buffer1[2] == (byte)98 && buffer1[3] == (byte)118 && buffer1[4] == (byte)48 && buffer1[5] == (byte)48 && buffer1[6] == (byte)49)
            {
                this.int_32 = (int)buffer1[7];
                this.int_30 = new int[this.int_32];
                for (int index = 0; index < this.int_32; ++index)
                    this.int_30[index] = 0;
                this.int_33 = this.int_39;
                switch (c.int_2)
                {
                    case 102:
                        this.int_33 = this.int_32 * c.int_75 * this.int_82 * 2;
                        break;
                    case 103:
                        this.int_33 = this.int_39 / 2;
                        break;
                }
                this.string_9 = new string[this.int_32];
                for (int index = 0; index < this.int_32; ++index)
                {
                    int num = 50 + index;
                    this.string_9[index] = Module.a("風銪龬膮肰薲趴馶辸论鎼", int_0) + num.ToString();
                }
                byte[] numArray1 = new byte[16]
                {
          (byte) 143,
          (byte) 45,
          (byte) 28,
          (byte) 105,
          (byte) 84,
          (byte) 163,
          (byte) 200,
          (byte) 75,
          (byte) 46,
          (byte) 227,
          (byte) 249,
          (byte) 35,
          (byte) 118,
          (byte) 176,
          (byte) 209,
          (byte) 62
                };
                byte[] numArray2 = new byte[16];
                for (int index = 0; index < 16; ++index)
                    numArray2[index] = buffer1[index + 185];
                byte num1 = 0;
                for (int index = 0; index < 16; ++index)
                {
                    byte num2 = (byte)((uint)numArray2[index] ^ (uint)numArray1[index]);
                    num1 += num2;
                }
                for (int index = 0; index < 16; ++index)
                    num1 += numArray2[index];
                this.byte_42 = (byte)((uint)(byte)((uint)(byte)((uint)(byte)((uint)(byte)((uint)(byte)((uint)num1 + (uint)numArray1[0]) + (uint)numArray1[2]) + (uint)numArray1[7]) + (uint)numArray1[9]) + (uint)numArray1[15]) ^ 90U);
                byte[] numArray3 = new byte[16]
                {
          (byte) 206,
          (byte) 73,
          (byte) 147,
          (byte) 86,
          (byte) 164,
          (byte) 129,
          (byte) 63,
          (byte) 162,
          (byte) 113,
          (byte) 148,
          (byte) 42,
          (byte) 53,
          (byte) 23,
          (byte) 62,
          (byte) 91,
          (byte) 225
                };
                byte num3 = 0;
                for (int index1 = 311; index1 < 427; ++index1)
                {
                    byte index2 = (byte)(index1 % 16);
                    num3 += (byte)((uint)buffer1[index1] ^ (uint)numArray3[(int)index2]);
                }
                for (int index = 430; index < 511; ++index)
                    num3 += (byte)((uint)buffer1[index] ^ 90U);
                this.byte_43 = (byte)((uint)num3 ^ 165U);
                if (c.int_2 == 81 || c.int_2 == 86 || c.int_2 == 82 || c.int_2 == 83 || c.int_2 == 84 || c.int_2 == 85)
                {
                    if (c.int_2 == 81)
                        buffer1[15] = (byte)12;
                    if (c.int_2 == 82)
                        buffer1[15] = (byte)31;
                    if (c.int_2 == 83)
                        buffer1[15] = (byte)2;
                    if (c.int_2 == 84)
                        buffer1[15] = (byte)8;
                    if (c.int_2 == 85)
                        buffer1[15] = (byte)46;
                    if (c.int_2 == 86)
                        buffer1[15] = (byte)54;
                }
                if (buffer1[36] == (byte)17)
                {
                    byte[] numArray4 = new byte[16]
                    {
            (byte) 140,
            (byte) 113,
            (byte) 41,
            (byte) 111,
            (byte) 227,
            (byte) 202,
            (byte) 180,
            (byte) 249,
            (byte) 55,
            (byte) 16,
            (byte) 77,
            (byte) 5,
            (byte) 147,
            (byte) 168,
            (byte) 138,
            (byte) 26
                    };
                    byte num4 = 0;
                    for (int index3 = 0; index3 < 109; ++index3)
                    {
                        byte index4 = (byte)(index3 % 16);
                        num4 += (byte)((uint)buffer1[index3] ^ (uint)numArray4[(int)index4]);
                    }
                    if (num4 < (byte)128)
                        num4 += (byte)120;
                    for (int index = 0; index < 16; ++index)
                        numArray2[index] = buffer1[index + (int)num4];
                    numArray2[3] = buffer1[12];
                    numArray2[4] = buffer1[13];
                    numArray2[7] = buffer1[15];
                    numArray2[8] = buffer1[31];
                    numArray2[10] = buffer1[27];
                    numArray2[11] = buffer1[14];
                    numArray2[15] = buffer1[26];
                    byte[] numArray5 = new byte[280]
                    {
            (byte) 36,
            (byte) 144,
            (byte) 157,
            (byte) 7,
            (byte) 104,
            (byte) 42,
            (byte) 8,
            (byte) 100,
            (byte) 183,
            (byte) 154,
            (byte) 151,
            (byte) 189,
            (byte) 153,
            (byte) 247,
            (byte) 133,
            (byte) 118,
            (byte) 252,
            (byte) 226,
            (byte) 43,
            (byte) 229,
            (byte) 229,
            (byte) 151,
            (byte) 204,
            (byte) 27,
            (byte) 57,
            (byte) 214,
            (byte) 205,
            (byte) 204,
            (byte) 26,
            (byte) 238,
            (byte) 78,
            (byte) 192,
            (byte) 7,
            (byte) 12,
            (byte) 117,
            (byte) 102,
            (byte) 116,
            (byte) 170,
            (byte) 21,
            (byte) 190,
            (byte) 99,
            (byte) 53,
            (byte) 198,
            (byte) 39,
            (byte) 126,
            (byte) 74,
            (byte) 132,
            (byte) 160,
            (byte) 134,
            (byte) 238,
            (byte) 190,
            (byte) 152,
            (byte) 180,
            (byte) 142,
            (byte) 21,
            (byte) 141,
            (byte) 195,
            (byte) 130,
            (byte) 205,
            (byte) 146,
            (byte) 92,
            (byte) 60,
            (byte) 74,
            (byte) 201,
            (byte) 75,
            (byte) 214,
            (byte) 181,
            (byte) 140,
            (byte) 130,
            (byte) 31,
            (byte) 1,
            (byte) 81,
            (byte) 205,
            (byte) 108,
            (byte) 129,
            (byte) 175,
            (byte) 208,
            (byte) 165,
            (byte) 156,
            (byte) 239,
            (byte) 82,
            (byte) 45,
            (byte) 70,
            (byte) 44,
            (byte) 47,
            (byte) 182,
            (byte) 12,
            (byte) 121,
            (byte) 247,
            (byte) 231,
            (byte) 162,
            (byte) 241,
            (byte) 220,
            (byte) 131,
            (byte) 97,
            (byte) 39,
            (byte) 235,
            (byte) 253,
            (byte) 220,
            (byte) 167,
            (byte) 148,
            (byte) 247,
            (byte) 29,
            (byte) 102,
            (byte) 236,
            (byte) 109,
            (byte) 202,
            (byte) 71,
            (byte) 12,
            (byte) 101,
            (byte) 188,
            (byte) 30,
            (byte) 229,
            (byte) 222,
            (byte) 64,
            (byte) 47,
            (byte) 245,
            (byte) 29,
            (byte) 153,
            (byte) 148,
            (byte) 202,
            (byte) 60,
            (byte) 149,
            (byte) 155,
            (byte) 125,
            (byte) 15,
            (byte) 116,
            (byte) 74,
            (byte) 11,
            (byte) 89,
            (byte) 195,
            (byte) 210,
            (byte) 201,
            (byte) 245,
            (byte) 91,
            (byte) 91,
            (byte) 15,
            (byte) 224,
            (byte) 63,
            (byte) 194,
            (byte) 235,
            (byte) 196,
            (byte) 108,
            (byte) 145,
            (byte) 42,
            (byte) 132,
            (byte) 12,
            (byte) 254,
            (byte) 67,
            (byte) 49,
            (byte) 50,
            (byte) 205,
            (byte) 99,
            (byte) 71,
            (byte) 221,
            (byte) 87,
            (byte) 97,
            (byte) 130,
            (byte) 233,
            (byte) 220,
            (byte) 248,
            (byte) 128,
            (byte) 60,
            (byte) 178,
            (byte) 162,
            (byte) 234,
            (byte) 85,
            (byte) 240,
            (byte) 131,
            (byte) 228,
            (byte) 32,
            (byte) 21,
            (byte) 222,
            (byte) 215,
            (byte) 168,
            (byte) 5,
            (byte) 207,
            (byte) 4,
            (byte) 112,
            (byte) 248,
            (byte) 3,
            (byte) 118,
            (byte) 7,
            (byte) 217,
            (byte) 39,
            (byte) 246,
            (byte) 111,
            (byte) 129,
            (byte) 24,
            (byte) 3,
            (byte) 249,
            (byte) 140,
            (byte) 246,
            (byte) 99,
            (byte) 202,
            (byte) 107,
            (byte) 136,
            (byte) 186,
            (byte) 239,
            (byte) 64,
            (byte) 47,
            (byte) 27,
            (byte) 123,
            (byte) 94,
            (byte) 17,
            (byte) 28,
            (byte) 239,
            (byte) 140,
            (byte) 159,
            (byte) 216,
            (byte) 136,
            (byte) 92,
            (byte) 18,
            (byte) 240,
            (byte) 216,
            (byte) 130,
            (byte) 121,
            (byte) 98,
            (byte) 139,
            (byte) 171,
            (byte) 122,
            (byte) 211,
            (byte) 216,
            (byte) 128,
            (byte) 234,
            (byte) 147,
            (byte) 30,
            (byte) 122,
            (byte) 12,
            (byte) 61,
            (byte) 124,
            (byte) 21,
            (byte) 21,
            (byte) 47,
            (byte) 201,
            (byte) 231,
            (byte) 251,
            (byte) 168,
            (byte) 200,
            (byte) 10,
            (byte) 6,
            (byte) 226,
            (byte) 226,
            (byte) 64,
            (byte) 123,
            (byte) 157,
            (byte) 122,
            (byte) 6,
            (byte) 138,
            (byte) 71,
            (byte) 241,
            (byte) 38,
            (byte) 47,
            (byte) 67,
            (byte) 197,
            (byte) 91,
            (byte) 67,
            (byte) 250,
            (byte) 115,
            (byte) 125,
            (byte) 254,
            (byte) 117,
            (byte) 127,
            (byte) 97,
            (byte) 91,
            (byte) 114,
            (byte) 71,
            (byte) 226,
            (byte) 38,
            (byte) 240,
            (byte) 135,
            (byte) 208,
            (byte) 153,
            (byte) 128,
            (byte) 165,
            (byte) 152,
            (byte) 241,
            (byte) 152,
            (byte) 5,
            (byte) 77
                    };
                    byte num5 = 0;
                    for (int index = 0; index < 16; ++index)
                        num5 += numArray2[index];
                    byte num6 = 0;
                    for (int index = 0; index < 16; ++index)
                    {
                        byte num7 = (byte)((uint)numArray2[index] ^ (uint)numArray5[index + (int)num5]);
                        num6 += num7;
                    }
                    byte[] numArray6 = new byte[8];
                    for (int index = 0; index < 8; ++index)
                        numArray6[index] = numArray5[index + (int)num6];
                    byte num8 = 90;
                    for (int index = 0; index < 8; ++index)
                        num8 ^= numArray2[index];
                    byte num9 = 0;
                    for (int index = 0; index < 8; ++index)
                    {
                        byte num10 = (byte)((uint)numArray2[index] ^ (uint)numArray5[index + (int)num8]);
                        num9 += num10;
                    }
                    byte[] buffer2 = new byte[8];
                    for (int index = 0; index < 8; ++index)
                        buffer2[index] = (byte)((uint)numArray2[index] ^ (uint)numArray5[index + (int)num9]);
                    byte[] numArray7 = new byte[8];
                    using (DESCryptoServiceProvider cryptoServiceProvider = new DESCryptoServiceProvider())
                    {
                        byte[] numArray8 = new byte[8];
                        cryptoServiceProvider.Key = numArray6;
                        cryptoServiceProvider.IV = numArray8;
                        cryptoServiceProvider.Padding = PaddingMode.None;
                        MemoryStream memoryStream = new MemoryStream();
                        using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, cryptoServiceProvider.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            cryptoStream.Write(buffer2, 0, buffer2.Length);
                            cryptoStream.FlushFinalBlock();
                            cryptoStream.Close();
                        }
                        byte[] array = memoryStream.ToArray();
                        memoryStream.Close();
                        if (array.Length == 8)
                        {
                            for (int index = 0; index < 8; ++index)
                                numArray7[index] = array[index];
                        }
                        else
                        {
                            if (c.useEnglishLanguage)
                            {
                                this.ShowMessage(Module.a("\uECA8\uD9AA\uDFAC삮쎰銲", int_0));
                                return;
                            }
                            this.ShowMessage(Module.a("磻듟됹䀥邰", int_0));
                            return;
                        }
                    }
                    byte[] numArray9 = new byte[4]
                    {
            (byte) ((uint) numArray7[0] ^ (uint) numArray7[1]),
            (byte) ((uint) numArray7[2] + (uint) numArray7[3]),
            (byte) ((uint) numArray7[4] - (uint) numArray7[5]),
            (byte) ((uint) numArray7[6] ^ (uint) numArray7[7])
                    };
                    byte num11 = 0;
                    byte num12 = numArray9[0];
                    if (num12 < (byte)128)
                        num12 += (byte)120;
                    for (int index5 = 0; index5 < 119; ++index5)
                    {
                        byte index6 = (byte)(index5 % 16);
                        num11 += (byte)((uint)buffer1[index5 + (int)num12] ^ (uint)numArray4[(int)index6]);
                    }
                    this.byte_42 ^= num11;
                    this.byte_42 += numArray9[2];
                    byte num13 = 0;
                    byte num14 = numArray9[1];
                    if (num14 < (byte)128)
                        num14 += (byte)120;
                    for (int index7 = 0; index7 < 149; ++index7)
                    {
                        byte index8 = (byte)(index7 % 16);
                        num13 += (byte)((uint)buffer1[index7 + (int)num14] ^ (uint)numArray4[(int)index8]);
                    }
                    this.byte_43 += num13;
                    this.byte_43 ^= numArray9[3];
                }
                this.byte_39 = new byte[10];
                new Random().NextBytes(this.byte_39);
                byte num15 = 0;
                numArray1[0] = (byte)59;
                numArray1[1] = (byte)129;
                numArray1[2] = (byte)197;
                numArray1[3] = (byte)228;
                numArray1[4] = (byte)81;
                numArray1[5] = (byte)208;
                numArray1[6] = (byte)127;
                numArray1[7] = (byte)174;
                numArray1[8] = (byte)99;
                numArray1[9] = (byte)41;
                for (int index = 0; index < 10; ++index)
                {
                    num15 += (byte)((uint)this.byte_39[index] ^ (uint)numArray1[index]);
                    this.byte_30[index + 2] = this.byte_39[index];
                }
                int num16 = (int)(byte)((uint)num15 ^ 90U);
                this.byte_41 = (byte)num16;
                this.int_79 = num16 - (int)this.byte_42;
            }
            this.fileStream_1 = new FileStream(this.string_20 + ((GClass5)c.arrayList_4[c.int_38]).string_3, FileMode.Open, FileAccess.Read);
            this.bufferedStream_1 = new BufferedStream((Stream)this.fileStream_1);
            this.int_55 = 0;
            this.int_40 = ((GClass5)c.arrayList_4[c.int_38]).int_0;
            this.int_50 = this.int_40;
            this.trackBar_0.Minimum = 0;
            this.trackBar_0.Maximum = this.int_40 - 1;
            this.trackBar_0.Enabled = true;
            if ((c.string_7 == Module.a("ﶨ\uE7AAﺬ辮\uE7B0蚲颴襁", int_0) || c.string_7 == Module.a("\uEAA8\uDEAA\uDFAC\uDBAE킰\uDAB2\uDBB4鞶\uEFB8躺", int_0)) && c.smethod_0() > 20)
                c.smethod_1(20);
            this.bool_50 = true;
            this.bool_37 = true;
            this.timer_1.Interval = 1000 / c.smethod_0();
            this.timer_1.Enabled = true;
            this.bool_27 = true;
            this.genum1_1 = GEnum1.const_8;
            this.bool_31 = false;
            this.menuItem_39.Enabled = true;
            this.menuItem_40.Enabled = false;
            this.byte_35[0] = (byte)197;
            this.byte_35[1] = (byte)119;
            this.byte_35[2] = (byte)136;
            try
            {
                this.udpClient_0.Send(this.byte_35, 5, Module.a("風銪龬膮肰薲趴馶辸论鎼誾\uF1C0", int_0), 5000);
            }
            catch
            {
            }
            this.k_0.Show();
            this.timer_0.Enabled = true;
            this.method_13();
            this.toolStripMenuItem_0.Enabled = false;
            this.toolStripMenuItem_1.Enabled = false;
            this.toolStripMenuItem_2.Enabled = false;
            this.toolStripMenuItem_3.Enabled = false;
            this.toolStripMenuItem_4.Enabled = false;
            this.menuItem_33.Enabled = false;
            this.menuItem_34.Enabled = true;
            this.method_31();
            this.BringToFront();
            this.method_39();
        }
        else if (c.useEnglishLanguage)
            this.ShowMessage(this.string_22 + Module.a("螨잪좬쮮醰\uDAB2\uDBB4솶\uD8B8ힺ풼\uDBBE\uEDC0ꃂ꧄껆\uAAC8ꃊ\uEDCC賎ꏐ뛒듔ꏖ律꿚닜\uFFDE蛠蛢诤苦鯨諪駬諮퇰蟲鷴鋶\uD9F8헺釼髾攀⌂挄渆攈渊Ⰼ", int_0));
        else
            this.ShowMessage(this.string_22 + Module.a("螨잪좬쮮醰㓗䏺埓\uF1DD鞺䨷ێ㪑\uDFE2\uDAB1\uD7A4퓨ᝉ颟\uE3CE캥쎰ﯔ믖볘뿚媹⦐\uE01F", int_0));
    }

    private void method_52()
    {
        this.bufferedStream_2.Seek((long)this.int_33 * (long)this.int_55 + 512L, SeekOrigin.Begin);
        this.bufferedStream_2.Read(this.byte_38, 0, this.int_33);
        for (uint index = 0; (long)index < (long)this.int_33; ++index)
            this.byte_40[index] = (byte)((uint)this.byte_38[(index ^ (uint)this.byte_43)] + (uint)this.int_79);
        for (int index1 = 0; index1 < 8; ++index1)
        {
            this.class2_1.method_0();
            for (int index2 = 0; index2 < this.int_32; ++index2)
            {
                this.byte_30[0] = (byte)136;
                this.byte_30[1] = (byte)index1;
                int num = index2 * 6144 + index1 * 768;
                for (int index3 = 0; index3 < 768; ++index3)
                    this.byte_30[index3 + 12] = this.byte_40[index3 + num];
                try
                {
                    this.udpClient_0.Send(this.byte_30, 780, this.string_9[index2], 5000);
                }
                catch
                {
                }
            }
            this.class2_1.method_1();
            while (this.class2_1.method_2() < 0.0015)
                this.class2_1.method_1();
        }
        this.byte_31[0] = (byte)170;
        switch (c.int_2)
        {
            case 101:
                this.byte_31[1] = (byte)17;
                break;
            case 103:
                this.byte_31[1] = (byte)34;
                break;
        }
        this.byte_31[2] = (byte)c.int_2;
        this.byte_31[3] = c.byte_20;
        for (int index = 0; index < this.int_32; ++index)
        {
            try
            {
                this.udpClient_0.Send(this.byte_31, 5, this.string_9[index], 5000);
            }
            catch
            {
            }
        }
    }

    private void method_53()
    {
        this.bufferedStream_2.Seek((long)this.int_33 * (long)this.int_55 + 512L, SeekOrigin.Begin);
        this.bufferedStream_2.Read(this.byte_38, 0, this.int_33);
        for (uint index = 0; (long)index < (long)this.int_33; ++index)
            this.byte_40[index] = (byte)((uint)this.byte_38[(index ^ (uint)this.byte_43)] + (uint)this.int_79);
        for (int index1 = 0; index1 < this.int_62; ++index1)
        {
            this.class2_1.method_0();
            for (int index2 = 0; index2 < this.int_32; ++index2)
            {
                this.byte_30[0] = (byte)136;
                this.byte_30[1] = (byte)index1;
                int num = index2 * this.int_63 + index1 * 1024;
                for (int index3 = 0; index3 < 1024; ++index3)
                    this.byte_30[index3 + 12] = this.byte_40[index3 + num];
                try
                {
                    this.udpClient_0.Send(this.byte_30, 1040, this.string_9[index2], 5000);
                }
                catch
                {
                }
            }
            this.class2_1.method_1();
            while (this.class2_1.method_2() < 0.0015)
                this.class2_1.method_1();
        }
        if (c.int_2 > 100)
        {
            for (int index = 0; index < this.int_32; ++index)
            {
                this.byte_31[0] = (byte)170;
                this.byte_31[1] = (byte)index;
                this.byte_31[2] = (byte)c.int_2;
                this.byte_31[3] = c.byte_20;
                try
                {
                    this.udpClient_0.Send(this.byte_31, 5, this.string_9[index], 5000);
                }
                catch
                {
                }
            }
        }
        else
        {
            for (int index = 0; index < this.int_32; ++index)
            {
                try
                {
                    this.udpClient_0.Send(this.byte_17, 65, this.string_9[index], 5000);
                }
                catch
                {
                }
            }
        }
    }

    private void method_54()
    {
        this.bufferedStream_2.Seek((long)this.int_33 * (long)this.int_55 + 512L, SeekOrigin.Begin);
        this.bufferedStream_2.Read(this.byte_38, 0, this.int_33);
        for (uint index = 0; (long)index < (long)this.int_33; ++index)
            this.byte_40[index] = (byte)((uint)this.byte_38[(index ^ (uint)this.byte_43)] + (uint)this.int_79);
        for (int index1 = 0; index1 < this.int_62; ++index1)
        {
            this.class2_1.method_0();
            for (int index2 = 0; index2 < this.int_32; ++index2)
            {
                this.byte_30[0] = (byte)136;
                this.byte_30[1] = (byte)index1;
                int num = index2 * this.int_63 + index1 * 1024;
                for (int index3 = 0; index3 < 1024; ++index3)
                    this.byte_30[index3 + 12] = this.byte_40[index3 + num];
                try
                {
                    this.udpClient_0.Send(this.byte_30, 1040, this.string_9[index2], 5000);
                }
                catch
                {
                }
            }
            this.class2_1.method_1();
            while (this.class2_1.method_2() < 0.0015)
                this.class2_1.method_1();
        }
        if (c.int_2 > 100)
        {
            for (int index = 0; index < this.int_32; ++index)
            {
                this.byte_31[0] = (byte)170;
                this.byte_31[1] = (byte)((uint)this.byte_29 | 160U);
                this.byte_31[2] = (byte)c.int_2;
                this.byte_31[3] = c.byte_20;
                try
                {
                    this.udpClient_0.Send(this.byte_31, 5, this.string_9[index], 5000);
                }
                catch
                {
                }
            }
        }
        else
        {
            for (int index = 0; index < this.int_32; ++index)
            {
                try
                {
                    this.udpClient_0.Send(this.byte_17, 65, this.string_9[index], 5000);
                }
                catch
                {
                }
            }
        }
    }

    private void method_55()
    {
        this.bufferedStream_2.Seek((long)this.int_33 * (long)this.int_55 + 512L, SeekOrigin.Begin);
        this.bufferedStream_2.Read(this.byte_38, 0, this.int_33);
        for (uint index = 0; (long)index < (long)this.int_33; ++index)
            this.byte_40[index] = (byte)((uint)this.byte_38[(index ^ (uint)this.byte_43)] + (uint)this.int_79);
        int num1 = this.int_82 * 24;
        int num2 = num1 / 1024;
        for (int index1 = 0; index1 < num2; ++index1)
        {
            this.class2_1.method_0();
            for (int index2 = 0; index2 < this.int_32; ++index2)
            {
                this.byte_30[0] = (byte)136;
                this.byte_30[1] = (byte)index1;
                int num3 = index2 * num1 + index1 * 1024;
                for (int index3 = 0; index3 < 1024; ++index3)
                    this.byte_30[index3 + 12] = this.byte_40[index3 + num3];
                try
                {
                    this.udpClient_0.Send(this.byte_30, 1040, this.string_9[index2], 5000);
                }
                catch
                {
                }
            }
            this.class2_1.method_1();
            while (this.class2_1.method_2() < 0.0015)
                this.class2_1.method_1();
        }
        if (c.int_2 > 100)
        {
            this.byte_31[0] = (byte)170;
            this.byte_31[1] = c.byte_19;
            this.byte_31[2] = (byte)c.int_2;
            this.byte_31[3] = c.byte_20;
            this.byte_31[4] = c.bool_17 ? (byte)85 : (byte)0;
            this.byte_31[5] = c.byte_2;
            this.byte_31[6] = c.byte_6;
            this.byte_31[7] = c.byte_7;
            this.byte_31[8] = c.byte_8;
            for (int index = 0; index < this.int_32; ++index)
            {
                try
                {
                    this.udpClient_0.Send(this.byte_31, 9, this.string_9[index], 5000);
                }
                catch
                {
                }
            }
        }
        else
        {
            for (int index = 0; index < this.int_32; ++index)
            {
                try
                {
                    this.udpClient_0.Send(this.byte_17, 65, this.string_9[index], 5000);
                }
                catch
                {
                }
            }
        }
    }

    private void method_56()
    {
        this.bufferedStream_2.Seek((long)this.int_33 * (long)this.int_55 + 512L, SeekOrigin.Begin);
        this.bufferedStream_2.Read(this.byte_38, 0, this.int_33);
        for (uint index = 0; (long)index < (long)this.int_33; ++index)
            this.byte_40[index] = (byte)((uint)this.byte_38[(index ^ (uint)this.byte_43)] + (uint)this.int_79);
        for (int index1 = 0; index1 < 16; ++index1)
        {
            this.class2_1.method_0();
            this.byte_30[0] = (byte)136;
            this.byte_30[1] = (byte)index1;
            int num = index1 * 1024;
            for (int index2 = 0; index2 < 1024; ++index2)
                this.byte_30[index2 + 12] = this.byte_40[index2 + num];
            try
            {
                this.udpClient_0.Send(this.byte_30, 1040, this.string_9[0], 5000);
            }
            catch
            {
            }
            this.class2_1.method_1();
            while (this.class2_1.method_2() < 0.0015)
                this.class2_1.method_1();
        }
        this.byte_31[0] = (byte)170;
        this.byte_31[1] = (byte)0;
        this.byte_31[2] = (byte)c.int_2;
        this.byte_31[3] = c.byte_20;
        try
        {
            this.udpClient_0.Send(this.byte_31, 5, this.string_9[0], 5000);
        }
        catch
        {
        }
    }

    private void method_57()
    {
        for (int index1 = 0; index1 < 8; ++index1)
        {
            this.class2_1.method_0();
            for (int index2 = 0; index2 < this.int_32; ++index2)
            {
                this.byte_30[0] = (byte)136;
                this.byte_30[1] = (byte)index1;
                int num = index2 * 6144 + index1 * 768;
                for (int index3 = 0; index3 < 768; ++index3)
                    this.byte_30[index3 + 12] = (byte)((uint)this.byte_40[index3 + num] + (uint)this.byte_42);
                try
                {
                    this.udpClient_0.Send(this.byte_30, 780, this.string_9[index2], 5000);
                }
                catch
                {
                }
            }
            this.class2_1.method_1();
            while (this.class2_1.method_2() < 0.0015)
                this.class2_1.method_1();
        }
        this.byte_31[0] = (byte)170;
        switch (c.int_2)
        {
            case 101:
                this.byte_31[1] = (byte)17;
                break;
            case 103:
                this.byte_31[1] = (byte)34;
                break;
        }
        this.byte_31[2] = (byte)c.int_2;
        this.byte_31[3] = c.byte_20;
        for (int index = 0; index < this.int_32; ++index)
        {
            try
            {
                this.udpClient_0.Send(this.byte_31, 5, this.string_9[index], 5000);
            }
            catch
            {
            }
        }
    }

    private void method_58()
    {
        for (int index1 = 0; index1 < this.int_62; ++index1)
        {
            this.class2_1.method_0();
            for (int index2 = 0; index2 < this.int_32; ++index2)
            {
                this.byte_30[0] = (byte)136;
                this.byte_30[1] = (byte)index1;
                int num = index2 * this.int_63 + index1 * 1024;
                for (int index3 = 0; index3 < 1024; ++index3)
                    this.byte_30[index3 + 12] = (byte)((uint)this.byte_40[index3 + num] + (uint)this.byte_42);
                try
                {
                    this.udpClient_0.Send(this.byte_30, 1040, this.string_9[index2], 5000);
                }
                catch
                {
                }
            }
            this.class2_1.method_1();
            while (this.class2_1.method_2() < 0.0015)
                this.class2_1.method_1();
        }
        if (c.int_2 > 100)
        {
            for (int index = 0; index < this.int_32; ++index)
            {
                this.byte_31[0] = (byte)170;
                this.byte_31[1] = (byte)index;
                this.byte_31[2] = (byte)c.int_2;
                this.byte_31[3] = c.byte_20;
                try
                {
                    this.udpClient_0.Send(this.byte_31, 5, this.string_9[index], 5000);
                }
                catch
                {
                }
            }
        }
        else
        {
            for (int index = 0; index < this.int_32; ++index)
            {
                try
                {
                    this.udpClient_0.Send(this.byte_17, 65, this.string_9[index], 5000);
                }
                catch
                {
                }
            }
        }
    }

    private void method_59()
    {
        int num1 = this.int_82 * 24;
        int num2 = num1 / 1024;
        for (int index1 = 0; index1 < num2; ++index1)
        {
            this.class2_1.method_0();
            for (int index2 = 0; index2 < this.int_32; ++index2)
            {
                this.byte_30[0] = (byte)136;
                this.byte_30[1] = (byte)index1;
                int num3 = index2 * num1 + index1 * 1024;
                for (int index3 = 0; index3 < 1024; ++index3)
                    this.byte_30[index3 + 12] = (byte)((uint)this.byte_40[index3 + num3] + (uint)this.byte_42);
                try
                {
                    this.udpClient_0.Send(this.byte_30, 1040, this.string_9[index2], 5000);
                }
                catch
                {
                }
            }
            this.class2_1.method_1();
            while (this.class2_1.method_2() < 0.0015)
                this.class2_1.method_1();
        }
        if (c.int_2 > 100)
        {
            this.byte_31[0] = (byte)170;
            this.byte_31[1] = c.byte_19;
            this.byte_31[2] = (byte)c.int_2;
            this.byte_31[3] = c.byte_20;
            this.byte_31[4] = c.bool_17 ? (byte)85 : (byte)0;
            this.byte_31[5] = c.byte_2;
            this.byte_31[6] = c.byte_6;
            this.byte_31[7] = c.byte_7;
            this.byte_31[8] = c.byte_8;
            for (int index = 0; index < this.int_32; ++index)
            {
                try
                {
                    this.udpClient_0.Send(this.byte_31, 9, this.string_9[index], 5000);
                }
                catch
                {
                }
            }
        }
        else
        {
            for (int index = 0; index < this.int_32; ++index)
            {
                try
                {
                    this.udpClient_0.Send(this.byte_17, 65, this.string_9[index], 5000);
                }
                catch
                {
                }
            }
        }
    }

    private void method_60()
    {
        for (int index1 = 0; index1 < this.int_62; ++index1)
        {
            this.class2_1.method_0();
            for (int index2 = 0; index2 < this.int_32; ++index2)
            {
                this.byte_30[0] = (byte)136;
                this.byte_30[1] = (byte)index1;
                int num = index2 * this.int_63 + index1 * 1024;
                for (int index3 = 0; index3 < 1024; ++index3)
                    this.byte_30[index3 + 12] = (byte)((uint)this.byte_40[index3 + num] + (uint)this.byte_42);
                try
                {
                    this.udpClient_0.Send(this.byte_30, 1040, this.string_9[index2], 5000);
                }
                catch
                {
                }
            }
            this.class2_1.method_1();
            while (this.class2_1.method_2() < 0.0015)
                this.class2_1.method_1();
        }
        if (c.int_2 > 100)
        {
            for (int index = 0; index < this.int_32; ++index)
            {
                this.byte_31[0] = (byte)170;
                this.byte_31[1] = (byte)((uint)this.byte_29 | 160U);
                this.byte_31[2] = (byte)c.int_2;
                this.byte_31[3] = c.byte_20;
                try
                {
                    this.udpClient_0.Send(this.byte_31, 5, this.string_9[index], 5000);
                }
                catch
                {
                }
            }
        }
        else
        {
            for (int index = 0; index < this.int_32; ++index)
            {
                try
                {
                    this.udpClient_0.Send(this.byte_17, 65, this.string_9[index], 5000);
                }
                catch
                {
                }
            }
        }
    }

    private void method_61()
    {
        for (int index1 = 0; index1 < 24; ++index1)
        {
            this.class2_1.method_0();
            for (int index2 = 0; index2 < this.int_32; ++index2)
            {
                this.byte_30[0] = (byte)136;
                this.byte_30[1] = (byte)index1;
                for (int index3 = 0; index3 < 1024; ++index3)
                    this.byte_30[index3 + 12] = this.byte_41;
                try
                {
                    this.udpClient_0.Send(this.byte_30, 1040, this.string_9[index2], 5000);
                }
                catch
                {
                }
            }
            this.class2_1.method_1();
            while (this.class2_1.method_2() < 0.0015)
                this.class2_1.method_1();
        }
        this.byte_31[0] = (byte)170;
        switch (c.int_2)
        {
            case 101:
                this.byte_31[1] = (byte)17;
                break;
            case 103:
                this.byte_31[1] = (byte)34;
                break;
            case 110:
                this.byte_31[1] = (byte)((uint)this.byte_29 | 160U);
                break;
        }
        this.byte_31[2] = (byte)c.int_2;
        this.byte_31[3] = c.byte_20;
        for (int index = 0; index < this.int_32; ++index)
        {
            try
            {
                this.udpClient_0.Send(this.byte_31, 5, this.string_9[index], 5000);
            }
            catch
            {
            }
        }
    }

    private void method_62()
    {
        for (int index1 = 0; index1 < 16; ++index1)
        {
            this.class2_1.method_0();
            this.byte_30[0] = (byte)136;
            this.byte_30[1] = (byte)index1;
            int num = index1 * 1024;
            for (int index2 = 0; index2 < 1024; ++index2)
                this.byte_30[index2 + 12] = (byte)((uint)this.byte_40[index2 + num] + (uint)this.byte_42);
            try
            {
                this.udpClient_0.Send(this.byte_30, 1040, this.string_9[0], 5000);
            }
            catch
            {
            }
            this.class2_1.method_1();
            while (this.class2_1.method_2() < 0.0015)
                this.class2_1.method_1();
        }
        this.byte_31[0] = (byte)170;
        this.byte_31[1] = (byte)0;
        this.byte_31[2] = (byte)c.int_2;
        this.byte_31[3] = c.byte_20;
        try
        {
            this.udpClient_0.Send(this.byte_31, 5, this.string_9[0], 5000);
        }
        catch
        {
        }
    }

    private void menuItem_34_Click(object sender, EventArgs e)
    {
        this.bool_50 = false;
        this.bool_37 = false;
        this.timer_1.Interval = 1000 / c.smethod_0();
        this.timer_1.Enabled = false;
        this.bool_27 = false;
        this.genum1_1 = GEnum1.const_6;
        this.method_31();
        this.trackBar_0.Enabled = false;
        this.bufferedStream_2.Flush();
        this.bufferedStream_2.Close();
        this.fileStream_2.Close();
        this.bufferedStream_1.Flush();
        this.bufferedStream_1.Close();
        this.fileStream_1.Close();
        this.k_0.Hide();
        this.timer_0.Enabled = false;
        this.bool_31 = false;
        this.menuItem_39.Enabled = false;
        this.menuItem_40.Enabled = false;
        this.menuItem_33.Enabled = true;
        this.menuItem_34.Enabled = false;
        this.method_31();
        this.int_22 = 5;
        this.timer_2.Enabled = true;
        if (!this.bool_11)
            return;
        this.menuItem_58_Click((object)null, (EventArgs)null);
        Thread.Sleep(1000);
        this.menuItem_58_Click((object)null, (EventArgs)null);
    }

    private void method_63()
    {
        byte[] numArray1 = new byte[3];
        switch (c.int_81)
        {
            case 0:
                numArray1[0] = (byte)0;
                numArray1[1] = (byte)1;
                numArray1[2] = (byte)2;
                break;
            case 1:
                numArray1[0] = (byte)0;
                numArray1[1] = (byte)2;
                numArray1[2] = (byte)1;
                break;
            case 2:
                numArray1[0] = (byte)1;
                numArray1[1] = (byte)0;
                numArray1[2] = (byte)2;
                break;
            case 3:
                numArray1[0] = (byte)1;
                numArray1[1] = (byte)2;
                numArray1[2] = (byte)0;
                break;
            case 4:
                numArray1[0] = (byte)2;
                numArray1[1] = (byte)0;
                numArray1[2] = (byte)1;
                break;
            case 5:
                numArray1[0] = (byte)2;
                numArray1[1] = (byte)1;
                numArray1[2] = (byte)0;
                break;
            default:
                numArray1[0] = (byte)0;
                numArray1[1] = (byte)1;
                numArray1[2] = (byte)2;
                break;
        }
        this.class2_0.method_0();
        byte[] numArray2 = new byte[8];
        byte[] numArray3 = new byte[8];
        int index1 = 0;
        for (int index2 = 0; index2 < this.int_32; ++index2)
        {
            for (int int_94 = 0; int_94 < this.int_82; ++int_94)
            {
                byte index3 = 0;
                for (int int_93 = index2 * c.int_75; int_93 < (index2 + 1) * c.int_75; ++int_93)
                {
                    byte index4 = this.method_41(int_93, int_94, (int)numArray1[0]);
                    byte num1 = c.byte_21[(int)index4];
                    byte index5 = this.method_41(int_93, int_94, (int)numArray1[1]);
                    byte num2 = c.byte_22[(int)index5];
                    byte index6 = this.method_41(int_93, int_94, (int)numArray1[2]);
                    byte num3 = c.byte_23[(int)index6];
                    numArray2[(int)index3] = (byte)((128 | (int)num1 >> 1) & 252 | (int)num2 >> 6);
                    numArray3[(int)index3] = (byte)((int)num2 << 2 & 224 | (int)num3 >> 3);
                    ++index3;
                }
                for (int index7 = 0; index7 < 8; ++index7)
                {
                    this.byte_40[index1] = numArray2[index7];
                    ++index1;
                }
                for (int index8 = 0; index8 < 8; ++index8)
                {
                    this.byte_40[index1] = numArray3[index8];
                    ++index1;
                }
            }
        }
        this.class2_0.method_1();
    }

    private void method_64()
    {
        byte[] numArray = new byte[3];
        switch (c.int_81)
        {
            case 0:
                numArray[0] = (byte)0;
                numArray[1] = (byte)1;
                numArray[2] = (byte)2;
                break;
            case 1:
                numArray[0] = (byte)0;
                numArray[1] = (byte)2;
                numArray[2] = (byte)1;
                break;
            case 2:
                numArray[0] = (byte)1;
                numArray[1] = (byte)0;
                numArray[2] = (byte)2;
                break;
            case 3:
                numArray[0] = (byte)1;
                numArray[1] = (byte)2;
                numArray[2] = (byte)0;
                break;
            case 4:
                numArray[0] = (byte)2;
                numArray[1] = (byte)0;
                numArray[2] = (byte)1;
                break;
            case 5:
                numArray[0] = (byte)2;
                numArray[1] = (byte)1;
                numArray[2] = (byte)0;
                break;
            default:
                numArray[0] = (byte)0;
                numArray[1] = (byte)1;
                numArray[2] = (byte)2;
                break;
        }
        this.class2_0.method_0();
        byte num1 = 1;
        int index1 = 0;
        for (int index2 = 0; index2 < this.int_32; ++index2)
        {
            for (int int_94 = 0; int_94 < this.int_82; ++int_94)
            {
                this.byte_40[index1] = byte.MaxValue;
                ++index1;
                for (int index3 = 7; index3 > 2; --index3)
                {
                    byte num2 = 0;
                    for (int int_93 = index2 * c.int_75; int_93 < (index2 + 1) * c.int_75; ++int_93)
                    {
                        byte index4 = this.method_41(int_93, int_94, (int)numArray[0]);
                        if ((byte)((uint)c.byte_21[(int)index4] & (uint)num1 << index3) != (byte)0)
                            num2 |= (byte)((uint)num1 << int_93 % c.int_75);
                    }
                    this.byte_40[index1] = num2;
                    ++index1;
                }
                for (int index5 = 7; index5 > 2; --index5)
                {
                    byte num3 = 0;
                    for (int int_93 = index2 * c.int_75; int_93 < (index2 + 1) * c.int_75; ++int_93)
                    {
                        byte index6 = this.method_41(int_93, int_94, (int)numArray[1]);
                        if ((byte)((uint)c.byte_22[(int)index6] & (uint)num1 << index5) != (byte)0)
                            num3 |= (byte)((uint)num1 << int_93 % c.int_75);
                    }
                    this.byte_40[index1] = num3;
                    ++index1;
                }
                for (int index7 = 7; index7 > 2; --index7)
                {
                    byte num4 = 0;
                    for (int int_93 = index2 * c.int_75; int_93 < (index2 + 1) * c.int_75; ++int_93)
                    {
                        byte index8 = this.method_41(int_93, int_94, (int)numArray[2]);
                        if ((byte)((uint)c.byte_23[(int)index8] & (uint)num1 << index7) != (byte)0)
                            num4 |= (byte)((uint)num1 << int_93 % c.int_75);
                    }
                    this.byte_40[index1] = num4;
                    ++index1;
                }
            }
        }
        this.class2_0.method_1();
    }

    private void method_65()
    {
        byte[] numArray = new byte[3];
        switch (c.int_81)
        {
            case 0:
                numArray[0] = (byte)0;
                numArray[1] = (byte)1;
                numArray[2] = (byte)2;
                break;
            case 1:
                numArray[0] = (byte)0;
                numArray[1] = (byte)2;
                numArray[2] = (byte)1;
                break;
            case 2:
                numArray[0] = (byte)1;
                numArray[1] = (byte)0;
                numArray[2] = (byte)2;
                break;
            case 3:
                numArray[0] = (byte)1;
                numArray[1] = (byte)2;
                numArray[2] = (byte)0;
                break;
            case 4:
                numArray[0] = (byte)2;
                numArray[1] = (byte)0;
                numArray[2] = (byte)1;
                break;
            case 5:
                numArray[0] = (byte)2;
                numArray[1] = (byte)1;
                numArray[2] = (byte)0;
                break;
            default:
                numArray[0] = (byte)0;
                numArray[1] = (byte)1;
                numArray[2] = (byte)2;
                break;
        }
        this.class2_0.method_0();
        int index1 = 0;
        for (int index2 = 0; index2 < this.int_32; ++index2)
        {
            if (c.bool_14)
            {
                int num1;
                if (c.byte_19 == (byte)3)
                {
                    int num2 = this.int_82 % 6;
                    num1 = num2 + 1;
                    index1 = num2 * 24;
                }
                else
                    num1 = 1;
                for (int index3 = this.int_82 - num1; index3 >= 0; --index3)
                {
                    int int_94;
                    switch (c.byte_19)
                    {
                        case 2:
                            int_94 = index3 / 4 * 4 + (3 - index3 % 4);
                            break;
                        case 3:
                            int_94 = index3 / 6 * 6 + (5 - index3 % 6);
                            break;
                        default:
                            int_94 = index3;
                            break;
                    }
                    for (int int_93 = index2 * c.int_75; int_93 < (index2 + 1) * c.int_75; ++int_93)
                    {
                        byte index4 = this.method_41(int_93, int_94, (int)numArray[0]);
                        byte num3 = c.byte_21[(int)index4];
                        this.byte_40[index1] = num3;
                        ++index1;
                    }
                    for (int int_93 = index2 * c.int_75; int_93 < (index2 + 1) * c.int_75; ++int_93)
                    {
                        byte index5 = this.method_41(int_93, int_94, (int)numArray[1]);
                        byte num4 = c.byte_22[(int)index5];
                        this.byte_40[index1] = num4;
                        ++index1;
                    }
                    for (int int_93 = index2 * c.int_75; int_93 < (index2 + 1) * c.int_75; ++int_93)
                    {
                        byte index6 = this.method_41(int_93, int_94, (int)numArray[2]);
                        byte num5 = c.byte_23[(int)index6];
                        this.byte_40[index1] = num5;
                        ++index1;
                    }
                }
            }
            else
            {
                for (int int_94 = 0; int_94 < this.int_82; ++int_94)
                {
                    for (int int_93 = index2 * c.int_75; int_93 < (index2 + 1) * c.int_75; ++int_93)
                    {
                        byte index7 = this.method_41(int_93, int_94, (int)numArray[0]);
                        byte num = c.byte_21[(int)index7];
                        this.byte_40[index1] = num;
                        ++index1;
                    }
                    for (int int_93 = index2 * c.int_75; int_93 < (index2 + 1) * c.int_75; ++int_93)
                    {
                        byte index8 = this.method_41(int_93, int_94, (int)numArray[1]);
                        byte num = c.byte_22[(int)index8];
                        this.byte_40[index1] = num;
                        ++index1;
                    }
                    for (int int_93 = index2 * c.int_75; int_93 < (index2 + 1) * c.int_75; ++int_93)
                    {
                        byte index9 = this.method_41(int_93, int_94, (int)numArray[2]);
                        byte num = c.byte_23[(int)index9];
                        this.byte_40[index1] = num;
                        ++index1;
                    }
                }
            }
        }
        this.class2_0.method_1();
    }

    private void method_66()
    {
        byte[] numArray = new byte[3];
        switch (c.int_81)
        {
            case 0:
                numArray[0] = (byte)0;
                numArray[1] = (byte)1;
                numArray[2] = (byte)2;
                break;
            case 1:
                numArray[0] = (byte)0;
                numArray[1] = (byte)2;
                numArray[2] = (byte)1;
                break;
            case 2:
                numArray[0] = (byte)1;
                numArray[1] = (byte)0;
                numArray[2] = (byte)2;
                break;
            case 3:
                numArray[0] = (byte)1;
                numArray[1] = (byte)2;
                numArray[2] = (byte)0;
                break;
            case 4:
                numArray[0] = (byte)2;
                numArray[1] = (byte)0;
                numArray[2] = (byte)1;
                break;
            case 5:
                numArray[0] = (byte)2;
                numArray[1] = (byte)1;
                numArray[2] = (byte)0;
                break;
            default:
                numArray[0] = (byte)0;
                numArray[1] = (byte)1;
                numArray[2] = (byte)2;
                break;
        }
        this.class2_0.method_0();
        byte num1 = 1;
        int index1 = 0;
        for (int index2 = 0; index2 < this.int_32; ++index2)
        {
            if (c.bool_14)
            {
                int num2;
                if (c.byte_19 == (byte)3)
                {
                    int num3 = this.int_82 % 6;
                    num2 = num3 + 1;
                    index1 = num3 * 24;
                }
                else
                    num2 = 1;
                for (int index3 = this.int_82 - num2; index3 >= 0; --index3)
                {
                    int int_94;
                    switch (c.byte_19)
                    {
                        case 2:
                            int_94 = index3 / 4 * 4 + (3 - index3 % 4);
                            break;
                        case 3:
                            int_94 = index3 / 6 * 6 + (5 - index3 % 6);
                            break;
                        default:
                            int_94 = index3;
                            break;
                    }
                    for (int index4 = 7; index4 >= 0; --index4)
                    {
                        byte num4 = 0;
                        for (int int_93 = index2 * c.int_75; int_93 < (index2 + 1) * c.int_75; ++int_93)
                        {
                            byte index5 = this.method_41(int_93, int_94, (int)numArray[0]);
                            if ((byte)((uint)c.byte_21[(int)index5] & (uint)num1 << index4) != (byte)0)
                                num4 |= (byte)((uint)num1 << int_93 % c.int_75);
                        }
                        this.byte_40[index1] = num4;
                        ++index1;
                    }
                    for (int index6 = 7; index6 >= 0; --index6)
                    {
                        byte num5 = 0;
                        for (int int_93 = index2 * c.int_75; int_93 < (index2 + 1) * c.int_75; ++int_93)
                        {
                            byte index7 = this.method_41(int_93, int_94, (int)numArray[1]);
                            if ((byte)((uint)c.byte_22[(int)index7] & (uint)num1 << index6) != (byte)0)
                                num5 |= (byte)((uint)num1 << int_93 % c.int_75);
                        }
                        this.byte_40[index1] = num5;
                        ++index1;
                    }
                    for (int index8 = 7; index8 >= 0; --index8)
                    {
                        byte num6 = 0;
                        for (int int_93 = index2 * c.int_75; int_93 < (index2 + 1) * c.int_75; ++int_93)
                        {
                            byte index9 = this.method_41(int_93, int_94, (int)numArray[2]);
                            if ((byte)((uint)c.byte_23[(int)index9] & (uint)num1 << index8) != (byte)0)
                                num6 |= (byte)((uint)num1 << int_93 % c.int_75);
                        }
                        this.byte_40[index1] = num6;
                        ++index1;
                    }
                }
            }
            else
            {
                for (int int_94 = 0; int_94 < this.int_82; ++int_94)
                {
                    for (int index10 = 7; index10 >= 0; --index10)
                    {
                        byte num7 = 0;
                        for (int int_93 = index2 * c.int_75; int_93 < (index2 + 1) * c.int_75; ++int_93)
                        {
                            byte index11 = this.method_41(int_93, int_94, (int)numArray[0]);
                            if ((byte)((uint)c.byte_21[(int)index11] & (uint)num1 << index10) != (byte)0)
                                num7 |= (byte)((uint)num1 << int_93 % c.int_75);
                        }
                        this.byte_40[index1] = num7;
                        ++index1;
                    }
                    for (int index12 = 7; index12 >= 0; --index12)
                    {
                        byte num8 = 0;
                        for (int int_93 = index2 * c.int_75; int_93 < (index2 + 1) * c.int_75; ++int_93)
                        {
                            byte index13 = this.method_41(int_93, int_94, (int)numArray[1]);
                            if ((byte)((uint)c.byte_22[(int)index13] & (uint)num1 << index12) != (byte)0)
                                num8 |= (byte)((uint)num1 << int_93 % c.int_75);
                        }
                        this.byte_40[index1] = num8;
                        ++index1;
                    }
                    for (int index14 = 7; index14 >= 0; --index14)
                    {
                        byte num9 = 0;
                        for (int int_93 = index2 * c.int_75; int_93 < (index2 + 1) * c.int_75; ++int_93)
                        {
                            byte index15 = this.method_41(int_93, int_94, (int)numArray[2]);
                            if ((byte)((uint)c.byte_23[(int)index15] & (uint)num1 << index14) != (byte)0)
                                num9 |= (byte)((uint)num1 << int_93 % c.int_75);
                        }
                        this.byte_40[index1] = num9;
                        ++index1;
                    }
                }
            }
        }
        this.class2_0.method_1();
    }

    private void method_67()
    {
        byte[] numArray = new byte[3];
        switch (c.int_81)
        {
            case 0:
                numArray[0] = (byte)0;
                numArray[1] = (byte)1;
                numArray[2] = (byte)2;
                break;
            case 1:
                numArray[0] = (byte)0;
                numArray[1] = (byte)2;
                numArray[2] = (byte)1;
                break;
            case 2:
                numArray[0] = (byte)1;
                numArray[1] = (byte)0;
                numArray[2] = (byte)2;
                break;
            case 3:
                numArray[0] = (byte)1;
                numArray[1] = (byte)2;
                numArray[2] = (byte)0;
                break;
            case 4:
                numArray[0] = (byte)2;
                numArray[1] = (byte)0;
                numArray[2] = (byte)1;
                break;
            case 5:
                numArray[0] = (byte)2;
                numArray[1] = (byte)1;
                numArray[2] = (byte)0;
                break;
            default:
                numArray[0] = (byte)0;
                numArray[1] = (byte)1;
                numArray[2] = (byte)2;
                break;
        }
        byte num1 = 1;
        this.class2_0.method_0();
        int index1 = 0;
        for (int index2 = 0; index2 < this.int_32; ++index2)
        {
            for (int int_94 = 0; int_94 < this.int_82; ++int_94)
            {
                for (int index3 = 7; index3 >= 0; --index3)
                {
                    byte num2 = 0;
                    for (int int_93 = index2 * c.int_75; int_93 < (index2 + 1) * c.int_75; ++int_93)
                    {
                        byte index4 = this.method_41(int_93, int_94, (int)numArray[0]);
                        if ((byte)((uint)c.byte_21[(int)index4] & (uint)num1 << index3) != (byte)0)
                            num2 |= (byte)((uint)num1 << int_93 % c.int_75);
                    }
                    this.byte_40[index1] = num2;
                    ++index1;
                }
                for (int index5 = 7; index5 >= 0; --index5)
                {
                    byte num3 = 0;
                    for (int int_93 = index2 * c.int_75; int_93 < (index2 + 1) * c.int_75; ++int_93)
                    {
                        byte index6 = this.method_41(int_93, int_94, (int)numArray[1]);
                        if ((byte)((uint)c.byte_22[(int)index6] & (uint)num1 << index5) != (byte)0)
                            num3 |= (byte)((uint)num1 << int_93 % c.int_75);
                    }
                    this.byte_40[index1] = num3;
                    ++index1;
                }
                for (int index7 = 7; index7 >= 0; --index7)
                {
                    byte num4 = 0;
                    for (int int_93 = index2 * c.int_75; int_93 < (index2 + 1) * c.int_75; ++int_93)
                    {
                        byte index8 = this.method_41(int_93, int_94, (int)numArray[2]);
                        if ((byte)((uint)c.byte_23[(int)index8] & (uint)num1 << index7) != (byte)0)
                            num4 |= (byte)((uint)num1 << int_93 % c.int_75);
                    }
                    this.byte_40[index1] = num4;
                    ++index1;
                }
            }
        }
        this.class2_0.method_1();
    }

    private void method_68()
    {
        byte[] numArray = new byte[3];
        switch (c.int_81)
        {
            case 0:
                numArray[0] = (byte)0;
                numArray[1] = (byte)1;
                numArray[2] = (byte)2;
                break;
            case 1:
                numArray[0] = (byte)0;
                numArray[1] = (byte)2;
                numArray[2] = (byte)1;
                break;
            case 2:
                numArray[0] = (byte)1;
                numArray[1] = (byte)0;
                numArray[2] = (byte)2;
                break;
            case 3:
                numArray[0] = (byte)1;
                numArray[1] = (byte)2;
                numArray[2] = (byte)0;
                break;
            case 4:
                numArray[0] = (byte)2;
                numArray[1] = (byte)0;
                numArray[2] = (byte)1;
                break;
            case 5:
                numArray[0] = (byte)2;
                numArray[1] = (byte)1;
                numArray[2] = (byte)0;
                break;
            default:
                numArray[0] = (byte)0;
                numArray[1] = (byte)1;
                numArray[2] = (byte)2;
                break;
        }
        byte num1 = 1;
        int index1 = 0;
        for (int index2 = 0; index2 < this.int_32; ++index2)
        {
            if (c.bool_1)
                index1 = index2 * 4096;
            for (int int_94 = 0; int_94 < this.int_82; ++int_94)
            {
                for (int index3 = 0; index3 < 8; ++index3)
                {
                    byte num2 = 0;
                    for (int int_93 = index2 * c.int_75; int_93 < (index2 + 1) * c.int_75; ++int_93)
                    {
                        byte index4 = this.method_41(int_93, int_94, (int)numArray[0]);
                        if ((byte)((uint)c.byte_21[(int)index4] & (uint)num1 << index3) != (byte)0)
                            num2 |= (byte)((uint)num1 << int_93 % c.int_75);
                    }
                    this.byte_40[index1] = num2;
                    ++index1;
                }
                for (int index5 = 0; index5 < 8; ++index5)
                {
                    byte num3 = 0;
                    for (int int_93 = index2 * c.int_75; int_93 < (index2 + 1) * c.int_75; ++int_93)
                    {
                        byte index6 = this.method_41(int_93, int_94, (int)numArray[1]);
                        if ((byte)((uint)c.byte_22[(int)index6] & (uint)num1 << index5) != (byte)0)
                            num3 |= (byte)((uint)num1 << int_93 % c.int_75);
                    }
                    this.byte_40[index1] = num3;
                    ++index1;
                }
                for (int index7 = 0; index7 < 8; ++index7)
                {
                    byte num4 = 0;
                    for (int int_93 = index2 * c.int_75; int_93 < (index2 + 1) * c.int_75; ++int_93)
                    {
                        byte index8 = this.method_41(int_93, int_94, (int)numArray[2]);
                        if ((byte)((uint)c.byte_23[(int)index8] & (uint)num1 << index7) != (byte)0)
                            num4 |= (byte)((uint)num1 << int_93 % c.int_75);
                    }
                    this.byte_40[index1] = num4;
                    ++index1;
                }
            }
        }
    }

    private void method_69()
    {
    }

    private void method_70()
    {
        byte[] numArray = new byte[3];
        if (c.int_2 != 3 && c.int_2 != 101)
            return;
        switch (c.int_81)
        {
            case 0:
                numArray[0] = (byte)2;
                numArray[1] = (byte)1;
                numArray[2] = (byte)0;
                break;
            case 1:
                numArray[0] = (byte)1;
                numArray[1] = (byte)2;
                numArray[2] = (byte)0;
                break;
            case 2:
                numArray[0] = (byte)2;
                numArray[1] = (byte)0;
                numArray[2] = (byte)1;
                break;
            case 3:
                numArray[0] = (byte)0;
                numArray[1] = (byte)2;
                numArray[2] = (byte)1;
                break;
            case 4:
                numArray[0] = (byte)1;
                numArray[1] = (byte)0;
                numArray[2] = (byte)2;
                break;
            case 5:
                numArray[0] = (byte)0;
                numArray[1] = (byte)1;
                numArray[2] = (byte)2;
                break;
            default:
                numArray[0] = (byte)2;
                numArray[1] = (byte)1;
                numArray[2] = (byte)0;
                break;
        }
        int num1 = c.int_8 + c.int_9 + c.int_10 + 3;
        int num2 = (768 - (int)c.byte_0) / num1;
        int num3 = (768 - (int)c.byte_0) % num1;
        byte num4 = 1;
        this.class2_0.method_0();
        int num5 = 0;
        for (int index1 = 0; index1 < this.int_32; ++index1)
        {
            for (int index2 = 0; index2 < 8; ++index2)
            {
                int num6 = num5 + num3;
                for (int int_94 = num2 - 1; int_94 >= 0; --int_94)
                {
                    byte num7 = 0;
                    byte num8 = 0;
                    byte num9 = 0;
                    int index3 = num6 + c.int_10;
                    for (int int_93 = index1 * c.int_75; int_93 < (index1 + 1) * c.int_75; ++int_93)
                    {
                        byte index4 = this.method_41(int_93, int_94, (int)numArray[0]);
                        if ((byte)((uint)c.byte_21[(int)index4] & (uint)num4 << index2) != (byte)0)
                            num7 |= (byte)((uint)num4 << int_93 % c.int_75);
                    }
                    this.byte_40[index3] = num7;
                    int index5 = index3 + 1 + c.int_9;
                    for (int int_93 = index1 * c.int_75; int_93 < (index1 + 1) * c.int_75; ++int_93)
                    {
                        byte index6 = this.method_41(int_93, int_94, (int)numArray[1]);
                        if ((byte)((uint)c.byte_22[(int)index6] & (uint)num4 << index2) != (byte)0)
                            num8 |= (byte)((uint)num4 << int_93 % c.int_75);
                    }
                    this.byte_40[index5] = num8;
                    int index7 = index5 + 1 + c.int_8;
                    for (int int_93 = index1 * c.int_75; int_93 < (index1 + 1) * c.int_75; ++int_93)
                    {
                        byte index8 = this.method_41(int_93, int_94, (int)numArray[2]);
                        if ((byte)((uint)c.byte_23[(int)index8] & (uint)num4 << index2) != (byte)0)
                            num9 |= (byte)((uint)num4 << int_93 % c.int_75);
                    }
                    this.byte_40[index7] = num9;
                    num6 = index7 + 1;
                }
                num5 = num6 + (int)c.byte_0;
            }
        }
        this.class2_0.method_1();
    }

    private void method_71()
    {
        byte[] numArray = new byte[3];
        if (c.int_2 != 103)
            return;
        switch (c.int_81)
        {
            case 0:
                numArray[0] = (byte)2;
                numArray[1] = (byte)1;
                numArray[2] = (byte)0;
                break;
            case 1:
                numArray[0] = (byte)1;
                numArray[1] = (byte)2;
                numArray[2] = (byte)0;
                break;
            case 2:
                numArray[0] = (byte)2;
                numArray[1] = (byte)0;
                numArray[2] = (byte)1;
                break;
            case 3:
                numArray[0] = (byte)0;
                numArray[1] = (byte)2;
                numArray[2] = (byte)1;
                break;
            case 4:
                numArray[0] = (byte)1;
                numArray[1] = (byte)0;
                numArray[2] = (byte)2;
                break;
            case 5:
                numArray[0] = (byte)0;
                numArray[1] = (byte)1;
                numArray[2] = (byte)2;
                break;
            default:
                numArray[0] = (byte)2;
                numArray[1] = (byte)1;
                numArray[2] = (byte)0;
                break;
        }
        int num1 = c.int_8 + c.int_9 + c.int_10 + 3;
        int num2 = (1536 - (int)c.byte_0) / num1;
        int num3 = (1536 - (int)c.byte_0) % num1;
        byte num4 = 1;
        this.class2_0.method_0();
        int num5 = 0;
        for (int index1 = 0; index1 < this.int_32; ++index1)
        {
            for (int index2 = 4; index2 < 8; ++index2)
            {
                int num6 = num5 + num3;
                for (int int_94 = num2 - 1; int_94 >= 0; --int_94)
                {
                    byte num7 = 0;
                    byte num8 = 0;
                    byte num9 = 0;
                    int index3 = num6 + c.int_10;
                    for (int int_93 = index1 * c.int_75; int_93 < (index1 + 1) * c.int_75; ++int_93)
                    {
                        byte index4 = this.method_41(int_93, int_94, (int)numArray[0]);
                        if ((byte)((uint)c.byte_23[(int)index4] & (uint)num4 << index2) != (byte)0)
                            num7 |= (byte)((uint)num4 << int_93 % c.int_75);
                    }
                    this.byte_40[index3] = num7;
                    int index5 = index3 + 1 + c.int_9;
                    for (int int_93 = index1 * c.int_75; int_93 < (index1 + 1) * c.int_75; ++int_93)
                    {
                        byte index6 = this.method_41(int_93, int_94, (int)numArray[1]);
                        if ((byte)((uint)c.byte_22[(int)index6] & (uint)num4 << index2) != (byte)0)
                            num8 |= (byte)((uint)num4 << int_93 % c.int_75);
                    }
                    this.byte_40[index5] = num8;
                    int index7 = index5 + 1 + c.int_8;
                    for (int int_93 = index1 * c.int_75; int_93 < (index1 + 1) * c.int_75; ++int_93)
                    {
                        byte index8 = this.method_41(int_93, int_94, (int)numArray[2]);
                        if ((byte)((uint)c.byte_21[(int)index8] & (uint)num4 << index2) != (byte)0)
                            num9 |= (byte)((uint)num4 << int_93 % c.int_75);
                    }
                    this.byte_40[index7] = num9;
                    num6 = index7 + 1;
                }
                num5 = num6 + (int)c.byte_0;
            }
        }
        this.class2_0.method_1();
    }

    private void method_72()
    {
        int int_0 = 0;
        this.bool_8 = true;
        this.int_31 = (int)byte.MaxValue;
        this.timer_1.Interval = 1000 / c.smethod_0();
        this.int_32 = this.int_23 / c.int_75;
        this.gclass4_0 = new GClass4[this.int_32, 8];
        for (int index = 0; index < this.int_32; ++index)
        {
            this.gclass4_0[index, 0] = new GClass4();
            this.gclass4_0[index, 1] = new GClass4();
            this.gclass4_0[index, 2] = new GClass4();
            this.gclass4_0[index, 3] = new GClass4();
            this.gclass4_0[index, 4] = new GClass4();
            this.gclass4_0[index, 5] = new GClass4();
            this.gclass4_0[index, 6] = new GClass4();
            this.gclass4_0[index, 7] = new GClass4();
        }
        for (int index1 = 0; index1 < this.arrayList_3.Count; ++index1)
        {
            int num = ((GClass8)this.arrayList_3[index1]).method_4();
            int index2 = num / 8;
            int index3 = num % 8;
            this.gclass4_0[index2, index3].bool_0 = true;
            this.gclass4_0[index2, index3].int_0 = ((GClass8)this.arrayList_3[index1]).method_0();
        }
        this.int_30 = new int[this.int_32];
        for (int index = 0; index < this.int_32; ++index)
            this.int_30[index] = 0;
        this.string_9 = new string[this.int_32];
        for (int index = 0; index < this.int_32; ++index)
        {
            int num = 50 + index;
            this.string_9[index] = Module.a("鞥醧颩芫龭蚯誱骳肵袷钹", int_0) + num.ToString();
        }
        if (c.int_2 == 180)
        {
            this.byte_39 = new byte[10];
            new Random().NextBytes(this.byte_39);
            byte num = 0;
            byte[] numArray = new byte[10]
            {
        (byte) 59,
        (byte) 129,
        (byte) 197,
        (byte) 228,
        (byte) 81,
        (byte) 208,
        (byte) 127,
        (byte) 42,
        (byte) 54,
        (byte) 199
            };
            this.byte_31[0] = (byte)204;
            this.byte_31[1] = (byte)85;
            for (int index = 0; index < 10; ++index)
            {
                num += (byte)((uint)this.byte_39[index] ^ (uint)numArray[index]);
                this.byte_31[index + 2] = this.byte_39[index];
            }
            this.byte_42 = (byte)((uint)num ^ 90U);
        }
        else
        {
            this.byte_39 = new byte[10];
            new Random().NextBytes(this.byte_39);
            byte num = 0;
            byte[] numArray = new byte[10]
            {
        (byte) 59,
        (byte) 129,
        (byte) 197,
        (byte) 228,
        (byte) 81,
        (byte) 208,
        (byte) 127,
        (byte) 174,
        (byte) 99,
        (byte) 41
            };
            for (int index = 0; index < 10; ++index)
            {
                num += (byte)((uint)this.byte_39[index] ^ (uint)numArray[index]);
                this.byte_30[index + 2] = this.byte_39[index];
            }
            this.byte_42 = (byte)((uint)num ^ 90U);
            this.byte_41 = this.byte_42;
            this.bool_30 = true;
            this.genum1_0 = this.genum1_1;
            this.genum1_1 = GEnum1.const_9;
            this.byte_35[0] = (byte)197;
            this.byte_35[1] = (byte)119;
            this.byte_35[2] = (byte)136;
            try
            {
                this.udpClient_0.Send(this.byte_35, 5, Module.a("鞥醧颩芫龭蚯誱骳肵袷钹覻躽", int_0), 5000);
            }
            catch
            {
            }
            this.timer_0.Enabled = true;
            this.method_39();
        }
    }

    private void menuItem_36_Click(object sender, EventArgs e)
    {
        int int_0 = 14;
        this.int_31 = (int)byte.MaxValue;
        if ((c.string_7 == Module.a("\uE0B3蝹\uEBB7骹\uEABB讽\uEDBF迁", 14) || c.string_7 == Module.a("\uF7B3쎵쪷캹\uDDBBힽ꺿\uE2C1鋃\uF3C5", int_0)) && c.smethod_0() > 20)
            c.smethod_1(20);
        this.timer_1.Interval = 1000 / c.smethod_0();
        if (this.bool_39)
            this.d_0.Hide();
        if (c.int_2 == 101 || c.int_2 == 102 || c.int_2 == 120 || c.int_2 == 201 || c.int_2 == 110 || c.int_2 == 150)
        {
            switch (c.int_81)
            {
                case 0:
                    this.toolStripTextBox_2.Text = Module.a("\uE6B3\uF1B5覆", int_0);
                    break;
                case 1:
                    this.toolStripTextBox_2.Text = Module.a("\uE6B3\uF4B5ﾷ", int_0);
                    break;
                case 2:
                    this.toolStripTextBox_2.Text = Module.a("\uF3B3\uE4B5覆", int_0);
                    break;
                case 3:
                    this.toolStripTextBox_2.Text = Module.a("\uF3B3\uF4B5\uEAB7", int_0);
                    break;
                case 4:
                    this.toolStripTextBox_2.Text = Module.a("\uF6B3\uE4B5ﾷ", int_0);
                    break;
                case 5:
                    this.toolStripTextBox_2.Text = Module.a("\uF6B3\uF1B5\uEAB7", int_0);
                    break;
                default:
                    this.toolStripTextBox_2.Text = Module.a("\uE6B3\uF1B5覆", int_0);
                    break;
            }
        }
        if (this.bool_39)
            this.d_0.Show();
        this.int_32 = this.int_23 / c.int_75;
        if (c.int_2 == 201)
            this.int_32 = 1;
        this.int_30 = new int[this.int_32];
        for (int index = 0; index < this.int_32; ++index)
            this.int_30[index] = 0;
        this.string_9 = new string[this.int_32];
        for (int index = 0; index < this.int_32; ++index)
        {
            int num = 50 + index;
            this.string_9[index] = Module.a("薳辵誷钹趻袽\uF8BF\uECC1\uF2C3\uF6C5\uE6C7", int_0) + num.ToString();
        }
        this.byte_39 = new byte[10];
        new Random().NextBytes(this.byte_39);
        byte num1 = 0;
        byte[] numArray = new byte[10]
        {
      (byte) 59,
      (byte) 129,
      (byte) 197,
      (byte) 228,
      (byte) 81,
      (byte) 208,
      (byte) 127,
      (byte) 174,
      (byte) 99,
      (byte) 41
        };
        for (int index = 0; index < 10; ++index)
        {
            num1 += (byte)((uint)this.byte_39[index] ^ (uint)numArray[index]);
            this.byte_30[index + 2] = this.byte_39[index];
        }
        this.byte_42 = (byte)((uint)num1 ^ 90U);
        this.byte_41 = this.byte_42;
        this.bool_30 = true;
        this.genum1_0 = this.genum1_1;
        this.genum1_1 = GEnum1.const_9;
        this.byte_35[0] = (byte)197;
        this.byte_35[1] = (byte)119;
        this.byte_35[2] = (byte)136;
        try
        {
            this.udpClient_0.Send(this.byte_35, 5, Module.a("薳辵誷钹趻袽\uF8BF\uECC1\uF2C3\uF6C5\uE6C7\uFFC9ﳋ", int_0), 5000);
        }
        catch
        {
        }
        this.k_0.Show();
        this.k_0.Location = new Point(780, 50);
        this.timer_0.Enabled = true;
        this.menuItem_9.Enabled = false;
        this.menuItem_7.Enabled = false;
        this.menuItem_37.Enabled = true;
        this.menuItem_36.Enabled = false;
        this.method_31();
        if (c.bool_51)
            this.a_0.TopMost = true;
        this.Size = new Size(780, 144);
        this.method_39();
    }

    private void method_73()
    {
        int int_0 = 8;
        this.int_31 = (int)byte.MaxValue;
        if (this.bool_39)
            this.d_0.Hide();
        if (c.int_2 == 101 || c.int_2 == 102 || c.int_2 == 120 || c.int_2 == 201 || c.int_2 == 110 || c.int_2 == 150)
        {
            switch (c.int_81)
            {
                case 0:
                    this.toolStripTextBox_2.Text = Module.a("ﲭ\uF7AF\uF0B1", int_0);
                    break;
                case 1:
                    this.toolStripTextBox_2.Text = Module.a("ﲭ\uF2AF\uF5B1", int_0);
                    break;
                case 2:
                    this.toolStripTextBox_2.Text = Module.a("\uE9AD\uE2AF\uF0B1", int_0);
                    break;
                case 3:
                    this.toolStripTextBox_2.Text = Module.a("\uE9AD\uF2AF\uE0B1", int_0);
                    break;
                case 4:
                    this.toolStripTextBox_2.Text = Module.a("\uECAD\uE2AF\uF5B1", int_0);
                    break;
                case 5:
                    this.toolStripTextBox_2.Text = Module.a("\uECAD\uF7AF\uE0B1", int_0);
                    break;
                default:
                    this.toolStripTextBox_2.Text = Module.a("ﲭ\uF7AF\uF0B1", int_0);
                    break;
            }
        }
        if (this.bool_39)
            this.d_0.Show();
        this.int_32 = this.int_23 / c.int_75;
        if (c.int_2 == 201)
            this.int_32 = 1;
        this.int_30 = new int[this.int_32];
        for (int index = 0; index < this.int_32; ++index)
            this.int_30[index] = 0;
        this.string_9 = new string[this.int_32];
        for (int index = 0; index < this.int_32; ++index)
        {
            int num = 50 + index;
            this.string_9[index] = Module.a("龭覯肱骳螵躷芹銻袽\uF0BF\uECC1", int_0) + num.ToString();
        }
        this.byte_39 = new byte[10];
        new Random().NextBytes(this.byte_39);
        byte num1 = 0;
        byte[] numArray = new byte[10]
        {
      (byte) 59,
      (byte) 129,
      (byte) 197,
      (byte) 228,
      (byte) 81,
      (byte) 208,
      (byte) 127,
      (byte) 174,
      (byte) 99,
      (byte) 41
        };
        for (int index = 0; index < 10; ++index)
        {
            num1 += (byte)((uint)this.byte_39[index] ^ (uint)numArray[index]);
            this.byte_30[index + 2] = this.byte_39[index];
        }
        this.byte_42 = (byte)((uint)num1 ^ 90U);
        this.byte_41 = this.byte_42;
        this.bool_30 = true;
        this.genum1_0 = this.genum1_1;
        this.genum1_1 = GEnum1.const_9;
        this.byte_35[0] = (byte)197;
        this.byte_35[1] = (byte)119;
        this.byte_35[2] = (byte)136;
        try
        {
            this.udpClient_0.Send(this.byte_35, 5, Module.a("龭覯肱骳螵躷芹銻袽\uF0BF\uECC1\uF1C3\uF6C5", int_0), 5000);
        }
        catch
        {
        }
        this.k_0.Show();
        this.k_0.Location = new Point(780, 50);
        this.timer_0.Enabled = true;
        this.menuItem_9.Enabled = false;
        this.menuItem_7.Enabled = false;
        this.menuItem_37.Enabled = true;
        this.menuItem_36.Enabled = false;
        this.method_31();
        this.Size = new Size(780, 144);
    }

    private void menuItem_37_Click(object sender, EventArgs e)
    {
        if (this.bool_28)
        {
            this.bool_28 = false;
            this.method_75();
        }
        this.Size = new Size(this.int_69, this.int_70);
        this.bool_30 = false;
        this.genum1_1 = this.genum1_0;
        if (this.bool_39)
        {
            this.menuItem_9.Enabled = true;
            this.menuItem_9_Click(sender, e);
        }
        else
            this.menuItem_7.Enabled = true;
        this.k_0.Hide();
        this.timer_0.Enabled = false;
        this.menuItem_37.Enabled = false;
        this.menuItem_36.Enabled = true;
        this.method_31();
        this.menuItem_7_Click(sender, e);
        this.int_22 = 5;
        this.timer_2.Enabled = true;
        this.menuItem_58_Click((object)null, (EventArgs)null);
        Thread.Sleep(1000);
        this.menuItem_58_Click((object)null, (EventArgs)null);
    }

    private void menuItem_38_Click(object sender, EventArgs e)
    {
        if (new ai().ShowDialog() != DialogResult.OK)
            return;
        this.method_26(14, c.int_78.ToString());
        this.method_13();
        if (this.genum1_1 == GEnum1.const_4 || this.genum1_1 == GEnum1.const_8)
        {
            this.d_0.ClientSize = new Size(400, 400);
            Rectangle rectangle_2 = new Rectangle(0, 0, this.d_0.ClientSize.Width, this.d_0.ClientSize.Height);
            c.gclass0_4.method_15(rectangle_2);
        }
        if (this.genum1_1 == GEnum1.const_3 || this.genum1_1 == GEnum1.const_9)
            c.i_0.ClientSize = new Size(400, 400);
        if (!this.bool_22)
            return;
        this.d_0.ClientSize = new Size(400, 400);
        Rectangle rectangle_2_1 = new Rectangle(0, 0, this.d_0.ClientSize.Width, this.d_0.ClientSize.Height);
        c.gclass0_4.method_15(rectangle_2_1);
    }

    private void menuItem_39_Click(object sender, EventArgs e)
    {
        this.bool_31 = true;
        this.menuItem_39.Enabled = false;
        this.menuItem_40.Enabled = true;
        this.method_31();
    }

    private void menuItem_40_Click(object sender, EventArgs e)
    {
        this.bool_31 = false;
        this.menuItem_39.Enabled = true;
        this.menuItem_40.Enabled = false;
        this.method_31();
    }

    private int method_74()
    {
        int int_0 = 15;
        if (this.byte_32 == null)
            return 1;
        if (this.byte_32[0] == (byte)85 && (int)this.byte_32[1] < this.int_32)
            this.int_30[(int)this.byte_32[1]] = 50;
        if (this.bool_33)
        {
            if (this.bool_26)
            {
                this.bool_34 = true;
                return 0;
            }
            if (this.byte_32[0] == (byte)176)
            {
                this.int_35 = 0;
                this.int_36 = 0;
                if (this.byte_32[1] == (byte)192)
                {
                    this.int_80 = 0;
                    this.int_34 = 1;
                }
                else if (this.byte_32[1] == (byte)195 && (int)this.byte_32[2] == (int)this.byte_36[0] && (int)this.byte_32[3] == (int)this.byte_36[1] && (int)this.byte_32[4] == (int)this.byte_36[2])
                    ++this.int_80;
                this.bufferedStream_2.Seek((long)this.int_80 * 512L, SeekOrigin.Begin);
                int num1 = this.bufferedStream_2.Read(this.byte_40, 0, 512);
                this.byte_30[0] = (byte)193;
                this.byte_30[1] = (byte)(this.int_80 / 65536);
                int num2 = this.int_80 % 65536;
                this.byte_30[2] = (byte)(num2 / 256);
                this.byte_30[3] = (byte)(num2 % 256);
                this.byte_36[0] = this.byte_30[1];
                this.byte_36[1] = this.byte_30[2];
                this.byte_36[2] = this.byte_30[3];
                int num3 = 0;
                for (int index = 0; index < 512; ++index)
                {
                    this.byte_30[index + 4] = this.byte_40[index];
                    num3 += (int)this.byte_40[index];
                }
                int num4 = num3 % 65536;
                this.byte_30[516] = (byte)(num4 / 256);
                this.byte_30[517] = (byte)(num4 % 256);
                if (num1 > 0)
                {
                    try
                    {
                        this.udpClient_0.Send(this.byte_30, 520, Module.a("蒴躶许閺貼覾燎\uEDC2\uF3C4\uF7C6\uE7C8ﻊ\uFDCC", int_0), 5000);
                    }
                    catch
                    {
                    }
                }
                else
                {
                    this.byte_30[0] = (byte)194;
                    this.byte_30[1] = (byte)170;
                    try
                    {
                        this.udpClient_0.Send(this.byte_30, 5, Module.a("蒴躶许閺貼覾燎\uEDC2\uF3C4\uF7C6\uE7C8ﻊ\uFDCC", int_0), 5000);
                    }
                    catch
                    {
                    }
                    this.string_10 = !c.useEnglishLanguage ? Module.a("뻺쨹㗣滑뱃", int_0) : Module.a("\uF1B4\uD8B6캸햺톼킾ꃀ\uA7C2\uE5C4裆뿈껊뿌츱", int_0);
                    this.bool_34 = true;
                }
            }
            else if (this.byte_32[0] == (byte)177)
            {
                this.int_35 = 0;
                this.int_36 = 0;
                if (this.byte_32[1] == (byte)195)
                {
                    this.string_10 = !c.useEnglishLanguage ? Module.a("\uE6B4\uF3B6\uD8EB뛴\uDED7蟠\uEDC0⎧Ⴈ첈둇쨵", int_0) : Module.a("\uE6B4\uF3B6馸\uF8BA\uDCBC춾ꗀ\uE3C2蓄ꗆ\uA7C8\uA4CA뿌ꋎ냐뿒倫铖룘뗚\uFDDC뇞軠韢엤ꏦ蛨鳪菬菮黰鋲釴\uF609", int_0);
                    this.bool_34 = true;
                }
            }
        }
        this.byte_32[0] = (byte)0;
        this.byte_32[1] = (byte)0;
        return 0;
    }

    private void timer_0_Tick(object sender, EventArgs e)
    {
        int int_0 = 2;
        this.timer_0.Enabled = false;
        int num1 = 0;
        int num2 = 0;
        IPEndPoint remoteEP = (IPEndPoint)null;
        bool flag = false;
        do
        {
            do
            {
                try
                {
                    this.byte_32 = this.udpClient_0.Receive(ref remoteEP);
                }
                catch
                {
                    flag = true;
                }
                if (this.bool_33 && this.int_36 > 3)
                {
                    this.int_36 = 0;
                    if (this.int_34 == 0)
                    {
                        this.byte_35[0] = (byte)192;
                        this.byte_35[1] = (byte)119;
                        this.byte_35[2] = (byte)136;
                        try
                        {
                            this.udpClient_0.Send(this.byte_35, 5, Module.a("馧鎩麫肭膯蒱貳颵躷誹銻讽\uF0BF", int_0), 5000);
                        }
                        catch
                        {
                        }
                    }
                    else
                    {
                        this.byte_32 = new byte[10];
                        this.byte_32[0] = (byte)176;
                        this.byte_32[1] = (byte)195;
                        this.byte_32[2] = byte.MaxValue;
                        this.byte_32[3] = byte.MaxValue;
                        this.byte_32[4] = byte.MaxValue;
                    }
                }
                if (this.method_74() != 0)
                    flag = true;
            }
            while (!flag);
            ++num2;
            if (!this.bool_33 || this.bool_34 || this.int_80 % 40 == 39)
                break;
        }
        while (num2 < 100);
        if (this.genum1_1 == GEnum1.const_0)
            return;
        if (this.genum1_1 == GEnum1.const_8 || this.genum1_1 == GEnum1.const_9)
        {
            for (int index = 0; index < this.int_32; ++index)
            {
                if (this.int_30[index] > 0)
                {
                    --this.int_30[index];
                    ++num1;
                }
            }
            if (this.int_31 != num1)
            {
                this.int_31 = num1;
                this.k_0.method_1("");
                for (int index = 0; index < this.int_32; ++index)
                {
                    if (c.useEnglishLanguage)
                    {
                        if (this.int_30[index] > 0)
                        {
                            k k0 = this.k_0;
                            k0.method_1(k0.method_0() + Module.a("\uE6A7얩芫", int_0) + (index + 1).ToString() + Module.a("袧誩얫\uDDAD邯ﲱ\uDBB3쒵햷\uDBB9킻薽", int_0) + Environment.NewLine);
                        }
                        else
                        {
                            k k0 = this.k_0;
                            k0.method_1(k0.method_0() + Module.a("\uE6A7얩芫", int_0) + (index + 1).ToString() + Module.a("袧誩얫\uDDAD邯\uF3B1횳\uD8B5ힷ좹톻\uDFBD겿療", int_0) + Environment.NewLine);
                        }
                    }
                    else if (this.int_30[index] > 0)
                    {
                        k k0 = this.k_0;
                        k0.method_1(k0.method_0() + Module.a("蓜", int_0) + (index + 1).ToString() + Module.a("忴곻ை躭邯銱钳헞胩膹", int_0) + Environment.NewLine);
                    }
                    else
                    {
                        k k0 = this.k_0;
                        k0.method_1(k0.method_0() + Module.a("蓜", int_0) + (index + 1).ToString() + Module.a("忴곻ை躭邯銱钳ᯐ루膹", int_0) + Environment.NewLine);
                    }
                }
            }
        }
        if (this.bool_33 || this.bool_34)
        {
            if (c.useEnglishLanguage)
            {
                this.textBox_2.Text = Module.a("\uECA7얩\uDBAB삭ﲯ\uDDB1햳튵톷풹\uDBBB龽", int_0);
                this.textBox_1.Text = Module.a("\uE6A7얩\uDEAB쎭톯\uDEB1", int_0);
            }
            else
            {
                this.textBox_2.Text = Module.a("嫺焦짺ꗣ촠鏛믬띊", int_0);
                this.textBox_1.Text = Module.a("쯌鋷굔", int_0);
            }
            this.progressBar_0.Value = this.int_80;
            this.label_7.Text = this.int_80.ToString() + Module.a("螧", int_0) + this.progressBar_0.Maximum.ToString();
            ++this.int_36;
            this.textBox_3.Text = (this.int_35 / 10).ToString() + Module.a("\uDBA7", int_0);
            ++this.int_35;
            if (this.int_35 > 150 || this.bool_34)
            {
                if (this.int_35 > 150)
                    this.string_10 = Module.a("\uEDA7\uD8A9\uDEAB솭슯鎱", int_0);
                this.bufferedStream_2.Flush();
                this.bufferedStream_2.Close();
                this.fileStream_2.Close();
                this.timer_0.Enabled = false;
                this.timer_0.Interval = 100;
                this.panel_2.Visible = false;
                this.progressBar_0.Visible = false;
                this.progressBar_0.Enabled = false;
                this.bool_33 = false;
                this.bool_34 = false;
                this.bool_26 = false;
                this.int_35 = 0;
                this.int_36 = 0;
                this.menuItem_41.Enabled = true;
                this.ShowMessage(this.string_10);
            }
        }
        this.timer_0.Enabled = true;
    }

    private void menuItem_41_Click(object sender, EventArgs e)
    {
    }

    private void button_0_Click(object sender, EventArgs e)
    {
        int int_0 = 10;
        this.bool_26 = true;
        if (c.useEnglishLanguage)
            this.string_10 = Module.a("\uF4AF\uDDB1쎳\uD8B5풷햹\uDDBB\uDABDꦿ곁ꏃ\uE6C5껇ꯉꗋꋍ뗏뛑\uF5D3", int_0);
        else
            this.string_10 = Module.a("믡켾껯鳒㓬ꫛ邻凮㴿\uD88E㢘㉄牢\uF0AE憯\uF0A8\uDD81놺\uEC8D𥉉햭풍⭐ፌ傺\uE9AF饬\uE71A", int_0);
    }

    private void menuItem_42_Click(object sender, EventArgs e)
    {
        this.menuItem_9_Click(sender, e);
        this.bool_50 = false;
        this.bool_37 = true;
        this.timer_1.Interval = 1000 / c.smethod_0();
        this.timer_1.Enabled = true;
        this.bool_40 = false;
        this.genum1_1 = GEnum1.const_4;
        this.bool_25 = true;
        this.byte_24 = (byte)0;
        this.byte_25 = byte.MaxValue;
        this.int_27 = 0;
        this.int_26 = 1;
        this.r_0.Show();
        this.r_0.Location = new Point(500, 200);
        this.method_31();
        this.bool_28 = true;
    }

    private void menuItem_43_Click(object sender, EventArgs e)
    {
        this.menuItem_9_Click(sender, e);
        this.bool_50 = false;
        this.bool_37 = true;
        this.timer_1.Interval = 1000 / c.smethod_0();
        this.timer_1.Enabled = true;
        this.bool_40 = false;
        this.genum1_1 = GEnum1.const_4;
        this.bool_25 = true;
        this.byte_24 = (byte)0;
        this.byte_25 = byte.MaxValue;
        this.int_27 = 0;
        this.int_26 = 2;
        this.r_0.Show();
        this.r_0.Location = new Point(500, 200);
        this.method_31();
        this.bool_28 = true;
    }

    private void menuItem_44_Click(object sender, EventArgs e)
    {
        this.menuItem_9_Click(sender, e);
        this.bool_50 = false;
        this.bool_37 = true;
        this.timer_1.Interval = 1000 / c.smethod_0();
        this.timer_1.Enabled = true;
        this.bool_40 = false;
        this.genum1_1 = GEnum1.const_4;
        this.bool_25 = true;
        this.byte_24 = (byte)0;
        this.byte_25 = byte.MaxValue;
        this.int_27 = 0;
        this.int_26 = 3;
        this.r_0.Show();
        this.r_0.Location = new Point(500, 200);
        this.method_31();
        this.bool_28 = true;
    }

    private void menuItem_45_Click(object sender, EventArgs e)
    {
        this.menuItem_9_Click(sender, e);
        this.bool_50 = false;
        this.bool_37 = true;
        this.timer_1.Interval = 1000 / c.smethod_0();
        this.timer_1.Enabled = true;
        this.bool_40 = false;
        this.genum1_1 = GEnum1.const_4;
        this.bool_25 = true;
        this.byte_24 = (byte)0;
        this.byte_25 = byte.MaxValue;
        this.int_27 = 0;
        this.int_26 = 4;
        this.r_0.Show();
        this.r_0.Location = new Point(500, 200);
        this.method_31();
        this.bool_28 = true;
    }

    private void menuItem_46_Click(object sender, EventArgs e)
    {
        this.menuItem_9_Click(sender, e);
        this.bool_50 = false;
        this.bool_37 = true;
        this.timer_1.Interval = 1000 / c.smethod_0();
        this.timer_1.Enabled = true;
        this.bool_40 = false;
        this.genum1_1 = GEnum1.const_4;
        this.bool_25 = true;
        this.byte_24 = (byte)128;
        this.byte_25 = byte.MaxValue;
        this.int_27 = 1;
        this.int_26 = 5;
        this.int_28 = 0;
        this.method_31();
        this.bool_28 = true;
    }

    private void menuItem_47_Click(object sender, EventArgs e)
    {
        int int_0 = 7;
        string str = c.useEnglishLanguage ? Application.StartupPath + Module.a("\uF1AC\uEAAEힰ햲킴풶춸\uE4BA\uD8BC톾鷀賂도ꋆ믈韊飌뿎\uFFD0ꃒꋔ뇖", int_0) : Application.StartupPath + Module.a("\uF1AC\uEAAEힰ햲킴풶춸\uE4BA\uD8BC톾鷀賂도ꋆ믈韊飌뿎\uFFD0ꃒꋔ뇖", int_0);
        if (!System.IO.File.Exists(str))
            return;
        this.method_21(str);
    }

    private void menuItem_48_Click(object sender, EventArgs e)
    {
        int int_0 = 1;
        string str = c.useEnglishLanguage ? Application.StartupPath + Module.a("ﮦ\uECA8춪쮬쪮튰잲\uEAB4튶ힸ\uE7BA\uF2BC즾꓀뇂駄菆ꛈ볊ꏌ\uE1CEꋐꓒ돔", int_0) : Application.StartupPath + Module.a("ﮦ\uECA8춪쮬쪮튰잲\uEAB4튶ힸ\uE7BA\uF2BC즾꓀뇂駄菆ꛈ볊ꏌ\uE1CEꋐꓒ돔", int_0);
        if (this.bool_20)
        {
            this.d_0.method_2();
            this.bool_20 = false;
        }
        if (!System.IO.File.Exists(str))
            return;
        this.method_21(str);
    }

    private void menuItem_49_Click(object sender, EventArgs e)
    {
        int int_0 = 15;
        string str = c.useEnglishLanguage ? Application.StartupPath + Module.a("\uE9B4\uF2B6\uDFB8\uDDBA\uD8BC\uDCBE뗀鳂ꃄ꧆闈蓊믌\uAACEꏐ迒駔닖뿘꿚\uF3DC곞雠藢", int_0) : Application.StartupPath + Module.a("\uE9B4\uF2B6\uDFB8\uDDBA\uD8BC\uDCBE뗀鳂ꃄ꧆闈蓊믌\uAACEꏐ迒駔닖뿘꿚\uF3DC곞雠藢", int_0);
        if (!System.IO.File.Exists(str))
            return;
        this.method_21(str);
    }

    private void menuItem_50_Click(object sender, EventArgs e)
    {
        int int_0 = 0;
        string str = c.useEnglishLanguage ? Application.StartupPath + Module.a("瘟\uEDA7첩쪫쮭펯욱\uEBB3펵횷\uE6B9\uF3BB좽ꖿ냁飃铅ꇇ귉\uA4CB뫍ﻏꇑꏓ냕", int_0) : Application.StartupPath + Module.a("瘟\uEDA7첩쪫쮭펯욱\uEBB3펵횷\uE6B9\uF3BB좽ꖿ냁飃铅ꇇ귉\uA4CB뫍ﻏꇑꏓ냕", int_0);
        if (!System.IO.File.Exists(str))
            return;
        this.method_21(str);
    }

    private void menuItem_51_Click(object sender, EventArgs e)
    {
        int int_0 = 13;
        string str = c.useEnglishLanguage ? Application.StartupPath + Module.a("\uEFB2\uF0B4톶\uDFB8\uDEBA\uDEBC쮾黀ꛂꯄ鯆駈맊ꋌꏎ룐뗒냔ꗖ룘꿚드냞迠뿢뇤迦賨쯪鷬鷮黰\u9FF2鳴釶鳸觺鳼课栀氂欄✆昈洊ⴌ怎朐爒礔㤖樘氚笜", int_0) : Application.StartupPath + Module.a("\uEFB2\uF0B4톶\uDFB8\uDEBA\uDEBC쮾黀ꛂꯄ鯆駈맊ꋌꏎ룐뗒냔ꗖ룘꿚드냞迠뿢뇤迦賨쯪鷬鷮黰\u9FF2鳴釶鳸觺鳼课栀氂欄✆昈洊ⴌ怎朐爒礔㤖樘氚笜", int_0);
        if (!System.IO.File.Exists(str))
            return;
        this.method_21(str);
    }

    private void menuItem_52_Click(object sender, EventArgs e)
    {
        int int_0 = 10;
        string str = c.useEnglishLanguage ? Application.StartupPath + Module.a("\uECAF\uF7B1튳킵\uDDB7\uD9B9좻\uE1BDꖿ곁飃雅뫇ꗉꃋ\uA7CD뛏럑ꛓ럕곗동돛냝볟\uA7E1裣諥臧髩飫蟭鏯鏱飳훵鯷闹鋻諽狿持會爅愇攉戋\u200D挏攑爓", int_0) : Application.StartupPath + Module.a("\uECAF\uF7B1튳킵\uDDB7\uD9B9좻\uE1BDꖿ곁飃雅뫇ꗉꃋ\uA7CD뛏럑ꛓ럕곗동돛냝볟\uA7E1裣諥臧髩飫蟭鏯鏱飳훵鯷闹鋻諽狿持會爅愇攉戋\u200D挏攑爓", int_0);
        if (!System.IO.File.Exists(str))
            return;
        this.method_21(str);
    }

    private void menuItem_53_Click(object sender, EventArgs e)
    {
        int int_0 = 13;
        string str = c.useEnglishLanguage ? Application.StartupPath + Module.a("\uEFB2\uF0B4톶\uDFB8\uDEBA\uDEBC쮾黀ꛂꯄ鯆駈맊ꋌꏎ룐뗒냔ꗖ룘꿚드냞迠뿢ꇤ軦裨蛪苬臮闰\uDEF2藴藶雸韺铼駾搀焂搄猆怈搊挌ℎ成搒猔", int_0) : Application.StartupPath + Module.a("\uEFB2\uF0B4톶\uDFB8\uDEBA\uDEBC쮾黀ꛂꯄ鯆駈맊ꋌꏎ룐뗒냔ꗖ룘꿚드냞迠뿢ꇤ軦裨蛪苬臮闰\uDEF2藴藶雸韺铼駾搀焂搄猆怈搊挌ℎ成搒猔", int_0);
        if (!System.IO.File.Exists(str))
            return;
        this.method_21(str);
    }

    private void menuItem_54_Click(object sender, EventArgs e)
    {
        int int_0 = 9;
        string str = c.useEnglishLanguage ? Application.StartupPath + Module.a("\uF3AE\uF4B0햲펴튶\uDAB8쾺\uE2BC\uDABE꿀鿂闄뗆ꛈ\uA7CA\uA4CC\uA9CE듐ꇒ듔ꏖ냘듚돜菞ꗠ諢蓤諦蛨藪觬싮苰鯲铴蟶鳸\u9FFA\uDDFC賾砀瀂焄栆攈戊渌ℎ成搒猔", int_0) : Application.StartupPath + Module.a("\uF3AE\uF4B0햲펴튶\uDAB8쾺\uE2BC\uDABE꿀鿂闄뗆ꛈ\uA7CA\uA4CC\uA9CE듐ꇒ듔ꏖ냘듚돜菞ꗠ諢蓤諦蛨藪觬싮苰鯲铴蟶鳸\u9FFA\uDDFC賾砀瀂焄栆攈戊渌ℎ成搒猔", int_0);
        if (!System.IO.File.Exists(str))
            return;
        this.method_21(str);
    }

    private void menuItem_55_Click(object sender, EventArgs e)
    {
        int int_0 = 5;
        string str = c.useEnglishLanguage ? Application.StartupPath + Module.a("\uF7AA\uE8AC즮ힰ횲횴쎶\uE6B8\uDEBA펼\uE3BE鋀뫂꣄\uAAC6곈뿊뿌ꛎ닐닒맔诖鷘껚볜돞쳠苢诤胦藨軪췬賮鷰鳲蛴苶诸黺폼賾瘀攂", int_0) : Application.StartupPath + Module.a("\uF7AA\uE8AC즮ힰ횲횴쎶\uE6B8\uDEBA펼\uE3BE鋀뫂꣄\uAAC6곈뿊뿌ꛎ닐닒맔诖鷘껚볜돞쳠苢诤胦藨軪췬賮鷰鳲蛴苶诸黺폼賾瘀攂", int_0);
        if (!System.IO.File.Exists(str))
            return;
        this.method_21(str);
    }

    private void menuItem_56_Click(object sender, EventArgs e)
    {
        int int_0 = 7;
        string str = c.useEnglishLanguage ? Application.StartupPath + Module.a("\uF1AC\uEAAEힰ햲킴풶춸\uE4BA\uD8BC톾鷀郂별\uAAC6\uA4C8껊만뷎룐냒듔믖藘\u9FDA닜꫞菠迢胤쟦裨藪諬菮铰폲髴釶\u9FF8헺軼裾最", int_0) : Application.StartupPath + Module.a("\uF1AC\uEAAEힰ햲킴풶춸\uE4BA\uD8BC톾鷀郂별\uAAC6\uA4C8껊만뷎룐냒듔믖藘\u9FDA닜꫞菠迢胤쟦裨藪諬菮铰폲髴釶\u9FF8헺軼裾最", int_0);
        if (!System.IO.File.Exists(str))
            return;
        this.method_21(str);
    }

    private void menuItem_57_Click(object sender, EventArgs e)
    {
        if (c.int_78 == 1)
            return;
        c.int_78 = 1;
        this.method_26(14, c.int_78.ToString());
        this.method_13();
        if (this.genum1_1 == GEnum1.const_4)
            this.d_0.ClientSize = new Size(this.int_67, this.int_68);
        if (this.genum1_1 != GEnum1.const_3)
            return;
        if (this.int_67 >= 500 && this.int_68 >= 400)
            c.i_0.ClientSize = new Size(500, 400);
        else
            c.i_0.ClientSize = new Size(this.int_67, this.int_68);
        c.i_0.method_0();
        Rectangle rectangle_2 = new Rectangle(0, 0, c.rectangle_0.Width, c.rectangle_0.Height);
        c.gclass0_4.method_15(rectangle_2);
    }

    private void menuItem_58_Click(object sender, EventArgs e)
    {
        int int_0 = 3;
        this.int_32 = this.int_23 / c.int_75;
        this.string_9 = new string[this.int_32];
        for (int index = 0; index < this.int_32; ++index)
        {
            int num = 50 + index;
            this.string_9[index] = Module.a("風銪龬膮肰薲趴馶辸论鎼", int_0) + num.ToString();
        }
        this.byte_35[0] = (byte)194;
        this.byte_35[1] = (byte)119;
        this.byte_35[2] = (byte)136;
        for (int index = 0; index < this.int_32; ++index)
        {
            try
            {
                this.udpClient_0.Send(this.byte_35, 5, this.string_9[index], 5000);
            }
            catch
            {
            }
        }
    }

    private void toolStripButton_19_Click(object sender, EventArgs e)
    {
        if (c.int_78 >= c.int_76)
            return;
        ++c.int_78;
        this.method_26(14, c.int_78.ToString());
        this.method_13();
        if (this.genum1_1 == GEnum1.const_4 || this.genum1_1 == GEnum1.const_8)
        {
            this.d_0.ClientSize = new Size(this.int_67, this.int_68);
            Rectangle rectangle_2 = new Rectangle(0, 0, this.d_0.ClientSize.Width, this.d_0.ClientSize.Height);
            c.gclass0_4.method_15(rectangle_2);
        }
        if (this.genum1_1 == GEnum1.const_3 || this.genum1_1 == GEnum1.const_9)
        {
            if (this.int_67 >= 500 && this.int_68 >= 400)
                c.i_0.ClientSize = new Size(500, 400);
            else
                c.i_0.ClientSize = new Size(this.int_67, this.int_68);
        }
        c.int_59 = 0;
        c.int_58 = 0;
        if (this.bool_22)
        {
            this.d_0.ClientSize = new Size(400, 400);
            Rectangle rectangle_2 = new Rectangle(0, 0, this.d_0.ClientSize.Width, this.d_0.ClientSize.Height);
            c.gclass0_4.method_15(rectangle_2);
        }
        if (!c.bool_51)
            return;
        this.a_0.method_1();
    }

    // Export Led file
    private void menuItem_59_Click(object sender, EventArgs e)
    {
        int int_0 = 9;
        for (int index = 0; index < c.arrayList_4.Count; ++index)
        {
            if (!System.IO.File.Exists(this.string_20 + ((GClass5)c.arrayList_4[index]).string_3) || !((GClass5)c.arrayList_4[index]).bool_2)
            {
                if (c.useEnglishLanguage)
                {
                    this.ShowMessage(((GClass5)c.arrayList_4[index]).string_0 + "no recording!"); //Module.a("솮\uDEB0鎲잴튶\uDAB8풺쾼\uDBBEꣀ귂ꋄ\uE6C6", int_0)); // ;
                    return;
                }
                this.ShowMessage(((GClass5)c.arrayList_4[index]).string_0 + "无录制内容!"); // Module.a("俋\uE4EF藠ュ\u0EED颸", int_0));
                return;
            }
        }
        ac ac = new ac();
        ac.BringToFront();
        if (ac.ShowDialog() != DialogResult.OK)
            return;
        this.int_32 = this.int_23 >= 8 ? this.int_23 / c.int_75 : 1;
        this.bool_5 = false;
        if (c.int_2 != 81 && c.int_2 != 86 && c.int_2 != 82 && c.int_2 != 83 && c.int_2 != 84 && c.int_2 != 85 && c.int_2 != 13 && c.int_2 != 32 && c.int_2 != 47 && c.int_2 != 52 && c.int_2 != 9 && c.int_2 != 16 && c.int_2 != 55)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
                return;
            string path = folderBrowserDialog.SelectedPath + "\\Led"; // Module.a("\uF3AEﶰ횲톴", int_0);
            if (Directory.Exists(path))
                Directory.Delete(path, true);
            Directory.CreateDirectory(path);
            for (int index = 0; index < c.arrayList_4.Count; ++index)
            {
                string str1 = this.string_20 + ((GClass5)c.arrayList_4[index]).string_3;
                string string_25 = this.string_20 + ((GClass5)c.arrayList_4[index]).string_1;
                c.int_38 = index;
                this.textBox_4.Text = this.listBox_0.Items[c.int_38].ToString();
                if (System.IO.File.Exists(str1))
                {
                    this.method_40(str1, string_25);
                    ((GClass5)c.arrayList_4[c.int_38]).bool_3 = true;
                }
                string sourceFileName = string_25 + "\00.led"; // Module.a("\uF3AE膰莲鮴\uDBB6\uDCB8\uDFBA", int_0);
                string str2 = index >= 10 ? index.ToString() : '0'.ToString() + index.ToString();
                string destFileName = path + (object)'\\' + str2 + "_" /*Module.a("\uF0AE", int_0)*/ + ((GClass5)c.arrayList_4[index]).string_0 + ".led"; // Module.a("膮\uDDB0횲톴", int_0);
                System.IO.File.Copy(sourceFileName, destFileName, true);
            }
        }
        else
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
                return;
            string path1 = folderBrowserDialog.SelectedPath + "\\Led"; // Module.a("\uF3AEﶰ횲톴", int_0);
            if (Directory.Exists(path1))
                Directory.Delete(path1, true);
            Directory.CreateDirectory(path1);
            string str3 = !c.useEnglishLanguage ? "控制器-" /*Module.a("\u08CD蟢\uDBE4颴", int_0)*/ : "Controller-" /*Module.a("\uECAE\uDEB0\uDDB2솴얶횸ힺ톼\uDABE돀\uEEC2", int_0)*/;
            if (c.int_2 != 13 && c.int_2 != 32 && c.int_2 != 47 && c.int_2 != 52 && c.int_2 != 9 && c.int_2 != 16 && c.int_2 != 55)
            {
                for (int index = 0; index < this.int_32; ++index)
                {
                    string path2 = path1 + (object)'\\' + str3 + (index + 1).ToString();
                    if (Directory.Exists(path2))
                        Directory.Delete(path2, true);
                    Directory.CreateDirectory(path2);
                }
                int num1;
                for (int index1 = 0; index1 < c.arrayList_4.Count; ++index1)
                {
                    string str4 = this.string_20 + ((GClass5)c.arrayList_4[index1]).string_3;
                    string string_25 = this.string_20 + ((GClass5)c.arrayList_4[index1]).string_1;
                    c.int_38 = index1;
                    this.textBox_4.Text = this.listBox_0.Items[c.int_38].ToString();
                    if (System.IO.File.Exists(str4))
                    {
                        this.method_40(str4, string_25);
                        ((GClass5)c.arrayList_4[c.int_38]).bool_3 = true;
                    }
                    for (int index2 = 0; index2 < this.int_32; ++index2)
                    {
                        object[] objArray1 = new object[7]
                        {
              (object) string_25,
              (object) "\\_LED", /*Module.a("\uF3AE\uEEB0ﾲ\uF0B4\uF3B6", int_0),*/
              (object) '\\',
              (object) c.string_3,
              (object) "_",/*Module.a("\uF0AE", int_0),*/
              null,
              null
                        };
                        object[] objArray2 = objArray1;
                        num1 = index2 + 1;
                        string str5 = num1.ToString();
                        objArray2[5] = (object)str5;
                        objArray1[6] = ".led"; // (object)Module.a("膮\uDDB0횲톴", int_0);
                        string sourceFileName = string.Concat(objArray1);
                        string str6 = index1 >= 10 ? index1.ToString() : '0'.ToString() + index1.ToString();
                        object[] objArray3 = new object[9];
                        objArray3[0] = (object)path1;
                        objArray3[1] = (object)'\\';
                        objArray3[2] = (object)str3;
                        object[] objArray4 = objArray3;
                        num1 = index2 + 1;
                        string str7 = num1.ToString();
                        objArray4[3] = (object)str7;
                        objArray3[4] = (object)'\\';
                        objArray3[5] = (object)str6;
                        objArray3[6] = (object)"_"; // Module.a("\uF0AE", int_0);
                        objArray3[7] = (object)((GClass5)c.arrayList_4[index1]).string_0;
                        objArray3[8] = (object)".led"; // Module.a("膮\uDDB0횲톴", int_0);
                        string destFileName = string.Concat(objArray3);
                        System.IO.File.Copy(sourceFileName, destFileName, true);
                    }
                }
                if (c.int_2 != 82 || c.byte_20 != (byte)22)
                    return;
                int[] numArray = new int[33];
                numArray[0] = c.arrayList_4.Count;
                numArray[1] = 1;
                for (int index3 = 0; index3 < this.int_32; ++index3)
                {
                    object[] objArray5 = new object[6]
                    {
            (object) path1,
            (object) '\\',
            (object) str3,
            null,
            null,
            null
                    };
                    object[] objArray6 = objArray5;
                    num1 = index3 + 1;
                    string str8 = num1.ToString();
                    objArray6[3] = (object)str8;
                    objArray5[4] = (object)'\\';
                    objArray5[5] = (object)"K-8000.led"; // Module.a("\uE4AE鲰讲薴螶覸閺톼\uDABEꗀ", int_0);
                    string path3 = string.Concat(objArray5);
                    if (System.IO.File.Exists(path3))
                        System.IO.File.Delete(path3);
                    FileStream fileStream1 = new FileStream(path3, FileMode.Create, FileAccess.Write);
                    BufferedStream bufferedStream1 = new BufferedStream((Stream)fileStream1);
                    byte[] buffer1 = new byte[512];
                    new Random().NextBytes(buffer1);
                    buffer1[0] = (byte)120;
                    buffer1[1] = (byte)98;
                    buffer1[2] = (byte)108;
                    buffer1[3] = (byte)116;
                    buffer1[4] = (byte)107;
                    buffer1[5] = (byte)45;
                    buffer1[6] = (byte)48;
                    buffer1[7] = (byte)48;
                    buffer1[8] = (byte)48;
                    buffer1[9] = (byte)48;
                    for (int index4 = 0; index4 < c.arrayList_4.Count; ++index4)
                    {
                        string str9 = index4 >= 10 ? index4.ToString() : '0'.ToString() + index4.ToString();
                        object[] objArray7 = new object[9];
                        objArray7[0] = (object)path1;
                        objArray7[1] = (object)'\\';
                        objArray7[2] = (object)str3;
                        object[] objArray8 = objArray7;
                        num1 = index3 + 1;
                        string str10 = num1.ToString();
                        objArray8[3] = (object)str10;
                        objArray7[4] = (object)'\\';
                        objArray7[5] = (object)str9;
                        objArray7[6] = (object)"_"; //Module.a("\uF0AE", int_0);
                        objArray7[7] = (object)((GClass5)c.arrayList_4[index4]).string_0;
                        objArray7[8] = (object)".led"; //Module.a("膮\uDDB0횲톴", int_0);
                        FileInfo fileInfo = new FileInfo(string.Concat(objArray7));
                        int num2 = (int)(fileInfo.Length / 512L);
                        if ((int)(fileInfo.Length % 512L) <= 0)
                        {
                            numArray[index4 + 2] = numArray[index4 + 1] + num2;
                        }
                        else
                        {
                            if (c.useEnglishLanguage)
                            {
                                this.ShowMessage("File error!"/*Module.a("\uE9AE\uD8B0\uDFB2킴鞶\uDCB8즺쾼킾돀\uE2C2", int_0)*/);
                                return;
                            }
                            this.ShowMessage(Module.a("⣋䟾䧣갡隶", int_0));
                            return;
                        }
                    }
                    for (int index5 = 0; index5 < 33; ++index5)
                    {
                        byte[] bytes = BitConverter.GetBytes(numArray[index5]);
                        buffer1[100 + index5 * 4] = bytes[0];
                        buffer1[100 + index5 * 4 + 1] = bytes[1];
                        buffer1[100 + index5 * 4 + 2] = bytes[2];
                        buffer1[100 + index5 * 4 + 3] = bytes[3];
                    }
                    bufferedStream1.Write(buffer1, 0, 512);
                    for (int index6 = 0; index6 < c.arrayList_4.Count; ++index6)
                    {
                        string str11 = index6 >= 10 ? index6.ToString() : '0'.ToString() + index6.ToString();
                        object[] objArray9 = new object[9];
                        objArray9[0] = (object)path1;
                        objArray9[1] = (object)'\\';
                        objArray9[2] = (object)str3;
                        object[] objArray10 = objArray9;
                        num1 = index3 + 1;
                        string str12 = num1.ToString();
                        objArray10[3] = (object)str12;
                        objArray9[4] = (object)'\\';
                        objArray9[5] = (object)str11;
                        objArray9[6] = (object)"_";/*Module.a("\uF0AE", int_0);*/
                        objArray9[7] = (object)((GClass5)c.arrayList_4[index6]).string_0;
                        objArray9[8] = (object)".led"; //"Module.a("膮\uDDB0횲톴", int_0);
                        string str13 = string.Concat(objArray9);
                        FileStream fileStream2 = new FileStream(str13, FileMode.Open, FileAccess.Read);
                        BufferedStream bufferedStream2 = new BufferedStream((Stream)fileStream2);
                        bufferedStream2.Seek(0L, SeekOrigin.Begin);
                        FileInfo fileInfo = new FileInfo(str13);
                        int num3 = (int)(fileInfo.Length / 1048576L);
                        int count = (int)(fileInfo.Length % 1048576L);
                        byte[] buffer2 = new byte[1048576];
                        for (int index7 = 0; index7 < num3; ++index7)
                        {
                            bufferedStream2.Read(buffer2, 0, 1048576);
                            bufferedStream1.Write(buffer2, 0, 1048576);
                        }
                        bufferedStream2.Read(buffer2, 0, count);
                        bufferedStream1.Write(buffer2, 0, count);
                        bufferedStream2.Flush();
                        bufferedStream2.Close();
                        fileStream2.Close();
                        System.IO.File.Delete(str13);
                    }
                    bufferedStream1.Flush();
                    bufferedStream1.Close();
                    fileStream1.Close();
                }
            }
            else if (c.int_2 == 32 && c.byte_20 > (byte)60)
            {
                for (int index = 0; index < c.arrayList_4.Count; ++index)
                {
                    string str14 = this.string_20 + ((GClass5)c.arrayList_4[index]).string_3;
                    string string_25 = this.string_20 + ((GClass5)c.arrayList_4[index]).string_1;
                    c.int_38 = index;
                    this.textBox_4.Text = this.listBox_0.Items[c.int_38].ToString();
                    if (System.IO.File.Exists(str14))
                        this.method_40(str14, string_25);
                    string sourceFileName = string_25 + "\\_T_1000_AC\\" /*+ Module.a("\uF3AE\uEEB0\uE7B2\uEAB4蚶覸论趼\uE0BE胀胂駄", int_0)*/ + c.string_3 + "_1.led" /*Module.a("\uF0AE肰鶲\uD9B4튶\uDDB8", int_0)*/;
                    string str15 = index >= 10 ? index.ToString() : '0'.ToString() + index.ToString();
                    string destFileName = path1 + (object)'\\' + str15 + Module.a("\uF0AE", int_0) + ((GClass5)c.arrayList_4[index]).string_0 + ".led" /*Module.a("膮\uDDB0횲톴", int_0)*/;
                    System.IO.File.Copy(sourceFileName, destFileName, true);
                }
            }
            else
            {
                foreach (GClass8 gclass8 in this.arrayList_3)
                {
                    string path4 = path1 + (object)'\\' + str3 + (gclass8.method_4() + 1).ToString();
                    if (Directory.Exists(path4))
                        Directory.Delete(path4, true);
                    Directory.CreateDirectory(path4);
                }
                for (int index = 0; index < c.arrayList_4.Count; ++index)
                {
                    string str16 = this.string_20 + ((GClass5)c.arrayList_4[index]).string_3;
                    string string_25 = this.string_20 + ((GClass5)c.arrayList_4[index]).string_1;
                    c.int_38 = index;
                    this.textBox_4.Text = this.listBox_0.Items[c.int_38].ToString();
                    if (System.IO.File.Exists(str16))
                        this.method_40(str16, string_25);
                    foreach (GClass8 gclass8 in this.arrayList_3)
                    {
                        string[] strArray1 = new string[6]
                        {
              string_25,
              "\\_T_1000_AC\\", /*Module.a("\uF3AE\uEEB0\uE7B2\uEAB4蚶覸论趼\uE0BE胀胂駄", int_0),*/
              c.string_3,
              "_", /*Module.a("\uF0AE", int_0),*/
              null,
              null
                        };
                        string[] strArray2 = strArray1;
                        int num = gclass8.method_4() + 1;
                        string str17 = num.ToString();
                        strArray2[4] = str17;
                        strArray1[5] = ".led"; // Module.a("膮\uDDB0횲톴", int_0);
                        string sourceFileName = string.Concat(strArray1);
                        string str18 = index >= 10 ? index.ToString() : '0'.ToString() + index.ToString();
                        object[] objArray11 = new object[9];
                        objArray11[0] = (object)path1;
                        objArray11[1] = (object)'\\';
                        objArray11[2] = (object)str3;
                        object[] objArray12 = objArray11;
                        num = gclass8.method_4() + 1;
                        string str19 = num.ToString();
                        objArray12[3] = (object)str19;
                        objArray11[4] = (object)'\\';
                        objArray11[5] = (object)str18;
                        objArray11[6] = (object)"_"; //Module.a("\uF0AE", int_0);
                        objArray11[7] = (object)((GClass5)c.arrayList_4[index]).string_0;
                        objArray11[8] = (object)".led";// Module.a("膮\uDDB0횲톴", int_0);
                        string destFileName = string.Concat(objArray11);
                        System.IO.File.Copy(sourceFileName, destFileName, true);
                    }
                }
                if (c.int_2 != 32 || c.byte_20 != (byte)22)
                    return;
                int[] numArray = new int[33];
                numArray[0] = c.arrayList_4.Count;
                numArray[1] = 1;
                foreach (GClass8 gclass8 in this.arrayList_3)
                {
                    string path5 = path1 + (object)'\\' + str3 + (gclass8.method_4() + 1).ToString() + (object)'\\' + "K-1000.led" /*Module.a("\uE4AE鲰芲薴螶覸閺톼\uDABEꗀ", int_0)*/;
                    if (System.IO.File.Exists(path5))
                        System.IO.File.Delete(path5);
                    FileStream fileStream3 = new FileStream(path5, FileMode.Create, FileAccess.Write);
                    BufferedStream bufferedStream3 = new BufferedStream((Stream)fileStream3);
                    byte[] buffer3 = new byte[512];
                    new Random().NextBytes(buffer3);
                    buffer3[0] = (byte)120;
                    buffer3[1] = (byte)98;
                    buffer3[2] = (byte)108;
                    buffer3[3] = (byte)116;
                    buffer3[4] = (byte)107;
                    buffer3[5] = (byte)45;
                    buffer3[6] = (byte)48;
                    buffer3[7] = (byte)48;
                    buffer3[8] = (byte)48;
                    buffer3[9] = (byte)48;
                    for (int index = 0; index < c.arrayList_4.Count; ++index)
                    {
                        string str20 = index >= 10 ? index.ToString() : '0'.ToString() + index.ToString();
                        FileInfo fileInfo = new FileInfo(path1 + (object)'\\' + str3 + (gclass8.method_4() + 1).ToString() + (object)'\\' + str20 + Module.a("\uF0AE", int_0) + ((GClass5)c.arrayList_4[index]).string_0 + Module.a("膮\uDDB0횲톴", int_0));
                        int num = (int)(fileInfo.Length / 512L);
                        if ((int)(fileInfo.Length % 512L) <= 0)
                        {
                            numArray[index + 2] = numArray[index + 1] + num;
                        }
                        else
                        {
                            if (c.useEnglishLanguage)
                            {
                                this.ShowMessage("File error!"/*Module.a("\uE9AE\uD8B0\uDFB2킴鞶\uDCB8즺쾼킾돀\uE2C2", int_0)*/);
                                return;
                            }
                            this.ShowMessage(Module.a("⣋䟾䧣갡隶", int_0));
                            return;
                        }
                    }
                    for (int index = 0; index < 33; ++index)
                    {
                        byte[] bytes = BitConverter.GetBytes(numArray[index]);
                        buffer3[100 + index * 4] = bytes[0];
                        buffer3[100 + index * 4 + 1] = bytes[1];
                        buffer3[100 + index * 4 + 2] = bytes[2];
                        buffer3[100 + index * 4 + 3] = bytes[3];
                    }
                    bufferedStream3.Write(buffer3, 0, 512);
                    for (int index8 = 0; index8 < c.arrayList_4.Count; ++index8)
                    {
                        string str21 = index8 >= 10 ? index8.ToString() : '0'.ToString() + index8.ToString();
                        string str22 = path1 + (object)'\\' + str3 + (gclass8.method_4() + 1).ToString() + (object)'\\' + str21 + "_" /*Module.a("\uF0AE", int_0)*/ + ((GClass5)c.arrayList_4[index8]).string_0 + ".led"; // Module.a("膮\uDDB0횲톴", int_0);
                        FileStream fileStream4 = new FileStream(str22, FileMode.Open, FileAccess.Read);
                        BufferedStream bufferedStream4 = new BufferedStream((Stream)fileStream4);
                        bufferedStream4.Seek(0L, SeekOrigin.Begin);
                        FileInfo fileInfo = new FileInfo(str22);
                        int num = (int)(fileInfo.Length / 1048576L);
                        int count = (int)(fileInfo.Length % 1048576L);
                        byte[] buffer4 = new byte[1048576];
                        for (int index9 = 0; index9 < num; ++index9)
                        {
                            bufferedStream4.Read(buffer4, 0, 1048576);
                            bufferedStream3.Write(buffer4, 0, 1048576);
                        }
                        bufferedStream4.Read(buffer4, 0, count);
                        bufferedStream3.Write(buffer4, 0, count);
                        bufferedStream4.Flush();
                        bufferedStream4.Close();
                        fileStream4.Close();
                        System.IO.File.Delete(str22);
                    }
                    bufferedStream3.Flush();
                    bufferedStream3.Close();
                    fileStream3.Close();
                }
            }
        }
    }

    public static void smethod_4(string string_24, string string_25)
    {
        if ((int)string_25[string_25.Length - 1] != (int)Path.DirectorySeparatorChar)
            string_25 += (string)(object)Path.DirectorySeparatorChar;
        if (!Directory.Exists(string_25))
            Directory.CreateDirectory(string_25);
        foreach (string fileSystemEntry in Directory.GetFileSystemEntries(string_24))
        {
            if (!Directory.Exists(fileSystemEntry))
                System.IO.File.Copy(fileSystemEntry, string_25 + Path.GetFileName(fileSystemEntry), true);
        }
    }

    private void toolStripButton_20_Click(object sender, EventArgs e)
    {
        if (c.int_78 <= 1)
            return;
        --c.int_78;
        this.method_26(14, c.int_78.ToString());
        this.method_13();
        if (this.genum1_1 == GEnum1.const_4 || this.genum1_1 == GEnum1.const_8)
        {
            this.d_0.ClientSize = new Size(this.int_67, this.int_68);
            Rectangle rectangle_2 = new Rectangle(0, 0, this.d_0.ClientSize.Width, this.d_0.ClientSize.Height);
            c.gclass0_4.method_15(rectangle_2);
        }
        if (this.genum1_1 == GEnum1.const_3 || this.genum1_1 == GEnum1.const_9)
        {
            if (this.int_67 >= 500 && this.int_68 >= 400)
                c.i_0.ClientSize = new Size(500, 400);
            else
                c.i_0.ClientSize = new Size(this.int_67, this.int_68);
        }
        c.int_59 = 0;
        c.int_58 = 0;
        if (this.bool_22)
        {
            this.d_0.ClientSize = new Size(400, 400);
            Rectangle rectangle_2 = new Rectangle(0, 0, this.d_0.ClientSize.Width, this.d_0.ClientSize.Height);
            c.gclass0_4.method_15(rectangle_2);
        }
        if (!c.bool_51)
            return;
        this.a_0.method_1();
    }

    private void method_75()
    {
        this.bool_37 = false;
        this.timer_1.Interval = 1000 / c.smethod_0();
        this.timer_1.Enabled = false;
        this.int_26 = 0;
        this.r_0.Hide();
        this.bool_25 = false;
        this.genum1_1 = !this.bool_40 ? GEnum1.const_2 : GEnum1.const_6;
        if (Convert.ToInt32(this.string_11[4]) == 1 && System.IO.File.Exists(this.string_20 + (object)'\\' + this.string_11[5]))
            this.genum1_1 = GEnum1.const_6;
        this.method_31();
    }

    private void method_76(int int_93)
    {
        int int_0 = 5;
        int byte24 = (int)this.byte_24;
        switch (int_93)
        {
            case 1:
                this.gclass0_3.method_12().ColorFill(Color.FromArgb(byte24, byte24, byte24));
                if (this.int_27 == 0)
                {
                    ++this.byte_24;
                    if ((int)this.byte_24 >= (int)this.byte_25)
                        this.int_27 = 1;
                }
                else if (this.int_27 == 1)
                {
                    --this.byte_24;
                    if (this.byte_24 <= (byte)0)
                        this.int_27 = 0;
                }
                this.r_0.label_0.Text = Module.a("\uF8F5\uE0FE\uDFDE\u17EE覲", int_0) + this.byte_24.ToString();
                break;
            case 2:
                this.gclass0_3.method_12().ColorFill(Color.FromArgb(byte24, 0, 0));
                if (this.int_27 == 0)
                {
                    ++this.byte_24;
                    if ((int)this.byte_24 >= (int)this.byte_25)
                        this.int_27 = 1;
                }
                else if (this.int_27 == 1)
                {
                    --this.byte_24;
                    if (this.byte_24 <= (byte)0)
                        this.int_27 = 0;
                }
                this.r_0.label_0.Text = Module.a("\uF8F5\uE0FE\uDFDE\u17EE覲", int_0) + this.byte_24.ToString();
                break;
            case 3:
                this.gclass0_3.method_12().ColorFill(Color.FromArgb(0, byte24, 0));
                if (this.int_27 == 0)
                {
                    ++this.byte_24;
                    if ((int)this.byte_24 >= (int)this.byte_25)
                        this.int_27 = 1;
                }
                else if (this.int_27 == 1)
                {
                    --this.byte_24;
                    if (this.byte_24 <= (byte)0)
                        this.int_27 = 0;
                }
                this.r_0.label_0.Text = Module.a("\uF8F5\uE0FE\uDFDE\u17EE覲", int_0) + this.byte_24.ToString();
                break;
            case 4:
                this.gclass0_3.method_12().ColorFill(Color.FromArgb(0, 0, byte24));
                if (this.int_27 == 0)
                {
                    ++this.byte_24;
                    if ((int)this.byte_24 >= (int)this.byte_25)
                        this.int_27 = 1;
                }
                else if (this.int_27 == 1)
                {
                    --this.byte_24;
                    if (this.byte_24 <= (byte)0)
                        this.int_27 = 0;
                }
                this.r_0.label_0.Text = Module.a("\uF8F5\uE0FE\uDFDE\u17EE覲", int_0) + this.byte_24.ToString();
                break;
            case 5:
                int num = (int)byte.MaxValue - byte24;
                if (this.int_28 == 0)
                    this.gclass0_3.method_12().ColorFill(Color.FromArgb(num, byte24, 0));
                else if (this.int_28 == 1)
                    this.gclass0_3.method_12().ColorFill(Color.FromArgb(0, num, byte24));
                else if (this.int_28 == 2)
                    this.gclass0_3.method_12().ColorFill(Color.FromArgb(byte24, 0, num));
                ++this.byte_24;
                if ((int)this.byte_24 < (int)this.byte_25)
                    break;
                ++this.int_28;
                if (this.int_28 > 2)
                    this.int_28 = 0;
                this.byte_24 = (byte)0;
                break;
            case 6:
                this.gclass0_3.method_12().ColorFill(Color.FromArgb((int)this.byte_26, (int)this.byte_27, (int)this.byte_28));
                ++this.byte_26;
                this.byte_27 -= (byte)4;
                this.byte_28 += (byte)3;
                break;
        }
    }

    private void c_Load(object sender, EventArgs e)
    {
        int int_0 = 12;
        string str1 = (string)null;
        bool flag = false;
        this.bool_19 = true;
        this.bool_20 = false;
        string path1 = c.string_2 + Module.a("\uEEB1\uE7B3습\uD9B7좹좻\uE1BD뒿\uECC1냃뻅볇", 12);
        if (System.IO.File.Exists(path1))
        {
            using (StreamReader streamReader = new StreamReader(path1, Encoding.Unicode))
            {
                str1 = streamReader.ReadLine();
                if (Convert.ToBoolean(streamReader.ReadLine()))
                    flag = true;
                string str2 = streamReader.ReadLine();
                if (str2 != null)
                {
                    this.bool_24 = true;
                    try
                    {
                        this.dateTime_0 = new DateTime(Convert.ToInt64(str2));
                    }
                    catch
                    {
                    }
                    this.timer_3.Enabled = true;
                }
                else
                {
                    this.bool_24 = false;
                    this.timer_3.Enabled = false;
                }
                this.bool_23 = true;
            }
        }
        try
        {
            if (this.bool_23)
            {
                if (str1 != null)
                {
                    if (System.IO.File.Exists(str1))
                    {
                        this.method_30(str1);
                        if (!this.method_27())
                        {
                            if (c.useEnglishLanguage)
                            {
                                this.ShowMessage(Module.a("\uF4B1햳\uDFB5풷\uDFB9\uD8BB麽뒿귁\uE4C3\uAAC5\uA7C7ꯉ\uA8CB\uEECD\uA4CF뫑뇓\uF6D5꣗꣙돛망鋟菡解웥蓧菩\u9FEB髭퇯", int_0));
                                return;
                            }
                            this.ShowMessage(Module.a("ዣ줼㐷囁귫퐳迤\uE532쌾", int_0));
                            return;
                        }
                        c.int_38 = 0;
                        if (((GClass5)c.arrayList_4[c.int_38]).bool_2 && this.genum1_1 == GEnum1.const_2)
                        {
                            this.genum1_1 = GEnum1.const_6;
                            this.method_31();
                        }
                        this.method_25();
                        this.textBox_4.Text = this.listBox_0.Items[c.int_38].ToString();
                        this.method_15();
                        this.method_81();
                        if (flag)
                        {
                            if (c.int_2 > 80)
                                this.menuItem_33_Click((object)null, (EventArgs)null);
                        }
                    }
                }
            }
        }
        catch
        {
        }
        //   string path2 = c.string_2 + Module.a("\uEEB1\uF0B3\uDBB5삷\uE5B9\uDDBB\uDABD꒿냁鯃뗅귇뻉\uFDCB뷍ꧏ\uAAD1뿓觕곗\uF4D9\uA8DBꛝ铟", int_0);
        string path2 = c.string_2 + "\\Dmx_addr_set1syxk_t.txt";
        if (System.IO.File.Exists(path2))
        {
            using (StreamReader streamReader = new StreamReader(path2, Encoding.Unicode))
            {
                try
                {
                    c.int_5 = Convert.ToInt32(streamReader.ReadLine());
                    c.int_6 = Convert.ToInt32(streamReader.ReadLine());
                    c.int_7 = Convert.ToInt32(streamReader.ReadLine());
                }
                catch
                {
                    c.int_5 = 1;
                    c.int_6 = 3;
                    c.int_7 = 512;
                }
            }
        }
        else
        {
            c.int_5 = 1;
            c.int_6 = 3;
            c.int_7 = 512;
        }
        this.method_77();
    }

    private void method_77()
    {
        int int_0 = 7;
        //   if (!(new StackFrame().GetMethod().Name == Module.a("淄\uE4C3ᇢ痩\uEAB4풶톸\uDEBA\uDEBC풾黀꧂계ꛆ\uA4C8ꋊ", 7)))
        if (!(new StackFrame().GetMethod().Name == Module.a("淄\uE4C3ᇢ痩\uEAB4풶톸\uDEBA\uDEBC풾黀꧂계ꛆ\uA4C8ꋊ", 7)))
            return;
        //   int num = (int) MessageBox.Show(Module.a("棙緅鶰볮盫隶馸钺銼邾\uE1C0闂계뗆볈룊\uE1CC\uEFCE돐뛒\uF5D4듖룘\uA9DA룜맞铠迢엤裦迨쯪铬胮蓰臲헴釶郸韺飼\uDEFE℀", int_0));
        int num = (int)MessageBox.Show("Virus, be careful of your file! ");
    }

    private void ShowMessage(string string_24)
    {
        MessageDialog aa = new MessageDialog();
        aa.label_0.Text = string_24;
        int num = (int)aa.ShowDialog();
    }

    private void c_SizeChanged(object sender, EventArgs e)
    {
    }

    private void menuItem_61_Click(object sender, EventArgs e)
    {
        int int_0 = 1;
        this.int_19 = 0;
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Title = Module.a("\uE8A6\uD9A8캪쎬", 1);
        if (!c.useEnglishLanguage)
            openFileDialog.InitialDirectory = Application.StartupPath + Module.a("ﮦ\uECA8춪쮬쪮튰잲\uEAB4튶ힸ\uE7BA", int_0);
        else
            openFileDialog.InitialDirectory = Application.StartupPath + Module.a("ﮦ\uECA8춪쮬쪮튰잲\uEAB4튶ힸ\uE7BA", int_0);
        openFileDialog.AddExtension = true;
        openFileDialog.CheckFileExists = true;
        openFileDialog.CheckPathExists = true;
        openFileDialog.Filter = Module.a("\uF4A6\uDEA8춪薬薮龰삲슴톶邸잺鞼醾닀듂ꏄ믆裈\uA7CAꇌ\uEFCE韐뫒맔닖律\uF3DA\uF7DC\uF1DE쯠쫢駤췦쟨쇪", int_0);
        openFileDialog.DefaultExt = Module.a("쪦\uD9A8颪", int_0);
        if (openFileDialog.ShowDialog() != DialogResult.OK)
            return;
        string fileName = openFileDialog.FileName;
        if (!System.IO.File.Exists(fileName))
            return;
        this.method_21(fileName);
    }

    private void menuItem_62_Click(object sender, EventArgs e)
    {
        this.menuItem_1_Click(sender, e);
        this.menuItem_36_Click(sender, e);
    }

    private void menuItem_63_Click(object sender, EventArgs e)
    {
        if (new ac().ShowDialog() != DialogResult.OK)
            return;
        this.method_26(30, c.byte_1.ToString());
        this.method_26(31, c.byte_2.ToString());
        this.method_26(32, c.byte_3.ToString());
        this.method_26(33, c.byte_4.ToString());
        this.method_26(34, c.byte_5.ToString());
    }

    private void method_79()
    {
        double double2 = c.double_2;
        for (int index = 0; index < 256; ++index)
        {
            double num1 = Math.Pow((double)index / (double)byte.MaxValue, double2);
            double num2 = (double)c.byte_13 * num1;
            c.byte_21[index] = (byte)num2;
            if (c.bool_18)
                c.byte_21[index] = (byte)~c.byte_21[index];
        }
        for (int index = 0; index < 256; ++index)
        {
            double num3 = Math.Pow((double)index / (double)byte.MaxValue, double2);
            double num4 = (double)c.byte_14 * num3;
            c.byte_22[index] = (byte)num4;
            if (c.bool_18)
                c.byte_22[index] = (byte)~c.byte_22[index];
        }
        for (int index = 0; index < 256; ++index)
        {
            double num5 = Math.Pow((double)index / (double)byte.MaxValue, double2);
            double num6 = (double)c.byte_15 * num5;
            c.byte_23[index] = (byte)num6;
            if (c.bool_18)
                c.byte_23[index] = (byte)~c.byte_23[index];
        }
        switch (c.byte_1)
        {
            case 1:
                c.byte_21[(int)byte.MaxValue] = (byte)254;
                c.byte_22[(int)byte.MaxValue] = (byte)254;
                c.byte_23[(int)byte.MaxValue] = (byte)254;
                c.byte_6 = (byte)((uint)(byte)((uint)c.byte_3 << 3) | (uint)(byte)((uint)(byte)((uint)c.byte_4 >> 2) & 7U));
                c.byte_7 = (byte)((uint)(byte)((uint)c.byte_4 << 6) | (uint)(byte)((uint)c.byte_5 << 1));
                if (c.byte_2 == (byte)85)
                    c.byte_7 = c.byte_7;
                c.byte_7 = c.byte_7;
                byte[] numArray1 = new byte[8]
                {
          (byte) 1,
          (byte) 2,
          (byte) 4,
          (byte) 8,
          (byte) 16,
          (byte) 32,
          (byte) 64,
          (byte) 128
                };
                byte[] numArray2 = new byte[8]
                {
          (byte) 128,
          (byte) 64,
          (byte) 32,
          (byte) 16,
          (byte) 8,
          (byte) 4,
          (byte) 2,
          (byte) 1
                };
                byte num7 = 0;
                for (int index = 0; index < 8; ++index)
                {
                    if (((int)c.byte_6 & (int)numArray1[index]) != 0)
                        num7 |= numArray2[index];
                }
                c.byte_6 = num7;
                byte num8 = 0;
                for (int index = 0; index < 8; ++index)
                {
                    if (((int)c.byte_7 & (int)numArray1[index]) != 0)
                        num8 |= numArray2[index];
                }
                c.byte_7 = num8;
                break;
            case 2:
                c.byte_6 = (byte)((uint)(byte)((uint)c.byte_5 << 4) | (uint)c.byte_4);
                c.byte_7 = (byte)((uint)(byte)((uint)c.byte_3 << 4) | 9U);
                break;
            case 3:
                byte num9 = (byte)((uint)c.byte_3 >> 4);
                byte num10 = (byte)((uint)c.byte_3 & 15U);
                byte num11 = (byte)((uint)c.byte_4 >> 4);
                byte num12 = (byte)((uint)c.byte_4 & 15U);
                c.byte_6 = c.byte_5 != (byte)0 ? (byte)212 : (byte)84;
                if (((int)num10 & 4) != 0)
                    c.byte_6 |= (byte)1;
                c.byte_7 = (byte)((uint)num10 << 6);
                c.byte_7 |= (byte)((uint)num11 << 2);
                if (((int)num12 & 4) != 0)
                    c.byte_7 |= (byte)1;
                c.byte_8 = (byte)((uint)num12 << 6);
                c.byte_8 |= (byte)((uint)num9 << 1);
                break;
            case 4:
                byte num13 = (byte)((uint)c.byte_3 >> 4);
                byte num14 = (byte)((uint)c.byte_3 & 15U);
                byte num15 = (byte)((uint)c.byte_4 >> 4);
                byte num16 = (byte)((uint)c.byte_4 & 15U);
                c.byte_6 = (byte)((uint)num14 << 5);
                c.byte_6 |= (byte)((uint)num15 << 2);
                c.byte_6 |= (byte)((uint)num16 >> 1);
                c.byte_7 = (byte)((uint)num16 << 7);
                c.byte_7 |= (byte)((uint)num13 << 5);
                c.byte_7 |= (byte)19;
                c.byte_8 = byte.MaxValue;
                break;
            case 5:
                c.byte_6 = c.byte_3;
                c.byte_7 = c.byte_4;
                c.byte_8 = c.byte_5;
                break;
        }
    }

    private void toolStripButton_22_Click(object sender, EventArgs e) => this.menuItem_41_Click(sender, e);

    private void toolStripButton_23_Click(object sender, EventArgs e) => this.menuItem_33_Click(sender, e);

    private void toolStripButton_21_Click(object sender, EventArgs e) => this.menuItem_62_Click(sender, e);

    private void vscrollBar_0_Scroll(object sender, ScrollEventArgs e) => this.method_15();

    private void hscrollBar_0_Scroll(object sender, ScrollEventArgs e) => this.method_15();

    private void menuItem_64_Click(object sender, EventArgs e)
    {
        int int_0 = 2;
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Title = Module.a("ﮧ쮩\uDAAB쮭邯펱잳颵隷钹", 2);
        saveFileDialog.AddExtension = true;
        saveFileDialog.DefaultExt = Module.a("즧\uDCA9얫", 2);
        saveFileDialog.Filter = Module.a("\uE9A7ﲩ\uE5AB蚭骯鲱햳삵톷鎹삻钽\uEEBFꏁ닃꿅듇诉ꃋꋍ\uF0CF铑뷓뫕뷗\uF2D9\uF6DB\uF0DD쫟쯡飣쳥웧샩", 2);
        if (saveFileDialog.ShowDialog() != DialogResult.OK)
            return;
        string fileName = saveFileDialog.FileName;
        this.bool_21 = true;
        this.bool_12 = false;
        if (c.useEnglishLanguage)
            this.ShowMessage(Module.a("\uEDA7튩\uDCAB솭슯욱钳鲵隷骹ﶻ\uE8BD覿\uE2C1ꋃ꿅\uA4C7꿉\uECCB\uAACDꗏꃑ뷓룕뿗龎\uA8DB뛝藟싡鏣迥蛧軩菫駭탯英蛳駵郷鏹黻韽瓿∁椃椅縇按戋植』昑笓㘕栗栙猛瘝䤟䀡䴣別ࠧ帩䐫䬭ု弱崳堵儷圹䤻匽愿", int_0));
        else
            this.ShowMessage(Module.a("哼僸蚫肭\uF1AF\uE4B1ﶳ㇐仹ꗞ䠮銽\uECD8喻\u2790䞼ꪬㆰ撙\uE2CD冶낺풴\uD989캄ﯙ", int_0));
        this.menuItem_5_Click(sender, e);
        Bitmap firstFrame = new Bitmap(this.int_67, this.int_68);
        this.aviManager_0 = new AviManager(fileName, false);
        this.videoStream_0 = this.aviManager_0.AddVideoStream(false, 25.0, firstFrame);
        this.timer_1.Interval = 1;
        this.WindowState = FormWindowState.Maximized;
        this.TopMost = true;
        this.ControlBox = false;
    }

    private void menuItem_65_Click(object sender, EventArgs e)
    {
        string str = Application.StartupPath + Module.a("\uF5A8\uF8AA\uE8ACﮮ\uEDB0﮲킴\uDBB6즸閺\uDEBCힾ곀", 3);
        if (!System.IO.File.Exists(str))
            return;
        Help.ShowHelp((Control)this, str);
    }

    private void method_80()
    {
        for (int index = 0; index < c.arrayList_4.Count; ++index)
        {
            string string3 = ((GClass5)c.arrayList_4[index]).string_3;
            ((GClass5)c.arrayList_4[index]).bool_3 = false;
            if (System.IO.File.Exists(string3))
            {
                this.int_55 = 0;
                this.method_26(9, this.int_55.ToString());
                ((GClass5)c.arrayList_4[index]).int_0 = 0;
                ((GClass5)c.arrayList_4[index]).bool_2 = false;
                System.IO.File.Delete(string3);
            }
        }
        this.method_28();
    }

    private void menuItem_67_Click(object sender, EventArgs e)
    {
        int int_0 = 12;
        if (new p().ShowDialog() != DialogResult.OK)
            return;
        this.method_26(4, Module.a("花", int_0));
        this.method_26(6, Module.a("花", int_0));
        string path = this.string_20 + ((GClass5)c.arrayList_4[c.int_38]).string_3;
        ((GClass5)c.arrayList_4[c.int_38]).bool_3 = false;
        if (System.IO.File.Exists(path))
        {
            this.int_55 = 0;
            this.method_26(9, this.int_55.ToString());
            ((GClass5)c.arrayList_4[c.int_38]).int_0 = 0;
            ((GClass5)c.arrayList_4[c.int_38]).bool_2 = false;
            this.method_28();
            System.IO.File.Delete(path);
        }
        if (this.genum1_1 == GEnum1.const_6)
            this.genum1_1 = GEnum1.const_2;
        this.method_31();
    }

    private void menuItem_68_Click(object sender, EventArgs e) => this.menuItem_67_Click(sender, e);

    private void c_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyData == Keys.F6)
            ++this.int_19;
        else if (e.KeyData == Keys.F7)
            --this.int_19;
        if (this.menuItem_1.Enabled && e.KeyData == Keys.F5)
            this.method_13();
        if (this.int_19 > 10)
            this.int_19 = 10;
        if (this.int_19 >= -10)
            return;
        this.int_19 = -10;
    }

    private void menuItem_70_Click(object sender, EventArgs e)
    {
        ++this.int_19;
        if (this.int_19 > 10)
            this.int_19 = 10;
        if (this.int_19 < -10)
            this.int_19 = -10;
        this.bool_19 = false;
    }

    private void menuItem_71_Click(object sender, EventArgs e)
    {
        --this.int_19;
        if (this.int_19 > 10)
            this.int_19 = 10;
        if (this.int_19 < -10)
            this.int_19 = -10;
        this.bool_19 = false;
    }

    private void menuItem_72_Click(object sender, EventArgs e)
    {
        string str = Application.StartupPath + Module.a("\uECAFﺱ\uF1B3\uF2B5\uF4B7﮹\uE5BB\uF1BD閿雁飃諅跇軉胋迍觏鷑臓苕\uF6D7뿙ꓛ믝", 10);
        if (!System.IO.File.Exists(str))
            return;
        Process.Start(str);
    }

    private void method_81()
    {
        int int_0 = 1;
        this.treeView_0.Nodes.Clear();
        for (int index1 = 0; index1 < this.arrayList_3.Count; ++index1)
        {
            int num1 = ((GClass8)this.arrayList_3[index1]).method_4() / 8 + 1;
            int num2 = ((GClass8)this.arrayList_3[index1]).method_4() % 8 + 1;
            string str = Module.a("辦\uEAA8", int_0) + num1.ToString() + Module.a("\uF7A6", int_0) + num2.ToString() + Module.a("躦", int_0);
            TreeNode node = new TreeNode();
            node.Text = Module.a("\uD7A6", int_0) + (((GClass8)this.arrayList_3[index1]).method_4() + 1).ToString() + Module.a("鶦", int_0) + ((GClass8)this.arrayList_3[index1]).method_0().ToString() + str;
            this.treeView_0.Nodes.Add(node);
            for (int index2 = 0; index2 < ((GClass8)this.arrayList_3[index1]).method_0(); ++index2)
                node.Nodes.Add((((GClass8)this.arrayList_3[index1]).method_4() + 1).ToString() + Module.a("\uF8A6誨", int_0) + (index2 + 1).ToString());
        }
        this.int_41 = 0;
        this.int_42 = 0;
        foreach (GClass8 gclass8 in this.arrayList_3)
        {
            this.int_41 += gclass8.method_0();
            if (this.int_42 < gclass8.method_0())
                this.int_42 = gclass8.method_0();
        }
        if (c.useEnglishLanguage)
            this.label_12.Text = Module.a("\uF3A6욨\uDFAA첬쎮记", int_0) + this.int_41.ToString();
        else
            this.label_12.Text = Module.a("鳆웘\uDBCF鞬", int_0) + this.int_41.ToString();
        this.bool_16 = false;
        this.int_16 = (int)ushort.MaxValue;
    }

    private void menuItem_73_Click(object sender, EventArgs e)
    {
        int int_0 = 18;
        this.timer_1.Enabled = false;
        this.bool_7 = false;
        this.bool_8 = false;
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Title = Module.a("\uF7B7쪹\uD9BB킽", 18);
        openFileDialog.Filter = Module.a("\uF4B7\uDFB9\uD8BB\uF2BDꆿ믁诃독볇\uEAC9請\uA7CD볏럑ﳓﳕ\uF6D7맙ꓛ볝짟黡컣죥诧鋩軫鋭뇯黱飳훵뻷鏹郻鯽⣿⠁⨃Ⰵℇ瘉☋\u200D㨏", 18);
        openFileDialog.RestoreDirectory = true;
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            this.arrayList_1.Clear();
            this.method_80();
            string fileName = openFileDialog.FileName;
            if (this.method_82(fileName) != 0)
            {
                c.gclass1_0 = new GClass1((Control)this.panel_0);
                Rectangle rectangle_2 = new Rectangle(0, 0, this.panel_0.Width, this.panel_0.Height);
                Rectangle rectangle_3 = new Rectangle(0, 0, this.panel_0.Width, this.panel_0.Height);
                this.gclass0_2 = new GClass0(c.gclass1_0.method_1(), rectangle_2, rectangle_3);
                this.gclass0_2.method_12().ColorFill(Color.FromArgb(0, 0, 0));
                this.method_15();
                this.genum1_1 = GEnum1.const_1;
                this.method_31();
            }
            else
            {
                int num = fileName.LastIndexOf('\\');
                string string_24 = fileName.Substring(num + 1);
                this.method_26(2, Module.a("誷", int_0));
                this.method_26(3, string_24);
                this.method_26(4, Module.a("袷", int_0));
                this.method_26(6, Module.a("袷", int_0));
                string path = this.string_20 + (object)'\\' + ((GClass5)c.arrayList_4[c.int_38]).string_3;
                ((GClass5)c.arrayList_4[c.int_38]).bool_3 = false;
                if (System.IO.File.Exists(path))
                {
                    this.int_55 = 0;
                    this.method_26(9, this.int_55.ToString());
                    System.IO.File.Delete(path);
                }
                this.genum1_1 = GEnum1.const_2;
                this.method_31();
            }
        }
        this.method_81();
    }

    private int method_82(string string_24)
    {
        int int_0 = 3;
        this.arrayList_1.Clear();
        this.arrayList_0.Clear();
        this.arrayList_2.Clear();
        try
        {
            this.fileStream_2 = new FileStream(string_24, FileMode.Open, FileAccess.Read);
            this.bufferedStream_2 = new BufferedStream((Stream)this.fileStream_2);
        }
        catch
        {
            if (c.useEnglishLanguage)
                this.ShowMessage(Module.a("\uDDA8쎪좬辮ힰ\uDAB2\uD9B4튶馸\uD9BA\uD8BC횾꿀꓂\uE5C4닆뫈껊꧌\uEFCE돐\uAAD2\uF5D4뛖럘듚\uA9DC럞蓠釢엤韦鯨蓪諬鷮郰黲헴\uDBF6觸韺飼黾爀昂┄搆攈搊縌樎ㄐ簒愔编簘椚渜㼞儠儢䨤䀦嬨䨪䀬尮ᴰ䜲崴制圸ᬺ刼伾⑀ⵂ敄ⅆ⁈❊⡌潎ぐ㑒㑔㹖㝘穚", int_0));
            else
                this.ShowMessage(Module.a("⻍巤컇蟹ᨸ嗡뗺鷸닂㓤싳韋\uEDC0㑉뚕⩓뾙䢑욶䂐\uDF84広蚶힉\uD827", int_0));
            return 1;
        }
        byte[] buffer1 = new byte[512];
        this.bufferedStream_2.Seek(0L, SeekOrigin.Begin);
        this.bufferedStream_2.Read(buffer1, 0, 512);
        byte num = 0;
        byte[] numArray1 = new byte[16]
        {
      (byte) 63,
      (byte) 81,
      (byte) 46,
      (byte) 147,
      (byte) 93,
      (byte) 243,
      (byte) 194,
      (byte) 55,
      (byte) 107,
      (byte) 210,
      (byte) 127,
      (byte) 160,
      (byte) 189,
      (byte) 25,
      (byte) 83,
      (byte) 227
        };
        for (int index1 = 114; index1 < 246; ++index1)
        {
            byte index2 = (byte)(index1 % 16);
            num += (byte)((uint)buffer1[index1] ^ (uint)numArray1[(int)index2]);
        }
        for (int index = 185; index < 290; ++index)
            num += (byte)((uint)buffer1[index] ^ 165U);
        this.byte_42 = (byte)((uint)num ^ 90U);
        for (int index3 = 311; index3 < 427; ++index3)
        {
            byte index4 = (byte)(index3 % 16);
            num += (byte)((uint)buffer1[index3] ^ (uint)numArray1[(int)index4]);
        }
        for (int index = 430; index < 511; ++index)
            num += (byte)((uint)buffer1[index] ^ 90U);
        this.byte_43 = (byte)((uint)num ^ 165U);
        byte[] numArray2 = new byte[256];
        byte[] buffer2 = new byte[256];
        this.bufferedStream_2.Seek(512L, SeekOrigin.Begin);
        while (this.bufferedStream_2.Read(buffer2, 0, 256) == 256)
        {
            for (uint index = 0; index < 256U; ++index)
                numArray2[index] = (byte)((uint)buffer2[(index ^ (uint)this.byte_43)] - (uint)this.byte_42);
            for (int index = 0; index < 16; ++index)
            {
                if (numArray2[index * 16] == (byte)85)
                    this.arrayList_1.Add((object)new PointF((float)((int)numArray2[index * 16 + 2] * 256 + (int)numArray2[index * 16 + 3]), (float)((int)numArray2[index * 16 + 4] * 256 + (int)numArray2[index * 16 + 5])));
                if (numArray2[index * 16] == (byte)119)
                    this.arrayList_2.Add((object)new GClass2(new PointF((float)((int)numArray2[index * 16 + 2] * 256 + (int)numArray2[index * 16 + 3]), (float)((int)numArray2[index * 16 + 4] * 256 + (int)numArray2[index * 16 + 5])), Module.a("\uD9A8", int_0) + numArray2[index * 16 + 6].ToString()));
                if (numArray2[index * 16] == (byte)170)
                    this.arrayList_0.Add((object)new GClass7(new PointF((float)((int)numArray2[index * 16 + 2] * 256 + (int)numArray2[index * 16 + 3]), (float)((int)numArray2[index * 16 + 4] * 256 + (int)numArray2[index * 16 + 5])), new PointF((float)((int)numArray2[index * 16 + 6] * 256 + (int)numArray2[index * 16 + 7]), (float)((int)numArray2[index * 16 + 8] * 256 + (int)numArray2[index * 16 + 9]))));
            }
        }
        this.bufferedStream_2.Flush();
        this.bufferedStream_2.Close();
        this.fileStream_2.Close();
        this.double_3 = 0.5;
        this.int_18 = (int)(this.double_3 * 2.0);
        return this.method_11();
    }

    private void toolStripButton_24_Click(object sender, EventArgs e) => this.menuItem_72_Click(sender, e);

    private void toolStripButton_25_Click(object sender, EventArgs e) => this.menuItem_73_Click(sender, e);

    private void menuItem_75_Click(object sender, EventArgs e)
    {
        int num = (int)new ae().ShowDialog();
    }

    private void timer_3_Tick(object sender, EventArgs e)
    {
        if (!this.bool_24)
            return;
        DateTime now = DateTime.Now;
        if (this.dateTime_0.Hour != now.Hour || this.dateTime_0.Minute != now.Minute)
            return;
        Class5.smethod_2();
    }

    // Sets language to chinese
    private void menuItem_77_Click(object sender, EventArgs e)
    {
        c.useEnglishLanguage = false;
        string path = c.string_2 + "\\en.txt"; //Module.a("\uEEB1톳\uD8B5隷캹쒻쪽", 12);
        if (System.IO.File.Exists(path))
            System.IO.File.Delete(path);
        using (StreamWriter streamWriter = new StreamWriter(path, false, Encoding.ASCII))
            streamWriter.WriteLine(c.useEnglishLanguage.ToString());
        Application.ExitThread();
        Thread.Sleep(500);
        this.method_83();
    }

    // Sets language to English
    private void menuItem_78_Click(object sender, EventArgs e)
    {
        c.useEnglishLanguage = true;
        string path = c.string_2 + "\\en.txt"; //Module.a("\uF2AD햯\uDCB1骳습삷캹", 8);
        if (System.IO.File.Exists(path))
            System.IO.File.Delete(path);
        using (StreamWriter streamWriter = new StreamWriter(path, false, Encoding.ASCII))
            streamWriter.WriteLine(c.useEnglishLanguage.ToString());
        Application.ExitThread();
        Thread.Sleep(500);
        this.method_83();
    }

    private void method_83()
    {
        Thread thread = new Thread(new ParameterizedThreadStart(this.method_84));
        object executablePath = (object)Application.ExecutablePath;
        Thread.Sleep(1000);
        thread.Start(executablePath);
    }

    private void method_84(object object_0) => new Process()
    {
        StartInfo = {
      FileName = object_0.ToString()
    }
    }.Start();

    private void menuItem_79_Click(object sender, EventArgs e)
    {
        int int_0 = 16;
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Title = Module.a("\uE5B5\uD9B7첹\uD9BB麽ꆿ뇁\uEAC3\uE8C5\uE6C7", 16);
        saveFileDialog.AddExtension = true;
        saveFileDialog.DefaultExt = Module.a("튵삷\uDCB9", 16);
        saveFileDialog.Filter = Module.a("튵삷\uDCB9钻钽\uEEBFꛁ볃ꃅ\uE1C7뛉\uE6CB\uE0CD듏\uAAD1닓\uAAD5駗뛙냛ﻝꛟ诡裣菥샧샩싫쓭\uD9EF軱\uDEF3\uD8F5틷", 16);
        if (saveFileDialog.ShowDialog() != DialogResult.OK)
            return;
        string fileName = saveFileDialog.FileName;
        if (System.IO.File.Exists(fileName))
        {
            try
            {
                System.IO.File.Delete(fileName);
            }
            catch
            {
                if (c.useEnglishLanguage)
                    this.ShowMessage(Module.a("\uE6B5풷\uDFB9\uDDBB춽ꖿ\uE2C1ꋃ꿅뫇막룋\uEECD돏뻑믓ꗕ뷗龎\uA8DB뛝藟싡컣죥賧鋩諫컭雯鯱飳鏵퓷\uDAF9鷻跽\u20FF瘁氃挅⠇氉攋戍甏㈑紓攕㠗猙爛㸝唟儡䄣ܥ", int_0));
                else
                    this.ShowMessage(Module.a("㇐仹\uD9D2铬쇲\uE8CA\uEF8F\uE8C3躔뮖❜\uE6CB\uE0CD듏\uAAD1닓冰⺙\uDB26", int_0));
            }
        }
        try
        {
            using (StreamWriter streamWriter_0 = new StreamWriter(fileName, false, Encoding.ASCII))
            {
                streamWriter_0.Write(Class6.string_0);
                foreach (GClass8 gclass8 in this.arrayList_3)
                {
                    for (int int_2 = 0; int_2 < gclass8.method_0(); ++int_2)
                        this.method_32(streamWriter_0, gclass8.method_6(int_2).X, c.int_66 - gclass8.method_6(int_2).Y, this.double_3);
                }
                foreach (PointF pointF in this.arrayList_1)
                {
                    Point point = new Point((int)pointF.X, (int)pointF.Y);
                    this.method_33(streamWriter_0, point.X, c.int_66 - point.Y, this.double_3);
                }
                foreach (GClass8 gclass8 in this.arrayList_3)
                {
                    if (gclass8.method_0() > 1)
                    {
                        for (int int_2 = 0; int_2 < gclass8.method_0() - 1; ++int_2)
                            this.method_34(streamWriter_0, (double)gclass8.method_6(int_2).X, (double)(c.int_66 - gclass8.method_6(int_2).Y), (double)gclass8.method_6(int_2 + 1).X, (double)(c.int_66 - gclass8.method_6(int_2 + 1).Y));
                    }
                }
                foreach (GClass8 gclass8 in this.arrayList_3)
                {
                    this.method_36(streamWriter_0, (double)gclass8.method_6(0).X - 1.5, (double)(c.int_66 - gclass8.method_6(0).Y) + 0.5, gclass8.method_4() + 1);
                    this.method_35(streamWriter_0, (double)gclass8.method_6(0).X - 1.5, (double)(c.int_66 - gclass8.method_6(0).Y) + 0.5, (double)gclass8.method_6(0).X, (double)(c.int_66 - gclass8.method_6(0).Y));
                }
                streamWriter_0.Write(Class6.string_1);
            }
        }
        catch
        {
        }
    }

    private void menuItem_80_Click(object sender, EventArgs e)
    {
        int num = (int)new v().ShowDialog();
    }

    private void toolStripButton_26_Click(object sender, EventArgs e) => this.menuItem_59_Click((object)null, (EventArgs)null);

    private void menuItem_81_Click(object sender, EventArgs e)
    {
        c.i_0.BackgroundImage = (Image)null;
        c.i_0.BackgroundImageLayout = ImageLayout.Tile;
        c.i_0.TransparencyKey = this.d_0.BackColor;
        c.i_0.Opacity = 1.0;
    }

    private void menuItem_82_Click(object sender, EventArgs e)
    {
        c.i_0.Opacity = 0.5;
        c.i_0.BackgroundImage = this.image_1;
        c.i_0.BackgroundImageLayout = ImageLayout.Stretch;
    }

    private void menuItem_83_Click(object sender, EventArgs e) => this.method_13();

    private void menuItem_84_Click(object sender, EventArgs e) => new af().Show();

    private void menuItem_85_Click(object sender, EventArgs e) => new s().Show();

    private void menuItem_86_Click(object sender, EventArgs e)
    {
        int int_0 = 17;
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Title = Module.a("\uE4B6\uD8B8춺\uD8BC龾ꃀ냂\uEBC4\uE9C6\uE7C8", 17);
        saveFileDialog.AddExtension = true;
        saveFileDialog.DefaultExt = Module.a("쒶캸\uDDBA", 17);
        saveFileDialog.Filter = Module.a("\uE4B6\uEEB8ﶺ閼閾\uEFC0냂닄ꇆ\uE0C8럊\uE7CC\uE1CEꋐꓒ돔ꯖ飘럚뇜\uFFDE\uA7E0諢觤苦쇨쇪쏬엮\uD8F0迲\uDFF4\uD9F6폸", 17);
        if (saveFileDialog.ShowDialog() != DialogResult.OK)
            return;
        this.string_4 = saveFileDialog.FileName;
        this.bool_21 = true;
        this.bool_12 = true;
        if (c.useEnglishLanguage)
            this.ShowMessage(Module.a("\uF2B6솸쮺튼춾뗀\uE3C2\uEFC4\uE9C6\uE9C8飊髌觎\uF1D0뗒볔믖볘ﯚ맜꫞鏠諢诤胦짨\u9FEA藬諮퇰蓲鳴駶鷸铺諼\uDFFE焀焂樄漆怈椊搌笎ㄐ縒稔愖瀘甚稜㼞唠䰢Ԥ圦嬨䐪䔬䘮匰娲䄴᜶䴸区堼Ἶⱀ⩂⭄\u2E46⑈㹊⁌湎", int_0));
        else
            this.ShowMessage(Module.a("䯭䏩醺鎼\uECBE雀藂䊡ㆈ횯㽟\uE1CC\uE3A9䚪め咭떽⊡玈\uF1DC座莋\uE385\uEAB8\uF1B5죨", int_0));
        this.menuItem_5_Click(sender, e);
        Bitmap bitmap = new Bitmap(this.int_67, this.int_68);
        if (System.IO.File.Exists(this.string_5))
            System.IO.File.Delete(this.string_5);
        bitmap.Save(this.string_5, ImageFormat.Jpeg);
        this.image_0 = Image.FromFile(this.string_5);
        int width = this.image_0.Width;
        int height = this.image_0.Height;
        this.swf_0 = new Swf();
        this.swf_0.Size = new Rect(0, 0, (0 + width) * 20, (0 + height) * 20);
        this.swf_0.Version = (byte)7;
        this.swf_0.Header.Signature = Module.a("\uF4B6\uEEB8\uE8BA", int_0);
        this.swf_0.Header.Fps = (float)c.smethod_0();
        this.swf_0.Tags.Add((BaseTag)new SetBackgroundColorTag(byte.MaxValue, byte.MaxValue, byte.MaxValue));
        this.image_0.Dispose();
        this.timer_1.Interval = 1;
    }

    private void menuItem_87_Click(object sender, EventArgs e)
    {
        switch (c.byte_1)
        {
            case 1:
            case 2:
                if (new u().ShowDialog() == DialogResult.OK)
                {
                    this.method_26(30, c.byte_1.ToString());
                    this.method_26(31, c.byte_2.ToString());
                    this.method_26(32, c.byte_3.ToString());
                    this.method_26(33, c.byte_4.ToString());
                    this.method_26(34, c.byte_5.ToString());
                }
                this.method_79();
                break;
            case 3:
            case 4:
                if (new w().ShowDialog() == DialogResult.OK)
                {
                    this.method_26(30, c.byte_1.ToString());
                    this.method_26(31, c.byte_2.ToString());
                    this.method_26(32, c.byte_3.ToString());
                    this.method_26(33, c.byte_4.ToString());
                    this.method_26(34, c.byte_5.ToString());
                }
                this.method_79();
                break;
            case 5:
                if (new j().ShowDialog() == DialogResult.OK)
                {
                    this.method_26(30, c.byte_1.ToString());
                    this.method_26(31, c.byte_2.ToString());
                    this.method_26(32, c.byte_3.ToString());
                    this.method_26(33, c.byte_4.ToString());
                    this.method_26(34, c.byte_5.ToString());
                }
                this.method_79();
                break;
        }
    }

    private void menuItem_88_Click(object sender, EventArgs e)
    {
        int int_0 = 13;
        string str = c.useEnglishLanguage ? Application.StartupPath + Module.a("\uEFB2\uF0B4톶\uDFB8\uDEBA\uDEBC쮾黀ꛂꯄ鯆蛈뿊ꗌ\uAACEꏐꃒ觔铖뛘럚닜귞쇠胢跤蛦蟨質裬쇮苰蓲鏴", int_0) : Application.StartupPath + Module.a("\uEFB2\uF0B4톶\uDFB8\uDEBA\uDEBC쮾黀ꛂꯄ鯆蛈뿊ꗌ\uAACEꏐꃒ觔铖뛘럚닜귞쇠胢跤蛦蟨質裬쇮苰蓲鏴", int_0);
        if (!System.IO.File.Exists(str))
            return;
        this.method_21(str);
    }

    private void menuItem_89_Click(object sender, EventArgs e)
    {
        int int_0 = 11;
        string str = c.useEnglishLanguage ? Application.StartupPath + Module.a("\uEDB0\uF6B2펴톶\uDCB8\uD8BA즼\uE0BE꓀귂駄裆뷈ꏊ\uA8CC뷎ꋐ迒雔룖뗘듚꿜\uFFDE蛠釢蓤菦胨軪菬鯮\uDFF0胲苴釶", int_0) : Application.StartupPath + Module.a("\uEDB0\uF6B2펴톶\uDCB8\uD8BA즼\uE0BE꓀귂駄裆뷈ꏊ\uA8CC뷎ꋐ迒雔룖뗘듚꿜\uFFDE蛠釢蓤菦胨軪菬鯮\uDFF0胲苴釶", int_0);
        if (!System.IO.File.Exists(str))
            return;
        this.method_21(str);
    }

    private void menuItem_90_Click(object sender, EventArgs e)
    {
        int int_0 = 1;
        string str = c.useEnglishLanguage ? Application.StartupPath + Module.a("ﮦ\uECA8춪쮬쪮튰잲\uEAB4튶ힸ\uE7BA\uF2BC쮾꧀ꛂ럄듆闈鯊곌볎ꋐ닒닔닖\uF7D8\uA8DAꫜ맞", int_0) : Application.StartupPath + Module.a("ﮦ\uECA8춪쮬쪮튰잲\uEAB4튶ힸ\uE7BA\uF2BC쮾꧀ꛂ럄듆闈鯊곌볎ꋐ닒닔닖\uF7D8\uA8DAꫜ맞", int_0);
        if (!System.IO.File.Exists(str))
            return;
        this.method_21(str);
    }

    private void menuItem_91_Click(object sender, EventArgs e) => this.method_12();

    private void method_85()
    {
        this.fileStream_0 = new FileStream(this.string_6, FileMode.Open, FileAccess.Read);
        this.bufferedStream_0 = new BufferedStream((Stream)this.fileStream_0);
    }

    private void method_86()
    {
        this.bufferedStream_0.Flush();
        this.bufferedStream_0.Close();
        this.fileStream_0.Close();
    }

    private void menuItem_92_Click(object sender, EventArgs e)
    {
        this.menuItem_9_Click(sender, e);
        this.int_19 = 0;
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Title = Module.a("\uE6A8\uDBAA좬솮", 3);
        openFileDialog.Filter = Module.a("\uDDA8쒪솬辮ힰ\uDAB2\uD9B4튶醸醺鎼쮾껀꿂\uECC4믆\uE3C8\uE5CA만ꃎ뷐꿒铔믖뗘ﯚ맜냞苠離裤苦蟨\u9FEA黬쟮\uDBF0\uDDF2\uDFF4\uDEF6藸퇺폼헾", 3);
        openFileDialog.RestoreDirectory = true;
        if (openFileDialog.ShowDialog() != DialogResult.OK)
            return;
        this.string_6 = openFileDialog.FileName;
        this.method_85();
        byte[] buffer = new byte[16];
        this.bufferedStream_0.Seek(0L, SeekOrigin.Begin);
        this.bufferedStream_0.Read(buffer, 0, 16);
        this.int_11 = (int)buffer[1] * 65536 + (int)buffer[2] * 256 + (int)buffer[3];
        this.int_13 = (int)buffer[4] * 256 + (int)buffer[5];
        this.int_12 = (int)buffer[6] * 256 + (int)buffer[7];
        this.int_15 = 0;
        this.int_14 = this.int_12 * this.int_13 * 3;
        this.byte_16 = new byte[this.int_14];
        this.method_13();
        this.bool_57 = true;
        this.bool_50 = false;
        this.bool_37 = true;
        this.timer_1.Interval = 1000 / c.smethod_0();
        this.timer_1.Enabled = true;
        this.bool_39 = false;
        this.bool_40 = false;
        this.genum1_1 = GEnum1.const_4;
        this.method_31();
        if (this.bool_4)
        {
            c.bool_51 = true;
            this.a_0.method_1();
        }
        this.bool_13 = true;
    }

    private void menuItem_93_Click(object sender, EventArgs e)
    {
        int int_0 = 17;
        this.timer_1.Enabled = false;
        this.bool_7 = false;
        this.bool_8 = false;
        this.arrayList_1.Clear();
        this.method_80();
        c.byte_9 = (byte)2;
        if (new GForm0().ShowDialog() != DialogResult.OK)
            return;
        switch (this.method_4())
        {
            case 1:
                c.gclass1_0 = new GClass1((Control)this.panel_0);
                Rectangle rectangle_2 = new Rectangle(0, 0, this.panel_0.Width, this.panel_0.Height);
                Rectangle rectangle_3 = new Rectangle(0, 0, this.panel_0.Width, this.panel_0.Height);
                this.gclass0_2 = new GClass0(c.gclass1_0.method_1(), rectangle_2, rectangle_3);
                this.gclass0_2.method_12().ColorFill(Color.FromArgb(0, 0, 0));
                this.method_15();
                this.genum1_1 = GEnum1.const_1;
                this.method_31();
                break;
            case 3:
                break;
            default:
                this.method_26(4, Module.a("螶", int_0));
                this.method_26(6, Module.a("螶", int_0));
                this.genum1_1 = GEnum1.const_2;
                this.method_31();
                this.method_81();
                break;
        }
    }

    private void toolStripMenuItem_5_Click(object sender, EventArgs e) => this.menuItem_83_Click((object)null, (EventArgs)null);

    private void toolStripMenuItem_6_Click(object sender, EventArgs e) => this.menuItem_19_Click((object)null, (EventArgs)null);

    private void toolStripMenuItem_7_Click(object sender, EventArgs e) => this.menuItem_38_Click((object)null, (EventArgs)null);

    private void toolStripMenuItem_8_Click(object sender, EventArgs e) => this.menuItem_57_Click((object)null, (EventArgs)null);

    private void toolStripMenuItem_9_Click(object sender, EventArgs e) => this.menuItem_63_Click((object)null, (EventArgs)null);

    private void toolStripMenuItem_10_Click(object sender, EventArgs e) => this.menuItem_87_Click((object)null, (EventArgs)null);

    private void toolStripMenuItem_11_Click(object sender, EventArgs e) => this.menuItem_17_Click((object)null, (EventArgs)null);

    private void toolStripMenuItem_12_Click(object sender, EventArgs e) => this.menuItem_70_Click((object)null, (EventArgs)null);

    private void toolStripMenuItem_13_Click(object sender, EventArgs e) => this.menuItem_71_Click((object)null, (EventArgs)null);

    private void menuItem_94_Click(object sender, EventArgs e)
    {
        int int_0 = 1;
        this.bool_19 = false;
        this.bool_57 = false;
        this.d_0.axShockwaveFlash_0.GotoFrame(0);
        if (this.bool_19)
            this.d_0.axShockwaveFlash_0.Play();
        if (this.bool_13)
            this.int_15 = 0;
        this.menuItem_20_Click(sender, e);
        this.method_26(6, Module.a("鞦", int_0));
        this.timer_1.Interval = 1;
    }

    private void menuItem_95_Click(object sender, EventArgs e)
    {
        int int_0 = 0;
        for (int index = 0; index < c.arrayList_4.Count; ++index)
        {
            if (!System.IO.File.Exists(this.string_20 + ((GClass5)c.arrayList_4[index]).string_3) || !((GClass5)c.arrayList_4[index]).bool_2)
            {
                if (c.useEnglishLanguage)
                {
                    this.ShowMessage(Module.a("\uF6A5\uDAA7얩쮫\uDCAD톯\uDFB1", int_0) + ((GClass5)c.arrayList_4[index]).string_0 + Module.a("좥잧誩\uDEAB쮭펯\uDDB1욳튵톷풹\uDBBB龽", int_0));
                    return;
                }
                this.ShowMessage(Module.a("\u2427䛑", int_0) + ((GClass5)c.arrayList_4[index]).string_0 + Module.a("䛀ﷸ鳻⧺\u17F6醯", int_0));
                return;
            }
        }
        ac ac = new ac();
        ac.BringToFront();
        if (ac.ShowDialog() != DialogResult.OK)
            return;
        this.bool_5 = true;
        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
        {
            string path = folderBrowserDialog.SelectedPath + Module.a("瘟\uE4A7쾩좫", int_0);
            if (Directory.Exists(path))
                Directory.Delete(path, true);
            Directory.CreateDirectory(path);
            for (int index = 0; index < c.arrayList_4.Count; ++index)
            {
                string str1 = this.string_20 + ((GClass5)c.arrayList_4[index]).string_3;
                string str2 = this.string_20 + ((GClass5)c.arrayList_4[index]).string_1 + Module.a("瘟쪧쎩슫", int_0);
                if (Directory.Exists(str2))
                    Directory.Delete(str2, true);
                Directory.CreateDirectory(str2);
                c.int_38 = index;
                this.textBox_4.Text = this.listBox_0.Items[c.int_38].ToString();
                if (System.IO.File.Exists(str1))
                    this.method_40(str1, str2);
                string sourceFileName = str2 + Module.a("瘟颧骩芫슭햯횱", int_0);
                string str3 = index >= 10 ? index.ToString() : '0'.ToString() + index.ToString();
                string destFileName = path + (object)'\\' + str3 + Module.a("殮", int_0) + ((GClass5)c.arrayList_4[index]).string_0 + Module.a("袥쪧쎩슫", int_0);
                System.IO.File.Copy(sourceFileName, destFileName, true);
            }
        }
        this.bool_5 = false;
    }

    private void menuItem_96_Click(object sender, EventArgs e) => this.menuItem_61_Click((object)null, (EventArgs)null);

    private void menuItem_97_Click(object sender, EventArgs e) => new x().Show();

    private void menuItem_98_Click(object sender, EventArgs e)
    {
        int int_0 = 10;
        ab.int_0 = this.int_40;
        ab.string_0 = Module.a("韱\uD8E3耾", 10);
        ab.int_1 = 1;
        if (new ab().ShowDialog() != DialogResult.OK)
            return;
        int length = ab.int_3 - ab.int_2 + 1;
        int int2 = ab.int_2;
        if (length == this.textBox_0.TextLength)
        {
            if (c.useEnglishLanguage)
                this.ShowMessage(Module.a("\uE5AF\uDCB1햳풵풷\uDFB9鲻쪽꾿\uE2C1\uA7C3독볇\uE7C9귋ꃍ듏\uFFD1ꓓ럕ꯗ껙맛ﻝ臟軡裣웥鳧苩觫컭雯胱闳鯵鷷觹\uDDFB", int_0));
            else
                this.ShowMessage(Module.a("뷡伱\uDEE1舸\uF8D5돞鯥뽂", int_0));
        }
        else
        {
            this.int_49 = new int[this.int_45.Length];
            for (int index = 0; index < this.int_45.Length; ++index)
                this.int_49[index] = this.int_45[index];
            this.toolStripMenuItem_4.Enabled = true;
            this.menuItem_102.Enabled = true;
            this.bool_46 = true;
            this.menuItem_31.Enabled = true;
            this.Text = this.string_8 + Module.a("\uEBAF龱馳", int_0) + this.string_22 + (object)']' + Module.a("邯颱", int_0);
            this.int_48 = new int[length];
            for (int index = 0; index < length; ++index)
                this.int_48[index] = this.int_45[int2 + index];
            this.toolStripMenuItem_2.Enabled = true;
            this.menuItem_100.Enabled = true;
            this.int_47 = new int[this.int_50];
            int index1 = 0;
            for (int index2 = 0; index2 < int2; ++index2)
            {
                this.int_47[index1] = this.int_45[index2];
                ++index1;
            }
            for (int index3 = length + int2; index3 < this.int_50; ++index3)
            {
                this.int_47[index1] = this.int_45[index3];
                ++index1;
            }
            this.int_50 = index1;
            this.int_45 = new int[this.int_50];
            for (int index4 = 0; index4 < this.int_50; ++index4)
                this.int_45[index4] = this.int_47[index4];
            this.int_55 = int2;
            this.int_40 = this.int_50;
            this.trackBar_0.Minimum = 0;
            this.trackBar_0.Maximum = this.int_40 - 1;
            this.textBox_0.Text = "";
            for (int index5 = 0; index5 < this.int_40; ++index5)
                this.textBox_0.Text += (string)(object)'■';
            this.textBox_0.SelectionStart = int2;
            this.toolStripTextBox_0.Text = (this.int_55 + 1).ToString() + (object)'/' + this.int_40.ToString();
            if (!this.bool_47)
                return;
            this.bool_47 = false;
            this.toolStripMenuItem_0.Enabled = false;
            this.toolStripMenuItem_1.Enabled = false;
            this.toolStripMenuItem_3.Enabled = false;
        }
    }

    private void menuItem_99_Click(object sender, EventArgs e)
    {
        ab.int_0 = this.int_40;
        ab.string_0 = Module.a("部듡跨", 17);
        ab.int_1 = 0;
        if (new ab().ShowDialog() != DialogResult.OK)
            return;
        int length = ab.int_3 - ab.int_2 + 1;
        int int2 = ab.int_2;
        this.int_48 = new int[length];
        for (int index = 0; index < length; ++index)
            this.int_48[index] = this.int_45[int2 + index];
        this.toolStripMenuItem_2.Enabled = true;
        this.menuItem_100.Enabled = true;
    }

    private void menuItem_100_Click(object sender, EventArgs e)
    {
        int int_0 = 15;
        m.int_0 = this.int_40;
        m.string_0 = Module.a("鋪⿊贵", 15);
        if (new m().ShowDialog() != DialogResult.OK)
            return;
        int int2 = ab.int_2;
        int length = this.int_48.Length;
        this.int_49 = new int[this.int_45.Length];
        for (int index = 0; index < this.int_45.Length; ++index)
            this.int_49[index] = this.int_45[index];
        this.toolStripMenuItem_4.Enabled = true;
        this.menuItem_102.Enabled = true;
        this.bool_46 = true;
        this.menuItem_31.Enabled = true;
        this.Text = this.string_8 + Module.a("\uEEB4骶钸", int_0) + this.string_22 + (object)']' + Module.a("閴鶶", int_0);
        this.int_47 = new int[this.int_50 + length];
        int index1 = 0;
        for (int index2 = 0; index2 < int2; ++index2)
        {
            this.int_47[index1] = this.int_45[index2];
            ++index1;
        }
        for (int index3 = 0; index3 < length; ++index3)
        {
            this.int_47[index1] = this.int_48[index3];
            ++index1;
        }
        for (int index4 = int2; index4 < this.int_50; ++index4)
        {
            this.int_47[index1] = this.int_45[index4];
            ++index1;
        }
        this.int_50 = index1;
        this.int_45 = new int[this.int_50];
        for (int index5 = 0; index5 < this.int_50; ++index5)
            this.int_45[index5] = this.int_47[index5];
        this.int_55 = int2;
        this.int_40 = this.int_50;
        this.trackBar_0.Minimum = 0;
        this.trackBar_0.Maximum = this.int_40 - 1;
        this.textBox_0.Text = "";
        for (int index6 = 0; index6 < this.int_40; ++index6)
            this.textBox_0.Text += (string)(object)'■';
        this.textBox_0.SelectionStart = int2;
        this.toolStripTextBox_0.Text = (this.int_55 + 1).ToString() + (object)'/' + this.int_40.ToString();
    }

    private void menuItem_101_Click(object sender, EventArgs e)
    {
        int int_0 = 13;
        ab.int_0 = this.int_40;
        ab.string_0 = Module.a("铬闦팠", 13);
        ab.int_1 = 1;
        if (new ab().ShowDialog() != DialogResult.OK)
            return;
        int num = ab.int_3 - ab.int_2 + 1;
        int int2 = ab.int_2;
        if (num == this.textBox_0.TextLength)
        {
            if (c.useEnglishLanguage)
                this.ShowMessage(Module.a("\uE6B2\uDBB4횶\uDBB8ힺ\uD8BC龾뗀곂\uE5C4ꏆ곈\uA7CA\uA8CC믎듐\uF3D2듔믖뗘ﯚ\uA9DC럞蓠쏢菤闦裨蛪裬鳮탰", int_0));
            else
                this.ShowMessage(Module.a("뻼䠴韤\uDD2Eﯘ듛飠쀿", int_0));
        }
        else
        {
            this.int_49 = new int[this.int_45.Length];
            for (int index = 0; index < this.int_45.Length; ++index)
                this.int_49[index] = this.int_45[index];
            this.toolStripMenuItem_4.Enabled = true;
            this.menuItem_102.Enabled = true;
            this.bool_46 = true;
            this.menuItem_31.Enabled = true;
            this.Text = this.string_8 + Module.a("\uE8B2颴骶", int_0) + this.string_22 + (object)']' + Module.a("鎲龴", int_0);
            this.int_47 = new int[this.int_50];
            int index1 = 0;
            for (int index2 = 0; index2 < int2; ++index2)
            {
                this.int_47[index1] = this.int_45[index2];
                ++index1;
            }
            for (int index3 = num + int2; index3 < this.int_50; ++index3)
            {
                this.int_47[index1] = this.int_45[index3];
                ++index1;
            }
            this.int_50 = index1;
            this.int_45 = new int[this.int_50];
            for (int index4 = 0; index4 < this.int_50; ++index4)
                this.int_45[index4] = this.int_47[index4];
            this.int_55 = int2;
            this.int_40 = this.int_50;
            this.trackBar_0.Minimum = 0;
            this.trackBar_0.Maximum = this.int_40 - 1;
            this.textBox_0.Text = "";
            for (int index5 = 0; index5 < this.int_40; ++index5)
                this.textBox_0.Text += (string)(object)'■';
            this.textBox_0.SelectionStart = int2;
            this.toolStripTextBox_0.Text = (this.int_55 + 1).ToString() + (object)'/' + this.int_40.ToString();
        }
    }

    private void menuItem_102_Click(object sender, EventArgs e) => this.toolStripMenuItem_4_Click((object)null, (EventArgs)null);

    private void panel_0_MouseDown(object sender, MouseEventArgs e)
    {
        if (this.int_85 < 1)
            return;
        int num1 = e.X / this.int_85;
        int num2 = e.Y / this.int_85;
        this.label_13.Text = num1.ToString() + (object)',' + num2.ToString();
    }

    private void button_1_Click(object sender, EventArgs e)
    {
        int int_0 = 15;
        if (c.arrayList_4.Count == 0)
        {
            if (c.useEnglishLanguage)
                this.ShowMessage(Module.a("\uE5B4\uDBB6\uDCB8\uDABA캼\uDABE\uE1C0ꃂ럄ꋆ\uA8C8뿊\uA8CC\uEFCE냐\uF3D2ꗔꗖ뛘뇚룜볞闠싢", int_0));
            else
                this.ShowMessage(Module.a("䈿\uFFE7ঢ়䇤뷲闰롘ⶴ\uE4C4", int_0));
        }
        else if (c.arrayList_4.Count >= 32)
        {
            if (c.useEnglishLanguage)
                this.ShowMessage(Module.a("\uE1B4\uD8B6춸\uDABA톼龾뇀뇂\uAAC4ꃆ믈\uAACAꃌ\uEFCE닐닒믔\uF7D6럘듚\uA9DC\uFFDE蓠鯢蛤苦賨迪췬\uDCEE쏰틲", int_0));
            else
                this.ShowMessage(Module.a("㜶姀苘쯟냲䈾䑍э\uF6C4\uF5C6\uE8C8", int_0));
        }
        else
        {
            if (this.genum1_1 == GEnum1.const_7)
            {
                this.menuItem_6_Click(sender, e);
                this.method_31();
            }
            ag.string_0 = !c.useEnglishLanguage ? Module.a("㜶姀", int_0) + (c.arrayList_4.Count + 1).ToString() : Module.a("\uE5B4얶횸\uDCBA쾼\uDEBE곀", int_0) + (c.arrayList_4.Count + 1).ToString();
        label_18:
            while (new ag().ShowDialog() == DialogResult.OK)
            {
                string string0 = ag.string_0;
                for (int index = 0; index < c.arrayList_4.Count; ++index)
                {
                    if (string0 == ((GClass5)c.arrayList_4[index]).string_0)
                    {
                        if (c.useEnglishLanguage)
                        {
                            this.ShowMessage(Module.a("\uE1B4\uDFB6\uDCB8鮺펼\uDEBE곀ꛂ\uE5C4ꛆꗈ맊\uA8CC껎뗐\uAAD2\uF5D4닖ꇘ닚껜ꯞ鋠쿢闤详賨諪黬諮퇰臲郴\uDAF6鳸闺觼髾猀∂", int_0));
                            goto label_18;
                        }
                        else
                        {
                            this.ShowMessage(Module.a("倿뫢䧁䧧狂\uE7E5\uE997\uEFC2\u324F\u0A57禭塅ꢝ\uEECE", int_0));
                            goto label_18;
                        }
                    }
                }
                string string_5 = Module.a("\uE9B4", int_0) + string0;
                string path = c.string_21 + string_5;
                if (Directory.Exists(path))
                    Directory.Delete(path, true);
                GClass5 gclass5 = new GClass5(string0, string_5, string_5 + Module.a("\uE9B4\uE8B6쮸\uDEBA\uDEBC醾ꏀꫂꯄ", int_0));
                gclass5.gclass6_0[0] = new GClass6();
                gclass5.gclass6_0[1] = new GClass6();
                gclass5.gclass6_0[2] = new GClass6();
                gclass5.gclass6_0[3] = new GClass6();
                gclass5.gclass6_0[4] = new GClass6();
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                c.arrayList_4.Add((object)gclass5);
                this.method_28();
                c.int_38 = c.arrayList_4.Count - 1;
                this.method_25();
                this.textBox_4.Text = this.listBox_0.Items[c.int_38].ToString();
                break;
            }
        }
    }

    private void listBox_0_DoubleClick(object sender, EventArgs e)
    {
        if (this.genum1_1 == GEnum1.const_8)
            return;
        if (this.genum1_1 == GEnum1.const_7)
            this.menuItem_6_Click(sender, e);
        if (this.listBox_0.SelectedIndex < 0 || this.listBox_0.SelectedIndex >= c.arrayList_4.Count)
            return;
        c.int_38 = this.listBox_0.SelectedIndex;
        this.textBox_4.Text = this.listBox_0.Items[c.int_38].ToString();
        this.bool_11 = true;
        this.menuItem_5_Click(sender, e);
        this.bool_11 = false;
    }

    private void trackBar_0_MouseDown(object sender, MouseEventArgs e) => this.menuItem_25_Click(sender, (EventArgs)e);

    private void menuItem_22_Popup(object sender, EventArgs e)
    {
        if (this.genum1_1 != GEnum1.const_7)
            return;
        this.menuItem_6_Click(sender, e);
    }

    private void menuItem_23_Popup(object sender, EventArgs e)
    {
        if (this.genum1_1 != GEnum1.const_7)
            return;
        this.menuItem_6_Click(sender, e);
    }

    private void treeView_0_AfterSelect(object sender, TreeViewEventArgs e)
    {
        if (this.treeView_0.SelectedNode == null)
            return;
        if (this.treeView_0.SelectedNode.Parent == null)
        {
            string str = this.treeView_0.SelectedNode.Text.Split(':')[0];
            this.int_16 = Convert.ToInt32(str.Substring(1, str.Length - 1)) - 1;
            this.bool_15 = true;
        }
        else
        {
            string text = this.treeView_0.SelectedNode.Text;
            this.int_16 = Convert.ToInt32(text.Split('_')[0]) - 1;
            this.int_17 = Convert.ToInt32(text.Split('#')[1]) - 1;
            this.bool_15 = false;
        }
        if (this.genum1_1 != GEnum1.const_2 && this.genum1_1 != GEnum1.const_6)
            return;
        this.timer_1.Enabled = true;
        this.bool_7 = true;
    }

    private void listBox_0_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (this.genum1_1 == GEnum1.const_7)
        {
            this.menuItem_6_Click(sender, e);
            this.method_31();
        }
        if (this.listBox_0.SelectedIndex < 0 || this.listBox_0.SelectedIndex >= c.arrayList_4.Count)
            return;
        c.int_38 = this.listBox_0.SelectedIndex;
        this.textBox_4.Text = this.listBox_0.Items[c.int_38].ToString();
        this.bool_11 = true;
        if (this.genum1_1 == GEnum1.const_8)
            this.method_87();
        this.bool_11 = false;
    }

    private void method_87()
    {
        int int_0 = 8;
        this.timer_1.Interval = 1000 / c.smethod_0();
        this.timer_1.Enabled = false;
        this.trackBar_0.Enabled = false;
        this.bufferedStream_2.Flush();
        this.bufferedStream_2.Close();
        this.fileStream_2.Close();
        this.bufferedStream_1.Flush();
        this.bufferedStream_1.Close();
        this.fileStream_1.Close();
        string path = this.string_20 + ((GClass5)c.arrayList_4[c.int_38]).string_1 + Module.a("\uF2AD肯花骳\uDAB5\uDDB7\uDEB9", 8);
        if (System.IO.File.Exists(path))
        {
            this.fileStream_2 = new FileStream(path, FileMode.Open, FileAccess.Read);
            this.bufferedStream_2 = new BufferedStream((Stream)this.fileStream_2);
            byte[] buffer1 = new byte[512];
            this.bufferedStream_2.Seek(0L, SeekOrigin.Begin);
            this.bufferedStream_2.Read(buffer1, 0, 512);
            if (buffer1[0] == (byte)114 && buffer1[1] == (byte)122 && buffer1[2] == (byte)98 && buffer1[3] == (byte)118 && buffer1[4] == (byte)48 && buffer1[5] == (byte)48 && buffer1[6] == (byte)49)
            {
                this.int_32 = (int)buffer1[7];
                this.int_30 = new int[this.int_32];
                for (int index = 0; index < this.int_32; ++index)
                    this.int_30[index] = 0;
                this.int_33 = this.int_39;
                switch (c.int_2)
                {
                    case 102:
                        this.int_33 = this.int_32 * c.int_75 * this.int_82 * 2;
                        break;
                    case 103:
                        this.int_33 = this.int_39 / 2;
                        break;
                }
                this.string_9 = new string[this.int_32];
                for (int index = 0; index < this.int_32; ++index)
                {
                    int num = 50 + index;
                    this.string_9[index] = Module.a("龭覯肱骳螵躷芹銻袽\uF0BF\uECC1", int_0) + num.ToString();
                }
                byte[] numArray1 = new byte[16]
                {
          (byte) 143,
          (byte) 45,
          (byte) 28,
          (byte) 105,
          (byte) 84,
          (byte) 163,
          (byte) 200,
          (byte) 75,
          (byte) 46,
          (byte) 227,
          (byte) 249,
          (byte) 35,
          (byte) 118,
          (byte) 176,
          (byte) 209,
          (byte) 62
                };
                byte[] numArray2 = new byte[16];
                for (int index = 0; index < 16; ++index)
                    numArray2[index] = buffer1[index + 185];
                byte num1 = 0;
                for (int index = 0; index < 16; ++index)
                {
                    byte num2 = (byte)((uint)numArray2[index] ^ (uint)numArray1[index]);
                    num1 += num2;
                }
                for (int index = 0; index < 16; ++index)
                    num1 += numArray2[index];
                this.byte_42 = (byte)((uint)(byte)((uint)(byte)((uint)(byte)((uint)(byte)((uint)(byte)((uint)num1 + (uint)numArray1[0]) + (uint)numArray1[2]) + (uint)numArray1[7]) + (uint)numArray1[9]) + (uint)numArray1[15]) ^ 90U);
                byte[] numArray3 = new byte[16]
                {
          (byte) 206,
          (byte) 73,
          (byte) 147,
          (byte) 86,
          (byte) 164,
          (byte) 129,
          (byte) 63,
          (byte) 162,
          (byte) 113,
          (byte) 148,
          (byte) 42,
          (byte) 53,
          (byte) 23,
          (byte) 62,
          (byte) 91,
          (byte) 225
                };
                byte num3 = 0;
                for (int index1 = 311; index1 < 427; ++index1)
                {
                    byte index2 = (byte)(index1 % 16);
                    num3 += (byte)((uint)buffer1[index1] ^ (uint)numArray3[(int)index2]);
                }
                for (int index = 430; index < 511; ++index)
                    num3 += (byte)((uint)buffer1[index] ^ 90U);
                this.byte_43 = (byte)((uint)num3 ^ 165U);
                if (c.int_2 == 81 || c.int_2 == 86 || c.int_2 == 82 || c.int_2 == 83 || c.int_2 == 84 || c.int_2 == 85)
                {
                    if (c.int_2 == 81)
                        buffer1[15] = (byte)12;
                    if (c.int_2 == 82)
                        buffer1[15] = (byte)31;
                    if (c.int_2 == 83)
                        buffer1[15] = (byte)2;
                    if (c.int_2 == 84)
                        buffer1[15] = (byte)8;
                    if (c.int_2 == 85)
                        buffer1[15] = (byte)46;
                    if (c.int_2 == 86)
                        buffer1[15] = (byte)54;
                }
                if (buffer1[36] == (byte)17)
                {
                    byte[] numArray4 = new byte[16]
                    {
            (byte) 140,
            (byte) 113,
            (byte) 41,
            (byte) 111,
            (byte) 227,
            (byte) 202,
            (byte) 180,
            (byte) 249,
            (byte) 55,
            (byte) 16,
            (byte) 77,
            (byte) 5,
            (byte) 147,
            (byte) 168,
            (byte) 138,
            (byte) 26
                    };
                    byte num4 = 0;
                    for (int index3 = 0; index3 < 109; ++index3)
                    {
                        byte index4 = (byte)(index3 % 16);
                        num4 += (byte)((uint)buffer1[index3] ^ (uint)numArray4[(int)index4]);
                    }
                    if (num4 < (byte)128)
                        num4 += (byte)120;
                    for (int index = 0; index < 16; ++index)
                        numArray2[index] = buffer1[index + (int)num4];
                    numArray2[3] = buffer1[12];
                    numArray2[4] = buffer1[13];
                    numArray2[7] = buffer1[15];
                    numArray2[8] = buffer1[31];
                    numArray2[10] = buffer1[27];
                    numArray2[11] = buffer1[14];
                    numArray2[15] = buffer1[26];
                    byte[] numArray5 = new byte[280]
                    {
            (byte) 36,
            (byte) 144,
            (byte) 157,
            (byte) 7,
            (byte) 104,
            (byte) 42,
            (byte) 8,
            (byte) 100,
            (byte) 183,
            (byte) 154,
            (byte) 151,
            (byte) 189,
            (byte) 153,
            (byte) 247,
            (byte) 133,
            (byte) 118,
            (byte) 252,
            (byte) 226,
            (byte) 43,
            (byte) 229,
            (byte) 229,
            (byte) 151,
            (byte) 204,
            (byte) 27,
            (byte) 57,
            (byte) 214,
            (byte) 205,
            (byte) 204,
            (byte) 26,
            (byte) 238,
            (byte) 78,
            (byte) 192,
            (byte) 7,
            (byte) 12,
            (byte) 117,
            (byte) 102,
            (byte) 116,
            (byte) 170,
            (byte) 21,
            (byte) 190,
            (byte) 99,
            (byte) 53,
            (byte) 198,
            (byte) 39,
            (byte) 126,
            (byte) 74,
            (byte) 132,
            (byte) 160,
            (byte) 134,
            (byte) 238,
            (byte) 190,
            (byte) 152,
            (byte) 180,
            (byte) 142,
            (byte) 21,
            (byte) 141,
            (byte) 195,
            (byte) 130,
            (byte) 205,
            (byte) 146,
            (byte) 92,
            (byte) 60,
            (byte) 74,
            (byte) 201,
            (byte) 75,
            (byte) 214,
            (byte) 181,
            (byte) 140,
            (byte) 130,
            (byte) 31,
            (byte) 1,
            (byte) 81,
            (byte) 205,
            (byte) 108,
            (byte) 129,
            (byte) 175,
            (byte) 208,
            (byte) 165,
            (byte) 156,
            (byte) 239,
            (byte) 82,
            (byte) 45,
            (byte) 70,
            (byte) 44,
            (byte) 47,
            (byte) 182,
            (byte) 12,
            (byte) 121,
            (byte) 247,
            (byte) 231,
            (byte) 162,
            (byte) 241,
            (byte) 220,
            (byte) 131,
            (byte) 97,
            (byte) 39,
            (byte) 235,
            (byte) 253,
            (byte) 220,
            (byte) 167,
            (byte) 148,
            (byte) 247,
            (byte) 29,
            (byte) 102,
            (byte) 236,
            (byte) 109,
            (byte) 202,
            (byte) 71,
            (byte) 12,
            (byte) 101,
            (byte) 188,
            (byte) 30,
            (byte) 229,
            (byte) 222,
            (byte) 64,
            (byte) 47,
            (byte) 245,
            (byte) 29,
            (byte) 153,
            (byte) 148,
            (byte) 202,
            (byte) 60,
            (byte) 149,
            (byte) 155,
            (byte) 125,
            (byte) 15,
            (byte) 116,
            (byte) 74,
            (byte) 11,
            (byte) 89,
            (byte) 195,
            (byte) 210,
            (byte) 201,
            (byte) 245,
            (byte) 91,
            (byte) 91,
            (byte) 15,
            (byte) 224,
            (byte) 63,
            (byte) 194,
            (byte) 235,
            (byte) 196,
            (byte) 108,
            (byte) 145,
            (byte) 42,
            (byte) 132,
            (byte) 12,
            (byte) 254,
            (byte) 67,
            (byte) 49,
            (byte) 50,
            (byte) 205,
            (byte) 99,
            (byte) 71,
            (byte) 221,
            (byte) 87,
            (byte) 97,
            (byte) 130,
            (byte) 233,
            (byte) 220,
            (byte) 248,
            (byte) 128,
            (byte) 60,
            (byte) 178,
            (byte) 162,
            (byte) 234,
            (byte) 85,
            (byte) 240,
            (byte) 131,
            (byte) 228,
            (byte) 32,
            (byte) 21,
            (byte) 222,
            (byte) 215,
            (byte) 168,
            (byte) 5,
            (byte) 207,
            (byte) 4,
            (byte) 112,
            (byte) 248,
            (byte) 3,
            (byte) 118,
            (byte) 7,
            (byte) 217,
            (byte) 39,
            (byte) 246,
            (byte) 111,
            (byte) 129,
            (byte) 24,
            (byte) 3,
            (byte) 249,
            (byte) 140,
            (byte) 246,
            (byte) 99,
            (byte) 202,
            (byte) 107,
            (byte) 136,
            (byte) 186,
            (byte) 239,
            (byte) 64,
            (byte) 47,
            (byte) 27,
            (byte) 123,
            (byte) 94,
            (byte) 17,
            (byte) 28,
            (byte) 239,
            (byte) 140,
            (byte) 159,
            (byte) 216,
            (byte) 136,
            (byte) 92,
            (byte) 18,
            (byte) 240,
            (byte) 216,
            (byte) 130,
            (byte) 121,
            (byte) 98,
            (byte) 139,
            (byte) 171,
            (byte) 122,
            (byte) 211,
            (byte) 216,
            (byte) 128,
            (byte) 234,
            (byte) 147,
            (byte) 30,
            (byte) 122,
            (byte) 12,
            (byte) 61,
            (byte) 124,
            (byte) 21,
            (byte) 21,
            (byte) 47,
            (byte) 201,
            (byte) 231,
            (byte) 251,
            (byte) 168,
            (byte) 200,
            (byte) 10,
            (byte) 6,
            (byte) 226,
            (byte) 226,
            (byte) 64,
            (byte) 123,
            (byte) 157,
            (byte) 122,
            (byte) 6,
            (byte) 138,
            (byte) 71,
            (byte) 241,
            (byte) 38,
            (byte) 47,
            (byte) 67,
            (byte) 197,
            (byte) 91,
            (byte) 67,
            (byte) 250,
            (byte) 115,
            (byte) 125,
            (byte) 254,
            (byte) 117,
            (byte) 127,
            (byte) 97,
            (byte) 91,
            (byte) 114,
            (byte) 71,
            (byte) 226,
            (byte) 38,
            (byte) 240,
            (byte) 135,
            (byte) 208,
            (byte) 153,
            (byte) 128,
            (byte) 165,
            (byte) 152,
            (byte) 241,
            (byte) 152,
            (byte) 5,
            (byte) 77
                    };
                    byte num5 = 0;
                    for (int index = 0; index < 16; ++index)
                        num5 += numArray2[index];
                    byte num6 = 0;
                    for (int index = 0; index < 16; ++index)
                    {
                        byte num7 = (byte)((uint)numArray2[index] ^ (uint)numArray5[index + (int)num5]);
                        num6 += num7;
                    }
                    byte[] numArray6 = new byte[8];
                    for (int index = 0; index < 8; ++index)
                        numArray6[index] = numArray5[index + (int)num6];
                    byte num8 = 90;
                    for (int index = 0; index < 8; ++index)
                        num8 ^= numArray2[index];
                    byte num9 = 0;
                    for (int index = 0; index < 8; ++index)
                    {
                        byte num10 = (byte)((uint)numArray2[index] ^ (uint)numArray5[index + (int)num8]);
                        num9 += num10;
                    }
                    byte[] buffer2 = new byte[8];
                    for (int index = 0; index < 8; ++index)
                        buffer2[index] = (byte)((uint)numArray2[index] ^ (uint)numArray5[index + (int)num9]);
                    byte[] numArray7 = new byte[8];
                    using (DESCryptoServiceProvider cryptoServiceProvider = new DESCryptoServiceProvider())
                    {
                        byte[] numArray8 = new byte[8];
                        cryptoServiceProvider.Key = numArray6;
                        cryptoServiceProvider.IV = numArray8;
                        cryptoServiceProvider.Padding = PaddingMode.None;
                        MemoryStream memoryStream = new MemoryStream();
                        using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, cryptoServiceProvider.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            cryptoStream.Write(buffer2, 0, buffer2.Length);
                            cryptoStream.FlushFinalBlock();
                            cryptoStream.Close();
                        }
                        byte[] array = memoryStream.ToArray();
                        memoryStream.Close();
                        if (array.Length == 8)
                        {
                            for (int index = 0; index < 8; ++index)
                                numArray7[index] = array[index];
                        }
                        else
                        {
                            if (c.useEnglishLanguage)
                            {
                                this.ShowMessage(Module.a("\uEBAD슯삱\uDBB3쒵馷", int_0));
                                return;
                            }
                            this.ShowMessage(Module.a("翾꿚ꬤ嬸鞵", int_0));
                            return;
                        }
                    }
                    byte[] numArray9 = new byte[4]
                    {
            (byte) ((uint) numArray7[0] ^ (uint) numArray7[1]),
            (byte) ((uint) numArray7[2] + (uint) numArray7[3]),
            (byte) ((uint) numArray7[4] - (uint) numArray7[5]),
            (byte) ((uint) numArray7[6] ^ (uint) numArray7[7])
                    };
                    byte num11 = 0;
                    byte num12 = numArray9[0];
                    if (num12 < (byte)128)
                        num12 += (byte)120;
                    for (int index5 = 0; index5 < 119; ++index5)
                    {
                        byte index6 = (byte)(index5 % 16);
                        num11 += (byte)((uint)buffer1[index5 + (int)num12] ^ (uint)numArray4[(int)index6]);
                    }
                    this.byte_42 ^= num11;
                    this.byte_42 += numArray9[2];
                    byte num13 = 0;
                    byte num14 = numArray9[1];
                    if (num14 < (byte)128)
                        num14 += (byte)120;
                    for (int index7 = 0; index7 < 149; ++index7)
                    {
                        byte index8 = (byte)(index7 % 16);
                        num13 += (byte)((uint)buffer1[index7 + (int)num14] ^ (uint)numArray4[(int)index8]);
                    }
                    this.byte_43 += num13;
                    this.byte_43 ^= numArray9[3];
                }
                this.byte_39 = new byte[10];
                new Random().NextBytes(this.byte_39);
                byte num15 = 0;
                numArray1[0] = (byte)59;
                numArray1[1] = (byte)129;
                numArray1[2] = (byte)197;
                numArray1[3] = (byte)228;
                numArray1[4] = (byte)81;
                numArray1[5] = (byte)208;
                numArray1[6] = (byte)127;
                numArray1[7] = (byte)174;
                numArray1[8] = (byte)99;
                numArray1[9] = (byte)41;
                for (int index = 0; index < 10; ++index)
                {
                    num15 += (byte)((uint)this.byte_39[index] ^ (uint)numArray1[index]);
                    this.byte_30[index + 2] = this.byte_39[index];
                }
                int num16 = (int)(byte)((uint)num15 ^ 90U);
                this.byte_41 = (byte)num16;
                this.int_79 = num16 - (int)this.byte_42;
            }
            this.fileStream_1 = new FileStream(this.string_20 + ((GClass5)c.arrayList_4[c.int_38]).string_3, FileMode.Open, FileAccess.Read);
            this.bufferedStream_1 = new BufferedStream((Stream)this.fileStream_1);
            this.int_55 = 0;
            this.int_40 = ((GClass5)c.arrayList_4[c.int_38]).int_0;
            this.int_50 = this.int_40;
            this.trackBar_0.Minimum = 0;
            this.trackBar_0.Maximum = this.int_40 - 1;
            this.trackBar_0.Enabled = true;
            if ((c.string_7 == Module.a("節ﲯ\uE1B1钳\uE0B5趷鞹\uF1BB", int_0) || c.string_7 == Module.a("\uEDAD얯삱삳ힵ톷풹鲻\uE8BD\uF5BF", int_0)) && c.smethod_0() > 20)
                c.smethod_1(20);
            this.bool_50 = true;
            this.bool_37 = true;
            this.timer_1.Interval = 1000 / c.smethod_0();
            this.timer_1.Enabled = true;
            this.bool_27 = true;
            this.timer_0.Enabled = true;
            this.method_39();
        }
        else if (c.useEnglishLanguage)
            this.ShowMessage(this.string_22 + Module.a("肭\uDCAFힱ킳隵톷풹쪻\uDFBD겿ꯁꃃ\uEAC5ꯇꛉꗋ귍믏\uF2D1韓ꓕ뷗믙\uA8DBﻝ铟跡쓣臥跧蓩觫鳭釯蛱釳훵賷鋹駻\uDEFD\u2EFF渁愃戅⠇氉攋戍甏㌑", int_0));
        else
            this.ShowMessage(this.string_22 + Module.a("肭\uDCAFힱ킳隵㿒䳷峞\uF6D8\uECBF㕊綳㶔퓧햼\uDCA9폭ౌ螂\uF8D3즠좵\uF4D9냛믝蓟斄ክ\uE71A", int_0));
    }

    private void button_4_Click(object sender, EventArgs e)
    {
        int int_0 = 6;
        if (this.listBox_0.SelectedIndex >= 0 && this.listBox_0.SelectedIndex < this.listBox_0.Items.Count)
        {
            if (this.listBox_0.SelectedIndex == 0)
            {
                if (c.useEnglishLanguage)
                    this.ShowMessage(Module.a("\uF8AB욭햯銱잳펵풷\uDFB9\uDFBB쪽ꦿ귁\uAAC3\uE6C5ꇇ막\uECCB뫍룏럑\uF4D3믕럗꧙\uA8DBﻝ铟跡铣웥臧黩觫菭\uDCEF诱鯳菵\uD8F7駹鷻都\u20FF氁欃爅⠇有挋砍甏㈑愓昕㤗", int_0));
                else
                    this.ShowMessage(Module.a("\uECC9ꜽ줷裿듔쀭섯隹峞毑쫱㦸\uE5C3", int_0));
            }
            else
            {
                GClass5 gclass5 = (GClass5)c.arrayList_4[this.listBox_0.SelectedIndex];
                c.arrayList_4.RemoveAt(this.listBox_0.SelectedIndex);
                c.arrayList_4.Insert(this.listBox_0.SelectedIndex - 1, (object)gclass5);
                int selectedIndex = this.listBox_0.SelectedIndex;
                this.method_28();
                this.method_25();
                this.listBox_0.SelectedIndex = selectedIndex - 1;
            }
        }
        else if (c.useEnglishLanguage)
            //     this.ShowMessage(Module.a("ﲫ슭햯펱잳펵颷즹\uD9BB튽ꖿꇁ냃\uE6C5볇ꋉ꧋\uEECD맏ꛑ뇓믕ꯗ龎ꗛ뇝闟싡鏣蟥蛧黩쳫髭\u9FEF틱駳駵軷\u9FF9\uDDFB", int_0));
            this.ShowMessage("Please select the items you want to move!");
        else
            //           this.ShowMessage(Module.a("\uFFF4\uE3FFᇃ믖봣志䏹\uEFF6씣銽㜴쭑ⶡ䝌㎾抛䢽䱏㺹\uF3D1", int_0));
            this.ShowMessage("当前没有选择任何项,请选择要移动的节目!");

    }

    private void button_2_Click(object sender, EventArgs e)
    {
        int int_0 = 1;
        if (this.listBox_0.SelectedIndex >= 0 && this.listBox_0.SelectedIndex < this.listBox_0.Items.Count)
        {
            if (this.listBox_0.SelectedIndex + 1 >= this.listBox_0.Items.Count)
            {
                if (c.useEnglishLanguage)
                    //                    this.ShowMessage(Module.a("\uF3A6솨캪趬\uDCAE풰\uDFB2킴풶춸\uDEBA\uD9BC龾ꣀ냂\uE5C4돆ꇈ껊\uEDCC귎뻐\uA7D2ꇔ룖듘ﯚ드ꯞ蓠転짤黦蛨黪췬賮郰鷲헴駶雸迺\uDDFC鋾渀甂怄✆洈搊稌愎【", int_0));
                    this.ShowMessage("The selected item is the last item and cannot be moved down.");
                else
                    //                   this.ShowMessage(Module.a("\uE7C4ꀸ툲韢꿉뿤돼찬鮶姝滖뛲䓇\uE0C0", int_0));
                    this.ShowMessage("所选项为最后一项,无法下移!");

            }
            else
            {
                GClass5 gclass5 = (GClass5)c.arrayList_4[this.listBox_0.SelectedIndex];
                c.arrayList_4.RemoveAt(this.listBox_0.SelectedIndex);
                c.arrayList_4.Insert(this.listBox_0.SelectedIndex + 1, (object)gclass5);
                int selectedIndex = this.listBox_0.SelectedIndex;
                this.method_28();
                this.method_25();
                this.listBox_0.SelectedIndex = selectedIndex + 1;
            }
        }
        else if (c.useEnglishLanguage)
            //     this.ShowMessage(Module.a("\uF7A6얨캪첬\uDCAE풰鎲운튶햸\uDEBA\uDEBC쮾\uE1C0럂귄ꋆ\uE9C8ꋊ만\uAACE볐ꃒ\uF5D4껖뛘껚\uFDDC\uA8DE胠跢釤쟦鷨蓪췬苮黰藲郴훶", int_0));
            this.ShowMessage("Please select the items you want to move!");
        else
            //            this.ShowMessage(Module.a("\uF4F9\uE4FA\u0AC6\uA4CB\uA63E壒䣼\uE0FB츮閸䰱됬囜䁉㢻涖䎰䭊▼\uECCC", int_0));
            this.ShowMessage("当前没有选择任何项,请选择要移动的节目!");
    }

    private void button_3_Click(object sender, EventArgs e)
    {
        int int_0 = 14;
        if (c.arrayList_4.Count > 1)
        {
            if (this.genum1_1 == GEnum1.const_7)
            {
                this.menuItem_6_Click(sender, e);
                this.method_31();
            }
            if (this.listBox_0.SelectedIndex < 0 || this.listBox_0.SelectedIndex >= c.arrayList_4.Count)
                return;
            //     string path = c.string_21 + Module.a("\uE8B3", int_0) + ((GClass5) c.arrayList_4[this.listBox_0.SelectedIndex]).string_0;
            string path = c.string_21 + "\\" + ((GClass5)c.arrayList_4[this.listBox_0.SelectedIndex]).string_0;
            if (Directory.Exists(path))
                Directory.Delete(path, true);
            c.arrayList_4.RemoveAt(this.listBox_0.SelectedIndex);
            this.method_28();
            if (c.int_38 >= c.arrayList_4.Count)
                c.int_38 = c.arrayList_4.Count - 1;
            this.method_25();
            this.textBox_4.Text = this.listBox_0.Items[c.int_38].ToString();
        }
        else if (c.useEnglishLanguage)
            //      this.ShowMessage(Module.a("ﾳ펵\uDDB7쪹鲻\uDFBD뒿\uE2C1ꣃꏅ꧇막룋\uEECD뿏병뇓\uF6D5꣗꣙돛망鋟菡解쫥釧藩駫컭鏯鏱髳훵雷闹裻\uDEFD擿朁栃挅簇漉Ⰻ漍簏縑㔓", int_0));
            this.ShowMessage("Keep at least one program,you can not delete all!");
        else
            //            this.ShowMessage(Module.a("䜲\uA7E9㤾柶\uE5CE뻳\uEAF1䁃⪵\uEAC5얉㝉\uEC99\uAA5B뢞㩁噑㢣輪", int_0));
            this.ShowMessage("至少要保留一个节目,不能删除全部节目!"); // simplified chinese of the above english
    }

    private void menuItem_106_Click(object sender, EventArgs e)
    {
        this.a_0.Hide();
        if (!c.bool_51)
            return;
        if (this.bool_29)
        {
            this.bool_29 = false;
            this.menuItem_9_Click(sender, e);
        }
        c.bool_51 = false;
        c.bool_55 = false;
    }

    private void menuItem_105_Click(object sender, EventArgs e)
    {
        if (this.genum1_1 != GEnum1.const_9 && !this.menuItem_10.Enabled)
        {
            this.menuItem_46_Click(sender, e);
            this.bool_29 = true;
        }
        this.a_0.method_1();
        c.bool_51 = true;
        this.a_0.Show();
        c.int_59 = 0;
        c.int_58 = 0;
        this.a_0.trackBar_1.Maximum = c.int_60;
        this.a_0.trackBar_2.Maximum = c.int_61;
        this.BringToFront();
        if (!c.bool_53)
        {
            c.gclass0_8.method_12().ColorFill(Color.FromArgb(0, 0, 0));
            c.gclass0_8.method_12().ForeColor = c.color_3;
        }
        else
        {
            c.gclass0_8.method_12().ColorFill(Color.FromArgb(0, 0, 1));
            c.gclass0_8.method_12().ForeColor = Color.FromArgb(0, 0, 0);
        }
        c.gclass0_8.method_12().FontHandle = c.font_0.ToHfont();
        c.size_0 = TextRenderer.MeasureText(c.string_19, c.font_0);
    }

    private void tabControl_0_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (this.genum1_1 != GEnum1.const_2 && this.genum1_1 != GEnum1.const_6)
            return;
        if (this.tabControl_0.SelectedIndex == 1)
        {
            this.timer_1.Enabled = true;
            this.bool_7 = true;
        }
        else
        {
            this.timer_1.Enabled = false;
            this.bool_7 = false;
        }
    }

    private void menuItem_104_Popup(object sender, EventArgs e)
    {
        if (this.genum1_1 != GEnum1.const_7)
            return;
        this.menuItem_6_Click(sender, e);
    }

    private void menuItem_109_Click(object sender, EventArgs e)
    {
        int num = (int)new g().ShowDialog();
    }

    private void menuItem_110_Click(object sender, EventArgs e)
    {
        int int_0 = 14;
        this.menuItem_109_Click((object)null, (EventArgs)null);
        this.int_32 = this.int_23 / c.int_75;
        this.string_9 = new string[this.int_32];
        for (int index = 0; index < this.int_32; ++index)
        {
            int num = 50 + index;
            this.string_9[index] = "192.168.60."; //Module.a("薳辵誷钹趻袽\uF8BF\uECC1\uF2C3\uF6C5\uE6C7", int_0) + num.ToString();
        }
        this.byte_35[0] = (byte)147;
        this.byte_35[1] = (byte)17;
        this.byte_35[2] = (byte)34;
        this.byte_35[3] = (byte)(c.int_5 / 256);
        this.byte_35[4] = (byte)(c.int_5 % 256);
        this.byte_35[5] = (byte)c.int_6;
        this.byte_35[6] = (byte)(c.int_7 / 256);
        this.byte_35[7] = (byte)(c.int_7 % 256);
        for (int index = 0; index < this.int_32; ++index)
        {
            try
            {
                this.udpClient_0.Send(this.byte_35, 8, this.string_9[index], 5000);
            }
            catch
            {
            }
        }
    }

    private void menuItem_111_Click(object sender, EventArgs e)
    {
        int int_0 = 13;
        this.byte_35[0] = (byte)60;// <
        this.byte_35[1] = (byte)90;// Z
        this.byte_35[2] = (byte)17;
        this.byte_35[3] = (byte)34;// "
        this.byte_35[4] = (byte)51; // 3
        this.byte_35[5] = (byte)68; //D
        this.byte_35[6] = (byte)85; // U
        try
        {
            //    this.udpClient_0.Send(this.byte_35, 8, Module.a("芲貴薶鞸誺讼螾\uEFC0\uF5C2\uF5C4\uE9C6\uFDC8\uFBCA", int_0), 5000);
            this.udpClient_0.Send(this.byte_35, 8, "192.168.60.40", 5000);

        }
        catch
        {
        }
    }

    private void menuItem_112_Click(object sender, EventArgs e)
    {
        int int_0 = 15;
        this.byte_35[0] = (byte)85;
        this.byte_35[1] = (byte)153;
        this.byte_35[2] = (byte)102;
        this.byte_35[3] = (byte)119;
        this.byte_35[4] = (byte)136;
        this.byte_35[5] = (byte)153;
        this.byte_35[6] = (byte)170;
        try
        {
            //     this.udpClient_0.Send(this.byte_35, 8, Module.a("蒴躶许閺貼覾燎\uEDC2\uF3C4\uF7C6\uE7C8ￊ\uFDCC", int_0), 5000);
            this.udpClient_0.Send(this.byte_35, 8, "192.168.60.40", 5000);
        }
        catch
        {
        }
    }

    [SpecialName]
    private static void old_acctor_mc()
    {
        c.string_0 = "V2.4"; // Module.a("ﺧ颩芫骭", 2);
        c.string_1 = "";
        c.string_2 = "";
        c.useEnglishLanguage = true;
        c.int_2 = 101;
        c.bool_1 = false;
        c.bool_2 = false;
        c.bool_3 = false;
        c.int_3 = 30;
        c.int_4 = 1024;
        c.byte_0 = (byte)0;
        c.int_8 = 0;
        c.int_9 = 0;
        c.int_10 = 0;
        c.byte_1 = (byte)0;
        c.byte_2 = (byte)0;
        c.byte_3 = (byte)8;
        c.byte_4 = (byte)8;
        c.byte_5 = (byte)8;
        c.byte_6 = (byte)0;
        c.byte_7 = (byte)0;
        c.byte_8 = (byte)0;
        c.bool_6 = false;
        c.bool_9 = false;
        c.byte_9 = (byte)0;
        c.byte_10 = (byte)0;
        c.string_3 = "00"; // Module.a("颧骩", 2);
        c.byte_13 = byte.MaxValue;
        c.byte_14 = byte.MaxValue;
        c.byte_15 = byte.MaxValue;
        c.double_2 = 1.8;
        c.bool_18 = false;
        c.string_7 = "T-100K-SC"; // Module.a("ﲧ螩鶫麭肯鈴馳\uE5B5﮷", 2);
        c.byte_21 = new byte[256];
        c.byte_22 = new byte[256];
        c.byte_23 = new byte[256];
        c.bool_32 = false;
        c.string_12 = new string[1000];
        c.string_13 = new string[1000];
        c.string_14 = new string[1000];
        c.string_15 = new string[1000];
        c.string_17 = "";
        c.bool_51 = false;
        c.bool_52 = false;
        c.bool_53 = true;
        c.bool_54 = true;
        c.int_57 = 1;
        c.int_58 = 0;
        c.int_59 = 0;
        c.string_19 = "Hello!"; // Module.a("\uE0A7쾩삫슭\uDFAF鎱", 2);
        c.bool_55 = false;
        c.bool_56 = false;
        c.int_73 = 25;
        c.int_74 = 1024;
        c.int_75 = 8;
        c.int_76 = 1;
        c.int_77 = 1;
        c.int_78 = 0;
        c.bool_59 = false;
    }
}
