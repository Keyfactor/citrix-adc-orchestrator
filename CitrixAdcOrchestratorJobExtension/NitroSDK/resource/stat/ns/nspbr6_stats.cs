// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.ns.nspbr6_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.ns
{
  public class nspbr6_stats : base_resource
  {
    private string nameField = (string) null;
    private string clearstatsField = (string) null;
    private long pbr6totpktsallowedField = 0;
    private long pbr6pktsallowedrateField = 0;
    private long pbr6totpktsdeniedField = 0;
    private long pbr6pktsdeniedrateField = 0;
    private long pbr6tothitsField = 0;
    private long pbr6hitsrateField = 0;
    private long pbr6totmissesField = 0;
    private long pbr6missesrateField = 0;
    private long pbr6perhitsField = 0;
    private long pbr6perhitsrateField = 0;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long pbr6pktsallowedrate
    {
      get => this.pbr6pktsallowedrateField;
      private set => this.pbr6pktsallowedrateField = value;
    }

    public long pbr6pktsdeniedrate
    {
      get => this.pbr6pktsdeniedrateField;
      private set => this.pbr6pktsdeniedrateField = value;
    }

    public long pbr6perhits
    {
      get => this.pbr6perhitsField;
      private set => this.pbr6perhitsField = value;
    }

    public long pbr6totpktsallowed
    {
      get => this.pbr6totpktsallowedField;
      private set => this.pbr6totpktsallowedField = value;
    }

    public long pbr6missesrate
    {
      get => this.pbr6missesrateField;
      private set => this.pbr6missesrateField = value;
    }

    public long pbr6tothits
    {
      get => this.pbr6tothitsField;
      private set => this.pbr6tothitsField = value;
    }

    public long pbr6perhitsrate
    {
      get => this.pbr6perhitsrateField;
      private set => this.pbr6perhitsrateField = value;
    }

    public long pbr6totpktsdenied
    {
      get => this.pbr6totpktsdeniedField;
      private set => this.pbr6totpktsdeniedField = value;
    }

    public long pbr6hitsrate
    {
      get => this.pbr6hitsrateField;
      private set => this.pbr6hitsrateField = value;
    }

    public long pbr6totmisses
    {
      get => this.pbr6totmissesField;
      private set => this.pbr6totmissesField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nspbr6_stats.nspbr6_response nspbr6Response = new nspbr6_stats.nspbr6_response();
      nspbr6_stats.nspbr6_response resource = (nspbr6_stats.nspbr6_response) service.get_payload_formatter().string_to_resource(nspbr6Response.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nspbr6;
    }

    internal override string get_object_name() => this.name;

    public static nspbr6_stats[] get(nitro_service service) => (nspbr6_stats[]) new nspbr6_stats().stat_resources(service, (options) null);

    public static nspbr6_stats[] get(nitro_service service, options option) => (nspbr6_stats[]) new nspbr6_stats().stat_resources(service, option);

    public static nspbr6_stats get(nitro_service service, string name) => (nspbr6_stats) new nspbr6_stats()
    {
      name = name
    }.stat_resource(service);

    private class nspbr6_response : base_response
    {
      public nspbr6_stats[] nspbr6 = (nspbr6_stats[]) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
