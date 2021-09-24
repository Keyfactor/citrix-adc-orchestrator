// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.nd6ravariables_onlinkipv6prefix_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class nd6ravariables_onlinkipv6prefix_binding : base_resource
  {
    private string ipv6prefixField = (string) null;
    private uint? vlanField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string ipv6prefix
    {
      get => this.ipv6prefixField;
      set => this.ipv6prefixField = value;
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
      nd6ravariables_onlinkipv6prefix_binding.nd6ravariables_onlinkipv6prefix_binding_response onlinkipv6prefixBindingResponse = new nd6ravariables_onlinkipv6prefix_binding.nd6ravariables_onlinkipv6prefix_binding_response();
      nd6ravariables_onlinkipv6prefix_binding.nd6ravariables_onlinkipv6prefix_binding_response resource = (nd6ravariables_onlinkipv6prefix_binding.nd6ravariables_onlinkipv6prefix_binding_response) service.get_payload_formatter().string_to_resource(onlinkipv6prefixBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nd6ravariables_onlinkipv6prefix_binding;
    }

    internal override string get_object_name() => this.vlan.HasValue ? this.vlan.ToString() : (string) null;

    public static base_response add(
      nitro_service client,
      nd6ravariables_onlinkipv6prefix_binding resource)
    {
      return new nd6ravariables_onlinkipv6prefix_binding()
      {
        vlan = resource.vlan,
        ipv6prefix = resource.ipv6prefix
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      nd6ravariables_onlinkipv6prefix_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nd6ravariables_onlinkipv6prefix_binding[] onlinkipv6prefixBindingArray = new nd6ravariables_onlinkipv6prefix_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          onlinkipv6prefixBindingArray[index] = new nd6ravariables_onlinkipv6prefix_binding();
          onlinkipv6prefixBindingArray[index].vlan = resources[index].vlan;
          onlinkipv6prefixBindingArray[index].ipv6prefix = resources[index].ipv6prefix;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) onlinkipv6prefixBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      nd6ravariables_onlinkipv6prefix_binding resource)
    {
      return new nd6ravariables_onlinkipv6prefix_binding()
      {
        vlan = resource.vlan,
        ipv6prefix = resource.ipv6prefix
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      nd6ravariables_onlinkipv6prefix_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nd6ravariables_onlinkipv6prefix_binding[] onlinkipv6prefixBindingArray = new nd6ravariables_onlinkipv6prefix_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          onlinkipv6prefixBindingArray[index] = new nd6ravariables_onlinkipv6prefix_binding();
          onlinkipv6prefixBindingArray[index].vlan = resources[index].vlan;
          onlinkipv6prefixBindingArray[index].ipv6prefix = resources[index].ipv6prefix;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) onlinkipv6prefixBindingArray);
      }
      return baseResponses;
    }

    public static nd6ravariables_onlinkipv6prefix_binding[] get(
      nitro_service service,
      uint? vlan)
    {
      return (nd6ravariables_onlinkipv6prefix_binding[]) new nd6ravariables_onlinkipv6prefix_binding()
      {
        vlan = vlan
      }.get_resources(service, (options) null);
    }

    public static nd6ravariables_onlinkipv6prefix_binding[] get_filtered(
      nitro_service service,
      uint? vlan,
      string filter)
    {
      nd6ravariables_onlinkipv6prefix_binding onlinkipv6prefixBinding = new nd6ravariables_onlinkipv6prefix_binding();
      onlinkipv6prefixBinding.vlan = vlan;
      options option = new options();
      option.set_filter(filter);
      return (nd6ravariables_onlinkipv6prefix_binding[]) onlinkipv6prefixBinding.getfiltered(service, option);
    }

    public static nd6ravariables_onlinkipv6prefix_binding[] get_filtered(
      nitro_service service,
      uint? vlan,
      filtervalue[] filter)
    {
      nd6ravariables_onlinkipv6prefix_binding onlinkipv6prefixBinding = new nd6ravariables_onlinkipv6prefix_binding();
      onlinkipv6prefixBinding.vlan = vlan;
      options option = new options();
      option.set_filter(filter);
      return (nd6ravariables_onlinkipv6prefix_binding[]) onlinkipv6prefixBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, uint? vlan)
    {
      nd6ravariables_onlinkipv6prefix_binding onlinkipv6prefixBinding = new nd6ravariables_onlinkipv6prefix_binding();
      onlinkipv6prefixBinding.vlan = vlan;
      options option = new options();
      option.set_count(true);
      nd6ravariables_onlinkipv6prefix_binding[] resources = (nd6ravariables_onlinkipv6prefix_binding[]) onlinkipv6prefixBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, uint? vlan, string filter)
    {
      nd6ravariables_onlinkipv6prefix_binding onlinkipv6prefixBinding = new nd6ravariables_onlinkipv6prefix_binding();
      onlinkipv6prefixBinding.vlan = vlan;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nd6ravariables_onlinkipv6prefix_binding[] onlinkipv6prefixBindingArray = (nd6ravariables_onlinkipv6prefix_binding[]) onlinkipv6prefixBinding.getfiltered(service, option);
      return onlinkipv6prefixBindingArray != null && onlinkipv6prefixBindingArray.Length > 0 ? onlinkipv6prefixBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, uint? vlan, filtervalue[] filter)
    {
      nd6ravariables_onlinkipv6prefix_binding onlinkipv6prefixBinding = new nd6ravariables_onlinkipv6prefix_binding();
      onlinkipv6prefixBinding.vlan = vlan;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nd6ravariables_onlinkipv6prefix_binding[] onlinkipv6prefixBindingArray = (nd6ravariables_onlinkipv6prefix_binding[]) onlinkipv6prefixBinding.getfiltered(service, option);
      return onlinkipv6prefixBindingArray != null && onlinkipv6prefixBindingArray.Length > 0 ? onlinkipv6prefixBindingArray[0].__count.Value : 0U;
    }

    private class nd6ravariables_onlinkipv6prefix_binding_response : base_response
    {
      public nd6ravariables_onlinkipv6prefix_binding[] nd6ravariables_onlinkipv6prefix_binding = (nd6ravariables_onlinkipv6prefix_binding[]) null;
    }
  }
}
