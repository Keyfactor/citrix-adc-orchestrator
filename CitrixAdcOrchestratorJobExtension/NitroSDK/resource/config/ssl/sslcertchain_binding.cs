// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslcertchain_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslcertchain_binding : base_resource
  {
    private string certkeynameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.ssl.sslcertchain_sslcertkey_binding[] sslcertchain_sslcertkey_bindingField = (com.citrix.netscaler.nitro.resource.config.ssl.sslcertchain_sslcertkey_binding[]) null;

    public string certkeyname
    {
      get => this.certkeynameField;
      set => this.certkeynameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ssl.sslcertchain_sslcertkey_binding[] sslcertchain_sslcertkey_binding
    {
      get => this.sslcertchain_sslcertkey_bindingField;
      private set => this.sslcertchain_sslcertkey_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslcertchain_binding.sslcertchain_binding_response sslcertchainBindingResponse = new sslcertchain_binding.sslcertchain_binding_response();
      sslcertchain_binding.sslcertchain_binding_response resource = (sslcertchain_binding.sslcertchain_binding_response) service.get_payload_formatter().string_to_resource(sslcertchainBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslcertchain_binding;
    }

    internal override string get_object_name() => this.certkeyname;

    public static sslcertchain_binding get(
      nitro_service service,
      string certkeyname)
    {
      return (sslcertchain_binding) new sslcertchain_binding()
      {
        certkeyname = certkeyname
      }.get_resource(service);
    }

    public static sslcertchain_binding[] get(
      nitro_service service,
      string[] certkeyname)
    {
      if (certkeyname == null || certkeyname.Length <= 0)
        return (sslcertchain_binding[]) null;
      sslcertchain_binding[] sslcertchainBindingArray1 = new sslcertchain_binding[certkeyname.Length];
      sslcertchain_binding[] sslcertchainBindingArray2 = new sslcertchain_binding[certkeyname.Length];
      for (int index = 0; index < certkeyname.Length; ++index)
      {
        sslcertchainBindingArray2[index] = new sslcertchain_binding();
        sslcertchainBindingArray2[index].certkeyname = certkeyname[index];
        sslcertchainBindingArray1[index] = (sslcertchain_binding) sslcertchainBindingArray2[index].get_resource(service);
      }
      return sslcertchainBindingArray1;
    }

    private class sslcertchain_binding_response : base_response
    {
      public sslcertchain_binding[] sslcertchain_binding = (sslcertchain_binding[]) null;
    }
  }
}
