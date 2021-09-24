// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver_auditnslogpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationvserver_auditnslogpolicy_binding : base_resource
  {
    private string policyField = (string) null;
    private uint? priorityField = new uint?();
    private string nameField = (string) null;
    private bool? secondaryField = new bool?();
    private bool? groupextractionField = new bool?();
    private string nextfactorField = (string) null;
    private string gotopriorityexpressionField = (string) null;
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

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string nextfactor
    {
      get => this.nextfactorField;
      set => this.nextfactorField = value;
    }

    public string gotopriorityexpression
    {
      get => this.gotopriorityexpressionField;
      set => this.gotopriorityexpressionField = value;
    }

    public bool? secondary
    {
      get => this.secondaryField;
      set => this.secondaryField = value;
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

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      authenticationvserver_auditnslogpolicy_binding.authenticationvserver_auditnslogpolicy_binding_response auditnslogpolicyBindingResponse = new authenticationvserver_auditnslogpolicy_binding.authenticationvserver_auditnslogpolicy_binding_response();
      authenticationvserver_auditnslogpolicy_binding.authenticationvserver_auditnslogpolicy_binding_response resource = (authenticationvserver_auditnslogpolicy_binding.authenticationvserver_auditnslogpolicy_binding_response) service.get_payload_formatter().string_to_resource(auditnslogpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationvserver_auditnslogpolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      authenticationvserver_auditnslogpolicy_binding resource)
    {
      return new authenticationvserver_auditnslogpolicy_binding()
      {
        name = resource.name,
        policy = resource.policy,
        priority = resource.priority,
        secondary = resource.secondary,
        groupextraction = resource.groupextraction,
        nextfactor = resource.nextfactor,
        gotopriorityexpression = resource.gotopriorityexpression
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      authenticationvserver_auditnslogpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationvserver_auditnslogpolicy_binding[] auditnslogpolicyBindingArray = new authenticationvserver_auditnslogpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          auditnslogpolicyBindingArray[index] = new authenticationvserver_auditnslogpolicy_binding();
          auditnslogpolicyBindingArray[index].name = resources[index].name;
          auditnslogpolicyBindingArray[index].policy = resources[index].policy;
          auditnslogpolicyBindingArray[index].priority = resources[index].priority;
          auditnslogpolicyBindingArray[index].secondary = resources[index].secondary;
          auditnslogpolicyBindingArray[index].groupextraction = resources[index].groupextraction;
          auditnslogpolicyBindingArray[index].nextfactor = resources[index].nextfactor;
          auditnslogpolicyBindingArray[index].gotopriorityexpression = resources[index].gotopriorityexpression;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) auditnslogpolicyBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      authenticationvserver_auditnslogpolicy_binding resource)
    {
      return new authenticationvserver_auditnslogpolicy_binding()
      {
        name = resource.name,
        policy = resource.policy,
        secondary = resource.secondary,
        groupextraction = resource.groupextraction
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      authenticationvserver_auditnslogpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationvserver_auditnslogpolicy_binding[] auditnslogpolicyBindingArray = new authenticationvserver_auditnslogpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          auditnslogpolicyBindingArray[index] = new authenticationvserver_auditnslogpolicy_binding();
          auditnslogpolicyBindingArray[index].name = resources[index].name;
          auditnslogpolicyBindingArray[index].policy = resources[index].policy;
          auditnslogpolicyBindingArray[index].secondary = resources[index].secondary;
          auditnslogpolicyBindingArray[index].groupextraction = resources[index].groupextraction;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) auditnslogpolicyBindingArray);
      }
      return baseResponses;
    }

    public static authenticationvserver_auditnslogpolicy_binding[] get(
      nitro_service service,
      string name)
    {
      return (authenticationvserver_auditnslogpolicy_binding[]) new authenticationvserver_auditnslogpolicy_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static authenticationvserver_auditnslogpolicy_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      authenticationvserver_auditnslogpolicy_binding auditnslogpolicyBinding = new authenticationvserver_auditnslogpolicy_binding();
      auditnslogpolicyBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (authenticationvserver_auditnslogpolicy_binding[]) auditnslogpolicyBinding.getfiltered(service, option);
    }

    public static authenticationvserver_auditnslogpolicy_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      authenticationvserver_auditnslogpolicy_binding auditnslogpolicyBinding = new authenticationvserver_auditnslogpolicy_binding();
      auditnslogpolicyBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (authenticationvserver_auditnslogpolicy_binding[]) auditnslogpolicyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      authenticationvserver_auditnslogpolicy_binding auditnslogpolicyBinding = new authenticationvserver_auditnslogpolicy_binding();
      auditnslogpolicyBinding.name = name;
      options option = new options();
      option.set_count(true);
      authenticationvserver_auditnslogpolicy_binding[] resources = (authenticationvserver_auditnslogpolicy_binding[]) auditnslogpolicyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      authenticationvserver_auditnslogpolicy_binding auditnslogpolicyBinding = new authenticationvserver_auditnslogpolicy_binding();
      auditnslogpolicyBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationvserver_auditnslogpolicy_binding[] auditnslogpolicyBindingArray = (authenticationvserver_auditnslogpolicy_binding[]) auditnslogpolicyBinding.getfiltered(service, option);
      return auditnslogpolicyBindingArray != null && auditnslogpolicyBindingArray.Length > 0 ? auditnslogpolicyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      authenticationvserver_auditnslogpolicy_binding auditnslogpolicyBinding = new authenticationvserver_auditnslogpolicy_binding();
      auditnslogpolicyBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationvserver_auditnslogpolicy_binding[] auditnslogpolicyBindingArray = (authenticationvserver_auditnslogpolicy_binding[]) auditnslogpolicyBinding.getfiltered(service, option);
      return auditnslogpolicyBindingArray != null && auditnslogpolicyBindingArray.Length > 0 ? auditnslogpolicyBindingArray[0].__count.Value : 0U;
    }

    private class authenticationvserver_auditnslogpolicy_binding_response : base_response
    {
      public authenticationvserver_auditnslogpolicy_binding[] authenticationvserver_auditnslogpolicy_binding = (authenticationvserver_auditnslogpolicy_binding[]) null;
    }
  }
}
