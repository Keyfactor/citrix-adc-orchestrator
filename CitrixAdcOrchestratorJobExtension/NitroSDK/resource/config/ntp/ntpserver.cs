// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ntp.ntpserver
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ntp
{
  public class ntpserver : base_resource
  {
    private string serveripField = (string) null;
    private string servernameField = (string) null;
    private uint? minpollField = new uint?();
    private uint? maxpollField = new uint?();
    private bool? autokeyField = new bool?();
    private uint? keyField = new uint?();
    private string preferredntpserverField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string serverip
    {
      get => this.serveripField;
      set => this.serveripField = value;
    }

    public string servername
    {
      get => this.servernameField;
      set => this.servernameField = value;
    }

    public uint? minpoll
    {
      get => this.minpollField;
      set => this.minpollField = value;
    }

    public uint? maxpoll
    {
      get => this.maxpollField;
      set => this.maxpollField = value;
    }

    public bool? autokey
    {
      get => this.autokeyField;
      set => this.autokeyField = value;
    }

    public uint? key
    {
      get => this.keyField;
      set => this.keyField = value;
    }

    public string preferredntpserver
    {
      get => this.preferredntpserverField;
      set => this.preferredntpserverField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      ntpserver.ntpserver_response ntpserverResponse = new ntpserver.ntpserver_response();
      ntpserver.ntpserver_response resource = (ntpserver.ntpserver_response) service.get_payload_formatter().string_to_resource(ntpserverResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.ntpserver;
    }

    internal override string get_object_name() => this.serverip;

    public static base_response add(nitro_service client, ntpserver resource) => new ntpserver()
    {
      serverip = resource.serverip,
      servername = resource.servername,
      minpoll = resource.minpoll,
      maxpoll = resource.maxpoll,
      autokey = resource.autokey,
      key = resource.key
    }.add_resource(client);

    public static base_responses add(nitro_service client, ntpserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        ntpserver[] ntpserverArray = new ntpserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          ntpserverArray[index] = new ntpserver();
          ntpserverArray[index].serverip = resources[index].serverip;
          ntpserverArray[index].servername = resources[index].servername;
          ntpserverArray[index].minpoll = resources[index].minpoll;
          ntpserverArray[index].maxpoll = resources[index].maxpoll;
          ntpserverArray[index].autokey = resources[index].autokey;
          ntpserverArray[index].key = resources[index].key;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) ntpserverArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string serverip) => new ntpserver()
    {
      serverip = serverip
    }.delete_resource(client);

    public static base_response delete(nitro_service client, ntpserver resource) => new ntpserver()
    {
      serverip = resource.serverip,
      servername = resource.servername
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] serverip)
    {
      base_responses baseResponses = (base_responses) null;
      if (serverip != null && serverip.Length > 0)
      {
        ntpserver[] ntpserverArray = new ntpserver[serverip.Length];
        for (int index = 0; index < serverip.Length; ++index)
        {
          ntpserverArray[index] = new ntpserver();
          ntpserverArray[index].serverip = serverip[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) ntpserverArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, ntpserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        ntpserver[] ntpserverArray = new ntpserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          ntpserverArray[index] = new ntpserver();
          ntpserverArray[index].serverip = resources[index].serverip;
          ntpserverArray[index].servername = resources[index].servername;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) ntpserverArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, ntpserver resource) => new ntpserver()
    {
      serverip = resource.serverip,
      servername = resource.servername,
      minpoll = resource.minpoll,
      maxpoll = resource.maxpoll,
      preferredntpserver = resource.preferredntpserver,
      autokey = resource.autokey,
      key = resource.key
    }.update_resource(client);

    public static base_responses update(nitro_service client, ntpserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        ntpserver[] ntpserverArray = new ntpserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          ntpserverArray[index] = new ntpserver();
          ntpserverArray[index].serverip = resources[index].serverip;
          ntpserverArray[index].servername = resources[index].servername;
          ntpserverArray[index].minpoll = resources[index].minpoll;
          ntpserverArray[index].maxpoll = resources[index].maxpoll;
          ntpserverArray[index].preferredntpserver = resources[index].preferredntpserver;
          ntpserverArray[index].autokey = resources[index].autokey;
          ntpserverArray[index].key = resources[index].key;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) ntpserverArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string serverip,
      string[] args)
    {
      return new ntpserver() { serverip = serverip }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      ntpserver resource,
      string[] args)
    {
      return new ntpserver()
      {
        serverip = resource.serverip,
        servername = resource.servername
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] serverip,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (serverip != null && serverip.Length > 0)
      {
        ntpserver[] ntpserverArray = new ntpserver[serverip.Length];
        for (int index = 0; index < serverip.Length; ++index)
        {
          ntpserverArray[index] = new ntpserver();
          ntpserverArray[index].serverip = serverip[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) ntpserverArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      ntpserver[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        ntpserver[] ntpserverArray = new ntpserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          ntpserverArray[index] = new ntpserver();
          ntpserverArray[index].serverip = resources[index].serverip;
          ntpserverArray[index].servername = resources[index].servername;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) ntpserverArray, args);
      }
      return baseResponses;
    }

    public static ntpserver[] get(nitro_service service) => (ntpserver[]) new ntpserver().get_resources(service, (options) null);

    public static ntpserver[] get(nitro_service service, options option) => (ntpserver[]) new ntpserver().get_resources(service, option);

    public static ntpserver get(nitro_service service, ntpserver obj)
    {
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (ntpserver) obj.get_resource(service, option);
    }

    public static ntpserver[] get(nitro_service service, ntpserver[] obj)
    {
      if (obj == null || obj.Length <= 0)
        return (ntpserver[]) null;
      ntpserver[] ntpserverArray = new ntpserver[obj.Length];
      for (int index = 0; index < obj.Length; ++index)
      {
        options option = new options();
        option.set_args(nitro_util.object_to_string_withoutquotes((object) obj[index]));
        ntpserverArray[index] = (ntpserver) obj[index].get_resource(service, option);
      }
      return ntpserverArray;
    }

    public static ntpserver[] get_filtered(nitro_service service, string filter)
    {
      ntpserver ntpserver = new ntpserver();
      options option = new options();
      option.set_filter(filter);
      return (ntpserver[]) ntpserver.getfiltered(service, option);
    }

    public static ntpserver[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      ntpserver ntpserver = new ntpserver();
      options option = new options();
      option.set_filter(filter);
      return (ntpserver[]) ntpserver.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      ntpserver ntpserver = new ntpserver();
      options option = new options();
      option.set_count(true);
      ntpserver[] resources = (ntpserver[]) ntpserver.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      ntpserver ntpserver = new ntpserver();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      ntpserver[] ntpserverArray = (ntpserver[]) ntpserver.getfiltered(service, option);
      return ntpserverArray != null && ntpserverArray.Length > 0 ? ntpserverArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      ntpserver ntpserver = new ntpserver();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      ntpserver[] ntpserverArray = (ntpserver[]) ntpserver.getfiltered(service, option);
      return ntpserverArray != null && ntpserverArray.Length > 0 ? ntpserverArray[0].__count.Value : 0U;
    }

    private class ntpserver_response : base_response
    {
      public ntpserver[] ntpserver = (ntpserver[]) null;
    }

    public static class preferredntpserverEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }
  }
}
