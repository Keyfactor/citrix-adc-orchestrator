// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.vpn.vpnglobal_authenticationnegotiatepolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.vpn
{
  public class vpnglobal_authenticationnegotiatepolicy_binding : base_resource
  {
    private string policynameField = (string) null;
    private uint? priorityField = new uint?();
    private bool? secondaryField = new bool?();
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

    public string policyname
    {
      get => this.policynameField;
      set => this.policynameField = value;
    }

    public bool? secondary
    {
      get => this.secondaryField;
      set => this.secondaryField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vpnglobal_authenticationnegotiatepolicy_binding.vpnglobal_authenticationnegotiatepolicy_binding_response authenticationnegotiatepolicyBindingResponse = new vpnglobal_authenticationnegotiatepolicy_binding.vpnglobal_authenticationnegotiatepolicy_binding_response();
      vpnglobal_authenticationnegotiatepolicy_binding.vpnglobal_authenticationnegotiatepolicy_binding_response resource = (vpnglobal_authenticationnegotiatepolicy_binding.vpnglobal_authenticationnegotiatepolicy_binding_response) service.get_payload_formatter().string_to_resource(authenticationnegotiatepolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vpnglobal_authenticationnegotiatepolicy_binding;
    }

    internal override string get_object_name() => (string) null;

    public static vpnglobal_authenticationnegotiatepolicy_binding[] get(
      nitro_service service)
    {
      return (vpnglobal_authenticationnegotiatepolicy_binding[]) new vpnglobal_authenticationnegotiatepolicy_binding().get_resources(service, (options) null);
    }

    public static vpnglobal_authenticationnegotiatepolicy_binding[] get_filtered(
      nitro_service service,
      string filter)
    {
      vpnglobal_authenticationnegotiatepolicy_binding authenticationnegotiatepolicyBinding = new vpnglobal_authenticationnegotiatepolicy_binding();
      options option = new options();
      option.set_filter(filter);
      return (vpnglobal_authenticationnegotiatepolicy_binding[]) authenticationnegotiatepolicyBinding.getfiltered(service, option);
    }

    public static vpnglobal_authenticationnegotiatepolicy_binding[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      vpnglobal_authenticationnegotiatepolicy_binding authenticationnegotiatepolicyBinding = new vpnglobal_authenticationnegotiatepolicy_binding();
      options option = new options();
      option.set_filter(filter);
      return (vpnglobal_authenticationnegotiatepolicy_binding[]) authenticationnegotiatepolicyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      vpnglobal_authenticationnegotiatepolicy_binding authenticationnegotiatepolicyBinding = new vpnglobal_authenticationnegotiatepolicy_binding();
      options option = new options();
      option.set_count(true);
      vpnglobal_authenticationnegotiatepolicy_binding[] resources = (vpnglobal_authenticationnegotiatepolicy_binding[]) authenticationnegotiatepolicyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      vpnglobal_authenticationnegotiatepolicy_binding authenticationnegotiatepolicyBinding = new vpnglobal_authenticationnegotiatepolicy_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnglobal_authenticationnegotiatepolicy_binding[] authenticationnegotiatepolicyBindingArray = (vpnglobal_authenticationnegotiatepolicy_binding[]) authenticationnegotiatepolicyBinding.getfiltered(service, option);
      return authenticationnegotiatepolicyBindingArray != null && authenticationnegotiatepolicyBindingArray.Length > 0 ? authenticationnegotiatepolicyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      vpnglobal_authenticationnegotiatepolicy_binding authenticationnegotiatepolicyBinding = new vpnglobal_authenticationnegotiatepolicy_binding();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnglobal_authenticationnegotiatepolicy_binding[] authenticationnegotiatepolicyBindingArray = (vpnglobal_authenticationnegotiatepolicy_binding[]) authenticationnegotiatepolicyBinding.getfiltered(service, option);
      return authenticationnegotiatepolicyBindingArray != null && authenticationnegotiatepolicyBindingArray.Length > 0 ? authenticationnegotiatepolicyBindingArray[0].__count.Value : 0U;
    }

    private class vpnglobal_authenticationnegotiatepolicy_binding_response : base_response
    {
      public vpnglobal_authenticationnegotiatepolicy_binding[] vpnglobal_authenticationnegotiatepolicy_binding = (vpnglobal_authenticationnegotiatepolicy_binding[]) null;
    }
  }
}
