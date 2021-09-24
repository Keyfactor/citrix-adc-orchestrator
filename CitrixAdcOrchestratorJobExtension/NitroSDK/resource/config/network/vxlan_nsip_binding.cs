// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.vxlan_nsip_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class vxlan_nsip_binding : base_resource
  {
    private string ipaddressField = (string) null;
    private string netmaskField = (string) null;
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
      vxlan_nsip_binding.vxlan_nsip_binding_response nsipBindingResponse = new vxlan_nsip_binding.vxlan_nsip_binding_response();
      vxlan_nsip_binding.vxlan_nsip_binding_response resource = (vxlan_nsip_binding.vxlan_nsip_binding_response) service.get_payload_formatter().string_to_resource(nsipBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vxlan_nsip_binding;
    }

    internal override string get_object_name() => this.id.HasValue ? this.id.ToString() : (string) null;

    public static base_response add(nitro_service client, vxlan_nsip_binding resource) => new vxlan_nsip_binding()
    {
      id = resource.id,
      ipaddress = resource.ipaddress,
      netmask = resource.netmask
    }.update_resource(client);

    public static base_responses add(
      nitro_service client,
      vxlan_nsip_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vxlan_nsip_binding[] vxlanNsipBindingArray = new vxlan_nsip_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vxlanNsipBindingArray[index] = new vxlan_nsip_binding();
          vxlanNsipBindingArray[index].id = resources[index].id;
          vxlanNsipBindingArray[index].ipaddress = resources[index].ipaddress;
          vxlanNsipBindingArray[index].netmask = resources[index].netmask;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) vxlanNsipBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      vxlan_nsip_binding resource)
    {
      return new vxlan_nsip_binding()
      {
        id = resource.id,
        ipaddress = resource.ipaddress,
        netmask = resource.netmask
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      vxlan_nsip_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vxlan_nsip_binding[] vxlanNsipBindingArray = new vxlan_nsip_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vxlanNsipBindingArray[index] = new vxlan_nsip_binding();
          vxlanNsipBindingArray[index].id = resources[index].id;
          vxlanNsipBindingArray[index].ipaddress = resources[index].ipaddress;
          vxlanNsipBindingArray[index].netmask = resources[index].netmask;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vxlanNsipBindingArray);
      }
      return baseResponses;
    }

    public static vxlan_nsip_binding[] get(nitro_service service, uint? id) => (vxlan_nsip_binding[]) new vxlan_nsip_binding()
    {
      id = id
    }.get_resources(service, (options) null);

    public static vxlan_nsip_binding[] get_filtered(
      nitro_service service,
      uint? id,
      string filter)
    {
      vxlan_nsip_binding vxlanNsipBinding = new vxlan_nsip_binding();
      vxlanNsipBinding.id = id;
      options option = new options();
      option.set_filter(filter);
      return (vxlan_nsip_binding[]) vxlanNsipBinding.getfiltered(service, option);
    }

    public static vxlan_nsip_binding[] get_filtered(
      nitro_service service,
      uint? id,
      filtervalue[] filter)
    {
      vxlan_nsip_binding vxlanNsipBinding = new vxlan_nsip_binding();
      vxlanNsipBinding.id = id;
      options option = new options();
      option.set_filter(filter);
      return (vxlan_nsip_binding[]) vxlanNsipBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, uint? id)
    {
      vxlan_nsip_binding vxlanNsipBinding = new vxlan_nsip_binding();
      vxlanNsipBinding.id = id;
      options option = new options();
      option.set_count(true);
      vxlan_nsip_binding[] resources = (vxlan_nsip_binding[]) vxlanNsipBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, uint? id, string filter)
    {
      vxlan_nsip_binding vxlanNsipBinding = new vxlan_nsip_binding();
      vxlanNsipBinding.id = id;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vxlan_nsip_binding[] vxlanNsipBindingArray = (vxlan_nsip_binding[]) vxlanNsipBinding.getfiltered(service, option);
      return vxlanNsipBindingArray != null && vxlanNsipBindingArray.Length > 0 ? vxlanNsipBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, uint? id, filtervalue[] filter)
    {
      vxlan_nsip_binding vxlanNsipBinding = new vxlan_nsip_binding();
      vxlanNsipBinding.id = id;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vxlan_nsip_binding[] vxlanNsipBindingArray = (vxlan_nsip_binding[]) vxlanNsipBinding.getfiltered(service, option);
      return vxlanNsipBindingArray != null && vxlanNsipBindingArray.Length > 0 ? vxlanNsipBindingArray[0].__count.Value : 0U;
    }

    private class vxlan_nsip_binding_response : base_response
    {
      public vxlan_nsip_binding[] vxlan_nsip_binding = (vxlan_nsip_binding[]) null;
    }
  }
}
