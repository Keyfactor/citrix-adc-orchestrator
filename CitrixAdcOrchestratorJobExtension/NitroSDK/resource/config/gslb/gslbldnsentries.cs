// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.gslb.gslbldnsentries
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.gslb
{
  public class gslbldnsentries : base_resource
  {
    private string sitenameField = (string) null;
    private uint? numsitesField = new uint?();
    private string ipaddressField = (string) null;
    private uint? ttlField = new uint?();
    private string nameField = (string) null;
    private uint?[] rttField = (uint?[]) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string sitename
    {
      get => this.sitenameField;
      private set => this.sitenameField = value;
    }

    public uint? numsites
    {
      get => this.numsitesField;
      private set => this.numsitesField = value;
    }

    public string ipaddress
    {
      get => this.ipaddressField;
      private set => this.ipaddressField = value;
    }

    public uint? ttl
    {
      get => this.ttlField;
      private set => this.ttlField = value;
    }

    public string name
    {
      get => this.nameField;
      private set => this.nameField = value;
    }

    public uint?[] rtt
    {
      get => this.rttField;
      private set => this.rttField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      gslbldnsentries.gslbldnsentries_response gslbldnsentriesResponse = new gslbldnsentries.gslbldnsentries_response();
      gslbldnsentries.gslbldnsentries_response resource = (gslbldnsentries.gslbldnsentries_response) service.get_payload_formatter().string_to_resource(gslbldnsentriesResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.gslbldnsentries;
    }

    internal override string get_object_name() => (string) null;

    public static base_response clear(nitro_service client) => new gslbldnsentries().perform_operation_byaction(client, nameof (clear));

    public static base_responses clear(
      nitro_service client,
      gslbldnsentries[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        gslbldnsentries[] gslbldnsentriesArray = new gslbldnsentries[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
          gslbldnsentriesArray[index] = new gslbldnsentries();
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) gslbldnsentriesArray, nameof (clear));
      }
      return baseResponses;
    }

    public static gslbldnsentries[] get(nitro_service service) => (gslbldnsentries[]) new gslbldnsentries().get_resources(service, (options) null);

    public static gslbldnsentries[] get(nitro_service service, options option) => (gslbldnsentries[]) new gslbldnsentries().get_resources(service, option);

    public static gslbldnsentries[] get_filtered(
      nitro_service service,
      string filter)
    {
      gslbldnsentries gslbldnsentries = new gslbldnsentries();
      options option = new options();
      option.set_filter(filter);
      return (gslbldnsentries[]) gslbldnsentries.getfiltered(service, option);
    }

    public static gslbldnsentries[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      gslbldnsentries gslbldnsentries = new gslbldnsentries();
      options option = new options();
      option.set_filter(filter);
      return (gslbldnsentries[]) gslbldnsentries.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      gslbldnsentries gslbldnsentries = new gslbldnsentries();
      options option = new options();
      option.set_count(true);
      gslbldnsentries[] resources = (gslbldnsentries[]) gslbldnsentries.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      gslbldnsentries gslbldnsentries = new gslbldnsentries();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      gslbldnsentries[] gslbldnsentriesArray = (gslbldnsentries[]) gslbldnsentries.getfiltered(service, option);
      return gslbldnsentriesArray != null && gslbldnsentriesArray.Length > 0 ? gslbldnsentriesArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      gslbldnsentries gslbldnsentries = new gslbldnsentries();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      gslbldnsentries[] gslbldnsentriesArray = (gslbldnsentries[]) gslbldnsentries.getfiltered(service, option);
      return gslbldnsentriesArray != null && gslbldnsentriesArray.Length > 0 ? gslbldnsentriesArray[0].__count.Value : 0U;
    }

    private class gslbldnsentries_response : base_response
    {
      public gslbldnsentries[] gslbldnsentries = (gslbldnsentries[]) null;
    }
  }
}
