// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationldappolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationldappolicy_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationldappolicy_vpnvserver_binding[] authenticationldappolicy_vpnvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationldappolicy_vpnvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationldappolicy_authenticationvserver_binding[] authenticationldappolicy_authenticationvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationldappolicy_authenticationvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationldappolicy_systemglobal_binding[] authenticationldappolicy_systemglobal_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationldappolicy_systemglobal_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationldappolicy_vpnglobal_binding[] authenticationldappolicy_vpnglobal_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationldappolicy_vpnglobal_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationldappolicy_authenticationvserver_binding[] authenticationldappolicy_authenticationvserver_binding
    {
      get => this.authenticationldappolicy_authenticationvserver_bindingField;
      private set => this.authenticationldappolicy_authenticationvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationldappolicy_systemglobal_binding[] authenticationldappolicy_systemglobal_binding
    {
      get => this.authenticationldappolicy_systemglobal_bindingField;
      private set => this.authenticationldappolicy_systemglobal_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationldappolicy_vpnvserver_binding[] authenticationldappolicy_vpnvserver_binding
    {
      get => this.authenticationldappolicy_vpnvserver_bindingField;
      private set => this.authenticationldappolicy_vpnvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationldappolicy_vpnglobal_binding[] authenticationldappolicy_vpnglobal_binding
    {
      get => this.authenticationldappolicy_vpnglobal_bindingField;
      private set => this.authenticationldappolicy_vpnglobal_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      authenticationldappolicy_binding.authenticationldappolicy_binding_response authenticationldappolicyBindingResponse = new authenticationldappolicy_binding.authenticationldappolicy_binding_response();
      authenticationldappolicy_binding.authenticationldappolicy_binding_response resource = (authenticationldappolicy_binding.authenticationldappolicy_binding_response) service.get_payload_formatter().string_to_resource(authenticationldappolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationldappolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static authenticationldappolicy_binding get(
      nitro_service service,
      string name)
    {
      return (authenticationldappolicy_binding) new authenticationldappolicy_binding()
      {
        name = name
      }.get_resource(service);
    }

    public static authenticationldappolicy_binding[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (authenticationldappolicy_binding[]) null;
      authenticationldappolicy_binding[] authenticationldappolicyBindingArray1 = new authenticationldappolicy_binding[name.Length];
      authenticationldappolicy_binding[] authenticationldappolicyBindingArray2 = new authenticationldappolicy_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        authenticationldappolicyBindingArray2[index] = new authenticationldappolicy_binding();
        authenticationldappolicyBindingArray2[index].name = name[index];
        authenticationldappolicyBindingArray1[index] = (authenticationldappolicy_binding) authenticationldappolicyBindingArray2[index].get_resource(service);
      }
      return authenticationldappolicyBindingArray1;
    }

    private class authenticationldappolicy_binding_response : base_response
    {
      public authenticationldappolicy_binding[] authenticationldappolicy_binding = (authenticationldappolicy_binding[]) null;
    }
  }
}
