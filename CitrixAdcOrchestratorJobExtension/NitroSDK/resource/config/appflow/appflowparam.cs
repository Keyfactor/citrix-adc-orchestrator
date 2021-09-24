// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.appflow.appflowparam
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.appflow
{
  public class appflowparam : base_resource
  {
    private long? templaterefreshField = new long?();
    private long? appnamerefreshField = new long?();
    private long? flowrecordintervalField = new long?();
    private long? securityinsightrecordintervalField = new long?();
    private uint? udppmtuField = new uint?();
    private string httpurlField = (string) null;
    private string aaausernameField = (string) null;
    private string httpcookieField = (string) null;
    private string httprefererField = (string) null;
    private string httpmethodField = (string) null;
    private string httphostField = (string) null;
    private string httpuseragentField = (string) null;
    private string clienttrafficonlyField = (string) null;
    private string httpcontenttypeField = (string) null;
    private string httpauthorizationField = (string) null;
    private string httpviaField = (string) null;
    private string httpxforwardedforField = (string) null;
    private string httplocationField = (string) null;
    private string httpsetcookieField = (string) null;
    private string httpsetcookie2Field = (string) null;
    private string connectionchainingField = (string) null;
    private string httpdomainField = (string) null;
    private string skipcacheredirectionhttptransactionField = (string) null;
    private string identifiernameField = (string) null;
    private string identifiersessionnameField = (string) null;
    private uint? observationdomainidField = new uint?();
    private string observationdomainnameField = (string) null;
    private string securityinsighttrafficField = (string) null;
    private string[] builtinField = (string[]) null;

    public long? templaterefresh
    {
      get => this.templaterefreshField;
      set => this.templaterefreshField = value;
    }

    public long? appnamerefresh
    {
      get => this.appnamerefreshField;
      set => this.appnamerefreshField = value;
    }

    public long? flowrecordinterval
    {
      get => this.flowrecordintervalField;
      set => this.flowrecordintervalField = value;
    }

    public long? securityinsightrecordinterval
    {
      get => this.securityinsightrecordintervalField;
      set => this.securityinsightrecordintervalField = value;
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

    public string aaausername
    {
      get => this.aaausernameField;
      set => this.aaausernameField = value;
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

    public string httpcontenttype
    {
      get => this.httpcontenttypeField;
      set => this.httpcontenttypeField = value;
    }

    public string httpauthorization
    {
      get => this.httpauthorizationField;
      set => this.httpauthorizationField = value;
    }

    public string httpvia
    {
      get => this.httpviaField;
      set => this.httpviaField = value;
    }

    public string httpxforwardedfor
    {
      get => this.httpxforwardedforField;
      set => this.httpxforwardedforField = value;
    }

    public string httplocation
    {
      get => this.httplocationField;
      set => this.httplocationField = value;
    }

    public string httpsetcookie
    {
      get => this.httpsetcookieField;
      set => this.httpsetcookieField = value;
    }

    public string httpsetcookie2
    {
      get => this.httpsetcookie2Field;
      set => this.httpsetcookie2Field = value;
    }

    public string connectionchaining
    {
      get => this.connectionchainingField;
      set => this.connectionchainingField = value;
    }

    public string httpdomain
    {
      get => this.httpdomainField;
      set => this.httpdomainField = value;
    }

    public string skipcacheredirectionhttptransaction
    {
      get => this.skipcacheredirectionhttptransactionField;
      set => this.skipcacheredirectionhttptransactionField = value;
    }

    public string identifiername
    {
      get => this.identifiernameField;
      set => this.identifiernameField = value;
    }

    public string identifiersessionname
    {
      get => this.identifiersessionnameField;
      set => this.identifiersessionnameField = value;
    }

    public uint? observationdomainid
    {
      get => this.observationdomainidField;
      set => this.observationdomainidField = value;
    }

    public string observationdomainname
    {
      get => this.observationdomainnameField;
      set => this.observationdomainnameField = value;
    }

    public string securityinsighttraffic
    {
      get => this.securityinsighttrafficField;
      set => this.securityinsighttrafficField = value;
    }

    public string[] builtin
    {
      get => this.builtinField;
      private set => this.builtinField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      appflowparam[] appflowparamArray = new appflowparam[1];
      appflowparam.appflowparam_response appflowparamResponse = new appflowparam.appflowparam_response();
      appflowparam.appflowparam_response resource = (appflowparam.appflowparam_response) service.get_payload_formatter().string_to_resource(appflowparamResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      appflowparamArray[0] = resource.appflowparam;
      return (base_resource[]) appflowparamArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, appflowparam resource) => new appflowparam()
    {
      templaterefresh = resource.templaterefresh,
      appnamerefresh = resource.appnamerefresh,
      flowrecordinterval = resource.flowrecordinterval,
      securityinsightrecordinterval = resource.securityinsightrecordinterval,
      udppmtu = resource.udppmtu,
      httpurl = resource.httpurl,
      aaausername = resource.aaausername,
      httpcookie = resource.httpcookie,
      httpreferer = resource.httpreferer,
      httpmethod = resource.httpmethod,
      httphost = resource.httphost,
      httpuseragent = resource.httpuseragent,
      clienttrafficonly = resource.clienttrafficonly,
      httpcontenttype = resource.httpcontenttype,
      httpauthorization = resource.httpauthorization,
      httpvia = resource.httpvia,
      httpxforwardedfor = resource.httpxforwardedfor,
      httplocation = resource.httplocation,
      httpsetcookie = resource.httpsetcookie,
      httpsetcookie2 = resource.httpsetcookie2,
      connectionchaining = resource.connectionchaining,
      httpdomain = resource.httpdomain,
      skipcacheredirectionhttptransaction = resource.skipcacheredirectionhttptransaction,
      identifiername = resource.identifiername,
      identifiersessionname = resource.identifiersessionname,
      observationdomainid = resource.observationdomainid,
      observationdomainname = resource.observationdomainname,
      securityinsighttraffic = resource.securityinsighttraffic
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      appflowparam resource,
      string[] args)
    {
      return new appflowparam().unset_resource(client, args);
    }

    public static appflowparam get(nitro_service service) => ((appflowparam[]) new appflowparam().get_resources(service, (options) null))[0];

    public static appflowparam get(nitro_service service, options option) => ((appflowparam[]) new appflowparam().get_resources(service, option))[0];

    private class appflowparam_response : base_response
    {
      public appflowparam appflowparam = (appflowparam) null;
    }

    public static class httprefererEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class httpsetcookieEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class httpviaEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class httpdomainEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class httpsetcookie2Enum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }

    public static class httpauthorizationEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class skipcacheredirectionhttptransactionEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class aaausernameEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class clienttrafficonlyEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class securityinsighttrafficEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class httpcontenttypeEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class httpmethodEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class httplocationEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class identifiersessionnameEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class connectionchainingEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class httpxforwardedforEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class identifiernameEnum
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
