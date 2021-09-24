// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslpkcs12
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslpkcs12 : base_resource
  {
    private string outfileField = (string) null;
    private bool? ImportField = new bool?();
    private string pkcs12fileField = (string) null;
    private bool? desField = new bool?();
    private bool? des3Field = new bool?();
    private bool? exportField = new bool?();
    private string certfileField = (string) null;
    private string keyfileField = (string) null;
    private string passwordField = (string) null;
    private string pempassphraseField = (string) null;

    public string outfile
    {
      get => this.outfileField;
      set => this.outfileField = value;
    }

    public bool? Import
    {
      get => this.ImportField;
      set => this.ImportField = value;
    }

    public string pkcs12file
    {
      get => this.pkcs12fileField;
      set => this.pkcs12fileField = value;
    }

    public bool? des
    {
      get => this.desField;
      set => this.desField = value;
    }

    public bool? des3
    {
      get => this.des3Field;
      set => this.des3Field = value;
    }

    public bool? export
    {
      get => this.exportField;
      set => this.exportField = value;
    }

    public string certfile
    {
      get => this.certfileField;
      set => this.certfileField = value;
    }

    public string keyfile
    {
      get => this.keyfileField;
      set => this.keyfileField = value;
    }

    public string password
    {
      get => this.passwordField;
      set => this.passwordField = value;
    }

    public string pempassphrase
    {
      get => this.pempassphraseField;
      set => this.pempassphraseField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslpkcs12[] sslpkcs12Array = new sslpkcs12[1];
      sslpkcs12.sslpkcs12_response sslpkcs12Response = new sslpkcs12.sslpkcs12_response();
      sslpkcs12.sslpkcs12_response resource = (sslpkcs12.sslpkcs12_response) service.get_payload_formatter().string_to_resource(sslpkcs12Response.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      sslpkcs12Array[0] = resource.sslpkcs12;
      return (base_resource[]) sslpkcs12Array;
    }

    internal override string get_object_name() => (string) null;

    public static base_response convert(nitro_service client, sslpkcs12 resource) => new sslpkcs12()
    {
      outfile = resource.outfile,
      Import = resource.Import,
      pkcs12file = resource.pkcs12file,
      des = resource.des,
      des3 = resource.des3,
      export = resource.export,
      certfile = resource.certfile,
      keyfile = resource.keyfile,
      password = resource.password,
      pempassphrase = resource.pempassphrase
    }.perform_operation_byaction(client, nameof (convert));

    private class sslpkcs12_response : base_response
    {
      public sslpkcs12 sslpkcs12 = (sslpkcs12) null;
    }
  }
}
