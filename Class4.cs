// Decompiled with JetBrains decompiler
// Type: Class4
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using Microsoft.DirectX.DirectDraw;
using System;
using System.Drawing;
using System.Windows.Forms;

internal class Class4
{
  public bool bool_0;
  public int int_0;
  public int int_1;
  public int int_2;
  public int int_3;
  public int int_4;
  public int int_5;
  public int int_6;
  public int int_7;
  public Rectangle rectangle_0;
  public Rectangle rectangle_1;
  public Color color_0;
  public Color color_1;
  public Font font_0;
  public string string_0;
  public int int_8;
  public int int_9;
  private Size size_0;
  private int int_10;
  private string string_1;
  private GClass0 gclass0_0;

  public Class4() => this.bool_0 = false;

  public void method_0()
  {
    int int_0 = 9;
    this.bool_0 = true;
    this.gclass0_0 = new GClass0(c.gclass1_0.method_1(), GEnum0.const_1, this.rectangle_0, this.rectangle_1);
    this.gclass0_0.method_12().ColorFill(Color.FromArgb(0, 0, 0));
    this.gclass0_0.method_12().SetColorKey(ColorKeyFlags.SourceDraw, new ColorKey()
    {
      ColorSpaceLowValue = 0,
      ColorSpaceHighValue = 0
    });
    if (this.int_0 == 0)
    {
      this.gclass0_0.method_12().ForeColor = this.color_1;
    }
    else
    {
      this.gclass0_0.method_12().ColorFill(Color.FromArgb(0, 0, 1));
      this.gclass0_0.method_12().ForeColor = Color.FromArgb(0, 0, 0);
    }
    this.gclass0_0.method_12().FontHandle = this.font_0.ToHfont();
    string[] strArray = this.string_0.Split(new string[1]
    {
      Module.a("ꊮ뮰", int_0)
    }, StringSplitOptions.None);
    if (strArray.Length > 1)
    {
      int length = strArray[0].Length;
      int index1 = 0;
      for (int index2 = 0; index2 < strArray.Length; ++index2)
      {
        if (strArray[index2].Length > length)
        {
          length = strArray[index2].Length;
          index1 = index2;
        }
      }
      this.size_0 = TextRenderer.MeasureText(strArray[index1], this.font_0);
    }
    else
      this.size_0 = TextRenderer.MeasureText(this.string_0, this.font_0);
  }

  public GClass0 method_1()
  {
    int int_0 = 4;
    if (this.int_0 == 0)
      this.gclass0_0.method_12().ColorFill(Color.FromArgb(0, 0, 0));
    else
      this.gclass0_0.method_12().ColorFill(Color.FromArgb(0, 0, 1));
    if (this.int_1 == 0)
    {
      if (this.int_3 >= 0 && this.int_3 < 10)
      {
        if (this.int_10 >= this.int_3)
        {
          this.int_10 = 0;
          --this.int_8;
        }
        else
          ++this.int_10;
      }
      else if (this.int_3 < 0)
        this.int_8 += this.int_3;
      if (this.int_8 + this.size_0.Width < 0)
        this.int_8 = this.rectangle_0.Width;
      if (this.string_0.Length > 0)
      {
        string[] strArray = this.string_0.Split(new string[1]
        {
          Module.a("ꞩꚫ", int_0)
        }, StringSplitOptions.None);
        if (strArray.Length > 1)
        {
          for (int index = 0; index < strArray.Length; ++index)
          {
            if (this.int_0 == 0)
              this.gclass0_0.method_12().ForeColor = this.color_1;
            this.gclass0_0.method_12().DrawText(this.int_8, this.int_9 + index * this.size_0.Height, strArray[index], false);
          }
        }
        else
        {
          if (this.int_0 == 0)
            this.gclass0_0.method_12().ForeColor = this.color_1;
          this.gclass0_0.method_12().DrawText(this.int_8, this.int_9, this.string_0, false);
        }
      }
    }
    else
    {
      if (this.int_3 >= 0 && this.int_3 < 10)
      {
        if (this.int_10 >= this.int_3)
        {
          this.int_10 = 0;
          --this.int_9;
        }
        else
          ++this.int_10;
      }
      else if (this.int_3 < 0)
        this.int_9 += this.int_3;
      if (this.string_0.Length > 0)
      {
        string[] strArray = this.string_0.Split(new string[1]
        {
          Module.a("ꞩꚫ", int_0)
        }, StringSplitOptions.None);
        if (strArray.Length > 1)
        {
          for (int index = 0; index < strArray.Length; ++index)
          {
            if (this.int_0 == 0)
              this.gclass0_0.method_12().ForeColor = this.color_1;
            for (int startIndex = 0; startIndex < strArray[index].Length; ++startIndex)
            {
              this.string_1 = strArray[index].Substring(startIndex, 1);
              this.gclass0_0.method_12().DrawText(this.int_8 + index * this.size_0.Height, this.int_9 + startIndex * this.size_0.Height, this.string_1, false);
            }
          }
        }
        else
        {
          if (this.int_0 == 0)
            this.gclass0_0.method_12().ForeColor = this.color_1;
          for (int startIndex = 0; startIndex < this.string_0.Length; ++startIndex)
          {
            this.string_1 = this.string_0.Substring(startIndex, 1);
            this.gclass0_0.method_12().DrawText(this.int_8, this.int_9 + startIndex * this.size_0.Height, this.string_1, false);
          }
        }
        if (this.int_9 + this.size_0.Height * this.string_0.Length < 0)
          this.int_9 = this.rectangle_0.Height;
      }
    }
    if (this.int_4 == 1)
    {
      LockedData lockedData = this.gclass0_0.method_12().Lock(LockFlags.NoSystemLock);
      lockedData.Data.Position = 0L;
      int num1 = lockedData.Pitch;
      byte num2 = 0;
      byte num3 = 0;
      byte num4 = 0;
      int num5 = num1;
      for (int index1 = 0; index1 < this.gclass0_0.method_5().Height; ++index1)
      {
        for (int index2 = 0; index2 < this.gclass0_0.method_5().Width; ++index2)
        {
          int num6 = index1 * num1 + index2 * 4;
          lockedData.Data.Position = (long) num6;
          byte num7 = (byte) lockedData.Data.ReadByte();
          byte num8 = (byte) lockedData.Data.ReadByte();
          byte num9 = (byte) lockedData.Data.ReadByte();
          if (index2 > 0)
          {
            if (num2 == (byte) 0 && num3 == (byte) 0 && num4 == (byte) 0 && (int) num9 == (int) this.color_1.R && (int) num8 == (int) this.color_1.G && (int) num7 == (int) this.color_1.B && num6 >= 4)
            {
              lockedData.Data.Position = (long) (num6 - 4);
              lockedData.Data.WriteByte(byte.MaxValue);
              lockedData.Data.WriteByte(byte.MaxValue);
              lockedData.Data.WriteByte(byte.MaxValue);
              lockedData.Data.WriteByte((byte) 0);
            }
            if (num9 == (byte) 0 && num8 == (byte) 0 && num7 == (byte) 0 && (int) num2 == (int) this.color_1.R && (int) num3 == (int) this.color_1.G && (int) num4 == (int) this.color_1.B)
            {
              lockedData.Data.Position = (long) num6;
              lockedData.Data.WriteByte(byte.MaxValue);
              lockedData.Data.WriteByte(byte.MaxValue);
              lockedData.Data.WriteByte(byte.MaxValue);
              lockedData.Data.WriteByte((byte) 0);
            }
          }
          num2 = num9;
          num3 = num8;
          num4 = num7;
        }
      }
      for (int index3 = 0; index3 < this.gclass0_0.method_5().Width; ++index3)
      {
        for (int index4 = 0; index4 < this.gclass0_0.method_5().Height; ++index4)
        {
          int num10 = index4 * num1 + index3 * 4;
          lockedData.Data.Position = (long) num10;
          byte num11 = (byte) lockedData.Data.ReadByte();
          byte num12 = (byte) lockedData.Data.ReadByte();
          byte num13 = (byte) lockedData.Data.ReadByte();
          if (index4 > 0)
          {
            if (num2 == (byte) 0 && num3 == (byte) 0 && num4 == (byte) 0 && (int) num13 == (int) this.color_1.R && (int) num12 == (int) this.color_1.G && (int) num11 == (int) this.color_1.B && num10 >= num5)
            {
              lockedData.Data.Position = (long) (num10 - num5);
              lockedData.Data.WriteByte(byte.MaxValue);
              lockedData.Data.WriteByte(byte.MaxValue);
              lockedData.Data.WriteByte(byte.MaxValue);
              lockedData.Data.WriteByte((byte) 0);
            }
            if (num13 == (byte) 0 && num12 == (byte) 0 && num11 == (byte) 0 && (int) num2 == (int) this.color_1.R && (int) num3 == (int) this.color_1.G && (int) num4 == (int) this.color_1.B)
            {
              lockedData.Data.Position = (long) num10;
              lockedData.Data.WriteByte(byte.MaxValue);
              lockedData.Data.WriteByte(byte.MaxValue);
              lockedData.Data.WriteByte(byte.MaxValue);
              lockedData.Data.WriteByte((byte) 0);
            }
          }
          num2 = num13;
          num3 = num12;
          num4 = num11;
        }
      }
      this.gclass0_0.method_12().Unlock();
    }
    return this.gclass0_0;
  }
}
