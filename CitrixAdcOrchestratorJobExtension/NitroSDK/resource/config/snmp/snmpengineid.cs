// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.snmp.snmpengineid
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.snmp
{
  public class snmpengineid : base_resource
  {
    private string engineidField = (string) null;
    private uint? ownernodeField = new uint?();
    private string defaultengineidField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string engineid
    {
      get => this.engineidField;
      set => this.engineidField = value;
    }

    public uint? ownernode
    {
      get => this.ownernodeField;
      set => this.ownernodeField = value;
    }

    public string defaultengineid
    {
      get => this.defaultengineidField;
      private set => this.defaultengineidField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      snmpengineid.snmpengineid_response snmpengineidResponse = new snmpengineid.snmpengineid_response();
      snmpengineid.snmpengineid_response resource = (snmpengineid.snmpengineid_response) service.get_payload_formatter().string_to_resource(snmpengineidResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.snmpengineid;
    }

    internal override string get_object_name() => this.ownernode.HasValue ? this.ownernode.ToString() : (string) null;

    public static base_response update(nitro_service client, snmpengineid resource) => new snmpengineid()
    {
      engineid = resource.engineid,
      ownernode = resource.ownernode
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      snmpengineid[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        snmpengineid[] snmpengineidArray = new snmpengineid[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          snmpengineidArray[index] = new snmpengineid();
          snmpengineidArray[index].engineid = resources[index].engineid;
          snmpengineidArray[index].ownernode = resources[index].ownernode;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) snmpengineidArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      uint? ownernode,
      string[] args)
    {
      return new snmpengineid() { ownernode = ownernode }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      snmpengineid resource,
      string[] args)
    {
      return new snmpengineid()
      {
        ownernode = resource.ownernode
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      uint?[] ownernode,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (ownernode != null && ownernode.Length > 0)
      {
        snmpengineid[] snmpengineidArray = new snmpengineid[ownernode.Length];
        for (int index = 0; index < ownernode.Length; ++index)
        {
          snmpengineidArray[index] = new snmpengineid();
          snmpengineidArray[index].ownernode = ownernode[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) snmpengineidArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      snmpengineid[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        snmpengineid[] snmpengineidArray = new snmpengineid[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          snmpengineidArray[index] = new snmpengineid();
          snmpengineidArray[index].ownernode = resources[index].ownernode;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) snmpengineidArray, args);
      }
      return baseResponses;
    }

    public static snmpengineid[] get(nitro_service service) => (snmpengineid[]) new snmpengineid().get_resources(service, (options) null);

    public static snmpengineid[] get(nitro_service service, options option) => (snmpengineid[]) new snmpengineid().get_resources(service, option);

    public static snmpengineid get(nitro_service service, uint? ownernode) => (snmpengineid) new snmpengineid()
    {
      ownernode = ownernode
    }.get_resource(service);

    public static snmpengineid[] get(nitro_service service, uint?[] ownernode)
    {
      if (ownernode == null || ownernode.Length <= 0)
        return (snmpengineid[]) null;
      snmpengineid[] snmpengineidArray1 = new snmpengineid[ownernode.Length];
      snmpengineid[] snmpengineidArray2 = new snmpengineid[ownernode.Length];
      for (int index = 0; index < ownernode.Length; ++index)
      {
        snmpengineidArray2[index] = new snmpengineid();
        snmpengineidArray2[index].ownernode = ownernode[index];
        snmpengineidArray1[index] = (snmpengineid) snmpengineidArray2[index].get_resource(service);
      }
      return snmpengineidArray1;
    }

    public static snmpengineid[] get_filtered(nitro_service service, string filter)
    {
      snmpengineid snmpengineid = new snmpengineid();
      options option = new options();
      option.set_filter(filter);
      return (snmpengineid[]) snmpengineid.getfiltered(service, option);
    }

    public static snmpengineid[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      snmpengineid snmpengineid = new snmpengineid();
      options option = new options();
      option.set_filter(filter);
      return (snmpengineid[]) snmpengineid.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      snmpengineid snmpengineid = new snmpengineid();
      options option = new options();
      option.set_count(true);
      snmpengineid[] resources = (snmpengineid[]) snmpengineid.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      snmpengineid snmpengineid = new snmpengineid();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      snmpengineid[] snmpengineidArray = (snmpengineid[]) snmpengineid.getfiltered(service, option);
      return snmpengineidArray != null && snmpengineidArray.Length > 0 ? snmpengineidArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      snmpengineid snmpengineid = new snmpengineid();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      snmpengineid[] snmpengineidArray = (snmpengineid[]) snmpengineid.getfiltered(service, option);
      return snmpengineidArray != null && snmpengineidArray.Length > 0 ? snmpengineidArray[0].__count.Value : 0U;
    }

    private class snmpengineid_response : base_response
    {
      public snmpengineid[] snmpengineid = (snmpengineid[]) null;
    }
  }
}
