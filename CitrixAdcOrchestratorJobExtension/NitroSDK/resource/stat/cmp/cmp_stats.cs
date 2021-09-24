// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.cmp.cmp_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.cmp
{
  public class cmp_stats : base_resource
  {
    private string clearstatsField = (string) null;
    private double delbwsavingField = 0.0;
    private double delcmpratioField = 0.0;
    private double decomptcpratioField = 0.0;
    private double decomptcpbandwidthsavingField = 0.0;
    private double comptcpratioField = 0.0;
    private double comptcpbandwidthsavingField = 0.0;
    private double comptotaldatacompressionratioField = 0.0;
    private double comphttpbandwidthsavingField = 0.0;
    private double compratioField = 0.0;
    private long comptotalrequestsField = 0;
    private long comprequestsrateField = 0;
    private long comptotalrxbytesField = 0;
    private long comprxbytesrateField = 0;
    private long comptotaltxbytesField = 0;
    private long comptxbytesrateField = 0;
    private long comptotalrxpacketsField = 0;
    private long comprxpacketsrateField = 0;
    private long comptotaltxpacketsField = 0;
    private long comptxpacketsrateField = 0;
    private long comptcptotalrxbytesField = 0;
    private long comptcprxbytesrateField = 0;
    private long comptcptotalrxpacketsField = 0;
    private long comptcprxpacketsrateField = 0;
    private long comptcptotaltxbytesField = 0;
    private long comptcptxbytesrateField = 0;
    private long comptcptotaltxpacketsField = 0;
    private long comptcptxpacketsrateField = 0;
    private long comptcptotalquantumField = 0;
    private long comptcpquantumrateField = 0;
    private long comptcptotalpushField = 0;
    private long comptcppushrateField = 0;
    private long comptcptotaleoiField = 0;
    private long comptcpeoirateField = 0;
    private long comptcptotaltimerField = 0;
    private long comptcptimerrateField = 0;
    private long decomptcprxbytesField = 0;
    private long decomptcprxbytesrateField = 0;
    private long decomptcprxpacketsField = 0;
    private long decomptcprxpacketsrateField = 0;
    private long decomptcptxbytesField = 0;
    private long decomptcptxbytesrateField = 0;
    private long decomptcptxpacketsField = 0;
    private long decomptcptxpacketsrateField = 0;
    private long decomptcperrdataField = 0;
    private long decomptcperrdatarateField = 0;
    private long decomptcperrlessdataField = 0;
    private long decomptcperrlessdatarateField = 0;
    private long decomptcperrmoredataField = 0;
    private long decomptcperrmoredatarateField = 0;
    private long decomptcperrmemoryField = 0;
    private long decomptcperrmemoryrateField = 0;
    private long decomptcperrunknownField = 0;
    private long decomptcperrunknownrateField = 0;
    private long delcomptotalrequestsField = 0;
    private long delcomprequestsrateField = 0;
    private long delcompdoneField = 0;
    private long delcompdonerateField = 0;
    private long delcomptcprxbytesField = 0;
    private long delcomptcprxbytesrateField = 0;
    private long delcomptcptxbytesField = 0;
    private long delcomptcptxbytesrateField = 0;
    private long delcompfirstaccessField = 0;
    private long delcompfirstaccessrateField = 0;
    private long delcomptcprxpacketsField = 0;
    private long delcomptcprxpacketsrateField = 0;
    private long delcomptcptxpacketsField = 0;
    private long delcomptcptxpacketsrateField = 0;
    private long delcompbaseservedField = 0;
    private long delcompbaseservedrateField = 0;
    private long delcompbasetcptxbytesField = 0;
    private long delcompbasetcptxbytesrateField = 0;
    private long delcomperrbypassedField = 0;
    private long delcomperrbypassedrateField = 0;
    private long delcomperrbfilewhdrfailedField = 0;
    private long delcomperrbfilewhdrfailedrateField = 0;
    private long delcomperrnostoremissField = 0;
    private long delcomperrnostoremissrateField = 0;
    private long delcomperrreqinfotoobigField = 0;
    private long delcomperrreqinfotoobigrateField = 0;
    private long delcomperrreqinfoallocfailField = 0;
    private long delcomperrreqinfoallocfailrateField = 0;
    private long delcomperrsessallocfailField = 0;
    private long delcomperrsessallocfailrateField = 0;

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public double comphttpbandwidthsaving
    {
      get => this.comphttpbandwidthsavingField;
      private set => this.comphttpbandwidthsavingField = value;
    }

    public long decomptcptxpacketsrate
    {
      get => this.decomptcptxpacketsrateField;
      private set => this.decomptcptxpacketsrateField = value;
    }

    public long delcompbasetcptxbytesrate
    {
      get => this.delcompbasetcptxbytesrateField;
      private set => this.delcompbasetcptxbytesrateField = value;
    }

    public long comptotaltxbytes
    {
      get => this.comptotaltxbytesField;
      private set => this.comptotaltxbytesField = value;
    }

    public long comptcpeoirate
    {
      get => this.comptcpeoirateField;
      private set => this.comptcpeoirateField = value;
    }

    public long delcomperrbypassedrate
    {
      get => this.delcomperrbypassedrateField;
      private set => this.delcomperrbypassedrateField = value;
    }

    public double delcmpratio
    {
      get => this.delcmpratioField;
      private set => this.delcmpratioField = value;
    }

    public long delcomprequestsrate
    {
      get => this.delcomprequestsrateField;
      private set => this.delcomprequestsrateField = value;
    }

    public long delcomptcprxpacketsrate
    {
      get => this.delcomptcprxpacketsrateField;
      private set => this.delcomptcprxpacketsrateField = value;
    }

    public long decomptcperrmemory
    {
      get => this.decomptcperrmemoryField;
      private set => this.decomptcperrmemoryField = value;
    }

    public double comptotaldatacompressionratio
    {
      get => this.comptotaldatacompressionratioField;
      private set => this.comptotaldatacompressionratioField = value;
    }

    public long comprxbytesrate
    {
      get => this.comprxbytesrateField;
      private set => this.comprxbytesrateField = value;
    }

    public long delcomperrsessallocfailrate
    {
      get => this.delcomperrsessallocfailrateField;
      private set => this.delcomperrsessallocfailrateField = value;
    }

    public long delcomptcptxpacketsrate
    {
      get => this.delcomptcptxpacketsrateField;
      private set => this.delcomptcptxpacketsrateField = value;
    }

    public long decomptcperrmemoryrate
    {
      get => this.decomptcperrmemoryrateField;
      private set => this.decomptcperrmemoryrateField = value;
    }

    public long decomptcperrmoredata
    {
      get => this.decomptcperrmoredataField;
      private set => this.decomptcperrmoredataField = value;
    }

    public long delcompfirstaccessrate
    {
      get => this.delcompfirstaccessrateField;
      private set => this.delcompfirstaccessrateField = value;
    }

    public long comprxpacketsrate
    {
      get => this.comprxpacketsrateField;
      private set => this.comprxpacketsrateField = value;
    }

    public long decomptcprxpacketsrate
    {
      get => this.decomptcprxpacketsrateField;
      private set => this.decomptcprxpacketsrateField = value;
    }

    public long comptcpquantumrate
    {
      get => this.comptcpquantumrateField;
      private set => this.comptcpquantumrateField = value;
    }

    public long comptxbytesrate
    {
      get => this.comptxbytesrateField;
      private set => this.comptxbytesrateField = value;
    }

    public long delcompbaseservedrate
    {
      get => this.delcompbaseservedrateField;
      private set => this.delcompbaseservedrateField = value;
    }

    public long comptcptxbytesrate
    {
      get => this.comptcptxbytesrateField;
      private set => this.comptcptxbytesrateField = value;
    }

    public long delcomptcprxpackets
    {
      get => this.delcomptcprxpacketsField;
      private set => this.delcomptcprxpacketsField = value;
    }

    public long delcomperrbfilewhdrfailed
    {
      get => this.delcomperrbfilewhdrfailedField;
      private set => this.delcomperrbfilewhdrfailedField = value;
    }

    public long decomptcperrmoredatarate
    {
      get => this.decomptcperrmoredatarateField;
      private set => this.decomptcperrmoredatarateField = value;
    }

    public long delcompbaseserved
    {
      get => this.delcompbaseservedField;
      private set => this.delcompbaseservedField = value;
    }

    public double compratio
    {
      get => this.compratioField;
      private set => this.compratioField = value;
    }

    public long decomptcperrlessdata
    {
      get => this.decomptcperrlessdataField;
      private set => this.decomptcperrlessdataField = value;
    }

    public long comptcprxbytesrate
    {
      get => this.comptcprxbytesrateField;
      private set => this.comptcprxbytesrateField = value;
    }

    public long comptcprxpacketsrate
    {
      get => this.comptcprxpacketsrateField;
      private set => this.comptcprxpacketsrateField = value;
    }

    public long delcomptcptxbytesrate
    {
      get => this.delcomptcptxbytesrateField;
      private set => this.delcomptcptxbytesrateField = value;
    }

    public long decomptcperrdatarate
    {
      get => this.decomptcperrdatarateField;
      private set => this.decomptcperrdatarateField = value;
    }

    public long delcompdonerate
    {
      get => this.delcompdonerateField;
      private set => this.delcompdonerateField = value;
    }

    public double decomptcpratio
    {
      get => this.decomptcpratioField;
      private set => this.decomptcpratioField = value;
    }

    public long decomptcperrlessdatarate
    {
      get => this.decomptcperrlessdatarateField;
      private set => this.decomptcperrlessdatarateField = value;
    }

    public long comptcptotaltxbytes
    {
      get => this.comptcptotaltxbytesField;
      private set => this.comptcptotaltxbytesField = value;
    }

    public long delcomptotalrequests
    {
      get => this.delcomptotalrequestsField;
      private set => this.delcomptotalrequestsField = value;
    }

    public long delcomperrreqinfoallocfailrate
    {
      get => this.delcomperrreqinfoallocfailrateField;
      private set => this.delcomperrreqinfoallocfailrateField = value;
    }

    public long delcomperrnostoremiss
    {
      get => this.delcomperrnostoremissField;
      private set => this.delcomperrnostoremissField = value;
    }

    public long delcompbasetcptxbytes
    {
      get => this.delcompbasetcptxbytesField;
      private set => this.delcompbasetcptxbytesField = value;
    }

    public long comptcptotalpush
    {
      get => this.comptcptotalpushField;
      private set => this.comptcptotalpushField = value;
    }

    public long delcompfirstaccess
    {
      get => this.delcompfirstaccessField;
      private set => this.delcompfirstaccessField = value;
    }

    public long delcompdone
    {
      get => this.delcompdoneField;
      private set => this.delcompdoneField = value;
    }

    public long comptcptotalrxpackets
    {
      get => this.comptcptotalrxpacketsField;
      private set => this.comptcptotalrxpacketsField = value;
    }

    public long delcomperrbypassed
    {
      get => this.delcomperrbypassedField;
      private set => this.delcomperrbypassedField = value;
    }

    public double delbwsaving
    {
      get => this.delbwsavingField;
      private set => this.delbwsavingField = value;
    }

    public long comprequestsrate
    {
      get => this.comprequestsrateField;
      private set => this.comprequestsrateField = value;
    }

    public long delcomptcptxbytes
    {
      get => this.delcomptcptxbytesField;
      private set => this.delcomptcptxbytesField = value;
    }

    public long delcomperrreqinfoallocfail
    {
      get => this.delcomperrreqinfoallocfailField;
      private set => this.delcomperrreqinfoallocfailField = value;
    }

    public long delcomperrreqinfotoobig
    {
      get => this.delcomperrreqinfotoobigField;
      private set => this.delcomperrreqinfotoobigField = value;
    }

    public long decomptcprxbytes
    {
      get => this.decomptcprxbytesField;
      private set => this.decomptcprxbytesField = value;
    }

    public long comptcptxpacketsrate
    {
      get => this.comptcptxpacketsrateField;
      private set => this.comptcptxpacketsrateField = value;
    }

    public long comptcptotaleoi
    {
      get => this.comptcptotaleoiField;
      private set => this.comptcptotaleoiField = value;
    }

    public long comptcppushrate
    {
      get => this.comptcppushrateField;
      private set => this.comptcppushrateField = value;
    }

    public long decomptcperrunknownrate
    {
      get => this.decomptcperrunknownrateField;
      private set => this.decomptcperrunknownrateField = value;
    }

    public double comptcpbandwidthsaving
    {
      get => this.comptcpbandwidthsavingField;
      private set => this.comptcpbandwidthsavingField = value;
    }

    public long comptotalrxbytes
    {
      get => this.comptotalrxbytesField;
      private set => this.comptotalrxbytesField = value;
    }

    public long decomptcptxbytes
    {
      get => this.decomptcptxbytesField;
      private set => this.decomptcptxbytesField = value;
    }

    public long decomptcprxpackets
    {
      get => this.decomptcprxpacketsField;
      private set => this.decomptcprxpacketsField = value;
    }

    public long comptcptotaltimer
    {
      get => this.comptcptotaltimerField;
      private set => this.comptcptotaltimerField = value;
    }

    public long delcomperrnostoremissrate
    {
      get => this.delcomperrnostoremissrateField;
      private set => this.delcomperrnostoremissrateField = value;
    }

    public double decomptcpbandwidthsaving
    {
      get => this.decomptcpbandwidthsavingField;
      private set => this.decomptcpbandwidthsavingField = value;
    }

    public long delcomperrsessallocfail
    {
      get => this.delcomperrsessallocfailField;
      private set => this.delcomperrsessallocfailField = value;
    }

    public long decomptcptxbytesrate
    {
      get => this.decomptcptxbytesrateField;
      private set => this.decomptcptxbytesrateField = value;
    }

    public long comptxpacketsrate
    {
      get => this.comptxpacketsrateField;
      private set => this.comptxpacketsrateField = value;
    }

    public long comptotaltxpackets
    {
      get => this.comptotaltxpacketsField;
      private set => this.comptotaltxpacketsField = value;
    }

    public long delcomperrreqinfotoobigrate
    {
      get => this.delcomperrreqinfotoobigrateField;
      private set => this.delcomperrreqinfotoobigrateField = value;
    }

    public long decomptcprxbytesrate
    {
      get => this.decomptcprxbytesrateField;
      private set => this.decomptcprxbytesrateField = value;
    }

    public long comptotalrequests
    {
      get => this.comptotalrequestsField;
      private set => this.comptotalrequestsField = value;
    }

    public long decomptcperrunknown
    {
      get => this.decomptcperrunknownField;
      private set => this.decomptcperrunknownField = value;
    }

    public long comptotalrxpackets
    {
      get => this.comptotalrxpacketsField;
      private set => this.comptotalrxpacketsField = value;
    }

    public long delcomptcprxbytes
    {
      get => this.delcomptcprxbytesField;
      private set => this.delcomptcprxbytesField = value;
    }

    public long comptcptimerrate
    {
      get => this.comptcptimerrateField;
      private set => this.comptcptimerrateField = value;
    }

    public long comptcptotalquantum
    {
      get => this.comptcptotalquantumField;
      private set => this.comptcptotalquantumField = value;
    }

    public long comptcptotaltxpackets
    {
      get => this.comptcptotaltxpacketsField;
      private set => this.comptcptotaltxpacketsField = value;
    }

    public long delcomptcptxpackets
    {
      get => this.delcomptcptxpacketsField;
      private set => this.delcomptcptxpacketsField = value;
    }

    public long comptcptotalrxbytes
    {
      get => this.comptcptotalrxbytesField;
      private set => this.comptcptotalrxbytesField = value;
    }

    public long delcomptcprxbytesrate
    {
      get => this.delcomptcprxbytesrateField;
      private set => this.delcomptcprxbytesrateField = value;
    }

    public long decomptcptxpackets
    {
      get => this.decomptcptxpacketsField;
      private set => this.decomptcptxpacketsField = value;
    }

    public long delcomperrbfilewhdrfailedrate
    {
      get => this.delcomperrbfilewhdrfailedrateField;
      private set => this.delcomperrbfilewhdrfailedrateField = value;
    }

    public double comptcpratio
    {
      get => this.comptcpratioField;
      private set => this.comptcpratioField = value;
    }

    public long decomptcperrdata
    {
      get => this.decomptcperrdataField;
      private set => this.decomptcperrdataField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      cmp_stats[] cmpStatsArray = new cmp_stats[1];
      cmp_stats.cmp_response cmpResponse = new cmp_stats.cmp_response();
      cmp_stats.cmp_response resource = (cmp_stats.cmp_response) service.get_payload_formatter().string_to_resource(cmpResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      cmpStatsArray[0] = resource.cmp;
      return (base_resource[]) cmpStatsArray;
    }

    internal override string get_object_name() => (string) null;

    public static cmp_stats get(nitro_service service) => ((cmp_stats[]) new cmp_stats().stat_resources(service, (options) null))[0];

    public static cmp_stats get(nitro_service service, options option) => ((cmp_stats[]) new cmp_stats().stat_resources(service, option))[0];

    private class cmp_response : base_response
    {
      public cmp_stats cmp = (cmp_stats) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
