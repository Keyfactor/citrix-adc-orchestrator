// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.vlan_interface_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class vlan_interface_binding : base_resource
  {
    private string ifnumField = (string) null;
    private bool? taggedField = new bool?();
    private uint? idField = new uint?();
    private string ownergroupField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string ownergroup
    {
      get => this.ownergroupField;
      set => this.ownergroupField = value;
    }

    public uint? id
    {
      get => this.idField;
      set => this.idField = value;
    }

    public string ifnum
    {
      get => this.ifnumField;
      set => this.ifnumField = value;
    }

    public bool? tagged
    {
      get => this.taggedField;
      set => this.taggedField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vlan_interface_binding.vlan_interface_binding_response interfaceBindingResponse = new vlan_interface_binding.vlan_interface_binding_response();
      vlan_interface_binding.vlan_interface_binding_response resource = (vlan_interface_binding.vlan_interface_binding_response) service.get_payload_formatter().string_to_resource(interfaceBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vlan_interface_binding;
    }

    internal override string get_object_name() => this.id.HasValue ? this.id.ToString() : (string) null;

    public static base_response add(
      nitro_service client,
      vlan_interface_binding resource)
    {
      return new vlan_interface_binding()
      {
        id = resource.id,
        ifnum = resource.ifnum,
        tagged = resource.tagged,
        ownergroup = resource.ownergroup
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      vlan_interface_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vlan_interface_binding[] interfaceBindingArray = new vlan_interface_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          interfaceBindingArray[index] = new vlan_interface_binding();
          interfaceBindingArray[index].id = resources[index].id;
          interfaceBindingArray[index].ifnum = resources[index].ifnum;
          interfaceBindingArray[index].tagged = resources[index].tagged;
          interfaceBindingArray[index].ownergroup = resources[index].ownergroup;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) interfaceBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      vlan_interface_binding resource)
    {
      return new vlan_interface_binding()
      {
        id = resource.id,
        ifnum = resource.ifnum,
        tagged = resource.tagged,
        ownergroup = resource.ownergroup
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      vlan_interface_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vlan_interface_binding[] interfaceBindingArray = new vlan_interface_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          interfaceBindingArray[index] = new vlan_interface_binding();
          interfaceBindingArray[index].id = resources[index].id;
          interfaceBindingArray[index].ifnum = resources[index].ifnum;
          interfaceBindingArray[index].tagged = resources[index].tagged;
          interfaceBindingArray[index].ownergroup = resources[index].ownergroup;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) interfaceBindingArray);
      }
      return baseResponses;
    }

    public static vlan_interface_binding[] get(
      nitro_service service,
      uint? id)
    {
      return (vlan_interface_binding[]) new vlan_interface_binding()
      {
        id = id
      }.get_resources(service, (options) null);
    }

    public static vlan_interface_binding[] get_filtered(
      nitro_service service,
      uint? id,
      string filter)
    {
      vlan_interface_binding interfaceBinding = new vlan_interface_binding();
      interfaceBinding.id = id;
      options option = new options();
      option.set_filter(filter);
      return (vlan_interface_binding[]) interfaceBinding.getfiltered(service, option);
    }

    public static vlan_interface_binding[] get_filtered(
      nitro_service service,
      uint? id,
      filtervalue[] filter)
    {
      vlan_interface_binding interfaceBinding = new vlan_interface_binding();
      interfaceBinding.id = id;
      options option = new options();
      option.set_filter(filter);
      return (vlan_interface_binding[]) interfaceBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, uint? id)
    {
      vlan_interface_binding interfaceBinding = new vlan_interface_binding();
      interfaceBinding.id = id;
      options option = new options();
      option.set_count(true);
      vlan_interface_binding[] resources = (vlan_interface_binding[]) interfaceBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, uint? id, string filter)
    {
      vlan_interface_binding interfaceBinding = new vlan_interface_binding();
      interfaceBinding.id = id;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vlan_interface_binding[] interfaceBindingArray = (vlan_interface_binding[]) interfaceBinding.getfiltered(service, option);
      return interfaceBindingArray != null && interfaceBindingArray.Length > 0 ? interfaceBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, uint? id, filtervalue[] filter)
    {
      vlan_interface_binding interfaceBinding = new vlan_interface_binding();
      interfaceBinding.id = id;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vlan_interface_binding[] interfaceBindingArray = (vlan_interface_binding[]) interfaceBinding.getfiltered(service, option);
      return interfaceBindingArray != null && interfaceBindingArray.Length > 0 ? interfaceBindingArray[0].__count.Value : 0U;
    }

    private class vlan_interface_binding_response : base_response
    {
      public vlan_interface_binding[] vlan_interface_binding = (vlan_interface_binding[]) null;
    }
  }
}
