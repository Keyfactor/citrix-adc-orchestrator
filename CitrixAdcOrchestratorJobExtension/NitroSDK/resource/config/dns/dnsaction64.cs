// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.dns.dnsaction64
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.dns
{
  public class dnsaction64 : base_resource
  {
    private string actionnameField = (string) null;
    private string prefixField = (string) null;
    private string mappedruleField = (string) null;
    private string excluderuleField = (string) null;
    private string[] builtinField = (string[]) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string actionname
    {
      get => this.actionnameField;
      set => this.actionnameField = value;
    }

    public string prefix
    {
      get => this.prefixField;
      set => this.prefixField = value;
    }

    public string mappedrule
    {
      get => this.mappedruleField;
      set => this.mappedruleField = value;
    }

    public string excluderule
    {
      get => this.excluderuleField;
      set => this.excluderuleField = value;
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
      dnsaction64.dnsaction64_response dnsaction64Response = new dnsaction64.dnsaction64_response();
      dnsaction64.dnsaction64_response resource = (dnsaction64.dnsaction64_response) service.get_payload_formatter().string_to_resource(dnsaction64Response.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.dnsaction64;
    }

    internal override string get_object_name() => this.actionname;

    public static base_response add(nitro_service client, dnsaction64 resource) => new dnsaction64()
    {
      actionname = resource.actionname,
      prefix = resource.prefix,
      mappedrule = resource.mappedrule,
      excluderule = resource.excluderule
    }.add_resource(client);

    public static base_responses add(nitro_service client, dnsaction64[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnsaction64[] dnsaction64Array = new dnsaction64[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnsaction64Array[index] = new dnsaction64();
          dnsaction64Array[index].actionname = resources[index].actionname;
          dnsaction64Array[index].prefix = resources[index].prefix;
          dnsaction64Array[index].mappedrule = resources[index].mappedrule;
          dnsaction64Array[index].excluderule = resources[index].excluderule;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) dnsaction64Array);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string actionname) => new dnsaction64()
    {
      actionname = actionname
    }.delete_resource(client);

    public static base_response delete(nitro_service client, dnsaction64 resource) => new dnsaction64()
    {
      actionname = resource.actionname
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] actionname)
    {
      base_responses baseResponses = (base_responses) null;
      if (actionname != null && actionname.Length > 0)
      {
        dnsaction64[] dnsaction64Array = new dnsaction64[actionname.Length];
        for (int index = 0; index < actionname.Length; ++index)
        {
          dnsaction64Array[index] = new dnsaction64();
          dnsaction64Array[index].actionname = actionname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dnsaction64Array);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, dnsaction64[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnsaction64[] dnsaction64Array = new dnsaction64[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnsaction64Array[index] = new dnsaction64();
          dnsaction64Array[index].actionname = resources[index].actionname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dnsaction64Array);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, dnsaction64 resource) => new dnsaction64()
    {
      actionname = resource.actionname,
      prefix = resource.prefix,
      mappedrule = resource.mappedrule,
      excluderule = resource.excluderule
    }.update_resource(client);

    public static base_responses update(nitro_service client, dnsaction64[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnsaction64[] dnsaction64Array = new dnsaction64[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnsaction64Array[index] = new dnsaction64();
          dnsaction64Array[index].actionname = resources[index].actionname;
          dnsaction64Array[index].prefix = resources[index].prefix;
          dnsaction64Array[index].mappedrule = resources[index].mappedrule;
          dnsaction64Array[index].excluderule = resources[index].excluderule;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) dnsaction64Array);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string actionname,
      string[] args)
    {
      return new dnsaction64() { actionname = actionname }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      dnsaction64 resource,
      string[] args)
    {
      return new dnsaction64()
      {
        actionname = resource.actionname
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] actionname,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (actionname != null && actionname.Length > 0)
      {
        dnsaction64[] dnsaction64Array = new dnsaction64[actionname.Length];
        for (int index = 0; index < actionname.Length; ++index)
        {
          dnsaction64Array[index] = new dnsaction64();
          dnsaction64Array[index].actionname = actionname[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) dnsaction64Array, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      dnsaction64[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnsaction64[] dnsaction64Array = new dnsaction64[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnsaction64Array[index] = new dnsaction64();
          dnsaction64Array[index].actionname = resources[index].actionname;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) dnsaction64Array, args);
      }
      return baseResponses;
    }

    public static dnsaction64[] get(nitro_service service) => (dnsaction64[]) new dnsaction64().get_resources(service, (options) null);

    public static dnsaction64[] get(nitro_service service, options option) => (dnsaction64[]) new dnsaction64().get_resources(service, option);

    public static dnsaction64 get(nitro_service service, string actionname) => (dnsaction64) new dnsaction64()
    {
      actionname = actionname
    }.get_resource(service);

    public static dnsaction64[] get(nitro_service service, string[] actionname)
    {
      if (actionname == null || actionname.Length <= 0)
        return (dnsaction64[]) null;
      dnsaction64[] dnsaction64Array1 = new dnsaction64[actionname.Length];
      dnsaction64[] dnsaction64Array2 = new dnsaction64[actionname.Length];
      for (int index = 0; index < actionname.Length; ++index)
      {
        dnsaction64Array2[index] = new dnsaction64();
        dnsaction64Array2[index].actionname = actionname[index];
        dnsaction64Array1[index] = (dnsaction64) dnsaction64Array2[index].get_resource(service);
      }
      return dnsaction64Array1;
    }

    public static dnsaction64[] get_filtered(nitro_service service, string filter)
    {
      dnsaction64 dnsaction64 = new dnsaction64();
      options option = new options();
      option.set_filter(filter);
      return (dnsaction64[]) dnsaction64.getfiltered(service, option);
    }

    public static dnsaction64[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      dnsaction64 dnsaction64 = new dnsaction64();
      options option = new options();
      option.set_filter(filter);
      return (dnsaction64[]) dnsaction64.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      dnsaction64 dnsaction64 = new dnsaction64();
      options option = new options();
      option.set_count(true);
      dnsaction64[] resources = (dnsaction64[]) dnsaction64.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      dnsaction64 dnsaction64 = new dnsaction64();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnsaction64[] dnsaction64Array = (dnsaction64[]) dnsaction64.getfiltered(service, option);
      return dnsaction64Array != null && dnsaction64Array.Length > 0 ? dnsaction64Array[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      dnsaction64 dnsaction64 = new dnsaction64();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnsaction64[] dnsaction64Array = (dnsaction64[]) dnsaction64.getfiltered(service, option);
      return dnsaction64Array != null && dnsaction64Array.Length > 0 ? dnsaction64Array[0].__count.Value : 0U;
    }

    private class dnsaction64_response : base_response
    {
      public dnsaction64[] dnsaction64 = (dnsaction64[]) null;
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
