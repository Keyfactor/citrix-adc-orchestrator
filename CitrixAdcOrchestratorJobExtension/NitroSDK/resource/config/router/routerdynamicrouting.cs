// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.router.routerdynamicrouting
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.router
{
  public class routerdynamicrouting : base_resource
  {
    private string commandstringField = (string) null;
    private string outputField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string commandstring
    {
      get => this.commandstringField;
      set => this.commandstringField = value;
    }

    public string output
    {
      get => this.outputField;
      private set => this.outputField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      routerdynamicrouting.routerdynamicrouting_response routerdynamicroutingResponse = new routerdynamicrouting.routerdynamicrouting_response();
      routerdynamicrouting.routerdynamicrouting_response resource = (routerdynamicrouting.routerdynamicrouting_response) service.get_payload_formatter().string_to_resource(routerdynamicroutingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.routerdynamicrouting;
    }

    internal override string get_object_name() => (string) null;

    public static base_response apply(
      nitro_service client,
      routerdynamicrouting resource)
    {
      return new routerdynamicrouting()
      {
        commandstring = resource.commandstring
      }.perform_operation_byaction(client, nameof (apply));
    }

    public static base_responses apply(
      nitro_service client,
      routerdynamicrouting[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        routerdynamicrouting[] routerdynamicroutingArray = new routerdynamicrouting[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          routerdynamicroutingArray[index] = new routerdynamicrouting();
          routerdynamicroutingArray[index].commandstring = resources[index].commandstring;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) routerdynamicroutingArray, nameof (apply));
      }
      return baseResponses;
    }

    public static routerdynamicrouting[] get(nitro_service service) => (routerdynamicrouting[]) new routerdynamicrouting().get_resources(service, (options) null);

    public static routerdynamicrouting[] get(
      nitro_service service,
      options option)
    {
      return (routerdynamicrouting[]) new routerdynamicrouting().get_resources(service, option);
    }

    public static routerdynamicrouting[] get(
      nitro_service service,
      routerdynamicrouting_args args)
    {
      routerdynamicrouting routerdynamicrouting = new routerdynamicrouting();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (routerdynamicrouting[]) routerdynamicrouting.get_resources(service, option);
    }

    public static routerdynamicrouting[] get_filtered(
      nitro_service service,
      string filter)
    {
      routerdynamicrouting routerdynamicrouting = new routerdynamicrouting();
      options option = new options();
      option.set_filter(filter);
      return (routerdynamicrouting[]) routerdynamicrouting.getfiltered(service, option);
    }

    public static routerdynamicrouting[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      routerdynamicrouting routerdynamicrouting = new routerdynamicrouting();
      options option = new options();
      option.set_filter(filter);
      return (routerdynamicrouting[]) routerdynamicrouting.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      routerdynamicrouting routerdynamicrouting = new routerdynamicrouting();
      options option = new options();
      option.set_count(true);
      routerdynamicrouting[] resources = (routerdynamicrouting[]) routerdynamicrouting.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      routerdynamicrouting routerdynamicrouting = new routerdynamicrouting();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      routerdynamicrouting[] routerdynamicroutingArray = (routerdynamicrouting[]) routerdynamicrouting.getfiltered(service, option);
      return routerdynamicroutingArray != null && routerdynamicroutingArray.Length > 0 ? routerdynamicroutingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      routerdynamicrouting routerdynamicrouting = new routerdynamicrouting();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      routerdynamicrouting[] routerdynamicroutingArray = (routerdynamicrouting[]) routerdynamicrouting.getfiltered(service, option);
      return routerdynamicroutingArray != null && routerdynamicroutingArray.Length > 0 ? routerdynamicroutingArray[0].__count.Value : 0U;
    }

    private class routerdynamicrouting_response : base_response
    {
      public routerdynamicrouting[] routerdynamicrouting = (routerdynamicrouting[]) null;
    }
  }
}
