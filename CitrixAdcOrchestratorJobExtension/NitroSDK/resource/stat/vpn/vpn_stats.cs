// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.vpn.vpn_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.vpn
{
  public class vpn_stats : base_resource
  {
    private string clearstatsField = (string) null;
    private long indexhtmlhitField = 0;
    private long indexhtmlnoservedField = 0;
    private long cfghtmlservedField = 0;
    private long cfghtmlservedrateField = 0;
    private long dnsreqhitField = 0;
    private long dnsreqhitrateField = 0;
    private long winsrequesthitField = 0;
    private long winsrequesthitrateField = 0;
    private long csrequesthitField = 0;
    private long csrequesthitrateField = 0;
    private long csnonhttpprobehitField = 0;
    private long csnonhttpprobehitrateField = 0;
    private long cshttpprobehitField = 0;
    private long cshttpprobehitrateField = 0;
    private long totalcsconnsuccField = 0;
    private long csconnsuccrateField = 0;
    private long totalfsrequestField = 0;
    private long fsrequestrateField = 0;
    private long iipdisabledmipusedField = 0;
    private long iipdisabledmipusedrateField = 0;
    private long iipfailedmipusedField = 0;
    private long iipfailedmipusedrateField = 0;
    private long iipspillovermipusedField = 0;
    private long iipspillovermipusedrateField = 0;
    private long iipdisabledmipdisabledField = 0;
    private long iipdisabledmipdisabledrateField = 0;
    private long iipfailedmipdisabledField = 0;
    private long iipfailedmipdisabledrateField = 0;
    private long socksmethreqrcvdField = 0;
    private long socksmethreqrcvdrateField = 0;
    private long socksmethreqsentField = 0;
    private long socksmethreqsentrateField = 0;
    private long socksmethresprcvdField = 0;
    private long socksmethresprcvdrateField = 0;
    private long socksmethrespsentField = 0;
    private long socksmethrespsentrateField = 0;
    private long socksconnreqrcvdField = 0;
    private long socksconnreqrcvdrateField = 0;
    private long socksconnreqsentField = 0;
    private long socksconnreqsentrateField = 0;
    private long socksconnresprcvdField = 0;
    private long socksconnresprcvdrateField = 0;
    private long socksconnrespsentField = 0;
    private long socksconnrespsentrateField = 0;
    private long socksservererrorField = 0;
    private long socksservererrorrateField = 0;
    private long socksclienterrorField = 0;
    private long socksclienterrorrateField = 0;
    private long staconnsuccessField = 0;
    private long staconnsuccessrateField = 0;
    private long staconnfailureField = 0;
    private long staconnfailurerateField = 0;
    private long cpsconnsuccessField = 0;
    private long cpsconnsuccessrateField = 0;
    private long cpsconnfailureField = 0;
    private long cpsconnfailurerateField = 0;
    private long starequestsentField = 0;
    private long starequestsentrateField = 0;
    private long staresponserecvdField = 0;
    private long staresponserecvdrateField = 0;
    private long icalicensefailureField = 0;
    private long icalicensefailurerateField = 0;

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long staconnfailurerate
    {
      get => this.staconnfailurerateField;
      private set => this.staconnfailurerateField = value;
    }

    public long totalcsconnsucc
    {
      get => this.totalcsconnsuccField;
      private set => this.totalcsconnsuccField = value;
    }

    public long csnonhttpprobehitrate
    {
      get => this.csnonhttpprobehitrateField;
      private set => this.csnonhttpprobehitrateField = value;
    }

    public long socksmethreqrcvd
    {
      get => this.socksmethreqrcvdField;
      private set => this.socksmethreqrcvdField = value;
    }

    public long iipspillovermipusedrate
    {
      get => this.iipspillovermipusedrateField;
      private set => this.iipspillovermipusedrateField = value;
    }

    public long iipfailedmipdisabled
    {
      get => this.iipfailedmipdisabledField;
      private set => this.iipfailedmipdisabledField = value;
    }

    public long cshttpprobehitrate
    {
      get => this.cshttpprobehitrateField;
      private set => this.cshttpprobehitrateField = value;
    }

    public long socksconnrespsentrate
    {
      get => this.socksconnrespsentrateField;
      private set => this.socksconnrespsentrateField = value;
    }

    public long starequestsent
    {
      get => this.starequestsentField;
      private set => this.starequestsentField = value;
    }

    public long socksservererrorrate
    {
      get => this.socksservererrorrateField;
      private set => this.socksservererrorrateField = value;
    }

    public long winsrequesthitrate
    {
      get => this.winsrequesthitrateField;
      private set => this.winsrequesthitrateField = value;
    }

    public long socksservererror
    {
      get => this.socksservererrorField;
      private set => this.socksservererrorField = value;
    }

    public long socksmethresprcvdrate
    {
      get => this.socksmethresprcvdrateField;
      private set => this.socksmethresprcvdrateField = value;
    }

    public long socksconnreqrcvd
    {
      get => this.socksconnreqrcvdField;
      private set => this.socksconnreqrcvdField = value;
    }

    public long totalfsrequest
    {
      get => this.totalfsrequestField;
      private set => this.totalfsrequestField = value;
    }

    public long socksmethreqrcvdrate
    {
      get => this.socksmethreqrcvdrateField;
      private set => this.socksmethreqrcvdrateField = value;
    }

    public long socksmethreqsentrate
    {
      get => this.socksmethreqsentrateField;
      private set => this.socksmethreqsentrateField = value;
    }

    public long cpsconnfailurerate
    {
      get => this.cpsconnfailurerateField;
      private set => this.cpsconnfailurerateField = value;
    }

    public long iipdisabledmipdisabled
    {
      get => this.iipdisabledmipdisabledField;
      private set => this.iipdisabledmipdisabledField = value;
    }

    public long cshttpprobehit
    {
      get => this.cshttpprobehitField;
      private set => this.cshttpprobehitField = value;
    }

    public long iipspillovermipused
    {
      get => this.iipspillovermipusedField;
      private set => this.iipspillovermipusedField = value;
    }

    public long cpsconnsuccess
    {
      get => this.cpsconnsuccessField;
      private set => this.cpsconnsuccessField = value;
    }

    public long iipdisabledmipusedrate
    {
      get => this.iipdisabledmipusedrateField;
      private set => this.iipdisabledmipusedrateField = value;
    }

    public long socksmethrespsentrate
    {
      get => this.socksmethrespsentrateField;
      private set => this.socksmethrespsentrateField = value;
    }

    public long socksmethreqsent
    {
      get => this.socksmethreqsentField;
      private set => this.socksmethreqsentField = value;
    }

    public long icalicensefailurerate
    {
      get => this.icalicensefailurerateField;
      private set => this.icalicensefailurerateField = value;
    }

    public long staconnfailure
    {
      get => this.staconnfailureField;
      private set => this.staconnfailureField = value;
    }

    public long socksconnreqrcvdrate
    {
      get => this.socksconnreqrcvdrateField;
      private set => this.socksconnreqrcvdrateField = value;
    }

    public long socksclienterrorrate
    {
      get => this.socksclienterrorrateField;
      private set => this.socksclienterrorrateField = value;
    }

    public long csrequesthit
    {
      get => this.csrequesthitField;
      private set => this.csrequesthitField = value;
    }

    public long winsrequesthit
    {
      get => this.winsrequesthitField;
      private set => this.winsrequesthitField = value;
    }

    public long dnsreqhitrate
    {
      get => this.dnsreqhitrateField;
      private set => this.dnsreqhitrateField = value;
    }

    public long socksconnresprcvd
    {
      get => this.socksconnresprcvdField;
      private set => this.socksconnresprcvdField = value;
    }

    public long socksmethrespsent
    {
      get => this.socksmethrespsentField;
      private set => this.socksmethrespsentField = value;
    }

    public long csconnsuccrate
    {
      get => this.csconnsuccrateField;
      private set => this.csconnsuccrateField = value;
    }

    public long socksconnreqsent
    {
      get => this.socksconnreqsentField;
      private set => this.socksconnreqsentField = value;
    }

    public long dnsreqhit
    {
      get => this.dnsreqhitField;
      private set => this.dnsreqhitField = value;
    }

    public long staconnsuccessrate
    {
      get => this.staconnsuccessrateField;
      private set => this.staconnsuccessrateField = value;
    }

    public long iipfailedmipusedrate
    {
      get => this.iipfailedmipusedrateField;
      private set => this.iipfailedmipusedrateField = value;
    }

    public long staconnsuccess
    {
      get => this.staconnsuccessField;
      private set => this.staconnsuccessField = value;
    }

    public long cfghtmlservedrate
    {
      get => this.cfghtmlservedrateField;
      private set => this.cfghtmlservedrateField = value;
    }

    public long staresponserecvdrate
    {
      get => this.staresponserecvdrateField;
      private set => this.staresponserecvdrateField = value;
    }

    public long cpsconnfailure
    {
      get => this.cpsconnfailureField;
      private set => this.cpsconnfailureField = value;
    }

    public long csrequesthitrate
    {
      get => this.csrequesthitrateField;
      private set => this.csrequesthitrateField = value;
    }

    public long csnonhttpprobehit
    {
      get => this.csnonhttpprobehitField;
      private set => this.csnonhttpprobehitField = value;
    }

    public long iipfailedmipdisabledrate
    {
      get => this.iipfailedmipdisabledrateField;
      private set => this.iipfailedmipdisabledrateField = value;
    }

    public long cpsconnsuccessrate
    {
      get => this.cpsconnsuccessrateField;
      private set => this.cpsconnsuccessrateField = value;
    }

    public long socksconnresprcvdrate
    {
      get => this.socksconnresprcvdrateField;
      private set => this.socksconnresprcvdrateField = value;
    }

    public long indexhtmlnoserved
    {
      get => this.indexhtmlnoservedField;
      private set => this.indexhtmlnoservedField = value;
    }

    public long fsrequestrate
    {
      get => this.fsrequestrateField;
      private set => this.fsrequestrateField = value;
    }

    public long indexhtmlhit
    {
      get => this.indexhtmlhitField;
      private set => this.indexhtmlhitField = value;
    }

    public long cfghtmlserved
    {
      get => this.cfghtmlservedField;
      private set => this.cfghtmlservedField = value;
    }

    public long icalicensefailure
    {
      get => this.icalicensefailureField;
      private set => this.icalicensefailureField = value;
    }

    public long staresponserecvd
    {
      get => this.staresponserecvdField;
      private set => this.staresponserecvdField = value;
    }

    public long socksclienterror
    {
      get => this.socksclienterrorField;
      private set => this.socksclienterrorField = value;
    }

    public long iipdisabledmipdisabledrate
    {
      get => this.iipdisabledmipdisabledrateField;
      private set => this.iipdisabledmipdisabledrateField = value;
    }

    public long socksconnrespsent
    {
      get => this.socksconnrespsentField;
      private set => this.socksconnrespsentField = value;
    }

    public long socksmethresprcvd
    {
      get => this.socksmethresprcvdField;
      private set => this.socksmethresprcvdField = value;
    }

    public long iipdisabledmipused
    {
      get => this.iipdisabledmipusedField;
      private set => this.iipdisabledmipusedField = value;
    }

    public long iipfailedmipused
    {
      get => this.iipfailedmipusedField;
      private set => this.iipfailedmipusedField = value;
    }

    public long socksconnreqsentrate
    {
      get => this.socksconnreqsentrateField;
      private set => this.socksconnreqsentrateField = value;
    }

    public long starequestsentrate
    {
      get => this.starequestsentrateField;
      private set => this.starequestsentrateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vpn_stats[] vpnStatsArray = new vpn_stats[1];
      vpn_stats.vpn_response vpnResponse = new vpn_stats.vpn_response();
      vpn_stats.vpn_response resource = (vpn_stats.vpn_response) service.get_payload_formatter().string_to_resource(vpnResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      vpnStatsArray[0] = resource.vpn;
      return (base_resource[]) vpnStatsArray;
    }

    internal override string get_object_name() => (string) null;

    public static vpn_stats get(nitro_service service) => ((vpn_stats[]) new vpn_stats().stat_resources(service, (options) null))[0];

    public static vpn_stats get(nitro_service service, options option) => ((vpn_stats[]) new vpn_stats().stat_resources(service, option))[0];

    private class vpn_response : base_response
    {
      public vpn_stats vpn = (vpn_stats) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
