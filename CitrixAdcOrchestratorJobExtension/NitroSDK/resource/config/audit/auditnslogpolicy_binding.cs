// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.audit.auditnslogpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.audit
{
  public class auditnslogpolicy_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.audit.auditnslogpolicy_tmglobal_binding[] auditnslogpolicy_tmglobal_bindingField = (com.citrix.netscaler.nitro.resource.config.audit.auditnslogpolicy_tmglobal_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.audit.auditnslogpolicy_appfwglobal_binding[] auditnslogpolicy_appfwglobal_bindingField = (com.citrix.netscaler.nitro.resource.config.audit.auditnslogpolicy_appfwglobal_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.audit.auditnslogpolicy_lbvserver_binding[] auditnslogpolicy_lbvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.audit.auditnslogpolicy_lbvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.audit.auditnslogpolicy_vpnglobal_binding[] auditnslogpolicy_vpnglobal_bindingField = (com.citrix.netscaler.nitro.resource.config.audit.auditnslogpolicy_vpnglobal_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.audit.auditnslogpolicy_vpnvserver_binding[] auditnslogpolicy_vpnvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.audit.auditnslogpolicy_vpnvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.audit.auditnslogpolicy_csvserver_binding[] auditnslogpolicy_csvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.audit.auditnslogpolicy_csvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.audit.auditnslogpolicy_aaauser_binding[] auditnslogpolicy_aaauser_bindingField = (com.citrix.netscaler.nitro.resource.config.audit.auditnslogpolicy_aaauser_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.audit.auditnslogpolicy_systemglobal_binding[] auditnslogpolicy_systemglobal_bindingField = (com.citrix.netscaler.nitro.resource.config.audit.auditnslogpolicy_systemglobal_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.audit.auditnslogpolicy_authenticationvserver_binding[] auditnslogpolicy_authenticationvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.audit.auditnslogpolicy_authenticationvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.audit.auditnslogpolicy_aaagroup_binding[] auditnslogpolicy_aaagroup_bindingField = (com.citrix.netscaler.nitro.resource.config.audit.auditnslogpolicy_aaagroup_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.audit.auditnslogpolicy_systemglobal_binding[] auditnslogpolicy_systemglobal_binding
    {
      get => this.auditnslogpolicy_systemglobal_bindingField;
      private set => this.auditnslogpolicy_systemglobal_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.audit.auditnslogpolicy_aaagroup_binding[] auditnslogpolicy_aaagroup_binding
    {
      get => this.auditnslogpolicy_aaagroup_bindingField;
      private set => this.auditnslogpolicy_aaagroup_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.audit.auditnslogpolicy_lbvserver_binding[] auditnslogpolicy_lbvserver_binding
    {
      get => this.auditnslogpolicy_lbvserver_bindingField;
      private set => this.auditnslogpolicy_lbvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.audit.auditnslogpolicy_csvserver_binding[] auditnslogpolicy_csvserver_binding
    {
      get => this.auditnslogpolicy_csvserver_bindingField;
      private set => this.auditnslogpolicy_csvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.audit.auditnslogpolicy_vpnglobal_binding[] auditnslogpolicy_vpnglobal_binding
    {
      get => this.auditnslogpolicy_vpnglobal_bindingField;
      private set => this.auditnslogpolicy_vpnglobal_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.audit.auditnslogpolicy_aaauser_binding[] auditnslogpolicy_aaauser_binding
    {
      get => this.auditnslogpolicy_aaauser_bindingField;
      private set => this.auditnslogpolicy_aaauser_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.audit.auditnslogpolicy_authenticationvserver_binding[] auditnslogpolicy_authenticationvserver_binding
    {
      get => this.auditnslogpolicy_authenticationvserver_bindingField;
      private set => this.auditnslogpolicy_authenticationvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.audit.auditnslogpolicy_vpnvserver_binding[] auditnslogpolicy_vpnvserver_binding
    {
      get => this.auditnslogpolicy_vpnvserver_bindingField;
      private set => this.auditnslogpolicy_vpnvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.audit.auditnslogpolicy_appfwglobal_binding[] auditnslogpolicy_appfwglobal_binding
    {
      get => this.auditnslogpolicy_appfwglobal_bindingField;
      private set => this.auditnslogpolicy_appfwglobal_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.audit.auditnslogpolicy_tmglobal_binding[] auditnslogpolicy_tmglobal_binding
    {
      get => this.auditnslogpolicy_tmglobal_bindingField;
      private set => this.auditnslogpolicy_tmglobal_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      auditnslogpolicy_binding.auditnslogpolicy_binding_response auditnslogpolicyBindingResponse = new auditnslogpolicy_binding.auditnslogpolicy_binding_response();
      auditnslogpolicy_binding.auditnslogpolicy_binding_response resource = (auditnslogpolicy_binding.auditnslogpolicy_binding_response) service.get_payload_formatter().string_to_resource(auditnslogpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.auditnslogpolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static auditnslogpolicy_binding get(
      nitro_service service,
      string name)
    {
      return (auditnslogpolicy_binding) new auditnslogpolicy_binding()
      {
        name = name
      }.get_resource(service);
    }

    public static auditnslogpolicy_binding[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (auditnslogpolicy_binding[]) null;
      auditnslogpolicy_binding[] auditnslogpolicyBindingArray1 = new auditnslogpolicy_binding[name.Length];
      auditnslogpolicy_binding[] auditnslogpolicyBindingArray2 = new auditnslogpolicy_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        auditnslogpolicyBindingArray2[index] = new auditnslogpolicy_binding();
        auditnslogpolicyBindingArray2[index].name = name[index];
        auditnslogpolicyBindingArray1[index] = (auditnslogpolicy_binding) auditnslogpolicyBindingArray2[index].get_resource(service);
      }
      return auditnslogpolicyBindingArray1;
    }

    private class auditnslogpolicy_binding_response : base_response
    {
      public auditnslogpolicy_binding[] auditnslogpolicy_binding = (auditnslogpolicy_binding[]) null;
    }
  }
}
