// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.dns.dnstxtrec
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.dns
{
  public class dnstxtrec : base_resource
  {
    private string domainField = (string) null;
    private string[] StringField = (string[]) null;
    private long? ttlField = new long?();
    private uint? recordidField = new uint?();
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

    public string[] String
    {
      get => this.StringField;
      set => this.StringField = value;
    }

    public long? ttl
    {
      get => this.ttlField;
      set => this.ttlField = value;
    }

    public uint? recordid
    {
      get => this.recordidField;
      set => this.recordidField = value;
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
      dnstxtrec.dnstxtrec_response dnstxtrecResponse = new dnstxtrec.dnstxtrec_response();
      dnstxtrec.dnstxtrec_response resource = (dnstxtrec.dnstxtrec_response) service.get_payload_formatter().string_to_resource(dnstxtrecResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.dnstxtrec;
    }

    internal override string get_object_name() => this.domain;

    public static base_response add(nitro_service client, dnstxtrec resource) => new dnstxtrec()
    {
      domain = resource.domain,
      String = resource.String,
      ttl = resource.ttl
    }.add_resource(client);

    public static base_responses add(nitro_service client, dnstxtrec[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnstxtrec[] dnstxtrecArray = new dnstxtrec[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnstxtrecArray[index] = new dnstxtrec();
          dnstxtrecArray[index].domain = resources[index].domain;
          dnstxtrecArray[index].String = resources[index].String;
          dnstxtrecArray[index].ttl = resources[index].ttl;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) dnstxtrecArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string domain) => new dnstxtrec()
    {
      domain = domain
    }.delete_resource(client);

    public static base_response delete(nitro_service client, dnstxtrec resource) => new dnstxtrec()
    {
      domain = resource.domain,
      String = resource.String,
      recordid = resource.recordid
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] domain)
    {
      base_responses baseResponses = (base_responses) null;
      if (domain != null && domain.Length > 0)
      {
        dnstxtrec[] dnstxtrecArray = new dnstxtrec[domain.Length];
        for (int index = 0; index < domain.Length; ++index)
        {
          dnstxtrecArray[index] = new dnstxtrec();
          dnstxtrecArray[index].domain = domain[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dnstxtrecArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, dnstxtrec[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnstxtrec[] dnstxtrecArray = new dnstxtrec[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnstxtrecArray[index] = new dnstxtrec();
          dnstxtrecArray[index].domain = resources[index].domain;
          dnstxtrecArray[index].String = resources[index].String;
          dnstxtrecArray[index].recordid = resources[index].recordid;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dnstxtrecArray);
      }
      return baseResponses;
    }

    public static dnstxtrec[] get(nitro_service service) => (dnstxtrec[]) new dnstxtrec().get_resources(service, (options) null);

    public static dnstxtrec[] get(nitro_service service, options option) => (dnstxtrec[]) new dnstxtrec().get_resources(service, option);

    public static dnstxtrec[] get(nitro_service service, dnstxtrec_args args)
    {
      dnstxtrec dnstxtrec = new dnstxtrec();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (dnstxtrec[]) dnstxtrec.get_resources(service, option);
    }

    public static dnstxtrec get(nitro_service service, string domain) => (dnstxtrec) new dnstxtrec()
    {
      domain = domain
    }.get_resource(service);

    public static dnstxtrec[] get(nitro_service service, string[] domain)
    {
      if (domain == null || domain.Length <= 0)
        return (dnstxtrec[]) null;
      dnstxtrec[] dnstxtrecArray1 = new dnstxtrec[domain.Length];
      dnstxtrec[] dnstxtrecArray2 = new dnstxtrec[domain.Length];
      for (int index = 0; index < domain.Length; ++index)
      {
        dnstxtrecArray2[index] = new dnstxtrec();
        dnstxtrecArray2[index].domain = domain[index];
        dnstxtrecArray1[index] = (dnstxtrec) dnstxtrecArray2[index].get_resource(service);
      }
      return dnstxtrecArray1;
    }

    public static dnstxtrec[] get_filtered(nitro_service service, string filter)
    {
      dnstxtrec dnstxtrec = new dnstxtrec();
      options option = new options();
      option.set_filter(filter);
      return (dnstxtrec[]) dnstxtrec.getfiltered(service, option);
    }

    public static dnstxtrec[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      dnstxtrec dnstxtrec = new dnstxtrec();
      options option = new options();
      option.set_filter(filter);
      return (dnstxtrec[]) dnstxtrec.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      dnstxtrec dnstxtrec = new dnstxtrec();
      options option = new options();
      option.set_count(true);
      dnstxtrec[] resources = (dnstxtrec[]) dnstxtrec.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      dnstxtrec dnstxtrec = new dnstxtrec();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnstxtrec[] dnstxtrecArray = (dnstxtrec[]) dnstxtrec.getfiltered(service, option);
      return dnstxtrecArray != null && dnstxtrecArray.Length > 0 ? dnstxtrecArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      dnstxtrec dnstxtrec = new dnstxtrec();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnstxtrec[] dnstxtrecArray = (dnstxtrec[]) dnstxtrec.getfiltered(service, option);
      return dnstxtrecArray != null && dnstxtrecArray.Length > 0 ? dnstxtrecArray[0].__count.Value : 0U;
    }

    private class dnstxtrec_response : base_response
    {
      public dnstxtrec[] dnstxtrec = (dnstxtrec[]) null;
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
