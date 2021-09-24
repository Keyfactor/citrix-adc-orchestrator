// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.protocol.protocolipv6_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.protocol
{
  public class protocolipv6_stats : base_resource
  {
    private string clearstatsField = (string) null;
    private long ipv6totrxpktsField = 0;
    private long ipv6rxpktsrateField = 0;
    private long ipv6totrxbytesField = 0;
    private long ipv6rxbytesrateField = 0;
    private long ipv6tottxpktsField = 0;
    private long ipv6txpktsrateField = 0;
    private long ipv6tottxbytesField = 0;
    private long ipv6txbytesrateField = 0;
    private long ipv6totroutepktsField = 0;
    private long ipv6routepktsrateField = 0;
    private long ipv6totroutembitsField = 0;
    private long ipv6routembitsrateField = 0;
    private long ipv6fragtotrxpktsField = 0;
    private long ipv6fragrxpktsrateField = 0;
    private long ipv6fragtottcpreassembledField = 0;
    private long ipv6fragtcpreassembledrateField = 0;
    private long ipv6fragtotudpreassembledField = 0;
    private long ipv6fragudpreassembledrateField = 0;
    private long ipv6fragtotpktsprocessnoreassField = 0;
    private long ipv6fragpktsprocessnoreassrateField = 0;
    private long ipv6fragtotpktsforwardField = 0;
    private long ipv6fragpktsforwardrateField = 0;
    private long ipv6errhdrField = 0;
    private long ipv6nextheadererrField = 0;
    private long ipv6landattackField = 0;
    private long ipv6fragpkttoobigField = 0;
    private long ipv6fragzerolenpktField = 0;
    private long ipv6toticmpnarxField = 0;
    private long ipv6icmpnarxrateField = 0;
    private long ipv6toticmpnsrxField = 0;
    private long ipv6icmpnsrxrateField = 0;
    private long ipv6toticmpnatxField = 0;
    private long ipv6icmpnatxrateField = 0;
    private long ipv6toticmpnstxField = 0;
    private long ipv6icmpnstxrateField = 0;
    private long ipv6toticmprarxField = 0;
    private long ipv6icmprarxrateField = 0;
    private long ipv6toticmprstxField = 0;
    private long ipv6icmprstxrateField = 0;
    private long ipv6toticmprxField = 0;
    private long ipv6icmprxrateField = 0;
    private long ipv6toticmptxField = 0;
    private long ipv6icmptxrateField = 0;
    private long ipv6errrxhdrField = 0;
    private long ipv6errrxpktField = 0;
    private long ipv6badcksumField = 0;
    private long icmpv6errorField = 0;
    private long icmpv6unsptField = 0;
    private long icmpv6rtthsldField = 0;

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long ipv6fragpktsforwardrate
    {
      get => this.ipv6fragpktsforwardrateField;
      private set => this.ipv6fragpktsforwardrateField = value;
    }

    public long ipv6icmprstxrate
    {
      get => this.ipv6icmprstxrateField;
      private set => this.ipv6icmprstxrateField = value;
    }

    public long ipv6fragrxpktsrate
    {
      get => this.ipv6fragrxpktsrateField;
      private set => this.ipv6fragrxpktsrateField = value;
    }

    public long ipv6totroutepkts
    {
      get => this.ipv6totroutepktsField;
      private set => this.ipv6totroutepktsField = value;
    }

    public long ipv6fragpkttoobig
    {
      get => this.ipv6fragpkttoobigField;
      private set => this.ipv6fragpkttoobigField = value;
    }

    public long ipv6toticmpnarx
    {
      get => this.ipv6toticmpnarxField;
      private set => this.ipv6toticmpnarxField = value;
    }

    public long ipv6fragtotrxpkts
    {
      get => this.ipv6fragtotrxpktsField;
      private set => this.ipv6fragtotrxpktsField = value;
    }

    public long ipv6icmpnatxrate
    {
      get => this.ipv6icmpnatxrateField;
      private set => this.ipv6icmpnatxrateField = value;
    }

    public long ipv6toticmpnsrx
    {
      get => this.ipv6toticmpnsrxField;
      private set => this.ipv6toticmpnsrxField = value;
    }

    public long ipv6routembitsrate
    {
      get => this.ipv6routembitsrateField;
      private set => this.ipv6routembitsrateField = value;
    }

    public long ipv6txpktsrate
    {
      get => this.ipv6txpktsrateField;
      private set => this.ipv6txpktsrateField = value;
    }

    public long icmpv6rtthsld
    {
      get => this.icmpv6rtthsldField;
      private set => this.icmpv6rtthsldField = value;
    }

    public long icmpv6unspt
    {
      get => this.icmpv6unsptField;
      private set => this.icmpv6unsptField = value;
    }

    public long ipv6badcksum
    {
      get => this.ipv6badcksumField;
      private set => this.ipv6badcksumField = value;
    }

    public long ipv6errrxhdr
    {
      get => this.ipv6errrxhdrField;
      private set => this.ipv6errrxhdrField = value;
    }

    public long ipv6totrxbytes
    {
      get => this.ipv6totrxbytesField;
      private set => this.ipv6totrxbytesField = value;
    }

    public long ipv6rxpktsrate
    {
      get => this.ipv6rxpktsrateField;
      private set => this.ipv6rxpktsrateField = value;
    }

    public long ipv6icmpnstxrate
    {
      get => this.ipv6icmpnstxrateField;
      private set => this.ipv6icmpnstxrateField = value;
    }

    public long ipv6icmprarxrate
    {
      get => this.ipv6icmprarxrateField;
      private set => this.ipv6icmprarxrateField = value;
    }

    public long ipv6errhdr
    {
      get => this.ipv6errhdrField;
      private set => this.ipv6errhdrField = value;
    }

    public long ipv6totrxpkts
    {
      get => this.ipv6totrxpktsField;
      private set => this.ipv6totrxpktsField = value;
    }

    public long ipv6toticmprx
    {
      get => this.ipv6toticmprxField;
      private set => this.ipv6toticmprxField = value;
    }

    public long ipv6fragtotpktsprocessnoreass
    {
      get => this.ipv6fragtotpktsprocessnoreassField;
      private set => this.ipv6fragtotpktsprocessnoreassField = value;
    }

    public long ipv6rxbytesrate
    {
      get => this.ipv6rxbytesrateField;
      private set => this.ipv6rxbytesrateField = value;
    }

    public long ipv6icmpnsrxrate
    {
      get => this.ipv6icmpnsrxrateField;
      private set => this.ipv6icmpnsrxrateField = value;
    }

    public long ipv6toticmpnatx
    {
      get => this.ipv6toticmpnatxField;
      private set => this.ipv6toticmpnatxField = value;
    }

    public long ipv6routepktsrate
    {
      get => this.ipv6routepktsrateField;
      private set => this.ipv6routepktsrateField = value;
    }

    public long ipv6icmptxrate
    {
      get => this.ipv6icmptxrateField;
      private set => this.ipv6icmptxrateField = value;
    }

    public long ipv6toticmprstx
    {
      get => this.ipv6toticmprstxField;
      private set => this.ipv6toticmprstxField = value;
    }

    public long ipv6totroutembits
    {
      get => this.ipv6totroutembitsField;
      private set => this.ipv6totroutembitsField = value;
    }

    public long ipv6icmprxrate
    {
      get => this.ipv6icmprxrateField;
      private set => this.ipv6icmprxrateField = value;
    }

    public long ipv6fragpktsprocessnoreassrate
    {
      get => this.ipv6fragpktsprocessnoreassrateField;
      private set => this.ipv6fragpktsprocessnoreassrateField = value;
    }

    public long ipv6fragtcpreassembledrate
    {
      get => this.ipv6fragtcpreassembledrateField;
      private set => this.ipv6fragtcpreassembledrateField = value;
    }

    public long ipv6tottxpkts
    {
      get => this.ipv6tottxpktsField;
      private set => this.ipv6tottxpktsField = value;
    }

    public long ipv6icmpnarxrate
    {
      get => this.ipv6icmpnarxrateField;
      private set => this.ipv6icmpnarxrateField = value;
    }

    public long ipv6fragtotudpreassembled
    {
      get => this.ipv6fragtotudpreassembledField;
      private set => this.ipv6fragtotudpreassembledField = value;
    }

    public long ipv6fragtottcpreassembled
    {
      get => this.ipv6fragtottcpreassembledField;
      private set => this.ipv6fragtottcpreassembledField = value;
    }

    public long ipv6errrxpkt
    {
      get => this.ipv6errrxpktField;
      private set => this.ipv6errrxpktField = value;
    }

    public long ipv6nextheadererr
    {
      get => this.ipv6nextheadererrField;
      private set => this.ipv6nextheadererrField = value;
    }

    public long ipv6toticmptx
    {
      get => this.ipv6toticmptxField;
      private set => this.ipv6toticmptxField = value;
    }

    public long ipv6toticmpnstx
    {
      get => this.ipv6toticmpnstxField;
      private set => this.ipv6toticmpnstxField = value;
    }

    public long ipv6fragudpreassembledrate
    {
      get => this.ipv6fragudpreassembledrateField;
      private set => this.ipv6fragudpreassembledrateField = value;
    }

    public long ipv6txbytesrate
    {
      get => this.ipv6txbytesrateField;
      private set => this.ipv6txbytesrateField = value;
    }

    public long icmpv6error
    {
      get => this.icmpv6errorField;
      private set => this.icmpv6errorField = value;
    }

    public long ipv6toticmprarx
    {
      get => this.ipv6toticmprarxField;
      private set => this.ipv6toticmprarxField = value;
    }

    public long ipv6tottxbytes
    {
      get => this.ipv6tottxbytesField;
      private set => this.ipv6tottxbytesField = value;
    }

    public long ipv6landattack
    {
      get => this.ipv6landattackField;
      private set => this.ipv6landattackField = value;
    }

    public long ipv6fragtotpktsforward
    {
      get => this.ipv6fragtotpktsforwardField;
      private set => this.ipv6fragtotpktsforwardField = value;
    }

    public long ipv6fragzerolenpkt
    {
      get => this.ipv6fragzerolenpktField;
      private set => this.ipv6fragzerolenpktField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      protocolipv6_stats[] protocolipv6StatsArray = new protocolipv6_stats[1];
      protocolipv6_stats.protocolipv6_response protocolipv6Response = new protocolipv6_stats.protocolipv6_response();
      protocolipv6_stats.protocolipv6_response resource = (protocolipv6_stats.protocolipv6_response) service.get_payload_formatter().string_to_resource(protocolipv6Response.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      protocolipv6StatsArray[0] = resource.protocolipv6;
      return (base_resource[]) protocolipv6StatsArray;
    }

    internal override string get_object_name() => (string) null;

    public static protocolipv6_stats get(nitro_service service) => ((protocolipv6_stats[]) new protocolipv6_stats().stat_resources(service, (options) null))[0];

    public static protocolipv6_stats get(nitro_service service, options option) => ((protocolipv6_stats[]) new protocolipv6_stats().stat_resources(service, option))[0];

    private class protocolipv6_response : base_response
    {
      public protocolipv6_stats protocolipv6 = (protocolipv6_stats) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
