// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.autoscale.autoscaleprofile
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.autoscale
{
  public class autoscaleprofile : base_resource
  {
    private string nameField = (string) null;
    private string typeField = (string) null;
    private string urlField = (string) null;
    private string apikeyField = (string) null;
    private string sharedsecretField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string type
    {
      get => this.typeField;
      set => this.typeField = value;
    }

    public string url
    {
      get => this.urlField;
      set => this.urlField = value;
    }

    public string apikey
    {
      get => this.apikeyField;
      set => this.apikeyField = value;
    }

    public string sharedsecret
    {
      get => this.sharedsecretField;
      set => this.sharedsecretField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      autoscaleprofile.autoscaleprofile_response autoscaleprofileResponse = new autoscaleprofile.autoscaleprofile_response();
      autoscaleprofile.autoscaleprofile_response resource = (autoscaleprofile.autoscaleprofile_response) service.get_payload_formatter().string_to_resource(autoscaleprofileResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.autoscaleprofile;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, autoscaleprofile resource) => new autoscaleprofile()
    {
      name = resource.name,
      type = resource.type,
      url = resource.url,
      apikey = resource.apikey,
      sharedsecret = resource.sharedsecret
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      autoscaleprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        autoscaleprofile[] autoscaleprofileArray = new autoscaleprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          autoscaleprofileArray[index] = new autoscaleprofile();
          autoscaleprofileArray[index].name = resources[index].name;
          autoscaleprofileArray[index].type = resources[index].type;
          autoscaleprofileArray[index].url = resources[index].url;
          autoscaleprofileArray[index].apikey = resources[index].apikey;
          autoscaleprofileArray[index].sharedsecret = resources[index].sharedsecret;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) autoscaleprofileArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new autoscaleprofile()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, autoscaleprofile resource) => new autoscaleprofile()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        autoscaleprofile[] autoscaleprofileArray = new autoscaleprofile[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          autoscaleprofileArray[index] = new autoscaleprofile();
          autoscaleprofileArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) autoscaleprofileArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      autoscaleprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        autoscaleprofile[] autoscaleprofileArray = new autoscaleprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          autoscaleprofileArray[index] = new autoscaleprofile();
          autoscaleprofileArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) autoscaleprofileArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, autoscaleprofile resource) => new autoscaleprofile()
    {
      name = resource.name,
      url = resource.url,
      apikey = resource.apikey,
      sharedsecret = resource.sharedsecret
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      autoscaleprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        autoscaleprofile[] autoscaleprofileArray = new autoscaleprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          autoscaleprofileArray[index] = new autoscaleprofile();
          autoscaleprofileArray[index].name = resources[index].name;
          autoscaleprofileArray[index].url = resources[index].url;
          autoscaleprofileArray[index].apikey = resources[index].apikey;
          autoscaleprofileArray[index].sharedsecret = resources[index].sharedsecret;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) autoscaleprofileArray);
      }
      return baseResponses;
    }

    public static autoscaleprofile[] get(nitro_service service) => (autoscaleprofile[]) new autoscaleprofile().get_resources(service, (options) null);

    public static autoscaleprofile[] get(nitro_service service, options option) => (autoscaleprofile[]) new autoscaleprofile().get_resources(service, option);

    public static autoscaleprofile get(nitro_service service, string name) => (autoscaleprofile) new autoscaleprofile()
    {
      name = name
    }.get_resource(service);

    public static autoscaleprofile[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (autoscaleprofile[]) null;
      autoscaleprofile[] autoscaleprofileArray1 = new autoscaleprofile[name.Length];
      autoscaleprofile[] autoscaleprofileArray2 = new autoscaleprofile[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        autoscaleprofileArray2[index] = new autoscaleprofile();
        autoscaleprofileArray2[index].name = name[index];
        autoscaleprofileArray1[index] = (autoscaleprofile) autoscaleprofileArray2[index].get_resource(service);
      }
      return autoscaleprofileArray1;
    }

    public static autoscaleprofile[] get_filtered(
      nitro_service service,
      string filter)
    {
      autoscaleprofile autoscaleprofile = new autoscaleprofile();
      options option = new options();
      option.set_filter(filter);
      return (autoscaleprofile[]) autoscaleprofile.getfiltered(service, option);
    }

    public static autoscaleprofile[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      autoscaleprofile autoscaleprofile = new autoscaleprofile();
      options option = new options();
      option.set_filter(filter);
      return (autoscaleprofile[]) autoscaleprofile.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      autoscaleprofile autoscaleprofile = new autoscaleprofile();
      options option = new options();
      option.set_count(true);
      autoscaleprofile[] resources = (autoscaleprofile[]) autoscaleprofile.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      autoscaleprofile autoscaleprofile = new autoscaleprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      autoscaleprofile[] autoscaleprofileArray = (autoscaleprofile[]) autoscaleprofile.getfiltered(service, option);
      return autoscaleprofileArray != null && autoscaleprofileArray.Length > 0 ? autoscaleprofileArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      autoscaleprofile autoscaleprofile = new autoscaleprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      autoscaleprofile[] autoscaleprofileArray = (autoscaleprofile[]) autoscaleprofile.getfiltered(service, option);
      return autoscaleprofileArray != null && autoscaleprofileArray.Length > 0 ? autoscaleprofileArray[0].__count.Value : 0U;
    }

    private class autoscaleprofile_response : base_response
    {
      public autoscaleprofile[] autoscaleprofile = (autoscaleprofile[]) null;
    }

    public static class typeEnum
    {
      public const string CLOUDSTACK = "CLOUDSTACK";
    }
  }
}
