// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.ns.nspbr_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.ns
{
  public class nspbr_stats : base_resource
  {
    private string nameField = (string) null;
    private string clearstatsField = (string) null;
    private long pbrtotpktsallowedField = 0;
    private long pbrpktsallowedrateField = 0;
    private long pbrtotpktsdeniedField = 0;
    private long pbrpktsdeniedrateField = 0;
    private long pbrtothitsField = 0;
    private long pbrhitsrateField = 0;
    private long pbrtotmissesField = 0;
    private long pbrmissesrateField = 0;
    private long pbrperhitsField = 0;
    private long pbrperhitsrateField = 0;

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

    public long pbrpktsdeniedrate
    {
      get => this.pbrpktsdeniedrateField;
      private set => this.pbrpktsdeniedrateField = value;
    }

    public long pbrmissesrate
    {
      get => this.pbrmissesrateField;
      private set => this.pbrmissesrateField = value;
    }

    public long pbrtothits
    {
      get => this.pbrtothitsField;
      private set => this.pbrtothitsField = value;
    }

    public long pbrperhitsrate
    {
      get => this.pbrperhitsrateField;
      private set => this.pbrperhitsrateField = value;
    }

    public long pbrhitsrate
    {
      get => this.pbrhitsrateField;
      private set => this.pbrhitsrateField = value;
    }

    public long pbrperhits
    {
      get => this.pbrperhitsField;
      private set => this.pbrperhitsField = value;
    }

    public long pbrtotmisses
    {
      get => this.pbrtotmissesField;
      private set => this.pbrtotmissesField = value;
    }

    public long pbrtotpktsallowed
    {
      get => this.pbrtotpktsallowedField;
      private set => this.pbrtotpktsallowedField = value;
    }

    public long pbrtotpktsdenied
    {
      get => this.pbrtotpktsdeniedField;
      private set => this.pbrtotpktsdeniedField = value;
    }

    public long pbrpktsallowedrate
    {
      get => this.pbrpktsallowedrateField;
      private set => this.pbrpktsallowedrateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nspbr_stats.nspbr_response nspbrResponse = new nspbr_stats.nspbr_response();
      nspbr_stats.nspbr_response resource = (nspbr_stats.nspbr_response) service.get_payload_formatter().string_to_resource(nspbrResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nspbr;
    }

    internal override string get_object_name() => this.name;

    public static nspbr_stats[] get(nitro_service service) => (nspbr_stats[]) new nspbr_stats().stat_resources(service, (options) null);

    public static nspbr_stats[] get(nitro_service service, options option) => (nspbr_stats[]) new nspbr_stats().stat_resources(service, option);

    public static nspbr_stats get(nitro_service service, string name) => (nspbr_stats) new nspbr_stats()
    {
      name = name
    }.stat_resource(service);

    private class nspbr_response : base_response
    {
      public nspbr_stats[] nspbr = (nspbr_stats[]) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
