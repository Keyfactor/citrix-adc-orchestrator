// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.appflow.appflow_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.appflow
{
  public class appflow_stats : base_resource
  {
    private string clearstatsField = (string) null;
    private long appflowtotaltxoctetsField = 0;
    private long appflowtxoctetsrateField = 0;
    private long appflowtotalflowsField = 0;
    private long appflowflowsrateField = 0;
    private long appflowtotaltxmessagessField = 0;
    private long appflowtxmessagessrateField = 0;
    private long appflowtotalignoctetsField = 0;
    private long appflowignoctetsrateField = 0;
    private long appflowtotalignpacketssField = 0;
    private long appflowignpacketssrateField = 0;
    private long appflowtotalnotxoctetsField = 0;
    private long appflownotxoctetsrateField = 0;
    private long appflowtotalnotxflowsField = 0;
    private long appflownotxflowsrateField = 0;
    private long appflowtotalnotxpacketsField = 0;
    private long appflownotxpacketsrateField = 0;

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long appflowtxmessagessrate
    {
      get => this.appflowtxmessagessrateField;
      private set => this.appflowtxmessagessrateField = value;
    }

    public long appflowtotalnotxoctets
    {
      get => this.appflowtotalnotxoctetsField;
      private set => this.appflowtotalnotxoctetsField = value;
    }

    public long appflowtotaltxmessagess
    {
      get => this.appflowtotaltxmessagessField;
      private set => this.appflowtotaltxmessagessField = value;
    }

    public long appflowtotalignpacketss
    {
      get => this.appflowtotalignpacketssField;
      private set => this.appflowtotalignpacketssField = value;
    }

    public long appflowtotalflows
    {
      get => this.appflowtotalflowsField;
      private set => this.appflowtotalflowsField = value;
    }

    public long appflowtotalnotxflows
    {
      get => this.appflowtotalnotxflowsField;
      private set => this.appflowtotalnotxflowsField = value;
    }

    public long appflownotxflowsrate
    {
      get => this.appflownotxflowsrateField;
      private set => this.appflownotxflowsrateField = value;
    }

    public long appflowtotalnotxpackets
    {
      get => this.appflowtotalnotxpacketsField;
      private set => this.appflowtotalnotxpacketsField = value;
    }

    public long appflownotxoctetsrate
    {
      get => this.appflownotxoctetsrateField;
      private set => this.appflownotxoctetsrateField = value;
    }

    public long appflowignpacketssrate
    {
      get => this.appflowignpacketssrateField;
      private set => this.appflowignpacketssrateField = value;
    }

    public long appflowtxoctetsrate
    {
      get => this.appflowtxoctetsrateField;
      private set => this.appflowtxoctetsrateField = value;
    }

    public long appflowignoctetsrate
    {
      get => this.appflowignoctetsrateField;
      private set => this.appflowignoctetsrateField = value;
    }

    public long appflowtotalignoctets
    {
      get => this.appflowtotalignoctetsField;
      private set => this.appflowtotalignoctetsField = value;
    }

    public long appflowtotaltxoctets
    {
      get => this.appflowtotaltxoctetsField;
      private set => this.appflowtotaltxoctetsField = value;
    }

    public long appflownotxpacketsrate
    {
      get => this.appflownotxpacketsrateField;
      private set => this.appflownotxpacketsrateField = value;
    }

    public long appflowflowsrate
    {
      get => this.appflowflowsrateField;
      private set => this.appflowflowsrateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      appflow_stats[] appflowStatsArray = new appflow_stats[1];
      appflow_stats.appflow_response appflowResponse = new appflow_stats.appflow_response();
      appflow_stats.appflow_response resource = (appflow_stats.appflow_response) service.get_payload_formatter().string_to_resource(appflowResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      appflowStatsArray[0] = resource.appflow;
      return (base_resource[]) appflowStatsArray;
    }

    internal override string get_object_name() => (string) null;

    public static appflow_stats get(nitro_service service) => ((appflow_stats[]) new appflow_stats().stat_resources(service, (options) null))[0];

    public static appflow_stats get(nitro_service service, options option) => ((appflow_stats[]) new appflow_stats().stat_resources(service, option))[0];

    private class appflow_response : base_response
    {
      public appflow_stats appflow = (appflow_stats) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
