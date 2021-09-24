// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.system.systemglobal_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.system
{
  public class systemglobal_binding : base_resource
  {
    private com.citrix.netscaler.nitro.resource.config.system.systemglobal_authenticationradiuspolicy_binding[] systemglobal_authenticationradiuspolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.system.systemglobal_authenticationradiuspolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.system.systemglobal_authenticationldappolicy_binding[] systemglobal_authenticationldappolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.system.systemglobal_authenticationldappolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.system.systemglobal_authenticationlocalpolicy_binding[] systemglobal_authenticationlocalpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.system.systemglobal_authenticationlocalpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.system.systemglobal_auditsyslogpolicy_binding[] systemglobal_auditsyslogpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.system.systemglobal_auditsyslogpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.system.systemglobal_auditnslogpolicy_binding[] systemglobal_auditnslogpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.system.systemglobal_auditnslogpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.system.systemglobal_authenticationpolicy_binding[] systemglobal_authenticationpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.system.systemglobal_authenticationpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.system.systemglobal_authenticationtacacspolicy_binding[] systemglobal_authenticationtacacspolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.system.systemglobal_authenticationtacacspolicy_binding[]) null;

    public com.citrix.netscaler.nitro.resource.config.system.systemglobal_authenticationldappolicy_binding[] systemglobal_authenticationldappolicy_binding
    {
      get => this.systemglobal_authenticationldappolicy_bindingField;
      private set => this.systemglobal_authenticationldappolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.system.systemglobal_auditsyslogpolicy_binding[] systemglobal_auditsyslogpolicy_binding
    {
      get => this.systemglobal_auditsyslogpolicy_bindingField;
      private set => this.systemglobal_auditsyslogpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.system.systemglobal_authenticationlocalpolicy_binding[] systemglobal_authenticationlocalpolicy_binding
    {
      get => this.systemglobal_authenticationlocalpolicy_bindingField;
      private set => this.systemglobal_authenticationlocalpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.system.systemglobal_auditnslogpolicy_binding[] systemglobal_auditnslogpolicy_binding
    {
      get => this.systemglobal_auditnslogpolicy_bindingField;
      private set => this.systemglobal_auditnslogpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.system.systemglobal_authenticationtacacspolicy_binding[] systemglobal_authenticationtacacspolicy_binding
    {
      get => this.systemglobal_authenticationtacacspolicy_bindingField;
      private set => this.systemglobal_authenticationtacacspolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.system.systemglobal_authenticationpolicy_binding[] systemglobal_authenticationpolicy_binding
    {
      get => this.systemglobal_authenticationpolicy_bindingField;
      private set => this.systemglobal_authenticationpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.system.systemglobal_authenticationradiuspolicy_binding[] systemglobal_authenticationradiuspolicy_binding
    {
      get => this.systemglobal_authenticationradiuspolicy_bindingField;
      private set => this.systemglobal_authenticationradiuspolicy_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      systemglobal_binding.systemglobal_binding_response systemglobalBindingResponse = new systemglobal_binding.systemglobal_binding_response();
      systemglobal_binding.systemglobal_binding_response resource = (systemglobal_binding.systemglobal_binding_response) service.get_payload_formatter().string_to_resource(systemglobalBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.systemglobal_binding;
    }

    internal override string get_object_name() => (string) null;

    public static systemglobal_binding get(nitro_service service) => (systemglobal_binding) new systemglobal_binding().get_resource(service);

    private class systemglobal_binding_response : base_response
    {
      public systemglobal_binding[] systemglobal_binding = (systemglobal_binding[]) null;
    }
  }
}
