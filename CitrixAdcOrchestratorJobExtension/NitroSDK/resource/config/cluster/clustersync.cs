// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cluster.clustersync
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.cluster
{
  public class clustersync : base_resource
  {
    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      clustersync[] clustersyncArray = new clustersync[1];
      clustersync.clustersync_response clustersyncResponse = new clustersync.clustersync_response();
      clustersync.clustersync_response resource = (clustersync.clustersync_response) service.get_payload_formatter().string_to_resource(clustersyncResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      clustersyncArray[0] = resource.clustersync;
      return (base_resource[]) clustersyncArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response Force(nitro_service client, clustersync resource) => new clustersync().perform_operation_byaction(client, nameof (Force));

    private class clustersync_response : base_response
    {
      public clustersync clustersync = (clustersync) null;
    }
  }
}
