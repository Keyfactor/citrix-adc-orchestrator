// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.dns.dnszone_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.dns
{
  public class dnszone_binding : base_resource
  {
    private string zonenameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.dns.dnszone_domain_binding[] dnszone_domain_bindingField = (com.citrix.netscaler.nitro.resource.config.dns.dnszone_domain_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.dns.dnszone_dnskey_binding[] dnszone_dnskey_bindingField = (com.citrix.netscaler.nitro.resource.config.dns.dnszone_dnskey_binding[]) null;

    public string zonename
    {
      get => this.zonenameField;
      set => this.zonenameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.dns.dnszone_dnskey_binding[] dnszone_dnskey_binding
    {
      get => this.dnszone_dnskey_bindingField;
      private set => this.dnszone_dnskey_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.dns.dnszone_domain_binding[] dnszone_domain_binding
    {
      get => this.dnszone_domain_bindingField;
      private set => this.dnszone_domain_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      dnszone_binding.dnszone_binding_response dnszoneBindingResponse = new dnszone_binding.dnszone_binding_response();
      dnszone_binding.dnszone_binding_response resource = (dnszone_binding.dnszone_binding_response) service.get_payload_formatter().string_to_resource(dnszoneBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.dnszone_binding;
    }

    internal override string get_object_name() => this.zonename;

    public static dnszone_binding get(nitro_service service, string zonename) => (dnszone_binding) new dnszone_binding()
    {
      zonename = zonename
    }.get_resource(service);

    public static dnszone_binding[] get(nitro_service service, string[] zonename)
    {
      if (zonename == null || zonename.Length <= 0)
        return (dnszone_binding[]) null;
      dnszone_binding[] dnszoneBindingArray1 = new dnszone_binding[zonename.Length];
      dnszone_binding[] dnszoneBindingArray2 = new dnszone_binding[zonename.Length];
      for (int index = 0; index < zonename.Length; ++index)
      {
        dnszoneBindingArray2[index] = new dnszone_binding();
        dnszoneBindingArray2[index].zonename = zonename[index];
        dnszoneBindingArray1[index] = (dnszone_binding) dnszoneBindingArray2[index].get_resource(service);
      }
      return dnszoneBindingArray1;
    }

    private class dnszone_binding_response : base_response
    {
      public dnszone_binding[] dnszone_binding = (dnszone_binding[]) null;
    }
  }
}
