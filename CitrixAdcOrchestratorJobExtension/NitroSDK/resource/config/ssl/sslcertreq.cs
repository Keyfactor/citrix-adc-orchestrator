// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslcertreq
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslcertreq : base_resource
  {
    private string reqfileField = (string) null;
    private string keyfileField = (string) null;
    private string fipskeynameField = (string) null;
    private string keyformField = (string) null;
    private string pempassphraseField = (string) null;
    private string countrynameField = (string) null;
    private string statenameField = (string) null;
    private string organizationnameField = (string) null;
    private string organizationunitnameField = (string) null;
    private string localitynameField = (string) null;
    private string commonnameField = (string) null;
    private string emailaddressField = (string) null;
    private string challengepasswordField = (string) null;
    private string companynameField = (string) null;

    public string reqfile
    {
      get => this.reqfileField;
      set => this.reqfileField = value;
    }

    public string keyfile
    {
      get => this.keyfileField;
      set => this.keyfileField = value;
    }

    public string fipskeyname
    {
      get => this.fipskeynameField;
      set => this.fipskeynameField = value;
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

    public string countryname
    {
      get => this.countrynameField;
      set => this.countrynameField = value;
    }

    public string statename
    {
      get => this.statenameField;
      set => this.statenameField = value;
    }

    public string organizationname
    {
      get => this.organizationnameField;
      set => this.organizationnameField = value;
    }

    public string organizationunitname
    {
      get => this.organizationunitnameField;
      set => this.organizationunitnameField = value;
    }

    public string localityname
    {
      get => this.localitynameField;
      set => this.localitynameField = value;
    }

    public string commonname
    {
      get => this.commonnameField;
      set => this.commonnameField = value;
    }

    public string emailaddress
    {
      get => this.emailaddressField;
      set => this.emailaddressField = value;
    }

    public string challengepassword
    {
      get => this.challengepasswordField;
      set => this.challengepasswordField = value;
    }

    public string companyname
    {
      get => this.companynameField;
      set => this.companynameField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslcertreq[] sslcertreqArray = new sslcertreq[1];
      sslcertreq.sslcertreq_response sslcertreqResponse = new sslcertreq.sslcertreq_response();
      sslcertreq.sslcertreq_response resource = (sslcertreq.sslcertreq_response) service.get_payload_formatter().string_to_resource(sslcertreqResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      sslcertreqArray[0] = resource.sslcertreq;
      return (base_resource[]) sslcertreqArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response create(nitro_service client, sslcertreq resource) => new sslcertreq()
    {
      reqfile = resource.reqfile,
      keyfile = resource.keyfile,
      fipskeyname = resource.fipskeyname,
      keyform = resource.keyform,
      pempassphrase = resource.pempassphrase,
      countryname = resource.countryname,
      statename = resource.statename,
      organizationname = resource.organizationname,
      organizationunitname = resource.organizationunitname,
      localityname = resource.localityname,
      commonname = resource.commonname,
      emailaddress = resource.emailaddress,
      challengepassword = resource.challengepassword,
      companyname = resource.companyname
    }.perform_operation_byaction(client, nameof (create));

    private class sslcertreq_response : base_response
    {
      public sslcertreq sslcertreq = (sslcertreq) null;
    }

    public static class keyformEnum
    {
      public const string DER = "DER";
      public const string PEM = "PEM";
    }
  }
}
