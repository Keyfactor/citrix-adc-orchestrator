// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.appfw.appfwpolicy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.appfw
{
  public class appfwpolicy : base_resource
  {
    private string nameField = (string) null;
    private string ruleField = (string) null;
    private string profilenameField = (string) null;
    private string commentField = (string) null;
    private string logactionField = (string) null;
    private string newnameField = (string) null;
    private long? hitsField = new long?();
    private long? undefhitsField = new long?();
    private string policytypeField = (string) null;
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

    public string profilename
    {
      get => this.profilenameField;
      set => this.profilenameField = value;
    }

    public string comment
    {
      get => this.commentField;
      set => this.commentField = value;
    }

    public string logaction
    {
      get => this.logactionField;
      set => this.logactionField = value;
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

    public string policytype
    {
      get => this.policytypeField;
      private set => this.policytypeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      appfwpolicy.appfwpolicy_response appfwpolicyResponse = new appfwpolicy.appfwpolicy_response();
      appfwpolicy.appfwpolicy_response resource = (appfwpolicy.appfwpolicy_response) service.get_payload_formatter().string_to_resource(appfwpolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.appfwpolicy;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, appfwpolicy resource) => new appfwpolicy()
    {
      name = resource.name,
      rule = resource.rule,
      profilename = resource.profilename,
      comment = resource.comment,
      logaction = resource.logaction
    }.add_resource(client);

    public static base_responses add(nitro_service client, appfwpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appfwpolicy[] appfwpolicyArray = new appfwpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appfwpolicyArray[index] = new appfwpolicy();
          appfwpolicyArray[index].name = resources[index].name;
          appfwpolicyArray[index].rule = resources[index].rule;
          appfwpolicyArray[index].profilename = resources[index].profilename;
          appfwpolicyArray[index].comment = resources[index].comment;
          appfwpolicyArray[index].logaction = resources[index].logaction;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) appfwpolicyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new appfwpolicy()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, appfwpolicy resource) => new appfwpolicy()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        appfwpolicy[] appfwpolicyArray = new appfwpolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          appfwpolicyArray[index] = new appfwpolicy();
          appfwpolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) appfwpolicyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, appfwpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appfwpolicy[] appfwpolicyArray = new appfwpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appfwpolicyArray[index] = new appfwpolicy();
          appfwpolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) appfwpolicyArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, appfwpolicy resource) => new appfwpolicy()
    {
      name = resource.name,
      rule = resource.rule,
      profilename = resource.profilename,
      comment = resource.comment,
      logaction = resource.logaction
    }.update_resource(client);

    public static base_responses update(nitro_service client, appfwpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appfwpolicy[] appfwpolicyArray = new appfwpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appfwpolicyArray[index] = new appfwpolicy();
          appfwpolicyArray[index].name = resources[index].name;
          appfwpolicyArray[index].rule = resources[index].rule;
          appfwpolicyArray[index].profilename = resources[index].profilename;
          appfwpolicyArray[index].comment = resources[index].comment;
          appfwpolicyArray[index].logaction = resources[index].logaction;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) appfwpolicyArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new appfwpolicy() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      appfwpolicy resource,
      string[] args)
    {
      return new appfwpolicy() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        appfwpolicy[] appfwpolicyArray = new appfwpolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          appfwpolicyArray[index] = new appfwpolicy();
          appfwpolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) appfwpolicyArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      appfwpolicy[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appfwpolicy[] appfwpolicyArray = new appfwpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appfwpolicyArray[index] = new appfwpolicy();
          appfwpolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) appfwpolicyArray, args);
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      appfwpolicy resource,
      string new_name)
    {
      return new appfwpolicy()
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
      return new appfwpolicy()
      {
        name = name,
        newname = new_name
      }.rename_resource(client);
    }

    public static appfwpolicy[] get(nitro_service service) => (appfwpolicy[]) new appfwpolicy().get_resources(service, (options) null);

    public static appfwpolicy[] get(nitro_service service, options option) => (appfwpolicy[]) new appfwpolicy().get_resources(service, option);

    public static appfwpolicy get(nitro_service service, string name) => (appfwpolicy) new appfwpolicy()
    {
      name = name
    }.get_resource(service);

    public static appfwpolicy[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (appfwpolicy[]) null;
      appfwpolicy[] appfwpolicyArray1 = new appfwpolicy[name.Length];
      appfwpolicy[] appfwpolicyArray2 = new appfwpolicy[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        appfwpolicyArray2[index] = new appfwpolicy();
        appfwpolicyArray2[index].name = name[index];
        appfwpolicyArray1[index] = (appfwpolicy) appfwpolicyArray2[index].get_resource(service);
      }
      return appfwpolicyArray1;
    }

    public static appfwpolicy[] get_filtered(nitro_service service, string filter)
    {
      appfwpolicy appfwpolicy = new appfwpolicy();
      options option = new options();
      option.set_filter(filter);
      return (appfwpolicy[]) appfwpolicy.getfiltered(service, option);
    }

    public static appfwpolicy[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      appfwpolicy appfwpolicy = new appfwpolicy();
      options option = new options();
      option.set_filter(filter);
      return (appfwpolicy[]) appfwpolicy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      appfwpolicy appfwpolicy = new appfwpolicy();
      options option = new options();
      option.set_count(true);
      appfwpolicy[] resources = (appfwpolicy[]) appfwpolicy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      appfwpolicy appfwpolicy = new appfwpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appfwpolicy[] appfwpolicyArray = (appfwpolicy[]) appfwpolicy.getfiltered(service, option);
      return appfwpolicyArray != null && appfwpolicyArray.Length > 0 ? appfwpolicyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      appfwpolicy appfwpolicy = new appfwpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appfwpolicy[] appfwpolicyArray = (appfwpolicy[]) appfwpolicy.getfiltered(service, option);
      return appfwpolicyArray != null && appfwpolicyArray.Length > 0 ? appfwpolicyArray[0].__count.Value : 0U;
    }

    private class appfwpolicy_response : base_response
    {
      public appfwpolicy[] appfwpolicy = (appfwpolicy[]) null;
    }

    public static class policytypeEnum
    {
      public const string Classic_Policy = "Classic Policy";
      public const string Advanced_Policy = "Advanced Policy";
    }
  }
}
