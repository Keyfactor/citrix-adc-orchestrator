// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.netprofile
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class netprofile : base_resource
  {
    private string nameField = (string) null;
    private uint? tdField = new uint?();
    private string srcipField = (string) null;
    private string srcippersistencyField = (string) null;
    private string overridelsnField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public uint? td
    {
      get => this.tdField;
      set => this.tdField = value;
    }

    public string srcip
    {
      get => this.srcipField;
      set => this.srcipField = value;
    }

    public string srcippersistency
    {
      get => this.srcippersistencyField;
      set => this.srcippersistencyField = value;
    }

    public string overridelsn
    {
      get => this.overridelsnField;
      set => this.overridelsnField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      netprofile.netprofile_response netprofileResponse = new netprofile.netprofile_response();
      netprofile.netprofile_response resource = (netprofile.netprofile_response) service.get_payload_formatter().string_to_resource(netprofileResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.netprofile;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, netprofile resource) => new netprofile()
    {
      name = resource.name,
      td = resource.td,
      srcip = resource.srcip,
      srcippersistency = resource.srcippersistency,
      overridelsn = resource.overridelsn
    }.add_resource(client);

    public static base_responses add(nitro_service client, netprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        netprofile[] netprofileArray = new netprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          netprofileArray[index] = new netprofile();
          netprofileArray[index].name = resources[index].name;
          netprofileArray[index].td = resources[index].td;
          netprofileArray[index].srcip = resources[index].srcip;
          netprofileArray[index].srcippersistency = resources[index].srcippersistency;
          netprofileArray[index].overridelsn = resources[index].overridelsn;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) netprofileArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new netprofile()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, netprofile resource) => new netprofile()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        netprofile[] netprofileArray = new netprofile[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          netprofileArray[index] = new netprofile();
          netprofileArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) netprofileArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, netprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        netprofile[] netprofileArray = new netprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          netprofileArray[index] = new netprofile();
          netprofileArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) netprofileArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, netprofile resource) => new netprofile()
    {
      name = resource.name,
      srcip = resource.srcip,
      srcippersistency = resource.srcippersistency,
      overridelsn = resource.overridelsn
    }.update_resource(client);

    public static base_responses update(nitro_service client, netprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        netprofile[] netprofileArray = new netprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          netprofileArray[index] = new netprofile();
          netprofileArray[index].name = resources[index].name;
          netprofileArray[index].srcip = resources[index].srcip;
          netprofileArray[index].srcippersistency = resources[index].srcippersistency;
          netprofileArray[index].overridelsn = resources[index].overridelsn;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) netprofileArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new netprofile() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      netprofile resource,
      string[] args)
    {
      return new netprofile() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        netprofile[] netprofileArray = new netprofile[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          netprofileArray[index] = new netprofile();
          netprofileArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) netprofileArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      netprofile[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        netprofile[] netprofileArray = new netprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          netprofileArray[index] = new netprofile();
          netprofileArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) netprofileArray, args);
      }
      return baseResponses;
    }

    public static netprofile[] get(nitro_service service) => (netprofile[]) new netprofile().get_resources(service, (options) null);

    public static netprofile[] get(nitro_service service, options option) => (netprofile[]) new netprofile().get_resources(service, option);

    public static netprofile get(nitro_service service, string name) => (netprofile) new netprofile()
    {
      name = name
    }.get_resource(service);

    public static netprofile[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (netprofile[]) null;
      netprofile[] netprofileArray1 = new netprofile[name.Length];
      netprofile[] netprofileArray2 = new netprofile[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        netprofileArray2[index] = new netprofile();
        netprofileArray2[index].name = name[index];
        netprofileArray1[index] = (netprofile) netprofileArray2[index].get_resource(service);
      }
      return netprofileArray1;
    }

    public static netprofile[] get_filtered(nitro_service service, string filter)
    {
      netprofile netprofile = new netprofile();
      options option = new options();
      option.set_filter(filter);
      return (netprofile[]) netprofile.getfiltered(service, option);
    }

    public static netprofile[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      netprofile netprofile = new netprofile();
      options option = new options();
      option.set_filter(filter);
      return (netprofile[]) netprofile.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      netprofile netprofile = new netprofile();
      options option = new options();
      option.set_count(true);
      netprofile[] resources = (netprofile[]) netprofile.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      netprofile netprofile = new netprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      netprofile[] netprofileArray = (netprofile[]) netprofile.getfiltered(service, option);
      return netprofileArray != null && netprofileArray.Length > 0 ? netprofileArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      netprofile netprofile = new netprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      netprofile[] netprofileArray = (netprofile[]) netprofile.getfiltered(service, option);
      return netprofileArray != null && netprofileArray.Length > 0 ? netprofileArray[0].__count.Value : 0U;
    }

    private class netprofile_response : base_response
    {
      public netprofile[] netprofile = (netprofile[]) null;
    }

    public static class srcippersistencyEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class overridelsnEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
