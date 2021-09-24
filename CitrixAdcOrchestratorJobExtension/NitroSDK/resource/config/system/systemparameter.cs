// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.system.systemparameter
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.system
{
  public class systemparameter : base_resource
  {
    private string rbaonresponseField = (string) null;
    private string promptstringField = (string) null;
    private uint? natpcbforceflushlimitField = new uint?();
    private string natpcbrstontimeoutField = (string) null;
    private long? timeoutField = new long?();
    private string localauthField = (string) null;
    private uint? minpasswordlenField = new uint?();
    private string strongpasswordField = (string) null;
    private string restrictedtimeoutField = (string) null;
    private string fipsusermodeField = (string) null;
    private string dopplerField = (string) null;
    private string googleanalyticsField = (string) null;
    private string cliloglevelField = (string) null;
    private uint? maxclientField = new uint?();

    public string rbaonresponse
    {
      get => this.rbaonresponseField;
      set => this.rbaonresponseField = value;
    }

    public string promptstring
    {
      get => this.promptstringField;
      set => this.promptstringField = value;
    }

    public uint? natpcbforceflushlimit
    {
      get => this.natpcbforceflushlimitField;
      set => this.natpcbforceflushlimitField = value;
    }

    public string natpcbrstontimeout
    {
      get => this.natpcbrstontimeoutField;
      set => this.natpcbrstontimeoutField = value;
    }

    public long? timeout
    {
      get => this.timeoutField;
      set => this.timeoutField = value;
    }

    public string localauth
    {
      get => this.localauthField;
      set => this.localauthField = value;
    }

    public uint? minpasswordlen
    {
      get => this.minpasswordlenField;
      set => this.minpasswordlenField = value;
    }

    public string strongpassword
    {
      get => this.strongpasswordField;
      set => this.strongpasswordField = value;
    }

    public string restrictedtimeout
    {
      get => this.restrictedtimeoutField;
      set => this.restrictedtimeoutField = value;
    }

    public string fipsusermode
    {
      get => this.fipsusermodeField;
      set => this.fipsusermodeField = value;
    }

    public string doppler
    {
      get => this.dopplerField;
      set => this.dopplerField = value;
    }

    public string googleanalytics
    {
      get => this.googleanalyticsField;
      set => this.googleanalyticsField = value;
    }

    public string cliloglevel
    {
      get => this.cliloglevelField;
      set => this.cliloglevelField = value;
    }

    public uint? maxclient
    {
      get => this.maxclientField;
      private set => this.maxclientField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      systemparameter[] systemparameterArray = new systemparameter[1];
      systemparameter.systemparameter_response systemparameterResponse = new systemparameter.systemparameter_response();
      systemparameter.systemparameter_response resource = (systemparameter.systemparameter_response) service.get_payload_formatter().string_to_resource(systemparameterResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      systemparameterArray[0] = resource.systemparameter;
      return (base_resource[]) systemparameterArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, systemparameter resource) => new systemparameter()
    {
      rbaonresponse = resource.rbaonresponse,
      promptstring = resource.promptstring,
      natpcbforceflushlimit = resource.natpcbforceflushlimit,
      natpcbrstontimeout = resource.natpcbrstontimeout,
      timeout = resource.timeout,
      localauth = resource.localauth,
      minpasswordlen = resource.minpasswordlen,
      strongpassword = resource.strongpassword,
      restrictedtimeout = resource.restrictedtimeout,
      fipsusermode = resource.fipsusermode,
      doppler = resource.doppler,
      googleanalytics = resource.googleanalytics,
      cliloglevel = resource.cliloglevel
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      systemparameter resource,
      string[] args)
    {
      return new systemparameter().unset_resource(client, args);
    }

    public static systemparameter get(nitro_service service) => ((systemparameter[]) new systemparameter().get_resources(service, (options) null))[0];

    public static systemparameter get(nitro_service service, options option) => ((systemparameter[]) new systemparameter().get_resources(service, option))[0];

    private class systemparameter_response : base_response
    {
      public systemparameter systemparameter = (systemparameter) null;
    }

    public static class strongpasswordEnum
    {
      public const string enableall = "enableall";
      public const string enablelocal = "enablelocal";
      public const string disabled = "disabled";
    }

    public static class localauthEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class fipsusermodeEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class dopplerEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class googleanalyticsEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class restrictedtimeoutEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class rbaonresponseEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class cliloglevelEnum
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

    public static class natpcbrstontimeoutEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
