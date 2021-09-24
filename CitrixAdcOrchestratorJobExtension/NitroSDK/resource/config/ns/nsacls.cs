// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nsacls
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nsacls : base_resource
  {
    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nsacls[] nsaclsArray = new nsacls[1];
      nsacls.nsacls_response nsaclsResponse = new nsacls.nsacls_response();
      nsacls.nsacls_response resource = (nsacls.nsacls_response) service.get_payload_formatter().string_to_resource(nsaclsResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      nsaclsArray[0] = resource.nsacls;
      return (base_resource[]) nsaclsArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response renumber(nitro_service client) => new nsacls().perform_operation_byaction(client, nameof (renumber));

    public static base_response clear(nitro_service client) => new nsacls().perform_operation_byaction(client, nameof (clear));

    public static base_response apply(nitro_service client, nsacls resource) => new nsacls().perform_operation_byaction(client, nameof (apply));

    private class nsacls_response : base_response
    {
      public nsacls nsacls = (nsacls) null;
    }
  }
}
