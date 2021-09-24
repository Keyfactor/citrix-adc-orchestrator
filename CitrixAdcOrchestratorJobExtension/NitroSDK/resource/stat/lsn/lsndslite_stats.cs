// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.lsn.lsndslite_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.lsn
{
  public class lsndslite_stats : base_resource
  {
    private string clearstatsField = (string) null;
    private long lsntotdsliterxpktsField = 0;
    private long lsndsliterxpktsrateField = 0;
    private long lsntotdsliterxbytesField = 0;
    private long lsndsliterxbytesrateField = 0;
    private long lsntotdslitetxpktsField = 0;
    private long lsndslitetxpktsrateField = 0;
    private long lsntotdslitetxbytesField = 0;
    private long lsndslitetxbytesrateField = 0;
    private long lsntotdslitetcprxpktsField = 0;
    private long lsndslitetcprxpktsrateField = 0;
    private long lsntotdslitetcprxbytesField = 0;
    private long lsndslitetcprxbytesrateField = 0;
    private long lsntotdslitetcptxpktsField = 0;
    private long lsndslitetcptxpktsrateField = 0;
    private long lsntotdslitetcptxbytesField = 0;
    private long lsndslitetcptxbytesrateField = 0;
    private long lsntotdslitetcpdrppktsField = 0;
    private long lsndslitetcpdrppktsrateField = 0;
    private long lsncurdslitetcpsessionsField = 0;
    private long lsncurdslitetcpsessionsrateField = 0;
    private long lsntotdsliteudprxpktsField = 0;
    private long lsndsliteudprxpktsrateField = 0;
    private long lsntotdsliteudprxbytesField = 0;
    private long lsndsliteudprxbytesrateField = 0;
    private long lsntotdsliteudptxpktsField = 0;
    private long lsndsliteudptxpktsrateField = 0;
    private long lsntotdsliteudptxbytesField = 0;
    private long lsndsliteudptxbytesrateField = 0;
    private long lsntotdsliteudpdrppktsField = 0;
    private long lsndsliteudpdrppktsrateField = 0;
    private long lsncurdsliteudpsessionsField = 0;
    private long lsncurdsliteudpsessionsrateField = 0;
    private long lsntotdsliteicmprxpktsField = 0;
    private long lsndsliteicmprxpktsrateField = 0;
    private long lsntotdsliteicmprxbytesField = 0;
    private long lsndsliteicmprxbytesrateField = 0;
    private long lsntotdsliteicmptxpktsField = 0;
    private long lsndsliteicmptxpktsrateField = 0;
    private long lsntotdsliteicmptxbytesField = 0;
    private long lsndsliteicmptxbytesrateField = 0;
    private long lsntotdsliteicmpdrppktsField = 0;
    private long lsndsliteicmpdrppktsrateField = 0;
    private long lsncurdsliteicmpsessionsField = 0;
    private long lsncurdsliteicmpsessionsrateField = 0;
    private long lsncurdslitesessionsField = 0;
    private long lsncurdslitesessionsrateField = 0;
    private long lsndslitecursubscribersField = 0;
    private long lsndslitecursubscribersrateField = 0;

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long lsntotdsliteudpdrppkts
    {
      get => this.lsntotdsliteudpdrppktsField;
      private set => this.lsntotdsliteudpdrppktsField = value;
    }

    public long lsndsliteudprxpktsrate
    {
      get => this.lsndsliteudprxpktsrateField;
      private set => this.lsndsliteudprxpktsrateField = value;
    }

    public long lsntotdsliterxpkts
    {
      get => this.lsntotdsliterxpktsField;
      private set => this.lsntotdsliterxpktsField = value;
    }

    public long lsntotdslitetxbytes
    {
      get => this.lsntotdslitetxbytesField;
      private set => this.lsntotdslitetxbytesField = value;
    }

    public long lsncurdsliteicmpsessionsrate
    {
      get => this.lsncurdsliteicmpsessionsrateField;
      private set => this.lsncurdsliteicmpsessionsrateField = value;
    }

    public long lsntotdsliteudptxbytes
    {
      get => this.lsntotdsliteudptxbytesField;
      private set => this.lsntotdsliteudptxbytesField = value;
    }

    public long lsntotdsliteicmptxpkts
    {
      get => this.lsntotdsliteicmptxpktsField;
      private set => this.lsntotdsliteicmptxpktsField = value;
    }

    public long lsndslitetxpktsrate
    {
      get => this.lsndslitetxpktsrateField;
      private set => this.lsndslitetxpktsrateField = value;
    }

    public long lsntotdsliteicmptxbytes
    {
      get => this.lsntotdsliteicmptxbytesField;
      private set => this.lsntotdsliteicmptxbytesField = value;
    }

    public long lsntotdsliterxbytes
    {
      get => this.lsntotdsliterxbytesField;
      private set => this.lsntotdsliterxbytesField = value;
    }

    public long lsntotdsliteicmpdrppkts
    {
      get => this.lsntotdsliteicmpdrppktsField;
      private set => this.lsntotdsliteicmpdrppktsField = value;
    }

    public long lsncurdslitetcpsessionsrate
    {
      get => this.lsncurdslitetcpsessionsrateField;
      private set => this.lsncurdslitetcpsessionsrateField = value;
    }

    public long lsndsliteudptxbytesrate
    {
      get => this.lsndsliteudptxbytesrateField;
      private set => this.lsndsliteudptxbytesrateField = value;
    }

    public long lsntotdsliteudprxbytes
    {
      get => this.lsntotdsliteudprxbytesField;
      private set => this.lsntotdsliteudprxbytesField = value;
    }

    public long lsndsliterxbytesrate
    {
      get => this.lsndsliterxbytesrateField;
      private set => this.lsndsliterxbytesrateField = value;
    }

    public long lsncurdsliteicmpsessions
    {
      get => this.lsncurdsliteicmpsessionsField;
      private set => this.lsncurdsliteicmpsessionsField = value;
    }

    public long lsndsliteicmprxbytesrate
    {
      get => this.lsndsliteicmprxbytesrateField;
      private set => this.lsndsliteicmprxbytesrateField = value;
    }

    public long lsndsliteudpdrppktsrate
    {
      get => this.lsndsliteudpdrppktsrateField;
      private set => this.lsndsliteudpdrppktsrateField = value;
    }

    public long lsntotdslitetcpdrppkts
    {
      get => this.lsntotdslitetcpdrppktsField;
      private set => this.lsntotdslitetcpdrppktsField = value;
    }

    public long lsntotdsliteicmprxbytes
    {
      get => this.lsntotdsliteicmprxbytesField;
      private set => this.lsntotdsliteicmprxbytesField = value;
    }

    public long lsncurdslitesessionsrate
    {
      get => this.lsncurdslitesessionsrateField;
      private set => this.lsncurdslitesessionsrateField = value;
    }

    public long lsntotdsliteicmprxpkts
    {
      get => this.lsntotdsliteicmprxpktsField;
      private set => this.lsntotdsliteicmprxpktsField = value;
    }

    public long lsntotdslitetxpkts
    {
      get => this.lsntotdslitetxpktsField;
      private set => this.lsntotdslitetxpktsField = value;
    }

    public long lsncurdsliteudpsessionsrate
    {
      get => this.lsncurdsliteudpsessionsrateField;
      private set => this.lsncurdsliteudpsessionsrateField = value;
    }

    public long lsndslitetcptxpktsrate
    {
      get => this.lsndslitetcptxpktsrateField;
      private set => this.lsndslitetcptxpktsrateField = value;
    }

    public long lsntotdslitetcptxpkts
    {
      get => this.lsntotdslitetcptxpktsField;
      private set => this.lsntotdslitetcptxpktsField = value;
    }

    public long lsndsliteicmptxpktsrate
    {
      get => this.lsndsliteicmptxpktsrateField;
      private set => this.lsndsliteicmptxpktsrateField = value;
    }

    public long lsndsliteicmpdrppktsrate
    {
      get => this.lsndsliteicmpdrppktsrateField;
      private set => this.lsndsliteicmpdrppktsrateField = value;
    }

    public long lsntotdsliteudprxpkts
    {
      get => this.lsntotdsliteudprxpktsField;
      private set => this.lsntotdsliteudprxpktsField = value;
    }

    public long lsncurdslitetcpsessions
    {
      get => this.lsncurdslitetcpsessionsField;
      private set => this.lsncurdslitetcpsessionsField = value;
    }

    public long lsndslitetxbytesrate
    {
      get => this.lsndslitetxbytesrateField;
      private set => this.lsndslitetxbytesrateField = value;
    }

    public long lsntotdslitetcprxbytes
    {
      get => this.lsntotdslitetcprxbytesField;
      private set => this.lsntotdslitetcprxbytesField = value;
    }

    public long lsndsliteicmptxbytesrate
    {
      get => this.lsndsliteicmptxbytesrateField;
      private set => this.lsndsliteicmptxbytesrateField = value;
    }

    public long lsndsliteicmprxpktsrate
    {
      get => this.lsndsliteicmprxpktsrateField;
      private set => this.lsndsliteicmprxpktsrateField = value;
    }

    public long lsncurdslitesessions
    {
      get => this.lsncurdslitesessionsField;
      private set => this.lsncurdslitesessionsField = value;
    }

    public long lsndslitetcprxbytesrate
    {
      get => this.lsndslitetcprxbytesrateField;
      private set => this.lsndslitetcprxbytesrateField = value;
    }

    public long lsndslitecursubscribers
    {
      get => this.lsndslitecursubscribersField;
      private set => this.lsndslitecursubscribersField = value;
    }

    public long lsntotdslitetcprxpkts
    {
      get => this.lsntotdslitetcprxpktsField;
      private set => this.lsntotdslitetcprxpktsField = value;
    }

    public long lsndsliterxpktsrate
    {
      get => this.lsndsliterxpktsrateField;
      private set => this.lsndsliterxpktsrateField = value;
    }

    public long lsncurdsliteudpsessions
    {
      get => this.lsncurdsliteudpsessionsField;
      private set => this.lsncurdsliteudpsessionsField = value;
    }

    public long lsndslitetcprxpktsrate
    {
      get => this.lsndslitetcprxpktsrateField;
      private set => this.lsndslitetcprxpktsrateField = value;
    }

    public long lsntotdsliteudptxpkts
    {
      get => this.lsntotdsliteudptxpktsField;
      private set => this.lsntotdsliteudptxpktsField = value;
    }

    public long lsntotdslitetcptxbytes
    {
      get => this.lsntotdslitetcptxbytesField;
      private set => this.lsntotdslitetcptxbytesField = value;
    }

    public long lsndslitetcpdrppktsrate
    {
      get => this.lsndslitetcpdrppktsrateField;
      private set => this.lsndslitetcpdrppktsrateField = value;
    }

    public long lsndslitetcptxbytesrate
    {
      get => this.lsndslitetcptxbytesrateField;
      private set => this.lsndslitetcptxbytesrateField = value;
    }

    public long lsndsliteudprxbytesrate
    {
      get => this.lsndsliteudprxbytesrateField;
      private set => this.lsndsliteudprxbytesrateField = value;
    }

    public long lsndsliteudptxpktsrate
    {
      get => this.lsndsliteudptxpktsrateField;
      private set => this.lsndsliteudptxpktsrateField = value;
    }

    public long lsndslitecursubscribersrate
    {
      get => this.lsndslitecursubscribersrateField;
      private set => this.lsndslitecursubscribersrateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lsndslite_stats[] lsndsliteStatsArray = new lsndslite_stats[1];
      lsndslite_stats.lsndslite_response lsndsliteResponse = new lsndslite_stats.lsndslite_response();
      lsndslite_stats.lsndslite_response resource = (lsndslite_stats.lsndslite_response) service.get_payload_formatter().string_to_resource(lsndsliteResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      lsndsliteStatsArray[0] = resource.lsndslite;
      return (base_resource[]) lsndsliteStatsArray;
    }

    internal override string get_object_name() => (string) null;

    public static lsndslite_stats get(nitro_service service) => ((lsndslite_stats[]) new lsndslite_stats().stat_resources(service, (options) null))[0];

    public static lsndslite_stats get(nitro_service service, options option) => ((lsndslite_stats[]) new lsndslite_stats().stat_resources(service, option))[0];

    private class lsndslite_response : base_response
    {
      public lsndslite_stats lsndslite = (lsndslite_stats) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
