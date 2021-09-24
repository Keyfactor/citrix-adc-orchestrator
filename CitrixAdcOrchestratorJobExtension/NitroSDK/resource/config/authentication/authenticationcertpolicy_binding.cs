// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationcertpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationcertpolicy_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationcertpolicy_vpnglobal_binding[] authenticationcertpolicy_vpnglobal_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationcertpolicy_vpnglobal_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationcertpolicy_vpnvserver_binding[] authenticationcertpolicy_vpnvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationcertpolicy_vpnvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationcertpolicy_authenticationvserver_binding[] authenticationcertpolicy_authenticationvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationcertpolicy_authenticationvserver_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationcertpolicy_authenticationvserver_binding[] authenticationcertpolicy_authenticationvserver_binding
    {
      get => this.authenticationcertpolicy_authenticationvserver_bindingField;
      private set => this.authenticationcertpolicy_authenticationvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationcertpolicy_vpnvserver_binding[] authenticationcertpolicy_vpnvserver_binding
    {
      get => this.authenticationcertpolicy_vpnvserver_bindingField;
      private set => this.authenticationcertpolicy_vpnvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationcertpolicy_vpnglobal_binding[] authenticationcertpolicy_vpnglobal_binding
    {
      get => this.authenticationcertpolicy_vpnglobal_bindingField;
      private set => this.authenticationcertpolicy_vpnglobal_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      authenticationcertpolicy_binding.authenticationcertpolicy_binding_response authenticationcertpolicyBindingResponse = new authenticationcertpolicy_binding.authenticationcertpolicy_binding_response();
      authenticationcertpolicy_binding.authenticationcertpolicy_binding_response resource = (authenticationcertpolicy_binding.authenticationcertpolicy_binding_response) service.get_payload_formatter().string_to_resource(authenticationcertpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationcertpolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static authenticationcertpolicy_binding get(
      nitro_service service,
      string name)
    {
      return (authenticationcertpolicy_binding) new authenticationcertpolicy_binding()
      {
        name = name
      }.get_resource(service);
    }

    public static authenticationcertpolicy_binding[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (authenticationcertpolicy_binding[]) null;
      authenticationcertpolicy_binding[] authenticationcertpolicyBindingArray1 = new authenticationcertpolicy_binding[name.Length];
      authenticationcertpolicy_binding[] authenticationcertpolicyBindingArray2 = new authenticationcertpolicy_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        authenticationcertpolicyBindingArray2[index] = new authenticationcertpolicy_binding();
        authenticationcertpolicyBindingArray2[index].name = name[index];
        authenticationcertpolicyBindingArray1[index] = (authenticationcertpolicy_binding) authenticationcertpolicyBindingArray2[index].get_resource(service);
      }
      return authenticationcertpolicyBindingArray1;
    }

    private class authenticationcertpolicy_binding_response : base_response
    {
      public authenticationcertpolicy_binding[] authenticationcertpolicy_binding = (authenticationcertpolicy_binding[]) null;
    }
  }
}
