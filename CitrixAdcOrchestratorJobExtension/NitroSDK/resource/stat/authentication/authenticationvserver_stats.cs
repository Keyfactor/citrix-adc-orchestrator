// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.authentication.authenticationvserver_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.authentication
{
  public class authenticationvserver_stats : base_resource
  {
    private string nameField = (string) null;
    private string clearstatsField = (string) null;
    private string primaryipaddressField = (string) null;
    private ushort primaryportField = 0;
    private string typeField = (string) null;
    private string stateField = (string) null;
    private long totalrequestsField = 0;
    private long requestsrateField = 0;
    private long totalresponsesField = 0;
    private long responsesrateField = 0;
    private long totalrequestbytesField = 0;
    private long requestbytesrateField = 0;
    private long totalresponsebytesField = 0;
    private long responsebytesrateField = 0;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long totalrequests
    {
      get => this.totalrequestsField;
      private set => this.totalrequestsField = value;
    }

    public long responsebytesrate
    {
      get => this.responsebytesrateField;
      private set => this.responsebytesrateField = value;
    }

    public long requestbytesrate
    {
      get => this.requestbytesrateField;
      private set => this.requestbytesrateField = value;
    }

    public string type
    {
      get => this.typeField;
      private set => this.typeField = value;
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

    public long totalrequestbytes
    {
      get => this.totalrequestbytesField;
      private set => this.totalrequestbytesField = value;
    }

    public string state
    {
      get => this.stateField;
      private set => this.stateField = value;
    }

    public long totalresponses
    {
      get => this.totalresponsesField;
      private set => this.totalresponsesField = value;
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
      authenticationvserver_stats.authenticationvserver_response authenticationvserverResponse = new authenticationvserver_stats.authenticationvserver_response();
      authenticationvserver_stats.authenticationvserver_response resource = (authenticationvserver_stats.authenticationvserver_response) service.get_payload_formatter().string_to_resource(authenticationvserverResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.authenticationvserver;
    }

    internal override string get_object_name() => this.name;

    public static authenticationvserver_stats[] get(nitro_service service) => (authenticationvserver_stats[]) new authenticationvserver_stats().stat_resources(service, (options) null);

    public static authenticationvserver_stats[] get(
      nitro_service service,
      options option)
    {
      return (authenticationvserver_stats[]) new authenticationvserver_stats().stat_resources(service, option);
    }

    public static authenticationvserver_stats get(
      nitro_service service,
      string name)
    {
      return (authenticationvserver_stats) new authenticationvserver_stats()
      {
        name = name
      }.stat_resource(service);
    }

    private class authenticationvserver_response : base_response
    {
      public authenticationvserver_stats[] authenticationvserver = (authenticationvserver_stats[]) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
