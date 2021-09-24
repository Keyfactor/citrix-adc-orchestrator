// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.stream.streamidentifier_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.stat.stream
{
  public class streamidentifier_stats : base_resource
  {
    private string nameField = (string) null;
    private string[] patternField = (string[]) null;
    private string clearstatsField = (string) null;
    private string sortbyField = (string) null;
    private string sortorderField = (string) null;
    private long streamobjreqField = 0;
    private long streamobjbandwField = 0;
    private long streamobjresptimeField = 0;
    private long streamobjconnField = 0;
    private long streamobjbreachcntField = 0;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string[] pattern
    {
      get => this.patternField;
      set => this.patternField = value;
    }

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public string sortby
    {
      get => this.sortbyField;
      set => this.sortbyField = value;
    }

    public string sortorder
    {
      get => this.sortorderField;
      set => this.sortorderField = value;
    }

    public long streamobjconn
    {
      get => this.streamobjconnField;
      private set => this.streamobjconnField = value;
    }

    public long streamobjbreachcnt
    {
      get => this.streamobjbreachcntField;
      private set => this.streamobjbreachcntField = value;
    }

    public long streamobjbandw
    {
      get => this.streamobjbandwField;
      private set => this.streamobjbandwField = value;
    }

    public long streamobjresptime
    {
      get => this.streamobjresptimeField;
      private set => this.streamobjresptimeField = value;
    }

    public long streamobjreq
    {
      get => this.streamobjreqField;
      private set => this.streamobjreqField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      streamidentifier_stats.streamidentifier_response streamidentifierResponse = new streamidentifier_stats.streamidentifier_response();
      streamidentifier_stats.streamidentifier_response resource = (streamidentifier_stats.streamidentifier_response) service.get_payload_formatter().string_to_resource(streamidentifierResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.streamidentifier;
    }

    internal override string get_object_name() => this.name;

    public static streamidentifier_stats get(
      nitro_service service,
      string name)
    {
      return (streamidentifier_stats) new streamidentifier_stats()
      {
        name = name
      }.stat_resource(service);
    }

    public static streamidentifier_stats get(
      nitro_service service,
      streamidentifier_stats obj)
    {
      options option = new options();
      option.set_args(nitro_util.statobject_to_string_withoutquotes((object) obj));
      return (streamidentifier_stats) obj.stat_resource(service, option);
    }

    private class streamidentifier_response : base_response
    {
      public streamidentifier_stats[] streamidentifier = (streamidentifier_stats[]) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }

    public static class sortorderEnum
    {
      public const string ascending = "ascending";
      public const string descending = "descending";
    }
  }
}
