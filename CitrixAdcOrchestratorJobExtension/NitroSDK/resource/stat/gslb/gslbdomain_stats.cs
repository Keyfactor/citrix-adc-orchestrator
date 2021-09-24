// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.gslb.gslbdomain_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.gslb
{
  public class gslbdomain_stats : base_resource
  {
    private string nameField = (string) null;
    private string dnsrecordtypeField = (string) null;
    private string clearstatsField = (string) null;
    private long dnstotalqueriesField = 0;
    private long dnsqueriesrateField = 0;
    private string gslbdnsrectypeField = (string) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

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

    public long dnsqueriesrate
    {
      get => this.dnsqueriesrateField;
      private set => this.dnsqueriesrateField = value;
    }

    public long dnstotalqueries
    {
      get => this.dnstotalqueriesField;
      private set => this.dnstotalqueriesField = value;
    }

    public string gslbdnsrectype
    {
      get => this.gslbdnsrectypeField;
      private set => this.gslbdnsrectypeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      gslbdomain_stats.gslbdomain_response gslbdomainResponse = new gslbdomain_stats.gslbdomain_response();
      gslbdomain_stats.gslbdomain_response resource = (gslbdomain_stats.gslbdomain_response) service.get_payload_formatter().string_to_resource(gslbdomainResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.gslbdomain;
    }

    internal override string get_object_name() => this.name;

    public static gslbdomain_stats[] get(nitro_service service) => (gslbdomain_stats[]) new gslbdomain_stats().stat_resources(service, (options) null);

    public static gslbdomain_stats[] get(nitro_service service, options option) => (gslbdomain_stats[]) new gslbdomain_stats().stat_resources(service, option);

    public static gslbdomain_stats get(nitro_service service, string name) => (gslbdomain_stats) new gslbdomain_stats()
    {
      name = name
    }.stat_resource(service);

    private class gslbdomain_response : base_response
    {
      public gslbdomain_stats[] gslbdomain = (gslbdomain_stats[]) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }

    public static class dnsrecordtypeEnum
    {
      public const string A = "A";
      public const string AAAA = "AAAA";
      public const string CNAME = "CNAME";
      public const string NAPTR = "NAPTR";
    }
  }
}
