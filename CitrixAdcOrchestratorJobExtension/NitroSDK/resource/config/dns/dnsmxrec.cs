// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.dns.dnsmxrec
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.dns
{
  public class dnsmxrec : base_resource
  {
    private string domainField = (string) null;
    private string mxField = (string) null;
    private uint? prefField = new uint?();
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

    public string mx
    {
      get => this.mxField;
      set => this.mxField = value;
    }

    public uint? pref
    {
      get => this.prefField;
      set => this.prefField = value;
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
      dnsmxrec.dnsmxrec_response dnsmxrecResponse = new dnsmxrec.dnsmxrec_response();
      dnsmxrec.dnsmxrec_response resource = (dnsmxrec.dnsmxrec_response) service.get_payload_formatter().string_to_resource(dnsmxrecResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.dnsmxrec;
    }

    internal override string get_object_name() => this.domain;

    public static base_response add(nitro_service client, dnsmxrec resource) => new dnsmxrec()
    {
      domain = resource.domain,
      mx = resource.mx,
      pref = resource.pref,
      ttl = resource.ttl
    }.add_resource(client);

    public static base_responses add(nitro_service client, dnsmxrec[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnsmxrec[] dnsmxrecArray = new dnsmxrec[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnsmxrecArray[index] = new dnsmxrec();
          dnsmxrecArray[index].domain = resources[index].domain;
          dnsmxrecArray[index].mx = resources[index].mx;
          dnsmxrecArray[index].pref = resources[index].pref;
          dnsmxrecArray[index].ttl = resources[index].ttl;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) dnsmxrecArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string domain) => new dnsmxrec()
    {
      domain = domain
    }.delete_resource(client);

    public static base_response delete(nitro_service client, dnsmxrec resource) => new dnsmxrec()
    {
      domain = resource.domain,
      mx = resource.mx
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] domain)
    {
      base_responses baseResponses = (base_responses) null;
      if (domain != null && domain.Length > 0)
      {
        dnsmxrec[] dnsmxrecArray = new dnsmxrec[domain.Length];
        for (int index = 0; index < domain.Length; ++index)
        {
          dnsmxrecArray[index] = new dnsmxrec();
          dnsmxrecArray[index].domain = domain[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dnsmxrecArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, dnsmxrec[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnsmxrec[] dnsmxrecArray = new dnsmxrec[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnsmxrecArray[index] = new dnsmxrec();
          dnsmxrecArray[index].domain = resources[index].domain;
          dnsmxrecArray[index].mx = resources[index].mx;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dnsmxrecArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, dnsmxrec resource) => new dnsmxrec()
    {
      domain = resource.domain,
      mx = resource.mx,
      pref = resource.pref,
      ttl = resource.ttl
    }.update_resource(client);

    public static base_responses update(nitro_service client, dnsmxrec[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnsmxrec[] dnsmxrecArray = new dnsmxrec[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnsmxrecArray[index] = new dnsmxrec();
          dnsmxrecArray[index].domain = resources[index].domain;
          dnsmxrecArray[index].mx = resources[index].mx;
          dnsmxrecArray[index].pref = resources[index].pref;
          dnsmxrecArray[index].ttl = resources[index].ttl;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) dnsmxrecArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      dnsmxrec resource,
      string[] args)
    {
      return new dnsmxrec()
      {
        domain = resource.domain,
        mx = resource.mx
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      dnsmxrec[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnsmxrec[] dnsmxrecArray = new dnsmxrec[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnsmxrecArray[index] = new dnsmxrec();
          dnsmxrecArray[index].domain = resources[index].domain;
          dnsmxrecArray[index].mx = resources[index].mx;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) dnsmxrecArray, args);
      }
      return baseResponses;
    }

    public static dnsmxrec[] get(nitro_service service) => (dnsmxrec[]) new dnsmxrec().get_resources(service, (options) null);

    public static dnsmxrec[] get(nitro_service service, options option) => (dnsmxrec[]) new dnsmxrec().get_resources(service, option);

    public static dnsmxrec[] get(nitro_service service, dnsmxrec_args args)
    {
      dnsmxrec dnsmxrec = new dnsmxrec();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (dnsmxrec[]) dnsmxrec.get_resources(service, option);
    }

    public static dnsmxrec get(nitro_service service, string domain) => (dnsmxrec) new dnsmxrec()
    {
      domain = domain
    }.get_resource(service);

    public static dnsmxrec[] get(nitro_service service, string[] domain)
    {
      if (domain == null || domain.Length <= 0)
        return (dnsmxrec[]) null;
      dnsmxrec[] dnsmxrecArray1 = new dnsmxrec[domain.Length];
      dnsmxrec[] dnsmxrecArray2 = new dnsmxrec[domain.Length];
      for (int index = 0; index < domain.Length; ++index)
      {
        dnsmxrecArray2[index] = new dnsmxrec();
        dnsmxrecArray2[index].domain = domain[index];
        dnsmxrecArray1[index] = (dnsmxrec) dnsmxrecArray2[index].get_resource(service);
      }
      return dnsmxrecArray1;
    }

    public static dnsmxrec[] get_filtered(nitro_service service, string filter)
    {
      dnsmxrec dnsmxrec = new dnsmxrec();
      options option = new options();
      option.set_filter(filter);
      return (dnsmxrec[]) dnsmxrec.getfiltered(service, option);
    }

    public static dnsmxrec[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      dnsmxrec dnsmxrec = new dnsmxrec();
      options option = new options();
      option.set_filter(filter);
      return (dnsmxrec[]) dnsmxrec.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      dnsmxrec dnsmxrec = new dnsmxrec();
      options option = new options();
      option.set_count(true);
      dnsmxrec[] resources = (dnsmxrec[]) dnsmxrec.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      dnsmxrec dnsmxrec = new dnsmxrec();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnsmxrec[] dnsmxrecArray = (dnsmxrec[]) dnsmxrec.getfiltered(service, option);
      return dnsmxrecArray != null && dnsmxrecArray.Length > 0 ? dnsmxrecArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      dnsmxrec dnsmxrec = new dnsmxrec();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnsmxrec[] dnsmxrecArray = (dnsmxrec[]) dnsmxrec.getfiltered(service, option);
      return dnsmxrecArray != null && dnsmxrecArray.Length > 0 ? dnsmxrecArray[0].__count.Value : 0U;
    }

    private class dnsmxrec_response : base_response
    {
      public dnsmxrec[] dnsmxrec = (dnsmxrec[]) null;
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
