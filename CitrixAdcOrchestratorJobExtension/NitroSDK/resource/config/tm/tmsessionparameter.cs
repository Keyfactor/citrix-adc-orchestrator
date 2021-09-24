// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.tm.tmsessionparameter
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.tm
{
  public class tmsessionparameter : base_resource
  {
    private uint? sesstimeoutField = new uint?();
    private string defaultauthorizationactionField = (string) null;
    private string ssoField = (string) null;
    private string ssocredentialField = (string) null;
    private string ssodomainField = (string) null;
    private string kcdaccountField = (string) null;
    private string httponlycookieField = (string) null;
    private string persistentcookieField = (string) null;
    private uint? persistentcookievalidityField = new uint?();
    private string homepageField = (string) null;
    private string nameField = (string) null;

    public uint? sesstimeout
    {
      get => this.sesstimeoutField;
      set => this.sesstimeoutField = value;
    }

    public string defaultauthorizationaction
    {
      get => this.defaultauthorizationactionField;
      set => this.defaultauthorizationactionField = value;
    }

    public string sso
    {
      get => this.ssoField;
      set => this.ssoField = value;
    }

    public string ssocredential
    {
      get => this.ssocredentialField;
      set => this.ssocredentialField = value;
    }

    public string ssodomain
    {
      get => this.ssodomainField;
      set => this.ssodomainField = value;
    }

    public string kcdaccount
    {
      get => this.kcdaccountField;
      set => this.kcdaccountField = value;
    }

    public string httponlycookie
    {
      get => this.httponlycookieField;
      set => this.httponlycookieField = value;
    }

    public string persistentcookie
    {
      get => this.persistentcookieField;
      set => this.persistentcookieField = value;
    }

    public uint? persistentcookievalidity
    {
      get => this.persistentcookievalidityField;
      set => this.persistentcookievalidityField = value;
    }

    public string homepage
    {
      get => this.homepageField;
      set => this.homepageField = value;
    }

    public string name
    {
      get => this.nameField;
      private set => this.nameField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      tmsessionparameter[] tmsessionparameterArray = new tmsessionparameter[1];
      tmsessionparameter.tmsessionparameter_response tmsessionparameterResponse = new tmsessionparameter.tmsessionparameter_response();
      tmsessionparameter.tmsessionparameter_response resource = (tmsessionparameter.tmsessionparameter_response) service.get_payload_formatter().string_to_resource(tmsessionparameterResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      tmsessionparameterArray[0] = resource.tmsessionparameter;
      return (base_resource[]) tmsessionparameterArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(
      nitro_service client,
      tmsessionparameter resource)
    {
      return new tmsessionparameter()
      {
        sesstimeout = resource.sesstimeout,
        defaultauthorizationaction = resource.defaultauthorizationaction,
        sso = resource.sso,
        ssocredential = resource.ssocredential,
        ssodomain = resource.ssodomain,
        kcdaccount = resource.kcdaccount,
        httponlycookie = resource.httponlycookie,
        persistentcookie = resource.persistentcookie,
        persistentcookievalidity = resource.persistentcookievalidity,
        homepage = resource.homepage
      }.update_resource(client);
    }

    public static base_response unset(
      nitro_service client,
      tmsessionparameter resource,
      string[] args)
    {
      return new tmsessionparameter().unset_resource(client, args);
    }

    public static tmsessionparameter get(nitro_service service) => ((tmsessionparameter[]) new tmsessionparameter().get_resources(service, (options) null))[0];

    public static tmsessionparameter get(nitro_service service, options option) => ((tmsessionparameter[]) new tmsessionparameter().get_resources(service, option))[0];

    private class tmsessionparameter_response : base_response
    {
      public tmsessionparameter tmsessionparameter = (tmsessionparameter) null;
    }

    public static class persistentcookieEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class httponlycookieEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class defaultauthorizationactionEnum
    {
      public const string ALLOW = "ALLOW";
      public const string DENY = "DENY";
    }

    public static class ssocredentialEnum
    {
      public const string PRIMARY = "PRIMARY";
      public const string SECONDARY = "SECONDARY";
    }

    public static class ssoEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }
  }
}
