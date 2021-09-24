// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.network.Interface_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.network
{
  public class Interface_stats : base_resource
  {
    private string idField = (string) null;
    private string clearstatsField = (string) null;
    private string curintfstateField = (string) null;
    private string curlinkuptimeField = (string) null;
    private string curlinkdowntimeField = (string) null;
    private long totrxbytesField = 0;
    private long rxbytesrateField = 0;
    private long tottxbytesField = 0;
    private long txbytesrateField = 0;
    private long totrxpktsField = 0;
    private long rxpktsrateField = 0;
    private long tottxpktsField = 0;
    private long txpktsrateField = 0;
    private long jumbopktsreceivedField = 0;
    private long jumbopktsreceivedrateField = 0;
    private long jumbopktstransmittedField = 0;
    private long jumbopktstransmittedrateField = 0;
    private long nictotmulticastpktsField = 0;
    private long nicmulticastpktsrateField = 0;
    private long totnetscalerpktsField = 0;
    private long netscalerpktsrateField = 0;
    private long rxlacpduField = 0;
    private long rxlacpdurateField = 0;
    private long txlacpduField = 0;
    private long txlacpdurateField = 0;
    private long errpktrxField = 0;
    private long errpktrxrateField = 0;
    private long errpkttxField = 0;
    private long errpkttxrateField = 0;
    private long errifindiscardsField = 0;
    private long errifindiscardsrateField = 0;
    private long nicerrifoutdiscardsField = 0;
    private long nicerrifoutdiscardsrateField = 0;
    private long errdroppedrxpktsField = 0;
    private long errdroppedrxpktsrateField = 0;
    private long errdroppedtxpktsField = 0;
    private long errdroppedtxpktsrateField = 0;
    private long errlinkhangsField = 0;
    private long nicstsstallsField = 0;
    private long nictxstallsField = 0;
    private long nicrxstallsField = 0;
    private long nicerrdisablesField = 0;
    private long errduplexmismatchField = 0;
    private long linkreinitsField = 0;
    private long totmacmovedField = 0;
    private long macmovedrateField = 0;
    private long errnicmutedField = 0;
    private string interfacealiasField = (string) null;
    private string curlinkstateField = (string) null;

    public string id
    {
      get => this.idField;
      set => this.idField = value;
    }

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long errpkttx
    {
      get => this.errpkttxField;
      private set => this.errpkttxField = value;
    }

    public long nicrxstalls
    {
      get => this.nicrxstallsField;
      private set => this.nicrxstallsField = value;
    }

    public long nictotmulticastpkts
    {
      get => this.nictotmulticastpktsField;
      private set => this.nictotmulticastpktsField = value;
    }

    public long jumbopktstransmitted
    {
      get => this.jumbopktstransmittedField;
      private set => this.jumbopktstransmittedField = value;
    }

    public long txbytesrate
    {
      get => this.txbytesrateField;
      private set => this.txbytesrateField = value;
    }

    public long rxlacpdu
    {
      get => this.rxlacpduField;
      private set => this.rxlacpduField = value;
    }

    public long netscalerpktsrate
    {
      get => this.netscalerpktsrateField;
      private set => this.netscalerpktsrateField = value;
    }

    public long tottxpkts
    {
      get => this.tottxpktsField;
      private set => this.tottxpktsField = value;
    }

    public long macmovedrate
    {
      get => this.macmovedrateField;
      private set => this.macmovedrateField = value;
    }

    public string curintfstate
    {
      get => this.curintfstateField;
      private set => this.curintfstateField = value;
    }

    public long errpktrx
    {
      get => this.errpktrxField;
      private set => this.errpktrxField = value;
    }

    public string curlinkdowntime
    {
      get => this.curlinkdowntimeField;
      private set => this.curlinkdowntimeField = value;
    }

    public long nicmulticastpktsrate
    {
      get => this.nicmulticastpktsrateField;
      private set => this.nicmulticastpktsrateField = value;
    }

    public long rxbytesrate
    {
      get => this.rxbytesrateField;
      private set => this.rxbytesrateField = value;
    }

    public string curlinkuptime
    {
      get => this.curlinkuptimeField;
      private set => this.curlinkuptimeField = value;
    }

    public long tottxbytes
    {
      get => this.tottxbytesField;
      private set => this.tottxbytesField = value;
    }

    public long errdroppedtxpktsrate
    {
      get => this.errdroppedtxpktsrateField;
      private set => this.errdroppedtxpktsrateField = value;
    }

    public long errpkttxrate
    {
      get => this.errpkttxrateField;
      private set => this.errpkttxrateField = value;
    }

    public long nictxstalls
    {
      get => this.nictxstallsField;
      private set => this.nictxstallsField = value;
    }

    public long rxlacpdurate
    {
      get => this.rxlacpdurateField;
      private set => this.rxlacpdurateField = value;
    }

    public long totnetscalerpkts
    {
      get => this.totnetscalerpktsField;
      private set => this.totnetscalerpktsField = value;
    }

    public long jumbopktsreceivedrate
    {
      get => this.jumbopktsreceivedrateField;
      private set => this.jumbopktsreceivedrateField = value;
    }

    public long totrxbytes
    {
      get => this.totrxbytesField;
      private set => this.totrxbytesField = value;
    }

    public long linkreinits
    {
      get => this.linkreinitsField;
      private set => this.linkreinitsField = value;
    }

    public long nicerrdisables
    {
      get => this.nicerrdisablesField;
      private set => this.nicerrdisablesField = value;
    }

    public long txpktsrate
    {
      get => this.txpktsrateField;
      private set => this.txpktsrateField = value;
    }

    public long jumbopktsreceived
    {
      get => this.jumbopktsreceivedField;
      private set => this.jumbopktsreceivedField = value;
    }

    public long txlacpdu
    {
      get => this.txlacpduField;
      private set => this.txlacpduField = value;
    }

    public long errdroppedrxpktsrate
    {
      get => this.errdroppedrxpktsrateField;
      private set => this.errdroppedrxpktsrateField = value;
    }

    public long errnicmuted
    {
      get => this.errnicmutedField;
      private set => this.errnicmutedField = value;
    }

    public long errdroppedtxpkts
    {
      get => this.errdroppedtxpktsField;
      private set => this.errdroppedtxpktsField = value;
    }

    public long nicerrifoutdiscardsrate
    {
      get => this.nicerrifoutdiscardsrateField;
      private set => this.nicerrifoutdiscardsrateField = value;
    }

    public long errifindiscardsrate
    {
      get => this.errifindiscardsrateField;
      private set => this.errifindiscardsrateField = value;
    }

    public long nicerrifoutdiscards
    {
      get => this.nicerrifoutdiscardsField;
      private set => this.nicerrifoutdiscardsField = value;
    }

    public string curlinkstate
    {
      get => this.curlinkstateField;
      private set => this.curlinkstateField = value;
    }

    public long errifindiscards
    {
      get => this.errifindiscardsField;
      private set => this.errifindiscardsField = value;
    }

    public string interfacealias
    {
      get => this.interfacealiasField;
      private set => this.interfacealiasField = value;
    }

    public long totrxpkts
    {
      get => this.totrxpktsField;
      private set => this.totrxpktsField = value;
    }

    public long totmacmoved
    {
      get => this.totmacmovedField;
      private set => this.totmacmovedField = value;
    }

    public long rxpktsrate
    {
      get => this.rxpktsrateField;
      private set => this.rxpktsrateField = value;
    }

    public long errduplexmismatch
    {
      get => this.errduplexmismatchField;
      private set => this.errduplexmismatchField = value;
    }

    public long jumbopktstransmittedrate
    {
      get => this.jumbopktstransmittedrateField;
      private set => this.jumbopktstransmittedrateField = value;
    }

    public long errpktrxrate
    {
      get => this.errpktrxrateField;
      private set => this.errpktrxrateField = value;
    }

    public long errlinkhangs
    {
      get => this.errlinkhangsField;
      private set => this.errlinkhangsField = value;
    }

    public long errdroppedrxpkts
    {
      get => this.errdroppedrxpktsField;
      private set => this.errdroppedrxpktsField = value;
    }

    public long txlacpdurate
    {
      get => this.txlacpdurateField;
      private set => this.txlacpdurateField = value;
    }

    public long nicstsstalls
    {
      get => this.nicstsstallsField;
      private set => this.nicstsstallsField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      Interface_stats.Interface_response interfaceResponse = new Interface_stats.Interface_response();
      Interface_stats.Interface_response resource = (Interface_stats.Interface_response) service.get_payload_formatter().string_to_resource(interfaceResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.Interface;
    }

    internal override string get_object_name() => this.id;

    public static Interface_stats[] get(nitro_service service) => (Interface_stats[]) new Interface_stats().stat_resources(service, (options) null);

    public static Interface_stats[] get(nitro_service service, options option) => (Interface_stats[]) new Interface_stats().stat_resources(service, option);

    public static Interface_stats get(nitro_service service, string id) => (Interface_stats) new Interface_stats()
    {
      id = id
    }.stat_resource(service);

    private class Interface_response : base_response
    {
      public Interface_stats[] Interface = (Interface_stats[]) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
