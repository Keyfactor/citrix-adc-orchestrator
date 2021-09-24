// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.ns.nsacl_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.ns
{
  public class nsacl_stats : base_resource
  {
    private string aclnameField = (string) null;
    private string clearstatsField = (string) null;
    private long acltotpktsbridgedField = 0;
    private long aclpktsbridgedrateField = 0;
    private long acltotpktsdeniedField = 0;
    private long aclpktsdeniedrateField = 0;
    private long acltotpktsallowedField = 0;
    private long aclpktsallowedrateField = 0;
    private long acltotpktsnatField = 0;
    private long aclpktsnatrateField = 0;
    private long acltothitsField = 0;
    private long aclhitsrateField = 0;
    private long acltotmissesField = 0;
    private long aclmissesrateField = 0;
    private long acltotcountField = 0;
    private long aclperhitsField = 0;
    private long aclperhitsrateField = 0;

    public string aclname
    {
      get => this.aclnameField;
      set => this.aclnameField = value;
    }

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long acltotpktsnat
    {
      get => this.acltotpktsnatField;
      private set => this.acltotpktsnatField = value;
    }

    public long aclpktsdeniedrate
    {
      get => this.aclpktsdeniedrateField;
      private set => this.aclpktsdeniedrateField = value;
    }

    public long aclhitsrate
    {
      get => this.aclhitsrateField;
      private set => this.aclhitsrateField = value;
    }

    public long aclpktsallowedrate
    {
      get => this.aclpktsallowedrateField;
      private set => this.aclpktsallowedrateField = value;
    }

    public long acltotpktsallowed
    {
      get => this.acltotpktsallowedField;
      private set => this.acltotpktsallowedField = value;
    }

    public long aclpktsbridgedrate
    {
      get => this.aclpktsbridgedrateField;
      private set => this.aclpktsbridgedrateField = value;
    }

    public long acltotpktsdenied
    {
      get => this.acltotpktsdeniedField;
      private set => this.acltotpktsdeniedField = value;
    }

    public long acltothits
    {
      get => this.acltothitsField;
      private set => this.acltothitsField = value;
    }

    public long aclperhits
    {
      get => this.aclperhitsField;
      private set => this.aclperhitsField = value;
    }

    public long aclperhitsrate
    {
      get => this.aclperhitsrateField;
      private set => this.aclperhitsrateField = value;
    }

    public long aclpktsnatrate
    {
      get => this.aclpktsnatrateField;
      private set => this.aclpktsnatrateField = value;
    }

    public long acltotcount
    {
      get => this.acltotcountField;
      private set => this.acltotcountField = value;
    }

    public long acltotmisses
    {
      get => this.acltotmissesField;
      private set => this.acltotmissesField = value;
    }

    public long acltotpktsbridged
    {
      get => this.acltotpktsbridgedField;
      private set => this.acltotpktsbridgedField = value;
    }

    public long aclmissesrate
    {
      get => this.aclmissesrateField;
      private set => this.aclmissesrateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nsacl_stats.nsacl_response nsaclResponse = new nsacl_stats.nsacl_response();
      nsacl_stats.nsacl_response resource = (nsacl_stats.nsacl_response) service.get_payload_formatter().string_to_resource(nsaclResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nsacl;
    }

    internal override string get_object_name() => this.aclname;

    public static nsacl_stats[] get(nitro_service service) => (nsacl_stats[]) new nsacl_stats().stat_resources(service, (options) null);

    public static nsacl_stats[] get(nitro_service service, options option) => (nsacl_stats[]) new nsacl_stats().stat_resources(service, option);

    public static nsacl_stats get(nitro_service service, string aclname) => (nsacl_stats) new nsacl_stats()
    {
      aclname = aclname
    }.stat_resource(service);

    private class nsacl_response : base_response
    {
      public nsacl_stats[] nsacl = (nsacl_stats[]) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
