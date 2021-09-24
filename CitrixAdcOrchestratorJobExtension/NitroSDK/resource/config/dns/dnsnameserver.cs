// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.dns.dnsnameserver
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.dns
{
  public class dnsnameserver : base_resource
  {
    private string ipField = (string) null;
    private string dnsvservernameField = (string) null;
    private bool? localField = new bool?();
    private string stateField = (string) null;
    private string typeField = (string) null;
    private string dnsprofilenameField = (string) null;
    private string servicenameField = (string) null;
    private ushort? portField = new ushort?();
    private string nameserverstateField = (string) null;
    private uint? clmonownerField = new uint?();
    private uint? clmonviewField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string ip
    {
      get => this.ipField;
      set => this.ipField = value;
    }

    public string dnsvservername
    {
      get => this.dnsvservernameField;
      set => this.dnsvservernameField = value;
    }

    public bool? local
    {
      get => this.localField;
      set => this.localField = value;
    }

    public string state
    {
      get => this.stateField;
      set => this.stateField = value;
    }

    public string type
    {
      get => this.typeField;
      set => this.typeField = value;
    }

    public string dnsprofilename
    {
      get => this.dnsprofilenameField;
      set => this.dnsprofilenameField = value;
    }

    public string servicename
    {
      get => this.servicenameField;
      private set => this.servicenameField = value;
    }

    public ushort? port
    {
      get => this.portField;
      private set => this.portField = value;
    }

    public string nameserverstate
    {
      get => this.nameserverstateField;
      private set => this.nameserverstateField = value;
    }

    public uint? clmonowner
    {
      get => this.clmonownerField;
      private set => this.clmonownerField = value;
    }

    public uint? clmonview
    {
      get => this.clmonviewField;
      private set => this.clmonviewField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      dnsnameserver.dnsnameserver_response dnsnameserverResponse = new dnsnameserver.dnsnameserver_response();
      dnsnameserver.dnsnameserver_response resource = (dnsnameserver.dnsnameserver_response) service.get_payload_formatter().string_to_resource(dnsnameserverResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.dnsnameserver;
    }

    internal override string get_object_name() => this.ip;

    public static base_response add(nitro_service client, dnsnameserver resource) => new dnsnameserver()
    {
      ip = resource.ip,
      dnsvservername = resource.dnsvservername,
      local = resource.local,
      state = resource.state,
      type = resource.type,
      dnsprofilename = resource.dnsprofilename
    }.add_resource(client);

    public static base_responses add(nitro_service client, dnsnameserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnsnameserver[] dnsnameserverArray = new dnsnameserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnsnameserverArray[index] = new dnsnameserver();
          dnsnameserverArray[index].ip = resources[index].ip;
          dnsnameserverArray[index].dnsvservername = resources[index].dnsvservername;
          dnsnameserverArray[index].local = resources[index].local;
          dnsnameserverArray[index].state = resources[index].state;
          dnsnameserverArray[index].type = resources[index].type;
          dnsnameserverArray[index].dnsprofilename = resources[index].dnsprofilename;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) dnsnameserverArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, dnsnameserver resource) => new dnsnameserver()
    {
      ip = resource.ip,
      dnsprofilename = resource.dnsprofilename
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      dnsnameserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnsnameserver[] dnsnameserverArray = new dnsnameserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnsnameserverArray[index] = new dnsnameserver();
          dnsnameserverArray[index].ip = resources[index].ip;
          dnsnameserverArray[index].dnsprofilename = resources[index].dnsprofilename;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) dnsnameserverArray);
      }
      return baseResponses;
    }

    public static base_response unset(nitro_service client, string ip, string[] args) => new dnsnameserver()
    {
      ip = ip
    }.unset_resource(client, args);

    public static base_response unset(
      nitro_service client,
      dnsnameserver resource,
      string[] args)
    {
      return new dnsnameserver() { ip = resource.ip }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] ip,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (ip != null && ip.Length > 0)
      {
        dnsnameserver[] dnsnameserverArray = new dnsnameserver[ip.Length];
        for (int index = 0; index < ip.Length; ++index)
        {
          dnsnameserverArray[index] = new dnsnameserver();
          dnsnameserverArray[index].ip = ip[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) dnsnameserverArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      dnsnameserver[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnsnameserver[] dnsnameserverArray = new dnsnameserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnsnameserverArray[index] = new dnsnameserver();
          dnsnameserverArray[index].ip = resources[index].ip;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) dnsnameserverArray, args);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string ip) => new dnsnameserver()
    {
      ip = ip
    }.delete_resource(client);

    public static base_response delete(nitro_service client, dnsnameserver resource) => new dnsnameserver()
    {
      ip = resource.ip,
      dnsvservername = resource.dnsvservername
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] ip)
    {
      base_responses baseResponses = (base_responses) null;
      if (ip != null && ip.Length > 0)
      {
        dnsnameserver[] dnsnameserverArray = new dnsnameserver[ip.Length];
        for (int index = 0; index < ip.Length; ++index)
        {
          dnsnameserverArray[index] = new dnsnameserver();
          dnsnameserverArray[index].ip = ip[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dnsnameserverArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      dnsnameserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnsnameserver[] dnsnameserverArray = new dnsnameserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnsnameserverArray[index] = new dnsnameserver();
          dnsnameserverArray[index].ip = resources[index].ip;
          dnsnameserverArray[index].dnsvservername = resources[index].dnsvservername;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dnsnameserverArray);
      }
      return baseResponses;
    }

    public static base_response enable(nitro_service client, string ip) => new dnsnameserver()
    {
      ip = ip
    }.perform_operation_byaction(client, nameof (enable));

    public static base_response enable(nitro_service client, dnsnameserver resource) => new dnsnameserver()
    {
      ip = resource.ip,
      dnsvservername = resource.dnsvservername
    }.perform_operation_byaction(client, nameof (enable));

    public static base_responses enable(nitro_service client, string[] ip)
    {
      base_responses baseResponses = (base_responses) null;
      if (ip != null && ip.Length > 0)
      {
        dnsnameserver[] dnsnameserverArray = new dnsnameserver[ip.Length];
        for (int index = 0; index < ip.Length; ++index)
        {
          dnsnameserverArray[index] = new dnsnameserver();
          dnsnameserverArray[index].ip = ip[index];
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) dnsnameserverArray, nameof (enable));
      }
      return baseResponses;
    }

    public static base_responses enable(
      nitro_service client,
      dnsnameserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnsnameserver[] dnsnameserverArray = new dnsnameserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnsnameserverArray[index] = new dnsnameserver();
          dnsnameserverArray[index].ip = resources[index].ip;
          dnsnameserverArray[index].dnsvservername = resources[index].dnsvservername;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) dnsnameserverArray, nameof (enable));
      }
      return baseResponses;
    }

    public static base_response disable(nitro_service client, string ip) => new dnsnameserver()
    {
      ip = ip
    }.perform_operation_byaction(client, nameof (disable));

    public static base_response disable(nitro_service client, dnsnameserver resource) => new dnsnameserver()
    {
      ip = resource.ip,
      dnsvservername = resource.dnsvservername
    }.perform_operation_byaction(client, nameof (disable));

    public static base_responses disable(nitro_service client, string[] ip)
    {
      base_responses baseResponses = (base_responses) null;
      if (ip != null && ip.Length > 0)
      {
        dnsnameserver[] dnsnameserverArray = new dnsnameserver[ip.Length];
        for (int index = 0; index < ip.Length; ++index)
        {
          dnsnameserverArray[index] = new dnsnameserver();
          dnsnameserverArray[index].ip = ip[index];
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) dnsnameserverArray, nameof (disable));
      }
      return baseResponses;
    }

    public static base_responses disable(
      nitro_service client,
      dnsnameserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnsnameserver[] dnsnameserverArray = new dnsnameserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnsnameserverArray[index] = new dnsnameserver();
          dnsnameserverArray[index].ip = resources[index].ip;
          dnsnameserverArray[index].dnsvservername = resources[index].dnsvservername;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) dnsnameserverArray, nameof (disable));
      }
      return baseResponses;
    }

    public static dnsnameserver[] get(nitro_service service) => (dnsnameserver[]) new dnsnameserver().get_resources(service, (options) null);

    public static dnsnameserver[] get(nitro_service service, options option) => (dnsnameserver[]) new dnsnameserver().get_resources(service, option);

    public static dnsnameserver get(nitro_service service, dnsnameserver obj)
    {
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (dnsnameserver) obj.get_resource(service, option);
    }

    public static dnsnameserver[] get(nitro_service service, dnsnameserver[] obj)
    {
      if (obj == null || obj.Length <= 0)
        return (dnsnameserver[]) null;
      dnsnameserver[] dnsnameserverArray = new dnsnameserver[obj.Length];
      for (int index = 0; index < obj.Length; ++index)
      {
        options option = new options();
        option.set_args(nitro_util.object_to_string_withoutquotes((object) obj[index]));
        dnsnameserverArray[index] = (dnsnameserver) obj[index].get_resource(service, option);
      }
      return dnsnameserverArray;
    }

    public static dnsnameserver[] get_filtered(nitro_service service, string filter)
    {
      dnsnameserver dnsnameserver = new dnsnameserver();
      options option = new options();
      option.set_filter(filter);
      return (dnsnameserver[]) dnsnameserver.getfiltered(service, option);
    }

    public static dnsnameserver[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      dnsnameserver dnsnameserver = new dnsnameserver();
      options option = new options();
      option.set_filter(filter);
      return (dnsnameserver[]) dnsnameserver.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      dnsnameserver dnsnameserver = new dnsnameserver();
      options option = new options();
      option.set_count(true);
      dnsnameserver[] resources = (dnsnameserver[]) dnsnameserver.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      dnsnameserver dnsnameserver = new dnsnameserver();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnsnameserver[] dnsnameserverArray = (dnsnameserver[]) dnsnameserver.getfiltered(service, option);
      return dnsnameserverArray != null && dnsnameserverArray.Length > 0 ? dnsnameserverArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      dnsnameserver dnsnameserver = new dnsnameserver();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnsnameserver[] dnsnameserverArray = (dnsnameserver[]) dnsnameserver.getfiltered(service, option);
      return dnsnameserverArray != null && dnsnameserverArray.Length > 0 ? dnsnameserverArray[0].__count.Value : 0U;
    }

    private class dnsnameserver_response : base_response
    {
      public dnsnameserver[] dnsnameserver = (dnsnameserver[]) null;
    }

    public static class stateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class typeEnum
    {
      public const string UDP = "UDP";
      public const string TCP = "TCP";
      public const string UDP_TCP = "UDP_TCP";
    }

    public static class nameserverstateEnum
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
