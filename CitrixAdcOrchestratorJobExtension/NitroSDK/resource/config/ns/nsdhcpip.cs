// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nsdhcpip
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nsdhcpip : base_resource
  {
    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nsdhcpip[] nsdhcpipArray = new nsdhcpip[1];
      nsdhcpip.nsdhcpip_response nsdhcpipResponse = new nsdhcpip.nsdhcpip_response();
      nsdhcpip.nsdhcpip_response resource = (nsdhcpip.nsdhcpip_response) service.get_payload_formatter().string_to_resource(nsdhcpipResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      nsdhcpipArray[0] = resource.nsdhcpip;
      return (base_resource[]) nsdhcpipArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response release(nitro_service client) => new nsdhcpip().perform_operation_byaction(client, nameof (release));

    private class nsdhcpip_response : base_response
    {
      public nsdhcpip nsdhcpip = (nsdhcpip) null;
    }
  }
}
