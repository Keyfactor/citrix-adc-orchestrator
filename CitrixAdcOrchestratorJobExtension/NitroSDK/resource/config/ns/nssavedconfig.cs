// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nssavedconfig
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nssavedconfig : base_resource
  {
    private string textblobField = (string) null;

    public string textblob
    {
      get => this.textblobField;
      private set => this.textblobField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nssavedconfig[] nssavedconfigArray = new nssavedconfig[1];
      nssavedconfig.nssavedconfig_response nssavedconfigResponse = new nssavedconfig.nssavedconfig_response();
      nssavedconfig.nssavedconfig_response resource = (nssavedconfig.nssavedconfig_response) service.get_payload_formatter().string_to_resource(nssavedconfigResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      nssavedconfigArray[0] = resource.nssavedconfig;
      return (base_resource[]) nssavedconfigArray;
    }

    internal override string get_object_name() => (string) null;

    public static nssavedconfig get(nitro_service service) => ((nssavedconfig[]) new nssavedconfig().get_resources(service, (options) null))[0];

    public static nssavedconfig get(nitro_service service, options option) => ((nssavedconfig[]) new nssavedconfig().get_resources(service, option))[0];

    private class nssavedconfig_response : base_response
    {
      public nssavedconfig nssavedconfig = (nssavedconfig) null;
    }
  }
}
