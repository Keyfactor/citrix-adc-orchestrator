// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cr.crvserver_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.cr
{
  public class crvserver_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.cr.crvserver_cmppolicy_binding[] crvserver_cmppolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.cr.crvserver_cmppolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cr.crvserver_lbvserver_binding[] crvserver_lbvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.cr.crvserver_lbvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cr.crvserver_rewritepolicy_binding[] crvserver_rewritepolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.cr.crvserver_rewritepolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cr.crvserver_cspolicy_binding[] crvserver_cspolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.cr.crvserver_cspolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cr.crvserver_appfwpolicy_binding[] crvserver_appfwpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.cr.crvserver_appfwpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cr.crvserver_crpolicy_binding[] crvserver_crpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.cr.crvserver_crpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cr.crvserver_spilloverpolicy_binding[] crvserver_spilloverpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.cr.crvserver_spilloverpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cr.crvserver_filterpolicy_binding[] crvserver_filterpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.cr.crvserver_filterpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cr.crvserver_icapolicy_binding[] crvserver_icapolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.cr.crvserver_icapolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cr.crvserver_appflowpolicy_binding[] crvserver_appflowpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.cr.crvserver_appflowpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cr.crvserver_responderpolicy_binding[] crvserver_responderpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.cr.crvserver_responderpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cr.crvserver_policymap_binding[] crvserver_policymap_bindingField = (com.citrix.netscaler.nitro.resource.config.cr.crvserver_policymap_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cr.crvserver_feopolicy_binding[] crvserver_feopolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.cr.crvserver_feopolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cr.crvserver_cachepolicy_binding[] crvserver_cachepolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.cr.crvserver_cachepolicy_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cr.crvserver_spilloverpolicy_binding[] crvserver_spilloverpolicy_binding
    {
      get => this.crvserver_spilloverpolicy_bindingField;
      private set => this.crvserver_spilloverpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cr.crvserver_policymap_binding[] crvserver_policymap_binding
    {
      get => this.crvserver_policymap_bindingField;
      private set => this.crvserver_policymap_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cr.crvserver_cachepolicy_binding[] crvserver_cachepolicy_binding
    {
      get => this.crvserver_cachepolicy_bindingField;
      private set => this.crvserver_cachepolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cr.crvserver_lbvserver_binding[] crvserver_lbvserver_binding
    {
      get => this.crvserver_lbvserver_bindingField;
      private set => this.crvserver_lbvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cr.crvserver_appfwpolicy_binding[] crvserver_appfwpolicy_binding
    {
      get => this.crvserver_appfwpolicy_bindingField;
      private set => this.crvserver_appfwpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cr.crvserver_filterpolicy_binding[] crvserver_filterpolicy_binding
    {
      get => this.crvserver_filterpolicy_bindingField;
      private set => this.crvserver_filterpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cr.crvserver_cmppolicy_binding[] crvserver_cmppolicy_binding
    {
      get => this.crvserver_cmppolicy_bindingField;
      private set => this.crvserver_cmppolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cr.crvserver_appflowpolicy_binding[] crvserver_appflowpolicy_binding
    {
      get => this.crvserver_appflowpolicy_bindingField;
      private set => this.crvserver_appflowpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cr.crvserver_icapolicy_binding[] crvserver_icapolicy_binding
    {
      get => this.crvserver_icapolicy_bindingField;
      private set => this.crvserver_icapolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cr.crvserver_responderpolicy_binding[] crvserver_responderpolicy_binding
    {
      get => this.crvserver_responderpolicy_bindingField;
      private set => this.crvserver_responderpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cr.crvserver_feopolicy_binding[] crvserver_feopolicy_binding
    {
      get => this.crvserver_feopolicy_bindingField;
      private set => this.crvserver_feopolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cr.crvserver_cspolicy_binding[] crvserver_cspolicy_binding
    {
      get => this.crvserver_cspolicy_bindingField;
      private set => this.crvserver_cspolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cr.crvserver_crpolicy_binding[] crvserver_crpolicy_binding
    {
      get => this.crvserver_crpolicy_bindingField;
      private set => this.crvserver_crpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cr.crvserver_rewritepolicy_binding[] crvserver_rewritepolicy_binding
    {
      get => this.crvserver_rewritepolicy_bindingField;
      private set => this.crvserver_rewritepolicy_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      crvserver_binding.crvserver_binding_response crvserverBindingResponse = new crvserver_binding.crvserver_binding_response();
      crvserver_binding.crvserver_binding_response resource = (crvserver_binding.crvserver_binding_response) service.get_payload_formatter().string_to_resource(crvserverBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.crvserver_binding;
    }

    internal override string get_object_name() => this.name;

    public static crvserver_binding get(nitro_service service, string name) => (crvserver_binding) new crvserver_binding()
    {
      name = name
    }.get_resource(service);

    public static crvserver_binding[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (crvserver_binding[]) null;
      crvserver_binding[] crvserverBindingArray1 = new crvserver_binding[name.Length];
      crvserver_binding[] crvserverBindingArray2 = new crvserver_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        crvserverBindingArray2[index] = new crvserver_binding();
        crvserverBindingArray2[index].name = name[index];
        crvserverBindingArray1[index] = (crvserver_binding) crvserverBindingArray2[index].get_resource(service);
      }
      return crvserverBindingArray1;
    }

    private class crvserver_binding_response : base_response
    {
      public crvserver_binding[] crvserver_binding = (crvserver_binding[]) null;
    }
  }
}
