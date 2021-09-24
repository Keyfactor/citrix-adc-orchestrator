// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lsn.lsnsipalgprofile
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.lsn
{
  public class lsnsipalgprofile : base_resource
  {
    private string sipalgprofilenameField = (string) null;
    private uint? datasessionidletimeoutField = new uint?();
    private uint? sipsessiontimeoutField = new uint?();
    private uint? registrationtimeoutField = new uint?();
    private string sipsrcportrangeField = (string) null;
    private string sipdstportrangeField = (string) null;
    private string openregisterpinholeField = (string) null;
    private string opencontactpinholeField = (string) null;
    private string openviapinholeField = (string) null;
    private string openrecordroutepinholeField = (string) null;
    private string siptransportprotocolField = (string) null;
    private string openroutepinholeField = (string) null;
    private string rportField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string sipalgprofilename
    {
      get => this.sipalgprofilenameField;
      set => this.sipalgprofilenameField = value;
    }

    public uint? datasessionidletimeout
    {
      get => this.datasessionidletimeoutField;
      set => this.datasessionidletimeoutField = value;
    }

    public uint? sipsessiontimeout
    {
      get => this.sipsessiontimeoutField;
      set => this.sipsessiontimeoutField = value;
    }

    public uint? registrationtimeout
    {
      get => this.registrationtimeoutField;
      set => this.registrationtimeoutField = value;
    }

    public string sipsrcportrange
    {
      get => this.sipsrcportrangeField;
      set => this.sipsrcportrangeField = value;
    }

    public string sipdstportrange
    {
      get => this.sipdstportrangeField;
      set => this.sipdstportrangeField = value;
    }

    public string openregisterpinhole
    {
      get => this.openregisterpinholeField;
      set => this.openregisterpinholeField = value;
    }

    public string opencontactpinhole
    {
      get => this.opencontactpinholeField;
      set => this.opencontactpinholeField = value;
    }

    public string openviapinhole
    {
      get => this.openviapinholeField;
      set => this.openviapinholeField = value;
    }

    public string openrecordroutepinhole
    {
      get => this.openrecordroutepinholeField;
      set => this.openrecordroutepinholeField = value;
    }

    public string siptransportprotocol
    {
      get => this.siptransportprotocolField;
      set => this.siptransportprotocolField = value;
    }

    public string openroutepinhole
    {
      get => this.openroutepinholeField;
      set => this.openroutepinholeField = value;
    }

    public string rport
    {
      get => this.rportField;
      set => this.rportField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lsnsipalgprofile.lsnsipalgprofile_response lsnsipalgprofileResponse = new lsnsipalgprofile.lsnsipalgprofile_response();
      lsnsipalgprofile.lsnsipalgprofile_response resource = (lsnsipalgprofile.lsnsipalgprofile_response) service.get_payload_formatter().string_to_resource(lsnsipalgprofileResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lsnsipalgprofile;
    }

    internal override string get_object_name() => this.sipalgprofilename;

    public static base_response add(nitro_service client, lsnsipalgprofile resource) => new lsnsipalgprofile()
    {
      sipalgprofilename = resource.sipalgprofilename,
      datasessionidletimeout = resource.datasessionidletimeout,
      sipsessiontimeout = resource.sipsessiontimeout,
      registrationtimeout = resource.registrationtimeout,
      sipsrcportrange = resource.sipsrcportrange,
      sipdstportrange = resource.sipdstportrange,
      openregisterpinhole = resource.openregisterpinhole,
      opencontactpinhole = resource.opencontactpinhole,
      openviapinhole = resource.openviapinhole,
      openrecordroutepinhole = resource.openrecordroutepinhole,
      siptransportprotocol = resource.siptransportprotocol,
      openroutepinhole = resource.openroutepinhole,
      rport = resource.rport
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      lsnsipalgprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsnsipalgprofile[] lsnsipalgprofileArray = new lsnsipalgprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsnsipalgprofileArray[index] = new lsnsipalgprofile();
          lsnsipalgprofileArray[index].sipalgprofilename = resources[index].sipalgprofilename;
          lsnsipalgprofileArray[index].datasessionidletimeout = resources[index].datasessionidletimeout;
          lsnsipalgprofileArray[index].sipsessiontimeout = resources[index].sipsessiontimeout;
          lsnsipalgprofileArray[index].registrationtimeout = resources[index].registrationtimeout;
          lsnsipalgprofileArray[index].sipsrcportrange = resources[index].sipsrcportrange;
          lsnsipalgprofileArray[index].sipdstportrange = resources[index].sipdstportrange;
          lsnsipalgprofileArray[index].openregisterpinhole = resources[index].openregisterpinhole;
          lsnsipalgprofileArray[index].opencontactpinhole = resources[index].opencontactpinhole;
          lsnsipalgprofileArray[index].openviapinhole = resources[index].openviapinhole;
          lsnsipalgprofileArray[index].openrecordroutepinhole = resources[index].openrecordroutepinhole;
          lsnsipalgprofileArray[index].siptransportprotocol = resources[index].siptransportprotocol;
          lsnsipalgprofileArray[index].openroutepinhole = resources[index].openroutepinhole;
          lsnsipalgprofileArray[index].rport = resources[index].rport;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) lsnsipalgprofileArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, lsnsipalgprofile resource) => new lsnsipalgprofile()
    {
      sipalgprofilename = resource.sipalgprofilename,
      datasessionidletimeout = resource.datasessionidletimeout,
      sipsessiontimeout = resource.sipsessiontimeout,
      registrationtimeout = resource.registrationtimeout,
      sipsrcportrange = resource.sipsrcportrange,
      sipdstportrange = resource.sipdstportrange,
      openregisterpinhole = resource.openregisterpinhole,
      opencontactpinhole = resource.opencontactpinhole,
      openviapinhole = resource.openviapinhole,
      openrecordroutepinhole = resource.openrecordroutepinhole,
      siptransportprotocol = resource.siptransportprotocol,
      openroutepinhole = resource.openroutepinhole,
      rport = resource.rport
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      lsnsipalgprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsnsipalgprofile[] lsnsipalgprofileArray = new lsnsipalgprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsnsipalgprofileArray[index] = new lsnsipalgprofile();
          lsnsipalgprofileArray[index].sipalgprofilename = resources[index].sipalgprofilename;
          lsnsipalgprofileArray[index].datasessionidletimeout = resources[index].datasessionidletimeout;
          lsnsipalgprofileArray[index].sipsessiontimeout = resources[index].sipsessiontimeout;
          lsnsipalgprofileArray[index].registrationtimeout = resources[index].registrationtimeout;
          lsnsipalgprofileArray[index].sipsrcportrange = resources[index].sipsrcportrange;
          lsnsipalgprofileArray[index].sipdstportrange = resources[index].sipdstportrange;
          lsnsipalgprofileArray[index].openregisterpinhole = resources[index].openregisterpinhole;
          lsnsipalgprofileArray[index].opencontactpinhole = resources[index].opencontactpinhole;
          lsnsipalgprofileArray[index].openviapinhole = resources[index].openviapinhole;
          lsnsipalgprofileArray[index].openrecordroutepinhole = resources[index].openrecordroutepinhole;
          lsnsipalgprofileArray[index].siptransportprotocol = resources[index].siptransportprotocol;
          lsnsipalgprofileArray[index].openroutepinhole = resources[index].openroutepinhole;
          lsnsipalgprofileArray[index].rport = resources[index].rport;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) lsnsipalgprofileArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string sipalgprofilename,
      string[] args)
    {
      return new lsnsipalgprofile()
      {
        sipalgprofilename = sipalgprofilename
      }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      lsnsipalgprofile resource,
      string[] args)
    {
      return new lsnsipalgprofile()
      {
        sipalgprofilename = resource.sipalgprofilename
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] sipalgprofilename,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (sipalgprofilename != null && sipalgprofilename.Length > 0)
      {
        lsnsipalgprofile[] lsnsipalgprofileArray = new lsnsipalgprofile[sipalgprofilename.Length];
        for (int index = 0; index < sipalgprofilename.Length; ++index)
        {
          lsnsipalgprofileArray[index] = new lsnsipalgprofile();
          lsnsipalgprofileArray[index].sipalgprofilename = sipalgprofilename[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) lsnsipalgprofileArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      lsnsipalgprofile[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsnsipalgprofile[] lsnsipalgprofileArray = new lsnsipalgprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsnsipalgprofileArray[index] = new lsnsipalgprofile();
          lsnsipalgprofileArray[index].sipalgprofilename = resources[index].sipalgprofilename;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) lsnsipalgprofileArray, args);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string sipalgprofilename) => new lsnsipalgprofile()
    {
      sipalgprofilename = sipalgprofilename
    }.delete_resource(client);

    public static base_response delete(nitro_service client, lsnsipalgprofile resource) => new lsnsipalgprofile()
    {
      sipalgprofilename = resource.sipalgprofilename
    }.delete_resource(client);

    public static base_responses delete(
      nitro_service client,
      string[] sipalgprofilename)
    {
      base_responses baseResponses = (base_responses) null;
      if (sipalgprofilename != null && sipalgprofilename.Length > 0)
      {
        lsnsipalgprofile[] lsnsipalgprofileArray = new lsnsipalgprofile[sipalgprofilename.Length];
        for (int index = 0; index < sipalgprofilename.Length; ++index)
        {
          lsnsipalgprofileArray[index] = new lsnsipalgprofile();
          lsnsipalgprofileArray[index].sipalgprofilename = sipalgprofilename[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lsnsipalgprofileArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      lsnsipalgprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsnsipalgprofile[] lsnsipalgprofileArray = new lsnsipalgprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsnsipalgprofileArray[index] = new lsnsipalgprofile();
          lsnsipalgprofileArray[index].sipalgprofilename = resources[index].sipalgprofilename;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lsnsipalgprofileArray);
      }
      return baseResponses;
    }

    public static lsnsipalgprofile[] get(nitro_service service) => (lsnsipalgprofile[]) new lsnsipalgprofile().get_resources(service, (options) null);

    public static lsnsipalgprofile[] get(nitro_service service, options option) => (lsnsipalgprofile[]) new lsnsipalgprofile().get_resources(service, option);

    public static lsnsipalgprofile get(
      nitro_service service,
      string sipalgprofilename)
    {
      return (lsnsipalgprofile) new lsnsipalgprofile()
      {
        sipalgprofilename = sipalgprofilename
      }.get_resource(service);
    }

    public static lsnsipalgprofile[] get(
      nitro_service service,
      string[] sipalgprofilename)
    {
      if (sipalgprofilename == null || sipalgprofilename.Length <= 0)
        return (lsnsipalgprofile[]) null;
      lsnsipalgprofile[] lsnsipalgprofileArray1 = new lsnsipalgprofile[sipalgprofilename.Length];
      lsnsipalgprofile[] lsnsipalgprofileArray2 = new lsnsipalgprofile[sipalgprofilename.Length];
      for (int index = 0; index < sipalgprofilename.Length; ++index)
      {
        lsnsipalgprofileArray2[index] = new lsnsipalgprofile();
        lsnsipalgprofileArray2[index].sipalgprofilename = sipalgprofilename[index];
        lsnsipalgprofileArray1[index] = (lsnsipalgprofile) lsnsipalgprofileArray2[index].get_resource(service);
      }
      return lsnsipalgprofileArray1;
    }

    public static lsnsipalgprofile[] get_filtered(
      nitro_service service,
      string filter)
    {
      lsnsipalgprofile lsnsipalgprofile = new lsnsipalgprofile();
      options option = new options();
      option.set_filter(filter);
      return (lsnsipalgprofile[]) lsnsipalgprofile.getfiltered(service, option);
    }

    public static lsnsipalgprofile[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      lsnsipalgprofile lsnsipalgprofile = new lsnsipalgprofile();
      options option = new options();
      option.set_filter(filter);
      return (lsnsipalgprofile[]) lsnsipalgprofile.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      lsnsipalgprofile lsnsipalgprofile = new lsnsipalgprofile();
      options option = new options();
      option.set_count(true);
      lsnsipalgprofile[] resources = (lsnsipalgprofile[]) lsnsipalgprofile.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      lsnsipalgprofile lsnsipalgprofile = new lsnsipalgprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsnsipalgprofile[] lsnsipalgprofileArray = (lsnsipalgprofile[]) lsnsipalgprofile.getfiltered(service, option);
      return lsnsipalgprofileArray != null && lsnsipalgprofileArray.Length > 0 ? lsnsipalgprofileArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      lsnsipalgprofile lsnsipalgprofile = new lsnsipalgprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsnsipalgprofile[] lsnsipalgprofileArray = (lsnsipalgprofile[]) lsnsipalgprofile.getfiltered(service, option);
      return lsnsipalgprofileArray != null && lsnsipalgprofileArray.Length > 0 ? lsnsipalgprofileArray[0].__count.Value : 0U;
    }

    private class lsnsipalgprofile_response : base_response
    {
      public lsnsipalgprofile[] lsnsipalgprofile = (lsnsipalgprofile[]) null;
    }

    public static class openrecordroutepinholeEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class rportEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class openviapinholeEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class siptransportprotocolEnum
    {
      public const string TCP = "TCP";
      public const string UDP = "UDP";
    }

    public static class openregisterpinholeEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class openroutepinholeEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class opencontactpinholeEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
