// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nsstats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nsstats : base_resource
  {
    private string cleanuplevelField = (string) null;

    public string cleanuplevel
    {
      get => this.cleanuplevelField;
      set => this.cleanuplevelField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nsstats[] nsstatsArray = new nsstats[1];
      nsstats.nsstats_response nsstatsResponse = new nsstats.nsstats_response();
      nsstats.nsstats_response resource = (nsstats.nsstats_response) service.get_payload_formatter().string_to_resource(nsstatsResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      nsstatsArray[0] = resource.nsstats;
      return (base_resource[]) nsstatsArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response clear(nitro_service client, nsstats resource) => new nsstats()
    {
      cleanuplevel = resource.cleanuplevel
    }.perform_operation_byaction(client, nameof (clear));

    private class nsstats_response : base_response
    {
      public nsstats nsstats = (nsstats) null;
    }

    public static class cleanuplevelEnum
    {
      public const string global = "global";
      public const string all = "all";
    }
  }
}
