// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.aaa.aaaglobal_aaapreauthenticationpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.aaa
{
  public class aaaglobal_aaapreauthenticationpolicy_binding : base_resource
  {
    private string policyField = (string) null;
    private uint? priorityField = new uint?();
    private uint? bindpolicytypeField = new uint?();
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

    public string policy
    {
      get => this.policyField;
      set => this.policyField = value;
    }

    public string[] builtin
    {
      get => this.builtinField;
      set => this.builtinField = value;
    }

    public uint? bindpolicytype
    {
      get => this.bindpolicytypeField;
      private set => this.bindpolicytypeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      aaaglobal_aaapreauthenticationpolicy_binding.aaaglobal_aaapreauthenticationpolicy_binding_response aaapreauthenticationpolicyBindingResponse = new aaaglobal_aaapreauthenticationpolicy_binding.aaaglobal_aaapreauthenticationpolicy_binding_response();
      aaaglobal_aaapreauthenticationpolicy_binding.aaaglobal_aaapreauthenticationpolicy_binding_response resource = (aaaglobal_aaapreauthenticationpolicy_binding.aaaglobal_aaapreauthenticationpolicy_binding_response) service.get_payload_formatter().string_to_resource(aaapreauthenticationpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.aaaglobal_aaapreauthenticationpolicy_binding;
    }

    internal override string get_object_name() => (string) null;

    public static base_response add(
      nitro_service client,
      aaaglobal_aaapreauthenticationpolicy_binding resource)
    {
      return new aaaglobal_aaapreauthenticationpolicy_binding()
      {
        policy = resource.policy,
        priority = resource.priority
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      aaaglobal_aaapreauthenticationpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        aaaglobal_aaapreauthenticationpolicy_binding[] aaapreauthenticationpolicyBindingArray = new aaaglobal_aaapreauthenticationpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          aaapreauthenticationpolicyBindingArray[index] = new aaaglobal_aaapreauthenticationpolicy_binding();
          aaapreauthenticationpolicyBindingArray[index].policy = resources[index].policy;
          aaapreauthenticationpolicyBindingArray[index].priority = resources[index].priority;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) aaapreauthenticationpolicyBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      aaaglobal_aaapreauthenticationpolicy_binding resource)
    {
      return new aaaglobal_aaapreauthenticationpolicy_binding()
      {
        policy = resource.policy
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      aaaglobal_aaapreauthenticationpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        aaaglobal_aaapreauthenticationpolicy_binding[] aaapreauthenticationpolicyBindingArray = new aaaglobal_aaapreauthenticationpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          aaapreauthenticationpolicyBindingArray[index] = new aaaglobal_aaapreauthenticationpolicy_binding();
          aaapreauthenticationpolicyBindingArray[index].policy = resources[index].policy;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) aaapreauthenticationpolicyBindingArray);
      }
      return baseResponses;
    }

    public static aaaglobal_aaapreauthenticationpolicy_binding[] get(
      nitro_service service)
    {
      return (aaaglobal_aaapreauthenticationpolicy_binding[]) new aaaglobal_aaapreauthenticationpolicy_binding().get_resources(service, (options) null);
    }

    public static aaaglobal_aaapreauthenticationpolicy_binding[] get_filtered(
      nitro_service service,
      string filter)
    {
      aaaglobal_aaapreauthenticationpolicy_binding aaapreauthenticationpolicyBinding = new aaaglobal_aaapreauthenticationpolicy_binding();
      options option = new options();
      option.set_filter(filter);
      return (aaaglobal_aaapreauthenticationpolicy_binding[]) aaapreauthenticationpolicyBinding.getfiltered(service, option);
    }

    public static aaaglobal_aaapreauthenticationpolicy_binding[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      aaaglobal_aaapreauthenticationpolicy_binding aaapreauthenticationpolicyBinding = new aaaglobal_aaapreauthenticationpolicy_binding();
      options option = new options();
      option.set_filter(filter);
      return (aaaglobal_aaapreauthenticationpolicy_binding[]) aaapreauthenticationpolicyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      aaaglobal_aaapreauthenticationpolicy_binding aaapreauthenticationpolicyBinding = new aaaglobal_aaapreauthenticationpolicy_binding();
      options option = new options();
      option.set_count(true);
      aaaglobal_aaapreauthenticationpolicy_binding[] resources = (aaaglobal_aaapreauthenticationpolicy_binding[]) aaapreauthenticationpolicyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      aaaglobal_aaapreauthenticationpolicy_binding aaapreauthenticationpolicyBinding = new aaaglobal_aaapreauthenticationpolicy_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      aaaglobal_aaapreauthenticationpolicy_binding[] aaapreauthenticationpolicyBindingArray = (aaaglobal_aaapreauthenticationpolicy_binding[]) aaapreauthenticationpolicyBinding.getfiltered(service, option);
      return aaapreauthenticationpolicyBindingArray != null && aaapreauthenticationpolicyBindingArray.Length > 0 ? aaapreauthenticationpolicyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      aaaglobal_aaapreauthenticationpolicy_binding aaapreauthenticationpolicyBinding = new aaaglobal_aaapreauthenticationpolicy_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      aaaglobal_aaapreauthenticationpolicy_binding[] aaapreauthenticationpolicyBindingArray = (aaaglobal_aaapreauthenticationpolicy_binding[]) aaapreauthenticationpolicyBinding.getfiltered(service, option);
      return aaapreauthenticationpolicyBindingArray != null && aaapreauthenticationpolicyBindingArray.Length > 0 ? aaapreauthenticationpolicyBindingArray[0].__count.Value : 0U;
    }

    private class aaaglobal_aaapreauthenticationpolicy_binding_response : base_response
    {
      public aaaglobal_aaapreauthenticationpolicy_binding[] aaaglobal_aaapreauthenticationpolicy_binding = (aaaglobal_aaapreauthenticationpolicy_binding[]) null;
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
