// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.aaa.aaaldapparams
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.aaa
{
  public class aaaldapparams : base_resource
  {
    private string serveripField = (string) null;
    private ushort? serverportField = new ushort?();
    private uint? authtimeoutField = new uint?();
    private string ldapbaseField = (string) null;
    private string ldapbinddnField = (string) null;
    private string ldapbinddnpasswordField = (string) null;
    private string ldaploginnameField = (string) null;
    private string searchfilterField = (string) null;
    private string groupattrnameField = (string) null;
    private string subattributenameField = (string) null;
    private string sectypeField = (string) null;
    private string svrtypeField = (string) null;
    private string ssonameattributeField = (string) null;
    private string passwdchangeField = (string) null;
    private string nestedgroupextractionField = (string) null;
    private uint? maxnestinglevelField = new uint?();
    private string groupnameidentifierField = (string) null;
    private string groupsearchattributeField = (string) null;
    private string groupsearchsubattributeField = (string) null;
    private string groupsearchfilterField = (string) null;
    private string defaultauthenticationgroupField = (string) null;
    private string groupauthnameField = (string) null;
    private string[] builtinField = (string[]) null;

    public string serverip
    {
      get => this.serveripField;
      set => this.serveripField = value;
    }

    public ushort? serverport
    {
      get => this.serverportField;
      set => this.serverportField = value;
    }

    public uint? authtimeout
    {
      get => this.authtimeoutField;
      set => this.authtimeoutField = value;
    }

    public string ldapbase
    {
      get => this.ldapbaseField;
      set => this.ldapbaseField = value;
    }

    public string ldapbinddn
    {
      get => this.ldapbinddnField;
      set => this.ldapbinddnField = value;
    }

    public string ldapbinddnpassword
    {
      get => this.ldapbinddnpasswordField;
      set => this.ldapbinddnpasswordField = value;
    }

    public string ldaploginname
    {
      get => this.ldaploginnameField;
      set => this.ldaploginnameField = value;
    }

    public string searchfilter
    {
      get => this.searchfilterField;
      set => this.searchfilterField = value;
    }

    public string groupattrname
    {
      get => this.groupattrnameField;
      set => this.groupattrnameField = value;
    }

    public string subattributename
    {
      get => this.subattributenameField;
      set => this.subattributenameField = value;
    }

    public string sectype
    {
      get => this.sectypeField;
      set => this.sectypeField = value;
    }

    public string svrtype
    {
      get => this.svrtypeField;
      set => this.svrtypeField = value;
    }

    public string ssonameattribute
    {
      get => this.ssonameattributeField;
      set => this.ssonameattributeField = value;
    }

    public string passwdchange
    {
      get => this.passwdchangeField;
      set => this.passwdchangeField = value;
    }

    public string nestedgroupextraction
    {
      get => this.nestedgroupextractionField;
      set => this.nestedgroupextractionField = value;
    }

    public uint? maxnestinglevel
    {
      get => this.maxnestinglevelField;
      set => this.maxnestinglevelField = value;
    }

    public string groupnameidentifier
    {
      get => this.groupnameidentifierField;
      set => this.groupnameidentifierField = value;
    }

    public string groupsearchattribute
    {
      get => this.groupsearchattributeField;
      set => this.groupsearchattributeField = value;
    }

    public string groupsearchsubattribute
    {
      get => this.groupsearchsubattributeField;
      set => this.groupsearchsubattributeField = value;
    }

    public string groupsearchfilter
    {
      get => this.groupsearchfilterField;
      set => this.groupsearchfilterField = value;
    }

    public string defaultauthenticationgroup
    {
      get => this.defaultauthenticationgroupField;
      set => this.defaultauthenticationgroupField = value;
    }

    public string groupauthname
    {
      get => this.groupauthnameField;
      private set => this.groupauthnameField = value;
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
      aaaldapparams[] aaaldapparamsArray = new aaaldapparams[1];
      aaaldapparams.aaaldapparams_response aaaldapparamsResponse = new aaaldapparams.aaaldapparams_response();
      aaaldapparams.aaaldapparams_response resource = (aaaldapparams.aaaldapparams_response) service.get_payload_formatter().string_to_resource(aaaldapparamsResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      aaaldapparamsArray[0] = resource.aaaldapparams;
      return (base_resource[]) aaaldapparamsArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, aaaldapparams resource) => new aaaldapparams()
    {
      serverip = resource.serverip,
      serverport = resource.serverport,
      authtimeout = resource.authtimeout,
      ldapbase = resource.ldapbase,
      ldapbinddn = resource.ldapbinddn,
      ldapbinddnpassword = resource.ldapbinddnpassword,
      ldaploginname = resource.ldaploginname,
      searchfilter = resource.searchfilter,
      groupattrname = resource.groupattrname,
      subattributename = resource.subattributename,
      sectype = resource.sectype,
      svrtype = resource.svrtype,
      ssonameattribute = resource.ssonameattribute,
      passwdchange = resource.passwdchange,
      nestedgroupextraction = resource.nestedgroupextraction,
      maxnestinglevel = resource.maxnestinglevel,
      groupnameidentifier = resource.groupnameidentifier,
      groupsearchattribute = resource.groupsearchattribute,
      groupsearchsubattribute = resource.groupsearchsubattribute,
      groupsearchfilter = resource.groupsearchfilter,
      defaultauthenticationgroup = resource.defaultauthenticationgroup
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      aaaldapparams resource,
      string[] args)
    {
      return new aaaldapparams().unset_resource(client, args);
    }

    public static aaaldapparams get(nitro_service service) => ((aaaldapparams[]) new aaaldapparams().get_resources(service, (options) null))[0];

    public static aaaldapparams get(nitro_service service, options option) => ((aaaldapparams[]) new aaaldapparams().get_resources(service, option))[0];

    private class aaaldapparams_response : base_response
    {
      public aaaldapparams aaaldapparams = (aaaldapparams) null;
    }

    public static class passwdchangeEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class sectypeEnum
    {
      public const string PLAINTEXT = "PLAINTEXT";
      public const string TLS = "TLS";
      public const string SSL = "SSL";
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }

    public static class svrtypeEnum
    {
      public const string AD = "AD";
      public const string NDS = "NDS";
    }

    public static class nestedgroupextractionEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }
  }
}
