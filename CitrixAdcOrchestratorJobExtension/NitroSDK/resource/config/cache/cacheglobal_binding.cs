// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cache.cacheglobal_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.cache
{
  public class cacheglobal_binding : base_resource
  {
    private com.citrix.netscaler.nitro.resource.config.cache.cacheglobal_cachepolicy_binding[] cacheglobal_cachepolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.cache.cacheglobal_cachepolicy_binding[]) null;

    public com.citrix.netscaler.nitro.resource.config.cache.cacheglobal_cachepolicy_binding[] cacheglobal_cachepolicy_binding
    {
      get => this.cacheglobal_cachepolicy_bindingField;
      private set => this.cacheglobal_cachepolicy_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      cacheglobal_binding.cacheglobal_binding_response cacheglobalBindingResponse = new cacheglobal_binding.cacheglobal_binding_response();
      cacheglobal_binding.cacheglobal_binding_response resource = (cacheglobal_binding.cacheglobal_binding_response) service.get_payload_formatter().string_to_resource(cacheglobalBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.cacheglobal_binding;
    }

    internal override string get_object_name() => (string) null;

    public static cacheglobal_binding get(nitro_service service) => (cacheglobal_binding) new cacheglobal_binding().get_resource(service);

    private class cacheglobal_binding_response : base_response
    {
      public cacheglobal_binding[] cacheglobal_binding = (cacheglobal_binding[]) null;
    }
  }
}
