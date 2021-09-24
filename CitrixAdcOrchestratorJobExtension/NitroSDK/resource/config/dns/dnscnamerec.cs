// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.dns.dnscnamerec
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.dns
{
  public class dnscnamerec : base_resource
  {
    private string aliasnameField = (string) null;
    private string canonicalnameField = (string) null;
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

    public string aliasname
    {
      get => this.aliasnameField;
      set => this.aliasnameField = value;
    }

    public string canonicalname
    {
      get => this.canonicalnameField;
      set => this.canonicalnameField = value;
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
      dnscnamerec.dnscnamerec_response dnscnamerecResponse = new dnscnamerec.dnscnamerec_response();
      dnscnamerec.dnscnamerec_response resource = (dnscnamerec.dnscnamerec_response) service.get_payload_formatter().string_to_resource(dnscnamerecResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.dnscnamerec;
    }

    internal override string get_object_name() => this.aliasname;

    public static base_response add(nitro_service client, dnscnamerec resource) => new dnscnamerec()
    {
      aliasname = resource.aliasname,
      canonicalname = resource.canonicalname,
      ttl = resource.ttl
    }.add_resource(client);

    public static base_responses add(nitro_service client, dnscnamerec[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnscnamerec[] dnscnamerecArray = new dnscnamerec[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnscnamerecArray[index] = new dnscnamerec();
          dnscnamerecArray[index].aliasname = resources[index].aliasname;
          dnscnamerecArray[index].canonicalname = resources[index].canonicalname;
          dnscnamerecArray[index].ttl = resources[index].ttl;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) dnscnamerecArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string aliasname) => new dnscnamerec()
    {
      aliasname = aliasname
    }.delete_resource(client);

    public static base_response delete(nitro_service client, dnscnamerec resource) => new dnscnamerec()
    {
      aliasname = resource.aliasname
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] aliasname)
    {
      base_responses baseResponses = (base_responses) null;
      if (aliasname != null && aliasname.Length > 0)
      {
        dnscnamerec[] dnscnamerecArray = new dnscnamerec[aliasname.Length];
        for (int index = 0; index < aliasname.Length; ++index)
        {
          dnscnamerecArray[index] = new dnscnamerec();
          dnscnamerecArray[index].aliasname = aliasname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dnscnamerecArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, dnscnamerec[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        dnscnamerec[] dnscnamerecArray = new dnscnamerec[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          dnscnamerecArray[index] = new dnscnamerec();
          dnscnamerecArray[index].aliasname = resources[index].aliasname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) dnscnamerecArray);
      }
      return baseResponses;
    }

    public static dnscnamerec[] get(nitro_service service) => (dnscnamerec[]) new dnscnamerec().get_resources(service, (options) null);

    public static dnscnamerec[] get(nitro_service service, options option) => (dnscnamerec[]) new dnscnamerec().get_resources(service, option);

    public static dnscnamerec[] get(nitro_service service, dnscnamerec_args args)
    {
      dnscnamerec dnscnamerec = new dnscnamerec();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (dnscnamerec[]) dnscnamerec.get_resources(service, option);
    }

    public static dnscnamerec get(nitro_service service, string aliasname) => (dnscnamerec) new dnscnamerec()
    {
      aliasname = aliasname
    }.get_resource(service);

    public static dnscnamerec[] get(nitro_service service, string[] aliasname)
    {
      if (aliasname == null || aliasname.Length <= 0)
        return (dnscnamerec[]) null;
      dnscnamerec[] dnscnamerecArray1 = new dnscnamerec[aliasname.Length];
      dnscnamerec[] dnscnamerecArray2 = new dnscnamerec[aliasname.Length];
      for (int index = 0; index < aliasname.Length; ++index)
      {
        dnscnamerecArray2[index] = new dnscnamerec();
        dnscnamerecArray2[index].aliasname = aliasname[index];
        dnscnamerecArray1[index] = (dnscnamerec) dnscnamerecArray2[index].get_resource(service);
      }
      return dnscnamerecArray1;
    }

    public static dnscnamerec[] get_filtered(nitro_service service, string filter)
    {
      dnscnamerec dnscnamerec = new dnscnamerec();
      options option = new options();
      option.set_filter(filter);
      return (dnscnamerec[]) dnscnamerec.getfiltered(service, option);
    }

    public static dnscnamerec[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      dnscnamerec dnscnamerec = new dnscnamerec();
      options option = new options();
      option.set_filter(filter);
      return (dnscnamerec[]) dnscnamerec.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      dnscnamerec dnscnamerec = new dnscnamerec();
      options option = new options();
      option.set_count(true);
      dnscnamerec[] resources = (dnscnamerec[]) dnscnamerec.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      dnscnamerec dnscnamerec = new dnscnamerec();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnscnamerec[] dnscnamerecArray = (dnscnamerec[]) dnscnamerec.getfiltered(service, option);
      return dnscnamerecArray != null && dnscnamerecArray.Length > 0 ? dnscnamerecArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      dnscnamerec dnscnamerec = new dnscnamerec();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      dnscnamerec[] dnscnamerecArray = (dnscnamerec[]) dnscnamerec.getfiltered(service, option);
      return dnscnamerecArray != null && dnscnamerecArray.Length > 0 ? dnscnamerecArray[0].__count.Value : 0U;
    }

    private class dnscnamerec_response : base_response
    {
      public dnscnamerec[] dnscnamerec = (dnscnamerec[]) null;
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
