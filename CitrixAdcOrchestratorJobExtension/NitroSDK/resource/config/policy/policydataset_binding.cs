// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.policy.policydataset_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.policy
{
  public class policydataset_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.policy.policydataset_value_binding[] policydataset_value_bindingField = (com.citrix.netscaler.nitro.resource.config.policy.policydataset_value_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.policy.policydataset_value_binding[] policydataset_value_binding
    {
      get => this.policydataset_value_bindingField;
      private set => this.policydataset_value_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      policydataset_binding.policydataset_binding_response policydatasetBindingResponse = new policydataset_binding.policydataset_binding_response();
      policydataset_binding.policydataset_binding_response resource = (policydataset_binding.policydataset_binding_response) service.get_payload_formatter().string_to_resource(policydatasetBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.policydataset_binding;
    }

    internal override string get_object_name() => this.name;

    public static policydataset_binding get(nitro_service service, string name) => (policydataset_binding) new policydataset_binding()
    {
      name = name
    }.get_resource(service);

    public static policydataset_binding[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (policydataset_binding[]) null;
      policydataset_binding[] policydatasetBindingArray1 = new policydataset_binding[name.Length];
      policydataset_binding[] policydatasetBindingArray2 = new policydataset_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        policydatasetBindingArray2[index] = new policydataset_binding();
        policydatasetBindingArray2[index].name = name[index];
        policydatasetBindingArray1[index] = (policydataset_binding) policydatasetBindingArray2[index].get_resource(service);
      }
      return policydatasetBindingArray1;
    }

    private class policydataset_binding_response : base_response
    {
      public policydataset_binding[] policydataset_binding = (policydataset_binding[]) null;
    }
  }
}
