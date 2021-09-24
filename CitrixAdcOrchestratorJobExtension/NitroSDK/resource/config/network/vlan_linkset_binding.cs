// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.vlan_linkset_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class vlan_linkset_binding : base_resource
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
      vlan_linkset_binding.vlan_linkset_binding_response linksetBindingResponse = new vlan_linkset_binding.vlan_linkset_binding_response();
      vlan_linkset_binding.vlan_linkset_binding_response resource = (vlan_linkset_binding.vlan_linkset_binding_response) service.get_payload_formatter().string_to_resource(linksetBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vlan_linkset_binding;
    }

    internal override string get_object_name() => this.id.HasValue ? this.id.ToString() : (string) null;

    public static base_response add(
      nitro_service client,
      vlan_linkset_binding resource)
    {
      return new vlan_linkset_binding()
      {
        id = resource.id,
        ifnum = resource.ifnum,
        tagged = resource.tagged,
        ownergroup = resource.ownergroup
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      vlan_linkset_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vlan_linkset_binding[] vlanLinksetBindingArray = new vlan_linkset_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vlanLinksetBindingArray[index] = new vlan_linkset_binding();
          vlanLinksetBindingArray[index].id = resources[index].id;
          vlanLinksetBindingArray[index].ifnum = resources[index].ifnum;
          vlanLinksetBindingArray[index].tagged = resources[index].tagged;
          vlanLinksetBindingArray[index].ownergroup = resources[index].ownergroup;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) vlanLinksetBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      vlan_linkset_binding resource)
    {
      return new vlan_linkset_binding()
      {
        id = resource.id,
        ifnum = resource.ifnum,
        tagged = resource.tagged,
        ownergroup = resource.ownergroup
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      vlan_linkset_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vlan_linkset_binding[] vlanLinksetBindingArray = new vlan_linkset_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vlanLinksetBindingArray[index] = new vlan_linkset_binding();
          vlanLinksetBindingArray[index].id = resources[index].id;
          vlanLinksetBindingArray[index].ifnum = resources[index].ifnum;
          vlanLinksetBindingArray[index].tagged = resources[index].tagged;
          vlanLinksetBindingArray[index].ownergroup = resources[index].ownergroup;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vlanLinksetBindingArray);
      }
      return baseResponses;
    }

    public static vlan_linkset_binding[] get(nitro_service service, uint? id) => (vlan_linkset_binding[]) new vlan_linkset_binding()
    {
      id = id
    }.get_resources(service, (options) null);

    public static vlan_linkset_binding[] get_filtered(
      nitro_service service,
      uint? id,
      string filter)
    {
      vlan_linkset_binding vlanLinksetBinding = new vlan_linkset_binding();
      vlanLinksetBinding.id = id;
      options option = new options();
      option.set_filter(filter);
      return (vlan_linkset_binding[]) vlanLinksetBinding.getfiltered(service, option);
    }

    public static vlan_linkset_binding[] get_filtered(
      nitro_service service,
      uint? id,
      filtervalue[] filter)
    {
      vlan_linkset_binding vlanLinksetBinding = new vlan_linkset_binding();
      vlanLinksetBinding.id = id;
      options option = new options();
      option.set_filter(filter);
      return (vlan_linkset_binding[]) vlanLinksetBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, uint? id)
    {
      vlan_linkset_binding vlanLinksetBinding = new vlan_linkset_binding();
      vlanLinksetBinding.id = id;
      options option = new options();
      option.set_count(true);
      vlan_linkset_binding[] resources = (vlan_linkset_binding[]) vlanLinksetBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, uint? id, string filter)
    {
      vlan_linkset_binding vlanLinksetBinding = new vlan_linkset_binding();
      vlanLinksetBinding.id = id;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vlan_linkset_binding[] vlanLinksetBindingArray = (vlan_linkset_binding[]) vlanLinksetBinding.getfiltered(service, option);
      return vlanLinksetBindingArray != null && vlanLinksetBindingArray.Length > 0 ? vlanLinksetBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, uint? id, filtervalue[] filter)
    {
      vlan_linkset_binding vlanLinksetBinding = new vlan_linkset_binding();
      vlanLinksetBinding.id = id;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vlan_linkset_binding[] vlanLinksetBindingArray = (vlan_linkset_binding[]) vlanLinksetBinding.getfiltered(service, option);
      return vlanLinksetBindingArray != null && vlanLinksetBindingArray.Length > 0 ? vlanLinksetBindingArray[0].__count.Value : 0U;
    }

    private class vlan_linkset_binding_response : base_response
    {
      public vlan_linkset_binding[] vlan_linkset_binding = (vlan_linkset_binding[]) null;
    }
  }
}
