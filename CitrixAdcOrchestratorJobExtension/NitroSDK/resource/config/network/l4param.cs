// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.l4param
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class l4param : base_resource
  {
    private string l2connmethodField = (string) null;
    private string l4switchField = (string) null;

    public string l2connmethod
    {
      get => this.l2connmethodField;
      set => this.l2connmethodField = value;
    }

    public string l4switch
    {
      get => this.l4switchField;
      set => this.l4switchField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      l4param[] l4paramArray = new l4param[1];
      l4param.l4param_response l4paramResponse = new l4param.l4param_response();
      l4param.l4param_response resource = (l4param.l4param_response) service.get_payload_formatter().string_to_resource(l4paramResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      l4paramArray[0] = resource.l4param;
      return (base_resource[]) l4paramArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, l4param resource) => new l4param()
    {
      l2connmethod = resource.l2connmethod,
      l4switch = resource.l4switch
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      l4param resource,
      string[] args)
    {
      return new l4param().unset_resource(client, args);
    }

    public static l4param get(nitro_service service) => ((l4param[]) new l4param().get_resources(service, (options) null))[0];

    public static l4param get(nitro_service service, options option) => ((l4param[]) new l4param().get_resources(service, option))[0];

    private class l4param_response : base_response
    {
      public l4param l4param = (l4param) null;
    }

    public static class l4switchEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class l2connmethodEnum
    {
      public const string Channel = "Channel";
      public const string Vlan = "Vlan";
      public const string VlanChannel = "VlanChannel";
      public const string Mac = "Mac";
      public const string MacChannel = "MacChannel";
      public const string MacVlan = "MacVlan";
      public const string MacVlanChannel = "MacVlanChannel";
    }
  }
}
