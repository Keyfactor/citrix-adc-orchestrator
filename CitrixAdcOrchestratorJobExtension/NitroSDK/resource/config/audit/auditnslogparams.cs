// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.audit.auditnslogparams
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.audit
{
  public class auditnslogparams : base_resource
  {
    private string serveripField = (string) null;
    private ushort? serverportField = new ushort?();
    private string dateformatField = (string) null;
    private string[] loglevelField = (string[]) null;
    private string logfacilityField = (string) null;
    private string tcpField = (string) null;
    private string aclField = (string) null;
    private string timezoneField = (string) null;
    private string userdefinedauditlogField = (string) null;
    private string appflowexportField = (string) null;
    private string lsnField = (string) null;
    private string algField = (string) null;
    private string subscriberlogField = (string) null;
    private string[] builtinField = (string[]) null;

    public string serverip
    {
      get => this.serveripField;
      set => this.serveripField = value;
    }

    public ushort? serverport
    {
      get => this.serverportField;
      set => this.serverportField = value;
    }

    public string dateformat
    {
      get => this.dateformatField;
      set => this.dateformatField = value;
    }

    public string[] loglevel
    {
      get => this.loglevelField;
      set => this.loglevelField = value;
    }

    public string logfacility
    {
      get => this.logfacilityField;
      set => this.logfacilityField = value;
    }

    public string tcp
    {
      get => this.tcpField;
      set => this.tcpField = value;
    }

    public string acl
    {
      get => this.aclField;
      set => this.aclField = value;
    }

    public string timezone
    {
      get => this.timezoneField;
      set => this.timezoneField = value;
    }

    public string userdefinedauditlog
    {
      get => this.userdefinedauditlogField;
      set => this.userdefinedauditlogField = value;
    }

    public string appflowexport
    {
      get => this.appflowexportField;
      set => this.appflowexportField = value;
    }

    public string lsn
    {
      get => this.lsnField;
      set => this.lsnField = value;
    }

    public string alg
    {
      get => this.algField;
      set => this.algField = value;
    }

    public string subscriberlog
    {
      get => this.subscriberlogField;
      set => this.subscriberlogField = value;
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
      auditnslogparams[] auditnslogparamsArray = new auditnslogparams[1];
      auditnslogparams.auditnslogparams_response auditnslogparamsResponse = new auditnslogparams.auditnslogparams_response();
      auditnslogparams.auditnslogparams_response resource = (auditnslogparams.auditnslogparams_response) service.get_payload_formatter().string_to_resource(auditnslogparamsResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      auditnslogparamsArray[0] = resource.auditnslogparams;
      return (base_resource[]) auditnslogparamsArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, auditnslogparams resource) => new auditnslogparams()
    {
      serverip = resource.serverip,
      serverport = resource.serverport,
      dateformat = resource.dateformat,
      loglevel = resource.loglevel,
      logfacility = resource.logfacility,
      tcp = resource.tcp,
      acl = resource.acl,
      timezone = resource.timezone,
      userdefinedauditlog = resource.userdefinedauditlog,
      appflowexport = resource.appflowexport,
      lsn = resource.lsn,
      alg = resource.alg,
      subscriberlog = resource.subscriberlog
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      auditnslogparams resource,
      string[] args)
    {
      return new auditnslogparams().unset_resource(client, args);
    }

    public static auditnslogparams get(nitro_service service) => ((auditnslogparams[]) new auditnslogparams().get_resources(service, (options) null))[0];

    public static auditnslogparams get(nitro_service service, options option) => ((auditnslogparams[]) new auditnslogparams().get_resources(service, option))[0];

    private class auditnslogparams_response : base_response
    {
      public auditnslogparams auditnslogparams = (auditnslogparams) null;
    }

    public static class userdefinedauditlogEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }

    public static class timezoneEnum
    {
      public const string GMT_TIME = "GMT_TIME";
      public const string LOCAL_TIME = "LOCAL_TIME";
    }

    public static class dateformatEnum
    {
      public const string MMDDYYYY = "MMDDYYYY";
      public const string DDMMYYYY = "DDMMYYYY";
      public const string YYYYMMDD = "YYYYMMDD";
    }

    public static class aclEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class lsnEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class subscriberlogEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class algEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class logfacilityEnum
    {
      public const string LOCAL0 = "LOCAL0";
      public const string LOCAL1 = "LOCAL1";
      public const string LOCAL2 = "LOCAL2";
      public const string LOCAL3 = "LOCAL3";
      public const string LOCAL4 = "LOCAL4";
      public const string LOCAL5 = "LOCAL5";
      public const string LOCAL6 = "LOCAL6";
      public const string LOCAL7 = "LOCAL7";
    }

    public static class loglevelEnum
    {
      public const string ALL = "ALL";
      public const string EMERGENCY = "EMERGENCY";
      public const string ALERT = "ALERT";
      public const string CRITICAL = "CRITICAL";
      public const string ERROR = "ERROR";
      public const string WARNING = "WARNING";
      public const string NOTICE = "NOTICE";
      public const string INFORMATIONAL = "INFORMATIONAL";
      public const string DEBUG = "DEBUG";
      public const string NONE = "NONE";
    }

    public static class tcpEnum
    {
      public const string NONE = "NONE";
      public const string ALL = "ALL";
    }

    public static class appflowexportEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
