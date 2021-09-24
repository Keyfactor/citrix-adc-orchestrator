// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.dns.dnsnsrec
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.dns
{
  public class dnsnsrec : base_resource
  {
    private string domainField = (string) null;
    private string nameserverField = (string) null;
    private long? ttlField = new long?();
    private string typeField = (string) null;
    private string authtypeField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string domain
    {
      get => this.domainField;
      set => this.domainField = value;
    }

    public string nameserver
    {
      get => this.nameserverField;
      set => this.nameserverField = value;
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

    public string authtype
    {
      get => this.authtypeField;
      private set => this.authtypeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      dnsnsrec.dnsnsrec_response dnsnsrecResponse = new dnsnsrec.dnsnsrec_response();
      dnsnsrec.dnsnsrec_response resource = (dnsnsrec.dnsnsrec_response) service.get_payload_formatter().string_to_resource(dnsnsrecResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.dnsnsrec;
    }

    internal override string get_object_name() => this.domain;

    public static base_response add(nitro_service client, dnsnsrec resource) => new dnsnsrec()
    {
      domain = resource.domain,
      nameserver = resource.nameserver,
      ttl = resource.ttl
    }.add_resource(client);

    public static base_responses add(nitro_service client, dnsnsrec[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnsnsrec[] dnsnsrecArray = new dnsnsrec[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnsnsrecArray[index] = new dnsnsrec();
          dnsnsrecArray[index].domain = resources[index].domain;
          dnsnsrecArray[index].nameserver = resources[index].nameserver;
          dnsnsrecArray[index].ttl = resources[index].ttl;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) dnsnsrecArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string domain) => new dnsnsrec()
    {
      domain = domain
    }.delete_resource(client);

    public static base_response delete(nitro_service client, dnsnsrec resource) => new dnsnsrec()
    {
      domain = resource.domain,
      nameserver = resource.nameserver
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] domain)
    {
      base_responses baseResponses = (base_responses) null;
      if (domain != null && domain.Length > 0)
      {
        dnsnsrec[] dnsnsrecArray = new dnsnsrec[domain.Length];
        for (int index = 0; index < domain.Length; ++index)
        {
          dnsnsrecArray[index] = new dnsnsrec();
          dnsnsrecArray[index].domain = domain[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dnsnsrecArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, dnsnsrec[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnsnsrec[] dnsnsrecArray = new dnsnsrec[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnsnsrecArray[index] = new dnsnsrec();
          dnsnsrecArray[index].domain = resources[index].domain;
          dnsnsrecArray[index].nameserver = resources[index].nameserver;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dnsnsrecArray);
      }
      return baseResponses;
    }

    public static dnsnsrec[] get(nitro_service service) => (dnsnsrec[]) new dnsnsrec().get_resources(service, (options) null);

    public static dnsnsrec[] get(nitro_service service, options option) => (dnsnsrec[]) new dnsnsrec().get_resources(service, option);

    public static dnsnsrec[] get(nitro_service service, dnsnsrec_args args)
    {
      dnsnsrec dnsnsrec = new dnsnsrec();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (dnsnsrec[]) dnsnsrec.get_resources(service, option);
    }

    public static dnsnsrec get(nitro_service service, string domain) => (dnsnsrec) new dnsnsrec()
    {
      domain = domain
    }.get_resource(service);

    public static dnsnsrec[] get(nitro_service service, string[] domain)
    {
      if (domain == null || domain.Length <= 0)
        return (dnsnsrec[]) null;
      dnsnsrec[] dnsnsrecArray1 = new dnsnsrec[domain.Length];
      dnsnsrec[] dnsnsrecArray2 = new dnsnsrec[domain.Length];
      for (int index = 0; index < domain.Length; ++index)
      {
        dnsnsrecArray2[index] = new dnsnsrec();
        dnsnsrecArray2[index].domain = domain[index];
        dnsnsrecArray1[index] = (dnsnsrec) dnsnsrecArray2[index].get_resource(service);
      }
      return dnsnsrecArray1;
    }

    public static dnsnsrec[] get_filtered(nitro_service service, string filter)
    {
      dnsnsrec dnsnsrec = new dnsnsrec();
      options option = new options();
      option.set_filter(filter);
      return (dnsnsrec[]) dnsnsrec.getfiltered(service, option);
    }

    public static dnsnsrec[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      dnsnsrec dnsnsrec = new dnsnsrec();
      options option = new options();
      option.set_filter(filter);
      return (dnsnsrec[]) dnsnsrec.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      dnsnsrec dnsnsrec = new dnsnsrec();
      options option = new options();
      option.set_count(true);
      dnsnsrec[] resources = (dnsnsrec[]) dnsnsrec.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      dnsnsrec dnsnsrec = new dnsnsrec();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnsnsrec[] dnsnsrecArray = (dnsnsrec[]) dnsnsrec.getfiltered(service, option);
      return dnsnsrecArray != null && dnsnsrecArray.Length > 0 ? dnsnsrecArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      dnsnsrec dnsnsrec = new dnsnsrec();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnsnsrec[] dnsnsrecArray = (dnsnsrec[]) dnsnsrec.getfiltered(service, option);
      return dnsnsrecArray != null && dnsnsrecArray.Length > 0 ? dnsnsrecArray[0].__count.Value : 0U;
    }

    private class dnsnsrec_response : base_response
    {
      public dnsnsrec[] dnsnsrec = (dnsnsrec[]) null;
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
