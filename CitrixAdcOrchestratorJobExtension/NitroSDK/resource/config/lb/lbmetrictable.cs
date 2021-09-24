// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lb.lbmetrictable
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.lb
{
  public class lbmetrictable : base_resource
  {
    private string metrictableField = (string) null;
    private string metricField = (string) null;
    private string SnmpoidField = (string) null;
    private string metrictypeField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string metrictable
    {
      get => this.metrictableField;
      set => this.metrictableField = value;
    }

    public string metric
    {
      get => this.metricField;
      set => this.metricField = value;
    }

    public string Snmpoid
    {
      get => this.SnmpoidField;
      set => this.SnmpoidField = value;
    }

    public string metrictype
    {
      get => this.metrictypeField;
      private set => this.metrictypeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lbmetrictable.lbmetrictable_response lbmetrictableResponse = new lbmetrictable.lbmetrictable_response();
      lbmetrictable.lbmetrictable_response resource = (lbmetrictable.lbmetrictable_response) service.get_payload_formatter().string_to_resource(lbmetrictableResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lbmetrictable;
    }

    internal override string get_object_name() => this.metrictable;

    public static base_response add(nitro_service client, lbmetrictable resource) => new lbmetrictable()
    {
      metrictable = resource.metrictable
    }.add_resource(client);

    public static base_responses add(nitro_service client, lbmetrictable[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lbmetrictable[] lbmetrictableArray = new lbmetrictable[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lbmetrictableArray[index] = new lbmetrictable();
          lbmetrictableArray[index].metrictable = resources[index].metrictable;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) lbmetrictableArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string metrictable) => new lbmetrictable()
    {
      metrictable = metrictable
    }.delete_resource(client);

    public static base_response delete(nitro_service client, lbmetrictable resource) => new lbmetrictable()
    {
      metrictable = resource.metrictable
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] metrictable)
    {
      base_responses baseResponses = (base_responses) null;
      if (metrictable != null && metrictable.Length > 0)
      {
        lbmetrictable[] lbmetrictableArray = new lbmetrictable[metrictable.Length];
        for (int index = 0; index < metrictable.Length; ++index)
        {
          lbmetrictableArray[index] = new lbmetrictable();
          lbmetrictableArray[index].metrictable = metrictable[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lbmetrictableArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      lbmetrictable[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lbmetrictable[] lbmetrictableArray = new lbmetrictable[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lbmetrictableArray[index] = new lbmetrictable();
          lbmetrictableArray[index].metrictable = resources[index].metrictable;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lbmetrictableArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, lbmetrictable resource) => new lbmetrictable()
    {
      metrictable = resource.metrictable,
      metric = resource.metric,
      Snmpoid = resource.Snmpoid
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      lbmetrictable[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lbmetrictable[] lbmetrictableArray = new lbmetrictable[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lbmetrictableArray[index] = new lbmetrictable();
          lbmetrictableArray[index].metrictable = resources[index].metrictable;
          lbmetrictableArray[index].metric = resources[index].metric;
          lbmetrictableArray[index].Snmpoid = resources[index].Snmpoid;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) lbmetrictableArray);
      }
      return baseResponses;
    }

    public static lbmetrictable[] get(nitro_service service) => (lbmetrictable[]) new lbmetrictable().get_resources(service, (options) null);

    public static lbmetrictable[] get(nitro_service service, options option) => (lbmetrictable[]) new lbmetrictable().get_resources(service, option);

    public static lbmetrictable get(nitro_service service, string metrictable) => (lbmetrictable) new lbmetrictable()
    {
      metrictable = metrictable
    }.get_resource(service);

    public static lbmetrictable[] get(nitro_service service, string[] metrictable)
    {
      if (metrictable == null || metrictable.Length <= 0)
        return (lbmetrictable[]) null;
      lbmetrictable[] lbmetrictableArray1 = new lbmetrictable[metrictable.Length];
      lbmetrictable[] lbmetrictableArray2 = new lbmetrictable[metrictable.Length];
      for (int index = 0; index < metrictable.Length; ++index)
      {
        lbmetrictableArray2[index] = new lbmetrictable();
        lbmetrictableArray2[index].metrictable = metrictable[index];
        lbmetrictableArray1[index] = (lbmetrictable) lbmetrictableArray2[index].get_resource(service);
      }
      return lbmetrictableArray1;
    }

    public static lbmetrictable[] get_filtered(nitro_service service, string filter)
    {
      lbmetrictable lbmetrictable = new lbmetrictable();
      options option = new options();
      option.set_filter(filter);
      return (lbmetrictable[]) lbmetrictable.getfiltered(service, option);
    }

    public static lbmetrictable[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      lbmetrictable lbmetrictable = new lbmetrictable();
      options option = new options();
      option.set_filter(filter);
      return (lbmetrictable[]) lbmetrictable.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      lbmetrictable lbmetrictable = new lbmetrictable();
      options option = new options();
      option.set_count(true);
      lbmetrictable[] resources = (lbmetrictable[]) lbmetrictable.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      lbmetrictable lbmetrictable = new lbmetrictable();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lbmetrictable[] lbmetrictableArray = (lbmetrictable[]) lbmetrictable.getfiltered(service, option);
      return lbmetrictableArray != null && lbmetrictableArray.Length > 0 ? lbmetrictableArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      lbmetrictable lbmetrictable = new lbmetrictable();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lbmetrictable[] lbmetrictableArray = (lbmetrictable[]) lbmetrictable.getfiltered(service, option);
      return lbmetrictableArray != null && lbmetrictableArray.Length > 0 ? lbmetrictableArray[0].__count.Value : 0U;
    }

    private class lbmetrictable_response : base_response
    {
      public lbmetrictable[] lbmetrictable = (lbmetrictable[]) null;
    }

    public static class metrictypeEnum
    {
      public const string INTERNAL = "INTERNAL";
      public const string CONFIGURED = "CONFIGURED";
    }
  }
}
