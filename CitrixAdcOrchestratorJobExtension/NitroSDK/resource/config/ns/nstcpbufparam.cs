// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nstcpbufparam
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nstcpbufparam : base_resource
  {
    private long? sizeField = new long?();
    private long? memlimitField = new long?();

    public long? size
    {
      get => this.sizeField;
      set => this.sizeField = value;
    }

    public long? memlimit
    {
      get => this.memlimitField;
      set => this.memlimitField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nstcpbufparam[] nstcpbufparamArray = new nstcpbufparam[1];
      nstcpbufparam.nstcpbufparam_response nstcpbufparamResponse = new nstcpbufparam.nstcpbufparam_response();
      nstcpbufparam.nstcpbufparam_response resource = (nstcpbufparam.nstcpbufparam_response) service.get_payload_formatter().string_to_resource(nstcpbufparamResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      nstcpbufparamArray[0] = resource.nstcpbufparam;
      return (base_resource[]) nstcpbufparamArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, nstcpbufparam resource) => new nstcpbufparam()
    {
      size = resource.size,
      memlimit = resource.memlimit
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      nstcpbufparam resource,
      string[] args)
    {
      return new nstcpbufparam().unset_resource(client, args);
    }

    public static nstcpbufparam get(nitro_service service) => ((nstcpbufparam[]) new nstcpbufparam().get_resources(service, (options) null))[0];

    public static nstcpbufparam get(nitro_service service, options option) => ((nstcpbufparam[]) new nstcpbufparam().get_resources(service, option))[0];

    private class nstcpbufparam_response : base_response
    {
      public nstcpbufparam nstcpbufparam = (nstcpbufparam) null;
    }
  }
}
