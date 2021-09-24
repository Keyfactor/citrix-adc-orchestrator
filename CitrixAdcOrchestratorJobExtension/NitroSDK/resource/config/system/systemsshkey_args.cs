// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.system.systemsshkey_args
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


namespace com.citrix.netscaler.nitro.resource.config.system
{
  public class systemsshkey_args
  {
    private string sshkeytypeField = (string) null;

    public string sshkeytype
    {
      get => this.sshkeytypeField;
      set => this.sshkeytypeField = value;
    }

    public static class sshkeytypeEnum
    {
      public const string PRIVATE = "PRIVATE";
      public const string PUBLIC = "PUBLIC";
    }
  }
}
