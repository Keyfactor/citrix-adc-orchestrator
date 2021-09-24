// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.ns.nsacl6_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.ns
{
  public class nsacl6_stats : base_resource
  {
    private string acl6nameField = (string) null;
    private string clearstatsField = (string) null;
    private long acl6totpktsbridgedField = 0;
    private long acl6pktsbridgedrateField = 0;
    private long acl6totpktsdeniedField = 0;
    private long acl6pktsdeniedrateField = 0;
    private long acl6totpktsallowedField = 0;
    private long acl6pktsallowedrateField = 0;
    private long acl6totpktsnatField = 0;
    private long acl6pktsnatrateField = 0;
    private long acl6tothitsField = 0;
    private long acl6hitsrateField = 0;
    private long acl6totmissesField = 0;
    private long acl6missesrateField = 0;
    private long acl6totpktsnat64Field = 0;
    private long acl6pktsnat64rateField = 0;
    private long acl6totcountField = 0;
    private long acl6perhitsField = 0;
    private long acl6perhitsrateField = 0;

    public string acl6name
    {
      get => this.acl6nameField;
      set => this.acl6nameField = value;
    }

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long acl6pktsnatrate
    {
      get => this.acl6pktsnatrateField;
      private set => this.acl6pktsnatrateField = value;
    }

    public long acl6missesrate
    {
      get => this.acl6missesrateField;
      private set => this.acl6missesrateField = value;
    }

    public long acl6totmisses
    {
      get => this.acl6totmissesField;
      private set => this.acl6totmissesField = value;
    }

    public long acl6totpktsnat64
    {
      get => this.acl6totpktsnat64Field;
      private set => this.acl6totpktsnat64Field = value;
    }

    public long acl6pktsnat64rate
    {
      get => this.acl6pktsnat64rateField;
      private set => this.acl6pktsnat64rateField = value;
    }

    public long acl6totpktsnat
    {
      get => this.acl6totpktsnatField;
      private set => this.acl6totpktsnatField = value;
    }

    public long acl6perhitsrate
    {
      get => this.acl6perhitsrateField;
      private set => this.acl6perhitsrateField = value;
    }

    public long acl6perhits
    {
      get => this.acl6perhitsField;
      private set => this.acl6perhitsField = value;
    }

    public long acl6tothits
    {
      get => this.acl6tothitsField;
      private set => this.acl6tothitsField = value;
    }

    public long acl6pktsbridgedrate
    {
      get => this.acl6pktsbridgedrateField;
      private set => this.acl6pktsbridgedrateField = value;
    }

    public long acl6pktsallowedrate
    {
      get => this.acl6pktsallowedrateField;
      private set => this.acl6pktsallowedrateField = value;
    }

    public long acl6totpktsbridged
    {
      get => this.acl6totpktsbridgedField;
      private set => this.acl6totpktsbridgedField = value;
    }

    public long acl6totpktsdenied
    {
      get => this.acl6totpktsdeniedField;
      private set => this.acl6totpktsdeniedField = value;
    }

    public long acl6totcount
    {
      get => this.acl6totcountField;
      private set => this.acl6totcountField = value;
    }

    public long acl6totpktsallowed
    {
      get => this.acl6totpktsallowedField;
      private set => this.acl6totpktsallowedField = value;
    }

    public long acl6pktsdeniedrate
    {
      get => this.acl6pktsdeniedrateField;
      private set => this.acl6pktsdeniedrateField = value;
    }

    public long acl6hitsrate
    {
      get => this.acl6hitsrateField;
      private set => this.acl6hitsrateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nsacl6_stats.nsacl6_response nsacl6Response = new nsacl6_stats.nsacl6_response();
      nsacl6_stats.nsacl6_response resource = (nsacl6_stats.nsacl6_response) service.get_payload_formatter().string_to_resource(nsacl6Response.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nsacl6;
    }

    internal override string get_object_name() => this.acl6name;

    public static nsacl6_stats[] get(nitro_service service) => (nsacl6_stats[]) new nsacl6_stats().stat_resources(service, (options) null);

    public static nsacl6_stats[] get(nitro_service service, options option) => (nsacl6_stats[]) new nsacl6_stats().stat_resources(service, option);

    public static nsacl6_stats get(nitro_service service, string acl6name) => (nsacl6_stats) new nsacl6_stats()
    {
      acl6name = acl6name
    }.stat_resource(service);

    private class nsacl6_response : base_response
    {
      public nsacl6_stats[] nsacl6 = (nsacl6_stats[]) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
