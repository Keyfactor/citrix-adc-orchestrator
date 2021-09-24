// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.dns.dnsptrrec
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.dns
{
  public class dnsptrrec : base_resource
  {
    private string reversedomainField = (string) null;
    private string domainField = (string) null;
    private long? ttlField = new long?();
    private string typeField = (string) null;
    private string authtypeField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string reversedomain
    {
      get => this.reversedomainField;
      set => this.reversedomainField = value;
    }

    public string domain
    {
      get => this.domainField;
      set => this.domainField = value;
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
      dnsptrrec.dnsptrrec_response dnsptrrecResponse = new dnsptrrec.dnsptrrec_response();
      dnsptrrec.dnsptrrec_response resource = (dnsptrrec.dnsptrrec_response) service.get_payload_formatter().string_to_resource(dnsptrrecResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.dnsptrrec;
    }

    internal override string get_object_name() => this.reversedomain;

    public static base_response add(nitro_service client, dnsptrrec resource) => new dnsptrrec()
    {
      reversedomain = resource.reversedomain,
      domain = resource.domain,
      ttl = resource.ttl
    }.add_resource(client);

    public static base_responses add(nitro_service client, dnsptrrec[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnsptrrec[] dnsptrrecArray = new dnsptrrec[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnsptrrecArray[index] = new dnsptrrec();
          dnsptrrecArray[index].reversedomain = resources[index].reversedomain;
          dnsptrrecArray[index].domain = resources[index].domain;
          dnsptrrecArray[index].ttl = resources[index].ttl;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) dnsptrrecArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string reversedomain) => new dnsptrrec()
    {
      reversedomain = reversedomain
    }.delete_resource(client);

    public static base_response delete(nitro_service client, dnsptrrec resource) => new dnsptrrec()
    {
      reversedomain = resource.reversedomain,
      domain = resource.domain
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] reversedomain)
    {
      base_responses baseResponses = (base_responses) null;
      if (reversedomain != null && reversedomain.Length > 0)
      {
        dnsptrrec[] dnsptrrecArray = new dnsptrrec[reversedomain.Length];
        for (int index = 0; index < reversedomain.Length; ++index)
        {
          dnsptrrecArray[index] = new dnsptrrec();
          dnsptrrecArray[index].reversedomain = reversedomain[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dnsptrrecArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, dnsptrrec[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnsptrrec[] dnsptrrecArray = new dnsptrrec[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnsptrrecArray[index] = new dnsptrrec();
          dnsptrrecArray[index].reversedomain = resources[index].reversedomain;
          dnsptrrecArray[index].domain = resources[index].domain;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dnsptrrecArray);
      }
      return baseResponses;
    }

    public static dnsptrrec[] get(nitro_service service) => (dnsptrrec[]) new dnsptrrec().get_resources(service, (options) null);

    public static dnsptrrec[] get(nitro_service service, options option) => (dnsptrrec[]) new dnsptrrec().get_resources(service, option);

    public static dnsptrrec[] get(nitro_service service, dnsptrrec_args args)
    {
      dnsptrrec dnsptrrec = new dnsptrrec();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (dnsptrrec[]) dnsptrrec.get_resources(service, option);
    }

    public static dnsptrrec get(nitro_service service, string reversedomain) => (dnsptrrec) new dnsptrrec()
    {
      reversedomain = reversedomain
    }.get_resource(service);

    public static dnsptrrec[] get(nitro_service service, string[] reversedomain)
    {
      if (reversedomain == null || reversedomain.Length <= 0)
        return (dnsptrrec[]) null;
      dnsptrrec[] dnsptrrecArray1 = new dnsptrrec[reversedomain.Length];
      dnsptrrec[] dnsptrrecArray2 = new dnsptrrec[reversedomain.Length];
      for (int index = 0; index < reversedomain.Length; ++index)
      {
        dnsptrrecArray2[index] = new dnsptrrec();
        dnsptrrecArray2[index].reversedomain = reversedomain[index];
        dnsptrrecArray1[index] = (dnsptrrec) dnsptrrecArray2[index].get_resource(service);
      }
      return dnsptrrecArray1;
    }

    public static dnsptrrec[] get_filtered(nitro_service service, string filter)
    {
      dnsptrrec dnsptrrec = new dnsptrrec();
      options option = new options();
      option.set_filter(filter);
      return (dnsptrrec[]) dnsptrrec.getfiltered(service, option);
    }

    public static dnsptrrec[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      dnsptrrec dnsptrrec = new dnsptrrec();
      options option = new options();
      option.set_filter(filter);
      return (dnsptrrec[]) dnsptrrec.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      dnsptrrec dnsptrrec = new dnsptrrec();
      options option = new options();
      option.set_count(true);
      dnsptrrec[] resources = (dnsptrrec[]) dnsptrrec.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      dnsptrrec dnsptrrec = new dnsptrrec();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnsptrrec[] dnsptrrecArray = (dnsptrrec[]) dnsptrrec.getfiltered(service, option);
      return dnsptrrecArray != null && dnsptrrecArray.Length > 0 ? dnsptrrecArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      dnsptrrec dnsptrrec = new dnsptrrec();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnsptrrec[] dnsptrrecArray = (dnsptrrec[]) dnsptrrec.getfiltered(service, option);
      return dnsptrrecArray != null && dnsptrrecArray.Length > 0 ? dnsptrrecArray[0].__count.Value : 0U;
    }

    private class dnsptrrec_response : base_response
    {
      public dnsptrrec[] dnsptrrec = (dnsptrrec[]) null;
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
