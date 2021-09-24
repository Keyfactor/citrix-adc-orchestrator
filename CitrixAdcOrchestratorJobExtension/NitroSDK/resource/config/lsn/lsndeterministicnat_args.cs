// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lsn.lsndeterministicnat_args
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


namespace com.citrix.netscaler.nitro.resource.config.lsn
{
  public class lsndeterministicnat_args
  {
    private string clientnameField = (string) null;
    private string network6Field = (string) null;
    private string subscripField = (string) null;
    private uint? tdField = new uint?();
    private string natipField = (string) null;

    public string clientname
    {
      get => this.clientnameField;
      set => this.clientnameField = value;
    }

    public string network6
    {
      get => this.network6Field;
      set => this.network6Field = value;
    }

    public string subscrip
    {
      get => this.subscripField;
      set => this.subscripField = value;
    }

    public uint? td
    {
      get => this.tdField;
      set => this.tdField = value;
    }

    public string natip
    {
      get => this.natipField;
      set => this.natipField = value;
    }
  }
}
