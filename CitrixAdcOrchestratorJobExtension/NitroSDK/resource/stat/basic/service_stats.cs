// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.basic.service_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.basic
{
  public class service_stats : base_resource
  {
    private string nameField = (string) null;
    private string clearstatsField = (string) null;
    private long throughputField = 0;
    private long throughputrateField = 0;
    private long avgsvrttfbField = 0;
    private string primaryipaddressField = (string) null;
    private ushort primaryportField = 0;
    private string servicetypeField = (string) null;
    private string stateField = (string) null;
    private long totalrequestsField = 0;
    private long requestsrateField = 0;
    private long totalresponsesField = 0;
    private long responsesrateField = 0;
    private long totalrequestbytesField = 0;
    private long requestbytesrateField = 0;
    private long totalresponsebytesField = 0;
    private long responsebytesrateField = 0;
    private long curclntconnectionsField = 0;
    private long surgecountField = 0;
    private long cursrvrconnectionsField = 0;
    private long svrestablishedconnField = 0;
    private long curreusepoolField = 0;
    private long maxclientsField = 0;
    private long curloadField = 0;
    private long curtflagsField = 0;
    private long vsvrservicehitsField = 0;
    private long vsvrservicehitsrateField = 0;
    private long activetransactionsField = 0;

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

    public long svrestablishedconn
    {
      get => this.svrestablishedconnField;
      private set => this.svrestablishedconnField = value;
    }

    public long curclntconnections
    {
      get => this.curclntconnectionsField;
      private set => this.curclntconnectionsField = value;
    }

    public string servicetype
    {
      get => this.servicetypeField;
      private set => this.servicetypeField = value;
    }

    public long totalrequests
    {
      get => this.totalrequestsField;
      private set => this.totalrequestsField = value;
    }

    public long surgecount
    {
      get => this.surgecountField;
      private set => this.surgecountField = value;
    }

    public long responsebytesrate
    {
      get => this.responsebytesrateField;
      private set => this.responsebytesrateField = value;
    }

    public long totalresponses
    {
      get => this.totalresponsesField;
      private set => this.totalresponsesField = value;
    }

    public long requestbytesrate
    {
      get => this.requestbytesrateField;
      private set => this.requestbytesrateField = value;
    }

    public long throughput
    {
      get => this.throughputField;
      private set => this.throughputField = value;
    }

    public long throughputrate
    {
      get => this.throughputrateField;
      private set => this.throughputrateField = value;
    }

    public long curtflags
    {
      get => this.curtflagsField;
      private set => this.curtflagsField = value;
    }

    public long cursrvrconnections
    {
      get => this.cursrvrconnectionsField;
      private set => this.cursrvrconnectionsField = value;
    }

    public string primaryipaddress
    {
      get => this.primaryipaddressField;
      private set => this.primaryipaddressField = value;
    }

    public long activetransactions
    {
      get => this.activetransactionsField;
      private set => this.activetransactionsField = value;
    }

    public long responsesrate
    {
      get => this.responsesrateField;
      private set => this.responsesrateField = value;
    }

    public long maxclients
    {
      get => this.maxclientsField;
      private set => this.maxclientsField = value;
    }

    public long avgsvrttfb
    {
      get => this.avgsvrttfbField;
      private set => this.avgsvrttfbField = value;
    }

    public long curload
    {
      get => this.curloadField;
      private set => this.curloadField = value;
    }

    public long totalrequestbytes
    {
      get => this.totalrequestbytesField;
      private set => this.totalrequestbytesField = value;
    }

    public long curreusepool
    {
      get => this.curreusepoolField;
      private set => this.curreusepoolField = value;
    }

    public string state
    {
      get => this.stateField;
      private set => this.stateField = value;
    }

    public long vsvrservicehits
    {
      get => this.vsvrservicehitsField;
      private set => this.vsvrservicehitsField = value;
    }

    public long totalresponsebytes
    {
      get => this.totalresponsebytesField;
      private set => this.totalresponsebytesField = value;
    }

    public ushort primaryport
    {
      get => this.primaryportField;
      private set => this.primaryportField = value;
    }

    public long requestsrate
    {
      get => this.requestsrateField;
      private set => this.requestsrateField = value;
    }

    public long vsvrservicehitsrate
    {
      get => this.vsvrservicehitsrateField;
      private set => this.vsvrservicehitsrateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      service_stats.service_response serviceResponse = new service_stats.service_response();
      service_stats.service_response resource = (service_stats.service_response) service.get_payload_formatter().string_to_resource(serviceResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.service;
    }

    internal override string get_object_name() => this.name;

    public static service_stats[] get(nitro_service service) => (service_stats[]) new service_stats().stat_resources(service, (options) null);

    public static service_stats[] get(nitro_service service, options option) => (service_stats[]) new service_stats().stat_resources(service, option);

    public static service_stats get(nitro_service service, string name) => (service_stats) new service_stats()
    {
      name = name
    }.stat_resource(service);

    private class service_response : base_response
    {
      public service_stats[] service = (service_stats[]) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
