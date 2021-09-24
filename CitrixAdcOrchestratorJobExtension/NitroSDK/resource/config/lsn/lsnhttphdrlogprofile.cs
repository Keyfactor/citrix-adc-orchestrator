// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lsn.lsnhttphdrlogprofile
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.lsn
{
  public class lsnhttphdrlogprofile : base_resource
  {
    private string httphdrlogprofilenameField = (string) null;
    private string logurlField = (string) null;
    private string logmethodField = (string) null;
    private string logversionField = (string) null;
    private string loghostField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string httphdrlogprofilename
    {
      get => this.httphdrlogprofilenameField;
      set => this.httphdrlogprofilenameField = value;
    }

    public string logurl
    {
      get => this.logurlField;
      set => this.logurlField = value;
    }

    public string logmethod
    {
      get => this.logmethodField;
      set => this.logmethodField = value;
    }

    public string logversion
    {
      get => this.logversionField;
      set => this.logversionField = value;
    }

    public string loghost
    {
      get => this.loghostField;
      set => this.loghostField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lsnhttphdrlogprofile.lsnhttphdrlogprofile_response lsnhttphdrlogprofileResponse = new lsnhttphdrlogprofile.lsnhttphdrlogprofile_response();
      lsnhttphdrlogprofile.lsnhttphdrlogprofile_response resource = (lsnhttphdrlogprofile.lsnhttphdrlogprofile_response) service.get_payload_formatter().string_to_resource(lsnhttphdrlogprofileResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lsnhttphdrlogprofile;
    }

    internal override string get_object_name() => this.httphdrlogprofilename;

    public static base_response add(
      nitro_service client,
      lsnhttphdrlogprofile resource)
    {
      return new lsnhttphdrlogprofile()
      {
        httphdrlogprofilename = resource.httphdrlogprofilename,
        logurl = resource.logurl,
        logmethod = resource.logmethod,
        logversion = resource.logversion,
        loghost = resource.loghost
      }.add_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      lsnhttphdrlogprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsnhttphdrlogprofile[] lsnhttphdrlogprofileArray = new lsnhttphdrlogprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsnhttphdrlogprofileArray[index] = new lsnhttphdrlogprofile();
          lsnhttphdrlogprofileArray[index].httphdrlogprofilename = resources[index].httphdrlogprofilename;
          lsnhttphdrlogprofileArray[index].logurl = resources[index].logurl;
          lsnhttphdrlogprofileArray[index].logmethod = resources[index].logmethod;
          lsnhttphdrlogprofileArray[index].logversion = resources[index].logversion;
          lsnhttphdrlogprofileArray[index].loghost = resources[index].loghost;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) lsnhttphdrlogprofileArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      string httphdrlogprofilename)
    {
      return new lsnhttphdrlogprofile()
      {
        httphdrlogprofilename = httphdrlogprofilename
      }.delete_resource(client);
    }

    public static base_response delete(
      nitro_service client,
      lsnhttphdrlogprofile resource)
    {
      return new lsnhttphdrlogprofile()
      {
        httphdrlogprofilename = resource.httphdrlogprofilename
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      string[] httphdrlogprofilename)
    {
      base_responses baseResponses = (base_responses) null;
      if (httphdrlogprofilename != null && httphdrlogprofilename.Length > 0)
      {
        lsnhttphdrlogprofile[] lsnhttphdrlogprofileArray = new lsnhttphdrlogprofile[httphdrlogprofilename.Length];
        for (int index = 0; index < httphdrlogprofilename.Length; ++index)
        {
          lsnhttphdrlogprofileArray[index] = new lsnhttphdrlogprofile();
          lsnhttphdrlogprofileArray[index].httphdrlogprofilename = httphdrlogprofilename[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lsnhttphdrlogprofileArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      lsnhttphdrlogprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsnhttphdrlogprofile[] lsnhttphdrlogprofileArray = new lsnhttphdrlogprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsnhttphdrlogprofileArray[index] = new lsnhttphdrlogprofile();
          lsnhttphdrlogprofileArray[index].httphdrlogprofilename = resources[index].httphdrlogprofilename;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lsnhttphdrlogprofileArray);
      }
      return baseResponses;
    }

    public static base_response update(
      nitro_service client,
      lsnhttphdrlogprofile resource)
    {
      return new lsnhttphdrlogprofile()
      {
        httphdrlogprofilename = resource.httphdrlogprofilename,
        logurl = resource.logurl,
        logmethod = resource.logmethod,
        logversion = resource.logversion,
        loghost = resource.loghost
      }.update_resource(client);
    }

    public static base_responses update(
      nitro_service client,
      lsnhttphdrlogprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsnhttphdrlogprofile[] lsnhttphdrlogprofileArray = new lsnhttphdrlogprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsnhttphdrlogprofileArray[index] = new lsnhttphdrlogprofile();
          lsnhttphdrlogprofileArray[index].httphdrlogprofilename = resources[index].httphdrlogprofilename;
          lsnhttphdrlogprofileArray[index].logurl = resources[index].logurl;
          lsnhttphdrlogprofileArray[index].logmethod = resources[index].logmethod;
          lsnhttphdrlogprofileArray[index].logversion = resources[index].logversion;
          lsnhttphdrlogprofileArray[index].loghost = resources[index].loghost;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) lsnhttphdrlogprofileArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string httphdrlogprofilename,
      string[] args)
    {
      return new lsnhttphdrlogprofile()
      {
        httphdrlogprofilename = httphdrlogprofilename
      }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      lsnhttphdrlogprofile resource,
      string[] args)
    {
      return new lsnhttphdrlogprofile()
      {
        httphdrlogprofilename = resource.httphdrlogprofilename
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] httphdrlogprofilename,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (httphdrlogprofilename != null && httphdrlogprofilename.Length > 0)
      {
        lsnhttphdrlogprofile[] lsnhttphdrlogprofileArray = new lsnhttphdrlogprofile[httphdrlogprofilename.Length];
        for (int index = 0; index < httphdrlogprofilename.Length; ++index)
        {
          lsnhttphdrlogprofileArray[index] = new lsnhttphdrlogprofile();
          lsnhttphdrlogprofileArray[index].httphdrlogprofilename = httphdrlogprofilename[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) lsnhttphdrlogprofileArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      lsnhttphdrlogprofile[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsnhttphdrlogprofile[] lsnhttphdrlogprofileArray = new lsnhttphdrlogprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsnhttphdrlogprofileArray[index] = new lsnhttphdrlogprofile();
          lsnhttphdrlogprofileArray[index].httphdrlogprofilename = resources[index].httphdrlogprofilename;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) lsnhttphdrlogprofileArray, args);
      }
      return baseResponses;
    }

    public static lsnhttphdrlogprofile[] get(nitro_service service) => (lsnhttphdrlogprofile[]) new lsnhttphdrlogprofile().get_resources(service, (options) null);

    public static lsnhttphdrlogprofile[] get(
      nitro_service service,
      options option)
    {
      return (lsnhttphdrlogprofile[]) new lsnhttphdrlogprofile().get_resources(service, option);
    }

    public static lsnhttphdrlogprofile get(
      nitro_service service,
      string httphdrlogprofilename)
    {
      return (lsnhttphdrlogprofile) new lsnhttphdrlogprofile()
      {
        httphdrlogprofilename = httphdrlogprofilename
      }.get_resource(service);
    }

    public static lsnhttphdrlogprofile[] get(
      nitro_service service,
      string[] httphdrlogprofilename)
    {
      if (httphdrlogprofilename == null || httphdrlogprofilename.Length <= 0)
        return (lsnhttphdrlogprofile[]) null;
      lsnhttphdrlogprofile[] lsnhttphdrlogprofileArray1 = new lsnhttphdrlogprofile[httphdrlogprofilename.Length];
      lsnhttphdrlogprofile[] lsnhttphdrlogprofileArray2 = new lsnhttphdrlogprofile[httphdrlogprofilename.Length];
      for (int index = 0; index < httphdrlogprofilename.Length; ++index)
      {
        lsnhttphdrlogprofileArray2[index] = new lsnhttphdrlogprofile();
        lsnhttphdrlogprofileArray2[index].httphdrlogprofilename = httphdrlogprofilename[index];
        lsnhttphdrlogprofileArray1[index] = (lsnhttphdrlogprofile) lsnhttphdrlogprofileArray2[index].get_resource(service);
      }
      return lsnhttphdrlogprofileArray1;
    }

    public static lsnhttphdrlogprofile[] get_filtered(
      nitro_service service,
      string filter)
    {
      lsnhttphdrlogprofile lsnhttphdrlogprofile = new lsnhttphdrlogprofile();
      options option = new options();
      option.set_filter(filter);
      return (lsnhttphdrlogprofile[]) lsnhttphdrlogprofile.getfiltered(service, option);
    }

    public static lsnhttphdrlogprofile[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      lsnhttphdrlogprofile lsnhttphdrlogprofile = new lsnhttphdrlogprofile();
      options option = new options();
      option.set_filter(filter);
      return (lsnhttphdrlogprofile[]) lsnhttphdrlogprofile.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      lsnhttphdrlogprofile lsnhttphdrlogprofile = new lsnhttphdrlogprofile();
      options option = new options();
      option.set_count(true);
      lsnhttphdrlogprofile[] resources = (lsnhttphdrlogprofile[]) lsnhttphdrlogprofile.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      lsnhttphdrlogprofile lsnhttphdrlogprofile = new lsnhttphdrlogprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsnhttphdrlogprofile[] lsnhttphdrlogprofileArray = (lsnhttphdrlogprofile[]) lsnhttphdrlogprofile.getfiltered(service, option);
      return lsnhttphdrlogprofileArray != null && lsnhttphdrlogprofileArray.Length > 0 ? lsnhttphdrlogprofileArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      lsnhttphdrlogprofile lsnhttphdrlogprofile = new lsnhttphdrlogprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsnhttphdrlogprofile[] lsnhttphdrlogprofileArray = (lsnhttphdrlogprofile[]) lsnhttphdrlogprofile.getfiltered(service, option);
      return lsnhttphdrlogprofileArray != null && lsnhttphdrlogprofileArray.Length > 0 ? lsnhttphdrlogprofileArray[0].__count.Value : 0U;
    }

    private class lsnhttphdrlogprofile_response : base_response
    {
      public lsnhttphdrlogprofile[] lsnhttphdrlogprofile = (lsnhttphdrlogprofile[]) null;
    }

    public static class logversionEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class logmethodEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class logurlEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class loghostEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
