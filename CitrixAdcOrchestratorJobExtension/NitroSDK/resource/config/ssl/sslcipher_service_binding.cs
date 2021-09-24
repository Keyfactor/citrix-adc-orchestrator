// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslcipher_service_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslcipher_service_binding : base_resource
  {
    private string ciphergroupnameField = (string) null;
    private string servicenameField = (string) null;
    private bool? serviceField = new bool?();
    private string servicegroupnameField = (string) null;
    private bool? servicegroupField = new bool?();
    private string cipheroperationField = (string) null;
    private string ciphgrpalsField = (string) null;
    private uint? cipherpriorityField = new uint?();

    public uint? cipherpriority
    {
      get => this.cipherpriorityField;
      set => this.cipherpriorityField = value;
    }

    public string ciphgrpals
    {
      get => this.ciphgrpalsField;
      set => this.ciphgrpalsField = value;
    }

    public string servicegroupname
    {
      get => this.servicegroupnameField;
      set => this.servicegroupnameField = value;
    }

    public bool? servicegroup
    {
      get => this.servicegroupField;
      set => this.servicegroupField = value;
    }

    public bool? service
    {
      get => this.serviceField;
      set => this.serviceField = value;
    }

    public string servicename
    {
      get => this.servicenameField;
      set => this.servicenameField = value;
    }

    public string ciphergroupname
    {
      get => this.ciphergroupnameField;
      set => this.ciphergroupnameField = value;
    }

    public string cipheroperation
    {
      get => this.cipheroperationField;
      set => this.cipheroperationField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslcipher_service_binding.sslcipher_service_binding_response serviceBindingResponse = new sslcipher_service_binding.sslcipher_service_binding_response();
      sslcipher_service_binding.sslcipher_service_binding_response resource = (sslcipher_service_binding.sslcipher_service_binding_response) service.get_payload_formatter().string_to_resource(serviceBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslcipher_service_binding;
    }

    internal override string get_object_name() => this.ciphergroupname;

    private class sslcipher_service_binding_response : base_response
    {
      public sslcipher_service_binding[] sslcipher_service_binding = (sslcipher_service_binding[]) null;
    }

    public static class cipheroperationEnum
    {
      public const string ADD = "ADD";
      public const string REM = "REM";
      public const string ORD = "ORD";
    }
  }
}
