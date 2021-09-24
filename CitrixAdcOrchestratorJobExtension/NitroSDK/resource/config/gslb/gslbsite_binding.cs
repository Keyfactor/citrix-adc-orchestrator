// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.gslb.gslbsite_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.gslb
{
  public class gslbsite_binding : base_resource
  {
    private string sitenameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.gslb.gslbsite_gslbservice_binding[] gslbsite_gslbservice_bindingField = (com.citrix.netscaler.nitro.resource.config.gslb.gslbsite_gslbservice_binding[]) null;

    public string sitename
    {
      get => this.sitenameField;
      set => this.sitenameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.gslb.gslbsite_gslbservice_binding[] gslbsite_gslbservice_binding
    {
      get => this.gslbsite_gslbservice_bindingField;
      private set => this.gslbsite_gslbservice_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      gslbsite_binding.gslbsite_binding_response gslbsiteBindingResponse = new gslbsite_binding.gslbsite_binding_response();
      gslbsite_binding.gslbsite_binding_response resource = (gslbsite_binding.gslbsite_binding_response) service.get_payload_formatter().string_to_resource(gslbsiteBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.gslbsite_binding;
    }

    internal override string get_object_name() => this.sitename;

    public static gslbsite_binding get(nitro_service service, string sitename) => (gslbsite_binding) new gslbsite_binding()
    {
      sitename = sitename
    }.get_resource(service);

    public static gslbsite_binding[] get(nitro_service service, string[] sitename)
    {
      if (sitename == null || sitename.Length <= 0)
        return (gslbsite_binding[]) null;
      gslbsite_binding[] gslbsiteBindingArray1 = new gslbsite_binding[sitename.Length];
      gslbsite_binding[] gslbsiteBindingArray2 = new gslbsite_binding[sitename.Length];
      for (int index = 0; index < sitename.Length; ++index)
      {
        gslbsiteBindingArray2[index] = new gslbsite_binding();
        gslbsiteBindingArray2[index].sitename = sitename[index];
        gslbsiteBindingArray1[index] = (gslbsite_binding) gslbsiteBindingArray2[index].get_resource(service);
      }
      return gslbsiteBindingArray1;
    }

    private class gslbsite_binding_response : base_response
    {
      public gslbsite_binding[] gslbsite_binding = (gslbsite_binding[]) null;
    }
  }
}
