// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.appqoe.appqoepolicy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.appqoe
{
  public class appqoepolicy : base_resource
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
      appqoepolicy.appqoepolicy_response appqoepolicyResponse = new appqoepolicy.appqoepolicy_response();
      appqoepolicy.appqoepolicy_response resource = (appqoepolicy.appqoepolicy_response) service.get_payload_formatter().string_to_resource(appqoepolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.appqoepolicy;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, appqoepolicy resource) => new appqoepolicy()
    {
      name = resource.name,
      rule = resource.rule,
      action = resource.action
    }.add_resource(client);

    public static base_responses add(nitro_service client, appqoepolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appqoepolicy[] appqoepolicyArray = new appqoepolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appqoepolicyArray[index] = new appqoepolicy();
          appqoepolicyArray[index].name = resources[index].name;
          appqoepolicyArray[index].rule = resources[index].rule;
          appqoepolicyArray[index].action = resources[index].action;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) appqoepolicyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new appqoepolicy()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, appqoepolicy resource) => new appqoepolicy()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        appqoepolicy[] appqoepolicyArray = new appqoepolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          appqoepolicyArray[index] = new appqoepolicy();
          appqoepolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) appqoepolicyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      appqoepolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appqoepolicy[] appqoepolicyArray = new appqoepolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appqoepolicyArray[index] = new appqoepolicy();
          appqoepolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) appqoepolicyArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, appqoepolicy resource) => new appqoepolicy()
    {
      name = resource.name,
      rule = resource.rule,
      action = resource.action
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      appqoepolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appqoepolicy[] appqoepolicyArray = new appqoepolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appqoepolicyArray[index] = new appqoepolicy();
          appqoepolicyArray[index].name = resources[index].name;
          appqoepolicyArray[index].rule = resources[index].rule;
          appqoepolicyArray[index].action = resources[index].action;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) appqoepolicyArray);
      }
      return baseResponses;
    }

    public static appqoepolicy[] get(nitro_service service) => (appqoepolicy[]) new appqoepolicy().get_resources(service, (options) null);

    public static appqoepolicy[] get(nitro_service service, options option) => (appqoepolicy[]) new appqoepolicy().get_resources(service, option);

    public static appqoepolicy get(nitro_service service, string name) => (appqoepolicy) new appqoepolicy()
    {
      name = name
    }.get_resource(service);

    public static appqoepolicy[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (appqoepolicy[]) null;
      appqoepolicy[] appqoepolicyArray1 = new appqoepolicy[name.Length];
      appqoepolicy[] appqoepolicyArray2 = new appqoepolicy[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        appqoepolicyArray2[index] = new appqoepolicy();
        appqoepolicyArray2[index].name = name[index];
        appqoepolicyArray1[index] = (appqoepolicy) appqoepolicyArray2[index].get_resource(service);
      }
      return appqoepolicyArray1;
    }

    public static appqoepolicy[] get_filtered(nitro_service service, string filter)
    {
      appqoepolicy appqoepolicy = new appqoepolicy();
      options option = new options();
      option.set_filter(filter);
      return (appqoepolicy[]) appqoepolicy.getfiltered(service, option);
    }

    public static appqoepolicy[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      appqoepolicy appqoepolicy = new appqoepolicy();
      options option = new options();
      option.set_filter(filter);
      return (appqoepolicy[]) appqoepolicy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      appqoepolicy appqoepolicy = new appqoepolicy();
      options option = new options();
      option.set_count(true);
      appqoepolicy[] resources = (appqoepolicy[]) appqoepolicy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      appqoepolicy appqoepolicy = new appqoepolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appqoepolicy[] appqoepolicyArray = (appqoepolicy[]) appqoepolicy.getfiltered(service, option);
      return appqoepolicyArray != null && appqoepolicyArray.Length > 0 ? appqoepolicyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      appqoepolicy appqoepolicy = new appqoepolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appqoepolicy[] appqoepolicyArray = (appqoepolicy[]) appqoepolicy.getfiltered(service, option);
      return appqoepolicyArray != null && appqoepolicyArray.Length > 0 ? appqoepolicyArray[0].__count.Value : 0U;
    }

    private class appqoepolicy_response : base_response
    {
      public appqoepolicy[] appqoepolicy = (appqoepolicy[]) null;
    }
  }
}
