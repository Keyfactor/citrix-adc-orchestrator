// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.ns.nssimpleacl_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.ns
{
  public class nssimpleacl_stats : base_resource
  {
    private string clearstatsField = (string) null;
    private long sacltothitsField = 0;
    private long saclhitsrateField = 0;
    private long sacltotmissesField = 0;
    private long saclmissesrateField = 0;
    private long saclscountField = 0;
    private long sacltotpktsallowedField = 0;
    private long saclpktsallowedrateField = 0;
    private long sacltotpktsbridgedField = 0;
    private long saclpktsbridgedrateField = 0;
    private long sacltotpktsdeniedField = 0;
    private long saclpktsdeniedrateField = 0;

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long sacltothits
    {
      get => this.sacltothitsField;
      private set => this.sacltothitsField = value;
    }

    public long saclscount
    {
      get => this.saclscountField;
      private set => this.saclscountField = value;
    }

    public long saclhitsrate
    {
      get => this.saclhitsrateField;
      private set => this.saclhitsrateField = value;
    }

    public long saclpktsbridgedrate
    {
      get => this.saclpktsbridgedrateField;
      private set => this.saclpktsbridgedrateField = value;
    }

    public long sacltotpktsdenied
    {
      get => this.sacltotpktsdeniedField;
      private set => this.sacltotpktsdeniedField = value;
    }

    public long sacltotmisses
    {
      get => this.sacltotmissesField;
      private set => this.sacltotmissesField = value;
    }

    public long saclmissesrate
    {
      get => this.saclmissesrateField;
      private set => this.saclmissesrateField = value;
    }

    public long saclpktsallowedrate
    {
      get => this.saclpktsallowedrateField;
      private set => this.saclpktsallowedrateField = value;
    }

    public long sacltotpktsbridged
    {
      get => this.sacltotpktsbridgedField;
      private set => this.sacltotpktsbridgedField = value;
    }

    public long saclpktsdeniedrate
    {
      get => this.saclpktsdeniedrateField;
      private set => this.saclpktsdeniedrateField = value;
    }

    public long sacltotpktsallowed
    {
      get => this.sacltotpktsallowedField;
      private set => this.sacltotpktsallowedField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nssimpleacl_stats[] nssimpleaclStatsArray = new nssimpleacl_stats[1];
      nssimpleacl_stats.nssimpleacl_response nssimpleaclResponse = new nssimpleacl_stats.nssimpleacl_response();
      nssimpleacl_stats.nssimpleacl_response resource = (nssimpleacl_stats.nssimpleacl_response) service.get_payload_formatter().string_to_resource(nssimpleaclResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      nssimpleaclStatsArray[0] = resource.nssimpleacl;
      return (base_resource[]) nssimpleaclStatsArray;
    }

    internal override string get_object_name() => (string) null;

    public static nssimpleacl_stats get(nitro_service service) => ((nssimpleacl_stats[]) new nssimpleacl_stats().stat_resources(service, (options) null))[0];

    public static nssimpleacl_stats get(nitro_service service, options option) => ((nssimpleacl_stats[]) new nssimpleacl_stats().stat_resources(service, option))[0];

    private class nssimpleacl_response : base_response
    {
      public nssimpleacl_stats nssimpleacl = (nssimpleacl_stats) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
