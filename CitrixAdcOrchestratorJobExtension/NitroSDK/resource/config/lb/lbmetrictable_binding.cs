// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lb.lbmetrictable_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.lb
{
  public class lbmetrictable_binding : base_resource
  {
    private string metrictableField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.lb.lbmetrictable_metric_binding[] lbmetrictable_metric_bindingField = (com.citrix.netscaler.nitro.resource.config.lb.lbmetrictable_metric_binding[]) null;

    public string metrictable
    {
      get => this.metrictableField;
      set => this.metrictableField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lb.lbmetrictable_metric_binding[] lbmetrictable_metric_binding
    {
      get => this.lbmetrictable_metric_bindingField;
      private set => this.lbmetrictable_metric_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lbmetrictable_binding.lbmetrictable_binding_response lbmetrictableBindingResponse = new lbmetrictable_binding.lbmetrictable_binding_response();
      lbmetrictable_binding.lbmetrictable_binding_response resource = (lbmetrictable_binding.lbmetrictable_binding_response) service.get_payload_formatter().string_to_resource(lbmetrictableBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lbmetrictable_binding;
    }

    internal override string get_object_name() => this.metrictable;

    public static lbmetrictable_binding get(
      nitro_service service,
      string metrictable)
    {
      return (lbmetrictable_binding) new lbmetrictable_binding()
      {
        metrictable = metrictable
      }.get_resource(service);
    }

    public static lbmetrictable_binding[] get(
      nitro_service service,
      string[] metrictable)
    {
      if (metrictable == null || metrictable.Length <= 0)
        return (lbmetrictable_binding[]) null;
      lbmetrictable_binding[] lbmetrictableBindingArray1 = new lbmetrictable_binding[metrictable.Length];
      lbmetrictable_binding[] lbmetrictableBindingArray2 = new lbmetrictable_binding[metrictable.Length];
      for (int index = 0; index < metrictable.Length; ++index)
      {
        lbmetrictableBindingArray2[index] = new lbmetrictable_binding();
        lbmetrictableBindingArray2[index].metrictable = metrictable[index];
        lbmetrictableBindingArray1[index] = (lbmetrictable_binding) lbmetrictableBindingArray2[index].get_resource(service);
      }
      return lbmetrictableBindingArray1;
    }

    private class lbmetrictable_binding_response : base_response
    {
      public lbmetrictable_binding[] lbmetrictable_binding = (lbmetrictable_binding[]) null;
    }
  }
}
