// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationtacacspolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationtacacspolicy_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationtacacspolicy_vpnglobal_binding[] authenticationtacacspolicy_vpnglobal_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationtacacspolicy_vpnglobal_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationtacacspolicy_vpnvserver_binding[] authenticationtacacspolicy_vpnvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationtacacspolicy_vpnvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationtacacspolicy_systemglobal_binding[] authenticationtacacspolicy_systemglobal_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationtacacspolicy_systemglobal_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationtacacspolicy_authenticationvserver_binding[] authenticationtacacspolicy_authenticationvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationtacacspolicy_authenticationvserver_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationtacacspolicy_vpnvserver_binding[] authenticationtacacspolicy_vpnvserver_binding
    {
      get => this.authenticationtacacspolicy_vpnvserver_bindingField;
      private set => this.authenticationtacacspolicy_vpnvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationtacacspolicy_systemglobal_binding[] authenticationtacacspolicy_systemglobal_binding
    {
      get => this.authenticationtacacspolicy_systemglobal_bindingField;
      private set => this.authenticationtacacspolicy_systemglobal_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationtacacspolicy_authenticationvserver_binding[] authenticationtacacspolicy_authenticationvserver_binding
    {
      get => this.authenticationtacacspolicy_authenticationvserver_bindingField;
      private set => this.authenticationtacacspolicy_authenticationvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationtacacspolicy_vpnglobal_binding[] authenticationtacacspolicy_vpnglobal_binding
    {
      get => this.authenticationtacacspolicy_vpnglobal_bindingField;
      private set => this.authenticationtacacspolicy_vpnglobal_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      authenticationtacacspolicy_binding.authenticationtacacspolicy_binding_response authenticationtacacspolicyBindingResponse = new authenticationtacacspolicy_binding.authenticationtacacspolicy_binding_response();
      authenticationtacacspolicy_binding.authenticationtacacspolicy_binding_response resource = (authenticationtacacspolicy_binding.authenticationtacacspolicy_binding_response) service.get_payload_formatter().string_to_resource(authenticationtacacspolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationtacacspolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static authenticationtacacspolicy_binding get(
      nitro_service service,
      string name)
    {
      return (authenticationtacacspolicy_binding) new authenticationtacacspolicy_binding()
      {
        name = name
      }.get_resource(service);
    }

    public static authenticationtacacspolicy_binding[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (authenticationtacacspolicy_binding[]) null;
      authenticationtacacspolicy_binding[] authenticationtacacspolicyBindingArray1 = new authenticationtacacspolicy_binding[name.Length];
      authenticationtacacspolicy_binding[] authenticationtacacspolicyBindingArray2 = new authenticationtacacspolicy_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        authenticationtacacspolicyBindingArray2[index] = new authenticationtacacspolicy_binding();
        authenticationtacacspolicyBindingArray2[index].name = name[index];
        authenticationtacacspolicyBindingArray1[index] = (authenticationtacacspolicy_binding) authenticationtacacspolicyBindingArray2[index].get_resource(service);
      }
      return authenticationtacacspolicyBindingArray1;
    }

    private class authenticationtacacspolicy_binding_response : base_response
    {
      public authenticationtacacspolicy_binding[] authenticationtacacspolicy_binding = (authenticationtacacspolicy_binding[]) null;
    }
  }
}
