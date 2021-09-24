// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.protocol.protocolip_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.protocol
{
  public class protocolip_stats : base_resource
  {
    private string clearstatsField = (string) null;
    private long iptotrxpktsField = 0;
    private long iprxpktsrateField = 0;
    private long iptotrxbytesField = 0;
    private long iprxbytesrateField = 0;
    private long iptottxpktsField = 0;
    private long iptxpktsrateField = 0;
    private long iptottxbytesField = 0;
    private long iptxbytesrateField = 0;
    private long iptotrxmbitsField = 0;
    private long iprxmbitsrateField = 0;
    private long iptottxmbitsField = 0;
    private long iptxmbitsrateField = 0;
    private long iptotroutedpktsField = 0;
    private long iproutedpktsrateField = 0;
    private long iptotroutedmbitsField = 0;
    private long iproutedmbitsrateField = 0;
    private long iptotfragmentsField = 0;
    private long iptotsuccreassemblyField = 0;
    private long iptotreassemblyattemptField = 0;
    private long iptotaddrlookupField = 0;
    private long iptotaddrlookupfailField = 0;
    private long iptotudpfragmentsfwdField = 0;
    private long iptottcpfragmentsfwdField = 0;
    private long iptotfragpktsgenField = 0;
    private long iptotbadchecksumsField = 0;
    private long iptotunsuccreassemblyField = 0;
    private long iptottoobigField = 0;
    private long iptotzerofragmentlenField = 0;
    private long iptotdupfragmentsField = 0;
    private long iptotoutoforderfragField = 0;
    private long iptotunknowndstrcvdField = 0;
    private long iptotbadtransportField = 0;
    private long iptotvipdownField = 0;
    private long iptotfixheaderfailField = 0;
    private long iptotttlexpiredField = 0;
    private long iptotmaxclientsField = 0;
    private long iptotunknownsvcsField = 0;
    private long iptotlandattacksField = 0;
    private long iptotinvalidheaderszField = 0;
    private long iptotinvalidpacketsizeField = 0;
    private long iptottruncatedpacketsField = 0;
    private long noniptottruncatedpacketsField = 0;
    private long iptotzeronexthopField = 0;
    private long iptotbadlensField = 0;
    private long iptotbadmacaddrsField = 0;

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long iproutedpktsrate
    {
      get => this.iproutedpktsrateField;
      private set => this.iproutedpktsrateField = value;
    }

    public long iptotoutoforderfrag
    {
      get => this.iptotoutoforderfragField;
      private set => this.iptotoutoforderfragField = value;
    }

    public long noniptottruncatedpackets
    {
      get => this.noniptottruncatedpacketsField;
      private set => this.noniptottruncatedpacketsField = value;
    }

    public long iptotmaxclients
    {
      get => this.iptotmaxclientsField;
      private set => this.iptotmaxclientsField = value;
    }

    public long iptotzerofragmentlen
    {
      get => this.iptotzerofragmentlenField;
      private set => this.iptotzerofragmentlenField = value;
    }

    public long iptxbytesrate
    {
      get => this.iptxbytesrateField;
      private set => this.iptxbytesrateField = value;
    }

    public long iptotvipdown
    {
      get => this.iptotvipdownField;
      private set => this.iptotvipdownField = value;
    }

    public long iptotroutedpkts
    {
      get => this.iptotroutedpktsField;
      private set => this.iptotroutedpktsField = value;
    }

    public long iprxmbitsrate
    {
      get => this.iprxmbitsrateField;
      private set => this.iprxmbitsrateField = value;
    }

    public long iprxpktsrate
    {
      get => this.iprxpktsrateField;
      private set => this.iprxpktsrateField = value;
    }

    public long iptxmbitsrate
    {
      get => this.iptxmbitsrateField;
      private set => this.iptxmbitsrateField = value;
    }

    public long iptotroutedmbits
    {
      get => this.iptotroutedmbitsField;
      private set => this.iptotroutedmbitsField = value;
    }

    public long iptotinvalidheadersz
    {
      get => this.iptotinvalidheaderszField;
      private set => this.iptotinvalidheaderszField = value;
    }

    public long iptotaddrlookupfail
    {
      get => this.iptotaddrlookupfailField;
      private set => this.iptotaddrlookupfailField = value;
    }

    public long iptotbadtransport
    {
      get => this.iptotbadtransportField;
      private set => this.iptotbadtransportField = value;
    }

    public long iptotfragpktsgen
    {
      get => this.iptotfragpktsgenField;
      private set => this.iptotfragpktsgenField = value;
    }

    public long iptotsuccreassembly
    {
      get => this.iptotsuccreassemblyField;
      private set => this.iptotsuccreassemblyField = value;
    }

    public long iptotrxmbits
    {
      get => this.iptotrxmbitsField;
      private set => this.iptotrxmbitsField = value;
    }

    public long iptottxbytes
    {
      get => this.iptottxbytesField;
      private set => this.iptottxbytesField = value;
    }

    public long iptotbadmacaddrs
    {
      get => this.iptotbadmacaddrsField;
      private set => this.iptotbadmacaddrsField = value;
    }

    public long iptottcpfragmentsfwd
    {
      get => this.iptottcpfragmentsfwdField;
      private set => this.iptottcpfragmentsfwdField = value;
    }

    public long iptotrxpkts
    {
      get => this.iptotrxpktsField;
      private set => this.iptotrxpktsField = value;
    }

    public long iptotrxbytes
    {
      get => this.iptotrxbytesField;
      private set => this.iptotrxbytesField = value;
    }

    public long iptotlandattacks
    {
      get => this.iptotlandattacksField;
      private set => this.iptotlandattacksField = value;
    }

    public long iptotunknowndstrcvd
    {
      get => this.iptotunknowndstrcvdField;
      private set => this.iptotunknowndstrcvdField = value;
    }

    public long iptottruncatedpackets
    {
      get => this.iptottruncatedpacketsField;
      private set => this.iptottruncatedpacketsField = value;
    }

    public long iptotttlexpired
    {
      get => this.iptotttlexpiredField;
      private set => this.iptotttlexpiredField = value;
    }

    public long iprxbytesrate
    {
      get => this.iprxbytesrateField;
      private set => this.iprxbytesrateField = value;
    }

    public long iptottxmbits
    {
      get => this.iptottxmbitsField;
      private set => this.iptottxmbitsField = value;
    }

    public long iptotbadlens
    {
      get => this.iptotbadlensField;
      private set => this.iptotbadlensField = value;
    }

    public long iptotunknownsvcs
    {
      get => this.iptotunknownsvcsField;
      private set => this.iptotunknownsvcsField = value;
    }

    public long iptotdupfragments
    {
      get => this.iptotdupfragmentsField;
      private set => this.iptotdupfragmentsField = value;
    }

    public long iptottoobig
    {
      get => this.iptottoobigField;
      private set => this.iptottoobigField = value;
    }

    public long iptotzeronexthop
    {
      get => this.iptotzeronexthopField;
      private set => this.iptotzeronexthopField = value;
    }

    public long iptotaddrlookup
    {
      get => this.iptotaddrlookupField;
      private set => this.iptotaddrlookupField = value;
    }

    public long iptotfragments
    {
      get => this.iptotfragmentsField;
      private set => this.iptotfragmentsField = value;
    }

    public long iptotinvalidpacketsize
    {
      get => this.iptotinvalidpacketsizeField;
      private set => this.iptotinvalidpacketsizeField = value;
    }

    public long iptotunsuccreassembly
    {
      get => this.iptotunsuccreassemblyField;
      private set => this.iptotunsuccreassemblyField = value;
    }

    public long iptotreassemblyattempt
    {
      get => this.iptotreassemblyattemptField;
      private set => this.iptotreassemblyattemptField = value;
    }

    public long iptottxpkts
    {
      get => this.iptottxpktsField;
      private set => this.iptottxpktsField = value;
    }

    public long iptxpktsrate
    {
      get => this.iptxpktsrateField;
      private set => this.iptxpktsrateField = value;
    }

    public long iptotbadchecksums
    {
      get => this.iptotbadchecksumsField;
      private set => this.iptotbadchecksumsField = value;
    }

    public long iptotfixheaderfail
    {
      get => this.iptotfixheaderfailField;
      private set => this.iptotfixheaderfailField = value;
    }

    public long iproutedmbitsrate
    {
      get => this.iproutedmbitsrateField;
      private set => this.iproutedmbitsrateField = value;
    }

    public long iptotudpfragmentsfwd
    {
      get => this.iptotudpfragmentsfwdField;
      private set => this.iptotudpfragmentsfwdField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      protocolip_stats[] protocolipStatsArray = new protocolip_stats[1];
      protocolip_stats.protocolip_response protocolipResponse = new protocolip_stats.protocolip_response();
      protocolip_stats.protocolip_response resource = (protocolip_stats.protocolip_response) service.get_payload_formatter().string_to_resource(protocolipResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      protocolipStatsArray[0] = resource.protocolip;
      return (base_resource[]) protocolipStatsArray;
    }

    internal override string get_object_name() => (string) null;

    public static protocolip_stats get(nitro_service service) => ((protocolip_stats[]) new protocolip_stats().stat_resources(service, (options) null))[0];

    public static protocolip_stats get(nitro_service service, options option) => ((protocolip_stats[]) new protocolip_stats().stat_resources(service, option))[0];

    private class protocolip_response : base_response
    {
      public protocolip_stats protocolip = (protocolip_stats) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
