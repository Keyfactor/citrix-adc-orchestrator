// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cmp.cmpglobal_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.cmp
{
  public class cmpglobal_binding : base_resource
  {
    private com.citrix.netscaler.nitro.resource.config.cmp.cmpglobal_cmppolicy_binding[] cmpglobal_cmppolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.cmp.cmpglobal_cmppolicy_binding[]) null;

    public com.citrix.netscaler.nitro.resource.config.cmp.cmpglobal_cmppolicy_binding[] cmpglobal_cmppolicy_binding
    {
      get => this.cmpglobal_cmppolicy_bindingField;
      private set => this.cmpglobal_cmppolicy_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      cmpglobal_binding.cmpglobal_binding_response cmpglobalBindingResponse = new cmpglobal_binding.cmpglobal_binding_response();
      cmpglobal_binding.cmpglobal_binding_response resource = (cmpglobal_binding.cmpglobal_binding_response) service.get_payload_formatter().string_to_resource(cmpglobalBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.cmpglobal_binding;
    }

    internal override string get_object_name() => (string) null;

    public static cmpglobal_binding get(nitro_service service) => (cmpglobal_binding) new cmpglobal_binding().get_resource(service);

    private class cmpglobal_binding_response : base_response
    {
      public cmpglobal_binding[] cmpglobal_binding = (cmpglobal_binding[]) null;
    }
  }
}
