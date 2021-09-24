// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.tunnel.tunneltrafficpolicy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.tunnel
{
  public class tunneltrafficpolicy : base_resource
  {
    private string nameField = (string) null;
    private string ruleField = (string) null;
    private string actionField = (string) null;
    private long? hitsField = new long?();
    private long? txbytesField = new long?();
    private long? rxbytesField = new long?();
    private long? clientttlbField = new long?();
    private long? clienttransactionsField = new long?();
    private long? serverttlbField = new long?();
    private long? servertransactionsField = new long?();
    private bool? isdefaultField = new bool?();
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

    public long? hits
    {
      get => this.hitsField;
      private set => this.hitsField = value;
    }

    public long? txbytes
    {
      get => this.txbytesField;
      private set => this.txbytesField = value;
    }

    public long? rxbytes
    {
      get => this.rxbytesField;
      private set => this.rxbytesField = value;
    }

    public long? clientttlb
    {
      get => this.clientttlbField;
      private set => this.clientttlbField = value;
    }

    public long? clienttransactions
    {
      get => this.clienttransactionsField;
      private set => this.clienttransactionsField = value;
    }

    public long? serverttlb
    {
      get => this.serverttlbField;
      private set => this.serverttlbField = value;
    }

    public long? servertransactions
    {
      get => this.servertransactionsField;
      private set => this.servertransactionsField = value;
    }

    public bool? isdefault
    {
      get => this.isdefaultField;
      private set => this.isdefaultField = value;
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
      tunneltrafficpolicy.tunneltrafficpolicy_response tunneltrafficpolicyResponse = new tunneltrafficpolicy.tunneltrafficpolicy_response();
      tunneltrafficpolicy.tunneltrafficpolicy_response resource = (tunneltrafficpolicy.tunneltrafficpolicy_response) service.get_payload_formatter().string_to_resource(tunneltrafficpolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.tunneltrafficpolicy;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, tunneltrafficpolicy resource) => new tunneltrafficpolicy()
    {
      name = resource.name,
      rule = resource.rule,
      action = resource.action
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      tunneltrafficpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        tunneltrafficpolicy[] tunneltrafficpolicyArray = new tunneltrafficpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          tunneltrafficpolicyArray[index] = new tunneltrafficpolicy();
          tunneltrafficpolicyArray[index].name = resources[index].name;
          tunneltrafficpolicyArray[index].rule = resources[index].rule;
          tunneltrafficpolicyArray[index].action = resources[index].action;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) tunneltrafficpolicyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new tunneltrafficpolicy()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      tunneltrafficpolicy resource)
    {
      return new tunneltrafficpolicy()
      {
        name = resource.name
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        tunneltrafficpolicy[] tunneltrafficpolicyArray = new tunneltrafficpolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          tunneltrafficpolicyArray[index] = new tunneltrafficpolicy();
          tunneltrafficpolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) tunneltrafficpolicyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      tunneltrafficpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        tunneltrafficpolicy[] tunneltrafficpolicyArray = new tunneltrafficpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          tunneltrafficpolicyArray[index] = new tunneltrafficpolicy();
          tunneltrafficpolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) tunneltrafficpolicyArray);
      }
      return baseResponses;
    }

    public static base_response update(
      nitro_service client,
      tunneltrafficpolicy resource)
    {
      return new tunneltrafficpolicy()
      {
        name = resource.name,
        rule = resource.rule,
        action = resource.action
      }.update_resource(client);
    }

    public static base_responses update(
      nitro_service client,
      tunneltrafficpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        tunneltrafficpolicy[] tunneltrafficpolicyArray = new tunneltrafficpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          tunneltrafficpolicyArray[index] = new tunneltrafficpolicy();
          tunneltrafficpolicyArray[index].name = resources[index].name;
          tunneltrafficpolicyArray[index].rule = resources[index].rule;
          tunneltrafficpolicyArray[index].action = resources[index].action;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) tunneltrafficpolicyArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new tunneltrafficpolicy() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      tunneltrafficpolicy resource,
      string[] args)
    {
      return new tunneltrafficpolicy()
      {
        name = resource.name
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        tunneltrafficpolicy[] tunneltrafficpolicyArray = new tunneltrafficpolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          tunneltrafficpolicyArray[index] = new tunneltrafficpolicy();
          tunneltrafficpolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) tunneltrafficpolicyArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      tunneltrafficpolicy[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        tunneltrafficpolicy[] tunneltrafficpolicyArray = new tunneltrafficpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          tunneltrafficpolicyArray[index] = new tunneltrafficpolicy();
          tunneltrafficpolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) tunneltrafficpolicyArray, args);
      }
      return baseResponses;
    }

    public static tunneltrafficpolicy[] get(nitro_service service) => (tunneltrafficpolicy[]) new tunneltrafficpolicy().get_resources(service, (options) null);

    public static tunneltrafficpolicy[] get(
      nitro_service service,
      options option)
    {
      return (tunneltrafficpolicy[]) new tunneltrafficpolicy().get_resources(service, option);
    }

    public static tunneltrafficpolicy get(nitro_service service, string name) => (tunneltrafficpolicy) new tunneltrafficpolicy()
    {
      name = name
    }.get_resource(service);

    public static tunneltrafficpolicy[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (tunneltrafficpolicy[]) null;
      tunneltrafficpolicy[] tunneltrafficpolicyArray1 = new tunneltrafficpolicy[name.Length];
      tunneltrafficpolicy[] tunneltrafficpolicyArray2 = new tunneltrafficpolicy[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        tunneltrafficpolicyArray2[index] = new tunneltrafficpolicy();
        tunneltrafficpolicyArray2[index].name = name[index];
        tunneltrafficpolicyArray1[index] = (tunneltrafficpolicy) tunneltrafficpolicyArray2[index].get_resource(service);
      }
      return tunneltrafficpolicyArray1;
    }

    public static tunneltrafficpolicy[] get_filtered(
      nitro_service service,
      string filter)
    {
      tunneltrafficpolicy tunneltrafficpolicy = new tunneltrafficpolicy();
      options option = new options();
      option.set_filter(filter);
      return (tunneltrafficpolicy[]) tunneltrafficpolicy.getfiltered(service, option);
    }

    public static tunneltrafficpolicy[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      tunneltrafficpolicy tunneltrafficpolicy = new tunneltrafficpolicy();
      options option = new options();
      option.set_filter(filter);
      return (tunneltrafficpolicy[]) tunneltrafficpolicy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      tunneltrafficpolicy tunneltrafficpolicy = new tunneltrafficpolicy();
      options option = new options();
      option.set_count(true);
      tunneltrafficpolicy[] resources = (tunneltrafficpolicy[]) tunneltrafficpolicy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      tunneltrafficpolicy tunneltrafficpolicy = new tunneltrafficpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      tunneltrafficpolicy[] tunneltrafficpolicyArray = (tunneltrafficpolicy[]) tunneltrafficpolicy.getfiltered(service, option);
      return tunneltrafficpolicyArray != null && tunneltrafficpolicyArray.Length > 0 ? tunneltrafficpolicyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      tunneltrafficpolicy tunneltrafficpolicy = new tunneltrafficpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      tunneltrafficpolicy[] tunneltrafficpolicyArray = (tunneltrafficpolicy[]) tunneltrafficpolicy.getfiltered(service, option);
      return tunneltrafficpolicyArray != null && tunneltrafficpolicyArray.Length > 0 ? tunneltrafficpolicyArray[0].__count.Value : 0U;
    }

    private class tunneltrafficpolicy_response : base_response
    {
      public tunneltrafficpolicy[] tunneltrafficpolicy = (tunneltrafficpolicy[]) null;
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
