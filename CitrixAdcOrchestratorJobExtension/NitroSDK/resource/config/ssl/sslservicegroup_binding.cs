// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslservicegroup_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslservicegroup_binding : base_resource
  {
    private string servicegroupnameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.ssl.sslservicegroup_sslcipher_binding[] sslservicegroup_sslcipher_bindingField = (com.citrix.netscaler.nitro.resource.config.ssl.sslservicegroup_sslcipher_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.ssl.sslservicegroup_ecccurve_binding[] sslservicegroup_ecccurve_bindingField = (com.citrix.netscaler.nitro.resource.config.ssl.sslservicegroup_ecccurve_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.ssl.sslservicegroup_sslcertkey_binding[] sslservicegroup_sslcertkey_bindingField = (com.citrix.netscaler.nitro.resource.config.ssl.sslservicegroup_sslcertkey_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.ssl.sslservicegroup_sslciphersuite_binding[] sslservicegroup_sslciphersuite_bindingField = (com.citrix.netscaler.nitro.resource.config.ssl.sslservicegroup_sslciphersuite_binding[]) null;

    public string servicegroupname
    {
      get => this.servicegroupnameField;
      set => this.servicegroupnameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ssl.sslservicegroup_sslcipher_binding[] sslservicegroup_sslcipher_binding
    {
      get => this.sslservicegroup_sslcipher_bindingField;
      private set => this.sslservicegroup_sslcipher_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ssl.sslservicegroup_sslciphersuite_binding[] sslservicegroup_sslciphersuite_binding
    {
      get => this.sslservicegroup_sslciphersuite_bindingField;
      private set => this.sslservicegroup_sslciphersuite_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ssl.sslservicegroup_ecccurve_binding[] sslservicegroup_ecccurve_binding
    {
      get => this.sslservicegroup_ecccurve_bindingField;
      private set => this.sslservicegroup_ecccurve_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ssl.sslservicegroup_sslcertkey_binding[] sslservicegroup_sslcertkey_binding
    {
      get => this.sslservicegroup_sslcertkey_bindingField;
      private set => this.sslservicegroup_sslcertkey_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslservicegroup_binding.sslservicegroup_binding_response sslservicegroupBindingResponse = new sslservicegroup_binding.sslservicegroup_binding_response();
      sslservicegroup_binding.sslservicegroup_binding_response resource = (sslservicegroup_binding.sslservicegroup_binding_response) service.get_payload_formatter().string_to_resource(sslservicegroupBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslservicegroup_binding;
    }

    internal override string get_object_name() => this.servicegroupname;

    public static sslservicegroup_binding get(
      nitro_service service,
      string servicegroupname)
    {
      return (sslservicegroup_binding) new sslservicegroup_binding()
      {
        servicegroupname = servicegroupname
      }.get_resource(service);
    }

    public static sslservicegroup_binding[] get(
      nitro_service service,
      string[] servicegroupname)
    {
      if (servicegroupname == null || servicegroupname.Length <= 0)
        return (sslservicegroup_binding[]) null;
      sslservicegroup_binding[] sslservicegroupBindingArray1 = new sslservicegroup_binding[servicegroupname.Length];
      sslservicegroup_binding[] sslservicegroupBindingArray2 = new sslservicegroup_binding[servicegroupname.Length];
      for (int index = 0; index < servicegroupname.Length; ++index)
      {
        sslservicegroupBindingArray2[index] = new sslservicegroup_binding();
        sslservicegroupBindingArray2[index].servicegroupname = servicegroupname[index];
        sslservicegroupBindingArray1[index] = (sslservicegroup_binding) sslservicegroupBindingArray2[index].get_resource(service);
      }
      return sslservicegroupBindingArray1;
    }

    private class sslservicegroup_binding_response : base_response
    {
      public sslservicegroup_binding[] sslservicegroup_binding = (sslservicegroup_binding[]) null;
    }
  }
}
