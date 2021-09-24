// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.gslb.gslbservice_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.gslb
{
  public class gslbservice_binding : base_resource
  {
    private string servicenameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.gslb.gslbservice_lbmonitor_binding[] gslbservice_lbmonitor_bindingField = (com.citrix.netscaler.nitro.resource.config.gslb.gslbservice_lbmonitor_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.gslb.gslbservice_dnsview_binding[] gslbservice_dnsview_bindingField = (com.citrix.netscaler.nitro.resource.config.gslb.gslbservice_dnsview_binding[]) null;

    public string servicename
    {
      get => this.servicenameField;
      set => this.servicenameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.gslb.gslbservice_lbmonitor_binding[] gslbservice_lbmonitor_binding
    {
      get => this.gslbservice_lbmonitor_bindingField;
      private set => this.gslbservice_lbmonitor_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.gslb.gslbservice_dnsview_binding[] gslbservice_dnsview_binding
    {
      get => this.gslbservice_dnsview_bindingField;
      private set => this.gslbservice_dnsview_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      gslbservice_binding.gslbservice_binding_response gslbserviceBindingResponse = new gslbservice_binding.gslbservice_binding_response();
      gslbservice_binding.gslbservice_binding_response resource = (gslbservice_binding.gslbservice_binding_response) service.get_payload_formatter().string_to_resource(gslbserviceBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.gslbservice_binding;
    }

    internal override string get_object_name() => this.servicename;

    public static gslbservice_binding get(
      nitro_service service,
      string servicename)
    {
      return (gslbservice_binding) new gslbservice_binding()
      {
        servicename = servicename
      }.get_resource(service);
    }

    public static gslbservice_binding[] get(
      nitro_service service,
      string[] servicename)
    {
      if (servicename == null || servicename.Length <= 0)
        return (gslbservice_binding[]) null;
      gslbservice_binding[] gslbserviceBindingArray1 = new gslbservice_binding[servicename.Length];
      gslbservice_binding[] gslbserviceBindingArray2 = new gslbservice_binding[servicename.Length];
      for (int index = 0; index < servicename.Length; ++index)
      {
        gslbserviceBindingArray2[index] = new gslbservice_binding();
        gslbserviceBindingArray2[index].servicename = servicename[index];
        gslbserviceBindingArray1[index] = (gslbservice_binding) gslbserviceBindingArray2[index].get_resource(service);
      }
      return gslbserviceBindingArray1;
    }

    private class gslbservice_binding_response : base_response
    {
      public gslbservice_binding[] gslbservice_binding = (gslbservice_binding[]) null;
    }
  }
}
