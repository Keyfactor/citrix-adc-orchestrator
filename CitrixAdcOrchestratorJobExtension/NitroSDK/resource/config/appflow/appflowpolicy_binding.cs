// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.appflow.appflowpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.appflow
{
  public class appflowpolicy_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.appflow.appflowpolicy_csvserver_binding[] appflowpolicy_csvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.appflow.appflowpolicy_csvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.appflow.appflowpolicy_lbvserver_binding[] appflowpolicy_lbvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.appflow.appflowpolicy_lbvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.appflow.appflowpolicy_appflowglobal_binding[] appflowpolicy_appflowglobal_bindingField = (com.citrix.netscaler.nitro.resource.config.appflow.appflowpolicy_appflowglobal_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.appflow.appflowpolicy_vpnvserver_binding[] appflowpolicy_vpnvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.appflow.appflowpolicy_vpnvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.appflow.appflowpolicy_appflowpolicylabel_binding[] appflowpolicy_appflowpolicylabel_bindingField = (com.citrix.netscaler.nitro.resource.config.appflow.appflowpolicy_appflowpolicylabel_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.appflow.appflowpolicy_appflowpolicylabel_binding[] appflowpolicy_appflowpolicylabel_binding
    {
      get => this.appflowpolicy_appflowpolicylabel_bindingField;
      private set => this.appflowpolicy_appflowpolicylabel_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.appflow.appflowpolicy_csvserver_binding[] appflowpolicy_csvserver_binding
    {
      get => this.appflowpolicy_csvserver_bindingField;
      private set => this.appflowpolicy_csvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.appflow.appflowpolicy_vpnvserver_binding[] appflowpolicy_vpnvserver_binding
    {
      get => this.appflowpolicy_vpnvserver_bindingField;
      private set => this.appflowpolicy_vpnvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.appflow.appflowpolicy_lbvserver_binding[] appflowpolicy_lbvserver_binding
    {
      get => this.appflowpolicy_lbvserver_bindingField;
      private set => this.appflowpolicy_lbvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.appflow.appflowpolicy_appflowglobal_binding[] appflowpolicy_appflowglobal_binding
    {
      get => this.appflowpolicy_appflowglobal_bindingField;
      private set => this.appflowpolicy_appflowglobal_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      appflowpolicy_binding.appflowpolicy_binding_response appflowpolicyBindingResponse = new appflowpolicy_binding.appflowpolicy_binding_response();
      appflowpolicy_binding.appflowpolicy_binding_response resource = (appflowpolicy_binding.appflowpolicy_binding_response) service.get_payload_formatter().string_to_resource(appflowpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.appflowpolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static appflowpolicy_binding get(nitro_service service, string name) => (appflowpolicy_binding) new appflowpolicy_binding()
    {
      name = name
    }.get_resource(service);

    public static appflowpolicy_binding[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (appflowpolicy_binding[]) null;
      appflowpolicy_binding[] appflowpolicyBindingArray1 = new appflowpolicy_binding[name.Length];
      appflowpolicy_binding[] appflowpolicyBindingArray2 = new appflowpolicy_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        appflowpolicyBindingArray2[index] = new appflowpolicy_binding();
        appflowpolicyBindingArray2[index].name = name[index];
        appflowpolicyBindingArray1[index] = (appflowpolicy_binding) appflowpolicyBindingArray2[index].get_resource(service);
      }
      return appflowpolicyBindingArray1;
    }

    private class appflowpolicy_binding_response : base_response
    {
      public appflowpolicy_binding[] appflowpolicy_binding = (appflowpolicy_binding[]) null;
    }
  }
}
