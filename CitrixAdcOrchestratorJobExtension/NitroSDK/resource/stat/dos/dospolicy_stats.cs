// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.dos.dospolicy_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.dos
{
  public class dospolicy_stats : base_resource
  {
    private string nameField = (string) null;
    private string clearstatsField = (string) null;
    private double doscurrentcltdetectrateField = 0.0;
    private string dosphysicalserviceipField = (string) null;
    private ushort dosphysicalserviceportField = 0;
    private long doscurrentqueuesizeField = 0;
    private long doscurrentqueuesizerateField = 0;
    private long dostotjssentField = 0;
    private long dosjssentrateField = 0;
    private long dostotjsrefusedField = 0;
    private long dosjsrefusedrateField = 0;
    private long dostotvalidclientsField = 0;
    private long dosvalidclientsrateField = 0;
    private long dostotjsbytessentField = 0;
    private long dosjsbytessentrateField = 0;
    private long dostotnongetpostrequestsField = 0;
    private long dosnongetpostrequestsrateField = 0;

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

    public long dosjsrefusedrate
    {
      get => this.dosjsrefusedrateField;
      private set => this.dosjsrefusedrateField = value;
    }

    public string dosphysicalserviceip
    {
      get => this.dosphysicalserviceipField;
      private set => this.dosphysicalserviceipField = value;
    }

    public long dosnongetpostrequestsrate
    {
      get => this.dosnongetpostrequestsrateField;
      private set => this.dosnongetpostrequestsrateField = value;
    }

    public long dosjssentrate
    {
      get => this.dosjssentrateField;
      private set => this.dosjssentrateField = value;
    }

    public ushort dosphysicalserviceport
    {
      get => this.dosphysicalserviceportField;
      private set => this.dosphysicalserviceportField = value;
    }

    public long dosjsbytessentrate
    {
      get => this.dosjsbytessentrateField;
      private set => this.dosjsbytessentrateField = value;
    }

    public double doscurrentcltdetectrate
    {
      get => this.doscurrentcltdetectrateField;
      private set => this.doscurrentcltdetectrateField = value;
    }

    public long dostotnongetpostrequests
    {
      get => this.dostotnongetpostrequestsField;
      private set => this.dostotnongetpostrequestsField = value;
    }

    public long dostotvalidclients
    {
      get => this.dostotvalidclientsField;
      private set => this.dostotvalidclientsField = value;
    }

    public long dosvalidclientsrate
    {
      get => this.dosvalidclientsrateField;
      private set => this.dosvalidclientsrateField = value;
    }

    public long doscurrentqueuesizerate
    {
      get => this.doscurrentqueuesizerateField;
      private set => this.doscurrentqueuesizerateField = value;
    }

    public long dostotjsbytessent
    {
      get => this.dostotjsbytessentField;
      private set => this.dostotjsbytessentField = value;
    }

    public long dostotjssent
    {
      get => this.dostotjssentField;
      private set => this.dostotjssentField = value;
    }

    public long dostotjsrefused
    {
      get => this.dostotjsrefusedField;
      private set => this.dostotjsrefusedField = value;
    }

    public long doscurrentqueuesize
    {
      get => this.doscurrentqueuesizeField;
      private set => this.doscurrentqueuesizeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      dospolicy_stats.dospolicy_response dospolicyResponse = new dospolicy_stats.dospolicy_response();
      dospolicy_stats.dospolicy_response resource = (dospolicy_stats.dospolicy_response) service.get_payload_formatter().string_to_resource(dospolicyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.dospolicy;
    }

    internal override string get_object_name() => this.name;

    public static dospolicy_stats[] get(nitro_service service) => (dospolicy_stats[]) new dospolicy_stats().stat_resources(service, (options) null);

    public static dospolicy_stats[] get(nitro_service service, options option) => (dospolicy_stats[]) new dospolicy_stats().stat_resources(service, option);

    public static dospolicy_stats get(nitro_service service, string name) => (dospolicy_stats) new dospolicy_stats()
    {
      name = name
    }.stat_resource(service);

    private class dospolicy_response : base_response
    {
      public dospolicy_stats[] dospolicy = (dospolicy_stats[]) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
