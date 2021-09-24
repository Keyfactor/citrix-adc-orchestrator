// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.audit.auditsyslogpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.audit
{
  public class auditsyslogpolicy_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.audit.auditsyslogpolicy_csvserver_binding[] auditsyslogpolicy_csvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.audit.auditsyslogpolicy_csvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.audit.auditsyslogpolicy_tmglobal_binding[] auditsyslogpolicy_tmglobal_bindingField = (com.citrix.netscaler.nitro.resource.config.audit.auditsyslogpolicy_tmglobal_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.audit.auditsyslogpolicy_lbvserver_binding[] auditsyslogpolicy_lbvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.audit.auditsyslogpolicy_lbvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.audit.auditsyslogpolicy_aaauser_binding[] auditsyslogpolicy_aaauser_bindingField = (com.citrix.netscaler.nitro.resource.config.audit.auditsyslogpolicy_aaauser_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.audit.auditsyslogpolicy_vpnglobal_binding[] auditsyslogpolicy_vpnglobal_bindingField = (com.citrix.netscaler.nitro.resource.config.audit.auditsyslogpolicy_vpnglobal_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.audit.auditsyslogpolicy_rnatglobal_binding[] auditsyslogpolicy_rnatglobal_bindingField = (com.citrix.netscaler.nitro.resource.config.audit.auditsyslogpolicy_rnatglobal_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.audit.auditsyslogpolicy_vpnvserver_binding[] auditsyslogpolicy_vpnvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.audit.auditsyslogpolicy_vpnvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.audit.auditsyslogpolicy_systemglobal_binding[] auditsyslogpolicy_systemglobal_bindingField = (com.citrix.netscaler.nitro.resource.config.audit.auditsyslogpolicy_systemglobal_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.audit.auditsyslogpolicy_authenticationvserver_binding[] auditsyslogpolicy_authenticationvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.audit.auditsyslogpolicy_authenticationvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.audit.auditsyslogpolicy_aaagroup_binding[] auditsyslogpolicy_aaagroup_bindingField = (com.citrix.netscaler.nitro.resource.config.audit.auditsyslogpolicy_aaagroup_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.audit.auditsyslogpolicy_aaagroup_binding[] auditsyslogpolicy_aaagroup_binding
    {
      get => this.auditsyslogpolicy_aaagroup_bindingField;
      private set => this.auditsyslogpolicy_aaagroup_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.audit.auditsyslogpolicy_tmglobal_binding[] auditsyslogpolicy_tmglobal_binding
    {
      get => this.auditsyslogpolicy_tmglobal_bindingField;
      private set => this.auditsyslogpolicy_tmglobal_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.audit.auditsyslogpolicy_rnatglobal_binding[] auditsyslogpolicy_rnatglobal_binding
    {
      get => this.auditsyslogpolicy_rnatglobal_bindingField;
      private set => this.auditsyslogpolicy_rnatglobal_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.audit.auditsyslogpolicy_vpnvserver_binding[] auditsyslogpolicy_vpnvserver_binding
    {
      get => this.auditsyslogpolicy_vpnvserver_bindingField;
      private set => this.auditsyslogpolicy_vpnvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.audit.auditsyslogpolicy_aaauser_binding[] auditsyslogpolicy_aaauser_binding
    {
      get => this.auditsyslogpolicy_aaauser_bindingField;
      private set => this.auditsyslogpolicy_aaauser_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.audit.auditsyslogpolicy_vpnglobal_binding[] auditsyslogpolicy_vpnglobal_binding
    {
      get => this.auditsyslogpolicy_vpnglobal_bindingField;
      private set => this.auditsyslogpolicy_vpnglobal_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.audit.auditsyslogpolicy_authenticationvserver_binding[] auditsyslogpolicy_authenticationvserver_binding
    {
      get => this.auditsyslogpolicy_authenticationvserver_bindingField;
      private set => this.auditsyslogpolicy_authenticationvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.audit.auditsyslogpolicy_lbvserver_binding[] auditsyslogpolicy_lbvserver_binding
    {
      get => this.auditsyslogpolicy_lbvserver_bindingField;
      private set => this.auditsyslogpolicy_lbvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.audit.auditsyslogpolicy_csvserver_binding[] auditsyslogpolicy_csvserver_binding
    {
      get => this.auditsyslogpolicy_csvserver_bindingField;
      private set => this.auditsyslogpolicy_csvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.audit.auditsyslogpolicy_systemglobal_binding[] auditsyslogpolicy_systemglobal_binding
    {
      get => this.auditsyslogpolicy_systemglobal_bindingField;
      private set => this.auditsyslogpolicy_systemglobal_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      auditsyslogpolicy_binding.auditsyslogpolicy_binding_response auditsyslogpolicyBindingResponse = new auditsyslogpolicy_binding.auditsyslogpolicy_binding_response();
      auditsyslogpolicy_binding.auditsyslogpolicy_binding_response resource = (auditsyslogpolicy_binding.auditsyslogpolicy_binding_response) service.get_payload_formatter().string_to_resource(auditsyslogpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.auditsyslogpolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static auditsyslogpolicy_binding get(
      nitro_service service,
      string name)
    {
      return (auditsyslogpolicy_binding) new auditsyslogpolicy_binding()
      {
        name = name
      }.get_resource(service);
    }

    public static auditsyslogpolicy_binding[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (auditsyslogpolicy_binding[]) null;
      auditsyslogpolicy_binding[] auditsyslogpolicyBindingArray1 = new auditsyslogpolicy_binding[name.Length];
      auditsyslogpolicy_binding[] auditsyslogpolicyBindingArray2 = new auditsyslogpolicy_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        auditsyslogpolicyBindingArray2[index] = new auditsyslogpolicy_binding();
        auditsyslogpolicyBindingArray2[index].name = name[index];
        auditsyslogpolicyBindingArray1[index] = (auditsyslogpolicy_binding) auditsyslogpolicyBindingArray2[index].get_resource(service);
      }
      return auditsyslogpolicyBindingArray1;
    }

    private class auditsyslogpolicy_binding_response : base_response
    {
      public auditsyslogpolicy_binding[] auditsyslogpolicy_binding = (auditsyslogpolicy_binding[]) null;
    }
  }
}
