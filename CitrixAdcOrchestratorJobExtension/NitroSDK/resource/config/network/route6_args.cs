// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.route6_args
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class route6_args
  {
    private string routetypeField = (string) null;
    private bool? detailField = new bool?();

    public string routetype
    {
      get => this.routetypeField;
      set => this.routetypeField = value;
    }

    public bool? detail
    {
      get => this.detailField;
      set => this.detailField = value;
    }

    public static class routetypeEnum
    {
      public const string CONNECTED = "CONNECTED";
      public const string STATIC = "STATIC";
      public const string DYNAMIC = "DYNAMIC";
      public const string OSPF = "OSPF";
      public const string ISIS = "ISIS";
      public const string BGP = "BGP";
      public const string RIP = "RIP";
      public const string ND_RA_ROUTE = "ND-RA-ROUTE";
      public const string FIB6 = "FIB6";
    }
  }
}
