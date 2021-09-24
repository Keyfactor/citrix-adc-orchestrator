// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nslimitselector
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nslimitselector : base_resource
  {
    private string selectornameField = (string) null;
    private string[] ruleField = (string[]) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string selectorname
    {
      get => this.selectornameField;
      set => this.selectornameField = value;
    }

    public string[] rule
    {
      get => this.ruleField;
      set => this.ruleField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nslimitselector.nslimitselector_response nslimitselectorResponse = new nslimitselector.nslimitselector_response();
      nslimitselector.nslimitselector_response resource = (nslimitselector.nslimitselector_response) service.get_payload_formatter().string_to_resource(nslimitselectorResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nslimitselector;
    }

    internal override string get_object_name() => this.selectorname;

    public static base_response add(nitro_service client, nslimitselector resource) => new nslimitselector()
    {
      selectorname = resource.selectorname,
      rule = resource.rule
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      nslimitselector[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nslimitselector[] nslimitselectorArray = new nslimitselector[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nslimitselectorArray[index] = new nslimitselector();
          nslimitselectorArray[index].selectorname = resources[index].selectorname;
          nslimitselectorArray[index].rule = resources[index].rule;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) nslimitselectorArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string selectorname) => new nslimitselector()
    {
      selectorname = selectorname
    }.delete_resource(client);

    public static base_response delete(nitro_service client, nslimitselector resource) => new nslimitselector()
    {
      selectorname = resource.selectorname
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] selectorname)
    {
      base_responses baseResponses = (base_responses) null;
      if (selectorname != null && selectorname.Length > 0)
      {
        nslimitselector[] nslimitselectorArray = new nslimitselector[selectorname.Length];
        for (int index = 0; index < selectorname.Length; ++index)
        {
          nslimitselectorArray[index] = new nslimitselector();
          nslimitselectorArray[index].selectorname = selectorname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nslimitselectorArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      nslimitselector[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nslimitselector[] nslimitselectorArray = new nslimitselector[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nslimitselectorArray[index] = new nslimitselector();
          nslimitselectorArray[index].selectorname = resources[index].selectorname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nslimitselectorArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, nslimitselector resource) => new nslimitselector()
    {
      selectorname = resource.selectorname,
      rule = resource.rule
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      nslimitselector[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nslimitselector[] nslimitselectorArray = new nslimitselector[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nslimitselectorArray[index] = new nslimitselector();
          nslimitselectorArray[index].selectorname = resources[index].selectorname;
          nslimitselectorArray[index].rule = resources[index].rule;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) nslimitselectorArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string selectorname,
      string[] args)
    {
      return new nslimitselector()
      {
        selectorname = selectorname
      }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      nslimitselector resource,
      string[] args)
    {
      return new nslimitselector()
      {
        selectorname = resource.selectorname
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] selectorname,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (selectorname != null && selectorname.Length > 0)
      {
        nslimitselector[] nslimitselectorArray = new nslimitselector[selectorname.Length];
        for (int index = 0; index < selectorname.Length; ++index)
        {
          nslimitselectorArray[index] = new nslimitselector();
          nslimitselectorArray[index].selectorname = selectorname[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) nslimitselectorArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      nslimitselector[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nslimitselector[] nslimitselectorArray = new nslimitselector[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nslimitselectorArray[index] = new nslimitselector();
          nslimitselectorArray[index].selectorname = resources[index].selectorname;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) nslimitselectorArray, args);
      }
      return baseResponses;
    }

    public static nslimitselector[] get(nitro_service service) => (nslimitselector[]) new nslimitselector().get_resources(service, (options) null);

    public static nslimitselector[] get(nitro_service service, options option) => (nslimitselector[]) new nslimitselector().get_resources(service, option);

    public static nslimitselector get(nitro_service service, string selectorname) => (nslimitselector) new nslimitselector()
    {
      selectorname = selectorname
    }.get_resource(service);

    public static nslimitselector[] get(nitro_service service, string[] selectorname)
    {
      if (selectorname == null || selectorname.Length <= 0)
        return (nslimitselector[]) null;
      nslimitselector[] nslimitselectorArray1 = new nslimitselector[selectorname.Length];
      nslimitselector[] nslimitselectorArray2 = new nslimitselector[selectorname.Length];
      for (int index = 0; index < selectorname.Length; ++index)
      {
        nslimitselectorArray2[index] = new nslimitselector();
        nslimitselectorArray2[index].selectorname = selectorname[index];
        nslimitselectorArray1[index] = (nslimitselector) nslimitselectorArray2[index].get_resource(service);
      }
      return nslimitselectorArray1;
    }

    public static nslimitselector[] get_filtered(
      nitro_service service,
      string filter)
    {
      nslimitselector nslimitselector = new nslimitselector();
      options option = new options();
      option.set_filter(filter);
      return (nslimitselector[]) nslimitselector.getfiltered(service, option);
    }

    public static nslimitselector[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      nslimitselector nslimitselector = new nslimitselector();
      options option = new options();
      option.set_filter(filter);
      return (nslimitselector[]) nslimitselector.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      nslimitselector nslimitselector = new nslimitselector();
      options option = new options();
      option.set_count(true);
      nslimitselector[] resources = (nslimitselector[]) nslimitselector.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      nslimitselector nslimitselector = new nslimitselector();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nslimitselector[] nslimitselectorArray = (nslimitselector[]) nslimitselector.getfiltered(service, option);
      return nslimitselectorArray != null && nslimitselectorArray.Length > 0 ? nslimitselectorArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      nslimitselector nslimitselector = new nslimitselector();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nslimitselector[] nslimitselectorArray = (nslimitselector[]) nslimitselector.getfiltered(service, option);
      return nslimitselectorArray != null && nslimitselectorArray.Length > 0 ? nslimitselectorArray[0].__count.Value : 0U;
    }

    private class nslimitselector_response : base_response
    {
      public nslimitselector[] nslimitselector = (nslimitselector[]) null;
    }
  }
}
