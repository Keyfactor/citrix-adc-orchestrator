// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.interfacepair
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class interfacepair : base_resource
  {
    private uint? idField = new uint?();
    private string[] ifnumField = (string[]) null;
    private string ifacesField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public uint? id
    {
      get => this.idField;
      set => this.idField = value;
    }

    public string[] ifnum
    {
      get => this.ifnumField;
      set => this.ifnumField = value;
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
      interfacepair.interfacepair_response interfacepairResponse = new interfacepair.interfacepair_response();
      interfacepair.interfacepair_response resource = (interfacepair.interfacepair_response) service.get_payload_formatter().string_to_resource(interfacepairResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.interfacepair;
    }

    internal override string get_object_name() => this.id.HasValue ? this.id.ToString() : (string) null;

    public static base_response add(nitro_service client, interfacepair resource) => new interfacepair()
    {
      id = resource.id,
      ifnum = resource.ifnum
    }.add_resource(client);

    public static base_responses add(nitro_service client, interfacepair[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        interfacepair[] interfacepairArray = new interfacepair[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          interfacepairArray[index] = new interfacepair();
          interfacepairArray[index].id = resources[index].id;
          interfacepairArray[index].ifnum = resources[index].ifnum;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) interfacepairArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, uint? id) => new interfacepair()
    {
      id = id
    }.delete_resource(client);

    public static base_response delete(nitro_service client, interfacepair resource) => new interfacepair()
    {
      id = resource.id
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, uint?[] id)
    {
      base_responses baseResponses = (base_responses) null;
      if (id != null && id.Length > 0)
      {
        interfacepair[] interfacepairArray = new interfacepair[id.Length];
        for (int index = 0; index < id.Length; ++index)
        {
          interfacepairArray[index] = new interfacepair();
          interfacepairArray[index].id = id[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) interfacepairArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      interfacepair[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        interfacepair[] interfacepairArray = new interfacepair[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          interfacepairArray[index] = new interfacepair();
          interfacepairArray[index].id = resources[index].id;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) interfacepairArray);
      }
      return baseResponses;
    }

    public static interfacepair[] get(nitro_service service) => (interfacepair[]) new interfacepair().get_resources(service, (options) null);

    public static interfacepair[] get(nitro_service service, options option) => (interfacepair[]) new interfacepair().get_resources(service, option);

    public static interfacepair get(nitro_service service, uint? id) => (interfacepair) new interfacepair()
    {
      id = id
    }.get_resource(service);

    public static interfacepair[] get(nitro_service service, uint?[] id)
    {
      if (id == null || id.Length <= 0)
        return (interfacepair[]) null;
      interfacepair[] interfacepairArray1 = new interfacepair[id.Length];
      interfacepair[] interfacepairArray2 = new interfacepair[id.Length];
      for (int index = 0; index < id.Length; ++index)
      {
        interfacepairArray2[index] = new interfacepair();
        interfacepairArray2[index].id = id[index];
        interfacepairArray1[index] = (interfacepair) interfacepairArray2[index].get_resource(service);
      }
      return interfacepairArray1;
    }

    public static interfacepair[] get_filtered(nitro_service service, string filter)
    {
      interfacepair interfacepair = new interfacepair();
      options option = new options();
      option.set_filter(filter);
      return (interfacepair[]) interfacepair.getfiltered(service, option);
    }

    public static interfacepair[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      interfacepair interfacepair = new interfacepair();
      options option = new options();
      option.set_filter(filter);
      return (interfacepair[]) interfacepair.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      interfacepair interfacepair = new interfacepair();
      options option = new options();
      option.set_count(true);
      interfacepair[] resources = (interfacepair[]) interfacepair.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      interfacepair interfacepair = new interfacepair();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      interfacepair[] interfacepairArray = (interfacepair[]) interfacepair.getfiltered(service, option);
      return interfacepairArray != null && interfacepairArray.Length > 0 ? interfacepairArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      interfacepair interfacepair = new interfacepair();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      interfacepair[] interfacepairArray = (interfacepair[]) interfacepair.getfiltered(service, option);
      return interfacepairArray != null && interfacepairArray.Length > 0 ? interfacepairArray[0].__count.Value : 0U;
    }

    private class interfacepair_response : base_response
    {
      public interfacepair[] interfacepair = (interfacepair[]) null;
    }
  }
}
