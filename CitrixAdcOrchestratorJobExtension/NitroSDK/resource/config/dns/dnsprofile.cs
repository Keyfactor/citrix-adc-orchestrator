// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.dns.dnsprofile
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.dns
{
  public class dnsprofile : base_resource
  {
    private string dnsprofilenameField = (string) null;
    private string dnsqueryloggingField = (string) null;
    private string dnsanswersecloggingField = (string) null;
    private string dnsextendedloggingField = (string) null;
    private string dnserrorloggingField = (string) null;
    private string cacherecordsField = (string) null;
    private string cachenegativeresponsesField = (string) null;
    private uint? referencecountField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string dnsprofilename
    {
      get => this.dnsprofilenameField;
      set => this.dnsprofilenameField = value;
    }

    public string dnsquerylogging
    {
      get => this.dnsqueryloggingField;
      set => this.dnsqueryloggingField = value;
    }

    public string dnsanswerseclogging
    {
      get => this.dnsanswersecloggingField;
      set => this.dnsanswersecloggingField = value;
    }

    public string dnsextendedlogging
    {
      get => this.dnsextendedloggingField;
      set => this.dnsextendedloggingField = value;
    }

    public string dnserrorlogging
    {
      get => this.dnserrorloggingField;
      set => this.dnserrorloggingField = value;
    }

    public string cacherecords
    {
      get => this.cacherecordsField;
      set => this.cacherecordsField = value;
    }

    public string cachenegativeresponses
    {
      get => this.cachenegativeresponsesField;
      set => this.cachenegativeresponsesField = value;
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
      dnsprofile.dnsprofile_response dnsprofileResponse = new dnsprofile.dnsprofile_response();
      dnsprofile.dnsprofile_response resource = (dnsprofile.dnsprofile_response) service.get_payload_formatter().string_to_resource(dnsprofileResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.dnsprofile;
    }

    internal override string get_object_name() => this.dnsprofilename;

    public static base_response add(nitro_service client, dnsprofile resource) => new dnsprofile()
    {
      dnsprofilename = resource.dnsprofilename,
      dnsquerylogging = resource.dnsquerylogging,
      dnsanswerseclogging = resource.dnsanswerseclogging,
      dnsextendedlogging = resource.dnsextendedlogging,
      dnserrorlogging = resource.dnserrorlogging,
      cacherecords = resource.cacherecords,
      cachenegativeresponses = resource.cachenegativeresponses
    }.add_resource(client);

    public static base_responses add(nitro_service client, dnsprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnsprofile[] dnsprofileArray = new dnsprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnsprofileArray[index] = new dnsprofile();
          dnsprofileArray[index].dnsprofilename = resources[index].dnsprofilename;
          dnsprofileArray[index].dnsquerylogging = resources[index].dnsquerylogging;
          dnsprofileArray[index].dnsanswerseclogging = resources[index].dnsanswerseclogging;
          dnsprofileArray[index].dnsextendedlogging = resources[index].dnsextendedlogging;
          dnsprofileArray[index].dnserrorlogging = resources[index].dnserrorlogging;
          dnsprofileArray[index].cacherecords = resources[index].cacherecords;
          dnsprofileArray[index].cachenegativeresponses = resources[index].cachenegativeresponses;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) dnsprofileArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, dnsprofile resource) => new dnsprofile()
    {
      dnsprofilename = resource.dnsprofilename,
      dnsquerylogging = resource.dnsquerylogging,
      dnsanswerseclogging = resource.dnsanswerseclogging,
      dnsextendedlogging = resource.dnsextendedlogging,
      dnserrorlogging = resource.dnserrorlogging,
      cacherecords = resource.cacherecords,
      cachenegativeresponses = resource.cachenegativeresponses
    }.update_resource(client);

    public static base_responses update(nitro_service client, dnsprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnsprofile[] dnsprofileArray = new dnsprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnsprofileArray[index] = new dnsprofile();
          dnsprofileArray[index].dnsprofilename = resources[index].dnsprofilename;
          dnsprofileArray[index].dnsquerylogging = resources[index].dnsquerylogging;
          dnsprofileArray[index].dnsanswerseclogging = resources[index].dnsanswerseclogging;
          dnsprofileArray[index].dnsextendedlogging = resources[index].dnsextendedlogging;
          dnsprofileArray[index].dnserrorlogging = resources[index].dnserrorlogging;
          dnsprofileArray[index].cacherecords = resources[index].cacherecords;
          dnsprofileArray[index].cachenegativeresponses = resources[index].cachenegativeresponses;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) dnsprofileArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string dnsprofilename,
      string[] args)
    {
      return new dnsprofile()
      {
        dnsprofilename = dnsprofilename
      }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      dnsprofile resource,
      string[] args)
    {
      return new dnsprofile()
      {
        dnsprofilename = resource.dnsprofilename
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] dnsprofilename,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (dnsprofilename != null && dnsprofilename.Length > 0)
      {
        dnsprofile[] dnsprofileArray = new dnsprofile[dnsprofilename.Length];
        for (int index = 0; index < dnsprofilename.Length; ++index)
        {
          dnsprofileArray[index] = new dnsprofile();
          dnsprofileArray[index].dnsprofilename = dnsprofilename[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) dnsprofileArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      dnsprofile[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnsprofile[] dnsprofileArray = new dnsprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnsprofileArray[index] = new dnsprofile();
          dnsprofileArray[index].dnsprofilename = resources[index].dnsprofilename;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) dnsprofileArray, args);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string dnsprofilename) => new dnsprofile()
    {
      dnsprofilename = dnsprofilename
    }.delete_resource(client);

    public static base_response delete(nitro_service client, dnsprofile resource) => new dnsprofile()
    {
      dnsprofilename = resource.dnsprofilename
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] dnsprofilename)
    {
      base_responses baseResponses = (base_responses) null;
      if (dnsprofilename != null && dnsprofilename.Length > 0)
      {
        dnsprofile[] dnsprofileArray = new dnsprofile[dnsprofilename.Length];
        for (int index = 0; index < dnsprofilename.Length; ++index)
        {
          dnsprofileArray[index] = new dnsprofile();
          dnsprofileArray[index].dnsprofilename = dnsprofilename[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dnsprofileArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, dnsprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnsprofile[] dnsprofileArray = new dnsprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnsprofileArray[index] = new dnsprofile();
          dnsprofileArray[index].dnsprofilename = resources[index].dnsprofilename;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dnsprofileArray);
      }
      return baseResponses;
    }

    public static dnsprofile[] get(nitro_service service) => (dnsprofile[]) new dnsprofile().get_resources(service, (options) null);

    public static dnsprofile[] get(nitro_service service, options option) => (dnsprofile[]) new dnsprofile().get_resources(service, option);

    public static dnsprofile get(nitro_service service, string dnsprofilename) => (dnsprofile) new dnsprofile()
    {
      dnsprofilename = dnsprofilename
    }.get_resource(service);

    public static dnsprofile[] get(nitro_service service, string[] dnsprofilename)
    {
      if (dnsprofilename == null || dnsprofilename.Length <= 0)
        return (dnsprofile[]) null;
      dnsprofile[] dnsprofileArray1 = new dnsprofile[dnsprofilename.Length];
      dnsprofile[] dnsprofileArray2 = new dnsprofile[dnsprofilename.Length];
      for (int index = 0; index < dnsprofilename.Length; ++index)
      {
        dnsprofileArray2[index] = new dnsprofile();
        dnsprofileArray2[index].dnsprofilename = dnsprofilename[index];
        dnsprofileArray1[index] = (dnsprofile) dnsprofileArray2[index].get_resource(service);
      }
      return dnsprofileArray1;
    }

    public static dnsprofile[] get_filtered(nitro_service service, string filter)
    {
      dnsprofile dnsprofile = new dnsprofile();
      options option = new options();
      option.set_filter(filter);
      return (dnsprofile[]) dnsprofile.getfiltered(service, option);
    }

    public static dnsprofile[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      dnsprofile dnsprofile = new dnsprofile();
      options option = new options();
      option.set_filter(filter);
      return (dnsprofile[]) dnsprofile.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      dnsprofile dnsprofile = new dnsprofile();
      options option = new options();
      option.set_count(true);
      dnsprofile[] resources = (dnsprofile[]) dnsprofile.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      dnsprofile dnsprofile = new dnsprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnsprofile[] dnsprofileArray = (dnsprofile[]) dnsprofile.getfiltered(service, option);
      return dnsprofileArray != null && dnsprofileArray.Length > 0 ? dnsprofileArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      dnsprofile dnsprofile = new dnsprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnsprofile[] dnsprofileArray = (dnsprofile[]) dnsprofile.getfiltered(service, option);
      return dnsprofileArray != null && dnsprofileArray.Length > 0 ? dnsprofileArray[0].__count.Value : 0U;
    }

    private class dnsprofile_response : base_response
    {
      public dnsprofile[] dnsprofile = (dnsprofile[]) null;
    }

    public static class dnsextendedloggingEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class cacherecordsEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class dnsanswersecloggingEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class cachenegativeresponsesEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class dnsqueryloggingEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class dnserrorloggingEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
