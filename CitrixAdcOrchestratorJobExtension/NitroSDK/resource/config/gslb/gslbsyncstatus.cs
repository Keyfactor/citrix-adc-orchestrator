// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.gslb.gslbsyncstatus
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.gslb
{
  public class gslbsyncstatus : base_resource
  {
    private string responseField = (string) null;

    public string response
    {
      get => this.responseField;
      private set => this.responseField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      gslbsyncstatus[] gslbsyncstatusArray = new gslbsyncstatus[1];
      gslbsyncstatus.gslbsyncstatus_response gslbsyncstatusResponse = new gslbsyncstatus.gslbsyncstatus_response();
      gslbsyncstatus.gslbsyncstatus_response resource = (gslbsyncstatus.gslbsyncstatus_response) service.get_payload_formatter().string_to_resource(gslbsyncstatusResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      gslbsyncstatusArray[0] = resource.gslbsyncstatus;
      return (base_resource[]) gslbsyncstatusArray;
    }

    internal override string get_object_name() => (string) null;

    public static gslbsyncstatus get(nitro_service service) => ((gslbsyncstatus[]) new gslbsyncstatus().get_resources(service, (options) null))[0];

    public static gslbsyncstatus get(nitro_service service, options option) => ((gslbsyncstatus[]) new gslbsyncstatus().get_resources(service, option))[0];

    private class gslbsyncstatus_response : base_response
    {
      public gslbsyncstatus gslbsyncstatus = (gslbsyncstatus) null;
    }
  }
}
