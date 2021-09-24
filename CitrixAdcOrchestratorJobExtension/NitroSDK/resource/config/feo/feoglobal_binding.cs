// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.feo.feoglobal_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.feo
{
  public class feoglobal_binding : base_resource
  {
    private com.citrix.netscaler.nitro.resource.config.feo.feoglobal_feopolicy_binding[] feoglobal_feopolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.feo.feoglobal_feopolicy_binding[]) null;

    public com.citrix.netscaler.nitro.resource.config.feo.feoglobal_feopolicy_binding[] feoglobal_feopolicy_binding
    {
      get => this.feoglobal_feopolicy_bindingField;
      private set => this.feoglobal_feopolicy_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      feoglobal_binding.feoglobal_binding_response feoglobalBindingResponse = new feoglobal_binding.feoglobal_binding_response();
      feoglobal_binding.feoglobal_binding_response resource = (feoglobal_binding.feoglobal_binding_response) service.get_payload_formatter().string_to_resource(feoglobalBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.feoglobal_binding;
    }

    internal override string get_object_name() => (string) null;

    public static feoglobal_binding get(nitro_service service) => (feoglobal_binding) new feoglobal_binding().get_resource(service);

    private class feoglobal_binding_response : base_response
    {
      public feoglobal_binding[] feoglobal_binding = (feoglobal_binding[]) null;
    }
  }
}
