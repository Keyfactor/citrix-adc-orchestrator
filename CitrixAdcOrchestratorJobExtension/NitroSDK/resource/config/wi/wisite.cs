// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.wi.wisite
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.wi
{
  public class wisite : base_resource
  {
    private string sitepathField = (string) null;
    private string agurlField = (string) null;
    private string staurlField = (string) null;
    private string secondstaurlField = (string) null;
    private string sessionreliabilityField = (string) null;
    private string usetwoticketsField = (string) null;
    private string authenticationpointField = (string) null;
    private string agauthenticationmethodField = (string) null;
    private string[] wiauthenticationmethodsField = (string[]) null;
    private string defaultcustomtextlocaleField = (string) null;
    private uint? websessiontimeoutField = new uint?();
    private string defaultaccessmethodField = (string) null;
    private string logintitleField = (string) null;
    private string appwelcomemessageField = (string) null;
    private string welcomemessageField = (string) null;
    private string footertextField = (string) null;
    private string loginsysmessageField = (string) null;
    private string preloginbuttonField = (string) null;
    private string preloginmessageField = (string) null;
    private string prelogintitleField = (string) null;
    private string domainselectionField = (string) null;
    private string sitetypeField = (string) null;
    private string userinterfacebrandingField = (string) null;
    private string publishedresourcetypeField = (string) null;
    private string kioskmodeField = (string) null;
    private string showsearchField = (string) null;
    private string showrefreshField = (string) null;
    private string wiuserinterfacemodesField = (string) null;
    private string userinterfacelayoutsField = (string) null;
    private string restrictdomainsField = (string) null;
    private string logindomainsField = (string) null;
    private string hidedomainfieldField = (string) null;
    private string agcallbackurlField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string sitepath
    {
      get => this.sitepathField;
      set => this.sitepathField = value;
    }

    public string agurl
    {
      get => this.agurlField;
      set => this.agurlField = value;
    }

    public string staurl
    {
      get => this.staurlField;
      set => this.staurlField = value;
    }

    public string secondstaurl
    {
      get => this.secondstaurlField;
      set => this.secondstaurlField = value;
    }

    public string sessionreliability
    {
      get => this.sessionreliabilityField;
      set => this.sessionreliabilityField = value;
    }

    public string usetwotickets
    {
      get => this.usetwoticketsField;
      set => this.usetwoticketsField = value;
    }

    public string authenticationpoint
    {
      get => this.authenticationpointField;
      set => this.authenticationpointField = value;
    }

    public string agauthenticationmethod
    {
      get => this.agauthenticationmethodField;
      set => this.agauthenticationmethodField = value;
    }

    public string[] wiauthenticationmethods
    {
      get => this.wiauthenticationmethodsField;
      set => this.wiauthenticationmethodsField = value;
    }

    public string defaultcustomtextlocale
    {
      get => this.defaultcustomtextlocaleField;
      set => this.defaultcustomtextlocaleField = value;
    }

    public uint? websessiontimeout
    {
      get => this.websessiontimeoutField;
      set => this.websessiontimeoutField = value;
    }

    public string defaultaccessmethod
    {
      get => this.defaultaccessmethodField;
      set => this.defaultaccessmethodField = value;
    }

    public string logintitle
    {
      get => this.logintitleField;
      set => this.logintitleField = value;
    }

    public string appwelcomemessage
    {
      get => this.appwelcomemessageField;
      set => this.appwelcomemessageField = value;
    }

    public string welcomemessage
    {
      get => this.welcomemessageField;
      set => this.welcomemessageField = value;
    }

    public string footertext
    {
      get => this.footertextField;
      set => this.footertextField = value;
    }

    public string loginsysmessage
    {
      get => this.loginsysmessageField;
      set => this.loginsysmessageField = value;
    }

    public string preloginbutton
    {
      get => this.preloginbuttonField;
      set => this.preloginbuttonField = value;
    }

    public string preloginmessage
    {
      get => this.preloginmessageField;
      set => this.preloginmessageField = value;
    }

    public string prelogintitle
    {
      get => this.prelogintitleField;
      set => this.prelogintitleField = value;
    }

    public string domainselection
    {
      get => this.domainselectionField;
      set => this.domainselectionField = value;
    }

    public string sitetype
    {
      get => this.sitetypeField;
      set => this.sitetypeField = value;
    }

    public string userinterfacebranding
    {
      get => this.userinterfacebrandingField;
      set => this.userinterfacebrandingField = value;
    }

    public string publishedresourcetype
    {
      get => this.publishedresourcetypeField;
      set => this.publishedresourcetypeField = value;
    }

    public string kioskmode
    {
      get => this.kioskmodeField;
      set => this.kioskmodeField = value;
    }

    public string showsearch
    {
      get => this.showsearchField;
      set => this.showsearchField = value;
    }

    public string showrefresh
    {
      get => this.showrefreshField;
      set => this.showrefreshField = value;
    }

    public string wiuserinterfacemodes
    {
      get => this.wiuserinterfacemodesField;
      set => this.wiuserinterfacemodesField = value;
    }

    public string userinterfacelayouts
    {
      get => this.userinterfacelayoutsField;
      set => this.userinterfacelayoutsField = value;
    }

    public string restrictdomains
    {
      get => this.restrictdomainsField;
      set => this.restrictdomainsField = value;
    }

    public string logindomains
    {
      get => this.logindomainsField;
      set => this.logindomainsField = value;
    }

    public string hidedomainfield
    {
      get => this.hidedomainfieldField;
      set => this.hidedomainfieldField = value;
    }

    public string agcallbackurl
    {
      get => this.agcallbackurlField;
      set => this.agcallbackurlField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      wisite.wisite_response wisiteResponse = new wisite.wisite_response();
      wisite.wisite_response resource = (wisite.wisite_response) service.get_payload_formatter().string_to_resource(wisiteResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.wisite;
    }

    internal override string get_object_name() => this.sitepath;

    public static base_response add(nitro_service client, wisite resource) => new wisite()
    {
      sitepath = resource.sitepath,
      agurl = resource.agurl,
      staurl = resource.staurl,
      secondstaurl = resource.secondstaurl,
      sessionreliability = resource.sessionreliability,
      usetwotickets = resource.usetwotickets,
      authenticationpoint = resource.authenticationpoint,
      agauthenticationmethod = resource.agauthenticationmethod,
      wiauthenticationmethods = resource.wiauthenticationmethods,
      defaultcustomtextlocale = resource.defaultcustomtextlocale,
      websessiontimeout = resource.websessiontimeout,
      defaultaccessmethod = resource.defaultaccessmethod,
      logintitle = resource.logintitle,
      appwelcomemessage = resource.appwelcomemessage,
      welcomemessage = resource.welcomemessage,
      footertext = resource.footertext,
      loginsysmessage = resource.loginsysmessage,
      preloginbutton = resource.preloginbutton,
      preloginmessage = resource.preloginmessage,
      prelogintitle = resource.prelogintitle,
      domainselection = resource.domainselection,
      sitetype = resource.sitetype,
      userinterfacebranding = resource.userinterfacebranding,
      publishedresourcetype = resource.publishedresourcetype,
      kioskmode = resource.kioskmode,
      showsearch = resource.showsearch,
      showrefresh = resource.showrefresh,
      wiuserinterfacemodes = resource.wiuserinterfacemodes,
      userinterfacelayouts = resource.userinterfacelayouts,
      restrictdomains = resource.restrictdomains,
      logindomains = resource.logindomains,
      hidedomainfield = resource.hidedomainfield,
      agcallbackurl = resource.agcallbackurl
    }.add_resource(client);

    public static base_responses add(nitro_service client, wisite[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        wisite[] wisiteArray = new wisite[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          wisiteArray[index] = new wisite();
          wisiteArray[index].sitepath = resources[index].sitepath;
          wisiteArray[index].agurl = resources[index].agurl;
          wisiteArray[index].staurl = resources[index].staurl;
          wisiteArray[index].secondstaurl = resources[index].secondstaurl;
          wisiteArray[index].sessionreliability = resources[index].sessionreliability;
          wisiteArray[index].usetwotickets = resources[index].usetwotickets;
          wisiteArray[index].authenticationpoint = resources[index].authenticationpoint;
          wisiteArray[index].agauthenticationmethod = resources[index].agauthenticationmethod;
          wisiteArray[index].wiauthenticationmethods = resources[index].wiauthenticationmethods;
          wisiteArray[index].defaultcustomtextlocale = resources[index].defaultcustomtextlocale;
          wisiteArray[index].websessiontimeout = resources[index].websessiontimeout;
          wisiteArray[index].defaultaccessmethod = resources[index].defaultaccessmethod;
          wisiteArray[index].logintitle = resources[index].logintitle;
          wisiteArray[index].appwelcomemessage = resources[index].appwelcomemessage;
          wisiteArray[index].welcomemessage = resources[index].welcomemessage;
          wisiteArray[index].footertext = resources[index].footertext;
          wisiteArray[index].loginsysmessage = resources[index].loginsysmessage;
          wisiteArray[index].preloginbutton = resources[index].preloginbutton;
          wisiteArray[index].preloginmessage = resources[index].preloginmessage;
          wisiteArray[index].prelogintitle = resources[index].prelogintitle;
          wisiteArray[index].domainselection = resources[index].domainselection;
          wisiteArray[index].sitetype = resources[index].sitetype;
          wisiteArray[index].userinterfacebranding = resources[index].userinterfacebranding;
          wisiteArray[index].publishedresourcetype = resources[index].publishedresourcetype;
          wisiteArray[index].kioskmode = resources[index].kioskmode;
          wisiteArray[index].showsearch = resources[index].showsearch;
          wisiteArray[index].showrefresh = resources[index].showrefresh;
          wisiteArray[index].wiuserinterfacemodes = resources[index].wiuserinterfacemodes;
          wisiteArray[index].userinterfacelayouts = resources[index].userinterfacelayouts;
          wisiteArray[index].restrictdomains = resources[index].restrictdomains;
          wisiteArray[index].logindomains = resources[index].logindomains;
          wisiteArray[index].hidedomainfield = resources[index].hidedomainfield;
          wisiteArray[index].agcallbackurl = resources[index].agcallbackurl;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) wisiteArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string sitepath) => new wisite()
    {
      sitepath = sitepath
    }.delete_resource(client);

    public static base_response delete(nitro_service client, wisite resource) => new wisite()
    {
      sitepath = resource.sitepath
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] sitepath)
    {
      base_responses baseResponses = (base_responses) null;
      if (sitepath != null && sitepath.Length > 0)
      {
        wisite[] wisiteArray = new wisite[sitepath.Length];
        for (int index = 0; index < sitepath.Length; ++index)
        {
          wisiteArray[index] = new wisite();
          wisiteArray[index].sitepath = sitepath[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) wisiteArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, wisite[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        wisite[] wisiteArray = new wisite[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          wisiteArray[index] = new wisite();
          wisiteArray[index].sitepath = resources[index].sitepath;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) wisiteArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, wisite resource) => new wisite()
    {
      sitepath = resource.sitepath,
      agurl = resource.agurl,
      staurl = resource.staurl,
      sessionreliability = resource.sessionreliability,
      usetwotickets = resource.usetwotickets,
      secondstaurl = resource.secondstaurl,
      wiauthenticationmethods = resource.wiauthenticationmethods,
      defaultaccessmethod = resource.defaultaccessmethod,
      defaultcustomtextlocale = resource.defaultcustomtextlocale,
      websessiontimeout = resource.websessiontimeout,
      logintitle = resource.logintitle,
      appwelcomemessage = resource.appwelcomemessage,
      welcomemessage = resource.welcomemessage,
      footertext = resource.footertext,
      loginsysmessage = resource.loginsysmessage,
      preloginbutton = resource.preloginbutton,
      preloginmessage = resource.preloginmessage,
      prelogintitle = resource.prelogintitle,
      domainselection = resource.domainselection,
      userinterfacebranding = resource.userinterfacebranding,
      authenticationpoint = resource.authenticationpoint,
      agauthenticationmethod = resource.agauthenticationmethod,
      publishedresourcetype = resource.publishedresourcetype,
      kioskmode = resource.kioskmode,
      showsearch = resource.showsearch,
      showrefresh = resource.showrefresh,
      wiuserinterfacemodes = resource.wiuserinterfacemodes,
      userinterfacelayouts = resource.userinterfacelayouts,
      restrictdomains = resource.restrictdomains,
      logindomains = resource.logindomains,
      hidedomainfield = resource.hidedomainfield,
      agcallbackurl = resource.agcallbackurl
    }.update_resource(client);

    public static base_responses update(nitro_service client, wisite[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        wisite[] wisiteArray = new wisite[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          wisiteArray[index] = new wisite();
          wisiteArray[index].sitepath = resources[index].sitepath;
          wisiteArray[index].agurl = resources[index].agurl;
          wisiteArray[index].staurl = resources[index].staurl;
          wisiteArray[index].sessionreliability = resources[index].sessionreliability;
          wisiteArray[index].usetwotickets = resources[index].usetwotickets;
          wisiteArray[index].secondstaurl = resources[index].secondstaurl;
          wisiteArray[index].wiauthenticationmethods = resources[index].wiauthenticationmethods;
          wisiteArray[index].defaultaccessmethod = resources[index].defaultaccessmethod;
          wisiteArray[index].defaultcustomtextlocale = resources[index].defaultcustomtextlocale;
          wisiteArray[index].websessiontimeout = resources[index].websessiontimeout;
          wisiteArray[index].logintitle = resources[index].logintitle;
          wisiteArray[index].appwelcomemessage = resources[index].appwelcomemessage;
          wisiteArray[index].welcomemessage = resources[index].welcomemessage;
          wisiteArray[index].footertext = resources[index].footertext;
          wisiteArray[index].loginsysmessage = resources[index].loginsysmessage;
          wisiteArray[index].preloginbutton = resources[index].preloginbutton;
          wisiteArray[index].preloginmessage = resources[index].preloginmessage;
          wisiteArray[index].prelogintitle = resources[index].prelogintitle;
          wisiteArray[index].domainselection = resources[index].domainselection;
          wisiteArray[index].userinterfacebranding = resources[index].userinterfacebranding;
          wisiteArray[index].authenticationpoint = resources[index].authenticationpoint;
          wisiteArray[index].agauthenticationmethod = resources[index].agauthenticationmethod;
          wisiteArray[index].publishedresourcetype = resources[index].publishedresourcetype;
          wisiteArray[index].kioskmode = resources[index].kioskmode;
          wisiteArray[index].showsearch = resources[index].showsearch;
          wisiteArray[index].showrefresh = resources[index].showrefresh;
          wisiteArray[index].wiuserinterfacemodes = resources[index].wiuserinterfacemodes;
          wisiteArray[index].userinterfacelayouts = resources[index].userinterfacelayouts;
          wisiteArray[index].restrictdomains = resources[index].restrictdomains;
          wisiteArray[index].logindomains = resources[index].logindomains;
          wisiteArray[index].hidedomainfield = resources[index].hidedomainfield;
          wisiteArray[index].agcallbackurl = resources[index].agcallbackurl;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) wisiteArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      string sitepath,
      string[] args)
    {
      return new wisite() { sitepath = sitepath }.unset_resource(client, args);
    }

    public static base_response unset(
      nitro_service client,
      wisite resource,
      string[] args)
    {
      return new wisite() { sitepath = resource.sitepath }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      string[] sitepath,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (sitepath != null && sitepath.Length > 0)
      {
        wisite[] wisiteArray = new wisite[sitepath.Length];
        for (int index = 0; index < sitepath.Length; ++index)
        {
          wisiteArray[index] = new wisite();
          wisiteArray[index].sitepath = sitepath[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) wisiteArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      wisite[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        wisite[] wisiteArray = new wisite[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          wisiteArray[index] = new wisite();
          wisiteArray[index].sitepath = resources[index].sitepath;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) wisiteArray, args);
      }
      return baseResponses;
    }

    public static wisite[] get(nitro_service service) => (wisite[]) new wisite().get_resources(service, (options) null);

    public static wisite[] get(nitro_service service, options option) => (wisite[]) new wisite().get_resources(service, option);

    public static wisite get(nitro_service service, string sitepath) => (wisite) new wisite()
    {
      sitepath = sitepath
    }.get_resource(service);

    public static wisite[] get(nitro_service service, string[] sitepath)
    {
      if (sitepath == null || sitepath.Length <= 0)
        return (wisite[]) null;
      wisite[] wisiteArray1 = new wisite[sitepath.Length];
      wisite[] wisiteArray2 = new wisite[sitepath.Length];
      for (int index = 0; index < sitepath.Length; ++index)
      {
        wisiteArray2[index] = new wisite();
        wisiteArray2[index].sitepath = sitepath[index];
        wisiteArray1[index] = (wisite) wisiteArray2[index].get_resource(service);
      }
      return wisiteArray1;
    }

    public static wisite[] get_filtered(nitro_service service, string filter)
    {
      wisite wisite = new wisite();
      options option = new options();
      option.set_filter(filter);
      return (wisite[]) wisite.getfiltered(service, option);
    }

    public static wisite[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      wisite wisite = new wisite();
      options option = new options();
      option.set_filter(filter);
      return (wisite[]) wisite.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      wisite wisite = new wisite();
      options option = new options();
      option.set_count(true);
      wisite[] resources = (wisite[]) wisite.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      wisite wisite = new wisite();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      wisite[] wisiteArray = (wisite[]) wisite.getfiltered(service, option);
      return wisiteArray != null && wisiteArray.Length > 0 ? wisiteArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      wisite wisite = new wisite();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      wisite[] wisiteArray = (wisite[]) wisite.getfiltered(service, option);
      return wisiteArray != null && wisiteArray.Length > 0 ? wisiteArray[0].__count.Value : 0U;
    }

    private class wisite_response : base_response
    {
      public wisite[] wisite = (wisite[]) null;
    }

    public static class sessionreliabilityEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class showsearchEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class showrefreshEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class userinterfacelayoutsEnum
    {
      public const string AUTO = "AUTO";
      public const string NORMAL = "NORMAL";
      public const string COMPACT = "COMPACT";
    }

    public static class wiauthenticationmethodsEnum
    {
      public const string Explicit = "Explicit";
      public const string Anonymous = "Anonymous";
    }

    public static class defaultaccessmethodEnum
    {
      public const string Direct = "Direct";
      public const string Alternate = "Alternate";
      public const string Translated = "Translated";
      public const string GatewayDirect = "GatewayDirect";
      public const string GatewayAlternate = "GatewayAlternate";
      public const string GatewayTranslated = "GatewayTranslated";
    }

    public static class wiuserinterfacemodesEnum
    {
      public const string SIMPLE = "SIMPLE";
      public const string ADVANCED = "ADVANCED";
    }

    public static class publishedresourcetypeEnum
    {
      public const string Online = "Online";
      public const string Offline = "Offline";
      public const string DualMode = "DualMode";
    }

    public static class usetwoticketsEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class agauthenticationmethodEnum
    {
      public const string Explicit = "Explicit";
      public const string SmartCard = "SmartCard";
    }

    public static class hidedomainfieldEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class authenticationpointEnum
    {
      public const string WebInterface = "WebInterface";
      public const string AccessGateway = "AccessGateway";
    }

    public static class restrictdomainsEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class sitetypeEnum
    {
      public const string XenAppWeb = "XenAppWeb";
      public const string XenAppServices = "XenAppServices";
    }

    public static class userinterfacebrandingEnum
    {
      public const string Desktops = "Desktops";
      public const string Applications = "Applications";
    }

    public static class defaultcustomtextlocaleEnum
    {
      public const string German = "German";
      public const string English = "English";
      public const string Spanish = "Spanish";
      public const string French = "French";
      public const string Japanese = "Japanese";
      public const string Korean = "Korean";
      public const string Russian = "Russian";
      public const string Chinese_simplified = "Chinese_simplified";
      public const string Chinese_traditional = "Chinese_traditional";
    }

    public static class kioskmodeEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }
  }
}
