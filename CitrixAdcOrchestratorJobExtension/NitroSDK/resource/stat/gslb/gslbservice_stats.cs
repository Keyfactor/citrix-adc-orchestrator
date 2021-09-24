// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.gslb.gslbservice_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.gslb
{
  public class gslbservice_stats : base_resource
  {
    private string servicenameField = (string) null;
    private string clearstatsField = (string) null;
    private long establishedconnField = 0;
    private string primaryipaddressField = (string) null;
    private ushort primaryportField = 0;
    private string servicetypeField = (string) null;
    private string stateField = (string) null;
    private long totalrequestbytesField = 0;
    private long requestbytesrateField = 0;
    private long totalresponsebytesField = 0;
    private long responsebytesrateField = 0;
    private long curloadField = 0;
    private long totalrequestsField = 0;
    private long requestsrateField = 0;
    private long totalresponsesField = 0;
    private long responsesrateField = 0;
    private long curclntconnectionsField = 0;
    private long cursrvrconnectionsField = 0;
    private long vsvrservicehitsField = 0;
    private long vsvrservicehitsrateField = 0;

    public string servicename
    {
      get => this.servicenameField;
      set => this.servicenameField = value;
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

    public string servicetype
    {
      get => this.servicetypeField;
      private set => this.servicetypeField = value;
    }

    public long establishedconn
    {
      get => this.establishedconnField;
      private set => this.establishedconnField = value;
    }

    public long totalrequests
    {
      get => this.totalrequestsField;
      private set => this.totalrequestsField = value;
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

    public long responsesrate
    {
      get => this.responsesrateField;
      private set => this.responsesrateField = value;
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
      gslbservice_stats.gslbservice_response gslbserviceResponse = new gslbservice_stats.gslbservice_response();
      gslbservice_stats.gslbservice_response resource = (gslbservice_stats.gslbservice_response) service.get_payload_formatter().string_to_resource(gslbserviceResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.gslbservice;
    }

    internal override string get_object_name() => this.servicename;

    public static gslbservice_stats[] get(nitro_service service) => (gslbservice_stats[]) new gslbservice_stats().stat_resources(service, (options) null);

    public static gslbservice_stats[] get(nitro_service service, options option) => (gslbservice_stats[]) new gslbservice_stats().stat_resources(service, option);

    public static gslbservice_stats get(nitro_service service, string servicename) => (gslbservice_stats) new gslbservice_stats()
    {
      servicename = servicename
    }.stat_resource(service);

    private class gslbservice_response : base_response
    {
      public gslbservice_stats[] gslbservice = (gslbservice_stats[]) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
