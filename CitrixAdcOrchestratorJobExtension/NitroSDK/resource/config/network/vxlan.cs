// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.vxlan
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class vxlan : base_resource
  {
    private uint? idField = new uint?();
    private uint? vlanField = new uint?();
    private ushort? portField = new ushort?();
    private string dynamicroutingField = (string) null;
    private string ipv6dynamicroutingField = (string) null;
    private uint? tdField = new uint?();
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

    public uint? vlan
    {
      get => this.vlanField;
      set => this.vlanField = value;
    }

    public ushort? port
    {
      get => this.portField;
      set => this.portField = value;
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

    public uint? td
    {
      get => this.tdField;
      private set => this.tdField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vxlan.vxlan_response vxlanResponse = new vxlan.vxlan_response();
      vxlan.vxlan_response resource = (vxlan.vxlan_response) service.get_payload_formatter().string_to_resource(vxlanResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vxlan;
    }

    internal override string get_object_name() => this.id.HasValue ? this.id.ToString() : (string) null;

    public static base_response add(nitro_service client, vxlan resource) => new vxlan()
    {
      id = resource.id,
      vlan = resource.vlan,
      port = resource.port,
      dynamicrouting = resource.dynamicrouting,
      ipv6dynamicrouting = resource.ipv6dynamicrouting
    }.add_resource(client);

    public static base_responses add(nitro_service client, vxlan[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vxlan[] vxlanArray = new vxlan[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vxlanArray[index] = new vxlan();
          vxlanArray[index].id = resources[index].id;
          vxlanArray[index].vlan = resources[index].vlan;
          vxlanArray[index].port = resources[index].port;
          vxlanArray[index].dynamicrouting = resources[index].dynamicrouting;
          vxlanArray[index].ipv6dynamicrouting = resources[index].ipv6dynamicrouting;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) vxlanArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, uint? id) => new vxlan()
    {
      id = id
    }.delete_resource(client);

    public static base_response delete(nitro_service client, vxlan resource) => new vxlan()
    {
      id = resource.id
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, uint?[] id)
    {
      base_responses baseResponses = (base_responses) null;
      if (id != null && id.Length > 0)
      {
        vxlan[] vxlanArray = new vxlan[id.Length];
        for (int index = 0; index < id.Length; ++index)
        {
          vxlanArray[index] = new vxlan();
          vxlanArray[index].id = id[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vxlanArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, vxlan[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vxlan[] vxlanArray = new vxlan[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vxlanArray[index] = new vxlan();
          vxlanArray[index].id = resources[index].id;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vxlanArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, vxlan resource) => new vxlan()
    {
      id = resource.id,
      vlan = resource.vlan,
      port = resource.port,
      dynamicrouting = resource.dynamicrouting,
      ipv6dynamicrouting = resource.ipv6dynamicrouting
    }.update_resource(client);

    public static base_responses update(nitro_service client, vxlan[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vxlan[] vxlanArray = new vxlan[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vxlanArray[index] = new vxlan();
          vxlanArray[index].id = resources[index].id;
          vxlanArray[index].vlan = resources[index].vlan;
          vxlanArray[index].port = resources[index].port;
          vxlanArray[index].dynamicrouting = resources[index].dynamicrouting;
          vxlanArray[index].ipv6dynamicrouting = resources[index].ipv6dynamicrouting;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) vxlanArray);
      }
      return baseResponses;
    }

    public static base_response unset(nitro_service client, uint? id, string[] args) => new vxlan()
    {
      id = id
    }.unset_resource(client, args);

    public static base_response unset(
      nitro_service client,
      vxlan resource,
      string[] args)
    {
      return new vxlan() { id = resource.id }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      uint?[] id,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (id != null && id.Length > 0)
      {
        vxlan[] vxlanArray = new vxlan[id.Length];
        for (int index = 0; index < id.Length; ++index)
        {
          vxlanArray[index] = new vxlan();
          vxlanArray[index].id = id[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) vxlanArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      vxlan[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vxlan[] vxlanArray = new vxlan[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vxlanArray[index] = new vxlan();
          vxlanArray[index].id = resources[index].id;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) vxlanArray, args);
      }
      return baseResponses;
    }

    public static vxlan[] get(nitro_service service) => (vxlan[]) new vxlan().get_resources(service, (options) null);

    public static vxlan[] get(nitro_service service, options option) => (vxlan[]) new vxlan().get_resources(service, option);

    public static vxlan get(nitro_service service, uint? id) => (vxlan) new vxlan()
    {
      id = id
    }.get_resource(service);

    public static vxlan[] get(nitro_service service, uint?[] id)
    {
      if (id == null || id.Length <= 0)
        return (vxlan[]) null;
      vxlan[] vxlanArray1 = new vxlan[id.Length];
      vxlan[] vxlanArray2 = new vxlan[id.Length];
      for (int index = 0; index < id.Length; ++index)
      {
        vxlanArray2[index] = new vxlan();
        vxlanArray2[index].id = id[index];
        vxlanArray1[index] = (vxlan) vxlanArray2[index].get_resource(service);
      }
      return vxlanArray1;
    }

    public static vxlan[] get_filtered(nitro_service service, string filter)
    {
      vxlan vxlan = new vxlan();
      options option = new options();
      option.set_filter(filter);
      return (vxlan[]) vxlan.getfiltered(service, option);
    }

    public static vxlan[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      vxlan vxlan = new vxlan();
      options option = new options();
      option.set_filter(filter);
      return (vxlan[]) vxlan.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      vxlan vxlan = new vxlan();
      options option = new options();
      option.set_count(true);
      vxlan[] resources = (vxlan[]) vxlan.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      vxlan vxlan = new vxlan();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vxlan[] vxlanArray = (vxlan[]) vxlan.getfiltered(service, option);
      return vxlanArray != null && vxlanArray.Length > 0 ? vxlanArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      vxlan vxlan = new vxlan();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vxlan[] vxlanArray = (vxlan[]) vxlan.getfiltered(service, option);
      return vxlanArray != null && vxlanArray.Length > 0 ? vxlanArray[0].__count.Value : 0U;
    }

    private class vxlan_response : base_response
    {
      public vxlan[] vxlan = (vxlan[]) null;
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
