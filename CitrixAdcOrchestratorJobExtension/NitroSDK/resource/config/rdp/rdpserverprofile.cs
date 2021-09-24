// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.rdp.rdpserverprofile
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.rdp
{
  public class rdpserverprofile : base_resource
  {
    private string nameField = (string) null;
    private string rdpipField = (string) null;
    private uint? rdpportField = new uint?();
    private string pskField = (string) null;
    private string[] builtinField = (string[]) null;
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

    public string rdpip
    {
      get => this.rdpipField;
      set => this.rdpipField = value;
    }

    public uint? rdpport
    {
      get => this.rdpportField;
      set => this.rdpportField = value;
    }

    public string psk
    {
      get => this.pskField;
      set => this.pskField = value;
    }

    public string[] builtin
    {
      get => this.builtinField;
      private set => this.builtinField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      rdpserverprofile.rdpserverprofile_response rdpserverprofileResponse = new rdpserverprofile.rdpserverprofile_response();
      rdpserverprofile.rdpserverprofile_response resource = (rdpserverprofile.rdpserverprofile_response) service.get_payload_formatter().string_to_resource(rdpserverprofileResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.rdpserverprofile;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, rdpserverprofile resource) => new rdpserverprofile()
    {
      name = resource.name,
      rdpip = resource.rdpip,
      rdpport = resource.rdpport,
      psk = resource.psk
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      rdpserverprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        rdpserverprofile[] rdpserverprofileArray = new rdpserverprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          rdpserverprofileArray[index] = new rdpserverprofile();
          rdpserverprofileArray[index].name = resources[index].name;
          rdpserverprofileArray[index].rdpip = resources[index].rdpip;
          rdpserverprofileArray[index].rdpport = resources[index].rdpport;
          rdpserverprofileArray[index].psk = resources[index].psk;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) rdpserverprofileArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, rdpserverprofile resource) => new rdpserverprofile()
    {
      name = resource.name,
      rdpip = resource.rdpip,
      rdpport = resource.rdpport,
      psk = resource.psk
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      rdpserverprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        rdpserverprofile[] rdpserverprofileArray = new rdpserverprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          rdpserverprofileArray[index] = new rdpserverprofile();
          rdpserverprofileArray[index].name = resources[index].name;
          rdpserverprofileArray[index].rdpip = resources[index].rdpip;
          rdpserverprofileArray[index].rdpport = resources[index].rdpport;
          rdpserverprofileArray[index].psk = resources[index].psk;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) rdpserverprofileArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new rdpserverprofile() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      rdpserverprofile resource,
      string[] args)
    {
      return new rdpserverprofile() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        rdpserverprofile[] rdpserverprofileArray = new rdpserverprofile[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          rdpserverprofileArray[index] = new rdpserverprofile();
          rdpserverprofileArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) rdpserverprofileArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      rdpserverprofile[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        rdpserverprofile[] rdpserverprofileArray = new rdpserverprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          rdpserverprofileArray[index] = new rdpserverprofile();
          rdpserverprofileArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) rdpserverprofileArray, args);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new rdpserverprofile()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, rdpserverprofile resource) => new rdpserverprofile()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        rdpserverprofile[] rdpserverprofileArray = new rdpserverprofile[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          rdpserverprofileArray[index] = new rdpserverprofile();
          rdpserverprofileArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) rdpserverprofileArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      rdpserverprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        rdpserverprofile[] rdpserverprofileArray = new rdpserverprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          rdpserverprofileArray[index] = new rdpserverprofile();
          rdpserverprofileArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) rdpserverprofileArray);
      }
      return baseResponses;
    }

    public static rdpserverprofile[] get(nitro_service service) => (rdpserverprofile[]) new rdpserverprofile().get_resources(service, (options) null);

    public static rdpserverprofile[] get(nitro_service service, options option) => (rdpserverprofile[]) new rdpserverprofile().get_resources(service, option);

    public static rdpserverprofile get(nitro_service service, string name) => (rdpserverprofile) new rdpserverprofile()
    {
      name = name
    }.get_resource(service);

    public static rdpserverprofile[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (rdpserverprofile[]) null;
      rdpserverprofile[] rdpserverprofileArray1 = new rdpserverprofile[name.Length];
      rdpserverprofile[] rdpserverprofileArray2 = new rdpserverprofile[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        rdpserverprofileArray2[index] = new rdpserverprofile();
        rdpserverprofileArray2[index].name = name[index];
        rdpserverprofileArray1[index] = (rdpserverprofile) rdpserverprofileArray2[index].get_resource(service);
      }
      return rdpserverprofileArray1;
    }

    public static rdpserverprofile[] get_filtered(
      nitro_service service,
      string filter)
    {
      rdpserverprofile rdpserverprofile = new rdpserverprofile();
      options option = new options();
      option.set_filter(filter);
      return (rdpserverprofile[]) rdpserverprofile.getfiltered(service, option);
    }

    public static rdpserverprofile[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      rdpserverprofile rdpserverprofile = new rdpserverprofile();
      options option = new options();
      option.set_filter(filter);
      return (rdpserverprofile[]) rdpserverprofile.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      rdpserverprofile rdpserverprofile = new rdpserverprofile();
      options option = new options();
      option.set_count(true);
      rdpserverprofile[] resources = (rdpserverprofile[]) rdpserverprofile.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      rdpserverprofile rdpserverprofile = new rdpserverprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      rdpserverprofile[] rdpserverprofileArray = (rdpserverprofile[]) rdpserverprofile.getfiltered(service, option);
      return rdpserverprofileArray != null && rdpserverprofileArray.Length > 0 ? rdpserverprofileArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      rdpserverprofile rdpserverprofile = new rdpserverprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      rdpserverprofile[] rdpserverprofileArray = (rdpserverprofile[]) rdpserverprofile.getfiltered(service, option);
      return rdpserverprofileArray != null && rdpserverprofileArray.Length > 0 ? rdpserverprofileArray[0].__count.Value : 0U;
    }

    private class rdpserverprofile_response : base_response
    {
      public rdpserverprofile[] rdpserverprofile = (rdpserverprofile[]) null;
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }
  }
}
