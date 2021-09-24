// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.cache.cache_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.cache
{
  public class cache_stats : base_resource
  {
    private string clearstatsField = (string) null;
    private long cachemaxmemorykbField = 0;
    private long cacherecentpercentsuccessfulrevalidationField = 0;
    private long cacherecentpercentstoreablemissField = 0;
    private long cacherecentpercentparameterizedhitsField = 0;
    private long cacherecentpercentoriginbandwidthsavedField = 0;
    private long cacherecentpercenthitField = 0;
    private long cacherecentpercentbytehitField = 0;
    private long cacherecentpercent304hitsField = 0;
    private long cacheutilizedmemorykbField = 0;
    private long cachemaxmemoryactivekbField = 0;
    private long cache64maxmemorykbField = 0;
    private long cachepercentpethitsField = 0;
    private long cachetotpethitsField = 0;
    private long cachepethitsrateField = 0;
    private long cachepercentparameterized304hitsField = 0;
    private long cachetotparameterizedhitsField = 0;
    private long cacheparameterizedhitsrateField = 0;
    private long cachepercentsuccessfulrevalidationField = 0;
    private long cachepercentstoreablemissField = 0;
    private long cachetotfulltoconditionalrequestField = 0;
    private long cachefulltoconditionalrequestrateField = 0;
    private long cachetotsuccessfulrevalidationField = 0;
    private long cachesuccessfulrevalidationrateField = 0;
    private long cachetotrevalidationmissField = 0;
    private long cacherevalidationmissrateField = 0;
    private long cachetotnonstoreablemissesField = 0;
    private long cachenonstoreablemissesrateField = 0;
    private long cachetotstoreablemissesField = 0;
    private long cachestoreablemissesrateField = 0;
    private long cachecompressedbytesservedField = 0;
    private long cachecompressedbytesservedrateField = 0;
    private long cachepercentbytehitField = 0;
    private long cachebytesservedField = 0;
    private long cachebytesservedrateField = 0;
    private long cachetotresponsebytesField = 0;
    private long cacheresponsebytesrateField = 0;
    private long cachepercent304hitsField = 0;
    private long cachenummarkerField = 0;
    private long cachepercentoriginbandwidthsavedField = 0;
    private long cachepercenthitField = 0;
    private long cachetotmissesField = 0;
    private long cachemissesrateField = 0;
    private long cachetothitsField = 0;
    private long cachehitsrateField = 0;
    private long cachetotrequestsField = 0;
    private long cacherequestsrateField = 0;
    private long cachenumcachedField = 0;
    private long cachecurhitsField = 0;
    private long cachecurmissesField = 0;
    private long cachetotnon304hitsField = 0;
    private long cachenon304hitsrateField = 0;
    private long cachetot304hitsField = 0;
    private long cache304hitsrateField = 0;
    private long cachetotsqlhitsField = 0;
    private long cachesqlhitsrateField = 0;
    private long cachetotexpireatlastbyteField = 0;
    private long cacheexpireatlastbyterateField = 0;
    private long cachetotflashcachemissesField = 0;
    private long cacheflashcachemissesrateField = 0;
    private long cachetotflashcachehitsField = 0;
    private long cacheflashcachehitsrateField = 0;
    private long cachetotparameterizedinvalidationrequestsField = 0;
    private long cacheparameterizedinvalidationrequestsrateField = 0;
    private long cachetotnonparameterizedinvalidationrequestsField = 0;
    private long cachenonparameterizedinvalidationrequestsrateField = 0;
    private long cachetotinvalidationrequestsField = 0;
    private long cacheinvalidationrequestsrateField = 0;
    private long cachetotparameterizedrequestsField = 0;
    private long cacheparameterizedrequestsrateField = 0;
    private long cachetotparameterizednon304hitsField = 0;
    private long cacheparameterizednon304hitsrateField = 0;
    private long cachetotparameterized304hitsField = 0;
    private long cacheparameterized304hitsrateField = 0;
    private long cachetotpetrequestsField = 0;
    private long cachepetrequestsrateField = 0;
    private long cacheerrmemallocField = 0;
    private long cachelargestresponsereceivedField = 0;

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long cachehitsrate
    {
      get => this.cachehitsrateField;
      private set => this.cachehitsrateField = value;
    }

    public long cachepethitsrate
    {
      get => this.cachepethitsrateField;
      private set => this.cachepethitsrateField = value;
    }

    public long cachetotexpireatlastbyte
    {
      get => this.cachetotexpireatlastbyteField;
      private set => this.cachetotexpireatlastbyteField = value;
    }

    public long cachenummarker
    {
      get => this.cachenummarkerField;
      private set => this.cachenummarkerField = value;
    }

    public long cachecurhits
    {
      get => this.cachecurhitsField;
      private set => this.cachecurhitsField = value;
    }

    public long cacheresponsebytesrate
    {
      get => this.cacheresponsebytesrateField;
      private set => this.cacheresponsebytesrateField = value;
    }

    public long cacheutilizedmemorykb
    {
      get => this.cacheutilizedmemorykbField;
      private set => this.cacheutilizedmemorykbField = value;
    }

    public long cachetotnonparameterizedinvalidationrequests
    {
      get => this.cachetotnonparameterizedinvalidationrequestsField;
      private set => this.cachetotnonparameterizedinvalidationrequestsField = value;
    }

    public long cachepercentpethits
    {
      get => this.cachepercentpethitsField;
      private set => this.cachepercentpethitsField = value;
    }

    public long cachebytesserved
    {
      get => this.cachebytesservedField;
      private set => this.cachebytesservedField = value;
    }

    public long cachetotparameterizednon304hits
    {
      get => this.cachetotparameterizednon304hitsField;
      private set => this.cachetotparameterizednon304hitsField = value;
    }

    public long cachebytesservedrate
    {
      get => this.cachebytesservedrateField;
      private set => this.cachebytesservedrateField = value;
    }

    public long cachepercent304hits
    {
      get => this.cachepercent304hitsField;
      private set => this.cachepercent304hitsField = value;
    }

    public long cachepercentbytehit
    {
      get => this.cachepercentbytehitField;
      private set => this.cachepercentbytehitField = value;
    }

    public long cachepercentstoreablemiss
    {
      get => this.cachepercentstoreablemissField;
      private set => this.cachepercentstoreablemissField = value;
    }

    public long cachetotpetrequests
    {
      get => this.cachetotpetrequestsField;
      private set => this.cachetotpetrequestsField = value;
    }

    public long cachecompressedbytesserved
    {
      get => this.cachecompressedbytesservedField;
      private set => this.cachecompressedbytesservedField = value;
    }

    public long cachetotresponsebytes
    {
      get => this.cachetotresponsebytesField;
      private set => this.cachetotresponsebytesField = value;
    }

    public long cachelargestresponsereceived
    {
      get => this.cachelargestresponsereceivedField;
      private set => this.cachelargestresponsereceivedField = value;
    }

    public long cachenonparameterizedinvalidationrequestsrate
    {
      get => this.cachenonparameterizedinvalidationrequestsrateField;
      private set => this.cachenonparameterizedinvalidationrequestsrateField = value;
    }

    public long cacherecentpercentbytehit
    {
      get => this.cacherecentpercentbytehitField;
      private set => this.cacherecentpercentbytehitField = value;
    }

    public long cacherecentpercentsuccessfulrevalidation
    {
      get => this.cacherecentpercentsuccessfulrevalidationField;
      private set => this.cacherecentpercentsuccessfulrevalidationField = value;
    }

    public long cachesuccessfulrevalidationrate
    {
      get => this.cachesuccessfulrevalidationrateField;
      private set => this.cachesuccessfulrevalidationrateField = value;
    }

    public long cachesqlhitsrate
    {
      get => this.cachesqlhitsrateField;
      private set => this.cachesqlhitsrateField = value;
    }

    public long cacherequestsrate
    {
      get => this.cacherequestsrateField;
      private set => this.cacherequestsrateField = value;
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

    public long cachenumcached
    {
      get => this.cachenumcachedField;
      private set => this.cachenumcachedField = value;
    }

    public long cachetothits
    {
      get => this.cachetothitsField;
      private set => this.cachetothitsField = value;
    }

    public long cachetotsuccessfulrevalidation
    {
      get => this.cachetotsuccessfulrevalidationField;
      private set => this.cachetotsuccessfulrevalidationField = value;
    }

    public long cachepercentparameterized304hits
    {
      get => this.cachepercentparameterized304hitsField;
      private set => this.cachepercentparameterized304hitsField = value;
    }

    public long cacheflashcachehitsrate
    {
      get => this.cacheflashcachehitsrateField;
      private set => this.cacheflashcachehitsrateField = value;
    }

    public long cachestoreablemissesrate
    {
      get => this.cachestoreablemissesrateField;
      private set => this.cachestoreablemissesrateField = value;
    }

    public long cachetotflashcachehits
    {
      get => this.cachetotflashcachehitsField;
      private set => this.cachetotflashcachehitsField = value;
    }

    public long cachetotsqlhits
    {
      get => this.cachetotsqlhitsField;
      private set => this.cachetotsqlhitsField = value;
    }

    public long cachetotrevalidationmiss
    {
      get => this.cachetotrevalidationmissField;
      private set => this.cachetotrevalidationmissField = value;
    }

    public long cachemaxmemoryactivekb
    {
      get => this.cachemaxmemoryactivekbField;
      private set => this.cachemaxmemoryactivekbField = value;
    }

    public long cachetotstoreablemisses
    {
      get => this.cachetotstoreablemissesField;
      private set => this.cachetotstoreablemissesField = value;
    }

    public long cacheparameterizedhitsrate
    {
      get => this.cacheparameterizedhitsrateField;
      private set => this.cacheparameterizedhitsrateField = value;
    }

    public long cacheparameterized304hitsrate
    {
      get => this.cacheparameterized304hitsrateField;
      private set => this.cacheparameterized304hitsrateField = value;
    }

    public long cacheexpireatlastbyterate
    {
      get => this.cacheexpireatlastbyterateField;
      private set => this.cacheexpireatlastbyterateField = value;
    }

    public long cachecurmisses
    {
      get => this.cachecurmissesField;
      private set => this.cachecurmissesField = value;
    }

    public long cacherevalidationmissrate
    {
      get => this.cacherevalidationmissrateField;
      private set => this.cacherevalidationmissrateField = value;
    }

    public long cachenon304hitsrate
    {
      get => this.cachenon304hitsrateField;
      private set => this.cachenon304hitsrateField = value;
    }

    public long cachepercentsuccessfulrevalidation
    {
      get => this.cachepercentsuccessfulrevalidationField;
      private set => this.cachepercentsuccessfulrevalidationField = value;
    }

    public long cachetotnon304hits
    {
      get => this.cachetotnon304hitsField;
      private set => this.cachetotnon304hitsField = value;
    }

    public long cachefulltoconditionalrequestrate
    {
      get => this.cachefulltoconditionalrequestrateField;
      private set => this.cachefulltoconditionalrequestrateField = value;
    }

    public long cacherecentpercentoriginbandwidthsaved
    {
      get => this.cacherecentpercentoriginbandwidthsavedField;
      private set => this.cacherecentpercentoriginbandwidthsavedField = value;
    }

    public long cacherecentpercentparameterizedhits
    {
      get => this.cacherecentpercentparameterizedhitsField;
      private set => this.cacherecentpercentparameterizedhitsField = value;
    }

    public long cachetotparameterizedinvalidationrequests
    {
      get => this.cachetotparameterizedinvalidationrequestsField;
      private set => this.cachetotparameterizedinvalidationrequestsField = value;
    }

    public long cachetotflashcachemisses
    {
      get => this.cachetotflashcachemissesField;
      private set => this.cachetotflashcachemissesField = value;
    }

    public long cacheparameterizedrequestsrate
    {
      get => this.cacheparameterizedrequestsrateField;
      private set => this.cacheparameterizedrequestsrateField = value;
    }

    public long cacheerrmemalloc
    {
      get => this.cacheerrmemallocField;
      private set => this.cacheerrmemallocField = value;
    }

    public long cacherecentpercenthit
    {
      get => this.cacherecentpercenthitField;
      private set => this.cacherecentpercenthitField = value;
    }

    public long cachecompressedbytesservedrate
    {
      get => this.cachecompressedbytesservedrateField;
      private set => this.cachecompressedbytesservedrateField = value;
    }

    public long cache304hitsrate
    {
      get => this.cache304hitsrateField;
      private set => this.cache304hitsrateField = value;
    }

    public long cachepercenthit
    {
      get => this.cachepercenthitField;
      private set => this.cachepercenthitField = value;
    }

    public long cachenonstoreablemissesrate
    {
      get => this.cachenonstoreablemissesrateField;
      private set => this.cachenonstoreablemissesrateField = value;
    }

    public long cachetotinvalidationrequests
    {
      get => this.cachetotinvalidationrequestsField;
      private set => this.cachetotinvalidationrequestsField = value;
    }

    public long cache64maxmemorykb
    {
      get => this.cache64maxmemorykbField;
      private set => this.cache64maxmemorykbField = value;
    }

    public long cachetot304hits
    {
      get => this.cachetot304hitsField;
      private set => this.cachetot304hitsField = value;
    }

    public long cachetotfulltoconditionalrequest
    {
      get => this.cachetotfulltoconditionalrequestField;
      private set => this.cachetotfulltoconditionalrequestField = value;
    }

    public long cachetotparameterizedhits
    {
      get => this.cachetotparameterizedhitsField;
      private set => this.cachetotparameterizedhitsField = value;
    }

    public long cachepetrequestsrate
    {
      get => this.cachepetrequestsrateField;
      private set => this.cachepetrequestsrateField = value;
    }

    public long cacherecentpercent304hits
    {
      get => this.cacherecentpercent304hitsField;
      private set => this.cacherecentpercent304hitsField = value;
    }

    public long cachetotnonstoreablemisses
    {
      get => this.cachetotnonstoreablemissesField;
      private set => this.cachetotnonstoreablemissesField = value;
    }

    public long cachetotparameterizedrequests
    {
      get => this.cachetotparameterizedrequestsField;
      private set => this.cachetotparameterizedrequestsField = value;
    }

    public long cachepercentoriginbandwidthsaved
    {
      get => this.cachepercentoriginbandwidthsavedField;
      private set => this.cachepercentoriginbandwidthsavedField = value;
    }

    public long cachetotrequests
    {
      get => this.cachetotrequestsField;
      private set => this.cachetotrequestsField = value;
    }

    public long cacheparameterizednon304hitsrate
    {
      get => this.cacheparameterizednon304hitsrateField;
      private set => this.cacheparameterizednon304hitsrateField = value;
    }

    public long cachetotmisses
    {
      get => this.cachetotmissesField;
      private set => this.cachetotmissesField = value;
    }

    public long cachetotpethits
    {
      get => this.cachetotpethitsField;
      private set => this.cachetotpethitsField = value;
    }

    public long cacheparameterizedinvalidationrequestsrate
    {
      get => this.cacheparameterizedinvalidationrequestsrateField;
      private set => this.cacheparameterizedinvalidationrequestsrateField = value;
    }

    public long cacherecentpercentstoreablemiss
    {
      get => this.cacherecentpercentstoreablemissField;
      private set => this.cacherecentpercentstoreablemissField = value;
    }

    public long cacheflashcachemissesrate
    {
      get => this.cacheflashcachemissesrateField;
      private set => this.cacheflashcachemissesrateField = value;
    }

    public long cacheinvalidationrequestsrate
    {
      get => this.cacheinvalidationrequestsrateField;
      private set => this.cacheinvalidationrequestsrateField = value;
    }

    public long cachetotparameterized304hits
    {
      get => this.cachetotparameterized304hitsField;
      private set => this.cachetotparameterized304hitsField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      cache_stats[] cacheStatsArray = new cache_stats[1];
      cache_stats.cache_response cacheResponse = new cache_stats.cache_response();
      cache_stats.cache_response resource = (cache_stats.cache_response) service.get_payload_formatter().string_to_resource(cacheResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      cacheStatsArray[0] = resource.cache;
      return (base_resource[]) cacheStatsArray;
    }

    internal override string get_object_name() => (string) null;

    public static cache_stats get(nitro_service service) => ((cache_stats[]) new cache_stats().stat_resources(service, (options) null))[0];

    public static cache_stats get(nitro_service service, options option) => ((cache_stats[]) new cache_stats().stat_resources(service, option))[0];

    private class cache_response : base_response
    {
      public cache_stats cache = (cache_stats) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
