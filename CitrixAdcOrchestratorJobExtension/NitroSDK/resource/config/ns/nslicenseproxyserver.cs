// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nslicenseproxyserver
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nslicenseproxyserver : base_resource
  {
    private string serveripField = (string) null;
    private string servernameField = (string) null;
    private uint? portField = new uint?();
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

    public uint? port
    {
      get => this.portField;
      set => this.portField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nslicenseproxyserver.nslicenseproxyserver_response nslicenseproxyserverResponse = new nslicenseproxyserver.nslicenseproxyserver_response();
      nslicenseproxyserver.nslicenseproxyserver_response resource = (nslicenseproxyserver.nslicenseproxyserver_response) service.get_payload_formatter().string_to_resource(nslicenseproxyserverResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nslicenseproxyserver;
    }

    internal override string get_object_name() => this.serverip;

    public static base_response add(
      nitro_service client,
      nslicenseproxyserver resource)
    {
      return new nslicenseproxyserver()
      {
        serverip = resource.serverip,
        servername = resource.servername,
        port = resource.port
      }.add_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      nslicenseproxyserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nslicenseproxyserver[] nslicenseproxyserverArray = new nslicenseproxyserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nslicenseproxyserverArray[index] = new nslicenseproxyserver();
          nslicenseproxyserverArray[index].serverip = resources[index].serverip;
          nslicenseproxyserverArray[index].servername = resources[index].servername;
          nslicenseproxyserverArray[index].port = resources[index].port;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) nslicenseproxyserverArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string serverip) => new nslicenseproxyserver()
    {
      serverip = serverip
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      nslicenseproxyserver resource)
    {
      return new nslicenseproxyserver()
      {
        serverip = resource.serverip,
        servername = resource.servername
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] serverip)
    {
      base_responses baseResponses = (base_responses) null;
      if (serverip != null && serverip.Length > 0)
      {
        nslicenseproxyserver[] nslicenseproxyserverArray = new nslicenseproxyserver[serverip.Length];
        for (int index = 0; index < serverip.Length; ++index)
        {
          nslicenseproxyserverArray[index] = new nslicenseproxyserver();
          nslicenseproxyserverArray[index].serverip = serverip[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nslicenseproxyserverArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      nslicenseproxyserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nslicenseproxyserver[] nslicenseproxyserverArray = new nslicenseproxyserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nslicenseproxyserverArray[index] = new nslicenseproxyserver();
          nslicenseproxyserverArray[index].serverip = resources[index].serverip;
          nslicenseproxyserverArray[index].servername = resources[index].servername;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nslicenseproxyserverArray);
      }
      return baseResponses;
    }

    public static base_response update(
      nitro_service client,
      nslicenseproxyserver resource)
    {
      return new nslicenseproxyserver()
      {
        serverip = resource.serverip,
        servername = resource.servername,
        port = resource.port
      }.update_resource(client);
    }

    public static base_responses update(
      nitro_service client,
      nslicenseproxyserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nslicenseproxyserver[] nslicenseproxyserverArray = new nslicenseproxyserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nslicenseproxyserverArray[index] = new nslicenseproxyserver();
          nslicenseproxyserverArray[index].serverip = resources[index].serverip;
          nslicenseproxyserverArray[index].servername = resources[index].servername;
          nslicenseproxyserverArray[index].port = resources[index].port;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) nslicenseproxyserverArray);
      }
      return baseResponses;
    }

    public static nslicenseproxyserver[] get(nitro_service service) => (nslicenseproxyserver[]) new nslicenseproxyserver().get_resources(service, (options) null);

    public static nslicenseproxyserver[] get(
      nitro_service service,
      options option)
    {
      return (nslicenseproxyserver[]) new nslicenseproxyserver().get_resources(service, option);
    }

    public static nslicenseproxyserver get(
      nitro_service service,
      nslicenseproxyserver obj)
    {
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (nslicenseproxyserver) obj.get_resource(service, option);
    }

    public static nslicenseproxyserver[] get(
      nitro_service service,
      nslicenseproxyserver[] obj)
    {
      if (obj == null || obj.Length <= 0)
        return (nslicenseproxyserver[]) null;
      nslicenseproxyserver[] nslicenseproxyserverArray = new nslicenseproxyserver[obj.Length];
      for (int index = 0; index < obj.Length; ++index)
      {
        options option = new options();
        option.set_args(nitro_util.object_to_string_withoutquotes((object) obj[index]));
        nslicenseproxyserverArray[index] = (nslicenseproxyserver) obj[index].get_resource(service, option);
      }
      return nslicenseproxyserverArray;
    }

    public static nslicenseproxyserver[] get_filtered(
      nitro_service service,
      string filter)
    {
      nslicenseproxyserver nslicenseproxyserver = new nslicenseproxyserver();
      options option = new options();
      option.set_filter(filter);
      return (nslicenseproxyserver[]) nslicenseproxyserver.getfiltered(service, option);
    }

    public static nslicenseproxyserver[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      nslicenseproxyserver nslicenseproxyserver = new nslicenseproxyserver();
      options option = new options();
      option.set_filter(filter);
      return (nslicenseproxyserver[]) nslicenseproxyserver.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      nslicenseproxyserver nslicenseproxyserver = new nslicenseproxyserver();
      options option = new options();
      option.set_count(true);
      nslicenseproxyserver[] resources = (nslicenseproxyserver[]) nslicenseproxyserver.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      nslicenseproxyserver nslicenseproxyserver = new nslicenseproxyserver();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nslicenseproxyserver[] nslicenseproxyserverArray = (nslicenseproxyserver[]) nslicenseproxyserver.getfiltered(service, option);
      return nslicenseproxyserverArray != null && nslicenseproxyserverArray.Length > 0 ? nslicenseproxyserverArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      nslicenseproxyserver nslicenseproxyserver = new nslicenseproxyserver();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nslicenseproxyserver[] nslicenseproxyserverArray = (nslicenseproxyserver[]) nslicenseproxyserver.getfiltered(service, option);
      return nslicenseproxyserverArray != null && nslicenseproxyserverArray.Length > 0 ? nslicenseproxyserverArray[0].__count.Value : 0U;
    }

    private class nslicenseproxyserver_response : base_response
    {
      public nslicenseproxyserver[] nslicenseproxyserver = (nslicenseproxyserver[]) null;
    }
  }
}
