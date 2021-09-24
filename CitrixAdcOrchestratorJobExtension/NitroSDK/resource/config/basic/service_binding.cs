// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.basic.service_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.basic
{
  public class service_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.basic.service_lbmonitor_binding[] service_lbmonitor_bindingField = (com.citrix.netscaler.nitro.resource.config.basic.service_lbmonitor_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.basic.service_dospolicy_binding[] service_dospolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.basic.service_dospolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.basic.service_scpolicy_binding[] service_scpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.basic.service_scpolicy_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.basic.service_scpolicy_binding[] service_scpolicy_binding
    {
      get => this.service_scpolicy_bindingField;
      private set => this.service_scpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.basic.service_lbmonitor_binding[] service_lbmonitor_binding
    {
      get => this.service_lbmonitor_bindingField;
      private set => this.service_lbmonitor_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.basic.service_dospolicy_binding[] service_dospolicy_binding
    {
      get => this.service_dospolicy_bindingField;
      private set => this.service_dospolicy_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      service_binding.service_binding_response serviceBindingResponse = new service_binding.service_binding_response();
      service_binding.service_binding_response resource = (service_binding.service_binding_response) service.get_payload_formatter().string_to_resource(serviceBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.service_binding;
    }

    internal override string get_object_name() => this.name;

    public static service_binding get(nitro_service service, string name) => (service_binding) new service_binding()
    {
      name = name
    }.get_resource(service);

    public static service_binding[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (service_binding[]) null;
      service_binding[] serviceBindingArray1 = new service_binding[name.Length];
      service_binding[] serviceBindingArray2 = new service_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        serviceBindingArray2[index] = new service_binding();
        serviceBindingArray2[index].name = name[index];
        serviceBindingArray1[index] = (service_binding) serviceBindingArray2[index].get_resource(service);
      }
      return serviceBindingArray1;
    }

    private class service_binding_response : base_response
    {
      public service_binding[] service_binding = (service_binding[]) null;
    }
  }
}
