// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.vpath
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class vpath : base_resource
  {
    private string nameField = (string) null;
    private string destipField = (string) null;
    private string netmaskField = (string) null;
    private string gatewayField = (string) null;
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

    public string destip
    {
      get => this.destipField;
      set => this.destipField = value;
    }

    public string netmask
    {
      get => this.netmaskField;
      set => this.netmaskField = value;
    }

    public string gateway
    {
      get => this.gatewayField;
      set => this.gatewayField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vpath.vpath_response vpathResponse = new vpath.vpath_response();
      vpath.vpath_response resource = (vpath.vpath_response) service.get_payload_formatter().string_to_resource(vpathResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vpath;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, vpath resource) => new vpath()
    {
      name = resource.name,
      destip = resource.destip,
      netmask = resource.netmask,
      gateway = resource.gateway
    }.add_resource(client);

    public static base_responses add(nitro_service client, vpath[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpath[] vpathArray = new vpath[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpathArray[index] = new vpath();
          vpathArray[index].name = resources[index].name;
          vpathArray[index].destip = resources[index].destip;
          vpathArray[index].netmask = resources[index].netmask;
          vpathArray[index].gateway = resources[index].gateway;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) vpathArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new vpath()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, vpath resource) => new vpath()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        vpath[] vpathArray = new vpath[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          vpathArray[index] = new vpath();
          vpathArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vpathArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, vpath[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpath[] vpathArray = new vpath[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpathArray[index] = new vpath();
          vpathArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vpathArray);
      }
      return baseResponses;
    }

    public static vpath[] get(nitro_service service) => (vpath[]) new vpath().get_resources(service, (options) null);

    public static vpath[] get(nitro_service service, options option) => (vpath[]) new vpath().get_resources(service, option);

    public static vpath get(nitro_service service, string name) => (vpath) new vpath()
    {
      name = name
    }.get_resource(service);

    public static vpath[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (vpath[]) null;
      vpath[] vpathArray1 = new vpath[name.Length];
      vpath[] vpathArray2 = new vpath[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        vpathArray2[index] = new vpath();
        vpathArray2[index].name = name[index];
        vpathArray1[index] = (vpath) vpathArray2[index].get_resource(service);
      }
      return vpathArray1;
    }

    public static vpath[] get_filtered(nitro_service service, string filter)
    {
      vpath vpath = new vpath();
      options option = new options();
      option.set_filter(filter);
      return (vpath[]) vpath.getfiltered(service, option);
    }

    public static vpath[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      vpath vpath = new vpath();
      options option = new options();
      option.set_filter(filter);
      return (vpath[]) vpath.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      vpath vpath = new vpath();
      options option = new options();
      option.set_count(true);
      vpath[] resources = (vpath[]) vpath.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      vpath vpath = new vpath();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpath[] vpathArray = (vpath[]) vpath.getfiltered(service, option);
      return vpathArray != null && vpathArray.Length > 0 ? vpathArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      vpath vpath = new vpath();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpath[] vpathArray = (vpath[]) vpath.getfiltered(service, option);
      return vpathArray != null && vpathArray.Length > 0 ? vpathArray[0].__count.Value : 0U;
    }

    private class vpath_response : base_response
    {
      public vpath[] vpath = (vpath[]) null;
    }
  }
}
