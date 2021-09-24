// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.authentication.authenticationvserver
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.authentication
{
  public class authenticationvserver : base_resource
  {
    private string nameField = (string) null;
    private string servicetypeField = (string) null;
    private string ipv46Field = (string) null;
    private uint? rangeField = new uint?();
    private ushort? portField = new ushort?();
    private string stateField = (string) null;
    private string authenticationField = (string) null;
    private string authenticationdomainField = (string) null;
    private string commentField = (string) null;
    private uint? tdField = new uint?();
    private string appflowlogField = (string) null;
    private uint? maxloginattemptsField = new uint?();
    private uint? failedlogintimeoutField = new uint?();
    private string newnameField = (string) null;
    private string ipField = (string) null;
    private string valueField = (string) null;
    private string typeField = (string) null;
    private string curstateField = (string) null;
    private int? statusField = new int?();
    private string cachetypeField = (string) null;
    private string redirectField = (string) null;
    private string precedenceField = (string) null;
    private string redirecturlField = (string) null;
    private uint? curaaausersField = new uint?();
    private string ruleField = (string) null;
    private string policyField = (string) null;
    private string servicenameField = (string) null;
    private uint? weightField = new uint?();
    private string cachevserverField = (string) null;
    private string backupvserverField = (string) null;
    private uint? clttimeoutField = new uint?();
    private string somethodField = (string) null;
    private uint? sothresholdField = new uint?();
    private string sopersistenceField = (string) null;
    private uint? sopersistencetimeoutField = new uint?();
    private uint? priorityField = new uint?();
    private string downstateflushField = (string) null;
    private string disableprimaryondownField = (string) null;
    private string listenpolicyField = (string) null;
    private uint? listenpriorityField = new uint?();
    private string tcpprofilenameField = (string) null;
    private string httpprofilenameField = (string) null;
    private uint? vstypeField = new uint?();
    private string ngnameField = (string) null;
    private bool? secondaryField = new bool?();
    private bool? groupextractionField = new bool?();
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

    public string servicetype
    {
      get => this.servicetypeField;
      set => this.servicetypeField = value;
    }

    public string ipv46
    {
      get => this.ipv46Field;
      set => this.ipv46Field = value;
    }

    public uint? range
    {
      get => this.rangeField;
      set => this.rangeField = value;
    }

    public ushort? port
    {
      get => this.portField;
      set => this.portField = value;
    }

    public string state
    {
      get => this.stateField;
      set => this.stateField = value;
    }

    public string authentication
    {
      get => this.authenticationField;
      set => this.authenticationField = value;
    }

    public string authenticationdomain
    {
      get => this.authenticationdomainField;
      set => this.authenticationdomainField = value;
    }

    public string comment
    {
      get => this.commentField;
      set => this.commentField = value;
    }

    public uint? td
    {
      get => this.tdField;
      set => this.tdField = value;
    }

    public string appflowlog
    {
      get => this.appflowlogField;
      set => this.appflowlogField = value;
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

    public string newname
    {
      get => this.newnameField;
      set => this.newnameField = value;
    }

    public string ip
    {
      get => this.ipField;
      private set => this.ipField = value;
    }

    public string value
    {
      get => this.valueField;
      private set => this.valueField = value;
    }

    public string type
    {
      get => this.typeField;
      private set => this.typeField = value;
    }

    public string curstate
    {
      get => this.curstateField;
      private set => this.curstateField = value;
    }

    public int? status
    {
      get => this.statusField;
      private set => this.statusField = value;
    }

    public string cachetype
    {
      get => this.cachetypeField;
      private set => this.cachetypeField = value;
    }

    public string redirect
    {
      get => this.redirectField;
      private set => this.redirectField = value;
    }

    public string precedence
    {
      get => this.precedenceField;
      private set => this.precedenceField = value;
    }

    public string redirecturl
    {
      get => this.redirecturlField;
      private set => this.redirecturlField = value;
    }

    public uint? curaaausers
    {
      get => this.curaaausersField;
      private set => this.curaaausersField = value;
    }

    public string rule
    {
      get => this.ruleField;
      private set => this.ruleField = value;
    }

    public string policy
    {
      get => this.policyField;
      private set => this.policyField = value;
    }

    public string servicename
    {
      get => this.servicenameField;
      private set => this.servicenameField = value;
    }

    public uint? weight
    {
      get => this.weightField;
      private set => this.weightField = value;
    }

    public string cachevserver
    {
      get => this.cachevserverField;
      private set => this.cachevserverField = value;
    }

    public string backupvserver
    {
      get => this.backupvserverField;
      private set => this.backupvserverField = value;
    }

    public uint? clttimeout
    {
      get => this.clttimeoutField;
      private set => this.clttimeoutField = value;
    }

    public string somethod
    {
      get => this.somethodField;
      private set => this.somethodField = value;
    }

    public uint? sothreshold
    {
      get => this.sothresholdField;
      private set => this.sothresholdField = value;
    }

    public string sopersistence
    {
      get => this.sopersistenceField;
      private set => this.sopersistenceField = value;
    }

    public uint? sopersistencetimeout
    {
      get => this.sopersistencetimeoutField;
      private set => this.sopersistencetimeoutField = value;
    }

    public uint? priority
    {
      get => this.priorityField;
      private set => this.priorityField = value;
    }

    public string downstateflush
    {
      get => this.downstateflushField;
      private set => this.downstateflushField = value;
    }

    public string disableprimaryondown
    {
      get => this.disableprimaryondownField;
      private set => this.disableprimaryondownField = value;
    }

    public string listenpolicy
    {
      get => this.listenpolicyField;
      private set => this.listenpolicyField = value;
    }

    public uint? listenpriority
    {
      get => this.listenpriorityField;
      private set => this.listenpriorityField = value;
    }

    public string tcpprofilename
    {
      get => this.tcpprofilenameField;
      private set => this.tcpprofilenameField = value;
    }

    public string httpprofilename
    {
      get => this.httpprofilenameField;
      private set => this.httpprofilenameField = value;
    }

    public uint? vstype
    {
      get => this.vstypeField;
      private set => this.vstypeField = value;
    }

    public string ngname
    {
      get => this.ngnameField;
      private set => this.ngnameField = value;
    }

    public bool? secondary
    {
      get => this.secondaryField;
      private set => this.secondaryField = value;
    }

    public bool? groupextraction
    {
      get => this.groupextractionField;
      private set => this.groupextractionField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      authenticationvserver.authenticationvserver_response authenticationvserverResponse = new authenticationvserver.authenticationvserver_response();
      authenticationvserver.authenticationvserver_response resource = (authenticationvserver.authenticationvserver_response) service.get_payload_formatter().string_to_resource(authenticationvserverResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationvserver;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      authenticationvserver resource)
    {
      return new authenticationvserver()
      {
        name = resource.name,
        servicetype = resource.servicetype,
        ipv46 = resource.ipv46,
        range = resource.range,
        port = resource.port,
        state = resource.state,
        authentication = resource.authentication,
        authenticationdomain = resource.authenticationdomain,
        comment = resource.comment,
        td = resource.td,
        appflowlog = resource.appflowlog,
        maxloginattempts = resource.maxloginattempts,
        failedlogintimeout = resource.failedlogintimeout
      }.add_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      authenticationvserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationvserver[] authenticationvserverArray = new authenticationvserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationvserverArray[index] = new authenticationvserver();
          authenticationvserverArray[index].name = resources[index].name;
          authenticationvserverArray[index].servicetype = resources[index].servicetype;
          authenticationvserverArray[index].ipv46 = resources[index].ipv46;
          authenticationvserverArray[index].range = resources[index].range;
          authenticationvserverArray[index].port = resources[index].port;
          authenticationvserverArray[index].state = resources[index].state;
          authenticationvserverArray[index].authentication = resources[index].authentication;
          authenticationvserverArray[index].authenticationdomain = resources[index].authenticationdomain;
          authenticationvserverArray[index].comment = resources[index].comment;
          authenticationvserverArray[index].td = resources[index].td;
          authenticationvserverArray[index].appflowlog = resources[index].appflowlog;
          authenticationvserverArray[index].maxloginattempts = resources[index].maxloginattempts;
          authenticationvserverArray[index].failedlogintimeout = resources[index].failedlogintimeout;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) authenticationvserverArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new authenticationvserver()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      authenticationvserver resource)
    {
      return new authenticationvserver()
      {
        name = resource.name
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        authenticationvserver[] authenticationvserverArray = new authenticationvserver[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationvserverArray[index] = new authenticationvserver();
          authenticationvserverArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationvserverArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      authenticationvserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationvserver[] authenticationvserverArray = new authenticationvserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationvserverArray[index] = new authenticationvserver();
          authenticationvserverArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) authenticationvserverArray);
      }
      return baseResponses;
    }

    public static base_response update(
      nitro_service client,
      authenticationvserver resource)
    {
      return new authenticationvserver()
      {
        name = resource.name,
        ipv46 = resource.ipv46,
        authentication = resource.authentication,
        authenticationdomain = resource.authenticationdomain,
        comment = resource.comment,
        appflowlog = resource.appflowlog,
        maxloginattempts = resource.maxloginattempts,
        failedlogintimeout = resource.failedlogintimeout
      }.update_resource(client);
    }

    public static base_responses update(
      nitro_service client,
      authenticationvserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationvserver[] authenticationvserverArray = new authenticationvserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationvserverArray[index] = new authenticationvserver();
          authenticationvserverArray[index].name = resources[index].name;
          authenticationvserverArray[index].ipv46 = resources[index].ipv46;
          authenticationvserverArray[index].authentication = resources[index].authentication;
          authenticationvserverArray[index].authenticationdomain = resources[index].authenticationdomain;
          authenticationvserverArray[index].comment = resources[index].comment;
          authenticationvserverArray[index].appflowlog = resources[index].appflowlog;
          authenticationvserverArray[index].maxloginattempts = resources[index].maxloginattempts;
          authenticationvserverArray[index].failedlogintimeout = resources[index].failedlogintimeout;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) authenticationvserverArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new authenticationvserver() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      authenticationvserver resource,
      string[] args)
    {
      return new authenticationvserver()
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
        authenticationvserver[] authenticationvserverArray = new authenticationvserver[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationvserverArray[index] = new authenticationvserver();
          authenticationvserverArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) authenticationvserverArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      authenticationvserver[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationvserver[] authenticationvserverArray = new authenticationvserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationvserverArray[index] = new authenticationvserver();
          authenticationvserverArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) authenticationvserverArray, args);
      }
      return baseResponses;
    }

    public static base_response enable(nitro_service client, string name) => new authenticationvserver()
    {
      name = name
    }.perform_operation_byaction(client, nameof (enable));

    public static base_response enable(
      nitro_service client,
      authenticationvserver resource)
    {
      return new authenticationvserver()
      {
        name = resource.name
      }.perform_operation_byaction(client, nameof (enable));
    }

    public static base_responses enable(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        authenticationvserver[] authenticationvserverArray = new authenticationvserver[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationvserverArray[index] = new authenticationvserver();
          authenticationvserverArray[index].name = name[index];
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) authenticationvserverArray, nameof (enable));
      }
      return baseResponses;
    }

    public static base_responses enable(
      nitro_service client,
      authenticationvserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationvserver[] authenticationvserverArray = new authenticationvserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationvserverArray[index] = new authenticationvserver();
          authenticationvserverArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) authenticationvserverArray, nameof (enable));
      }
      return baseResponses;
    }

    public static base_response disable(nitro_service client, string name) => new authenticationvserver()
    {
      name = name
    }.perform_operation_byaction(client, nameof (disable));

    public static base_response disable(
      nitro_service client,
      authenticationvserver resource)
    {
      return new authenticationvserver()
      {
        name = resource.name
      }.perform_operation_byaction(client, nameof (disable));
    }

    public static base_responses disable(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        authenticationvserver[] authenticationvserverArray = new authenticationvserver[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          authenticationvserverArray[index] = new authenticationvserver();
          authenticationvserverArray[index].name = name[index];
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) authenticationvserverArray, nameof (disable));
      }
      return baseResponses;
    }

    public static base_responses disable(
      nitro_service client,
      authenticationvserver[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        authenticationvserver[] authenticationvserverArray = new authenticationvserver[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          authenticationvserverArray[index] = new authenticationvserver();
          authenticationvserverArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) authenticationvserverArray, nameof (disable));
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      authenticationvserver resource,
      string new_name)
    {
      return new authenticationvserver()
      {
        name = resource.name,
        newname = new_name
      }.rename_resource(client);
    }

    public static base_response rename(
      nitro_service client,
      string name,
      string new_name)
    {
      return new authenticationvserver()
      {
        name = name,
        newname = new_name
      }.rename_resource(client);
    }

    public static authenticationvserver[] get(nitro_service service) => (authenticationvserver[]) new authenticationvserver().get_resources(service, (options) null);

    public static authenticationvserver[] get(
      nitro_service service,
      options option)
    {
      return (authenticationvserver[]) new authenticationvserver().get_resources(service, option);
    }

    public static authenticationvserver get(nitro_service service, string name) => (authenticationvserver) new authenticationvserver()
    {
      name = name
    }.get_resource(service);

    public static authenticationvserver[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (authenticationvserver[]) null;
      authenticationvserver[] authenticationvserverArray1 = new authenticationvserver[name.Length];
      authenticationvserver[] authenticationvserverArray2 = new authenticationvserver[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        authenticationvserverArray2[index] = new authenticationvserver();
        authenticationvserverArray2[index].name = name[index];
        authenticationvserverArray1[index] = (authenticationvserver) authenticationvserverArray2[index].get_resource(service);
      }
      return authenticationvserverArray1;
    }

    public static authenticationvserver[] get_filtered(
      nitro_service service,
      string filter)
    {
      authenticationvserver authenticationvserver = new authenticationvserver();
      options option = new options();
      option.set_filter(filter);
      return (authenticationvserver[]) authenticationvserver.getfiltered(service, option);
    }

    public static authenticationvserver[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      authenticationvserver authenticationvserver = new authenticationvserver();
      options option = new options();
      option.set_filter(filter);
      return (authenticationvserver[]) authenticationvserver.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      authenticationvserver authenticationvserver = new authenticationvserver();
      options option = new options();
      option.set_count(true);
      authenticationvserver[] resources = (authenticationvserver[]) authenticationvserver.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      authenticationvserver authenticationvserver = new authenticationvserver();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationvserver[] authenticationvserverArray = (authenticationvserver[]) authenticationvserver.getfiltered(service, option);
      return authenticationvserverArray != null && authenticationvserverArray.Length > 0 ? authenticationvserverArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      authenticationvserver authenticationvserver = new authenticationvserver();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      authenticationvserver[] authenticationvserverArray = (authenticationvserver[]) authenticationvserver.getfiltered(service, option);
      return authenticationvserverArray != null && authenticationvserverArray.Length > 0 ? authenticationvserverArray[0].__count.Value : 0U;
    }

    private class authenticationvserver_response : base_response
    {
      public authenticationvserver[] authenticationvserver = (authenticationvserver[]) null;
    }

    public static class authenticationEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class stateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class cachetypeEnum
    {
      public const string TRANSPARENT = "TRANSPARENT";
      public const string REVERSE = "REVERSE";
      public const string FORWARD = "FORWARD";
    }

    public static class downstateflushEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class servicetypeEnum
    {
      public const string SSL = "SSL";
    }

    public static class valueEnum
    {
      public const string Certkey_not_bound = "Certkey not bound";
      public const string SSL_feature_disabled = "SSL feature disabled";
    }

    public static class disableprimaryondownEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class typeEnum
    {
      public const string CONTENT = "CONTENT";
      public const string ADDRESS = "ADDRESS";
    }

    public static class somethodEnum
    {
      public const string CONNECTION = "CONNECTION";
      public const string DYNAMICCONNECTION = "DYNAMICCONNECTION";
      public const string BANDWIDTH = "BANDWIDTH";
      public const string HEALTH = "HEALTH";
      public const string NONE = "NONE";
    }

    public static class sopersistenceEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class redirectEnum
    {
      public const string CACHE = "CACHE";
      public const string POLICY = "POLICY";
      public const string ORIGIN = "ORIGIN";
    }

    public static class appflowlogEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class precedenceEnum
    {
      public const string RULE = "RULE";
      public const string URL = "URL";
    }

    public static class curstateEnum
    {
      public const string UP = "UP";
      public const string DOWN = "DOWN";
      public const string UNKNOWN = "UNKNOWN";
      public const string BUSY = "BUSY";
      public const string OUT_OF_SERVICE = "OUT OF SERVICE";
      public const string GOING_OUT_OF_SERVICE = "GOING OUT OF SERVICE";
      public const string DOWN_WHEN_GOING_OUT_OF_SERVICE = "DOWN WHEN GOING OUT OF SERVICE";
      public const string NS_EMPTY_STR = "NS_EMPTY_STR";
      public const string Unknown = "Unknown";
      public const string DISABLED = "DISABLED";
    }
  }
}
