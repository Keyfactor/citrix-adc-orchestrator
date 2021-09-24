// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.dns.dnspolicy64
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.dns
{
  public class dnspolicy64 : base_resource
  {
    private string nameField = (string) null;
    private string ruleField = (string) null;
    private string actionField = (string) null;
    private long? hitsField = new long?();
    private string labeltypeField = (string) null;
    private string labelnameField = (string) null;
    private long? undefhitsField = new long?();
    private string descriptionField = (string) null;
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

    public string action
    {
      get => this.actionField;
      set => this.actionField = value;
    }

    public long? hits
    {
      get => this.hitsField;
      private set => this.hitsField = value;
    }

    public string labeltype
    {
      get => this.labeltypeField;
      private set => this.labeltypeField = value;
    }

    public string labelname
    {
      get => this.labelnameField;
      private set => this.labelnameField = value;
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

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      dnspolicy64.dnspolicy64_response dnspolicy64Response = new dnspolicy64.dnspolicy64_response();
      dnspolicy64.dnspolicy64_response resource = (dnspolicy64.dnspolicy64_response) service.get_payload_formatter().string_to_resource(dnspolicy64Response.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.dnspolicy64;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, dnspolicy64 resource) => new dnspolicy64()
    {
      name = resource.name,
      rule = resource.rule,
      action = resource.action
    }.add_resource(client);

    public static base_responses add(nitro_service client, dnspolicy64[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnspolicy64[] dnspolicy64Array = new dnspolicy64[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnspolicy64Array[index] = new dnspolicy64();
          dnspolicy64Array[index].name = resources[index].name;
          dnspolicy64Array[index].rule = resources[index].rule;
          dnspolicy64Array[index].action = resources[index].action;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) dnspolicy64Array);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new dnspolicy64()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, dnspolicy64 resource) => new dnspolicy64()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        dnspolicy64[] dnspolicy64Array = new dnspolicy64[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          dnspolicy64Array[index] = new dnspolicy64();
          dnspolicy64Array[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dnspolicy64Array);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, dnspolicy64[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnspolicy64[] dnspolicy64Array = new dnspolicy64[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnspolicy64Array[index] = new dnspolicy64();
          dnspolicy64Array[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dnspolicy64Array);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, dnspolicy64 resource) => new dnspolicy64()
    {
      name = resource.name,
      rule = resource.rule,
      action = resource.action
    }.update_resource(client);

    public static base_responses update(nitro_service client, dnspolicy64[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnspolicy64[] dnspolicy64Array = new dnspolicy64[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnspolicy64Array[index] = new dnspolicy64();
          dnspolicy64Array[index].name = resources[index].name;
          dnspolicy64Array[index].rule = resources[index].rule;
          dnspolicy64Array[index].action = resources[index].action;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) dnspolicy64Array);
      }
      return baseResponses;
    }

    public static dnspolicy64[] get(nitro_service service) => (dnspolicy64[]) new dnspolicy64().get_resources(service, (options) null);

    public static dnspolicy64[] get(nitro_service service, options option) => (dnspolicy64[]) new dnspolicy64().get_resources(service, option);

    public static dnspolicy64 get(nitro_service service, string name) => (dnspolicy64) new dnspolicy64()
    {
      name = name
    }.get_resource(service);

    public static dnspolicy64[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (dnspolicy64[]) null;
      dnspolicy64[] dnspolicy64Array1 = new dnspolicy64[name.Length];
      dnspolicy64[] dnspolicy64Array2 = new dnspolicy64[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        dnspolicy64Array2[index] = new dnspolicy64();
        dnspolicy64Array2[index].name = name[index];
        dnspolicy64Array1[index] = (dnspolicy64) dnspolicy64Array2[index].get_resource(service);
      }
      return dnspolicy64Array1;
    }

    public static dnspolicy64[] get_filtered(nitro_service service, string filter)
    {
      dnspolicy64 dnspolicy64 = new dnspolicy64();
      options option = new options();
      option.set_filter(filter);
      return (dnspolicy64[]) dnspolicy64.getfiltered(service, option);
    }

    public static dnspolicy64[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      dnspolicy64 dnspolicy64 = new dnspolicy64();
      options option = new options();
      option.set_filter(filter);
      return (dnspolicy64[]) dnspolicy64.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      dnspolicy64 dnspolicy64 = new dnspolicy64();
      options option = new options();
      option.set_count(true);
      dnspolicy64[] resources = (dnspolicy64[]) dnspolicy64.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      dnspolicy64 dnspolicy64 = new dnspolicy64();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnspolicy64[] dnspolicy64Array = (dnspolicy64[]) dnspolicy64.getfiltered(service, option);
      return dnspolicy64Array != null && dnspolicy64Array.Length > 0 ? dnspolicy64Array[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      dnspolicy64 dnspolicy64 = new dnspolicy64();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnspolicy64[] dnspolicy64Array = (dnspolicy64[]) dnspolicy64.getfiltered(service, option);
      return dnspolicy64Array != null && dnspolicy64Array.Length > 0 ? dnspolicy64Array[0].__count.Value : 0U;
    }

    private class dnspolicy64_response : base_response
    {
      public dnspolicy64[] dnspolicy64 = (dnspolicy64[]) null;
    }

    public static class labeltypeEnum
    {
      public const string reqvserver = "reqvserver";
      public const string resvserver = "resvserver";
      public const string policylabel = "policylabel";
    }
  }
}
