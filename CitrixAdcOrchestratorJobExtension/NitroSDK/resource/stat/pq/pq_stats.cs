// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.pq.pq_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.pq
{
  public class pq_stats : base_resource
  {
    private string clearstatsField = (string) null;
    private long pqtotalpolicymatchesField = 0;
    private long pqpolicymatchesrateField = 0;
    private long pqtotalthresholdfailedField = 0;
    private long pqthresholdfailedrateField = 0;
    private long pqpriority1requestsField = 0;
    private long pqpriority1requestsrateField = 0;
    private long pqpriority2requestsField = 0;
    private long pqpriority2requestsrateField = 0;
    private long pqpriority3requestsField = 0;
    private long pqpriority3requestsrateField = 0;

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long pqpriority2requestsrate
    {
      get => this.pqpriority2requestsrateField;
      private set => this.pqpriority2requestsrateField = value;
    }

    public long pqpolicymatchesrate
    {
      get => this.pqpolicymatchesrateField;
      private set => this.pqpolicymatchesrateField = value;
    }

    public long pqpriority1requestsrate
    {
      get => this.pqpriority1requestsrateField;
      private set => this.pqpriority1requestsrateField = value;
    }

    public long pqthresholdfailedrate
    {
      get => this.pqthresholdfailedrateField;
      private set => this.pqthresholdfailedrateField = value;
    }

    public long pqtotalpolicymatches
    {
      get => this.pqtotalpolicymatchesField;
      private set => this.pqtotalpolicymatchesField = value;
    }

    public long pqpriority1requests
    {
      get => this.pqpriority1requestsField;
      private set => this.pqpriority1requestsField = value;
    }

    public long pqpriority3requestsrate
    {
      get => this.pqpriority3requestsrateField;
      private set => this.pqpriority3requestsrateField = value;
    }

    public long pqpriority3requests
    {
      get => this.pqpriority3requestsField;
      private set => this.pqpriority3requestsField = value;
    }

    public long pqpriority2requests
    {
      get => this.pqpriority2requestsField;
      private set => this.pqpriority2requestsField = value;
    }

    public long pqtotalthresholdfailed
    {
      get => this.pqtotalthresholdfailedField;
      private set => this.pqtotalthresholdfailedField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      pq_stats[] pqStatsArray = new pq_stats[1];
      pq_stats.pq_response pqResponse = new pq_stats.pq_response();
      pq_stats.pq_response resource = (pq_stats.pq_response) service.get_payload_formatter().string_to_resource(pqResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      pqStatsArray[0] = resource.pq;
      return (base_resource[]) pqStatsArray;
    }

    internal override string get_object_name() => (string) null;

    public static pq_stats get(nitro_service service) => ((pq_stats[]) new pq_stats().stat_resources(service, (options) null))[0];

    public static pq_stats get(nitro_service service, options option) => ((pq_stats[]) new pq_stats().stat_resources(service, option))[0];

    private class pq_response : base_response
    {
      public pq_stats pq = (pq_stats) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
