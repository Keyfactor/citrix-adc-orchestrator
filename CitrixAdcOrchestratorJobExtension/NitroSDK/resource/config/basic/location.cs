// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.basic.location
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.basic
{
  public class location : base_resource
  {
    private string ipfromField = (string) null;
    private string iptoField = (string) null;
    private string preferredlocationField = (string) null;
    private int? longitudeField = new int?();
    private int? latitudeField = new int?();
    private string q1labelField = (string) null;
    private string q2labelField = (string) null;
    private string q3labelField = (string) null;
    private string q4labelField = (string) null;
    private string q5labelField = (string) null;
    private string q6labelField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string ipfrom
    {
      get => this.ipfromField;
      set => this.ipfromField = value;
    }

    public string ipto
    {
      get => this.iptoField;
      set => this.iptoField = value;
    }

    public string preferredlocation
    {
      get => this.preferredlocationField;
      set => this.preferredlocationField = value;
    }

    public int? longitude
    {
      get => this.longitudeField;
      set => this.longitudeField = value;
    }

    public int? latitude
    {
      get => this.latitudeField;
      set => this.latitudeField = value;
    }

    public string q1label
    {
      get => this.q1labelField;
      private set => this.q1labelField = value;
    }

    public string q2label
    {
      get => this.q2labelField;
      private set => this.q2labelField = value;
    }

    public string q3label
    {
      get => this.q3labelField;
      private set => this.q3labelField = value;
    }

    public string q4label
    {
      get => this.q4labelField;
      private set => this.q4labelField = value;
    }

    public string q5label
    {
      get => this.q5labelField;
      private set => this.q5labelField = value;
    }

    public string q6label
    {
      get => this.q6labelField;
      private set => this.q6labelField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      location.location_response locationResponse = new location.location_response();
      location.location_response resource = (location.location_response) service.get_payload_formatter().string_to_resource(locationResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.location;
    }

    internal override string get_object_name() => this.ipfrom;

    public static base_response add(nitro_service client, location resource) => new location()
    {
      ipfrom = resource.ipfrom,
      ipto = resource.ipto,
      preferredlocation = resource.preferredlocation,
      longitude = resource.longitude,
      latitude = resource.latitude
    }.add_resource(client);

    public static base_responses add(nitro_service client, location[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        location[] locationArray = new location[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          locationArray[index] = new location();
          locationArray[index].ipfrom = resources[index].ipfrom;
          locationArray[index].ipto = resources[index].ipto;
          locationArray[index].preferredlocation = resources[index].preferredlocation;
          locationArray[index].longitude = resources[index].longitude;
          locationArray[index].latitude = resources[index].latitude;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) locationArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string ipfrom) => new location()
    {
      ipfrom = ipfrom
    }.delete_resource(client);

    public static base_response delete(nitro_service client, location resource) => new location()
    {
      ipfrom = resource.ipfrom,
      ipto = resource.ipto
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] ipfrom)
    {
      base_responses baseResponses = (base_responses) null;
      if (ipfrom != null && ipfrom.Length > 0)
      {
        location[] locationArray = new location[ipfrom.Length];
        for (int index = 0; index < ipfrom.Length; ++index)
        {
          locationArray[index] = new location();
          locationArray[index].ipfrom = ipfrom[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) locationArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, location[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        location[] locationArray = new location[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          locationArray[index] = new location();
          locationArray[index].ipfrom = resources[index].ipfrom;
          locationArray[index].ipto = resources[index].ipto;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) locationArray);
      }
      return baseResponses;
    }

    public static location[] get(nitro_service service) => (location[]) new location().get_resources(service, (options) null);

    public static location[] get(nitro_service service, options option) => (location[]) new location().get_resources(service, option);

    public static location get(nitro_service service, string ipfrom) => (location) new location()
    {
      ipfrom = ipfrom
    }.get_resource(service);

    public static location[] get(nitro_service service, string[] ipfrom)
    {
      if (ipfrom == null || ipfrom.Length <= 0)
        return (location[]) null;
      location[] locationArray1 = new location[ipfrom.Length];
      location[] locationArray2 = new location[ipfrom.Length];
      for (int index = 0; index < ipfrom.Length; ++index)
      {
        locationArray2[index] = new location();
        locationArray2[index].ipfrom = ipfrom[index];
        locationArray1[index] = (location) locationArray2[index].get_resource(service);
      }
      return locationArray1;
    }

    public static location[] get_filtered(nitro_service service, string filter)
    {
      location location = new location();
      options option = new options();
      option.set_filter(filter);
      return (location[]) location.getfiltered(service, option);
    }

    public static location[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      location location = new location();
      options option = new options();
      option.set_filter(filter);
      return (location[]) location.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      location location = new location();
      options option = new options();
      option.set_count(true);
      location[] resources = (location[]) location.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      location location = new location();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      location[] locationArray = (location[]) location.getfiltered(service, option);
      return locationArray != null && locationArray.Length > 0 ? locationArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      location location = new location();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      location[] locationArray = (location[]) location.getfiltered(service, option);
      return locationArray != null && locationArray.Length > 0 ? locationArray[0].__count.Value : 0U;
    }

    private class location_response : base_response
    {
      public location[] location = (location[]) null;
    }
  }
}
