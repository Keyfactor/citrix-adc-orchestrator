// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.wi.wisite_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.wi
{
  public class wisite_binding : base_resource
  {
    private string sitepathField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.wi.wisite_translationinternalip_binding[] wisite_translationinternalip_bindingField = (com.citrix.netscaler.nitro.resource.config.wi.wisite_translationinternalip_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.wi.wisite_accessmethod_binding[] wisite_accessmethod_bindingField = (com.citrix.netscaler.nitro.resource.config.wi.wisite_accessmethod_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.wi.wisite_farmname_binding[] wisite_farmname_bindingField = (com.citrix.netscaler.nitro.resource.config.wi.wisite_farmname_binding[]) null;

    public string sitepath
    {
      get => this.sitepathField;
      set => this.sitepathField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.wi.wisite_translationinternalip_binding[] wisite_translationinternalip_binding
    {
      get => this.wisite_translationinternalip_bindingField;
      private set => this.wisite_translationinternalip_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.wi.wisite_accessmethod_binding[] wisite_accessmethod_binding
    {
      get => this.wisite_accessmethod_bindingField;
      private set => this.wisite_accessmethod_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.wi.wisite_farmname_binding[] wisite_farmname_binding
    {
      get => this.wisite_farmname_bindingField;
      private set => this.wisite_farmname_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      wisite_binding.wisite_binding_response wisiteBindingResponse = new wisite_binding.wisite_binding_response();
      wisite_binding.wisite_binding_response resource = (wisite_binding.wisite_binding_response) service.get_payload_formatter().string_to_resource(wisiteBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.wisite_binding;
    }

    internal override string get_object_name() => this.sitepath;

    public static wisite_binding get(nitro_service service, string sitepath) => (wisite_binding) new wisite_binding()
    {
      sitepath = sitepath
    }.get_resource(service);

    public static wisite_binding[] get(nitro_service service, string[] sitepath)
    {
      if (sitepath == null || sitepath.Length <= 0)
        return (wisite_binding[]) null;
      wisite_binding[] wisiteBindingArray1 = new wisite_binding[sitepath.Length];
      wisite_binding[] wisiteBindingArray2 = new wisite_binding[sitepath.Length];
      for (int index = 0; index < sitepath.Length; ++index)
      {
        wisiteBindingArray2[index] = new wisite_binding();
        wisiteBindingArray2[index].sitepath = sitepath[index];
        wisiteBindingArray1[index] = (wisite_binding) wisiteBindingArray2[index].get_resource(service);
      }
      return wisiteBindingArray1;
    }

    private class wisite_binding_response : base_response
    {
      public wisite_binding[] wisite_binding = (wisite_binding[]) null;
    }
  }
}
