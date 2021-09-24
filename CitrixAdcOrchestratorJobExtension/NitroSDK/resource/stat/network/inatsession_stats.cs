// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.network.inatsession_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.stat.network
{
  public class inatsession_stats : base_resource
  {
    private string nameField = (string) null;
    private string clearstatsField = (string) null;
    private long inattothitsField = 0;
    private long inathitsrateField = 0;
    private long inatcursessionsField = 0;
    private long inatcursessionsrateField = 0;
    private long inattotreceivebytesField = 0;
    private long inatreceivebytesrateField = 0;
    private long inattotsentbytesField = 0;
    private long inatsentbytesrateField = 0;
    private long inattotpktreceivedField = 0;
    private long inatpktreceivedrateField = 0;
    private long inattotpktsentField = 0;
    private long inatpktsentrateField = 0;

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

    public long inattotsentbytes
    {
      get => this.inattotsentbytesField;
      private set => this.inattotsentbytesField = value;
    }

    public long inatreceivebytesrate
    {
      get => this.inatreceivebytesrateField;
      private set => this.inatreceivebytesrateField = value;
    }

    public long inathitsrate
    {
      get => this.inathitsrateField;
      private set => this.inathitsrateField = value;
    }

    public long inattotreceivebytes
    {
      get => this.inattotreceivebytesField;
      private set => this.inattotreceivebytesField = value;
    }

    public long inatcursessionsrate
    {
      get => this.inatcursessionsrateField;
      private set => this.inatcursessionsrateField = value;
    }

    public long inatcursessions
    {
      get => this.inatcursessionsField;
      private set => this.inatcursessionsField = value;
    }

    public long inatsentbytesrate
    {
      get => this.inatsentbytesrateField;
      private set => this.inatsentbytesrateField = value;
    }

    public long inatpktsentrate
    {
      get => this.inatpktsentrateField;
      private set => this.inatpktsentrateField = value;
    }

    public long inattotpktreceived
    {
      get => this.inattotpktreceivedField;
      private set => this.inattotpktreceivedField = value;
    }

    public long inattothits
    {
      get => this.inattothitsField;
      private set => this.inattothitsField = value;
    }

    public long inattotpktsent
    {
      get => this.inattotpktsentField;
      private set => this.inattotpktsentField = value;
    }

    public long inatpktreceivedrate
    {
      get => this.inatpktreceivedrateField;
      private set => this.inatpktreceivedrateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      inatsession_stats.inatsession_response inatsessionResponse = new inatsession_stats.inatsession_response();
      inatsession_stats.inatsession_response resource = (inatsession_stats.inatsession_response) service.get_payload_formatter().string_to_resource(inatsessionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.inatsession;
    }

    internal override string get_object_name() => this.name;

    public static inatsession_stats get(nitro_service service, string name) => (inatsession_stats) new inatsession_stats()
    {
      name = name
    }.stat_resource(service);

    public static inatsession_stats get(
      nitro_service service,
      inatsession_stats obj)
    {
      options option = new options();
      option.set_args(nitro_util.statobject_to_string_withoutquotes((object) obj));
      return (inatsession_stats) obj.stat_resource(service, option);
    }

    private class inatsession_response : base_response
    {
      public inatsession_stats[] inatsession = (inatsession_stats[]) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
