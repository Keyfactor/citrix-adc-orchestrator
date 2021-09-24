// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ca.capolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ca
{
  public class capolicy_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.ca.capolicy_lbvserver_binding[] capolicy_lbvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.ca.capolicy_lbvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.ca.capolicy_caglobal_binding[] capolicy_caglobal_bindingField = (com.citrix.netscaler.nitro.resource.config.ca.capolicy_caglobal_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.ca.capolicy_csvserver_binding[] capolicy_csvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.ca.capolicy_csvserver_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ca.capolicy_csvserver_binding[] capolicy_csvserver_binding
    {
      get => this.capolicy_csvserver_bindingField;
      private set => this.capolicy_csvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ca.capolicy_caglobal_binding[] capolicy_caglobal_binding
    {
      get => this.capolicy_caglobal_bindingField;
      private set => this.capolicy_caglobal_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ca.capolicy_lbvserver_binding[] capolicy_lbvserver_binding
    {
      get => this.capolicy_lbvserver_bindingField;
      private set => this.capolicy_lbvserver_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      capolicy_binding.capolicy_binding_response capolicyBindingResponse = new capolicy_binding.capolicy_binding_response();
      capolicy_binding.capolicy_binding_response resource = (capolicy_binding.capolicy_binding_response) service.get_payload_formatter().string_to_resource(capolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.capolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static capolicy_binding get(nitro_service service, string name) => (capolicy_binding) new capolicy_binding()
    {
      name = name
    }.get_resource(service);

    public static capolicy_binding[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (capolicy_binding[]) null;
      capolicy_binding[] capolicyBindingArray1 = new capolicy_binding[name.Length];
      capolicy_binding[] capolicyBindingArray2 = new capolicy_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        capolicyBindingArray2[index] = new capolicy_binding();
        capolicyBindingArray2[index].name = name[index];
        capolicyBindingArray1[index] = (capolicy_binding) capolicyBindingArray2[index].get_resource(service);
      }
      return capolicyBindingArray1;
    }

    private class capolicy_binding_response : base_response
    {
      public capolicy_binding[] capolicy_binding = (capolicy_binding[]) null;
    }
  }
}
