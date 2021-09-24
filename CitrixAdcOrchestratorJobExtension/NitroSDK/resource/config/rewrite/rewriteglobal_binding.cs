// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.rewrite.rewriteglobal_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.rewrite
{
  public class rewriteglobal_binding : base_resource
  {
    private com.citrix.netscaler.nitro.resource.config.rewrite.rewriteglobal_rewritepolicy_binding[] rewriteglobal_rewritepolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.rewrite.rewriteglobal_rewritepolicy_binding[]) null;

    public com.citrix.netscaler.nitro.resource.config.rewrite.rewriteglobal_rewritepolicy_binding[] rewriteglobal_rewritepolicy_binding
    {
      get => this.rewriteglobal_rewritepolicy_bindingField;
      private set => this.rewriteglobal_rewritepolicy_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      rewriteglobal_binding.rewriteglobal_binding_response rewriteglobalBindingResponse = new rewriteglobal_binding.rewriteglobal_binding_response();
      rewriteglobal_binding.rewriteglobal_binding_response resource = (rewriteglobal_binding.rewriteglobal_binding_response) service.get_payload_formatter().string_to_resource(rewriteglobalBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.rewriteglobal_binding;
    }

    internal override string get_object_name() => (string) null;

    public static rewriteglobal_binding get(nitro_service service) => (rewriteglobal_binding) new rewriteglobal_binding().get_resource(service);

    private class rewriteglobal_binding_response : base_response
    {
      public rewriteglobal_binding[] rewriteglobal_binding = (rewriteglobal_binding[]) null;
    }
  }
}
