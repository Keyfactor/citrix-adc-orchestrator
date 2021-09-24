// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.feo.feoparameter
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.feo
{
  public class feoparameter : base_resource
  {
    private uint? cachemaxageField = new uint?();
    private uint? jpegqualitypercentField = new uint?();
    private uint? cssinlinethressizeField = new uint?();
    private uint? jsinlinethressizeField = new uint?();
    private uint? imginlinethressizeField = new uint?();
    private string[] builtinField = (string[]) null;

    public uint? cachemaxage
    {
      get => this.cachemaxageField;
      set => this.cachemaxageField = value;
    }

    public uint? jpegqualitypercent
    {
      get => this.jpegqualitypercentField;
      set => this.jpegqualitypercentField = value;
    }

    public uint? cssinlinethressize
    {
      get => this.cssinlinethressizeField;
      set => this.cssinlinethressizeField = value;
    }

    public uint? jsinlinethressize
    {
      get => this.jsinlinethressizeField;
      set => this.jsinlinethressizeField = value;
    }

    public uint? imginlinethressize
    {
      get => this.imginlinethressizeField;
      set => this.imginlinethressizeField = value;
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
      feoparameter[] feoparameterArray = new feoparameter[1];
      feoparameter.feoparameter_response feoparameterResponse = new feoparameter.feoparameter_response();
      feoparameter.feoparameter_response resource = (feoparameter.feoparameter_response) service.get_payload_formatter().string_to_resource(feoparameterResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      feoparameterArray[0] = resource.feoparameter;
      return (base_resource[]) feoparameterArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, feoparameter resource) => new feoparameter()
    {
      cachemaxage = resource.cachemaxage,
      jpegqualitypercent = resource.jpegqualitypercent,
      cssinlinethressize = resource.cssinlinethressize,
      jsinlinethressize = resource.jsinlinethressize,
      imginlinethressize = resource.imginlinethressize
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      feoparameter resource,
      string[] args)
    {
      return new feoparameter().unset_resource(client, args);
    }

    public static feoparameter get(nitro_service service) => ((feoparameter[]) new feoparameter().get_resources(service, (options) null))[0];

    public static feoparameter get(nitro_service service, options option) => ((feoparameter[]) new feoparameter().get_resources(service, option))[0];

    private class feoparameter_response : base_response
    {
      public feoparameter feoparameter = (feoparameter) null;
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }
  }
}
