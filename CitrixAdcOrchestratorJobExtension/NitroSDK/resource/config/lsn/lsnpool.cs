// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lsn.lsnpool
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.lsn
{
  public class lsnpool : base_resource
  {
    private string poolnameField = (string) null;
    private string nattypeField = (string) null;
    private string portblockallocationField = (string) null;
    private long? portrealloctimeoutField = new long?();
    private uint? maxportrealloctmqField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string poolname
    {
      get => this.poolnameField;
      set => this.poolnameField = value;
    }

    public string nattype
    {
      get => this.nattypeField;
      set => this.nattypeField = value;
    }

    public string portblockallocation
    {
      get => this.portblockallocationField;
      set => this.portblockallocationField = value;
    }

    public long? portrealloctimeout
    {
      get => this.portrealloctimeoutField;
      set => this.portrealloctimeoutField = value;
    }

    public uint? maxportrealloctmq
    {
      get => this.maxportrealloctmqField;
      set => this.maxportrealloctmqField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lsnpool.lsnpool_response lsnpoolResponse = new lsnpool.lsnpool_response();
      lsnpool.lsnpool_response resource = (lsnpool.lsnpool_response) service.get_payload_formatter().string_to_resource(lsnpoolResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lsnpool;
    }

    internal override string get_object_name() => this.poolname;

    public static base_response add(nitro_service client, lsnpool resource) => new lsnpool()
    {
      poolname = resource.poolname,
      nattype = resource.nattype,
      portblockallocation = resource.portblockallocation,
      portrealloctimeout = resource.portrealloctimeout,
      maxportrealloctmq = resource.maxportrealloctmq
    }.add_resource(client);

    public static base_responses add(nitro_service client, lsnpool[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsnpool[] lsnpoolArray = new lsnpool[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsnpoolArray[index] = new lsnpool();
          lsnpoolArray[index].poolname = resources[index].poolname;
          lsnpoolArray[index].nattype = resources[index].nattype;
          lsnpoolArray[index].portblockallocation = resources[index].portblockallocation;
          lsnpoolArray[index].portrealloctimeout = resources[index].portrealloctimeout;
          lsnpoolArray[index].maxportrealloctmq = resources[index].maxportrealloctmq;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) lsnpoolArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string poolname) => new lsnpool()
    {
      poolname = poolname
    }.delete_resource(client);

    public static base_response delete(nitro_service client, lsnpool resource) => new lsnpool()
    {
      poolname = resource.poolname
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] poolname)
    {
      base_responses baseResponses = (base_responses) null;
      if (poolname != null && poolname.Length > 0)
      {
        lsnpool[] lsnpoolArray = new lsnpool[poolname.Length];
        for (int index = 0; index < poolname.Length; ++index)
        {
          lsnpoolArray[index] = new lsnpool();
          lsnpoolArray[index].poolname = poolname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lsnpoolArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, lsnpool[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsnpool[] lsnpoolArray = new lsnpool[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsnpoolArray[index] = new lsnpool();
          lsnpoolArray[index].poolname = resources[index].poolname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) lsnpoolArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, lsnpool resource) => new lsnpool()
    {
      poolname = resource.poolname,
      portrealloctimeout = resource.portrealloctimeout,
      maxportrealloctmq = resource.maxportrealloctmq
    }.update_resource(client);

    public static base_responses update(nitro_service client, lsnpool[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsnpool[] lsnpoolArray = new lsnpool[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsnpoolArray[index] = new lsnpool();
          lsnpoolArray[index].poolname = resources[index].poolname;
          lsnpoolArray[index].portrealloctimeout = resources[index].portrealloctimeout;
          lsnpoolArray[index].maxportrealloctmq = resources[index].maxportrealloctmq;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) lsnpoolArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string poolname,
      string[] args)
    {
      return new lsnpool() { poolname = poolname }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      lsnpool resource,
      string[] args)
    {
      return new lsnpool() { poolname = resource.poolname }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] poolname,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (poolname != null && poolname.Length > 0)
      {
        lsnpool[] lsnpoolArray = new lsnpool[poolname.Length];
        for (int index = 0; index < poolname.Length; ++index)
        {
          lsnpoolArray[index] = new lsnpool();
          lsnpoolArray[index].poolname = poolname[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) lsnpoolArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      lsnpool[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        lsnpool[] lsnpoolArray = new lsnpool[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          lsnpoolArray[index] = new lsnpool();
          lsnpoolArray[index].poolname = resources[index].poolname;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) lsnpoolArray, args);
      }
      return baseResponses;
    }

    public static lsnpool[] get(nitro_service service) => (lsnpool[]) new lsnpool().get_resources(service, (options) null);

    public static lsnpool[] get(nitro_service service, options option) => (lsnpool[]) new lsnpool().get_resources(service, option);

    public static lsnpool get(nitro_service service, string poolname) => (lsnpool) new lsnpool()
    {
      poolname = poolname
    }.get_resource(service);

    public static lsnpool[] get(nitro_service service, string[] poolname)
    {
      if (poolname == null || poolname.Length <= 0)
        return (lsnpool[]) null;
      lsnpool[] lsnpoolArray1 = new lsnpool[poolname.Length];
      lsnpool[] lsnpoolArray2 = new lsnpool[poolname.Length];
      for (int index = 0; index < poolname.Length; ++index)
      {
        lsnpoolArray2[index] = new lsnpool();
        lsnpoolArray2[index].poolname = poolname[index];
        lsnpoolArray1[index] = (lsnpool) lsnpoolArray2[index].get_resource(service);
      }
      return lsnpoolArray1;
    }

    public static lsnpool[] get_filtered(nitro_service service, string filter)
    {
      lsnpool lsnpool = new lsnpool();
      options option = new options();
      option.set_filter(filter);
      return (lsnpool[]) lsnpool.getfiltered(service, option);
    }

    public static lsnpool[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      lsnpool lsnpool = new lsnpool();
      options option = new options();
      option.set_filter(filter);
      return (lsnpool[]) lsnpool.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      lsnpool lsnpool = new lsnpool();
      options option = new options();
      option.set_count(true);
      lsnpool[] resources = (lsnpool[]) lsnpool.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      lsnpool lsnpool = new lsnpool();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsnpool[] lsnpoolArray = (lsnpool[]) lsnpool.getfiltered(service, option);
      return lsnpoolArray != null && lsnpoolArray.Length > 0 ? lsnpoolArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      lsnpool lsnpool = new lsnpool();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      lsnpool[] lsnpoolArray = (lsnpool[]) lsnpool.getfiltered(service, option);
      return lsnpoolArray != null && lsnpoolArray.Length > 0 ? lsnpoolArray[0].__count.Value : 0U;
    }

    private class lsnpool_response : base_response
    {
      public lsnpool[] lsnpool = (lsnpool[]) null;
    }

    public static class portblockallocationEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class nattypeEnum
    {
      public const string DYNAMIC = "DYNAMIC";
      public const string DETERMINISTIC = "DETERMINISTIC";
    }
  }
}
