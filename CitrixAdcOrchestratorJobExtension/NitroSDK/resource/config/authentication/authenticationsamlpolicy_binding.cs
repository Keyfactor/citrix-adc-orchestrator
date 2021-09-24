// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationsamlpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationsamlpolicy_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationsamlpolicy_vpnglobal_binding[] authenticationsamlpolicy_vpnglobal_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationsamlpolicy_vpnglobal_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationsamlpolicy_vpnvserver_binding[] authenticationsamlpolicy_vpnvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationsamlpolicy_vpnvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationsamlpolicy_authenticationvserver_binding[] authenticationsamlpolicy_authenticationvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationsamlpolicy_authenticationvserver_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationsamlpolicy_vpnvserver_binding[] authenticationsamlpolicy_vpnvserver_binding
    {
      get => this.authenticationsamlpolicy_vpnvserver_bindingField;
      private set => this.authenticationsamlpolicy_vpnvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationsamlpolicy_vpnglobal_binding[] authenticationsamlpolicy_vpnglobal_binding
    {
      get => this.authenticationsamlpolicy_vpnglobal_bindingField;
      private set => this.authenticationsamlpolicy_vpnglobal_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationsamlpolicy_authenticationvserver_binding[] authenticationsamlpolicy_authenticationvserver_binding
    {
      get => this.authenticationsamlpolicy_authenticationvserver_bindingField;
      private set => this.authenticationsamlpolicy_authenticationvserver_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      authenticationsamlpolicy_binding.authenticationsamlpolicy_binding_response authenticationsamlpolicyBindingResponse = new authenticationsamlpolicy_binding.authenticationsamlpolicy_binding_response();
      authenticationsamlpolicy_binding.authenticationsamlpolicy_binding_response resource = (authenticationsamlpolicy_binding.authenticationsamlpolicy_binding_response) service.get_payload_formatter().string_to_resource(authenticationsamlpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationsamlpolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static authenticationsamlpolicy_binding get(
      nitro_service service,
      string name)
    {
      return (authenticationsamlpolicy_binding) new authenticationsamlpolicy_binding()
      {
        name = name
      }.get_resource(service);
    }

    public static authenticationsamlpolicy_binding[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (authenticationsamlpolicy_binding[]) null;
      authenticationsamlpolicy_binding[] authenticationsamlpolicyBindingArray1 = new authenticationsamlpolicy_binding[name.Length];
      authenticationsamlpolicy_binding[] authenticationsamlpolicyBindingArray2 = new authenticationsamlpolicy_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        authenticationsamlpolicyBindingArray2[index] = new authenticationsamlpolicy_binding();
        authenticationsamlpolicyBindingArray2[index].name = name[index];
        authenticationsamlpolicyBindingArray1[index] = (authenticationsamlpolicy_binding) authenticationsamlpolicyBindingArray2[index].get_resource(service);
      }
      return authenticationsamlpolicyBindingArray1;
    }

    private class authenticationsamlpolicy_binding_response : base_response
    {
      public authenticationsamlpolicy_binding[] authenticationsamlpolicy_binding = (authenticationsamlpolicy_binding[]) null;
    }
  }
}
