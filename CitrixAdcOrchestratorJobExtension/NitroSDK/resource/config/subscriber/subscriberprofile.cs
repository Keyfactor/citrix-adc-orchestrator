// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.subscriber.subscriberprofile
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.subscriber
{
  public class subscriberprofile : base_resource
  {
    private string ipField = (string) null;
    private string[] subscriberrulesField = (string[]) null;
    private string subscriptionidtypeField = (string) null;
    private string subscriptionidvalueField = (string) null;
    private string servicepathField = (string) null;
    private uint? flagsField = new uint?();
    private uint? ttlField = new uint?();
    private string avpdisplaybufferField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string ip
    {
      get => this.ipField;
      set => this.ipField = value;
    }

    public string[] subscriberrules
    {
      get => this.subscriberrulesField;
      set => this.subscriberrulesField = value;
    }

    public string subscriptionidtype
    {
      get => this.subscriptionidtypeField;
      set => this.subscriptionidtypeField = value;
    }

    public string subscriptionidvalue
    {
      get => this.subscriptionidvalueField;
      set => this.subscriptionidvalueField = value;
    }

    public string servicepath
    {
      get => this.servicepathField;
      set => this.servicepathField = value;
    }

    public uint? flags
    {
      get => this.flagsField;
      private set => this.flagsField = value;
    }

    public uint? ttl
    {
      get => this.ttlField;
      private set => this.ttlField = value;
    }

    public string avpdisplaybuffer
    {
      get => this.avpdisplaybufferField;
      private set => this.avpdisplaybufferField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      subscriberprofile.subscriberprofile_response subscriberprofileResponse = new subscriberprofile.subscriberprofile_response();
      subscriberprofile.subscriberprofile_response resource = (subscriberprofile.subscriberprofile_response) service.get_payload_formatter().string_to_resource(subscriberprofileResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.subscriberprofile;
    }

    internal override string get_object_name() => this.ip;

    public static base_response add(nitro_service client, subscriberprofile resource) => new subscriberprofile()
    {
      ip = resource.ip,
      subscriberrules = resource.subscriberrules,
      subscriptionidtype = resource.subscriptionidtype,
      subscriptionidvalue = resource.subscriptionidvalue,
      servicepath = resource.servicepath
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      subscriberprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        subscriberprofile[] subscriberprofileArray = new subscriberprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          subscriberprofileArray[index] = new subscriberprofile();
          subscriberprofileArray[index].ip = resources[index].ip;
          subscriberprofileArray[index].subscriberrules = resources[index].subscriberrules;
          subscriberprofileArray[index].subscriptionidtype = resources[index].subscriptionidtype;
          subscriberprofileArray[index].subscriptionidvalue = resources[index].subscriptionidvalue;
          subscriberprofileArray[index].servicepath = resources[index].servicepath;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) subscriberprofileArray);
      }
      return baseResponses;
    }

    public static base_response update(
      nitro_service client,
      subscriberprofile resource)
    {
      return new subscriberprofile()
      {
        ip = resource.ip,
        subscriberrules = resource.subscriberrules,
        subscriptionidtype = resource.subscriptionidtype,
        subscriptionidvalue = resource.subscriptionidvalue,
        servicepath = resource.servicepath
      }.update_resource(client);
    }

    public static base_responses update(
      nitro_service client,
      subscriberprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        subscriberprofile[] subscriberprofileArray = new subscriberprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          subscriberprofileArray[index] = new subscriberprofile();
          subscriberprofileArray[index].ip = resources[index].ip;
          subscriberprofileArray[index].subscriberrules = resources[index].subscriberrules;
          subscriberprofileArray[index].subscriptionidtype = resources[index].subscriptionidtype;
          subscriberprofileArray[index].subscriptionidvalue = resources[index].subscriptionidvalue;
          subscriberprofileArray[index].servicepath = resources[index].servicepath;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) subscriberprofileArray);
      }
      return baseResponses;
    }

    public static base_response unset(nitro_service client, string ip, string[] args) => new subscriberprofile()
    {
      ip = ip
    }.unset_resource(client, args);

    public static base_response unset(
      nitro_service client,
      subscriberprofile resource,
      string[] args)
    {
      return new subscriberprofile() { ip = resource.ip }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] ip,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (ip != null && ip.Length > 0)
      {
        subscriberprofile[] subscriberprofileArray = new subscriberprofile[ip.Length];
        for (int index = 0; index < ip.Length; ++index)
        {
          subscriberprofileArray[index] = new subscriberprofile();
          subscriberprofileArray[index].ip = ip[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) subscriberprofileArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      subscriberprofile[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        subscriberprofile[] subscriberprofileArray = new subscriberprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          subscriberprofileArray[index] = new subscriberprofile();
          subscriberprofileArray[index].ip = resources[index].ip;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) subscriberprofileArray, args);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string ip) => new subscriberprofile()
    {
      ip = ip
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      subscriberprofile resource)
    {
      return new subscriberprofile() { ip = resource.ip }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] ip)
    {
      base_responses baseResponses = (base_responses) null;
      if (ip != null && ip.Length > 0)
      {
        subscriberprofile[] subscriberprofileArray = new subscriberprofile[ip.Length];
        for (int index = 0; index < ip.Length; ++index)
        {
          subscriberprofileArray[index] = new subscriberprofile();
          subscriberprofileArray[index].ip = ip[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) subscriberprofileArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      subscriberprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        subscriberprofile[] subscriberprofileArray = new subscriberprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          subscriberprofileArray[index] = new subscriberprofile();
          subscriberprofileArray[index].ip = resources[index].ip;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) subscriberprofileArray);
      }
      return baseResponses;
    }

    public static subscriberprofile[] get(nitro_service service) => (subscriberprofile[]) new subscriberprofile().get_resources(service, (options) null);

    public static subscriberprofile[] get(nitro_service service, options option) => (subscriberprofile[]) new subscriberprofile().get_resources(service, option);

    public static subscriberprofile get(nitro_service service, string ip) => (subscriberprofile) new subscriberprofile()
    {
      ip = ip
    }.get_resource(service);

    public static subscriberprofile[] get(nitro_service service, string[] ip)
    {
      if (ip == null || ip.Length <= 0)
        return (subscriberprofile[]) null;
      subscriberprofile[] subscriberprofileArray1 = new subscriberprofile[ip.Length];
      subscriberprofile[] subscriberprofileArray2 = new subscriberprofile[ip.Length];
      for (int index = 0; index < ip.Length; ++index)
      {
        subscriberprofileArray2[index] = new subscriberprofile();
        subscriberprofileArray2[index].ip = ip[index];
        subscriberprofileArray1[index] = (subscriberprofile) subscriberprofileArray2[index].get_resource(service);
      }
      return subscriberprofileArray1;
    }

    public static subscriberprofile[] get_filtered(
      nitro_service service,
      string filter)
    {
      subscriberprofile subscriberprofile = new subscriberprofile();
      options option = new options();
      option.set_filter(filter);
      return (subscriberprofile[]) subscriberprofile.getfiltered(service, option);
    }

    public static subscriberprofile[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      subscriberprofile subscriberprofile = new subscriberprofile();
      options option = new options();
      option.set_filter(filter);
      return (subscriberprofile[]) subscriberprofile.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      subscriberprofile subscriberprofile = new subscriberprofile();
      options option = new options();
      option.set_count(true);
      subscriberprofile[] resources = (subscriberprofile[]) subscriberprofile.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      subscriberprofile subscriberprofile = new subscriberprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      subscriberprofile[] subscriberprofileArray = (subscriberprofile[]) subscriberprofile.getfiltered(service, option);
      return subscriberprofileArray != null && subscriberprofileArray.Length > 0 ? subscriberprofileArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      subscriberprofile subscriberprofile = new subscriberprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      subscriberprofile[] subscriberprofileArray = (subscriberprofile[]) subscriberprofile.getfiltered(service, option);
      return subscriberprofileArray != null && subscriberprofileArray.Length > 0 ? subscriberprofileArray[0].__count.Value : 0U;
    }

    private class subscriberprofile_response : base_response
    {
      public subscriberprofile[] subscriberprofile = (subscriberprofile[]) null;
    }

    public static class subscriptionidtypeEnum
    {
      public const string E164 = "E164";
      public const string IMSI = "IMSI";
      public const string SIP_URI = "SIP_URI";
      public const string NAI = "NAI";
      public const string PRIVATE = "PRIVATE";
    }
  }
}
