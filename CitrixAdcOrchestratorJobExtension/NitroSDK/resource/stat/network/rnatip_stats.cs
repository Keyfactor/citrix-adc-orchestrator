// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.network.rnatip_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.network
{
  public class rnatip_stats : base_resource
  {
    private string RnatipField = (string) null;
    private string clearstatsField = (string) null;
    private long iptdField = 0;
    private long iprnattotrxbytesField = 0;
    private long iprnatrxbytesrateField = 0;
    private long iprnattottxbytesField = 0;
    private long iprnattxbytesrateField = 0;
    private long iprnattotrxpktsField = 0;
    private long iprnatrxpktsrateField = 0;
    private long iprnattottxpktsField = 0;
    private long iprnattxpktsrateField = 0;
    private long iprnattottxsynField = 0;
    private long iprnattxsynrateField = 0;
    private long iprnatcursessionsField = 0;

    public string Rnatip
    {
      get => this.RnatipField;
      set => this.RnatipField = value;
    }

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long iprnatrxpktsrate
    {
      get => this.iprnatrxpktsrateField;
      private set => this.iprnatrxpktsrateField = value;
    }

    public long iprnattxpktsrate
    {
      get => this.iprnattxpktsrateField;
      private set => this.iprnattxpktsrateField = value;
    }

    public long iprnattottxpkts
    {
      get => this.iprnattottxpktsField;
      private set => this.iprnattottxpktsField = value;
    }

    public long iptd
    {
      get => this.iptdField;
      private set => this.iptdField = value;
    }

    public long iprnattottxbytes
    {
      get => this.iprnattottxbytesField;
      private set => this.iprnattottxbytesField = value;
    }

    public long iprnatcursessions
    {
      get => this.iprnatcursessionsField;
      private set => this.iprnatcursessionsField = value;
    }

    public long iprnatrxbytesrate
    {
      get => this.iprnatrxbytesrateField;
      private set => this.iprnatrxbytesrateField = value;
    }

    public long iprnattotrxbytes
    {
      get => this.iprnattotrxbytesField;
      private set => this.iprnattotrxbytesField = value;
    }

    public long iprnattxsynrate
    {
      get => this.iprnattxsynrateField;
      private set => this.iprnattxsynrateField = value;
    }

    public long iprnattxbytesrate
    {
      get => this.iprnattxbytesrateField;
      private set => this.iprnattxbytesrateField = value;
    }

    public long iprnattotrxpkts
    {
      get => this.iprnattotrxpktsField;
      private set => this.iprnattotrxpktsField = value;
    }

    public long iprnattottxsyn
    {
      get => this.iprnattottxsynField;
      private set => this.iprnattottxsynField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      rnatip_stats.rnatip_response rnatipResponse = new rnatip_stats.rnatip_response();
      rnatip_stats.rnatip_response resource = (rnatip_stats.rnatip_response) service.get_payload_formatter().string_to_resource(rnatipResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.rnatip;
    }

    internal override string get_object_name() => this.Rnatip;

    public static rnatip_stats[] get(nitro_service service) => (rnatip_stats[]) new rnatip_stats().stat_resources(service, (options) null);

    public static rnatip_stats[] get(nitro_service service, options option) => (rnatip_stats[]) new rnatip_stats().stat_resources(service, option);

    public static rnatip_stats get(nitro_service service, string Rnatip) => (rnatip_stats) new rnatip_stats()
    {
      Rnatip = Rnatip
    }.stat_resource(service);

    private class rnatip_response : base_response
    {
      public rnatip_stats[] rnatip = (rnatip_stats[]) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
