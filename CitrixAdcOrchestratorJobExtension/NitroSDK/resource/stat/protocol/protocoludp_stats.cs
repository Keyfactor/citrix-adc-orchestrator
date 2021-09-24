// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.protocol.protocoludp_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.protocol
{
  public class protocoludp_stats : base_resource
  {
    private string clearstatsField = (string) null;
    private long udptotrxpktsField = 0;
    private long udprxpktsrateField = 0;
    private long udptotrxbytesField = 0;
    private long udprxbytesrateField = 0;
    private long udptottxpktsField = 0;
    private long udptxpktsrateField = 0;
    private long udptottxbytesField = 0;
    private long udptxbytesrateField = 0;
    private long udpcurratethresholdField = 0;
    private long udptotunknownsvcpktsField = 0;
    private long udpbadchecksumField = 0;
    private long udpcurratethresholdexceedsField = 0;

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long udptxpktsrate
    {
      get => this.udptxpktsrateField;
      private set => this.udptxpktsrateField = value;
    }

    public long udpcurratethreshold
    {
      get => this.udpcurratethresholdField;
      private set => this.udpcurratethresholdField = value;
    }

    public long udptotrxpkts
    {
      get => this.udptotrxpktsField;
      private set => this.udptotrxpktsField = value;
    }

    public long udptottxpkts
    {
      get => this.udptottxpktsField;
      private set => this.udptottxpktsField = value;
    }

    public long udptotrxbytes
    {
      get => this.udptotrxbytesField;
      private set => this.udptotrxbytesField = value;
    }

    public long udptxbytesrate
    {
      get => this.udptxbytesrateField;
      private set => this.udptxbytesrateField = value;
    }

    public long udprxpktsrate
    {
      get => this.udprxpktsrateField;
      private set => this.udprxpktsrateField = value;
    }

    public long udpbadchecksum
    {
      get => this.udpbadchecksumField;
      private set => this.udpbadchecksumField = value;
    }

    public long udptottxbytes
    {
      get => this.udptottxbytesField;
      private set => this.udptottxbytesField = value;
    }

    public long udptotunknownsvcpkts
    {
      get => this.udptotunknownsvcpktsField;
      private set => this.udptotunknownsvcpktsField = value;
    }

    public long udprxbytesrate
    {
      get => this.udprxbytesrateField;
      private set => this.udprxbytesrateField = value;
    }

    public long udpcurratethresholdexceeds
    {
      get => this.udpcurratethresholdexceedsField;
      private set => this.udpcurratethresholdexceedsField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      protocoludp_stats[] protocoludpStatsArray = new protocoludp_stats[1];
      protocoludp_stats.protocoludp_response protocoludpResponse = new protocoludp_stats.protocoludp_response();
      protocoludp_stats.protocoludp_response resource = (protocoludp_stats.protocoludp_response) service.get_payload_formatter().string_to_resource(protocoludpResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      protocoludpStatsArray[0] = resource.protocoludp;
      return (base_resource[]) protocoludpStatsArray;
    }

    internal override string get_object_name() => (string) null;

    public static protocoludp_stats get(nitro_service service) => ((protocoludp_stats[]) new protocoludp_stats().stat_resources(service, (options) null))[0];

    public static protocoludp_stats get(nitro_service service, options option) => ((protocoludp_stats[]) new protocoludp_stats().stat_resources(service, option))[0];

    private class protocoludp_response : base_response
    {
      public protocoludp_stats protocoludp = (protocoludp_stats) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
