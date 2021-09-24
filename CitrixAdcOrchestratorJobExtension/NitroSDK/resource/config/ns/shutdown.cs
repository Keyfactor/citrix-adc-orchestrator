// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.shutdown
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class shutdown : base_resource
  {
    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      shutdown[] shutdownArray = new shutdown[1];
      shutdown.shutdown_response shutdownResponse = new shutdown.shutdown_response();
      shutdown.shutdown_response resource = (shutdown.shutdown_response) service.get_payload_formatter().string_to_resource(shutdownResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      shutdownArray[0] = resource.shutdown;
      return (base_resource[]) shutdownArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response Shutdown(nitro_service client, shutdown resource) => new shutdown().perform_operation(client);

    private class shutdown_response : base_response
    {
      public shutdown shutdown = (shutdown) null;
    }
  }
}
