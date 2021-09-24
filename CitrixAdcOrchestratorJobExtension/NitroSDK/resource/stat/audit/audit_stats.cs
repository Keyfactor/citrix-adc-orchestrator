// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.audit.audit_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.audit
{
  public class audit_stats : base_resource
  {
    private string clearstatsField = (string) null;
    private long auditsyslogmsgsentField = 0;
    private long auditsyslogmsgsentrateField = 0;
    private long auditsyslogmsggenField = 0;
    private long auditsyslogmsggenrateField = 0;
    private long auditsyslogmsgsenttcpField = 0;
    private long auditsyslogmsgsenttcprateField = 0;
    private long auditnsballocfailField = 0;
    private long auditnsballocfailrateField = 0;
    private long auditlog32errsyslogallocnsbfailField = 0;
    private long auditlog32errsyslogallocnsbfailrateField = 0;
    private long auditmemallocfailField = 0;
    private long auditmemallocfailrateField = 0;
    private long auditportallocfailField = 0;
    private long auditportallocfailrateField = 0;
    private long auditnatpcblkupfailField = 0;
    private long auditnatpcblkupfailrateField = 0;
    private long auditcontextnotfoundField = 0;
    private long auditcontextnotfoundrateField = 0;
    private long nsbchainallocfailField = 0;
    private long nsbchainallocfailrateField = 0;
    private long clientconnfailField = 0;
    private long clientconnfailrateField = 0;
    private long flushcmdcntField = 0;
    private long flushcmdcntrateField = 0;
    private long systcpconnfailField = 0;
    private long systcpconnfailrateField = 0;
    private long logunsentlbsysField = 0;
    private long logunsentlbsysrateField = 0;
    private long logsdroppedField = 0;
    private long logsdroppedrateField = 0;
    private long logsdroppedtxminnsbsField = 0;
    private long logsdroppedtxminnsbsrateField = 0;

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long auditportallocfailrate
    {
      get => this.auditportallocfailrateField;
      private set => this.auditportallocfailrateField = value;
    }

    public long auditnsballocfailrate
    {
      get => this.auditnsballocfailrateField;
      private set => this.auditnsballocfailrateField = value;
    }

    public long auditsyslogmsgsenttcprate
    {
      get => this.auditsyslogmsgsenttcprateField;
      private set => this.auditsyslogmsgsenttcprateField = value;
    }

    public long auditcontextnotfoundrate
    {
      get => this.auditcontextnotfoundrateField;
      private set => this.auditcontextnotfoundrateField = value;
    }

    public long logsdroppedtxminnsbs
    {
      get => this.logsdroppedtxminnsbsField;
      private set => this.logsdroppedtxminnsbsField = value;
    }

    public long clientconnfail
    {
      get => this.clientconnfailField;
      private set => this.clientconnfailField = value;
    }

    public long flushcmdcntrate
    {
      get => this.flushcmdcntrateField;
      private set => this.flushcmdcntrateField = value;
    }

    public long auditlog32errsyslogallocnsbfailrate
    {
      get => this.auditlog32errsyslogallocnsbfailrateField;
      private set => this.auditlog32errsyslogallocnsbfailrateField = value;
    }

    public long auditnsballocfail
    {
      get => this.auditnsballocfailField;
      private set => this.auditnsballocfailField = value;
    }

    public long auditsyslogmsgsentrate
    {
      get => this.auditsyslogmsgsentrateField;
      private set => this.auditsyslogmsgsentrateField = value;
    }

    public long clientconnfailrate
    {
      get => this.clientconnfailrateField;
      private set => this.clientconnfailrateField = value;
    }

    public long auditnatpcblkupfailrate
    {
      get => this.auditnatpcblkupfailrateField;
      private set => this.auditnatpcblkupfailrateField = value;
    }

    public long auditmemallocfailrate
    {
      get => this.auditmemallocfailrateField;
      private set => this.auditmemallocfailrateField = value;
    }

    public long auditlog32errsyslogallocnsbfail
    {
      get => this.auditlog32errsyslogallocnsbfailField;
      private set => this.auditlog32errsyslogallocnsbfailField = value;
    }

    public long logsdroppedrate
    {
      get => this.logsdroppedrateField;
      private set => this.logsdroppedrateField = value;
    }

    public long auditportallocfail
    {
      get => this.auditportallocfailField;
      private set => this.auditportallocfailField = value;
    }

    public long nsbchainallocfail
    {
      get => this.nsbchainallocfailField;
      private set => this.nsbchainallocfailField = value;
    }

    public long logunsentlbsys
    {
      get => this.logunsentlbsysField;
      private set => this.logunsentlbsysField = value;
    }

    public long auditnatpcblkupfail
    {
      get => this.auditnatpcblkupfailField;
      private set => this.auditnatpcblkupfailField = value;
    }

    public long systcpconnfailrate
    {
      get => this.systcpconnfailrateField;
      private set => this.systcpconnfailrateField = value;
    }

    public long systcpconnfail
    {
      get => this.systcpconnfailField;
      private set => this.systcpconnfailField = value;
    }

    public long auditmemallocfail
    {
      get => this.auditmemallocfailField;
      private set => this.auditmemallocfailField = value;
    }

    public long logunsentlbsysrate
    {
      get => this.logunsentlbsysrateField;
      private set => this.logunsentlbsysrateField = value;
    }

    public long auditsyslogmsggenrate
    {
      get => this.auditsyslogmsggenrateField;
      private set => this.auditsyslogmsggenrateField = value;
    }

    public long logsdropped
    {
      get => this.logsdroppedField;
      private set => this.logsdroppedField = value;
    }

    public long auditsyslogmsgsent
    {
      get => this.auditsyslogmsgsentField;
      private set => this.auditsyslogmsgsentField = value;
    }

    public long auditcontextnotfound
    {
      get => this.auditcontextnotfoundField;
      private set => this.auditcontextnotfoundField = value;
    }

    public long flushcmdcnt
    {
      get => this.flushcmdcntField;
      private set => this.flushcmdcntField = value;
    }

    public long logsdroppedtxminnsbsrate
    {
      get => this.logsdroppedtxminnsbsrateField;
      private set => this.logsdroppedtxminnsbsrateField = value;
    }

    public long auditsyslogmsggen
    {
      get => this.auditsyslogmsggenField;
      private set => this.auditsyslogmsggenField = value;
    }

    public long nsbchainallocfailrate
    {
      get => this.nsbchainallocfailrateField;
      private set => this.nsbchainallocfailrateField = value;
    }

    public long auditsyslogmsgsenttcp
    {
      get => this.auditsyslogmsgsenttcpField;
      private set => this.auditsyslogmsgsenttcpField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      audit_stats[] auditStatsArray = new audit_stats[1];
      audit_stats.audit_response auditResponse = new audit_stats.audit_response();
      audit_stats.audit_response resource = (audit_stats.audit_response) service.get_payload_formatter().string_to_resource(auditResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      auditStatsArray[0] = resource.audit;
      return (base_resource[]) auditStatsArray;
    }

    internal override string get_object_name() => (string) null;

    public static audit_stats get(nitro_service service) => ((audit_stats[]) new audit_stats().stat_resources(service, (options) null))[0];

    public static audit_stats get(nitro_service service, options option) => ((audit_stats[]) new audit_stats().stat_resources(service, option))[0];

    private class audit_response : base_response
    {
      public audit_stats audit = (audit_stats) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
