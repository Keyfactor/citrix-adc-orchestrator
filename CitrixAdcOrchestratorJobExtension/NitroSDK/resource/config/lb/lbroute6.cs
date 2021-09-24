// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lb.lbroute6
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.lb
{
  public class lbroute6 : base_resource
  {
    private string networkField = (string) null;
    private string gatewaynameField = (string) null;
    private uint? tdField = new uint?();
    private string flagsField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string network
    {
      get => this.networkField;
      set => this.networkField = value;
    }

    public string gatewayname
    {
      get => this.gatewaynameField;
      set => this.gatewaynameField = value;
    }

    public uint? td
    {
      get => this.tdField;
      set => this.tdField = value;
    }

    public string flags
    {
      get => this.flagsField;
      private set => this.flagsField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lbroute6.lbroute6_response lbroute6Response = new lbroute6.lbroute6_response();
      lbroute6.lbroute6_response resource = (lbroute6.lbroute6_response) service.get_payload_formatter().string_to_resource(lbroute6Response.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lbroute6;
    }

    internal override string get_object_name() => this.network;

    public static base_response add(nitro_service client, lbroute6 resource) => new lbroute6()
    {
      network = resource.network,
      gatewayname = resource.gatewayname,
      td = resource.td
    }.add_resource(client);

    public static base_responses add(nitro_service client, lbroute6[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lbroute6[] lbroute6Array = new lbroute6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lbroute6Array[index] = new lbroute6();
          lbroute6Array[index].network = resources[index].network;
          lbroute6Array[index].gatewayname = resources[index].gatewayname;
          lbroute6Array[index].td = resources[index].td;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) lbroute6Array);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string network) => new lbroute6()
    {
      network = network
    }.delete_resource(client);

    public static base_response delete(nitro_service client, lbroute6 resource) => new lbroute6()
    {
      network = resource.network,
      td = resource.td
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] network)
    {
      base_responses baseResponses = (base_responses) null;
      if (network != null && network.Length > 0)
      {
        lbroute6[] lbroute6Array = new lbroute6[network.Length];
        for (int index = 0; index < network.Length; ++index)
        {
          lbroute6Array[index] = new lbroute6();
          lbroute6Array[index].network = network[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lbroute6Array);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, lbroute6[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lbroute6[] lbroute6Array = new lbroute6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lbroute6Array[index] = new lbroute6();
          lbroute6Array[index].network = resources[index].network;
          lbroute6Array[index].td = resources[index].td;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lbroute6Array);
      }
      return baseResponses;
    }

    public static lbroute6[] get(nitro_service service) => (lbroute6[]) new lbroute6().get_resources(service, (options) null);

    public static lbroute6[] get(nitro_service service, options option) => (lbroute6[]) new lbroute6().get_resources(service, option);

    public static lbroute6 get(nitro_service service, lbroute6 obj)
    {
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (lbroute6) obj.get_resource(service, option);
    }

    public static lbroute6[] get(nitro_service service, lbroute6[] obj)
    {
      if (obj == null || obj.Length <= 0)
        return (lbroute6[]) null;
      lbroute6[] lbroute6Array = new lbroute6[obj.Length];
      for (int index = 0; index < obj.Length; ++index)
      {
        options option = new options();
        option.set_args(nitro_util.object_to_string_withoutquotes((object) obj[index]));
        lbroute6Array[index] = (lbroute6) obj[index].get_resource(service, option);
      }
      return lbroute6Array;
    }

    public static lbroute6[] get_filtered(nitro_service service, string filter)
    {
      lbroute6 lbroute6 = new lbroute6();
      options option = new options();
      option.set_filter(filter);
      return (lbroute6[]) lbroute6.getfiltered(service, option);
    }

    public static lbroute6[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      lbroute6 lbroute6 = new lbroute6();
      options option = new options();
      option.set_filter(filter);
      return (lbroute6[]) lbroute6.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      lbroute6 lbroute6 = new lbroute6();
      options option = new options();
      option.set_count(true);
      lbroute6[] resources = (lbroute6[]) lbroute6.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      lbroute6 lbroute6 = new lbroute6();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lbroute6[] lbroute6Array = (lbroute6[]) lbroute6.getfiltered(service, option);
      return lbroute6Array != null && lbroute6Array.Length > 0 ? lbroute6Array[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      lbroute6 lbroute6 = new lbroute6();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lbroute6[] lbroute6Array = (lbroute6[]) lbroute6.getfiltered(service, option);
      return lbroute6Array != null && lbroute6Array.Length > 0 ? lbroute6Array[0].__count.Value : 0U;
    }

    private class lbroute6_response : base_response
    {
      public lbroute6[] lbroute6 = (lbroute6[]) null;
    }

    public static class flagsEnum
    {
      public const string UP = "UP";
      public const string DOWN = "DOWN";
      public const string UNKNOWN = "UNKNOWN";
      public const string BUSY = "BUSY";
      public const string OUT_OF_SERVICE = "OUT OF SERVICE";
      public const string GOING_OUT_OF_SERVICE = "GOING OUT OF SERVICE";
      public const string DOWN_WHEN_GOING_OUT_OF_SERVICE = "DOWN WHEN GOING OUT OF SERVICE";
      public const string NS_EMPTY_STR = "NS_EMPTY_STR";
      public const string Unknown = "Unknown";
      public const string DISABLED = "DISABLED";
    }
  }
}
