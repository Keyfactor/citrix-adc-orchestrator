// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.responder.responderpolicylabel_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.responder
{
  public class responderpolicylabel_stats : base_resource
  {
    private string labelnameField = (string) null;
    private string clearstatsField = (string) null;
    private long pipolicylabelhitsField = 0;
    private long pipolicylabelhitsrateField = 0;

    public string labelname
    {
      get => this.labelnameField;
      set => this.labelnameField = value;
    }

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long pipolicylabelhitsrate
    {
      get => this.pipolicylabelhitsrateField;
      private set => this.pipolicylabelhitsrateField = value;
    }

    public long pipolicylabelhits
    {
      get => this.pipolicylabelhitsField;
      private set => this.pipolicylabelhitsField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      responderpolicylabel_stats.responderpolicylabel_response responderpolicylabelResponse = new responderpolicylabel_stats.responderpolicylabel_response();
      responderpolicylabel_stats.responderpolicylabel_response resource = (responderpolicylabel_stats.responderpolicylabel_response) service.get_payload_formatter().string_to_resource(responderpolicylabelResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.responderpolicylabel;
    }

    internal override string get_object_name() => this.labelname;

    public static responderpolicylabel_stats[] get(nitro_service service) => (responderpolicylabel_stats[]) new responderpolicylabel_stats().stat_resources(service, (options) null);

    public static responderpolicylabel_stats[] get(
      nitro_service service,
      options option)
    {
      return (responderpolicylabel_stats[]) new responderpolicylabel_stats().stat_resources(service, option);
    }

    public static responderpolicylabel_stats get(
      nitro_service service,
      string labelname)
    {
      return (responderpolicylabel_stats) new responderpolicylabel_stats()
      {
        labelname = labelname
      }.stat_resource(service);
    }

    private class responderpolicylabel_response : base_response
    {
      public responderpolicylabel_stats[] responderpolicylabel = (responderpolicylabel_stats[]) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
