// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.gslb.gslbvserver_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.gslb
{
  public class gslbvserver_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.gslb.gslbvserver_spilloverpolicy_binding[] gslbvserver_spilloverpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.gslb.gslbvserver_spilloverpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.gslb.gslbvserver_gslbservice_binding[] gslbvserver_gslbservice_bindingField = (com.citrix.netscaler.nitro.resource.config.gslb.gslbvserver_gslbservice_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.gslb.gslbvserver_domain_binding[] gslbvserver_domain_bindingField = (com.citrix.netscaler.nitro.resource.config.gslb.gslbvserver_domain_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.gslb.gslbvserver_gslbservice_binding[] gslbvserver_gslbservice_binding
    {
      get => this.gslbvserver_gslbservice_bindingField;
      private set => this.gslbvserver_gslbservice_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.gslb.gslbvserver_spilloverpolicy_binding[] gslbvserver_spilloverpolicy_binding
    {
      get => this.gslbvserver_spilloverpolicy_bindingField;
      private set => this.gslbvserver_spilloverpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.gslb.gslbvserver_domain_binding[] gslbvserver_domain_binding
    {
      get => this.gslbvserver_domain_bindingField;
      private set => this.gslbvserver_domain_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      gslbvserver_binding.gslbvserver_binding_response gslbvserverBindingResponse = new gslbvserver_binding.gslbvserver_binding_response();
      gslbvserver_binding.gslbvserver_binding_response resource = (gslbvserver_binding.gslbvserver_binding_response) service.get_payload_formatter().string_to_resource(gslbvserverBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.gslbvserver_binding;
    }

    internal override string get_object_name() => this.name;

    public static gslbvserver_binding get(nitro_service service, string name) => (gslbvserver_binding) new gslbvserver_binding()
    {
      name = name
    }.get_resource(service);

    public static gslbvserver_binding[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (gslbvserver_binding[]) null;
      gslbvserver_binding[] gslbvserverBindingArray1 = new gslbvserver_binding[name.Length];
      gslbvserver_binding[] gslbvserverBindingArray2 = new gslbvserver_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        gslbvserverBindingArray2[index] = new gslbvserver_binding();
        gslbvserverBindingArray2[index].name = name[index];
        gslbvserverBindingArray1[index] = (gslbvserver_binding) gslbvserverBindingArray2[index].get_resource(service);
      }
      return gslbvserverBindingArray1;
    }

    private class gslbvserver_binding_response : base_response
    {
      public gslbvserver_binding[] gslbvserver_binding = (gslbvserver_binding[]) null;
    }
  }
}
