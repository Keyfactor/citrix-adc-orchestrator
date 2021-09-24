// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cache.cacheobject_args
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


namespace com.citrix.netscaler.nitro.resource.config.cache
{
  public class cacheobject_args
  {
    private string urlField = (string) null;
    private long? locatorField = new long?();
    private uint? httpstatusField = new uint?();
    private string hostField = (string) null;
    private ushort? portField = new ushort?();
    private string groupnameField = (string) null;
    private string httpmethodField = (string) null;
    private string groupField = (string) null;
    private string ignoremarkerobjectsField = (string) null;
    private string includenotreadyobjectsField = (string) null;

    public string url
    {
      get => this.urlField;
      set => this.urlField = value;
    }

    public long? locator
    {
      get => this.locatorField;
      set => this.locatorField = value;
    }

    public uint? httpstatus
    {
      get => this.httpstatusField;
      set => this.httpstatusField = value;
    }

    public string host
    {
      get => this.hostField;
      set => this.hostField = value;
    }

    public ushort? port
    {
      get => this.portField;
      set => this.portField = value;
    }

    public string groupname
    {
      get => this.groupnameField;
      set => this.groupnameField = value;
    }

    public string httpmethod
    {
      get => this.httpmethodField;
      set => this.httpmethodField = value;
    }

    public string group
    {
      get => this.groupField;
      set => this.groupField = value;
    }

    public string ignoremarkerobjects
    {
      get => this.ignoremarkerobjectsField;
      set => this.ignoremarkerobjectsField = value;
    }

    public string includenotreadyobjects
    {
      get => this.includenotreadyobjectsField;
      set => this.includenotreadyobjectsField = value;
    }

    public static class includenotreadyobjectsEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class httpmethodEnum
    {
      public const string GET = "GET";
      public const string POST = "POST";
    }

    public static class ignoremarkerobjectsEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }
  }
}
