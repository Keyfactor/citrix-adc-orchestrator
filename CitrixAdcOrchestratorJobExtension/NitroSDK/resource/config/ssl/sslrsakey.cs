// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslrsakey
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslrsakey : base_resource
  {
    private string keyfileField = (string) null;
    private uint? bitsField = new uint?();
    private string exponentField = (string) null;
    private string keyformField = (string) null;
    private bool? desField = new bool?();
    private bool? des3Field = new bool?();
    private string passwordField = (string) null;

    public string keyfile
    {
      get => this.keyfileField;
      set => this.keyfileField = value;
    }

    public uint? bits
    {
      get => this.bitsField;
      set => this.bitsField = value;
    }

    public string exponent
    {
      get => this.exponentField;
      set => this.exponentField = value;
    }

    public string keyform
    {
      get => this.keyformField;
      set => this.keyformField = value;
    }

    public bool? des
    {
      get => this.desField;
      set => this.desField = value;
    }

    public bool? des3
    {
      get => this.des3Field;
      set => this.des3Field = value;
    }

    public string password
    {
      get => this.passwordField;
      set => this.passwordField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslrsakey[] sslrsakeyArray = new sslrsakey[1];
      sslrsakey.sslrsakey_response sslrsakeyResponse = new sslrsakey.sslrsakey_response();
      sslrsakey.sslrsakey_response resource = (sslrsakey.sslrsakey_response) service.get_payload_formatter().string_to_resource(sslrsakeyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      sslrsakeyArray[0] = resource.sslrsakey;
      return (base_resource[]) sslrsakeyArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response create(nitro_service client, sslrsakey resource) => new sslrsakey()
    {
      keyfile = resource.keyfile,
      bits = resource.bits,
      exponent = resource.exponent,
      keyform = resource.keyform,
      des = resource.des,
      des3 = resource.des3,
      password = resource.password
    }.perform_operation_byaction(client, nameof (create));

    private class sslrsakey_response : base_response
    {
      public sslrsakey sslrsakey = (sslrsakey) null;
    }

    public static class keyformEnum
    {
      public const string DER = "DER";
      public const string PEM = "PEM";
    }

    public static class exponentEnum
    {
      public const string _3 = "3";
      public const string F4 = "F4";
    }
  }
}
