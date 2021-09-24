// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.responder.responderparam
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.responder
{
  public class responderparam : base_resource
  {
    private string undefactionField = (string) null;

    public string undefaction
    {
      get => this.undefactionField;
      set => this.undefactionField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      responderparam[] responderparamArray = new responderparam[1];
      responderparam.responderparam_response responderparamResponse = new responderparam.responderparam_response();
      responderparam.responderparam_response resource = (responderparam.responderparam_response) service.get_payload_formatter().string_to_resource(responderparamResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      responderparamArray[0] = resource.responderparam;
      return (base_resource[]) responderparamArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, responderparam resource) => new responderparam()
    {
      undefaction = resource.undefaction
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      responderparam resource,
      string[] args)
    {
      return new responderparam().unset_resource(client, args);
    }

    public static responderparam get(nitro_service service) => ((responderparam[]) new responderparam().get_resources(service, (options) null))[0];

    public static responderparam get(nitro_service service, options option) => ((responderparam[]) new responderparam().get_resources(service, option))[0];

    private class responderparam_response : base_response
    {
      public responderparam responderparam = (responderparam) null;
    }
  }
}
