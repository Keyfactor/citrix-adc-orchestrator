// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.network.inat_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.network
{
  public class inat_stats : base_resource
  {
    private string nameField = (string) null;
    private string clearstatsField = (string) null;
    private long nat46tottcp46Field = 0;
    private long nat46tcp46rateField = 0;
    private long nat46totudp46Field = 0;
    private long nat46udp46rateField = 0;
    private long nat46toticmp46Field = 0;
    private long nat46icmp46rateField = 0;
    private long nat46totdrop46Field = 0;
    private long nat46drop46rateField = 0;
    private long nat46tottcp64Field = 0;
    private long nat46tcp64rateField = 0;
    private long nat46totudp64Field = 0;
    private long nat46udp64rateField = 0;
    private long nat46toticmp64Field = 0;
    private long nat46icmp64rateField = 0;
    private long nat46totdrop64Field = 0;
    private long nat46drop64rateField = 0;
    private long inatnat46tcp46Field = 0;
    private long inatnat46tcp46rateField = 0;
    private long inatnat46udp46Field = 0;
    private long inatnat46udp46rateField = 0;
    private long inatnat46icmp46Field = 0;
    private long inatnat46icmp46rateField = 0;
    private long inatnat46drop46Field = 0;
    private long inatnat46drop46rateField = 0;
    private long inatnat46tcp64Field = 0;
    private long inatnat46tcp64rateField = 0;
    private long inatnat46udp64Field = 0;
    private long inatnat46udp64rateField = 0;
    private long inatnat46icmp64Field = 0;
    private long inatnat46icmp64rateField = 0;
    private long inatnat46drop64Field = 0;
    private long inatnat46drop64rateField = 0;

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

    public long nat46udp64rate
    {
      get => this.nat46udp64rateField;
      private set => this.nat46udp64rateField = value;
    }

    public long nat46totdrop64
    {
      get => this.nat46totdrop64Field;
      private set => this.nat46totdrop64Field = value;
    }

    public long nat46totudp46
    {
      get => this.nat46totudp46Field;
      private set => this.nat46totudp46Field = value;
    }

    public long nat46icmp64rate
    {
      get => this.nat46icmp64rateField;
      private set => this.nat46icmp64rateField = value;
    }

    public long inatnat46tcp46
    {
      get => this.inatnat46tcp46Field;
      private set => this.inatnat46tcp46Field = value;
    }

    public long nat46totdrop46
    {
      get => this.nat46totdrop46Field;
      private set => this.nat46totdrop46Field = value;
    }

    public long inatnat46tcp64
    {
      get => this.inatnat46tcp64Field;
      private set => this.inatnat46tcp64Field = value;
    }

    public long inatnat46drop46
    {
      get => this.inatnat46drop46Field;
      private set => this.inatnat46drop46Field = value;
    }

    public long inatnat46drop64
    {
      get => this.inatnat46drop64Field;
      private set => this.inatnat46drop64Field = value;
    }

    public long inatnat46udp46
    {
      get => this.inatnat46udp46Field;
      private set => this.inatnat46udp46Field = value;
    }

    public long nat46tottcp64
    {
      get => this.nat46tottcp64Field;
      private set => this.nat46tottcp64Field = value;
    }

    public long nat46drop46rate
    {
      get => this.nat46drop46rateField;
      private set => this.nat46drop46rateField = value;
    }

    public long inatnat46drop46rate
    {
      get => this.inatnat46drop46rateField;
      private set => this.inatnat46drop46rateField = value;
    }

    public long inatnat46tcp64rate
    {
      get => this.inatnat46tcp64rateField;
      private set => this.inatnat46tcp64rateField = value;
    }

    public long inatnat46icmp64
    {
      get => this.inatnat46icmp64Field;
      private set => this.inatnat46icmp64Field = value;
    }

    public long nat46drop64rate
    {
      get => this.nat46drop64rateField;
      private set => this.nat46drop64rateField = value;
    }

    public long inatnat46tcp46rate
    {
      get => this.inatnat46tcp46rateField;
      private set => this.inatnat46tcp46rateField = value;
    }

    public long nat46tottcp46
    {
      get => this.nat46tottcp46Field;
      private set => this.nat46tottcp46Field = value;
    }

    public long nat46toticmp46
    {
      get => this.nat46toticmp46Field;
      private set => this.nat46toticmp46Field = value;
    }

    public long inatnat46icmp46rate
    {
      get => this.inatnat46icmp46rateField;
      private set => this.inatnat46icmp46rateField = value;
    }

    public long inatnat46udp64
    {
      get => this.inatnat46udp64Field;
      private set => this.inatnat46udp64Field = value;
    }

    public long nat46tcp46rate
    {
      get => this.nat46tcp46rateField;
      private set => this.nat46tcp46rateField = value;
    }

    public long inatnat46drop64rate
    {
      get => this.inatnat46drop64rateField;
      private set => this.inatnat46drop64rateField = value;
    }

    public long inatnat46udp64rate
    {
      get => this.inatnat46udp64rateField;
      private set => this.inatnat46udp64rateField = value;
    }

    public long nat46icmp46rate
    {
      get => this.nat46icmp46rateField;
      private set => this.nat46icmp46rateField = value;
    }

    public long inatnat46icmp46
    {
      get => this.inatnat46icmp46Field;
      private set => this.inatnat46icmp46Field = value;
    }

    public long inatnat46icmp64rate
    {
      get => this.inatnat46icmp64rateField;
      private set => this.inatnat46icmp64rateField = value;
    }

    public long nat46tcp64rate
    {
      get => this.nat46tcp64rateField;
      private set => this.nat46tcp64rateField = value;
    }

    public long nat46totudp64
    {
      get => this.nat46totudp64Field;
      private set => this.nat46totudp64Field = value;
    }

    public long nat46udp46rate
    {
      get => this.nat46udp46rateField;
      private set => this.nat46udp46rateField = value;
    }

    public long nat46toticmp64
    {
      get => this.nat46toticmp64Field;
      private set => this.nat46toticmp64Field = value;
    }

    public long inatnat46udp46rate
    {
      get => this.inatnat46udp46rateField;
      private set => this.inatnat46udp46rateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      inat_stats.inat_response inatResponse = new inat_stats.inat_response();
      inat_stats.inat_response resource = (inat_stats.inat_response) service.get_payload_formatter().string_to_resource(inatResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.inat;
    }

    internal override string get_object_name() => this.name;

    public static inat_stats[] get(nitro_service service) => (inat_stats[]) new inat_stats().stat_resources(service, (options) null);

    public static inat_stats[] get(nitro_service service, options option) => (inat_stats[]) new inat_stats().stat_resources(service, option);

    public static inat_stats get(nitro_service service, string name) => (inat_stats) new inat_stats()
    {
      name = name
    }.stat_resource(service);

    private class inat_response : base_response
    {
      public inat_stats[] inat = (inat_stats[]) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
