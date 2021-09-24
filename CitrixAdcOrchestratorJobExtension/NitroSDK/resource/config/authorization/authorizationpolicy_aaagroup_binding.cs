// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authorization.authorizationpolicy_aaagroup_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.authorization
{
  public class authorizationpolicy_aaagroup_binding : base_resource
  {
    private string boundtoField = (string) null;
    private uint? priorityField = new uint?();
    private string nameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string boundto
    {
      get => this.boundtoField;
      set => this.boundtoField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public uint? priority
    {
      get => this.priorityField;
      private set => this.priorityField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      authorizationpolicy_aaagroup_binding.authorizationpolicy_aaagroup_binding_response aaagroupBindingResponse = new authorizationpolicy_aaagroup_binding.authorizationpolicy_aaagroup_binding_response();
      authorizationpolicy_aaagroup_binding.authorizationpolicy_aaagroup_binding_response resource = (authorizationpolicy_aaagroup_binding.authorizationpolicy_aaagroup_binding_response) service.get_payload_formatter().string_to_resource(aaagroupBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authorizationpolicy_aaagroup_binding;
    }

    internal override string get_object_name() => this.name;

    public static authorizationpolicy_aaagroup_binding[] get(
      nitro_service service,
      string name)
    {
      return (authorizationpolicy_aaagroup_binding[]) new authorizationpolicy_aaagroup_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static authorizationpolicy_aaagroup_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      authorizationpolicy_aaagroup_binding authorizationpolicyAaagroupBinding = new authorizationpolicy_aaagroup_binding();
      authorizationpolicyAaagroupBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (authorizationpolicy_aaagroup_binding[]) authorizationpolicyAaagroupBinding.getfiltered(service, option);
    }

    public static authorizationpolicy_aaagroup_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      authorizationpolicy_aaagroup_binding authorizationpolicyAaagroupBinding = new authorizationpolicy_aaagroup_binding();
      authorizationpolicyAaagroupBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (authorizationpolicy_aaagroup_binding[]) authorizationpolicyAaagroupBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      authorizationpolicy_aaagroup_binding authorizationpolicyAaagroupBinding = new authorizationpolicy_aaagroup_binding();
      authorizationpolicyAaagroupBinding.name = name;
      options option = new options();
      option.set_count(true);
      authorizationpolicy_aaagroup_binding[] resources = (authorizationpolicy_aaagroup_binding[]) authorizationpolicyAaagroupBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      authorizationpolicy_aaagroup_binding authorizationpolicyAaagroupBinding = new authorizationpolicy_aaagroup_binding();
      authorizationpolicyAaagroupBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authorizationpolicy_aaagroup_binding[] authorizationpolicyAaagroupBindingArray = (authorizationpolicy_aaagroup_binding[]) authorizationpolicyAaagroupBinding.getfiltered(service, option);
      return authorizationpolicyAaagroupBindingArray != null && authorizationpolicyAaagroupBindingArray.Length > 0 ? authorizationpolicyAaagroupBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      authorizationpolicy_aaagroup_binding authorizationpolicyAaagroupBinding = new authorizationpolicy_aaagroup_binding();
      authorizationpolicyAaagroupBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authorizationpolicy_aaagroup_binding[] authorizationpolicyAaagroupBindingArray = (authorizationpolicy_aaagroup_binding[]) authorizationpolicyAaagroupBinding.getfiltered(service, option);
      return authorizationpolicyAaagroupBindingArray != null && authorizationpolicyAaagroupBindingArray.Length > 0 ? authorizationpolicyAaagroupBindingArray[0].__count.Value : 0U;
    }

    private class authorizationpolicy_aaagroup_binding_response : base_response
    {
      public authorizationpolicy_aaagroup_binding[] authorizationpolicy_aaagroup_binding = (authorizationpolicy_aaagroup_binding[]) null;
    }
  }
}
