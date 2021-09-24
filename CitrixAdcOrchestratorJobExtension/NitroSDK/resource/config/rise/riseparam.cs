// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.rise.riseparam
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.rise
{
  public class riseparam : base_resource
  {
    private string directmodeField = (string) null;
    private string indirectmodeField = (string) null;

    public string directmode
    {
      get => this.directmodeField;
      set => this.directmodeField = value;
    }

    public string indirectmode
    {
      get => this.indirectmodeField;
      set => this.indirectmodeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      riseparam[] riseparamArray = new riseparam[1];
      riseparam.riseparam_response riseparamResponse = new riseparam.riseparam_response();
      riseparam.riseparam_response resource = (riseparam.riseparam_response) service.get_payload_formatter().string_to_resource(riseparamResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      riseparamArray[0] = resource.riseparam;
      return (base_resource[]) riseparamArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, riseparam resource) => new riseparam()
    {
      directmode = resource.directmode,
      indirectmode = resource.indirectmode
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      riseparam resource,
      string[] args)
    {
      return new riseparam().unset_resource(client, args);
    }

    public static riseparam get(nitro_service service) => ((riseparam[]) new riseparam().get_resources(service, (options) null))[0];

    public static riseparam get(nitro_service service, options option) => ((riseparam[]) new riseparam().get_resources(service, option))[0];

    private class riseparam_response : base_response
    {
      public riseparam riseparam = (riseparam) null;
    }

    public static class directmodeEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class indirectmodeEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
