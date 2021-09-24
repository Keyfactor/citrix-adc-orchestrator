// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationradiuspolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationradiuspolicy_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationradiuspolicy_vpnglobal_binding[] authenticationradiuspolicy_vpnglobal_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationradiuspolicy_vpnglobal_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationradiuspolicy_vpnvserver_binding[] authenticationradiuspolicy_vpnvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationradiuspolicy_vpnvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationradiuspolicy_systemglobal_binding[] authenticationradiuspolicy_systemglobal_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationradiuspolicy_systemglobal_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationradiuspolicy_authenticationvserver_binding[] authenticationradiuspolicy_authenticationvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationradiuspolicy_authenticationvserver_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationradiuspolicy_authenticationvserver_binding[] authenticationradiuspolicy_authenticationvserver_binding
    {
      get => this.authenticationradiuspolicy_authenticationvserver_bindingField;
      private set => this.authenticationradiuspolicy_authenticationvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationradiuspolicy_vpnglobal_binding[] authenticationradiuspolicy_vpnglobal_binding
    {
      get => this.authenticationradiuspolicy_vpnglobal_bindingField;
      private set => this.authenticationradiuspolicy_vpnglobal_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationradiuspolicy_systemglobal_binding[] authenticationradiuspolicy_systemglobal_binding
    {
      get => this.authenticationradiuspolicy_systemglobal_bindingField;
      private set => this.authenticationradiuspolicy_systemglobal_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationradiuspolicy_vpnvserver_binding[] authenticationradiuspolicy_vpnvserver_binding
    {
      get => this.authenticationradiuspolicy_vpnvserver_bindingField;
      private set => this.authenticationradiuspolicy_vpnvserver_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      authenticationradiuspolicy_binding.authenticationradiuspolicy_binding_response authenticationradiuspolicyBindingResponse = new authenticationradiuspolicy_binding.authenticationradiuspolicy_binding_response();
      authenticationradiuspolicy_binding.authenticationradiuspolicy_binding_response resource = (authenticationradiuspolicy_binding.authenticationradiuspolicy_binding_response) service.get_payload_formatter().string_to_resource(authenticationradiuspolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationradiuspolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static authenticationradiuspolicy_binding get(
      nitro_service service,
      string name)
    {
      return (authenticationradiuspolicy_binding) new authenticationradiuspolicy_binding()
      {
        name = name
      }.get_resource(service);
    }

    public static authenticationradiuspolicy_binding[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (authenticationradiuspolicy_binding[]) null;
      authenticationradiuspolicy_binding[] authenticationradiuspolicyBindingArray1 = new authenticationradiuspolicy_binding[name.Length];
      authenticationradiuspolicy_binding[] authenticationradiuspolicyBindingArray2 = new authenticationradiuspolicy_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        authenticationradiuspolicyBindingArray2[index] = new authenticationradiuspolicy_binding();
        authenticationradiuspolicyBindingArray2[index].name = name[index];
        authenticationradiuspolicyBindingArray1[index] = (authenticationradiuspolicy_binding) authenticationradiuspolicyBindingArray2[index].get_resource(service);
      }
      return authenticationradiuspolicyBindingArray1;
    }

    private class authenticationradiuspolicy_binding_response : base_response
    {
      public authenticationradiuspolicy_binding[] authenticationradiuspolicy_binding = (authenticationradiuspolicy_binding[]) null;
    }
  }
}
