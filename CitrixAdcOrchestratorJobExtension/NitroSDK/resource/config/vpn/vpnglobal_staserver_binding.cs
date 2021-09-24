// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_staserver_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.vpn
{
  public class vpnglobal_staserver_binding : base_resource
  {
    private string staserverField = (string) null;
    private string staauthidField = (string) null;
    private string staaddresstypeField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string staserver
    {
      get => this.staserverField;
      set => this.staserverField = value;
    }

    public string staaddresstype
    {
      get => this.staaddresstypeField;
      set => this.staaddresstypeField = value;
    }

    public string staauthid
    {
      get => this.staauthidField;
      private set => this.staauthidField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vpnglobal_staserver_binding.vpnglobal_staserver_binding_response staserverBindingResponse = new vpnglobal_staserver_binding.vpnglobal_staserver_binding_response();
      vpnglobal_staserver_binding.vpnglobal_staserver_binding_response resource = (vpnglobal_staserver_binding.vpnglobal_staserver_binding_response) service.get_payload_formatter().string_to_resource(staserverBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vpnglobal_staserver_binding;
    }

    internal override string get_object_name() => (string) null;

    public static base_response add(
      nitro_service client,
      vpnglobal_staserver_binding resource)
    {
      return new vpnglobal_staserver_binding()
      {
        staserver = resource.staserver,
        staaddresstype = resource.staaddresstype
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      vpnglobal_staserver_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnglobal_staserver_binding[] staserverBindingArray = new vpnglobal_staserver_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          staserverBindingArray[index] = new vpnglobal_staserver_binding();
          staserverBindingArray[index].staserver = resources[index].staserver;
          staserverBindingArray[index].staaddresstype = resources[index].staaddresstype;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) staserverBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      vpnglobal_staserver_binding resource)
    {
      return new vpnglobal_staserver_binding()
      {
        staserver = resource.staserver
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      vpnglobal_staserver_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnglobal_staserver_binding[] staserverBindingArray = new vpnglobal_staserver_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          staserverBindingArray[index] = new vpnglobal_staserver_binding();
          staserverBindingArray[index].staserver = resources[index].staserver;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) staserverBindingArray);
      }
      return baseResponses;
    }

    public static vpnglobal_staserver_binding[] get(nitro_service service) => (vpnglobal_staserver_binding[]) new vpnglobal_staserver_binding().get_resources(service, (options) null);

    public static vpnglobal_staserver_binding[] get_filtered(
      nitro_service service,
      string filter)
    {
      vpnglobal_staserver_binding staserverBinding = new vpnglobal_staserver_binding();
      options option = new options();
      option.set_filter(filter);
      return (vpnglobal_staserver_binding[]) staserverBinding.getfiltered(service, option);
    }

    public static vpnglobal_staserver_binding[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      vpnglobal_staserver_binding staserverBinding = new vpnglobal_staserver_binding();
      options option = new options();
      option.set_filter(filter);
      return (vpnglobal_staserver_binding[]) staserverBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      vpnglobal_staserver_binding staserverBinding = new vpnglobal_staserver_binding();
      options option = new options();
      option.set_count(true);
      vpnglobal_staserver_binding[] resources = (vpnglobal_staserver_binding[]) staserverBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      vpnglobal_staserver_binding staserverBinding = new vpnglobal_staserver_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnglobal_staserver_binding[] staserverBindingArray = (vpnglobal_staserver_binding[]) staserverBinding.getfiltered(service, option);
      return staserverBindingArray != null && staserverBindingArray.Length > 0 ? staserverBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      vpnglobal_staserver_binding staserverBinding = new vpnglobal_staserver_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnglobal_staserver_binding[] staserverBindingArray = (vpnglobal_staserver_binding[]) staserverBinding.getfiltered(service, option);
      return staserverBindingArray != null && staserverBindingArray.Length > 0 ? staserverBindingArray[0].__count.Value : 0U;
    }

    private class vpnglobal_staserver_binding_response : base_response
    {
      public vpnglobal_staserver_binding[] vpnglobal_staserver_binding = (vpnglobal_staserver_binding[]) null;
    }

    public static class staaddresstypeEnum
    {
      public const string IPV4 = "IPV4";
      public const string IPV6 = "IPV6";
    }
  }
}
