// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.basic.server
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.basic
{
  public class server : base_resource
  {
    private string nameField = (string) null;
    private string ipaddressField = (string) null;
    private string domainField = (string) null;
    private string translationipField = (string) null;
    private string translationmaskField = (string) null;
    private int? domainresolveretryField = new int?();
    private string stateField = (string) null;
    private string ipv6addressField = (string) null;
    private string commentField = (string) null;
    private uint? tdField = new uint?();
    private bool? domainresolvenowField = new bool?();
    private long? delayField = new long?();
    private string gracefulField = (string) null;
    private bool? InternalField = new bool?();
    private string newnameField = (string) null;
    private string statechangetimesecField = (string) null;
    private uint? tickssincelaststatechangeField = new uint?();
    private string autoscaleField = (string) null;
    private string customserveridField = (string) null;
    private uint? monthresholdField = new uint?();
    private uint? maxclientField = new uint?();
    private uint? maxreqField = new uint?();
    private uint? maxbandwidthField = new uint?();
    private string usipField = (string) null;
    private string ckaField = (string) null;
    private string tcpbField = (string) null;
    private string cmpField = (string) null;
    private long? clttimeoutField = new long?();
    private long? svrtimeoutField = new long?();
    private string cipheaderField = (string) null;
    private string cipField = (string) null;
    private string cacheableField = (string) null;
    private string scField = (string) null;
    private string spField = (string) null;
    private string downstateflushField = (string) null;
    private string appflowlogField = (string) null;
    private uint? boundtdField = new uint?();
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

    public string ipaddress
    {
      get => this.ipaddressField;
      set => this.ipaddressField = value;
    }

    public string domain
    {
      get => this.domainField;
      set => this.domainField = value;
    }

    public string translationip
    {
      get => this.translationipField;
      set => this.translationipField = value;
    }

    public string translationmask
    {
      get => this.translationmaskField;
      set => this.translationmaskField = value;
    }

    public int? domainresolveretry
    {
      get => this.domainresolveretryField;
      set => this.domainresolveretryField = value;
    }

    public string state
    {
      get => this.stateField;
      set => this.stateField = value;
    }

    public string ipv6address
    {
      get => this.ipv6addressField;
      set => this.ipv6addressField = value;
    }

    public string comment
    {
      get => this.commentField;
      set => this.commentField = value;
    }

    public uint? td
    {
      get => this.tdField;
      set => this.tdField = value;
    }

    public bool? domainresolvenow
    {
      get => this.domainresolvenowField;
      set => this.domainresolvenowField = value;
    }

    public long? delay
    {
      get => this.delayField;
      set => this.delayField = value;
    }

    public string graceful
    {
      get => this.gracefulField;
      set => this.gracefulField = value;
    }

    public bool? Internal
    {
      get => this.InternalField;
      set => this.InternalField = value;
    }

    public string newname
    {
      get => this.newnameField;
      set => this.newnameField = value;
    }

    public string statechangetimesec
    {
      get => this.statechangetimesecField;
      private set => this.statechangetimesecField = value;
    }

    public uint? tickssincelaststatechange
    {
      get => this.tickssincelaststatechangeField;
      private set => this.tickssincelaststatechangeField = value;
    }

    public string autoscale
    {
      get => this.autoscaleField;
      private set => this.autoscaleField = value;
    }

    public string customserverid
    {
      get => this.customserveridField;
      private set => this.customserveridField = value;
    }

    public uint? monthreshold
    {
      get => this.monthresholdField;
      private set => this.monthresholdField = value;
    }

    public uint? maxclient
    {
      get => this.maxclientField;
      private set => this.maxclientField = value;
    }

    public uint? maxreq
    {
      get => this.maxreqField;
      private set => this.maxreqField = value;
    }

    public uint? maxbandwidth
    {
      get => this.maxbandwidthField;
      private set => this.maxbandwidthField = value;
    }

    public string usip
    {
      get => this.usipField;
      private set => this.usipField = value;
    }

    public string cka
    {
      get => this.ckaField;
      private set => this.ckaField = value;
    }

    public string tcpb
    {
      get => this.tcpbField;
      private set => this.tcpbField = value;
    }

    public string cmp
    {
      get => this.cmpField;
      private set => this.cmpField = value;
    }

    public long? clttimeout
    {
      get => this.clttimeoutField;
      private set => this.clttimeoutField = value;
    }

    public long? svrtimeout
    {
      get => this.svrtimeoutField;
      private set => this.svrtimeoutField = value;
    }

    public string cipheader
    {
      get => this.cipheaderField;
      private set => this.cipheaderField = value;
    }

    public string cip
    {
      get => this.cipField;
      private set => this.cipField = value;
    }

    public string cacheable
    {
      get => this.cacheableField;
      private set => this.cacheableField = value;
    }

    public string sc
    {
      get => this.scField;
      private set => this.scField = value;
    }

    public string sp
    {
      get => this.spField;
      private set => this.spField = value;
    }

    public string downstateflush
    {
      get => this.downstateflushField;
      private set => this.downstateflushField = value;
    }

    public string appflowlog
    {
      get => this.appflowlogField;
      private set => this.appflowlogField = value;
    }

    public uint? boundtd
    {
      get => this.boundtdField;
      private set => this.boundtdField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      server.server_response serverResponse = new server.server_response();
      server.server_response resource = (server.server_response) service.get_payload_formatter().string_to_resource(serverResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.server;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, server resource) => new server()
    {
      name = resource.name,
      ipaddress = resource.ipaddress,
      domain = resource.domain,
      translationip = resource.translationip,
      translationmask = resource.translationmask,
      domainresolveretry = resource.domainresolveretry,
      state = resource.state,
      ipv6address = resource.ipv6address,
      comment = resource.comment,
      td = resource.td
    }.add_resource(client);

    public static base_responses add(nitro_service client, server[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        server[] serverArray = new server[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          serverArray[index] = new server();
          serverArray[index].name = resources[index].name;
          serverArray[index].ipaddress = resources[index].ipaddress;
          serverArray[index].domain = resources[index].domain;
          serverArray[index].translationip = resources[index].translationip;
          serverArray[index].translationmask = resources[index].translationmask;
          serverArray[index].domainresolveretry = resources[index].domainresolveretry;
          serverArray[index].state = resources[index].state;
          serverArray[index].ipv6address = resources[index].ipv6address;
          serverArray[index].comment = resources[index].comment;
          serverArray[index].td = resources[index].td;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) serverArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new server()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, server resource) => new server()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        server[] serverArray = new server[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          serverArray[index] = new server();
          serverArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) serverArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, server[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        server[] serverArray = new server[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          serverArray[index] = new server();
          serverArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) serverArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, server resource) => new server()
    {
      name = resource.name,
      ipaddress = resource.ipaddress,
      domainresolveretry = resource.domainresolveretry,
      translationip = resource.translationip,
      translationmask = resource.translationmask,
      domainresolvenow = resource.domainresolvenow,
      comment = resource.comment
    }.update_resource(client);

    public static base_responses update(nitro_service client, server[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        server[] serverArray = new server[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          serverArray[index] = new server();
          serverArray[index].name = resources[index].name;
          serverArray[index].ipaddress = resources[index].ipaddress;
          serverArray[index].domainresolveretry = resources[index].domainresolveretry;
          serverArray[index].translationip = resources[index].translationip;
          serverArray[index].translationmask = resources[index].translationmask;
          serverArray[index].domainresolvenow = resources[index].domainresolvenow;
          serverArray[index].comment = resources[index].comment;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) serverArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new server() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      server resource,
      string[] args)
    {
      return new server() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        server[] serverArray = new server[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          serverArray[index] = new server();
          serverArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) serverArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      server[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        server[] serverArray = new server[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          serverArray[index] = new server();
          serverArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) serverArray, args);
      }
      return baseResponses;
    }

    public static base_response enable(nitro_service client, string name) => new server()
    {
      name = name
    }.perform_operation_byaction(client, nameof (enable));

    public static base_response enable(nitro_service client, server resource) => new server()
    {
      name = resource.name
    }.perform_operation_byaction(client, nameof (enable));

    public static base_responses enable(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        server[] serverArray = new server[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          serverArray[index] = new server();
          serverArray[index].name = name[index];
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) serverArray, nameof (enable));
      }
      return baseResponses;
    }

    public static base_responses enable(nitro_service client, server[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        server[] serverArray = new server[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          serverArray[index] = new server();
          serverArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) serverArray, nameof (enable));
      }
      return baseResponses;
    }

    public static base_response disable(nitro_service client, string name) => new server()
    {
      name = name
    }.perform_operation_byaction(client, nameof (disable));

    public static base_response disable(nitro_service client, server resource) => new server()
    {
      name = resource.name,
      delay = resource.delay,
      graceful = resource.graceful
    }.perform_operation_byaction(client, nameof (disable));

    public static base_responses disable(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        server[] serverArray = new server[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          serverArray[index] = new server();
          serverArray[index].name = name[index];
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) serverArray, nameof (disable));
      }
      return baseResponses;
    }

    public static base_responses disable(nitro_service client, server[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        server[] serverArray = new server[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          serverArray[index] = new server();
          serverArray[index].name = resources[index].name;
          serverArray[index].delay = resources[index].delay;
          serverArray[index].graceful = resources[index].graceful;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) serverArray, nameof (disable));
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      server resource,
      string new_name)
    {
      return new server()
      {
        name = resource.name,
        newname = new_name
      }.rename_resource(client);
    }

    public static base_response rename(
      nitro_service client,
      string name,
      string new_name)
    {
      return new server()
      {
        name = name,
        newname = new_name
      }.rename_resource(client);
    }

    public static server[] get(nitro_service service) => (server[]) new server().get_resources(service, (options) null);

    public static server[] get(nitro_service service, options option) => (server[]) new server().get_resources(service, option);

    public static server[] get(nitro_service service, server_args args)
    {
      server server = new server();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (server[]) server.get_resources(service, option);
    }

    public static server get(nitro_service service, string name) => (server) new server()
    {
      name = name
    }.get_resource(service);

    public static server[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (server[]) null;
      server[] serverArray1 = new server[name.Length];
      server[] serverArray2 = new server[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        serverArray2[index] = new server();
        serverArray2[index].name = name[index];
        serverArray1[index] = (server) serverArray2[index].get_resource(service);
      }
      return serverArray1;
    }

    public static server[] get_filtered(nitro_service service, string filter)
    {
      server server = new server();
      options option = new options();
      option.set_filter(filter);
      return (server[]) server.getfiltered(service, option);
    }

    public static server[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      server server = new server();
      options option = new options();
      option.set_filter(filter);
      return (server[]) server.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      server server = new server();
      options option = new options();
      option.set_count(true);
      server[] resources = (server[]) server.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      server server = new server();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      server[] serverArray = (server[]) server.getfiltered(service, option);
      return serverArray != null && serverArray.Length > 0 ? serverArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      server server = new server();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      server[] serverArray = (server[]) server.getfiltered(service, option);
      return serverArray != null && serverArray.Length > 0 ? serverArray[0].__count.Value : 0U;
    }

    private class server_response : base_response
    {
      public server[] server = (server[]) null;
    }

    public static class spEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class scEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class stateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class downstateflushEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class ipv6addressEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class usipEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class cacheableEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class autoscaleEnum
    {
      public const string DISABLED = "DISABLED";
      public const string DNS = "DNS";
      public const string POLICY = "POLICY";
    }

    public static class tcpbEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class cipEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class ckaEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class appflowlogEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class cmpEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class gracefulEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }
  }
}
