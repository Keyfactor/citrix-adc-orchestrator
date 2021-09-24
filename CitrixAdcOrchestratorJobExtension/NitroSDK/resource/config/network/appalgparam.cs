// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.appalgparam
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class appalgparam : base_resource
  {
    private uint? pptpgreidletimeoutField = new uint?();

    public uint? pptpgreidletimeout
    {
      get => this.pptpgreidletimeoutField;
      set => this.pptpgreidletimeoutField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      appalgparam[] appalgparamArray = new appalgparam[1];
      appalgparam.appalgparam_response appalgparamResponse = new appalgparam.appalgparam_response();
      appalgparam.appalgparam_response resource = (appalgparam.appalgparam_response) service.get_payload_formatter().string_to_resource(appalgparamResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      appalgparamArray[0] = resource.appalgparam;
      return (base_resource[]) appalgparamArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, appalgparam resource) => new appalgparam()
    {
      pptpgreidletimeout = resource.pptpgreidletimeout
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      appalgparam resource,
      string[] args)
    {
      return new appalgparam().unset_resource(client, args);
    }

    public static appalgparam get(nitro_service service) => ((appalgparam[]) new appalgparam().get_resources(service, (options) null))[0];

    public static appalgparam get(nitro_service service, options option) => ((appalgparam[]) new appalgparam().get_resources(service, option))[0];

    private class appalgparam_response : base_response
    {
      public appalgparam appalgparam = (appalgparam) null;
    }
  }
}
