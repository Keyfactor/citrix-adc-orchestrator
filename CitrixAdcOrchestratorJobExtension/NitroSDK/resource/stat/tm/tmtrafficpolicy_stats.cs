// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.tm.tmtrafficpolicy_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.tm
{
  public class tmtrafficpolicy_stats : base_resource
  {
    private string nameField = (string) null;
    private string clearstatsField = (string) null;
    private long pipolicyhitsField = 0;
    private long pipolicyhitsrateField = 0;

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

    public long pipolicyhitsrate
    {
      get => this.pipolicyhitsrateField;
      private set => this.pipolicyhitsrateField = value;
    }

    public long pipolicyhits
    {
      get => this.pipolicyhitsField;
      private set => this.pipolicyhitsField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      tmtrafficpolicy_stats.tmtrafficpolicy_response tmtrafficpolicyResponse = new tmtrafficpolicy_stats.tmtrafficpolicy_response();
      tmtrafficpolicy_stats.tmtrafficpolicy_response resource = (tmtrafficpolicy_stats.tmtrafficpolicy_response) service.get_payload_formatter().string_to_resource(tmtrafficpolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.tmtrafficpolicy;
    }

    internal override string get_object_name() => this.name;

    public static tmtrafficpolicy_stats[] get(nitro_service service) => (tmtrafficpolicy_stats[]) new tmtrafficpolicy_stats().stat_resources(service, (options) null);

    public static tmtrafficpolicy_stats[] get(
      nitro_service service,
      options option)
    {
      return (tmtrafficpolicy_stats[]) new tmtrafficpolicy_stats().stat_resources(service, option);
    }

    public static tmtrafficpolicy_stats get(nitro_service service, string name) => (tmtrafficpolicy_stats) new tmtrafficpolicy_stats()
    {
      name = name
    }.stat_resource(service);

    private class tmtrafficpolicy_response : base_response
    {
      public tmtrafficpolicy_stats[] tmtrafficpolicy = (tmtrafficpolicy_stats[]) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
