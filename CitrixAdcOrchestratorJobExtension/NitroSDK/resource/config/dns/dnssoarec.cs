// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.dns.dnssoarec
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.dns
{
  public class dnssoarec : base_resource
  {
    private string domainField = (string) null;
    private string originserverField = (string) null;
    private string contactField = (string) null;
    private uint? serialField = new uint?();
    private long? refreshField = new long?();
    private long? retryField = new long?();
    private long? expireField = new long?();
    private long? minimumField = new long?();
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

    public string originserver
    {
      get => this.originserverField;
      set => this.originserverField = value;
    }

    public string contact
    {
      get => this.contactField;
      set => this.contactField = value;
    }

    public uint? serial
    {
      get => this.serialField;
      set => this.serialField = value;
    }

    public long? refresh
    {
      get => this.refreshField;
      set => this.refreshField = value;
    }

    public long? retry
    {
      get => this.retryField;
      set => this.retryField = value;
    }

    public long? expire
    {
      get => this.expireField;
      set => this.expireField = value;
    }

    public long? minimum
    {
      get => this.minimumField;
      set => this.minimumField = value;
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
      dnssoarec.dnssoarec_response dnssoarecResponse = new dnssoarec.dnssoarec_response();
      dnssoarec.dnssoarec_response resource = (dnssoarec.dnssoarec_response) service.get_payload_formatter().string_to_resource(dnssoarecResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.dnssoarec;
    }

    internal override string get_object_name() => this.domain;

    public static base_response add(nitro_service client, dnssoarec resource) => new dnssoarec()
    {
      domain = resource.domain,
      originserver = resource.originserver,
      contact = resource.contact,
      serial = resource.serial,
      refresh = resource.refresh,
      retry = resource.retry,
      expire = resource.expire,
      minimum = resource.minimum,
      ttl = resource.ttl
    }.add_resource(client);

    public static base_responses add(nitro_service client, dnssoarec[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnssoarec[] dnssoarecArray = new dnssoarec[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnssoarecArray[index] = new dnssoarec();
          dnssoarecArray[index].domain = resources[index].domain;
          dnssoarecArray[index].originserver = resources[index].originserver;
          dnssoarecArray[index].contact = resources[index].contact;
          dnssoarecArray[index].serial = resources[index].serial;
          dnssoarecArray[index].refresh = resources[index].refresh;
          dnssoarecArray[index].retry = resources[index].retry;
          dnssoarecArray[index].expire = resources[index].expire;
          dnssoarecArray[index].minimum = resources[index].minimum;
          dnssoarecArray[index].ttl = resources[index].ttl;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) dnssoarecArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string domain) => new dnssoarec()
    {
      domain = domain
    }.delete_resource(client);

    public static base_response delete(nitro_service client, dnssoarec resource) => new dnssoarec()
    {
      domain = resource.domain
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] domain)
    {
      base_responses baseResponses = (base_responses) null;
      if (domain != null && domain.Length > 0)
      {
        dnssoarec[] dnssoarecArray = new dnssoarec[domain.Length];
        for (int index = 0; index < domain.Length; ++index)
        {
          dnssoarecArray[index] = new dnssoarec();
          dnssoarecArray[index].domain = domain[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dnssoarecArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, dnssoarec[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnssoarec[] dnssoarecArray = new dnssoarec[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnssoarecArray[index] = new dnssoarec();
          dnssoarecArray[index].domain = resources[index].domain;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dnssoarecArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, dnssoarec resource) => new dnssoarec()
    {
      domain = resource.domain,
      originserver = resource.originserver,
      contact = resource.contact,
      serial = resource.serial,
      refresh = resource.refresh,
      retry = resource.retry,
      expire = resource.expire,
      minimum = resource.minimum,
      ttl = resource.ttl
    }.update_resource(client);

    public static base_responses update(nitro_service client, dnssoarec[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnssoarec[] dnssoarecArray = new dnssoarec[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnssoarecArray[index] = new dnssoarec();
          dnssoarecArray[index].domain = resources[index].domain;
          dnssoarecArray[index].originserver = resources[index].originserver;
          dnssoarecArray[index].contact = resources[index].contact;
          dnssoarecArray[index].serial = resources[index].serial;
          dnssoarecArray[index].refresh = resources[index].refresh;
          dnssoarecArray[index].retry = resources[index].retry;
          dnssoarecArray[index].expire = resources[index].expire;
          dnssoarecArray[index].minimum = resources[index].minimum;
          dnssoarecArray[index].ttl = resources[index].ttl;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) dnssoarecArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string domain,
      string[] args)
    {
      return new dnssoarec() { domain = domain }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      dnssoarec resource,
      string[] args)
    {
      return new dnssoarec() { domain = resource.domain }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] domain,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (domain != null && domain.Length > 0)
      {
        dnssoarec[] dnssoarecArray = new dnssoarec[domain.Length];
        for (int index = 0; index < domain.Length; ++index)
        {
          dnssoarecArray[index] = new dnssoarec();
          dnssoarecArray[index].domain = domain[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) dnssoarecArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      dnssoarec[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnssoarec[] dnssoarecArray = new dnssoarec[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnssoarecArray[index] = new dnssoarec();
          dnssoarecArray[index].domain = resources[index].domain;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) dnssoarecArray, args);
      }
      return baseResponses;
    }

    public static dnssoarec[] get(nitro_service service) => (dnssoarec[]) new dnssoarec().get_resources(service, (options) null);

    public static dnssoarec[] get(nitro_service service, options option) => (dnssoarec[]) new dnssoarec().get_resources(service, option);

    public static dnssoarec[] get(nitro_service service, dnssoarec_args args)
    {
      dnssoarec dnssoarec = new dnssoarec();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (dnssoarec[]) dnssoarec.get_resources(service, option);
    }

    public static dnssoarec get(nitro_service service, string domain) => (dnssoarec) new dnssoarec()
    {
      domain = domain
    }.get_resource(service);

    public static dnssoarec[] get(nitro_service service, string[] domain)
    {
      if (domain == null || domain.Length <= 0)
        return (dnssoarec[]) null;
      dnssoarec[] dnssoarecArray1 = new dnssoarec[domain.Length];
      dnssoarec[] dnssoarecArray2 = new dnssoarec[domain.Length];
      for (int index = 0; index < domain.Length; ++index)
      {
        dnssoarecArray2[index] = new dnssoarec();
        dnssoarecArray2[index].domain = domain[index];
        dnssoarecArray1[index] = (dnssoarec) dnssoarecArray2[index].get_resource(service);
      }
      return dnssoarecArray1;
    }

    public static dnssoarec[] get_filtered(nitro_service service, string filter)
    {
      dnssoarec dnssoarec = new dnssoarec();
      options option = new options();
      option.set_filter(filter);
      return (dnssoarec[]) dnssoarec.getfiltered(service, option);
    }

    public static dnssoarec[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      dnssoarec dnssoarec = new dnssoarec();
      options option = new options();
      option.set_filter(filter);
      return (dnssoarec[]) dnssoarec.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      dnssoarec dnssoarec = new dnssoarec();
      options option = new options();
      option.set_count(true);
      dnssoarec[] resources = (dnssoarec[]) dnssoarec.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      dnssoarec dnssoarec = new dnssoarec();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnssoarec[] dnssoarecArray = (dnssoarec[]) dnssoarec.getfiltered(service, option);
      return dnssoarecArray != null && dnssoarecArray.Length > 0 ? dnssoarecArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      dnssoarec dnssoarec = new dnssoarec();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnssoarec[] dnssoarecArray = (dnssoarec[]) dnssoarec.getfiltered(service, option);
      return dnssoarecArray != null && dnssoarecArray.Length > 0 ? dnssoarecArray[0].__count.Value : 0U;
    }

    private class dnssoarec_response : base_response
    {
      public dnssoarec[] dnssoarec = (dnssoarec[]) null;
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
