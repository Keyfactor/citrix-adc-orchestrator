// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lsn.lsnsession_args
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


namespace com.citrix.netscaler.nitro.resource.config.lsn
{
  public class lsnsession_args
  {
    private string nattypeField = (string) null;
    private string clientnameField = (string) null;
    private string networkField = (string) null;
    private string netmaskField = (string) null;
    private string network6Field = (string) null;
    private uint? tdField = new uint?();
    private string natipField = (string) null;

    public string nattype
    {
      get => this.nattypeField;
      set => this.nattypeField = value;
    }

    public string clientname
    {
      get => this.clientnameField;
      set => this.clientnameField = value;
    }

    public string network
    {
      get => this.networkField;
      set => this.networkField = value;
    }

    public string netmask
    {
      get => this.netmaskField;
      set => this.netmaskField = value;
    }

    public string network6
    {
      get => this.network6Field;
      set => this.network6Field = value;
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

    public static class nattypeEnum
    {
      public const string NAT44 = "NAT44";
      public const string DS_Lite = "DS-Lite";
    }
  }
}
