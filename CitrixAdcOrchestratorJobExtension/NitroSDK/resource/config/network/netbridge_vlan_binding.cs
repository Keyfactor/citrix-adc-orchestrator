// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.netbridge_vlan_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class netbridge_vlan_binding : base_resource
  {
    private uint? vlanField = new uint?();
    private string nameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public uint? vlan
    {
      get => this.vlanField;
      set => this.vlanField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      netbridge_vlan_binding.netbridge_vlan_binding_response vlanBindingResponse = new netbridge_vlan_binding.netbridge_vlan_binding_response();
      netbridge_vlan_binding.netbridge_vlan_binding_response resource = (netbridge_vlan_binding.netbridge_vlan_binding_response) service.get_payload_formatter().string_to_resource(vlanBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.netbridge_vlan_binding;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      netbridge_vlan_binding resource)
    {
      return new netbridge_vlan_binding()
      {
        name = resource.name,
        vlan = resource.vlan
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      netbridge_vlan_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        netbridge_vlan_binding[] netbridgeVlanBindingArray = new netbridge_vlan_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          netbridgeVlanBindingArray[index] = new netbridge_vlan_binding();
          netbridgeVlanBindingArray[index].name = resources[index].name;
          netbridgeVlanBindingArray[index].vlan = resources[index].vlan;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) netbridgeVlanBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      netbridge_vlan_binding resource)
    {
      return new netbridge_vlan_binding()
      {
        name = resource.name,
        vlan = resource.vlan
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      netbridge_vlan_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        netbridge_vlan_binding[] netbridgeVlanBindingArray = new netbridge_vlan_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          netbridgeVlanBindingArray[index] = new netbridge_vlan_binding();
          netbridgeVlanBindingArray[index].name = resources[index].name;
          netbridgeVlanBindingArray[index].vlan = resources[index].vlan;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) netbridgeVlanBindingArray);
      }
      return baseResponses;
    }

    public static netbridge_vlan_binding[] get(
      nitro_service service,
      string name)
    {
      return (netbridge_vlan_binding[]) new netbridge_vlan_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static netbridge_vlan_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      netbridge_vlan_binding netbridgeVlanBinding = new netbridge_vlan_binding();
      netbridgeVlanBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (netbridge_vlan_binding[]) netbridgeVlanBinding.getfiltered(service, option);
    }

    public static netbridge_vlan_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      netbridge_vlan_binding netbridgeVlanBinding = new netbridge_vlan_binding();
      netbridgeVlanBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (netbridge_vlan_binding[]) netbridgeVlanBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      netbridge_vlan_binding netbridgeVlanBinding = new netbridge_vlan_binding();
      netbridgeVlanBinding.name = name;
      options option = new options();
      option.set_count(true);
      netbridge_vlan_binding[] resources = (netbridge_vlan_binding[]) netbridgeVlanBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      netbridge_vlan_binding netbridgeVlanBinding = new netbridge_vlan_binding();
      netbridgeVlanBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      netbridge_vlan_binding[] netbridgeVlanBindingArray = (netbridge_vlan_binding[]) netbridgeVlanBinding.getfiltered(service, option);
      return netbridgeVlanBindingArray != null && netbridgeVlanBindingArray.Length > 0 ? netbridgeVlanBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      netbridge_vlan_binding netbridgeVlanBinding = new netbridge_vlan_binding();
      netbridgeVlanBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      netbridge_vlan_binding[] netbridgeVlanBindingArray = (netbridge_vlan_binding[]) netbridgeVlanBinding.getfiltered(service, option);
      return netbridgeVlanBindingArray != null && netbridgeVlanBindingArray.Length > 0 ? netbridgeVlanBindingArray[0].__count.Value : 0U;
    }

    private class netbridge_vlan_binding_response : base_response
    {
      public netbridge_vlan_binding[] netbridge_vlan_binding = (netbridge_vlan_binding[]) null;
    }
  }
}
