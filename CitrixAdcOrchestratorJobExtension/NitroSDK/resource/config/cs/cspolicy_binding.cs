// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cs.cspolicy_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.cs
{
  public class cspolicy_binding : base_resource
  {
    private string policynameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.cs.cspolicy_cspolicylabel_binding[] cspolicy_cspolicylabel_bindingField = (com.citrix.netscaler.nitro.resource.config.cs.cspolicy_cspolicylabel_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cs.cspolicy_csvserver_binding[] cspolicy_csvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.cs.cspolicy_csvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cs.cspolicy_crvserver_binding[] cspolicy_crvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.cs.cspolicy_crvserver_binding[]) null;

    public string policyname
    {
      get => this.policynameField;
      set => this.policynameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cs.cspolicy_cspolicylabel_binding[] cspolicy_cspolicylabel_binding
    {
      get => this.cspolicy_cspolicylabel_bindingField;
      private set => this.cspolicy_cspolicylabel_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cs.cspolicy_crvserver_binding[] cspolicy_crvserver_binding
    {
      get => this.cspolicy_crvserver_bindingField;
      private set => this.cspolicy_crvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cs.cspolicy_csvserver_binding[] cspolicy_csvserver_binding
    {
      get => this.cspolicy_csvserver_bindingField;
      private set => this.cspolicy_csvserver_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      cspolicy_binding.cspolicy_binding_response cspolicyBindingResponse = new cspolicy_binding.cspolicy_binding_response();
      cspolicy_binding.cspolicy_binding_response resource = (cspolicy_binding.cspolicy_binding_response) service.get_payload_formatter().string_to_resource(cspolicyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.cspolicy_binding;
    }

    internal override string get_object_name() => this.policyname;

    public static cspolicy_binding get(nitro_service service, string policyname) => (cspolicy_binding) new cspolicy_binding()
    {
      policyname = policyname
    }.get_resource(service);

    public static cspolicy_binding[] get(nitro_service service, string[] policyname)
    {
      if (policyname == null || policyname.Length <= 0)
        return (cspolicy_binding[]) null;
      cspolicy_binding[] cspolicyBindingArray1 = new cspolicy_binding[policyname.Length];
      cspolicy_binding[] cspolicyBindingArray2 = new cspolicy_binding[policyname.Length];
      for (int index = 0; index < policyname.Length; ++index)
      {
        cspolicyBindingArray2[index] = new cspolicy_binding();
        cspolicyBindingArray2[index].policyname = policyname[index];
        cspolicyBindingArray1[index] = (cspolicy_binding) cspolicyBindingArray2[index].get_resource(service);
      }
      return cspolicyBindingArray1;
    }

    private class cspolicy_binding_response : base_response
    {
      public cspolicy_binding[] cspolicy_binding = (cspolicy_binding[]) null;
    }
  }
}
