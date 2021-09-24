// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cs.csvserver_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.cs
{
  public class csvserver_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.cs.csvserver_spilloverpolicy_binding[] csvserver_spilloverpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.cs.csvserver_spilloverpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cs.csvserver_auditnslogpolicy_binding[] csvserver_auditnslogpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.cs.csvserver_auditnslogpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cs.csvserver_domain_binding[] csvserver_domain_bindingField = (com.citrix.netscaler.nitro.resource.config.cs.csvserver_domain_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cs.csvserver_filterpolicy_binding[] csvserver_filterpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.cs.csvserver_filterpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cs.csvserver_cmppolicy_binding[] csvserver_cmppolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.cs.csvserver_cmppolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cs.csvserver_lbvserver_binding[] csvserver_lbvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.cs.csvserver_lbvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cs.csvserver_appflowpolicy_binding[] csvserver_appflowpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.cs.csvserver_appflowpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cs.csvserver_responderpolicy_binding[] csvserver_responderpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.cs.csvserver_responderpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cs.csvserver_transformpolicy_binding[] csvserver_transformpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.cs.csvserver_transformpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cs.csvserver_vpnvserver_binding[] csvserver_vpnvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.cs.csvserver_vpnvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cs.csvserver_feopolicy_binding[] csvserver_feopolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.cs.csvserver_feopolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cs.csvserver_authorizationpolicy_binding[] csvserver_authorizationpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.cs.csvserver_authorizationpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cs.csvserver_rewritepolicy_binding[] csvserver_rewritepolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.cs.csvserver_rewritepolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cs.csvserver_cachepolicy_binding[] csvserver_cachepolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.cs.csvserver_cachepolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cs.csvserver_cspolicy_binding[] csvserver_cspolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.cs.csvserver_cspolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cs.csvserver_gslbvserver_binding[] csvserver_gslbvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.cs.csvserver_gslbvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cs.csvserver_auditsyslogpolicy_binding[] csvserver_auditsyslogpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.cs.csvserver_auditsyslogpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cs.csvserver_tmtrafficpolicy_binding[] csvserver_tmtrafficpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.cs.csvserver_tmtrafficpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cs.csvserver_appfwpolicy_binding[] csvserver_appfwpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.cs.csvserver_appfwpolicy_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cs.csvserver_auditnslogpolicy_binding[] csvserver_auditnslogpolicy_binding
    {
      get => this.csvserver_auditnslogpolicy_bindingField;
      private set => this.csvserver_auditnslogpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cs.csvserver_tmtrafficpolicy_binding[] csvserver_tmtrafficpolicy_binding
    {
      get => this.csvserver_tmtrafficpolicy_bindingField;
      private set => this.csvserver_tmtrafficpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cs.csvserver_lbvserver_binding[] csvserver_lbvserver_binding
    {
      get => this.csvserver_lbvserver_bindingField;
      private set => this.csvserver_lbvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cs.csvserver_responderpolicy_binding[] csvserver_responderpolicy_binding
    {
      get => this.csvserver_responderpolicy_bindingField;
      private set => this.csvserver_responderpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cs.csvserver_gslbvserver_binding[] csvserver_gslbvserver_binding
    {
      get => this.csvserver_gslbvserver_bindingField;
      private set => this.csvserver_gslbvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cs.csvserver_cachepolicy_binding[] csvserver_cachepolicy_binding
    {
      get => this.csvserver_cachepolicy_bindingField;
      private set => this.csvserver_cachepolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cs.csvserver_filterpolicy_binding[] csvserver_filterpolicy_binding
    {
      get => this.csvserver_filterpolicy_bindingField;
      private set => this.csvserver_filterpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cs.csvserver_transformpolicy_binding[] csvserver_transformpolicy_binding
    {
      get => this.csvserver_transformpolicy_bindingField;
      private set => this.csvserver_transformpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cs.csvserver_appflowpolicy_binding[] csvserver_appflowpolicy_binding
    {
      get => this.csvserver_appflowpolicy_bindingField;
      private set => this.csvserver_appflowpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cs.csvserver_appfwpolicy_binding[] csvserver_appfwpolicy_binding
    {
      get => this.csvserver_appfwpolicy_bindingField;
      private set => this.csvserver_appfwpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cs.csvserver_authorizationpolicy_binding[] csvserver_authorizationpolicy_binding
    {
      get => this.csvserver_authorizationpolicy_bindingField;
      private set => this.csvserver_authorizationpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cs.csvserver_auditsyslogpolicy_binding[] csvserver_auditsyslogpolicy_binding
    {
      get => this.csvserver_auditsyslogpolicy_bindingField;
      private set => this.csvserver_auditsyslogpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cs.csvserver_cmppolicy_binding[] csvserver_cmppolicy_binding
    {
      get => this.csvserver_cmppolicy_bindingField;
      private set => this.csvserver_cmppolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cs.csvserver_rewritepolicy_binding[] csvserver_rewritepolicy_binding
    {
      get => this.csvserver_rewritepolicy_bindingField;
      private set => this.csvserver_rewritepolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cs.csvserver_spilloverpolicy_binding[] csvserver_spilloverpolicy_binding
    {
      get => this.csvserver_spilloverpolicy_bindingField;
      private set => this.csvserver_spilloverpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cs.csvserver_cspolicy_binding[] csvserver_cspolicy_binding
    {
      get => this.csvserver_cspolicy_bindingField;
      private set => this.csvserver_cspolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cs.csvserver_feopolicy_binding[] csvserver_feopolicy_binding
    {
      get => this.csvserver_feopolicy_bindingField;
      private set => this.csvserver_feopolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cs.csvserver_vpnvserver_binding[] csvserver_vpnvserver_binding
    {
      get => this.csvserver_vpnvserver_bindingField;
      private set => this.csvserver_vpnvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cs.csvserver_domain_binding[] csvserver_domain_binding
    {
      get => this.csvserver_domain_bindingField;
      private set => this.csvserver_domain_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      csvserver_binding.csvserver_binding_response csvserverBindingResponse = new csvserver_binding.csvserver_binding_response();
      csvserver_binding.csvserver_binding_response resource = (csvserver_binding.csvserver_binding_response) service.get_payload_formatter().string_to_resource(csvserverBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.csvserver_binding;
    }

    internal override string get_object_name() => this.name;

    public static csvserver_binding get(nitro_service service, string name) => (csvserver_binding) new csvserver_binding()
    {
      name = name
    }.get_resource(service);

    public static csvserver_binding[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (csvserver_binding[]) null;
      csvserver_binding[] csvserverBindingArray1 = new csvserver_binding[name.Length];
      csvserver_binding[] csvserverBindingArray2 = new csvserver_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        csvserverBindingArray2[index] = new csvserver_binding();
        csvserverBindingArray2[index].name = name[index];
        csvserverBindingArray1[index] = (csvserver_binding) csvserverBindingArray2[index].get_resource(service);
      }
      return csvserverBindingArray1;
    }

    private class csvserver_binding_response : base_response
    {
      public csvserver_binding[] csvserver_binding = (csvserver_binding[]) null;
    }
  }
}
