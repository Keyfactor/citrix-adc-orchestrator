// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_vpnclientlessaccesspolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.vpn
{
  public class vpnglobal_vpnclientlessaccesspolicy_binding : base_resource
  {
    private string policynameField = (string) null;
    private uint? priorityField = new uint?();
    private string typeField = (string) null;
    private string[] builtinField = (string[]) null;
    private string globalbindtypeField = (string) null;
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

    public string globalbindtype
    {
      get => this.globalbindtypeField;
      set => this.globalbindtypeField = value;
    }

    public string[] builtin
    {
      get => this.builtinField;
      set => this.builtinField = value;
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

    public string type
    {
      get => this.typeField;
      set => this.typeField = value;
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
      vpnglobal_vpnclientlessaccesspolicy_binding.vpnglobal_vpnclientlessaccesspolicy_binding_response vpnclientlessaccesspolicyBindingResponse = new vpnglobal_vpnclientlessaccesspolicy_binding.vpnglobal_vpnclientlessaccesspolicy_binding_response();
      vpnglobal_vpnclientlessaccesspolicy_binding.vpnglobal_vpnclientlessaccesspolicy_binding_response resource = (vpnglobal_vpnclientlessaccesspolicy_binding.vpnglobal_vpnclientlessaccesspolicy_binding_response) service.get_payload_formatter().string_to_resource(vpnclientlessaccesspolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vpnglobal_vpnclientlessaccesspolicy_binding;
    }

    internal override string get_object_name() => (string) null;

    public static base_response add(
      nitro_service client,
      vpnglobal_vpnclientlessaccesspolicy_binding resource)
    {
      return new vpnglobal_vpnclientlessaccesspolicy_binding()
      {
        policyname = resource.policyname,
        priority = resource.priority,
        secondary = resource.secondary,
        groupextraction = resource.groupextraction
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      vpnglobal_vpnclientlessaccesspolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnglobal_vpnclientlessaccesspolicy_binding[] vpnclientlessaccesspolicyBindingArray = new vpnglobal_vpnclientlessaccesspolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnclientlessaccesspolicyBindingArray[index] = new vpnglobal_vpnclientlessaccesspolicy_binding();
          vpnclientlessaccesspolicyBindingArray[index].policyname = resources[index].policyname;
          vpnclientlessaccesspolicyBindingArray[index].priority = resources[index].priority;
          vpnclientlessaccesspolicyBindingArray[index].secondary = resources[index].secondary;
          vpnclientlessaccesspolicyBindingArray[index].groupextraction = resources[index].groupextraction;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) vpnclientlessaccesspolicyBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      vpnglobal_vpnclientlessaccesspolicy_binding resource)
    {
      return new vpnglobal_vpnclientlessaccesspolicy_binding()
      {
        policyname = resource.policyname,
        secondary = resource.secondary,
        groupextraction = resource.groupextraction
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      vpnglobal_vpnclientlessaccesspolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnglobal_vpnclientlessaccesspolicy_binding[] vpnclientlessaccesspolicyBindingArray = new vpnglobal_vpnclientlessaccesspolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnclientlessaccesspolicyBindingArray[index] = new vpnglobal_vpnclientlessaccesspolicy_binding();
          vpnclientlessaccesspolicyBindingArray[index].policyname = resources[index].policyname;
          vpnclientlessaccesspolicyBindingArray[index].secondary = resources[index].secondary;
          vpnclientlessaccesspolicyBindingArray[index].groupextraction = resources[index].groupextraction;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vpnclientlessaccesspolicyBindingArray);
      }
      return baseResponses;
    }

    public static vpnglobal_vpnclientlessaccesspolicy_binding[] get(
      nitro_service service)
    {
      return (vpnglobal_vpnclientlessaccesspolicy_binding[]) new vpnglobal_vpnclientlessaccesspolicy_binding().get_resources(service, (options) null);
    }

    public static vpnglobal_vpnclientlessaccesspolicy_binding[] get_filtered(
      nitro_service service,
      string filter)
    {
      vpnglobal_vpnclientlessaccesspolicy_binding vpnclientlessaccesspolicyBinding = new vpnglobal_vpnclientlessaccesspolicy_binding();
      options option = new options();
      option.set_filter(filter);
      return (vpnglobal_vpnclientlessaccesspolicy_binding[]) vpnclientlessaccesspolicyBinding.getfiltered(service, option);
    }

    public static vpnglobal_vpnclientlessaccesspolicy_binding[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      vpnglobal_vpnclientlessaccesspolicy_binding vpnclientlessaccesspolicyBinding = new vpnglobal_vpnclientlessaccesspolicy_binding();
      options option = new options();
      option.set_filter(filter);
      return (vpnglobal_vpnclientlessaccesspolicy_binding[]) vpnclientlessaccesspolicyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      vpnglobal_vpnclientlessaccesspolicy_binding vpnclientlessaccesspolicyBinding = new vpnglobal_vpnclientlessaccesspolicy_binding();
      options option = new options();
      option.set_count(true);
      vpnglobal_vpnclientlessaccesspolicy_binding[] resources = (vpnglobal_vpnclientlessaccesspolicy_binding[]) vpnclientlessaccesspolicyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      vpnglobal_vpnclientlessaccesspolicy_binding vpnclientlessaccesspolicyBinding = new vpnglobal_vpnclientlessaccesspolicy_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnglobal_vpnclientlessaccesspolicy_binding[] vpnclientlessaccesspolicyBindingArray = (vpnglobal_vpnclientlessaccesspolicy_binding[]) vpnclientlessaccesspolicyBinding.getfiltered(service, option);
      return vpnclientlessaccesspolicyBindingArray != null && vpnclientlessaccesspolicyBindingArray.Length > 0 ? vpnclientlessaccesspolicyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      vpnglobal_vpnclientlessaccesspolicy_binding vpnclientlessaccesspolicyBinding = new vpnglobal_vpnclientlessaccesspolicy_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnglobal_vpnclientlessaccesspolicy_binding[] vpnclientlessaccesspolicyBindingArray = (vpnglobal_vpnclientlessaccesspolicy_binding[]) vpnclientlessaccesspolicyBinding.getfiltered(service, option);
      return vpnclientlessaccesspolicyBindingArray != null && vpnclientlessaccesspolicyBindingArray.Length > 0 ? vpnclientlessaccesspolicyBindingArray[0].__count.Value : 0U;
    }

    private class vpnglobal_vpnclientlessaccesspolicy_binding_response : base_response
    {
      public vpnglobal_vpnclientlessaccesspolicy_binding[] vpnglobal_vpnclientlessaccesspolicy_binding = (vpnglobal_vpnclientlessaccesspolicy_binding[]) null;
    }

    public static class globalbindtypeEnum
    {
      public const string SYSTEM_GLOBAL = "SYSTEM_GLOBAL";
      public const string VPN_GLOBAL = "VPN_GLOBAL";
      public const string RNAT_GLOBAL = "RNAT_GLOBAL";
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }

    public static class typeEnum
    {
      public const string REQ_OVERRIDE = "REQ_OVERRIDE";
      public const string REQ_DEFAULT = "REQ_DEFAULT";
      public const string RES_OVERRIDE = "RES_OVERRIDE";
      public const string RES_DEFAULT = "RES_DEFAULT";
    }

    public static class staaddresstypeEnum
    {
      public const string IPV4 = "IPV4";
      public const string IPV6 = "IPV6";
    }
  }
}
