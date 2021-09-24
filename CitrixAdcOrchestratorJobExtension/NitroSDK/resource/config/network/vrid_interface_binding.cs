// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.vrid_interface_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class vrid_interface_binding : base_resource
  {
    private string ifacesField = (string) null;
    private string trackifnumField = (string) null;
    private uint? vlanField = new uint?();
    private uint? flagsField = new uint?();
    private uint? idField = new uint?();
    private string ifnumField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string ifnum
    {
      get => this.ifnumField;
      set => this.ifnumField = value;
    }

    public string trackifnum
    {
      get => this.trackifnumField;
      set => this.trackifnumField = value;
    }

    public string ifaces
    {
      get => this.ifacesField;
      set => this.ifacesField = value;
    }

    public uint? id
    {
      get => this.idField;
      set => this.idField = value;
    }

    public uint? flags
    {
      get => this.flagsField;
      private set => this.flagsField = value;
    }

    public uint? vlan
    {
      get => this.vlanField;
      private set => this.vlanField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vrid_interface_binding.vrid_interface_binding_response interfaceBindingResponse = new vrid_interface_binding.vrid_interface_binding_response();
      vrid_interface_binding.vrid_interface_binding_response resource = (vrid_interface_binding.vrid_interface_binding_response) service.get_payload_formatter().string_to_resource(interfaceBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vrid_interface_binding;
    }

    internal override string get_object_name() => this.id.HasValue ? this.id.ToString() : (string) null;

    public static base_response add(
      nitro_service client,
      vrid_interface_binding resource)
    {
      return new vrid_interface_binding()
      {
        id = resource.id,
        ifnum = resource.ifnum,
        trackifnum = resource.trackifnum
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      vrid_interface_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vrid_interface_binding[] interfaceBindingArray = new vrid_interface_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          interfaceBindingArray[index] = new vrid_interface_binding();
          interfaceBindingArray[index].id = resources[index].id;
          interfaceBindingArray[index].ifnum = resources[index].ifnum;
          interfaceBindingArray[index].trackifnum = resources[index].trackifnum;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) interfaceBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      vrid_interface_binding resource)
    {
      return new vrid_interface_binding()
      {
        id = resource.id,
        ifnum = resource.ifnum,
        trackifnum = resource.trackifnum
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      vrid_interface_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vrid_interface_binding[] interfaceBindingArray = new vrid_interface_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          interfaceBindingArray[index] = new vrid_interface_binding();
          interfaceBindingArray[index].id = resources[index].id;
          interfaceBindingArray[index].ifnum = resources[index].ifnum;
          interfaceBindingArray[index].trackifnum = resources[index].trackifnum;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) interfaceBindingArray);
      }
      return baseResponses;
    }

    public static vrid_interface_binding[] get(
      nitro_service service,
      uint? id)
    {
      return (vrid_interface_binding[]) new vrid_interface_binding()
      {
        id = id
      }.get_resources(service, (options) null);
    }

    public static vrid_interface_binding[] get_filtered(
      nitro_service service,
      uint? id,
      string filter)
    {
      vrid_interface_binding interfaceBinding = new vrid_interface_binding();
      interfaceBinding.id = id;
      options option = new options();
      option.set_filter(filter);
      return (vrid_interface_binding[]) interfaceBinding.getfiltered(service, option);
    }

    public static vrid_interface_binding[] get_filtered(
      nitro_service service,
      uint? id,
      filtervalue[] filter)
    {
      vrid_interface_binding interfaceBinding = new vrid_interface_binding();
      interfaceBinding.id = id;
      options option = new options();
      option.set_filter(filter);
      return (vrid_interface_binding[]) interfaceBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, uint? id)
    {
      vrid_interface_binding interfaceBinding = new vrid_interface_binding();
      interfaceBinding.id = id;
      options option = new options();
      option.set_count(true);
      vrid_interface_binding[] resources = (vrid_interface_binding[]) interfaceBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, uint? id, string filter)
    {
      vrid_interface_binding interfaceBinding = new vrid_interface_binding();
      interfaceBinding.id = id;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vrid_interface_binding[] interfaceBindingArray = (vrid_interface_binding[]) interfaceBinding.getfiltered(service, option);
      return interfaceBindingArray != null && interfaceBindingArray.Length > 0 ? interfaceBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, uint? id, filtervalue[] filter)
    {
      vrid_interface_binding interfaceBinding = new vrid_interface_binding();
      interfaceBinding.id = id;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vrid_interface_binding[] interfaceBindingArray = (vrid_interface_binding[]) interfaceBinding.getfiltered(service, option);
      return interfaceBindingArray != null && interfaceBindingArray.Length > 0 ? interfaceBindingArray[0].__count.Value : 0U;
    }

    private class vrid_interface_binding_response : base_response
    {
      public vrid_interface_binding[] vrid_interface_binding = (vrid_interface_binding[]) null;
    }
  }
}
