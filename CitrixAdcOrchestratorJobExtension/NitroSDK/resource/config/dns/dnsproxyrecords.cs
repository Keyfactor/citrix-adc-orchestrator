// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.dns.dnsproxyrecords
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.dns
{
  public class dnsproxyrecords : base_resource
  {
    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      dnsproxyrecords[] dnsproxyrecordsArray = new dnsproxyrecords[1];
      dnsproxyrecords.dnsproxyrecords_response dnsproxyrecordsResponse = new dnsproxyrecords.dnsproxyrecords_response();
      dnsproxyrecords.dnsproxyrecords_response resource = (dnsproxyrecords.dnsproxyrecords_response) service.get_payload_formatter().string_to_resource(dnsproxyrecordsResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      dnsproxyrecordsArray[0] = resource.dnsproxyrecords;
      return (base_resource[]) dnsproxyrecordsArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response flush(nitro_service client) => new dnsproxyrecords().perform_operation_byaction(client, nameof (flush));

    private class dnsproxyrecords_response : base_response
    {
      public dnsproxyrecords dnsproxyrecords = (dnsproxyrecords) null;
    }
  }
}
