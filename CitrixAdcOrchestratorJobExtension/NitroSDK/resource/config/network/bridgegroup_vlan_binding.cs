// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.bridgegroup_vlan_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class bridgegroup_vlan_binding : base_resource
  {
    private uint? vlanField = new uint?();
    private bool? rnatField = new bool?();
    private uint? idField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public uint? id
    {
      get => this.idField;
      set => this.idField = value;
    }

    public uint? vlan
    {
      get => this.vlanField;
      set => this.vlanField = value;
    }

    public bool? rnat
    {
      get => this.rnatField;
      private set => this.rnatField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      bridgegroup_vlan_binding.bridgegroup_vlan_binding_response vlanBindingResponse = new bridgegroup_vlan_binding.bridgegroup_vlan_binding_response();
      bridgegroup_vlan_binding.bridgegroup_vlan_binding_response resource = (bridgegroup_vlan_binding.bridgegroup_vlan_binding_response) service.get_payload_formatter().string_to_resource(vlanBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.bridgegroup_vlan_binding;
    }

    internal override string get_object_name() => this.id.HasValue ? this.id.ToString() : (string) null;

    public static base_response add(
      nitro_service client,
      bridgegroup_vlan_binding resource)
    {
      return new bridgegroup_vlan_binding()
      {
        id = resource.id,
        vlan = resource.vlan
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      bridgegroup_vlan_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        bridgegroup_vlan_binding[] bridgegroupVlanBindingArray = new bridgegroup_vlan_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          bridgegroupVlanBindingArray[index] = new bridgegroup_vlan_binding();
          bridgegroupVlanBindingArray[index].id = resources[index].id;
          bridgegroupVlanBindingArray[index].vlan = resources[index].vlan;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) bridgegroupVlanBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      bridgegroup_vlan_binding resource)
    {
      return new bridgegroup_vlan_binding()
      {
        id = resource.id,
        vlan = resource.vlan
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      bridgegroup_vlan_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        bridgegroup_vlan_binding[] bridgegroupVlanBindingArray = new bridgegroup_vlan_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          bridgegroupVlanBindingArray[index] = new bridgegroup_vlan_binding();
          bridgegroupVlanBindingArray[index].id = resources[index].id;
          bridgegroupVlanBindingArray[index].vlan = resources[index].vlan;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) bridgegroupVlanBindingArray);
      }
      return baseResponses;
    }

    public static bridgegroup_vlan_binding[] get(
      nitro_service service,
      uint? id)
    {
      return (bridgegroup_vlan_binding[]) new bridgegroup_vlan_binding()
      {
        id = id
      }.get_resources(service, (options) null);
    }

    public static bridgegroup_vlan_binding[] get_filtered(
      nitro_service service,
      uint? id,
      string filter)
    {
      bridgegroup_vlan_binding bridgegroupVlanBinding = new bridgegroup_vlan_binding();
      bridgegroupVlanBinding.id = id;
      options option = new options();
      option.set_filter(filter);
      return (bridgegroup_vlan_binding[]) bridgegroupVlanBinding.getfiltered(service, option);
    }

    public static bridgegroup_vlan_binding[] get_filtered(
      nitro_service service,
      uint? id,
      filtervalue[] filter)
    {
      bridgegroup_vlan_binding bridgegroupVlanBinding = new bridgegroup_vlan_binding();
      bridgegroupVlanBinding.id = id;
      options option = new options();
      option.set_filter(filter);
      return (bridgegroup_vlan_binding[]) bridgegroupVlanBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, uint? id)
    {
      bridgegroup_vlan_binding bridgegroupVlanBinding = new bridgegroup_vlan_binding();
      bridgegroupVlanBinding.id = id;
      options option = new options();
      option.set_count(true);
      bridgegroup_vlan_binding[] resources = (bridgegroup_vlan_binding[]) bridgegroupVlanBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, uint? id, string filter)
    {
      bridgegroup_vlan_binding bridgegroupVlanBinding = new bridgegroup_vlan_binding();
      bridgegroupVlanBinding.id = id;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      bridgegroup_vlan_binding[] bridgegroupVlanBindingArray = (bridgegroup_vlan_binding[]) bridgegroupVlanBinding.getfiltered(service, option);
      return bridgegroupVlanBindingArray != null && bridgegroupVlanBindingArray.Length > 0 ? bridgegroupVlanBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, uint? id, filtervalue[] filter)
    {
      bridgegroup_vlan_binding bridgegroupVlanBinding = new bridgegroup_vlan_binding();
      bridgegroupVlanBinding.id = id;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      bridgegroup_vlan_binding[] bridgegroupVlanBindingArray = (bridgegroup_vlan_binding[]) bridgegroupVlanBinding.getfiltered(service, option);
      return bridgegroupVlanBindingArray != null && bridgegroupVlanBindingArray.Length > 0 ? bridgegroupVlanBindingArray[0].__count.Value : 0U;
    }

    private class bridgegroup_vlan_binding_response : base_response
    {
      public bridgegroup_vlan_binding[] bridgegroup_vlan_binding = (bridgegroup_vlan_binding[]) null;
    }
  }
}
