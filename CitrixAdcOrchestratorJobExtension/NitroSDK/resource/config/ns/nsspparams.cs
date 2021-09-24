// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nsspparams
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nsspparams : base_resource
  {
    private int? basethresholdField = new int?();
    private string throttleField = (string) null;
    private int?[] table0Field = (int?[]) null;

    public int? basethreshold
    {
      get => this.basethresholdField;
      set => this.basethresholdField = value;
    }

    public string throttle
    {
      get => this.throttleField;
      set => this.throttleField = value;
    }

    public int?[] table0
    {
      get => this.table0Field;
      private set => this.table0Field = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nsspparams[] nsspparamsArray = new nsspparams[1];
      nsspparams.nsspparams_response nsspparamsResponse = new nsspparams.nsspparams_response();
      nsspparams.nsspparams_response resource = (nsspparams.nsspparams_response) service.get_payload_formatter().string_to_resource(nsspparamsResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      nsspparamsArray[0] = resource.nsspparams;
      return (base_resource[]) nsspparamsArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, nsspparams resource) => new nsspparams()
    {
      basethreshold = resource.basethreshold,
      throttle = resource.throttle
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      nsspparams resource,
      string[] args)
    {
      return new nsspparams().unset_resource(client, args);
    }

    public static nsspparams get(nitro_service service) => ((nsspparams[]) new nsspparams().get_resources(service, (options) null))[0];

    public static nsspparams get(nitro_service service, options option) => ((nsspparams[]) new nsspparams().get_resources(service, option))[0];

    private class nsspparams_response : base_response
    {
      public nsspparams nsspparams = (nsspparams) null;
    }

    public static class throttleEnum
    {
      public const string Aggressive = "Aggressive";
      public const string Normal = "Normal";
      public const string Relaxed = "Relaxed";
    }
  }
}
