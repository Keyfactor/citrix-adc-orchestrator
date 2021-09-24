// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.filter.filterglobal_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.filter
{
  public class filterglobal_binding : base_resource
  {
    private com.citrix.netscaler.nitro.resource.config.filter.filterglobal_filterpolicy_binding[] filterglobal_filterpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.filter.filterglobal_filterpolicy_binding[]) null;

    public com.citrix.netscaler.nitro.resource.config.filter.filterglobal_filterpolicy_binding[] filterglobal_filterpolicy_binding
    {
      get => this.filterglobal_filterpolicy_bindingField;
      private set => this.filterglobal_filterpolicy_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      filterglobal_binding.filterglobal_binding_response filterglobalBindingResponse = new filterglobal_binding.filterglobal_binding_response();
      filterglobal_binding.filterglobal_binding_response resource = (filterglobal_binding.filterglobal_binding_response) service.get_payload_formatter().string_to_resource(filterglobalBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.filterglobal_binding;
    }

    internal override string get_object_name() => (string) null;

    public static filterglobal_binding get(nitro_service service) => (filterglobal_binding) new filterglobal_binding().get_resource(service);

    private class filterglobal_binding_response : base_response
    {
      public filterglobal_binding[] filterglobal_binding = (filterglobal_binding[]) null;
    }
  }
}
