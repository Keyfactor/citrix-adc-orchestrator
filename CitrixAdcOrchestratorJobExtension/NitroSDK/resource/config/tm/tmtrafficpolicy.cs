// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.tm.tmtrafficpolicy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.tm
{
  public class tmtrafficpolicy : base_resource
  {
    private string nameField = (string) null;
    private string ruleField = (string) null;
    private string actionField = (string) null;
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

    public string action
    {
      get => this.actionField;
      set => this.actionField = value;
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
      tmtrafficpolicy.tmtrafficpolicy_response tmtrafficpolicyResponse = new tmtrafficpolicy.tmtrafficpolicy_response();
      tmtrafficpolicy.tmtrafficpolicy_response resource = (tmtrafficpolicy.tmtrafficpolicy_response) service.get_payload_formatter().string_to_resource(tmtrafficpolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.tmtrafficpolicy;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, tmtrafficpolicy resource) => new tmtrafficpolicy()
    {
      name = resource.name,
      rule = resource.rule,
      action = resource.action
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      tmtrafficpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        tmtrafficpolicy[] tmtrafficpolicyArray = new tmtrafficpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          tmtrafficpolicyArray[index] = new tmtrafficpolicy();
          tmtrafficpolicyArray[index].name = resources[index].name;
          tmtrafficpolicyArray[index].rule = resources[index].rule;
          tmtrafficpolicyArray[index].action = resources[index].action;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) tmtrafficpolicyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new tmtrafficpolicy()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, tmtrafficpolicy resource) => new tmtrafficpolicy()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        tmtrafficpolicy[] tmtrafficpolicyArray = new tmtrafficpolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          tmtrafficpolicyArray[index] = new tmtrafficpolicy();
          tmtrafficpolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) tmtrafficpolicyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      tmtrafficpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        tmtrafficpolicy[] tmtrafficpolicyArray = new tmtrafficpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          tmtrafficpolicyArray[index] = new tmtrafficpolicy();
          tmtrafficpolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) tmtrafficpolicyArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, tmtrafficpolicy resource) => new tmtrafficpolicy()
    {
      name = resource.name,
      rule = resource.rule,
      action = resource.action
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      tmtrafficpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        tmtrafficpolicy[] tmtrafficpolicyArray = new tmtrafficpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          tmtrafficpolicyArray[index] = new tmtrafficpolicy();
          tmtrafficpolicyArray[index].name = resources[index].name;
          tmtrafficpolicyArray[index].rule = resources[index].rule;
          tmtrafficpolicyArray[index].action = resources[index].action;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) tmtrafficpolicyArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new tmtrafficpolicy() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      tmtrafficpolicy resource,
      string[] args)
    {
      return new tmtrafficpolicy() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        tmtrafficpolicy[] tmtrafficpolicyArray = new tmtrafficpolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          tmtrafficpolicyArray[index] = new tmtrafficpolicy();
          tmtrafficpolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) tmtrafficpolicyArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      tmtrafficpolicy[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        tmtrafficpolicy[] tmtrafficpolicyArray = new tmtrafficpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          tmtrafficpolicyArray[index] = new tmtrafficpolicy();
          tmtrafficpolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) tmtrafficpolicyArray, args);
      }
      return baseResponses;
    }

    public static tmtrafficpolicy[] get(nitro_service service) => (tmtrafficpolicy[]) new tmtrafficpolicy().get_resources(service, (options) null);

    public static tmtrafficpolicy[] get(nitro_service service, options option) => (tmtrafficpolicy[]) new tmtrafficpolicy().get_resources(service, option);

    public static tmtrafficpolicy get(nitro_service service, string name) => (tmtrafficpolicy) new tmtrafficpolicy()
    {
      name = name
    }.get_resource(service);

    public static tmtrafficpolicy[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (tmtrafficpolicy[]) null;
      tmtrafficpolicy[] tmtrafficpolicyArray1 = new tmtrafficpolicy[name.Length];
      tmtrafficpolicy[] tmtrafficpolicyArray2 = new tmtrafficpolicy[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        tmtrafficpolicyArray2[index] = new tmtrafficpolicy();
        tmtrafficpolicyArray2[index].name = name[index];
        tmtrafficpolicyArray1[index] = (tmtrafficpolicy) tmtrafficpolicyArray2[index].get_resource(service);
      }
      return tmtrafficpolicyArray1;
    }

    public static tmtrafficpolicy[] get_filtered(
      nitro_service service,
      string filter)
    {
      tmtrafficpolicy tmtrafficpolicy = new tmtrafficpolicy();
      options option = new options();
      option.set_filter(filter);
      return (tmtrafficpolicy[]) tmtrafficpolicy.getfiltered(service, option);
    }

    public static tmtrafficpolicy[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      tmtrafficpolicy tmtrafficpolicy = new tmtrafficpolicy();
      options option = new options();
      option.set_filter(filter);
      return (tmtrafficpolicy[]) tmtrafficpolicy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      tmtrafficpolicy tmtrafficpolicy = new tmtrafficpolicy();
      options option = new options();
      option.set_count(true);
      tmtrafficpolicy[] resources = (tmtrafficpolicy[]) tmtrafficpolicy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      tmtrafficpolicy tmtrafficpolicy = new tmtrafficpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      tmtrafficpolicy[] tmtrafficpolicyArray = (tmtrafficpolicy[]) tmtrafficpolicy.getfiltered(service, option);
      return tmtrafficpolicyArray != null && tmtrafficpolicyArray.Length > 0 ? tmtrafficpolicyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      tmtrafficpolicy tmtrafficpolicy = new tmtrafficpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      tmtrafficpolicy[] tmtrafficpolicyArray = (tmtrafficpolicy[]) tmtrafficpolicy.getfiltered(service, option);
      return tmtrafficpolicyArray != null && tmtrafficpolicyArray.Length > 0 ? tmtrafficpolicyArray[0].__count.Value : 0U;
    }

    private class tmtrafficpolicy_response : base_response
    {
      public tmtrafficpolicy[] tmtrafficpolicy = (tmtrafficpolicy[]) null;
    }
  }
}
