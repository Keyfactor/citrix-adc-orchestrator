// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.ns.nsmemory_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.ns
{
  public class nsmemory_stats : base_resource
  {
    private string poolField = (string) null;
    private string clearstatsField = (string) null;
    private double allocfField = 0.0;
    private double memcurallocperField = 0.0;
    private long memcurinkbField = 0;

    public string pool
    {
      get => this.poolField;
      set => this.poolField = value;
    }

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long memcurinkb
    {
      get => this.memcurinkbField;
      private set => this.memcurinkbField = value;
    }

    public double allocf
    {
      get => this.allocfField;
      private set => this.allocfField = value;
    }

    public double memcurallocper
    {
      get => this.memcurallocperField;
      private set => this.memcurallocperField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nsmemory_stats.nsmemory_response nsmemoryResponse = new nsmemory_stats.nsmemory_response();
      nsmemory_stats.nsmemory_response resource = (nsmemory_stats.nsmemory_response) service.get_payload_formatter().string_to_resource(nsmemoryResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nsmemory;
    }

    internal override string get_object_name() => this.pool;

    public static nsmemory_stats[] get(nitro_service service) => (nsmemory_stats[]) new nsmemory_stats().stat_resources(service, (options) null);

    public static nsmemory_stats[] get(nitro_service service, options option) => (nsmemory_stats[]) new nsmemory_stats().stat_resources(service, option);

    public static nsmemory_stats get(nitro_service service, string pool) => (nsmemory_stats) new nsmemory_stats()
    {
      pool = pool
    }.stat_resource(service);

    private class nsmemory_response : base_response
    {
      public nsmemory_stats[] nsmemory = (nsmemory_stats[]) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
