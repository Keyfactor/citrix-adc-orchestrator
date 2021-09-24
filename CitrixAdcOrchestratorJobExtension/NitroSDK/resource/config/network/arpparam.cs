// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.arpparam
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class arpparam : base_resource
  {
    private uint? timeoutField = new uint?();
    private string spoofvalidationField = (string) null;

    public uint? timeout
    {
      get => this.timeoutField;
      set => this.timeoutField = value;
    }

    public string spoofvalidation
    {
      get => this.spoofvalidationField;
      set => this.spoofvalidationField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      arpparam[] arpparamArray = new arpparam[1];
      arpparam.arpparam_response arpparamResponse = new arpparam.arpparam_response();
      arpparam.arpparam_response resource = (arpparam.arpparam_response) service.get_payload_formatter().string_to_resource(arpparamResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      arpparamArray[0] = resource.arpparam;
      return (base_resource[]) arpparamArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, arpparam resource) => new arpparam()
    {
      timeout = resource.timeout,
      spoofvalidation = resource.spoofvalidation
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      arpparam resource,
      string[] args)
    {
      return new arpparam().unset_resource(client, args);
    }

    public static arpparam get(nitro_service service) => ((arpparam[]) new arpparam().get_resources(service, (options) null))[0];

    public static arpparam get(nitro_service service, options option) => ((arpparam[]) new arpparam().get_resources(service, option))[0];

    private class arpparam_response : base_response
    {
      public arpparam arpparam = (arpparam) null;
    }

    public static class spoofvalidationEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
