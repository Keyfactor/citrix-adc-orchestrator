// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nslimitidentifier_nslimitsessions_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nslimitidentifier_nslimitsessions_binding : base_resource
  {
    private string limitidentifierField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string limitidentifier
    {
      get => this.limitidentifierField;
      set => this.limitidentifierField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nslimitidentifier_nslimitsessions_binding.nslimitidentifier_nslimitsessions_binding_response nslimitsessionsBindingResponse = new nslimitidentifier_nslimitsessions_binding.nslimitidentifier_nslimitsessions_binding_response();
      nslimitidentifier_nslimitsessions_binding.nslimitidentifier_nslimitsessions_binding_response resource = (nslimitidentifier_nslimitsessions_binding.nslimitidentifier_nslimitsessions_binding_response) service.get_payload_formatter().string_to_resource(nslimitsessionsBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nslimitidentifier_nslimitsessions_binding;
    }

    internal override string get_object_name() => this.limitidentifier;

    public static nslimitidentifier_nslimitsessions_binding[] get(
      nitro_service service,
      string limitidentifier)
    {
      return (nslimitidentifier_nslimitsessions_binding[]) new nslimitidentifier_nslimitsessions_binding()
      {
        limitidentifier = limitidentifier
      }.get_resources(service, (options) null);
    }

    public static nslimitidentifier_nslimitsessions_binding[] get_filtered(
      nitro_service service,
      string limitidentifier,
      string filter)
    {
      nslimitidentifier_nslimitsessions_binding nslimitsessionsBinding = new nslimitidentifier_nslimitsessions_binding();
      nslimitsessionsBinding.limitidentifier = limitidentifier;
      options option = new options();
      option.set_filter(filter);
      return (nslimitidentifier_nslimitsessions_binding[]) nslimitsessionsBinding.getfiltered(service, option);
    }

    public static nslimitidentifier_nslimitsessions_binding[] get_filtered(
      nitro_service service,
      string limitidentifier,
      filtervalue[] filter)
    {
      nslimitidentifier_nslimitsessions_binding nslimitsessionsBinding = new nslimitidentifier_nslimitsessions_binding();
      nslimitsessionsBinding.limitidentifier = limitidentifier;
      options option = new options();
      option.set_filter(filter);
      return (nslimitidentifier_nslimitsessions_binding[]) nslimitsessionsBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string limitidentifier)
    {
      nslimitidentifier_nslimitsessions_binding nslimitsessionsBinding = new nslimitidentifier_nslimitsessions_binding();
      nslimitsessionsBinding.limitidentifier = limitidentifier;
      options option = new options();
      option.set_count(true);
      nslimitidentifier_nslimitsessions_binding[] resources = (nslimitidentifier_nslimitsessions_binding[]) nslimitsessionsBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string limitidentifier, string filter)
    {
      nslimitidentifier_nslimitsessions_binding nslimitsessionsBinding = new nslimitidentifier_nslimitsessions_binding();
      nslimitsessionsBinding.limitidentifier = limitidentifier;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nslimitidentifier_nslimitsessions_binding[] nslimitsessionsBindingArray = (nslimitidentifier_nslimitsessions_binding[]) nslimitsessionsBinding.getfiltered(service, option);
      return nslimitsessionsBindingArray != null && nslimitsessionsBindingArray.Length > 0 ? nslimitsessionsBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string limitidentifier,
      filtervalue[] filter)
    {
      nslimitidentifier_nslimitsessions_binding nslimitsessionsBinding = new nslimitidentifier_nslimitsessions_binding();
      nslimitsessionsBinding.limitidentifier = limitidentifier;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nslimitidentifier_nslimitsessions_binding[] nslimitsessionsBindingArray = (nslimitidentifier_nslimitsessions_binding[]) nslimitsessionsBinding.getfiltered(service, option);
      return nslimitsessionsBindingArray != null && nslimitsessionsBindingArray.Length > 0 ? nslimitsessionsBindingArray[0].__count.Value : 0U;
    }

    private class nslimitidentifier_nslimitsessions_binding_response : base_response
    {
      public nslimitidentifier_nslimitsessions_binding[] nslimitidentifier_nslimitsessions_binding = (nslimitidentifier_nslimitsessions_binding[]) null;
    }
  }
}
