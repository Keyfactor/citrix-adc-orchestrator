// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.vpn.vpnparameter
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.vpn
{
  public class vpnparameter : base_resource
  {
    private ushort?[] httpportField = (ushort?[]) null;
    private string winsipField = (string) null;
    private string dnsvservernameField = (string) null;
    private string splitdnsField = (string) null;
    private uint? sesstimeoutField = new uint?();
    private string clientsecurityField = (string) null;
    private string clientsecuritygroupField = (string) null;
    private string clientsecuritymessageField = (string) null;
    private string clientsecuritylogField = (string) null;
    private string smartgroupField = (string) null;
    private string splittunnelField = (string) null;
    private string locallanaccessField = (string) null;
    private string rfc1918Field = (string) null;
    private string spoofiipField = (string) null;
    private string killconnectionsField = (string) null;
    private string transparentinterceptionField = (string) null;
    private string windowsclienttypeField = (string) null;
    private string defaultauthorizationactionField = (string) null;
    private string authorizationgroupField = (string) null;
    private uint? clientidletimeoutField = new uint?();
    private string proxyField = (string) null;
    private string allprotocolproxyField = (string) null;
    private string httpproxyField = (string) null;
    private string ftpproxyField = (string) null;
    private string socksproxyField = (string) null;
    private string gopherproxyField = (string) null;
    private string sslproxyField = (string) null;
    private string proxyexceptionField = (string) null;
    private string proxylocalbypassField = (string) null;
    private string clientcleanuppromptField = (string) null;
    private string[] forcecleanupField = (string[]) null;
    private string[] clientoptionsField = (string[]) null;
    private string[] clientconfigurationField = (string[]) null;
    private string ssoField = (string) null;
    private string ssocredentialField = (string) null;
    private string windowsautologonField = (string) null;
    private string usemipField = (string) null;
    private string useiipField = (string) null;
    private string clientdebugField = (string) null;
    private string loginscriptField = (string) null;
    private string logoutscriptField = (string) null;
    private string homepageField = (string) null;
    private string icaproxyField = (string) null;
    private string wihomeField = (string) null;
    private string wihomeaddresstypeField = (string) null;
    private string citrixreceiverhomeField = (string) null;
    private string wiportalmodeField = (string) null;
    private string clientchoicesField = (string) null;
    private string epaclienttypeField = (string) null;
    private string iipdnssuffixField = (string) null;
    private uint? forcedtimeoutField = new uint?();
    private uint? forcedtimeoutwarningField = new uint?();
    private string ntdomainField = (string) null;
    private string clientlessvpnmodeField = (string) null;
    private string clientlessmodeurlencodingField = (string) null;
    private string clientlesspersistentcookieField = (string) null;
    private string emailhomeField = (string) null;
    private string allowedlogingroupsField = (string) null;
    private string encryptcsecexpField = (string) null;
    private uint? apptokentimeoutField = new uint?();
    private uint? mdxtokentimeoutField = new uint?();
    private string uithemeField = (string) null;
    private string securebrowseField = (string) null;
    private string storefronturlField = (string) null;
    private string kcdaccountField = (string) null;
    private string clientversionsField = (string) null;
    private string rdpclientprofilenameField = (string) null;
    private string windowspluginupgradeField = (string) null;
    private string macpluginupgradeField = (string) null;
    private string linuxpluginupgradeField = (string) null;
    private string iconwithreceiverField = (string) null;
    private string userdomainsField = (string) null;
    private string icasessiontimeoutField = (string) null;
    private string nameField = (string) null;
    private uint? clientidletimeoutwarningField = new uint?();

    public ushort?[] httpport
    {
      get => this.httpportField;
      set => this.httpportField = value;
    }

    public string winsip
    {
      get => this.winsipField;
      set => this.winsipField = value;
    }

    public string dnsvservername
    {
      get => this.dnsvservernameField;
      set => this.dnsvservernameField = value;
    }

    public string splitdns
    {
      get => this.splitdnsField;
      set => this.splitdnsField = value;
    }

    public uint? sesstimeout
    {
      get => this.sesstimeoutField;
      set => this.sesstimeoutField = value;
    }

    public string clientsecurity
    {
      get => this.clientsecurityField;
      set => this.clientsecurityField = value;
    }

    public string clientsecuritygroup
    {
      get => this.clientsecuritygroupField;
      set => this.clientsecuritygroupField = value;
    }

    public string clientsecuritymessage
    {
      get => this.clientsecuritymessageField;
      set => this.clientsecuritymessageField = value;
    }

    public string clientsecuritylog
    {
      get => this.clientsecuritylogField;
      set => this.clientsecuritylogField = value;
    }

    public string smartgroup
    {
      get => this.smartgroupField;
      set => this.smartgroupField = value;
    }

    public string splittunnel
    {
      get => this.splittunnelField;
      set => this.splittunnelField = value;
    }

    public string locallanaccess
    {
      get => this.locallanaccessField;
      set => this.locallanaccessField = value;
    }

    public string rfc1918
    {
      get => this.rfc1918Field;
      set => this.rfc1918Field = value;
    }

    public string spoofiip
    {
      get => this.spoofiipField;
      set => this.spoofiipField = value;
    }

    public string killconnections
    {
      get => this.killconnectionsField;
      set => this.killconnectionsField = value;
    }

    public string transparentinterception
    {
      get => this.transparentinterceptionField;
      set => this.transparentinterceptionField = value;
    }

    public string windowsclienttype
    {
      get => this.windowsclienttypeField;
      set => this.windowsclienttypeField = value;
    }

    public string defaultauthorizationaction
    {
      get => this.defaultauthorizationactionField;
      set => this.defaultauthorizationactionField = value;
    }

    public string authorizationgroup
    {
      get => this.authorizationgroupField;
      set => this.authorizationgroupField = value;
    }

    public uint? clientidletimeout
    {
      get => this.clientidletimeoutField;
      set => this.clientidletimeoutField = value;
    }

    public string proxy
    {
      get => this.proxyField;
      set => this.proxyField = value;
    }

    public string allprotocolproxy
    {
      get => this.allprotocolproxyField;
      set => this.allprotocolproxyField = value;
    }

    public string httpproxy
    {
      get => this.httpproxyField;
      set => this.httpproxyField = value;
    }

    public string ftpproxy
    {
      get => this.ftpproxyField;
      set => this.ftpproxyField = value;
    }

    public string socksproxy
    {
      get => this.socksproxyField;
      set => this.socksproxyField = value;
    }

    public string gopherproxy
    {
      get => this.gopherproxyField;
      set => this.gopherproxyField = value;
    }

    public string sslproxy
    {
      get => this.sslproxyField;
      set => this.sslproxyField = value;
    }

    public string proxyexception
    {
      get => this.proxyexceptionField;
      set => this.proxyexceptionField = value;
    }

    public string proxylocalbypass
    {
      get => this.proxylocalbypassField;
      set => this.proxylocalbypassField = value;
    }

    public string clientcleanupprompt
    {
      get => this.clientcleanuppromptField;
      set => this.clientcleanuppromptField = value;
    }

    public string[] forcecleanup
    {
      get => this.forcecleanupField;
      set => this.forcecleanupField = value;
    }

    public string[] clientoptions
    {
      get => this.clientoptionsField;
      set => this.clientoptionsField = value;
    }

    public string[] clientconfiguration
    {
      get => this.clientconfigurationField;
      set => this.clientconfigurationField = value;
    }

    public string sso
    {
      get => this.ssoField;
      set => this.ssoField = value;
    }

    public string ssocredential
    {
      get => this.ssocredentialField;
      set => this.ssocredentialField = value;
    }

    public string windowsautologon
    {
      get => this.windowsautologonField;
      set => this.windowsautologonField = value;
    }

    public string usemip
    {
      get => this.usemipField;
      set => this.usemipField = value;
    }

    public string useiip
    {
      get => this.useiipField;
      set => this.useiipField = value;
    }

    public string clientdebug
    {
      get => this.clientdebugField;
      set => this.clientdebugField = value;
    }

    public string loginscript
    {
      get => this.loginscriptField;
      set => this.loginscriptField = value;
    }

    public string logoutscript
    {
      get => this.logoutscriptField;
      set => this.logoutscriptField = value;
    }

    public string homepage
    {
      get => this.homepageField;
      set => this.homepageField = value;
    }

    public string icaproxy
    {
      get => this.icaproxyField;
      set => this.icaproxyField = value;
    }

    public string wihome
    {
      get => this.wihomeField;
      set => this.wihomeField = value;
    }

    public string wihomeaddresstype
    {
      get => this.wihomeaddresstypeField;
      set => this.wihomeaddresstypeField = value;
    }

    public string citrixreceiverhome
    {
      get => this.citrixreceiverhomeField;
      set => this.citrixreceiverhomeField = value;
    }

    public string wiportalmode
    {
      get => this.wiportalmodeField;
      set => this.wiportalmodeField = value;
    }

    public string clientchoices
    {
      get => this.clientchoicesField;
      set => this.clientchoicesField = value;
    }

    public string epaclienttype
    {
      get => this.epaclienttypeField;
      set => this.epaclienttypeField = value;
    }

    public string iipdnssuffix
    {
      get => this.iipdnssuffixField;
      set => this.iipdnssuffixField = value;
    }

    public uint? forcedtimeout
    {
      get => this.forcedtimeoutField;
      set => this.forcedtimeoutField = value;
    }

    public uint? forcedtimeoutwarning
    {
      get => this.forcedtimeoutwarningField;
      set => this.forcedtimeoutwarningField = value;
    }

    public string ntdomain
    {
      get => this.ntdomainField;
      set => this.ntdomainField = value;
    }

    public string clientlessvpnmode
    {
      get => this.clientlessvpnmodeField;
      set => this.clientlessvpnmodeField = value;
    }

    public string clientlessmodeurlencoding
    {
      get => this.clientlessmodeurlencodingField;
      set => this.clientlessmodeurlencodingField = value;
    }

    public string clientlesspersistentcookie
    {
      get => this.clientlesspersistentcookieField;
      set => this.clientlesspersistentcookieField = value;
    }

    public string emailhome
    {
      get => this.emailhomeField;
      set => this.emailhomeField = value;
    }

    public string allowedlogingroups
    {
      get => this.allowedlogingroupsField;
      set => this.allowedlogingroupsField = value;
    }

    public string encryptcsecexp
    {
      get => this.encryptcsecexpField;
      set => this.encryptcsecexpField = value;
    }

    public uint? apptokentimeout
    {
      get => this.apptokentimeoutField;
      set => this.apptokentimeoutField = value;
    }

    public uint? mdxtokentimeout
    {
      get => this.mdxtokentimeoutField;
      set => this.mdxtokentimeoutField = value;
    }

    public string uitheme
    {
      get => this.uithemeField;
      set => this.uithemeField = value;
    }

    public string securebrowse
    {
      get => this.securebrowseField;
      set => this.securebrowseField = value;
    }

    public string storefronturl
    {
      get => this.storefronturlField;
      set => this.storefronturlField = value;
    }

    public string kcdaccount
    {
      get => this.kcdaccountField;
      set => this.kcdaccountField = value;
    }

    public string clientversions
    {
      get => this.clientversionsField;
      set => this.clientversionsField = value;
    }

    public string rdpclientprofilename
    {
      get => this.rdpclientprofilenameField;
      set => this.rdpclientprofilenameField = value;
    }

    public string windowspluginupgrade
    {
      get => this.windowspluginupgradeField;
      set => this.windowspluginupgradeField = value;
    }

    public string macpluginupgrade
    {
      get => this.macpluginupgradeField;
      set => this.macpluginupgradeField = value;
    }

    public string linuxpluginupgrade
    {
      get => this.linuxpluginupgradeField;
      set => this.linuxpluginupgradeField = value;
    }

    public string iconwithreceiver
    {
      get => this.iconwithreceiverField;
      set => this.iconwithreceiverField = value;
    }

    public string userdomains
    {
      get => this.userdomainsField;
      set => this.userdomainsField = value;
    }

    public string icasessiontimeout
    {
      get => this.icasessiontimeoutField;
      set => this.icasessiontimeoutField = value;
    }

    public string name
    {
      get => this.nameField;
      private set => this.nameField = value;
    }

    public uint? clientidletimeoutwarning
    {
      get => this.clientidletimeoutwarningField;
      private set => this.clientidletimeoutwarningField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vpnparameter[] vpnparameterArray = new vpnparameter[1];
      vpnparameter.vpnparameter_response vpnparameterResponse = new vpnparameter.vpnparameter_response();
      vpnparameter.vpnparameter_response resource = (vpnparameter.vpnparameter_response) service.get_payload_formatter().string_to_resource(vpnparameterResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      vpnparameterArray[0] = resource.vpnparameter;
      return (base_resource[]) vpnparameterArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, vpnparameter resource) => new vpnparameter()
    {
      httpport = resource.httpport,
      winsip = resource.winsip,
      dnsvservername = resource.dnsvservername,
      splitdns = resource.splitdns,
      sesstimeout = resource.sesstimeout,
      clientsecurity = resource.clientsecurity,
      clientsecuritygroup = resource.clientsecuritygroup,
      clientsecuritymessage = resource.clientsecuritymessage,
      clientsecuritylog = resource.clientsecuritylog,
      smartgroup = resource.smartgroup,
      splittunnel = resource.splittunnel,
      locallanaccess = resource.locallanaccess,
      rfc1918 = resource.rfc1918,
      spoofiip = resource.spoofiip,
      killconnections = resource.killconnections,
      transparentinterception = resource.transparentinterception,
      windowsclienttype = resource.windowsclienttype,
      defaultauthorizationaction = resource.defaultauthorizationaction,
      authorizationgroup = resource.authorizationgroup,
      clientidletimeout = resource.clientidletimeout,
      proxy = resource.proxy,
      allprotocolproxy = resource.allprotocolproxy,
      httpproxy = resource.httpproxy,
      ftpproxy = resource.ftpproxy,
      socksproxy = resource.socksproxy,
      gopherproxy = resource.gopherproxy,
      sslproxy = resource.sslproxy,
      proxyexception = resource.proxyexception,
      proxylocalbypass = resource.proxylocalbypass,
      clientcleanupprompt = resource.clientcleanupprompt,
      forcecleanup = resource.forcecleanup,
      clientoptions = resource.clientoptions,
      clientconfiguration = resource.clientconfiguration,
      sso = resource.sso,
      ssocredential = resource.ssocredential,
      windowsautologon = resource.windowsautologon,
      usemip = resource.usemip,
      useiip = resource.useiip,
      clientdebug = resource.clientdebug,
      loginscript = resource.loginscript,
      logoutscript = resource.logoutscript,
      homepage = resource.homepage,
      icaproxy = resource.icaproxy,
      wihome = resource.wihome,
      wihomeaddresstype = resource.wihomeaddresstype,
      citrixreceiverhome = resource.citrixreceiverhome,
      wiportalmode = resource.wiportalmode,
      clientchoices = resource.clientchoices,
      epaclienttype = resource.epaclienttype,
      iipdnssuffix = resource.iipdnssuffix,
      forcedtimeout = resource.forcedtimeout,
      forcedtimeoutwarning = resource.forcedtimeoutwarning,
      ntdomain = resource.ntdomain,
      clientlessvpnmode = resource.clientlessvpnmode,
      clientlessmodeurlencoding = resource.clientlessmodeurlencoding,
      clientlesspersistentcookie = resource.clientlesspersistentcookie,
      emailhome = resource.emailhome,
      allowedlogingroups = resource.allowedlogingroups,
      encryptcsecexp = resource.encryptcsecexp,
      apptokentimeout = resource.apptokentimeout,
      mdxtokentimeout = resource.mdxtokentimeout,
      uitheme = resource.uitheme,
      securebrowse = resource.securebrowse,
      storefronturl = resource.storefronturl,
      kcdaccount = resource.kcdaccount,
      clientversions = resource.clientversions,
      rdpclientprofilename = resource.rdpclientprofilename,
      windowspluginupgrade = resource.windowspluginupgrade,
      macpluginupgrade = resource.macpluginupgrade,
      linuxpluginupgrade = resource.linuxpluginupgrade,
      iconwithreceiver = resource.iconwithreceiver,
      userdomains = resource.userdomains,
      icasessiontimeout = resource.icasessiontimeout
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      vpnparameter resource,
      string[] args)
    {
      return new vpnparameter().unset_resource(client, args);
    }

    public static vpnparameter get(nitro_service service) => ((vpnparameter[]) new vpnparameter().get_resources(service, (options) null))[0];

    public static vpnparameter get(nitro_service service, options option) => ((vpnparameter[]) new vpnparameter().get_resources(service, option))[0];

    private class vpnparameter_response : base_response
    {
      public vpnparameter vpnparameter = (vpnparameter) null;
    }

    public static class spoofiipEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class macpluginupgradeEnum
    {
      public const string Always = "Always";
      public const string Essential = "Essential";
      public const string Never = "Never";
    }

    public static class transparentinterceptionEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class wihomeaddresstypeEnum
    {
      public const string IPV4 = "IPV4";
      public const string IPV6 = "IPV6";
    }

    public static class clientcleanuppromptEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class icaproxyEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class clientlessvpnmodeEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
      public const string DISABLED = "DISABLED";
    }

    public static class splitdnsEnum
    {
      public const string LOCAL = "LOCAL";
      public const string REMOTE = "REMOTE";
      public const string BOTH = "BOTH";
    }

    public static class usemipEnum
    {
      public const string NS = "NS";
      public const string OFF = "OFF";
    }

    public static class windowsclienttypeEnum
    {
      public const string AGENT = "AGENT";
      public const string PLUGIN = "PLUGIN";
    }

    public static class epaclienttypeEnum
    {
      public const string AGENT = "AGENT";
      public const string PLUGIN = "PLUGIN";
    }

    public static class icasessiontimeoutEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class clientlesspersistentcookieEnum
    {
      public const string ALLOW = "ALLOW";
      public const string DENY = "DENY";
      public const string PROMPT = "PROMPT";
    }

    public static class locallanaccessEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class windowspluginupgradeEnum
    {
      public const string Always = "Always";
      public const string Essential = "Essential";
      public const string Never = "Never";
    }

    public static class proxyEnum
    {
      public const string BROWSER = "BROWSER";
      public const string NS = "NS";
      public const string OFF = "OFF";
    }

    public static class uithemeEnum
    {
      public const string DEFAULT = "DEFAULT";
      public const string GREENBUBBLE = "GREENBUBBLE";
      public const string CUSTOM = "CUSTOM";
    }

    public static class encryptcsecexpEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class wiportalmodeEnum
    {
      public const string NORMAL = "NORMAL";
      public const string COMPACT = "COMPACT";
    }

    public static class clientlessmodeurlencodingEnum
    {
      public const string TRANSPARENT = "TRANSPARENT";
      public const string OPAQUE = "OPAQUE";
      public const string ENCRYPT = "ENCRYPT";
    }

    public static class forcecleanupEnum
    {
      public const string none = "none";
      public const string all = "all";
      public const string cookie = "cookie";
      public const string addressbar = "addressbar";
      public const string plugin = "plugin";
      public const string filesystemapplication = "filesystemapplication";
      public const string application = "application";
      public const string applicationdata = "applicationdata";
      public const string clientcertificate = "clientcertificate";
      public const string autocomplete = "autocomplete";
      public const string cache = "cache";
    }

    public static class clientsecuritylogEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class killconnectionsEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class linuxpluginupgradeEnum
    {
      public const string Always = "Always";
      public const string Essential = "Essential";
      public const string Never = "Never";
    }

    public static class iconwithreceiverEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class useiipEnum
    {
      public const string NOSPILLOVER = "NOSPILLOVER";
      public const string SPILLOVER = "SPILLOVER";
      public const string OFF = "OFF";
    }

    public static class securebrowseEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class windowsautologonEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class defaultauthorizationactionEnum
    {
      public const string ALLOW = "ALLOW";
      public const string DENY = "DENY";
    }

    public static class clientoptionsEnum
    {
      public const string none = "none";
      public const string all = "all";
      public const string services = "services";
      public const string filetransfer = "filetransfer";
      public const string configuration = "configuration";
    }

    public static class clientchoicesEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class splittunnelEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
      public const string REVERSE = "REVERSE";
    }

    public static class ssocredentialEnum
    {
      public const string PRIMARY = "PRIMARY";
      public const string SECONDARY = "SECONDARY";
    }

    public static class proxylocalbypassEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class rfc1918Enum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class clientconfigurationEnum
    {
      public const string none = "none";
      public const string all = "all";
      public const string general = "general";
      public const string tunnel = "tunnel";
      public const string trace = "trace";
      public const string compression = "compression";
    }

    public static class clientdebugEnum
    {
      public const string debug = "debug";
      public const string stats = "stats";
      public const string events = "events";
      public const string OFF = "OFF";
    }

    public static class ssoEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }
  }
}
