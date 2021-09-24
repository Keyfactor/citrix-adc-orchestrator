// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslcert
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslcert : base_resource
  {
    private string certfileField = (string) null;
    private string reqfileField = (string) null;
    private string certtypeField = (string) null;
    private string keyfileField = (string) null;
    private string keyformField = (string) null;
    private string pempassphraseField = (string) null;
    private uint? daysField = new uint?();
    private string certformField = (string) null;
    private string cacertField = (string) null;
    private string cacertformField = (string) null;
    private string cakeyField = (string) null;
    private string cakeyformField = (string) null;
    private string caserialField = (string) null;

    public string certfile
    {
      get => this.certfileField;
      set => this.certfileField = value;
    }

    public string reqfile
    {
      get => this.reqfileField;
      set => this.reqfileField = value;
    }

    public string certtype
    {
      get => this.certtypeField;
      set => this.certtypeField = value;
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

    public string pempassphrase
    {
      get => this.pempassphraseField;
      set => this.pempassphraseField = value;
    }

    public uint? days
    {
      get => this.daysField;
      set => this.daysField = value;
    }

    public string certform
    {
      get => this.certformField;
      set => this.certformField = value;
    }

    public string cacert
    {
      get => this.cacertField;
      set => this.cacertField = value;
    }

    public string cacertform
    {
      get => this.cacertformField;
      set => this.cacertformField = value;
    }

    public string cakey
    {
      get => this.cakeyField;
      set => this.cakeyField = value;
    }

    public string cakeyform
    {
      get => this.cakeyformField;
      set => this.cakeyformField = value;
    }

    public string caserial
    {
      get => this.caserialField;
      set => this.caserialField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslcert[] sslcertArray = new sslcert[1];
      sslcert.sslcert_response sslcertResponse = new sslcert.sslcert_response();
      sslcert.sslcert_response resource = (sslcert.sslcert_response) service.get_payload_formatter().string_to_resource(sslcertResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      sslcertArray[0] = resource.sslcert;
      return (base_resource[]) sslcertArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response create(nitro_service client, sslcert resource) => new sslcert()
    {
      certfile = resource.certfile,
      reqfile = resource.reqfile,
      certtype = resource.certtype,
      keyfile = resource.keyfile,
      keyform = resource.keyform,
      pempassphrase = resource.pempassphrase,
      days = resource.days,
      certform = resource.certform,
      cacert = resource.cacert,
      cacertform = resource.cacertform,
      cakey = resource.cakey,
      cakeyform = resource.cakeyform,
      caserial = resource.caserial
    }.perform_operation_byaction(client, nameof (create));

    private class sslcert_response : base_response
    {
      public sslcert sslcert = (sslcert) null;
    }

    public static class keyformEnum
    {
      public const string DER = "DER";
      public const string PEM = "PEM";
    }

    public static class cacertformEnum
    {
      public const string DER = "DER";
      public const string PEM = "PEM";
    }

    public static class certtypeEnum
    {
      public const string ROOT_CERT = "ROOT_CERT";
      public const string INTM_CERT = "INTM_CERT";
      public const string CLNT_CERT = "CLNT_CERT";
      public const string SRVR_CERT = "SRVR_CERT";
    }

    public static class certformEnum
    {
      public const string DER = "DER";
      public const string PEM = "PEM";
    }

    public static class cakeyformEnum
    {
      public const string DER = "DER";
      public const string PEM = "PEM";
    }
  }
}
