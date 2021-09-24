// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.snmp.snmptrap
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.snmp
{
  public class snmptrap : base_resource
  {
    private string trapclassField = (string) null;
    private string trapdestinationField = (string) null;
    private string versionField = (string) null;
    private uint? tdField = new uint?();
    private ushort? destportField = new ushort?();
    private string communitynameField = (string) null;
    private string srcipField = (string) null;
    private string severityField = (string) null;
    private string allpartitionsField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string trapclass
    {
      get => this.trapclassField;
      set => this.trapclassField = value;
    }

    public string trapdestination
    {
      get => this.trapdestinationField;
      set => this.trapdestinationField = value;
    }

    public string version
    {
      get => this.versionField;
      set => this.versionField = value;
    }

    public uint? td
    {
      get => this.tdField;
      set => this.tdField = value;
    }

    public ushort? destport
    {
      get => this.destportField;
      set => this.destportField = value;
    }

    public string communityname
    {
      get => this.communitynameField;
      set => this.communitynameField = value;
    }

    public string srcip
    {
      get => this.srcipField;
      set => this.srcipField = value;
    }

    public string severity
    {
      get => this.severityField;
      set => this.severityField = value;
    }

    public string allpartitions
    {
      get => this.allpartitionsField;
      set => this.allpartitionsField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      snmptrap.snmptrap_response snmptrapResponse = new snmptrap.snmptrap_response();
      snmptrap.snmptrap_response resource = (snmptrap.snmptrap_response) service.get_payload_formatter().string_to_resource(snmptrapResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.snmptrap;
    }

    internal override string get_object_name() => this.trapclass;

    public static base_response add(nitro_service client, snmptrap resource) => new snmptrap()
    {
      trapclass = resource.trapclass,
      trapdestination = resource.trapdestination,
      version = resource.version,
      td = resource.td,
      destport = resource.destport,
      communityname = resource.communityname,
      srcip = resource.srcip,
      severity = resource.severity,
      allpartitions = resource.allpartitions
    }.add_resource(client);

    public static base_responses add(nitro_service client, snmptrap[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        snmptrap[] snmptrapArray = new snmptrap[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          snmptrapArray[index] = new snmptrap();
          snmptrapArray[index].trapclass = resources[index].trapclass;
          snmptrapArray[index].trapdestination = resources[index].trapdestination;
          snmptrapArray[index].version = resources[index].version;
          snmptrapArray[index].td = resources[index].td;
          snmptrapArray[index].destport = resources[index].destport;
          snmptrapArray[index].communityname = resources[index].communityname;
          snmptrapArray[index].srcip = resources[index].srcip;
          snmptrapArray[index].severity = resources[index].severity;
          snmptrapArray[index].allpartitions = resources[index].allpartitions;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) snmptrapArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string trapclass) => new snmptrap()
    {
      trapclass = trapclass
    }.delete_resource(client);

    public static base_response delete(nitro_service client, snmptrap resource) => new snmptrap()
    {
      trapclass = resource.trapclass,
      trapdestination = resource.trapdestination,
      version = resource.version,
      td = resource.td
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] trapclass)
    {
      base_responses baseResponses = (base_responses) null;
      if (trapclass != null && trapclass.Length > 0)
      {
        snmptrap[] snmptrapArray = new snmptrap[trapclass.Length];
        for (int index = 0; index < trapclass.Length; ++index)
        {
          snmptrapArray[index] = new snmptrap();
          snmptrapArray[index].trapclass = trapclass[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) snmptrapArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, snmptrap[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        snmptrap[] snmptrapArray = new snmptrap[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          snmptrapArray[index] = new snmptrap();
          snmptrapArray[index].trapclass = resources[index].trapclass;
          snmptrapArray[index].trapdestination = resources[index].trapdestination;
          snmptrapArray[index].version = resources[index].version;
          snmptrapArray[index].td = resources[index].td;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) snmptrapArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, snmptrap resource) => new snmptrap()
    {
      trapclass = resource.trapclass,
      trapdestination = resource.trapdestination,
      version = resource.version,
      td = resource.td,
      destport = resource.destport,
      communityname = resource.communityname,
      srcip = resource.srcip,
      severity = resource.severity,
      allpartitions = resource.allpartitions
    }.update_resource(client);

    public static base_responses update(nitro_service client, snmptrap[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        snmptrap[] snmptrapArray = new snmptrap[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          snmptrapArray[index] = new snmptrap();
          snmptrapArray[index].trapclass = resources[index].trapclass;
          snmptrapArray[index].trapdestination = resources[index].trapdestination;
          snmptrapArray[index].version = resources[index].version;
          snmptrapArray[index].td = resources[index].td;
          snmptrapArray[index].destport = resources[index].destport;
          snmptrapArray[index].communityname = resources[index].communityname;
          snmptrapArray[index].srcip = resources[index].srcip;
          snmptrapArray[index].severity = resources[index].severity;
          snmptrapArray[index].allpartitions = resources[index].allpartitions;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) snmptrapArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      snmptrap resource,
      string[] args)
    {
      return new snmptrap()
      {
        trapclass = resource.trapclass,
        trapdestination = resource.trapdestination,
        version = resource.version,
        td = resource.td
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      snmptrap[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        snmptrap[] snmptrapArray = new snmptrap[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          snmptrapArray[index] = new snmptrap();
          snmptrapArray[index].trapclass = resources[index].trapclass;
          snmptrapArray[index].trapdestination = resources[index].trapdestination;
          snmptrapArray[index].version = resources[index].version;
          snmptrapArray[index].td = resources[index].td;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) snmptrapArray, args);
      }
      return baseResponses;
    }

    public static snmptrap[] get(nitro_service service) => (snmptrap[]) new snmptrap().get_resources(service, (options) null);

    public static snmptrap[] get(nitro_service service, options option) => (snmptrap[]) new snmptrap().get_resources(service, option);

    public static snmptrap get(nitro_service service, snmptrap obj)
    {
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (snmptrap) obj.get_resource(service, option);
    }

    public static snmptrap[] get(nitro_service service, snmptrap[] obj)
    {
      if (obj == null || obj.Length <= 0)
        return (snmptrap[]) null;
      snmptrap[] snmptrapArray = new snmptrap[obj.Length];
      for (int index = 0; index < obj.Length; ++index)
      {
        options option = new options();
        option.set_args(nitro_util.object_to_string_withoutquotes((object) obj[index]));
        snmptrapArray[index] = (snmptrap) obj[index].get_resource(service, option);
      }
      return snmptrapArray;
    }

    public static snmptrap[] get_filtered(nitro_service service, string filter)
    {
      snmptrap snmptrap = new snmptrap();
      options option = new options();
      option.set_filter(filter);
      return (snmptrap[]) snmptrap.getfiltered(service, option);
    }

    public static snmptrap[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      snmptrap snmptrap = new snmptrap();
      options option = new options();
      option.set_filter(filter);
      return (snmptrap[]) snmptrap.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      snmptrap snmptrap = new snmptrap();
      options option = new options();
      option.set_count(true);
      snmptrap[] resources = (snmptrap[]) snmptrap.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      snmptrap snmptrap = new snmptrap();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      snmptrap[] snmptrapArray = (snmptrap[]) snmptrap.getfiltered(service, option);
      return snmptrapArray != null && snmptrapArray.Length > 0 ? snmptrapArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      snmptrap snmptrap = new snmptrap();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      snmptrap[] snmptrapArray = (snmptrap[]) snmptrap.getfiltered(service, option);
      return snmptrapArray != null && snmptrapArray.Length > 0 ? snmptrapArray[0].__count.Value : 0U;
    }

    private class snmptrap_response : base_response
    {
      public snmptrap[] snmptrap = (snmptrap[]) null;
    }

    public static class allpartitionsEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class trapclassEnum
    {
      public const string generic = "generic";
      public const string specific = "specific";
    }

    public static class severityEnum
    {
      public const string Critical = "Critical";
      public const string Major = "Major";
      public const string Minor = "Minor";
      public const string Warning = "Warning";
      public const string Informational = "Informational";
    }

    public static class versionEnum
    {
      public const string V1 = "V1";
      public const string V2 = "V2";
      public const string V3 = "V3";
    }
  }
}
