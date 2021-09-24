// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.rewrite.rewritepolicylabel_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.rewrite
{
  public class rewritepolicylabel_binding : base_resource
  {
    private string labelnameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.rewrite.rewritepolicylabel_policybinding_binding[] rewritepolicylabel_policybinding_bindingField = (com.citrix.netscaler.nitro.resource.config.rewrite.rewritepolicylabel_policybinding_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.rewrite.rewritepolicylabel_rewritepolicy_binding[] rewritepolicylabel_rewritepolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.rewrite.rewritepolicylabel_rewritepolicy_binding[]) null;

    public string labelname
    {
      get => this.labelnameField;
      set => this.labelnameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.rewrite.rewritepolicylabel_policybinding_binding[] rewritepolicylabel_policybinding_binding
    {
      get => this.rewritepolicylabel_policybinding_bindingField;
      private set => this.rewritepolicylabel_policybinding_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.rewrite.rewritepolicylabel_rewritepolicy_binding[] rewritepolicylabel_rewritepolicy_binding
    {
      get => this.rewritepolicylabel_rewritepolicy_bindingField;
      private set => this.rewritepolicylabel_rewritepolicy_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      rewritepolicylabel_binding.rewritepolicylabel_binding_response rewritepolicylabelBindingResponse = new rewritepolicylabel_binding.rewritepolicylabel_binding_response();
      rewritepolicylabel_binding.rewritepolicylabel_binding_response resource = (rewritepolicylabel_binding.rewritepolicylabel_binding_response) service.get_payload_formatter().string_to_resource(rewritepolicylabelBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.rewritepolicylabel_binding;
    }

    internal override string get_object_name() => this.labelname;

    public static rewritepolicylabel_binding get(
      nitro_service service,
      string labelname)
    {
      return (rewritepolicylabel_binding) new rewritepolicylabel_binding()
      {
        labelname = labelname
      }.get_resource(service);
    }

    public static rewritepolicylabel_binding[] get(
      nitro_service service,
      string[] labelname)
    {
      if (labelname == null || labelname.Length <= 0)
        return (rewritepolicylabel_binding[]) null;
      rewritepolicylabel_binding[] rewritepolicylabelBindingArray1 = new rewritepolicylabel_binding[labelname.Length];
      rewritepolicylabel_binding[] rewritepolicylabelBindingArray2 = new rewritepolicylabel_binding[labelname.Length];
      for (int index = 0; index < labelname.Length; ++index)
      {
        rewritepolicylabelBindingArray2[index] = new rewritepolicylabel_binding();
        rewritepolicylabelBindingArray2[index].labelname = labelname[index];
        rewritepolicylabelBindingArray1[index] = (rewritepolicylabel_binding) rewritepolicylabelBindingArray2[index].get_resource(service);
      }
      return rewritepolicylabelBindingArray1;
    }

    private class rewritepolicylabel_binding_response : base_response
    {
      public rewritepolicylabel_binding[] rewritepolicylabel_binding = (rewritepolicylabel_binding[]) null;
    }
  }
}
