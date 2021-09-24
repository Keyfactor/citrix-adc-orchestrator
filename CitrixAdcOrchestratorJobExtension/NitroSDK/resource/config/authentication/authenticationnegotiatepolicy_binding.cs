// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationnegotiatepolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationnegotiatepolicy_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.authentication.authenticationnegotiatepolicy_authenticationvserver_binding[] authenticationnegotiatepolicy_authenticationvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.authentication.authenticationnegotiatepolicy_authenticationvserver_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.authentication.authenticationnegotiatepolicy_authenticationvserver_binding[] authenticationnegotiatepolicy_authenticationvserver_binding
    {
      get => this.authenticationnegotiatepolicy_authenticationvserver_bindingField;
      private set => this.authenticationnegotiatepolicy_authenticationvserver_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      authenticationnegotiatepolicy_binding.authenticationnegotiatepolicy_binding_response authenticationnegotiatepolicyBindingResponse = new authenticationnegotiatepolicy_binding.authenticationnegotiatepolicy_binding_response();
      authenticationnegotiatepolicy_binding.authenticationnegotiatepolicy_binding_response resource = (authenticationnegotiatepolicy_binding.authenticationnegotiatepolicy_binding_response) service.get_payload_formatter().string_to_resource(authenticationnegotiatepolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationnegotiatepolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static authenticationnegotiatepolicy_binding get(
      nitro_service service,
      string name)
    {
      return (authenticationnegotiatepolicy_binding) new authenticationnegotiatepolicy_binding()
      {
        name = name
      }.get_resource(service);
    }

    public static authenticationnegotiatepolicy_binding[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (authenticationnegotiatepolicy_binding[]) null;
      authenticationnegotiatepolicy_binding[] authenticationnegotiatepolicyBindingArray1 = new authenticationnegotiatepolicy_binding[name.Length];
      authenticationnegotiatepolicy_binding[] authenticationnegotiatepolicyBindingArray2 = new authenticationnegotiatepolicy_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        authenticationnegotiatepolicyBindingArray2[index] = new authenticationnegotiatepolicy_binding();
        authenticationnegotiatepolicyBindingArray2[index].name = name[index];
        authenticationnegotiatepolicyBindingArray1[index] = (authenticationnegotiatepolicy_binding) authenticationnegotiatepolicyBindingArray2[index].get_resource(service);
      }
      return authenticationnegotiatepolicyBindingArray1;
    }

    private class authenticationnegotiatepolicy_binding_response : base_response
    {
      public authenticationnegotiatepolicy_binding[] authenticationnegotiatepolicy_binding = (authenticationnegotiatepolicy_binding[]) null;
    }
  }
}
