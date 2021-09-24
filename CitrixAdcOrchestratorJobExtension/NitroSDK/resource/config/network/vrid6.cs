// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.vrid6
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class vrid6 : base_resource
  {
    private uint? idField = new uint?();
    private bool? allField = new bool?();
    private string ifacesField = (string) null;
    private string ifnumField = (string) null;
    private string typeField = (string) null;
    private uint? priorityField = new uint?();
    private uint? stateField = new uint?();
    private uint? flagsField = new uint?();
    private string ipaddressField = (string) null;
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

    public bool? all
    {
      get => this.allField;
      set => this.allField = value;
    }

    public string ifaces
    {
      get => this.ifacesField;
      private set => this.ifacesField = value;
    }

    public string ifnum
    {
      get => this.ifnumField;
      private set => this.ifnumField = value;
    }

    public string type
    {
      get => this.typeField;
      private set => this.typeField = value;
    }

    public uint? priority
    {
      get => this.priorityField;
      private set => this.priorityField = value;
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

    public string ipaddress
    {
      get => this.ipaddressField;
      private set => this.ipaddressField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vrid6.vrid6_response vrid6Response = new vrid6.vrid6_response();
      vrid6.vrid6_response resource = (vrid6.vrid6_response) service.get_payload_formatter().string_to_resource(vrid6Response.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vrid6;
    }

    internal override string get_object_name() => this.id.HasValue ? this.id.ToString() : (string) null;

    public static base_response add(nitro_service client, vrid6 resource) => new vrid6()
    {
      id = resource.id
    }.add_resource(client);

    public static base_responses add(nitro_service client, vrid6[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vrid6[] vrid6Array = new vrid6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vrid6Array[index] = new vrid6();
          vrid6Array[index].id = resources[index].id;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) vrid6Array);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, uint? id) => new vrid6()
    {
      id = id
    }.delete_resource(client);

    public static base_response delete(nitro_service client, vrid6 resource) => new vrid6()
    {
      id = resource.id,
      all = resource.all
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, uint?[] id)
    {
      base_responses baseResponses = (base_responses) null;
      if (id != null && id.Length > 0)
      {
        vrid6[] vrid6Array = new vrid6[id.Length];
        for (int index = 0; index < id.Length; ++index)
        {
          vrid6Array[index] = new vrid6();
          vrid6Array[index].id = id[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vrid6Array);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, vrid6[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vrid6[] vrid6Array = new vrid6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vrid6Array[index] = new vrid6();
          vrid6Array[index].id = resources[index].id;
          vrid6Array[index].all = resources[index].all;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vrid6Array);
      }
      return baseResponses;
    }

    public static vrid6[] get(nitro_service service) => (vrid6[]) new vrid6().get_resources(service, (options) null);

    public static vrid6[] get(nitro_service service, options option) => (vrid6[]) new vrid6().get_resources(service, option);

    public static vrid6 get(nitro_service service, uint? id) => (vrid6) new vrid6()
    {
      id = id
    }.get_resource(service);

    public static vrid6[] get(nitro_service service, uint?[] id)
    {
      if (id == null || id.Length <= 0)
        return (vrid6[]) null;
      vrid6[] vrid6Array1 = new vrid6[id.Length];
      vrid6[] vrid6Array2 = new vrid6[id.Length];
      for (int index = 0; index < id.Length; ++index)
      {
        vrid6Array2[index] = new vrid6();
        vrid6Array2[index].id = id[index];
        vrid6Array1[index] = (vrid6) vrid6Array2[index].get_resource(service);
      }
      return vrid6Array1;
    }

    public static vrid6[] get_filtered(nitro_service service, string filter)
    {
      vrid6 vrid6 = new vrid6();
      options option = new options();
      option.set_filter(filter);
      return (vrid6[]) vrid6.getfiltered(service, option);
    }

    public static vrid6[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      vrid6 vrid6 = new vrid6();
      options option = new options();
      option.set_filter(filter);
      return (vrid6[]) vrid6.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      vrid6 vrid6 = new vrid6();
      options option = new options();
      option.set_count(true);
      vrid6[] resources = (vrid6[]) vrid6.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      vrid6 vrid6 = new vrid6();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vrid6[] vrid6Array = (vrid6[]) vrid6.getfiltered(service, option);
      return vrid6Array != null && vrid6Array.Length > 0 ? vrid6Array[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      vrid6 vrid6 = new vrid6();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vrid6[] vrid6Array = (vrid6[]) vrid6.getfiltered(service, option);
      return vrid6Array != null && vrid6Array.Length > 0 ? vrid6Array[0].__count.Value : 0U;
    }

    private class vrid6_response : base_response
    {
      public vrid6[] vrid6 = (vrid6[]) null;
    }

    public static class typeEnum
    {
      public const string STATIC = "STATIC";
      public const string DYNAMIC = "DYNAMIC";
    }
  }
}
