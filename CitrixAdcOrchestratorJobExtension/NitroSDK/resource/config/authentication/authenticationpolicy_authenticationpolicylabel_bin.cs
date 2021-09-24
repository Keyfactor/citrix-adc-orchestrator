// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationpolicy_authenticationpolicylabel_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationpolicy_authenticationpolicylabel_binding : base_resource
  {
    private string boundtoField = (string) null;
    private uint? priorityField = new uint?();
    private uint? activepolicyField = new uint?();
    private string gotopriorityexpressionField = (string) null;
    private string nextfactorField = (string) null;
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

    public string nextfactor
    {
      get => this.nextfactorField;
      private set => this.nextfactorField = value;
    }

    public string gotopriorityexpression
    {
      get => this.gotopriorityexpressionField;
      private set => this.gotopriorityexpressionField = value;
    }

    public uint? activepolicy
    {
      get => this.activepolicyField;
      private set => this.activepolicyField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      authenticationpolicy_authenticationpolicylabel_binding.authenticationpolicy_authenticationpolicylabel_binding_response authenticationpolicylabelBindingResponse = new authenticationpolicy_authenticationpolicylabel_binding.authenticationpolicy_authenticationpolicylabel_binding_response();
      authenticationpolicy_authenticationpolicylabel_binding.authenticationpolicy_authenticationpolicylabel_binding_response resource = (authenticationpolicy_authenticationpolicylabel_binding.authenticationpolicy_authenticationpolicylabel_binding_response) service.get_payload_formatter().string_to_resource(authenticationpolicylabelBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationpolicy_authenticationpolicylabel_binding;
    }

    internal override string get_object_name() => this.name;

    public static authenticationpolicy_authenticationpolicylabel_binding[] get(
      nitro_service service,
      string name)
    {
      return (authenticationpolicy_authenticationpolicylabel_binding[]) new authenticationpolicy_authenticationpolicylabel_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static authenticationpolicy_authenticationpolicylabel_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      authenticationpolicy_authenticationpolicylabel_binding authenticationpolicylabelBinding = new authenticationpolicy_authenticationpolicylabel_binding();
      authenticationpolicylabelBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (authenticationpolicy_authenticationpolicylabel_binding[]) authenticationpolicylabelBinding.getfiltered(service, option);
    }

    public static authenticationpolicy_authenticationpolicylabel_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      authenticationpolicy_authenticationpolicylabel_binding authenticationpolicylabelBinding = new authenticationpolicy_authenticationpolicylabel_binding();
      authenticationpolicylabelBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (authenticationpolicy_authenticationpolicylabel_binding[]) authenticationpolicylabelBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      authenticationpolicy_authenticationpolicylabel_binding authenticationpolicylabelBinding = new authenticationpolicy_authenticationpolicylabel_binding();
      authenticationpolicylabelBinding.name = name;
      options option = new options();
      option.set_count(true);
      authenticationpolicy_authenticationpolicylabel_binding[] resources = (authenticationpolicy_authenticationpolicylabel_binding[]) authenticationpolicylabelBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      authenticationpolicy_authenticationpolicylabel_binding authenticationpolicylabelBinding = new authenticationpolicy_authenticationpolicylabel_binding();
      authenticationpolicylabelBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationpolicy_authenticationpolicylabel_binding[] authenticationpolicylabelBindingArray = (authenticationpolicy_authenticationpolicylabel_binding[]) authenticationpolicylabelBinding.getfiltered(service, option);
      return authenticationpolicylabelBindingArray != null && authenticationpolicylabelBindingArray.Length > 0 ? authenticationpolicylabelBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      authenticationpolicy_authenticationpolicylabel_binding authenticationpolicylabelBinding = new authenticationpolicy_authenticationpolicylabel_binding();
      authenticationpolicylabelBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationpolicy_authenticationpolicylabel_binding[] authenticationpolicylabelBindingArray = (authenticationpolicy_authenticationpolicylabel_binding[]) authenticationpolicylabelBinding.getfiltered(service, option);
      return authenticationpolicylabelBindingArray != null && authenticationpolicylabelBindingArray.Length > 0 ? authenticationpolicylabelBindingArray[0].__count.Value : 0U;
    }

    private class authenticationpolicy_authenticationpolicylabel_binding_response : base_response
    {
      public authenticationpolicy_authenticationpolicylabel_binding[] authenticationpolicy_authenticationpolicylabel_binding = (authenticationpolicy_authenticationpolicylabel_binding[]) null;
    }
  }
}
