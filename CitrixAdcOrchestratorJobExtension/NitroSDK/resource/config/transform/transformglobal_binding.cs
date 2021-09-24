// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.transform.transformglobal_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.transform
{
  public class transformglobal_binding : base_resource
  {
    private com.citrix.netscaler.nitro.resource.config.transform.transformglobal_transformpolicy_binding[] transformglobal_transformpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.transform.transformglobal_transformpolicy_binding[]) null;

    public com.citrix.netscaler.nitro.resource.config.transform.transformglobal_transformpolicy_binding[] transformglobal_transformpolicy_binding
    {
      get => this.transformglobal_transformpolicy_bindingField;
      private set => this.transformglobal_transformpolicy_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      transformglobal_binding.transformglobal_binding_response transformglobalBindingResponse = new transformglobal_binding.transformglobal_binding_response();
      transformglobal_binding.transformglobal_binding_response resource = (transformglobal_binding.transformglobal_binding_response) service.get_payload_formatter().string_to_resource(transformglobalBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.transformglobal_binding;
    }

    internal override string get_object_name() => (string) null;

    public static transformglobal_binding get(nitro_service service) => (transformglobal_binding) new transformglobal_binding().get_resource(service);

    private class transformglobal_binding_response : base_response
    {
      public transformglobal_binding[] transformglobal_binding = (transformglobal_binding[]) null;
    }
  }
}
