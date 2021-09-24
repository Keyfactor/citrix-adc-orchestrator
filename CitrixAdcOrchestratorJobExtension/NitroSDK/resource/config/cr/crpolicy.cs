// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cr.crpolicy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.cr
{
  public class crpolicy : base_resource
  {
    private string policynameField = (string) null;
    private string ruleField = (string) null;
    private string actionField = (string) null;
    private string logactionField = (string) null;
    private string newnameField = (string) null;
    private string domainField = (string) null;
    private uint? vstypeField = new uint?();
    private uint? hitsField = new uint?();
    private uint? bindhitsField = new uint?();
    private uint? priorityField = new uint?();
    private bool? activepolicyField = new bool?();
    private string cspolicytypeField = (string) null;
    private string labelnameField = (string) null;
    private string labeltypeField = (string) null;
    private string[] builtinField = (string[]) null;
    private bool? isdefaultField = new bool?();
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

    public string domain
    {
      get => this.domainField;
      private set => this.domainField = value;
    }

    public uint? vstype
    {
      get => this.vstypeField;
      private set => this.vstypeField = value;
    }

    public uint? hits
    {
      get => this.hitsField;
      private set => this.hitsField = value;
    }

    public uint? bindhits
    {
      get => this.bindhitsField;
      private set => this.bindhitsField = value;
    }

    public uint? priority
    {
      get => this.priorityField;
      private set => this.priorityField = value;
    }

    public bool? activepolicy
    {
      get => this.activepolicyField;
      private set => this.activepolicyField = value;
    }

    public string cspolicytype
    {
      get => this.cspolicytypeField;
      private set => this.cspolicytypeField = value;
    }

    public string labelname
    {
      get => this.labelnameField;
      private set => this.labelnameField = value;
    }

    public string labeltype
    {
      get => this.labeltypeField;
      private set => this.labeltypeField = value;
    }

    public string[] builtin
    {
      get => this.builtinField;
      private set => this.builtinField = value;
    }

    public bool? isdefault
    {
      get => this.isdefaultField;
      private set => this.isdefaultField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      crpolicy.crpolicy_response crpolicyResponse = new crpolicy.crpolicy_response();
      crpolicy.crpolicy_response resource = (crpolicy.crpolicy_response) service.get_payload_formatter().string_to_resource(crpolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.crpolicy;
    }

    internal override string get_object_name() => this.policyname;

    public static base_response add(nitro_service client, crpolicy resource) => new crpolicy()
    {
      policyname = resource.policyname,
      rule = resource.rule,
      action = resource.action,
      logaction = resource.logaction
    }.add_resource(client);

    public static base_responses add(nitro_service client, crpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        crpolicy[] crpolicyArray = new crpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          crpolicyArray[index] = new crpolicy();
          crpolicyArray[index].policyname = resources[index].policyname;
          crpolicyArray[index].rule = resources[index].rule;
          crpolicyArray[index].action = resources[index].action;
          crpolicyArray[index].logaction = resources[index].logaction;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) crpolicyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string policyname) => new crpolicy()
    {
      policyname = policyname
    }.delete_resource(client);

    public static base_response delete(nitro_service client, crpolicy resource) => new crpolicy()
    {
      policyname = resource.policyname
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] policyname)
    {
      base_responses baseResponses = (base_responses) null;
      if (policyname != null && policyname.Length > 0)
      {
        crpolicy[] crpolicyArray = new crpolicy[policyname.Length];
        for (int index = 0; index < policyname.Length; ++index)
        {
          crpolicyArray[index] = new crpolicy();
          crpolicyArray[index].policyname = policyname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) crpolicyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, crpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        crpolicy[] crpolicyArray = new crpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          crpolicyArray[index] = new crpolicy();
          crpolicyArray[index].policyname = resources[index].policyname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) crpolicyArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, crpolicy resource) => new crpolicy()
    {
      policyname = resource.policyname,
      rule = resource.rule,
      action = resource.action,
      logaction = resource.logaction
    }.update_resource(client);

    public static base_responses update(nitro_service client, crpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        crpolicy[] crpolicyArray = new crpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          crpolicyArray[index] = new crpolicy();
          crpolicyArray[index].policyname = resources[index].policyname;
          crpolicyArray[index].rule = resources[index].rule;
          crpolicyArray[index].action = resources[index].action;
          crpolicyArray[index].logaction = resources[index].logaction;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) crpolicyArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string policyname,
      string[] args)
    {
      return new crpolicy() { policyname = policyname }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      crpolicy resource,
      string[] args)
    {
      return new crpolicy()
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
        crpolicy[] crpolicyArray = new crpolicy[policyname.Length];
        for (int index = 0; index < policyname.Length; ++index)
        {
          crpolicyArray[index] = new crpolicy();
          crpolicyArray[index].policyname = policyname[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) crpolicyArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      crpolicy[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        crpolicy[] crpolicyArray = new crpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          crpolicyArray[index] = new crpolicy();
          crpolicyArray[index].policyname = resources[index].policyname;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) crpolicyArray, args);
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      crpolicy resource,
      string new_policyname)
    {
      return new crpolicy()
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
      return new crpolicy()
      {
        policyname = policyname,
        newname = new_policyname
      }.rename_resource(client);
    }

    public static crpolicy[] get(nitro_service service) => (crpolicy[]) new crpolicy().get_resources(service, (options) null);

    public static crpolicy[] get(nitro_service service, options option) => (crpolicy[]) new crpolicy().get_resources(service, option);

    public static crpolicy get(nitro_service service, string policyname) => (crpolicy) new crpolicy()
    {
      policyname = policyname
    }.get_resource(service);

    public static crpolicy[] get(nitro_service service, string[] policyname)
    {
      if (policyname == null || policyname.Length <= 0)
        return (crpolicy[]) null;
      crpolicy[] crpolicyArray1 = new crpolicy[policyname.Length];
      crpolicy[] crpolicyArray2 = new crpolicy[policyname.Length];
      for (int index = 0; index < policyname.Length; ++index)
      {
        crpolicyArray2[index] = new crpolicy();
        crpolicyArray2[index].policyname = policyname[index];
        crpolicyArray1[index] = (crpolicy) crpolicyArray2[index].get_resource(service);
      }
      return crpolicyArray1;
    }

    public static crpolicy[] get_filtered(nitro_service service, string filter)
    {
      crpolicy crpolicy = new crpolicy();
      options option = new options();
      option.set_filter(filter);
      return (crpolicy[]) crpolicy.getfiltered(service, option);
    }

    public static crpolicy[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      crpolicy crpolicy = new crpolicy();
      options option = new options();
      option.set_filter(filter);
      return (crpolicy[]) crpolicy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      crpolicy crpolicy = new crpolicy();
      options option = new options();
      option.set_count(true);
      crpolicy[] resources = (crpolicy[]) crpolicy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      crpolicy crpolicy = new crpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      crpolicy[] crpolicyArray = (crpolicy[]) crpolicy.getfiltered(service, option);
      return crpolicyArray != null && crpolicyArray.Length > 0 ? crpolicyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      crpolicy crpolicy = new crpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      crpolicy[] crpolicyArray = (crpolicy[]) crpolicy.getfiltered(service, option);
      return crpolicyArray != null && crpolicyArray.Length > 0 ? crpolicyArray[0].__count.Value : 0U;
    }

    private class crpolicy_response : base_response
    {
      public crpolicy[] crpolicy = (crpolicy[]) null;
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }

    public static class cspolicytypeEnum
    {
      public const string Classic_Policy = "Classic Policy";
      public const string Advanced_Policy = "Advanced Policy";
    }

    public static class labeltypeEnum
    {
      public const string reqvserver = "reqvserver";
      public const string resvserver = "resvserver";
      public const string policylabel = "policylabel";
    }
  }
}
