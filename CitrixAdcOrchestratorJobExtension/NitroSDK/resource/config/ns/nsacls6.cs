// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nsacls6
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nsacls6 : base_resource
  {
    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nsacls6[] nsacls6Array = new nsacls6[1];
      nsacls6.nsacls6_response nsacls6Response = new nsacls6.nsacls6_response();
      nsacls6.nsacls6_response resource = (nsacls6.nsacls6_response) service.get_payload_formatter().string_to_resource(nsacls6Response.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      nsacls6Array[0] = resource.nsacls6;
      return (base_resource[]) nsacls6Array;
    }

    internal override string get_object_name() => (string) null;

    public static base_response clear(nitro_service client) => new nsacls6().perform_operation_byaction(client, nameof (clear));

    public static base_response apply(nitro_service client, nsacls6 resource) => new nsacls6().perform_operation_byaction(client, nameof (apply));

    public static base_response renumber(nitro_service client) => new nsacls6().perform_operation_byaction(client, nameof (renumber));

    private class nsacls6_response : base_response
    {
      public nsacls6 nsacls6 = (nsacls6) null;
    }
  }
}
