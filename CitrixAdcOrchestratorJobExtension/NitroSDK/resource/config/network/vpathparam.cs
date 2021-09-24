// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.vpathparam
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class vpathparam : base_resource
  {
    private string srcipField = (string) null;
    private string offloadField = (string) null;
    private string encapsulationField = (string) null;

    public string srcip
    {
      get => this.srcipField;
      set => this.srcipField = value;
    }

    public string offload
    {
      get => this.offloadField;
      set => this.offloadField = value;
    }

    public string encapsulation
    {
      get => this.encapsulationField;
      private set => this.encapsulationField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vpathparam[] vpathparamArray = new vpathparam[1];
      vpathparam.vpathparam_response vpathparamResponse = new vpathparam.vpathparam_response();
      vpathparam.vpathparam_response resource = (vpathparam.vpathparam_response) service.get_payload_formatter().string_to_resource(vpathparamResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      vpathparamArray[0] = resource.vpathparam;
      return (base_resource[]) vpathparamArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, vpathparam resource) => new vpathparam()
    {
      srcip = resource.srcip,
      offload = resource.offload
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      vpathparam resource,
      string[] args)
    {
      return new vpathparam().unset_resource(client, args);
    }

    public static vpathparam get(nitro_service service) => ((vpathparam[]) new vpathparam().get_resources(service, (options) null))[0];

    public static vpathparam get(nitro_service service, options option) => ((vpathparam[]) new vpathparam().get_resources(service, option))[0];

    private class vpathparam_response : base_response
    {
      public vpathparam vpathparam = (vpathparam) null;
    }

    public static class offloadEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class encapsulationEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
