// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.basic.dbsmonitors
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.basic
{
  public class dbsmonitors : base_resource
  {
    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      dbsmonitors[] dbsmonitorsArray = new dbsmonitors[1];
      dbsmonitors.dbsmonitors_response dbsmonitorsResponse = new dbsmonitors.dbsmonitors_response();
      dbsmonitors.dbsmonitors_response resource = (dbsmonitors.dbsmonitors_response) service.get_payload_formatter().string_to_resource(dbsmonitorsResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      dbsmonitorsArray[0] = resource.dbsmonitors;
      return (base_resource[]) dbsmonitorsArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response restart(nitro_service client) => new dbsmonitors().perform_operation_byaction(client, nameof (restart));

    private class dbsmonitors_response : base_response
    {
      public dbsmonitors dbsmonitors = (dbsmonitors) null;
    }
  }
}
