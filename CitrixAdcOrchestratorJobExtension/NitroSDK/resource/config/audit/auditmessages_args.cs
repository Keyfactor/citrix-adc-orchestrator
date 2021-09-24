// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.audit.auditmessages_args
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


namespace com.citrix.netscaler.nitro.resource.config.audit
{
  public class auditmessages_args
  {
    private string[] loglevelField = (string[]) null;
    private uint? numofmesgsField = new uint?();

    public string[] loglevel
    {
      get => this.loglevelField;
      set => this.loglevelField = value;
    }

    public uint? numofmesgs
    {
      get => this.numofmesgsField;
      set => this.numofmesgsField = value;
    }

    public static class loglevelEnum
    {
      public const string ALL = "ALL";
      public const string EMERGENCY = "EMERGENCY";
      public const string ALERT = "ALERT";
      public const string CRITICAL = "CRITICAL";
      public const string ERROR = "ERROR";
      public const string WARNING = "WARNING";
      public const string NOTICE = "NOTICE";
      public const string INFORMATIONAL = "INFORMATIONAL";
      public const string DEBUG = "DEBUG";
    }
  }
}
