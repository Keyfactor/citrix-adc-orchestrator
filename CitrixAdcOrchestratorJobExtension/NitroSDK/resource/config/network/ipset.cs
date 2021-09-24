// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.ipset
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class ipset : base_resource
  {
    private string nameField = (string) null;
    private uint? tdField = new uint?();
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

    public uint? td
    {
      get => this.tdField;
      set => this.tdField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      ipset.ipset_response ipsetResponse = new ipset.ipset_response();
      ipset.ipset_response resource = (ipset.ipset_response) service.get_payload_formatter().string_to_resource(ipsetResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.ipset;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, ipset resource) => new ipset()
    {
      name = resource.name,
      td = resource.td
    }.add_resource(client);

    public static base_responses add(nitro_service client, ipset[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        ipset[] ipsetArray = new ipset[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          ipsetArray[index] = new ipset();
          ipsetArray[index].name = resources[index].name;
          ipsetArray[index].td = resources[index].td;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) ipsetArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new ipset()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, ipset resource) => new ipset()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        ipset[] ipsetArray = new ipset[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          ipsetArray[index] = new ipset();
          ipsetArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) ipsetArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, ipset[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        ipset[] ipsetArray = new ipset[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          ipsetArray[index] = new ipset();
          ipsetArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) ipsetArray);
      }
      return baseResponses;
    }

    public static ipset[] get(nitro_service service) => (ipset[]) new ipset().get_resources(service, (options) null);

    public static ipset[] get(nitro_service service, options option) => (ipset[]) new ipset().get_resources(service, option);

    public static ipset get(nitro_service service, string name) => (ipset) new ipset()
    {
      name = name
    }.get_resource(service);

    public static ipset[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (ipset[]) null;
      ipset[] ipsetArray1 = new ipset[name.Length];
      ipset[] ipsetArray2 = new ipset[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        ipsetArray2[index] = new ipset();
        ipsetArray2[index].name = name[index];
        ipsetArray1[index] = (ipset) ipsetArray2[index].get_resource(service);
      }
      return ipsetArray1;
    }

    public static ipset[] get_filtered(nitro_service service, string filter)
    {
      ipset ipset = new ipset();
      options option = new options();
      option.set_filter(filter);
      return (ipset[]) ipset.getfiltered(service, option);
    }

    public static ipset[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      ipset ipset = new ipset();
      options option = new options();
      option.set_filter(filter);
      return (ipset[]) ipset.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      ipset ipset = new ipset();
      options option = new options();
      option.set_count(true);
      ipset[] resources = (ipset[]) ipset.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      ipset ipset = new ipset();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      ipset[] ipsetArray = (ipset[]) ipset.getfiltered(service, option);
      return ipsetArray != null && ipsetArray.Length > 0 ? ipsetArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      ipset ipset = new ipset();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      ipset[] ipsetArray = (ipset[]) ipset.getfiltered(service, option);
      return ipsetArray != null && ipsetArray.Length > 0 ? ipsetArray[0].__count.Value : 0U;
    }

    private class ipset_response : base_response
    {
      public ipset[] ipset = (ipset[]) null;
    }
  }
}
