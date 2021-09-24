// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.appqoe.appqoe_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.appqoe
{
  public class appqoe_stats : base_resource
  {
    private string clearstatsField = (string) null;
    private long totinmemrspField = 0;
    private long inmemrsprateField = 0;
    private long totfaultycookiesField = 0;
    private long faultycookiesrateField = 0;
    private long totvalidcookiesField = 0;
    private long validcookiesrateField = 0;
    private long tothighprireqField = 0;
    private long highprireqrateField = 0;
    private long totmediumprireqField = 0;
    private long mediumprireqrateField = 0;
    private long totlowprireqField = 0;
    private long lowprireqrateField = 0;
    private long totlowestprireqField = 0;
    private long lowestprireqrateField = 0;
    private long totaltsvrsubfailedField = 0;
    private long tsvrsubfailedrateField = 0;
    private long totdostrigField = 0;
    private long dostrigrateField = 0;
    private long totdosqvalidcookiesField = 0;
    private long dosqvalidcookiesrateField = 0;
    private long totdoshvalidcookiesField = 0;
    private long doshvalidcookiesrateField = 0;
    private long totsidvalidcookiesField = 0;
    private long sidvalidcookiesrateField = 0;
    private long totonhvalidcookiesField = 0;
    private long onhvalidcookiesrateField = 0;
    private long totpriqvalidcookiesField = 0;
    private long priqvalidcookiesrateField = 0;
    private long totdosqfaultycookiesField = 0;
    private long dosqfaultycookiesrateField = 0;
    private long totdoshfaultycookiesField = 0;
    private long doshfaultycookiesrateField = 0;
    private long totsidfaultycookiesField = 0;
    private long sidfaultycookiesrateField = 0;
    private long totonhfaultycookiesField = 0;
    private long onhfaultycookiesrateField = 0;
    private long totpriqfaultycookiesField = 0;
    private long priqfaultycookiesrateField = 0;
    private long totpriembedlinksField = 0;
    private long priembedlinksrateField = 0;
    private long totsessreqField = 0;
    private long sessreqrateField = 0;
    private long totaltcntreqField = 0;
    private long tcntreqrateField = 0;
    private long totgetinmemrspField = 0;
    private long getinmemrsprateField = 0;
    private long totpostinmemrspField = 0;
    private long postinmemrsprateField = 0;
    private long totpostinmemrspbytesField = 0;
    private long postinmemrspbytesrateField = 0;

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long totpriqvalidcookies
    {
      get => this.totpriqvalidcookiesField;
      private set => this.totpriqvalidcookiesField = value;
    }

    public long totonhvalidcookies
    {
      get => this.totonhvalidcookiesField;
      private set => this.totonhvalidcookiesField = value;
    }

    public long dosqvalidcookiesrate
    {
      get => this.dosqvalidcookiesrateField;
      private set => this.dosqvalidcookiesrateField = value;
    }

    public long sidvalidcookiesrate
    {
      get => this.sidvalidcookiesrateField;
      private set => this.sidvalidcookiesrateField = value;
    }

    public long onhvalidcookiesrate
    {
      get => this.onhvalidcookiesrateField;
      private set => this.onhvalidcookiesrateField = value;
    }

    public long totdosqvalidcookies
    {
      get => this.totdosqvalidcookiesField;
      private set => this.totdosqvalidcookiesField = value;
    }

    public long dostrigrate
    {
      get => this.dostrigrateField;
      private set => this.dostrigrateField = value;
    }

    public long totgetinmemrsp
    {
      get => this.totgetinmemrspField;
      private set => this.totgetinmemrspField = value;
    }

    public long totlowprireq
    {
      get => this.totlowprireqField;
      private set => this.totlowprireqField = value;
    }

    public long totdoshfaultycookies
    {
      get => this.totdoshfaultycookiesField;
      private set => this.totdoshfaultycookiesField = value;
    }

    public long doshfaultycookiesrate
    {
      get => this.doshfaultycookiesrateField;
      private set => this.doshfaultycookiesrateField = value;
    }

    public long sessreqrate
    {
      get => this.sessreqrateField;
      private set => this.sessreqrateField = value;
    }

    public long totpostinmemrspbytes
    {
      get => this.totpostinmemrspbytesField;
      private set => this.totpostinmemrspbytesField = value;
    }

    public long totpriqfaultycookies
    {
      get => this.totpriqfaultycookiesField;
      private set => this.totpriqfaultycookiesField = value;
    }

    public long totpostinmemrsp
    {
      get => this.totpostinmemrspField;
      private set => this.totpostinmemrspField = value;
    }

    public long priembedlinksrate
    {
      get => this.priembedlinksrateField;
      private set => this.priembedlinksrateField = value;
    }

    public long mediumprireqrate
    {
      get => this.mediumprireqrateField;
      private set => this.mediumprireqrateField = value;
    }

    public long totdostrig
    {
      get => this.totdostrigField;
      private set => this.totdostrigField = value;
    }

    public long totvalidcookies
    {
      get => this.totvalidcookiesField;
      private set => this.totvalidcookiesField = value;
    }

    public long totinmemrsp
    {
      get => this.totinmemrspField;
      private set => this.totinmemrspField = value;
    }

    public long totsidfaultycookies
    {
      get => this.totsidfaultycookiesField;
      private set => this.totsidfaultycookiesField = value;
    }

    public long totsidvalidcookies
    {
      get => this.totsidvalidcookiesField;
      private set => this.totsidvalidcookiesField = value;
    }

    public long totdosqfaultycookies
    {
      get => this.totdosqfaultycookiesField;
      private set => this.totdosqfaultycookiesField = value;
    }

    public long tsvrsubfailedrate
    {
      get => this.tsvrsubfailedrateField;
      private set => this.tsvrsubfailedrateField = value;
    }

    public long postinmemrsprate
    {
      get => this.postinmemrsprateField;
      private set => this.postinmemrsprateField = value;
    }

    public long totpriembedlinks
    {
      get => this.totpriembedlinksField;
      private set => this.totpriembedlinksField = value;
    }

    public long totmediumprireq
    {
      get => this.totmediumprireqField;
      private set => this.totmediumprireqField = value;
    }

    public long priqvalidcookiesrate
    {
      get => this.priqvalidcookiesrateField;
      private set => this.priqvalidcookiesrateField = value;
    }

    public long totfaultycookies
    {
      get => this.totfaultycookiesField;
      private set => this.totfaultycookiesField = value;
    }

    public long doshvalidcookiesrate
    {
      get => this.doshvalidcookiesrateField;
      private set => this.doshvalidcookiesrateField = value;
    }

    public long sidfaultycookiesrate
    {
      get => this.sidfaultycookiesrateField;
      private set => this.sidfaultycookiesrateField = value;
    }

    public long highprireqrate
    {
      get => this.highprireqrateField;
      private set => this.highprireqrateField = value;
    }

    public long dosqfaultycookiesrate
    {
      get => this.dosqfaultycookiesrateField;
      private set => this.dosqfaultycookiesrateField = value;
    }

    public long inmemrsprate
    {
      get => this.inmemrsprateField;
      private set => this.inmemrsprateField = value;
    }

    public long getinmemrsprate
    {
      get => this.getinmemrsprateField;
      private set => this.getinmemrsprateField = value;
    }

    public long onhfaultycookiesrate
    {
      get => this.onhfaultycookiesrateField;
      private set => this.onhfaultycookiesrateField = value;
    }

    public long validcookiesrate
    {
      get => this.validcookiesrateField;
      private set => this.validcookiesrateField = value;
    }

    public long totaltcntreq
    {
      get => this.totaltcntreqField;
      private set => this.totaltcntreqField = value;
    }

    public long totsessreq
    {
      get => this.totsessreqField;
      private set => this.totsessreqField = value;
    }

    public long priqfaultycookiesrate
    {
      get => this.priqfaultycookiesrateField;
      private set => this.priqfaultycookiesrateField = value;
    }

    public long tcntreqrate
    {
      get => this.tcntreqrateField;
      private set => this.tcntreqrateField = value;
    }

    public long totdoshvalidcookies
    {
      get => this.totdoshvalidcookiesField;
      private set => this.totdoshvalidcookiesField = value;
    }

    public long lowprireqrate
    {
      get => this.lowprireqrateField;
      private set => this.lowprireqrateField = value;
    }

    public long tothighprireq
    {
      get => this.tothighprireqField;
      private set => this.tothighprireqField = value;
    }

    public long totaltsvrsubfailed
    {
      get => this.totaltsvrsubfailedField;
      private set => this.totaltsvrsubfailedField = value;
    }

    public long totlowestprireq
    {
      get => this.totlowestprireqField;
      private set => this.totlowestprireqField = value;
    }

    public long lowestprireqrate
    {
      get => this.lowestprireqrateField;
      private set => this.lowestprireqrateField = value;
    }

    public long totonhfaultycookies
    {
      get => this.totonhfaultycookiesField;
      private set => this.totonhfaultycookiesField = value;
    }

    public long faultycookiesrate
    {
      get => this.faultycookiesrateField;
      private set => this.faultycookiesrateField = value;
    }

    public long postinmemrspbytesrate
    {
      get => this.postinmemrspbytesrateField;
      private set => this.postinmemrspbytesrateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      appqoe_stats[] appqoeStatsArray = new appqoe_stats[1];
      appqoe_stats.appqoe_response appqoeResponse = new appqoe_stats.appqoe_response();
      appqoe_stats.appqoe_response resource = (appqoe_stats.appqoe_response) service.get_payload_formatter().string_to_resource(appqoeResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      appqoeStatsArray[0] = resource.appqoe;
      return (base_resource[]) appqoeStatsArray;
    }

    internal override string get_object_name() => (string) null;

    public static appqoe_stats get(nitro_service service) => ((appqoe_stats[]) new appqoe_stats().stat_resources(service, (options) null))[0];

    public static appqoe_stats get(nitro_service service, options option) => ((appqoe_stats[]) new appqoe_stats().stat_resources(service, option))[0];

    private class appqoe_response : base_response
    {
      public appqoe_stats appqoe = (appqoe_stats) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
