// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.vlan_channel_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class vlan_channel_binding : base_resource
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
      vlan_channel_binding.vlan_channel_binding_response channelBindingResponse = new vlan_channel_binding.vlan_channel_binding_response();
      vlan_channel_binding.vlan_channel_binding_response resource = (vlan_channel_binding.vlan_channel_binding_response) service.get_payload_formatter().string_to_resource(channelBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vlan_channel_binding;
    }

    internal override string get_object_name() => this.id.HasValue ? this.id.ToString() : (string) null;

    public static base_response add(
      nitro_service client,
      vlan_channel_binding resource)
    {
      return new vlan_channel_binding()
      {
        id = resource.id,
        ifnum = resource.ifnum,
        tagged = resource.tagged,
        ownergroup = resource.ownergroup
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      vlan_channel_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vlan_channel_binding[] vlanChannelBindingArray = new vlan_channel_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vlanChannelBindingArray[index] = new vlan_channel_binding();
          vlanChannelBindingArray[index].id = resources[index].id;
          vlanChannelBindingArray[index].ifnum = resources[index].ifnum;
          vlanChannelBindingArray[index].tagged = resources[index].tagged;
          vlanChannelBindingArray[index].ownergroup = resources[index].ownergroup;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) vlanChannelBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      vlan_channel_binding resource)
    {
      return new vlan_channel_binding()
      {
        id = resource.id,
        ifnum = resource.ifnum,
        tagged = resource.tagged,
        ownergroup = resource.ownergroup
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      vlan_channel_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vlan_channel_binding[] vlanChannelBindingArray = new vlan_channel_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vlanChannelBindingArray[index] = new vlan_channel_binding();
          vlanChannelBindingArray[index].id = resources[index].id;
          vlanChannelBindingArray[index].ifnum = resources[index].ifnum;
          vlanChannelBindingArray[index].tagged = resources[index].tagged;
          vlanChannelBindingArray[index].ownergroup = resources[index].ownergroup;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vlanChannelBindingArray);
      }
      return baseResponses;
    }

    public static vlan_channel_binding[] get(nitro_service service, uint? id) => (vlan_channel_binding[]) new vlan_channel_binding()
    {
      id = id
    }.get_resources(service, (options) null);

    public static vlan_channel_binding[] get_filtered(
      nitro_service service,
      uint? id,
      string filter)
    {
      vlan_channel_binding vlanChannelBinding = new vlan_channel_binding();
      vlanChannelBinding.id = id;
      options option = new options();
      option.set_filter(filter);
      return (vlan_channel_binding[]) vlanChannelBinding.getfiltered(service, option);
    }

    public static vlan_channel_binding[] get_filtered(
      nitro_service service,
      uint? id,
      filtervalue[] filter)
    {
      vlan_channel_binding vlanChannelBinding = new vlan_channel_binding();
      vlanChannelBinding.id = id;
      options option = new options();
      option.set_filter(filter);
      return (vlan_channel_binding[]) vlanChannelBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, uint? id)
    {
      vlan_channel_binding vlanChannelBinding = new vlan_channel_binding();
      vlanChannelBinding.id = id;
      options option = new options();
      option.set_count(true);
      vlan_channel_binding[] resources = (vlan_channel_binding[]) vlanChannelBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, uint? id, string filter)
    {
      vlan_channel_binding vlanChannelBinding = new vlan_channel_binding();
      vlanChannelBinding.id = id;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vlan_channel_binding[] vlanChannelBindingArray = (vlan_channel_binding[]) vlanChannelBinding.getfiltered(service, option);
      return vlanChannelBindingArray != null && vlanChannelBindingArray.Length > 0 ? vlanChannelBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, uint? id, filtervalue[] filter)
    {
      vlan_channel_binding vlanChannelBinding = new vlan_channel_binding();
      vlanChannelBinding.id = id;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vlan_channel_binding[] vlanChannelBindingArray = (vlan_channel_binding[]) vlanChannelBinding.getfiltered(service, option);
      return vlanChannelBindingArray != null && vlanChannelBindingArray.Length > 0 ? vlanChannelBindingArray[0].__count.Value : 0U;
    }

    private class vlan_channel_binding_response : base_response
    {
      public vlan_channel_binding[] vlan_channel_binding = (vlan_channel_binding[]) null;
    }
  }
}
