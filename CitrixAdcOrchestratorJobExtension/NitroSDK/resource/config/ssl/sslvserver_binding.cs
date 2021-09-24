// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslvserver_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslvserver_binding : base_resource
  {
    private string vservernameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.ssl.sslvserver_sslpolicy_binding[] sslvserver_sslpolicy_bindingField = (com.citrix.netscaler.nitro.resource.config.ssl.sslvserver_sslpolicy_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.ssl.sslvserver_sslcipher_binding[] sslvserver_sslcipher_bindingField = (com.citrix.netscaler.nitro.resource.config.ssl.sslvserver_sslcipher_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.ssl.sslvserver_ecccurve_binding[] sslvserver_ecccurve_bindingField = (com.citrix.netscaler.nitro.resource.config.ssl.sslvserver_ecccurve_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.ssl.sslvserver_sslcertkey_binding[] sslvserver_sslcertkey_bindingField = (com.citrix.netscaler.nitro.resource.config.ssl.sslvserver_sslcertkey_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.ssl.sslvserver_sslciphersuite_binding[] sslvserver_sslciphersuite_bindingField = (com.citrix.netscaler.nitro.resource.config.ssl.sslvserver_sslciphersuite_binding[]) null;

    public string vservername
    {
      get => this.vservernameField;
      set => this.vservernameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ssl.sslvserver_sslpolicy_binding[] sslvserver_sslpolicy_binding
    {
      get => this.sslvserver_sslpolicy_bindingField;
      private set => this.sslvserver_sslpolicy_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ssl.sslvserver_sslcertkey_binding[] sslvserver_sslcertkey_binding
    {
      get => this.sslvserver_sslcertkey_bindingField;
      private set => this.sslvserver_sslcertkey_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ssl.sslvserver_sslciphersuite_binding[] sslvserver_sslciphersuite_binding
    {
      get => this.sslvserver_sslciphersuite_bindingField;
      private set => this.sslvserver_sslciphersuite_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ssl.sslvserver_ecccurve_binding[] sslvserver_ecccurve_binding
    {
      get => this.sslvserver_ecccurve_bindingField;
      private set => this.sslvserver_ecccurve_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ssl.sslvserver_sslcipher_binding[] sslvserver_sslcipher_binding
    {
      get => this.sslvserver_sslcipher_bindingField;
      private set => this.sslvserver_sslcipher_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslvserver_binding.sslvserver_binding_response sslvserverBindingResponse = new sslvserver_binding.sslvserver_binding_response();
      sslvserver_binding.sslvserver_binding_response resource = (sslvserver_binding.sslvserver_binding_response) service.get_payload_formatter().string_to_resource(sslvserverBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslvserver_binding;
    }

    internal override string get_object_name() => this.vservername;

    public static sslvserver_binding get(
      nitro_service service,
      string vservername)
    {
      return (sslvserver_binding) new sslvserver_binding()
      {
        vservername = vservername
      }.get_resource(service);
    }

    public static sslvserver_binding[] get(
      nitro_service service,
      string[] vservername)
    {
      if (vservername == null || vservername.Length <= 0)
        return (sslvserver_binding[]) null;
      sslvserver_binding[] sslvserverBindingArray1 = new sslvserver_binding[vservername.Length];
      sslvserver_binding[] sslvserverBindingArray2 = new sslvserver_binding[vservername.Length];
      for (int index = 0; index < vservername.Length; ++index)
      {
        sslvserverBindingArray2[index] = new sslvserver_binding();
        sslvserverBindingArray2[index].vservername = vservername[index];
        sslvserverBindingArray1[index] = (sslvserver_binding) sslvserverBindingArray2[index].get_resource(service);
      }
      return sslvserverBindingArray1;
    }

    private class sslvserver_binding_response : base_response
    {
      public sslvserver_binding[] sslvserver_binding = (sslvserver_binding[]) null;
    }
  }
}
