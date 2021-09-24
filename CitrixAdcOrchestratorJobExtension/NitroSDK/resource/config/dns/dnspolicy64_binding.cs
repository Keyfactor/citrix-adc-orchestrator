// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.dns.dnspolicy64_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.dns
{
  public class dnspolicy64_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.dns.dnspolicy64_lbvserver_binding[] dnspolicy64_lbvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.dns.dnspolicy64_lbvserver_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.dns.dnspolicy64_lbvserver_binding[] dnspolicy64_lbvserver_binding
    {
      get => this.dnspolicy64_lbvserver_bindingField;
      private set => this.dnspolicy64_lbvserver_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      dnspolicy64_binding.dnspolicy64_binding_response dnspolicy64BindingResponse = new dnspolicy64_binding.dnspolicy64_binding_response();
      dnspolicy64_binding.dnspolicy64_binding_response resource = (dnspolicy64_binding.dnspolicy64_binding_response) service.get_payload_formatter().string_to_resource(dnspolicy64BindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.dnspolicy64_binding;
    }

    internal override string get_object_name() => this.name;

    public static dnspolicy64_binding get(nitro_service service, string name) => (dnspolicy64_binding) new dnspolicy64_binding()
    {
      name = name
    }.get_resource(service);

    public static dnspolicy64_binding[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (dnspolicy64_binding[]) null;
      dnspolicy64_binding[] dnspolicy64BindingArray1 = new dnspolicy64_binding[name.Length];
      dnspolicy64_binding[] dnspolicy64BindingArray2 = new dnspolicy64_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        dnspolicy64BindingArray2[index] = new dnspolicy64_binding();
        dnspolicy64BindingArray2[index].name = name[index];
        dnspolicy64BindingArray1[index] = (dnspolicy64_binding) dnspolicy64BindingArray2[index].get_resource(service);
      }
      return dnspolicy64BindingArray1;
    }

    private class dnspolicy64_binding_response : base_response
    {
      public dnspolicy64_binding[] dnspolicy64_binding = (dnspolicy64_binding[]) null;
    }
  }
}
