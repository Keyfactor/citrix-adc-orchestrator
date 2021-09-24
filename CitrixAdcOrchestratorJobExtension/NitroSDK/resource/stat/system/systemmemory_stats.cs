// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.system.systemmemory_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.system
{
  public class systemmemory_stats : base_resource
  {
    private string clearstatsField = (string) null;
    private double shmemallocpcntField = 0.0;
    private long shmemallocinmbField = 0;
    private long shmemtotinmbField = 0;
    private long memtotfreeField = 0;
    private double memusagepcntField = 0.0;
    private long memtotuseinmbField = 0;
    private double memtotallocpcntField = 0.0;
    private long memtotallocmbField = 0;
    private long memtotinmbField = 0;
    private long memtotavailField = 0;

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public double memtotallocpcnt
    {
      get => this.memtotallocpcntField;
      private set => this.memtotallocpcntField = value;
    }

    public long memtotfree
    {
      get => this.memtotfreeField;
      private set => this.memtotfreeField = value;
    }

    public double shmemallocpcnt
    {
      get => this.shmemallocpcntField;
      private set => this.shmemallocpcntField = value;
    }

    public long shmemallocinmb
    {
      get => this.shmemallocinmbField;
      private set => this.shmemallocinmbField = value;
    }

    public long memtotuseinmb
    {
      get => this.memtotuseinmbField;
      private set => this.memtotuseinmbField = value;
    }

    public double memusagepcnt
    {
      get => this.memusagepcntField;
      private set => this.memusagepcntField = value;
    }

    public long memtotinmb
    {
      get => this.memtotinmbField;
      private set => this.memtotinmbField = value;
    }

    public long memtotallocmb
    {
      get => this.memtotallocmbField;
      private set => this.memtotallocmbField = value;
    }

    public long memtotavail
    {
      get => this.memtotavailField;
      private set => this.memtotavailField = value;
    }

    public long shmemtotinmb
    {
      get => this.shmemtotinmbField;
      private set => this.shmemtotinmbField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      systemmemory_stats[] systemmemoryStatsArray = new systemmemory_stats[1];
      systemmemory_stats.systemmemory_response systemmemoryResponse = new systemmemory_stats.systemmemory_response();
      systemmemory_stats.systemmemory_response resource = (systemmemory_stats.systemmemory_response) service.get_payload_formatter().string_to_resource(systemmemoryResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      systemmemoryStatsArray[0] = resource.systemmemory;
      return (base_resource[]) systemmemoryStatsArray;
    }

    internal override string get_object_name() => (string) null;

    public static systemmemory_stats get(nitro_service service) => ((systemmemory_stats[]) new systemmemory_stats().stat_resources(service, (options) null))[0];

    public static systemmemory_stats get(nitro_service service, options option) => ((systemmemory_stats[]) new systemmemory_stats().stat_resources(service, option))[0];

    private class systemmemory_response : base_response
    {
      public systemmemory_stats systemmemory = (systemmemory_stats) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
