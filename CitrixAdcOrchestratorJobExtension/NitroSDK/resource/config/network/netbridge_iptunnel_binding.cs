// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.netbridge_iptunnel_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class netbridge_iptunnel_binding : base_resource
  {
    private string tunnelField = (string) null;
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

    public string tunnel
    {
      get => this.tunnelField;
      set => this.tunnelField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      netbridge_iptunnel_binding.netbridge_iptunnel_binding_response iptunnelBindingResponse = new netbridge_iptunnel_binding.netbridge_iptunnel_binding_response();
      netbridge_iptunnel_binding.netbridge_iptunnel_binding_response resource = (netbridge_iptunnel_binding.netbridge_iptunnel_binding_response) service.get_payload_formatter().string_to_resource(iptunnelBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.netbridge_iptunnel_binding;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      netbridge_iptunnel_binding resource)
    {
      return new netbridge_iptunnel_binding()
      {
        name = resource.name,
        tunnel = resource.tunnel
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      netbridge_iptunnel_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        netbridge_iptunnel_binding[] netbridgeIptunnelBindingArray = new netbridge_iptunnel_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          netbridgeIptunnelBindingArray[index] = new netbridge_iptunnel_binding();
          netbridgeIptunnelBindingArray[index].name = resources[index].name;
          netbridgeIptunnelBindingArray[index].tunnel = resources[index].tunnel;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) netbridgeIptunnelBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      netbridge_iptunnel_binding resource)
    {
      return new netbridge_iptunnel_binding()
      {
        name = resource.name,
        tunnel = resource.tunnel
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      netbridge_iptunnel_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        netbridge_iptunnel_binding[] netbridgeIptunnelBindingArray = new netbridge_iptunnel_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          netbridgeIptunnelBindingArray[index] = new netbridge_iptunnel_binding();
          netbridgeIptunnelBindingArray[index].name = resources[index].name;
          netbridgeIptunnelBindingArray[index].tunnel = resources[index].tunnel;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) netbridgeIptunnelBindingArray);
      }
      return baseResponses;
    }

    public static netbridge_iptunnel_binding[] get(
      nitro_service service,
      string name)
    {
      return (netbridge_iptunnel_binding[]) new netbridge_iptunnel_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static netbridge_iptunnel_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      netbridge_iptunnel_binding netbridgeIptunnelBinding = new netbridge_iptunnel_binding();
      netbridgeIptunnelBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (netbridge_iptunnel_binding[]) netbridgeIptunnelBinding.getfiltered(service, option);
    }

    public static netbridge_iptunnel_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      netbridge_iptunnel_binding netbridgeIptunnelBinding = new netbridge_iptunnel_binding();
      netbridgeIptunnelBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (netbridge_iptunnel_binding[]) netbridgeIptunnelBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      netbridge_iptunnel_binding netbridgeIptunnelBinding = new netbridge_iptunnel_binding();
      netbridgeIptunnelBinding.name = name;
      options option = new options();
      option.set_count(true);
      netbridge_iptunnel_binding[] resources = (netbridge_iptunnel_binding[]) netbridgeIptunnelBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      netbridge_iptunnel_binding netbridgeIptunnelBinding = new netbridge_iptunnel_binding();
      netbridgeIptunnelBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      netbridge_iptunnel_binding[] netbridgeIptunnelBindingArray = (netbridge_iptunnel_binding[]) netbridgeIptunnelBinding.getfiltered(service, option);
      return netbridgeIptunnelBindingArray != null && netbridgeIptunnelBindingArray.Length > 0 ? netbridgeIptunnelBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      netbridge_iptunnel_binding netbridgeIptunnelBinding = new netbridge_iptunnel_binding();
      netbridgeIptunnelBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      netbridge_iptunnel_binding[] netbridgeIptunnelBindingArray = (netbridge_iptunnel_binding[]) netbridgeIptunnelBinding.getfiltered(service, option);
      return netbridgeIptunnelBindingArray != null && netbridgeIptunnelBindingArray.Length > 0 ? netbridgeIptunnelBindingArray[0].__count.Value : 0U;
    }

    private class netbridge_iptunnel_binding_response : base_response
    {
      public netbridge_iptunnel_binding[] netbridge_iptunnel_binding = (netbridge_iptunnel_binding[]) null;
    }
  }
}
