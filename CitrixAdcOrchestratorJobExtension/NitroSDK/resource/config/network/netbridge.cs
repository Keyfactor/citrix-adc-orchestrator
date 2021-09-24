// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.netbridge
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class netbridge : base_resource
  {
    private string nameField = (string) null;
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

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      netbridge.netbridge_response netbridgeResponse = new netbridge.netbridge_response();
      netbridge.netbridge_response resource = (netbridge.netbridge_response) service.get_payload_formatter().string_to_resource(netbridgeResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.netbridge;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, netbridge resource) => new netbridge()
    {
      name = resource.name
    }.add_resource(client);

    public static base_responses add(nitro_service client, netbridge[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        netbridge[] netbridgeArray = new netbridge[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          netbridgeArray[index] = new netbridge();
          netbridgeArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) netbridgeArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new netbridge()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, netbridge resource) => new netbridge()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        netbridge[] netbridgeArray = new netbridge[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          netbridgeArray[index] = new netbridge();
          netbridgeArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) netbridgeArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, netbridge[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        netbridge[] netbridgeArray = new netbridge[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          netbridgeArray[index] = new netbridge();
          netbridgeArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) netbridgeArray);
      }
      return baseResponses;
    }

    public static netbridge[] get(nitro_service service) => (netbridge[]) new netbridge().get_resources(service, (options) null);

    public static netbridge[] get(nitro_service service, options option) => (netbridge[]) new netbridge().get_resources(service, option);

    public static netbridge get(nitro_service service, string name) => (netbridge) new netbridge()
    {
      name = name
    }.get_resource(service);

    public static netbridge[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (netbridge[]) null;
      netbridge[] netbridgeArray1 = new netbridge[name.Length];
      netbridge[] netbridgeArray2 = new netbridge[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        netbridgeArray2[index] = new netbridge();
        netbridgeArray2[index].name = name[index];
        netbridgeArray1[index] = (netbridge) netbridgeArray2[index].get_resource(service);
      }
      return netbridgeArray1;
    }

    public static netbridge[] get_filtered(nitro_service service, string filter)
    {
      netbridge netbridge = new netbridge();
      options option = new options();
      option.set_filter(filter);
      return (netbridge[]) netbridge.getfiltered(service, option);
    }

    public static netbridge[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      netbridge netbridge = new netbridge();
      options option = new options();
      option.set_filter(filter);
      return (netbridge[]) netbridge.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      netbridge netbridge = new netbridge();
      options option = new options();
      option.set_count(true);
      netbridge[] resources = (netbridge[]) netbridge.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      netbridge netbridge = new netbridge();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      netbridge[] netbridgeArray = (netbridge[]) netbridge.getfiltered(service, option);
      return netbridgeArray != null && netbridgeArray.Length > 0 ? netbridgeArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      netbridge netbridge = new netbridge();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      netbridge[] netbridgeArray = (netbridge[]) netbridge.getfiltered(service, option);
      return netbridgeArray != null && netbridgeArray.Length > 0 ? netbridgeArray[0].__count.Value : 0U;
    }

    private class netbridge_response : base_response
    {
      public netbridge[] netbridge = (netbridge[]) null;
    }
  }
}
