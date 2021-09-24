// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.ssl.sslvserver_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.ssl
{
  public class sslvserver_stats : base_resource
  {
    private string vservernameField = (string) null;
    private string clearstatsField = (string) null;
    private long vslbhealthField = 0;
    private string primaryipaddressField = (string) null;
    private ushort primaryportField = 0;
    private string typeField = (string) null;
    private string stateField = (string) null;
    private long actsvcsField = 0;
    private long ssltotclientauthsuccessField = 0;
    private long ssltotclientauthfailureField = 0;

    public string vservername
    {
      get => this.vservernameField;
      set => this.vservernameField = value;
    }

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public string state
    {
      get => this.stateField;
      private set => this.stateField = value;
    }

    public long vslbhealth
    {
      get => this.vslbhealthField;
      private set => this.vslbhealthField = value;
    }

    public long actsvcs
    {
      get => this.actsvcsField;
      private set => this.actsvcsField = value;
    }

    public string primaryipaddress
    {
      get => this.primaryipaddressField;
      private set => this.primaryipaddressField = value;
    }

    public string type
    {
      get => this.typeField;
      private set => this.typeField = value;
    }

    public ushort primaryport
    {
      get => this.primaryportField;
      private set => this.primaryportField = value;
    }

    public long ssltotclientauthfailure
    {
      get => this.ssltotclientauthfailureField;
      private set => this.ssltotclientauthfailureField = value;
    }

    public long ssltotclientauthsuccess
    {
      get => this.ssltotclientauthsuccessField;
      private set => this.ssltotclientauthsuccessField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslvserver_stats.sslvserver_response sslvserverResponse = new sslvserver_stats.sslvserver_response();
      sslvserver_stats.sslvserver_response resource = (sslvserver_stats.sslvserver_response) service.get_payload_formatter().string_to_resource(sslvserverResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslvserver;
    }

    internal override string get_object_name() => this.vservername;

    public static sslvserver_stats[] get(nitro_service service) => (sslvserver_stats[]) new sslvserver_stats().stat_resources(service, (options) null);

    public static sslvserver_stats[] get(nitro_service service, options option) => (sslvserver_stats[]) new sslvserver_stats().stat_resources(service, option);

    public static sslvserver_stats get(nitro_service service, string vservername) => (sslvserver_stats) new sslvserver_stats()
    {
      vservername = vservername
    }.stat_resource(service);

    private class sslvserver_response : base_response
    {
      public sslvserver_stats[] sslvserver = (sslvserver_stats[]) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
