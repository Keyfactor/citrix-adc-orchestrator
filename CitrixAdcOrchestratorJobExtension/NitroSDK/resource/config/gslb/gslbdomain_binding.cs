// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.gslb.gslbdomain_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.gslb
{
  public class gslbdomain_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.gslb.gslbdomain_gslbvserver_binding[] gslbdomain_gslbvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.gslb.gslbdomain_gslbvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.gslb.gslbdomain_gslbservice_binding[] gslbdomain_gslbservice_bindingField = (com.citrix.netscaler.nitro.resource.config.gslb.gslbdomain_gslbservice_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.gslb.gslbdomain_lbmonitor_binding[] gslbdomain_lbmonitor_bindingField = (com.citrix.netscaler.nitro.resource.config.gslb.gslbdomain_lbmonitor_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.gslb.gslbdomain_lbmonitor_binding[] gslbdomain_lbmonitor_binding
    {
      get => this.gslbdomain_lbmonitor_bindingField;
      private set => this.gslbdomain_lbmonitor_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.gslb.gslbdomain_gslbvserver_binding[] gslbdomain_gslbvserver_binding
    {
      get => this.gslbdomain_gslbvserver_bindingField;
      private set => this.gslbdomain_gslbvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.gslb.gslbdomain_gslbservice_binding[] gslbdomain_gslbservice_binding
    {
      get => this.gslbdomain_gslbservice_bindingField;
      private set => this.gslbdomain_gslbservice_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      gslbdomain_binding.gslbdomain_binding_response gslbdomainBindingResponse = new gslbdomain_binding.gslbdomain_binding_response();
      gslbdomain_binding.gslbdomain_binding_response resource = (gslbdomain_binding.gslbdomain_binding_response) service.get_payload_formatter().string_to_resource(gslbdomainBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.gslbdomain_binding;
    }

    internal override string get_object_name() => this.name;

    public static gslbdomain_binding get(nitro_service service, string name) => (gslbdomain_binding) new gslbdomain_binding()
    {
      name = name
    }.get_resource(service);

    public static gslbdomain_binding[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (gslbdomain_binding[]) null;
      gslbdomain_binding[] gslbdomainBindingArray1 = new gslbdomain_binding[name.Length];
      gslbdomain_binding[] gslbdomainBindingArray2 = new gslbdomain_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        gslbdomainBindingArray2[index] = new gslbdomain_binding();
        gslbdomainBindingArray2[index].name = name[index];
        gslbdomainBindingArray1[index] = (gslbdomain_binding) gslbdomainBindingArray2[index].get_resource(service);
      }
      return gslbdomainBindingArray1;
    }

    private class gslbdomain_binding_response : base_response
    {
      public gslbdomain_binding[] gslbdomain_binding = (gslbdomain_binding[]) null;
    }
  }
}
