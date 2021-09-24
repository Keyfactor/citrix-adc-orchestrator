// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lb.lbparameter
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.lb
{
  public class lbparameter : base_resource
  {
    private string httponlycookieflagField = (string) null;
    private string usesecuredpersistencecookieField = (string) null;
    private string cookiepassphraseField = (string) null;
    private string consolidatedlconnField = (string) null;
    private string useportforhashlbField = (string) null;
    private string preferdirectrouteField = (string) null;
    private uint? startuprrfactorField = new uint?();
    private string monitorskipmaxclientField = (string) null;
    private string monitorconnectioncloseField = (string) null;
    private string vserverspecificmacField = (string) null;
    private string retainservicestateField = (string) null;
    private uint? sessionsthresholdField = new uint?();
    private string[] builtinField = (string[]) null;

    public string httponlycookieflag
    {
      get => this.httponlycookieflagField;
      set => this.httponlycookieflagField = value;
    }

    public string usesecuredpersistencecookie
    {
      get => this.usesecuredpersistencecookieField;
      set => this.usesecuredpersistencecookieField = value;
    }

    public string cookiepassphrase
    {
      get => this.cookiepassphraseField;
      set => this.cookiepassphraseField = value;
    }

    public string consolidatedlconn
    {
      get => this.consolidatedlconnField;
      set => this.consolidatedlconnField = value;
    }

    public string useportforhashlb
    {
      get => this.useportforhashlbField;
      set => this.useportforhashlbField = value;
    }

    public string preferdirectroute
    {
      get => this.preferdirectrouteField;
      set => this.preferdirectrouteField = value;
    }

    public uint? startuprrfactor
    {
      get => this.startuprrfactorField;
      set => this.startuprrfactorField = value;
    }

    public string monitorskipmaxclient
    {
      get => this.monitorskipmaxclientField;
      set => this.monitorskipmaxclientField = value;
    }

    public string monitorconnectionclose
    {
      get => this.monitorconnectioncloseField;
      set => this.monitorconnectioncloseField = value;
    }

    public string vserverspecificmac
    {
      get => this.vserverspecificmacField;
      set => this.vserverspecificmacField = value;
    }

    public string retainservicestate
    {
      get => this.retainservicestateField;
      set => this.retainservicestateField = value;
    }

    public uint? sessionsthreshold
    {
      get => this.sessionsthresholdField;
      private set => this.sessionsthresholdField = value;
    }

    public string[] builtin
    {
      get => this.builtinField;
      private set => this.builtinField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lbparameter[] lbparameterArray = new lbparameter[1];
      lbparameter.lbparameter_response lbparameterResponse = new lbparameter.lbparameter_response();
      lbparameter.lbparameter_response resource = (lbparameter.lbparameter_response) service.get_payload_formatter().string_to_resource(lbparameterResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      lbparameterArray[0] = resource.lbparameter;
      return (base_resource[]) lbparameterArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, lbparameter resource) => new lbparameter()
    {
      httponlycookieflag = resource.httponlycookieflag,
      usesecuredpersistencecookie = resource.usesecuredpersistencecookie,
      cookiepassphrase = resource.cookiepassphrase,
      consolidatedlconn = resource.consolidatedlconn,
      useportforhashlb = resource.useportforhashlb,
      preferdirectroute = resource.preferdirectroute,
      startuprrfactor = resource.startuprrfactor,
      monitorskipmaxclient = resource.monitorskipmaxclient,
      monitorconnectionclose = resource.monitorconnectionclose,
      vserverspecificmac = resource.vserverspecificmac,
      retainservicestate = resource.retainservicestate
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      lbparameter resource,
      string[] args)
    {
      return new lbparameter().unset_resource(client, args);
    }

    public static lbparameter get(nitro_service service) => ((lbparameter[]) new lbparameter().get_resources(service, (options) null))[0];

    public static lbparameter get(nitro_service service, options option) => ((lbparameter[]) new lbparameter().get_resources(service, option))[0];

    private class lbparameter_response : base_response
    {
      public lbparameter lbparameter = (lbparameter) null;
    }

    public static class usesecuredpersistencecookieEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class httponlycookieflagEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class monitorconnectioncloseEnum
    {
      public const string RESET = "RESET";
      public const string FIN = "FIN";
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }

    public static class retainservicestateEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class useportforhashlbEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class consolidatedlconnEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class vserverspecificmacEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class monitorskipmaxclientEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class preferdirectrouteEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }
  }
}
