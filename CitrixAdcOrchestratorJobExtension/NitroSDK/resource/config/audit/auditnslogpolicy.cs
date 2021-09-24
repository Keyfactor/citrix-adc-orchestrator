// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.audit.auditnslogpolicy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.audit
{
  public class auditnslogpolicy : base_resource
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
      auditnslogpolicy.auditnslogpolicy_response auditnslogpolicyResponse = new auditnslogpolicy.auditnslogpolicy_response();
      auditnslogpolicy.auditnslogpolicy_response resource = (auditnslogpolicy.auditnslogpolicy_response) service.get_payload_formatter().string_to_resource(auditnslogpolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.auditnslogpolicy;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, auditnslogpolicy resource) => new auditnslogpolicy()
    {
      name = resource.name,
      rule = resource.rule,
      action = resource.action
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      auditnslogpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        auditnslogpolicy[] auditnslogpolicyArray = new auditnslogpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          auditnslogpolicyArray[index] = new auditnslogpolicy();
          auditnslogpolicyArray[index].name = resources[index].name;
          auditnslogpolicyArray[index].rule = resources[index].rule;
          auditnslogpolicyArray[index].action = resources[index].action;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) auditnslogpolicyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new auditnslogpolicy()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, auditnslogpolicy resource) => new auditnslogpolicy()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        auditnslogpolicy[] auditnslogpolicyArray = new auditnslogpolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          auditnslogpolicyArray[index] = new auditnslogpolicy();
          auditnslogpolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) auditnslogpolicyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      auditnslogpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        auditnslogpolicy[] auditnslogpolicyArray = new auditnslogpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          auditnslogpolicyArray[index] = new auditnslogpolicy();
          auditnslogpolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) auditnslogpolicyArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, auditnslogpolicy resource) => new auditnslogpolicy()
    {
      name = resource.name,
      rule = resource.rule,
      action = resource.action
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      auditnslogpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        auditnslogpolicy[] auditnslogpolicyArray = new auditnslogpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          auditnslogpolicyArray[index] = new auditnslogpolicy();
          auditnslogpolicyArray[index].name = resources[index].name;
          auditnslogpolicyArray[index].rule = resources[index].rule;
          auditnslogpolicyArray[index].action = resources[index].action;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) auditnslogpolicyArray);
      }
      return baseResponses;
    }

    public static auditnslogpolicy[] get(nitro_service service) => (auditnslogpolicy[]) new auditnslogpolicy().get_resources(service, (options) null);

    public static auditnslogpolicy[] get(nitro_service service, options option) => (auditnslogpolicy[]) new auditnslogpolicy().get_resources(service, option);

    public static auditnslogpolicy get(nitro_service service, string name) => (auditnslogpolicy) new auditnslogpolicy()
    {
      name = name
    }.get_resource(service);

    public static auditnslogpolicy[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (auditnslogpolicy[]) null;
      auditnslogpolicy[] auditnslogpolicyArray1 = new auditnslogpolicy[name.Length];
      auditnslogpolicy[] auditnslogpolicyArray2 = new auditnslogpolicy[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        auditnslogpolicyArray2[index] = new auditnslogpolicy();
        auditnslogpolicyArray2[index].name = name[index];
        auditnslogpolicyArray1[index] = (auditnslogpolicy) auditnslogpolicyArray2[index].get_resource(service);
      }
      return auditnslogpolicyArray1;
    }

    public static auditnslogpolicy[] get_filtered(
      nitro_service service,
      string filter)
    {
      auditnslogpolicy auditnslogpolicy = new auditnslogpolicy();
      options option = new options();
      option.set_filter(filter);
      return (auditnslogpolicy[]) auditnslogpolicy.getfiltered(service, option);
    }

    public static auditnslogpolicy[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      auditnslogpolicy auditnslogpolicy = new auditnslogpolicy();
      options option = new options();
      option.set_filter(filter);
      return (auditnslogpolicy[]) auditnslogpolicy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      auditnslogpolicy auditnslogpolicy = new auditnslogpolicy();
      options option = new options();
      option.set_count(true);
      auditnslogpolicy[] resources = (auditnslogpolicy[]) auditnslogpolicy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      auditnslogpolicy auditnslogpolicy = new auditnslogpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      auditnslogpolicy[] auditnslogpolicyArray = (auditnslogpolicy[]) auditnslogpolicy.getfiltered(service, option);
      return auditnslogpolicyArray != null && auditnslogpolicyArray.Length > 0 ? auditnslogpolicyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      auditnslogpolicy auditnslogpolicy = new auditnslogpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      auditnslogpolicy[] auditnslogpolicyArray = (auditnslogpolicy[]) auditnslogpolicy.getfiltered(service, option);
      return auditnslogpolicyArray != null && auditnslogpolicyArray.Length > 0 ? auditnslogpolicyArray[0].__count.Value : 0U;
    }

    private class auditnslogpolicy_response : base_response
    {
      public auditnslogpolicy[] auditnslogpolicy = (auditnslogpolicy[]) null;
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
