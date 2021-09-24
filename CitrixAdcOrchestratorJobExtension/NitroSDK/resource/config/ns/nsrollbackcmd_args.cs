// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nsrollbackcmd_args
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nsrollbackcmd_args
  {
    private string filenameField = (string) null;
    private string outtypeField = (string) null;

    public string filename
    {
      get => this.filenameField;
      set => this.filenameField = value;
    }

    public string outtype
    {
      get => this.outtypeField;
      set => this.outtypeField = value;
    }

    public static class outtypeEnum
    {
      public const string cli = "cli";
      public const string xml = "xml";
    }
  }
}
