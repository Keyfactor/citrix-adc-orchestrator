// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.aaa.aaacertparams
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.aaa
{
  public class aaacertparams : base_resource
  {
    private string usernamefieldField = (string) null;
    private string groupnamefieldField = (string) null;
    private string defaultauthenticationgroupField = (string) null;
    private string twofactorField = (string) null;

    public string usernamefield
    {
      get => this.usernamefieldField;
      set => this.usernamefieldField = value;
    }

    public string groupnamefield
    {
      get => this.groupnamefieldField;
      set => this.groupnamefieldField = value;
    }

    public string defaultauthenticationgroup
    {
      get => this.defaultauthenticationgroupField;
      set => this.defaultauthenticationgroupField = value;
    }

    public string twofactor
    {
      get => this.twofactorField;
      private set => this.twofactorField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      aaacertparams[] aaacertparamsArray = new aaacertparams[1];
      aaacertparams.aaacertparams_response aaacertparamsResponse = new aaacertparams.aaacertparams_response();
      aaacertparams.aaacertparams_response resource = (aaacertparams.aaacertparams_response) service.get_payload_formatter().string_to_resource(aaacertparamsResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      aaacertparamsArray[0] = resource.aaacertparams;
      return (base_resource[]) aaacertparamsArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, aaacertparams resource) => new aaacertparams()
    {
      usernamefield = resource.usernamefield,
      groupnamefield = resource.groupnamefield,
      defaultauthenticationgroup = resource.defaultauthenticationgroup
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      aaacertparams resource,
      string[] args)
    {
      return new aaacertparams().unset_resource(client, args);
    }

    public static aaacertparams get(nitro_service service) => ((aaacertparams[]) new aaacertparams().get_resources(service, (options) null))[0];

    public static aaacertparams get(nitro_service service, options option) => ((aaacertparams[]) new aaacertparams().get_resources(service, option))[0];

    private class aaacertparams_response : base_response
    {
      public aaacertparams aaacertparams = (aaacertparams) null;
    }

    public static class twofactorEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }
  }
}
