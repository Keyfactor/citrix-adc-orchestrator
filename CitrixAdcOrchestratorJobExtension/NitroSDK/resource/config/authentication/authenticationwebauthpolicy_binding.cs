// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationwebauthpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationwebauthpolicy_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationwebauthpolicy_vpnglobal_binding[] authenticationwebauthpolicy_vpnglobal_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationwebauthpolicy_vpnglobal_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationwebauthpolicy_vpnvserver_binding[] authenticationwebauthpolicy_vpnvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationwebauthpolicy_vpnvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationwebauthpolicy_systemglobal_binding[] authenticationwebauthpolicy_systemglobal_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationwebauthpolicy_systemglobal_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationwebauthpolicy_authenticationvserver_binding[] authenticationwebauthpolicy_authenticationvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationwebauthpolicy_authenticationvserver_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationwebauthpolicy_vpnglobal_binding[] authenticationwebauthpolicy_vpnglobal_binding
    {
      get => this.authenticationwebauthpolicy_vpnglobal_bindingField;
      private set => this.authenticationwebauthpolicy_vpnglobal_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationwebauthpolicy_authenticationvserver_binding[] authenticationwebauthpolicy_authenticationvserver_binding
    {
      get => this.authenticationwebauthpolicy_authenticationvserver_bindingField;
      private set => this.authenticationwebauthpolicy_authenticationvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationwebauthpolicy_systemglobal_binding[] authenticationwebauthpolicy_systemglobal_binding
    {
      get => this.authenticationwebauthpolicy_systemglobal_bindingField;
      private set => this.authenticationwebauthpolicy_systemglobal_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationwebauthpolicy_vpnvserver_binding[] authenticationwebauthpolicy_vpnvserver_binding
    {
      get => this.authenticationwebauthpolicy_vpnvserver_bindingField;
      private set => this.authenticationwebauthpolicy_vpnvserver_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      authenticationwebauthpolicy_binding.authenticationwebauthpolicy_binding_response authenticationwebauthpolicyBindingResponse = new authenticationwebauthpolicy_binding.authenticationwebauthpolicy_binding_response();
      authenticationwebauthpolicy_binding.authenticationwebauthpolicy_binding_response resource = (authenticationwebauthpolicy_binding.authenticationwebauthpolicy_binding_response) service.get_payload_formatter().string_to_resource(authenticationwebauthpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationwebauthpolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static authenticationwebauthpolicy_binding get(
      nitro_service service,
      string name)
    {
      return (authenticationwebauthpolicy_binding) new authenticationwebauthpolicy_binding()
      {
        name = name
      }.get_resource(service);
    }

    public static authenticationwebauthpolicy_binding[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (authenticationwebauthpolicy_binding[]) null;
      authenticationwebauthpolicy_binding[] authenticationwebauthpolicyBindingArray1 = new authenticationwebauthpolicy_binding[name.Length];
      authenticationwebauthpolicy_binding[] authenticationwebauthpolicyBindingArray2 = new authenticationwebauthpolicy_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        authenticationwebauthpolicyBindingArray2[index] = new authenticationwebauthpolicy_binding();
        authenticationwebauthpolicyBindingArray2[index].name = name[index];
        authenticationwebauthpolicyBindingArray1[index] = (authenticationwebauthpolicy_binding) authenticationwebauthpolicyBindingArray2[index].get_resource(service);
      }
      return authenticationwebauthpolicyBindingArray1;
    }

    private class authenticationwebauthpolicy_binding_response : base_response
    {
      public authenticationwebauthpolicy_binding[] authenticationwebauthpolicy_binding = (authenticationwebauthpolicy_binding[]) null;
    }
  }
}
