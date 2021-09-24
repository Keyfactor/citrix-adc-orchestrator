// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.cluster.clusternode_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.cluster
{
  public class clusternode_stats : base_resource
  {
    private uint nodeidField = 0;
    private string clearstatsField = (string) null;
    private string clsyncstateField = (string) null;
    private string clnodeeffectivehealthField = (string) null;
    private string clnodeipField = (string) null;
    private string clmasterstateField = (string) null;
    private long cltothbtxField = 0;
    private long cltothbrxField = 0;
    private long nnmcurconnField = 0;
    private long nnmtotconntxField = 0;
    private long nnmtotconnrxField = 0;
    private string clptpstateField = (string) null;
    private long clptptxField = 0;
    private long clptprxField = 0;
    private long nnmerrmsendField = 0;

    public uint nodeid
    {
      get => this.nodeidField;
      set => this.nodeidField = value;
    }

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public string clnodeip
    {
      get => this.clnodeipField;
      private set => this.clnodeipField = value;
    }

    public string clsyncstate
    {
      get => this.clsyncstateField;
      private set => this.clsyncstateField = value;
    }

    public long nnmcurconn
    {
      get => this.nnmcurconnField;
      private set => this.nnmcurconnField = value;
    }

    public long nnmerrmsend
    {
      get => this.nnmerrmsendField;
      private set => this.nnmerrmsendField = value;
    }

    public string clnodeeffectivehealth
    {
      get => this.clnodeeffectivehealthField;
      private set => this.clnodeeffectivehealthField = value;
    }

    public long nnmtotconnrx
    {
      get => this.nnmtotconnrxField;
      private set => this.nnmtotconnrxField = value;
    }

    public long cltothbrx
    {
      get => this.cltothbrxField;
      private set => this.cltothbrxField = value;
    }

    public long clptprx
    {
      get => this.clptprxField;
      private set => this.clptprxField = value;
    }

    public long nnmtotconntx
    {
      get => this.nnmtotconntxField;
      private set => this.nnmtotconntxField = value;
    }

    public string clmasterstate
    {
      get => this.clmasterstateField;
      private set => this.clmasterstateField = value;
    }

    public long clptptx
    {
      get => this.clptptxField;
      private set => this.clptptxField = value;
    }

    public string clptpstate
    {
      get => this.clptpstateField;
      private set => this.clptpstateField = value;
    }

    public long cltothbtx
    {
      get => this.cltothbtxField;
      private set => this.cltothbtxField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      clusternode_stats.clusternode_response clusternodeResponse = new clusternode_stats.clusternode_response();
      clusternode_stats.clusternode_response resource = (clusternode_stats.clusternode_response) service.get_payload_formatter().string_to_resource(clusternodeResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.clusternode;
    }

    internal override string get_object_name() => this.nodeid.ToString();

    public static clusternode_stats[] get(nitro_service service) => (clusternode_stats[]) new clusternode_stats().stat_resources(service, (options) null);

    public static clusternode_stats[] get(nitro_service service, options option) => (clusternode_stats[]) new clusternode_stats().stat_resources(service, option);

    public static clusternode_stats get(nitro_service service, uint nodeid) => (clusternode_stats) new clusternode_stats()
    {
      nodeid = nodeid
    }.stat_resource(service);

    private class clusternode_response : base_response
    {
      public clusternode_stats[] clusternode = (clusternode_stats[]) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
