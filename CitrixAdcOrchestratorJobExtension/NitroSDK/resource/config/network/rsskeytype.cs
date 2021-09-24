// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.rsskeytype
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class rsskeytype : base_resource
  {
    private string rsstypeField = (string) null;

    public string rsstype
    {
      get => this.rsstypeField;
      set => this.rsstypeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      rsskeytype[] rsskeytypeArray = new rsskeytype[1];
      rsskeytype.rsskeytype_response rsskeytypeResponse = new rsskeytype.rsskeytype_response();
      rsskeytype.rsskeytype_response resource = (rsskeytype.rsskeytype_response) service.get_payload_formatter().string_to_resource(rsskeytypeResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      rsskeytypeArray[0] = resource.rsskeytype;
      return (base_resource[]) rsskeytypeArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, rsskeytype resource) => new rsskeytype()
    {
      rsstype = resource.rsstype
    }.update_resource(client);

    public static rsskeytype get(nitro_service service) => ((rsskeytype[]) new rsskeytype().get_resources(service, (options) null))[0];

    public static rsskeytype get(nitro_service service, options option) => ((rsskeytype[]) new rsskeytype().get_resources(service, option))[0];

    private class rsskeytype_response : base_response
    {
      public rsskeytype rsskeytype = (rsskeytype) null;
    }

    public static class rsstypeEnum
    {
      public const string ASYMMETRIC = "ASYMMETRIC";
      public const string SYMMETRIC = "SYMMETRIC";
    }
  }
}
