// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cache.cacheselector
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.cache
{
  public class cacheselector : base_resource
  {
    private string selectornameField = (string) null;
    private string[] ruleField = (string[]) null;
    private uint? flagsField = new uint?();
    private string[] builtinField = (string[]) null;
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
      cacheselector.cacheselector_response cacheselectorResponse = new cacheselector.cacheselector_response();
      cacheselector.cacheselector_response resource = (cacheselector.cacheselector_response) service.get_payload_formatter().string_to_resource(cacheselectorResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.cacheselector;
    }

    internal override string get_object_name() => this.selectorname;

    public static base_response add(nitro_service client, cacheselector resource) => new cacheselector()
    {
      selectorname = resource.selectorname,
      rule = resource.rule
    }.add_resource(client);

    public static base_responses add(nitro_service client, cacheselector[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        cacheselector[] cacheselectorArray = new cacheselector[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          cacheselectorArray[index] = new cacheselector();
          cacheselectorArray[index].selectorname = resources[index].selectorname;
          cacheselectorArray[index].rule = resources[index].rule;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) cacheselectorArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string selectorname) => new cacheselector()
    {
      selectorname = selectorname
    }.delete_resource(client);

    public static base_response delete(nitro_service client, cacheselector resource) => new cacheselector()
    {
      selectorname = resource.selectorname
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] selectorname)
    {
      base_responses baseResponses = (base_responses) null;
      if (selectorname != null && selectorname.Length > 0)
      {
        cacheselector[] cacheselectorArray = new cacheselector[selectorname.Length];
        for (int index = 0; index < selectorname.Length; ++index)
        {
          cacheselectorArray[index] = new cacheselector();
          cacheselectorArray[index].selectorname = selectorname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) cacheselectorArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      cacheselector[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        cacheselector[] cacheselectorArray = new cacheselector[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          cacheselectorArray[index] = new cacheselector();
          cacheselectorArray[index].selectorname = resources[index].selectorname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) cacheselectorArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, cacheselector resource) => new cacheselector()
    {
      selectorname = resource.selectorname,
      rule = resource.rule
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      cacheselector[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        cacheselector[] cacheselectorArray = new cacheselector[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          cacheselectorArray[index] = new cacheselector();
          cacheselectorArray[index].selectorname = resources[index].selectorname;
          cacheselectorArray[index].rule = resources[index].rule;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) cacheselectorArray);
      }
      return baseResponses;
    }

    public static cacheselector[] get(nitro_service service) => (cacheselector[]) new cacheselector().get_resources(service, (options) null);

    public static cacheselector[] get(nitro_service service, options option) => (cacheselector[]) new cacheselector().get_resources(service, option);

    public static cacheselector get(nitro_service service, string selectorname) => (cacheselector) new cacheselector()
    {
      selectorname = selectorname
    }.get_resource(service);

    public static cacheselector[] get(nitro_service service, string[] selectorname)
    {
      if (selectorname == null || selectorname.Length <= 0)
        return (cacheselector[]) null;
      cacheselector[] cacheselectorArray1 = new cacheselector[selectorname.Length];
      cacheselector[] cacheselectorArray2 = new cacheselector[selectorname.Length];
      for (int index = 0; index < selectorname.Length; ++index)
      {
        cacheselectorArray2[index] = new cacheselector();
        cacheselectorArray2[index].selectorname = selectorname[index];
        cacheselectorArray1[index] = (cacheselector) cacheselectorArray2[index].get_resource(service);
      }
      return cacheselectorArray1;
    }

    public static cacheselector[] get_filtered(nitro_service service, string filter)
    {
      cacheselector cacheselector = new cacheselector();
      options option = new options();
      option.set_filter(filter);
      return (cacheselector[]) cacheselector.getfiltered(service, option);
    }

    public static cacheselector[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      cacheselector cacheselector = new cacheselector();
      options option = new options();
      option.set_filter(filter);
      return (cacheselector[]) cacheselector.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      cacheselector cacheselector = new cacheselector();
      options option = new options();
      option.set_count(true);
      cacheselector[] resources = (cacheselector[]) cacheselector.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      cacheselector cacheselector = new cacheselector();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      cacheselector[] cacheselectorArray = (cacheselector[]) cacheselector.getfiltered(service, option);
      return cacheselectorArray != null && cacheselectorArray.Length > 0 ? cacheselectorArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      cacheselector cacheselector = new cacheselector();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      cacheselector[] cacheselectorArray = (cacheselector[]) cacheselector.getfiltered(service, option);
      return cacheselectorArray != null && cacheselectorArray.Length > 0 ? cacheselectorArray[0].__count.Value : 0U;
    }

    private class cacheselector_response : base_response
    {
      public cacheselector[] cacheselector = (cacheselector[]) null;
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
