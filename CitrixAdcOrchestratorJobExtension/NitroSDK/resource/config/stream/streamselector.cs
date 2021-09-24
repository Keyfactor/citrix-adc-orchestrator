// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.stream.streamselector
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.stream
{
  public class streamselector : base_resource
  {
    private string nameField = (string) null;
    private string[] ruleField = (string[]) null;
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

    public string[] rule
    {
      get => this.ruleField;
      set => this.ruleField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      streamselector.streamselector_response streamselectorResponse = new streamselector.streamselector_response();
      streamselector.streamselector_response resource = (streamselector.streamselector_response) service.get_payload_formatter().string_to_resource(streamselectorResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.streamselector;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, streamselector resource) => new streamselector()
    {
      name = resource.name,
      rule = resource.rule
    }.add_resource(client);

    public static base_responses add(nitro_service client, streamselector[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        streamselector[] streamselectorArray = new streamselector[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          streamselectorArray[index] = new streamselector();
          streamselectorArray[index].name = resources[index].name;
          streamselectorArray[index].rule = resources[index].rule;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) streamselectorArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, streamselector resource) => new streamselector()
    {
      name = resource.name,
      rule = resource.rule
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      streamselector[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        streamselector[] streamselectorArray = new streamselector[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          streamselectorArray[index] = new streamselector();
          streamselectorArray[index].name = resources[index].name;
          streamselectorArray[index].rule = resources[index].rule;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) streamselectorArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new streamselector()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, streamselector resource) => new streamselector()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        streamselector[] streamselectorArray = new streamselector[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          streamselectorArray[index] = new streamselector();
          streamselectorArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) streamselectorArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      streamselector[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        streamselector[] streamselectorArray = new streamselector[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          streamselectorArray[index] = new streamselector();
          streamselectorArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) streamselectorArray);
      }
      return baseResponses;
    }

    public static streamselector[] get(nitro_service service) => (streamselector[]) new streamselector().get_resources(service, (options) null);

    public static streamselector[] get(nitro_service service, options option) => (streamselector[]) new streamselector().get_resources(service, option);

    public static streamselector get(nitro_service service, string name) => (streamselector) new streamselector()
    {
      name = name
    }.get_resource(service);

    public static streamselector[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (streamselector[]) null;
      streamselector[] streamselectorArray1 = new streamselector[name.Length];
      streamselector[] streamselectorArray2 = new streamselector[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        streamselectorArray2[index] = new streamselector();
        streamselectorArray2[index].name = name[index];
        streamselectorArray1[index] = (streamselector) streamselectorArray2[index].get_resource(service);
      }
      return streamselectorArray1;
    }

    public static streamselector[] get_filtered(nitro_service service, string filter)
    {
      streamselector streamselector = new streamselector();
      options option = new options();
      option.set_filter(filter);
      return (streamselector[]) streamselector.getfiltered(service, option);
    }

    public static streamselector[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      streamselector streamselector = new streamselector();
      options option = new options();
      option.set_filter(filter);
      return (streamselector[]) streamselector.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      streamselector streamselector = new streamselector();
      options option = new options();
      option.set_count(true);
      streamselector[] resources = (streamselector[]) streamselector.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      streamselector streamselector = new streamselector();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      streamselector[] streamselectorArray = (streamselector[]) streamselector.getfiltered(service, option);
      return streamselectorArray != null && streamselectorArray.Length > 0 ? streamselectorArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      streamselector streamselector = new streamselector();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      streamselector[] streamselectorArray = (streamselector[]) streamselector.getfiltered(service, option);
      return streamselectorArray != null && streamselectorArray.Length > 0 ? streamselectorArray[0].__count.Value : 0U;
    }

    private class streamselector_response : base_response
    {
      public streamselector[] streamselector = (streamselector[]) null;
    }
  }
}
