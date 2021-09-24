// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.subscriber.subscriberradiusinterface
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.subscriber
{
  public class subscriberradiusinterface : base_resource
  {
    private string listeningserviceField = (string) null;
    private string svrstateField = (string) null;

    public string listeningservice
    {
      get => this.listeningserviceField;
      set => this.listeningserviceField = value;
    }

    public string svrstate
    {
      get => this.svrstateField;
      private set => this.svrstateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      subscriberradiusinterface[] subscriberradiusinterfaceArray = new subscriberradiusinterface[1];
      subscriberradiusinterface.subscriberradiusinterface_response subscriberradiusinterfaceResponse = new subscriberradiusinterface.subscriberradiusinterface_response();
      subscriberradiusinterface.subscriberradiusinterface_response resource = (subscriberradiusinterface.subscriberradiusinterface_response) service.get_payload_formatter().string_to_resource(subscriberradiusinterfaceResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      subscriberradiusinterfaceArray[0] = resource.subscriberradiusinterface;
      return (base_resource[]) subscriberradiusinterfaceArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(
      nitro_service client,
      subscriberradiusinterface resource)
    {
      return new subscriberradiusinterface()
      {
        listeningservice = resource.listeningservice
      }.update_resource(client);
    }

    public static subscriberradiusinterface get(nitro_service service) => ((subscriberradiusinterface[]) new subscriberradiusinterface().get_resources(service, (options) null))[0];

    public static subscriberradiusinterface get(
      nitro_service service,
      options option)
    {
      return ((subscriberradiusinterface[]) new subscriberradiusinterface().get_resources(service, option))[0];
    }

    private class subscriberradiusinterface_response : base_response
    {
      public subscriberradiusinterface subscriberradiusinterface = (subscriberradiusinterface) null;
    }

    public static class svrstateEnum
    {
      public const string UP = "UP";
      public const string DOWN = "DOWN";
      public const string UNKNOWN = "UNKNOWN";
      public const string BUSY = "BUSY";
      public const string OUT_OF_SERVICE = "OUT OF SERVICE";
      public const string GOING_OUT_OF_SERVICE = "GOING OUT OF SERVICE";
      public const string DOWN_WHEN_GOING_OUT_OF_SERVICE = "DOWN WHEN GOING OUT OF SERVICE";
      public const string NS_EMPTY_STR = "NS_EMPTY_STR";
      public const string Unknown = "Unknown";
      public const string DISABLED = "DISABLED";
    }
  }
}
