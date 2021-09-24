// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslcipher_sslvserver_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslcipher_sslvserver_binding : base_resource
  {
    private string ciphergroupnameField = (string) null;
    private string vservernameField = (string) null;
    private bool? vserverField = new bool?();
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

    public bool? vserver
    {
      get => this.vserverField;
      set => this.vserverField = value;
    }

    public string vservername
    {
      get => this.vservernameField;
      set => this.vservernameField = value;
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
      sslcipher_sslvserver_binding.sslcipher_sslvserver_binding_response sslvserverBindingResponse = new sslcipher_sslvserver_binding.sslcipher_sslvserver_binding_response();
      sslcipher_sslvserver_binding.sslcipher_sslvserver_binding_response resource = (sslcipher_sslvserver_binding.sslcipher_sslvserver_binding_response) service.get_payload_formatter().string_to_resource(sslvserverBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslcipher_sslvserver_binding;
    }

    internal override string get_object_name() => this.ciphergroupname;

    private class sslcipher_sslvserver_binding_response : base_response
    {
      public sslcipher_sslvserver_binding[] sslcipher_sslvserver_binding = (sslcipher_sslvserver_binding[]) null;
    }

    public static class cipheroperationEnum
    {
      public const string ADD = "ADD";
      public const string REM = "REM";
      public const string ORD = "ORD";
    }
  }
}
