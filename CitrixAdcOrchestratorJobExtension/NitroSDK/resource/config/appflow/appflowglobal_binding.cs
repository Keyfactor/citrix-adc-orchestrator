// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.appflow.appflowglobal_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.appflow
{
  public class appflowglobal_binding : base_resource
  {
    private com.citrix.netscaler.nitro.resource.config.appflow.appflowglobal_appflowpolicy_binding[] appflowglobal_appflowpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.appflow.appflowglobal_appflowpolicy_binding[]) null;

    public com.citrix.netscaler.nitro.resource.config.appflow.appflowglobal_appflowpolicy_binding[] appflowglobal_appflowpolicy_binding
    {
      get => this.appflowglobal_appflowpolicy_bindingField;
      private set => this.appflowglobal_appflowpolicy_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      appflowglobal_binding.appflowglobal_binding_response appflowglobalBindingResponse = new appflowglobal_binding.appflowglobal_binding_response();
      appflowglobal_binding.appflowglobal_binding_response resource = (appflowglobal_binding.appflowglobal_binding_response) service.get_payload_formatter().string_to_resource(appflowglobalBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.appflowglobal_binding;
    }

    internal override string get_object_name() => (string) null;

    public static appflowglobal_binding get(nitro_service service) => (appflowglobal_binding) new appflowglobal_binding().get_resource(service);

    private class appflowglobal_binding_response : base_response
    {
      public appflowglobal_binding[] appflowglobal_binding = (appflowglobal_binding[]) null;
    }
  }
}
