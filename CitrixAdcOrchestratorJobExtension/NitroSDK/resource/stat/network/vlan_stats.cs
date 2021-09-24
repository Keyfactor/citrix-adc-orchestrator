// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.network.vlan_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.network
{
  public class vlan_stats : base_resource
  {
    private uint idField = 0;
    private string clearstatsField = (string) null;
    private long vlantotrxpktsField = 0;
    private long vlanrxpktsrateField = 0;
    private long vlantotrxbytesField = 0;
    private long vlanrxbytesrateField = 0;
    private long vlantottxpktsField = 0;
    private long vlantxpktsrateField = 0;
    private long vlantottxbytesField = 0;
    private long vlantxbytesrateField = 0;
    private long vlantotdroppedpktsField = 0;
    private long vlantotbroadcastpktsField = 0;

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

    public long vlanrxbytesrate
    {
      get => this.vlanrxbytesrateField;
      private set => this.vlanrxbytesrateField = value;
    }

    public long vlantottxpkts
    {
      get => this.vlantottxpktsField;
      private set => this.vlantottxpktsField = value;
    }

    public long vlantotdroppedpkts
    {
      get => this.vlantotdroppedpktsField;
      private set => this.vlantotdroppedpktsField = value;
    }

    public long vlanrxpktsrate
    {
      get => this.vlanrxpktsrateField;
      private set => this.vlanrxpktsrateField = value;
    }

    public long vlantotrxpkts
    {
      get => this.vlantotrxpktsField;
      private set => this.vlantotrxpktsField = value;
    }

    public long vlantotbroadcastpkts
    {
      get => this.vlantotbroadcastpktsField;
      private set => this.vlantotbroadcastpktsField = value;
    }

    public long vlantxbytesrate
    {
      get => this.vlantxbytesrateField;
      private set => this.vlantxbytesrateField = value;
    }

    public long vlantotrxbytes
    {
      get => this.vlantotrxbytesField;
      private set => this.vlantotrxbytesField = value;
    }

    public long vlantxpktsrate
    {
      get => this.vlantxpktsrateField;
      private set => this.vlantxpktsrateField = value;
    }

    public long vlantottxbytes
    {
      get => this.vlantottxbytesField;
      private set => this.vlantottxbytesField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vlan_stats.vlan_response vlanResponse = new vlan_stats.vlan_response();
      vlan_stats.vlan_response resource = (vlan_stats.vlan_response) service.get_payload_formatter().string_to_resource(vlanResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vlan;
    }

    internal override string get_object_name() => this.id.ToString();

    public static vlan_stats[] get(nitro_service service) => (vlan_stats[]) new vlan_stats().stat_resources(service, (options) null);

    public static vlan_stats[] get(nitro_service service, options option) => (vlan_stats[]) new vlan_stats().stat_resources(service, option);

    public static vlan_stats get(nitro_service service, uint id) => (vlan_stats) new vlan_stats()
    {
      id = id
    }.stat_resource(service);

    private class vlan_response : base_response
    {
      public vlan_stats[] vlan = (vlan_stats[]) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
