// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ntp.ntpsync
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ntp
{
  public class ntpsync : base_resource
  {
    private string stateField = (string) null;

    public string state
    {
      get => this.stateField;
      private set => this.stateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      ntpsync[] ntpsyncArray = new ntpsync[1];
      ntpsync.ntpsync_response ntpsyncResponse = new ntpsync.ntpsync_response();
      ntpsync.ntpsync_response resource = (ntpsync.ntpsync_response) service.get_payload_formatter().string_to_resource(ntpsyncResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      ntpsyncArray[0] = resource.ntpsync;
      return (base_resource[]) ntpsyncArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response enable(nitro_service client) => new ntpsync().perform_operation_byaction(client, nameof (enable));

    public static base_response disable(nitro_service client) => new ntpsync().perform_operation_byaction(client, nameof (disable));

    public static ntpsync get(nitro_service service) => ((ntpsync[]) new ntpsync().get_resources(service, (options) null))[0];

    public static ntpsync get(nitro_service service, options option) => ((ntpsync[]) new ntpsync().get_resources(service, option))[0];

    private class ntpsync_response : base_response
    {
      public ntpsync ntpsync = (ntpsync) null;
    }

    public static class stateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
