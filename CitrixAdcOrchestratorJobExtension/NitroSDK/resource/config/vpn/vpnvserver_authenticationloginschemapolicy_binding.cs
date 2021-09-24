// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.vpn.vpnvserver_authenticationloginschemapolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.vpn
{
  public class vpnvserver_authenticationloginschemapolicy_binding : base_resource
  {
    private string policyField = (string) null;
    private uint? priorityField = new uint?();
    private string gotopriorityexpressionField = (string) null;
    private string nameField = (string) null;
    private bool? secondaryField = new bool?();
    private bool? groupextractionField = new bool?();
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

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vpnvserver_authenticationloginschemapolicy_binding.vpnvserver_authenticationloginschemapolicy_binding_response authenticationloginschemapolicyBindingResponse = new vpnvserver_authenticationloginschemapolicy_binding.vpnvserver_authenticationloginschemapolicy_binding_response();
      vpnvserver_authenticationloginschemapolicy_binding.vpnvserver_authenticationloginschemapolicy_binding_response resource = (vpnvserver_authenticationloginschemapolicy_binding.vpnvserver_authenticationloginschemapolicy_binding_response) service.get_payload_formatter().string_to_resource(authenticationloginschemapolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vpnvserver_authenticationloginschemapolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      vpnvserver_authenticationloginschemapolicy_binding resource)
    {
      return new vpnvserver_authenticationloginschemapolicy_binding()
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
      vpnvserver_authenticationloginschemapolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnvserver_authenticationloginschemapolicy_binding[] authenticationloginschemapolicyBindingArray = new vpnvserver_authenticationloginschemapolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationloginschemapolicyBindingArray[index] = new vpnvserver_authenticationloginschemapolicy_binding();
          authenticationloginschemapolicyBindingArray[index].name = resources[index].name;
          authenticationloginschemapolicyBindingArray[index].policy = resources[index].policy;
          authenticationloginschemapolicyBindingArray[index].priority = resources[index].priority;
          authenticationloginschemapolicyBindingArray[index].secondary = resources[index].secondary;
          authenticationloginschemapolicyBindingArray[index].groupextraction = resources[index].groupextraction;
          authenticationloginschemapolicyBindingArray[index].gotopriorityexpression = resources[index].gotopriorityexpression;
          authenticationloginschemapolicyBindingArray[index].bindpoint = resources[index].bindpoint;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) authenticationloginschemapolicyBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      vpnvserver_authenticationloginschemapolicy_binding resource)
    {
      return new vpnvserver_authenticationloginschemapolicy_binding()
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
      vpnvserver_authenticationloginschemapolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnvserver_authenticationloginschemapolicy_binding[] authenticationloginschemapolicyBindingArray = new vpnvserver_authenticationloginschemapolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationloginschemapolicyBindingArray[index] = new vpnvserver_authenticationloginschemapolicy_binding();
          authenticationloginschemapolicyBindingArray[index].name = resources[index].name;
          authenticationloginschemapolicyBindingArray[index].policy = resources[index].policy;
          authenticationloginschemapolicyBindingArray[index].secondary = resources[index].secondary;
          authenticationloginschemapolicyBindingArray[index].groupextraction = resources[index].groupextraction;
          authenticationloginschemapolicyBindingArray[index].bindpoint = resources[index].bindpoint;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationloginschemapolicyBindingArray);
      }
      return baseResponses;
    }

    public static vpnvserver_authenticationloginschemapolicy_binding[] get(
      nitro_service service,
      string name)
    {
      return (vpnvserver_authenticationloginschemapolicy_binding[]) new vpnvserver_authenticationloginschemapolicy_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static vpnvserver_authenticationloginschemapolicy_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      vpnvserver_authenticationloginschemapolicy_binding authenticationloginschemapolicyBinding = new vpnvserver_authenticationloginschemapolicy_binding();
      authenticationloginschemapolicyBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (vpnvserver_authenticationloginschemapolicy_binding[]) authenticationloginschemapolicyBinding.getfiltered(service, option);
    }

    public static vpnvserver_authenticationloginschemapolicy_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      vpnvserver_authenticationloginschemapolicy_binding authenticationloginschemapolicyBinding = new vpnvserver_authenticationloginschemapolicy_binding();
      authenticationloginschemapolicyBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (vpnvserver_authenticationloginschemapolicy_binding[]) authenticationloginschemapolicyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      vpnvserver_authenticationloginschemapolicy_binding authenticationloginschemapolicyBinding = new vpnvserver_authenticationloginschemapolicy_binding();
      authenticationloginschemapolicyBinding.name = name;
      options option = new options();
      option.set_count(true);
      vpnvserver_authenticationloginschemapolicy_binding[] resources = (vpnvserver_authenticationloginschemapolicy_binding[]) authenticationloginschemapolicyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      vpnvserver_authenticationloginschemapolicy_binding authenticationloginschemapolicyBinding = new vpnvserver_authenticationloginschemapolicy_binding();
      authenticationloginschemapolicyBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnvserver_authenticationloginschemapolicy_binding[] authenticationloginschemapolicyBindingArray = (vpnvserver_authenticationloginschemapolicy_binding[]) authenticationloginschemapolicyBinding.getfiltered(service, option);
      return authenticationloginschemapolicyBindingArray != null && authenticationloginschemapolicyBindingArray.Length > 0 ? authenticationloginschemapolicyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      vpnvserver_authenticationloginschemapolicy_binding authenticationloginschemapolicyBinding = new vpnvserver_authenticationloginschemapolicy_binding();
      authenticationloginschemapolicyBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnvserver_authenticationloginschemapolicy_binding[] authenticationloginschemapolicyBindingArray = (vpnvserver_authenticationloginschemapolicy_binding[]) authenticationloginschemapolicyBinding.getfiltered(service, option);
      return authenticationloginschemapolicyBindingArray != null && authenticationloginschemapolicyBindingArray.Length > 0 ? authenticationloginschemapolicyBindingArray[0].__count.Value : 0U;
    }

    private class vpnvserver_authenticationloginschemapolicy_binding_response : base_response
    {
      public vpnvserver_authenticationloginschemapolicy_binding[] vpnvserver_authenticationloginschemapolicy_binding = (vpnvserver_authenticationloginschemapolicy_binding[]) null;
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
