// Decompiled with JetBrains decompiler
// Type: Class0
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using Microsoft.DirectX.DirectDraw;
using System.Drawing;
using System.IO;

internal class Class0
{
  public string string_0;
  public int int_0;
  public int int_1;
  public int int_2;
  public int int_3;
  public int int_4;
  public byte[] byte_0;
  public bool bool_0;
  private FileStream fileStream_0;
  private BufferedStream bufferedStream_0;
  private GClass0 gclass0_0;

  public Class0() => this.bool_0 = false;

  public Class0(string string_1, Rectangle rectangle_0)
  {
    int int_0 = 15;
    // ISSUE: explicit constructor call
 //   base.\u002Ector();
    if (this.bool_0)
    {
      this.bufferedStream_0.Flush();
      this.bufferedStream_0.Close();
      this.fileStream_0.Close();
    }
    this.bool_0 = false;
    if (!File.Exists(string_1) || !string_1.ToLower().EndsWith(Module.a("鮴쎶횸ힺ", int_0)))
      return;
    this.string_0 = string_1;
    this.bool_0 = true;
    this.fileStream_0 = new FileStream(string_1, FileMode.Open, FileAccess.Read);
    this.bufferedStream_0 = new BufferedStream((Stream) this.fileStream_0);
    byte[] buffer = new byte[16];
    this.bufferedStream_0.Seek(0L, SeekOrigin.Begin);
    this.bufferedStream_0.Read(buffer, 0, 16);
    this.int_0 = (int) buffer[1] * 65536 + (int) buffer[2] * 256 + (int) buffer[3];
    this.int_1 = (int) buffer[4] * 256 + (int) buffer[5];
    this.int_2 = (int) buffer[6] * 256 + (int) buffer[7];
    this.int_3 = 0;
    this.int_4 = this.int_2 * this.int_1 * 3;
    this.byte_0 = new byte[this.int_4];
    Rectangle rectangle_2 = new Rectangle(0, 0, this.int_2, this.int_1);
    this.gclass0_0 = new GClass0(c.gclass1_0.method_1(), rectangle_2, rectangle_0);
  }

  public GClass0 method_0()
  {
    ++this.int_3;
    if (this.int_3 >= this.int_0)
      this.int_3 = 0;
    this.bufferedStream_0.Seek((long) this.int_3 * (long) this.int_4 + 14L, SeekOrigin.Begin);
    this.bufferedStream_0.Read(this.byte_0, 0, this.int_4);
    for (int index = 0; index < this.int_4; ++index)
      this.byte_0[index] = (byte) ((uint) this.byte_0[index] << 1);
    LockedData lockedData = this.gclass0_0.method_12().Lock(LockFlags.WriteOnly);
    lockedData.Data.Position = 0L;
    int num = lockedData.Pitch;
    for (int index1 = 0; index1 < this.int_1; ++index1)
    {
      for (int index2 = 0; index2 < this.int_2; ++index2)
      {
        int index3 = (this.int_2 * index1 + index2) * 3;
        lockedData.Data.Position = (long) (num * index1 + index2 * 4);
        lockedData.Data.WriteByte(this.byte_0[index3 + 2]);
        lockedData.Data.WriteByte(this.byte_0[index3 + 1]);
        lockedData.Data.WriteByte(this.byte_0[index3]);
        lockedData.Data.WriteByte((byte) 0);
      }
    }
    this.gclass0_0.method_12().Unlock();
    return this.gclass0_0;
  }

  public GClass0 method_1(GClass0 gclass0_1)
  {
    ++this.int_3;
    if (this.int_3 >= this.int_0)
      this.int_3 = 0;
    this.bufferedStream_0.Seek((long) this.int_3 * (long) this.int_4 + 14L, SeekOrigin.Begin);
    this.bufferedStream_0.Read(this.byte_0, 0, this.int_4);
    for (int index = 0; index < this.int_4; ++index)
      this.byte_0[index] = (byte) ((uint) this.byte_0[index] << 1);
    LockedData lockedData = this.gclass0_0.method_12().Lock(LockFlags.WriteOnly);
    lockedData.Data.Position = 0L;
    int num = lockedData.Pitch;
    for (int index1 = 0; index1 < this.int_1; ++index1)
    {
      for (int index2 = 0; index2 < this.int_2; ++index2)
      {
        int index3 = (this.int_2 * index1 + index2) * 3;
        lockedData.Data.Position = (long) (num * index1 + index2 * 4);
        lockedData.Data.WriteByte(this.byte_0[index3 + 2]);
        lockedData.Data.WriteByte(this.byte_0[index3 + 1]);
        lockedData.Data.WriteByte(this.byte_0[index3]);
        lockedData.Data.WriteByte((byte) 0);
      }
    }
    this.gclass0_0.method_12().Unlock();
    this.gclass0_0.method_13(gclass0_1);
    return this.gclass0_0;
  }
}
