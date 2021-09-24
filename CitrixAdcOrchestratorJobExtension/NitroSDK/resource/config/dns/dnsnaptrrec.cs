// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.dns.dnsnaptrrec
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.dns
{
  public class dnsnaptrrec : base_resource
  {
    private string domainField = (string) null;
    private uint? orderField = new uint?();
    private uint? preferenceField = new uint?();
    private string flagsField = (string) null;
    private string servicesField = (string) null;
    private string regexpField = (string) null;
    private string replacementField = (string) null;
    private long? ttlField = new long?();
    private uint? recordidField = new uint?();
    private string typeField = (string) null;
    private string authtypeField = (string) null;
    private string vservernameField = (string) null;
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

    public uint? order
    {
      get => this.orderField;
      set => this.orderField = value;
    }

    public uint? preference
    {
      get => this.preferenceField;
      set => this.preferenceField = value;
    }

    public string flags
    {
      get => this.flagsField;
      set => this.flagsField = value;
    }

    public string services
    {
      get => this.servicesField;
      set => this.servicesField = value;
    }

    public string regexp
    {
      get => this.regexpField;
      set => this.regexpField = value;
    }

    public string replacement
    {
      get => this.replacementField;
      set => this.replacementField = value;
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

    public string vservername
    {
      get => this.vservernameField;
      private set => this.vservernameField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      dnsnaptrrec.dnsnaptrrec_response dnsnaptrrecResponse = new dnsnaptrrec.dnsnaptrrec_response();
      dnsnaptrrec.dnsnaptrrec_response resource = (dnsnaptrrec.dnsnaptrrec_response) service.get_payload_formatter().string_to_resource(dnsnaptrrecResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.dnsnaptrrec;
    }

    internal override string get_object_name() => this.domain;

    public static base_response add(nitro_service client, dnsnaptrrec resource) => new dnsnaptrrec()
    {
      domain = resource.domain,
      order = resource.order,
      preference = resource.preference,
      flags = resource.flags,
      services = resource.services,
      regexp = resource.regexp,
      replacement = resource.replacement,
      ttl = resource.ttl
    }.add_resource(client);

    public static base_responses add(nitro_service client, dnsnaptrrec[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnsnaptrrec[] dnsnaptrrecArray = new dnsnaptrrec[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnsnaptrrecArray[index] = new dnsnaptrrec();
          dnsnaptrrecArray[index].domain = resources[index].domain;
          dnsnaptrrecArray[index].order = resources[index].order;
          dnsnaptrrecArray[index].preference = resources[index].preference;
          dnsnaptrrecArray[index].flags = resources[index].flags;
          dnsnaptrrecArray[index].services = resources[index].services;
          dnsnaptrrecArray[index].regexp = resources[index].regexp;
          dnsnaptrrecArray[index].replacement = resources[index].replacement;
          dnsnaptrrecArray[index].ttl = resources[index].ttl;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) dnsnaptrrecArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string domain) => new dnsnaptrrec()
    {
      domain = domain
    }.delete_resource(client);

    public static base_response delete(nitro_service client, dnsnaptrrec resource) => new dnsnaptrrec()
    {
      domain = resource.domain,
      order = resource.order,
      recordid = resource.recordid,
      preference = resource.preference,
      flags = resource.flags,
      services = resource.services,
      regexp = resource.regexp,
      replacement = resource.replacement
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] domain)
    {
      base_responses baseResponses = (base_responses) null;
      if (domain != null && domain.Length > 0)
      {
        dnsnaptrrec[] dnsnaptrrecArray = new dnsnaptrrec[domain.Length];
        for (int index = 0; index < domain.Length; ++index)
        {
          dnsnaptrrecArray[index] = new dnsnaptrrec();
          dnsnaptrrecArray[index].domain = domain[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dnsnaptrrecArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, dnsnaptrrec[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnsnaptrrec[] dnsnaptrrecArray = new dnsnaptrrec[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnsnaptrrecArray[index] = new dnsnaptrrec();
          dnsnaptrrecArray[index].domain = resources[index].domain;
          dnsnaptrrecArray[index].order = resources[index].order;
          dnsnaptrrecArray[index].recordid = resources[index].recordid;
          dnsnaptrrecArray[index].preference = resources[index].preference;
          dnsnaptrrecArray[index].flags = resources[index].flags;
          dnsnaptrrecArray[index].services = resources[index].services;
          dnsnaptrrecArray[index].regexp = resources[index].regexp;
          dnsnaptrrecArray[index].replacement = resources[index].replacement;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dnsnaptrrecArray);
      }
      return baseResponses;
    }

    public static dnsnaptrrec[] get(nitro_service service) => (dnsnaptrrec[]) new dnsnaptrrec().get_resources(service, (options) null);

    public static dnsnaptrrec[] get(nitro_service service, options option) => (dnsnaptrrec[]) new dnsnaptrrec().get_resources(service, option);

    public static dnsnaptrrec[] get(nitro_service service, dnsnaptrrec_args args)
    {
      dnsnaptrrec dnsnaptrrec = new dnsnaptrrec();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (dnsnaptrrec[]) dnsnaptrrec.get_resources(service, option);
    }

    public static dnsnaptrrec get(nitro_service service, string domain) => (dnsnaptrrec) new dnsnaptrrec()
    {
      domain = domain
    }.get_resource(service);

    public static dnsnaptrrec[] get(nitro_service service, string[] domain)
    {
      if (domain == null || domain.Length <= 0)
        return (dnsnaptrrec[]) null;
      dnsnaptrrec[] dnsnaptrrecArray1 = new dnsnaptrrec[domain.Length];
      dnsnaptrrec[] dnsnaptrrecArray2 = new dnsnaptrrec[domain.Length];
      for (int index = 0; index < domain.Length; ++index)
      {
        dnsnaptrrecArray2[index] = new dnsnaptrrec();
        dnsnaptrrecArray2[index].domain = domain[index];
        dnsnaptrrecArray1[index] = (dnsnaptrrec) dnsnaptrrecArray2[index].get_resource(service);
      }
      return dnsnaptrrecArray1;
    }

    public static dnsnaptrrec[] get_filtered(nitro_service service, string filter)
    {
      dnsnaptrrec dnsnaptrrec = new dnsnaptrrec();
      options option = new options();
      option.set_filter(filter);
      return (dnsnaptrrec[]) dnsnaptrrec.getfiltered(service, option);
    }

    public static dnsnaptrrec[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      dnsnaptrrec dnsnaptrrec = new dnsnaptrrec();
      options option = new options();
      option.set_filter(filter);
      return (dnsnaptrrec[]) dnsnaptrrec.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      dnsnaptrrec dnsnaptrrec = new dnsnaptrrec();
      options option = new options();
      option.set_count(true);
      dnsnaptrrec[] resources = (dnsnaptrrec[]) dnsnaptrrec.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      dnsnaptrrec dnsnaptrrec = new dnsnaptrrec();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnsnaptrrec[] dnsnaptrrecArray = (dnsnaptrrec[]) dnsnaptrrec.getfiltered(service, option);
      return dnsnaptrrecArray != null && dnsnaptrrecArray.Length > 0 ? dnsnaptrrecArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      dnsnaptrrec dnsnaptrrec = new dnsnaptrrec();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnsnaptrrec[] dnsnaptrrecArray = (dnsnaptrrec[]) dnsnaptrrec.getfiltered(service, option);
      return dnsnaptrrecArray != null && dnsnaptrrecArray.Length > 0 ? dnsnaptrrecArray[0].__count.Value : 0U;
    }

    private class dnsnaptrrec_response : base_response
    {
      public dnsnaptrrec[] dnsnaptrrec = (dnsnaptrrec[]) null;
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
