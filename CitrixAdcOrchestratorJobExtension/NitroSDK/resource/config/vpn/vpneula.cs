// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.vpn.vpneula
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.vpn
{
  public class vpneula : base_resource
  {
    private string nameField = (string) null;
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

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vpneula.vpneula_response vpneulaResponse = new vpneula.vpneula_response();
      vpneula.vpneula_response resource = (vpneula.vpneula_response) service.get_payload_formatter().string_to_resource(vpneulaResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vpneula;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, vpneula resource) => new vpneula()
    {
      name = resource.name
    }.add_resource(client);

    public static base_responses add(nitro_service client, vpneula[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpneula[] vpneulaArray = new vpneula[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpneulaArray[index] = new vpneula();
          vpneulaArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) vpneulaArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new vpneula()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, vpneula resource) => new vpneula()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        vpneula[] vpneulaArray = new vpneula[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          vpneulaArray[index] = new vpneula();
          vpneulaArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vpneulaArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, vpneula[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpneula[] vpneulaArray = new vpneula[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpneulaArray[index] = new vpneula();
          vpneulaArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vpneulaArray);
      }
      return baseResponses;
    }

    public static vpneula[] get(nitro_service service) => (vpneula[]) new vpneula().get_resources(service, (options) null);

    public static vpneula[] get(nitro_service service, options option) => (vpneula[]) new vpneula().get_resources(service, option);

    public static vpneula get(nitro_service service, string name) => (vpneula) new vpneula()
    {
      name = name
    }.get_resource(service);

    public static vpneula[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (vpneula[]) null;
      vpneula[] vpneulaArray1 = new vpneula[name.Length];
      vpneula[] vpneulaArray2 = new vpneula[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        vpneulaArray2[index] = new vpneula();
        vpneulaArray2[index].name = name[index];
        vpneulaArray1[index] = (vpneula) vpneulaArray2[index].get_resource(service);
      }
      return vpneulaArray1;
    }

    public static vpneula[] get_filtered(nitro_service service, string filter)
    {
      vpneula vpneula = new vpneula();
      options option = new options();
      option.set_filter(filter);
      return (vpneula[]) vpneula.getfiltered(service, option);
    }

    public static vpneula[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      vpneula vpneula = new vpneula();
      options option = new options();
      option.set_filter(filter);
      return (vpneula[]) vpneula.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      vpneula vpneula = new vpneula();
      options option = new options();
      option.set_count(true);
      vpneula[] resources = (vpneula[]) vpneula.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      vpneula vpneula = new vpneula();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpneula[] vpneulaArray = (vpneula[]) vpneula.getfiltered(service, option);
      return vpneulaArray != null && vpneulaArray.Length > 0 ? vpneulaArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      vpneula vpneula = new vpneula();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpneula[] vpneulaArray = (vpneula[]) vpneula.getfiltered(service, option);
      return vpneulaArray != null && vpneulaArray.Length > 0 ? vpneulaArray[0].__count.Value : 0U;
    }

    private class vpneula_response : base_response
    {
      public vpneula[] vpneula = (vpneula[]) null;
    }
  }
}
