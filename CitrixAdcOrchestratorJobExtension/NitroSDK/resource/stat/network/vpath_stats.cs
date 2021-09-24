// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.network.vpath_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.network
{
  public class vpath_stats : base_resource
  {
    private string clearstatsField = (string) null;
    private long vpathtotl2datarxField = 0;
    private long vpathl2datarxrateField = 0;
    private long vpathtotl3datarxField = 0;
    private long vpathl3datarxrateField = 0;
    private long vpathtotl2cntrlpktsField = 0;
    private long vpathl2cntrlpktsrateField = 0;
    private long vpathtotl3cntrlpktsField = 0;
    private long vpathl3cntrlpktsrateField = 0;
    private long vpathtotfragpktsField = 0;
    private long vpathfragpktsrateField = 0;
    private long vpathtotl2encappktsField = 0;
    private long vpathl2encappktsrateField = 0;
    private long vpathtotl3encappktsField = 0;
    private long vpathl3encappktsrateField = 0;
    private long vpathtotfragencappktsField = 0;
    private long vpathfragencappktsrateField = 0;
    private long vpathtotoffloadField = 0;
    private long vpathoffloadrateField = 0;

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long vpathfragencappktsrate
    {
      get => this.vpathfragencappktsrateField;
      private set => this.vpathfragencappktsrateField = value;
    }

    public long vpathtotl2cntrlpkts
    {
      get => this.vpathtotl2cntrlpktsField;
      private set => this.vpathtotl2cntrlpktsField = value;
    }

    public long vpathtotoffload
    {
      get => this.vpathtotoffloadField;
      private set => this.vpathtotoffloadField = value;
    }

    public long vpathtotl3encappkts
    {
      get => this.vpathtotl3encappktsField;
      private set => this.vpathtotl3encappktsField = value;
    }

    public long vpathtotl2datarx
    {
      get => this.vpathtotl2datarxField;
      private set => this.vpathtotl2datarxField = value;
    }

    public long vpathtotl2encappkts
    {
      get => this.vpathtotl2encappktsField;
      private set => this.vpathtotl2encappktsField = value;
    }

    public long vpathoffloadrate
    {
      get => this.vpathoffloadrateField;
      private set => this.vpathoffloadrateField = value;
    }

    public long vpathl3cntrlpktsrate
    {
      get => this.vpathl3cntrlpktsrateField;
      private set => this.vpathl3cntrlpktsrateField = value;
    }

    public long vpathfragpktsrate
    {
      get => this.vpathfragpktsrateField;
      private set => this.vpathfragpktsrateField = value;
    }

    public long vpathtotl3datarx
    {
      get => this.vpathtotl3datarxField;
      private set => this.vpathtotl3datarxField = value;
    }

    public long vpathtotl3cntrlpkts
    {
      get => this.vpathtotl3cntrlpktsField;
      private set => this.vpathtotl3cntrlpktsField = value;
    }

    public long vpathtotfragencappkts
    {
      get => this.vpathtotfragencappktsField;
      private set => this.vpathtotfragencappktsField = value;
    }

    public long vpathl3encappktsrate
    {
      get => this.vpathl3encappktsrateField;
      private set => this.vpathl3encappktsrateField = value;
    }

    public long vpathl2encappktsrate
    {
      get => this.vpathl2encappktsrateField;
      private set => this.vpathl2encappktsrateField = value;
    }

    public long vpathl2cntrlpktsrate
    {
      get => this.vpathl2cntrlpktsrateField;
      private set => this.vpathl2cntrlpktsrateField = value;
    }

    public long vpathl3datarxrate
    {
      get => this.vpathl3datarxrateField;
      private set => this.vpathl3datarxrateField = value;
    }

    public long vpathl2datarxrate
    {
      get => this.vpathl2datarxrateField;
      private set => this.vpathl2datarxrateField = value;
    }

    public long vpathtotfragpkts
    {
      get => this.vpathtotfragpktsField;
      private set => this.vpathtotfragpktsField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vpath_stats[] vpathStatsArray = new vpath_stats[1];
      vpath_stats.vpath_response vpathResponse = new vpath_stats.vpath_response();
      vpath_stats.vpath_response resource = (vpath_stats.vpath_response) service.get_payload_formatter().string_to_resource(vpathResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      vpathStatsArray[0] = resource.vpath;
      return (base_resource[]) vpathStatsArray;
    }

    internal override string get_object_name() => (string) null;

    public static vpath_stats get(nitro_service service) => ((vpath_stats[]) new vpath_stats().stat_resources(service, (options) null))[0];

    public static vpath_stats get(nitro_service service, options option) => ((vpath_stats[]) new vpath_stats().stat_resources(service, option))[0];

    private class vpath_response : base_response
    {
      public vpath_stats vpath = (vpath_stats) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
