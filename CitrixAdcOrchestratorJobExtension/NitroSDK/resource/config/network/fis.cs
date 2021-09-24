// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.fis
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class fis : base_resource
  {
    private string nameField = (string) null;
    private uint? ownernodeField = new uint?();
    private string ifacesField = (string) null;
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

    public uint? ownernode
    {
      get => this.ownernodeField;
      set => this.ownernodeField = value;
    }

    public string ifaces
    {
      get => this.ifacesField;
      private set => this.ifacesField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      fis.fis_response fisResponse = new fis.fis_response();
      fis.fis_response resource = (fis.fis_response) service.get_payload_formatter().string_to_resource(fisResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.fis;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, fis resource) => new fis()
    {
      name = resource.name,
      ownernode = resource.ownernode
    }.add_resource(client);

    public static base_responses add(nitro_service client, fis[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        fis[] fisArray = new fis[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          fisArray[index] = new fis();
          fisArray[index].name = resources[index].name;
          fisArray[index].ownernode = resources[index].ownernode;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) fisArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new fis()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, fis resource) => new fis()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        fis[] fisArray = new fis[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          fisArray[index] = new fis();
          fisArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) fisArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, fis[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        fis[] fisArray = new fis[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          fisArray[index] = new fis();
          fisArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) fisArray);
      }
      return baseResponses;
    }

    public static fis[] get(nitro_service service) => (fis[]) new fis().get_resources(service, (options) null);

    public static fis[] get(nitro_service service, options option) => (fis[]) new fis().get_resources(service, option);

    public static fis get(nitro_service service, string name) => (fis) new fis()
    {
      name = name
    }.get_resource(service);

    public static fis[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (fis[]) null;
      fis[] fisArray1 = new fis[name.Length];
      fis[] fisArray2 = new fis[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        fisArray2[index] = new fis();
        fisArray2[index].name = name[index];
        fisArray1[index] = (fis) fisArray2[index].get_resource(service);
      }
      return fisArray1;
    }

    public static fis[] get_filtered(nitro_service service, string filter)
    {
      fis fis = new fis();
      options option = new options();
      option.set_filter(filter);
      return (fis[]) fis.getfiltered(service, option);
    }

    public static fis[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      fis fis = new fis();
      options option = new options();
      option.set_filter(filter);
      return (fis[]) fis.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      fis fis = new fis();
      options option = new options();
      option.set_count(true);
      fis[] resources = (fis[]) fis.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      fis fis = new fis();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      fis[] fisArray = (fis[]) fis.getfiltered(service, option);
      return fisArray != null && fisArray.Length > 0 ? fisArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      fis fis = new fis();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      fis[] fisArray = (fis[]) fis.getfiltered(service, option);
      return fisArray != null && fisArray.Length > 0 ? fisArray[0].__count.Value : 0U;
    }

    private class fis_response : base_response
    {
      public fis[] fis = (fis[]) null;
    }
  }
}
