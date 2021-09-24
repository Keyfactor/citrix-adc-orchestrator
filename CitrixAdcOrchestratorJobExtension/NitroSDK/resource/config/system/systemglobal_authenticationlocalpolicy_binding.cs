// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.system.systemglobal_authenticationlocalpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.system
{
  public class systemglobal_authenticationlocalpolicy_binding : base_resource
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
      systemglobal_authenticationlocalpolicy_binding.systemglobal_authenticationlocalpolicy_binding_response authenticationlocalpolicyBindingResponse = new systemglobal_authenticationlocalpolicy_binding.systemglobal_authenticationlocalpolicy_binding_response();
      systemglobal_authenticationlocalpolicy_binding.systemglobal_authenticationlocalpolicy_binding_response resource = (systemglobal_authenticationlocalpolicy_binding.systemglobal_authenticationlocalpolicy_binding_response) service.get_payload_formatter().string_to_resource(authenticationlocalpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.systemglobal_authenticationlocalpolicy_binding;
    }

    internal override string get_object_name() => (string) null;

    public static base_response add(
      nitro_service client,
      systemglobal_authenticationlocalpolicy_binding resource)
    {
      return new systemglobal_authenticationlocalpolicy_binding()
      {
        policyname = resource.policyname,
        priority = resource.priority
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      systemglobal_authenticationlocalpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        systemglobal_authenticationlocalpolicy_binding[] authenticationlocalpolicyBindingArray = new systemglobal_authenticationlocalpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationlocalpolicyBindingArray[index] = new systemglobal_authenticationlocalpolicy_binding();
          authenticationlocalpolicyBindingArray[index].policyname = resources[index].policyname;
          authenticationlocalpolicyBindingArray[index].priority = resources[index].priority;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) authenticationlocalpolicyBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      systemglobal_authenticationlocalpolicy_binding resource)
    {
      return new systemglobal_authenticationlocalpolicy_binding()
      {
        policyname = resource.policyname
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      systemglobal_authenticationlocalpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        systemglobal_authenticationlocalpolicy_binding[] authenticationlocalpolicyBindingArray = new systemglobal_authenticationlocalpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationlocalpolicyBindingArray[index] = new systemglobal_authenticationlocalpolicy_binding();
          authenticationlocalpolicyBindingArray[index].policyname = resources[index].policyname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationlocalpolicyBindingArray);
      }
      return baseResponses;
    }

    public static systemglobal_authenticationlocalpolicy_binding[] get(
      nitro_service service)
    {
      return (systemglobal_authenticationlocalpolicy_binding[]) new systemglobal_authenticationlocalpolicy_binding().get_resources(service, (options) null);
    }

    public static systemglobal_authenticationlocalpolicy_binding[] get_filtered(
      nitro_service service,
      string filter)
    {
      systemglobal_authenticationlocalpolicy_binding authenticationlocalpolicyBinding = new systemglobal_authenticationlocalpolicy_binding();
      options option = new options();
      option.set_filter(filter);
      return (systemglobal_authenticationlocalpolicy_binding[]) authenticationlocalpolicyBinding.getfiltered(service, option);
    }

    public static systemglobal_authenticationlocalpolicy_binding[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      systemglobal_authenticationlocalpolicy_binding authenticationlocalpolicyBinding = new systemglobal_authenticationlocalpolicy_binding();
      options option = new options();
      option.set_filter(filter);
      return (systemglobal_authenticationlocalpolicy_binding[]) authenticationlocalpolicyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      systemglobal_authenticationlocalpolicy_binding authenticationlocalpolicyBinding = new systemglobal_authenticationlocalpolicy_binding();
      options option = new options();
      option.set_count(true);
      systemglobal_authenticationlocalpolicy_binding[] resources = (systemglobal_authenticationlocalpolicy_binding[]) authenticationlocalpolicyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      systemglobal_authenticationlocalpolicy_binding authenticationlocalpolicyBinding = new systemglobal_authenticationlocalpolicy_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      systemglobal_authenticationlocalpolicy_binding[] authenticationlocalpolicyBindingArray = (systemglobal_authenticationlocalpolicy_binding[]) authenticationlocalpolicyBinding.getfiltered(service, option);
      return authenticationlocalpolicyBindingArray != null && authenticationlocalpolicyBindingArray.Length > 0 ? authenticationlocalpolicyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      systemglobal_authenticationlocalpolicy_binding authenticationlocalpolicyBinding = new systemglobal_authenticationlocalpolicy_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      systemglobal_authenticationlocalpolicy_binding[] authenticationlocalpolicyBindingArray = (systemglobal_authenticationlocalpolicy_binding[]) authenticationlocalpolicyBinding.getfiltered(service, option);
      return authenticationlocalpolicyBindingArray != null && authenticationlocalpolicyBindingArray.Length > 0 ? authenticationlocalpolicyBindingArray[0].__count.Value : 0U;
    }

    private class systemglobal_authenticationlocalpolicy_binding_response : base_response
    {
      public systemglobal_authenticationlocalpolicy_binding[] systemglobal_authenticationlocalpolicy_binding = (systemglobal_authenticationlocalpolicy_binding[]) null;
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
