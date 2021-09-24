// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ipsec.ipsecparameter
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ipsec
{
  public class ipsecparameter : base_resource
  {
    private string ikeversionField = (string) null;
    private string[] encalgoField = (string[]) null;
    private string[] hashalgoField = (string[]) null;
    private uint? lifetimeField = new uint?();
    private uint? livenesscheckintervalField = new uint?();
    private uint? replaywindowsizeField = new uint?();
    private uint? ikeretryintervalField = new uint?();
    private string perfectforwardsecrecyField = (string) null;
    private uint? retransmissiontimeField = new uint?();

    public string ikeversion
    {
      get => this.ikeversionField;
      set => this.ikeversionField = value;
    }

    public string[] encalgo
    {
      get => this.encalgoField;
      set => this.encalgoField = value;
    }

    public string[] hashalgo
    {
      get => this.hashalgoField;
      set => this.hashalgoField = value;
    }

    public uint? lifetime
    {
      get => this.lifetimeField;
      set => this.lifetimeField = value;
    }

    public uint? livenesscheckinterval
    {
      get => this.livenesscheckintervalField;
      set => this.livenesscheckintervalField = value;
    }

    public uint? replaywindowsize
    {
      get => this.replaywindowsizeField;
      set => this.replaywindowsizeField = value;
    }

    public uint? ikeretryinterval
    {
      get => this.ikeretryintervalField;
      set => this.ikeretryintervalField = value;
    }

    public string perfectforwardsecrecy
    {
      get => this.perfectforwardsecrecyField;
      set => this.perfectforwardsecrecyField = value;
    }

    public uint? retransmissiontime
    {
      get => this.retransmissiontimeField;
      set => this.retransmissiontimeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      ipsecparameter[] ipsecparameterArray = new ipsecparameter[1];
      ipsecparameter.ipsecparameter_response ipsecparameterResponse = new ipsecparameter.ipsecparameter_response();
      ipsecparameter.ipsecparameter_response resource = (ipsecparameter.ipsecparameter_response) service.get_payload_formatter().string_to_resource(ipsecparameterResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      ipsecparameterArray[0] = resource.ipsecparameter;
      return (base_resource[]) ipsecparameterArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, ipsecparameter resource) => new ipsecparameter()
    {
      ikeversion = resource.ikeversion,
      encalgo = resource.encalgo,
      hashalgo = resource.hashalgo,
      lifetime = resource.lifetime,
      livenesscheckinterval = resource.livenesscheckinterval,
      replaywindowsize = resource.replaywindowsize,
      ikeretryinterval = resource.ikeretryinterval,
      perfectforwardsecrecy = resource.perfectforwardsecrecy,
      retransmissiontime = resource.retransmissiontime
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      ipsecparameter resource,
      string[] args)
    {
      return new ipsecparameter().unset_resource(client, args);
    }

    public static ipsecparameter get(nitro_service service) => ((ipsecparameter[]) new ipsecparameter().get_resources(service, (options) null))[0];

    public static ipsecparameter get(nitro_service service, options option) => ((ipsecparameter[]) new ipsecparameter().get_resources(service, option))[0];

    private class ipsecparameter_response : base_response
    {
      public ipsecparameter ipsecparameter = (ipsecparameter) null;
    }

    public static class perfectforwardsecrecyEnum
    {
      public const string ENABLE = "ENABLE";
      public const string DISABLE = "DISABLE";
    }

    public static class encalgoEnum
    {
      public const string AES = "AES";
      public const string _3DES = "3DES";
    }

    public static class ikeversionEnum
    {
      public const string V1 = "V1";
      public const string V2 = "V2";
    }

    public static class hashalgoEnum
    {
      public const string HMAC_SHA1 = "HMAC_SHA1";
      public const string HMAC_SHA256 = "HMAC_SHA256";
      public const string HMAC_SHA384 = "HMAC_SHA384";
      public const string HMAC_SHA512 = "HMAC_SHA512";
      public const string HMAC_MD5 = "HMAC_MD5";
    }
  }
}
