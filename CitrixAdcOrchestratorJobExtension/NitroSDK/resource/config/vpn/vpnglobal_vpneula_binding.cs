// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_vpneula_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.vpn
{
  public class vpnglobal_vpneula_binding : base_resource
  {
    private string eulaField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string eula
    {
      get => this.eulaField;
      set => this.eulaField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vpnglobal_vpneula_binding.vpnglobal_vpneula_binding_response vpneulaBindingResponse = new vpnglobal_vpneula_binding.vpnglobal_vpneula_binding_response();
      vpnglobal_vpneula_binding.vpnglobal_vpneula_binding_response resource = (vpnglobal_vpneula_binding.vpnglobal_vpneula_binding_response) service.get_payload_formatter().string_to_resource(vpneulaBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vpnglobal_vpneula_binding;
    }

    internal override string get_object_name() => (string) null;

    public static base_response add(
      nitro_service client,
      vpnglobal_vpneula_binding resource)
    {
      return new vpnglobal_vpneula_binding()
      {
        eula = resource.eula
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      vpnglobal_vpneula_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnglobal_vpneula_binding[] vpnglobalVpneulaBindingArray = new vpnglobal_vpneula_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnglobalVpneulaBindingArray[index] = new vpnglobal_vpneula_binding();
          vpnglobalVpneulaBindingArray[index].eula = resources[index].eula;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) vpnglobalVpneulaBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      vpnglobal_vpneula_binding resource)
    {
      return new vpnglobal_vpneula_binding()
      {
        eula = resource.eula
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      vpnglobal_vpneula_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnglobal_vpneula_binding[] vpnglobalVpneulaBindingArray = new vpnglobal_vpneula_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnglobalVpneulaBindingArray[index] = new vpnglobal_vpneula_binding();
          vpnglobalVpneulaBindingArray[index].eula = resources[index].eula;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vpnglobalVpneulaBindingArray);
      }
      return baseResponses;
    }

    public static vpnglobal_vpneula_binding[] get(nitro_service service) => (vpnglobal_vpneula_binding[]) new vpnglobal_vpneula_binding().get_resources(service, (options) null);

    public static vpnglobal_vpneula_binding[] get_filtered(
      nitro_service service,
      string filter)
    {
      vpnglobal_vpneula_binding vpnglobalVpneulaBinding = new vpnglobal_vpneula_binding();
      options option = new options();
      option.set_filter(filter);
      return (vpnglobal_vpneula_binding[]) vpnglobalVpneulaBinding.getfiltered(service, option);
    }

    public static vpnglobal_vpneula_binding[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      vpnglobal_vpneula_binding vpnglobalVpneulaBinding = new vpnglobal_vpneula_binding();
      options option = new options();
      option.set_filter(filter);
      return (vpnglobal_vpneula_binding[]) vpnglobalVpneulaBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      vpnglobal_vpneula_binding vpnglobalVpneulaBinding = new vpnglobal_vpneula_binding();
      options option = new options();
      option.set_count(true);
      vpnglobal_vpneula_binding[] resources = (vpnglobal_vpneula_binding[]) vpnglobalVpneulaBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      vpnglobal_vpneula_binding vpnglobalVpneulaBinding = new vpnglobal_vpneula_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnglobal_vpneula_binding[] vpnglobalVpneulaBindingArray = (vpnglobal_vpneula_binding[]) vpnglobalVpneulaBinding.getfiltered(service, option);
      return vpnglobalVpneulaBindingArray != null && vpnglobalVpneulaBindingArray.Length > 0 ? vpnglobalVpneulaBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      vpnglobal_vpneula_binding vpnglobalVpneulaBinding = new vpnglobal_vpneula_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnglobal_vpneula_binding[] vpnglobalVpneulaBindingArray = (vpnglobal_vpneula_binding[]) vpnglobalVpneulaBinding.getfiltered(service, option);
      return vpnglobalVpneulaBindingArray != null && vpnglobalVpneulaBindingArray.Length > 0 ? vpnglobalVpneulaBindingArray[0].__count.Value : 0U;
    }

    private class vpnglobal_vpneula_binding_response : base_response
    {
      public vpnglobal_vpneula_binding[] vpnglobal_vpneula_binding = (vpnglobal_vpneula_binding[]) null;
    }
  }
}
