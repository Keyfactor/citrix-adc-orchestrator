// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationloginschemapolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationloginschemapolicy_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationloginschemapolicy_vpnvserver_binding[] authenticationloginschemapolicy_vpnvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationloginschemapolicy_vpnvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationloginschemapolicy_authenticationvserver_binding[] authenticationloginschemapolicy_authenticationvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationloginschemapolicy_authenticationvserver_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationloginschemapolicy_authenticationvserver_binding[] authenticationloginschemapolicy_authenticationvserver_binding
    {
      get => this.authenticationloginschemapolicy_authenticationvserver_bindingField;
      private set => this.authenticationloginschemapolicy_authenticationvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationloginschemapolicy_vpnvserver_binding[] authenticationloginschemapolicy_vpnvserver_binding
    {
      get => this.authenticationloginschemapolicy_vpnvserver_bindingField;
      private set => this.authenticationloginschemapolicy_vpnvserver_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      authenticationloginschemapolicy_binding.authenticationloginschemapolicy_binding_response authenticationloginschemapolicyBindingResponse = new authenticationloginschemapolicy_binding.authenticationloginschemapolicy_binding_response();
      authenticationloginschemapolicy_binding.authenticationloginschemapolicy_binding_response resource = (authenticationloginschemapolicy_binding.authenticationloginschemapolicy_binding_response) service.get_payload_formatter().string_to_resource(authenticationloginschemapolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationloginschemapolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static authenticationloginschemapolicy_binding get(
      nitro_service service,
      string name)
    {
      return (authenticationloginschemapolicy_binding) new authenticationloginschemapolicy_binding()
      {
        name = name
      }.get_resource(service);
    }

    public static authenticationloginschemapolicy_binding[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (authenticationloginschemapolicy_binding[]) null;
      authenticationloginschemapolicy_binding[] authenticationloginschemapolicyBindingArray1 = new authenticationloginschemapolicy_binding[name.Length];
      authenticationloginschemapolicy_binding[] authenticationloginschemapolicyBindingArray2 = new authenticationloginschemapolicy_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        authenticationloginschemapolicyBindingArray2[index] = new authenticationloginschemapolicy_binding();
        authenticationloginschemapolicyBindingArray2[index].name = name[index];
        authenticationloginschemapolicyBindingArray1[index] = (authenticationloginschemapolicy_binding) authenticationloginschemapolicyBindingArray2[index].get_resource(service);
      }
      return authenticationloginschemapolicyBindingArray1;
    }

    private class authenticationloginschemapolicy_binding_response : base_response
    {
      public authenticationloginschemapolicy_binding[] authenticationloginschemapolicy_binding = (authenticationloginschemapolicy_binding[]) null;
    }
  }
}
