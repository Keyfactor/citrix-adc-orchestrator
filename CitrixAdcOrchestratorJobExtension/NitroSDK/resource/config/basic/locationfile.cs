// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.basic.locationfile
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.basic
{
  public class locationfile : base_resource
  {
    private string LocationfileField = (string) null;
    private string formatField = (string) null;
    private string srcField = (string) null;

    public string Locationfile
    {
      get => this.LocationfileField;
      set => this.LocationfileField = value;
    }

    public string format
    {
      get => this.formatField;
      set => this.formatField = value;
    }

    public string src
    {
      get => this.srcField;
      set => this.srcField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      locationfile[] locationfileArray = new locationfile[1];
      locationfile.locationfile_response locationfileResponse = new locationfile.locationfile_response();
      locationfile.locationfile_response resource = (locationfile.locationfile_response) service.get_payload_formatter().string_to_resource(locationfileResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      locationfileArray[0] = resource.locationfile;
      return (base_resource[]) locationfileArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response add(nitro_service client, locationfile resource) => new locationfile()
    {
      Locationfile = resource.Locationfile,
      format = resource.format
    }.add_resource(client);

    public static base_response delete(nitro_service client) => new locationfile().delete_resource(client);

    public static base_response Import(nitro_service client, locationfile resource) => new locationfile()
    {
      Locationfile = resource.Locationfile,
      src = resource.src
    }.perform_operation_byaction(client, nameof (Import));

    public static locationfile get(nitro_service service) => ((locationfile[]) new locationfile().get_resources(service, (options) null))[0];

    public static locationfile get(nitro_service service, options option) => ((locationfile[]) new locationfile().get_resources(service, option))[0];

    private class locationfile_response : base_response
    {
      public locationfile locationfile = (locationfile) null;
    }

    public static class formatEnum
    {
      public const string netscaler = "netscaler";
      public const string ip_country = "ip-country";
      public const string ip_country_isp = "ip-country-isp";
      public const string ip_country_region_city = "ip-country-region-city";
      public const string ip_country_region_city_isp = "ip-country-region-city-isp";
      public const string geoip_country = "geoip-country";
      public const string geoip_region = "geoip-region";
      public const string geoip_city = "geoip-city";
      public const string geoip_country_org = "geoip-country-org";
      public const string geoip_country_isp = "geoip-country-isp";
      public const string geoip_city_isp_org = "geoip-city-isp-org";
    }
  }
}
