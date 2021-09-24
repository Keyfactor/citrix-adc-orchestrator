// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.vpn.vpnsessionpolicy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.vpn
{
  public class vpnsessionpolicy : base_resource
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
      vpnsessionpolicy.vpnsessionpolicy_response vpnsessionpolicyResponse = new vpnsessionpolicy.vpnsessionpolicy_response();
      vpnsessionpolicy.vpnsessionpolicy_response resource = (vpnsessionpolicy.vpnsessionpolicy_response) service.get_payload_formatter().string_to_resource(vpnsessionpolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vpnsessionpolicy;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, vpnsessionpolicy resource) => new vpnsessionpolicy()
    {
      name = resource.name,
      rule = resource.rule,
      action = resource.action
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      vpnsessionpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnsessionpolicy[] vpnsessionpolicyArray = new vpnsessionpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnsessionpolicyArray[index] = new vpnsessionpolicy();
          vpnsessionpolicyArray[index].name = resources[index].name;
          vpnsessionpolicyArray[index].rule = resources[index].rule;
          vpnsessionpolicyArray[index].action = resources[index].action;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) vpnsessionpolicyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new vpnsessionpolicy()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, vpnsessionpolicy resource) => new vpnsessionpolicy()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        vpnsessionpolicy[] vpnsessionpolicyArray = new vpnsessionpolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          vpnsessionpolicyArray[index] = new vpnsessionpolicy();
          vpnsessionpolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vpnsessionpolicyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      vpnsessionpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnsessionpolicy[] vpnsessionpolicyArray = new vpnsessionpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnsessionpolicyArray[index] = new vpnsessionpolicy();
          vpnsessionpolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vpnsessionpolicyArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, vpnsessionpolicy resource) => new vpnsessionpolicy()
    {
      name = resource.name,
      rule = resource.rule,
      action = resource.action
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      vpnsessionpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnsessionpolicy[] vpnsessionpolicyArray = new vpnsessionpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnsessionpolicyArray[index] = new vpnsessionpolicy();
          vpnsessionpolicyArray[index].name = resources[index].name;
          vpnsessionpolicyArray[index].rule = resources[index].rule;
          vpnsessionpolicyArray[index].action = resources[index].action;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) vpnsessionpolicyArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new vpnsessionpolicy() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      vpnsessionpolicy resource,
      string[] args)
    {
      return new vpnsessionpolicy() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        vpnsessionpolicy[] vpnsessionpolicyArray = new vpnsessionpolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          vpnsessionpolicyArray[index] = new vpnsessionpolicy();
          vpnsessionpolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) vpnsessionpolicyArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      vpnsessionpolicy[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnsessionpolicy[] vpnsessionpolicyArray = new vpnsessionpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnsessionpolicyArray[index] = new vpnsessionpolicy();
          vpnsessionpolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) vpnsessionpolicyArray, args);
      }
      return baseResponses;
    }

    public static vpnsessionpolicy[] get(nitro_service service) => (vpnsessionpolicy[]) new vpnsessionpolicy().get_resources(service, (options) null);

    public static vpnsessionpolicy[] get(nitro_service service, options option) => (vpnsessionpolicy[]) new vpnsessionpolicy().get_resources(service, option);

    public static vpnsessionpolicy get(nitro_service service, string name) => (vpnsessionpolicy) new vpnsessionpolicy()
    {
      name = name
    }.get_resource(service);

    public static vpnsessionpolicy[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (vpnsessionpolicy[]) null;
      vpnsessionpolicy[] vpnsessionpolicyArray1 = new vpnsessionpolicy[name.Length];
      vpnsessionpolicy[] vpnsessionpolicyArray2 = new vpnsessionpolicy[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        vpnsessionpolicyArray2[index] = new vpnsessionpolicy();
        vpnsessionpolicyArray2[index].name = name[index];
        vpnsessionpolicyArray1[index] = (vpnsessionpolicy) vpnsessionpolicyArray2[index].get_resource(service);
      }
      return vpnsessionpolicyArray1;
    }

    public static vpnsessionpolicy[] get_filtered(
      nitro_service service,
      string filter)
    {
      vpnsessionpolicy vpnsessionpolicy = new vpnsessionpolicy();
      options option = new options();
      option.set_filter(filter);
      return (vpnsessionpolicy[]) vpnsessionpolicy.getfiltered(service, option);
    }

    public static vpnsessionpolicy[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      vpnsessionpolicy vpnsessionpolicy = new vpnsessionpolicy();
      options option = new options();
      option.set_filter(filter);
      return (vpnsessionpolicy[]) vpnsessionpolicy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      vpnsessionpolicy vpnsessionpolicy = new vpnsessionpolicy();
      options option = new options();
      option.set_count(true);
      vpnsessionpolicy[] resources = (vpnsessionpolicy[]) vpnsessionpolicy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      vpnsessionpolicy vpnsessionpolicy = new vpnsessionpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnsessionpolicy[] vpnsessionpolicyArray = (vpnsessionpolicy[]) vpnsessionpolicy.getfiltered(service, option);
      return vpnsessionpolicyArray != null && vpnsessionpolicyArray.Length > 0 ? vpnsessionpolicyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      vpnsessionpolicy vpnsessionpolicy = new vpnsessionpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnsessionpolicy[] vpnsessionpolicyArray = (vpnsessionpolicy[]) vpnsessionpolicy.getfiltered(service, option);
      return vpnsessionpolicyArray != null && vpnsessionpolicyArray.Length > 0 ? vpnsessionpolicyArray[0].__count.Value : 0U;
    }

    private class vpnsessionpolicy_response : base_response
    {
      public vpnsessionpolicy[] vpnsessionpolicy = (vpnsessionpolicy[]) null;
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
