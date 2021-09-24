// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.policy.policystringmap
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.policy
{
  public class policystringmap : base_resource
  {
    private string nameField = (string) null;
    private string commentField = (string) null;
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

    public string comment
    {
      get => this.commentField;
      set => this.commentField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      policystringmap.policystringmap_response policystringmapResponse = new policystringmap.policystringmap_response();
      policystringmap.policystringmap_response resource = (policystringmap.policystringmap_response) service.get_payload_formatter().string_to_resource(policystringmapResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.policystringmap;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, policystringmap resource) => new policystringmap()
    {
      name = resource.name,
      comment = resource.comment
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      policystringmap[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        policystringmap[] policystringmapArray = new policystringmap[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          policystringmapArray[index] = new policystringmap();
          policystringmapArray[index].name = resources[index].name;
          policystringmapArray[index].comment = resources[index].comment;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) policystringmapArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new policystringmap()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, policystringmap resource) => new policystringmap()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        policystringmap[] policystringmapArray = new policystringmap[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          policystringmapArray[index] = new policystringmap();
          policystringmapArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) policystringmapArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      policystringmap[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        policystringmap[] policystringmapArray = new policystringmap[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          policystringmapArray[index] = new policystringmap();
          policystringmapArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) policystringmapArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, policystringmap resource) => new policystringmap()
    {
      name = resource.name,
      comment = resource.comment
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      policystringmap[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        policystringmap[] policystringmapArray = new policystringmap[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          policystringmapArray[index] = new policystringmap();
          policystringmapArray[index].name = resources[index].name;
          policystringmapArray[index].comment = resources[index].comment;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) policystringmapArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new policystringmap() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      policystringmap resource,
      string[] args)
    {
      return new policystringmap() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        policystringmap[] policystringmapArray = new policystringmap[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          policystringmapArray[index] = new policystringmap();
          policystringmapArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) policystringmapArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      policystringmap[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        policystringmap[] policystringmapArray = new policystringmap[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          policystringmapArray[index] = new policystringmap();
          policystringmapArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) policystringmapArray, args);
      }
      return baseResponses;
    }

    public static policystringmap[] get(nitro_service service) => (policystringmap[]) new policystringmap().get_resources(service, (options) null);

    public static policystringmap[] get(nitro_service service, options option) => (policystringmap[]) new policystringmap().get_resources(service, option);

    public static policystringmap get(nitro_service service, string name) => (policystringmap) new policystringmap()
    {
      name = name
    }.get_resource(service);

    public static policystringmap[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (policystringmap[]) null;
      policystringmap[] policystringmapArray1 = new policystringmap[name.Length];
      policystringmap[] policystringmapArray2 = new policystringmap[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        policystringmapArray2[index] = new policystringmap();
        policystringmapArray2[index].name = name[index];
        policystringmapArray1[index] = (policystringmap) policystringmapArray2[index].get_resource(service);
      }
      return policystringmapArray1;
    }

    public static policystringmap[] get_filtered(
      nitro_service service,
      string filter)
    {
      policystringmap policystringmap = new policystringmap();
      options option = new options();
      option.set_filter(filter);
      return (policystringmap[]) policystringmap.getfiltered(service, option);
    }

    public static policystringmap[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      policystringmap policystringmap = new policystringmap();
      options option = new options();
      option.set_filter(filter);
      return (policystringmap[]) policystringmap.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      policystringmap policystringmap = new policystringmap();
      options option = new options();
      option.set_count(true);
      policystringmap[] resources = (policystringmap[]) policystringmap.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      policystringmap policystringmap = new policystringmap();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      policystringmap[] policystringmapArray = (policystringmap[]) policystringmap.getfiltered(service, option);
      return policystringmapArray != null && policystringmapArray.Length > 0 ? policystringmapArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      policystringmap policystringmap = new policystringmap();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      policystringmap[] policystringmapArray = (policystringmap[]) policystringmap.getfiltered(service, option);
      return policystringmapArray != null && policystringmapArray.Length > 0 ? policystringmapArray[0].__count.Value : 0U;
    }

    private class policystringmap_response : base_response
    {
      public policystringmap[] policystringmap = (policystringmap[]) null;
    }
  }
}
