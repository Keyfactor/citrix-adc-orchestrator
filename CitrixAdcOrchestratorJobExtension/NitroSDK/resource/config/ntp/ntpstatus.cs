// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ntp.ntpstatus
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ntp
{
  public class ntpstatus : base_resource
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
      ntpstatus[] ntpstatusArray = new ntpstatus[1];
      ntpstatus.ntpstatus_response ntpstatusResponse = new ntpstatus.ntpstatus_response();
      ntpstatus.ntpstatus_response resource = (ntpstatus.ntpstatus_response) service.get_payload_formatter().string_to_resource(ntpstatusResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      ntpstatusArray[0] = resource.ntpstatus;
      return (base_resource[]) ntpstatusArray;
    }

    internal override string get_object_name() => (string) null;

    public static ntpstatus get(nitro_service service) => ((ntpstatus[]) new ntpstatus().get_resources(service, (options) null))[0];

    public static ntpstatus get(nitro_service service, options option) => ((ntpstatus[]) new ntpstatus().get_resources(service, option))[0];

    private class ntpstatus_response : base_response
    {
      public ntpstatus ntpstatus = (ntpstatus) null;
    }
  }
}
