// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cmp.cmppolicylabel_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.cmp
{
  public class cmppolicylabel_binding : base_resource
  {
    private string labelnameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.cmp.cmppolicylabel_cmppolicy_binding[] cmppolicylabel_cmppolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.cmp.cmppolicylabel_cmppolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cmp.cmppolicylabel_policybinding_binding[] cmppolicylabel_policybinding_bindingField = (com.citrix.netscaler.nitro.resource.config.cmp.cmppolicylabel_policybinding_binding[]) null;

    public string labelname
    {
      get => this.labelnameField;
      set => this.labelnameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cmp.cmppolicylabel_policybinding_binding[] cmppolicylabel_policybinding_binding
    {
      get => this.cmppolicylabel_policybinding_bindingField;
      private set => this.cmppolicylabel_policybinding_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cmp.cmppolicylabel_cmppolicy_binding[] cmppolicylabel_cmppolicy_binding
    {
      get => this.cmppolicylabel_cmppolicy_bindingField;
      private set => this.cmppolicylabel_cmppolicy_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      cmppolicylabel_binding.cmppolicylabel_binding_response cmppolicylabelBindingResponse = new cmppolicylabel_binding.cmppolicylabel_binding_response();
      cmppolicylabel_binding.cmppolicylabel_binding_response resource = (cmppolicylabel_binding.cmppolicylabel_binding_response) service.get_payload_formatter().string_to_resource(cmppolicylabelBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.cmppolicylabel_binding;
    }

    internal override string get_object_name() => this.labelname;

    public static cmppolicylabel_binding get(
      nitro_service service,
      string labelname)
    {
      return (cmppolicylabel_binding) new cmppolicylabel_binding()
      {
        labelname = labelname
      }.get_resource(service);
    }

    public static cmppolicylabel_binding[] get(
      nitro_service service,
      string[] labelname)
    {
      if (labelname == null || labelname.Length <= 0)
        return (cmppolicylabel_binding[]) null;
      cmppolicylabel_binding[] cmppolicylabelBindingArray1 = new cmppolicylabel_binding[labelname.Length];
      cmppolicylabel_binding[] cmppolicylabelBindingArray2 = new cmppolicylabel_binding[labelname.Length];
      for (int index = 0; index < labelname.Length; ++index)
      {
        cmppolicylabelBindingArray2[index] = new cmppolicylabel_binding();
        cmppolicylabelBindingArray2[index].labelname = labelname[index];
        cmppolicylabelBindingArray1[index] = (cmppolicylabel_binding) cmppolicylabelBindingArray2[index].get_resource(service);
      }
      return cmppolicylabelBindingArray1;
    }

    private class cmppolicylabel_binding_response : base_response
    {
      public cmppolicylabel_binding[] cmppolicylabel_binding = (cmppolicylabel_binding[]) null;
    }
  }
}
