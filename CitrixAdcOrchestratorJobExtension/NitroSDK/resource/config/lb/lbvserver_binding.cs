// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lb.lbvserver_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.lb
{
  public class lbvserver_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.lb.lbvserver_cmppolicy_binding[] lbvserver_cmppolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.lb.lbvserver_cmppolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.lb.lbvserver_authorizationpolicy_binding[] lbvserver_authorizationpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.lb.lbvserver_authorizationpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.lb.lbvserver_rewritepolicy_binding[] lbvserver_rewritepolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.lb.lbvserver_rewritepolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.lb.lbvserver_pqpolicy_binding[] lbvserver_pqpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.lb.lbvserver_pqpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.lb.lbvserver_service_binding[] lbvserver_service_bindingField = (com.citrix.netscaler.nitro.resource.config.lb.lbvserver_service_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.lb.lbvserver_tmtrafficpolicy_binding[] lbvserver_tmtrafficpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.lb.lbvserver_tmtrafficpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.lb.lbvserver_auditsyslogpolicy_binding[] lbvserver_auditsyslogpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.lb.lbvserver_auditsyslogpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.lb.lbvserver_appfwpolicy_binding[] lbvserver_appfwpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.lb.lbvserver_appfwpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.lb.lbvserver_spilloverpolicy_binding[] lbvserver_spilloverpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.lb.lbvserver_spilloverpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.lb.lbvserver_csvserver_binding[] lbvserver_csvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.lb.lbvserver_csvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.lb.lbvserver_capolicy_binding[] lbvserver_capolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.lb.lbvserver_capolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.lb.lbvserver_auditnslogpolicy_binding[] lbvserver_auditnslogpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.lb.lbvserver_auditnslogpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.lb.lbvserver_filterpolicy_binding[] lbvserver_filterpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.lb.lbvserver_filterpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.lb.lbvserver_appflowpolicy_binding[] lbvserver_appflowpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.lb.lbvserver_appflowpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.lb.lbvserver_responderpolicy_binding[] lbvserver_responderpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.lb.lbvserver_responderpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.lb.lbvserver_transformpolicy_binding[] lbvserver_transformpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.lb.lbvserver_transformpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.lb.lbvserver_dospolicy_binding[] lbvserver_dospolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.lb.lbvserver_dospolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.lb.lbvserver_feopolicy_binding[] lbvserver_feopolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.lb.lbvserver_feopolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.lb.lbvserver_servicegroupmember_binding[] lbvserver_servicegroupmember_bindingField = (com.citrix.netscaler.nitro.resource.config.lb.lbvserver_servicegroupmember_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.lb.lbvserver_dnspolicy64_binding[] lbvserver_dnspolicy64_bindingField = (com.citrix.netscaler.nitro.resource.config.lb.lbvserver_dnspolicy64_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.lb.lbvserver_cachepolicy_binding[] lbvserver_cachepolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.lb.lbvserver_cachepolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.lb.lbvserver_scpolicy_binding[] lbvserver_scpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.lb.lbvserver_scpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.lb.lbvserver_servicegroup_binding[] lbvserver_servicegroup_bindingField = (com.citrix.netscaler.nitro.resource.config.lb.lbvserver_servicegroup_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.lb.lbvserver_appqoepolicy_binding[] lbvserver_appqoepolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.lb.lbvserver_appqoepolicy_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lb.lbvserver_appfwpolicy_binding[] lbvserver_appfwpolicy_binding
    {
      get => this.lbvserver_appfwpolicy_bindingField;
      private set => this.lbvserver_appfwpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lb.lbvserver_spilloverpolicy_binding[] lbvserver_spilloverpolicy_binding
    {
      get => this.lbvserver_spilloverpolicy_bindingField;
      private set => this.lbvserver_spilloverpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lb.lbvserver_appqoepolicy_binding[] lbvserver_appqoepolicy_binding
    {
      get => this.lbvserver_appqoepolicy_bindingField;
      private set => this.lbvserver_appqoepolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lb.lbvserver_feopolicy_binding[] lbvserver_feopolicy_binding
    {
      get => this.lbvserver_feopolicy_bindingField;
      private set => this.lbvserver_feopolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lb.lbvserver_csvserver_binding[] lbvserver_csvserver_binding
    {
      get => this.lbvserver_csvserver_bindingField;
      private set => this.lbvserver_csvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lb.lbvserver_capolicy_binding[] lbvserver_capolicy_binding
    {
      get => this.lbvserver_capolicy_bindingField;
      private set => this.lbvserver_capolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lb.lbvserver_authorizationpolicy_binding[] lbvserver_authorizationpolicy_binding
    {
      get => this.lbvserver_authorizationpolicy_bindingField;
      private set => this.lbvserver_authorizationpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lb.lbvserver_servicegroupmember_binding[] lbvserver_servicegroupmember_binding
    {
      get => this.lbvserver_servicegroupmember_bindingField;
      private set => this.lbvserver_servicegroupmember_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lb.lbvserver_dospolicy_binding[] lbvserver_dospolicy_binding
    {
      get => this.lbvserver_dospolicy_bindingField;
      private set => this.lbvserver_dospolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lb.lbvserver_tmtrafficpolicy_binding[] lbvserver_tmtrafficpolicy_binding
    {
      get => this.lbvserver_tmtrafficpolicy_bindingField;
      private set => this.lbvserver_tmtrafficpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lb.lbvserver_cmppolicy_binding[] lbvserver_cmppolicy_binding
    {
      get => this.lbvserver_cmppolicy_bindingField;
      private set => this.lbvserver_cmppolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lb.lbvserver_auditsyslogpolicy_binding[] lbvserver_auditsyslogpolicy_binding
    {
      get => this.lbvserver_auditsyslogpolicy_bindingField;
      private set => this.lbvserver_auditsyslogpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lb.lbvserver_pqpolicy_binding[] lbvserver_pqpolicy_binding
    {
      get => this.lbvserver_pqpolicy_bindingField;
      private set => this.lbvserver_pqpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lb.lbvserver_dnspolicy64_binding[] lbvserver_dnspolicy64_binding
    {
      get => this.lbvserver_dnspolicy64_bindingField;
      private set => this.lbvserver_dnspolicy64_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lb.lbvserver_rewritepolicy_binding[] lbvserver_rewritepolicy_binding
    {
      get => this.lbvserver_rewritepolicy_bindingField;
      private set => this.lbvserver_rewritepolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lb.lbvserver_auditnslogpolicy_binding[] lbvserver_auditnslogpolicy_binding
    {
      get => this.lbvserver_auditnslogpolicy_bindingField;
      private set => this.lbvserver_auditnslogpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lb.lbvserver_transformpolicy_binding[] lbvserver_transformpolicy_binding
    {
      get => this.lbvserver_transformpolicy_bindingField;
      private set => this.lbvserver_transformpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lb.lbvserver_filterpolicy_binding[] lbvserver_filterpolicy_binding
    {
      get => this.lbvserver_filterpolicy_bindingField;
      private set => this.lbvserver_filterpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lb.lbvserver_scpolicy_binding[] lbvserver_scpolicy_binding
    {
      get => this.lbvserver_scpolicy_bindingField;
      private set => this.lbvserver_scpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lb.lbvserver_appflowpolicy_binding[] lbvserver_appflowpolicy_binding
    {
      get => this.lbvserver_appflowpolicy_bindingField;
      private set => this.lbvserver_appflowpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lb.lbvserver_servicegroup_binding[] lbvserver_servicegroup_binding
    {
      get => this.lbvserver_servicegroup_bindingField;
      private set => this.lbvserver_servicegroup_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lb.lbvserver_cachepolicy_binding[] lbvserver_cachepolicy_binding
    {
      get => this.lbvserver_cachepolicy_bindingField;
      private set => this.lbvserver_cachepolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lb.lbvserver_service_binding[] lbvserver_service_binding
    {
      get => this.lbvserver_service_bindingField;
      private set => this.lbvserver_service_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lb.lbvserver_responderpolicy_binding[] lbvserver_responderpolicy_binding
    {
      get => this.lbvserver_responderpolicy_bindingField;
      private set => this.lbvserver_responderpolicy_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lbvserver_binding.lbvserver_binding_response lbvserverBindingResponse = new lbvserver_binding.lbvserver_binding_response();
      lbvserver_binding.lbvserver_binding_response resource = (lbvserver_binding.lbvserver_binding_response) service.get_payload_formatter().string_to_resource(lbvserverBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lbvserver_binding;
    }

    internal override string get_object_name() => this.name;

    public static lbvserver_binding get(nitro_service service, string name) => (lbvserver_binding) new lbvserver_binding()
    {
      name = name
    }.get_resource(service);

    public static lbvserver_binding[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (lbvserver_binding[]) null;
      lbvserver_binding[] lbvserverBindingArray1 = new lbvserver_binding[name.Length];
      lbvserver_binding[] lbvserverBindingArray2 = new lbvserver_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        lbvserverBindingArray2[index] = new lbvserver_binding();
        lbvserverBindingArray2[index].name = name[index];
        lbvserverBindingArray1[index] = (lbvserver_binding) lbvserverBindingArray2[index].get_resource(service);
      }
      return lbvserverBindingArray1;
    }

    private class lbvserver_binding_response : base_response
    {
      public lbvserver_binding[] lbvserver_binding = (lbvserver_binding[]) null;
    }
  }
}
