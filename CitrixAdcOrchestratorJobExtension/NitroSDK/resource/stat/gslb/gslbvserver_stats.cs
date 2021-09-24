// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.gslb.gslbvserver_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.gslb
{
  public class gslbvserver_stats : base_resource
  {
    private string nameField = (string) null;
    private string clearstatsField = (string) null;
    private long establishedconnField = 0;
    private long inactsvcsField = 0;
    private long vslbhealthField = 0;
    private string typeField = (string) null;
    private string stateField = (string) null;
    private long actsvcsField = 0;
    private long tothitsField = 0;
    private long hitsrateField = 0;
    private long totalrequestbytesField = 0;
    private long requestbytesrateField = 0;
    private long totalresponsebytesField = 0;
    private long responsebytesrateField = 0;
    private long sothresholdField = 0;
    private long totspilloversField = 0;
    private long totvserverdownbackuphitsField = 0;
    private long totalrequestsField = 0;
    private long requestsrateField = 0;
    private long totalresponsesField = 0;
    private long responsesrateField = 0;
    private long curclntconnectionsField = 0;
    private long cursrvrconnectionsField = 0;

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

    public long curclntconnections
    {
      get => this.curclntconnectionsField;
      private set => this.curclntconnectionsField = value;
    }

    public long establishedconn
    {
      get => this.establishedconnField;
      private set => this.establishedconnField = value;
    }

    public long tothits
    {
      get => this.tothitsField;
      private set => this.tothitsField = value;
    }

    public long totalrequests
    {
      get => this.totalrequestsField;
      private set => this.totalrequestsField = value;
    }

    public long sothreshold
    {
      get => this.sothresholdField;
      private set => this.sothresholdField = value;
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

    public string type
    {
      get => this.typeField;
      private set => this.typeField = value;
    }

    public long hitsrate
    {
      get => this.hitsrateField;
      private set => this.hitsrateField = value;
    }

    public long cursrvrconnections
    {
      get => this.cursrvrconnectionsField;
      private set => this.cursrvrconnectionsField = value;
    }

    public long responsesrate
    {
      get => this.responsesrateField;
      private set => this.responsesrateField = value;
    }

    public long totspillovers
    {
      get => this.totspilloversField;
      private set => this.totspilloversField = value;
    }

    public long totalrequestbytes
    {
      get => this.totalrequestbytesField;
      private set => this.totalrequestbytesField = value;
    }

    public string state
    {
      get => this.stateField;
      private set => this.stateField = value;
    }

    public long vslbhealth
    {
      get => this.vslbhealthField;
      private set => this.vslbhealthField = value;
    }

    public long actsvcs
    {
      get => this.actsvcsField;
      private set => this.actsvcsField = value;
    }

    public long totalresponsebytes
    {
      get => this.totalresponsebytesField;
      private set => this.totalresponsebytesField = value;
    }

    public long requestsrate
    {
      get => this.requestsrateField;
      private set => this.requestsrateField = value;
    }

    public long totvserverdownbackuphits
    {
      get => this.totvserverdownbackuphitsField;
      private set => this.totvserverdownbackuphitsField = value;
    }

    public long inactsvcs
    {
      get => this.inactsvcsField;
      private set => this.inactsvcsField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      gslbvserver_stats.gslbvserver_response gslbvserverResponse = new gslbvserver_stats.gslbvserver_response();
      gslbvserver_stats.gslbvserver_response resource = (gslbvserver_stats.gslbvserver_response) service.get_payload_formatter().string_to_resource(gslbvserverResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.gslbvserver;
    }

    internal override string get_object_name() => this.name;

    public static gslbvserver_stats[] get(nitro_service service) => (gslbvserver_stats[]) new gslbvserver_stats().stat_resources(service, (options) null);

    public static gslbvserver_stats[] get(nitro_service service, options option) => (gslbvserver_stats[]) new gslbvserver_stats().stat_resources(service, option);

    public static gslbvserver_stats get(nitro_service service, string name) => (gslbvserver_stats) new gslbvserver_stats()
    {
      name = name
    }.stat_resource(service);

    private class gslbvserver_response : base_response
    {
      public gslbvserver_stats[] gslbvserver = (gslbvserver_stats[]) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
