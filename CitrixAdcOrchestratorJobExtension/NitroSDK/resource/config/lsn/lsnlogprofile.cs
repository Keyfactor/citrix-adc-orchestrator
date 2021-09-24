// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lsn.lsnlogprofile
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.lsn
{
  public class lsnlogprofile : base_resource
  {
    private string logprofilenameField = (string) null;
    private string logsubscrinfoField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string logprofilename
    {
      get => this.logprofilenameField;
      set => this.logprofilenameField = value;
    }

    public string logsubscrinfo
    {
      get => this.logsubscrinfoField;
      set => this.logsubscrinfoField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lsnlogprofile.lsnlogprofile_response lsnlogprofileResponse = new lsnlogprofile.lsnlogprofile_response();
      lsnlogprofile.lsnlogprofile_response resource = (lsnlogprofile.lsnlogprofile_response) service.get_payload_formatter().string_to_resource(lsnlogprofileResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lsnlogprofile;
    }

    internal override string get_object_name() => this.logprofilename;

    public static base_response add(nitro_service client, lsnlogprofile resource) => new lsnlogprofile()
    {
      logprofilename = resource.logprofilename,
      logsubscrinfo = resource.logsubscrinfo
    }.add_resource(client);

    public static base_responses add(nitro_service client, lsnlogprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsnlogprofile[] lsnlogprofileArray = new lsnlogprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsnlogprofileArray[index] = new lsnlogprofile();
          lsnlogprofileArray[index].logprofilename = resources[index].logprofilename;
          lsnlogprofileArray[index].logsubscrinfo = resources[index].logsubscrinfo;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) lsnlogprofileArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string logprofilename) => new lsnlogprofile()
    {
      logprofilename = logprofilename
    }.delete_resource(client);

    public static base_response delete(nitro_service client, lsnlogprofile resource) => new lsnlogprofile()
    {
      logprofilename = resource.logprofilename
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] logprofilename)
    {
      base_responses baseResponses = (base_responses) null;
      if (logprofilename != null && logprofilename.Length > 0)
      {
        lsnlogprofile[] lsnlogprofileArray = new lsnlogprofile[logprofilename.Length];
        for (int index = 0; index < logprofilename.Length; ++index)
        {
          lsnlogprofileArray[index] = new lsnlogprofile();
          lsnlogprofileArray[index].logprofilename = logprofilename[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lsnlogprofileArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      lsnlogprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsnlogprofile[] lsnlogprofileArray = new lsnlogprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsnlogprofileArray[index] = new lsnlogprofile();
          lsnlogprofileArray[index].logprofilename = resources[index].logprofilename;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lsnlogprofileArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, lsnlogprofile resource) => new lsnlogprofile()
    {
      logprofilename = resource.logprofilename,
      logsubscrinfo = resource.logsubscrinfo
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      lsnlogprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsnlogprofile[] lsnlogprofileArray = new lsnlogprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsnlogprofileArray[index] = new lsnlogprofile();
          lsnlogprofileArray[index].logprofilename = resources[index].logprofilename;
          lsnlogprofileArray[index].logsubscrinfo = resources[index].logsubscrinfo;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) lsnlogprofileArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string logprofilename,
      string[] args)
    {
      return new lsnlogprofile()
      {
        logprofilename = logprofilename
      }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      lsnlogprofile resource,
      string[] args)
    {
      return new lsnlogprofile()
      {
        logprofilename = resource.logprofilename
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] logprofilename,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (logprofilename != null && logprofilename.Length > 0)
      {
        lsnlogprofile[] lsnlogprofileArray = new lsnlogprofile[logprofilename.Length];
        for (int index = 0; index < logprofilename.Length; ++index)
        {
          lsnlogprofileArray[index] = new lsnlogprofile();
          lsnlogprofileArray[index].logprofilename = logprofilename[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) lsnlogprofileArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      lsnlogprofile[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsnlogprofile[] lsnlogprofileArray = new lsnlogprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsnlogprofileArray[index] = new lsnlogprofile();
          lsnlogprofileArray[index].logprofilename = resources[index].logprofilename;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) lsnlogprofileArray, args);
      }
      return baseResponses;
    }

    public static lsnlogprofile[] get(nitro_service service) => (lsnlogprofile[]) new lsnlogprofile().get_resources(service, (options) null);

    public static lsnlogprofile[] get(nitro_service service, options option) => (lsnlogprofile[]) new lsnlogprofile().get_resources(service, option);

    public static lsnlogprofile get(nitro_service service, string logprofilename) => (lsnlogprofile) new lsnlogprofile()
    {
      logprofilename = logprofilename
    }.get_resource(service);

    public static lsnlogprofile[] get(nitro_service service, string[] logprofilename)
    {
      if (logprofilename == null || logprofilename.Length <= 0)
        return (lsnlogprofile[]) null;
      lsnlogprofile[] lsnlogprofileArray1 = new lsnlogprofile[logprofilename.Length];
      lsnlogprofile[] lsnlogprofileArray2 = new lsnlogprofile[logprofilename.Length];
      for (int index = 0; index < logprofilename.Length; ++index)
      {
        lsnlogprofileArray2[index] = new lsnlogprofile();
        lsnlogprofileArray2[index].logprofilename = logprofilename[index];
        lsnlogprofileArray1[index] = (lsnlogprofile) lsnlogprofileArray2[index].get_resource(service);
      }
      return lsnlogprofileArray1;
    }

    public static lsnlogprofile[] get_filtered(nitro_service service, string filter)
    {
      lsnlogprofile lsnlogprofile = new lsnlogprofile();
      options option = new options();
      option.set_filter(filter);
      return (lsnlogprofile[]) lsnlogprofile.getfiltered(service, option);
    }

    public static lsnlogprofile[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      lsnlogprofile lsnlogprofile = new lsnlogprofile();
      options option = new options();
      option.set_filter(filter);
      return (lsnlogprofile[]) lsnlogprofile.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      lsnlogprofile lsnlogprofile = new lsnlogprofile();
      options option = new options();
      option.set_count(true);
      lsnlogprofile[] resources = (lsnlogprofile[]) lsnlogprofile.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      lsnlogprofile lsnlogprofile = new lsnlogprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsnlogprofile[] lsnlogprofileArray = (lsnlogprofile[]) lsnlogprofile.getfiltered(service, option);
      return lsnlogprofileArray != null && lsnlogprofileArray.Length > 0 ? lsnlogprofileArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      lsnlogprofile lsnlogprofile = new lsnlogprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsnlogprofile[] lsnlogprofileArray = (lsnlogprofile[]) lsnlogprofile.getfiltered(service, option);
      return lsnlogprofileArray != null && lsnlogprofileArray.Length > 0 ? lsnlogprofileArray[0].__count.Value : 0U;
    }

    private class lsnlogprofile_response : base_response
    {
      public lsnlogprofile[] lsnlogprofile = (lsnlogprofile[]) null;
    }

    public static class logsubscrinfoEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
