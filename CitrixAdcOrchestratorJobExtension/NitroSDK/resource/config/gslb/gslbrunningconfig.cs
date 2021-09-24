// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.gslb.gslbrunningconfig
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.gslb
{
  public class gslbrunningconfig : base_resource
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
      gslbrunningconfig[] gslbrunningconfigArray = new gslbrunningconfig[1];
      gslbrunningconfig.gslbrunningconfig_response gslbrunningconfigResponse = new gslbrunningconfig.gslbrunningconfig_response();
      gslbrunningconfig.gslbrunningconfig_response resource = (gslbrunningconfig.gslbrunningconfig_response) service.get_payload_formatter().string_to_resource(gslbrunningconfigResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      gslbrunningconfigArray[0] = resource.gslbrunningconfig;
      return (base_resource[]) gslbrunningconfigArray;
    }

    internal override string get_object_name() => (string) null;

    public static gslbrunningconfig get(nitro_service service) => ((gslbrunningconfig[]) new gslbrunningconfig().get_resources(service, (options) null))[0];

    public static gslbrunningconfig get(nitro_service service, options option) => ((gslbrunningconfig[]) new gslbrunningconfig().get_resources(service, option))[0];

    private class gslbrunningconfig_response : base_response
    {
      public gslbrunningconfig gslbrunningconfig = (gslbrunningconfig) null;
    }
  }
}
