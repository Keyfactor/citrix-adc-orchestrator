// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslocspresponder
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslocspresponder : base_resource
  {
    private string nameField = (string) null;
    private string urlField = (string) null;
    private string cacheField = (string) null;
    private uint? cachetimeoutField = new uint?();
    private uint? batchingdepthField = new uint?();
    private uint? batchingdelayField = new uint?();
    private uint? resptimeoutField = new uint?();
    private string respondercertField = (string) null;
    private bool? trustresponderField = new bool?();
    private uint? producedattimeskewField = new uint?();
    private string signingcertField = (string) null;
    private string usenonceField = (string) null;
    private string insertclientcertField = (string) null;
    private bool? useaiaField = new bool?();
    private string dnsField = (string) null;
    private string ipaddressField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string url
    {
      get => this.urlField;
      set => this.urlField = value;
    }

    public string cache
    {
      get => this.cacheField;
      set => this.cacheField = value;
    }

    public uint? cachetimeout
    {
      get => this.cachetimeoutField;
      set => this.cachetimeoutField = value;
    }

    public uint? batchingdepth
    {
      get => this.batchingdepthField;
      set => this.batchingdepthField = value;
    }

    public uint? batchingdelay
    {
      get => this.batchingdelayField;
      set => this.batchingdelayField = value;
    }

    public uint? resptimeout
    {
      get => this.resptimeoutField;
      set => this.resptimeoutField = value;
    }

    public string respondercert
    {
      get => this.respondercertField;
      set => this.respondercertField = value;
    }

    public bool? trustresponder
    {
      get => this.trustresponderField;
      set => this.trustresponderField = value;
    }

    public uint? producedattimeskew
    {
      get => this.producedattimeskewField;
      set => this.producedattimeskewField = value;
    }

    public string signingcert
    {
      get => this.signingcertField;
      set => this.signingcertField = value;
    }

    public string usenonce
    {
      get => this.usenonceField;
      set => this.usenonceField = value;
    }

    public string insertclientcert
    {
      get => this.insertclientcertField;
      set => this.insertclientcertField = value;
    }

    public bool? useaia
    {
      get => this.useaiaField;
      private set => this.useaiaField = value;
    }

    public string dns
    {
      get => this.dnsField;
      private set => this.dnsField = value;
    }

    public string ipaddress
    {
      get => this.ipaddressField;
      private set => this.ipaddressField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslocspresponder.sslocspresponder_response sslocspresponderResponse = new sslocspresponder.sslocspresponder_response();
      sslocspresponder.sslocspresponder_response resource = (sslocspresponder.sslocspresponder_response) service.get_payload_formatter().string_to_resource(sslocspresponderResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslocspresponder;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, sslocspresponder resource) => new sslocspresponder()
    {
      name = resource.name,
      url = resource.url,
      cache = resource.cache,
      cachetimeout = resource.cachetimeout,
      batchingdepth = resource.batchingdepth,
      batchingdelay = resource.batchingdelay,
      resptimeout = resource.resptimeout,
      respondercert = resource.respondercert,
      trustresponder = resource.trustresponder,
      producedattimeskew = resource.producedattimeskew,
      signingcert = resource.signingcert,
      usenonce = resource.usenonce,
      insertclientcert = resource.insertclientcert
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      sslocspresponder[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslocspresponder[] sslocspresponderArray = new sslocspresponder[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslocspresponderArray[index] = new sslocspresponder();
          sslocspresponderArray[index].name = resources[index].name;
          sslocspresponderArray[index].url = resources[index].url;
          sslocspresponderArray[index].cache = resources[index].cache;
          sslocspresponderArray[index].cachetimeout = resources[index].cachetimeout;
          sslocspresponderArray[index].batchingdepth = resources[index].batchingdepth;
          sslocspresponderArray[index].batchingdelay = resources[index].batchingdelay;
          sslocspresponderArray[index].resptimeout = resources[index].resptimeout;
          sslocspresponderArray[index].respondercert = resources[index].respondercert;
          sslocspresponderArray[index].trustresponder = resources[index].trustresponder;
          sslocspresponderArray[index].producedattimeskew = resources[index].producedattimeskew;
          sslocspresponderArray[index].signingcert = resources[index].signingcert;
          sslocspresponderArray[index].usenonce = resources[index].usenonce;
          sslocspresponderArray[index].insertclientcert = resources[index].insertclientcert;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) sslocspresponderArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new sslocspresponder()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, sslocspresponder resource) => new sslocspresponder()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        sslocspresponder[] sslocspresponderArray = new sslocspresponder[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          sslocspresponderArray[index] = new sslocspresponder();
          sslocspresponderArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) sslocspresponderArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      sslocspresponder[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslocspresponder[] sslocspresponderArray = new sslocspresponder[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslocspresponderArray[index] = new sslocspresponder();
          sslocspresponderArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) sslocspresponderArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, sslocspresponder resource) => new sslocspresponder()
    {
      name = resource.name,
      url = resource.url,
      cache = resource.cache,
      cachetimeout = resource.cachetimeout,
      batchingdepth = resource.batchingdepth,
      batchingdelay = resource.batchingdelay,
      resptimeout = resource.resptimeout,
      respondercert = resource.respondercert,
      trustresponder = resource.trustresponder,
      producedattimeskew = resource.producedattimeskew,
      signingcert = resource.signingcert,
      usenonce = resource.usenonce,
      insertclientcert = resource.insertclientcert
    }.update_resource(client);

    public static base_responses update(
      nitro_service client,
      sslocspresponder[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslocspresponder[] sslocspresponderArray = new sslocspresponder[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslocspresponderArray[index] = new sslocspresponder();
          sslocspresponderArray[index].name = resources[index].name;
          sslocspresponderArray[index].url = resources[index].url;
          sslocspresponderArray[index].cache = resources[index].cache;
          sslocspresponderArray[index].cachetimeout = resources[index].cachetimeout;
          sslocspresponderArray[index].batchingdepth = resources[index].batchingdepth;
          sslocspresponderArray[index].batchingdelay = resources[index].batchingdelay;
          sslocspresponderArray[index].resptimeout = resources[index].resptimeout;
          sslocspresponderArray[index].respondercert = resources[index].respondercert;
          sslocspresponderArray[index].trustresponder = resources[index].trustresponder;
          sslocspresponderArray[index].producedattimeskew = resources[index].producedattimeskew;
          sslocspresponderArray[index].signingcert = resources[index].signingcert;
          sslocspresponderArray[index].usenonce = resources[index].usenonce;
          sslocspresponderArray[index].insertclientcert = resources[index].insertclientcert;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) sslocspresponderArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string name,
      string[] args)
    {
      return new sslocspresponder() { name = name }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      sslocspresponder resource,
      string[] args)
    {
      return new sslocspresponder()
      {
        name = resource.name,
        insertclientcert = resource.insertclientcert
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] name,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        sslocspresponder[] sslocspresponderArray = new sslocspresponder[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          sslocspresponderArray[index] = new sslocspresponder();
          sslocspresponderArray[index].name = name[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) sslocspresponderArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      sslocspresponder[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslocspresponder[] sslocspresponderArray = new sslocspresponder[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslocspresponderArray[index] = new sslocspresponder();
          sslocspresponderArray[index].name = resources[index].name;
          sslocspresponderArray[index].insertclientcert = resources[index].insertclientcert;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) sslocspresponderArray, args);
      }
      return baseResponses;
    }

    public static sslocspresponder[] get(nitro_service service) => (sslocspresponder[]) new sslocspresponder().get_resources(service, (options) null);

    public static sslocspresponder[] get(nitro_service service, options option) => (sslocspresponder[]) new sslocspresponder().get_resources(service, option);

    public static sslocspresponder get(nitro_service service, string name) => (sslocspresponder) new sslocspresponder()
    {
      name = name
    }.get_resource(service);

    public static sslocspresponder[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (sslocspresponder[]) null;
      sslocspresponder[] sslocspresponderArray1 = new sslocspresponder[name.Length];
      sslocspresponder[] sslocspresponderArray2 = new sslocspresponder[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        sslocspresponderArray2[index] = new sslocspresponder();
        sslocspresponderArray2[index].name = name[index];
        sslocspresponderArray1[index] = (sslocspresponder) sslocspresponderArray2[index].get_resource(service);
      }
      return sslocspresponderArray1;
    }

    public static sslocspresponder[] get_filtered(
      nitro_service service,
      string filter)
    {
      sslocspresponder sslocspresponder = new sslocspresponder();
      options option = new options();
      option.set_filter(filter);
      return (sslocspresponder[]) sslocspresponder.getfiltered(service, option);
    }

    public static sslocspresponder[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      sslocspresponder sslocspresponder = new sslocspresponder();
      options option = new options();
      option.set_filter(filter);
      return (sslocspresponder[]) sslocspresponder.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      sslocspresponder sslocspresponder = new sslocspresponder();
      options option = new options();
      option.set_count(true);
      sslocspresponder[] resources = (sslocspresponder[]) sslocspresponder.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      sslocspresponder sslocspresponder = new sslocspresponder();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslocspresponder[] sslocspresponderArray = (sslocspresponder[]) sslocspresponder.getfiltered(service, option);
      return sslocspresponderArray != null && sslocspresponderArray.Length > 0 ? sslocspresponderArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      sslocspresponder sslocspresponder = new sslocspresponder();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslocspresponder[] sslocspresponderArray = (sslocspresponder[]) sslocspresponder.getfiltered(service, option);
      return sslocspresponderArray != null && sslocspresponderArray.Length > 0 ? sslocspresponderArray[0].__count.Value : 0U;
    }

    private class sslocspresponder_response : base_response
    {
      public sslocspresponder[] sslocspresponder = (sslocspresponder[]) null;
    }

    public static class insertclientcertEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class usenonceEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class cacheEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
