// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cluster.clusternodegroup
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.cluster
{
  public class clusternodegroup : base_resource
  {
    private string nameField = (string) null;
    private string strictField = (string) null;
    private string stickyField = (string) null;
    private string stateField = (string) null;
    private uint? priorityField = new uint?();
    private uint? currentnodemaskField = new uint?();
    private uint? backupnodemaskField = new uint?();
    private uint? boundedentitiescntfrompeField = new uint?();
    private uint?[] activelistField = (uint?[]) null;
    private uint?[] backuplistField = (uint?[]) null;
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

    public string strict
    {
      get => this.strictField;
      set => this.strictField = value;
    }

    public string sticky
    {
      get => this.stickyField;
      set => this.stickyField = value;
    }

    public string state
    {
      get => this.stateField;
      set => this.stateField = value;
    }

    public uint? priority
    {
      get => this.priorityField;
      set => this.priorityField = value;
    }

    public uint? currentnodemask
    {
      get => this.currentnodemaskField;
      private set => this.currentnodemaskField = value;
    }

    public uint? backupnodemask
    {
      get => this.backupnodemaskField;
      private set => this.backupnodemaskField = value;
    }

    public uint? boundedentitiescntfrompe
    {
      get => this.boundedentitiescntfrompeField;
      private set => this.boundedentitiescntfrompeField = value;
    }

    public uint?[] activelist
    {
      get => this.activelistField;
      private set => this.activelistField = value;
    }

    public uint?[] backuplist
    {
      get => this.backuplistField;
      private set => this.backuplistField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      clusternodegroup.clusternodegroup_response clusternodegroupResponse = new clusternodegroup.clusternodegroup_response();
      clusternodegroup.clusternodegroup_response resource = (clusternodegroup.clusternodegroup_response) service.get_payload_formatter().string_to_resource(clusternodegroupResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.clusternodegroup;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, clusternodegroup resource) => new clusternodegroup()
    {
      name = resource.name,
      strict = resource.strict,
      sticky = resource.sticky,
      state = resource.state,
      priority = resource.priority
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      clusternodegroup[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        clusternodegroup[] clusternodegroupArray = new clusternodegroup[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          clusternodegroupArray[index] = new clusternodegroup();
          clusternodegroupArray[index].name = resources[index].name;
          clusternodegroupArray[index].strict = resources[index].strict;
          clusternodegroupArray[index].sticky = resources[index].sticky;
          clusternodegroupArray[index].state = resources[index].state;
          clusternodegroupArray[index].priority = resources[index].priority;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) clusternodegroupArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, clusternodegroup resource) => new clusternodegroup()
    {
      name = resource.name,
      strict = resource.strict,
      state = resource.state,
      priority = resource.priority
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      clusternodegroup[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        clusternodegroup[] clusternodegroupArray = new clusternodegroup[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          clusternodegroupArray[index] = new clusternodegroup();
          clusternodegroupArray[index].name = resources[index].name;
          clusternodegroupArray[index].strict = resources[index].strict;
          clusternodegroupArray[index].state = resources[index].state;
          clusternodegroupArray[index].priority = resources[index].priority;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) clusternodegroupArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new clusternodegroup() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      clusternodegroup resource,
      string[] args)
    {
      return new clusternodegroup() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        clusternodegroup[] clusternodegroupArray = new clusternodegroup[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          clusternodegroupArray[index] = new clusternodegroup();
          clusternodegroupArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) clusternodegroupArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      clusternodegroup[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        clusternodegroup[] clusternodegroupArray = new clusternodegroup[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          clusternodegroupArray[index] = new clusternodegroup();
          clusternodegroupArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) clusternodegroupArray, args);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new clusternodegroup()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, clusternodegroup resource) => new clusternodegroup()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        clusternodegroup[] clusternodegroupArray = new clusternodegroup[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          clusternodegroupArray[index] = new clusternodegroup();
          clusternodegroupArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) clusternodegroupArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      clusternodegroup[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        clusternodegroup[] clusternodegroupArray = new clusternodegroup[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          clusternodegroupArray[index] = new clusternodegroup();
          clusternodegroupArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) clusternodegroupArray);
      }
      return baseResponses;
    }

    public static clusternodegroup[] get(nitro_service service) => (clusternodegroup[]) new clusternodegroup().get_resources(service, (options) null);

    public static clusternodegroup[] get(nitro_service service, options option) => (clusternodegroup[]) new clusternodegroup().get_resources(service, option);

    public static clusternodegroup get(nitro_service service, string name) => (clusternodegroup) new clusternodegroup()
    {
      name = name
    }.get_resource(service);

    public static clusternodegroup[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (clusternodegroup[]) null;
      clusternodegroup[] clusternodegroupArray1 = new clusternodegroup[name.Length];
      clusternodegroup[] clusternodegroupArray2 = new clusternodegroup[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        clusternodegroupArray2[index] = new clusternodegroup();
        clusternodegroupArray2[index].name = name[index];
        clusternodegroupArray1[index] = (clusternodegroup) clusternodegroupArray2[index].get_resource(service);
      }
      return clusternodegroupArray1;
    }

    public static clusternodegroup[] get_filtered(
      nitro_service service,
      string filter)
    {
      clusternodegroup clusternodegroup = new clusternodegroup();
      options option = new options();
      option.set_filter(filter);
      return (clusternodegroup[]) clusternodegroup.getfiltered(service, option);
    }

    public static clusternodegroup[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      clusternodegroup clusternodegroup = new clusternodegroup();
      options option = new options();
      option.set_filter(filter);
      return (clusternodegroup[]) clusternodegroup.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      clusternodegroup clusternodegroup = new clusternodegroup();
      options option = new options();
      option.set_count(true);
      clusternodegroup[] resources = (clusternodegroup[]) clusternodegroup.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      clusternodegroup clusternodegroup = new clusternodegroup();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      clusternodegroup[] clusternodegroupArray = (clusternodegroup[]) clusternodegroup.getfiltered(service, option);
      return clusternodegroupArray != null && clusternodegroupArray.Length > 0 ? clusternodegroupArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      clusternodegroup clusternodegroup = new clusternodegroup();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      clusternodegroup[] clusternodegroupArray = (clusternodegroup[]) clusternodegroup.getfiltered(service, option);
      return clusternodegroupArray != null && clusternodegroupArray.Length > 0 ? clusternodegroupArray[0].__count.Value : 0U;
    }

    private class clusternodegroup_response : base_response
    {
      public clusternodegroup[] clusternodegroup = (clusternodegroup[]) null;
    }

    public static class stateEnum
    {
      public const string ACTIVE = "ACTIVE";
      public const string SPARE = "SPARE";
      public const string PASSIVE = "PASSIVE";
    }

    public static class strictEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class stickyEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }
  }
}
