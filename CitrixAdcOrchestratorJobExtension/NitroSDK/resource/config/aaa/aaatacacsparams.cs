// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.aaa.aaatacacsparams
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.aaa
{
  public class aaatacacsparams : base_resource
  {
    private string serveripField = (string) null;
    private ushort? serverportField = new ushort?();
    private uint? authtimeoutField = new uint?();
    private string tacacssecretField = (string) null;
    private string authorizationField = (string) null;
    private string accountingField = (string) null;
    private string auditfailedcmdsField = (string) null;
    private string defaultauthenticationgroupField = (string) null;
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

    public string tacacssecret
    {
      get => this.tacacssecretField;
      set => this.tacacssecretField = value;
    }

    public string authorization
    {
      get => this.authorizationField;
      set => this.authorizationField = value;
    }

    public string accounting
    {
      get => this.accountingField;
      set => this.accountingField = value;
    }

    public string auditfailedcmds
    {
      get => this.auditfailedcmdsField;
      set => this.auditfailedcmdsField = value;
    }

    public string defaultauthenticationgroup
    {
      get => this.defaultauthenticationgroupField;
      set => this.defaultauthenticationgroupField = value;
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
      aaatacacsparams[] aaatacacsparamsArray = new aaatacacsparams[1];
      aaatacacsparams.aaatacacsparams_response aaatacacsparamsResponse = new aaatacacsparams.aaatacacsparams_response();
      aaatacacsparams.aaatacacsparams_response resource = (aaatacacsparams.aaatacacsparams_response) service.get_payload_formatter().string_to_resource(aaatacacsparamsResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      aaatacacsparamsArray[0] = resource.aaatacacsparams;
      return (base_resource[]) aaatacacsparamsArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, aaatacacsparams resource) => new aaatacacsparams()
    {
      serverip = resource.serverip,
      serverport = resource.serverport,
      authtimeout = resource.authtimeout,
      tacacssecret = resource.tacacssecret,
      authorization = resource.authorization,
      accounting = resource.accounting,
      auditfailedcmds = resource.auditfailedcmds,
      defaultauthenticationgroup = resource.defaultauthenticationgroup
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      aaatacacsparams resource,
      string[] args)
    {
      return new aaatacacsparams().unset_resource(client, args);
    }

    public static aaatacacsparams get(nitro_service service) => ((aaatacacsparams[]) new aaatacacsparams().get_resources(service, (options) null))[0];

    public static aaatacacsparams get(nitro_service service, options option) => ((aaatacacsparams[]) new aaatacacsparams().get_resources(service, option))[0];

    private class aaatacacsparams_response : base_response
    {
      public aaatacacsparams aaatacacsparams = (aaatacacsparams) null;
    }

    public static class auditfailedcmdsEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class authorizationEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }

    public static class accountingEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }
  }
}
