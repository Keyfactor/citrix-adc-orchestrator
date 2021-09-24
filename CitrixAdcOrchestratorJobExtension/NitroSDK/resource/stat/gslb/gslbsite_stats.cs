// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.gslb.gslbsite_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.gslb
{
  public class gslbsite_stats : base_resource
  {
    private string sitenameField = (string) null;
    private string clearstatsField = (string) null;
    private string sitepublicipField = (string) null;
    private string siteipField = (string) null;
    private string sitemepstatusField = (string) null;
    private string persexchangeField = (string) null;
    private string nwmetricexchangeField = (string) null;
    private string sitemetricexchangeField = (string) null;
    private string sitetypeField = (string) null;
    private string siteipstrField = (string) null;
    private string sitepublicipstrField = (string) null;
    private string sitemetricmepstatusField = (string) null;
    private string nwmetricmepstatusField = (string) null;
    private long sitetotalrequestbytesField = 0;
    private long siterequestbytesrateField = 0;
    private long sitetotalresponsebytesField = 0;
    private long siteresponsebytesrateField = 0;
    private long sitetotalrequestsField = 0;
    private long siterequestsrateField = 0;
    private long sitetotalresponsesField = 0;
    private long siteresponsesrateField = 0;
    private long sitecurclntconnectionsField = 0;
    private long sitecursrvrconnectionsField = 0;

    public string sitename
    {
      get => this.sitenameField;
      set => this.sitenameField = value;
    }

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long siteresponsesrate
    {
      get => this.siteresponsesrateField;
      private set => this.siteresponsesrateField = value;
    }

    public string siteipstr
    {
      get => this.siteipstrField;
      private set => this.siteipstrField = value;
    }

    public long sitetotalrequests
    {
      get => this.sitetotalrequestsField;
      private set => this.sitetotalrequestsField = value;
    }

    public long siterequestsrate
    {
      get => this.siterequestsrateField;
      private set => this.siterequestsrateField = value;
    }

    public string nwmetricmepstatus
    {
      get => this.nwmetricmepstatusField;
      private set => this.nwmetricmepstatusField = value;
    }

    public string sitemetricexchange
    {
      get => this.sitemetricexchangeField;
      private set => this.sitemetricexchangeField = value;
    }

    public string sitepublicip
    {
      get => this.sitepublicipField;
      private set => this.sitepublicipField = value;
    }

    public long sitetotalresponsebytes
    {
      get => this.sitetotalresponsebytesField;
      private set => this.sitetotalresponsebytesField = value;
    }

    public long sitecursrvrconnections
    {
      get => this.sitecursrvrconnectionsField;
      private set => this.sitecursrvrconnectionsField = value;
    }

    public string sitepublicipstr
    {
      get => this.sitepublicipstrField;
      private set => this.sitepublicipstrField = value;
    }

    public long sitetotalrequestbytes
    {
      get => this.sitetotalrequestbytesField;
      private set => this.sitetotalrequestbytesField = value;
    }

    public string siteip
    {
      get => this.siteipField;
      private set => this.siteipField = value;
    }

    public string sitemepstatus
    {
      get => this.sitemepstatusField;
      private set => this.sitemepstatusField = value;
    }

    public long sitecurclntconnections
    {
      get => this.sitecurclntconnectionsField;
      private set => this.sitecurclntconnectionsField = value;
    }

    public string sitetype
    {
      get => this.sitetypeField;
      private set => this.sitetypeField = value;
    }

    public string nwmetricexchange
    {
      get => this.nwmetricexchangeField;
      private set => this.nwmetricexchangeField = value;
    }

    public string persexchange
    {
      get => this.persexchangeField;
      private set => this.persexchangeField = value;
    }

    public long siterequestbytesrate
    {
      get => this.siterequestbytesrateField;
      private set => this.siterequestbytesrateField = value;
    }

    public long siteresponsebytesrate
    {
      get => this.siteresponsebytesrateField;
      private set => this.siteresponsebytesrateField = value;
    }

    public long sitetotalresponses
    {
      get => this.sitetotalresponsesField;
      private set => this.sitetotalresponsesField = value;
    }

    public string sitemetricmepstatus
    {
      get => this.sitemetricmepstatusField;
      private set => this.sitemetricmepstatusField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      gslbsite_stats.gslbsite_response gslbsiteResponse = new gslbsite_stats.gslbsite_response();
      gslbsite_stats.gslbsite_response resource = (gslbsite_stats.gslbsite_response) service.get_payload_formatter().string_to_resource(gslbsiteResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.gslbsite;
    }

    internal override string get_object_name() => this.sitename;

    public static gslbsite_stats[] get(nitro_service service) => (gslbsite_stats[]) new gslbsite_stats().stat_resources(service, (options) null);

    public static gslbsite_stats[] get(nitro_service service, options option) => (gslbsite_stats[]) new gslbsite_stats().stat_resources(service, option);

    public static gslbsite_stats get(nitro_service service, string sitename) => (gslbsite_stats) new gslbsite_stats()
    {
      sitename = sitename
    }.stat_resource(service);

    private class gslbsite_response : base_response
    {
      public gslbsite_stats[] gslbsite = (gslbsite_stats[]) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
