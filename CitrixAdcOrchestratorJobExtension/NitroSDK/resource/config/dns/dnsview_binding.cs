// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.dns.dnsview_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.dns
{
  public class dnsview_binding : base_resource
  {
    private string viewnameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.dns.dnsview_gslbservice_binding[] dnsview_gslbservice_bindingField = (com.citrix.netscaler.nitro.resource.config.dns.dnsview_gslbservice_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.dns.dnsview_dnspolicy_binding[] dnsview_dnspolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.dns.dnsview_dnspolicy_binding[]) null;

    public string viewname
    {
      get => this.viewnameField;
      set => this.viewnameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.dns.dnsview_dnspolicy_binding[] dnsview_dnspolicy_binding
    {
      get => this.dnsview_dnspolicy_bindingField;
      private set => this.dnsview_dnspolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.dns.dnsview_gslbservice_binding[] dnsview_gslbservice_binding
    {
      get => this.dnsview_gslbservice_bindingField;
      private set => this.dnsview_gslbservice_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      dnsview_binding.dnsview_binding_response dnsviewBindingResponse = new dnsview_binding.dnsview_binding_response();
      dnsview_binding.dnsview_binding_response resource = (dnsview_binding.dnsview_binding_response) service.get_payload_formatter().string_to_resource(dnsviewBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.dnsview_binding;
    }

    internal override string get_object_name() => this.viewname;

    public static dnsview_binding get(nitro_service service, string viewname) => (dnsview_binding) new dnsview_binding()
    {
      viewname = viewname
    }.get_resource(service);

    public static dnsview_binding[] get(nitro_service service, string[] viewname)
    {
      if (viewname == null || viewname.Length <= 0)
        return (dnsview_binding[]) null;
      dnsview_binding[] dnsviewBindingArray1 = new dnsview_binding[viewname.Length];
      dnsview_binding[] dnsviewBindingArray2 = new dnsview_binding[viewname.Length];
      for (int index = 0; index < viewname.Length; ++index)
      {
        dnsviewBindingArray2[index] = new dnsview_binding();
        dnsviewBindingArray2[index].viewname = viewname[index];
        dnsviewBindingArray1[index] = (dnsview_binding) dnsviewBindingArray2[index].get_resource(service);
      }
      return dnsviewBindingArray1;
    }

    private class dnsview_binding_response : base_response
    {
      public dnsview_binding[] dnsview_binding = (dnsview_binding[]) null;
    }
  }
}
