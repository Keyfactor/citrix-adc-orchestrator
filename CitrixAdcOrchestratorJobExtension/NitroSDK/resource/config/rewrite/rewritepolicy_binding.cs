// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.rewrite.rewritepolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.rewrite
{
  public class rewritepolicy_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.rewrite.rewritepolicy_csvserver_binding[] rewritepolicy_csvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.rewrite.rewritepolicy_csvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.rewrite.rewritepolicy_lbvserver_binding[] rewritepolicy_lbvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.rewrite.rewritepolicy_lbvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.rewrite.rewritepolicy_rewriteglobal_binding[] rewritepolicy_rewriteglobal_bindingField = (com.citrix.netscaler.nitro.resource.config.rewrite.rewritepolicy_rewriteglobal_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.rewrite.rewritepolicy_rewritepolicylabel_binding[] rewritepolicy_rewritepolicylabel_bindingField = (com.citrix.netscaler.nitro.resource.config.rewrite.rewritepolicy_rewritepolicylabel_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.rewrite.rewritepolicy_lbvserver_binding[] rewritepolicy_lbvserver_binding
    {
      get => this.rewritepolicy_lbvserver_bindingField;
      private set => this.rewritepolicy_lbvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.rewrite.rewritepolicy_rewritepolicylabel_binding[] rewritepolicy_rewritepolicylabel_binding
    {
      get => this.rewritepolicy_rewritepolicylabel_bindingField;
      private set => this.rewritepolicy_rewritepolicylabel_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.rewrite.rewritepolicy_rewriteglobal_binding[] rewritepolicy_rewriteglobal_binding
    {
      get => this.rewritepolicy_rewriteglobal_bindingField;
      private set => this.rewritepolicy_rewriteglobal_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.rewrite.rewritepolicy_csvserver_binding[] rewritepolicy_csvserver_binding
    {
      get => this.rewritepolicy_csvserver_bindingField;
      private set => this.rewritepolicy_csvserver_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      rewritepolicy_binding.rewritepolicy_binding_response rewritepolicyBindingResponse = new rewritepolicy_binding.rewritepolicy_binding_response();
      rewritepolicy_binding.rewritepolicy_binding_response resource = (rewritepolicy_binding.rewritepolicy_binding_response) service.get_payload_formatter().string_to_resource(rewritepolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.rewritepolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static rewritepolicy_binding get(nitro_service service, string name) => (rewritepolicy_binding) new rewritepolicy_binding()
    {
      name = name
    }.get_resource(service);

    public static rewritepolicy_binding[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (rewritepolicy_binding[]) null;
      rewritepolicy_binding[] rewritepolicyBindingArray1 = new rewritepolicy_binding[name.Length];
      rewritepolicy_binding[] rewritepolicyBindingArray2 = new rewritepolicy_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        rewritepolicyBindingArray2[index] = new rewritepolicy_binding();
        rewritepolicyBindingArray2[index].name = name[index];
        rewritepolicyBindingArray1[index] = (rewritepolicy_binding) rewritepolicyBindingArray2[index].get_resource(service);
      }
      return rewritepolicyBindingArray1;
    }

    private class rewritepolicy_binding_response : base_response
    {
      public rewritepolicy_binding[] rewritepolicy_binding = (rewritepolicy_binding[]) null;
    }
  }
}
