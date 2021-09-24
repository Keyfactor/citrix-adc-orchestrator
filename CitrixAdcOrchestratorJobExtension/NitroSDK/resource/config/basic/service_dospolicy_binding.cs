// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.basic.service_dospolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.basic
{
  public class service_dospolicy_binding : base_resource
  {
    private string policynameField = (string) null;
    private string nameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string policyname
    {
      get => this.policynameField;
      set => this.policynameField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      service_dospolicy_binding.service_dospolicy_binding_response dospolicyBindingResponse = new service_dospolicy_binding.service_dospolicy_binding_response();
      service_dospolicy_binding.service_dospolicy_binding_response resource = (service_dospolicy_binding.service_dospolicy_binding_response) service.get_payload_formatter().string_to_resource(dospolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.service_dospolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      service_dospolicy_binding resource)
    {
      return new service_dospolicy_binding()
      {
        name = resource.name,
        policyname = resource.policyname
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      service_dospolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        service_dospolicy_binding[] dospolicyBindingArray = new service_dospolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dospolicyBindingArray[index] = new service_dospolicy_binding();
          dospolicyBindingArray[index].name = resources[index].name;
          dospolicyBindingArray[index].policyname = resources[index].policyname;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) dospolicyBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      service_dospolicy_binding resource)
    {
      return new service_dospolicy_binding()
      {
        name = resource.name,
        policyname = resource.policyname
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      service_dospolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        service_dospolicy_binding[] dospolicyBindingArray = new service_dospolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dospolicyBindingArray[index] = new service_dospolicy_binding();
          dospolicyBindingArray[index].name = resources[index].name;
          dospolicyBindingArray[index].policyname = resources[index].policyname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dospolicyBindingArray);
      }
      return baseResponses;
    }

    public static service_dospolicy_binding[] get(
      nitro_service service,
      string name)
    {
      return (service_dospolicy_binding[]) new service_dospolicy_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static service_dospolicy_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      service_dospolicy_binding dospolicyBinding = new service_dospolicy_binding();
      dospolicyBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (service_dospolicy_binding[]) dospolicyBinding.getfiltered(service, option);
    }

    public static service_dospolicy_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      service_dospolicy_binding dospolicyBinding = new service_dospolicy_binding();
      dospolicyBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (service_dospolicy_binding[]) dospolicyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      service_dospolicy_binding dospolicyBinding = new service_dospolicy_binding();
      dospolicyBinding.name = name;
      options option = new options();
      option.set_count(true);
      service_dospolicy_binding[] resources = (service_dospolicy_binding[]) dospolicyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      service_dospolicy_binding dospolicyBinding = new service_dospolicy_binding();
      dospolicyBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      service_dospolicy_binding[] dospolicyBindingArray = (service_dospolicy_binding[]) dospolicyBinding.getfiltered(service, option);
      return dospolicyBindingArray != null && dospolicyBindingArray.Length > 0 ? dospolicyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      service_dospolicy_binding dospolicyBinding = new service_dospolicy_binding();
      dospolicyBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      service_dospolicy_binding[] dospolicyBindingArray = (service_dospolicy_binding[]) dospolicyBinding.getfiltered(service, option);
      return dospolicyBindingArray != null && dospolicyBindingArray.Length > 0 ? dospolicyBindingArray[0].__count.Value : 0U;
    }

    private class service_dospolicy_binding_response : base_response
    {
      public service_dospolicy_binding[] service_dospolicy_binding = (service_dospolicy_binding[]) null;
    }

    public static class monstateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
