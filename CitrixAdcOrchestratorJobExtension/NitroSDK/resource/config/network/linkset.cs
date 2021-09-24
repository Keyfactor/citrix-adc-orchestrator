// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.linkset
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class linkset : base_resource
  {
    private string idField = (string) null;
    private string ifnumField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string id
    {
      get => this.idField;
      set => this.idField = value;
    }

    public string ifnum
    {
      get => this.ifnumField;
      private set => this.ifnumField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      linkset.linkset_response linksetResponse = new linkset.linkset_response();
      linkset.linkset_response resource = (linkset.linkset_response) service.get_payload_formatter().string_to_resource(linksetResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.linkset;
    }

    internal override string get_object_name() => this.id;

    public static base_response add(nitro_service client, linkset resource) => new linkset()
    {
      id = resource.id
    }.add_resource(client);

    public static base_responses add(nitro_service client, linkset[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        linkset[] linksetArray = new linkset[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          linksetArray[index] = new linkset();
          linksetArray[index].id = resources[index].id;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) linksetArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string id) => new linkset()
    {
      id = id
    }.delete_resource(client);

    public static base_response delete(nitro_service client, linkset resource) => new linkset()
    {
      id = resource.id
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] id)
    {
      base_responses baseResponses = (base_responses) null;
      if (id != null && id.Length > 0)
      {
        linkset[] linksetArray = new linkset[id.Length];
        for (int index = 0; index < id.Length; ++index)
        {
          linksetArray[index] = new linkset();
          linksetArray[index].id = id[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) linksetArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, linkset[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        linkset[] linksetArray = new linkset[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          linksetArray[index] = new linkset();
          linksetArray[index].id = resources[index].id;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) linksetArray);
      }
      return baseResponses;
    }

    public static linkset[] get(nitro_service service) => (linkset[]) new linkset().get_resources(service, (options) null);

    public static linkset[] get(nitro_service service, options option) => (linkset[]) new linkset().get_resources(service, option);

    public static linkset get(nitro_service service, string id) => (linkset) new linkset()
    {
      id = id
    }.get_resource(service);

    public static linkset[] get(nitro_service service, string[] id)
    {
      if (id == null || id.Length <= 0)
        return (linkset[]) null;
      linkset[] linksetArray1 = new linkset[id.Length];
      linkset[] linksetArray2 = new linkset[id.Length];
      for (int index = 0; index < id.Length; ++index)
      {
        linksetArray2[index] = new linkset();
        linksetArray2[index].id = id[index];
        linksetArray1[index] = (linkset) linksetArray2[index].get_resource(service);
      }
      return linksetArray1;
    }

    public static linkset[] get_filtered(nitro_service service, string filter)
    {
      linkset linkset = new linkset();
      options option = new options();
      option.set_filter(filter);
      return (linkset[]) linkset.getfiltered(service, option);
    }

    public static linkset[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      linkset linkset = new linkset();
      options option = new options();
      option.set_filter(filter);
      return (linkset[]) linkset.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      linkset linkset = new linkset();
      options option = new options();
      option.set_count(true);
      linkset[] resources = (linkset[]) linkset.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      linkset linkset = new linkset();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      linkset[] linksetArray = (linkset[]) linkset.getfiltered(service, option);
      return linksetArray != null && linksetArray.Length > 0 ? linksetArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      linkset linkset = new linkset();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      linkset[] linksetArray = (linkset[]) linkset.getfiltered(service, option);
      return linksetArray != null && linksetArray.Length > 0 ? linksetArray[0].__count.Value : 0U;
    }

    private class linkset_response : base_response
    {
      public linkset[] linkset = (linkset[]) null;
    }
  }
}
