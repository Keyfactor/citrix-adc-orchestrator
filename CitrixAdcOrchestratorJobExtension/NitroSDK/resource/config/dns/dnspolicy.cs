// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.dns.dnspolicy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.dns
{
  public class dnspolicy : base_resource
  {
    private string nameField = (string) null;
    private string ruleField = (string) null;
    private string viewnameField = (string) null;
    private string preferredlocationField = (string) null;
    private string[] preferredloclistField = (string[]) null;
    private string dropField = (string) null;
    private string cachebypassField = (string) null;
    private string actionnameField = (string) null;
    private string logactionField = (string) null;
    private long? hitsField = new long?();
    private long? undefhitsField = new long?();
    private string descriptionField = (string) null;
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

    public string viewname
    {
      get => this.viewnameField;
      set => this.viewnameField = value;
    }

    public string preferredlocation
    {
      get => this.preferredlocationField;
      set => this.preferredlocationField = value;
    }

    public string[] preferredloclist
    {
      get => this.preferredloclistField;
      set => this.preferredloclistField = value;
    }

    public string drop
    {
      get => this.dropField;
      set => this.dropField = value;
    }

    public string cachebypass
    {
      get => this.cachebypassField;
      set => this.cachebypassField = value;
    }

    public string actionname
    {
      get => this.actionnameField;
      set => this.actionnameField = value;
    }

    public string logaction
    {
      get => this.logactionField;
      set => this.logactionField = value;
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

    public string[] builtin
    {
      get => this.builtinField;
      private set => this.builtinField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      dnspolicy.dnspolicy_response dnspolicyResponse = new dnspolicy.dnspolicy_response();
      dnspolicy.dnspolicy_response resource = (dnspolicy.dnspolicy_response) service.get_payload_formatter().string_to_resource(dnspolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.dnspolicy;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, dnspolicy resource) => new dnspolicy()
    {
      name = resource.name,
      rule = resource.rule,
      viewname = resource.viewname,
      preferredlocation = resource.preferredlocation,
      preferredloclist = resource.preferredloclist,
      drop = resource.drop,
      cachebypass = resource.cachebypass,
      actionname = resource.actionname,
      logaction = resource.logaction
    }.add_resource(client);

    public static base_responses add(nitro_service client, dnspolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnspolicy[] dnspolicyArray = new dnspolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnspolicyArray[index] = new dnspolicy();
          dnspolicyArray[index].name = resources[index].name;
          dnspolicyArray[index].rule = resources[index].rule;
          dnspolicyArray[index].viewname = resources[index].viewname;
          dnspolicyArray[index].preferredlocation = resources[index].preferredlocation;
          dnspolicyArray[index].preferredloclist = resources[index].preferredloclist;
          dnspolicyArray[index].drop = resources[index].drop;
          dnspolicyArray[index].cachebypass = resources[index].cachebypass;
          dnspolicyArray[index].actionname = resources[index].actionname;
          dnspolicyArray[index].logaction = resources[index].logaction;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) dnspolicyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new dnspolicy()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, dnspolicy resource) => new dnspolicy()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        dnspolicy[] dnspolicyArray = new dnspolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          dnspolicyArray[index] = new dnspolicy();
          dnspolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dnspolicyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, dnspolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnspolicy[] dnspolicyArray = new dnspolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnspolicyArray[index] = new dnspolicy();
          dnspolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dnspolicyArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, dnspolicy resource) => new dnspolicy()
    {
      name = resource.name,
      rule = resource.rule,
      viewname = resource.viewname,
      preferredlocation = resource.preferredlocation,
      preferredloclist = resource.preferredloclist,
      drop = resource.drop,
      cachebypass = resource.cachebypass,
      actionname = resource.actionname,
      logaction = resource.logaction
    }.update_resource(client);

    public static base_responses update(nitro_service client, dnspolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnspolicy[] dnspolicyArray = new dnspolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnspolicyArray[index] = new dnspolicy();
          dnspolicyArray[index].name = resources[index].name;
          dnspolicyArray[index].rule = resources[index].rule;
          dnspolicyArray[index].viewname = resources[index].viewname;
          dnspolicyArray[index].preferredlocation = resources[index].preferredlocation;
          dnspolicyArray[index].preferredloclist = resources[index].preferredloclist;
          dnspolicyArray[index].drop = resources[index].drop;
          dnspolicyArray[index].cachebypass = resources[index].cachebypass;
          dnspolicyArray[index].actionname = resources[index].actionname;
          dnspolicyArray[index].logaction = resources[index].logaction;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) dnspolicyArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new dnspolicy() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      dnspolicy resource,
      string[] args)
    {
      return new dnspolicy() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        dnspolicy[] dnspolicyArray = new dnspolicy[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          dnspolicyArray[index] = new dnspolicy();
          dnspolicyArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) dnspolicyArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      dnspolicy[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnspolicy[] dnspolicyArray = new dnspolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnspolicyArray[index] = new dnspolicy();
          dnspolicyArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) dnspolicyArray, args);
      }
      return baseResponses;
    }

    public static dnspolicy[] get(nitro_service service) => (dnspolicy[]) new dnspolicy().get_resources(service, (options) null);

    public static dnspolicy[] get(nitro_service service, options option) => (dnspolicy[]) new dnspolicy().get_resources(service, option);

    public static dnspolicy get(nitro_service service, string name) => (dnspolicy) new dnspolicy()
    {
      name = name
    }.get_resource(service);

    public static dnspolicy[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (dnspolicy[]) null;
      dnspolicy[] dnspolicyArray1 = new dnspolicy[name.Length];
      dnspolicy[] dnspolicyArray2 = new dnspolicy[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        dnspolicyArray2[index] = new dnspolicy();
        dnspolicyArray2[index].name = name[index];
        dnspolicyArray1[index] = (dnspolicy) dnspolicyArray2[index].get_resource(service);
      }
      return dnspolicyArray1;
    }

    public static dnspolicy[] get_filtered(nitro_service service, string filter)
    {
      dnspolicy dnspolicy = new dnspolicy();
      options option = new options();
      option.set_filter(filter);
      return (dnspolicy[]) dnspolicy.getfiltered(service, option);
    }

    public static dnspolicy[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      dnspolicy dnspolicy = new dnspolicy();
      options option = new options();
      option.set_filter(filter);
      return (dnspolicy[]) dnspolicy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      dnspolicy dnspolicy = new dnspolicy();
      options option = new options();
      option.set_count(true);
      dnspolicy[] resources = (dnspolicy[]) dnspolicy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      dnspolicy dnspolicy = new dnspolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnspolicy[] dnspolicyArray = (dnspolicy[]) dnspolicy.getfiltered(service, option);
      return dnspolicyArray != null && dnspolicyArray.Length > 0 ? dnspolicyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      dnspolicy dnspolicy = new dnspolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnspolicy[] dnspolicyArray = (dnspolicy[]) dnspolicy.getfiltered(service, option);
      return dnspolicyArray != null && dnspolicyArray.Length > 0 ? dnspolicyArray[0].__count.Value : 0U;
    }

    private class dnspolicy_response : base_response
    {
      public dnspolicy[] dnspolicy = (dnspolicy[]) null;
    }

    public static class cachebypassEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }

    public static class dropEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }
  }
}
