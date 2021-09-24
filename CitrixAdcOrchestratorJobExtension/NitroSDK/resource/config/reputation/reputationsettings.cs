// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.reputation.reputationsettings
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.reputation
{
  public class reputationsettings : base_resource
  {
    private string proxyserverField = (string) null;
    private uint? proxyportField = new uint?();

    public string proxyserver
    {
      get => this.proxyserverField;
      set => this.proxyserverField = value;
    }

    public uint? proxyport
    {
      get => this.proxyportField;
      set => this.proxyportField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      reputationsettings[] reputationsettingsArray = new reputationsettings[1];
      reputationsettings.reputationsettings_response reputationsettingsResponse = new reputationsettings.reputationsettings_response();
      reputationsettings.reputationsettings_response resource = (reputationsettings.reputationsettings_response) service.get_payload_formatter().string_to_resource(reputationsettingsResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      reputationsettingsArray[0] = resource.reputationsettings;
      return (base_resource[]) reputationsettingsArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(
      nitro_service client,
      reputationsettings resource)
    {
      return new reputationsettings()
      {
        proxyserver = resource.proxyserver,
        proxyport = resource.proxyport
      }.update_resource(client);
    }

    public static base_response unset(
      nitro_service client,
      reputationsettings resource,
      string[] args)
    {
      return new reputationsettings().unset_resource(client, args);
    }

    public static reputationsettings get(nitro_service service) => ((reputationsettings[]) new reputationsettings().get_resources(service, (options) null))[0];

    public static reputationsettings get(nitro_service service, options option) => ((reputationsettings[]) new reputationsettings().get_resources(service, option))[0];

    private class reputationsettings_response : base_response
    {
      public reputationsettings reputationsettings = (reputationsettings) null;
    }
  }
}
