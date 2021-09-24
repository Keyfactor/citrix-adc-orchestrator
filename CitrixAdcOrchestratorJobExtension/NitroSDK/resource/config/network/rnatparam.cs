// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.rnatparam
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class rnatparam : base_resource
  {
    private string tcpproxyField = (string) null;
    private string srcippersistencyField = (string) null;

    public string tcpproxy
    {
      get => this.tcpproxyField;
      set => this.tcpproxyField = value;
    }

    public string srcippersistency
    {
      get => this.srcippersistencyField;
      set => this.srcippersistencyField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      rnatparam[] rnatparamArray = new rnatparam[1];
      rnatparam.rnatparam_response rnatparamResponse = new rnatparam.rnatparam_response();
      rnatparam.rnatparam_response resource = (rnatparam.rnatparam_response) service.get_payload_formatter().string_to_resource(rnatparamResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      rnatparamArray[0] = resource.rnatparam;
      return (base_resource[]) rnatparamArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, rnatparam resource) => new rnatparam()
    {
      tcpproxy = resource.tcpproxy,
      srcippersistency = resource.srcippersistency
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      rnatparam resource,
      string[] args)
    {
      return new rnatparam().unset_resource(client, args);
    }

    public static rnatparam get(nitro_service service) => ((rnatparam[]) new rnatparam().get_resources(service, (options) null))[0];

    public static rnatparam get(nitro_service service, options option) => ((rnatparam[]) new rnatparam().get_resources(service, option))[0];

    private class rnatparam_response : base_response
    {
      public rnatparam rnatparam = (rnatparam) null;
    }

    public static class srcippersistencyEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class tcpproxyEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
