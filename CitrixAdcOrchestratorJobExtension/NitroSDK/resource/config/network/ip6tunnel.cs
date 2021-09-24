// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.ip6tunnel
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class ip6tunnel : base_resource
  {
    private string nameField = (string) null;
    private string remoteField = (string) null;
    private string localField = (string) null;
    private string ownergroupField = (string) null;
    private string remoteipField = (string) null;
    private uint? typeField = new uint?();
    private string encapipField = (string) null;
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

    public string remote
    {
      get => this.remoteField;
      set => this.remoteField = value;
    }

    public string local
    {
      get => this.localField;
      set => this.localField = value;
    }

    public string ownergroup
    {
      get => this.ownergroupField;
      set => this.ownergroupField = value;
    }

    public string remoteip
    {
      get => this.remoteipField;
      private set => this.remoteipField = value;
    }

    public uint? type
    {
      get => this.typeField;
      private set => this.typeField = value;
    }

    public string encapip
    {
      get => this.encapipField;
      private set => this.encapipField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      ip6tunnel.ip6tunnel_response ip6tunnelResponse = new ip6tunnel.ip6tunnel_response();
      ip6tunnel.ip6tunnel_response resource = (ip6tunnel.ip6tunnel_response) service.get_payload_formatter().string_to_resource(ip6tunnelResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.ip6tunnel;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, ip6tunnel resource) => new ip6tunnel()
    {
      name = resource.name,
      remote = resource.remote,
      local = resource.local,
      ownergroup = resource.ownergroup
    }.add_resource(client);

    public static base_responses add(nitro_service client, ip6tunnel[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        ip6tunnel[] ip6tunnelArray = new ip6tunnel[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          ip6tunnelArray[index] = new ip6tunnel();
          ip6tunnelArray[index].name = resources[index].name;
          ip6tunnelArray[index].remote = resources[index].remote;
          ip6tunnelArray[index].local = resources[index].local;
          ip6tunnelArray[index].ownergroup = resources[index].ownergroup;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) ip6tunnelArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new ip6tunnel()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, ip6tunnel resource) => new ip6tunnel()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        ip6tunnel[] ip6tunnelArray = new ip6tunnel[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          ip6tunnelArray[index] = new ip6tunnel();
          ip6tunnelArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) ip6tunnelArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, ip6tunnel[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        ip6tunnel[] ip6tunnelArray = new ip6tunnel[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          ip6tunnelArray[index] = new ip6tunnel();
          ip6tunnelArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) ip6tunnelArray);
      }
      return baseResponses;
    }

    public static ip6tunnel[] get(nitro_service service) => (ip6tunnel[]) new ip6tunnel().get_resources(service, (options) null);

    public static ip6tunnel[] get(nitro_service service, options option) => (ip6tunnel[]) new ip6tunnel().get_resources(service, option);

    public static ip6tunnel[] get(nitro_service service, ip6tunnel_args args)
    {
      ip6tunnel ip6tunnel = new ip6tunnel();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (ip6tunnel[]) ip6tunnel.get_resources(service, option);
    }

    public static ip6tunnel get(nitro_service service, string name) => (ip6tunnel) new ip6tunnel()
    {
      name = name
    }.get_resource(service);

    public static ip6tunnel[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (ip6tunnel[]) null;
      ip6tunnel[] ip6tunnelArray1 = new ip6tunnel[name.Length];
      ip6tunnel[] ip6tunnelArray2 = new ip6tunnel[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        ip6tunnelArray2[index] = new ip6tunnel();
        ip6tunnelArray2[index].name = name[index];
        ip6tunnelArray1[index] = (ip6tunnel) ip6tunnelArray2[index].get_resource(service);
      }
      return ip6tunnelArray1;
    }

    public static ip6tunnel[] get_filtered(nitro_service service, string filter)
    {
      ip6tunnel ip6tunnel = new ip6tunnel();
      options option = new options();
      option.set_filter(filter);
      return (ip6tunnel[]) ip6tunnel.getfiltered(service, option);
    }

    public static ip6tunnel[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      ip6tunnel ip6tunnel = new ip6tunnel();
      options option = new options();
      option.set_filter(filter);
      return (ip6tunnel[]) ip6tunnel.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      ip6tunnel ip6tunnel = new ip6tunnel();
      options option = new options();
      option.set_count(true);
      ip6tunnel[] resources = (ip6tunnel[]) ip6tunnel.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      ip6tunnel ip6tunnel = new ip6tunnel();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      ip6tunnel[] ip6tunnelArray = (ip6tunnel[]) ip6tunnel.getfiltered(service, option);
      return ip6tunnelArray != null && ip6tunnelArray.Length > 0 ? ip6tunnelArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      ip6tunnel ip6tunnel = new ip6tunnel();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      ip6tunnel[] ip6tunnelArray = (ip6tunnel[]) ip6tunnel.getfiltered(service, option);
      return ip6tunnelArray != null && ip6tunnelArray.Length > 0 ? ip6tunnelArray[0].__count.Value : 0U;
    }

    private class ip6tunnel_response : base_response
    {
      public ip6tunnel[] ip6tunnel = (ip6tunnel[]) null;
    }
  }
}
