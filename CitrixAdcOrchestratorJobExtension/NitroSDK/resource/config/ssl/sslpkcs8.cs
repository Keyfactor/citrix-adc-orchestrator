// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslpkcs8
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslpkcs8 : base_resource
  {
    private string pkcs8fileField = (string) null;
    private string keyfileField = (string) null;
    private string keyformField = (string) null;
    private string passwordField = (string) null;

    public string pkcs8file
    {
      get => this.pkcs8fileField;
      set => this.pkcs8fileField = value;
    }

    public string keyfile
    {
      get => this.keyfileField;
      set => this.keyfileField = value;
    }

    public string keyform
    {
      get => this.keyformField;
      set => this.keyformField = value;
    }

    public string password
    {
      get => this.passwordField;
      set => this.passwordField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslpkcs8[] sslpkcs8Array = new sslpkcs8[1];
      sslpkcs8.sslpkcs8_response sslpkcs8Response = new sslpkcs8.sslpkcs8_response();
      sslpkcs8.sslpkcs8_response resource = (sslpkcs8.sslpkcs8_response) service.get_payload_formatter().string_to_resource(sslpkcs8Response.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      sslpkcs8Array[0] = resource.sslpkcs8;
      return (base_resource[]) sslpkcs8Array;
    }

    internal override string get_object_name() => (string) null;

    public static base_response convert(nitro_service client, sslpkcs8 resource) => new sslpkcs8()
    {
      pkcs8file = resource.pkcs8file,
      keyfile = resource.keyfile,
      keyform = resource.keyform,
      password = resource.password
    }.perform_operation_byaction(client, nameof (convert));

    private class sslpkcs8_response : base_response
    {
      public sslpkcs8 sslpkcs8 = (sslpkcs8) null;
    }

    public static class keyformEnum
    {
      public const string DER = "DER";
      public const string PEM = "PEM";
    }
  }
}
