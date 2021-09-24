// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.appflow.appflowpolicylabel_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.appflow
{
  public class appflowpolicylabel_binding : base_resource
  {
    private string labelnameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.appflow.appflowpolicylabel_appflowpolicy_binding[] appflowpolicylabel_appflowpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.appflow.appflowpolicylabel_appflowpolicy_binding[]) null;

    public string labelname
    {
      get => this.labelnameField;
      set => this.labelnameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.appflow.appflowpolicylabel_appflowpolicy_binding[] appflowpolicylabel_appflowpolicy_binding
    {
      get => this.appflowpolicylabel_appflowpolicy_bindingField;
      private set => this.appflowpolicylabel_appflowpolicy_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      appflowpolicylabel_binding.appflowpolicylabel_binding_response appflowpolicylabelBindingResponse = new appflowpolicylabel_binding.appflowpolicylabel_binding_response();
      appflowpolicylabel_binding.appflowpolicylabel_binding_response resource = (appflowpolicylabel_binding.appflowpolicylabel_binding_response) service.get_payload_formatter().string_to_resource(appflowpolicylabelBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.appflowpolicylabel_binding;
    }

    internal override string get_object_name() => this.labelname;

    public static appflowpolicylabel_binding get(
      nitro_service service,
      string labelname)
    {
      return (appflowpolicylabel_binding) new appflowpolicylabel_binding()
      {
        labelname = labelname
      }.get_resource(service);
    }

    public static appflowpolicylabel_binding[] get(
      nitro_service service,
      string[] labelname)
    {
      if (labelname == null || labelname.Length <= 0)
        return (appflowpolicylabel_binding[]) null;
      appflowpolicylabel_binding[] appflowpolicylabelBindingArray1 = new appflowpolicylabel_binding[labelname.Length];
      appflowpolicylabel_binding[] appflowpolicylabelBindingArray2 = new appflowpolicylabel_binding[labelname.Length];
      for (int index = 0; index < labelname.Length; ++index)
      {
        appflowpolicylabelBindingArray2[index] = new appflowpolicylabel_binding();
        appflowpolicylabelBindingArray2[index].labelname = labelname[index];
        appflowpolicylabelBindingArray1[index] = (appflowpolicylabel_binding) appflowpolicylabelBindingArray2[index].get_resource(service);
      }
      return appflowpolicylabelBindingArray1;
    }

    private class appflowpolicylabel_binding_response : base_response
    {
      public appflowpolicylabel_binding[] appflowpolicylabel_binding = (appflowpolicylabel_binding[]) null;
    }
  }
}
