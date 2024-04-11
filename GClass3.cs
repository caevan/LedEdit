// Decompiled with JetBrains decompiler
// Type: GClass3
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using System;
using System.Runtime.InteropServices;
using System.Text;

public class GClass3
{
  private const uint uint_0 = 475264;
  private const uint uint_1 = 508036;
  private const uint uint_2 = 508040;
  private const uint uint_3 = 2147483648;
  private const uint uint_4 = 1073741824;
  private const uint uint_5 = 1;
  private const uint uint_6 = 2;
  private const uint uint_7 = 1;
  private const uint uint_8 = 3;

  [DllImport("kernel32.dll", SetLastError = true)]
  private static extern int CloseHandle(IntPtr intptr_0);

  [DllImport("kernel32.dll", SetLastError = true)]
  private static extern IntPtr CreateFile(
    string string_0,
    uint uint_9,
    uint uint_10,
    IntPtr intptr_0,
    uint uint_11,
    uint uint_12,
    IntPtr intptr_1);

  [DllImport("kernel32.dll")]
  private static extern int DeviceIoControl(
    IntPtr intptr_0,
    uint uint_9,
    IntPtr intptr_1,
    uint uint_10,
    ref Struct5 struct5_0,
    uint uint_11,
    ref uint uint_12,
    [Out] IntPtr intptr_2);

  [DllImport("kernel32.dll")]
  private static extern int DeviceIoControl(
    IntPtr intptr_0,
    uint uint_9,
    ref Struct7 struct7_0,
    uint uint_10,
    ref Struct9 struct9_0,
    uint uint_11,
    ref uint uint_12,
    [Out] IntPtr intptr_1);

  public static GStruct0 smethod_0(byte byte_0)
  {
    int int_0 = 12;
    switch (Environment.OSVersion.Platform)
    {
      case PlatformID.Win32S:
        throw new NotSupportedException(Module.a("\uE5B1\uDDB3\uD8B5讷袹쾻麽ꦿ뇁\uE4C3\uA8C5\uA7C7뻉\uECCB뷍ꗏꋑꓓ맕\uAAD7껙맛뫝컟", int_0));
      case PlatformID.Win32Windows:
        return GClass3.smethod_1(byte_0);
      case PlatformID.Win32NT:
        return GClass3.smethod_2(byte_0);
      case PlatformID.WinCE:
        throw new NotSupportedException(Module.a("\uE5B1\uDDB3\uD8B5﮷ﾹ鲻ힽ뎿\uE2C1\uAAC3꧅볇\uEAC9뿋믍ꃏꋑ믓ꓕ곗뿙룛\uF0DD", int_0));
      default:
        throw new NotSupportedException(Module.a("\uE7B1\uDAB3\uDDB5횷햹쮻킽\uE0BF鋁ꣃ\uA7C5볇곉ꏋ볍뷏ﳑ", int_0));
    }
  }

  private static GStruct0 smethod_1(byte byte_0)
  {
    int int_0 = 17;
    Struct5 struct5_0 = new Struct5();
    Struct7 struct7_0 = new Struct7();
    Struct9 struct9_0 = new Struct9();
    uint uint_12 = 0;
    IntPtr file = GClass3.CreateFile(Module.a("\uEBB6\uE5B8閺\uE1BC\uECBE곀ꋂ럄돆뿈룊꧌", 17), 0U, 0U, IntPtr.Zero, 1U, 0U, IntPtr.Zero);
    if (file == IntPtr.Zero)
      throw new Exception(Module.a("\uF8B6즸\uDEBA펼龾닀껂꓄뗆뷈뷊뻌ꯎ\uFFD0ꗒ귔돖律뷚볜뛞跠蛢臤짦", int_0));
    if (GClass3.DeviceIoControl(file, 475264U, IntPtr.Zero, 0U, ref struct5_0, (uint) Marshal.SizeOf((object) struct5_0), ref uint_12, IntPtr.Zero) == 0)
    {
      GClass3.CloseHandle(file);
      throw new Exception(Module.a("\uF3B6\uDCB8춺풼\uDCBE꓀諂\uAAC4蓆ꛈꗊ만뷎뻐뿒\uF5D4뇖룘닚뇜뫞藠\uD9E2ꇤꇦ맨듪ꫬꫮꗰ곲ꏴ닶꯸꣺듼냾伀", int_0));
    }
    if (((int) struct5_0.uint_0 & 1) == 0)
    {
      GClass3.CloseHandle(file);
      throw new Exception(Module.a("\uF2B6쮸즺튼춾﯀\uE3C2賄菆賈\uEBCA\uA4CCꯎ듐뷒ꇔ뻖뿘ꋚ\uFDDC볞軠転裤蛦蟨迪췬臮黰蟲헴蓶賸诺跼郾猀眂怄挆✈", int_0));
    }
    struct7_0.struct6_0.byte_5 = ((int) byte_0 & 1) == 0 ? (byte) 160 : (byte) 176;
    if (0L != ((long) struct5_0.uint_0 & (long) (16 >> (int) byte_0)))
    {
      GClass3.CloseHandle(file);
      throw new Exception(string.Format(Module.a("\uF3B6쮸튺쮼\uDABE\uE1C0룂\uF5C4뫆\uE9C8ꋊ뻌\uEFCE냐\uF3D2铔菖飘诚铜\uFFDE藠蛢鏤軦諨軪쇬쿮蛰雲헴鏶雸闺\uDAFC\uD8FE甀⌂愄戆紈渊渌笎ㄐ稒愔", int_0), (object) ((int) byte_0 + 1)));
    }
    struct7_0.struct6_0.byte_6 = (byte) 236;
    struct7_0.byte_0 = byte_0;
    struct7_0.struct6_0.byte_1 = (byte) 1;
    struct7_0.struct6_0.byte_2 = (byte) 1;
    struct7_0.uint_0 = 512U;
    if (GClass3.DeviceIoControl(file, 508040U, ref struct7_0, (uint) Marshal.SizeOf((object) struct7_0), ref struct9_0, (uint) Marshal.SizeOf((object) struct9_0), ref uint_12, IntPtr.Zero) == 0)
    {
      GClass3.CloseHandle(file);
      throw new Exception(Module.a("\uF3B6\uDCB8춺풼\uDCBE꓀諂\uAAC4蓆ꛈꗊ만뷎뻐뿒\uF5D4뇖룘닚뇜뫞藠\uD9E2엤ꏦ꿨믪달뷮듰냲냴뻶꿸뻺ꋼ믾匀䨂匄䈆嘈伊䰌嬎倐", int_0));
    }
    GClass3.CloseHandle(file);
    return GClass3.smethod_3(struct9_0.struct10_0);
  }

  private static GStruct0 smethod_2(byte byte_0)
  {
    int int_0 = 9;
    Struct5 struct5_0 = new Struct5();
    Struct7 struct7_0 = new Struct7();
    Struct9 struct9_0 = new Struct9();
    uint uint_12 = 0;
    IntPtr file = GClass3.CreateFile(string.Format(Module.a("\uF3AE\uEDB0鶲\uE9B4\uE7B6톸슺캼횾ꋀꋂ꧄菆믈ꋊ믌\uAACE\uAAD0\uE3D2꣔", 9), (object) byte_0), 3221225472U, 3U, IntPtr.Zero, 3U, 0U, IntPtr.Zero);
    if (file == IntPtr.Zero)
      throw new Exception(Module.a("\uECAE쎰횲풴쎶\uDCB8ﶺ풼펾꓀\uE3C2ꏄꛆꃈ\uA7CA꧌\uE1CE", int_0));
    if (GClass3.DeviceIoControl(file, 475264U, IntPtr.Zero, 0U, ref struct5_0, (uint) Marshal.SizeOf((object) struct5_0), ref uint_12, IntPtr.Zero) == 0)
    {
      GClass3.CloseHandle(file);
      throw new Exception(string.Format(Module.a("\uEBAE쎰\uDAB2쎴튶馸삺趼슾\uE1C0껂꓄뻆\uE9C8ꗊꋌ믎\uF1D0뛒귔뻖\uAAD8꿚껜\uF1DE", int_0), (object) ((int) byte_0 + 1)));
    }
    if (((int) struct5_0.uint_0 & 1) == 0)
    {
      GClass3.CloseHandle(file);
      throw new Exception(Module.a("\uEAAE쎰솲\uDAB4얶莸鮺\uF4BC﮾蓀\uE3C2계ꏆ곈ꗊ만ꛎ럐\uAAD2\uF5D4듖뛘뛚냜뻞迠蟢엤触蛨\u9FEA췬鳮蓰菲藴飶诸迺飼鯾⼀", int_0));
    }
    struct7_0.struct6_0.byte_5 = ((int) byte_0 & 1) == 0 ? (byte) 160 : (byte) 176;
    if (0L != ((long) struct5_0.uint_0 & (long) (16 >> (int) byte_0)))
    {
      GClass3.CloseHandle(file);
      throw new Exception(string.Format(Module.a("\uEBAE쎰\uDAB2쎴튶馸삺趼슾\uE1C0ꫂ뛄\uE7C6\uA8C8\uEBCA賌鯎郐菒鳔\uF7D6뷘뻚ꯜ뛞苠蛢짤쟦黨軪췬诮黰鷲틴탶跸\uDBFA駼髾甀昂昄猆⤈戊礌ℎ", int_0), (object) ((int) byte_0 + 1)));
    }
    struct7_0.struct6_0.byte_6 = (byte) 236;
    struct7_0.byte_0 = byte_0;
    struct7_0.struct6_0.byte_1 = (byte) 1;
    struct7_0.struct6_0.byte_2 = (byte) 1;
    struct7_0.uint_0 = 512U;
    if (GClass3.DeviceIoControl(file, 508040U, ref struct7_0, (uint) Marshal.SizeOf((object) struct7_0), ref struct9_0, (uint) Marshal.SizeOf((object) struct9_0), ref uint_12, IntPtr.Zero) == 0)
    {
      GClass3.CloseHandle(file);
      throw new Exception(Module.a("\uEBAE풰얲\uDCB4풶\uDCB8\uF2BA튼ﲾ껀귂뇄뗆ꛈ\uA7CA\uEDCC\uA9CE냐뫒맔닖뷘\uE1DA\uFDDC鯞\uA7E0돢뫤뗦골꣪꣬ꛮ\uA7F0뛲ꫴ돶꯸닺\uABFC뫾帀䜂䐄匆䠈", int_0));
    }
    GClass3.CloseHandle(file);
    return GClass3.smethod_3(struct9_0.struct10_0);
  }

  private static GStruct0 smethod_3(Struct10 struct10_0)
  {
    GStruct0 gstruct0 = new GStruct0();
    GClass3.smethod_4(struct10_0.byte_2);
    gstruct0.string_0 = Encoding.ASCII.GetString(struct10_0.byte_2).Trim();
    GClass3.smethod_4(struct10_0.byte_1);
    gstruct0.string_1 = Encoding.ASCII.GetString(struct10_0.byte_1).Trim();
    GClass3.smethod_4(struct10_0.byte_0);
    gstruct0.string_2 = Encoding.ASCII.GetString(struct10_0.byte_0).Trim();
    gstruct0.uint_0 = struct10_0.uint_1 / 2U / 1024U;
    return gstruct0;
  }

  private static void smethod_4(byte[] byte_0)
  {
    for (int index = 0; index < byte_0.Length; index += 2)
    {
      byte num = byte_0[index];
      byte_0[index] = byte_0[index + 1];
      byte_0[index + 1] = num;
    }
  }
}
