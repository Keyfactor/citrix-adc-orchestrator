// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.nat64
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class nat64 : base_resource
  {
    private string nameField = (string) null;
    private string acl6nameField = (string) null;
    private string netprofileField = (string) null;
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

    public string acl6name
    {
      get => this.acl6nameField;
      set => this.acl6nameField = value;
    }

    public string netprofile
    {
      get => this.netprofileField;
      set => this.netprofileField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nat64.nat64_response nat64Response = new nat64.nat64_response();
      nat64.nat64_response resource = (nat64.nat64_response) service.get_payload_formatter().string_to_resource(nat64Response.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nat64;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, nat64 resource) => new nat64()
    {
      name = resource.name,
      acl6name = resource.acl6name,
      netprofile = resource.netprofile
    }.add_resource(client);

    public static base_responses add(nitro_service client, nat64[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nat64[] nat64Array = new nat64[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nat64Array[index] = new nat64();
          nat64Array[index].name = resources[index].name;
          nat64Array[index].acl6name = resources[index].acl6name;
          nat64Array[index].netprofile = resources[index].netprofile;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) nat64Array);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, nat64 resource) => new nat64()
    {
      name = resource.name,
      acl6name = resource.acl6name,
      netprofile = resource.netprofile
    }.update_resource(client);

    public static base_responses update(nitro_service client, nat64[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nat64[] nat64Array = new nat64[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nat64Array[index] = new nat64();
          nat64Array[index].name = resources[index].name;
          nat64Array[index].acl6name = resources[index].acl6name;
          nat64Array[index].netprofile = resources[index].netprofile;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) nat64Array);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new nat64() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      nat64 resource,
      string[] args)
    {
      return new nat64() { name = resource.name }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        nat64[] nat64Array = new nat64[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          nat64Array[index] = new nat64();
          nat64Array[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) nat64Array, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      nat64[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nat64[] nat64Array = new nat64[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nat64Array[index] = new nat64();
          nat64Array[index].name = resources[index].name;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) nat64Array, args);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new nat64()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, nat64 resource) => new nat64()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        nat64[] nat64Array = new nat64[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          nat64Array[index] = new nat64();
          nat64Array[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nat64Array);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, nat64[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nat64[] nat64Array = new nat64[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nat64Array[index] = new nat64();
          nat64Array[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nat64Array);
      }
      return baseResponses;
    }

    public static nat64[] get(nitro_service service) => (nat64[]) new nat64().get_resources(service, (options) null);

    public static nat64[] get(nitro_service service, options option) => (nat64[]) new nat64().get_resources(service, option);

    public static nat64 get(nitro_service service, string name) => (nat64) new nat64()
    {
      name = name
    }.get_resource(service);

    public static nat64[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (nat64[]) null;
      nat64[] nat64Array1 = new nat64[name.Length];
      nat64[] nat64Array2 = new nat64[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        nat64Array2[index] = new nat64();
        nat64Array2[index].name = name[index];
        nat64Array1[index] = (nat64) nat64Array2[index].get_resource(service);
      }
      return nat64Array1;
    }

    public static nat64[] get_filtered(nitro_service service, string filter)
    {
      nat64 nat64 = new nat64();
      options option = new options();
      option.set_filter(filter);
      return (nat64[]) nat64.getfiltered(service, option);
    }

    public static nat64[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      nat64 nat64 = new nat64();
      options option = new options();
      option.set_filter(filter);
      return (nat64[]) nat64.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      nat64 nat64 = new nat64();
      options option = new options();
      option.set_count(true);
      nat64[] resources = (nat64[]) nat64.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      nat64 nat64 = new nat64();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nat64[] nat64Array = (nat64[]) nat64.getfiltered(service, option);
      return nat64Array != null && nat64Array.Length > 0 ? nat64Array[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      nat64 nat64 = new nat64();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nat64[] nat64Array = (nat64[]) nat64.getfiltered(service, option);
      return nat64Array != null && nat64Array.Length > 0 ? nat64Array[0].__count.Value : 0U;
    }

    private class nat64_response : base_response
    {
      public nat64[] nat64 = (nat64[]) null;
    }
  }
}
