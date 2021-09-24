// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.system.systembw_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.system
{
  public class systembw_stats : base_resource
  {
    private string clearstatsField = (string) null;
    private long httpcltpoolinactiveField = 0;
    private long httpcltpooloutactiveField = 0;
    private long httpsvr200okrespField = 0;
    private long httpsvr200okresprateField = 0;
    private long httpsvr404notfoundField = 0;
    private long httpsvr404notfoundrateField = 0;
    private long httpclterrstrayField = 0;
    private long httpclterrstrayrateField = 0;
    private long httpcltttfplwmField = 0;
    private long httpcltttfplwmrateField = 0;
    private long httpcltttfp_0Field = 0;
    private long httpcltttfp_0rateField = 0;
    private long httpcltttfp_1Field = 0;
    private long httpcltttfp_1rateField = 0;
    private long httpcltttfp_2Field = 0;
    private long httpcltttfp_2rateField = 0;
    private long httpcltttfp_3Field = 0;
    private long httpcltttfp_3rateField = 0;
    private long httpcltttfp_4Field = 0;
    private long httpcltttfp_4rateField = 0;
    private long httpcltttfp_5Field = 0;
    private long httpcltttfp_5rateField = 0;
    private long httpcltttfp_6Field = 0;
    private long httpcltttfp_6rateField = 0;
    private long httpcltttfp_7Field = 0;
    private long httpcltttfp_7rateField = 0;
    private long httpcltttfphwmField = 0;
    private long httpcltttfphwmrateField = 0;
    private long httpcltttfpmaxField = 0;
    private long httpcltttlplwmField = 0;
    private long httpcltttlplwmrateField = 0;
    private long httpcltttlp_0Field = 0;
    private long httpcltttlp_0rateField = 0;
    private long httpcltttlp_1Field = 0;
    private long httpcltttlp_1rateField = 0;
    private long httpcltttlp_2Field = 0;
    private long httpcltttlp_2rateField = 0;
    private long httpcltttlp_3Field = 0;
    private long httpcltttlp_3rateField = 0;
    private long httpcltttlp_4Field = 0;
    private long httpcltttlp_4rateField = 0;
    private long httpcltttlp_5Field = 0;
    private long httpcltttlp_5rateField = 0;
    private long httpcltttlp_6Field = 0;
    private long httpcltttlp_6rateField = 0;
    private long httpcltttlp_7Field = 0;
    private long httpcltttlp_7rateField = 0;
    private long httpcltttlphwmField = 0;
    private long httpcltttlphwmrateField = 0;
    private long httpcltttlpmaxField = 0;

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long httpcltttfp_4rate
    {
      get => this.httpcltttfp_4rateField;
      private set => this.httpcltttfp_4rateField = value;
    }

    public long httpcltttlp_5rate
    {
      get => this.httpcltttlp_5rateField;
      private set => this.httpcltttlp_5rateField = value;
    }

    public long httpcltttfp_2rate
    {
      get => this.httpcltttfp_2rateField;
      private set => this.httpcltttfp_2rateField = value;
    }

    public long httpcltttfp_7rate
    {
      get => this.httpcltttfp_7rateField;
      private set => this.httpcltttfp_7rateField = value;
    }

    public long httpcltttlphwmrate
    {
      get => this.httpcltttlphwmrateField;
      private set => this.httpcltttlphwmrateField = value;
    }

    public long httpcltttfp_0rate
    {
      get => this.httpcltttfp_0rateField;
      private set => this.httpcltttfp_0rateField = value;
    }

    public long httpcltttlplwmrate
    {
      get => this.httpcltttlplwmrateField;
      private set => this.httpcltttlplwmrateField = value;
    }

    public long httpcltttfp_4
    {
      get => this.httpcltttfp_4Field;
      private set => this.httpcltttfp_4Field = value;
    }

    public long httpcltpooloutactive
    {
      get => this.httpcltpooloutactiveField;
      private set => this.httpcltpooloutactiveField = value;
    }

    public long httpcltttlplwm
    {
      get => this.httpcltttlplwmField;
      private set => this.httpcltttlplwmField = value;
    }

    public long httpcltttlp_1
    {
      get => this.httpcltttlp_1Field;
      private set => this.httpcltttlp_1Field = value;
    }

    public long httpsvr404notfoundrate
    {
      get => this.httpsvr404notfoundrateField;
      private set => this.httpsvr404notfoundrateField = value;
    }

    public long httpcltttlp_6
    {
      get => this.httpcltttlp_6Field;
      private set => this.httpcltttlp_6Field = value;
    }

    public long httpcltttlphwm
    {
      get => this.httpcltttlphwmField;
      private set => this.httpcltttlphwmField = value;
    }

    public long httpcltttlp_1rate
    {
      get => this.httpcltttlp_1rateField;
      private set => this.httpcltttlp_1rateField = value;
    }

    public long httpcltpoolinactive
    {
      get => this.httpcltpoolinactiveField;
      private set => this.httpcltpoolinactiveField = value;
    }

    public long httpcltttlp_3
    {
      get => this.httpcltttlp_3Field;
      private set => this.httpcltttlp_3Field = value;
    }

    public long httpcltttlp_5
    {
      get => this.httpcltttlp_5Field;
      private set => this.httpcltttlp_5Field = value;
    }

    public long httpcltttlp_6rate
    {
      get => this.httpcltttlp_6rateField;
      private set => this.httpcltttlp_6rateField = value;
    }

    public long httpsvr200okresprate
    {
      get => this.httpsvr200okresprateField;
      private set => this.httpsvr200okresprateField = value;
    }

    public long httpcltttfp_1rate
    {
      get => this.httpcltttfp_1rateField;
      private set => this.httpcltttfp_1rateField = value;
    }

    public long httpcltttfp_1
    {
      get => this.httpcltttfp_1Field;
      private set => this.httpcltttfp_1Field = value;
    }

    public long httpcltttfphwmrate
    {
      get => this.httpcltttfphwmrateField;
      private set => this.httpcltttfphwmrateField = value;
    }

    public long httpcltttfp_6
    {
      get => this.httpcltttfp_6Field;
      private set => this.httpcltttfp_6Field = value;
    }

    public long httpcltttfpmax
    {
      get => this.httpcltttfpmaxField;
      private set => this.httpcltttfpmaxField = value;
    }

    public long httpcltttfp_5
    {
      get => this.httpcltttfp_5Field;
      private set => this.httpcltttfp_5Field = value;
    }

    public long httpcltttlpmax
    {
      get => this.httpcltttlpmaxField;
      private set => this.httpcltttlpmaxField = value;
    }

    public long httpcltttlp_4rate
    {
      get => this.httpcltttlp_4rateField;
      private set => this.httpcltttlp_4rateField = value;
    }

    public long httpcltttlp_7rate
    {
      get => this.httpcltttlp_7rateField;
      private set => this.httpcltttlp_7rateField = value;
    }

    public long httpcltttfp_0
    {
      get => this.httpcltttfp_0Field;
      private set => this.httpcltttfp_0Field = value;
    }

    public long httpcltttfp_3
    {
      get => this.httpcltttfp_3Field;
      private set => this.httpcltttfp_3Field = value;
    }

    public long httpcltttfphwm
    {
      get => this.httpcltttfphwmField;
      private set => this.httpcltttfphwmField = value;
    }

    public long httpclterrstray
    {
      get => this.httpclterrstrayField;
      private set => this.httpclterrstrayField = value;
    }

    public long httpcltttlp_0rate
    {
      get => this.httpcltttlp_0rateField;
      private set => this.httpcltttlp_0rateField = value;
    }

    public long httpcltttfplwm
    {
      get => this.httpcltttfplwmField;
      private set => this.httpcltttfplwmField = value;
    }

    public long httpcltttlp_0
    {
      get => this.httpcltttlp_0Field;
      private set => this.httpcltttlp_0Field = value;
    }

    public long httpclterrstrayrate
    {
      get => this.httpclterrstrayrateField;
      private set => this.httpclterrstrayrateField = value;
    }

    public long httpcltttfplwmrate
    {
      get => this.httpcltttfplwmrateField;
      private set => this.httpcltttfplwmrateField = value;
    }

    public long httpcltttlp_2
    {
      get => this.httpcltttlp_2Field;
      private set => this.httpcltttlp_2Field = value;
    }

    public long httpcltttfp_2
    {
      get => this.httpcltttfp_2Field;
      private set => this.httpcltttfp_2Field = value;
    }

    public long httpcltttlp_2rate
    {
      get => this.httpcltttlp_2rateField;
      private set => this.httpcltttlp_2rateField = value;
    }

    public long httpcltttlp_4
    {
      get => this.httpcltttlp_4Field;
      private set => this.httpcltttlp_4Field = value;
    }

    public long httpcltttfp_7
    {
      get => this.httpcltttfp_7Field;
      private set => this.httpcltttfp_7Field = value;
    }

    public long httpsvr200okresp
    {
      get => this.httpsvr200okrespField;
      private set => this.httpsvr200okrespField = value;
    }

    public long httpsvr404notfound
    {
      get => this.httpsvr404notfoundField;
      private set => this.httpsvr404notfoundField = value;
    }

    public long httpcltttlp_3rate
    {
      get => this.httpcltttlp_3rateField;
      private set => this.httpcltttlp_3rateField = value;
    }

    public long httpcltttfp_6rate
    {
      get => this.httpcltttfp_6rateField;
      private set => this.httpcltttfp_6rateField = value;
    }

    public long httpcltttfp_5rate
    {
      get => this.httpcltttfp_5rateField;
      private set => this.httpcltttfp_5rateField = value;
    }

    public long httpcltttfp_3rate
    {
      get => this.httpcltttfp_3rateField;
      private set => this.httpcltttfp_3rateField = value;
    }

    public long httpcltttlp_7
    {
      get => this.httpcltttlp_7Field;
      private set => this.httpcltttlp_7Field = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      systembw_stats[] systembwStatsArray = new systembw_stats[1];
      systembw_stats.systembw_response systembwResponse = new systembw_stats.systembw_response();
      systembw_stats.systembw_response resource = (systembw_stats.systembw_response) service.get_payload_formatter().string_to_resource(systembwResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      systembwStatsArray[0] = resource.systembw;
      return (base_resource[]) systembwStatsArray;
    }

    internal override string get_object_name() => (string) null;

    public static systembw_stats get(nitro_service service) => ((systembw_stats[]) new systembw_stats().stat_resources(service, (options) null))[0];

    public static systembw_stats get(nitro_service service, options option) => ((systembw_stats[]) new systembw_stats().stat_resources(service, option))[0];

    private class systembw_response : base_response
    {
      public systembw_stats systembw = (systembw_stats) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
