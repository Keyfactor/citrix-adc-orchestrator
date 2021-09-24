// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.filter.filterpolicy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.filter
{
  public class filterpolicy : base_resource
  {
    private string nameField = (string) null;
    private string ruleField = (string) null;
    private string reqactionField = (string) null;
    private string resactionField = (string) null;
    private long? hitsField = new long?();
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

    public string rule
    {
      get => this.ruleField;
      set => this.ruleField = value;
    }

    public string reqaction
    {
      get => this.reqactionField;
      set => this.reqactionField = value;
    }

    public string resaction
    {
      get => this.resactionField;
      set => this.resactionField = value;
    }

    public long? hits
    {
      get => this.hitsField;
      private set => this.hitsField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      filterpolicy.filterpolicy_response filterpolicyResponse = new filterpolicy.filterpolicy_response();
      filterpolicy.filterpolicy_response resource = (filterpolicy.filterpolicy_response) service.get_payload_formatter().string_to_resource(filterpolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.filterpolicy;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, filterpolicy resource) => new filterpolicy()
    {
      name = resource.name,
      rule = resource.rule,
      reqaction = resource.reqaction,
      resaction = resource.resaction
    }.add_resource(client);

    public static base_responses add(nitro_service client, filterpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        filterpolicy[] filterpolicyArray = new filterpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          filterpolicyArray[index] = new filterpolicy();
          filterpolicyArray[index].name = resources[index].name;
          filterpolicyArray[index].rule = resources[index].rule;
          filterpolicyArray[index].reqaction = resources[index].reqaction;
          filterpolicyArray[index].resaction = resources[index].resaction;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) filterpolicyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new filterpolicy()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, filterpolicy resource) => new filterpolicy()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        filterpolicy[] filterpolicyArray = new filterpolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          filterpolicyArray[index] = new filterpolicy();
          filterpolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) filterpolicyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      filterpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        filterpolicy[] filterpolicyArray = new filterpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          filterpolicyArray[index] = new filterpolicy();
          filterpolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) filterpolicyArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, filterpolicy resource) => new filterpolicy()
    {
      name = resource.name,
      rule = resource.rule,
      reqaction = resource.reqaction,
      resaction = resource.resaction
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      filterpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        filterpolicy[] filterpolicyArray = new filterpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          filterpolicyArray[index] = new filterpolicy();
          filterpolicyArray[index].name = resources[index].name;
          filterpolicyArray[index].rule = resources[index].rule;
          filterpolicyArray[index].reqaction = resources[index].reqaction;
          filterpolicyArray[index].resaction = resources[index].resaction;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) filterpolicyArray);
      }
      return baseResponses;
    }

    public static filterpolicy[] get(nitro_service service) => (filterpolicy[]) new filterpolicy().get_resources(service, (options) null);

    public static filterpolicy[] get(nitro_service service, options option) => (filterpolicy[]) new filterpolicy().get_resources(service, option);

    public static filterpolicy get(nitro_service service, string name) => (filterpolicy) new filterpolicy()
    {
      name = name
    }.get_resource(service);

    public static filterpolicy[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (filterpolicy[]) null;
      filterpolicy[] filterpolicyArray1 = new filterpolicy[name.Length];
      filterpolicy[] filterpolicyArray2 = new filterpolicy[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        filterpolicyArray2[index] = new filterpolicy();
        filterpolicyArray2[index].name = name[index];
        filterpolicyArray1[index] = (filterpolicy) filterpolicyArray2[index].get_resource(service);
      }
      return filterpolicyArray1;
    }

    public static filterpolicy[] get_filtered(nitro_service service, string filter)
    {
      filterpolicy filterpolicy = new filterpolicy();
      options option = new options();
      option.set_filter(filter);
      return (filterpolicy[]) filterpolicy.getfiltered(service, option);
    }

    public static filterpolicy[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      filterpolicy filterpolicy = new filterpolicy();
      options option = new options();
      option.set_filter(filter);
      return (filterpolicy[]) filterpolicy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      filterpolicy filterpolicy = new filterpolicy();
      options option = new options();
      option.set_count(true);
      filterpolicy[] resources = (filterpolicy[]) filterpolicy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      filterpolicy filterpolicy = new filterpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      filterpolicy[] filterpolicyArray = (filterpolicy[]) filterpolicy.getfiltered(service, option);
      return filterpolicyArray != null && filterpolicyArray.Length > 0 ? filterpolicyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      filterpolicy filterpolicy = new filterpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      filterpolicy[] filterpolicyArray = (filterpolicy[]) filterpolicy.getfiltered(service, option);
      return filterpolicyArray != null && filterpolicyArray.Length > 0 ? filterpolicyArray[0].__count.Value : 0U;
    }

    private class filterpolicy_response : base_response
    {
      public filterpolicy[] filterpolicy = (filterpolicy[]) null;
    }
  }
}
