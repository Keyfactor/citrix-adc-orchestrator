// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.appqoe.appqoepolicy_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.appqoe
{
  public class appqoepolicy_stats : base_resource
  {
    private string nameField = (string) null;
    private string clearstatsField = (string) null;
    private long qosavgserverttfbField = 0;
    private long qosavgserverttfbrateField = 0;
    private long qosavgserverttlbField = 0;
    private long qosavgserverttlbrateField = 0;
    private long qosavgclientttlbField = 0;
    private long qosavgclientttlbrateField = 0;
    private long totthroughputField = 0;
    private long throughputrateField = 0;
    private long totsvrlinkedtoField = 0;
    private long svrlinkedtorateField = 0;
    private long totcltrequestsField = 0;
    private long cltrequestsrateField = 0;
    private long totrequestsField = 0;
    private long requestsrateField = 0;
    private long totrequestbytesField = 0;
    private long requestbytesrateField = 0;
    private long totresponseField = 0;
    private long responserateField = 0;
    private long totresponsebytesField = 0;
    private long responsebytesrateField = 0;
    private long totjssentField = 0;
    private long jssentrateField = 0;
    private long totjsbytessentField = 0;
    private long jsbytessentrateField = 0;
    private long pipolicyhitsField = 0;
    private long pipolicyhitsrateField = 0;

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

    public long qosavgclientttlbrate
    {
      get => this.qosavgclientttlbrateField;
      private set => this.qosavgclientttlbrateField = value;
    }

    public long totjssent
    {
      get => this.totjssentField;
      private set => this.totjssentField = value;
    }

    public long responsebytesrate
    {
      get => this.responsebytesrateField;
      private set => this.responsebytesrateField = value;
    }

    public long totthroughput
    {
      get => this.totthroughputField;
      private set => this.totthroughputField = value;
    }

    public long requestbytesrate
    {
      get => this.requestbytesrateField;
      private set => this.requestbytesrateField = value;
    }

    public long totjsbytessent
    {
      get => this.totjsbytessentField;
      private set => this.totjsbytessentField = value;
    }

    public long svrlinkedtorate
    {
      get => this.svrlinkedtorateField;
      private set => this.svrlinkedtorateField = value;
    }

    public long totresponse
    {
      get => this.totresponseField;
      private set => this.totresponseField = value;
    }

    public long totresponsebytes
    {
      get => this.totresponsebytesField;
      private set => this.totresponsebytesField = value;
    }

    public long jssentrate
    {
      get => this.jssentrateField;
      private set => this.jssentrateField = value;
    }

    public long qosavgserverttfbrate
    {
      get => this.qosavgserverttfbrateField;
      private set => this.qosavgserverttfbrateField = value;
    }

    public long pipolicyhits
    {
      get => this.pipolicyhitsField;
      private set => this.pipolicyhitsField = value;
    }

    public long qosavgclientttlb
    {
      get => this.qosavgclientttlbField;
      private set => this.qosavgclientttlbField = value;
    }

    public long totcltrequests
    {
      get => this.totcltrequestsField;
      private set => this.totcltrequestsField = value;
    }

    public long totrequests
    {
      get => this.totrequestsField;
      private set => this.totrequestsField = value;
    }

    public long qosavgserverttlbrate
    {
      get => this.qosavgserverttlbrateField;
      private set => this.qosavgserverttlbrateField = value;
    }

    public long totrequestbytes
    {
      get => this.totrequestbytesField;
      private set => this.totrequestbytesField = value;
    }

    public long cltrequestsrate
    {
      get => this.cltrequestsrateField;
      private set => this.cltrequestsrateField = value;
    }

    public long throughputrate
    {
      get => this.throughputrateField;
      private set => this.throughputrateField = value;
    }

    public long totsvrlinkedto
    {
      get => this.totsvrlinkedtoField;
      private set => this.totsvrlinkedtoField = value;
    }

    public long qosavgserverttfb
    {
      get => this.qosavgserverttfbField;
      private set => this.qosavgserverttfbField = value;
    }

    public long pipolicyhitsrate
    {
      get => this.pipolicyhitsrateField;
      private set => this.pipolicyhitsrateField = value;
    }

    public long jsbytessentrate
    {
      get => this.jsbytessentrateField;
      private set => this.jsbytessentrateField = value;
    }

    public long responserate
    {
      get => this.responserateField;
      private set => this.responserateField = value;
    }

    public long requestsrate
    {
      get => this.requestsrateField;
      private set => this.requestsrateField = value;
    }

    public long qosavgserverttlb
    {
      get => this.qosavgserverttlbField;
      private set => this.qosavgserverttlbField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      appqoepolicy_stats.appqoepolicy_response appqoepolicyResponse = new appqoepolicy_stats.appqoepolicy_response();
      appqoepolicy_stats.appqoepolicy_response resource = (appqoepolicy_stats.appqoepolicy_response) service.get_payload_formatter().string_to_resource(appqoepolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.appqoepolicy;
    }

    internal override string get_object_name() => this.name;

    public static appqoepolicy_stats[] get(nitro_service service) => (appqoepolicy_stats[]) new appqoepolicy_stats().stat_resources(service, (options) null);

    public static appqoepolicy_stats[] get(nitro_service service, options option) => (appqoepolicy_stats[]) new appqoepolicy_stats().stat_resources(service, option);

    public static appqoepolicy_stats get(nitro_service service, string name) => (appqoepolicy_stats) new appqoepolicy_stats()
    {
      name = name
    }.stat_resource(service);

    private class appqoepolicy_response : base_response
    {
      public appqoepolicy_stats[] appqoepolicy = (appqoepolicy_stats[]) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
