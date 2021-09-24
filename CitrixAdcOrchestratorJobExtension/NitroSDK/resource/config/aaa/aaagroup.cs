// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.aaa.aaagroup
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.aaa
{
  public class aaagroup : base_resource
  {
    private string groupnameField = (string) null;
    private uint? weightField = new uint?();
    private bool? loggedinField = new bool?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string groupname
    {
      get => this.groupnameField;
      set => this.groupnameField = value;
    }

    public uint? weight
    {
      get => this.weightField;
      set => this.weightField = value;
    }

    public bool? loggedin
    {
      get => this.loggedinField;
      set => this.loggedinField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      aaagroup.aaagroup_response aaagroupResponse = new aaagroup.aaagroup_response();
      aaagroup.aaagroup_response resource = (aaagroup.aaagroup_response) service.get_payload_formatter().string_to_resource(aaagroupResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.aaagroup;
    }

    internal override string get_object_name() => this.groupname;

    public static base_response add(nitro_service client, aaagroup resource) => new aaagroup()
    {
      groupname = resource.groupname,
      weight = resource.weight
    }.add_resource(client);

    public static base_responses add(nitro_service client, aaagroup[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        aaagroup[] aaagroupArray = new aaagroup[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          aaagroupArray[index] = new aaagroup();
          aaagroupArray[index].groupname = resources[index].groupname;
          aaagroupArray[index].weight = resources[index].weight;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) aaagroupArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string groupname) => new aaagroup()
    {
      groupname = groupname
    }.delete_resource(client);

    public static base_response delete(nitro_service client, aaagroup resource) => new aaagroup()
    {
      groupname = resource.groupname
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] groupname)
    {
      base_responses baseResponses = (base_responses) null;
      if (groupname != null && groupname.Length > 0)
      {
        aaagroup[] aaagroupArray = new aaagroup[groupname.Length];
        for (int index = 0; index < groupname.Length; ++index)
        {
          aaagroupArray[index] = new aaagroup();
          aaagroupArray[index].groupname = groupname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) aaagroupArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, aaagroup[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        aaagroup[] aaagroupArray = new aaagroup[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          aaagroupArray[index] = new aaagroup();
          aaagroupArray[index].groupname = resources[index].groupname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) aaagroupArray);
      }
      return baseResponses;
    }

    public static aaagroup[] get(nitro_service service) => (aaagroup[]) new aaagroup().get_resources(service, (options) null);

    public static aaagroup[] get(nitro_service service, options option) => (aaagroup[]) new aaagroup().get_resources(service, option);

    public static aaagroup[] get(nitro_service service, aaagroup_args args)
    {
      aaagroup aaagroup = new aaagroup();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (aaagroup[]) aaagroup.get_resources(service, option);
    }

    public static aaagroup get(nitro_service service, string groupname) => (aaagroup) new aaagroup()
    {
      groupname = groupname
    }.get_resource(service);

    public static aaagroup[] get(nitro_service service, string[] groupname)
    {
      if (groupname == null || groupname.Length <= 0)
        return (aaagroup[]) null;
      aaagroup[] aaagroupArray1 = new aaagroup[groupname.Length];
      aaagroup[] aaagroupArray2 = new aaagroup[groupname.Length];
      for (int index = 0; index < groupname.Length; ++index)
      {
        aaagroupArray2[index] = new aaagroup();
        aaagroupArray2[index].groupname = groupname[index];
        aaagroupArray1[index] = (aaagroup) aaagroupArray2[index].get_resource(service);
      }
      return aaagroupArray1;
    }

    public static aaagroup[] get_filtered(nitro_service service, string filter)
    {
      aaagroup aaagroup = new aaagroup();
      options option = new options();
      option.set_filter(filter);
      return (aaagroup[]) aaagroup.getfiltered(service, option);
    }

    public static aaagroup[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      aaagroup aaagroup = new aaagroup();
      options option = new options();
      option.set_filter(filter);
      return (aaagroup[]) aaagroup.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      aaagroup aaagroup = new aaagroup();
      options option = new options();
      option.set_count(true);
      aaagroup[] resources = (aaagroup[]) aaagroup.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      aaagroup aaagroup = new aaagroup();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      aaagroup[] aaagroupArray = (aaagroup[]) aaagroup.getfiltered(service, option);
      return aaagroupArray != null && aaagroupArray.Length > 0 ? aaagroupArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      aaagroup aaagroup = new aaagroup();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      aaagroup[] aaagroupArray = (aaagroup[]) aaagroup.getfiltered(service, option);
      return aaagroupArray != null && aaagroupArray.Length > 0 ? aaagroupArray[0].__count.Value : 0U;
    }

    private class aaagroup_response : base_response
    {
      public aaagroup[] aaagroup = (aaagroup[]) null;
    }
  }
}
