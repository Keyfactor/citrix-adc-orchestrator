// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslpolicylabel_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslpolicylabel_binding : base_resource
  {
    private string labelnameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.ssl.sslpolicylabel_sslpolicy_binding[] sslpolicylabel_sslpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.ssl.sslpolicylabel_sslpolicy_binding[]) null;

    public string labelname
    {
      get => this.labelnameField;
      set => this.labelnameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ssl.sslpolicylabel_sslpolicy_binding[] sslpolicylabel_sslpolicy_binding
    {
      get => this.sslpolicylabel_sslpolicy_bindingField;
      private set => this.sslpolicylabel_sslpolicy_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslpolicylabel_binding.sslpolicylabel_binding_response sslpolicylabelBindingResponse = new sslpolicylabel_binding.sslpolicylabel_binding_response();
      sslpolicylabel_binding.sslpolicylabel_binding_response resource = (sslpolicylabel_binding.sslpolicylabel_binding_response) service.get_payload_formatter().string_to_resource(sslpolicylabelBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslpolicylabel_binding;
    }

    internal override string get_object_name() => this.labelname;

    public static sslpolicylabel_binding get(
      nitro_service service,
      string labelname)
    {
      return (sslpolicylabel_binding) new sslpolicylabel_binding()
      {
        labelname = labelname
      }.get_resource(service);
    }

    public static sslpolicylabel_binding[] get(
      nitro_service service,
      string[] labelname)
    {
      if (labelname == null || labelname.Length <= 0)
        return (sslpolicylabel_binding[]) null;
      sslpolicylabel_binding[] sslpolicylabelBindingArray1 = new sslpolicylabel_binding[labelname.Length];
      sslpolicylabel_binding[] sslpolicylabelBindingArray2 = new sslpolicylabel_binding[labelname.Length];
      for (int index = 0; index < labelname.Length; ++index)
      {
        sslpolicylabelBindingArray2[index] = new sslpolicylabel_binding();
        sslpolicylabelBindingArray2[index].labelname = labelname[index];
        sslpolicylabelBindingArray1[index] = (sslpolicylabel_binding) sslpolicylabelBindingArray2[index].get_resource(service);
      }
      return sslpolicylabelBindingArray1;
    }

    private class sslpolicylabel_binding_response : base_response
    {
      public sslpolicylabel_binding[] sslpolicylabel_binding = (sslpolicylabel_binding[]) null;
    }
  }
}
