// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cmp.cmpparameter
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.cmp
{
  public class cmpparameter : base_resource
  {
    private string cmplevelField = (string) null;
    private uint? quantumsizeField = new uint?();
    private string servercmpField = (string) null;
    private string heurexpiryField = (string) null;
    private uint? heurexpirythresField = new uint?();
    private uint? heurexpiryhistwtField = new uint?();
    private uint? minressizeField = new uint?();
    private uint? cmpbypasspctField = new uint?();
    private string cmponpushField = (string) null;
    private string policytypeField = (string) null;
    private string addvaryheaderField = (string) null;
    private string varyheadervalueField = (string) null;
    private string externalcacheField = (string) null;
    private string[] builtinField = (string[]) null;

    public string cmplevel
    {
      get => this.cmplevelField;
      set => this.cmplevelField = value;
    }

    public uint? quantumsize
    {
      get => this.quantumsizeField;
      set => this.quantumsizeField = value;
    }

    public string servercmp
    {
      get => this.servercmpField;
      set => this.servercmpField = value;
    }

    public string heurexpiry
    {
      get => this.heurexpiryField;
      set => this.heurexpiryField = value;
    }

    public uint? heurexpirythres
    {
      get => this.heurexpirythresField;
      set => this.heurexpirythresField = value;
    }

    public uint? heurexpiryhistwt
    {
      get => this.heurexpiryhistwtField;
      set => this.heurexpiryhistwtField = value;
    }

    public uint? minressize
    {
      get => this.minressizeField;
      set => this.minressizeField = value;
    }

    public uint? cmpbypasspct
    {
      get => this.cmpbypasspctField;
      set => this.cmpbypasspctField = value;
    }

    public string cmponpush
    {
      get => this.cmponpushField;
      set => this.cmponpushField = value;
    }

    public string policytype
    {
      get => this.policytypeField;
      set => this.policytypeField = value;
    }

    public string addvaryheader
    {
      get => this.addvaryheaderField;
      set => this.addvaryheaderField = value;
    }

    public string varyheadervalue
    {
      get => this.varyheadervalueField;
      set => this.varyheadervalueField = value;
    }

    public string externalcache
    {
      get => this.externalcacheField;
      set => this.externalcacheField = value;
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
      cmpparameter[] cmpparameterArray = new cmpparameter[1];
      cmpparameter.cmpparameter_response cmpparameterResponse = new cmpparameter.cmpparameter_response();
      cmpparameter.cmpparameter_response resource = (cmpparameter.cmpparameter_response) service.get_payload_formatter().string_to_resource(cmpparameterResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      cmpparameterArray[0] = resource.cmpparameter;
      return (base_resource[]) cmpparameterArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, cmpparameter resource) => new cmpparameter()
    {
      cmplevel = resource.cmplevel,
      quantumsize = resource.quantumsize,
      servercmp = resource.servercmp,
      heurexpiry = resource.heurexpiry,
      heurexpirythres = resource.heurexpirythres,
      heurexpiryhistwt = resource.heurexpiryhistwt,
      minressize = resource.minressize,
      cmpbypasspct = resource.cmpbypasspct,
      cmponpush = resource.cmponpush,
      policytype = resource.policytype,
      addvaryheader = resource.addvaryheader,
      varyheadervalue = resource.varyheadervalue,
      externalcache = resource.externalcache
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      cmpparameter resource,
      string[] args)
    {
      return new cmpparameter().unset_resource(client, args);
    }

    public static cmpparameter get(nitro_service service) => ((cmpparameter[]) new cmpparameter().get_resources(service, (options) null))[0];

    public static cmpparameter get(nitro_service service, options option) => ((cmpparameter[]) new cmpparameter().get_resources(service, option))[0];

    private class cmpparameter_response : base_response
    {
      public cmpparameter cmpparameter = (cmpparameter) null;
    }

    public static class externalcacheEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }

    public static class addvaryheaderEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class servercmpEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class cmplevelEnum
    {
      public const string optimal = "optimal";
      public const string bestspeed = "bestspeed";
      public const string bestcompression = "bestcompression";
    }

    public static class policytypeEnum
    {
      public const string CLASSIC = "CLASSIC";
      public const string ADVANCED = "ADVANCED";
    }

    public static class cmponpushEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class heurexpiryEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }
  }
}
