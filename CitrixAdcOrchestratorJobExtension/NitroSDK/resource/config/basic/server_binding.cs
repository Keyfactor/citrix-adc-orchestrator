// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.basic.server_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.basic
{
  public class server_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.basic.server_service_binding[] server_service_bindingField = (com.citrix.netscaler.nitro.resource.config.basic.server_service_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.basic.server_gslbservice_binding[] server_gslbservice_bindingField = (com.citrix.netscaler.nitro.resource.config.basic.server_gslbservice_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.basic.server_servicegroup_binding[] server_servicegroup_bindingField = (com.citrix.netscaler.nitro.resource.config.basic.server_servicegroup_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.basic.server_servicegroup_binding[] server_servicegroup_binding
    {
      get => this.server_servicegroup_bindingField;
      private set => this.server_servicegroup_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.basic.server_service_binding[] server_service_binding
    {
      get => this.server_service_bindingField;
      private set => this.server_service_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.basic.server_gslbservice_binding[] server_gslbservice_binding
    {
      get => this.server_gslbservice_bindingField;
      private set => this.server_gslbservice_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      server_binding.server_binding_response serverBindingResponse = new server_binding.server_binding_response();
      server_binding.server_binding_response resource = (server_binding.server_binding_response) service.get_payload_formatter().string_to_resource(serverBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.server_binding;
    }

    internal override string get_object_name() => this.name;

    public static server_binding get(nitro_service service, string name) => (server_binding) new server_binding()
    {
      name = name
    }.get_resource(service);

    public static server_binding[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (server_binding[]) null;
      server_binding[] serverBindingArray1 = new server_binding[name.Length];
      server_binding[] serverBindingArray2 = new server_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        serverBindingArray2[index] = new server_binding();
        serverBindingArray2[index].name = name[index];
        serverBindingArray1[index] = (server_binding) serverBindingArray2[index].get_resource(service);
      }
      return serverBindingArray1;
    }

    private class server_binding_response : base_response
    {
      public server_binding[] server_binding = (server_binding[]) null;
    }
  }
}
