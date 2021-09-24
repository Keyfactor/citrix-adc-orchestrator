// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ca.caglobal_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ca
{
  public class caglobal_binding : base_resource
  {
    private com.citrix.netscaler.nitro.resource.config.ca.caglobal_capolicy_binding[] caglobal_capolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.ca.caglobal_capolicy_binding[]) null;

    public com.citrix.netscaler.nitro.resource.config.ca.caglobal_capolicy_binding[] caglobal_capolicy_binding
    {
      get => this.caglobal_capolicy_bindingField;
      private set => this.caglobal_capolicy_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      caglobal_binding.caglobal_binding_response caglobalBindingResponse = new caglobal_binding.caglobal_binding_response();
      caglobal_binding.caglobal_binding_response resource = (caglobal_binding.caglobal_binding_response) service.get_payload_formatter().string_to_resource(caglobalBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.caglobal_binding;
    }

    internal override string get_object_name() => (string) null;

    public static caglobal_binding get(nitro_service service) => (caglobal_binding) new caglobal_binding().get_resource(service);

    private class caglobal_binding_response : base_response
    {
      public caglobal_binding[] caglobal_binding = (caglobal_binding[]) null;
    }
  }
}
