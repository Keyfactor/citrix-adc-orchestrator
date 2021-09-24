// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.dns.dnsparameter
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.dns
{
  public class dnsparameter : base_resource
  {
    private uint? retriesField = new uint?();
    private long? minttlField = new long?();
    private long? maxttlField = new long?();
    private string cacherecordsField = (string) null;
    private string namelookuppriorityField = (string) null;
    private string recursionField = (string) null;
    private string resolutionorderField = (string) null;
    private string dnssecField = (string) null;
    private uint? maxpipelineField = new uint?();
    private string dnsrootreferralField = (string) null;
    private uint? dns64timeoutField = new uint?();

    public uint? retries
    {
      get => this.retriesField;
      set => this.retriesField = value;
    }

    public long? minttl
    {
      get => this.minttlField;
      set => this.minttlField = value;
    }

    public long? maxttl
    {
      get => this.maxttlField;
      set => this.maxttlField = value;
    }

    public string cacherecords
    {
      get => this.cacherecordsField;
      set => this.cacherecordsField = value;
    }

    public string namelookuppriority
    {
      get => this.namelookuppriorityField;
      set => this.namelookuppriorityField = value;
    }

    public string recursion
    {
      get => this.recursionField;
      set => this.recursionField = value;
    }

    public string resolutionorder
    {
      get => this.resolutionorderField;
      set => this.resolutionorderField = value;
    }

    public string dnssec
    {
      get => this.dnssecField;
      set => this.dnssecField = value;
    }

    public uint? maxpipeline
    {
      get => this.maxpipelineField;
      set => this.maxpipelineField = value;
    }

    public string dnsrootreferral
    {
      get => this.dnsrootreferralField;
      set => this.dnsrootreferralField = value;
    }

    public uint? dns64timeout
    {
      get => this.dns64timeoutField;
      set => this.dns64timeoutField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      dnsparameter[] dnsparameterArray = new dnsparameter[1];
      dnsparameter.dnsparameter_response dnsparameterResponse = new dnsparameter.dnsparameter_response();
      dnsparameter.dnsparameter_response resource = (dnsparameter.dnsparameter_response) service.get_payload_formatter().string_to_resource(dnsparameterResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      dnsparameterArray[0] = resource.dnsparameter;
      return (base_resource[]) dnsparameterArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, dnsparameter resource) => new dnsparameter()
    {
      retries = resource.retries,
      minttl = resource.minttl,
      maxttl = resource.maxttl,
      cacherecords = resource.cacherecords,
      namelookuppriority = resource.namelookuppriority,
      recursion = resource.recursion,
      resolutionorder = resource.resolutionorder,
      dnssec = resource.dnssec,
      maxpipeline = resource.maxpipeline,
      dnsrootreferral = resource.dnsrootreferral,
      dns64timeout = resource.dns64timeout
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      dnsparameter resource,
      string[] args)
    {
      return new dnsparameter().unset_resource(client, args);
    }

    public static dnsparameter get(nitro_service service) => ((dnsparameter[]) new dnsparameter().get_resources(service, (options) null))[0];

    public static dnsparameter get(nitro_service service, options option) => ((dnsparameter[]) new dnsparameter().get_resources(service, option))[0];

    private class dnsparameter_response : base_response
    {
      public dnsparameter dnsparameter = (dnsparameter) null;
    }

    public static class cacherecordsEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class recursionEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class resolutionorderEnum
    {
      public const string OnlyAQuery = "OnlyAQuery";
      public const string OnlyAAAAQuery = "OnlyAAAAQuery";
      public const string AThenAAAAQuery = "AThenAAAAQuery";
      public const string AAAAThenAQuery = "AAAAThenAQuery";
    }

    public static class namelookuppriorityEnum
    {
      public const string WINS = "WINS";
      public const string DNS = "DNS";
    }

    public static class dnsrootreferralEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class dnssecEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
