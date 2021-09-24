// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.audit.auditmessageaction
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.audit
{
  public class auditmessageaction : base_resource
  {
    private string nameField = (string) null;
    private string loglevelField = (string) null;
    private string stringbuilderexprField = (string) null;
    private string logtonewnslogField = (string) null;
    private string bypasssafetycheckField = (string) null;
    private string loglevel1Field = (string) null;
    private long? hitsField = new long?();
    private long? undefhitsField = new long?();
    private uint? referencecountField = new uint?();
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

    public string loglevel
    {
      get => this.loglevelField;
      set => this.loglevelField = value;
    }

    public string stringbuilderexpr
    {
      get => this.stringbuilderexprField;
      set => this.stringbuilderexprField = value;
    }

    public string logtonewnslog
    {
      get => this.logtonewnslogField;
      set => this.logtonewnslogField = value;
    }

    public string bypasssafetycheck
    {
      get => this.bypasssafetycheckField;
      set => this.bypasssafetycheckField = value;
    }

    public string loglevel1
    {
      get => this.loglevel1Field;
      private set => this.loglevel1Field = value;
    }

    public long? hits
    {
      get => this.hitsField;
      private set => this.hitsField = value;
    }

    public long? undefhits
    {
      get => this.undefhitsField;
      private set => this.undefhitsField = value;
    }

    public uint? referencecount
    {
      get => this.referencecountField;
      private set => this.referencecountField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      auditmessageaction.auditmessageaction_response auditmessageactionResponse = new auditmessageaction.auditmessageaction_response();
      auditmessageaction.auditmessageaction_response resource = (auditmessageaction.auditmessageaction_response) service.get_payload_formatter().string_to_resource(auditmessageactionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.auditmessageaction;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, auditmessageaction resource) => new auditmessageaction()
    {
      name = resource.name,
      loglevel = resource.loglevel,
      stringbuilderexpr = resource.stringbuilderexpr,
      logtonewnslog = resource.logtonewnslog,
      bypasssafetycheck = resource.bypasssafetycheck
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      auditmessageaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        auditmessageaction[] auditmessageactionArray = new auditmessageaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          auditmessageactionArray[index] = new auditmessageaction();
          auditmessageactionArray[index].name = resources[index].name;
          auditmessageactionArray[index].loglevel = resources[index].loglevel;
          auditmessageactionArray[index].stringbuilderexpr = resources[index].stringbuilderexpr;
          auditmessageactionArray[index].logtonewnslog = resources[index].logtonewnslog;
          auditmessageactionArray[index].bypasssafetycheck = resources[index].bypasssafetycheck;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) auditmessageactionArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new auditmessageaction()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      auditmessageaction resource)
    {
      return new auditmessageaction()
      {
        name = resource.name
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        auditmessageaction[] auditmessageactionArray = new auditmessageaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          auditmessageactionArray[index] = new auditmessageaction();
          auditmessageactionArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) auditmessageactionArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      auditmessageaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        auditmessageaction[] auditmessageactionArray = new auditmessageaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          auditmessageactionArray[index] = new auditmessageaction();
          auditmessageactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) auditmessageactionArray);
      }
      return baseResponses;
    }

    public static base_response update(
      nitro_service client,
      auditmessageaction resource)
    {
      return new auditmessageaction()
      {
        name = resource.name,
        loglevel = resource.loglevel,
        stringbuilderexpr = resource.stringbuilderexpr,
        logtonewnslog = resource.logtonewnslog,
        bypasssafetycheck = resource.bypasssafetycheck
      }.update_resource(client);
    }

    public static base_responses update(
      nitro_service client,
      auditmessageaction[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        auditmessageaction[] auditmessageactionArray = new auditmessageaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          auditmessageactionArray[index] = new auditmessageaction();
          auditmessageactionArray[index].name = resources[index].name;
          auditmessageactionArray[index].loglevel = resources[index].loglevel;
          auditmessageactionArray[index].stringbuilderexpr = resources[index].stringbuilderexpr;
          auditmessageactionArray[index].logtonewnslog = resources[index].logtonewnslog;
          auditmessageactionArray[index].bypasssafetycheck = resources[index].bypasssafetycheck;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) auditmessageactionArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new auditmessageaction() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      auditmessageaction resource,
      string[] args)
    {
      return new auditmessageaction()
      {
        name = resource.name
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        auditmessageaction[] auditmessageactionArray = new auditmessageaction[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          auditmessageactionArray[index] = new auditmessageaction();
          auditmessageactionArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) auditmessageactionArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      auditmessageaction[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        auditmessageaction[] auditmessageactionArray = new auditmessageaction[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          auditmessageactionArray[index] = new auditmessageaction();
          auditmessageactionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) auditmessageactionArray, args);
      }
      return baseResponses;
    }

    public static auditmessageaction[] get(nitro_service service) => (auditmessageaction[]) new auditmessageaction().get_resources(service, (options) null);

    public static auditmessageaction[] get(nitro_service service, options option) => (auditmessageaction[]) new auditmessageaction().get_resources(service, option);

    public static auditmessageaction get(nitro_service service, string name) => (auditmessageaction) new auditmessageaction()
    {
      name = name
    }.get_resource(service);

    public static auditmessageaction[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (auditmessageaction[]) null;
      auditmessageaction[] auditmessageactionArray1 = new auditmessageaction[name.Length];
      auditmessageaction[] auditmessageactionArray2 = new auditmessageaction[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        auditmessageactionArray2[index] = new auditmessageaction();
        auditmessageactionArray2[index].name = name[index];
        auditmessageactionArray1[index] = (auditmessageaction) auditmessageactionArray2[index].get_resource(service);
      }
      return auditmessageactionArray1;
    }

    public static auditmessageaction[] get_filtered(
      nitro_service service,
      string filter)
    {
      auditmessageaction auditmessageaction = new auditmessageaction();
      options option = new options();
      option.set_filter(filter);
      return (auditmessageaction[]) auditmessageaction.getfiltered(service, option);
    }

    public static auditmessageaction[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      auditmessageaction auditmessageaction = new auditmessageaction();
      options option = new options();
      option.set_filter(filter);
      return (auditmessageaction[]) auditmessageaction.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      auditmessageaction auditmessageaction = new auditmessageaction();
      options option = new options();
      option.set_count(true);
      auditmessageaction[] resources = (auditmessageaction[]) auditmessageaction.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      auditmessageaction auditmessageaction = new auditmessageaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      auditmessageaction[] auditmessageactionArray = (auditmessageaction[]) auditmessageaction.getfiltered(service, option);
      return auditmessageactionArray != null && auditmessageactionArray.Length > 0 ? auditmessageactionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      auditmessageaction auditmessageaction = new auditmessageaction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      auditmessageaction[] auditmessageactionArray = (auditmessageaction[]) auditmessageaction.getfiltered(service, option);
      return auditmessageactionArray != null && auditmessageactionArray.Length > 0 ? auditmessageactionArray[0].__count.Value : 0U;
    }

    private class auditmessageaction_response : base_response
    {
      public auditmessageaction[] auditmessageaction = (auditmessageaction[]) null;
    }

    public static class loglevel1Enum
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

    public static class logtonewnslogEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class loglevelEnum
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

    public static class bypasssafetycheckEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }
  }
}
