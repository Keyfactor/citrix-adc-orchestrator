// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.ns.nstrafficdomain_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.ns
{
  public class nstrafficdomain_stats : base_resource
  {
    private uint tdField = 0;
    private string clearstatsField = (string) null;
    private long nstdtotrxpktsField = 0;
    private long nstdrxpktsrateField = 0;
    private long nstdtottxpktsField = 0;
    private long nstdtxpktsrateField = 0;
    private long nstdtotdroppedpktsField = 0;
    private long nstddroppedpktsrateField = 0;

    public uint td
    {
      get => this.tdField;
      set => this.tdField = value;
    }

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long nstdtotrxpkts
    {
      get => this.nstdtotrxpktsField;
      private set => this.nstdtotrxpktsField = value;
    }

    public long nstddroppedpktsrate
    {
      get => this.nstddroppedpktsrateField;
      private set => this.nstddroppedpktsrateField = value;
    }

    public long nstdtotdroppedpkts
    {
      get => this.nstdtotdroppedpktsField;
      private set => this.nstdtotdroppedpktsField = value;
    }

    public long nstdrxpktsrate
    {
      get => this.nstdrxpktsrateField;
      private set => this.nstdrxpktsrateField = value;
    }

    public long nstdtottxpkts
    {
      get => this.nstdtottxpktsField;
      private set => this.nstdtottxpktsField = value;
    }

    public long nstdtxpktsrate
    {
      get => this.nstdtxpktsrateField;
      private set => this.nstdtxpktsrateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nstrafficdomain_stats.nstrafficdomain_response nstrafficdomainResponse = new nstrafficdomain_stats.nstrafficdomain_response();
      nstrafficdomain_stats.nstrafficdomain_response resource = (nstrafficdomain_stats.nstrafficdomain_response) service.get_payload_formatter().string_to_resource(nstrafficdomainResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nstrafficdomain;
    }

    internal override string get_object_name() => this.td.ToString();

    public static nstrafficdomain_stats[] get(nitro_service service) => (nstrafficdomain_stats[]) new nstrafficdomain_stats().stat_resources(service, (options) null);

    public static nstrafficdomain_stats[] get(
      nitro_service service,
      options option)
    {
      return (nstrafficdomain_stats[]) new nstrafficdomain_stats().stat_resources(service, option);
    }

    public static nstrafficdomain_stats get(nitro_service service, uint td) => (nstrafficdomain_stats) new nstrafficdomain_stats()
    {
      td = td
    }.stat_resource(service);

    private class nstrafficdomain_response : base_response
    {
      public nstrafficdomain_stats[] nstrafficdomain = (nstrafficdomain_stats[]) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
