// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.snmp.snmpcommunity
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.snmp
{
  public class snmpcommunity : base_resource
  {
    private string communitynameField = (string) null;
    private string permissionsField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string communityname
    {
      get => this.communitynameField;
      set => this.communitynameField = value;
    }

    public string permissions
    {
      get => this.permissionsField;
      set => this.permissionsField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      snmpcommunity.snmpcommunity_response snmpcommunityResponse = new snmpcommunity.snmpcommunity_response();
      snmpcommunity.snmpcommunity_response resource = (snmpcommunity.snmpcommunity_response) service.get_payload_formatter().string_to_resource(snmpcommunityResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.snmpcommunity;
    }

    internal override string get_object_name() => this.communityname;

    public static base_response add(nitro_service client, snmpcommunity resource) => new snmpcommunity()
    {
      communityname = resource.communityname,
      permissions = resource.permissions
    }.add_resource(client);

    public static base_responses add(nitro_service client, snmpcommunity[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        snmpcommunity[] snmpcommunityArray = new snmpcommunity[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          snmpcommunityArray[index] = new snmpcommunity();
          snmpcommunityArray[index].communityname = resources[index].communityname;
          snmpcommunityArray[index].permissions = resources[index].permissions;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) snmpcommunityArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string communityname) => new snmpcommunity()
    {
      communityname = communityname
    }.delete_resource(client);

    public static base_response delete(nitro_service client, snmpcommunity resource) => new snmpcommunity()
    {
      communityname = resource.communityname
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] communityname)
    {
      base_responses baseResponses = (base_responses) null;
      if (communityname != null && communityname.Length > 0)
      {
        snmpcommunity[] snmpcommunityArray = new snmpcommunity[communityname.Length];
        for (int index = 0; index < communityname.Length; ++index)
        {
          snmpcommunityArray[index] = new snmpcommunity();
          snmpcommunityArray[index].communityname = communityname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) snmpcommunityArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      snmpcommunity[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        snmpcommunity[] snmpcommunityArray = new snmpcommunity[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          snmpcommunityArray[index] = new snmpcommunity();
          snmpcommunityArray[index].communityname = resources[index].communityname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) snmpcommunityArray);
      }
      return baseResponses;
    }

    public static snmpcommunity[] get(nitro_service service) => (snmpcommunity[]) new snmpcommunity().get_resources(service, (options) null);

    public static snmpcommunity[] get(nitro_service service, options option) => (snmpcommunity[]) new snmpcommunity().get_resources(service, option);

    public static snmpcommunity get(nitro_service service, string communityname) => (snmpcommunity) new snmpcommunity()
    {
      communityname = communityname
    }.get_resource(service);

    public static snmpcommunity[] get(nitro_service service, string[] communityname)
    {
      if (communityname == null || communityname.Length <= 0)
        return (snmpcommunity[]) null;
      snmpcommunity[] snmpcommunityArray1 = new snmpcommunity[communityname.Length];
      snmpcommunity[] snmpcommunityArray2 = new snmpcommunity[communityname.Length];
      for (int index = 0; index < communityname.Length; ++index)
      {
        snmpcommunityArray2[index] = new snmpcommunity();
        snmpcommunityArray2[index].communityname = communityname[index];
        snmpcommunityArray1[index] = (snmpcommunity) snmpcommunityArray2[index].get_resource(service);
      }
      return snmpcommunityArray1;
    }

    public static snmpcommunity[] get_filtered(nitro_service service, string filter)
    {
      snmpcommunity snmpcommunity = new snmpcommunity();
      options option = new options();
      option.set_filter(filter);
      return (snmpcommunity[]) snmpcommunity.getfiltered(service, option);
    }

    public static snmpcommunity[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      snmpcommunity snmpcommunity = new snmpcommunity();
      options option = new options();
      option.set_filter(filter);
      return (snmpcommunity[]) snmpcommunity.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      snmpcommunity snmpcommunity = new snmpcommunity();
      options option = new options();
      option.set_count(true);
      snmpcommunity[] resources = (snmpcommunity[]) snmpcommunity.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      snmpcommunity snmpcommunity = new snmpcommunity();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      snmpcommunity[] snmpcommunityArray = (snmpcommunity[]) snmpcommunity.getfiltered(service, option);
      return snmpcommunityArray != null && snmpcommunityArray.Length > 0 ? snmpcommunityArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      snmpcommunity snmpcommunity = new snmpcommunity();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      snmpcommunity[] snmpcommunityArray = (snmpcommunity[]) snmpcommunity.getfiltered(service, option);
      return snmpcommunityArray != null && snmpcommunityArray.Length > 0 ? snmpcommunityArray[0].__count.Value : 0U;
    }

    private class snmpcommunity_response : base_response
    {
      public snmpcommunity[] snmpcommunity = (snmpcommunity[]) null;
    }

    public static class permissionsEnum
    {
      public const string GET = "GET";
      public const string GET_NEXT = "GET_NEXT";
      public const string GET_BULK = "GET_BULK";
      public const string SET = "SET";
      public const string ALL = "ALL";
    }
  }
}
