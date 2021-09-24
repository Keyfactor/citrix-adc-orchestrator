// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.pq.pqpolicy_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.pq
{
  public class pqpolicy_stats : base_resource
  {
    private string policynameField = (string) null;
    private string clearstatsField = (string) null;
    private long pqtotavgqueuewaittimeField = 0;
    private long pqavgqueuewaittimerateField = 0;
    private long pqavgclienttransactiontimemsField = 0;
    private long pqavgclienttransactiontimemsrateField = 0;
    private string pqvserveripField = (string) null;
    private ushort pqvserverportField = 0;
    private long pqqdepthField = 0;
    private long pqqdepthrateField = 0;
    private long pqcurrentclientconnectionsField = 0;
    private long pqcurrentclientconnectionsrateField = 0;
    private long pqtotclientconnectionsField = 0;
    private long pqclientconnectionsrateField = 0;
    private long pqdroppedField = 0;
    private long pqdroppedrateField = 0;
    private long totclienttransactionsField = 0;
    private long clienttransactionsrateField = 0;
    private long pqtotqueuedepthField = 0;
    private long pqqueuedepthrateField = 0;

    public string policyname
    {
      get => this.policynameField;
      set => this.policynameField = value;
    }

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public string pqvserverip
    {
      get => this.pqvserveripField;
      private set => this.pqvserveripField = value;
    }

    public long pqqueuedepthrate
    {
      get => this.pqqueuedepthrateField;
      private set => this.pqqueuedepthrateField = value;
    }

    public long pqdroppedrate
    {
      get => this.pqdroppedrateField;
      private set => this.pqdroppedrateField = value;
    }

    public long pqtotqueuedepth
    {
      get => this.pqtotqueuedepthField;
      private set => this.pqtotqueuedepthField = value;
    }

    public ushort pqvserverport
    {
      get => this.pqvserverportField;
      private set => this.pqvserverportField = value;
    }

    public long totclienttransactions
    {
      get => this.totclienttransactionsField;
      private set => this.totclienttransactionsField = value;
    }

    public long clienttransactionsrate
    {
      get => this.clienttransactionsrateField;
      private set => this.clienttransactionsrateField = value;
    }

    public long pqcurrentclientconnectionsrate
    {
      get => this.pqcurrentclientconnectionsrateField;
      private set => this.pqcurrentclientconnectionsrateField = value;
    }

    public long pqqdepthrate
    {
      get => this.pqqdepthrateField;
      private set => this.pqqdepthrateField = value;
    }

    public long pqqdepth
    {
      get => this.pqqdepthField;
      private set => this.pqqdepthField = value;
    }

    public long pqclientconnectionsrate
    {
      get => this.pqclientconnectionsrateField;
      private set => this.pqclientconnectionsrateField = value;
    }

    public long pqavgclienttransactiontimems
    {
      get => this.pqavgclienttransactiontimemsField;
      private set => this.pqavgclienttransactiontimemsField = value;
    }

    public long pqavgclienttransactiontimemsrate
    {
      get => this.pqavgclienttransactiontimemsrateField;
      private set => this.pqavgclienttransactiontimemsrateField = value;
    }

    public long pqtotavgqueuewaittime
    {
      get => this.pqtotavgqueuewaittimeField;
      private set => this.pqtotavgqueuewaittimeField = value;
    }

    public long pqdropped
    {
      get => this.pqdroppedField;
      private set => this.pqdroppedField = value;
    }

    public long pqtotclientconnections
    {
      get => this.pqtotclientconnectionsField;
      private set => this.pqtotclientconnectionsField = value;
    }

    public long pqavgqueuewaittimerate
    {
      get => this.pqavgqueuewaittimerateField;
      private set => this.pqavgqueuewaittimerateField = value;
    }

    public long pqcurrentclientconnections
    {
      get => this.pqcurrentclientconnectionsField;
      private set => this.pqcurrentclientconnectionsField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      pqpolicy_stats.pqpolicy_response pqpolicyResponse = new pqpolicy_stats.pqpolicy_response();
      pqpolicy_stats.pqpolicy_response resource = (pqpolicy_stats.pqpolicy_response) service.get_payload_formatter().string_to_resource(pqpolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.pqpolicy;
    }

    internal override string get_object_name() => this.policyname;

    public static pqpolicy_stats[] get(nitro_service service) => (pqpolicy_stats[]) new pqpolicy_stats().stat_resources(service, (options) null);

    public static pqpolicy_stats[] get(nitro_service service, options option) => (pqpolicy_stats[]) new pqpolicy_stats().stat_resources(service, option);

    public static pqpolicy_stats get(nitro_service service, string policyname) => (pqpolicy_stats) new pqpolicy_stats()
    {
      policyname = policyname
    }.stat_resource(service);

    private class pqpolicy_response : base_response
    {
      public pqpolicy_stats[] pqpolicy = (pqpolicy_stats[]) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
