// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.appqoe.appqoecustomresp
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.appqoe
{
  public class appqoecustomresp : base_resource
  {
    private string srcField = (string) null;
    private string nameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string src
    {
      get => this.srcField;
      set => this.srcField = value;
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
      appqoecustomresp.appqoecustomresp_response appqoecustomrespResponse = new appqoecustomresp.appqoecustomresp_response();
      appqoecustomresp.appqoecustomresp_response resource = (appqoecustomresp.appqoecustomresp_response) service.get_payload_formatter().string_to_resource(appqoecustomrespResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.appqoecustomresp;
    }

    internal override string get_object_name() => this.name;

    public static base_response Import(nitro_service client, appqoecustomresp resource) => new appqoecustomresp()
    {
      src = resource.src,
      name = resource.name
    }.perform_operation_byaction(client, nameof (Import));

    public static base_responses Import(
      nitro_service client,
      appqoecustomresp[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appqoecustomresp[] appqoecustomrespArray = new appqoecustomresp[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appqoecustomrespArray[index] = new appqoecustomresp();
          appqoecustomrespArray[index].src = resources[index].src;
          appqoecustomrespArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) appqoecustomrespArray, nameof (Import));
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new appqoecustomresp()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, appqoecustomresp resource) => new appqoecustomresp()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        appqoecustomresp[] appqoecustomrespArray = new appqoecustomresp[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          appqoecustomrespArray[index] = new appqoecustomresp();
          appqoecustomrespArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) appqoecustomrespArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      appqoecustomresp[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appqoecustomresp[] appqoecustomrespArray = new appqoecustomresp[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appqoecustomrespArray[index] = new appqoecustomresp();
          appqoecustomrespArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) appqoecustomrespArray);
      }
      return baseResponses;
    }

    public static base_response change(nitro_service client, appqoecustomresp resource) => new appqoecustomresp()
    {
      name = resource.name
    }.perform_operation_byaction(client, "update");

    public static base_responses change(
      nitro_service client,
      appqoecustomresp[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        appqoecustomresp[] appqoecustomrespArray = new appqoecustomresp[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          appqoecustomrespArray[index] = new appqoecustomresp();
          appqoecustomrespArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) appqoecustomrespArray, "update");
      }
      return baseResponses;
    }

    public static appqoecustomresp[] get(nitro_service service) => (appqoecustomresp[]) new appqoecustomresp().get_resources(service, (options) null);

    public static appqoecustomresp[] get(nitro_service service, options option) => (appqoecustomresp[]) new appqoecustomresp().get_resources(service, option);

    public static appqoecustomresp[] get_filtered(
      nitro_service service,
      string filter)
    {
      appqoecustomresp appqoecustomresp = new appqoecustomresp();
      options option = new options();
      option.set_filter(filter);
      return (appqoecustomresp[]) appqoecustomresp.getfiltered(service, option);
    }

    public static appqoecustomresp[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      appqoecustomresp appqoecustomresp = new appqoecustomresp();
      options option = new options();
      option.set_filter(filter);
      return (appqoecustomresp[]) appqoecustomresp.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      appqoecustomresp appqoecustomresp = new appqoecustomresp();
      options option = new options();
      option.set_count(true);
      appqoecustomresp[] resources = (appqoecustomresp[]) appqoecustomresp.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      appqoecustomresp appqoecustomresp = new appqoecustomresp();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appqoecustomresp[] appqoecustomrespArray = (appqoecustomresp[]) appqoecustomresp.getfiltered(service, option);
      return appqoecustomrespArray != null && appqoecustomrespArray.Length > 0 ? appqoecustomrespArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      appqoecustomresp appqoecustomresp = new appqoecustomresp();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      appqoecustomresp[] appqoecustomrespArray = (appqoecustomresp[]) appqoecustomresp.getfiltered(service, option);
      return appqoecustomrespArray != null && appqoecustomrespArray.Length > 0 ? appqoecustomrespArray[0].__count.Value : 0U;
    }

    private class appqoecustomresp_response : base_response
    {
      public appqoecustomresp[] appqoecustomresp = (appqoecustomresp[]) null;
    }
  }
}
