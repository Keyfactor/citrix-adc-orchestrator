// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ica.icaglobal_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ica
{
  public class icaglobal_binding : base_resource
  {
    private com.citrix.netscaler.nitro.resource.config.ica.icaglobal_icapolicy_binding[] icaglobal_icapolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.ica.icaglobal_icapolicy_binding[]) null;

    public com.citrix.netscaler.nitro.resource.config.ica.icaglobal_icapolicy_binding[] icaglobal_icapolicy_binding
    {
      get => this.icaglobal_icapolicy_bindingField;
      private set => this.icaglobal_icapolicy_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      icaglobal_binding.icaglobal_binding_response icaglobalBindingResponse = new icaglobal_binding.icaglobal_binding_response();
      icaglobal_binding.icaglobal_binding_response resource = (icaglobal_binding.icaglobal_binding_response) service.get_payload_formatter().string_to_resource(icaglobalBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.icaglobal_binding;
    }

    internal override string get_object_name() => (string) null;

    public static icaglobal_binding get(nitro_service service) => (icaglobal_binding) new icaglobal_binding().get_resource(service);

    private class icaglobal_binding_response : base_response
    {
      public icaglobal_binding[] icaglobal_binding = (icaglobal_binding[]) null;
    }
  }
}
