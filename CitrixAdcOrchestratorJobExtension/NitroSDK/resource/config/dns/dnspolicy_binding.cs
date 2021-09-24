// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.dns.dnspolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.dns
{
  public class dnspolicy_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.dns.dnspolicy_dnspolicylabel_binding[] dnspolicy_dnspolicylabel_bindingField = (com.citrix.netscaler.nitro.resource.config.dns.dnspolicy_dnspolicylabel_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.dns.dnspolicy_dnsglobal_binding[] dnspolicy_dnsglobal_bindingField = (com.citrix.netscaler.nitro.resource.config.dns.dnspolicy_dnsglobal_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.dns.dnspolicy_dnsglobal_binding[] dnspolicy_dnsglobal_binding
    {
      get => this.dnspolicy_dnsglobal_bindingField;
      private set => this.dnspolicy_dnsglobal_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.dns.dnspolicy_dnspolicylabel_binding[] dnspolicy_dnspolicylabel_binding
    {
      get => this.dnspolicy_dnspolicylabel_bindingField;
      private set => this.dnspolicy_dnspolicylabel_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      dnspolicy_binding.dnspolicy_binding_response dnspolicyBindingResponse = new dnspolicy_binding.dnspolicy_binding_response();
      dnspolicy_binding.dnspolicy_binding_response resource = (dnspolicy_binding.dnspolicy_binding_response) service.get_payload_formatter().string_to_resource(dnspolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.dnspolicy_binding;
    }

    internal override string get_object_name() => this.name;

    public static dnspolicy_binding get(nitro_service service, string name) => (dnspolicy_binding) new dnspolicy_binding()
    {
      name = name
    }.get_resource(service);

    public static dnspolicy_binding[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (dnspolicy_binding[]) null;
      dnspolicy_binding[] dnspolicyBindingArray1 = new dnspolicy_binding[name.Length];
      dnspolicy_binding[] dnspolicyBindingArray2 = new dnspolicy_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        dnspolicyBindingArray2[index] = new dnspolicy_binding();
        dnspolicyBindingArray2[index].name = name[index];
        dnspolicyBindingArray1[index] = (dnspolicy_binding) dnspolicyBindingArray2[index].get_resource(service);
      }
      return dnspolicyBindingArray1;
    }

    private class dnspolicy_binding_response : base_response
    {
      public dnspolicy_binding[] dnspolicy_binding = (dnspolicy_binding[]) null;
    }
  }
}
