// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.appfw.appfwpolicylabel_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.appfw
{
  public class appfwpolicylabel_binding : base_resource
  {
    private string labelnameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.appfw.appfwpolicylabel_policybinding_binding[] appfwpolicylabel_policybinding_bindingField = (com.citrix.netscaler.nitro.resource.config.appfw.appfwpolicylabel_policybinding_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.appfw.appfwpolicylabel_appfwpolicy_binding[] appfwpolicylabel_appfwpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.appfw.appfwpolicylabel_appfwpolicy_binding[]) null;

    public string labelname
    {
      get => this.labelnameField;
      set => this.labelnameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.appfw.appfwpolicylabel_policybinding_binding[] appfwpolicylabel_policybinding_binding
    {
      get => this.appfwpolicylabel_policybinding_bindingField;
      private set => this.appfwpolicylabel_policybinding_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.appfw.appfwpolicylabel_appfwpolicy_binding[] appfwpolicylabel_appfwpolicy_binding
    {
      get => this.appfwpolicylabel_appfwpolicy_bindingField;
      private set => this.appfwpolicylabel_appfwpolicy_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      appfwpolicylabel_binding.appfwpolicylabel_binding_response appfwpolicylabelBindingResponse = new appfwpolicylabel_binding.appfwpolicylabel_binding_response();
      appfwpolicylabel_binding.appfwpolicylabel_binding_response resource = (appfwpolicylabel_binding.appfwpolicylabel_binding_response) service.get_payload_formatter().string_to_resource(appfwpolicylabelBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.appfwpolicylabel_binding;
    }

    internal override string get_object_name() => this.labelname;

    public static appfwpolicylabel_binding get(
      nitro_service service,
      string labelname)
    {
      return (appfwpolicylabel_binding) new appfwpolicylabel_binding()
      {
        labelname = labelname
      }.get_resource(service);
    }

    public static appfwpolicylabel_binding[] get(
      nitro_service service,
      string[] labelname)
    {
      if (labelname == null || labelname.Length <= 0)
        return (appfwpolicylabel_binding[]) null;
      appfwpolicylabel_binding[] appfwpolicylabelBindingArray1 = new appfwpolicylabel_binding[labelname.Length];
      appfwpolicylabel_binding[] appfwpolicylabelBindingArray2 = new appfwpolicylabel_binding[labelname.Length];
      for (int index = 0; index < labelname.Length; ++index)
      {
        appfwpolicylabelBindingArray2[index] = new appfwpolicylabel_binding();
        appfwpolicylabelBindingArray2[index].labelname = labelname[index];
        appfwpolicylabelBindingArray1[index] = (appfwpolicylabel_binding) appfwpolicylabelBindingArray2[index].get_resource(service);
      }
      return appfwpolicylabelBindingArray1;
    }

    private class appfwpolicylabel_binding_response : base_response
    {
      public appfwpolicylabel_binding[] appfwpolicylabel_binding = (appfwpolicylabel_binding[]) null;
    }
  }
}
