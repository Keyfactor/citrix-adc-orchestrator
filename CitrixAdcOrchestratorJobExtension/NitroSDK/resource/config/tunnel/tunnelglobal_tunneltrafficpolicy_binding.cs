// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.tunnel.tunnelglobal_tunneltrafficpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.tunnel
{
  public class tunnelglobal_tunneltrafficpolicy_binding : base_resource
  {
    private string policynameField = (string) null;
    private uint? priorityField = new uint?();
    private string stateField = (string) null;
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

    public string state
    {
      get => this.stateField;
      set => this.stateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      tunnelglobal_tunneltrafficpolicy_binding.tunnelglobal_tunneltrafficpolicy_binding_response tunneltrafficpolicyBindingResponse = new tunnelglobal_tunneltrafficpolicy_binding.tunnelglobal_tunneltrafficpolicy_binding_response();
      tunnelglobal_tunneltrafficpolicy_binding.tunnelglobal_tunneltrafficpolicy_binding_response resource = (tunnelglobal_tunneltrafficpolicy_binding.tunnelglobal_tunneltrafficpolicy_binding_response) service.get_payload_formatter().string_to_resource(tunneltrafficpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.tunnelglobal_tunneltrafficpolicy_binding;
    }

    internal override string get_object_name() => (string) null;

    public static base_response add(
      nitro_service client,
      tunnelglobal_tunneltrafficpolicy_binding resource)
    {
      return new tunnelglobal_tunneltrafficpolicy_binding()
      {
        policyname = resource.policyname,
        priority = resource.priority,
        state = resource.state
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      tunnelglobal_tunneltrafficpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        tunnelglobal_tunneltrafficpolicy_binding[] tunneltrafficpolicyBindingArray = new tunnelglobal_tunneltrafficpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          tunneltrafficpolicyBindingArray[index] = new tunnelglobal_tunneltrafficpolicy_binding();
          tunneltrafficpolicyBindingArray[index].policyname = resources[index].policyname;
          tunneltrafficpolicyBindingArray[index].priority = resources[index].priority;
          tunneltrafficpolicyBindingArray[index].state = resources[index].state;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) tunneltrafficpolicyBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      tunnelglobal_tunneltrafficpolicy_binding resource)
    {
      return new tunnelglobal_tunneltrafficpolicy_binding()
      {
        policyname = resource.policyname
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      tunnelglobal_tunneltrafficpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        tunnelglobal_tunneltrafficpolicy_binding[] tunneltrafficpolicyBindingArray = new tunnelglobal_tunneltrafficpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          tunneltrafficpolicyBindingArray[index] = new tunnelglobal_tunneltrafficpolicy_binding();
          tunneltrafficpolicyBindingArray[index].policyname = resources[index].policyname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) tunneltrafficpolicyBindingArray);
      }
      return baseResponses;
    }

    public static tunnelglobal_tunneltrafficpolicy_binding[] get(
      nitro_service service)
    {
      return (tunnelglobal_tunneltrafficpolicy_binding[]) new tunnelglobal_tunneltrafficpolicy_binding().get_resources(service, (options) null);
    }

    public static tunnelglobal_tunneltrafficpolicy_binding[] get_filtered(
      nitro_service service,
      string filter)
    {
      tunnelglobal_tunneltrafficpolicy_binding tunneltrafficpolicyBinding = new tunnelglobal_tunneltrafficpolicy_binding();
      options option = new options();
      option.set_filter(filter);
      return (tunnelglobal_tunneltrafficpolicy_binding[]) tunneltrafficpolicyBinding.getfiltered(service, option);
    }

    public static tunnelglobal_tunneltrafficpolicy_binding[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      tunnelglobal_tunneltrafficpolicy_binding tunneltrafficpolicyBinding = new tunnelglobal_tunneltrafficpolicy_binding();
      options option = new options();
      option.set_filter(filter);
      return (tunnelglobal_tunneltrafficpolicy_binding[]) tunneltrafficpolicyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      tunnelglobal_tunneltrafficpolicy_binding tunneltrafficpolicyBinding = new tunnelglobal_tunneltrafficpolicy_binding();
      options option = new options();
      option.set_count(true);
      tunnelglobal_tunneltrafficpolicy_binding[] resources = (tunnelglobal_tunneltrafficpolicy_binding[]) tunneltrafficpolicyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      tunnelglobal_tunneltrafficpolicy_binding tunneltrafficpolicyBinding = new tunnelglobal_tunneltrafficpolicy_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      tunnelglobal_tunneltrafficpolicy_binding[] tunneltrafficpolicyBindingArray = (tunnelglobal_tunneltrafficpolicy_binding[]) tunneltrafficpolicyBinding.getfiltered(service, option);
      return tunneltrafficpolicyBindingArray != null && tunneltrafficpolicyBindingArray.Length > 0 ? tunneltrafficpolicyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      tunnelglobal_tunneltrafficpolicy_binding tunneltrafficpolicyBinding = new tunnelglobal_tunneltrafficpolicy_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      tunnelglobal_tunneltrafficpolicy_binding[] tunneltrafficpolicyBindingArray = (tunnelglobal_tunneltrafficpolicy_binding[]) tunneltrafficpolicyBinding.getfiltered(service, option);
      return tunneltrafficpolicyBindingArray != null && tunneltrafficpolicyBindingArray.Length > 0 ? tunneltrafficpolicyBindingArray[0].__count.Value : 0U;
    }

    private class tunnelglobal_tunneltrafficpolicy_binding_response : base_response
    {
      public tunnelglobal_tunneltrafficpolicy_binding[] tunnelglobal_tunneltrafficpolicy_binding = (tunnelglobal_tunneltrafficpolicy_binding[]) null;
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }

    public static class stateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
