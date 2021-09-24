// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.network.rnat_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.network
{
  public class rnat_stats : base_resource
  {
    private string clearstatsField = (string) null;
    private long rnattotrxbytesField = 0;
    private long rnatrxbytesrateField = 0;
    private long rnattottxbytesField = 0;
    private long rnattxbytesrateField = 0;
    private long rnattotrxpktsField = 0;
    private long rnatrxpktsrateField = 0;
    private long rnattottxpktsField = 0;
    private long rnattxpktsrateField = 0;
    private long rnattottxsynField = 0;
    private long rnattxsynrateField = 0;
    private long rnatcursessionsField = 0;

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long rnattottxpkts
    {
      get => this.rnattottxpktsField;
      private set => this.rnattottxpktsField = value;
    }

    public long rnatrxbytesrate
    {
      get => this.rnatrxbytesrateField;
      private set => this.rnatrxbytesrateField = value;
    }

    public long rnattxsynrate
    {
      get => this.rnattxsynrateField;
      private set => this.rnattxsynrateField = value;
    }

    public long rnattxpktsrate
    {
      get => this.rnattxpktsrateField;
      private set => this.rnattxpktsrateField = value;
    }

    public long rnattottxsyn
    {
      get => this.rnattottxsynField;
      private set => this.rnattottxsynField = value;
    }

    public long rnattxbytesrate
    {
      get => this.rnattxbytesrateField;
      private set => this.rnattxbytesrateField = value;
    }

    public long rnatrxpktsrate
    {
      get => this.rnatrxpktsrateField;
      private set => this.rnatrxpktsrateField = value;
    }

    public long rnatcursessions
    {
      get => this.rnatcursessionsField;
      private set => this.rnatcursessionsField = value;
    }

    public long rnattotrxpkts
    {
      get => this.rnattotrxpktsField;
      private set => this.rnattotrxpktsField = value;
    }

    public long rnattotrxbytes
    {
      get => this.rnattotrxbytesField;
      private set => this.rnattotrxbytesField = value;
    }

    public long rnattottxbytes
    {
      get => this.rnattottxbytesField;
      private set => this.rnattottxbytesField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      rnat_stats[] rnatStatsArray = new rnat_stats[1];
      rnat_stats.rnat_response rnatResponse = new rnat_stats.rnat_response();
      rnat_stats.rnat_response resource = (rnat_stats.rnat_response) service.get_payload_formatter().string_to_resource(rnatResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      rnatStatsArray[0] = resource.rnat;
      return (base_resource[]) rnatStatsArray;
    }

    internal override string get_object_name() => (string) null;

    public static rnat_stats get(nitro_service service) => ((rnat_stats[]) new rnat_stats().stat_resources(service, (options) null))[0];

    public static rnat_stats get(nitro_service service, options option) => ((rnat_stats[]) new rnat_stats().stat_resources(service, option))[0];

    private class rnat_response : base_response
    {
      public rnat_stats rnat = (rnat_stats) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
