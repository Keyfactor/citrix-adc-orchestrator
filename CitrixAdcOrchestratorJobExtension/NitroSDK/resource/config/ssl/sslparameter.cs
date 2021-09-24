// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslparameter
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslparameter : base_resource
  {
    private string quantumsizeField = (string) null;
    private uint? crlmemorysizembField = new uint?();
    private string strictcachecksField = (string) null;
    private uint? ssltriggertimeoutField = new uint?();
    private string sendclosenotifyField = (string) null;
    private uint? encrypttriggerpktcountField = new uint?();
    private string denysslrenegField = (string) null;
    private string insertionencodingField = (string) null;
    private uint? ocspcachesizeField = new uint?();
    private uint? pushflagField = new uint?();
    private string dropreqwithnohostheaderField = (string) null;
    private uint? pushenctriggertimeoutField = new uint?();
    private uint? cryptodevdisablelimitField = new uint?();
    private string undefactioncontrolField = (string) null;
    private string undefactiondataField = (string) null;
    private string defaultprofileField = (string) null;
    private string svctls1112disableField = (string) null;
    private string montls1112disableField = (string) null;

    public string quantumsize
    {
      get => this.quantumsizeField;
      set => this.quantumsizeField = value;
    }

    public uint? crlmemorysizemb
    {
      get => this.crlmemorysizembField;
      set => this.crlmemorysizembField = value;
    }

    public string strictcachecks
    {
      get => this.strictcachecksField;
      set => this.strictcachecksField = value;
    }

    public uint? ssltriggertimeout
    {
      get => this.ssltriggertimeoutField;
      set => this.ssltriggertimeoutField = value;
    }

    public string sendclosenotify
    {
      get => this.sendclosenotifyField;
      set => this.sendclosenotifyField = value;
    }

    public uint? encrypttriggerpktcount
    {
      get => this.encrypttriggerpktcountField;
      set => this.encrypttriggerpktcountField = value;
    }

    public string denysslreneg
    {
      get => this.denysslrenegField;
      set => this.denysslrenegField = value;
    }

    public string insertionencoding
    {
      get => this.insertionencodingField;
      set => this.insertionencodingField = value;
    }

    public uint? ocspcachesize
    {
      get => this.ocspcachesizeField;
      set => this.ocspcachesizeField = value;
    }

    public uint? pushflag
    {
      get => this.pushflagField;
      set => this.pushflagField = value;
    }

    public string dropreqwithnohostheader
    {
      get => this.dropreqwithnohostheaderField;
      set => this.dropreqwithnohostheaderField = value;
    }

    public uint? pushenctriggertimeout
    {
      get => this.pushenctriggertimeoutField;
      set => this.pushenctriggertimeoutField = value;
    }

    public uint? cryptodevdisablelimit
    {
      get => this.cryptodevdisablelimitField;
      set => this.cryptodevdisablelimitField = value;
    }

    public string undefactioncontrol
    {
      get => this.undefactioncontrolField;
      set => this.undefactioncontrolField = value;
    }

    public string undefactiondata
    {
      get => this.undefactiondataField;
      set => this.undefactiondataField = value;
    }

    public string defaultprofile
    {
      get => this.defaultprofileField;
      set => this.defaultprofileField = value;
    }

    public string svctls1112disable
    {
      get => this.svctls1112disableField;
      private set => this.svctls1112disableField = value;
    }

    public string montls1112disable
    {
      get => this.montls1112disableField;
      private set => this.montls1112disableField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslparameter[] sslparameterArray = new sslparameter[1];
      sslparameter.sslparameter_response sslparameterResponse = new sslparameter.sslparameter_response();
      sslparameter.sslparameter_response resource = (sslparameter.sslparameter_response) service.get_payload_formatter().string_to_resource(sslparameterResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      sslparameterArray[0] = resource.sslparameter;
      return (base_resource[]) sslparameterArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, sslparameter resource) => new sslparameter()
    {
      quantumsize = resource.quantumsize,
      crlmemorysizemb = resource.crlmemorysizemb,
      strictcachecks = resource.strictcachecks,
      ssltriggertimeout = resource.ssltriggertimeout,
      sendclosenotify = resource.sendclosenotify,
      encrypttriggerpktcount = resource.encrypttriggerpktcount,
      denysslreneg = resource.denysslreneg,
      insertionencoding = resource.insertionencoding,
      ocspcachesize = resource.ocspcachesize,
      pushflag = resource.pushflag,
      dropreqwithnohostheader = resource.dropreqwithnohostheader,
      pushenctriggertimeout = resource.pushenctriggertimeout,
      cryptodevdisablelimit = resource.cryptodevdisablelimit,
      undefactioncontrol = resource.undefactioncontrol,
      undefactiondata = resource.undefactiondata,
      defaultprofile = resource.defaultprofile
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      sslparameter resource,
      string[] args)
    {
      return new sslparameter().unset_resource(client, args);
    }

    public static sslparameter get(nitro_service service) => ((sslparameter[]) new sslparameter().get_resources(service, (options) null))[0];

    public static sslparameter get(nitro_service service, options option) => ((sslparameter[]) new sslparameter().get_resources(service, option))[0];

    private class sslparameter_response : base_response
    {
      public sslparameter sslparameter = (sslparameter) null;
    }

    public static class denysslrenegEnum
    {
      public const string NO = "NO";
      public const string FRONTEND_CLIENT = "FRONTEND_CLIENT";
      public const string FRONTEND_CLIENTSERVER = "FRONTEND_CLIENTSERVER";
      public const string ALL = "ALL";
      public const string NONSECURE = "NONSECURE";
    }

    public static class insertionencodingEnum
    {
      public const string Unicode = "Unicode";
      public const string UTF_8 = "UTF-8";
    }

    public static class defaultprofileEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class strictcachecksEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class quantumsizeEnum
    {
      public const string _4096 = "4096";
      public const string _8192 = "8192";
      public const string _16384 = "16384";
    }

    public static class svctls1112disableEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class sendclosenotifyEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class dropreqwithnohostheaderEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class montls1112disableEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
