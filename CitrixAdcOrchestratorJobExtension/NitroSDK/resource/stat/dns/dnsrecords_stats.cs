// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.dns.dnsrecords_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.dns
{
  public class dnsrecords_stats : base_resource
  {
    private string dnsrecordtypeField = (string) null;
    private string clearstatsField = (string) null;
    private long dnstotentriesField = 0;
    private long dnstotupdatesField = 0;
    private long dnstotresponsesField = 0;
    private long dnstotrequestsField = 0;
    private long dnscurentriesField = 0;
    private long dnstoterrlimitsField = 0;
    private long dnstoterrrespformField = 0;
    private long dnstoterraliasexField = 0;
    private long dnstoterrnodomainsField = 0;
    private long dnscurrecordsField = 0;

    public string dnsrecordtype
    {
      get => this.dnsrecordtypeField;
      set => this.dnsrecordtypeField = value;
    }

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long dnscurentries
    {
      get => this.dnscurentriesField;
      private set => this.dnscurentriesField = value;
    }

    public long dnstotupdates
    {
      get => this.dnstotupdatesField;
      private set => this.dnstotupdatesField = value;
    }

    public long dnstotrequests
    {
      get => this.dnstotrequestsField;
      private set => this.dnstotrequestsField = value;
    }

    public long dnstoterraliasex
    {
      get => this.dnstoterraliasexField;
      private set => this.dnstoterraliasexField = value;
    }

    public long dnstoterrrespform
    {
      get => this.dnstoterrrespformField;
      private set => this.dnstoterrrespformField = value;
    }

    public long dnstotentries
    {
      get => this.dnstotentriesField;
      private set => this.dnstotentriesField = value;
    }

    public long dnscurrecords
    {
      get => this.dnscurrecordsField;
      private set => this.dnscurrecordsField = value;
    }

    public long dnstoterrnodomains
    {
      get => this.dnstoterrnodomainsField;
      private set => this.dnstoterrnodomainsField = value;
    }

    public long dnstoterrlimits
    {
      get => this.dnstoterrlimitsField;
      private set => this.dnstoterrlimitsField = value;
    }

    public long dnstotresponses
    {
      get => this.dnstotresponsesField;
      private set => this.dnstotresponsesField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      dnsrecords_stats.dnsrecords_response dnsrecordsResponse = new dnsrecords_stats.dnsrecords_response();
      dnsrecords_stats.dnsrecords_response resource = (dnsrecords_stats.dnsrecords_response) service.get_payload_formatter().string_to_resource(dnsrecordsResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.dnsrecords;
    }

    internal override string get_object_name() => this.dnsrecordtype;

    public static dnsrecords_stats[] get(nitro_service service) => (dnsrecords_stats[]) new dnsrecords_stats().stat_resources(service, (options) null);

    public static dnsrecords_stats[] get(nitro_service service, options option) => (dnsrecords_stats[]) new dnsrecords_stats().stat_resources(service, option);

    public static dnsrecords_stats get(nitro_service service, string dnsrecordtype) => (dnsrecords_stats) new dnsrecords_stats()
    {
      dnsrecordtype = dnsrecordtype
    }.stat_resource(service);

    private class dnsrecords_response : base_response
    {
      public dnsrecords_stats[] dnsrecords = (dnsrecords_stats[]) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
