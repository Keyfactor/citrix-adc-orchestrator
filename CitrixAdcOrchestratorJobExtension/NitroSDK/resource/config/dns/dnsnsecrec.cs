// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.dns.dnsnsecrec
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.dns
{
  public class dnsnsecrec : base_resource
  {
    private string hostnameField = (string) null;
    private string typeField = (string) null;
    private string nextnsecField = (string) null;
    private string[] nextrecsField = (string[]) null;
    private long? ttlField = new long?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string hostname
    {
      get => this.hostnameField;
      set => this.hostnameField = value;
    }

    public string type
    {
      get => this.typeField;
      set => this.typeField = value;
    }

    public string nextnsec
    {
      get => this.nextnsecField;
      private set => this.nextnsecField = value;
    }

    public string[] nextrecs
    {
      get => this.nextrecsField;
      private set => this.nextrecsField = value;
    }

    public long? ttl
    {
      get => this.ttlField;
      private set => this.ttlField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      dnsnsecrec.dnsnsecrec_response dnsnsecrecResponse = new dnsnsecrec.dnsnsecrec_response();
      dnsnsecrec.dnsnsecrec_response resource = (dnsnsecrec.dnsnsecrec_response) service.get_payload_formatter().string_to_resource(dnsnsecrecResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.dnsnsecrec;
    }

    internal override string get_object_name() => this.hostname;

    public static dnsnsecrec[] get(nitro_service service) => (dnsnsecrec[]) new dnsnsecrec().get_resources(service, (options) null);

    public static dnsnsecrec[] get(nitro_service service, options option) => (dnsnsecrec[]) new dnsnsecrec().get_resources(service, option);

    public static dnsnsecrec[] get(nitro_service service, dnsnsecrec_args args)
    {
      dnsnsecrec dnsnsecrec = new dnsnsecrec();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (dnsnsecrec[]) dnsnsecrec.get_resources(service, option);
    }

    public static dnsnsecrec get(nitro_service service, string hostname) => (dnsnsecrec) new dnsnsecrec()
    {
      hostname = hostname
    }.get_resource(service);

    public static dnsnsecrec[] get(nitro_service service, string[] hostname)
    {
      if (hostname == null || hostname.Length <= 0)
        return (dnsnsecrec[]) null;
      dnsnsecrec[] dnsnsecrecArray1 = new dnsnsecrec[hostname.Length];
      dnsnsecrec[] dnsnsecrecArray2 = new dnsnsecrec[hostname.Length];
      for (int index = 0; index < hostname.Length; ++index)
      {
        dnsnsecrecArray2[index] = new dnsnsecrec();
        dnsnsecrecArray2[index].hostname = hostname[index];
        dnsnsecrecArray1[index] = (dnsnsecrec) dnsnsecrecArray2[index].get_resource(service);
      }
      return dnsnsecrecArray1;
    }

    public static dnsnsecrec[] get_filtered(nitro_service service, string filter)
    {
      dnsnsecrec dnsnsecrec = new dnsnsecrec();
      options option = new options();
      option.set_filter(filter);
      return (dnsnsecrec[]) dnsnsecrec.getfiltered(service, option);
    }

    public static dnsnsecrec[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      dnsnsecrec dnsnsecrec = new dnsnsecrec();
      options option = new options();
      option.set_filter(filter);
      return (dnsnsecrec[]) dnsnsecrec.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      dnsnsecrec dnsnsecrec = new dnsnsecrec();
      options option = new options();
      option.set_count(true);
      dnsnsecrec[] resources = (dnsnsecrec[]) dnsnsecrec.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      dnsnsecrec dnsnsecrec = new dnsnsecrec();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnsnsecrec[] dnsnsecrecArray = (dnsnsecrec[]) dnsnsecrec.getfiltered(service, option);
      return dnsnsecrecArray != null && dnsnsecrecArray.Length > 0 ? dnsnsecrecArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      dnsnsecrec dnsnsecrec = new dnsnsecrec();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnsnsecrec[] dnsnsecrecArray = (dnsnsecrec[]) dnsnsecrec.getfiltered(service, option);
      return dnsnsecrecArray != null && dnsnsecrecArray.Length > 0 ? dnsnsecrecArray[0].__count.Value : 0U;
    }

    private class dnsnsecrec_response : base_response
    {
      public dnsnsecrec[] dnsnsecrec = (dnsnsecrec[]) null;
    }

    public static class typeEnum
    {
      public const string ALL = "ALL";
      public const string ADNS = "ADNS";
      public const string PROXY = "PROXY";
    }

    public static class nextrecsEnum
    {
      public const string A = "A";
      public const string NS = "NS";
      public const string CNAME = "CNAME";
      public const string SOA = "SOA";
      public const string MX = "MX";
      public const string AAAA = "AAAA";
      public const string SRV = "SRV";
      public const string RRSIG = "RRSIG";
      public const string NSEC = "NSEC";
      public const string DNSKEY = "DNSKEY";
      public const string PTR = "PTR";
      public const string TXT = "TXT";
      public const string NAPTR = "NAPTR";
    }
  }
}
