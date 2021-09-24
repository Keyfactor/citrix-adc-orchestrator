// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.lldp.lldp_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.lldp
{
  public class lldp_stats : base_resource
  {
    private string ifnumField = (string) null;
    private string clearstatsField = (string) null;
    private long rxportframestotalField = 0;
    private long rxportframesrateField = 0;
    private long rxportbytestotalField = 0;
    private long rxportbytesrateField = 0;
    private long txportframestotalField = 0;
    private long txportframesrateField = 0;
    private long txportbytestotalField = 0;
    private long txportbytesrateField = 0;
    private long rxportframeserrorsField = 0;
    private long rxportframeserrorsrateField = 0;
    private long rxporttlvsdiscardedtotalField = 0;
    private long rxporttlvsdiscardedrateField = 0;
    private long rxporttlvsunrecognizedtotalField = 0;
    private long rxporttlvsunrecognizedrateField = 0;

    public string ifnum
    {
      get => this.ifnumField;
      set => this.ifnumField = value;
    }

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long rxporttlvsdiscardedtotal
    {
      get => this.rxporttlvsdiscardedtotalField;
      private set => this.rxporttlvsdiscardedtotalField = value;
    }

    public long rxportframeserrors
    {
      get => this.rxportframeserrorsField;
      private set => this.rxportframeserrorsField = value;
    }

    public long rxportframeserrorsrate
    {
      get => this.rxportframeserrorsrateField;
      private set => this.rxportframeserrorsrateField = value;
    }

    public long rxportframestotal
    {
      get => this.rxportframestotalField;
      private set => this.rxportframestotalField = value;
    }

    public long txportbytestotal
    {
      get => this.txportbytestotalField;
      private set => this.txportbytestotalField = value;
    }

    public long txportframestotal
    {
      get => this.txportframestotalField;
      private set => this.txportframestotalField = value;
    }

    public long rxporttlvsunrecognizedtotal
    {
      get => this.rxporttlvsunrecognizedtotalField;
      private set => this.rxporttlvsunrecognizedtotalField = value;
    }

    public long rxportbytesrate
    {
      get => this.rxportbytesrateField;
      private set => this.rxportbytesrateField = value;
    }

    public long rxportbytestotal
    {
      get => this.rxportbytestotalField;
      private set => this.rxportbytestotalField = value;
    }

    public long rxporttlvsdiscardedrate
    {
      get => this.rxporttlvsdiscardedrateField;
      private set => this.rxporttlvsdiscardedrateField = value;
    }

    public long txportbytesrate
    {
      get => this.txportbytesrateField;
      private set => this.txportbytesrateField = value;
    }

    public long rxporttlvsunrecognizedrate
    {
      get => this.rxporttlvsunrecognizedrateField;
      private set => this.rxporttlvsunrecognizedrateField = value;
    }

    public long rxportframesrate
    {
      get => this.rxportframesrateField;
      private set => this.rxportframesrateField = value;
    }

    public long txportframesrate
    {
      get => this.txportframesrateField;
      private set => this.txportframesrateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lldp_stats.lldp_response lldpResponse = new lldp_stats.lldp_response();
      lldp_stats.lldp_response resource = (lldp_stats.lldp_response) service.get_payload_formatter().string_to_resource(lldpResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lldp;
    }

    internal override string get_object_name() => this.ifnum;

    public static lldp_stats[] get(nitro_service service) => (lldp_stats[]) new lldp_stats().stat_resources(service, (options) null);

    public static lldp_stats[] get(nitro_service service, options option) => (lldp_stats[]) new lldp_stats().stat_resources(service, option);

    public static lldp_stats get(nitro_service service, string ifnum) => (lldp_stats) new lldp_stats()
    {
      ifnum = ifnum
    }.stat_resource(service);

    private class lldp_response : base_response
    {
      public lldp_stats[] lldp = (lldp_stats[]) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
