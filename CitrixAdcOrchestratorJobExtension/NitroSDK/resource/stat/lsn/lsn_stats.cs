// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.lsn.lsn_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.lsn
{
  public class lsn_stats : base_resource
  {
    private string clearstatsField = (string) null;
    private long lsntottcprxpktsField = 0;
    private long lsntcprxpktsrateField = 0;
    private long lsntottcprxbytesField = 0;
    private long lsntcprxbytesrateField = 0;
    private long lsntottcptxpktsField = 0;
    private long lsntcptxpktsrateField = 0;
    private long lsntottcptxbytesField = 0;
    private long lsntcptxbytesrateField = 0;
    private long lsntottcpdrppktsField = 0;
    private long lsntcpdrppktsrateField = 0;
    private long lsncurtcpsessionsField = 0;
    private long lsncurtcpsessionsrateField = 0;
    private long lsntotudprxpktsField = 0;
    private long lsnudprxpktsrateField = 0;
    private long lsntotudprxbytesField = 0;
    private long lsnudprxbytesrateField = 0;
    private long lsntotudptxpktsField = 0;
    private long lsnudptxpktsrateField = 0;
    private long lsntotudptxbytesField = 0;
    private long lsnudptxbytesrateField = 0;
    private long lsntotudpdrppktsField = 0;
    private long lsnudpdrppktsrateField = 0;
    private long lsncurudpsessionsField = 0;
    private long lsncurudpsessionsrateField = 0;
    private long lsntoticmprxpktsField = 0;
    private long lsnicmprxpktsrateField = 0;
    private long lsntoticmprxbytesField = 0;
    private long lsnicmprxbytesrateField = 0;
    private long lsntoticmptxpktsField = 0;
    private long lsnicmptxpktsrateField = 0;
    private long lsntoticmptxbytesField = 0;
    private long lsnicmptxbytesrateField = 0;
    private long lsntoticmpdrppktsField = 0;
    private long lsnicmpdrppktsrateField = 0;
    private long lsncuricmpsessionsField = 0;
    private long lsncuricmpsessionsrateField = 0;
    private long lsncursessionsField = 0;
    private long lsncursessionsrateField = 0;
    private long lsncursubscribersField = 0;
    private long lsncursubscribersrateField = 0;

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long lsncursubscribersrate
    {
      get => this.lsncursubscribersrateField;
      private set => this.lsncursubscribersrateField = value;
    }

    public long lsntotudptxbytes
    {
      get => this.lsntotudptxbytesField;
      private set => this.lsntotudptxbytesField = value;
    }

    public long lsncuricmpsessionsrate
    {
      get => this.lsncuricmpsessionsrateField;
      private set => this.lsncuricmpsessionsrateField = value;
    }

    public long lsncursessions
    {
      get => this.lsncursessionsField;
      private set => this.lsncursessionsField = value;
    }

    public long lsntottcptxbytes
    {
      get => this.lsntottcptxbytesField;
      private set => this.lsntottcptxbytesField = value;
    }

    public long lsnudptxbytesrate
    {
      get => this.lsnudptxbytesrateField;
      private set => this.lsnudptxbytesrateField = value;
    }

    public long lsntotudpdrppkts
    {
      get => this.lsntotudpdrppktsField;
      private set => this.lsntotudpdrppktsField = value;
    }

    public long lsntottcpdrppkts
    {
      get => this.lsntottcpdrppktsField;
      private set => this.lsntottcpdrppktsField = value;
    }

    public long lsntoticmptxpkts
    {
      get => this.lsntoticmptxpktsField;
      private set => this.lsntoticmptxpktsField = value;
    }

    public long lsntcptxbytesrate
    {
      get => this.lsntcptxbytesrateField;
      private set => this.lsntcptxbytesrateField = value;
    }

    public long lsnudprxbytesrate
    {
      get => this.lsnudprxbytesrateField;
      private set => this.lsnudprxbytesrateField = value;
    }

    public long lsntcpdrppktsrate
    {
      get => this.lsntcpdrppktsrateField;
      private set => this.lsntcpdrppktsrateField = value;
    }

    public long lsntotudprxbytes
    {
      get => this.lsntotudprxbytesField;
      private set => this.lsntotudprxbytesField = value;
    }

    public long lsnicmpdrppktsrate
    {
      get => this.lsnicmpdrppktsrateField;
      private set => this.lsnicmpdrppktsrateField = value;
    }

    public long lsntottcprxbytes
    {
      get => this.lsntottcprxbytesField;
      private set => this.lsntottcprxbytesField = value;
    }

    public long lsntoticmptxbytes
    {
      get => this.lsntoticmptxbytesField;
      private set => this.lsntoticmptxbytesField = value;
    }

    public long lsntoticmprxpkts
    {
      get => this.lsntoticmprxpktsField;
      private set => this.lsntoticmprxpktsField = value;
    }

    public long lsnicmptxpktsrate
    {
      get => this.lsnicmptxpktsrateField;
      private set => this.lsnicmptxpktsrateField = value;
    }

    public long lsnicmprxbytesrate
    {
      get => this.lsnicmprxbytesrateField;
      private set => this.lsnicmprxbytesrateField = value;
    }

    public long lsntoticmpdrppkts
    {
      get => this.lsntoticmpdrppktsField;
      private set => this.lsntoticmpdrppktsField = value;
    }

    public long lsntcprxpktsrate
    {
      get => this.lsntcprxpktsrateField;
      private set => this.lsntcprxpktsrateField = value;
    }

    public long lsntottcptxpkts
    {
      get => this.lsntottcptxpktsField;
      private set => this.lsntottcptxpktsField = value;
    }

    public long lsncurtcpsessionsrate
    {
      get => this.lsncurtcpsessionsrateField;
      private set => this.lsncurtcpsessionsrateField = value;
    }

    public long lsncursubscribers
    {
      get => this.lsncursubscribersField;
      private set => this.lsncursubscribersField = value;
    }

    public long lsncurudpsessionsrate
    {
      get => this.lsncurudpsessionsrateField;
      private set => this.lsncurudpsessionsrateField = value;
    }

    public long lsnudptxpktsrate
    {
      get => this.lsnudptxpktsrateField;
      private set => this.lsnudptxpktsrateField = value;
    }

    public long lsntottcprxpkts
    {
      get => this.lsntottcprxpktsField;
      private set => this.lsntottcprxpktsField = value;
    }

    public long lsnicmptxbytesrate
    {
      get => this.lsnicmptxbytesrateField;
      private set => this.lsnicmptxbytesrateField = value;
    }

    public long lsntotudprxpkts
    {
      get => this.lsntotudprxpktsField;
      private set => this.lsntotudprxpktsField = value;
    }

    public long lsncursessionsrate
    {
      get => this.lsncursessionsrateField;
      private set => this.lsncursessionsrateField = value;
    }

    public long lsntcptxpktsrate
    {
      get => this.lsntcptxpktsrateField;
      private set => this.lsntcptxpktsrateField = value;
    }

    public long lsnudprxpktsrate
    {
      get => this.lsnudprxpktsrateField;
      private set => this.lsnudprxpktsrateField = value;
    }

    public long lsntotudptxpkts
    {
      get => this.lsntotudptxpktsField;
      private set => this.lsntotudptxpktsField = value;
    }

    public long lsncurudpsessions
    {
      get => this.lsncurudpsessionsField;
      private set => this.lsncurudpsessionsField = value;
    }

    public long lsnudpdrppktsrate
    {
      get => this.lsnudpdrppktsrateField;
      private set => this.lsnudpdrppktsrateField = value;
    }

    public long lsntoticmprxbytes
    {
      get => this.lsntoticmprxbytesField;
      private set => this.lsntoticmprxbytesField = value;
    }

    public long lsncuricmpsessions
    {
      get => this.lsncuricmpsessionsField;
      private set => this.lsncuricmpsessionsField = value;
    }

    public long lsncurtcpsessions
    {
      get => this.lsncurtcpsessionsField;
      private set => this.lsncurtcpsessionsField = value;
    }

    public long lsntcprxbytesrate
    {
      get => this.lsntcprxbytesrateField;
      private set => this.lsntcprxbytesrateField = value;
    }

    public long lsnicmprxpktsrate
    {
      get => this.lsnicmprxpktsrateField;
      private set => this.lsnicmprxpktsrateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lsn_stats[] lsnStatsArray = new lsn_stats[1];
      lsn_stats.lsn_response lsnResponse = new lsn_stats.lsn_response();
      lsn_stats.lsn_response resource = (lsn_stats.lsn_response) service.get_payload_formatter().string_to_resource(lsnResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      lsnStatsArray[0] = resource.lsn;
      return (base_resource[]) lsnStatsArray;
    }

    internal override string get_object_name() => (string) null;

    public static lsn_stats get(nitro_service service) => ((lsn_stats[]) new lsn_stats().stat_resources(service, (options) null))[0];

    public static lsn_stats get(nitro_service service, options option) => ((lsn_stats[]) new lsn_stats().stat_resources(service, option))[0];

    private class lsn_response : base_response
    {
      public lsn_stats lsn = (lsn_stats) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
