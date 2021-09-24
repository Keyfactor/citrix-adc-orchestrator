// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.aaa.aaasession_args
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


namespace com.citrix.netscaler.nitro.resource.config.aaa
{
  public class aaasession_args
  {
    private string usernameField = (string) null;
    private string groupnameField = (string) null;
    private string iipField = (string) null;
    private string netmaskField = (string) null;

    public string username
    {
      get => this.usernameField;
      set => this.usernameField = value;
    }

    public string groupname
    {
      get => this.groupnameField;
      set => this.groupnameField = value;
    }

    public string iip
    {
      get => this.iipField;
      set => this.iipField = value;
    }

    public string netmask
    {
      get => this.netmaskField;
      set => this.netmaskField = value;
    }
  }
}
