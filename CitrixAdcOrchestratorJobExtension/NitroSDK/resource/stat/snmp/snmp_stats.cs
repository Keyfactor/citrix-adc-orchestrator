// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.snmp.snmp_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.snmp
{
  public class snmp_stats : base_resource
  {
    private string clearstatsField = (string) null;
    private long snmptotrxpktsField = 0;
    private long snmprxpktsrateField = 0;
    private long snmptottxpktsField = 0;
    private long snmptxpktsrateField = 0;
    private long snmptotgetreqsField = 0;
    private long snmpgetreqsrateField = 0;
    private long snmptotgetnextreqsField = 0;
    private long snmpgetnextreqsrateField = 0;
    private long snmptotgetbulkreqsField = 0;
    private long snmpgetbulkreqsrateField = 0;
    private long snmptotresponsesField = 0;
    private long snmpresponsesrateField = 0;
    private long snmptottrapsField = 0;
    private long snmptoterrreqdroppedField = 0;
    private long snmptotparseerrsField = 0;
    private long snmptotbadversionsField = 0;
    private long snmptotbadcommnameField = 0;
    private long snmptotbadcommuseField = 0;
    private long snmpunsupportedsecuritylevelField = 0;
    private long snmpnotintimewindowField = 0;
    private long snmpunknownusernameField = 0;
    private long snmpunknownengineidsField = 0;
    private long snmpwrongdigestsField = 0;
    private long snmpdecryptionerrorsField = 0;

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long snmpdecryptionerrors
    {
      get => this.snmpdecryptionerrorsField;
      private set => this.snmpdecryptionerrorsField = value;
    }

    public long snmptotresponses
    {
      get => this.snmptotresponsesField;
      private set => this.snmptotresponsesField = value;
    }

    public long snmptotbadcommuse
    {
      get => this.snmptotbadcommuseField;
      private set => this.snmptotbadcommuseField = value;
    }

    public long snmptoterrreqdropped
    {
      get => this.snmptoterrreqdroppedField;
      private set => this.snmptoterrreqdroppedField = value;
    }

    public long snmpgetnextreqsrate
    {
      get => this.snmpgetnextreqsrateField;
      private set => this.snmpgetnextreqsrateField = value;
    }

    public long snmptotrxpkts
    {
      get => this.snmptotrxpktsField;
      private set => this.snmptotrxpktsField = value;
    }

    public long snmptottxpkts
    {
      get => this.snmptottxpktsField;
      private set => this.snmptottxpktsField = value;
    }

    public long snmptotparseerrs
    {
      get => this.snmptotparseerrsField;
      private set => this.snmptotparseerrsField = value;
    }

    public long snmptottraps
    {
      get => this.snmptottrapsField;
      private set => this.snmptottrapsField = value;
    }

    public long snmptotbadversions
    {
      get => this.snmptotbadversionsField;
      private set => this.snmptotbadversionsField = value;
    }

    public long snmptxpktsrate
    {
      get => this.snmptxpktsrateField;
      private set => this.snmptxpktsrateField = value;
    }

    public long snmpresponsesrate
    {
      get => this.snmpresponsesrateField;
      private set => this.snmpresponsesrateField = value;
    }

    public long snmpgetreqsrate
    {
      get => this.snmpgetreqsrateField;
      private set => this.snmpgetreqsrateField = value;
    }

    public long snmptotbadcommname
    {
      get => this.snmptotbadcommnameField;
      private set => this.snmptotbadcommnameField = value;
    }

    public long snmptotgetnextreqs
    {
      get => this.snmptotgetnextreqsField;
      private set => this.snmptotgetnextreqsField = value;
    }

    public long snmpunknownengineids
    {
      get => this.snmpunknownengineidsField;
      private set => this.snmpunknownengineidsField = value;
    }

    public long snmpwrongdigests
    {
      get => this.snmpwrongdigestsField;
      private set => this.snmpwrongdigestsField = value;
    }

    public long snmpgetbulkreqsrate
    {
      get => this.snmpgetbulkreqsrateField;
      private set => this.snmpgetbulkreqsrateField = value;
    }

    public long snmpnotintimewindow
    {
      get => this.snmpnotintimewindowField;
      private set => this.snmpnotintimewindowField = value;
    }

    public long snmptotgetbulkreqs
    {
      get => this.snmptotgetbulkreqsField;
      private set => this.snmptotgetbulkreqsField = value;
    }

    public long snmpunknownusername
    {
      get => this.snmpunknownusernameField;
      private set => this.snmpunknownusernameField = value;
    }

    public long snmpunsupportedsecuritylevel
    {
      get => this.snmpunsupportedsecuritylevelField;
      private set => this.snmpunsupportedsecuritylevelField = value;
    }

    public long snmptotgetreqs
    {
      get => this.snmptotgetreqsField;
      private set => this.snmptotgetreqsField = value;
    }

    public long snmprxpktsrate
    {
      get => this.snmprxpktsrateField;
      private set => this.snmprxpktsrateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      snmp_stats[] snmpStatsArray = new snmp_stats[1];
      snmp_stats.snmp_response snmpResponse = new snmp_stats.snmp_response();
      snmp_stats.snmp_response resource = (snmp_stats.snmp_response) service.get_payload_formatter().string_to_resource(snmpResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      snmpStatsArray[0] = resource.snmp;
      return (base_resource[]) snmpStatsArray;
    }

    internal override string get_object_name() => (string) null;

    public static snmp_stats get(nitro_service service) => ((snmp_stats[]) new snmp_stats().stat_resources(service, (options) null))[0];

    public static snmp_stats get(nitro_service service, options option) => ((snmp_stats[]) new snmp_stats().stat_resources(service, option))[0];

    private class snmp_response : base_response
    {
      public snmp_stats snmp = (snmp_stats) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
