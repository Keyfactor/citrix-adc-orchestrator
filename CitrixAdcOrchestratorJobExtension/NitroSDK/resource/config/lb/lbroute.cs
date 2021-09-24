// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lb.lbroute
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.lb
{
  public class lbroute : base_resource
  {
    private string networkField = (string) null;
    private string netmaskField = (string) null;
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

    public string netmask
    {
      get => this.netmaskField;
      set => this.netmaskField = value;
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
      lbroute.lbroute_response lbrouteResponse = new lbroute.lbroute_response();
      lbroute.lbroute_response resource = (lbroute.lbroute_response) service.get_payload_formatter().string_to_resource(lbrouteResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lbroute;
    }

    internal override string get_object_name() => this.network;

    public static base_response add(nitro_service client, lbroute resource) => new lbroute()
    {
      network = resource.network,
      netmask = resource.netmask,
      gatewayname = resource.gatewayname,
      td = resource.td
    }.add_resource(client);

    public static base_responses add(nitro_service client, lbroute[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lbroute[] lbrouteArray = new lbroute[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lbrouteArray[index] = new lbroute();
          lbrouteArray[index].network = resources[index].network;
          lbrouteArray[index].netmask = resources[index].netmask;
          lbrouteArray[index].gatewayname = resources[index].gatewayname;
          lbrouteArray[index].td = resources[index].td;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) lbrouteArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string network) => new lbroute()
    {
      network = network
    }.delete_resource(client);

    public static base_response delete(nitro_service client, lbroute resource) => new lbroute()
    {
      network = resource.network,
      netmask = resource.netmask,
      td = resource.td
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] network)
    {
      base_responses baseResponses = (base_responses) null;
      if (network != null && network.Length > 0)
      {
        lbroute[] lbrouteArray = new lbroute[network.Length];
        for (int index = 0; index < network.Length; ++index)
        {
          lbrouteArray[index] = new lbroute();
          lbrouteArray[index].network = network[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lbrouteArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, lbroute[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lbroute[] lbrouteArray = new lbroute[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lbrouteArray[index] = new lbroute();
          lbrouteArray[index].network = resources[index].network;
          lbrouteArray[index].netmask = resources[index].netmask;
          lbrouteArray[index].td = resources[index].td;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lbrouteArray);
      }
      return baseResponses;
    }

    public static lbroute[] get(nitro_service service) => (lbroute[]) new lbroute().get_resources(service, (options) null);

    public static lbroute[] get(nitro_service service, options option) => (lbroute[]) new lbroute().get_resources(service, option);

    public static lbroute get(nitro_service service, lbroute obj)
    {
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (lbroute) obj.get_resource(service, option);
    }

    public static lbroute[] get(nitro_service service, lbroute[] obj)
    {
      if (obj == null || obj.Length <= 0)
        return (lbroute[]) null;
      lbroute[] lbrouteArray = new lbroute[obj.Length];
      for (int index = 0; index < obj.Length; ++index)
      {
        options option = new options();
        option.set_args(nitro_util.object_to_string_withoutquotes((object) obj[index]));
        lbrouteArray[index] = (lbroute) obj[index].get_resource(service, option);
      }
      return lbrouteArray;
    }

    public static lbroute[] get_filtered(nitro_service service, string filter)
    {
      lbroute lbroute = new lbroute();
      options option = new options();
      option.set_filter(filter);
      return (lbroute[]) lbroute.getfiltered(service, option);
    }

    public static lbroute[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      lbroute lbroute = new lbroute();
      options option = new options();
      option.set_filter(filter);
      return (lbroute[]) lbroute.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      lbroute lbroute = new lbroute();
      options option = new options();
      option.set_count(true);
      lbroute[] resources = (lbroute[]) lbroute.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      lbroute lbroute = new lbroute();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lbroute[] lbrouteArray = (lbroute[]) lbroute.getfiltered(service, option);
      return lbrouteArray != null && lbrouteArray.Length > 0 ? lbrouteArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      lbroute lbroute = new lbroute();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lbroute[] lbrouteArray = (lbroute[]) lbroute.getfiltered(service, option);
      return lbrouteArray != null && lbrouteArray.Length > 0 ? lbrouteArray[0].__count.Value : 0U;
    }

    private class lbroute_response : base_response
    {
      public lbroute[] lbroute = (lbroute[]) null;
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
