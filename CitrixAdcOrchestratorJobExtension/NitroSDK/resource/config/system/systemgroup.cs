// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.system.systemgroup
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.system
{
  public class systemgroup : base_resource
  {
    private string groupnameField = (string) null;
    private string promptstringField = (string) null;
    private long? timeoutField = new long?();
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

    public string promptstring
    {
      get => this.promptstringField;
      set => this.promptstringField = value;
    }

    public long? timeout
    {
      get => this.timeoutField;
      set => this.timeoutField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      systemgroup.systemgroup_response systemgroupResponse = new systemgroup.systemgroup_response();
      systemgroup.systemgroup_response resource = (systemgroup.systemgroup_response) service.get_payload_formatter().string_to_resource(systemgroupResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.systemgroup;
    }

    internal override string get_object_name() => this.groupname;

    public static base_response add(nitro_service client, systemgroup resource) => new systemgroup()
    {
      groupname = resource.groupname,
      promptstring = resource.promptstring,
      timeout = resource.timeout
    }.add_resource(client);

    public static base_responses add(nitro_service client, systemgroup[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        systemgroup[] systemgroupArray = new systemgroup[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          systemgroupArray[index] = new systemgroup();
          systemgroupArray[index].groupname = resources[index].groupname;
          systemgroupArray[index].promptstring = resources[index].promptstring;
          systemgroupArray[index].timeout = resources[index].timeout;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) systemgroupArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string groupname) => new systemgroup()
    {
      groupname = groupname
    }.delete_resource(client);

    public static base_response delete(nitro_service client, systemgroup resource) => new systemgroup()
    {
      groupname = resource.groupname
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] groupname)
    {
      base_responses baseResponses = (base_responses) null;
      if (groupname != null && groupname.Length > 0)
      {
        systemgroup[] systemgroupArray = new systemgroup[groupname.Length];
        for (int index = 0; index < groupname.Length; ++index)
        {
          systemgroupArray[index] = new systemgroup();
          systemgroupArray[index].groupname = groupname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) systemgroupArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, systemgroup[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        systemgroup[] systemgroupArray = new systemgroup[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          systemgroupArray[index] = new systemgroup();
          systemgroupArray[index].groupname = resources[index].groupname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) systemgroupArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, systemgroup resource) => new systemgroup()
    {
      groupname = resource.groupname,
      promptstring = resource.promptstring,
      timeout = resource.timeout
    }.update_resource(client);

    public static base_responses update(nitro_service client, systemgroup[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        systemgroup[] systemgroupArray = new systemgroup[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          systemgroupArray[index] = new systemgroup();
          systemgroupArray[index].groupname = resources[index].groupname;
          systemgroupArray[index].promptstring = resources[index].promptstring;
          systemgroupArray[index].timeout = resources[index].timeout;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) systemgroupArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string groupname,
      string[] args)
    {
      return new systemgroup() { groupname = groupname }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      systemgroup resource,
      string[] args)
    {
      return new systemgroup()
      {
        groupname = resource.groupname
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] groupname,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (groupname != null && groupname.Length > 0)
      {
        systemgroup[] systemgroupArray = new systemgroup[groupname.Length];
        for (int index = 0; index < groupname.Length; ++index)
        {
          systemgroupArray[index] = new systemgroup();
          systemgroupArray[index].groupname = groupname[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) systemgroupArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      systemgroup[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        systemgroup[] systemgroupArray = new systemgroup[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          systemgroupArray[index] = new systemgroup();
          systemgroupArray[index].groupname = resources[index].groupname;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) systemgroupArray, args);
      }
      return baseResponses;
    }

    public static systemgroup[] get(nitro_service service) => (systemgroup[]) new systemgroup().get_resources(service, (options) null);

    public static systemgroup[] get(nitro_service service, options option) => (systemgroup[]) new systemgroup().get_resources(service, option);

    public static systemgroup get(nitro_service service, string groupname) => (systemgroup) new systemgroup()
    {
      groupname = groupname
    }.get_resource(service);

    public static systemgroup[] get(nitro_service service, string[] groupname)
    {
      if (groupname == null || groupname.Length <= 0)
        return (systemgroup[]) null;
      systemgroup[] systemgroupArray1 = new systemgroup[groupname.Length];
      systemgroup[] systemgroupArray2 = new systemgroup[groupname.Length];
      for (int index = 0; index < groupname.Length; ++index)
      {
        systemgroupArray2[index] = new systemgroup();
        systemgroupArray2[index].groupname = groupname[index];
        systemgroupArray1[index] = (systemgroup) systemgroupArray2[index].get_resource(service);
      }
      return systemgroupArray1;
    }

    public static systemgroup[] get_filtered(nitro_service service, string filter)
    {
      systemgroup systemgroup = new systemgroup();
      options option = new options();
      option.set_filter(filter);
      return (systemgroup[]) systemgroup.getfiltered(service, option);
    }

    public static systemgroup[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      systemgroup systemgroup = new systemgroup();
      options option = new options();
      option.set_filter(filter);
      return (systemgroup[]) systemgroup.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      systemgroup systemgroup = new systemgroup();
      options option = new options();
      option.set_count(true);
      systemgroup[] resources = (systemgroup[]) systemgroup.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      systemgroup systemgroup = new systemgroup();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      systemgroup[] systemgroupArray = (systemgroup[]) systemgroup.getfiltered(service, option);
      return systemgroupArray != null && systemgroupArray.Length > 0 ? systemgroupArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      systemgroup systemgroup = new systemgroup();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      systemgroup[] systemgroupArray = (systemgroup[]) systemgroup.getfiltered(service, option);
      return systemgroupArray != null && systemgroupArray.Length > 0 ? systemgroupArray[0].__count.Value : 0U;
    }

    private class systemgroup_response : base_response
    {
      public systemgroup[] systemgroup = (systemgroup[]) null;
    }
  }
}
