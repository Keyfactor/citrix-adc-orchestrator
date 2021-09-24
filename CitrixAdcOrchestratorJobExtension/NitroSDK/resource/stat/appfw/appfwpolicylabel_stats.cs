// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.appfw.appfwpolicylabel_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.appfw
{
  public class appfwpolicylabel_stats : base_resource
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
      appfwpolicylabel_stats.appfwpolicylabel_response appfwpolicylabelResponse = new appfwpolicylabel_stats.appfwpolicylabel_response();
      appfwpolicylabel_stats.appfwpolicylabel_response resource = (appfwpolicylabel_stats.appfwpolicylabel_response) service.get_payload_formatter().string_to_resource(appfwpolicylabelResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.appfwpolicylabel;
    }

    internal override string get_object_name() => this.labelname;

    public static appfwpolicylabel_stats[] get(nitro_service service) => (appfwpolicylabel_stats[]) new appfwpolicylabel_stats().stat_resources(service, (options) null);

    public static appfwpolicylabel_stats[] get(
      nitro_service service,
      options option)
    {
      return (appfwpolicylabel_stats[]) new appfwpolicylabel_stats().stat_resources(service, option);
    }

    public static appfwpolicylabel_stats get(
      nitro_service service,
      string labelname)
    {
      return (appfwpolicylabel_stats) new appfwpolicylabel_stats()
      {
        labelname = labelname
      }.stat_resource(service);
    }

    private class appfwpolicylabel_response : base_response
    {
      public appfwpolicylabel_stats[] appfwpolicylabel = (appfwpolicylabel_stats[]) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
