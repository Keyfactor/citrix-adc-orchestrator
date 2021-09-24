// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.gslb.gslbldnsentry
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.gslb
{
  public class gslbldnsentry : base_resource
  {
    private string ipaddressField = (string) null;

    public string ipaddress
    {
      get => this.ipaddressField;
      set => this.ipaddressField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      gslbldnsentry[] gslbldnsentryArray = new gslbldnsentry[1];
      gslbldnsentry.gslbldnsentry_response gslbldnsentryResponse = new gslbldnsentry.gslbldnsentry_response();
      gslbldnsentry.gslbldnsentry_response resource = (gslbldnsentry.gslbldnsentry_response) service.get_payload_formatter().string_to_resource(gslbldnsentryResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      gslbldnsentryArray[0] = resource.gslbldnsentry;
      return (base_resource[]) gslbldnsentryArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response delete(nitro_service client, gslbldnsentry resource) => new gslbldnsentry()
    {
      ipaddress = resource.ipaddress
    }.delete_resource(client);

    private class gslbldnsentry_response : base_response
    {
      public gslbldnsentry gslbldnsentry = (gslbldnsentry) null;
    }
  }
}
