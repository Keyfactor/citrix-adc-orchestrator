// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.protocol.protocolicmp_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.protocol
{
  public class protocolicmp_stats : base_resource
  {
    private string clearstatsField = (string) null;
    private long icmptotrxpktsField = 0;
    private long icmprxpktsrateField = 0;
    private long icmptotrxbytesField = 0;
    private long icmprxbytesrateField = 0;
    private long icmptottxpktsField = 0;
    private long icmptxpktsrateField = 0;
    private long icmptottxbytesField = 0;
    private long icmptxbytesrateField = 0;
    private long icmptotrxechoreplyField = 0;
    private long icmprxechoreplyrateField = 0;
    private long icmptottxechoreplyField = 0;
    private long icmptxechoreplyrateField = 0;
    private long icmptotrxechoField = 0;
    private long icmprxechorateField = 0;
    private long icmptotdstiplookupField = 0;
    private long icmpcurratethresholdField = 0;
    private long icmptotportunreachablerxField = 0;
    private long icmptotportunreachabletxField = 0;
    private long icmptotneedfragrxField = 0;
    private long icmptotthresholdexceedsField = 0;
    private long icmptotpktsdroppedField = 0;
    private long icmptotbadchecksumField = 0;
    private long icmptotnonfirstipfragField = 0;
    private long icmptotinvalidbodylenField = 0;
    private long icmptotnotcpconnField = 0;
    private long icmptotnoudpconnField = 0;
    private long icmptotinvalidtcpseqnoField = 0;
    private long icmptotinvalidnextmtuvalField = 0;
    private long icmptotbignextmtuField = 0;
    private long icmptotinvalidprotocolField = 0;
    private long icmptotbadpmtuipchecksumField = 0;
    private long icmptotpmtunolinkField = 0;
    private long icmptotpmtudiscoverydisabledField = 0;

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long icmprxbytesrate
    {
      get => this.icmprxbytesrateField;
      private set => this.icmprxbytesrateField = value;
    }

    public long icmptotpktsdropped
    {
      get => this.icmptotpktsdroppedField;
      private set => this.icmptotpktsdroppedField = value;
    }

    public long icmptotrxechoreply
    {
      get => this.icmptotrxechoreplyField;
      private set => this.icmptotrxechoreplyField = value;
    }

    public long icmptotthresholdexceeds
    {
      get => this.icmptotthresholdexceedsField;
      private set => this.icmptotthresholdexceedsField = value;
    }

    public long icmptotbadpmtuipchecksum
    {
      get => this.icmptotbadpmtuipchecksumField;
      private set => this.icmptotbadpmtuipchecksumField = value;
    }

    public long icmprxechoreplyrate
    {
      get => this.icmprxechoreplyrateField;
      private set => this.icmprxechoreplyrateField = value;
    }

    public long icmptxpktsrate
    {
      get => this.icmptxpktsrateField;
      private set => this.icmptxpktsrateField = value;
    }

    public long icmptotbadchecksum
    {
      get => this.icmptotbadchecksumField;
      private set => this.icmptotbadchecksumField = value;
    }

    public long icmptotnonfirstipfrag
    {
      get => this.icmptotnonfirstipfragField;
      private set => this.icmptotnonfirstipfragField = value;
    }

    public long icmptotinvalidbodylen
    {
      get => this.icmptotinvalidbodylenField;
      private set => this.icmptotinvalidbodylenField = value;
    }

    public long icmptottxechoreply
    {
      get => this.icmptottxechoreplyField;
      private set => this.icmptottxechoreplyField = value;
    }

    public long icmptotpmtunolink
    {
      get => this.icmptotpmtunolinkField;
      private set => this.icmptotpmtunolinkField = value;
    }

    public long icmptotinvalidprotocol
    {
      get => this.icmptotinvalidprotocolField;
      private set => this.icmptotinvalidprotocolField = value;
    }

    public long icmptottxpkts
    {
      get => this.icmptottxpktsField;
      private set => this.icmptottxpktsField = value;
    }

    public long icmptotinvalidnextmtuval
    {
      get => this.icmptotinvalidnextmtuvalField;
      private set => this.icmptotinvalidnextmtuvalField = value;
    }

    public long icmptotportunreachablerx
    {
      get => this.icmptotportunreachablerxField;
      private set => this.icmptotportunreachablerxField = value;
    }

    public long icmptotneedfragrx
    {
      get => this.icmptotneedfragrxField;
      private set => this.icmptotneedfragrxField = value;
    }

    public long icmptotrxecho
    {
      get => this.icmptotrxechoField;
      private set => this.icmptotrxechoField = value;
    }

    public long icmptotdstiplookup
    {
      get => this.icmptotdstiplookupField;
      private set => this.icmptotdstiplookupField = value;
    }

    public long icmprxechorate
    {
      get => this.icmprxechorateField;
      private set => this.icmprxechorateField = value;
    }

    public long icmptotbignextmtu
    {
      get => this.icmptotbignextmtuField;
      private set => this.icmptotbignextmtuField = value;
    }

    public long icmptxechoreplyrate
    {
      get => this.icmptxechoreplyrateField;
      private set => this.icmptxechoreplyrateField = value;
    }

    public long icmptotpmtudiscoverydisabled
    {
      get => this.icmptotpmtudiscoverydisabledField;
      private set => this.icmptotpmtudiscoverydisabledField = value;
    }

    public long icmprxpktsrate
    {
      get => this.icmprxpktsrateField;
      private set => this.icmprxpktsrateField = value;
    }

    public long icmptotnoudpconn
    {
      get => this.icmptotnoudpconnField;
      private set => this.icmptotnoudpconnField = value;
    }

    public long icmptottxbytes
    {
      get => this.icmptottxbytesField;
      private set => this.icmptottxbytesField = value;
    }

    public long icmptotrxbytes
    {
      get => this.icmptotrxbytesField;
      private set => this.icmptotrxbytesField = value;
    }

    public long icmptotrxpkts
    {
      get => this.icmptotrxpktsField;
      private set => this.icmptotrxpktsField = value;
    }

    public long icmptotportunreachabletx
    {
      get => this.icmptotportunreachabletxField;
      private set => this.icmptotportunreachabletxField = value;
    }

    public long icmptotnotcpconn
    {
      get => this.icmptotnotcpconnField;
      private set => this.icmptotnotcpconnField = value;
    }

    public long icmptotinvalidtcpseqno
    {
      get => this.icmptotinvalidtcpseqnoField;
      private set => this.icmptotinvalidtcpseqnoField = value;
    }

    public long icmpcurratethreshold
    {
      get => this.icmpcurratethresholdField;
      private set => this.icmpcurratethresholdField = value;
    }

    public long icmptxbytesrate
    {
      get => this.icmptxbytesrateField;
      private set => this.icmptxbytesrateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      protocolicmp_stats[] protocolicmpStatsArray = new protocolicmp_stats[1];
      protocolicmp_stats.protocolicmp_response protocolicmpResponse = new protocolicmp_stats.protocolicmp_response();
      protocolicmp_stats.protocolicmp_response resource = (protocolicmp_stats.protocolicmp_response) service.get_payload_formatter().string_to_resource(protocolicmpResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      protocolicmpStatsArray[0] = resource.protocolicmp;
      return (base_resource[]) protocolicmpStatsArray;
    }

    internal override string get_object_name() => (string) null;

    public static protocolicmp_stats get(nitro_service service) => ((protocolicmp_stats[]) new protocolicmp_stats().stat_resources(service, (options) null))[0];

    public static protocolicmp_stats get(nitro_service service, options option) => ((protocolicmp_stats[]) new protocolicmp_stats().stat_resources(service, option))[0];

    private class protocolicmp_response : base_response
    {
      public protocolicmp_stats protocolicmp = (protocolicmp_stats) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
