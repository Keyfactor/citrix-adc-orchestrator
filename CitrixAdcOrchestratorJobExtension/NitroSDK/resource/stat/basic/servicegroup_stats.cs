// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.basic.servicegroup_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.basic
{
  public class servicegroup_stats : base_resource
  {
    private string servicegroupnameField = (string) null;
    private string clearstatsField = (string) null;
    private string stateField = (string) null;
    private string servicetypeField = (string) null;

    public string servicegroupname
    {
      get => this.servicegroupnameField;
      set => this.servicegroupnameField = value;
    }

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public string servicetype
    {
      get => this.servicetypeField;
      private set => this.servicetypeField = value;
    }

    public string state
    {
      get => this.stateField;
      private set => this.stateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      servicegroup_stats.servicegroup_response servicegroupResponse = new servicegroup_stats.servicegroup_response();
      servicegroup_stats.servicegroup_response resource = (servicegroup_stats.servicegroup_response) service.get_payload_formatter().string_to_resource(servicegroupResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.servicegroup;
    }

    internal override string get_object_name() => this.servicegroupname;

    public static servicegroup_stats[] get(nitro_service service) => (servicegroup_stats[]) new servicegroup_stats().stat_resources(service, (options) null);

    public static servicegroup_stats[] get(nitro_service service, options option) => (servicegroup_stats[]) new servicegroup_stats().stat_resources(service, option);

    public static servicegroup_stats get(
      nitro_service service,
      string servicegroupname)
    {
      return (servicegroup_stats) new servicegroup_stats()
      {
        servicegroupname = servicegroupname
      }.stat_resource(service);
    }

    private class servicegroup_response : base_response
    {
      public servicegroup_stats[] servicegroup = (servicegroup_stats[]) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
