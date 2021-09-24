// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nsconnectiontable_args
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nsconnectiontable_args
  {
    private string filterexpressionField = (string) null;
    private bool? linkField = new bool?();
    private bool? nameField = new bool?();
    private string[] detailField = (string[]) null;
    private bool? listenField = new bool?();

    public string filterexpression
    {
      get => this.filterexpressionField;
      set => this.filterexpressionField = value;
    }

    public bool? link
    {
      get => this.linkField;
      set => this.linkField = value;
    }

    public bool? name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string[] detail
    {
      get => this.detailField;
      set => this.detailField = value;
    }

    public bool? listen
    {
      get => this.listenField;
      set => this.listenField = value;
    }

    public static class detailEnum
    {
      public const string LINK = "LINK";
      public const string NAME = "NAME";
      public const string CONNFAILOVER = "CONNFAILOVER";
      public const string FULL = "FULL";
      public const string NNM = "NNM";
    }
  }
}
