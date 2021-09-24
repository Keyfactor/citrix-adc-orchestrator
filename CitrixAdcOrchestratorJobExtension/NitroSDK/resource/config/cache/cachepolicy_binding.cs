// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cache.cachepolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.cache
{
  public class cachepolicy_binding : base_resource
  {
    private string policynameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.cache.cachepolicy_cacheglobal_binding[] cachepolicy_cacheglobal_bindingField = (com.citrix.netscaler.nitro.resource.config.cache.cachepolicy_cacheglobal_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cache.cachepolicy_cachepolicylabel_binding[] cachepolicy_cachepolicylabel_bindingField = (com.citrix.netscaler.nitro.resource.config.cache.cachepolicy_cachepolicylabel_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cache.cachepolicy_csvserver_binding[] cachepolicy_csvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.cache.cachepolicy_csvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cache.cachepolicy_lbvserver_binding[] cachepolicy_lbvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.cache.cachepolicy_lbvserver_binding[]) null;

    public string policyname
    {
      get => this.policynameField;
      set => this.policynameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cache.cachepolicy_cachepolicylabel_binding[] cachepolicy_cachepolicylabel_binding
    {
      get => this.cachepolicy_cachepolicylabel_bindingField;
      private set => this.cachepolicy_cachepolicylabel_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cache.cachepolicy_lbvserver_binding[] cachepolicy_lbvserver_binding
    {
      get => this.cachepolicy_lbvserver_bindingField;
      private set => this.cachepolicy_lbvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cache.cachepolicy_cacheglobal_binding[] cachepolicy_cacheglobal_binding
    {
      get => this.cachepolicy_cacheglobal_bindingField;
      private set => this.cachepolicy_cacheglobal_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cache.cachepolicy_csvserver_binding[] cachepolicy_csvserver_binding
    {
      get => this.cachepolicy_csvserver_bindingField;
      private set => this.cachepolicy_csvserver_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      cachepolicy_binding.cachepolicy_binding_response cachepolicyBindingResponse = new cachepolicy_binding.cachepolicy_binding_response();
      cachepolicy_binding.cachepolicy_binding_response resource = (cachepolicy_binding.cachepolicy_binding_response) service.get_payload_formatter().string_to_resource(cachepolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.cachepolicy_binding;
    }

    internal override string get_object_name() => this.policyname;

    public static cachepolicy_binding get(
      nitro_service service,
      string policyname)
    {
      return (cachepolicy_binding) new cachepolicy_binding()
      {
        policyname = policyname
      }.get_resource(service);
    }

    public static cachepolicy_binding[] get(
      nitro_service service,
      string[] policyname)
    {
      if (policyname == null || policyname.Length <= 0)
        return (cachepolicy_binding[]) null;
      cachepolicy_binding[] cachepolicyBindingArray1 = new cachepolicy_binding[policyname.Length];
      cachepolicy_binding[] cachepolicyBindingArray2 = new cachepolicy_binding[policyname.Length];
      for (int index = 0; index < policyname.Length; ++index)
      {
        cachepolicyBindingArray2[index] = new cachepolicy_binding();
        cachepolicyBindingArray2[index].policyname = policyname[index];
        cachepolicyBindingArray1[index] = (cachepolicy_binding) cachepolicyBindingArray2[index].get_resource(service);
      }
      return cachepolicyBindingArray1;
    }

    private class cachepolicy_binding_response : base_response
    {
      public cachepolicy_binding[] cachepolicy_binding = (cachepolicy_binding[]) null;
    }
  }
}
