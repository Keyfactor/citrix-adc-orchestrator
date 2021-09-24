// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.appflow.appflowpolicy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.appflow
{
  public class appflowpolicy : base_resource
  {
    private string nameField = (string) null;
    private string ruleField = (string) null;
    private string actionField = (string) null;
    private string commentField = (string) null;
    private string newnameField = (string) null;
    private long? hitsField = new long?();
    private long? undefhitsField = new long?();
    private string descriptionField = (string) null;
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

    public string comment
    {
      get => this.commentField;
      set => this.commentField = value;
    }

    public string newname
    {
      get => this.newnameField;
      set => this.newnameField = value;
    }

    public long? hits
    {
      get => this.hitsField;
      private set => this.hitsField = value;
    }

    public long? undefhits
    {
      get => this.undefhitsField;
      private set => this.undefhitsField = value;
    }

    public string description
    {
      get => this.descriptionField;
      private set => this.descriptionField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      appflowpolicy.appflowpolicy_response appflowpolicyResponse = new appflowpolicy.appflowpolicy_response();
      appflowpolicy.appflowpolicy_response resource = (appflowpolicy.appflowpolicy_response) service.get_payload_formatter().string_to_resource(appflowpolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.appflowpolicy;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, appflowpolicy resource) => new appflowpolicy()
    {
      name = resource.name,
      rule = resource.rule,
      action = resource.action,
      comment = resource.comment
    }.add_resource(client);

    public static base_responses add(nitro_service client, appflowpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appflowpolicy[] appflowpolicyArray = new appflowpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appflowpolicyArray[index] = new appflowpolicy();
          appflowpolicyArray[index].name = resources[index].name;
          appflowpolicyArray[index].rule = resources[index].rule;
          appflowpolicyArray[index].action = resources[index].action;
          appflowpolicyArray[index].comment = resources[index].comment;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) appflowpolicyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new appflowpolicy()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, appflowpolicy resource) => new appflowpolicy()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        appflowpolicy[] appflowpolicyArray = new appflowpolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          appflowpolicyArray[index] = new appflowpolicy();
          appflowpolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) appflowpolicyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      appflowpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appflowpolicy[] appflowpolicyArray = new appflowpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appflowpolicyArray[index] = new appflowpolicy();
          appflowpolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) appflowpolicyArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, appflowpolicy resource) => new appflowpolicy()
    {
      name = resource.name,
      rule = resource.rule,
      action = resource.action,
      comment = resource.comment
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      appflowpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appflowpolicy[] appflowpolicyArray = new appflowpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appflowpolicyArray[index] = new appflowpolicy();
          appflowpolicyArray[index].name = resources[index].name;
          appflowpolicyArray[index].rule = resources[index].rule;
          appflowpolicyArray[index].action = resources[index].action;
          appflowpolicyArray[index].comment = resources[index].comment;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) appflowpolicyArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new appflowpolicy() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      appflowpolicy resource,
      string[] args)
    {
      return new appflowpolicy() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        appflowpolicy[] appflowpolicyArray = new appflowpolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          appflowpolicyArray[index] = new appflowpolicy();
          appflowpolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) appflowpolicyArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      appflowpolicy[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appflowpolicy[] appflowpolicyArray = new appflowpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appflowpolicyArray[index] = new appflowpolicy();
          appflowpolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) appflowpolicyArray, args);
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      appflowpolicy resource,
      string new_name)
    {
      return new appflowpolicy()
      {
        name = resource.name,
        newname = new_name
      }.rename_resource(client);
    }

    public static base_response rename(
      nitro_service client,
      string name,
      string new_name)
    {
      return new appflowpolicy()
      {
        name = name,
        newname = new_name
      }.rename_resource(client);
    }

    public static appflowpolicy[] get(nitro_service service) => (appflowpolicy[]) new appflowpolicy().get_resources(service, (options) null);

    public static appflowpolicy[] get(nitro_service service, options option) => (appflowpolicy[]) new appflowpolicy().get_resources(service, option);

    public static appflowpolicy get(nitro_service service, string name) => (appflowpolicy) new appflowpolicy()
    {
      name = name
    }.get_resource(service);

    public static appflowpolicy[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (appflowpolicy[]) null;
      appflowpolicy[] appflowpolicyArray1 = new appflowpolicy[name.Length];
      appflowpolicy[] appflowpolicyArray2 = new appflowpolicy[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        appflowpolicyArray2[index] = new appflowpolicy();
        appflowpolicyArray2[index].name = name[index];
        appflowpolicyArray1[index] = (appflowpolicy) appflowpolicyArray2[index].get_resource(service);
      }
      return appflowpolicyArray1;
    }

    public static appflowpolicy[] get_filtered(nitro_service service, string filter)
    {
      appflowpolicy appflowpolicy = new appflowpolicy();
      options option = new options();
      option.set_filter(filter);
      return (appflowpolicy[]) appflowpolicy.getfiltered(service, option);
    }

    public static appflowpolicy[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      appflowpolicy appflowpolicy = new appflowpolicy();
      options option = new options();
      option.set_filter(filter);
      return (appflowpolicy[]) appflowpolicy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      appflowpolicy appflowpolicy = new appflowpolicy();
      options option = new options();
      option.set_count(true);
      appflowpolicy[] resources = (appflowpolicy[]) appflowpolicy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      appflowpolicy appflowpolicy = new appflowpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appflowpolicy[] appflowpolicyArray = (appflowpolicy[]) appflowpolicy.getfiltered(service, option);
      return appflowpolicyArray != null && appflowpolicyArray.Length > 0 ? appflowpolicyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      appflowpolicy appflowpolicy = new appflowpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appflowpolicy[] appflowpolicyArray = (appflowpolicy[]) appflowpolicy.getfiltered(service, option);
      return appflowpolicyArray != null && appflowpolicyArray.Length > 0 ? appflowpolicyArray[0].__count.Value : 0U;
    }

    private class appflowpolicy_response : base_response
    {
      public appflowpolicy[] appflowpolicy = (appflowpolicy[]) null;
    }
  }
}
