// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.rnatglobal_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class rnatglobal_binding : base_resource
  {
    private com.citrix.netscaler.nitro.resource.config.network.rnatglobal_auditsyslogpolicy_binding[] rnatglobal_auditsyslogpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.network.rnatglobal_auditsyslogpolicy_binding[]) null;

    public com.citrix.netscaler.nitro.resource.config.network.rnatglobal_auditsyslogpolicy_binding[] rnatglobal_auditsyslogpolicy_binding
    {
      get => this.rnatglobal_auditsyslogpolicy_bindingField;
      private set => this.rnatglobal_auditsyslogpolicy_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      rnatglobal_binding.rnatglobal_binding_response rnatglobalBindingResponse = new rnatglobal_binding.rnatglobal_binding_response();
      rnatglobal_binding.rnatglobal_binding_response resource = (rnatglobal_binding.rnatglobal_binding_response) service.get_payload_formatter().string_to_resource(rnatglobalBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.rnatglobal_binding;
    }

    internal override string get_object_name() => (string) null;

    public static rnatglobal_binding get(nitro_service service) => (rnatglobal_binding) new rnatglobal_binding().get_resource(service);

    private class rnatglobal_binding_response : base_response
    {
      public rnatglobal_binding[] rnatglobal_binding = (rnatglobal_binding[]) null;
    }
  }
}
