// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nsrpcnode
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nsrpcnode : base_resource
  {
    private string ipaddressField = (string) null;
    private string passwordField = (string) null;
    private string srcipField = (string) null;
    private string secureField = (string) null;
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

    public string password
    {
      get => this.passwordField;
      set => this.passwordField = value;
    }

    public string srcip
    {
      get => this.srcipField;
      set => this.srcipField = value;
    }

    public string secure
    {
      get => this.secureField;
      set => this.secureField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nsrpcnode.nsrpcnode_response nsrpcnodeResponse = new nsrpcnode.nsrpcnode_response();
      nsrpcnode.nsrpcnode_response resource = (nsrpcnode.nsrpcnode_response) service.get_payload_formatter().string_to_resource(nsrpcnodeResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nsrpcnode;
    }

    internal override string get_object_name() => this.ipaddress;

    public static base_response update(nitro_service client, nsrpcnode resource) => new nsrpcnode()
    {
      ipaddress = resource.ipaddress,
      password = resource.password,
      srcip = resource.srcip,
      secure = resource.secure
    }.update_resource(client);

    public static base_responses update(nitro_service client, nsrpcnode[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsrpcnode[] nsrpcnodeArray = new nsrpcnode[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsrpcnodeArray[index] = new nsrpcnode();
          nsrpcnodeArray[index].ipaddress = resources[index].ipaddress;
          nsrpcnodeArray[index].password = resources[index].password;
          nsrpcnodeArray[index].srcip = resources[index].srcip;
          nsrpcnodeArray[index].secure = resources[index].secure;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) nsrpcnodeArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string ipaddress,
      string[] args)
    {
      return new nsrpcnode() { ipaddress = ipaddress }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      nsrpcnode resource,
      string[] args)
    {
      return new nsrpcnode()
      {
        ipaddress = resource.ipaddress
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] ipaddress,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (ipaddress != null && ipaddress.Length > 0)
      {
        nsrpcnode[] nsrpcnodeArray = new nsrpcnode[ipaddress.Length];
        for (int index = 0; index < ipaddress.Length; ++index)
        {
          nsrpcnodeArray[index] = new nsrpcnode();
          nsrpcnodeArray[index].ipaddress = ipaddress[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) nsrpcnodeArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      nsrpcnode[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsrpcnode[] nsrpcnodeArray = new nsrpcnode[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsrpcnodeArray[index] = new nsrpcnode();
          nsrpcnodeArray[index].ipaddress = resources[index].ipaddress;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) nsrpcnodeArray, args);
      }
      return baseResponses;
    }

    public static nsrpcnode[] get(nitro_service service) => (nsrpcnode[]) new nsrpcnode().get_resources(service, (options) null);

    public static nsrpcnode[] get(nitro_service service, options option) => (nsrpcnode[]) new nsrpcnode().get_resources(service, option);

    public static nsrpcnode get(nitro_service service, string ipaddress) => (nsrpcnode) new nsrpcnode()
    {
      ipaddress = ipaddress
    }.get_resource(service);

    public static nsrpcnode[] get(nitro_service service, string[] ipaddress)
    {
      if (ipaddress == null || ipaddress.Length <= 0)
        return (nsrpcnode[]) null;
      nsrpcnode[] nsrpcnodeArray1 = new nsrpcnode[ipaddress.Length];
      nsrpcnode[] nsrpcnodeArray2 = new nsrpcnode[ipaddress.Length];
      for (int index = 0; index < ipaddress.Length; ++index)
      {
        nsrpcnodeArray2[index] = new nsrpcnode();
        nsrpcnodeArray2[index].ipaddress = ipaddress[index];
        nsrpcnodeArray1[index] = (nsrpcnode) nsrpcnodeArray2[index].get_resource(service);
      }
      return nsrpcnodeArray1;
    }

    public static nsrpcnode[] get_filtered(nitro_service service, string filter)
    {
      nsrpcnode nsrpcnode = new nsrpcnode();
      options option = new options();
      option.set_filter(filter);
      return (nsrpcnode[]) nsrpcnode.getfiltered(service, option);
    }

    public static nsrpcnode[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      nsrpcnode nsrpcnode = new nsrpcnode();
      options option = new options();
      option.set_filter(filter);
      return (nsrpcnode[]) nsrpcnode.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      nsrpcnode nsrpcnode = new nsrpcnode();
      options option = new options();
      option.set_count(true);
      nsrpcnode[] resources = (nsrpcnode[]) nsrpcnode.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      nsrpcnode nsrpcnode = new nsrpcnode();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nsrpcnode[] nsrpcnodeArray = (nsrpcnode[]) nsrpcnode.getfiltered(service, option);
      return nsrpcnodeArray != null && nsrpcnodeArray.Length > 0 ? nsrpcnodeArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      nsrpcnode nsrpcnode = new nsrpcnode();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nsrpcnode[] nsrpcnodeArray = (nsrpcnode[]) nsrpcnode.getfiltered(service, option);
      return nsrpcnodeArray != null && nsrpcnodeArray.Length > 0 ? nsrpcnodeArray[0].__count.Value : 0U;
    }

    private class nsrpcnode_response : base_response
    {
      public nsrpcnode[] nsrpcnode = (nsrpcnode[]) null;
    }

    public static class secureEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }
  }
}
