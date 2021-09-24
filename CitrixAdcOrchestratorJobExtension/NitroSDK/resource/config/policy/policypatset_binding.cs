// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.policy.policypatset_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.policy
{
  public class policypatset_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.policy.policypatset_pattern_binding[] policypatset_pattern_bindingField = (com.citrix.netscaler.nitro.resource.config.policy.policypatset_pattern_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.policy.policypatset_pattern_binding[] policypatset_pattern_binding
    {
      get => this.policypatset_pattern_bindingField;
      private set => this.policypatset_pattern_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      policypatset_binding.policypatset_binding_response policypatsetBindingResponse = new policypatset_binding.policypatset_binding_response();
      policypatset_binding.policypatset_binding_response resource = (policypatset_binding.policypatset_binding_response) service.get_payload_formatter().string_to_resource(policypatsetBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.policypatset_binding;
    }

    internal override string get_object_name() => this.name;

    public static policypatset_binding get(nitro_service service, string name) => (policypatset_binding) new policypatset_binding()
    {
      name = name
    }.get_resource(service);

    public static policypatset_binding[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (policypatset_binding[]) null;
      policypatset_binding[] policypatsetBindingArray1 = new policypatset_binding[name.Length];
      policypatset_binding[] policypatsetBindingArray2 = new policypatset_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        policypatsetBindingArray2[index] = new policypatset_binding();
        policypatsetBindingArray2[index].name = name[index];
        policypatsetBindingArray1[index] = (policypatset_binding) policypatsetBindingArray2[index].get_resource(service);
      }
      return policypatsetBindingArray1;
    }

    private class policypatset_binding_response : base_response
    {
      public policypatset_binding[] policypatset_binding = (policypatset_binding[]) null;
    }
  }
}
