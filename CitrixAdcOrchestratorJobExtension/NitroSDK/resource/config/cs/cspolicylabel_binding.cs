// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cs.cspolicylabel_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.cs
{
  public class cspolicylabel_binding : base_resource
  {
    private string labelnameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.cs.cspolicylabel_cspolicy_binding[] cspolicylabel_cspolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.cs.cspolicylabel_cspolicy_binding[]) null;

    public string labelname
    {
      get => this.labelnameField;
      set => this.labelnameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cs.cspolicylabel_cspolicy_binding[] cspolicylabel_cspolicy_binding
    {
      get => this.cspolicylabel_cspolicy_bindingField;
      private set => this.cspolicylabel_cspolicy_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      cspolicylabel_binding.cspolicylabel_binding_response cspolicylabelBindingResponse = new cspolicylabel_binding.cspolicylabel_binding_response();
      cspolicylabel_binding.cspolicylabel_binding_response resource = (cspolicylabel_binding.cspolicylabel_binding_response) service.get_payload_formatter().string_to_resource(cspolicylabelBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.cspolicylabel_binding;
    }

    internal override string get_object_name() => this.labelname;

    public static cspolicylabel_binding get(
      nitro_service service,
      string labelname)
    {
      return (cspolicylabel_binding) new cspolicylabel_binding()
      {
        labelname = labelname
      }.get_resource(service);
    }

    public static cspolicylabel_binding[] get(
      nitro_service service,
      string[] labelname)
    {
      if (labelname == null || labelname.Length <= 0)
        return (cspolicylabel_binding[]) null;
      cspolicylabel_binding[] cspolicylabelBindingArray1 = new cspolicylabel_binding[labelname.Length];
      cspolicylabel_binding[] cspolicylabelBindingArray2 = new cspolicylabel_binding[labelname.Length];
      for (int index = 0; index < labelname.Length; ++index)
      {
        cspolicylabelBindingArray2[index] = new cspolicylabel_binding();
        cspolicylabelBindingArray2[index].labelname = labelname[index];
        cspolicylabelBindingArray1[index] = (cspolicylabel_binding) cspolicylabelBindingArray2[index].get_resource(service);
      }
      return cspolicylabelBindingArray1;
    }

    private class cspolicylabel_binding_response : base_response
    {
      public cspolicylabel_binding[] cspolicylabel_binding = (cspolicylabel_binding[]) null;
    }
  }
}
