// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.system.systemglobal_auditnslogpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.system
{
  public class systemglobal_auditnslogpolicy_binding : base_resource
  {
    private string policynameField = (string) null;
    private uint? priorityField = new uint?();
    private string[] builtinField = (string[]) null;
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

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      systemglobal_auditnslogpolicy_binding.systemglobal_auditnslogpolicy_binding_response auditnslogpolicyBindingResponse = new systemglobal_auditnslogpolicy_binding.systemglobal_auditnslogpolicy_binding_response();
      systemglobal_auditnslogpolicy_binding.systemglobal_auditnslogpolicy_binding_response resource = (systemglobal_auditnslogpolicy_binding.systemglobal_auditnslogpolicy_binding_response) service.get_payload_formatter().string_to_resource(auditnslogpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.systemglobal_auditnslogpolicy_binding;
    }

    internal override string get_object_name() => (string) null;

    public static base_response add(
      nitro_service client,
      systemglobal_auditnslogpolicy_binding resource)
    {
      return new systemglobal_auditnslogpolicy_binding()
      {
        policyname = resource.policyname,
        priority = resource.priority
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      systemglobal_auditnslogpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        systemglobal_auditnslogpolicy_binding[] auditnslogpolicyBindingArray = new systemglobal_auditnslogpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          auditnslogpolicyBindingArray[index] = new systemglobal_auditnslogpolicy_binding();
          auditnslogpolicyBindingArray[index].policyname = resources[index].policyname;
          auditnslogpolicyBindingArray[index].priority = resources[index].priority;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) auditnslogpolicyBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      systemglobal_auditnslogpolicy_binding resource)
    {
      return new systemglobal_auditnslogpolicy_binding()
      {
        policyname = resource.policyname
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      systemglobal_auditnslogpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        systemglobal_auditnslogpolicy_binding[] auditnslogpolicyBindingArray = new systemglobal_auditnslogpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          auditnslogpolicyBindingArray[index] = new systemglobal_auditnslogpolicy_binding();
          auditnslogpolicyBindingArray[index].policyname = resources[index].policyname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) auditnslogpolicyBindingArray);
      }
      return baseResponses;
    }

    public static systemglobal_auditnslogpolicy_binding[] get(
      nitro_service service)
    {
      return (systemglobal_auditnslogpolicy_binding[]) new systemglobal_auditnslogpolicy_binding().get_resources(service, (options) null);
    }

    public static systemglobal_auditnslogpolicy_binding[] get_filtered(
      nitro_service service,
      string filter)
    {
      systemglobal_auditnslogpolicy_binding auditnslogpolicyBinding = new systemglobal_auditnslogpolicy_binding();
      options option = new options();
      option.set_filter(filter);
      return (systemglobal_auditnslogpolicy_binding[]) auditnslogpolicyBinding.getfiltered(service, option);
    }

    public static systemglobal_auditnslogpolicy_binding[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      systemglobal_auditnslogpolicy_binding auditnslogpolicyBinding = new systemglobal_auditnslogpolicy_binding();
      options option = new options();
      option.set_filter(filter);
      return (systemglobal_auditnslogpolicy_binding[]) auditnslogpolicyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      systemglobal_auditnslogpolicy_binding auditnslogpolicyBinding = new systemglobal_auditnslogpolicy_binding();
      options option = new options();
      option.set_count(true);
      systemglobal_auditnslogpolicy_binding[] resources = (systemglobal_auditnslogpolicy_binding[]) auditnslogpolicyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      systemglobal_auditnslogpolicy_binding auditnslogpolicyBinding = new systemglobal_auditnslogpolicy_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      systemglobal_auditnslogpolicy_binding[] auditnslogpolicyBindingArray = (systemglobal_auditnslogpolicy_binding[]) auditnslogpolicyBinding.getfiltered(service, option);
      return auditnslogpolicyBindingArray != null && auditnslogpolicyBindingArray.Length > 0 ? auditnslogpolicyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      systemglobal_auditnslogpolicy_binding auditnslogpolicyBinding = new systemglobal_auditnslogpolicy_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      systemglobal_auditnslogpolicy_binding[] auditnslogpolicyBindingArray = (systemglobal_auditnslogpolicy_binding[]) auditnslogpolicyBinding.getfiltered(service, option);
      return auditnslogpolicyBindingArray != null && auditnslogpolicyBindingArray.Length > 0 ? auditnslogpolicyBindingArray[0].__count.Value : 0U;
    }

    private class systemglobal_auditnslogpolicy_binding_response : base_response
    {
      public systemglobal_auditnslogpolicy_binding[] systemglobal_auditnslogpolicy_binding = (systemglobal_auditnslogpolicy_binding[]) null;
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }
  }
}
