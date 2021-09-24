// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lsn.lsnappsprofile
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.lsn
{
  public class lsnappsprofile : base_resource
  {
    private string appsprofilenameField = (string) null;
    private string transportprotocolField = (string) null;
    private string ippoolingField = (string) null;
    private string mappingField = (string) null;
    private string filteringField = (string) null;
    private string tcpproxyField = (string) null;
    private uint? tdField = new uint?();
    private string l2infoField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string appsprofilename
    {
      get => this.appsprofilenameField;
      set => this.appsprofilenameField = value;
    }

    public string transportprotocol
    {
      get => this.transportprotocolField;
      set => this.transportprotocolField = value;
    }

    public string ippooling
    {
      get => this.ippoolingField;
      set => this.ippoolingField = value;
    }

    public string mapping
    {
      get => this.mappingField;
      set => this.mappingField = value;
    }

    public string filtering
    {
      get => this.filteringField;
      set => this.filteringField = value;
    }

    public string tcpproxy
    {
      get => this.tcpproxyField;
      set => this.tcpproxyField = value;
    }

    public uint? td
    {
      get => this.tdField;
      set => this.tdField = value;
    }

    public string l2info
    {
      get => this.l2infoField;
      set => this.l2infoField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lsnappsprofile.lsnappsprofile_response lsnappsprofileResponse = new lsnappsprofile.lsnappsprofile_response();
      lsnappsprofile.lsnappsprofile_response resource = (lsnappsprofile.lsnappsprofile_response) service.get_payload_formatter().string_to_resource(lsnappsprofileResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lsnappsprofile;
    }

    internal override string get_object_name() => this.appsprofilename;

    public static base_response add(nitro_service client, lsnappsprofile resource) => new lsnappsprofile()
    {
      appsprofilename = resource.appsprofilename,
      transportprotocol = resource.transportprotocol,
      ippooling = resource.ippooling,
      mapping = resource.mapping,
      filtering = resource.filtering,
      tcpproxy = resource.tcpproxy,
      td = resource.td,
      l2info = resource.l2info
    }.add_resource(client);

    public static base_responses add(nitro_service client, lsnappsprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsnappsprofile[] lsnappsprofileArray = new lsnappsprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsnappsprofileArray[index] = new lsnappsprofile();
          lsnappsprofileArray[index].appsprofilename = resources[index].appsprofilename;
          lsnappsprofileArray[index].transportprotocol = resources[index].transportprotocol;
          lsnappsprofileArray[index].ippooling = resources[index].ippooling;
          lsnappsprofileArray[index].mapping = resources[index].mapping;
          lsnappsprofileArray[index].filtering = resources[index].filtering;
          lsnappsprofileArray[index].tcpproxy = resources[index].tcpproxy;
          lsnappsprofileArray[index].td = resources[index].td;
          lsnappsprofileArray[index].l2info = resources[index].l2info;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) lsnappsprofileArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string appsprofilename) => new lsnappsprofile()
    {
      appsprofilename = appsprofilename
    }.delete_resource(client);

    public static base_response delete(nitro_service client, lsnappsprofile resource) => new lsnappsprofile()
    {
      appsprofilename = resource.appsprofilename
    }.delete_resource(client);

    public static base_responses delete(
      nitro_service client,
      string[] appsprofilename)
    {
      base_responses baseResponses = (base_responses) null;
      if (appsprofilename != null && appsprofilename.Length > 0)
      {
        lsnappsprofile[] lsnappsprofileArray = new lsnappsprofile[appsprofilename.Length];
        for (int index = 0; index < appsprofilename.Length; ++index)
        {
          lsnappsprofileArray[index] = new lsnappsprofile();
          lsnappsprofileArray[index].appsprofilename = appsprofilename[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lsnappsprofileArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      lsnappsprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsnappsprofile[] lsnappsprofileArray = new lsnappsprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsnappsprofileArray[index] = new lsnappsprofile();
          lsnappsprofileArray[index].appsprofilename = resources[index].appsprofilename;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lsnappsprofileArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, lsnappsprofile resource) => new lsnappsprofile()
    {
      appsprofilename = resource.appsprofilename,
      ippooling = resource.ippooling,
      mapping = resource.mapping,
      filtering = resource.filtering,
      tcpproxy = resource.tcpproxy,
      td = resource.td,
      l2info = resource.l2info
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      lsnappsprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsnappsprofile[] lsnappsprofileArray = new lsnappsprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsnappsprofileArray[index] = new lsnappsprofile();
          lsnappsprofileArray[index].appsprofilename = resources[index].appsprofilename;
          lsnappsprofileArray[index].ippooling = resources[index].ippooling;
          lsnappsprofileArray[index].mapping = resources[index].mapping;
          lsnappsprofileArray[index].filtering = resources[index].filtering;
          lsnappsprofileArray[index].tcpproxy = resources[index].tcpproxy;
          lsnappsprofileArray[index].td = resources[index].td;
          lsnappsprofileArray[index].l2info = resources[index].l2info;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) lsnappsprofileArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string appsprofilename,
      string[] args)
    {
      return new lsnappsprofile()
      {
        appsprofilename = appsprofilename
      }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      lsnappsprofile resource,
      string[] args)
    {
      return new lsnappsprofile()
      {
        appsprofilename = resource.appsprofilename
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] appsprofilename,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (appsprofilename != null && appsprofilename.Length > 0)
      {
        lsnappsprofile[] lsnappsprofileArray = new lsnappsprofile[appsprofilename.Length];
        for (int index = 0; index < appsprofilename.Length; ++index)
        {
          lsnappsprofileArray[index] = new lsnappsprofile();
          lsnappsprofileArray[index].appsprofilename = appsprofilename[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) lsnappsprofileArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      lsnappsprofile[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsnappsprofile[] lsnappsprofileArray = new lsnappsprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsnappsprofileArray[index] = new lsnappsprofile();
          lsnappsprofileArray[index].appsprofilename = resources[index].appsprofilename;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) lsnappsprofileArray, args);
      }
      return baseResponses;
    }

    public static lsnappsprofile[] get(nitro_service service) => (lsnappsprofile[]) new lsnappsprofile().get_resources(service, (options) null);

    public static lsnappsprofile[] get(nitro_service service, options option) => (lsnappsprofile[]) new lsnappsprofile().get_resources(service, option);

    public static lsnappsprofile get(nitro_service service, string appsprofilename) => (lsnappsprofile) new lsnappsprofile()
    {
      appsprofilename = appsprofilename
    }.get_resource(service);

    public static lsnappsprofile[] get(
      nitro_service service,
      string[] appsprofilename)
    {
      if (appsprofilename == null || appsprofilename.Length <= 0)
        return (lsnappsprofile[]) null;
      lsnappsprofile[] lsnappsprofileArray1 = new lsnappsprofile[appsprofilename.Length];
      lsnappsprofile[] lsnappsprofileArray2 = new lsnappsprofile[appsprofilename.Length];
      for (int index = 0; index < appsprofilename.Length; ++index)
      {
        lsnappsprofileArray2[index] = new lsnappsprofile();
        lsnappsprofileArray2[index].appsprofilename = appsprofilename[index];
        lsnappsprofileArray1[index] = (lsnappsprofile) lsnappsprofileArray2[index].get_resource(service);
      }
      return lsnappsprofileArray1;
    }

    public static lsnappsprofile[] get_filtered(nitro_service service, string filter)
    {
      lsnappsprofile lsnappsprofile = new lsnappsprofile();
      options option = new options();
      option.set_filter(filter);
      return (lsnappsprofile[]) lsnappsprofile.getfiltered(service, option);
    }

    public static lsnappsprofile[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      lsnappsprofile lsnappsprofile = new lsnappsprofile();
      options option = new options();
      option.set_filter(filter);
      return (lsnappsprofile[]) lsnappsprofile.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      lsnappsprofile lsnappsprofile = new lsnappsprofile();
      options option = new options();
      option.set_count(true);
      lsnappsprofile[] resources = (lsnappsprofile[]) lsnappsprofile.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      lsnappsprofile lsnappsprofile = new lsnappsprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsnappsprofile[] lsnappsprofileArray = (lsnappsprofile[]) lsnappsprofile.getfiltered(service, option);
      return lsnappsprofileArray != null && lsnappsprofileArray.Length > 0 ? lsnappsprofileArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      lsnappsprofile lsnappsprofile = new lsnappsprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsnappsprofile[] lsnappsprofileArray = (lsnappsprofile[]) lsnappsprofile.getfiltered(service, option);
      return lsnappsprofileArray != null && lsnappsprofileArray.Length > 0 ? lsnappsprofileArray[0].__count.Value : 0U;
    }

    private class lsnappsprofile_response : base_response
    {
      public lsnappsprofile[] lsnappsprofile = (lsnappsprofile[]) null;
    }

    public static class mappingEnum
    {
      public const string ENDPOINT_INDEPENDENT = "ENDPOINT-INDEPENDENT";
      public const string ADDRESS_DEPENDENT = "ADDRESS-DEPENDENT";
      public const string ADDRESS_PORT_DEPENDENT = "ADDRESS-PORT-DEPENDENT";
    }

    public static class filteringEnum
    {
      public const string ENDPOINT_INDEPENDENT = "ENDPOINT-INDEPENDENT";
      public const string ADDRESS_DEPENDENT = "ADDRESS-DEPENDENT";
      public const string ADDRESS_PORT_DEPENDENT = "ADDRESS-PORT-DEPENDENT";
    }

    public static class tcpproxyEnum
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

    public static class l2infoEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class ippoolingEnum
    {
      public const string PAIRED = "PAIRED";
      public const string RANDOM = "RANDOM";
    }
  }
}
