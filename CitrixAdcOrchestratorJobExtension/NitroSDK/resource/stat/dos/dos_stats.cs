// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.dos.dos_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.dos
{
  public class dos_stats : base_resource
  {
    private string clearstatsField = (string) null;
    private long dostotconditiontriggeredField = 0;
    private long dosconditiontriggeredrateField = 0;
    private long dostotvalidcookiesField = 0;
    private long dosvalidcookiesrateField = 0;
    private long dostotdospriorityclientsField = 0;
    private long dosdospriorityclientsrateField = 0;

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long dostotvalidcookies
    {
      get => this.dostotvalidcookiesField;
      private set => this.dostotvalidcookiesField = value;
    }

    public long dosvalidcookiesrate
    {
      get => this.dosvalidcookiesrateField;
      private set => this.dosvalidcookiesrateField = value;
    }

    public long dosdospriorityclientsrate
    {
      get => this.dosdospriorityclientsrateField;
      private set => this.dosdospriorityclientsrateField = value;
    }

    public long dosconditiontriggeredrate
    {
      get => this.dosconditiontriggeredrateField;
      private set => this.dosconditiontriggeredrateField = value;
    }

    public long dostotconditiontriggered
    {
      get => this.dostotconditiontriggeredField;
      private set => this.dostotconditiontriggeredField = value;
    }

    public long dostotdospriorityclients
    {
      get => this.dostotdospriorityclientsField;
      private set => this.dostotdospriorityclientsField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      dos_stats[] dosStatsArray = new dos_stats[1];
      dos_stats.dos_response dosResponse = new dos_stats.dos_response();
      dos_stats.dos_response resource = (dos_stats.dos_response) service.get_payload_formatter().string_to_resource(dosResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      dosStatsArray[0] = resource.dos;
      return (base_resource[]) dosStatsArray;
    }

    internal override string get_object_name() => (string) null;

    public static dos_stats get(nitro_service service) => ((dos_stats[]) new dos_stats().stat_resources(service, (options) null))[0];

    public static dos_stats get(nitro_service service, options option) => ((dos_stats[]) new dos_stats().stat_resources(service, option))[0];

    private class dos_response : base_response
    {
      public dos_stats dos = (dos_stats) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
