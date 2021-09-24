// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.sc.sc_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.sc
{
  public class sc_stats : base_resource
  {
    private string clearstatsField = (string) null;
    private long sctotcondtriggeredField = 0;
    private long sccondtriggeredrateField = 0;
    private long scpolicyurlhitsField = 0;
    private long scpolicyurlhitsrateField = 0;
    private long scpopupsField = 0;
    private long scpopupsrateField = 0;
    private long sctotreissuedrequestsField = 0;
    private long screissuedrequestsrateField = 0;
    private long scsessionreqsField = 0;
    private long scsessionreqsrateField = 0;
    private long scaltconturlsField = 0;
    private long scaltconturlsrateField = 0;
    private long scpostreqsField = 0;
    private long scpostreqsrateField = 0;
    private long scresetstatsField = 0;
    private long scresetstatsrateField = 0;
    private long scunsupbrowField = 0;
    private long scunsupbrowrateField = 0;
    private long scfaultycookiesField = 0;
    private long scfaultycookiesrateField = 0;

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long scpopups
    {
      get => this.scpopupsField;
      private set => this.scpopupsField = value;
    }

    public long scfaultycookiesrate
    {
      get => this.scfaultycookiesrateField;
      private set => this.scfaultycookiesrateField = value;
    }

    public long screissuedrequestsrate
    {
      get => this.screissuedrequestsrateField;
      private set => this.screissuedrequestsrateField = value;
    }

    public long scpostreqs
    {
      get => this.scpostreqsField;
      private set => this.scpostreqsField = value;
    }

    public long scaltconturls
    {
      get => this.scaltconturlsField;
      private set => this.scaltconturlsField = value;
    }

    public long scresetstatsrate
    {
      get => this.scresetstatsrateField;
      private set => this.scresetstatsrateField = value;
    }

    public long scpopupsrate
    {
      get => this.scpopupsrateField;
      private set => this.scpopupsrateField = value;
    }

    public long sctotreissuedrequests
    {
      get => this.sctotreissuedrequestsField;
      private set => this.sctotreissuedrequestsField = value;
    }

    public long scunsupbrow
    {
      get => this.scunsupbrowField;
      private set => this.scunsupbrowField = value;
    }

    public long scpolicyurlhitsrate
    {
      get => this.scpolicyurlhitsrateField;
      private set => this.scpolicyurlhitsrateField = value;
    }

    public long sccondtriggeredrate
    {
      get => this.sccondtriggeredrateField;
      private set => this.sccondtriggeredrateField = value;
    }

    public long scpolicyurlhits
    {
      get => this.scpolicyurlhitsField;
      private set => this.scpolicyurlhitsField = value;
    }

    public long scsessionreqsrate
    {
      get => this.scsessionreqsrateField;
      private set => this.scsessionreqsrateField = value;
    }

    public long scresetstats
    {
      get => this.scresetstatsField;
      private set => this.scresetstatsField = value;
    }

    public long sctotcondtriggered
    {
      get => this.sctotcondtriggeredField;
      private set => this.sctotcondtriggeredField = value;
    }

    public long scfaultycookies
    {
      get => this.scfaultycookiesField;
      private set => this.scfaultycookiesField = value;
    }

    public long scsessionreqs
    {
      get => this.scsessionreqsField;
      private set => this.scsessionreqsField = value;
    }

    public long scaltconturlsrate
    {
      get => this.scaltconturlsrateField;
      private set => this.scaltconturlsrateField = value;
    }

    public long scunsupbrowrate
    {
      get => this.scunsupbrowrateField;
      private set => this.scunsupbrowrateField = value;
    }

    public long scpostreqsrate
    {
      get => this.scpostreqsrateField;
      private set => this.scpostreqsrateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sc_stats[] scStatsArray = new sc_stats[1];
      sc_stats.sc_response scResponse = new sc_stats.sc_response();
      sc_stats.sc_response resource = (sc_stats.sc_response) service.get_payload_formatter().string_to_resource(scResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      scStatsArray[0] = resource.sc;
      return (base_resource[]) scStatsArray;
    }

    internal override string get_object_name() => (string) null;

    public static sc_stats get(nitro_service service) => ((sc_stats[]) new sc_stats().stat_resources(service, (options) null))[0];

    public static sc_stats get(nitro_service service, options option) => ((sc_stats[]) new sc_stats().stat_resources(service, option))[0];

    private class sc_response : base_response
    {
      public sc_stats sc = (sc_stats) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
