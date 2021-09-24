// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationpolicy_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationpolicy_authenticationpolicylabel_binding[] authenticationpolicy_authenticationpolicylabel_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationpolicy_authenticationpolicylabel_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationpolicy_authenticationvserver_binding[] authenticationpolicy_authenticationvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationpolicy_authenticationvserver_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationpolicy_authenticationvserver_binding[] authenticationpolicy_authenticationvserver_binding
    {
      get => this.authenticationpolicy_authenticationvserver_bindingField;
      private set => this.authenticationpolicy_authenticationvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationpolicy_authenticationpolicylabel_binding[] authenticationpolicy_authenticationpolicylabel_binding
    {
      get => this.authenticationpolicy_authenticationpolicylabel_bindingField;
      private set => this.authenticationpolicy_authenticationpolicylabel_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      authenticationpolicy_binding.authenticationpolicy_binding_response authenticationpolicyBindingResponse = new authenticationpolicy_binding.authenticationpolicy_binding_response();
      authenticationpolicy_binding.authenticationpolicy_binding_response resource = (authenticationpolicy_binding.authenticationpolicy_binding_response) service.get_payload_formatter().string_to_resource(authenticationpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationpolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static authenticationpolicy_binding get(
      nitro_service service,
      string name)
    {
      return (authenticationpolicy_binding) new authenticationpolicy_binding()
      {
        name = name
      }.get_resource(service);
    }

    public static authenticationpolicy_binding[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (authenticationpolicy_binding[]) null;
      authenticationpolicy_binding[] authenticationpolicyBindingArray1 = new authenticationpolicy_binding[name.Length];
      authenticationpolicy_binding[] authenticationpolicyBindingArray2 = new authenticationpolicy_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        authenticationpolicyBindingArray2[index] = new authenticationpolicy_binding();
        authenticationpolicyBindingArray2[index].name = name[index];
        authenticationpolicyBindingArray1[index] = (authenticationpolicy_binding) authenticationpolicyBindingArray2[index].get_resource(service);
      }
      return authenticationpolicyBindingArray1;
    }

    private class authenticationpolicy_binding_response : base_response
    {
      public authenticationpolicy_binding[] authenticationpolicy_binding = (authenticationpolicy_binding[]) null;
    }
  }
}
