// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.lacp
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class lacp : base_resource
  {
    private uint? syspriorityField = new uint?();
    private uint? ownernodeField = new uint?();
    private string devicenameField = (string) null;
    private string macField = (string) null;
    private uint? flagsField = new uint?();
    private uint? lacpkeyField = new uint?();
    private uint? clustersyspriorityField = new uint?();
    private string clustermacField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public uint? syspriority
    {
      get => this.syspriorityField;
      set => this.syspriorityField = value;
    }

    public uint? ownernode
    {
      get => this.ownernodeField;
      set => this.ownernodeField = value;
    }

    public string devicename
    {
      get => this.devicenameField;
      private set => this.devicenameField = value;
    }

    public string mac
    {
      get => this.macField;
      private set => this.macField = value;
    }

    public uint? flags
    {
      get => this.flagsField;
      private set => this.flagsField = value;
    }

    public uint? lacpkey
    {
      get => this.lacpkeyField;
      private set => this.lacpkeyField = value;
    }

    public uint? clustersyspriority
    {
      get => this.clustersyspriorityField;
      private set => this.clustersyspriorityField = value;
    }

    public string clustermac
    {
      get => this.clustermacField;
      private set => this.clustermacField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lacp.lacp_response lacpResponse = new lacp.lacp_response();
      lacp.lacp_response resource = (lacp.lacp_response) service.get_payload_formatter().string_to_resource(lacpResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lacp;
    }

    internal override string get_object_name() => this.ownernode.HasValue ? this.ownernode.ToString() : (string) null;

    public static base_response update(nitro_service client, lacp resource) => new lacp()
    {
      syspriority = resource.syspriority,
      ownernode = resource.ownernode
    }.update_resource(client);

    public static base_responses update(nitro_service client, lacp[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lacp[] lacpArray = new lacp[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lacpArray[index] = new lacp();
          lacpArray[index].syspriority = resources[index].syspriority;
          lacpArray[index].ownernode = resources[index].ownernode;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) lacpArray);
      }
      return baseResponses;
    }

    public static lacp[] get(nitro_service service) => (lacp[]) new lacp().get_resources(service, (options) null);

    public static lacp[] get(nitro_service service, options option) => (lacp[]) new lacp().get_resources(service, option);

    public static lacp get(nitro_service service, uint? ownernode) => (lacp) new lacp()
    {
      ownernode = ownernode
    }.get_resource(service);

    public static lacp[] get(nitro_service service, uint?[] ownernode)
    {
      if (ownernode == null || ownernode.Length <= 0)
        return (lacp[]) null;
      lacp[] lacpArray1 = new lacp[ownernode.Length];
      lacp[] lacpArray2 = new lacp[ownernode.Length];
      for (int index = 0; index < ownernode.Length; ++index)
      {
        lacpArray2[index] = new lacp();
        lacpArray2[index].ownernode = ownernode[index];
        lacpArray1[index] = (lacp) lacpArray2[index].get_resource(service);
      }
      return lacpArray1;
    }

    public static lacp[] get_filtered(nitro_service service, string filter)
    {
      lacp lacp = new lacp();
      options option = new options();
      option.set_filter(filter);
      return (lacp[]) lacp.getfiltered(service, option);
    }

    public static lacp[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      lacp lacp = new lacp();
      options option = new options();
      option.set_filter(filter);
      return (lacp[]) lacp.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      lacp lacp = new lacp();
      options option = new options();
      option.set_count(true);
      lacp[] resources = (lacp[]) lacp.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      lacp lacp = new lacp();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lacp[] lacpArray = (lacp[]) lacp.getfiltered(service, option);
      return lacpArray != null && lacpArray.Length > 0 ? lacpArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      lacp lacp = new lacp();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lacp[] lacpArray = (lacp[]) lacp.getfiltered(service, option);
      return lacpArray != null && lacpArray.Length > 0 ? lacpArray[0].__count.Value : 0U;
    }

    private class lacp_response : base_response
    {
      public lacp[] lacp = (lacp[]) null;
    }
  }
}
