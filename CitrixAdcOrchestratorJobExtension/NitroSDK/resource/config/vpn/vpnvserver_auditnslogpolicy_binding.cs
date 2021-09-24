// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_auditnslogpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.vpn
{
  public class vpnvserver_auditnslogpolicy_binding : base_resource
  {
    private string policyField = (string) null;
    private uint? priorityField = new uint?();
    private uint? acttypeField = new uint?();
    private string nameField = (string) null;
    private bool? secondaryField = new bool?();
    private bool? groupextractionField = new bool?();
    private string gotopriorityexpressionField = (string) null;
    private string bindpointField = (string) null;
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
      vpnvserver_auditnslogpolicy_binding.vpnvserver_auditnslogpolicy_binding_response auditnslogpolicyBindingResponse = new vpnvserver_auditnslogpolicy_binding.vpnvserver_auditnslogpolicy_binding_response();
      vpnvserver_auditnslogpolicy_binding.vpnvserver_auditnslogpolicy_binding_response resource = (vpnvserver_auditnslogpolicy_binding.vpnvserver_auditnslogpolicy_binding_response) service.get_payload_formatter().string_to_resource(auditnslogpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vpnvserver_auditnslogpolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      vpnvserver_auditnslogpolicy_binding resource)
    {
      return new vpnvserver_auditnslogpolicy_binding()
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
      vpnvserver_auditnslogpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnvserver_auditnslogpolicy_binding[] auditnslogpolicyBindingArray = new vpnvserver_auditnslogpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          auditnslogpolicyBindingArray[index] = new vpnvserver_auditnslogpolicy_binding();
          auditnslogpolicyBindingArray[index].name = resources[index].name;
          auditnslogpolicyBindingArray[index].policy = resources[index].policy;
          auditnslogpolicyBindingArray[index].priority = resources[index].priority;
          auditnslogpolicyBindingArray[index].secondary = resources[index].secondary;
          auditnslogpolicyBindingArray[index].groupextraction = resources[index].groupextraction;
          auditnslogpolicyBindingArray[index].gotopriorityexpression = resources[index].gotopriorityexpression;
          auditnslogpolicyBindingArray[index].bindpoint = resources[index].bindpoint;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) auditnslogpolicyBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      vpnvserver_auditnslogpolicy_binding resource)
    {
      return new vpnvserver_auditnslogpolicy_binding()
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
      vpnvserver_auditnslogpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnvserver_auditnslogpolicy_binding[] auditnslogpolicyBindingArray = new vpnvserver_auditnslogpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          auditnslogpolicyBindingArray[index] = new vpnvserver_auditnslogpolicy_binding();
          auditnslogpolicyBindingArray[index].name = resources[index].name;
          auditnslogpolicyBindingArray[index].policy = resources[index].policy;
          auditnslogpolicyBindingArray[index].secondary = resources[index].secondary;
          auditnslogpolicyBindingArray[index].groupextraction = resources[index].groupextraction;
          auditnslogpolicyBindingArray[index].bindpoint = resources[index].bindpoint;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) auditnslogpolicyBindingArray);
      }
      return baseResponses;
    }

    public static vpnvserver_auditnslogpolicy_binding[] get(
      nitro_service service,
      string name)
    {
      return (vpnvserver_auditnslogpolicy_binding[]) new vpnvserver_auditnslogpolicy_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static vpnvserver_auditnslogpolicy_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      vpnvserver_auditnslogpolicy_binding auditnslogpolicyBinding = new vpnvserver_auditnslogpolicy_binding();
      auditnslogpolicyBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (vpnvserver_auditnslogpolicy_binding[]) auditnslogpolicyBinding.getfiltered(service, option);
    }

    public static vpnvserver_auditnslogpolicy_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      vpnvserver_auditnslogpolicy_binding auditnslogpolicyBinding = new vpnvserver_auditnslogpolicy_binding();
      auditnslogpolicyBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (vpnvserver_auditnslogpolicy_binding[]) auditnslogpolicyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      vpnvserver_auditnslogpolicy_binding auditnslogpolicyBinding = new vpnvserver_auditnslogpolicy_binding();
      auditnslogpolicyBinding.name = name;
      options option = new options();
      option.set_count(true);
      vpnvserver_auditnslogpolicy_binding[] resources = (vpnvserver_auditnslogpolicy_binding[]) auditnslogpolicyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      vpnvserver_auditnslogpolicy_binding auditnslogpolicyBinding = new vpnvserver_auditnslogpolicy_binding();
      auditnslogpolicyBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnvserver_auditnslogpolicy_binding[] auditnslogpolicyBindingArray = (vpnvserver_auditnslogpolicy_binding[]) auditnslogpolicyBinding.getfiltered(service, option);
      return auditnslogpolicyBindingArray != null && auditnslogpolicyBindingArray.Length > 0 ? auditnslogpolicyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      vpnvserver_auditnslogpolicy_binding auditnslogpolicyBinding = new vpnvserver_auditnslogpolicy_binding();
      auditnslogpolicyBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnvserver_auditnslogpolicy_binding[] auditnslogpolicyBindingArray = (vpnvserver_auditnslogpolicy_binding[]) auditnslogpolicyBinding.getfiltered(service, option);
      return auditnslogpolicyBindingArray != null && auditnslogpolicyBindingArray.Length > 0 ? auditnslogpolicyBindingArray[0].__count.Value : 0U;
    }

    private class vpnvserver_auditnslogpolicy_binding_response : base_response
    {
      public vpnvserver_auditnslogpolicy_binding[] vpnvserver_auditnslogpolicy_binding = (vpnvserver_auditnslogpolicy_binding[]) null;
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
