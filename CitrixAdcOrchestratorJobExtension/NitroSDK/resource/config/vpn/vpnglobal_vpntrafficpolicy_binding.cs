// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_vpntrafficpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.vpn
{
  public class vpnglobal_vpntrafficpolicy_binding : base_resource
  {
    private string policynameField = (string) null;
    private uint? priorityField = new uint?();
    private bool? secondaryField = new bool?();
    private bool? groupextractionField = new bool?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public uint? priority
    {
      get => this.priorityField;
      set => this.priorityField = value;
    }

    public string policyname
    {
      get => this.policynameField;
      set => this.policynameField = value;
    }

    public bool? secondary
    {
      get => this.secondaryField;
      set => this.secondaryField = value;
    }

    public bool? groupextraction
    {
      get => this.groupextractionField;
      set => this.groupextractionField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vpnglobal_vpntrafficpolicy_binding.vpnglobal_vpntrafficpolicy_binding_response vpntrafficpolicyBindingResponse = new vpnglobal_vpntrafficpolicy_binding.vpnglobal_vpntrafficpolicy_binding_response();
      vpnglobal_vpntrafficpolicy_binding.vpnglobal_vpntrafficpolicy_binding_response resource = (vpnglobal_vpntrafficpolicy_binding.vpnglobal_vpntrafficpolicy_binding_response) service.get_payload_formatter().string_to_resource(vpntrafficpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vpnglobal_vpntrafficpolicy_binding;
    }

    internal override string get_object_name() => (string) null;

    public static base_response add(
      nitro_service client,
      vpnglobal_vpntrafficpolicy_binding resource)
    {
      return new vpnglobal_vpntrafficpolicy_binding()
      {
        policyname = resource.policyname,
        priority = resource.priority,
        secondary = resource.secondary,
        groupextraction = resource.groupextraction
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      vpnglobal_vpntrafficpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnglobal_vpntrafficpolicy_binding[] vpntrafficpolicyBindingArray = new vpnglobal_vpntrafficpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpntrafficpolicyBindingArray[index] = new vpnglobal_vpntrafficpolicy_binding();
          vpntrafficpolicyBindingArray[index].policyname = resources[index].policyname;
          vpntrafficpolicyBindingArray[index].priority = resources[index].priority;
          vpntrafficpolicyBindingArray[index].secondary = resources[index].secondary;
          vpntrafficpolicyBindingArray[index].groupextraction = resources[index].groupextraction;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) vpntrafficpolicyBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      vpnglobal_vpntrafficpolicy_binding resource)
    {
      return new vpnglobal_vpntrafficpolicy_binding()
      {
        policyname = resource.policyname,
        secondary = resource.secondary,
        groupextraction = resource.groupextraction
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      vpnglobal_vpntrafficpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnglobal_vpntrafficpolicy_binding[] vpntrafficpolicyBindingArray = new vpnglobal_vpntrafficpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpntrafficpolicyBindingArray[index] = new vpnglobal_vpntrafficpolicy_binding();
          vpntrafficpolicyBindingArray[index].policyname = resources[index].policyname;
          vpntrafficpolicyBindingArray[index].secondary = resources[index].secondary;
          vpntrafficpolicyBindingArray[index].groupextraction = resources[index].groupextraction;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vpntrafficpolicyBindingArray);
      }
      return baseResponses;
    }

    public static vpnglobal_vpntrafficpolicy_binding[] get(
      nitro_service service)
    {
      return (vpnglobal_vpntrafficpolicy_binding[]) new vpnglobal_vpntrafficpolicy_binding().get_resources(service, (options) null);
    }

    public static vpnglobal_vpntrafficpolicy_binding[] get_filtered(
      nitro_service service,
      string filter)
    {
      vpnglobal_vpntrafficpolicy_binding vpntrafficpolicyBinding = new vpnglobal_vpntrafficpolicy_binding();
      options option = new options();
      option.set_filter(filter);
      return (vpnglobal_vpntrafficpolicy_binding[]) vpntrafficpolicyBinding.getfiltered(service, option);
    }

    public static vpnglobal_vpntrafficpolicy_binding[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      vpnglobal_vpntrafficpolicy_binding vpntrafficpolicyBinding = new vpnglobal_vpntrafficpolicy_binding();
      options option = new options();
      option.set_filter(filter);
      return (vpnglobal_vpntrafficpolicy_binding[]) vpntrafficpolicyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      vpnglobal_vpntrafficpolicy_binding vpntrafficpolicyBinding = new vpnglobal_vpntrafficpolicy_binding();
      options option = new options();
      option.set_count(true);
      vpnglobal_vpntrafficpolicy_binding[] resources = (vpnglobal_vpntrafficpolicy_binding[]) vpntrafficpolicyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      vpnglobal_vpntrafficpolicy_binding vpntrafficpolicyBinding = new vpnglobal_vpntrafficpolicy_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnglobal_vpntrafficpolicy_binding[] vpntrafficpolicyBindingArray = (vpnglobal_vpntrafficpolicy_binding[]) vpntrafficpolicyBinding.getfiltered(service, option);
      return vpntrafficpolicyBindingArray != null && vpntrafficpolicyBindingArray.Length > 0 ? vpntrafficpolicyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      vpnglobal_vpntrafficpolicy_binding vpntrafficpolicyBinding = new vpnglobal_vpntrafficpolicy_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnglobal_vpntrafficpolicy_binding[] vpntrafficpolicyBindingArray = (vpnglobal_vpntrafficpolicy_binding[]) vpntrafficpolicyBinding.getfiltered(service, option);
      return vpntrafficpolicyBindingArray != null && vpntrafficpolicyBindingArray.Length > 0 ? vpntrafficpolicyBindingArray[0].__count.Value : 0U;
    }

    private class vpnglobal_vpntrafficpolicy_binding_response : base_response
    {
      public vpnglobal_vpntrafficpolicy_binding[] vpnglobal_vpntrafficpolicy_binding = (vpnglobal_vpntrafficpolicy_binding[]) null;
    }

    public static class staaddresstypeEnum
    {
      public const string IPV4 = "IPV4";
      public const string IPV6 = "IPV6";
    }
  }
}
