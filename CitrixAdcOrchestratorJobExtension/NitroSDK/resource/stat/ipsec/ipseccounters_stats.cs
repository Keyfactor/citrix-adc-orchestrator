// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.ipsec.ipseccounters_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.ipsec
{
  public class ipseccounters_stats : base_resource
  {
    private string clearstatsField = (string) null;
    private long ipsectotrxbytesField = 0;
    private long ipsecrxbytesrateField = 0;
    private long ipsectottxbytesField = 0;
    private long ipsectxbytesrateField = 0;
    private long ipsectotrxpktsField = 0;
    private long ipsecrxpktsrateField = 0;
    private long ipsectottxpktsField = 0;
    private long ipsectxpktsrateField = 0;

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long ipsecrxbytesrate
    {
      get => this.ipsecrxbytesrateField;
      private set => this.ipsecrxbytesrateField = value;
    }

    public long ipsectxbytesrate
    {
      get => this.ipsectxbytesrateField;
      private set => this.ipsectxbytesrateField = value;
    }

    public long ipsectottxbytes
    {
      get => this.ipsectottxbytesField;
      private set => this.ipsectottxbytesField = value;
    }

    public long ipsecrxpktsrate
    {
      get => this.ipsecrxpktsrateField;
      private set => this.ipsecrxpktsrateField = value;
    }

    public long ipsectotrxpkts
    {
      get => this.ipsectotrxpktsField;
      private set => this.ipsectotrxpktsField = value;
    }

    public long ipsectottxpkts
    {
      get => this.ipsectottxpktsField;
      private set => this.ipsectottxpktsField = value;
    }

    public long ipsectotrxbytes
    {
      get => this.ipsectotrxbytesField;
      private set => this.ipsectotrxbytesField = value;
    }

    public long ipsectxpktsrate
    {
      get => this.ipsectxpktsrateField;
      private set => this.ipsectxpktsrateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      ipseccounters_stats[] ipseccountersStatsArray = new ipseccounters_stats[1];
      ipseccounters_stats.ipseccounters_response ipseccountersResponse = new ipseccounters_stats.ipseccounters_response();
      ipseccounters_stats.ipseccounters_response resource = (ipseccounters_stats.ipseccounters_response) service.get_payload_formatter().string_to_resource(ipseccountersResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      ipseccountersStatsArray[0] = resource.ipseccounters;
      return (base_resource[]) ipseccountersStatsArray;
    }

    internal override string get_object_name() => (string) null;

    public static ipseccounters_stats get(nitro_service service) => ((ipseccounters_stats[]) new ipseccounters_stats().stat_resources(service, (options) null))[0];

    public static ipseccounters_stats get(nitro_service service, options option) => ((ipseccounters_stats[]) new ipseccounters_stats().stat_resources(service, option))[0];

    private class ipseccounters_response : base_response
    {
      public ipseccounters_stats ipseccounters = (ipseccounters_stats) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
