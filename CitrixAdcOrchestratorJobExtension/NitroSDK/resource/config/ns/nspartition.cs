// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nspartition
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nspartition : base_resource
  {
    private string partitionnameField = (string) null;
    private uint? maxbandwidthField = new uint?();
    private uint? minbandwidthField = new uint?();
    private uint? maxconnField = new uint?();
    private long? maxmemlimitField = new long?();
    private uint? partitionidField = new uint?();
    private string partitiontypeField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string partitionname
    {
      get => this.partitionnameField;
      set => this.partitionnameField = value;
    }

    public uint? maxbandwidth
    {
      get => this.maxbandwidthField;
      set => this.maxbandwidthField = value;
    }

    public uint? minbandwidth
    {
      get => this.minbandwidthField;
      set => this.minbandwidthField = value;
    }

    public uint? maxconn
    {
      get => this.maxconnField;
      set => this.maxconnField = value;
    }

    public long? maxmemlimit
    {
      get => this.maxmemlimitField;
      set => this.maxmemlimitField = value;
    }

    public uint? partitionid
    {
      get => this.partitionidField;
      private set => this.partitionidField = value;
    }

    public string partitiontype
    {
      get => this.partitiontypeField;
      private set => this.partitiontypeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nspartition.nspartition_response nspartitionResponse = new nspartition.nspartition_response();
      nspartition.nspartition_response resource = (nspartition.nspartition_response) service.get_payload_formatter().string_to_resource(nspartitionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nspartition;
    }

    internal override string get_object_name() => this.partitionname;

    public static base_response add(nitro_service client, nspartition resource) => new nspartition()
    {
      partitionname = resource.partitionname,
      maxbandwidth = resource.maxbandwidth,
      minbandwidth = resource.minbandwidth,
      maxconn = resource.maxconn,
      maxmemlimit = resource.maxmemlimit
    }.add_resource(client);

    public static base_responses add(nitro_service client, nspartition[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nspartition[] nspartitionArray = new nspartition[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nspartitionArray[index] = new nspartition();
          nspartitionArray[index].partitionname = resources[index].partitionname;
          nspartitionArray[index].maxbandwidth = resources[index].maxbandwidth;
          nspartitionArray[index].minbandwidth = resources[index].minbandwidth;
          nspartitionArray[index].maxconn = resources[index].maxconn;
          nspartitionArray[index].maxmemlimit = resources[index].maxmemlimit;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) nspartitionArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string partitionname) => new nspartition()
    {
      partitionname = partitionname
    }.delete_resource(client);

    public static base_response delete(nitro_service client, nspartition resource) => new nspartition()
    {
      partitionname = resource.partitionname
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] partitionname)
    {
      base_responses baseResponses = (base_responses) null;
      if (partitionname != null && partitionname.Length > 0)
      {
        nspartition[] nspartitionArray = new nspartition[partitionname.Length];
        for (int index = 0; index < partitionname.Length; ++index)
        {
          nspartitionArray[index] = new nspartition();
          nspartitionArray[index].partitionname = partitionname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nspartitionArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, nspartition[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nspartition[] nspartitionArray = new nspartition[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nspartitionArray[index] = new nspartition();
          nspartitionArray[index].partitionname = resources[index].partitionname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nspartitionArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, nspartition resource) => new nspartition()
    {
      partitionname = resource.partitionname,
      maxbandwidth = resource.maxbandwidth,
      minbandwidth = resource.minbandwidth,
      maxconn = resource.maxconn,
      maxmemlimit = resource.maxmemlimit
    }.update_resource(client);

    public static base_responses update(nitro_service client, nspartition[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nspartition[] nspartitionArray = new nspartition[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nspartitionArray[index] = new nspartition();
          nspartitionArray[index].partitionname = resources[index].partitionname;
          nspartitionArray[index].maxbandwidth = resources[index].maxbandwidth;
          nspartitionArray[index].minbandwidth = resources[index].minbandwidth;
          nspartitionArray[index].maxconn = resources[index].maxconn;
          nspartitionArray[index].maxmemlimit = resources[index].maxmemlimit;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) nspartitionArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string partitionname,
      string[] args)
    {
      return new nspartition()
      {
        partitionname = partitionname
      }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      nspartition resource,
      string[] args)
    {
      return new nspartition()
      {
        partitionname = resource.partitionname
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] partitionname,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (partitionname != null && partitionname.Length > 0)
      {
        nspartition[] nspartitionArray = new nspartition[partitionname.Length];
        for (int index = 0; index < partitionname.Length; ++index)
        {
          nspartitionArray[index] = new nspartition();
          nspartitionArray[index].partitionname = partitionname[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) nspartitionArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      nspartition[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nspartition[] nspartitionArray = new nspartition[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nspartitionArray[index] = new nspartition();
          nspartitionArray[index].partitionname = resources[index].partitionname;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) nspartitionArray, args);
      }
      return baseResponses;
    }

    public static base_response Switch(nitro_service client, nspartition resource) => new nspartition()
    {
      partitionname = resource.partitionname
    }.perform_operation_byaction(client, nameof (Switch));

    public static base_responses Switch(nitro_service client, nspartition[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nspartition[] nspartitionArray = new nspartition[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nspartitionArray[index] = new nspartition();
          nspartitionArray[index].partitionname = resources[index].partitionname;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) nspartitionArray, nameof (Switch));
      }
      return baseResponses;
    }

    public static nspartition[] get(nitro_service service) => (nspartition[]) new nspartition().get_resources(service, (options) null);

    public static nspartition[] get(nitro_service service, options option) => (nspartition[]) new nspartition().get_resources(service, option);

    public static nspartition get(nitro_service service, string partitionname) => (nspartition) new nspartition()
    {
      partitionname = partitionname
    }.get_resource(service);

    public static nspartition[] get(nitro_service service, string[] partitionname)
    {
      if (partitionname == null || partitionname.Length <= 0)
        return (nspartition[]) null;
      nspartition[] nspartitionArray1 = new nspartition[partitionname.Length];
      nspartition[] nspartitionArray2 = new nspartition[partitionname.Length];
      for (int index = 0; index < partitionname.Length; ++index)
      {
        nspartitionArray2[index] = new nspartition();
        nspartitionArray2[index].partitionname = partitionname[index];
        nspartitionArray1[index] = (nspartition) nspartitionArray2[index].get_resource(service);
      }
      return nspartitionArray1;
    }

    public static nspartition[] get_filtered(nitro_service service, string filter)
    {
      nspartition nspartition = new nspartition();
      options option = new options();
      option.set_filter(filter);
      return (nspartition[]) nspartition.getfiltered(service, option);
    }

    public static nspartition[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      nspartition nspartition = new nspartition();
      options option = new options();
      option.set_filter(filter);
      return (nspartition[]) nspartition.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      nspartition nspartition = new nspartition();
      options option = new options();
      option.set_count(true);
      nspartition[] resources = (nspartition[]) nspartition.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      nspartition nspartition = new nspartition();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nspartition[] nspartitionArray = (nspartition[]) nspartition.getfiltered(service, option);
      return nspartitionArray != null && nspartitionArray.Length > 0 ? nspartitionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      nspartition nspartition = new nspartition();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nspartition[] nspartitionArray = (nspartition[]) nspartition.getfiltered(service, option);
      return nspartitionArray != null && nspartitionArray.Length > 0 ? nspartitionArray[0].__count.Value : 0U;
    }

    private class nspartition_response : base_response
    {
      public nspartition[] nspartition = (nspartition[]) null;
    }

    public static class partitiontypeEnum
    {
      public const string Default_Partition = "Default Partition";
      public const string Current_Partition = "Current Partition";
    }
  }
}
