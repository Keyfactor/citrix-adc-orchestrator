// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.protocol.protocolhttp_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.protocol
{
  public class protocolhttp_stats : base_resource
  {
    private string clearstatsField = (string) null;
    private long spdytotstreamsField = 0;
    private long spdystreamsrateField = 0;
    private long httptotrequestsField = 0;
    private long httprequestsrateField = 0;
    private long httptotresponsesField = 0;
    private long httpresponsesrateField = 0;
    private long httptotrxrequestbytesField = 0;
    private long httprxrequestbytesrateField = 0;
    private long httptotrxresponsebytesField = 0;
    private long httprxresponsebytesrateField = 0;
    private long httptotgetsField = 0;
    private long httpgetsrateField = 0;
    private long httptotpostsField = 0;
    private long httppostsrateField = 0;
    private long httptotothersField = 0;
    private long httptohersrateField = 0;
    private long httptot10requestsField = 0;
    private long http10requestsrateField = 0;
    private long httptot11requestsField = 0;
    private long http11requestsrateField = 0;
    private long httptotclenrequestsField = 0;
    private long httpclenrequestsrateField = 0;
    private long httptotchunkedrequestsField = 0;
    private long httpchunkedrequestsrateField = 0;
    private long httptottxrequestbytesField = 0;
    private long httptxrequestbytesrateField = 0;
    private long httptot10responsesField = 0;
    private long http10responsesrateField = 0;
    private long httptot11responsesField = 0;
    private long http11responsesrateField = 0;
    private long httptotclenresponsesField = 0;
    private long httpclenresponsesrateField = 0;
    private long httptotchunkedresponsesField = 0;
    private long httpchunkedresponsesrateField = 0;
    private long httperrnoreusemultipartField = 0;
    private long httperrnoreusemultipartrateField = 0;
    private long httptotnoclenchunkresponsesField = 0;
    private long httpnoclenchunkresponsesrateField = 0;
    private long httptottxresponsebytesField = 0;
    private long httptxresponsebytesrateField = 0;
    private long httperrincompleteheadersField = 0;
    private long httperrincompleterequestsField = 0;
    private long httperrincompleterequestsrateField = 0;
    private long httperrincompleteresponsesField = 0;
    private long httperrincompleteresponsesrateField = 0;
    private long httperrserverbusyField = 0;
    private long httperrserverbusyrateField = 0;
    private long httperrlargecontentField = 0;
    private long httperrlargechunkField = 0;
    private long httperrlargectlenField = 0;
    private long spdyv2totstreamsField = 0;
    private long spdyv2streamsrateField = 0;
    private long spdyv3totstreamsField = 0;
    private long spdyv3streamsrateField = 0;

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long httptotclenresponses
    {
      get => this.httptotclenresponsesField;
      private set => this.httptotclenresponsesField = value;
    }

    public long httperrnoreusemultipart
    {
      get => this.httperrnoreusemultipartField;
      private set => this.httperrnoreusemultipartField = value;
    }

    public long spdyv3streamsrate
    {
      get => this.spdyv3streamsrateField;
      private set => this.spdyv3streamsrateField = value;
    }

    public long httprxrequestbytesrate
    {
      get => this.httprxrequestbytesrateField;
      private set => this.httprxrequestbytesrateField = value;
    }

    public long httptotrxresponsebytes
    {
      get => this.httptotrxresponsebytesField;
      private set => this.httptotrxresponsebytesField = value;
    }

    public long httptotchunkedresponses
    {
      get => this.httptotchunkedresponsesField;
      private set => this.httptotchunkedresponsesField = value;
    }

    public long httperrincompleterequests
    {
      get => this.httperrincompleterequestsField;
      private set => this.httperrincompleterequestsField = value;
    }

    public long httptot10requests
    {
      get => this.httptot10requestsField;
      private set => this.httptot10requestsField = value;
    }

    public long httptotgets
    {
      get => this.httptotgetsField;
      private set => this.httptotgetsField = value;
    }

    public long httperrlargecontent
    {
      get => this.httperrlargecontentField;
      private set => this.httperrlargecontentField = value;
    }

    public long http10responsesrate
    {
      get => this.http10responsesrateField;
      private set => this.http10responsesrateField = value;
    }

    public long httperrserverbusy
    {
      get => this.httperrserverbusyField;
      private set => this.httperrserverbusyField = value;
    }

    public long httptxrequestbytesrate
    {
      get => this.httptxrequestbytesrateField;
      private set => this.httptxrequestbytesrateField = value;
    }

    public long httptotposts
    {
      get => this.httptotpostsField;
      private set => this.httptotpostsField = value;
    }

    public long httptotclenrequests
    {
      get => this.httptotclenrequestsField;
      private set => this.httptotclenrequestsField = value;
    }

    public long httprxresponsebytesrate
    {
      get => this.httprxresponsebytesrateField;
      private set => this.httprxresponsebytesrateField = value;
    }

    public long spdyv2streamsrate
    {
      get => this.spdyv2streamsrateField;
      private set => this.spdyv2streamsrateField = value;
    }

    public long httperrincompleteresponsesrate
    {
      get => this.httperrincompleteresponsesrateField;
      private set => this.httperrincompleteresponsesrateField = value;
    }

    public long httpnoclenchunkresponsesrate
    {
      get => this.httpnoclenchunkresponsesrateField;
      private set => this.httpnoclenchunkresponsesrateField = value;
    }

    public long httpchunkedrequestsrate
    {
      get => this.httpchunkedrequestsrateField;
      private set => this.httpchunkedrequestsrateField = value;
    }

    public long http11responsesrate
    {
      get => this.http11responsesrateField;
      private set => this.http11responsesrateField = value;
    }

    public long httptotrequests
    {
      get => this.httptotrequestsField;
      private set => this.httptotrequestsField = value;
    }

    public long httptotresponses
    {
      get => this.httptotresponsesField;
      private set => this.httptotresponsesField = value;
    }

    public long httperrincompleteresponses
    {
      get => this.httperrincompleteresponsesField;
      private set => this.httperrincompleteresponsesField = value;
    }

    public long spdytotstreams
    {
      get => this.spdytotstreamsField;
      private set => this.spdytotstreamsField = value;
    }

    public long httptottxrequestbytes
    {
      get => this.httptottxrequestbytesField;
      private set => this.httptottxrequestbytesField = value;
    }

    public long httperrserverbusyrate
    {
      get => this.httperrserverbusyrateField;
      private set => this.httperrserverbusyrateField = value;
    }

    public long http11requestsrate
    {
      get => this.http11requestsrateField;
      private set => this.http11requestsrateField = value;
    }

    public long spdystreamsrate
    {
      get => this.spdystreamsrateField;
      private set => this.spdystreamsrateField = value;
    }

    public long httptxresponsebytesrate
    {
      get => this.httptxresponsebytesrateField;
      private set => this.httptxresponsebytesrateField = value;
    }

    public long httptohersrate
    {
      get => this.httptohersrateField;
      private set => this.httptohersrateField = value;
    }

    public long httpchunkedresponsesrate
    {
      get => this.httpchunkedresponsesrateField;
      private set => this.httpchunkedresponsesrateField = value;
    }

    public long httptot11responses
    {
      get => this.httptot11responsesField;
      private set => this.httptot11responsesField = value;
    }

    public long http10requestsrate
    {
      get => this.http10requestsrateField;
      private set => this.http10requestsrateField = value;
    }

    public long httprequestsrate
    {
      get => this.httprequestsrateField;
      private set => this.httprequestsrateField = value;
    }

    public long httpresponsesrate
    {
      get => this.httpresponsesrateField;
      private set => this.httpresponsesrateField = value;
    }

    public long httptot10responses
    {
      get => this.httptot10responsesField;
      private set => this.httptot10responsesField = value;
    }

    public long httptotnoclenchunkresponses
    {
      get => this.httptotnoclenchunkresponsesField;
      private set => this.httptotnoclenchunkresponsesField = value;
    }

    public long httperrlargechunk
    {
      get => this.httperrlargechunkField;
      private set => this.httperrlargechunkField = value;
    }

    public long httperrnoreusemultipartrate
    {
      get => this.httperrnoreusemultipartrateField;
      private set => this.httperrnoreusemultipartrateField = value;
    }

    public long spdyv3totstreams
    {
      get => this.spdyv3totstreamsField;
      private set => this.spdyv3totstreamsField = value;
    }

    public long httperrincompleteheaders
    {
      get => this.httperrincompleteheadersField;
      private set => this.httperrincompleteheadersField = value;
    }

    public long httptot11requests
    {
      get => this.httptot11requestsField;
      private set => this.httptot11requestsField = value;
    }

    public long httppostsrate
    {
      get => this.httppostsrateField;
      private set => this.httppostsrateField = value;
    }

    public long httpgetsrate
    {
      get => this.httpgetsrateField;
      private set => this.httpgetsrateField = value;
    }

    public long httpclenresponsesrate
    {
      get => this.httpclenresponsesrateField;
      private set => this.httpclenresponsesrateField = value;
    }

    public long httperrlargectlen
    {
      get => this.httperrlargectlenField;
      private set => this.httperrlargectlenField = value;
    }

    public long httptottxresponsebytes
    {
      get => this.httptottxresponsebytesField;
      private set => this.httptottxresponsebytesField = value;
    }

    public long spdyv2totstreams
    {
      get => this.spdyv2totstreamsField;
      private set => this.spdyv2totstreamsField = value;
    }

    public long httptotchunkedrequests
    {
      get => this.httptotchunkedrequestsField;
      private set => this.httptotchunkedrequestsField = value;
    }

    public long httperrincompleterequestsrate
    {
      get => this.httperrincompleterequestsrateField;
      private set => this.httperrincompleterequestsrateField = value;
    }

    public long httpclenrequestsrate
    {
      get => this.httpclenrequestsrateField;
      private set => this.httpclenrequestsrateField = value;
    }

    public long httptotrxrequestbytes
    {
      get => this.httptotrxrequestbytesField;
      private set => this.httptotrxrequestbytesField = value;
    }

    public long httptotothers
    {
      get => this.httptotothersField;
      private set => this.httptotothersField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      protocolhttp_stats[] protocolhttpStatsArray = new protocolhttp_stats[1];
      protocolhttp_stats.protocolhttp_response protocolhttpResponse = new protocolhttp_stats.protocolhttp_response();
      protocolhttp_stats.protocolhttp_response resource = (protocolhttp_stats.protocolhttp_response) service.get_payload_formatter().string_to_resource(protocolhttpResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      protocolhttpStatsArray[0] = resource.protocolhttp;
      return (base_resource[]) protocolhttpStatsArray;
    }

    internal override string get_object_name() => (string) null;

    public static protocolhttp_stats get(nitro_service service) => ((protocolhttp_stats[]) new protocolhttp_stats().stat_resources(service, (options) null))[0];

    public static protocolhttp_stats get(nitro_service service, options option) => ((protocolhttp_stats[]) new protocolhttp_stats().stat_resources(service, option))[0];

    private class protocolhttp_response : base_response
    {
      public protocolhttp_stats protocolhttp = (protocolhttp_stats) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
