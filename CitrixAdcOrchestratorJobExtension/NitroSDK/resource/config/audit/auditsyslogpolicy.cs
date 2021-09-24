// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.audit.auditsyslogpolicy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.audit
{
  public class auditsyslogpolicy : base_resource
  {
    private string nameField = (string) null;
    private string ruleField = (string) null;
    private string actionField = (string) null;
    private string[] builtinField = (string[]) null;
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

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      auditsyslogpolicy.auditsyslogpolicy_response auditsyslogpolicyResponse = new auditsyslogpolicy.auditsyslogpolicy_response();
      auditsyslogpolicy.auditsyslogpolicy_response resource = (auditsyslogpolicy.auditsyslogpolicy_response) service.get_payload_formatter().string_to_resource(auditsyslogpolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.auditsyslogpolicy;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, auditsyslogpolicy resource) => new auditsyslogpolicy()
    {
      name = resource.name,
      rule = resource.rule,
      action = resource.action
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      auditsyslogpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        auditsyslogpolicy[] auditsyslogpolicyArray = new auditsyslogpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          auditsyslogpolicyArray[index] = new auditsyslogpolicy();
          auditsyslogpolicyArray[index].name = resources[index].name;
          auditsyslogpolicyArray[index].rule = resources[index].rule;
          auditsyslogpolicyArray[index].action = resources[index].action;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) auditsyslogpolicyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new auditsyslogpolicy()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      auditsyslogpolicy resource)
    {
      return new auditsyslogpolicy()
      {
        name = resource.name
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        auditsyslogpolicy[] auditsyslogpolicyArray = new auditsyslogpolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          auditsyslogpolicyArray[index] = new auditsyslogpolicy();
          auditsyslogpolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) auditsyslogpolicyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      auditsyslogpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        auditsyslogpolicy[] auditsyslogpolicyArray = new auditsyslogpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          auditsyslogpolicyArray[index] = new auditsyslogpolicy();
          auditsyslogpolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) auditsyslogpolicyArray);
      }
      return baseResponses;
    }

    public static base_response update(
      nitro_service client,
      auditsyslogpolicy resource)
    {
      return new auditsyslogpolicy()
      {
        name = resource.name,
        rule = resource.rule,
        action = resource.action
      }.update_resource(client);
    }

    public static base_responses update(
      nitro_service client,
      auditsyslogpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        auditsyslogpolicy[] auditsyslogpolicyArray = new auditsyslogpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          auditsyslogpolicyArray[index] = new auditsyslogpolicy();
          auditsyslogpolicyArray[index].name = resources[index].name;
          auditsyslogpolicyArray[index].rule = resources[index].rule;
          auditsyslogpolicyArray[index].action = resources[index].action;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) auditsyslogpolicyArray);
      }
      return baseResponses;
    }

    public static auditsyslogpolicy[] get(nitro_service service) => (auditsyslogpolicy[]) new auditsyslogpolicy().get_resources(service, (options) null);

    public static auditsyslogpolicy[] get(nitro_service service, options option) => (auditsyslogpolicy[]) new auditsyslogpolicy().get_resources(service, option);

    public static auditsyslogpolicy get(nitro_service service, string name) => (auditsyslogpolicy) new auditsyslogpolicy()
    {
      name = name
    }.get_resource(service);

    public static auditsyslogpolicy[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (auditsyslogpolicy[]) null;
      auditsyslogpolicy[] auditsyslogpolicyArray1 = new auditsyslogpolicy[name.Length];
      auditsyslogpolicy[] auditsyslogpolicyArray2 = new auditsyslogpolicy[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        auditsyslogpolicyArray2[index] = new auditsyslogpolicy();
        auditsyslogpolicyArray2[index].name = name[index];
        auditsyslogpolicyArray1[index] = (auditsyslogpolicy) auditsyslogpolicyArray2[index].get_resource(service);
      }
      return auditsyslogpolicyArray1;
    }

    public static auditsyslogpolicy[] get_filtered(
      nitro_service service,
      string filter)
    {
      auditsyslogpolicy auditsyslogpolicy = new auditsyslogpolicy();
      options option = new options();
      option.set_filter(filter);
      return (auditsyslogpolicy[]) auditsyslogpolicy.getfiltered(service, option);
    }

    public static auditsyslogpolicy[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      auditsyslogpolicy auditsyslogpolicy = new auditsyslogpolicy();
      options option = new options();
      option.set_filter(filter);
      return (auditsyslogpolicy[]) auditsyslogpolicy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      auditsyslogpolicy auditsyslogpolicy = new auditsyslogpolicy();
      options option = new options();
      option.set_count(true);
      auditsyslogpolicy[] resources = (auditsyslogpolicy[]) auditsyslogpolicy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      auditsyslogpolicy auditsyslogpolicy = new auditsyslogpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      auditsyslogpolicy[] auditsyslogpolicyArray = (auditsyslogpolicy[]) auditsyslogpolicy.getfiltered(service, option);
      return auditsyslogpolicyArray != null && auditsyslogpolicyArray.Length > 0 ? auditsyslogpolicyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      auditsyslogpolicy auditsyslogpolicy = new auditsyslogpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      auditsyslogpolicy[] auditsyslogpolicyArray = (auditsyslogpolicy[]) auditsyslogpolicy.getfiltered(service, option);
      return auditsyslogpolicyArray != null && auditsyslogpolicyArray.Length > 0 ? auditsyslogpolicyArray[0].__count.Value : 0U;
    }

    private class auditsyslogpolicy_response : base_response
    {
      public auditsyslogpolicy[] auditsyslogpolicy = (auditsyslogpolicy[]) null;
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
