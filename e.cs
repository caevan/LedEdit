// Decompiled with JetBrains decompiler
// Type: e
// Assembly: LedEdit, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: D08429D7-F24F-41DD-AFC4-7F40AB03BFB1
// Assembly location: C:\pixelled\2020 LedEdit\2020 LedEdit\2020 lededit.exe

using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

[DebuggerNonUserCode]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
internal class e
{
  private static ResourceManager resourceManager_0;
  private static CultureInfo cultureInfo_0;

  internal e()
  {
  }

  [SpecialName]
  internal static ResourceManager smethod_0()
  {
    int int_0 = 17;
    // ISSUE: reference to a compiler-generated field
    if (object.ReferenceEquals((object) e.resourceManager_0, (object) null))
    {
            // ISSUE: reference to a compiler-generated field
            e.resourceManager_0 = new ResourceManager("LedEdit.Properties.Resources", typeof(e).Assembly);
        }
        // ISSUE: reference to a compiler-generated field
        return e.resourceManager_0;
  }

  [SpecialName]
  internal static CultureInfo smethod_1() => e.cultureInfo_0;

  [SpecialName]
  internal static void smethod_2(CultureInfo cultureInfo_1) => e.cultureInfo_0 = cultureInfo_1;
}
