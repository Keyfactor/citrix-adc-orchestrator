// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslcipher_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslcipher_binding : base_resource
  {
    private string ciphergroupnameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.ssl.sslcipher_individualcipher_binding[] sslcipher_individualcipher_bindingField = (com.citrix.netscaler.nitro.resource.config.ssl.sslcipher_individualcipher_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.ssl.sslcipher_sslprofile_binding[] sslcipher_sslprofile_bindingField = (com.citrix.netscaler.nitro.resource.config.ssl.sslcipher_sslprofile_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.ssl.sslcipher_sslciphersuite_binding[] sslcipher_sslciphersuite_bindingField = (com.citrix.netscaler.nitro.resource.config.ssl.sslcipher_sslciphersuite_binding[]) null;

    public string ciphergroupname
    {
      get => this.ciphergroupnameField;
      set => this.ciphergroupnameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ssl.sslcipher_sslciphersuite_binding[] sslcipher_sslciphersuite_binding
    {
      get => this.sslcipher_sslciphersuite_bindingField;
      private set => this.sslcipher_sslciphersuite_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ssl.sslcipher_individualcipher_binding[] sslcipher_individualcipher_binding
    {
      get => this.sslcipher_individualcipher_bindingField;
      private set => this.sslcipher_individualcipher_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ssl.sslcipher_sslprofile_binding[] sslcipher_sslprofile_binding
    {
      get => this.sslcipher_sslprofile_bindingField;
      private set => this.sslcipher_sslprofile_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslcipher_binding.sslcipher_binding_response sslcipherBindingResponse = new sslcipher_binding.sslcipher_binding_response();
      sslcipher_binding.sslcipher_binding_response resource = (sslcipher_binding.sslcipher_binding_response) service.get_payload_formatter().string_to_resource(sslcipherBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslcipher_binding;
    }

    internal override string get_object_name() => this.ciphergroupname;

    public static sslcipher_binding get(
      nitro_service service,
      string ciphergroupname)
    {
      return (sslcipher_binding) new sslcipher_binding()
      {
        ciphergroupname = ciphergroupname
      }.get_resource(service);
    }

    public static sslcipher_binding[] get(
      nitro_service service,
      string[] ciphergroupname)
    {
      if (ciphergroupname == null || ciphergroupname.Length <= 0)
        return (sslcipher_binding[]) null;
      sslcipher_binding[] sslcipherBindingArray1 = new sslcipher_binding[ciphergroupname.Length];
      sslcipher_binding[] sslcipherBindingArray2 = new sslcipher_binding[ciphergroupname.Length];
      for (int index = 0; index < ciphergroupname.Length; ++index)
      {
        sslcipherBindingArray2[index] = new sslcipher_binding();
        sslcipherBindingArray2[index].ciphergroupname = ciphergroupname[index];
        sslcipherBindingArray1[index] = (sslcipher_binding) sslcipherBindingArray2[index].get_resource(service);
      }
      return sslcipherBindingArray1;
    }

    private class sslcipher_binding_response : base_response
    {
      public sslcipher_binding[] sslcipher_binding = (sslcipher_binding[]) null;
    }
  }
}
