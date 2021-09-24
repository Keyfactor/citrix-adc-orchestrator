// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.dns.dnsaaaarec
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.dns
{
  public class dnsaaaarec : base_resource
  {
    private string hostnameField = (string) null;
    private string ipv6addressField = (string) null;
    private long? ttlField = new long?();
    private string typeField = (string) null;
    private string vservernameField = (string) null;
    private string authtypeField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string hostname
    {
      get => this.hostnameField;
      set => this.hostnameField = value;
    }

    public string ipv6address
    {
      get => this.ipv6addressField;
      set => this.ipv6addressField = value;
    }

    public long? ttl
    {
      get => this.ttlField;
      set => this.ttlField = value;
    }

    public string type
    {
      get => this.typeField;
      set => this.typeField = value;
    }

    public string vservername
    {
      get => this.vservernameField;
      private set => this.vservernameField = value;
    }

    public string authtype
    {
      get => this.authtypeField;
      private set => this.authtypeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      dnsaaaarec.dnsaaaarec_response dnsaaaarecResponse = new dnsaaaarec.dnsaaaarec_response();
      dnsaaaarec.dnsaaaarec_response resource = (dnsaaaarec.dnsaaaarec_response) service.get_payload_formatter().string_to_resource(dnsaaaarecResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.dnsaaaarec;
    }

    internal override string get_object_name() => this.hostname;

    public static base_response add(nitro_service client, dnsaaaarec resource) => new dnsaaaarec()
    {
      hostname = resource.hostname,
      ipv6address = resource.ipv6address,
      ttl = resource.ttl
    }.add_resource(client);

    public static base_responses add(nitro_service client, dnsaaaarec[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnsaaaarec[] dnsaaaarecArray = new dnsaaaarec[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnsaaaarecArray[index] = new dnsaaaarec();
          dnsaaaarecArray[index].hostname = resources[index].hostname;
          dnsaaaarecArray[index].ipv6address = resources[index].ipv6address;
          dnsaaaarecArray[index].ttl = resources[index].ttl;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) dnsaaaarecArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string hostname) => new dnsaaaarec()
    {
      hostname = hostname
    }.delete_resource(client);

    public static base_response delete(nitro_service client, dnsaaaarec resource) => new dnsaaaarec()
    {
      hostname = resource.hostname,
      ipv6address = resource.ipv6address
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] hostname)
    {
      base_responses baseResponses = (base_responses) null;
      if (hostname != null && hostname.Length > 0)
      {
        dnsaaaarec[] dnsaaaarecArray = new dnsaaaarec[hostname.Length];
        for (int index = 0; index < hostname.Length; ++index)
        {
          dnsaaaarecArray[index] = new dnsaaaarec();
          dnsaaaarecArray[index].hostname = hostname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dnsaaaarecArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, dnsaaaarec[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnsaaaarec[] dnsaaaarecArray = new dnsaaaarec[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnsaaaarecArray[index] = new dnsaaaarec();
          dnsaaaarecArray[index].hostname = resources[index].hostname;
          dnsaaaarecArray[index].ipv6address = resources[index].ipv6address;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dnsaaaarecArray);
      }
      return baseResponses;
    }

    public static dnsaaaarec[] get(nitro_service service) => (dnsaaaarec[]) new dnsaaaarec().get_resources(service, (options) null);

    public static dnsaaaarec[] get(nitro_service service, options option) => (dnsaaaarec[]) new dnsaaaarec().get_resources(service, option);

    public static dnsaaaarec get(nitro_service service, dnsaaaarec obj)
    {
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (dnsaaaarec) obj.get_resource(service, option);
    }

    public static dnsaaaarec[] get(nitro_service service, dnsaaaarec[] obj)
    {
      if (obj == null || obj.Length <= 0)
        return (dnsaaaarec[]) null;
      dnsaaaarec[] dnsaaaarecArray = new dnsaaaarec[obj.Length];
      for (int index = 0; index < obj.Length; ++index)
      {
        options option = new options();
        option.set_args(nitro_util.object_to_string_withoutquotes((object) obj[index]));
        dnsaaaarecArray[index] = (dnsaaaarec) obj[index].get_resource(service, option);
      }
      return dnsaaaarecArray;
    }

    public static dnsaaaarec[] get(nitro_service service, dnsaaaarec_args args)
    {
      dnsaaaarec dnsaaaarec = new dnsaaaarec();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (dnsaaaarec[]) dnsaaaarec.get_resources(service, option);
    }

    public static dnsaaaarec[] get_filtered(nitro_service service, string filter)
    {
      dnsaaaarec dnsaaaarec = new dnsaaaarec();
      options option = new options();
      option.set_filter(filter);
      return (dnsaaaarec[]) dnsaaaarec.getfiltered(service, option);
    }

    public static dnsaaaarec[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      dnsaaaarec dnsaaaarec = new dnsaaaarec();
      options option = new options();
      option.set_filter(filter);
      return (dnsaaaarec[]) dnsaaaarec.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      dnsaaaarec dnsaaaarec = new dnsaaaarec();
      options option = new options();
      option.set_count(true);
      dnsaaaarec[] resources = (dnsaaaarec[]) dnsaaaarec.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      dnsaaaarec dnsaaaarec = new dnsaaaarec();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnsaaaarec[] dnsaaaarecArray = (dnsaaaarec[]) dnsaaaarec.getfiltered(service, option);
      return dnsaaaarecArray != null && dnsaaaarecArray.Length > 0 ? dnsaaaarecArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      dnsaaaarec dnsaaaarec = new dnsaaaarec();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnsaaaarec[] dnsaaaarecArray = (dnsaaaarec[]) dnsaaaarec.getfiltered(service, option);
      return dnsaaaarecArray != null && dnsaaaarecArray.Length > 0 ? dnsaaaarecArray[0].__count.Value : 0U;
    }

    private class dnsaaaarec_response : base_response
    {
      public dnsaaaarec[] dnsaaaarec = (dnsaaaarec[]) null;
    }

    public static class authtypeEnum
    {
      public const string ALL = "ALL";
      public const string ADNS = "ADNS";
      public const string PROXY = "PROXY";
    }

    public static class typeEnum
    {
      public const string ALL = "ALL";
      public const string ADNS = "ADNS";
      public const string PROXY = "PROXY";
    }
  }
}
