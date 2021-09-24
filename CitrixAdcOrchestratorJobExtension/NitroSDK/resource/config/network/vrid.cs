// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.vrid
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class vrid : base_resource
  {
    private uint? idField = new uint?();
    private uint? priorityField = new uint?();
    private string preemptionField = (string) null;
    private string sharingField = (string) null;
    private string trackingField = (string) null;
    private uint? ownernodeField = new uint?();
    private uint? trackifnumpriorityField = new uint?();
    private long? preemptiondelaytimerField = new long?();
    private bool? allField = new bool?();
    private string ifacesField = (string) null;
    private string typeField = (string) null;
    private uint? effectivepriorityField = new uint?();
    private uint? flagsField = new uint?();
    private string ipaddressField = (string) null;
    private uint? stateField = new uint?();
    private uint? operationalownernodeField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public uint? id
    {
      get => this.idField;
      set => this.idField = value;
    }

    public uint? priority
    {
      get => this.priorityField;
      set => this.priorityField = value;
    }

    public string preemption
    {
      get => this.preemptionField;
      set => this.preemptionField = value;
    }

    public string sharing
    {
      get => this.sharingField;
      set => this.sharingField = value;
    }

    public string tracking
    {
      get => this.trackingField;
      set => this.trackingField = value;
    }

    public uint? ownernode
    {
      get => this.ownernodeField;
      set => this.ownernodeField = value;
    }

    public uint? trackifnumpriority
    {
      get => this.trackifnumpriorityField;
      set => this.trackifnumpriorityField = value;
    }

    public long? preemptiondelaytimer
    {
      get => this.preemptiondelaytimerField;
      set => this.preemptiondelaytimerField = value;
    }

    public bool? all
    {
      get => this.allField;
      set => this.allField = value;
    }

    public string ifaces
    {
      get => this.ifacesField;
      private set => this.ifacesField = value;
    }

    public string type
    {
      get => this.typeField;
      private set => this.typeField = value;
    }

    public uint? effectivepriority
    {
      get => this.effectivepriorityField;
      private set => this.effectivepriorityField = value;
    }

    public uint? flags
    {
      get => this.flagsField;
      private set => this.flagsField = value;
    }

    public string ipaddress
    {
      get => this.ipaddressField;
      private set => this.ipaddressField = value;
    }

    public uint? state
    {
      get => this.stateField;
      private set => this.stateField = value;
    }

    public uint? operationalownernode
    {
      get => this.operationalownernodeField;
      private set => this.operationalownernodeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vrid.vrid_response vridResponse = new vrid.vrid_response();
      vrid.vrid_response resource = (vrid.vrid_response) service.get_payload_formatter().string_to_resource(vridResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vrid;
    }

    internal override string get_object_name() => this.id.HasValue ? this.id.ToString() : (string) null;

    public static base_response add(nitro_service client, vrid resource) => new vrid()
    {
      id = resource.id,
      priority = resource.priority,
      preemption = resource.preemption,
      sharing = resource.sharing,
      tracking = resource.tracking,
      ownernode = resource.ownernode,
      trackifnumpriority = resource.trackifnumpriority,
      preemptiondelaytimer = resource.preemptiondelaytimer
    }.add_resource(client);

    public static base_responses add(nitro_service client, vrid[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vrid[] vridArray = new vrid[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vridArray[index] = new vrid();
          vridArray[index].id = resources[index].id;
          vridArray[index].priority = resources[index].priority;
          vridArray[index].preemption = resources[index].preemption;
          vridArray[index].sharing = resources[index].sharing;
          vridArray[index].tracking = resources[index].tracking;
          vridArray[index].ownernode = resources[index].ownernode;
          vridArray[index].trackifnumpriority = resources[index].trackifnumpriority;
          vridArray[index].preemptiondelaytimer = resources[index].preemptiondelaytimer;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) vridArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, uint? id) => new vrid()
    {
      id = id
    }.delete_resource(client);

    public static base_response delete(nitro_service client, vrid resource) => new vrid()
    {
      id = resource.id,
      all = resource.all
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, uint?[] id)
    {
      base_responses baseResponses = (base_responses) null;
      if (id != null && id.Length > 0)
      {
        vrid[] vridArray = new vrid[id.Length];
        for (int index = 0; index < id.Length; ++index)
        {
          vridArray[index] = new vrid();
          vridArray[index].id = id[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vridArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, vrid[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vrid[] vridArray = new vrid[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vridArray[index] = new vrid();
          vridArray[index].id = resources[index].id;
          vridArray[index].all = resources[index].all;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vridArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, vrid resource) => new vrid()
    {
      id = resource.id,
      priority = resource.priority,
      preemption = resource.preemption,
      sharing = resource.sharing,
      tracking = resource.tracking,
      ownernode = resource.ownernode,
      trackifnumpriority = resource.trackifnumpriority,
      preemptiondelaytimer = resource.preemptiondelaytimer
    }.update_resource(client);

    public static base_responses update(nitro_service client, vrid[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vrid[] vridArray = new vrid[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vridArray[index] = new vrid();
          vridArray[index].id = resources[index].id;
          vridArray[index].priority = resources[index].priority;
          vridArray[index].preemption = resources[index].preemption;
          vridArray[index].sharing = resources[index].sharing;
          vridArray[index].tracking = resources[index].tracking;
          vridArray[index].ownernode = resources[index].ownernode;
          vridArray[index].trackifnumpriority = resources[index].trackifnumpriority;
          vridArray[index].preemptiondelaytimer = resources[index].preemptiondelaytimer;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) vridArray);
      }
      return baseResponses;
    }

    public static base_response unset(nitro_service client, uint? id, string[] args) => new vrid()
    {
      id = id
    }.unset_resource(client, args);

    public static base_response unset(
      nitro_service client,
      vrid resource,
      string[] args)
    {
      return new vrid() { id = resource.id }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      uint?[] id,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (id != null && id.Length > 0)
      {
        vrid[] vridArray = new vrid[id.Length];
        for (int index = 0; index < id.Length; ++index)
        {
          vridArray[index] = new vrid();
          vridArray[index].id = id[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) vridArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      vrid[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vrid[] vridArray = new vrid[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vridArray[index] = new vrid();
          vridArray[index].id = resources[index].id;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) vridArray, args);
      }
      return baseResponses;
    }

    public static vrid[] get(nitro_service service) => (vrid[]) new vrid().get_resources(service, (options) null);

    public static vrid[] get(nitro_service service, options option) => (vrid[]) new vrid().get_resources(service, option);

    public static vrid get(nitro_service service, uint? id) => (vrid) new vrid()
    {
      id = id
    }.get_resource(service);

    public static vrid[] get(nitro_service service, uint?[] id)
    {
      if (id == null || id.Length <= 0)
        return (vrid[]) null;
      vrid[] vridArray1 = new vrid[id.Length];
      vrid[] vridArray2 = new vrid[id.Length];
      for (int index = 0; index < id.Length; ++index)
      {
        vridArray2[index] = new vrid();
        vridArray2[index].id = id[index];
        vridArray1[index] = (vrid) vridArray2[index].get_resource(service);
      }
      return vridArray1;
    }

    public static vrid[] get_filtered(nitro_service service, string filter)
    {
      vrid vrid = new vrid();
      options option = new options();
      option.set_filter(filter);
      return (vrid[]) vrid.getfiltered(service, option);
    }

    public static vrid[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      vrid vrid = new vrid();
      options option = new options();
      option.set_filter(filter);
      return (vrid[]) vrid.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      vrid vrid = new vrid();
      options option = new options();
      option.set_count(true);
      vrid[] resources = (vrid[]) vrid.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      vrid vrid = new vrid();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vrid[] vridArray = (vrid[]) vrid.getfiltered(service, option);
      return vridArray != null && vridArray.Length > 0 ? vridArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      vrid vrid = new vrid();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vrid[] vridArray = (vrid[]) vrid.getfiltered(service, option);
      return vridArray != null && vridArray.Length > 0 ? vridArray[0].__count.Value : 0U;
    }

    private class vrid_response : base_response
    {
      public vrid[] vrid = (vrid[]) null;
    }

    public static class sharingEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class typeEnum
    {
      public const string STATIC = "STATIC";
      public const string DYNAMIC = "DYNAMIC";
    }

    public static class trackingEnum
    {
      public const string NONE = "NONE";
      public const string ONE = "ONE";
      public const string ALL = "ALL";
      public const string PROGRESSIVE = "PROGRESSIVE";
    }

    public static class preemptionEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
