// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.system.systemcpu_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.system
{
  public class systemcpu_stats : base_resource
  {
    private uint idField = 0;
    private string clearstatsField = (string) null;
    private long percpuuseField = 0;

    public uint id
    {
      get => this.idField;
      set => this.idField = value;
    }

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long percpuuse
    {
      get => this.percpuuseField;
      private set => this.percpuuseField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      systemcpu_stats.systemcpu_response systemcpuResponse = new systemcpu_stats.systemcpu_response();
      systemcpu_stats.systemcpu_response resource = (systemcpu_stats.systemcpu_response) service.get_payload_formatter().string_to_resource(systemcpuResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.systemcpu;
    }

    internal override string get_object_name() => this.id.ToString();

    public static systemcpu_stats[] get(nitro_service service) => (systemcpu_stats[]) new systemcpu_stats().stat_resources(service, (options) null);

    public static systemcpu_stats[] get(nitro_service service, options option) => (systemcpu_stats[]) new systemcpu_stats().stat_resources(service, option);

    public static systemcpu_stats get(nitro_service service, uint id) => (systemcpu_stats) new systemcpu_stats()
    {
      id = id
    }.stat_resource(service);

    private class systemcpu_response : base_response
    {
      public systemcpu_stats[] systemcpu = (systemcpu_stats[]) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
