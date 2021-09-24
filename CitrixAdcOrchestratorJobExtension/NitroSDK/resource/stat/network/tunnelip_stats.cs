// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.network.tunnelip_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.network
{
  public class tunnelip_stats : base_resource
  {
    private string tunnelipField = (string) null;
    private string clearstatsField = (string) null;
    private long tnltotrxpktsField = 0;
    private long tnlrxpktsrateField = 0;
    private long tnltottxpktsField = 0;
    private long tnltxpktsrateField = 0;
    private long tnltotrxbytesField = 0;
    private long tnlrxbytesrateField = 0;
    private long tnltottxbytesField = 0;
    private long tnltxbytesrateField = 0;

    public string tunnelip
    {
      get => this.tunnelipField;
      set => this.tunnelipField = value;
    }

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long tnltxpktsrate
    {
      get => this.tnltxpktsrateField;
      private set => this.tnltxpktsrateField = value;
    }

    public long tnltxbytesrate
    {
      get => this.tnltxbytesrateField;
      private set => this.tnltxbytesrateField = value;
    }

    public long tnlrxpktsrate
    {
      get => this.tnlrxpktsrateField;
      private set => this.tnlrxpktsrateField = value;
    }

    public long tnltotrxpkts
    {
      get => this.tnltotrxpktsField;
      private set => this.tnltotrxpktsField = value;
    }

    public long tnltottxbytes
    {
      get => this.tnltottxbytesField;
      private set => this.tnltottxbytesField = value;
    }

    public long tnltottxpkts
    {
      get => this.tnltottxpktsField;
      private set => this.tnltottxpktsField = value;
    }

    public long tnlrxbytesrate
    {
      get => this.tnlrxbytesrateField;
      private set => this.tnlrxbytesrateField = value;
    }

    public long tnltotrxbytes
    {
      get => this.tnltotrxbytesField;
      private set => this.tnltotrxbytesField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      tunnelip_stats.tunnelip_response tunnelipResponse = new tunnelip_stats.tunnelip_response();
      tunnelip_stats.tunnelip_response resource = (tunnelip_stats.tunnelip_response) service.get_payload_formatter().string_to_resource(tunnelipResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.tunnelip;
    }

    internal override string get_object_name() => this.tunnelip;

    public static tunnelip_stats[] get(nitro_service service) => (tunnelip_stats[]) new tunnelip_stats().stat_resources(service, (options) null);

    public static tunnelip_stats[] get(nitro_service service, options option) => (tunnelip_stats[]) new tunnelip_stats().stat_resources(service, option);

    public static tunnelip_stats get(nitro_service service, string tunnelip) => (tunnelip_stats) new tunnelip_stats()
    {
      tunnelip = tunnelip
    }.stat_resource(service);

    private class tunnelip_response : base_response
    {
      public tunnelip_stats[] tunnelip = (tunnelip_stats[]) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
