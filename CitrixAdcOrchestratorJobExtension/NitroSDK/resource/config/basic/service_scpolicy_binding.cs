// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.basic.service_scpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.basic
{
  public class service_scpolicy_binding : base_resource
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
      service_scpolicy_binding.service_scpolicy_binding_response scpolicyBindingResponse = new service_scpolicy_binding.service_scpolicy_binding_response();
      service_scpolicy_binding.service_scpolicy_binding_response resource = (service_scpolicy_binding.service_scpolicy_binding_response) service.get_payload_formatter().string_to_resource(scpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.service_scpolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      service_scpolicy_binding resource)
    {
      return new service_scpolicy_binding()
      {
        name = resource.name,
        policyname = resource.policyname
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      service_scpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        service_scpolicy_binding[] serviceScpolicyBindingArray = new service_scpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          serviceScpolicyBindingArray[index] = new service_scpolicy_binding();
          serviceScpolicyBindingArray[index].name = resources[index].name;
          serviceScpolicyBindingArray[index].policyname = resources[index].policyname;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) serviceScpolicyBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      service_scpolicy_binding resource)
    {
      return new service_scpolicy_binding()
      {
        name = resource.name,
        policyname = resource.policyname
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      service_scpolicy_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        service_scpolicy_binding[] serviceScpolicyBindingArray = new service_scpolicy_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          serviceScpolicyBindingArray[index] = new service_scpolicy_binding();
          serviceScpolicyBindingArray[index].name = resources[index].name;
          serviceScpolicyBindingArray[index].policyname = resources[index].policyname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) serviceScpolicyBindingArray);
      }
      return baseResponses;
    }

    public static service_scpolicy_binding[] get(
      nitro_service service,
      string name)
    {
      return (service_scpolicy_binding[]) new service_scpolicy_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static service_scpolicy_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      service_scpolicy_binding serviceScpolicyBinding = new service_scpolicy_binding();
      serviceScpolicyBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (service_scpolicy_binding[]) serviceScpolicyBinding.getfiltered(service, option);
    }

    public static service_scpolicy_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      service_scpolicy_binding serviceScpolicyBinding = new service_scpolicy_binding();
      serviceScpolicyBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (service_scpolicy_binding[]) serviceScpolicyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      service_scpolicy_binding serviceScpolicyBinding = new service_scpolicy_binding();
      serviceScpolicyBinding.name = name;
      options option = new options();
      option.set_count(true);
      service_scpolicy_binding[] resources = (service_scpolicy_binding[]) serviceScpolicyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      service_scpolicy_binding serviceScpolicyBinding = new service_scpolicy_binding();
      serviceScpolicyBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      service_scpolicy_binding[] serviceScpolicyBindingArray = (service_scpolicy_binding[]) serviceScpolicyBinding.getfiltered(service, option);
      return serviceScpolicyBindingArray != null && serviceScpolicyBindingArray.Length > 0 ? serviceScpolicyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      service_scpolicy_binding serviceScpolicyBinding = new service_scpolicy_binding();
      serviceScpolicyBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      service_scpolicy_binding[] serviceScpolicyBindingArray = (service_scpolicy_binding[]) serviceScpolicyBinding.getfiltered(service, option);
      return serviceScpolicyBindingArray != null && serviceScpolicyBindingArray.Length > 0 ? serviceScpolicyBindingArray[0].__count.Value : 0U;
    }

    private class service_scpolicy_binding_response : base_response
    {
      public service_scpolicy_binding[] service_scpolicy_binding = (service_scpolicy_binding[]) null;
    }

    public static class monstateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
