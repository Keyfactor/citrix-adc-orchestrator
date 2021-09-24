// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.snmp.snmpalarm
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.snmp
{
  public class snmpalarm : base_resource
  {
    private string trapnameField = (string) null;
    private uint? thresholdvalueField = new uint?();
    private uint? normalvalueField = new uint?();
    private long? timeField = new long?();
    private string stateField = (string) null;
    private string severityField = (string) null;
    private string loggingField = (string) null;
    private long? timeoutField = new long?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string trapname
    {
      get => this.trapnameField;
      set => this.trapnameField = value;
    }

    public uint? thresholdvalue
    {
      get => this.thresholdvalueField;
      set => this.thresholdvalueField = value;
    }

    public uint? normalvalue
    {
      get => this.normalvalueField;
      set => this.normalvalueField = value;
    }

    public long? time
    {
      get => this.timeField;
      set => this.timeField = value;
    }

    public string state
    {
      get => this.stateField;
      set => this.stateField = value;
    }

    public string severity
    {
      get => this.severityField;
      set => this.severityField = value;
    }

    public string logging
    {
      get => this.loggingField;
      set => this.loggingField = value;
    }

    public long? timeout
    {
      get => this.timeoutField;
      private set => this.timeoutField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      snmpalarm.snmpalarm_response snmpalarmResponse = new snmpalarm.snmpalarm_response();
      snmpalarm.snmpalarm_response resource = (snmpalarm.snmpalarm_response) service.get_payload_formatter().string_to_resource(snmpalarmResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.snmpalarm;
    }

    internal override string get_object_name() => this.trapname;

    public static base_response update(nitro_service client, snmpalarm resource) => new snmpalarm()
    {
      trapname = resource.trapname,
      thresholdvalue = resource.thresholdvalue,
      normalvalue = resource.normalvalue,
      time = resource.time,
      state = resource.state,
      severity = resource.severity,
      logging = resource.logging
    }.update_resource(client);

    public static base_responses update(nitro_service client, snmpalarm[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        snmpalarm[] snmpalarmArray = new snmpalarm[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          snmpalarmArray[index] = new snmpalarm();
          snmpalarmArray[index].trapname = resources[index].trapname;
          snmpalarmArray[index].thresholdvalue = resources[index].thresholdvalue;
          snmpalarmArray[index].normalvalue = resources[index].normalvalue;
          snmpalarmArray[index].time = resources[index].time;
          snmpalarmArray[index].state = resources[index].state;
          snmpalarmArray[index].severity = resources[index].severity;
          snmpalarmArray[index].logging = resources[index].logging;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) snmpalarmArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string trapname,
      string[] args)
    {
      return new snmpalarm() { trapname = trapname }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      snmpalarm resource,
      string[] args)
    {
      return new snmpalarm()
      {
        trapname = resource.trapname
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] trapname,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (trapname != null && trapname.Length > 0)
      {
        snmpalarm[] snmpalarmArray = new snmpalarm[trapname.Length];
        for (int index = 0; index < trapname.Length; ++index)
        {
          snmpalarmArray[index] = new snmpalarm();
          snmpalarmArray[index].trapname = trapname[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) snmpalarmArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      snmpalarm[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        snmpalarm[] snmpalarmArray = new snmpalarm[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          snmpalarmArray[index] = new snmpalarm();
          snmpalarmArray[index].trapname = resources[index].trapname;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) snmpalarmArray, args);
      }
      return baseResponses;
    }

    public static base_response enable(nitro_service client, string trapname) => new snmpalarm()
    {
      trapname = trapname
    }.perform_operation_byaction(client, nameof (enable));

    public static base_response enable(nitro_service client, snmpalarm resource) => new snmpalarm()
    {
      trapname = resource.trapname
    }.perform_operation_byaction(client, nameof (enable));

    public static base_responses enable(nitro_service client, string[] trapname)
    {
      base_responses baseResponses = (base_responses) null;
      if (trapname != null && trapname.Length > 0)
      {
        snmpalarm[] snmpalarmArray = new snmpalarm[trapname.Length];
        for (int index = 0; index < trapname.Length; ++index)
        {
          snmpalarmArray[index] = new snmpalarm();
          snmpalarmArray[index].trapname = trapname[index];
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) snmpalarmArray, nameof (enable));
      }
      return baseResponses;
    }

    public static base_responses enable(nitro_service client, snmpalarm[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        snmpalarm[] snmpalarmArray = new snmpalarm[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          snmpalarmArray[index] = new snmpalarm();
          snmpalarmArray[index].trapname = resources[index].trapname;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) snmpalarmArray, nameof (enable));
      }
      return baseResponses;
    }

    public static base_response disable(nitro_service client, string trapname) => new snmpalarm()
    {
      trapname = trapname
    }.perform_operation_byaction(client, nameof (disable));

    public static base_response disable(nitro_service client, snmpalarm resource) => new snmpalarm()
    {
      trapname = resource.trapname
    }.perform_operation_byaction(client, nameof (disable));

    public static base_responses disable(nitro_service client, string[] trapname)
    {
      base_responses baseResponses = (base_responses) null;
      if (trapname != null && trapname.Length > 0)
      {
        snmpalarm[] snmpalarmArray = new snmpalarm[trapname.Length];
        for (int index = 0; index < trapname.Length; ++index)
        {
          snmpalarmArray[index] = new snmpalarm();
          snmpalarmArray[index].trapname = trapname[index];
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) snmpalarmArray, nameof (disable));
      }
      return baseResponses;
    }

    public static base_responses disable(nitro_service client, snmpalarm[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        snmpalarm[] snmpalarmArray = new snmpalarm[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          snmpalarmArray[index] = new snmpalarm();
          snmpalarmArray[index].trapname = resources[index].trapname;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) snmpalarmArray, nameof (disable));
      }
      return baseResponses;
    }

    public static snmpalarm[] get(nitro_service service) => (snmpalarm[]) new snmpalarm().get_resources(service, (options) null);

    public static snmpalarm[] get(nitro_service service, options option) => (snmpalarm[]) new snmpalarm().get_resources(service, option);

    public static snmpalarm get(nitro_service service, string trapname) => (snmpalarm) new snmpalarm()
    {
      trapname = trapname
    }.get_resource(service);

    public static snmpalarm[] get(nitro_service service, string[] trapname)
    {
      if (trapname == null || trapname.Length <= 0)
        return (snmpalarm[]) null;
      snmpalarm[] snmpalarmArray1 = new snmpalarm[trapname.Length];
      snmpalarm[] snmpalarmArray2 = new snmpalarm[trapname.Length];
      for (int index = 0; index < trapname.Length; ++index)
      {
        snmpalarmArray2[index] = new snmpalarm();
        snmpalarmArray2[index].trapname = trapname[index];
        snmpalarmArray1[index] = (snmpalarm) snmpalarmArray2[index].get_resource(service);
      }
      return snmpalarmArray1;
    }

    public static snmpalarm[] get_filtered(nitro_service service, string filter)
    {
      snmpalarm snmpalarm = new snmpalarm();
      options option = new options();
      option.set_filter(filter);
      return (snmpalarm[]) snmpalarm.getfiltered(service, option);
    }

    public static snmpalarm[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      snmpalarm snmpalarm = new snmpalarm();
      options option = new options();
      option.set_filter(filter);
      return (snmpalarm[]) snmpalarm.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      snmpalarm snmpalarm = new snmpalarm();
      options option = new options();
      option.set_count(true);
      snmpalarm[] resources = (snmpalarm[]) snmpalarm.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      snmpalarm snmpalarm = new snmpalarm();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      snmpalarm[] snmpalarmArray = (snmpalarm[]) snmpalarm.getfiltered(service, option);
      return snmpalarmArray != null && snmpalarmArray.Length > 0 ? snmpalarmArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      snmpalarm snmpalarm = new snmpalarm();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      snmpalarm[] snmpalarmArray = (snmpalarm[]) snmpalarm.getfiltered(service, option);
      return snmpalarmArray != null && snmpalarmArray.Length > 0 ? snmpalarmArray[0].__count.Value : 0U;
    }

    private class snmpalarm_response : base_response
    {
      public snmpalarm[] snmpalarm = (snmpalarm[]) null;
    }

    public static class trapnameEnum
    {
      public const string CPU_USAGE = "CPU-USAGE";
      public const string AVERAGE_CPU = "AVERAGE-CPU";
      public const string MEMORY = "MEMORY";
      public const string MGMT_CPU_USAGE = "MGMT-CPU-USAGE";
      public const string SYNFLOOD = "SYNFLOOD";
      public const string VSERVER_REQRATE = "VSERVER-REQRATE";
      public const string SERVICE_REQRATE = "SERVICE-REQRATE";
      public const string ENTITY_RXRATE = "ENTITY-RXRATE";
      public const string ENTITY_TXRATE = "ENTITY-TXRATE";
      public const string ENTITY_SYNFLOOD = "ENTITY-SYNFLOOD";
      public const string SERVICE_MAXCLIENTS = "SERVICE-MAXCLIENTS";
      public const string HA_STATE_CHANGE = "HA-STATE-CHANGE";
      public const string ENTITY_STATE = "ENTITY-STATE";
      public const string CONFIG_CHANGE = "CONFIG-CHANGE";
      public const string CONFIG_SAVE = "CONFIG-SAVE";
      public const string SERVICEGROUP_MEMBER_REQRATE = "SERVICEGROUP-MEMBER-REQRATE";
      public const string SERVICEGROUP_MEMBER_MAXCLIENTS = "SERVICEGROUP-MEMBER-MAXCLIENTS";
      public const string MONITOR_RTO_THRESHOLD = "MONITOR-RTO-THRESHOLD";
      public const string LOGIN_FAILURE = "LOGIN-FAILURE";
      public const string SSL_CERT_EXPIRY = "SSL-CERT-EXPIRY";
      public const string FAN_SPEED_LOW = "FAN-SPEED-LOW";
      public const string VOLTAGE_LOW = "VOLTAGE-LOW";
      public const string VOLTAGE_HIGH = "VOLTAGE-HIGH";
      public const string TEMPERATURE_HIGH = "TEMPERATURE-HIGH";
      public const string CPU_TEMPERATURE_HIGH = "CPU-TEMPERATURE-HIGH";
      public const string POWER_SUPPLY_FAILURE = "POWER-SUPPLY-FAILURE";
      public const string DISK_USAGE_HIGH = "DISK-USAGE-HIGH";
      public const string INTERFACE_THROUGHPUT_LOW = "INTERFACE-THROUGHPUT-LOW";
      public const string MON_PROBE_FAILED = "MON_PROBE_FAILED";
      public const string HA_VERSION_MISMATCH = "HA-VERSION-MISMATCH";
      public const string HA_SYNC_FAILURE = "HA-SYNC-FAILURE";
      public const string HA_NO_HEARTBEATS = "HA-NO-HEARTBEATS";
      public const string HA_BAD_SECONDARY_STATE = "HA-BAD-SECONDARY-STATE";
      public const string INTERFACE_BW_USAGE = "INTERFACE-BW-USAGE";
      public const string RATE_LIMIT_THRESHOLD_EXCEEDED = "RATE-LIMIT-THRESHOLD-EXCEEDED";
      public const string ENTITY_NAME_CHANGE = "ENTITY-NAME-CHANGE";
      public const string HA_PROP_FAILURE = "HA-PROP-FAILURE";
      public const string IP_CONFLICT = "IP-CONFLICT";
      public const string PF_RL_RATE_THRESHOLD = "PF-RL-RATE-THRESHOLD";
      public const string PF_RL_PPS_THRESHOLD = "PF-RL-PPS-THRESHOLD";
      public const string PF_RL_RATE_PKTS_DROPPED = "PF-RL-RATE-PKTS-DROPPED";
      public const string PF_RL_PPS_PKTS_DROPPED = "PF-RL-PPS-PKTS-DROPPED";
      public const string APPFW_START_URL = "APPFW-START-URL";
      public const string APPFW_DENY_URL = "APPFW-DENY-URL";
      public const string APPFW_VIOLATIONS_TYPE = "APPFW-VIOLATIONS-TYPE";
      public const string APPFW_REFERER_HEADER = "APPFW-REFERER-HEADER";
      public const string APPFW_CSRF_TAG = "APPFW-CSRF-TAG";
      public const string APPFW_COOKIE = "APPFW-COOKIE";
      public const string APPFW_FIELD_CONSISTENCY = "APPFW-FIELD-CONSISTENCY";
      public const string APPFW_BUFFER_OVERFLOW = "APPFW-BUFFER-OVERFLOW";
      public const string APPFW_FIELD_FORMAT = "APPFW-FIELD-FORMAT";
      public const string APPFW_SAFE_COMMERCE = "APPFW-SAFE-COMMERCE";
      public const string APPFW_SAFE_OBJECT = "APPFW-SAFE-OBJECT";
      public const string APPFW_POLICY_HIT = "APPFW-POLICY-HIT";
      public const string APPFW_XSS = "APPFW-XSS";
      public const string APPFW_XML_XSS = "APPFW-XML-XSS";
      public const string APPFW_SQL = "APPFW-SQL";
      public const string APPFW_XML_SQL = "APPFW-XML-SQL";
      public const string APPFW_XML_ATTACHMENT = "APPFW-XML-ATTACHMENT";
      public const string APPFW_XML_DOS = "APPFW-XML-DOS";
      public const string APPFW_XML_VALIDATION = "APPFW-XML-VALIDATION";
      public const string APPFW_XML_WSI = "APPFW-XML-WSI";
      public const string APPFW_XML_SCHEMA_COMPILE = "APPFW-XML-SCHEMA-COMPILE";
      public const string APPFW_XML_SOAP_FAULT = "APPFW-XML-SOAP-FAULT";
      public const string DNSKEY_EXPIRY = "DNSKEY-EXPIRY";
      public const string HA_LICENSE_MISMATCH = "HA-LICENSE-MISMATCH";
      public const string SSL_CARD_FAILED = "SSL-CARD-FAILED";
      public const string SSL_CARD_NORMAL = "SSL-CARD-NORMAL";
      public const string WARM_RESTART_EVENT = "WARM-RESTART-EVENT";
      public const string HARD_DISK_DRIVE_ERRORS = "HARD-DISK-DRIVE-ERRORS";
      public const string COMPACT_FLASH_ERRORS = "COMPACT-FLASH-ERRORS";
      public const string CALLHOME_UPLOAD_EVENT = "CALLHOME-UPLOAD-EVENT";
      public const string _1024KEY_EXCHANGE_RATE = "1024KEY-EXCHANGE-RATE";
      public const string _2048KEY_EXCHANGE_RATE = "2048KEY-EXCHANGE-RATE";
      public const string _4096KEY_EXCHANGE_RATE = "4096KEY-EXCHANGE-RATE";
      public const string SSL_CUR_SESSION_INUSE = "SSL-CUR-SESSION-INUSE";
      public const string CLUSTER_NODE_HEALTH = "CLUSTER-NODE-HEALTH";
      public const string CLUSTER_NODE_QUORUM = "CLUSTER-NODE-QUORUM";
      public const string CLUSTER_VERSION_MISMATCH = "CLUSTER-VERSION-MISMATCH";
      public const string CLUSTER_CCO_CHANGE = "CLUSTER-CCO-CHANGE";
      public const string CLUSTER_OVS_CHANGE = "CLUSTER-OVS-CHANGE";
      public const string CLUSTER_SYNC_FAILURE = "CLUSTER-SYNC-FAILURE";
      public const string CLUSTER_PROP_FAILURE = "CLUSTER-PROP-FAILURE";
      public const string HA_STICKY_PRIMARY = "HA-STICKY-PRIMARY";
      public const string INBAND_PROTOCOL_VERSION_MISMATCH = "INBAND-PROTOCOL-VERSION-MISMATCH";
      public const string SSL_CHIP_REINIT = "SSL-CHIP-REINIT";
      public const string VRID_STATE_CHANGE = "VRID-STATE-CHANGE";
      public const string PORT_ALLOC_FAILED = "PORT-ALLOC-FAILED";
      public const string LLDP_REMOTE_CHANGE = "LLDP-REMOTE-CHANGE";
      public const string DUPLICATE_IPV6 = "DUPLICATE-IPV6";
      public const string PARTITION_CONFIG_EVENT = "PARTITION-CONFIG-EVENT";
      public const string PARTITION_SWITCHED = "PARTITION-SWITCHED";
      public const string LSN_PORTALLOC_FAILED = "LSN-PORTALLOC-FAILED";
      public const string LSN_PORTQUOTA_EXCEED = "LSN-PORTQUOTA-EXCEED";
      public const string LSN_SESSIONQUOTA_EXCEED = "LSN-SESSIONQUOTA-EXCEED";
      public const string VSERVER_SPILLOVER = "VSERVER-SPILLOVER";
      public const string PARTITION_RATE_LIMIT = "PARTITION-RATE-LIMIT";
      public const string CLUSTER_BACKPLANE_HB_MISSING = "CLUSTER-BACKPLANE-HB-MISSING";
    }

    public static class stateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class severityEnum
    {
      public const string Critical = "Critical";
      public const string Major = "Major";
      public const string Minor = "Minor";
      public const string Warning = "Warning";
      public const string Informational = "Informational";
    }

    public static class loggingEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
