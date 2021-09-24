// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nsappflowcollector
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nsappflowcollector : base_resource
  {
    private string nameField = (string) null;
    private string ipaddressField = (string) null;
    private ushort? portField = new ushort?();
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

    public string ipaddress
    {
      get => this.ipaddressField;
      set => this.ipaddressField = value;
    }

    public ushort? port
    {
      get => this.portField;
      set => this.portField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nsappflowcollector.nsappflowcollector_response nsappflowcollectorResponse = new nsappflowcollector.nsappflowcollector_response();
      nsappflowcollector.nsappflowcollector_response resource = (nsappflowcollector.nsappflowcollector_response) service.get_payload_formatter().string_to_resource(nsappflowcollectorResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nsappflowcollector;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, nsappflowcollector resource) => new nsappflowcollector()
    {
      name = resource.name,
      ipaddress = resource.ipaddress,
      port = resource.port
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      nsappflowcollector[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsappflowcollector[] nsappflowcollectorArray = new nsappflowcollector[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsappflowcollectorArray[index] = new nsappflowcollector();
          nsappflowcollectorArray[index].name = resources[index].name;
          nsappflowcollectorArray[index].ipaddress = resources[index].ipaddress;
          nsappflowcollectorArray[index].port = resources[index].port;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) nsappflowcollectorArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new nsappflowcollector()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      nsappflowcollector resource)
    {
      return new nsappflowcollector()
      {
        name = resource.name
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        nsappflowcollector[] nsappflowcollectorArray = new nsappflowcollector[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          nsappflowcollectorArray[index] = new nsappflowcollector();
          nsappflowcollectorArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nsappflowcollectorArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      nsappflowcollector[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nsappflowcollector[] nsappflowcollectorArray = new nsappflowcollector[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nsappflowcollectorArray[index] = new nsappflowcollector();
          nsappflowcollectorArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) nsappflowcollectorArray);
      }
      return baseResponses;
    }

    public static nsappflowcollector[] get(nitro_service service) => (nsappflowcollector[]) new nsappflowcollector().get_resources(service, (options) null);

    public static nsappflowcollector[] get(nitro_service service, options option) => (nsappflowcollector[]) new nsappflowcollector().get_resources(service, option);

    public static nsappflowcollector get(nitro_service service, string name) => (nsappflowcollector) new nsappflowcollector()
    {
      name = name
    }.get_resource(service);

    public static nsappflowcollector[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (nsappflowcollector[]) null;
      nsappflowcollector[] nsappflowcollectorArray1 = new nsappflowcollector[name.Length];
      nsappflowcollector[] nsappflowcollectorArray2 = new nsappflowcollector[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        nsappflowcollectorArray2[index] = new nsappflowcollector();
        nsappflowcollectorArray2[index].name = name[index];
        nsappflowcollectorArray1[index] = (nsappflowcollector) nsappflowcollectorArray2[index].get_resource(service);
      }
      return nsappflowcollectorArray1;
    }

    public static nsappflowcollector[] get_filtered(
      nitro_service service,
      string filter)
    {
      nsappflowcollector nsappflowcollector = new nsappflowcollector();
      options option = new options();
      option.set_filter(filter);
      return (nsappflowcollector[]) nsappflowcollector.getfiltered(service, option);
    }

    public static nsappflowcollector[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      nsappflowcollector nsappflowcollector = new nsappflowcollector();
      options option = new options();
      option.set_filter(filter);
      return (nsappflowcollector[]) nsappflowcollector.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      nsappflowcollector nsappflowcollector = new nsappflowcollector();
      options option = new options();
      option.set_count(true);
      nsappflowcollector[] resources = (nsappflowcollector[]) nsappflowcollector.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      nsappflowcollector nsappflowcollector = new nsappflowcollector();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nsappflowcollector[] nsappflowcollectorArray = (nsappflowcollector[]) nsappflowcollector.getfiltered(service, option);
      return nsappflowcollectorArray != null && nsappflowcollectorArray.Length > 0 ? nsappflowcollectorArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      nsappflowcollector nsappflowcollector = new nsappflowcollector();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nsappflowcollector[] nsappflowcollectorArray = (nsappflowcollector[]) nsappflowcollector.getfiltered(service, option);
      return nsappflowcollectorArray != null && nsappflowcollectorArray.Length > 0 ? nsappflowcollectorArray[0].__count.Value : 0U;
    }

    private class nsappflowcollector_response : base_response
    {
      public nsappflowcollector[] nsappflowcollector = (nsappflowcollector[]) null;
    }
  }
}
