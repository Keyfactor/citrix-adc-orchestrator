// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cache.cacheforwardproxy
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.cache
{
  public class cacheforwardproxy : base_resource
  {
    private string ipaddressField = (string) null;
    private ushort? portField = new ushort?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string ipaddress
    {
      get => this.ipaddressField;
      set => this.ipaddressField = value;
    }

    public ushort? port
    {
      get => this.portField;
      set => this.portField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      cacheforwardproxy.cacheforwardproxy_response cacheforwardproxyResponse = new cacheforwardproxy.cacheforwardproxy_response();
      cacheforwardproxy.cacheforwardproxy_response resource = (cacheforwardproxy.cacheforwardproxy_response) service.get_payload_formatter().string_to_resource(cacheforwardproxyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.cacheforwardproxy;
    }

    internal override string get_object_name() => this.ipaddress;

    public static base_response add(nitro_service client, cacheforwardproxy resource) => new cacheforwardproxy()
    {
      ipaddress = resource.ipaddress,
      port = resource.port
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      cacheforwardproxy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        cacheforwardproxy[] cacheforwardproxyArray = new cacheforwardproxy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          cacheforwardproxyArray[index] = new cacheforwardproxy();
          cacheforwardproxyArray[index].ipaddress = resources[index].ipaddress;
          cacheforwardproxyArray[index].port = resources[index].port;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) cacheforwardproxyArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string ipaddress) => new cacheforwardproxy()
    {
      ipaddress = ipaddress
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      cacheforwardproxy resource)
    {
      return new cacheforwardproxy()
      {
        ipaddress = resource.ipaddress,
        port = resource.port
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] ipaddress)
    {
      base_responses baseResponses = (base_responses) null;
      if (ipaddress != null && ipaddress.Length > 0)
      {
        cacheforwardproxy[] cacheforwardproxyArray = new cacheforwardproxy[ipaddress.Length];
        for (int index = 0; index < ipaddress.Length; ++index)
        {
          cacheforwardproxyArray[index] = new cacheforwardproxy();
          cacheforwardproxyArray[index].ipaddress = ipaddress[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) cacheforwardproxyArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      cacheforwardproxy[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        cacheforwardproxy[] cacheforwardproxyArray = new cacheforwardproxy[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          cacheforwardproxyArray[index] = new cacheforwardproxy();
          cacheforwardproxyArray[index].ipaddress = resources[index].ipaddress;
          cacheforwardproxyArray[index].port = resources[index].port;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) cacheforwardproxyArray);
      }
      return baseResponses;
    }

    public static cacheforwardproxy[] get(nitro_service service) => (cacheforwardproxy[]) new cacheforwardproxy().get_resources(service, (options) null);

    public static cacheforwardproxy[] get(nitro_service service, options option) => (cacheforwardproxy[]) new cacheforwardproxy().get_resources(service, option);

    public static cacheforwardproxy[] get_filtered(
      nitro_service service,
      string filter)
    {
      cacheforwardproxy cacheforwardproxy = new cacheforwardproxy();
      options option = new options();
      option.set_filter(filter);
      return (cacheforwardproxy[]) cacheforwardproxy.getfiltered(service, option);
    }

    public static cacheforwardproxy[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      cacheforwardproxy cacheforwardproxy = new cacheforwardproxy();
      options option = new options();
      option.set_filter(filter);
      return (cacheforwardproxy[]) cacheforwardproxy.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      cacheforwardproxy cacheforwardproxy = new cacheforwardproxy();
      options option = new options();
      option.set_count(true);
      cacheforwardproxy[] resources = (cacheforwardproxy[]) cacheforwardproxy.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      cacheforwardproxy cacheforwardproxy = new cacheforwardproxy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      cacheforwardproxy[] cacheforwardproxyArray = (cacheforwardproxy[]) cacheforwardproxy.getfiltered(service, option);
      return cacheforwardproxyArray != null && cacheforwardproxyArray.Length > 0 ? cacheforwardproxyArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      cacheforwardproxy cacheforwardproxy = new cacheforwardproxy();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      cacheforwardproxy[] cacheforwardproxyArray = (cacheforwardproxy[]) cacheforwardproxy.getfiltered(service, option);
      return cacheforwardproxyArray != null && cacheforwardproxyArray.Length > 0 ? cacheforwardproxyArray[0].__count.Value : 0U;
    }

    private class cacheforwardproxy_response : base_response
    {
      public cacheforwardproxy[] cacheforwardproxy = (cacheforwardproxy[]) null;
    }
  }
}
