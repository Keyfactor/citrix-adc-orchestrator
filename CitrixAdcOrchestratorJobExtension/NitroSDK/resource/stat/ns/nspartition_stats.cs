// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.ns.nspartition_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.ns
{
  public class nspartition_stats : base_resource
  {
    private string partitionnameField = (string) null;
    private string clearstatsField = (string) null;
    private long minbandwidthField = 0;
    private long maxbandwidthField = 0;
    private long maxconnectionField = 0;
    private long maxmemoryField = 0;
    private long currentbandwidthField = 0;
    private long currentconnectionsField = 0;
    private long memoryusagepcntField = 0;
    private long totaldropsField = 0;
    private long dropsrateField = 0;
    private long totaltokendropsField = 0;
    private long tokendropsrateField = 0;
    private long totalconnectiondropsField = 0;
    private long connectiondropsrateField = 0;

    public string partitionname
    {
      get => this.partitionnameField;
      set => this.partitionnameField = value;
    }

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long currentconnections
    {
      get => this.currentconnectionsField;
      private set => this.currentconnectionsField = value;
    }

    public long tokendropsrate
    {
      get => this.tokendropsrateField;
      private set => this.tokendropsrateField = value;
    }

    public long totaltokendrops
    {
      get => this.totaltokendropsField;
      private set => this.totaltokendropsField = value;
    }

    public long maxbandwidth
    {
      get => this.maxbandwidthField;
      private set => this.maxbandwidthField = value;
    }

    public long minbandwidth
    {
      get => this.minbandwidthField;
      private set => this.minbandwidthField = value;
    }

    public long totaldrops
    {
      get => this.totaldropsField;
      private set => this.totaldropsField = value;
    }

    public long connectiondropsrate
    {
      get => this.connectiondropsrateField;
      private set => this.connectiondropsrateField = value;
    }

    public long totalconnectiondrops
    {
      get => this.totalconnectiondropsField;
      private set => this.totalconnectiondropsField = value;
    }

    public long dropsrate
    {
      get => this.dropsrateField;
      private set => this.dropsrateField = value;
    }

    public long currentbandwidth
    {
      get => this.currentbandwidthField;
      private set => this.currentbandwidthField = value;
    }

    public long maxconnection
    {
      get => this.maxconnectionField;
      private set => this.maxconnectionField = value;
    }

    public long maxmemory
    {
      get => this.maxmemoryField;
      private set => this.maxmemoryField = value;
    }

    public long memoryusagepcnt
    {
      get => this.memoryusagepcntField;
      private set => this.memoryusagepcntField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nspartition_stats.nspartition_response nspartitionResponse = new nspartition_stats.nspartition_response();
      nspartition_stats.nspartition_response resource = (nspartition_stats.nspartition_response) service.get_payload_formatter().string_to_resource(nspartitionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nspartition;
    }

    internal override string get_object_name() => this.partitionname;

    public static nspartition_stats[] get(nitro_service service) => (nspartition_stats[]) new nspartition_stats().stat_resources(service, (options) null);

    public static nspartition_stats[] get(nitro_service service, options option) => (nspartition_stats[]) new nspartition_stats().stat_resources(service, option);

    public static nspartition_stats get(
      nitro_service service,
      string partitionname)
    {
      return (nspartition_stats) new nspartition_stats()
      {
        partitionname = partitionname
      }.stat_resource(service);
    }

    private class nspartition_response : base_response
    {
      public nspartition_stats[] nspartition = (nspartition_stats[]) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
