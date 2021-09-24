// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.appflow.appflowcollector
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.appflow
{
  public class appflowcollector : base_resource
  {
    private string nameField = (string) null;
    private string ipaddressField = (string) null;
    private ushort? portField = new ushort?();
    private string netprofileField = (string) null;
    private string newnameField = (string) null;
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

    public string netprofile
    {
      get => this.netprofileField;
      set => this.netprofileField = value;
    }

    public string newname
    {
      get => this.newnameField;
      set => this.newnameField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      appflowcollector.appflowcollector_response appflowcollectorResponse = new appflowcollector.appflowcollector_response();
      appflowcollector.appflowcollector_response resource = (appflowcollector.appflowcollector_response) service.get_payload_formatter().string_to_resource(appflowcollectorResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.appflowcollector;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, appflowcollector resource) => new appflowcollector()
    {
      name = resource.name,
      ipaddress = resource.ipaddress,
      port = resource.port,
      netprofile = resource.netprofile
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      appflowcollector[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appflowcollector[] appflowcollectorArray = new appflowcollector[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appflowcollectorArray[index] = new appflowcollector();
          appflowcollectorArray[index].name = resources[index].name;
          appflowcollectorArray[index].ipaddress = resources[index].ipaddress;
          appflowcollectorArray[index].port = resources[index].port;
          appflowcollectorArray[index].netprofile = resources[index].netprofile;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) appflowcollectorArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new appflowcollector()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, appflowcollector resource) => new appflowcollector()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        appflowcollector[] appflowcollectorArray = new appflowcollector[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          appflowcollectorArray[index] = new appflowcollector();
          appflowcollectorArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) appflowcollectorArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      appflowcollector[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appflowcollector[] appflowcollectorArray = new appflowcollector[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appflowcollectorArray[index] = new appflowcollector();
          appflowcollectorArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) appflowcollectorArray);
      }
      return baseResponses;
    }

    public static base_response rename(
      nitro_service client,
      appflowcollector resource,
      string new_name)
    {
      return new appflowcollector()
      {
        name = resource.name,
        newname = new_name
      }.rename_resource(client);
    }

    public static base_response rename(
      nitro_service client,
      string name,
      string new_name)
    {
      return new appflowcollector()
      {
        name = name,
        newname = new_name
      }.rename_resource(client);
    }

    public static appflowcollector[] get(nitro_service service) => (appflowcollector[]) new appflowcollector().get_resources(service, (options) null);

    public static appflowcollector[] get(nitro_service service, options option) => (appflowcollector[]) new appflowcollector().get_resources(service, option);

    public static appflowcollector get(nitro_service service, string name) => (appflowcollector) new appflowcollector()
    {
      name = name
    }.get_resource(service);

    public static appflowcollector[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (appflowcollector[]) null;
      appflowcollector[] appflowcollectorArray1 = new appflowcollector[name.Length];
      appflowcollector[] appflowcollectorArray2 = new appflowcollector[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        appflowcollectorArray2[index] = new appflowcollector();
        appflowcollectorArray2[index].name = name[index];
        appflowcollectorArray1[index] = (appflowcollector) appflowcollectorArray2[index].get_resource(service);
      }
      return appflowcollectorArray1;
    }

    public static appflowcollector[] get_filtered(
      nitro_service service,
      string filter)
    {
      appflowcollector appflowcollector = new appflowcollector();
      options option = new options();
      option.set_filter(filter);
      return (appflowcollector[]) appflowcollector.getfiltered(service, option);
    }

    public static appflowcollector[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      appflowcollector appflowcollector = new appflowcollector();
      options option = new options();
      option.set_filter(filter);
      return (appflowcollector[]) appflowcollector.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      appflowcollector appflowcollector = new appflowcollector();
      options option = new options();
      option.set_count(true);
      appflowcollector[] resources = (appflowcollector[]) appflowcollector.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      appflowcollector appflowcollector = new appflowcollector();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appflowcollector[] appflowcollectorArray = (appflowcollector[]) appflowcollector.getfiltered(service, option);
      return appflowcollectorArray != null && appflowcollectorArray.Length > 0 ? appflowcollectorArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      appflowcollector appflowcollector = new appflowcollector();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appflowcollector[] appflowcollectorArray = (appflowcollector[]) appflowcollector.getfiltered(service, option);
      return appflowcollectorArray != null && appflowcollectorArray.Length > 0 ? appflowcollectorArray[0].__count.Value : 0U;
    }

    private class appflowcollector_response : base_response
    {
      public appflowcollector[] appflowcollector = (appflowcollector[]) null;
    }
  }
}
