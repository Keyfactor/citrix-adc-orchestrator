// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.aaa.aaa_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.aaa
{
  public class aaa_stats : base_resource
  {
    private string clearstatsField = (string) null;
    private long aaaauthsuccessField = 0;
    private long aaaauthsuccessrateField = 0;
    private long aaaauthfailField = 0;
    private long aaaauthfailrateField = 0;
    private long aaaauthonlyhttpsuccessField = 0;
    private long aaaauthonlyhttpsuccessrateField = 0;
    private long aaaauthonlyhttpfailField = 0;
    private long aaaauthonlyhttpfailrateField = 0;
    private long aaaauthnonhttpsuccessField = 0;
    private long aaaauthnonhttpsuccessrateField = 0;
    private long aaaauthnonhttpfailField = 0;
    private long aaaauthnonhttpfailrateField = 0;
    private long aaacursessionsField = 0;
    private long aaacursessionsrateField = 0;
    private long aaatotsessionsField = 0;
    private long aaasessionsrateField = 0;
    private long aaatotsessiontimeoutField = 0;
    private long aaasessiontimeoutrateField = 0;
    private long aaacuricasessionsField = 0;
    private long aaacuricasessionsrateField = 0;
    private long aaacuricaonlyconnField = 0;
    private long aaacuricaonlyconnrateField = 0;
    private long aaacuricaconnField = 0;
    private long aaacuricaconnrateField = 0;
    private long aaacurtmsessionsField = 0;
    private long aaacurtmsessionsrateField = 0;
    private long aaatottmsessionsField = 0;
    private long aaatmsessionsrateField = 0;

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long aaatotsessiontimeout
    {
      get => this.aaatotsessiontimeoutField;
      private set => this.aaatotsessiontimeoutField = value;
    }

    public long aaaauthfail
    {
      get => this.aaaauthfailField;
      private set => this.aaaauthfailField = value;
    }

    public long aaaauthsuccess
    {
      get => this.aaaauthsuccessField;
      private set => this.aaaauthsuccessField = value;
    }

    public long aaatottmsessions
    {
      get => this.aaatottmsessionsField;
      private set => this.aaatottmsessionsField = value;
    }

    public long aaaauthonlyhttpfailrate
    {
      get => this.aaaauthonlyhttpfailrateField;
      private set => this.aaaauthonlyhttpfailrateField = value;
    }

    public long aaaauthnonhttpsuccess
    {
      get => this.aaaauthnonhttpsuccessField;
      private set => this.aaaauthnonhttpsuccessField = value;
    }

    public long aaacuricaonlyconnrate
    {
      get => this.aaacuricaonlyconnrateField;
      private set => this.aaacuricaonlyconnrateField = value;
    }

    public long aaaauthonlyhttpsuccessrate
    {
      get => this.aaaauthonlyhttpsuccessrateField;
      private set => this.aaaauthonlyhttpsuccessrateField = value;
    }

    public long aaacurtmsessions
    {
      get => this.aaacurtmsessionsField;
      private set => this.aaacurtmsessionsField = value;
    }

    public long aaacuricasessions
    {
      get => this.aaacuricasessionsField;
      private set => this.aaacuricasessionsField = value;
    }

    public long aaatotsessions
    {
      get => this.aaatotsessionsField;
      private set => this.aaatotsessionsField = value;
    }

    public long aaaauthonlyhttpfail
    {
      get => this.aaaauthonlyhttpfailField;
      private set => this.aaaauthonlyhttpfailField = value;
    }

    public long aaacuricaonlyconn
    {
      get => this.aaacuricaonlyconnField;
      private set => this.aaacuricaonlyconnField = value;
    }

    public long aaatmsessionsrate
    {
      get => this.aaatmsessionsrateField;
      private set => this.aaatmsessionsrateField = value;
    }

    public long aaaauthfailrate
    {
      get => this.aaaauthfailrateField;
      private set => this.aaaauthfailrateField = value;
    }

    public long aaacursessionsrate
    {
      get => this.aaacursessionsrateField;
      private set => this.aaacursessionsrateField = value;
    }

    public long aaaauthnonhttpsuccessrate
    {
      get => this.aaaauthnonhttpsuccessrateField;
      private set => this.aaaauthnonhttpsuccessrateField = value;
    }

    public long aaacuricaconn
    {
      get => this.aaacuricaconnField;
      private set => this.aaacuricaconnField = value;
    }

    public long aaaauthnonhttpfailrate
    {
      get => this.aaaauthnonhttpfailrateField;
      private set => this.aaaauthnonhttpfailrateField = value;
    }

    public long aaaauthnonhttpfail
    {
      get => this.aaaauthnonhttpfailField;
      private set => this.aaaauthnonhttpfailField = value;
    }

    public long aaacuricaconnrate
    {
      get => this.aaacuricaconnrateField;
      private set => this.aaacuricaconnrateField = value;
    }

    public long aaaauthsuccessrate
    {
      get => this.aaaauthsuccessrateField;
      private set => this.aaaauthsuccessrateField = value;
    }

    public long aaaauthonlyhttpsuccess
    {
      get => this.aaaauthonlyhttpsuccessField;
      private set => this.aaaauthonlyhttpsuccessField = value;
    }

    public long aaacurtmsessionsrate
    {
      get => this.aaacurtmsessionsrateField;
      private set => this.aaacurtmsessionsrateField = value;
    }

    public long aaasessiontimeoutrate
    {
      get => this.aaasessiontimeoutrateField;
      private set => this.aaasessiontimeoutrateField = value;
    }

    public long aaacuricasessionsrate
    {
      get => this.aaacuricasessionsrateField;
      private set => this.aaacuricasessionsrateField = value;
    }

    public long aaacursessions
    {
      get => this.aaacursessionsField;
      private set => this.aaacursessionsField = value;
    }

    public long aaasessionsrate
    {
      get => this.aaasessionsrateField;
      private set => this.aaasessionsrateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      aaa_stats[] aaaStatsArray = new aaa_stats[1];
      aaa_stats.aaa_response aaaResponse = new aaa_stats.aaa_response();
      aaa_stats.aaa_response resource = (aaa_stats.aaa_response) service.get_payload_formatter().string_to_resource(aaaResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      aaaStatsArray[0] = resource.aaa;
      return (base_resource[]) aaaStatsArray;
    }

    internal override string get_object_name() => (string) null;

    public static aaa_stats get(nitro_service service) => ((aaa_stats[]) new aaa_stats().stat_resources(service, (options) null))[0];

    public static aaa_stats get(nitro_service service, options option) => ((aaa_stats[]) new aaa_stats().stat_resources(service, option))[0];

    private class aaa_response : base_response
    {
      public aaa_stats aaa = (aaa_stats) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
