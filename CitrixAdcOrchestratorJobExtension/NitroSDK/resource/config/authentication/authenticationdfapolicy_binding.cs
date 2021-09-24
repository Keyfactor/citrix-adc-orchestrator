// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationdfapolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationdfapolicy_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationdfapolicy_vpnvserver_binding[] authenticationdfapolicy_vpnvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationdfapolicy_vpnvserver_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationdfapolicy_vpnvserver_binding[] authenticationdfapolicy_vpnvserver_binding
    {
      get => this.authenticationdfapolicy_vpnvserver_bindingField;
      private set => this.authenticationdfapolicy_vpnvserver_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      authenticationdfapolicy_binding.authenticationdfapolicy_binding_response authenticationdfapolicyBindingResponse = new authenticationdfapolicy_binding.authenticationdfapolicy_binding_response();
      authenticationdfapolicy_binding.authenticationdfapolicy_binding_response resource = (authenticationdfapolicy_binding.authenticationdfapolicy_binding_response) service.get_payload_formatter().string_to_resource(authenticationdfapolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationdfapolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static authenticationdfapolicy_binding get(
      nitro_service service,
      string name)
    {
      return (authenticationdfapolicy_binding) new authenticationdfapolicy_binding()
      {
        name = name
      }.get_resource(service);
    }

    public static authenticationdfapolicy_binding[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (authenticationdfapolicy_binding[]) null;
      authenticationdfapolicy_binding[] authenticationdfapolicyBindingArray1 = new authenticationdfapolicy_binding[name.Length];
      authenticationdfapolicy_binding[] authenticationdfapolicyBindingArray2 = new authenticationdfapolicy_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        authenticationdfapolicyBindingArray2[index] = new authenticationdfapolicy_binding();
        authenticationdfapolicyBindingArray2[index].name = name[index];
        authenticationdfapolicyBindingArray1[index] = (authenticationdfapolicy_binding) authenticationdfapolicyBindingArray2[index].get_resource(service);
      }
      return authenticationdfapolicyBindingArray1;
    }

    private class authenticationdfapolicy_binding_response : base_response
    {
      public authenticationdfapolicy_binding[] authenticationdfapolicy_binding = (authenticationdfapolicy_binding[]) null;
    }
  }
}
