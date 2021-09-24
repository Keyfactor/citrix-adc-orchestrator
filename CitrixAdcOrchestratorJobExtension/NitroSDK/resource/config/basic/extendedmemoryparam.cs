// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.basic.extendedmemoryparam
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.basic
{
  public class extendedmemoryparam : base_resource
  {
    private long? memlimitField = new long?();
    private long? memlimitactiveField = new long?();
    private long? maxmemlimitField = new long?();
    private long? minrequiredmemoryField = new long?();

    public long? memlimit
    {
      get => this.memlimitField;
      set => this.memlimitField = value;
    }

    public long? memlimitactive
    {
      get => this.memlimitactiveField;
      private set => this.memlimitactiveField = value;
    }

    public long? maxmemlimit
    {
      get => this.maxmemlimitField;
      private set => this.maxmemlimitField = value;
    }

    public long? minrequiredmemory
    {
      get => this.minrequiredmemoryField;
      private set => this.minrequiredmemoryField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      extendedmemoryparam[] extendedmemoryparamArray = new extendedmemoryparam[1];
      extendedmemoryparam.extendedmemoryparam_response extendedmemoryparamResponse = new extendedmemoryparam.extendedmemoryparam_response();
      extendedmemoryparam.extendedmemoryparam_response resource = (extendedmemoryparam.extendedmemoryparam_response) service.get_payload_formatter().string_to_resource(extendedmemoryparamResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      extendedmemoryparamArray[0] = resource.extendedmemoryparam;
      return (base_resource[]) extendedmemoryparamArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(
      nitro_service client,
      extendedmemoryparam resource)
    {
      return new extendedmemoryparam()
      {
        memlimit = resource.memlimit
      }.update_resource(client);
    }

    public static base_response unset(
      nitro_service client,
      extendedmemoryparam resource,
      string[] args)
    {
      return new extendedmemoryparam().unset_resource(client, args);
    }

    public static extendedmemoryparam get(nitro_service service) => ((extendedmemoryparam[]) new extendedmemoryparam().get_resources(service, (options) null))[0];

    public static extendedmemoryparam get(nitro_service service, options option) => ((extendedmemoryparam[]) new extendedmemoryparam().get_resources(service, option))[0];

    private class extendedmemoryparam_response : base_response
    {
      public extendedmemoryparam extendedmemoryparam = (extendedmemoryparam) null;
    }
  }
}
