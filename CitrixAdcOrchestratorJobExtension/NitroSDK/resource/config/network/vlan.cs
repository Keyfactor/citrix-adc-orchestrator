// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.vlan
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class vlan : base_resource
  {
    private uint? idField = new uint?();
    private string aliasnameField = (string) null;
    private string dynamicroutingField = (string) null;
    private string ipv6dynamicroutingField = (string) null;
    private uint? mtuField = new uint?();
    private string linklocalipv6addrField = (string) null;
    private bool? rnatField = new bool?();
    private long? portbitmapField = new long?();
    private uint? lsbitmapField = new uint?();
    private long? tagbitmapField = new long?();
    private uint? lstagbitmapField = new uint?();
    private string ifacesField = (string) null;
    private string tagifacesField = (string) null;
    private string ifnumField = (string) null;
    private bool? taggedField = new bool?();
    private uint? vlantdField = new uint?();
    private string sdxvlanField = (string) null;
    private string partitionnameField = (string) null;
    private uint? vxlanField = new uint?();
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

    public string aliasname
    {
      get => this.aliasnameField;
      set => this.aliasnameField = value;
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

    public uint? mtu
    {
      get => this.mtuField;
      set => this.mtuField = value;
    }

    public string linklocalipv6addr
    {
      get => this.linklocalipv6addrField;
      private set => this.linklocalipv6addrField = value;
    }

    public bool? rnat
    {
      get => this.rnatField;
      private set => this.rnatField = value;
    }

    public long? portbitmap
    {
      get => this.portbitmapField;
      private set => this.portbitmapField = value;
    }

    public uint? lsbitmap
    {
      get => this.lsbitmapField;
      private set => this.lsbitmapField = value;
    }

    public long? tagbitmap
    {
      get => this.tagbitmapField;
      private set => this.tagbitmapField = value;
    }

    public uint? lstagbitmap
    {
      get => this.lstagbitmapField;
      private set => this.lstagbitmapField = value;
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

    public string ifnum
    {
      get => this.ifnumField;
      private set => this.ifnumField = value;
    }

    public bool? tagged
    {
      get => this.taggedField;
      private set => this.taggedField = value;
    }

    public uint? vlantd
    {
      get => this.vlantdField;
      private set => this.vlantdField = value;
    }

    public string sdxvlan
    {
      get => this.sdxvlanField;
      private set => this.sdxvlanField = value;
    }

    public string partitionname
    {
      get => this.partitionnameField;
      private set => this.partitionnameField = value;
    }

    public uint? vxlan
    {
      get => this.vxlanField;
      private set => this.vxlanField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vlan.vlan_response vlanResponse = new vlan.vlan_response();
      vlan.vlan_response resource = (vlan.vlan_response) service.get_payload_formatter().string_to_resource(vlanResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vlan;
    }

    internal override string get_object_name() => this.id.HasValue ? this.id.ToString() : (string) null;

    public static base_response add(nitro_service client, vlan resource) => new vlan()
    {
      id = resource.id,
      aliasname = resource.aliasname,
      dynamicrouting = resource.dynamicrouting,
      ipv6dynamicrouting = resource.ipv6dynamicrouting,
      mtu = resource.mtu
    }.add_resource(client);

    public static base_responses add(nitro_service client, vlan[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vlan[] vlanArray = new vlan[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vlanArray[index] = new vlan();
          vlanArray[index].id = resources[index].id;
          vlanArray[index].aliasname = resources[index].aliasname;
          vlanArray[index].dynamicrouting = resources[index].dynamicrouting;
          vlanArray[index].ipv6dynamicrouting = resources[index].ipv6dynamicrouting;
          vlanArray[index].mtu = resources[index].mtu;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) vlanArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, uint? id) => new vlan()
    {
      id = id
    }.delete_resource(client);

    public static base_response delete(nitro_service client, vlan resource) => new vlan()
    {
      id = resource.id
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, uint?[] id)
    {
      base_responses baseResponses = (base_responses) null;
      if (id != null && id.Length > 0)
      {
        vlan[] vlanArray = new vlan[id.Length];
        for (int index = 0; index < id.Length; ++index)
        {
          vlanArray[index] = new vlan();
          vlanArray[index].id = id[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vlanArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, vlan[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vlan[] vlanArray = new vlan[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vlanArray[index] = new vlan();
          vlanArray[index].id = resources[index].id;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vlanArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, vlan resource) => new vlan()
    {
      id = resource.id,
      aliasname = resource.aliasname,
      dynamicrouting = resource.dynamicrouting,
      ipv6dynamicrouting = resource.ipv6dynamicrouting,
      mtu = resource.mtu
    }.update_resource(client);

    public static base_responses update(nitro_service client, vlan[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vlan[] vlanArray = new vlan[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vlanArray[index] = new vlan();
          vlanArray[index].id = resources[index].id;
          vlanArray[index].aliasname = resources[index].aliasname;
          vlanArray[index].dynamicrouting = resources[index].dynamicrouting;
          vlanArray[index].ipv6dynamicrouting = resources[index].ipv6dynamicrouting;
          vlanArray[index].mtu = resources[index].mtu;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) vlanArray);
      }
      return baseResponses;
    }

    public static base_response unset(nitro_service client, uint? id, string[] args) => new vlan()
    {
      id = id
    }.unset_resource(client, args);

    public static base_response unset(
      nitro_service client,
      vlan resource,
      string[] args)
    {
      return new vlan() { id = resource.id }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      uint?[] id,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (id != null && id.Length > 0)
      {
        vlan[] vlanArray = new vlan[id.Length];
        for (int index = 0; index < id.Length; ++index)
        {
          vlanArray[index] = new vlan();
          vlanArray[index].id = id[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) vlanArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      vlan[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vlan[] vlanArray = new vlan[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vlanArray[index] = new vlan();
          vlanArray[index].id = resources[index].id;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) vlanArray, args);
      }
      return baseResponses;
    }

    public static vlan[] get(nitro_service service) => (vlan[]) new vlan().get_resources(service, (options) null);

    public static vlan[] get(nitro_service service, options option) => (vlan[]) new vlan().get_resources(service, option);

    public static vlan get(nitro_service service, uint? id) => (vlan) new vlan()
    {
      id = id
    }.get_resource(service);

    public static vlan[] get(nitro_service service, uint?[] id)
    {
      if (id == null || id.Length <= 0)
        return (vlan[]) null;
      vlan[] vlanArray1 = new vlan[id.Length];
      vlan[] vlanArray2 = new vlan[id.Length];
      for (int index = 0; index < id.Length; ++index)
      {
        vlanArray2[index] = new vlan();
        vlanArray2[index].id = id[index];
        vlanArray1[index] = (vlan) vlanArray2[index].get_resource(service);
      }
      return vlanArray1;
    }

    public static vlan[] get_filtered(nitro_service service, string filter)
    {
      vlan vlan = new vlan();
      options option = new options();
      option.set_filter(filter);
      return (vlan[]) vlan.getfiltered(service, option);
    }

    public static vlan[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      vlan vlan = new vlan();
      options option = new options();
      option.set_filter(filter);
      return (vlan[]) vlan.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      vlan vlan = new vlan();
      options option = new options();
      option.set_count(true);
      vlan[] resources = (vlan[]) vlan.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      vlan vlan = new vlan();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vlan[] vlanArray = (vlan[]) vlan.getfiltered(service, option);
      return vlanArray != null && vlanArray.Length > 0 ? vlanArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      vlan vlan = new vlan();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vlan[] vlanArray = (vlan[]) vlan.getfiltered(service, option);
      return vlanArray != null && vlanArray.Length > 0 ? vlanArray[0].__count.Value : 0U;
    }

    private class vlan_response : base_response
    {
      public vlan[] vlan = (vlan[]) null;
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

    public static class sdxvlanEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }
  }
}
