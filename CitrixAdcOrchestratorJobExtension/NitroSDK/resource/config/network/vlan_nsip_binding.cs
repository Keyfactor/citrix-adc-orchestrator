// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.vlan_nsip_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class vlan_nsip_binding : base_resource
  {
    private string ipaddressField = (string) null;
    private string netmaskField = (string) null;
    private uint? tdField = new uint?();
    private string ownergroupField = (string) null;
    private uint? idField = new uint?();
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

    public uint? td
    {
      get => this.tdField;
      set => this.tdField = value;
    }

    public string netmask
    {
      get => this.netmaskField;
      set => this.netmaskField = value;
    }

    public string ipaddress
    {
      get => this.ipaddressField;
      set => this.ipaddressField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vlan_nsip_binding.vlan_nsip_binding_response nsipBindingResponse = new vlan_nsip_binding.vlan_nsip_binding_response();
      vlan_nsip_binding.vlan_nsip_binding_response resource = (vlan_nsip_binding.vlan_nsip_binding_response) service.get_payload_formatter().string_to_resource(nsipBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vlan_nsip_binding;
    }

    internal override string get_object_name() => this.id.HasValue ? this.id.ToString() : (string) null;

    public static base_response add(nitro_service client, vlan_nsip_binding resource) => new vlan_nsip_binding()
    {
      id = resource.id,
      ipaddress = resource.ipaddress,
      netmask = resource.netmask,
      td = resource.td,
      ownergroup = resource.ownergroup
    }.update_resource(client);

    public static base_responses add(
      nitro_service client,
      vlan_nsip_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vlan_nsip_binding[] vlanNsipBindingArray = new vlan_nsip_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vlanNsipBindingArray[index] = new vlan_nsip_binding();
          vlanNsipBindingArray[index].id = resources[index].id;
          vlanNsipBindingArray[index].ipaddress = resources[index].ipaddress;
          vlanNsipBindingArray[index].netmask = resources[index].netmask;
          vlanNsipBindingArray[index].td = resources[index].td;
          vlanNsipBindingArray[index].ownergroup = resources[index].ownergroup;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) vlanNsipBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      vlan_nsip_binding resource)
    {
      return new vlan_nsip_binding()
      {
        id = resource.id,
        ipaddress = resource.ipaddress,
        netmask = resource.netmask,
        td = resource.td,
        ownergroup = resource.ownergroup
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      vlan_nsip_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vlan_nsip_binding[] vlanNsipBindingArray = new vlan_nsip_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vlanNsipBindingArray[index] = new vlan_nsip_binding();
          vlanNsipBindingArray[index].id = resources[index].id;
          vlanNsipBindingArray[index].ipaddress = resources[index].ipaddress;
          vlanNsipBindingArray[index].netmask = resources[index].netmask;
          vlanNsipBindingArray[index].td = resources[index].td;
          vlanNsipBindingArray[index].ownergroup = resources[index].ownergroup;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vlanNsipBindingArray);
      }
      return baseResponses;
    }

    public static vlan_nsip_binding[] get(nitro_service service, uint? id) => (vlan_nsip_binding[]) new vlan_nsip_binding()
    {
      id = id
    }.get_resources(service, (options) null);

    public static vlan_nsip_binding[] get_filtered(
      nitro_service service,
      uint? id,
      string filter)
    {
      vlan_nsip_binding vlanNsipBinding = new vlan_nsip_binding();
      vlanNsipBinding.id = id;
      options option = new options();
      option.set_filter(filter);
      return (vlan_nsip_binding[]) vlanNsipBinding.getfiltered(service, option);
    }

    public static vlan_nsip_binding[] get_filtered(
      nitro_service service,
      uint? id,
      filtervalue[] filter)
    {
      vlan_nsip_binding vlanNsipBinding = new vlan_nsip_binding();
      vlanNsipBinding.id = id;
      options option = new options();
      option.set_filter(filter);
      return (vlan_nsip_binding[]) vlanNsipBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, uint? id)
    {
      vlan_nsip_binding vlanNsipBinding = new vlan_nsip_binding();
      vlanNsipBinding.id = id;
      options option = new options();
      option.set_count(true);
      vlan_nsip_binding[] resources = (vlan_nsip_binding[]) vlanNsipBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, uint? id, string filter)
    {
      vlan_nsip_binding vlanNsipBinding = new vlan_nsip_binding();
      vlanNsipBinding.id = id;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vlan_nsip_binding[] vlanNsipBindingArray = (vlan_nsip_binding[]) vlanNsipBinding.getfiltered(service, option);
      return vlanNsipBindingArray != null && vlanNsipBindingArray.Length > 0 ? vlanNsipBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, uint? id, filtervalue[] filter)
    {
      vlan_nsip_binding vlanNsipBinding = new vlan_nsip_binding();
      vlanNsipBinding.id = id;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vlan_nsip_binding[] vlanNsipBindingArray = (vlan_nsip_binding[]) vlanNsipBinding.getfiltered(service, option);
      return vlanNsipBindingArray != null && vlanNsipBindingArray.Length > 0 ? vlanNsipBindingArray[0].__count.Value : 0U;
    }

    private class vlan_nsip_binding_response : base_response
    {
      public vlan_nsip_binding[] vlan_nsip_binding = (vlan_nsip_binding[]) null;
    }
  }
}
