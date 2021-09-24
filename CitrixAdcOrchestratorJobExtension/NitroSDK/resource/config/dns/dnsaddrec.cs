// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.dns.dnsaddrec
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.dns
{
  public class dnsaddrec : base_resource
  {
    private string hostnameField = (string) null;
    private string ipaddressField = (string) null;
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

    public string ipaddress
    {
      get => this.ipaddressField;
      set => this.ipaddressField = value;
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
      dnsaddrec.dnsaddrec_response dnsaddrecResponse = new dnsaddrec.dnsaddrec_response();
      dnsaddrec.dnsaddrec_response resource = (dnsaddrec.dnsaddrec_response) service.get_payload_formatter().string_to_resource(dnsaddrecResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.dnsaddrec;
    }

    internal override string get_object_name() => this.hostname;

    public static base_response add(nitro_service client, dnsaddrec resource) => new dnsaddrec()
    {
      hostname = resource.hostname,
      ipaddress = resource.ipaddress,
      ttl = resource.ttl
    }.add_resource(client);

    public static base_responses add(nitro_service client, dnsaddrec[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnsaddrec[] dnsaddrecArray = new dnsaddrec[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnsaddrecArray[index] = new dnsaddrec();
          dnsaddrecArray[index].hostname = resources[index].hostname;
          dnsaddrecArray[index].ipaddress = resources[index].ipaddress;
          dnsaddrecArray[index].ttl = resources[index].ttl;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) dnsaddrecArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string hostname) => new dnsaddrec()
    {
      hostname = hostname
    }.delete_resource(client);

    public static base_response delete(nitro_service client, dnsaddrec resource) => new dnsaddrec()
    {
      hostname = resource.hostname,
      ipaddress = resource.ipaddress
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] hostname)
    {
      base_responses baseResponses = (base_responses) null;
      if (hostname != null && hostname.Length > 0)
      {
        dnsaddrec[] dnsaddrecArray = new dnsaddrec[hostname.Length];
        for (int index = 0; index < hostname.Length; ++index)
        {
          dnsaddrecArray[index] = new dnsaddrec();
          dnsaddrecArray[index].hostname = hostname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dnsaddrecArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, dnsaddrec[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnsaddrec[] dnsaddrecArray = new dnsaddrec[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnsaddrecArray[index] = new dnsaddrec();
          dnsaddrecArray[index].hostname = resources[index].hostname;
          dnsaddrecArray[index].ipaddress = resources[index].ipaddress;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dnsaddrecArray);
      }
      return baseResponses;
    }

    public static dnsaddrec[] get(nitro_service service) => (dnsaddrec[]) new dnsaddrec().get_resources(service, (options) null);

    public static dnsaddrec[] get(nitro_service service, options option) => (dnsaddrec[]) new dnsaddrec().get_resources(service, option);

    public static dnsaddrec[] get(nitro_service service, dnsaddrec_args args)
    {
      dnsaddrec dnsaddrec = new dnsaddrec();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (dnsaddrec[]) dnsaddrec.get_resources(service, option);
    }

    public static dnsaddrec get(nitro_service service, string hostname) => (dnsaddrec) new dnsaddrec()
    {
      hostname = hostname
    }.get_resource(service);

    public static dnsaddrec[] get(nitro_service service, string[] hostname)
    {
      if (hostname == null || hostname.Length <= 0)
        return (dnsaddrec[]) null;
      dnsaddrec[] dnsaddrecArray1 = new dnsaddrec[hostname.Length];
      dnsaddrec[] dnsaddrecArray2 = new dnsaddrec[hostname.Length];
      for (int index = 0; index < hostname.Length; ++index)
      {
        dnsaddrecArray2[index] = new dnsaddrec();
        dnsaddrecArray2[index].hostname = hostname[index];
        dnsaddrecArray1[index] = (dnsaddrec) dnsaddrecArray2[index].get_resource(service);
      }
      return dnsaddrecArray1;
    }

    public static dnsaddrec[] get_filtered(nitro_service service, string filter)
    {
      dnsaddrec dnsaddrec = new dnsaddrec();
      options option = new options();
      option.set_filter(filter);
      return (dnsaddrec[]) dnsaddrec.getfiltered(service, option);
    }

    public static dnsaddrec[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      dnsaddrec dnsaddrec = new dnsaddrec();
      options option = new options();
      option.set_filter(filter);
      return (dnsaddrec[]) dnsaddrec.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      dnsaddrec dnsaddrec = new dnsaddrec();
      options option = new options();
      option.set_count(true);
      dnsaddrec[] resources = (dnsaddrec[]) dnsaddrec.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      dnsaddrec dnsaddrec = new dnsaddrec();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnsaddrec[] dnsaddrecArray = (dnsaddrec[]) dnsaddrec.getfiltered(service, option);
      return dnsaddrecArray != null && dnsaddrecArray.Length > 0 ? dnsaddrecArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      dnsaddrec dnsaddrec = new dnsaddrec();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnsaddrec[] dnsaddrecArray = (dnsaddrec[]) dnsaddrec.getfiltered(service, option);
      return dnsaddrecArray != null && dnsaddrecArray.Length > 0 ? dnsaddrecArray[0].__count.Value : 0U;
    }

    private class dnsaddrec_response : base_response
    {
      public dnsaddrec[] dnsaddrec = (dnsaddrec[]) null;
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
