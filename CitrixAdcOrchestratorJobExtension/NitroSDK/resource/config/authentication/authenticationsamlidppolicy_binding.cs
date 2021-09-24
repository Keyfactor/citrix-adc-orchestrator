// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationsamlidppolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationsamlidppolicy_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationsamlidppolicy_vpnvserver_binding[] authenticationsamlidppolicy_vpnvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationsamlidppolicy_vpnvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationsamlidppolicy_authenticationvserver_binding[] authenticationsamlidppolicy_authenticationvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationsamlidppolicy_authenticationvserver_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationsamlidppolicy_authenticationvserver_binding[] authenticationsamlidppolicy_authenticationvserver_binding
    {
      get => this.authenticationsamlidppolicy_authenticationvserver_bindingField;
      private set => this.authenticationsamlidppolicy_authenticationvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationsamlidppolicy_vpnvserver_binding[] authenticationsamlidppolicy_vpnvserver_binding
    {
      get => this.authenticationsamlidppolicy_vpnvserver_bindingField;
      private set => this.authenticationsamlidppolicy_vpnvserver_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      authenticationsamlidppolicy_binding.authenticationsamlidppolicy_binding_response authenticationsamlidppolicyBindingResponse = new authenticationsamlidppolicy_binding.authenticationsamlidppolicy_binding_response();
      authenticationsamlidppolicy_binding.authenticationsamlidppolicy_binding_response resource = (authenticationsamlidppolicy_binding.authenticationsamlidppolicy_binding_response) service.get_payload_formatter().string_to_resource(authenticationsamlidppolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationsamlidppolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static authenticationsamlidppolicy_binding get(
      nitro_service service,
      string name)
    {
      return (authenticationsamlidppolicy_binding) new authenticationsamlidppolicy_binding()
      {
        name = name
      }.get_resource(service);
    }

    public static authenticationsamlidppolicy_binding[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (authenticationsamlidppolicy_binding[]) null;
      authenticationsamlidppolicy_binding[] authenticationsamlidppolicyBindingArray1 = new authenticationsamlidppolicy_binding[name.Length];
      authenticationsamlidppolicy_binding[] authenticationsamlidppolicyBindingArray2 = new authenticationsamlidppolicy_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        authenticationsamlidppolicyBindingArray2[index] = new authenticationsamlidppolicy_binding();
        authenticationsamlidppolicyBindingArray2[index].name = name[index];
        authenticationsamlidppolicyBindingArray1[index] = (authenticationsamlidppolicy_binding) authenticationsamlidppolicyBindingArray2[index].get_resource(service);
      }
      return authenticationsamlidppolicyBindingArray1;
    }

    private class authenticationsamlidppolicy_binding_response : base_response
    {
      public authenticationsamlidppolicy_binding[] authenticationsamlidppolicy_binding = (authenticationsamlidppolicy_binding[]) null;
    }
  }
}
