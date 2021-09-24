// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.responder.responderglobal_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.responder
{
  public class responderglobal_binding : base_resource
  {
    private com.citrix.netscaler.nitro.resource.config.responder.responderglobal_responderpolicy_binding[] responderglobal_responderpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.responder.responderglobal_responderpolicy_binding[]) null;

    public com.citrix.netscaler.nitro.resource.config.responder.responderglobal_responderpolicy_binding[] responderglobal_responderpolicy_binding
    {
      get => this.responderglobal_responderpolicy_bindingField;
      private set => this.responderglobal_responderpolicy_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      responderglobal_binding.responderglobal_binding_response responderglobalBindingResponse = new responderglobal_binding.responderglobal_binding_response();
      responderglobal_binding.responderglobal_binding_response resource = (responderglobal_binding.responderglobal_binding_response) service.get_payload_formatter().string_to_resource(responderglobalBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.responderglobal_binding;
    }

    internal override string get_object_name() => (string) null;

    public static responderglobal_binding get(nitro_service service) => (responderglobal_binding) new responderglobal_binding().get_resource(service);

    private class responderglobal_binding_response : base_response
    {
      public responderglobal_binding[] responderglobal_binding = (responderglobal_binding[]) null;
    }
  }
}
