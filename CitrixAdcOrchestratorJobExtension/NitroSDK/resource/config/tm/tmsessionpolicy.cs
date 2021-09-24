// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.tm.tmsessionpolicy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.tm
{
  public class tmsessionpolicy : base_resource
  {
    private string nameField = (string) null;
    private string ruleField = (string) null;
    private string actionField = (string) null;
    private string[] builtinField = (string[]) null;
    private string expressiontypeField = (string) null;
    private long? hitsField = new long?();
    private string gotopriorityexpressionField = (string) null;
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

    public string[] builtin
    {
      get => this.builtinField;
      private set => this.builtinField = value;
    }

    public string expressiontype
    {
      get => this.expressiontypeField;
      private set => this.expressiontypeField = value;
    }

    public long? hits
    {
      get => this.hitsField;
      private set => this.hitsField = value;
    }

    public string gotopriorityexpression
    {
      get => this.gotopriorityexpressionField;
      private set => this.gotopriorityexpressionField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      tmsessionpolicy.tmsessionpolicy_response tmsessionpolicyResponse = new tmsessionpolicy.tmsessionpolicy_response();
      tmsessionpolicy.tmsessionpolicy_response resource = (tmsessionpolicy.tmsessionpolicy_response) service.get_payload_formatter().string_to_resource(tmsessionpolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.tmsessionpolicy;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, tmsessionpolicy resource) => new tmsessionpolicy()
    {
      name = resource.name,
      rule = resource.rule,
      action = resource.action
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      tmsessionpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        tmsessionpolicy[] tmsessionpolicyArray = new tmsessionpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          tmsessionpolicyArray[index] = new tmsessionpolicy();
          tmsessionpolicyArray[index].name = resources[index].name;
          tmsessionpolicyArray[index].rule = resources[index].rule;
          tmsessionpolicyArray[index].action = resources[index].action;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) tmsessionpolicyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new tmsessionpolicy()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, tmsessionpolicy resource) => new tmsessionpolicy()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        tmsessionpolicy[] tmsessionpolicyArray = new tmsessionpolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          tmsessionpolicyArray[index] = new tmsessionpolicy();
          tmsessionpolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) tmsessionpolicyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      tmsessionpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        tmsessionpolicy[] tmsessionpolicyArray = new tmsessionpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          tmsessionpolicyArray[index] = new tmsessionpolicy();
          tmsessionpolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) tmsessionpolicyArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, tmsessionpolicy resource) => new tmsessionpolicy()
    {
      name = resource.name,
      rule = resource.rule,
      action = resource.action
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      tmsessionpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        tmsessionpolicy[] tmsessionpolicyArray = new tmsessionpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          tmsessionpolicyArray[index] = new tmsessionpolicy();
          tmsessionpolicyArray[index].name = resources[index].name;
          tmsessionpolicyArray[index].rule = resources[index].rule;
          tmsessionpolicyArray[index].action = resources[index].action;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) tmsessionpolicyArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new tmsessionpolicy() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      tmsessionpolicy resource,
      string[] args)
    {
      return new tmsessionpolicy() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        tmsessionpolicy[] tmsessionpolicyArray = new tmsessionpolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          tmsessionpolicyArray[index] = new tmsessionpolicy();
          tmsessionpolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) tmsessionpolicyArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      tmsessionpolicy[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        tmsessionpolicy[] tmsessionpolicyArray = new tmsessionpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          tmsessionpolicyArray[index] = new tmsessionpolicy();
          tmsessionpolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) tmsessionpolicyArray, args);
      }
      return baseResponses;
    }

    public static tmsessionpolicy[] get(nitro_service service) => (tmsessionpolicy[]) new tmsessionpolicy().get_resources(service, (options) null);

    public static tmsessionpolicy[] get(nitro_service service, options option) => (tmsessionpolicy[]) new tmsessionpolicy().get_resources(service, option);

    public static tmsessionpolicy get(nitro_service service, string name) => (tmsessionpolicy) new tmsessionpolicy()
    {
      name = name
    }.get_resource(service);

    public static tmsessionpolicy[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (tmsessionpolicy[]) null;
      tmsessionpolicy[] tmsessionpolicyArray1 = new tmsessionpolicy[name.Length];
      tmsessionpolicy[] tmsessionpolicyArray2 = new tmsessionpolicy[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        tmsessionpolicyArray2[index] = new tmsessionpolicy();
        tmsessionpolicyArray2[index].name = name[index];
        tmsessionpolicyArray1[index] = (tmsessionpolicy) tmsessionpolicyArray2[index].get_resource(service);
      }
      return tmsessionpolicyArray1;
    }

    public static tmsessionpolicy[] get_filtered(
      nitro_service service,
      string filter)
    {
      tmsessionpolicy tmsessionpolicy = new tmsessionpolicy();
      options option = new options();
      option.set_filter(filter);
      return (tmsessionpolicy[]) tmsessionpolicy.getfiltered(service, option);
    }

    public static tmsessionpolicy[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      tmsessionpolicy tmsessionpolicy = new tmsessionpolicy();
      options option = new options();
      option.set_filter(filter);
      return (tmsessionpolicy[]) tmsessionpolicy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      tmsessionpolicy tmsessionpolicy = new tmsessionpolicy();
      options option = new options();
      option.set_count(true);
      tmsessionpolicy[] resources = (tmsessionpolicy[]) tmsessionpolicy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      tmsessionpolicy tmsessionpolicy = new tmsessionpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      tmsessionpolicy[] tmsessionpolicyArray = (tmsessionpolicy[]) tmsessionpolicy.getfiltered(service, option);
      return tmsessionpolicyArray != null && tmsessionpolicyArray.Length > 0 ? tmsessionpolicyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      tmsessionpolicy tmsessionpolicy = new tmsessionpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      tmsessionpolicy[] tmsessionpolicyArray = (tmsessionpolicy[]) tmsessionpolicy.getfiltered(service, option);
      return tmsessionpolicyArray != null && tmsessionpolicyArray.Length > 0 ? tmsessionpolicyArray[0].__count.Value : 0U;
    }

    private class tmsessionpolicy_response : base_response
    {
      public tmsessionpolicy[] tmsessionpolicy = (tmsessionpolicy[]) null;
    }

    public static class expressiontypeEnum
    {
      public const string Classic_Policy = "Classic Policy";
      public const string Advanced_Policy = "Advanced Policy";
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }
  }
}
