// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.appfw.appfwpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.appfw
{
  public class appfwpolicy_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.appfw.appfwpolicy_appfwglobal_binding[] appfwpolicy_appfwglobal_bindingField = (com.citrix.netscaler.nitro.resource.config.appfw.appfwpolicy_appfwglobal_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.appfw.appfwpolicy_lbvserver_binding[] appfwpolicy_lbvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.appfw.appfwpolicy_lbvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.appfw.appfwpolicy_csvserver_binding[] appfwpolicy_csvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.appfw.appfwpolicy_csvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.appfw.appfwpolicy_appfwpolicylabel_binding[] appfwpolicy_appfwpolicylabel_bindingField = (com.citrix.netscaler.nitro.resource.config.appfw.appfwpolicy_appfwpolicylabel_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.appfw.appfwpolicy_appfwpolicylabel_binding[] appfwpolicy_appfwpolicylabel_binding
    {
      get => this.appfwpolicy_appfwpolicylabel_bindingField;
      private set => this.appfwpolicy_appfwpolicylabel_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.appfw.appfwpolicy_csvserver_binding[] appfwpolicy_csvserver_binding
    {
      get => this.appfwpolicy_csvserver_bindingField;
      private set => this.appfwpolicy_csvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.appfw.appfwpolicy_appfwglobal_binding[] appfwpolicy_appfwglobal_binding
    {
      get => this.appfwpolicy_appfwglobal_bindingField;
      private set => this.appfwpolicy_appfwglobal_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.appfw.appfwpolicy_lbvserver_binding[] appfwpolicy_lbvserver_binding
    {
      get => this.appfwpolicy_lbvserver_bindingField;
      private set => this.appfwpolicy_lbvserver_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      appfwpolicy_binding.appfwpolicy_binding_response appfwpolicyBindingResponse = new appfwpolicy_binding.appfwpolicy_binding_response();
      appfwpolicy_binding.appfwpolicy_binding_response resource = (appfwpolicy_binding.appfwpolicy_binding_response) service.get_payload_formatter().string_to_resource(appfwpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.appfwpolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static appfwpolicy_binding get(nitro_service service, string name) => (appfwpolicy_binding) new appfwpolicy_binding()
    {
      name = name
    }.get_resource(service);

    public static appfwpolicy_binding[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (appfwpolicy_binding[]) null;
      appfwpolicy_binding[] appfwpolicyBindingArray1 = new appfwpolicy_binding[name.Length];
      appfwpolicy_binding[] appfwpolicyBindingArray2 = new appfwpolicy_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        appfwpolicyBindingArray2[index] = new appfwpolicy_binding();
        appfwpolicyBindingArray2[index].name = name[index];
        appfwpolicyBindingArray1[index] = (appfwpolicy_binding) appfwpolicyBindingArray2[index].get_resource(service);
      }
      return appfwpolicyBindingArray1;
    }

    private class appfwpolicy_binding_response : base_response
    {
      public appfwpolicy_binding[] appfwpolicy_binding = (appfwpolicy_binding[]) null;
    }
  }
}
