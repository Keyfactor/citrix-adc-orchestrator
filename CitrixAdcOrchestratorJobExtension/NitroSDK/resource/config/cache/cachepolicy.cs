// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cache.cachepolicy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.cache
{
  public class cachepolicy : base_resource
  {
    private string policynameField = (string) null;
    private string ruleField = (string) null;
    private string actionField = (string) null;
    private string storeingroupField = (string) null;
    private string[] invalgroupsField = (string[]) null;
    private string[] invalobjectsField = (string[]) null;
    private string undefactionField = (string) null;
    private string newnameField = (string) null;
    private long? hitsField = new long?();
    private long? undefhitsField = new long?();
    private uint? flagsField = new uint?();
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

    public string storeingroup
    {
      get => this.storeingroupField;
      set => this.storeingroupField = value;
    }

    public string[] invalgroups
    {
      get => this.invalgroupsField;
      set => this.invalgroupsField = value;
    }

    public string[] invalobjects
    {
      get => this.invalobjectsField;
      set => this.invalobjectsField = value;
    }

    public string undefaction
    {
      get => this.undefactionField;
      set => this.undefactionField = value;
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

    public uint? flags
    {
      get => this.flagsField;
      private set => this.flagsField = value;
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
      cachepolicy.cachepolicy_response cachepolicyResponse = new cachepolicy.cachepolicy_response();
      cachepolicy.cachepolicy_response resource = (cachepolicy.cachepolicy_response) service.get_payload_formatter().string_to_resource(cachepolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.cachepolicy;
    }

    internal override string get_object_name() => this.policyname;

    public static base_response add(nitro_service client, cachepolicy resource) => new cachepolicy()
    {
      policyname = resource.policyname,
      rule = resource.rule,
      action = resource.action,
      storeingroup = resource.storeingroup,
      invalgroups = resource.invalgroups,
      invalobjects = resource.invalobjects,
      undefaction = resource.undefaction
    }.add_resource(client);

    public static base_responses add(nitro_service client, cachepolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        cachepolicy[] cachepolicyArray = new cachepolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          cachepolicyArray[index] = new cachepolicy();
          cachepolicyArray[index].policyname = resources[index].policyname;
          cachepolicyArray[index].rule = resources[index].rule;
          cachepolicyArray[index].action = resources[index].action;
          cachepolicyArray[index].storeingroup = resources[index].storeingroup;
          cachepolicyArray[index].invalgroups = resources[index].invalgroups;
          cachepolicyArray[index].invalobjects = resources[index].invalobjects;
          cachepolicyArray[index].undefaction = resources[index].undefaction;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) cachepolicyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string policyname) => new cachepolicy()
    {
      policyname = policyname
    }.delete_resource(client);

    public static base_response delete(nitro_service client, cachepolicy resource) => new cachepolicy()
    {
      policyname = resource.policyname
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] policyname)
    {
      base_responses baseResponses = (base_responses) null;
      if (policyname != null && policyname.Length > 0)
      {
        cachepolicy[] cachepolicyArray = new cachepolicy[policyname.Length];
        for (int index = 0; index < policyname.Length; ++index)
        {
          cachepolicyArray[index] = new cachepolicy();
          cachepolicyArray[index].policyname = policyname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) cachepolicyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, cachepolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        cachepolicy[] cachepolicyArray = new cachepolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          cachepolicyArray[index] = new cachepolicy();
          cachepolicyArray[index].policyname = resources[index].policyname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) cachepolicyArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, cachepolicy resource) => new cachepolicy()
    {
      policyname = resource.policyname,
      rule = resource.rule,
      action = resource.action,
      storeingroup = resource.storeingroup,
      invalgroups = resource.invalgroups,
      invalobjects = resource.invalobjects,
      undefaction = resource.undefaction
    }.update_resource(client);

    public static base_responses update(nitro_service client, cachepolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        cachepolicy[] cachepolicyArray = new cachepolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          cachepolicyArray[index] = new cachepolicy();
          cachepolicyArray[index].policyname = resources[index].policyname;
          cachepolicyArray[index].rule = resources[index].rule;
          cachepolicyArray[index].action = resources[index].action;
          cachepolicyArray[index].storeingroup = resources[index].storeingroup;
          cachepolicyArray[index].invalgroups = resources[index].invalgroups;
          cachepolicyArray[index].invalobjects = resources[index].invalobjects;
          cachepolicyArray[index].undefaction = resources[index].undefaction;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) cachepolicyArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string policyname,
      string[] args)
    {
      return new cachepolicy() { policyname = policyname }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      cachepolicy resource,
      string[] args)
    {
      return new cachepolicy()
      {
        policyname = resource.policyname
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] policyname,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (policyname != null && policyname.Length > 0)
      {
        cachepolicy[] cachepolicyArray = new cachepolicy[policyname.Length];
        for (int index = 0; index < policyname.Length; ++index)
        {
          cachepolicyArray[index] = new cachepolicy();
          cachepolicyArray[index].policyname = policyname[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) cachepolicyArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      cachepolicy[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        cachepolicy[] cachepolicyArray = new cachepolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          cachepolicyArray[index] = new cachepolicy();
          cachepolicyArray[index].policyname = resources[index].policyname;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) cachepolicyArray, args);
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      cachepolicy resource,
      string new_policyname)
    {
      return new cachepolicy()
      {
        policyname = resource.policyname,
        newname = new_policyname
      }.rename_resource(client);
    }

    public static base_response rename(
      nitro_service client,
      string policyname,
      string new_policyname)
    {
      return new cachepolicy()
      {
        policyname = policyname,
        newname = new_policyname
      }.rename_resource(client);
    }

    public static cachepolicy[] get(nitro_service service) => (cachepolicy[]) new cachepolicy().get_resources(service, (options) null);

    public static cachepolicy[] get(nitro_service service, options option) => (cachepolicy[]) new cachepolicy().get_resources(service, option);

    public static cachepolicy get(nitro_service service, string policyname) => (cachepolicy) new cachepolicy()
    {
      policyname = policyname
    }.get_resource(service);

    public static cachepolicy[] get(nitro_service service, string[] policyname)
    {
      if (policyname == null || policyname.Length <= 0)
        return (cachepolicy[]) null;
      cachepolicy[] cachepolicyArray1 = new cachepolicy[policyname.Length];
      cachepolicy[] cachepolicyArray2 = new cachepolicy[policyname.Length];
      for (int index = 0; index < policyname.Length; ++index)
      {
        cachepolicyArray2[index] = new cachepolicy();
        cachepolicyArray2[index].policyname = policyname[index];
        cachepolicyArray1[index] = (cachepolicy) cachepolicyArray2[index].get_resource(service);
      }
      return cachepolicyArray1;
    }

    public static cachepolicy[] get_filtered(nitro_service service, string filter)
    {
      cachepolicy cachepolicy = new cachepolicy();
      options option = new options();
      option.set_filter(filter);
      return (cachepolicy[]) cachepolicy.getfiltered(service, option);
    }

    public static cachepolicy[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      cachepolicy cachepolicy = new cachepolicy();
      options option = new options();
      option.set_filter(filter);
      return (cachepolicy[]) cachepolicy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      cachepolicy cachepolicy = new cachepolicy();
      options option = new options();
      option.set_count(true);
      cachepolicy[] resources = (cachepolicy[]) cachepolicy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      cachepolicy cachepolicy = new cachepolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      cachepolicy[] cachepolicyArray = (cachepolicy[]) cachepolicy.getfiltered(service, option);
      return cachepolicyArray != null && cachepolicyArray.Length > 0 ? cachepolicyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      cachepolicy cachepolicy = new cachepolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      cachepolicy[] cachepolicyArray = (cachepolicy[]) cachepolicy.getfiltered(service, option);
      return cachepolicyArray != null && cachepolicyArray.Length > 0 ? cachepolicyArray[0].__count.Value : 0U;
    }

    private class cachepolicy_response : base_response
    {
      public cachepolicy[] cachepolicy = (cachepolicy[]) null;
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }

    public static class undefactionEnum
    {
      public const string NOCACHE = "NOCACHE";
      public const string RESET = "RESET";
    }

    public static class actionEnum
    {
      public const string CACHE = "CACHE";
      public const string NOCACHE = "NOCACHE";
      public const string MAY_CACHE = "MAY_CACHE";
      public const string MAY_NOCACHE = "MAY_NOCACHE";
      public const string INVAL = "INVAL";
    }
  }
}
