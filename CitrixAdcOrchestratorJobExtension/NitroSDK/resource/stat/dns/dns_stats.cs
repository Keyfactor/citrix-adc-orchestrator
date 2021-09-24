// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.dns.dns_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.dns
{
  public class dns_stats : base_resource
  {
    private string clearstatsField = (string) null;
    private long dnstotqueriesField = 0;
    private long dnsqueriesrateField = 0;
    private long dnstotmultiqueryField = 0;
    private long dnstotanswersField = 0;
    private long dnsanswersrateField = 0;
    private long dnstotserverresponseField = 0;
    private long dnsserverresponserateField = 0;
    private long dnstotrecupdateField = 0;
    private long dnstotauthansField = 0;
    private long dnstotserverqueryField = 0;
    private long dnsserverqueryrateField = 0;
    private long dnstotcacheflushField = 0;
    private long dnstotcacheentriesflushField = 0;
    private long dnscurnoauthentriesField = 0;
    private long dnscurauthentriesField = 0;
    private long dnstotauthnonamesField = 0;
    private long dnstotunsupportedresponseclassField = 0;
    private long dnstotinvalidqueryformatField = 0;
    private long dnstotstrayanswerField = 0;
    private long dnstotresponsebadlenField = 0;
    private long dnstotreqrefusalsField = 0;
    private long dnserrnullattackField = 0;
    private long dnstotunsupportedresponsetypeField = 0;
    private long dnstotunsupportedqueryclassField = 0;
    private long dnstotnonauthnodatasField = 0;
    private long dnstotnodatarespsField = 0;
    private long dnstotmultiquerydisableerrorField = 0;
    private long dnstotothererrorsField = 0;
    private long dns64totqueriesField = 0;
    private long dns64queriesrateField = 0;
    private long dns64totanswersField = 0;
    private long dns64answersrateField = 0;
    private long dns64totrwanswersField = 0;
    private long dns64rwanswersrateField = 0;
    private long dns64totresponsesField = 0;
    private long dns64responsesrateField = 0;
    private long dns64totgslbqueriesField = 0;
    private long dns64gslbqueriesrateField = 0;
    private long dns64totgslbanswersField = 0;
    private long dns64gslbanswersrateField = 0;
    private long dns64tottcanswersField = 0;
    private long dns64tcanswersrateField = 0;
    private long dns64totsvraqueriesField = 0;
    private long dns64svraqueriesrateField = 0;
    private long dns64totaaaabypassField = 0;
    private long dns64aaaabypassrateField = 0;
    private long dns64tottcpqueriesField = 0;
    private long dns64tcpqueriesrateField = 0;
    private long dns64activepoliciesField = 0;
    private long dns64totnodatarespField = 0;
    private long dns64nodataresprateField = 0;
    private long dnstotnsrecqueriesField = 0;
    private long dnsnsrecqueriesrateField = 0;
    private long dnstotsoarecqueriesField = 0;
    private long dnssoarecqueriesrateField = 0;
    private long dnstotptrrecqueriesField = 0;
    private long dnsptrrecqueriesrateField = 0;
    private long dnstotsrvrecqueriesField = 0;
    private long dnssrvrecqueriesrateField = 0;
    private long dnstotaresponseField = 0;
    private long dnsaresponserateField = 0;
    private long dnstotcnameresponseField = 0;
    private long dnscnameresponserateField = 0;
    private long dnstotmxresponseField = 0;
    private long dnsmxresponserateField = 0;
    private long dnstotanyresponseField = 0;
    private long dnsanyresponserateField = 0;
    private long dnstotnsrecupdateField = 0;
    private long dnstotsoarecupdateField = 0;
    private long dnstotptrrecupdateField = 0;
    private long dnstotsrvrecupdateField = 0;
    private long dnstotaaaarecqueriesField = 0;
    private long dnsaaaarecqueriesrateField = 0;
    private long dnstotarecqueriesField = 0;
    private long dnsarecqueriesrateField = 0;
    private long dnstotcnamerecqueriesField = 0;
    private long dnscnamerecqueriesrateField = 0;
    private long dnstotmxrecqueriesField = 0;
    private long dnsmxrecqueriesrateField = 0;
    private long dnstotanyqueriesField = 0;
    private long dnsanyqueriesrateField = 0;
    private long dnstotaaaaresponseField = 0;
    private long dnsaaaaresponserateField = 0;
    private long dnstotnsresponseField = 0;
    private long dnsnsresponserateField = 0;
    private long dnstotsoaresponseField = 0;
    private long dnssoaresponserateField = 0;
    private long dnstotptrresponseField = 0;
    private long dnsptrresponserateField = 0;
    private long dnstotsrvresponseField = 0;
    private long dnssrvresponserateField = 0;
    private long dnstotaaaarecupdateField = 0;
    private long dnstotarecupdateField = 0;
    private long dnstotmxrecupdateField = 0;
    private long dnstotcnamerecupdateField = 0;
    private long dnscuraaaarecordField = 0;
    private long dnscurarecordField = 0;
    private long dnscurmxrecordField = 0;
    private long dnscurcnamerecordField = 0;
    private long dnscurnsrecordField = 0;
    private long dnscursoarecordField = 0;
    private long dnscurptrrecordField = 0;
    private long dnscursrvrecordField = 0;
    private long dnstotaaaarecfailedField = 0;
    private long dnstotarecfailedField = 0;
    private long dnstotmxrecfailedField = 0;
    private long dnstotptrrecfailedField = 0;
    private long dnstotnsrecfailedField = 0;
    private long dnstotcnamerecfailedField = 0;
    private long dnstotsoarecfailedField = 0;
    private long dnstotsrvrecfailedField = 0;
    private long dnstotanyrecfailedField = 0;
    private long dnstotunsupportedqueriesField = 0;

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long dnstotcnameresponse
    {
      get => this.dnstotcnameresponseField;
      private set => this.dnstotcnameresponseField = value;
    }

    public long dnsaresponserate
    {
      get => this.dnsaresponserateField;
      private set => this.dnsaresponserateField = value;
    }

    public long dns64rwanswersrate
    {
      get => this.dns64rwanswersrateField;
      private set => this.dns64rwanswersrateField = value;
    }

    public long dnstotaaaarecupdate
    {
      get => this.dnstotaaaarecupdateField;
      private set => this.dnstotaaaarecupdateField = value;
    }

    public long dnstotptrrecupdate
    {
      get => this.dnstotptrrecupdateField;
      private set => this.dnstotptrrecupdateField = value;
    }

    public long dns64nodataresprate
    {
      get => this.dns64nodataresprateField;
      private set => this.dns64nodataresprateField = value;
    }

    public long dnserrnullattack
    {
      get => this.dnserrnullattackField;
      private set => this.dnserrnullattackField = value;
    }

    public long dnstotunsupportedqueries
    {
      get => this.dnstotunsupportedqueriesField;
      private set => this.dnstotunsupportedqueriesField = value;
    }

    public long dnstotauthnonames
    {
      get => this.dnstotauthnonamesField;
      private set => this.dnstotauthnonamesField = value;
    }

    public long dnstotmxrecupdate
    {
      get => this.dnstotmxrecupdateField;
      private set => this.dnstotmxrecupdateField = value;
    }

    public long dnstotanyqueries
    {
      get => this.dnstotanyqueriesField;
      private set => this.dnstotanyqueriesField = value;
    }

    public long dns64totrwanswers
    {
      get => this.dns64totrwanswersField;
      private set => this.dns64totrwanswersField = value;
    }

    public long dnstotstrayanswer
    {
      get => this.dnstotstrayanswerField;
      private set => this.dnstotstrayanswerField = value;
    }

    public long dnstotptrrecfailed
    {
      get => this.dnstotptrrecfailedField;
      private set => this.dnstotptrrecfailedField = value;
    }

    public long dns64activepolicies
    {
      get => this.dns64activepoliciesField;
      private set => this.dns64activepoliciesField = value;
    }

    public long dnstotcnamerecupdate
    {
      get => this.dnstotcnamerecupdateField;
      private set => this.dnstotcnamerecupdateField = value;
    }

    public long dnscursoarecord
    {
      get => this.dnscursoarecordField;
      private set => this.dnscursoarecordField = value;
    }

    public long dnstotcacheentriesflush
    {
      get => this.dnstotcacheentriesflushField;
      private set => this.dnstotcacheentriesflushField = value;
    }

    public long dnsaaaaresponserate
    {
      get => this.dnsaaaaresponserateField;
      private set => this.dnsaaaaresponserateField = value;
    }

    public long dnsaaaarecqueriesrate
    {
      get => this.dnsaaaarecqueriesrateField;
      private set => this.dnsaaaarecqueriesrateField = value;
    }

    public long dnstotmxrecqueries
    {
      get => this.dnstotmxrecqueriesField;
      private set => this.dnstotmxrecqueriesField = value;
    }

    public long dnstotsoarecqueries
    {
      get => this.dnstotsoarecqueriesField;
      private set => this.dnstotsoarecqueriesField = value;
    }

    public long dnscurarecord
    {
      get => this.dnscurarecordField;
      private set => this.dnscurarecordField = value;
    }

    public long dnstotinvalidqueryformat
    {
      get => this.dnstotinvalidqueryformatField;
      private set => this.dnstotinvalidqueryformatField = value;
    }

    public long dnstotsrvrecfailed
    {
      get => this.dnstotsrvrecfailedField;
      private set => this.dnstotsrvrecfailedField = value;
    }

    public long dnsarecqueriesrate
    {
      get => this.dnsarecqueriesrateField;
      private set => this.dnsarecqueriesrateField = value;
    }

    public long dnstotsoaresponse
    {
      get => this.dnstotsoaresponseField;
      private set => this.dnstotsoaresponseField = value;
    }

    public long dnstotserverresponse
    {
      get => this.dnstotserverresponseField;
      private set => this.dnstotserverresponseField = value;
    }

    public long dnsanyqueriesrate
    {
      get => this.dnsanyqueriesrateField;
      private set => this.dnsanyqueriesrateField = value;
    }

    public long dnscurauthentries
    {
      get => this.dnscurauthentriesField;
      private set => this.dnscurauthentriesField = value;
    }

    public long dnstotmxresponse
    {
      get => this.dnstotmxresponseField;
      private set => this.dnstotmxresponseField = value;
    }

    public long dnstotptrrecqueries
    {
      get => this.dnstotptrrecqueriesField;
      private set => this.dnstotptrrecqueriesField = value;
    }

    public long dnstotunsupportedqueryclass
    {
      get => this.dnstotunsupportedqueryclassField;
      private set => this.dnstotunsupportedqueryclassField = value;
    }

    public long dnsptrresponserate
    {
      get => this.dnsptrresponserateField;
      private set => this.dnsptrresponserateField = value;
    }

    public long dnssoarecqueriesrate
    {
      get => this.dnssoarecqueriesrateField;
      private set => this.dnssoarecqueriesrateField = value;
    }

    public long dns64totgslbanswers
    {
      get => this.dns64totgslbanswersField;
      private set => this.dns64totgslbanswersField = value;
    }

    public long dns64answersrate
    {
      get => this.dns64answersrateField;
      private set => this.dns64answersrateField = value;
    }

    public long dns64totqueries
    {
      get => this.dns64totqueriesField;
      private set => this.dns64totqueriesField = value;
    }

    public long dnsptrrecqueriesrate
    {
      get => this.dnsptrrecqueriesrateField;
      private set => this.dnsptrrecqueriesrateField = value;
    }

    public long dnstotsoarecfailed
    {
      get => this.dnstotsoarecfailedField;
      private set => this.dnstotsoarecfailedField = value;
    }

    public long dns64tottcpqueries
    {
      get => this.dns64tottcpqueriesField;
      private set => this.dns64tottcpqueriesField = value;
    }

    public long dnstotaaaarecqueries
    {
      get => this.dnstotaaaarecqueriesField;
      private set => this.dnstotaaaarecqueriesField = value;
    }

    public long dns64responsesrate
    {
      get => this.dns64responsesrateField;
      private set => this.dns64responsesrateField = value;
    }

    public long dnstotmxrecfailed
    {
      get => this.dnstotmxrecfailedField;
      private set => this.dnstotmxrecfailedField = value;
    }

    public long dns64tottcanswers
    {
      get => this.dns64tottcanswersField;
      private set => this.dns64tottcanswersField = value;
    }

    public long dnstotaaaarecfailed
    {
      get => this.dnstotaaaarecfailedField;
      private set => this.dnstotaaaarecfailedField = value;
    }

    public long dnssrvresponserate
    {
      get => this.dnssrvresponserateField;
      private set => this.dnssrvresponserateField = value;
    }

    public long dnsnsrecqueriesrate
    {
      get => this.dnsnsrecqueriesrateField;
      private set => this.dnsnsrecqueriesrateField = value;
    }

    public long dnstotserverquery
    {
      get => this.dnstotserverqueryField;
      private set => this.dnstotserverqueryField = value;
    }

    public long dnssoaresponserate
    {
      get => this.dnssoaresponserateField;
      private set => this.dnssoaresponserateField = value;
    }

    public long dnstotmultiquery
    {
      get => this.dnstotmultiqueryField;
      private set => this.dnstotmultiqueryField = value;
    }

    public long dnscuraaaarecord
    {
      get => this.dnscuraaaarecordField;
      private set => this.dnscuraaaarecordField = value;
    }

    public long dnsqueriesrate
    {
      get => this.dnsqueriesrateField;
      private set => this.dnsqueriesrateField = value;
    }

    public long dns64gslbqueriesrate
    {
      get => this.dns64gslbqueriesrateField;
      private set => this.dns64gslbqueriesrateField = value;
    }

    public long dnsanyresponserate
    {
      get => this.dnsanyresponserateField;
      private set => this.dnsanyresponserateField = value;
    }

    public long dnsanswersrate
    {
      get => this.dnsanswersrateField;
      private set => this.dnsanswersrateField = value;
    }

    public long dnstotarecupdate
    {
      get => this.dnstotarecupdateField;
      private set => this.dnstotarecupdateField = value;
    }

    public long dnscnameresponserate
    {
      get => this.dnscnameresponserateField;
      private set => this.dnscnameresponserateField = value;
    }

    public long dnstotothererrors
    {
      get => this.dnstotothererrorsField;
      private set => this.dnstotothererrorsField = value;
    }

    public long dnstotnsrecfailed
    {
      get => this.dnstotnsrecfailedField;
      private set => this.dnstotnsrecfailedField = value;
    }

    public long dnscurcnamerecord
    {
      get => this.dnscurcnamerecordField;
      private set => this.dnscurcnamerecordField = value;
    }

    public long dnscurnoauthentries
    {
      get => this.dnscurnoauthentriesField;
      private set => this.dnscurnoauthentriesField = value;
    }

    public long dnstotresponsebadlen
    {
      get => this.dnstotresponsebadlenField;
      private set => this.dnstotresponsebadlenField = value;
    }

    public long dns64totaaaabypass
    {
      get => this.dns64totaaaabypassField;
      private set => this.dns64totaaaabypassField = value;
    }

    public long dns64tcpqueriesrate
    {
      get => this.dns64tcpqueriesrateField;
      private set => this.dns64tcpqueriesrateField = value;
    }

    public long dnstotaaaaresponse
    {
      get => this.dnstotaaaaresponseField;
      private set => this.dnstotaaaaresponseField = value;
    }

    public long dns64gslbanswersrate
    {
      get => this.dns64gslbanswersrateField;
      private set => this.dns64gslbanswersrateField = value;
    }

    public long dnstotunsupportedresponsetype
    {
      get => this.dnstotunsupportedresponsetypeField;
      private set => this.dnstotunsupportedresponsetypeField = value;
    }

    public long dns64totsvraqueries
    {
      get => this.dns64totsvraqueriesField;
      private set => this.dns64totsvraqueriesField = value;
    }

    public long dns64totresponses
    {
      get => this.dns64totresponsesField;
      private set => this.dns64totresponsesField = value;
    }

    public long dnstotnsrecqueries
    {
      get => this.dnstotnsrecqueriesField;
      private set => this.dnstotnsrecqueriesField = value;
    }

    public long dns64totanswers
    {
      get => this.dns64totanswersField;
      private set => this.dns64totanswersField = value;
    }

    public long dnscursrvrecord
    {
      get => this.dnscursrvrecordField;
      private set => this.dnscursrvrecordField = value;
    }

    public long dnscurptrrecord
    {
      get => this.dnscurptrrecordField;
      private set => this.dnscurptrrecordField = value;
    }

    public long dnstotanyresponse
    {
      get => this.dnstotanyresponseField;
      private set => this.dnstotanyresponseField = value;
    }

    public long dnstotanyrecfailed
    {
      get => this.dnstotanyrecfailedField;
      private set => this.dnstotanyrecfailedField = value;
    }

    public long dns64aaaabypassrate
    {
      get => this.dns64aaaabypassrateField;
      private set => this.dns64aaaabypassrateField = value;
    }

    public long dnstotnsresponse
    {
      get => this.dnstotnsresponseField;
      private set => this.dnstotnsresponseField = value;
    }

    public long dnssrvrecqueriesrate
    {
      get => this.dnssrvrecqueriesrateField;
      private set => this.dnssrvrecqueriesrateField = value;
    }

    public long dnstotnsrecupdate
    {
      get => this.dnstotnsrecupdateField;
      private set => this.dnstotnsrecupdateField = value;
    }

    public long dnstotcnamerecqueries
    {
      get => this.dnstotcnamerecqueriesField;
      private set => this.dnstotcnamerecqueriesField = value;
    }

    public long dnstotmultiquerydisableerror
    {
      get => this.dnstotmultiquerydisableerrorField;
      private set => this.dnstotmultiquerydisableerrorField = value;
    }

    public long dnstotarecqueries
    {
      get => this.dnstotarecqueriesField;
      private set => this.dnstotarecqueriesField = value;
    }

    public long dnsserverresponserate
    {
      get => this.dnsserverresponserateField;
      private set => this.dnsserverresponserateField = value;
    }

    public long dnsnsresponserate
    {
      get => this.dnsnsresponserateField;
      private set => this.dnsnsresponserateField = value;
    }

    public long dnstotanswers
    {
      get => this.dnstotanswersField;
      private set => this.dnstotanswersField = value;
    }

    public long dnsmxrecqueriesrate
    {
      get => this.dnsmxrecqueriesrateField;
      private set => this.dnsmxrecqueriesrateField = value;
    }

    public long dnstotcnamerecfailed
    {
      get => this.dnstotcnamerecfailedField;
      private set => this.dnstotcnamerecfailedField = value;
    }

    public long dnstotsrvrecqueries
    {
      get => this.dnstotsrvrecqueriesField;
      private set => this.dnstotsrvrecqueriesField = value;
    }

    public long dnstotaresponse
    {
      get => this.dnstotaresponseField;
      private set => this.dnstotaresponseField = value;
    }

    public long dnscnamerecqueriesrate
    {
      get => this.dnscnamerecqueriesrateField;
      private set => this.dnscnamerecqueriesrateField = value;
    }

    public long dns64totnodataresp
    {
      get => this.dns64totnodatarespField;
      private set => this.dns64totnodatarespField = value;
    }

    public long dnstotqueries
    {
      get => this.dnstotqueriesField;
      private set => this.dnstotqueriesField = value;
    }

    public long dnstotsrvresponse
    {
      get => this.dnstotsrvresponseField;
      private set => this.dnstotsrvresponseField = value;
    }

    public long dnstotunsupportedresponseclass
    {
      get => this.dnstotunsupportedresponseclassField;
      private set => this.dnstotunsupportedresponseclassField = value;
    }

    public long dnstotcacheflush
    {
      get => this.dnstotcacheflushField;
      private set => this.dnstotcacheflushField = value;
    }

    public long dnstotarecfailed
    {
      get => this.dnstotarecfailedField;
      private set => this.dnstotarecfailedField = value;
    }

    public long dnstotsrvrecupdate
    {
      get => this.dnstotsrvrecupdateField;
      private set => this.dnstotsrvrecupdateField = value;
    }

    public long dns64svraqueriesrate
    {
      get => this.dns64svraqueriesrateField;
      private set => this.dns64svraqueriesrateField = value;
    }

    public long dnsserverqueryrate
    {
      get => this.dnsserverqueryrateField;
      private set => this.dnsserverqueryrateField = value;
    }

    public long dnscurnsrecord
    {
      get => this.dnscurnsrecordField;
      private set => this.dnscurnsrecordField = value;
    }

    public long dnstotsoarecupdate
    {
      get => this.dnstotsoarecupdateField;
      private set => this.dnstotsoarecupdateField = value;
    }

    public long dns64queriesrate
    {
      get => this.dns64queriesrateField;
      private set => this.dns64queriesrateField = value;
    }

    public long dnstotnonauthnodatas
    {
      get => this.dnstotnonauthnodatasField;
      private set => this.dnstotnonauthnodatasField = value;
    }

    public long dnstotauthans
    {
      get => this.dnstotauthansField;
      private set => this.dnstotauthansField = value;
    }

    public long dnstotreqrefusals
    {
      get => this.dnstotreqrefusalsField;
      private set => this.dnstotreqrefusalsField = value;
    }

    public long dnscurmxrecord
    {
      get => this.dnscurmxrecordField;
      private set => this.dnscurmxrecordField = value;
    }

    public long dns64tcanswersrate
    {
      get => this.dns64tcanswersrateField;
      private set => this.dns64tcanswersrateField = value;
    }

    public long dnstotrecupdate
    {
      get => this.dnstotrecupdateField;
      private set => this.dnstotrecupdateField = value;
    }

    public long dns64totgslbqueries
    {
      get => this.dns64totgslbqueriesField;
      private set => this.dns64totgslbqueriesField = value;
    }

    public long dnstotnodataresps
    {
      get => this.dnstotnodatarespsField;
      private set => this.dnstotnodatarespsField = value;
    }

    public long dnstotptrresponse
    {
      get => this.dnstotptrresponseField;
      private set => this.dnstotptrresponseField = value;
    }

    public long dnsmxresponserate
    {
      get => this.dnsmxresponserateField;
      private set => this.dnsmxresponserateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      dns_stats[] dnsStatsArray = new dns_stats[1];
      dns_stats.dns_response dnsResponse = new dns_stats.dns_response();
      dns_stats.dns_response resource = (dns_stats.dns_response) service.get_payload_formatter().string_to_resource(dnsResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      dnsStatsArray[0] = resource.dns;
      return (base_resource[]) dnsStatsArray;
    }

    internal override string get_object_name() => (string) null;

    public static dns_stats get(nitro_service service) => ((dns_stats[]) new dns_stats().stat_resources(service, (options) null))[0];

    public static dns_stats get(nitro_service service, options option) => ((dns_stats[]) new dns_stats().stat_resources(service, option))[0];

    private class dns_response : base_response
    {
      public dns_stats dns = (dns_stats) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
