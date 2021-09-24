// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.system.systemcmdpolicy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.system
{
  public class systemcmdpolicy : base_resource
  {
    private string policynameField = (string) null;
    private string actionField = (string) null;
    private string cmdspecField = (string) null;
    private string[] builtinField = (string[]) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string policyname
    {
      get => this.policynameField;
      set => this.policynameField = value;
    }

    public string action
    {
      get => this.actionField;
      set => this.actionField = value;
    }

    public string cmdspec
    {
      get => this.cmdspecField;
      set => this.cmdspecField = value;
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
      systemcmdpolicy.systemcmdpolicy_response systemcmdpolicyResponse = new systemcmdpolicy.systemcmdpolicy_response();
      systemcmdpolicy.systemcmdpolicy_response resource = (systemcmdpolicy.systemcmdpolicy_response) service.get_payload_formatter().string_to_resource(systemcmdpolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.systemcmdpolicy;
    }

    internal override string get_object_name() => this.policyname;

    public static base_response add(nitro_service client, systemcmdpolicy resource) => new systemcmdpolicy()
    {
      policyname = resource.policyname,
      action = resource.action,
      cmdspec = resource.cmdspec
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      systemcmdpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        systemcmdpolicy[] systemcmdpolicyArray = new systemcmdpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          systemcmdpolicyArray[index] = new systemcmdpolicy();
          systemcmdpolicyArray[index].policyname = resources[index].policyname;
          systemcmdpolicyArray[index].action = resources[index].action;
          systemcmdpolicyArray[index].cmdspec = resources[index].cmdspec;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) systemcmdpolicyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string policyname) => new systemcmdpolicy()
    {
      policyname = policyname
    }.delete_resource(client);

    public static base_response delete(nitro_service client, systemcmdpolicy resource) => new systemcmdpolicy()
    {
      policyname = resource.policyname
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] policyname)
    {
      base_responses baseResponses = (base_responses) null;
      if (policyname != null && policyname.Length > 0)
      {
        systemcmdpolicy[] systemcmdpolicyArray = new systemcmdpolicy[policyname.Length];
        for (int index = 0; index < policyname.Length; ++index)
        {
          systemcmdpolicyArray[index] = new systemcmdpolicy();
          systemcmdpolicyArray[index].policyname = policyname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) systemcmdpolicyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      systemcmdpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        systemcmdpolicy[] systemcmdpolicyArray = new systemcmdpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          systemcmdpolicyArray[index] = new systemcmdpolicy();
          systemcmdpolicyArray[index].policyname = resources[index].policyname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) systemcmdpolicyArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, systemcmdpolicy resource) => new systemcmdpolicy()
    {
      policyname = resource.policyname,
      action = resource.action,
      cmdspec = resource.cmdspec
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      systemcmdpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        systemcmdpolicy[] systemcmdpolicyArray = new systemcmdpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          systemcmdpolicyArray[index] = new systemcmdpolicy();
          systemcmdpolicyArray[index].policyname = resources[index].policyname;
          systemcmdpolicyArray[index].action = resources[index].action;
          systemcmdpolicyArray[index].cmdspec = resources[index].cmdspec;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) systemcmdpolicyArray);
      }
      return baseResponses;
    }

    public static systemcmdpolicy[] get(nitro_service service) => (systemcmdpolicy[]) new systemcmdpolicy().get_resources(service, (options) null);

    public static systemcmdpolicy[] get(nitro_service service, options option) => (systemcmdpolicy[]) new systemcmdpolicy().get_resources(service, option);

    public static systemcmdpolicy get(nitro_service service, string policyname) => (systemcmdpolicy) new systemcmdpolicy()
    {
      policyname = policyname
    }.get_resource(service);

    public static systemcmdpolicy[] get(nitro_service service, string[] policyname)
    {
      if (policyname == null || policyname.Length <= 0)
        return (systemcmdpolicy[]) null;
      systemcmdpolicy[] systemcmdpolicyArray1 = new systemcmdpolicy[policyname.Length];
      systemcmdpolicy[] systemcmdpolicyArray2 = new systemcmdpolicy[policyname.Length];
      for (int index = 0; index < policyname.Length; ++index)
      {
        systemcmdpolicyArray2[index] = new systemcmdpolicy();
        systemcmdpolicyArray2[index].policyname = policyname[index];
        systemcmdpolicyArray1[index] = (systemcmdpolicy) systemcmdpolicyArray2[index].get_resource(service);
      }
      return systemcmdpolicyArray1;
    }

    public static systemcmdpolicy[] get_filtered(
      nitro_service service,
      string filter)
    {
      systemcmdpolicy systemcmdpolicy = new systemcmdpolicy();
      options option = new options();
      option.set_filter(filter);
      return (systemcmdpolicy[]) systemcmdpolicy.getfiltered(service, option);
    }

    public static systemcmdpolicy[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      systemcmdpolicy systemcmdpolicy = new systemcmdpolicy();
      options option = new options();
      option.set_filter(filter);
      return (systemcmdpolicy[]) systemcmdpolicy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      systemcmdpolicy systemcmdpolicy = new systemcmdpolicy();
      options option = new options();
      option.set_count(true);
      systemcmdpolicy[] resources = (systemcmdpolicy[]) systemcmdpolicy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      systemcmdpolicy systemcmdpolicy = new systemcmdpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      systemcmdpolicy[] systemcmdpolicyArray = (systemcmdpolicy[]) systemcmdpolicy.getfiltered(service, option);
      return systemcmdpolicyArray != null && systemcmdpolicyArray.Length > 0 ? systemcmdpolicyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      systemcmdpolicy systemcmdpolicy = new systemcmdpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      systemcmdpolicy[] systemcmdpolicyArray = (systemcmdpolicy[]) systemcmdpolicy.getfiltered(service, option);
      return systemcmdpolicyArray != null && systemcmdpolicyArray.Length > 0 ? systemcmdpolicyArray[0].__count.Value : 0U;
    }

    private class systemcmdpolicy_response : base_response
    {
      public systemcmdpolicy[] systemcmdpolicy = (systemcmdpolicy[]) null;
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }

    public static class actionEnum
    {
      public const string ALLOW = "ALLOW";
      public const string DENY = "DENY";
    }
  }
}
