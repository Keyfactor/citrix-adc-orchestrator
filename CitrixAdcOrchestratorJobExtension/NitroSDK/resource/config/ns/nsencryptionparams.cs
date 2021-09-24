// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nsencryptionparams
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nsencryptionparams : base_resource
  {
    private string methodField = (string) null;
    private string keyvalueField = (string) null;

    public string method
    {
      get => this.methodField;
      set => this.methodField = value;
    }

    public string keyvalue
    {
      get => this.keyvalueField;
      set => this.keyvalueField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nsencryptionparams[] nsencryptionparamsArray = new nsencryptionparams[1];
      nsencryptionparams.nsencryptionparams_response nsencryptionparamsResponse = new nsencryptionparams.nsencryptionparams_response();
      nsencryptionparams.nsencryptionparams_response resource = (nsencryptionparams.nsencryptionparams_response) service.get_payload_formatter().string_to_resource(nsencryptionparamsResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      nsencryptionparamsArray[0] = resource.nsencryptionparams;
      return (base_resource[]) nsencryptionparamsArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(
      nitro_service client,
      nsencryptionparams resource)
    {
      return new nsencryptionparams()
      {
        method = resource.method,
        keyvalue = resource.keyvalue
      }.update_resource(client);
    }

    public static nsencryptionparams get(nitro_service service) => ((nsencryptionparams[]) new nsencryptionparams().get_resources(service, (options) null))[0];

    public static nsencryptionparams get(nitro_service service, options option) => ((nsencryptionparams[]) new nsencryptionparams().get_resources(service, option))[0];

    private class nsencryptionparams_response : base_response
    {
      public nsencryptionparams nsencryptionparams = (nsencryptionparams) null;
    }

    public static class methodEnum
    {
      public const string NONE = "NONE";
      public const string RC4 = "RC4";
      public const string DES3 = "DES3";
      public const string AES128 = "AES128";
      public const string AES192 = "AES192";
      public const string AES256 = "AES256";
    }
  }
}
