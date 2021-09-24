// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.ns.nslimitidentifier_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.ns
{
  public class nslimitidentifier_stats : base_resource
  {
    private string nameField = (string) null;
    private string[] patternField = (string[]) null;
    private string clearstatsField = (string) null;
    private string sortbyField = (string) null;
    private string sortorderField = (string) null;
    private long ratelmtobjhitsField = 0;
    private long ratelmtobjdropsField = 0;
    private long ratelmtsessionobjhitsField = 0;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string[] pattern
    {
      get => this.patternField;
      set => this.patternField = value;
    }

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public string sortby
    {
      get => this.sortbyField;
      set => this.sortbyField = value;
    }

    public string sortorder
    {
      get => this.sortorderField;
      set => this.sortorderField = value;
    }

    public long ratelmtobjhits
    {
      get => this.ratelmtobjhitsField;
      private set => this.ratelmtobjhitsField = value;
    }

    public long ratelmtsessionobjhits
    {
      get => this.ratelmtsessionobjhitsField;
      private set => this.ratelmtsessionobjhitsField = value;
    }

    public long ratelmtobjdrops
    {
      get => this.ratelmtobjdropsField;
      private set => this.ratelmtobjdropsField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nslimitidentifier_stats.nslimitidentifier_response nslimitidentifierResponse = new nslimitidentifier_stats.nslimitidentifier_response();
      nslimitidentifier_stats.nslimitidentifier_response resource = (nslimitidentifier_stats.nslimitidentifier_response) service.get_payload_formatter().string_to_resource(nslimitidentifierResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nslimitidentifier;
    }

    internal override string get_object_name() => this.name;

    public static nslimitidentifier_stats[] get(nitro_service service) => (nslimitidentifier_stats[]) new nslimitidentifier_stats().stat_resources(service, (options) null);

    public static nslimitidentifier_stats[] get(
      nitro_service service,
      options option)
    {
      return (nslimitidentifier_stats[]) new nslimitidentifier_stats().stat_resources(service, option);
    }

    public static nslimitidentifier_stats get(
      nitro_service service,
      string name)
    {
      return (nslimitidentifier_stats) new nslimitidentifier_stats()
      {
        name = name
      }.stat_resource(service);
    }

    private class nslimitidentifier_response : base_response
    {
      public nslimitidentifier_stats[] nslimitidentifier = (nslimitidentifier_stats[]) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }

    public static class sortorderEnum
    {
      public const string ascending = "ascending";
      public const string descending = "descending";
    }
  }
}
