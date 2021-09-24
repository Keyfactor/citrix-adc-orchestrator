// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.rnat6
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class rnat6 : base_resource
  {
    private string nameField = (string) null;
    private string networkField = (string) null;
    private string acl6nameField = (string) null;
    private ushort? redirectportField = new ushort?();
    private uint? tdField = new uint?();
    private string srcippersistencyField = (string) null;
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

    public string network
    {
      get => this.networkField;
      set => this.networkField = value;
    }

    public string acl6name
    {
      get => this.acl6nameField;
      set => this.acl6nameField = value;
    }

    public ushort? redirectport
    {
      get => this.redirectportField;
      set => this.redirectportField = value;
    }

    public uint? td
    {
      get => this.tdField;
      set => this.tdField = value;
    }

    public string srcippersistency
    {
      get => this.srcippersistencyField;
      set => this.srcippersistencyField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      rnat6.rnat6_response rnat6Response = new rnat6.rnat6_response();
      rnat6.rnat6_response resource = (rnat6.rnat6_response) service.get_payload_formatter().string_to_resource(rnat6Response.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.rnat6;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, rnat6 resource) => new rnat6()
    {
      name = resource.name,
      network = resource.network,
      acl6name = resource.acl6name,
      redirectport = resource.redirectport,
      td = resource.td,
      srcippersistency = resource.srcippersistency
    }.add_resource(client);

    public static base_responses add(nitro_service client, rnat6[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        rnat6[] rnat6Array = new rnat6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          rnat6Array[index] = new rnat6();
          rnat6Array[index].name = resources[index].name;
          rnat6Array[index].network = resources[index].network;
          rnat6Array[index].acl6name = resources[index].acl6name;
          rnat6Array[index].redirectport = resources[index].redirectport;
          rnat6Array[index].td = resources[index].td;
          rnat6Array[index].srcippersistency = resources[index].srcippersistency;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) rnat6Array);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, rnat6 resource) => new rnat6()
    {
      name = resource.name,
      redirectport = resource.redirectport,
      srcippersistency = resource.srcippersistency
    }.update_resource(client);

    public static base_responses update(nitro_service client, rnat6[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        rnat6[] rnat6Array = new rnat6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          rnat6Array[index] = new rnat6();
          rnat6Array[index].name = resources[index].name;
          rnat6Array[index].redirectport = resources[index].redirectport;
          rnat6Array[index].srcippersistency = resources[index].srcippersistency;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) rnat6Array);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new rnat6() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      rnat6 resource,
      string[] args)
    {
      return new rnat6() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        rnat6[] rnat6Array = new rnat6[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          rnat6Array[index] = new rnat6();
          rnat6Array[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) rnat6Array, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      rnat6[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        rnat6[] rnat6Array = new rnat6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          rnat6Array[index] = new rnat6();
          rnat6Array[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) rnat6Array, args);
      }
      return baseResponses;
    }

    public static base_response clear(nitro_service client, rnat6 resource) => new rnat6()
    {
      name = resource.name
    }.perform_operation_byaction(client, nameof (clear));

    public static base_responses clear(nitro_service client, rnat6[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        rnat6[] rnat6Array = new rnat6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          rnat6Array[index] = new rnat6();
          rnat6Array[index].name = resources[index].name;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) rnat6Array, nameof (clear));
      }
      return baseResponses;
    }

    public static rnat6[] get(nitro_service service) => (rnat6[]) new rnat6().get_resources(service, (options) null);

    public static rnat6[] get(nitro_service service, options option) => (rnat6[]) new rnat6().get_resources(service, option);

    public static rnat6 get(nitro_service service, string name) => (rnat6) new rnat6()
    {
      name = name
    }.get_resource(service);

    public static rnat6[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (rnat6[]) null;
      rnat6[] rnat6Array1 = new rnat6[name.Length];
      rnat6[] rnat6Array2 = new rnat6[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        rnat6Array2[index] = new rnat6();
        rnat6Array2[index].name = name[index];
        rnat6Array1[index] = (rnat6) rnat6Array2[index].get_resource(service);
      }
      return rnat6Array1;
    }

    public static rnat6[] get_filtered(nitro_service service, string filter)
    {
      rnat6 rnat6 = new rnat6();
      options option = new options();
      option.set_filter(filter);
      return (rnat6[]) rnat6.getfiltered(service, option);
    }

    public static rnat6[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      rnat6 rnat6 = new rnat6();
      options option = new options();
      option.set_filter(filter);
      return (rnat6[]) rnat6.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      rnat6 rnat6 = new rnat6();
      options option = new options();
      option.set_count(true);
      rnat6[] resources = (rnat6[]) rnat6.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      rnat6 rnat6 = new rnat6();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      rnat6[] rnat6Array = (rnat6[]) rnat6.getfiltered(service, option);
      return rnat6Array != null && rnat6Array.Length > 0 ? rnat6Array[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      rnat6 rnat6 = new rnat6();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      rnat6[] rnat6Array = (rnat6[]) rnat6.getfiltered(service, option);
      return rnat6Array != null && rnat6Array.Length > 0 ? rnat6Array[0].__count.Value : 0U;
    }

    private class rnat6_response : base_response
    {
      public rnat6[] rnat6 = (rnat6[]) null;
    }

    public static class srcippersistencyEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
