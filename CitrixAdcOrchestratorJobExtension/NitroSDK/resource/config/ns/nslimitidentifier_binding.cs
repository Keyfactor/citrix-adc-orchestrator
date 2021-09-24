// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nslimitidentifier_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nslimitidentifier_binding : base_resource
  {
    private string limitidentifierField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.ns.nslimitidentifier_nslimitsessions_binding[] nslimitidentifier_nslimitsessions_bindingField = (com.citrix.netscaler.nitro.resource.config.ns.nslimitidentifier_nslimitsessions_binding[]) null;

    public string limitidentifier
    {
      get => this.limitidentifierField;
      set => this.limitidentifierField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ns.nslimitidentifier_nslimitsessions_binding[] nslimitidentifier_nslimitsessions_binding
    {
      get => this.nslimitidentifier_nslimitsessions_bindingField;
      private set => this.nslimitidentifier_nslimitsessions_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nslimitidentifier_binding.nslimitidentifier_binding_response nslimitidentifierBindingResponse = new nslimitidentifier_binding.nslimitidentifier_binding_response();
      nslimitidentifier_binding.nslimitidentifier_binding_response resource = (nslimitidentifier_binding.nslimitidentifier_binding_response) service.get_payload_formatter().string_to_resource(nslimitidentifierBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nslimitidentifier_binding;
    }

    internal override string get_object_name() => this.limitidentifier;

    public static nslimitidentifier_binding get(
      nitro_service service,
      string limitidentifier)
    {
      return (nslimitidentifier_binding) new nslimitidentifier_binding()
      {
        limitidentifier = limitidentifier
      }.get_resource(service);
    }

    public static nslimitidentifier_binding[] get(
      nitro_service service,
      string[] limitidentifier)
    {
      if (limitidentifier == null || limitidentifier.Length <= 0)
        return (nslimitidentifier_binding[]) null;
      nslimitidentifier_binding[] nslimitidentifierBindingArray1 = new nslimitidentifier_binding[limitidentifier.Length];
      nslimitidentifier_binding[] nslimitidentifierBindingArray2 = new nslimitidentifier_binding[limitidentifier.Length];
      for (int index = 0; index < limitidentifier.Length; ++index)
      {
        nslimitidentifierBindingArray2[index] = new nslimitidentifier_binding();
        nslimitidentifierBindingArray2[index].limitidentifier = limitidentifier[index];
        nslimitidentifierBindingArray1[index] = (nslimitidentifier_binding) nslimitidentifierBindingArray2[index].get_resource(service);
      }
      return nslimitidentifierBindingArray1;
    }

    private class nslimitidentifier_binding_response : base_response
    {
      public nslimitidentifier_binding[] nslimitidentifier_binding = (nslimitidentifier_binding[]) null;
    }
  }
}
