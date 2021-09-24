// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.protocol.protocolicmpv6_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.protocol
{
  public class protocolicmpv6_stats : base_resource
  {
    private string clearstatsField = (string) null;
    private long icmpv6totrxpktsField = 0;
    private long icmpv6rxpktsrateField = 0;
    private long icmpv6totrxbytesField = 0;
    private long icmpv6rxbytesrateField = 0;
    private long icmpv6tottxpktsField = 0;
    private long icmpv6txpktsrateField = 0;
    private long icmpv6tottxbytesField = 0;
    private long icmpv6txbytesrateField = 0;
    private long icmpv6totrxnaField = 0;
    private long icmpv6rxnarateField = 0;
    private long icmpv6totrxnsField = 0;
    private long icmpv6rxnsrateField = 0;
    private long icmpv6totrxraField = 0;
    private long icmpv6rxrarateField = 0;
    private long icmpv6totrxrsField = 0;
    private long icmpv6rxrsrateField = 0;
    private long icmpv6totrxechoreqField = 0;
    private long icmpv6rxechoreqrateField = 0;
    private long icmpv6totrxechoreplyField = 0;
    private long icmpv6rxechoreplyrateField = 0;
    private long icmpv6tottxnaField = 0;
    private long icmpv6txnarateField = 0;
    private long icmpv6tottxnsField = 0;
    private long icmpv6txnsrateField = 0;
    private long icmpv6tottxraField = 0;
    private long icmpv6txrarateField = 0;
    private long icmpv6tottxrsField = 0;
    private long icmpv6txrsrateField = 0;
    private long icmpv6tottxechoreqField = 0;
    private long icmpv6txechoreqrateField = 0;
    private long icmpv6tottxechoreplyField = 0;
    private long icmpv6txechoreplyrateField = 0;
    private long icmpv6errraField = 0;
    private long icmpv6errnaField = 0;
    private long icmpv6errnsField = 0;
    private long icmpv6badchecksumsField = 0;
    private long icmpv6unsptField = 0;
    private long icmpv6rtthsldField = 0;

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long icmpv6tottxns
    {
      get => this.icmpv6tottxnsField;
      private set => this.icmpv6tottxnsField = value;
    }

    public long icmpv6txpktsrate
    {
      get => this.icmpv6txpktsrateField;
      private set => this.icmpv6txpktsrateField = value;
    }

    public long icmpv6unspt
    {
      get => this.icmpv6unsptField;
      private set => this.icmpv6unsptField = value;
    }

    public long icmpv6totrxechoreply
    {
      get => this.icmpv6totrxechoreplyField;
      private set => this.icmpv6totrxechoreplyField = value;
    }

    public long icmpv6tottxra
    {
      get => this.icmpv6tottxraField;
      private set => this.icmpv6tottxraField = value;
    }

    public long icmpv6tottxechoreply
    {
      get => this.icmpv6tottxechoreplyField;
      private set => this.icmpv6tottxechoreplyField = value;
    }

    public long icmpv6badchecksums
    {
      get => this.icmpv6badchecksumsField;
      private set => this.icmpv6badchecksumsField = value;
    }

    public long icmpv6txnarate
    {
      get => this.icmpv6txnarateField;
      private set => this.icmpv6txnarateField = value;
    }

    public long icmpv6txrsrate
    {
      get => this.icmpv6txrsrateField;
      private set => this.icmpv6txrsrateField = value;
    }

    public long icmpv6tottxna
    {
      get => this.icmpv6tottxnaField;
      private set => this.icmpv6tottxnaField = value;
    }

    public long icmpv6totrxra
    {
      get => this.icmpv6totrxraField;
      private set => this.icmpv6totrxraField = value;
    }

    public long icmpv6tottxrs
    {
      get => this.icmpv6tottxrsField;
      private set => this.icmpv6tottxrsField = value;
    }

    public long icmpv6rxpktsrate
    {
      get => this.icmpv6rxpktsrateField;
      private set => this.icmpv6rxpktsrateField = value;
    }

    public long icmpv6totrxpkts
    {
      get => this.icmpv6totrxpktsField;
      private set => this.icmpv6totrxpktsField = value;
    }

    public long icmpv6totrxns
    {
      get => this.icmpv6totrxnsField;
      private set => this.icmpv6totrxnsField = value;
    }

    public long icmpv6rxechoreplyrate
    {
      get => this.icmpv6rxechoreplyrateField;
      private set => this.icmpv6rxechoreplyrateField = value;
    }

    public long icmpv6txechoreqrate
    {
      get => this.icmpv6txechoreqrateField;
      private set => this.icmpv6txechoreqrateField = value;
    }

    public long icmpv6rxrsrate
    {
      get => this.icmpv6rxrsrateField;
      private set => this.icmpv6rxrsrateField = value;
    }

    public long icmpv6errna
    {
      get => this.icmpv6errnaField;
      private set => this.icmpv6errnaField = value;
    }

    public long icmpv6rxnsrate
    {
      get => this.icmpv6rxnsrateField;
      private set => this.icmpv6rxnsrateField = value;
    }

    public long icmpv6rxbytesrate
    {
      get => this.icmpv6rxbytesrateField;
      private set => this.icmpv6rxbytesrateField = value;
    }

    public long icmpv6rtthsld
    {
      get => this.icmpv6rtthsldField;
      private set => this.icmpv6rtthsldField = value;
    }

    public long icmpv6totrxrs
    {
      get => this.icmpv6totrxrsField;
      private set => this.icmpv6totrxrsField = value;
    }

    public long icmpv6totrxna
    {
      get => this.icmpv6totrxnaField;
      private set => this.icmpv6totrxnaField = value;
    }

    public long icmpv6txechoreplyrate
    {
      get => this.icmpv6txechoreplyrateField;
      private set => this.icmpv6txechoreplyrateField = value;
    }

    public long icmpv6totrxbytes
    {
      get => this.icmpv6totrxbytesField;
      private set => this.icmpv6totrxbytesField = value;
    }

    public long icmpv6txrarate
    {
      get => this.icmpv6txrarateField;
      private set => this.icmpv6txrarateField = value;
    }

    public long icmpv6errns
    {
      get => this.icmpv6errnsField;
      private set => this.icmpv6errnsField = value;
    }

    public long icmpv6totrxechoreq
    {
      get => this.icmpv6totrxechoreqField;
      private set => this.icmpv6totrxechoreqField = value;
    }

    public long icmpv6tottxechoreq
    {
      get => this.icmpv6tottxechoreqField;
      private set => this.icmpv6tottxechoreqField = value;
    }

    public long icmpv6rxrarate
    {
      get => this.icmpv6rxrarateField;
      private set => this.icmpv6rxrarateField = value;
    }

    public long icmpv6rxechoreqrate
    {
      get => this.icmpv6rxechoreqrateField;
      private set => this.icmpv6rxechoreqrateField = value;
    }

    public long icmpv6tottxpkts
    {
      get => this.icmpv6tottxpktsField;
      private set => this.icmpv6tottxpktsField = value;
    }

    public long icmpv6tottxbytes
    {
      get => this.icmpv6tottxbytesField;
      private set => this.icmpv6tottxbytesField = value;
    }

    public long icmpv6rxnarate
    {
      get => this.icmpv6rxnarateField;
      private set => this.icmpv6rxnarateField = value;
    }

    public long icmpv6txnsrate
    {
      get => this.icmpv6txnsrateField;
      private set => this.icmpv6txnsrateField = value;
    }

    public long icmpv6errra
    {
      get => this.icmpv6errraField;
      private set => this.icmpv6errraField = value;
    }

    public long icmpv6txbytesrate
    {
      get => this.icmpv6txbytesrateField;
      private set => this.icmpv6txbytesrateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      protocolicmpv6_stats[] protocolicmpv6StatsArray = new protocolicmpv6_stats[1];
      protocolicmpv6_stats.protocolicmpv6_response protocolicmpv6Response = new protocolicmpv6_stats.protocolicmpv6_response();
      protocolicmpv6_stats.protocolicmpv6_response resource = (protocolicmpv6_stats.protocolicmpv6_response) service.get_payload_formatter().string_to_resource(protocolicmpv6Response.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      protocolicmpv6StatsArray[0] = resource.protocolicmpv6;
      return (base_resource[]) protocolicmpv6StatsArray;
    }

    internal override string get_object_name() => (string) null;

    public static protocolicmpv6_stats get(nitro_service service) => ((protocolicmpv6_stats[]) new protocolicmpv6_stats().stat_resources(service, (options) null))[0];

    public static protocolicmpv6_stats get(
      nitro_service service,
      options option)
    {
      return ((protocolicmpv6_stats[]) new protocolicmpv6_stats().stat_resources(service, option))[0];
    }

    private class protocolicmpv6_response : base_response
    {
      public protocolicmpv6_stats protocolicmpv6 = (protocolicmpv6_stats) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
