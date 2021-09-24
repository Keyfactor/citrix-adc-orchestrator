// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.ha.hanode_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.ha
{
  public class hanode_stats : base_resource
  {
    private string clearstatsField = (string) null;
    private string hacurstatusField = (string) null;
    private string hacurstateField = (string) null;
    private string hacurmasterstateField = (string) null;
    private string transtimeField = (string) null;
    private long hatotpktrxField = 0;
    private long hapktrxrateField = 0;
    private long hatotpkttxField = 0;
    private long hapkttxrateField = 0;
    private long haerrproptimeoutField = 0;
    private long haerrsyncfailureField = 0;

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long haerrsyncfailure
    {
      get => this.haerrsyncfailureField;
      private set => this.haerrsyncfailureField = value;
    }

    public string transtime
    {
      get => this.transtimeField;
      private set => this.transtimeField = value;
    }

    public string hacurstatus
    {
      get => this.hacurstatusField;
      private set => this.hacurstatusField = value;
    }

    public string hacurmasterstate
    {
      get => this.hacurmasterstateField;
      private set => this.hacurmasterstateField = value;
    }

    public long hatotpkttx
    {
      get => this.hatotpkttxField;
      private set => this.hatotpkttxField = value;
    }

    public long hapktrxrate
    {
      get => this.hapktrxrateField;
      private set => this.hapktrxrateField = value;
    }

    public long haerrproptimeout
    {
      get => this.haerrproptimeoutField;
      private set => this.haerrproptimeoutField = value;
    }

    public long hapkttxrate
    {
      get => this.hapkttxrateField;
      private set => this.hapkttxrateField = value;
    }

    public string hacurstate
    {
      get => this.hacurstateField;
      private set => this.hacurstateField = value;
    }

    public long hatotpktrx
    {
      get => this.hatotpktrxField;
      private set => this.hatotpktrxField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      hanode_stats[] hanodeStatsArray = new hanode_stats[1];
      hanode_stats.hanode_response hanodeResponse = new hanode_stats.hanode_response();
      hanode_stats.hanode_response resource = (hanode_stats.hanode_response) service.get_payload_formatter().string_to_resource(hanodeResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      hanodeStatsArray[0] = resource.hanode;
      return (base_resource[]) hanodeStatsArray;
    }

    internal override string get_object_name() => (string) null;

    public static hanode_stats get(nitro_service service) => ((hanode_stats[]) new hanode_stats().stat_resources(service, (options) null))[0];

    public static hanode_stats get(nitro_service service, options option) => ((hanode_stats[]) new hanode_stats().stat_resources(service, option))[0];

    private class hanode_response : base_response
    {
      public hanode_stats hanode = (hanode_stats) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
