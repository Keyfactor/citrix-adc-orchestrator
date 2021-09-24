// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.network.vxlan_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.network
{
  public class vxlan_stats : base_resource
  {
    private uint idField = 0;
    private string clearstatsField = (string) null;
    private long vxlantotrxpktsField = 0;
    private long vxlanrxpktsrateField = 0;
    private long vxlantotrxbytesField = 0;
    private long vxlanrxbytesrateField = 0;
    private long vxlantottxpktsField = 0;
    private long vxlantxpktsrateField = 0;
    private long vxlantottxbytesField = 0;
    private long vxlantxbytesrateField = 0;

    public uint id
    {
      get => this.idField;
      set => this.idField = value;
    }

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long vxlanrxbytesrate
    {
      get => this.vxlanrxbytesrateField;
      private set => this.vxlanrxbytesrateField = value;
    }

    public long vxlantottxpkts
    {
      get => this.vxlantottxpktsField;
      private set => this.vxlantottxpktsField = value;
    }

    public long vxlanrxpktsrate
    {
      get => this.vxlanrxpktsrateField;
      private set => this.vxlanrxpktsrateField = value;
    }

    public long vxlantotrxbytes
    {
      get => this.vxlantotrxbytesField;
      private set => this.vxlantotrxbytesField = value;
    }

    public long vxlantxbytesrate
    {
      get => this.vxlantxbytesrateField;
      private set => this.vxlantxbytesrateField = value;
    }

    public long vxlantxpktsrate
    {
      get => this.vxlantxpktsrateField;
      private set => this.vxlantxpktsrateField = value;
    }

    public long vxlantottxbytes
    {
      get => this.vxlantottxbytesField;
      private set => this.vxlantottxbytesField = value;
    }

    public long vxlantotrxpkts
    {
      get => this.vxlantotrxpktsField;
      private set => this.vxlantotrxpktsField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vxlan_stats.vxlan_response vxlanResponse = new vxlan_stats.vxlan_response();
      vxlan_stats.vxlan_response resource = (vxlan_stats.vxlan_response) service.get_payload_formatter().string_to_resource(vxlanResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vxlan;
    }

    internal override string get_object_name() => this.id.ToString();

    public static vxlan_stats[] get(nitro_service service) => (vxlan_stats[]) new vxlan_stats().stat_resources(service, (options) null);

    public static vxlan_stats[] get(nitro_service service, options option) => (vxlan_stats[]) new vxlan_stats().stat_resources(service, option);

    public static vxlan_stats get(nitro_service service, uint id) => (vxlan_stats) new vxlan_stats()
    {
      id = id
    }.stat_resource(service);

    private class vxlan_response : base_response
    {
      public vxlan_stats[] vxlan = (vxlan_stats[]) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
