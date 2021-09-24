// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.vpn.vpnicaconnection
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.vpn
{
  public class vpnicaconnection : base_resource
  {
    private string usernameField = (string) null;
    private bool? allField = new bool?();
    private string domainField = (string) null;
    private string srcipField = (string) null;
    private ushort? srcportField = new ushort?();
    private string destipField = (string) null;
    private ushort? destportField = new ushort?();
    private uint? peidField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string username
    {
      get => this.usernameField;
      set => this.usernameField = value;
    }

    public bool? all
    {
      get => this.allField;
      set => this.allField = value;
    }

    public string domain
    {
      get => this.domainField;
      private set => this.domainField = value;
    }

    public string srcip
    {
      get => this.srcipField;
      private set => this.srcipField = value;
    }

    public ushort? srcport
    {
      get => this.srcportField;
      private set => this.srcportField = value;
    }

    public string destip
    {
      get => this.destipField;
      private set => this.destipField = value;
    }

    public ushort? destport
    {
      get => this.destportField;
      private set => this.destportField = value;
    }

    public uint? peid
    {
      get => this.peidField;
      private set => this.peidField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vpnicaconnection.vpnicaconnection_response vpnicaconnectionResponse = new vpnicaconnection.vpnicaconnection_response();
      vpnicaconnection.vpnicaconnection_response resource = (vpnicaconnection.vpnicaconnection_response) service.get_payload_formatter().string_to_resource(vpnicaconnectionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vpnicaconnection;
    }

    internal override string get_object_name() => (string) null;

    public static base_response kill(nitro_service client, vpnicaconnection resource) => new vpnicaconnection()
    {
      username = resource.username,
      all = resource.all
    }.perform_operation_byaction(client, nameof (kill));

    public static base_responses kill(
      nitro_service client,
      vpnicaconnection[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnicaconnection[] vpnicaconnectionArray = new vpnicaconnection[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnicaconnectionArray[index] = new vpnicaconnection();
          vpnicaconnectionArray[index].username = resources[index].username;
          vpnicaconnectionArray[index].all = resources[index].all;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) vpnicaconnectionArray, nameof (kill));
      }
      return baseResponses;
    }

    public static vpnicaconnection[] get(nitro_service service) => (vpnicaconnection[]) new vpnicaconnection().get_resources(service, (options) null);

    public static vpnicaconnection[] get(nitro_service service, options option) => (vpnicaconnection[]) new vpnicaconnection().get_resources(service, option);

    public static vpnicaconnection[] get(
      nitro_service service,
      vpnicaconnection_args args)
    {
      vpnicaconnection vpnicaconnection = new vpnicaconnection();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (vpnicaconnection[]) vpnicaconnection.get_resources(service, option);
    }

    public static vpnicaconnection[] get_filtered(
      nitro_service service,
      string filter)
    {
      vpnicaconnection vpnicaconnection = new vpnicaconnection();
      options option = new options();
      option.set_filter(filter);
      return (vpnicaconnection[]) vpnicaconnection.getfiltered(service, option);
    }

    public static vpnicaconnection[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      vpnicaconnection vpnicaconnection = new vpnicaconnection();
      options option = new options();
      option.set_filter(filter);
      return (vpnicaconnection[]) vpnicaconnection.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      vpnicaconnection vpnicaconnection = new vpnicaconnection();
      options option = new options();
      option.set_count(true);
      vpnicaconnection[] resources = (vpnicaconnection[]) vpnicaconnection.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      vpnicaconnection vpnicaconnection = new vpnicaconnection();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnicaconnection[] vpnicaconnectionArray = (vpnicaconnection[]) vpnicaconnection.getfiltered(service, option);
      return vpnicaconnectionArray != null && vpnicaconnectionArray.Length > 0 ? vpnicaconnectionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      vpnicaconnection vpnicaconnection = new vpnicaconnection();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnicaconnection[] vpnicaconnectionArray = (vpnicaconnection[]) vpnicaconnection.getfiltered(service, option);
      return vpnicaconnectionArray != null && vpnicaconnectionArray.Length > 0 ? vpnicaconnectionArray[0].__count.Value : 0U;
    }

    private class vpnicaconnection_response : base_response
    {
      public vpnicaconnection[] vpnicaconnection = (vpnicaconnection[]) null;
    }
  }
}
