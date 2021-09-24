// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.ns.ns_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.ns
{
  public class ns_stats : base_resource
  {
    private string clearstatsField = (string) null;
    private double rescpuusagepcntField = 0.0;
    private double cpuusagepcntField = 0.0;
    private long cachemaxmemorykbField = 0;
    private double delcmpratioField = 0.0;
    private long rescpuusageField = 0;
    private long cpuusageField = 0;
    private long resmemusageField = 0;
    private double comptotaldatacompressionratioField = 0.0;
    private double compratioField = 0.0;
    private long cacheutilizedmemorykbField = 0;
    private long cachemaxmemoryactivekbField = 0;
    private long cache64maxmemorykbField = 0;
    private long cachepercentoriginbandwidthsavedField = 0;
    private long cachetotmissesField = 0;
    private long cachemissesrateField = 0;
    private long cachetothitsField = 0;
    private long cachehitsrateField = 0;
    private long sslnumcardsupField = 0;
    private double memusagepcntField = 0.0;
    private long memuseinmbField = 0;
    private double mgmtcpuusagepcntField = 0.0;
    private double pktcpuusagepcntField = 0.0;
    private string starttimeField = (string) null;
    private string transtimeField = (string) null;
    private string hacurstateField = (string) null;
    private string hacurmasterstateField = (string) null;
    private long sslcardsField = 0;
    private long disk0perusageField = 0;
    private long disk1perusageField = 0;
    private long disk0availField = 0;
    private long disk1availField = 0;
    private long totrxmbitsField = 0;
    private long rxmbitsrateField = 0;
    private long tottxmbitsField = 0;
    private long txmbitsrateField = 0;
    private long tcpcurclientconnField = 0;
    private long tcpcurclientconnestablishedField = 0;
    private long tcpcurserverconnField = 0;
    private long tcpcurserverconnestablishedField = 0;
    private long httptotrequestsField = 0;
    private long httprequestsrateField = 0;
    private long httptotresponsesField = 0;
    private long httpresponsesrateField = 0;
    private long httptotrxrequestbytesField = 0;
    private long httprxrequestbytesrateField = 0;
    private long httptotrxresponsebytesField = 0;
    private long httprxresponsebytesrateField = 0;
    private long ssltottransactionsField = 0;
    private long ssltransactionsrateField = 0;
    private long ssltotsessionhitsField = 0;
    private long sslsessionhitsrateField = 0;
    private long appfirewallrequestsField = 0;
    private long appfirewallrequestsrateField = 0;
    private long appfirewallresponsesField = 0;
    private long appfirewallresponsesrateField = 0;
    private long appfirewallabortsField = 0;
    private long appfirewallabortsrateField = 0;
    private long appfirewallredirectsField = 0;
    private long appfirewallredirectsrateField = 0;
    private long misccounter0Field = 0;
    private long misccounter1Field = 0;
    private long numcpusField = 0;

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long appfirewallredirectsrate
    {
      get => this.appfirewallredirectsrateField;
      private set => this.appfirewallredirectsrateField = value;
    }

    public long ssltottransactions
    {
      get => this.ssltottransactionsField;
      private set => this.ssltottransactionsField = value;
    }

    public long sslnumcardsup
    {
      get => this.sslnumcardsupField;
      private set => this.sslnumcardsupField = value;
    }

    public string hacurmasterstate
    {
      get => this.hacurmasterstateField;
      private set => this.hacurmasterstateField = value;
    }

    public long httprxrequestbytesrate
    {
      get => this.httprxrequestbytesrateField;
      private set => this.httprxrequestbytesrateField = value;
    }

    public long httptotrxresponsebytes
    {
      get => this.httptotrxresponsebytesField;
      private set => this.httptotrxresponsebytesField = value;
    }

    public long disk1perusage
    {
      get => this.disk1perusageField;
      private set => this.disk1perusageField = value;
    }

    public double rescpuusagepcnt
    {
      get => this.rescpuusagepcntField;
      private set => this.rescpuusagepcntField = value;
    }

    public long appfirewallresponsesrate
    {
      get => this.appfirewallresponsesrateField;
      private set => this.appfirewallresponsesrateField = value;
    }

    public double delcmpratio
    {
      get => this.delcmpratioField;
      private set => this.delcmpratioField = value;
    }

    public long appfirewallresponses
    {
      get => this.appfirewallresponsesField;
      private set => this.appfirewallresponsesField = value;
    }

    public double comptotaldatacompressionratio
    {
      get => this.comptotaldatacompressionratioField;
      private set => this.comptotaldatacompressionratioField = value;
    }

    public long httprxresponsebytesrate
    {
      get => this.httprxresponsebytesrateField;
      private set => this.httprxresponsebytesrateField = value;
    }

    public long disk0perusage
    {
      get => this.disk0perusageField;
      private set => this.disk0perusageField = value;
    }

    public long appfirewallabortsrate
    {
      get => this.appfirewallabortsrateField;
      private set => this.appfirewallabortsrateField = value;
    }

    public long appfirewallrequestsrate
    {
      get => this.appfirewallrequestsrateField;
      private set => this.appfirewallrequestsrateField = value;
    }

    public long ssltotsessionhits
    {
      get => this.ssltotsessionhitsField;
      private set => this.ssltotsessionhitsField = value;
    }

    public long appfirewallredirects
    {
      get => this.appfirewallredirectsField;
      private set => this.appfirewallredirectsField = value;
    }

    public double mgmtcpuusagepcnt
    {
      get => this.mgmtcpuusagepcntField;
      private set => this.mgmtcpuusagepcntField = value;
    }

    public long cpuusage
    {
      get => this.cpuusageField;
      private set => this.cpuusageField = value;
    }

    public long httptotresponses
    {
      get => this.httptotresponsesField;
      private set => this.httptotresponsesField = value;
    }

    public double compratio
    {
      get => this.compratioField;
      private set => this.compratioField = value;
    }

    public long memuseinmb
    {
      get => this.memuseinmbField;
      private set => this.memuseinmbField = value;
    }

    public long sslsessionhitsrate
    {
      get => this.sslsessionhitsrateField;
      private set => this.sslsessionhitsrateField = value;
    }

    public long resmemusage
    {
      get => this.resmemusageField;
      private set => this.resmemusageField = value;
    }

    public long cache64maxmemorykb
    {
      get => this.cache64maxmemorykbField;
      private set => this.cache64maxmemorykbField = value;
    }

    public string starttime
    {
      get => this.starttimeField;
      private set => this.starttimeField = value;
    }

    public long cachepercentoriginbandwidthsaved
    {
      get => this.cachepercentoriginbandwidthsavedField;
      private set => this.cachepercentoriginbandwidthsavedField = value;
    }

    public long misccounter0
    {
      get => this.misccounter0Field;
      private set => this.misccounter0Field = value;
    }

    public double memusagepcnt
    {
      get => this.memusagepcntField;
      private set => this.memusagepcntField = value;
    }

    public long cachehitsrate
    {
      get => this.cachehitsrateField;
      private set => this.cachehitsrateField = value;
    }

    public string transtime
    {
      get => this.transtimeField;
      private set => this.transtimeField = value;
    }

    public long cacheutilizedmemorykb
    {
      get => this.cacheutilizedmemorykbField;
      private set => this.cacheutilizedmemorykbField = value;
    }

    public long appfirewallaborts
    {
      get => this.appfirewallabortsField;
      private set => this.appfirewallabortsField = value;
    }

    public long disk1avail
    {
      get => this.disk1availField;
      private set => this.disk1availField = value;
    }

    public long tcpcurserverconnestablished
    {
      get => this.tcpcurserverconnestablishedField;
      private set => this.tcpcurserverconnestablishedField = value;
    }

    public long tcpcurclientconn
    {
      get => this.tcpcurclientconnField;
      private set => this.tcpcurclientconnField = value;
    }

    public long tcpcurserverconn
    {
      get => this.tcpcurserverconnField;
      private set => this.tcpcurserverconnField = value;
    }

    public long rescpuusage
    {
      get => this.rescpuusageField;
      private set => this.rescpuusageField = value;
    }

    public long appfirewallrequests
    {
      get => this.appfirewallrequestsField;
      private set => this.appfirewallrequestsField = value;
    }

    public long totrxmbits
    {
      get => this.totrxmbitsField;
      private set => this.totrxmbitsField = value;
    }

    public long tottxmbits
    {
      get => this.tottxmbitsField;
      private set => this.tottxmbitsField = value;
    }

    public long cachemissesrate
    {
      get => this.cachemissesrateField;
      private set => this.cachemissesrateField = value;
    }

    public long cachemaxmemorykb
    {
      get => this.cachemaxmemorykbField;
      private set => this.cachemaxmemorykbField = value;
    }

    public long httptotrequests
    {
      get => this.httptotrequestsField;
      private set => this.httptotrequestsField = value;
    }

    public long cachetothits
    {
      get => this.cachetothitsField;
      private set => this.cachetothitsField = value;
    }

    public long misccounter1
    {
      get => this.misccounter1Field;
      private set => this.misccounter1Field = value;
    }

    public long numcpus
    {
      get => this.numcpusField;
      private set => this.numcpusField = value;
    }

    public double pktcpuusagepcnt
    {
      get => this.pktcpuusagepcntField;
      private set => this.pktcpuusagepcntField = value;
    }

    public long ssltransactionsrate
    {
      get => this.ssltransactionsrateField;
      private set => this.ssltransactionsrateField = value;
    }

    public long httprequestsrate
    {
      get => this.httprequestsrateField;
      private set => this.httprequestsrateField = value;
    }

    public long cachemaxmemoryactivekb
    {
      get => this.cachemaxmemoryactivekbField;
      private set => this.cachemaxmemoryactivekbField = value;
    }

    public long httpresponsesrate
    {
      get => this.httpresponsesrateField;
      private set => this.httpresponsesrateField = value;
    }

    public long disk0avail
    {
      get => this.disk0availField;
      private set => this.disk0availField = value;
    }

    public long txmbitsrate
    {
      get => this.txmbitsrateField;
      private set => this.txmbitsrateField = value;
    }

    public long sslcards
    {
      get => this.sslcardsField;
      private set => this.sslcardsField = value;
    }

    public string hacurstate
    {
      get => this.hacurstateField;
      private set => this.hacurstateField = value;
    }

    public long rxmbitsrate
    {
      get => this.rxmbitsrateField;
      private set => this.rxmbitsrateField = value;
    }

    public long tcpcurclientconnestablished
    {
      get => this.tcpcurclientconnestablishedField;
      private set => this.tcpcurclientconnestablishedField = value;
    }

    public double cpuusagepcnt
    {
      get => this.cpuusagepcntField;
      private set => this.cpuusagepcntField = value;
    }

    public long cachetotmisses
    {
      get => this.cachetotmissesField;
      private set => this.cachetotmissesField = value;
    }

    public long httptotrxrequestbytes
    {
      get => this.httptotrxrequestbytesField;
      private set => this.httptotrxrequestbytesField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      ns_stats[] nsStatsArray = new ns_stats[1];
      ns_stats.ns_response nsResponse = new ns_stats.ns_response();
      ns_stats.ns_response resource = (ns_stats.ns_response) service.get_payload_formatter().string_to_resource(nsResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      nsStatsArray[0] = resource.ns;
      return (base_resource[]) nsStatsArray;
    }

    internal override string get_object_name() => (string) null;

    public static ns_stats get(nitro_service service) => ((ns_stats[]) new ns_stats().stat_resources(service, (options) null))[0];

    public static ns_stats get(nitro_service service, options option) => ((ns_stats[]) new ns_stats().stat_resources(service, option))[0];

    private class ns_response : base_response
    {
      public ns_stats ns = (ns_stats) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
