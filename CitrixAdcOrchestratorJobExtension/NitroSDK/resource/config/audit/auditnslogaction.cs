// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.audit.auditnslogaction
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.audit
{
  public class auditnslogaction : base_resource
  {
    private string nameField = (string) null;
    private string serveripField = (string) null;
    private string serverdomainnameField = (string) null;
    private int? domainresolveretryField = new int?();
    private ushort? serverportField = new ushort?();
    private string[] loglevelField = (string[]) null;
    private string dateformatField = (string) null;
    private string logfacilityField = (string) null;
    private string tcpField = (string) null;
    private string aclField = (string) null;
    private string timezoneField = (string) null;
    private string userdefinedauditlogField = (string) null;
    private string appflowexportField = (string) null;
    private string lsnField = (string) null;
    private string algField = (string) null;
    private string subscriberlogField = (string) null;
    private bool? domainresolvenowField = new bool?();
    private string ipField = (string) null;
    private string[] builtinField = (string[]) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string serverip
    {
      get => this.serveripField;
      set => this.serveripField = value;
    }

    public string serverdomainname
    {
      get => this.serverdomainnameField;
      set => this.serverdomainnameField = value;
    }

    public int? domainresolveretry
    {
      get => this.domainresolveretryField;
      set => this.domainresolveretryField = value;
    }

    public ushort? serverport
    {
      get => this.serverportField;
      set => this.serverportField = value;
    }

    public string[] loglevel
    {
      get => this.loglevelField;
      set => this.loglevelField = value;
    }

    public string dateformat
    {
      get => this.dateformatField;
      set => this.dateformatField = value;
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

    public bool? domainresolvenow
    {
      get => this.domainresolvenowField;
      set => this.domainresolvenowField = value;
    }

    public string ip
    {
      get => this.ipField;
      private set => this.ipField = value;
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
      auditnslogaction.auditnslogaction_response auditnslogactionResponse = new auditnslogaction.auditnslogaction_response();
      auditnslogaction.auditnslogaction_response resource = (auditnslogaction.auditnslogaction_response) service.get_payload_formatter().string_to_resource(auditnslogactionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.auditnslogaction;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, auditnslogaction resource) => new auditnslogaction()
    {
      name = resource.name,
      serverip = resource.serverip,
      serverdomainname = resource.serverdomainname,
      domainresolveretry = resource.domainresolveretry,
      serverport = resource.serverport,
      loglevel = resource.loglevel,
      dateformat = resource.dateformat,
      logfacility = resource.logfacility,
      tcp = resource.tcp,
      acl = resource.acl,
      timezone = resource.timezone,
      userdefinedauditlog = resource.userdefinedauditlog,
      appflowexport = resource.appflowexport,
      lsn = resource.lsn,
      alg = resource.alg,
      subscriberlog = resource.subscriberlog
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      auditnslogaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        auditnslogaction[] auditnslogactionArray = new auditnslogaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          auditnslogactionArray[index] = new auditnslogaction();
          auditnslogactionArray[index].name = resources[index].name;
          auditnslogactionArray[index].serverip = resources[index].serverip;
          auditnslogactionArray[index].serverdomainname = resources[index].serverdomainname;
          auditnslogactionArray[index].domainresolveretry = resources[index].domainresolveretry;
          auditnslogactionArray[index].serverport = resources[index].serverport;
          auditnslogactionArray[index].loglevel = resources[index].loglevel;
          auditnslogactionArray[index].dateformat = resources[index].dateformat;
          auditnslogactionArray[index].logfacility = resources[index].logfacility;
          auditnslogactionArray[index].tcp = resources[index].tcp;
          auditnslogactionArray[index].acl = resources[index].acl;
          auditnslogactionArray[index].timezone = resources[index].timezone;
          auditnslogactionArray[index].userdefinedauditlog = resources[index].userdefinedauditlog;
          auditnslogactionArray[index].appflowexport = resources[index].appflowexport;
          auditnslogactionArray[index].lsn = resources[index].lsn;
          auditnslogactionArray[index].alg = resources[index].alg;
          auditnslogactionArray[index].subscriberlog = resources[index].subscriberlog;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) auditnslogactionArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new auditnslogaction()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, auditnslogaction resource) => new auditnslogaction()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        auditnslogaction[] auditnslogactionArray = new auditnslogaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          auditnslogactionArray[index] = new auditnslogaction();
          auditnslogactionArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) auditnslogactionArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      auditnslogaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        auditnslogaction[] auditnslogactionArray = new auditnslogaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          auditnslogactionArray[index] = new auditnslogaction();
          auditnslogactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) auditnslogactionArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, auditnslogaction resource) => new auditnslogaction()
    {
      name = resource.name,
      serverip = resource.serverip,
      serverdomainname = resource.serverdomainname,
      domainresolveretry = resource.domainresolveretry,
      domainresolvenow = resource.domainresolvenow,
      serverport = resource.serverport,
      loglevel = resource.loglevel,
      dateformat = resource.dateformat,
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

    public static base_responses update(
      nitro_service client,
      auditnslogaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        auditnslogaction[] auditnslogactionArray = new auditnslogaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          auditnslogactionArray[index] = new auditnslogaction();
          auditnslogactionArray[index].name = resources[index].name;
          auditnslogactionArray[index].serverip = resources[index].serverip;
          auditnslogactionArray[index].serverdomainname = resources[index].serverdomainname;
          auditnslogactionArray[index].domainresolveretry = resources[index].domainresolveretry;
          auditnslogactionArray[index].domainresolvenow = resources[index].domainresolvenow;
          auditnslogactionArray[index].serverport = resources[index].serverport;
          auditnslogactionArray[index].loglevel = resources[index].loglevel;
          auditnslogactionArray[index].dateformat = resources[index].dateformat;
          auditnslogactionArray[index].logfacility = resources[index].logfacility;
          auditnslogactionArray[index].tcp = resources[index].tcp;
          auditnslogactionArray[index].acl = resources[index].acl;
          auditnslogactionArray[index].timezone = resources[index].timezone;
          auditnslogactionArray[index].userdefinedauditlog = resources[index].userdefinedauditlog;
          auditnslogactionArray[index].appflowexport = resources[index].appflowexport;
          auditnslogactionArray[index].lsn = resources[index].lsn;
          auditnslogactionArray[index].alg = resources[index].alg;
          auditnslogactionArray[index].subscriberlog = resources[index].subscriberlog;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) auditnslogactionArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new auditnslogaction() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      auditnslogaction resource,
      string[] args)
    {
      return new auditnslogaction() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        auditnslogaction[] auditnslogactionArray = new auditnslogaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          auditnslogactionArray[index] = new auditnslogaction();
          auditnslogactionArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) auditnslogactionArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      auditnslogaction[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        auditnslogaction[] auditnslogactionArray = new auditnslogaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          auditnslogactionArray[index] = new auditnslogaction();
          auditnslogactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) auditnslogactionArray, args);
      }
      return baseResponses;
    }

    public static auditnslogaction[] get(nitro_service service) => (auditnslogaction[]) new auditnslogaction().get_resources(service, (options) null);

    public static auditnslogaction[] get(nitro_service service, options option) => (auditnslogaction[]) new auditnslogaction().get_resources(service, option);

    public static auditnslogaction get(nitro_service service, string name) => (auditnslogaction) new auditnslogaction()
    {
      name = name
    }.get_resource(service);

    public static auditnslogaction[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (auditnslogaction[]) null;
      auditnslogaction[] auditnslogactionArray1 = new auditnslogaction[name.Length];
      auditnslogaction[] auditnslogactionArray2 = new auditnslogaction[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        auditnslogactionArray2[index] = new auditnslogaction();
        auditnslogactionArray2[index].name = name[index];
        auditnslogactionArray1[index] = (auditnslogaction) auditnslogactionArray2[index].get_resource(service);
      }
      return auditnslogactionArray1;
    }

    public static auditnslogaction[] get_filtered(
      nitro_service service,
      string filter)
    {
      auditnslogaction auditnslogaction = new auditnslogaction();
      options option = new options();
      option.set_filter(filter);
      return (auditnslogaction[]) auditnslogaction.getfiltered(service, option);
    }

    public static auditnslogaction[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      auditnslogaction auditnslogaction = new auditnslogaction();
      options option = new options();
      option.set_filter(filter);
      return (auditnslogaction[]) auditnslogaction.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      auditnslogaction auditnslogaction = new auditnslogaction();
      options option = new options();
      option.set_count(true);
      auditnslogaction[] resources = (auditnslogaction[]) auditnslogaction.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      auditnslogaction auditnslogaction = new auditnslogaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      auditnslogaction[] auditnslogactionArray = (auditnslogaction[]) auditnslogaction.getfiltered(service, option);
      return auditnslogactionArray != null && auditnslogactionArray.Length > 0 ? auditnslogactionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      auditnslogaction auditnslogaction = new auditnslogaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      auditnslogaction[] auditnslogactionArray = (auditnslogaction[]) auditnslogaction.getfiltered(service, option);
      return auditnslogactionArray != null && auditnslogactionArray.Length > 0 ? auditnslogactionArray[0].__count.Value : 0U;
    }

    private class auditnslogaction_response : base_response
    {
      public auditnslogaction[] auditnslogaction = (auditnslogaction[]) null;
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
