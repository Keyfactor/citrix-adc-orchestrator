// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lb.lbmonitor_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.lb
{
  public class lbmonitor_binding : base_resource
  {
    private string monitornameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.lb.lbmonitor_metric_binding[] lbmonitor_metric_bindingField = (com.citrix.netscaler.nitro.resource.config.lb.lbmonitor_metric_binding[]) null;

    public string monitorname
    {
      get => this.monitornameField;
      set => this.monitornameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lb.lbmonitor_metric_binding[] lbmonitor_metric_binding
    {
      get => this.lbmonitor_metric_bindingField;
      private set => this.lbmonitor_metric_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lbmonitor_binding.lbmonitor_binding_response lbmonitorBindingResponse = new lbmonitor_binding.lbmonitor_binding_response();
      lbmonitor_binding.lbmonitor_binding_response resource = (lbmonitor_binding.lbmonitor_binding_response) service.get_payload_formatter().string_to_resource(lbmonitorBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lbmonitor_binding;
    }

    internal override string get_object_name() => this.monitorname;

    public static lbmonitor_binding get(nitro_service service, string monitorname) => (lbmonitor_binding) new lbmonitor_binding()
    {
      monitorname = monitorname
    }.get_resource(service);

    public static lbmonitor_binding[] get(
      nitro_service service,
      string[] monitorname)
    {
      if (monitorname == null || monitorname.Length <= 0)
        return (lbmonitor_binding[]) null;
      lbmonitor_binding[] lbmonitorBindingArray1 = new lbmonitor_binding[monitorname.Length];
      lbmonitor_binding[] lbmonitorBindingArray2 = new lbmonitor_binding[monitorname.Length];
      for (int index = 0; index < monitorname.Length; ++index)
      {
        lbmonitorBindingArray2[index] = new lbmonitor_binding();
        lbmonitorBindingArray2[index].monitorname = monitorname[index];
        lbmonitorBindingArray1[index] = (lbmonitor_binding) lbmonitorBindingArray2[index].get_resource(service);
      }
      return lbmonitorBindingArray1;
    }

    private class lbmonitor_binding_response : base_response
    {
      public lbmonitor_binding[] lbmonitor_binding = (lbmonitor_binding[]) null;
    }
  }
}
