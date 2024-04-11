// Decompiled with JetBrains decompiler
// Type: DotfuscatorAttribute
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using System;

[AttributeUsage(AttributeTargets.Assembly)]
public sealed class DotfuscatorAttribute : Attribute
{
  private string string_0;
  private bool bool_0;
  private int int_0;

  public DotfuscatorAttribute(string string_1, int int_1, bool bool_1)
  {
    DotfuscatorAttribute dotfuscatorAttribute = this;
    // ISSUE: explicit constructor call
 //   dotfuscatorAttribute.\u002Ector();
    dotfuscatorAttribute.string_0 = string_1;
    this.int_0 = int_1;
    this.bool_0 = bool_1;
  }

  //public string A => this.string_0;

  public string get_A() => this.string_0;

  //public bool B => this.useEnglishLanguage;

  public bool get_B() => this.bool_0;

  //public int C => this.int_0;

  public int get_C() => this.int_0;
}
