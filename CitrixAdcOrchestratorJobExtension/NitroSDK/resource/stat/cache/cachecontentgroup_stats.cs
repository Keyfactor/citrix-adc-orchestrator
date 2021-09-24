// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.cache.cachecontentgroup_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.cache
{
  public class cachecontentgroup_stats : base_resource
  {
    private string nameField = (string) null;
    private string clearstatsField = (string) null;
    private long groupnon304hitField = 0;
    private long group304hitField = 0;
    private long totcellField = 0;
    private long totmarkercellField = 0;
    private long timesflushedField = 0;
    private long totmemoryField = 0;
    private long maxmemoryField = 0;

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

    public long group304hit
    {
      get => this.group304hitField;
      private set => this.group304hitField = value;
    }

    public long totmarkercell
    {
      get => this.totmarkercellField;
      private set => this.totmarkercellField = value;
    }

    public long timesflushed
    {
      get => this.timesflushedField;
      private set => this.timesflushedField = value;
    }

    public long totmemory
    {
      get => this.totmemoryField;
      private set => this.totmemoryField = value;
    }

    public long totcell
    {
      get => this.totcellField;
      private set => this.totcellField = value;
    }

    public long groupnon304hit
    {
      get => this.groupnon304hitField;
      private set => this.groupnon304hitField = value;
    }

    public long maxmemory
    {
      get => this.maxmemoryField;
      private set => this.maxmemoryField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      cachecontentgroup_stats.cachecontentgroup_response cachecontentgroupResponse = new cachecontentgroup_stats.cachecontentgroup_response();
      cachecontentgroup_stats.cachecontentgroup_response resource = (cachecontentgroup_stats.cachecontentgroup_response) service.get_payload_formatter().string_to_resource(cachecontentgroupResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.cachecontentgroup;
    }

    internal override string get_object_name() => this.name;

    public static cachecontentgroup_stats[] get(nitro_service service) => (cachecontentgroup_stats[]) new cachecontentgroup_stats().stat_resources(service, (options) null);

    public static cachecontentgroup_stats[] get(
      nitro_service service,
      options option)
    {
      return (cachecontentgroup_stats[]) new cachecontentgroup_stats().stat_resources(service, option);
    }

    public static cachecontentgroup_stats get(
      nitro_service service,
      string name)
    {
      return (cachecontentgroup_stats) new cachecontentgroup_stats()
      {
        name = name
      }.stat_resource(service);
    }

    private class cachecontentgroup_response : base_response
    {
      public cachecontentgroup_stats[] cachecontentgroup = (cachecontentgroup_stats[]) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
