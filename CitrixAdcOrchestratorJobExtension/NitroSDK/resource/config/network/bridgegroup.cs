// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.bridgegroup
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class bridgegroup : base_resource
  {
    private uint? idField = new uint?();
    private string dynamicroutingField = (string) null;
    private string ipv6dynamicroutingField = (string) null;
    private bool? flagsField = new bool?();
    private long? portbitmapField = new long?();
    private long? tagbitmapField = new long?();
    private string ifacesField = (string) null;
    private string tagifacesField = (string) null;
    private bool? rnatField = new bool?();
    private string partitionnameField = (string) null;
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

    public string dynamicrouting
    {
      get => this.dynamicroutingField;
      set => this.dynamicroutingField = value;
    }

    public string ipv6dynamicrouting
    {
      get => this.ipv6dynamicroutingField;
      set => this.ipv6dynamicroutingField = value;
    }

    public bool? flags
    {
      get => this.flagsField;
      private set => this.flagsField = value;
    }

    public long? portbitmap
    {
      get => this.portbitmapField;
      private set => this.portbitmapField = value;
    }

    public long? tagbitmap
    {
      get => this.tagbitmapField;
      private set => this.tagbitmapField = value;
    }

    public string ifaces
    {
      get => this.ifacesField;
      private set => this.ifacesField = value;
    }

    public string tagifaces
    {
      get => this.tagifacesField;
      private set => this.tagifacesField = value;
    }

    public bool? rnat
    {
      get => this.rnatField;
      private set => this.rnatField = value;
    }

    public string partitionname
    {
      get => this.partitionnameField;
      private set => this.partitionnameField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      bridgegroup.bridgegroup_response bridgegroupResponse = new bridgegroup.bridgegroup_response();
      bridgegroup.bridgegroup_response resource = (bridgegroup.bridgegroup_response) service.get_payload_formatter().string_to_resource(bridgegroupResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.bridgegroup;
    }

    internal override string get_object_name() => this.id.HasValue ? this.id.ToString() : (string) null;

    public static base_response add(nitro_service client, bridgegroup resource) => new bridgegroup()
    {
      id = resource.id,
      dynamicrouting = resource.dynamicrouting,
      ipv6dynamicrouting = resource.ipv6dynamicrouting
    }.add_resource(client);

    public static base_responses add(nitro_service client, bridgegroup[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        bridgegroup[] bridgegroupArray = new bridgegroup[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          bridgegroupArray[index] = new bridgegroup();
          bridgegroupArray[index].id = resources[index].id;
          bridgegroupArray[index].dynamicrouting = resources[index].dynamicrouting;
          bridgegroupArray[index].ipv6dynamicrouting = resources[index].ipv6dynamicrouting;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) bridgegroupArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, uint? id) => new bridgegroup()
    {
      id = id
    }.delete_resource(client);

    public static base_response delete(nitro_service client, bridgegroup resource) => new bridgegroup()
    {
      id = resource.id
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, uint?[] id)
    {
      base_responses baseResponses = (base_responses) null;
      if (id != null && id.Length > 0)
      {
        bridgegroup[] bridgegroupArray = new bridgegroup[id.Length];
        for (int index = 0; index < id.Length; ++index)
        {
          bridgegroupArray[index] = new bridgegroup();
          bridgegroupArray[index].id = id[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) bridgegroupArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, bridgegroup[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        bridgegroup[] bridgegroupArray = new bridgegroup[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          bridgegroupArray[index] = new bridgegroup();
          bridgegroupArray[index].id = resources[index].id;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) bridgegroupArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, bridgegroup resource) => new bridgegroup()
    {
      id = resource.id,
      dynamicrouting = resource.dynamicrouting,
      ipv6dynamicrouting = resource.ipv6dynamicrouting
    }.update_resource(client);

    public static base_responses update(nitro_service client, bridgegroup[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        bridgegroup[] bridgegroupArray = new bridgegroup[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          bridgegroupArray[index] = new bridgegroup();
          bridgegroupArray[index].id = resources[index].id;
          bridgegroupArray[index].dynamicrouting = resources[index].dynamicrouting;
          bridgegroupArray[index].ipv6dynamicrouting = resources[index].ipv6dynamicrouting;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) bridgegroupArray);
      }
      return baseResponses;
    }

    public static base_response unset(nitro_service client, uint? id, string[] args) => new bridgegroup()
    {
      id = id
    }.unset_resource(client, args);

    public static base_response unset(
      nitro_service client,
      bridgegroup resource,
      string[] args)
    {
      return new bridgegroup() { id = resource.id }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      uint?[] id,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (id != null && id.Length > 0)
      {
        bridgegroup[] bridgegroupArray = new bridgegroup[id.Length];
        for (int index = 0; index < id.Length; ++index)
        {
          bridgegroupArray[index] = new bridgegroup();
          bridgegroupArray[index].id = id[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) bridgegroupArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      bridgegroup[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        bridgegroup[] bridgegroupArray = new bridgegroup[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          bridgegroupArray[index] = new bridgegroup();
          bridgegroupArray[index].id = resources[index].id;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) bridgegroupArray, args);
      }
      return baseResponses;
    }

    public static bridgegroup[] get(nitro_service service) => (bridgegroup[]) new bridgegroup().get_resources(service, (options) null);

    public static bridgegroup[] get(nitro_service service, options option) => (bridgegroup[]) new bridgegroup().get_resources(service, option);

    public static bridgegroup get(nitro_service service, uint? id) => (bridgegroup) new bridgegroup()
    {
      id = id
    }.get_resource(service);

    public static bridgegroup[] get(nitro_service service, uint?[] id)
    {
      if (id == null || id.Length <= 0)
        return (bridgegroup[]) null;
      bridgegroup[] bridgegroupArray1 = new bridgegroup[id.Length];
      bridgegroup[] bridgegroupArray2 = new bridgegroup[id.Length];
      for (int index = 0; index < id.Length; ++index)
      {
        bridgegroupArray2[index] = new bridgegroup();
        bridgegroupArray2[index].id = id[index];
        bridgegroupArray1[index] = (bridgegroup) bridgegroupArray2[index].get_resource(service);
      }
      return bridgegroupArray1;
    }

    public static bridgegroup[] get_filtered(nitro_service service, string filter)
    {
      bridgegroup bridgegroup = new bridgegroup();
      options option = new options();
      option.set_filter(filter);
      return (bridgegroup[]) bridgegroup.getfiltered(service, option);
    }

    public static bridgegroup[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      bridgegroup bridgegroup = new bridgegroup();
      options option = new options();
      option.set_filter(filter);
      return (bridgegroup[]) bridgegroup.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      bridgegroup bridgegroup = new bridgegroup();
      options option = new options();
      option.set_count(true);
      bridgegroup[] resources = (bridgegroup[]) bridgegroup.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      bridgegroup bridgegroup = new bridgegroup();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      bridgegroup[] bridgegroupArray = (bridgegroup[]) bridgegroup.getfiltered(service, option);
      return bridgegroupArray != null && bridgegroupArray.Length > 0 ? bridgegroupArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      bridgegroup bridgegroup = new bridgegroup();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      bridgegroup[] bridgegroupArray = (bridgegroup[]) bridgegroup.getfiltered(service, option);
      return bridgegroupArray != null && bridgegroupArray.Length > 0 ? bridgegroupArray[0].__count.Value : 0U;
    }

    private class bridgegroup_response : base_response
    {
      public bridgegroup[] bridgegroup = (bridgegroup[]) null;
    }

    public static class ipv6dynamicroutingEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class dynamicroutingEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
