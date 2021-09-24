// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.tunnel.tunneltrafficpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.tunnel
{
  public class tunneltrafficpolicy_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.tunnel.tunneltrafficpolicy_tunnelglobal_binding[] tunneltrafficpolicy_tunnelglobal_bindingField = (com.citrix.netscaler.nitro.resource.config.tunnel.tunneltrafficpolicy_tunnelglobal_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.tunnel.tunneltrafficpolicy_tunnelglobal_binding[] tunneltrafficpolicy_tunnelglobal_binding
    {
      get => this.tunneltrafficpolicy_tunnelglobal_bindingField;
      private set => this.tunneltrafficpolicy_tunnelglobal_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      tunneltrafficpolicy_binding.tunneltrafficpolicy_binding_response tunneltrafficpolicyBindingResponse = new tunneltrafficpolicy_binding.tunneltrafficpolicy_binding_response();
      tunneltrafficpolicy_binding.tunneltrafficpolicy_binding_response resource = (tunneltrafficpolicy_binding.tunneltrafficpolicy_binding_response) service.get_payload_formatter().string_to_resource(tunneltrafficpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.tunneltrafficpolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static tunneltrafficpolicy_binding get(
      nitro_service service,
      string name)
    {
      return (tunneltrafficpolicy_binding) new tunneltrafficpolicy_binding()
      {
        name = name
      }.get_resource(service);
    }

    public static tunneltrafficpolicy_binding[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (tunneltrafficpolicy_binding[]) null;
      tunneltrafficpolicy_binding[] tunneltrafficpolicyBindingArray1 = new tunneltrafficpolicy_binding[name.Length];
      tunneltrafficpolicy_binding[] tunneltrafficpolicyBindingArray2 = new tunneltrafficpolicy_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        tunneltrafficpolicyBindingArray2[index] = new tunneltrafficpolicy_binding();
        tunneltrafficpolicyBindingArray2[index].name = name[index];
        tunneltrafficpolicyBindingArray1[index] = (tunneltrafficpolicy_binding) tunneltrafficpolicyBindingArray2[index].get_resource(service);
      }
      return tunneltrafficpolicyBindingArray1;
    }

    private class tunneltrafficpolicy_binding_response : base_response
    {
      public tunneltrafficpolicy_binding[] tunneltrafficpolicy_binding = (tunneltrafficpolicy_binding[]) null;
    }
  }
}
