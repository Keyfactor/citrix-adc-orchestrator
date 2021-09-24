// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.policy.policystringmap_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.policy
{
  public class policystringmap_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.policy.policystringmap_pattern_binding[] policystringmap_pattern_bindingField = (com.citrix.netscaler.nitro.resource.config.policy.policystringmap_pattern_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.policy.policystringmap_pattern_binding[] policystringmap_pattern_binding
    {
      get => this.policystringmap_pattern_bindingField;
      private set => this.policystringmap_pattern_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      policystringmap_binding.policystringmap_binding_response policystringmapBindingResponse = new policystringmap_binding.policystringmap_binding_response();
      policystringmap_binding.policystringmap_binding_response resource = (policystringmap_binding.policystringmap_binding_response) service.get_payload_formatter().string_to_resource(policystringmapBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.policystringmap_binding;
    }

    internal override string get_object_name() => this.name;

    public static policystringmap_binding get(
      nitro_service service,
      string name)
    {
      return (policystringmap_binding) new policystringmap_binding()
      {
        name = name
      }.get_resource(service);
    }

    public static policystringmap_binding[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (policystringmap_binding[]) null;
      policystringmap_binding[] policystringmapBindingArray1 = new policystringmap_binding[name.Length];
      policystringmap_binding[] policystringmapBindingArray2 = new policystringmap_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        policystringmapBindingArray2[index] = new policystringmap_binding();
        policystringmapBindingArray2[index].name = name[index];
        policystringmapBindingArray1[index] = (policystringmap_binding) policystringmapBindingArray2[index].get_resource(service);
      }
      return policystringmapBindingArray1;
    }

    private class policystringmap_binding_response : base_response
    {
      public policystringmap_binding[] policystringmap_binding = (policystringmap_binding[]) null;
    }
  }
}
