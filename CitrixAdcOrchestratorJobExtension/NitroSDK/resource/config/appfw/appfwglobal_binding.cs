// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.appfw.appfwglobal_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.appfw
{
  public class appfwglobal_binding : base_resource
  {
    private com.citrix.netscaler.nitro.resource.config.appfw.appfwglobal_auditsyslogpolicy_binding[] appfwglobal_auditsyslogpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.appfw.appfwglobal_auditsyslogpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.appfw.appfwglobal_auditnslogpolicy_binding[] appfwglobal_auditnslogpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.appfw.appfwglobal_auditnslogpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.appfw.appfwglobal_appfwpolicy_binding[] appfwglobal_appfwpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.appfw.appfwglobal_appfwpolicy_binding[]) null;

    public com.citrix.netscaler.nitro.resource.config.appfw.appfwglobal_appfwpolicy_binding[] appfwglobal_appfwpolicy_binding
    {
      get => this.appfwglobal_appfwpolicy_bindingField;
      private set => this.appfwglobal_appfwpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.appfw.appfwglobal_auditsyslogpolicy_binding[] appfwglobal_auditsyslogpolicy_binding
    {
      get => this.appfwglobal_auditsyslogpolicy_bindingField;
      private set => this.appfwglobal_auditsyslogpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.appfw.appfwglobal_auditnslogpolicy_binding[] appfwglobal_auditnslogpolicy_binding
    {
      get => this.appfwglobal_auditnslogpolicy_bindingField;
      private set => this.appfwglobal_auditnslogpolicy_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      appfwglobal_binding.appfwglobal_binding_response appfwglobalBindingResponse = new appfwglobal_binding.appfwglobal_binding_response();
      appfwglobal_binding.appfwglobal_binding_response resource = (appfwglobal_binding.appfwglobal_binding_response) service.get_payload_formatter().string_to_resource(appfwglobalBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.appfwglobal_binding;
    }

    internal override string get_object_name() => (string) null;

    public static appfwglobal_binding get(nitro_service service) => (appfwglobal_binding) new appfwglobal_binding().get_resource(service);

    private class appfwglobal_binding_response : base_response
    {
      public appfwglobal_binding[] appfwglobal_binding = (appfwglobal_binding[]) null;
    }
  }
}
