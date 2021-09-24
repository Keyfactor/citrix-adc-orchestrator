// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.dns.dnspolicylabel_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.dns
{
  public class dnspolicylabel_binding : base_resource
  {
    private string labelnameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.dns.dnspolicylabel_policybinding_binding[] dnspolicylabel_policybinding_bindingField = (com.citrix.netscaler.nitro.resource.config.dns.dnspolicylabel_policybinding_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.dns.dnspolicylabel_dnspolicy_binding[] dnspolicylabel_dnspolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.dns.dnspolicylabel_dnspolicy_binding[]) null;

    public string labelname
    {
      get => this.labelnameField;
      set => this.labelnameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.dns.dnspolicylabel_policybinding_binding[] dnspolicylabel_policybinding_binding
    {
      get => this.dnspolicylabel_policybinding_bindingField;
      private set => this.dnspolicylabel_policybinding_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.dns.dnspolicylabel_dnspolicy_binding[] dnspolicylabel_dnspolicy_binding
    {
      get => this.dnspolicylabel_dnspolicy_bindingField;
      private set => this.dnspolicylabel_dnspolicy_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      dnspolicylabel_binding.dnspolicylabel_binding_response dnspolicylabelBindingResponse = new dnspolicylabel_binding.dnspolicylabel_binding_response();
      dnspolicylabel_binding.dnspolicylabel_binding_response resource = (dnspolicylabel_binding.dnspolicylabel_binding_response) service.get_payload_formatter().string_to_resource(dnspolicylabelBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.dnspolicylabel_binding;
    }

    internal override string get_object_name() => this.labelname;

    public static dnspolicylabel_binding get(
      nitro_service service,
      string labelname)
    {
      return (dnspolicylabel_binding) new dnspolicylabel_binding()
      {
        labelname = labelname
      }.get_resource(service);
    }

    public static dnspolicylabel_binding[] get(
      nitro_service service,
      string[] labelname)
    {
      if (labelname == null || labelname.Length <= 0)
        return (dnspolicylabel_binding[]) null;
      dnspolicylabel_binding[] dnspolicylabelBindingArray1 = new dnspolicylabel_binding[labelname.Length];
      dnspolicylabel_binding[] dnspolicylabelBindingArray2 = new dnspolicylabel_binding[labelname.Length];
      for (int index = 0; index < labelname.Length; ++index)
      {
        dnspolicylabelBindingArray2[index] = new dnspolicylabel_binding();
        dnspolicylabelBindingArray2[index].labelname = labelname[index];
        dnspolicylabelBindingArray1[index] = (dnspolicylabel_binding) dnspolicylabelBindingArray2[index].get_resource(service);
      }
      return dnspolicylabelBindingArray1;
    }

    private class dnspolicylabel_binding_response : base_response
    {
      public dnspolicylabel_binding[] dnspolicylabel_binding = (dnspolicylabel_binding[]) null;
    }
  }
}
