// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nsappflowparam
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nsappflowparam : base_resource
  {
    private long? templaterefreshField = new long?();
    private uint? udppmtuField = new uint?();
    private string httpurlField = (string) null;
    private string httpcookieField = (string) null;
    private string httprefererField = (string) null;
    private string httpmethodField = (string) null;
    private string httphostField = (string) null;
    private string httpuseragentField = (string) null;
    private string clienttrafficonlyField = (string) null;

    public long? templaterefresh
    {
      get => this.templaterefreshField;
      set => this.templaterefreshField = value;
    }

    public uint? udppmtu
    {
      get => this.udppmtuField;
      set => this.udppmtuField = value;
    }

    public string httpurl
    {
      get => this.httpurlField;
      set => this.httpurlField = value;
    }

    public string httpcookie
    {
      get => this.httpcookieField;
      set => this.httpcookieField = value;
    }

    public string httpreferer
    {
      get => this.httprefererField;
      set => this.httprefererField = value;
    }

    public string httpmethod
    {
      get => this.httpmethodField;
      set => this.httpmethodField = value;
    }

    public string httphost
    {
      get => this.httphostField;
      set => this.httphostField = value;
    }

    public string httpuseragent
    {
      get => this.httpuseragentField;
      set => this.httpuseragentField = value;
    }

    public string clienttrafficonly
    {
      get => this.clienttrafficonlyField;
      set => this.clienttrafficonlyField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nsappflowparam[] nsappflowparamArray = new nsappflowparam[1];
      nsappflowparam.nsappflowparam_response nsappflowparamResponse = new nsappflowparam.nsappflowparam_response();
      nsappflowparam.nsappflowparam_response resource = (nsappflowparam.nsappflowparam_response) service.get_payload_formatter().string_to_resource(nsappflowparamResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      nsappflowparamArray[0] = resource.nsappflowparam;
      return (base_resource[]) nsappflowparamArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, nsappflowparam resource) => new nsappflowparam()
    {
      templaterefresh = resource.templaterefresh,
      udppmtu = resource.udppmtu,
      httpurl = resource.httpurl,
      httpcookie = resource.httpcookie,
      httpreferer = resource.httpreferer,
      httpmethod = resource.httpmethod,
      httphost = resource.httphost,
      httpuseragent = resource.httpuseragent,
      clienttrafficonly = resource.clienttrafficonly
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      nsappflowparam resource,
      string[] args)
    {
      return new nsappflowparam().unset_resource(client, args);
    }

    public static nsappflowparam get(nitro_service service) => ((nsappflowparam[]) new nsappflowparam().get_resources(service, (options) null))[0];

    public static nsappflowparam get(nitro_service service, options option) => ((nsappflowparam[]) new nsappflowparam().get_resources(service, option))[0];

    private class nsappflowparam_response : base_response
    {
      public nsappflowparam nsappflowparam = (nsappflowparam) null;
    }

    public static class httprefererEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class clienttrafficonlyEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class httpmethodEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class httpcookieEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class httpurlEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class httpuseragentEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class httphostEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
