// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.tm.tmglobal_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.tm
{
  public class tmglobal_binding : base_resource
  {
    private com.citrix.netscaler.nitro.resource.config.tm.tmglobal_tmtrafficpolicy_binding[] tmglobal_tmtrafficpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.tm.tmglobal_tmtrafficpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.tm.tmglobal_auditsyslogpolicy_binding[] tmglobal_auditsyslogpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.tm.tmglobal_auditsyslogpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.tm.tmglobal_auditnslogpolicy_binding[] tmglobal_auditnslogpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.tm.tmglobal_auditnslogpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.tm.tmglobal_tmsessionpolicy_binding[] tmglobal_tmsessionpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.tm.tmglobal_tmsessionpolicy_binding[]) null;

    public com.citrix.netscaler.nitro.resource.config.tm.tmglobal_tmtrafficpolicy_binding[] tmglobal_tmtrafficpolicy_binding
    {
      get => this.tmglobal_tmtrafficpolicy_bindingField;
      private set => this.tmglobal_tmtrafficpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.tm.tmglobal_auditnslogpolicy_binding[] tmglobal_auditnslogpolicy_binding
    {
      get => this.tmglobal_auditnslogpolicy_bindingField;
      private set => this.tmglobal_auditnslogpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.tm.tmglobal_auditsyslogpolicy_binding[] tmglobal_auditsyslogpolicy_binding
    {
      get => this.tmglobal_auditsyslogpolicy_bindingField;
      private set => this.tmglobal_auditsyslogpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.tm.tmglobal_tmsessionpolicy_binding[] tmglobal_tmsessionpolicy_binding
    {
      get => this.tmglobal_tmsessionpolicy_bindingField;
      private set => this.tmglobal_tmsessionpolicy_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      tmglobal_binding.tmglobal_binding_response tmglobalBindingResponse = new tmglobal_binding.tmglobal_binding_response();
      tmglobal_binding.tmglobal_binding_response resource = (tmglobal_binding.tmglobal_binding_response) service.get_payload_formatter().string_to_resource(tmglobalBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.tmglobal_binding;
    }

    internal override string get_object_name() => (string) null;

    public static tmglobal_binding get(nitro_service service) => (tmglobal_binding) new tmglobal_binding().get_resource(service);

    private class tmglobal_binding_response : base_response
    {
      public tmglobal_binding[] tmglobal_binding = (tmglobal_binding[]) null;
    }
  }
}
