// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nstrafficdomain_vxlan_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nstrafficdomain_vxlan_binding : base_resource
  {
    private uint? vxlanField = new uint?();
    private uint? tdField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public uint? td
    {
      get => this.tdField;
      set => this.tdField = value;
    }

    public uint? vxlan
    {
      get => this.vxlanField;
      set => this.vxlanField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nstrafficdomain_vxlan_binding.nstrafficdomain_vxlan_binding_response vxlanBindingResponse = new nstrafficdomain_vxlan_binding.nstrafficdomain_vxlan_binding_response();
      nstrafficdomain_vxlan_binding.nstrafficdomain_vxlan_binding_response resource = (nstrafficdomain_vxlan_binding.nstrafficdomain_vxlan_binding_response) service.get_payload_formatter().string_to_resource(vxlanBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nstrafficdomain_vxlan_binding;
    }

    internal override string get_object_name() => this.td.HasValue ? this.td.ToString() : (string) null;

    public static base_response add(
      nitro_service client,
      nstrafficdomain_vxlan_binding resource)
    {
      return new nstrafficdomain_vxlan_binding()
      {
        td = resource.td,
        vxlan = resource.vxlan
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      nstrafficdomain_vxlan_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nstrafficdomain_vxlan_binding[] nstrafficdomainVxlanBindingArray = new nstrafficdomain_vxlan_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nstrafficdomainVxlanBindingArray[index] = new nstrafficdomain_vxlan_binding();
          nstrafficdomainVxlanBindingArray[index].td = resources[index].td;
          nstrafficdomainVxlanBindingArray[index].vxlan = resources[index].vxlan;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) nstrafficdomainVxlanBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      nstrafficdomain_vxlan_binding resource)
    {
      return new nstrafficdomain_vxlan_binding()
      {
        td = resource.td,
        vxlan = resource.vxlan
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      nstrafficdomain_vxlan_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nstrafficdomain_vxlan_binding[] nstrafficdomainVxlanBindingArray = new nstrafficdomain_vxlan_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nstrafficdomainVxlanBindingArray[index] = new nstrafficdomain_vxlan_binding();
          nstrafficdomainVxlanBindingArray[index].td = resources[index].td;
          nstrafficdomainVxlanBindingArray[index].vxlan = resources[index].vxlan;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nstrafficdomainVxlanBindingArray);
      }
      return baseResponses;
    }

    public static nstrafficdomain_vxlan_binding[] get(
      nitro_service service,
      uint? td)
    {
      return (nstrafficdomain_vxlan_binding[]) new nstrafficdomain_vxlan_binding()
      {
        td = td
      }.get_resources(service, (options) null);
    }

    public static nstrafficdomain_vxlan_binding[] get_filtered(
      nitro_service service,
      uint? td,
      string filter)
    {
      nstrafficdomain_vxlan_binding nstrafficdomainVxlanBinding = new nstrafficdomain_vxlan_binding();
      nstrafficdomainVxlanBinding.td = td;
      options option = new options();
      option.set_filter(filter);
      return (nstrafficdomain_vxlan_binding[]) nstrafficdomainVxlanBinding.getfiltered(service, option);
    }

    public static nstrafficdomain_vxlan_binding[] get_filtered(
      nitro_service service,
      uint? td,
      filtervalue[] filter)
    {
      nstrafficdomain_vxlan_binding nstrafficdomainVxlanBinding = new nstrafficdomain_vxlan_binding();
      nstrafficdomainVxlanBinding.td = td;
      options option = new options();
      option.set_filter(filter);
      return (nstrafficdomain_vxlan_binding[]) nstrafficdomainVxlanBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, uint? td)
    {
      nstrafficdomain_vxlan_binding nstrafficdomainVxlanBinding = new nstrafficdomain_vxlan_binding();
      nstrafficdomainVxlanBinding.td = td;
      options option = new options();
      option.set_count(true);
      nstrafficdomain_vxlan_binding[] resources = (nstrafficdomain_vxlan_binding[]) nstrafficdomainVxlanBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, uint? td, string filter)
    {
      nstrafficdomain_vxlan_binding nstrafficdomainVxlanBinding = new nstrafficdomain_vxlan_binding();
      nstrafficdomainVxlanBinding.td = td;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nstrafficdomain_vxlan_binding[] nstrafficdomainVxlanBindingArray = (nstrafficdomain_vxlan_binding[]) nstrafficdomainVxlanBinding.getfiltered(service, option);
      return nstrafficdomainVxlanBindingArray != null && nstrafficdomainVxlanBindingArray.Length > 0 ? nstrafficdomainVxlanBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, uint? td, filtervalue[] filter)
    {
      nstrafficdomain_vxlan_binding nstrafficdomainVxlanBinding = new nstrafficdomain_vxlan_binding();
      nstrafficdomainVxlanBinding.td = td;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nstrafficdomain_vxlan_binding[] nstrafficdomainVxlanBindingArray = (nstrafficdomain_vxlan_binding[]) nstrafficdomainVxlanBinding.getfiltered(service, option);
      return nstrafficdomainVxlanBindingArray != null && nstrafficdomainVxlanBindingArray.Length > 0 ? nstrafficdomainVxlanBindingArray[0].__count.Value : 0U;
    }

    private class nstrafficdomain_vxlan_binding_response : base_response
    {
      public nstrafficdomain_vxlan_binding[] nstrafficdomain_vxlan_binding = (nstrafficdomain_vxlan_binding[]) null;
    }
  }
}
