// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.qos.qos_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.qos
{
  public class qos_stats : base_resource
  {
    private string clearstatsField = (string) null;
    private long ipcmessagessentField = 0;
    private long ipcmessagessentrateField = 0;
    private long ipcmessagesfailedField = 0;
    private long ipcmessagesfailedrateField = 0;
    private long ipcmessagesreceivedField = 0;
    private long ipcmessagesreceivedrateField = 0;
    private long ipcpe2qossentField = 0;
    private long ipcpe2qossentrateField = 0;
    private long ipcpe2qosfailedField = 0;
    private long ipcpe2qosfailedrateField = 0;
    private long ipcpe2qosreceivedField = 0;
    private long ipcpe2qosreceivedrateField = 0;
    private long qosbytesdroppedField = 0;
    private long qosbytesdroppedrateField = 0;
    private long qosbytessentnotclassifiedField = 0;
    private long qosbytessentnotclassifiedrateField = 0;
    private long qosbytesdroppednoconnectionField = 0;
    private long qosbytesdroppednoconnectionrateField = 0;
    private long qosinputpacketsField = 0;
    private long qosinputpacketsrateField = 0;
    private long qosoutputpacketsField = 0;
    private long qosoutputpacketsrateField = 0;
    private long qosdroppacketsField = 0;
    private long qosdroppacketsrateField = 0;
    private long qosrewritemacsField = 0;
    private long qosrewritemacsrateField = 0;
    private long qospacketsunclassifiedField = 0;
    private long qospacketsunclassifiedrateField = 0;
    private long qospacketsclassifiedField = 0;
    private long qospacketsclassifiedrateField = 0;
    private long qoslearnedmacField = 0;
    private long qoslearnedmacrateField = 0;
    private long qosinputbytesField = 0;
    private long qosinputbytesrateField = 0;
    private long qosoutputbytesField = 0;
    private long qosoutputbytesrateField = 0;
    private long qosfreeheldlistField = 0;
    private long qoslink00sentField = 0;
    private long qoslink00sentrateField = 0;
    private long qoslink00dropField = 0;
    private long qoslink00droprateField = 0;
    private long qoslink01sentField = 0;
    private long qoslink01sentrateField = 0;
    private long qoslink01dropField = 0;
    private long qoslink01droprateField = 0;
    private long qoslink02sentField = 0;
    private long qoslink02sentrateField = 0;
    private long qoslink02dropField = 0;
    private long qoslink02droprateField = 0;
    private long qoslink03sentField = 0;
    private long qoslink03sentrateField = 0;
    private long qoslink03dropField = 0;
    private long qoslink03droprateField = 0;
    private long qoslink04sentField = 0;
    private long qoslink04sentrateField = 0;
    private long qoslink04dropField = 0;
    private long qoslink04droprateField = 0;
    private long qoslink05sentField = 0;
    private long qoslink05sentrateField = 0;
    private long qoslink05dropField = 0;
    private long qoslink05droprateField = 0;
    private long qoslink06sentField = 0;
    private long qoslink06sentrateField = 0;
    private long qoslink06dropField = 0;
    private long qoslink06droprateField = 0;
    private long qoslink07sentField = 0;
    private long qoslink07sentrateField = 0;
    private long qoslink07dropField = 0;
    private long qoslink07droprateField = 0;
    private long qoslink08sentField = 0;
    private long qoslink08sentrateField = 0;
    private long qoslink08dropField = 0;
    private long qoslink08droprateField = 0;
    private long qoslink09sentField = 0;
    private long qoslink09sentrateField = 0;
    private long qoslink09dropField = 0;
    private long qoslink09droprateField = 0;
    private long qoslink10sentField = 0;
    private long qoslink10sentrateField = 0;
    private long qoslink10dropField = 0;
    private long qoslink10droprateField = 0;

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long qoslink06droprate
    {
      get => this.qoslink06droprateField;
      private set => this.qoslink06droprateField = value;
    }

    public long ipcpe2qosfailed
    {
      get => this.ipcpe2qosfailedField;
      private set => this.ipcpe2qosfailedField = value;
    }

    public long qoslink02sent
    {
      get => this.qoslink02sentField;
      private set => this.qoslink02sentField = value;
    }

    public long qoslink10sent
    {
      get => this.qoslink10sentField;
      private set => this.qoslink10sentField = value;
    }

    public long ipcmessagessentrate
    {
      get => this.ipcmessagessentrateField;
      private set => this.ipcmessagessentrateField = value;
    }

    public long qoslink02sentrate
    {
      get => this.qoslink02sentrateField;
      private set => this.qoslink02sentrateField = value;
    }

    public long qosrewritemacsrate
    {
      get => this.qosrewritemacsrateField;
      private set => this.qosrewritemacsrateField = value;
    }

    public long qoslink08sentrate
    {
      get => this.qoslink08sentrateField;
      private set => this.qoslink08sentrateField = value;
    }

    public long qoslink04drop
    {
      get => this.qoslink04dropField;
      private set => this.qoslink04dropField = value;
    }

    public long qoslink01droprate
    {
      get => this.qoslink01droprateField;
      private set => this.qoslink01droprateField = value;
    }

    public long qosoutputbytesrate
    {
      get => this.qosoutputbytesrateField;
      private set => this.qosoutputbytesrateField = value;
    }

    public long qoslink08drop
    {
      get => this.qoslink08dropField;
      private set => this.qoslink08dropField = value;
    }

    public long qoslink05sent
    {
      get => this.qoslink05sentField;
      private set => this.qoslink05sentField = value;
    }

    public long qoslink10droprate
    {
      get => this.qoslink10droprateField;
      private set => this.qoslink10droprateField = value;
    }

    public long qoslink00drop
    {
      get => this.qoslink00dropField;
      private set => this.qoslink00dropField = value;
    }

    public long ipcmessagesfailedrate
    {
      get => this.ipcmessagesfailedrateField;
      private set => this.ipcmessagesfailedrateField = value;
    }

    public long qoslink05droprate
    {
      get => this.qoslink05droprateField;
      private set => this.qoslink05droprateField = value;
    }

    public long qoslink08droprate
    {
      get => this.qoslink08droprateField;
      private set => this.qoslink08droprateField = value;
    }

    public long qosbytessentnotclassifiedrate
    {
      get => this.qosbytessentnotclassifiedrateField;
      private set => this.qosbytessentnotclassifiedrateField = value;
    }

    public long qoslink03droprate
    {
      get => this.qoslink03droprateField;
      private set => this.qoslink03droprateField = value;
    }

    public long qoslink09sent
    {
      get => this.qoslink09sentField;
      private set => this.qoslink09sentField = value;
    }

    public long qospacketsunclassifiedrate
    {
      get => this.qospacketsunclassifiedrateField;
      private set => this.qospacketsunclassifiedrateField = value;
    }

    public long qosfreeheldlist
    {
      get => this.qosfreeheldlistField;
      private set => this.qosfreeheldlistField = value;
    }

    public long qospacketsclassified
    {
      get => this.qospacketsclassifiedField;
      private set => this.qospacketsclassifiedField = value;
    }

    public long qosbytesdroppednoconnectionrate
    {
      get => this.qosbytesdroppednoconnectionrateField;
      private set => this.qosbytesdroppednoconnectionrateField = value;
    }

    public long qoslink01sentrate
    {
      get => this.qoslink01sentrateField;
      private set => this.qoslink01sentrateField = value;
    }

    public long qoslink09sentrate
    {
      get => this.qoslink09sentrateField;
      private set => this.qoslink09sentrateField = value;
    }

    public long qoslink03drop
    {
      get => this.qoslink03dropField;
      private set => this.qoslink03dropField = value;
    }

    public long qoslink03sentrate
    {
      get => this.qoslink03sentrateField;
      private set => this.qoslink03sentrateField = value;
    }

    public long qoslink02drop
    {
      get => this.qoslink02dropField;
      private set => this.qoslink02dropField = value;
    }

    public long qosinputbytes
    {
      get => this.qosinputbytesField;
      private set => this.qosinputbytesField = value;
    }

    public long qosinputpacketsrate
    {
      get => this.qosinputpacketsrateField;
      private set => this.qosinputpacketsrateField = value;
    }

    public long qosoutputbytes
    {
      get => this.qosoutputbytesField;
      private set => this.qosoutputbytesField = value;
    }

    public long ipcmessagesfailed
    {
      get => this.ipcmessagesfailedField;
      private set => this.ipcmessagesfailedField = value;
    }

    public long qoslink07sentrate
    {
      get => this.qoslink07sentrateField;
      private set => this.qoslink07sentrateField = value;
    }

    public long qosinputbytesrate
    {
      get => this.qosinputbytesrateField;
      private set => this.qosinputbytesrateField = value;
    }

    public long qoslink04droprate
    {
      get => this.qoslink04droprateField;
      private set => this.qoslink04droprateField = value;
    }

    public long ipcpe2qosfailedrate
    {
      get => this.ipcpe2qosfailedrateField;
      private set => this.ipcpe2qosfailedrateField = value;
    }

    public long qosoutputpackets
    {
      get => this.qosoutputpacketsField;
      private set => this.qosoutputpacketsField = value;
    }

    public long qosbytesdroppedrate
    {
      get => this.qosbytesdroppedrateField;
      private set => this.qosbytesdroppedrateField = value;
    }

    public long qoslink06sent
    {
      get => this.qoslink06sentField;
      private set => this.qoslink06sentField = value;
    }

    public long qoslink04sent
    {
      get => this.qoslink04sentField;
      private set => this.qoslink04sentField = value;
    }

    public long qoslink00sent
    {
      get => this.qoslink00sentField;
      private set => this.qoslink00sentField = value;
    }

    public long qoslink07sent
    {
      get => this.qoslink07sentField;
      private set => this.qoslink07sentField = value;
    }

    public long qoslink09droprate
    {
      get => this.qoslink09droprateField;
      private set => this.qoslink09droprateField = value;
    }

    public long qoslink10drop
    {
      get => this.qoslink10dropField;
      private set => this.qoslink10dropField = value;
    }

    public long qospacketsunclassified
    {
      get => this.qospacketsunclassifiedField;
      private set => this.qospacketsunclassifiedField = value;
    }

    public long qosoutputpacketsrate
    {
      get => this.qosoutputpacketsrateField;
      private set => this.qosoutputpacketsrateField = value;
    }

    public long qoslink03sent
    {
      get => this.qoslink03sentField;
      private set => this.qoslink03sentField = value;
    }

    public long qoslink05sentrate
    {
      get => this.qoslink05sentrateField;
      private set => this.qoslink05sentrateField = value;
    }

    public long qoslink04sentrate
    {
      get => this.qoslink04sentrateField;
      private set => this.qoslink04sentrateField = value;
    }

    public long qosbytesdropped
    {
      get => this.qosbytesdroppedField;
      private set => this.qosbytesdroppedField = value;
    }

    public long qosdroppackets
    {
      get => this.qosdroppacketsField;
      private set => this.qosdroppacketsField = value;
    }

    public long qoslink06drop
    {
      get => this.qoslink06dropField;
      private set => this.qoslink06dropField = value;
    }

    public long qosinputpackets
    {
      get => this.qosinputpacketsField;
      private set => this.qosinputpacketsField = value;
    }

    public long qoslink07droprate
    {
      get => this.qoslink07droprateField;
      private set => this.qoslink07droprateField = value;
    }

    public long ipcmessagesreceived
    {
      get => this.ipcmessagesreceivedField;
      private set => this.ipcmessagesreceivedField = value;
    }

    public long qoslink09drop
    {
      get => this.qoslink09dropField;
      private set => this.qoslink09dropField = value;
    }

    public long qoslink02droprate
    {
      get => this.qoslink02droprateField;
      private set => this.qoslink02droprateField = value;
    }

    public long qoslink07drop
    {
      get => this.qoslink07dropField;
      private set => this.qoslink07dropField = value;
    }

    public long qoslink05drop
    {
      get => this.qoslink05dropField;
      private set => this.qoslink05dropField = value;
    }

    public long ipcpe2qosreceivedrate
    {
      get => this.ipcpe2qosreceivedrateField;
      private set => this.ipcpe2qosreceivedrateField = value;
    }

    public long qoslink00sentrate
    {
      get => this.qoslink00sentrateField;
      private set => this.qoslink00sentrateField = value;
    }

    public long ipcpe2qossent
    {
      get => this.ipcpe2qossentField;
      private set => this.ipcpe2qossentField = value;
    }

    public long qoslink01sent
    {
      get => this.qoslink01sentField;
      private set => this.qoslink01sentField = value;
    }

    public long qoslearnedmacrate
    {
      get => this.qoslearnedmacrateField;
      private set => this.qoslearnedmacrateField = value;
    }

    public long qoslink08sent
    {
      get => this.qoslink08sentField;
      private set => this.qoslink08sentField = value;
    }

    public long qoslink06sentrate
    {
      get => this.qoslink06sentrateField;
      private set => this.qoslink06sentrateField = value;
    }

    public long qoslink01drop
    {
      get => this.qoslink01dropField;
      private set => this.qoslink01dropField = value;
    }

    public long ipcmessagesreceivedrate
    {
      get => this.ipcmessagesreceivedrateField;
      private set => this.ipcmessagesreceivedrateField = value;
    }

    public long ipcpe2qossentrate
    {
      get => this.ipcpe2qossentrateField;
      private set => this.ipcpe2qossentrateField = value;
    }

    public long qosbytessentnotclassified
    {
      get => this.qosbytessentnotclassifiedField;
      private set => this.qosbytessentnotclassifiedField = value;
    }

    public long qoslearnedmac
    {
      get => this.qoslearnedmacField;
      private set => this.qoslearnedmacField = value;
    }

    public long ipcmessagessent
    {
      get => this.ipcmessagessentField;
      private set => this.ipcmessagessentField = value;
    }

    public long qoslink00droprate
    {
      get => this.qoslink00droprateField;
      private set => this.qoslink00droprateField = value;
    }

    public long qoslink10sentrate
    {
      get => this.qoslink10sentrateField;
      private set => this.qoslink10sentrateField = value;
    }

    public long ipcpe2qosreceived
    {
      get => this.ipcpe2qosreceivedField;
      private set => this.ipcpe2qosreceivedField = value;
    }

    public long qosdroppacketsrate
    {
      get => this.qosdroppacketsrateField;
      private set => this.qosdroppacketsrateField = value;
    }

    public long qosbytesdroppednoconnection
    {
      get => this.qosbytesdroppednoconnectionField;
      private set => this.qosbytesdroppednoconnectionField = value;
    }

    public long qospacketsclassifiedrate
    {
      get => this.qospacketsclassifiedrateField;
      private set => this.qospacketsclassifiedrateField = value;
    }

    public long qosrewritemacs
    {
      get => this.qosrewritemacsField;
      private set => this.qosrewritemacsField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      qos_stats[] qosStatsArray = new qos_stats[1];
      qos_stats.qos_response qosResponse = new qos_stats.qos_response();
      qos_stats.qos_response resource = (qos_stats.qos_response) service.get_payload_formatter().string_to_resource(qosResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      qosStatsArray[0] = resource.qos;
      return (base_resource[]) qosStatsArray;
    }

    internal override string get_object_name() => (string) null;

    public static qos_stats get(nitro_service service) => ((qos_stats[]) new qos_stats().stat_resources(service, (options) null))[0];

    public static qos_stats get(nitro_service service, options option) => ((qos_stats[]) new qos_stats().stat_resources(service, option))[0];

    private class qos_response : base_response
    {
      public qos_stats qos = (qos_stats) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
