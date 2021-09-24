// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.authentication.authenticationpolicylabel_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.authentication
{
  public class authenticationpolicylabel_stats : base_resource
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
      authenticationpolicylabel_stats.authenticationpolicylabel_response authenticationpolicylabelResponse = new authenticationpolicylabel_stats.authenticationpolicylabel_response();
      authenticationpolicylabel_stats.authenticationpolicylabel_response resource = (authenticationpolicylabel_stats.authenticationpolicylabel_response) service.get_payload_formatter().string_to_resource(authenticationpolicylabelResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationpolicylabel;
    }

    internal override string get_object_name() => this.labelname;

    public static authenticationpolicylabel_stats[] get(
      nitro_service service)
    {
      return (authenticationpolicylabel_stats[]) new authenticationpolicylabel_stats().stat_resources(service, (options) null);
    }

    public static authenticationpolicylabel_stats[] get(
      nitro_service service,
      options option)
    {
      return (authenticationpolicylabel_stats[]) new authenticationpolicylabel_stats().stat_resources(service, option);
    }

    public static authenticationpolicylabel_stats get(
      nitro_service service,
      string labelname)
    {
      return (authenticationpolicylabel_stats) new authenticationpolicylabel_stats()
      {
        labelname = labelname
      }.stat_resource(service);
    }

    private class authenticationpolicylabel_response : base_response
    {
      public authenticationpolicylabel_stats[] authenticationpolicylabel = (authenticationpolicylabel_stats[]) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
