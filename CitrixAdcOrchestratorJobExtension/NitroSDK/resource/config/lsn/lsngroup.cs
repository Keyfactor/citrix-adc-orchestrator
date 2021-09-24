// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lsn.lsngroup
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.lsn
{
  public class lsngroup : base_resource
  {
    private string groupnameField = (string) null;
    private string clientnameField = (string) null;
    private string nattypeField = (string) null;
    private uint? portblocksizeField = new uint?();
    private string loggingField = (string) null;
    private string sessionloggingField = (string) null;
    private string sessionsyncField = (string) null;
    private uint? snmptraplimitField = new uint?();
    private string ftpField = (string) null;
    private string pptpField = (string) null;
    private string sipalgField = (string) null;
    private string rtspalgField = (string) null;
    private string ip6profileField = (string) null;
    private uint? groupidField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string groupname
    {
      get => this.groupnameField;
      set => this.groupnameField = value;
    }

    public string clientname
    {
      get => this.clientnameField;
      set => this.clientnameField = value;
    }

    public string nattype
    {
      get => this.nattypeField;
      set => this.nattypeField = value;
    }

    public uint? portblocksize
    {
      get => this.portblocksizeField;
      set => this.portblocksizeField = value;
    }

    public string logging
    {
      get => this.loggingField;
      set => this.loggingField = value;
    }

    public string sessionlogging
    {
      get => this.sessionloggingField;
      set => this.sessionloggingField = value;
    }

    public string sessionsync
    {
      get => this.sessionsyncField;
      set => this.sessionsyncField = value;
    }

    public uint? snmptraplimit
    {
      get => this.snmptraplimitField;
      set => this.snmptraplimitField = value;
    }

    public string ftp
    {
      get => this.ftpField;
      set => this.ftpField = value;
    }

    public string pptp
    {
      get => this.pptpField;
      set => this.pptpField = value;
    }

    public string sipalg
    {
      get => this.sipalgField;
      set => this.sipalgField = value;
    }

    public string rtspalg
    {
      get => this.rtspalgField;
      set => this.rtspalgField = value;
    }

    public string ip6profile
    {
      get => this.ip6profileField;
      set => this.ip6profileField = value;
    }

    public uint? groupid
    {
      get => this.groupidField;
      private set => this.groupidField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lsngroup.lsngroup_response lsngroupResponse = new lsngroup.lsngroup_response();
      lsngroup.lsngroup_response resource = (lsngroup.lsngroup_response) service.get_payload_formatter().string_to_resource(lsngroupResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lsngroup;
    }

    internal override string get_object_name() => this.groupname;

    public static base_response add(nitro_service client, lsngroup resource) => new lsngroup()
    {
      groupname = resource.groupname,
      clientname = resource.clientname,
      nattype = resource.nattype,
      portblocksize = resource.portblocksize,
      logging = resource.logging,
      sessionlogging = resource.sessionlogging,
      sessionsync = resource.sessionsync,
      snmptraplimit = resource.snmptraplimit,
      ftp = resource.ftp,
      pptp = resource.pptp,
      sipalg = resource.sipalg,
      rtspalg = resource.rtspalg,
      ip6profile = resource.ip6profile
    }.add_resource(client);

    public static base_responses add(nitro_service client, lsngroup[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsngroup[] lsngroupArray = new lsngroup[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsngroupArray[index] = new lsngroup();
          lsngroupArray[index].groupname = resources[index].groupname;
          lsngroupArray[index].clientname = resources[index].clientname;
          lsngroupArray[index].nattype = resources[index].nattype;
          lsngroupArray[index].portblocksize = resources[index].portblocksize;
          lsngroupArray[index].logging = resources[index].logging;
          lsngroupArray[index].sessionlogging = resources[index].sessionlogging;
          lsngroupArray[index].sessionsync = resources[index].sessionsync;
          lsngroupArray[index].snmptraplimit = resources[index].snmptraplimit;
          lsngroupArray[index].ftp = resources[index].ftp;
          lsngroupArray[index].pptp = resources[index].pptp;
          lsngroupArray[index].sipalg = resources[index].sipalg;
          lsngroupArray[index].rtspalg = resources[index].rtspalg;
          lsngroupArray[index].ip6profile = resources[index].ip6profile;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) lsngroupArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string groupname) => new lsngroup()
    {
      groupname = groupname
    }.delete_resource(client);

    public static base_response delete(nitro_service client, lsngroup resource) => new lsngroup()
    {
      groupname = resource.groupname
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] groupname)
    {
      base_responses baseResponses = (base_responses) null;
      if (groupname != null && groupname.Length > 0)
      {
        lsngroup[] lsngroupArray = new lsngroup[groupname.Length];
        for (int index = 0; index < groupname.Length; ++index)
        {
          lsngroupArray[index] = new lsngroup();
          lsngroupArray[index].groupname = groupname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lsngroupArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, lsngroup[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsngroup[] lsngroupArray = new lsngroup[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsngroupArray[index] = new lsngroup();
          lsngroupArray[index].groupname = resources[index].groupname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lsngroupArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, lsngroup resource) => new lsngroup()
    {
      groupname = resource.groupname,
      portblocksize = resource.portblocksize,
      logging = resource.logging,
      sessionlogging = resource.sessionlogging,
      sessionsync = resource.sessionsync,
      snmptraplimit = resource.snmptraplimit,
      ftp = resource.ftp,
      pptp = resource.pptp,
      sipalg = resource.sipalg,
      rtspalg = resource.rtspalg
    }.update_resource(client);

    public static base_responses update(nitro_service client, lsngroup[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsngroup[] lsngroupArray = new lsngroup[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsngroupArray[index] = new lsngroup();
          lsngroupArray[index].groupname = resources[index].groupname;
          lsngroupArray[index].portblocksize = resources[index].portblocksize;
          lsngroupArray[index].logging = resources[index].logging;
          lsngroupArray[index].sessionlogging = resources[index].sessionlogging;
          lsngroupArray[index].sessionsync = resources[index].sessionsync;
          lsngroupArray[index].snmptraplimit = resources[index].snmptraplimit;
          lsngroupArray[index].ftp = resources[index].ftp;
          lsngroupArray[index].pptp = resources[index].pptp;
          lsngroupArray[index].sipalg = resources[index].sipalg;
          lsngroupArray[index].rtspalg = resources[index].rtspalg;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) lsngroupArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string groupname,
      string[] args)
    {
      return new lsngroup() { groupname = groupname }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      lsngroup resource,
      string[] args)
    {
      return new lsngroup()
      {
        groupname = resource.groupname
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] groupname,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (groupname != null && groupname.Length > 0)
      {
        lsngroup[] lsngroupArray = new lsngroup[groupname.Length];
        for (int index = 0; index < groupname.Length; ++index)
        {
          lsngroupArray[index] = new lsngroup();
          lsngroupArray[index].groupname = groupname[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) lsngroupArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      lsngroup[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsngroup[] lsngroupArray = new lsngroup[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsngroupArray[index] = new lsngroup();
          lsngroupArray[index].groupname = resources[index].groupname;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) lsngroupArray, args);
      }
      return baseResponses;
    }

    public static lsngroup[] get(nitro_service service) => (lsngroup[]) new lsngroup().get_resources(service, (options) null);

    public static lsngroup[] get(nitro_service service, options option) => (lsngroup[]) new lsngroup().get_resources(service, option);

    public static lsngroup get(nitro_service service, string groupname) => (lsngroup) new lsngroup()
    {
      groupname = groupname
    }.get_resource(service);

    public static lsngroup[] get(nitro_service service, string[] groupname)
    {
      if (groupname == null || groupname.Length <= 0)
        return (lsngroup[]) null;
      lsngroup[] lsngroupArray1 = new lsngroup[groupname.Length];
      lsngroup[] lsngroupArray2 = new lsngroup[groupname.Length];
      for (int index = 0; index < groupname.Length; ++index)
      {
        lsngroupArray2[index] = new lsngroup();
        lsngroupArray2[index].groupname = groupname[index];
        lsngroupArray1[index] = (lsngroup) lsngroupArray2[index].get_resource(service);
      }
      return lsngroupArray1;
    }

    public static lsngroup[] get_filtered(nitro_service service, string filter)
    {
      lsngroup lsngroup = new lsngroup();
      options option = new options();
      option.set_filter(filter);
      return (lsngroup[]) lsngroup.getfiltered(service, option);
    }

    public static lsngroup[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      lsngroup lsngroup = new lsngroup();
      options option = new options();
      option.set_filter(filter);
      return (lsngroup[]) lsngroup.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      lsngroup lsngroup = new lsngroup();
      options option = new options();
      option.set_count(true);
      lsngroup[] resources = (lsngroup[]) lsngroup.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      lsngroup lsngroup = new lsngroup();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsngroup[] lsngroupArray = (lsngroup[]) lsngroup.getfiltered(service, option);
      return lsngroupArray != null && lsngroupArray.Length > 0 ? lsngroupArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      lsngroup lsngroup = new lsngroup();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsngroup[] lsngroupArray = (lsngroup[]) lsngroup.getfiltered(service, option);
      return lsngroupArray != null && lsngroupArray.Length > 0 ? lsngroupArray[0].__count.Value : 0U;
    }

    private class lsngroup_response : base_response
    {
      public lsngroup[] lsngroup = (lsngroup[]) null;
    }

    public static class sessionloggingEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class sipalgEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class pptpEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class rtspalgEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class ftpEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class nattypeEnum
    {
      public const string DYNAMIC = "DYNAMIC";
      public const string DETERMINISTIC = "DETERMINISTIC";
    }

    public static class sessionsyncEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class loggingEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
