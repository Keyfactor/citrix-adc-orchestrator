// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslcertkey_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslcertkey_binding : base_resource
  {
    private string certkeyField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.ssl.sslcertkey_sslvserver_binding[] sslcertkey_sslvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.ssl.sslcertkey_sslvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.ssl.sslcertkey_sslocspresponder_binding[] sslcertkey_sslocspresponder_bindingField = (com.citrix.netscaler.nitro.resource.config.ssl.sslcertkey_sslocspresponder_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.ssl.sslcertkey_service_binding[] sslcertkey_service_bindingField = (com.citrix.netscaler.nitro.resource.config.ssl.sslcertkey_service_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.ssl.sslcertkey_crldistribution_binding[] sslcertkey_crldistribution_bindingField = (com.citrix.netscaler.nitro.resource.config.ssl.sslcertkey_crldistribution_binding[]) null;

    public string certkey
    {
      get => this.certkeyField;
      set => this.certkeyField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ssl.sslcertkey_crldistribution_binding[] sslcertkey_crldistribution_binding
    {
      get => this.sslcertkey_crldistribution_bindingField;
      private set => this.sslcertkey_crldistribution_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ssl.sslcertkey_sslvserver_binding[] sslcertkey_sslvserver_binding
    {
      get => this.sslcertkey_sslvserver_bindingField;
      private set => this.sslcertkey_sslvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ssl.sslcertkey_sslocspresponder_binding[] sslcertkey_sslocspresponder_binding
    {
      get => this.sslcertkey_sslocspresponder_bindingField;
      private set => this.sslcertkey_sslocspresponder_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ssl.sslcertkey_service_binding[] sslcertkey_service_binding
    {
      get => this.sslcertkey_service_bindingField;
      private set => this.sslcertkey_service_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslcertkey_binding.sslcertkey_binding_response sslcertkeyBindingResponse = new sslcertkey_binding.sslcertkey_binding_response();
      sslcertkey_binding.sslcertkey_binding_response resource = (sslcertkey_binding.sslcertkey_binding_response) service.get_payload_formatter().string_to_resource(sslcertkeyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslcertkey_binding;
    }

    internal override string get_object_name() => this.certkey;

    public static sslcertkey_binding get(nitro_service service, string certkey) => (sslcertkey_binding) new sslcertkey_binding()
    {
      certkey = certkey
    }.get_resource(service);

    public static sslcertkey_binding[] get(
      nitro_service service,
      string[] certkey)
    {
      if (certkey == null || certkey.Length <= 0)
        return (sslcertkey_binding[]) null;
      sslcertkey_binding[] sslcertkeyBindingArray1 = new sslcertkey_binding[certkey.Length];
      sslcertkey_binding[] sslcertkeyBindingArray2 = new sslcertkey_binding[certkey.Length];
      for (int index = 0; index < certkey.Length; ++index)
      {
        sslcertkeyBindingArray2[index] = new sslcertkey_binding();
        sslcertkeyBindingArray2[index].certkey = certkey[index];
        sslcertkeyBindingArray1[index] = (sslcertkey_binding) sslcertkeyBindingArray2[index].get_resource(service);
      }
      return sslcertkeyBindingArray1;
    }

    private class sslcertkey_binding_response : base_response
    {
      public sslcertkey_binding[] sslcertkey_binding = (sslcertkey_binding[]) null;
    }
  }
}
