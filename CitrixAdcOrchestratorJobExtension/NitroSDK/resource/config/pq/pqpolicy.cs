// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.pq.pqpolicy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.pq
{
  public class pqpolicy : base_resource
  {
    private string policynameField = (string) null;
    private string ruleField = (string) null;
    private uint? priorityField = new uint?();
    private uint? weightField = new uint?();
    private uint? qdepthField = new uint?();
    private uint? polqdepthField = new uint?();
    private long? hitsField = new long?();
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

    public uint? priority
    {
      get => this.priorityField;
      set => this.priorityField = value;
    }

    public uint? weight
    {
      get => this.weightField;
      set => this.weightField = value;
    }

    public uint? qdepth
    {
      get => this.qdepthField;
      set => this.qdepthField = value;
    }

    public uint? polqdepth
    {
      get => this.polqdepthField;
      set => this.polqdepthField = value;
    }

    public long? hits
    {
      get => this.hitsField;
      private set => this.hitsField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      pqpolicy.pqpolicy_response pqpolicyResponse = new pqpolicy.pqpolicy_response();
      pqpolicy.pqpolicy_response resource = (pqpolicy.pqpolicy_response) service.get_payload_formatter().string_to_resource(pqpolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.pqpolicy;
    }

    internal override string get_object_name() => this.policyname;

    public static base_response add(nitro_service client, pqpolicy resource) => new pqpolicy()
    {
      policyname = resource.policyname,
      rule = resource.rule,
      priority = resource.priority,
      weight = resource.weight,
      qdepth = resource.qdepth,
      polqdepth = resource.polqdepth
    }.add_resource(client);

    public static base_responses add(nitro_service client, pqpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        pqpolicy[] pqpolicyArray = new pqpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          pqpolicyArray[index] = new pqpolicy();
          pqpolicyArray[index].policyname = resources[index].policyname;
          pqpolicyArray[index].rule = resources[index].rule;
          pqpolicyArray[index].priority = resources[index].priority;
          pqpolicyArray[index].weight = resources[index].weight;
          pqpolicyArray[index].qdepth = resources[index].qdepth;
          pqpolicyArray[index].polqdepth = resources[index].polqdepth;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) pqpolicyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string policyname) => new pqpolicy()
    {
      policyname = policyname
    }.delete_resource(client);

    public static base_response delete(nitro_service client, pqpolicy resource) => new pqpolicy()
    {
      policyname = resource.policyname
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] policyname)
    {
      base_responses baseResponses = (base_responses) null;
      if (policyname != null && policyname.Length > 0)
      {
        pqpolicy[] pqpolicyArray = new pqpolicy[policyname.Length];
        for (int index = 0; index < policyname.Length; ++index)
        {
          pqpolicyArray[index] = new pqpolicy();
          pqpolicyArray[index].policyname = policyname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) pqpolicyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, pqpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        pqpolicy[] pqpolicyArray = new pqpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          pqpolicyArray[index] = new pqpolicy();
          pqpolicyArray[index].policyname = resources[index].policyname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) pqpolicyArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, pqpolicy resource) => new pqpolicy()
    {
      policyname = resource.policyname,
      weight = resource.weight,
      qdepth = resource.qdepth,
      polqdepth = resource.polqdepth
    }.update_resource(client);

    public static base_responses update(nitro_service client, pqpolicy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        pqpolicy[] pqpolicyArray = new pqpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          pqpolicyArray[index] = new pqpolicy();
          pqpolicyArray[index].policyname = resources[index].policyname;
          pqpolicyArray[index].weight = resources[index].weight;
          pqpolicyArray[index].qdepth = resources[index].qdepth;
          pqpolicyArray[index].polqdepth = resources[index].polqdepth;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) pqpolicyArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string policyname,
      string[] args)
    {
      return new pqpolicy() { policyname = policyname }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      pqpolicy resource,
      string[] args)
    {
      return new pqpolicy()
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
        pqpolicy[] pqpolicyArray = new pqpolicy[policyname.Length];
        for (int index = 0; index < policyname.Length; ++index)
        {
          pqpolicyArray[index] = new pqpolicy();
          pqpolicyArray[index].policyname = policyname[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) pqpolicyArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      pqpolicy[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        pqpolicy[] pqpolicyArray = new pqpolicy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          pqpolicyArray[index] = new pqpolicy();
          pqpolicyArray[index].policyname = resources[index].policyname;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) pqpolicyArray, args);
      }
      return baseResponses;
    }

    public static pqpolicy[] get(nitro_service service) => (pqpolicy[]) new pqpolicy().get_resources(service, (options) null);

    public static pqpolicy[] get(nitro_service service, options option) => (pqpolicy[]) new pqpolicy().get_resources(service, option);

    public static pqpolicy get(nitro_service service, string policyname) => (pqpolicy) new pqpolicy()
    {
      policyname = policyname
    }.get_resource(service);

    public static pqpolicy[] get(nitro_service service, string[] policyname)
    {
      if (policyname == null || policyname.Length <= 0)
        return (pqpolicy[]) null;
      pqpolicy[] pqpolicyArray1 = new pqpolicy[policyname.Length];
      pqpolicy[] pqpolicyArray2 = new pqpolicy[policyname.Length];
      for (int index = 0; index < policyname.Length; ++index)
      {
        pqpolicyArray2[index] = new pqpolicy();
        pqpolicyArray2[index].policyname = policyname[index];
        pqpolicyArray1[index] = (pqpolicy) pqpolicyArray2[index].get_resource(service);
      }
      return pqpolicyArray1;
    }

    public static pqpolicy[] get_filtered(nitro_service service, string filter)
    {
      pqpolicy pqpolicy = new pqpolicy();
      options option = new options();
      option.set_filter(filter);
      return (pqpolicy[]) pqpolicy.getfiltered(service, option);
    }

    public static pqpolicy[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      pqpolicy pqpolicy = new pqpolicy();
      options option = new options();
      option.set_filter(filter);
      return (pqpolicy[]) pqpolicy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      pqpolicy pqpolicy = new pqpolicy();
      options option = new options();
      option.set_count(true);
      pqpolicy[] resources = (pqpolicy[]) pqpolicy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      pqpolicy pqpolicy = new pqpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      pqpolicy[] pqpolicyArray = (pqpolicy[]) pqpolicy.getfiltered(service, option);
      return pqpolicyArray != null && pqpolicyArray.Length > 0 ? pqpolicyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      pqpolicy pqpolicy = new pqpolicy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      pqpolicy[] pqpolicyArray = (pqpolicy[]) pqpolicy.getfiltered(service, option);
      return pqpolicyArray != null && pqpolicyArray.Length > 0 ? pqpolicyArray[0].__count.Value : 0U;
    }

    private class pqpolicy_response : base_response
    {
      public pqpolicy[] pqpolicy = (pqpolicy[]) null;
    }
  }
}
