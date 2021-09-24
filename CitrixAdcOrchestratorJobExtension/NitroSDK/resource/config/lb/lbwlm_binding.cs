// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lb.lbwlm_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.lb
{
  public class lbwlm_binding : base_resource
  {
    private string wlmnameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.lb.lbwlm_lbvserver_binding[] lbwlm_lbvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.lb.lbwlm_lbvserver_binding[]) null;

    public string wlmname
    {
      get => this.wlmnameField;
      set => this.wlmnameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lb.lbwlm_lbvserver_binding[] lbwlm_lbvserver_binding
    {
      get => this.lbwlm_lbvserver_bindingField;
      private set => this.lbwlm_lbvserver_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lbwlm_binding.lbwlm_binding_response lbwlmBindingResponse = new lbwlm_binding.lbwlm_binding_response();
      lbwlm_binding.lbwlm_binding_response resource = (lbwlm_binding.lbwlm_binding_response) service.get_payload_formatter().string_to_resource(lbwlmBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lbwlm_binding;
    }

    internal override string get_object_name() => this.wlmname;

    public static lbwlm_binding get(nitro_service service, string wlmname) => (lbwlm_binding) new lbwlm_binding()
    {
      wlmname = wlmname
    }.get_resource(service);

    public static lbwlm_binding[] get(nitro_service service, string[] wlmname)
    {
      if (wlmname == null || wlmname.Length <= 0)
        return (lbwlm_binding[]) null;
      lbwlm_binding[] lbwlmBindingArray1 = new lbwlm_binding[wlmname.Length];
      lbwlm_binding[] lbwlmBindingArray2 = new lbwlm_binding[wlmname.Length];
      for (int index = 0; index < wlmname.Length; ++index)
      {
        lbwlmBindingArray2[index] = new lbwlm_binding();
        lbwlmBindingArray2[index].wlmname = wlmname[index];
        lbwlmBindingArray1[index] = (lbwlm_binding) lbwlmBindingArray2[index].get_resource(service);
      }
      return lbwlmBindingArray1;
    }

    private class lbwlm_binding_response : base_response
    {
      public lbwlm_binding[] lbwlm_binding = (lbwlm_binding[]) null;
    }
  }
}
