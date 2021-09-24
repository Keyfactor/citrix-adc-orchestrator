// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ntp.ntpparam
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ntp
{
  public class ntpparam : base_resource
  {
    private string authenticationField = (string) null;
    private uint?[] trustedkeyField = (uint?[]) null;
    private uint? autokeylogsecField = new uint?();
    private uint? revokelogsecField = new uint?();

    public string authentication
    {
      get => this.authenticationField;
      set => this.authenticationField = value;
    }

    public uint?[] trustedkey
    {
      get => this.trustedkeyField;
      set => this.trustedkeyField = value;
    }

    public uint? autokeylogsec
    {
      get => this.autokeylogsecField;
      set => this.autokeylogsecField = value;
    }

    public uint? revokelogsec
    {
      get => this.revokelogsecField;
      set => this.revokelogsecField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      ntpparam[] ntpparamArray = new ntpparam[1];
      ntpparam.ntpparam_response ntpparamResponse = new ntpparam.ntpparam_response();
      ntpparam.ntpparam_response resource = (ntpparam.ntpparam_response) service.get_payload_formatter().string_to_resource(ntpparamResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      ntpparamArray[0] = resource.ntpparam;
      return (base_resource[]) ntpparamArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, ntpparam resource) => new ntpparam()
    {
      authentication = resource.authentication,
      trustedkey = resource.trustedkey,
      autokeylogsec = resource.autokeylogsec,
      revokelogsec = resource.revokelogsec
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      ntpparam resource,
      string[] args)
    {
      return new ntpparam().unset_resource(client, args);
    }

    public static ntpparam get(nitro_service service) => ((ntpparam[]) new ntpparam().get_resources(service, (options) null))[0];

    public static ntpparam get(nitro_service service, options option) => ((ntpparam[]) new ntpparam().get_resources(service, option))[0];

    private class ntpparam_response : base_response
    {
      public ntpparam ntpparam = (ntpparam) null;
    }

    public static class authenticationEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }
  }
}
