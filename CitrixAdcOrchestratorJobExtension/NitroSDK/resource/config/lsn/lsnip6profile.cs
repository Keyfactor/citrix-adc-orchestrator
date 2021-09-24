// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lsn.lsnip6profile
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.lsn
{
  public class lsnip6profile : base_resource
  {
    private string nameField = (string) null;
    private string typeField = (string) null;
    private string network6Field = (string) null;
    private string natprefixField = (string) null;
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

    public string type
    {
      get => this.typeField;
      set => this.typeField = value;
    }

    public string network6
    {
      get => this.network6Field;
      set => this.network6Field = value;
    }

    public string natprefix
    {
      get => this.natprefixField;
      private set => this.natprefixField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lsnip6profile.lsnip6profile_response lsnip6profileResponse = new lsnip6profile.lsnip6profile_response();
      lsnip6profile.lsnip6profile_response resource = (lsnip6profile.lsnip6profile_response) service.get_payload_formatter().string_to_resource(lsnip6profileResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lsnip6profile;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, lsnip6profile resource) => new lsnip6profile()
    {
      name = resource.name,
      type = resource.type,
      network6 = resource.network6
    }.add_resource(client);

    public static base_responses add(nitro_service client, lsnip6profile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsnip6profile[] lsnip6profileArray = new lsnip6profile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsnip6profileArray[index] = new lsnip6profile();
          lsnip6profileArray[index].name = resources[index].name;
          lsnip6profileArray[index].type = resources[index].type;
          lsnip6profileArray[index].network6 = resources[index].network6;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) lsnip6profileArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new lsnip6profile()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, lsnip6profile resource) => new lsnip6profile()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        lsnip6profile[] lsnip6profileArray = new lsnip6profile[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          lsnip6profileArray[index] = new lsnip6profile();
          lsnip6profileArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lsnip6profileArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      lsnip6profile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsnip6profile[] lsnip6profileArray = new lsnip6profile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsnip6profileArray[index] = new lsnip6profile();
          lsnip6profileArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lsnip6profileArray);
      }
      return baseResponses;
    }

    public static lsnip6profile[] get(nitro_service service) => (lsnip6profile[]) new lsnip6profile().get_resources(service, (options) null);

    public static lsnip6profile[] get(nitro_service service, options option) => (lsnip6profile[]) new lsnip6profile().get_resources(service, option);

    public static lsnip6profile get(nitro_service service, string name) => (lsnip6profile) new lsnip6profile()
    {
      name = name
    }.get_resource(service);

    public static lsnip6profile[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (lsnip6profile[]) null;
      lsnip6profile[] lsnip6profileArray1 = new lsnip6profile[name.Length];
      lsnip6profile[] lsnip6profileArray2 = new lsnip6profile[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        lsnip6profileArray2[index] = new lsnip6profile();
        lsnip6profileArray2[index].name = name[index];
        lsnip6profileArray1[index] = (lsnip6profile) lsnip6profileArray2[index].get_resource(service);
      }
      return lsnip6profileArray1;
    }

    public static lsnip6profile[] get_filtered(nitro_service service, string filter)
    {
      lsnip6profile lsnip6profile = new lsnip6profile();
      options option = new options();
      option.set_filter(filter);
      return (lsnip6profile[]) lsnip6profile.getfiltered(service, option);
    }

    public static lsnip6profile[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      lsnip6profile lsnip6profile = new lsnip6profile();
      options option = new options();
      option.set_filter(filter);
      return (lsnip6profile[]) lsnip6profile.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      lsnip6profile lsnip6profile = new lsnip6profile();
      options option = new options();
      option.set_count(true);
      lsnip6profile[] resources = (lsnip6profile[]) lsnip6profile.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      lsnip6profile lsnip6profile = new lsnip6profile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsnip6profile[] lsnip6profileArray = (lsnip6profile[]) lsnip6profile.getfiltered(service, option);
      return lsnip6profileArray != null && lsnip6profileArray.Length > 0 ? lsnip6profileArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      lsnip6profile lsnip6profile = new lsnip6profile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsnip6profile[] lsnip6profileArray = (lsnip6profile[]) lsnip6profile.getfiltered(service, option);
      return lsnip6profileArray != null && lsnip6profileArray.Length > 0 ? lsnip6profileArray[0].__count.Value : 0U;
    }

    private class lsnip6profile_response : base_response
    {
      public lsnip6profile[] lsnip6profile = (lsnip6profile[]) null;
    }

    public static class typeEnum
    {
      public const string DS_Lite = "DS-Lite";
    }
  }
}
