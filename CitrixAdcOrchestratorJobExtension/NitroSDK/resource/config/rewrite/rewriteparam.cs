// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.rewrite.rewriteparam
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.rewrite
{
  public class rewriteparam : base_resource
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
      rewriteparam[] rewriteparamArray = new rewriteparam[1];
      rewriteparam.rewriteparam_response rewriteparamResponse = new rewriteparam.rewriteparam_response();
      rewriteparam.rewriteparam_response resource = (rewriteparam.rewriteparam_response) service.get_payload_formatter().string_to_resource(rewriteparamResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      rewriteparamArray[0] = resource.rewriteparam;
      return (base_resource[]) rewriteparamArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, rewriteparam resource) => new rewriteparam()
    {
      undefaction = resource.undefaction
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      rewriteparam resource,
      string[] args)
    {
      return new rewriteparam().unset_resource(client, args);
    }

    public static rewriteparam get(nitro_service service) => ((rewriteparam[]) new rewriteparam().get_resources(service, (options) null))[0];

    public static rewriteparam get(nitro_service service, options option) => ((rewriteparam[]) new rewriteparam().get_resources(service, option))[0];

    private class rewriteparam_response : base_response
    {
      public rewriteparam rewriteparam = (rewriteparam) null;
    }
  }
}
