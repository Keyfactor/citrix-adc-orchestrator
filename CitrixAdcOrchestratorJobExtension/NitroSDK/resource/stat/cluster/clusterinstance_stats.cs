// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.cluster.clusterinstance_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.cluster
{
  public class clusterinstance_stats : base_resource
  {
    private uint clidField = 0;
    private string clearstatsField = (string) null;
    private long clnumnodesField = 0;
    private string clcurstatusField = (string) null;
    private string clviewleaderField = (string) null;
    private long totsteeredpktsField = 0;
    private long clbkplanerxField = 0;
    private long clbkplanerxrateField = 0;
    private long clbkplanetxField = 0;
    private long clbkplanetxrateField = 0;
    private long numdfddroppktsField = 0;
    private long totpropagationtimeoutField = 0;

    public uint clid
    {
      get => this.clidField;
      set => this.clidField = value;
    }

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long totpropagationtimeout
    {
      get => this.totpropagationtimeoutField;
      private set => this.totpropagationtimeoutField = value;
    }

    public long clbkplanetx
    {
      get => this.clbkplanetxField;
      private set => this.clbkplanetxField = value;
    }

    public long clbkplanetxrate
    {
      get => this.clbkplanetxrateField;
      private set => this.clbkplanetxrateField = value;
    }

    public long totsteeredpkts
    {
      get => this.totsteeredpktsField;
      private set => this.totsteeredpktsField = value;
    }

    public long numdfddroppkts
    {
      get => this.numdfddroppktsField;
      private set => this.numdfddroppktsField = value;
    }

    public string clviewleader
    {
      get => this.clviewleaderField;
      private set => this.clviewleaderField = value;
    }

    public long clbkplanerx
    {
      get => this.clbkplanerxField;
      private set => this.clbkplanerxField = value;
    }

    public string clcurstatus
    {
      get => this.clcurstatusField;
      private set => this.clcurstatusField = value;
    }

    public long clnumnodes
    {
      get => this.clnumnodesField;
      private set => this.clnumnodesField = value;
    }

    public long clbkplanerxrate
    {
      get => this.clbkplanerxrateField;
      private set => this.clbkplanerxrateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      clusterinstance_stats.clusterinstance_response clusterinstanceResponse = new clusterinstance_stats.clusterinstance_response();
      clusterinstance_stats.clusterinstance_response resource = (clusterinstance_stats.clusterinstance_response) service.get_payload_formatter().string_to_resource(clusterinstanceResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.clusterinstance;
    }

    internal override string get_object_name() => this.clid.ToString();

    public static clusterinstance_stats[] get(nitro_service service) => (clusterinstance_stats[]) new clusterinstance_stats().stat_resources(service, (options) null);

    public static clusterinstance_stats[] get(
      nitro_service service,
      options option)
    {
      return (clusterinstance_stats[]) new clusterinstance_stats().stat_resources(service, option);
    }

    public static clusterinstance_stats get(nitro_service service, uint clid) => (clusterinstance_stats) new clusterinstance_stats()
    {
      clid = clid
    }.stat_resource(service);

    private class clusterinstance_response : base_response
    {
      public clusterinstance_stats[] clusterinstance = (clusterinstance_stats[]) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
