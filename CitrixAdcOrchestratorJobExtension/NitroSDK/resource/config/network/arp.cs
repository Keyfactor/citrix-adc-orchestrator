// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.arp
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class arp : base_resource
  {
    private string ipaddressField = (string) null;
    private uint? tdField = new uint?();
    private string macField = (string) null;
    private string ifnumField = (string) null;
    private uint? vxlanField = new uint?();
    private string vtepField = (string) null;
    private uint? vlanField = new uint?();
    private uint? ownernodeField = new uint?();
    private bool? allField = new bool?();
    private uint? timeoutField = new uint?();
    private uint? stateField = new uint?();
    private uint? flagsField = new uint?();
    private string typeField = (string) null;
    private uint? channelField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string ipaddress
    {
      get => this.ipaddressField;
      set => this.ipaddressField = value;
    }

    public uint? td
    {
      get => this.tdField;
      set => this.tdField = value;
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

    public uint? vlan
    {
      get => this.vlanField;
      set => this.vlanField = value;
    }

    public uint? ownernode
    {
      get => this.ownernodeField;
      set => this.ownernodeField = value;
    }

    public bool? all
    {
      get => this.allField;
      set => this.allField = value;
    }

    public uint? timeout
    {
      get => this.timeoutField;
      private set => this.timeoutField = value;
    }

    public uint? state
    {
      get => this.stateField;
      private set => this.stateField = value;
    }

    public uint? flags
    {
      get => this.flagsField;
      private set => this.flagsField = value;
    }

    public string type
    {
      get => this.typeField;
      private set => this.typeField = value;
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
      arp.arp_response arpResponse = new arp.arp_response();
      arp.arp_response resource = (arp.arp_response) service.get_payload_formatter().string_to_resource(arpResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.arp;
    }

    internal override string get_object_name() => this.ipaddress;

    public static base_response add(nitro_service client, arp resource) => new arp()
    {
      ipaddress = resource.ipaddress,
      td = resource.td,
      mac = resource.mac,
      ifnum = resource.ifnum,
      vxlan = resource.vxlan,
      vtep = resource.vtep,
      vlan = resource.vlan,
      ownernode = resource.ownernode
    }.add_resource(client);

    public static base_responses add(nitro_service client, arp[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        arp[] arpArray = new arp[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          arpArray[index] = new arp();
          arpArray[index].ipaddress = resources[index].ipaddress;
          arpArray[index].td = resources[index].td;
          arpArray[index].mac = resources[index].mac;
          arpArray[index].ifnum = resources[index].ifnum;
          arpArray[index].vxlan = resources[index].vxlan;
          arpArray[index].vtep = resources[index].vtep;
          arpArray[index].vlan = resources[index].vlan;
          arpArray[index].ownernode = resources[index].ownernode;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) arpArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string ipaddress) => new arp()
    {
      ipaddress = ipaddress
    }.delete_resource(client);

    public static base_response delete(nitro_service client, arp resource) => new arp()
    {
      ipaddress = resource.ipaddress,
      td = resource.td,
      all = resource.all,
      ownernode = resource.ownernode
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] ipaddress)
    {
      base_responses baseResponses = (base_responses) null;
      if (ipaddress != null && ipaddress.Length > 0)
      {
        arp[] arpArray = new arp[ipaddress.Length];
        for (int index = 0; index < ipaddress.Length; ++index)
        {
          arpArray[index] = new arp();
          arpArray[index].ipaddress = ipaddress[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) arpArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, arp[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        arp[] arpArray = new arp[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          arpArray[index] = new arp();
          arpArray[index].ipaddress = resources[index].ipaddress;
          arpArray[index].td = resources[index].td;
          arpArray[index].all = resources[index].all;
          arpArray[index].ownernode = resources[index].ownernode;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) arpArray);
      }
      return baseResponses;
    }

    public static base_response send(nitro_service client, arp resource) => new arp()
    {
      ipaddress = resource.ipaddress,
      td = resource.td,
      all = resource.all
    }.perform_operation_byaction(client, nameof (send));

    public static base_responses send(nitro_service client, arp[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        arp[] arpArray = new arp[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          arpArray[index] = new arp();
          arpArray[index].ipaddress = resources[index].ipaddress;
          arpArray[index].td = resources[index].td;
          arpArray[index].all = resources[index].all;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) arpArray, nameof (send));
      }
      return baseResponses;
    }

    public static arp[] get(nitro_service service) => (arp[]) new arp().get_resources(service, (options) null);

    public static arp[] get(nitro_service service, options option) => (arp[]) new arp().get_resources(service, option);

    public static arp get(nitro_service service, arp obj)
    {
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (arp) obj.get_resource(service, option);
    }

    public static arp[] get(nitro_service service, arp[] obj)
    {
      if (obj == null || obj.Length <= 0)
        return (arp[]) null;
      arp[] arpArray = new arp[obj.Length];
      for (int index = 0; index < obj.Length; ++index)
      {
        options option = new options();
        option.set_args(nitro_util.object_to_string_withoutquotes((object) obj[index]));
        arpArray[index] = (arp) obj[index].get_resource(service, option);
      }
      return arpArray;
    }

    public static arp[] get_filtered(nitro_service service, string filter)
    {
      arp arp = new arp();
      options option = new options();
      option.set_filter(filter);
      return (arp[]) arp.getfiltered(service, option);
    }

    public static arp[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      arp arp = new arp();
      options option = new options();
      option.set_filter(filter);
      return (arp[]) arp.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      arp arp = new arp();
      options option = new options();
      option.set_count(true);
      arp[] resources = (arp[]) arp.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      arp arp = new arp();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      arp[] arpArray = (arp[]) arp.getfiltered(service, option);
      return arpArray != null && arpArray.Length > 0 ? arpArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      arp arp = new arp();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      arp[] arpArray = (arp[]) arp.getfiltered(service, option);
      return arpArray != null && arpArray.Length > 0 ? arpArray[0].__count.Value : 0U;
    }

    private class arp_response : base_response
    {
      public arp[] arp = (arp[]) null;
    }

    public static class typeEnum
    {
      public const string STATIC = "STATIC";
      public const string PERMANENT = "PERMANENT";
      public const string DYNAMIC = "DYNAMIC";
    }
  }
}
