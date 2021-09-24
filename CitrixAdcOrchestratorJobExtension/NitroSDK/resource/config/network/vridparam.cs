// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.vridparam
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class vridparam : base_resource
  {
    private string sendtomasterField = (string) null;
    private uint? hellointervalField = new uint?();
    private long? deadintervalField = new long?();

    public string sendtomaster
    {
      get => this.sendtomasterField;
      set => this.sendtomasterField = value;
    }

    public uint? hellointerval
    {
      get => this.hellointervalField;
      set => this.hellointervalField = value;
    }

    public long? deadinterval
    {
      get => this.deadintervalField;
      set => this.deadintervalField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vridparam[] vridparamArray = new vridparam[1];
      vridparam.vridparam_response vridparamResponse = new vridparam.vridparam_response();
      vridparam.vridparam_response resource = (vridparam.vridparam_response) service.get_payload_formatter().string_to_resource(vridparamResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      vridparamArray[0] = resource.vridparam;
      return (base_resource[]) vridparamArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, vridparam resource) => new vridparam()
    {
      sendtomaster = resource.sendtomaster,
      hellointerval = resource.hellointerval,
      deadinterval = resource.deadinterval
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      vridparam resource,
      string[] args)
    {
      return new vridparam().unset_resource(client, args);
    }

    public static vridparam get(nitro_service service) => ((vridparam[]) new vridparam().get_resources(service, (options) null))[0];

    public static vridparam get(nitro_service service, options option) => ((vridparam[]) new vridparam().get_resources(service, option))[0];

    private class vridparam_response : base_response
    {
      public vridparam vridparam = (vridparam) null;
    }

    public static class sendtomasterEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
