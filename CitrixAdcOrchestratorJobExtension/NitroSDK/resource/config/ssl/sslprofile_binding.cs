// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslprofile_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslprofile_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.ssl.sslprofile_sslcipher_binding[] sslprofile_sslcipher_bindingField = (com.citrix.netscaler.nitro.resource.config.ssl.sslprofile_sslcipher_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.ssl.sslprofile_ecccurve_binding[] sslprofile_ecccurve_bindingField = (com.citrix.netscaler.nitro.resource.config.ssl.sslprofile_ecccurve_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.ssl.sslprofile_sslvserver_binding[] sslprofile_sslvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.ssl.sslprofile_sslvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.ssl.sslprofile_sslciphersuite_binding[] sslprofile_sslciphersuite_bindingField = (com.citrix.netscaler.nitro.resource.config.ssl.sslprofile_sslciphersuite_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ssl.sslprofile_ecccurve_binding[] sslprofile_ecccurve_binding
    {
      get => this.sslprofile_ecccurve_bindingField;
      private set => this.sslprofile_ecccurve_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ssl.sslprofile_sslciphersuite_binding[] sslprofile_sslciphersuite_binding
    {
      get => this.sslprofile_sslciphersuite_bindingField;
      private set => this.sslprofile_sslciphersuite_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ssl.sslprofile_sslvserver_binding[] sslprofile_sslvserver_binding
    {
      get => this.sslprofile_sslvserver_bindingField;
      private set => this.sslprofile_sslvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ssl.sslprofile_sslcipher_binding[] sslprofile_sslcipher_binding
    {
      get => this.sslprofile_sslcipher_bindingField;
      private set => this.sslprofile_sslcipher_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslprofile_binding.sslprofile_binding_response sslprofileBindingResponse = new sslprofile_binding.sslprofile_binding_response();
      sslprofile_binding.sslprofile_binding_response resource = (sslprofile_binding.sslprofile_binding_response) service.get_payload_formatter().string_to_resource(sslprofileBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslprofile_binding;
    }

    internal override string get_object_name() => this.name;

    public static sslprofile_binding get(nitro_service service, string name) => (sslprofile_binding) new sslprofile_binding()
    {
      name = name
    }.get_resource(service);

    public static sslprofile_binding[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (sslprofile_binding[]) null;
      sslprofile_binding[] sslprofileBindingArray1 = new sslprofile_binding[name.Length];
      sslprofile_binding[] sslprofileBindingArray2 = new sslprofile_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        sslprofileBindingArray2[index] = new sslprofile_binding();
        sslprofileBindingArray2[index].name = name[index];
        sslprofileBindingArray1[index] = (sslprofile_binding) sslprofileBindingArray2[index].get_resource(service);
      }
      return sslprofileBindingArray1;
    }

    private class sslprofile_binding_response : base_response
    {
      public sslprofile_binding[] sslprofile_binding = (sslprofile_binding[]) null;
    }
  }
}
