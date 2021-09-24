// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cs.cspolicy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.cs
{
  public class cspolicy : base_resource
  {
    private string policynameField = (string) null;
    private string urlField = (string) null;
    private string ruleField = (string) null;
    private string domainField = (string) null;
    private string actionField = (string) null;
    private string logactionField = (string) null;
    private string newnameField = (string) null;
    private uint? vstypeField = new uint?();
    private uint? hitsField = new uint?();
    private uint? bindhitsField = new uint?();
    private string labelnameField = (string) null;
    private string labeltypeField = (string) null;
    private uint? priorityField = new uint?();
    private bool? activepolicyField = new bool?();
    private string cspolicytypeField = (string) null;
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

    public string url
    {
      get => this.urlField;
      set => this.urlField = value;
    }

    public string rule
    {
      get => this.ruleField;
      set => this.ruleField = value;
    }

    public string domain
    {
      get => this.domainField;
      set => this.domainField = value;
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

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      cspolicy.cspolicy_response cspolicyResponse = new cspolicy.cspolicy_response();
      cspolicy.cspolicy_response resource = (cspolicy.cspolicy_response) service.get_payload_formatter().string_to_resource(cspolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.cspolicy;
    }

    internal override string get_object_name() => this.policyname;

    public static base_response add(nitro_service client, cspolicy resource) => new cspolicy()
    {
      policyname = resource.policyname,
      url = resource.url,
      rule = resource.rule,
      domain = resource.domain,
      action = resource.action,
      logaction = resource.logaction
    }.add_resource(client);

    public static base_responses add(nitro_service client, cspolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        cspolicy[] cspolicyArray = new cspolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          cspolicyArray[index] = new cspolicy();
          cspolicyArray[index].policyname = resources[index].policyname;
          cspolicyArray[index].url = resources[index].url;
          cspolicyArray[index].rule = resources[index].rule;
          cspolicyArray[index].domain = resources[index].domain;
          cspolicyArray[index].action = resources[index].action;
          cspolicyArray[index].logaction = resources[index].logaction;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) cspolicyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string policyname) => new cspolicy()
    {
      policyname = policyname
    }.delete_resource(client);

    public static base_response delete(nitro_service client, cspolicy resource) => new cspolicy()
    {
      policyname = resource.policyname
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] policyname)
    {
      base_responses baseResponses = (base_responses) null;
      if (policyname != null && policyname.Length > 0)
      {
        cspolicy[] cspolicyArray = new cspolicy[policyname.Length];
        for (int index = 0; index < policyname.Length; ++index)
        {
          cspolicyArray[index] = new cspolicy();
          cspolicyArray[index].policyname = policyname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) cspolicyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, cspolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        cspolicy[] cspolicyArray = new cspolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          cspolicyArray[index] = new cspolicy();
          cspolicyArray[index].policyname = resources[index].policyname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) cspolicyArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, cspolicy resource) => new cspolicy()
    {
      policyname = resource.policyname,
      url = resource.url,
      rule = resource.rule,
      domain = resource.domain,
      action = resource.action,
      logaction = resource.logaction
    }.update_resource(client);

    public static base_responses update(nitro_service client, cspolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        cspolicy[] cspolicyArray = new cspolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          cspolicyArray[index] = new cspolicy();
          cspolicyArray[index].policyname = resources[index].policyname;
          cspolicyArray[index].url = resources[index].url;
          cspolicyArray[index].rule = resources[index].rule;
          cspolicyArray[index].domain = resources[index].domain;
          cspolicyArray[index].action = resources[index].action;
          cspolicyArray[index].logaction = resources[index].logaction;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) cspolicyArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string policyname,
      string[] args)
    {
      return new cspolicy() { policyname = policyname }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      cspolicy resource,
      string[] args)
    {
      return new cspolicy()
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
        cspolicy[] cspolicyArray = new cspolicy[policyname.Length];
        for (int index = 0; index < policyname.Length; ++index)
        {
          cspolicyArray[index] = new cspolicy();
          cspolicyArray[index].policyname = policyname[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) cspolicyArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      cspolicy[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        cspolicy[] cspolicyArray = new cspolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          cspolicyArray[index] = new cspolicy();
          cspolicyArray[index].policyname = resources[index].policyname;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) cspolicyArray, args);
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      cspolicy resource,
      string new_policyname)
    {
      return new cspolicy()
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
      return new cspolicy()
      {
        policyname = policyname,
        newname = new_policyname
      }.rename_resource(client);
    }

    public static cspolicy[] get(nitro_service service) => (cspolicy[]) new cspolicy().get_resources(service, (options) null);

    public static cspolicy[] get(nitro_service service, options option) => (cspolicy[]) new cspolicy().get_resources(service, option);

    public static cspolicy get(nitro_service service, string policyname) => (cspolicy) new cspolicy()
    {
      policyname = policyname
    }.get_resource(service);

    public static cspolicy[] get(nitro_service service, string[] policyname)
    {
      if (policyname == null || policyname.Length <= 0)
        return (cspolicy[]) null;
      cspolicy[] cspolicyArray1 = new cspolicy[policyname.Length];
      cspolicy[] cspolicyArray2 = new cspolicy[policyname.Length];
      for (int index = 0; index < policyname.Length; ++index)
      {
        cspolicyArray2[index] = new cspolicy();
        cspolicyArray2[index].policyname = policyname[index];
        cspolicyArray1[index] = (cspolicy) cspolicyArray2[index].get_resource(service);
      }
      return cspolicyArray1;
    }

    public static cspolicy[] get_filtered(nitro_service service, string filter)
    {
      cspolicy cspolicy = new cspolicy();
      options option = new options();
      option.set_filter(filter);
      return (cspolicy[]) cspolicy.getfiltered(service, option);
    }

    public static cspolicy[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      cspolicy cspolicy = new cspolicy();
      options option = new options();
      option.set_filter(filter);
      return (cspolicy[]) cspolicy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      cspolicy cspolicy = new cspolicy();
      options option = new options();
      option.set_count(true);
      cspolicy[] resources = (cspolicy[]) cspolicy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      cspolicy cspolicy = new cspolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      cspolicy[] cspolicyArray = (cspolicy[]) cspolicy.getfiltered(service, option);
      return cspolicyArray != null && cspolicyArray.Length > 0 ? cspolicyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      cspolicy cspolicy = new cspolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      cspolicy[] cspolicyArray = (cspolicy[]) cspolicy.getfiltered(service, option);
      return cspolicyArray != null && cspolicyArray.Length > 0 ? cspolicyArray[0].__count.Value : 0U;
    }

    private class cspolicy_response : base_response
    {
      public cspolicy[] cspolicy = (cspolicy[]) null;
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
