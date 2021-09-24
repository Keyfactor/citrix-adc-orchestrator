// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lb.lbmonbindings_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.lb
{
  public class lbmonbindings_binding : base_resource
  {
    private string monitornameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.lb.lbmonbindings_servicegroup_binding[] lbmonbindings_servicegroup_bindingField = (com.citrix.netscaler.nitro.resource.config.lb.lbmonbindings_servicegroup_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.lb.lbmonbindings_service_binding[] lbmonbindings_service_bindingField = (com.citrix.netscaler.nitro.resource.config.lb.lbmonbindings_service_binding[]) null;

    public string monitorname
    {
      get => this.monitornameField;
      set => this.monitornameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lb.lbmonbindings_service_binding[] lbmonbindings_service_binding
    {
      get => this.lbmonbindings_service_bindingField;
      private set => this.lbmonbindings_service_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lb.lbmonbindings_servicegroup_binding[] lbmonbindings_servicegroup_binding
    {
      get => this.lbmonbindings_servicegroup_bindingField;
      private set => this.lbmonbindings_servicegroup_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lbmonbindings_binding.lbmonbindings_binding_response lbmonbindingsBindingResponse = new lbmonbindings_binding.lbmonbindings_binding_response();
      lbmonbindings_binding.lbmonbindings_binding_response resource = (lbmonbindings_binding.lbmonbindings_binding_response) service.get_payload_formatter().string_to_resource(lbmonbindingsBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lbmonbindings_binding;
    }

    internal override string get_object_name() => this.monitorname;

    public static lbmonbindings_binding get(
      nitro_service service,
      string monitorname)
    {
      return (lbmonbindings_binding) new lbmonbindings_binding()
      {
        monitorname = monitorname
      }.get_resource(service);
    }

    public static lbmonbindings_binding[] get(
      nitro_service service,
      string[] monitorname)
    {
      if (monitorname == null || monitorname.Length <= 0)
        return (lbmonbindings_binding[]) null;
      lbmonbindings_binding[] lbmonbindingsBindingArray1 = new lbmonbindings_binding[monitorname.Length];
      lbmonbindings_binding[] lbmonbindingsBindingArray2 = new lbmonbindings_binding[monitorname.Length];
      for (int index = 0; index < monitorname.Length; ++index)
      {
        lbmonbindingsBindingArray2[index] = new lbmonbindings_binding();
        lbmonbindingsBindingArray2[index].monitorname = monitorname[index];
        lbmonbindingsBindingArray1[index] = (lbmonbindings_binding) lbmonbindingsBindingArray2[index].get_resource(service);
      }
      return lbmonbindingsBindingArray1;
    }

    private class lbmonbindings_binding_response : base_response
    {
      public lbmonbindings_binding[] lbmonbindings_binding = (lbmonbindings_binding[]) null;
    }
  }
}
