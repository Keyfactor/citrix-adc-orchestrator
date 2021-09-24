// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nsaptlicense_args
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nsaptlicense_args
  {
    private string serialnoField = (string) null;
    private string useproxyField = (string) null;

    public string serialno
    {
      get => this.serialnoField;
      set => this.serialnoField = value;
    }

    public string useproxy
    {
      get => this.useproxyField;
      set => this.useproxyField = value;
    }

    public static class useproxyEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }
  }
}
