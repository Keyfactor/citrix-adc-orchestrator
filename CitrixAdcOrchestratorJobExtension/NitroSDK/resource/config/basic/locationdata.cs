// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.basic.locationdata
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.basic
{
  public class locationdata : base_resource
  {
    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      locationdata[] locationdataArray = new locationdata[1];
      locationdata.locationdata_response locationdataResponse = new locationdata.locationdata_response();
      locationdata.locationdata_response resource = (locationdata.locationdata_response) service.get_payload_formatter().string_to_resource(locationdataResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      locationdataArray[0] = resource.locationdata;
      return (base_resource[]) locationdataArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response clear(nitro_service client) => new locationdata().perform_operation_byaction(client, nameof (clear));

    private class locationdata_response : base_response
    {
      public locationdata locationdata = (locationdata) null;
    }
  }
}
