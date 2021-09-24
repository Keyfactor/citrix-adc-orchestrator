// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.sc.scpolicy_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.sc
{
  public class scpolicy_stats : base_resource
  {
    private string nameField = (string) null;
    private string clearstatsField = (string) null;
    private long avgservertransactiontimeField = 0;
    private long avgservertransactiontimerateField = 0;
    private long scaverageclientttlbField = 0;
    private long scaverageclientttlbrateField = 0;
    private string scphysicalserviceipField = (string) null;
    private ushort scphysicalserviceportField = 0;
    private long sccurrentclientconnectionsField = 0;
    private long sccurrentclientconnectionsrateField = 0;
    private long sccurrentwaitingclientsField = 0;
    private long sccurrentwaitingclientsrateField = 0;
    private long totopenconnField = 0;
    private long openconnrateField = 0;
    private long sccurrentwaitingtimeField = 0;
    private long sccurrentwaitingtimerateField = 0;
    private long sctotalclientconnectionsField = 0;
    private long scclientconnectionsrateField = 0;
    private long sctotalserverconnectionsField = 0;
    private long scserverconnectionsrateField = 0;
    private long totclienttransactionField = 0;
    private long clienttransactionrateField = 0;
    private long sctotalservertransactionsField = 0;
    private long scservertransactionsrateField = 0;
    private long sctotalrequestsreceivedField = 0;
    private long screquestsreceivedrateField = 0;
    private long sctotalrequestbytesField = 0;
    private long screquestbytesrateField = 0;
    private long sctotalresponsesreceivedField = 0;
    private long scresponsesreceivedrateField = 0;
    private long sctotalresponsebytesField = 0;
    private long scresponsebytesrateField = 0;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long sctotalresponsesreceived
    {
      get => this.sctotalresponsesreceivedField;
      private set => this.sctotalresponsesreceivedField = value;
    }

    public long sccurrentwaitingtime
    {
      get => this.sccurrentwaitingtimeField;
      private set => this.sccurrentwaitingtimeField = value;
    }

    public long clienttransactionrate
    {
      get => this.clienttransactionrateField;
      private set => this.clienttransactionrateField = value;
    }

    public long sccurrentwaitingtimerate
    {
      get => this.sccurrentwaitingtimerateField;
      private set => this.sccurrentwaitingtimerateField = value;
    }

    public long sccurrentwaitingclients
    {
      get => this.sccurrentwaitingclientsField;
      private set => this.sccurrentwaitingclientsField = value;
    }

    public long sctotalrequestsreceived
    {
      get => this.sctotalrequestsreceivedField;
      private set => this.sctotalrequestsreceivedField = value;
    }

    public long screquestsreceivedrate
    {
      get => this.screquestsreceivedrateField;
      private set => this.screquestsreceivedrateField = value;
    }

    public long scresponsebytesrate
    {
      get => this.scresponsebytesrateField;
      private set => this.scresponsebytesrateField = value;
    }

    public long screquestbytesrate
    {
      get => this.screquestbytesrateField;
      private set => this.screquestbytesrateField = value;
    }

    public long sctotalresponsebytes
    {
      get => this.sctotalresponsebytesField;
      private set => this.sctotalresponsebytesField = value;
    }

    public long scserverconnectionsrate
    {
      get => this.scserverconnectionsrateField;
      private set => this.scserverconnectionsrateField = value;
    }

    public long sctotalservertransactions
    {
      get => this.sctotalservertransactionsField;
      private set => this.sctotalservertransactionsField = value;
    }

    public long sccurrentwaitingclientsrate
    {
      get => this.sccurrentwaitingclientsrateField;
      private set => this.sccurrentwaitingclientsrateField = value;
    }

    public long scaverageclientttlb
    {
      get => this.scaverageclientttlbField;
      private set => this.scaverageclientttlbField = value;
    }

    public long avgservertransactiontime
    {
      get => this.avgservertransactiontimeField;
      private set => this.avgservertransactiontimeField = value;
    }

    public string scphysicalserviceip
    {
      get => this.scphysicalserviceipField;
      private set => this.scphysicalserviceipField = value;
    }

    public long sccurrentclientconnectionsrate
    {
      get => this.sccurrentclientconnectionsrateField;
      private set => this.sccurrentclientconnectionsrateField = value;
    }

    public long sccurrentclientconnections
    {
      get => this.sccurrentclientconnectionsField;
      private set => this.sccurrentclientconnectionsField = value;
    }

    public long openconnrate
    {
      get => this.openconnrateField;
      private set => this.openconnrateField = value;
    }

    public long scclientconnectionsrate
    {
      get => this.scclientconnectionsrateField;
      private set => this.scclientconnectionsrateField = value;
    }

    public long scaverageclientttlbrate
    {
      get => this.scaverageclientttlbrateField;
      private set => this.scaverageclientttlbrateField = value;
    }

    public long totclienttransaction
    {
      get => this.totclienttransactionField;
      private set => this.totclienttransactionField = value;
    }

    public long scservertransactionsrate
    {
      get => this.scservertransactionsrateField;
      private set => this.scservertransactionsrateField = value;
    }

    public long sctotalclientconnections
    {
      get => this.sctotalclientconnectionsField;
      private set => this.sctotalclientconnectionsField = value;
    }

    public ushort scphysicalserviceport
    {
      get => this.scphysicalserviceportField;
      private set => this.scphysicalserviceportField = value;
    }

    public long totopenconn
    {
      get => this.totopenconnField;
      private set => this.totopenconnField = value;
    }

    public long avgservertransactiontimerate
    {
      get => this.avgservertransactiontimerateField;
      private set => this.avgservertransactiontimerateField = value;
    }

    public long scresponsesreceivedrate
    {
      get => this.scresponsesreceivedrateField;
      private set => this.scresponsesreceivedrateField = value;
    }

    public long sctotalrequestbytes
    {
      get => this.sctotalrequestbytesField;
      private set => this.sctotalrequestbytesField = value;
    }

    public long sctotalserverconnections
    {
      get => this.sctotalserverconnectionsField;
      private set => this.sctotalserverconnectionsField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      scpolicy_stats.scpolicy_response scpolicyResponse = new scpolicy_stats.scpolicy_response();
      scpolicy_stats.scpolicy_response resource = (scpolicy_stats.scpolicy_response) service.get_payload_formatter().string_to_resource(scpolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.scpolicy;
    }

    internal override string get_object_name() => this.name;

    public static scpolicy_stats[] get(nitro_service service) => (scpolicy_stats[]) new scpolicy_stats().stat_resources(service, (options) null);

    public static scpolicy_stats[] get(nitro_service service, options option) => (scpolicy_stats[]) new scpolicy_stats().stat_resources(service, option);

    public static scpolicy_stats get(nitro_service service, string name) => (scpolicy_stats) new scpolicy_stats()
    {
      name = name
    }.stat_resource(service);

    private class scpolicy_response : base_response
    {
      public scpolicy_stats[] scpolicy = (scpolicy_stats[]) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
