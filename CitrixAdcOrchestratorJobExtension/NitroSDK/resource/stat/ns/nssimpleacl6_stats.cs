// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.ns.nssimpleacl6_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.ns
{
  public class nssimpleacl6_stats : base_resource
  {
    private string clearstatsField = (string) null;
    private long sacl6tothitsField = 0;
    private long sacl6hitsrateField = 0;
    private long sacl6totmissesField = 0;
    private long sacl6missesrateField = 0;
    private long sacl6scountField = 0;
    private long sacl6totpktsallowedField = 0;
    private long sacl6pktsallowedrateField = 0;
    private long sacl6totpktsbridgedField = 0;
    private long sacl6pktsbridgedrateField = 0;
    private long sacl6totpktsdeniedField = 0;
    private long sacl6pktsdeniedrateField = 0;

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long sacl6scount
    {
      get => this.sacl6scountField;
      private set => this.sacl6scountField = value;
    }

    public long sacl6pktsbridgedrate
    {
      get => this.sacl6pktsbridgedrateField;
      private set => this.sacl6pktsbridgedrateField = value;
    }

    public long sacl6totpktsallowed
    {
      get => this.sacl6totpktsallowedField;
      private set => this.sacl6totpktsallowedField = value;
    }

    public long sacl6totmisses
    {
      get => this.sacl6totmissesField;
      private set => this.sacl6totmissesField = value;
    }

    public long sacl6missesrate
    {
      get => this.sacl6missesrateField;
      private set => this.sacl6missesrateField = value;
    }

    public long sacl6hitsrate
    {
      get => this.sacl6hitsrateField;
      private set => this.sacl6hitsrateField = value;
    }

    public long sacl6tothits
    {
      get => this.sacl6tothitsField;
      private set => this.sacl6tothitsField = value;
    }

    public long sacl6totpktsdenied
    {
      get => this.sacl6totpktsdeniedField;
      private set => this.sacl6totpktsdeniedField = value;
    }

    public long sacl6pktsallowedrate
    {
      get => this.sacl6pktsallowedrateField;
      private set => this.sacl6pktsallowedrateField = value;
    }

    public long sacl6totpktsbridged
    {
      get => this.sacl6totpktsbridgedField;
      private set => this.sacl6totpktsbridgedField = value;
    }

    public long sacl6pktsdeniedrate
    {
      get => this.sacl6pktsdeniedrateField;
      private set => this.sacl6pktsdeniedrateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nssimpleacl6_stats[] nssimpleacl6StatsArray = new nssimpleacl6_stats[1];
      nssimpleacl6_stats.nssimpleacl6_response nssimpleacl6Response = new nssimpleacl6_stats.nssimpleacl6_response();
      nssimpleacl6_stats.nssimpleacl6_response resource = (nssimpleacl6_stats.nssimpleacl6_response) service.get_payload_formatter().string_to_resource(nssimpleacl6Response.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      nssimpleacl6StatsArray[0] = resource.nssimpleacl6;
      return (base_resource[]) nssimpleacl6StatsArray;
    }

    internal override string get_object_name() => (string) null;

    public static nssimpleacl6_stats get(nitro_service service) => ((nssimpleacl6_stats[]) new nssimpleacl6_stats().stat_resources(service, (options) null))[0];

    public static nssimpleacl6_stats get(nitro_service service, options option) => ((nssimpleacl6_stats[]) new nssimpleacl6_stats().stat_resources(service, option))[0];

    private class nssimpleacl6_response : base_response
    {
      public nssimpleacl6_stats nssimpleacl6 = (nssimpleacl6_stats) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
