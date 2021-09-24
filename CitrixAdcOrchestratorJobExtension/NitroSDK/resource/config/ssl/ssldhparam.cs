// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.ssldhparam
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class ssldhparam : base_resource
  {
    private string dhfileField = (string) null;
    private uint? bitsField = new uint?();
    private string genField = (string) null;

    public string dhfile
    {
      get => this.dhfileField;
      set => this.dhfileField = value;
    }

    public uint? bits
    {
      get => this.bitsField;
      set => this.bitsField = value;
    }

    public string gen
    {
      get => this.genField;
      set => this.genField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      ssldhparam[] ssldhparamArray = new ssldhparam[1];
      ssldhparam.ssldhparam_response ssldhparamResponse = new ssldhparam.ssldhparam_response();
      ssldhparam.ssldhparam_response resource = (ssldhparam.ssldhparam_response) service.get_payload_formatter().string_to_resource(ssldhparamResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      ssldhparamArray[0] = resource.ssldhparam;
      return (base_resource[]) ssldhparamArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response create(nitro_service client, ssldhparam resource) => new ssldhparam()
    {
      dhfile = resource.dhfile,
      bits = resource.bits,
      gen = resource.gen
    }.perform_operation_byaction(client, nameof (create));

    private class ssldhparam_response : base_response
    {
      public ssldhparam ssldhparam = (ssldhparam) null;
    }

    public static class genEnum
    {
      public const string _2 = "2";
      public const string _5 = "5";
    }
  }
}
