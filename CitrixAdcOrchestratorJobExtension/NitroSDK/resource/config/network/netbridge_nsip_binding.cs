// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.netbridge_nsip_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class netbridge_nsip_binding : base_resource
  {
    private string ipaddressField = (string) null;
    private string netmaskField = (string) null;
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
      netbridge_nsip_binding.netbridge_nsip_binding_response nsipBindingResponse = new netbridge_nsip_binding.netbridge_nsip_binding_response();
      netbridge_nsip_binding.netbridge_nsip_binding_response resource = (netbridge_nsip_binding.netbridge_nsip_binding_response) service.get_payload_formatter().string_to_resource(nsipBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.netbridge_nsip_binding;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      netbridge_nsip_binding resource)
    {
      return new netbridge_nsip_binding()
      {
        name = resource.name,
        ipaddress = resource.ipaddress,
        netmask = resource.netmask
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      netbridge_nsip_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        netbridge_nsip_binding[] netbridgeNsipBindingArray = new netbridge_nsip_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          netbridgeNsipBindingArray[index] = new netbridge_nsip_binding();
          netbridgeNsipBindingArray[index].name = resources[index].name;
          netbridgeNsipBindingArray[index].ipaddress = resources[index].ipaddress;
          netbridgeNsipBindingArray[index].netmask = resources[index].netmask;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) netbridgeNsipBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      netbridge_nsip_binding resource)
    {
      return new netbridge_nsip_binding()
      {
        name = resource.name,
        ipaddress = resource.ipaddress,
        netmask = resource.netmask
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      netbridge_nsip_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        netbridge_nsip_binding[] netbridgeNsipBindingArray = new netbridge_nsip_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          netbridgeNsipBindingArray[index] = new netbridge_nsip_binding();
          netbridgeNsipBindingArray[index].name = resources[index].name;
          netbridgeNsipBindingArray[index].ipaddress = resources[index].ipaddress;
          netbridgeNsipBindingArray[index].netmask = resources[index].netmask;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) netbridgeNsipBindingArray);
      }
      return baseResponses;
    }

    public static netbridge_nsip_binding[] get(
      nitro_service service,
      string name)
    {
      return (netbridge_nsip_binding[]) new netbridge_nsip_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static netbridge_nsip_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      netbridge_nsip_binding netbridgeNsipBinding = new netbridge_nsip_binding();
      netbridgeNsipBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (netbridge_nsip_binding[]) netbridgeNsipBinding.getfiltered(service, option);
    }

    public static netbridge_nsip_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      netbridge_nsip_binding netbridgeNsipBinding = new netbridge_nsip_binding();
      netbridgeNsipBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (netbridge_nsip_binding[]) netbridgeNsipBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      netbridge_nsip_binding netbridgeNsipBinding = new netbridge_nsip_binding();
      netbridgeNsipBinding.name = name;
      options option = new options();
      option.set_count(true);
      netbridge_nsip_binding[] resources = (netbridge_nsip_binding[]) netbridgeNsipBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      netbridge_nsip_binding netbridgeNsipBinding = new netbridge_nsip_binding();
      netbridgeNsipBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      netbridge_nsip_binding[] netbridgeNsipBindingArray = (netbridge_nsip_binding[]) netbridgeNsipBinding.getfiltered(service, option);
      return netbridgeNsipBindingArray != null && netbridgeNsipBindingArray.Length > 0 ? netbridgeNsipBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      netbridge_nsip_binding netbridgeNsipBinding = new netbridge_nsip_binding();
      netbridgeNsipBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      netbridge_nsip_binding[] netbridgeNsipBindingArray = (netbridge_nsip_binding[]) netbridgeNsipBinding.getfiltered(service, option);
      return netbridgeNsipBindingArray != null && netbridgeNsipBindingArray.Length > 0 ? netbridgeNsipBindingArray[0].__count.Value : 0U;
    }

    private class netbridge_nsip_binding_response : base_response
    {
      public netbridge_nsip_binding[] netbridge_nsip_binding = (netbridge_nsip_binding[]) null;
    }
  }
}
