// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.dns.dnssrvrec
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.dns
{
  public class dnssrvrec : base_resource
  {
    private string domainField = (string) null;
    private string targetField = (string) null;
    private uint? priorityField = new uint?();
    private uint? weightField = new uint?();
    private uint? portField = new uint?();
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

    public string target
    {
      get => this.targetField;
      set => this.targetField = value;
    }

    public uint? priority
    {
      get => this.priorityField;
      set => this.priorityField = value;
    }

    public uint? weight
    {
      get => this.weightField;
      set => this.weightField = value;
    }

    public uint? port
    {
      get => this.portField;
      set => this.portField = value;
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
      dnssrvrec.dnssrvrec_response dnssrvrecResponse = new dnssrvrec.dnssrvrec_response();
      dnssrvrec.dnssrvrec_response resource = (dnssrvrec.dnssrvrec_response) service.get_payload_formatter().string_to_resource(dnssrvrecResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.dnssrvrec;
    }

    internal override string get_object_name() => this.domain;

    public static base_response add(nitro_service client, dnssrvrec resource) => new dnssrvrec()
    {
      domain = resource.domain,
      target = resource.target,
      priority = resource.priority,
      weight = resource.weight,
      port = resource.port,
      ttl = resource.ttl
    }.add_resource(client);

    public static base_responses add(nitro_service client, dnssrvrec[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnssrvrec[] dnssrvrecArray = new dnssrvrec[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnssrvrecArray[index] = new dnssrvrec();
          dnssrvrecArray[index].domain = resources[index].domain;
          dnssrvrecArray[index].target = resources[index].target;
          dnssrvrecArray[index].priority = resources[index].priority;
          dnssrvrecArray[index].weight = resources[index].weight;
          dnssrvrecArray[index].port = resources[index].port;
          dnssrvrecArray[index].ttl = resources[index].ttl;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) dnssrvrecArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string domain) => new dnssrvrec()
    {
      domain = domain
    }.delete_resource(client);

    public static base_response delete(nitro_service client, dnssrvrec resource) => new dnssrvrec()
    {
      domain = resource.domain,
      target = resource.target
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] domain)
    {
      base_responses baseResponses = (base_responses) null;
      if (domain != null && domain.Length > 0)
      {
        dnssrvrec[] dnssrvrecArray = new dnssrvrec[domain.Length];
        for (int index = 0; index < domain.Length; ++index)
        {
          dnssrvrecArray[index] = new dnssrvrec();
          dnssrvrecArray[index].domain = domain[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dnssrvrecArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, dnssrvrec[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnssrvrec[] dnssrvrecArray = new dnssrvrec[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnssrvrecArray[index] = new dnssrvrec();
          dnssrvrecArray[index].domain = resources[index].domain;
          dnssrvrecArray[index].target = resources[index].target;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dnssrvrecArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, dnssrvrec resource) => new dnssrvrec()
    {
      domain = resource.domain,
      target = resource.target,
      priority = resource.priority,
      weight = resource.weight,
      port = resource.port,
      ttl = resource.ttl
    }.update_resource(client);

    public static base_responses update(nitro_service client, dnssrvrec[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnssrvrec[] dnssrvrecArray = new dnssrvrec[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnssrvrecArray[index] = new dnssrvrec();
          dnssrvrecArray[index].domain = resources[index].domain;
          dnssrvrecArray[index].target = resources[index].target;
          dnssrvrecArray[index].priority = resources[index].priority;
          dnssrvrecArray[index].weight = resources[index].weight;
          dnssrvrecArray[index].port = resources[index].port;
          dnssrvrecArray[index].ttl = resources[index].ttl;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) dnssrvrecArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      dnssrvrec resource,
      string[] args)
    {
      return new dnssrvrec()
      {
        domain = resource.domain,
        target = resource.target
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      dnssrvrec[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnssrvrec[] dnssrvrecArray = new dnssrvrec[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnssrvrecArray[index] = new dnssrvrec();
          dnssrvrecArray[index].domain = resources[index].domain;
          dnssrvrecArray[index].target = resources[index].target;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) dnssrvrecArray, args);
      }
      return baseResponses;
    }

    public static dnssrvrec[] get(nitro_service service) => (dnssrvrec[]) new dnssrvrec().get_resources(service, (options) null);

    public static dnssrvrec[] get(nitro_service service, options option) => (dnssrvrec[]) new dnssrvrec().get_resources(service, option);

    public static dnssrvrec get(nitro_service service, dnssrvrec obj)
    {
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (dnssrvrec) obj.get_resource(service, option);
    }

    public static dnssrvrec[] get(nitro_service service, dnssrvrec[] obj)
    {
      if (obj == null || obj.Length <= 0)
        return (dnssrvrec[]) null;
      dnssrvrec[] dnssrvrecArray = new dnssrvrec[obj.Length];
      for (int index = 0; index < obj.Length; ++index)
      {
        options option = new options();
        option.set_args(nitro_util.object_to_string_withoutquotes((object) obj[index]));
        dnssrvrecArray[index] = (dnssrvrec) obj[index].get_resource(service, option);
      }
      return dnssrvrecArray;
    }

    public static dnssrvrec[] get(nitro_service service, dnssrvrec_args args)
    {
      dnssrvrec dnssrvrec = new dnssrvrec();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (dnssrvrec[]) dnssrvrec.get_resources(service, option);
    }

    public static dnssrvrec[] get_filtered(nitro_service service, string filter)
    {
      dnssrvrec dnssrvrec = new dnssrvrec();
      options option = new options();
      option.set_filter(filter);
      return (dnssrvrec[]) dnssrvrec.getfiltered(service, option);
    }

    public static dnssrvrec[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      dnssrvrec dnssrvrec = new dnssrvrec();
      options option = new options();
      option.set_filter(filter);
      return (dnssrvrec[]) dnssrvrec.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      dnssrvrec dnssrvrec = new dnssrvrec();
      options option = new options();
      option.set_count(true);
      dnssrvrec[] resources = (dnssrvrec[]) dnssrvrec.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      dnssrvrec dnssrvrec = new dnssrvrec();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnssrvrec[] dnssrvrecArray = (dnssrvrec[]) dnssrvrec.getfiltered(service, option);
      return dnssrvrecArray != null && dnssrvrecArray.Length > 0 ? dnssrvrecArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      dnssrvrec dnssrvrec = new dnssrvrec();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnssrvrec[] dnssrvrecArray = (dnssrvrec[]) dnssrvrec.getfiltered(service, option);
      return dnssrvrecArray != null && dnssrvrecArray.Length > 0 ? dnssrvrecArray[0].__count.Value : 0U;
    }

    private class dnssrvrec_response : base_response
    {
      public dnssrvrec[] dnssrvrec = (dnssrvrec[]) null;
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
