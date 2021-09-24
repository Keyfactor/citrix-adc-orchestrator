// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.vpn.vpnurl
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.vpn
{
  public class vpnurl : base_resource
  {
    private string urlnameField = (string) null;
    private string linknameField = (string) null;
    private string actualurlField = (string) null;
    private string vservernameField = (string) null;
    private string clientlessaccessField = (string) null;
    private string commentField = (string) null;
    private string iconurlField = (string) null;
    private string ssotypeField = (string) null;
    private string applicationtypeField = (string) null;
    private string samlssoprofileField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string urlname
    {
      get => this.urlnameField;
      set => this.urlnameField = value;
    }

    public string linkname
    {
      get => this.linknameField;
      set => this.linknameField = value;
    }

    public string actualurl
    {
      get => this.actualurlField;
      set => this.actualurlField = value;
    }

    public string vservername
    {
      get => this.vservernameField;
      set => this.vservernameField = value;
    }

    public string clientlessaccess
    {
      get => this.clientlessaccessField;
      set => this.clientlessaccessField = value;
    }

    public string comment
    {
      get => this.commentField;
      set => this.commentField = value;
    }

    public string iconurl
    {
      get => this.iconurlField;
      set => this.iconurlField = value;
    }

    public string ssotype
    {
      get => this.ssotypeField;
      set => this.ssotypeField = value;
    }

    public string applicationtype
    {
      get => this.applicationtypeField;
      set => this.applicationtypeField = value;
    }

    public string samlssoprofile
    {
      get => this.samlssoprofileField;
      set => this.samlssoprofileField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vpnurl.vpnurl_response vpnurlResponse = new vpnurl.vpnurl_response();
      vpnurl.vpnurl_response resource = (vpnurl.vpnurl_response) service.get_payload_formatter().string_to_resource(vpnurlResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vpnurl;
    }

    internal override string get_object_name() => this.urlname;

    public static base_response add(nitro_service client, vpnurl resource) => new vpnurl()
    {
      urlname = resource.urlname,
      linkname = resource.linkname,
      actualurl = resource.actualurl,
      vservername = resource.vservername,
      clientlessaccess = resource.clientlessaccess,
      comment = resource.comment,
      iconurl = resource.iconurl,
      ssotype = resource.ssotype,
      applicationtype = resource.applicationtype,
      samlssoprofile = resource.samlssoprofile
    }.add_resource(client);

    public static base_responses add(nitro_service client, vpnurl[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnurl[] vpnurlArray = new vpnurl[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnurlArray[index] = new vpnurl();
          vpnurlArray[index].urlname = resources[index].urlname;
          vpnurlArray[index].linkname = resources[index].linkname;
          vpnurlArray[index].actualurl = resources[index].actualurl;
          vpnurlArray[index].vservername = resources[index].vservername;
          vpnurlArray[index].clientlessaccess = resources[index].clientlessaccess;
          vpnurlArray[index].comment = resources[index].comment;
          vpnurlArray[index].iconurl = resources[index].iconurl;
          vpnurlArray[index].ssotype = resources[index].ssotype;
          vpnurlArray[index].applicationtype = resources[index].applicationtype;
          vpnurlArray[index].samlssoprofile = resources[index].samlssoprofile;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) vpnurlArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string urlname) => new vpnurl()
    {
      urlname = urlname
    }.delete_resource(client);

    public static base_response delete(nitro_service client, vpnurl resource) => new vpnurl()
    {
      urlname = resource.urlname
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] urlname)
    {
      base_responses baseResponses = (base_responses) null;
      if (urlname != null && urlname.Length > 0)
      {
        vpnurl[] vpnurlArray = new vpnurl[urlname.Length];
        for (int index = 0; index < urlname.Length; ++index)
        {
          vpnurlArray[index] = new vpnurl();
          vpnurlArray[index].urlname = urlname[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vpnurlArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, vpnurl[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnurl[] vpnurlArray = new vpnurl[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnurlArray[index] = new vpnurl();
          vpnurlArray[index].urlname = resources[index].urlname;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vpnurlArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, vpnurl resource) => new vpnurl()
    {
      urlname = resource.urlname,
      linkname = resource.linkname,
      actualurl = resource.actualurl,
      vservername = resource.vservername,
      clientlessaccess = resource.clientlessaccess,
      comment = resource.comment,
      iconurl = resource.iconurl,
      ssotype = resource.ssotype,
      applicationtype = resource.applicationtype,
      samlssoprofile = resource.samlssoprofile
    }.update_resource(client);

    public static base_responses update(nitro_service client, vpnurl[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnurl[] vpnurlArray = new vpnurl[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnurlArray[index] = new vpnurl();
          vpnurlArray[index].urlname = resources[index].urlname;
          vpnurlArray[index].linkname = resources[index].linkname;
          vpnurlArray[index].actualurl = resources[index].actualurl;
          vpnurlArray[index].vservername = resources[index].vservername;
          vpnurlArray[index].clientlessaccess = resources[index].clientlessaccess;
          vpnurlArray[index].comment = resources[index].comment;
          vpnurlArray[index].iconurl = resources[index].iconurl;
          vpnurlArray[index].ssotype = resources[index].ssotype;
          vpnurlArray[index].applicationtype = resources[index].applicationtype;
          vpnurlArray[index].samlssoprofile = resources[index].samlssoprofile;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) vpnurlArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string urlname,
      string[] args)
    {
      return new vpnurl() { urlname = urlname }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      vpnurl resource,
      string[] args)
    {
      return new vpnurl() { urlname = resource.urlname }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] urlname,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (urlname != null && urlname.Length > 0)
      {
        vpnurl[] vpnurlArray = new vpnurl[urlname.Length];
        for (int index = 0; index < urlname.Length; ++index)
        {
          vpnurlArray[index] = new vpnurl();
          vpnurlArray[index].urlname = urlname[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) vpnurlArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      vpnurl[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnurl[] vpnurlArray = new vpnurl[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnurlArray[index] = new vpnurl();
          vpnurlArray[index].urlname = resources[index].urlname;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) vpnurlArray, args);
      }
      return baseResponses;
    }

    public static vpnurl[] get(nitro_service service) => (vpnurl[]) new vpnurl().get_resources(service, (options) null);

    public static vpnurl[] get(nitro_service service, options option) => (vpnurl[]) new vpnurl().get_resources(service, option);

    public static vpnurl get(nitro_service service, string urlname) => (vpnurl) new vpnurl()
    {
      urlname = urlname
    }.get_resource(service);

    public static vpnurl[] get(nitro_service service, string[] urlname)
    {
      if (urlname == null || urlname.Length <= 0)
        return (vpnurl[]) null;
      vpnurl[] vpnurlArray1 = new vpnurl[urlname.Length];
      vpnurl[] vpnurlArray2 = new vpnurl[urlname.Length];
      for (int index = 0; index < urlname.Length; ++index)
      {
        vpnurlArray2[index] = new vpnurl();
        vpnurlArray2[index].urlname = urlname[index];
        vpnurlArray1[index] = (vpnurl) vpnurlArray2[index].get_resource(service);
      }
      return vpnurlArray1;
    }

    public static vpnurl[] get_filtered(nitro_service service, string filter)
    {
      vpnurl vpnurl = new vpnurl();
      options option = new options();
      option.set_filter(filter);
      return (vpnurl[]) vpnurl.getfiltered(service, option);
    }

    public static vpnurl[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      vpnurl vpnurl = new vpnurl();
      options option = new options();
      option.set_filter(filter);
      return (vpnurl[]) vpnurl.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      vpnurl vpnurl = new vpnurl();
      options option = new options();
      option.set_count(true);
      vpnurl[] resources = (vpnurl[]) vpnurl.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      vpnurl vpnurl = new vpnurl();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnurl[] vpnurlArray = (vpnurl[]) vpnurl.getfiltered(service, option);
      return vpnurlArray != null && vpnurlArray.Length > 0 ? vpnurlArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      vpnurl vpnurl = new vpnurl();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnurl[] vpnurlArray = (vpnurl[]) vpnurl.getfiltered(service, option);
      return vpnurlArray != null && vpnurlArray.Length > 0 ? vpnurlArray[0].__count.Value : 0U;
    }

    private class vpnurl_response : base_response
    {
      public vpnurl[] vpnurl = (vpnurl[]) null;
    }

    public static class applicationtypeEnum
    {
      public const string CVPN = "CVPN";
      public const string VPN = "VPN";
      public const string SaaS = "SaaS";
    }

    public static class clientlessaccessEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class ssotypeEnum
    {
      public const string unifiedgateway = "unifiedgateway";
      public const string selfauth = "selfauth";
      public const string samlauth = "samlauth";
    }
  }
}
