// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.bridgetable
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class bridgetable : base_resource
  {
    private uint? bridgeageField = new uint?();
    private uint? vlanField = new uint?();
    private string ifnumField = (string) null;
    private uint? vxlanField = new uint?();
    private string macField = (string) null;
    private string vtepField = (string) null;
    private uint? flagsField = new uint?();
    private uint? channelField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public uint? bridgeage
    {
      get => this.bridgeageField;
      set => this.bridgeageField = value;
    }

    public uint? vlan
    {
      get => this.vlanField;
      set => this.vlanField = value;
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

    public string mac
    {
      get => this.macField;
      private set => this.macField = value;
    }

    public string vtep
    {
      get => this.vtepField;
      private set => this.vtepField = value;
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
      bridgetable.bridgetable_response bridgetableResponse = new bridgetable.bridgetable_response();
      bridgetable.bridgetable_response resource = (bridgetable.bridgetable_response) service.get_payload_formatter().string_to_resource(bridgetableResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.bridgetable;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, bridgetable resource) => new bridgetable()
    {
      bridgeage = resource.bridgeage
    }.update_resource(client);

    public static base_responses update(nitro_service client, bridgetable[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        bridgetable[] bridgetableArray = new bridgetable[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          bridgetableArray[index] = new bridgetable();
          bridgetableArray[index].bridgeage = resources[index].bridgeage;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) bridgetableArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      bridgetable resource,
      string[] args)
    {
      return new bridgetable().unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      bridgetable[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        bridgetable[] bridgetableArray = new bridgetable[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
          bridgetableArray[index] = new bridgetable();
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) bridgetableArray, args);
      }
      return baseResponses;
    }

    public static base_response clear(nitro_service client, bridgetable resource) => new bridgetable()
    {
      vlan = resource.vlan,
      ifnum = resource.ifnum,
      vxlan = resource.vxlan
    }.perform_operation_byaction(client, nameof (clear));

    public static base_responses clear(nitro_service client, bridgetable[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        bridgetable[] bridgetableArray = new bridgetable[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          bridgetableArray[index] = new bridgetable();
          bridgetableArray[index].vlan = resources[index].vlan;
          bridgetableArray[index].ifnum = resources[index].ifnum;
          bridgetableArray[index].vxlan = resources[index].vxlan;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) bridgetableArray, nameof (clear));
      }
      return baseResponses;
    }

    public static bridgetable[] get(nitro_service service) => (bridgetable[]) new bridgetable().get_resources(service, (options) null);

    public static bridgetable[] get(nitro_service service, options option) => (bridgetable[]) new bridgetable().get_resources(service, option);

    public static bridgetable[] get_filtered(nitro_service service, string filter)
    {
      bridgetable bridgetable = new bridgetable();
      options option = new options();
      option.set_filter(filter);
      return (bridgetable[]) bridgetable.getfiltered(service, option);
    }

    public static bridgetable[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      bridgetable bridgetable = new bridgetable();
      options option = new options();
      option.set_filter(filter);
      return (bridgetable[]) bridgetable.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      bridgetable bridgetable = new bridgetable();
      options option = new options();
      option.set_count(true);
      bridgetable[] resources = (bridgetable[]) bridgetable.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      bridgetable bridgetable = new bridgetable();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      bridgetable[] bridgetableArray = (bridgetable[]) bridgetable.getfiltered(service, option);
      return bridgetableArray != null && bridgetableArray.Length > 0 ? bridgetableArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      bridgetable bridgetable = new bridgetable();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      bridgetable[] bridgetableArray = (bridgetable[]) bridgetable.getfiltered(service, option);
      return bridgetableArray != null && bridgetableArray.Length > 0 ? bridgetableArray[0].__count.Value : 0U;
    }

    private class bridgetable_response : base_response
    {
      public bridgetable[] bridgetable = (bridgetable[]) null;
    }
  }
}
