// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.nd6
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class nd6 : base_resource
  {
    private string neighborField = (string) null;
    private string macField = (string) null;
    private string ifnumField = (string) null;
    private int? vlanField = new int?();
    private uint? vxlanField = new uint?();
    private string vtepField = (string) null;
    private uint? tdField = new uint?();
    private string stateField = (string) null;
    private uint? timeoutField = new uint?();
    private uint? flagsField = new uint?();
    private uint? channelField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string neighbor
    {
      get => this.neighborField;
      set => this.neighborField = value;
    }

    public string mac
    {
      get => this.macField;
      set => this.macField = value;
    }

    public string ifnum
    {
      get => this.ifnumField;
      set => this.ifnumField = value;
    }

    public int? vlan
    {
      get => this.vlanField;
      set => this.vlanField = value;
    }

    public uint? vxlan
    {
      get => this.vxlanField;
      set => this.vxlanField = value;
    }

    public string vtep
    {
      get => this.vtepField;
      set => this.vtepField = value;
    }

    public uint? td
    {
      get => this.tdField;
      set => this.tdField = value;
    }

    public string state
    {
      get => this.stateField;
      private set => this.stateField = value;
    }

    public uint? timeout
    {
      get => this.timeoutField;
      private set => this.timeoutField = value;
    }

    public uint? flags
    {
      get => this.flagsField;
      private set => this.flagsField = value;
    }

    public uint? channel
    {
      get => this.channelField;
      private set => this.channelField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nd6.nd6_response nd6Response = new nd6.nd6_response();
      nd6.nd6_response resource = (nd6.nd6_response) service.get_payload_formatter().string_to_resource(nd6Response.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nd6;
    }

    internal override string get_object_name() => this.neighbor;

    public static base_response add(nitro_service client, nd6 resource) => new nd6()
    {
      neighbor = resource.neighbor,
      mac = resource.mac,
      ifnum = resource.ifnum,
      vlan = resource.vlan,
      vxlan = resource.vxlan,
      vtep = resource.vtep,
      td = resource.td
    }.add_resource(client);

    public static base_responses add(nitro_service client, nd6[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nd6[] nd6Array = new nd6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nd6Array[index] = new nd6();
          nd6Array[index].neighbor = resources[index].neighbor;
          nd6Array[index].mac = resources[index].mac;
          nd6Array[index].ifnum = resources[index].ifnum;
          nd6Array[index].vlan = resources[index].vlan;
          nd6Array[index].vxlan = resources[index].vxlan;
          nd6Array[index].vtep = resources[index].vtep;
          nd6Array[index].td = resources[index].td;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) nd6Array);
      }
      return baseResponses;
    }

    public static base_response clear(nitro_service client) => new nd6().perform_operation_byaction(client, nameof (clear));

    public static base_responses clear(nitro_service client, nd6[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nd6[] nd6Array = new nd6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
          nd6Array[index] = new nd6();
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) nd6Array, nameof (clear));
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string neighbor) => new nd6()
    {
      neighbor = neighbor
    }.delete_resource(client);

    public static base_response delete(nitro_service client, nd6 resource) => new nd6()
    {
      neighbor = resource.neighbor,
      vlan = resource.vlan,
      vxlan = resource.vxlan,
      td = resource.td
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] neighbor)
    {
      base_responses baseResponses = (base_responses) null;
      if (neighbor != null && neighbor.Length > 0)
      {
        nd6[] nd6Array = new nd6[neighbor.Length];
        for (int index = 0; index < neighbor.Length; ++index)
        {
          nd6Array[index] = new nd6();
          nd6Array[index].neighbor = neighbor[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nd6Array);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, nd6[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nd6[] nd6Array = new nd6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nd6Array[index] = new nd6();
          nd6Array[index].neighbor = resources[index].neighbor;
          nd6Array[index].vlan = resources[index].vlan;
          nd6Array[index].vxlan = resources[index].vxlan;
          nd6Array[index].td = resources[index].td;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nd6Array);
      }
      return baseResponses;
    }

    public static nd6[] get(nitro_service service) => (nd6[]) new nd6().get_resources(service, (options) null);

    public static nd6[] get(nitro_service service, options option) => (nd6[]) new nd6().get_resources(service, option);

    public static nd6 get(nitro_service service, nd6 obj)
    {
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (nd6) obj.get_resource(service, option);
    }

    public static nd6[] get(nitro_service service, nd6[] obj)
    {
      if (obj == null || obj.Length <= 0)
        return (nd6[]) null;
      nd6[] nd6Array = new nd6[obj.Length];
      for (int index = 0; index < obj.Length; ++index)
      {
        options option = new options();
        option.set_args(nitro_util.object_to_string_withoutquotes((object) obj[index]));
        nd6Array[index] = (nd6) obj[index].get_resource(service, option);
      }
      return nd6Array;
    }

    public static nd6[] get_filtered(nitro_service service, string filter)
    {
      nd6 nd6 = new nd6();
      options option = new options();
      option.set_filter(filter);
      return (nd6[]) nd6.getfiltered(service, option);
    }

    public static nd6[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      nd6 nd6 = new nd6();
      options option = new options();
      option.set_filter(filter);
      return (nd6[]) nd6.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      nd6 nd6 = new nd6();
      options option = new options();
      option.set_count(true);
      nd6[] resources = (nd6[]) nd6.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      nd6 nd6 = new nd6();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nd6[] nd6Array = (nd6[]) nd6.getfiltered(service, option);
      return nd6Array != null && nd6Array.Length > 0 ? nd6Array[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      nd6 nd6 = new nd6();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nd6[] nd6Array = (nd6[]) nd6.getfiltered(service, option);
      return nd6Array != null && nd6Array.Length > 0 ? nd6Array[0].__count.Value : 0U;
    }

    private class nd6_response : base_response
    {
      public nd6[] nd6 = (nd6[]) null;
    }

    public static class stateEnum
    {
      public const string INCOMPLETE = "INCOMPLETE";
      public const string REACHABLE = "REACHABLE";
      public const string STALE = "STALE";
      public const string DELAY = "DELAY";
      public const string PROBE = "PROBE";
    }
  }
}
