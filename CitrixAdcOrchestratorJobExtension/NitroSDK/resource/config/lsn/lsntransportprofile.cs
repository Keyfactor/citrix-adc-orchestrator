// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lsn.lsntransportprofile
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.lsn
{
  public class lsntransportprofile : base_resource
  {
    private string transportprofilenameField = (string) null;
    private string transportprotocolField = (string) null;
    private long? sessiontimeoutField = new long?();
    private long? finrsttimeoutField = new long?();
    private uint? stuntimeoutField = new uint?();
    private uint? synidletimeoutField = new uint?();
    private uint? portquotaField = new uint?();
    private uint? sessionquotaField = new uint?();
    private long? groupsessionlimitField = new long?();
    private string portpreserveparityField = (string) null;
    private string portpreserverangeField = (string) null;
    private string syncheckField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string transportprofilename
    {
      get => this.transportprofilenameField;
      set => this.transportprofilenameField = value;
    }

    public string transportprotocol
    {
      get => this.transportprotocolField;
      set => this.transportprotocolField = value;
    }

    public long? sessiontimeout
    {
      get => this.sessiontimeoutField;
      set => this.sessiontimeoutField = value;
    }

    public long? finrsttimeout
    {
      get => this.finrsttimeoutField;
      set => this.finrsttimeoutField = value;
    }

    public uint? stuntimeout
    {
      get => this.stuntimeoutField;
      set => this.stuntimeoutField = value;
    }

    public uint? synidletimeout
    {
      get => this.synidletimeoutField;
      set => this.synidletimeoutField = value;
    }

    public uint? portquota
    {
      get => this.portquotaField;
      set => this.portquotaField = value;
    }

    public uint? sessionquota
    {
      get => this.sessionquotaField;
      set => this.sessionquotaField = value;
    }

    public long? groupsessionlimit
    {
      get => this.groupsessionlimitField;
      set => this.groupsessionlimitField = value;
    }

    public string portpreserveparity
    {
      get => this.portpreserveparityField;
      set => this.portpreserveparityField = value;
    }

    public string portpreserverange
    {
      get => this.portpreserverangeField;
      set => this.portpreserverangeField = value;
    }

    public string syncheck
    {
      get => this.syncheckField;
      set => this.syncheckField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lsntransportprofile.lsntransportprofile_response lsntransportprofileResponse = new lsntransportprofile.lsntransportprofile_response();
      lsntransportprofile.lsntransportprofile_response resource = (lsntransportprofile.lsntransportprofile_response) service.get_payload_formatter().string_to_resource(lsntransportprofileResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lsntransportprofile;
    }

    internal override string get_object_name() => this.transportprofilename;

    public static base_response add(nitro_service client, lsntransportprofile resource) => new lsntransportprofile()
    {
      transportprofilename = resource.transportprofilename,
      transportprotocol = resource.transportprotocol,
      sessiontimeout = resource.sessiontimeout,
      finrsttimeout = resource.finrsttimeout,
      stuntimeout = resource.stuntimeout,
      synidletimeout = resource.synidletimeout,
      portquota = resource.portquota,
      sessionquota = resource.sessionquota,
      groupsessionlimit = resource.groupsessionlimit,
      portpreserveparity = resource.portpreserveparity,
      portpreserverange = resource.portpreserverange,
      syncheck = resource.syncheck
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      lsntransportprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsntransportprofile[] lsntransportprofileArray = new lsntransportprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsntransportprofileArray[index] = new lsntransportprofile();
          lsntransportprofileArray[index].transportprofilename = resources[index].transportprofilename;
          lsntransportprofileArray[index].transportprotocol = resources[index].transportprotocol;
          lsntransportprofileArray[index].sessiontimeout = resources[index].sessiontimeout;
          lsntransportprofileArray[index].finrsttimeout = resources[index].finrsttimeout;
          lsntransportprofileArray[index].stuntimeout = resources[index].stuntimeout;
          lsntransportprofileArray[index].synidletimeout = resources[index].synidletimeout;
          lsntransportprofileArray[index].portquota = resources[index].portquota;
          lsntransportprofileArray[index].sessionquota = resources[index].sessionquota;
          lsntransportprofileArray[index].groupsessionlimit = resources[index].groupsessionlimit;
          lsntransportprofileArray[index].portpreserveparity = resources[index].portpreserveparity;
          lsntransportprofileArray[index].portpreserverange = resources[index].portpreserverange;
          lsntransportprofileArray[index].syncheck = resources[index].syncheck;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) lsntransportprofileArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      string transportprofilename)
    {
      return new lsntransportprofile()
      {
        transportprofilename = transportprofilename
      }.delete_resource(client);
    }

    public static base_response delete(
      nitro_service client,
      lsntransportprofile resource)
    {
      return new lsntransportprofile()
      {
        transportprofilename = resource.transportprofilename
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      string[] transportprofilename)
    {
      base_responses baseResponses = (base_responses) null;
      if (transportprofilename != null && transportprofilename.Length > 0)
      {
        lsntransportprofile[] lsntransportprofileArray = new lsntransportprofile[transportprofilename.Length];
        for (int index = 0; index < transportprofilename.Length; ++index)
        {
          lsntransportprofileArray[index] = new lsntransportprofile();
          lsntransportprofileArray[index].transportprofilename = transportprofilename[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lsntransportprofileArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      lsntransportprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsntransportprofile[] lsntransportprofileArray = new lsntransportprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsntransportprofileArray[index] = new lsntransportprofile();
          lsntransportprofileArray[index].transportprofilename = resources[index].transportprofilename;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lsntransportprofileArray);
      }
      return baseResponses;
    }

    public static base_response update(
      nitro_service client,
      lsntransportprofile resource)
    {
      return new lsntransportprofile()
      {
        transportprofilename = resource.transportprofilename,
        sessiontimeout = resource.sessiontimeout,
        finrsttimeout = resource.finrsttimeout,
        stuntimeout = resource.stuntimeout,
        synidletimeout = resource.synidletimeout,
        portquota = resource.portquota,
        sessionquota = resource.sessionquota,
        groupsessionlimit = resource.groupsessionlimit,
        portpreserveparity = resource.portpreserveparity,
        portpreserverange = resource.portpreserverange,
        syncheck = resource.syncheck
      }.update_resource(client);
    }

    public static base_responses update(
      nitro_service client,
      lsntransportprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsntransportprofile[] lsntransportprofileArray = new lsntransportprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsntransportprofileArray[index] = new lsntransportprofile();
          lsntransportprofileArray[index].transportprofilename = resources[index].transportprofilename;
          lsntransportprofileArray[index].sessiontimeout = resources[index].sessiontimeout;
          lsntransportprofileArray[index].finrsttimeout = resources[index].finrsttimeout;
          lsntransportprofileArray[index].stuntimeout = resources[index].stuntimeout;
          lsntransportprofileArray[index].synidletimeout = resources[index].synidletimeout;
          lsntransportprofileArray[index].portquota = resources[index].portquota;
          lsntransportprofileArray[index].sessionquota = resources[index].sessionquota;
          lsntransportprofileArray[index].groupsessionlimit = resources[index].groupsessionlimit;
          lsntransportprofileArray[index].portpreserveparity = resources[index].portpreserveparity;
          lsntransportprofileArray[index].portpreserverange = resources[index].portpreserverange;
          lsntransportprofileArray[index].syncheck = resources[index].syncheck;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) lsntransportprofileArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string transportprofilename,
      string[] args)
    {
      return new lsntransportprofile()
      {
        transportprofilename = transportprofilename
      }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      lsntransportprofile resource,
      string[] args)
    {
      return new lsntransportprofile()
      {
        transportprofilename = resource.transportprofilename
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] transportprofilename,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (transportprofilename != null && transportprofilename.Length > 0)
      {
        lsntransportprofile[] lsntransportprofileArray = new lsntransportprofile[transportprofilename.Length];
        for (int index = 0; index < transportprofilename.Length; ++index)
        {
          lsntransportprofileArray[index] = new lsntransportprofile();
          lsntransportprofileArray[index].transportprofilename = transportprofilename[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) lsntransportprofileArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      lsntransportprofile[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsntransportprofile[] lsntransportprofileArray = new lsntransportprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsntransportprofileArray[index] = new lsntransportprofile();
          lsntransportprofileArray[index].transportprofilename = resources[index].transportprofilename;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) lsntransportprofileArray, args);
      }
      return baseResponses;
    }

    public static lsntransportprofile[] get(nitro_service service) => (lsntransportprofile[]) new lsntransportprofile().get_resources(service, (options) null);

    public static lsntransportprofile[] get(
      nitro_service service,
      options option)
    {
      return (lsntransportprofile[]) new lsntransportprofile().get_resources(service, option);
    }

    public static lsntransportprofile get(
      nitro_service service,
      string transportprofilename)
    {
      return (lsntransportprofile) new lsntransportprofile()
      {
        transportprofilename = transportprofilename
      }.get_resource(service);
    }

    public static lsntransportprofile[] get(
      nitro_service service,
      string[] transportprofilename)
    {
      if (transportprofilename == null || transportprofilename.Length <= 0)
        return (lsntransportprofile[]) null;
      lsntransportprofile[] lsntransportprofileArray1 = new lsntransportprofile[transportprofilename.Length];
      lsntransportprofile[] lsntransportprofileArray2 = new lsntransportprofile[transportprofilename.Length];
      for (int index = 0; index < transportprofilename.Length; ++index)
      {
        lsntransportprofileArray2[index] = new lsntransportprofile();
        lsntransportprofileArray2[index].transportprofilename = transportprofilename[index];
        lsntransportprofileArray1[index] = (lsntransportprofile) lsntransportprofileArray2[index].get_resource(service);
      }
      return lsntransportprofileArray1;
    }

    public static lsntransportprofile[] get_filtered(
      nitro_service service,
      string filter)
    {
      lsntransportprofile lsntransportprofile = new lsntransportprofile();
      options option = new options();
      option.set_filter(filter);
      return (lsntransportprofile[]) lsntransportprofile.getfiltered(service, option);
    }

    public static lsntransportprofile[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      lsntransportprofile lsntransportprofile = new lsntransportprofile();
      options option = new options();
      option.set_filter(filter);
      return (lsntransportprofile[]) lsntransportprofile.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      lsntransportprofile lsntransportprofile = new lsntransportprofile();
      options option = new options();
      option.set_count(true);
      lsntransportprofile[] resources = (lsntransportprofile[]) lsntransportprofile.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      lsntransportprofile lsntransportprofile = new lsntransportprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsntransportprofile[] lsntransportprofileArray = (lsntransportprofile[]) lsntransportprofile.getfiltered(service, option);
      return lsntransportprofileArray != null && lsntransportprofileArray.Length > 0 ? lsntransportprofileArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      lsntransportprofile lsntransportprofile = new lsntransportprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsntransportprofile[] lsntransportprofileArray = (lsntransportprofile[]) lsntransportprofile.getfiltered(service, option);
      return lsntransportprofileArray != null && lsntransportprofileArray.Length > 0 ? lsntransportprofileArray[0].__count.Value : 0U;
    }

    private class lsntransportprofile_response : base_response
    {
      public lsntransportprofile[] lsntransportprofile = (lsntransportprofile[]) null;
    }

    public static class portpreserveparityEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class transportprotocolEnum
    {
      public const string TCP = "TCP";
      public const string UDP = "UDP";
      public const string ICMP = "ICMP";
    }

    public static class syncheckEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class portpreserverangeEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
