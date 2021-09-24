// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.bridgegroup_nsip_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class bridgegroup_nsip_binding : base_resource
  {
    private string ipaddressField = (string) null;
    private uint? tdField = new uint?();
    private string netmaskField = (string) null;
    private bool? rnatField = new bool?();
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

    public bool? rnat
    {
      get => this.rnatField;
      private set => this.rnatField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      bridgegroup_nsip_binding.bridgegroup_nsip_binding_response nsipBindingResponse = new bridgegroup_nsip_binding.bridgegroup_nsip_binding_response();
      bridgegroup_nsip_binding.bridgegroup_nsip_binding_response resource = (bridgegroup_nsip_binding.bridgegroup_nsip_binding_response) service.get_payload_formatter().string_to_resource(nsipBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.bridgegroup_nsip_binding;
    }

    internal override string get_object_name() => this.id.HasValue ? this.id.ToString() : (string) null;

    public static base_response add(
      nitro_service client,
      bridgegroup_nsip_binding resource)
    {
      return new bridgegroup_nsip_binding()
      {
        id = resource.id,
        ipaddress = resource.ipaddress,
        netmask = resource.netmask,
        td = resource.td
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      bridgegroup_nsip_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        bridgegroup_nsip_binding[] bridgegroupNsipBindingArray = new bridgegroup_nsip_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          bridgegroupNsipBindingArray[index] = new bridgegroup_nsip_binding();
          bridgegroupNsipBindingArray[index].id = resources[index].id;
          bridgegroupNsipBindingArray[index].ipaddress = resources[index].ipaddress;
          bridgegroupNsipBindingArray[index].netmask = resources[index].netmask;
          bridgegroupNsipBindingArray[index].td = resources[index].td;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) bridgegroupNsipBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      bridgegroup_nsip_binding resource)
    {
      return new bridgegroup_nsip_binding()
      {
        id = resource.id,
        ipaddress = resource.ipaddress,
        netmask = resource.netmask,
        td = resource.td
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      bridgegroup_nsip_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        bridgegroup_nsip_binding[] bridgegroupNsipBindingArray = new bridgegroup_nsip_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          bridgegroupNsipBindingArray[index] = new bridgegroup_nsip_binding();
          bridgegroupNsipBindingArray[index].id = resources[index].id;
          bridgegroupNsipBindingArray[index].ipaddress = resources[index].ipaddress;
          bridgegroupNsipBindingArray[index].netmask = resources[index].netmask;
          bridgegroupNsipBindingArray[index].td = resources[index].td;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) bridgegroupNsipBindingArray);
      }
      return baseResponses;
    }

    public static bridgegroup_nsip_binding[] get(
      nitro_service service,
      uint? id)
    {
      return (bridgegroup_nsip_binding[]) new bridgegroup_nsip_binding()
      {
        id = id
      }.get_resources(service, (options) null);
    }

    public static bridgegroup_nsip_binding[] get_filtered(
      nitro_service service,
      uint? id,
      string filter)
    {
      bridgegroup_nsip_binding bridgegroupNsipBinding = new bridgegroup_nsip_binding();
      bridgegroupNsipBinding.id = id;
      options option = new options();
      option.set_filter(filter);
      return (bridgegroup_nsip_binding[]) bridgegroupNsipBinding.getfiltered(service, option);
    }

    public static bridgegroup_nsip_binding[] get_filtered(
      nitro_service service,
      uint? id,
      filtervalue[] filter)
    {
      bridgegroup_nsip_binding bridgegroupNsipBinding = new bridgegroup_nsip_binding();
      bridgegroupNsipBinding.id = id;
      options option = new options();
      option.set_filter(filter);
      return (bridgegroup_nsip_binding[]) bridgegroupNsipBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, uint? id)
    {
      bridgegroup_nsip_binding bridgegroupNsipBinding = new bridgegroup_nsip_binding();
      bridgegroupNsipBinding.id = id;
      options option = new options();
      option.set_count(true);
      bridgegroup_nsip_binding[] resources = (bridgegroup_nsip_binding[]) bridgegroupNsipBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, uint? id, string filter)
    {
      bridgegroup_nsip_binding bridgegroupNsipBinding = new bridgegroup_nsip_binding();
      bridgegroupNsipBinding.id = id;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      bridgegroup_nsip_binding[] bridgegroupNsipBindingArray = (bridgegroup_nsip_binding[]) bridgegroupNsipBinding.getfiltered(service, option);
      return bridgegroupNsipBindingArray != null && bridgegroupNsipBindingArray.Length > 0 ? bridgegroupNsipBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, uint? id, filtervalue[] filter)
    {
      bridgegroup_nsip_binding bridgegroupNsipBinding = new bridgegroup_nsip_binding();
      bridgegroupNsipBinding.id = id;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      bridgegroup_nsip_binding[] bridgegroupNsipBindingArray = (bridgegroup_nsip_binding[]) bridgegroupNsipBinding.getfiltered(service, option);
      return bridgegroupNsipBindingArray != null && bridgegroupNsipBindingArray.Length > 0 ? bridgegroupNsipBindingArray[0].__count.Value : 0U;
    }

    private class bridgegroup_nsip_binding_response : base_response
    {
      public bridgegroup_nsip_binding[] bridgegroup_nsip_binding = (bridgegroup_nsip_binding[]) null;
    }
  }
}
