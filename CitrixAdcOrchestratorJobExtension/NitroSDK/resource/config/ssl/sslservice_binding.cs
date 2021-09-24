// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslservice_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslservice_binding : base_resource
  {
    private string servicenameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.ssl.sslservice_sslcipher_binding[] sslservice_sslcipher_bindingField = (com.citrix.netscaler.nitro.resource.config.ssl.sslservice_sslcipher_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.ssl.sslservice_ecccurve_binding[] sslservice_ecccurve_bindingField = (com.citrix.netscaler.nitro.resource.config.ssl.sslservice_ecccurve_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.ssl.sslservice_sslpolicy_binding[] sslservice_sslpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.ssl.sslservice_sslpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.ssl.sslservice_sslcertkey_binding[] sslservice_sslcertkey_bindingField = (com.citrix.netscaler.nitro.resource.config.ssl.sslservice_sslcertkey_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.ssl.sslservice_sslciphersuite_binding[] sslservice_sslciphersuite_bindingField = (com.citrix.netscaler.nitro.resource.config.ssl.sslservice_sslciphersuite_binding[]) null;

    public string servicename
    {
      get => this.servicenameField;
      set => this.servicenameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ssl.sslservice_sslciphersuite_binding[] sslservice_sslciphersuite_binding
    {
      get => this.sslservice_sslciphersuite_bindingField;
      private set => this.sslservice_sslciphersuite_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ssl.sslservice_sslcertkey_binding[] sslservice_sslcertkey_binding
    {
      get => this.sslservice_sslcertkey_bindingField;
      private set => this.sslservice_sslcertkey_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ssl.sslservice_sslcipher_binding[] sslservice_sslcipher_binding
    {
      get => this.sslservice_sslcipher_bindingField;
      private set => this.sslservice_sslcipher_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ssl.sslservice_ecccurve_binding[] sslservice_ecccurve_binding
    {
      get => this.sslservice_ecccurve_bindingField;
      private set => this.sslservice_ecccurve_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ssl.sslservice_sslpolicy_binding[] sslservice_sslpolicy_binding
    {
      get => this.sslservice_sslpolicy_bindingField;
      private set => this.sslservice_sslpolicy_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslservice_binding.sslservice_binding_response sslserviceBindingResponse = new sslservice_binding.sslservice_binding_response();
      sslservice_binding.sslservice_binding_response resource = (sslservice_binding.sslservice_binding_response) service.get_payload_formatter().string_to_resource(sslserviceBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslservice_binding;
    }

    internal override string get_object_name() => this.servicename;

    public static sslservice_binding get(
      nitro_service service,
      string servicename)
    {
      return (sslservice_binding) new sslservice_binding()
      {
        servicename = servicename
      }.get_resource(service);
    }

    public static sslservice_binding[] get(
      nitro_service service,
      string[] servicename)
    {
      if (servicename == null || servicename.Length <= 0)
        return (sslservice_binding[]) null;
      sslservice_binding[] sslserviceBindingArray1 = new sslservice_binding[servicename.Length];
      sslservice_binding[] sslserviceBindingArray2 = new sslservice_binding[servicename.Length];
      for (int index = 0; index < servicename.Length; ++index)
      {
        sslserviceBindingArray2[index] = new sslservice_binding();
        sslserviceBindingArray2[index].servicename = servicename[index];
        sslserviceBindingArray1[index] = (sslservice_binding) sslserviceBindingArray2[index].get_resource(service);
      }
      return sslserviceBindingArray1;
    }

    private class sslservice_binding_response : base_response
    {
      public sslservice_binding[] sslservice_binding = (sslservice_binding[]) null;
    }
  }
}
