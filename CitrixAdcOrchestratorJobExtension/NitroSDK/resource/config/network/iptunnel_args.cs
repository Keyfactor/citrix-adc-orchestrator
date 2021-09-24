// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.iptunnel_args
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class iptunnel_args
  {
    private string remoteField = (string) null;
    private string remotesubnetmaskField = (string) null;

    public string remote
    {
      get => this.remoteField;
      set => this.remoteField = value;
    }

    public string remotesubnetmask
    {
      get => this.remotesubnetmaskField;
      set => this.remotesubnetmaskField = value;
    }
  }
}
