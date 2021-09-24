// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nstrafficdomain_vlan_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nstrafficdomain_vlan_binding : base_resource
  {
    private uint? vlanField = new uint?();
    private uint? tdField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public uint? vlan
    {
      get => this.vlanField;
      set => this.vlanField = value;
    }

    public uint? td
    {
      get => this.tdField;
      set => this.tdField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nstrafficdomain_vlan_binding.nstrafficdomain_vlan_binding_response vlanBindingResponse = new nstrafficdomain_vlan_binding.nstrafficdomain_vlan_binding_response();
      nstrafficdomain_vlan_binding.nstrafficdomain_vlan_binding_response resource = (nstrafficdomain_vlan_binding.nstrafficdomain_vlan_binding_response) service.get_payload_formatter().string_to_resource(vlanBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nstrafficdomain_vlan_binding;
    }

    internal override string get_object_name() => this.td.HasValue ? this.td.ToString() : (string) null;

    public static base_response add(
      nitro_service client,
      nstrafficdomain_vlan_binding resource)
    {
      return new nstrafficdomain_vlan_binding()
      {
        td = resource.td,
        vlan = resource.vlan
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      nstrafficdomain_vlan_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nstrafficdomain_vlan_binding[] nstrafficdomainVlanBindingArray = new nstrafficdomain_vlan_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nstrafficdomainVlanBindingArray[index] = new nstrafficdomain_vlan_binding();
          nstrafficdomainVlanBindingArray[index].td = resources[index].td;
          nstrafficdomainVlanBindingArray[index].vlan = resources[index].vlan;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) nstrafficdomainVlanBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      nstrafficdomain_vlan_binding resource)
    {
      return new nstrafficdomain_vlan_binding()
      {
        td = resource.td,
        vlan = resource.vlan
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      nstrafficdomain_vlan_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nstrafficdomain_vlan_binding[] nstrafficdomainVlanBindingArray = new nstrafficdomain_vlan_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nstrafficdomainVlanBindingArray[index] = new nstrafficdomain_vlan_binding();
          nstrafficdomainVlanBindingArray[index].td = resources[index].td;
          nstrafficdomainVlanBindingArray[index].vlan = resources[index].vlan;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nstrafficdomainVlanBindingArray);
      }
      return baseResponses;
    }

    public static nstrafficdomain_vlan_binding[] get(
      nitro_service service,
      uint? td)
    {
      return (nstrafficdomain_vlan_binding[]) new nstrafficdomain_vlan_binding()
      {
        td = td
      }.get_resources(service, (options) null);
    }

    public static nstrafficdomain_vlan_binding[] get_filtered(
      nitro_service service,
      uint? td,
      string filter)
    {
      nstrafficdomain_vlan_binding nstrafficdomainVlanBinding = new nstrafficdomain_vlan_binding();
      nstrafficdomainVlanBinding.td = td;
      options option = new options();
      option.set_filter(filter);
      return (nstrafficdomain_vlan_binding[]) nstrafficdomainVlanBinding.getfiltered(service, option);
    }

    public static nstrafficdomain_vlan_binding[] get_filtered(
      nitro_service service,
      uint? td,
      filtervalue[] filter)
    {
      nstrafficdomain_vlan_binding nstrafficdomainVlanBinding = new nstrafficdomain_vlan_binding();
      nstrafficdomainVlanBinding.td = td;
      options option = new options();
      option.set_filter(filter);
      return (nstrafficdomain_vlan_binding[]) nstrafficdomainVlanBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, uint? td)
    {
      nstrafficdomain_vlan_binding nstrafficdomainVlanBinding = new nstrafficdomain_vlan_binding();
      nstrafficdomainVlanBinding.td = td;
      options option = new options();
      option.set_count(true);
      nstrafficdomain_vlan_binding[] resources = (nstrafficdomain_vlan_binding[]) nstrafficdomainVlanBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, uint? td, string filter)
    {
      nstrafficdomain_vlan_binding nstrafficdomainVlanBinding = new nstrafficdomain_vlan_binding();
      nstrafficdomainVlanBinding.td = td;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nstrafficdomain_vlan_binding[] nstrafficdomainVlanBindingArray = (nstrafficdomain_vlan_binding[]) nstrafficdomainVlanBinding.getfiltered(service, option);
      return nstrafficdomainVlanBindingArray != null && nstrafficdomainVlanBindingArray.Length > 0 ? nstrafficdomainVlanBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, uint? td, filtervalue[] filter)
    {
      nstrafficdomain_vlan_binding nstrafficdomainVlanBinding = new nstrafficdomain_vlan_binding();
      nstrafficdomainVlanBinding.td = td;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nstrafficdomain_vlan_binding[] nstrafficdomainVlanBindingArray = (nstrafficdomain_vlan_binding[]) nstrafficdomainVlanBinding.getfiltered(service, option);
      return nstrafficdomainVlanBindingArray != null && nstrafficdomainVlanBindingArray.Length > 0 ? nstrafficdomainVlanBindingArray[0].__count.Value : 0U;
    }

    private class nstrafficdomain_vlan_binding_response : base_response
    {
      public nstrafficdomain_vlan_binding[] nstrafficdomain_vlan_binding = (nstrafficdomain_vlan_binding[]) null;
    }
  }
}
