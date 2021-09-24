// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.aaa.aaaradiusparams
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.aaa
{
  public class aaaradiusparams : base_resource
  {
    private string serveripField = (string) null;
    private ushort? serverportField = new ushort?();
    private uint? authtimeoutField = new uint?();
    private string radkeyField = (string) null;
    private string radnasipField = (string) null;
    private string radnasidField = (string) null;
    private uint? radvendoridField = new uint?();
    private uint? radattributetypeField = new uint?();
    private string radgroupsprefixField = (string) null;
    private string radgroupseparatorField = (string) null;
    private string passencodingField = (string) null;
    private uint? ipvendoridField = new uint?();
    private uint? ipattributetypeField = new uint?();
    private string accountingField = (string) null;
    private uint? pwdvendoridField = new uint?();
    private uint? pwdattributetypeField = new uint?();
    private string defaultauthenticationgroupField = (string) null;
    private string callingstationidField = (string) null;
    private string groupauthnameField = (string) null;
    private string ipaddressField = (string) null;
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

    public string radkey
    {
      get => this.radkeyField;
      set => this.radkeyField = value;
    }

    public string radnasip
    {
      get => this.radnasipField;
      set => this.radnasipField = value;
    }

    public string radnasid
    {
      get => this.radnasidField;
      set => this.radnasidField = value;
    }

    public uint? radvendorid
    {
      get => this.radvendoridField;
      set => this.radvendoridField = value;
    }

    public uint? radattributetype
    {
      get => this.radattributetypeField;
      set => this.radattributetypeField = value;
    }

    public string radgroupsprefix
    {
      get => this.radgroupsprefixField;
      set => this.radgroupsprefixField = value;
    }

    public string radgroupseparator
    {
      get => this.radgroupseparatorField;
      set => this.radgroupseparatorField = value;
    }

    public string passencoding
    {
      get => this.passencodingField;
      set => this.passencodingField = value;
    }

    public uint? ipvendorid
    {
      get => this.ipvendoridField;
      set => this.ipvendoridField = value;
    }

    public uint? ipattributetype
    {
      get => this.ipattributetypeField;
      set => this.ipattributetypeField = value;
    }

    public string accounting
    {
      get => this.accountingField;
      set => this.accountingField = value;
    }

    public uint? pwdvendorid
    {
      get => this.pwdvendoridField;
      set => this.pwdvendoridField = value;
    }

    public uint? pwdattributetype
    {
      get => this.pwdattributetypeField;
      set => this.pwdattributetypeField = value;
    }

    public string defaultauthenticationgroup
    {
      get => this.defaultauthenticationgroupField;
      set => this.defaultauthenticationgroupField = value;
    }

    public string callingstationid
    {
      get => this.callingstationidField;
      set => this.callingstationidField = value;
    }

    public string groupauthname
    {
      get => this.groupauthnameField;
      private set => this.groupauthnameField = value;
    }

    public string ipaddress
    {
      get => this.ipaddressField;
      private set => this.ipaddressField = value;
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
      aaaradiusparams[] aaaradiusparamsArray = new aaaradiusparams[1];
      aaaradiusparams.aaaradiusparams_response aaaradiusparamsResponse = new aaaradiusparams.aaaradiusparams_response();
      aaaradiusparams.aaaradiusparams_response resource = (aaaradiusparams.aaaradiusparams_response) service.get_payload_formatter().string_to_resource(aaaradiusparamsResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      aaaradiusparamsArray[0] = resource.aaaradiusparams;
      return (base_resource[]) aaaradiusparamsArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, aaaradiusparams resource) => new aaaradiusparams()
    {
      serverip = resource.serverip,
      serverport = resource.serverport,
      authtimeout = resource.authtimeout,
      radkey = resource.radkey,
      radnasip = resource.radnasip,
      radnasid = resource.radnasid,
      radvendorid = resource.radvendorid,
      radattributetype = resource.radattributetype,
      radgroupsprefix = resource.radgroupsprefix,
      radgroupseparator = resource.radgroupseparator,
      passencoding = resource.passencoding,
      ipvendorid = resource.ipvendorid,
      ipattributetype = resource.ipattributetype,
      accounting = resource.accounting,
      pwdvendorid = resource.pwdvendorid,
      pwdattributetype = resource.pwdattributetype,
      defaultauthenticationgroup = resource.defaultauthenticationgroup,
      callingstationid = resource.callingstationid
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      aaaradiusparams resource,
      string[] args)
    {
      return new aaaradiusparams().unset_resource(client, args);
    }

    public static aaaradiusparams get(nitro_service service) => ((aaaradiusparams[]) new aaaradiusparams().get_resources(service, (options) null))[0];

    public static aaaradiusparams get(nitro_service service, options option) => ((aaaradiusparams[]) new aaaradiusparams().get_resources(service, option))[0];

    private class aaaradiusparams_response : base_response
    {
      public aaaradiusparams aaaradiusparams = (aaaradiusparams) null;
    }

    public static class passencodingEnum
    {
      public const string pap = "pap";
      public const string chap = "chap";
      public const string mschapv1 = "mschapv1";
      public const string mschapv2 = "mschapv2";
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }

    public static class callingstationidEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class accountingEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class radnasipEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
