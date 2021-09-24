// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.appfw.appfwsettings
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.appfw
{
  public class appfwsettings : base_resource
  {
    private string defaultprofileField = (string) null;
    private string undefactionField = (string) null;
    private uint? sessiontimeoutField = new uint?();
    private uint? learnratelimitField = new uint?();
    private uint? sessionlifetimeField = new uint?();
    private string sessioncookienameField = (string) null;
    private string clientiploggingheaderField = (string) null;
    private uint? importsizelimitField = new uint?();
    private string signatureautoupdateField = (string) null;
    private string signatureurlField = (string) null;
    private string cookiepostencryptprefixField = (string) null;
    private string logmalformedreqField = (string) null;
    private string geolocationloggingField = (string) null;
    private string cefloggingField = (string) null;
    private string entitydecodingField = (string) null;
    private string useconfigurablesecretkeyField = (string) null;

    public string defaultprofile
    {
      get => this.defaultprofileField;
      set => this.defaultprofileField = value;
    }

    public string undefaction
    {
      get => this.undefactionField;
      set => this.undefactionField = value;
    }

    public uint? sessiontimeout
    {
      get => this.sessiontimeoutField;
      set => this.sessiontimeoutField = value;
    }

    public uint? learnratelimit
    {
      get => this.learnratelimitField;
      set => this.learnratelimitField = value;
    }

    public uint? sessionlifetime
    {
      get => this.sessionlifetimeField;
      set => this.sessionlifetimeField = value;
    }

    public string sessioncookiename
    {
      get => this.sessioncookienameField;
      set => this.sessioncookienameField = value;
    }

    public string clientiploggingheader
    {
      get => this.clientiploggingheaderField;
      set => this.clientiploggingheaderField = value;
    }

    public uint? importsizelimit
    {
      get => this.importsizelimitField;
      set => this.importsizelimitField = value;
    }

    public string signatureautoupdate
    {
      get => this.signatureautoupdateField;
      set => this.signatureautoupdateField = value;
    }

    public string signatureurl
    {
      get => this.signatureurlField;
      set => this.signatureurlField = value;
    }

    public string cookiepostencryptprefix
    {
      get => this.cookiepostencryptprefixField;
      set => this.cookiepostencryptprefixField = value;
    }

    public string logmalformedreq
    {
      get => this.logmalformedreqField;
      set => this.logmalformedreqField = value;
    }

    public string geolocationlogging
    {
      get => this.geolocationloggingField;
      set => this.geolocationloggingField = value;
    }

    public string ceflogging
    {
      get => this.cefloggingField;
      set => this.cefloggingField = value;
    }

    public string entitydecoding
    {
      get => this.entitydecodingField;
      set => this.entitydecodingField = value;
    }

    public string useconfigurablesecretkey
    {
      get => this.useconfigurablesecretkeyField;
      set => this.useconfigurablesecretkeyField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      appfwsettings[] appfwsettingsArray = new appfwsettings[1];
      appfwsettings.appfwsettings_response appfwsettingsResponse = new appfwsettings.appfwsettings_response();
      appfwsettings.appfwsettings_response resource = (appfwsettings.appfwsettings_response) service.get_payload_formatter().string_to_resource(appfwsettingsResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      appfwsettingsArray[0] = resource.appfwsettings;
      return (base_resource[]) appfwsettingsArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, appfwsettings resource) => new appfwsettings()
    {
      defaultprofile = resource.defaultprofile,
      undefaction = resource.undefaction,
      sessiontimeout = resource.sessiontimeout,
      learnratelimit = resource.learnratelimit,
      sessionlifetime = resource.sessionlifetime,
      sessioncookiename = resource.sessioncookiename,
      clientiploggingheader = resource.clientiploggingheader,
      importsizelimit = resource.importsizelimit,
      signatureautoupdate = resource.signatureautoupdate,
      signatureurl = resource.signatureurl,
      cookiepostencryptprefix = resource.cookiepostencryptprefix,
      logmalformedreq = resource.logmalformedreq,
      geolocationlogging = resource.geolocationlogging,
      ceflogging = resource.ceflogging,
      entitydecoding = resource.entitydecoding,
      useconfigurablesecretkey = resource.useconfigurablesecretkey
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      appfwsettings resource,
      string[] args)
    {
      return new appfwsettings().unset_resource(client, args);
    }

    public static appfwsettings get(nitro_service service) => ((appfwsettings[]) new appfwsettings().get_resources(service, (options) null))[0];

    public static appfwsettings get(nitro_service service, options option) => ((appfwsettings[]) new appfwsettings().get_resources(service, option))[0];

    private class appfwsettings_response : base_response
    {
      public appfwsettings appfwsettings = (appfwsettings) null;
    }

    public static class cefloggingEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class logmalformedreqEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class signatureautoupdateEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class useconfigurablesecretkeyEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class geolocationloggingEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class entitydecodingEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }
  }
}
