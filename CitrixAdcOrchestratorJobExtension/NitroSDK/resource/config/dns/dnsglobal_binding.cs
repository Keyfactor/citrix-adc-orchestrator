// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.dns.dnsglobal_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.dns
{
  public class dnsglobal_binding : base_resource
  {
    private com.citrix.netscaler.nitro.resource.config.dns.dnsglobal_dnspolicy_binding[] dnsglobal_dnspolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.dns.dnsglobal_dnspolicy_binding[]) null;

    public com.citrix.netscaler.nitro.resource.config.dns.dnsglobal_dnspolicy_binding[] dnsglobal_dnspolicy_binding
    {
      get => this.dnsglobal_dnspolicy_bindingField;
      private set => this.dnsglobal_dnspolicy_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      dnsglobal_binding.dnsglobal_binding_response dnsglobalBindingResponse = new dnsglobal_binding.dnsglobal_binding_response();
      dnsglobal_binding.dnsglobal_binding_response resource = (dnsglobal_binding.dnsglobal_binding_response) service.get_payload_formatter().string_to_resource(dnsglobalBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.dnsglobal_binding;
    }

    internal override string get_object_name() => (string) null;

    public static dnsglobal_binding get(nitro_service service) => (dnsglobal_binding) new dnsglobal_binding().get_resource(service);

    private class dnsglobal_binding_response : base_response
    {
      public dnsglobal_binding[] dnsglobal_binding = (dnsglobal_binding[]) null;
    }
  }
}
