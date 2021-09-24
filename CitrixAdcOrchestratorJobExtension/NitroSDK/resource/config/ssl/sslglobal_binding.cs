// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslglobal_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslglobal_binding : base_resource
  {
    private com.citrix.netscaler.nitro.resource.config.ssl.sslglobal_sslpolicy_binding[] sslglobal_sslpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.ssl.sslglobal_sslpolicy_binding[]) null;

    public com.citrix.netscaler.nitro.resource.config.ssl.sslglobal_sslpolicy_binding[] sslglobal_sslpolicy_binding
    {
      get => this.sslglobal_sslpolicy_bindingField;
      private set => this.sslglobal_sslpolicy_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslglobal_binding.sslglobal_binding_response sslglobalBindingResponse = new sslglobal_binding.sslglobal_binding_response();
      sslglobal_binding.sslglobal_binding_response resource = (sslglobal_binding.sslglobal_binding_response) service.get_payload_formatter().string_to_resource(sslglobalBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslglobal_binding;
    }

    internal override string get_object_name() => (string) null;

    public static sslglobal_binding get(nitro_service service) => (sslglobal_binding) new sslglobal_binding().get_resource(service);

    private class sslglobal_binding_response : base_response
    {
      public sslglobal_binding[] sslglobal_binding = (sslglobal_binding[]) null;
    }
  }
}
