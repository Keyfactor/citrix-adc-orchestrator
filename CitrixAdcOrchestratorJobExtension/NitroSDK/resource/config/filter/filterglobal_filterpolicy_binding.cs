// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.filter.filterglobal_filterpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.filter
{
  public class filterglobal_filterpolicy_binding : base_resource
  {
    private string policynameField = (string) null;
    private uint? priorityField = new uint?();
    private string stateField = (string) null;
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

    public string state
    {
      get => this.stateField;
      set => this.stateField = value;
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
      filterglobal_filterpolicy_binding.filterglobal_filterpolicy_binding_response filterpolicyBindingResponse = new filterglobal_filterpolicy_binding.filterglobal_filterpolicy_binding_response();
      filterglobal_filterpolicy_binding.filterglobal_filterpolicy_binding_response resource = (filterglobal_filterpolicy_binding.filterglobal_filterpolicy_binding_response) service.get_payload_formatter().string_to_resource(filterpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.filterglobal_filterpolicy_binding;
    }

    internal override string get_object_name() => (string) null;

    public static base_response add(
      nitro_service client,
      filterglobal_filterpolicy_binding resource)
    {
      return new filterglobal_filterpolicy_binding()
      {
        policyname = resource.policyname,
        priority = resource.priority,
        state = resource.state
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      filterglobal_filterpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        filterglobal_filterpolicy_binding[] filterpolicyBindingArray = new filterglobal_filterpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          filterpolicyBindingArray[index] = new filterglobal_filterpolicy_binding();
          filterpolicyBindingArray[index].policyname = resources[index].policyname;
          filterpolicyBindingArray[index].priority = resources[index].priority;
          filterpolicyBindingArray[index].state = resources[index].state;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) filterpolicyBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      filterglobal_filterpolicy_binding resource)
    {
      return new filterglobal_filterpolicy_binding()
      {
        policyname = resource.policyname
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      filterglobal_filterpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        filterglobal_filterpolicy_binding[] filterpolicyBindingArray = new filterglobal_filterpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          filterpolicyBindingArray[index] = new filterglobal_filterpolicy_binding();
          filterpolicyBindingArray[index].policyname = resources[index].policyname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) filterpolicyBindingArray);
      }
      return baseResponses;
    }

    public static filterglobal_filterpolicy_binding[] get(
      nitro_service service)
    {
      return (filterglobal_filterpolicy_binding[]) new filterglobal_filterpolicy_binding().get_resources(service, (options) null);
    }

    public static filterglobal_filterpolicy_binding[] get_filtered(
      nitro_service service,
      string filter)
    {
      filterglobal_filterpolicy_binding filterpolicyBinding = new filterglobal_filterpolicy_binding();
      options option = new options();
      option.set_filter(filter);
      return (filterglobal_filterpolicy_binding[]) filterpolicyBinding.getfiltered(service, option);
    }

    public static filterglobal_filterpolicy_binding[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      filterglobal_filterpolicy_binding filterpolicyBinding = new filterglobal_filterpolicy_binding();
      options option = new options();
      option.set_filter(filter);
      return (filterglobal_filterpolicy_binding[]) filterpolicyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      filterglobal_filterpolicy_binding filterpolicyBinding = new filterglobal_filterpolicy_binding();
      options option = new options();
      option.set_count(true);
      filterglobal_filterpolicy_binding[] resources = (filterglobal_filterpolicy_binding[]) filterpolicyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      filterglobal_filterpolicy_binding filterpolicyBinding = new filterglobal_filterpolicy_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      filterglobal_filterpolicy_binding[] filterpolicyBindingArray = (filterglobal_filterpolicy_binding[]) filterpolicyBinding.getfiltered(service, option);
      return filterpolicyBindingArray != null && filterpolicyBindingArray.Length > 0 ? filterpolicyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      filterglobal_filterpolicy_binding filterpolicyBinding = new filterglobal_filterpolicy_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      filterglobal_filterpolicy_binding[] filterpolicyBindingArray = (filterglobal_filterpolicy_binding[]) filterpolicyBinding.getfiltered(service, option);
      return filterpolicyBindingArray != null && filterpolicyBindingArray.Length > 0 ? filterpolicyBindingArray[0].__count.Value : 0U;
    }

    private class filterglobal_filterpolicy_binding_response : base_response
    {
      public filterglobal_filterpolicy_binding[] filterglobal_filterpolicy_binding = (filterglobal_filterpolicy_binding[]) null;
    }

    public static class stateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
