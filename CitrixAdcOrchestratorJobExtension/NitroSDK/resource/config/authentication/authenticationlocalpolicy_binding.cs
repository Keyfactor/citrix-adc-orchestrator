// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationlocalpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationlocalpolicy_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationlocalpolicy_vpnglobal_binding[] authenticationlocalpolicy_vpnglobal_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationlocalpolicy_vpnglobal_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationlocalpolicy_vpnvserver_binding[] authenticationlocalpolicy_vpnvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationlocalpolicy_vpnvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationlocalpolicy_systemglobal_binding[] authenticationlocalpolicy_systemglobal_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationlocalpolicy_systemglobal_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationlocalpolicy_authenticationvserver_binding[] authenticationlocalpolicy_authenticationvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationlocalpolicy_authenticationvserver_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationlocalpolicy_vpnvserver_binding[] authenticationlocalpolicy_vpnvserver_binding
    {
      get => this.authenticationlocalpolicy_vpnvserver_bindingField;
      private set => this.authenticationlocalpolicy_vpnvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationlocalpolicy_systemglobal_binding[] authenticationlocalpolicy_systemglobal_binding
    {
      get => this.authenticationlocalpolicy_systemglobal_bindingField;
      private set => this.authenticationlocalpolicy_systemglobal_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationlocalpolicy_vpnglobal_binding[] authenticationlocalpolicy_vpnglobal_binding
    {
      get => this.authenticationlocalpolicy_vpnglobal_bindingField;
      private set => this.authenticationlocalpolicy_vpnglobal_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationlocalpolicy_authenticationvserver_binding[] authenticationlocalpolicy_authenticationvserver_binding
    {
      get => this.authenticationlocalpolicy_authenticationvserver_bindingField;
      private set => this.authenticationlocalpolicy_authenticationvserver_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      authenticationlocalpolicy_binding.authenticationlocalpolicy_binding_response authenticationlocalpolicyBindingResponse = new authenticationlocalpolicy_binding.authenticationlocalpolicy_binding_response();
      authenticationlocalpolicy_binding.authenticationlocalpolicy_binding_response resource = (authenticationlocalpolicy_binding.authenticationlocalpolicy_binding_response) service.get_payload_formatter().string_to_resource(authenticationlocalpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationlocalpolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static authenticationlocalpolicy_binding get(
      nitro_service service,
      string name)
    {
      return (authenticationlocalpolicy_binding) new authenticationlocalpolicy_binding()
      {
        name = name
      }.get_resource(service);
    }

    public static authenticationlocalpolicy_binding[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (authenticationlocalpolicy_binding[]) null;
      authenticationlocalpolicy_binding[] authenticationlocalpolicyBindingArray1 = new authenticationlocalpolicy_binding[name.Length];
      authenticationlocalpolicy_binding[] authenticationlocalpolicyBindingArray2 = new authenticationlocalpolicy_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        authenticationlocalpolicyBindingArray2[index] = new authenticationlocalpolicy_binding();
        authenticationlocalpolicyBindingArray2[index].name = name[index];
        authenticationlocalpolicyBindingArray1[index] = (authenticationlocalpolicy_binding) authenticationlocalpolicyBindingArray2[index].get_resource(service);
      }
      return authenticationlocalpolicyBindingArray1;
    }

    private class authenticationlocalpolicy_binding_response : base_response
    {
      public authenticationlocalpolicy_binding[] authenticationlocalpolicy_binding = (authenticationlocalpolicy_binding[]) null;
    }
  }
}
