// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nshttpparam
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nshttpparam : base_resource
  {
    private string dropinvalreqsField = (string) null;
    private string markhttp09invalField = (string) null;
    private string markconnreqinvalField = (string) null;
    private string insnssrvrhdrField = (string) null;
    private string nssrvrhdrField = (string) null;
    private string logerrrespField = (string) null;
    private string conmultiplexField = (string) null;
    private uint? maxreusepoolField = new uint?();
    private string[] builtinField = (string[]) null;

    public string dropinvalreqs
    {
      get => this.dropinvalreqsField;
      set => this.dropinvalreqsField = value;
    }

    public string markhttp09inval
    {
      get => this.markhttp09invalField;
      set => this.markhttp09invalField = value;
    }

    public string markconnreqinval
    {
      get => this.markconnreqinvalField;
      set => this.markconnreqinvalField = value;
    }

    public string insnssrvrhdr
    {
      get => this.insnssrvrhdrField;
      set => this.insnssrvrhdrField = value;
    }

    public string nssrvrhdr
    {
      get => this.nssrvrhdrField;
      set => this.nssrvrhdrField = value;
    }

    public string logerrresp
    {
      get => this.logerrrespField;
      set => this.logerrrespField = value;
    }

    public string conmultiplex
    {
      get => this.conmultiplexField;
      set => this.conmultiplexField = value;
    }

    public uint? maxreusepool
    {
      get => this.maxreusepoolField;
      set => this.maxreusepoolField = value;
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
      nshttpparam[] nshttpparamArray = new nshttpparam[1];
      nshttpparam.nshttpparam_response nshttpparamResponse = new nshttpparam.nshttpparam_response();
      nshttpparam.nshttpparam_response resource = (nshttpparam.nshttpparam_response) service.get_payload_formatter().string_to_resource(nshttpparamResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      nshttpparamArray[0] = resource.nshttpparam;
      return (base_resource[]) nshttpparamArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, nshttpparam resource) => new nshttpparam()
    {
      dropinvalreqs = resource.dropinvalreqs,
      markhttp09inval = resource.markhttp09inval,
      markconnreqinval = resource.markconnreqinval,
      insnssrvrhdr = resource.insnssrvrhdr,
      nssrvrhdr = resource.nssrvrhdr,
      logerrresp = resource.logerrresp,
      conmultiplex = resource.conmultiplex,
      maxreusepool = resource.maxreusepool
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      nshttpparam resource,
      string[] args)
    {
      return new nshttpparam().unset_resource(client, args);
    }

    public static nshttpparam get(nitro_service service) => ((nshttpparam[]) new nshttpparam().get_resources(service, (options) null))[0];

    public static nshttpparam get(nitro_service service, options option) => ((nshttpparam[]) new nshttpparam().get_resources(service, option))[0];

    private class nshttpparam_response : base_response
    {
      public nshttpparam nshttpparam = (nshttpparam) null;
    }

    public static class conmultiplexEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class markhttp09invalEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class insnssrvrhdrEnum
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

    public static class markconnreqinvalEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class logerrrespEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class dropinvalreqsEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }
  }
}
