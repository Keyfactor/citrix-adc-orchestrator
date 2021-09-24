// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.basic.servicegroupmember_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.stat.basic
{
  public class servicegroupmember_stats : base_resource
  {
    private string servicegroupnameField = (string) null;
    private string ipField = (string) null;
    private string servernameField = (string) null;
    private ushort portField = 0;
    private string clearstatsField = (string) null;
    private long avgsvrttfbField = 0;
    private string primaryipaddressField = (string) null;
    private ushort primaryportField = 0;
    private string servicetypeField = (string) null;
    private string stateField = (string) null;
    private long totalrequestsField = 0;
    private long requestsrateField = 0;
    private long totalresponsesField = 0;
    private long responsesrateField = 0;
    private long totalrequestbytesField = 0;
    private long requestbytesrateField = 0;
    private long totalresponsebytesField = 0;
    private long responsebytesrateField = 0;
    private long curclntconnectionsField = 0;
    private long surgecountField = 0;
    private long cursrvrconnectionsField = 0;
    private long svrestablishedconnField = 0;
    private long curreusepoolField = 0;
    private long maxclientsField = 0;

    public string servicegroupname
    {
      get => this.servicegroupnameField;
      set => this.servicegroupnameField = value;
    }

    public string ip
    {
      get => this.ipField;
      set => this.ipField = value;
    }

    public string servername
    {
      get => this.servernameField;
      set => this.servernameField = value;
    }

    public ushort port
    {
      get => this.portField;
      set => this.portField = value;
    }

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long svrestablishedconn
    {
      get => this.svrestablishedconnField;
      private set => this.svrestablishedconnField = value;
    }

    public long curclntconnections
    {
      get => this.curclntconnectionsField;
      private set => this.curclntconnectionsField = value;
    }

    public string servicetype
    {
      get => this.servicetypeField;
      private set => this.servicetypeField = value;
    }

    public long totalrequests
    {
      get => this.totalrequestsField;
      private set => this.totalrequestsField = value;
    }

    public long surgecount
    {
      get => this.surgecountField;
      private set => this.surgecountField = value;
    }

    public long responsebytesrate
    {
      get => this.responsebytesrateField;
      private set => this.responsebytesrateField = value;
    }

    public long totalresponses
    {
      get => this.totalresponsesField;
      private set => this.totalresponsesField = value;
    }

    public long requestbytesrate
    {
      get => this.requestbytesrateField;
      private set => this.requestbytesrateField = value;
    }

    public long cursrvrconnections
    {
      get => this.cursrvrconnectionsField;
      private set => this.cursrvrconnectionsField = value;
    }

    public string primaryipaddress
    {
      get => this.primaryipaddressField;
      private set => this.primaryipaddressField = value;
    }

    public long responsesrate
    {
      get => this.responsesrateField;
      private set => this.responsesrateField = value;
    }

    public long maxclients
    {
      get => this.maxclientsField;
      private set => this.maxclientsField = value;
    }

    public long avgsvrttfb
    {
      get => this.avgsvrttfbField;
      private set => this.avgsvrttfbField = value;
    }

    public long totalrequestbytes
    {
      get => this.totalrequestbytesField;
      private set => this.totalrequestbytesField = value;
    }

    public long curreusepool
    {
      get => this.curreusepoolField;
      private set => this.curreusepoolField = value;
    }

    public string state
    {
      get => this.stateField;
      private set => this.stateField = value;
    }

    public long totalresponsebytes
    {
      get => this.totalresponsebytesField;
      private set => this.totalresponsebytesField = value;
    }

    public ushort primaryport
    {
      get => this.primaryportField;
      private set => this.primaryportField = value;
    }

    public long requestsrate
    {
      get => this.requestsrateField;
      private set => this.requestsrateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      servicegroupmember_stats.servicegroupmember_response servicegroupmemberResponse = new servicegroupmember_stats.servicegroupmember_response();
      servicegroupmember_stats.servicegroupmember_response resource = (servicegroupmember_stats.servicegroupmember_response) service.get_payload_formatter().string_to_resource(servicegroupmemberResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.servicegroupmember;
    }

    internal override string get_object_name() => this.servicegroupname;

    public static servicegroupmember_stats get(
      nitro_service service,
      servicegroupmember_stats obj)
    {
      options option = new options();
      option.set_args(nitro_util.statobject_to_string_withoutquotes((object) obj));
      return (servicegroupmember_stats) obj.stat_resource(service, option);
    }

    private class servicegroupmember_response : base_response
    {
      public servicegroupmember_stats[] servicegroupmember = (servicegroupmember_stats[]) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
