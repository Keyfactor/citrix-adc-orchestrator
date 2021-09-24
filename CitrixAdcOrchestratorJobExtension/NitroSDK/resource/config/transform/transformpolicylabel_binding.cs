// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.transform.transformpolicylabel_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.transform
{
  public class transformpolicylabel_binding : base_resource
  {
    private string labelnameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.transform.transformpolicylabel_policybinding_binding[] transformpolicylabel_policybinding_bindingField = (com.citrix.netscaler.nitro.resource.config.transform.transformpolicylabel_policybinding_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.transform.transformpolicylabel_transformpolicy_binding[] transformpolicylabel_transformpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.transform.transformpolicylabel_transformpolicy_binding[]) null;

    public string labelname
    {
      get => this.labelnameField;
      set => this.labelnameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.transform.transformpolicylabel_policybinding_binding[] transformpolicylabel_policybinding_binding
    {
      get => this.transformpolicylabel_policybinding_bindingField;
      private set => this.transformpolicylabel_policybinding_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.transform.transformpolicylabel_transformpolicy_binding[] transformpolicylabel_transformpolicy_binding
    {
      get => this.transformpolicylabel_transformpolicy_bindingField;
      private set => this.transformpolicylabel_transformpolicy_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      transformpolicylabel_binding.transformpolicylabel_binding_response transformpolicylabelBindingResponse = new transformpolicylabel_binding.transformpolicylabel_binding_response();
      transformpolicylabel_binding.transformpolicylabel_binding_response resource = (transformpolicylabel_binding.transformpolicylabel_binding_response) service.get_payload_formatter().string_to_resource(transformpolicylabelBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.transformpolicylabel_binding;
    }

    internal override string get_object_name() => this.labelname;

    public static transformpolicylabel_binding get(
      nitro_service service,
      string labelname)
    {
      return (transformpolicylabel_binding) new transformpolicylabel_binding()
      {
        labelname = labelname
      }.get_resource(service);
    }

    public static transformpolicylabel_binding[] get(
      nitro_service service,
      string[] labelname)
    {
      if (labelname == null || labelname.Length <= 0)
        return (transformpolicylabel_binding[]) null;
      transformpolicylabel_binding[] transformpolicylabelBindingArray1 = new transformpolicylabel_binding[labelname.Length];
      transformpolicylabel_binding[] transformpolicylabelBindingArray2 = new transformpolicylabel_binding[labelname.Length];
      for (int index = 0; index < labelname.Length; ++index)
      {
        transformpolicylabelBindingArray2[index] = new transformpolicylabel_binding();
        transformpolicylabelBindingArray2[index].labelname = labelname[index];
        transformpolicylabelBindingArray1[index] = (transformpolicylabel_binding) transformpolicylabelBindingArray2[index].get_resource(service);
      }
      return transformpolicylabelBindingArray1;
    }

    private class transformpolicylabel_binding_response : base_response
    {
      public transformpolicylabel_binding[] transformpolicylabel_binding = (transformpolicylabel_binding[]) null;
    }
  }
}
