// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cr.crpolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.cr
{
  public class crpolicy_binding : base_resource
  {
    private string policynameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.cr.crpolicy_crvserver_binding[] crpolicy_crvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.cr.crpolicy_crvserver_binding[]) null;

    public string policyname
    {
      get => this.policynameField;
      set => this.policynameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cr.crpolicy_crvserver_binding[] crpolicy_crvserver_binding
    {
      get => this.crpolicy_crvserver_bindingField;
      private set => this.crpolicy_crvserver_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      crpolicy_binding.crpolicy_binding_response crpolicyBindingResponse = new crpolicy_binding.crpolicy_binding_response();
      crpolicy_binding.crpolicy_binding_response resource = (crpolicy_binding.crpolicy_binding_response) service.get_payload_formatter().string_to_resource(crpolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.crpolicy_binding;
    }

    internal override string get_object_name() => this.policyname;

    public static crpolicy_binding get(nitro_service service, string policyname) => (crpolicy_binding) new crpolicy_binding()
    {
      policyname = policyname
    }.get_resource(service);

    public static crpolicy_binding[] get(nitro_service service, string[] policyname)
    {
      if (policyname == null || policyname.Length <= 0)
        return (crpolicy_binding[]) null;
      crpolicy_binding[] crpolicyBindingArray1 = new crpolicy_binding[policyname.Length];
      crpolicy_binding[] crpolicyBindingArray2 = new crpolicy_binding[policyname.Length];
      for (int index = 0; index < policyname.Length; ++index)
      {
        crpolicyBindingArray2[index] = new crpolicy_binding();
        crpolicyBindingArray2[index].policyname = policyname[index];
        crpolicyBindingArray1[index] = (crpolicy_binding) crpolicyBindingArray2[index].get_resource(service);
      }
      return crpolicyBindingArray1;
    }

    private class crpolicy_binding_response : base_response
    {
      public crpolicy_binding[] crpolicy_binding = (crpolicy_binding[]) null;
    }
  }
}
