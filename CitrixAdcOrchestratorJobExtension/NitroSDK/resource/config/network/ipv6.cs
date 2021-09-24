// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.ipv6
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class ipv6 : base_resource
  {
    private string ralearningField = (string) null;
    private string routerredirectionField = (string) null;
    private uint? ndbasereachtimeField = new uint?();
    private uint? ndretransmissiontimeField = new uint?();
    private string natprefixField = (string) null;
    private uint? tdField = new uint?();
    private string dodadField = (string) null;
    private int? basereachtimeField = new int?();
    private int? reachtimeField = new int?();
    private uint? ndreachtimeField = new uint?();
    private int? retransmissiontimeField = new int?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string ralearning
    {
      get => this.ralearningField;
      set => this.ralearningField = value;
    }

    public string routerredirection
    {
      get => this.routerredirectionField;
      set => this.routerredirectionField = value;
    }

    public uint? ndbasereachtime
    {
      get => this.ndbasereachtimeField;
      set => this.ndbasereachtimeField = value;
    }

    public uint? ndretransmissiontime
    {
      get => this.ndretransmissiontimeField;
      set => this.ndretransmissiontimeField = value;
    }

    public string natprefix
    {
      get => this.natprefixField;
      set => this.natprefixField = value;
    }

    public uint? td
    {
      get => this.tdField;
      set => this.tdField = value;
    }

    public string dodad
    {
      get => this.dodadField;
      set => this.dodadField = value;
    }

    public int? basereachtime
    {
      get => this.basereachtimeField;
      private set => this.basereachtimeField = value;
    }

    public int? reachtime
    {
      get => this.reachtimeField;
      private set => this.reachtimeField = value;
    }

    public uint? ndreachtime
    {
      get => this.ndreachtimeField;
      private set => this.ndreachtimeField = value;
    }

    public int? retransmissiontime
    {
      get => this.retransmissiontimeField;
      private set => this.retransmissiontimeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      ipv6.ipv6_response ipv6Response = new ipv6.ipv6_response();
      ipv6.ipv6_response resource = (ipv6.ipv6_response) service.get_payload_formatter().string_to_resource(ipv6Response.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.ipv6;
    }

    internal override string get_object_name() => this.td.HasValue ? this.td.ToString() : (string) null;

    public static base_response update(nitro_service client, ipv6 resource) => new ipv6()
    {
      ralearning = resource.ralearning,
      routerredirection = resource.routerredirection,
      ndbasereachtime = resource.ndbasereachtime,
      ndretransmissiontime = resource.ndretransmissiontime,
      natprefix = resource.natprefix,
      td = resource.td,
      dodad = resource.dodad
    }.update_resource(client);

    public static base_responses update(nitro_service client, ipv6[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        ipv6[] ipv6Array = new ipv6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          ipv6Array[index] = new ipv6();
          ipv6Array[index].ralearning = resources[index].ralearning;
          ipv6Array[index].routerredirection = resources[index].routerredirection;
          ipv6Array[index].ndbasereachtime = resources[index].ndbasereachtime;
          ipv6Array[index].ndretransmissiontime = resources[index].ndretransmissiontime;
          ipv6Array[index].natprefix = resources[index].natprefix;
          ipv6Array[index].td = resources[index].td;
          ipv6Array[index].dodad = resources[index].dodad;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) ipv6Array);
      }
      return baseResponses;
    }

    public static base_response unset(nitro_service client, uint? td, string[] args) => new ipv6()
    {
      td = td
    }.unset_resource(client, args);

    public static base_response unset(
      nitro_service client,
      ipv6 resource,
      string[] args)
    {
      return new ipv6().unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      uint?[] td,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (td != null && td.Length > 0)
      {
        ipv6[] ipv6Array = new ipv6[td.Length];
        for (int index = 0; index < td.Length; ++index)
        {
          ipv6Array[index] = new ipv6();
          ipv6Array[index].td = td[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) ipv6Array, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      ipv6[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        ipv6[] ipv6Array = new ipv6[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          ipv6Array[index] = new ipv6();
          ipv6Array[index].td = resources[index].td;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) ipv6Array, args);
      }
      return baseResponses;
    }

    public static ipv6[] get(nitro_service service) => (ipv6[]) new ipv6().get_resources(service, (options) null);

    public static ipv6[] get(nitro_service service, options option) => (ipv6[]) new ipv6().get_resources(service, option);

    public static ipv6 get(nitro_service service, uint? td) => (ipv6) new ipv6()
    {
      td = td
    }.get_resource(service);

    public static ipv6[] get(nitro_service service, uint?[] td)
    {
      if (td == null || td.Length <= 0)
        return (ipv6[]) null;
      ipv6[] ipv6Array1 = new ipv6[td.Length];
      ipv6[] ipv6Array2 = new ipv6[td.Length];
      for (int index = 0; index < td.Length; ++index)
      {
        ipv6Array2[index] = new ipv6();
        ipv6Array2[index].td = td[index];
        ipv6Array1[index] = (ipv6) ipv6Array2[index].get_resource(service);
      }
      return ipv6Array1;
    }

    public static ipv6[] get_filtered(nitro_service service, string filter)
    {
      ipv6 ipv6 = new ipv6();
      options option = new options();
      option.set_filter(filter);
      return (ipv6[]) ipv6.getfiltered(service, option);
    }

    public static ipv6[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      ipv6 ipv6 = new ipv6();
      options option = new options();
      option.set_filter(filter);
      return (ipv6[]) ipv6.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      ipv6 ipv6 = new ipv6();
      options option = new options();
      option.set_count(true);
      ipv6[] resources = (ipv6[]) ipv6.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      ipv6 ipv6 = new ipv6();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      ipv6[] ipv6Array = (ipv6[]) ipv6.getfiltered(service, option);
      return ipv6Array != null && ipv6Array.Length > 0 ? ipv6Array[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      ipv6 ipv6 = new ipv6();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      ipv6[] ipv6Array = (ipv6[]) ipv6.getfiltered(service, option);
      return ipv6Array != null && ipv6Array.Length > 0 ? ipv6Array[0].__count.Value : 0U;
    }

    private class ipv6_response : base_response
    {
      public ipv6[] ipv6 = (ipv6[]) null;
    }

    public static class routerredirectionEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class ralearningEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class dodadEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
