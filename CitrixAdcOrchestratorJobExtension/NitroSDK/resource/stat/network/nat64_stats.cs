// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.network.nat64_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.network
{
  public class nat64_stats : base_resource
  {
    private string clearstatsField = (string) null;
    private long nat64tottcpsessionsField = 0;
    private long nat64tcpsessionsrateField = 0;
    private long nat64totudpsessionsField = 0;
    private long nat64udpsessionsrateField = 0;
    private long nat64toticmpsessionsField = 0;
    private long nat64icmpsessionsrateField = 0;
    private long nat64totsessionsField = 0;
    private long nat64sessionsrateField = 0;

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long nat64icmpsessionsrate
    {
      get => this.nat64icmpsessionsrateField;
      private set => this.nat64icmpsessionsrateField = value;
    }

    public long nat64toticmpsessions
    {
      get => this.nat64toticmpsessionsField;
      private set => this.nat64toticmpsessionsField = value;
    }

    public long nat64sessionsrate
    {
      get => this.nat64sessionsrateField;
      private set => this.nat64sessionsrateField = value;
    }

    public long nat64totudpsessions
    {
      get => this.nat64totudpsessionsField;
      private set => this.nat64totudpsessionsField = value;
    }

    public long nat64udpsessionsrate
    {
      get => this.nat64udpsessionsrateField;
      private set => this.nat64udpsessionsrateField = value;
    }

    public long nat64tottcpsessions
    {
      get => this.nat64tottcpsessionsField;
      private set => this.nat64tottcpsessionsField = value;
    }

    public long nat64totsessions
    {
      get => this.nat64totsessionsField;
      private set => this.nat64totsessionsField = value;
    }

    public long nat64tcpsessionsrate
    {
      get => this.nat64tcpsessionsrateField;
      private set => this.nat64tcpsessionsrateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nat64_stats[] nat64StatsArray = new nat64_stats[1];
      nat64_stats.nat64_response nat64Response = new nat64_stats.nat64_response();
      nat64_stats.nat64_response resource = (nat64_stats.nat64_response) service.get_payload_formatter().string_to_resource(nat64Response.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      nat64StatsArray[0] = resource.nat64;
      return (base_resource[]) nat64StatsArray;
    }

    internal override string get_object_name() => (string) null;

    public static nat64_stats get(nitro_service service) => ((nat64_stats[]) new nat64_stats().stat_resources(service, (options) null))[0];

    public static nat64_stats get(nitro_service service, options option) => ((nat64_stats[]) new nat64_stats().stat_resources(service, option))[0];

    private class nat64_response : base_response
    {
      public nat64_stats nat64 = (nat64_stats) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
