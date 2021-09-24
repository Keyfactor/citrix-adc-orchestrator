// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lsn.lsnrtspalgprofile
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.lsn
{
  public class lsnrtspalgprofile : base_resource
  {
    private string rtspalgprofilenameField = (string) null;
    private uint? rtspidletimeoutField = new uint?();
    private string rtspportrangeField = (string) null;
    private string rtsptransportprotocolField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string rtspalgprofilename
    {
      get => this.rtspalgprofilenameField;
      set => this.rtspalgprofilenameField = value;
    }

    public uint? rtspidletimeout
    {
      get => this.rtspidletimeoutField;
      set => this.rtspidletimeoutField = value;
    }

    public string rtspportrange
    {
      get => this.rtspportrangeField;
      set => this.rtspportrangeField = value;
    }

    public string rtsptransportprotocol
    {
      get => this.rtsptransportprotocolField;
      set => this.rtsptransportprotocolField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lsnrtspalgprofile.lsnrtspalgprofile_response lsnrtspalgprofileResponse = new lsnrtspalgprofile.lsnrtspalgprofile_response();
      lsnrtspalgprofile.lsnrtspalgprofile_response resource = (lsnrtspalgprofile.lsnrtspalgprofile_response) service.get_payload_formatter().string_to_resource(lsnrtspalgprofileResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lsnrtspalgprofile;
    }

    internal override string get_object_name() => this.rtspalgprofilename;

    public static base_response add(nitro_service client, lsnrtspalgprofile resource) => new lsnrtspalgprofile()
    {
      rtspalgprofilename = resource.rtspalgprofilename,
      rtspidletimeout = resource.rtspidletimeout,
      rtspportrange = resource.rtspportrange,
      rtsptransportprotocol = resource.rtsptransportprotocol
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      lsnrtspalgprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsnrtspalgprofile[] lsnrtspalgprofileArray = new lsnrtspalgprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsnrtspalgprofileArray[index] = new lsnrtspalgprofile();
          lsnrtspalgprofileArray[index].rtspalgprofilename = resources[index].rtspalgprofilename;
          lsnrtspalgprofileArray[index].rtspidletimeout = resources[index].rtspidletimeout;
          lsnrtspalgprofileArray[index].rtspportrange = resources[index].rtspportrange;
          lsnrtspalgprofileArray[index].rtsptransportprotocol = resources[index].rtsptransportprotocol;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) lsnrtspalgprofileArray);
      }
      return baseResponses;
    }

    public static base_response update(
      nitro_service client,
      lsnrtspalgprofile resource)
    {
      return new lsnrtspalgprofile()
      {
        rtspalgprofilename = resource.rtspalgprofilename,
        rtspidletimeout = resource.rtspidletimeout,
        rtspportrange = resource.rtspportrange,
        rtsptransportprotocol = resource.rtsptransportprotocol
      }.update_resource(client);
    }

    public static base_responses update(
      nitro_service client,
      lsnrtspalgprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsnrtspalgprofile[] lsnrtspalgprofileArray = new lsnrtspalgprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsnrtspalgprofileArray[index] = new lsnrtspalgprofile();
          lsnrtspalgprofileArray[index].rtspalgprofilename = resources[index].rtspalgprofilename;
          lsnrtspalgprofileArray[index].rtspidletimeout = resources[index].rtspidletimeout;
          lsnrtspalgprofileArray[index].rtspportrange = resources[index].rtspportrange;
          lsnrtspalgprofileArray[index].rtsptransportprotocol = resources[index].rtsptransportprotocol;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) lsnrtspalgprofileArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string rtspalgprofilename,
      string[] args)
    {
      return new lsnrtspalgprofile()
      {
        rtspalgprofilename = rtspalgprofilename
      }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      lsnrtspalgprofile resource,
      string[] args)
    {
      return new lsnrtspalgprofile()
      {
        rtspalgprofilename = resource.rtspalgprofilename
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] rtspalgprofilename,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (rtspalgprofilename != null && rtspalgprofilename.Length > 0)
      {
        lsnrtspalgprofile[] lsnrtspalgprofileArray = new lsnrtspalgprofile[rtspalgprofilename.Length];
        for (int index = 0; index < rtspalgprofilename.Length; ++index)
        {
          lsnrtspalgprofileArray[index] = new lsnrtspalgprofile();
          lsnrtspalgprofileArray[index].rtspalgprofilename = rtspalgprofilename[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) lsnrtspalgprofileArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      lsnrtspalgprofile[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsnrtspalgprofile[] lsnrtspalgprofileArray = new lsnrtspalgprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsnrtspalgprofileArray[index] = new lsnrtspalgprofile();
          lsnrtspalgprofileArray[index].rtspalgprofilename = resources[index].rtspalgprofilename;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) lsnrtspalgprofileArray, args);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string rtspalgprofilename) => new lsnrtspalgprofile()
    {
      rtspalgprofilename = rtspalgprofilename
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      lsnrtspalgprofile resource)
    {
      return new lsnrtspalgprofile()
      {
        rtspalgprofilename = resource.rtspalgprofilename
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      string[] rtspalgprofilename)
    {
      base_responses baseResponses = (base_responses) null;
      if (rtspalgprofilename != null && rtspalgprofilename.Length > 0)
      {
        lsnrtspalgprofile[] lsnrtspalgprofileArray = new lsnrtspalgprofile[rtspalgprofilename.Length];
        for (int index = 0; index < rtspalgprofilename.Length; ++index)
        {
          lsnrtspalgprofileArray[index] = new lsnrtspalgprofile();
          lsnrtspalgprofileArray[index].rtspalgprofilename = rtspalgprofilename[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lsnrtspalgprofileArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      lsnrtspalgprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsnrtspalgprofile[] lsnrtspalgprofileArray = new lsnrtspalgprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsnrtspalgprofileArray[index] = new lsnrtspalgprofile();
          lsnrtspalgprofileArray[index].rtspalgprofilename = resources[index].rtspalgprofilename;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lsnrtspalgprofileArray);
      }
      return baseResponses;
    }

    public static lsnrtspalgprofile[] get(nitro_service service) => (lsnrtspalgprofile[]) new lsnrtspalgprofile().get_resources(service, (options) null);

    public static lsnrtspalgprofile[] get(nitro_service service, options option) => (lsnrtspalgprofile[]) new lsnrtspalgprofile().get_resources(service, option);

    public static lsnrtspalgprofile get(
      nitro_service service,
      string rtspalgprofilename)
    {
      return (lsnrtspalgprofile) new lsnrtspalgprofile()
      {
        rtspalgprofilename = rtspalgprofilename
      }.get_resource(service);
    }

    public static lsnrtspalgprofile[] get(
      nitro_service service,
      string[] rtspalgprofilename)
    {
      if (rtspalgprofilename == null || rtspalgprofilename.Length <= 0)
        return (lsnrtspalgprofile[]) null;
      lsnrtspalgprofile[] lsnrtspalgprofileArray1 = new lsnrtspalgprofile[rtspalgprofilename.Length];
      lsnrtspalgprofile[] lsnrtspalgprofileArray2 = new lsnrtspalgprofile[rtspalgprofilename.Length];
      for (int index = 0; index < rtspalgprofilename.Length; ++index)
      {
        lsnrtspalgprofileArray2[index] = new lsnrtspalgprofile();
        lsnrtspalgprofileArray2[index].rtspalgprofilename = rtspalgprofilename[index];
        lsnrtspalgprofileArray1[index] = (lsnrtspalgprofile) lsnrtspalgprofileArray2[index].get_resource(service);
      }
      return lsnrtspalgprofileArray1;
    }

    public static lsnrtspalgprofile[] get_filtered(
      nitro_service service,
      string filter)
    {
      lsnrtspalgprofile lsnrtspalgprofile = new lsnrtspalgprofile();
      options option = new options();
      option.set_filter(filter);
      return (lsnrtspalgprofile[]) lsnrtspalgprofile.getfiltered(service, option);
    }

    public static lsnrtspalgprofile[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      lsnrtspalgprofile lsnrtspalgprofile = new lsnrtspalgprofile();
      options option = new options();
      option.set_filter(filter);
      return (lsnrtspalgprofile[]) lsnrtspalgprofile.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      lsnrtspalgprofile lsnrtspalgprofile = new lsnrtspalgprofile();
      options option = new options();
      option.set_count(true);
      lsnrtspalgprofile[] resources = (lsnrtspalgprofile[]) lsnrtspalgprofile.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      lsnrtspalgprofile lsnrtspalgprofile = new lsnrtspalgprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsnrtspalgprofile[] lsnrtspalgprofileArray = (lsnrtspalgprofile[]) lsnrtspalgprofile.getfiltered(service, option);
      return lsnrtspalgprofileArray != null && lsnrtspalgprofileArray.Length > 0 ? lsnrtspalgprofileArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      lsnrtspalgprofile lsnrtspalgprofile = new lsnrtspalgprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsnrtspalgprofile[] lsnrtspalgprofileArray = (lsnrtspalgprofile[]) lsnrtspalgprofile.getfiltered(service, option);
      return lsnrtspalgprofileArray != null && lsnrtspalgprofileArray.Length > 0 ? lsnrtspalgprofileArray[0].__count.Value : 0U;
    }

    private class lsnrtspalgprofile_response : base_response
    {
      public lsnrtspalgprofile[] lsnrtspalgprofile = (lsnrtspalgprofile[]) null;
    }

    public static class rtsptransportprotocolEnum
    {
      public const string TCP = "TCP";
      public const string UDP = "UDP";
    }
  }
}
