// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authorization.authorizationpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.authorization
{
  public class authorizationpolicy_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.authorization.authorizationpolicy_csvserver_binding[] authorizationpolicy_csvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.authorization.authorizationpolicy_csvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.authorization.authorizationpolicy_lbvserver_binding[] authorizationpolicy_lbvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.authorization.authorizationpolicy_lbvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.authorization.authorizationpolicy_aaauser_binding[] authorizationpolicy_aaauser_bindingField = (com.citrix.netscaler.nitro.resource.config.authorization.authorizationpolicy_aaauser_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.authorization.authorizationpolicy_authorizationpolicylabel_binding[] authorizationpolicy_authorizationpolicylabel_bindingField = (com.citrix.netscaler.nitro.resource.config.authorization.authorizationpolicy_authorizationpolicylabel_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.authorization.authorizationpolicy_aaagroup_binding[] authorizationpolicy_aaagroup_bindingField = (com.citrix.netscaler.nitro.resource.config.authorization.authorizationpolicy_aaagroup_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authorization.authorizationpolicy_lbvserver_binding[] authorizationpolicy_lbvserver_binding
    {
      get => this.authorizationpolicy_lbvserver_bindingField;
      private set => this.authorizationpolicy_lbvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authorization.authorizationpolicy_aaagroup_binding[] authorizationpolicy_aaagroup_binding
    {
      get => this.authorizationpolicy_aaagroup_bindingField;
      private set => this.authorizationpolicy_aaagroup_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authorization.authorizationpolicy_csvserver_binding[] authorizationpolicy_csvserver_binding
    {
      get => this.authorizationpolicy_csvserver_bindingField;
      private set => this.authorizationpolicy_csvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authorization.authorizationpolicy_authorizationpolicylabel_binding[] authorizationpolicy_authorizationpolicylabel_binding
    {
      get => this.authorizationpolicy_authorizationpolicylabel_bindingField;
      private set => this.authorizationpolicy_authorizationpolicylabel_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authorization.authorizationpolicy_aaauser_binding[] authorizationpolicy_aaauser_binding
    {
      get => this.authorizationpolicy_aaauser_bindingField;
      private set => this.authorizationpolicy_aaauser_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      authorizationpolicy_binding.authorizationpolicy_binding_response authorizationpolicyBindingResponse = new authorizationpolicy_binding.authorizationpolicy_binding_response();
      authorizationpolicy_binding.authorizationpolicy_binding_response resource = (authorizationpolicy_binding.authorizationpolicy_binding_response) service.get_payload_formatter().string_to_resource(authorizationpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authorizationpolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static authorizationpolicy_binding get(
      nitro_service service,
      string name)
    {
      return (authorizationpolicy_binding) new authorizationpolicy_binding()
      {
        name = name
      }.get_resource(service);
    }

    public static authorizationpolicy_binding[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (authorizationpolicy_binding[]) null;
      authorizationpolicy_binding[] authorizationpolicyBindingArray1 = new authorizationpolicy_binding[name.Length];
      authorizationpolicy_binding[] authorizationpolicyBindingArray2 = new authorizationpolicy_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        authorizationpolicyBindingArray2[index] = new authorizationpolicy_binding();
        authorizationpolicyBindingArray2[index].name = name[index];
        authorizationpolicyBindingArray1[index] = (authorizationpolicy_binding) authorizationpolicyBindingArray2[index].get_resource(service);
      }
      return authorizationpolicyBindingArray1;
    }

    private class authorizationpolicy_binding_response : base_response
    {
      public authorizationpolicy_binding[] authorizationpolicy_binding = (authorizationpolicy_binding[]) null;
    }
  }
}
