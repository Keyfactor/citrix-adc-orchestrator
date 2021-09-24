// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.network.bridge_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.network
{
  public class bridge_stats : base_resource
  {
    private string clearstatsField = (string) null;
    private long tcptotbdgmacmovedField = 0;
    private long tcpbdgmacmovedrateField = 0;
    private long tcptotbdgcollisionsField = 0;
    private long tcpbdgcollisionsrateField = 0;
    private long tcperrbdgmutedField = 0;
    private long tcperrbdgmutedrateField = 0;
    private long totbdgpktsField = 0;
    private long bdgpktsrateField = 0;
    private long totbdgmbitsField = 0;
    private long bdgmbitsrateField = 0;

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long bdgpktsrate
    {
      get => this.bdgpktsrateField;
      private set => this.bdgpktsrateField = value;
    }

    public long totbdgmbits
    {
      get => this.totbdgmbitsField;
      private set => this.totbdgmbitsField = value;
    }

    public long bdgmbitsrate
    {
      get => this.bdgmbitsrateField;
      private set => this.bdgmbitsrateField = value;
    }

    public long totbdgpkts
    {
      get => this.totbdgpktsField;
      private set => this.totbdgpktsField = value;
    }

    public long tcperrbdgmuted
    {
      get => this.tcperrbdgmutedField;
      private set => this.tcperrbdgmutedField = value;
    }

    public long tcpbdgcollisionsrate
    {
      get => this.tcpbdgcollisionsrateField;
      private set => this.tcpbdgcollisionsrateField = value;
    }

    public long tcptotbdgcollisions
    {
      get => this.tcptotbdgcollisionsField;
      private set => this.tcptotbdgcollisionsField = value;
    }

    public long tcperrbdgmutedrate
    {
      get => this.tcperrbdgmutedrateField;
      private set => this.tcperrbdgmutedrateField = value;
    }

    public long tcpbdgmacmovedrate
    {
      get => this.tcpbdgmacmovedrateField;
      private set => this.tcpbdgmacmovedrateField = value;
    }

    public long tcptotbdgmacmoved
    {
      get => this.tcptotbdgmacmovedField;
      private set => this.tcptotbdgmacmovedField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      bridge_stats[] bridgeStatsArray = new bridge_stats[1];
      bridge_stats.bridge_response bridgeResponse = new bridge_stats.bridge_response();
      bridge_stats.bridge_response resource = (bridge_stats.bridge_response) service.get_payload_formatter().string_to_resource(bridgeResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      bridgeStatsArray[0] = resource.bridge;
      return (base_resource[]) bridgeStatsArray;
    }

    internal override string get_object_name() => (string) null;

    public static bridge_stats get(nitro_service service) => ((bridge_stats[]) new bridge_stats().stat_resources(service, (options) null))[0];

    public static bridge_stats get(nitro_service service, options option) => ((bridge_stats[]) new bridge_stats().stat_resources(service, option))[0];

    private class bridge_response : base_response
    {
      public bridge_stats bridge = (bridge_stats) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
