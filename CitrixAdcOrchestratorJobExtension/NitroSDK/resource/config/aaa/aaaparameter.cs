// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.aaa.aaaparameter
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.aaa
{
  public class aaaparameter : base_resource
  {
    private string enablestaticpagecachingField = (string) null;
    private string enableenhancedauthfeedbackField = (string) null;
    private string defaultauthtypeField = (string) null;
    private uint? maxaaausersField = new uint?();
    private uint? maxloginattemptsField = new uint?();
    private uint? failedlogintimeoutField = new uint?();
    private string aaadnatipField = (string) null;
    private string enablesessionstickinessField = (string) null;
    private string aaasessionloglevelField = (string) null;

    public string enablestaticpagecaching
    {
      get => this.enablestaticpagecachingField;
      set => this.enablestaticpagecachingField = value;
    }

    public string enableenhancedauthfeedback
    {
      get => this.enableenhancedauthfeedbackField;
      set => this.enableenhancedauthfeedbackField = value;
    }

    public string defaultauthtype
    {
      get => this.defaultauthtypeField;
      set => this.defaultauthtypeField = value;
    }

    public uint? maxaaausers
    {
      get => this.maxaaausersField;
      set => this.maxaaausersField = value;
    }

    public uint? maxloginattempts
    {
      get => this.maxloginattemptsField;
      set => this.maxloginattemptsField = value;
    }

    public uint? failedlogintimeout
    {
      get => this.failedlogintimeoutField;
      set => this.failedlogintimeoutField = value;
    }

    public string aaadnatip
    {
      get => this.aaadnatipField;
      set => this.aaadnatipField = value;
    }

    public string enablesessionstickiness
    {
      get => this.enablesessionstickinessField;
      set => this.enablesessionstickinessField = value;
    }

    public string aaasessionloglevel
    {
      get => this.aaasessionloglevelField;
      set => this.aaasessionloglevelField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      aaaparameter[] aaaparameterArray = new aaaparameter[1];
      aaaparameter.aaaparameter_response aaaparameterResponse = new aaaparameter.aaaparameter_response();
      aaaparameter.aaaparameter_response resource = (aaaparameter.aaaparameter_response) service.get_payload_formatter().string_to_resource(aaaparameterResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      aaaparameterArray[0] = resource.aaaparameter;
      return (base_resource[]) aaaparameterArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, aaaparameter resource) => new aaaparameter()
    {
      enablestaticpagecaching = resource.enablestaticpagecaching,
      enableenhancedauthfeedback = resource.enableenhancedauthfeedback,
      defaultauthtype = resource.defaultauthtype,
      maxaaausers = resource.maxaaausers,
      maxloginattempts = resource.maxloginattempts,
      failedlogintimeout = resource.failedlogintimeout,
      aaadnatip = resource.aaadnatip,
      enablesessionstickiness = resource.enablesessionstickiness,
      aaasessionloglevel = resource.aaasessionloglevel
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      aaaparameter resource,
      string[] args)
    {
      return new aaaparameter().unset_resource(client, args);
    }

    public static aaaparameter get(nitro_service service) => ((aaaparameter[]) new aaaparameter().get_resources(service, (options) null))[0];

    public static aaaparameter get(nitro_service service, options option) => ((aaaparameter[]) new aaaparameter().get_resources(service, option))[0];

    private class aaaparameter_response : base_response
    {
      public aaaparameter aaaparameter = (aaaparameter) null;
    }

    public static class aaasessionloglevelEnum
    {
      public const string EMERGENCY = "EMERGENCY";
      public const string ALERT = "ALERT";
      public const string CRITICAL = "CRITICAL";
      public const string ERROR = "ERROR";
      public const string WARNING = "WARNING";
      public const string NOTICE = "NOTICE";
      public const string INFORMATIONAL = "INFORMATIONAL";
      public const string DEBUG = "DEBUG";
    }

    public static class defaultauthtypeEnum
    {
      public const string LOCAL = "LOCAL";
      public const string LDAP = "LDAP";
      public const string RADIUS = "RADIUS";
      public const string TACACS = "TACACS";
      public const string CERT = "CERT";
    }

    public static class enableenhancedauthfeedbackEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class enablestaticpagecachingEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class enablesessionstickinessEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }
  }
}
