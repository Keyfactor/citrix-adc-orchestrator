// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cache.cachepolicylabel_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.cache
{
  public class cachepolicylabel_binding : base_resource
  {
    private string labelnameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.cache.cachepolicylabel_policybinding_binding[] cachepolicylabel_policybinding_bindingField = (com.citrix.netscaler.nitro.resource.config.cache.cachepolicylabel_policybinding_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cache.cachepolicylabel_cachepolicy_binding[] cachepolicylabel_cachepolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.cache.cachepolicylabel_cachepolicy_binding[]) null;

    public string labelname
    {
      get => this.labelnameField;
      set => this.labelnameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cache.cachepolicylabel_policybinding_binding[] cachepolicylabel_policybinding_binding
    {
      get => this.cachepolicylabel_policybinding_bindingField;
      private set => this.cachepolicylabel_policybinding_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cache.cachepolicylabel_cachepolicy_binding[] cachepolicylabel_cachepolicy_binding
    {
      get => this.cachepolicylabel_cachepolicy_bindingField;
      private set => this.cachepolicylabel_cachepolicy_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      cachepolicylabel_binding.cachepolicylabel_binding_response cachepolicylabelBindingResponse = new cachepolicylabel_binding.cachepolicylabel_binding_response();
      cachepolicylabel_binding.cachepolicylabel_binding_response resource = (cachepolicylabel_binding.cachepolicylabel_binding_response) service.get_payload_formatter().string_to_resource(cachepolicylabelBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.cachepolicylabel_binding;
    }

    internal override string get_object_name() => this.labelname;

    public static cachepolicylabel_binding get(
      nitro_service service,
      string labelname)
    {
      return (cachepolicylabel_binding) new cachepolicylabel_binding()
      {
        labelname = labelname
      }.get_resource(service);
    }

    public static cachepolicylabel_binding[] get(
      nitro_service service,
      string[] labelname)
    {
      if (labelname == null || labelname.Length <= 0)
        return (cachepolicylabel_binding[]) null;
      cachepolicylabel_binding[] cachepolicylabelBindingArray1 = new cachepolicylabel_binding[labelname.Length];
      cachepolicylabel_binding[] cachepolicylabelBindingArray2 = new cachepolicylabel_binding[labelname.Length];
      for (int index = 0; index < labelname.Length; ++index)
      {
        cachepolicylabelBindingArray2[index] = new cachepolicylabel_binding();
        cachepolicylabelBindingArray2[index].labelname = labelname[index];
        cachepolicylabelBindingArray1[index] = (cachepolicylabel_binding) cachepolicylabelBindingArray2[index].get_resource(service);
      }
      return cachepolicylabelBindingArray1;
    }

    private class cachepolicylabel_binding_response : base_response
    {
      public cachepolicylabel_binding[] cachepolicylabel_binding = (cachepolicylabel_binding[]) null;
    }
  }
}
