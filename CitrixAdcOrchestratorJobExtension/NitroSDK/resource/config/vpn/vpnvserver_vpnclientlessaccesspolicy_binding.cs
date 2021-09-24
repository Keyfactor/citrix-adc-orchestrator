// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_vpnclientlessaccesspolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.vpn
{
  public class vpnvserver_vpnclientlessaccesspolicy_binding : base_resource
  {
    private string policyField = (string) null;
    private uint? priorityField = new uint?();
    private string bindpointField = (string) null;
    private string gotopriorityexpressionField = (string) null;
    private uint? acttypeField = new uint?();
    private string nameField = (string) null;
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

    public string gotopriorityexpression
    {
      get => this.gotopriorityexpressionField;
      set => this.gotopriorityexpressionField = value;
    }

    public string policy
    {
      get => this.policyField;
      set => this.policyField = value;
    }

    public bool? groupextraction
    {
      get => this.groupextractionField;
      set => this.groupextractionField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public bool? secondary
    {
      get => this.secondaryField;
      set => this.secondaryField = value;
    }

    public string bindpoint
    {
      get => this.bindpointField;
      set => this.bindpointField = value;
    }

    public uint? acttype
    {
      get => this.acttypeField;
      private set => this.acttypeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vpnvserver_vpnclientlessaccesspolicy_binding.vpnvserver_vpnclientlessaccesspolicy_binding_response vpnclientlessaccesspolicyBindingResponse = new vpnvserver_vpnclientlessaccesspolicy_binding.vpnvserver_vpnclientlessaccesspolicy_binding_response();
      vpnvserver_vpnclientlessaccesspolicy_binding.vpnvserver_vpnclientlessaccesspolicy_binding_response resource = (vpnvserver_vpnclientlessaccesspolicy_binding.vpnvserver_vpnclientlessaccesspolicy_binding_response) service.get_payload_formatter().string_to_resource(vpnclientlessaccesspolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vpnvserver_vpnclientlessaccesspolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      vpnvserver_vpnclientlessaccesspolicy_binding resource)
    {
      return new vpnvserver_vpnclientlessaccesspolicy_binding()
      {
        name = resource.name,
        policy = resource.policy,
        priority = resource.priority,
        secondary = resource.secondary,
        groupextraction = resource.groupextraction,
        gotopriorityexpression = resource.gotopriorityexpression,
        bindpoint = resource.bindpoint
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      vpnvserver_vpnclientlessaccesspolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnvserver_vpnclientlessaccesspolicy_binding[] vpnclientlessaccesspolicyBindingArray = new vpnvserver_vpnclientlessaccesspolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnclientlessaccesspolicyBindingArray[index] = new vpnvserver_vpnclientlessaccesspolicy_binding();
          vpnclientlessaccesspolicyBindingArray[index].name = resources[index].name;
          vpnclientlessaccesspolicyBindingArray[index].policy = resources[index].policy;
          vpnclientlessaccesspolicyBindingArray[index].priority = resources[index].priority;
          vpnclientlessaccesspolicyBindingArray[index].secondary = resources[index].secondary;
          vpnclientlessaccesspolicyBindingArray[index].groupextraction = resources[index].groupextraction;
          vpnclientlessaccesspolicyBindingArray[index].gotopriorityexpression = resources[index].gotopriorityexpression;
          vpnclientlessaccesspolicyBindingArray[index].bindpoint = resources[index].bindpoint;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) vpnclientlessaccesspolicyBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      vpnvserver_vpnclientlessaccesspolicy_binding resource)
    {
      return new vpnvserver_vpnclientlessaccesspolicy_binding()
      {
        name = resource.name,
        policy = resource.policy,
        secondary = resource.secondary,
        groupextraction = resource.groupextraction,
        bindpoint = resource.bindpoint
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      vpnvserver_vpnclientlessaccesspolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnvserver_vpnclientlessaccesspolicy_binding[] vpnclientlessaccesspolicyBindingArray = new vpnvserver_vpnclientlessaccesspolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnclientlessaccesspolicyBindingArray[index] = new vpnvserver_vpnclientlessaccesspolicy_binding();
          vpnclientlessaccesspolicyBindingArray[index].name = resources[index].name;
          vpnclientlessaccesspolicyBindingArray[index].policy = resources[index].policy;
          vpnclientlessaccesspolicyBindingArray[index].secondary = resources[index].secondary;
          vpnclientlessaccesspolicyBindingArray[index].groupextraction = resources[index].groupextraction;
          vpnclientlessaccesspolicyBindingArray[index].bindpoint = resources[index].bindpoint;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vpnclientlessaccesspolicyBindingArray);
      }
      return baseResponses;
    }

    public static vpnvserver_vpnclientlessaccesspolicy_binding[] get(
      nitro_service service,
      string name)
    {
      return (vpnvserver_vpnclientlessaccesspolicy_binding[]) new vpnvserver_vpnclientlessaccesspolicy_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static vpnvserver_vpnclientlessaccesspolicy_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      vpnvserver_vpnclientlessaccesspolicy_binding vpnclientlessaccesspolicyBinding = new vpnvserver_vpnclientlessaccesspolicy_binding();
      vpnclientlessaccesspolicyBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (vpnvserver_vpnclientlessaccesspolicy_binding[]) vpnclientlessaccesspolicyBinding.getfiltered(service, option);
    }

    public static vpnvserver_vpnclientlessaccesspolicy_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      vpnvserver_vpnclientlessaccesspolicy_binding vpnclientlessaccesspolicyBinding = new vpnvserver_vpnclientlessaccesspolicy_binding();
      vpnclientlessaccesspolicyBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (vpnvserver_vpnclientlessaccesspolicy_binding[]) vpnclientlessaccesspolicyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      vpnvserver_vpnclientlessaccesspolicy_binding vpnclientlessaccesspolicyBinding = new vpnvserver_vpnclientlessaccesspolicy_binding();
      vpnclientlessaccesspolicyBinding.name = name;
      options option = new options();
      option.set_count(true);
      vpnvserver_vpnclientlessaccesspolicy_binding[] resources = (vpnvserver_vpnclientlessaccesspolicy_binding[]) vpnclientlessaccesspolicyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      vpnvserver_vpnclientlessaccesspolicy_binding vpnclientlessaccesspolicyBinding = new vpnvserver_vpnclientlessaccesspolicy_binding();
      vpnclientlessaccesspolicyBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnvserver_vpnclientlessaccesspolicy_binding[] vpnclientlessaccesspolicyBindingArray = (vpnvserver_vpnclientlessaccesspolicy_binding[]) vpnclientlessaccesspolicyBinding.getfiltered(service, option);
      return vpnclientlessaccesspolicyBindingArray != null && vpnclientlessaccesspolicyBindingArray.Length > 0 ? vpnclientlessaccesspolicyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      vpnvserver_vpnclientlessaccesspolicy_binding vpnclientlessaccesspolicyBinding = new vpnvserver_vpnclientlessaccesspolicy_binding();
      vpnclientlessaccesspolicyBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnvserver_vpnclientlessaccesspolicy_binding[] vpnclientlessaccesspolicyBindingArray = (vpnvserver_vpnclientlessaccesspolicy_binding[]) vpnclientlessaccesspolicyBinding.getfiltered(service, option);
      return vpnclientlessaccesspolicyBindingArray != null && vpnclientlessaccesspolicyBindingArray.Length > 0 ? vpnclientlessaccesspolicyBindingArray[0].__count.Value : 0U;
    }

    private class vpnvserver_vpnclientlessaccesspolicy_binding_response : base_response
    {
      public vpnvserver_vpnclientlessaccesspolicy_binding[] vpnvserver_vpnclientlessaccesspolicy_binding = (vpnvserver_vpnclientlessaccesspolicy_binding[]) null;
    }

    public static class staaddresstypeEnum
    {
      public const string IPV4 = "IPV4";
      public const string IPV6 = "IPV6";
    }

    public static class bindpointEnum
    {
      public const string REQUEST = "REQUEST";
      public const string RESPONSE = "RESPONSE";
      public const string ICA_REQUEST = "ICA_REQUEST";
      public const string OTHERTCP_REQUEST = "OTHERTCP_REQUEST";
    }
  }
}
