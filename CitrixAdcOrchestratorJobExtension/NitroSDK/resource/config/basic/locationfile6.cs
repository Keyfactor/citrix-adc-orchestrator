// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.basic.locationfile6
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.basic
{
  public class locationfile6 : base_resource
  {
    private string LocationfileField = (string) null;
    private string formatField = (string) null;
    private string srcField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

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
      locationfile6.locationfile6_response locationfile6Response = new locationfile6.locationfile6_response();
      locationfile6.locationfile6_response resource = (locationfile6.locationfile6_response) service.get_payload_formatter().string_to_resource(locationfile6Response.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.locationfile6;
    }

    internal override string get_object_name() => (string) null;

    public static base_response add(nitro_service client, locationfile6 resource) => new locationfile6()
    {
      Locationfile = resource.Locationfile,
      format = resource.format
    }.add_resource(client);

    public static base_responses add(nitro_service client, locationfile6[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        locationfile6[] locationfile6Array = new locationfile6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          locationfile6Array[index] = new locationfile6();
          locationfile6Array[index].Locationfile = resources[index].Locationfile;
          locationfile6Array[index].format = resources[index].format;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) locationfile6Array);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client) => new locationfile6().delete_resource(client);

    public static base_responses delete(
      nitro_service client,
      locationfile6[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        locationfile6[] locationfile6Array = new locationfile6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
          locationfile6Array[index] = new locationfile6();
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) locationfile6Array);
      }
      return baseResponses;
    }

    public static base_response Import(nitro_service client, locationfile6 resource) => new locationfile6()
    {
      Locationfile = resource.Locationfile,
      src = resource.src
    }.perform_operation_byaction(client, nameof (Import));

    public static base_responses Import(
      nitro_service client,
      locationfile6[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        locationfile6[] locationfile6Array = new locationfile6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          locationfile6Array[index] = new locationfile6();
          locationfile6Array[index].Locationfile = resources[index].Locationfile;
          locationfile6Array[index].src = resources[index].src;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) locationfile6Array, nameof (Import));
      }
      return baseResponses;
    }

    public static locationfile6[] get(nitro_service service) => (locationfile6[]) new locationfile6().get_resources(service, (options) null);

    public static locationfile6[] get(nitro_service service, options option) => (locationfile6[]) new locationfile6().get_resources(service, option);

    public static locationfile6[] get_filtered(nitro_service service, string filter)
    {
      locationfile6 locationfile6 = new locationfile6();
      options option = new options();
      option.set_filter(filter);
      return (locationfile6[]) locationfile6.getfiltered(service, option);
    }

    public static locationfile6[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      locationfile6 locationfile6 = new locationfile6();
      options option = new options();
      option.set_filter(filter);
      return (locationfile6[]) locationfile6.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      locationfile6 locationfile6 = new locationfile6();
      options option = new options();
      option.set_count(true);
      locationfile6[] resources = (locationfile6[]) locationfile6.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      locationfile6 locationfile6 = new locationfile6();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      locationfile6[] locationfile6Array = (locationfile6[]) locationfile6.getfiltered(service, option);
      return locationfile6Array != null && locationfile6Array.Length > 0 ? locationfile6Array[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      locationfile6 locationfile6 = new locationfile6();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      locationfile6[] locationfile6Array = (locationfile6[]) locationfile6.getfiltered(service, option);
      return locationfile6Array != null && locationfile6Array.Length > 0 ? locationfile6Array[0].__count.Value : 0U;
    }

    private class locationfile6_response : base_response
    {
      public locationfile6[] locationfile6 = (locationfile6[]) null;
    }

    public static class formatEnum
    {
      public const string netscaler6 = "netscaler6";
      public const string geoip_country6 = "geoip-country6";
    }
  }
}
